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
    /// PictureResources(PictureResources)
    /// </summary>
    [Serializable]
    public class clsPictureResources : clsEntityBase2
    {
        public const string CurrTabName_S = "PictureResources"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "PictureId"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 12;
        public static string[] AttributeName = new string[] { "Memo", "PictureConfigerId", "PictureId", "PictureName", "OrginialFileName", "ResizePictureName", "ThumbName", "OrginialFileHeight", "OrginialFileSize", "ResizePictureSize", "ThumbSize", "OrginialFileWidth" };
        //以下是属性变量


        /// <summary> 
        /// 备注
        /// </summary>
        protected string mstrMemo;

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
        /// 新文件名
        /// </summary>
        protected string mstrResizePictureName;

        /// <summary> 
        /// 缩略文件名
        /// </summary>
        protected string mstrThumbName;

        /// <summary> 
        /// 原图片高度
        /// </summary>
        protected int mintOrginialFileHeight;

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

        //用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
        private static string m_strConnectString;
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }

        public clsPictureResources()
        {
            SetInit();
            CurrTabName = "PictureResources";
            lstKeyFldNames.Add("PictureId");
        }

        public clsPictureResources(int intPictureId)
        {

            mintPictureId = intPictureId;
            SetInit();
            CurrTabName = "PictureResources";
            lstKeyFldNames.Add("PictureId");
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
                else if (strAttributeName == "ResizePictureName")
                {
                    return mstrResizePictureName;
                }
                else if (strAttributeName == "ThumbName")
                {
                    return mstrThumbName;
                }
                else if (strAttributeName == "OrginialFileHeight")
                {
                    return mintOrginialFileHeight;
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
                return null;
            }
            set
            {
                if (strAttributeName == "Memo")
                {
                    mstrMemo = value.ToString();
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
                else if (strAttributeName == "ResizePictureName")
                {
                    mstrResizePictureName = value.ToString();
                }
                else if (strAttributeName == "ThumbName")
                {
                    mstrThumbName = value.ToString();
                }
                else if (strAttributeName == "OrginialFileHeight")
                {
                    mintOrginialFileHeight = TransNullToInt(value.ToString());
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
                else if ("ResizePictureName" == AttributeName[intIndex])
                {
                    return mstrResizePictureName;
                }
                else if ("ThumbName" == AttributeName[intIndex])
                {
                    return mstrThumbName;
                }
                else if ("OrginialFileHeight" == AttributeName[intIndex])
                {
                    return mintOrginialFileHeight;
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
                return null;
            }
            set
            {
                if ("Memo" == AttributeName[intIndex])
                {
                    mstrMemo = value.ToString();
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
                else if ("ResizePictureName" == AttributeName[intIndex])
                {
                    mstrResizePictureName = value.ToString();
                }
                else if ("ThumbName" == AttributeName[intIndex])
                {
                    mstrThumbName = value.ToString();
                }
                else if ("OrginialFileHeight" == AttributeName[intIndex])
                {
                    mintOrginialFileHeight = TransNullToInt(value.ToString());
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
        /// 新文件名
        /// </summary>
        public string ResizePictureName
        {
            get
            {
                return mstrResizePictureName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrResizePictureName = value;
                }
                else
                {
                    mstrResizePictureName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("ResizePictureName");
            }
        }
        /// <summary>
        /// 缩略文件名
        /// </summary>
        public string ThumbName
        {
            get
            {
                return mstrThumbName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrThumbName = value;
                }
                else
                {
                    mstrThumbName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("ThumbName");
            }
        }
        /// <summary>
        /// 原图片高度
        /// </summary>
        public int OrginialFileHeight
        {
            get
            {
                return mintOrginialFileHeight;
            }
            set
            {
                mintOrginialFileHeight = value;
                //记录修改过的字段
                AddUpdatedFld("OrginialFileHeight");
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
    }
}