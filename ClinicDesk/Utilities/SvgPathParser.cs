using System.Drawing.Drawing2D;
using System.Globalization;

namespace ClinicDesk.Utilities;

/// <summary>
///  An allocation-free SVG to GDI path parser that supports the commands: <c>M, C, Q, L, V, H, Z</c> in relative and absolute coordinates
///  and with or without path command repeating.
/// </summary>
public static class SvgPathParser
{
    public static List<GraphicsPath> ParseMultiplePaths(ReadOnlySpan<char> data, PointF? scale = null, PointF? offset = null)
    {
        List<GraphicsPath> paths = [];
        int start = 0;
        
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == '\n' || data[i] == '\r')
            {
                ReadOnlySpan<char> line = data.Slice(start, i - start).Trim();
                
                if (!line.IsEmpty)
                    paths.Add(ParsePath(line, scale, offset));
    
                // Skip \r in Windows-Style new line.
                if (data[i] == '\r' && i + 1 < data.Length && data[i + 1] == '\n')
                    i++;
                
                // Skip \n in Unix-Style and Windows-Style new line or \r in Mac-Style new line.
                start = i + 1;
            }
        }
    
        // Handle last line (if no newline at end).
        if (start < data.Length)
        {
            ReadOnlySpan<char> line = data.Slice(start).Trim();
            
            if (!line.IsEmpty)
                paths.Add(ParsePath(line, scale, offset));
        }
    
        return paths;
    }

    public static GraphicsPath ParsePath(ReadOnlySpan<char> svgPath, PointF? scale = null, PointF? offset = null)
    {
        GraphicsPath path = new();
        SvgTokenizer tokenizer = new(svgPath);

        PointF startPoint = default;
        PointF lastPoint = default;
        
        PointF s = scale ?? new PointF(1f, 1f);
        PointF o = offset ?? default;

        while (tokenizer.MoveNext())
        {
            char command = tokenizer.CurrentCommand;
            bool isRelative = char.IsLower(command);
            
            // Determine the base point for relative commands.
            PointF basePoint = isRelative ? lastPoint : default;

            // Convert command to uppercase for processing.
            switch (char.ToUpper(command))
            {
                case 'M':
                    lastPoint = new PointF(basePoint.X + tokenizer.ReadFloat() * s.X + o.X,
                        basePoint.Y + tokenizer.ReadFloat() * s.Y + o.Y);
                    startPoint = lastPoint;
                    break;
                    
                case 'L':
                    while (tokenizer.IsCommandRepeated)
                    {
                        PointF p1 = new(basePoint.X + tokenizer.ReadFloat() * s.X + o.X,
                            basePoint.Y + tokenizer.ReadFloat() * s.Y + o.Y);
                            
                        path.AddLine(lastPoint, p1);
                        lastPoint = p1;
                    }
                    break;

                case 'C':
                    while (tokenizer.IsCommandRepeated)
                    {
                        PointF p1 = new(basePoint.X + tokenizer.ReadFloat() * s.X + o.X,
                            basePoint.Y + tokenizer.ReadFloat() * s.Y + o.Y);
                        PointF p2 = new(basePoint.X + tokenizer.ReadFloat() * s.X + o.X,
                            basePoint.Y + tokenizer.ReadFloat() * s.Y + o.Y);
                        PointF p3 = new(basePoint.X + tokenizer.ReadFloat() * s.X + o.X,
                            basePoint.Y + tokenizer.ReadFloat() * s.Y + o.Y);

                        path.AddBezier(lastPoint, p1, p2, p3);
                        lastPoint = p3;
                    }
                    break;
                    
                case 'Q':
                    while (tokenizer.IsCommandRepeated)
                    {
                        PointF p1 = new(basePoint.X + tokenizer.ReadFloat() * s.X + o.X,
                            basePoint.Y + tokenizer.ReadFloat() * s.Y + o.Y);
                        PointF p2 = new(basePoint.X + tokenizer.ReadFloat() * s.X + o.X,
                            basePoint.Y + tokenizer.ReadFloat() * s.Y + o.Y);

                        // Quadratic Bezier curve approximation using cubic Bezier.
                        PointF c1 = new(
                            lastPoint.X + (2f / 3f) * (p1.X - lastPoint.X),
                            lastPoint.Y + (2f / 3f) * (p1.Y - lastPoint.Y)
                        );

                        PointF c2 = new(
                            p2.X + (2f / 3f) * (p1.X - p2.X),
                            p2.Y + (2f / 3f) * (p1.Y - p2.Y)
                        );

                        path.AddBezier(lastPoint, c1, c2, p2);

                        lastPoint = p2;
                    }
                    break;

                case 'H':
                    while (tokenizer.IsCommandRepeated)
                    {
                        float x = basePoint.X + tokenizer.ReadFloat() * s.X + o.X;
                        // Maintain the current Y coordinate.
                        PointF p1 = new(x, lastPoint.Y);
                        
                        path.AddLine(lastPoint, p1);
                        lastPoint = p1;
                    }
                    break;

                case 'V':
                    while (tokenizer.IsCommandRepeated)
                    {
                        float y = basePoint.X + tokenizer.ReadFloat() * s.Y + o.Y;
                        // Maintain the current X coordinate.
                        PointF p1 = new(lastPoint.X, y);
                        
                        path.AddLine(lastPoint, p1);
                        lastPoint = p1;
                    }
                    break;

                case 'Z':
                    path.CloseFigure();
                    lastPoint = startPoint;
                    break;
            }
        }

        return path;
    }

    private ref struct SvgTokenizer
    {
        private ReadOnlySpan<char> _span;
        private int _pos;
        
        public char CurrentCommand { get; private set; }
        
        public bool HasMore => _pos < _span.Length;
        public bool IsCommandRepeated => HasMore && PeekIsNumber();
        
        public SvgTokenizer(ReadOnlySpan<char> span)
        {
            _span = span;
            SkipWhitespace();
        }

        public bool MoveNext()
        {
            SkipWhitespace();
            
            if (_pos >= _span.Length)
                return false;

            CurrentCommand = _span[_pos++];
            SkipWhitespace();
            
            return true;
        }

        public float ReadFloat()
        {
            SkipWhitespace();
            
            int start = _pos;
            
            while (_pos < _span.Length && (char.IsDigit(_span[_pos]) || _span[_pos] is '.' or '-' or 'e' or 'E' or '+'))
                _pos++;

            ReadOnlySpan<char> numberSpan = _span.Slice(start, _pos - start);
            SkipCommaWhitespace();
            
            return float.Parse(numberSpan, CultureInfo.InvariantCulture);
        }

        public bool PeekIsNumber()
        {
            int pos = _pos;
            
            while (pos < _span.Length && char.IsWhiteSpace(_span[pos]))
                pos++;
            
            if (_pos >= _span.Length)
                return false;

            char c = _span[_pos];
            return char.IsDigit(c) || c == '-' || c == '+';
        }

        private void SkipWhitespace()
        {
            while (_pos < _span.Length && char.IsWhiteSpace(_span[_pos]))
                _pos++;
        }

        private void SkipCommaWhitespace()
        {
            while (_pos < _span.Length && (_span[_pos] == ',' || char.IsWhiteSpace(_span[_pos])))
                _pos++;
        }
    }
}
