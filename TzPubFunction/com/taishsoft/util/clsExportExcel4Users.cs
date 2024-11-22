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
        public const string CurrTabName_S = "ExportExcel4Users";    //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "id_ExportExcel4Users";    //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 4;
        public static string[] AttributeName = new string[] { "id_ExportExcel4Users", "UserID", "ViewName", "FieldName" };
        //以下是属性变量

        protected string mstrid_ExportExcel4Users;    //导出Excel用户字段流水号
        protected string mstrUserID;    //用户代号
        protected string mstrViewName;    //界面名称
        protected string mstrFieldName;    //字段名

        //用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
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
        /// 导出Excel用户字段流水号
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
        /// 用户代号
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
        /// 界面名称
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
        /// 字段名
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
        /// 添加新记录
        /// </summary>
        /// <returns>添加是否成功?</returns>
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
            objRow["id_ExportExcel4Users"] = mstrid_ExportExcel4Users;    //导出Excel用户字段流水号
            objRow["UserID"] = mstrUserID;    //用户代号
            objRow["ViewName"] = mstrViewName;    //界面名称
            objRow["FieldName"] = mstrFieldName;    //字段名
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
        /// 功能：通过SQL命令来插入记录
        ///       主要用于上传文件时。
        /// </summary>
        /// <returns>如果插入成功则返回TRUE，否则为FALSE</returns>
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
            //通过存储过程来
            //直接使用
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
        /// 把多条记录同时插入到表中!
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
                strResult = "错误号为：" + mintErrNo.ToString();
                return false;
            }
            strSQL = "Select * from ExportExcel4Users where id_ExportExcel4Users='111'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "ExportExcel4Users");
            //检查关键字的唯一性
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                string strid_ExportExcel4Users = oRow["id_ExportExcel4Users"].ToString().Trim();
                if (IsExist(strid_ExportExcel4Users))
                {
                    strResult = "关键字id_ExportExcel4Users为：" + strid_ExportExcel4Users + "的记录已存在，不能重复插入!";
                    return false;
                }
            }
            //把多条记录插入到表中
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                objRow = objDS.Tables["ExportExcel4Users"].NewRow();
                objRow["id_ExportExcel4Users"] = oRow["id_ExportExcel4Users"].ToString().Trim();    //导出Excel用户字段流水号
                objRow["UserID"] = oRow["UserID"].ToString().Trim();    //用户代号
                objRow["ViewName"] = oRow["ViewName"].ToString().Trim();    //界面名称
                objRow["FieldName"] = oRow["FieldName"].ToString().Trim();    //字段名
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
                //MsgBox("没有相应的ID号：id_ExportExcel4Users=" + "'"+ mstrid_ExportExcel4Users+"'");
                return false;
            }
            objRow = objDS.Tables["ExportExcel4Users"].Rows[0];
            objRow["UserID"] = mstrUserID;       //用户代号
            objRow["ViewName"] = mstrViewName;       //界面名称
            objRow["FieldName"] = mstrFieldName;       //字段名
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
            sbSQL.AppendFormat("UserID = '{0}'", mstrUserID);       //用户代号
            sbSQL.AppendFormat(", ViewName = '{0}'", mstrViewName);       //界面名称
            sbSQL.AppendFormat(", FieldName = '{0}'", mstrFieldName);       //字段名
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
        /// 功能：修改多条记录
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
                return 0;   //表示删除0条记录，实际上是不能该表的所有记录
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
                objRow["UserID"] = mstrUserID;    //用户代号
                objRow["ViewName"] = mstrViewName;    //界面名称
                objRow["FieldName"] = mstrFieldName;    //字段名
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
            //删除ExportExcel4Users本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from ExportExcel4Users where id_ExportExcel4Users=" + "'" + mstrid_ExportExcel4Users + "'";
            return objSQL.ExecSql(strSQL);
        }


        //同时删除多条记录
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
            //删除ExportExcel4Users本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from ExportExcel4Users where id_ExportExcel4Users in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }

        public static bool DelRecord(string strid_ExportExcel4Users)
        {
            //删除单条记录
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
            //删除ExportExcel4Users本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from ExportExcel4Users where id_ExportExcel4Users=" + "'" + strid_ExportExcel4Users + "'";
            return objSQL.ExecSql(strSQL);
        }


        /// <summary>
        /// 功能：删除多条记录，带条件的删除
        /// </summary>
        /// <param name="strCondition">需要删除的记录条件</param>
        /// <returns>返回删除的记录0。</returns>
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
                return 0;	//表示删除0条记录，实际上是不能该表的所有记录
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
            mstrid_ExportExcel4Users = objDT.Rows[0]["id_ExportExcel4Users"].ToString().Trim();       //导出Excel用户字段流水号
            mstrUserID = objDT.Rows[0]["UserID"].ToString().Trim();       //用户代号
            mstrViewName = objDT.Rows[0]["ViewName"].ToString().Trim();       //界面名称
            mstrFieldName = objDT.Rows[0]["FieldName"].ToString().Trim();       //字段名
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
                objExportExcel4Users.id_ExportExcel4Users = objRow["id_ExportExcel4Users"].ToString().Trim();     //导出Excel用户字段流水号
                objExportExcel4Users.UserID = objRow["UserID"].ToString().Trim();     //用户代号
                objExportExcel4Users.ViewName = objRow["ViewName"].ToString().Trim();     //界面名称
                objExportExcel4Users.FieldName = objRow["FieldName"].ToString().Trim();     //字段名
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
            objExportExcel4Users.id_ExportExcel4Users = objRow["id_ExportExcel4Users"].ToString().Trim();     //导出Excel用户字段流水号
            objExportExcel4Users.UserID = objRow["UserID"].ToString().Trim();     //用户代号
            objExportExcel4Users.ViewName = objRow["ViewName"].ToString().Trim();     //界面名称
            objExportExcel4Users.FieldName = objRow["FieldName"].ToString().Trim();     //字段名
            objDT = null;
            return objExportExcel4Users;
        }



        /// <summary>
        /// 功能：获取某一条件的相关表视图(View)
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
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
        /// 判断当前表中是否存在给定关键字值的记录
        /// </summary>
        /// <param name="strid_ExportExcel4Users">给定的关键字值</param>
        /// <returns>返回是否存在?</returns>
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
        /// 检查字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
        /// </summary>
        public void CheckPropertyNew()
        {
            if (Object.Equals(null, mstrid_ExportExcel4Users)
            || (!Object.Equals(null, mstrid_ExportExcel4Users) && mstrid_ExportExcel4Users.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[导出Excel用户字段流水号]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrUserID)
            || (!Object.Equals(null, mstrUserID) && mstrUserID.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[用户代号]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrViewName)
            || (!Object.Equals(null, mstrViewName) && mstrViewName.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[界面名称]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrFieldName)
            || (!Object.Equals(null, mstrFieldName) && mstrFieldName.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[字段名]不能为空(NULL)!");
            }
            if (!Object.Equals(null, mstrid_ExportExcel4Users) && getStrLen(mstrid_ExportExcel4Users) > 8)
            {
                throw new clsDbObjException("字段[导出Excel用户字段流水号]的长度不能超过8!");
            }
            if (!Object.Equals(null, mstrUserID) && getStrLen(mstrUserID) > 20)
            {
                throw new clsDbObjException("字段[用户代号]的长度不能超过20!");
            }
            if (!Object.Equals(null, mstrViewName) && getStrLen(mstrViewName) > 50)
            {
                throw new clsDbObjException("字段[界面名称]的长度不能超过50!");
            }
            if (!Object.Equals(null, mstrFieldName) && getStrLen(mstrFieldName) > 50)
            {
                throw new clsDbObjException("字段[字段名]的长度不能超过50!");
            }
        }


        /// <summary>
        /// 获取当前表满足条件的所有记录的关键字值列表
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>返回的关键字值列表</returns>
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
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
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
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
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