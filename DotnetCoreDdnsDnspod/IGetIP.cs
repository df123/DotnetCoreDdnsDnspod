using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetCoreDdnsDnspod
{
    public interface IGetIP
    {
        /// <summary>
        /// 获取IP地址
        /// </summary>
        /// <param name="url">获取ip地址的网站</param>
        /// <returns>返回获取的ip地址</returns>
        public string GetIP(string url);
    }
}
