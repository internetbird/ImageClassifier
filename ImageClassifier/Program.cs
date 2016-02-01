using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ImageClassifier
{
    class Program
    {

        static void Main(string[] args)
        {
            Regex r = new Regex(":");
            int photoDatePropertyId = 36867;

            var directory = ConfigurationManager.AppSettings["ImagesFolder"];

            string[] files = Directory.GetFiles(directory);

            foreach (string file in files)
            {
               
                using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                using (Image myImage = Image.FromStream(fs, false, false))
                {
                    string dateTaken = "N\\A";

                    if (myImage.PropertyIdList.Contains(photoDatePropertyId))
                    {
                        PropertyItem propItem = myImage.GetPropertyItem(photoDatePropertyId);
                        dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                    }

                    Console.WriteLine($"{file} : {dateTaken}");
                }

            }

            Console.ReadKey();

        }
    }
}
