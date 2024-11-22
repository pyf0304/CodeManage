
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.comm_db_obj;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace com.taishsoft.comm_db_obj
{
    /// <summary>
    /// ʵ�����Ļ���2
    /// </summary>
    [Serializable]
    [DataContractAttribute]
    public class clsEntityBase2
    {
        /// <summary>
        /// ��ǰ�������������صı���
        /// </summary>
        protected string _CurrTabName;
        /// <summary>
        /// ���ڼ�¼���޸����Թ�������Щ���Ա����ù�
        /// </summary>
        private List<string> lstUpdatedFldCol = null;//���ڼ�¼���޸����Թ�������Щ���Ա����ù�
        /// <summary>
        /// ��������������ص��ֶαȽ������
        /// </summary>
        public Dictionary<string, string> dicFldComparisonOp;

        /// <summary>
        /// ��������������ص��ֶαȽ������
        /// </summary>
        [DataMember]//�ǳ���Ҫ
        public string sfFldComparisonOp
        {
            get
            {
                return mstrsfFldComparisonOp;
            }
            set
            {
                if (value == "")
                {
                    mstrsfFldComparisonOp = value;
                }
                else
                {
                    mstrsfFldComparisonOp = value;
                }
            }
        }
        //protected string _CurrTabName
        //{
        //    get { return mstrCurrTabName; }
        //    set { mstrCurrTabName = value; }
        //}
        /// <summary>
        /// ��ǰ����Ĺؼ���������
        /// </summary>
        protected List<string> lstKeyFldNames;  //��ǰ��Ĺؼ����ֶε�����

        /// <summary>
        /// ������Ϣ
        /// </summary>
        protected string[] mstrErrMsg_Tz = { "0:����", "1:Ժϵ��Ϊ��", "2:רҵ���Ϊ��", "3:������ͬ�ı��" };
        /// <summary>
        /// ��Ĺؼ���
        /// </summary>
        public virtual string _KeyId
        {
            get;
        }

        /// <summary>
        /// ��������ֶ�ֵ
        /// </summary>
        public virtual string _NameValue
        {
            get;
        }
        [DataMember]//�ǳ���Ҫ
        private string mstrsfUpdFldSetStr = "";    //ϵͳ�ֶ�_�޸��ֶμ��ϴ�
        [DataMember]//�ǳ���Ҫ
        private string mstrsfFldComparisonOp = "";    //ϵͳ�ֶ�_�޸��ֶμ��ϴ�

        /// <summary>
        /// ϵͳ�ֶ�_�޸��ֶμ��ϴ�      
        /// </summary>
        [DataMember]//�ǳ���Ҫ
        public string sfUpdFldSetStr
        {
            get
            {
                return mstrsfUpdFldSetStr;
            }
            set
            {
                if (value == "")
                {
                    mstrsfUpdFldSetStr = value;
                }
                else
                {
                    mstrsfUpdFldSetStr = value;
                }
            }
        }

        /// <summary>
        /// ������Ϣ�� 0:����,1:�����Ϊ��,2:ѧ��Ϊ��
        /// </summary>
        protected int mintErrNo = 0;   //

        /// <summary>
        /// ��ǰģ����������ǰ����
        /// </summary>
        public string _ModuleName { get; set; }
        //		public static string mstrClassName;
        /// <summary>
        /// �Ƿ��Ѿ��ͷŶ���(������������)
        /// </summary>
        protected bool mblnDisposed = false;
        /// <summary>
        /// �쳣��Ϣ
        /// </summary>
        protected const string EXCEPTION_MSG = "����"; //there was an error in the method. please see the Application Log for details.";

        /// <summary>
        /// ����Tag
        /// </summary>
        protected int mintIntTag;    //����Tag
        /// <summary>
        /// �ַ��ͱ�ǩ
        /// </summary>
        protected string mstrStrTag;    //�ַ��ͱ�ǩ
        /// <summary>
        /// �Ƿ�������
        /// </summary>
        protected bool mbolIsCheckProperty;    //�Ƿ�������

        /// <summary>
        /// ����:"IntTag"
        /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_IntTag = "_IntTag";    //����Tag

        /// <summary>
        /// ����:"StrTag"
        /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_StrTag = "_StrTag";    //�ַ��ͱ�ǩ

        /// <summary>
        /// ����:"IsCheckProperty"
        /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_IsCheckProperty = "IsCheckProperty";    //�Ƿ�������

        ////�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�
        private static string m_strConnectStringB;
        /// <summary>
        /// ��ǰ��ʹ�õ����Ӵ�����
        /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenConnectString)
        /// </summary>
        public static string _ConnectStringB
        {
            get { return m_strConnectStringB; }
            set { m_strConnectStringB = value; }
        }
        ///// <summary>
        ///// ҵ���߼���Ĺ��������������
        ///// </summary>
        //public clsCommFun4BL objCommFun4BL;

        /// <summary>
        /// ����Tag(˵��:;�ֶ�����:int;�ֶγ���:4;�Ƿ�ɿ�:False)
        /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
        /// </summary>
        public int _IntTag
        {
            get
            {
                return mintIntTag;
            }
            set
            {
                mintIntTag = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld(con_IntTag);
            }
        }
        /// <summary>
        /// �ַ��ͱ�ǩ(˵��:;�ֶ�����:string;�ֶγ���:1000;�Ƿ�ɿ�:False)
        /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
        /// </summary>
        public string _StrTag
        {
            get
            {
                return mstrStrTag;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrStrTag = value;
                }
                else
                {
                    mstrStrTag = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld(con_StrTag);
            }
        }
        /// <summary>
        /// ���ڸ�ѡ����Ƿ�ѡ��
        /// </summary>
        public string _Checked { get; set; }
        /// <summary>
        /// �Ƿ�������(˵��:;�ֶ�����:bool;�ֶγ���:1;�Ƿ�ɿ�:False)
        /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
        /// </summary>
        public bool _IsCheckProperty
        {
            get
            {
                return mbolIsCheckProperty;
            }
            set
            {
                mbolIsCheckProperty = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld(con_IsCheckProperty);
            }
        }
        /// <summary>
        /// ���캯��
        /// </summary>
        public clsEntityBase2()
        {
            SetInit();
            mbolIsCheckProperty = false;

        }

        /// <summary>
        /// �������Щͨ�����Խ��г�ʼֵ
        /// </summary>
        protected void SetInit()
        {
            _CurrTabName = "Users";    //��ǰ�������������صı���
            //lstKeyFldNames.Add("UserId");		//��ǰ��Ĺؼ����ֶε�����
            lstKeyFldNames = new List<string>();
            _ModuleName = this.GetType().ToString();
            lstUpdatedFldCol = new List<string>();
            dicFldComparisonOp = new Dictionary<string, string>();
        }

        /// <summary>
        /// �����
        /// </summary>
        public int _ErrNo
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
        /// ������ʾ�Ĵ�����Ϣ
        /// </summary>
        public string _DispErrMsg { get; set; }
        /// <summary>
        /// ��ǰ��(����)�ı���
        /// </summary>
        public string _TabName_Curr
        {
            get
            {
                return _CurrTabName;
            }
        }
        /// <summary>
        /// ��ǰ��(����)�ı�ؼ��ֶ���
        /// </summary>
        public List<string> _TabKeyFldNames
        {
            get
            {
                return lstKeyFldNames;
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
            float f1 = 0.0f;
            if (obj == null) return f1;
            float.TryParse(obj.ToString(), out f1);
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
        /// ����Ѿ��޸ĵ��ֶ�
        /// </summary>
        /// <param name="strFldName">�ֶ���</param>
        protected void AddUpdatedFld(string strFldName)
        {
            if (lstUpdatedFldCol == null) lstUpdatedFldCol = new List<string>();
            if (lstUpdatedFldCol.Contains(strFldName) == false)
            {
                lstUpdatedFldCol.Add(strFldName);
            }
        }
        /// <summary>
        /// ��ȡ�޸��ֶεĺϲ������ԡ�|���ָ�
        /// </summary>
        /// <returns></returns>
        public string getsfUpdFldSetStr()
        {
            StringBuilder sbsfUpdFldSetStr = new StringBuilder();
            foreach (string strFldName in lstUpdatedFldCol)
            {
                sbsfUpdFldSetStr.AppendFormat("{0}|", strFldName);
            }
            return sbsfUpdFldSetStr.ToString();
        }

      

        /// <summary>
        /// ����ֶε��޸ı�־
        /// </summary>
        /// <returns></returns>
        public bool ClearFldUpdateFlag()
        {
            this.lstUpdatedFldCol = null;
            return true;
        }
        /// <summary>
        /// ����ֶ��Ƿ��޸Ĺ���
        /// </summary>
        /// <param name="strFldName">�ֶ���</param>
        /// <returns>���� true:�޸Ĺ���false:δ�޸�</returns>
        public bool IsUpdated(string strFldName)
        {
            if (lstUpdatedFldCol.Contains(strFldName) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// ����޸�״̬,����մ洢���ֶ���Ϣ��lstUpdatedFldCol����.
        /// </summary>
        public void ClearUpdateState()
        {
            lstUpdatedFldCol.Clear();
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strAttributeName"></param>
        /// <returns></returns>
        public virtual object this[string strAttributeName]
        {
            get
            {
                return null;
            }
            set
            { }
        }
        /// <summary>
        /// Ϊ������������ֶ�ֵ��Ϊ�Զ������ȡ��������׼��
        /// </summary>
        /// <param name = "strFldName">�ֶ���</param>
        /// <param name = "strFldValue">�ֶ�ֵ</param>
        /// <param name = "strComparisonOp">�Ƚ������</param>
        public void SetCondFldValue(string strFldName, string strFldValue, string strComparisonOp)
        {
            this[strFldName] = strFldValue;
            if (dicFldComparisonOp.ContainsKey(strFldName) == false)
            {
                dicFldComparisonOp.Add(strFldName, strComparisonOp);
            }
            else
            {
                dicFldComparisonOp[strFldName] = strComparisonOp;
            }
        }

    }
}
