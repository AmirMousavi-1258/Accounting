using Accounting.App.Customers;
using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        void BindGrid()
        {
            using (UnitOfWork un = new UnitOfWork())
            {
                dgwCustomers.AutoGenerateColumns = false;
                dgwCustomers.DataSource = un.CustomerRepository.GetAllCustomers();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            BindGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using(UnitOfWork db = new UnitOfWork())
            {
                dgwCustomers.DataSource=db.CustomerRepository.getCustomerByFilter(txtSearch.Text);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dgwCustomers.CurrentCell != null)
            {
                using(UnitOfWork db = new UnitOfWork())
                {
                    string customerName = dgwCustomers.CurrentRow.Cells[1].Value.ToString();
                    if(MessageBox.Show($"آیا از حذف {customerName} راضی هستید؟","توجه",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    int customerId = int.Parse(dgwCustomers.CurrentRow.Cells[0].Value.ToString());
                    db.CustomerRepository.DeleteCustomer(customerId);
                    db.Save();
                    BindGrid();

                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا یک ردیف را انتخاب کنید");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frmAdd = new frmAddOrEdit();
            if(frmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(dgwCustomers.CurrentRow != null)
            {
                int customerId= int.Parse(dgwCustomers.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEdit frmEdit = new frmAddOrEdit();
                frmEdit.customerId = customerId;
                if(frmEdit.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }

            }
        }
    }
}
