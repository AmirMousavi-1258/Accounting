namespace Accounting.App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsLoginData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BtnCustomers = new System.Windows.Forms.ToolStripButton();
            this.BtnNewAcounting = new System.Windows.Forms.ToolStripButton();
            this.tsbBuys = new System.Windows.Forms.ToolStripButton();
            this.tsbRecieves = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBalanceAccount = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblRecieve = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRfrsh = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLoginData});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(78, 24);
            this.toolStripDropDownButton1.Text = "تنظیمات";
            // 
            // tsLoginData
            // 
            this.tsLoginData.Name = "tsLoginData";
            this.tsLoginData.Size = new System.Drawing.Size(195, 26);
            this.tsLoginData.Text = "اطلاعات شخصی";
            this.tsLoginData.Click += new System.EventHandler(this.tsLoginData_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCustomers,
            this.BtnNewAcounting,
            this.tsbBuys,
            this.tsbRecieves,
            this.BtnRfrsh});
            this.toolStrip2.Location = new System.Drawing.Point(0, 27);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(782, 67);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("BtnCustomers.Image")));
            this.BtnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(90, 64);
            this.BtnCustomers.Text = "طرف حساب";
            this.BtnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // BtnNewAcounting
            // 
            this.BtnNewAcounting.Image = global::Accounting.App.Properties.Resources._1371476499_todo_list;
            this.BtnNewAcounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnNewAcounting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNewAcounting.Name = "BtnNewAcounting";
            this.BtnNewAcounting.Size = new System.Drawing.Size(92, 64);
            this.BtnNewAcounting.Text = "تراکنش جدید";
            this.BtnNewAcounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNewAcounting.Click += new System.EventHandler(this.BtnNewAcounting_Click);
            // 
            // tsbBuys
            // 
            this.tsbBuys.Image = global::Accounting.App.Properties.Resources.servicesCosts;
            this.tsbBuys.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBuys.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuys.Name = "tsbBuys";
            this.tsbBuys.Size = new System.Drawing.Size(110, 64);
            this.tsbBuys.Text = "گزارش پرداختیها";
            this.tsbBuys.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBuys.Click += new System.EventHandler(this.tsbBuys_Click);
            // 
            // tsbRecieves
            // 
            this.tsbRecieves.Image = global::Accounting.App.Properties.Resources._1370791030_credit_card;
            this.tsbRecieves.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRecieves.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecieves.Name = "tsbRecieves";
            this.tsbRecieves.Size = new System.Drawing.Size(111, 64);
            this.tsbRecieves.Text = "گزارش دریافتیها";
            this.tsbRecieves.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRecieves.Click += new System.EventHandler(this.tsbRecieves_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime,
            this.lblDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(42, 20);
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 20);
            this.lblDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting.App.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBalanceAccount);
            this.groupBox1.Controls.Add(this.lblPay);
            this.groupBox1.Controls.Add(this.lblRecieve);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(442, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 131);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش کلی";
            // 
            // lblBalanceAccount
            // 
            this.lblBalanceAccount.Location = new System.Drawing.Point(6, 97);
            this.lblBalanceAccount.Name = "lblBalanceAccount";
            this.lblBalanceAccount.Size = new System.Drawing.Size(199, 21);
            this.lblBalanceAccount.TabIndex = 5;
            this.lblBalanceAccount.Text = "0";
            // 
            // lblPay
            // 
            this.lblPay.Location = new System.Drawing.Point(6, 69);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(199, 21);
            this.lblPay.TabIndex = 4;
            this.lblPay.Text = "0";
            // 
            // lblRecieve
            // 
            this.lblRecieve.Location = new System.Drawing.Point(6, 38);
            this.lblRecieve.Name = "lblRecieve";
            this.lblRecieve.Size = new System.Drawing.Size(199, 21);
            this.lblRecieve.TabIndex = 3;
            this.lblRecieve.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "مجموع :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "پرداخت ها :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "دریافت ها :";
            // 
            // BtnRfrsh
            // 
            this.BtnRfrsh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRfrsh.Image = global::Accounting.App.Properties.Resources._1371476342_Refresh;
            this.BtnRfrsh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRfrsh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRfrsh.Name = "BtnRfrsh";
            this.BtnRfrsh.Size = new System.Drawing.Size(44, 64);
            this.BtnRfrsh.Text = "toolStripButton1";
            this.BtnRfrsh.Click += new System.EventHandler(this.BtnRfrsh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری شخصی من";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BtnCustomers;
        private System.Windows.Forms.ToolStripButton BtnNewAcounting;
        private System.Windows.Forms.ToolStripButton tsbBuys;
        private System.Windows.Forms.ToolStripButton tsbRecieves;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem tsLoginData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalanceAccount;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblRecieve;
        private System.Windows.Forms.ToolStripButton BtnRfrsh;
    }
}

