using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MyScripts
{
    internal class Tab_Bitmaper
    {
        public List<BitImage> GetListboxItems(int count)
        {

            Random rand = new();

            List<BitImage> list_bitImages = new();

            var bitmap1 = new WriteableBitmap(140, 20, 96, 96, System.Windows.Media.PixelFormats.Bgr24, null);

            var w = bitmap1.PixelWidth;
            var h = bitmap1.PixelHeight;
            var stride = bitmap1.BackBufferStride;
            var pixelPtr = bitmap1.BackBuffer;

            var bitmap2 = new System.Drawing.Bitmap(w, h, stride, System.Drawing.Imaging.PixelFormat.Format24bppRgb, pixelPtr);

            for (int i = 0; i < count; i++)
            {
                bitmap1.Lock();
                using (var g = System.Drawing.Graphics.FromImage(bitmap2))
                {
                    g.DrawString(rand.Next(10000, 999999).ToString(), new Font("Tahoma", 15), System.Drawing.Brushes.White, 0, 0);
                }
                bitmap1.AddDirtyRect(new Int32Rect(0, 0, 140, 20));

                bitmap1.Unlock();
                list_bitImages.Add(new BitImage() { bitmapImage = bitmap1.Clone() });
                bitmap1.Clear();
            }

            return list_bitImages;

        }



        public class BitImage
        {
            public ImageSource bitmapImage { get; set; }
        }



    }

}
