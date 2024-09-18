using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmScan
{
    public class BarcodeScan
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public DateTime ScanTime { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
