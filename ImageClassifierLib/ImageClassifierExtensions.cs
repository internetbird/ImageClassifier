using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageClassifierLib
{
    public static class ImageClassifierExtensions
    {
        public static bool IsImageFile(this string fileName)
        {
            fileName = fileName.ToLower();

            return fileName.EndsWith(".jpg") ||
                fileName.EndsWith(".jpeg") ||
                fileName.EndsWith(".png") ||
                fileName.EndsWith(".gif");
        }
    }
}