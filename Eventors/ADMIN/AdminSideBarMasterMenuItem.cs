﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventors.ADMIN
{
    public class AdminSideBarMasterMenuItem
    {
        public AdminSideBarMasterMenuItem()
        {
            TargetType = typeof(AdminSideBarMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}