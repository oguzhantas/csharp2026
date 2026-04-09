namespace RastgeleSayiUretme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele= new Random();
            double sayi;
            for (int i = 0; i < 6; i++)
            {
                sayi= rastgele.Next(1, 50);
                Console.WriteLine(sayi);
            }
            
        }
    }
}
