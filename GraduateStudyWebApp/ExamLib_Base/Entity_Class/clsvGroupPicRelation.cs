///----------------------
///生成代码版本：09.10.08.1
///生成日期：2009/12/28
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
    /// vGroupPicRelation(vGroupPicRelation)
    /// </summary>
    [Serializable]
    public class clsvGroupPicRelation : clsEntityBase2
    {
        public const string CurrTabName_S = "vGroupPicRelation"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "RelationshipId"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 20;
        public static string[] AttributeName = new string[] { "RelationshipId", "GroupId", "GroupName", "CreateTime", "PictureConfigerId", "PictureId", "PictureName", "OrginialFileName", "OrginialFileSize", "ResizePictureSize", "ThumbSize", "OrginialFileWidth", "CreateUserID", "LastModifyUserID", "LastModifyTime", "CreateUserName", "Memo", "LastModifyUserName", "PictureConfigName", "PicturePath" };
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
        /// 组名称
        /// </summary>
        protected string mstrGroupName;

        /// <summary> 
        /// 创建时间
        /// </summary>
        protected string mstrCreateTime;

        /// <summary> 
        /// 图片配置Id
        /// </summary>
        protected string mstrPictureConfigerId;

        /// <summary> 
        /// 图片Id
        /// </summary>
        protected int mintPictureId;

        /// <summary> 
        /// 图片名
        /// </summary>
        protected string mstrPictureName;

        /// <summary> 
        /// 原文件名
        /// </summary>
        protected string mstrOrginialFileName;

        /// <summary> 
        /// 原文件大小
        /// </summary>
        protected int mintOrginialFileSize;

        /// <summary> 
        /// 新文件大小
        /// </summary>
        protected int mintResizePictureSize;

        /// <summary> 
        /// 缩略图大小
        /// </summary>
        protected int mintThumbSize;

        /// <summary> 
        /// 原图片宽度
        /// </summary>
        protected int mintOrginialFileWidth;

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
        /// CreateUserName
        /// </summary>
        protected string mstrCreateUserName;

        /// <summary> 
        /// 备注
        /// </summary>
        protected string mstrMemo;

        /// <summary> 
        /// LastModifyUserName
        /// </summary>
        protected string mstrLastModifyUserName;

        /// <summary> 
        /// 图片配置名
        /// </summary>
        protected string mstrPictureConfigName;

        /// <summary> 
        /// 图片路径
        /// </summary>
        protected string mstrPicturePath;

        //用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
        private static string m_strConnectString;
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }

        public clsvGroupPicRelation()
        {
            SetInit();
            CurrTabName = "vGroupPicRelation";
            lstKeyFldNames.Add("RelationshipId");
        }

        public clsvGroupPicRelation(int intRelationshipId)
        {

            mintRelationshipId = intRelationshipId;
            SetInit();
            CurrTabName = "vGroupPicRelation";
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
                else if (strAttributeName == "GroupName")
                {
                    return mstrGroupName;
                }
                else if (strAttributeName == "CreateTime")
                {
                    return mstrCreateTime;
                }
                else if (strAttributeName == "PictureConfigerId")
                {
                    return mstrPictureConfigerId;
                }
                else if (strAttributeName == "PictureId")
                {
                    return mintPictureId;
                }
                else if (strAttributeName == "PictureName")
                {
                    return mstrPictureName;
                }
                else if (strAttributeName == "OrginialFileName")
                {
                    return mstrOrginialFileName;
                }
                else if (strAttributeName == "OrginialFileSize")
                {
                    return mintOrginialFileSize;
                }
                else if (strAttributeName == "ResizePictureSize")
                {
                    return mintResizePictureSize;
                }
                else if (strAttributeName == "ThumbSize")
                {
                    return mintThumbSize;
                }
                else if (strAttributeName == "OrginialFileWidth")
                {
                    return mintOrginialFileWidth;
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
                else if (strAttributeName == "CreateUserName")
                {
                    return mstrCreateUserName;
                }
                else if (strAttributeName == "Memo")
                {
                    return mstrMemo;
                }
                else if (strAttributeName == "LastModifyUserName")
                {
                    return mstrLastModifyUserName;
                }
                else if (strAttributeName == "PictureConfigName")
                {
                    return mstrPictureConfigName;
                }
                else if (strAttributeName == "PicturePath")
                {
                    return mstrPicturePath;
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
                else if (strAttributeName == "GroupName")
                {
                    mstrGroupName = value.ToString();
                }
                else if (strAttributeName == "CreateTime")
                {
                    mstrCreateTime = value.ToString();
                }
                else if (strAttributeName == "PictureConfigerId")
                {
                    mstrPictureConfigerId = value.ToString();
                }
                else if (strAttributeName == "PictureId")
                {
                    mintPictureId = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "PictureName")
                {
                    mstrPictureName = value.ToString();
                }
                else if (strAttributeName == "OrginialFileName")
                {
                    mstrOrginialFileName = value.ToString();
                }
                else if (strAttributeName == "OrginialFileSize")
                {
                    mintOrginialFileSize = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "ResizePictureSize")
                {
                    mintResizePictureSize = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "ThumbSize")
                {
                    mintThumbSize = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "OrginialFileWidth")
                {
                    mintOrginialFileWidth = TransNullToInt(value.ToString());
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
                else if (strAttributeName == "CreateUserName")
                {
                    mstrCreateUserName = value.ToString();
                }
                else if (strAttributeName == "Memo")
                {
                    mstrMemo = value.ToString();
                }
                else if (strAttributeName == "LastModifyUserName")
                {
                    mstrLastModifyUserName = value.ToString();
                }
                else if (strAttributeName == "PictureConfigName")
                {
                    mstrPictureConfigName = value.ToString();
                }
                else if (strAttributeName == "PicturePath")
                {
                    mstrPicturePath = value.ToString();
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
                else if ("GroupName" == AttributeName[intIndex])
                {
                    return mstrGroupName;
                }
                else if ("CreateTime" == AttributeName[intIndex])
                {
                    return mstrCreateTime;
                }
                else if ("PictureConfigerId" == AttributeName[intIndex])
                {
                    return mstrPictureConfigerId;
                }
                else if ("PictureId" == AttributeName[intIndex])
                {
                    return mintPictureId;
                }
                else if ("PictureName" == AttributeName[intIndex])
                {
                    return mstrPictureName;
                }
                else if ("OrginialFileName" == AttributeName[intIndex])
                {
                    return mstrOrginialFileName;
                }
                else if ("OrginialFileSize" == AttributeName[intIndex])
                {
                    return mintOrginialFileSize;
                }
                else if ("ResizePictureSize" == AttributeName[intIndex])
                {
                    return mintResizePictureSize;
                }
                else if ("ThumbSize" == AttributeName[intIndex])
                {
                    return mintThumbSize;
                }
                else if ("OrginialFileWidth" == AttributeName[intIndex])
                {
                    return mintOrginialFileWidth;
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
                else if ("CreateUserName" == AttributeName[intIndex])
                {
                    return mstrCreateUserName;
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    return mstrMemo;
                }
                else if ("LastModifyUserName" == AttributeName[intIndex])
                {
                    return mstrLastModifyUserName;
                }
                else if ("PictureConfigName" == AttributeName[intIndex])
                {
                    return mstrPictureConfigName;
                }
                else if ("PicturePath" == AttributeName[intIndex])
                {
                    return mstrPicturePath;
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
                else if ("GroupName" == AttributeName[intIndex])
                {
                    mstrGroupName = value.ToString();
                }
                else if ("CreateTime" == AttributeName[intIndex])
                {
                    mstrCreateTime = value.ToString();
                }
                else if ("PictureConfigerId" == AttributeName[intIndex])
                {
                    mstrPictureConfigerId = value.ToString();
                }
                else if ("PictureId" == AttributeName[intIndex])
                {
                    mintPictureId = TransNullToInt(value.ToString());
                }
                else if ("PictureName" == AttributeName[intIndex])
                {
                    mstrPictureName = value.ToString();
                }
                else if ("OrginialFileName" == AttributeName[intIndex])
                {
                    mstrOrginialFileName = value.ToString();
                }
                else if ("OrginialFileSize" == AttributeName[intIndex])
                {
                    mintOrginialFileSize = TransNullToInt(value.ToString());
                }
                else if ("ResizePictureSize" == AttributeName[intIndex])
                {
                    mintResizePictureSize = TransNullToInt(value.ToString());
                }
                else if ("ThumbSize" == AttributeName[intIndex])
                {
                    mintThumbSize = TransNullToInt(value.ToString());
                }
                else if ("OrginialFileWidth" == AttributeName[intIndex])
                {
                    mintOrginialFileWidth = TransNullToInt(value.ToString());
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
                else if ("CreateUserName" == AttributeName[intIndex])
                {
                    mstrCreateUserName = value.ToString();
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    mstrMemo = value.ToString();
                }
                else if ("LastModifyUserName" == AttributeName[intIndex])
                {
                    mstrLastModifyUserName = value.ToString();
                }
                else if ("PictureConfigName" == AttributeName[intIndex])
                {
                    mstrPictureConfigName = value.ToString();
                }
                else if ("PicturePath" == AttributeName[intIndex])
                {
                    mstrPicturePath = value.ToString();
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
        /// 图片名
        /// </summary>
        public string PictureName
        {
            get
            {
                return mstrPictureName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPictureName = value;
                }
                else
                {
                    mstrPictureName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("PictureName");
            }
        }
        /// <summary>
        /// 原文件名
        /// </summary>
        public string OrginialFileName
        {
            get
            {
                return mstrOrginialFileName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrOrginialFileName = value;
                }
                else
                {
                    mstrOrginialFileName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("OrginialFileName");
            }
        }
        /// <summary>
        /// 原文件大小
        /// </summary>
        public int OrginialFileSize
        {
            get
            {
                return mintOrginialFileSize;
            }
            set
            {
                mintOrginialFileSize = value;
                //记录修改过的字段
                AddUpdatedFld("OrginialFileSize");
            }
        }
        /// <summary>
        /// 新文件大小
        /// </summary>
        public int ResizePictureSize
        {
            get
            {
                return mintResizePictureSize;
            }
            set
            {
                mintResizePictureSize = value;
                //记录修改过的字段
                AddUpdatedFld("ResizePictureSize");
            }
        }
        /// <summary>
        /// 缩略图大小
        /// </summary>
        public int ThumbSize
        {
            get
            {
                return mintThumbSize;
            }
            set
            {
                mintThumbSize = value;
                //记录修改过的字段
                AddUpdatedFld("ThumbSize");
            }
        }
        /// <summary>
        /// 原图片宽度
        /// </summary>
        public int OrginialFileWidth
        {
            get
            {
                return mintOrginialFileWidth;
            }
            set
            {
                mintOrginialFileWidth = value;
                //记录修改过的字段
                AddUpdatedFld("OrginialFileWidth");
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
        /// CreateUserName
        /// </summary>
        public string CreateUserName
        {
            get
            {
                return mstrCreateUserName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrCreateUserName = value;
                }
                else
                {
                    mstrCreateUserName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("CreateUserName");
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
        /// LastModifyUserName
        /// </summary>
        public string LastModifyUserName
        {
            get
            {
                return mstrLastModifyUserName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrLastModifyUserName = value;
                }
                else
                {
                    mstrLastModifyUserName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("LastModifyUserName");
            }
        }
        /// <summary>
        /// 图片配置名
        /// </summary>
        public string PictureConfigName
        {
            get
            {
                return mstrPictureConfigName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPictureConfigName = value;
                }
                else
                {
                    mstrPictureConfigName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("PictureConfigName");
            }
        }
        /// <summary>
        /// 图片路径
        /// </summary>
        public string PicturePath
        {
            get
            {
                return mstrPicturePath;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPicturePath = value;
                }
                else
                {
                    mstrPicturePath = value;
                }
                //记录修改过的字段
                AddUpdatedFld("PicturePath");
            }
        }
    }
}