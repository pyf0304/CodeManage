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
    /// ��־��
    /// </summary>
    public class clsLog_S
    {
        //����Log�ļ����ݵĶ��к��߳�
        private static Queue<string> qLogDataLst = null;
        //public static Thread threadSaveLogData = null;
        //private static bool mbolIsUseQueue = false;
        //private static bool pbolIsOpenThread = false;
        private static System.Timers.Timer timer;
        private string mstrLogDir = "";
        private static string mstrLogDir_S = "";
        private static Mutex objMutex = null;
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <summary>
        ///// ��־Ŀ¼��
        ///// </summary>
        //public string LogDir
        //{
        //    get { return mstrLogDir; }
        //    set
        //    {
        //        mstrLogDir = value;
        //        if (string.IsNullOrEmpty(mstrLogDir) == true)
        //        {
        //            mstrLogDir = @"D:\Taishsoft\";
        //        }
        //        if (Directory.Exists(mstrLogDir) == false)
        //        {
        //            Directory.CreateDirectory(mstrLogDir);
        //        }
        //    }
        //}

        /// <summary>
        /// ��־Ŀ¼��
        /// </summary>
        public static string LogDir_S
        {
            get { return mstrLogDir_S; }
            set
            {
                mstrLogDir_S = value;
                //if (string.IsNullOrEmpty(mstrLogDir_S) == true)
                //{
                //    mstrLogDir_S = @"D:\Taishsoft\";
                //}
                if (string.IsNullOrEmpty(mstrLogDir_S) == true)
                {
                    return;
                }
                if (Directory.Exists(mstrLogDir_S) == false)
                {
                    Directory.CreateDirectory(mstrLogDir_S);
                }
            }
        }

        //private string mstrLogFileName;
        ///// <summary>
        ///// ��־�ļ���
        ///// </summary>
        //public string LogFileName
        //{
        //    get { return mstrLogFileName; }
        //    set
        //    {
        //        mstrLogFileName = value;

        //        if (string.IsNullOrEmpty(mstrLogFileName) == true)
        //        {
        //            mstrLogDir = @"TaishsoftLog.txt";
        //        }
        //    }
        //}

        private static string mstrLogFileName_S;
        /// <summary>
        /// ��־�ļ���
        /// </summary>
        public static string LogFileName_S
        {
            get { return mstrLogFileName_S; }
            set
            {
                mstrLogFileName_S = value;

                if (string.IsNullOrEmpty(mstrLogFileName_S) == true)
                {
                    mstrLogDir_S = @"TaishsoftLog.txt";
                }
            }
        }
        //private string mstrLogFullFileName;
        ///// <summary>
        ///// ��־����ȫ�ļ���������Ŀ¼����
        ///// ���������Է�
        ///// ���ڣ�2010-10-04
        ///// </summary>
        //public string LogFullFileName
        //{
        //    get
        //    {
        //        string strCurrDate = clsDateTime.getTodayStr(0);
        //        if (mstrLogDir.Substring(mstrLogDir.Length - 1, 1) == "\\")
        //        {
        //        }
        //        else
        //        {
        //            mstrLogDir += "\\";
        //        }
        //        mstrLogFullFileName = mstrLogDir + mstrLogFileName + strCurrDate + ".txt";

        //        return mstrLogFullFileName;

        //    }
        //    //set { mstrLogFullFileName = value; }
        //}


        private static string mstrLogFullFileName_S;
        /// <summary>
        /// ��־����ȫ�ļ���������Ŀ¼����
        /// ���������Է�
        /// ���ڣ�2010-10-04
        /// </summary>
        public static string LogFullFileName_S
        {
            get
            {
                string strCurrDate = clsDateTime.getTodayStr(0);
                if (mstrLogDir_S.Substring(mstrLogDir_S.Length - 1, 1) == "\\")
                {
                }
                else
                {
                    mstrLogDir_S += "\\";
                }
                mstrLogFullFileName_S = mstrLogDir_S + mstrLogFileName_S + strCurrDate + ".txt";

                return mstrLogFullFileName_S;

            }
            //set { mstrLogFullFileName = value; }
        }

        /// <summary>
        /// ���������־�ĺ���
        /// </summary>
        /// <param name="objException">�쳣����</param>
        /// <param name="strModuleName">ģ������</param>
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
                sbMsg.AppendFormat("ʱ�䣺{0};\r\n", clsDateTime.getTodayDateTimeStr(0));
                sbMsg.AppendFormat("(ErrorId:1002)д������־���ɹ���ԭ������Ϣ��{0};\r\n", strLogMsg);
                sbMsg.AppendFormat("������־���ɹ���ԭ��{0};({1}==>{2})\r\n", 
                    objException1.Message,
                    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunction());
                WriteLog(sbMsg.ToString());
                //                throw objException1;
            }
        }



        /// <summary>
        /// ���������־�ĺ���
        /// </summary>
        /// <param name="strModuleName">ģ������</param>
        /// <param name="strSource">��Դ</param>
        /// <param name="strMessage">������Ϣ</param>
        /// <param name="strStackTrace">������Ϣ</param>
        /// <param name="strTargetSite">Ŀ��վ��</param>
        public static void LogErrorS3(string strModuleName, string strSource, string strMessage, string strStackTrace, string strTargetSite)
        {
            //Log the error information to the Application Log
            StringBuilder sbLogMsg = new StringBuilder();
            try
            {
                sbLogMsg.Append("һ���������!\r\n");
                sbLogMsg.AppendFormat("ģ������{0}.\r\n", strModuleName);
                sbLogMsg.AppendFormat("��Դ��{0}.\r\n", strSource);
                sbLogMsg.AppendFormat("������Ϣ��{0}.\r\n", strMessage);
                sbLogMsg.AppendFormat("������Ϣ��{0}.\r\n", strStackTrace);
                sbLogMsg.AppendFormat("վ�㣺{0}.\r\n", strTargetSite);

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, sbLogMsg.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsLog-LogErrorS3");
            }
        }

        /// <summary>
        /// ������ʾ��Ϣ��־�ĺ���
        /// </summary>
        /// <param name="strModuleName">ģ������</param>
        /// <param name="strSource">��Դ</param>
        /// <param name="strMessage">��ʾ��Ϣ</param>
        /// <param name="strStackTrace">������Ϣ</param>
        /// <param name="strTargetSite">Ŀ��վ��</param>
        /// <param name="bolIsWriteTxtFile">Ŀ��վ��</param>
        public static void LogInfoS1(string strModuleName, string strSource, string strMessage, string strStackTrace, string strTargetSite, bool bolIsWriteTxtFile)
        {
            //Log the error information to the Application Log
            StringBuilder sbLogMsg = new StringBuilder();
            try
            {
                sbLogMsg.Append("һ����Ϣ����!\r\n");
                sbLogMsg.AppendFormat("ģ������{0}.\r\n", strModuleName);
                sbLogMsg.AppendFormat("��Դ��{0}.\r\n", strSource);
                sbLogMsg.AppendFormat("��ʾ��Ϣ��{0}.\r\n", strMessage);
                sbLogMsg.AppendFormat("������Ϣ��{0}.\r\n", strStackTrace);
                sbLogMsg.AppendFormat("վ�㣺{0}.\r\n", strTargetSite);
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
        /// д��־����
        /// </summary>
        /// <param name="strLogContent"></param>
        private static void WriteLog(string strLogContent)
        {
            string strFullLogFileName;	//��־�ļ���
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

            }
        }
        ///// <summary>
        ///// д��־��������
        ///// ���������Է�
        ///// ���ڣ�2010-10-04
        ///// </summary>
        ///// <param name="strLogContent"></param>
        //public void WriteDebugLog(string strLogContent)
        //{
        //    string strCurrDateTime = clsDateTime.getTodayDateTimeStr(0);
        //    try
        //    {

        //        FileStream fs = new FileStream(LogFullFileName, FileMode.OpenOrCreate,
        //            FileAccess.Write);
        //        StreamWriter m_streamWriter = new StreamWriter(fs);
        //        m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
        //        m_streamWriter.WriteLine(strCurrDateTime + ": " + strLogContent + "\r\n");
        //        m_streamWriter.Flush();
        //        m_streamWriter.Close();
        //        fs.Close();
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("дLOG�ļ���������{0}.", objException.Message);
        //        StackTrace trace = new StackTrace();
        //        int intCurrLevel = 0;
        //        foreach (StackFrame frame in trace.GetFrames())
        //        {
        //            string strFileName = frame.GetFileName();
        //            string strMothodName = frame.GetMethod().Name;
        //            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
        //            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
        //            intCurrLevel++;
        //            if (intCurrLevel > clsDebugBase_Pub.TraceLevel) break;
        //        }
        //        throw new Exception(strMsg);
        //    }
        //}

        /// <summary>
        /// д��־��������
        /// ���������Է�
        /// ���ڣ�2010-10-04
        /// </summary>
        /// <param name="strLogContent"></param>
        public static void WriteDebugLog_S(string strLogContent)
        {
            string strCurrDateTime = clsDateTime.getTodayDateTimeStr(0);
            try
            {

                FileStream fs = new FileStream(LogFullFileName_S, FileMode.OpenOrCreate,
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
                string strMsg = string.Format("дLOG�ļ���������{0}.", objException.Message);
                StackTrace trace = new StackTrace();
                int intCurrLevel = 0;
                foreach (StackFrame frame in trace.GetFrames())
                {
                    string strFileName = frame.GetFileName();
                    string strMothodName = frame.GetMethod().Name;
                    if (frame.GetMethod().DeclaringType == null) break;
                    string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                    strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                    intCurrLevel++;
                    if (intCurrLevel > clsDebugBase_Pub.TraceLevel) break;
                }
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// д��־��������
        /// ���������Է�
        /// ���ڣ�2010-10-04
        /// </summary>
        public static void FlushDebugLogByQueue()
        {
            bool bolIsRelease = false;
            string strCurrDateTime = clsDateTime.getTodayDateTimeStr(0);
            try
            {
            
                if (qLogDataLst.Count == 0)
                {
                    return;
                }
              
                FileStream fs = new FileStream(LogFullFileName_S, FileMode.OpenOrCreate,
                    FileAccess.Write);
                StreamWriter m_streamWriter = new StreamWriter(fs);
                m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
                objMutex.WaitOne();
                bolIsRelease = false;
                string strMyData = strCurrDateTime + "_Q: �������м�¼��" + qLogDataLst.Count.ToString() + "\r\n";
                m_streamWriter.WriteLine(strMyData);
                while (true)
                {

                    strMyData = qLogDataLst.Dequeue();
                    //objLog4Debug.WriteDebugLog(strMyData);
                    m_streamWriter.WriteLine(strMyData);
                    if (qLogDataLst.Count == 0)
                    {
                        break;
                    }
                }
                objMutex.ReleaseMutex();
                bolIsRelease = true;
                m_streamWriter.Flush();
                m_streamWriter.Close();
                fs.Close();
              
            }
            catch (Exception objException)
            {
                if (bolIsRelease == false)
                {
                    objMutex.ReleaseMutex();
                    bolIsRelease = true;
                }
                string strMsg = string.Format("дLOG�ļ���������{0}.", objException.Message);
                StackTrace trace = new StackTrace();
                int intCurrLevel = 0;
                foreach (StackFrame frame in trace.GetFrames())
                {
                    string strFileName = frame.GetFileName();
                    string strMothodName = frame.GetMethod().Name;
                    if (frame.GetMethod().DeclaringType == null) break;
                    string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                    strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                    intCurrLevel++;
                    if (intCurrLevel > clsDebugBase_Pub.TraceLevel) break;
                }
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// д��־��������
        /// ���������Է�
        /// ���ڣ�2010-10-04
        /// </summary>
        /// <param name="strLogContent"></param>
        public static void WriteDebugLogByQueue(string strLogContent)
        {
       
            string strCurrDateTime = clsDateTime.getTodayDateTimeStr(0);
            try
            {

                //FileStream fs = new FileStream(LogFullFileName, FileMode.OpenOrCreate,
                //    FileAccess.Write);
                //StreamWriter m_streamWriter = new StreamWriter(fs);
                //m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
                if (objMutex == null)
                {
                    objMutex = new Mutex();
                }
                objMutex.WaitOne();
          
                if (timer == null)
                {
                    SetUpTimer();
                }
                if (qLogDataLst == null)
                {
                    qLogDataLst = new Queue<string>();
                }
                if (qLogDataLst.Count <= 1000)
                {
                    string strMyData = strCurrDateTime + "_Q: " + strLogContent + "\r\n";

                    qLogDataLst.Enqueue(strMyData);
                }
                objMutex.ReleaseMutex();
           
                //m_streamWriter.Flush();
                //m_streamWriter.Close();
                //fs.Close();
            }
            catch (Exception objException)
            {
               
                string strMsg = string.Format("��Ϣ�����г�������{0}.", objException.Message);
                StackTrace trace = new StackTrace();
                int intCurrLevel = 0;
                foreach (StackFrame frame in trace.GetFrames())
                {
                    string strFileName = frame.GetFileName();
                    string strMothodName = frame.GetMethod().Name;
                    if (frame.GetMethod().DeclaringType == null) break;
                    string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                    strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                    intCurrLevel++;
                    if (intCurrLevel > clsDebugBase_Pub.TraceLevel) break;
                }
                throw new Exception(strMsg);
            }
        }

        private static void SetUpTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Start();

            WriteLog("Timer Has Begin Work! " + clsDateTime.getTodayDateTimeStr(0));

        }

        private static void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            System.DateTime dtCurrTime = System.DateTime.Now;


            //foreach (DateTime dtTime in arrRunTime)
            //{
            //    if (dtTime.Hour == dtCurrTime.Hour
            //        && dtTime.Minute == dtCurrTime.Minute)
            //    {
            //WriteLog("Copy Data Started " + clsDateTime.getTodayDateTimeStr(0));
            if (qLogDataLst == null || qLogDataLst.Count == 0) return;
            timer.Enabled = false;
           
            try
            {
                FlushDebugLogByQueue();
            }
            catch(Exception objException)
            {
                LogErrorS(objException, "clsLog-timer_Elapsed");
            }
            timer.Enabled = true;
            //WriteLog("Copy Data Finished " + clsDateTime.getTodayDateTimeStr(0));
            //    }
            //}
        }

    }
}
