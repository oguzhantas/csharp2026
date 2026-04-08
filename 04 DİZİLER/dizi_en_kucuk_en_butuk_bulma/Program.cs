namespace Yeni_en_kucuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 30, 10,2, 15,50, 3, 20, 9 };
            int enkucuk = a[0];
            int enbuyuk = a[0];

            for (int i = 0; i < a.Length; i++)
            { 
                if (enkucuk > a[i])
                    enkucuk = a[i];

                if (enbuyuk < a[i])
                    enbuyuk = a[i];
            }
            Console.WriteLine("En küçük değer:"+enkucuk);
            Console.WriteLine("En büyük değer:" + enbuyuk);
        }
    }
}
