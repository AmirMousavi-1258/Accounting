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
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer;

namespace Accounting.App.Customers
{
    public partial class frmNewTransaction : Form
    {
        UnitOfWork db = new UnitOfWork();
        public frmNewTransaction()
        {
            InitializeComponent();
        }

        private void frmNewTransaction_Load(object sender, EventArgs e)
        {
            dgvCostumers.AutoGenerateColumns = false;
            dgvCostumers.DataSource = db.CustomerRepository.GetNames();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvCostumers.AutoGenerateColumns = false;
            dgvCostumers.DataSource = db.CustomerRepository.GetNames(txtFilter.Text);
        }

        private void dgvCostumers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCostumers.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("یکی از افراد را از درون لیست انتخاب کنید.", "احتیاط");
            }
            else if (rdBuy.Checked == false && rdRecieve.Checked == false)
            {
                MessageBox.Show("یکی از حالت هارا انتخاب کنید", "احتیاط");
            }
            else if (nmtxtCatch.Value == 0 || nmtxtCatch.Value > 9999999)
            {
                MessageBox.Show("مقدار باید بین 1 تا 9999999 باشد", "احتیاط");
            }
            else
            {
                DataLayer.Accounting accounting = new DataLayer.Accounting()
                {
                    Amount = int.Parse(nmtxtCatch.Value.ToString()),
                    CostumerID = db.CustomerRepository.GetCustomerIdByName(txtName.Text),
                    TypeID = (rdBuy.Checked ? 2 : 1),
                    DateTime = DateTime.Now,
                    Description = txtDetails.Text,
                };
                db.AccountingRepository.Insert(accounting);
                db.Save();
                DialogResult = DialogResult.OK;

            }
        }
    }
}
