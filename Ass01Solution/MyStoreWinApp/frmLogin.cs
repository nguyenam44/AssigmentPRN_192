using BusinessObject;
using DataAccess.Repository;
using Nancy.Json;
using System;
using System.IO;
using System.Windows.Forms;
namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        private TextBox txtEmail;
        private Label lbEmail;
        private Label lbPassword;
        private Label lbLogin;
        private Button btnLog;
        private Button btnCancel;
        private TextBox txtPassword;

        private MemberRepository memberRepository = new MemberRepository();

        public frmLogin()
        {
            InitializeComponent();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void Login_Click(object sender, EventArgs e)
        {
            string json = string.Empty;

            using (StreamReader reader = new StreamReader("appsettings.json"))
            {
                json = reader.ReadToEnd();
            }
            JavaScriptSerializer jss = new JavaScriptSerializer();
            // convert json string to dynamic type
            var obj = jss.Deserialize<dynamic>(json);
            // get contents

            var admin = new MemberObject
            {
                Email = obj["DefaultAccount"]["Email"],
                Password = obj["DefaultAccount"]["password"]
            };

            var members = memberRepository.GetMembers();
            bool canLog = false;
            foreach (var i in members)
            {
                if (i.Email.Equals(txtEmail.Text) && i.Password.Equals(txtPassword.Text))
                {
                    frmMemberManagements frm = new frmMemberManagements()
                    {
                        isAdmin = false,
                        email = txtEmail.Text,
                    };
                    frm.ShowDialog();
                    canLog = true;
                    this.Close();


                }
                else if (admin.Email.Equals(txtEmail.Text) && admin.Password.Equals(txtPassword.Text))
                {
                    frmMemberManagements frm = new frmMemberManagements()
                    {
                        isAdmin = true
                    };
                    frm.ShowDialog();

                    this.Close();


                }

            }
            if (canLog == false)
            {
                MessageBox.Show("Wrong Email or Password. Please try again!", "Error");
            }

        }
        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void lbLogin_Click(object sender, EventArgs e)
        {

        }
    }
}