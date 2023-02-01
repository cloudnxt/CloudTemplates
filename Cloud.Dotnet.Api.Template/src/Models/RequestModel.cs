namespace Cloud.Dotnet.Api.Template.Models
{
    public class RequestModel
    {

        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ValidDuration { get; set; }
    }
}