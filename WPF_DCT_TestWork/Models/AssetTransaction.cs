using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_DCT_TestWork.Models
{
    public class AssetTransaction : DomainObject
    {
        public Account Account { get; set; }
        public bool IsPurchase { get; set; }
        public int Amount { get; set; }
        public DateTime DateProcessed { get; set; }
    }
}
