using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleReservation
{
    internal class ByteToImage
    {
        public byte[] data;
        public ByteToImage(byte[] image)
        {
            this.data = image;
        }

        public Image convert()
        {
            int maxW = 250;
            int maxH = 250;
            using (MemoryStream ms = new MemoryStream(this.data))
            {
                int newW, newH;

                Image image = Image.FromStream(ms);

                if (image.Width > image.Height)
                {
                    newW = maxW;
                    newH = (int)((float)image.Height / image.Width * maxW);
                }
                else
                {
                    newH = maxH;
                    newW = (int)((float)image.Width / image.Height * maxH);
                }

                image = image.GetThumbnailImage(newW, newH, null, IntPtr.Zero);
                return image;
            }
        }
    }
}
