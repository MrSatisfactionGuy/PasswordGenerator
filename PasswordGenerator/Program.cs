using PasswordGenerator.Class;

namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Passwort Generator***");
            Console.WriteLine("Bitte die Länge eingeben:");
            string laenge = Console.ReadLine();

            bool tryParseNum = false;

            if (tryParseNum == Int32.TryParse(laenge, out int exitLength)) Console.WriteLine("Bitte eine Zahl angeben!");
            Generator generator = new Generator();

            string password = generator.GeneratePassword(exitLength);
            Console.WriteLine(password);
            Console.ReadKey();
        }
    }
}
