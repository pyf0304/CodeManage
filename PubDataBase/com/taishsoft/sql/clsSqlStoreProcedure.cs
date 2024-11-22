//----------------------
//���ɴ���汾��6.3.0.0
//�������ڣ�2008/01/27
//�����ߣ����Է�
//ע�⣺��Ҫ���ݵײ㣨PubDataBase.dll���İ汾��4.3.0.0
//========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.common;
using com.taishsoft.commexception;
using com.taishsoft.commdb;
using com.taishsoft.syspara;
using System.Collections.Generic;
namespace com.taishsoft.sql
{
    public class clsSqlStoreProcedure : clsGeneralTab
    {
        public const string CurrTabName_S = "SqlStoreProcedure"; //��ǰ�������������صı���
        public const string CurrTabKeyFldName_S = "mId"; //��ǰ���еĹؼ������ƣ��������صı��йؼ�����
        protected const int mintAttributeCount = 5;
        public static string[] AttributeName = new string[] { "mId", "SP_ID", "SP_Name", "uid", "ConnectString_db" };
        //���������Ա���

        protected long mlngmId;    //mId
        protected long mlngSP_ID;    //SP_ID
        protected string mstrSP_Name;    //�洢��������
        protected int mintuid;    //uid
        protected string mstrConnectString_db;    //ConnectString_db

        //�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�
        private static string m_strConnectString;
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }

        public clsSqlStoreProcedure()
        {
            SetInit();
            _CurrTabName = "SqlStoreProcedure";
            KeyFldName = "mId";
        }

        public clsSqlStoreProcedure(long lngmId)
        {

            mlngmId = lngmId;
            SetInit();
            _CurrTabName = "SqlStoreProcedure";
            KeyFldName = "mId";
        }

