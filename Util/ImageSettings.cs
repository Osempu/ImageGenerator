using ImageGenerator.Models;

namespace ImageGenerator.Util
{
    public class ImageSettings
    {
        private Image image;

        public ImageSettings()
        {
            image = new Image();
        }

        public ImageSettings SetWidth(string width){
            image.Width = width;
            return this;
        }

        public ImageSettings SetHeight(string height){
            image.Height = height;
            return this;
        }

        public ImageSettings SetGrayscale(bool hasGrasyScale){
            image.Grayscale = hasGrasyScale;
            return this;
        }

        public ImageSettings SetBlur(bool hasBlur, int blurLevel = 0){
            image.Blur = hasBlur;
            image.BlurLevel = blurLevel;
            return this;
        }

        public ImageSettings SetImageId(bool hasId,int id){
            image.HasId = hasId;
            image.ImageId = id;
            return this;
        }

        public ImageSettings SetImageExtensions(string extension)
        {
            image.Extension = extension;
            return this;
        }

        public Image Build(){
            return image;
        }
    }
}