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
    /// 用户组部门关系(UserGroupDepartmentRelation)
    /// </summary>
    [Serializable]
    public class clsUserGroupDepartmentRelationEN : clsEntityBase2
    {
        public const string CurrTabName_S = "UserGroupDepartmentRelation"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "Mid"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 4;
        public static string[] AttributeName = new string[] { "Mid", "UserGroupId", "DepartmentId", "Memo" };
        //以下是属性变量


        /// <summary> 
        /// Mid
        /// </summary>
        protected long mlngMid;

        /// <summary> 
        /// 用户组Id
        /// </summary>
        protected string mstrUserGroupId;

        /// <summary> 
        /// 部门Id
        /// </summary>
        protected string mstrDepartmentId;

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

        public clsUserGroupDepartmentRelationEN()
        {
            SetInit();
            CurrTabName = "UserGroupDepartmentRelation";
            lstKeyFldNames.Add("Mid");
        }

        public clsUserGroupDepartmentRelationEN(long lngMid)
        {

            mlngMid = lngMid;
            SetInit();
            CurrTabName = "UserGroupDepartmentRelation";
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
                else if (strAttributeName == "UserGroupId")
                {
                    return mstrUserGroupId;
                }
                else if (strAttributeName == "DepartmentId")
                {
                    return mstrDepartmentId;
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
                else if (strAttributeName == "UserGroupId")
                {
                    mstrUserGroupId = value.ToString();
                }
                else if (strAttributeName == "DepartmentId")
                {
                    mstrDepartmentId = value.ToString();
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
                else if ("UserGroupId" == AttributeName[intIndex])
                {
                    return mstrUserGroupId;
                }
                else if ("DepartmentId" == AttributeName[intIndex])
                {
                    return mstrDepartmentId;
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
                else if ("UserGroupId" == AttributeName[intIndex])
                {
                    mstrUserGroupId = value.ToString();
                }
                else if ("DepartmentId" == AttributeName[intIndex])
                {
                    mstrDepartmentId = value.ToString();
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
        /// 用户组Id
        /// </summary>
        public string UserGroupId
        {
            get
            {
                return mstrUserGroupId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrUserGroupId = value;
                }
                else
                {
                    mstrUserGroupId = value;
                }
                //记录修改过的字段
                AddUpdatedFld("UserGroupId");
            }
        }
        /// <summary>
        /// 部门Id
        /// </summary>
        public string DepartmentId
        {
            get
            {
                return mstrDepartmentId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDepartmentId = value;
                }
                else
                {
                    mstrDepartmentId = value;
                }
                //记录修改过的字段
                AddUpdatedFld("DepartmentId");
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