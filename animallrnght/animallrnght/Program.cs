namespace animallrnght
{
    internal class Program
    {
        static int NimePikkus(string loomanimi)
        {
            return loomanimi.Length;
        }

        static void Main()
        {
           
            string[] loomad = { "koer", "kass", "jänes", "sipelgasiil", "lendorav", "hakkas" };

            string pikimNimi = "";
            int maxPikkus = 0;

            
            foreach (string loom in loomad)
            {
                int pikkus = NimePikkus(loom);
                Console.WriteLine($"{loom} pikkus: {pikkus}");

                
                if (pikkus > maxPikkus)
                {
                    maxPikkus = pikkus;
                    pikimNimi = loom;
                }
            }

            
            Console.WriteLine($"\nKõige pikem loomanimi on: {pikimNimi}");
        }
    }    }