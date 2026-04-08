namespace for_dongu_14_sonsuz_toplam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double toplam = 0, sayi;
            string bilgi;
           
            for(; ; )
            {
                Console.Write("Sayı giriniz:(X:Çıkış)");
                bilgi=Console.ReadLine();
                if(bilgi=="X" || bilgi == "x")
                {
                    break;
                }
                sayi =  double.Parse(bilgi);
                toplam += sayi;
                Console.WriteLine("Toplam:" + toplam);  
            }
        
        }
    }
}
