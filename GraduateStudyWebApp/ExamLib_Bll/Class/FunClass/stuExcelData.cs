using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

using System.Collections;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace ExamLib.BusinessLogicEx
{
    [Serializable]
    [DataContractAttribute]
    public class stuExcelData
    {

        /// <summary>
        /// Csv格式的Excel数据
        /// </summary>
        [DataMember]//非常重要
        public string Csv { get; set; }

       
        /// <summary>
        /// 用户Id
        /// </summary>        
        [DataMember]//非常重要
        public string UserId { get; set; }

        /// <summary>
        /// 年级Id
        /// </summary>        
        [DataMember]//非常重要
        public string QuestionTypeName { get; set; }
        /// <summary>
        /// 是否四舍五入
        /// </summary>        
        [DataMember]//非常重要
        public bool bolRound { get; set; }
        
    }
}
