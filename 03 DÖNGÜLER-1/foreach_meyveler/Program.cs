namespace foreach_meyveler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = { "elma", "kivi", "muz","çilek" };
            foreach (var  m in meyveler)
            {
                Console.WriteLine(m);
            }
        }
    }
}
