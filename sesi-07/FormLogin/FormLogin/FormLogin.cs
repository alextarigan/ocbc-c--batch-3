using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class FormLogin : Form
    {
        Config db = new Config();
        public FormLogin()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM user_info where username='" + txtUser.Text + "' and pasword ='" + txtPassword.Text+"'");

            if(db.Count() == 1)
            {
                MessageBox.Show("Sukses, kamu berhasil login sebagai" + db.Results(0, "names"));
            }
            else
            {
                MessageBox.Show("Username atau Password yang dimasukkan salah");
            }
        }
    }
}
