namespace Metot_DiziYaz1
{
    internal class Program
    {
        static void diziYaz(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] b = { 1, 3, 5, 7, 9, 15 };
            diziYaz(b);
        }
    }
}
