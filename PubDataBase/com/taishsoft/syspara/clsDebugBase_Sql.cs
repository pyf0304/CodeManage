using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace com.taishsoft.syspara
{
    /// <summary>
    /// 用于处理Debug的底层类
    /// </summary>
    public class clsDebugBase_Sql
    {
        //保存Log文件数据的队列和线程
        //public static Queue<string> qLogDataLst = null;
        //public static Thread threadSaveLogData = null;
        private static bool mbolIsUseQueue = true;
        //private static bool pbolIsOpenThread = false;
        /// <summary>
        /// 是否使用队列来保存日志
        /// </summary>
        public static bool IsUseQueue
        {
            get { return clsDebugBase_Sql.mbolIsUseQueue; }
            set { clsDebugBase_Sql.mbolIsUseQueue = value; }
        }
        private static bool mbolIsDebug = false;
        /// <summary>
        /// 是否Debug,如果Debug许多函数会记录被调用的情况
        /// </summary>
        public static bool IsDebug
        {
            get { return clsDebugBase_Sql.mbolIsDebug; }
            set { clsDebugBase_Sql.mbolIsDebug = value; }
        }

        private static int mintTraceLevel = 0;
        /// <summary>
        /// 跟踪等级
        /// </summary>
        public static int TraceLevel
        {
            get { return clsDebugBase_Sql.mintTraceLevel; }
            set { clsDebugBase_Sql.mintTraceLevel = value; }
        }
        //private static clsLog objLog4Debug = null;
        private static string mstrLogFile4Debug = "";
        /// <summary>
        /// 用于Debug的日志文件名
        /// </summary>
        public static string LogFile4Debug
        {
            get { return clsDebugBase_Sql.mstrLogFile4Debug; }
            set { clsDebugBase_Sql.mstrLogFile4Debug = value; }
        }

        private static string mstrLogDir4Debug;		//当前目录4Debug
        /// <summary>
        /// 用于Debug的日志目录
        /// </summary>
        public static string LogDir4Debug
        {
            get { return clsDebugBase_Sql.mstrLogDir4Debug; }
            set
            {
                clsDebugBase_Sql.mstrLogDir4Debug = value;
                if (Directory.Exists(value) == false)
                {
                    try
                    {
                        Directory.CreateDirectory(value);
                    }
                    catch(Exception objException)
                    {
                        clsDebugBase_Sql.mbolIsDebug = false;
                    }
                }
            }
        }

        /// <summary>
        /// 写日志内容
        /// </summary>
        /// <param name="strLogContent">需要写的内容</param>
        public static void WriteLog(string strLogContent)
        {
            if (mbolIsUseQueue == true)
            {
                WriteLogByQueue(strLogContent);
                return;
            }
            //if (objLog4Debug == null)
            //{
            //    objLog4Debug = new clsLog();

            //if (string.IsNullOrEmpty(mstrLogDir4Debug) == true)
            //{
            //    mstrLogDir4Debug = @"D:\TaishSoft";
            //}
            if (string.IsNullOrEmpty(mstrLogDir4Debug) == true)
            {
                return;
            }
            clsLog_S.LogDir_S = mstrLogDir4Debug;

            if (string.IsNullOrEmpty(mstrLogFile4Debug) == true)
            {
                mstrLogFile4Debug = @"\LogFile4Debug";
            }
            clsLog_S.LogFileName_S = mstrLogFile4Debug;
            //}
            clsLog_S.WriteDebugLog_S(strLogContent);
        }

        /// <summary>
        /// 写日志内容
        /// </summary>
        /// <param name="strLogContent">需要写的内容</param>
        public static void WriteLogByQueue(string strLogContent)
        {

            //if (objLog4Debug == null)
            //{
            //objLog4Debug = new clsLog();

            //if (string.IsNullOrEmpty(mstrLogDir4Debug) == true)
            //{
            //    mstrLogDir4Debug = @"D:\TaishSoft";
            //}
            if (string.IsNullOrEmpty(mstrLogDir4Debug) == true)
            {
                return;
            }
            clsLog_S.LogDir_S = mstrLogDir4Debug;

            if (string.IsNullOrEmpty(mstrLogFile4Debug) == true)
            {
                mstrLogFile4Debug = @"\LogFile4Debug";
            }
            clsLog_S.LogFileName_S = mstrLogFile4Debug;
            //}
            clsLog_S.WriteDebugLogByQueue(strLogContent);
        }
        ///// <summary>
        ///// 保存Log数据到文件
        ///// </summary>
        //public static void SaveLogDataToFile()
        //{
        //    //string uploadFolder = GetUploadFolder(strSaveFolder, strUserId);
        //    //clsLog.WriteLog2(string.Format("上传目录名：{0}", uploadFolder));
        //    //clsLog.WriteLog2(string.Format("strSaveFolder：{0}", strSaveFolder));
        //    //clsLog.WriteLog2(string.Format("strUserId：{0}", strUserId));
        //    if (qLogDataLst.Count == 0)
        //    {
        //        threadSaveLogData.Suspend();
        //    }
        //    while (true)
        //    {

        //        string strMyData = qLogDataLst.Dequeue();
        //        objLog4Debug.WriteDebugLog(strMyData);
        //        if (qLogDataLst.Count == 0)
        //        {
        //            threadSaveLogData.Suspend();
        //        }
        //    }
        //}

    }
}
