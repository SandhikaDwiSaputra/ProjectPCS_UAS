
namespace ProjectPCSuas
{
    partial class BrowseSuplier
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
            this.m_supplierDataGridView = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fillByPIdToolStrip = new System.Windows.Forms.ToolStrip();
            this.p_IDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.p_IDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByPIdToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_UASDataSet = new ProjectPCSuas.Project_UASDataSet();
            this.m_supplierTableAdapter = new ProjectPCSuas.Project_UASDataSetTableAdapters.m_supplierTableAdapter();
            this.tableAdapterManager = new ProjectPCSuas.Project_UASDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierDataGridView)).BeginInit();
            this.fillByPIdToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_UASDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // m_supplierDataGridView
            // 
            this.m_supplierDataGridView.AutoGenerateColumns = false;
            this.m_supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_supplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.View});
            this.m_supplierDataGridView.DataSource = this.m_supplierBindingSource;
            this.m_supplierDataGridView.Location = new System.Drawing.Point(10, 62);
            this.m_supplierDataGridView.Name = "m_supplierDataGridView";
            this.m_supplierDataGridView.Size = new System.Drawing.Size(1143, 295);
            this.m_supplierDataGridView.TabIndex = 1;
            this.m_supplierDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_supplierDataGridView_CellContentClick);
            // 
            // View
            // 
            this.View.DataPropertyName = "P_ID";
            this.View.HeaderText = "";
            this.View.Name = "View";
            this.View.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.View.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.View.Text = "Detail";
            this.View.UseColumnTextForButtonValue = true;
            // 
            // fillByPIdToolStrip
            // 
            this.fillByPIdToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.p_IDToolStripLabel,
            this.p_IDToolStripTextBox,
            this.fillByPIdToolStripButton});
            this.fillByPIdToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByPIdToolStrip.Name = "fillByPIdToolStrip";
            this.fillByPIdToolStrip.Size = new System.Drawing.Size(1173, 25);
            this.fillByPIdToolStrip.TabIndex = 2;
            this.fillByPIdToolStrip.Text = "fillByPIdToolStrip";
            // 
            // p_IDToolStripLabel
            // 
            this.p_IDToolStripLabel.Name = "p_IDToolStripLabel";
            this.p_IDToolStripLabel.Size = new System.Drawing.Size(33, 22);
            this.p_IDToolStripLabel.Text = "P_ID:";
            // 
            // p_IDToolStripTextBox
            // 
            this.p_IDToolStripTextBox.Name = "p_IDToolStripTextBox";
            this.p_IDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByPIdToolStripButton
            // 
            this.fillByPIdToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByPIdToolStripButton.Name = "fillByPIdToolStripButton";
            this.fillByPIdToolStripButton.Size = new System.Drawing.Size(56, 22);
            this.fillByPIdToolStripButton.Text = "FillByPId";
            this.fillByPIdToolStripButton.Click += new System.EventHandler(this.fillByPIdToolStripButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "P_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "P_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NAMA";
            this.dataGridViewTextBoxColumn2.HeaderText = "NAMA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ALAMAT";
            this.dataGridViewTextBoxColumn3.HeaderText = "ALAMAT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "KOTA";
            this.dataGridViewTextBoxColumn4.HeaderText = "KOTA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TELP_HP";
            this.dataGridViewTextBoxColumn5.HeaderText = "TELP_HP";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NPWP";
            this.dataGridViewTextBoxColumn6.HeaderText = "NPWP";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NAMA_NPWP";
            this.dataGridViewTextBoxColumn7.HeaderText = "NAMA_NPWP";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ALAMAT_NPW";
            this.dataGridViewTextBoxColumn8.HeaderText = "ALAMAT_NPW";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EMAIL";
            this.dataGridViewTextBoxColumn9.HeaderText = "EMAIL";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "BANK";
            this.dataGridViewTextBoxColumn10.HeaderText = "BANK";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "NOTE";
            this.dataGridViewTextBoxColumn11.HeaderText = "NOTE";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // m_supplierBindingSource
            // 
            this.m_supplierBindingSource.DataMember = "m_supplier";
            this.m_supplierBindingSource.DataSource = this.project_UASDataSet;
            // 
            // project_UASDataSet
            // 
            this.project_UASDataSet.DataSetName = "Project_UASDataSet";
            this.project_UASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_supplierTableAdapter
            // 
            this.m_supplierTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.m_supplierTableAdapter = this.m_supplierTableAdapter;
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
            this.tableAdapterManager.UpdateOrder = ProjectPCSuas.Project_UASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // BrowseSuplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 450);
            this.Controls.Add(this.fillByPIdToolStrip);
            this.Controls.Add(this.m_supplierDataGridView);
            this.Name = "BrowseSuplier";
            this.Text = "BrowseSuplier";
            this.Load += new System.EventHandler(this.BrowseSuplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierDataGridView)).EndInit();
            this.fillByPIdToolStrip.ResumeLayout(false);
            this.fillByPIdToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_UASDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Project_UASDataSet project_UASDataSet;
        private System.Windows.Forms.BindingSource m_supplierBindingSource;
        private Project_UASDataSetTableAdapters.m_supplierTableAdapter m_supplierTableAdapter;
        private Project_UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView m_supplierDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.ToolStrip fillByPIdToolStrip;
        private System.Windows.Forms.ToolStripLabel p_IDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox p_IDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByPIdToolStripButton;
    }
}