namespace Sifre_Kontrol_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            string sifre = "", mesaj = "";
            sifre= t<aqxtSifre.Text;
            int buyukharf = 0, kucukharf = 0, rakam = 0, sembol = 0;

            if (sifre.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakter olsun");
            }
            else
            {
                for (int i = 0; i < sifre.Length; i++)
                {
                    if (sifre[i] >= '0' && sifre[i] <= '9') rakam++;
                    else if (sifre[i] >= 'a' && sifre[i] <= 'z') kucukharf++;
                    else if (sifre[i] >= 'A' && sifre[i] <= 'Z') buyukharf++;
                    else if (sifre[i] >= '!' && sifre[i] <= '/') sembol++;
                }
                if (kucukharf < 2) mesaj = "En az 2 küçük harf olmalı \n";
                if (buyukharf < 2) mesaj += "En az 2 büyük harf olmalı \n";
                if (sembol < 2) mesaj += "En az 2  sembol olmalı \n";
                if (rakam < 2) mesaj += "En az 2 rakam olmalı \n";

                if (sembol >= 2
                 && kucukharf >= 2
                 && buyukharf >= 2
                 && rakam >= 2
                 && sifre.Length >= 8)
                {
                    MessageBox.Show("Şifre uygun");
                }
                else
                    MessageBox.Show(mesaj);
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
