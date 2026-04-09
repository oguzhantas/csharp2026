namespace Metot_Standart_Sapma
{
    internal class Program
    {

        static double standartSapma(int[] a)
        {
            double ortalama = 0;
            double toplam = 0;
            double standartSapma = 0;
            for (int i = 0; i < a.Length; i++)  //Dizi toplamını buluyoruz
            {
                toplam += a[i];
            }
            ortalama = toplam / a.Length; //Ortalamayı buluyoruz
            //Dizinin her bir elemanını ortalamadan çıkarıyoruz sonra karesini alıyoruz. 
            for (int i = 0; i < a.Length; i++)
            {
                standartSapma += Math.Pow(a[i] - ortalama, 2);
            }
            //sqrt fonksiyonu ile karakökünü buluyoruz
            standartSapma = Math.Sqrt(standartSapma / a.Length);
            return standartSapma;
        }
        static void Main(string[] args)
        {
            int[] elemanlar = { 3,4,5};

            double sonuc = standartSapma(elemanlar);
            Console.WriteLine("Standart Sapma:"+sonuc);
        }
    }
}
