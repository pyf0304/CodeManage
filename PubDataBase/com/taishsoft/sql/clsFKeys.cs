
///----------------------
///���ɴ���汾��2013.04.17.1
///�������ڣ�2013/06/19
///�����ߣ����Է�
///�������ƣ�AGC_CSV7
///����ID��0005
///ģ����������ϵͳ����
///ģ��Ӣ������SysPara
///ע�⣺1����Ҫ���ݵײ㣨PubDataBase.dll���İ汾��2013.04.05.3
///       2����Ҫ���������㣨TzPubFunction.dll���İ汾��2013.04.25.2
///========================
using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.common;
using com.taishsoft.commexception;
using com.taishsoft.commdb;
using System.Collections.Generic;


namespace com.taishsoft.sql
{

    /// <summary>
    /// �����(FKeys)
    /// </summary>
    [Serializable]
    public class clsFKeys : clsGeneralTab2
    {
        /// <summary>
        /// ��ǰ�������������صı���
        /// </summary>
        public const string CurrTabName_S = "FKeys";
        /// <summary>
        /// ��ǰ���еĹؼ������ƣ��������صı��йؼ�����
        /// </summary>
        public const string CurrTabKeyFldName_S = "Id";
        /// <summary>
        /// ��ǰ������Ը���
        /// </summary>
        protected const int mintAttributeCount = 12;
        /// <summary>
        /// ��ǰ�������������
        /// </summary>
        public static string[] AttributeName = new string[] { "Id", "FKeyName", "FKeyColumnID", "FKeyColumnName", "FKeyTabID", "FKeyTabName", "PKeyColumnID", "PKeyColumnName", "PKeyTabId", "PKeyTabName", "Update_Action", "Delete_Action" };
        //���������Ա���

        /// <summary> 
        /// ����Id(�ֶ�����:bigint,�ֶγ���:8,�Ƿ�ɿ�:False)
        /// </summary>
        protected long mlngId;
        /// <summary> 
        /// �������(�ֶ�����:varchar,�ֶγ���:128,�Ƿ�ɿ�:False)
        /// </summary>
        protected string mstrFKeyName;
        /// <summary> 
        /// �����Id(�ֶ�����:varchar,�ֶγ���:128,�Ƿ�ɿ�:False)
        /// </summary>
        protected string mstrFKeyColumnID;
        /// <summary> 
        /// �������(�ֶ�����:varchar,�ֶγ���:128,�Ƿ�ɿ�:False)
        /// </summary>
        protected string mstrFKeyColumnName;
        /// <summary> 
        /// �����ID(�ֶ�����:varchar,�ֶγ���:128,�Ƿ�ɿ�:True)
        /// </summary>
        protected string mstrFKeyTabID;
        /// <summary> 
        /// ���������(�ֶ�����:varchar,�ֶγ���:128,�Ƿ�ɿ�:False)
        /// </summary>
        protected string mstrFKeyTabName;
        /// <summary> 
        /// ������ID(�ֶ�����:varchar,�ֶγ���:128,�Ƿ�ɿ�:False)
        /// </summary>
        protected string mstrPKeyColumnID;
        /// <summary> 
        /// ��������(�ֶ�����:varchar,�ֶγ���:128,�Ƿ�ɿ�:False)
        /// </summary>
        protected string mstrPKeyColumnName;
        /// <summary> 
        /// ������Id(�ֶ�����:varchar,�ֶγ���:128,�Ƿ�ɿ�:False)
        /// </summary>
        protected string mstrPKeyTabId;
        /// <summary> 
        /// ��������(�ֶ�����:varchar,�ֶγ���:128,�Ƿ�ɿ�:False)
        /// </summary>
        protected string mstrPKeyTabName;
        /// <summary> 
        /// ��������(�ֶ�����:varchar,�ֶγ���:128,�Ƿ�ɿ�:False)
        /// </summary>
        protected string mstrUpdate_Action;
        /// <summary> 
        /// ����ɾ��(�ֶ�����:int,�ֶγ���:4,�Ƿ�ɿ�:False)
        /// </summary>
        protected int mintDelete_Action;

        /// <summary> 
        /// ����Tag(�ֶ�����:int,�ֶγ���:4,�Ƿ�ɿ�:False)
        /// </summary>
        protected int mintIntTag;

