
namespace yeni_dizi_siralama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = { "ananas", "kivi", "muz", "elma", "ayva","armut" };
            Array.Sort(meyveler);
            foreach (string m in meyveler) {
                Console.WriteLine(m);
            }

        }
    }
}
