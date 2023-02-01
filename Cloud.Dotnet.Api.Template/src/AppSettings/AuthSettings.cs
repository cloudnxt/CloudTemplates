namespace Cloud.Dotnet.Api.Template.AppSettings
{
    public class AuthSettings
    {

        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ValidDuration { get; set; }
    }
}