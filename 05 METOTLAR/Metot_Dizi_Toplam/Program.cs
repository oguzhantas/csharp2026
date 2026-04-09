namespace Metot_Dizi_Toplam
{
    internal class Program
    {
        static double diziToplam(double[] a)
        {
            double toplam = 0;
            for(int i = 0; i < a.Length; i++)
            {
                toplam+= a[i];
            }
            return toplam;
        }
        static void Main(string[] args)
        {
            double[] b = { 10, 20, 30,40.5 };
            Console.WriteLine(diziToplam(b));
        }
    }
}
