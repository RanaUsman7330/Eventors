using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventors.MODELS
{
    class BookingsModel
    {
        [PrimaryKey, AutoIncrement]
        public int BookingID { get; set; }
        public int EventFID { get; set; }
        public int PlaceFID { get; set; }
        public int BookingsNoOfPeople { get; set; }
        public DateTime BookingsDate { get; set; }
        public TimeSpan BookingsTime { get; set; }
        public string BookingsOtherDetails { get; set; }
        public string BookingsStatus { get; set; }

    }
}
