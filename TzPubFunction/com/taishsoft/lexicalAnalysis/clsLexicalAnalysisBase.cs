using com.taishsoft.common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.lexicalAnalysis
{
    public class clsLexicalAnalysisBase
    {
        protected Stack<char> stkMate = null;
        protected tzEnvirmentStatus esCurrStatus = tzEnvirmentStatus.CodeScript;
        protected char[] chResourceProject;
        protected bool mbolIsIgnoreCase = false;//是否忽略大小写
        protected int pProject = 0;
        protected int mintWordIndex = 0;
        protected int mintWordTotal = 0;
        protected int mintCodeLen = 0;
        protected int mintLineNo = 1;//行号
        protected int mintCharNo = 0;//行内字符序号
        protected int mintLastPos = -1;
        protected List<clsWord_LA> arrResultWord = new List<clsWord_LA>();

        //保留字
        protected List<string> arrReserveWord = null;
        //系统数据类型
        //private static string[] sstrSystemType ={"bool","byte","char","decimal",
        //    "double","float","int","interface","long","object",
        //    "sbyte", "short","string","struct", "uint","ulong","ushort","void", "Exception"};
        protected List<string> arrSystemType = null;//系统类型
        protected List<string> arrSystemVariableTbl = null;//系统变量
        protected List<string> arrSystemObjectProperty = null;//系统对象属性
        protected List<string> arrPropertyTbl = null;//属性
                                                     //        protected List<string> arrCodeConstTbl = null;//属性

        private static string[] NameSpaces = {"System","System.Collections",
            "System.Collections.Generic","System.IO","System.Text",
            "System.Collections.Generic",
            "Microsoft.Office.Interop","Word","Microsoft.Office.Interop.Word",
            "System.Reflection","com.taishsoft.common",
            "Microsoft.Office.Interop.Word","System.Data","System.Diagnostics",
            "com.taishsoft.datetime","System.Linq"};

        //上下文关键字用于提供代码中的特定含义，但它不是 C# 中的保留字。 某些上下文关键字（如 partial 和 where）在两个或更多个上下文中具有特殊含义。
        //添加
        //别名
        private static string[] ContextKeyword = {
     "ascending","descending","dynamic","from","get","global","group","into","join","let","orderby",
            "partial（类型）","partial（方法）","remove","select","set","value","var",
            "where（泛型类型约束）","where（查询子句）","yield"              };
        //private static string[] 运算符1 ={"*","/","%","+","-","<<",">>","<",">","<=",">=",
        //"==","!=","&","^","|","&&","||","?:","+=","-=","*=","/=","%=","&=","|=","^=",
        //"<<=",">>=","="};
        protected List<string> arrOperators = null;//操作符、运算符
        protected List<string> arrElementDelimiter = null;//Xml元素分隔符

        //private static string[] operators ={"*","/","%","+","-","<<",">>",
        //    "<",">","<=",">=",
        //"==","!=","&","^","|","&&","||","?", "?:","+=","-=","*=","/=","%=","&=","|=","^=",
        //"<<=",">>=","=","++","--"};
        private static string[] Delimiter = { ",", ";", ".", "'", "(", ")", ":", "[", "]", "{", "}", "/", "\"", "\'", "\\" };

        //分界符运算符表,根据需要可以自行增加//我去除：,"\?"
        private static string[] operatorOrDelimiter ={
"+","-","*","/","<","<=",">",">=","=","==",
"!=",";","(",")","^",",","\"","\'","#","&",
"&&","|","||","%","~","<<",">>","[","]","{",
"}","\\",".",":","!"
};

        private static string[] sstrElementDelimiter = { };
        //private static string[] 界符1 = { ",", ";", ".", "'", "(", ")", ":", "[", "]", "{", "}", "/" };
        private static List<string> arrUserClassTbl;//用户类
        private static string[] UDSpaceNameTbl;
        private static List<string> arrVariableTbl = null;//变量表
        private static List<string> arrFunctionTbl = null;//函数表
        private static List<string> arrUnknownTbl = null;//未知表
        private static List<string> arrRegionTbl = null;//区域表

        private static string[] IDentifierTbl;//标识符表
        private static string[] ConstTbl;
        //private static string[] 未知符号;
        private ArrayList temp = new ArrayList();


        private string mstrCode_In = "";
        private string[] msstrCodeLines = null;
        /// <summary>
        /// 输入需要分析的代码
        /// </summary>
        public string Code_In
        {
            get
            {
                return mstrCode_In;
            }

            set
            {
                mstrCode_In = value;
            }
        }
        /// <summary>
        /// 代码行
        /// </summary>
        public string[] CodeLines
        {
            get
            {
                return msstrCodeLines;
            }

            set
            {
                msstrCodeLines = value;
            }
        }

        public List<clsWord_LA> ResultWord
        {
            get
            {
                return arrResultWord;
            }

            set
            {
                arrResultWord = value;
            }
        }

        public clsLexicalAnalysisBase(string strCode_In)
        {
            this.mstrCode_In = strCode_In;
            this.chResourceProject = this.mstrCode_In.ToCharArray();
            this.mintCodeLen = this.chResourceProject.Length;
            pProject = 0;
            arrVariableTbl = new List<string>();
            arrUserClassTbl = new List<string>();
            arrFunctionTbl = new List<string>();
            arrRegionTbl = new List<string>();
            stkMate = new Stack<char>();
        }
        /// <summary>
        /// 查找字符编码在相关表中的位置
        /// </summary>
        /// <param name="objWord">词</param>
        /// <param name="sstrWord"></param>
        /// <returns></returns>
        public int fnSearch_Location(clsWord_LA objWord, string[] sstrWord) //查找字符编码
        {
            for (int i = 0; i < sstrWord.Length; i++)
            {
                if (objWord.Word == sstrWord[i])
                    return i + 1;
            }
            return -1;
        }

        /// <summary>
        /// 查找字符编码在相关表中的位置
        /// </summary>
        /// <param name="objWord">词</param>
        /// <param name="sstrWord"></param>
        /// <returns></returns>
        public int fnSearch_Location(clsWord_LA objWord, List<string> sstrWord) //查找字符编码
        {
            for (int i = 0; i < sstrWord.Count; i++)
            {
                if (objWord.Word == sstrWord[i])
                    return i + 1;
            }
            return -1;
        }
        /// <summary>
        /// 插入新的标识符
        /// </summary>
        /// <param name="objWord"></param>
        /// <param name="sstrIDentifier">标识符表</param>
        /// <returns></returns>
        public int fnInsertId(clsWord_LA objWord, ref string[] sstrIDentifier)//标识符插入标识符表返回位置
        {
            temp.Clear();
            if (sstrIDentifier == null)
                temp.Add(objWord.Word);
            else
            {
                for (int i = 0; i < sstrIDentifier.Length; i++)
                    if (objWord.Word == sstrIDentifier[i])
                        return i;
                for (int j = 0; j < sstrIDentifier.Length; j++)
                {
                    temp.Add(sstrIDentifier[j]);
                }
                temp.Add(objWord.Word);
            }
            sstrIDentifier = (string[])temp.ToArray(typeof(string));
            return sstrIDentifier.Length - 1;
        }

        /// <summary>
        /// 插入新的标识符
        /// </summary>
        /// <param name="objWord"></param>
        /// <param name="sstrIDentifier">标识符表</param>
        /// <returns></returns>
        public int fnInsertId(clsWord_LA objWord, List<string> sstrIDentifier)//标识符插入标识符表返回位置
        {
            //temp.Clear();
            if (sstrIDentifier == null)
            {
                sstrIDentifier = new List<string>();
            }
            for (int i = 0; i < sstrIDentifier.Count; i++)
                if (objWord.Word == sstrIDentifier[i])
                    return i;
            //for (int j = 0; j < sstrIDentifier.Count; j++)
            //{
            //    temp.Add(sstrIDentifier[j]);
            //}
            sstrIDentifier.Add(objWord.Word);

            return sstrIDentifier.Count - 1;
        }

        /// <summary>
        /// 预处理
        /// </summary>
        /// <returns></returns>
        public virtual string fnPretreatment()       //预处理
        {
            string strCode_In = mstrCode_In;// textBox1.Text;
            string strCode_out = null;
            //去除换行和//注释
            string[] sstrLine = CodeLines;// textBox1.Lines;
            for (int i = 0; i < sstrLine.Length; i++)
            {
                if (sstrLine[i].Contains("//"))
                {
                    string[] strr = sstrLine[i].Split('/');
                    sstrLine[i] = strr[0];
                }
                else if (sstrLine[i].Contains("#region"))
                {
                    sstrLine[i] = "";
                }
                else if (sstrLine[i].Contains("#endregion"))
                {
                    sstrLine[i] = "";
                }
            }
            for (int i = 0; i < sstrLine.Length; i++)
            {
                //sstrLine[i] = sstrLine[i].Replace(";", " ;");
                //sstrLine[i] = sstrLine[i].Replace("(", " ( ");
                //sstrLine[i] = sstrLine[i].Replace(")", " ) ");

                strCode_out += sstrLine[i] + " ";
            }
            //去除跳格，回车
            if (strCode_out.Contains("/v"))
            {
                strCode_out = strCode_out.Replace("/v", " ");
            }
            if (strCode_out.Contains("/r"))
            {
                strCode_out = strCode_out.Replace("/r", " ");
            }
            if (strCode_out.Contains("/n"))
                strCode_out = strCode_out.Replace("/n", " ");
            if (strCode_out.Contains("/t"))
            {
                strCode_out = strCode_out.Replace("/t", " ");
            }
            //去除注释
            while (strCode_out.Contains("/*") && strCode_out.Contains("*/"))
            {
                strCode_out = strCode_out.Remove(strCode_out.IndexOf("/*"), strCode_out.IndexOf("*/") - strCode_out.IndexOf("/*") + 2);
            }
            //去除多余空格
            while (strCode_out.Contains("  "))
            {
                strCode_out = strCode_out.Replace("  ", " ");
            }
            return strCode_out;
        }
        /// <summary>
        /// 是否是操作符
        /// </summary>
        /// <param name="strWord"></param>
        /// <returns></returns>
        //protected bool IsOperator(string strWord)
        //{
        //    for (int i = 0; i < operators.Length; i++)
        //        if (strWord == operators[i])
        //            return true;
        //    return false;
        //}
        protected bool IsOperator(string strWord)
        {
            //for (int i = 0; i < operators.Length; i++)
            if (arrOperators.Contains(strWord) == true)
                return true;
            return false;
        }
        /// <summary>
        /// 是否是分隔符
        /// </summary>
        /// <param name="strWord">一个词</param>
        /// <returns></returns>
        protected bool IsCommunity_character(string strWord)
        {
            for (int i = 0; i < Delimiter.Length; i++)
                if (strWord == Delimiter[i])
                    return true;
            return false;
        }

        /// <summary>
        /// 词法分析
        /// </summary>
        /// <param name="strCode_In">输入的代码，分析前的代码</param>
        /// <param name="strCode_Out">输出的代码，已经分析后生成的代码</param>
        void analyze(string strCode_In, ref string strCode_Out)
        {

            string[] sstrWord1 = strCode_In.Split(new char[] { ' ' });
            List<clsWord_LA> arrResultWord = new List<clsWord_LA>();
            foreach (string strWord in sstrWord1)
            {
                clsWord_LA objWord_LA = new clsWord_LA(strWord);
                arrResultWord.Add(objWord_LA);
            }
            for (int i = 0; i < arrResultWord.Count - 1; i++)
            {
                clsWord_LA objWord_Curr = arrResultWord[i];
                tzWordType wtType;
                if (mbolIsIgnoreCase == false)
                {
                    wtType = fnJudgeType(objWord_Curr);
                }
                else
                {
                    wtType = fnJudgeTypeIgnoreCase(objWord_Curr);
                }
                if (wtType == tzWordType.UnKnown && i > 0)
                {
                    clsWord_LA objWord_Prev = arrResultWord[i - 1];
                    if (objWord_Prev.Word == "class")
                    {
                        objWord_Curr.WordType = "用户类";
                        wtType = tzWordType.UserClass;
                    }
                    else if (objWord_Prev.WordType == "保留字")
                    {
                        objWord_Curr.WordType = "标识符";
                        wtType = tzWordType.IDentifier;
                    }
                }
                switch (wtType)
                {
                    case tzWordType.ReserveWord:
                        strCode_Out += "( " + arrResultWord[i].Word + "," + "保留字," + fnSearch_Location(arrResultWord[i], arrReserveWord) + " )" + '\r' + '\n';
                        break;
                    case tzWordType.IDentifier:
                        strCode_Out += "( " + arrResultWord[i].Word + "," + "标识符," + fnInsertId(arrResultWord[i], ref IDentifierTbl) + " )" + '\r' + '\n';
                        break;
                    case tzWordType.Const:
                        strCode_Out += "( " + arrResultWord[i].Word + "," + "常数," + fnInsertId(arrResultWord[i], ref ConstTbl) + " )" + '\r' + '\n';
                        break;
                    case tzWordType.Operators:
                        strCode_Out += "( " + arrResultWord[i].Word + "," + "运算符," + fnSearch_Location(arrResultWord[i], arrOperators) + " )" + '\r' + '\n';
                        break;
                    case tzWordType.Delimiter:
                        strCode_Out += "( " + arrResultWord[i].Word + "," + "界符," + fnSearch_Location(arrResultWord[i], Delimiter) + " )" + '\r' + '\n';
                        break;
                    case tzWordType.UnKnown:
                        strCode_Out += "( " + arrResultWord[i].Word + "," + "未知符号," + fnInsertId(arrResultWord[i], arrUnknownTbl) + " )" + '\r' + '\n';
                        break;
                    case tzWordType.NameSpaces:
                        strCode_Out += "( " + arrResultWord[i].Word + "," + "域名," + fnSearch_Location(arrResultWord[i], NameSpaces) + " )" + '\r' + '\n';
                        break;
                    case tzWordType.UserClass:
                        strCode_Out += "( " + arrResultWord[i].Word + "," + "用户类," + fnInsertId(arrResultWord[i], arrUserClassTbl) + " )" + '\r' + '\n';
                        break;
                }
            }
        }

        protected void fnAddWordToList(string strWord)
        {
            clsWord_LA objWord_LA = new clsWord_LA(strWord);
            objWord_LA.Index = arrResultWord.Count;
            arrResultWord.Add(objWord_LA);
        }
        protected void fnAddWordToList(string strWord, string strWordType, tzWordType wtWordTypeId)
        {
            clsWord_LA objWord_LA = new clsWord_LA(strWord);
            objWord_LA.WordType = strWordType;
            objWord_LA.WordTypeId = wtWordTypeId;
            objWord_LA.Index = arrResultWord.Count;
            arrResultWord.Add(objWord_LA);
        }
        /// <summary>
        /// 前一个单词，排除无效的单词
        /// </summary>
        public clsWord_LA PrevWord
        {
            get
            {
                int intAddIndex = 1;
                while (true)
                {
                    if (mintWordIndex - intAddIndex < 0) return null;
                    if (arrResultWord[mintWordIndex - intAddIndex].InEffect == false)
                    {
                        intAddIndex++;
                        continue;
                    }

                    return arrResultWord[mintWordIndex - intAddIndex];
                }
            }
        }
        /// <summary>
        /// 前一个单词，排除无效的单词
        /// </summary>
        public static clsWord_LA GetPrevWord(List<clsWord_LA> arrObjLst, int intIndex)
        {
            if (intIndex - 1 < 0) return null;
            return arrObjLst[intIndex - 1];
        }
        /// <summary>
        /// 前一个单词，排除无效的单词
        /// </summary>
        public clsWord_LA CurrWord
        {
            get
            {
                while (true)
                {
                    if (mintWordIndex == -1) return null;
                    if (mintWordIndex >= arrResultWord.Count) return null;
                    clsWord_LA objWord_LA = arrResultWord[mintWordIndex];
                    if (objWord_LA.InEffect == false)
                    {
                        mintWordIndex++;
                        continue;
                    }

                    return arrResultWord[mintWordIndex];
                }
            }
        }

        /// <summary>
        /// 前一个单词，排除无效的单词
        /// </summary>
        public static clsWord_LA GetCurrWord(List<clsWord_LA> arrObjLst, int intIndex)
        {
            if (intIndex == -1) return null;
            if (intIndex >= arrObjLst.Count) return null;          
            return arrObjLst[intIndex];
        }
        /// <summary>
        /// 下一个单词，排除无效的单词
        /// </summary>
        public clsWord_LA NextWord
        {
            get
            {
                int intAddIndex = 1;
                while (true)
                {
                    if (mintWordIndex + intAddIndex >= arrResultWord.Count - 1) return null;

                    if (arrResultWord[mintWordIndex + intAddIndex].InEffect == false)
                    {
                        intAddIndex++;
                        continue;
                    }
                    return arrResultWord[mintWordIndex + intAddIndex];
                }
            }
        }

        /// <summary>
        /// 下一个单词，排除无效的单词
        /// </summary>
        public static clsWord_LA GetNextWord(List<clsWord_LA> arrObjLst, int intIndex)
        {
            if (intIndex + 1 >= arrObjLst.Count - 1) return null;
            return arrObjLst[intIndex + 1];
        }
        /// <summary>
        /// 词法分析
        /// </summary>
        /// <param name="strCode_In">输入的代码，分析前的代码</param>
        /// <param name="strCode_Out">输出的代码，已经分析后生成的代码</param>
        public string fnAnalyzeV3()
        {
            string strErrMsg = "";
            try
            {
                fnScanner();
            }
            catch (Exception objException)
            {
                strErrMsg = objException.Message;
                //throw new Exception(strErrMsg);
                //return;
            }
            //string[] sstrWord1 = strCode_In.Split(new char[] { ' ' });

            //List<clsWord_LA> arrResultWord = new List<clsWord_LA>();
            //foreach (string strWord in sstrWord1)
            //{
            //    clsWord_LA objWord_LA = new clsWord_LA(strWord);
            //    arrResultWord.Add(objWord_LA);
            //}
            mintWordIndex = 0;
            while (true)
            {
                if (CurrWord == null) break;
                //clsWord_LA objWord_Curr = arrResultWord[i];
                //if (objWord_Curr.InEffect == false) continue;
                //决定单词的类型
                DetermineTypeOfWord(CurrWord);
                //把单词插入到相关表中
                InsertWordToReleTab(CurrWord);
                mintWordIndex++;
            }
            return strErrMsg;
        }
        protected virtual void DetermineTypeOfWord(clsWord_LA objWord_Curr)
        {

            if (objWord_Curr.Word == ".")
            {


                if (PrevWord != null)
                {
                    switch (PrevWord.WordTypeId)
                    {
                        case tzWordType.NameSpaces:
                            if (NextWord != null)
                            {
                                string strWord_Temp = string.Format("{0}.{1}", PrevWord.Word, NextWord.Word);
                                clsWord_LA objWord_Temp = new clsWord_LA(strWord_Temp);
                                tzWordType wtType;
                                if (mbolIsIgnoreCase == false)
                                {
                                    wtType = fnJudgeType(objWord_Temp);
                                }
                                else
                                {
                                    wtType = fnJudgeTypeIgnoreCase(objWord_Temp);
                                }

                                switch (wtType)
                                {
                                    case tzWordType.NameSpaces://说明前后三个词可以合并
                                        PrevWord.Word = strWord_Temp;
                                        objWord_Curr.InEffect = false;
                                        NextWord.InEffect = false;
                                        return;

                                    case tzWordType.SystemType:
                                        PrevWord.Word = strWord_Temp;
                                        PrevWord.WordTypeId = tzWordType.SystemType;
                                        objWord_Curr.InEffect = false;
                                        NextWord.InEffect = false;
                                        return;

                                }
                            }
                            break;
                        case tzWordType.SystemVariable:
                            break;
                        default:
                            break;
                    }
                }
            }

            tzWordType intType;
            if (mbolIsIgnoreCase == false)
            {
                intType = fnJudgeType(objWord_Curr);
            }
            else
            {
                intType = fnJudgeTypeIgnoreCase(objWord_Curr);
            }

            switch (intType)
            {
                case tzWordType.UnKnown://未知符号                    
                case tzWordType.IDentifier://标识符
                    if (PrevWord == null) return;
                    switch (PrevWord.WordTypeId)
                    {
                        case tzWordType.SystemType:
                        case tzWordType.UserClass:
                            if (NextWord != null && NextWord.Word == "(")
                            {
                                objWord_Curr.WordType = "函数方法";
                                objWord_Curr.WordTypeId = tzWordType.Function;
                            }
                            else
                            {
                                objWord_Curr.WordType = "变量";
                                objWord_Curr.WordTypeId = tzWordType.Variable;
                            }
                            break;
                        case tzWordType.ReserveWord:
                            if (PrevWord.Word == "class")
                            {
                                objWord_Curr.WordType = "用户类";
                                objWord_Curr.WordTypeId = tzWordType.UserClass;
                            }
                            else if (PrevWord.Word == "namespace")
                            {
                                objWord_Curr.WordType = "用户定义域";
                                objWord_Curr.WordTypeId = tzWordType.UDSpaceName;
                            }
                            else
                            {
                                objWord_Curr.WordType = "标识符";
                                objWord_Curr.WordTypeId = tzWordType.IDentifier;
                            }
                            break;
                    }

                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// 把单词根据类型插入到相关表中
        /// </summary>
        protected virtual void InsertWordToReleTab(clsWord_LA objWord_Curr)
        {
            switch (objWord_Curr.WordTypeId)
            {
                case tzWordType.ReserveWord:

                    break;
                case tzWordType.IDentifier:
                    fnInsertId(objWord_Curr, ref IDentifierTbl);
                    break;
                case tzWordType.SystemObjectProperty:
                    break;
                case tzWordType.Const:
                    fnInsertId(objWord_Curr, ref ConstTbl);
                    break;
                case tzWordType.CodeConst:
                    //fnInsertId(arrResultWord[i], ref ConstTbl);
                    break;
                case tzWordType.Operators:
                    break;
                case tzWordType.Delimiter:
                    break;
                case tzWordType.UnKnown:
                    fnInsertId(objWord_Curr, arrUnknownTbl);
                    break;
                case tzWordType.NameSpaces:
                    fnSearch_Location(objWord_Curr, NameSpaces);
                    break;
                //case tzWordType 7:
                //    strCode_Out += "( " + arrResultWord[i].Word + "," + "未知," + InsertId(arrResultWord[i], arrUnknownTbl) + " )" + '\r' + '\n';
                //    break;
                case tzWordType.UserClass:
                    fnInsertId(objWord_Curr, arrUserClassTbl);
                    break;
                case tzWordType.UDSpaceName:
                    fnInsertId(objWord_Curr, ref UDSpaceNameTbl);
                    break;
                case tzWordType.SystemType:

                    break;
                case tzWordType.ElementDelimiter:

                    break;
                case tzWordType.SystemVariable:
                    break;
                case tzWordType.Variable://变量                      
                    fnInsertId(objWord_Curr, arrVariableTbl);
                    break;
                case tzWordType.Function://函数方法                       
                    fnInsertId(objWord_Curr, arrVariableTbl);
                    break;
                case tzWordType.CodeRegion://区域
                    fnInsertId(objWord_Curr, arrRegionTbl);
                    break;

                default:
                    string strMsg = string.Format("单词类型：[{0}]没有被处理！({1})",
                    clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }

        public string fnShowAllWordType()
        {
            StringBuilder sbCode_Out = new StringBuilder();
            for (int i = 0; i < arrResultWord.Count; i++)
            {
                clsWord_LA objWord_Curr = arrResultWord[i];
                if (objWord_Curr.InEffect == false) continue;
                tzWordType wtType = objWord_Curr.WordTypeId;
                switch (wtType)
                {
                    case tzWordType.ReserveWord:
                        sbCode_Out.AppendFormat("{3}. {0}, {1}, {2}\r\n",
                             arrResultWord[i].Word,
                         clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                             fnSearch_Location(arrResultWord[i], arrReserveWord),
                             objWord_Curr.Index);
                        break;
                    case tzWordType.IDentifier:
                        sbCode_Out.AppendFormat("{3}. {0}, {1}, {2})\r\n",
                            arrResultWord[i].Word,
                            clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                            fnInsertId(arrResultWord[i], ref IDentifierTbl),
                             objWord_Curr.Index);
                        break;
                    case tzWordType.SystemObjectProperty:
                        sbCode_Out.AppendFormat("{3}. {0}, {1}, {2})\r\n",
                            arrResultWord[i].Word,
                            clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                            fnSearch_Location(arrResultWord[i], arrSystemObjectProperty),
                             objWord_Curr.Index);
                        break;
                    case tzWordType.Const:
                        sbCode_Out.AppendFormat("{3}. {0}, {1}, {2})\r\n",
                           arrResultWord[i].Word,
                           clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                           fnInsertId(arrResultWord[i], ref ConstTbl),
                             objWord_Curr.Index);
                        break;
                    case tzWordType.CodeConst:
                        sbCode_Out.AppendFormat("{3}. {0}, {1}, {2})\r\n",
                           arrResultWord[i].Word,
                           clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                           0,
                             objWord_Curr.Index);
                        break;
                    case tzWordType.Operators:
                        sbCode_Out.AppendFormat("{3}. {0}, {1}, {2})\r\n",
                        arrResultWord[i].Word,
                        clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                        fnSearch_Location(arrResultWord[i], arrOperators),
                             objWord_Curr.Index);
                        break;
                    case tzWordType.Delimiter:
                        sbCode_Out.AppendFormat("{3}. {0}, {1}, {2})\r\n",
                        arrResultWord[i].Word,
                        clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                        fnSearch_Location(arrResultWord[i], Delimiter),
                             objWord_Curr.Index);
                        break;
                    case tzWordType.ElementDelimiter:
                        sbCode_Out.AppendFormat("{3}. {0}, {1}, {2})\r\n",
                        arrResultWord[i].Word,
                        clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                        fnSearch_Location(arrResultWord[i], Delimiter)
                        ,
                             objWord_Curr.Index);
                        break;
                    case tzWordType.UnKnown:
                        sbCode_Out.AppendFormat("{3}. {0}, {1}, {2})\r\n",
                        arrResultWord[i].Word,
                        clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                        fnInsertId(arrResultWord[i], arrUnknownTbl),
                             objWord_Curr.Index);
                        break;
                    case tzWordType.NameSpaces:
                        sbCode_Out.AppendFormat("{3}. {0}, {1}, {2})\r\n",
                        arrResultWord[i].Word,
                        clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                        fnSearch_Location(arrResultWord[i], NameSpaces),
                             objWord_Curr.Index);
                        break;
                    //case tzWordType 7:
                    //    strCode_Out += "( " + arrResultWord[i].Word + "," + "未知," + InsertId(arrResultWord[i], arrUnknownTbl) + " )" + '\r' + '\n';
                    //    break;
                    case tzWordType.UserClass:
                        sbCode_Out.AppendFormat("{3}. {0}, {1}, {2})\r\n",
                        arrResultWord[i].Word,
                        clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                        fnInsertId(arrResultWord[i], arrUserClassTbl),
                             objWord_Curr.Index);
                        break;
                    case tzWordType.UDSpaceName:
                        sbCode_Out.AppendFormat("{3}. {0}, {1}, {2})\r\n",
                        arrResultWord[i].Word,
                       clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                        fnInsertId(arrResultWord[i], ref UDSpaceNameTbl),
                             objWord_Curr.Index);
                        break;
                    case tzWordType.SystemType:
                        sbCode_Out.AppendFormat("{3}. {0}, {1}, {2})\r\n",
                        arrResultWord[i].Word,
                        clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                        fnSearch_Location(arrResultWord[i], arrSystemType),
                             objWord_Curr.Index);
                        break;
                    case tzWordType.SystemVariable:
                        sbCode_Out.AppendFormat("{3}. {0}, {1}, {2})\r\n",
                           arrResultWord[i].Word,
                          clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                          fnSearch_Location(arrResultWord[i], arrSystemVariableTbl),
                             objWord_Curr.Index);
                        break;
                    case tzWordType.Variable://变量
                        sbCode_Out.AppendFormat("{3}. {0}, {1}, {2})\r\n",
                        arrResultWord[i].Word,
                        clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                        fnInsertId(arrResultWord[i], arrVariableTbl),
                             objWord_Curr.Index);
                        break;
                    case tzWordType.Function://函数方法
                        sbCode_Out.AppendFormat("{3}. {0}, {1}, {2})\r\n",
                        arrResultWord[i].Word,
                        clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                        fnInsertId(arrResultWord[i], arrVariableTbl),
                             objWord_Curr.Index);
                        break;
                    case tzWordType.CodeRegion://区域
                        sbCode_Out.AppendFormat("{3}. {0}, {1}, {2})\r\n",
                        arrResultWord[i].Word,
                        clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                        fnInsertId(arrResultWord[i], arrRegionTbl),
                             objWord_Curr.Index);
                        break;

                    default:
                        string strMsg = string.Format("单词类型：[{0}]没有被处理！({1})",
                            clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            sbCode_Out.AppendFormat("共计:[{0}]行，[{1}]字符。", mintLineNo, pProject);
            return sbCode_Out.ToString();
        }
        /// <summary>
        /// 类型判断liexingpanduan
        /// </summary>
        /// <param name="strWord">分解后一个词</param>
        /// <returns></returns>
        protected virtual tzWordType fnJudgeType(clsWord_LA objWord)
        {
            if (objWord == null)
                return tzWordType.Null;
            if (string.IsNullOrEmpty(objWord.WordType) == false)
            {
                return objWord.WordTypeId;
            }
            char a = objWord.Word[0];
            //            str = str.TrimEnd(';');
            if (char.IsLetter(a))  //首个字符为字母，则可能为保留字/标识符，也可能是未知字符
            {
                int i = 0;
                if (arrSystemType.Contains(objWord.Word) == true)
                {
                    objWord.WordType = "系统类型";
                    objWord.WordTypeId = tzWordType.SystemType;
                    return tzWordType.SystemType;//保留字
                }
                if (arrSystemVariableTbl.Contains(objWord.Word) == true)
                {
                    objWord.WordType = "系统变量";
                    objWord.WordTypeId = tzWordType.SystemVariable;
                    return tzWordType.SystemVariable;
                }
                if (arrSystemObjectProperty.Contains(objWord.Word) == true)
                {
                    objWord.WordType = "系统对象属性";
                    objWord.WordTypeId = tzWordType.SystemObjectProperty;
                    return tzWordType.SystemObjectProperty;//系统对象属性
                }

                if (arrReserveWord.Contains(objWord.Word) == true)
                {
                    objWord.WordType = "保留字";
                    objWord.WordTypeId = tzWordType.ReserveWord;
                    return tzWordType.ReserveWord;//保留字
                }
                if (arrOperators.Contains(objWord.Word) == true)
                {
                    objWord.WordType = "运算符";
                    objWord.WordTypeId = tzWordType.Operators;
                    return tzWordType.Operators;//运算符
                }

                for (int k = 0; k < NameSpaces.Length; k++)
                    if (objWord.Word == NameSpaces[k])
                    {
                        objWord.WordType = "域名";
                        objWord.WordTypeId = tzWordType.NameSpaces;
                        return tzWordType.NameSpaces;//域名
                    }
                if (arrUserClassTbl != null)
                {
                    if (arrUserClassTbl.Contains(objWord.Word))
                    {
                        objWord.WordType = "用户类";
                        objWord.WordTypeId = tzWordType.UserClass;
                        return tzWordType.UserClass;//用户类
                    }
                }
                if (arrVariableTbl != null)
                {
                    if (arrVariableTbl.Contains(objWord.Word))
                    {
                        objWord.WordType = "变量";
                        objWord.WordTypeId = tzWordType.Variable;
                        return tzWordType.Variable;//用户类
                    }
                }

                if (UDSpaceNameTbl != null)
                {
                    for (int k = 0; k < UDSpaceNameTbl.Length; k++)
                        if (objWord.Word == UDSpaceNameTbl[k])
                        {
                            objWord.WordType = "用户定义域";
                            objWord.WordTypeId = tzWordType.UDSpaceName;
                            return tzWordType.UDSpaceName;//用户定义域
                        }
                }

                if (IDentifierTbl != null)
                {
                    for (int k = 0; k < IDentifierTbl.Length; k++)
                        if (objWord.Word == IDentifierTbl[k])
                        {
                            objWord.WordType = "标识符";
                            objWord.WordTypeId = tzWordType.IDentifier;
                            return tzWordType.IDentifier;//标识符
                        }
                }
                for (i = 0; i < objWord.Word.Length; i++)
                    if (char.IsLetterOrDigit(objWord.Word[i]) == false)
                    {
                        objWord.WordType = "未知符号";
                        objWord.WordTypeId = tzWordType.UnKnown;
                        return tzWordType.UnKnown;//未知符号
                    }
                if (i >= objWord.Word.Length)
                {
                    objWord.WordType = "未知";
                    objWord.WordTypeId = tzWordType.UnKnown;
                    return tzWordType.UnKnown;//未知   
                }
            }
            else if (char.IsDigit(a))//首个字符为数字，则可能为数字也可能为未知字符
            {
                int j = 0;
                for (j = 0; j < objWord.Word.Length; j++)
                    if (char.IsDigit(objWord.Word[j]) == false)
                    {
                        objWord.WordTypeId = tzWordType.UnKnown;
                        return tzWordType.UnKnown;//未知符号
                    }
                if (j >= objWord.Word.Length)
                {
                    objWord.WordTypeId = tzWordType.Const;
                    return tzWordType.Const; //常数
                }
            }
            else//首个字符不是字母/数字，则可能是运算符/界符或未知字符
            {
                if (IsOperator(objWord.Word))
                {
                    objWord.WordTypeId = tzWordType.Operators;
                    return tzWordType.Operators;//运算符
                }
                if (IsCommunity_character(objWord.Word))
                {
                    objWord.WordTypeId = tzWordType.Delimiter;
                    return tzWordType.Delimiter;//界符                 

                }
            }
            return tzWordType.IDentifier;
        }

        /// <summary>
        /// 类型判断liexingpanduan
        /// </summary>
        /// <param name="strWord">分解后一个词</param>
        /// <returns></returns>
        protected tzWordType fnJudgeTypeIgnoreCase(clsWord_LA objWord)
        {
            if (objWord == null)
                return tzWordType.Null;
            if (string.IsNullOrEmpty(objWord.WordType) == false)
            {
                return objWord.WordTypeId;
            }
            char a = objWord.Word[0];
            //            str = str.TrimEnd(';');
            if (char.IsLetter(a))  //首个字符为字母，则可能为保留字/标识符，也可能是未知字符
            {
                int i = 0;
                if (arrSystemType.Contains(objWord.Word.ToLower()) == true)
                {
                    objWord.WordType = "系统类型";
                    objWord.WordTypeId = tzWordType.SystemType;
                    return tzWordType.SystemType;//保留字
                }
                if (arrSystemVariableTbl.Contains(objWord.Word.ToLower()) == true)
                {
                    objWord.WordType = "系统变量";
                    objWord.WordTypeId = tzWordType.SystemVariable;
                    return tzWordType.SystemVariable;
                }
                if (arrSystemObjectProperty.Contains(objWord.Word.ToLower()) == true)
                {
                    objWord.WordType = "系统对象属性";
                    objWord.WordTypeId = tzWordType.SystemObjectProperty;
                    return tzWordType.SystemObjectProperty;//系统对象属性
                }

                if (arrReserveWord.Contains(objWord.Word.ToLower()) == true)
                {
                    objWord.WordType = "保留字";
                    objWord.WordTypeId = tzWordType.ReserveWord;
                    return tzWordType.ReserveWord;//保留字
                }
                if (arrOperators.Contains(objWord.Word.ToLower()) == true)
                {
                    objWord.WordType = "运算符";
                    objWord.WordTypeId = tzWordType.Operators;
                    return tzWordType.Operators;//运算符
                }

                for (int k = 0; k < NameSpaces.Length; k++)
                    if (objWord.Word == NameSpaces[k])
                    {
                        objWord.WordType = "域名";
                        objWord.WordTypeId = tzWordType.NameSpaces;
                        return tzWordType.NameSpaces;//域名
                    }
                if (arrUserClassTbl != null)
                {
                    if (arrUserClassTbl.Contains(objWord.Word.ToLower()))
                    {
                        objWord.WordType = "用户类";
                        objWord.WordTypeId = tzWordType.UserClass;
                        return tzWordType.UserClass;//用户类
                    }
                }
                if (arrVariableTbl != null)
                {
                    if (arrVariableTbl.Contains(objWord.Word.ToLower()))
                    {
                        objWord.WordType = "变量";
                        objWord.WordTypeId = tzWordType.Variable;
                        return tzWordType.Variable;//用户类
                    }
                }

                if (UDSpaceNameTbl != null)
                {
                    for (int k = 0; k < UDSpaceNameTbl.Length; k++)
                        if (objWord.Word == UDSpaceNameTbl[k])
                        {
                            objWord.WordType = "用户定义域";
                            objWord.WordTypeId = tzWordType.UDSpaceName;
                            return tzWordType.UDSpaceName;//用户定义域
                        }
                }

                if (IDentifierTbl != null)
                {
                    for (int k = 0; k < IDentifierTbl.Length; k++)
                        if (objWord.Word == IDentifierTbl[k])
                        {
                            objWord.WordType = "标识符";
                            objWord.WordTypeId = tzWordType.IDentifier;
                            return tzWordType.IDentifier;//标识符
                        }
                }
                for (i = 0; i < objWord.Word.Length; i++)
                    if (char.IsLetterOrDigit(objWord.Word[i]) == false)
                    {
                        objWord.WordType = "未知符号";
                        objWord.WordTypeId = tzWordType.UnKnown;
                        return tzWordType.UnKnown;//未知符号
                    }
                if (i >= objWord.Word.Length)
                {
                    objWord.WordType = "未知";
                    objWord.WordTypeId = tzWordType.UnKnown;
                    return tzWordType.UnKnown;//未知   
                }
            }
            else if (char.IsDigit(a))//首个字符为数字，则可能为数字也可能为未知字符
            {
                int j = 0;
                for (j = 0; j < objWord.Word.Length; j++)
                    if (char.IsDigit(objWord.Word[j]) == false)
                    {
                        objWord.WordTypeId = tzWordType.UnKnown;
                        return tzWordType.UnKnown;//未知符号
                    }
                if (j >= objWord.Word.Length)
                {
                    objWord.WordTypeId = tzWordType.Const;
                    return tzWordType.Const; //常数
                }
            }
            else//首个字符不是字母/数字，则可能是运算符/界符或未知字符
            {
                if (IsOperator(objWord.Word.ToLower()))
                {
                    objWord.WordTypeId = tzWordType.Operators;
                    return tzWordType.Operators;//运算符
                }
                if (IsCommunity_character(objWord.Word))
                {
                    objWord.WordTypeId = tzWordType.Delimiter;
                    return tzWordType.Delimiter;//界符                 

                }
            }
            return tzWordType.IDentifier;
        }

        /// <summary>
        /// 获取当前字符
        /// </summary>
        /// <returns></returns>
        protected char GetCurrChar()
        {

            char ch = chResourceProject[pProject];
            if (pProject == mintLastPos) return ch;
            mintLastPos = pProject;
            if (ch == '\r')
            {
                mintLineNo++;
                mintCharNo = 0;
            }
            else
            {
                mintCharNo++;
            }
            return ch;
        }
        /// <summary>
        /// 获取下一个字符
        /// </summary>
        /// <returns></returns>
        protected char GetNextChar()
        {
            if (pProject >= mintCodeLen - 1)
                return '\0';
            else
                return chResourceProject[pProject + 1];
        }
        /// <summary>
        /// 获取前一字符
        /// </summary>
        /// <returns></returns>
        protected char GetPrevChar()
        {
            if (pProject == 0)
                return '\0';
            else
                return chResourceProject[pProject - 1];
        }

        protected virtual void fnScanner()
        {//根据DFA的状态转换图设计
            char[] token = new char[100];
            char[] chStringConst = new char[10000];
            string strWord = "";
            //int syn = -1;

            //int i, count = 0;//count用来做token的指示器，收集有用字符
            char ch;//作为判断使用
            char char_Next;//作为判断使用

            string strMsg = "";
            while (true)
            {
                if (pProject >= mintCodeLen) break;
                ch = GetCurrChar();
                //count = 0;            
                if (esCurrStatus == tzEnvirmentStatus.CodeConst)
                {
                    fnAccessCodeConst();
                    continue;
                }
                tzFirstCharType fctFirstCharType = fnGetCharTypeByFirstChar(ch);
                switch (fctFirstCharType)
                {
                    case tzFirstCharType.IsEmptyReturn:

                        while (ch == ' ' || ch == '\n' || ch == '\r' || ch == '\t')
                        {//过滤空格，防止程序因识别不了空格而结束
                            pProject++;
                            if (pProject >= mintCodeLen) break;
                            ch = GetCurrChar();
                        }
                        break;
                    case tzFirstCharType.XmlTags_Start:// "/"
                        char_Next = GetNextChar();
                        switch (char_Next)
                        {
                            case '/':
                                fnAccessXmlElement_End(ch);
                                break;
                            default:
                                fnAccessXmlElement_Start(ch);
                                break;
                        }
                        break;
                    case tzFirstCharType.Slash:// "/"

                        char_Next = GetNextChar();
                        switch (char_Next)
                        {
                            case '/':
                                pProject++;
                                while (ch != '\n' && ch != '\r')
                                {//过滤//后面的注释
                                    pProject++;
                                    if (pProject >= mintCodeLen) break;
                                    ch = GetCurrChar();
                                }
                                pProject++;
                                ch = GetCurrChar();
                                if (ch == '\r' || ch == '\n')
                                {
                                    pProject++;
                                }
                                break;
                            case '*'://出现了"/*", 查找"*/",去除之间的部分
                                while (true)
                                {//过滤//后面的注释
                                    pProject++;
                                    if (pProject >= mintCodeLen) break;
                                    ch = GetCurrChar();

                                    char_Next = GetNextChar();
                                    if (ch == '*' && char_Next == '/')
                                    {
                                        //找到了"*/"
                                        pProject++;//这是"/"的位置
                                        pProject++;//这是下个字符的位置
                                        break;
                                    }
                                }

                                break;
                            case '=':
                                strWord = "/=";
                                fnAddWordToList(strWord, "操作符", tzWordType.Operators);
                                pProject++;
                                pProject++;
                                //int x = 5;
                                //x /= 3;
                                break;
                            default:
                                strWord = "/";
                                fnAddWordToList(strWord, "操作符", tzWordType.Operators);
                                pProject++;
                                break;
                        }
                        break;

                    case tzFirstCharType.IsLetter://首字符是字符
                        fnAccessFirstCharIsLetter(ch);
                        continue;
                    case tzFirstCharType.IsDigit://首字符是数字
                        fnAccessFirstCharIsDigit(ch);
                        continue;
                    case tzFirstCharType.DoubleQuotes://双引号"
                        if (fnAccessStringConst() == true)
                        {
                            continue;
                        }
                        continue;
                    case tzFirstCharType.SingleQuotes://单引号"
                        if (fnAccessStringConst4SingleQuote() == true)
                        {
                            continue;
                        }
                        continue;
                    case tzFirstCharType.LetterAt: //字符@
                        fnAccessLetterAt();
                        break;
                    case tzFirstCharType.LetterDollar: //字符$

                        token[0] = ch;
                        token[1] = GetNextChar();
                        token[2] = '\0';//形成单字符串
                        strWord = new string(token, 0, 2);
                        if (IsCommunity_character(strWord) == true
                            || IsOperator(strWord) == true)
                        {
                            fnAddWordToList(strWord);
                            pProject++;
                            pProject++;
                            continue;
                        }
                        token[1] = '\0';//形成单字符串
                        strWord = new String(token, 0, 1);
                        if (IsCommunity_character(strWord) == true
                            || IsOperator(strWord) == true)
                        {
                            fnAddWordToList(strWord);
                            pProject++;
                            continue;
                        }
                        pProject++;
                        continue;
                    case tzFirstCharType.HashSign://字母#
                        if (fnAccessRegion() == true)
                        {
                            continue;
                        }
                        continue;
                    case tzFirstCharType.Operators://操作符

                        token[0] = ch;
                        token[1] = GetNextChar();
                        token[2] = '\0';//形成单字符串
                        strWord = new string(token, 0, 2);
                        if (IsCommunity_character(strWord) == true
                            || IsOperator(strWord) == true)
                        {
                            fnAddWordToList(strWord);
                            pProject++;
                            pProject++;
                            continue;
                        }
                        token[1] = '\0';//形成单字符串
                        strWord = new String(token, 0, 1);
                        if (IsCommunity_character(strWord) == true
                            || IsOperator(strWord) == true)
                        {
                            fnAddWordToList(strWord);
                            pProject++;

                            continue;
                        }
                        break;
                    case tzFirstCharType.Delimiter://分隔符、界符
                        fnAccessDelimiter();
                        break;
                    case tzFirstCharType.SpecialOperators:

                        token[0] = ch;
                        token[1] = GetNextChar();
                        token[2] = '\0';//形成单字符串
                        strWord = new string(token, 0, 2);
                        if (IsCommunity_character(strWord) == true
                            || IsOperator(strWord) == true)
                        {
                            fnAddWordToList(strWord);
                            pProject++;
                            pProject++;
                            continue;
                        }
                        token[1] = '\0';//形成单字符串
                        strWord = new String(token, 0, 1);
                        if (IsCommunity_character(strWord) == true
                            || IsOperator(strWord) == true)
                        {
                            fnAddWordToList(strWord);
                            pProject++;

                            continue;
                        }

                        break;
                    default:
                        strMsg = string.Format("出错：字符[{4}]处分析出错。在行:[{0}].第:[{1}]，总第[{2}]个字符处。({3})",
                             mintLineNo, mintCharNo, pProject, clsStackTrace.GetCurrClassFunction(), ch);
                        Console.WriteLine(strMsg);
                        throw new Exception(strMsg);
                }
            }
            strWord = "#End";
            fnAddWordToList(strWord);
        }
        protected virtual tzFirstCharType fnGetCharTypeByFirstChar(char ch)
        {
            if (ch == ' ' || ch == '\n' || ch == '\r' || ch == '\t')
            {
                return tzFirstCharType.IsEmptyReturn;
            }
            else if (Char.IsLetter(ch) == true || ch == '_')
            {
                return tzFirstCharType.IsLetter;
            }
            else if (Char.IsDigit(ch))
            {
                return tzFirstCharType.IsDigit;
            }
            else if (ch == '/')
            {
                return tzFirstCharType.Slash;
            }
            else if (ch == '"')
            {
                return tzFirstCharType.DoubleQuotes;//双引号 '"'
            }
            else if (ch == '\'')
            {
                return tzFirstCharType.SingleQuotes;//双引号 '"'
            }
            else if (ch == '@')
            {
                return tzFirstCharType.LetterAt;
            }
            else if (ch == '$')
            {
                return tzFirstCharType.LetterDollar;
            }
            else if (ch == '#')
            {
                return tzFirstCharType.HashSign;
            }
            else if (ch == ';'
                || ch == '('
                || ch == ')'
                || ch == ','
                || ch == '\"'
                || ch == '\''
                || ch == '~'
                || ch == '#'
                || ch == '%'
                || ch == '['
                || ch == ']'
                || ch == '{'
                || ch == '}'
                || ch == '\\'
                || ch == '.'
                || ch == ':')
            {//若为运算符或者界符，查表得到结果////////|| ch == '\?'
                return tzFirstCharType.Delimiter;
            }
            else if (ch == '+'
                || ch == '-'
                || ch == '*'
                || ch == '/'
                || ch == '^'
                || ch == '?'
                || ch == '<'
                || ch == '>')
            {//若为运算符或者界符，查表得到结果////////|| ch == '\?'
                return tzFirstCharType.Operators;
            }
            if (ch == '='
             || ch == '|'
             || ch == '!'
             || ch == '&'

             || ch == '<'
             || ch == '>')
            {//=.==  //|,||  //!,!=  //&,&&
                return tzFirstCharType.SpecialOperators;
            }
            return tzFirstCharType.Null;
        }
        private int strcmp(char[] chSS, string strTT)
        {
            char[] chTT = strTT.ToCharArray();
            int iLenS = chSS.Length;
            int iLenT = chTT.Length;
            int iLen = iLenS > iLenT ? iLenT : iLenS;
            for (int i = 0; i < iLen; i++)
            {
                if (chTT[i] > chSS[i]) return 1;
                else if (chTT[i] < chSS[i]) return -1;
            }
            if (iLenT == iLenS) return 0;
            if (iLenS > iLenT) return 1;
            return -1;
        }
        private int searchReserve(string[] reserveWord, char[] s)
        {
            int iLen = reserveWord.Length;
            for (int i = 0; i < iLen; i++)
            {
                if (strcmp(s, reserveWord[i]) == 0)
                {//若成功查找，则返回种别码
                    return i + 1;//返回种别码
                }
            }
            return -1;//否则返回-1，代表查找不成功，即为标识符
        }

        /// <summary>
        /// 处理字符@
        /// </summary>
        /// <returns></returns>
        protected virtual bool fnAccessLetterAt()
        {
            char char_Next = GetNextChar();
            if (char_Next == '"')
            {
                if (fnAccessStringConst() == true)
                {
                    return true;
                }
            }
            else
            {
                string strMsg = string.Format("出错：[@]处出错。在行:[{0}].第:[{1}]处,总第[{2}]个字符处。({3})",
                    mintLineNo, mintCharNo, pProject, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return true;
        }

        protected bool fnAccessStringConst()
        {
            int count = 0;
            char[] chStringConst = new char[10000];

            char ch = GetCurrChar();
            if (ch == '@')
            {
                chStringConst[count++] = ch;//收集
                pProject++;//下移
                ch = GetCurrChar();
            }

            chStringConst[count++] = ch;//收集
            pProject++;//下移
            ch = GetCurrChar();
            bool bolIsHaveEscapedcharacters = false;
            while (true)
            {//后跟字母或数字
                char thisChar = ch;
                char prevChar = GetPrevChar();
                chStringConst[count++] = ch;//收集
                if (thisChar == '\\')
                {
                    if (bolIsHaveEscapedcharacters == false)
                    {
                        bolIsHaveEscapedcharacters = true;
                    }
                    else
                    {
                        bolIsHaveEscapedcharacters = false;
                    }
                }
                if (thisChar == '"')
                {
                    if (bolIsHaveEscapedcharacters == true)
                    {
                        pProject++;//下移
                        ch = GetCurrChar();
                        bolIsHaveEscapedcharacters = false;
                    }
                    else
                    {
                        pProject++;//下移                     
                        break;
                    }
                }
                pProject++;
                ch = GetCurrChar();
            }//多读了一个字符既是下次将要开始的指针位置
            chStringConst[count] = '\0';
            string strWord = new string(chStringConst, 0, count);
            fnAddWordToList(strWord, "常量", tzWordType.Const);
            return true;
        }
        /// <summary>
        /// 针对单引号的字符常量
        /// </summary>
        /// <returns></returns>
        protected bool fnAccessStringConst4SingleQuote()
        {
            int count = 0;
            int intPos4Escapedcharacters = 0;
            char[] chStringConst = new char[10000];

            char ch = GetCurrChar();
            if (ch == '@')
            {
                chStringConst[count++] = ch;//收集
                pProject++;//下移
                ch = GetCurrChar();
            }

            chStringConst[count++] = ch;//收集
            pProject++;//下移
            ch = GetCurrChar();
            bool bolIsHaveEscapedcharacters = false;
            while (true)
            {//后跟字母或数字
                char thisChar = ch;
                char prevChar = GetPrevChar();
                chStringConst[count++] = ch;//收集
                if (thisChar == '\\')
                {
                    if (bolIsHaveEscapedcharacters == false)
                    {
                        bolIsHaveEscapedcharacters = true;
                        intPos4Escapedcharacters = pProject;
                    }
                    else
                    {
                        bolIsHaveEscapedcharacters = false;
                    }
                }
                else
                {
                    if (bolIsHaveEscapedcharacters == true)
                    {

                    }
                }
                if (thisChar == '\'')
                {
                    if (bolIsHaveEscapedcharacters == true && intPos4Escapedcharacters == pProject-1)
                    {
                        pProject++;//下移
                        ch = GetCurrChar();
                        bolIsHaveEscapedcharacters = false;
                    }
                    else
                    {
                        pProject++;//下移                     
                        break;
                    }
                }
                pProject++;
                ch = GetCurrChar();
            }//多读了一个字符既是下次将要开始的指针位置
            chStringConst[count] = '\0';
            string strWord = new string(chStringConst, 0, count);
            fnAddWordToList(strWord, "常量", tzWordType.Const);
            return true;
        }
        protected bool fnAccessRegion()
        {
            int count = 0;
            char[] chStringConst = new char[1000];
            char[] token = new char[100];
            char ch = GetCurrChar();
            token[count++] = ch;//收集
            pProject++;//下移
            ch = GetCurrChar();
            while (ch != ' ' && ch != '\r')
            {
                token[count++] = ch;
                pProject++;//下移
                ch = GetCurrChar();
            }
            string strWord = new String(token, 0, count);
            fnAddWordToList(strWord, "代码区域", tzWordType.CodeRegion);
            //去除中间的空格
            while (ch == ' ')
            {
                pProject++;//下移
                ch = GetCurrChar();
            }
            char nextChar = GetNextChar();
            if (ch == '\r' && nextChar == '\n')
            {
                return true;
            }

            count = 0;
            chStringConst[count++] = ch;
            pProject++;
            ch = GetCurrChar();
            char prevChar = GetPrevChar();
            while (true)
            {//后跟字母或数字

                //"\r\n"
                if (ch == '\n' && prevChar == '\r')
                {
                    pProject++;
                    break;
                }
                chStringConst[count++] = ch;//收集

                //if (thisChar == '\n')
                //{
                //    string ss = "";
                //}
                //if (thisChar == '\r')
                //{
                //    string ss1 = "";
                //}
                if (count >= 999)
                {
                    string strMsg = string.Format("出错：[#]处出错。在行:[{0}].第:[{1}]字符, 总第:[{2}]处。({2})",
                         mintLineNo, mintCharNo, pProject, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                pProject++;
                ch = GetCurrChar();
                prevChar = GetPrevChar();
            }//多读了一个字符既是下次将要开始的指针位置
            chStringConst[count] = '\0';
            strWord = new string(chStringConst, 0, count);
            fnAddWordToList(strWord, "常量", tzWordType.Const);
            return true;
        }
        protected virtual void fnAccessFirstCharIsLetter(char chCurrChar)
        {
            char ch;
            char[] token = new char[100];
            int i, count = 0;//count用来做token的指示器，收集有用字符

            token[count++] = chCurrChar;//收集
            pProject++;//下移
            ch = GetCurrChar();
            while (Char.IsLetter(ch)
                || Char.IsDigit(ch)
                //|| resourceProject[pProject] == '.'
                || ch == '_')
            {//后跟字母或数字
                token[count++] = ch;//收集
                pProject++;//下移
                if (pProject >= mintCodeLen) break;
                ch = GetCurrChar();
            }//多读了一个字符既是下次将要开始的指针位置
            token[count] = '\0';
            string strWord = new string(token, 0, count);
            fnAddWordToList(strWord);
        }

        protected virtual void fnAccessXmlElement_End(char chCurrChar)
        {
            char ch;
            char[] token = new char[100];
            int i, count = 0;//count用来做token的指示器，收集有用字符

            token[count++] = chCurrChar;//收集
            pProject++;//下移
            ch = GetCurrChar();
            while (Char.IsLetter(ch)
                || Char.IsDigit(ch)
                //|| resourceProject[pProject] == '.'
                || ch == '_')
            {//后跟字母或数字
                token[count++] = ch;//收集
                pProject++;//下移
                if (pProject >= mintCodeLen) break;
                ch = GetCurrChar();
            }//多读了一个字符既是下次将要开始的指针位置
            token[count] = '\0';
            string strWord = new string(token, 0, count);
            fnAddWordToList(strWord);
        }

        protected virtual void fnAccessXmlElement_Start(char chCurrChar)
        {
            char ch;
            char[] token = new char[100];
            int i, count = 0;//count用来做token的指示器，收集有用字符

            token[count++] = chCurrChar;//收集
            pProject++;//下移
            ch = GetCurrChar();
            while (Char.IsLetter(ch)
                || Char.IsDigit(ch)
                //|| resourceProject[pProject] == '.'
                || ch == '_')
            {//后跟字母或数字
                token[count++] = ch;//收集
                pProject++;//下移
                if (pProject >= mintCodeLen) break;
                ch = GetCurrChar();
            }//多读了一个字符既是下次将要开始的指针位置
            token[count] = '\0';
            string strWord = new string(token, 0, count);
            fnAddWordToList(strWord);
        }


        protected void fnAccessFirstCharIsDigit(char chCurrChar)
        {
            char ch = GetCurrChar();
            char[] token = new char[100];
            int i, count = 0;//count用来做token的指示器，收集有用字符
            while (Char.IsDigit(ch)
                       || ch == '.'
                       || ch == 'f')
            {//后跟数字
                token[count++] = ch;//收集
                pProject++;
                ch = GetCurrChar();
            }//多读了一个字符既是下次将要开始的指针位置
            token[count] = '\0';
            string strWord = new string(token, 0, count);
            fnAddWordToList(strWord, "常量", tzWordType.Const);
        }
        /// <summary>
        /// 
        /// </summary>
        protected virtual void fnAccessCodeConst()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        protected virtual void fnAccessDelimiter()
        {
            char[] token = new char[100];
            char ch;//作为判断使用
            string strWord = "";
            ch = GetCurrChar();
            token[0] = ch;
            token[1] = GetNextChar();
            token[2] = '\0';//形成单字符串
            strWord = new string(token, 0, 2);
            if (IsCommunity_character(strWord) == true
                || IsOperator(strWord) == true)
            {
                fnAddWordToList(strWord);
                pProject++;
                pProject++;
                return;
            }
            token[1] = '\0';//形成单字符串
            strWord = new String(token, 0, 1);
            if (IsCommunity_character(strWord) == true
                || IsOperator(strWord) == true)
            {
                fnAddWordToList(strWord);
                pProject++;
                return;
            }

        }

        /// <summary>
        /// 获取单词列表的子列表
        /// </summary>
        /// <param name="parrObjLst">源对象列表</param>
        /// <param name="intStartIndex">开始序号</param>
        /// <param name="intEndIndex">结束序号</param>
        /// <returns>单词列表的子列表</returns>
        public static List<clsWord_LA> GetSubObjLst(List<clsWord_LA> parrObjLst, int intStartIndex, int intEndIndex)
        {
            List<clsWord_LA> arrObjLst = new List<clsWord_LA>();
            for (int i = intStartIndex; i <= intEndIndex; i++)
            {
                clsWord_LA objWord_LA = parrObjLst[i];
                if (objWord_LA.InEffect == false) continue;
                arrObjLst.Add(objWord_LA);
            }
            return arrObjLst;
        }
    }
}
// if (resourceProject[pProject] == '='
//    || resourceProject[pProject] == '|'
//    || resourceProject[pProject] == '!'
//    || resourceProject[pProject] == '&'
//    || resourceProject[pProject] == '<'
//    || resourceProject[pProject] == '>')
//{//=.==  //|,||  //!,!=  //&,&&


//    pProject++;
//    if (resourceProject[pProject] == '=')
//    {
//        syn = 42;
//    }
//    else
//    {
//        pProject--;
//        syn = 41;
//    }
//    pProject++;
//    return;
//}

//if (resourceProject[pProject] == '$')
//               {//结束符
//                   syn = 0;//种别码为0
//               }