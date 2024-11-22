using com.taishsoft.common;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace com.taishsoft.dynamiccompiler
{
    /// <summary>
    /// 动态编译器
    /// </summary>
    public class clsDynamicCompiler
    {
        List<clsDynamicFunction> arrDynamicFunction = null;
        List<string> arrReferencedAssemblies = null;
        List<string> arrUsings = null;
        List<string> arrDefineClassVar = null;
        /// <summary>
        /// 当前的编译结果
        /// </summary>
        public CompilerResults objCompilerResults = null;
        /// <summary>
        /// 当前程序集
        /// </summary>
        public Assembly objAssembly = null;
        private Hashtable htInstance = null;
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
        public clsDynamicCompiler()
        {
            arrDynamicFunction = new List<clsDynamicFunction>();
            arrReferencedAssemblies = new List<string>();
            arrUsings = new List<string>();
            arrDefineClassVar = new List<string>();
            htInstance = new Hashtable();
        }
        /// <summary>
        /// 添加函数
        /// </summary>
        /// <param name="objDynamicFunction"></param>
        /// <returns></returns>
        public bool AddFunction(clsDynamicFunction objDynamicFunction)
        {
            arrDynamicFunction.Add(objDynamicFunction);
            return true;
        }
        /// <summary>
        /// 添加引用的程序集
        /// </summary>
        /// <param name="strReferencedAssemblie"></param>
        /// <returns></returns>
        public bool AddReferencedAssemblie(string strReferencedAssemblie)
        {
            arrReferencedAssemblies.Add(strReferencedAssemblie);
            return true;
        }
        /// <summary>
        /// 添加引用
        /// </summary>
        /// <param name="strUsing"></param>
        /// <returns></returns>
        public bool AddUsing(string strUsing)
        {
            arrUsings.Add(strUsing);
            return true;
        }
        /// <summary>
        /// 添加类变量定义
        /// </summary>
        /// <param name="strDefineClassVar"></param>
        /// <returns></returns>
        public bool AddDefineClassVar(string strDefineClassVar)
        {
            arrDefineClassVar.Add(strDefineClassVar);
            return true;
        }
        public void CompilerCode()
        {
            CodeDomProvider objCSharpCodePrivoder = CodeDomProvider.CreateProvider("CSharp");

            // 2.ICodeComplier  
            //ICodeCompiler objICodeCompiler = objCSharpCodePrivoder.CreateCompiler();

            // 3.CompilerParameters  
            CompilerParameters objCompilerParameters = new CompilerParameters();
            objCompilerParameters.ReferencedAssemblies.Add("System.dll");
            foreach (string strReferencedAssemblie in arrReferencedAssemblies)
            {
                objCompilerParameters.ReferencedAssemblies.Add(strReferencedAssemblie);
            }

            objCompilerParameters.GenerateExecutable = false;
            objCompilerParameters.GenerateInMemory = true;

            // 4.CompilerResults  
            objCompilerResults = objCSharpCodePrivoder.CompileAssemblyFromSource(objCompilerParameters, GenerateCode());

            if (objCompilerResults.Errors.HasErrors)
            {
                StringBuilder sbCompilerError = new StringBuilder();
                sbCompilerError.Append("编译错误：");
                sbCompilerError.Append(Environment.NewLine);
                Console.WriteLine("编译错误：");
                foreach (CompilerError err in objCompilerResults.Errors)
                {
                    Console.WriteLine(err.ErrorText);
                    sbCompilerError.Append(err.ErrorText);
                    sbCompilerError.Append(Environment.NewLine);

                }
                throw new Exception(sbCompilerError.ToString());
            }
            else
            {
                //// 通过反射，调用HelloWorld的实例  
                //Assembly objAssembly = objCompilerResults.CompiledAssembly;
                //object objHelloWorld = objAssembly.CreateInstance("DynamicCodeGenerate.HelloWorld");
                //MethodInfo objMI = objHelloWorld.GetType().GetMethod("OutPut");

                //Console.WriteLine(objMI.Invoke(objHelloWorld, null));
            }

            //Console.ReadLine();
        }
        /// <summary>
        /// 执行函数
        /// </summary>
        /// <param name="objDynamicFunction"></param>
        /// <returns></returns>
        public object ExecFunction(clsDynamicFunction objDynamicFunction)
        {
            string strMsg = "";
        
            if (objCompilerResults.Errors.HasErrors)
            {
                StringBuilder sbCompilerError = new StringBuilder();
                sbCompilerError.Append("编译错误：");
                sbCompilerError.Append(Environment.NewLine);
                foreach (CompilerError err in objCompilerResults.Errors)
                {
                    sbCompilerError.Append(err.ErrorText);
                    sbCompilerError.Append(Environment.NewLine);
                }
                sbCompilerError.AppendFormat("({0}->{1})", 
                    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(sbCompilerError.ToString());
            }
            objAssembly = objCompilerResults.CompiledAssembly;
            string strMyClassName = string.Format("{0}.{1}", mstrNameSpace, mstrClassName);
            object objMyInstance = htInstance[strMyClassName];
            if (objMyInstance == null)
            {
                objMyInstance = objAssembly.CreateInstance(strMyClassName);
                if (objMyInstance != null)
                {
                    htInstance.Add(strMyClassName, objMyInstance);
                }
            }
            if (objMyInstance == null)
            {
                strMsg = string.Format("在当前程序集中，不能建立：[{0}]的实例。({1}->{2})", 
                    strMyClassName,
                    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            MethodInfo objMI = objMyInstance.GetType().GetMethod(objDynamicFunction.FunctionName);
            if (objMI == null)
            {
                strMsg = string.Format("在当前程序集中，不能发现函数：[{0}]！({1}->{2})",
                    objDynamicFunction.FunctionName,
                    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            object objReturn = null;
            try
            {
                if (objDynamicFunction.Parameters.Count > 0)
                {
                    object[] args = new object[objDynamicFunction.Parameters.Count];
                    int intIndex = 0;
                    foreach (object objParameter in objDynamicFunction.Parameters)
                    {
                        args[intIndex] = objParameter;
                        intIndex++;
                    }
                    objReturn = objMI.Invoke(objMyInstance, args).ToString();
                }
                else
                {
                    //                    strReturn = objMI.Invoke(objHelloWorld, null).ToString();
                    objReturn = objMI.Invoke(objMyInstance, null);
                }
                //return objReturn;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("发生错误:{0}({1}->{2})",
                    objException.Message,
                    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            objDynamicFunction.ExecReturn = objReturn;
            return objReturn;

        }
        public static bool ExecStaticFunctionLst(Queue<object> arrFunctionLst4Queue)
        {
            while (arrFunctionLst4Queue.Count > 0)
            {
                object objFunction = arrFunctionLst4Queue.Dequeue();
                clsDynamicFunction objDynamicFunction = (clsDynamicFunction)objFunction;
                ExecStaticFunction(objDynamicFunction);

                //string str = que.Dequeue();
                //Console.WriteLine("出队列-{0}", str);
            }
            return true;
        }
        /// <summary>
        /// 执行类的静态的方法
        /// </summary>
        /// <param name="objDynamicFunction"></param>
        /// <returns></returns>
        public static object ExecStaticFunction(clsDynamicFunction objDynamicFunction)
        {
            string strMsg = "";
            object objReturn = null;
            try
            {
                Type _Type = null;
                if (objDynamicFunction.AssemblyType != null)
                {
                    _Type = objDynamicFunction.AssemblyType;
                }
                else
                {
                    Assembly asmb = Assembly.LoadFrom("MyCalc.dll");
                    string strMyClassName = string.Format("{0}.{1}", objDynamicFunction.NameSpace, objDynamicFunction.ClassName);
                    _Type = asmb.GetType(strMyClassName);
                }
                //Type _Type1 = typeof(MyCalc.clsCalc);
                //Type _Type2 = asmb.GetType(_Type.FullName,true);
                //Type[] _AllType1 = _WebServiceAssembly.GetTypes();//.GetType("EduHigh_WS.StudentInfoExService");
                //Type _Type_1 = _AllType1[0];
                //txtFileName4GenCode.Text = _Type.FullName;
                //MethodInfo[] _AllMethod = _Type.GetMethods();
                MethodInfo objMI = _Type.GetMethod(objDynamicFunction.FunctionName);
                if (objMI == null)
                {
                    strMsg = string.Format("在当前程序集中，不能发现函数：[{0}]！({1}->{2})",
                        objDynamicFunction.FunctionName,
                        clsStackTrace.GetCurrClassFunctionByLevel(2),
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                if (objDynamicFunction.Parameters.Count > 0)
                {
                    object[] args = new object[objDynamicFunction.Parameters.Count];
                    int intIndex = 0;
                    foreach (object objParameter in objDynamicFunction.Parameters)
                    {
                        args[intIndex] = objParameter;
                        intIndex++;
                    }
                    objReturn = objMI.Invoke(null, args).ToString();
                }
                else
                {
                    //                    strReturn = objMI.Invoke(objHelloWorld, null).ToString();
                    objReturn = objMI.Invoke(null, null);
                }
                //return objReturn;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("发生错误:{0}({1}->{2})",
                    objException.Message,
                    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            objDynamicFunction.ExecReturn = objReturn;
            return objReturn;


        }

        /// <summary>
        /// 执行类的实例（对象）方法
        /// </summary>
        /// <param name="objDynamicFunction"></param>
        /// <returns></returns>
        public static object ExecInstanceFunction(clsDynamicFunction objDynamicFunction)
        {
            string strMsg = "";
            object objReturn = null;
            try
            {
                //通过反射来执行类的静态方法
                //Type tx = typeof(ConsoleApplication1.Program);
                //MethodInfo mf = tx.GetMethod("Display", BindingFlags.NonPublic | BindingFlags.Static, null, new Type[] { }, null);
                //string saf = (string)mf.Invoke(null, null);

                //Console.WriteLine(saf);

                //Console.ReadKey();


                ////通过反射来执行类的实例方法
                ////string[] str = new string[2];
                //Program p1 = new Program();
                //Type t = p1.GetType();
                ////因为此句我分析好久
                //MethodInfo mi = t.GetMethod("Spec", BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { }, null);

                ////通过反射执行ReturnAutoID方法，返回AutoID值
                //string strx = mi.Invoke(p1, null).ToString();
                //Console.WriteLine(strx);
                //Console.ReadKey();
                Assembly asmb = Assembly.LoadFrom("MyCalc.dll");
                string strMyClassName = string.Format("{0}.{1}", objDynamicFunction.NameSpace, objDynamicFunction.ClassName);
                Type _Type = asmb.GetType(strMyClassName);
              
                //Type _Type1 = typeof(MyCalc.clsCalc);
                //Type _Type2 = asmb.GetType(_Type.FullName,true);
                //Type[] _AllType1 = _WebServiceAssembly.GetTypes();//.GetType("EduHigh_WS.StudentInfoExService");
                //Type _Type_1 = _AllType1[0];
                //txtFileName4GenCode.Text = _Type.FullName;
                MethodInfo[] _AllMethod = _Type.GetMethods();
                MethodInfo objMI = _Type.GetMethod(objDynamicFunction.FunctionName);
                if (objMI == null)
                {
                    strMsg = string.Format("在当前程序集中，不能发现函数：[{0}]！({1}->{2})",
                        objDynamicFunction.FunctionName,
                        clsStackTrace.GetCurrClassFunctionByLevel(2),
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                if (objDynamicFunction.Parameters.Count > 0)
                {
                    object[] args = new object[objDynamicFunction.Parameters.Count];
                    int intIndex = 0;
                    foreach (object objParameter in objDynamicFunction.Parameters)
                    {
                        args[intIndex] = objParameter;
                        intIndex++;
                    }
                    objReturn = objMI.Invoke(null, args).ToString();
                }
                else
                {
                    //                    strReturn = objMI.Invoke(objHelloWorld, null).ToString();
                    objReturn = objMI.Invoke(null, null);
                }
                //return objReturn;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("发生错误:{0}({1}->{2})",
                    objException.Message,
                    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            objDynamicFunction.ExecReturn = objReturn;
            return objReturn;


        }
        
        public string GenerateCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("using System;");
            sb.Append(Environment.NewLine);
            foreach (string strUsing in arrUsings)
            {
                sb.AppendFormat("using {0};", strUsing);
                sb.Append(Environment.NewLine);
            }
            sb.AppendFormat("namespace {0}", mstrNameSpace);
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);

            sb.AppendFormat("      public class {0}", mstrClassName);
            sb.Append(Environment.NewLine);
            sb.Append("      {");
            sb.Append(Environment.NewLine);
            foreach (string strDefineClassVar in arrDefineClassVar)
            {
                sb.AppendFormat("{0}", strDefineClassVar);
                sb.Append(Environment.NewLine);
            }
            foreach (clsDynamicFunction objDynamicFunction in arrDynamicFunction)
            {
                string strFuncCode = objDynamicFunction.GenerateCode();
                sb.Append(strFuncCode);
            }
            sb.Append(Environment.NewLine);
            sb.Append("      }");
            sb.Append(Environment.NewLine);
            sb.Append("}");

            string code = sb.ToString();
            Console.WriteLine(code);
            //Console.WriteLine();
            return code;
        }
        public static object ExecStaticFunctionBak20170526(clsDynamicFunction objDynamicFunction)
        {

            object objReturn = null;
            try
            {
                //Type tx = typeof(ConsoleApplication1.Program);
                //MethodInfo mf = tx.GetMethod("Display", BindingFlags.NonPublic | BindingFlags.Static, null, new Type[] { }, null);
                //string saf = (string)mf.Invoke(null, null);

                //Console.WriteLine(saf);

                //Console.ReadKey();


                ////通过反射来执行类的实例方法
                ////string[] str = new string[2];
                //Program p1 = new Program();
                //Type t = p1.GetType();
                ////因为此句我分析好久
                //MethodInfo mi = t.GetMethod("Spec", BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { }, null);

                ////通过反射执行ReturnAutoID方法，返回AutoID值
                //string strx = mi.Invoke(p1, null).ToString();
                //Console.WriteLine(strx);
                //Console.ReadKey();
                Assembly asmb = Assembly.LoadFrom("MyCalc.dll");
                string strMyClassName = string.Format("{0}.{1}", objDynamicFunction.NameSpace, objDynamicFunction.ClassName);
                Type _Type = asmb.GetType(strMyClassName);
                //Type _Type1 = typeof(MyCalc.clsCalc);
                //Type _Type2 = asmb.GetType(_Type.FullName,true);
                //Type[] _AllType1 = _WebServiceAssembly.GetTypes();//.GetType("EduHigh_WS.StudentInfoExService");
                //Type _Type_1 = _AllType1[0];
                //txtFileName4GenCode.Text = _Type.FullName;
                MethodInfo[] _AllMethod = _Type.GetMethods();
                MethodInfo objMI = _Type.GetMethod(objDynamicFunction.FunctionName);

                if (objDynamicFunction.Parameters.Count > 0)
                {
                    object[] args = new object[objDynamicFunction.Parameters.Count];
                    int intIndex = 0;
                    foreach (object objParameter in objDynamicFunction.Parameters)
                    {
                        args[intIndex] = objParameter;
                        intIndex++;
                    }
                    objReturn = objMI.Invoke(null, args).ToString();
                }
                else
                {
                    //                    strReturn = objMI.Invoke(objHelloWorld, null).ToString();
                    objReturn = objMI.Invoke(null, null);
                }
                //return objReturn;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("发生错误:{0}({1}->{2})",
                    objException.Message,
                    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            objDynamicFunction.ExecReturn = objReturn;
            return objReturn;


        }

    }
}