        /// <summary> 
        /// �ַ��ͱ�ǩ(�ֶ�����:string,�ֶγ���:1000,�Ƿ�ɿ�:False)
        /// </summary>
        protected string mstrStrTag;

        /// <summary> 
        /// �Ƿ�������(�ֶ�����:bool,�ֶγ���:1,�Ƿ�ɿ�:False)
        /// </summary>
        protected bool mbolIsCheckProperty;

        //�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�
        private static string m_strConnectString;
        /// <summary>
        /// ��ǰ��ָ�������Ӵ�
        /// </summary>
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }
        private string m_strConnectString_Obj;
        /// <summary>
        /// ��ǰ����ָ�������Ӵ�
        /// </summary>
        public string ConnectString_Obj
        {
            get { return m_strConnectString_Obj; }
            set { m_strConnectString_Obj = value; }
        }

        /// <summary>
        /// ��ǰ��Ĺ��캯��
        /// </summary>
        public clsFKeys()
        {
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "FKeys";
            lstKeyFldNames.Add("Id");
        }

        /// <summary>
        /// ��ǰ��Ĺ��캯��
        /// </summary>
        /// <param name="lngId">����Id</param>
        public clsFKeys(long lngId)
        {
            if (lngId == 0)
            {
                throw new Exception("�ؼ��ֲ���Ϊ0��");
            }

            mlngId = lngId;
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "FKeys";
            lstKeyFldNames.Add("Id");
        }

        /// <summary>
        /// ��ǰ��Ĺ��캯��
        /// </summary>
        /// <param name="lngId">����Id</param>
        /// <param name="bolIsGetFKeys">�Ƿ��ȡ�ùؼ�����صļ�¼����</param>
        public clsFKeys(long lngId, bool bolIsGetFKeys)
        {
            if (lngId == 0)
            {
                throw new Exception("�ؼ��ֲ���Ϊ0��");
            }

            mlngId = lngId;
            SetInit();
            mbolIsCheckProperty = false;
            if (bolIsGetFKeys == true)
            {
                //GetFKeys();
            }
            _CurrTabName = "FKeys";
            lstKeyFldNames.Add("Id");
        }



