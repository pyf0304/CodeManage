using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading;
using com.taishsoft.datetime;

namespace com.taishsoft.common
{
    /// <summary>
    /// 日志类
    /// </summary>
    public class clsLog
    {
        //保存Log文件数据的队列和线程
        //private static Queue<string> qLogDataLst = null;
        //public static Thread threadSaveLogData = null;
        //private static bool mbolIsUseQueue = false;
        //private static bool pbolIsOpenThread = false;
        //private static System.Timers.Timer timer;
        private string mstrLogDir = "";

        /// <summary>
        /// 
        /// </summary>
        public clsLog(string strLogDir, string strLogFileName)
        {
            //SetUpTimer();
            if (string.IsNullOrEmpty(strLogDir) == true)
            {
                string strMsg = string.Format("日志目录不能为空，请咨询管理员！({0}==>{1})",
                      clsStackTrace.GetCurrClassFunctionByLevel(2),
                      clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (string.IsNullOrEmpty(strLogFileName) == true)
            {
                string strMsg = string.Format("日志文件名不能为空，请咨询管理员！({0}==>{1})",
                      clsStackTrace.GetCurrClassFunctionByLevel(2),
                      clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            mstrLogDir = strLogDir;
            mstrLogFileName = strLogFileName;
            
        }
        /// <summary>
        /// 日志目录名
        /// </summary>
        protected string LogDir
        {
            get {
                if (string.IsNullOrEmpty(mstrLogDir) == true)
                {
                    //this.LogDir = @"D:\Taishsoft_ErrorLog\";
                    //string strMsg = string.Format("意外:目录为空。（{0}==》{1})",
                    //    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    //    clsStackTrace.GetCurrClassFunction());
                    //LogErrorS2(clsStackTrace.GetCurrClassFunction(),
                    //    clsStackTrace.GetCurrClassFunction(), strMsg,
                    //    "", "");
                }
                return mstrLogDir;
            }
            set
            {
                mstrLogDir = value;
                //if (string.IsNullOrEmpty(mstrLogDir) == true)
                //{
                //    mstrLogDir = @"D:\Taishsoft\";
                //}
                if (string.IsNullOrEmpty(mstrLogDir) == true)
                {
                    return ;
                }

                if (Directory.Exists(mstrLogDir) == false)
                {
                    try
                    {
                        Directory.CreateDirectory(mstrLogDir);
                    }
                    catch(Exception objException)
                    {
                        LogErrorS(objException, "clsLog");
                    }
                }
            }
        }

        private string mstrLogFileName;
        /// <summary>
        /// 日志文件名
        /// </summary>
        protected string LogFileName
        {
            get {
                if (string.IsNullOrEmpty(mstrLogFileName) == true)
                {
                    mstrLogFileName = string.Format("LogError", clsDateTime.getTodayStr(0));
                }
                return mstrLogFileName;
            }
            set
            {
                mstrLogFileName = value;

                if (string.IsNullOrEmpty(mstrLogFileName) == true)
                {
                    mstrLogDir = @"TaishsoftLog.txt";
                }
            }
        }

  
        private string mstrLogFullFileName;
        /// <summary>
        /// 日志的完全文件名，包含目录名。
        /// 姓名：潘以锋
        /// 日期：2010-10-04
        /// </summary>
        public string LogFullFileName
        {
            get
            {
                if (string.IsNullOrEmpty(LogDir) == true)
                {
                    string strMsg = string.Format("日志目录不能为空，请咨询管理员！({0}==>{1})",
                        clsStackTrace.GetCurrClassFunctionByLevel(2),
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }

                if (string.IsNullOrEmpty(LogFileName) == true)
                {
                    string strMsg = string.Format("日志文件名不能为空，请咨询管理员！({0}==>{1})",
                                               clsStackTrace.GetCurrClassFunctionByLevel(2),
                                               clsStackTrace.GetCurrClassFunction());
                    
                    throw new Exception(strMsg);
                }

                string strCurrDate = clsDateTime.getTodayStr(0);
                if (mstrLogDir.Substring(mstrLogDir.Length - 1, 1) == "\\")
                {
                }
                else
                {
                    mstrLogDir += "\\";
                }
                mstrLogFullFileName = mstrLogDir + mstrLogFileName + strCurrDate + ".txt";

                return mstrLogFullFileName;

            }
            //set { mstrLogFullFileName = value; }
        }


    
        /// <summary>
        /// 处理错误日志的函数
        /// </summary>
        /// <param name="objException">异常对象</param>
        /// <param name="strModuleName">模块名称</param>
        public static void LogErrorS(Exception objException, string strModuleName)
        {
            //Log the error information to the Application Log
            string strLogMsg = "";
            try
            {
                strLogMsg = "An error occurred in the following module: "
                    + strModuleName + "Source: " + objException.Source

                    + "Message: " + objException.Message
                    + "Stack Trace:  " + objException.StackTrace

                    + "Target Site:  " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch (Exception objException1)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("时间：{0};\r\n", clsDateTime.getTodayDateTimeStr(0));
                sbMsg.AppendFormat("(ErrorId:1001)写错误日志不成功。原错误信息：{0};\r\n", strLogMsg);
                sbMsg.AppendFormat("错误日志不成功的原因：{0};({1}==>{2})\r\n", 
                    objException1.Message, clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunction());
                WriteLog(sbMsg.ToString());
                //                throw objException1;
            }
        }



        /// <summary>
        /// 处理错误日志的函数
        /// </summary>
        /// <param name="strModuleName">模块名称</param>
        /// <param name="strSource">来源</param>
        /// <param name="strMessage">错误信息</param>
        /// <param name="strStackTrace">跟踪信息</param>
        /// <param name="strTargetSite">目标站点</param>
        public static void LogErrorS3(string strModuleName, string strSource, string strMessage, string strStackTrace, string strTargetSite)
        {
            //Log the error information to the Application Log
            StringBuilder sbLogMsg = new StringBuilder();
            try
            {
                sbLogMsg.Append("一个错误出现!\r\n");
                sbLogMsg.AppendFormat("模块名：{0}.\r\n", strModuleName);
                sbLogMsg.AppendFormat("来源：{0}.\r\n", strSource);
                sbLogMsg.AppendFormat("错误信息：{0}.\r\n", strMessage);
                sbLogMsg.AppendFormat("跟踪信息：{0}.\r\n", strStackTrace);
                sbLogMsg.AppendFormat("站点：{0}.\r\n", strTargetSite);

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, sbLogMsg.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsLog-LogErrorS3");
            }
        }

        /// <summary>
        /// 处理错误日志的函数
        /// </summary>
        /// <param name="strModuleName">模块名称</param>
        /// <param name="strSource">来源</param>
        /// <param name="strMessage">错误信息</param>
        /// <param name="strStackTrace">跟踪信息</param>
        /// <param name="strTargetSite">目标站点</param>
        public static void LogErrorS2(string strModuleName, string strSource, string strMessage, string strStackTrace, string strTargetSite)
        {
            //Log the error information to the Application Log
            StringBuilder sbLogMsg = new StringBuilder();
            try
            {
                sbLogMsg.Append("一个错误出现!\r\n");
                sbLogMsg.AppendFormat("模块名：{0}.\r\n", strModuleName);
                sbLogMsg.AppendFormat("来源：{0}.\r\n", strSource);
                sbLogMsg.AppendFormat("错误信息：{0}.\r\n", strMessage);
                sbLogMsg.AppendFormat("跟踪信息：{0}.\r\n", strStackTrace);
                sbLogMsg.AppendFormat("站点：{0}.\r\n", strTargetSite);

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, sbLogMsg.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
            catch(Exception objException)
            {
                string strSS = objException.Message;
                Console.WriteLine(strSS);
            }
        }

        /// <summary>
        /// 处理提示信息日志的函数
        /// </summary>
        /// <param name="strModuleName">模块名称</param>
        /// <param name="strSource">来源</param>
        /// <param name="strMessage">提示信息</param>
        /// <param name="strStackTrace">跟踪信息</param>
        /// <param name="strTargetSite">目标站点</param>
        /// <param name="bolIsWriteTxtFile">目标站点</param>
        public static void LogInfoS1(string strModuleName, string strSource, string strMessage, string strStackTrace, string strTargetSite, bool bolIsWriteTxtFile)
        {
            //Log the error information to the Application Log
            StringBuilder sbLogMsg = new StringBuilder();
            try
            {
                sbLogMsg.Append("一个信息出现!\r\n");
                sbLogMsg.AppendFormat("模块名：{0}.\r\n", strModuleName);
                sbLogMsg.AppendFormat("来源：{0}.\r\n", strSource);
                sbLogMsg.AppendFormat("提示信息：{0}.\r\n", strMessage);
                sbLogMsg.AppendFormat("跟踪信息：{0}.\r\n", strStackTrace);
                sbLogMsg.AppendFormat("站点：{0}.\r\n", strTargetSite);
                if (bolIsWriteTxtFile)
                {
                    WriteLog(sbLogMsg.ToString());
                }
                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, sbLogMsg.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsLog-LogInfoS1");
            }
        }
        /// <summary>
        /// 写日志内容
        /// </summary>
        /// <param name="strLogContent"></param>
        private static void WriteLog(string strLogContent)
        {
            string strFullLogFileName;	//日志文件名
            string strCurrDir = @"C:\TaishSoftLog";
            if (Directory.Exists(strCurrDir) == false)
            {
                Directory.CreateDirectory(strCurrDir);
            }
            strFullLogFileName = strCurrDir + @"\EventLog4TzPubFunction.txt";
            try
            {
                FileStream fs = new FileStream(strFullLogFileName, FileMode.OpenOrCreate,
                    FileAccess.Write);
                StreamWriter m_streamWriter = new StreamWriter(fs);
                m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
                m_streamWriter.WriteLine("TzPubFunction: " + strLogContent + "\r\n");
                m_streamWriter.Flush();
                m_streamWriter.Close();
                fs.Close();
            }
            catch(Exception objException)
            {
                LogErrorS(objException, "clsLog");
            }
        }
        /// <summary>
        /// 写日志调试内容
        /// 姓名：潘以锋
        /// 日期：2010-10-04
        /// </summary>
        /// <param name="strLogContent"></param>
        public void WriteDebugLog(string strLogContent)
        {
            string strCurrDateTime = clsDateTime.getTodayDateTimeStr(0);
            if (string.IsNullOrEmpty(LogDir) == true)
            {
                string strMsg = string.Format("日志目录不能为空，请咨询管理员！({0}==>{1})",
                      clsStackTrace.GetCurrClassFunctionByLevel(2), 
                      clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            if (string.IsNullOrEmpty(LogFileName) == true)
            {
                string strMsg = string.Format("日志文件名不能为空，请咨询管理员！({0}==>{1})",
                      clsStackTrace.GetCurrClassFunctionByLevel(2), 
                      clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            try
            {

                FileStream fs = new FileStream(LogFullFileName, FileMode.OpenOrCreate,
                    FileAccess.Write);
                StreamWriter m_streamWriter = new StreamWriter(fs);
                m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
                m_streamWriter.WriteLine(strCurrDateTime + ": " + strLogContent + "\r\n");
                m_streamWriter.Flush();
                m_streamWriter.Close();
                fs.Close();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("写LOG文件出错！出错：{0}.", objException.Message);
                StackTrace trace = new StackTrace();
                int intCurrLevel = 0;
                foreach (StackFrame frame in trace.GetFrames())
                {
                    string strFileName = frame.GetFileName();
                    string strMothodName = frame.GetMethod().Name;
                    if (frame.GetMethod().DeclaringType == null) break;
                    string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                    strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                    intCurrLevel++;
                    if (intCurrLevel > clsDebugBase_Pub.TraceLevel) break;
                }
                //throw new Exception(strMsg);
                LogErrorS(objException, "clsLog");
            }
        }

     

    }
}
