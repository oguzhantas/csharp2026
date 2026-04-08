namespace if_Vergi_Dilimleri2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kazanc, vergi=0;

            Console.WriteLine("Kazancınızı giriniz:");
            kazanc= double.Parse(Console.ReadLine());

            if (kazanc <= 190000)
            {
                vergi = kazanc * 0.15; //vergi = kazanc*15/100;
            }
            else if (kazanc <= 400000)
            {
                // 190 bin TL'nin %15'i 28.500 TL
                vergi = 28500 + (kazanc-190000) * 0.20;
            }
            else if (kazanc <= 1500000)
            {
                // 190 bin için 28.500 TL, 400 bin için 70.500
                vergi = 70500 + (kazanc-400000) * 0.27;
            }
            else if (kazanc <= 5300000)
            {
                //1500000 için 367500 
                vergi = 367500 + (kazanc-1500000) * 0.35;
            }else if (kazanc > 5300000)
            {
                vergi = 1697500 + (kazanc - 5300000) * 0.40;

            }
            Console.WriteLine("Vergi :"+vergi);

        }
    }
}
