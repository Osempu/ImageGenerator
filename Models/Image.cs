namespace ImageGenerator.Models
{
    public class Image
    {
        public string Width { get; set; }
        public string Height { get; set; }
        public bool HasId { get; set; }
        public int ImageId { get; set; }
        public bool Grayscale { get; set; }
        public bool Blur { get; set; }
        public int BlurLevel { get; set; }
        public string Extension { get; set; }
    }
}