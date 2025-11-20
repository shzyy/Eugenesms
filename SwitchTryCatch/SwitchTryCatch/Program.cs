namespace SwitchTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try Catch koos Switch-ga");


            //alguses teha switch kus saab sisestada numbreid 1 ja 2

            int input = int.Parse(Console.ReadLine());

            try
            { 

            switch (input)
            {
                case 1:
                    Console.WriteLine("sisestatud number 1");
                    break;

                    case 2:
                    Console.WriteLine("sisestatud number 2");
                    break;

                    default:
                    Console.WriteLine("Error");
                    break;
                }
            }
            catch (FormatException)
            { 
                Console.WriteLine("Palun sisesta kehtiv number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Sisestatud number in liiga suur või liiga väike");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Tekkis ootamatu viga:{ex.Message}");
            }
        }
    }

}
