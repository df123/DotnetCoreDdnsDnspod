using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetCoreDdnsDnspod.JsonData
{
    public class UserData
    {
        public string Token { get; set; }
        public string Domain { get; set; }
        public int IntervalTime { get; set; }
        public string GetIPUrl { get; set; }
    }
}
