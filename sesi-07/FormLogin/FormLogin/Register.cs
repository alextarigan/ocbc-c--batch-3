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
    public partial class Register : Form
    {
        Config db = new Config();
        public Register()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            db.Execute("INSERT INTO user_info (id,names, username,pasword) VALUES (NULL, '" + txtNames.Text + "', '" + txtUsername.Text + "','" + txtPassword.Text + "')");
            MessageBox.Show("Anda Berhasil daftar");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
        }
    }
}




