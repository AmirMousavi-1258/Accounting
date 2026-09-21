namespace Accounting.App.Customers
{
    partial class frmNewTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCostumers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdBuy = new System.Windows.Forms.RadioButton();
            this.rdRecieve = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.nmtxtCatch = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.btnAdmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmtxtCatch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCostumers);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اشخاص";
            // 
            // dgvCostumers
            // 
            this.dgvCostumers.AllowUserToAddRows = false;
            this.dgvCostumers.AllowUserToDeleteRows = false;
            this.dgvCostumers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCostumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostumers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvCostumers.Location = new System.Drawing.Point(6, 51);
            this.dgvCostumers.Name = "dgvCostumers";
            this.dgvCostumers.ReadOnly = true;
            this.dgvCostumers.RowHeadersWidth = 51;
            this.dgvCostumers.RowTemplate.Height = 24;
            this.dgvCostumers.Size = new System.Drawing.Size(200, 272);
            this.dgvCostumers.TabIndex = 1;
            this.dgvCostumers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCostumers_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FullName";
            this.Column1.HeaderText = "نام شخص";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(6, 22);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(200, 23);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "طرف حساب :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(230, 12);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(189, 23);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "نوع تراکنش :";
            // 
            // rdBuy
            // 
            this.rdBuy.AutoSize = true;
            this.rdBuy.Location = new System.Drawing.Point(282, 53);
            this.rdBuy.Name = "rdBuy";
            this.rdBuy.Size = new System.Drawing.Size(67, 20);
            this.rdBuy.TabIndex = 4;
            this.rdBuy.TabStop = true;
            this.rdBuy.Text = "پرداخت";
            this.rdBuy.UseVisualStyleBackColor = true;
            // 
            // rdRecieve
            // 
            this.rdRecieve.AutoSize = true;
            this.rdRecieve.Location = new System.Drawing.Point(355, 53);
            this.rdRecieve.Name = "rdRecieve";
            this.rdRecieve.Size = new System.Drawing.Size(64, 20);
            this.rdRecieve.TabIndex = 5;
            this.rdRecieve.TabStop = true;
            this.rdRecieve.Text = "دریافت";
            this.rdRecieve.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "مبلغ:";
            // 
            // nmtxtCatch
            // 
            this.nmtxtCatch.Location = new System.Drawing.Point(230, 89);
            this.nmtxtCatch.Name = "nmtxtCatch";
            this.nmtxtCatch.Size = new System.Drawing.Size(189, 23);
            this.nmtxtCatch.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "شرح:";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(230, 122);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(189, 169);
            this.txtDetails.TabIndex = 9;
            // 
            // btnAdmit
            // 
            this.btnAdmit.Location = new System.Drawing.Point(410, 316);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(87, 25);
            this.btnAdmit.TabIndex = 10;
            this.btnAdmit.Text = "ثبت";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // frmNewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(509, 353);
            this.Controls.Add(this.btnAdmit);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmtxtCatch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdRecieve);
            this.Controls.Add(this.rdBuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewTransaction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تراکنش جدید";
            this.Load += new System.EventHandler(this.frmNewTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmtxtCatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCostumers;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdBuy;
        private System.Windows.Forms.RadioButton rdRecieve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmtxtCatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnAdmit;
    }
}