using ClinicDesk.Database.Dto;
using ClinicDesk.Database.Models;

namespace ClinicDesk.ControlHelpers;

public class VisitsGrid : GridButtonHelper
{
    private Patient _patient = null!;
    private int? _originalVisitId;
    private bool _isShowingOneVisit;
    private List<VisitDto> _visits;

    public VisitsGrid(DataGridView grd) : base(grd, null!)
    {
        ColumnActions = new Dictionary<string, Action<int>>
        {
            ["showBtn"] = showBtn_Click
        };
        
        SetupVisitsDataGrid();
    }
    
    private void SetupVisitsDataGrid()
    {
        Utils.SetupDataGrid(Grid);
        
        Grid.CellFormatting += Grid_CellFormatting;
        Grid.CellPainting += Grid_CellPainting;

        Grid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 50,
            DataPropertyName = "Serial",
            HeaderText = "No."
        });

        Grid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 200,
            DataPropertyName = "CheckInAt",
            HeaderText = "Date",
            DefaultCellStyle = { Format = "dd-MM-yyyy hh:mm tt" }
        });

        Grid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 300,
            DataPropertyName = "Diagnosis",
            HeaderText = "Diagnosis"
        });

        Grid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 300,
            DataPropertyName = "Treatment",
            HeaderText = "Treatment"
        });

        Grid.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "showBtn",
            Width = 120,
            HeaderText = "",
            UseColumnTextForButtonValue = false
        });
    }
    
    private void showBtn_Click(int rowIndex)
    {
        VisitDto visit = _visits[rowIndex];

        if (IsButtonDisabled(rowIndex, visit))
            return;

        _originalVisitId = rowIndex == 0 && _isShowingOneVisit ? null : visit.Id;
        PopulateGrid();
    }

    private void Grid_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.ColumnIndex == -1 || e.RowIndex == -1)
           return;

        // Disable the buttons on visits with no followups and on followups themselves.
        if (Grid.Columns[e.ColumnIndex].Name == "showBtn" && IsButtonDisabled(e.RowIndex, _visits[e.RowIndex]))
        {
            e.PaintBackground(e.CellBounds, true);
            e.Handled = true;
        }
    }
    
    private void Grid_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex == -1 || Grid.Columns[e.ColumnIndex].Name != "showBtn")
            return;

        Grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _isShowingOneVisit ? "Back" : "Show Followups";
    }

    private bool IsButtonDisabled(int rowIndex, VisitDto visit)
    {
        return (!_isShowingOneVisit && visit.FollowUpsCount == 0) ||
            (_isShowingOneVisit && rowIndex != 0);
    }

    public void RefreshList(int? originalVisitId, Patient patient)
    {
        _patient = patient;
        _originalVisitId = originalVisitId;
        
        PopulateGrid();
    }
    
    private void PopulateGrid()
    {
        _isShowingOneVisit = _originalVisitId != null;
        
        _visits = _patient.Visits
            .Where(v => v.OriginalVisitId == _originalVisitId)
            .Select(v => new VisitDto
            {
                Id = v.Id,
                CheckInAt = v.CheckInAt,
                Type = v.Type,
                Diagnosis = v.Diagnosis,
                Treatment = v.Treatment,
                FollowUpsCount = v.FollowUps.Count
            })
            .ToList();

        // For the backward row
        if (_isShowingOneVisit)
        {
            // Show original visit.
            VisitDto? orgVisit = _patient.Visits
                .Select(v => new VisitDto
                {
                    Id = v.Id,
                    CheckInAt = v.CheckInAt,
                    Type = v.Type,
                    Diagnosis = v.Diagnosis,
                    Treatment = v.Treatment,
                })
                .FirstOrDefault(v => v.Id == _originalVisitId);

            _visits.Insert(0, orgVisit!);

            for (int i = 1; i < _visits.Count; i++)
                _visits[i].Serial = i;
        }
        else
        {
            for (int i = 0; i < _visits.Count; i++)
                _visits[i].Serial = i + 1;
        }

        Grid.DataSource = _visits;
        
        // Set a special color for the original visit.
        if (_isShowingOneVisit)
            Grid.Rows[0].DefaultCellStyle.BackColor = Color.LightBlue;
    }
}
