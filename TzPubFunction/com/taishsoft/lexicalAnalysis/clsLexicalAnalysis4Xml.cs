using com.taishsoft.common;
using com.taishsoft.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.lexicalAnalysis
{

    /// <summary>
    /// 用于语法分析
    /// </summary>
    public class clsLexicalAnalysis4Xml : clsLexicalAnalysisBase
    {
        private static string[] sstrSystemType ={"bool","byte","char","decimal",
            "double","float","int","interface","long","object",
            "sbyte", "short","string","struct", "uint","ulong","ushort","void", "Exception"};

        private static string[] sstrReserveWord ={"abstract","as","base","bool","break","byte","case","catch","char","checked",
        "class","const","continue","decimal","default","do","double","else","enum","event",
        "explicit","extern","false","finally","fixed","float","for","foreach","goto","if",
        "implicit","in","in（泛型修饰符）","int","interface","internal","为","lock","long",
        "命名空间","namespace","new","null","object","operator","out","out（泛型修饰符）","override",
        "params","private","protected","public","readonly","ref","return","sbyte","sealed",
        "short","sizeof","stackalloc","static","string","结构","struct", "switch","this","throw","true",
        "try","typeof","uint","ulong","unchecked","unsafe","ushort","using","virtual","void",
        "volatile","while"};
        private static string[] sstrOperators ={"*","/","%","+","-","<<",">>",
            "<",">","<=",">=",
        "==","!=","&","^","|","&&","||","?", "?:","+=","-=","*=","/=","%=","&=","|=","^=",
        "<<=",">>=","=","++","--", "and", "or"};
        private static string[] sstrElementDelimiter = { "<", ">", "</", "<?", "?>", "/>" };
        private static string[] sstrSystemVariable = { };
        private static string[] sstrSystemObjectProperty = { "length" };
        public clsLexicalAnalysis4Xml(string strCode_In) : base(strCode_In)
        {
            arrSystemType = new List<string>(sstrSystemType);
            arrReserveWord = new List<string>(sstrReserveWord);
            arrSystemVariableTbl = new List<string>(sstrSystemVariable);
            arrSystemObjectProperty = new List<string>(sstrSystemObjectProperty);
            arrOperators = new List<string>(sstrOperators);
            arrElementDelimiter = new List<string>(sstrElementDelimiter);
        }

        protected override tzFirstCharType fnGetCharTypeByFirstChar(char ch)
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
            else if (ch == '<')
            {
                return tzFirstCharType.XmlTags_Start;
            }
            else if (ch == '>')
            {
                return tzFirstCharType.XmlTags_End;
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
        protected override void fnScanner()
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
                                strWord = "</";
                                fnAddWordToList(strWord, "Xml元素分隔符", tzWordType.ElementDelimiter);
                                pProject++;
                                pProject++;
                                break;
                            default:
                                strWord = "<";
                                fnAddWordToList(strWord, "Xml元素分隔符", tzWordType.ElementDelimiter);
                                pProject++;

                                break;
                        }
                        break;
                    case tzFirstCharType.XmlTags_End:// "/"

                        strWord = ">";
                        fnAddWordToList(strWord, "Xml元素分隔符", tzWordType.ElementDelimiter);
                        pProject++;
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
        protected override void DetermineTypeOfWord(clsWord_LA objWord_Curr)
        {
            //clsWord_LA PrevWord = fnGetPrevWord(intIndex);
            //clsWord_LA NextWord = fnGetNextWord(intIndex);
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
        /// 合并不应被分开的词
        /// </summary>
        public void CombineRelaWord()
        {
            mintWordIndex = 0;
            mintWordTotal = arrResultWord.Count;
            while (true)
            {
                if (CurrWord == null) break;
                string strWord = CurrWord.Word;
                try
                {
                    switch (strWord)
                    {
                        case "<":
                            if (NextWord.Word == "?")
                            {
                                CurrWord.Word = string.Format("{0}{1}", CurrWord.Word, NextWord.Word);
                                //arrResultWord.Remove(NextWord);
                                NextWord.InEffect = false;
                            }
                            mintWordIndex++;
                            break;
                        case ">":
                            if (PrevWord.Word == "?")
                            {
                                CurrWord.Word = string.Format("{0}{1}", PrevWord.Word, CurrWord.Word);
                                //arrResultWord.Remove(PrevWord);
                                PrevWord.InEffect = false;
                            }
                            else if (PrevWord.Word == "/")
                            {
                                CurrWord.Word = string.Format("{0}{1}", PrevWord.Word, CurrWord.Word);
                                //arrResultWord.Remove(PrevWord);
                                PrevWord.InEffect = false;
                            }
                            mintWordIndex++;
                            break;

                        case ".":
                            CurrWord.Word = string.Format("{0}.", PrevWord.Word);
                            //arrResultWord.Remove(PrevWord);
                            PrevWord.InEffect = false;
                            CurrWord.Word += string.Format("{0}", NextWord.Word);
                            //arrResultWord.Remove(NextWord);
                            NextWord.InEffect = false;

                            while (true)
                            {
                                if (NextWord.Word != ".")
                                {
                                    break;
                                }
                                else
                                {
                                    CurrWord.Word += string.Format(".");
                                    //arrResultWord.Remove(NextWord);
                                    NextWord.InEffect = false;
                                    CurrWord.Word += string.Format("{0}", NextWord.Word);
                                    //arrResultWord.Remove(NextWord);
                                    NextWord.InEffect = false;
                                }
                            }
                            mintWordIndex++;
                            //mintWordIndex++;
                            break;
                        case ":":
                            CurrWord.Word = string.Format("{0}:{1}", PrevWord.Word, NextWord.Word);
                            //arrResultWord.Remove(PrevWord);
                            PrevWord.InEffect = false;
                            //arrResultWord.Remove(NextWord);

                            NextWord.InEffect = false;
                            mintWordIndex++;                 
                            break;
                        default:
                            mintWordIndex++;
                            break;
                    }
                }
                catch(Exception objException)
                {
                    string strMsg = string.Format("在合并时出错！序号:[{0}],错误:[{1}]({2})", mintWordIndex, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }

            }
            mintWordIndex = 0;
            int intCount = arrResultWord.Count;
            for (mintWordIndex = intCount-1; mintWordIndex>=0; mintWordIndex--)
            {
                clsWord_LA objInfor = arrResultWord[mintWordIndex];
            
                //if (CurrWord == null) break;
                if (objInfor.InEffect == false)
                {
                    arrResultWord.Remove(objInfor);
                }
              
            }
            int intIndex = 0;
            mintWordIndex = 0;
            while (true)
            {
                if (CurrWord == null) break;
                //string strWord = CurrWord.Word;
                CurrWord.Index = intIndex++;
                mintWordIndex++;
            }
        }
        public List<clsNodeObj> GeneXmlElementByWordLst()
        {
            //预处理

            StringBuilder sbCode_Out = new StringBuilder();
            List<clsNodeObj> arrNodeObj = new List<clsNodeObj>();
            clsNodeObj myNodeObj_Curr = null;
            mintWordIndex = 0;
            mintWordTotal = arrResultWord.Count;
            List<clsRange> arrRange = null;
            try
            {
                arrRange = getElementObjRange(arrResultWord);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在把词列表按元素分组范围时出错！错误：[{0}]. ({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            foreach (clsRange objInFor in arrRange)
            {
                try
                {


                    List<clsWord_LA> arrSubObjLst = GetSubObjLst(arrResultWord, objInFor.StartPos, objInFor.EndPos);
                    myNodeObj_Curr = GetOntSubXmlElement(arrSubObjLst);
                    if (myNodeObj_Curr != null)
                    {
                        arrNodeObj.Add(myNodeObj_Curr);
                    }
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("在根据词数组生成元素时出错！（组：{2}({3}--{4})）错误：[{0}]. ({1})",
                        objException.Message, clsStackTrace.GetCurrClassFunction(), objInFor.Index, objInFor.StartPos, objInFor.EndPos);
                    throw new Exception(strMsg);
                }
            }

            //while (true)
            //{
            //    if (CurrWord == null) break;
            //    if (CurrWord.Word == "#End") break;
            //    //clsWord_LA objWord_Curr = CurrWord;
            //    //if (objWord_Curr.InEffect == false) continue;
            //    //clsWord_LA objWord_Prev = fnGetPrevWord(i);
            //    //clsWord_LA objWord_Next = fnGetNextWord(i);

            //    myNodeObj_Curr = GetOntXmlElement();
            //    if (myNodeObj_Curr != null)
            //    {
            //        arrNodeObj.Add(myNodeObj_Curr);
            //    }
            //    if (myNodeObj_Curr.IntTag == 0)
            //    {
            //        string ss = "这里出错！";
            //    }
            //    mintWordIndex = myNodeObj_Curr.IntTag;
            //    if (IsEndTag(CurrWord.Word)) mintWordIndex++;
            //}
            //sbCode_Out.AppendFormat("共计:[{0}]行，[{1}]字符。", mintLineNo, pProject);
            //return "";// sbCode_Out.ToString();

            return arrNodeObj;
        }

        public clsNodeObj GetOntXmlElementBak20180606()
        {
            //预处理
            string strMsg = "";
            int intStartTag = 0;
            int intEndTag = 0;
            //List<clsNodeObj> arrNodeObj = new List<clsNodeObj>();
            string strElementType = "";
            clsNodeObj myNodeObj_Curr = new clsNodeObj();
            while (true)
            {
                clsWord_LA objWord_Curr = CurrWord;
                if (objWord_Curr == null) break;
                if (objWord_Curr.Word == "#End") return myNodeObj_Curr;
                //clsWord_LA objWord_Curr = CurrWord;
                //if (objWord_Curr.InEffect == false) continue;
                //clsWord_LA objWord_Prev = fnGetPrevWord(i);
                //clsWord_LA objWord_Next = fnGetNextWord(i);



                tzWordType wtType = objWord_Curr.WordTypeId;
                switch (wtType)
                {
                    case tzWordType.ElementDelimiter:
                        string strCurrTag = objWord_Curr.Word;
                        switch (strCurrTag)
                        {
                            case ">":
                                if (NextWord.Word == "#End")
                                {
                                    return myNodeObj_Curr;
                                }
                                mintWordIndex++;
                                break;
                            case "<?":
                                intStartTag = mintWordIndex + 1;
                                intEndTag = FindEndTag4StartTagDelimiter(arrResultWord, strCurrTag, intStartTag);
                                if (intEndTag < intStartTag)
                                {
                                    strMsg = string.Format("[{0}]找不到相应的结束标签！", strCurrTag);
                                    throw new Exception(strMsg);
                                }
                                {
                                    mintWordIndex = intStartTag;
                                    while (mintWordIndex < intEndTag)
                                    {
                                        objWord_Curr = CurrWord;
                                        if (mintWordIndex == intStartTag + 1)
                                        {
                                            myNodeObj_Curr.Name = objWord_Curr.Word;
                                        }
                                        else
                                        {
                                            myNodeObj_Curr.Value += string.Format("{0} ", objWord_Curr.Word);
                                        }
                                        mintWordIndex++;
                                        objWord_Curr = CurrWord;
                                    }
                                    myNodeObj_Curr.IntTag = objWord_Curr.Index + 1;
                                    return myNodeObj_Curr;
                                }
                                break;
                            case "<":
                                intStartTag = mintWordIndex;
                                intEndTag = FindEndTag4StartTagDelimiter(arrResultWord, strCurrTag, intStartTag + 1);
                                if (intEndTag < intStartTag)
                                {
                                    strMsg = string.Format("[{0}]找不到相应的结束标签！", strCurrTag);
                                    throw new Exception(strMsg);
                                }

                                mintWordIndex = intStartTag + 1;
                                bool bolIsFirst = true;
                                while (mintWordIndex < intEndTag)
                                {
                                    objWord_Curr = CurrWord;
                                    if (bolIsFirst)
                                    {
                                        myNodeObj_Curr.Name = objWord_Curr.Word;
                                        mintWordIndex++;
                                        bolIsFirst = false;
                                        continue;
                                    }

                                    myNodeObj_Curr.Value += string.Format("{0} ", objWord_Curr.Word);
                                    mintWordIndex++;

                                }
                                clsWord_LA objWord_LA = arrResultWord[intEndTag];
                                if (objWord_LA.Word == "/>")
                                {
                                    myNodeObj_Curr.IntTag = objWord_LA.Index + 1;
                                    return myNodeObj_Curr;
                                }
                                intStartTag = mintWordIndex;
                                intEndTag = FindTagName(arrResultWord, "</", myNodeObj_Curr.Name, intStartTag + 1);
                                if (intEndTag < intStartTag)
                                {
                                    //说明找不到
                                    myNodeObj_Curr.IntTag = objWord_Curr.Index + 1;
                                    return myNodeObj_Curr;
                                }
                                else
                                {
                                    mintWordIndex = intStartTag + 1;
                                    intStartTag++;
                                    clsNodeObj myNodeObj_Sub = null;
                                    while (intStartTag < intEndTag)
                                    {
                                        List<clsWord_LA> arrSubObjLst = GetSubObjLst(arrResultWord, intStartTag, intEndTag - 1);
                                        myNodeObj_Sub = GetOntSubXmlElement(arrSubObjLst);

                                        if (myNodeObj_Sub != null)
                                        {
                                            myNodeObj_Curr.AddNodeObj(myNodeObj_Sub);
                                            if (myNodeObj_Sub.IntTag < intStartTag)
                                            {
                                                string ss = "这里出错！";
                                            }
                                            intStartTag = myNodeObj_Sub.IntTag;
                                            mintWordIndex = arrResultWord[myNodeObj_Sub.IntTag].Index + 3;
                                            objWord_Curr = CurrWord;
                                        }
                                        else
                                        {
                                            break;
                                        }

                                    }

                                }
                                myNodeObj_Curr.IntTag = objWord_Curr.Index;
                                return myNodeObj_Curr;

                            case "</":

                                if (string.IsNullOrEmpty(strElementType) == true) return null;
                                if (strElementType == "Value")
                                {
                                    return myNodeObj_Curr;
                                }
                                mintWordIndex++;
                                objWord_Curr = CurrWord;
                                myNodeObj_Curr.Name = objWord_Curr.Word;
                                mintWordIndex++;
                                objWord_Curr = CurrWord;

                                if (objWord_Curr.Word == ">")
                                {
                                    return myNodeObj_Curr;
                                }
                                break;

                        }

                        break;
                    case tzWordType.UnKnown:

                        myNodeObj_Curr.Value += CurrWord.Word;
                        if (string.IsNullOrEmpty(strElementType) == true)
                        {
                            strElementType = "Value";
                        }
                        mintWordIndex++;
                        break;
                    case tzWordType.ReserveWord:
                    case tzWordType.IDentifier:
                    case tzWordType.SystemObjectProperty:
                    case tzWordType.Const:
                    case tzWordType.CodeConst:
                    case tzWordType.Operators:
                    case tzWordType.Delimiter:
                    case tzWordType.NameSpaces:
                    case tzWordType.UserClass:
                    case tzWordType.UDSpaceName:
                    case tzWordType.SystemType:
                    case tzWordType.SystemVariable:
                    case tzWordType.Variable://变量
                    case tzWordType.Function://函数方法
                    case tzWordType.CodeRegion://区域
                        break;
                    default:
                        strMsg = string.Format("单词类型：[{0}]没有被处理！({1})",
                            clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(CurrWord.WordTypeId),
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            //sbCode_Out.AppendFormat("共计:[{0}]行，[{1}]字符。", mintLineNo, pProject);
            //return "";// sbCode_Out.ToString();

            return myNodeObj_Curr;
        }

        public static clsNodeObj GetOntSubXmlElement(List<clsWord_LA> arrObjLst)
        {
            //预处理
            string strMsg = "";
            int intStartTag = 0;
            int intEndTag = 0;
            int intStartTag2 = 0;
            int intEndTag2 = 0;
            //List<clsNodeObj> arrNodeObj = new List<clsNodeObj>();
            string strElementType = "";
            int intWordIndex = 0;
            int intLstLen = arrObjLst.Count;
            clsNodeObj myNodeObj_Curr = new clsNodeObj();
            while (intWordIndex < intLstLen)
            {
                clsWord_LA objWord_Curr = GetCurrWord( arrObjLst, intWordIndex);
                if (objWord_Curr == null) break;
                if (objWord_Curr.Word == "#End") return myNodeObj_Curr;
                //clsWord_LA objWord_Curr = CurrWord;
                //if (objWord_Curr.InEffect == false) continue;
                clsWord_LA objWord_Prev = GetPrevWord(arrObjLst, intWordIndex);
                clsWord_LA objWord_Next = GetNextWord(arrObjLst, intWordIndex);

                tzWordType wtType = objWord_Curr.WordTypeId;
                switch (wtType)
                {
                    case tzWordType.ElementDelimiter:
                        string strCurrTag = objWord_Curr.Word;
                        switch (strCurrTag)
                        {
                            case "<?":
                                intStartTag = intWordIndex + 1;
                                intEndTag = FindEndTag4StartTagDelimiter(arrObjLst, strCurrTag, intStartTag);
                                if (intEndTag < intStartTag)
                                {
                                    strMsg = string.Format("[{0}]找不到相应的结束标签！", strCurrTag);
                                    throw new Exception(strMsg);
                                }
                                {
                                    intWordIndex = intStartTag;
                                    while (intWordIndex < intEndTag)
                                    {
                                        objWord_Curr =GetCurrWord(arrObjLst, intWordIndex);
                                        objWord_Prev = GetPrevWord(arrObjLst, intWordIndex);
                                        objWord_Next = GetNextWord(arrObjLst, intWordIndex);
                                        if (intWordIndex == intStartTag)
                                        {
                                            myNodeObj_Curr.Name = objWord_Curr.Word;
                                            myNodeObj_Curr.NodeType = "<?";
                                        }
                                        else
                                        {
                                            myNodeObj_Curr.Value += string.Format("{0} ", objWord_Curr.Word);
                                        }
                                        if (objWord_Curr.Word == "=")
                                        {
                                            string strKey = objWord_Prev.Word;
                                            string strValue = objWord_Next.Word;
                                            switch(strKey)
                                            {
                                                case "android:id":
                                                    myNodeObj_Curr.Id = strValue;
                                                    break;
                                                default:
                                                    myNodeObj_Curr.AddAttribute(strKey, strValue);
                                                    break;
                                            }
                                        }
                                        intWordIndex++;
                                    }
                                    myNodeObj_Curr.IntTag = objWord_Curr.Index + 1;
                                    return myNodeObj_Curr;
                                }
                            

                            case ">":
                                if (objWord_Next.Word == "#End")
                                {
                                    return myNodeObj_Curr;
                                }
                                intWordIndex++;
                                break;

                            case "<":
                                if (strElementType == "Value")
                                {
                                    myNodeObj_Curr.IntTag = objWord_Curr.Index;
                                    return myNodeObj_Curr;
                                }
                                strElementType = "Element";

                                intStartTag = intWordIndex + 1;
                                intEndTag = FindEndTag4StartTagDelimiter(arrObjLst, strCurrTag, intStartTag);
                                if (intEndTag < intStartTag)
                                {
                                    strMsg = string.Format("[{0}]找不到相应的结束标签！", strCurrTag);
                                    throw new Exception(strMsg);
                                }

                                intWordIndex = intStartTag;
                                while (intWordIndex < intEndTag)
                                {
                                    objWord_Curr = GetCurrWord(arrObjLst, intWordIndex);
                                    objWord_Prev = GetPrevWord(arrObjLst, intWordIndex);
                                    objWord_Next = GetNextWord(arrObjLst, intWordIndex);
                                    if (intWordIndex == intStartTag)
                                    {
                                        myNodeObj_Curr.Name = objWord_Curr.Word;
                                        myNodeObj_Curr.NodeType = "<";

                                    }
                                    else
                                    {
                                        myNodeObj_Curr.Value += string.Format("{0} ", objWord_Curr.Word);
                                    }
                                    if (objWord_Curr.Word == "=")
                                    {
                                        string strKey = objWord_Prev.Word;
                                        string strValue = objWord_Next.Word;
                                        switch (strKey)
                                        {
                                            case "android:id":
                                                myNodeObj_Curr.Id = strValue;
                                                break;
                                            default:
                                                myNodeObj_Curr.AddAttribute(strKey, strValue);
                                                break;
                                        }
                                    }
                                    intWordIndex++;

                                }
                                clsWord_LA objWord_LA = GetCurrWord( arrObjLst ,intEndTag);
                                if (objWord_LA.Word == "/>")
                                {
                                    myNodeObj_Curr.IntTag = intEndTag + 1;
                                    return myNodeObj_Curr;
                                }

                                intStartTag2 = intWordIndex + 1;
                                intEndTag2 = FindTagName(arrObjLst, "</", myNodeObj_Curr.Name, intStartTag2);
                                if (intEndTag2 < intStartTag2)
                                {
                                    //说明找不到
                                    myNodeObj_Curr.IntTag = intEndTag;
                                    return myNodeObj_Curr;
                                }
                                else
                                {
                                    clsNodeObj myNodeObj_Sub = null;

                                    List<clsWord_LA> arrSubObjLst = GetSubObjLst(arrObjLst, intStartTag2, intEndTag2 - 1);
                                    List<clsRange> arrRange = null;
                                    try
                                    {
                                        arrRange = getElementObjRange(arrSubObjLst);
                                    }
                                    catch (Exception objException)
                                    {
                                        strMsg = string.Format("在把词列表按元素分组范围时出错！错误：[{0}]. ({1})", objException.Message,
                                            clsStackTrace.GetCurrClassFunction());
                                        throw new Exception(strMsg);
                                    }
                                    foreach (clsRange objInFor in arrRange)
                                    {
                                        List<clsWord_LA> arrSubObjLst_In = GetSubObjLst(arrSubObjLst, objInFor.StartPos, objInFor.EndPos);
                                        myNodeObj_Sub = GetOntSubXmlElement(arrSubObjLst_In);
                                        if (myNodeObj_Sub != null)
                                        {
                                            myNodeObj_Curr.AddNodeObj(myNodeObj_Sub);
                                        }
                                    }
                                }

                                return myNodeObj_Curr;
                            case "</":
                                if (string.IsNullOrEmpty(strElementType) == true) return null;
                                if (strElementType == "Value") return myNodeObj_Curr;
                                intWordIndex++;
                                objWord_Curr = GetCurrWord(arrObjLst, intWordIndex);
                                myNodeObj_Curr.Name = objWord_Curr.Word;
                                intWordIndex++;
                                objWord_Curr = GetCurrWord(arrObjLst, intWordIndex);

                                if (objWord_Curr.Word == ">")
                                {
                                    myNodeObj_Curr.IntTag = objWord_Curr.Index;
                                    return myNodeObj_Curr;
                                }
                                break;
                        }

                        break;
                    case tzWordType.UnKnown:

                        myNodeObj_Curr.Value += objWord_Curr.Word;
                        myNodeObj_Curr.IntTag = objWord_Curr.Index + 1;

                        if (string.IsNullOrEmpty(strElementType) == true)
                        {
                            strElementType = "Value";
                        }
                        while (true)
                        {
                            if (objWord_Curr.WordTypeId == tzWordType.ElementDelimiter)
                            {
                                return myNodeObj_Curr;
                            }
                            intWordIndex++;
                            objWord_Curr = GetCurrWord(arrObjLst, intWordIndex);
                            if (objWord_Curr == null)
                            {
                                return myNodeObj_Curr;
                            }
                            myNodeObj_Curr.Value += string.Format(" {0}", objWord_Curr.Word);
                        }
                        intWordIndex++;
                        break;
                    case tzWordType.ReserveWord:
                    case tzWordType.IDentifier:
                    case tzWordType.SystemObjectProperty:
                    case tzWordType.Const:
                    case tzWordType.CodeConst:
                    case tzWordType.Operators:
                    case tzWordType.Delimiter:
                    case tzWordType.NameSpaces:
                    case tzWordType.UserClass:
                    case tzWordType.UDSpaceName:
                    case tzWordType.SystemType:
                    case tzWordType.SystemVariable:
                    case tzWordType.Variable://变量
                    case tzWordType.Function://函数方法
                    case tzWordType.CodeRegion://区域
                        intWordIndex++;
                        break;
                    default:
                        strMsg = string.Format("单词类型：[{0}]没有被处理！({1})",
                            clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            //sbCode_Out.AppendFormat("共计:[{0}]行，[{1}]字符。", mintLineNo, pProject);
            //return "";// sbCode_Out.ToString();

            return myNodeObj_Curr;
        }

        public static clsNodeObj GetOntSubXmlElementBak201806042(List<clsWord_LA> arrObjLst)
        {
            //预处理
            string strMsg = "";
            int intStartTag = 0;
            int intEndTag = 0;
            //List<clsNodeObj> arrNodeObj = new List<clsNodeObj>();
            string strElementType = "";
            int intWordIndex = 0;
            int intLstLen = arrObjLst.Count;
            clsNodeObj myNodeObj_Curr = new clsNodeObj();
            while (intWordIndex < intLstLen)
            {
                clsWord_LA objWord_Curr = arrObjLst[intWordIndex];
                if (objWord_Curr == null) break;
                if (objWord_Curr.Word == "#End") return myNodeObj_Curr;
                //clsWord_LA objWord_Curr = CurrWord;
                //if (objWord_Curr.InEffect == false) continue;
                clsWord_LA objWord_Prev = GetPrevWord(arrObjLst, intWordIndex);
                clsWord_LA objWord_Next = GetNextWord(arrObjLst, intWordIndex);

                tzWordType wtType = objWord_Curr.WordTypeId;
                switch (wtType)
                {
                    case tzWordType.ElementDelimiter:
                        string strCurrTag = objWord_Curr.Word;
                        switch (strCurrTag)
                        {
                            case ">":
                                if (objWord_Next.Word == "#End")
                                {
                                    return myNodeObj_Curr;
                                }
                                intWordIndex++;
                                break;

                            case "<":
                                if (strElementType == "Value")
                                {
                                    myNodeObj_Curr.IntTag = objWord_Curr.Index;
                                    return myNodeObj_Curr;
                                }
                                strElementType = "Element";

                                intStartTag = intWordIndex + 1;
                                intEndTag = FindEndTag4StartTagDelimiter(arrObjLst, strCurrTag, intStartTag);
                                if (intEndTag < intStartTag)
                                {
                                    strMsg = string.Format("[{0}]找不到相应的结束标签！", strCurrTag);
                                    throw new Exception(strMsg);
                                }

                                intWordIndex = intStartTag;
                                while (intWordIndex < intEndTag)
                                {
                                    objWord_Curr = GetCurrWord(arrObjLst, intWordIndex);
                                    if (intWordIndex == intStartTag)
                                    {
                                        myNodeObj_Curr.Name = objWord_Curr.Word;
                                    }
                                    else
                                    {
                                        myNodeObj_Curr.Value += string.Format("{0} ", objWord_Curr.Word);
                                    }
                                    intWordIndex++;

                                }
                                clsWord_LA objWord_LA = arrObjLst[intEndTag];
                                if (objWord_LA.Word == "/>")
                                {
                                    myNodeObj_Curr.IntTag = intEndTag + 1;
                                    return myNodeObj_Curr;
                                }

                                intStartTag = intWordIndex + 1;
                                intEndTag = FindTagName(arrObjLst, "</", myNodeObj_Curr.Name, intStartTag);
                                if (intEndTag < intStartTag)
                                {
                                    //说明找不到
                                    myNodeObj_Curr.IntTag = intEndTag;
                                    return myNodeObj_Curr;
                                }
                                else
                                {
                                    clsNodeObj myNodeObj_Sub = null;
                                    while (intStartTag < intEndTag)
                                    {
                                        List<clsWord_LA> arrSubObjLst = GetSubObjLst(arrObjLst, intStartTag, intEndTag - 1);
                                        myNodeObj_Sub = GetOntSubXmlElement(arrSubObjLst);
                                        objWord_Curr = GetCurrWord(arrObjLst, intWordIndex);
                                        if (myNodeObj_Sub != null)
                                        {
                                            myNodeObj_Curr.AddNodeObj(myNodeObj_Sub);
                                            if (myNodeObj_Sub.IntTag < intWordIndex)
                                            {
                                                string ss = "这里出错！";
                                            }

                                            intStartTag = myNodeObj_Sub.IntTag;
                                            intWordIndex = myNodeObj_Sub.IntTag + 3;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }

                                }
                                myNodeObj_Curr.IntTag = intEndTag + 3;
                                return myNodeObj_Curr;
                            case "</":
                                if (string.IsNullOrEmpty(strElementType) == true) return null;
                                if (strElementType == "Value") return myNodeObj_Curr;
                                intWordIndex++;
                                objWord_Curr = GetCurrWord(arrObjLst, intWordIndex);
                                myNodeObj_Curr.Name = objWord_Curr.Word;
                                intWordIndex++;
                                objWord_Curr = GetCurrWord(arrObjLst, intWordIndex);

                                if (objWord_Curr.Word == ">")
                                {
                                    myNodeObj_Curr.IntTag = objWord_Curr.Index;
                                    return myNodeObj_Curr;
                                }
                                break;
                        }

                        break;
                    case tzWordType.UnKnown:

                        myNodeObj_Curr.Value += objWord_Curr.Word;
                        myNodeObj_Curr.IntTag = objWord_Curr.Index + 1;
                        if (string.IsNullOrEmpty(strElementType) == true)
                        {
                            strElementType = "Value";
                        }
                        intWordIndex++;
                        break;
                    case tzWordType.ReserveWord:
                    case tzWordType.IDentifier:
                    case tzWordType.SystemObjectProperty:
                    case tzWordType.Const:
                    case tzWordType.CodeConst:
                    case tzWordType.Operators:
                    case tzWordType.Delimiter:
                    case tzWordType.NameSpaces:
                    case tzWordType.UserClass:
                    case tzWordType.UDSpaceName:
                    case tzWordType.SystemType:
                    case tzWordType.SystemVariable:
                    case tzWordType.Variable://变量
                    case tzWordType.Function://函数方法
                    case tzWordType.CodeRegion://区域
                        intWordIndex++;
                        break;
                    default:
                        strMsg = string.Format("单词类型：[{0}]没有被处理！({1})",
                            clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            //sbCode_Out.AppendFormat("共计:[{0}]行，[{1}]字符。", mintLineNo, pProject);
            //return "";// sbCode_Out.ToString();

            return myNodeObj_Curr;
        }


        public clsNodeObj GetOntSubXmlElementBak(int pintStartIndex, int pintEndIndex)
        {
            //预处理
            string strMsg = "";
            int intStartTag = 0;
            int intEndTag = 0;
            //List<clsNodeObj> arrNodeObj = new List<clsNodeObj>();
            string strElementType = "";
            mintWordIndex = pintStartIndex;
            clsNodeObj myNodeObj_Curr = new clsNodeObj();
            while (mintWordIndex < pintEndIndex)
            {
                clsWord_LA objWord_Curr = CurrWord;
                if (objWord_Curr == null) break;
                if (objWord_Curr.Word == "#End") return myNodeObj_Curr;
                //clsWord_LA objWord_Curr = CurrWord;
                //if (objWord_Curr.InEffect == false) continue;
                //clsWord_LA objWord_Prev = fnGetPrevWord(i);
                //clsWord_LA objWord_Next = fnGetNextWord(i);



                tzWordType wtType = objWord_Curr.WordTypeId;
                switch (wtType)
                {
                    case tzWordType.ElementDelimiter:
                        string strCurrTag = objWord_Curr.Word;
                        switch (strCurrTag)
                        {
                            case ">":
                                if (NextWord.Word == "#End")
                                {
                                    return myNodeObj_Curr;
                                }
                                mintWordIndex++;
                                break;

                            case "<":
                                if (strElementType == "Value") return myNodeObj_Curr;
                                strElementType = "Element";

                                intStartTag = mintWordIndex;
                                intEndTag = FindEndTag4StartTagDelimiter(arrResultWord, strCurrTag, intStartTag);
                                if (intEndTag < intStartTag)
                                {
                                    strMsg = string.Format("[{0}]找不到相应的结束标签！", strCurrTag);
                                    throw new Exception(strMsg);
                                }

                                mintWordIndex = intStartTag + 1;
                                while (mintWordIndex >= intEndTag)
                                {
                                    objWord_Curr = CurrWord;
                                    myNodeObj_Curr.Name = objWord_Curr.Word;
                                    mintWordIndex++;
                                    objWord_Curr = CurrWord;
                                    myNodeObj_Curr.Value += string.Format("{0} ", objWord_Curr.Word);
                                    mintWordIndex++;
                                    objWord_Curr = CurrWord;
                                }
                                intStartTag = mintWordIndex;
                                intEndTag = FindTagName(arrResultWord, strCurrTag, myNodeObj_Curr.Name, intStartTag);
                                if (intEndTag < intStartTag)
                                {
                                    //说明找不到
                                    return myNodeObj_Curr;
                                }
                                else
                                {
                                    while (mintWordIndex < intEndTag)
                                    {
                                        List<clsWord_LA> arrSubObjLst = GetSubObjLst(arrResultWord, intStartTag, intEndTag + 2);
                                        clsNodeObj myNodeObj_Sub = GetOntSubXmlElement(arrSubObjLst);
                                        objWord_Curr = CurrWord;
                                        if (myNodeObj_Sub != null)
                                        {
                                            myNodeObj_Curr.AddNodeObj(myNodeObj_Sub);

                                        }
                                        mintWordIndex++;
                                    }
                                }
                                return myNodeObj_Curr;


                            case "</":

                                if (string.IsNullOrEmpty(strElementType) == true) return null;
                                if (strElementType == "Value") return myNodeObj_Curr;
                                mintWordIndex++;
                                objWord_Curr = CurrWord;
                                myNodeObj_Curr.Name = objWord_Curr.Word;
                                mintWordIndex++;
                                objWord_Curr = CurrWord;

                                if (objWord_Curr.Word == ">")
                                {
                                    return myNodeObj_Curr;
                                }
                                break;

                        }

                        break;
                    case tzWordType.UnKnown:

                        myNodeObj_Curr.Value += CurrWord.Word;
                        if (string.IsNullOrEmpty(strElementType) == true)
                        {
                            strElementType = "Value";
                        }
                        mintWordIndex++;
                        break;
                    case tzWordType.ReserveWord:
                    case tzWordType.IDentifier:
                    case tzWordType.SystemObjectProperty:
                    case tzWordType.Const:
                    case tzWordType.CodeConst:
                    case tzWordType.Operators:
                    case tzWordType.Delimiter:
                    case tzWordType.NameSpaces:
                    case tzWordType.UserClass:
                    case tzWordType.UDSpaceName:
                    case tzWordType.SystemType:
                    case tzWordType.SystemVariable:
                    case tzWordType.Variable://变量
                    case tzWordType.Function://函数方法
                    case tzWordType.CodeRegion://区域
                        break;
                    default:
                        strMsg = string.Format("单词类型：[{0}]没有被处理！({1})",
                            clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(CurrWord.WordTypeId),
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            //sbCode_Out.AppendFormat("共计:[{0}]行，[{1}]字符。", mintLineNo, pProject);
            //return "";// sbCode_Out.ToString();

            return myNodeObj_Curr;
        }


        public clsNodeObj GetOntXmlElementBak()
        {
            //预处理


            //List<clsNodeObj> arrNodeObj = new List<clsNodeObj>();
            string strElementType = "";
            clsNodeObj myNodeObj_Curr = new clsNodeObj();
            while (true)
            {
                clsWord_LA objWord_Curr = CurrWord;
                if (objWord_Curr == null) break;
                if (objWord_Curr.Word == "#End") return myNodeObj_Curr;
                //clsWord_LA objWord_Curr = CurrWord;
                //if (objWord_Curr.InEffect == false) continue;
                //clsWord_LA objWord_Prev = fnGetPrevWord(i);
                //clsWord_LA objWord_Next = fnGetNextWord(i);



                tzWordType wtType = objWord_Curr.WordTypeId;
                switch (wtType)
                {
                    case tzWordType.ElementDelimiter:
                        switch (objWord_Curr.Word)
                        {
                            case ">":
                                if (NextWord.Word == "#End")
                                {
                                    return myNodeObj_Curr;
                                }
                                mintWordIndex++;
                                break;
                            case "<?":
                                {
                                    mintWordIndex++;
                                    objWord_Curr = CurrWord;
                                    myNodeObj_Curr.Name = objWord_Curr.Word;
                                    mintWordIndex++;
                                    objWord_Curr = CurrWord;

                                    while (true)
                                    {
                                        if (objWord_Curr.Word == "?>")
                                        {
                                            return myNodeObj_Curr;
                                        }
                                        myNodeObj_Curr.Value += string.Format("{0} ", objWord_Curr.Word);
                                        mintWordIndex++;
                                        objWord_Curr = CurrWord;
                                    }
                                }

                            case "<":
                                {
                                    if (strElementType == "Value") return myNodeObj_Curr;
                                    strElementType = "Element";
                                    mintWordIndex++;
                                    objWord_Curr = CurrWord;
                                    myNodeObj_Curr.Name = objWord_Curr.Word;
                                    mintWordIndex++;
                                    objWord_Curr = CurrWord;
                                    while (true)
                                    {
                                        if (objWord_Curr == null)
                                        {
                                            return myNodeObj_Curr;
                                        }
                                        if (objWord_Curr.Word == "/>")//://本元素结束了
                                        {
                                            return myNodeObj_Curr;
                                        }
                                        else if (objWord_Curr.Word == ">")
                                        {
                                            mintWordIndex++;
                                            objWord_Curr = CurrWord;
                                            clsNodeObj myNodeObj_Sub = GetOntXmlElementBak20180606();
                                            objWord_Curr = CurrWord;
                                            if (myNodeObj_Sub != null)
                                            {
                                                myNodeObj_Curr.AddNodeObj(myNodeObj_Sub);

                                                while (true)
                                                {
                                                    if (objWord_Curr.Word == "<")
                                                    {
                                                        myNodeObj_Sub = GetOntXmlElementBak20180606();
                                                        if (myNodeObj_Sub != null)
                                                        {
                                                            myNodeObj_Curr.AddNodeObj(myNodeObj_Sub);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                                break;
                                            }
                                            //mintWordIndex++;

                                        }
                                        else if (objWord_Curr.Word == "</")
                                        {
                                            mintWordIndex++;
                                            objWord_Curr = CurrWord;
                                            while (true)
                                            {
                                                if (objWord_Curr.Word == ">")
                                                {
                                                    return myNodeObj_Curr;
                                                }
                                                mintWordIndex++;
                                                objWord_Curr = CurrWord;
                                            }
                                            break;
                                        }

                                        myNodeObj_Curr.Value += string.Format("{0} ", objWord_Curr.Word);
                                        mintWordIndex++;
                                        objWord_Curr = CurrWord;
                                    }
                                    break;
                                }
                            case "</":

                                if (string.IsNullOrEmpty(strElementType) == true) return null;
                                if (strElementType == "Value") return myNodeObj_Curr;
                                mintWordIndex++;
                                objWord_Curr = CurrWord;
                                myNodeObj_Curr.Name = objWord_Curr.Word;
                                mintWordIndex++;
                                objWord_Curr = CurrWord;

                                if (objWord_Curr.Word == ">")
                                {
                                    return myNodeObj_Curr;
                                }
                                break;

                        }

                        break;
                    case tzWordType.UnKnown:

                        myNodeObj_Curr.Value += CurrWord.Word;
                        if (string.IsNullOrEmpty(strElementType) == true)
                        {
                            strElementType = "Value";
                        }
                        mintWordIndex++;
                        break;
                    case tzWordType.ReserveWord:
                    case tzWordType.IDentifier:
                    case tzWordType.SystemObjectProperty:
                    case tzWordType.Const:
                    case tzWordType.CodeConst:
                    case tzWordType.Operators:
                    case tzWordType.Delimiter:
                    case tzWordType.NameSpaces:
                    case tzWordType.UserClass:
                    case tzWordType.UDSpaceName:
                    case tzWordType.SystemType:
                    case tzWordType.SystemVariable:
                    case tzWordType.Variable://变量
                    case tzWordType.Function://函数方法
                    case tzWordType.CodeRegion://区域
                        break;
                    default:
                        string strMsg = string.Format("单词类型：[{0}]没有被处理！({1})",
                            clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(CurrWord.WordTypeId),
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            //sbCode_Out.AppendFormat("共计:[{0}]行，[{1}]字符。", mintLineNo, pProject);
            //return "";// sbCode_Out.ToString();

            return myNodeObj_Curr;
        }
        /// <summary>
        /// 判断：是否是开始标签？
        /// </summary>
        /// <param name="strTag">所给标签</param>
        /// <returns>是否是开始标签？</returns>
        public static bool IsStartTag(string strTag)
        {
            switch (strTag)
            {
                case ">":
                    return false;
                case "<?":
                    return true;
                case "?>":
                    return false;
                case "<":
                    return true;
                case "</":
                    return true;
                default:
                    return false;
                    //string strMsg = string.Format("标签：[{0}]没有被处理！({1})",
                    //        strTag,
                    //      clsStackTrace.GetCurrClassFunction());
                    //throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 判断：是否是开始标签？
        /// </summary>
        /// <param name="strTag">所给标签</param>
        /// <returns>是否是开始标签？</returns>
        public static bool IsStartTag4Element(string strTag)
        {
            switch (strTag)
            {
                case ">":
                    return false;
                case "<?":
                    return false;
                case "?>":
                    return false;
                case "<":
                    return true;
                case "</":
                    return false;
                default:
                    return false;
                    //string strMsg = string.Format("标签：[{0}]没有被处理！({1})",
                    //        strTag,
                    //      clsStackTrace.GetCurrClassFunction());
                    //throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 判断：是否是开始标签？
        /// </summary>
        /// <param name="strTag">所给标签</param>
        /// <returns>是否是开始标签？</returns>
        public static bool IsEndTag4Element(string strTag)
        {
            switch (strTag)
            {
                case ">":
                    return false;
                case "<?":
                    return false;
                case "?>":
                    return false;
                case "<":
                    return false;
                case "</":
                    return true;
                case "/>":
                    return true;
                default:
                    return false;
                    //string strMsg = string.Format("标签：[{0}]没有被处理！({1})",
                    //        strTag,
                    //      clsStackTrace.GetCurrClassFunction());
                    //throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 判断：是否是结束标签？
        /// </summary>
        /// <param name="strTag">所给标签</param>
        /// <returns>是否是结束标签？</returns>
        public static bool IsEndTag(string strTag)
        {
            switch (strTag)
            {
                case ">":
                    return true;
                case "<?":
                    return false;
                case "?>":
                    return true;
                case "/>":
                    return true;
                case "<":
                    return false;
                case "</":
                    return false;
                default:
                    return false;
                    //string strMsg = string.Format("标签：[{0}]没有被处理！({1})",
                    //        strTag,
                    //      clsStackTrace.GetCurrClassFunction());
                    //throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 判断两个元素标签是否匹配
        /// </summary>
        /// <param name="strStartTag"></param>
        /// <param name="strEndTag"></param>
        /// <returns></returns>
        public static bool IsMatch(string strStartTag, string strEndTag)
        {
            string strMsg = "";
            if (IsStartTag(strStartTag) == false)
            {
                strMsg = string.Format("[{0}]不是开始标签，不需要判别！", strStartTag);
                throw new Exception(strMsg);
            }
            if (IsEndTag(strEndTag) == false)
            {
                strMsg = string.Format("[{0}]不是结束标签，不需要判别！", strEndTag);
                throw new Exception(strMsg);
            }
            switch (strStartTag)
            {
                case "<":
                    switch (strEndTag)
                    {
                        case ">":
                            return true;
                        case "/>":
                            return true;
                        case "?>":
                            return false;

                        default:
                            strMsg = string.Format("结束标签：[{0}]没有被处理！({1})",
                                   strEndTag,
                                 clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }

                case "<?":
                    switch (strEndTag)
                    {
                        case ">":
                            return false;
                        case "/>":
                            return false;
                        case "?>":
                            return true;

                        default:
                            strMsg = string.Format("结束标签：[{0}]没有被处理！({1})",
                                   strEndTag,
                                 clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }
                case "</":
                    switch (strEndTag)
                    {
                        case ">":
                            return true;
                        case "/>":
                            return false;
                        case "?>":
                            return false;

                        default:
                            strMsg = string.Format("结束标签：[{0}]没有被处理！({1})",
                                   strEndTag,
                                 clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }
                default:
                    strMsg = string.Format("开始标签：[{0}]没有被处理！({1})",
                                       strStartTag,
                                     clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 判断元素的标签以及名称是否匹配
        /// </summary>
        /// <param name="objStartTag"></param>
        /// <param name="objEndTag"></param>
        /// <returns></returns>
        public static bool IsMatch4Element(clsWord_LA objStartTag, clsWord_LA objEndTag)
        {
            if (IsEndTag(objEndTag.Tag))
            {
                if (IsMatch(objStartTag.Tag, objEndTag.Tag) == false) return false;
            }
            if (IsEndTag(objEndTag.Tag) && IsEndTag4Element(objEndTag.Tag)) return true;
            if (objStartTag.TagName == objEndTag.TagName) return true;
            else return false;
        }

        public static int FindEndTag4StartTagDelimiter(List<clsWord_LA> arrObjLst, string strStartTagDelimiter, int intStartIndex)
        {

            //List<clsNodeObj> arrNodeObj = new List<clsNodeObj>();
            string strElementType = "";
            clsNodeObj myNodeObj_Curr = new clsNodeObj();
            int intFindIndex = 0;
            int intCurrIndex = intStartIndex;
            int intWordIndex = intStartIndex;
            int intLstLen = arrObjLst.Count;
            Stack<string> objStack = new Stack<string>();
            objStack.Push(strStartTagDelimiter);
            while (intWordIndex < intLstLen)
            {
                clsWord_LA objWord_Curr = arrObjLst[intWordIndex];
                if (objWord_Curr == null) return intWordIndex;
                if (objWord_Curr.Word == "#End") return intWordIndex;

                clsWord_LA objWord_Prev = GetPrevWord(arrObjLst, intWordIndex);
                clsWord_LA objWord_Next = GetNextWord(arrObjLst, intWordIndex);

                tzWordType wtType = objWord_Curr.WordTypeId;
                switch (wtType)
                {

                    case tzWordType.ElementDelimiter:
                        string strCurrTag = objWord_Curr.Word;
                        if (IsStartTag(objWord_Curr.Word))//如果是开始标签
                        {
                            objStack.Push(objWord_Curr.Word);
                            intWordIndex++;
                            continue;
                        }
                        //接下来处理结束标签：
                        string strTopTag = objStack.Peek();
                        if (IsMatch(strTopTag, strCurrTag) == true)
                        {
                            objStack.Pop();
                            if (objStack.Count == 0) return intWordIndex;
                            intWordIndex++;
                            continue;
                        }

                        break;
                    case tzWordType.ReserveWord:
                    case tzWordType.SystemObjectProperty:
                    case tzWordType.CodeConst:
                    case tzWordType.Operators:
                    case tzWordType.UnKnown:
                    case tzWordType.NameSpaces:
                    case tzWordType.UserClass:
                    case tzWordType.UDSpaceName:
                    case tzWordType.SystemType:
                    case tzWordType.SystemVariable:
                    case tzWordType.Variable://变量                        
                    case tzWordType.Function://函数方法                       
                    case tzWordType.CodeRegion://区域
                    case tzWordType.Const://区域
                    case tzWordType.Delimiter://区域

                        intWordIndex++;
                        break;

                    default:
                        string strMsg = string.Format("单词类型：[{0}]没有被处理！({1})",
                            clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }


            return -1;
        }

        public static int FindTagName(List<clsWord_LA> arrObjLst, string strTag, string strElementName, int intStartIndex)
        {
            string strMsg = "";
            if (string.IsNullOrEmpty(strTag) == true || string.IsNullOrEmpty(strElementName) == true)
            {
                strMsg = string.Format("在查找标签名、元素名时，标签、元素不能为空。[{0}{1}]({2})", 
                    strTag, strElementName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            clsNodeObj myNodeObj_Curr = new clsNodeObj();
            string strTopTag = "";
            int intWordIndex = intStartIndex;
            int intLstLen = arrObjLst.Count;

            int intCurrIndex = intStartIndex;
            Stack<string> objStack = new Stack<string>();
            Stack<clsWord_LA> objStack_TagName = new Stack<clsWord_LA>();

            //objStack.Push(strStartTagDelimiter);
            while (intWordIndex < intLstLen)
            {
                clsWord_LA objWord_Curr = arrObjLst[intWordIndex];
                if (objWord_Curr == null) return intWordIndex;
                if (objWord_Curr.Word == "#End") return intWordIndex;

                clsWord_LA objWord_Prev = GetPrevWord(arrObjLst, intWordIndex);
                clsWord_LA objWord_Next = GetNextWord(arrObjLst, intWordIndex);


                tzWordType wtType = objWord_Curr.WordTypeId;
                switch (wtType)
                {

                    case tzWordType.ElementDelimiter:
                        string strCurrTag = objWord_Curr.Word;
                        clsWord_LA objWord_Start = objWord_Curr;
                        objWord_Start.Tag = objWord_Curr.Word;
                        objWord_Start.TagName = objWord_Next.Word;
                        if (strCurrTag != strTag)//如果是开始标签
                        {
                            if (IsStartTag(strCurrTag))
                            {
                                //主要处理“/>”,认为“/>”是一个元素的标签结束
                                string strCurrTagName = string.Format("{0}{1}", strCurrTag, objWord_Next.Word);
                                if (IsEndTag4Element(strCurrTag))
                                {
                                    clsWord_LA objTopTag4Element = objStack_TagName.Peek();
                                    if (IsMatch4Element(objTopTag4Element, objWord_Start) == false)
                                    {
                                        strMsg = string.Format("结束标签:[{0}{1}]没有相应的开始标签！", 
                                            objWord_Start.Tag, objWord_Start.TagName);
                                        throw new Exception(strMsg);
                                    }
                                    else
                                    {
                                        objStack_TagName.Push(objWord_Start);
                                    }
                                    objStack.Pop();
                                }
                                else if (IsStartTag4Element(strCurrTag))
                                {
                                    objStack_TagName.Push(objWord_Start);
                                }
                                objStack.Push(strCurrTag);
                                intWordIndex++;
                                continue;
                            }
                            if (IsEndTag(strCurrTag))
                            {
                                
                                if (objStack.Count > 0)
                                {
                                    strTopTag = objStack.Peek();
                                    if (IsMatch(strTopTag, strCurrTag) == false)
                                    {
                                        strMsg = string.Format("结束标签:[{0}]没有相应的开始标签！", strCurrTag);
                                        throw new Exception(strMsg);
                                    }
                                    objStack.Pop();
                                }
                                if (IsEndTag4Element(strCurrTag))
                                {
                                    //主要处理“/>”,认为“/>”是一个元素的标签结束
                                    if (objStack_TagName.Count > 0)
                                    {
                                        clsWord_LA objTopTagName = objStack_TagName.Peek();
                                        if (IsMatch4Element(objTopTagName, objWord_Start) == false)
                                        {
                                            strMsg = string.Format("结束标签:[{0}{1}]没有相应的开始标签！",
                                                 objWord_Start.Tag, objWord_Start.TagName);
                                            throw new Exception(strMsg);
                                        }
                                        objStack_TagName.Pop();
                                    }
                                }
                                intWordIndex++;
                                continue;
                            }
                        }
                        //以下处理strTag等于"</"的情况
                        if (objStack.Count > 0)
                        {
                            if (IsStartTag(strCurrTag))
                            {
                                objStack.Push(strCurrTag);
                                intWordIndex++;
                                continue;
                            }
                            if (IsEndTag(strCurrTag))
                            {
                                if (objStack.Count > 0)
                                {
                                    strTopTag = objStack.Peek();
                                    if (IsMatch(strTopTag, strCurrTag) == false)
                                    {
                                        strMsg = string.Format("结束标签:[{0}]没有相应的开始标签！", strCurrTag);
                                        throw new Exception(strMsg);
                                    }
                                    objStack.Pop();
                                }
                                intWordIndex++;
                                continue;
                            }
                        }
                        else if (objStack_TagName.Count > 0)
                        {
                            if (IsStartTag(strCurrTag) && IsEndTag4Element(strCurrTag))
                            {
                                if (objStack_TagName.Count > 0)
                                {
                                    clsWord_LA objTopTag = objStack_TagName.Peek();
                                    if (IsMatch4Element(objTopTag, objWord_Start) == false)
                                    {
                                        strMsg = string.Format("结束标签:[{0}]没有相应的开始标签！", strCurrTag);
                                        throw new Exception(strMsg);
                                    }
                                    objStack_TagName.Pop();
                                }
                                intWordIndex++;
                                continue;
                            }
                        }
                        else if ((objStack.Count == 0) && (objStack_TagName.Count == 0))
                        {
                            objWord_Next = GetNextWord(arrObjLst, intWordIndex);
                            if (objWord_Next.Word == strElementName)
                            {
                                return intWordIndex;
                            }
                            else
                            {
                                if (IsStartTag(strCurrTag))
                                {
                                    objStack.Push(strCurrTag);
                                    intWordIndex++;
                                    continue;
                                }
                                if (IsEndTag(strCurrTag))
                                {
                                    if (objStack.Count > 0)
                                    {
                                        strTopTag = objStack.Peek();
                                        if (IsMatch(strTopTag, strCurrTag) == false)
                                        {
                                            strMsg = string.Format("结束标签:[{0}]没有相应的开始标签！", strCurrTag);
                                            throw new Exception(strMsg);
                                        }
                                        objStack.Pop();
                                    }
                                    intWordIndex++;
                                    continue;
                                }

                            }
                            intWordIndex++;
                            continue;
                        }
                        else
                        {
                            intWordIndex++;
                        }
                        break;
                    case tzWordType.ReserveWord:
                    case tzWordType.SystemObjectProperty:
                    case tzWordType.CodeConst:
                    case tzWordType.Operators:
                    case tzWordType.UnKnown:
                    case tzWordType.NameSpaces:
                    case tzWordType.UserClass:
                    case tzWordType.UDSpaceName:
                    case tzWordType.SystemType:
                    case tzWordType.SystemVariable:
                    case tzWordType.Variable://变量                        
                    case tzWordType.Function://函数方法                       
                    case tzWordType.CodeRegion://区域
                    case tzWordType.Delimiter://区域
                    case tzWordType.Const://区域
                        intWordIndex++;
                        break;

                    default:
                        strMsg = string.Format("单词类型：[{0}]没有被处理！({1})",
                            clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            strMsg = string.Format("标签组合:[{0}{1}]无法找到！从:[{2}]到:[{3}].({4})",
                strTag, strElementName, intStartIndex, arrObjLst.Count, clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
            return -1;
        }

        public static List<clsRange> getElementObjRange(List<clsWord_LA> arrObjLst)
        {
            List<clsRange> arrRange = new List<clsRange>();
            clsRange objRange = null;
            string strMsg = "";
            int intStartTag = 0;
            int intStartTag2 = 0;
            int intEndTag = 0;
            int intEndTag2 = 0;
            int intIndex = 0;
            //List<clsNodeObj> arrNodeObj = new List<clsNodeObj>();
            string strElementType = "";
            //clsNodeObj myNodeObj_Curr = new clsNodeObj();
            int intWordIndex = 0;
            while (true)
            {
                clsWord_LA objWord_Curr = GetCurrWord( arrObjLst, intWordIndex);
                if (objWord_Curr == null) break;
                if (objWord_Curr.Word == "#End") return arrRange;
                //clsWord_LA objWord_Curr = CurrWord;
                //if (objWord_Curr.InEffect == false) continue;
                clsWord_LA objWord_Prev = GetPrevWord(arrObjLst, intWordIndex);
                clsWord_LA objWord_Next = GetNextWord(arrObjLst, intWordIndex);



                tzWordType wtType = objWord_Curr.WordTypeId;
                switch (wtType)
                {
                    case tzWordType.ElementDelimiter:
                        string strCurrTag = objWord_Curr.Word;
                        switch (strCurrTag)
                        {
                            case ">":
                                if (objWord_Next.Word == "#End")
                                {
                                    return arrRange;
                                }
                                intWordIndex++;
                                break;
                            case "<?":
                                intStartTag = intWordIndex;
                                intEndTag = FindEndTag4StartTagDelimiter(arrObjLst, strCurrTag, intStartTag + 1);
                                if (intEndTag < intStartTag)
                                {
                                    strMsg = string.Format("[{0}]找不到相应的结束标签！", strCurrTag);
                                    throw new Exception(strMsg);
                                }
                                objRange = new clsRange();
                                objRange.Index = intIndex++;
                                objRange.StartPos = intStartTag;
                                objRange.EndPos = intEndTag;
                                arrRange.Add(objRange);
                                intWordIndex = intEndTag + 1;
                                break;
                            case "<":
                                intStartTag = intWordIndex;
                                intEndTag = FindEndTag4StartTagDelimiter(arrObjLst, strCurrTag, intStartTag + 1);
                                if (intEndTag < intStartTag)
                                {
                                    strMsg = string.Format("[{0}]找不到相应的结束标签！", strCurrTag);
                                    throw new Exception(strMsg);
                                }
                                string strTagName = objWord_Next.Word;
                                intWordIndex = intStartTag + 1;

                                clsWord_LA objWord_LA = arrObjLst[intEndTag];
                                if (objWord_LA.Word == "/>")
                                {
                                    objRange = new clsRange();
                                    objRange.Index = intIndex++;
                                    objRange.StartPos = intStartTag;
                                    objRange.EndPos = intEndTag;
                                    arrRange.Add(objRange);
                                    intWordIndex = intEndTag + 1;
                                    continue;
                                }
                                intStartTag2 = intEndTag + 1;
                                intEndTag2 = FindTagName(arrObjLst, "</", strTagName, intStartTag2);
                                if (intEndTag2 < intStartTag2)
                                {
                                    //说明找不到"</"
                                    objRange = new clsRange();
                                    objRange.Index = intIndex++;
                                    objRange.StartPos = intStartTag;
                                    objRange.EndPos = intEndTag;
                                    arrRange.Add(objRange);
                                    intWordIndex = intEndTag + 1;
                                    continue;
                                }
                                else
                                {
                                    objRange = new clsRange();
                                    objRange.Index = intIndex++;
                                    objRange.StartPos = intStartTag;
                                    objRange.EndPos = intEndTag2 + 2;
                                    arrRange.Add(objRange);
                                    intWordIndex = intEndTag2 + 3;
                                    continue;

                                }
                                break;

                            case "</":
                                strMsg = string.Format("一个元素不应该以【</】开始！处理到序号：[{0}]({1})", 
                                    intWordIndex, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);


                        }

                        break;
                    case tzWordType.UnKnown:
                        intStartTag = intWordIndex;
                        while (true)
                        {
                            if (objWord_Curr.WordTypeId == tzWordType.ElementDelimiter)
                            {
                                intEndTag = intWordIndex - 1;
                                objRange = new clsRange();
                                objRange.Index = intIndex++;
                                objRange.StartPos = intStartTag;
                                objRange.EndPos = intEndTag;
                                arrRange.Add(objRange);
                                break;
                            }
                            intWordIndex++;
                            objWord_Curr = GetCurrWord( arrObjLst, intWordIndex);
                            if (objWord_Curr == null)
                            {
                                intEndTag = intWordIndex - 1;
                                objRange = new clsRange();
                                objRange.Index = intIndex++;
                                objRange.StartPos = intStartTag;
                                objRange.EndPos = intEndTag;
                                arrRange.Add(objRange);
                                break;
                            }
                        }
                        break;
                    case tzWordType.ReserveWord:
                    case tzWordType.IDentifier:
                    case tzWordType.SystemObjectProperty:
                    case tzWordType.Const:
                    case tzWordType.CodeConst:
                    case tzWordType.Operators:
                    case tzWordType.Delimiter:
                    case tzWordType.NameSpaces:
                    case tzWordType.UserClass:
                    case tzWordType.UDSpaceName:
                    case tzWordType.SystemType:
                    case tzWordType.SystemVariable:
                    case tzWordType.Variable://变量
                    case tzWordType.Function://函数方法
                    case tzWordType.CodeRegion://区域
                        break;
                    default:
                        strMsg = string.Format("单词类型：[{0}]没有被处理！({1})",
                            clsPubClass4LexicalAnalysis.GetWordTypeCHStrByWordType(objWord_Curr.WordTypeId),
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }

            return arrRange;
        }

        public static void GeneScript(clsNodeObj objNodeObj, StringBuilder sbXml)
        {
            sbXml.AppendFormat("{0}{1} ", objNodeObj.NodeType, objNodeObj.Name);
            foreach (string strAttr in objNodeObj.AttributeNames)
            {
                if (objNodeObj.NodeType == "<?")
                {
                    sbXml.AppendFormat("{0} = {1} ", strAttr, objNodeObj[strAttr]);
                }
                else
                {
                    sbXml.AppendFormat("\r\n{0} = {1} ", strAttr, objNodeObj[strAttr]);
                }
            }
            if (objNodeObj.SubNodeObjLst == null || objNodeObj.AttributeNames.Count == 0)
            {
                if (objNodeObj.NodeType == "<?")
                {
                    sbXml.Append("?>\r\n");
                }
                else
                {
                    sbXml.Append("/>\r\n");
                }
            }
            else
            {
                
                sbXml.Append(">\r\n");

                foreach (clsNodeObj objInFor in objNodeObj.SubNodeObjLst)
                {
                    GeneScript(objInFor, sbXml);
                }
                sbXml.AppendFormat("</{0}>\r\n", objNodeObj.Name);
            }
        }

        public static string GeneScript(List<clsNodeObj> arrNodeObj)
        {
            StringBuilder sbXml = new StringBuilder();
            foreach(clsNodeObj objInFor in arrNodeObj)
            {
                GeneScript(objInFor, sbXml);
            }

            return sbXml.ToString();
        }

        /// <summary>
        /// 生成安卓的XML脚本
        /// </summary>
        /// <param name="arrNodeObj"></param>
        /// <returns></returns>
        public static string GeneAndroidXmlScript(List<clsNodeObj> arrNodeObj)
        {
            StringBuilder sbXml = new StringBuilder();
            string strClsName = string.Format("clsXmlScript");
            string strObjName = string.Format("objXmlScript");
            sbXml.AppendFormat("{0} {1} = new {0}(); \r\n", strClsName, strObjName);

            foreach (clsNodeObj objInFor in arrNodeObj)
            {
                GeneAndroidXmlScript(objInFor, strObjName, sbXml);
            }

            return sbXml.ToString();
        }
        public static void GeneAndroidXmlScript(clsNodeObj objNodeObj, string strParentObjName, StringBuilder sbXml)
        {
            string strClsName = string.Format("cls{0}", objNodeObj.Name);
            string strObjName = string.Format("obj{0}EN", objNodeObj.Name);
            sbXml.AppendFormat("{0} {1} = new {0}(); \r\n", strClsName, strObjName);

            foreach (string strAttr in objNodeObj.AttributeNames)
            {
                if (objNodeObj.NodeType == "<?")
                {
                    sbXml.AppendFormat("{0}.{1} = {2}; \r\n", strObjName, strAttr, objNodeObj[strAttr]);
                }
                else
                {
                    sbXml.AppendFormat("{0}.{1} = {2};\r\n ", strObjName, strAttr, objNodeObj[strAttr]);
                }
            }
            if (objNodeObj.SubNodeObjLst == null || objNodeObj.AttributeNames.Count == 0)
            {
               
            }
            else
            {              

                foreach (clsNodeObj objInFor in objNodeObj.SubNodeObjLst)
                {
                    GeneAndroidXmlScript(objInFor, strObjName, sbXml);
                }             
            }
            sbXml.AppendFormat("{0}.arrSubAndroidControlLst2.Add({1});\r\n ", strParentObjName, strObjName);
        }

    }
    class clsTagName
    {

    }
}
