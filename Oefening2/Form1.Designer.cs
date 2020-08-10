namespace Oefening2
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
            this.cbMijnComboBox = new System.Windows.Forms.ComboBox();
            this.btnMijnKnop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbMijnComboBox
            // 
            this.cbMijnComboBox.FormattingEnabled = true;
            this.cbMijnComboBox.Location = new System.Drawing.Point(12, 12);
            this.cbMijnComboBox.Name = "cbMijnComboBox";
            this.cbMijnComboBox.Size = new System.Drawing.Size(121, 21);
            this.cbMijnComboBox.TabIndex = 0;
            // 
            // btnMijnKnop
            // 
            this.btnMijnKnop.Location = new System.Drawing.Point(12, 40);
            this.btnMijnKnop.Name = "btnMijnKnop";
            this.btnMijnKnop.Size = new System.Drawing.Size(121, 23);
            this.btnMijnKnop.TabIndex = 1;
            this.btnMijnKnop.Text = "Verwijder uit de lijst";
            this.btnMijnKnop.UseVisualStyleBackColor = true;
            this.btnMijnKnop.Click += new System.EventHandler(this.btnMijnKnop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMijnKnop);
            this.Controls.Add(this.cbMijnComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMijnComboBox;
        private System.Windows.Forms.Button btnMijnKnop;
    }
}

