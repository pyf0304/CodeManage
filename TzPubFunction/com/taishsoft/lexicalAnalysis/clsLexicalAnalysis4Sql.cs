using com.taishsoft.common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.lexicalAnalysis
{
    public class clsLexicalAnalysis4Sql : clsLexicalAnalysisBase
    {
        private static string[] sstrSystemType ={"var", "function" };
        private static string[] sstrReserveWord ={"abstract","as","base","bool","break","byte","case","catch","char","checked",
        "class","const","continue","decimal","default","do","double","else","enum","event",
        "explicit","extern","false","finally","fixed","float","for","foreach","goto","if",
        "implicit","in","in（泛型修饰符）","int","interface","internal","为","lock","long",
        "命名空间","namespace","new","null","object","operator","out","out（泛型修饰符）","override",
        "params","private","protected","public","readonly","ref","return","sbyte","sealed",
        "short","sizeof","stackalloc","static","string","结构","struct", "switch","this","throw","true",
        "try","typeof","uint","ulong","unchecked","unsafe","ushort","using","virtual","void",
        "volatile","while","function", "select", "from", "delete", "update"};
        private static string[] sstrSystemVariable = { "arguments" };
        private static string[] sstrSystemObjectProperty = { "length","value" };

        private static string[] sstrOperators ={"*","/","%","+","-","<<",">>",
            "<",">","<=",">=",
        "==","!=","&","^","|","&&","||","?", "?:","+=","-=","*=","/=","%=","&=","|=","^=",
        "<<=",">>=","=","++","--", "and", "or"};
        private static string[] sstrElementDelimiter = { };
        public clsLexicalAnalysis4Sql(string strCode_In) :base(strCode_In)
        {
            arrSystemType = new List<string>(sstrSystemType);
            arrReserveWord = new List<string>(sstrReserveWord);
            arrSystemVariableTbl = new List<string>(sstrSystemVariable);
            arrSystemObjectProperty = new List<string>(sstrSystemObjectProperty);
            arrOperators = new List<string>(sstrOperators);
            arrElementDelimiter = new List<string>(sstrElementDelimiter);

            this.mbolIsIgnoreCase = true;
        }
        public static List<clsWord_LA> getWordLst(string strText)
        {
            clsLexicalAnalysis4Sql objLexicalAnalysis4Sql = new clsLexicalAnalysis4Sql(strText);
            //objLexicalAnalysis4Sql.CodeLines = strText.Lines;
            //string strText1 = objLexicalAnalysis4Sql.fnPretreatment();
            //string strCode_Out = null;
            objLexicalAnalysis4Sql.fnAnalyzeV3();
            List<clsWord_LA> arrResultWord = objLexicalAnalysis4Sql.ResultWord;// new List<clsWord_LA>();
//            foreach (clsWord_LA objWord_LA in arrResultWord)
//            {
//                Console.WriteLine(objWord_LA.Word);
////                lbWords.Items.Add(objWord_LA.Word);
//            }
            return arrResultWord;
        }
        public static bool CheckgetWordLst(string strText)
        {
            clsLexicalAnalysis4Sql objLexicalAnalysis4Sql = new clsLexicalAnalysis4Sql(strText);
            //objLexicalAnalysis4Sql.CodeLines = strText.Lines;
            //string strText1 = objLexicalAnalysis4Sql.fnPretreatment();
            //string strCode_Out = null;
            objLexicalAnalysis4Sql.fnAnalyzeV3();
            List<clsWord_LA> arrResultWord = objLexicalAnalysis4Sql.ResultWord;// new List<clsWord_LA>();
                                                                               //            foreach (clsWord_LA objWord_LA in arrResultWord)
                                                                               //            {
                                                                               //                Console.WriteLine(objWord_LA.Word);
                                                                               ////                lbWords.Items.Add(objWord_LA.Word);
                                                                               //            }
            return true;
        }

    }
}
