using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.lexicalAnalysis
{
    /// <summary>
    /// 环境状态
    /// </summary>
    public enum tzEnvirmentStatus
    {
        /// <summary>
        /// 代码常量
        /// </summary>
        CodeConst,
        /// <summary>
        /// 代码脚本
        /// </summary>
        CodeScript,
        Null
    }
    public enum tzWordType
    {
        /// <summary>
        /// 保留字
        /// </summary>
        ReserveWord,//
        /// <summary>
        /// 系统类型
        /// </summary>
        SystemType,//
        /// <summary>
        /// 系统变量
        /// </summary>
        SystemVariable,//
        /// <summary>
        /// 系统对象属性
        /// </summary>
        SystemObjectProperty,//
        /// <summary>
        /// 系统域名
        /// </summary>
        NameSpaces,//
        /// <summary>
        /// 上下文关键字
        /// </summary>
        ContextKeyword,//
        /// <summary>
        /// 操作符
        /// </summary>
        Operators,//
        /// <summary>
        /// 分隔符
        /// </summary>
        Delimiter,//
        /// <summary>
        /// Xml元素分隔符
        /// </summary>
        ElementDelimiter,//
        /// <summary>
        /// 用户类
        /// </summary>
        UserClass,//
        /// <summary>
        /// 属性
        /// </summary>
        Property,//
        /// <summary>
        /// 用户定义域名
        /// </summary>
        UDSpaceName,//
        /// <summary>
        /// 变量
        /// </summary>
        Variable,//
        /// <summary>
        /// 函数
        /// </summary>
        Function,//
        /// <summary>
        /// 标识符
        /// </summary>
        IDentifier,//
        /// <summary>
        /// 代码区域
        /// </summary>
        CodeRegion,//
        /// <summary>
        /// 常量
        /// </summary>
        Const,//常量
        /// <summary>
        /// 代码常量,可以直接输出到
        /// </summary>
        CodeConst,//代码常量,可以直接输出到
        /// <summary>
        /// 未知
        /// </summary>
        UnKnown,//
        Null//无效
    }
    public enum tzFirstCharType
    {
        /// <summary>
        /// 空格、回车等
        /// </summary>
        IsEmptyReturn,//空格回车等
        /// <summary>
        /// 
        /// </summary>
        IsLetter,//字母
        /// <summary>
        /// 
        /// </summary>
        IsDigit,//数字
        /// <summary>
        /// "/"
        /// </summary>
        Slash,// "/"
        /// <summary>
        /// 双引号
        /// </summary>
        DoubleQuotes,//双引号

        /// <summary>
        /// 单引号
        /// </summary>
        SingleQuotes,//单引号
        /// <summary>
        /// 字母$
        /// </summary>
        LetterDollar,//字母$
        /// <summary>
        /// 字母@
        /// </summary>
        LetterAt,//字母@
        /// <summary>
        /// 字母#
        /// </summary>
        HashSign,//字母#
        /// <summary>
        /// 分隔符、界符
        /// </summary>
        Delimiter, //分隔符、界符

        /// <summary>
        /// Xml标签开始符
        /// </summary>
        XmlTags_Start, //Xml标签开始符

        /// <summary>
        /// Xml标签结束符
        /// </summary>
        XmlTags_End, //Xml标签结束符

        /// <summary>
        /// 运算符
        /// </summary>
        Operators, //   运算符,
        /// <summary>
        /// 特殊运算符
        /// </summary>
        SpecialOperators, //   特殊运算符,
        /// <summary>
        /// 其他未处理字符
        /// </summary>
        Null
    }
    /// <summary>
    /// 
    /// </summary>
    public class clsPubClass4LexicalAnalysis
    {
        public static tzWordType GetWordTypeByString(string strWordType)
        {
            switch (strWordType)
            {
                case "ReserveWord":
                    return tzWordType.ReserveWord;
                case "SystemType":
                    return tzWordType.SystemType;
                case "SystemVariable":
                    return tzWordType.SystemVariable;
                case "NameSpaces":
                    return tzWordType.NameSpaces;
                case "ContextKeyword":
                    return tzWordType.ContextKeyword;
                case "Operators":
                    return tzWordType.Operators;
                case "Delimiter":
                    return tzWordType.Delimiter;
                case "UserClass":
                    return tzWordType.UserClass;
                case "UDSpaceName":
                    return tzWordType.UDSpaceName;
                case "Variable":
                    return tzWordType.Variable;
                case "Function":
                    return tzWordType.Function;
                case "CodeRegion":
                    return tzWordType.CodeRegion;
                case "Const":
                    return tzWordType.Const;
                case "CodeConst":
                    return tzWordType.CodeConst;
                case "UnKnown":
                    return tzWordType.UnKnown;

                default:
                    string strMsg = string.Format("提供的单词类型串：[{0}]不存在，无法处理！({1})", strWordType,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wtWordType"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string GetWordTypeStrByWordType(tzWordType wtWordType)
        {
            switch (wtWordType)
            {
                case tzWordType.ReserveWord:
                    return "ReserveWord";
                case tzWordType.SystemType:
                    return "SystemType";
                case tzWordType.SystemVariable:
                    return "SystemVariable";
                case tzWordType.NameSpaces:
                    return "NameSpaces";
                case tzWordType.ContextKeyword:
                    return "ContextKeyword";
                case tzWordType.Operators:
                    return "Operators";
                case tzWordType.Delimiter:
                    return "Delimiter";
                case tzWordType.UserClass:
                    return "UserClass";
                case tzWordType.UDSpaceName:
                    return "UDSpaceName";
                case tzWordType.Variable:
                    return "Variable";
                case tzWordType.Function:
                    return "Function";
                case tzWordType.CodeRegion:
                    return "CodeRegion";
                case tzWordType.Const:
                    return "Const";
                case tzWordType.CodeConst:
                    return "CodeConst";
                case tzWordType.UnKnown:
                    return "UnKnown";

                default:
                    string strMsg = string.Format("提供的单词类型：[{0}]不存在，无法处理！({1})", wtWordType,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wtWordType"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string GetWordTypeCHStrByWordType(tzWordType wtWordType)
        {
            switch (wtWordType)
            {
                case tzWordType.ReserveWord:
                    return "保留字";
                case tzWordType.SystemType:
                    return "系统类型";
                case tzWordType.SystemVariable:
                    return "系统变量";
                case tzWordType.SystemObjectProperty:
                    return "系统对象属性";
                case tzWordType.NameSpaces:
                    return "系统域名";
                case tzWordType.ContextKeyword:
                    return "上下文关键字";
                case tzWordType.Operators:
                    return "运算符";
                case tzWordType.Delimiter:
                    return "分界符";
                case tzWordType.UserClass:
                    return "用户类";
                case tzWordType.UDSpaceName:
                    return "用户域名";
                case tzWordType.Variable:
                    return "变量";
                case tzWordType.IDentifier:
                    return "标识符";
                case tzWordType.Function:
                    return "函数";
                case tzWordType.CodeRegion:
                    return "代码区域";
                case tzWordType.Const:
                    return "常量";
                case tzWordType.CodeConst:
                    return "代码常量";
                case tzWordType.UnKnown:
                    return "未知符";
                case tzWordType.ElementDelimiter:
                    return "Xml元素分隔符";

                default:
                    string strMsg = string.Format("提供的单词类型：[{0}]不存在，无法处理！({1})", wtWordType,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
        }
    }
}
