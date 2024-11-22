using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace com.taishsoft.common
{
    /// <summary>
    /// 获取顶部对象列表的参数对象-Static
    /// </summary>
    public static class stuTopPara_Static
    {
        /// <summary>
        /// 根据获取顶部对象列表的参数对象获取相关的字典参数
        /// </summary>
        /// <param name="objTopPara">获取顶部对象列表的参数对象</param>
        /// <returns>获取的相关字典参数</returns>
        public static Dictionary<string, string> GetDictParam(this stuTopPara objTopPara)
        {
            //List<string> arrLst = new List<string>(objTopPara.exclude);
           
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strWhereCond"] = objTopPara.whereCond,
                ["strOrderBy"] = objTopPara.orderBy,
                ["intTopSize"] = objTopPara.topSize.ToString(),
                ["arrExclude"] = objTopPara.exclude,
                ["bolIsCheckSQLAttack"] = objTopPara.isCheckSQLAttack.ToString(),
            };
            return dictParam;
        }
    }
    /// <summary>
    /// 获取顶部对象列表的参数对象
    /// </summary>
    [Serializable]
    [DataContractAttribute]
    public class stuTopPara
    {
      
        /// <summary>
        /// 顶部记录数
        /// </summary>
        [DataMember]//非常重要
        public int topSize { get; set; }

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
        /// 排除的检查字符串列表
        /// </summary>
        [DataMember]//非常重要
        public string exclude { get; set; }

        /// <summary>
        /// 是否检查SQL攻击
        /// </summary>
        [DataMember]//非常重要
        public string isCheckSQLAttack { get; set; }

    }
}