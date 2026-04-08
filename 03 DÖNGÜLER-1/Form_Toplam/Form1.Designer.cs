namespace Form_Toplam
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
            btnHesapla = new Button();
            txtSayi1 = new TextBox();
            txtSayi2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnHesapla
            // 
            btnHesapla.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnHesapla.Location = new Point(145, 127);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(166, 39);
            btnHesapla.TabIndex = 0;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // txtSayi1
            // 
            txtSayi1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtSayi1.Location = new Point(145, 29);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(166, 33);
            txtSayi1.TabIndex = 1;
            // 
            // txtSayi2
            // 
            txtSayi2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtSayi2.Location = new Point(143, 69);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(168, 33);
            txtSayi2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(52, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 3;
            label1.Text = "Sayı 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(52, 77);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 4;
            label2.Text = "Sayı 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 202);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSayi2);
            Controls.Add(txtSayi1);
            Controls.Add(btnHesapla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHesapla;
        private TextBox txtSayi1;
        private TextBox txtSayi2;
        private Label label1;
        private Label label2;
    }
}
