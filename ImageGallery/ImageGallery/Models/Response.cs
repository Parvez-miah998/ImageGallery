namespace ImageGallery.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }

        public List<Images> listImages { get; set; }
        public Images image { get; set; }
    }
}
