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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BtnCustomers = new System.Windows.Forms.ToolStripButton();
            this.BtnNewAcounting = new System.Windows.Forms.ToolStripButton();
            this.tsbRecieves = new System.Windows.Forms.ToolStripButton();
            this.tsbBuys = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
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
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(78, 24);
            this.toolStripDropDownButton1.Text = "تنظیمات";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCustomers,
            this.BtnNewAcounting,
            this.tsbBuys,
            this.tsbRecieves});
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
            this.BtnNewAcounting.Image = global::Accounting.App.Properties.Resources._1370791030_credit_card;
            this.BtnNewAcounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnNewAcounting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNewAcounting.Name = "BtnNewAcounting";
            this.BtnNewAcounting.Size = new System.Drawing.Size(92, 64);
            this.BtnNewAcounting.Text = "تراکنش جدید";
            this.BtnNewAcounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNewAcounting.Click += new System.EventHandler(this.BtnNewAcounting_Click);
            // 
            // tsbRecieves
            // 
            this.tsbRecieves.Image = global::Accounting.App.Properties.Resources.servicesCosts;
            this.tsbRecieves.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRecieves.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecieves.Name = "tsbRecieves";
            this.tsbRecieves.Size = new System.Drawing.Size(111, 64);
            this.tsbRecieves.Text = "گزارش دریافتیها";
            this.tsbRecieves.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRecieves.Click += new System.EventHandler(this.tsbRecieves_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری شخصی من";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
    }
}

