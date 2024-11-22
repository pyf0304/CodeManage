//----------------------
//���ɴ���汾��6.3.0.0
//�������ڣ�2008/01/28
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
    public class clsSqlSP_Para : clsGeneralTab
    {
        public const string CurrTabName_S = "SqlSP_Para"; //��ǰ�������������صı���
        public const string CurrTabKeyFldName_S = "mId"; //��ǰ���еĹؼ������ƣ��������صı��йؼ�����
        protected const int mintAttributeCount = 8;
        public static string[] AttributeName = new string[] { "mId", "id_StoreProcedure", "ParaName", "ParaSize", "ParaDataType", "ParaDirection", "IsNullable", "SP_ID" };
        //���������Ա���

        protected long mlngmId;    //mId
        protected long mlngid_StoreProcedure;    //�洢������ˮ��
        protected string mstrParaName;    //������
        protected short mshtParaSize;    //��������
        protected string mstrParaDataType;    //������������
        protected string mstrParaDirection;    //������������
        protected bool mbolIsNullable;    //�Ƿ�ɿ�
        protected long mlngSP_ID;    //SP_ID

        //�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�
        private static string m_strConnectString;
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }

        public clsSqlSP_Para()
        {
            SetInit();
            _CurrTabName = "SqlSP_Para";
            KeyFldName = "mId";
        }

        public clsSqlSP_Para(long lngmId)
        {

            mlngmId = lngmId;
            SetInit();
            _CurrTabName = "SqlSP_Para";
            KeyFldName = "mId";
        }

        public clsSqlSP_Para(long lngmId, bool bolIsGetSqlSP_Para)
        {

            mlngmId = lngmId;
            SetInit();
            if (bolIsGetSqlSP_Para == true)
            {
                GetSqlSP_Para();
            }
            _CurrTabName = "SqlSP_Para";
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
                else if (strAttributeName == "id_StoreProcedure")
                {
                    return mlngid_StoreProcedure;
                }
                else if (strAttributeName == "ParaName")
                {
                    return mstrParaName;
                }
                else if (strAttributeName == "ParaSize")
                {
                    return mshtParaSize;
                }
                else if (strAttributeName == "ParaDataType")
                {
                    return mstrParaDataType;
                }
                else if (strAttributeName == "ParaDirection")
                {
                    return mstrParaDirection;
                }
                else if (strAttributeName == "IsNullable")
                {
                    return mbolIsNullable;
                }
                else if (strAttributeName == "SP_ID")
                {
                    return mlngSP_ID;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "mId")
                {
                    mlngmId = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "id_StoreProcedure")
                {
                    mlngid_StoreProcedure = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "ParaName")
                {
                    mstrParaName = value.ToString();
                }
                else if (strAttributeName == "ParaSize")
                {
                    mshtParaSize = TransNullToShort(value.ToString());
                }
                else if (strAttributeName == "ParaDataType")
                {
                    mstrParaDataType = value.ToString();
                }
                else if (strAttributeName == "ParaDirection")
                {
                    mstrParaDirection = value.ToString();
                }
                else if (strAttributeName == "IsNullable")
                {
                    mbolIsNullable = TransNullToBool(value.ToString());
                }
                else if (strAttributeName == "SP_ID")
                {
                    mlngSP_ID = TransNullToInt(value.ToString());
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
                else if ("id_StoreProcedure" == AttributeName[intIndex])
                {
                    return mlngid_StoreProcedure;
                }
                else if ("ParaName" == AttributeName[intIndex])
                {
                    return mstrParaName;
                }
                else if ("ParaSize" == AttributeName[intIndex])
                {
                    return mshtParaSize;
                }
                else if ("ParaDataType" == AttributeName[intIndex])
                {
                    return mstrParaDataType;
                }
                else if ("ParaDirection" == AttributeName[intIndex])
                {
                    return mstrParaDirection;
                }
                else if ("IsNullable" == AttributeName[intIndex])
                {
                    return mbolIsNullable;
                }
                else if ("SP_ID" == AttributeName[intIndex])
                {
                    return mlngSP_ID;
                }
                return null;
            }
            set
            {
                if ("mId" == AttributeName[intIndex])
                {
                    mlngmId = TransNullToInt(value.ToString());
                }
                else if ("id_StoreProcedure" == AttributeName[intIndex])
                {
                    mlngid_StoreProcedure = TransNullToInt(value.ToString());
                }
                else if ("ParaName" == AttributeName[intIndex])
                {
                    mstrParaName = value.ToString();
                }
                else if ("ParaSize" == AttributeName[intIndex])
                {
                    mshtParaSize = TransNullToShort(value.ToString());
                }
                else if ("ParaDataType" == AttributeName[intIndex])
                {
                    mstrParaDataType = value.ToString();
                }
                else if ("ParaDirection" == AttributeName[intIndex])
                {
                    mstrParaDirection = value.ToString();
                }
                else if ("IsNullable" == AttributeName[intIndex])
                {
                    mbolIsNullable = TransNullToBool(value.ToString());
                }
                else if ("SP_ID" == AttributeName[intIndex])
                {
                    mlngSP_ID = TransNullToInt(value.ToString());
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
        /// �洢������ˮ��
        /// </summary>
        public long id_StoreProcedure
        {
            get
            {
                return mlngid_StoreProcedure;
            }
            set
            {
                mlngid_StoreProcedure = value;
                if (htProperty.ContainsKey("id_StoreProcedure") == false)
                {
                    htProperty.Add("id_StoreProcedure", "true");
                }
            }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string ParaName
        {
            get
            {
                return mstrParaName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrParaName = value;
                }
                else
                {
                    mstrParaName = value;
                }
                if (htProperty.ContainsKey("ParaName") == false)
                {
                    htProperty.Add("ParaName", "true");
                }
            }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public short ParaSize
        {
            get
            {
                return mshtParaSize;
            }
            set
            {
                mshtParaSize = value;
                if (htProperty.ContainsKey("ParaSize") == false)
                {
                    htProperty.Add("ParaSize", "true");
                }
            }
        }
        /// <summary>
        /// ������������
        /// </summary>
        public string ParaDataType
        {
            get
            {
                return mstrParaDataType;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrParaDataType = value;
                }
                else
                {
                    mstrParaDataType = value;
                }
                if (htProperty.ContainsKey("ParaDataType") == false)
                {
                    htProperty.Add("ParaDataType", "true");
                }
            }
        }
        /// <summary>
        /// ������������
        /// </summary>
        public string ParaDirection
        {
            get
            {
                return mstrParaDirection;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrParaDirection = value;
                }
                else
                {
                    mstrParaDirection = value;
                }
                if (htProperty.ContainsKey("ParaDirection") == false)
                {
                    htProperty.Add("ParaDirection", "true");
                }
            }
        }
        /// <summary>
        /// �Ƿ�ɿ�
        /// </summary>
        public bool IsNullable
        {
            get
            {
                return mbolIsNullable;
            }
            set
            {
                mbolIsNullable = value;
                if (htProperty.ContainsKey("IsNullable") == false)
                {
                    htProperty.Add("IsNullable", "true");
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
            if (string.IsNullOrEmpty(clsSqlSP_Para.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsSqlSP_Para.ConnectString);
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            strSQL = "Select * from SqlSP_Para where 1=2";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "SqlSP_Para");
            objRow = objDS.Tables["SqlSP_Para"].NewRow();
            objRow["id_StoreProcedure"] = mlngid_StoreProcedure; //�洢������ˮ��
            objRow["ParaName"] = mstrParaName; //������
            objRow["ParaSize"] = mshtParaSize; //��������
            objRow["ParaDataType"] = mstrParaDataType; //������������
            objRow["ParaDirection"] = mstrParaDirection; //������������
            objRow["IsNullable"] = mbolIsNullable; //�Ƿ�ɿ�
            objRow["SP_ID"] = mlngSP_ID; //SP_ID
            objDS.Tables["SqlSP_Para"].Rows.Add(objRow);
            try
            {
                objDA.Update(objDS, "SqlSP_Para");
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            strSQL.AppendFormat("insert into SqlSP_Para (id_StoreProcedure, ParaName, ParaSize, ParaDataType, ParaDirection, IsNullable, SP_ID) values ({0}, '{1}', {2}, '{3}', '{4}', '{5}', {6})", mlngid_StoreProcedure, mstrParaName, mshtParaSize, mstrParaDataType, mstrParaDirection, mbolIsNullable == true ? "1" : "0", mlngSP_ID);
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
            arrFieldListForInsert.Add("id_StoreProcedure");
            arrValueListForInsert.Add(mlngid_StoreProcedure.ToString());
            if (mstrParaName != null)
            {
                arrFieldListForInsert.Add("ParaName");
                mstrParaName = mstrParaName.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrParaName + "'");
            }
            arrFieldListForInsert.Add("ParaSize");
            arrValueListForInsert.Add(mshtParaSize.ToString());
            if (mstrParaDataType != null)
            {
                arrFieldListForInsert.Add("ParaDataType");
                mstrParaDataType = mstrParaDataType.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrParaDataType + "'");
            }
            if (mstrParaDirection != null)
            {
                arrFieldListForInsert.Add("ParaDirection");
                mstrParaDirection = mstrParaDirection.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrParaDirection + "'");
            }
            arrFieldListForInsert.Add("IsNullable");
            arrValueListForInsert.Add("'" + (mbolIsNullable == false ? "0" : "1") + "'");
            arrFieldListForInsert.Add("SP_ID");
            arrValueListForInsert.Add(mlngSP_ID.ToString());
            //��֯�����¼SQL��
            string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
            string strFieldListCode = string.Join(",", sstrFieldCode);
            string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
            string strValuesListCode = string.Join(",", sstrValuesCode);
            strSQL.Append("Insert into SqlSP_Para");
            strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            strSQL.AppendFormat("insert into SqlSP_Para (mId, id_StoreProcedure, ParaName, ParaSize, ParaDataType, ParaDirection, IsNullable, SP_ID) values ({0}, {1}, '{2}', {3}, '{4}', '{5}', '{6}', {7})", mlngmId, mlngid_StoreProcedure, mstrParaName, mshtParaSize, mstrParaDataType, mstrParaDirection, mbolIsNullable, mlngSP_ID);
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
            arrFieldListForInsert.Add("id_StoreProcedure");
            arrValueListForInsert.Add(mlngid_StoreProcedure.ToString());
            if (mstrParaName != null)
            {
                arrFieldListForInsert.Add("ParaName");
                mstrParaName = mstrParaName.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrParaName + "'");
            }
            arrFieldListForInsert.Add("ParaSize");
            arrValueListForInsert.Add(mshtParaSize.ToString());
            if (mstrParaDataType != null)
            {
                arrFieldListForInsert.Add("ParaDataType");
                mstrParaDataType = mstrParaDataType.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrParaDataType + "'");
            }
            if (mstrParaDirection != null)
            {
                arrFieldListForInsert.Add("ParaDirection");
                mstrParaDirection = mstrParaDirection.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                arrValueListForInsert.Add("'" + mstrParaDirection + "'");
            }
            arrFieldListForInsert.Add("IsNullable");
            arrValueListForInsert.Add("'" + (mbolIsNullable == false ? "0" : "1") + "'");
            arrFieldListForInsert.Add("SP_ID");
            arrValueListForInsert.Add(mlngSP_ID.ToString());
            //��֯�����¼SQL��
            string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
            string strFieldListCode = string.Join(",", sstrFieldCode);
            string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
            string strValuesListCode = string.Join(",", sstrValuesCode);
            strSQL.Append("Insert into SqlSP_Para");
            strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            return objSQL.ExecSql(strSQL.ToString(), objSqlConnect, objSqlTransaction);
        }


        public bool AddnewSqlSP_ParaBySP()
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mlngid_StoreProcedure);
            values.Add(mstrParaName);
            values.Add(mshtParaSize);
            values.Add(mstrParaDataType);
            values.Add(mstrParaDirection);
            values.Add(mbolIsNullable);
            values.Add(mlngSP_ID);
            objSQL.ExecSP("SqlSP_Para_Add", values);
            return true;
        }

        /// <summary>
        /// �Ѷ�����¼ͬʱ���뵽����!
        /// </summary>
        /// <param name="oDT"></param>
        /// <param name="strResult"></param>
        /// <returns></returns>
        public bool AddnewSqlSP_Paras(System.Data.DataTable oDT, ref string strResult)
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            if (mintErrNo != 0)
            {
                strResult = "�����Ϊ��" + mintErrNo.ToString();
                return false;
            }
            strSQL = "Select * from SqlSP_Para where mId='111'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "SqlSP_Para");
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
                objRow = objDS.Tables["SqlSP_Para"].NewRow();
                objRow["id_StoreProcedure"] = oRow["id_StoreProcedure"].ToString().Trim(); //�洢������ˮ��
                objRow["ParaName"] = oRow["ParaName"].ToString().Trim(); //������
                objRow["ParaSize"] = oRow["ParaSize"].ToString().Trim(); //��������
                objRow["ParaDataType"] = oRow["ParaDataType"].ToString().Trim(); //������������
                objRow["ParaDirection"] = oRow["ParaDirection"].ToString().Trim(); //������������
                objRow["IsNullable"] = oRow["IsNullable"].ToString().Trim(); //�Ƿ�ɿ�
                objRow["SP_ID"] = oRow["SP_ID"].ToString().Trim(); //SP_ID
                objDS.Tables["SqlSP_Para"].Rows.Add(objRow);
            }
            try
            {
                objDA.Update(objDS, "SqlSP_Para");
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            strSQL = "Select * from SqlSP_Para where mId=" + "" + mlngmId + "";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "SqlSP_Para");
            if (objDS.Tables["SqlSP_Para"].Rows.Count == 0)
            {
                //MsgBox("û����Ӧ��ID�ţ�mId=" + ""+ mlngmId+"");
                return false;
            }
            objRow = objDS.Tables["SqlSP_Para"].Rows[0];
            if (htProperty.ContainsKey("id_StoreProcedure"))
            {
                objRow["id_StoreProcedure"] = mlngid_StoreProcedure; //�洢������ˮ��
            }
            if (htProperty.ContainsKey("ParaName"))
            {
                objRow["ParaName"] = mstrParaName; //������
            }
            if (htProperty.ContainsKey("ParaSize"))
            {
                objRow["ParaSize"] = mshtParaSize; //��������
            }
            if (htProperty.ContainsKey("ParaDataType"))
            {
                objRow["ParaDataType"] = mstrParaDataType; //������������
            }
            if (htProperty.ContainsKey("ParaDirection"))
            {
                objRow["ParaDirection"] = mstrParaDirection; //������������
            }
            if (htProperty.ContainsKey("IsNullable"))
            {
                objRow["IsNullable"] = mbolIsNullable; //�Ƿ�ɿ�
            }
            if (htProperty.ContainsKey("SP_ID"))
            {
                objRow["SP_ID"] = mlngSP_ID; //SP_ID
            }
            try
            {
                objDA.Update(objDS, "SqlSP_Para");
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
        public bool UpdateSqlSP_ParaBySP()
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mlngmId);
            values.Add(mlngid_StoreProcedure);
            values.Add(mstrParaName);
            values.Add(mshtParaSize);
            values.Add(mstrParaDataType);
            values.Add(mstrParaDirection);
            values.Add(mbolIsNullable);
            values.Add(mlngSP_ID);
            objSQL.ExecSP("SqlSP_Para_Update", values);
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            sbSQL.AppendFormat("Update SqlSP_Para Set ");
            sbSQL.AppendFormat("id_StoreProcedure = {0}", mlngid_StoreProcedure); //�洢������ˮ��
            sbSQL.AppendFormat(", ParaName = '{0}'", mstrParaName); //������
            sbSQL.AppendFormat(", ParaSize = {0}", mshtParaSize); //��������
            sbSQL.AppendFormat(", ParaDataType = '{0}'", mstrParaDataType); //������������
            sbSQL.AppendFormat(", ParaDirection = '{0}'", mstrParaDirection); //������������
            sbSQL.AppendFormat(", IsNullable = '{0}'", mbolIsNullable == true ? "1" : "0"); //�Ƿ�ɿ�
            sbSQL.AppendFormat(", SP_ID = {0}", mlngSP_ID); //SP_ID
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            sbSQL.AppendFormat("Update SqlSP_Para Set ");
            if (htProperty.ContainsKey("id_StoreProcedure"))
            {
                sbSQL.AppendFormat(" id_StoreProcedure = {0},", mlngid_StoreProcedure); //�洢������ˮ��
            }
            if (htProperty.ContainsKey("ParaName"))
            {
                mstrParaName = mstrParaName.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" ParaName = '{0}',", mstrParaName); //������
            }
            if (htProperty.ContainsKey("ParaSize"))
            {
                sbSQL.AppendFormat(" ParaSize = {0},", mshtParaSize); //��������
            }
            if (htProperty.ContainsKey("ParaDataType"))
            {
                mstrParaDataType = mstrParaDataType.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" ParaDataType = '{0}',", mstrParaDataType); //������������
            }
            if (htProperty.ContainsKey("ParaDirection"))
            {
                mstrParaDirection = mstrParaDirection.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" ParaDirection = '{0}',", mstrParaDirection); //������������
            }
            if (htProperty.ContainsKey("IsNullable"))
            {
                sbSQL.AppendFormat(" IsNullable = '{0}',", mbolIsNullable == true ? "1" : "0"); //�Ƿ�ɿ�
            }
            if (htProperty.ContainsKey("SP_ID"))
            {
                sbSQL.AppendFormat(" SP_ID = {0},", mlngSP_ID); //SP_ID
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            sbSQL.AppendFormat("Update SqlSP_Para Set ");
            sbSQL.AppendFormat("id_StoreProcedure = {0}", mlngid_StoreProcedure); //�洢������ˮ��
            sbSQL.AppendFormat(", ParaName = '{0}'", mstrParaName); //������
            sbSQL.AppendFormat(", ParaSize = {0}", mshtParaSize); //��������
            sbSQL.AppendFormat(", ParaDataType = '{0}'", mstrParaDataType); //������������
            sbSQL.AppendFormat(", ParaDirection = '{0}'", mstrParaDirection); //������������
            sbSQL.AppendFormat(", IsNullable = '{0}'", mbolIsNullable); //�Ƿ�ɿ�
            sbSQL.AppendFormat(", SP_ID = {0}", mlngSP_ID); //SP_ID
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            sbSQL.AppendFormat("Update SqlSP_Para Set ");
            if (htProperty.ContainsKey("id_StoreProcedure"))
            {
                sbSQL.AppendFormat(" id_StoreProcedure = {0},", mlngid_StoreProcedure); //�洢������ˮ��
            }
            if (htProperty.ContainsKey("ParaName"))
            {
                mstrParaName = mstrParaName.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" ParaName = '{0}',", mstrParaName); //������
            }
            if (htProperty.ContainsKey("ParaSize"))
            {
                sbSQL.AppendFormat(" ParaSize = {0},", mshtParaSize); //��������
            }
            if (htProperty.ContainsKey("ParaDataType"))
            {
                mstrParaDataType = mstrParaDataType.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" ParaDataType = '{0}',", mstrParaDataType); //������������
            }
            if (htProperty.ContainsKey("ParaDirection"))
            {
                mstrParaDirection = mstrParaDirection.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"
                sbSQL.AppendFormat(" ParaDirection = '{0}',", mstrParaDirection); //������������
            }
            if (htProperty.ContainsKey("IsNullable"))
            {
                sbSQL.AppendFormat(" IsNullable = '{0}',", mbolIsNullable == true ? "1" : "0"); //�Ƿ�ɿ�
            }
            if (htProperty.ContainsKey("SP_ID"))
            {
                sbSQL.AppendFormat(" SP_ID = {0},", mlngSP_ID); //SP_ID
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            int intRecCount;
            if (strCondition == "")
            {
                return 0; //��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
            }
            strSQL = "Select * from SqlSP_Para where " + strCondition;
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "SqlSP_Para");
            if (objDS.Tables["SqlSP_Para"].Rows.Count == 0)
            {
                return 0;
            }
            intRecCount = objDS.Tables["SqlSP_Para"].Rows.Count;
            foreach (System.Data.DataRow objRow in objDS.Tables["SqlSP_Para"].Rows)
            {
                objRow["id_StoreProcedure"] = mlngid_StoreProcedure; //�洢������ˮ��
                objRow["ParaName"] = mstrParaName; //������
                objRow["ParaSize"] = mshtParaSize; //��������
                objRow["ParaDataType"] = mstrParaDataType; //������������
                objRow["ParaDirection"] = mstrParaDirection; //������������
                objRow["IsNullable"] = mbolIsNullable; //�Ƿ�ɿ�
                objRow["SP_ID"] = mlngSP_ID; //SP_ID
            }
            try
            {
                objDA.Update(objDS, "SqlSP_Para");
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            //ɾ��SqlSP_Para�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from SqlSP_Para where mId=" + "" + mlngmId + "";
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mlngmId);
            objSQL.ExecSP("SqlSP_Para_Delete", values);
            return true;
        }

        public bool DelRecord(SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            //ɾ��SqlSP_Para�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from SqlSP_Para where mId=" + "" + mlngmId + "";
            return objSQL.ExecSql(strSQL, objSqlConnect, objSqlTransaction);
        }


        //ͬʱɾ��������¼
        public static bool DelSqlSP_Para(ArrayList lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
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
            //ɾ��SqlSP_Para�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from SqlSP_Para where mId in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }

        public static bool DelRecord(long lngmId)
        {
            //ɾ��������¼
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            //ɾ��SqlSP_Para�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from SqlSP_Para where mId=" + "" + lngmId + "";
            return objSQL.ExecSql(strSQL);
        }


        /// <summary>
        /// ���ܣ�ɾ��������¼����������ɾ��
        /// </summary>
        /// <param name="strCondition">��Ҫɾ���ļ�¼����</param>
        /// <returns>����ɾ���ļ�¼0��</returns>
        public static int DelSqlSP_Para(string strCondition)
        {
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            string strSQL;
            if (strCondition == "")
            {
                return 0;	//��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
            }
            else
            {
                strSQL = "Delete from SqlSP_Para where " + strCondition;
            }
            int intRecoCount = objSQL.ExecSql2(strSQL);
            return intRecoCount;
        }


        public bool GetSqlSP_Para()
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            strSQL = "Select * from SqlSP_Para where mId=" + "" + mlngmId + "";
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            mlngmId = Int32.Parse(objDT.Rows[0]["mId"].ToString().Trim()); //mId
            mlngid_StoreProcedure = Int32.Parse(objDT.Rows[0]["id_StoreProcedure"].ToString().Trim()); //�洢������ˮ��
            mstrParaName = objDT.Rows[0]["ParaName"].ToString().Trim(); //������
            mshtParaSize = short.Parse(objDT.Rows[0]["ParaSize"].ToString().Trim()); //��������
            mstrParaDataType = objDT.Rows[0]["ParaDataType"].ToString().Trim(); //������������
            mstrParaDirection = objDT.Rows[0]["ParaDirection"].ToString().Trim(); //������������
            mbolIsNullable = TransNullToBool(objDT.Rows[0]["IsNullable"].ToString().Trim()); //�Ƿ�ɿ�
            mlngSP_ID = Int32.Parse(objDT.Rows[0]["SP_ID"].ToString().Trim()); //SP_ID
            objDT = null;
            return true;
        }

        public bool GetSqlSP_ParaOneBySP()
        {
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mlngmId);
            objDT = objSQL.ExecSpReturnDT("SqlSP_Para_SelectOne", values);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            mlngmId = Int32.Parse(objDT.Rows[0]["mId"].ToString().Trim()); //mId
            mlngid_StoreProcedure = Int32.Parse(objDT.Rows[0]["id_StoreProcedure"].ToString().Trim()); //�洢������ˮ��
            mstrParaName = objDT.Rows[0]["ParaName"].ToString().Trim(); //������
            mshtParaSize = short.Parse(objDT.Rows[0]["ParaSize"].ToString().Trim()); //��������
            mstrParaDataType = objDT.Rows[0]["ParaDataType"].ToString().Trim(); //������������
            mstrParaDirection = objDT.Rows[0]["ParaDirection"].ToString().Trim(); //������������
            mbolIsNullable = TransNullToBool(objDT.Rows[0]["IsNullable"].ToString().Trim()); //�Ƿ�ɿ�
            mlngSP_ID = Int32.Parse(objDT.Rows[0]["SP_ID"].ToString().Trim()); //SP_ID
            objDT = null;
            return true;
        }

        public static System.Data.DataTable GetSqlSP_Para(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            strSQL = "Select * from SqlSP_Para where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        public static System.Data.DataTable GetSqlSP_ParaByCondBySP(string strCondition)
        {
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDT = objSQL.ExecSpReturnDT("SqlSP_Para_SelectByCond", values);
            return objDT;
        }

        public static System.Data.DataSet GetSqlSP_ParaDataSetByCondBySP(string strCondition)
        {
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDS = objSQL.ExecSPReturnDS("SqlSP_Para_SelectByCond", values, "SqlSP_Para");
            return objDS;
        }

        public static System.Data.DataSet GetDataSet_SqlSP_Para(string strCondition)
        {
            string strSQL;
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            strSQL = "Select * from SqlSP_Para where " + strCondition;
            objDS = objSQL.GetDataSet(strSQL, "SqlSP_Para");
            return objDS;
        }

        public static System.Data.DataSet GetDataSet_SqlSP_ParaByCondBySP(string strCondition)
        {
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDS = objSQL.ExecSPReturnDS("SqlSP_Para_SelectByCond", values, "SqlSP_Para");
            return objDS;
        }

        public static System.Data.DataSet GetDataSet_SqlSP_ParaV(string strCondition)
        {
            string strSQL;
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            strSQL = "Select * from vSqlSP_Para where " + strCondition;
            objDS = objSQL.GetDataSet(strSQL, "vSqlSP_Para");
            return objDS;
        }

        public ArrayList GetSqlSP_ParaObjList(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            strSQL = "Select * from SqlSP_Para where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsSqlSP_Para objSqlSP_Para = new clsSqlSP_Para();
                objSqlSP_Para.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //mId
                objSqlSP_Para.id_StoreProcedure = Int32.Parse(objRow["id_StoreProcedure"].ToString().Trim()); //�洢������ˮ��
                objSqlSP_Para.ParaName = objRow["ParaName"].ToString().Trim(); //������
                objSqlSP_Para.ParaSize = short.Parse(objRow["ParaSize"].ToString().Trim()); //��������
                objSqlSP_Para.ParaDataType = objRow["ParaDataType"].ToString().Trim(); //������������
                objSqlSP_Para.ParaDirection = objRow["ParaDirection"].ToString().Trim(); //������������
                objSqlSP_Para.IsNullable = TransNullToBool(objRow["IsNullable"].ToString().Trim()); //�Ƿ�ɿ�
                objSqlSP_Para.SP_ID = Int32.Parse(objRow["SP_ID"].ToString().Trim()); //SP_ID
                objSqlSP_Para.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ
                arrObjList.Add(objSqlSP_Para);
            }
            objDT = null;
            return arrObjList;
        }

        public ArrayList GetSqlSP_ParaObjListBySP(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDT = objSQL.ExecSpReturnDT("SqlSP_Para_SelectByCond", values);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsSqlSP_Para objSqlSP_Para = new clsSqlSP_Para();
                objSqlSP_Para.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //mId
                objSqlSP_Para.id_StoreProcedure = Int32.Parse(objRow["id_StoreProcedure"].ToString().Trim()); //�洢������ˮ��
                objSqlSP_Para.ParaName = objRow["ParaName"].ToString().Trim(); //������
                objSqlSP_Para.ParaSize = short.Parse(objRow["ParaSize"].ToString().Trim()); //��������
                objSqlSP_Para.ParaDataType = objRow["ParaDataType"].ToString().Trim(); //������������
                objSqlSP_Para.ParaDirection = objRow["ParaDirection"].ToString().Trim(); //������������
                objSqlSP_Para.IsNullable = TransNullToBool(objRow["IsNullable"].ToString().Trim()); //�Ƿ�ɿ�
                objSqlSP_Para.SP_ID = Int32.Parse(objRow["SP_ID"].ToString().Trim()); //SP_ID
                objSqlSP_Para.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ
                arrObjList.Add(objSqlSP_Para);
            }
            objDT = null;
            return arrObjList;
        }

        public clsSqlSP_Para GetFirstSqlSP_Para(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            strSQL = "Select * from SqlSP_Para where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            DataRow objRow = objDT.Rows[0];
            clsSqlSP_Para objSqlSP_Para = new clsSqlSP_Para();
            objSqlSP_Para.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //mId
            objSqlSP_Para.id_StoreProcedure = Int32.Parse(objRow["id_StoreProcedure"].ToString().Trim()); //�洢������ˮ��
            objSqlSP_Para.ParaName = objRow["ParaName"].ToString().Trim(); //������
            objSqlSP_Para.ParaSize = short.Parse(objRow["ParaSize"].ToString().Trim()); //��������
            objSqlSP_Para.ParaDataType = objRow["ParaDataType"].ToString().Trim(); //������������
            objSqlSP_Para.ParaDirection = objRow["ParaDirection"].ToString().Trim(); //������������
            objSqlSP_Para.IsNullable = TransNullToBool(objRow["IsNullable"].ToString().Trim()); //�Ƿ�ɿ�
            objSqlSP_Para.SP_ID = Int32.Parse(objRow["SP_ID"].ToString().Trim()); //SP_ID
            objSqlSP_Para.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ
            objDT = null;
            return objSqlSP_Para;
        }

        public clsSqlSP_Para GetFirstSqlSP_ParaBySP(string strCondition)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDT = objSQL.ExecSpReturnDT("SqlSP_Para_SelectTop1ByCond", values);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            DataRow objRow = objDT.Rows[0];
            clsSqlSP_Para objSqlSP_Para = new clsSqlSP_Para();
            objSqlSP_Para.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //mId
            objSqlSP_Para.id_StoreProcedure = Int32.Parse(objRow["id_StoreProcedure"].ToString().Trim()); //�洢������ˮ��
            objSqlSP_Para.ParaName = objRow["ParaName"].ToString().Trim(); //������
            objSqlSP_Para.ParaSize = short.Parse(objRow["ParaSize"].ToString().Trim()); //��������
            objSqlSP_Para.ParaDataType = objRow["ParaDataType"].ToString().Trim(); //������������
            objSqlSP_Para.ParaDirection = objRow["ParaDirection"].ToString().Trim(); //������������
            objSqlSP_Para.IsNullable = TransNullToBool(objRow["IsNullable"].ToString().Trim()); //�Ƿ�ɿ�
            objSqlSP_Para.SP_ID = Int32.Parse(objRow["SP_ID"].ToString().Trim()); //SP_ID
            objSqlSP_Para.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ
            objDT = null;
            return objSqlSP_Para;
        }



        /// <summary>
        /// ���ܣ���ȡĳһ��������ر���ͼ(View)
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>�����Ѿ�ת�������DataTable</returns>
        public static System.Data.DataTable GetSqlSP_ParaV(string strCondition)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            strSQL.Append("Select vSqlSP_Para.* ");
            strSQL.Append(" from vSqlSP_Para ");
            strSQL.Append(" where " + strCondition);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }


        public override bool IsExist()
        {
            clsSpecSQLforSql objSQL = null;
            //��ȡ���Ӷ���
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            if (objSQL.IsExistRecord("SqlSP_Para", "mId=" + "" + mlngmId + ""))
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            if (objSQL.IsExistRecord("SqlSP_Para", "mId=" + "" + lngmId + ""))
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysPara_PubDataBase.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(lngmId);
            string strIsExist = "";
            values.Add(strIsExist);
            ArrayList arrReturn = objSQL.ExecSpWithOutPut("SqlSP_Para_IsExist", values);
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
            if (Object.Equals(null, mlngid_StoreProcedure)
            || (!Object.Equals(null, mlngid_StoreProcedure) && mlngid_StoreProcedure.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[�洢������ˮ��]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrParaName)
            || (!Object.Equals(null, mstrParaName) && mstrParaName.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[������]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mshtParaSize)
            || (!Object.Equals(null, mshtParaSize) && mshtParaSize.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[��������]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrParaDataType)
            || (!Object.Equals(null, mstrParaDataType) && mstrParaDataType.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[������������]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrParaDirection)
            || (!Object.Equals(null, mstrParaDirection) && mstrParaDirection.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[������������]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mbolIsNullable)
            || (!Object.Equals(null, mbolIsNullable) && mbolIsNullable.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[�Ƿ�ɿ�]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mlngSP_ID)
            || (!Object.Equals(null, mlngSP_ID) && mlngSP_ID.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[SP_ID]����Ϊ��(NULL)!");
            }
            if (!Object.Equals(null, mstrParaName) && getStrLen(mstrParaName) > 50)
            {
                throw new clsDbObjException("�ֶ�[������]�ĳ��Ȳ��ܳ���50!");
            }
            if (!Object.Equals(null, mstrParaDataType) && getStrLen(mstrParaDataType) > 20)
            {
                throw new clsDbObjException("�ֶ�[������������]�ĳ��Ȳ��ܳ���20!");
            }
            if (!Object.Equals(null, mstrParaDirection) && getStrLen(mstrParaDirection) > 20)
            {
                throw new clsDbObjException("�ֶ�[������������]�ĳ��Ȳ��ܳ���20!");
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            int iRow, iCol;
            string strKeyValue;
            strSQL = "Select mId from SqlSP_Para where " + strCondtion;
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            string strKeyValue;
            strSQL = "Select mId from SqlSP_Para where " + strCondtion;
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
            objSQL = clsSqlSP_Para.GetSpecSQLObj();
            string strKeyValue;
            strSQL = "Select mId from SqlSP_Para where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsSqlSP_Para");
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return new clsSqlSP_Para().TransNullToInt(null);
            }
            strKeyValue = objDT.Rows[0][0].ToString();
            objDT = null;
            return long.Parse(strKeyValue);
        }
    }
}