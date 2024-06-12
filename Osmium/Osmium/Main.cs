namespace Osmium
{
    public partial class Main : Form
    {
        private Config _config { get; set; }
        public Main()
        {
            InitializeComponent();
            _config = new Config();
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
            btn_Development.BackColor = _config.BackColor2;
            btn_KeyManager.BackColor = _config.BackColor2;
            btn_Development.ForeColor = _config.TextForeColor;
            btn_KeyManager.ForeColor = _config.TextForeColor;
            btn_KeyManager.FlatStyle = FlatStyle.Flat;
            btn_Development.FlatStyle = FlatStyle.Flat;
        }

        private void btn_Development_Click(object sender, EventArgs e)
        {
            OpenAIAPI ai = new OpenAIAPI("api_Key");
            MessageBox.Show(ai.GetEmbedding("This is a test!"));
        }
    }
}