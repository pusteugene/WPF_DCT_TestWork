﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_DCT_TestWork.Models
{
    public class User : DomainObject
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DatedJoined { get; set; }
    }
}
