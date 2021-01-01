using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventors.MODELS
{
    class EventsModel
    {
        [PrimaryKey, AutoIncrement]
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string EventImage { get; set; }
        public string EventDetail { get; set; }
        public string EventStatus { get; set; }
    }
}
