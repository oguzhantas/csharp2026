namespace Dizi_notlar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notlar = { 55.5, 60, 70, 40, 20, 60 };
            int gecenSayisi=0, kalanSayisi=0;
            double gecenToplam = 0, kalanToplam=0;
            for (int i = 0; i < notlar.Length; i++)
            {
                if(notlar[i] >= 50)
                {
                    gecenSayisi++;
                    gecenToplam += notlar[i];
                }
                else
                {
                    kalanSayisi++;
                    kalanToplam += notlar[i];
                }
            }
            double gecenOrtalama = gecenToplam / gecenSayisi;
            double kalanOrtalama= kalanToplam / kalanSayisi;
            Console.WriteLine("Geçenlerin ortalaması:"+gecenOrtalama);
            Console.WriteLine("Kalanların ortalaması:" + kalanOrtalama);

        }
    }
}
