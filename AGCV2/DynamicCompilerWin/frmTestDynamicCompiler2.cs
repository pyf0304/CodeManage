﻿using com.taishsoft.common;
using CommonTable.Entity;

using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using com.taishsoft.dynamiccompiler;
using AGC.BusinessLogicEx;
using AGC.BusinessLogic;
using MyCalc;

namespace DynamicCompilerWin
{
    public partial class frmTestDynamicCompiler_Calc : Form
    {
        public frmTestDynamicCompiler_Calc()
        {
            InitializeComponent();
            clsCalc.intTimes = 10;
        }
        public void AA()
        {
            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            CompilerParameters cp = new CompilerParameters();
            cp.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            cp.GenerateInMemory = false;
            cp.OutputAssembly = "myasm.dll";

            //CompilerResults result =
            //provider.CompileAssemblyFromSource(cp, sourceCode);
        }
        private void btnDynCompAndExec_Click(object sender, EventArgs e)
        {
            CodeDomProvider objCSharpCodePrivoder = CodeDomProvider.CreateProvider("CSharp");

            //CSharpCodeProvider objCSharpCodePrivoder = new CSharpCodeProvider();

            // 2.ICodeComplier  
            //ICodeCompiler objICodeCompiler = objCSharpCodePrivoder.CreateCompiler();

            // 3.CompilerParameters  
            CompilerParameters objCompilerParameters = new CompilerParameters();
            objCompilerParameters.ReferencedAssemblies.Add("System.dll");
            objCompilerParameters.GenerateExecutable = false;
            objCompilerParameters.GenerateInMemory = true;

            // 4.CompilerResults  
            CompilerResults cr = objCSharpCodePrivoder.CompileAssemblyFromSource(objCompilerParameters, GenerateCode());



            if (cr.Errors.HasErrors)
            {
                Console.WriteLine("编译错误：");
                foreach (CompilerError err in cr.Errors)
                {
                    Console.WriteLine(err.ErrorText);
                }
            }
            else
            {
                // 通过反射，调用HelloWorld的实例  
                Assembly objAssembly = cr.CompiledAssembly;
                object objHelloWorld = objAssembly.CreateInstance("DynamicCodeGenerate.HelloWorld");
                MethodInfo objMI = objHelloWorld.GetType().GetMethod("OutPut");

                string strResult = objMI.Invoke(objHelloWorld, null).ToString();
                lblResult.Text = strResult;
            }

        }

        private void btnDynCompAndExec_ClickBak(object sender, EventArgs e)
        {
            CodeDomProvider objCSharpCodePrivoder = CodeDomProvider.CreateProvider("CSharp");

            //CSharpCodeProvider objCSharpCodePrivoder = new CSharpCodeProvider();

            // 2.ICodeComplier  
            ICodeCompiler objICodeCompiler = objCSharpCodePrivoder.CreateCompiler();

            // 3.CompilerParameters  
            CompilerParameters objCompilerParameters = new CompilerParameters();
            objCompilerParameters.ReferencedAssemblies.Add("System.dll");
            objCompilerParameters.GenerateExecutable = false;
            objCompilerParameters.GenerateInMemory = true;

            // 4.CompilerResults  
            CompilerResults cr = objICodeCompiler.CompileAssemblyFromSource(objCompilerParameters, GenerateCode());



            if (cr.Errors.HasErrors)
            {
                Console.WriteLine("编译错误：");
                foreach (CompilerError err in cr.Errors)
                {
                    Console.WriteLine(err.ErrorText);
                }
            }
            else
            {
                // 通过反射，调用HelloWorld的实例  
                Assembly objAssembly = cr.CompiledAssembly;
                object objHelloWorld = objAssembly.CreateInstance("DynamicCodeGenerate.HelloWorld");
                MethodInfo objMI = objHelloWorld.GetType().GetMethod("OutPut");

                string strResult = objMI.Invoke(objHelloWorld, null).ToString();
                lblResult.Text = strResult;
            }

        }

        private string GenerateCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("using System;");
            sb.Append(Environment.NewLine);
            sb.Append("namespace DynamicCodeGenerate");
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            sb.Append("      public class HelloWorld");
            sb.Append(Environment.NewLine);
            sb.Append("      {");
            sb.Append(Environment.NewLine);
            sb.Append("          public string OutPut()");
            sb.Append(Environment.NewLine);
            sb.Append("          {");
            sb.Append(Environment.NewLine);
            sb.Append("               return \"Hello world!\";");
            sb.Append(Environment.NewLine);
            sb.Append("          }");
            sb.Append(Environment.NewLine);
            sb.Append("      }");
            sb.Append(Environment.NewLine);
            sb.Append("}");

            string code = sb.ToString();
            Console.WriteLine(code);
            Console.WriteLine();

