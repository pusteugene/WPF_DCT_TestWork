﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_DCT_TestWork.Model
{
    public class Account
    {
        public int Id { get; set; }
        public User AccountHolder { get; set; }
        public double Balance { get; set; }
        public IEnumerable<AssetTransaction> AssetTransactions { get; set; }
    }
}
