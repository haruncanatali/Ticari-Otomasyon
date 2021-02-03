namespace TicariOtomasyon.DesktopUI.Formlar
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.kullaniciSifreTxt = new DevExpress.XtraEditors.TextEdit();
            this.kullaniciAdiTxt = new DevExpress.XtraEditors.TextEdit();
            this.girisYapBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciSifreTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAdiTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(203, 190);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kullanıcı Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(188, 249);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(143, 25);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Kullanıcı Şifre";
            // 
            // kullaniciSifreTxt
            // 
            this.kullaniciSifreTxt.Location = new System.Drawing.Point(377, 254);
            this.kullaniciSifreTxt.Name = "kullaniciSifreTxt";
            this.kullaniciSifreTxt.Properties.Appearance.Options.UseTextOptions = true;
            this.kullaniciSifreTxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.kullaniciSifreTxt.Properties.MaxLength = 12;
            this.kullaniciSifreTxt.Properties.PasswordChar = '*';
            this.kullaniciSifreTxt.Size = new System.Drawing.Size(184, 20);
            this.kullaniciSifreTxt.TabIndex = 1;
            // 
            // kullaniciAdiTxt
            // 
            this.kullaniciAdiTxt.Location = new System.Drawing.Point(377, 192);
            this.kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            this.kullaniciAdiTxt.Properties.Appearance.Options.UseTextOptions = true;
            this.kullaniciAdiTxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.kullaniciAdiTxt.Properties.MaxLength = 12;
            this.kullaniciAdiTxt.Size = new System.Drawing.Size(184, 20);
            this.kullaniciAdiTxt.TabIndex = 1;
            // 
            // girisYapBtn
            // 
            this.girisYapBtn.Location = new System.Drawing.Point(430, 302);
            this.girisYapBtn.Name = "girisYapBtn";
            this.girisYapBtn.Size = new System.Drawing.Size(98, 50);
            this.girisYapBtn.TabIndex = 2;
            this.girisYapBtn.Text = "Giriş Yap";
            this.girisYapBtn.Click += new System.EventHandler(this.girisYapBtn_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(197, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(398, 27);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "TİCARİ OTOMASYON SİSTEMİ";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.girisYapBtn);
            this.Controls.Add(this.kullaniciAdiTxt);
            this.Controls.Add(this.kullaniciSifreTxt);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciSifreTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAdiTxt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit kullaniciSifreTxt;
        private DevExpress.XtraEditors.TextEdit kullaniciAdiTxt;
        private DevExpress.XtraEditors.SimpleButton girisYapBtn;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}