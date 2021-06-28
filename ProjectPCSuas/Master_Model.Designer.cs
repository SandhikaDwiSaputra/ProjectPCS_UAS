
namespace ProjectPCSuas
{
    partial class Master_Model
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
            System.Windows.Forms.Label dESCRIPTIONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master_Model));
            this.uASDataSet2 = new ProjectPCSuas.UASDataSet2();
            this.m_modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_modelTableAdapter = new ProjectPCSuas.UASDataSet2TableAdapters.m_modelTableAdapter();
            this.tableAdapterManager = new ProjectPCSuas.UASDataSet2TableAdapters.TableAdapterManager();
            this.m_modelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.m_modelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseBTN = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.TBcari = new System.Windows.Forms.TextBox();
            this.m_modelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MODEL_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DESCRIPTION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            dESCRIPTIONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_modelBindingNavigator)).BeginInit();
            this.m_modelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_modelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dESCRIPTIONLabel
            // 
            dESCRIPTIONLabel.AutoSize = true;
            dESCRIPTIONLabel.Location = new System.Drawing.Point(40, 163);
            dESCRIPTIONLabel.Name = "dESCRIPTIONLabel";
            dESCRIPTIONLabel.Size = new System.Drawing.Size(104, 17);
            dESCRIPTIONLabel.TabIndex = 3;
            dESCRIPTIONLabel.Text = "DESCRIPTION:";
            // 
            // uASDataSet2
            // 
            this.uASDataSet2.DataSetName = "UASDataSet2";
            this.uASDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_modelBindingSource
            // 
            this.m_modelBindingSource.DataMember = "m_model";
            this.m_modelBindingSource.DataSource = this.uASDataSet2;
            // 
            // m_modelTableAdapter
            // 
            this.m_modelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.m_barangTableAdapter = null;
            this.tableAdapterManager.m_groupuserTableAdapter = null;
            this.tableAdapterManager.m_hakaksesgroupuserTableAdapter = null;
            this.tableAdapterManager.m_kotaTableAdapter = null;
            this.tableAdapterManager.m_merkTableAdapter = null;
            this.tableAdapterManager.m_modelTableAdapter = this.m_modelTableAdapter;
            this.tableAdapterManager.m_pelangganTableAdapter = null;
            this.tableAdapterManager.m_supplierTableAdapter = null;
            this.tableAdapterManager.m_usersTableAdapter = null;
            this.tableAdapterManager.rework_detailTableAdapter = null;
            this.tableAdapterManager.reworkTableAdapter = null;
            this.tableAdapterManager.stock_historyTableAdapter = null;
            this.tableAdapterManager.stockTableAdapter = null;
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
            // m_modelBindingNavigator
            // 
            this.m_modelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_modelBindingNavigator.BindingSource = this.m_modelBindingSource;
            this.m_modelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_modelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_modelBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.m_modelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_modelBindingNavigatorSaveItem});
            this.m_modelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_modelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_modelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_modelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_modelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_modelBindingNavigator.Name = "m_modelBindingNavigator";
            this.m_modelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_modelBindingNavigator.Size = new System.Drawing.Size(824, 31);
            this.m_modelBindingNavigator.TabIndex = 0;
            this.m_modelBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // m_modelBindingNavigatorSaveItem
            // 
            this.m_modelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_modelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_modelBindingNavigatorSaveItem.Image")));
            this.m_modelBindingNavigatorSaveItem.Name = "m_modelBindingNavigatorSaveItem";
            this.m_modelBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.m_modelBindingNavigatorSaveItem.Text = "Save Data";
            this.m_modelBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_modelBindingNavigatorSaveItem_Click_1);
            // 
            // dESCRIPTIONTextBox
            // 
            this.dESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_modelBindingSource, "DESCRIPTION", true));
            this.dESCRIPTIONTextBox.Location = new System.Drawing.Point(150, 160);
            this.dESCRIPTIONTextBox.Name = "dESCRIPTIONTextBox";
            this.dESCRIPTIONTextBox.Size = new System.Drawing.Size(229, 22);
            this.dESCRIPTIONTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 36);
            this.label1.TabIndex = 32;
            this.label1.Text = "Input Master Model";
            // 
            // BrowseBTN
            // 
            this.BrowseBTN.Location = new System.Drawing.Point(547, 160);
            this.BrowseBTN.Name = "BrowseBTN";
            this.BrowseBTN.Size = new System.Drawing.Size(75, 23);
            this.BrowseBTN.TabIndex = 33;
            this.BrowseBTN.Text = "Browse";
            this.BrowseBTN.UseVisualStyleBackColor = true;
            this.BrowseBTN.Click += new System.EventHandler(this.BrowseBTN_Click);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(256, 211);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 34;
            this.btnCari.Text = "Search";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(385, 160);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 35;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(466, 160);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // TBcari
            // 
            this.TBcari.Location = new System.Drawing.Point(43, 211);
            this.TBcari.Name = "TBcari";
            this.TBcari.Size = new System.Drawing.Size(207, 22);
            this.TBcari.TabIndex = 37;
            // 
            // m_modelDataGridView
            // 
            this.m_modelDataGridView.AutoGenerateColumns = false;
            this.m_modelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_modelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ColumnDelete,
            this.ColumnEdit});
            this.m_modelDataGridView.DataSource = this.m_modelBindingSource;
            this.m_modelDataGridView.Location = new System.Drawing.Point(43, 262);
            this.m_modelDataGridView.Name = "m_modelDataGridView";
            this.m_modelDataGridView.RowHeadersWidth = 51;
            this.m_modelDataGridView.RowTemplate.Height = 24;
            this.m_modelDataGridView.Size = new System.Drawing.Size(738, 220);
            this.m_modelDataGridView.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MODEL_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MODEL_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DESCRIPTION";
            this.dataGridViewTextBoxColumn2.HeaderText = "DESCRIPTION";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.MinimumWidth = 6;
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Text = "Delete";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            this.ColumnDelete.Width = 125;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.HeaderText = "";
            this.ColumnEdit.MinimumWidth = 6;
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.Text = "Edit";
            this.ColumnEdit.UseColumnTextForButtonValue = true;
            this.ColumnEdit.Width = 125;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MODEL_ID,
            this.DESCRIPTION});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(854, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 38;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // MODEL_ID
            // 
            this.MODEL_ID.Text = "ID";
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.Text = "Description";
            // 
            // Master_Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 522);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.m_modelDataGridView);
            this.Controls.Add(this.TBcari);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.BrowseBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(dESCRIPTIONLabel);
            this.Controls.Add(this.dESCRIPTIONTextBox);
            this.Controls.Add(this.m_modelBindingNavigator);
            this.Name = "Master_Model";
            this.Text = "Master_Model";
            this.Load += new System.EventHandler(this.Master_Model_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_modelBindingNavigator)).EndInit();
            this.m_modelBindingNavigator.ResumeLayout(false);
            this.m_modelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_modelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UASDataSet2 uASDataSet2;
        private System.Windows.Forms.BindingSource m_modelBindingSource;
        private UASDataSet2TableAdapters.m_modelTableAdapter m_modelTableAdapter;
        private UASDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_modelBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_modelBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dESCRIPTIONTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowseBTN;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox TBcari;
        private System.Windows.Forms.DataGridView m_modelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEdit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MODEL_ID;
        private System.Windows.Forms.ColumnHeader DESCRIPTION;
    }
}