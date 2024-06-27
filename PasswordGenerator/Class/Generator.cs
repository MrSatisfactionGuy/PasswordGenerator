namespace PasswordGenerator.Class
{
    public class Generator
    {
        private static readonly Random rnd = new Random();
        private static string Buchstaben = "abcdefghijklmnopqrstuvwxyz";
        private static string BuchstabenUpper = Buchstaben.ToUpper();
        private static int Zahlen = 1234567890;
        private static string Zeichen = "!@#$%^&*()_+";

        static string combinedString = string.Format("{0}{1}{2}{3}", Buchstaben, BuchstabenUpper, Zahlen, Zeichen);

        public string GeneratePassword(int lange)
        {
            char[] password = new char[lange];
            for (int i = 0; i < lange; i++)
            {
                password[i] = combinedString[rnd.Next(combinedString.Length)];
            }

            return new string(password);
        }

    }
}
