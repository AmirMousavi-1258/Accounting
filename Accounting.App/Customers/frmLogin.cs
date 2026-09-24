using Accounting.DataLayer;
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

namespace Accounting.App.Customers
{
    public partial class frmLogin : Form
    {
        public bool isEdit = false;
        public int userID = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isEdit) 
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var user = db.Login.GetById(userID);
                    user.UserName = txtUserName.Text;
                    user.Password = txtPassword.Text;
                    db.Login.Update(user);
                    db.Save();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                string username = txtUserName.Text;
                string password = txtPassword.Text;
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("لطفا اطلاعات خود را وارد کنید ");
                }
                else
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                         userID= db.Login.get(u=>u.UserName == username&&u.Password == password).Select(u=>u.LoginID).FirstOrDefault();
                        if (db.Login.get(u => u.UserName == username && u.Password == password).Any())
                        {
                            MessageBox.Show("ورود موفقیت آمیز بود.");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("کاربر یافت نشد!!");

                        }
                    }


                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                this.Text = "ویرایش";
                groupBox1.Text = "ویرایش اطلاعات";
                button1.Text = "ثبت";
                button2.Enabled = false;
                button2.Visible = false;
                using (UnitOfWork db = new UnitOfWork())
                {
                    var user = db.Login.GetById(userID);
                    txtUserName.Text = user.UserName;
                    txtPassword.Text = user.Password;
                }
            }
        }
    }
}
