using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace Jk_Accounting_Software.Internal.Classes
{
    public static class IImageHandler
    {
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            Rectangle destRect = new Rectangle(0, 0, width, height);
            Bitmap destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            using (Graphics graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (ImageAttributes wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public static byte[] ConvertImageToByte(Image img)
        {
            byte[] array;
            ImageConverter converter = new ImageConverter();

            array = converter.ConvertTo(img, typeof(byte[])) as byte[];

            return array;
        }

        public static Image ConvertByteToImage(byte[] array)
        {
            Image img;
            MemoryStream stream = new MemoryStream(array);
            
            try
            {   
                img = Image.FromStream(stream);
            }
            finally
            {
                stream.Dispose();
            }

            return img;
        }
    }
}
