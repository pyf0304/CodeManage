using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace com.taishsoft.common
{
    /// <summary>
    /// 文本位置范围(start-line, start-col, end-line, end-col)的参数对象-Static
    /// </summary>
    public static class stuTextRange_Static
    {
        /// <summary>
        /// 根据记录范围获取记录的参数对象获取相关的字典参数
        /// </summary>
        /// <param name="objTextRange">根据范围获取记录的参数对象</param>
        /// <returns>获取的相关字典参数</returns>
        public static Dictionary<string, string> GetDictParam(this stuTextRange objTextRange)
        {
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["intStartLine"] = objTextRange.StartPos.Line.ToString(),
                ["intStartCol"] = objTextRange.StartPos.Col.ToString(),
                ["intEndLine"] = objTextRange.EndPos.Line.ToString(),
                ["intEndCol"] = objTextRange.EndPos.Col.ToString(),
            };
            return dictParam;
        }
    }
    /// <summary>
    /// 文本位置范围(start-line, start-col, end-line, end-col)的对象
    /// </summary>
    [Serializable]
    [DataContractAttribute]
    public class stuTextRange
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="objStartPos"></param>
        /// <param name="objEndPos"></param>
        public stuTextRange(stuTextPos objStartPos, stuTextPos objEndPos)
        {
            this.StartPos = objStartPos;
            this.EndPos = objEndPos;
        }
        /// <summary>
        /// 开始位置
        /// </summary>
        [DataMember]//非常重要
        public stuTextPos StartPos { get; set; }
        /// <summary>
        /// 结束位置
        /// </summary>
        [DataMember]//非常重要
        public stuTextPos EndPos { get; set; }



    }
}