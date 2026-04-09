namespace Metot_İki_Dizi_Toplam
{
    internal class Program
    {

        static int[] ikiDiziTopla(int[] a, int[] b)
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
            int[] y = { 6, 7, 8 };
            int[]z = ikiDiziTopla(x, y);
            for (int i = 0; i < z.Length; i++)
            {
                Console.WriteLine(z[i]);
            }
        }
    }
}
