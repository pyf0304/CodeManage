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
        public const string CurrTabName_S = "PrjDataBase";    //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "PrjDataBaseId";    //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 13;
        public static string[] AttributeName = new string[] { "PrjDataBaseId", "PrjDataBaseName", "DataBaseName", "DatabaseOwner", "DataBasePwd", "DataBaseTypeId", "DataBaseUserId", "IpAddress", "SID", "TableSpace", "UserId", "UpdDate", "Memo" };
        //以下是属性变量

        protected string mstrPrjDataBaseId;    //项目数据库Id
        protected string mstrPrjDataBaseName;    //项目数据库名
        protected string mstrDataBaseName;    //数据库名
        protected string mstrDatabaseOwner;    //数据库拥有者
        protected string mstrDataBasePwd;    //数据库的用户口令
        protected string mstrDataBaseTypeId;    //数据库类型ID
        protected string mstrDataBaseUserId;    //数据库的用户ID
        protected string mstrIpAddress;    //服务器
        protected string mstrSID;    //SID
        protected string mstrTableSpace;    //表空间
        protected string mstrUserId;    //用户ID
        protected string mstrUpdDate;    //修改日期
        protected string mstrMemo;    //备注

        //用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
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
        /// 项目数据库Id
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
        /// 项目数据库名
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
        /// 数据库名
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
        /// 数据库拥有者
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
        /// 数据库的用户口令
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
        /// 数据库类型ID
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
        /// 数据库的用户ID
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
        /// 服务器
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
        /// 表空间
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
        /// 用户ID
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
        /// 修改日期
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
            objRow["PrjDataBaseId"] = mstrPrjDataBaseId;    //项目数据库Id
            if (mstrPrjDataBaseName != "")
            {
                objRow["PrjDataBaseName"] = mstrPrjDataBaseName;   //项目数据库名
            }
            if (mstrDataBaseName != "")
            {
                objRow["DataBaseName"] = mstrDataBaseName;   //数据库名
            }
            if (mstrDatabaseOwner != "")
            {
                objRow["DatabaseOwner"] = mstrDatabaseOwner;   //数据库拥有者
            }
            if (mstrDataBasePwd != "")
            {
                objRow["DataBasePwd"] = mstrDataBasePwd;   //数据库的用户口令
            }
            if (mstrDataBaseTypeId != "")
            {
                objRow["DataBaseTypeId"] = mstrDataBaseTypeId;   //数据库类型ID
            }
            if (mstrDataBaseUserId != "")
            {
                objRow["DataBaseUserId"] = mstrDataBaseUserId;   //数据库的用户ID
            }
            if (mstrIpAddress != "")
            {
                objRow["IpAddress"] = mstrIpAddress;   //服务器
            }
            if (mstrSID != "")
            {
                objRow["SID"] = mstrSID;   //SID
            }
            if (mstrTableSpace != "")
            {
                objRow["TableSpace"] = mstrTableSpace;   //表空间
            }
            if (mstrUserId != "")
            {
                objRow["UserId"] = mstrUserId;   //用户ID
            }
            if (mstrUpdDate != "")
            {
                objRow["UpdDate"] = mstrUpdDate;   //修改日期
            }
            if (mstrMemo != "")
            {
                objRow["Memo"] = mstrMemo;   //备注
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
        /// 功能：通过SQL命令来插入记录
        ///       主要用于上传文件时。
        /// </summary>
        /// <returns>如果插入成功则返回TRUE，否则为FALSE</returns>
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
            //通过存储过程来
            //直接使用
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
        /// 把多条记录同时插入到表中!
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
                strResult = "错误号为：" + mintErrNo.ToString();
                return false;
            }
            strSQL = "Select * from PrjDataBase where PrjDataBaseId='111'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "PrjDataBase");
            //检查关键字的唯一性
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                string strPrjDataBaseId = oRow["PrjDataBaseId"].ToString().Trim();
                if (IsExist(strPrjDataBaseId))
                {
                    strResult = "关键字PrjDataBaseId为：" + strPrjDataBaseId + "的记录已存在，不能重复插入!";
                    return false;
                }
            }
            //把多条记录插入到表中
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                objRow = objDS.Tables["PrjDataBase"].NewRow();
                objRow["PrjDataBaseId"] = oRow["PrjDataBaseId"].ToString().Trim();    //项目数据库Id
                objRow["PrjDataBaseName"] = oRow["PrjDataBaseName"].ToString().Trim();    //项目数据库名
                objRow["DataBaseName"] = oRow["DataBaseName"].ToString().Trim();    //数据库名
                objRow["DatabaseOwner"] = oRow["DatabaseOwner"].ToString().Trim();    //数据库拥有者
                objRow["DataBasePwd"] = oRow["DataBasePwd"].ToString().Trim();    //数据库的用户口令
                objRow["DataBaseTypeId"] = oRow["DataBaseTypeId"].ToString().Trim();    //数据库类型ID
                objRow["DataBaseUserId"] = oRow["DataBaseUserId"].ToString().Trim();    //数据库的用户ID
                objRow["IpAddress"] = oRow["IpAddress"].ToString().Trim();    //服务器
                objRow["SID"] = oRow["SID"].ToString().Trim();    //SID
                objRow["TableSpace"] = oRow["TableSpace"].ToString().Trim();    //表空间
                objRow["UserId"] = oRow["UserId"].ToString().Trim();    //用户ID
                objRow["UpdDate"] = oRow["UpdDate"].ToString().Trim();    //修改日期
                objRow["Memo"] = oRow["Memo"].ToString().Trim();    //备注
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
                //MsgBox("没有相应的ID号：PrjDataBaseId=" + "'"+ mstrPrjDataBaseId+"'");
                return false;
            }
            objRow = objDS.Tables["PrjDataBase"].Rows[0];
            if (mstrPrjDataBaseName != "")
            {
                objRow["PrjDataBaseName"] = mstrPrjDataBaseName;    //项目数据库名
            }
            if (mstrDataBaseName != "")
            {
                objRow["DataBaseName"] = mstrDataBaseName;    //数据库名
            }
            if (mstrDatabaseOwner != "")
            {
                objRow["DatabaseOwner"] = mstrDatabaseOwner;    //数据库拥有者
            }
            if (mstrDataBasePwd != "")
            {
                objRow["DataBasePwd"] = mstrDataBasePwd;    //数据库的用户口令
            }
            if (mstrDataBaseTypeId != "")
            {
                objRow["DataBaseTypeId"] = mstrDataBaseTypeId;    //数据库类型ID
            }
            if (mstrDataBaseUserId != "")
            {
                objRow["DataBaseUserId"] = mstrDataBaseUserId;    //数据库的用户ID
            }
            if (mstrIpAddress != "")
            {
                objRow["IpAddress"] = mstrIpAddress;    //服务器
            }
            if (mstrSID != "")
            {
                objRow["SID"] = mstrSID;    //SID
            }
            if (mstrTableSpace != "")
            {
                objRow["TableSpace"] = mstrTableSpace;    //表空间
            }
            if (mstrUserId != "")
            {
                objRow["UserId"] = mstrUserId;    //用户ID
            }
            if (mstrUpdDate != "")
            {
                objRow["UpdDate"] = mstrUpdDate;    //修改日期
            }
            if (mstrMemo != "")
            {
                objRow["Memo"] = mstrMemo;    //备注
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
            sbSQL.AppendFormat("PrjDataBaseName = '{0}'", mstrPrjDataBaseName);       //项目数据库名
            sbSQL.AppendFormat(", DataBaseName = '{0}'", mstrDataBaseName);       //数据库名
            sbSQL.AppendFormat(", DatabaseOwner = '{0}'", mstrDatabaseOwner);       //数据库拥有者
            sbSQL.AppendFormat(", DataBasePwd = '{0}'", mstrDataBasePwd);       //数据库的用户口令
            sbSQL.AppendFormat(", DataBaseTypeId = '{0}'", mstrDataBaseTypeId);       //数据库类型ID
            sbSQL.AppendFormat(", DataBaseUserId = '{0}'", mstrDataBaseUserId);       //数据库的用户ID
            sbSQL.AppendFormat(", IpAddress = '{0}'", mstrIpAddress);       //服务器
            sbSQL.AppendFormat(", SID = '{0}'", mstrSID);       //SID
            sbSQL.AppendFormat(", TableSpace = '{0}'", mstrTableSpace);       //表空间
            sbSQL.AppendFormat(", UserId = '{0}'", mstrUserId);       //用户ID
            sbSQL.AppendFormat(", UpdDate = '{0}'", mstrUpdDate);       //修改日期
            sbSQL.AppendFormat(", Memo = '{0}'", mstrMemo);       //备注
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
                return 0;   //表示删除0条记录，实际上是不能该表的所有记录
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
                objRow["PrjDataBaseName"] = mstrPrjDataBaseName;    //项目数据库名
                objRow["DataBaseName"] = mstrDataBaseName;    //数据库名
                objRow["DatabaseOwner"] = mstrDatabaseOwner;    //数据库拥有者
                objRow["DataBasePwd"] = mstrDataBasePwd;    //数据库的用户口令
                objRow["DataBaseTypeId"] = mstrDataBaseTypeId;    //数据库类型ID
                objRow["DataBaseUserId"] = mstrDataBaseUserId;    //数据库的用户ID
                objRow["IpAddress"] = mstrIpAddress;    //服务器
                objRow["SID"] = mstrSID;    //SID
                objRow["TableSpace"] = mstrTableSpace;    //表空间
                objRow["UserId"] = mstrUserId;    //用户ID
                objRow["UpdDate"] = mstrUpdDate;    //修改日期
                objRow["Memo"] = mstrMemo;    //备注
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
            //删除PrjDataBase本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from PrjDataBase where PrjDataBaseId=" + "'" + mstrPrjDataBaseId + "'";
            return objSQL.ExecSql(strSQL);
        }


        //同时删除多条记录
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
            //删除PrjDataBase本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from PrjDataBase where PrjDataBaseId in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }

        public static bool DelRecord(string strPrjDataBaseId)
        {
            //删除单条记录
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
            //删除PrjDataBase本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from PrjDataBase where PrjDataBaseId=" + "'" + strPrjDataBaseId + "'";
            return objSQL.ExecSql(strSQL);
        }


        /// <summary>
        /// 功能：删除多条记录，带条件的删除
        /// </summary>
        /// <param name="strCondition">需要删除的记录条件</param>
        /// <returns>返回删除的记录0。</returns>
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
                return 0;	//表示删除0条记录，实际上是不能该表的所有记录
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
            mstrPrjDataBaseId = objDT.Rows[0]["PrjDataBaseId"].ToString().Trim();       //项目数据库Id
            mstrPrjDataBaseName = objDT.Rows[0]["PrjDataBaseName"].ToString().Trim();       //项目数据库名
            mstrDataBaseName = objDT.Rows[0]["DataBaseName"].ToString().Trim();       //数据库名
            mstrDatabaseOwner = objDT.Rows[0]["DatabaseOwner"].ToString().Trim();       //数据库拥有者
            mstrDataBasePwd = objDT.Rows[0]["DataBasePwd"].ToString().Trim();       //数据库的用户口令
            mstrDataBaseTypeId = objDT.Rows[0]["DataBaseTypeId"].ToString().Trim();       //数据库类型ID
            mstrDataBaseUserId = objDT.Rows[0]["DataBaseUserId"].ToString().Trim();       //数据库的用户ID
            mstrIpAddress = objDT.Rows[0]["IpAddress"].ToString().Trim();       //服务器
            mstrSID = objDT.Rows[0]["SID"].ToString().Trim();       //SID
            mstrTableSpace = objDT.Rows[0]["TableSpace"].ToString().Trim();       //表空间
            mstrUserId = objDT.Rows[0]["UserId"].ToString().Trim();       //用户ID
            mstrUpdDate = objDT.Rows[0]["UpdDate"].ToString().Trim();       //修改日期
            mstrMemo = objDT.Rows[0]["Memo"].ToString().Trim();       //备注
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
                objPrjDataBase.PrjDataBaseId = objRow["PrjDataBaseId"].ToString().Trim();     //项目数据库Id
                objPrjDataBase.PrjDataBaseName = objRow["PrjDataBaseName"].ToString().Trim();     //项目数据库名
                objPrjDataBase.DataBaseName = objRow["DataBaseName"].ToString().Trim();     //数据库名
                objPrjDataBase.DatabaseOwner = objRow["DatabaseOwner"].ToString().Trim();     //数据库拥有者
                objPrjDataBase.DataBasePwd = objRow["DataBasePwd"].ToString().Trim();     //数据库的用户口令
                objPrjDataBase.DataBaseTypeId = objRow["DataBaseTypeId"].ToString().Trim();     //数据库类型ID
                objPrjDataBase.DataBaseUserId = objRow["DataBaseUserId"].ToString().Trim();     //数据库的用户ID
                objPrjDataBase.IpAddress = objRow["IpAddress"].ToString().Trim();     //服务器
                objPrjDataBase.SID = objRow["SID"].ToString().Trim();     //SID
                objPrjDataBase.TableSpace = objRow["TableSpace"].ToString().Trim();     //表空间
                objPrjDataBase.UserId = objRow["UserId"].ToString().Trim();     //用户ID
                objPrjDataBase.UpdDate = objRow["UpdDate"].ToString().Trim();     //修改日期
                objPrjDataBase.Memo = objRow["Memo"].ToString().Trim();     //备注
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
            objPrjDataBase.PrjDataBaseId = objRow["PrjDataBaseId"].ToString().Trim();     //项目数据库Id
            objPrjDataBase.PrjDataBaseName = objRow["PrjDataBaseName"].ToString().Trim();     //项目数据库名
            objPrjDataBase.DataBaseName = objRow["DataBaseName"].ToString().Trim();     //数据库名
            objPrjDataBase.DatabaseOwner = objRow["DatabaseOwner"].ToString().Trim();     //数据库拥有者
            objPrjDataBase.DataBasePwd = objRow["DataBasePwd"].ToString().Trim();     //数据库的用户口令
            objPrjDataBase.DataBaseTypeId = objRow["DataBaseTypeId"].ToString().Trim();     //数据库类型ID
            objPrjDataBase.DataBaseUserId = objRow["DataBaseUserId"].ToString().Trim();     //数据库的用户ID
            objPrjDataBase.IpAddress = objRow["IpAddress"].ToString().Trim();     //服务器
            objPrjDataBase.SID = objRow["SID"].ToString().Trim();     //SID
            objPrjDataBase.TableSpace = objRow["TableSpace"].ToString().Trim();     //表空间
            objPrjDataBase.UserId = objRow["UserId"].ToString().Trim();     //用户ID
            objPrjDataBase.UpdDate = objRow["UpdDate"].ToString().Trim();     //修改日期
            objPrjDataBase.Memo = objRow["Memo"].ToString().Trim();     //备注
            objDT = null;
            return objPrjDataBase;
        }


        /// <summary>
        /// 功能：获取某一条件的DataTable，其中的代码转换成相应的名称
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
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
        /// 功能：获取某一条件的相关表视图(View)
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
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
        /// 判断当前表中是否存在给定关键字值的记录
        /// </summary>
        /// <param name="strPrjDataBaseId">给定的关键字值</param>
        /// <returns>返回是否存在?</returns>
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
        /// 检查字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
        /// </summary>
        public void CheckPropertyNew()
        {
            if (Object.Equals(null, mstrPrjDataBaseId)
            || (!Object.Equals(null, mstrPrjDataBaseId) && mstrPrjDataBaseId.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[项目数据库Id]不能为空(NULL)!");
            }
            if (!Object.Equals(null, mstrPrjDataBaseId) && getStrLen(mstrPrjDataBaseId) > 4)
            {
                throw new clsDbObjException("字段[项目数据库Id]的长度不能超过4!");
            }
            if (!Object.Equals(null, mstrPrjDataBaseName) && getStrLen(mstrPrjDataBaseName) > 50)
            {
                throw new clsDbObjException("字段[项目数据库名]的长度不能超过50!");
            }
            if (!Object.Equals(null, mstrDataBaseName) && getStrLen(mstrDataBaseName) > 30)
            {
                throw new clsDbObjException("字段[数据库名]的长度不能超过30!");
            }
            if (!Object.Equals(null, mstrDatabaseOwner) && getStrLen(mstrDatabaseOwner) > 30)
            {
                throw new clsDbObjException("字段[数据库拥有者]的长度不能超过30!");
            }
            if (!Object.Equals(null, mstrDataBasePwd) && getStrLen(mstrDataBasePwd) > 20)
            {
                throw new clsDbObjException("字段[数据库的用户口令]的长度不能超过20!");
            }
            if (!Object.Equals(null, mstrDataBaseTypeId) && getStrLen(mstrDataBaseTypeId) > 2)
            {
                throw new clsDbObjException("字段[数据库类型ID]的长度不能超过2!");
            }
            if (!Object.Equals(null, mstrDataBaseUserId) && getStrLen(mstrDataBaseUserId) > 18)
            {
                throw new clsDbObjException("字段[数据库的用户ID]的长度不能超过18!");
            }
            if (!Object.Equals(null, mstrIpAddress) && getStrLen(mstrIpAddress) > 23)
            {
                throw new clsDbObjException("字段[服务器]的长度不能超过23!");
            }
            if (!Object.Equals(null, mstrSID) && getStrLen(mstrSID) > 30)
            {
                throw new clsDbObjException("字段[SID]的长度不能超过30!");
            }
            if (!Object.Equals(null, mstrTableSpace) && getStrLen(mstrTableSpace) > 30)
            {
                throw new clsDbObjException("字段[表空间]的长度不能超过30!");
            }
            if (!Object.Equals(null, mstrUserId) && getStrLen(mstrUserId) > 18)
            {
                throw new clsDbObjException("字段[用户ID]的长度不能超过18!");
            }
            if (!Object.Equals(null, mstrUpdDate) && getStrLen(mstrUpdDate) > 8)
            {
                throw new clsDbObjException("字段[修改日期]的长度不能超过8!");
            }
            if (!Object.Equals(null, mstrMemo) && getStrLen(mstrMemo) > 1000)
            {
                throw new clsDbObjException("字段[备注]的长度不能超过1000!");
            }
        }


        /// <summary>
        /// 获取当前表满足条件的所有记录的关键字值列表
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>返回的关键字值列表</returns>
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
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
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
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
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