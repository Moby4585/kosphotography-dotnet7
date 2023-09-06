using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Client;
using Vintagestory.Client.NoObf;
using Vintagestory.Client;
using Vintagestory.API.Config;
using Vintagestory.API.Common;
using Vintagestory.API.Server;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.MathTools;
using Vintagestory.API.Util;
using Vintagestory.GameContent;
using Vintagestory.API.Datastructures;
using System.Drawing;
using System.Drawing.Imaging;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using SkiaSharp;

namespace kosphotography
{
    public static class BitmapUtil
    {
        public static SKBitmap GrayscaleBitmapFromPixels(byte[] pixels, int width, int height)
        {
            SKBitmap bitmap = new SKBitmap(width, height);

            SKColor[] pixelsColor = new SKColor[pixels.Length];
            for (int i = 0; i < pixels.Length; i++)
            {
                int color = (int)pixels[i];
                pixelsColor[i] = SKColor.FromHsv(0, 0, ((float)color)/255f);
            }

            bitmap.Pixels = pixelsColor;

            return bitmap;
        }
    }
}
