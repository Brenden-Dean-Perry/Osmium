using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneralClassLibrary;

namespace Osmium.Views
{
    public partial class MarketAccess : Form
    {
        public MarketAccess()
        {
            InitializeComponent();
        }

        private void btn_Refesh_Click(object sender, EventArgs e)
        {
             AlphaVantageAPI api = new AlphaVantageAPI("demo");
            Dictionary<string, dynamic> results = api.GetTickerSearchResults("AP");
            textBox_Test.Text = results.ToList()[0].Value.ToString();
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