        public clsSqlStoreProcedure(long lngmId, bool bolIsGetSqlStoreProcedure)
        {

            mlngmId = lngmId;
            SetInit();
            if (bolIsGetSqlStoreProcedure == true)
            {
                GetSqlStoreProcedure();
            }
            _CurrTabName = "SqlStoreProcedure";
            KeyFldName = "mId";
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
                if (strAttributeName == "mId")
                {
                    return mlngmId;
                }
                else if (strAttributeName == "SP_ID")
                {
                    return mlngSP_ID;
                }
                else if (strAttributeName == "SP_Name")
                {
                    return mstrSP_Name;
                }
                else if (strAttributeName == "uid")
                {
                    return mintuid;
                }
                else if (strAttributeName == "ConnectString_db")
                {
                    return mstrConnectString_db;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "mId")
                {
                    mlngmId = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "SP_ID")
                {
                    mlngSP_ID = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "SP_Name")
                {
                    mstrSP_Name = value.ToString();
                }
                else if (strAttributeName == "uid")
                {
                    mintuid = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "ConnectString_db")
                {
                    mstrConnectString_db = value.ToString();
                }
            }
        }
        public object this[int intIndex]
        {
            get
            {
                if ("mId" == AttributeName[intIndex])
                {
                    return mlngmId;
                }
                else if ("SP_ID" == AttributeName[intIndex])
                {
                    return mlngSP_ID;
                }
                else if ("SP_Name" == AttributeName[intIndex])
                {
                    return mstrSP_Name;
                }
                else if ("uid" == AttributeName[intIndex])
                {
                    return mintuid;
                }
                else if ("ConnectString_db" == AttributeName[intIndex])
                {
                    return mstrConnectString_db;
                }
                return null;
            }
            set
            {
                if ("mId" == AttributeName[intIndex])
                {
                    mlngmId = TransNullToInt(value.ToString());
                }
                else if ("SP_ID" == AttributeName[intIndex])
                {
                    mlngSP_ID = TransNullToInt(value.ToString());
                }
                else if ("SP_Name" == AttributeName[intIndex])
                {
                    mstrSP_Name = value.ToString();
                }
                else if ("uid" == AttributeName[intIndex])
                {
                    mintuid = TransNullToInt(value.ToString());
                }
                else if ("ConnectString_db" == AttributeName[intIndex])
                {
                    mstrConnectString_db = value.ToString();
                }
            }
        }

        /// <summary>
        /// mId
        /// </summary>
        public long mId
        {
            get
            {
                return mlngmId;
            }
            set
            {
                mlngmId = value;
                if (htProperty.ContainsKey("mId") == false)
                {
                    htProperty.Add("mId", "true");
                }
            }
        }
        /// <summary>
        /// SP_ID
        /// </summary>
        public long SP_ID
        {
            get
            {
                return mlngSP_ID;
            }
            set
            {
                mlngSP_ID = value;
                if (htProperty.ContainsKey("SP_ID") == false)
                {
                    htProperty.Add("SP_ID", "true");
                }
            }
        }
        /// <summary>
        /// �洢��������
        /// </summary>
        public string SP_Name
        {
            get
            {
                return mstrSP_Name;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSP_Name = value;
                }
                else
                {
                    mstrSP_Name = value;
                }
                if (htProperty.ContainsKey("SP_Name") == false)
                {
                    htProperty.Add("SP_Name", "true");
                }
            }
        }
        /// <summary>
        /// uid
        /// </summary>
        public int uid
        {
            get
            {
                return mintuid;
            }
            set
            {
                mintuid = value;
                if (htProperty.ContainsKey("uid") == false)
                {
                    htProperty.Add("uid", "true");
                }
            }
        }
        /// <summary>
        /// ConnectString_db
        /// </summary>
        public string ConnectString_db
        {
            get
            {
                return mstrConnectString_db;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrConnectString_db = value;
                }
                else
                {
                    mstrConnectString_db = value;
                }
                if (htProperty.ContainsKey("ConnectString_db") == false)
                {
                    htProperty.Add("ConnectString_db", "true");
                }
            }
        }

        /// <summary>
        /// ����޸�״̬,����մ洢���ֶ���Ϣ��HashTable�б�.
        /// </summary>
        public void ClearUpdateState()
        {
            htProperty.Clear();
        }

        public static clsSpecSQLforSql GetSpecSQLObj()
        {
            clsSpecSQLforSql objSQL = null;
            if (clsSysPara_PubDataBase.bolIsUseConnectStrName == true)
            {
                objSQL = new clsSpecSQLforSql(clsSysPara_PubDataBase.strConnectStrName, true);
                return objSQL;
            }
            if (string.IsNullOrEmpty(clsSqlStoreProcedure.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlStoreProcedure.ConnectString);
            }
            return objSQL;
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
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            strSQL = "Select * from SqlStoreProcedure where 1=2";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "SqlStoreProcedure");
            objRow = objDS.Tables["SqlStoreProcedure"].NewRow();
            objRow["SP_ID"] = mlngSP_ID; //SP_ID
            objRow["SP_Name"] = mstrSP_Name; //�洢��������
            objRow["uid"] = mintuid; //uid
            if (mstrConnectString_db != "")
            {
                objRow["ConnectString_db"] = mstrConnectString_db; //ConnectString_db
            }
            objDS.Tables["SqlStoreProcedure"].Rows.Add(objRow);
            try
            {
                objDA.Update(objDS, "SqlStoreProcedure");
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
        /// ��Ҫ�����ϴ��ļ�ʱ��
        /// </summary>
        /// <returns>�������ɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool AddNewRecordBySQL()
        {
            StringBuilder strSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            strSQL.AppendFormat("insert into SqlStoreProcedure (SP_ID, SP_Name, uid, ConnectString_db) values ({0}, '{1}', {2}, '{3}')", mlngSP_ID, mstrSP_Name, mintuid, mstrConnectString_db);
            return objSQL.ExecSql(strSQL.ToString());
        }



        /// <summary>
        /// /// ���ܣ�ͨ��SQL�����������¼,�÷�ʽ���Ż���ʽ
        /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ�ʹ�ֶ�ֵΪNULL���ֶ��������
        /// </summary>
        /// <returns>�������ɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool AddNewRecordBySQL2()
        {
            StringBuilder strSQL = new StringBuilder();
            //��Ҫ�������ֶ��б�
            ArrayList arrFieldListForInsert = new ArrayList();
            //��Ҫ������ֵ�б�
            ArrayList arrValueListForInsert = new ArrayList();
            arrFieldListForInsert.Add("mId");
            arrValueListForInsert.Add(mlngmId.ToString());
            arrFieldListForInsert.Add("SP_ID");
            arrValueListForInsert.Add(mlngSP_ID.ToString());
            if (mstrSP_Name != null)
            {
                arrFieldListForInsert.Add("SP_Name");
                mstrSP_Name = mstrSP_Name.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrSP_Name + "'");
            }
            arrFieldListForInsert.Add("uid");
            arrValueListForInsert.Add(mintuid.ToString());
            if (mstrConnectString_db != null)
            {
                arrFieldListForInsert.Add("ConnectString_db");
                mstrConnectString_db = mstrConnectString_db.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrConnectString_db + "'");
            }
            //��֯�����¼SQL��
            string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
            string strFieldListCode = string.Join(",", sstrFieldCode);
            string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
            string strValuesListCode = string.Join(",", sstrValuesCode);
            strSQL.Append("Insert into SqlStoreProcedure");
            strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            return objSQL.ExecSql(strSQL.ToString());
        }



        /// <summary>
        /// ���ܣ�ͨ��SQL�����������¼
        /// ��Ҫ�����ϴ��ļ�ʱ��
        /// </summary>
        /// <returns>�������ɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool AddNewRecordBySQL(SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            StringBuilder strSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            strSQL.AppendFormat("insert into SqlStoreProcedure (mId, SP_ID, SP_Name, uid, ConnectString_db) values ({0}, {1}, '{2}', {3}, '{4}')", mlngmId, mlngSP_ID, mstrSP_Name, mintuid, mstrConnectString_db);
            return objSQL.ExecSql(strSQL.ToString(), objSqlConnect, objSqlTransaction);
        }



        /// <summary>
        /// ���ܣ�ͨ��SQL�����������¼
        /// ��Ҫ�����ϴ��ļ�ʱ��
        /// </summary>
        /// <returns>�������ɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool AddNewRecordBySQL2(SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            StringBuilder strSQL = new StringBuilder();
            //��Ҫ�������ֶ��б�
            ArrayList arrFieldListForInsert = new ArrayList();
            //��Ҫ������ֵ�б�
            ArrayList arrValueListForInsert = new ArrayList();
            arrFieldListForInsert.Add("mId");
            arrValueListForInsert.Add(mlngmId.ToString());
            arrFieldListForInsert.Add("SP_ID");
            arrValueListForInsert.Add(mlngSP_ID.ToString());
            if (mstrSP_Name != null)
            {
                arrFieldListForInsert.Add("SP_Name");
                mstrSP_Name = mstrSP_Name.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrSP_Name + "'");
            }
            arrFieldListForInsert.Add("uid");
            arrValueListForInsert.Add(mintuid.ToString());
            if (mstrConnectString_db != null)
            {
                arrFieldListForInsert.Add("ConnectString_db");
                mstrConnectString_db = mstrConnectString_db.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrConnectString_db + "'");
            }
            //��֯�����¼SQL��
            string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
            string strFieldListCode = string.Join(",", sstrFieldCode);
            string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
            string strValuesListCode = string.Join(",", sstrValuesCode);
            strSQL.Append("Insert into SqlStoreProcedure");
            strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            return objSQL.ExecSql(strSQL.ToString(), objSqlConnect, objSqlTransaction);
        }


        public bool AddnewSqlStoreProcedureBySP()
        {
            //ͨ���洢������
            //ֱ��ʹ��
            if (mintErrNo != 0)
            {
                //MsgBox(mstrErrMsg(mintErrNo))
                return false;
            }
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mlngSP_ID);
            values.Add(mstrSP_Name);
            values.Add(mintuid);
            values.Add(mstrConnectString_db);
            objSQL.ExecSP("SqlStoreProcedure_Add", values);
            return true;
        }

        /// <summary>
        /// �Ѷ�����¼ͬʱ���뵽����!
        /// </summary>
        /// <param name="oDT"></param>
        /// <param name="strResult"></param>
        /// <returns></returns>
        public bool AddnewSqlStoreProcedures(System.Data.DataTable oDT, ref string strResult)
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            if (mintErrNo != 0)
            {
                strResult = "�����Ϊ��" + mintErrNo.ToString();
                return false;
            }
            strSQL = "Select * from SqlStoreProcedure where mId='111'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "SqlStoreProcedure");
            //���ؼ��ֵ�Ψһ��
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                long lngmId = Int32.Parse(oRow["mId"].ToString().Trim());
                if (IsExist(lngmId))
                {
                    strResult = "�ؼ���mIdΪ��" + lngmId + "�ļ�¼�Ѵ��ڣ������ظ�����!";
                    return false;
                }
            }
            //�Ѷ�����¼���뵽����
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                objRow = objDS.Tables["SqlStoreProcedure"].NewRow();
                objRow["SP_ID"] = oRow["SP_ID"].ToString().Trim(); //SP_ID
                objRow["SP_Name"] = oRow["SP_Name"].ToString().Trim(); //�洢��������
                objRow["uid"] = oRow["uid"].ToString().Trim(); //uid
                objRow["ConnectString_db"] = oRow["ConnectString_db"].ToString().Trim(); //ConnectString_db
                objDS.Tables["SqlStoreProcedure"].Rows.Add(objRow);
            }
            try
            {
                objDA.Update(objDS, "SqlStoreProcedure");
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
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            strSQL = "Select * from SqlStoreProcedure where mId=" + "" + mlngmId + "";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "SqlStoreProcedure");
            if (objDS.Tables["SqlStoreProcedure"].Rows.Count == 0)
            {
                //MsgBox("û����Ӧ��ID�ţ�mId=" + ""+ mlngmId+"");
                return false;
            }
            objRow = objDS.Tables["SqlStoreProcedure"].Rows[0];
            if (htProperty.ContainsKey("SP_ID"))
            {
                objRow["SP_ID"] = mlngSP_ID; //SP_ID
            }
            if (htProperty.ContainsKey("SP_Name"))
            {
                objRow["SP_Name"] = mstrSP_Name; //�洢��������
            }
            if (htProperty.ContainsKey("uid"))
            {
                objRow["uid"] = mintuid; //uid
            }
            if (htProperty.ContainsKey("ConnectString_db"))
            {
                objRow["ConnectString_db"] = mstrConnectString_db; //ConnectString_db
            }
            try
            {
                objDA.Update(objDS, "SqlStoreProcedure");
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
        /// /// ���ܣ�ͨ���洢����(StoreProcedure)���޸ļ�¼
        /// /// ȱ��:1������֧��������.
        /// </summary>
        /// <returns>����޸ĳɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool UpdateSqlStoreProcedureBySP()
        {
            //ͨ���洢������
            //ֱ��ʹ��
            if (mintErrNo != 0)
            {
                //MsgBox(mstrErrMsg(mintErrNo))
                return false;
            }
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mlngmId);
            values.Add(mlngSP_ID);
            values.Add(mstrSP_Name);
            values.Add(mintuid);
            values.Add(mstrConnectString_db);
            objSQL.ExecSP("SqlStoreProcedure_Update", values);
            return true;
        }

        /// <summary>
        /// /// ���ܣ�ͨ��SQL�������޸ļ�¼,�÷�ʽ�Ƿ��Ż���ʽ
        /// /// ȱ��:1�����ܴ����ֶ��еĵ�Ʋ���⣻2�����ܴ������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.
        /// </summary>
        /// <returns>����޸ĳɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool UpdateBySql()
        {
            StringBuilder sbSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            sbSQL.AppendFormat("Update SqlStoreProcedure Set ");
            sbSQL.AppendFormat("SP_ID = {0}", mlngSP_ID); //SP_ID
            sbSQL.AppendFormat(", SP_Name = '{0}'", mstrSP_Name); //�洢��������
            sbSQL.AppendFormat(", uid = {0}", mintuid); //uid
            sbSQL.AppendFormat(", ConnectString_db = '{0}'", mstrConnectString_db); //ConnectString_db
            sbSQL.AppendFormat("Where mId = {0}", mlngmId);
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
        /// /// ���ܣ�ͨ��SQL�������޸ļ�¼,�÷�ʽ���Ż���ʽ
        /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ��������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.
        /// </summary>
        /// <returns>����޸ĳɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool UpdateBySql2()
        {
            StringBuilder sbSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            sbSQL.AppendFormat("Update SqlStoreProcedure Set ");
            if (htProperty.ContainsKey("SP_ID"))
            {
                sbSQL.AppendFormat(" SP_ID = {0},", mlngSP_ID); //SP_ID
            }
            if (htProperty.ContainsKey("SP_Name"))
            {
                mstrSP_Name = mstrSP_Name.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" SP_Name = '{0}',", mstrSP_Name); //�洢��������
            }
            if (htProperty.ContainsKey("uid"))
            {
                sbSQL.AppendFormat(" uid = {0},", mintuid); //uid
            }
            if (htProperty.ContainsKey("ConnectString_db"))
            {
                mstrConnectString_db = mstrConnectString_db.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" ConnectString_db = '{0}',", mstrConnectString_db); //ConnectString_db
            }
            sbSQL.Remove(sbSQL.Length - 1, 1);
            sbSQL.AppendFormat(" Where mId = {0}", mlngmId);
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
        /// /// ���ܣ�ͨ��SQL�������޸ļ�¼,֧��������,�÷�ʽ�Ƿ��Ż���ʽ
        /// /// �ŵ�:1��֧��������.
        /// /// ȱ��:1�����ܴ����ֶ��еĵ�Ʋ���⣻
        /// ///      2�����ܴ������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�;
        /// </summary>
        /// <returns>����޸ĳɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool UpdateBySql(SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            StringBuilder sbSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            sbSQL.AppendFormat("Update SqlStoreProcedure Set ");
            sbSQL.AppendFormat("SP_ID = {0}", mlngSP_ID); //SP_ID
            sbSQL.AppendFormat(", SP_Name = '{0}'", mstrSP_Name); //�洢��������
            sbSQL.AppendFormat(", uid = {0}", mintuid); //uid
            sbSQL.AppendFormat(", ConnectString_db = '{0}'", mstrConnectString_db); //ConnectString_db
            sbSQL.AppendFormat("Where mId = {0}", mlngmId);
            try
            {
                return objSQL.ExecSql(sbSQL.ToString(), objSqlConnect, objSqlTransaction);
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
        /// /// ���ܣ�ͨ��SQL�������޸ļ�¼,֧��������,�÷�ʽ���Ż���ʽ
        /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻
        /// ///      2���ܹ��������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�;
        /// ///      3��֧��������.
        /// </summary>
        /// <returns>����޸ĳɹ��򷵻�TRUE������ΪFALSE</returns>
        public bool UpdateBySql2(SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            StringBuilder sbSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            sbSQL.AppendFormat("Update SqlStoreProcedure Set ");
            if (htProperty.ContainsKey("SP_ID"))
            {
                sbSQL.AppendFormat(" SP_ID = {0},", mlngSP_ID); //SP_ID
            }
            if (htProperty.ContainsKey("SP_Name"))
            {
                mstrSP_Name = mstrSP_Name.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" SP_Name = '{0}',", mstrSP_Name); //�洢��������
            }
            if (htProperty.ContainsKey("uid"))
            {
                sbSQL.AppendFormat(" uid = {0},", mintuid); //uid
            }
            if (htProperty.ContainsKey("ConnectString_db"))
            {
                mstrConnectString_db = mstrConnectString_db.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" ConnectString_db = '{0}',", mstrConnectString_db); //ConnectString_db
            }
            sbSQL.Remove(sbSQL.Length - 1, 1);
            sbSQL.AppendFormat(" Where mId = {0}", mlngmId);
            try
            {
                return objSQL.ExecSql(sbSQL.ToString(), objSqlConnect, objSqlTransaction);
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
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            int intRecCount;
            if (strCondition == "")
            {
                return 0; //��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
            }
            strSQL = "Select * from SqlStoreProcedure where " + strCondition;
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "SqlStoreProcedure");
            if (objDS.Tables["SqlStoreProcedure"].Rows.Count == 0)
            {
                return 0;
            }
            intRecCount = objDS.Tables["SqlStoreProcedure"].Rows.Count;
            foreach (System.Data.DataRow objRow in objDS.Tables["SqlStoreProcedure"].Rows)
            {
                objRow["SP_ID"] = mlngSP_ID; //SP_ID
                objRow["SP_Name"] = mstrSP_Name; //�洢��������
                objRow["uid"] = mintuid; //uid
                objRow["ConnectString_db"] = mstrConnectString_db; //ConnectString_db
            }
            try
            {
                objDA.Update(objDS, "SqlStoreProcedure");
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
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            //ɾ��SqlStoreProcedure�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from SqlStoreProcedure where mId=" + "" + mlngmId + "";
            return objSQL.ExecSql(strSQL);
        }


        public bool DelRecordBySP()
        {
            //ͨ���洢������
            //ֱ��ʹ��
            if (mintErrNo != 0)
            {
                //MsgBox(mstrErrMsg(mintErrNo))
                return false;
            }
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mlngmId);
            objSQL.ExecSP("SqlStoreProcedure_Delete", values);
            return true;
        }

        public bool DelRecord(SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            //ɾ��SqlStoreProcedure�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from SqlStoreProcedure where mId=" + "" + mlngmId + "";
            return objSQL.ExecSql(strSQL, objSqlConnect, objSqlTransaction);
        }


        //ͬʱɾ��������¼
        public static bool DelSqlStoreProcedure(ArrayList lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
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
            //ɾ��SqlStoreProcedure�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from SqlStoreProcedure where mId in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }

        public static bool DelRecord(long lngmId)
        {
            //ɾ��������¼
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            //ɾ��SqlStoreProcedure�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from SqlStoreProcedure where mId=" + "" + lngmId + "";
            return objSQL.ExecSql(strSQL);
        }


        /// <summary>
        /// ���ܣ�ɾ��������¼����������ɾ��
        /// </summary>
        /// <param name="strCondition">��Ҫɾ���ļ�¼����</param>
        /// <returns>����ɾ���ļ�¼0��</returns>
        public static int DelSqlStoreProcedure(string strCondition)
        {
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            string strSQL;
            if (strCondition == "")
            {
                return 0;	//��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
            }
            else
            {
                strSQL = "Delete from SqlStoreProcedure where " + strCondition;
            }
            int intRecoCount = objSQL.ExecSql2(strSQL);
            return intRecoCount;
        }


        public bool GetSqlStoreProcedure()
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            strSQL = "Select * from SqlStoreProcedure where mId=" + "" + mlngmId + "";
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            mlngmId = Int32.Parse(objDT.Rows[0]["mId"].ToString().Trim()); //mId
            mlngSP_ID = Int32.Parse(objDT.Rows[0]["SP_ID"].ToString().Trim()); //SP_ID
            mstrSP_Name = objDT.Rows[0]["SP_Name"].ToString().Trim(); //�洢��������
            mintuid = Int32.Parse(objDT.Rows[0]["uid"].ToString().Trim()); //uid
            mstrConnectString_db = objDT.Rows[0]["ConnectString_db"].ToString().Trim(); //ConnectString_db
            objDT = null;
            return true;
        }

        public bool GetSqlStoreProcedureOneBySP()
        {
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mlngmId);
            objDT = objSQL.ExecSpReturnDT("SqlStoreProcedure_SelectOne", values);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            mlngmId = Int32.Parse(objDT.Rows[0]["mId"].ToString().Trim()); //mId
            mlngSP_ID = Int32.Parse(objDT.Rows[0]["SP_ID"].ToString().Trim()); //SP_ID
            mstrSP_Name = objDT.Rows[0]["SP_Name"].ToString().Trim(); //�洢��������
            mintuid = Int32.Parse(objDT.Rows[0]["uid"].ToString().Trim()); //uid
            mstrConnectString_db = objDT.Rows[0]["ConnectString_db"].ToString().Trim(); //ConnectString_db
            objDT = null;
            return true;
        }

        public static System.Data.DataTable GetSqlStoreProcedure(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            strSQL = "Select * from SqlStoreProcedure where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        public static System.Data.DataTable GetSqlStoreProcedureByCondBySP(string strCondition)
        {
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDT = objSQL.ExecSpReturnDT("SqlStoreProcedure_SelectByCond", values);
            return objDT;
        }

        public static System.Data.DataSet GetSqlStoreProcedureDataSetByCondBySP(string strCondition)
        {
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDS = objSQL.ExecSPReturnDS("SqlStoreProcedure_SelectByCond", values, "SqlStoreProcedure");
            return objDS;
        }

        public static System.Data.DataSet GetDataSet_SqlStoreProcedure(string strCondition)
        {
            string strSQL;
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            strSQL = "Select * from SqlStoreProcedure where " + strCondition;
            objDS = objSQL.GetDataSet(strSQL, "SqlStoreProcedure");
            return objDS;
        }

        public static System.Data.DataSet GetDataSet_SqlStoreProcedureByCondBySP(string strCondition)
        {
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDS = objSQL.ExecSPReturnDS("SqlStoreProcedure_SelectByCond", values, "SqlStoreProcedure");
            return objDS;
        }

        public static System.Data.DataSet GetDataSet_SqlStoreProcedureV(string strCondition)
        {
            string strSQL;
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            strSQL = "Select * from vSqlStoreProcedure where " + strCondition;
            objDS = objSQL.GetDataSet(strSQL, "vSqlStoreProcedure");
            return objDS;
        }

        public ArrayList GetSqlStoreProcedureObjList(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            strSQL = "Select * from SqlStoreProcedure where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsSqlStoreProcedure objSqlStoreProcedure = new clsSqlStoreProcedure();
                objSqlStoreProcedure.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //mId
                objSqlStoreProcedure.SP_ID = Int32.Parse(objRow["SP_ID"].ToString().Trim()); //SP_ID
                objSqlStoreProcedure.SP_Name = objRow["SP_Name"].ToString().Trim(); //�洢��������
                objSqlStoreProcedure.uid = Int32.Parse(objRow["uid"].ToString().Trim()); //uid
                objSqlStoreProcedure.ConnectString_db = objRow["ConnectString_db"].ToString().Trim(); //ConnectString_db
                objSqlStoreProcedure.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ
                arrObjList.Add(objSqlStoreProcedure);
            }
            objDT = null;
            return arrObjList;
        }

        public ArrayList GetSqlStoreProcedureObjListBySP(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDT = objSQL.ExecSpReturnDT("SqlStoreProcedure_SelectByCond", values);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsSqlStoreProcedure objSqlStoreProcedure = new clsSqlStoreProcedure();
                objSqlStoreProcedure.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //mId
                objSqlStoreProcedure.SP_ID = Int32.Parse(objRow["SP_ID"].ToString().Trim()); //SP_ID
                objSqlStoreProcedure.SP_Name = objRow["SP_Name"].ToString().Trim(); //�洢��������
                objSqlStoreProcedure.uid = Int32.Parse(objRow["uid"].ToString().Trim()); //uid
                objSqlStoreProcedure.ConnectString_db = objRow["ConnectString_db"].ToString().Trim(); //ConnectString_db
                objSqlStoreProcedure.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ
                arrObjList.Add(objSqlStoreProcedure);
            }
            objDT = null;
            return arrObjList;
        }

        public clsSqlStoreProcedure GetFirstSqlStoreProcedure(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            strSQL = "Select * from SqlStoreProcedure where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            DataRow objRow = objDT.Rows[0];
            clsSqlStoreProcedure objSqlStoreProcedure = new clsSqlStoreProcedure();
            objSqlStoreProcedure.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //mId
            objSqlStoreProcedure.SP_ID = Int32.Parse(objRow["SP_ID"].ToString().Trim()); //SP_ID
            objSqlStoreProcedure.SP_Name = objRow["SP_Name"].ToString().Trim(); //�洢��������
            objSqlStoreProcedure.uid = Int32.Parse(objRow["uid"].ToString().Trim()); //uid
            objSqlStoreProcedure.ConnectString_db = objRow["ConnectString_db"].ToString().Trim(); //ConnectString_db
            objSqlStoreProcedure.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ
            objDT = null;
            return objSqlStoreProcedure;
        }

        public clsSqlStoreProcedure GetFirstSqlStoreProcedureBySP(string strCondition)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDT = objSQL.ExecSpReturnDT("SqlStoreProcedure_SelectTop1ByCond", values);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            DataRow objRow = objDT.Rows[0];
            clsSqlStoreProcedure objSqlStoreProcedure = new clsSqlStoreProcedure();
            objSqlStoreProcedure.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //mId
            objSqlStoreProcedure.SP_ID = Int32.Parse(objRow["SP_ID"].ToString().Trim()); //SP_ID
            objSqlStoreProcedure.SP_Name = objRow["SP_Name"].ToString().Trim(); //�洢��������
            objSqlStoreProcedure.uid = Int32.Parse(objRow["uid"].ToString().Trim()); //uid
            objSqlStoreProcedure.ConnectString_db = objRow["ConnectString_db"].ToString().Trim(); //ConnectString_db
            objSqlStoreProcedure.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ
            objDT = null;
            return objSqlStoreProcedure;
        }



        /// <summary>
        /// ���ܣ���ȡĳһ��������ر���ͼ(View)
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>�����Ѿ�ת�������DataTable</returns>
        public static System.Data.DataTable GetSqlStoreProcedureV(string strCondition)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            strSQL.Append("Select vSqlStoreProcedure.* ");
            strSQL.Append(" from vSqlStoreProcedure ");
            strSQL.Append(" where " + strCondition);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }


        public override bool IsExist()
        {
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            if (objSQL.IsExistRecord("SqlStoreProcedure", "mId=" + "" + mlngmId + ""))
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
        /// <param name="lngmId">�����Ĺؼ���ֵ</param>
        /// <returns>�����Ƿ����?</returns>
        public static bool IsExist(long lngmId)
        {
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            if (objSQL.IsExistRecord("SqlStoreProcedure", "mId=" + "" + lngmId + ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsExistBySP(long lngmId)
        {
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(lngmId);
            string strIsExist = "";
            values.Add(strIsExist);
            ArrayList arrReturn = objSQL.ExecSpWithOutPut("SqlStoreProcedure_IsExist", values);
            if (arrReturn[0].ToString() == "1")
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
            if (Object.Equals(null, mlngmId)
            || (!Object.Equals(null, mlngmId) && mlngmId.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[mId]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mlngSP_ID)
            || (!Object.Equals(null, mlngSP_ID) && mlngSP_ID.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[SP_ID]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrSP_Name)
            || (!Object.Equals(null, mstrSP_Name) && mstrSP_Name.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[�洢��������]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mintuid)
            || (!Object.Equals(null, mintuid) && mintuid.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[uid]����Ϊ��(NULL)!");
            }
            if (!Object.Equals(null, mstrSP_Name) && getStrLen(mstrSP_Name) > 50)
            {
                throw new clsDbObjException("�ֶ�[�洢��������]�ĳ��Ȳ��ܳ���50!");
            }
            if (!Object.Equals(null, mstrConnectString_db) && getStrLen(mstrConnectString_db) > 255)
            {
                throw new clsDbObjException("�ֶ�[ConnectString_db]�ĳ��Ȳ��ܳ���255!");
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
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            int iRow, iCol;
            string strKeyValue;
            strSQL = "Select mId from SqlStoreProcedure where " + strCondtion;
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
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            string strKeyValue;
            strSQL = "Select mId from SqlStoreProcedure where " + strCondtion;
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
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlStoreProcedure.GetSpecSQLObj();
            string strKeyValue;
            strSQL = "Select mId from SqlStoreProcedure where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsSqlStoreProcedure");
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return new clsSqlStoreProcedure().TransNullToInt(null);
            }
            strKeyValue = objDT.Rows[0][0].ToString();
            objDT = null;
            return long.Parse(strKeyValue);
        }
    }
}