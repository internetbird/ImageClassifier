using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageMetadataExtractor
{
    public class ImageMetadata
    {
        public string ProcessingSoftware { get; set; }
        public DateTime? TakenAt { get; set; }
        public GeoCoordinate Location { get; set; }

    }
}
