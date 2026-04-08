namespace DikdortgenCevre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kisaKenar, uzunKenar, cevre;
            kisaKenar = 5;
            uzunKenar = 10;

            cevre = kisaKenar * uzunKenar;
            Console.WriteLine("Çevre:"+cevre);
            Console.ReadKey();
        }
    }
}
