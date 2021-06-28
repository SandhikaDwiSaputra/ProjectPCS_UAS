
namespace ProjectPCSuas
{
    partial class Header_INV_PPN
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
            System.Windows.Forms.Label nO_INVLabel;
            System.Windows.Forms.Label nO_PNWLabel;
            System.Windows.Forms.Label tGL_INVLabel;
            System.Windows.Forms.Label tGL_TERIMALabel;
            System.Windows.Forms.Label p_IDLabel;
            System.Windows.Forms.Label pART_CHARGLabel;
            System.Windows.Forms.Label sERVICE_CHLabel;
            System.Windows.Forms.Label dISCOUNTLabel;
            System.Windows.Forms.Label nETTOLabel;
            System.Windows.Forms.Label nONPROFITLabel;
            System.Windows.Forms.Label pPNLabel;
            System.Windows.Forms.Label cASHLabel;
            System.Windows.Forms.Label mEKANIKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Header_INV_PPN));
            this.project_UASDataSet = new ProjectPCSuas.Project_UASDataSet();
            this.t_invoiceppn_headerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_invoiceppn_headerTableAdapter = new ProjectPCSuas.Project_UASDataSetTableAdapters.t_invoiceppn_headerTableAdapter();
            this.tableAdapterManager = new ProjectPCSuas.Project_UASDataSetTableAdapters.TableAdapterManager();
            this.t_invoiceppn_headerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.t_invoiceppn_headerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nO_INVTextBox = new System.Windows.Forms.TextBox();
            this.nO_PNWTextBox = new System.Windows.Forms.TextBox();
            this.tGL_INVDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tGL_TERIMADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.p_IDTextBox = new System.Windows.Forms.TextBox();
            this.pART_CHARGTextBox = new System.Windows.Forms.TextBox();
            this.sERVICE_CHTextBox = new System.Windows.Forms.TextBox();
            this.dISCOUNTTextBox = new System.Windows.Forms.TextBox();
            this.nETTOTextBox = new System.Windows.Forms.TextBox();
            this.nONPROFITTextBox = new System.Windows.Forms.TextBox();
            this.pPNTextBox = new System.Windows.Forms.TextBox();
            this.cASHTextBox = new System.Windows.Forms.TextBox();
            this.mEKANIKTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            nO_INVLabel = new System.Windows.Forms.Label();
            nO_PNWLabel = new System.Windows.Forms.Label();
            tGL_INVLabel = new System.Windows.Forms.Label();
            tGL_TERIMALabel = new System.Windows.Forms.Label();
            p_IDLabel = new System.Windows.Forms.Label();
            pART_CHARGLabel = new System.Windows.Forms.Label();
            sERVICE_CHLabel = new System.Windows.Forms.Label();
            dISCOUNTLabel = new System.Windows.Forms.Label();
            nETTOLabel = new System.Windows.Forms.Label();
            nONPROFITLabel = new System.Windows.Forms.Label();
            pPNLabel = new System.Windows.Forms.Label();
            cASHLabel = new System.Windows.Forms.Label();
            mEKANIKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.project_UASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_headerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_headerBindingNavigator)).BeginInit();
            this.t_invoiceppn_headerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nO_INVLabel
            // 
            nO_INVLabel.AutoSize = true;
            nO_INVLabel.Location = new System.Drawing.Point(244, 98);
            nO_INVLabel.Name = "nO_INVLabel";
            nO_INVLabel.Size = new System.Drawing.Size(59, 17);
            nO_INVLabel.TabIndex = 1;
            nO_INVLabel.Text = "NO INV:";
            // 
            // nO_PNWLabel
            // 
            nO_PNWLabel.AutoSize = true;
            nO_PNWLabel.Location = new System.Drawing.Point(234, 157);
            nO_PNWLabel.Name = "nO_PNWLabel";
            nO_PNWLabel.Size = new System.Drawing.Size(69, 17);
            nO_PNWLabel.TabIndex = 3;
            nO_PNWLabel.Text = "NO PNW:";
            // 
            // tGL_INVLabel
            // 
            tGL_INVLabel.AutoSize = true;
            tGL_INVLabel.Location = new System.Drawing.Point(237, 205);
            tGL_INVLabel.Name = "tGL_INVLabel";
            tGL_INVLabel.Size = new System.Drawing.Size(66, 17);
            tGL_INVLabel.TabIndex = 5;
            tGL_INVLabel.Text = "TGL INV:";
            // 
            // tGL_TERIMALabel
            // 
            tGL_TERIMALabel.AutoSize = true;
            tGL_TERIMALabel.Location = new System.Drawing.Point(208, 248);
            tGL_TERIMALabel.Name = "tGL_TERIMALabel";
            tGL_TERIMALabel.Size = new System.Drawing.Size(95, 17);
            tGL_TERIMALabel.TabIndex = 7;
            tGL_TERIMALabel.Text = "TGL TERIMA:";
            // 
            // p_IDLabel
            // 
            p_IDLabel.AutoSize = true;
            p_IDLabel.Location = new System.Drawing.Point(265, 301);
            p_IDLabel.Name = "p_IDLabel";
            p_IDLabel.Size = new System.Drawing.Size(38, 17);
            p_IDLabel.TabIndex = 9;
            p_IDLabel.Text = "P ID:";
            // 
            // pART_CHARGLabel
            // 
            pART_CHARGLabel.AutoSize = true;
            pART_CHARGLabel.Location = new System.Drawing.Point(201, 346);
            pART_CHARGLabel.Name = "pART_CHARGLabel";
            pART_CHARGLabel.Size = new System.Drawing.Size(102, 17);
            pART_CHARGLabel.TabIndex = 11;
            pART_CHARGLabel.Text = "PART CHARG:";
            // 
            // sERVICE_CHLabel
            // 
            sERVICE_CHLabel.AutoSize = true;
            sERVICE_CHLabel.Location = new System.Drawing.Point(210, 396);
            sERVICE_CHLabel.Name = "sERVICE_CHLabel";
            sERVICE_CHLabel.Size = new System.Drawing.Size(93, 17);
            sERVICE_CHLabel.TabIndex = 13;
            sERVICE_CHLabel.Text = "SERVICE CH:";
            // 
            // dISCOUNTLabel
            // 
            dISCOUNTLabel.AutoSize = true;
            dISCOUNTLabel.Location = new System.Drawing.Point(220, 445);
            dISCOUNTLabel.Name = "dISCOUNTLabel";
            dISCOUNTLabel.Size = new System.Drawing.Size(83, 17);
            dISCOUNTLabel.TabIndex = 15;
            dISCOUNTLabel.Text = "DISCOUNT:";
            // 
            // nETTOLabel
            // 
            nETTOLabel.AutoSize = true;
            nETTOLabel.Location = new System.Drawing.Point(621, 99);
            nETTOLabel.Name = "nETTOLabel";
            nETTOLabel.Size = new System.Drawing.Size(60, 17);
            nETTOLabel.TabIndex = 17;
            nETTOLabel.Text = "NETTO:";
            // 
            // nONPROFITLabel
            // 
            nONPROFITLabel.AutoSize = true;
            nONPROFITLabel.Location = new System.Drawing.Point(588, 173);
            nONPROFITLabel.Name = "nONPROFITLabel";
            nONPROFITLabel.Size = new System.Drawing.Size(93, 17);
            nONPROFITLabel.TabIndex = 19;
            nONPROFITLabel.Text = "NONPROFIT:";
            // 
            // pPNLabel
            // 
            pPNLabel.AutoSize = true;
            pPNLabel.Location = new System.Drawing.Point(641, 233);
            pPNLabel.Name = "pPNLabel";
            pPNLabel.Size = new System.Drawing.Size(40, 17);
            pPNLabel.TabIndex = 21;
            pPNLabel.Text = "PPN:";
            // 
            // cASHLabel
            // 
            cASHLabel.AutoSize = true;
            cASHLabel.Location = new System.Drawing.Point(632, 289);
            cASHLabel.Name = "cASHLabel";
            cASHLabel.Size = new System.Drawing.Size(49, 17);
            cASHLabel.TabIndex = 23;
            cASHLabel.Text = "CASH:";
            // 
            // mEKANIKLabel
            // 
            mEKANIKLabel.AutoSize = true;
            mEKANIKLabel.Location = new System.Drawing.Point(609, 346);
            mEKANIKLabel.Name = "mEKANIKLabel";
            mEKANIKLabel.Size = new System.Drawing.Size(72, 17);
            mEKANIKLabel.TabIndex = 25;
            mEKANIKLabel.Text = "MEKANIK:";
            mEKANIKLabel.Click += new System.EventHandler(this.mEKANIKLabel_Click);
            // 
            // project_UASDataSet
            // 
            this.project_UASDataSet.DataSetName = "Project_UASDataSet";
            this.project_UASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_invoiceppn_headerBindingSource
            // 
            this.t_invoiceppn_headerBindingSource.DataMember = "t_invoiceppn_header";
            this.t_invoiceppn_headerBindingSource.DataSource = this.project_UASDataSet;
            // 
            // t_invoiceppn_headerTableAdapter
            // 
            this.t_invoiceppn_headerTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.t_invoiceppn_detailTableAdapter = null;
            this.tableAdapterManager.t_invoiceppn_headerTableAdapter = this.t_invoiceppn_headerTableAdapter;
            this.tableAdapterManager.t_label_hargaTableAdapter = null;
            this.tableAdapterManager.t_pembelian_detailTableAdapter = null;
            this.tableAdapterManager.t_pembelian_headerTableAdapter = null;
            this.tableAdapterManager.t_penawaran_detailTableAdapter = null;
            this.tableAdapterManager.t_penawaran_headerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectPCSuas.Project_UASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_invoiceppn_headerBindingNavigator
            // 
            this.t_invoiceppn_headerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_invoiceppn_headerBindingNavigator.BindingSource = this.t_invoiceppn_headerBindingSource;
            this.t_invoiceppn_headerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_invoiceppn_headerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_invoiceppn_headerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.t_invoiceppn_headerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_invoiceppn_headerBindingNavigatorSaveItem});
            this.t_invoiceppn_headerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_invoiceppn_headerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_invoiceppn_headerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_invoiceppn_headerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_invoiceppn_headerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_invoiceppn_headerBindingNavigator.Name = "t_invoiceppn_headerBindingNavigator";
            this.t_invoiceppn_headerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_invoiceppn_headerBindingNavigator.Size = new System.Drawing.Size(1082, 27);
            this.t_invoiceppn_headerBindingNavigator.TabIndex = 0;
            this.t_invoiceppn_headerBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
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
            // t_invoiceppn_headerBindingNavigatorSaveItem
            // 
            this.t_invoiceppn_headerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_invoiceppn_headerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_invoiceppn_headerBindingNavigatorSaveItem.Image")));
            this.t_invoiceppn_headerBindingNavigatorSaveItem.Name = "t_invoiceppn_headerBindingNavigatorSaveItem";
            this.t_invoiceppn_headerBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.t_invoiceppn_headerBindingNavigatorSaveItem.Text = "Save Data";
            this.t_invoiceppn_headerBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_invoiceppn_headerBindingNavigatorSaveItem_Click);
            // 
            // nO_INVTextBox
            // 
            this.nO_INVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_headerBindingSource, "NO_INV", true));
            this.nO_INVTextBox.Location = new System.Drawing.Point(309, 95);
            this.nO_INVTextBox.Name = "nO_INVTextBox";
            this.nO_INVTextBox.Size = new System.Drawing.Size(200, 22);
            this.nO_INVTextBox.TabIndex = 2;
            // 
            // nO_PNWTextBox
            // 
            this.nO_PNWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_headerBindingSource, "NO_PNW", true));
            this.nO_PNWTextBox.Location = new System.Drawing.Point(309, 154);
            this.nO_PNWTextBox.Name = "nO_PNWTextBox";
            this.nO_PNWTextBox.Size = new System.Drawing.Size(200, 22);
            this.nO_PNWTextBox.TabIndex = 4;
            // 
            // tGL_INVDateTimePicker
            // 
            this.tGL_INVDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.t_invoiceppn_headerBindingSource, "TGL_INV", true));
            this.tGL_INVDateTimePicker.Location = new System.Drawing.Point(309, 201);
            this.tGL_INVDateTimePicker.Name = "tGL_INVDateTimePicker";
            this.tGL_INVDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.tGL_INVDateTimePicker.TabIndex = 6;
            // 
            // tGL_TERIMADateTimePicker
            // 
            this.tGL_TERIMADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.t_invoiceppn_headerBindingSource, "TGL_TERIMA", true));
            this.tGL_TERIMADateTimePicker.Location = new System.Drawing.Point(309, 244);
            this.tGL_TERIMADateTimePicker.Name = "tGL_TERIMADateTimePicker";
            this.tGL_TERIMADateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.tGL_TERIMADateTimePicker.TabIndex = 8;
            // 
            // p_IDTextBox
            // 
            this.p_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_headerBindingSource, "P_ID", true));
            this.p_IDTextBox.Location = new System.Drawing.Point(309, 298);
            this.p_IDTextBox.Name = "p_IDTextBox";
            this.p_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.p_IDTextBox.TabIndex = 10;
            // 
            // pART_CHARGTextBox
            // 
            this.pART_CHARGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_headerBindingSource, "PART_CHARG", true));
            this.pART_CHARGTextBox.Location = new System.Drawing.Point(309, 343);
            this.pART_CHARGTextBox.Name = "pART_CHARGTextBox";
            this.pART_CHARGTextBox.Size = new System.Drawing.Size(200, 22);
            this.pART_CHARGTextBox.TabIndex = 12;
            // 
            // sERVICE_CHTextBox
            // 
            this.sERVICE_CHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_headerBindingSource, "SERVICE_CH", true));
            this.sERVICE_CHTextBox.Location = new System.Drawing.Point(309, 393);
            this.sERVICE_CHTextBox.Name = "sERVICE_CHTextBox";
            this.sERVICE_CHTextBox.Size = new System.Drawing.Size(200, 22);
            this.sERVICE_CHTextBox.TabIndex = 14;
            // 
            // dISCOUNTTextBox
            // 
            this.dISCOUNTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_headerBindingSource, "DISCOUNT", true));
            this.dISCOUNTTextBox.Location = new System.Drawing.Point(309, 442);
            this.dISCOUNTTextBox.Name = "dISCOUNTTextBox";
            this.dISCOUNTTextBox.Size = new System.Drawing.Size(200, 22);
            this.dISCOUNTTextBox.TabIndex = 16;
            // 
            // nETTOTextBox
            // 
            this.nETTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_headerBindingSource, "NETTO", true));
            this.nETTOTextBox.Location = new System.Drawing.Point(687, 96);
            this.nETTOTextBox.Name = "nETTOTextBox";
            this.nETTOTextBox.Size = new System.Drawing.Size(191, 22);
            this.nETTOTextBox.TabIndex = 18;
            // 
            // nONPROFITTextBox
            // 
            this.nONPROFITTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_headerBindingSource, "NONPROFIT", true));
            this.nONPROFITTextBox.Location = new System.Drawing.Point(687, 170);
            this.nONPROFITTextBox.Name = "nONPROFITTextBox";
            this.nONPROFITTextBox.Size = new System.Drawing.Size(191, 22);
            this.nONPROFITTextBox.TabIndex = 20;
            // 
            // pPNTextBox
            // 
            this.pPNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_headerBindingSource, "PPN", true));
            this.pPNTextBox.Location = new System.Drawing.Point(687, 230);
            this.pPNTextBox.Name = "pPNTextBox";
            this.pPNTextBox.Size = new System.Drawing.Size(191, 22);
            this.pPNTextBox.TabIndex = 22;
            // 
            // cASHTextBox
            // 
            this.cASHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_headerBindingSource, "CASH", true));
            this.cASHTextBox.Location = new System.Drawing.Point(687, 286);
            this.cASHTextBox.Name = "cASHTextBox";
            this.cASHTextBox.Size = new System.Drawing.Size(191, 22);
            this.cASHTextBox.TabIndex = 24;
            // 
            // mEKANIKTextBox
            // 
            this.mEKANIKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_headerBindingSource, "MEKANIK", true));
            this.mEKANIKTextBox.Location = new System.Drawing.Point(687, 343);
            this.mEKANIKTextBox.Name = "mEKANIKTextBox";
            this.mEKANIKTextBox.Size = new System.Drawing.Size(191, 22);
            this.mEKANIKTextBox.TabIndex = 26;
            this.mEKANIKTextBox.TextChanged += new System.EventHandler(this.mEKANIKTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(888, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(969, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Header_INV_PPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(mEKANIKLabel);
            this.Controls.Add(this.mEKANIKTextBox);
            this.Controls.Add(cASHLabel);
            this.Controls.Add(this.cASHTextBox);
            this.Controls.Add(pPNLabel);
            this.Controls.Add(this.pPNTextBox);
            this.Controls.Add(nONPROFITLabel);
            this.Controls.Add(this.nONPROFITTextBox);
            this.Controls.Add(nETTOLabel);
            this.Controls.Add(this.nETTOTextBox);
            this.Controls.Add(dISCOUNTLabel);
            this.Controls.Add(this.dISCOUNTTextBox);
            this.Controls.Add(sERVICE_CHLabel);
            this.Controls.Add(this.sERVICE_CHTextBox);
            this.Controls.Add(pART_CHARGLabel);
            this.Controls.Add(this.pART_CHARGTextBox);
            this.Controls.Add(p_IDLabel);
            this.Controls.Add(this.p_IDTextBox);
            this.Controls.Add(tGL_TERIMALabel);
            this.Controls.Add(this.tGL_TERIMADateTimePicker);
            this.Controls.Add(tGL_INVLabel);
            this.Controls.Add(this.tGL_INVDateTimePicker);
            this.Controls.Add(nO_PNWLabel);
            this.Controls.Add(this.nO_PNWTextBox);
            this.Controls.Add(nO_INVLabel);
            this.Controls.Add(this.nO_INVTextBox);
            this.Controls.Add(this.t_invoiceppn_headerBindingNavigator);
            this.Name = "Header_INV_PPN";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Header_INV_PPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_UASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_headerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_headerBindingNavigator)).EndInit();
            this.t_invoiceppn_headerBindingNavigator.ResumeLayout(false);
            this.t_invoiceppn_headerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Project_UASDataSet project_UASDataSet;
        private System.Windows.Forms.BindingSource t_invoiceppn_headerBindingSource;
        private Project_UASDataSetTableAdapters.t_invoiceppn_headerTableAdapter t_invoiceppn_headerTableAdapter;
        private Project_UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_invoiceppn_headerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_invoiceppn_headerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nO_INVTextBox;
        private System.Windows.Forms.TextBox nO_PNWTextBox;
        private System.Windows.Forms.DateTimePicker tGL_INVDateTimePicker;
        private System.Windows.Forms.DateTimePicker tGL_TERIMADateTimePicker;
        private System.Windows.Forms.TextBox p_IDTextBox;
        private System.Windows.Forms.TextBox pART_CHARGTextBox;
        private System.Windows.Forms.TextBox sERVICE_CHTextBox;
        private System.Windows.Forms.TextBox dISCOUNTTextBox;
        private System.Windows.Forms.TextBox nETTOTextBox;
        private System.Windows.Forms.TextBox nONPROFITTextBox;
        private System.Windows.Forms.TextBox pPNTextBox;
        private System.Windows.Forms.TextBox cASHTextBox;
        private System.Windows.Forms.TextBox mEKANIKTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}