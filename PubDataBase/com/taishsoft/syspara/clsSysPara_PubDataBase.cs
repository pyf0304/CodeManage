using System;
using com.taishsoft.commdbforxml;

namespace com.taishsoft.syspara
{
	/// <summary>
	/// clsSysPara ��ժҪ˵����
	/// </summary>
	public class clsSysPara_PubDataBase
	{
        /// <summary>
        /// ���ڶ���SQL�洢���̵�XML�ļ�����
        /// </summary>
        public static string strXmlSpParaFileName;	//���ڶ���SQL�洢���̵�XML�ļ����ơ�
       
        public static clsSpecSQLforXml objSpecSqlForXml = null;

        ///���Ӵ�����
        public static string strConnectStrName = "";
        /// <summary>
        /// �Ƿ�ʹ�����Ӵ���
        /// </summary>
        public static bool bolIsUseConnectStrName = false;

        /// <summary>
        /// �û�ID
        /// </summary>
        public static string strUserId = "";
        /// <summary>
        /// ���Ӵ�
        /// </summary>
        public static string strConnectString = "";
        /// <summary>
        /// PubDataBase�İ汾
        /// </summary>
        public static string strVersion = "2019.03.07.01";

	}
}
