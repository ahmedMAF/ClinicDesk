namespace ClinicDesk.ControlHelpers;

public class GridButtonHelper
{
    protected readonly DataGridView Grid;
    protected Dictionary<string, Action<int>> ColumnActions;
    
    public GridButtonHelper(DataGridView grd, Dictionary<string, Action<int>> columnActions)
    {
        Grid = grd;
        ColumnActions = columnActions;
        
        Grid.CellClick += Grid_CellClick;
    }
    
    private void Grid_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1 || e.ColumnIndex == -1 || Grid.Columns[e.ColumnIndex] is not DataGridViewButtonColumn)
            return;
            
        string colName = Grid.Columns[e.ColumnIndex].Name;
        ColumnActions[colName](e.RowIndex);
    }
}
