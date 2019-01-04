namespace MssNet
{
    public class MssClientSettings
    {
        public MssClientSettings(string user, string password, string source)
        {
            User = user;
            Password = password;
            Source = source;
        }

        public string User { get; private set; }
        public string Password { get; private set; }
        public string Source { get; private set; }
    }
}
