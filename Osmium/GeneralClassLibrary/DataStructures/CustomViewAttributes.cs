using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary.Enums;

namespace BusinessLogicLibrary.DataStructures
{
    public class CustomViewAttributes : Attribute
    {
        public ViewDataFormat Format { get; set; } = ViewDataFormat.None;
        public ViewForeColorSelectionType ForeColorType { get; set; } = ViewForeColorSelectionType.None;
        public string ToolTipHeaderDescription { get; set; } = String.Empty;
        public bool IsEditable { get; set; } = false;
        public bool AlternativeColumnColor { get; set; } = false;
        public bool IsColumnVisble { get; set; } = true;
    }
}
