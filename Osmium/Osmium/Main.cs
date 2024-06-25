using DataAccess;

namespace DesktopUI
{
    public partial class Main : Form
    {
        private UIConfig _config { get; set; }
        private ViewFactory _viewFactory { get; set; }
        private ConfigManager _configManager { get; set; }
        public Main()
        {
            InitializeComponent();
            _config = new UIConfig();
            _viewFactory = new ViewFactory();
            _configManager = new ConfigManager();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SetupDefaultFormatting();
        }

        public void SetupDefaultFormatting()
        {
            this.BackColor = _config.BackColor;
            panel_Menu.BackColor = _config.BackColor2;
            panel_Logo.BackColor = _config.BackColor2;

            foreach(Control control in panel_Menu.Controls)
            {
                if(control is Button)
                {
                    control.BackColor = _config.BackColor2;
                    control.ForeColor = _config.TextForeColor;
                    ((Button)control).FlatStyle = FlatStyle.Flat;
                }
            }
        }

        private void btn_Development_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string file = ofd.FileName;
            string api_Key = File.ReadAllText(file);

            MessageBox.Show(api_Key);
            
            DataAccess.OpenAIAPI ai = new DataAccess.OpenAIAPI(api_Key);
            //MessageBox.Show(ai.GetEmbedding("Say this is a test!"));
        }

        private void btn_MarketAccess_Click(object sender, EventArgs e)
        {
            Form marketAccess = _viewFactory.CreateMarketAccess();
            marketAccess.Show();
        }
    }
}