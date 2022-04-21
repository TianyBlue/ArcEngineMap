using System;
using System.Windows.Forms;

namespace ArcEngineMap
{
    public partial class LoginForm : Form
    {
        private MainForm parent;
        private string username = string.Empty;
        private string password = string.Empty;
        public LoginForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            username = usernameTextBox.Text;
            password = passwordTextBox.Text;
            if (username == string.Empty || password == string.Empty)
                MessageBox.Show("请正确输入账号密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                parent.Login(username, password);
                this.Hide();
                this.Dispose();
            }
                
        }

        private void SkipLoginBtn_Click(object sender, EventArgs e)
        {
            parent.SkipLogin();
            this.Hide();
            this.Dispose();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
