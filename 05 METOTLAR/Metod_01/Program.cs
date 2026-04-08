namespace Metod_01
{
    internal class Program
    {
        static void yaz(string mesaj) //Parametre alan metod
        {
            Console.WriteLine(mesaj);
        }
        static void Main(string[] args)
        {
            yaz("nasılsın?");
            yaz("iyi misin?");
            yaz("i sayısını giriniz:");
            string adi = "Oğuzhan";
            yaz(adi);
        }
    }
}
