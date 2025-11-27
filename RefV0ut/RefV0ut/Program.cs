namespace RefV0ut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ref vs Out");

            int first = 1;
            int second = 2;

            method1(out first, out second);
            method2(first,ref second);
            method3(ref first, second);

            Console.WriteLine($"first; {first}, second: {second}");
            Console.ReadLine();
        }

        static void method1(out int a, out int b) 
        {
            a = 2;
            b = 1;
        }


        static void method2(int a, ref int b)
        {
            a *= 5;
            b *= a;
        }

        static void method3(ref int a, int b)
        {
            a *= 5;
            b *= b;
        }
    }
}
