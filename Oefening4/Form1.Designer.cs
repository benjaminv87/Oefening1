namespace Oefening4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVoornaam = new System.Windows.Forms.TextBox();
            this.tbFamilienaam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbMijnComboBox
            // 
            this.cbMijnComboBox.FormattingEnabled = true;
            this.cbMijnComboBox.Location = new System.Drawing.Point(12, 12);
            this.cbMijnComboBox.Name = "cbMijnComboBox";
            this.cbMijnComboBox.Size = new System.Drawing.Size(242, 21);
            this.cbMijnComboBox.TabIndex = 0;
            this.cbMijnComboBox.SelectedIndexChanged += new System.EventHandler(this.cbMijnComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voornaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Familienaam";
            // 
            // tbVoornaam
            // 
            this.tbVoornaam.Location = new System.Drawing.Point(12, 77);
            this.tbVoornaam.Name = "tbVoornaam";
            this.tbVoornaam.Size = new System.Drawing.Size(115, 20);
            this.tbVoornaam.TabIndex = 3;
            this.tbVoornaam.Visible = false;
            this.tbVoornaam.Leave += new System.EventHandler(this.tbVoornaam_Leave);
            // 
            // tbFamilienaam
            // 
            this.tbFamilienaam.Location = new System.Drawing.Point(139, 77);
            this.tbFamilienaam.Name = "tbFamilienaam";
            this.tbFamilienaam.Size = new System.Drawing.Size(115, 20);
            this.tbFamilienaam.TabIndex = 4;
            this.tbFamilienaam.Visible = false;
            this.tbFamilienaam.Leave += new System.EventHandler(this.tbFamilienaam_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbFamilienaam);
            this.Controls.Add(this.tbVoornaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMijnComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMijnComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVoornaam;
        private System.Windows.Forms.TextBox tbFamilienaam;
    }
}

