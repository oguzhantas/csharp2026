namespace for_ic_ice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int ogrenciSayisi = 3;
            int dersSayisi = 5;
            for (i = 1; i <= ogrenciSayisi; i++)
            {
                Console.WriteLine("====");
                for(j=1;j<=dersSayisi; j++)  
                {
                    Console.WriteLine(i+". öğrenci,"+j+".ders");
                }
            }
        }
    }
}
