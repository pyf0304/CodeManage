///----------------------
///���ɴ���汾��09.10.08.1
///�������ڣ�2009/11/04
///�����ߣ���Զ��
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
    /// PictureResources(PictureResources)
    /// </summary>
    [Serializable]
    public class clsPictureResources : clsEntityBase2
    {
        public const string CurrTabName_S = "PictureResources"; //��ǰ�������������صı���
        public const string CurrTabKeyFldName_S = "PictureId"; //��ǰ���еĹؼ������ƣ��������صı��йؼ�����
        protected const int mintAttributeCount = 12;
        public static string[] AttributeName = new string[] { "Memo", "PictureConfigerId", "PictureId", "PictureName", "OrginialFileName", "ResizePictureName", "ThumbName", "OrginialFileHeight", "OrginialFileSize", "ResizePictureSize", "ThumbSize", "OrginialFileWidth" };
        //���������Ա���


        /// <summary> 
        /// ��ע
        /// </summary>
        protected string mstrMemo;

        /// <summary> 
        /// ͼƬ����Id
        /// </summary>
        protected string mstrPictureConfigerId;

        /// <summary> 
        /// ͼƬId
        /// </summary>
        protected int mintPictureId;

        /// <summary> 
        /// ͼƬ��
        /// </summary>
        protected string mstrPictureName;

        /// <summary> 
        /// ԭ�ļ���
        /// </summary>
        protected string mstrOrginialFileName;

        /// <summary> 
        /// ���ļ���
        /// </summary>
        protected string mstrResizePictureName;

        /// <summary> 
        /// �����ļ���
        /// </summary>
        protected string mstrThumbName;

        /// <summary> 
        /// ԭͼƬ�߶�
        /// </summary>
        protected int mintOrginialFileHeight;

        /// <summary> 
        /// ԭ�ļ���С
        /// </summary>
        protected int mintOrginialFileSize;

        /// <summary> 
        /// ���ļ���С
        /// </summary>
        protected int mintResizePictureSize;

        /// <summary> 
        /// ����ͼ��С
        /// </summary>
        protected int mintThumbSize;

        /// <summary> 
        /// ԭͼƬ���
        /// </summary>
        protected int mintOrginialFileWidth;

        //�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�
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
        /// <summary>
        /// ͼƬ����Id
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
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("PictureConfigerId");
            }
        }
        /// <summary>
        /// ͼƬId
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
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("PictureId");
            }
        }
        /// <summary>
        /// ͼƬ��
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
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("PictureName");
            }
        }
        /// <summary>
        /// ԭ�ļ���
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
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("OrginialFileName");
            }
        }
        /// <summary>
        /// ���ļ���
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
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("ResizePictureName");
            }
        }
        /// <summary>
        /// �����ļ���
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
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("ThumbName");
            }
        }
        /// <summary>
        /// ԭͼƬ�߶�
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
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("OrginialFileHeight");
            }
        }
        /// <summary>
        /// ԭ�ļ���С
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
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("OrginialFileSize");
            }
        }
        /// <summary>
        /// ���ļ���С
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
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("ResizePictureSize");
            }
        }
        /// <summary>
        /// ����ͼ��С
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
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("ThumbSize");
            }
        }
        /// <summary>
        /// ԭͼƬ���
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
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("OrginialFileWidth");
            }
        }
    }
}