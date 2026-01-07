namespace ForLoopArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();
            creator.CreateArray();

            Console.ReadLine();
        }

        // Внутренний класс
        class Creator
        {
            public void CreateArray()
            {
                string word = "Hello";
                string[] array = new string[word.Length];

                // Используем цикл
                for (int i = 0; i < word.Length; i++)
                {
                    array[i] = word[i].ToString();
                }

                // Вывод массива
                foreach (string s in array)
                {
                    Console.Write(s + " ");
                }
            }
        }
    }
}