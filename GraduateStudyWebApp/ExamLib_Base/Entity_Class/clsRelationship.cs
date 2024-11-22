///----------------------
///生成代码版本：09.10.08.1
///生成日期：2009/11/04
///生成者：曹远玲
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
    /// Relationship(Relationship)
    /// </summary>
    [Serializable]
    public class clsRelationship : clsEntityBase2
    {
        public const string CurrTabName_S = "Relationship"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "RelationshipId"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 8;
        public static string[] AttributeName = new string[] { "Memo", "PictureId", "RelationshipId", "DepartmentID", "CreateTime", "CreateUserID", "LastModifyTime", "LastModifyUserID" };
        //以下是属性变量


        /// <summary> 
        /// 备注
        /// </summary>
        protected string mstrMemo;

        /// <summary> 
        /// 图片Id
        /// </summary>
        protected int mintPictureId;

        /// <summary> 
        /// 关系流水Id
        /// </summary>
        protected int mintRelationshipId;

        /// <summary> 
        /// 部门ID
        /// </summary>
        protected int mintDepartmentID;

        /// <summary> 
        /// 建立时间
        /// </summary>
        protected string mstrCreateTime;

        /// <summary> 
        /// 建立用户ID
        /// </summary>
        protected string mstrCreateUserID;

        /// <summary> 
        /// 最后修改时间
        /// </summary>
        protected string mstrLastModifyTime;

        /// <summary> 
        /// 最后修改用户ID
        /// </summary>
        protected string mstrLastModifyUserID;

        //用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
        private static string m_strConnectString;
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }

        public clsRelationship()
        {
            SetInit();
            CurrTabName = "Relationship";
            lstKeyFldNames.Add("RelationshipId");
        }

        public clsRelationship(int intRelationshipId)
        {

            mintRelationshipId = intRelationshipId;
            SetInit();
            CurrTabName = "Relationship";
            lstKeyFldNames.Add("RelationshipId");
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
                if (strAttributeName == "Memo")
                {
                    return mstrMemo;
                }
                else if (strAttributeName == "PictureId")
                {
                    return mintPictureId;
                }
                else if (strAttributeName == "RelationshipId")
                {
                    return mintRelationshipId;
                }
                else if (strAttributeName == "DepartmentID")
                {
                    return mintDepartmentID;
                }
                else if (strAttributeName == "CreateTime")
                {
                    return mstrCreateTime;
                }
                else if (strAttributeName == "CreateUserID")
                {
                    return mstrCreateUserID;
                }
                else if (strAttributeName == "LastModifyTime")
                {
                    return mstrLastModifyTime;
                }
                else if (strAttributeName == "LastModifyUserID")
                {
                    return mstrLastModifyUserID;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "Memo")
                {
                    mstrMemo = value.ToString();
                }
                else if (strAttributeName == "PictureId")
                {
                    mintPictureId = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "RelationshipId")
                {
                    mintRelationshipId = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "DepartmentID")
                {
                    mintDepartmentID = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "CreateTime")
                {
                    mstrCreateTime = value.ToString();
                }
                else if (strAttributeName == "CreateUserID")
                {
                    mstrCreateUserID = value.ToString();
                }
                else if (strAttributeName == "LastModifyTime")
                {
                    mstrLastModifyTime = value.ToString();
                }
                else if (strAttributeName == "LastModifyUserID")
                {
                    mstrLastModifyUserID = value.ToString();
                }
            }
        }
        public object this[int intIndex]
        {
            get
            {
                if ("Memo" == AttributeName[intIndex])
                {
                    return mstrMemo;
                }
                else if ("PictureId" == AttributeName[intIndex])
                {
                    return mintPictureId;
                }
                else if ("RelationshipId" == AttributeName[intIndex])
                {
                    return mintRelationshipId;
                }
                else if ("DepartmentID" == AttributeName[intIndex])
                {
                    return mintDepartmentID;
                }
                else if ("CreateTime" == AttributeName[intIndex])
                {
                    return mstrCreateTime;
                }
                else if ("CreateUserID" == AttributeName[intIndex])
                {
                    return mstrCreateUserID;
                }
                else if ("LastModifyTime" == AttributeName[intIndex])
                {
                    return mstrLastModifyTime;
                }
                else if ("LastModifyUserID" == AttributeName[intIndex])
                {
                    return mstrLastModifyUserID;
                }
                return null;
            }
            set
            {
                if ("Memo" == AttributeName[intIndex])
                {
                    mstrMemo = value.ToString();
                }
                else if ("PictureId" == AttributeName[intIndex])
                {
                    mintPictureId = TransNullToInt(value.ToString());
                }
                else if ("RelationshipId" == AttributeName[intIndex])
                {
                    mintRelationshipId = TransNullToInt(value.ToString());
                }
                else if ("DepartmentID" == AttributeName[intIndex])
                {
                    mintDepartmentID = TransNullToInt(value.ToString());
                }
                else if ("CreateTime" == AttributeName[intIndex])
                {
                    mstrCreateTime = value.ToString();
                }
                else if ("CreateUserID" == AttributeName[intIndex])
                {
                    mstrCreateUserID = value.ToString();
                }
                else if ("LastModifyTime" == AttributeName[intIndex])
                {
                    mstrLastModifyTime = value.ToString();
                }
                else if ("LastModifyUserID" == AttributeName[intIndex])
                {
                    mstrLastModifyUserID = value.ToString();
                }
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
        /// <summary>
        /// 图片Id
        /// </summary>
        public int PictureId
        {
            get
            {
                return mintPictureId;
            }
            set
            {
                mintPictureId = value;
                //记录修改过的字段
                AddUpdatedFld("PictureId");
            }
        }
        /// <summary>
        /// 关系流水Id
        /// </summary>
        public int RelationshipId
        {
            get
            {
                return mintRelationshipId;
            }
            set
            {
                mintRelationshipId = value;
                //记录修改过的字段
                AddUpdatedFld("RelationshipId");
            }
        }
        /// <summary>
        /// 部门ID
        /// </summary>
        public int DepartmentID
        {
            get
            {
                return mintDepartmentID;
            }
            set
            {
                mintDepartmentID = value;
                //记录修改过的字段
                AddUpdatedFld("DepartmentID");
            }
        }
        /// <summary>
        /// 建立时间
        /// </summary>
        public string CreateTime
        {
            get
            {
                return mstrCreateTime;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrCreateTime = value;
                }
                else
                {
                    mstrCreateTime = value;
                }
                //记录修改过的字段
                AddUpdatedFld("CreateTime");
            }
        }
        /// <summary>
        /// 建立用户ID
        /// </summary>
        public string CreateUserID
        {
            get
            {
                return mstrCreateUserID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrCreateUserID = value;
                }
                else
                {
                    mstrCreateUserID = value;
                }
                //记录修改过的字段
                AddUpdatedFld("CreateUserID");
            }
        }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public string LastModifyTime
        {
            get
            {
                return mstrLastModifyTime;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrLastModifyTime = value;
                }
                else
                {
                    mstrLastModifyTime = value;
                }
                //记录修改过的字段
                AddUpdatedFld("LastModifyTime");
            }
        }
        /// <summary>
        /// 最后修改用户ID
        /// </summary>
        public string LastModifyUserID
        {
            get
            {
                return mstrLastModifyUserID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrLastModifyUserID = value;
                }
                else
                {
                    mstrLastModifyUserID = value;
                }
                //记录修改过的字段
                AddUpdatedFld("LastModifyUserID");
            }
        }
    }
}