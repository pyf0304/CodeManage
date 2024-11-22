///----------------------
///���ɴ���汾��09.10.08.1
///�������ڣ�2010/11/23
///�����ߣ����Է�
///ע�⣺1����Ҫ���ݵײ㣨PubDataBase.dll���İ汾��2010.05.04.1
///       2����Ҫ���������㣨TzPubFunction.dll���İ汾��2010.05.04.1
///========================
using System;
using System.Text;
using System.Collections;
using com.taishsoft.comm_db_obj;

namespace Questionnaire.Entity
{
    /// <summary>
    /// �ʾ������(UserAnswerResult)
    /// </summary>
    [Serializable]
    public class clsUserAnswerResultEN : clsEntityBase2
    {
        public const string CurrTabName_S = "UserAnswerResult"; //��ǰ�������������صı���
        public const string CurrTabKeyFldName_S = "MinID"; //��ǰ���еĹؼ������ƣ��������صı��йؼ�����
        protected const int mintAttributeCount = 14;
        public static string[] AttributeName = new string[] { "MinID", "QuestionnaireSetId", "School", "UserID", "QuestionID", "AnswerID", "AnswerText", "AnswerDate", "AnswerTime", "AnswerIP", "AnswerMode", "id_School", "BatchId", "Memo" };
        //���������Ա���


        /// <summary> 
        /// ���ID
        /// </summary>
        protected long mlngMinID;

        /// <summary> 
        /// �ʾ�ID
        /// </summary>
        protected string mstrQuestionnaireSetId;

        /// <summary> 
        /// ѧУ
        /// </summary>
        protected string mstrSchool;

        /// <summary> 
        /// �û�ID
        /// </summary>
        protected string mstrUserID;

        /// <summary> 
        /// ��ĿID
        /// </summary>
        protected long mlngQuestionID;

        /// <summary> 
        /// �ʴ�ID
        /// </summary>
        protected long mlngAnswerID;

        /// <summary> 
        /// �ʴ�����
        /// </summary>
        protected string mstrAnswerText;

        /// <summary> 
        /// �ش�����
        /// </summary>
        protected string mstrAnswerDate;

        /// <summary> 
        /// �ش�ʱ��
        /// </summary>
        protected string mstrAnswerTime;

        /// <summary> 
        /// �ش�IP
        /// </summary>
        protected string mstrAnswerIP;

        /// <summary> 
        /// �ش�ģʽ
        /// </summary>
        protected int mintAnswerMode;

        /// <summary> 
        /// ѧУ��ˮ��
        /// </summary>
        protected string mstrid_School;

        /// <summary> 
        /// ����ID
        /// </summary>
        protected string mstrBatchId;

        /// <summary> 
        /// ��ע
        /// </summary>
        protected string mstrMemo;

        //�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�
        private static string m_strConnectString;
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }

        public clsUserAnswerResultEN()
        {
            SetInit();
            CurrTabName = "UserAnswerResult";
            lstKeyFldNames.Add("MinID");
        }

        public clsUserAnswerResultEN(long lngMinID)
        {

            mlngMinID = lngMinID;
            SetInit();
            CurrTabName = "UserAnswerResult";
            lstKeyFldNames.Add("MinID");
        }

