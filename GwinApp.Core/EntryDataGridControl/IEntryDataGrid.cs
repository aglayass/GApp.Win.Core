using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GApp.Win.EntryDataGridControl
{
 
    public interface  IEntryDataGrid
    {
        event EventHandler DataChanged;
        string Title { set; get; }
        DataGridView EntityDataGridView { set; get; }
        BindingSource BindingSource { set; get; }
        List<object> DataSource { set; get; }
        int Width { get; set; }
        int Height { get; set; }
    }
}
