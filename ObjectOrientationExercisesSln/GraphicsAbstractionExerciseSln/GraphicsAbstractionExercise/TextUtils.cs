using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAbstractionExercise
{
    internal class TextUtils
    {
        public static void DrawCenteredText(Graphics graphics, string text, Rectangle bounds)
        {
            using (Font font = new Font("Arial", 10))
            {
                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                graphics.DrawString(text, font, Brushes.White, bounds, format);
            }
        }
    }
}
