//-----------------------------------------------------------------------
// <copyright file="Encrypter.cs" company="Freelancer">
// Copyright (c) Ilian Stoyanov. All rights reserved.
// </copyright>
// <author>Ilian Stoyanov</author>
//-----------------------------------------------------------------------

namespace ProjectX
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Resources;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;

    class Encrypter
    {
        private static byte[] key;
        private static int keyL;

        static Encrypter()
        {
            string path = Directory.GetCurrentDirectory().Replace("bin\\Debug", "").Replace("bin\\Release", "");
            Bitmap noise = new Bitmap(path + "noise.png");
            var noiseData = noise.LockBits(
                                            new Rectangle(0, 0, noise.Width, noise.Height),
                                            ImageLockMode.ReadOnly,
                                            PixelFormat.Format32bppArgb);
            keyL = Math.Abs(noiseData.Stride) * noise.Height;
            key = new byte[keyL];
            Marshal.Copy(noiseData.Scan0, key, 0, keyL);
        }

        public void EncryptFile(string dir)
        {
            AddNoise(dir);
        }

        public string DecryptFile(string dir)
        {
            return RemoveNoise(dir);
        }

        public void EncryptFiles(string dir)
        {
            var filePaths = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories);

            Parallel.ForEach(filePaths, AddNoise);
        }

        private void AddNoise(string filePath)
        {
            var bmp = new Bitmap(filePath);
            var bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);

            var bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            var rgbValues = new byte[bytes];
            Marshal.Copy(bmpData.Scan0, rgbValues, 0, bytes);

            int r, g, b, a;
            int keyOffset = 0;

            for (var i = 0; i < bmp.Height; i++)
            {
                for (var j = 0; j < bmpData.Width; j++)
                {
                    b = (i * bmp.Width + j) * 4;
                    g = b + 1;
                    r = g + 1;
                    a = r + 1;

                    if (rgbValues[a] == 0) continue;

                    rgbValues[r] ^= key[keyOffset++ % keyL];
                    rgbValues[g] ^= key[keyOffset++ % keyL];
                    rgbValues[b] ^= key[keyOffset++ % keyL];
                }
            }

            Marshal.Copy(rgbValues, 0, bmpData.Scan0, bytes);

            bmp.UnlockBits(bmpData);
            bmp.Save(filePath + ".tmp", ImageFormat.Png);
            bmp.Dispose();

            File.Delete(filePath);
            File.Move(filePath + ".tmp", filePath);
        }

        private string RemoveNoise(string filePath)
        {
            string tempImage = System.Environment.GetEnvironmentVariable("TEMP") + "\\" + filePath.Split('\\').Last();

            if (File.Exists(tempImage))
            {
                tempImage = System.Environment.GetEnvironmentVariable("TEMP") + "\\" + Guid.NewGuid() + filePath.Split('\\').Last();
            }

            var bmp = new Bitmap(filePath);
            var bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);

            var bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            var rgbValues = new byte[bytes];
            Marshal.Copy(bmpData.Scan0, rgbValues, 0, bytes);

            int r, g, b, a;
            int keyOffset = 0;

            for (var i = 0; i < bmp.Height; i++)
            {
                for (var j = 0; j < bmpData.Width; j++)
                {
                    b = (i * bmp.Width + j) * 4;
                    g = b + 1;
                    r = g + 1;
                    a = r + 1;

                    if (rgbValues[a] == 0) continue;

                    rgbValues[r] ^= key[keyOffset++ % keyL];
                    rgbValues[g] ^= key[keyOffset++ % keyL];
                    rgbValues[b] ^= key[keyOffset++ % keyL];
                }
            }

            Marshal.Copy(rgbValues, 0, bmpData.Scan0, bytes);

            bmp.UnlockBits(bmpData);

            bmp.Save(tempImage, ImageFormat.Png);
            bmp.Dispose();

            return tempImage;
        }
    }
}
