namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number");
            //loeme kasutaja sisendit ja see peab olema float andmetüüp
            float firstNumber = float.Parse(Console.ReadLine());
            //Konsool kirjutab, et sisesta teine number
            //loeme kasutaja sisendit ja see peab olema float andmetüüp
            //mõlemal juhul tuleb float ära parsida
            Console.WriteLine("Sisesta teine number");
            float secondNumber = float.Parse(Console.ReadLine());

            //konsool kirjutab, et vali tehe: +, -, *, /
            Console.WriteLine("Vali tehe: +, -, *, /");
            string input = Console.ReadLine();
            //kasutate switch, et teha valik kasutaja sisendi põhjal
            switch (input)
            {
                case "+":
                    Console.WriteLine($"Tulemus: {firstNumber + secondNumber}");
                    break;
                case "-":
                    Console.WriteLine($"Tulemus: {firstNumber - secondNumber}");
                    break;
                case "*":
                    Console.WriteLine($"Tulemus: {firstNumber * secondNumber}");
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Nulliga jagamine ei ole lubatud");
                    }
                    else
                    {
                        Console.WriteLine($"Tulemus: {firstNumber / secondNumber}");
                    }
                    break;

                default:
                    Console.WriteLine("Tehe pole lubatud");
                    break;
            }
        }
    }
}