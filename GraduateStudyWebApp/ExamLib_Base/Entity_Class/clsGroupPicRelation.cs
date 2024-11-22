///----------------------
///生成代码版本：09.10.08.1
///生成日期：2009/12/27
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
    /// 组图片关系(GroupPicRelation)
    /// </summary>
    [Serializable]
    public class clsGroupPicRelation : clsEntityBase2
    {
        public const string CurrTabName_S = "GroupPicRelation"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "RelationshipId"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 9;
        public static string[] AttributeName = new string[] { "RelationshipId", "GroupId", "PictureConfigerId", "PictureId", "CreateTime", "CreateUserID", "LastModifyUserID", "LastModifyTime", "Memo" };
        //以下是属性变量


        /// <summary> 
        /// 关系流水Id
        /// </summary>
        protected int mintRelationshipId;

        /// <summary> 
        /// 组Id
        /// </summary>
        protected string mstrGroupId;

        /// <summary> 
        /// 图片配置Id
        /// </summary>
        protected string mstrPictureConfigerId;

        /// <summary> 
        /// 图片Id
        /// </summary>
        protected int mintPictureId;

        /// <summary> 
        /// 创建时间
        /// </summary>
        protected string mstrCreateTime;

        /// <summary> 
        /// 建立用户ID
        /// </summary>
        protected string mstrCreateUserID;

        /// <summary> 
        /// 最后修改用户ID
        /// </summary>
        protected string mstrLastModifyUserID;

        /// <summary> 
        /// 最后修改时间
        /// </summary>
        protected string mstrLastModifyTime;

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

        public clsGroupPicRelation()
        {
            SetInit();
            CurrTabName = "GroupPicRelation";
            lstKeyFldNames.Add("RelationshipId");
        }

        public clsGroupPicRelation(int intRelationshipId)
        {

            mintRelationshipId = intRelationshipId;
            SetInit();
            CurrTabName = "GroupPicRelation";
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
                if (strAttributeName == "RelationshipId")
                {
                    return mintRelationshipId;
                }
                else if (strAttributeName == "GroupId")
                {
                    return mstrGroupId;
                }
                else if (strAttributeName == "PictureConfigerId")
                {
                    return mstrPictureConfigerId;
                }
                else if (strAttributeName == "PictureId")
                {
                    return mintPictureId;
                }
                else if (strAttributeName == "CreateTime")
                {
                    return mstrCreateTime;
                }
                else if (strAttributeName == "CreateUserID")
                {
                    return mstrCreateUserID;
                }
                else if (strAttributeName == "LastModifyUserID")
                {
                    return mstrLastModifyUserID;
                }
                else if (strAttributeName == "LastModifyTime")
                {
                    return mstrLastModifyTime;
                }
                else if (strAttributeName == "Memo")
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "RelationshipId")
                {
                    mintRelationshipId = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "GroupId")
                {
                    mstrGroupId = value.ToString();
                }
                else if (strAttributeName == "PictureConfigerId")
                {
                    mstrPictureConfigerId = value.ToString();
                }
                else if (strAttributeName == "PictureId")
                {
                    mintPictureId = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "CreateTime")
                {
                    mstrCreateTime = value.ToString();
                }
                else if (strAttributeName == "CreateUserID")
                {
                    mstrCreateUserID = value.ToString();
                }
                else if (strAttributeName == "LastModifyUserID")
                {
                    mstrLastModifyUserID = value.ToString();
                }
                else if (strAttributeName == "LastModifyTime")
                {
                    mstrLastModifyTime = value.ToString();
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
                if ("RelationshipId" == AttributeName[intIndex])
                {
                    return mintRelationshipId;
                }
                else if ("GroupId" == AttributeName[intIndex])
                {
                    return mstrGroupId;
                }
                else if ("PictureConfigerId" == AttributeName[intIndex])
                {
                    return mstrPictureConfigerId;
                }
                else if ("PictureId" == AttributeName[intIndex])
                {
                    return mintPictureId;
                }
                else if ("CreateTime" == AttributeName[intIndex])
                {
                    return mstrCreateTime;
                }
                else if ("CreateUserID" == AttributeName[intIndex])
                {
                    return mstrCreateUserID;
                }
                else if ("LastModifyUserID" == AttributeName[intIndex])
                {
                    return mstrLastModifyUserID;
                }
                else if ("LastModifyTime" == AttributeName[intIndex])
                {
                    return mstrLastModifyTime;
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if ("RelationshipId" == AttributeName[intIndex])
                {
                    mintRelationshipId = TransNullToInt(value.ToString());
                }
                else if ("GroupId" == AttributeName[intIndex])
                {
                    mstrGroupId = value.ToString();
                }
                else if ("PictureConfigerId" == AttributeName[intIndex])
                {
                    mstrPictureConfigerId = value.ToString();
                }
                else if ("PictureId" == AttributeName[intIndex])
                {
                    mintPictureId = TransNullToInt(value.ToString());
                }
                else if ("CreateTime" == AttributeName[intIndex])
                {
                    mstrCreateTime = value.ToString();
                }
                else if ("CreateUserID" == AttributeName[intIndex])
                {
                    mstrCreateUserID = value.ToString();
                }
                else if ("LastModifyUserID" == AttributeName[intIndex])
                {
                    mstrLastModifyUserID = value.ToString();
                }
                else if ("LastModifyTime" == AttributeName[intIndex])
                {
                    mstrLastModifyTime = value.ToString();
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    mstrMemo = value.ToString();
                }
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
        /// 图片配置Id
        /// </summary>
        public string PictureConfigerId
        {
            get
            {
                return mstrPictureConfigerId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPictureConfigerId = value;
                }
                else
                {
                    mstrPictureConfigerId = value;
                }
                //记录修改过的字段
                AddUpdatedFld("PictureConfigerId");
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
        /// 创建时间
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