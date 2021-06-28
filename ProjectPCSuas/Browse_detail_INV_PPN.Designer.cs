
namespace ProjectPCSuas
{
    partial class Browse_detail_INV_PPN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browse_detail_INV_PPN));
            this.project_UASDataSet = new ProjectPCSuas.Project_UASDataSet();
            this.t_invoiceppn_detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_invoiceppn_detailTableAdapter = new ProjectPCSuas.Project_UASDataSetTableAdapters.t_invoiceppn_detailTableAdapter();
            this.tableAdapterManager = new ProjectPCSuas.Project_UASDataSetTableAdapters.TableAdapterManager();
            this.t_invoiceppn_detailBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.t_invoiceppn_detailBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.t_invoiceppn_detailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.project_UASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_detailBindingNavigator)).BeginInit();
            this.t_invoiceppn_detailBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_detailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // project_UASDataSet
            // 
            this.project_UASDataSet.DataSetName = "Project_UASDataSet";
            this.project_UASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_invoiceppn_detailBindingSource
            // 
            this.t_invoiceppn_detailBindingSource.DataMember = "t_invoiceppn_detail";
            this.t_invoiceppn_detailBindingSource.DataSource = this.project_UASDataSet;
            // 
            // t_invoiceppn_detailTableAdapter
            // 
            this.t_invoiceppn_detailTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.stock_historyTableAdapter = null;
            this.tableAdapterManager.stockTableAdapter = null;
            this.tableAdapterManager.t_invoice_detailTableAdapter = null;
            this.tableAdapterManager.t_invoice_headerTableAdapter = null;
            this.tableAdapterManager.t_invoiceppn_detailTableAdapter = this.t_invoiceppn_detailTableAdapter;
            this.tableAdapterManager.t_invoiceppn_headerTableAdapter = null;
            this.tableAdapterManager.t_label_hargaTableAdapter = null;
            this.tableAdapterManager.t_pembelian_detailTableAdapter = null;
            this.tableAdapterManager.t_pembelian_headerTableAdapter = null;
            this.tableAdapterManager.t_penawaran_detailTableAdapter = null;
            this.tableAdapterManager.t_penawaran_headerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectPCSuas.Project_UASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_invoiceppn_detailBindingNavigator
            // 
            this.t_invoiceppn_detailBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_invoiceppn_detailBindingNavigator.BindingSource = this.t_invoiceppn_detailBindingSource;
            this.t_invoiceppn_detailBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_invoiceppn_detailBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_invoiceppn_detailBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.t_invoiceppn_detailBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_invoiceppn_detailBindingNavigatorSaveItem});
            this.t_invoiceppn_detailBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_invoiceppn_detailBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_invoiceppn_detailBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_invoiceppn_detailBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_invoiceppn_detailBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_invoiceppn_detailBindingNavigator.Name = "t_invoiceppn_detailBindingNavigator";
            this.t_invoiceppn_detailBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_invoiceppn_detailBindingNavigator.Size = new System.Drawing.Size(1223, 27);
            this.t_invoiceppn_detailBindingNavigator.TabIndex = 0;
            this.t_invoiceppn_detailBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // t_invoiceppn_detailBindingNavigatorSaveItem
            // 
            this.t_invoiceppn_detailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_invoiceppn_detailBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_invoiceppn_detailBindingNavigatorSaveItem.Image")));
            this.t_invoiceppn_detailBindingNavigatorSaveItem.Name = "t_invoiceppn_detailBindingNavigatorSaveItem";
            this.t_invoiceppn_detailBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.t_invoiceppn_detailBindingNavigatorSaveItem.Text = "Save Data";
            this.t_invoiceppn_detailBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_invoiceppn_detailBindingNavigatorSaveItem_Click);
            // 
            // t_invoiceppn_detailDataGridView
            // 
            this.t_invoiceppn_detailDataGridView.AutoGenerateColumns = false;
            this.t_invoiceppn_detailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_invoiceppn_detailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.t_invoiceppn_detailDataGridView.DataSource = this.t_invoiceppn_detailBindingSource;
            this.t_invoiceppn_detailDataGridView.Location = new System.Drawing.Point(12, 79);
            this.t_invoiceppn_detailDataGridView.Name = "t_invoiceppn_detailDataGridView";
            this.t_invoiceppn_detailDataGridView.RowHeadersWidth = 51;
            this.t_invoiceppn_detailDataGridView.RowTemplate.Height = 24;
            this.t_invoiceppn_detailDataGridView.Size = new System.Drawing.Size(1078, 220);
            this.t_invoiceppn_detailDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NO_INV";
            this.dataGridViewTextBoxColumn1.HeaderText = "NO_INV";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KODE";
            this.dataGridViewTextBoxColumn2.HeaderText = "KODE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PART_NO";
            this.dataGridViewTextBoxColumn3.HeaderText = "PART_NO";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DESCRIPTIO";
            this.dataGridViewTextBoxColumn4.HeaderText = "DESCRIPTIO";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "QTY";
            this.dataGridViewTextBoxColumn5.HeaderText = "QTY";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "QTY_M";
            this.dataGridViewTextBoxColumn6.HeaderText = "QTY_M";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UNIT_PRICE";
            this.dataGridViewTextBoxColumn7.HeaderText = "UNIT_PRICE";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UNIT_PRIC2";
            this.dataGridViewTextBoxColumn8.HeaderText = "UNIT_PRIC2";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // Browse_detail_INV_PPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 450);
            this.Controls.Add(this.t_invoiceppn_detailDataGridView);
            this.Controls.Add(this.t_invoiceppn_detailBindingNavigator);
            this.Name = "Browse_detail_INV_PPN";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Browse_detail_INV_PPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_UASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_detailBindingNavigator)).EndInit();
            this.t_invoiceppn_detailBindingNavigator.ResumeLayout(false);
            this.t_invoiceppn_detailBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_detailDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Project_UASDataSet project_UASDataSet;
        private System.Windows.Forms.BindingSource t_invoiceppn_detailBindingSource;
        private Project_UASDataSetTableAdapters.t_invoiceppn_detailTableAdapter t_invoiceppn_detailTableAdapter;
        private Project_UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_invoiceppn_detailBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_invoiceppn_detailBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView t_invoiceppn_detailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}