namespace dizi_string_4_cumle_arama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cumle = "Pazardan 5 kg elma 3 kg çilek aldım";
            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] > '0' && cumle[i]<'9')
                    Console.WriteLine(cumle[i]);
            }
        }
    }
}
