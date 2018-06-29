namespace Reproduce_Issue {
    partial class CtrlScroll {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.scbMain = new MetroFramework.Controls.MetroScrollBar();
            this.btnExample = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // scbMain
            // 
            this.scbMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.scbMain.Location = new System.Drawing.Point(290, 0);
            this.scbMain.Name = "scbMain";
            this.scbMain.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.scbMain.Size = new System.Drawing.Size(10, 300);
            this.scbMain.TabIndex = 0;
            // 
            // btnExample
            // 
            this.btnExample.Location = new System.Drawing.Point(62, 261);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(75, 129);
            this.btnExample.TabIndex = 1;
            this.btnExample.Text = "Out of Bounds";
            this.btnExample.UseVisualStyleBackColor = true;
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBody.Controls.Add(this.btnExample);
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(290, 391);
            this.pnlBody.TabIndex = 2;
            // 
            // CtrlScroll
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.scbMain);
            this.Name = "CtrlScroll";
            this.Size = new System.Drawing.Size(300, 300);
            this.Resize += new System.EventHandler(this.CtrlScroll_Resize);
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroScrollBar scbMain;
        private System.Windows.Forms.Button btnExample;
        private System.Windows.Forms.Panel pnlBody;
    }
}
