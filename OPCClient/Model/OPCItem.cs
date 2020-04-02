using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCClient.Model
{
    /// <summary>
    /// OPC Item
    /// </summary>
    public class OPCItem
    {
        /// <summary>
        /// 变量名称
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 数值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public DateTime Time { get; set; }
    }
}
