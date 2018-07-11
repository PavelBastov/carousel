using System.Collections.Generic;

namespace server.Pictures
{
    public class LocalFilePictureProvider : IPictureProvider
    {
        private const int Count = 7;

        public List<PictureInfo> GetAll()
        {
            var result = new List<PictureInfo>();

            for (var i = 0; i < Count; i++)
            {
                var item = new PictureInfo();
                item.Id = i + 1;
                item.ContentType = "image/jpeg";
                item.Url = $"/img/picture{i + 1}.jpg";
                result.Add(item);
            }
            return result;
        }
    }
}
