namespace ProjectPCSuas
{
    partial class SupplierDetail
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
            System.Windows.Forms.Label p_IDLabel;
            System.Windows.Forms.Label nAMALabel;
            System.Windows.Forms.Label aLAMATLabel;
            System.Windows.Forms.Label kOTALabel;
            System.Windows.Forms.Label tELP_HPLabel;
            System.Windows.Forms.Label nPWPLabel;
            System.Windows.Forms.Label nAMA_NPWPLabel;
            System.Windows.Forms.Label aLAMAT_NPWLabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label bANKLabel;
            System.Windows.Forms.Label nOTELabel;
            this.project_UASDataSet = new ProjectPCSuas.Project_UASDataSet();
            this.m_supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_supplierTableAdapter = new ProjectPCSuas.Project_UASDataSetTableAdapters.m_supplierTableAdapter();
            this.tableAdapterManager = new ProjectPCSuas.Project_UASDataSetTableAdapters.TableAdapterManager();
            this.p_IDTextBox = new System.Windows.Forms.TextBox();
            this.nAMATextBox = new System.Windows.Forms.TextBox();
            this.aLAMATTextBox = new System.Windows.Forms.TextBox();
            this.kOTATextBox = new System.Windows.Forms.TextBox();
            this.tELP_HPTextBox = new System.Windows.Forms.TextBox();
            this.nPWPTextBox = new System.Windows.Forms.TextBox();
            this.nAMA_NPWPTextBox = new System.Windows.Forms.TextBox();
            this.aLAMAT_NPWTextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.bANKTextBox = new System.Windows.Forms.TextBox();
            this.nOTETextBox = new System.Windows.Forms.TextBox();
            this.fillByPIdToolStrip = new System.Windows.Forms.ToolStrip();
            this.p_IDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.p_IDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByPIdToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            p_IDLabel = new System.Windows.Forms.Label();
            nAMALabel = new System.Windows.Forms.Label();
            aLAMATLabel = new System.Windows.Forms.Label();
            kOTALabel = new System.Windows.Forms.Label();
            tELP_HPLabel = new System.Windows.Forms.Label();
            nPWPLabel = new System.Windows.Forms.Label();
            nAMA_NPWPLabel = new System.Windows.Forms.Label();
            aLAMAT_NPWLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            bANKLabel = new System.Windows.Forms.Label();
            nOTELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.project_UASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingSource)).BeginInit();
            this.fillByPIdToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // project_UASDataSet
            // 
            this.project_UASDataSet.DataSetName = "Project_UASDataSet";
            this.project_UASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_supplierBindingSource
            // 
            this.m_supplierBindingSource.DataMember = "m_supplier";
            this.m_supplierBindingSource.DataSource = this.project_UASDataSet;
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
            // p_IDLabel
            // 
            p_IDLabel.AutoSize = true;
            p_IDLabel.Location = new System.Drawing.Point(11, 42);
            p_IDLabel.Name = "p_IDLabel";
            p_IDLabel.Size = new System.Drawing.Size(31, 13);
            p_IDLabel.TabIndex = 1;
            p_IDLabel.Text = "P ID:";
            // 
            // p_IDTextBox
            // 
            this.p_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "P_ID", true));
            this.p_IDTextBox.Location = new System.Drawing.Point(99, 39);
            this.p_IDTextBox.Name = "p_IDTextBox";
            this.p_IDTextBox.ReadOnly = true;
            this.p_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_IDTextBox.TabIndex = 2;
            // 
            // nAMALabel
            // 
            nAMALabel.AutoSize = true;
            nAMALabel.Location = new System.Drawing.Point(11, 68);
            nAMALabel.Name = "nAMALabel";
            nAMALabel.Size = new System.Drawing.Size(41, 13);
            nAMALabel.TabIndex = 3;
            nAMALabel.Text = "NAMA:";
            // 
            // nAMATextBox
            // 
            this.nAMATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NAMA", true));
            this.nAMATextBox.Location = new System.Drawing.Point(99, 65);
            this.nAMATextBox.Name = "nAMATextBox";
            this.nAMATextBox.Size = new System.Drawing.Size(100, 20);
            this.nAMATextBox.TabIndex = 4;
            // 
            // aLAMATLabel
            // 
            aLAMATLabel.AutoSize = true;
            aLAMATLabel.Location = new System.Drawing.Point(11, 94);
            aLAMATLabel.Name = "aLAMATLabel";
            aLAMATLabel.Size = new System.Drawing.Size(53, 13);
            aLAMATLabel.TabIndex = 5;
            aLAMATLabel.Text = "ALAMAT:";
            // 
            // aLAMATTextBox
            // 
            this.aLAMATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "ALAMAT", true));
            this.aLAMATTextBox.Location = new System.Drawing.Point(99, 91);
            this.aLAMATTextBox.Name = "aLAMATTextBox";
            this.aLAMATTextBox.Size = new System.Drawing.Size(100, 20);
            this.aLAMATTextBox.TabIndex = 6;
            // 
            // kOTALabel
            // 
            kOTALabel.AutoSize = true;
            kOTALabel.Location = new System.Drawing.Point(11, 120);
            kOTALabel.Name = "kOTALabel";
            kOTALabel.Size = new System.Drawing.Size(39, 13);
            kOTALabel.TabIndex = 7;
            kOTALabel.Text = "KOTA:";
            // 
            // kOTATextBox
            // 
            this.kOTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "KOTA", true));
            this.kOTATextBox.Location = new System.Drawing.Point(99, 117);
            this.kOTATextBox.Name = "kOTATextBox";
            this.kOTATextBox.Size = new System.Drawing.Size(100, 20);
            this.kOTATextBox.TabIndex = 8;
            // 
            // tELP_HPLabel
            // 
            tELP_HPLabel.AutoSize = true;
            tELP_HPLabel.Location = new System.Drawing.Point(11, 146);
            tELP_HPLabel.Name = "tELP_HPLabel";
            tELP_HPLabel.Size = new System.Drawing.Size(55, 13);
            tELP_HPLabel.TabIndex = 9;
            tELP_HPLabel.Text = "TELP HP:";
            // 
            // tELP_HPTextBox
            // 
            this.tELP_HPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "TELP_HP", true));
            this.tELP_HPTextBox.Location = new System.Drawing.Point(99, 143);
            this.tELP_HPTextBox.Name = "tELP_HPTextBox";
            this.tELP_HPTextBox.Size = new System.Drawing.Size(100, 20);
            this.tELP_HPTextBox.TabIndex = 10;
            // 
            // nPWPLabel
            // 
            nPWPLabel.AutoSize = true;
            nPWPLabel.Location = new System.Drawing.Point(11, 172);
            nPWPLabel.Name = "nPWPLabel";
            nPWPLabel.Size = new System.Drawing.Size(43, 13);
            nPWPLabel.TabIndex = 11;
            nPWPLabel.Text = "NPWP:";
            // 
            // nPWPTextBox
            // 
            this.nPWPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NPWP", true));
            this.nPWPTextBox.Location = new System.Drawing.Point(99, 169);
            this.nPWPTextBox.Name = "nPWPTextBox";
            this.nPWPTextBox.Size = new System.Drawing.Size(100, 20);
            this.nPWPTextBox.TabIndex = 12;
            // 
            // nAMA_NPWPLabel
            // 
            nAMA_NPWPLabel.AutoSize = true;
            nAMA_NPWPLabel.Location = new System.Drawing.Point(11, 198);
            nAMA_NPWPLabel.Name = "nAMA_NPWPLabel";
            nAMA_NPWPLabel.Size = new System.Drawing.Size(77, 13);
            nAMA_NPWPLabel.TabIndex = 13;
            nAMA_NPWPLabel.Text = "NAMA NPWP:";
            // 
            // nAMA_NPWPTextBox
            // 
            this.nAMA_NPWPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NAMA_NPWP", true));
            this.nAMA_NPWPTextBox.Location = new System.Drawing.Point(99, 195);
            this.nAMA_NPWPTextBox.Name = "nAMA_NPWPTextBox";
            this.nAMA_NPWPTextBox.Size = new System.Drawing.Size(100, 20);
            this.nAMA_NPWPTextBox.TabIndex = 14;
            // 
            // aLAMAT_NPWLabel
            // 
            aLAMAT_NPWLabel.AutoSize = true;
            aLAMAT_NPWLabel.Location = new System.Drawing.Point(11, 224);
            aLAMAT_NPWLabel.Name = "aLAMAT_NPWLabel";
            aLAMAT_NPWLabel.Size = new System.Drawing.Size(82, 13);
            aLAMAT_NPWLabel.TabIndex = 15;
            aLAMAT_NPWLabel.Text = "ALAMAT NPW:";
            // 
            // aLAMAT_NPWTextBox
            // 
            this.aLAMAT_NPWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "ALAMAT_NPW", true));
            this.aLAMAT_NPWTextBox.Location = new System.Drawing.Point(99, 221);
            this.aLAMAT_NPWTextBox.Name = "aLAMAT_NPWTextBox";
            this.aLAMAT_NPWTextBox.Size = new System.Drawing.Size(100, 20);
            this.aLAMAT_NPWTextBox.TabIndex = 16;
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(11, 250);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(42, 13);
            eMAILLabel.TabIndex = 17;
            eMAILLabel.Text = "EMAIL:";
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(99, 247);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(100, 20);
            this.eMAILTextBox.TabIndex = 18;
            // 
            // bANKLabel
            // 
            bANKLabel.AutoSize = true;
            bANKLabel.Location = new System.Drawing.Point(11, 276);
            bANKLabel.Name = "bANKLabel";
            bANKLabel.Size = new System.Drawing.Size(39, 13);
            bANKLabel.TabIndex = 19;
            bANKLabel.Text = "BANK:";
            // 
            // bANKTextBox
            // 
            this.bANKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "BANK", true));
            this.bANKTextBox.Location = new System.Drawing.Point(99, 273);
            this.bANKTextBox.Name = "bANKTextBox";
            this.bANKTextBox.Size = new System.Drawing.Size(100, 20);
            this.bANKTextBox.TabIndex = 20;
            // 
            // nOTELabel
            // 
            nOTELabel.AutoSize = true;
            nOTELabel.Location = new System.Drawing.Point(11, 302);
            nOTELabel.Name = "nOTELabel";
            nOTELabel.Size = new System.Drawing.Size(40, 13);
            nOTELabel.TabIndex = 21;
            nOTELabel.Text = "NOTE:";
            // 
            // nOTETextBox
            // 
            this.nOTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NOTE", true));
            this.nOTETextBox.Location = new System.Drawing.Point(99, 299);
            this.nOTETextBox.Name = "nOTETextBox";
            this.nOTETextBox.Size = new System.Drawing.Size(100, 20);
            this.nOTETextBox.TabIndex = 22;
            // 
            // fillByPIdToolStrip
            // 
            this.fillByPIdToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.p_IDToolStripLabel,
            this.p_IDToolStripTextBox,
            this.fillByPIdToolStripButton});
            this.fillByPIdToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByPIdToolStrip.Name = "fillByPIdToolStrip";
            this.fillByPIdToolStrip.Size = new System.Drawing.Size(241, 25);
            this.fillByPIdToolStrip.TabIndex = 23;
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
            this.p_IDToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillByPIdToolStripButton
            // 
            this.fillByPIdToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByPIdToolStripButton.Name = "fillByPIdToolStripButton";
            this.fillByPIdToolStripButton.Size = new System.Drawing.Size(56, 19);
            this.fillByPIdToolStripButton.Text = "FillByPId";
            this.fillByPIdToolStripButton.Click += new System.EventHandler(this.fillByPIdToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SupplierDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 379);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillByPIdToolStrip);
            this.Controls.Add(p_IDLabel);
            this.Controls.Add(this.p_IDTextBox);
            this.Controls.Add(nAMALabel);
            this.Controls.Add(this.nAMATextBox);
            this.Controls.Add(aLAMATLabel);
            this.Controls.Add(this.aLAMATTextBox);
            this.Controls.Add(kOTALabel);
            this.Controls.Add(this.kOTATextBox);
            this.Controls.Add(tELP_HPLabel);
            this.Controls.Add(this.tELP_HPTextBox);
            this.Controls.Add(nPWPLabel);
            this.Controls.Add(this.nPWPTextBox);
            this.Controls.Add(nAMA_NPWPLabel);
            this.Controls.Add(this.nAMA_NPWPTextBox);
            this.Controls.Add(aLAMAT_NPWLabel);
            this.Controls.Add(this.aLAMAT_NPWTextBox);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.eMAILTextBox);
            this.Controls.Add(bANKLabel);
            this.Controls.Add(this.bANKTextBox);
            this.Controls.Add(nOTELabel);
            this.Controls.Add(this.nOTETextBox);
            this.Name = "SupplierDetail";
            this.Text = "SupplierDetail";
            this.Load += new System.EventHandler(this.SupplierDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_UASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingSource)).EndInit();
            this.fillByPIdToolStrip.ResumeLayout(false);
            this.fillByPIdToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Project_UASDataSet project_UASDataSet;
        private System.Windows.Forms.BindingSource m_supplierBindingSource;
        private Project_UASDataSetTableAdapters.m_supplierTableAdapter m_supplierTableAdapter;
        private Project_UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox p_IDTextBox;
        private System.Windows.Forms.TextBox nAMATextBox;
        private System.Windows.Forms.TextBox aLAMATTextBox;
        private System.Windows.Forms.TextBox kOTATextBox;
        private System.Windows.Forms.TextBox tELP_HPTextBox;
        private System.Windows.Forms.TextBox nPWPTextBox;
        private System.Windows.Forms.TextBox nAMA_NPWPTextBox;
        private System.Windows.Forms.TextBox aLAMAT_NPWTextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox bANKTextBox;
        private System.Windows.Forms.TextBox nOTETextBox;
        private System.Windows.Forms.ToolStrip fillByPIdToolStrip;
        private System.Windows.Forms.ToolStripLabel p_IDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox p_IDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByPIdToolStripButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}