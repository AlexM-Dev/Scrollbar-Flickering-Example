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
            this.btnExample.Location = new System.Drawing.Point(87, 265);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(75, 48);
            this.btnExample.TabIndex = 1;
            this.btnExample.Text = "Out of Bounds";
            this.btnExample.UseVisualStyleBackColor = true;
            // 
            // CtrlScroll
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExample);
            this.Controls.Add(this.scbMain);
            this.Name = "CtrlScroll";
            this.Size = new System.Drawing.Size(300, 300);
            this.Load += new System.EventHandler(this.CtrlScroll_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroScrollBar scbMain;
        private System.Windows.Forms.Button btnExample;
    }
}
