using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.DataStructures
{
    public class GridCell
    {
        public int RowIndex { get; set; } = -1;
        public int ColumneIndex { get; set; } = -1;
        public object? Value { get; set; }

        public GridCell()
        {

        }

        public GridCell(object Value, int RowIndex, int ColumnIndex)
        {
            this.Value = Value;
            this.RowIndex = RowIndex;
            this.ColumneIndex = ColumnIndex;
        }
    }
}
