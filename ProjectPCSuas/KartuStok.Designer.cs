namespace ProjectPCSuas
{
    partial class KartuStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KartuStok));
            System.Windows.Forms.Label iD_STOCKLabel;
            System.Windows.Forms.Label iD_BARANGLabel;
            System.Windows.Forms.Label sTOCK_MINLabel;
            System.Windows.Forms.Label sTOCK_ON_HANDLabel;
            this.uASDataSet2 = new ProjectPCSuas.UASDataSet2();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new ProjectPCSuas.UASDataSet2TableAdapters.stockTableAdapter();
            this.tableAdapterManager = new ProjectPCSuas.UASDataSet2TableAdapters.TableAdapterManager();
            this.stockBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.stockBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_STOCKTextBox = new System.Windows.Forms.TextBox();
            this.iD_BARANGTextBox = new System.Windows.Forms.TextBox();
            this.sTOCK_MINTextBox = new System.Windows.Forms.TextBox();
            this.sTOCK_ON_HANDTextBox = new System.Windows.Forms.TextBox();
            this.stock_historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stock_historyTableAdapter = new ProjectPCSuas.UASDataSet2TableAdapters.stock_historyTableAdapter();
            this.stock_historyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_STOCKLabel = new System.Windows.Forms.Label();
            iD_BARANGLabel = new System.Windows.Forms.Label();
            sTOCK_MINLabel = new System.Windows.Forms.Label();
            sTOCK_ON_HANDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingNavigator)).BeginInit();
            this.stockBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_historyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uASDataSet2
            // 
            this.uASDataSet2.DataSetName = "UASDataSet2";
            this.uASDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "stock";
            this.stockBindingSource.DataSource = this.uASDataSet2;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.m_barangTableAdapter = null;
            this.tableAdapterManager.m_groupuserTableAdapter = null;
            this.tableAdapterManager.m_hakaksesgroupuserTableAdapter = null;
            this.tableAdapterManager.m_kotaTableAdapter = null;
            this.tableAdapterManager.m_merkTableAdapter = null;
            this.tableAdapterManager.m_modelTableAdapter = null;
            this.tableAdapterManager.m_pelangganTableAdapter = null;
            this.tableAdapterManager.m_supplierTableAdapter = null;
            this.tableAdapterManager.m_usersTableAdapter = null;
            this.tableAdapterManager.rework_detailTableAdapter = null;
            this.tableAdapterManager.reworkTableAdapter = null;
            this.tableAdapterManager.stock_historyTableAdapter = this.stock_historyTableAdapter;
            this.tableAdapterManager.stockTableAdapter = this.stockTableAdapter;
            this.tableAdapterManager.t_invoice_detailTableAdapter = null;
            this.tableAdapterManager.t_invoice_headerTableAdapter = null;
            this.tableAdapterManager.t_invoiceppn_detailTableAdapter = null;
            this.tableAdapterManager.t_invoiceppn_headerTableAdapter = null;
            this.tableAdapterManager.t_label_hargaTableAdapter = null;
            this.tableAdapterManager.t_pembelian_detailTableAdapter = null;
            this.tableAdapterManager.t_pembelian_headerTableAdapter = null;
            this.tableAdapterManager.t_penawaran_detailTableAdapter = null;
            this.tableAdapterManager.t_penawaran_headerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectPCSuas.UASDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stockBindingNavigator
            // 
            this.stockBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stockBindingNavigator.BindingSource = this.stockBindingSource;
            this.stockBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stockBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stockBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.stockBindingNavigatorSaveItem});
            this.stockBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stockBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stockBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stockBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stockBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stockBindingNavigator.Name = "stockBindingNavigator";
            this.stockBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stockBindingNavigator.Size = new System.Drawing.Size(820, 25);
            this.stockBindingNavigator.TabIndex = 0;
            this.stockBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // stockBindingNavigatorSaveItem
            // 
            this.stockBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stockBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stockBindingNavigatorSaveItem.Image")));
            this.stockBindingNavigatorSaveItem.Name = "stockBindingNavigatorSaveItem";
            this.stockBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.stockBindingNavigatorSaveItem.Text = "Save Data";
            this.stockBindingNavigatorSaveItem.Click += new System.EventHandler(this.stockBindingNavigatorSaveItem_Click);
            // 
            // iD_STOCKLabel
            // 
            iD_STOCKLabel.AutoSize = true;
            iD_STOCKLabel.Location = new System.Drawing.Point(12, 62);
            iD_STOCKLabel.Name = "iD_STOCKLabel";
            iD_STOCKLabel.Size = new System.Drawing.Size(60, 13);
            iD_STOCKLabel.TabIndex = 1;
            iD_STOCKLabel.Text = "ID STOCK:";
            // 
            // iD_STOCKTextBox
            // 
            this.iD_STOCKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "ID_STOCK", true));
            this.iD_STOCKTextBox.Location = new System.Drawing.Point(117, 59);
            this.iD_STOCKTextBox.Name = "iD_STOCKTextBox";
            this.iD_STOCKTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_STOCKTextBox.TabIndex = 2;
            // 
            // iD_BARANGLabel
            // 
            iD_BARANGLabel.AutoSize = true;
            iD_BARANGLabel.Location = new System.Drawing.Point(12, 88);
            iD_BARANGLabel.Name = "iD_BARANGLabel";
            iD_BARANGLabel.Size = new System.Drawing.Size(69, 13);
            iD_BARANGLabel.TabIndex = 3;
            iD_BARANGLabel.Text = "ID BARANG:";
            // 
            // iD_BARANGTextBox
            // 
            this.iD_BARANGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "ID_BARANG", true));
            this.iD_BARANGTextBox.Location = new System.Drawing.Point(117, 85);
            this.iD_BARANGTextBox.Name = "iD_BARANGTextBox";
            this.iD_BARANGTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_BARANGTextBox.TabIndex = 4;
            // 
            // sTOCK_MINLabel
            // 
            sTOCK_MINLabel.AutoSize = true;
            sTOCK_MINLabel.Location = new System.Drawing.Point(12, 114);
            sTOCK_MINLabel.Name = "sTOCK_MINLabel";
            sTOCK_MINLabel.Size = new System.Drawing.Size(69, 13);
            sTOCK_MINLabel.TabIndex = 5;
            sTOCK_MINLabel.Text = "STOCK MIN:";
            // 
            // sTOCK_MINTextBox
            // 
            this.sTOCK_MINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "STOCK_MIN", true));
            this.sTOCK_MINTextBox.Location = new System.Drawing.Point(117, 111);
            this.sTOCK_MINTextBox.Name = "sTOCK_MINTextBox";
            this.sTOCK_MINTextBox.Size = new System.Drawing.Size(100, 20);
            this.sTOCK_MINTextBox.TabIndex = 6;
            // 
            // sTOCK_ON_HANDLabel
            // 
            sTOCK_ON_HANDLabel.AutoSize = true;
            sTOCK_ON_HANDLabel.Location = new System.Drawing.Point(12, 140);
            sTOCK_ON_HANDLabel.Name = "sTOCK_ON_HANDLabel";
            sTOCK_ON_HANDLabel.Size = new System.Drawing.Size(99, 13);
            sTOCK_ON_HANDLabel.TabIndex = 7;
            sTOCK_ON_HANDLabel.Text = "STOCK ON HAND:";
            // 
            // sTOCK_ON_HANDTextBox
            // 
            this.sTOCK_ON_HANDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "STOCK_ON_HAND", true));
            this.sTOCK_ON_HANDTextBox.Location = new System.Drawing.Point(117, 137);
            this.sTOCK_ON_HANDTextBox.Name = "sTOCK_ON_HANDTextBox";
            this.sTOCK_ON_HANDTextBox.Size = new System.Drawing.Size(100, 20);
            this.sTOCK_ON_HANDTextBox.TabIndex = 8;
            // 
            // stock_historyBindingSource
            // 
            this.stock_historyBindingSource.DataMember = "stock_history";
            this.stock_historyBindingSource.DataSource = this.uASDataSet2;
            // 
            // stock_historyTableAdapter
            // 
            this.stock_historyTableAdapter.ClearBeforeFill = true;
            // 
            // stock_historyDataGridView
            // 
            this.stock_historyDataGridView.AutoGenerateColumns = false;
            this.stock_historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stock_historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.stock_historyDataGridView.DataSource = this.stock_historyBindingSource;
            this.stock_historyDataGridView.Location = new System.Drawing.Point(15, 179);
            this.stock_historyDataGridView.Name = "stock_historyDataGridView";
            this.stock_historyDataGridView.Size = new System.Drawing.Size(743, 220);
            this.stock_historyDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_BARANG";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_BARANG";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_INVOICE";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_INVOICE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_PEMBELIAN";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_PEMBELIAN";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_REWORK";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID_REWORK";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "REWORK_INVOICE";
            this.dataGridViewTextBoxColumn6.HeaderText = "REWORK_INVOICE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "STOCK_HISTORY_VALUE";
            this.dataGridViewTextBoxColumn7.HeaderText = "STOCK_HISTORY_VALUE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "STOCK_HISTORY_DATE";
            this.dataGridViewTextBoxColumn8.HeaderText = "STOCK_HISTORY_DATE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // KartuStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 486);
            this.Controls.Add(this.stock_historyDataGridView);
            this.Controls.Add(iD_STOCKLabel);
            this.Controls.Add(this.iD_STOCKTextBox);
            this.Controls.Add(iD_BARANGLabel);
            this.Controls.Add(this.iD_BARANGTextBox);
            this.Controls.Add(sTOCK_MINLabel);
            this.Controls.Add(this.sTOCK_MINTextBox);
            this.Controls.Add(sTOCK_ON_HANDLabel);
            this.Controls.Add(this.sTOCK_ON_HANDTextBox);
            this.Controls.Add(this.stockBindingNavigator);
            this.Name = "KartuStok";
            this.Text = "KartuStok";
            this.Load += new System.EventHandler(this.KartuStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingNavigator)).EndInit();
            this.stockBindingNavigator.ResumeLayout(false);
            this.stockBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_historyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UASDataSet2 uASDataSet2;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private UASDataSet2TableAdapters.stockTableAdapter stockTableAdapter;
        private UASDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stockBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton stockBindingNavigatorSaveItem;
        private UASDataSet2TableAdapters.stock_historyTableAdapter stock_historyTableAdapter;
        private System.Windows.Forms.TextBox iD_STOCKTextBox;
        private System.Windows.Forms.TextBox iD_BARANGTextBox;
        private System.Windows.Forms.TextBox sTOCK_MINTextBox;
        private System.Windows.Forms.TextBox sTOCK_ON_HANDTextBox;
        private System.Windows.Forms.BindingSource stock_historyBindingSource;
        private System.Windows.Forms.DataGridView stock_historyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}