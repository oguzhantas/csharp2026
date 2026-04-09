namespace RastgeleSayiUret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele=new Random();
            //Tamsayı üretir
            int s1 =rastgele.Next();

            //0 ile 1 arasında ondalık sayı üretir. 0 dahil 1 dahil değil
            double s2 = rastgele.NextDouble(); 
            
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            int s3 = rastgele.Next(1, 100); //1 dahil 100 dahil değil
            Console.WriteLine(s3);
        }
    }
}
