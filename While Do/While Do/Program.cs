namespace While_Do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while Do");

            int i = 1;

            do
            {
                Console.WriteLine(i);
                //i++ tahendab, et sama mis i = i + i
                i++;
            }
            while (i <= 10);
            //kui tuli nr 11, siis tingimus ei kehti enam ja tsükkel lõpeb
        }
    }
}
