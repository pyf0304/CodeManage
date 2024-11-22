using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.common;
using com.taishsoft.commexception;
using com.taishsoft.commdb;
using System.Collections.Generic;


namespace com.taishsoft.sqlfororacle
{
    public class clsColumns : clsGeneralTab
    {
        public const string CurrTabName_S = "Columns";    //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "Column_Name";    //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 6;
        public static string[] AttributeName = new string[] { "Column_Name", "Type_Name", "length", "Is_Nullable", "COLUMN_DEF", "PRECISION" };
        //以下是属性变量

        /// <summary>
        /// 列名
        /// </summary>
        protected string mstrColumn_Name;    //列名

        /// <summary>
        /// 数据类型
        /// </summary>
        protected string mstrType_Name;    //数据类型

        /// <summary>
        /// 字段长度
        /// </summary>
        protected int mintlength;    //字段长度

        /// <summary>
        /// 是否可空
        /// </summary>
        protected string mstrIs_Nullable;    //是否可空
        /// <summary>
        /// 字段缺省值
        /// </summary>
        protected string mstrCOLUMN_DEF;    //字段缺省值
        /// <summary>
        /// 精确度
        /// </summary>
        protected int mintPRECISION;    //精确度
        /// <summary>
        /// 构造函数
        /// </summary>
        public clsColumns()
        {
            SetInit();
            _CurrTabName = "Columns";
            KeyFldName = "Column_Name";
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="strColumn_Name">字段名</param>
        public clsColumns(string strColumn_Name)
        {

            mstrColumn_Name = strColumn_Name;
            SetInit();
            _CurrTabName = "Columns";
            KeyFldName = "Column_Name";
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="strColumn_Name">字段名</param>
        /// <param name="bolIsGetColumns">是否获取对象</param>
        public clsColumns(string strColumn_Name, bool bolIsGetColumns)
        {

            mstrColumn_Name = strColumn_Name;
            SetInit();
            if (bolIsGetColumns == true)
            {
                GetColumns();
            }
            _CurrTabName = "Columns";
            KeyFldName = "Column_Name";
        }

        /// <summary>
        /// 属性数
        /// </summary>
        public static int AttributeCount
        {
            get
            {
                return mintAttributeCount;
            }
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="strAttributeName"></param>
       /// <returns></returns>
        public object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == "Column_Name")
                {
                    return mstrColumn_Name;
                }
                else if (strAttributeName == "Type_Name")
                {
                    return mstrType_Name;
                }
                else if (strAttributeName == "length")
                {
                    return mintlength;
                }
                else if (strAttributeName == "Is_Nullable")
                {
                    return mstrIs_Nullable;
                }
                else if (strAttributeName == "COLUMN_DEF")
                {
                    return mstrCOLUMN_DEF;
                }
                else if (strAttributeName == "PRECISION")
                {
                    return mintPRECISION;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "Column_Name")
                {
                    mstrColumn_Name = value.ToString();
                }
                else if (strAttributeName == "Type_Name")
                {
                    mstrType_Name = value.ToString();
                }
                else if (strAttributeName == "length")
                {
                    mintlength = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "Is_Nullable")
                {
                    mstrIs_Nullable = value.ToString();
                }
                else if (strAttributeName == "COLUMN_DEF")
                {
                    mstrCOLUMN_DEF = value.ToString();
                }
                else if (strAttributeName == "PRECISION")
                {
                    mintPRECISION = TransNullToInt(value.ToString());
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="intIndex"></param>
        /// <returns></returns>
        public object this[int intIndex]
        {
            get
            {
                if ("Column_Name" == AttributeName[intIndex])
                {
                    return mstrColumn_Name;
                }
                else if ("Type_Name" == AttributeName[intIndex])
                {
                    return mstrType_Name;
                }
                else if ("length" == AttributeName[intIndex])
                {
                    return mintlength;
                }
                else if ("Is_Nullable" == AttributeName[intIndex])
                {
                    return mstrIs_Nullable;
                }
                else if ("COLUMN_DEF" == AttributeName[intIndex])
                {
                    return mstrCOLUMN_DEF;
                }
                else if ("PRECISION" == AttributeName[intIndex])
                {
                    return mintPRECISION;
                }
                return null;
            }
            set
            {
                if ("Column_Name" == AttributeName[intIndex])
                {
                    mstrColumn_Name = value.ToString();
                }
                else if ("Type_Name" == AttributeName[intIndex])
                {
                    mstrType_Name = value.ToString();
                }
                else if ("length" == AttributeName[intIndex])
                {
                    mintlength = TransNullToInt(value.ToString());
                }
                else if ("Is_Nullable" == AttributeName[intIndex])
                {
                    mstrIs_Nullable = value.ToString();
                }
                else if ("COLUMN_DEF" == AttributeName[intIndex])
                {
                    mstrCOLUMN_DEF = value.ToString();
                }
                else if ("PRECISION" == AttributeName[intIndex])
                {
                    mintPRECISION = TransNullToInt(value.ToString());
                }
            }
        }

        /// <summary>
        /// 列名
        /// </summary>
        public string Column_Name
        {
            get
            {
                return mstrColumn_Name;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrColumn_Name = value;
                }
                else
                {
                    mstrColumn_Name = value;
                }
            }
        }
        /// <summary>
        /// 数据类型
        /// </summary>
        public string Type_Name
        {
            get
            {
                return mstrType_Name;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrType_Name = value;
                }
                else
                {
                    mstrType_Name = value;
                }
            }
        }
        /// <summary>
        /// 字段长度
        /// </summary>
        public int length
        {
            get
            {
                return mintlength;
            }
            set
            {
                mintlength = value;
            }
        }
        /// <summary>
        /// 是否可空
        /// </summary>
        public string Is_Nullable
        {
            get
            {
                return mstrIs_Nullable;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrIs_Nullable = value;
                }
                else
                {
                    mstrIs_Nullable = value;
                }
            }
        }
        /// <summary>
        /// 字段缺省值
        /// </summary>
        public string COLUMN_DEF
        {
            get
            {
                return mstrCOLUMN_DEF;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrCOLUMN_DEF = value;
                }
                else
                {
                    mstrCOLUMN_DEF = value;
                }
            }
        }
        /// <summary>
        /// 精确度
        /// </summary>
        public int PRECISION
        {
            get
            {
                return mintPRECISION;
            }
            set
            {
                mintPRECISION = value;
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
            strSQL = "Select * from Columns where 1=2";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "Columns");
            objRow = objDS.Tables["Columns"].NewRow();
            objRow["Column_Name"] = mstrColumn_Name;    //列名
            objRow["Type_Name"] = mstrType_Name;    //数据类型
            objRow["length"] = mintlength;    //字段长度
            objRow["Is_Nullable"] = mstrIs_Nullable;    //是否可空
            if (mstrCOLUMN_DEF != "")
            {
                objRow["COLUMN_DEF"] = mstrCOLUMN_DEF;   //字段缺省值
            }
            objRow["PRECISION"] = mintPRECISION;    //精确度
            objDS.Tables["Columns"].Rows.Add(objRow);
            try
            {
                objDA.Update(objDS, "Columns");
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



        public bool AddnewColumnsBySP()
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
            values.Add(mstrColumn_Name);
            values.Add(mstrType_Name);
            values.Add(mintlength);
            values.Add(mstrIs_Nullable);
            values.Add(mstrCOLUMN_DEF);
            values.Add(mintPRECISION);
            objSQL.ExecSP("AddnewColumns", values);
            return true;
        }

        /// <summary>
        /// 把多条记录同时插入到表中!
        /// </summary>
        /// <param name="oDT"></param>
        /// <param name="strResult"></param>
        /// <returns></returns>
        public bool AddnewColumnss(System.Data.DataTable oDT, ref string strResult)
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
            strSQL = "Select * from Columns where Column_Name='111'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "Columns");
            //检查关键字的唯一性
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                string strColumn_Name = oRow["Column_Name"].ToString().Trim();
                if (IsExist(strColumn_Name))
                {
                    strResult = "关键字Column_Name为：" + strColumn_Name + "的记录已存在，不能重复插入!";
                    return false;
                }
            }
            //把多条记录插入到表中
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                objRow = objDS.Tables["Columns"].NewRow();
                objRow["Column_Name"] = oRow["Column_Name"].ToString().Trim();    //列名
                objRow["Type_Name"] = oRow["Type_Name"].ToString().Trim();    //数据类型
                objRow["length"] = oRow["length"].ToString().Trim();    //字段长度
                objRow["Is_Nullable"] = oRow["Is_Nullable"].ToString().Trim();    //是否可空
                objRow["COLUMN_DEF"] = oRow["COLUMN_DEF"].ToString().Trim();    //字段缺省值
                objRow["PRECISION"] = oRow["PRECISION"].ToString().Trim();    //精确度
                objDS.Tables["Columns"].Rows.Add(objRow);
            }
            try
            {
                objDA.Update(objDS, "Columns");
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
            strSQL = "Select * from Columns where Column_Name=" + "'" + mstrColumn_Name + "'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "Columns");
            if (objDS.Tables["Columns"].Rows.Count == 0)
            {
                //MsgBox("没有相应的ID号：Column_Name=" + "'"+ mstrColumn_Name+"'");
                return false;
            }
            objRow = objDS.Tables["Columns"].Rows[0];
            objRow["Type_Name"] = mstrType_Name;       //数据类型
            objRow["length"] = mintlength;       //字段长度
            objRow["Is_Nullable"] = mstrIs_Nullable;       //是否可空
            if (mstrCOLUMN_DEF != "")
            {
                objRow["COLUMN_DEF"] = mstrCOLUMN_DEF;    //字段缺省值
            }
            objRow["PRECISION"] = mintPRECISION;       //精确度
            try
            {
                objDA.Update(objDS, "Columns");
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
            strSQL = "Select * from Columns where " + strCondition;
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "Columns");
            if (objDS.Tables["Columns"].Rows.Count == 0)
            {
                return 0;
            }
            intRecCount = objDS.Tables["Columns"].Rows.Count;
            foreach (System.Data.DataRow objRow in objDS.Tables["Columns"].Rows)
            {
                objRow["Type_Name"] = mstrType_Name;    //数据类型
                objRow["length"] = mintlength;    //字段长度
                objRow["Is_Nullable"] = mstrIs_Nullable;    //是否可空
                objRow["COLUMN_DEF"] = mstrCOLUMN_DEF;    //字段缺省值
                objRow["PRECISION"] = mintPRECISION;    //精确度
            }
            try
            {
                objDA.Update(objDS, "Columns");
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
            //删除Columns本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from Columns where Column_Name=" + "'" + mstrColumn_Name + "'";
            return objSQL.ExecSql(strSQL);
        }


        //同时删除多条记录
        public static bool DelColumns(ArrayList lstKey)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
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
            //删除Columns本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from Columns where Column_Name in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }

        public static bool DelRecord(string strColumn_Name)
        {
            //删除单条记录
            string strSQL = "";
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            //删除Columns本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from Columns where Column_Name=" + "'" + strColumn_Name + "'";
            return objSQL.ExecSql(strSQL);
        }


        /// <summary>
        /// 功能：删除多条记录，带条件的删除
        /// </summary>
        /// <param name="strCondition">需要删除的记录条件</param>
        /// <returns>返回删除的记录0。</returns>
        public static int DelColumns(string strCondition)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strSQL;
            if (strCondition == "")
            {
                return 0;	//表示删除0条记录，实际上是不能该表的所有记录
            }
            else
            {
                strSQL = "Delete from Columns where " + strCondition;
            }
            int intRecoCount = objSQL.ExecSql2(strSQL);
            return intRecoCount;
        }


        public bool GetColumns()
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from Columns where Column_Name=" + "'" + mstrColumn_Name + "'";
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            mstrColumn_Name = objDT.Rows[0]["Column_Name"].ToString().Trim();       //列名
            mstrType_Name = objDT.Rows[0]["Type_Name"].ToString().Trim();       //数据类型
            mintlength = Int32.Parse(objDT.Rows[0]["length"].ToString().Trim());       //字段长度
            mstrIs_Nullable = objDT.Rows[0]["Is_Nullable"].ToString().Trim();       //是否可空
            mstrCOLUMN_DEF = objDT.Rows[0]["COLUMN_DEF"].ToString().Trim();       //字段缺省值
            mintPRECISION = TransNullToInt(objDT.Rows[0]["PRECISION"].ToString().Trim());       //精确度
            objDT = null;
            return true;
        }

        public static System.Data.DataTable GetColumns(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from Columns where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        public ArrayList GetColumnsObjList(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from Columns where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsColumns objColumns = new clsColumns();
                objColumns.Column_Name = objRow["Column_Name"].ToString().Trim();     //列名
                objColumns.Type_Name = objRow["Type_Name"].ToString().Trim();     //数据类型
                objColumns.length = Int32.Parse(objRow["length"].ToString().Trim());     //字段长度
                objColumns.Is_Nullable = objRow["Is_Nullable"].ToString().Trim();     //是否可空
                objColumns.COLUMN_DEF = objRow["COLUMN_DEF"].ToString().Trim();     //字段缺省值
                objColumns.PRECISION = TransNullToInt(objRow["PRECISION"].ToString().Trim());     //精确度
                arrObjList.Add(objColumns);
            }
            objDT = null;
            return arrObjList;
        }

        public clsColumns GetFirstColumns(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL = "Select * from Columns where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            DataRow objRow = objDT.Rows[0];
            clsColumns objColumns = new clsColumns();
            objColumns.Column_Name = objRow["Column_Name"].ToString().Trim();     //列名
            objColumns.Type_Name = objRow["Type_Name"].ToString().Trim();     //数据类型
            objColumns.length = Int32.Parse(objRow["length"].ToString().Trim());     //字段长度
            objColumns.Is_Nullable = objRow["Is_Nullable"].ToString().Trim();     //是否可空
            objColumns.COLUMN_DEF = objRow["COLUMN_DEF"].ToString().Trim();     //字段缺省值
            objColumns.PRECISION = TransNullToInt(objRow["PRECISION"].ToString().Trim());     //精确度
            objDT = null;
            return objColumns;
        }



        /// <summary>
        /// 功能：获取某一条件的相关表视图(View)
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
        public static System.Data.DataTable GetColumnsV(string strCondition)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL.Append("Select vColumns.* ");
            strSQL.Append(" from vColumns ");
            strSQL.Append(" where " + strCondition);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }


        public override bool IsExist()
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            if (objSQL.IsExistRecord("Columns", "Column_Name=" + "'" + mstrColumn_Name + "'"))
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
        /// <param name="strColumn_Name">给定的关键字值</param>
        /// <returns>返回是否存在?</returns>
        public static bool IsExist(string strColumn_Name)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            if (objSQL.IsExistRecord("Columns", "Column_Name=" + "'" + strColumn_Name + "'"))
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
            if (Object.Equals(null, mstrColumn_Name)
            || (!Object.Equals(null, mstrColumn_Name) && mstrColumn_Name.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[列名]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrType_Name)
            || (!Object.Equals(null, mstrType_Name) && mstrType_Name.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[数据类型]不能为空(NULL)!");
            }
            if (Object.Equals(null, mintlength)
            || (!Object.Equals(null, mintlength) && mintlength.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[字段长度]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrIs_Nullable)
            || (!Object.Equals(null, mstrIs_Nullable) && mstrIs_Nullable.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[是否可空]不能为空(NULL)!");
            }
            if (!Object.Equals(null, mstrColumn_Name) && getStrLen(mstrColumn_Name) > 50)
            {
                throw new clsDbObjException("字段[列名]的长度不能超过50!");
            }
            if (!Object.Equals(null, mstrType_Name) && getStrLen(mstrType_Name) > 50)
            {
                throw new clsDbObjException("字段[数据类型]的长度不能超过50!");
            }
            if (!Object.Equals(null, mstrIs_Nullable) && getStrLen(mstrIs_Nullable) > 20)
            {
                throw new clsDbObjException("字段[是否可空]的长度不能超过20!");
            }
            if (!Object.Equals(null, mstrCOLUMN_DEF) && getStrLen(mstrCOLUMN_DEF) > 50)
            {
                throw new clsDbObjException("字段[字段缺省值]的长度不能超过50!");
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
            strSQL = "Select Column_Name from Columns where " + strCondtion;
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
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strKeyValue;
            strSQL = "Select Column_Name from Columns where " + strCondtion;
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
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strKeyValue;
            strSQL = "Select Column_Name from Columns where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsColumns");
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