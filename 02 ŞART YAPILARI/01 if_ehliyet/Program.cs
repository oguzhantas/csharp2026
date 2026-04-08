namespace if_ehliyet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yas;
            Console.WriteLine("Yaşınızı giriniz:");
            yas= int.Parse(Console.ReadLine());

            if (yas >= 18)
                Console.WriteLine("Ehliyet alabilirsiniz");
            else
                Console.WriteLine("Ehliyet alamazsınız, yaşınız küçük");
        }
    }
}
