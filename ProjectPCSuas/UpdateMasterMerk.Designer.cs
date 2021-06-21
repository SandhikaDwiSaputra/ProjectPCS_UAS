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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label mERK_DESCLabel;
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.mERK_DESCTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            mERK_DESCLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(12, 56);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 6;
            iDLabel.Text = "ID:";
            // 
            // mERK_DESCLabel
            // 
            mERK_DESCLabel.AutoSize = true;
            mERK_DESCLabel.Location = new System.Drawing.Point(12, 82);
            mERK_DESCLabel.Name = "mERK_DESCLabel";
            mERK_DESCLabel.Size = new System.Drawing.Size(73, 13);
            mERK_DESCLabel.TabIndex = 8;
            mERK_DESCLabel.Text = "MERK DESC:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.Location = new System.Drawing.Point(91, 53);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 7;
            // 
            // mERK_DESCTextBox
            // 
            this.mERK_DESCTextBox.Location = new System.Drawing.Point(91, 79);
            this.mERK_DESCTextBox.Name = "mERK_DESCTextBox";
            this.mERK_DESCTextBox.Size = new System.Drawing.Size(100, 20);
            this.mERK_DESCTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateMasterMerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(mERK_DESCLabel);
            this.Controls.Add(this.mERK_DESCTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Name = "UpdateMasterMerk";
            this.Text = "UpdateMasterMerk";
            this.Load += new System.EventHandler(this.UpdateMasterMerk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox mERK_DESCTextBox;
        private System.Windows.Forms.Button button1;
    }
}