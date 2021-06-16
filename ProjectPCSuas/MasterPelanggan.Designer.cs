
namespace ProjectPCSuas
{
    partial class MasterPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterPelanggan));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nAMALabel;
            System.Windows.Forms.Label aLAMATLabel;
            System.Windows.Forms.Label kOTALabel;
            System.Windows.Forms.Label tELPLabel;
            System.Windows.Forms.Label nPWPLabel;
            System.Windows.Forms.Label nAMA1Label;
            System.Windows.Forms.Label aLAMAT1Label;
            System.Windows.Forms.Label kOTA1Label;
            System.Windows.Forms.Label hPLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.uASDataSet2 = new ProjectPCSuas.UASDataSet2();
            this.m_pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_pelangganTableAdapter = new ProjectPCSuas.UASDataSet2TableAdapters.m_pelangganTableAdapter();
            this.tableAdapterManager = new ProjectPCSuas.UASDataSet2TableAdapters.TableAdapterManager();
            this.m_pelangganBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.m_pelangganBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nAMATextBox = new System.Windows.Forms.TextBox();
            this.aLAMATTextBox = new System.Windows.Forms.TextBox();
            this.kOTATextBox = new System.Windows.Forms.TextBox();
            this.tELPTextBox = new System.Windows.Forms.TextBox();
            this.nPWPTextBox = new System.Windows.Forms.TextBox();
            this.nAMA1TextBox = new System.Windows.Forms.TextBox();
            this.aLAMAT1TextBox = new System.Windows.Forms.TextBox();
            this.kOTA1TextBox = new System.Windows.Forms.TextBox();
            this.hPTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            nAMALabel = new System.Windows.Forms.Label();
            aLAMATLabel = new System.Windows.Forms.Label();
            kOTALabel = new System.Windows.Forms.Label();
            tELPLabel = new System.Windows.Forms.Label();
            nPWPLabel = new System.Windows.Forms.Label();
            nAMA1Label = new System.Windows.Forms.Label();
            aLAMAT1Label = new System.Windows.Forms.Label();
            kOTA1Label = new System.Windows.Forms.Label();
            hPLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pelangganBindingNavigator)).BeginInit();
            this.m_pelangganBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // uASDataSet2
            // 
            this.uASDataSet2.DataSetName = "UASDataSet2";
            this.uASDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_pelangganBindingSource
            // 
            this.m_pelangganBindingSource.DataMember = "m_pelanggan";
            this.m_pelangganBindingSource.DataSource = this.uASDataSet2;
            // 
            // m_pelangganTableAdapter
            // 
            this.m_pelangganTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.m_pelangganTableAdapter = this.m_pelangganTableAdapter;
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
            // m_pelangganBindingNavigator
            // 
            this.m_pelangganBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_pelangganBindingNavigator.BindingSource = this.m_pelangganBindingSource;
            this.m_pelangganBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_pelangganBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_pelangganBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.m_pelangganBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_pelangganBindingNavigatorSaveItem});
            this.m_pelangganBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_pelangganBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_pelangganBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_pelangganBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_pelangganBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_pelangganBindingNavigator.Name = "m_pelangganBindingNavigator";
            this.m_pelangganBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_pelangganBindingNavigator.Size = new System.Drawing.Size(1108, 27);
            this.m_pelangganBindingNavigator.TabIndex = 0;
            this.m_pelangganBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // m_pelangganBindingNavigatorSaveItem
            // 
            this.m_pelangganBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_pelangganBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_pelangganBindingNavigatorSaveItem.Image")));
            this.m_pelangganBindingNavigatorSaveItem.Name = "m_pelangganBindingNavigatorSaveItem";
            this.m_pelangganBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.m_pelangganBindingNavigatorSaveItem.Text = "Save Data";
            this.m_pelangganBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_pelangganBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(40, 382);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(51, 17);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "NAMA:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(126, 379);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(327, 22);
            this.iDTextBox.TabIndex = 2;
            this.iDTextBox.TextChanged += new System.EventHandler(this.iDTextBox_TextChanged);
            // 
            // nAMALabel
            // 
            nAMALabel.AutoSize = true;
            nAMALabel.Location = new System.Drawing.Point(40, 139);
            nAMALabel.Name = "nAMALabel";
            nAMALabel.Size = new System.Drawing.Size(51, 17);
            nAMALabel.TabIndex = 5;
            nAMALabel.Text = "NAMA:";
            // 
            // nAMATextBox
            // 
            this.nAMATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "NAMA", true));
            this.nAMATextBox.Location = new System.Drawing.Point(126, 139);
            this.nAMATextBox.Name = "nAMATextBox";
            this.nAMATextBox.Size = new System.Drawing.Size(401, 22);
            this.nAMATextBox.TabIndex = 6;
            // 
            // aLAMATLabel
            // 
            aLAMATLabel.AutoSize = true;
            aLAMATLabel.Location = new System.Drawing.Point(40, 178);
            aLAMATLabel.Name = "aLAMATLabel";
            aLAMATLabel.Size = new System.Drawing.Size(67, 17);
            aLAMATLabel.TabIndex = 7;
            aLAMATLabel.Text = "ALAMAT:";
            // 
            // aLAMATTextBox
            // 
            this.aLAMATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "ALAMAT", true));
            this.aLAMATTextBox.Location = new System.Drawing.Point(126, 178);
            this.aLAMATTextBox.Name = "aLAMATTextBox";
            this.aLAMATTextBox.Size = new System.Drawing.Size(573, 22);
            this.aLAMATTextBox.TabIndex = 8;
            // 
            // kOTALabel
            // 
            kOTALabel.AutoSize = true;
            kOTALabel.Location = new System.Drawing.Point(723, 173);
            kOTALabel.Name = "kOTALabel";
            kOTALabel.Size = new System.Drawing.Size(50, 17);
            kOTALabel.TabIndex = 9;
            kOTALabel.Text = "KOTA:";
            // 
            // kOTATextBox
            // 
            this.kOTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "KOTA", true));
            this.kOTATextBox.Location = new System.Drawing.Point(779, 173);
            this.kOTATextBox.Name = "kOTATextBox";
            this.kOTATextBox.Size = new System.Drawing.Size(238, 22);
            this.kOTATextBox.TabIndex = 10;
            // 
            // tELPLabel
            // 
            tELPLabel.AutoSize = true;
            tELPLabel.Location = new System.Drawing.Point(726, 137);
            tELPLabel.Name = "tELPLabel";
            tELPLabel.Size = new System.Drawing.Size(47, 17);
            tELPLabel.TabIndex = 11;
            tELPLabel.Text = "TELP:";
            // 
            // tELPTextBox
            // 
            this.tELPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "TELP", true));
            this.tELPTextBox.Location = new System.Drawing.Point(779, 134);
            this.tELPTextBox.Name = "tELPTextBox";
            this.tELPTextBox.Size = new System.Drawing.Size(238, 22);
            this.tELPTextBox.TabIndex = 12;
            // 
            // nPWPLabel
            // 
            nPWPLabel.AutoSize = true;
            nPWPLabel.Location = new System.Drawing.Point(469, 380);
            nPWPLabel.Name = "nPWPLabel";
            nPWPLabel.Size = new System.Drawing.Size(53, 17);
            nPWPLabel.TabIndex = 13;
            nPWPLabel.Text = "NPWP:";
            // 
            // nPWPTextBox
            // 
            this.nPWPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "NPWP", true));
            this.nPWPTextBox.Location = new System.Drawing.Point(528, 377);
            this.nPWPTextBox.Name = "nPWPTextBox";
            this.nPWPTextBox.Size = new System.Drawing.Size(202, 22);
            this.nPWPTextBox.TabIndex = 14;
            // 
            // nAMA1Label
            // 
            nAMA1Label.AutoSize = true;
            nAMA1Label.Location = new System.Drawing.Point(40, 255);
            nAMA1Label.Name = "nAMA1Label";
            nAMA1Label.Size = new System.Drawing.Size(59, 17);
            nAMA1Label.TabIndex = 19;
            nAMA1Label.Text = "NAMA2:";
            // 
            // nAMA1TextBox
            // 
            this.nAMA1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "NAMA1", true));
            this.nAMA1TextBox.Location = new System.Drawing.Point(126, 250);
            this.nAMA1TextBox.Name = "nAMA1TextBox";
            this.nAMA1TextBox.Size = new System.Drawing.Size(401, 22);
            this.nAMA1TextBox.TabIndex = 20;
            // 
            // aLAMAT1Label
            // 
            aLAMAT1Label.AutoSize = true;
            aLAMAT1Label.Location = new System.Drawing.Point(40, 289);
            aLAMAT1Label.Name = "aLAMAT1Label";
            aLAMAT1Label.Size = new System.Drawing.Size(75, 17);
            aLAMAT1Label.TabIndex = 21;
            aLAMAT1Label.Text = "ALAMAT2:";
            // 
            // aLAMAT1TextBox
            // 
            this.aLAMAT1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "ALAMAT1", true));
            this.aLAMAT1TextBox.Location = new System.Drawing.Point(126, 289);
            this.aLAMAT1TextBox.Name = "aLAMAT1TextBox";
            this.aLAMAT1TextBox.Size = new System.Drawing.Size(573, 22);
            this.aLAMAT1TextBox.TabIndex = 22;
            // 
            // kOTA1Label
            // 
            kOTA1Label.AutoSize = true;
            kOTA1Label.Location = new System.Drawing.Point(712, 287);
            kOTA1Label.Name = "kOTA1Label";
            kOTA1Label.Size = new System.Drawing.Size(58, 17);
            kOTA1Label.TabIndex = 23;
            kOTA1Label.Text = "KOTA2:";
            // 
            // kOTA1TextBox
            // 
            this.kOTA1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "KOTA1", true));
            this.kOTA1TextBox.Location = new System.Drawing.Point(792, 284);
            this.kOTA1TextBox.Name = "kOTA1TextBox";
            this.kOTA1TextBox.Size = new System.Drawing.Size(225, 22);
            this.kOTA1TextBox.TabIndex = 24;
            // 
            // hPLabel
            // 
            hPLabel.AutoSize = true;
            hPLabel.Location = new System.Drawing.Point(711, 253);
            hPLabel.Name = "hPLabel";
            hPLabel.Size = new System.Drawing.Size(70, 17);
            hPLabel.TabIndex = 25;
            hPLabel.Text = "TELP/HP:";
            // 
            // hPTextBox
            // 
            this.hPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "HP", true));
            this.hPTextBox.Location = new System.Drawing.Point(792, 250);
            this.hPTextBox.Name = "hPTextBox";
            this.hPTextBox.Size = new System.Drawing.Size(225, 22);
            this.hPTextBox.TabIndex = 26;
            this.hPTextBox.TextChanged += new System.EventHandler(this.hPTextBox_TextChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(35, 107);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 17);
            label1.TabIndex = 29;
            label1.Text = "Pelanggan:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "NAMA", true));
            this.textBox1.Location = new System.Drawing.Point(126, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(40, 414);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 17);
            label2.TabIndex = 31;
            label2.Text = "ALAMAT:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "ALAMAT", true));
            this.textBox2.Location = new System.Drawing.Point(126, 414);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(970, 22);
            this.textBox2.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(40, 453);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 17);
            label3.TabIndex = 33;
            label3.Text = "EMAIL:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "ALAMAT", true));
            this.textBox3.Location = new System.Drawing.Point(126, 451);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(604, 22);
            this.textBox3.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(377, 31);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(353, 36);
            label4.TabIndex = 35;
            label4.Text = "Input Master Pelanggan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(40, 500);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 17);
            label5.TabIndex = 36;
            label5.Text = "NOTE:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "ALAMAT", true));
            this.textBox4.Location = new System.Drawing.Point(126, 495);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(604, 22);
            this.textBox4.TabIndex = 37;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 536);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nAMALabel);
            this.Controls.Add(this.nAMATextBox);
            this.Controls.Add(aLAMATLabel);
            this.Controls.Add(this.aLAMATTextBox);
            this.Controls.Add(kOTALabel);
            this.Controls.Add(this.kOTATextBox);
            this.Controls.Add(tELPLabel);
            this.Controls.Add(this.tELPTextBox);
            this.Controls.Add(nPWPLabel);
            this.Controls.Add(this.nPWPTextBox);
            this.Controls.Add(nAMA1Label);
            this.Controls.Add(this.nAMA1TextBox);
            this.Controls.Add(aLAMAT1Label);
            this.Controls.Add(this.aLAMAT1TextBox);
            this.Controls.Add(kOTA1Label);
            this.Controls.Add(this.kOTA1TextBox);
            this.Controls.Add(hPLabel);
            this.Controls.Add(this.hPTextBox);
            this.Controls.Add(this.m_pelangganBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pelangganBindingNavigator)).EndInit();
            this.m_pelangganBindingNavigator.ResumeLayout(false);
            this.m_pelangganBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UASDataSet2 uASDataSet2;
        private System.Windows.Forms.BindingSource m_pelangganBindingSource;
        private UASDataSet2TableAdapters.m_pelangganTableAdapter m_pelangganTableAdapter;
        private UASDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_pelangganBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_pelangganBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nAMATextBox;
        private System.Windows.Forms.TextBox aLAMATTextBox;
        private System.Windows.Forms.TextBox kOTATextBox;
        private System.Windows.Forms.TextBox tELPTextBox;
        private System.Windows.Forms.TextBox nPWPTextBox;
        private System.Windows.Forms.TextBox nAMA1TextBox;
        private System.Windows.Forms.TextBox aLAMAT1TextBox;
        private System.Windows.Forms.TextBox kOTA1TextBox;
        private System.Windows.Forms.TextBox hPTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}