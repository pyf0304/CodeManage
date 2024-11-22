using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgcCommBase
{

    public class TabProp
    {
        public int KeyFldCount;
        public string FldId;
        public string FldName;
        public string PriVarName;
        public string TypeScriptType;
        public string KeyFldNameLstStr;
        public string PropertyNameLstrStr;
        /// <summary>
        /// 私有变量名定义列表
        /// </summary>
        public string KeyVarDefineLstStr;
        /// <summary>
        /// 私有变量名列表
        /// </summary>
        public string KeyPrivVarNameLstStr;
        /// <summary>
        /// 关键字属性名列表，附加“objKeyLst”, 例如:objKeyLst.prjId,objKeyLst.stuId等
        /// </summary>
        public string KeyPropNameLstStrWithKeyLst;
        public string FuncModuleEnName4GC;
        public string ByInFuncName;
        public string DataTypeId;
        public int FldLength;
        public bool IsNumberType;
    }
   

}
