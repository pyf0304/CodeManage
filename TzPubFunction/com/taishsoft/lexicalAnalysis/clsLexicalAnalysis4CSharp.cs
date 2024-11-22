using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.lexicalAnalysis
{

    public class clsLexicalAnalysis4CSharp:clsLexicalAnalysisBase
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
        "<<=",">>=","=","++","--"};

        private static string[] sstrElementDelimiter = { };

        private static string[] sstrSystemVariable ={};
        private static string[] sstrSystemObjectProperty = { "length" };
        public clsLexicalAnalysis4CSharp(string strCode_In):base(strCode_In)
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
