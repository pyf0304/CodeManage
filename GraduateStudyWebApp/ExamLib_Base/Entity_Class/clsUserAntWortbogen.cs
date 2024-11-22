///----------------------
///生成代码版本：09.10.08.1
///生成日期：2010/11/23
///生成者：潘以锋
///注意：1、需要数据底层（PubDataBase.dll）的版本：2010.05.04.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2010.05.04.1
///========================
using System;
using System.Text;
using System.Collections;
using com.taishsoft.comm_db_obj;

namespace Questionnaire.Entity
{
    /// <summary>
    /// 问卷调查结果(UserAnswerResult)
    /// </summary>
    [Serializable]
    public class clsUserAnswerResultEN : clsEntityBase2
    {
        public const string CurrTabName_S = "UserAnswerResult"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "MinID"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 14;
        public static string[] AttributeName = new string[] { "MinID", "QuestionnaireSetId", "School", "UserID", "QuestionID", "AnswerID", "AnswerText", "AnswerDate", "AnswerTime", "AnswerIP", "AnswerMode", "id_School", "BatchId", "Memo" };
        //以下是属性变量


        /// <summary> 
        /// 答卷ID
        /// </summary>
        protected long mlngMinID;

        /// <summary> 
        /// 问卷集ID
        /// </summary>
        protected string mstrQuestionnaireSetId;

        /// <summary> 
        /// 学校
        /// </summary>
        protected string mstrSchool;

        /// <summary> 
        /// 用户ID
        /// </summary>
        protected string mstrUserID;

        /// <summary> 
        /// 题目ID
        /// </summary>
        protected long mlngQuestionID;

        /// <summary> 
        /// 问答ID
        /// </summary>
        protected long mlngAnswerID;

        /// <summary> 
        /// 问答内容
        /// </summary>
        protected string mstrAnswerText;

        /// <summary> 
        /// 回答日期
        /// </summary>
        protected string mstrAnswerDate;

        /// <summary> 
        /// 回答时间
        /// </summary>
        protected string mstrAnswerTime;

        /// <summary> 
        /// 回答IP
        /// </summary>
        protected string mstrAnswerIP;

        /// <summary> 
        /// 回答模式
        /// </summary>
        protected int mintAnswerMode;

        /// <summary> 
        /// 学校流水号
        /// </summary>
        protected string mstrid_School;

        /// <summary> 
        /// 批次ID
        /// </summary>
        protected string mstrBatchId;

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
        /// 答卷ID
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
                //记录修改过的字段
                AddUpdatedFld("MinID");
            }
        }
        /// <summary>
        /// 问卷集ID
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
                //记录修改过的字段
                AddUpdatedFld("QuestionnaireSetId");
            }
        }
        /// <summary>
        /// 学校
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
                //记录修改过的字段
                AddUpdatedFld("School");
            }
        }
        /// <summary>
        /// 用户ID
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
                //记录修改过的字段
                AddUpdatedFld("UserID");
            }
        }
        /// <summary>
        /// 题目ID
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
                //记录修改过的字段
                AddUpdatedFld("QuestionID");
            }
        }
        /// <summary>
        /// 问答ID
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
                //记录修改过的字段
                AddUpdatedFld("AnswerID");
            }
        }
        /// <summary>
        /// 问答内容
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
                //记录修改过的字段
                AddUpdatedFld("AnswerText");
            }
        }
        /// <summary>
        /// 回答日期
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
                //记录修改过的字段
                AddUpdatedFld("AnswerDate");
            }
        }
        /// <summary>
        /// 回答时间
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
                //记录修改过的字段
                AddUpdatedFld("AnswerTime");
            }
        }
        /// <summary>
        /// 回答IP
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
                //记录修改过的字段
                AddUpdatedFld("AnswerIP");
            }
        }
        /// <summary>
        /// 回答模式
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
                //记录修改过的字段
                AddUpdatedFld("AnswerMode");
            }
        }
        /// <summary>
        /// 学校流水号
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
                //记录修改过的字段
                AddUpdatedFld("id_School");
            }
        }
        /// <summary>
        /// 批次ID
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
                //记录修改过的字段
                AddUpdatedFld("BatchId");
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