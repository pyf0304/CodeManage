using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace com.taishsoft.common
{
    /// <summary>
    /// 专门用于记录排序操作传递参数的数据结构
    /// </summary>
    [Serializable]
    [DataContractAttribute]
    public class clsOrderByData
    {
        /// <summary>
        /// 需要移动记录的关键字列表
        /// </summary>
        [DataMember]//非常重要
        public string[] KeyIdLst { get; set; }

        /// <summary>
        /// 分类字段值
        /// </summary>
        [DataMember]//非常重要
        public string ClassificationFieldValue { get; set; }
        /// <summary>
        /// 分类字段值2
        /// </summary>
        [DataMember]//非常重要
        public string ClassificationFieldValue2 { get; set; }
        /// <summary>
        /// 分类字段值列表
        /// </summary>
        [DataMember]//非常重要
        public string ClassificationFieldValueLst { get; set; }

    }
}