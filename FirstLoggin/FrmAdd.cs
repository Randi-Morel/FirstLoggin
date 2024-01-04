using FirstLoggin.Models;
using System;
using System.Windows.Forms;
using static FirstLoggin.Models.Connection;

namespace FirstLoggin
{
    public partial class FrmAdd : Form
    {
        private Connection connection;

        private int? Id;

        public FrmAdd( int? Id=null)
        {
            InitializeComponent();
            string connectionString = "data source=localhost\\SQLEXPRESS;Initial Catalog=DBWin;Integrated Security=True";
            connection = new Connection(connectionString);
            this.Id = Id;
            if (this.Id != null )
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            Users users = connection.users(Id);
            txtAddUserName.Text = users.UserName;
            txtAddPassword.Text = users.Password;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Id == null)
                {
                    connection.Add(txtAddUserName.Text, txtAddPassword.Text);
                }
                else
                {
                    connection.Update((int)Id,txtAddUserName.Text, txtAddPassword.Text);
                }
                this.Close();
            }
            catch(Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}
