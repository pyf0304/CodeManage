using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace com.taishsoft.common
{
    /// <summary>
    /// 分页获取对象列表的参数对象-Static
    /// </summary>
    public static class stuPagerPara_Static
    {
        /// <summary>
        /// 根据分页获取记录的参数对象获取相关的字典参数
        /// </summary>
        /// <param name="objPagerPara">分页获取记录的参数对象</param>
        /// <returns>获取的相关字典参数</returns>
        public static Dictionary<string, string> GetDictParam(this stuPagerPara objPagerPara)
        {
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strWhereCond"] = objPagerPara.whereCond,
                ["strOrderBy"] = objPagerPara.orderBy,
                ["intPageIndex"] = objPagerPara.pageIndex.ToString(),
                ["intPageSize"] = objPagerPara.pageSize.ToString()
            };
            return dictParam;
        }
    }
    /// <summary>
    /// 分页获取对象列表的参数对象
    /// </summary>
    [Serializable]
    [DataContractAttribute]
    public class stuPagerPara
    {
        /// <summary>
        /// 页序号
        /// </summary>
        [DataMember]//非常重要
        public int pageIndex { get; set; }
        /// <summary>
        /// 每页记录数
        /// </summary>
        [DataMember]//非常重要
        public int pageSize { get; set; }

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
        /// <summary>
        /// 左连接
        /// </summary>
        [DataMember]//非常重要
        public string leftJoin { get; set; }


    }
}