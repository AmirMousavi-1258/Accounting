using Accounting.App.Customers;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frm = new frmCustomers();
            frm.ShowDialog();
        }

        private void BtnNewAcounting_Click(object sender, EventArgs e)
        {
            frmNewTransaction frm = new frmNewTransaction();
            frm.ShowDialog();
        }

        private void tsbBuys_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.TypeID = 2;
            frm.ShowDialog();
        }

        private void tsbRecieves_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.TypeID = 1;
            frm.ShowDialog();
        }
    }
}
