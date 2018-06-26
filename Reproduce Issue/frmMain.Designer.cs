namespace Reproduce_Issue {
    partial class frmMain {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ctrlScroll1 = new Reproduce_Issue.CtrlScroll();
            this.SuspendLayout();
            // 
            // ctrlScroll1
            // 
            this.ctrlScroll1.BackColor = System.Drawing.Color.White;
            this.ctrlScroll1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlScroll1.Location = new System.Drawing.Point(0, 0);
            this.ctrlScroll1.Name = "ctrlScroll1";
            this.ctrlScroll1.Size = new System.Drawing.Size(284, 261);
            this.ctrlScroll1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ctrlScroll1);
            this.Name = "frmMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlScroll ctrlScroll1;
    }
}

