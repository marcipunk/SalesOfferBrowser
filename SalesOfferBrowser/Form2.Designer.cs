namespace SalesOfferBrowser
{
    partial class Form2
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
            System.Windows.Forms.Label issueDateLabel;
            this.offerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voucherNumMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.labIssueDate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerVersionGroupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordinalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencePartNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseUnitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offUnitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDiscountPercentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isOptionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deliveryTimeValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryTimeUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPartNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerVersionGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.offerVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            issueDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.offerBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offerItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offerVersionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // issueDateLabel
            // 
            issueDateLabel.AutoSize = true;
            issueDateLabel.Location = new System.Drawing.Point(14, 20);
            issueDateLabel.Name = "issueDateLabel";
            issueDateLabel.Size = new System.Drawing.Size(61, 13);
            issueDateLabel.TabIndex = 3;
            issueDateLabel.Text = "Issue Date:";
            // 
            // offerBindingSource
            // 
            this.offerBindingSource.DataSource = typeof(SalesOfferBrowser.ObservableListSource<SalesOfferBrowser.Offer>);
            // 
            // voucherNumMetroLabel
            // 
            this.voucherNumMetroLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.offerBindingSource, "VoucherNum", true));
            this.voucherNumMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.voucherNumMetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.voucherNumMetroLabel.Location = new System.Drawing.Point(427, 34);
            this.voucherNumMetroLabel.Name = "voucherNumMetroLabel";
            this.voucherNumMetroLabel.Size = new System.Drawing.Size(196, 23);
            this.voucherNumMetroLabel.TabIndex = 1;
            this.voucherNumMetroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.voucherNumMetroLabel.UseStyleColors = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.labIssueDate);
            this.metroPanel1.Controls.Add(issueDateLabel);
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(603, 421);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // labIssueDate
            // 
            this.labIssueDate.AutoSize = true;
            this.labIssueDate.Location = new System.Drawing.Point(82, 19);
            this.labIssueDate.Name = "labIssueDate";
            this.labIssueDate.Size = new System.Drawing.Size(0, 13);
            this.labIssueDate.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.offerVersionGroupIdDataGridViewTextBoxColumn,
            this.ordinalNumberDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.referencePartNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.measureDataGridViewTextBoxColumn,
            this.baseUnitPriceDataGridViewTextBoxColumn,
            this.offUnitPriceDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.taxIdDataGridViewTextBoxColumn,
            this.baseAmountDataGridViewTextBoxColumn,
            this.offAmountDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.baseTaxDataGridViewTextBoxColumn,
            this.offTaxDataGridViewTextBoxColumn,
            this.taxDataGridViewTextBoxColumn,
            this.baseTotalDataGridViewTextBoxColumn,
            this.offTotalDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.discountPercentDataGridViewTextBoxColumn,
            this.isDiscountPercentDataGridViewCheckBoxColumn,
            this.isOptionDataGridViewCheckBoxColumn,
            this.deliveryTimeValueDataGridViewTextBoxColumn,
            this.deliveryTimeUnitDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.clientPartNoDataGridViewTextBoxColumn,
            this.offerVersionGroupDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.offerItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 368);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // offerVersionGroupIdDataGridViewTextBoxColumn
            // 
            this.offerVersionGroupIdDataGridViewTextBoxColumn.DataPropertyName = "OfferVersionGroupId";
            this.offerVersionGroupIdDataGridViewTextBoxColumn.HeaderText = "OfferVersionGroupId";
            this.offerVersionGroupIdDataGridViewTextBoxColumn.Name = "offerVersionGroupIdDataGridViewTextBoxColumn";
            // 
            // ordinalNumberDataGridViewTextBoxColumn
            // 
            this.ordinalNumberDataGridViewTextBoxColumn.DataPropertyName = "OrdinalNumber";
            this.ordinalNumberDataGridViewTextBoxColumn.HeaderText = "OrdinalNumber";
            this.ordinalNumberDataGridViewTextBoxColumn.Name = "ordinalNumberDataGridViewTextBoxColumn";
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // referencePartNoDataGridViewTextBoxColumn
            // 
            this.referencePartNoDataGridViewTextBoxColumn.DataPropertyName = "ReferencePartNo";
            this.referencePartNoDataGridViewTextBoxColumn.HeaderText = "ReferencePartNo";
            this.referencePartNoDataGridViewTextBoxColumn.Name = "referencePartNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // measureDataGridViewTextBoxColumn
            // 
            this.measureDataGridViewTextBoxColumn.DataPropertyName = "Measure";
            this.measureDataGridViewTextBoxColumn.HeaderText = "Measure";
            this.measureDataGridViewTextBoxColumn.Name = "measureDataGridViewTextBoxColumn";
            // 
            // baseUnitPriceDataGridViewTextBoxColumn
            // 
            this.baseUnitPriceDataGridViewTextBoxColumn.DataPropertyName = "BaseUnitPrice";
            this.baseUnitPriceDataGridViewTextBoxColumn.HeaderText = "BaseUnitPrice";
            this.baseUnitPriceDataGridViewTextBoxColumn.Name = "baseUnitPriceDataGridViewTextBoxColumn";
            // 
            // offUnitPriceDataGridViewTextBoxColumn
            // 
            this.offUnitPriceDataGridViewTextBoxColumn.DataPropertyName = "OffUnitPrice";
            this.offUnitPriceDataGridViewTextBoxColumn.HeaderText = "OffUnitPrice";
            this.offUnitPriceDataGridViewTextBoxColumn.Name = "offUnitPriceDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // taxIdDataGridViewTextBoxColumn
            // 
            this.taxIdDataGridViewTextBoxColumn.DataPropertyName = "TaxId";
            this.taxIdDataGridViewTextBoxColumn.HeaderText = "TaxId";
            this.taxIdDataGridViewTextBoxColumn.Name = "taxIdDataGridViewTextBoxColumn";
            // 
            // baseAmountDataGridViewTextBoxColumn
            // 
            this.baseAmountDataGridViewTextBoxColumn.DataPropertyName = "BaseAmount";
            this.baseAmountDataGridViewTextBoxColumn.HeaderText = "BaseAmount";
            this.baseAmountDataGridViewTextBoxColumn.Name = "baseAmountDataGridViewTextBoxColumn";
            // 
            // offAmountDataGridViewTextBoxColumn
            // 
            this.offAmountDataGridViewTextBoxColumn.DataPropertyName = "OffAmount";
            this.offAmountDataGridViewTextBoxColumn.HeaderText = "OffAmount";
            this.offAmountDataGridViewTextBoxColumn.Name = "offAmountDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // baseTaxDataGridViewTextBoxColumn
            // 
            this.baseTaxDataGridViewTextBoxColumn.DataPropertyName = "BaseTax";
            this.baseTaxDataGridViewTextBoxColumn.HeaderText = "BaseTax";
            this.baseTaxDataGridViewTextBoxColumn.Name = "baseTaxDataGridViewTextBoxColumn";
            // 
            // offTaxDataGridViewTextBoxColumn
            // 
            this.offTaxDataGridViewTextBoxColumn.DataPropertyName = "OffTax";
            this.offTaxDataGridViewTextBoxColumn.HeaderText = "OffTax";
            this.offTaxDataGridViewTextBoxColumn.Name = "offTaxDataGridViewTextBoxColumn";
            // 
            // taxDataGridViewTextBoxColumn
            // 
            this.taxDataGridViewTextBoxColumn.DataPropertyName = "Tax";
            this.taxDataGridViewTextBoxColumn.HeaderText = "Tax";
            this.taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            // 
            // baseTotalDataGridViewTextBoxColumn
            // 
            this.baseTotalDataGridViewTextBoxColumn.DataPropertyName = "BaseTotal";
            this.baseTotalDataGridViewTextBoxColumn.HeaderText = "BaseTotal";
            this.baseTotalDataGridViewTextBoxColumn.Name = "baseTotalDataGridViewTextBoxColumn";
            // 
            // offTotalDataGridViewTextBoxColumn
            // 
            this.offTotalDataGridViewTextBoxColumn.DataPropertyName = "OffTotal";
            this.offTotalDataGridViewTextBoxColumn.HeaderText = "OffTotal";
            this.offTotalDataGridViewTextBoxColumn.Name = "offTotalDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // discountPercentDataGridViewTextBoxColumn
            // 
            this.discountPercentDataGridViewTextBoxColumn.DataPropertyName = "DiscountPercent";
            this.discountPercentDataGridViewTextBoxColumn.HeaderText = "DiscountPercent";
            this.discountPercentDataGridViewTextBoxColumn.Name = "discountPercentDataGridViewTextBoxColumn";
            // 
            // isDiscountPercentDataGridViewCheckBoxColumn
            // 
            this.isDiscountPercentDataGridViewCheckBoxColumn.DataPropertyName = "IsDiscountPercent";
            this.isDiscountPercentDataGridViewCheckBoxColumn.HeaderText = "IsDiscountPercent";
            this.isDiscountPercentDataGridViewCheckBoxColumn.Name = "isDiscountPercentDataGridViewCheckBoxColumn";
            // 
            // isOptionDataGridViewCheckBoxColumn
            // 
            this.isOptionDataGridViewCheckBoxColumn.DataPropertyName = "IsOption";
            this.isOptionDataGridViewCheckBoxColumn.HeaderText = "IsOption";
            this.isOptionDataGridViewCheckBoxColumn.Name = "isOptionDataGridViewCheckBoxColumn";
            // 
            // deliveryTimeValueDataGridViewTextBoxColumn
            // 
            this.deliveryTimeValueDataGridViewTextBoxColumn.DataPropertyName = "DeliveryTimeValue";
            this.deliveryTimeValueDataGridViewTextBoxColumn.HeaderText = "DeliveryTimeValue";
            this.deliveryTimeValueDataGridViewTextBoxColumn.Name = "deliveryTimeValueDataGridViewTextBoxColumn";
            // 
            // deliveryTimeUnitDataGridViewTextBoxColumn
            // 
            this.deliveryTimeUnitDataGridViewTextBoxColumn.DataPropertyName = "DeliveryTimeUnit";
            this.deliveryTimeUnitDataGridViewTextBoxColumn.HeaderText = "DeliveryTimeUnit";
            this.deliveryTimeUnitDataGridViewTextBoxColumn.Name = "deliveryTimeUnitDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // clientPartNoDataGridViewTextBoxColumn
            // 
            this.clientPartNoDataGridViewTextBoxColumn.DataPropertyName = "ClientPartNo";
            this.clientPartNoDataGridViewTextBoxColumn.HeaderText = "ClientPartNo";
            this.clientPartNoDataGridViewTextBoxColumn.Name = "clientPartNoDataGridViewTextBoxColumn";
            // 
            // offerVersionGroupDataGridViewTextBoxColumn
            // 
            this.offerVersionGroupDataGridViewTextBoxColumn.DataPropertyName = "OfferVersionGroup";
            this.offerVersionGroupDataGridViewTextBoxColumn.HeaderText = "OfferVersionGroup";
            this.offerVersionGroupDataGridViewTextBoxColumn.Name = "offerVersionGroupDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // offerItemBindingSource
            // 
            this.offerItemBindingSource.DataSource = typeof(SalesOfferBrowser.ObservableListSource<SalesOfferBrowser.OfferItem>);
            // 
            // offerVersionBindingSource
            // 
            this.offerVersionBindingSource.DataSource = typeof(SalesOfferBrowser.ObservableListSource<SalesOfferBrowser.OfferVersion>);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(643, 501);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.voucherNumMetroLabel);
            this.Name = "Form2";
            this.Text = "Offer";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            ((System.ComponentModel.ISupportInitialize)(this.offerBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offerItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offerVersionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource offerBindingSource;
        private MetroFramework.Controls.MetroLabel voucherNumMetroLabel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.BindingSource offerItemBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerVersionGroupIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordinalNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencePartNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseUnitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offUnitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDiscountPercentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOptionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryTimeValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryTimeUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPartNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerVersionGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource offerVersionBindingSource;
        private System.Windows.Forms.Label labIssueDate;
    }
}