        /// <summary>
        /// ��ǰ������Եĸ���
        /// </summary>
        public static int AttributeCount
        {
            get
            {
                return mintAttributeCount;
            }
        }
        /// <summary>
        /// �������Ե�����(�ַ�������)��ȡ�����Ե�ֵ
        /// </summary>
        /// <param name="strAttributeName">��������(�ַ���)</param>
        /// <returns>�����Ե�ֵ</returns>
        public object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == "Id")
                {
                    return mlngId;
                }
                else if (strAttributeName == "FKeyName")
                {
                    return mstrFKeyName;
                }
                else if (strAttributeName == "FKeyColumnID")
                {
                    return mstrFKeyColumnID;
                }
                else if (strAttributeName == "FKeyColumnName")
                {
                    return mstrFKeyColumnName;
                }
                else if (strAttributeName == "FKeyTabID")
                {
                    return mstrFKeyTabID;
                }
                else if (strAttributeName == "FKeyTabName")
                {
                    return mstrFKeyTabName;
                }
                else if (strAttributeName == "PKeyColumnID")
                {
                    return mstrPKeyColumnID;
                }
                else if (strAttributeName == "PKeyColumnName")
                {
                    return mstrPKeyColumnName;
                }
                else if (strAttributeName == "PKeyTabId")
                {
                    return mstrPKeyTabId;
                }
                else if (strAttributeName == "PKeyTabName")
                {
                    return mstrPKeyTabName;
                }
                else if (strAttributeName == "Update_Action")
                {
                    return mstrUpdate_Action;
                }
                else if (strAttributeName == "Delete_Action")
                {
                    return mintDelete_Action;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "Id")
                {
                    mlngId = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "FKeyName")
                {
                    mstrFKeyName = value.ToString();
                }
                else if (strAttributeName == "FKeyColumnID")
                {
                    mstrFKeyColumnID = value.ToString();
                }
                else if (strAttributeName == "FKeyColumnName")
                {
                    mstrFKeyColumnName = value.ToString();
                }
                else if (strAttributeName == "FKeyTabID")
                {
                    mstrFKeyTabID = value.ToString();
                }
                else if (strAttributeName == "FKeyTabName")
                {
                    mstrFKeyTabName = value.ToString();
                }
                else if (strAttributeName == "PKeyColumnID")
                {
                    mstrPKeyColumnID = value.ToString();
                }
                else if (strAttributeName == "PKeyColumnName")
                {
                    mstrPKeyColumnName = value.ToString();
                }
                else if (strAttributeName == "PKeyTabId")
                {
                    mstrPKeyTabId = value.ToString();
                }
                else if (strAttributeName == "PKeyTabName")
                {
                    mstrPKeyTabName = value.ToString();
                }
                else if (strAttributeName == "Update_Action")
                {
                    mstrUpdate_Action = value.ToString();
                }
                else if (strAttributeName == "Delete_Action")
                {
                    mintDelete_Action = TransNullToInt(value.ToString());
                }
            }
        }
        /// <summary>
        /// �������Ե����(����)��ȡ�����Ե�ֵ
        /// </summary>
        /// <param name="intIndex">�������(����)</param>
        /// <returns>�����Ե�ֵ</returns>
        public object this[int intIndex]
        {
            get
            {
                if ("Id" == AttributeName[intIndex])
                {
                    return mlngId;
                }
                else if ("FKeyName" == AttributeName[intIndex])
                {
                    return mstrFKeyName;
                }
                else if ("FKeyColumnID" == AttributeName[intIndex])
                {
                    return mstrFKeyColumnID;
                }
                else if ("FKeyColumnName" == AttributeName[intIndex])
                {
                    return mstrFKeyColumnName;
                }
                else if ("FKeyTabID" == AttributeName[intIndex])
                {
                    return mstrFKeyTabID;
                }
                else if ("FKeyTabName" == AttributeName[intIndex])
                {
                    return mstrFKeyTabName;
                }
                else if ("PKeyColumnID" == AttributeName[intIndex])
                {
                    return mstrPKeyColumnID;
                }
                else if ("PKeyColumnName" == AttributeName[intIndex])
                {
                    return mstrPKeyColumnName;
                }
                else if ("PKeyTabId" == AttributeName[intIndex])
                {
                    return mstrPKeyTabId;
                }
                else if ("PKeyTabName" == AttributeName[intIndex])
                {
                    return mstrPKeyTabName;
                }
                else if ("Update_Action" == AttributeName[intIndex])
                {
                    return mstrUpdate_Action;
                }
                else if ("Delete_Action" == AttributeName[intIndex])
                {
                    return mintDelete_Action;
                }
                return null;
            }
            set
            {
                if ("Id" == AttributeName[intIndex])
                {
                    mlngId = TransNullToInt(value.ToString());
                }
                else if ("FKeyName" == AttributeName[intIndex])
                {
                    mstrFKeyName = value.ToString();
                }
                else if ("FKeyColumnID" == AttributeName[intIndex])
                {
                    mstrFKeyColumnID = value.ToString();
                }
                else if ("FKeyColumnName" == AttributeName[intIndex])
                {
                    mstrFKeyColumnName = value.ToString();
                }
                else if ("FKeyTabID" == AttributeName[intIndex])
                {
                    mstrFKeyTabID = value.ToString();
                }
                else if ("FKeyTabName" == AttributeName[intIndex])
                {
                    mstrFKeyTabName = value.ToString();
                }
                else if ("PKeyColumnID" == AttributeName[intIndex])
                {
                    mstrPKeyColumnID = value.ToString();
                }
                else if ("PKeyColumnName" == AttributeName[intIndex])
                {
                    mstrPKeyColumnName = value.ToString();
                }
                else if ("PKeyTabId" == AttributeName[intIndex])
                {
                    mstrPKeyTabId = value.ToString();
                }
                else if ("PKeyTabName" == AttributeName[intIndex])
                {
                    mstrPKeyTabName = value.ToString();
                }
                else if ("Update_Action" == AttributeName[intIndex])
                {
                    mstrUpdate_Action = value.ToString();
                }
                else if ("Delete_Action" == AttributeName[intIndex])
                {
                    mintDelete_Action = TransNullToInt(value.ToString());
                }
            }
        }

        /// <summary>
        /// ����Id(˵��:;�ֶ�����:bigint;�ֶγ���:8;�Ƿ�ɿ�:False)
        /// </summary>
        public long Id
        {
            get
            {
                return mlngId;
            }
            set
            {
                mlngId = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("Id");
            }
        }
        /// <summary>
        /// �������(˵��:;�ֶ�����:varchar;�ֶγ���:128;�Ƿ�ɿ�:False)
        /// </summary>
        public string FKeyName
        {
            get
            {
                return mstrFKeyName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFKeyName = value;
                }
                else
                {
                    mstrFKeyName = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("FKeyName");
            }
        }
        /// <summary>
        /// �����Id(˵��:;�ֶ�����:varchar;�ֶγ���:128;�Ƿ�ɿ�:False)
        /// </summary>
        public string FKeyColumnID
        {
            get
            {
                return mstrFKeyColumnID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFKeyColumnID = value;
                }
                else
                {
                    mstrFKeyColumnID = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("FKeyColumnID");
            }
        }
        /// <summary>
        /// �������(˵��:;�ֶ�����:varchar;�ֶγ���:128;�Ƿ�ɿ�:False)
        /// </summary>
        public string FKeyColumnName
        {
            get
            {
                return mstrFKeyColumnName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFKeyColumnName = value;
                }
                else
                {
                    mstrFKeyColumnName = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("FKeyColumnName");
            }
        }
        /// <summary>
        /// �����ID(˵��:;�ֶ�����:varchar;�ֶγ���:128;�Ƿ�ɿ�:True)
        /// </summary>
        public string FKeyTabID
        {
            get
            {
                return mstrFKeyTabID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFKeyTabID = value;
                }
                else
                {
                    mstrFKeyTabID = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("FKeyTabID");
            }
        }
        /// <summary>
        /// ���������(˵��:;�ֶ�����:varchar;�ֶγ���:128;�Ƿ�ɿ�:False)
        /// </summary>
        public string FKeyTabName
        {
            get
            {
                return mstrFKeyTabName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFKeyTabName = value;
                }
                else
                {
                    mstrFKeyTabName = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("FKeyTabName");
            }
        }
        /// <summary>
        /// ������ID(˵��:;�ֶ�����:varchar;�ֶγ���:128;�Ƿ�ɿ�:False)
        /// </summary>
        public string PKeyColumnID
        {
            get
            {
                return mstrPKeyColumnID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPKeyColumnID = value;
                }
                else
                {
                    mstrPKeyColumnID = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("PKeyColumnID");
            }
        }
        /// <summary>
        /// ��������(˵��:;�ֶ�����:varchar;�ֶγ���:128;�Ƿ�ɿ�:False)
        /// </summary>
        public string PKeyColumnName
        {
            get
            {
                return mstrPKeyColumnName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPKeyColumnName = value;
                }
                else
                {
                    mstrPKeyColumnName = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("PKeyColumnName");
            }
        }
        /// <summary>
        /// ������Id(˵��:;�ֶ�����:varchar;�ֶγ���:128;�Ƿ�ɿ�:False)
        /// </summary>
        public string PKeyTabId
        {
            get
            {
                return mstrPKeyTabId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPKeyTabId = value;
                }
                else
                {
                    mstrPKeyTabId = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("PKeyTabId");
            }
        }
        /// <summary>
        /// ��������(˵��:;�ֶ�����:varchar;�ֶγ���:128;�Ƿ�ɿ�:False)
        /// </summary>
        public string PKeyTabName
        {
            get
            {
                return mstrPKeyTabName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPKeyTabName = value;
                }
                else
                {
                    mstrPKeyTabName = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("PKeyTabName");
            }
        }
        /// <summary>
        /// ��������(˵��:;�ֶ�����:varchar;�ֶγ���:128;�Ƿ�ɿ�:False)
        /// </summary>
        public string Update_Action
        {
            get
            {
                return mstrUpdate_Action;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrUpdate_Action = value;
                }
                else
                {
                    mstrUpdate_Action = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("Update_Action");
            }
        }
        /// <summary>
        /// ����ɾ��(˵��:;�ֶ�����:int;�ֶγ���:4;�Ƿ�ɿ�:False)
        /// </summary>
        public int Delete_Action
        {
            get
            {
                return mintDelete_Action;
            }
            set
            {
                mintDelete_Action = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("Delete_Action");
            }
        }
        /// <summary>
        /// ����Tag(˵��:;�ֶ�����:int;�ֶγ���:4;�Ƿ�ɿ�:False)
        /// </summary>
        public int IntTag
        {
            get
            {
                return mintIntTag;
            }
            set
            {
                mintIntTag = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("IntTag");
            }
        }
        /// <summary>
        /// �ַ��ͱ�ǩ(˵��:;�ֶ�����:string;�ֶγ���:1000;�Ƿ�ɿ�:False)
        /// </summary>
        public string StrTag
        {
            get
            {
                return mstrStrTag;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrStrTag = value;
                }
                else
                {
                    mstrStrTag = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("StrTag");
            }
        }
        /// <summary>
        /// �Ƿ�������(˵��:;�ֶ�����:bool;�ֶγ���:1;�Ƿ�ɿ�:False)
        /// </summary>
        public bool IsCheckProperty
        {
            get
            {
                return mbolIsCheckProperty;
            }
            set
            {
                mbolIsCheckProperty = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("IsCheckProperty");
            }
        }

        ///// <summary>
        ///// ��ȡSQL���������Ӷ���
        ///// </summary>
        ///// <returns>SQL���������Ӷ���</returns>
        //public static clsSpecSQLforSql GetSpecSQLObj()
        //{
        //    clsSpecSQLforSql objSQL = null;
        //    //1. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�
        //    if (clsSysPara.bolIsUseConnectStrName == true)
        //    {
        //        objSQL = new clsSpecSQLforSql(clsSysPara.strConnectStrName, true);
        //        return objSQL;
        //    }
        //    //2. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�
        //    //3. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�
        //    if (string.IsNullOrEmpty(clsFKeys.ConnectString) == true)
        //    {
        //        objSQL = new clsSpecSQLforSql();
        //    }
        //    else
        //    {
        //        objSQL = new clsSpecSQLforSql(clsFKeys.ConnectString);
        //    }
        //    return objSQL;
        //}


        public void CopyTo(clsFKeys objFKeys)
        {
            objFKeys.Id = mlngId; //����Id
            objFKeys.FKeyName = mstrFKeyName; //�������
            objFKeys.FKeyColumnID = mstrFKeyColumnID; //�����Id
            objFKeys.FKeyColumnName = mstrFKeyColumnName; //�������
            objFKeys.FKeyTabID = mstrFKeyTabID; //�����ID
            objFKeys.FKeyTabName = mstrFKeyTabName; //���������
            objFKeys.PKeyColumnID = mstrPKeyColumnID; //������ID
            objFKeys.PKeyColumnName = mstrPKeyColumnName; //��������
            objFKeys.PKeyTabId = mstrPKeyTabId; //������Id
            objFKeys.PKeyTabName = mstrPKeyTabName; //��������
            objFKeys.Update_Action = mstrUpdate_Action; //��������
            objFKeys.Delete_Action = mintDelete_Action; //����ɾ��
        }

        public void CopyTo(clsFKeys objFKeysS, clsFKeys objFKeysT)
        {
            objFKeysT.Id = objFKeysS.Id; //����Id
            objFKeysT.FKeyName = objFKeysS.FKeyName; //�������
            objFKeysT.FKeyColumnID = objFKeysS.FKeyColumnID; //�����Id
            objFKeysT.FKeyColumnName = objFKeysS.FKeyColumnName; //�������
            objFKeysT.FKeyTabID = objFKeysS.FKeyTabID; //�����ID
            objFKeysT.FKeyTabName = objFKeysS.FKeyTabName; //���������
            objFKeysT.PKeyColumnID = objFKeysS.PKeyColumnID; //������ID
            objFKeysT.PKeyColumnName = objFKeysS.PKeyColumnName; //��������
            objFKeysT.PKeyTabId = objFKeysS.PKeyTabId; //������Id
            objFKeysT.PKeyTabName = objFKeysS.PKeyTabName; //��������
            objFKeysT.Update_Action = objFKeysS.Update_Action; //��������
            objFKeysT.Delete_Action = objFKeysS.Delete_Action; //����ɾ��
        }


        /// <summary>
        /// ��DataRowת���ɼ�¼����.
        /// </summary>
        /// <param name="objRow">������DataRow</param>
        /// <returns>��¼����</returns>
        public clsFKeys GetFKeysObjByDataRow(DataRow objRow)
        {
            if (objRow == null)
            {
                return null;
            }
            clsFKeys objFKeys = new clsFKeys();
            objFKeys.Id = Int32.Parse(objRow["Id"].ToString().Trim()); //����Id
            objFKeys.FKeyName = objRow["FKeyName"].ToString().Trim(); //�������
            objFKeys.FKeyColumnID = objRow["FKeyColumnID"].ToString().Trim(); //�����Id
            objFKeys.FKeyColumnName = objRow["FKeyColumnName"].ToString().Trim(); //�������
            objFKeys.FKeyTabID = objRow["FKeyTabID"].ToString().Trim(); //�����ID
            objFKeys.FKeyTabName = objRow["FKeyTabName"].ToString().Trim(); //���������
            objFKeys.PKeyColumnID = objRow["PKeyColumnID"].ToString().Trim(); //������ID
            objFKeys.PKeyColumnName = objRow["PKeyColumnName"].ToString().Trim(); //��������
            objFKeys.PKeyTabId = objRow["PKeyTabId"].ToString().Trim(); //������Id
            objFKeys.PKeyTabName = objRow["PKeyTabName"].ToString().Trim(); //��������
            objFKeys.Update_Action = objRow["Update_Action"].ToString().Trim(); //��������
            objFKeys.Delete_Action = Int32.Parse(objRow["Delete_Action"].ToString().Trim()); //����ɾ��
            objFKeys.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ
            return objFKeys;
        }

   
        /// <summary>
        /// ��ȡ�������������м�¼�����б�,�ö����б����ʽ��ʾ
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>�������������м�¼�����б�</returns>
        public List<clsFKeys> GetFKeysObjList_List(string strCondition)
        {
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("�����������к���{0}�����飡", objException.Message));
            }
            List<clsFKeys> arrObjList = new List<clsFKeys>();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = null;// this.GetSpecSQLObj_Obj();
            strSQL = "Select * from FKeys where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsFKeys objFKeys = new clsFKeys();
                objFKeys.Id = Int32.Parse(objRow["Id"].ToString().Trim()); //����Id
                objFKeys.FKeyName = objRow["FKeyName"].ToString().Trim(); //�������
                objFKeys.FKeyColumnID = objRow["FKeyColumnID"].ToString().Trim(); //�����Id
                objFKeys.FKeyColumnName = objRow["FKeyColumnName"].ToString().Trim(); //�������
                objFKeys.FKeyTabID = objRow["FKeyTabID"].ToString().Trim(); //�����ID
                objFKeys.FKeyTabName = objRow["FKeyTabName"].ToString().Trim(); //���������
                objFKeys.PKeyColumnID = objRow["PKeyColumnID"].ToString().Trim(); //������ID
                objFKeys.PKeyColumnName = objRow["PKeyColumnName"].ToString().Trim(); //��������
                objFKeys.PKeyTabId = objRow["PKeyTabId"].ToString().Trim(); //������Id
                objFKeys.PKeyTabName = objRow["PKeyTabName"].ToString().Trim(); //��������
                objFKeys.Update_Action = objRow["Update_Action"].ToString().Trim(); //��������
                objFKeys.Delete_Action = Int32.Parse(objRow["Delete_Action"].ToString().Trim()); //����ɾ��
                objFKeys.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ
                arrObjList.Add(objFKeys);
            }
            objDT = null;
            return arrObjList;
        }

   
        /// <summary>
        /// ����ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.
        /// </summary>
        public void CheckPropertyNew()
        {
            if (Object.Equals(null, mstrFKeyName)
            || (!Object.Equals(null, mstrFKeyName) && mstrFKeyName.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[�������]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrFKeyColumnID)
            || (!Object.Equals(null, mstrFKeyColumnID) && mstrFKeyColumnID.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[�����Id]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrFKeyColumnName)
            || (!Object.Equals(null, mstrFKeyColumnName) && mstrFKeyColumnName.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[�������]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrFKeyTabName)
            || (!Object.Equals(null, mstrFKeyTabName) && mstrFKeyTabName.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[���������]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrPKeyColumnID)
            || (!Object.Equals(null, mstrPKeyColumnID) && mstrPKeyColumnID.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[������ID]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrPKeyColumnName)
            || (!Object.Equals(null, mstrPKeyColumnName) && mstrPKeyColumnName.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[��������]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrPKeyTabId)
            || (!Object.Equals(null, mstrPKeyTabId) && mstrPKeyTabId.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[������Id]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrPKeyTabName)
            || (!Object.Equals(null, mstrPKeyTabName) && mstrPKeyTabName.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[��������]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrUpdate_Action)
            || (!Object.Equals(null, mstrUpdate_Action) && mstrUpdate_Action.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[��������]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mintDelete_Action)
            || (!Object.Equals(null, mintDelete_Action) && mintDelete_Action.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[����ɾ��]����Ϊ��(NULL)!");
            }
            if (!Object.Equals(null, mstrFKeyName) && getStrLen(mstrFKeyName) > 128)
            {
                throw new clsDbObjException("�ֶ�[�������]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrFKeyColumnID) && getStrLen(mstrFKeyColumnID) > 128)
            {
                throw new clsDbObjException("�ֶ�[�����Id]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrFKeyColumnName) && getStrLen(mstrFKeyColumnName) > 128)
            {
                throw new clsDbObjException("�ֶ�[�������]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrFKeyTabID) && getStrLen(mstrFKeyTabID) > 128)
            {
                throw new clsDbObjException("�ֶ�[�����ID]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrFKeyTabName) && getStrLen(mstrFKeyTabName) > 128)
            {
                throw new clsDbObjException("�ֶ�[���������]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrPKeyColumnID) && getStrLen(mstrPKeyColumnID) > 128)
            {
                throw new clsDbObjException("�ֶ�[������ID]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrPKeyColumnName) && getStrLen(mstrPKeyColumnName) > 128)
            {
                throw new clsDbObjException("�ֶ�[��������]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrPKeyTabId) && getStrLen(mstrPKeyTabId) > 128)
            {
                throw new clsDbObjException("�ֶ�[������Id]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrPKeyTabName) && getStrLen(mstrPKeyTabName) > 128)
            {
                throw new clsDbObjException("�ֶ�[��������]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrUpdate_Action) && getStrLen(mstrUpdate_Action) > 128)
            {
                throw new clsDbObjException("�ֶ�[��������]�ĳ��Ȳ��ܳ���128!");
            }
            mbolIsCheckProperty = true;
        }
        /// <summary>
        /// רҵ����޸ĵļ���ֶ�ֵ�Ƿ�Ϸ�,1)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.
        /// </summary>
        public void CheckProperty4Update()
        {
            if (!Object.Equals(null, mstrFKeyName) && getStrLen(mstrFKeyName) > 128)
            {
                throw new clsDbObjException("�ֶ�[�������]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrFKeyColumnID) && getStrLen(mstrFKeyColumnID) > 128)
            {
                throw new clsDbObjException("�ֶ�[�����Id]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrFKeyColumnName) && getStrLen(mstrFKeyColumnName) > 128)
            {
                throw new clsDbObjException("�ֶ�[�������]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrFKeyTabID) && getStrLen(mstrFKeyTabID) > 128)
            {
                throw new clsDbObjException("�ֶ�[�����ID]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrFKeyTabName) && getStrLen(mstrFKeyTabName) > 128)
            {
                throw new clsDbObjException("�ֶ�[���������]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrPKeyColumnID) && getStrLen(mstrPKeyColumnID) > 128)
            {
                throw new clsDbObjException("�ֶ�[������ID]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrPKeyColumnName) && getStrLen(mstrPKeyColumnName) > 128)
            {
                throw new clsDbObjException("�ֶ�[��������]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrPKeyTabId) && getStrLen(mstrPKeyTabId) > 128)
            {
                throw new clsDbObjException("�ֶ�[������Id]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrPKeyTabName) && getStrLen(mstrPKeyTabName) > 128)
            {
                throw new clsDbObjException("�ֶ�[��������]�ĳ��Ȳ��ܳ���128!");
            }
            if (!Object.Equals(null, mstrUpdate_Action) && getStrLen(mstrUpdate_Action) > 128)
            {
                throw new clsDbObjException("�ֶ�[��������]�ĳ��Ȳ��ܳ���128!");
            }
            mbolIsCheckProperty = true;
        }



    }
}
