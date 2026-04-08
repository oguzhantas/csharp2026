namespace if_dort_islem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sonuc=0;
            char islem;
            Console.Write("1. sayıyı giriniz:");
            sayi1 = int.Parse(Console.ReadLine());

            Console.Write("2. sayıyı giriniz:");
            sayi2 = int.Parse(Console.ReadLine());
            
            Console.Write("İşlemi giriniz(+,-,*,/)");
            islem= char.Parse(Console.ReadLine());  //DİKKAT

            if (islem == '+')
                sonuc = sayi1 + sayi2;
            else if (islem == '-')
                sonuc = sayi1 - sayi2;
            else if (islem == '*')
                sonuc = sayi1 * sayi2;
            else if (islem == '/')
                sonuc = sayi1 / sayi2;
            else
                Console.WriteLine("Lütfen +,-,*,/ giriniz");

            Console.WriteLine("Sonuç:"+sonuc);

        }
    }
}
