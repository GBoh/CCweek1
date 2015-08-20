using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

namespace CreateBitmap
{
    class Program
    {

        static void Main(string[] args)
        {

            // create bitmap
            var bitmap = new Bitmap(500, 500);

            // randomly set 1000 pixels
            var rnd = new Random();
            var rndColor = new Random();
            for (var i = 0; i < 5000000; i++)
            {
                if (rndColor.NextDouble() > .8)
                {
                    bitmap.SetPixel(rnd.Next(500), rnd.Next(500), Color.Salmon);
                }
                if (rndColor.NextDouble() > .6)
                {
                    bitmap.SetPixel(rnd.Next(500), rnd.Next(500), Color.LightSeaGreen);
                }
                if (rndColor.NextDouble() > .4)
                {
                    bitmap.SetPixel(rnd.Next(500), rnd.Next(500), Color.CornflowerBlue);
                }
                else
                {
                    bitmap.SetPixel(rnd.Next(500), rnd.Next(500), Color.LightGoldenrodYellow);
                }

            }

            // save bitmap to current directory (debug directory)
            var currentDirectory = Environment.CurrentDirectory;
            var path = Path.Combine(currentDirectory, "MyImage.png");
            bitmap.Save(path, ImageFormat.Png);
        }
    }
}
