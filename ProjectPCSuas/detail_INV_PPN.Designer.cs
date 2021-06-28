
namespace ProjectPCSuas
{
    partial class detail_INV_PPN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detail_INV_PPN));
            System.Windows.Forms.Label nO_INVLabel;
            System.Windows.Forms.Label kODELabel;
            System.Windows.Forms.Label pART_NOLabel;
            System.Windows.Forms.Label dESCRIPTIOLabel;
            System.Windows.Forms.Label qTYLabel;
            System.Windows.Forms.Label qTY_MLabel;
            System.Windows.Forms.Label uNIT_PRICELabel;
            System.Windows.Forms.Label uNIT_PRIC2Label;
            this.project_UASDataSet = new ProjectPCSuas.Project_UASDataSet();
            this.t_invoiceppn_detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_invoiceppn_detailTableAdapter = new ProjectPCSuas.Project_UASDataSetTableAdapters.t_invoiceppn_detailTableAdapter();
            this.tableAdapterManager = new ProjectPCSuas.Project_UASDataSetTableAdapters.TableAdapterManager();
            this.t_invoiceppn_detailBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.t_invoiceppn_detailBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nO_INVTextBox = new System.Windows.Forms.TextBox();
            this.kODETextBox = new System.Windows.Forms.TextBox();
            this.pART_NOTextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPTIOTextBox = new System.Windows.Forms.TextBox();
            this.qTYTextBox = new System.Windows.Forms.TextBox();
            this.qTY_MTextBox = new System.Windows.Forms.TextBox();
            this.uNIT_PRICETextBox = new System.Windows.Forms.TextBox();
            this.uNIT_PRIC2TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            nO_INVLabel = new System.Windows.Forms.Label();
            kODELabel = new System.Windows.Forms.Label();
            pART_NOLabel = new System.Windows.Forms.Label();
            dESCRIPTIOLabel = new System.Windows.Forms.Label();
            qTYLabel = new System.Windows.Forms.Label();
            qTY_MLabel = new System.Windows.Forms.Label();
            uNIT_PRICELabel = new System.Windows.Forms.Label();
            uNIT_PRIC2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.project_UASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_detailBindingNavigator)).BeginInit();
            this.t_invoiceppn_detailBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // project_UASDataSet
            // 
            this.project_UASDataSet.DataSetName = "Project_UASDataSet";
            this.project_UASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_invoiceppn_detailBindingSource
            // 
            this.t_invoiceppn_detailBindingSource.DataMember = "t_invoiceppn_detail";
            this.t_invoiceppn_detailBindingSource.DataSource = this.project_UASDataSet;
            // 
            // t_invoiceppn_detailTableAdapter
            // 
            this.t_invoiceppn_detailTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.t_invoiceppn_detailTableAdapter = this.t_invoiceppn_detailTableAdapter;
            this.tableAdapterManager.t_invoiceppn_headerTableAdapter = null;
            this.tableAdapterManager.t_label_hargaTableAdapter = null;
            this.tableAdapterManager.t_pembelian_detailTableAdapter = null;
            this.tableAdapterManager.t_pembelian_headerTableAdapter = null;
            this.tableAdapterManager.t_penawaran_detailTableAdapter = null;
            this.tableAdapterManager.t_penawaran_headerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectPCSuas.Project_UASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_invoiceppn_detailBindingNavigator
            // 
            this.t_invoiceppn_detailBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_invoiceppn_detailBindingNavigator.BindingSource = this.t_invoiceppn_detailBindingSource;
            this.t_invoiceppn_detailBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_invoiceppn_detailBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_invoiceppn_detailBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.t_invoiceppn_detailBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_invoiceppn_detailBindingNavigatorSaveItem});
            this.t_invoiceppn_detailBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_invoiceppn_detailBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_invoiceppn_detailBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_invoiceppn_detailBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_invoiceppn_detailBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_invoiceppn_detailBindingNavigator.Name = "t_invoiceppn_detailBindingNavigator";
            this.t_invoiceppn_detailBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_invoiceppn_detailBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.t_invoiceppn_detailBindingNavigator.TabIndex = 0;
            this.t_invoiceppn_detailBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
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
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // t_invoiceppn_detailBindingNavigatorSaveItem
            // 
            this.t_invoiceppn_detailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_invoiceppn_detailBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_invoiceppn_detailBindingNavigatorSaveItem.Image")));
            this.t_invoiceppn_detailBindingNavigatorSaveItem.Name = "t_invoiceppn_detailBindingNavigatorSaveItem";
            this.t_invoiceppn_detailBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.t_invoiceppn_detailBindingNavigatorSaveItem.Text = "Save Data";
            this.t_invoiceppn_detailBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_invoiceppn_detailBindingNavigatorSaveItem_Click);
            // 
            // nO_INVLabel
            // 
            nO_INVLabel.AutoSize = true;
            nO_INVLabel.Location = new System.Drawing.Point(290, 89);
            nO_INVLabel.Name = "nO_INVLabel";
            nO_INVLabel.Size = new System.Drawing.Size(59, 17);
            nO_INVLabel.TabIndex = 1;
            nO_INVLabel.Text = "NO INV:";
            // 
            // nO_INVTextBox
            // 
            this.nO_INVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_detailBindingSource, "NO_INV", true));
            this.nO_INVTextBox.Location = new System.Drawing.Point(355, 86);
            this.nO_INVTextBox.Name = "nO_INVTextBox";
            this.nO_INVTextBox.Size = new System.Drawing.Size(215, 22);
            this.nO_INVTextBox.TabIndex = 2;
            // 
            // kODELabel
            // 
            kODELabel.AutoSize = true;
            kODELabel.Location = new System.Drawing.Point(298, 136);
            kODELabel.Name = "kODELabel";
            kODELabel.Size = new System.Drawing.Size(51, 17);
            kODELabel.TabIndex = 3;
            kODELabel.Text = "KODE:";
            kODELabel.Click += new System.EventHandler(this.kODELabel_Click);
            // 
            // kODETextBox
            // 
            this.kODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_detailBindingSource, "KODE", true));
            this.kODETextBox.Location = new System.Drawing.Point(355, 133);
            this.kODETextBox.Name = "kODETextBox";
            this.kODETextBox.Size = new System.Drawing.Size(215, 22);
            this.kODETextBox.TabIndex = 4;
            this.kODETextBox.TextChanged += new System.EventHandler(this.kODETextBox_TextChanged);
            // 
            // pART_NOLabel
            // 
            pART_NOLabel.AutoSize = true;
            pART_NOLabel.Location = new System.Drawing.Point(275, 181);
            pART_NOLabel.Name = "pART_NOLabel";
            pART_NOLabel.Size = new System.Drawing.Size(74, 17);
            pART_NOLabel.TabIndex = 5;
            pART_NOLabel.Text = "PART NO:";
            // 
            // pART_NOTextBox
            // 
            this.pART_NOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_detailBindingSource, "PART_NO", true));
            this.pART_NOTextBox.Location = new System.Drawing.Point(355, 178);
            this.pART_NOTextBox.Name = "pART_NOTextBox";
            this.pART_NOTextBox.Size = new System.Drawing.Size(215, 22);
            this.pART_NOTextBox.TabIndex = 6;
            // 
            // dESCRIPTIOLabel
            // 
            dESCRIPTIOLabel.AutoSize = true;
            dESCRIPTIOLabel.Location = new System.Drawing.Point(255, 233);
            dESCRIPTIOLabel.Name = "dESCRIPTIOLabel";
            dESCRIPTIOLabel.Size = new System.Drawing.Size(94, 17);
            dESCRIPTIOLabel.TabIndex = 7;
            dESCRIPTIOLabel.Text = "DESCRIPTIO:";
            // 
            // dESCRIPTIOTextBox
            // 
            this.dESCRIPTIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_detailBindingSource, "DESCRIPTIO", true));
            this.dESCRIPTIOTextBox.Location = new System.Drawing.Point(355, 230);
            this.dESCRIPTIOTextBox.Name = "dESCRIPTIOTextBox";
            this.dESCRIPTIOTextBox.Size = new System.Drawing.Size(215, 22);
            this.dESCRIPTIOTextBox.TabIndex = 8;
            // 
            // qTYLabel
            // 
            qTYLabel.AutoSize = true;
            qTYLabel.Location = new System.Drawing.Point(308, 278);
            qTYLabel.Name = "qTYLabel";
            qTYLabel.Size = new System.Drawing.Size(41, 17);
            qTYLabel.TabIndex = 9;
            qTYLabel.Text = "QTY:";
            // 
            // qTYTextBox
            // 
            this.qTYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_detailBindingSource, "QTY", true));
            this.qTYTextBox.Location = new System.Drawing.Point(355, 275);
            this.qTYTextBox.Name = "qTYTextBox";
            this.qTYTextBox.Size = new System.Drawing.Size(215, 22);
            this.qTYTextBox.TabIndex = 10;
            // 
            // qTY_MLabel
            // 
            qTY_MLabel.AutoSize = true;
            qTY_MLabel.Location = new System.Drawing.Point(293, 326);
            qTY_MLabel.Name = "qTY_MLabel";
            qTY_MLabel.Size = new System.Drawing.Size(56, 17);
            qTY_MLabel.TabIndex = 11;
            qTY_MLabel.Text = "QTY M:";
            // 
            // qTY_MTextBox
            // 
            this.qTY_MTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_detailBindingSource, "QTY_M", true));
            this.qTY_MTextBox.Location = new System.Drawing.Point(355, 323);
            this.qTY_MTextBox.Name = "qTY_MTextBox";
            this.qTY_MTextBox.Size = new System.Drawing.Size(215, 22);
            this.qTY_MTextBox.TabIndex = 12;
            // 
            // uNIT_PRICELabel
            // 
            uNIT_PRICELabel.AutoSize = true;
            uNIT_PRICELabel.Location = new System.Drawing.Point(261, 368);
            uNIT_PRICELabel.Name = "uNIT_PRICELabel";
            uNIT_PRICELabel.Size = new System.Drawing.Size(88, 17);
            uNIT_PRICELabel.TabIndex = 13;
            uNIT_PRICELabel.Text = "UNIT PRICE:";
            // 
            // uNIT_PRICETextBox
            // 
            this.uNIT_PRICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_detailBindingSource, "UNIT_PRICE", true));
            this.uNIT_PRICETextBox.Location = new System.Drawing.Point(355, 365);
            this.uNIT_PRICETextBox.Name = "uNIT_PRICETextBox";
            this.uNIT_PRICETextBox.Size = new System.Drawing.Size(215, 22);
            this.uNIT_PRICETextBox.TabIndex = 14;
            // 
            // uNIT_PRIC2Label
            // 
            uNIT_PRIC2Label.AutoSize = true;
            uNIT_PRIC2Label.Location = new System.Drawing.Point(262, 410);
            uNIT_PRIC2Label.Name = "uNIT_PRIC2Label";
            uNIT_PRIC2Label.Size = new System.Drawing.Size(87, 17);
            uNIT_PRIC2Label.TabIndex = 15;
            uNIT_PRIC2Label.Text = "UNIT PRIC2:";
            // 
            // uNIT_PRIC2TextBox
            // 
            this.uNIT_PRIC2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoiceppn_detailBindingSource, "UNIT_PRIC2", true));
            this.uNIT_PRIC2TextBox.Location = new System.Drawing.Point(355, 407);
            this.uNIT_PRIC2TextBox.Name = "uNIT_PRIC2TextBox";
            this.uNIT_PRIC2TextBox.Size = new System.Drawing.Size(215, 22);
            this.uNIT_PRIC2TextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(637, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Detail_INV_PPN";
            // 
            // detail_INV_PPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(uNIT_PRIC2Label);
            this.Controls.Add(this.uNIT_PRIC2TextBox);
            this.Controls.Add(uNIT_PRICELabel);
            this.Controls.Add(this.uNIT_PRICETextBox);
            this.Controls.Add(qTY_MLabel);
            this.Controls.Add(this.qTY_MTextBox);
            this.Controls.Add(qTYLabel);
            this.Controls.Add(this.qTYTextBox);
            this.Controls.Add(dESCRIPTIOLabel);
            this.Controls.Add(this.dESCRIPTIOTextBox);
            this.Controls.Add(pART_NOLabel);
            this.Controls.Add(this.pART_NOTextBox);
            this.Controls.Add(kODELabel);
            this.Controls.Add(this.kODETextBox);
            this.Controls.Add(nO_INVLabel);
            this.Controls.Add(this.nO_INVTextBox);
            this.Controls.Add(this.t_invoiceppn_detailBindingNavigator);
            this.Name = "detail_INV_PPN";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.detail_INV_PPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_UASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoiceppn_detailBindingNavigator)).EndInit();
            this.t_invoiceppn_detailBindingNavigator.ResumeLayout(false);
            this.t_invoiceppn_detailBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Project_UASDataSet project_UASDataSet;
        private System.Windows.Forms.BindingSource t_invoiceppn_detailBindingSource;
        private Project_UASDataSetTableAdapters.t_invoiceppn_detailTableAdapter t_invoiceppn_detailTableAdapter;
        private Project_UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_invoiceppn_detailBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_invoiceppn_detailBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nO_INVTextBox;
        private System.Windows.Forms.TextBox kODETextBox;
        private System.Windows.Forms.TextBox pART_NOTextBox;
        private System.Windows.Forms.TextBox dESCRIPTIOTextBox;
        private System.Windows.Forms.TextBox qTYTextBox;
        private System.Windows.Forms.TextBox qTY_MTextBox;
        private System.Windows.Forms.TextBox uNIT_PRICETextBox;
        private System.Windows.Forms.TextBox uNIT_PRIC2TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}