namespace TicariOtomasyon.DesktopUI.Formlar
{
    partial class MailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.mailTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.konuTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.mesajTxt = new System.Windows.Forms.RichTextBox();
            this.mailGonderBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.mailTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konuTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mail :";
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(70, 13);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Properties.Appearance.Options.UseTextOptions = true;
            this.mailTxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mailTxt.Properties.ReadOnly = true;
            this.mailTxt.Size = new System.Drawing.Size(208, 20);
            this.mailTxt.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Konu :";
            // 
            // konuTxt
            // 
            this.konuTxt.Location = new System.Drawing.Point(70, 51);
            this.konuTxt.Name = "konuTxt";
            this.konuTxt.Properties.Appearance.Options.UseTextOptions = true;
            this.konuTxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.konuTxt.Size = new System.Drawing.Size(208, 20);
            this.konuTxt.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mesaj :";
            // 
            // mesajTxt
            // 
            this.mesajTxt.Location = new System.Drawing.Point(67, 99);
            this.mesajTxt.Name = "mesajTxt";
            this.mesajTxt.Size = new System.Drawing.Size(211, 175);
            this.mesajTxt.TabIndex = 2;
            this.mesajTxt.Text = "";
            // 
            // mailGonderBtn
            // 
            this.mailGonderBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.mailGonderBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.mailGonderBtn.Location = new System.Drawing.Point(126, 280);
            this.mailGonderBtn.Name = "mailGonderBtn";
            this.mailGonderBtn.Size = new System.Drawing.Size(103, 71);
            this.mailGonderBtn.TabIndex = 3;
            this.mailGonderBtn.Text = "Maili Gönder";
            this.mailGonderBtn.Click += new System.EventHandler(this.mailGonderBtn_Click);
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 370);
            this.Controls.Add(this.mailGonderBtn);
            this.Controls.Add(this.mesajTxt);
            this.Controls.Add(this.konuTxt);
            this.Controls.Add(this.mailTxt);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "MailForm";
            this.Text = "Mail Gönderme Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.mailTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konuTxt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit mailTxt;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit konuTxt;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.RichTextBox mesajTxt;
        private DevExpress.XtraEditors.SimpleButton mailGonderBtn;
    }
}