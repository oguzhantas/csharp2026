namespace BKI_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bki, kilo, boy;
            Console.WriteLine("Kilonuzu giriniz");
            kilo = double.Parse(Console.ReadLine());

            Console.WriteLine("Boyunuzu giriniz:");
            boy= double.Parse(Console.ReadLine());

            bki = kilo / (boy * boy); 
            //Boyun karesi için Math.Pow(boy, 2); yazabilirsiniz
            Console.WriteLine("BKI değeri:" + bki);
            Console.ReadKey();
        }
    }
}
