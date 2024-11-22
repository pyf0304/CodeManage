///----------------------
///生成代码版本：2011.05.08.1
///生成日期：2011/05/20
///生成者：潘以锋
///注意：1、需要数据底层（PubDataBase.dll）的版本：2011.05.08.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2011.05.08.1
///========================
using System;
using System.Text;
using System.Collections;
using com.taishsoft.comm_db_obj;

namespace Questionnaire.Entity
{
    /// <summary>
    /// 用户组角色关系(UserGroupRoleRelation)
    /// </summary>
    [Serializable]
    public class clsUserGroupRoleRelationEN : clsEntityBase2
    {
        public const string CurrTabName_S = "UserGroupRoleRelation"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "Mid"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 4;
        public static string[] AttributeName = new string[] { "Mid", "GroupId", "RoleId", "Memo" };
        //以下是属性变量


        /// <summary> 
        /// Mid
        /// </summary>
        protected long mlngMid;

        /// <summary> 
        /// 组Id
        /// </summary>
        protected string mstrGroupId;

        /// <summary> 
        /// 角色Id
        /// </summary>
        protected string mstrRoleId;

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

        public clsUserGroupRoleRelationEN()
        {
            SetInit();
            CurrTabName = "UserGroupRoleRelation";
            lstKeyFldNames.Add("Mid");
        }

        public clsUserGroupRoleRelationEN(long lngMid)
        {

            mlngMid = lngMid;
            SetInit();
            CurrTabName = "UserGroupRoleRelation";
            lstKeyFldNames.Add("Mid");
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
                if (strAttributeName == "Mid")
                {
                    return mlngMid;
                }
                else if (strAttributeName == "GroupId")
                {
                    return mstrGroupId;
                }
                else if (strAttributeName == "RoleId")
                {
                    return mstrRoleId;
                }
                else if (strAttributeName == "Memo")
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "Mid")
                {
                    mlngMid = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "GroupId")
                {
                    mstrGroupId = value.ToString();
                }
                else if (strAttributeName == "RoleId")
                {
                    mstrRoleId = value.ToString();
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
                if ("Mid" == AttributeName[intIndex])
                {
                    return mlngMid;
                }
                else if ("GroupId" == AttributeName[intIndex])
                {
                    return mstrGroupId;
                }
                else if ("RoleId" == AttributeName[intIndex])
                {
                    return mstrRoleId;
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if ("Mid" == AttributeName[intIndex])
                {
                    mlngMid = TransNullToInt(value.ToString());
                }
                else if ("GroupId" == AttributeName[intIndex])
                {
                    mstrGroupId = value.ToString();
                }
                else if ("RoleId" == AttributeName[intIndex])
                {
                    mstrRoleId = value.ToString();
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    mstrMemo = value.ToString();
                }
            }
        }

        /// <summary>
        /// Mid
        /// </summary>
        public long Mid
        {
            get
            {
                return mlngMid;
            }
            set
            {
                mlngMid = value;
                //记录修改过的字段
                AddUpdatedFld("Mid");
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
        /// 角色Id
        /// </summary>
        public string RoleId
        {
            get
            {
                return mstrRoleId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrRoleId = value;
                }
                else
                {
                    mstrRoleId = value;
                }
                //记录修改过的字段
                AddUpdatedFld("RoleId");
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