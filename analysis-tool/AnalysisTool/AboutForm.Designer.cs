namespace AnalysisTool
{
    partial class AboutForm
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
            this.buttonCloseAbout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCloseAbout
            // 
            this.buttonCloseAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCloseAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseAbout.Location = new System.Drawing.Point(10, 34);
            this.buttonCloseAbout.Name = "buttonCloseAbout";
            this.buttonCloseAbout.Size = new System.Drawing.Size(264, 23);
            this.buttonCloseAbout.TabIndex = 0;
            this.buttonCloseAbout.Text = "Close";
            this.buttonCloseAbout.UseVisualStyleBackColor = true;
            this.buttonCloseAbout.Click += new System.EventHandler(this.buttonCloseAbout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version 0.1";
            // 
            // AboutForm
            // 
            this.AcceptButton = this.buttonCloseAbout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 67);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCloseAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseAbout;
        private System.Windows.Forms.Label label1;
    }
}