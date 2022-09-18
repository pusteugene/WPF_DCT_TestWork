using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_DCT_TestWork.Model
{
    public class AssetTransaction
    {
        public int Id { get; set; }
        public Account Account { get; set; }
        public bool IsPurchase { get; set; }
        public int Amount { get; set; }
    }
}
