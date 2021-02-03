namespace TicariOtomasyon.DesktopUI.Formlar
{
    partial class NotlarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotlarForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.silBtn = new DevExpress.XtraEditors.SimpleButton();
            this.guncelleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.kaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.temizleBtn = new DevExpress.XtraEditors.SimpleButton();
            this._detayTxt = new System.Windows.Forms.RichTextBox();
            this.tarihTxt = new DevExpress.XtraEditors.DateEdit();
            this.hitapTxt = new DevExpress.XtraEditors.TextEdit();
            this.olusturanTxt = new DevExpress.XtraEditors.TextEdit();
            this.baslikTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.detayTxt = new System.Windows.Forms.RichTextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.saatTxt = new DevExpress.XtraEditors.TextEdit();
            this.saatCek = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarihTxt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitapTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olusturanTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baslikTxt.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saatTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.xtraTabControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(566, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(234, 511);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Not Veritabanı İşlemleri";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 20);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(230, 489);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.saatCek);
            this.xtraTabPage1.Controls.Add(this.saatTxt);
            this.xtraTabPage1.Controls.Add(this.silBtn);
            this.xtraTabPage1.Controls.Add(this.guncelleBtn);
            this.xtraTabPage1.Controls.Add(this.kaydetBtn);
            this.xtraTabPage1.Controls.Add(this.temizleBtn);
            this.xtraTabPage1.Controls.Add(this._detayTxt);
            this.xtraTabPage1.Controls.Add(this.tarihTxt);
            this.xtraTabPage1.Controls.Add(this.hitapTxt);
            this.xtraTabPage1.Controls.Add(this.olusturanTxt);
            this.xtraTabPage1.Controls.Add(this.baslikTxt);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(224, 461);
            this.xtraTabPage1.Text = "Veritabanı İşlemleri";
            // 
            // silBtn
            // 
            this.silBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("silBtn.ImageOptions.Image")));
            this.silBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.silBtn.Location = new System.Drawing.Point(166, 371);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(49, 85);
            this.silBtn.TabIndex = 17;
            this.silBtn.Text = "Sil";
            this.silBtn.Click += new System.EventHandler(this.veritabaniBtns_Clicl);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guncelleBtn.ImageOptions.Image")));
            this.guncelleBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.guncelleBtn.Location = new System.Drawing.Point(115, 371);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(49, 85);
            this.guncelleBtn.TabIndex = 17;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.Click += new System.EventHandler(this.veritabaniBtns_Clicl);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kaydetBtn.ImageOptions.Image")));
            this.kaydetBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.kaydetBtn.Location = new System.Drawing.Point(64, 371);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(49, 85);
            this.kaydetBtn.TabIndex = 17;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.Click += new System.EventHandler(this.veritabaniBtns_Clicl);
            // 
            // temizleBtn
            // 
            this.temizleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("temizleBtn.ImageOptions.Image")));
            this.temizleBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.temizleBtn.Location = new System.Drawing.Point(13, 371);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(49, 85);
            this.temizleBtn.TabIndex = 17;
            this.temizleBtn.Text = "Temizle";
            this.temizleBtn.Click += new System.EventHandler(this.veritabaniBtns_Clicl);
            // 
            // _detayTxt
            // 
            this._detayTxt.Location = new System.Drawing.Point(86, 183);
            this._detayTxt.Name = "_detayTxt";
            this._detayTxt.ReadOnly = true;
            this._detayTxt.Size = new System.Drawing.Size(131, 158);
            this._detayTxt.TabIndex = 15;
            this._detayTxt.Text = "";
            // 
            // tarihTxt
            // 
            this.tarihTxt.EditValue = null;
            this.tarihTxt.Location = new System.Drawing.Point(86, 8);
            this.tarihTxt.Name = "tarihTxt";
            this.tarihTxt.Properties.Appearance.Options.UseTextOptions = true;
            this.tarihTxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tarihTxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarihTxt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarihTxt.Size = new System.Drawing.Size(131, 20);
            this.tarihTxt.TabIndex = 14;
            // 
            // hitapTxt
            // 
            this.hitapTxt.Location = new System.Drawing.Point(86, 148);
            this.hitapTxt.Name = "hitapTxt";
            this.hitapTxt.Properties.Appearance.Options.UseTextOptions = true;
            this.hitapTxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.hitapTxt.Size = new System.Drawing.Size(131, 20);
            this.hitapTxt.TabIndex = 11;
            // 
            // olusturanTxt
            // 
            this.olusturanTxt.Location = new System.Drawing.Point(86, 111);
            this.olusturanTxt.Name = "olusturanTxt";
            this.olusturanTxt.Properties.Appearance.Options.UseTextOptions = true;
            this.olusturanTxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.olusturanTxt.Size = new System.Drawing.Size(131, 20);
            this.olusturanTxt.TabIndex = 12;
            // 
            // baslikTxt
            // 
            this.baslikTxt.Location = new System.Drawing.Point(86, 78);
            this.baslikTxt.Name = "baslikTxt";
            this.baslikTxt.Properties.Appearance.Options.UseTextOptions = true;
            this.baslikTxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.baslikTxt.Size = new System.Drawing.Size(131, 20);
            this.baslikTxt.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(31, 182);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(49, 18);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Detay :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(2, 147);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 18);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Hitap Ettiği :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(8, 110);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Oluşturan :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(35, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 18);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Başlık :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(41, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 18);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Saat :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(37, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 18);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Tarih :";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.detayTxt);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(224, 461);
            this.xtraTabPage2.Text = "Detay";
            // 
            // detayTxt
            // 
            this.detayTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detayTxt.Location = new System.Drawing.Point(0, 0);
            this.detayTxt.Name = "detayTxt";
            this.detayTxt.Size = new System.Drawing.Size(224, 461);
            this.detayTxt.TabIndex = 0;
            this.detayTxt.Text = "";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(566, 511);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Not Listesi";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(562, 489);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // saatTxt
            // 
            this.saatTxt.Location = new System.Drawing.Point(86, 43);
            this.saatTxt.Name = "saatTxt";
            this.saatTxt.Properties.Appearance.Options.UseTextOptions = true;
            this.saatTxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.saatTxt.Size = new System.Drawing.Size(89, 20);
            this.saatTxt.TabIndex = 18;
            // 
            // saatCek
            // 
            this.saatCek.Location = new System.Drawing.Point(182, 41);
            this.saatCek.Name = "saatCek";
            this.saatCek.Size = new System.Drawing.Size(33, 23);
            this.saatCek.TabIndex = 19;
            this.saatCek.Text = "Çek";
            this.saatCek.Click += new System.EventHandler(this.saatCek_Click);
            // 
            // NotlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "NotlarForm";
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.NotlarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarihTxt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitapTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olusturanTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baslikTxt.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saatTxt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton silBtn;
        private DevExpress.XtraEditors.SimpleButton guncelleBtn;
        private DevExpress.XtraEditors.SimpleButton kaydetBtn;
        private DevExpress.XtraEditors.SimpleButton temizleBtn;
        private System.Windows.Forms.RichTextBox _detayTxt;
        private DevExpress.XtraEditors.DateEdit tarihTxt;
        private DevExpress.XtraEditors.TextEdit hitapTxt;
        private DevExpress.XtraEditors.TextEdit olusturanTxt;
        private DevExpress.XtraEditors.TextEdit baslikTxt;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.RichTextBox detayTxt;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit saatTxt;
        private DevExpress.XtraEditors.SimpleButton saatCek;
    }
}