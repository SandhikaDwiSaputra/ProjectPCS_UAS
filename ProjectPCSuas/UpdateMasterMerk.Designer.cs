namespace ProjectPCSuas
{
    partial class UpdateMasterMerk
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
            System.Windows.Forms.Label iDLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.mERK_DESCTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.project_UASDataSet = new ProjectPCSuas.Project_UASDataSet();
            this.m_merkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_merkTableAdapter = new ProjectPCSuas.Project_UASDataSetTableAdapters.m_merkTableAdapter();
            this.tableAdapterManager = new ProjectPCSuas.Project_UASDataSetTableAdapters.TableAdapterManager();
            mERK_DESCLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.project_UASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_merkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mERK_DESCLabel
            // 
            mERK_DESCLabel.AutoSize = true;
            mERK_DESCLabel.Location = new System.Drawing.Point(31, 77);
            mERK_DESCLabel.Name = "mERK_DESCLabel";
            mERK_DESCLabel.Size = new System.Drawing.Size(73, 13);
            mERK_DESCLabel.TabIndex = 13;
            mERK_DESCLabel.Text = "MERK DESC:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(31, 51);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 11;
            iDLabel.Text = "ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mERK_DESCTextBox
            // 
            this.mERK_DESCTextBox.Location = new System.Drawing.Point(110, 74);
            this.mERK_DESCTextBox.Name = "mERK_DESCTextBox";
            this.mERK_DESCTextBox.Size = new System.Drawing.Size(100, 20);
            this.mERK_DESCTextBox.TabIndex = 14;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Location = new System.Drawing.Point(110, 48);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 12;
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
            // UpdateMasterMerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(mERK_DESCLabel);
            this.Controls.Add(this.mERK_DESCTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Name = "UpdateMasterMerk";
            this.Text = "UpdateMasterMerk";
            this.Load += new System.EventHandler(this.UpdateMasterMerk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_UASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_merkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mERK_DESCTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private Project_UASDataSet project_UASDataSet;
        private System.Windows.Forms.BindingSource m_merkBindingSource;
        private Project_UASDataSetTableAdapters.m_merkTableAdapter m_merkTableAdapter;
        private Project_UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}