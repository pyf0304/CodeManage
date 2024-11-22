///----------------------
///生成代码版本：09.10.08.1
///生成日期：2010/02/05
///生成者：潘以锋
///注意：1、需要数据底层（PubDataBase.dll）的版本：09.10.08.2
///       2、需要公共函数层（TzPubFunction.dll）的版本：09.10.08.1
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
    /// 公告(Notice)
    /// </summary>
    [Serializable]
    public class clsNotice : clsEntityBase2
    {
        public const string CurrTabName_S = "Notice"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "NoticeID"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 7;
        public static string[] AttributeName = new string[] { "NoticeID", "NoticeTitle", "NoticeContent", "NoticeDate", "publisher", "BrowseTime", "Memo" };
        //以下是属性变量


        /// <summary> 
        /// 公告ID
        /// </summary>
        protected long mlngNoticeID;

        /// <summary> 
        /// 公告标题
        /// </summary>
        protected string mstrNoticeTitle;

        /// <summary> 
        /// 公告内容
        /// </summary>
        protected string mstrNoticeContent;

        /// <summary> 
        /// 公告日期
        /// </summary>
        protected string mstrNoticeDate;

        /// <summary> 
        /// 发布者
        /// </summary>
        protected string mstrpublisher;

        /// <summary> 
        /// 浏览次数
        /// </summary>
        protected int mintBrowseTime;

        /// <summary> 
        /// 备注
        /// </summary>
        protected string mstrMemo;

        //用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
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
        /// 公告ID
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
                //记录修改过的字段
                AddUpdatedFld("NoticeID");
            }
        }
        /// <summary>
        /// 公告标题
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
                //记录修改过的字段
                AddUpdatedFld("NoticeTitle");
            }
        }
        /// <summary>
        /// 公告内容
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
                //记录修改过的字段
                AddUpdatedFld("NoticeContent");
            }
        }
        /// <summary>
        /// 公告日期
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
                //记录修改过的字段
                AddUpdatedFld("NoticeDate");
            }
        }
        /// <summary>
        /// 发布者
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
                //记录修改过的字段
                AddUpdatedFld("publisher");
            }
        }
        /// <summary>
        /// 浏览次数
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
                //记录修改过的字段
                AddUpdatedFld("BrowseTime");
            }
        }
        /// <summary>
        /// 备注
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
                //记录修改过的字段
                AddUpdatedFld("Memo");
            }
        }
    }
}