
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;

using com.taishsoft.comm_db_obj;

namespace com.taishsoft.comm_db_obj
{
    [Serializable]
    public class clsEntityBase
    {
        /// <summary>
        /// ��ǰ�������������صı���
        /// </summary>
        protected string _CurrTabName;    
        /// <summary>
        /// ���ڼ�¼���޸����Թ�������Щ���Ա����ù�
        /// </summary>
        public Hashtable htProperty = null;//���ڼ�¼���޸����Թ�������Щ���Ա����ù�

        //protected string _CurrTabName
        //{
        //    get { return mstrCurrTabName; }
        //    set { mstrCurrTabName = value; }
        //}

        /// <summary>
        /// ��ǰ��Ĺؼ����ֶε�����
        /// </summary>
        protected string KeyFldName;    

    
        /// <summary>
        /// �����ǳ�����Ϣ
        /// </summary>
        protected string[] mstrErrMsg_Tz = { "0:����", "1:Ժϵ��Ϊ��", "2:רҵ���Ϊ��", "3:������ͬ�ı��" };
       
        /// <summary>
        /// �����ǳ�����Ϣ����
        /// </summary>
        protected int mintErrNo = 0;   //0:����,1:�����Ϊ��,2:ѧ��Ϊ��
        /// <summary>
        /// 
        /// </summary>
        protected string mstrDispErrMsg;         //������ʾ�Ĵ�����Ϣ
        /// <summary>
        /// 
        /// </summary>
        protected string mstrModuleName;
        //		public static string mstrClassName;
        /// <summary>
        /// �Ƿ��Ѿ��ͷŶ���(������������)
        /// </summary>
        protected bool mblnDisposed = false;     //�Ƿ��Ѿ��ͷŶ���(������������)
        /// <summary>
        /// 
        /// </summary>
        protected const string EXCEPTION_MSG = "����"; //there was an error in the method. please see the Application Log for details.";
        //���������Ա���
        ///�ú���������:

        public clsEntityBase()
        {
            SetInit();
        }

        /// <summary>
        /// ���������Щ���Գ�ʼֵ
        /// </summary>
        protected void SetInit()
        {
            _CurrTabName = "Users";    //��ǰ�������������صı���
            KeyFldName = "UserId";		//��ǰ��Ĺؼ����ֶε�����
            mstrModuleName = this.GetType().ToString();
            htProperty = new Hashtable();
        }

        /// <summary>
        /// �����
        /// </summary>
        public int ErrNo
        {
            get
            {
                return mintErrNo;
            }
            set
            {
                mintErrNo = value;
            }
        }
        /// <summary>
        /// ������Ϣ
        /// </summary>
        public string DispErrMsg       //������ʾ�Ĵ�����Ϣ
        {
            get
            {
                return mstrDispErrMsg;
            }
            set
            {
                mstrDispErrMsg = value;
            }
        }
        /// <summary>
        /// ��ǰ��(����)�ı���
        /// </summary>
        public string TabName_Curr
        {
            get
            {
                return _CurrTabName;
            }
        }
        /// <summary>
        /// ��ǰ��(����)�ı�ؼ��ֶ���
        /// </summary>
        public string TabKeyFldName
        {
            get
            {
                return KeyFldName;
            }
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ�ַ���,���ΪNULL�ͷ��ؿմ�
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص��ַ���</returns>
        protected string TransNullToStr(Object obj)
        {
            if (obj == null) return "";
            if (obj.ToString() == "")
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ�ַ���,���ΪNULL�ͷ��ؿմ�
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص��ַ���</returns>
        public static string TransNullToStr_S(Object obj)
        {
            if (obj == null) return "";
            if (obj.ToString() == "")
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ����,���ΪNULL�ͷ���0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�����ֵ</returns>
        protected int TransNullToInt(Object obj)
        {
            int i = 0;
            if (obj == null) return 0;
            Int32.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ����,���ΪNULL�ͷ���0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�����ֵ</returns>
        public static int TransNullToInt_S(Object obj)
        {

            int i = 0;
            if (obj == null) return 0;
            Int32.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĶ�����ֵ</returns>
        protected short TransNullToShort(Object obj)
        {
            short i = 0;
            if (obj == null) return 0;
            short.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĶ�����ֵ</returns>
        public static short TransNullToShort_S(Object obj)
        {
            short i = 0;
            if (obj == null) return 0;
            short.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���#1/1/1900#(��С������)
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�������ֵ</returns>
        protected DateTime TransNullToDate(Object obj)
        {
            DateTime objDT = System.DateTime.Parse("#1/1/1900#");
            System.DateTime.TryParse(obj.ToString(), out objDT);
            return objDT;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���#1/1/1900#(��С������)
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�������ֵ</returns>
        public static DateTime TransNullToDate_S(Object obj)
        {
            DateTime objDT = System.DateTime.Parse("#1/1/1900#");
            if (obj == null) return objDT;
            System.DateTime.TryParse(obj.ToString(), out objDT);
            return objDT;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���0.0f
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĸ�����ֵ</returns>
        protected float TransNullToFloat(Object obj)
        {
                float f1 =  0.0f;
                if (obj == null) return f1;
                float.TryParse( obj.ToString(), out f1);
                return f1;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���0.0f
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĸ�����ֵ</returns>
        public static float TransNullToFloat_S(Object obj)
        {
            float f1 = 0.0f;
            if (obj == null) return f1;
            float.TryParse(obj.ToString(), out f1);
            return f1;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ˫��������,���ΪNULL�ͷ���0.0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�˫��������ֵ</returns>
        protected double TransNullToDouble(Object obj)
        {
            double d1 = 0.0;
            if (obj == null) return d1;
            double.TryParse(obj.ToString(), out d1);
            return d1;
        }

        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ˫��������,���ΪNULL�ͷ���0.0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�˫��������ֵ</returns>
        public static double TransNullToDouble_S(Object obj)
        {
            double d1 = 0.0;
            if (obj == null) return d1;
            double.TryParse(obj.ToString(), out d1);
            return d1;
        }

        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ��ؼ�(false)
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĲ�����ֵ</returns>
        protected bool TransNullToBool(Object obj)
        {
            if (obj == null) return false;
            if (obj.ToString() == "")
            {
                return false;
            }
            else
            {
                string strFirstByte = obj.ToString().Substring(0, 1);
                strFirstByte = strFirstByte.ToLower();
                if (strFirstByte == "y" || strFirstByte == "t" || strFirstByte == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ��ؼ�(false)
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĲ�����ֵ</returns>
        public static bool TransNullToBool_S(Object obj)
        {
            if (obj == null) return false;
            if (obj.ToString() == "")
            {
                return false;
            }
            else
            {
                string strFirstByte = obj.ToString().Substring(0, 1);
                strFirstByte = strFirstByte.ToLower();
                if (strFirstByte == "y" || strFirstByte == "t" || strFirstByte == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// ���������־�ĺ���
        /// </summary>
        /// <param name="objException">�쳣����</param>
        /// <param name="strModuleName">ģ������</param>
        public static void LogErrorS(Exception objException, string strModuleName)
        {           
            string strLogMsg;
            try
            {
                strLogMsg = "��һ���������������ģ����: "
                    + strModuleName + "��ϢԴ: " + objException.Source
                    + "ˮţ: " + objException.Message
                    + "����:  " + objException.StackTrace
                    + "Ŀ¼վ��:  " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
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
        public static void LogErrorS2(string strModuleName, string strSource, string strMessage, string strStackTrace, string strTargetSite)
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
            catch
            {
            }
        }

    }
}
