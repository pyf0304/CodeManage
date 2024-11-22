using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commexception;
using SpecData;
namespace com.taishsoft.util
{
    public class clsExportExcel4Users : clsGeneralTab
    {
        public const string CurrTabName_S = "ExportExcel4Users";    //��ǰ�������������صı���
        public const string CurrTabKeyFldName_S = "id_ExportExcel4Users";    //��ǰ���еĹؼ������ƣ��������صı��йؼ�����
        protected const int mintAttributeCount = 4;
        public static string[] AttributeName = new string[] { "id_ExportExcel4Users", "UserID", "ViewName", "FieldName" };
        //���������Ա���

        protected string mstrid_ExportExcel4Users;    //����Excel�û��ֶ���ˮ��
        protected string mstrUserID;    //�û�����
        protected string mstrViewName;    //��������
        protected string mstrFieldName;    //�ֶ���

        //�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�
        private static string m_strConnectString;
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }

        public clsExportExcel4Users()
        {
            SetInit();
            CurrTabName = "ExportExcel4Users";
            KeyFldName = "id_ExportExcel4Users";
        }

        public clsExportExcel4Users(string strid_ExportExcel4Users)
        {

            mstrid_ExportExcel4Users = strid_ExportExcel4Users;
            SetInit();
            CurrTabName = "ExportExcel4Users";
            KeyFldName = "id_ExportExcel4Users";
        }

