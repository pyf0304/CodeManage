using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace com.taishsoft.common
{
    /// <summary>
    /// 系统信息跟踪
    /// </summary>
    public class clsStackTrace
    {
        /// <summary>
        /// 获取当前函数名
        /// </summary>
        /// <returns>返回当前函数名</returns>
        public static string GetCurrFunction()
        {
            System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace();
            string strFunctionName = "";// st.GetFrame(0).ToString();
            string strClassName = "";//类名

            string strMsg = "";
            int intCurrLevel = 0;
            foreach (StackFrame frame in trace.GetFrames())
            {
                string strFileName = frame.GetFileName();
                string strMothodName = frame.GetMethod().Name;
                if (frame.GetMethod().DeclaringType == null) break;
                string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                if (intCurrLevel == 1)
                {
                    strFunctionName = strMothodName;
                    strClassName = strDeclaringType;
                    return strFunctionName;
                }
                intCurrLevel++;
            }
            return strFunctionName;
        }
        /// <summary>
        /// 获取当前类名、函数名
        /// </summary>
        /// <returns>返回当前[类名：函数名]</returns>
        public static string GetCurrClassFunction()
        {
            System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace();
            string strFunctionName = "";// st.GetFrame(0).ToString();
            string strClassName = "";//类名

            string strMsg = "";
            int intCurrLevel = 0;
            foreach (StackFrame frame in trace.GetFrames())
            {
                string strFileName = frame.GetFileName();
                string strMothodName = frame.GetMethod().Name;
                if (frame.GetMethod().DeclaringType == null) break;
                string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                if (intCurrLevel == 1)
                {
                    strFunctionName = strMothodName;
                    strClassName = strDeclaringType;
                    return string.Format("{0}:{1}", strClassName, strFunctionName);
                }
                intCurrLevel++;

            }
            return string.Format("{0}:{1}", strClassName, strFunctionName);
        }

        /// <summary>
        /// 根据深度获取当前函数名，例如层为1代表上一层函数名，即调用该函数的函数，父函数，层为2代表上两层函数名，即当前函数的父函数的父函数
        /// </summary>
        /// <returns>返回上n层的函数名</returns>
        public static string GetCurrFunctionByLevel(int intLevel)
        {
            System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace();
            string strFunctionName = "";// st.GetFrame(0).ToString();
            string strClassName = "";//类名

            string strMsg = "";
            int intCurrLevel = 0;
            foreach (StackFrame frame in trace.GetFrames())
            {
                string strFileName = frame.GetFileName();
                string strMothodName = frame.GetMethod().Name;
                if (frame.GetMethod().DeclaringType == null) break;
                string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                if (intCurrLevel == intLevel)
                {
                    strFunctionName = strMothodName;
                    strClassName = strDeclaringType;
                    return strFunctionName;
                }
                intCurrLevel++;
            }
            return strFunctionName;
        }
        /// <summary>
        /// 根据深度获取当前类名、函数名，例如层为1代表上一层函数名，即调用该函数的函数，父函数，层为2代表上两层函数名，即当前函数的父函数的父函数
        /// </summary>
        /// <returns>返回上n层的[类名：函数名]</returns>
        public static string GetCurrClassFunctionByLevel(int intLevel)
        {
            System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace();
            string strFunctionName = "";// st.GetFrame(0).ToString();
            string strClassName = "";//类名

            string strMsg = "";
            int intCurrLevel = 0;
            foreach (StackFrame frame in trace.GetFrames())
            {
                string strFileName = frame.GetFileName();
                string strMothodName = frame.GetMethod().Name;
                if (frame.GetMethod().DeclaringType == null) break;
                string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                if (intCurrLevel == intLevel)
                {
                    strFunctionName = strMothodName;
                    strClassName = strDeclaringType;
                    return string.Format("{0}:{1}", strClassName, strFunctionName);
                }
                intCurrLevel++;

            }
            return string.Format("{0}:{1}", strClassName, strFunctionName);
        }
    }
}
