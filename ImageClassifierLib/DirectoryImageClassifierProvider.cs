using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageClassifierLib
{
    public class DirectoryImageClassifierProvider : IImageClassifierProvider
    {
        private readonly string _imagesFolder;

        public DirectoryImageClassifierProvider(string imagesFolder)
        {
            _imagesFolder = imagesFolder;
        }

        public string[] GetImagesFilePaths()
        {
            if (string.IsNullOrWhiteSpace(_imagesFolder))
            {
                throw new MissingFieldException("Images Folder is not initialized");
            }

            string[] files = Directory.GetFiles(_imagesFolder);
            return files;
        }
    }
}
