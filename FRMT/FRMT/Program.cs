namespace FRMT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Korrutustabel");

            int j, i, n;

            Console.WriteLine("sisesta tabelisse number, millest soovid alustada");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Korrutustabel ühest kun {0} ", n);
            Console.WriteLine("\n");

            for (i = 1; i <= n; i++) ;
            {
                for (j = 1; j <= n; j++)
                {
                    Console.WriteLine("{0}x{1} = {2},", j, i, i * j);
                }
            }
    
          
            
        }
    }
}
