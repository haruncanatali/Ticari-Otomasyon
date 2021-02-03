namespace TicariOtomasyon.DesktopUI.Formlar
{
    partial class RaporlarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporlarForm));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblMusteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dboTicariOtomasyonDataSet = new TicariOtomasyon.DesktopUI.DboTicariOtomasyonDataSet();
            this.tblFirmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Tbl_MusteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MusteriTableAdapter = new TicariOtomasyon.DesktopUI.DboTicariOtomasyonDataSetTableAdapters.Tbl_MusteriTableAdapter();
            this.tbl_FirmaTableAdapter = new TicariOtomasyon.DesktopUI.DboTicariOtomasyonDataSetTableAdapters.Tbl_FirmaTableAdapter();
            this.tbl_PersonelTableAdapter = new TicariOtomasyon.DesktopUI.DboTicariOtomasyonDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.Tbl_UrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_UrunTableAdapter = new TicariOtomasyon.DesktopUI.DboTicariOtomasyonDataSetTableAdapters.Tbl_UrunTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboTicariOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_MusteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_UrunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMusteriBindingSource
            // 
            this.tblMusteriBindingSource.DataMember = "Tbl_Musteri";
            this.tblMusteriBindingSource.DataSource = this.dboTicariOtomasyonDataSet;
            // 
            // dboTicariOtomasyonDataSet
            // 
            this.dboTicariOtomasyonDataSet.DataSetName = "DboTicariOtomasyonDataSet";
            this.dboTicariOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFirmaBindingSource
            // 
            this.tblFirmaBindingSource.DataMember = "Tbl_Firma";
            this.tblFirmaBindingSource.DataSource = this.dboTicariOtomasyonDataSet;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.dboTicariOtomasyonDataSet;
            // 
            // tblUrunBindingSource
            // 
            this.tblUrunBindingSource.DataMember = "Tbl_Urun";
            this.tblUrunBindingSource.DataSource = this.dboTicariOtomasyonDataSet;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(800, 511);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.reportViewer1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(794, 464);
            this.xtraTabPage1.Text = "Müşteri Raporları";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DboTicariOtomasyonDataSet";
            reportDataSource5.Value = this.tblMusteriBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TicariOtomasyon.DesktopUI.Reports.MusteriRapor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(794, 464);
            this.reportViewer1.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.reportViewer2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(794, 464);
            this.xtraTabPage2.Text = "Firma Raporları";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource6.Name = "DboTicariOtomasyonDataSet";
            reportDataSource6.Value = this.tblFirmaBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "TicariOtomasyon.DesktopUI.Reports.FirmaRapor.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(794, 464);
            this.reportViewer2.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.reportViewer3);
            this.xtraTabPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage3.ImageOptions.Image")));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(794, 464);
            this.xtraTabPage3.Text = "Personel Raporları";
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource7.Name = "DboTicariOtomasyonDataSet";
            reportDataSource7.Value = this.tblPersonelBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "TicariOtomasyon.DesktopUI.Reports.MusteriRapor.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(794, 464);
            this.reportViewer3.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.reportViewer4);
            this.xtraTabPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage4.ImageOptions.Image")));
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(794, 464);
            this.xtraTabPage4.Text = "Ürün Raporları";
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource8.Name = "DboTicariOtomasyonDataSet";
            reportDataSource8.Value = this.tblUrunBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "TicariOtomasyon.DesktopUI.Reports.UrunRapor.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(794, 464);
            this.reportViewer4.TabIndex = 0;
            // 
            // Tbl_MusteriBindingSource
            // 
            this.Tbl_MusteriBindingSource.DataMember = "Tbl_Musteri";
            this.Tbl_MusteriBindingSource.DataSource = this.dboTicariOtomasyonDataSet;
            // 
            // tbl_MusteriTableAdapter
            // 
            this.tbl_MusteriTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_FirmaTableAdapter
            // 
            this.tbl_FirmaTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // Tbl_UrunBindingSource
            // 
            this.Tbl_UrunBindingSource.DataMember = "Tbl_Urun";
            this.Tbl_UrunBindingSource.DataSource = this.dboTicariOtomasyonDataSet;
            // 
            // tbl_UrunTableAdapter
            // 
            this.tbl_UrunTableAdapter.ClearBeforeFill = true;
            // 
            // RaporlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "RaporlarForm";
            this.Text = "RaporlarForm";
            this.Load += new System.EventHandler(this.RaporlarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboTicariOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFirmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_MusteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_UrunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DboTicariOtomasyonDataSet dboTicariOtomasyonDataSet;
        private System.Windows.Forms.BindingSource Tbl_MusteriBindingSource;
        private System.Windows.Forms.BindingSource tblMusteriBindingSource;
        private DboTicariOtomasyonDataSetTableAdapters.Tbl_MusteriTableAdapter tbl_MusteriTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource tblFirmaBindingSource;
        private DboTicariOtomasyonDataSetTableAdapters.Tbl_FirmaTableAdapter tbl_FirmaTableAdapter;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private DboTicariOtomasyonDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.BindingSource Tbl_UrunBindingSource;
        private System.Windows.Forms.BindingSource tblUrunBindingSource;
        private DboTicariOtomasyonDataSetTableAdapters.Tbl_UrunTableAdapter tbl_UrunTableAdapter;
    }
}