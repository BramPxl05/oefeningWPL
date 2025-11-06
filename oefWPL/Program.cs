namespace oefWPL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = "Uzui";
            string password = "Daddy";
            int tries = 0;

            while (tries < 3)
            {
                Console.Write("Naam: ");
                string userInput = Console.ReadLine();
                Console.Write("Wachtwoord: ");
                string passwordInput = Console.ReadLine();

                if (userInput == user && passwordInput == password)
                {
                    Console.WriteLine($"Welkom, {userInput}!");
                    return;
                }

                tries++;
                Console.WriteLine($"Foutieve login. {3 - tries} pogingen over.");
            }

            Console.WriteLine("Alle pogingen gebruikt, toegang geweigerd");
        }
    }
}
