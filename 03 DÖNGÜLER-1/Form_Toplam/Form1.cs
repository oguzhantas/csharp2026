namespace Form_Toplam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = int.Parse( txtSayi1.Text);
            sayi2 = int.Parse(txtSayi2.Text);
            toplam = sayi1 + sayi2;
            MessageBox.Show("Toplam:" + toplam);

        }
    }
}
