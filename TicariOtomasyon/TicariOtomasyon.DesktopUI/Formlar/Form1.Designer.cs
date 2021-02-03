namespace TicariOtomasyon.DesktopUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.btnStoklar = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.btnFirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAnasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersoneller = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiderler = new DevExpress.XtraBars.BarButtonItem();
            this.btnNotlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnBankalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnRehber = new DevExpress.XtraBars.BarButtonItem();
            this.btnFaturalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCikisYap = new DevExpress.XtraBars.BarButtonItem();
            this.adminHeader = new DevExpress.XtraBars.BarHeaderItem();
            this.raporlarBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnUrunler,
            this.btnStoklar,
            this.btnMusteriler,
            this.btnFirmalar,
            this.btnAnasayfa,
            this.btnPersoneller,
            this.btnGiderler,
            this.btnNotlar,
            this.btnBankalar,
            this.btnRehber,
            this.btnFaturalar,
            this.btnAyarlar,
            this.btnCikisYap,
            this.adminHeader,
            this.raporlarBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 21;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.adminHeader);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(845, 138);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Caption = "Ürünler";
            this.btnUrunler.Id = 1;
            this.btnUrunler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunler.ImageOptions.Image")));
            this.btnUrunler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunler.ImageOptions.LargeImage")));
            this.btnUrunler.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnUrunler.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnUrunler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunler_ItemClick);
            // 
            // btnStoklar
            // 
            this.btnStoklar.Caption = "Stoklar";
            this.btnStoklar.Id = 2;
            this.btnStoklar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStoklar.ImageOptions.Image")));
            this.btnStoklar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStoklar.ImageOptions.LargeImage")));
            this.btnStoklar.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnStoklar.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnStoklar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStoklar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStoklar.Name = "btnStoklar";
            this.btnStoklar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStoklar_ItemClick);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Caption = "Müşteriler";
            this.btnMusteriler.Id = 3;
            this.btnMusteriler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriler.ImageOptions.Image")));
            this.btnMusteriler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriler.ImageOptions.LargeImage")));
            this.btnMusteriler.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnMusteriler.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnMusteriler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriler_ItemClick);
            // 
            // btnFirmalar
            // 
            this.btnFirmalar.Caption = "Firmalar";
            this.btnFirmalar.Id = 4;
            this.btnFirmalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmalar.ImageOptions.Image")));
            this.btnFirmalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFirmalar.ImageOptions.LargeImage")));
            this.btnFirmalar.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnFirmalar.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnFirmalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnFirmalar.Name = "btnFirmalar";
            this.btnFirmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFirmalar_ItemClick);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Caption = "Anasayfa";
            this.btnAnasayfa.Id = 5;
            this.btnAnasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.ImageOptions.Image")));
            this.btnAnasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.ImageOptions.LargeImage")));
            this.btnAnasayfa.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnAnasayfa.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnAnasayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAnasayfa_ItemClick);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.Caption = "Personeller";
            this.btnPersoneller.Id = 6;
            this.btnPersoneller.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersoneller.ImageOptions.Image")));
            this.btnPersoneller.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPersoneller.ImageOptions.LargeImage")));
            this.btnPersoneller.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnPersoneller.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPersoneller_ItemClick);
            // 
            // btnGiderler
            // 
            this.btnGiderler.Caption = "Giderler";
            this.btnGiderler.Id = 7;
            this.btnGiderler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiderler.ImageOptions.Image")));
            this.btnGiderler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGiderler.ImageOptions.LargeImage")));
            this.btnGiderler.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnGiderler.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnGiderler.Name = "btnGiderler";
            this.btnGiderler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiderler_ItemClick);
            // 
            // btnNotlar
            // 
            this.btnNotlar.Caption = "Notlar";
            this.btnNotlar.Id = 9;
            this.btnNotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNotlar.ImageOptions.Image")));
            this.btnNotlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNotlar.ImageOptions.LargeImage")));
            this.btnNotlar.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnNotlar.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnNotlar.Name = "btnNotlar";
            this.btnNotlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNotlar_ItemClick);
            // 
            // btnBankalar
            // 
            this.btnBankalar.Caption = "Bankalar";
            this.btnBankalar.Id = 10;
            this.btnBankalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBankalar.ImageOptions.Image")));
            this.btnBankalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBankalar.ImageOptions.LargeImage")));
            this.btnBankalar.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnBankalar.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnBankalar.Name = "btnBankalar";
            this.btnBankalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBankalar_ItemClick);
            // 
            // btnRehber
            // 
            this.btnRehber.Caption = "Rehber";
            this.btnRehber.Id = 11;
            this.btnRehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRehber.ImageOptions.Image")));
            this.btnRehber.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRehber.ImageOptions.LargeImage")));
            this.btnRehber.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnRehber.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnRehber.Name = "btnRehber";
            this.btnRehber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRehber_ItemClick);
            // 
            // btnFaturalar
            // 
            this.btnFaturalar.Caption = "Faturalar";
            this.btnFaturalar.Id = 12;
            this.btnFaturalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturalar.ImageOptions.Image")));
            this.btnFaturalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFaturalar.ImageOptions.LargeImage")));
            this.btnFaturalar.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnFaturalar.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnFaturalar.Name = "btnFaturalar";
            this.btnFaturalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFaturalar_ItemClick);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Caption = "Ayarlar";
            this.btnAyarlar.Id = 13;
            this.btnAyarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.Image")));
            this.btnAyarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.LargeImage")));
            this.btnAyarlar.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnAyarlar.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAyarlar_ItemClick);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Caption = "Çıkış Yap";
            this.btnCikisYap.Id = 15;
            this.btnCikisYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikisYap.ImageOptions.Image")));
            this.btnCikisYap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCikisYap.ImageOptions.LargeImage")));
            this.btnCikisYap.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnCikisYap.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnCikisYap.ItemAppearance.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCikisYap.ItemAppearance.Pressed.Options.UseBackColor = true;
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCikisYap_ItemClick);
            // 
            // adminHeader
            // 
            this.adminHeader.Caption = "AdminNameText";
            this.adminHeader.Id = 17;
            this.adminHeader.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("adminHeader.ImageOptions.Image")));
            this.adminHeader.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("adminHeader.ImageOptions.LargeImage")));
            this.adminHeader.Name = "adminHeader";
            // 
            // raporlarBtn
            // 
            this.raporlarBtn.Caption = "Raporlar";
            this.raporlarBtn.Id = 20;
            this.raporlarBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("raporlarBtn.ImageOptions.Image")));
            this.raporlarBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("raporlarBtn.ImageOptions.LargeImage")));
            this.raporlarBtn.Name = "raporlarBtn";
            this.raporlarBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.raporlarBtn_ItemClick_1);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ticari Otomasyon Sistemi Modülleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAnasayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUrunler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStoklar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteriler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFirmalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPersoneller);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGiderler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNotlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBankalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRehber);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFaturalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.raporlarBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAyarlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCikisYap);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 711);
            this.ControlBox = false;
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticari Otomasyon Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnUrunler;
        private DevExpress.XtraBars.BarButtonItem btnStoklar;
        private DevExpress.XtraBars.BarButtonItem btnMusteriler;
        private DevExpress.XtraBars.BarButtonItem btnFirmalar;
        private DevExpress.XtraBars.BarButtonItem btnAnasayfa;
        private DevExpress.XtraBars.BarButtonItem btnPersoneller;
        private DevExpress.XtraBars.BarButtonItem btnGiderler;
        private DevExpress.XtraBars.BarButtonItem btnNotlar;
        private DevExpress.XtraBars.BarButtonItem btnBankalar;
        private DevExpress.XtraBars.BarButtonItem btnRehber;
        private DevExpress.XtraBars.BarButtonItem btnFaturalar;
        private DevExpress.XtraBars.BarButtonItem btnAyarlar;
        private DevExpress.XtraBars.BarButtonItem btnCikisYap;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem raporlarBtn;
        public DevExpress.XtraBars.BarHeaderItem adminHeader;
    }
}

