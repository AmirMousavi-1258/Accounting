using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App.Customers
{
    public partial class frmReport : Form
    {
        public int TypeID = 0;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            if (TypeID == 2)
            {
                this.Text = "گزارش پرداختیها";
            }
            else if (TypeID == 1)
            {
                this.Text = "گزارش دریافتیها";
            }
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            Filter();
        }
        void Filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                var result = db.AccountingRepository.get(a => a.TypeID == TypeID);
                dgvReports.AutoGenerateColumns = false;
                dgvReports.Rows.Clear();
                foreach (var report in result)
                {
                    string customerName = db.CustomerRepository.GetCustomerNameByID(report.CostumerID);
                    dgvReports.Rows.Add(report.ID, customerName, report.Amount, report.DateTime.ToShamsi());
                }
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            using(UnitOfWork db = new UnitOfWork())
            {
            if(dgvReports.CurrentRow != null)
            {
                    if (MessageBox.Show("ایا از حذف این مطمین هستید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int id = int.Parse(dgvReports.CurrentRow.Cells[0].Value.ToString());
                        db.AccountingRepository.Delete(id);
                        db.Save();
                        Filter();
                    }
            }

            }
        }
    }
}
