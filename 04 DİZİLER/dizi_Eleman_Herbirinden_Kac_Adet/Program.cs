namespace Yeni_Dizi_Eleman_Herbirinden_Kac_Adet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 10, 20, 30, 10, 40, 50, 20, 30, 10 };
            int[] b = new int[a.Length];
            int sayac, sonindis = 0;
            bool bulundu;
            
            for (int i = 0; i < a.Length; i++) {
               // Console.WriteLine(a[i]+" kontrol ediliyor...");
                sayac = 0;
                bulundu = false;    
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                        sayac++;
                }
               // Console.WriteLine(a[i] + "=> " + sayac + " adet var");
                  for (int k = 0; k < b.Length; k++)
                   {
                       if (a[i] == b[k])
                           bulundu = true;
                   }
                   if (bulundu == false)
                   {
                       b[sonindis] = a[i];
                       Console.WriteLine(a[i] + "=> " + sayac + " adet var");
                       sonindis++;
                   }

            }

           

        }
    }
}
