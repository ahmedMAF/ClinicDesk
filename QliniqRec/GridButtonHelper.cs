using Microsoft.EntityFrameworkCore;
using QliniqRec.Database;
using QliniqRec.Database.Dto;
using QliniqRec.Database.Models;
using ReaLTaiizor.Forms;
using System.Windows.Forms;

namespace QliniqRec;

public class GridButtonHelper
{
    private readonly DataGridView _grd;
    private readonly Dictionary<string, Action<int>> _columnActions;
    
    public GridButtonHelper(DataGridView grd, Dictionary<string, Action<int>> columnActions)
    {
        _grd = grd;
        _columnActions = columnActions;
        
        grd.CellClick += Grd_CellClick;
    }
    
    private void Grd_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1 || e.ColumnIndex == -1 || appointmentsGrd.Columns[e.ColumnIndex] is not DataGridViewButtonColumn)
            return;
            
        string colName = appointmentsGrd.Columns[e.ColumnIndex].Name;
        _columnActions[colName](e.RowIndex);
    }
}
