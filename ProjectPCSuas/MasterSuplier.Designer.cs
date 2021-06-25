
namespace ProjectPCSuas
{
    partial class MasterSuplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterSuplier));
            System.Windows.Forms.Label nOTELabel;
            System.Windows.Forms.Label bANKLabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label aLAMAT_NPWLabel;
            System.Windows.Forms.Label nAMA_NPWPLabel;
            System.Windows.Forms.Label nPWPLabel;
            System.Windows.Forms.Label tELP_HPLabel;
            System.Windows.Forms.Label kOTALabel;
            System.Windows.Forms.Label aLAMATLabel;
            System.Windows.Forms.Label nAMALabel;
            System.Windows.Forms.Label p_IDLabel;
            this.uASDataSet2 = new ProjectPCSuas.UASDataSet2();
            this.m_supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_supplierTableAdapter = new ProjectPCSuas.UASDataSet2TableAdapters.m_supplierTableAdapter();
            this.tableAdapterManager = new ProjectPCSuas.UASDataSet2TableAdapters.TableAdapterManager();
            this.m_supplierBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.m_supplierBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseBTN = new System.Windows.Forms.Button();
            this.nOTETextBox = new System.Windows.Forms.TextBox();
            this.bANKTextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.aLAMAT_NPWTextBox = new System.Windows.Forms.TextBox();
            this.nAMA_NPWPTextBox = new System.Windows.Forms.TextBox();
            this.nPWPTextBox = new System.Windows.Forms.TextBox();
            this.tELP_HPTextBox = new System.Windows.Forms.TextBox();
            this.kOTATextBox = new System.Windows.Forms.TextBox();
            this.aLAMATTextBox = new System.Windows.Forms.TextBox();
            this.nAMATextBox = new System.Windows.Forms.TextBox();
            this.p_IDTextBox = new System.Windows.Forms.TextBox();
            nOTELabel = new System.Windows.Forms.Label();
            bANKLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            aLAMAT_NPWLabel = new System.Windows.Forms.Label();
            nAMA_NPWPLabel = new System.Windows.Forms.Label();
            nPWPLabel = new System.Windows.Forms.Label();
            tELP_HPLabel = new System.Windows.Forms.Label();
            kOTALabel = new System.Windows.Forms.Label();
            aLAMATLabel = new System.Windows.Forms.Label();
            nAMALabel = new System.Windows.Forms.Label();
            p_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingNavigator)).BeginInit();
            this.m_supplierBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // uASDataSet2
            // 
            this.uASDataSet2.DataSetName = "UASDataSet2";
            this.uASDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_supplierBindingSource
            // 
            this.m_supplierBindingSource.DataMember = "m_supplier";
            this.m_supplierBindingSource.DataSource = this.uASDataSet2;
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
            this.tableAdapterManager.UpdateOrder = ProjectPCSuas.UASDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m_supplierBindingNavigator
            // 
            this.m_supplierBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_supplierBindingNavigator.BindingSource = this.m_supplierBindingSource;
            this.m_supplierBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_supplierBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_supplierBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.m_supplierBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_supplierBindingNavigatorSaveItem});
            this.m_supplierBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_supplierBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_supplierBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_supplierBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_supplierBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_supplierBindingNavigator.Name = "m_supplierBindingNavigator";
            this.m_supplierBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_supplierBindingNavigator.Size = new System.Drawing.Size(920, 27);
            this.m_supplierBindingNavigator.TabIndex = 0;
            this.m_supplierBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // m_supplierBindingNavigatorSaveItem
            // 
            this.m_supplierBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_supplierBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_supplierBindingNavigatorSaveItem.Image")));
            this.m_supplierBindingNavigatorSaveItem.Name = "m_supplierBindingNavigatorSaveItem";
            this.m_supplierBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.m_supplierBindingNavigatorSaveItem.Text = "Save Data";
            this.m_supplierBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_supplierBindingNavigatorSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "Master Suplier";
            // 
            // BrowseBTN
            // 
            this.BrowseBTN.Location = new System.Drawing.Point(520, 33);
            this.BrowseBTN.Name = "BrowseBTN";
            this.BrowseBTN.Size = new System.Drawing.Size(75, 23);
            this.BrowseBTN.TabIndex = 31;
            this.BrowseBTN.Text = "Browse";
            this.BrowseBTN.UseVisualStyleBackColor = true;
            this.BrowseBTN.Click += new System.EventHandler(this.BrowseBTN_Click);
            // 
            // nOTETextBox
            // 
            this.nOTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NOTE", true));
            this.nOTETextBox.Location = new System.Drawing.Point(99, 285);
            this.nOTETextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nOTETextBox.Name = "nOTETextBox";
            this.nOTETextBox.Size = new System.Drawing.Size(570, 20);
            this.nOTETextBox.TabIndex = 22;
            // 
            // nOTELabel
            // 
            nOTELabel.AutoSize = true;
            nOTELabel.Location = new System.Drawing.Point(17, 287);
            nOTELabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nOTELabel.Name = "nOTELabel";
            nOTELabel.Size = new System.Drawing.Size(40, 13);
            nOTELabel.TabIndex = 21;
            nOTELabel.Text = "NOTE:";
            // 
            // bANKTextBox
            // 
            this.bANKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "BANK", true));
            this.bANKTextBox.Location = new System.Drawing.Point(456, 87);
            this.bANKTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.bANKTextBox.Name = "bANKTextBox";
            this.bANKTextBox.Size = new System.Drawing.Size(210, 20);
            this.bANKTextBox.TabIndex = 20;
            // 
            // bANKLabel
            // 
            bANKLabel.AutoSize = true;
            bANKLabel.Location = new System.Drawing.Point(399, 90);
            bANKLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            bANKLabel.Name = "bANKLabel";
            bANKLabel.Size = new System.Drawing.Size(39, 13);
            bANKLabel.TabIndex = 19;
            bANKLabel.Text = "BANK:";
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(99, 241);
            this.eMAILTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(570, 20);
            this.eMAILTextBox.TabIndex = 18;
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(17, 243);
            eMAILLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(42, 13);
            eMAILLabel.TabIndex = 17;
            eMAILLabel.Text = "EMAIL:";
            // 
            // aLAMAT_NPWTextBox
            // 
            this.aLAMAT_NPWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "ALAMAT_NPW", true));
            this.aLAMAT_NPWTextBox.Location = new System.Drawing.Point(99, 198);
            this.aLAMAT_NPWTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.aLAMAT_NPWTextBox.Name = "aLAMAT_NPWTextBox";
            this.aLAMAT_NPWTextBox.Size = new System.Drawing.Size(570, 20);
            this.aLAMAT_NPWTextBox.TabIndex = 16;
            // 
            // aLAMAT_NPWLabel
            // 
            aLAMAT_NPWLabel.AutoSize = true;
            aLAMAT_NPWLabel.Location = new System.Drawing.Point(17, 201);
            aLAMAT_NPWLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            aLAMAT_NPWLabel.Name = "aLAMAT_NPWLabel";
            aLAMAT_NPWLabel.Size = new System.Drawing.Size(82, 13);
            aLAMAT_NPWLabel.TabIndex = 15;
            aLAMAT_NPWLabel.Text = "ALAMAT NPW:";
            // 
            // nAMA_NPWPTextBox
            // 
            this.nAMA_NPWPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NAMA_NPWP", true));
            this.nAMA_NPWPTextBox.Location = new System.Drawing.Point(99, 155);
            this.nAMA_NPWPTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nAMA_NPWPTextBox.Name = "nAMA_NPWPTextBox";
            this.nAMA_NPWPTextBox.Size = new System.Drawing.Size(296, 20);
            this.nAMA_NPWPTextBox.TabIndex = 14;
            // 
            // nAMA_NPWPLabel
            // 
            nAMA_NPWPLabel.AutoSize = true;
            nAMA_NPWPLabel.Location = new System.Drawing.Point(18, 158);
            nAMA_NPWPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nAMA_NPWPLabel.Name = "nAMA_NPWPLabel";
            nAMA_NPWPLabel.Size = new System.Drawing.Size(77, 13);
            nAMA_NPWPLabel.TabIndex = 13;
            nAMA_NPWPLabel.Text = "NAMA NPWP:";
            // 
            // nPWPTextBox
            // 
            this.nPWPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NPWP", true));
            this.nPWPTextBox.Location = new System.Drawing.Point(456, 156);
            this.nPWPTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nPWPTextBox.Name = "nPWPTextBox";
            this.nPWPTextBox.Size = new System.Drawing.Size(213, 20);
            this.nPWPTextBox.TabIndex = 12;
            // 
            // nPWPLabel
            // 
            nPWPLabel.AutoSize = true;
            nPWPLabel.Location = new System.Drawing.Point(399, 158);
            nPWPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nPWPLabel.Name = "nPWPLabel";
            nPWPLabel.Size = new System.Drawing.Size(43, 13);
            nPWPLabel.TabIndex = 11;
            nPWPLabel.Text = "NPWP:";
            // 
            // tELP_HPTextBox
            // 
            this.tELP_HPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "TELP_HP", true));
            this.tELP_HPTextBox.Location = new System.Drawing.Point(726, 87);
            this.tELP_HPTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.tELP_HPTextBox.Name = "tELP_HPTextBox";
            this.tELP_HPTextBox.Size = new System.Drawing.Size(186, 20);
            this.tELP_HPTextBox.TabIndex = 10;
            // 
            // tELP_HPLabel
            // 
            tELP_HPLabel.AutoSize = true;
            tELP_HPLabel.Location = new System.Drawing.Point(669, 89);
            tELP_HPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tELP_HPLabel.Name = "tELP_HPLabel";
            tELP_HPLabel.Size = new System.Drawing.Size(55, 13);
            tELP_HPLabel.TabIndex = 9;
            tELP_HPLabel.Text = "TELP HP:";
            // 
            // kOTATextBox
            // 
            this.kOTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "KOTA", true));
            this.kOTATextBox.Location = new System.Drawing.Point(726, 119);
            this.kOTATextBox.Margin = new System.Windows.Forms.Padding(2);
            this.kOTATextBox.Name = "kOTATextBox";
            this.kOTATextBox.Size = new System.Drawing.Size(186, 20);
            this.kOTATextBox.TabIndex = 8;
            // 
            // kOTALabel
            // 
            kOTALabel.AutoSize = true;
            kOTALabel.Location = new System.Drawing.Point(683, 120);
            kOTALabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            kOTALabel.Name = "kOTALabel";
            kOTALabel.Size = new System.Drawing.Size(39, 13);
            kOTALabel.TabIndex = 7;
            kOTALabel.Text = "KOTA:";
            // 
            // aLAMATTextBox
            // 
            this.aLAMATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "ALAMAT", true));
            this.aLAMATTextBox.Location = new System.Drawing.Point(456, 119);
            this.aLAMATTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.aLAMATTextBox.Name = "aLAMATTextBox";
            this.aLAMATTextBox.Size = new System.Drawing.Size(209, 20);
            this.aLAMATTextBox.TabIndex = 6;
            // 
            // aLAMATLabel
            // 
            aLAMATLabel.AutoSize = true;
            aLAMATLabel.Location = new System.Drawing.Point(399, 121);
            aLAMATLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            aLAMATLabel.Name = "aLAMATLabel";
            aLAMATLabel.Size = new System.Drawing.Size(53, 13);
            aLAMATLabel.TabIndex = 5;
            aLAMATLabel.Text = "ALAMAT:";
            // 
            // nAMATextBox
            // 
            this.nAMATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NAMA", true));
            this.nAMATextBox.Location = new System.Drawing.Point(99, 117);
            this.nAMATextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nAMATextBox.Name = "nAMATextBox";
            this.nAMATextBox.Size = new System.Drawing.Size(296, 20);
            this.nAMATextBox.TabIndex = 4;
            // 
            // nAMALabel
            // 
            nAMALabel.AutoSize = true;
            nAMALabel.Location = new System.Drawing.Point(18, 121);
            nAMALabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nAMALabel.Name = "nAMALabel";
            nAMALabel.Size = new System.Drawing.Size(41, 13);
            nAMALabel.TabIndex = 3;
            nAMALabel.Text = "NAMA:";
            // 
            // p_IDTextBox
            // 
            this.p_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "P_ID", true));
            this.p_IDTextBox.Location = new System.Drawing.Point(99, 87);
            this.p_IDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.p_IDTextBox.Name = "p_IDTextBox";
            this.p_IDTextBox.Size = new System.Drawing.Size(296, 20);
            this.p_IDTextBox.TabIndex = 2;
            // 
            // p_IDLabel
            // 
            p_IDLabel.AutoSize = true;
            p_IDLabel.Location = new System.Drawing.Point(17, 90);
            p_IDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            p_IDLabel.Name = "p_IDLabel";
            p_IDLabel.Size = new System.Drawing.Size(31, 13);
            p_IDLabel.TabIndex = 1;
            p_IDLabel.Text = "P ID:";
            // 
            // MasterSuplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 333);
            this.Controls.Add(this.BrowseBTN);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.m_supplierBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MasterSuplier";
            this.Text = "MasterSupplier";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingNavigator)).EndInit();
            this.m_supplierBindingNavigator.ResumeLayout(false);
            this.m_supplierBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UASDataSet2 uASDataSet2;
        private System.Windows.Forms.BindingSource m_supplierBindingSource;
        private UASDataSet2TableAdapters.m_supplierTableAdapter m_supplierTableAdapter;
        private UASDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_supplierBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_supplierBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowseBTN;
        private System.Windows.Forms.TextBox nOTETextBox;
        private System.Windows.Forms.TextBox bANKTextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox aLAMAT_NPWTextBox;
        private System.Windows.Forms.TextBox nAMA_NPWPTextBox;
        private System.Windows.Forms.TextBox nPWPTextBox;
        private System.Windows.Forms.TextBox tELP_HPTextBox;
        private System.Windows.Forms.TextBox kOTATextBox;
        private System.Windows.Forms.TextBox aLAMATTextBox;
        private System.Windows.Forms.TextBox nAMATextBox;
        private System.Windows.Forms.TextBox p_IDTextBox;
    }
}