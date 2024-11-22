
///----------------------
///生成代码版本：2013.04.17.1
///生成日期：2013/06/19
///生成者：潘以锋
///工程名称：AGC_CSV7
///工程ID：0005
///模块中文名：系统参数
///模块英文名：SysPara
///注意：1、需要数据底层（PubDataBase.dll）的版本：2013.04.05.3
///       2、需要公共函数层（TzPubFunction.dll）的版本：2013.04.25.2
///========================
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
    /// 表外键(FKeys)
    /// </summary>
    [Serializable]
    public class clsFKeys : clsGeneralTab2
    {
        /// <summary>
        /// 当前表名，与该类相关的表名
        /// </summary>
        public const string CurrTabName_S = "FKeys";
        /// <summary>
        /// 当前表中的关键字名称，与该类相关的表中关键字名
        /// </summary>
        public const string CurrTabKeyFldName_S = "Id";
        /// <summary>
        /// 当前类的属性个数
        /// </summary>
        protected const int mintAttributeCount = 12;
        /// <summary>
        /// 当前类的属性名数组
        /// </summary>
        public static string[] AttributeName = new string[] { "Id", "FKeyName", "FKeyColumnID", "FKeyColumnName", "FKeyTabID", "FKeyTabName", "PKeyColumnID", "PKeyColumnName", "PKeyTabId", "PKeyTabName", "Update_Action", "Delete_Action" };
        //以下是属性变量

        /// <summary> 
        /// 对象Id(字段类型:bigint,字段长度:8,是否可空:False)
        /// </summary>
        protected long mlngId;
        /// <summary> 
        /// 外键名称(字段类型:varchar,字段长度:128,是否可空:False)
        /// </summary>
        protected string mstrFKeyName;
        /// <summary> 
        /// 外键列Id(字段类型:varchar,字段长度:128,是否可空:False)
        /// </summary>
        protected string mstrFKeyColumnID;
        /// <summary> 
        /// 外键列名(字段类型:varchar,字段长度:128,是否可空:False)
        /// </summary>
        protected string mstrFKeyColumnName;
        /// <summary> 
        /// 外键表ID(字段类型:varchar,字段长度:128,是否可空:True)
        /// </summary>
        protected string mstrFKeyTabID;
        /// <summary> 
        /// 外键表名称(字段类型:varchar,字段长度:128,是否可空:False)
        /// </summary>
        protected string mstrFKeyTabName;
        /// <summary> 
        /// 主键列ID(字段类型:varchar,字段长度:128,是否可空:False)
        /// </summary>
        protected string mstrPKeyColumnID;
        /// <summary> 
        /// 主键列名(字段类型:varchar,字段长度:128,是否可空:False)
        /// </summary>
        protected string mstrPKeyColumnName;
        /// <summary> 
        /// 主键表Id(字段类型:varchar,字段长度:128,是否可空:False)
        /// </summary>
        protected string mstrPKeyTabId;
        /// <summary> 
        /// 主键表名(字段类型:varchar,字段长度:128,是否可空:False)
        /// </summary>
        protected string mstrPKeyTabName;
        /// <summary> 
        /// 级联更新(字段类型:varchar,字段长度:128,是否可空:False)
        /// </summary>
        protected string mstrUpdate_Action;
        /// <summary> 
        /// 级联删除(字段类型:int,字段长度:4,是否可空:False)
        /// </summary>
        protected int mintDelete_Action;

        /// <summary> 
        /// 整型Tag(字段类型:int,字段长度:4,是否可空:False)
        /// </summary>
        protected int mintIntTag;

        /// <summary> 
        /// 字符型标签(字段类型:string,字段长度:1000,是否可空:False)
        /// </summary>
        protected string mstrStrTag;

        /// <summary> 
        /// 是否检查属性(字段类型:bool,字段长度:1,是否可空:False)
        /// </summary>
        protected bool mbolIsCheckProperty;

        //用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
        private static string m_strConnectString;
        /// <summary>
        /// 当前类指定的连接串
        /// </summary>
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }
        private string m_strConnectString_Obj;
        /// <summary>
        /// 当前对象指定的连接串
        /// </summary>
        public string ConnectString_Obj
        {
            get { return m_strConnectString_Obj; }
            set { m_strConnectString_Obj = value; }
        }

        /// <summary>
        /// 当前类的构造函数
        /// </summary>
        public clsFKeys()
        {
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "FKeys";
            lstKeyFldNames.Add("Id");
        }

        /// <summary>
        /// 当前类的构造函数
        /// </summary>
        /// <param name="lngId">对象Id</param>
        public clsFKeys(long lngId)
        {
            if (lngId == 0)
            {
                throw new Exception("关键字不能为0！");
            }

            mlngId = lngId;
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "FKeys";
            lstKeyFldNames.Add("Id");
        }

        /// <summary>
        /// 当前类的构造函数
        /// </summary>
        /// <param name="lngId">对象Id</param>
        /// <param name="bolIsGetFKeys">是否获取该关键字相关的记录属性</param>
        public clsFKeys(long lngId, bool bolIsGetFKeys)
        {
            if (lngId == 0)
            {
                throw new Exception("关键字不能为0！");
            }

            mlngId = lngId;
            SetInit();
            mbolIsCheckProperty = false;
            if (bolIsGetFKeys == true)
            {
                //GetFKeys();
            }
            _CurrTabName = "FKeys";
            lstKeyFldNames.Add("Id");
        }



        /// <summary>
        /// 当前类的属性的个数
        /// </summary>
        public static int AttributeCount
        {
            get
            {
                return mintAttributeCount;
            }
        }
        /// <summary>
        /// 根据属性的名称(字符型名称)存取该属性的值
        /// </summary>
        /// <param name="strAttributeName">属性名称(字符型)</param>
        /// <returns>该属性的值</returns>
        public object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == "Id")
                {
                    return mlngId;
                }
                else if (strAttributeName == "FKeyName")
                {
                    return mstrFKeyName;
                }
                else if (strAttributeName == "FKeyColumnID")
                {
                    return mstrFKeyColumnID;
                }
                else if (strAttributeName == "FKeyColumnName")
                {
                    return mstrFKeyColumnName;
                }
                else if (strAttributeName == "FKeyTabID")
                {
                    return mstrFKeyTabID;
                }
                else if (strAttributeName == "FKeyTabName")
                {
                    return mstrFKeyTabName;
                }
                else if (strAttributeName == "PKeyColumnID")
                {
                    return mstrPKeyColumnID;
                }
                else if (strAttributeName == "PKeyColumnName")
                {
                    return mstrPKeyColumnName;
                }
                else if (strAttributeName == "PKeyTabId")
                {
                    return mstrPKeyTabId;
                }
                else if (strAttributeName == "PKeyTabName")
                {
                    return mstrPKeyTabName;
                }
                else if (strAttributeName == "Update_Action")
                {
                    return mstrUpdate_Action;
                }
                else if (strAttributeName == "Delete_Action")
                {
                    return mintDelete_Action;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "Id")
                {
                    mlngId = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "FKeyName")
                {
                    mstrFKeyName = value.ToString();
                }
                else if (strAttributeName == "FKeyColumnID")
                {
                    mstrFKeyColumnID = value.ToString();
                }
                else if (strAttributeName == "FKeyColumnName")
                {
                    mstrFKeyColumnName = value.ToString();
                }
                else if (strAttributeName == "FKeyTabID")
                {
                    mstrFKeyTabID = value.ToString();
                }
                else if (strAttributeName == "FKeyTabName")
                {
                    mstrFKeyTabName = value.ToString();
                }
                else if (strAttributeName == "PKeyColumnID")
                {
                    mstrPKeyColumnID = value.ToString();
                }
                else if (strAttributeName == "PKeyColumnName")
                {
                    mstrPKeyColumnName = value.ToString();
                }
                else if (strAttributeName == "PKeyTabId")
                {
                    mstrPKeyTabId = value.ToString();
                }
                else if (strAttributeName == "PKeyTabName")
                {
                    mstrPKeyTabName = value.ToString();
                }
                else if (strAttributeName == "Update_Action")
                {
                    mstrUpdate_Action = value.ToString();
                }
                else if (strAttributeName == "Delete_Action")
                {
                    mintDelete_Action = TransNullToInt(value.ToString());
                }
            }
        }
        /// <summary>
        /// 根据属性的序号(整型)存取该属性的值
        /// </summary>
        /// <param name="intIndex">属性序号(整型)</param>
        /// <returns>该属性的值</returns>
        public object this[int intIndex]
        {
            get
            {
                if ("Id" == AttributeName[intIndex])
                {
                    return mlngId;
                }
                else if ("FKeyName" == AttributeName[intIndex])
                {
                    return mstrFKeyName;
                }
                else if ("FKeyColumnID" == AttributeName[intIndex])
                {
                    return mstrFKeyColumnID;
                }
                else if ("FKeyColumnName" == AttributeName[intIndex])
                {
                    return mstrFKeyColumnName;
                }
                else if ("FKeyTabID" == AttributeName[intIndex])
                {
                    return mstrFKeyTabID;
                }
                else if ("FKeyTabName" == AttributeName[intIndex])
                {
                    return mstrFKeyTabName;
                }
                else if ("PKeyColumnID" == AttributeName[intIndex])
                {
                    return mstrPKeyColumnID;
                }
                else if ("PKeyColumnName" == AttributeName[intIndex])
                {
                    return mstrPKeyColumnName;
                }
                else if ("PKeyTabId" == AttributeName[intIndex])
                {
                    return mstrPKeyTabId;
                }
                else if ("PKeyTabName" == AttributeName[intIndex])
                {
                    return mstrPKeyTabName;
                }
                else if ("Update_Action" == AttributeName[intIndex])
                {
                    return mstrUpdate_Action;
                }
                else if ("Delete_Action" == AttributeName[intIndex])
                {
                    return mintDelete_Action;
                }
                return null;
            }
            set
            {
                if ("Id" == AttributeName[intIndex])
                {
                    mlngId = TransNullToInt(value.ToString());
                }
                else if ("FKeyName" == AttributeName[intIndex])
                {
                    mstrFKeyName = value.ToString();
                }
                else if ("FKeyColumnID" == AttributeName[intIndex])
                {
                    mstrFKeyColumnID = value.ToString();
                }
                else if ("FKeyColumnName" == AttributeName[intIndex])
                {
                    mstrFKeyColumnName = value.ToString();
                }
                else if ("FKeyTabID" == AttributeName[intIndex])
                {
                    mstrFKeyTabID = value.ToString();
                }
                else if ("FKeyTabName" == AttributeName[intIndex])
                {
                    mstrFKeyTabName = value.ToString();
                }
                else if ("PKeyColumnID" == AttributeName[intIndex])
                {
                    mstrPKeyColumnID = value.ToString();
                }
                else if ("PKeyColumnName" == AttributeName[intIndex])
                {
                    mstrPKeyColumnName = value.ToString();
                }
                else if ("PKeyTabId" == AttributeName[intIndex])
                {
                    mstrPKeyTabId = value.ToString();
                }
                else if ("PKeyTabName" == AttributeName[intIndex])
                {
                    mstrPKeyTabName = value.ToString();
                }
                else if ("Update_Action" == AttributeName[intIndex])
                {
                    mstrUpdate_Action = value.ToString();
                }
                else if ("Delete_Action" == AttributeName[intIndex])
                {
                    mintDelete_Action = TransNullToInt(value.ToString());
                }
            }
        }

        /// <summary>
        /// 对象Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
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
                //记录修改过的字段
                AddUpdatedFld("Id");
            }
        }
        /// <summary>
        /// 外键名称(说明:;字段类型:varchar;字段长度:128;是否可空:False)
        /// </summary>
        public string FKeyName
        {
            get
            {
                return mstrFKeyName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFKeyName = value;
                }
                else
                {
                    mstrFKeyName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("FKeyName");
            }
        }
        /// <summary>
        /// 外键列Id(说明:;字段类型:varchar;字段长度:128;是否可空:False)
        /// </summary>
        public string FKeyColumnID
        {
            get
            {
                return mstrFKeyColumnID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFKeyColumnID = value;
                }
                else
                {
                    mstrFKeyColumnID = value;
                }
                //记录修改过的字段
                AddUpdatedFld("FKeyColumnID");
            }
        }
        /// <summary>
        /// 外键列名(说明:;字段类型:varchar;字段长度:128;是否可空:False)
        /// </summary>
        public string FKeyColumnName
        {
            get
            {
                return mstrFKeyColumnName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFKeyColumnName = value;
                }
                else
                {
                    mstrFKeyColumnName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("FKeyColumnName");
            }
        }
        /// <summary>
        /// 外键表ID(说明:;字段类型:varchar;字段长度:128;是否可空:True)
        /// </summary>
        public string FKeyTabID
        {
            get
            {
                return mstrFKeyTabID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFKeyTabID = value;
                }
                else
                {
                    mstrFKeyTabID = value;
                }
                //记录修改过的字段
                AddUpdatedFld("FKeyTabID");
            }
        }
        /// <summary>
        /// 外键表名称(说明:;字段类型:varchar;字段长度:128;是否可空:False)
        /// </summary>
        public string FKeyTabName
        {
            get
            {
                return mstrFKeyTabName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFKeyTabName = value;
                }
                else
                {
                    mstrFKeyTabName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("FKeyTabName");
            }
        }
        /// <summary>
        /// 主键列ID(说明:;字段类型:varchar;字段长度:128;是否可空:False)
        /// </summary>
        public string PKeyColumnID
        {
            get
            {
                return mstrPKeyColumnID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPKeyColumnID = value;
                }
                else
                {
                    mstrPKeyColumnID = value;
                }
                //记录修改过的字段
                AddUpdatedFld("PKeyColumnID");
            }
        }
        /// <summary>
        /// 主键列名(说明:;字段类型:varchar;字段长度:128;是否可空:False)
        /// </summary>
        public string PKeyColumnName
        {
            get
            {
                return mstrPKeyColumnName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPKeyColumnName = value;
                }
                else
                {
                    mstrPKeyColumnName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("PKeyColumnName");
            }
        }
        /// <summary>
        /// 主键表Id(说明:;字段类型:varchar;字段长度:128;是否可空:False)
        /// </summary>
        public string PKeyTabId
        {
            get
            {
                return mstrPKeyTabId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPKeyTabId = value;
                }
                else
                {
                    mstrPKeyTabId = value;
                }
                //记录修改过的字段
                AddUpdatedFld("PKeyTabId");
            }
        }
        /// <summary>
        /// 主键表名(说明:;字段类型:varchar;字段长度:128;是否可空:False)
        /// </summary>
        public string PKeyTabName
        {
            get
            {
                return mstrPKeyTabName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPKeyTabName = value;
                }
                else
                {
                    mstrPKeyTabName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("PKeyTabName");
            }
        }
        /// <summary>
        /// 级联更新(说明:;字段类型:varchar;字段长度:128;是否可空:False)
        /// </summary>
        public string Update_Action
        {
            get
            {
                return mstrUpdate_Action;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrUpdate_Action = value;
                }
                else
                {
                    mstrUpdate_Action = value;
                }
                //记录修改过的字段
                AddUpdatedFld("Update_Action");
            }
        }
        /// <summary>
        /// 级联删除(说明:;字段类型:int;字段长度:4;是否可空:False)
        /// </summary>
        public int Delete_Action
        {
            get
            {
                return mintDelete_Action;
            }
            set
            {
                mintDelete_Action = value;
                //记录修改过的字段
                AddUpdatedFld("Delete_Action");
            }
        }
        /// <summary>
        /// 整型Tag(说明:;字段类型:int;字段长度:4;是否可空:False)
        /// </summary>
        public int IntTag
        {
            get
            {
                return mintIntTag;
            }
            set
            {
                mintIntTag = value;
                //记录修改过的字段
                AddUpdatedFld("IntTag");
            }
        }
        /// <summary>
        /// 字符型标签(说明:;字段类型:string;字段长度:1000;是否可空:False)
        /// </summary>
        public string StrTag
        {
            get
            {
                return mstrStrTag;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrStrTag = value;
                }
                else
                {
                    mstrStrTag = value;
                }
                //记录修改过的字段
                AddUpdatedFld("StrTag");
            }
        }
        /// <summary>
        /// 是否检查属性(说明:;字段类型:bool;字段长度:1;是否可空:False)
        /// </summary>
        public bool IsCheckProperty
        {
            get
            {
                return mbolIsCheckProperty;
            }
            set
            {
                mbolIsCheckProperty = value;
                //记录修改过的字段
                AddUpdatedFld("IsCheckProperty");
            }
        }

        ///// <summary>
        ///// 获取SQL服务器连接对象
        ///// </summary>
        ///// <returns>SQL服务器连接对象</returns>
        //public static clsSpecSQLforSql GetSpecSQLObj()
        //{
        //    clsSpecSQLforSql objSQL = null;
        //    //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
        //    if (clsSysPara.bolIsUseConnectStrName == true)
        //    {
        //        objSQL = new clsSpecSQLforSql(clsSysPara.strConnectStrName, true);
        //        return objSQL;
        //    }
        //    //2. 如果类所指定的连接串非空,就用该类所指定的连接串
        //    //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
        //    if (string.IsNullOrEmpty(clsFKeys.ConnectString) == true)
        //    {
        //        objSQL = new clsSpecSQLforSql();
        //    }
        //    else
        //    {
        //        objSQL = new clsSpecSQLforSql(clsFKeys.ConnectString);
        //    }
        //    return objSQL;
        //}


        public void CopyTo(clsFKeys objFKeys)
        {
            objFKeys.Id = mlngId; //对象Id
            objFKeys.FKeyName = mstrFKeyName; //外键名称
            objFKeys.FKeyColumnID = mstrFKeyColumnID; //外键列Id
            objFKeys.FKeyColumnName = mstrFKeyColumnName; //外键列名
            objFKeys.FKeyTabID = mstrFKeyTabID; //外键表ID
            objFKeys.FKeyTabName = mstrFKeyTabName; //外键表名称
            objFKeys.PKeyColumnID = mstrPKeyColumnID; //主键列ID
            objFKeys.PKeyColumnName = mstrPKeyColumnName; //主键列名
            objFKeys.PKeyTabId = mstrPKeyTabId; //主键表Id
            objFKeys.PKeyTabName = mstrPKeyTabName; //主键表名
            objFKeys.Update_Action = mstrUpdate_Action; //级联更新
            objFKeys.Delete_Action = mintDelete_Action; //级联删除
        }

        public void CopyTo(clsFKeys objFKeysS, clsFKeys objFKeysT)
        {
            objFKeysT.Id = objFKeysS.Id; //对象Id
            objFKeysT.FKeyName = objFKeysS.FKeyName; //外键名称
            objFKeysT.FKeyColumnID = objFKeysS.FKeyColumnID; //外键列Id
            objFKeysT.FKeyColumnName = objFKeysS.FKeyColumnName; //外键列名
            objFKeysT.FKeyTabID = objFKeysS.FKeyTabID; //外键表ID
            objFKeysT.FKeyTabName = objFKeysS.FKeyTabName; //外键表名称
            objFKeysT.PKeyColumnID = objFKeysS.PKeyColumnID; //主键列ID
            objFKeysT.PKeyColumnName = objFKeysS.PKeyColumnName; //主键列名
            objFKeysT.PKeyTabId = objFKeysS.PKeyTabId; //主键表Id
            objFKeysT.PKeyTabName = objFKeysS.PKeyTabName; //主键表名
            objFKeysT.Update_Action = objFKeysS.Update_Action; //级联更新
            objFKeysT.Delete_Action = objFKeysS.Delete_Action; //级联删除
        }


        /// <summary>
        /// 把DataRow转换成记录对象.
        /// </summary>
        /// <param name="objRow">所给的DataRow</param>
        /// <returns>记录对象</returns>
        public clsFKeys GetFKeysObjByDataRow(DataRow objRow)
        {
            if (objRow == null)
            {
                return null;
            }
            clsFKeys objFKeys = new clsFKeys();
            objFKeys.Id = Int32.Parse(objRow["Id"].ToString().Trim()); //对象Id
            objFKeys.FKeyName = objRow["FKeyName"].ToString().Trim(); //外键名称
            objFKeys.FKeyColumnID = objRow["FKeyColumnID"].ToString().Trim(); //外键列Id
            objFKeys.FKeyColumnName = objRow["FKeyColumnName"].ToString().Trim(); //外键列名
            objFKeys.FKeyTabID = objRow["FKeyTabID"].ToString().Trim(); //外键表ID
            objFKeys.FKeyTabName = objRow["FKeyTabName"].ToString().Trim(); //外键表名称
            objFKeys.PKeyColumnID = objRow["PKeyColumnID"].ToString().Trim(); //主键列ID
            objFKeys.PKeyColumnName = objRow["PKeyColumnName"].ToString().Trim(); //主键列名
            objFKeys.PKeyTabId = objRow["PKeyTabId"].ToString().Trim(); //主键表Id
            objFKeys.PKeyTabName = objRow["PKeyTabName"].ToString().Trim(); //主键表名
            objFKeys.Update_Action = objRow["Update_Action"].ToString().Trim(); //级联更新
            objFKeys.Delete_Action = Int32.Parse(objRow["Delete_Action"].ToString().Trim()); //级联删除
            objFKeys.ClearUpdateState();//清除修改状态,即清除脏字段信息
            return objFKeys;
        }

   
        /// <summary>
        /// 获取满足条件的所有记录对象列表,用对象列表的形式表示
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>满足条件的所有记录对象列表</returns>
        public List<clsFKeys> GetFKeysObjList_List(string strCondition)
        {
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0}，请检查！", objException.Message));
            }
            List<clsFKeys> arrObjList = new List<clsFKeys>();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = null;// this.GetSpecSQLObj_Obj();
            strSQL = "Select * from FKeys where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsFKeys objFKeys = new clsFKeys();
                objFKeys.Id = Int32.Parse(objRow["Id"].ToString().Trim()); //对象Id
                objFKeys.FKeyName = objRow["FKeyName"].ToString().Trim(); //外键名称
                objFKeys.FKeyColumnID = objRow["FKeyColumnID"].ToString().Trim(); //外键列Id
                objFKeys.FKeyColumnName = objRow["FKeyColumnName"].ToString().Trim(); //外键列名
                objFKeys.FKeyTabID = objRow["FKeyTabID"].ToString().Trim(); //外键表ID
                objFKeys.FKeyTabName = objRow["FKeyTabName"].ToString().Trim(); //外键表名称
                objFKeys.PKeyColumnID = objRow["PKeyColumnID"].ToString().Trim(); //主键列ID
                objFKeys.PKeyColumnName = objRow["PKeyColumnName"].ToString().Trim(); //主键列名
                objFKeys.PKeyTabId = objRow["PKeyTabId"].ToString().Trim(); //主键表Id
                objFKeys.PKeyTabName = objRow["PKeyTabName"].ToString().Trim(); //主键表名
                objFKeys.Update_Action = objRow["Update_Action"].ToString().Trim(); //级联更新
                objFKeys.Delete_Action = Int32.Parse(objRow["Delete_Action"].ToString().Trim()); //级联删除
                objFKeys.ClearUpdateState();//清除修改状态,即清除脏字段信息
                arrObjList.Add(objFKeys);
            }
            objDT = null;
            return arrObjList;
        }

   
        /// <summary>
        /// 检查字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
        /// </summary>
        public void CheckPropertyNew()
        {
            if (Object.Equals(null, mstrFKeyName)
            || (!Object.Equals(null, mstrFKeyName) && mstrFKeyName.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[外键名称]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrFKeyColumnID)
            || (!Object.Equals(null, mstrFKeyColumnID) && mstrFKeyColumnID.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[外键列Id]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrFKeyColumnName)
            || (!Object.Equals(null, mstrFKeyColumnName) && mstrFKeyColumnName.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[外键列名]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrFKeyTabName)
            || (!Object.Equals(null, mstrFKeyTabName) && mstrFKeyTabName.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[外键表名称]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrPKeyColumnID)
            || (!Object.Equals(null, mstrPKeyColumnID) && mstrPKeyColumnID.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[主键列ID]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrPKeyColumnName)
            || (!Object.Equals(null, mstrPKeyColumnName) && mstrPKeyColumnName.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[主键列名]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrPKeyTabId)
            || (!Object.Equals(null, mstrPKeyTabId) && mstrPKeyTabId.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[主键表Id]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrPKeyTabName)
            || (!Object.Equals(null, mstrPKeyTabName) && mstrPKeyTabName.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[主键表名]不能为空(NULL)!");
            }
            if (Object.Equals(null, mstrUpdate_Action)
            || (!Object.Equals(null, mstrUpdate_Action) && mstrUpdate_Action.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[级联更新]不能为空(NULL)!");
            }
            if (Object.Equals(null, mintDelete_Action)
            || (!Object.Equals(null, mintDelete_Action) && mintDelete_Action.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[级联删除]不能为空(NULL)!");
            }
            if (!Object.Equals(null, mstrFKeyName) && getStrLen(mstrFKeyName) > 128)
            {
                throw new clsDbObjException("字段[外键名称]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrFKeyColumnID) && getStrLen(mstrFKeyColumnID) > 128)
            {
                throw new clsDbObjException("字段[外键列Id]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrFKeyColumnName) && getStrLen(mstrFKeyColumnName) > 128)
            {
                throw new clsDbObjException("字段[外键列名]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrFKeyTabID) && getStrLen(mstrFKeyTabID) > 128)
            {
                throw new clsDbObjException("字段[外键表ID]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrFKeyTabName) && getStrLen(mstrFKeyTabName) > 128)
            {
                throw new clsDbObjException("字段[外键表名称]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrPKeyColumnID) && getStrLen(mstrPKeyColumnID) > 128)
            {
                throw new clsDbObjException("字段[主键列ID]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrPKeyColumnName) && getStrLen(mstrPKeyColumnName) > 128)
            {
                throw new clsDbObjException("字段[主键列名]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrPKeyTabId) && getStrLen(mstrPKeyTabId) > 128)
            {
                throw new clsDbObjException("字段[主键表Id]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrPKeyTabName) && getStrLen(mstrPKeyTabName) > 128)
            {
                throw new clsDbObjException("字段[主键表名]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrUpdate_Action) && getStrLen(mstrUpdate_Action) > 128)
            {
                throw new clsDbObjException("字段[级联更新]的长度不能超过128!");
            }
            mbolIsCheckProperty = true;
        }
        /// <summary>
        /// 专业针对修改的检查字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
        /// </summary>
        public void CheckProperty4Update()
        {
            if (!Object.Equals(null, mstrFKeyName) && getStrLen(mstrFKeyName) > 128)
            {
                throw new clsDbObjException("字段[外键名称]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrFKeyColumnID) && getStrLen(mstrFKeyColumnID) > 128)
            {
                throw new clsDbObjException("字段[外键列Id]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrFKeyColumnName) && getStrLen(mstrFKeyColumnName) > 128)
            {
                throw new clsDbObjException("字段[外键列名]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrFKeyTabID) && getStrLen(mstrFKeyTabID) > 128)
            {
                throw new clsDbObjException("字段[外键表ID]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrFKeyTabName) && getStrLen(mstrFKeyTabName) > 128)
            {
                throw new clsDbObjException("字段[外键表名称]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrPKeyColumnID) && getStrLen(mstrPKeyColumnID) > 128)
            {
                throw new clsDbObjException("字段[主键列ID]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrPKeyColumnName) && getStrLen(mstrPKeyColumnName) > 128)
            {
                throw new clsDbObjException("字段[主键列名]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrPKeyTabId) && getStrLen(mstrPKeyTabId) > 128)
            {
                throw new clsDbObjException("字段[主键表Id]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrPKeyTabName) && getStrLen(mstrPKeyTabName) > 128)
            {
                throw new clsDbObjException("字段[主键表名]的长度不能超过128!");
            }
            if (!Object.Equals(null, mstrUpdate_Action) && getStrLen(mstrUpdate_Action) > 128)
            {
                throw new clsDbObjException("字段[级联更新]的长度不能超过128!");
            }
            mbolIsCheckProperty = true;
        }



    }
}