        public static int AttributeCount
        {
            get
            {
                return mintAttributeCount;
            }
        }
        public object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == "MinID")
                {
                    return mlngMinID;
                }
                else if (strAttributeName == "QuestionnaireSetId")
                {
                    return mstrQuestionnaireSetId;
                }
                else if (strAttributeName == "School")
                {
                    return mstrSchool;
                }
                else if (strAttributeName == "UserID")
                {
                    return mstrUserID;
                }
                else if (strAttributeName == "QuestionID")
                {
                    return mlngQuestionID;
                }
                else if (strAttributeName == "AnswerID")
                {
                    return mlngAnswerID;
                }
                else if (strAttributeName == "AnswerText")
                {
                    return mstrAnswerText;
                }
                else if (strAttributeName == "AnswerDate")
                {
                    return mstrAnswerDate;
                }
                else if (strAttributeName == "AnswerTime")
                {
                    return mstrAnswerTime;
                }
                else if (strAttributeName == "AnswerIP")
                {
                    return mstrAnswerIP;
                }
                else if (strAttributeName == "AnswerMode")
                {
                    return mintAnswerMode;
                }
                else if (strAttributeName == "id_School")
                {
                    return mstrid_School;
                }
                else if (strAttributeName == "BatchId")
                {
                    return mstrBatchId;
                }
                else if (strAttributeName == "Memo")
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "MinID")
                {
                    mlngMinID = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "QuestionnaireSetId")
                {
                    mstrQuestionnaireSetId = value.ToString();
                }
                else if (strAttributeName == "School")
                {
                    mstrSchool = value.ToString();
                }
                else if (strAttributeName == "UserID")
                {
                    mstrUserID = value.ToString();
                }
                else if (strAttributeName == "QuestionID")
                {
                    mlngQuestionID = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "AnswerID")
                {
                    mlngAnswerID = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "AnswerText")
                {
                    mstrAnswerText = value.ToString();
                }
                else if (strAttributeName == "AnswerDate")
                {
                    mstrAnswerDate = value.ToString();
                }
                else if (strAttributeName == "AnswerTime")
                {
                    mstrAnswerTime = value.ToString();
                }
                else if (strAttributeName == "AnswerIP")
                {
                    mstrAnswerIP = value.ToString();
                }
                else if (strAttributeName == "AnswerMode")
                {
                    mintAnswerMode = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "id_School")
                {
                    mstrid_School = value.ToString();
                }
                else if (strAttributeName == "BatchId")
                {
                    mstrBatchId = value.ToString();
                }
                else if (strAttributeName == "Memo")
                {
                    mstrMemo = value.ToString();
                }
            }
        }
        public object this[int intIndex]
        {
            get
            {
                if ("MinID" == AttributeName[intIndex])
                {
                    return mlngMinID;
                }
                else if ("QuestionnaireSetId" == AttributeName[intIndex])
                {
                    return mstrQuestionnaireSetId;
                }
                else if ("School" == AttributeName[intIndex])
                {
                    return mstrSchool;
                }
                else if ("UserID" == AttributeName[intIndex])
                {
                    return mstrUserID;
                }
                else if ("QuestionID" == AttributeName[intIndex])
                {
                    return mlngQuestionID;
                }
                else if ("AnswerID" == AttributeName[intIndex])
                {
                    return mlngAnswerID;
                }
                else if ("AnswerText" == AttributeName[intIndex])
                {
                    return mstrAnswerText;
                }
                else if ("AnswerDate" == AttributeName[intIndex])
                {
                    return mstrAnswerDate;
                }
                else if ("AnswerTime" == AttributeName[intIndex])
                {
                    return mstrAnswerTime;
                }
                else if ("AnswerIP" == AttributeName[intIndex])
                {
                    return mstrAnswerIP;
                }
                else if ("AnswerMode" == AttributeName[intIndex])
                {
                    return mintAnswerMode;
                }
                else if ("id_School" == AttributeName[intIndex])
                {
                    return mstrid_School;
                }
                else if ("BatchId" == AttributeName[intIndex])
                {
                    return mstrBatchId;
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if ("MinID" == AttributeName[intIndex])
                {
                    mlngMinID = TransNullToInt(value.ToString());
                }
                else if ("QuestionnaireSetId" == AttributeName[intIndex])
                {
                    mstrQuestionnaireSetId = value.ToString();
                }
                else if ("School" == AttributeName[intIndex])
                {
                    mstrSchool = value.ToString();
                }
                else if ("UserID" == AttributeName[intIndex])
                {
                    mstrUserID = value.ToString();
                }
                else if ("QuestionID" == AttributeName[intIndex])
                {
                    mlngQuestionID = TransNullToInt(value.ToString());
                }
                else if ("AnswerID" == AttributeName[intIndex])
                {
                    mlngAnswerID = TransNullToInt(value.ToString());
                }
                else if ("AnswerText" == AttributeName[intIndex])
                {
                    mstrAnswerText = value.ToString();
                }
                else if ("AnswerDate" == AttributeName[intIndex])
                {
                    mstrAnswerDate = value.ToString();
                }
                else if ("AnswerTime" == AttributeName[intIndex])
                {
                    mstrAnswerTime = value.ToString();
                }
                else if ("AnswerIP" == AttributeName[intIndex])
                {
                    mstrAnswerIP = value.ToString();
                }
                else if ("AnswerMode" == AttributeName[intIndex])
                {
                    mintAnswerMode = TransNullToInt(value.ToString());
                }
                else if ("id_School" == AttributeName[intIndex])
                {
                    mstrid_School = value.ToString();
                }
                else if ("BatchId" == AttributeName[intIndex])
                {
                    mstrBatchId = value.ToString();
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    mstrMemo = value.ToString();
                }
            }
        }

        /// <summary>
        /// ���ID
        /// </summary>
        public long MinID
        {
            get
            {
                return mlngMinID;
            }
            set
            {
                mlngMinID = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("MinID");
            }
        }
        /// <summary>
        /// �ʾ�ID
        /// </summary>
        public string QuestionnaireSetId
        {
            get
            {
                return mstrQuestionnaireSetId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrQuestionnaireSetId = value;
                }
                else
                {
                    mstrQuestionnaireSetId = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("QuestionnaireSetId");
            }
        }
        /// <summary>
        /// ѧУ
        /// </summary>
        public string School
        {
            get
            {
                return mstrSchool;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSchool = value;
                }
                else
                {
                    mstrSchool = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("School");
            }
        }
        /// <summary>
        /// �û�ID
        /// </summary>
        public string UserID
        {
            get
            {
                return mstrUserID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrUserID = value;
                }
                else
                {
                    mstrUserID = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("UserID");
            }
        }
        /// <summary>
        /// ��ĿID
        /// </summary>
        public long QuestionID
        {
            get
            {
                return mlngQuestionID;
            }
            set
            {
                mlngQuestionID = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("QuestionID");
            }
        }
        /// <summary>
        /// �ʴ�ID
        /// </summary>
        public long AnswerID
        {
            get
            {
                return mlngAnswerID;
            }
            set
            {
                mlngAnswerID = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("AnswerID");
            }
        }
        /// <summary>
        /// �ʴ�����
        /// </summary>
        public string AnswerText
        {
            get
            {
                return mstrAnswerText;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrAnswerText = value;
                }
                else
                {
                    mstrAnswerText = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("AnswerText");
            }
        }
        /// <summary>
        /// �ش�����
        /// </summary>
        public string AnswerDate
        {
            get
            {
                return mstrAnswerDate;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrAnswerDate = value;
                }
                else
                {
                    mstrAnswerDate = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("AnswerDate");
            }
        }
        /// <summary>
        /// �ش�ʱ��
        /// </summary>
        public string AnswerTime
        {
            get
            {
                return mstrAnswerTime;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrAnswerTime = value;
                }
                else
                {
                    mstrAnswerTime = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("AnswerTime");
            }
        }
        /// <summary>
        /// �ش�IP
        /// </summary>
        public string AnswerIP
        {
            get
            {
                return mstrAnswerIP;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrAnswerIP = value;
                }
                else
                {
                    mstrAnswerIP = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("AnswerIP");
            }
        }
        /// <summary>
        /// �ش�ģʽ
        /// </summary>
        public int AnswerMode
        {
            get
            {
                return mintAnswerMode;
            }
            set
            {
                mintAnswerMode = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("AnswerMode");
            }
        }
        /// <summary>
        /// ѧУ��ˮ��
        /// </summary>
        public string id_School
        {
            get
            {
                return mstrid_School;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrid_School = value;
                }
                else
                {
                    mstrid_School = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("id_School");
            }
        }
        /// <summary>
        /// ����ID
        /// </summary>
        public string BatchId
        {
            get
            {
                return mstrBatchId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrBatchId = value;
                }
                else
                {
                    mstrBatchId = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("BatchId");
            }
        }
        /// <summary>
        /// ��ע
        /// </summary>
        public string Memo
        {
            get
            {
                return mstrMemo;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrMemo = value;
                }
                else
                {
                    mstrMemo = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("Memo");
            }
        }
    }
}