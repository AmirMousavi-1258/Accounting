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
    }
}
