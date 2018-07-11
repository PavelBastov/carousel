using Nancy;

namespace server.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => Response.AsFile("static/index.html", "text/html");
        }
    }
}
