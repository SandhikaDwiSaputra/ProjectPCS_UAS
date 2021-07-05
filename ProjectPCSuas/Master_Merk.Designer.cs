
namespace ProjectPCSuas
{
    partial class Master_Merk
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
            System.Windows.Forms.Label mERK_DESCLabel;
            this.project_UASDataSet = new ProjectPCSuas.Project_UASDataSet();
            this.m_merkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_merkTableAdapter = new ProjectPCSuas.Project_UASDataSetTableAdapters.m_merkTableAdapter();
            this.tableAdapterManager = new ProjectPCSuas.Project_UASDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.TBcari = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mERK_DESCTextBox = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_merkDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            mERK_DESCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.project_UASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_merkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_merkDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mERK_DESCLabel
            // 
            mERK_DESCLabel.AutoSize = true;
            mERK_DESCLabel.Location = new System.Drawing.Point(35, 161);
            mERK_DESCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mERK_DESCLabel.Name = "mERK_DESCLabel";
            mERK_DESCLabel.Size = new System.Drawing.Size(92, 17);
            mERK_DESCLabel.TabIndex = 6;
            mERK_DESCLabel.Text = "MERK DESC:";
            // 
            // project_UASDataSet
            // 
            this.project_UASDataSet.DataSetName = "Project_UASDataSet";
            this.project_UASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_merkBindingSource
            // 
            this.m_merkBindingSource.DataMember = "m_merk";
            this.m_merkBindingSource.DataSource = this.project_UASDataSet;
            // 
            // m_merkTableAdapter
            // 
            this.m_merkTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.m_barangTableAdapter = null;
            this.tableAdapterManager.m_groupuserTableAdapter = null;
            this.tableAdapterManager.m_hakaksesgroupuserTableAdapter = null;
            this.tableAdapterManager.m_kotaTableAdapter = null;
            this.tableAdapterManager.m_merkTableAdapter = this.m_merkTableAdapter;
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
            this.tableAdapterManager.t_invoiceppn_detailTableAdapter = null;
            this.tableAdapterManager.t_invoiceppn_headerTableAdapter = null;
            this.tableAdapterManager.t_label_hargaTableAdapter = null;
            this.tableAdapterManager.t_pembelian_detailTableAdapter = null;
            this.tableAdapterManager.t_pembelian_headerTableAdapter = null;
            this.tableAdapterManager.t_penawaran_detailTableAdapter = null;
            this.tableAdapterManager.t_penawaran_headerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectPCSuas.Project_UASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 36);
            this.label1.TabIndex = 31;
            this.label1.Text = "Input Master Merk";
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Merk_Desc";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(987, 110);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(176, 118);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // TBcari
            // 
            this.TBcari.Location = new System.Drawing.Point(32, 223);
            this.TBcari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBcari.Name = "TBcari";
            this.TBcari.Size = new System.Drawing.Size(176, 22);
            this.TBcari.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 223);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "cari";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mERK_DESCTextBox
            // 
            this.mERK_DESCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_merkBindingSource, "MERK_DESC", true));
            this.mERK_DESCTextBox.Location = new System.Drawing.Point(140, 158);
            this.mERK_DESCTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mERK_DESCTextBox.Name = "mERK_DESCTextBox";
            this.mERK_DESCTextBox.Size = new System.Drawing.Size(132, 22);
            this.mERK_DESCTextBox.TabIndex = 7;
            this.mERK_DESCTextBox.TextChanged += new System.EventHandler(this.mERK_DESCTextBox_TextChanged);
            // 
            // Update
            // 
            this.Update.DataPropertyName = "ID";
            this.Update.HeaderText = "";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 125;
            // 
            // Button
            // 
            this.Button.DataPropertyName = "ID";
            this.Button.HeaderText = "";
            this.Button.MinimumWidth = 6;
            this.Button.Name = "Button";
            this.Button.ReadOnly = true;
            this.Button.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Button.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Button.Text = "Delete";
            this.Button.UseColumnTextForButtonValue = true;
            this.Button.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MERK_DESC";
            this.dataGridViewTextBoxColumn2.HeaderText = "MERK_DESC";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // m_merkDataGridView
            // 
            this.m_merkDataGridView.AutoGenerateColumns = false;
            this.m_merkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_merkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Button,
            this.Update});
            this.m_merkDataGridView.DataSource = this.m_merkBindingSource;
            this.m_merkDataGridView.Location = new System.Drawing.Point(32, 255);
            this.m_merkDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_merkDataGridView.Name = "m_merkDataGridView";
            this.m_merkDataGridView.RowHeadersWidth = 51;
            this.m_merkDataGridView.Size = new System.Drawing.Size(591, 250);
            this.m_merkDataGridView.TabIndex = 33;
            this.m_merkDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_merkDataGridView_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 154);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 34;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(389, 154);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 37;
            this.button5.Text = "Print";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Master_Merk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 554);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.m_merkDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(mERK_DESCLabel);
            this.Controls.Add(this.mERK_DESCTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBcari);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Master_Merk";
            this.Text = "MasterMerk";
            this.Load += new System.EventHandler(this.MasterMerk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_UASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_merkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_merkDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Project_UASDataSet project_UASDataSet;
        private System.Windows.Forms.BindingSource m_merkBindingSource;
        private Project_UASDataSetTableAdapters.m_merkTableAdapter m_merkTableAdapter;
        private Project_UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox TBcari;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mERK_DESCTextBox;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView m_merkDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}