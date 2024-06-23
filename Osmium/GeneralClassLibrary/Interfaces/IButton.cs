using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClassLibrary.Interfaces
{
    public interface IButton
    {
        string GetItemText();
        bool IsEnabled();
        void ItemClicked(object sender, EventArgs e);
    }
}
