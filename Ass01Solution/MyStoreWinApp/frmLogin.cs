namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLogin
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}