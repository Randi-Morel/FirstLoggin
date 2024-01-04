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
    public partial class FrmHome : Form
    {

        private Connection connection;

        public FrmHome()
        {
            InitializeComponent();
            string connectionString = "data source=localhost\\SQLEXPRESS;Initial Catalog=DBWin;Integrated Security=True";
            connection = new Connection(connectionString);
        }
        private void FrmHome_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            dataGridView1.DataSource = connection.users();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddHome_Click(object sender, EventArgs e)
        {
            FrmAdd frmAdd = new FrmAdd();
            frmAdd.ShowDialog();
            Refresh();
        }
        private void btnEditHome_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            try
            {
                if (Id != null)
                {
                    FrmAdd frmEdit = new FrmAdd(Id);
                    frmEdit.ShowDialog();
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +  ex.Message);
            }
        }

        private void btnDeleteHome_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                connection.Delete((int)Id);
                Refresh();
            }
        }

        #region HELPER
        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString() );
            }
            catch 
            {
                return null;
            }
        }
        #endregion

    }
}
