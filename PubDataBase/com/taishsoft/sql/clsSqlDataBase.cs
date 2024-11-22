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
    /// 
    /// </summary>
    public class clsSqlDataBase : clsGeneralTab
    {
        public const string CurrTabName_S = "PrjDataBase";    //��ǰ�������������صı���
        public const string CurrTabKeyFldName_S = "PrjDataBaseId";    //��ǰ���еĹؼ������ƣ��������صı��йؼ�����
        protected const int mintAttributeCount = 13;
        public static string[] AttributeName = new string[] { "PrjDataBaseId", "PrjDataBaseName", "DataBaseName", "DatabaseOwner", "DataBasePwd", "DataBaseTypeId", "DataBaseUserId", "IpAddress", "SID", "TableSpace", "UserId", "UpdDate", "Memo" };
        //���������Ա���

        protected string mstrPrjDataBaseId;    //��Ŀ���ݿ�Id
        protected string mstrPrjDataBaseName;    //��Ŀ���ݿ���
        protected string mstrDataBaseName;    //���ݿ���
        protected string mstrDatabaseOwner;    //���ݿ�ӵ����
        protected string mstrDataBasePwd;    //���ݿ���û�����
        protected string mstrDataBaseTypeId;    //���ݿ�����ID
        protected string mstrDataBaseUserId;    //���ݿ���û�ID
        protected string mstrIpAddress;    //������
        protected string mstrSID;    //SID
        protected string mstrTableSpace;    //��ռ�
        protected string mstrUserId;    //�û�ID
        protected string mstrUpdDate;    //�޸�����
        protected string mstrMemo;    //��ע

        //�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�
        private static string m_strConnectString;
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }

        public clsSqlDataBase()
        {
            SetInit();
            _CurrTabName = "PrjDataBase";
            KeyFldName = "PrjDataBaseId";
        }

        public clsSqlDataBase(string strPrjDataBaseId)
        {

            mstrPrjDataBaseId = strPrjDataBaseId;
            SetInit();
            _CurrTabName = "PrjDataBase";
            KeyFldName = "PrjDataBaseId";
        }

        public clsSqlDataBase(string strPrjDataBaseId, bool bolIsGetPrjDataBase)
        {

            mstrPrjDataBaseId = strPrjDataBaseId;
            SetInit();
            if (bolIsGetPrjDataBase == true)
            {
                GetPrjDataBase();
            }
            _CurrTabName = "PrjDataBase";
            KeyFldName = "PrjDataBaseId";
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
                if (strAttributeName == "PrjDataBaseId")
                {
                    return mstrPrjDataBaseId;
                }
                else if (strAttributeName == "PrjDataBaseName")
                {
                    return mstrPrjDataBaseName;
                }
                else if (strAttributeName == "DataBaseName")
                {
                    return mstrDataBaseName;
                }
                else if (strAttributeName == "DatabaseOwner")
                {
                    return mstrDatabaseOwner;
                }
                else if (strAttributeName == "DataBasePwd")
                {
                    return mstrDataBasePwd;
                }
                else if (strAttributeName == "DataBaseTypeId")
                {
                    return mstrDataBaseTypeId;
                }
                else if (strAttributeName == "DataBaseUserId")
                {
                    return mstrDataBaseUserId;
                }
                else if (strAttributeName == "IpAddress")
                {
                    return mstrIpAddress;
                }
                else if (strAttributeName == "SID")
                {
                    return mstrSID;
                }
                else if (strAttributeName == "TableSpace")
                {
                    return mstrTableSpace;
                }
                else if (strAttributeName == "UserId")
                {
                    return mstrUserId;
                }
                else if (strAttributeName == "UpdDate")
                {
                    return mstrUpdDate;
                }
                else if (strAttributeName == "Memo")
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "PrjDataBaseId")
                {
                    mstrPrjDataBaseId = value.ToString();
                }
                else if (strAttributeName == "PrjDataBaseName")
                {
                    mstrPrjDataBaseName = value.ToString();
                }
                else if (strAttributeName == "DataBaseName")
                {
                    mstrDataBaseName = value.ToString();
                }
                else if (strAttributeName == "DatabaseOwner")
                {
                    mstrDatabaseOwner = value.ToString();
                }
                else if (strAttributeName == "DataBasePwd")
                {
                    mstrDataBasePwd = value.ToString();
                }
                else if (strAttributeName == "DataBaseTypeId")
                {
                    mstrDataBaseTypeId = value.ToString();
                }
                else if (strAttributeName == "DataBaseUserId")
                {
                    mstrDataBaseUserId = value.ToString();
                }
                else if (strAttributeName == "IpAddress")
                {
                    mstrIpAddress = value.ToString();
                }
                else if (strAttributeName == "SID")
                {
                    mstrSID = value.ToString();
                }
                else if (strAttributeName == "TableSpace")
                {
                    mstrTableSpace = value.ToString();
                }
                else if (strAttributeName == "UserId")
                {
                    mstrUserId = value.ToString();
                }
                else if (strAttributeName == "UpdDate")
                {
                    mstrUpdDate = value.ToString();
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
                if ("PrjDataBaseId" == AttributeName[intIndex])
                {
                    return mstrPrjDataBaseId;
                }
                else if ("PrjDataBaseName" == AttributeName[intIndex])
                {
                    return mstrPrjDataBaseName;
                }
                else if ("DataBaseName" == AttributeName[intIndex])
                {
                    return mstrDataBaseName;
                }
                else if ("DatabaseOwner" == AttributeName[intIndex])
                {
                    return mstrDatabaseOwner;
                }
                else if ("DataBasePwd" == AttributeName[intIndex])
                {
                    return mstrDataBasePwd;
                }
                else if ("DataBaseTypeId" == AttributeName[intIndex])
                {
                    return mstrDataBaseTypeId;
                }
                else if ("DataBaseUserId" == AttributeName[intIndex])
                {
                    return mstrDataBaseUserId;
                }
                else if ("IpAddress" == AttributeName[intIndex])
                {
                    return mstrIpAddress;
                }
                else if ("SID" == AttributeName[intIndex])
                {
                    return mstrSID;
                }
                else if ("TableSpace" == AttributeName[intIndex])
                {
                    return mstrTableSpace;
                }
                else if ("UserId" == AttributeName[intIndex])
                {
                    return mstrUserId;
                }
                else if ("UpdDate" == AttributeName[intIndex])
                {
                    return mstrUpdDate;
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if ("PrjDataBaseId" == AttributeName[intIndex])
                {
                    mstrPrjDataBaseId = value.ToString();
                }
                else if ("PrjDataBaseName" == AttributeName[intIndex])
                {
                    mstrPrjDataBaseName = value.ToString();
                }
                else if ("DataBaseName" == AttributeName[intIndex])
                {
                    mstrDataBaseName = value.ToString();
                }
                else if ("DatabaseOwner" == AttributeName[intIndex])
                {
                    mstrDatabaseOwner = value.ToString();
                }
                else if ("DataBasePwd" == AttributeName[intIndex])
                {
                    mstrDataBasePwd = value.ToString();
                }
                else if ("DataBaseTypeId" == AttributeName[intIndex])
                {
                    mstrDataBaseTypeId = value.ToString();
                }
                else if ("DataBaseUserId" == AttributeName[intIndex])
                {
                    mstrDataBaseUserId = value.ToString();
                }
                else if ("IpAddress" == AttributeName[intIndex])
                {
                    mstrIpAddress = value.ToString();
                }
                else if ("SID" == AttributeName[intIndex])
                {
                    mstrSID = value.ToString();
                }
                else if ("TableSpace" == AttributeName[intIndex])
                {
                    mstrTableSpace = value.ToString();
                }
                else if ("UserId" == AttributeName[intIndex])
                {
                    mstrUserId = value.ToString();
                }
                else if ("UpdDate" == AttributeName[intIndex])
                {
                    mstrUpdDate = value.ToString();
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    mstrMemo = value.ToString();
                }
            }
        }

        /// <summary>
        /// ��Ŀ���ݿ�Id
        /// </summary>
        public string PrjDataBaseId
        {
            get
            {
                return mstrPrjDataBaseId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPrjDataBaseId = value;
                }
                else
                {
                    mstrPrjDataBaseId = value;
                }
            }
        }
        /// <summary>
        /// ��Ŀ���ݿ���
        /// </summary>
        public string PrjDataBaseName
        {
            get
            {
                return mstrPrjDataBaseName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPrjDataBaseName = value;
                }
                else
                {
                    mstrPrjDataBaseName = value;
                }
            }
        }
        /// <summary>
        /// ���ݿ���
        /// </summary>
        public string DataBaseName
        {
            get
            {
                return mstrDataBaseName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDataBaseName = value;
                }
                else
                {
                    mstrDataBaseName = value;
                }
            }
        }
        /// <summary>
        /// ���ݿ�ӵ����
        /// </summary>
        public string DatabaseOwner
        {
            get
            {
                return mstrDatabaseOwner;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDatabaseOwner = value;
                }
                else
                {
                    mstrDatabaseOwner = value;
                }
            }
        }
        /// <summary>
        /// ���ݿ���û�����
        /// </summary>
        public string DataBasePwd
        {
            get
            {
                return mstrDataBasePwd;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDataBasePwd = value;
                }
                else
                {
                    mstrDataBasePwd = value;
                }
            }
        }
        /// <summary>
        /// ���ݿ�����ID
        /// </summary>
        public string DataBaseTypeId
        {
            get
            {
                return mstrDataBaseTypeId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDataBaseTypeId = value;
                }
                else
                {
                    mstrDataBaseTypeId = value;
                }
            }
        }
        /// <summary>
        /// ���ݿ���û�ID
        /// </summary>
        public string DataBaseUserId
        {
            get
            {
                return mstrDataBaseUserId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDataBaseUserId = value;
                }
                else
                {
                    mstrDataBaseUserId = value;
                }
            }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string IpAddress
        {
            get
            {
                return mstrIpAddress;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrIpAddress = value;
                }
                else
                {
                    mstrIpAddress = value;
                }
            }
        }
        /// <summary>
        /// SID
        /// </summary>
        public string SID
        {
            get
            {
                return mstrSID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSID = value;
                }
                else
                {
                    mstrSID = value;
                }
            }
        }
        /// <summary>
        /// ��ռ�
        /// </summary>
        public string TableSpace
        {
            get
            {
                return mstrTableSpace;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTableSpace = value;
                }
                else
                {
                    mstrTableSpace = value;
                }
            }
        }
        /// <summary>
        /// �û�ID
        /// </summary>
        public string UserId
        {
            get
            {
                return mstrUserId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrUserId = value;
                }
                else
                {
                    mstrUserId = value;
                }
            }
        }
        /// <summary>
        /// �޸�����
        /// </summary>
        public string UpdDate
        {
            get
            {
                return mstrUpdDate;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrUpdDate = value;
                }
                else
                {
                    mstrUpdDate = value;
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
            }
        }

        /// <summary>
        /// ����¼�¼
        /// </summary>
        /// <returns>����Ƿ�ɹ�?</returns>
        public override bool AddNewRecord()
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow;
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            strSQL = "Select * from PrjDataBase where 1=2";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "PrjDataBase");
            objRow = objDS.Tables["PrjDataBase"].NewRow();
            objRow["PrjDataBaseId"] = mstrPrjDataBaseId;    //��Ŀ���ݿ�Id
            if (mstrPrjDataBaseName != "")
            {
                objRow["PrjDataBaseName"] = mstrPrjDataBaseName;   //��Ŀ���ݿ���
            }
            if (mstrDataBaseName != "")
            {
                objRow["DataBaseName"] = mstrDataBaseName;   //���ݿ���
            }
            if (mstrDatabaseOwner != "")
            {
                objRow["DatabaseOwner"] = mstrDatabaseOwner;   //���ݿ�ӵ����
            }
            if (mstrDataBasePwd != "")
            {
                objRow["DataBasePwd"] = mstrDataBasePwd;   //���ݿ���û�����
            }
            if (mstrDataBaseTypeId != "")
            {
                objRow["DataBaseTypeId"] = mstrDataBaseTypeId;   //���ݿ�����ID
            }
            if (mstrDataBaseUserId != "")
            {
                objRow["DataBaseUserId"] = mstrDataBaseUserId;   //���ݿ���û�ID
            }
            if (mstrIpAddress != "")
            {
                objRow["IpAddress"] = mstrIpAddress;   //������
            }
            if (mstrSID != "")
            {
                objRow["SID"] = mstrSID;   //SID
            }
            if (mstrTableSpace != "")
            {
                objRow["TableSpace"] = mstrTableSpace;   //��ռ�
            }
            if (mstrUserId != "")
            {
                objRow["UserId"] = mstrUserId;   //�û�ID
            }
            if (mstrUpdDate != "")
            {
                objRow["UpdDate"] = mstrUpdDate;   //�޸�����
            }
            if (mstrMemo != "")
            {
                objRow["Memo"] = mstrMemo;   //��ע
            }
            objDS.Tables["PrjDataBase"].Rows.Add(objRow);
            try
            {
                objDA.Update(objDS, "PrjDataBase");
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                objDA = null;
                objDS = null;
                objCB = null;
                objRow = null;
            }
            return true;
        }



        /// <summary>
        /// ���ܣ�ͨ��SQL�����������¼
        ///       ��Ҫ�����ϴ��ļ�ʱ��
        /// </summary>
        /// <returns>�������ɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool AddNewRecordBySQL()
        {
            StringBuilder strSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            strSQL.AppendFormat("insert into PrjDataBase (PrjDataBaseId, PrjDataBaseName, DataBaseName, DatabaseOwner, DataBasePwd, DataBaseTypeId, DataBaseUserId, IpAddress, SID, TableSpace, UserId, UpdDate, Memo) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')", mstrPrjDataBaseId, mstrPrjDataBaseName, mstrDataBaseName, mstrDatabaseOwner, mstrDataBasePwd, mstrDataBaseTypeId, mstrDataBaseUserId, mstrIpAddress, mstrSID, mstrTableSpace, mstrUserId, mstrUpdDate, mstrMemo);
            return objSQL.ExecSql(strSQL.ToString());
        }


        public bool AddnewPrjDataBaseBySP()
        {
            //ͨ���洢������
            //ֱ��ʹ��
            if (mintErrNo != 0)
            {
                //MsgBox(mstrErrMsg(mintErrNo))
                return false;
            }
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            objSQL.SPConfigXMLFile = "..\\XML\\XMLSP.xml";
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mstrPrjDataBaseId);
            values.Add(mstrPrjDataBaseName);
            values.Add(mstrDataBaseName);
            values.Add(mstrDatabaseOwner);
            values.Add(mstrDataBasePwd);
            values.Add(mstrDataBaseTypeId);
            values.Add(mstrDataBaseUserId);
            values.Add(mstrIpAddress);
            values.Add(mstrSID);
            values.Add(mstrTableSpace);
            values.Add(mstrUserId);
            values.Add(mstrUpdDate);
            values.Add(mstrMemo);
            objSQL.ExecSP("AddnewPrjDataBase", values);
            return true;
        }

        /// <summary>
        /// �Ѷ�����¼ͬʱ���뵽����!
        /// </summary>
        /// <param name="oDT"></param>
        /// <param name="strResult"></param>
        /// <returns></returns>
        public bool AddnewPrjDataBases(System.Data.DataTable oDT, ref string strResult)
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow;
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            if (mintErrNo != 0)
            {
                strResult = "�����Ϊ��" + mintErrNo.ToString();
                return false;
            }
            strSQL = "Select * from PrjDataBase where PrjDataBaseId='111'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "PrjDataBase");
            //���ؼ��ֵ�Ψһ��
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                string strPrjDataBaseId = oRow["PrjDataBaseId"].ToString().Trim();
                if (IsExist(strPrjDataBaseId))
                {
                    strResult = "�ؼ���PrjDataBaseIdΪ��" + strPrjDataBaseId + "�ļ�¼�Ѵ��ڣ������ظ�����!";
                    return false;
                }
            }
            //�Ѷ�����¼���뵽����
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                objRow = objDS.Tables["PrjDataBase"].NewRow();
                objRow["PrjDataBaseId"] = oRow["PrjDataBaseId"].ToString().Trim();    //��Ŀ���ݿ�Id
                objRow["PrjDataBaseName"] = oRow["PrjDataBaseName"].ToString().Trim();    //��Ŀ���ݿ���
                objRow["DataBaseName"] = oRow["DataBaseName"].ToString().Trim();    //���ݿ���
                objRow["DatabaseOwner"] = oRow["DatabaseOwner"].ToString().Trim();    //���ݿ�ӵ����
                objRow["DataBasePwd"] = oRow["DataBasePwd"].ToString().Trim();    //���ݿ���û�����
                objRow["DataBaseTypeId"] = oRow["DataBaseTypeId"].ToString().Trim();    //���ݿ�����ID
                objRow["DataBaseUserId"] = oRow["DataBaseUserId"].ToString().Trim();    //���ݿ���û�ID
                objRow["IpAddress"] = oRow["IpAddress"].ToString().Trim();    //������
                objRow["SID"] = oRow["SID"].ToString().Trim();    //SID
                objRow["TableSpace"] = oRow["TableSpace"].ToString().Trim();    //��ռ�
                objRow["UserId"] = oRow["UserId"].ToString().Trim();    //�û�ID
                objRow["UpdDate"] = oRow["UpdDate"].ToString().Trim();    //�޸�����
                objRow["Memo"] = oRow["Memo"].ToString().Trim();    //��ע
                objDS.Tables["PrjDataBase"].Rows.Add(objRow);
            }
            try
            {
                objDA.Update(objDS, "PrjDataBase");
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                objDA = null;
                objDS = null;
                objCB = null;
                objRow = null;
                objSQL.SQLConnect.Close();
                objSQL = null;
            }
            return true;
        }

        public override bool Update()
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow;
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            strSQL = "Select * from PrjDataBase where PrjDataBaseId=" + "'" + mstrPrjDataBaseId + "'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "PrjDataBase");
            if (objDS.Tables["PrjDataBase"].Rows.Count == 0)
            {
                //MsgBox("û����Ӧ��ID�ţ�PrjDataBaseId=" + "'"+ mstrPrjDataBaseId+"'");
                return false;
            }
            objRow = objDS.Tables["PrjDataBase"].Rows[0];
            if (mstrPrjDataBaseName != "")
            {
                objRow["PrjDataBaseName"] = mstrPrjDataBaseName;    //��Ŀ���ݿ���
            }
            if (mstrDataBaseName != "")
            {
                objRow["DataBaseName"] = mstrDataBaseName;    //���ݿ���
            }
            if (mstrDatabaseOwner != "")
            {
                objRow["DatabaseOwner"] = mstrDatabaseOwner;    //���ݿ�ӵ����
            }
            if (mstrDataBasePwd != "")
            {
                objRow["DataBasePwd"] = mstrDataBasePwd;    //���ݿ���û�����
            }
            if (mstrDataBaseTypeId != "")
            {
                objRow["DataBaseTypeId"] = mstrDataBaseTypeId;    //���ݿ�����ID
            }
            if (mstrDataBaseUserId != "")
            {
                objRow["DataBaseUserId"] = mstrDataBaseUserId;    //���ݿ���û�ID
            }
            if (mstrIpAddress != "")
            {
                objRow["IpAddress"] = mstrIpAddress;    //������
            }
            if (mstrSID != "")
            {
                objRow["SID"] = mstrSID;    //SID
            }
            if (mstrTableSpace != "")
            {
                objRow["TableSpace"] = mstrTableSpace;    //��ռ�
            }
            if (mstrUserId != "")
            {
                objRow["UserId"] = mstrUserId;    //�û�ID
            }
            if (mstrUpdDate != "")
            {
                objRow["UpdDate"] = mstrUpdDate;    //�޸�����
            }
            if (mstrMemo != "")
            {
                objRow["Memo"] = mstrMemo;    //��ע
            }
            try
            {
                objDA.Update(objDS, "PrjDataBase");
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                objDA = null;
                objDS = null;
                objCB = null;
                objRow = null;
            }
            return true;
        }


        public bool UpdateBySql()
        {
            StringBuilder sbSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            sbSQL.AppendFormat("Update PrjDataBase Set ");
            sbSQL.AppendFormat("PrjDataBaseName = '{0}'", mstrPrjDataBaseName);       //��Ŀ���ݿ���
            sbSQL.AppendFormat(", DataBaseName = '{0}'", mstrDataBaseName);       //���ݿ���
            sbSQL.AppendFormat(", DatabaseOwner = '{0}'", mstrDatabaseOwner);       //���ݿ�ӵ����
            sbSQL.AppendFormat(", DataBasePwd = '{0}'", mstrDataBasePwd);       //���ݿ���û�����
            sbSQL.AppendFormat(", DataBaseTypeId = '{0}'", mstrDataBaseTypeId);       //���ݿ�����ID
            sbSQL.AppendFormat(", DataBaseUserId = '{0}'", mstrDataBaseUserId);       //���ݿ���û�ID
            sbSQL.AppendFormat(", IpAddress = '{0}'", mstrIpAddress);       //������
            sbSQL.AppendFormat(", SID = '{0}'", mstrSID);       //SID
            sbSQL.AppendFormat(", TableSpace = '{0}'", mstrTableSpace);       //��ռ�
            sbSQL.AppendFormat(", UserId = '{0}'", mstrUserId);       //�û�ID
            sbSQL.AppendFormat(", UpdDate = '{0}'", mstrUpdDate);       //�޸�����
            sbSQL.AppendFormat(", Memo = '{0}'", mstrMemo);       //��ע
            sbSQL.AppendFormat("Where PrjDataBaseId = '{0}'", mstrPrjDataBaseId);
            try
            {
                return objSQL.ExecSql(sbSQL.ToString());
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
        }



        /// <summary>
        /// ���ܣ��޸Ķ�����¼
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public override int UpdateMultiRec(string strCondition)
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            //			System.Data.DataRow objRow ;
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            int intRecCount;
            if (strCondition == "")
            {
                return 0;   //��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
            }
            strSQL = "Select * from PrjDataBase where " + strCondition;
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "PrjDataBase");
            if (objDS.Tables["PrjDataBase"].Rows.Count == 0)
            {
                return 0;
            }
            intRecCount = objDS.Tables["PrjDataBase"].Rows.Count;
            foreach (System.Data.DataRow objRow in objDS.Tables["PrjDataBase"].Rows)
            {
                objRow["PrjDataBaseName"] = mstrPrjDataBaseName;    //��Ŀ���ݿ���
                objRow["DataBaseName"] = mstrDataBaseName;    //���ݿ���
                objRow["DatabaseOwner"] = mstrDatabaseOwner;    //���ݿ�ӵ����
                objRow["DataBasePwd"] = mstrDataBasePwd;    //���ݿ���û�����
                objRow["DataBaseTypeId"] = mstrDataBaseTypeId;    //���ݿ�����ID
                objRow["DataBaseUserId"] = mstrDataBaseUserId;    //���ݿ���û�ID
                objRow["IpAddress"] = mstrIpAddress;    //������
                objRow["SID"] = mstrSID;    //SID
                objRow["TableSpace"] = mstrTableSpace;    //��ռ�
                objRow["UserId"] = mstrUserId;    //�û�ID
                objRow["UpdDate"] = mstrUpdDate;    //�޸�����
                objRow["Memo"] = mstrMemo;    //��ע
            }
            try
            {
                objDA.Update(objDS, "PrjDataBase");
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                objDA = null;
                objDS = null;
                objCB = null;
            }
            return intRecCount;
        }


        public override bool DelRecord()
        {
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            //ɾ��PrjDataBase�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from PrjDataBase where PrjDataBaseId=" + "'" + mstrPrjDataBaseId + "'";
            return objSQL.ExecSql(strSQL);
        }


        //ͬʱɾ��������¼
        public static bool DelPrjDataBase(ArrayList lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
                else strKeyList += "," + "'" + lstKey[i].ToString() + "'";
            }
            strSQL = "";
            //ɾ��PrjDataBase�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from PrjDataBase where PrjDataBaseId in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }

        public static bool DelRecord(string strPrjDataBaseId)
        {
            //ɾ��������¼
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            //ɾ��PrjDataBase�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from PrjDataBase where PrjDataBaseId=" + "'" + strPrjDataBaseId + "'";
            return objSQL.ExecSql(strSQL);
        }


        /// <summary>
        /// ���ܣ�ɾ��������¼����������ɾ��
        /// </summary>
        /// <param name="strCondition">��Ҫɾ���ļ�¼����</param>
        /// <returns>����ɾ���ļ�¼0��</returns>
        public static int DelPrjDataBase(string strCondition)
        {
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            string strSQL;
            if (strCondition == "")
            {
                return 0;	//��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
            }
            else
            {
                strSQL = "Delete from PrjDataBase where " + strCondition;
            }
            int intRecoCount = objSQL.ExecSql2(strSQL);
            return intRecoCount;
        }


        public bool GetPrjDataBase()
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            strSQL = "Select * from PrjDataBase where PrjDataBaseId=" + "'" + mstrPrjDataBaseId + "'";
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            mstrPrjDataBaseId = objDT.Rows[0]["PrjDataBaseId"].ToString().Trim();       //��Ŀ���ݿ�Id
            mstrPrjDataBaseName = objDT.Rows[0]["PrjDataBaseName"].ToString().Trim();       //��Ŀ���ݿ���
            mstrDataBaseName = objDT.Rows[0]["DataBaseName"].ToString().Trim();       //���ݿ���
            mstrDatabaseOwner = objDT.Rows[0]["DatabaseOwner"].ToString().Trim();       //���ݿ�ӵ����
            mstrDataBasePwd = objDT.Rows[0]["DataBasePwd"].ToString().Trim();       //���ݿ���û�����
            mstrDataBaseTypeId = objDT.Rows[0]["DataBaseTypeId"].ToString().Trim();       //���ݿ�����ID
            mstrDataBaseUserId = objDT.Rows[0]["DataBaseUserId"].ToString().Trim();       //���ݿ���û�ID
            mstrIpAddress = objDT.Rows[0]["IpAddress"].ToString().Trim();       //������
            mstrSID = objDT.Rows[0]["SID"].ToString().Trim();       //SID
            mstrTableSpace = objDT.Rows[0]["TableSpace"].ToString().Trim();       //��ռ�
            mstrUserId = objDT.Rows[0]["UserId"].ToString().Trim();       //�û�ID
            mstrUpdDate = objDT.Rows[0]["UpdDate"].ToString().Trim();       //�޸�����
            mstrMemo = objDT.Rows[0]["Memo"].ToString().Trim();       //��ע
            objDT = null;
            return true;
        }

        public static System.Data.DataTable GetPrjDataBase(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            strSQL = "Select * from PrjDataBase where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        public ArrayList GetPrjDataBaseObjList(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            strSQL = "Select * from PrjDataBase where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsSqlDataBase objPrjDataBase = new clsSqlDataBase();
                objPrjDataBase.PrjDataBaseId = objRow["PrjDataBaseId"].ToString().Trim();     //��Ŀ���ݿ�Id
                objPrjDataBase.PrjDataBaseName = objRow["PrjDataBaseName"].ToString().Trim();     //��Ŀ���ݿ���
                objPrjDataBase.DataBaseName = objRow["DataBaseName"].ToString().Trim();     //���ݿ���
                objPrjDataBase.DatabaseOwner = objRow["DatabaseOwner"].ToString().Trim();     //���ݿ�ӵ����
                objPrjDataBase.DataBasePwd = objRow["DataBasePwd"].ToString().Trim();     //���ݿ���û�����
                objPrjDataBase.DataBaseTypeId = objRow["DataBaseTypeId"].ToString().Trim();     //���ݿ�����ID
                objPrjDataBase.DataBaseUserId = objRow["DataBaseUserId"].ToString().Trim();     //���ݿ���û�ID
                objPrjDataBase.IpAddress = objRow["IpAddress"].ToString().Trim();     //������
                objPrjDataBase.SID = objRow["SID"].ToString().Trim();     //SID
                objPrjDataBase.TableSpace = objRow["TableSpace"].ToString().Trim();     //��ռ�
                objPrjDataBase.UserId = objRow["UserId"].ToString().Trim();     //�û�ID
                objPrjDataBase.UpdDate = objRow["UpdDate"].ToString().Trim();     //�޸�����
                objPrjDataBase.Memo = objRow["Memo"].ToString().Trim();     //��ע
                arrObjList.Add(objPrjDataBase);
            }
            objDT = null;
            return arrObjList;
        }

        public clsSqlDataBase GetFirstPrjDataBase(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            strSQL = "Select * from PrjDataBase where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            DataRow objRow = objDT.Rows[0];
            clsSqlDataBase objPrjDataBase = new clsSqlDataBase();
            objPrjDataBase.PrjDataBaseId = objRow["PrjDataBaseId"].ToString().Trim();     //��Ŀ���ݿ�Id
            objPrjDataBase.PrjDataBaseName = objRow["PrjDataBaseName"].ToString().Trim();     //��Ŀ���ݿ���
            objPrjDataBase.DataBaseName = objRow["DataBaseName"].ToString().Trim();     //���ݿ���
            objPrjDataBase.DatabaseOwner = objRow["DatabaseOwner"].ToString().Trim();     //���ݿ�ӵ����
            objPrjDataBase.DataBasePwd = objRow["DataBasePwd"].ToString().Trim();     //���ݿ���û�����
            objPrjDataBase.DataBaseTypeId = objRow["DataBaseTypeId"].ToString().Trim();     //���ݿ�����ID
            objPrjDataBase.DataBaseUserId = objRow["DataBaseUserId"].ToString().Trim();     //���ݿ���û�ID
            objPrjDataBase.IpAddress = objRow["IpAddress"].ToString().Trim();     //������
            objPrjDataBase.SID = objRow["SID"].ToString().Trim();     //SID
            objPrjDataBase.TableSpace = objRow["TableSpace"].ToString().Trim();     //��ռ�
            objPrjDataBase.UserId = objRow["UserId"].ToString().Trim();     //�û�ID
            objPrjDataBase.UpdDate = objRow["UpdDate"].ToString().Trim();     //�޸�����
            objPrjDataBase.Memo = objRow["Memo"].ToString().Trim();     //��ע
            objDT = null;
            return objPrjDataBase;
        }


        /// <summary>
        /// ���ܣ���ȡĳһ������DataTable�����еĴ���ת������Ӧ������
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>�����Ѿ�ת�������DataTable</returns>
        public static System.Data.DataTable GetPrjDataBaseT(string strCondition)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            strSQL.Append("Select PrjDataBase.* ");
            strSQL.Append(", Users.UserName UsersUserName ");
            strSQL.Append(" from PrjDataBase ");
            strSQL.Append(" left JOIN Users on PrjDataBase.UserId = Users.UserId ");
            strSQL.Append(" where " + strCondition);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }



        /// <summary>
        /// ���ܣ���ȡĳһ��������ر���ͼ(View)
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>�����Ѿ�ת�������DataTable</returns>
        public static System.Data.DataTable GetPrjDataBaseV(string strCondition)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            strSQL.Append("Select vPrjDataBase.* ");
            strSQL.Append(" from vPrjDataBase ");
            strSQL.Append(" where " + strCondition);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }


        public override bool IsExist()
        {
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            if (objSQL.IsExistRecord("PrjDataBase", "PrjDataBaseId=" + "'" + mstrPrjDataBaseId + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// �жϵ�ǰ�����Ƿ���ڸ����ؼ���ֵ�ļ�¼
        /// </summary>
        /// <param name="strPrjDataBaseId">�����Ĺؼ���ֵ</param>
        /// <returns>�����Ƿ����?</returns>
        public static bool IsExist(string strPrjDataBaseId)
        {
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            if (objSQL.IsExistRecord("PrjDataBase", "PrjDataBaseId=" + "'" + strPrjDataBaseId + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ����ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.
        /// </summary>
        public void CheckPropertyNew()
        {
            if (Object.Equals(null, mstrPrjDataBaseId)
            || (!Object.Equals(null, mstrPrjDataBaseId) && mstrPrjDataBaseId.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[��Ŀ���ݿ�Id]����Ϊ��(NULL)!");
            }
            if (!Object.Equals(null, mstrPrjDataBaseId) && getStrLen(mstrPrjDataBaseId) > 4)
            {
                throw new clsDbObjException("�ֶ�[��Ŀ���ݿ�Id]�ĳ��Ȳ��ܳ���4!");
            }
            if (!Object.Equals(null, mstrPrjDataBaseName) && getStrLen(mstrPrjDataBaseName) > 50)
            {
                throw new clsDbObjException("�ֶ�[��Ŀ���ݿ���]�ĳ��Ȳ��ܳ���50!");
            }
            if (!Object.Equals(null, mstrDataBaseName) && getStrLen(mstrDataBaseName) > 30)
            {
                throw new clsDbObjException("�ֶ�[���ݿ���]�ĳ��Ȳ��ܳ���30!");
            }
            if (!Object.Equals(null, mstrDatabaseOwner) && getStrLen(mstrDatabaseOwner) > 30)
            {
                throw new clsDbObjException("�ֶ�[���ݿ�ӵ����]�ĳ��Ȳ��ܳ���30!");
            }
            if (!Object.Equals(null, mstrDataBasePwd) && getStrLen(mstrDataBasePwd) > 20)
            {
                throw new clsDbObjException("�ֶ�[���ݿ���û�����]�ĳ��Ȳ��ܳ���20!");
            }
            if (!Object.Equals(null, mstrDataBaseTypeId) && getStrLen(mstrDataBaseTypeId) > 2)
            {
                throw new clsDbObjException("�ֶ�[���ݿ�����ID]�ĳ��Ȳ��ܳ���2!");
            }
            if (!Object.Equals(null, mstrDataBaseUserId) && getStrLen(mstrDataBaseUserId) > 18)
            {
                throw new clsDbObjException("�ֶ�[���ݿ���û�ID]�ĳ��Ȳ��ܳ���18!");
            }
            if (!Object.Equals(null, mstrIpAddress) && getStrLen(mstrIpAddress) > 23)
            {
                throw new clsDbObjException("�ֶ�[������]�ĳ��Ȳ��ܳ���23!");
            }
            if (!Object.Equals(null, mstrSID) && getStrLen(mstrSID) > 30)
            {
                throw new clsDbObjException("�ֶ�[SID]�ĳ��Ȳ��ܳ���30!");
            }
            if (!Object.Equals(null, mstrTableSpace) && getStrLen(mstrTableSpace) > 30)
            {
                throw new clsDbObjException("�ֶ�[��ռ�]�ĳ��Ȳ��ܳ���30!");
            }
            if (!Object.Equals(null, mstrUserId) && getStrLen(mstrUserId) > 18)
            {
                throw new clsDbObjException("�ֶ�[�û�ID]�ĳ��Ȳ��ܳ���18!");
            }
            if (!Object.Equals(null, mstrUpdDate) && getStrLen(mstrUpdDate) > 8)
            {
                throw new clsDbObjException("�ֶ�[�޸�����]�ĳ��Ȳ��ܳ���8!");
            }
            if (!Object.Equals(null, mstrMemo) && getStrLen(mstrMemo) > 1000)
            {
                throw new clsDbObjException("�ֶ�[��ע]�ĳ��Ȳ��ܳ���1000!");
            }
        }


        /// <summary>
        /// ��ȡ��ǰ���������������м�¼�Ĺؼ���ֵ�б�
        /// </summary>
        /// <param name="strCondtion">������</param>
        /// <returns>���صĹؼ���ֵ�б�</returns>
        public override List<string> GetID(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            List<string> arrList = new List<string>();
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            int iRow, iCol;
            string strKeyValue;
            strSQL = "Select PrjDataBaseId from PrjDataBase where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            for (iRow = 0; iRow <= objDT.Rows.Count - 1; iRow++)
            {
                strKeyValue = "";
                for (iCol = 0; iCol <= objDT.Columns.Count - 1; iCol++)
                {
                    if (iCol == 0)
                    {
                        strKeyValue += objDT.Rows[iRow][iCol].ToString();
                    }
                    else
                    {
                        strKeyValue += "//" + objDT.Rows[iRow][iCol].ToString();
                    }
                }
                arrList.Add(strKeyValue);
            }
            objDT = null;
            return arrList;
        }

        /// <summary>
        /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ
        /// </summary>
        /// <param name="strCondtion">������</param>
        /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>
        public string GetFirstID(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            ArrayList arrList = new ArrayList();
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            string strKeyValue;
            strSQL = "Select PrjDataBaseId from PrjDataBase where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            strKeyValue = objDT.Rows[0][0].ToString();
            objDT = null;
            return strKeyValue;
        }

        /// <summary>
        /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ
        /// </summary>
        /// <param name="strCondtion">������</param>
        /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>
        public static string GetFirstID_S(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            ArrayList arrList = new ArrayList();
            clsSpecSQLforSql objSQL = null;
            if (string.IsNullOrEmpty(clsSqlDataBase.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlDataBase.ConnectString);
            }
            string strKeyValue;
            strSQL = "Select PrjDataBaseId from PrjDataBase where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsSqlDataBase");
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            strKeyValue = objDT.Rows[0][0].ToString();
            objDT = null;
            return strKeyValue;
        }
    }
}