namespace RandomPasswordGenerator
{
    internal class PasswordStore : IPasswordStore
    {
        private static Dictionary<string, string> PasswordDicitonary { get; set; }

        public static void StorePassword(string username, string password)
        {
            //_passwordDicitonary = new Dictionary<string, string>();
            try
            {
                PasswordDicitonary.Add(username, password);
                Console.WriteLine($"Password: {password} with username: {username} added");

            }
            catch (ArgumentException)
            {
                throw new ArgumentException($"{username} already exists");
            }


        }

        public static string RetrievePassword(string username)
        {
            string value = "";
            if (PasswordDicitonary.TryGetValue(username, out value))
            {
                return $"Password for username: {username} is: {value}";
            }
            return $"Username not found";
        }

        static PasswordStore()
        {
            PasswordDicitonary = new Dictionary<string, string>();
        }
    }
}
