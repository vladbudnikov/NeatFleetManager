﻿using NeatFleetManagement.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeatFleetManagement.Service
{
    public class CarServiceModel
    {
        public int CarId { get; set; }
        public CarColor Color { get; set; }
        public CarCondition Condition { get; set; } 
        public decimal Price { get; set; }
        public string OwnerId { get; set; }
    }
}
