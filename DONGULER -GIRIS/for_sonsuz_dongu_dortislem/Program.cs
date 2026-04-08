namespace for_sonsuz_dongu_dortislem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char islem;
            double sayi1, sayi2, sonuc=0;
           for(; ; )
            {
                Console.WriteLine("+) TOPLAMA");
                Console.WriteLine("-) ÇIKARMA");
                Console.WriteLine("*) ÇARPMA");
                Console.WriteLine("/) BÖLME");
                Console.WriteLine("X) ÇIKIŞ");
                Console.Write("İşlem seçiniz:");
                islem= char.Parse(Console.ReadLine());
                if (islem == 'X' || islem == 'x')
                    break;
                else
                {
                    if(!(islem =='+' || islem=='-' || islem=='*' || islem=='/'))
                    {
                        Console.WriteLine("Lütfen +,-,*,/ giriniz");
                        Console.ReadKey();
                        Console.Clear();
                    }else
                    {
                        Console.Write("1. sayı:");
                        sayi1= double.Parse(Console.ReadLine());

                        Console.Write("2. sayı:");
                        sayi2 = double.Parse(Console.ReadLine());

                        if (islem == '+')
                            sonuc = sayi1 + sayi2;
                        else if (islem == '-')
                            sonuc = sayi1 - sayi2;
                        else if (islem == '*')
                            sonuc = sayi1 * sayi2;
                        else if (islem == '/')
                            sonuc = sayi1 / sayi2;
                        Console.WriteLine("Sonuç:"+sonuc);
                        Console.ReadKey();
                        Console.Clear();    
                    }
                }

            }
        }
    }
}
