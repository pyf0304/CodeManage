using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.dynamiccompiler
{
    /// <summary>
    /// 动态函数，从程序集中分析得到的函数
    /// </summary>
    public class clsDynamicFunction
    {
        private List<string> arrCommandLine = null;
        private List<object> arrParameters = null;
        private string mstrFuncId;
        private string mstrFunctionName;
        private string mstrFunctionSignature;
        private System.Type mReturnType;
      
        private string mstrFunctionContent;
        private object mobjExecReturn;

        private string mstrNameSpace;
        /// <summary>
        /// 类名
        /// </summary>
        private string mstrClassName;
        /// <summary>
        /// 类名
        /// </summary>
        public string ClassName
        {
            get
            {
                return mstrClassName;
            }

            set
            {
                mstrClassName = value;
            }
        }
        /// <summary>
        /// 域名
        /// </summary>
        public string NameSpace
        {
            get
            {
                return mstrNameSpace;
            }

            set
            {
                mstrNameSpace = value;
            }
        }
        /// <summary>
        /// 程序集文件
        /// </summary>
        private string mAssemblyFile;

        /// <summary>
        /// 程序集类型
        /// </summary>
        private System.Type mAssemblyType;
        public clsDynamicFunction()
        {
            arrCommandLine = new List<string>();
            arrParameters = new List<object>();
        }
        /// <summary>
        /// 添加命令行
        /// </summary>
        /// <param name="strCommandLine">命令行</param>
        /// <returns></returns>
        public bool AddCommandLine(string strCommandLine)
        {
            arrCommandLine.Add(strCommandLine);
            return true;
        }
        /// <summary>
        /// 添加执行的参数
        /// </summary>
        /// <param name="strParameter">执行参数</param>
        /// <returns></returns>
        public bool AddParameter(object strParameter)
        {
            arrParameters.Add(strParameter);
            return true;
        }
        /// <summary>
        /// 函数名
        /// </summary>
        public string FunctionName
        {
            get
            {
                return mstrFunctionName;
            }

            set
            {
                mstrFunctionName = value;
            }
        }
        /// <summary>
        /// 函数签名
        /// </summary>
        public string FunctionSignature
        {
            get
            {
                return mstrFunctionSignature;
            }

            set
            {
                mstrFunctionSignature = value;
            }
        }
        /// <summary>
        /// 函数内容
        /// </summary>
        public string FunctionContent
        {
            get
            {
                return mstrFunctionContent;
            }

            set
            {
                mstrFunctionContent = value;
            }
        }
        /// <summary>
        /// 执行函数返回值
        /// </summary>
        public object ExecReturn
        {
            get
            {
                return mobjExecReturn;
            }

            set
            {
                mobjExecReturn = value;
            }
        }

        public List<object> Parameters
        {
            get
            {
                return arrParameters;
            }

            set
            {
                arrParameters = value;
            }
        }

        public Type ReturnType
        {
            get
            {
                return mReturnType;
            }

            set
            {
                mReturnType = value;
            }
        }

        /// <summary>
        /// 程序集类型，代表某一个类
        /// </summary>
        public Type AssemblyType
        {
            get
            {
                return mAssemblyType;
            }

            set
            {
                mAssemblyType = value;
            }
        }

        /// <summary>
        /// 程序集文件
        /// </summary>
        public string AssemblyFile
        {
            get
            {
                return mAssemblyFile;
            }

            set
            {
                mAssemblyFile = value;
            }
        }

        /// <summary>
        /// 函数Id， 关键字
        /// </summary>
        public string FuncId
        {
            get
            {
                return mstrFuncId;
            }

            set
            {
                mstrFuncId = value;
            }
        }

        public string GenerateCode()
        {
            StringBuilder sb = new StringBuilder();

            //sb.Append("          public string OutPut()");
            sb.Append(mstrFunctionSignature);
            sb.Append(Environment.NewLine);
            sb.Append("          {");
            sb.Append(Environment.NewLine);
            foreach (string strCommandLine in arrCommandLine)
            {
                sb.Append(strCommandLine);
                sb.Append(Environment.NewLine);
            }
            sb.Append(Environment.NewLine);
            sb.Append("          }");
            sb.Append(Environment.NewLine);

            string code = sb.ToString();

            return code;
        }
        /// <summary>
        /// 在函数对象列表中检查是否存在所给的函数对象
        /// </summary>
        /// <param name="arrFunctionObjLst">函数对象列表</param>
        /// <param name="objDynamicFunction">所给的函数对象</param>
        /// <returns>存在就返回True,否则就返回False</returns>
        public static bool IsExistSameFunction(Queue<object> arrFunctionObjLst, clsDynamicFunction objDynamicFunction)
        {
            foreach(object objFunction in arrFunctionObjLst)
            {
                clsDynamicFunction objDynamicFunction_P = (clsDynamicFunction)objFunction;
                if (objDynamicFunction.NameSpace == objDynamicFunction_P.NameSpace
                    && objDynamicFunction.ClassName == objDynamicFunction_P.ClassName
                    && objDynamicFunction.FunctionName == objDynamicFunction_P.FunctionName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
