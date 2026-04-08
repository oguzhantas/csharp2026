
namespace while_sermaye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sermaye = 1000;
            int i = 1;
           /* while (i <= 20)
            {
                sermaye += sermaye * 0.1;
                Console.WriteLine(i+". yılın sonunda Sermaye:"+sermaye);
                i++;
            }
            Console.ReadKey();*/

            for (i = 1; i <= 20; i++)
            {
               sermaye += sermaye * 0.1;
               Console.WriteLine(i + ". yılın sonunda Sermaye:" + sermaye);
            }

        }
    }
}
