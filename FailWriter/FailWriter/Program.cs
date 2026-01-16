namespace FailWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta faili läbi konsooli");

            string filepath = @"C:/Users/opilane/Desktop/cheshki.txt";
            string inputText = Console.ReadLine();

            File.WriteAllText(filepath, inputText);
        }
    }
}
