using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App.Customers
{
    public partial class frmAddOrEdit : Form
    {
        public int customerId = -1;
        UnitOfWork db = new UnitOfWork();
        public frmAddOrEdit()
        {
            InitializeComponent();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pcCustomer.ImageLocation = ofd.FileName;
                MessageBox.Show(pcCustomer.ImageLocation);
            }
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            if(Validation()== true)
            {
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation);
                string path = Application.StartupPath + "/Images/";
                if(!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pcCustomer.Image.Save(path + imageName);
                dbo_Customers cst = new dbo_Customers()
                {
                    FullName = txtName.Text,
                    Moblie = txtMobile.Text,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    CustomerImage = imageName,
                };
                if(customerId == -1)
                {
                db.CustomerRepository.InsertCustomer(cst);
                }
                else
                {
                    cst.CustomerID = customerId;
                    db.CustomerRepository.UpdateCustomer(cst);
                }
                    db.Save();
                DialogResult = DialogResult.OK;
            }
        }
        public bool Validation()
        {
            if (string.IsNullOrEmpty(txtName.Text) )
            {
                MessageBox.Show("Enter Name.");
                return false;
            }
            else if (string.IsNullOrEmpty(txtMobile.Text))
            {
                MessageBox.Show("Enter Mobile.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if(customerId != -1)
            {
                this.Text = "ویرایش شخص";
                btnAdmit.Text = "ویرایش";
                var customer = db.CustomerRepository.GetCustomerById(customerId);
                txtEmail.Text = customer.Email;
                txtAddress.Text = customer.Address;
                txtMobile.Text = customer.Moblie;
                txtName.Text = customer.FullName;
                pcCustomer.ImageLocation = Application.StartupPath + "/Images/"+customer.CustomerImage;
            }
        }
    }
}
