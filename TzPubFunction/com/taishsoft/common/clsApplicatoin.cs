using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace com.taishsoft.common
{
    /// <summary>
    /// 
    /// </summary>
    public class clsApplicatoin
    {
        private static string mstrApplicationName; //当前应用程序名；


        /// <summary>
        /// 当前应用程序名，需要设置后才能显示
        /// </summary>
        public static string ApplicationName
        {
            get
            {
                if (string.IsNullOrEmpty(clsApplicatoin.mstrApplicationName) == true)
                {
                    throw new Exception("当前应用程序名还没有被设置！");
                }
                return clsApplicatoin.mstrApplicationName;
            }
            set { clsApplicatoin.mstrApplicationName = value; }
        }
        private static string mstrExecutablePath;

        /// <summary>
        /// 获取当前执行文件所在的路径名称（当前应用程序所在的子目录名称）
        /// </summary>
        public static string ExecutablePath
        {
            get {
                if (clsApplicatoin.mstrExecutablePath == null)
                {
                    clsApplicatoin.mstrExecutablePath = AppPath();
                    return clsApplicatoin.mstrExecutablePath;
                }
                return clsApplicatoin.mstrExecutablePath; }
            set { clsApplicatoin.mstrExecutablePath = value; }
        }

        /// <summary>
        /// 获取当前主机的IP地址
        /// </summary>
        /// <returns></returns>
        public static string GetAddressIP()
        {
            string server = Dns.GetHostName();
            IPHostEntry heserver = Dns.GetHostEntry(server);
            return heserver.AddressList[0].ToString();
        }
        /// <summary>
        /// 获取当前主机的IP地址
        /// </summary>
        /// <returns></returns>
        public static string GetAddressIP4()
        {
            string strIP = "";
            string server = Dns.GetHostName();
            IPHostEntry heserver = Dns.GetHostEntry(server);
            foreach (IPAddress myip in heserver.AddressList)
            {
                string[] sstrTemp = myip.ToString().Split('.');
                if (sstrTemp.Length == 4)
                {
                    strIP = myip.ToString();
                    if (strIP.Length>30)
                    {
                        return strIP.Substring(0, 30);
                    }
                    else
                    {
                        return strIP;
                    }
                }
            }
            strIP = heserver.AddressList[4].ToString();
            if (strIP.Length > 30)
            {
                return strIP.Substring(0, 30);
            }
            else
            {
                return strIP;
            }
        }
        /// <summary>
        /// 获取当前执行文件所在的路径名称（当前应用程序所在的子目录名称）
        /// </summary>
        /// <returns></returns>
        public static string AppPath()
        {
            return System.Windows.Forms.Application.StartupPath;
        }
    }
}
