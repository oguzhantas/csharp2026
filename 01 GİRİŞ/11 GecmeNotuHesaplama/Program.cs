namespace GecmeNotuHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            double v1, v2, f, p, vizeort, ortalama;
            Console.Write("1. Vize Notunu giriniz:");
            v1 = double.Parse(Console.ReadLine());

            Console.Write("2. Vize Notunu giriniz:");
            v2= double.Parse(Console.ReadLine());

            Console.Write("Proje Notunu giriniz:");
            p = double.Parse(Console.ReadLine());

            Console.Write("Final Notunu giriniz:");
            f = double.Parse(Console.ReadLine());

            vizeort = (v1 + v2) / 2;
            Console.WriteLine("Vize Ortalaması:" + vizeort);

            ortalama = (vizeort * 0.30) + (p * 0.30) + (f * 0.40);
            Console.WriteLine("Ortalama:"+ortalama);
        }
    }
}
