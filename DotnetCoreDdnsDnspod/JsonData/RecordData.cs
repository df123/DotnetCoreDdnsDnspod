using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetCoreDdnsDnspod.JsonData
{
    public class RecordData
    {
        /// <summary>
        /// 
        /// </summary>
        public Status status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Domain domain { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Info info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<RecordsItem> records { get; set; }
    }

    public class Domain
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string punycode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string grade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string owner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ext_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ttl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> dnspod_ns { get; set; }
    }

    public class Info
    {
        /// <summary>
        /// 
        /// </summary>
        public string sub_domains { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string record_total { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string records_num { get; set; }
    }

    public class RecordsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 电信
        /// </summary>
        public string line { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string line_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ttl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string weight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string monitor_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string updated_on { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string use_aqb { get; set; }
    }
}
