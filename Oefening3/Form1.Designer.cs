namespace Oefening3
{
    partial class Form1
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
            this.lbMijnLijst = new System.Windows.Forms.ListBox();
            this.tbMijnTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbMijnLijst
            // 
            this.lbMijnLijst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMijnLijst.FormattingEnabled = true;
            this.lbMijnLijst.Location = new System.Drawing.Point(12, 35);
            this.lbMijnLijst.MultiColumn = true;
            this.lbMijnLijst.Name = "lbMijnLijst";
            this.lbMijnLijst.ScrollAlwaysVisible = true;
            this.lbMijnLijst.Size = new System.Drawing.Size(381, 407);
            this.lbMijnLijst.TabIndex = 0;
            // 
            // tbMijnTextBox
            // 
            this.tbMijnTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMijnTextBox.Location = new System.Drawing.Point(12, 9);
            this.tbMijnTextBox.Name = "tbMijnTextBox";
            this.tbMijnTextBox.Size = new System.Drawing.Size(381, 20);
            this.tbMijnTextBox.TabIndex = 1;
            this.tbMijnTextBox.TextChanged += new System.EventHandler(this.tbMijnTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.tbMijnTextBox);
            this.Controls.Add(this.lbMijnLijst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMijnLijst;
        private System.Windows.Forms.TextBox tbMijnTextBox;
    }
}

