using ImageGenerator.Models;
using System.Text;

namespace ImageGenerator.Util
{
    public static class LinkBuilder
    {
        public static string BuildLink(Image image)
        {
            var sb = new StringBuilder("https://picsum.photos");

            if (image.HasId is true)
            {
                sb.Append($"/id/{image.ImageId}");
            }

            sb.Append($"/{image.Width}");

            if (image.Height is not null)
            {
                sb.Append($"/{image.Height}");
            }

            if (!string.IsNullOrEmpty(image.Extension))
            {
                sb.Append($".{image.Extension}");
            }

            if (image.Blur is true && image.Grayscale is true)
            {
                sb.Append("?grayscale&blur");

                if (image.BlurLevel > 0)
                {
                    sb.Append($"={image.BlurLevel}");
                }
            }
            else
            {
                if (image.Grayscale is true)
                {
                    sb.Append("?grayscale");
                }

                if (image.Blur is true)
                {
                    sb.Append("?blur");
                    if (image.BlurLevel > 0)
                    {
                        sb.Append($"={image.BlurLevel}");
                    }
                }
            }

            return sb.ToString();
        }
    }
}