namespace digitalClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "digital clock";
            Console.CursorVisible = false;

            while (true) ;
            {
                //puhastab konsooli akna
                Console.Clear();
                //võtab praeguse kellaaja ja vormindab selle kujule tunnid:minutid:sekundid
                string time = DateTime.Now.ToString("HH:mm:ss");
                //arvutab X-koordinaadi, et tekst oleks horisontaalselt keskel
                int x = (Console.WindowWidth - time.Length) / 2;
                //arvutab Y-koordinaadi (Vertikaalne keskkoht
                int y = Console.WindowHeight / 2;
                //seab kursori arvutatud asukohta
                Console.SetCursorPosition(x, y);
                //kuvab praeguse kellaaja konsoolis
                Console.Write(time);
                //peatab programmi töö 1 sekundiks
                Thread.Sleep(1000);
            }
        }
    }
}