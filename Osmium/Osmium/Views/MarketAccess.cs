using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLibrary.Enums;

namespace DesktopUI.Views
{
    public partial class MarketAccess : Form
    {
        public MarketAccess()
        {
            InitializeComponent();
        }

        private void btn_Refesh_Click(object sender, EventArgs e)
        {
           
            DataAccess.AlphaVantageAPI api = new DataAccess.AlphaVantageAPI("demo");
            MessageBox.Show(api.GetPrice("IBM").ToString());
        }

        private void textBox_Test_TextChanged(object sender, EventArgs e)
        {

        }

        private void MarketAccess_Load(object sender, EventArgs e)
        {
            ApplyFormatting();
        }

        private void ApplyFormatting()
        {
            UIConfig config = new UIConfig();

            foreach(Control control in panel_Menu.Controls)
            {
                if(control is Button)
                {
                    control.BackColor = config.BackColor2;
                    control.ForeColor = config.TextForeColor;
                    ((Button)control).FlatStyle = FlatStyle.Flat;
                }
            }
        }
    }
}
