using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventors.MODELS
{
    public class UsersListModel
    {
        [PrimaryKey, AutoIncrement]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserImage { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserPhone { get; set; }
        public int UserCNIC { get; set; }
        public string UserFrontCNICImage { get; set; }
        public string UserBackCNICImage { get; set; }
        public double UserLongitude { get; set; }
        public double UserLatitude { get; set; }
        public double UserAddress { get; set; }
    }
}
