﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public bool IsActive { get; set; }
        public MemberShipType MemberShipType { get; set; }
    }
}