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
            this.btnMijnKnop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMijnLijst
            // 
            this.lbMijnLijst.FormattingEnabled = true;
            this.lbMijnLijst.Location = new System.Drawing.Point(32, 35);
            this.lbMijnLijst.Name = "lbMijnLijst";
            this.lbMijnLijst.Size = new System.Drawing.Size(137, 381);
            this.lbMijnLijst.TabIndex = 0;
            // 
            // tbMijnTextBox
            // 
            this.tbMijnTextBox.Location = new System.Drawing.Point(191, 35);
            this.tbMijnTextBox.Name = "tbMijnTextBox";
            this.tbMijnTextBox.Size = new System.Drawing.Size(100, 20);
            this.tbMijnTextBox.TabIndex = 1;
            // 
            // btnMijnKnop
            // 
            this.btnMijnKnop.Location = new System.Drawing.Point(191, 62);
            this.btnMijnKnop.Name = "btnMijnKnop";
            this.btnMijnKnop.Size = new System.Drawing.Size(100, 23);
            this.btnMijnKnop.TabIndex = 2;
            this.btnMijnKnop.Text = "Filter op text";
            this.btnMijnKnop.UseVisualStyleBackColor = true;
            this.btnMijnKnop.Click += new System.EventHandler(this.btnMijnKnop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMijnKnop);
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
        private System.Windows.Forms.Button btnMijnKnop;
    }
}

