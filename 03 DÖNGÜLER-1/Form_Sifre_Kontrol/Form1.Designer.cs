namespace Sifre_Kontrol_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKontrol = new Button();
            txtSifre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnKontrol
            // 
            btnKontrol.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKontrol.Location = new Point(141, 80);
            btnKontrol.Name = "btnKontrol";
            btnKontrol.Size = new Size(167, 35);
            btnKontrol.TabIndex = 0;
            btnKontrol.Text = "Kontrol Et";
            btnKontrol.UseVisualStyleBackColor = true;
            btnKontrol.Click += btnKontrol_Click;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtSifre.Location = new Point(141, 41);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(167, 33);
            txtSifre.TabIndex = 1;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(66, 41);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 2;
            label1.Text = "Şifre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 167);
            Controls.Add(label1);
            Controls.Add(txtSifre);
            Controls.Add(btnKontrol);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKontrol;
        private TextBox txtSifre;
        private Label label1;
    }
}
