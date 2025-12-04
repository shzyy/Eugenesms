namespace ForLoopEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop Endless");
            ushort i = 0;


            for (; ; )
            {
                Console.WriteLine("Number " + i);
                i++;


                if (i == 11)
                {
                    break;
                }



            }
        }
    }
}