using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;

namespace DotnetCoreDdnsDnspod
{
    public class GetIPImplement : IGetIP
    {
        public string GetIP(string url)
        {
            HttpClient httpClient = new HttpClient();
            string s =  httpClient.GetAsync("http://members.3322.org/dyndns/getip").Result.Content.ReadAsStringAsync().Result;
            Match match = Regex.Match(s, "[0-9]{0,3}[.]{1}[0-9]{0,3}[.]{1}[0-9]{0,3}[.]{1}[0-9]{0,3}");
            return match.Value;
        }
    }
}
