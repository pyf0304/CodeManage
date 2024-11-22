///----------------------
///���ɴ���汾��09.10.08.1
///�������ڣ�2009/10/16
///�����ߣ����Է�
///ע�⣺1����Ҫ���ݵײ㣨PubDataBase.dll���İ汾��09.10.08.2
///       2����Ҫ���������㣨TzPubFunction.dll���İ汾��09.10.08.1
///========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.common;
using com.taishsoft.commexception;
using com.taishsoft.commdb;

namespace EcardDataClass
{
    /// <summary>
    /// PERSON_q(PERSON_q)
    /// </summary>
    [Serializable]
    public class clsPERSON_q : clsGeneralTab2
    {
        /// <summary>
        /// ��ǰ�������������صı���
        /// </summary>
        public const string CurrTabName_S = "PERSON_q";
        /// <summary>
        /// ��ǰ���еĹؼ������ƣ��������صı��йؼ�����
        /// </summary>
        public const string CurrTabKeyFldName_S = "Account";
        /// <summary>
        /// ��ǰ������Ը���
        /// </summary>
        protected const int mintAttributeCount = 40;
        /// <summary>
        /// ��ǰ�������������
        /// </summary>
        public static string[] AttributeName = new string[] { "Account", "SCH_ID", "BANK_ACC", "CARD_NO", "TEMP_CARD_NO", "TEMP_USING", "TEMP_DEPOSIT", "PASSWORD", "MONEY", "CARD_KIND", "CARD_STATE", "LAST_TIME", "USEFUL_LIMIT", "RECYCLE_LIMIT", "NAME", "SEX", "IDEN_NO", "NATION_NO", "POLITICS", "DUTY", "BIRTH", "PERSON_ID", "STUDENT_ID", "SCHOOL_NO", "ACADEMY_NO", "DEP_NO", "CLASS_NO", "GRADE", "IN_TIME", "WALLANCE", "ADDRESS", "PHONE", "POST_NO", "POST_ADDRESS", "MAIL", "DESCR", "USER_ID", "OP_DATE", "ANNEX", "UpdDate" };
        //���������Ա���

        /// <summary> 
        /// ����
        /// </summary>
        protected string mstrAccount;
        /// <summary> 
        /// SCH_ID
        /// </summary>
        protected string mstrSCH_ID;
        /// <summary> 
        /// �����ʺ�
        /// </summary>
        protected string mstrBANK_ACC;
        /// <summary> 
        /// CARD_NO
        /// </summary>
        protected string mstrCARD_NO;
        /// <summary> 
        /// TEMP_CARD_NO
        /// </summary>
        protected string mstrTEMP_CARD_NO;
        /// <summary> 
        /// TEMP_USING
        /// </summary>
        protected double mdblTEMP_USING;
        /// <summary> 
        /// TEMP_DEPOSIT
        /// </summary>
        protected double mdblTEMP_DEPOSIT;
        /// <summary> 
        /// ����
        /// </summary>
        protected string mstrPASSWORD;
        /// <summary> 
        /// MONEY
        /// </summary>
        protected double mdblMONEY;
        /// <summary> 
        /// CARD_KIND
        /// </summary>
        protected double mdblCARD_KIND;
        /// <summary> 
        /// CARD_STATE
        /// </summary>
        protected double mdblCARD_STATE;
        /// <summary> 
        /// LAST_TIME
        /// </summary>
        protected DateTime mdteLAST_TIME;
        /// <summary> 
        /// USEFUL_LIMIT
        /// </summary>
        protected DateTime mdteUSEFUL_LIMIT;
        /// <summary> 
        /// RECYCLE_LIMIT
        /// </summary>
        protected DateTime mdteRECYCLE_LIMIT;
        /// <summary> 
        /// ����
        /// </summary>
        protected string mstrNAME;
        /// <summary> 
        /// �Ա�
        /// </summary>
        protected double mdblSEX;
        /// <summary> 
        /// IDEN_NO
        /// </summary>
        protected double mdblIDEN_NO;
        /// <summary> 
        /// �������
        /// </summary>
        protected double mdblNATION_NO;
        /// <summary> 
        /// ������ò
        /// </summary>
        protected string mstrPOLITICS;
        /// <summary> 
        /// DUTY
        /// </summary>
        protected string mstrDUTY;
        /// <summary> 
        /// ��ѧʱ��
        /// </summary>
        protected DateTime mdteBIRTH;
        /// <summary> 
        /// ���֤����
        /// </summary>
        protected string mstrPERSON_ID;
        /// <summary> 
        /// ѧ��
        /// </summary>
        protected string mstrSTUDENT_ID;
        /// <summary> 
        /// SCHOOL_NO
        /// </summary>
        protected string mstrSCHOOL_NO;
        /// <summary> 
        /// ѧԺ���
        /// </summary>
        protected string mstrACADEMY_NO;
        /// <summary> 
        /// רҵ���
        /// </summary>
        protected string mstrDEP_NO;
        /// <summary> 
        /// �༶���
        /// </summary>
        protected string mstrCLASS_NO;
        /// <summary> 
        /// �꼶
        /// </summary>
        protected string mstrGRADE;
        /// <summary> 
        /// IN_TIME
        /// </summary>
        protected DateTime mdteIN_TIME;
        /// <summary> 
        /// WALLANCE
        /// </summary>
        protected double mdblWALLANCE;
        /// <summary> 
        /// ��ͥסַ
        /// </summary>
        protected string mstrADDRESS;
        /// <summary> 
        /// �绰
        /// </summary>
        protected string mstrPHONE;
        /// <summary> 
        /// ��������
        /// </summary>
        protected string mstrPOST_NO;
        /// <summary> 
        /// ������ַ
        /// </summary>
        protected string mstrPOST_ADDRESS;
        /// <summary> 
        /// ����
        /// </summary>
        protected string mstrMAIL;
        /// <summary> 
        /// DESCR
        /// </summary>
        protected string mstrDESCR;
        /// <summary> 
        /// �û�ID
        /// </summary>
        protected string mstrUSER_ID;
        /// <summary> 
        /// OP_DATE
        /// </summary>
        protected DateTime mdteOP_DATE;
        /// <summary> 
        /// ANNEX
        /// </summary>
        protected string mstrANNEX;
        /// <summary> 
        /// UpdDate
        /// </summary>
        protected string mstrUpdDate;

        //�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�
        private static string m_strConnectString;
        /// <summary>
        /// ��ǰ��ָ�������Ӵ�
        /// </summary>
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }
        private string m_strConnectString_Obj;
        /// <summary>
        /// ��ǰ����ָ�������Ӵ�
        /// </summary>
        public string ConnectString_Obj
        {
            get { return m_strConnectString_Obj; }
            set { m_strConnectString_Obj = value; }
        }

        /// <summary>
        /// ��ǰ��Ĺ��캯��
        /// </summary>
        public clsPERSON_q()
        {
            SetInit();
            CurrTabName = "PERSON_q";
            lstKeyFldNames.Add("Account");
        }

        /// <summary>
        /// ��ǰ��Ĺ��캯��
        /// </summary>
        /// <param name="strAccount">����</param>
        public clsPERSON_q(string strAccount)
        {

            mstrAccount = strAccount;
            SetInit();
            CurrTabName = "PERSON_q";
            lstKeyFldNames.Add("Account");
        }

        /// <summary>
        /// ��ǰ��Ĺ��캯��
        /// </summary>
        /// <param name="strAccount">����</param>
        /// <param name="bolIsGetPERSON_q">�Ƿ��ȡ�ùؼ�����صļ�¼����</param>
        public clsPERSON_q(string strAccount, bool bolIsGetPERSON_q)
        {

            mstrAccount = strAccount;
            SetInit();
            if (bolIsGetPERSON_q == true)
            {
                GetPERSON_q();
            }
            CurrTabName = "PERSON_q";
            lstKeyFldNames.Add("Account");
        }


