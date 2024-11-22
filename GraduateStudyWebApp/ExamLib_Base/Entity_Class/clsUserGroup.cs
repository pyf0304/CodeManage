///----------------------
///生成代码版本：09.10.08.1
///生成日期：2010/02/09
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
    /// 用户组(UserGroup)
    /// </summary>
    [Serializable]
    public class clsUserGroup : clsEntityBase2
    {
        public const string CurrTabName_S = "UserGroup"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "GroupId"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 4;
        public static string[] AttributeName = new string[] { "GroupId", "GroupName", "HomePage", "Memo" };
        //以下是属性变量


        /// <summary> 
        /// 组Id
        /// </summary>
        protected string mstrGroupId;

        /// <summary> 
        /// 组名称
        /// </summary>
        protected string mstrGroupName;

        /// <summary> 
        /// 主页
        /// </summary>
        protected string mstrHomePage;

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

        public clsUserGroup()
        {
            SetInit();
            CurrTabName = "UserGroup";
            lstKeyFldNames.Add("GroupId");
        }

        public clsUserGroup(string strGroupId)
        {

            mstrGroupId = strGroupId;
            SetInit();
            CurrTabName = "UserGroup";
            lstKeyFldNames.Add("GroupId");
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
                if (strAttributeName == "GroupId")
                {
                    return mstrGroupId;
                }
                else if (strAttributeName == "GroupName")
                {
                    return mstrGroupName;
                }
                else if (strAttributeName == "HomePage")
                {
                    return mstrHomePage;
                }
                else if (strAttributeName == "Memo")
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "GroupId")
                {
                    mstrGroupId = value.ToString();
                }
                else if (strAttributeName == "GroupName")
                {
                    mstrGroupName = value.ToString();
                }
                else if (strAttributeName == "HomePage")
                {
                    mstrHomePage = value.ToString();
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
                if ("GroupId" == AttributeName[intIndex])
                {
                    return mstrGroupId;
                }
                else if ("GroupName" == AttributeName[intIndex])
                {
                    return mstrGroupName;
                }
                else if ("HomePage" == AttributeName[intIndex])
                {
                    return mstrHomePage;
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if ("GroupId" == AttributeName[intIndex])
                {
                    mstrGroupId = value.ToString();
                }
                else if ("GroupName" == AttributeName[intIndex])
                {
                    mstrGroupName = value.ToString();
                }
                else if ("HomePage" == AttributeName[intIndex])
                {
                    mstrHomePage = value.ToString();
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    mstrMemo = value.ToString();
                }
            }
        }

        /// <summary>
        /// 组Id
        /// </summary>
        public string GroupId
        {
            get
            {
                return mstrGroupId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrGroupId = value;
                }
                else
                {
                    mstrGroupId = value;
                }
                //记录修改过的字段
                AddUpdatedFld("GroupId");
            }
        }
        /// <summary>
        /// 组名称
        /// </summary>
        public string GroupName
        {
            get
            {
                return mstrGroupName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrGroupName = value;
                }
                else
                {
                    mstrGroupName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("GroupName");
            }
        }
        /// <summary>
        /// 主页
        /// </summary>
        public string HomePage
        {
            get
            {
                return mstrHomePage;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrHomePage = value;
                }
                else
                {
                    mstrHomePage = value;
                }
                //记录修改过的字段
                AddUpdatedFld("HomePage");
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