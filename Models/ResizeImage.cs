using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace Models
{
    public class ResizeImage
    {
        public static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[input.Length];
            //byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        public static void ImageNoResize(byte[] data, string despath, long quality)
        {
            Stream stream = new MemoryStream(data);
            var sourceBitmap = new Bitmap(stream);
            var info = ImageCodecInfo.GetImageEncoders();
            var param = new EncoderParameters(1);
            param.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            sourceBitmap.Save(despath, info[1], param);
        }

        public static void ImageResize(byte[] data, string desPath, int thumbWidth, int thumbHeight, long quality)
        {
            Stream stream = new MemoryStream(data);
            var sourceBitmap = new Bitmap(stream);
            var thumbBitmap = new Bitmap(thumbWidth, thumbHeight);
            var g = Graphics.FromImage(thumbBitmap);
            try
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.FillRectangle(Brushes.White, 0, 0, thumbWidth, thumbHeight);
                g.DrawImage(sourceBitmap, 0, 0, thumbWidth, thumbHeight);

                var info = ImageCodecInfo.GetImageEncoders();
                var param = new EncoderParameters(1);
                param.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

                thumbBitmap.Save(desPath, info[1], param);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
               // logger.Error(ex);
            }
            finally
            {
                sourceBitmap.Dispose();
                thumbBitmap.Dispose();
                g.Dispose();
            }
        }

        public static byte[] SaveData(string file, int size, long quality)
        {
            var sourceBitmap = new Bitmap(file);

            var h = sourceBitmap.Height;
            var w = sourceBitmap.Width;

            var nw = 0;
            var nh = 0;
            if (w > h)
            {
                nh = size;
                nw = w * nh / h;
            }
            else
            {
                nw = size;
                nh = h * nw / w;
            }

            var thumbBitmap = new Bitmap(nw, nh);
            var g = Graphics.FromImage(thumbBitmap);
            try
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.FillRectangle(Brushes.White, 0, 0, nw, nh);
                g.DrawImage(sourceBitmap, 0, 0, nw, nh);

                var info = ImageCodecInfo.GetImageEncoders();
                var param = new EncoderParameters(1);
                param.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

                var ms = new MemoryStream();
                thumbBitmap.Save(ms, info[1], param);

                return ms.GetBuffer();
            }
            catch (Exception ex)
            {
              //  logger.Error(ex);
                return null;
            }
            finally
            {
                sourceBitmap.Dispose();
                thumbBitmap.Dispose();
                g.Dispose();
            }
        }

        public static void ImageCrop(byte[] data, string desPath, int width, int height, long quality)
        {
            Stream stream = new MemoryStream(data);
            Image imgPhoto = new Bitmap(stream);
            var sourceWidth = imgPhoto.Width;
            var sourceHeight = imgPhoto.Height;
            var destX = 0;
            var destY = 0;

            float nPercent;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = (width / (float)sourceWidth);
            nPercentH = (height / (float)sourceHeight);

            if (nPercentH < nPercentW)
            {
                nPercent = nPercentW;
                destY = (int)((height - (sourceHeight * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentH;
                destX = (int)((width - (sourceWidth * nPercent)) / 2);
            }

            var destWidth = (int)(sourceWidth * nPercent);
            var destHeight = (int)(sourceHeight * nPercent);

            if (nPercentH < nPercentW)
            {
                destWidth += 1;
            }
            else
            {
                destHeight += 1;
            }

            var bmPhoto = new Bitmap(width, height);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

            try
            {
                Graphics grPhoto = Graphics.FromImage(bmPhoto);
                grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
                grPhoto.DrawImage(imgPhoto,
                                  new Rectangle(destX, destY, destWidth, destHeight),
                                  new Rectangle(0, 0, sourceWidth, sourceHeight),
                                  GraphicsUnit.Pixel);

                var info = ImageCodecInfo.GetImageEncoders();
                var param = new EncoderParameters(1);
                param.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);

                bmPhoto.Save(desPath, info[1], param);
            }
            catch (Exception ex)
            {
                //logger.Error(ex);
            }
            finally
            {
                bmPhoto.Dispose();
                stream.Close();
                stream.Dispose();
                imgPhoto.Dispose();
            }
        }


        public static byte[] Crop(string fileImg, int width, int height, int x, int y)
        {
            using (var originalImage = Image.FromFile(fileImg))
            {
                using (var bmp = new Bitmap(width, height))
                {
                    bmp.SetResolution(originalImage.HorizontalResolution, originalImage.VerticalResolution);
                    using (var graphic = Graphics.FromImage(bmp))
                    {
                        graphic.SmoothingMode = SmoothingMode.AntiAlias;
                        graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        graphic.DrawImage(originalImage, new Rectangle(0, 0, width, height), x, y, width, height, GraphicsUnit.Pixel);
                        var ms = new MemoryStream();
                        bmp.Save(ms, originalImage.RawFormat);
                        return ms.GetBuffer();
                    }
                }
            }
        }

        public static void Process(byte[] data, string desPath, int width, int height, long quality, bool crop)
        {
            if (crop)
            {
                ImageCrop(data, desPath, width, height, quality);
            }
            else
            {
                ImageResize(data, desPath, width, height, quality);
            }
        }
    }
}