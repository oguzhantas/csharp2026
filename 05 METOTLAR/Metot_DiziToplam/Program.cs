namespace Metot_DiziToplam
{
    internal class Program
    {

        static int[] diziTopla(int[] a, int[] b)
        {
            int[] c = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i] + b[i];
            }
            return c;
        }
        static void Main(string[] args)
        {
            int[] x = { 3, 4, 5 };
            int[] y = { 6,7,8 };
            int[] z = diziTopla(x, y);
            foreach ( var eleman in z)
            {
                Console.WriteLine(eleman);
            }

        }
    }
}
