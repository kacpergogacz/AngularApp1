namespace AngularApp1.Server.Models
{
    //Umożliwia korzystanie z zadeklarowanej w appsetting.json jwt_secret
    public class ApplicationSettings
    {
        public string JWT_Secret { get; set; } = "";
    }
}
