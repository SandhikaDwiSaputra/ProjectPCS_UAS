
namespace ProjectPCSuas
{
    partial class PrintMasterMerk
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
            this.crystalReportViewerMerk = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerMerk
            // 
            this.crystalReportViewerMerk.ActiveViewIndex = -1;
            this.crystalReportViewerMerk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerMerk.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerMerk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerMerk.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerMerk.Name = "crystalReportViewerMerk";
            this.crystalReportViewerMerk.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerMerk.TabIndex = 0;
            this.crystalReportViewerMerk.Load += new System.EventHandler(this.crystalReportViewerMerk_Load);
            // 
            // PrintMasterMerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerMerk);
            this.Name = "PrintMasterMerk";
            this.Text = "PrintMasterMerk";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerMerk;
    }
}