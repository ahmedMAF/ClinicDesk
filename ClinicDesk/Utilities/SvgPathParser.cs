using System.Drawing.Drawing2D;
using System.Globalization;

namespace ClinicDesk.Utilities;

public static class SvgPathParser
{
    public static float Scale { get; set; } = 1f;

    public static List<GraphicsPath> ParseMultiplePaths(ReadOnlySpan<char> data)
    {
        List<GraphicsPath> paths = [];
        int start = 0;
        
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == '\n' || data[i] == '\r')
            {
                ReadOnlySpan<char> line = data.Slice(start, i - start).Trim();
                
                if (!line.IsEmpty)
                    paths.Add(ParsePath(line));
    
                // Skip \r\n or lone \r
                if (data[i] == '\r' && i + 1 < data.Length && data[i + 1] == '\n')
                    i++;
                
                start = i + 1;
            }
        }
    
        // Handle last line (if no newline at end)
        if (start < data.Length)
        {
            ReadOnlySpan<char> line = data.Slice(start).Trim();
            
            if (!line.IsEmpty)
                paths.Add(ParsePath(line));
        }
    
        return paths;
    }

    public static GraphicsPath ParsePath(ReadOnlySpan<char> svgPath)
    {
        GraphicsPath path = new();
        SvgTokenizer tokenizer = new(svgPath);

        PointF startPoint = default;
        PointF lastPoint = default;

        while (tokenizer.MoveNext())
        {
            char command = tokenizer.CurrentCommand;
            
            switch (command)
            {
                case 'M':
                    float x = tokenizer.ReadFloat() * Scale;
                    float y = tokenizer.ReadFloat() * Scale;
                    lastPoint = new PointF(x, y);
                    startPoint = lastPoint;
                    break;

                case 'C':
                    while (tokenizer.HasMore && tokenizer.PeekIsNumber())
                    {
                        PointF p1 = new(tokenizer.ReadFloat() * Scale, tokenizer.ReadFloat() * Scale);
                        PointF p2 = new(tokenizer.ReadFloat() * Scale, tokenizer.ReadFloat() * Scale);
                        PointF p3 = new(tokenizer.ReadFloat() * Scale, tokenizer.ReadFloat() * Scale);

                        path.AddBezier(lastPoint, p1, p2, p3);
                        lastPoint = p3;
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
