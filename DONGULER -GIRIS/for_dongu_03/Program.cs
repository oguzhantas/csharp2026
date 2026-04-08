namespace for_dongu_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, baslangic,  bitis,  artim;

            Console.Write("Başlangıç değerini giriniz:");
            baslangic =int.Parse(Console.ReadLine());
           
            Console.Write("Bitiş değerini giriniz:");
            bitis = int.Parse(Console.ReadLine());

            Console.Write("Artım değerini giriniz:");
            artim = int.Parse(Console.ReadLine());

            for (i = baslangic; i <= bitis; i += artim)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Son i değeri:"+i);
            Console.ReadKey();
        }
    }
}
