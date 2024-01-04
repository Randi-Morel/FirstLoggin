using FirstLoggin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstLoggin
{
    public partial class Form1 : Form
    {
        private Connection connection;

        public Form1()
        {
            InitializeComponent();
            string connectionString = "data source=localhost\\SQLEXPRESS;Initial Catalog=DBWin;Integrated Security=True";
            connection = new Connection(connectionString);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if (connection.GetUser(userName,password))
            {
                this.Hide();
                FrmHome frmHome = new FrmHome();
                frmHome.FormClosed += (s,arg) => this.Close();
                frmHome.Show();
            }
            else
            {
                MessageBox.Show("Inicio de sesión fallido. Verifica tus credenciales.");
            }
        }
    }
}


