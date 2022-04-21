using System;
using System.Windows.Forms;
using ESRI.ArcGIS.Controls;

namespace ArcEngineMap
{
    public partial class DataBaseLoginForm : Form
    {
        AxMapControl mapControl;
        MainForm parent;
        public DataBaseLoginForm(AxMapControl mapControl,MainForm form)
        {
            InitializeComponent();
            this.mapControl = mapControl;
            this.parent = form;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            // host格式：ip,port；例如：127.0.0.1,5432
            // 只能连接64位较低版本(如9.2版本)的PG数据库
            // 数据库中只能存在带有geom列的数据表
            string host = DBAddressTextBox.Text;
            string username = UserNameTextBox.Text;
            string pwd = PasswordTextBox.Text;
            string dbname = DBNameTextBox.Text;
            if(host == string.Empty ||username == string.Empty || pwd == string.Empty || dbname == string.Empty)
            {
                MessageBox.Show("请正确输入！");
            }
            else
            {
                parent.CreateDBConnect(host, dbname, username, pwd);
                this.Hide();
                this.Dispose();
            }

        }
    }
}
