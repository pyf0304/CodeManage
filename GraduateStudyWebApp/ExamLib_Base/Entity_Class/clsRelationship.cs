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
    /// Relationship(Relationship)
    /// </summary>
    [Serializable]
    public class clsRelationship : clsEntityBase2
    {
        public const string CurrTabName_S = "Relationship"; //��ǰ�������������صı���
        public const string CurrTabKeyFldName_S = "RelationshipId"; //��ǰ���еĹؼ������ƣ��������صı��йؼ�����
        protected const int mintAttributeCount = 8;
        public static string[] AttributeName = new string[] { "Memo", "PictureId", "RelationshipId", "DepartmentID", "CreateTime", "CreateUserID", "LastModifyTime", "LastModifyUserID" };
        //���������Ա���


        /// <summary> 
        /// ��ע
        /// </summary>
        protected string mstrMemo;

        /// <summary> 
        /// ͼƬId
        /// </summary>
        protected int mintPictureId;

        /// <summary> 
        /// ��ϵ��ˮId
        /// </summary>
        protected int mintRelationshipId;

        /// <summary> 
        /// ����ID
        /// </summary>
        protected int mintDepartmentID;

        /// <summary> 
        /// ����ʱ��
        /// </summary>
        protected string mstrCreateTime;

        /// <summary> 
        /// �����û�ID
        /// </summary>
        protected string mstrCreateUserID;

        /// <summary> 
        /// ����޸�ʱ��
        /// </summary>
        protected string mstrLastModifyTime;

        /// <summary> 
        /// ����޸��û�ID
        /// </summary>
        protected string mstrLastModifyUserID;

        //�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�
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
        /// ��ϵ��ˮId
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
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("RelationshipId");
            }
        }
        /// <summary>
        /// ����ID
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
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("DepartmentID");
            }
        }
        /// <summary>
        /// ����ʱ��
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
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("CreateTime");
            }
        }
        /// <summary>
        /// �����û�ID
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
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("CreateUserID");
            }
        }
        /// <summary>
        /// ����޸�ʱ��
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
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("LastModifyTime");
            }
        }
        /// <summary>
        /// ����޸��û�ID
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
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("LastModifyUserID");
            }
        }
    }
}