        /// <summary>
        /// ��ǰ������Եĸ���
        /// </summary>
        public static int AttributeCount
        {
            get
            {
                return mintAttributeCount;
            }
        }
        /// <summary>
        /// �������Ե�����(�ַ�������)��ȡ�����Ե�ֵ
        /// </summary>
        /// <param name="strAttributeName">��������(�ַ���)</param>
        /// <returns>�����Ե�ֵ</returns>
        public object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == "Account")
                {
                    return mstrAccount;
                }
                else if (strAttributeName == "SCH_ID")
                {
                    return mstrSCH_ID;
                }
                else if (strAttributeName == "BANK_ACC")
                {
                    return mstrBANK_ACC;
                }
                else if (strAttributeName == "CARD_NO")
                {
                    return mstrCARD_NO;
                }
                else if (strAttributeName == "TEMP_CARD_NO")
                {
                    return mstrTEMP_CARD_NO;
                }
                else if (strAttributeName == "TEMP_USING")
                {
                    return mdblTEMP_USING;
                }
                else if (strAttributeName == "TEMP_DEPOSIT")
                {
                    return mdblTEMP_DEPOSIT;
                }
                else if (strAttributeName == "PASSWORD")
                {
                    return mstrPASSWORD;
                }
                else if (strAttributeName == "MONEY")
                {
                    return mdblMONEY;
                }
                else if (strAttributeName == "CARD_KIND")
                {
                    return mdblCARD_KIND;
                }
                else if (strAttributeName == "CARD_STATE")
                {
                    return mdblCARD_STATE;
                }
                else if (strAttributeName == "LAST_TIME")
                {
                    return mdteLAST_TIME;
                }
                else if (strAttributeName == "USEFUL_LIMIT")
                {
                    return mdteUSEFUL_LIMIT;
                }
                else if (strAttributeName == "RECYCLE_LIMIT")
                {
                    return mdteRECYCLE_LIMIT;
                }
                else if (strAttributeName == "NAME")
                {
                    return mstrNAME;
                }
                else if (strAttributeName == "SEX")
                {
                    return mdblSEX;
                }
                else if (strAttributeName == "IDEN_NO")
                {
                    return mdblIDEN_NO;
                }
                else if (strAttributeName == "NATION_NO")
                {
                    return mdblNATION_NO;
                }
                else if (strAttributeName == "POLITICS")
                {
                    return mstrPOLITICS;
                }
                else if (strAttributeName == "DUTY")
                {
                    return mstrDUTY;
                }
                else if (strAttributeName == "BIRTH")
                {
                    return mdteBIRTH;
                }
                else if (strAttributeName == "PERSON_ID")
                {
                    return mstrPERSON_ID;
                }
                else if (strAttributeName == "STUDENT_ID")
                {
                    return mstrSTUDENT_ID;
                }
                else if (strAttributeName == "SCHOOL_NO")
                {
                    return mstrSCHOOL_NO;
                }
                else if (strAttributeName == "ACADEMY_NO")
                {
                    return mstrACADEMY_NO;
                }
                else if (strAttributeName == "DEP_NO")
                {
                    return mstrDEP_NO;
                }
                else if (strAttributeName == "CLASS_NO")
                {
                    return mstrCLASS_NO;
                }
                else if (strAttributeName == "GRADE")
                {
                    return mstrGRADE;
                }
                else if (strAttributeName == "IN_TIME")
                {
                    return mdteIN_TIME;
                }
                else if (strAttributeName == "WALLANCE")
                {
                    return mdblWALLANCE;
                }
                else if (strAttributeName == "ADDRESS")
                {
                    return mstrADDRESS;
                }
                else if (strAttributeName == "PHONE")
                {
                    return mstrPHONE;
                }
                else if (strAttributeName == "POST_NO")
                {
                    return mstrPOST_NO;
                }
                else if (strAttributeName == "POST_ADDRESS")
                {
                    return mstrPOST_ADDRESS;
                }
                else if (strAttributeName == "MAIL")
                {
                    return mstrMAIL;
                }
                else if (strAttributeName == "DESCR")
                {
                    return mstrDESCR;
                }
                else if (strAttributeName == "USER_ID")
                {
                    return mstrUSER_ID;
                }
                else if (strAttributeName == "OP_DATE")
                {
                    return mdteOP_DATE;
                }
                else if (strAttributeName == "ANNEX")
                {
                    return mstrANNEX;
                }
                else if (strAttributeName == "UpdDate")
                {
                    return mstrUpdDate;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "Account")
                {
                    mstrAccount = value.ToString();
                }
                else if (strAttributeName == "SCH_ID")
                {
                    mstrSCH_ID = value.ToString();
                }
                else if (strAttributeName == "BANK_ACC")
                {
                    mstrBANK_ACC = value.ToString();
                }
                else if (strAttributeName == "CARD_NO")
                {
                    mstrCARD_NO = value.ToString();
                }
                else if (strAttributeName == "TEMP_CARD_NO")
                {
                    mstrTEMP_CARD_NO = value.ToString();
                }
                else if (strAttributeName == "TEMP_USING")
                {
                    mdblTEMP_USING = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "TEMP_DEPOSIT")
                {
                    mdblTEMP_DEPOSIT = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "PASSWORD")
                {
                    mstrPASSWORD = value.ToString();
                }
                else if (strAttributeName == "MONEY")
                {
                    mdblMONEY = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "CARD_KIND")
                {
                    mdblCARD_KIND = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "CARD_STATE")
                {
                    mdblCARD_STATE = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "LAST_TIME")
                {
                    mdteLAST_TIME = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "USEFUL_LIMIT")
                {
                    mdteUSEFUL_LIMIT = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "RECYCLE_LIMIT")
                {
                    mdteRECYCLE_LIMIT = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "NAME")
                {
                    mstrNAME = value.ToString();
                }
                else if (strAttributeName == "SEX")
                {
                    mdblSEX = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "IDEN_NO")
                {
                    mdblIDEN_NO = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "NATION_NO")
                {
                    mdblNATION_NO = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "POLITICS")
                {
                    mstrPOLITICS = value.ToString();
                }
                else if (strAttributeName == "DUTY")
                {
                    mstrDUTY = value.ToString();
                }
                else if (strAttributeName == "BIRTH")
                {
                    mdteBIRTH = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "PERSON_ID")
                {
                    mstrPERSON_ID = value.ToString();
                }
                else if (strAttributeName == "STUDENT_ID")
                {
                    mstrSTUDENT_ID = value.ToString();
                }
                else if (strAttributeName == "SCHOOL_NO")
                {
                    mstrSCHOOL_NO = value.ToString();
                }
                else if (strAttributeName == "ACADEMY_NO")
                {
                    mstrACADEMY_NO = value.ToString();
                }
                else if (strAttributeName == "DEP_NO")
                {
                    mstrDEP_NO = value.ToString();
                }
                else if (strAttributeName == "CLASS_NO")
                {
                    mstrCLASS_NO = value.ToString();
                }
                else if (strAttributeName == "GRADE")
                {
                    mstrGRADE = value.ToString();
                }
                else if (strAttributeName == "IN_TIME")
                {
                    mdteIN_TIME = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "WALLANCE")
                {
                    mdblWALLANCE = TransNullToDouble(value.ToString());
                }
                else if (strAttributeName == "ADDRESS")
                {
                    mstrADDRESS = value.ToString();
                }
                else if (strAttributeName == "PHONE")
                {
                    mstrPHONE = value.ToString();
                }
                else if (strAttributeName == "POST_NO")
                {
                    mstrPOST_NO = value.ToString();
                }
                else if (strAttributeName == "POST_ADDRESS")
                {
                    mstrPOST_ADDRESS = value.ToString();
                }
                else if (strAttributeName == "MAIL")
                {
                    mstrMAIL = value.ToString();
                }
                else if (strAttributeName == "DESCR")
                {
                    mstrDESCR = value.ToString();
                }
                else if (strAttributeName == "USER_ID")
                {
                    mstrUSER_ID = value.ToString();
                }
                else if (strAttributeName == "OP_DATE")
                {
                    mdteOP_DATE = TransNullToDate(value.ToString());
                }
                else if (strAttributeName == "ANNEX")
                {
                    mstrANNEX = value.ToString();
                }
                else if (strAttributeName == "UpdDate")
                {
                    mstrUpdDate = value.ToString();
                }
            }
        }
        /// <summary>
        /// �������Ե����(����)��ȡ�����Ե�ֵ
        /// </summary>
        /// <param name="intIndex">�������(����)</param>
        /// <returns>�����Ե�ֵ</returns>
        public object this[int intIndex]
        {
            get
            {
                if ("Account" == AttributeName[intIndex])
                {
                    return mstrAccount;
                }
                else if ("SCH_ID" == AttributeName[intIndex])
                {
                    return mstrSCH_ID;
                }
                else if ("BANK_ACC" == AttributeName[intIndex])
                {
                    return mstrBANK_ACC;
                }
                else if ("CARD_NO" == AttributeName[intIndex])
                {
                    return mstrCARD_NO;
                }
                else if ("TEMP_CARD_NO" == AttributeName[intIndex])
                {
                    return mstrTEMP_CARD_NO;
                }
                else if ("TEMP_USING" == AttributeName[intIndex])
                {
                    return mdblTEMP_USING;
                }
                else if ("TEMP_DEPOSIT" == AttributeName[intIndex])
                {
                    return mdblTEMP_DEPOSIT;
                }
                else if ("PASSWORD" == AttributeName[intIndex])
                {
                    return mstrPASSWORD;
                }
                else if ("MONEY" == AttributeName[intIndex])
                {
                    return mdblMONEY;
                }
                else if ("CARD_KIND" == AttributeName[intIndex])
                {
                    return mdblCARD_KIND;
                }
                else if ("CARD_STATE" == AttributeName[intIndex])
                {
                    return mdblCARD_STATE;
                }
                else if ("LAST_TIME" == AttributeName[intIndex])
                {
                    return mdteLAST_TIME;
                }
                else if ("USEFUL_LIMIT" == AttributeName[intIndex])
                {
                    return mdteUSEFUL_LIMIT;
                }
                else if ("RECYCLE_LIMIT" == AttributeName[intIndex])
                {
                    return mdteRECYCLE_LIMIT;
                }
                else if ("NAME" == AttributeName[intIndex])
                {
                    return mstrNAME;
                }
                else if ("SEX" == AttributeName[intIndex])
                {
                    return mdblSEX;
                }
                else if ("IDEN_NO" == AttributeName[intIndex])
                {
                    return mdblIDEN_NO;
                }
                else if ("NATION_NO" == AttributeName[intIndex])
                {
                    return mdblNATION_NO;
                }
                else if ("POLITICS" == AttributeName[intIndex])
                {
                    return mstrPOLITICS;
                }
                else if ("DUTY" == AttributeName[intIndex])
                {
                    return mstrDUTY;
                }
                else if ("BIRTH" == AttributeName[intIndex])
                {
                    return mdteBIRTH;
                }
                else if ("PERSON_ID" == AttributeName[intIndex])
                {
                    return mstrPERSON_ID;
                }
                else if ("STUDENT_ID" == AttributeName[intIndex])
                {
                    return mstrSTUDENT_ID;
                }
                else if ("SCHOOL_NO" == AttributeName[intIndex])
                {
                    return mstrSCHOOL_NO;
                }
                else if ("ACADEMY_NO" == AttributeName[intIndex])
                {
                    return mstrACADEMY_NO;
                }
                else if ("DEP_NO" == AttributeName[intIndex])
                {
                    return mstrDEP_NO;
                }
                else if ("CLASS_NO" == AttributeName[intIndex])
                {
                    return mstrCLASS_NO;
                }
                else if ("GRADE" == AttributeName[intIndex])
                {
                    return mstrGRADE;
                }
                else if ("IN_TIME" == AttributeName[intIndex])
                {
                    return mdteIN_TIME;
                }
                else if ("WALLANCE" == AttributeName[intIndex])
                {
                    return mdblWALLANCE;
                }
                else if ("ADDRESS" == AttributeName[intIndex])
                {
                    return mstrADDRESS;
                }
                else if ("PHONE" == AttributeName[intIndex])
                {
                    return mstrPHONE;
                }
                else if ("POST_NO" == AttributeName[intIndex])
                {
                    return mstrPOST_NO;
                }
                else if ("POST_ADDRESS" == AttributeName[intIndex])
                {
                    return mstrPOST_ADDRESS;
                }
                else if ("MAIL" == AttributeName[intIndex])
                {
                    return mstrMAIL;
                }
                else if ("DESCR" == AttributeName[intIndex])
                {
                    return mstrDESCR;
                }
                else if ("USER_ID" == AttributeName[intIndex])
                {
                    return mstrUSER_ID;
                }
                else if ("OP_DATE" == AttributeName[intIndex])
                {
                    return mdteOP_DATE;
                }
                else if ("ANNEX" == AttributeName[intIndex])
                {
                    return mstrANNEX;
                }
                else if ("UpdDate" == AttributeName[intIndex])
                {
                    return mstrUpdDate;
                }
                return null;
            }
            set
            {
                if ("Account" == AttributeName[intIndex])
                {
                    mstrAccount = value.ToString();
                }
                else if ("SCH_ID" == AttributeName[intIndex])
                {
                    mstrSCH_ID = value.ToString();
                }
                else if ("BANK_ACC" == AttributeName[intIndex])
                {
                    mstrBANK_ACC = value.ToString();
                }
                else if ("CARD_NO" == AttributeName[intIndex])
                {
                    mstrCARD_NO = value.ToString();
                }
                else if ("TEMP_CARD_NO" == AttributeName[intIndex])
                {
                    mstrTEMP_CARD_NO = value.ToString();
                }
                else if ("TEMP_USING" == AttributeName[intIndex])
                {
                    mdblTEMP_USING = TransNullToDouble(value.ToString());
                }
                else if ("TEMP_DEPOSIT" == AttributeName[intIndex])
                {
                    mdblTEMP_DEPOSIT = TransNullToDouble(value.ToString());
                }
                else if ("PASSWORD" == AttributeName[intIndex])
                {
                    mstrPASSWORD = value.ToString();
                }
                else if ("MONEY" == AttributeName[intIndex])
                {
                    mdblMONEY = TransNullToDouble(value.ToString());
                }
                else if ("CARD_KIND" == AttributeName[intIndex])
                {
                    mdblCARD_KIND = TransNullToDouble(value.ToString());
                }
                else if ("CARD_STATE" == AttributeName[intIndex])
                {
                    mdblCARD_STATE = TransNullToDouble(value.ToString());
                }
                else if ("LAST_TIME" == AttributeName[intIndex])
                {
                    mdteLAST_TIME = TransNullToDate(value.ToString());
                }
                else if ("USEFUL_LIMIT" == AttributeName[intIndex])
                {
                    mdteUSEFUL_LIMIT = TransNullToDate(value.ToString());
                }
                else if ("RECYCLE_LIMIT" == AttributeName[intIndex])
                {
                    mdteRECYCLE_LIMIT = TransNullToDate(value.ToString());
                }
                else if ("NAME" == AttributeName[intIndex])
                {
                    mstrNAME = value.ToString();
                }
                else if ("SEX" == AttributeName[intIndex])
                {
                    mdblSEX = TransNullToDouble(value.ToString());
                }
                else if ("IDEN_NO" == AttributeName[intIndex])
                {
                    mdblIDEN_NO = TransNullToDouble(value.ToString());
                }
                else if ("NATION_NO" == AttributeName[intIndex])
                {
                    mdblNATION_NO = TransNullToDouble(value.ToString());
                }
                else if ("POLITICS" == AttributeName[intIndex])
                {
                    mstrPOLITICS = value.ToString();
                }
                else if ("DUTY" == AttributeName[intIndex])
                {
                    mstrDUTY = value.ToString();
                }
                else if ("BIRTH" == AttributeName[intIndex])
                {
                    mdteBIRTH = TransNullToDate(value.ToString());
                }
                else if ("PERSON_ID" == AttributeName[intIndex])
                {
                    mstrPERSON_ID = value.ToString();
                }
                else if ("STUDENT_ID" == AttributeName[intIndex])
                {
                    mstrSTUDENT_ID = value.ToString();
                }
                else if ("SCHOOL_NO" == AttributeName[intIndex])
                {
                    mstrSCHOOL_NO = value.ToString();
                }
                else if ("ACADEMY_NO" == AttributeName[intIndex])
                {
                    mstrACADEMY_NO = value.ToString();
                }
                else if ("DEP_NO" == AttributeName[intIndex])
                {
                    mstrDEP_NO = value.ToString();
                }
                else if ("CLASS_NO" == AttributeName[intIndex])
                {
                    mstrCLASS_NO = value.ToString();
                }
                else if ("GRADE" == AttributeName[intIndex])
                {
                    mstrGRADE = value.ToString();
                }
                else if ("IN_TIME" == AttributeName[intIndex])
                {
                    mdteIN_TIME = TransNullToDate(value.ToString());
                }
                else if ("WALLANCE" == AttributeName[intIndex])
                {
                    mdblWALLANCE = TransNullToDouble(value.ToString());
                }
                else if ("ADDRESS" == AttributeName[intIndex])
                {
                    mstrADDRESS = value.ToString();
                }
                else if ("PHONE" == AttributeName[intIndex])
                {
                    mstrPHONE = value.ToString();
                }
                else if ("POST_NO" == AttributeName[intIndex])
                {
                    mstrPOST_NO = value.ToString();
                }
                else if ("POST_ADDRESS" == AttributeName[intIndex])
                {
                    mstrPOST_ADDRESS = value.ToString();
                }
                else if ("MAIL" == AttributeName[intIndex])
                {
                    mstrMAIL = value.ToString();
                }
                else if ("DESCR" == AttributeName[intIndex])
                {
                    mstrDESCR = value.ToString();
                }
                else if ("USER_ID" == AttributeName[intIndex])
                {
                    mstrUSER_ID = value.ToString();
                }
                else if ("OP_DATE" == AttributeName[intIndex])
                {
                    mdteOP_DATE = TransNullToDate(value.ToString());
                }
                else if ("ANNEX" == AttributeName[intIndex])
                {
                    mstrANNEX = value.ToString();
                }
                else if ("UpdDate" == AttributeName[intIndex])
                {
                    mstrUpdDate = value.ToString();
                }
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        public string Account
        {
            get
            {
                return mstrAccount;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrAccount = value;
                }
                else
                {
                    mstrAccount = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("Account");
            }
        }
        /// <summary>
        /// SCH_ID
        /// </summary>
        public string SCH_ID
        {
            get
            {
                return mstrSCH_ID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSCH_ID = value;
                }
                else
                {
                    mstrSCH_ID = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("SCH_ID");
            }
        }
        /// <summary>
        /// �����ʺ�
        /// </summary>
        public string BANK_ACC
        {
            get
            {
                return mstrBANK_ACC;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrBANK_ACC = value;
                }
                else
                {
                    mstrBANK_ACC = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("BANK_ACC");
            }
        }
        /// <summary>
        /// CARD_NO
        /// </summary>
        public string CARD_NO
        {
            get
            {
                return mstrCARD_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrCARD_NO = value;
                }
                else
                {
                    mstrCARD_NO = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("CARD_NO");
            }
        }
        /// <summary>
        /// TEMP_CARD_NO
        /// </summary>
        public string TEMP_CARD_NO
        {
            get
            {
                return mstrTEMP_CARD_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTEMP_CARD_NO = value;
                }
                else
                {
                    mstrTEMP_CARD_NO = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("TEMP_CARD_NO");
            }
        }
        /// <summary>
        /// TEMP_USING
        /// </summary>
        public double TEMP_USING
        {
            get
            {
                return mdblTEMP_USING;
            }
            set
            {
                mdblTEMP_USING = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("TEMP_USING");
            }
        }
        /// <summary>
        /// TEMP_DEPOSIT
        /// </summary>
        public double TEMP_DEPOSIT
        {
            get
            {
                return mdblTEMP_DEPOSIT;
            }
            set
            {
                mdblTEMP_DEPOSIT = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("TEMP_DEPOSIT");
            }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string PASSWORD
        {
            get
            {
                return mstrPASSWORD;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPASSWORD = value;
                }
                else
                {
                    mstrPASSWORD = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("PASSWORD");
            }
        }
        /// <summary>
        /// MONEY
        /// </summary>
        public double MONEY
        {
            get
            {
                return mdblMONEY;
            }
            set
            {
                mdblMONEY = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("MONEY");
            }
        }
        /// <summary>
        /// CARD_KIND
        /// </summary>
        public double CARD_KIND
        {
            get
            {
                return mdblCARD_KIND;
            }
            set
            {
                mdblCARD_KIND = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("CARD_KIND");
            }
        }
        /// <summary>
        /// CARD_STATE
        /// </summary>
        public double CARD_STATE
        {
            get
            {
                return mdblCARD_STATE;
            }
            set
            {
                mdblCARD_STATE = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("CARD_STATE");
            }
        }
        /// <summary>
        /// LAST_TIME
        /// </summary>
        public DateTime LAST_TIME
        {
            get
            {
                return mdteLAST_TIME;
            }
            set
            {
                mdteLAST_TIME = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("LAST_TIME");
            }
        }
        /// <summary>
        /// USEFUL_LIMIT
        /// </summary>
        public DateTime USEFUL_LIMIT
        {
            get
            {
                return mdteUSEFUL_LIMIT;
            }
            set
            {
                mdteUSEFUL_LIMIT = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("USEFUL_LIMIT");
            }
        }
        /// <summary>
        /// RECYCLE_LIMIT
        /// </summary>
        public DateTime RECYCLE_LIMIT
        {
            get
            {
                return mdteRECYCLE_LIMIT;
            }
            set
            {
                mdteRECYCLE_LIMIT = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("RECYCLE_LIMIT");
            }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string NAME
        {
            get
            {
                return mstrNAME;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrNAME = value;
                }
                else
                {
                    mstrNAME = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("NAME");
            }
        }
        /// <summary>
        /// �Ա�
        /// </summary>
        public double SEX
        {
            get
            {
                return mdblSEX;
            }
            set
            {
                mdblSEX = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("SEX");
            }
        }
        /// <summary>
        /// IDEN_NO
        /// </summary>
        public double IDEN_NO
        {
            get
            {
                return mdblIDEN_NO;
            }
            set
            {
                mdblIDEN_NO = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("IDEN_NO");
            }
        }
        /// <summary>
        /// �������
        /// </summary>
        public double NATION_NO
        {
            get
            {
                return mdblNATION_NO;
            }
            set
            {
                mdblNATION_NO = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("NATION_NO");
            }
        }
        /// <summary>
        /// ������ò
        /// </summary>
        public string POLITICS
        {
            get
            {
                return mstrPOLITICS;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPOLITICS = value;
                }
                else
                {
                    mstrPOLITICS = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("POLITICS");
            }
        }
        /// <summary>
        /// DUTY
        /// </summary>
        public string DUTY
        {
            get
            {
                return mstrDUTY;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDUTY = value;
                }
                else
                {
                    mstrDUTY = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("DUTY");
            }
        }
        /// <summary>
        /// ��ѧʱ��
        /// </summary>
        public DateTime BIRTH
        {
            get
            {
                return mdteBIRTH;
            }
            set
            {
                mdteBIRTH = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("BIRTH");
            }
        }
        /// <summary>
        /// ���֤����
        /// </summary>
        public string PERSON_ID
        {
            get
            {
                return mstrPERSON_ID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPERSON_ID = value;
                }
                else
                {
                    mstrPERSON_ID = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("PERSON_ID");
            }
        }
        /// <summary>
        /// ѧ��
        /// </summary>
        public string STUDENT_ID
        {
            get
            {
                return mstrSTUDENT_ID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSTUDENT_ID = value;
                }
                else
                {
                    mstrSTUDENT_ID = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("STUDENT_ID");
            }
        }
        /// <summary>
        /// SCHOOL_NO
        /// </summary>
        public string SCHOOL_NO
        {
            get
            {
                return mstrSCHOOL_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSCHOOL_NO = value;
                }
                else
                {
                    mstrSCHOOL_NO = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("SCHOOL_NO");
            }
        }
        /// <summary>
        /// ѧԺ���
        /// </summary>
        public string ACADEMY_NO
        {
            get
            {
                return mstrACADEMY_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrACADEMY_NO = value;
                }
                else
                {
                    mstrACADEMY_NO = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("ACADEMY_NO");
            }
        }
        /// <summary>
        /// רҵ���
        /// </summary>
        public string DEP_NO
        {
            get
            {
                return mstrDEP_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDEP_NO = value;
                }
                else
                {
                    mstrDEP_NO = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("DEP_NO");
            }
        }
        /// <summary>
        /// �༶���
        /// </summary>
        public string CLASS_NO
        {
            get
            {
                return mstrCLASS_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrCLASS_NO = value;
                }
                else
                {
                    mstrCLASS_NO = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("CLASS_NO");
            }
        }
        /// <summary>
        /// �꼶
        /// </summary>
        public string GRADE
        {
            get
            {
                return mstrGRADE;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrGRADE = value;
                }
                else
                {
                    mstrGRADE = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("GRADE");
            }
        }
        /// <summary>
        /// IN_TIME
        /// </summary>
        public DateTime IN_TIME
        {
            get
            {
                return mdteIN_TIME;
            }
            set
            {
                mdteIN_TIME = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("IN_TIME");
            }
        }
        /// <summary>
        /// WALLANCE
        /// </summary>
        public double WALLANCE
        {
            get
            {
                return mdblWALLANCE;
            }
            set
            {
                mdblWALLANCE = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("WALLANCE");
            }
        }
        /// <summary>
        /// ��ͥסַ
        /// </summary>
        public string ADDRESS
        {
            get
            {
                return mstrADDRESS;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrADDRESS = value;
                }
                else
                {
                    mstrADDRESS = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("ADDRESS");
            }
        }
        /// <summary>
        /// �绰
        /// </summary>
        public string PHONE
        {
            get
            {
                return mstrPHONE;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPHONE = value;
                }
                else
                {
                    mstrPHONE = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("PHONE");
            }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string POST_NO
        {
            get
            {
                return mstrPOST_NO;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPOST_NO = value;
                }
                else
                {
                    mstrPOST_NO = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("POST_NO");
            }
        }
        /// <summary>
        /// ������ַ
        /// </summary>
        public string POST_ADDRESS
        {
            get
            {
                return mstrPOST_ADDRESS;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPOST_ADDRESS = value;
                }
                else
                {
                    mstrPOST_ADDRESS = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("POST_ADDRESS");
            }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string MAIL
        {
            get
            {
                return mstrMAIL;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrMAIL = value;
                }
                else
                {
                    mstrMAIL = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("MAIL");
            }
        }
        /// <summary>
        /// DESCR
        /// </summary>
        public string DESCR
        {
            get
            {
                return mstrDESCR;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDESCR = value;
                }
                else
                {
                    mstrDESCR = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("DESCR");
            }
        }
        /// <summary>
        /// �û�ID
        /// </summary>
        public string USER_ID
        {
            get
            {
                return mstrUSER_ID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrUSER_ID = value;
                }
                else
                {
                    mstrUSER_ID = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("USER_ID");
            }
        }
        /// <summary>
        /// OP_DATE
        /// </summary>
        public DateTime OP_DATE
        {
            get
            {
                return mdteOP_DATE;
            }
            set
            {
                mdteOP_DATE = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("OP_DATE");
            }
        }
        /// <summary>
        /// ANNEX
        /// </summary>
        public string ANNEX
        {
            get
            {
                return mstrANNEX;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrANNEX = value;
                }
                else
                {
                    mstrANNEX = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("ANNEX");
            }
        }
        /// <summary>
        /// UpdDate
        /// </summary>
        public string UpdDate
        {
            get
            {
                return mstrUpdDate;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrUpdDate = value;
                }
                else
                {
                    mstrUpdDate = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("UpdDate");
            }
        }

        /// <summary>
        /// ��ȡSQL���������Ӷ���
        /// </summary>
        /// <returns>SQL���������Ӷ���</returns>
        public static clsSpecSQLforSql GetSpecSQLObj()
        {
            clsSpecSQLforSql objSQL = null;
            //1. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�
            if (clsSysPara.bolIsUseConnectStrName == true)
            {
                objSQL = new clsSpecSQLforSql(clsSysPara.strConnectStrName, true);
                return objSQL;
            }
            //2. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�
            //3. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�
            if (string.IsNullOrEmpty(clsPERSON_q.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsPERSON_q.ConnectString);
            }
            return objSQL;
        }

        /// <summary>
        /// ��ȡSQL���������Ӷ���
        /// </summary>
        /// <returns>SQL���������Ӷ���</returns>
        public clsSpecSQLforSql GetSpecSQLObj_Obj()
        {
            clsSpecSQLforSql objSQL = null;
            //1. �����ǰ������ָ�������Ӵ�,���ö������Ӵ�
            if (string.IsNullOrEmpty(this.ConnectString_Obj) == false)
            {
                objSQL = new clsSpecSQLforSql(this.ConnectString_Obj);
                return objSQL;
            }
            //2. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�
            if (clsSysPara.bolIsUseConnectStrName == true)
            {
                objSQL = new clsSpecSQLforSql(clsSysPara.strConnectStrName, true);
                return objSQL;
            }
            //3. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�
            //4. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�
            if (string.IsNullOrEmpty(clsPERSON_q.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsPERSON_q.ConnectString);
            }
            return objSQL;
        }


        /// <summary>
        /// ����¼�¼
        /// </summary>
        /// <returns>����Ƿ�ɹ�?</returns>
        public bool AddNewRecord()
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            strSQL = "Select * from PERSON_q where 1=2";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "PERSON_q");
            objRow = objDS.Tables["PERSON_q"].NewRow();
            objRow["Account"] = mstrAccount; //����
            if (mstrSCH_ID != "")
            {
                objRow["SCH_ID"] = mstrSCH_ID; //SCH_ID
            }
            if (mstrBANK_ACC != "")
            {
                objRow["BANK_ACC"] = mstrBANK_ACC; //�����ʺ�
            }
            if (mstrCARD_NO != "")
            {
                objRow["CARD_NO"] = mstrCARD_NO; //CARD_NO
            }
            if (mstrTEMP_CARD_NO != "")
            {
                objRow["TEMP_CARD_NO"] = mstrTEMP_CARD_NO; //TEMP_CARD_NO
            }
            objRow["TEMP_USING"] = mdblTEMP_USING; //TEMP_USING
            objRow["TEMP_DEPOSIT"] = mdblTEMP_DEPOSIT; //TEMP_DEPOSIT
            if (mstrPASSWORD != "")
            {
                objRow["PASSWORD"] = mstrPASSWORD; //����
            }
            objRow["MONEY"] = mdblMONEY; //MONEY
            objRow["CARD_KIND"] = mdblCARD_KIND; //CARD_KIND
            objRow["CARD_STATE"] = mdblCARD_STATE; //CARD_STATE
            objRow["LAST_TIME"] = mdteLAST_TIME; //LAST_TIME
            objRow["USEFUL_LIMIT"] = mdteUSEFUL_LIMIT; //USEFUL_LIMIT
            objRow["RECYCLE_LIMIT"] = mdteRECYCLE_LIMIT; //RECYCLE_LIMIT
            if (mstrNAME != "")
            {
                objRow["NAME"] = mstrNAME; //����
            }
            objRow["SEX"] = mdblSEX; //�Ա�
            objRow["IDEN_NO"] = mdblIDEN_NO; //IDEN_NO
            objRow["NATION_NO"] = mdblNATION_NO; //�������
            if (mstrPOLITICS != "")
            {
                objRow["POLITICS"] = mstrPOLITICS; //������ò
            }
            if (mstrDUTY != "")
            {
                objRow["DUTY"] = mstrDUTY; //DUTY
            }
            objRow["BIRTH"] = mdteBIRTH; //��ѧʱ��
            if (mstrPERSON_ID != "")
            {
                objRow["PERSON_ID"] = mstrPERSON_ID; //���֤����
            }
            if (mstrSTUDENT_ID != "")
            {
                objRow["STUDENT_ID"] = mstrSTUDENT_ID; //ѧ��
            }
            if (mstrSCHOOL_NO != "")
            {
                objRow["SCHOOL_NO"] = mstrSCHOOL_NO; //SCHOOL_NO
            }
            if (mstrACADEMY_NO != "")
            {
                objRow["ACADEMY_NO"] = mstrACADEMY_NO; //ѧԺ���
            }
            if (mstrDEP_NO != "")
            {
                objRow["DEP_NO"] = mstrDEP_NO; //רҵ���
            }
            if (mstrCLASS_NO != "")
            {
                objRow["CLASS_NO"] = mstrCLASS_NO; //�༶���
            }
            if (mstrGRADE != "")
            {
                objRow["GRADE"] = mstrGRADE; //�꼶
            }
            objRow["IN_TIME"] = mdteIN_TIME; //IN_TIME
            objRow["WALLANCE"] = mdblWALLANCE; //WALLANCE
            if (mstrADDRESS != "")
            {
                objRow["ADDRESS"] = mstrADDRESS; //��ͥסַ
            }
            if (mstrPHONE != "")
            {
                objRow["PHONE"] = mstrPHONE; //�绰
            }
            if (mstrPOST_NO != "")
            {
                objRow["POST_NO"] = mstrPOST_NO; //��������
            }
            if (mstrPOST_ADDRESS != "")
            {
                objRow["POST_ADDRESS"] = mstrPOST_ADDRESS; //������ַ
            }
            if (mstrMAIL != "")
            {
                objRow["MAIL"] = mstrMAIL; //����
            }
            if (mstrDESCR != "")
            {
                objRow["DESCR"] = mstrDESCR; //DESCR
            }
            if (mstrUSER_ID != "")
            {
                objRow["USER_ID"] = mstrUSER_ID; //�û�ID
            }
            objRow["OP_DATE"] = mdteOP_DATE; //OP_DATE
            if (mstrANNEX != "")
            {
                objRow["ANNEX"] = mstrANNEX; //ANNEX
            }
            if (mstrUpdDate != "")
            {
                objRow["UpdDate"] = mstrUpdDate; //UpdDate
            }
            objDS.Tables["PERSON_q"].Rows.Add(objRow);
            try
            {
                objDA.Update(objDS, "PERSON_q");
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                objDA = null;
                objDS = null;
                objCB = null;
                objRow = null;
            }
            return true;
        }



        /// <summary>
        /// ���ܣ�ͨ��SQL�����������¼
        /// ��Ҫ�����ϴ��ļ�ʱ��
        /// </summary>
        /// <returns>�������ɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool AddNewRecordBySQL()
        {
            StringBuilder strSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            strSQL.AppendFormat("insert into PERSON_q (Account, SCH_ID, BANK_ACC, CARD_NO, TEMP_CARD_NO, TEMP_USING, TEMP_DEPOSIT, PASSWORD, MONEY, CARD_KIND, CARD_STATE, LAST_TIME, USEFUL_LIMIT, RECYCLE_LIMIT, NAME, SEX, IDEN_NO, NATION_NO, POLITICS, DUTY, BIRTH, PERSON_ID, STUDENT_ID, SCHOOL_NO, ACADEMY_NO, DEP_NO, CLASS_NO, GRADE, IN_TIME, WALLANCE, ADDRESS, PHONE, POST_NO, POST_ADDRESS, MAIL, DESCR, USER_ID, OP_DATE, ANNEX, UpdDate) values ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, '{7}', {8}, {9}, {10}, '{11}', '{12}', '{13}', '{14}', {15}, {16}, {17}, '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', {29}, '{30}', '{31}', '{32}', '{33}', '{34}', '{35}', '{36}', '{37}', '{38}', '{39}')", mstrAccount, mstrSCH_ID, mstrBANK_ACC, mstrCARD_NO, mstrTEMP_CARD_NO, mdblTEMP_USING, mdblTEMP_DEPOSIT, mstrPASSWORD, mdblMONEY, mdblCARD_KIND, mdblCARD_STATE, mdteLAST_TIME, mdteUSEFUL_LIMIT, mdteRECYCLE_LIMIT, mstrNAME, mdblSEX, mdblIDEN_NO, mdblNATION_NO, mstrPOLITICS, mstrDUTY, mdteBIRTH, mstrPERSON_ID, mstrSTUDENT_ID, mstrSCHOOL_NO, mstrACADEMY_NO, mstrDEP_NO, mstrCLASS_NO, mstrGRADE, mdteIN_TIME, mdblWALLANCE, mstrADDRESS, mstrPHONE, mstrPOST_NO, mstrPOST_ADDRESS, mstrMAIL, mstrDESCR, mstrUSER_ID, mdteOP_DATE, mstrANNEX, mstrUpdDate);
            return objSQL.ExecSql(strSQL.ToString());
        }



        /// <summary>
        /// /// ���ܣ�ͨ��SQL�����������¼,�÷�ʽ���Ż���ʽ
        /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ�ʹ�ֶ�ֵΪNULL���ֶ��������
        /// </summary>
        /// <returns>�������ɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool AddNewRecordBySQL2()
        {
            StringBuilder strSQL = new StringBuilder();
            //��Ҫ�������ֶ��б�
            ArrayList arrFieldListForInsert = new ArrayList();
            //��Ҫ������ֵ�б�
            ArrayList arrValueListForInsert = new ArrayList();
            if (mstrAccount != null)
            {
                arrFieldListForInsert.Add("Account");
                mstrAccount = mstrAccount.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrAccount + "'");
            }
            if (mstrSCH_ID != null)
            {
                arrFieldListForInsert.Add("SCH_ID");
                mstrSCH_ID = mstrSCH_ID.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrSCH_ID + "'");
            }
            if (mstrBANK_ACC != null)
            {
                arrFieldListForInsert.Add("BANK_ACC");
                mstrBANK_ACC = mstrBANK_ACC.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrBANK_ACC + "'");
            }
            if (mstrCARD_NO != null)
            {
                arrFieldListForInsert.Add("CARD_NO");
                mstrCARD_NO = mstrCARD_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrCARD_NO + "'");
            }
            if (mstrTEMP_CARD_NO != null)
            {
                arrFieldListForInsert.Add("TEMP_CARD_NO");
                mstrTEMP_CARD_NO = mstrTEMP_CARD_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrTEMP_CARD_NO + "'");
            }
            arrFieldListForInsert.Add("TEMP_USING");
            arrValueListForInsert.Add(mdblTEMP_USING.ToString());
            arrFieldListForInsert.Add("TEMP_DEPOSIT");
            arrValueListForInsert.Add(mdblTEMP_DEPOSIT.ToString());
            if (mstrPASSWORD != null)
            {
                arrFieldListForInsert.Add("PASSWORD");
                mstrPASSWORD = mstrPASSWORD.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrPASSWORD + "'");
            }
            arrFieldListForInsert.Add("MONEY");
            arrValueListForInsert.Add(mdblMONEY.ToString());
            arrFieldListForInsert.Add("CARD_KIND");
            arrValueListForInsert.Add(mdblCARD_KIND.ToString());
            arrFieldListForInsert.Add("CARD_STATE");
            arrValueListForInsert.Add(mdblCARD_STATE.ToString());
            arrFieldListForInsert.Add("LAST_TIME");
            arrValueListForInsert.Add("'" + mdteLAST_TIME + "'");
            arrFieldListForInsert.Add("USEFUL_LIMIT");
            arrValueListForInsert.Add("'" + mdteUSEFUL_LIMIT + "'");
            arrFieldListForInsert.Add("RECYCLE_LIMIT");
            arrValueListForInsert.Add("'" + mdteRECYCLE_LIMIT + "'");
            if (mstrNAME != null)
            {
                arrFieldListForInsert.Add("NAME");
                mstrNAME = mstrNAME.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrNAME + "'");
            }
            arrFieldListForInsert.Add("SEX");
            arrValueListForInsert.Add(mdblSEX.ToString());
            arrFieldListForInsert.Add("IDEN_NO");
            arrValueListForInsert.Add(mdblIDEN_NO.ToString());
            arrFieldListForInsert.Add("NATION_NO");
            arrValueListForInsert.Add(mdblNATION_NO.ToString());
            if (mstrPOLITICS != null)
            {
                arrFieldListForInsert.Add("POLITICS");
                mstrPOLITICS = mstrPOLITICS.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrPOLITICS + "'");
            }
            if (mstrDUTY != null)
            {
                arrFieldListForInsert.Add("DUTY");
                mstrDUTY = mstrDUTY.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrDUTY + "'");
            }
            arrFieldListForInsert.Add("BIRTH");
            arrValueListForInsert.Add("'" + mdteBIRTH + "'");
            if (mstrPERSON_ID != null)
            {
                arrFieldListForInsert.Add("PERSON_ID");
                mstrPERSON_ID = mstrPERSON_ID.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrPERSON_ID + "'");
            }
            if (mstrSTUDENT_ID != null)
            {
                arrFieldListForInsert.Add("STUDENT_ID");
                mstrSTUDENT_ID = mstrSTUDENT_ID.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrSTUDENT_ID + "'");
            }
            if (mstrSCHOOL_NO != null)
            {
                arrFieldListForInsert.Add("SCHOOL_NO");
                mstrSCHOOL_NO = mstrSCHOOL_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrSCHOOL_NO + "'");
            }
            if (mstrACADEMY_NO != null)
            {
                arrFieldListForInsert.Add("ACADEMY_NO");
                mstrACADEMY_NO = mstrACADEMY_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrACADEMY_NO + "'");
            }
            if (mstrDEP_NO != null)
            {
                arrFieldListForInsert.Add("DEP_NO");
                mstrDEP_NO = mstrDEP_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrDEP_NO + "'");
            }
            if (mstrCLASS_NO != null)
            {
                arrFieldListForInsert.Add("CLASS_NO");
                mstrCLASS_NO = mstrCLASS_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrCLASS_NO + "'");
            }
            if (mstrGRADE != null)
            {
                arrFieldListForInsert.Add("GRADE");
                mstrGRADE = mstrGRADE.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrGRADE + "'");
            }
            arrFieldListForInsert.Add("IN_TIME");
            arrValueListForInsert.Add("'" + mdteIN_TIME + "'");
            arrFieldListForInsert.Add("WALLANCE");
            arrValueListForInsert.Add(mdblWALLANCE.ToString());
            if (mstrADDRESS != null)
            {
                arrFieldListForInsert.Add("ADDRESS");
                mstrADDRESS = mstrADDRESS.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrADDRESS + "'");
            }
            if (mstrPHONE != null)
            {
                arrFieldListForInsert.Add("PHONE");
                mstrPHONE = mstrPHONE.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrPHONE + "'");
            }
            if (mstrPOST_NO != null)
            {
                arrFieldListForInsert.Add("POST_NO");
                mstrPOST_NO = mstrPOST_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrPOST_NO + "'");
            }
            if (mstrPOST_ADDRESS != null)
            {
                arrFieldListForInsert.Add("POST_ADDRESS");
                mstrPOST_ADDRESS = mstrPOST_ADDRESS.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrPOST_ADDRESS + "'");
            }
            if (mstrMAIL != null)
            {
                arrFieldListForInsert.Add("MAIL");
                mstrMAIL = mstrMAIL.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrMAIL + "'");
            }
            if (mstrDESCR != null)
            {
                arrFieldListForInsert.Add("DESCR");
                mstrDESCR = mstrDESCR.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrDESCR + "'");
            }
            if (mstrUSER_ID != null)
            {
                arrFieldListForInsert.Add("USER_ID");
                mstrUSER_ID = mstrUSER_ID.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrUSER_ID + "'");
            }
            arrFieldListForInsert.Add("OP_DATE");
            arrValueListForInsert.Add("'" + mdteOP_DATE + "'");
            if (mstrANNEX != null)
            {
                arrFieldListForInsert.Add("ANNEX");
                mstrANNEX = mstrANNEX.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrANNEX + "'");
            }
            if (mstrUpdDate != null)
            {
                arrFieldListForInsert.Add("UpdDate");
                mstrUpdDate = mstrUpdDate.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrUpdDate + "'");
            }
            //��֯�����¼SQL��
            string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
            string strFieldListCode = string.Join(",", sstrFieldCode);
            string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
            string strValuesListCode = string.Join(",", sstrValuesCode);
            strSQL.Append("Insert into PERSON_q");
            strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            return objSQL.ExecSql(strSQL.ToString());
        }



        /// <summary>
        /// ���ܣ�ͨ��SQL�����������¼
        /// ��Ҫ�����ϴ��ļ�ʱ��
        /// </summary>
        /// <returns>�������ɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool AddNewRecordBySQL(SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            StringBuilder strSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            strSQL.AppendFormat("insert into PERSON_q (Account, SCH_ID, BANK_ACC, CARD_NO, TEMP_CARD_NO, TEMP_USING, TEMP_DEPOSIT, PASSWORD, MONEY, CARD_KIND, CARD_STATE, LAST_TIME, USEFUL_LIMIT, RECYCLE_LIMIT, NAME, SEX, IDEN_NO, NATION_NO, POLITICS, DUTY, BIRTH, PERSON_ID, STUDENT_ID, SCHOOL_NO, ACADEMY_NO, DEP_NO, CLASS_NO, GRADE, IN_TIME, WALLANCE, ADDRESS, PHONE, POST_NO, POST_ADDRESS, MAIL, DESCR, USER_ID, OP_DATE, ANNEX, UpdDate) values ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, '{7}', {8}, {9}, {10}, '{11}', '{12}', '{13}', '{14}', {15}, {16}, {17}, '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', {29}, '{30}', '{31}', '{32}', '{33}', '{34}', '{35}', '{36}', '{37}', '{38}', '{39}')", mstrAccount, mstrSCH_ID, mstrBANK_ACC, mstrCARD_NO, mstrTEMP_CARD_NO, mdblTEMP_USING, mdblTEMP_DEPOSIT, mstrPASSWORD, mdblMONEY, mdblCARD_KIND, mdblCARD_STATE, mdteLAST_TIME, mdteUSEFUL_LIMIT, mdteRECYCLE_LIMIT, mstrNAME, mdblSEX, mdblIDEN_NO, mdblNATION_NO, mstrPOLITICS, mstrDUTY, mdteBIRTH, mstrPERSON_ID, mstrSTUDENT_ID, mstrSCHOOL_NO, mstrACADEMY_NO, mstrDEP_NO, mstrCLASS_NO, mstrGRADE, mdteIN_TIME, mdblWALLANCE, mstrADDRESS, mstrPHONE, mstrPOST_NO, mstrPOST_ADDRESS, mstrMAIL, mstrDESCR, mstrUSER_ID, mdteOP_DATE, mstrANNEX, mstrUpdDate);
            return objSQL.ExecSql(strSQL.ToString(), objSqlConnect, objSqlTransaction);
        }



        /// <summary>
        /// ���ܣ�ͨ��SQL�����������¼
        /// ��Ҫ�����ϴ��ļ�ʱ��
        /// </summary>
        /// <returns>�������ɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool AddNewRecordBySQL2(SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            StringBuilder strSQL = new StringBuilder();
            //��Ҫ�������ֶ��б�
            ArrayList arrFieldListForInsert = new ArrayList();
            //��Ҫ������ֵ�б�
            ArrayList arrValueListForInsert = new ArrayList();
            if (mstrAccount != null)
            {
                arrFieldListForInsert.Add("Account");
                mstrAccount = mstrAccount.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrAccount + "'");
            }
            if (mstrSCH_ID != null)
            {
                arrFieldListForInsert.Add("SCH_ID");
                mstrSCH_ID = mstrSCH_ID.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrSCH_ID + "'");
            }
            if (mstrBANK_ACC != null)
            {
                arrFieldListForInsert.Add("BANK_ACC");
                mstrBANK_ACC = mstrBANK_ACC.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrBANK_ACC + "'");
            }
            if (mstrCARD_NO != null)
            {
                arrFieldListForInsert.Add("CARD_NO");
                mstrCARD_NO = mstrCARD_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrCARD_NO + "'");
            }
            if (mstrTEMP_CARD_NO != null)
            {
                arrFieldListForInsert.Add("TEMP_CARD_NO");
                mstrTEMP_CARD_NO = mstrTEMP_CARD_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrTEMP_CARD_NO + "'");
            }
            arrFieldListForInsert.Add("TEMP_USING");
            arrValueListForInsert.Add(mdblTEMP_USING.ToString());
            arrFieldListForInsert.Add("TEMP_DEPOSIT");
            arrValueListForInsert.Add(mdblTEMP_DEPOSIT.ToString());
            if (mstrPASSWORD != null)
            {
                arrFieldListForInsert.Add("PASSWORD");
                mstrPASSWORD = mstrPASSWORD.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrPASSWORD + "'");
            }
            arrFieldListForInsert.Add("MONEY");
            arrValueListForInsert.Add(mdblMONEY.ToString());
            arrFieldListForInsert.Add("CARD_KIND");
            arrValueListForInsert.Add(mdblCARD_KIND.ToString());
            arrFieldListForInsert.Add("CARD_STATE");
            arrValueListForInsert.Add(mdblCARD_STATE.ToString());
            arrFieldListForInsert.Add("LAST_TIME");
            arrValueListForInsert.Add("'" + mdteLAST_TIME + "'");
            arrFieldListForInsert.Add("USEFUL_LIMIT");
            arrValueListForInsert.Add("'" + mdteUSEFUL_LIMIT + "'");
            arrFieldListForInsert.Add("RECYCLE_LIMIT");
            arrValueListForInsert.Add("'" + mdteRECYCLE_LIMIT + "'");
            if (mstrNAME != null)
            {
                arrFieldListForInsert.Add("NAME");
                mstrNAME = mstrNAME.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrNAME + "'");
            }
            arrFieldListForInsert.Add("SEX");
            arrValueListForInsert.Add(mdblSEX.ToString());
            arrFieldListForInsert.Add("IDEN_NO");
            arrValueListForInsert.Add(mdblIDEN_NO.ToString());
            arrFieldListForInsert.Add("NATION_NO");
            arrValueListForInsert.Add(mdblNATION_NO.ToString());
            if (mstrPOLITICS != null)
            {
                arrFieldListForInsert.Add("POLITICS");
                mstrPOLITICS = mstrPOLITICS.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrPOLITICS + "'");
            }
            if (mstrDUTY != null)
            {
                arrFieldListForInsert.Add("DUTY");
                mstrDUTY = mstrDUTY.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrDUTY + "'");
            }
            arrFieldListForInsert.Add("BIRTH");
            arrValueListForInsert.Add("'" + mdteBIRTH + "'");
            if (mstrPERSON_ID != null)
            {
                arrFieldListForInsert.Add("PERSON_ID");
                mstrPERSON_ID = mstrPERSON_ID.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrPERSON_ID + "'");
            }
            if (mstrSTUDENT_ID != null)
            {
                arrFieldListForInsert.Add("STUDENT_ID");
                mstrSTUDENT_ID = mstrSTUDENT_ID.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrSTUDENT_ID + "'");
            }
            if (mstrSCHOOL_NO != null)
            {
                arrFieldListForInsert.Add("SCHOOL_NO");
                mstrSCHOOL_NO = mstrSCHOOL_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrSCHOOL_NO + "'");
            }
            if (mstrACADEMY_NO != null)
            {
                arrFieldListForInsert.Add("ACADEMY_NO");
                mstrACADEMY_NO = mstrACADEMY_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrACADEMY_NO + "'");
            }
            if (mstrDEP_NO != null)
            {
                arrFieldListForInsert.Add("DEP_NO");
                mstrDEP_NO = mstrDEP_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrDEP_NO + "'");
            }
            if (mstrCLASS_NO != null)
            {
                arrFieldListForInsert.Add("CLASS_NO");
                mstrCLASS_NO = mstrCLASS_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrCLASS_NO + "'");
            }
            if (mstrGRADE != null)
            {
                arrFieldListForInsert.Add("GRADE");
                mstrGRADE = mstrGRADE.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrGRADE + "'");
            }
            arrFieldListForInsert.Add("IN_TIME");
            arrValueListForInsert.Add("'" + mdteIN_TIME + "'");
            arrFieldListForInsert.Add("WALLANCE");
            arrValueListForInsert.Add(mdblWALLANCE.ToString());
            if (mstrADDRESS != null)
            {
                arrFieldListForInsert.Add("ADDRESS");
                mstrADDRESS = mstrADDRESS.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrADDRESS + "'");
            }
            if (mstrPHONE != null)
            {
                arrFieldListForInsert.Add("PHONE");
                mstrPHONE = mstrPHONE.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrPHONE + "'");
            }
            if (mstrPOST_NO != null)
            {
                arrFieldListForInsert.Add("POST_NO");
                mstrPOST_NO = mstrPOST_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrPOST_NO + "'");
            }
            if (mstrPOST_ADDRESS != null)
            {
                arrFieldListForInsert.Add("POST_ADDRESS");
                mstrPOST_ADDRESS = mstrPOST_ADDRESS.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrPOST_ADDRESS + "'");
            }
            if (mstrMAIL != null)
            {
                arrFieldListForInsert.Add("MAIL");
                mstrMAIL = mstrMAIL.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrMAIL + "'");
            }
            if (mstrDESCR != null)
            {
                arrFieldListForInsert.Add("DESCR");
                mstrDESCR = mstrDESCR.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrDESCR + "'");
            }
            if (mstrUSER_ID != null)
            {
                arrFieldListForInsert.Add("USER_ID");
                mstrUSER_ID = mstrUSER_ID.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrUSER_ID + "'");
            }
            arrFieldListForInsert.Add("OP_DATE");
            arrValueListForInsert.Add("'" + mdteOP_DATE + "'");
            if (mstrANNEX != null)
            {
                arrFieldListForInsert.Add("ANNEX");
                mstrANNEX = mstrANNEX.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrANNEX + "'");
            }
            if (mstrUpdDate != null)
            {
                arrFieldListForInsert.Add("UpdDate");
                mstrUpdDate = mstrUpdDate.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrUpdDate + "'");
            }
            //��֯�����¼SQL��
            string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
            string strFieldListCode = string.Join(",", sstrFieldCode);
            string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
            string strValuesListCode = string.Join(",", sstrValuesCode);
            strSQL.Append("Insert into PERSON_q");
            strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            return objSQL.ExecSql(strSQL.ToString(), objSqlConnect, objSqlTransaction);
        }


        /// <summary>
        /// ���ܣ�ͨ���洢�����������¼
        /// </summary>
        /// <returns>�������ɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool AddnewPERSON_qBySP()
        {
            //ͨ���洢������
            //ֱ��ʹ��
            if (mintErrNo != 0)
            {
                //MsgBox(mstrErrMsg(mintErrNo))
                return false;
            }
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mstrAccount);
            values.Add(mstrSCH_ID);
            values.Add(mstrBANK_ACC);
            values.Add(mstrCARD_NO);
            values.Add(mstrTEMP_CARD_NO);
            values.Add(mdblTEMP_USING);
            values.Add(mdblTEMP_DEPOSIT);
            values.Add(mstrPASSWORD);
            values.Add(mdblMONEY);
            values.Add(mdblCARD_KIND);
            values.Add(mdblCARD_STATE);
            values.Add(mdteLAST_TIME);
            values.Add(mdteUSEFUL_LIMIT);
            values.Add(mdteRECYCLE_LIMIT);
            values.Add(mstrNAME);
            values.Add(mdblSEX);
            values.Add(mdblIDEN_NO);
            values.Add(mdblNATION_NO);
            values.Add(mstrPOLITICS);
            values.Add(mstrDUTY);
            values.Add(mdteBIRTH);
            values.Add(mstrPERSON_ID);
            values.Add(mstrSTUDENT_ID);
            values.Add(mstrSCHOOL_NO);
            values.Add(mstrACADEMY_NO);
            values.Add(mstrDEP_NO);
            values.Add(mstrCLASS_NO);
            values.Add(mstrGRADE);
            values.Add(mdteIN_TIME);
            values.Add(mdblWALLANCE);
            values.Add(mstrADDRESS);
            values.Add(mstrPHONE);
            values.Add(mstrPOST_NO);
            values.Add(mstrPOST_ADDRESS);
            values.Add(mstrMAIL);
            values.Add(mstrDESCR);
            values.Add(mstrUSER_ID);
            values.Add(mdteOP_DATE);
            values.Add(mstrANNEX);
            values.Add(mstrUpdDate);
            objSQL.ExecSP("p_Add_PERSON_q", values);
            return true;
        }

        /// <summary>
        /// �Ѷ�����¼ͬʱ���뵽����!
        /// </summary>
        /// <param name="oDT"></param>
        /// <param name="strResult"></param>
        /// <returns></returns>
        public bool AddnewPERSON_qs(System.Data.DataTable oDT, ref string strResult)
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            if (mintErrNo != 0)
            {
                strResult = "�����Ϊ��" + mintErrNo.ToString();
                return false;
            }
            strSQL = "Select * from PERSON_q where Account='111'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "PERSON_q");
            //���ؼ��ֵ�Ψһ��
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                string strAccount = oRow["Account"].ToString().Trim();
                if (IsExist(strAccount))
                {
                    strResult = "�ؼ���AccountΪ��" + strAccount + "�ļ�¼�Ѵ��ڣ������ظ�����!";
                    return false;
                }
            }
            //�Ѷ�����¼���뵽����
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                objRow = objDS.Tables["PERSON_q"].NewRow();
                objRow["Account"] = oRow["Account"].ToString().Trim(); //����
                objRow["SCH_ID"] = oRow["SCH_ID"].ToString().Trim(); //SCH_ID
                objRow["BANK_ACC"] = oRow["BANK_ACC"].ToString().Trim(); //�����ʺ�
                objRow["CARD_NO"] = oRow["CARD_NO"].ToString().Trim(); //CARD_NO
                objRow["TEMP_CARD_NO"] = oRow["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
                objRow["TEMP_USING"] = oRow["TEMP_USING"].ToString().Trim(); //TEMP_USING
                objRow["TEMP_DEPOSIT"] = oRow["TEMP_DEPOSIT"].ToString().Trim(); //TEMP_DEPOSIT
                objRow["PASSWORD"] = oRow["PASSWORD"].ToString().Trim(); //����
                objRow["MONEY"] = oRow["MONEY"].ToString().Trim(); //MONEY
                objRow["CARD_KIND"] = oRow["CARD_KIND"].ToString().Trim(); //CARD_KIND
                objRow["CARD_STATE"] = oRow["CARD_STATE"].ToString().Trim(); //CARD_STATE
                objRow["LAST_TIME"] = oRow["LAST_TIME"].ToString().Trim(); //LAST_TIME
                objRow["USEFUL_LIMIT"] = oRow["USEFUL_LIMIT"].ToString().Trim(); //USEFUL_LIMIT
                objRow["RECYCLE_LIMIT"] = oRow["RECYCLE_LIMIT"].ToString().Trim(); //RECYCLE_LIMIT
                objRow["NAME"] = oRow["NAME"].ToString().Trim(); //����
                objRow["SEX"] = oRow["SEX"].ToString().Trim(); //�Ա�
                objRow["IDEN_NO"] = oRow["IDEN_NO"].ToString().Trim(); //IDEN_NO
                objRow["NATION_NO"] = oRow["NATION_NO"].ToString().Trim(); //�������
                objRow["POLITICS"] = oRow["POLITICS"].ToString().Trim(); //������ò
                objRow["DUTY"] = oRow["DUTY"].ToString().Trim(); //DUTY
                objRow["BIRTH"] = oRow["BIRTH"].ToString().Trim(); //��ѧʱ��
                objRow["PERSON_ID"] = oRow["PERSON_ID"].ToString().Trim(); //���֤����
                objRow["STUDENT_ID"] = oRow["STUDENT_ID"].ToString().Trim(); //ѧ��
                objRow["SCHOOL_NO"] = oRow["SCHOOL_NO"].ToString().Trim(); //SCHOOL_NO
                objRow["ACADEMY_NO"] = oRow["ACADEMY_NO"].ToString().Trim(); //ѧԺ���
                objRow["DEP_NO"] = oRow["DEP_NO"].ToString().Trim(); //רҵ���
                objRow["CLASS_NO"] = oRow["CLASS_NO"].ToString().Trim(); //�༶���
                objRow["GRADE"] = oRow["GRADE"].ToString().Trim(); //�꼶
                objRow["IN_TIME"] = oRow["IN_TIME"].ToString().Trim(); //IN_TIME
                objRow["WALLANCE"] = oRow["WALLANCE"].ToString().Trim(); //WALLANCE
                objRow["ADDRESS"] = oRow["ADDRESS"].ToString().Trim(); //��ͥסַ
                objRow["PHONE"] = oRow["PHONE"].ToString().Trim(); //�绰
                objRow["POST_NO"] = oRow["POST_NO"].ToString().Trim(); //��������
                objRow["POST_ADDRESS"] = oRow["POST_ADDRESS"].ToString().Trim(); //������ַ
                objRow["MAIL"] = oRow["MAIL"].ToString().Trim(); //����
                objRow["DESCR"] = oRow["DESCR"].ToString().Trim(); //DESCR
                objRow["USER_ID"] = oRow["USER_ID"].ToString().Trim(); //�û�ID
                objRow["OP_DATE"] = oRow["OP_DATE"].ToString().Trim(); //OP_DATE
                objRow["ANNEX"] = oRow["ANNEX"].ToString().Trim(); //ANNEX
                objRow["UpdDate"] = oRow["UpdDate"].ToString().Trim(); //UpdDate
                objDS.Tables["PERSON_q"].Rows.Add(objRow);
            }
            try
            {
                objDA.Update(objDS, "PERSON_q");
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                objDA = null;
                objDS = null;
                objCB = null;
                objRow = null;
                objSQL.SQLConnect.Close();
                objSQL = null;
            }
            return true;
        }

        /// <summary>
        /// ���ܣ��޸ļ�¼
        /// </summary>
        /// <returns>����޸ĳɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool Update()
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            strSQL = "Select * from PERSON_q where Account=" + "'" + mstrAccount + "'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "PERSON_q");
            if (objDS.Tables["PERSON_q"].Rows.Count == 0)
            {
                //MsgBox("û����Ӧ��ID�ţ�Account=" + "'"+ mstrAccount+"'");
                return false;
            }
            objRow = objDS.Tables["PERSON_q"].Rows[0];
            if (IsUpdated("SCH_ID"))
            {
                objRow["SCH_ID"] = mstrSCH_ID; //SCH_ID
            }
            if (IsUpdated("BANK_ACC"))
            {
                objRow["BANK_ACC"] = mstrBANK_ACC; //�����ʺ�
            }
            if (IsUpdated("CARD_NO"))
            {
                objRow["CARD_NO"] = mstrCARD_NO; //CARD_NO
            }
            if (IsUpdated("TEMP_CARD_NO"))
            {
                objRow["TEMP_CARD_NO"] = mstrTEMP_CARD_NO; //TEMP_CARD_NO
            }
            if (IsUpdated("TEMP_USING"))
            {
                objRow["TEMP_USING"] = mdblTEMP_USING; //TEMP_USING
            }
            if (IsUpdated("TEMP_DEPOSIT"))
            {
                objRow["TEMP_DEPOSIT"] = mdblTEMP_DEPOSIT; //TEMP_DEPOSIT
            }
            if (IsUpdated("PASSWORD"))
            {
                objRow["PASSWORD"] = mstrPASSWORD; //����
            }
            if (IsUpdated("MONEY"))
            {
                objRow["MONEY"] = mdblMONEY; //MONEY
            }
            if (IsUpdated("CARD_KIND"))
            {
                objRow["CARD_KIND"] = mdblCARD_KIND; //CARD_KIND
            }
            if (IsUpdated("CARD_STATE"))
            {
                objRow["CARD_STATE"] = mdblCARD_STATE; //CARD_STATE
            }
            if (IsUpdated("LAST_TIME"))
            {
                objRow["LAST_TIME"] = mdteLAST_TIME; //LAST_TIME
            }
            if (IsUpdated("USEFUL_LIMIT"))
            {
                objRow["USEFUL_LIMIT"] = mdteUSEFUL_LIMIT; //USEFUL_LIMIT
            }
            if (IsUpdated("RECYCLE_LIMIT"))
            {
                objRow["RECYCLE_LIMIT"] = mdteRECYCLE_LIMIT; //RECYCLE_LIMIT
            }
            if (IsUpdated("NAME"))
            {
                objRow["NAME"] = mstrNAME; //����
            }
            if (IsUpdated("SEX"))
            {
                objRow["SEX"] = mdblSEX; //�Ա�
            }
            if (IsUpdated("IDEN_NO"))
            {
                objRow["IDEN_NO"] = mdblIDEN_NO; //IDEN_NO
            }
            if (IsUpdated("NATION_NO"))
            {
                objRow["NATION_NO"] = mdblNATION_NO; //�������
            }
            if (IsUpdated("POLITICS"))
            {
                objRow["POLITICS"] = mstrPOLITICS; //������ò
            }
            if (IsUpdated("DUTY"))
            {
                objRow["DUTY"] = mstrDUTY; //DUTY
            }
            if (IsUpdated("BIRTH"))
            {
                objRow["BIRTH"] = mdteBIRTH; //��ѧʱ��
            }
            if (IsUpdated("PERSON_ID"))
            {
                objRow["PERSON_ID"] = mstrPERSON_ID; //���֤����
            }
            if (IsUpdated("STUDENT_ID"))
            {
                objRow["STUDENT_ID"] = mstrSTUDENT_ID; //ѧ��
            }
            if (IsUpdated("SCHOOL_NO"))
            {
                objRow["SCHOOL_NO"] = mstrSCHOOL_NO; //SCHOOL_NO
            }
            if (IsUpdated("ACADEMY_NO"))
            {
                objRow["ACADEMY_NO"] = mstrACADEMY_NO; //ѧԺ���
            }
            if (IsUpdated("DEP_NO"))
            {
                objRow["DEP_NO"] = mstrDEP_NO; //רҵ���
            }
            if (IsUpdated("CLASS_NO"))
            {
                objRow["CLASS_NO"] = mstrCLASS_NO; //�༶���
            }
            if (IsUpdated("GRADE"))
            {
                objRow["GRADE"] = mstrGRADE; //�꼶
            }
            if (IsUpdated("IN_TIME"))
            {
                objRow["IN_TIME"] = mdteIN_TIME; //IN_TIME
            }
            if (IsUpdated("WALLANCE"))
            {
                objRow["WALLANCE"] = mdblWALLANCE; //WALLANCE
            }
            if (IsUpdated("ADDRESS"))
            {
                objRow["ADDRESS"] = mstrADDRESS; //��ͥסַ
            }
            if (IsUpdated("PHONE"))
            {
                objRow["PHONE"] = mstrPHONE; //�绰
            }
            if (IsUpdated("POST_NO"))
            {
                objRow["POST_NO"] = mstrPOST_NO; //��������
            }
            if (IsUpdated("POST_ADDRESS"))
            {
                objRow["POST_ADDRESS"] = mstrPOST_ADDRESS; //������ַ
            }
            if (IsUpdated("MAIL"))
            {
                objRow["MAIL"] = mstrMAIL; //����
            }
            if (IsUpdated("DESCR"))
            {
                objRow["DESCR"] = mstrDESCR; //DESCR
            }
            if (IsUpdated("USER_ID"))
            {
                objRow["USER_ID"] = mstrUSER_ID; //�û�ID
            }
            if (IsUpdated("OP_DATE"))
            {
                objRow["OP_DATE"] = mdteOP_DATE; //OP_DATE
            }
            if (IsUpdated("ANNEX"))
            {
                objRow["ANNEX"] = mstrANNEX; //ANNEX
            }
            if (IsUpdated("UpdDate"))
            {
                objRow["UpdDate"] = mstrUpdDate; //UpdDate
            }
            try
            {
                objDA.Update(objDS, "PERSON_q");
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                objDA = null;
                objDS = null;
                objCB = null;
                objRow = null;
            }
            return true;
        }


        /// <summary>
        /// /// ���ܣ�ͨ���洢����(StoreProcedure)���޸ļ�¼
        /// /// ȱ��:1������֧��������.
        /// </summary>
        /// <returns>����޸ĳɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool UpdatePERSON_qBySP()
        {
            //ͨ���洢������
            //ֱ��ʹ��
            if (mintErrNo != 0)
            {
                //MsgBox(mstrErrMsg(mintErrNo))
                return false;
            }
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mstrAccount);
            values.Add(mstrSCH_ID);
            values.Add(mstrBANK_ACC);
            values.Add(mstrCARD_NO);
            values.Add(mstrTEMP_CARD_NO);
            values.Add(mdblTEMP_USING);
            values.Add(mdblTEMP_DEPOSIT);
            values.Add(mstrPASSWORD);
            values.Add(mdblMONEY);
            values.Add(mdblCARD_KIND);
            values.Add(mdblCARD_STATE);
            values.Add(mdteLAST_TIME);
            values.Add(mdteUSEFUL_LIMIT);
            values.Add(mdteRECYCLE_LIMIT);
            values.Add(mstrNAME);
            values.Add(mdblSEX);
            values.Add(mdblIDEN_NO);
            values.Add(mdblNATION_NO);
            values.Add(mstrPOLITICS);
            values.Add(mstrDUTY);
            values.Add(mdteBIRTH);
            values.Add(mstrPERSON_ID);
            values.Add(mstrSTUDENT_ID);
            values.Add(mstrSCHOOL_NO);
            values.Add(mstrACADEMY_NO);
            values.Add(mstrDEP_NO);
            values.Add(mstrCLASS_NO);
            values.Add(mstrGRADE);
            values.Add(mdteIN_TIME);
            values.Add(mdblWALLANCE);
            values.Add(mstrADDRESS);
            values.Add(mstrPHONE);
            values.Add(mstrPOST_NO);
            values.Add(mstrPOST_ADDRESS);
            values.Add(mstrMAIL);
            values.Add(mstrDESCR);
            values.Add(mstrUSER_ID);
            values.Add(mdteOP_DATE);
            values.Add(mstrANNEX);
            values.Add(mstrUpdDate);
            objSQL.ExecSP("p_Upt_PERSON_q", values);
            return true;
        }

        /// <summary>
        /// /// ���ܣ�ͨ��SQL�������޸ļ�¼,�÷�ʽ�Ƿ��Ż���ʽ
        /// /// ȱ��:1�����ܴ����ֶ��еĵ�Ʋ���⣻2�����ܴ������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.
        /// </summary>
        /// <returns>����޸ĳɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool UpdateBySql()
        {
            StringBuilder sbSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            sbSQL.AppendFormat("Update PERSON_q Set ");
            sbSQL.AppendFormat("SCH_ID = '{0}'", mstrSCH_ID); //SCH_ID
            sbSQL.AppendFormat(", BANK_ACC = '{0}'", mstrBANK_ACC); //�����ʺ�
            sbSQL.AppendFormat(", CARD_NO = '{0}'", mstrCARD_NO); //CARD_NO
            sbSQL.AppendFormat(", TEMP_CARD_NO = '{0}'", mstrTEMP_CARD_NO); //TEMP_CARD_NO
            sbSQL.AppendFormat(", TEMP_USING = {0}", mdblTEMP_USING); //TEMP_USING
            sbSQL.AppendFormat(", TEMP_DEPOSIT = {0}", mdblTEMP_DEPOSIT); //TEMP_DEPOSIT
            sbSQL.AppendFormat(", PASSWORD = '{0}'", mstrPASSWORD); //����
            sbSQL.AppendFormat(", MONEY = {0}", mdblMONEY); //MONEY
            sbSQL.AppendFormat(", CARD_KIND = {0}", mdblCARD_KIND); //CARD_KIND
            sbSQL.AppendFormat(", CARD_STATE = {0}", mdblCARD_STATE); //CARD_STATE
            sbSQL.AppendFormat(", LAST_TIME = '{0}'", mdteLAST_TIME); //LAST_TIME
            sbSQL.AppendFormat(", USEFUL_LIMIT = '{0}'", mdteUSEFUL_LIMIT); //USEFUL_LIMIT
            sbSQL.AppendFormat(", RECYCLE_LIMIT = '{0}'", mdteRECYCLE_LIMIT); //RECYCLE_LIMIT
            sbSQL.AppendFormat(", NAME = '{0}'", mstrNAME); //����
            sbSQL.AppendFormat(", SEX = {0}", mdblSEX); //�Ա�
            sbSQL.AppendFormat(", IDEN_NO = {0}", mdblIDEN_NO); //IDEN_NO
            sbSQL.AppendFormat(", NATION_NO = {0}", mdblNATION_NO); //�������
            sbSQL.AppendFormat(", POLITICS = '{0}'", mstrPOLITICS); //������ò
            sbSQL.AppendFormat(", DUTY = '{0}'", mstrDUTY); //DUTY
            sbSQL.AppendFormat(", BIRTH = '{0}'", mdteBIRTH); //��ѧʱ��
            sbSQL.AppendFormat(", PERSON_ID = '{0}'", mstrPERSON_ID); //���֤����
            sbSQL.AppendFormat(", STUDENT_ID = '{0}'", mstrSTUDENT_ID); //ѧ��
            sbSQL.AppendFormat(", SCHOOL_NO = '{0}'", mstrSCHOOL_NO); //SCHOOL_NO
            sbSQL.AppendFormat(", ACADEMY_NO = '{0}'", mstrACADEMY_NO); //ѧԺ���
            sbSQL.AppendFormat(", DEP_NO = '{0}'", mstrDEP_NO); //רҵ���
            sbSQL.AppendFormat(", CLASS_NO = '{0}'", mstrCLASS_NO); //�༶���
            sbSQL.AppendFormat(", GRADE = '{0}'", mstrGRADE); //�꼶
            sbSQL.AppendFormat(", IN_TIME = '{0}'", mdteIN_TIME); //IN_TIME
            sbSQL.AppendFormat(", WALLANCE = {0}", mdblWALLANCE); //WALLANCE
            sbSQL.AppendFormat(", ADDRESS = '{0}'", mstrADDRESS); //��ͥסַ
            sbSQL.AppendFormat(", PHONE = '{0}'", mstrPHONE); //�绰
            sbSQL.AppendFormat(", POST_NO = '{0}'", mstrPOST_NO); //��������
            sbSQL.AppendFormat(", POST_ADDRESS = '{0}'", mstrPOST_ADDRESS); //������ַ
            sbSQL.AppendFormat(", MAIL = '{0}'", mstrMAIL); //����
            sbSQL.AppendFormat(", DESCR = '{0}'", mstrDESCR); //DESCR
            sbSQL.AppendFormat(", USER_ID = '{0}'", mstrUSER_ID); //�û�ID
            sbSQL.AppendFormat(", OP_DATE = '{0}'", mdteOP_DATE); //OP_DATE
            sbSQL.AppendFormat(", ANNEX = '{0}'", mstrANNEX); //ANNEX
            sbSQL.AppendFormat(", UpdDate = '{0}'", mstrUpdDate); //UpdDate
            sbSQL.AppendFormat("Where Account = '{0}'", mstrAccount);
            try
            {
                return objSQL.ExecSql(sbSQL.ToString());
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
        }


        /// <summary>
        /// /// ���ܣ�ͨ��SQL�������޸ļ�¼,�÷�ʽ���Ż���ʽ
        /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ��������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.
        /// </summary>
        /// <returns>����޸ĳɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool UpdateBySql2()
        {
            StringBuilder sbSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            sbSQL.AppendFormat("Update PERSON_q Set ");
            if (IsUpdated("SCH_ID"))
            {
                mstrSCH_ID = mstrSCH_ID.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" SCH_ID = '{0}',", mstrSCH_ID); //SCH_ID
            }
            if (IsUpdated("BANK_ACC"))
            {
                mstrBANK_ACC = mstrBANK_ACC.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" BANK_ACC = '{0}',", mstrBANK_ACC); //�����ʺ�
            }
            if (IsUpdated("CARD_NO"))
            {
                mstrCARD_NO = mstrCARD_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" CARD_NO = '{0}',", mstrCARD_NO); //CARD_NO
            }
            if (IsUpdated("TEMP_CARD_NO"))
            {
                mstrTEMP_CARD_NO = mstrTEMP_CARD_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" TEMP_CARD_NO = '{0}',", mstrTEMP_CARD_NO); //TEMP_CARD_NO
            }
            if (IsUpdated("TEMP_USING"))
            {
                sbSQL.AppendFormat(" TEMP_USING = {0},", mdblTEMP_USING); //TEMP_USING
            }
            if (IsUpdated("TEMP_DEPOSIT"))
            {
                sbSQL.AppendFormat(" TEMP_DEPOSIT = {0},", mdblTEMP_DEPOSIT); //TEMP_DEPOSIT
            }
            if (IsUpdated("PASSWORD"))
            {
                mstrPASSWORD = mstrPASSWORD.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" PASSWORD = '{0}',", mstrPASSWORD); //����
            }
            if (IsUpdated("MONEY"))
            {
                sbSQL.AppendFormat(" MONEY = {0},", mdblMONEY); //MONEY
            }
            if (IsUpdated("CARD_KIND"))
            {
                sbSQL.AppendFormat(" CARD_KIND = {0},", mdblCARD_KIND); //CARD_KIND
            }
            if (IsUpdated("CARD_STATE"))
            {
                sbSQL.AppendFormat(" CARD_STATE = {0},", mdblCARD_STATE); //CARD_STATE
            }
            if (IsUpdated("LAST_TIME"))
            {
                sbSQL.AppendFormat(" LAST_TIME = '{0}',", mdteLAST_TIME); //LAST_TIME
            }
            if (IsUpdated("USEFUL_LIMIT"))
            {
                sbSQL.AppendFormat(" USEFUL_LIMIT = '{0}',", mdteUSEFUL_LIMIT); //USEFUL_LIMIT
            }
            if (IsUpdated("RECYCLE_LIMIT"))
            {
                sbSQL.AppendFormat(" RECYCLE_LIMIT = '{0}',", mdteRECYCLE_LIMIT); //RECYCLE_LIMIT
            }
            if (IsUpdated("NAME"))
            {
                mstrNAME = mstrNAME.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" NAME = '{0}',", mstrNAME); //����
            }
            if (IsUpdated("SEX"))
            {
                sbSQL.AppendFormat(" SEX = {0},", mdblSEX); //�Ա�
            }
            if (IsUpdated("IDEN_NO"))
            {
                sbSQL.AppendFormat(" IDEN_NO = {0},", mdblIDEN_NO); //IDEN_NO
            }
            if (IsUpdated("NATION_NO"))
            {
                sbSQL.AppendFormat(" NATION_NO = {0},", mdblNATION_NO); //�������
            }
            if (IsUpdated("POLITICS"))
            {
                mstrPOLITICS = mstrPOLITICS.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" POLITICS = '{0}',", mstrPOLITICS); //������ò
            }
            if (IsUpdated("DUTY"))
            {
                mstrDUTY = mstrDUTY.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" DUTY = '{0}',", mstrDUTY); //DUTY
            }
            if (IsUpdated("BIRTH"))
            {
                sbSQL.AppendFormat(" BIRTH = '{0}',", mdteBIRTH); //��ѧʱ��
            }
            if (IsUpdated("PERSON_ID"))
            {
                mstrPERSON_ID = mstrPERSON_ID.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" PERSON_ID = '{0}',", mstrPERSON_ID); //���֤����
            }
            if (IsUpdated("STUDENT_ID"))
            {
                mstrSTUDENT_ID = mstrSTUDENT_ID.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" STUDENT_ID = '{0}',", mstrSTUDENT_ID); //ѧ��
            }
            if (IsUpdated("SCHOOL_NO"))
            {
                mstrSCHOOL_NO = mstrSCHOOL_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" SCHOOL_NO = '{0}',", mstrSCHOOL_NO); //SCHOOL_NO
            }
            if (IsUpdated("ACADEMY_NO"))
            {
                mstrACADEMY_NO = mstrACADEMY_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" ACADEMY_NO = '{0}',", mstrACADEMY_NO); //ѧԺ���
            }
            if (IsUpdated("DEP_NO"))
            {
                mstrDEP_NO = mstrDEP_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" DEP_NO = '{0}',", mstrDEP_NO); //רҵ���
            }
            if (IsUpdated("CLASS_NO"))
            {
                mstrCLASS_NO = mstrCLASS_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" CLASS_NO = '{0}',", mstrCLASS_NO); //�༶���
            }
            if (IsUpdated("GRADE"))
            {
                mstrGRADE = mstrGRADE.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" GRADE = '{0}',", mstrGRADE); //�꼶
            }
            if (IsUpdated("IN_TIME"))
            {
                sbSQL.AppendFormat(" IN_TIME = '{0}',", mdteIN_TIME); //IN_TIME
            }
            if (IsUpdated("WALLANCE"))
            {
                sbSQL.AppendFormat(" WALLANCE = {0},", mdblWALLANCE); //WALLANCE
            }
            if (IsUpdated("ADDRESS"))
            {
                mstrADDRESS = mstrADDRESS.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" ADDRESS = '{0}',", mstrADDRESS); //��ͥסַ
            }
            if (IsUpdated("PHONE"))
            {
                mstrPHONE = mstrPHONE.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" PHONE = '{0}',", mstrPHONE); //�绰
            }
            if (IsUpdated("POST_NO"))
            {
                mstrPOST_NO = mstrPOST_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" POST_NO = '{0}',", mstrPOST_NO); //��������
            }
            if (IsUpdated("POST_ADDRESS"))
            {
                mstrPOST_ADDRESS = mstrPOST_ADDRESS.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" POST_ADDRESS = '{0}',", mstrPOST_ADDRESS); //������ַ
            }
            if (IsUpdated("MAIL"))
            {
                mstrMAIL = mstrMAIL.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" MAIL = '{0}',", mstrMAIL); //����
            }
            if (IsUpdated("DESCR"))
            {
                mstrDESCR = mstrDESCR.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" DESCR = '{0}',", mstrDESCR); //DESCR
            }
            if (IsUpdated("USER_ID"))
            {
                mstrUSER_ID = mstrUSER_ID.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" USER_ID = '{0}',", mstrUSER_ID); //�û�ID
            }
            if (IsUpdated("OP_DATE"))
            {
                sbSQL.AppendFormat(" OP_DATE = '{0}',", mdteOP_DATE); //OP_DATE
            }
            if (IsUpdated("ANNEX"))
            {
                mstrANNEX = mstrANNEX.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" ANNEX = '{0}',", mstrANNEX); //ANNEX
            }
            if (IsUpdated("UpdDate"))
            {
                mstrUpdDate = mstrUpdDate.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" UpdDate = '{0}',", mstrUpdDate); //UpdDate
            }
            sbSQL.Remove(sbSQL.Length - 1, 1);
            sbSQL.AppendFormat(" Where Account = '{0}'", mstrAccount);
            try
            {
                return objSQL.ExecSql(sbSQL.ToString());
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
        }


        /// <summary>
        /// /// ���ܣ�ͨ��SQL�������޸ļ�¼,֧��������,�÷�ʽ�Ƿ��Ż���ʽ
        /// /// �ŵ�:1��֧��������.
        /// /// ȱ��:1�����ܴ����ֶ��еĵ�Ʋ���⣻
        /// ///      2�����ܴ������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�;
        /// </summary>
        /// <returns>����޸ĳɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool UpdateBySql(SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            StringBuilder sbSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            sbSQL.AppendFormat("Update PERSON_q Set ");
            sbSQL.AppendFormat("SCH_ID = '{0}'", mstrSCH_ID); //SCH_ID
            sbSQL.AppendFormat(", BANK_ACC = '{0}'", mstrBANK_ACC); //�����ʺ�
            sbSQL.AppendFormat(", CARD_NO = '{0}'", mstrCARD_NO); //CARD_NO
            sbSQL.AppendFormat(", TEMP_CARD_NO = '{0}'", mstrTEMP_CARD_NO); //TEMP_CARD_NO
            sbSQL.AppendFormat(", TEMP_USING = {0}", mdblTEMP_USING); //TEMP_USING
            sbSQL.AppendFormat(", TEMP_DEPOSIT = {0}", mdblTEMP_DEPOSIT); //TEMP_DEPOSIT
            sbSQL.AppendFormat(", PASSWORD = '{0}'", mstrPASSWORD); //����
            sbSQL.AppendFormat(", MONEY = {0}", mdblMONEY); //MONEY
            sbSQL.AppendFormat(", CARD_KIND = {0}", mdblCARD_KIND); //CARD_KIND
            sbSQL.AppendFormat(", CARD_STATE = {0}", mdblCARD_STATE); //CARD_STATE
            sbSQL.AppendFormat(", LAST_TIME = '{0}'", mdteLAST_TIME); //LAST_TIME
            sbSQL.AppendFormat(", USEFUL_LIMIT = '{0}'", mdteUSEFUL_LIMIT); //USEFUL_LIMIT
            sbSQL.AppendFormat(", RECYCLE_LIMIT = '{0}'", mdteRECYCLE_LIMIT); //RECYCLE_LIMIT
            sbSQL.AppendFormat(", NAME = '{0}'", mstrNAME); //����
            sbSQL.AppendFormat(", SEX = {0}", mdblSEX); //�Ա�
            sbSQL.AppendFormat(", IDEN_NO = {0}", mdblIDEN_NO); //IDEN_NO
            sbSQL.AppendFormat(", NATION_NO = {0}", mdblNATION_NO); //�������
            sbSQL.AppendFormat(", POLITICS = '{0}'", mstrPOLITICS); //������ò
            sbSQL.AppendFormat(", DUTY = '{0}'", mstrDUTY); //DUTY
            sbSQL.AppendFormat(", BIRTH = '{0}'", mdteBIRTH); //��ѧʱ��
            sbSQL.AppendFormat(", PERSON_ID = '{0}'", mstrPERSON_ID); //���֤����
            sbSQL.AppendFormat(", STUDENT_ID = '{0}'", mstrSTUDENT_ID); //ѧ��
            sbSQL.AppendFormat(", SCHOOL_NO = '{0}'", mstrSCHOOL_NO); //SCHOOL_NO
            sbSQL.AppendFormat(", ACADEMY_NO = '{0}'", mstrACADEMY_NO); //ѧԺ���
            sbSQL.AppendFormat(", DEP_NO = '{0}'", mstrDEP_NO); //רҵ���
            sbSQL.AppendFormat(", CLASS_NO = '{0}'", mstrCLASS_NO); //�༶���
            sbSQL.AppendFormat(", GRADE = '{0}'", mstrGRADE); //�꼶
            sbSQL.AppendFormat(", IN_TIME = '{0}'", mdteIN_TIME); //IN_TIME
            sbSQL.AppendFormat(", WALLANCE = {0}", mdblWALLANCE); //WALLANCE
            sbSQL.AppendFormat(", ADDRESS = '{0}'", mstrADDRESS); //��ͥסַ
            sbSQL.AppendFormat(", PHONE = '{0}'", mstrPHONE); //�绰
            sbSQL.AppendFormat(", POST_NO = '{0}'", mstrPOST_NO); //��������
            sbSQL.AppendFormat(", POST_ADDRESS = '{0}'", mstrPOST_ADDRESS); //������ַ
            sbSQL.AppendFormat(", MAIL = '{0}'", mstrMAIL); //����
            sbSQL.AppendFormat(", DESCR = '{0}'", mstrDESCR); //DESCR
            sbSQL.AppendFormat(", USER_ID = '{0}'", mstrUSER_ID); //�û�ID
            sbSQL.AppendFormat(", OP_DATE = '{0}'", mdteOP_DATE); //OP_DATE
            sbSQL.AppendFormat(", ANNEX = '{0}'", mstrANNEX); //ANNEX
            sbSQL.AppendFormat(", UpdDate = '{0}'", mstrUpdDate); //UpdDate
            sbSQL.AppendFormat("Where Account = '{0}'", mstrAccount);
            try
            {
                return objSQL.ExecSql(sbSQL.ToString(), objSqlConnect, objSqlTransaction);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
        }


        /// <summary>
        /// /// ���ܣ�ͨ��SQL�������޸ļ�¼,֧��������,�÷�ʽ���Ż���ʽ
        /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻
        /// ///      2���ܹ��������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�;
        /// ///      3��֧��������.
        /// </summary>
        /// <returns>����޸ĳɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool UpdateBySql2(SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            StringBuilder sbSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            sbSQL.AppendFormat("Update PERSON_q Set ");
            if (IsUpdated("Account"))
            {
                mstrAccount = mstrAccount.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" Account = '{0}',", mstrAccount); //����
            }
            if (IsUpdated("SCH_ID"))
            {
                mstrSCH_ID = mstrSCH_ID.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" SCH_ID = '{0}',", mstrSCH_ID); //SCH_ID
            }
            if (IsUpdated("BANK_ACC"))
            {
                mstrBANK_ACC = mstrBANK_ACC.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" BANK_ACC = '{0}',", mstrBANK_ACC); //�����ʺ�
            }
            if (IsUpdated("CARD_NO"))
            {
                mstrCARD_NO = mstrCARD_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" CARD_NO = '{0}',", mstrCARD_NO); //CARD_NO
            }
            if (IsUpdated("TEMP_CARD_NO"))
            {
                mstrTEMP_CARD_NO = mstrTEMP_CARD_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" TEMP_CARD_NO = '{0}',", mstrTEMP_CARD_NO); //TEMP_CARD_NO
            }
            if (IsUpdated("TEMP_USING"))
            {
                sbSQL.AppendFormat(" TEMP_USING = {0},", mdblTEMP_USING); //TEMP_USING
            }
            if (IsUpdated("TEMP_DEPOSIT"))
            {
                sbSQL.AppendFormat(" TEMP_DEPOSIT = {0},", mdblTEMP_DEPOSIT); //TEMP_DEPOSIT
            }
            if (IsUpdated("PASSWORD"))
            {
                mstrPASSWORD = mstrPASSWORD.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" PASSWORD = '{0}',", mstrPASSWORD); //����
            }
            if (IsUpdated("MONEY"))
            {
                sbSQL.AppendFormat(" MONEY = {0},", mdblMONEY); //MONEY
            }
            if (IsUpdated("CARD_KIND"))
            {
                sbSQL.AppendFormat(" CARD_KIND = {0},", mdblCARD_KIND); //CARD_KIND
            }
            if (IsUpdated("CARD_STATE"))
            {
                sbSQL.AppendFormat(" CARD_STATE = {0},", mdblCARD_STATE); //CARD_STATE
            }
            if (IsUpdated("LAST_TIME"))
            {
                sbSQL.AppendFormat(" LAST_TIME = '{0}',", mdteLAST_TIME); //LAST_TIME
            }
            if (IsUpdated("USEFUL_LIMIT"))
            {
                sbSQL.AppendFormat(" USEFUL_LIMIT = '{0}',", mdteUSEFUL_LIMIT); //USEFUL_LIMIT
            }
            if (IsUpdated("RECYCLE_LIMIT"))
            {
                sbSQL.AppendFormat(" RECYCLE_LIMIT = '{0}',", mdteRECYCLE_LIMIT); //RECYCLE_LIMIT
            }
            if (IsUpdated("NAME"))
            {
                mstrNAME = mstrNAME.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" NAME = '{0}',", mstrNAME); //����
            }
            if (IsUpdated("SEX"))
            {
                sbSQL.AppendFormat(" SEX = {0},", mdblSEX); //�Ա�
            }
            if (IsUpdated("IDEN_NO"))
            {
                sbSQL.AppendFormat(" IDEN_NO = {0},", mdblIDEN_NO); //IDEN_NO
            }
            if (IsUpdated("NATION_NO"))
            {
                sbSQL.AppendFormat(" NATION_NO = {0},", mdblNATION_NO); //�������
            }
            if (IsUpdated("POLITICS"))
            {
                mstrPOLITICS = mstrPOLITICS.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" POLITICS = '{0}',", mstrPOLITICS); //������ò
            }
            if (IsUpdated("DUTY"))
            {
                mstrDUTY = mstrDUTY.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" DUTY = '{0}',", mstrDUTY); //DUTY
            }
            if (IsUpdated("BIRTH"))
            {
                sbSQL.AppendFormat(" BIRTH = '{0}',", mdteBIRTH); //��ѧʱ��
            }
            if (IsUpdated("PERSON_ID"))
            {
                mstrPERSON_ID = mstrPERSON_ID.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" PERSON_ID = '{0}',", mstrPERSON_ID); //���֤����
            }
            if (IsUpdated("STUDENT_ID"))
            {
                mstrSTUDENT_ID = mstrSTUDENT_ID.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" STUDENT_ID = '{0}',", mstrSTUDENT_ID); //ѧ��
            }
            if (IsUpdated("SCHOOL_NO"))
            {
                mstrSCHOOL_NO = mstrSCHOOL_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" SCHOOL_NO = '{0}',", mstrSCHOOL_NO); //SCHOOL_NO
            }
            if (IsUpdated("ACADEMY_NO"))
            {
                mstrACADEMY_NO = mstrACADEMY_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" ACADEMY_NO = '{0}',", mstrACADEMY_NO); //ѧԺ���
            }
            if (IsUpdated("DEP_NO"))
            {
                mstrDEP_NO = mstrDEP_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" DEP_NO = '{0}',", mstrDEP_NO); //רҵ���
            }
            if (IsUpdated("CLASS_NO"))
            {
                mstrCLASS_NO = mstrCLASS_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" CLASS_NO = '{0}',", mstrCLASS_NO); //�༶���
            }
            if (IsUpdated("GRADE"))
            {
                mstrGRADE = mstrGRADE.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" GRADE = '{0}',", mstrGRADE); //�꼶
            }
            if (IsUpdated("IN_TIME"))
            {
                sbSQL.AppendFormat(" IN_TIME = '{0}',", mdteIN_TIME); //IN_TIME
            }
            if (IsUpdated("WALLANCE"))
            {
                sbSQL.AppendFormat(" WALLANCE = {0},", mdblWALLANCE); //WALLANCE
            }
            if (IsUpdated("ADDRESS"))
            {
                mstrADDRESS = mstrADDRESS.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" ADDRESS = '{0}',", mstrADDRESS); //��ͥסַ
            }
            if (IsUpdated("PHONE"))
            {
                mstrPHONE = mstrPHONE.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" PHONE = '{0}',", mstrPHONE); //�绰
            }
            if (IsUpdated("POST_NO"))
            {
                mstrPOST_NO = mstrPOST_NO.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" POST_NO = '{0}',", mstrPOST_NO); //��������
            }
            if (IsUpdated("POST_ADDRESS"))
            {
                mstrPOST_ADDRESS = mstrPOST_ADDRESS.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" POST_ADDRESS = '{0}',", mstrPOST_ADDRESS); //������ַ
            }
            if (IsUpdated("MAIL"))
            {
                mstrMAIL = mstrMAIL.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" MAIL = '{0}',", mstrMAIL); //����
            }
            if (IsUpdated("DESCR"))
            {
                mstrDESCR = mstrDESCR.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" DESCR = '{0}',", mstrDESCR); //DESCR
            }
            if (IsUpdated("USER_ID"))
            {
                mstrUSER_ID = mstrUSER_ID.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" USER_ID = '{0}',", mstrUSER_ID); //�û�ID
            }
            if (IsUpdated("OP_DATE"))
            {
                sbSQL.AppendFormat(" OP_DATE = '{0}',", mdteOP_DATE); //OP_DATE
            }
            if (IsUpdated("ANNEX"))
            {
                mstrANNEX = mstrANNEX.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" ANNEX = '{0}',", mstrANNEX); //ANNEX
            }
            if (IsUpdated("UpdDate"))
            {
                mstrUpdDate = mstrUpdDate.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" UpdDate = '{0}',", mstrUpdDate); //UpdDate
            }
            sbSQL.Remove(sbSQL.Length - 1, 1);
            sbSQL.AppendFormat(" Where Account = '{0}'", mstrAccount);
            try
            {
                return objSQL.ExecSql(sbSQL.ToString(), objSqlConnect, objSqlTransaction);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
        }



        /// <summary>
        /// ���ܣ��޸Ķ�����¼
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public int UpdateMultiRec(string strCondition)
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            //			System.Data.DataRow objRow ;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            int intRecCount;
            if (strCondition == "")
            {
                return 0; //��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
            }
            strSQL = "Select * from PERSON_q where " + strCondition;
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "PERSON_q");
            if (objDS.Tables["PERSON_q"].Rows.Count == 0)
            {
                return 0;
            }
            intRecCount = objDS.Tables["PERSON_q"].Rows.Count;
            foreach (System.Data.DataRow objRow in objDS.Tables["PERSON_q"].Rows)
            {
                objRow["SCH_ID"] = mstrSCH_ID; //SCH_ID
                objRow["BANK_ACC"] = mstrBANK_ACC; //�����ʺ�
                objRow["CARD_NO"] = mstrCARD_NO; //CARD_NO
                objRow["TEMP_CARD_NO"] = mstrTEMP_CARD_NO; //TEMP_CARD_NO
                objRow["TEMP_USING"] = mdblTEMP_USING; //TEMP_USING
                objRow["TEMP_DEPOSIT"] = mdblTEMP_DEPOSIT; //TEMP_DEPOSIT
                objRow["PASSWORD"] = mstrPASSWORD; //����
                objRow["MONEY"] = mdblMONEY; //MONEY
                objRow["CARD_KIND"] = mdblCARD_KIND; //CARD_KIND
                objRow["CARD_STATE"] = mdblCARD_STATE; //CARD_STATE
                objRow["LAST_TIME"] = mdteLAST_TIME; //LAST_TIME
                objRow["USEFUL_LIMIT"] = mdteUSEFUL_LIMIT; //USEFUL_LIMIT
                objRow["RECYCLE_LIMIT"] = mdteRECYCLE_LIMIT; //RECYCLE_LIMIT
                objRow["NAME"] = mstrNAME; //����
                objRow["SEX"] = mdblSEX; //�Ա�
                objRow["IDEN_NO"] = mdblIDEN_NO; //IDEN_NO
                objRow["NATION_NO"] = mdblNATION_NO; //�������
                objRow["POLITICS"] = mstrPOLITICS; //������ò
                objRow["DUTY"] = mstrDUTY; //DUTY
                objRow["BIRTH"] = mdteBIRTH; //��ѧʱ��
                objRow["PERSON_ID"] = mstrPERSON_ID; //���֤����
                objRow["STUDENT_ID"] = mstrSTUDENT_ID; //ѧ��
                objRow["SCHOOL_NO"] = mstrSCHOOL_NO; //SCHOOL_NO
                objRow["ACADEMY_NO"] = mstrACADEMY_NO; //ѧԺ���
                objRow["DEP_NO"] = mstrDEP_NO; //רҵ���
                objRow["CLASS_NO"] = mstrCLASS_NO; //�༶���
                objRow["GRADE"] = mstrGRADE; //�꼶
                objRow["IN_TIME"] = mdteIN_TIME; //IN_TIME
                objRow["WALLANCE"] = mdblWALLANCE; //WALLANCE
                objRow["ADDRESS"] = mstrADDRESS; //��ͥסַ
                objRow["PHONE"] = mstrPHONE; //�绰
                objRow["POST_NO"] = mstrPOST_NO; //��������
                objRow["POST_ADDRESS"] = mstrPOST_ADDRESS; //������ַ
                objRow["MAIL"] = mstrMAIL; //����
                objRow["DESCR"] = mstrDESCR; //DESCR
                objRow["USER_ID"] = mstrUSER_ID; //�û�ID
                objRow["OP_DATE"] = mdteOP_DATE; //OP_DATE
                objRow["ANNEX"] = mstrANNEX; //ANNEX
                objRow["UpdDate"] = mstrUpdDate; //UpdDate
            }
            try
            {
                objDA.Update(objDS, "PERSON_q");
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                objDA = null;
                objDS = null;
                objCB = null;
            }
            return intRecCount;
        }


        /// <summary>
        /// ���ܣ��ѵ�ǰ�����Ƶ��µĶ���
        /// </summary>
        /// <param name="objPERSON_q">�¶���,Ŀ�����</param>
        public void CopyTo(clsPERSON_q objPERSON_q)
        {
            objPERSON_q.Account = mstrAccount; //����
            objPERSON_q.SCH_ID = mstrSCH_ID; //SCH_ID
            objPERSON_q.BANK_ACC = mstrBANK_ACC; //�����ʺ�
            objPERSON_q.CARD_NO = mstrCARD_NO; //CARD_NO
            objPERSON_q.TEMP_CARD_NO = mstrTEMP_CARD_NO; //TEMP_CARD_NO
            objPERSON_q.TEMP_USING = mdblTEMP_USING; //TEMP_USING
            objPERSON_q.TEMP_DEPOSIT = mdblTEMP_DEPOSIT; //TEMP_DEPOSIT
            objPERSON_q.PASSWORD = mstrPASSWORD; //����
            objPERSON_q.MONEY = mdblMONEY; //MONEY
            objPERSON_q.CARD_KIND = mdblCARD_KIND; //CARD_KIND
            objPERSON_q.CARD_STATE = mdblCARD_STATE; //CARD_STATE
            objPERSON_q.LAST_TIME = mdteLAST_TIME; //LAST_TIME
            objPERSON_q.USEFUL_LIMIT = mdteUSEFUL_LIMIT; //USEFUL_LIMIT
            objPERSON_q.RECYCLE_LIMIT = mdteRECYCLE_LIMIT; //RECYCLE_LIMIT
            objPERSON_q.NAME = mstrNAME; //����
            objPERSON_q.SEX = mdblSEX; //�Ա�
            objPERSON_q.IDEN_NO = mdblIDEN_NO; //IDEN_NO
            objPERSON_q.NATION_NO = mdblNATION_NO; //�������
            objPERSON_q.POLITICS = mstrPOLITICS; //������ò
            objPERSON_q.DUTY = mstrDUTY; //DUTY
            objPERSON_q.BIRTH = mdteBIRTH; //��ѧʱ��
            objPERSON_q.PERSON_ID = mstrPERSON_ID; //���֤����
            objPERSON_q.STUDENT_ID = mstrSTUDENT_ID; //ѧ��
            objPERSON_q.SCHOOL_NO = mstrSCHOOL_NO; //SCHOOL_NO
            objPERSON_q.ACADEMY_NO = mstrACADEMY_NO; //ѧԺ���
            objPERSON_q.DEP_NO = mstrDEP_NO; //רҵ���
            objPERSON_q.CLASS_NO = mstrCLASS_NO; //�༶���
            objPERSON_q.GRADE = mstrGRADE; //�꼶
            objPERSON_q.IN_TIME = mdteIN_TIME; //IN_TIME
            objPERSON_q.WALLANCE = mdblWALLANCE; //WALLANCE
            objPERSON_q.ADDRESS = mstrADDRESS; //��ͥסַ
            objPERSON_q.PHONE = mstrPHONE; //�绰
            objPERSON_q.POST_NO = mstrPOST_NO; //��������
            objPERSON_q.POST_ADDRESS = mstrPOST_ADDRESS; //������ַ
            objPERSON_q.MAIL = mstrMAIL; //����
            objPERSON_q.DESCR = mstrDESCR; //DESCR
            objPERSON_q.USER_ID = mstrUSER_ID; //�û�ID
            objPERSON_q.OP_DATE = mdteOP_DATE; //OP_DATE
            objPERSON_q.ANNEX = mstrANNEX; //ANNEX
            objPERSON_q.UpdDate = mstrUpdDate; //UpdDate
        }

        /// <summary>
        /// ���ܣ���Դ�����Ƶ�Ŀ�����
        /// </summary>
        /// <param name="objPERSON_qS">Դ����</param>
        /// <param name="objPERSON_qT">Ŀ�����</param>
        public void CopyTo(clsPERSON_q objPERSON_qS, clsPERSON_q objPERSON_qT)
        {
            objPERSON_qT.Account = objPERSON_qS.Account; //����
            objPERSON_qT.SCH_ID = objPERSON_qS.SCH_ID; //SCH_ID
            objPERSON_qT.BANK_ACC = objPERSON_qS.BANK_ACC; //�����ʺ�
            objPERSON_qT.CARD_NO = objPERSON_qS.CARD_NO; //CARD_NO
            objPERSON_qT.TEMP_CARD_NO = objPERSON_qS.TEMP_CARD_NO; //TEMP_CARD_NO
            objPERSON_qT.TEMP_USING = objPERSON_qS.TEMP_USING; //TEMP_USING
            objPERSON_qT.TEMP_DEPOSIT = objPERSON_qS.TEMP_DEPOSIT; //TEMP_DEPOSIT
            objPERSON_qT.PASSWORD = objPERSON_qS.PASSWORD; //����
            objPERSON_qT.MONEY = objPERSON_qS.MONEY; //MONEY
            objPERSON_qT.CARD_KIND = objPERSON_qS.CARD_KIND; //CARD_KIND
            objPERSON_qT.CARD_STATE = objPERSON_qS.CARD_STATE; //CARD_STATE
            objPERSON_qT.LAST_TIME = objPERSON_qS.LAST_TIME; //LAST_TIME
            objPERSON_qT.USEFUL_LIMIT = objPERSON_qS.USEFUL_LIMIT; //USEFUL_LIMIT
            objPERSON_qT.RECYCLE_LIMIT = objPERSON_qS.RECYCLE_LIMIT; //RECYCLE_LIMIT
            objPERSON_qT.NAME = objPERSON_qS.NAME; //����
            objPERSON_qT.SEX = objPERSON_qS.SEX; //�Ա�
            objPERSON_qT.IDEN_NO = objPERSON_qS.IDEN_NO; //IDEN_NO
            objPERSON_qT.NATION_NO = objPERSON_qS.NATION_NO; //�������
            objPERSON_qT.POLITICS = objPERSON_qS.POLITICS; //������ò
            objPERSON_qT.DUTY = objPERSON_qS.DUTY; //DUTY
            objPERSON_qT.BIRTH = objPERSON_qS.BIRTH; //��ѧʱ��
            objPERSON_qT.PERSON_ID = objPERSON_qS.PERSON_ID; //���֤����
            objPERSON_qT.STUDENT_ID = objPERSON_qS.STUDENT_ID; //ѧ��
            objPERSON_qT.SCHOOL_NO = objPERSON_qS.SCHOOL_NO; //SCHOOL_NO
            objPERSON_qT.ACADEMY_NO = objPERSON_qS.ACADEMY_NO; //ѧԺ���
            objPERSON_qT.DEP_NO = objPERSON_qS.DEP_NO; //רҵ���
            objPERSON_qT.CLASS_NO = objPERSON_qS.CLASS_NO; //�༶���
            objPERSON_qT.GRADE = objPERSON_qS.GRADE; //�꼶
            objPERSON_qT.IN_TIME = objPERSON_qS.IN_TIME; //IN_TIME
            objPERSON_qT.WALLANCE = objPERSON_qS.WALLANCE; //WALLANCE
            objPERSON_qT.ADDRESS = objPERSON_qS.ADDRESS; //��ͥסַ
            objPERSON_qT.PHONE = objPERSON_qS.PHONE; //�绰
            objPERSON_qT.POST_NO = objPERSON_qS.POST_NO; //��������
            objPERSON_qT.POST_ADDRESS = objPERSON_qS.POST_ADDRESS; //������ַ
            objPERSON_qT.MAIL = objPERSON_qS.MAIL; //����
            objPERSON_qT.DESCR = objPERSON_qS.DESCR; //DESCR
            objPERSON_qT.USER_ID = objPERSON_qS.USER_ID; //�û�ID
            objPERSON_qT.OP_DATE = objPERSON_qS.OP_DATE; //OP_DATE
            objPERSON_qT.ANNEX = objPERSON_qS.ANNEX; //ANNEX
            objPERSON_qT.UpdDate = objPERSON_qS.UpdDate; //UpdDate
        }

        /// <summary>
        /// ͬ����¼���Ѽ�¼ͬ������һ����������
        /// </summary>
        /// <param name="strConnectStringT">����Ŀ������������Ӵ�</param>
        /// <param name="objPERSON_q">��Ҫͬ���Ķ����¼</param>
        /// <returns>�Ѿ�ͬ���ļ�¼��</returns>
        public static int SynchRecordToServerB(string strConnectStringT, clsPERSON_q objPERSON_q)
        {
            objPERSON_q.ConnectString_Obj = strConnectStringT;
            //����ڱ����Ƿ���<IsArchive>�ֶ�
            if (objPERSON_q["IsArchive"] != null)
            {
                bool bolIsArchive = bool.Parse(objPERSON_q["IsArchive"].ToString());
                //����Ѿ��鵵,�Ͳ���Ҫ�ٹ鵵
                if (bolIsArchive == true)
                {
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("�ؼ���:{0}�ļ�¼,�ڵ�ǰ�������Ѿ��鵵,����Ҫ��ͬ��.",
                    objPERSON_q.Account);
                    throw new Exception(sbMsg.ToString());
                }
            }
            //�����Ŀ������Ƿ����
            if (objPERSON_q.IsExist() == false)
            {
                //���������,�����
                objPERSON_q.AddNewRecordBySQL2();
                return 1;
            }
            else
            {
                clsPERSON_q objPERSON_qT = null;
                //�������,���޸�.
                //����Ƿ���<UptDate>�ֶ�
                if (objPERSON_q["UptDate"] != null)
                {
                    string strUptDate = objPERSON_q["UptDate"].ToString();
                    //��ȡĿ��������е�ͬ�ؼ��ֵļ�¼
                    objPERSON_qT = new clsPERSON_q();
                    objPERSON_qT.Account = objPERSON_q.Account;
                    objPERSON_qT.ConnectString_Obj = strConnectStringT;
                    objPERSON_qT.GetPERSON_q();
                    string strUptDateT = objPERSON_qT["UptDate"].ToString();
                    if (strUptDateT.CompareTo(strUptDate) > 0)
                    {
                        StringBuilder sbMsg = new StringBuilder();
                        sbMsg.AppendFormat("�ؼ���:{0}�ļ�¼,�ڵ�ǰ��������Ŀ¼��������,����ͬ��.��ǰ��¼���޸�ʱ��:{1},��Ŀ���¼���޸�ʱ��:{2}.",
                        objPERSON_q.Account,
                        strUptDate,
                        strUptDateT);
                        throw new Exception(sbMsg.ToString());
                    }
                }
                objPERSON_q.CopyTo(objPERSON_qT);
                objPERSON_qT.UpdateBySql2();
                return 1;
            }
        }

        /// <summary>
        /// ���ܣ�ɾ����ǰ������ָ�ļ�¼
        /// </summary>
        /// <returns>���ɾ���ɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool DelRecord()
        {
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            //ɾ��PERSON_q�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from PERSON_q where Account=" + "'" + mstrAccount + "'";
            return objSQL.ExecSql(strSQL);
        }


        /// <summary>
        /// ���ܣ�ɾ����ǰ������ָ�ļ�¼,ͨ���洢������ʵ��
        /// </summary>
        /// <returns>���ɾ���ɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool DelRecordBySP()
        {
            //ͨ���洢������
            //ֱ��ʹ��
            if (mintErrNo != 0)
            {
                //MsgBox(mstrErrMsg(mintErrNo))
                return false;
            }
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mstrAccount);
            objSQL.ExecSP("p_Del_PERSON_q", values);
            return true;
        }

        /// <summary>
        /// ���ܣ���ǰ������ָ�ļ�¼
        /// </summary>
        /// <param name="objSqlConnect">Sql���Ӷ���</param>
        /// <param name="objSqlTransaction">Sql�������</param>
        /// <returns>����ɾ���ļ�¼0��</returns>
        public bool DelRecord(SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            //ɾ��PERSON_q�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from PERSON_q where Account=" + "'" + mstrAccount + "'";
            return objSQL.ExecSql(strSQL, objSqlConnect, objSqlTransaction);
        }


        /// <summary>
        /// ���ܣ�ͬʱɾ��������¼
        /// </summary>
        /// <param name="lstKey">�����Ĺؼ���ֵ�б�</param>
        /// <returns>����ɾ���Ƿ�ɹ�?</returns>
        public static bool DelPERSON_q(ArrayList lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsPERSON_q.GetSpecSQLObj();
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
                else strKeyList += "," + "'" + lstKey[i].ToString() + "'";
            }
            strSQL = "";
            //ɾ��PERSON_q�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from PERSON_q where Account in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }

        /// <summary>
        /// ���ܣ�ͬʱɾ��������¼
        /// </summary>
        /// <param name="lstKey">�����Ĺؼ���ֵ�б�</param>
        /// <param name="objSqlConnect">Sql���Ӷ���</param>
        /// <param name="objSqlTransaction">Sql�������</param>
        /// <returns>����ɾ���Ƿ�ɹ�?��</returns>
        public static bool DelPERSON_q(ArrayList lstKey, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsPERSON_q.GetSpecSQLObj();
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
                else strKeyList += "," + "'" + lstKey[i].ToString() + "'";
            }
            strSQL = "";
            //ɾ��PERSON_q�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from PERSON_q where Account in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL, objSqlConnect, objSqlTransaction);
        }

        /// <summary>
        /// ���ܣ�ɾ���ؼ�����ָ���ļ�¼
        /// </summary>
        /// <param name="strAccount">�����Ĺؼ���ֵ</param>
        /// <returns>���ɾ���ɹ��򷵻�TRUE������ΪFALSE</returns>
        public static bool DelRecord(string strAccount)
        {
            //ɾ��������¼
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsPERSON_q.GetSpecSQLObj();
            //ɾ��PERSON_q�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from PERSON_q where Account=" + "'" + strAccount + "'";
            return objSQL.ExecSql(strSQL);
        }

        /// <summary>
        /// ���ܣ���ǰ������ָ�ļ�¼
        /// </summary>
        /// <param name="strAccount">�����Ĺؼ���ֵ</param>
        /// <param name="objSqlConnect">Sql���Ӷ���</param>
        /// <param name="objSqlTransaction">Sql�������</param>
        /// <returns>����ɾ���ļ�¼0��</returns>
        public static bool DelRecord(string strAccount, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            //ɾ��������¼
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsPERSON_q.GetSpecSQLObj();
            //ɾ��PERSON_q�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from PERSON_q where Account=" + "'" + strAccount + "'";
            return objSQL.ExecSql(strSQL, objSqlConnect, objSqlTransaction);
        }


        /// <summary>
        /// ���ܣ�ɾ��������¼����������ɾ��
        /// </summary>
        /// <param name="strCondition">��Ҫɾ���ļ�¼����</param>
        /// <returns>����ɾ���ļ�¼0��</returns>
        public static int DelPERSON_q(string strCondition)
        {
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsPERSON_q.GetSpecSQLObj();
            string strSQL;
            if (strCondition == "")
            {
                return 0;	//��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
            }
            else
            {
                strSQL = "Delete from PERSON_q where " + strCondition;
            }
            int intRecoCount = objSQL.ExecSql2(strSQL);
            return intRecoCount;
        }



        /// <summary>
        /// ���ܣ�ɾ��������¼����������ɾ��
        /// </summary>
        /// <param name="strCondition">��Ҫɾ���ļ�¼����</param>
        /// <param name="objSqlConnect">Sql���Ӷ���</param>
        /// <param name="objSqlTransaction">Sql�������</param>
        /// <returns>����ɾ���ļ�¼0��</returns>
        public static int DelPERSON_q(string strCondition, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsPERSON_q.GetSpecSQLObj();
            string strSQL;
            if (strCondition == "")
            {
                return 0;	//��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
            }
            else
            {
                strSQL = "Delete from PERSON_q where " + strCondition;
            }
            int intRecoCount = objSQL.ExecSql2(strSQL, objSqlConnect, objSqlTransaction);
            return intRecoCount;
        }


        /// <summary>
        /// ��ȡ��ǰ�ؼ��ֵļ�¼����,�ö������ʽ��ʾ.
        /// </summary>
        /// <returns>�Ƿ�ɹ�</returns>
        public bool GetPERSON_q()
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            strSQL = "Select * from PERSON_q where Account=" + "'" + mstrAccount + "'";
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            mstrAccount = objDT.Rows[0]["Account"].ToString().Trim(); //����
            mstrSCH_ID = objDT.Rows[0]["SCH_ID"].ToString().Trim(); //SCH_ID
            mstrBANK_ACC = objDT.Rows[0]["BANK_ACC"].ToString().Trim(); //�����ʺ�
            mstrCARD_NO = objDT.Rows[0]["CARD_NO"].ToString().Trim(); //CARD_NO
            mstrTEMP_CARD_NO = objDT.Rows[0]["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
            mdblTEMP_USING = TransNullToDouble(objDT.Rows[0]["TEMP_USING"].ToString().Trim()); //TEMP_USING
            mdblTEMP_DEPOSIT = TransNullToDouble(objDT.Rows[0]["TEMP_DEPOSIT"].ToString().Trim()); //TEMP_DEPOSIT
            mstrPASSWORD = objDT.Rows[0]["PASSWORD"].ToString().Trim(); //����
            mdblMONEY = TransNullToDouble(objDT.Rows[0]["MONEY"].ToString().Trim()); //MONEY
            mdblCARD_KIND = TransNullToDouble(objDT.Rows[0]["CARD_KIND"].ToString().Trim()); //CARD_KIND
            mdblCARD_STATE = TransNullToDouble(objDT.Rows[0]["CARD_STATE"].ToString().Trim()); //CARD_STATE
            mdteLAST_TIME = TransNullToDate(objDT.Rows[0]["LAST_TIME"].ToString().Trim()); //LAST_TIME
            mdteUSEFUL_LIMIT = TransNullToDate(objDT.Rows[0]["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
            mdteRECYCLE_LIMIT = TransNullToDate(objDT.Rows[0]["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
            mstrNAME = objDT.Rows[0]["NAME"].ToString().Trim(); //����
            mdblSEX = TransNullToDouble(objDT.Rows[0]["SEX"].ToString().Trim()); //�Ա�
            mdblIDEN_NO = TransNullToDouble(objDT.Rows[0]["IDEN_NO"].ToString().Trim()); //IDEN_NO
            mdblNATION_NO = TransNullToDouble(objDT.Rows[0]["NATION_NO"].ToString().Trim()); //�������
            mstrPOLITICS = objDT.Rows[0]["POLITICS"].ToString().Trim(); //������ò
            mstrDUTY = objDT.Rows[0]["DUTY"].ToString().Trim(); //DUTY
            mdteBIRTH = TransNullToDate(objDT.Rows[0]["BIRTH"].ToString().Trim()); //��ѧʱ��
            mstrPERSON_ID = objDT.Rows[0]["PERSON_ID"].ToString().Trim(); //���֤����
            mstrSTUDENT_ID = objDT.Rows[0]["STUDENT_ID"].ToString().Trim(); //ѧ��
            mstrSCHOOL_NO = objDT.Rows[0]["SCHOOL_NO"].ToString().Trim(); //SCHOOL_NO
            mstrACADEMY_NO = objDT.Rows[0]["ACADEMY_NO"].ToString().Trim(); //ѧԺ���
            mstrDEP_NO = objDT.Rows[0]["DEP_NO"].ToString().Trim(); //רҵ���
            mstrCLASS_NO = objDT.Rows[0]["CLASS_NO"].ToString().Trim(); //�༶���
            mstrGRADE = objDT.Rows[0]["GRADE"].ToString().Trim(); //�꼶
            mdteIN_TIME = TransNullToDate(objDT.Rows[0]["IN_TIME"].ToString().Trim()); //IN_TIME
            mdblWALLANCE = TransNullToDouble(objDT.Rows[0]["WALLANCE"].ToString().Trim()); //WALLANCE
            mstrADDRESS = objDT.Rows[0]["ADDRESS"].ToString().Trim(); //��ͥסַ
            mstrPHONE = objDT.Rows[0]["PHONE"].ToString().Trim(); //�绰
            mstrPOST_NO = objDT.Rows[0]["POST_NO"].ToString().Trim(); //��������
            mstrPOST_ADDRESS = objDT.Rows[0]["POST_ADDRESS"].ToString().Trim(); //������ַ
            mstrMAIL = objDT.Rows[0]["MAIL"].ToString().Trim(); //����
            mstrDESCR = objDT.Rows[0]["DESCR"].ToString().Trim(); //DESCR
            mstrUSER_ID = objDT.Rows[0]["USER_ID"].ToString().Trim(); //�û�ID
            mdteOP_DATE = TransNullToDate(objDT.Rows[0]["OP_DATE"].ToString().Trim()); //OP_DATE
            mstrANNEX = objDT.Rows[0]["ANNEX"].ToString().Trim(); //ANNEX
            mstrUpdDate = objDT.Rows[0]["UpdDate"].ToString().Trim(); //UpdDate
            objDT = null;
            return true;
        }

        /// <summary>
        /// ��DataRowת���ɼ�¼����.
        /// </summary>
        /// <param name="objRow">������DataRow</param>
        /// <returns>��¼����</returns>
        public clsPERSON_q GetPERSON_qObjByDataRow(DataRow objRow)
        {
            if (objRow == null)
            {
                return null;
            }
            clsPERSON_q objPERSON_q = new clsPERSON_q();
            objPERSON_q.Account = objRow["Account"].ToString().Trim(); //����
            objPERSON_q.SCH_ID = objRow["SCH_ID"].ToString().Trim(); //SCH_ID
            objPERSON_q.BANK_ACC = objRow["BANK_ACC"].ToString().Trim(); //�����ʺ�
            objPERSON_q.CARD_NO = objRow["CARD_NO"].ToString().Trim(); //CARD_NO
            objPERSON_q.TEMP_CARD_NO = objRow["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
            objPERSON_q.TEMP_USING = TransNullToDouble(objRow["TEMP_USING"].ToString().Trim()); //TEMP_USING
            objPERSON_q.TEMP_DEPOSIT = TransNullToDouble(objRow["TEMP_DEPOSIT"].ToString().Trim()); //TEMP_DEPOSIT
            objPERSON_q.PASSWORD = objRow["PASSWORD"].ToString().Trim(); //����
            objPERSON_q.MONEY = TransNullToDouble(objRow["MONEY"].ToString().Trim()); //MONEY
            objPERSON_q.CARD_KIND = TransNullToDouble(objRow["CARD_KIND"].ToString().Trim()); //CARD_KIND
            objPERSON_q.CARD_STATE = TransNullToDouble(objRow["CARD_STATE"].ToString().Trim()); //CARD_STATE
            objPERSON_q.LAST_TIME = TransNullToDate(objRow["LAST_TIME"].ToString().Trim()); //LAST_TIME
            objPERSON_q.USEFUL_LIMIT = TransNullToDate(objRow["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
            objPERSON_q.RECYCLE_LIMIT = TransNullToDate(objRow["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
            objPERSON_q.NAME = objRow["NAME"].ToString().Trim(); //����
            objPERSON_q.SEX = TransNullToDouble(objRow["SEX"].ToString().Trim()); //�Ա�
            objPERSON_q.IDEN_NO = TransNullToDouble(objRow["IDEN_NO"].ToString().Trim()); //IDEN_NO
            objPERSON_q.NATION_NO = TransNullToDouble(objRow["NATION_NO"].ToString().Trim()); //�������
            objPERSON_q.POLITICS = objRow["POLITICS"].ToString().Trim(); //������ò
            objPERSON_q.DUTY = objRow["DUTY"].ToString().Trim(); //DUTY
            objPERSON_q.BIRTH = TransNullToDate(objRow["BIRTH"].ToString().Trim()); //��ѧʱ��
            objPERSON_q.PERSON_ID = objRow["PERSON_ID"].ToString().Trim(); //���֤����
            objPERSON_q.STUDENT_ID = objRow["STUDENT_ID"].ToString().Trim(); //ѧ��
            objPERSON_q.SCHOOL_NO = objRow["SCHOOL_NO"].ToString().Trim(); //SCHOOL_NO
            objPERSON_q.ACADEMY_NO = objRow["ACADEMY_NO"].ToString().Trim(); //ѧԺ���
            objPERSON_q.DEP_NO = objRow["DEP_NO"].ToString().Trim(); //רҵ���
            objPERSON_q.CLASS_NO = objRow["CLASS_NO"].ToString().Trim(); //�༶���
            objPERSON_q.GRADE = objRow["GRADE"].ToString().Trim(); //�꼶
            objPERSON_q.IN_TIME = TransNullToDate(objRow["IN_TIME"].ToString().Trim()); //IN_TIME
            objPERSON_q.WALLANCE = TransNullToDouble(objRow["WALLANCE"].ToString().Trim()); //WALLANCE
            objPERSON_q.ADDRESS = objRow["ADDRESS"].ToString().Trim(); //��ͥסַ
            objPERSON_q.PHONE = objRow["PHONE"].ToString().Trim(); //�绰
            objPERSON_q.POST_NO = objRow["POST_NO"].ToString().Trim(); //��������
            objPERSON_q.POST_ADDRESS = objRow["POST_ADDRESS"].ToString().Trim(); //������ַ
            objPERSON_q.MAIL = objRow["MAIL"].ToString().Trim(); //����
            objPERSON_q.DESCR = objRow["DESCR"].ToString().Trim(); //DESCR
            objPERSON_q.USER_ID = objRow["USER_ID"].ToString().Trim(); //�û�ID
            objPERSON_q.OP_DATE = TransNullToDate(objRow["OP_DATE"].ToString().Trim()); //OP_DATE
            objPERSON_q.ANNEX = objRow["ANNEX"].ToString().Trim(); //ANNEX
            objPERSON_q.UpdDate = objRow["UpdDate"].ToString().Trim(); //UpdDate
            objPERSON_q.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ
            return objPERSON_q;
        }

        /// <summary>
        /// ��ȡ��ǰ�ؼ��ֵļ�¼����,�ö������ʽ��ʾ,�ô洢������ʵ��.
        /// </summary>
        /// <returns>�Ƿ�ɹ�</returns>
        public bool GetPERSON_qOneBySP()
        {
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mstrAccount);
            objDT = objSQL.ExecSpReturnDT("p_Get_PERSON_q", values);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            mstrAccount = objDT.Rows[0]["Account"].ToString().Trim(); //����
            mstrSCH_ID = objDT.Rows[0]["SCH_ID"].ToString().Trim(); //SCH_ID
            mstrBANK_ACC = objDT.Rows[0]["BANK_ACC"].ToString().Trim(); //�����ʺ�
            mstrCARD_NO = objDT.Rows[0]["CARD_NO"].ToString().Trim(); //CARD_NO
            mstrTEMP_CARD_NO = objDT.Rows[0]["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
            mdblTEMP_USING = TransNullToDouble(objDT.Rows[0]["TEMP_USING"].ToString().Trim()); //TEMP_USING
            mdblTEMP_DEPOSIT = TransNullToDouble(objDT.Rows[0]["TEMP_DEPOSIT"].ToString().Trim()); //TEMP_DEPOSIT
            mstrPASSWORD = objDT.Rows[0]["PASSWORD"].ToString().Trim(); //����
            mdblMONEY = TransNullToDouble(objDT.Rows[0]["MONEY"].ToString().Trim()); //MONEY
            mdblCARD_KIND = TransNullToDouble(objDT.Rows[0]["CARD_KIND"].ToString().Trim()); //CARD_KIND
            mdblCARD_STATE = TransNullToDouble(objDT.Rows[0]["CARD_STATE"].ToString().Trim()); //CARD_STATE
            mdteLAST_TIME = TransNullToDate(objDT.Rows[0]["LAST_TIME"].ToString().Trim()); //LAST_TIME
            mdteUSEFUL_LIMIT = TransNullToDate(objDT.Rows[0]["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
            mdteRECYCLE_LIMIT = TransNullToDate(objDT.Rows[0]["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
            mstrNAME = objDT.Rows[0]["NAME"].ToString().Trim(); //����
            mdblSEX = TransNullToDouble(objDT.Rows[0]["SEX"].ToString().Trim()); //�Ա�
            mdblIDEN_NO = TransNullToDouble(objDT.Rows[0]["IDEN_NO"].ToString().Trim()); //IDEN_NO
            mdblNATION_NO = TransNullToDouble(objDT.Rows[0]["NATION_NO"].ToString().Trim()); //�������
            mstrPOLITICS = objDT.Rows[0]["POLITICS"].ToString().Trim(); //������ò
            mstrDUTY = objDT.Rows[0]["DUTY"].ToString().Trim(); //DUTY
            mdteBIRTH = TransNullToDate(objDT.Rows[0]["BIRTH"].ToString().Trim()); //��ѧʱ��
            mstrPERSON_ID = objDT.Rows[0]["PERSON_ID"].ToString().Trim(); //���֤����
            mstrSTUDENT_ID = objDT.Rows[0]["STUDENT_ID"].ToString().Trim(); //ѧ��
            mstrSCHOOL_NO = objDT.Rows[0]["SCHOOL_NO"].ToString().Trim(); //SCHOOL_NO
            mstrACADEMY_NO = objDT.Rows[0]["ACADEMY_NO"].ToString().Trim(); //ѧԺ���
            mstrDEP_NO = objDT.Rows[0]["DEP_NO"].ToString().Trim(); //רҵ���
            mstrCLASS_NO = objDT.Rows[0]["CLASS_NO"].ToString().Trim(); //�༶���
            mstrGRADE = objDT.Rows[0]["GRADE"].ToString().Trim(); //�꼶
            mdteIN_TIME = TransNullToDate(objDT.Rows[0]["IN_TIME"].ToString().Trim()); //IN_TIME
            mdblWALLANCE = TransNullToDouble(objDT.Rows[0]["WALLANCE"].ToString().Trim()); //WALLANCE
            mstrADDRESS = objDT.Rows[0]["ADDRESS"].ToString().Trim(); //��ͥסַ
            mstrPHONE = objDT.Rows[0]["PHONE"].ToString().Trim(); //�绰
            mstrPOST_NO = objDT.Rows[0]["POST_NO"].ToString().Trim(); //��������
            mstrPOST_ADDRESS = objDT.Rows[0]["POST_ADDRESS"].ToString().Trim(); //������ַ
            mstrMAIL = objDT.Rows[0]["MAIL"].ToString().Trim(); //����
            mstrDESCR = objDT.Rows[0]["DESCR"].ToString().Trim(); //DESCR
            mstrUSER_ID = objDT.Rows[0]["USER_ID"].ToString().Trim(); //�û�ID
            mdteOP_DATE = TransNullToDate(objDT.Rows[0]["OP_DATE"].ToString().Trim()); //OP_DATE
            mstrANNEX = objDT.Rows[0]["ANNEX"].ToString().Trim(); //ANNEX
            mstrUpdDate = objDT.Rows[0]["UpdDate"].ToString().Trim(); //UpdDate
            objDT = null;
            return true;
        }

        /// <summary>
        /// ��ȡ�������������м�¼,��DataTable����ʽ��ʾ
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>�������������м�¼</returns>
        public static System.Data.DataTable GetPERSON_q(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsPERSON_q.GetSpecSQLObj();
            strSQL = "Select * from PERSON_q where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// ��ȡ�������������м�¼,��DataTable����ʽ��ʾ,�ô洢������ʵ��
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>�������������м�¼</returns>
        public static System.Data.DataTable GetPERSON_qByCondBySP(string strCondition)
        {
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsPERSON_q.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDT = objSQL.ExecSpReturnDT("p_Get_PERSON_qByCond", values);
            return objDT;
        }

        /// <summary>
        /// ��ȡ�������������м�¼,��DataSet����ʽ��ʾ
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>�������������м�¼</returns>
        public static System.Data.DataSet GetPERSON_qDataSetByCondBySP(string strCondition)
        {
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsPERSON_q.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDS = objSQL.ExecSPReturnDS("p_Get_PERSON_qByCond", values, "PERSON_q");
            return objDS;
        }

        /// <summary>
        /// ��ȡ�������������м�¼,��DataSet����ʽ��ʾ
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>�������������м�¼</returns>
        public static System.Data.DataSet GetDataSet_PERSON_q(string strCondition)
        {
            string strSQL;
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsPERSON_q.GetSpecSQLObj();
            strSQL = "Select * from PERSON_q where " + strCondition;
            objDS = objSQL.GetDataSet(strSQL, "PERSON_q");
            return objDS;
        }

        /// <summary>
        /// ��ȡ��ñ����������������м�¼,��DataSet����ʽ��ʾ, �ô洢������ʵ��
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>�������������м�¼</returns>
        public static System.Data.DataSet GetDataSet_PERSON_qByCondBySP(string strCondition)
        {
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsPERSON_q.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDS = objSQL.ExecSPReturnDS("p_Get_PERSON_qByCond", values, "PERSON_q");
            return objDS;
        }

        /// <summary>
        /// ��ȡ��ñ���ͼ���������������м�¼,��DataSet����ʽ��ʾ
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>�������������м�¼</returns>
        public static System.Data.DataSet GetDataSet_PERSON_qV(string strCondition)
        {
            string strSQL;
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsPERSON_q.GetSpecSQLObj();
            strSQL = "Select * from vPERSON_q where " + strCondition;
            objDS = objSQL.GetDataSet(strSQL, "vPERSON_q");
            return objDS;
        }

        /// <summary>
        /// ��ȡ�������������м�¼�����б�,�ö����б����ʽ��ʾ
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>�������������м�¼�����б�</returns>
        public ArrayList GetPERSON_qObjList(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            strSQL = "Select * from PERSON_q where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsPERSON_q objPERSON_q = new clsPERSON_q();
                objPERSON_q.Account = objRow["Account"].ToString().Trim(); //����
                objPERSON_q.SCH_ID = objRow["SCH_ID"].ToString().Trim(); //SCH_ID
                objPERSON_q.BANK_ACC = objRow["BANK_ACC"].ToString().Trim(); //�����ʺ�
                objPERSON_q.CARD_NO = objRow["CARD_NO"].ToString().Trim(); //CARD_NO
                objPERSON_q.TEMP_CARD_NO = objRow["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
                objPERSON_q.TEMP_USING = TransNullToDouble(objRow["TEMP_USING"].ToString().Trim()); //TEMP_USING
                objPERSON_q.TEMP_DEPOSIT = TransNullToDouble(objRow["TEMP_DEPOSIT"].ToString().Trim()); //TEMP_DEPOSIT
                objPERSON_q.PASSWORD = objRow["PASSWORD"].ToString().Trim(); //����
                objPERSON_q.MONEY = TransNullToDouble(objRow["MONEY"].ToString().Trim()); //MONEY
                objPERSON_q.CARD_KIND = TransNullToDouble(objRow["CARD_KIND"].ToString().Trim()); //CARD_KIND
                objPERSON_q.CARD_STATE = TransNullToDouble(objRow["CARD_STATE"].ToString().Trim()); //CARD_STATE
                objPERSON_q.LAST_TIME = TransNullToDate(objRow["LAST_TIME"].ToString().Trim()); //LAST_TIME
                objPERSON_q.USEFUL_LIMIT = TransNullToDate(objRow["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
                objPERSON_q.RECYCLE_LIMIT = TransNullToDate(objRow["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
                objPERSON_q.NAME = objRow["NAME"].ToString().Trim(); //����
                objPERSON_q.SEX = TransNullToDouble(objRow["SEX"].ToString().Trim()); //�Ա�
                objPERSON_q.IDEN_NO = TransNullToDouble(objRow["IDEN_NO"].ToString().Trim()); //IDEN_NO
                objPERSON_q.NATION_NO = TransNullToDouble(objRow["NATION_NO"].ToString().Trim()); //�������
                objPERSON_q.POLITICS = objRow["POLITICS"].ToString().Trim(); //������ò
                objPERSON_q.DUTY = objRow["DUTY"].ToString().Trim(); //DUTY
                objPERSON_q.BIRTH = TransNullToDate(objRow["BIRTH"].ToString().Trim()); //��ѧʱ��
                objPERSON_q.PERSON_ID = objRow["PERSON_ID"].ToString().Trim(); //���֤����
                objPERSON_q.STUDENT_ID = objRow["STUDENT_ID"].ToString().Trim(); //ѧ��
                objPERSON_q.SCHOOL_NO = objRow["SCHOOL_NO"].ToString().Trim(); //SCHOOL_NO
                objPERSON_q.ACADEMY_NO = objRow["ACADEMY_NO"].ToString().Trim(); //ѧԺ���
                objPERSON_q.DEP_NO = objRow["DEP_NO"].ToString().Trim(); //רҵ���
                objPERSON_q.CLASS_NO = objRow["CLASS_NO"].ToString().Trim(); //�༶���
                objPERSON_q.GRADE = objRow["GRADE"].ToString().Trim(); //�꼶
                objPERSON_q.IN_TIME = TransNullToDate(objRow["IN_TIME"].ToString().Trim()); //IN_TIME
                objPERSON_q.WALLANCE = TransNullToDouble(objRow["WALLANCE"].ToString().Trim()); //WALLANCE
                objPERSON_q.ADDRESS = objRow["ADDRESS"].ToString().Trim(); //��ͥסַ
                objPERSON_q.PHONE = objRow["PHONE"].ToString().Trim(); //�绰
                objPERSON_q.POST_NO = objRow["POST_NO"].ToString().Trim(); //��������
                objPERSON_q.POST_ADDRESS = objRow["POST_ADDRESS"].ToString().Trim(); //������ַ
                objPERSON_q.MAIL = objRow["MAIL"].ToString().Trim(); //����
                objPERSON_q.DESCR = objRow["DESCR"].ToString().Trim(); //DESCR
                objPERSON_q.USER_ID = objRow["USER_ID"].ToString().Trim(); //�û�ID
                objPERSON_q.OP_DATE = TransNullToDate(objRow["OP_DATE"].ToString().Trim()); //OP_DATE
                objPERSON_q.ANNEX = objRow["ANNEX"].ToString().Trim(); //ANNEX
                objPERSON_q.UpdDate = objRow["UpdDate"].ToString().Trim(); //UpdDate
                objPERSON_q.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ
                arrObjList.Add(objPERSON_q);
            }
            objDT = null;
            return arrObjList;
        }

        /// <summary>
        /// ��ȡ�������������м�¼�����б�,�ö����б����ʽ��ʾ,�ô洢������ʵ��.
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>�������������м�¼�����б�</returns>
        public ArrayList GetPERSON_qObjListBySP(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDT = objSQL.ExecSpReturnDT("p_Get_PERSON_qByCond", values);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsPERSON_q objPERSON_q = new clsPERSON_q();
                objPERSON_q.Account = objRow["Account"].ToString().Trim(); //����
                objPERSON_q.SCH_ID = objRow["SCH_ID"].ToString().Trim(); //SCH_ID
                objPERSON_q.BANK_ACC = objRow["BANK_ACC"].ToString().Trim(); //�����ʺ�
                objPERSON_q.CARD_NO = objRow["CARD_NO"].ToString().Trim(); //CARD_NO
                objPERSON_q.TEMP_CARD_NO = objRow["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
                objPERSON_q.TEMP_USING = TransNullToDouble(objRow["TEMP_USING"].ToString().Trim()); //TEMP_USING
                objPERSON_q.TEMP_DEPOSIT = TransNullToDouble(objRow["TEMP_DEPOSIT"].ToString().Trim()); //TEMP_DEPOSIT
                objPERSON_q.PASSWORD = objRow["PASSWORD"].ToString().Trim(); //����
                objPERSON_q.MONEY = TransNullToDouble(objRow["MONEY"].ToString().Trim()); //MONEY
                objPERSON_q.CARD_KIND = TransNullToDouble(objRow["CARD_KIND"].ToString().Trim()); //CARD_KIND
                objPERSON_q.CARD_STATE = TransNullToDouble(objRow["CARD_STATE"].ToString().Trim()); //CARD_STATE
                objPERSON_q.LAST_TIME = TransNullToDate(objRow["LAST_TIME"].ToString().Trim()); //LAST_TIME
                objPERSON_q.USEFUL_LIMIT = TransNullToDate(objRow["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
                objPERSON_q.RECYCLE_LIMIT = TransNullToDate(objRow["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
                objPERSON_q.NAME = objRow["NAME"].ToString().Trim(); //����
                objPERSON_q.SEX = TransNullToDouble(objRow["SEX"].ToString().Trim()); //�Ա�
                objPERSON_q.IDEN_NO = TransNullToDouble(objRow["IDEN_NO"].ToString().Trim()); //IDEN_NO
                objPERSON_q.NATION_NO = TransNullToDouble(objRow["NATION_NO"].ToString().Trim()); //�������
                objPERSON_q.POLITICS = objRow["POLITICS"].ToString().Trim(); //������ò
                objPERSON_q.DUTY = objRow["DUTY"].ToString().Trim(); //DUTY
                objPERSON_q.BIRTH = TransNullToDate(objRow["BIRTH"].ToString().Trim()); //��ѧʱ��
                objPERSON_q.PERSON_ID = objRow["PERSON_ID"].ToString().Trim(); //���֤����
                objPERSON_q.STUDENT_ID = objRow["STUDENT_ID"].ToString().Trim(); //ѧ��
                objPERSON_q.SCHOOL_NO = objRow["SCHOOL_NO"].ToString().Trim(); //SCHOOL_NO
                objPERSON_q.ACADEMY_NO = objRow["ACADEMY_NO"].ToString().Trim(); //ѧԺ���
                objPERSON_q.DEP_NO = objRow["DEP_NO"].ToString().Trim(); //רҵ���
                objPERSON_q.CLASS_NO = objRow["CLASS_NO"].ToString().Trim(); //�༶���
                objPERSON_q.GRADE = objRow["GRADE"].ToString().Trim(); //�꼶
                objPERSON_q.IN_TIME = TransNullToDate(objRow["IN_TIME"].ToString().Trim()); //IN_TIME
                objPERSON_q.WALLANCE = TransNullToDouble(objRow["WALLANCE"].ToString().Trim()); //WALLANCE
                objPERSON_q.ADDRESS = objRow["ADDRESS"].ToString().Trim(); //��ͥסַ
                objPERSON_q.PHONE = objRow["PHONE"].ToString().Trim(); //�绰
                objPERSON_q.POST_NO = objRow["POST_NO"].ToString().Trim(); //��������
                objPERSON_q.POST_ADDRESS = objRow["POST_ADDRESS"].ToString().Trim(); //������ַ
                objPERSON_q.MAIL = objRow["MAIL"].ToString().Trim(); //����
                objPERSON_q.DESCR = objRow["DESCR"].ToString().Trim(); //DESCR
                objPERSON_q.USER_ID = objRow["USER_ID"].ToString().Trim(); //�û�ID
                objPERSON_q.OP_DATE = TransNullToDate(objRow["OP_DATE"].ToString().Trim()); //OP_DATE
                objPERSON_q.ANNEX = objRow["ANNEX"].ToString().Trim(); //ANNEX
                objPERSON_q.UpdDate = objRow["UpdDate"].ToString().Trim(); //UpdDate
                objPERSON_q.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ
                arrObjList.Add(objPERSON_q);
            }
            objDT = null;
            return arrObjList;
        }

        /// <summary>
        /// ��ȡ���������ĵ�һ����¼,�ö������ʽ��ʾ
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>��һ����¼�Ķ���</returns>
        public clsPERSON_q GetFirstPERSON_q(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            strSQL = "Select * from PERSON_q where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            DataRow objRow = objDT.Rows[0];
            clsPERSON_q objPERSON_q = new clsPERSON_q();
            objPERSON_q.Account = objRow["Account"].ToString().Trim(); //����
            objPERSON_q.SCH_ID = objRow["SCH_ID"].ToString().Trim(); //SCH_ID
            objPERSON_q.BANK_ACC = objRow["BANK_ACC"].ToString().Trim(); //�����ʺ�
            objPERSON_q.CARD_NO = objRow["CARD_NO"].ToString().Trim(); //CARD_NO
            objPERSON_q.TEMP_CARD_NO = objRow["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
            objPERSON_q.TEMP_USING = TransNullToDouble(objRow["TEMP_USING"].ToString().Trim()); //TEMP_USING
            objPERSON_q.TEMP_DEPOSIT = TransNullToDouble(objRow["TEMP_DEPOSIT"].ToString().Trim()); //TEMP_DEPOSIT
            objPERSON_q.PASSWORD = objRow["PASSWORD"].ToString().Trim(); //����
            objPERSON_q.MONEY = TransNullToDouble(objRow["MONEY"].ToString().Trim()); //MONEY
            objPERSON_q.CARD_KIND = TransNullToDouble(objRow["CARD_KIND"].ToString().Trim()); //CARD_KIND
            objPERSON_q.CARD_STATE = TransNullToDouble(objRow["CARD_STATE"].ToString().Trim()); //CARD_STATE
            objPERSON_q.LAST_TIME = TransNullToDate(objRow["LAST_TIME"].ToString().Trim()); //LAST_TIME
            objPERSON_q.USEFUL_LIMIT = TransNullToDate(objRow["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
            objPERSON_q.RECYCLE_LIMIT = TransNullToDate(objRow["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
            objPERSON_q.NAME = objRow["NAME"].ToString().Trim(); //����
            objPERSON_q.SEX = TransNullToDouble(objRow["SEX"].ToString().Trim()); //�Ա�
            objPERSON_q.IDEN_NO = TransNullToDouble(objRow["IDEN_NO"].ToString().Trim()); //IDEN_NO
            objPERSON_q.NATION_NO = TransNullToDouble(objRow["NATION_NO"].ToString().Trim()); //�������
            objPERSON_q.POLITICS = objRow["POLITICS"].ToString().Trim(); //������ò
            objPERSON_q.DUTY = objRow["DUTY"].ToString().Trim(); //DUTY
            objPERSON_q.BIRTH = TransNullToDate(objRow["BIRTH"].ToString().Trim()); //��ѧʱ��
            objPERSON_q.PERSON_ID = objRow["PERSON_ID"].ToString().Trim(); //���֤����
            objPERSON_q.STUDENT_ID = objRow["STUDENT_ID"].ToString().Trim(); //ѧ��
            objPERSON_q.SCHOOL_NO = objRow["SCHOOL_NO"].ToString().Trim(); //SCHOOL_NO
            objPERSON_q.ACADEMY_NO = objRow["ACADEMY_NO"].ToString().Trim(); //ѧԺ���
            objPERSON_q.DEP_NO = objRow["DEP_NO"].ToString().Trim(); //רҵ���
            objPERSON_q.CLASS_NO = objRow["CLASS_NO"].ToString().Trim(); //�༶���
            objPERSON_q.GRADE = objRow["GRADE"].ToString().Trim(); //�꼶
            objPERSON_q.IN_TIME = TransNullToDate(objRow["IN_TIME"].ToString().Trim()); //IN_TIME
            objPERSON_q.WALLANCE = TransNullToDouble(objRow["WALLANCE"].ToString().Trim()); //WALLANCE
            objPERSON_q.ADDRESS = objRow["ADDRESS"].ToString().Trim(); //��ͥסַ
            objPERSON_q.PHONE = objRow["PHONE"].ToString().Trim(); //�绰
            objPERSON_q.POST_NO = objRow["POST_NO"].ToString().Trim(); //��������
            objPERSON_q.POST_ADDRESS = objRow["POST_ADDRESS"].ToString().Trim(); //������ַ
            objPERSON_q.MAIL = objRow["MAIL"].ToString().Trim(); //����
            objPERSON_q.DESCR = objRow["DESCR"].ToString().Trim(); //DESCR
            objPERSON_q.USER_ID = objRow["USER_ID"].ToString().Trim(); //�û�ID
            objPERSON_q.OP_DATE = TransNullToDate(objRow["OP_DATE"].ToString().Trim()); //OP_DATE
            objPERSON_q.ANNEX = objRow["ANNEX"].ToString().Trim(); //ANNEX
            objPERSON_q.UpdDate = objRow["UpdDate"].ToString().Trim(); //UpdDate
            objPERSON_q.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ
            objDT = null;
            return objPERSON_q;
        }

        /// <summary>
        /// ��ȡ���������ĵ�һ����¼,�ö������ʽ��ʾ,�ô洢������ʵ��
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>��һ����¼�Ķ���</returns>
        public clsPERSON_q GetFirstPERSON_qBySP(string strCondition)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDT = objSQL.ExecSpReturnDT("p_Get_PERSON_qTop1ByCond", values);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            DataRow objRow = objDT.Rows[0];
            clsPERSON_q objPERSON_q = new clsPERSON_q();
            objPERSON_q.Account = objRow["Account"].ToString().Trim(); //����
            objPERSON_q.SCH_ID = objRow["SCH_ID"].ToString().Trim(); //SCH_ID
            objPERSON_q.BANK_ACC = objRow["BANK_ACC"].ToString().Trim(); //�����ʺ�
            objPERSON_q.CARD_NO = objRow["CARD_NO"].ToString().Trim(); //CARD_NO
            objPERSON_q.TEMP_CARD_NO = objRow["TEMP_CARD_NO"].ToString().Trim(); //TEMP_CARD_NO
            objPERSON_q.TEMP_USING = TransNullToDouble(objRow["TEMP_USING"].ToString().Trim()); //TEMP_USING
            objPERSON_q.TEMP_DEPOSIT = TransNullToDouble(objRow["TEMP_DEPOSIT"].ToString().Trim()); //TEMP_DEPOSIT
            objPERSON_q.PASSWORD = objRow["PASSWORD"].ToString().Trim(); //����
            objPERSON_q.MONEY = TransNullToDouble(objRow["MONEY"].ToString().Trim()); //MONEY
            objPERSON_q.CARD_KIND = TransNullToDouble(objRow["CARD_KIND"].ToString().Trim()); //CARD_KIND
            objPERSON_q.CARD_STATE = TransNullToDouble(objRow["CARD_STATE"].ToString().Trim()); //CARD_STATE
            objPERSON_q.LAST_TIME = TransNullToDate(objRow["LAST_TIME"].ToString().Trim()); //LAST_TIME
            objPERSON_q.USEFUL_LIMIT = TransNullToDate(objRow["USEFUL_LIMIT"].ToString().Trim()); //USEFUL_LIMIT
            objPERSON_q.RECYCLE_LIMIT = TransNullToDate(objRow["RECYCLE_LIMIT"].ToString().Trim()); //RECYCLE_LIMIT
            objPERSON_q.NAME = objRow["NAME"].ToString().Trim(); //����
            objPERSON_q.SEX = TransNullToDouble(objRow["SEX"].ToString().Trim()); //�Ա�
            objPERSON_q.IDEN_NO = TransNullToDouble(objRow["IDEN_NO"].ToString().Trim()); //IDEN_NO
            objPERSON_q.NATION_NO = TransNullToDouble(objRow["NATION_NO"].ToString().Trim()); //�������
            objPERSON_q.POLITICS = objRow["POLITICS"].ToString().Trim(); //������ò
            objPERSON_q.DUTY = objRow["DUTY"].ToString().Trim(); //DUTY
            objPERSON_q.BIRTH = TransNullToDate(objRow["BIRTH"].ToString().Trim()); //��ѧʱ��
            objPERSON_q.PERSON_ID = objRow["PERSON_ID"].ToString().Trim(); //���֤����
            objPERSON_q.STUDENT_ID = objRow["STUDENT_ID"].ToString().Trim(); //ѧ��
            objPERSON_q.SCHOOL_NO = objRow["SCHOOL_NO"].ToString().Trim(); //SCHOOL_NO
            objPERSON_q.ACADEMY_NO = objRow["ACADEMY_NO"].ToString().Trim(); //ѧԺ���
            objPERSON_q.DEP_NO = objRow["DEP_NO"].ToString().Trim(); //רҵ���
            objPERSON_q.CLASS_NO = objRow["CLASS_NO"].ToString().Trim(); //�༶���
            objPERSON_q.GRADE = objRow["GRADE"].ToString().Trim(); //�꼶
            objPERSON_q.IN_TIME = TransNullToDate(objRow["IN_TIME"].ToString().Trim()); //IN_TIME
            objPERSON_q.WALLANCE = TransNullToDouble(objRow["WALLANCE"].ToString().Trim()); //WALLANCE
            objPERSON_q.ADDRESS = objRow["ADDRESS"].ToString().Trim(); //��ͥסַ
            objPERSON_q.PHONE = objRow["PHONE"].ToString().Trim(); //�绰
            objPERSON_q.POST_NO = objRow["POST_NO"].ToString().Trim(); //��������
            objPERSON_q.POST_ADDRESS = objRow["POST_ADDRESS"].ToString().Trim(); //������ַ
            objPERSON_q.MAIL = objRow["MAIL"].ToString().Trim(); //����
            objPERSON_q.DESCR = objRow["DESCR"].ToString().Trim(); //DESCR
            objPERSON_q.USER_ID = objRow["USER_ID"].ToString().Trim(); //�û�ID
            objPERSON_q.OP_DATE = TransNullToDate(objRow["OP_DATE"].ToString().Trim()); //OP_DATE
            objPERSON_q.ANNEX = objRow["ANNEX"].ToString().Trim(); //ANNEX
            objPERSON_q.UpdDate = objRow["UpdDate"].ToString().Trim(); //UpdDate
            objPERSON_q.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ
            objDT = null;
            return objPERSON_q;
        }



        /// <summary>
        /// ���ܣ���ȡĳһ��������ر���ͼ(View)
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>�����Ѿ�ת�������DataTable</returns>
        public static System.Data.DataTable GetPERSON_qV(string strCondition)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsPERSON_q.GetSpecSQLObj();
            strSQL.Append("Select vPERSON_q.* ");
            strSQL.Append(" from vPERSON_q ");
            strSQL.Append(" where " + strCondition);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }


        /// <summary>
        /// �Ƿ���ڼ�¼
        /// </summary>
        /// <returns>�Ƿ����</returns>
        public bool IsExist()
        {
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            if (objSQL.IsExistRecord("PERSON_q", "Account=" + "'" + mstrAccount + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// �жϵ�ǰ�����Ƿ���ڸ����ؼ���ֵ�ļ�¼
        /// </summary>
        /// <param name="strAccount">�����Ĺؼ���ֵ</param>
        /// <returns>�����Ƿ����?</returns>
        public static bool IsExist(string strAccount)
        {
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsPERSON_q.GetSpecSQLObj();
            if (objSQL.IsExistRecord("PERSON_q", "Account=" + "'" + strAccount + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// �Ƿ���ڼ�¼
        /// </summary>
        /// <param name="strAccount">�ؼ���</param>
        /// <returns>�Ƿ����</returns>
        public static bool IsExistBySP_S(string strAccount)
        {
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsPERSON_q.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strAccount);
            string strIsExist = "";
            values.Add(strIsExist);
            ArrayList arrReturn = objSQL.ExecSpWithOutPut("p_IsExist_PERSON_q", values);
            if (arrReturn[0].ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ����ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.
        /// </summary>
        public void CheckPropertyNew()
        {
            if (Object.Equals(null, mstrAccount)
            || (!Object.Equals(null, mstrAccount) && mstrAccount.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[����]����Ϊ��(NULL)!");
            }
            if (!Object.Equals(null, mstrAccount) && getStrLen(mstrAccount) > 10)
            {
                throw new clsDbObjException("�ֶ�[����]�ĳ��Ȳ��ܳ���10!");
            }
            if (!Object.Equals(null, mstrSCH_ID) && getStrLen(mstrSCH_ID) > 25)
            {
                throw new clsDbObjException("�ֶ�[SCH_ID]�ĳ��Ȳ��ܳ���25!");
            }
            if (!Object.Equals(null, mstrBANK_ACC) && getStrLen(mstrBANK_ACC) > 20)
            {
                throw new clsDbObjException("�ֶ�[�����ʺ�]�ĳ��Ȳ��ܳ���20!");
            }
            if (!Object.Equals(null, mstrCARD_NO) && getStrLen(mstrCARD_NO) > 19)
            {
                throw new clsDbObjException("�ֶ�[CARD_NO]�ĳ��Ȳ��ܳ���19!");
            }
            if (!Object.Equals(null, mstrTEMP_CARD_NO) && getStrLen(mstrTEMP_CARD_NO) > 19)
            {
                throw new clsDbObjException("�ֶ�[TEMP_CARD_NO]�ĳ��Ȳ��ܳ���19!");
            }
            if (!Object.Equals(null, mstrPASSWORD) && getStrLen(mstrPASSWORD) > 8)
            {
                throw new clsDbObjException("�ֶ�[����]�ĳ��Ȳ��ܳ���8!");
            }
            if (!Object.Equals(null, mstrNAME) && getStrLen(mstrNAME) > 40)
            {
                throw new clsDbObjException("�ֶ�[����]�ĳ��Ȳ��ܳ���40!");
            }
            if (!Object.Equals(null, mstrPOLITICS) && getStrLen(mstrPOLITICS) > 10)
            {
                throw new clsDbObjException("�ֶ�[������ò]�ĳ��Ȳ��ܳ���10!");
            }
            if (!Object.Equals(null, mstrDUTY) && getStrLen(mstrDUTY) > 20)
            {
                throw new clsDbObjException("�ֶ�[DUTY]�ĳ��Ȳ��ܳ���20!");
            }
            if (!Object.Equals(null, mstrPERSON_ID) && getStrLen(mstrPERSON_ID) > 18)
            {
                throw new clsDbObjException("�ֶ�[���֤����]�ĳ��Ȳ��ܳ���18!");
            }
            if (!Object.Equals(null, mstrSTUDENT_ID) && getStrLen(mstrSTUDENT_ID) > 15)
            {
                throw new clsDbObjException("�ֶ�[ѧ��]�ĳ��Ȳ��ܳ���15!");
            }
            if (!Object.Equals(null, mstrSCHOOL_NO) && getStrLen(mstrSCHOOL_NO) > 8)
            {
                throw new clsDbObjException("�ֶ�[SCHOOL_NO]�ĳ��Ȳ��ܳ���8!");
            }
            if (!Object.Equals(null, mstrACADEMY_NO) && getStrLen(mstrACADEMY_NO) > 8)
            {
                throw new clsDbObjException("�ֶ�[ѧԺ���]�ĳ��Ȳ��ܳ���8!");
            }
            if (!Object.Equals(null, mstrDEP_NO) && getStrLen(mstrDEP_NO) > 8)
            {
                throw new clsDbObjException("�ֶ�[רҵ���]�ĳ��Ȳ��ܳ���8!");
            }
            if (!Object.Equals(null, mstrCLASS_NO) && getStrLen(mstrCLASS_NO) > 8)
            {
                throw new clsDbObjException("�ֶ�[�༶���]�ĳ��Ȳ��ܳ���8!");
            }
            if (!Object.Equals(null, mstrGRADE) && getStrLen(mstrGRADE) > 4)
            {
                throw new clsDbObjException("�ֶ�[�꼶]�ĳ��Ȳ��ܳ���4!");
            }
            if (!Object.Equals(null, mstrADDRESS) && getStrLen(mstrADDRESS) > 100)
            {
                throw new clsDbObjException("�ֶ�[��ͥסַ]�ĳ��Ȳ��ܳ���100!");
            }
            if (!Object.Equals(null, mstrPHONE) && getStrLen(mstrPHONE) > 50)
            {
                throw new clsDbObjException("�ֶ�[�绰]�ĳ��Ȳ��ܳ���50!");
            }
            if (!Object.Equals(null, mstrPOST_NO) && getStrLen(mstrPOST_NO) > 8)
            {
                throw new clsDbObjException("�ֶ�[��������]�ĳ��Ȳ��ܳ���8!");
            }
            if (!Object.Equals(null, mstrPOST_ADDRESS) && getStrLen(mstrPOST_ADDRESS) > 40)
            {
                throw new clsDbObjException("�ֶ�[������ַ]�ĳ��Ȳ��ܳ���40!");
            }
            if (!Object.Equals(null, mstrMAIL) && getStrLen(mstrMAIL) > 50)
            {
                throw new clsDbObjException("�ֶ�[����]�ĳ��Ȳ��ܳ���50!");
            }
            if (!Object.Equals(null, mstrDESCR) && getStrLen(mstrDESCR) > 100)
            {
                throw new clsDbObjException("�ֶ�[DESCR]�ĳ��Ȳ��ܳ���100!");
            }
            if (!Object.Equals(null, mstrUSER_ID) && getStrLen(mstrUSER_ID) > 12)
            {
                throw new clsDbObjException("�ֶ�[�û�ID]�ĳ��Ȳ��ܳ���12!");
            }
            if (!Object.Equals(null, mstrANNEX) && getStrLen(mstrANNEX) > 20)
            {
                throw new clsDbObjException("�ֶ�[ANNEX]�ĳ��Ȳ��ܳ���20!");
            }
            if (!Object.Equals(null, mstrUpdDate) && getStrLen(mstrUpdDate) > 14)
            {
                throw new clsDbObjException("�ֶ�[UpdDate]�ĳ��Ȳ��ܳ���14!");
            }
        }


        /// <summary>
        /// ��ȡ��ǰ���������������м�¼�Ĺؼ���ֵ�б�
        /// </summary>
        /// <param name="strCondtion">������</param>
        /// <returns>���صĹؼ���ֵ�б�</returns>
        public ArrayList GetID(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            ArrayList arrList = new ArrayList();
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            int iRow, iCol;
            string strKeyValue;
            strSQL = "Select Account from PERSON_q where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            for (iRow = 0; iRow <= objDT.Rows.Count - 1; iRow++)
            {
                strKeyValue = "";
                for (iCol = 0; iCol <= objDT.Columns.Count - 1; iCol++)
                {
                    if (iCol == 0)
                    {
                        strKeyValue += objDT.Rows[iRow][iCol].ToString();
                    }
                    else
                    {
                        strKeyValue += "//" + objDT.Rows[iRow][iCol].ToString();
                    }
                }
                arrList.Add(strKeyValue);
            }
            objDT = null;
            return arrList;
        }

        /// <summary>
        /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ
        /// </summary>
        /// <param name="strCondtion">������</param>
        /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>
        public string GetFirstID(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            ArrayList arrList = new ArrayList();
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = this.GetSpecSQLObj_Obj();
            string strKeyValue;
            strSQL = "Select Account from PERSON_q where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            strKeyValue = objDT.Rows[0][0].ToString();
            objDT = null;
            return strKeyValue;
        }

        /// <summary>
        /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ
        /// </summary>
        /// <param name="strCondtion">������</param>
        /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>
        public static string GetFirstID_S(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            ArrayList arrList = new ArrayList();
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsPERSON_q.GetSpecSQLObj();
            string strKeyValue;
            strSQL = "Select Account from PERSON_q where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsPERSON_q");
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            strKeyValue = objDT.Rows[0][0].ToString();
            objDT = null;
            return strKeyValue;
        }
    }
}