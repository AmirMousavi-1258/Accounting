using Accounting.App.Customers;
using Accounting.Business.Account;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.utility;
using Accounting.ViewModels.Report;
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
        public int userID = 0;
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
            frm.loginID = userID;
            frm.ShowDialog();
        }

        private void tsbBuys_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.LoginID = userID;
            frm.TypeID = 2;
            frm.ShowDialog();
        }

        private void tsbRecieves_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.LoginID = userID;
            frm.TypeID = 1;
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = (DateTime.Now).ToShamsi();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            this.Hide();
            frmLogin frmlg = new frmLogin();
            if (frmlg.ShowDialog() == DialogResult.OK)
            {
                userID = frmlg.userID;
                Balance();
            }
            else
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void tsLoginData_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.userID = userID;
            frm.isEdit = true;
            this.Hide();
            if (frm.ShowDialog() == DialogResult.OK) { Application.Restart(); }
            else { }

        }

        public void Balance()
        {
            ReportViewModel RP = ReportBalance.ReportForMainForm(userID);
            lblBalanceAccount.Text = RP.Total.ToString("#,0");
            lblPay.Text = RP.Pay.ToString("#,0");
            lblRecieve.Text = RP.Recieve.ToString("#,0");
        }

        private void BtnRfrsh_Click(object sender, EventArgs e)
        {
            Balance();
        }
    }
}
