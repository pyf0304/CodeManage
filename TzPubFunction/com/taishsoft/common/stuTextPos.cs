using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace com.taishsoft.common
{
    /// <summary>
    /// 文本位置（Line, Col）对象-Static
    /// </summary>
    public static class stuTextPos_Static
    {
        /// <summary>
        /// 根据记录范围获取记录的参数对象获取相关的字典参数
        /// </summary>
        /// <param name="objTextPos">根据范围获取记录的参数对象</param>
        /// <returns>获取的相关字典参数</returns>
        public static Dictionary<string, string> GetDictParam(this stuTextPos objTextPos)
        {
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {         
                ["intLine"] = objTextPos.Line.ToString(),
                ["intCol"] = objTextPos.Col.ToString()
            };
            return dictParam;
        }
    }
    /// <summary>
    /// 文本位置（Line, Col）对象
    /// </summary>
    [Serializable]
    [DataContractAttribute]
    public class stuTextPos
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="intLine"></param>
        /// <param name="intCol"></param>
        public stuTextPos(int intLine, int intCol)
        {
            this.Line = intLine;
            this.Col = intCol;
        }
        /// <summary>
        /// 行
        /// </summary>
        [DataMember]//非常重要
        public int Line { get; set; }
        /// <summary>
        /// 列
        /// </summary>
        [DataMember]//非常重要
        public int Col { get; set; }

      


    }
}