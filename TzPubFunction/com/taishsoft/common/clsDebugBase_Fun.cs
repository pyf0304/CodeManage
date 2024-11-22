using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace com.taishsoft.common
{

    public class clsDebugBase_Pub
    {
        private static bool mbolIsDebug = false;
        /// <summary>
        /// 是否Debug,如果Debug许多函数会记录被调用的情况
        /// </summary>
        public static bool IsDebug
        {
            get { return clsDebugBase_Pub.mbolIsDebug; }
            set { clsDebugBase_Pub.mbolIsDebug = value; }
        }

        private static int mintTraceLevel = 0;
        /// <summary>
        /// 跟踪等级
        /// </summary>
        public static int TraceLevel
        {
            get { return clsDebugBase_Pub.mintTraceLevel; }
            set { clsDebugBase_Pub.mintTraceLevel = value; }
        }
        private static clsLog objLog4Debug = null;
        private static string mstrLogFile4Debug = "";
        /// <summary>
        /// 用于Debug的日志文件名
        /// </summary>
        public static string LogFile4Debug
        {
            get { return clsDebugBase_Pub.mstrLogFile4Debug; }
            set { clsDebugBase_Pub.mstrLogFile4Debug = value; }
        }

        private static string mstrLogDir4Debug;		//当前目录4Debug
        /// <summary>
        /// 用于Debug的日志目录
        /// </summary>
        public static string LogDir4Debug
        {
            get { return clsDebugBase_Pub.mstrLogDir4Debug; }
            set { clsDebugBase_Pub.mstrLogDir4Debug = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="strLogContent"></param>
        public static void WriteLog(string strLogContent)
        {
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

            //}
            clsLog_S.WriteDebugLog_S(strLogContent);
        }

    }
}
