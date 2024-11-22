using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace com.taishsoft.common
{
    /// <summary>
    /// 根据记录序号范围获取对象列表的参数对象-Static
    /// </summary>
    public static class stuRangePara_Static
    {
        /// <summary>
        /// 根据记录范围获取记录的参数对象获取相关的字典参数
        /// </summary>
        /// <param name="objRangePara">根据范围获取记录的参数对象</param>
        /// <returns>获取的相关字典参数</returns>
        public static Dictionary<string, string> GetDictParam(this stuRangePara objRangePara)
        {
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strWhereCond"] = objRangePara.whereCond,
                ["strOrderBy"] = objRangePara.orderBy,
                ["intMinNum"] = objRangePara.minNum.ToString(),
                ["intMaxNum"] = objRangePara.maxNum.ToString()
            };
            return dictParam;
        }
    }
    /// <summary>
    /// 根据记录序号范围获取对象列表的参数对象
    /// </summary>
    [Serializable]
    [DataContractAttribute]
    public class stuRangePara
    {
        /// <summary>
        /// 记录范围的最小记录号
        /// </summary>
        [DataMember]//非常重要
        public int minNum { get; set; }
        /// <summary>
        /// 记录范围的最大记录号
        /// </summary>
        [DataMember]//非常重要
        public int maxNum { get; set; }

        /// <summary>
        /// 条件串
        /// </summary>
        [DataMember]//非常重要
        public string whereCond { get; set; }
        /// <summary>
        /// 排序表达式
        /// </summary>
        [DataMember]//非常重要
        public string orderBy { get; set; }


    }
}