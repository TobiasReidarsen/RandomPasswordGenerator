namespace RandomPasswordGenerator
{
    internal interface IPasswordStore
    {
        static abstract void StorePassword(string username, string password);
    }
}
