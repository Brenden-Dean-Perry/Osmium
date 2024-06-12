using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osmium
{
    public class Config
    {
        public Color BackColor { get; set; } = Color.FromArgb(15, 15, 15);
        public Color BackColor2 { set; get; } = Color.FromArgb(20, 20, 20);
        public Color TextForeColor { get; set; } = Color.White;
    }
}
