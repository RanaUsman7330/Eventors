using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventors.MODELS
{
    class PlacesModel
    {
        [PrimaryKey,AutoIncrement]
        public int PlaceID { get; set; }
        public string PlaceName { get; set; }
        public string PlaceCity { get; set; }
        public string PlaceAddress { get; set; }
        public string PlaceOwnerPhone { get; set; }
        public double PlaceLongitude { get; set; }
        public double PlaceLatitude { get; set; }
        public string PlaceImage1 { get; set; }
        public string PlaceImage2 { get; set; }
        public string PlaceImage3 { get; set; }
        public string PlaceImage4 { get; set; }
        public string PlaceDetail { get; set; }
        public string PlaceStatus { get; set; }
    }
}
