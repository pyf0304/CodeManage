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
        private static string mstrApplicationName; //��ǰӦ�ó�������


        /// <summary>
        /// ��ǰӦ�ó���������Ҫ���ú������ʾ
        /// </summary>
        public static string ApplicationName
        {
            get
            {
                if (string.IsNullOrEmpty(clsApplicatoin.mstrApplicationName) == true)
                {
                    throw new Exception("��ǰӦ�ó�������û�б����ã�");
                }
                return clsApplicatoin.mstrApplicationName;
            }
            set { clsApplicatoin.mstrApplicationName = value; }
        }
        private static string mstrExecutablePath;

        /// <summary>
        /// ��ȡ��ǰִ���ļ����ڵ�·�����ƣ���ǰӦ�ó������ڵ���Ŀ¼���ƣ�
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
        /// ��ȡ��ǰ������IP��ַ
        /// </summary>
        /// <returns></returns>
        public static string GetAddressIP()
        {
            string server = Dns.GetHostName();
            IPHostEntry heserver = Dns.GetHostEntry(server);
            return heserver.AddressList[0].ToString();
        }
        /// <summary>
        /// ��ȡ��ǰ������IP��ַ
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
        /// ��ȡ��ǰִ���ļ����ڵ�·�����ƣ���ǰӦ�ó������ڵ���Ŀ¼���ƣ�
        /// </summary>
        /// <returns></returns>
        public static string AppPath()
        {
            return System.Windows.Forms.Application.StartupPath;
        }
    }
}
