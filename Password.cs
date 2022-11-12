namespace RandomPasswordGenerator
{
    internal class Password
    {
        private readonly string _username;
        private readonly string _password;

        private void SendToStore()
        {
            PasswordStore.StorePassword(_username, _password);
        }

        public Password(string username, string password)
        {
            _username = username;
            _password = password;
            SendToStore();
        }
    }
}
