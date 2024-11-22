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
    public class clsSqlTabView : clsGeneralTab
    {
        public const string CurrTabName_S = "SqlTabView";    //��ǰ�������������صı���
        public const string CurrTabKeyFldName_S = "Id";    //��ǰ���еĹؼ������ƣ��������صı��йؼ�����
        protected const int mintAttributeCount = 12;
        public static string[] AttributeName = new string[] { "Id", "Name", "Owner", "TabType", "FldNum", "Server", "DataBaseName", "UserId", "Password", "ConnectString", "Tag", "Memo" };
        //���������Ա���

        protected long mlngId;    //����Id
        protected string mstrName;    //����ͼ��
        /// <summary>
        /// ӵ����
        /// </summary>
        protected string mstrOwner;    //ӵ����
        protected string mstrTabType;    //������
        protected int mintFldNum;    //�ֶ���
        protected string mstrServer;    //��������
        protected string mstrDataBaseName;    //���ݿ���
        protected string mstrUserId;    //�û�ID
        protected string mstrPassword;    //����
        /// <summary>
        /// ���Ӵ�
        /// </summary>
        protected string mstrConnectString;    //���Ӵ�
        /// <summary>
        /// Tag
        /// </summary>
        protected string mstrTag;    //Tag
        /// <summary>
        /// ��ע
        /// </summary>
        protected string mstrMemo;    //��ע

        public clsSqlTabView()
        {
            SetInit();
            _CurrTabName = "SqlTabView";
            KeyFldName = "Id";
        }

        public clsSqlTabView(long lngId)
        {

            mlngId = lngId;
            SetInit();
            _CurrTabName = "SqlTabView";
            KeyFldName = "Id";
        }

        public clsSqlTabView(long lngId, bool bolIsGetSqlTabView)
        {

            mlngId = lngId;
            SetInit();
            if (bolIsGetSqlTabView == true)
            {
                GetSqlTabView();
            }
            _CurrTabName = "SqlTabView";
            KeyFldName = "Id";
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
                if (strAttributeName == "Id")
                {
                    return mlngId;
                }
                else if (strAttributeName == "Name")
                {
                    return mstrName;
                }
                else if (strAttributeName == "Owner")
                {
                    return mstrOwner;
                }
                else if (strAttributeName == "TabType")
                {
                    return mstrTabType;
                }
                else if (strAttributeName == "FldNum")
                {
                    return mintFldNum;
                }
                else if (strAttributeName == "Server")
                {
                    return mstrServer;
                }
                else if (strAttributeName == "DataBaseName")
                {
                    return mstrDataBaseName;
                }
                else if (strAttributeName == "UserId")
                {
                    return mstrUserId;
                }
                else if (strAttributeName == "Password")
                {
                    return mstrPassword;
                }
                else if (strAttributeName == "ConnectString")
                {
                    return mstrConnectString;
                }
                else if (strAttributeName == "Tag")
                {
                    return mstrTag;
                }
                else if (strAttributeName == "Memo")
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "Id")
                {
                    mlngId = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "Name")
                {
                    mstrName = value.ToString();
                }
                else if (strAttributeName == "Owner")
                {
                    mstrOwner = value.ToString();
                }
                else if (strAttributeName == "TabType")
                {
                    mstrTabType = value.ToString();
                }
                else if (strAttributeName == "FldNum")
                {
                    mintFldNum = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "Server")
                {
                    mstrServer = value.ToString();
                }
                else if (strAttributeName == "DataBaseName")
                {
                    mstrDataBaseName = value.ToString();
                }
                else if (strAttributeName == "UserId")
                {
                    mstrUserId = value.ToString();
                }
                else if (strAttributeName == "Password")
                {
                    mstrPassword = value.ToString();
                }
                else if (strAttributeName == "ConnectString")
                {
                    mstrConnectString = value.ToString();
                }
                else if (strAttributeName == "Tag")
                {
                    mstrTag = value.ToString();
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
                if ("Id" == AttributeName[intIndex])
                {
                    return mlngId;
                }
                else if ("Name" == AttributeName[intIndex])
                {
                    return mstrName;
                }
                else if ("Owner" == AttributeName[intIndex])
                {
                    return mstrOwner;
                }
                else if ("TabType" == AttributeName[intIndex])
                {
                    return mstrTabType;
                }
                else if ("FldNum" == AttributeName[intIndex])
                {
                    return mintFldNum;
                }
                else if ("Server" == AttributeName[intIndex])
                {
                    return mstrServer;
                }
                else if ("DataBaseName" == AttributeName[intIndex])
                {
                    return mstrDataBaseName;
                }
                else if ("UserId" == AttributeName[intIndex])
                {
                    return mstrUserId;
                }
                else if ("Password" == AttributeName[intIndex])
                {
                    return mstrPassword;
                }
                else if ("ConnectString" == AttributeName[intIndex])
                {
                    return mstrConnectString;
                }
                else if ("Tag" == AttributeName[intIndex])
                {
                    return mstrTag;
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if ("Id" == AttributeName[intIndex])
                {
                    mlngId = TransNullToInt(value.ToString());
                }
                else if ("Name" == AttributeName[intIndex])
                {
                    mstrName = value.ToString();
                }
                else if ("Owner" == AttributeName[intIndex])
                {
                    mstrOwner = value.ToString();
                }
                else if ("TabType" == AttributeName[intIndex])
                {
                    mstrTabType = value.ToString();
                }
                else if ("FldNum" == AttributeName[intIndex])
                {
                    mintFldNum = TransNullToInt(value.ToString());
                }
                else if ("Server" == AttributeName[intIndex])
                {
                    mstrServer = value.ToString();
                }
                else if ("DataBaseName" == AttributeName[intIndex])
                {
                    mstrDataBaseName = value.ToString();
                }
                else if ("UserId" == AttributeName[intIndex])
                {
                    mstrUserId = value.ToString();
                }
                else if ("Password" == AttributeName[intIndex])
                {
                    mstrPassword = value.ToString();
                }
                else if ("ConnectString" == AttributeName[intIndex])
                {
                    mstrConnectString = value.ToString();
                }
                else if ("Tag" == AttributeName[intIndex])
                {
                    mstrTag = value.ToString();
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    mstrMemo = value.ToString();
                }
            }
        }

        /// <summary>
        /// ����Id
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
            }
        }
        /// <summary>
        /// ����ͼ��
        /// </summary>
        public string Name
        {
            get
            {
                return mstrName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrName = value;
                }
                else
                {
                    mstrName = value;
                }
            }
        }
        /// <summary>
        /// ӵ����
        /// </summary>
        public string Owner
        {
            get
            {
                return mstrOwner;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrOwner = value;
                }
                else
                {
                    mstrOwner = value;
                }
            }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string TabType
        {
            get
            {
                return mstrTabType;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTabType = value;
                }
                else
                {
                    mstrTabType = value;
                }
            }
        }
        /// <summary>
        /// �ֶ���
        /// </summary>
        public int FldNum
        {
            get
            {
                return mintFldNum;
            }
            set
            {
                mintFldNum = value;
            }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string Server
        {
            get
            {
                return mstrServer;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrServer = value;
                }
                else
                {
                    mstrServer = value;
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
        /// ����
        /// </summary>
        public string Password
        {
            get
            {
                return mstrPassword;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPassword = value;
                }
                else
                {
                    mstrPassword = value;
                }
            }
        }
        /// <summary>
        /// ���Ӵ�
        /// </summary>
        public string ConnectString
        {
            get
            {
                return mstrConnectString;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrConnectString = value;
                }
                else
                {
                    mstrConnectString = value;
                }
            }
        }
        /// <summary>
        /// Tag
        /// </summary>
        public string Tag
        {
            get
            {
                return mstrTag;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTag = value;
                }
                else
                {
                    mstrTag = value;
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
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from SqlTabView where 1=2";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "SqlTabView");
            objRow = objDS.Tables["SqlTabView"].NewRow();
            objRow["Id"] = mlngId;    //����Id
            objRow["Name"] = mstrName;    //����ͼ��
            objRow["Owner"] = mstrOwner;    //ӵ����
            objRow["TabType"] = mstrTabType;    //������
            objRow["FldNum"] = mintFldNum;    //�ֶ���
            if (mstrServer != "")
            {
                objRow["Server"] = mstrServer;   //��������
            }
            if (mstrDataBaseName != "")
            {
                objRow["DataBaseName"] = mstrDataBaseName;   //���ݿ���
            }
            if (mstrUserId != "")
            {
                objRow["UserId"] = mstrUserId;   //�û�ID
            }
            if (mstrPassword != "")
            {
                objRow["Password"] = mstrPassword;   //����
            }
            if (mstrConnectString != "")
            {
                objRow["ConnectString"] = mstrConnectString;   //���Ӵ�
            }
            if (mstrTag != "")
            {
                objRow["Tag"] = mstrTag;   //Tag
            }
            if (mstrMemo != "")
            {
                objRow["Memo"] = mstrMemo;   //��ע
            }
            objDS.Tables["SqlTabView"].Rows.Add(objRow);
            try
            {
                objDA.Update(objDS, "SqlTabView");
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



        public bool AddnewSqlTabViewBySP()
        {
            //ͨ���洢������
            //ֱ��ʹ��
            if (mintErrNo != 0)
            {
                //MsgBox(mstrErrMsg(mintErrNo))
                return false;
            }
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            objSQL.SPConfigXMLFile = "..\\XML\\XMLSP.xml";
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mlngId);
            values.Add(mstrName);
            values.Add(mstrOwner);
            values.Add(mstrTabType);
            values.Add(mintFldNum);
            values.Add(mstrServer);
            values.Add(mstrDataBaseName);
            values.Add(mstrUserId);
            values.Add(mstrPassword);
            values.Add(mstrConnectString);
            values.Add(mstrTag);
            values.Add(mstrMemo);
            objSQL.ExecSP("AddnewSqlTabView", values);
            return true;
        }

        /// <summary>
        /// �Ѷ�����¼ͬʱ���뵽����!
        /// </summary>
        /// <param name="oDT"></param>
        /// <param name="strResult"></param>
        /// <returns></returns>
        public bool AddnewSqlTabViews(System.Data.DataTable oDT, ref string strResult)
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            if (mintErrNo != 0)
            {
                strResult = "�����Ϊ��" + mintErrNo.ToString();
                return false;
            }
            strSQL = "Select * from SqlTabView where Id='111'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "SqlTabView");
            //���ؼ��ֵ�Ψһ��
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                long lngId = Int32.Parse(oRow["Id"].ToString().Trim());
                if (IsExist(lngId))
                {
                    strResult = "�ؼ���IdΪ��" + lngId + "�ļ�¼�Ѵ��ڣ������ظ�����!";
                    return false;
                }
            }
            //�Ѷ�����¼���뵽����
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                objRow = objDS.Tables["SqlTabView"].NewRow();
                objRow["Id"] = oRow["Id"].ToString().Trim();    //����Id
                objRow["Name"] = oRow["Name"].ToString().Trim();    //����ͼ��
                objRow["Owner"] = oRow["Owner"].ToString().Trim();    //ӵ����
                objRow["TabType"] = oRow["TabType"].ToString().Trim();    //������
                objRow["FldNum"] = oRow["FldNum"].ToString().Trim();    //�ֶ���
                objRow["Server"] = oRow["Server"].ToString().Trim();    //��������
                objRow["DataBaseName"] = oRow["DataBaseName"].ToString().Trim();    //���ݿ���
                objRow["UserId"] = oRow["UserId"].ToString().Trim();    //�û�ID
                objRow["Password"] = oRow["Password"].ToString().Trim();    //����
                objRow["ConnectString"] = oRow["ConnectString"].ToString().Trim();    //���Ӵ�
                objRow["Tag"] = oRow["Tag"].ToString().Trim();    //Tag
                objRow["Memo"] = oRow["Memo"].ToString().Trim();    //��ע
                objDS.Tables["SqlTabView"].Rows.Add(objRow);
            }
            try
            {
                objDA.Update(objDS, "SqlTabView");
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
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from SqlTabView where Id=" + "" + mlngId + "";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "SqlTabView");
            if (objDS.Tables["SqlTabView"].Rows.Count == 0)
            {
                //MsgBox("û����Ӧ��ID�ţ�Id=" + ""+ mlngId+"");
                return false;
            }
            objRow = objDS.Tables["SqlTabView"].Rows[0];
            objRow["Name"] = mstrName;       //����ͼ��
            objRow["Owner"] = mstrOwner;       //ӵ����
            objRow["TabType"] = mstrTabType;       //������
            objRow["FldNum"] = mintFldNum;       //�ֶ���
            if (mstrServer != "")
            {
                objRow["Server"] = mstrServer;    //��������
            }
            if (mstrDataBaseName != "")
            {
                objRow["DataBaseName"] = mstrDataBaseName;    //���ݿ���
            }
            if (mstrUserId != "")
            {
                objRow["UserId"] = mstrUserId;    //�û�ID
            }
            if (mstrPassword != "")
            {
                objRow["Password"] = mstrPassword;    //����
            }
            if (mstrConnectString != "")
            {
                objRow["ConnectString"] = mstrConnectString;    //���Ӵ�
            }
            if (mstrTag != "")
            {
                objRow["Tag"] = mstrTag;    //Tag
            }
            if (mstrMemo != "")
            {
                objRow["Memo"] = mstrMemo;    //��ע
            }
            try
            {
                objDA.Update(objDS, "SqlTabView");
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
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            int intRecCount;
            if (strCondition == "")
            {
                return 0;   //��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
            }
            strSQL = "Select * from SqlTabView where " + strCondition;
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "SqlTabView");
            if (objDS.Tables["SqlTabView"].Rows.Count == 0)
            {
                return 0;
            }
            intRecCount = objDS.Tables["SqlTabView"].Rows.Count;
            foreach (System.Data.DataRow objRow in objDS.Tables["SqlTabView"].Rows)
            {
                objRow["Name"] = mstrName;    //����ͼ��
                objRow["Owner"] = mstrOwner;    //ӵ����
                objRow["TabType"] = mstrTabType;    //������
                objRow["FldNum"] = mintFldNum;    //�ֶ���
                objRow["Server"] = mstrServer;    //��������
                objRow["DataBaseName"] = mstrDataBaseName;    //���ݿ���
                objRow["UserId"] = mstrUserId;    //�û�ID
                objRow["Password"] = mstrPassword;    //����
                objRow["ConnectString"] = mstrConnectString;    //���Ӵ�
                objRow["Tag"] = mstrTag;    //Tag
                objRow["Memo"] = mstrMemo;    //��ע
            }
            try
            {
                objDA.Update(objDS, "SqlTabView");
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
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            //ɾ��SqlTabView�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from SqlTabView where Id=" + "" + mlngId + "";
            return objSQL.ExecSql(strSQL);
        }


        //ͬʱɾ��������¼
        public static bool DelSqlTabView(ArrayList lstKey)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
                else strKeyList += "," + "" + lstKey[i].ToString() + "";
            }
            strSQL = "";
            //ɾ��SqlTabView�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from SqlTabView where Id in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }

        public static bool DelRecord(long lngId)
        {
            //ɾ��������¼
            string strSQL = "";
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            //ɾ��SqlTabView�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from SqlTabView where Id=" + "" + lngId + "";
            return objSQL.ExecSql(strSQL);
        }


        /// <summary>
        /// ���ܣ�ɾ��������¼����������ɾ��
        /// </summary>
        /// <param name="strCondition">��Ҫɾ���ļ�¼����</param>
        /// <returns>����ɾ���ļ�¼0��</returns>
        public static int DelSqlTabView(string strCondition)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strSQL;
            if (strCondition == "")
            {
                return 0;	//��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
            }
            else
            {
                strSQL = "Delete from SqlTabView where " + strCondition;
            }
            int intRecoCount = objSQL.ExecSql2(strSQL);
            return intRecoCount;
        }


        public bool GetSqlTabView()
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from SqlTabView where Id=" + "" + mlngId + "";
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            mlngId = Int32.Parse(objDT.Rows[0]["Id"].ToString().Trim());       //����Id
            mstrName = objDT.Rows[0]["Name"].ToString().Trim();       //����ͼ��
            mstrOwner = objDT.Rows[0]["Owner"].ToString().Trim();       //ӵ����
            mstrTabType = objDT.Rows[0]["TabType"].ToString().Trim();       //������
            mintFldNum = TransNullToInt(objDT.Rows[0]["FldNum"].ToString().Trim());       //�ֶ���
            mstrServer = objDT.Rows[0]["Server"].ToString().Trim();       //��������
            mstrDataBaseName = objDT.Rows[0]["DataBaseName"].ToString().Trim();       //���ݿ���
            mstrUserId = objDT.Rows[0]["UserId"].ToString().Trim();       //�û�ID
            mstrPassword = objDT.Rows[0]["Password"].ToString().Trim();       //����
            mstrConnectString = objDT.Rows[0]["ConnectString"].ToString().Trim();       //���Ӵ�
            mstrTag = objDT.Rows[0]["Tag"].ToString().Trim();       //Tag
            mstrMemo = objDT.Rows[0]["Memo"].ToString().Trim();       //��ע
            objDT = null;
            return true;
        }

        public static System.Data.DataTable GetSqlTabView(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from SqlTabView where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        public ArrayList GetSqlTabViewObjList(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from SqlTabView where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsSqlTabView objSqlTabView = new clsSqlTabView();
                objSqlTabView.Id = Int32.Parse(objRow["Id"].ToString().Trim());     //����Id
                objSqlTabView.Name = objRow["Name"].ToString().Trim();     //����ͼ��
                objSqlTabView.Owner = objRow["Owner"].ToString().Trim();     //ӵ����
                objSqlTabView.TabType = objRow["TabType"].ToString().Trim();     //������
                objSqlTabView.FldNum = TransNullToInt(objRow["FldNum"].ToString().Trim());     //�ֶ���
                objSqlTabView.Server = objRow["Server"].ToString().Trim();     //��������
                objSqlTabView.DataBaseName = objRow["DataBaseName"].ToString().Trim();     //���ݿ���
                objSqlTabView.UserId = objRow["UserId"].ToString().Trim();     //�û�ID
                objSqlTabView.Password = objRow["Password"].ToString().Trim();     //����
                objSqlTabView.ConnectString = objRow["ConnectString"].ToString().Trim();     //���Ӵ�
                objSqlTabView.Tag = objRow["Tag"].ToString().Trim();     //Tag
                objSqlTabView.Memo = objRow["Memo"].ToString().Trim();     //��ע
                arrObjList.Add(objSqlTabView);
            }
            objDT = null;
            return arrObjList;
        }

        public clsSqlTabView GetFirstSqlTabView(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from SqlTabView where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            DataRow objRow = objDT.Rows[0];
            clsSqlTabView objSqlTabView = new clsSqlTabView();
            objSqlTabView.Id = Int32.Parse(objRow["Id"].ToString().Trim());     //����Id
            objSqlTabView.Name = objRow["Name"].ToString().Trim();     //����ͼ��
            objSqlTabView.Owner = objRow["Owner"].ToString().Trim();     //ӵ����
            objSqlTabView.TabType = objRow["TabType"].ToString().Trim();     //������
            objSqlTabView.FldNum = TransNullToInt(objRow["FldNum"].ToString().Trim());     //�ֶ���
            objSqlTabView.Server = objRow["Server"].ToString().Trim();     //��������
            objSqlTabView.DataBaseName = objRow["DataBaseName"].ToString().Trim();     //���ݿ���
            objSqlTabView.UserId = objRow["UserId"].ToString().Trim();     //�û�ID
            objSqlTabView.Password = objRow["Password"].ToString().Trim();     //����
            objSqlTabView.ConnectString = objRow["ConnectString"].ToString().Trim();     //���Ӵ�
            objSqlTabView.Tag = objRow["Tag"].ToString().Trim();     //Tag
            objSqlTabView.Memo = objRow["Memo"].ToString().Trim();     //��ע
            objDT = null;
            return objSqlTabView;
        }


        /// <summary>
        /// ���ܣ���ȡĳһ������DataTable�����еĴ���ת������Ӧ������
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>�����Ѿ�ת�������DataTable</returns>
        public static System.Data.DataTable GetSqlTabViewT(string strCondition)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL.Append("Select SqlTabView.* ");
            strSQL.Append(", Users.UserName UsersUserName ");
            strSQL.Append(" from SqlTabView ");
            strSQL.Append(" left JOIN Users on SqlTabView.UserId = Users.UserId ");
            strSQL.Append(" where " + strCondition);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }



        /// <summary>
        /// ���ܣ���ȡĳһ��������ر���ͼ(View)
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>�����Ѿ�ת�������DataTable</returns>
        public static System.Data.DataTable GetSqlTabViewV(string strCondition)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL.Append("Select vSqlTabView.* ");
            strSQL.Append(" from vSqlTabView ");
            strSQL.Append(" where " + strCondition);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }


        public override bool IsExist()
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            if (objSQL.IsExistRecord("SqlTabView", "Id=" + "" + mlngId + ""))
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
        /// <param name="lngId">�����Ĺؼ���ֵ</param>
        /// <returns>�����Ƿ����?</returns>
        public static bool IsExist(long lngId)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            if (objSQL.IsExistRecord("SqlTabView", "Id=" + "" + lngId + ""))
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
            if (Object.Equals(null, mlngId)
            || (!Object.Equals(null, mlngId) && mlngId.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[����Id]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrName)
            || (!Object.Equals(null, mstrName) && mstrName.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[����ͼ��]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrOwner)
            || (!Object.Equals(null, mstrOwner) && mstrOwner.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[ӵ����]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrTabType)
            || (!Object.Equals(null, mstrTabType) && mstrTabType.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[������]����Ϊ��(NULL)!");
            }
            if (!Object.Equals(null, mstrName) && getStrLen(mstrName) > 50)
            {
                throw new clsDbObjException("�ֶ�[����ͼ��]�ĳ��Ȳ��ܳ���50!");
            }
            if (!Object.Equals(null, mstrOwner) && getStrLen(mstrOwner) > 50)
            {
                throw new clsDbObjException("�ֶ�[ӵ����]�ĳ��Ȳ��ܳ���50!");
            }
            if (!Object.Equals(null, mstrTabType) && getStrLen(mstrTabType) > 30)
            {
                throw new clsDbObjException("�ֶ�[������]�ĳ��Ȳ��ܳ���30!");
            }
            if (!Object.Equals(null, mstrServer) && getStrLen(mstrServer) > 50)
            {
                throw new clsDbObjException("�ֶ�[��������]�ĳ��Ȳ��ܳ���50!");
            }
            if (!Object.Equals(null, mstrDataBaseName) && getStrLen(mstrDataBaseName) > 50)
            {
                throw new clsDbObjException("�ֶ�[���ݿ���]�ĳ��Ȳ��ܳ���50!");
            }
            if (!Object.Equals(null, mstrUserId) && getStrLen(mstrUserId) > 18)
            {
                throw new clsDbObjException("�ֶ�[�û�ID]�ĳ��Ȳ��ܳ���18!");
            }
            if (!Object.Equals(null, mstrPassword) && getStrLen(mstrPassword) > 20)
            {
                throw new clsDbObjException("�ֶ�[����]�ĳ��Ȳ��ܳ���20!");
            }
            if (!Object.Equals(null, mstrConnectString) && getStrLen(mstrConnectString) > 100)
            {
                throw new clsDbObjException("�ֶ�[���Ӵ�]�ĳ��Ȳ��ܳ���100!");
            }
            if (!Object.Equals(null, mstrTag) && getStrLen(mstrTag) > 500)
            {
                throw new clsDbObjException("�ֶ�[Tag]�ĳ��Ȳ��ܳ���500!");
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
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            int iRow, iCol;
            string strKeyValue;
            strSQL = "Select Id from SqlTabView where " + strCondtion;
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
        public long GetFirstID(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            ArrayList arrList = new ArrayList();
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strKeyValue;
            strSQL = "Select Id from SqlTabView where " + strCondtion;
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
                return TransNullToInt(null);
            }
            strKeyValue = objDT.Rows[0][0].ToString();
            objDT = null;
            return long.Parse(strKeyValue);
        }

        /// <summary>
        /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ
        /// </summary>
        /// <param name="strCondtion">������</param>
        /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>
        public static long GetFirstID_S(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            ArrayList arrList = new ArrayList();
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strKeyValue;
            strSQL = "Select Id from SqlTabView where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsSqlTabView");
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return new clsSqlTabView().TransNullToInt(null);
            }
            strKeyValue = objDT.Rows[0][0].ToString();
            objDT = null;
            return long.Parse(strKeyValue);
        }
    }
}