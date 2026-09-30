using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.utility;
using Accounting.ViewModels.Costumers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App.Customers
{
    public partial class frmReport : Form
    {
        public int TypeID = 0;
        public int LoginID = 0;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ListCustomerViewModel> list = new List<ListCustomerViewModel>();
                list.Add(new ListCustomerViewModel()
                {
                    CustomerID = 0,
                    FullName = "انتخاب کنید"
                });
                list.AddRange(db.CustomerRepository.GetNames());
                cboCustomer.DataSource = list;
                cboCustomer.DisplayMember = "FullName";
                cboCustomer.ValueMember = "CustomerID";
            }
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
                List<DataLayer.Accounting> result = new List<DataLayer.Accounting>();
                DateTime? startDate;
                DateTime? EndDate;
                if ((int)cboCustomer.SelectedValue != 0)
                {
                    int id = int.Parse(cboCustomer.SelectedValue.ToString());
                    result.AddRange(db.AccountingRepository.get(a => a.TypeID == TypeID && a.CostumerID == id&&a.LoginID == LoginID));
                }
                else
                {
                    result.AddRange(db.AccountingRepository.get(a => a.TypeID == TypeID&&a.LoginID == LoginID));
                }
                if(msSinceDate.Text != "    /  /")
                {
                    startDate = Convert.ToDateTime(msSinceDate.Text);
                    startDate = DateConvertor.ToMiladi(startDate.Value);
                    //startDate = startDate.Value.ToMiladi();
                    result = result.Where(r => r.DateTime >= startDate.Value).ToList();
                }
                if(msForDate.Text != "    /  /")
                {
                    EndDate = Convert.ToDateTime(msForDate.Text);
                    EndDate = DateConvertor.ToMiladi(EndDate.Value);
                    //EndDate = EndDate.Value.ToMiladi();
                    result = result.Where(r => r.DateTime <= EndDate.Value).ToList();

                }
                dgvReports.AutoGenerateColumns = false;
                dgvReports.Rows.Clear();
                foreach (var report in result)
                {
                    string customerName = db.CustomerRepository.GetCustomerNameByID(report.CostumerID);
                    DataGridViewRow row = new DataGridViewRow();
                    
                    dgvReports.Rows.Add(report.ID,customerName,report.Amount,report.DateTime,report.Description);
                }
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (dgvReports.CurrentRow != null)
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dgvReports.CurrentRow != null)
            {
                int id = int.Parse(dgvReports.CurrentRow.Cells[0].Value.ToString());
                frmNewTransaction frm = new frmNewTransaction();
                frm.AccountID = id;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void msSinceDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("Customer");
            dtPrint.Columns.Add("Amount");
            dtPrint.Columns.Add("Date");
            dtPrint.Columns.Add("Discription");
            foreach (DataGridViewRow itm in dgvReports.Rows)
            {
                dtPrint.Rows.Add(
                    itm.Cells[1].Value.ToString(),
                    itm.Cells[2].Value.ToString(),
                    itm.Cells[3].Value.ToString(),
                    itm.Cells[4].Value.ToString());
            }
            stiReport1.Load(Application.StartupPath + "/Report.mrt");
            stiReport1.RegData("Dt",dtPrint);
            stiReport1.Show();
        }
    }
}