            return code;
        }

        private void btnTestDynamicCompilerClass_Click(object sender, EventArgs e)
        {
            clsDynamicCompiler objDynamicCompiler = new clsDynamicCompiler();
            objDynamicCompiler.NameSpace = "MyTest";
            objDynamicCompiler.ClassName = "Hello";
            clsDynamicFunction objDynamicFunction = new clsDynamicFunction();
            objDynamicFunction.FunctionName = "OutPut";
            objDynamicFunction.FunctionSignature = "public string OutPut()";
            objDynamicFunction.AddCommandLine("string strName=\"Pyf\";");
            objDynamicFunction.AddCommandLine("return string.Format(\"Hello world!{0}\", strName);");
            objDynamicCompiler.AddFunction(objDynamicFunction);
            objDynamicCompiler.CompilerCode();
            objDynamicCompiler.ExecFunction(objDynamicFunction);
            lblResult.Text = objDynamicFunction.ExecReturn.ToString();
        }

        private void btnTestCalc_Click(object sender, EventArgs e)
        {
            clsCalc objCalc = new clsCalc();
            double dblArea = objCalc.Area(10);
            lblResult.Text = dblArea.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsDynamicCompiler objDynamicCompiler = new clsDynamicCompiler();
            objDynamicCompiler.NameSpace = "MyTest";
            objDynamicCompiler.ClassName = "TestCalc";
            objDynamicCompiler.AddReferencedAssemblie("MyCalc.dll");
            objDynamicCompiler.AddUsing("MyCalc");
            clsDynamicFunction objDynamicFunction = new clsDynamicFunction();
            objDynamicFunction.FunctionName = "GetArea";
            objDynamicFunction.FunctionSignature = "public double GetArea(double dblR)";
            objDynamicFunction.AddCommandLine("clsCalc objCalc = new clsCalc();");
            objDynamicFunction.AddCommandLine(" double dblArea = objCalc.Area(dblR);");
            objDynamicFunction.AddCommandLine("return dblArea;");
            objDynamicCompiler.AddFunction(objDynamicFunction);
            objDynamicCompiler.CompilerCode();
            objDynamicFunction.AddParameter(10.0);
            objDynamicCompiler.ExecFunction(objDynamicFunction);
            lblResult.Text = objDynamicFunction.ExecReturn.ToString();
        }
        public void ReFreshCache()
        {
            string strMsg = string.Format("刷新缓存成功！({2}->{1}->{0})",
           clsStackTrace.GetCurrClassFunction(),
           clsStackTrace.GetCurrClassFunctionByLevel(2),
           clsStackTrace.GetCurrClassFunctionByLevel(3));
            clsSysParaEN.objLog.WriteDebugLog(strMsg);
            // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
            clsPrjTabBL.ReFreshThisCache();
            if (clsPrjTabBL.objCommFun4BL != null) clsPrjTabBL.objCommFun4BL.ReFreshCache();
        }

