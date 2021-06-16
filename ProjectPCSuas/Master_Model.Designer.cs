
namespace ProjectPCSuas
{
    partial class MasterModel
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
            System.Windows.Forms.Label mODEL_IDLabel;
            System.Windows.Forms.Label dESCRIPTIONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterModel));
            this.uASDataSet2 = new ProjectPCSuas.UASDataSet2();
            this.m_modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_modelTableAdapter = new ProjectPCSuas.UASDataSet2TableAdapters.m_modelTableAdapter();
            this.tableAdapterManager = new ProjectPCSuas.UASDataSet2TableAdapters.TableAdapterManager();
            this.m_modelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.m_modelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mODEL_IDTextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            this.BrowseBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            mODEL_IDLabel = new System.Windows.Forms.Label();
            dESCRIPTIONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_modelBindingNavigator)).BeginInit();
            this.m_modelBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // mODEL_IDLabel
            // 
            mODEL_IDLabel.AutoSize = true;
            mODEL_IDLabel.Location = new System.Drawing.Point(148, 124);
            mODEL_IDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            mODEL_IDLabel.Name = "mODEL_IDLabel";
            mODEL_IDLabel.Size = new System.Drawing.Size(62, 13);
            mODEL_IDLabel.TabIndex = 1;
            mODEL_IDLabel.Text = "MODEL ID:";
            // 
            // dESCRIPTIONLabel
            // 
            dESCRIPTIONLabel.AutoSize = true;
            dESCRIPTIONLabel.Location = new System.Drawing.Point(148, 146);
            dESCRIPTIONLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dESCRIPTIONLabel.Name = "dESCRIPTIONLabel";
            dESCRIPTIONLabel.Size = new System.Drawing.Size(83, 13);
            dESCRIPTIONLabel.TabIndex = 3;
            dESCRIPTIONLabel.Text = "DESCRIPTION:";
            // 
            // uASDataSet2
            // 
            this.uASDataSet2.DataSetName = "UASDataSet2";
            this.uASDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_modelBindingSource
            // 
            this.m_modelBindingSource.DataMember = "m_model";
            this.m_modelBindingSource.DataSource = this.uASDataSet2;
            // 
            // m_modelTableAdapter
            // 
            this.m_modelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.m_barangTableAdapter = null;
            this.tableAdapterManager.m_groupuserTableAdapter = null;
            this.tableAdapterManager.m_hakaksesgroupuserTableAdapter = null;
            this.tableAdapterManager.m_kotaTableAdapter = null;
            this.tableAdapterManager.m_merkTableAdapter = null;
            this.tableAdapterManager.m_modelTableAdapter = this.m_modelTableAdapter;
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
            // m_modelBindingNavigator
            // 
            this.m_modelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_modelBindingNavigator.BindingSource = this.m_modelBindingSource;
            this.m_modelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_modelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_modelBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.m_modelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_modelBindingNavigatorSaveItem});
            this.m_modelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_modelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_modelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_modelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_modelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_modelBindingNavigator.Name = "m_modelBindingNavigator";
            this.m_modelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_modelBindingNavigator.Size = new System.Drawing.Size(574, 27);
            this.m_modelBindingNavigator.TabIndex = 0;
            this.m_modelBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // m_modelBindingNavigatorSaveItem
            // 
            this.m_modelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_modelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_modelBindingNavigatorSaveItem.Image")));
            this.m_modelBindingNavigatorSaveItem.Name = "m_modelBindingNavigatorSaveItem";
            this.m_modelBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.m_modelBindingNavigatorSaveItem.Text = "Save Data";
            this.m_modelBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_modelBindingNavigatorSaveItem_Click);
            // 
            // mODEL_IDTextBox
            // 
            this.mODEL_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_modelBindingSource, "MODEL_ID", true));
            this.mODEL_IDTextBox.Location = new System.Drawing.Point(230, 121);
            this.mODEL_IDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mODEL_IDTextBox.Name = "mODEL_IDTextBox";
            this.mODEL_IDTextBox.Size = new System.Drawing.Size(76, 20);
            this.mODEL_IDTextBox.TabIndex = 2;
            // 
            // dESCRIPTIONTextBox
            // 
            this.dESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_modelBindingSource, "DESCRIPTION", true));
            this.dESCRIPTIONTextBox.Location = new System.Drawing.Point(230, 144);
            this.dESCRIPTIONTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dESCRIPTIONTextBox.Name = "dESCRIPTIONTextBox";
            this.dESCRIPTIONTextBox.Size = new System.Drawing.Size(76, 20);
            this.dESCRIPTIONTextBox.TabIndex = 4;
            // 
            // BrowseBTN
            // 
            this.BrowseBTN.Location = new System.Drawing.Point(407, 50);
            this.BrowseBTN.Name = "BrowseBTN";
            this.BrowseBTN.Size = new System.Drawing.Size(75, 23);
            this.BrowseBTN.TabIndex = 30;
            this.BrowseBTN.Text = "Browse";
            this.BrowseBTN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Input Master Model";
            // 
            // MasterModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 223);
            this.Controls.Add(this.BrowseBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(mODEL_IDLabel);
            this.Controls.Add(this.mODEL_IDTextBox);
            this.Controls.Add(dESCRIPTIONLabel);
            this.Controls.Add(this.dESCRIPTIONTextBox);
            this.Controls.Add(this.m_modelBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MasterModel";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_modelBindingNavigator)).EndInit();
            this.m_modelBindingNavigator.ResumeLayout(false);
            this.m_modelBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UASDataSet2 uASDataSet2;
        private System.Windows.Forms.BindingSource m_modelBindingSource;
        private UASDataSet2TableAdapters.m_modelTableAdapter m_modelTableAdapter;
        private UASDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_modelBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_modelBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox mODEL_IDTextBox;
        private System.Windows.Forms.TextBox dESCRIPTIONTextBox;
        private System.Windows.Forms.Button BrowseBTN;
        private System.Windows.Forms.Label label1;
    }
}