namespace TicariOtomasyon.DesktopUI.Formlar
{
    partial class PersonelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.temizleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.silBtn = new DevExpress.XtraEditors.SimpleButton();
            this.guncelleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.kaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.telefonTxt = new System.Windows.Forms.MaskedTextBox();
            this.ilceCbx = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ilCbx = new DevExpress.XtraEditors.ComboBoxEdit();
            this.adresTxt = new System.Windows.Forms.RichTextBox();
            this.gorevTxt = new DevExpress.XtraEditors.TextEdit();
            this.mailTxt = new DevExpress.XtraEditors.TextEdit();
            this.tcTxt = new DevExpress.XtraEditors.TextEdit();
            this.soyadTxt = new DevExpress.XtraEditors.TextEdit();
            this.adTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilceCbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilCbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyadTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.temizleBtn);
            this.groupControl1.Controls.Add(this.silBtn);
            this.groupControl1.Controls.Add(this.guncelleBtn);
            this.groupControl1.Controls.Add(this.kaydetBtn);
            this.groupControl1.Controls.Add(this.telefonTxt);
            this.groupControl1.Controls.Add(this.ilceCbx);
            this.groupControl1.Controls.Add(this.ilCbx);
            this.groupControl1.Controls.Add(this.adresTxt);
            this.groupControl1.Controls.Add(this.gorevTxt);
            this.groupControl1.Controls.Add(this.mailTxt);
            this.groupControl1.Controls.Add(this.tcTxt);
            this.groupControl1.Controls.Add(this.soyadTxt);
            this.groupControl1.Controls.Add(this.adTxt);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(558, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(242, 511);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Personel Veritabanı İşlemleri";
            // 
            // temizleBtn
            // 
            this.temizleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("temizleBtn.ImageOptions.Image")));
            this.temizleBtn.Location = new System.Drawing.Point(6, 394);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(224, 36);
            this.temizleBtn.TabIndex = 10;
            this.temizleBtn.Text = "Temizle";
            this.temizleBtn.Click += new System.EventHandler(this.veriTabaniBtns_Click);
            // 
            // silBtn
            // 
            this.silBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("silBtn.ImageOptions.Image")));
            this.silBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.silBtn.Location = new System.Drawing.Point(163, 436);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(67, 68);
            this.silBtn.TabIndex = 13;
            this.silBtn.Text = "Sil";
            this.silBtn.Click += new System.EventHandler(this.veriTabaniBtns_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guncelleBtn.ImageOptions.Image")));
            this.guncelleBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.guncelleBtn.Location = new System.Drawing.Point(85, 436);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(67, 68);
            this.guncelleBtn.TabIndex = 12;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.Click += new System.EventHandler(this.veriTabaniBtns_Click);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kaydetBtn.ImageOptions.Image")));
            this.kaydetBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.kaydetBtn.Location = new System.Drawing.Point(6, 436);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(67, 68);
            this.kaydetBtn.TabIndex = 11;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.Click += new System.EventHandler(this.veriTabaniBtns_Click);
            // 
            // telefonTxt
            // 
            this.telefonTxt.Location = new System.Drawing.Point(70, 108);
            this.telefonTxt.Mask = "(9999) 000-0000";
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.Size = new System.Drawing.Size(160, 21);
            this.telefonTxt.TabIndex = 3;
            // 
            // ilceCbx
            // 
            this.ilceCbx.Location = new System.Drawing.Point(70, 280);
            this.ilceCbx.Name = "ilceCbx";
            this.ilceCbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ilceCbx.Size = new System.Drawing.Size(160, 20);
            this.ilceCbx.TabIndex = 8;
            // 
            // ilCbx
            // 
            this.ilCbx.Location = new System.Drawing.Point(70, 246);
            this.ilCbx.Name = "ilCbx";
            this.ilCbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ilCbx.Size = new System.Drawing.Size(160, 20);
            this.ilCbx.TabIndex = 7;
            this.ilCbx.SelectedIndexChanged += new System.EventHandler(this.ilCbx_SelectedIndexChanged);
            // 
            // adresTxt
            // 
            this.adresTxt.Location = new System.Drawing.Point(70, 315);
            this.adresTxt.Name = "adresTxt";
            this.adresTxt.Size = new System.Drawing.Size(160, 68);
            this.adresTxt.TabIndex = 9;
            this.adresTxt.Text = "";
            // 
            // gorevTxt
            // 
            this.gorevTxt.Location = new System.Drawing.Point(70, 208);
            this.gorevTxt.Name = "gorevTxt";
            this.gorevTxt.Size = new System.Drawing.Size(160, 20);
            this.gorevTxt.TabIndex = 6;
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(70, 175);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(160, 20);
            this.mailTxt.TabIndex = 5;
            // 
            // tcTxt
            // 
            this.tcTxt.Location = new System.Drawing.Point(70, 142);
            this.tcTxt.Name = "tcTxt";
            this.tcTxt.Properties.MaxLength = 11;
            this.tcTxt.Size = new System.Drawing.Size(160, 20);
            this.tcTxt.TabIndex = 4;
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(70, 73);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(160, 20);
            this.soyadTxt.TabIndex = 2;
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(70, 37);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(160, 20);
            this.adTxt.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(15, 207);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 18);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Görev :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(17, 314);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 18);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Adres :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(31, 279);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(33, 18);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "İlçe :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(46, 245);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(18, 18);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "İl :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(30, 174);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 18);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Mail :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 141);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 18);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "TC No :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Telefon :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Soyad :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(37, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ad :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(558, 511);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Personel Listesi";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(554, 489);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "PersonelForm";
            this.Text = "PersonelForm";
            this.Load += new System.EventHandler(this.PersonelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilceCbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilCbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyadTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton temizleBtn;
        private DevExpress.XtraEditors.SimpleButton silBtn;
        private DevExpress.XtraEditors.SimpleButton guncelleBtn;
        private DevExpress.XtraEditors.SimpleButton kaydetBtn;
        private System.Windows.Forms.MaskedTextBox telefonTxt;
        private DevExpress.XtraEditors.ComboBoxEdit ilceCbx;
        private DevExpress.XtraEditors.ComboBoxEdit ilCbx;
        private System.Windows.Forms.RichTextBox adresTxt;
        private DevExpress.XtraEditors.TextEdit gorevTxt;
        private DevExpress.XtraEditors.TextEdit mailTxt;
        private DevExpress.XtraEditors.TextEdit tcTxt;
        private DevExpress.XtraEditors.TextEdit soyadTxt;
        private DevExpress.XtraEditors.TextEdit adTxt;
    }
}