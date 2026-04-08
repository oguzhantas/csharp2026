namespace Metod_04_Satis_Fiyati
{
    internal class Program
    {
        static double hesapla(double alis, double kar)
        {
            double satisfiyati=0;
            satisfiyati = alis + kar;
            
            return (satisfiyati); 
        }

        static void Main(string[] args)
        {
            double a = 500; //alış fiyatı
            double k = 100; // kar 
            Console.WriteLine("Satış Fiyatı:"+ hesapla(a,k));
        }
    }
}
