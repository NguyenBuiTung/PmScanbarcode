﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmScan
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<BarcodeScan> BarcodeScans { get; set; }
    }
}
