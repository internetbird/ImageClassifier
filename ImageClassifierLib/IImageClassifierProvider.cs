using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageClassifierLib
{
    public interface IImageClassifierProvider
    {
        string[] GetImagesFilePaths();

    }
}
