
namespace ProjectPCSuas
{
    partial class MasterBarang
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
            System.Windows.Forms.Label kODELabel;
            System.Windows.Forms.Label pART_NOLabel;
            System.Windows.Forms.Label pN1Label;
            System.Windows.Forms.Label uNIT_PRICELabel;
            System.Windows.Forms.Label dESCRIPTIONLabel;
            System.Windows.Forms.Label uNITLabel;
            System.Windows.Forms.Label sTAMPINGLabel;
            System.Windows.Forms.Label dATA_FISIKLabel;
            System.Windows.Forms.Label pERSAMAANLabel;
            System.Windows.Forms.Label mERK1Label;
            System.Windows.Forms.Label mERK2Label;
            System.Windows.Forms.Label mERK3Label;
            System.Windows.Forms.Label kETERANGANLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterBarang));
            this.uASDataSet2 = new ProjectPCSuas.UASDataSet2();
            this.m_barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_barangTableAdapter = new ProjectPCSuas.UASDataSet2TableAdapters.m_barangTableAdapter();
            this.tableAdapterManager = new ProjectPCSuas.UASDataSet2TableAdapters.TableAdapterManager();
            this.m_barangBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.m_barangBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kODETextBox = new System.Windows.Forms.TextBox();
            this.pART_NOTextBox = new System.Windows.Forms.TextBox();
            this.pN1TextBox = new System.Windows.Forms.TextBox();
            this.uNIT_PRICETextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            this.uNITTextBox = new System.Windows.Forms.TextBox();
            this.sTAMPINGTextBox = new System.Windows.Forms.TextBox();
            this.dATA_FISIKTextBox = new System.Windows.Forms.TextBox();
            this.pERSAMAANTextBox = new System.Windows.Forms.TextBox();
            this.mERK1TextBox = new System.Windows.Forms.TextBox();
            this.mERK2TextBox = new System.Windows.Forms.TextBox();
            this.mERK3TextBox = new System.Windows.Forms.TextBox();
            this.kETERANGANTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseBTN = new System.Windows.Forms.Button();
            kODELabel = new System.Windows.Forms.Label();
            pART_NOLabel = new System.Windows.Forms.Label();
            pN1Label = new System.Windows.Forms.Label();
            uNIT_PRICELabel = new System.Windows.Forms.Label();
            dESCRIPTIONLabel = new System.Windows.Forms.Label();
            uNITLabel = new System.Windows.Forms.Label();
            sTAMPINGLabel = new System.Windows.Forms.Label();
            dATA_FISIKLabel = new System.Windows.Forms.Label();
            pERSAMAANLabel = new System.Windows.Forms.Label();
            mERK1Label = new System.Windows.Forms.Label();
            mERK2Label = new System.Windows.Forms.Label();
            mERK3Label = new System.Windows.Forms.Label();
            kETERANGANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingNavigator)).BeginInit();
            this.m_barangBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // kODELabel
            // 
            kODELabel.AutoSize = true;
            kODELabel.Location = new System.Drawing.Point(17, 132);
            kODELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            kODELabel.Name = "kODELabel";
            kODELabel.Size = new System.Drawing.Size(91, 17);
            kODELabel.TabIndex = 1;
            kODELabel.Text = "Kode Barang";
            kODELabel.Click += new System.EventHandler(this.kODELabel_Click);
            // 
            // pART_NOLabel
            // 
            pART_NOLabel.AutoSize = true;
            pART_NOLabel.Location = new System.Drawing.Point(256, 132);
            pART_NOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pART_NOLabel.Name = "pART_NOLabel";
            pART_NOLabel.Size = new System.Drawing.Size(88, 17);
            pART_NOLabel.TabIndex = 3;
            pART_NOLabel.Text = "Part Number";
            // 
            // pN1Label
            // 
            pN1Label.AutoSize = true;
            pN1Label.Location = new System.Drawing.Point(511, 132);
            pN1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pN1Label.Name = "pN1Label";
            pN1Label.Size = new System.Drawing.Size(51, 17);
            pN1Label.TabIndex = 5;
            pN1Label.Text = "P / N 1";
            // 
            // uNIT_PRICELabel
            // 
            uNIT_PRICELabel.AutoSize = true;
            uNIT_PRICELabel.Location = new System.Drawing.Point(767, 132);
            uNIT_PRICELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            uNIT_PRICELabel.Name = "uNIT_PRICELabel";
            uNIT_PRICELabel.Size = new System.Drawing.Size(96, 17);
            uNIT_PRICELabel.TabIndex = 7;
            uNIT_PRICELabel.Text = "Harga Satuan";
            // 
            // dESCRIPTIONLabel
            // 
            dESCRIPTIONLabel.AutoSize = true;
            dESCRIPTIONLabel.Location = new System.Drawing.Point(16, 181);
            dESCRIPTIONLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dESCRIPTIONLabel.Name = "dESCRIPTIONLabel";
            dESCRIPTIONLabel.Size = new System.Drawing.Size(95, 17);
            dESCRIPTIONLabel.TabIndex = 9;
            dESCRIPTIONLabel.Text = "Nama Barang";
            // 
            // uNITLabel
            // 
            uNITLabel.AutoSize = true;
            uNITLabel.Location = new System.Drawing.Point(440, 185);
            uNITLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            uNITLabel.Name = "uNITLabel";
            uNITLabel.Size = new System.Drawing.Size(33, 17);
            uNITLabel.TabIndex = 11;
            uNITLabel.Text = "Unit";
            // 
            // sTAMPINGLabel
            // 
            sTAMPINGLabel.AutoSize = true;
            sTAMPINGLabel.Location = new System.Drawing.Point(16, 247);
            sTAMPINGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sTAMPINGLabel.Name = "sTAMPINGLabel";
            sTAMPINGLabel.Size = new System.Drawing.Size(67, 17);
            sTAMPINGLabel.TabIndex = 13;
            sTAMPINGLabel.Text = "Stamping";
            // 
            // dATA_FISIKLabel
            // 
            dATA_FISIKLabel.AutoSize = true;
            dATA_FISIKLabel.Location = new System.Drawing.Point(256, 251);
            dATA_FISIKLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dATA_FISIKLabel.Name = "dATA_FISIKLabel";
            dATA_FISIKLabel.Size = new System.Drawing.Size(70, 17);
            dATA_FISIKLabel.TabIndex = 15;
            dATA_FISIKLabel.Text = "Data Fisik";
            // 
            // pERSAMAANLabel
            // 
            pERSAMAANLabel.AutoSize = true;
            pERSAMAANLabel.Location = new System.Drawing.Point(511, 251);
            pERSAMAANLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pERSAMAANLabel.Name = "pERSAMAANLabel";
            pERSAMAANLabel.Size = new System.Drawing.Size(85, 17);
            pERSAMAANLabel.TabIndex = 17;
            pERSAMAANLabel.Text = "Perrsamaan";
            // 
            // mERK1Label
            // 
            mERK1Label.AutoSize = true;
            mERK1Label.Location = new System.Drawing.Point(17, 315);
            mERK1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mERK1Label.Name = "mERK1Label";
            mERK1Label.Size = new System.Drawing.Size(51, 17);
            mERK1Label.TabIndex = 19;
            mERK1Label.Text = "Merk 1";
            // 
            // mERK2Label
            // 
            mERK2Label.AutoSize = true;
            mERK2Label.Location = new System.Drawing.Point(256, 314);
            mERK2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mERK2Label.Name = "mERK2Label";
            mERK2Label.Size = new System.Drawing.Size(51, 17);
            mERK2Label.TabIndex = 21;
            mERK2Label.Text = "Merk 2";
            // 
            // mERK3Label
            // 
            mERK3Label.AutoSize = true;
            mERK3Label.Location = new System.Drawing.Point(511, 314);
            mERK3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mERK3Label.Name = "mERK3Label";
            mERK3Label.Size = new System.Drawing.Size(51, 17);
            mERK3Label.TabIndex = 23;
            mERK3Label.Text = "Merk 3";
            // 
            // kETERANGANLabel
            // 
            kETERANGANLabel.AutoSize = true;
            kETERANGANLabel.Location = new System.Drawing.Point(17, 389);
            kETERANGANLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            kETERANGANLabel.Name = "kETERANGANLabel";
            kETERANGANLabel.Size = new System.Drawing.Size(38, 17);
            kETERANGANLabel.TabIndex = 25;
            kETERANGANLabel.Text = "Note";
            // 
            // uASDataSet2
            // 
            this.uASDataSet2.DataSetName = "UASDataSet2";
            this.uASDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_barangBindingSource
            // 
            this.m_barangBindingSource.DataMember = "m_barang";
            this.m_barangBindingSource.DataSource = this.uASDataSet2;
            // 
            // m_barangTableAdapter
            // 
            this.m_barangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.m_barangTableAdapter = this.m_barangTableAdapter;
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
            this.tableAdapterManager.t_invoiceppn_detailTableAdapter = null;
            this.tableAdapterManager.t_invoiceppn_headerTableAdapter = null;
            this.tableAdapterManager.t_label_hargaTableAdapter = null;
            this.tableAdapterManager.t_pembelian_detailTableAdapter = null;
            this.tableAdapterManager.t_pembelian_headerTableAdapter = null;
            this.tableAdapterManager.t_penawaran_detailTableAdapter = null;
            this.tableAdapterManager.t_penawaran_headerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectPCSuas.UASDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m_barangBindingNavigator
            // 
            this.m_barangBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_barangBindingNavigator.BindingSource = this.m_barangBindingSource;
            this.m_barangBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_barangBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_barangBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.m_barangBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_barangBindingNavigatorSaveItem});
            this.m_barangBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_barangBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_barangBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_barangBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_barangBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_barangBindingNavigator.Name = "m_barangBindingNavigator";
            this.m_barangBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_barangBindingNavigator.Size = new System.Drawing.Size(1067, 27);
            this.m_barangBindingNavigator.TabIndex = 0;
            this.m_barangBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // m_barangBindingNavigatorSaveItem
            // 
            this.m_barangBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_barangBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_barangBindingNavigatorSaveItem.Image")));
            this.m_barangBindingNavigatorSaveItem.Name = "m_barangBindingNavigatorSaveItem";
            this.m_barangBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.m_barangBindingNavigatorSaveItem.Text = "Save Data";
            this.m_barangBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_barangBindingNavigatorSaveItem_Click);
            // 
            // kODETextBox
            // 
            this.kODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "KODE", true));
            this.kODETextBox.Location = new System.Drawing.Point(113, 128);
            this.kODETextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kODETextBox.Name = "kODETextBox";
            this.kODETextBox.Size = new System.Drawing.Size(132, 22);
            this.kODETextBox.TabIndex = 2;
            // 
            // pART_NOTextBox
            // 
            this.pART_NOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "PART_NO", true));
            this.pART_NOTextBox.Location = new System.Drawing.Point(355, 128);
            this.pART_NOTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pART_NOTextBox.Name = "pART_NOTextBox";
            this.pART_NOTextBox.Size = new System.Drawing.Size(132, 22);
            this.pART_NOTextBox.TabIndex = 4;
            // 
            // pN1TextBox
            // 
            this.pN1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "PN1", true));
            this.pN1TextBox.Location = new System.Drawing.Point(597, 128);
            this.pN1TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pN1TextBox.Name = "pN1TextBox";
            this.pN1TextBox.Size = new System.Drawing.Size(156, 22);
            this.pN1TextBox.TabIndex = 6;
            // 
            // uNIT_PRICETextBox
            // 
            this.uNIT_PRICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "UNIT_PRICE", true));
            this.uNIT_PRICETextBox.Location = new System.Drawing.Point(869, 128);
            this.uNIT_PRICETextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uNIT_PRICETextBox.Name = "uNIT_PRICETextBox";
            this.uNIT_PRICETextBox.Size = new System.Drawing.Size(132, 22);
            this.uNIT_PRICETextBox.TabIndex = 8;
            // 
            // dESCRIPTIONTextBox
            // 
            this.dESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "DESCRIPTION", true));
            this.dESCRIPTIONTextBox.Location = new System.Drawing.Point(113, 177);
            this.dESCRIPTIONTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dESCRIPTIONTextBox.Name = "dESCRIPTIONTextBox";
            this.dESCRIPTIONTextBox.Size = new System.Drawing.Size(317, 22);
            this.dESCRIPTIONTextBox.TabIndex = 10;
            // 
            // uNITTextBox
            // 
            this.uNITTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "UNIT", true));
            this.uNITTextBox.Location = new System.Drawing.Point(496, 181);
            this.uNITTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uNITTextBox.Name = "uNITTextBox";
            this.uNITTextBox.Size = new System.Drawing.Size(456, 22);
            this.uNITTextBox.TabIndex = 12;
            // 
            // sTAMPINGTextBox
            // 
            this.sTAMPINGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "STAMPING", true));
            this.sTAMPINGTextBox.Location = new System.Drawing.Point(113, 244);
            this.sTAMPINGTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sTAMPINGTextBox.Name = "sTAMPINGTextBox";
            this.sTAMPINGTextBox.Size = new System.Drawing.Size(132, 22);
            this.sTAMPINGTextBox.TabIndex = 14;
            // 
            // dATA_FISIKTextBox
            // 
            this.dATA_FISIKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "DATA_FISIK", true));
            this.dATA_FISIKTextBox.Location = new System.Drawing.Point(355, 247);
            this.dATA_FISIKTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dATA_FISIKTextBox.Name = "dATA_FISIKTextBox";
            this.dATA_FISIKTextBox.Size = new System.Drawing.Size(132, 22);
            this.dATA_FISIKTextBox.TabIndex = 16;
            // 
            // pERSAMAANTextBox
            // 
            this.pERSAMAANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "PERSAMAAN", true));
            this.pERSAMAANTextBox.Location = new System.Drawing.Point(621, 247);
            this.pERSAMAANTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pERSAMAANTextBox.Name = "pERSAMAANTextBox";
            this.pERSAMAANTextBox.Size = new System.Drawing.Size(132, 22);
            this.pERSAMAANTextBox.TabIndex = 18;
            // 
            // mERK1TextBox
            // 
            this.mERK1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "MERK1", true));
            this.mERK1TextBox.Location = new System.Drawing.Point(113, 310);
            this.mERK1TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mERK1TextBox.Name = "mERK1TextBox";
            this.mERK1TextBox.Size = new System.Drawing.Size(132, 22);
            this.mERK1TextBox.TabIndex = 20;
            // 
            // mERK2TextBox
            // 
            this.mERK2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "MERK2", true));
            this.mERK2TextBox.Location = new System.Drawing.Point(355, 310);
            this.mERK2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mERK2TextBox.Name = "mERK2TextBox";
            this.mERK2TextBox.Size = new System.Drawing.Size(132, 22);
            this.mERK2TextBox.TabIndex = 22;
            // 
            // mERK3TextBox
            // 
            this.mERK3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "MERK3", true));
            this.mERK3TextBox.Location = new System.Drawing.Point(621, 311);
            this.mERK3TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mERK3TextBox.Name = "mERK3TextBox";
            this.mERK3TextBox.Size = new System.Drawing.Size(132, 22);
            this.mERK3TextBox.TabIndex = 24;
            // 
            // kETERANGANTextBox
            // 
            this.kETERANGANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "KETERANGAN", true));
            this.kETERANGANTextBox.Location = new System.Drawing.Point(113, 385);
            this.kETERANGANTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kETERANGANTextBox.Name = "kETERANGANTextBox";
            this.kETERANGANTextBox.Size = new System.Drawing.Size(640, 22);
            this.kETERANGANTextBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "Input Master Barang";
            // 
            // BrowseBTN
            // 
            this.BrowseBTN.Location = new System.Drawing.Point(697, 53);
            this.BrowseBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrowseBTN.Name = "BrowseBTN";
            this.BrowseBTN.Size = new System.Drawing.Size(100, 28);
            this.BrowseBTN.TabIndex = 28;
            this.BrowseBTN.Text = "Browse";
            this.BrowseBTN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BrowseBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(kETERANGANLabel);
            this.Controls.Add(this.kETERANGANTextBox);
            this.Controls.Add(mERK3Label);
            this.Controls.Add(this.mERK3TextBox);
            this.Controls.Add(mERK2Label);
            this.Controls.Add(this.mERK2TextBox);
            this.Controls.Add(mERK1Label);
            this.Controls.Add(this.mERK1TextBox);
            this.Controls.Add(pERSAMAANLabel);
            this.Controls.Add(this.pERSAMAANTextBox);
            this.Controls.Add(dATA_FISIKLabel);
            this.Controls.Add(this.dATA_FISIKTextBox);
            this.Controls.Add(sTAMPINGLabel);
            this.Controls.Add(this.sTAMPINGTextBox);
            this.Controls.Add(uNITLabel);
            this.Controls.Add(this.uNITTextBox);
            this.Controls.Add(dESCRIPTIONLabel);
            this.Controls.Add(this.dESCRIPTIONTextBox);
            this.Controls.Add(uNIT_PRICELabel);
            this.Controls.Add(this.uNIT_PRICETextBox);
            this.Controls.Add(pN1Label);
            this.Controls.Add(this.pN1TextBox);
            this.Controls.Add(pART_NOLabel);
            this.Controls.Add(this.pART_NOTextBox);
            this.Controls.Add(kODELabel);
            this.Controls.Add(this.kODETextBox);
            this.Controls.Add(this.m_barangBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingNavigator)).EndInit();
            this.m_barangBindingNavigator.ResumeLayout(false);
            this.m_barangBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UASDataSet2 uASDataSet2;
        private System.Windows.Forms.BindingSource m_barangBindingSource;
        private UASDataSet2TableAdapters.m_barangTableAdapter m_barangTableAdapter;
        private UASDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_barangBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_barangBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox kODETextBox;
        private System.Windows.Forms.TextBox pART_NOTextBox;
        private System.Windows.Forms.TextBox pN1TextBox;
        private System.Windows.Forms.TextBox uNIT_PRICETextBox;
        private System.Windows.Forms.TextBox dESCRIPTIONTextBox;
        private System.Windows.Forms.TextBox uNITTextBox;
        private System.Windows.Forms.TextBox sTAMPINGTextBox;
        private System.Windows.Forms.TextBox dATA_FISIKTextBox;
        private System.Windows.Forms.TextBox pERSAMAANTextBox;
        private System.Windows.Forms.TextBox mERK1TextBox;
        private System.Windows.Forms.TextBox mERK2TextBox;
        private System.Windows.Forms.TextBox mERK3TextBox;
        private System.Windows.Forms.TextBox kETERANGANTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowseBTN;
    }
}

