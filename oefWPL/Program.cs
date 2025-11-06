namespace oefWPL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = "Uzui";
            string password = "Daddy";

            Console.Write("Naam: ");
            string userInput = Console.ReadLine();
            Console.Write("Wachtwoord: ");
            string passwordInput = Console.ReadLine();

            if (userInput == user && passwordInput == password)
            {
                Console.WriteLine($"Welkom, {userInput}!");
                return;
            }
        }
    }
}
