namespace Denklem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //y = 4x3 + 3x2 + 5x + 2
            double x, y1, y2;

            Console.WriteLine("x değerini giriniz:");
            x = double.Parse(Console.ReadLine());

            y1 = (4 * x * x * x) + (3 * x * x) + (5 * x) + 2;
            y2 = 4 * Math.Pow(x, 3) + 3 * Math.Pow(x, 2) + 5 * x + 2;

            Console.WriteLine("y1 =" + y1);
            Console.WriteLine("y2 =" + y2);
            Console.ReadKey();


        }
    }
}
