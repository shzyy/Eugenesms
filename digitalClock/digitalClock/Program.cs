namespace digitalClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "digital clock";
            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("digital Clock\n");
                Console.WriteLine(DateTime.Now.ToString("HH:mm: ss"));
                Thread.Sleep(1000);
            }
        }
    }
}
