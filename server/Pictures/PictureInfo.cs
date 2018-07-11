namespace server.Pictures
{
    public class PictureInfo
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public string ContentType { get; set; }

        public byte[] Content { get; set; }
    }
}
