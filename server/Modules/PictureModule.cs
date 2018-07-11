using Nancy;
using server.Pictures;

namespace server.Modules
{
    public class PictureModule : NancyModule
    {
        public PictureModule(IPictureProvider pictureProvider)
        {
            Get["/api/pictures"] = _ =>
            {
                return Response.AsJson(pictureProvider.GetAll());
            };
        }
    }
}
