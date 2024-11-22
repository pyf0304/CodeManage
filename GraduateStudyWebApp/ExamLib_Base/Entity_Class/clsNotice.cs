///----------------------
///���ɴ���汾��09.10.08.1
///�������ڣ�2010/02/05
///�����ߣ����Է�
///ע�⣺1����Ҫ���ݵײ㣨PubDataBase.dll���İ汾��09.10.08.2
///       2����Ҫ���������㣨TzPubFunction.dll���İ汾��09.10.08.1
///========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.comm_db_obj;

namespace Questionnaire.Entity
{
    /// <summary>
    /// ����(Notice)
    /// </summary>
    [Serializable]
    public class clsNotice : clsEntityBase2
    {
        public const string CurrTabName_S = "Notice"; //��ǰ�������������صı���
        public const string CurrTabKeyFldName_S = "NoticeID"; //��ǰ���еĹؼ������ƣ��������صı��йؼ�����
        protected const int mintAttributeCount = 7;
        public static string[] AttributeName = new string[] { "NoticeID", "NoticeTitle", "NoticeContent", "NoticeDate", "publisher", "BrowseTime", "Memo" };
        //���������Ա���


        /// <summary> 
        /// ����ID
        /// </summary>
        protected long mlngNoticeID;

        /// <summary> 
        /// �������
        /// </summary>
        protected string mstrNoticeTitle;

        /// <summary> 
        /// ��������
        /// </summary>
        protected string mstrNoticeContent;

        /// <summary> 
        /// ��������
        /// </summary>
        protected string mstrNoticeDate;

        /// <summary> 
        /// ������
        /// </summary>
        protected string mstrpublisher;

        /// <summary> 
        /// �������
        /// </summary>
        protected int mintBrowseTime;

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

        public clsNotice()
        {
            SetInit();
            CurrTabName = "Notice";
            lstKeyFldNames.Add("NoticeID");
        }

        public clsNotice(long lngNoticeID)
        {

            mlngNoticeID = lngNoticeID;
            SetInit();
            CurrTabName = "Notice";
            lstKeyFldNames.Add("NoticeID");
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
                if (strAttributeName == "NoticeID")
                {
                    return mlngNoticeID;
                }
                else if (strAttributeName == "NoticeTitle")
                {
                    return mstrNoticeTitle;
                }
                else if (strAttributeName == "NoticeContent")
                {
                    return mstrNoticeContent;
                }
                else if (strAttributeName == "NoticeDate")
                {
                    return mstrNoticeDate;
                }
                else if (strAttributeName == "publisher")
                {
                    return mstrpublisher;
                }
                else if (strAttributeName == "BrowseTime")
                {
                    return mintBrowseTime;
                }
                else if (strAttributeName == "Memo")
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "NoticeID")
                {
                    mlngNoticeID = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "NoticeTitle")
                {
                    mstrNoticeTitle = value.ToString();
                }
                else if (strAttributeName == "NoticeContent")
                {
                    mstrNoticeContent = value.ToString();
                }
                else if (strAttributeName == "NoticeDate")
                {
                    mstrNoticeDate = value.ToString();
                }
                else if (strAttributeName == "publisher")
                {
                    mstrpublisher = value.ToString();
                }
                else if (strAttributeName == "BrowseTime")
                {
                    mintBrowseTime = TransNullToInt(value.ToString());
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
                if ("NoticeID" == AttributeName[intIndex])
                {
                    return mlngNoticeID;
                }
                else if ("NoticeTitle" == AttributeName[intIndex])
                {
                    return mstrNoticeTitle;
                }
                else if ("NoticeContent" == AttributeName[intIndex])
                {
                    return mstrNoticeContent;
                }
                else if ("NoticeDate" == AttributeName[intIndex])
                {
                    return mstrNoticeDate;
                }
                else if ("publisher" == AttributeName[intIndex])
                {
                    return mstrpublisher;
                }
                else if ("BrowseTime" == AttributeName[intIndex])
                {
                    return mintBrowseTime;
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if ("NoticeID" == AttributeName[intIndex])
                {
                    mlngNoticeID = TransNullToInt(value.ToString());
                }
                else if ("NoticeTitle" == AttributeName[intIndex])
                {
                    mstrNoticeTitle = value.ToString();
                }
                else if ("NoticeContent" == AttributeName[intIndex])
                {
                    mstrNoticeContent = value.ToString();
                }
                else if ("NoticeDate" == AttributeName[intIndex])
                {
                    mstrNoticeDate = value.ToString();
                }
                else if ("publisher" == AttributeName[intIndex])
                {
                    mstrpublisher = value.ToString();
                }
                else if ("BrowseTime" == AttributeName[intIndex])
                {
                    mintBrowseTime = TransNullToInt(value.ToString());
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    mstrMemo = value.ToString();
                }
            }
        }

        /// <summary>
        /// ����ID
        /// </summary>
        public long NoticeID
        {
            get
            {
                return mlngNoticeID;
            }
            set
            {
                mlngNoticeID = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("NoticeID");
            }
        }
        /// <summary>
        /// �������
        /// </summary>
        public string NoticeTitle
        {
            get
            {
                return mstrNoticeTitle;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrNoticeTitle = value;
                }
                else
                {
                    mstrNoticeTitle = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("NoticeTitle");
            }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string NoticeContent
        {
            get
            {
                return mstrNoticeContent;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrNoticeContent = value;
                }
                else
                {
                    mstrNoticeContent = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("NoticeContent");
            }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string NoticeDate
        {
            get
            {
                return mstrNoticeDate;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrNoticeDate = value;
                }
                else
                {
                    mstrNoticeDate = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("NoticeDate");
            }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string publisher
        {
            get
            {
                return mstrpublisher;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrpublisher = value;
                }
                else
                {
                    mstrpublisher = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("publisher");
            }
        }
        /// <summary>
        /// �������
        /// </summary>
        public int BrowseTime
        {
            get
            {
                return mintBrowseTime;
            }
            set
            {
                mintBrowseTime = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("BrowseTime");
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