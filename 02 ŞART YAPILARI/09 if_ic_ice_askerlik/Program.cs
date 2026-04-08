namespace if_ic_ice_askerlik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char cinsiyet; //Erkekse 'E', kadınsa 'K' alacağız
            int dogumtarihi, yas;

            Console.WriteLine("Cinsiyeti giriniz:");
            cinsiyet= char.Parse(Console.ReadLine());

            if(cinsiyet=='E' || cinsiyet=='e')
            {
                Console.WriteLine("Doğum tarihi giriniz:");
                dogumtarihi = int.Parse(Console.ReadLine());
                yas = 2026 - dogumtarihi;

                if (yas>=18)
                {
                    Console.WriteLine("Askere gidebilirsiz");
                }
                else
                {
                    Console.WriteLine("Askere gitmenize daha "+(18-yas) +" yıl var");
                }
            } //cinsiyet=='E'
            else if(cinsiyet=='K' || cinsiyet == 'k')
            {
                Console.WriteLine("Kadınlar şu an askere alınmıyor");
            }
            else
            {
                Console.WriteLine("Lütfen E veya K harfi giriniz");
            }
        }
    }
}
