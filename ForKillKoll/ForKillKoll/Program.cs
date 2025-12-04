namespace LoopKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kill Koll*");
            //teha vooskeem
            int arv = Convert.ToInt32(Console.ReadLine());  

            for (int i = 0; i < arv; i++)
            {
                Console.WriteLine("See on rida nr {0}", i);

                for (int j = 0; j < arv; j++)
                {
                    Console.WriteLine("Kill - koll");
                    
                }
                for (int k = 0; k < arv; k++)
                    {
                    Console.WriteLine("Killadi - koll");
                }
            }

}
}
}