namespace if_Bilet_Indirim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim;
            double biletFiyat=0, fiyat=1000;
            Console.WriteLine(  "Meslek seçiniz:\n"+
                                "1) Öğrenci %40\n"+
                                "2) Öğretmen %30\n"+
                                "3) Sağlık Çalışan %20\n"+
                                "4) TSK Mensubu %25\n"+
                                "5) Diğer(İndirim yok)");
            Console.Write("Seçiminiz:");
             secim = int.Parse(Console.ReadLine());
            if (secim == 1)
                biletFiyat = fiyat- (fiyat * 0.40);
            else if (secim == 2)
                biletFiyat = fiyat- (fiyat * 0.30);
            else if (secim == 3)
                biletFiyat = fiyat- (fiyat * 0.20);
            else if (secim == 4)
                biletFiyat = fiyat- (fiyat * 0.25);
            else
                biletFiyat = fiyat;
            Console.WriteLine("Bilet fiyatı:"+biletFiyat);
        }
    }
}
