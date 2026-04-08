namespace if_sart_pozitif_negatif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Bir sayı giriniz:");
            sayi = int.Parse(Console.ReadLine()); ;
           // sayi = Convert.ToInt32(Console.ReadLine);

            if(sayi>0)
                Console.WriteLine("Pozitif Sayı");
            else if(sayi<0)
                Console.WriteLine("Negatif Sayı");
            else if(sayi==0)
                Console.WriteLine("Sıfır");

        }
    }
}
