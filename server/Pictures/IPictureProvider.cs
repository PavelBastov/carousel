using System.Collections.Generic;

namespace server.Pictures
{
    public interface IPictureProvider
    {
        List<PictureInfo> GetAll();
    }
}
