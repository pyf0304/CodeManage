using System;
using com.taishsoft.commdbforxml;
using com.taishsoft.common;

namespace AGC.Entity
{
    /// <summary>
    /// clsSysPara ��ժҪ˵����
    /// </summary>
    public class clsSysParaEN_Local : clsSysParaEN
    {

        public static clsLog objLog4GCError = null;//new clsLog();

        private static bool mbolIsBackupForGeneCode = true;
        /// <summary>
        /// �����ɴ���ʱ�Ƿ񱸷�
        /// </summary>
        public static bool IsBackupForGeneCode
        {
            get { return clsSysParaEN_Local.mbolIsBackupForGeneCode; }
            set
            {
                clsSysParaEN_Local.mbolIsBackupForGeneCode = value;
            }
        }
        private static bool mbolIsUseFieldCache = false;
        /// <summary>
        /// �Ƿ�ʹ���ֶλ���
        /// </summary>
        public static bool IsUseFieldCache
        {
            get { return clsSysParaEN_Local.mbolIsUseFieldCache; }
            set { clsSysParaEN_Local.mbolIsUseFieldCache = value; }
        }
        /// <summary>
        /// �Ƿ���SQLע��,20090524��Ӹù���
        /// </summary>
        public static bool bolIsAccessSqlInjection = false;

        public static string strMainJobDesc = "��Ҫ����";
        public static string strDynamicLibPath = "";

        public static string strCurrPrjConnectString = "";  //��ǰ��ѡ���������Ӵ�
        public static string strVersion = "2024.11.13.2";

        public clsSysParaEN_Local()
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
    }
}