        public clsExportExcel4Users(string strid_ExportExcel4Users, bool bolIsGetExportExcel4Users)
        {

            mstrid_ExportExcel4Users = strid_ExportExcel4Users;
            SetInit();
            if (bolIsGetExportExcel4Users == true)
            {
                GetExportExcel4Users();
            }
            CurrTabName = "ExportExcel4Users";
            KeyFldName = "id_ExportExcel4Users";
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
                if (strAttributeName == "id_ExportExcel4Users")
                {
                    return mstrid_ExportExcel4Users;
                }
                else if (strAttributeName == "UserID")
                {
                    return mstrUserID;
                }
                else if (strAttributeName == "ViewName")
                {
                    return mstrViewName;
                }
                else if (strAttributeName == "FieldName")
                {
                    return mstrFieldName;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "id_ExportExcel4Users")
                {
                    mstrid_ExportExcel4Users = value.ToString();
                }
                else if (strAttributeName == "UserID")
                {
                    mstrUserID = value.ToString();
                }
                else if (strAttributeName == "ViewName")
                {
                    mstrViewName = value.ToString();
                }
                else if (strAttributeName == "FieldName")
                {
                    mstrFieldName = value.ToString();
                }
            }
        }
        public object this[int intIndex]
        {
            get
            {
                if ("id_ExportExcel4Users" == AttributeName[intIndex])
                {
                    return mstrid_ExportExcel4Users;
                }
                else if ("UserID" == AttributeName[intIndex])
                {
                    return mstrUserID;
                }
                else if ("ViewName" == AttributeName[intIndex])
                {
                    return mstrViewName;
                }
                else if ("FieldName" == AttributeName[intIndex])
                {
                    return mstrFieldName;
                }
                return null;
            }
            set
            {
                if ("id_ExportExcel4Users" == AttributeName[intIndex])
                {
                    mstrid_ExportExcel4Users = value.ToString();
                }
                else if ("UserID" == AttributeName[intIndex])
                {
                    mstrUserID = value.ToString();
                }
                else if ("ViewName" == AttributeName[intIndex])
                {
                    mstrViewName = value.ToString();
                }
                else if ("FieldName" == AttributeName[intIndex])
                {
                    mstrFieldName = value.ToString();
                }
            }
        }

        /// <summary>
        /// ����Excel�û��ֶ���ˮ��
        /// </summary>
        public string id_ExportExcel4Users
        {
            get
            {
                return mstrid_ExportExcel4Users;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrid_ExportExcel4Users = value;
                }
                else
                {
                    mstrid_ExportExcel4Users = value;
                }
            }
        }
        /// <summary>
        /// �û�����
        /// </summary>
        public string UserID
        {
            get
            {
                return mstrUserID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrUserID = value;
                }
                else
                {
                    mstrUserID = value;
                }
            }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string ViewName
        {
            get
            {
                return mstrViewName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrViewName = value;
                }
                else
                {
                    mstrViewName = value;
                }
            }
        }
        /// <summary>
        /// �ֶ���
        /// </summary>
        public string FieldName
        {
            get
            {
                return mstrFieldName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFieldName = value;
                }
                else
                {
                    mstrFieldName = value;
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
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            strSQL = "Select * from ExportExcel4Users where 1=2";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "ExportExcel4Users");
            objRow = objDS.Tables["ExportExcel4Users"].NewRow();
            objRow["id_ExportExcel4Users"] = mstrid_ExportExcel4Users;    //����Excel�û��ֶ���ˮ��
            objRow["UserID"] = mstrUserID;    //�û�����
            objRow["ViewName"] = mstrViewName;    //��������
            objRow["FieldName"] = mstrFieldName;    //�ֶ���
            objDS.Tables["ExportExcel4Users"].Rows.Add(objRow);
            try
            {
                objDA.Update(objDS, "ExportExcel4Users");
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
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            strSQL.AppendFormat("insert into ExportExcel4Users (id_ExportExcel4Users, UserID, ViewName, FieldName) values ('{0}', '{1}', '{2}', '{3}')", mstrid_ExportExcel4Users, mstrUserID, mstrViewName, mstrFieldName);
            return objSQL.ExecSql(strSQL.ToString());
        }


        public bool AddnewExportExcel4UsersBySP()
        {
            //ͨ���洢������
            //ֱ��ʹ��
            if (mintErrNo != 0)
            {
                //MsgBox(mstrErrMsg(mintErrNo))
                return false;
            }
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            objSQL.SPConfigXMLFile = "..\\XML\\XMLSP.xml";
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(mstrid_ExportExcel4Users);
            values.Add(mstrUserID);
            values.Add(mstrViewName);
            values.Add(mstrFieldName);
            objSQL.ExecSP("AddnewExportExcel4Users", values);
            return true;
        }

        /// <summary>
        /// �Ѷ�����¼ͬʱ���뵽����!
        /// </summary>
        /// <param name="oDT"></param>
        /// <param name="strResult"></param>
        /// <returns></returns>
        public bool AddnewExportExcel4Userss(System.Data.DataTable oDT, ref string strResult)
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow;
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            if (mintErrNo != 0)
            {
                strResult = "�����Ϊ��" + mintErrNo.ToString();
                return false;
            }
            strSQL = "Select * from ExportExcel4Users where id_ExportExcel4Users='111'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "ExportExcel4Users");
            //���ؼ��ֵ�Ψһ��
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                string strid_ExportExcel4Users = oRow["id_ExportExcel4Users"].ToString().Trim();
                if (IsExist(strid_ExportExcel4Users))
                {
                    strResult = "�ؼ���id_ExportExcel4UsersΪ��" + strid_ExportExcel4Users + "�ļ�¼�Ѵ��ڣ������ظ�����!";
                    return false;
                }
            }
            //�Ѷ�����¼���뵽����
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                objRow = objDS.Tables["ExportExcel4Users"].NewRow();
                objRow["id_ExportExcel4Users"] = oRow["id_ExportExcel4Users"].ToString().Trim();    //����Excel�û��ֶ���ˮ��
                objRow["UserID"] = oRow["UserID"].ToString().Trim();    //�û�����
                objRow["ViewName"] = oRow["ViewName"].ToString().Trim();    //��������
                objRow["FieldName"] = oRow["FieldName"].ToString().Trim();    //�ֶ���
                objDS.Tables["ExportExcel4Users"].Rows.Add(objRow);
            }
            try
            {
                objDA.Update(objDS, "ExportExcel4Users");
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
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            strSQL = "Select * from ExportExcel4Users where id_ExportExcel4Users=" + "'" + mstrid_ExportExcel4Users + "'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "ExportExcel4Users");
            if (objDS.Tables["ExportExcel4Users"].Rows.Count == 0)
            {
                //MsgBox("û����Ӧ��ID�ţ�id_ExportExcel4Users=" + "'"+ mstrid_ExportExcel4Users+"'");
                return false;
            }
            objRow = objDS.Tables["ExportExcel4Users"].Rows[0];
            objRow["UserID"] = mstrUserID;       //�û�����
            objRow["ViewName"] = mstrViewName;       //��������
            objRow["FieldName"] = mstrFieldName;       //�ֶ���
            try
            {
                objDA.Update(objDS, "ExportExcel4Users");
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
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            sbSQL.AppendFormat("Update ExportExcel4Users Set ");
            sbSQL.AppendFormat("UserID = '{0}'", mstrUserID);       //�û�����
            sbSQL.AppendFormat(", ViewName = '{0}'", mstrViewName);       //��������
            sbSQL.AppendFormat(", FieldName = '{0}'", mstrFieldName);       //�ֶ���
            sbSQL.AppendFormat("Where id_ExportExcel4Users = '{0}'", mstrid_ExportExcel4Users);
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
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            int intRecCount;
            if (strCondition == "")
            {
                return 0;   //��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
            }
            strSQL = "Select * from ExportExcel4Users where " + strCondition;
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "ExportExcel4Users");
            if (objDS.Tables["ExportExcel4Users"].Rows.Count == 0)
            {
                return 0;
            }
            intRecCount = objDS.Tables["ExportExcel4Users"].Rows.Count;
            foreach (System.Data.DataRow objRow in objDS.Tables["ExportExcel4Users"].Rows)
            {
                objRow["UserID"] = mstrUserID;    //�û�����
                objRow["ViewName"] = mstrViewName;    //��������
                objRow["FieldName"] = mstrFieldName;    //�ֶ���
            }
            try
            {
                objDA.Update(objDS, "ExportExcel4Users");
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
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            //ɾ��ExportExcel4Users�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from ExportExcel4Users where id_ExportExcel4Users=" + "'" + mstrid_ExportExcel4Users + "'";
            return objSQL.ExecSql(strSQL);
        }


        //ͬʱɾ��������¼
        public static bool DelExportExcel4Users(ArrayList lstKey)
        {
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
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
            //ɾ��ExportExcel4Users�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from ExportExcel4Users where id_ExportExcel4Users in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }

        public static bool DelRecord(string strid_ExportExcel4Users)
        {
            //ɾ��������¼
            string strSQL = "";
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            //ɾ��ExportExcel4Users�������뵱ǰ�����йصļ�¼
            strSQL = strSQL + "Delete from ExportExcel4Users where id_ExportExcel4Users=" + "'" + strid_ExportExcel4Users + "'";
            return objSQL.ExecSql(strSQL);
        }


        /// <summary>
        /// ���ܣ�ɾ��������¼����������ɾ��
        /// </summary>
        /// <param name="strCondition">��Ҫɾ���ļ�¼����</param>
        /// <returns>����ɾ���ļ�¼0��</returns>
        public static int DelExportExcel4Users(string strCondition)
        {
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            string strSQL;
            if (strCondition == "")
            {
                return 0;	//��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
            }
            else
            {
                strSQL = "Delete from ExportExcel4Users where " + strCondition;
            }
            int intRecoCount = objSQL.ExecSql2(strSQL);
            return intRecoCount;
        }


        public bool GetExportExcel4Users()
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            strSQL = "Select * from ExportExcel4Users where id_ExportExcel4Users=" + "'" + mstrid_ExportExcel4Users + "'";
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            mstrid_ExportExcel4Users = objDT.Rows[0]["id_ExportExcel4Users"].ToString().Trim();       //����Excel�û��ֶ���ˮ��
            mstrUserID = objDT.Rows[0]["UserID"].ToString().Trim();       //�û�����
            mstrViewName = objDT.Rows[0]["ViewName"].ToString().Trim();       //��������
            mstrFieldName = objDT.Rows[0]["FieldName"].ToString().Trim();       //�ֶ���
            objDT = null;
            return true;
        }

        public static System.Data.DataTable GetExportExcel4Users(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            strSQL = "Select * from ExportExcel4Users where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        public ArrayList GetExportExcel4UsersObjList(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            strSQL = "Select * from ExportExcel4Users where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsExportExcel4Users objExportExcel4Users = new clsExportExcel4Users();
                objExportExcel4Users.id_ExportExcel4Users = objRow["id_ExportExcel4Users"].ToString().Trim();     //����Excel�û��ֶ���ˮ��
                objExportExcel4Users.UserID = objRow["UserID"].ToString().Trim();     //�û�����
                objExportExcel4Users.ViewName = objRow["ViewName"].ToString().Trim();     //��������
                objExportExcel4Users.FieldName = objRow["FieldName"].ToString().Trim();     //�ֶ���
                arrObjList.Add(objExportExcel4Users);
            }
            objDT = null;
            return arrObjList;
        }

        public clsExportExcel4Users GetFirstExportExcel4Users(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            strSQL = "Select * from ExportExcel4Users where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            DataRow objRow = objDT.Rows[0];
            clsExportExcel4Users objExportExcel4Users = new clsExportExcel4Users();
            objExportExcel4Users.id_ExportExcel4Users = objRow["id_ExportExcel4Users"].ToString().Trim();     //����Excel�û��ֶ���ˮ��
            objExportExcel4Users.UserID = objRow["UserID"].ToString().Trim();     //�û�����
            objExportExcel4Users.ViewName = objRow["ViewName"].ToString().Trim();     //��������
            objExportExcel4Users.FieldName = objRow["FieldName"].ToString().Trim();     //�ֶ���
            objDT = null;
            return objExportExcel4Users;
        }



        /// <summary>
        /// ���ܣ���ȡĳһ��������ر���ͼ(View)
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>�����Ѿ�ת�������DataTable</returns>
        public static System.Data.DataTable GetExportExcel4UsersV(string strCondition)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            strSQL.Append("Select vExportExcel4Users.* ");
            strSQL.Append(" from vExportExcel4Users ");
            strSQL.Append(" where " + strCondition);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }


        public override bool IsExist()
        {
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            if (objSQL.IsExistRecord("ExportExcel4Users", "id_ExportExcel4Users=" + "'" + mstrid_ExportExcel4Users + "'"))
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
        /// <param name="strid_ExportExcel4Users">�����Ĺؼ���ֵ</param>
        /// <returns>�����Ƿ����?</returns>
        public static bool IsExist(string strid_ExportExcel4Users)
        {
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            if (objSQL.IsExistRecord("ExportExcel4Users", "id_ExportExcel4Users=" + "'" + strid_ExportExcel4Users + "'"))
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
            if (Object.Equals(null, mstrid_ExportExcel4Users)
            || (!Object.Equals(null, mstrid_ExportExcel4Users) && mstrid_ExportExcel4Users.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[����Excel�û��ֶ���ˮ��]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrUserID)
            || (!Object.Equals(null, mstrUserID) && mstrUserID.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[�û�����]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrViewName)
            || (!Object.Equals(null, mstrViewName) && mstrViewName.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[��������]����Ϊ��(NULL)!");
            }
            if (Object.Equals(null, mstrFieldName)
            || (!Object.Equals(null, mstrFieldName) && mstrFieldName.ToString() == "")
            )
            {
                throw new clsDbObjException("�ֶ�[�ֶ���]����Ϊ��(NULL)!");
            }
            if (!Object.Equals(null, mstrid_ExportExcel4Users) && getStrLen(mstrid_ExportExcel4Users) > 8)
            {
                throw new clsDbObjException("�ֶ�[����Excel�û��ֶ���ˮ��]�ĳ��Ȳ��ܳ���8!");
            }
            if (!Object.Equals(null, mstrUserID) && getStrLen(mstrUserID) > 20)
            {
                throw new clsDbObjException("�ֶ�[�û�����]�ĳ��Ȳ��ܳ���20!");
            }
            if (!Object.Equals(null, mstrViewName) && getStrLen(mstrViewName) > 50)
            {
                throw new clsDbObjException("�ֶ�[��������]�ĳ��Ȳ��ܳ���50!");
            }
            if (!Object.Equals(null, mstrFieldName) && getStrLen(mstrFieldName) > 50)
            {
                throw new clsDbObjException("�ֶ�[�ֶ���]�ĳ��Ȳ��ܳ���50!");
            }
        }


        /// <summary>
        /// ��ȡ��ǰ���������������м�¼�Ĺؼ���ֵ�б�
        /// </summary>
        /// <param name="strCondtion">������</param>
        /// <returns>���صĹؼ���ֵ�б�</returns>
        public override ArrayList GetID(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            ArrayList arrList = new ArrayList();
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            int iRow, iCol;
            string strKeyValue;
            strSQL = "Select id_ExportExcel4Users from ExportExcel4Users where " + strCondtion;
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
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            string strKeyValue;
            strSQL = "Select id_ExportExcel4Users from ExportExcel4Users where " + strCondtion;
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
            clsSpecSQL objSQL = null;
            if (string.IsNullOrEmpty(clsExportExcel4Users.ConnectString) == true)
            {
                objSQL = new clsSpecSQL();
            }
            else
            {
                objSQL = new clsSpecSQL(clsExportExcel4Users.ConnectString);
            }
            string strKeyValue;
            strSQL = "Select id_ExportExcel4Users from ExportExcel4Users where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsExportExcel4Users");
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