        private void btnTestDynCompiler4CacheInit_Click(object sender, EventArgs e)
        {
            clsDynamicCompiler objDynamicCompiler = new clsDynamicCompiler();
            objDynamicCompiler.NameSpace = "MyTest";
            objDynamicCompiler.ClassName = "AgcCs";
            objDynamicCompiler.AddReferencedAssemblie("TzPubFunction.dll");
            objDynamicCompiler.AddReferencedAssemblie("PubDataBase.dll");
            objDynamicCompiler.AddReferencedAssemblie("CommonTableENDABL.dll");
            objDynamicCompiler.AddReferencedAssemblie("AgcEN.dll");
            objDynamicCompiler.AddReferencedAssemblie("AgcDA.dll");
            objDynamicCompiler.AddReferencedAssemblie("AgcBusinessLogic.dll");
            objDynamicCompiler.AddUsing("com.taishsoft.common");
            objDynamicCompiler.AddUsing("AGC_CSV7.BusinessLogic");
            objDynamicCompiler.AddUsing("CommonTable.Entity");
            clsDynamicFunction objDynamicFunction = new clsDynamicFunction();
            objDynamicFunction.FunctionName = "ReFreshCache";
            //objDynamicFunction.ReturnType = Type.GetType("System.String");
            objDynamicFunction.ReturnType = Type.GetType("void");

            objDynamicFunction.FunctionSignature = "public void ReFreshCache()";
            objDynamicFunction.AddCommandLine("try");
            objDynamicFunction.AddCommandLine("{");
            objDynamicFunction.AddCommandLine("Console.WriteLine(\"执行开始！\");");
            objDynamicFunction.AddCommandLine("clsSysParaEN.objLog = new clsLog();");

            objDynamicFunction.AddCommandLine("clsSysParaEN.objLog.LogDir = @\"D:\\Log\\AgcCs_Win\\\";");
            objDynamicFunction.AddCommandLine("clsSysParaEN.objLog.LogFileName = \"Debug4Win\";");
            objDynamicFunction.AddCommandLine("string strMsg = string.Format(\"刷新缓存成功！({2}->{1}->{0})\",");
            objDynamicFunction.AddCommandLine(" clsStackTrace.GetCurrClassFunction(),");
            objDynamicFunction.AddCommandLine("clsStackTrace.GetCurrClassFunctionByLevel(2),");
            objDynamicFunction.AddCommandLine("clsStackTrace.GetCurrClassFunctionByLevel(3));");
            objDynamicFunction.AddCommandLine("clsSysParaEN.objLog.WriteDebugLog(strMsg);");
            objDynamicFunction.AddCommandLine("// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            objDynamicFunction.AddCommandLine("clsPrjTabBL.ReFreshThisCache();");
            objDynamicFunction.AddCommandLine("if (clsPrjTabBL.objCommFun4BL != null) clsPrjTabBL.objCommFun4BL.ReFreshCache();");
            objDynamicFunction.AddCommandLine("Console.WriteLine(\"执行完成！\");");
            objDynamicFunction.AddCommandLine("}");
            objDynamicFunction.AddCommandLine("catch (Exception objException)");
            objDynamicFunction.AddCommandLine("{");
            objDynamicFunction.AddCommandLine("Console.WriteLine(objException.Message);");
            //    objDynamicFunction.AddCommandLine("MessageBox.Show(objException.Message);");
            objDynamicFunction.AddCommandLine("}");
            objDynamicCompiler.AddFunction(objDynamicFunction);
            objDynamicCompiler.CompilerCode();

            objDynamicCompiler.ExecFunction(objDynamicFunction);
            //lblResult.Text = objDynamicFunction.ExecReturn.ToString();
        }

        private void btnTestCacheInit_Click(object sender, EventArgs e)
        {
            try
            {
                clsSysParaEN.objLog = new clsLog();
                clsSysParaEN.objLog.LogDir = @"D:\Log\AgcCs_Win\";
                clsSysParaEN.objLog.LogFileName = "Debug4Win";
                ReFreshCache();
                Console.WriteLine("执行完成！");
            }
            catch(Exception objException)
            {
                Console.WriteLine(objException.Message);
                MessageBox.Show(objException.Message);
            }
        }

        private void btnInvokeFunctionByStrName_Click(object sender, EventArgs e)
        {
         
            //clsDynamicCompiler objDynamicCompiler = new clsDynamicCompiler();
            //objDynamicCompiler.NameSpace = "MyTest";
            //objDynamicCompiler.ClassName = "TestCalc";
            //objDynamicCompiler.AddReferencedAssemblie("MyCalc.dll");
            //objDynamicCompiler.AddUsing("MyCalc");
            clsDynamicFunction objDynamicFunction = new clsDynamicFunction();
            objDynamicFunction.AssemblyFile = "MyCalc.dll";
            objDynamicFunction.NameSpace = "MyCalc";
            objDynamicFunction.ClassName = "clsCalc";
            objDynamicFunction.AssemblyType = typeof(MyCalc.clsCalc);
            objDynamicFunction.FunctionName = "Area_S";
            //objDynamicCompiler.AddFunction(objDynamicFunction);
            //objDynamicCompiler.CompilerCode();
            objDynamicFunction.AddParameter(10.0);
            try
            {
                clsDynamicCompiler.ExecStaticFunction(objDynamicFunction);
                lblResult.Text = string.Format("intTime={0}, Result={1}", clsCalc.intTimes, objDynamicFunction.ExecReturn.ToString());
            }
            catch(Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnAddCacheInitFunction_Click(object sender, EventArgs e)
        {
            clsPrjTabBL.objCommFun4BL = new clsCommFun4BL4PrjTab();

            clsSysParaEN.spIsUseQueue4Task = true;
            clsPrjTabBL.ReFreshCache();
            clsPrjTabFldBL.ReFreshCache();
            clsPrjTabBL.ReFreshCache();
            clsPrjTabFldBL.ReFreshCache();

//            clsPrjTabBL.ReFreshCache();
            clsPrjTabFldBL.ReFreshCache();
            int intCount = clsSysParaEN.arrFunctionLst4Queue.Count;
        }

        private void btnExecCacheInitFunction_Click(object sender, EventArgs e)
        {
            try
            {
                clsSysParaEN.spIsUseQueue4Task = false;
                clsDynamicCompiler.ExecStaticFunctionLst(clsSysParaEN.arrFunctionLst4Queue);
                MessageBox.Show(clsSysParaEN.arrFunctionLst4Queue.Count.ToString());
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }
    }
}
