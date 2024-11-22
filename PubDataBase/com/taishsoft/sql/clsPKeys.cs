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
    public class clsPKeys : clsGeneralTab
    {
        public const string CurrTabName_S = "PKeys";    //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "Id";    //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 7;
        public static string[] AttributeName = new string[] { "Id", "COLUMN_NAME", "KEY_SEQ", "PK_NAME", "TABLE_NAME", "TABLE_OWNER", "TABLE_QUALIFIER" };
        //以下是属性变量

        protected long mlngId;    //对象Id
        protected string mstrCOLUMN_NAME;    //COLUMN_NAME
        protected int mintKEY_SEQ;    //KEY_SEQ
        protected string mstrPK_NAME;    //PK_NAME
        protected string mstrTABLE_NAME;    //TABLE_NAME
        protected string mstrTABLE_OWNER;    //TABLE_OWNER
        protected string mstrTABLE_QUALIFIER;    //TABLE_QUALIFIER

        public clsPKeys()
        {
            SetInit();
            _CurrTabName = "PKeys";
            KeyFldName = "Id";
        }

        public clsPKeys(long lngId)
        {

            mlngId = lngId;
            SetInit();
            _CurrTabName = "PKeys";
            KeyFldName = "Id";
        }

        public clsPKeys(long lngId, bool bolIsGetPKeys)
        {

            mlngId = lngId;
            SetInit();
            if (bolIsGetPKeys == true)
            {
                GetPKeys();
            }
            _CurrTabName = "PKeys";
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
                else if (strAttributeName == "COLUMN_NAME")
                {
                    return mstrCOLUMN_NAME;
                }
                else if (strAttributeName == "KEY_SEQ")
                {
                    return mintKEY_SEQ;
                }
                else if (strAttributeName == "PK_NAME")
                {
                    return mstrPK_NAME;
                }
                else if (strAttributeName == "TABLE_NAME")
                {
                    return mstrTABLE_NAME;
                }
                else if (strAttributeName == "TABLE_OWNER")
                {
                    return mstrTABLE_OWNER;
                }
                else if (strAttributeName == "TABLE_QUALIFIER")
                {
                    return mstrTABLE_QUALIFIER;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "Id")
                {
                    mlngId = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "COLUMN_NAME")
                {
                    mstrCOLUMN_NAME = value.ToString();
                }
                else if (strAttributeName == "KEY_SEQ")
                {
                    mintKEY_SEQ = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "PK_NAME")
                {
                    mstrPK_NAME = value.ToString();
                }
                else if (strAttributeName == "TABLE_NAME")
                {
                    mstrTABLE_NAME = value.ToString();
                }
                else if (strAttributeName == "TABLE_OWNER")
                {
                    mstrTABLE_OWNER = value.ToString();
                }
                else if (strAttributeName == "TABLE_QUALIFIER")
                {
                    mstrTABLE_QUALIFIER = value.ToString();
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
                else if ("COLUMN_NAME" == AttributeName[intIndex])
                {
                    return mstrCOLUMN_NAME;
                }
                else if ("KEY_SEQ" == AttributeName[intIndex])
                {
                    return mintKEY_SEQ;
                }
                else if ("PK_NAME" == AttributeName[intIndex])
                {
                    return mstrPK_NAME;
                }
                else if ("TABLE_NAME" == AttributeName[intIndex])
                {
                    return mstrTABLE_NAME;
                }
                else if ("TABLE_OWNER" == AttributeName[intIndex])
                {
                    return mstrTABLE_OWNER;
                }
                else if ("TABLE_QUALIFIER" == AttributeName[intIndex])
                {
                    return mstrTABLE_QUALIFIER;
                }
                return null;
            }
            set
            {
                if ("Id" == AttributeName[intIndex])
                {
                    mlngId = TransNullToInt(value.ToString());
                }
                else if ("COLUMN_NAME" == AttributeName[intIndex])
                {
                    mstrCOLUMN_NAME = value.ToString();
                }
                else if ("KEY_SEQ" == AttributeName[intIndex])
                {
                    mintKEY_SEQ = TransNullToInt(value.ToString());
                }
                else if ("PK_NAME" == AttributeName[intIndex])
                {
                    mstrPK_NAME = value.ToString();
                }
                else if ("TABLE_NAME" == AttributeName[intIndex])
                {
                    mstrTABLE_NAME = value.ToString();
                }
                else if ("TABLE_OWNER" == AttributeName[intIndex])
                {
                    mstrTABLE_OWNER = value.ToString();
                }
                else if ("TABLE_QUALIFIER" == AttributeName[intIndex])
                {
                    mstrTABLE_QUALIFIER = value.ToString();
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
        /// COLUMN_NAME
        /// </summary>
        public string COLUMN_NAME
        {
            get
            {
                return mstrCOLUMN_NAME;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrCOLUMN_NAME = value;
                }
                else
                {
                    mstrCOLUMN_NAME = value;
                }
            }
        }
        /// <summary>
        /// KEY_SEQ
        /// </summary>
        public int KEY_SEQ
        {
            get
            {
                return mintKEY_SEQ;
            }
            set
            {
                mintKEY_SEQ = value;
            }
        }
        /// <summary>
        /// PK_NAME
        /// </summary>
        public string PK_NAME
        {
            get
            {
                return mstrPK_NAME;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPK_NAME = value;
                }
                else
                {
                    mstrPK_NAME = value;
                }
            }
        }
        /// <summary>
        /// TABLE_NAME
        /// </summary>
        public string TABLE_NAME
        {
            get
            {
                return mstrTABLE_NAME;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTABLE_NAME = value;
                }
                else
                {
                    mstrTABLE_NAME = value;
                }
            }
        }
        /// <summary>
        /// TABLE_OWNER
        /// </summary>
        public string TABLE_OWNER
        {
            get
            {
                return mstrTABLE_OWNER;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTABLE_OWNER = value;
                }
                else
                {
                    mstrTABLE_OWNER = value;
                }
            }
        }
        /// <summary>
        /// TABLE_QUALIFIER
        /// </summary>
        public string TABLE_QUALIFIER
        {
            get
            {
                return mstrTABLE_QUALIFIER;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTABLE_QUALIFIER = value;
                }
                else
                {
                    mstrTABLE_QUALIFIER = value;
                }
            }
        }

        /// <summary>
        /// 添加新记录
        /// </summary>
        /// <returns>添加是否成功?</returns>
        public override  bool AddNewRecord()
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from PKeys where 1=2";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "PKeys");
            objRow = objDS.Tables["PKeys"].NewRow();
            objRow["Id"] = mlngId;    //对象Id
            objRow["COLUMN_NAME"] = mstrCOLUMN_NAME;    //COLUMN_NAME
            objRow["KEY_SEQ"] = mintKEY_SEQ;    //KEY_SEQ
            objRow["PK_NAME"] = mstrPK_NAME;    //PK_NAME
            objRow["TABLE_NAME"] = mstrTABLE_NAME;    //TABLE_NAME
            objRow["TABLE_OWNER"] = mstrTABLE_OWNER;    //TABLE_OWNER
            objRow["TABLE_QUALIFIER"] = mstrTABLE_QUALIFIER;    //TABLE_QUALIFIER
            objDS.Tables["PKeys"].Rows.Add(objRow);
            try
            {
                objDA.Update(objDS, "PKeys");
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



        public bool AddnewPKeysBySP()
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
            values.Add(mstrCOLUMN_NAME);
            values.Add(mintKEY_SEQ);
            values.Add(mstrPK_NAME);
            values.Add(mstrTABLE_NAME);
            values.Add(mstrTABLE_OWNER);
            values.Add(mstrTABLE_QUALIFIER);
            objSQL.ExecSP("AddnewPKeys", values);
            return true;
        }

        /// <summary>
        /// 把多条记录同时插入到表中!
        /// </summary>
        /// <param name="oDT"></param>
        /// <param name="strResult"></param>
        /// <returns></returns>
        public bool AddnewPKeyss(System.Data.DataTable oDT, ref string strResult)
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
            strSQL = "Select * from PKeys where Id='111'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "PKeys");
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
                objRow = objDS.Tables["PKeys"].NewRow();
                objRow["Id"] = oRow["Id"].ToString().Trim();    //对象Id
                objRow["COLUMN_NAME"] = oRow["COLUMN_NAME"].ToString().Trim();    //COLUMN_NAME
                objRow["KEY_SEQ"] = oRow["KEY_SEQ"].ToString().Trim();    //KEY_SEQ
                objRow["PK_NAME"] = oRow["PK_NAME"].ToString().Trim();    //PK_NAME
                objRow["TABLE_NAME"] = oRow["TABLE_NAME"].ToString().Trim();    //TABLE_NAME
                objRow["TABLE_OWNER"] = oRow["TABLE_OWNER"].ToString().Trim();    //TABLE_OWNER
                objRow["TABLE_QUALIFIER"] = oRow["TABLE_QUALIFIER"].ToString().Trim();    //TABLE_QUALIFIER
                objDS.Tables["PKeys"].Rows.Add(objRow);
            }
            try
            {
                objDA.Update(objDS, "PKeys");
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
            strSQL = "Select * from PKeys where Id=" + "" + mlngId + "";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "PKeys");
            if (objDS.Tables["PKeys"].Rows.Count == 0)
            {
                //MsgBox("没有相应的ID号：Id=" + ""+ mlngId+"");
                return false;
            }
            objRow = objDS.Tables["PKeys"].Rows[0];
            objRow["COLUMN_NAME"] = mstrCOLUMN_NAME;       //COLUMN_NAME
            objRow["KEY_SEQ"] = mintKEY_SEQ;       //KEY_SEQ
            objRow["PK_NAME"] = mstrPK_NAME;       //PK_NAME
            objRow["TABLE_NAME"] = mstrTABLE_NAME;       //TABLE_NAME
            objRow["TABLE_OWNER"] = mstrTABLE_OWNER;       //TABLE_OWNER
            objRow["TABLE_QUALIFIER"] = mstrTABLE_QUALIFIER;       //TABLE_QUALIFIER
            try
            {
                objDA.Update(objDS, "PKeys");
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
            strSQL = "Select * from PKeys where " + strCondition;
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "PKeys");
            if (objDS.Tables["PKeys"].Rows.Count == 0)
            {
                return 0;
            }
            intRecCount = objDS.Tables["PKeys"].Rows.Count;
            foreach (System.Data.DataRow objRow in objDS.Tables["PKeys"].Rows)
            {
                objRow["COLUMN_NAME"] = mstrCOLUMN_NAME;    //COLUMN_NAME
                objRow["KEY_SEQ"] = mintKEY_SEQ;    //KEY_SEQ
                objRow["PK_NAME"] = mstrPK_NAME;    //PK_NAME
                objRow["TABLE_NAME"] = mstrTABLE_NAME;    //TABLE_NAME
                objRow["TABLE_OWNER"] = mstrTABLE_OWNER;    //TABLE_OWNER
                objRow["TABLE_QUALIFIER"] = mstrTABLE_QUALIFIER;    //TABLE_QUALIFIER
            }
            try
            {
                objDA.Update(objDS, "PKeys");
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
            //删除PKeys本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from PKeys where Id=" + "" + mlngId + "";
            return objSQL.ExecSql(strSQL);
        }


        //同时删除多条记录
        public static bool DelPKeys(ArrayList lstKey)
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
            //删除PKeys本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from PKeys where Id in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }

        public static bool DelRecord(long lngId)
        {
            //删除单条记录
            string strSQL = "";
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            //删除PKeys本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from PKeys where Id=" + "" + lngId + "";
            return objSQL.ExecSql(strSQL);
        }


        /// <summary>
        /// 功能：删除多条记录，带条件的删除
        /// </summary>
        /// <param name="strCondition">需要删除的记录条件</param>
        /// <returns>返回删除的记录0。</returns>
        public static int DelPKeys(string strCondition)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strSQL;
            if (strCondition == "")
            {
                return 0;	//表示删除0条记录，实际上是不能该表的所有记录
            }
            else
            {
                strSQL = "Delete from PKeys where " + strCondition;
            }
            int intRecoCount = objSQL.ExecSql2(strSQL);
            return intRecoCount;
        }


        public bool GetPKeys()
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from PKeys where Id=" + "" + mlngId + "";
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            mlngId = Int32.Parse(objDT.Rows[0]["Id"].ToString().Trim());       //对象Id
            mstrCOLUMN_NAME = objDT.Rows[0]["COLUMN_NAME"].ToString().Trim();       //COLUMN_NAME
            mintKEY_SEQ = Int32.Parse(objDT.Rows[0]["KEY_SEQ"].ToString().Trim());       //KEY_SEQ
            mstrPK_NAME = objDT.Rows[0]["PK_NAME"].ToString().Trim();       //PK_NAME
            mstrTABLE_NAME = objDT.Rows[0]["TABLE_NAME"].ToString().Trim();       //TABLE_NAME
            mstrTABLE_OWNER = objDT.Rows[0]["TABLE_OWNER"].ToString().Trim();       //TABLE_OWNER
            mstrTABLE_QUALIFIER = objDT.Rows[0]["TABLE_QUALIFIER"].ToString().Trim();       //TABLE_QUALIFIER
            objDT = null;
            return true;
        }

        public static System.Data.DataTable GetPKeys(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from PKeys where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        public ArrayList GetPKeysObjList(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from PKeys where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsPKeys objPKeys = new clsPKeys();
                objPKeys.Id = Int32.Parse(objRow["Id"].ToString().Trim());     //对象Id
                objPKeys.COLUMN_NAME = objRow["COLUMN_NAME"].ToString().Trim();     //COLUMN_NAME
                objPKeys.KEY_SEQ = Int32.Parse(objRow["KEY_SEQ"].ToString().Trim());     //KEY_SEQ
                objPKeys.PK_NAME = objRow["PK_NAME"].ToString().Trim();     //PK_NAME
                objPKeys.TABLE_NAME = objRow["TABLE_NAME"].ToString().Trim();     //TABLE_NAME
                objPKeys.TABLE_OWNER = objRow["TABLE_OWNER"].ToString().Trim();     //TABLE_OWNER
                objPKeys.TABLE_QUALIFIER = objRow["TABLE_QUALIFIER"].ToString().Trim();     //TABLE_QUALIFIER
                arrObjList.Add(objPKeys);
            }
            objDT = null;
            return arrObjList;
        }

        public clsPKeys GetFirstPKeys(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from PKeys where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            DataRow objRow = objDT.Rows[0];
            clsPKeys objPKeys = new clsPKeys();
            objPKeys.Id = Int32.Parse(objRow["Id"].ToString().Trim());     //对象Id
            objPKeys.COLUMN_NAME = objRow["COLUMN_NAME"].ToString().Trim();     //COLUMN_NAME
            objPKeys.KEY_SEQ = Int32.Parse(objRow["KEY_SEQ"].ToString().Trim());     //KEY_SEQ
            objPKeys.PK_NAME = objRow["PK_NAME"].ToString().Trim();     //PK_NAME
            objPKeys.TABLE_NAME = objRow["TABLE_NAME"].ToString().Trim();     //TABLE_NAME
            objPKeys.TABLE_OWNER = objRow["TABLE_OWNER"].ToString().Trim();     //TABLE_OWNER
            objPKeys.TABLE_QUALIFIER = objRow["TABLE_QUALIFIER"].ToString().Trim();     //TABLE_QUALIFIER
            objDT = null;
            return objPKeys;
        }



        /// <summary>
        /// 功能：获取某一条件的相关表视图(View)
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
        public static System.Data.DataTable GetPKeysV(string strCondition)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL.Append("Select vPKeys.* ");
            strSQL.Append(" from vPKeys ");
            strSQL.Append(" where " + strCondition);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }


        public override bool IsExist()
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            if (objSQL.IsExistRecord("PKeys", "Id=" + "" + mlngId + ""))
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
            if (objSQL.IsExistRecord("PKeys", "Id=" + "" + lngId + ""))
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
            if (Object.Equals(null, mstrCOLUMN_NAME)
            || (!Object.Equals(null, mstrCOLUMN_NAME) && mstrCOLUMN_NAME.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[COLUMN_NAME]不能为空(NULL)!");
            }
            if (Object.Equals(null, mintKEY_SEQ)
            || (!Object.Equals(null, mintKEY_SEQ) && mintKEY_SEQ.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[KEY_SEQ]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrPK_NAME)
            || (!Object.Equals(null, mstrPK_NAME) && mstrPK_NAME.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[PK_NAME]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrTABLE_NAME)
            || (!Object.Equals(null, mstrTABLE_NAME) && mstrTABLE_NAME.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[TABLE_NAME]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrTABLE_OWNER)
            || (!Object.Equals(null, mstrTABLE_OWNER) && mstrTABLE_OWNER.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[TABLE_OWNER]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrTABLE_QUALIFIER)
            || (!Object.Equals(null, mstrTABLE_QUALIFIER) && mstrTABLE_QUALIFIER.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[TABLE_QUALIFIER]不能为空(NULL)!");
            }
            if (!Object.Equals(null, mstrCOLUMN_NAME) && getStrLen(mstrCOLUMN_NAME) > 128)
            {
                throw new clsDbObjException("字段[COLUMN_NAME]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrPK_NAME) && getStrLen(mstrPK_NAME) > 128)
            {
                throw new clsDbObjException("字段[PK_NAME]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrTABLE_NAME) && getStrLen(mstrTABLE_NAME) > 128)
            {
                throw new clsDbObjException("字段[TABLE_NAME]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrTABLE_OWNER) && getStrLen(mstrTABLE_OWNER) > 128)
            {
                throw new clsDbObjException("字段[TABLE_OWNER]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrTABLE_QUALIFIER) && getStrLen(mstrTABLE_QUALIFIER) > 128)
            {
                throw new clsDbObjException("字段[TABLE_QUALIFIER]的长度不能超过128!");
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
            strSQL = "Select Id from PKeys where " + strCondtion;
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
            strSQL = "Select Id from PKeys where " + strCondtion;
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
            strSQL = "Select Id from PKeys where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsPKeys");
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return new clsPKeys().TransNullToInt(null);
            }
            strKeyValue = objDT.Rows[0][0].ToString();
            objDT = null;
            return long.Parse(strKeyValue);
        }
    }
}