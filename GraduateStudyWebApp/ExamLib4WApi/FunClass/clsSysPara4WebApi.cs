
using System;

namespace ExamLib4WApi
{
    /// <summary>
    /// clsSysPara��
    /// </summary>
    public class clsSysPara4WebApi
    {

        /// <summary>
        /// ��ǰ������IPAddress
        /// </summary>
        public static String strCurrIPAddressAndPort
        {
            set
            {
                clsSysPara.CurrIPAddressAndPort = value;
            }
            get
            {
                return clsSysPara.CurrIPAddressAndPort;
            }
        }
        /// <summary>
        /// ��ǰ������IPAddress�����ã�
        /// </summary>
        public static String strCurrIPAddressAndPort2
        {
            set
            {
                clsSysPara.strCurrIPAddressAndPort2 = value;
            }
        }
          /// <summary>
        /// �Ƿ�ʹ�ñ��õ�ͳһƽ̨�����ַ
        /// </summary>
        public static bool bolIsUseBackupIpAddressAndCurrPrx
        {
            set
            {
                clsSysPara.bolIsUseBackupIpAddressAndCurrPrx = value;
            }
        }

        ///// <summary>
        ///// �Ƿ񱾻�����״̬
        ///// </summary>
        //public static bool bolIsLocalHost
        //{
        //    set
        //    {
        //        clsSysPara.bolIsLocalHost = value;
        //    }
        //}
        /// <summary>
        /// 
        /// </summary>
        public static String strCurrIPAddressAndPort_Local
        {
            set
            {
                clsSysPara.strCurrIPAddressAndPort_Local = value;
            }
            get
            {
                return clsSysPara.strCurrIPAddressAndPort_Local;
            }
        }

        /// <summary>
        /// ��ǰ�����Ķ˿ں�
        /// </summary>
        public static String strCurrPrx
        {
            set
            {
                clsSysPara.CurrPrx = value;
            }
            get
            {
                return clsSysPara.CurrPrx;
            }
        }

        /// <summary>
        /// ��ǰ�����Ķ˿ںţ����ã�
        /// </summary>
        public static String strCurrPrx2
        {
            set
            {
                clsSysPara.strCurrPrx2 = value;
            }
        }
        /// <summary>
        /// �Ƿ񱾻�����״̬
        /// </summary>
        public static bool bolIsLocalHost
        {
            set
            {
                clsSysPara.bolIsLocalHost = value;
            }
            get
            {
                return clsSysPara.bolIsLocalHost;
            }
        }
        ///// <summary>
        ///// ����������
        ///// </summary>
        ///// <param name="strReturn">������ش�����Ϣ</param>
        ///// <returns>�����Ƿ�ɹ���</returns>
        //public static bool TestConnect(ref string strReturn)
        //{
        //    LoginServiceSoapClient objLoginService = null;
        //    try
        //    {
        //        objLoginService =clsLoginWS.GetLoginServiceSoapClient();
        //        string ss = objLoginService.GetUserIdByLoginName("pyf");
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMessage = objException.InnerException.Message;
        //        if (strMessage.IndexOf("�޷�����") >= 0)
        //        {
        //            string strMsg = string.Format(" ����������,�������ڣ�{3}, ��ʹ���������ӡ�{0}.clsSysPara.CurrPrx={1}; clsSysPara.CurrIPAddressAndPort={2}",
        //                 objException.Message,
        //                 clsSysPara.CurrPrx,
        //                 clsSysPara.CurrIPAddressAndPort,
        //                 objException.InnerException.Message);
        //            com.taishsoft.common.clsLog.LogErrorS(objException, "TestConnect");
        //            strReturn = strMsg;
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //        //throw new Exception(strMsg);
        //    }
        //    return true;
        //}
        ///// <summary>
        ///// ���Ա�������
        ///// </summary>
        ///// <param name="strReturn">������ش�����Ϣ</param>
        ///// <returns>�����Ƿ�ɹ���</returns>
        //public static bool TestConnect2(ref string strReturn)
        //{
        //    LoginServiceSoapClient objLoginService = null;
        //    try
        //    {
        //        objLoginService = clsLoginWS.GetLoginServiceSoapClientByBackup();
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMessage = objException.InnerException.Message;
        //        if (strMessage.IndexOf("�޷�����") >= 0)
        //        {
        //            string strMsg = string.Format("���Ա�������������,�������ڣ�{3}, ��ʹ���������ӡ�{0}.clsSysPara.CurrPrx={1}; clsSysPara.CurrIPAddressAndPort={2}",
        //                 objException.Message,
        //                 clsSysPara.CurrPrx,
        //                 clsSysPara.CurrIPAddressAndPort,
        //                 objException.InnerException.Message);
        //            com.taishsoft.common.clsLog.LogErrorS(objException, "TestConnect");
        //            strReturn = strMsg;
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }
        //    return true;
        //}
    
    }
}
