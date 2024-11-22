using com.taishsoft.common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.lexicalAnalysis
{
    public class clsLexicalAnalysis4Js : clsLexicalAnalysisBase
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
        "volatile","while","function"};
        private static string[] sstrSystemVariable = { "arguments" };
        private static string[] sstrSystemObjectProperty = { "length","value" };
        private static string[] sstrOperators ={"*","/","%","+","-","<<",">>",
            "<",">","<=",">=",
        "==","!=","&","^","|","&&","||","?", "?:","+=","-=","*=","/=","%=","&=","|=","^=",
        "<<=",">>=","=","++","--"};
        private static string[] sstrElementDelimiter = { };
        public clsLexicalAnalysis4Js(string strCode_In) :base(strCode_In)
        {
            arrSystemType = new List<string>(sstrSystemType);
            arrReserveWord = new List<string>(sstrReserveWord);
            arrSystemVariableTbl = new List<string>(sstrSystemVariable);
            arrSystemObjectProperty = new List<string>(sstrSystemObjectProperty);
            arrOperators = new List<string>(sstrOperators);
            arrElementDelimiter = new List<string>(sstrElementDelimiter);

        }

    }
}
