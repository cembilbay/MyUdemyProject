﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrate
{
    public class About
    {
        public int AboutId { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Content { get; set; }
        public string RoomCount { get; set; }
        public string StaffCount { get; set; }
        public string CustomerCount { get; set; }
    }
}
