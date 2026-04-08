namespace if_kullanici_sifre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullanici, sifre;

            Console.WriteLine("Kullanıcı adını giriniz:");
            kullanici= Console.ReadLine();

            Console.WriteLine("Şifre giriniz:");
            sifre = Console.ReadLine();

            if(kullanici=="oguzhan" && sifre=="1234")
                Console.WriteLine("Giriş yapabilirsiniz");
            else
                Console.WriteLine("Kullanıcı adı - şifre yanlış");

        }
    }
}
