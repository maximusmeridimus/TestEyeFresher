using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace EyeFresher
{
    class PixelWork
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hwnd, IntPtr hDC);

        [DllImport("gdi32.dll")]
        public static extern uint GetPixel(IntPtr hDC, int x, int y);

        public static Color CalculateAverageColor()
        {
            Color averageColor = Color.Black;

            Random rand = new Random();
            uint averageR = 0;
            uint averageG = 0;
            uint averageB = 0;

            for (int i = 0; i < 100; i++)
            {
                int x = rand.Next(1920);
                int y = rand.Next(1080);

                IntPtr hDC = GetDC(IntPtr.Zero);
                uint pixel = GetPixel(hDC, x, y);
                ReleaseDC(IntPtr.Zero, hDC);

                averageR += pixel & 0x000000FF;
                averageG += (pixel & 0x0000FF00) >> 8;
                averageB += (pixel & 0x00FF0000) >> 16;
            }

            averageR = averageR / 100;
            averageG = averageG / 100;
            averageB = averageB / 100;

            averageColor = Color.FromArgb((int)averageR, (int)averageG, (int)averageB);
            return averageColor;
        }

        public static Color CalculateContrastColor(Color color)
        {
            return Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
        }


    }
}
