namespace KareAlanCevre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, alan, cevre;

            Console.Write("Karenin bir kenarını giriniz:");
            a= int.Parse(Console.ReadLine());

            alan = a * a;
            cevre = 4 * a;

            Console.Write("Alan=" + alan + " Çevre:" + cevre);
            Console.ReadKey();

        }
    }
}
