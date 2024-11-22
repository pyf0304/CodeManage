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
        public const string CurrTabName_S = "SqlTabView";    //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "Id";    //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 12;
        public static string[] AttributeName = new string[] { "Id", "Name", "Owner", "TabType", "FldNum", "Server", "DataBaseName", "UserId", "Password", "ConnectString", "Tag", "Memo" };
        //以下是属性变量

        protected long mlngId;    //对象Id
        protected string mstrName;    //表视图名
        /// <summary>
        /// 拥有者
        /// </summary>
        protected string mstrOwner;    //拥有者
        protected string mstrTabType;    //表类型
        protected int mintFldNum;    //字段数
        protected string mstrServer;    //服务器名
        protected string mstrDataBaseName;    //数据库名
        protected string mstrUserId;    //用户ID
        protected string mstrPassword;    //口令
        /// <summary>
        /// 连接串
        /// </summary>
        protected string mstrConnectString;    //连接串
        /// <summary>
        /// Tag
        /// </summary>
        protected string mstrTag;    //Tag
        /// <summary>
        /// 备注
        /// </summary>
        protected string mstrMemo;    //备注

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
        /// 对象Id
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
        /// 表视图名
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
        /// 拥有者
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
        /// 表类型
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
        /// 字段数
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
        /// 服务器名
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
        /// 口令
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
        /// 连接串
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
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from SqlTabView where 1=2";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "SqlTabView");
            objRow = objDS.Tables["SqlTabView"].NewRow();
            objRow["Id"] = mlngId;    //对象Id
            objRow["Name"] = mstrName;    //表视图名
            objRow["Owner"] = mstrOwner;    //拥有者
            objRow["TabType"] = mstrTabType;    //表类型
            objRow["FldNum"] = mintFldNum;    //字段数
            if (mstrServer != "")
            {
                objRow["Server"] = mstrServer;   //服务器名
            }
            if (mstrDataBaseName != "")
            {
                objRow["DataBaseName"] = mstrDataBaseName;   //数据库名
            }
            if (mstrUserId != "")
            {
                objRow["UserId"] = mstrUserId;   //用户ID
            }
            if (mstrPassword != "")
            {
                objRow["Password"] = mstrPassword;   //口令
            }
            if (mstrConnectString != "")
            {
                objRow["ConnectString"] = mstrConnectString;   //连接串
            }
            if (mstrTag != "")
            {
                objRow["Tag"] = mstrTag;   //Tag
            }
            if (mstrMemo != "")
            {
                objRow["Memo"] = mstrMemo;   //备注
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
            //通过存储过程来
            //直接使用
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
        /// 把多条记录同时插入到表中!
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
                strResult = "错误号为：" + mintErrNo.ToString();
                return false;
            }
            strSQL = "Select * from SqlTabView where Id='111'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "SqlTabView");
            //检查关键字的唯一性
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                long lngId = Int32.Parse(oRow["Id"].ToString().Trim());
                if (IsExist(lngId))
                {
                    strResult = "关键字Id为：" + lngId + "的记录已存在，不能重复插入!";
                    return false;
                }
            }
            //把多条记录插入到表中
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                objRow = objDS.Tables["SqlTabView"].NewRow();
                objRow["Id"] = oRow["Id"].ToString().Trim();    //对象Id
                objRow["Name"] = oRow["Name"].ToString().Trim();    //表视图名
                objRow["Owner"] = oRow["Owner"].ToString().Trim();    //拥有者
                objRow["TabType"] = oRow["TabType"].ToString().Trim();    //表类型
                objRow["FldNum"] = oRow["FldNum"].ToString().Trim();    //字段数
                objRow["Server"] = oRow["Server"].ToString().Trim();    //服务器名
                objRow["DataBaseName"] = oRow["DataBaseName"].ToString().Trim();    //数据库名
                objRow["UserId"] = oRow["UserId"].ToString().Trim();    //用户ID
                objRow["Password"] = oRow["Password"].ToString().Trim();    //口令
                objRow["ConnectString"] = oRow["ConnectString"].ToString().Trim();    //连接串
                objRow["Tag"] = oRow["Tag"].ToString().Trim();    //Tag
                objRow["Memo"] = oRow["Memo"].ToString().Trim();    //备注
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
                //MsgBox("没有相应的ID号：Id=" + ""+ mlngId+"");
                return false;
            }
            objRow = objDS.Tables["SqlTabView"].Rows[0];
            objRow["Name"] = mstrName;       //表视图名
            objRow["Owner"] = mstrOwner;       //拥有者
            objRow["TabType"] = mstrTabType;       //表类型
            objRow["FldNum"] = mintFldNum;       //字段数
            if (mstrServer != "")
            {
                objRow["Server"] = mstrServer;    //服务器名
            }
            if (mstrDataBaseName != "")
            {
                objRow["DataBaseName"] = mstrDataBaseName;    //数据库名
            }
            if (mstrUserId != "")
            {
                objRow["UserId"] = mstrUserId;    //用户ID
            }
            if (mstrPassword != "")
            {
                objRow["Password"] = mstrPassword;    //口令
            }
            if (mstrConnectString != "")
            {
                objRow["ConnectString"] = mstrConnectString;    //连接串
            }
            if (mstrTag != "")
            {
                objRow["Tag"] = mstrTag;    //Tag
            }
            if (mstrMemo != "")
            {
                objRow["Memo"] = mstrMemo;    //备注
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
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            int intRecCount;
            if (strCondition == "")
            {
                return 0;   //表示删除0条记录，实际上是不能该表的所有记录
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
                objRow["Name"] = mstrName;    //表视图名
                objRow["Owner"] = mstrOwner;    //拥有者
                objRow["TabType"] = mstrTabType;    //表类型
                objRow["FldNum"] = mintFldNum;    //字段数
                objRow["Server"] = mstrServer;    //服务器名
                objRow["DataBaseName"] = mstrDataBaseName;    //数据库名
                objRow["UserId"] = mstrUserId;    //用户ID
                objRow["Password"] = mstrPassword;    //口令
                objRow["ConnectString"] = mstrConnectString;    //连接串
                objRow["Tag"] = mstrTag;    //Tag
                objRow["Memo"] = mstrMemo;    //备注
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
            //删除SqlTabView本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from SqlTabView where Id=" + "" + mlngId + "";
            return objSQL.ExecSql(strSQL);
        }


        //同时删除多条记录
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
            //删除SqlTabView本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from SqlTabView where Id in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }

        public static bool DelRecord(long lngId)
        {
            //删除单条记录
            string strSQL = "";
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            //删除SqlTabView本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from SqlTabView where Id=" + "" + lngId + "";
            return objSQL.ExecSql(strSQL);
        }


        /// <summary>
        /// 功能：删除多条记录，带条件的删除
        /// </summary>
        /// <param name="strCondition">需要删除的记录条件</param>
        /// <returns>返回删除的记录0。</returns>
        public static int DelSqlTabView(string strCondition)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strSQL;
            if (strCondition == "")
            {
                return 0;	//表示删除0条记录，实际上是不能该表的所有记录
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
            mlngId = Int32.Parse(objDT.Rows[0]["Id"].ToString().Trim());       //对象Id
            mstrName = objDT.Rows[0]["Name"].ToString().Trim();       //表视图名
            mstrOwner = objDT.Rows[0]["Owner"].ToString().Trim();       //拥有者
            mstrTabType = objDT.Rows[0]["TabType"].ToString().Trim();       //表类型
            mintFldNum = TransNullToInt(objDT.Rows[0]["FldNum"].ToString().Trim());       //字段数
            mstrServer = objDT.Rows[0]["Server"].ToString().Trim();       //服务器名
            mstrDataBaseName = objDT.Rows[0]["DataBaseName"].ToString().Trim();       //数据库名
            mstrUserId = objDT.Rows[0]["UserId"].ToString().Trim();       //用户ID
            mstrPassword = objDT.Rows[0]["Password"].ToString().Trim();       //口令
            mstrConnectString = objDT.Rows[0]["ConnectString"].ToString().Trim();       //连接串
            mstrTag = objDT.Rows[0]["Tag"].ToString().Trim();       //Tag
            mstrMemo = objDT.Rows[0]["Memo"].ToString().Trim();       //备注
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
                objSqlTabView.Id = Int32.Parse(objRow["Id"].ToString().Trim());     //对象Id
                objSqlTabView.Name = objRow["Name"].ToString().Trim();     //表视图名
                objSqlTabView.Owner = objRow["Owner"].ToString().Trim();     //拥有者
                objSqlTabView.TabType = objRow["TabType"].ToString().Trim();     //表类型
                objSqlTabView.FldNum = TransNullToInt(objRow["FldNum"].ToString().Trim());     //字段数
                objSqlTabView.Server = objRow["Server"].ToString().Trim();     //服务器名
                objSqlTabView.DataBaseName = objRow["DataBaseName"].ToString().Trim();     //数据库名
                objSqlTabView.UserId = objRow["UserId"].ToString().Trim();     //用户ID
                objSqlTabView.Password = objRow["Password"].ToString().Trim();     //口令
                objSqlTabView.ConnectString = objRow["ConnectString"].ToString().Trim();     //连接串
                objSqlTabView.Tag = objRow["Tag"].ToString().Trim();     //Tag
                objSqlTabView.Memo = objRow["Memo"].ToString().Trim();     //备注
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
            objSqlTabView.Id = Int32.Parse(objRow["Id"].ToString().Trim());     //对象Id
            objSqlTabView.Name = objRow["Name"].ToString().Trim();     //表视图名
            objSqlTabView.Owner = objRow["Owner"].ToString().Trim();     //拥有者
            objSqlTabView.TabType = objRow["TabType"].ToString().Trim();     //表类型
            objSqlTabView.FldNum = TransNullToInt(objRow["FldNum"].ToString().Trim());     //字段数
            objSqlTabView.Server = objRow["Server"].ToString().Trim();     //服务器名
            objSqlTabView.DataBaseName = objRow["DataBaseName"].ToString().Trim();     //数据库名
            objSqlTabView.UserId = objRow["UserId"].ToString().Trim();     //用户ID
            objSqlTabView.Password = objRow["Password"].ToString().Trim();     //口令
            objSqlTabView.ConnectString = objRow["ConnectString"].ToString().Trim();     //连接串
            objSqlTabView.Tag = objRow["Tag"].ToString().Trim();     //Tag
            objSqlTabView.Memo = objRow["Memo"].ToString().Trim();     //备注
            objDT = null;
            return objSqlTabView;
        }


        /// <summary>
        /// 功能：获取某一条件的DataTable，其中的代码转换成相应的名称
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
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
        /// 功能：获取某一条件的相关表视图(View)
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
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
        /// 判断当前表中是否存在给定关键字值的记录
        /// </summary>
        /// <param name="lngId">给定的关键字值</param>
        /// <returns>返回是否存在?</returns>
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
        /// 检查字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
        /// </summary>
        public void CheckPropertyNew()
        {
            if (Object.Equals(null, mlngId)
            || (!Object.Equals(null, mlngId) && mlngId.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[对象Id]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrName)
            || (!Object.Equals(null, mstrName) && mstrName.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[表视图名]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrOwner)
            || (!Object.Equals(null, mstrOwner) && mstrOwner.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[拥有者]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrTabType)
            || (!Object.Equals(null, mstrTabType) && mstrTabType.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[表类型]不能为空(NULL)!");
            }
            if (!Object.Equals(null, mstrName) && getStrLen(mstrName) > 50)
            {
                throw new clsDbObjException("字段[表视图名]的长度不能超过50!");
            }
            if (!Object.Equals(null, mstrOwner) && getStrLen(mstrOwner) > 50)
            {
                throw new clsDbObjException("字段[拥有者]的长度不能超过50!");
            }
            if (!Object.Equals(null, mstrTabType) && getStrLen(mstrTabType) > 30)
            {
                throw new clsDbObjException("字段[表类型]的长度不能超过30!");
            }
            if (!Object.Equals(null, mstrServer) && getStrLen(mstrServer) > 50)
            {
                throw new clsDbObjException("字段[服务器名]的长度不能超过50!");
            }
            if (!Object.Equals(null, mstrDataBaseName) && getStrLen(mstrDataBaseName) > 50)
            {
                throw new clsDbObjException("字段[数据库名]的长度不能超过50!");
            }
            if (!Object.Equals(null, mstrUserId) && getStrLen(mstrUserId) > 18)
            {
                throw new clsDbObjException("字段[用户ID]的长度不能超过18!");
            }
            if (!Object.Equals(null, mstrPassword) && getStrLen(mstrPassword) > 20)
            {
                throw new clsDbObjException("字段[口令]的长度不能超过20!");
            }
            if (!Object.Equals(null, mstrConnectString) && getStrLen(mstrConnectString) > 100)
            {
                throw new clsDbObjException("字段[连接串]的长度不能超过100!");
            }
            if (!Object.Equals(null, mstrTag) && getStrLen(mstrTag) > 500)
            {
                throw new clsDbObjException("字段[Tag]的长度不能超过500!");
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
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
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
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
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