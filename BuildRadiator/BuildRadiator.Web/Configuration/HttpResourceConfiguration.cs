namespace BuildRadiator.Web.Configuration
{
    public class HttpResourceConfiguration
    {
        private readonly string password;
        private readonly string url;
        private readonly string username;

        public HttpResourceConfiguration(string url, string username, string password)
        {
            this.url = url;
            this.username = username;
            this.password = password;
        }

        public string Url
        {
            get { return url; }
        }

        public string Username
        {
            get { return username; }
        }

        public string Password
        {
            get { return password; }
        }
    }
}