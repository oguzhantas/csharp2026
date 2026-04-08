namespace Dizi_Toplam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = {10, 20, 30, 40, 50};

            int toplam = 0;
            for (int i = 0; i < a.Length; i++)
            {
                toplam += a[i];
                //toplam = toplam+ a[i];
            }
            Console.WriteLine("Dizi toplamı:"+toplam);
        }
    }
}
