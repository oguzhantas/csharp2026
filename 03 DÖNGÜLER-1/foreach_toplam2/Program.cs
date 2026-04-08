namespace foreach_toplam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 5, 10, 15, 20, 25 };
            int toplam = 0;

            foreach (int s in sayilar)
            {
                Console.WriteLine(s);
                toplam += s;
            }
            Console.WriteLine("Toplam sonucu:"+toplam);
        }
    }
}
