
namespace ProjectPCSuas
{
    partial class Pembelian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pembelian));
            System.Windows.Forms.Label nO_PNWLabel;
            System.Windows.Forms.Label nO_NOTALabel;
            System.Windows.Forms.Label fAKTUR_PAJLabel;
            System.Windows.Forms.Label tGL_PNWLabel;
            System.Windows.Forms.Label nPWPLabel;
            System.Windows.Forms.Label p_IDLabel;
            System.Windows.Forms.Label nAMALabel;
            System.Windows.Forms.Label aLAMATLabel;
            System.Windows.Forms.Label kOTALabel;
            System.Windows.Forms.Label nOTELabel;
            this.project_UASDataSet = new ProjectPCSuas.Project_UASDataSet();
            this.t_pembelian_headerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_pembelian_headerTableAdapter = new ProjectPCSuas.Project_UASDataSetTableAdapters.t_pembelian_headerTableAdapter();
            this.tableAdapterManager = new ProjectPCSuas.Project_UASDataSetTableAdapters.TableAdapterManager();
            this.t_pembelian_headerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.t_pembelian_headerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nO_PNWTextBox = new System.Windows.Forms.TextBox();
            this.nO_NOTATextBox = new System.Windows.Forms.TextBox();
            this.fAKTUR_PAJTextBox = new System.Windows.Forms.TextBox();
            this.tGL_PNWDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.m_supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_supplierTableAdapter = new ProjectPCSuas.Project_UASDataSetTableAdapters.m_supplierTableAdapter();
            this.nPWPTextBox = new System.Windows.Forms.TextBox();
            this.p_IDComboBox = new System.Windows.Forms.ComboBox();
            this.nAMATextBox = new System.Windows.Forms.TextBox();
            this.aLAMATTextBox = new System.Windows.Forms.TextBox();
            this.kOTATextBox = new System.Windows.Forms.TextBox();
            this.nOTETextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            nO_PNWLabel = new System.Windows.Forms.Label();
            nO_NOTALabel = new System.Windows.Forms.Label();
            fAKTUR_PAJLabel = new System.Windows.Forms.Label();
            tGL_PNWLabel = new System.Windows.Forms.Label();
            nPWPLabel = new System.Windows.Forms.Label();
            p_IDLabel = new System.Windows.Forms.Label();
            nAMALabel = new System.Windows.Forms.Label();
            aLAMATLabel = new System.Windows.Forms.Label();
            kOTALabel = new System.Windows.Forms.Label();
            nOTELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.project_UASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_pembelian_headerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_pembelian_headerBindingNavigator)).BeginInit();
            this.t_pembelian_headerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // project_UASDataSet
            // 
            this.project_UASDataSet.DataSetName = "Project_UASDataSet";
            this.project_UASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_pembelian_headerBindingSource
            // 
            this.t_pembelian_headerBindingSource.DataMember = "t_pembelian_header";
            this.t_pembelian_headerBindingSource.DataSource = this.project_UASDataSet;
            // 
            // t_pembelian_headerTableAdapter
            // 
            this.t_pembelian_headerTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.t_pembelian_headerTableAdapter = this.t_pembelian_headerTableAdapter;
            this.tableAdapterManager.t_penawaran_detailTableAdapter = null;
            this.tableAdapterManager.t_penawaran_headerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectPCSuas.Project_UASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_pembelian_headerBindingNavigator
            // 
            this.t_pembelian_headerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_pembelian_headerBindingNavigator.BindingSource = this.t_pembelian_headerBindingSource;
            this.t_pembelian_headerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_pembelian_headerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_pembelian_headerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_pembelian_headerBindingNavigatorSaveItem});
            this.t_pembelian_headerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_pembelian_headerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_pembelian_headerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_pembelian_headerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_pembelian_headerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_pembelian_headerBindingNavigator.Name = "t_pembelian_headerBindingNavigator";
            this.t_pembelian_headerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_pembelian_headerBindingNavigator.Size = new System.Drawing.Size(1051, 25);
            this.t_pembelian_headerBindingNavigator.TabIndex = 0;
            this.t_pembelian_headerBindingNavigator.Text = "bindingNavigator1";
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
            // t_pembelian_headerBindingNavigatorSaveItem
            // 
            this.t_pembelian_headerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_pembelian_headerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_pembelian_headerBindingNavigatorSaveItem.Image")));
            this.t_pembelian_headerBindingNavigatorSaveItem.Name = "t_pembelian_headerBindingNavigatorSaveItem";
            this.t_pembelian_headerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.t_pembelian_headerBindingNavigatorSaveItem.Text = "Save Data";
            this.t_pembelian_headerBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_pembelian_headerBindingNavigatorSaveItem_Click);
            // 
            // nO_PNWLabel
            // 
            nO_PNWLabel.AutoSize = true;
            nO_PNWLabel.Location = new System.Drawing.Point(29, 65);
            nO_PNWLabel.Name = "nO_PNWLabel";
            nO_PNWLabel.Size = new System.Drawing.Size(55, 13);
            nO_PNWLabel.TabIndex = 1;
            nO_PNWLabel.Text = "NO PNW:";
            // 
            // nO_PNWTextBox
            // 
            this.nO_PNWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_pembelian_headerBindingSource, "NO_PNW", true));
            this.nO_PNWTextBox.Location = new System.Drawing.Point(90, 62);
            this.nO_PNWTextBox.Name = "nO_PNWTextBox";
            this.nO_PNWTextBox.Size = new System.Drawing.Size(100, 20);
            this.nO_PNWTextBox.TabIndex = 2;
            // 
            // nO_NOTALabel
            // 
            nO_NOTALabel.AutoSize = true;
            nO_NOTALabel.Location = new System.Drawing.Point(205, 65);
            nO_NOTALabel.Name = "nO_NOTALabel";
            nO_NOTALabel.Size = new System.Drawing.Size(59, 13);
            nO_NOTALabel.TabIndex = 3;
            nO_NOTALabel.Text = "NO NOTA:";
            // 
            // nO_NOTATextBox
            // 
            this.nO_NOTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_pembelian_headerBindingSource, "NO_NOTA", true));
            this.nO_NOTATextBox.Location = new System.Drawing.Point(270, 62);
            this.nO_NOTATextBox.Name = "nO_NOTATextBox";
            this.nO_NOTATextBox.Size = new System.Drawing.Size(100, 20);
            this.nO_NOTATextBox.TabIndex = 4;
            // 
            // fAKTUR_PAJLabel
            // 
            fAKTUR_PAJLabel.AutoSize = true;
            fAKTUR_PAJLabel.Location = new System.Drawing.Point(547, 65);
            fAKTUR_PAJLabel.Name = "fAKTUR_PAJLabel";
            fAKTUR_PAJLabel.Size = new System.Drawing.Size(75, 13);
            fAKTUR_PAJLabel.TabIndex = 5;
            fAKTUR_PAJLabel.Text = "FAKTUR PAJ:";
            // 
            // fAKTUR_PAJTextBox
            // 
            this.fAKTUR_PAJTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_pembelian_headerBindingSource, "FAKTUR_PAJ", true));
            this.fAKTUR_PAJTextBox.Location = new System.Drawing.Point(628, 62);
            this.fAKTUR_PAJTextBox.Name = "fAKTUR_PAJTextBox";
            this.fAKTUR_PAJTextBox.Size = new System.Drawing.Size(100, 20);
            this.fAKTUR_PAJTextBox.TabIndex = 6;
            // 
            // tGL_PNWLabel
            // 
            tGL_PNWLabel.AutoSize = true;
            tGL_PNWLabel.Location = new System.Drawing.Point(762, 63);
            tGL_PNWLabel.Name = "tGL_PNWLabel";
            tGL_PNWLabel.Size = new System.Drawing.Size(60, 13);
            tGL_PNWLabel.TabIndex = 7;
            tGL_PNWLabel.Text = "TGL PNW:";
            // 
            // tGL_PNWDateTimePicker
            // 
            this.tGL_PNWDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.t_pembelian_headerBindingSource, "TGL_PNW", true));
            this.tGL_PNWDateTimePicker.Location = new System.Drawing.Point(828, 59);
            this.tGL_PNWDateTimePicker.Name = "tGL_PNWDateTimePicker";
            this.tGL_PNWDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tGL_PNWDateTimePicker.TabIndex = 8;
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
            // nPWPLabel
            // 
            nPWPLabel.AutoSize = true;
            nPWPLabel.Location = new System.Drawing.Point(379, 65);
            nPWPLabel.Name = "nPWPLabel";
            nPWPLabel.Size = new System.Drawing.Size(43, 13);
            nPWPLabel.TabIndex = 11;
            nPWPLabel.Text = "NPWP:";
            // 
            // nPWPTextBox
            // 
            this.nPWPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NPWP", true));
            this.nPWPTextBox.Location = new System.Drawing.Point(428, 62);
            this.nPWPTextBox.Name = "nPWPTextBox";
            this.nPWPTextBox.Size = new System.Drawing.Size(100, 20);
            this.nPWPTextBox.TabIndex = 12;
            // 
            // p_IDLabel
            // 
            p_IDLabel.AutoSize = true;
            p_IDLabel.Location = new System.Drawing.Point(53, 114);
            p_IDLabel.Name = "p_IDLabel";
            p_IDLabel.Size = new System.Drawing.Size(31, 13);
            p_IDLabel.TabIndex = 12;
            p_IDLabel.Text = "P ID:";
            // 
            // p_IDComboBox
            // 
            this.p_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_pembelian_headerBindingSource, "P_ID", true));
            this.p_IDComboBox.FormattingEnabled = true;
            this.p_IDComboBox.Location = new System.Drawing.Point(90, 111);
            this.p_IDComboBox.Name = "p_IDComboBox";
            this.p_IDComboBox.Size = new System.Drawing.Size(100, 21);
            this.p_IDComboBox.TabIndex = 13;
            // 
            // nAMALabel
            // 
            nAMALabel.AutoSize = true;
            nAMALabel.Location = new System.Drawing.Point(223, 114);
            nAMALabel.Name = "nAMALabel";
            nAMALabel.Size = new System.Drawing.Size(41, 13);
            nAMALabel.TabIndex = 13;
            nAMALabel.Text = "NAMA:";
            // 
            // nAMATextBox
            // 
            this.nAMATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NAMA", true));
            this.nAMATextBox.Location = new System.Drawing.Point(270, 111);
            this.nAMATextBox.Name = "nAMATextBox";
            this.nAMATextBox.Size = new System.Drawing.Size(100, 20);
            this.nAMATextBox.TabIndex = 14;
            // 
            // aLAMATLabel
            // 
            aLAMATLabel.AutoSize = true;
            aLAMATLabel.Location = new System.Drawing.Point(379, 114);
            aLAMATLabel.Name = "aLAMATLabel";
            aLAMATLabel.Size = new System.Drawing.Size(53, 13);
            aLAMATLabel.TabIndex = 15;
            aLAMATLabel.Text = "ALAMAT:";
            // 
            // aLAMATTextBox
            // 
            this.aLAMATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "ALAMAT", true));
            this.aLAMATTextBox.Location = new System.Drawing.Point(438, 111);
            this.aLAMATTextBox.Name = "aLAMATTextBox";
            this.aLAMATTextBox.Size = new System.Drawing.Size(100, 20);
            this.aLAMATTextBox.TabIndex = 16;
            // 
            // kOTALabel
            // 
            kOTALabel.AutoSize = true;
            kOTALabel.Location = new System.Drawing.Point(583, 114);
            kOTALabel.Name = "kOTALabel";
            kOTALabel.Size = new System.Drawing.Size(39, 13);
            kOTALabel.TabIndex = 17;
            kOTALabel.Text = "KOTA:";
            // 
            // kOTATextBox
            // 
            this.kOTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "KOTA", true));
            this.kOTATextBox.Location = new System.Drawing.Point(628, 111);
            this.kOTATextBox.Name = "kOTATextBox";
            this.kOTATextBox.Size = new System.Drawing.Size(100, 20);
            this.kOTATextBox.TabIndex = 18;
            // 
            // nOTELabel
            // 
            nOTELabel.AutoSize = true;
            nOTELabel.Location = new System.Drawing.Point(824, 191);
            nOTELabel.Name = "nOTELabel";
            nOTELabel.Size = new System.Drawing.Size(40, 13);
            nOTELabel.TabIndex = 19;
            nOTELabel.Text = "NOTE:";
            // 
            // nOTETextBox
            // 
            this.nOTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NOTE", true));
            this.nOTETextBox.Location = new System.Drawing.Point(870, 188);
            this.nOTETextBox.Name = "nOTETextBox";
            this.nOTETextBox.Size = new System.Drawing.Size(100, 20);
            this.nOTETextBox.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 22;
            // 
            // Pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(nOTELabel);
            this.Controls.Add(this.nOTETextBox);
            this.Controls.Add(kOTALabel);
            this.Controls.Add(this.kOTATextBox);
            this.Controls.Add(aLAMATLabel);
            this.Controls.Add(this.aLAMATTextBox);
            this.Controls.Add(nAMALabel);
            this.Controls.Add(this.nAMATextBox);
            this.Controls.Add(p_IDLabel);
            this.Controls.Add(this.p_IDComboBox);
            this.Controls.Add(nPWPLabel);
            this.Controls.Add(this.nPWPTextBox);
            this.Controls.Add(tGL_PNWLabel);
            this.Controls.Add(this.tGL_PNWDateTimePicker);
            this.Controls.Add(fAKTUR_PAJLabel);
            this.Controls.Add(this.fAKTUR_PAJTextBox);
            this.Controls.Add(nO_NOTALabel);
            this.Controls.Add(this.nO_NOTATextBox);
            this.Controls.Add(nO_PNWLabel);
            this.Controls.Add(this.nO_PNWTextBox);
            this.Controls.Add(this.t_pembelian_headerBindingNavigator);
            this.Name = "Pembelian";
            this.Text = "Pembelian";
            this.Load += new System.EventHandler(this.Pembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_UASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_pembelian_headerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_pembelian_headerBindingNavigator)).EndInit();
            this.t_pembelian_headerBindingNavigator.ResumeLayout(false);
            this.t_pembelian_headerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Project_UASDataSet project_UASDataSet;
        private System.Windows.Forms.BindingSource t_pembelian_headerBindingSource;
        private Project_UASDataSetTableAdapters.t_pembelian_headerTableAdapter t_pembelian_headerTableAdapter;
        private Project_UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_pembelian_headerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_pembelian_headerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nO_PNWTextBox;
        private Project_UASDataSetTableAdapters.m_supplierTableAdapter m_supplierTableAdapter;
        private System.Windows.Forms.TextBox nO_NOTATextBox;
        private System.Windows.Forms.TextBox fAKTUR_PAJTextBox;
        private System.Windows.Forms.DateTimePicker tGL_PNWDateTimePicker;
        private System.Windows.Forms.BindingSource m_supplierBindingSource;
        private System.Windows.Forms.TextBox nPWPTextBox;
        private System.Windows.Forms.ComboBox p_IDComboBox;
        private System.Windows.Forms.TextBox nAMATextBox;
        private System.Windows.Forms.TextBox aLAMATTextBox;
        private System.Windows.Forms.TextBox kOTATextBox;
        private System.Windows.Forms.TextBox nOTETextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}