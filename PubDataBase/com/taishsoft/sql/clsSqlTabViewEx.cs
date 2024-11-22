using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using System.Collections.Generic;

namespace com.taishsoft.sql
{
    public class clsSqlTabViewEx : clsSqlTabView
    {
        //与表视图相关的列对象列表
        public List<clsColumns> arrColumnsObjList = null;
        public List<clsFKeys> arrFKeysObjList = null;
        public List<clsPKeys> arrPkeysObjList = null;
        public clsPrjDataBaseEx objDataBase = null;
        public clsSqlTabViewEx()
            : base()
        {
        }

        public clsSqlTabViewEx(long lngId)
            : base(lngId)
        {
        }

        public clsSqlTabViewEx(long lngId, bool bolIsGetSqlTabView)
            : base(lngId, bolIsGetSqlTabView)
        {
        }


        public static System.Data.DataTable GetId()
        {
            //获取某学院所有专业信息
            string strSQL = "select Id, Name from SqlTabView ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }

        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_SqlTabView(System.Windows.Forms.ListView lvSqlTabView, string strWhereCond)
        {
            //	操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviSqlTabView;
            ArrayList arrSqlTabViewObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrSqlTabViewObjList = new clsSqlTabView().GetSqlTabViewObjList(strWhereCond);
            //	3、设置ListView的列头信息
            lvSqlTabView.Items.Clear();//清除原来所有Item
            lvSqlTabView.Columns.Clear();//清除原来所有列头信息
            lvSqlTabView.Columns.Add("对象Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlTabView.Columns.Add("表视图名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlTabView.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsSqlTabView objSqlTabView in arrSqlTabViewObjList)
            {
                lviSqlTabView = new System.Windows.Forms.ListViewItem();
                lviSqlTabView.Tag = objSqlTabView.Id;
                lviSqlTabView.Text = objSqlTabView.Id.ToString();
                lviSqlTabView.SubItems.Add(objSqlTabView.Name);
                lvSqlTabView.Items.Add(lviSqlTabView);
            }
            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrSqlTabViewObjList.Count;
        }
        /// <summary>
        /// 修改表--添加字段
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <param name="objColumns">列对象</param>
        /// <param name="strConnectString">连接者</param>
        /// <param name="strDatabaseOwner">拥有者</param>
        /// <returns>成功?</returns>
        public static bool AlterTab4AddField(string strTabName, 
                                        clsColumns objColumns,
                                        string strConnectString, 
                                        string strDatabaseOwner)
        {
            StringBuilder sbMessage = new StringBuilder();
            StringBuilder strAlterTabCode = new StringBuilder();

            string strFieldType;
            //			string strFieldType0;
            //string strPrimaryKey;		//, strPrimaryKey0;
            string strFieldLength, strFieldLength0;		//字段长度
            ArrayList arrFieldCodes = new ArrayList();

            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strAlterTabCode.AppendFormat("Alter table [{0}].[{1}] add \r\r\n",
               strDatabaseOwner,
               strTabName
               );

            //字段名
            strAlterTabCode.AppendFormat("\t{0}", objColumns.Column_Name);

            //计算字段类型
            strAlterTabCode.AppendFormat(" {0}", objColumns.Type_Name);

            //计算字段长度
            strFieldLength0 = objColumns.length.ToString();
            if (strFieldLength0 == string.Empty)
                strFieldLength = string.Empty;
            else
                strFieldLength = "(" + strFieldLength0 + ")";
            strFieldType = objColumns.Type_Name;
            if (strFieldType == "bigint" || strFieldType == "int"
                || strFieldType == "float" || strFieldType == "bit"
                || strFieldType == "double" || strFieldType == "text"
                || strFieldType == "timestamp" || strFieldType == "smallint"
                || strFieldType == "tinyint"
                || strFieldType == "image" || strFieldType == "bigint identity")
            {
                strFieldLength = string.Empty;
            }
            if (string.IsNullOrEmpty(strFieldLength) == false)
            {
                strAlterTabCode.AppendFormat(" {0}", strFieldLength);

            }
            //计算是否可空

            if (objColumns.Is_Nullable == "YES")
            {
                strAlterTabCode.Append(" Null");
            }
            else
            {
                strAlterTabCode.Append(" not Null");
                //组合缺省值串
                string strDefaultValueStr = CombineDefaultValueString(strFieldType, objColumns.COLUMN_DEF);
                strAlterTabCode.AppendFormat(" {0}", strDefaultValueStr);
            }

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            return objSQL.ExecSql(strAlterTabCode.ToString());
        }


        /// <summary>
        /// 修改表--为主键去除Identity属性
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <param name="strConstraint_Name">主键约束名</param>
        /// <param name="objColumns">列对象</param>
        /// <param name="strConnectString">连接者</param>
        /// <param name="strDatabaseOwner">拥有者</param>
        /// <returns>成功?</returns>
        public static bool AlterTab4DropIdentity4PrjmaryKey(string strTabName,
                                string strConstraint_Name,
                                clsColumns objColumns,
                                string strConnectString, 
                                string strDatabaseOwner)
        {
            StringBuilder sbMessage = new StringBuilder();
            StringBuilder strAlterTabCode = new StringBuilder();

            ArrayList arrFieldCodes = new ArrayList();

            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }
            //添加临时代替字段
            //alter table aa1 add iid bigint not null default 0
            ////把主键值复制到临时字段
            // update aa1 set iid=mid ;
            ////删除表的主键
            //alter table aa1 drop constraint aa1_pk;
            ////删除表的原主键列
            // alter table aa1 drop column mid ;
            ////把临时主键重命名为原主键名
            // exec sp_rename 'aa1.iid','mid' ;

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);

            string strTempPrimeryKey = "TzIdForUpdateIdentity";
            if (clsSqlObject.IsExistColumnInTable(strConnectString, strTabName, strDatabaseOwner, strTempPrimeryKey) == false)
            {
                //添加临时代替字段
                strAlterTabCode.AppendFormat("alter table {0} add {1} {2} null;",
                            strTabName,
                            strTempPrimeryKey,
                            objColumns.Type_Name);
                try
                {
                    objSQL.ExecSql(strAlterTabCode.ToString());
                }
                catch (Exception objException)
                {
                    throw new Exception("添加新临时字段有问题" + objException.Message);

                }
                strAlterTabCode = new StringBuilder();
            }
            ////把主键值复制到临时字段
            // update aa1 set iid=mid ;
            strAlterTabCode.AppendFormat("update {0} set {1}={2};",
                        strTabName,
                        strTempPrimeryKey,
                        objColumns.Column_Name);

            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                throw new Exception("把原主键值复制到新字段（update {0} set）有问题" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();


            //修改表，修改临时代替字段为非空
            //alter   table   aa1   alter column  iid bigint not null ;
            strAlterTabCode.AppendFormat("alter table {0} alter column {1} {2} not null;",
                        strTabName,
                        strTempPrimeryKey,
                        objColumns.Type_Name);
            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                throw new Exception("修改表，修改临时代替字段为非空有问题" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();
            

            ////删除表的主键
            //alter table aa1 drop constraint aa1_pk;
            strAlterTabCode.AppendFormat("alter table {0} drop constraint {1};",
                        strTabName,
                        strConstraint_Name);

            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                throw new Exception("删除表主键约束关系有问题" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();
            ////删除表的主键字段
            //alter table aa1 drop constraint aa1_pk;
            strAlterTabCode.AppendFormat("alter table {0} drop column {1}; ",
                        strTabName,
                        objColumns.Column_Name);

            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                throw new Exception("删除表主键字段有问题" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();
            ////把临时主键重命名为原主键名
            // exec sp_rename 'aa1.iid','mid' ;
            strAlterTabCode.AppendFormat("exec sp_rename '{0}.{1}','{2}';",
                        strTabName,
                        strTempPrimeryKey,
                        objColumns.Column_Name);
            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                throw new Exception("Sql对象改名（exec sp_rename）有问题" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();
            //修改表添加主键
            //a)	alter table UserGrade add  primary  key(GradeID)
            strAlterTabCode.AppendFormat("alter table {0} add primary key ({1});",
                        strTabName,
                        objColumns.Column_Name);
            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                throw new Exception("把重命名后的字段设置成有问题" + objException.Message);

            }


            return true;
        }


        /// <summary>
        /// 修改表--为主键去除Identity属性
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <param name="strConstraint_Name">主键约束名</param>
        /// <param name="strConnectString">连接者</param>
        /// <returns>成功?</returns>
        public static bool AlterTab4DropConstraint(string strTabName,
                                string strConstraint_Name,
                                string strConnectString)
        {
            StringBuilder sbMessage = new StringBuilder();
            StringBuilder strAlterTabCode = new StringBuilder();

            ArrayList arrFieldCodes = new ArrayList();

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);

            strAlterTabCode = new StringBuilder();


            ////删除表的主键
            //alter table aa1 drop constraint aa1_pk;
            strAlterTabCode.AppendFormat("alter table {0} drop constraint {1};",
                        strTabName,
                        strConstraint_Name);

            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                throw new Exception("删除表主键约束关系有问题" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();


            return true;
        }


        /// <summary>
        /// 修改表--为主键去除Identity属性
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <param name="strConnectString">连接者</param>
        /// <param name="strDatabaseOwner">拥有者</param>
        /// <returns>成功?</returns>
        public static bool Exec_SetIdentityInsertOn(string strTabName,
                                string strConnectString,
                                string strDatabaseOwner)
        {
            StringBuilder sbMessage = new StringBuilder();
            StringBuilder strAlterTabCode = new StringBuilder();

            ArrayList arrFieldCodes = new ArrayList();

            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }
           
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);

                //添加临时代替字段
            strAlterTabCode.AppendFormat("SET IDENTITY_INSERT {0}.{1} ON;",
                            strDatabaseOwner,
                            strTabName);
                try
                {
                    objSQL.ExecSql(strAlterTabCode.ToString());
                }
                catch (Exception objException)
                {
                    throw new Exception("设置标识列（Identity）允许添加标识值有问题" + objException.Message);

                }

            return true;
        }

        public static bool Exec_SetIdentityInsertOff(string strTabName,
                                string strConnectString,
                                string strDatabaseOwner)
        {
            StringBuilder sbMessage = new StringBuilder();
            StringBuilder strAlterTabCode = new StringBuilder();

            ArrayList arrFieldCodes = new ArrayList();

            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);

            //添加临时代替字段
            strAlterTabCode.AppendFormat("SET IDENTITY_INSERT {0}.{1} OFF;",
                            strDatabaseOwner,
                            strTabName);
            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                throw new Exception("设置标识列（Identity）禁止添加标识值有问题" + objException.Message);

            }

            return true;
        }

        /// <summary>
        /// 修改表--为主键添加Identity属性,临时不实现
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <param name="strConstraint_Name">主键约束名</param>
        /// <param name="objColumns">列对象</param>
        /// <param name="strConnectString">连接者</param>
        /// <param name="strDatabaseOwner">拥有者</param>
        /// <returns>成功?</returns>
        public static bool BBBAlterTab4AddIdentity4PrjmaryKey(string strTabName,
                                string strConstraint_Name,
                                clsColumns objColumns,
                                string strConnectString,
                                string strDatabaseOwner)
        {
            StringBuilder sbMessage = new StringBuilder();
            StringBuilder strAlterTabCode = new StringBuilder();

            ArrayList arrFieldCodes = new ArrayList();

            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }
            //添加临时代替字段
            //alter table aa1 add iid bigint not null default 0
            ////把主键值复制到临时字段
            // update aa1 set iid=mid ;
            ////删除表的主键
            //alter table aa1 drop constraint aa1_pk;
            ////删除表的原主键列
            // alter table aa1 drop column mid ;
            ////把临时主键重命名为原主键名
            // exec sp_rename 'aa1.iid','mid' ;

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            string strTempPrimeryKey = "TzIdForUpdateIdentity";

            if (clsSqlObject.IsExistColumnInTable(strConnectString, strTabName, strDatabaseOwner, strTempPrimeryKey) == false)
            {
                //添加临时代替字段
                strAlterTabCode.AppendFormat("alter table {0} add {1} {2} identity null;",
                            strTabName,
                            strTempPrimeryKey,
                            objColumns.Type_Name);
                try
                {
                    objSQL.ExecSql(strAlterTabCode.ToString());
                }
                catch (Exception objException)
                {
                    throw new Exception("添加新临时字段有问题" + objException.Message);

                }
                strAlterTabCode = new StringBuilder();
            }
            ////把主键值复制到临时字段
            // update aa1 set iid=mid ;
            strAlterTabCode.AppendFormat("update {0} set {1}={2};",
                        strTabName,
                        strTempPrimeryKey,
                        objColumns.Column_Name);

            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                throw new Exception("把原主键值复制到新字段（update {0} set）有问题" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();


            //修改表，修改临时代替字段为非空
            //alter   table   aa1   alter column  iid bigint not null ;
            strAlterTabCode.AppendFormat("alter table {0} alter column {1} {2} not null;",
                        strTabName,
                        strTempPrimeryKey,
                        objColumns.Type_Name);
            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                throw new Exception("修改表，修改临时代替字段为非空有问题" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();


            ////删除表的主键
            //alter table aa1 drop constraint aa1_pk;
            strAlterTabCode.AppendFormat("alter table {0} drop constraint {1};",
                        strTabName,
                        strConstraint_Name);

            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                throw new Exception("删除表主键约束关系有问题" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();
            ////删除表的主键字段
            //alter table aa1 drop constraint aa1_pk;
            strAlterTabCode.AppendFormat("alter table {0} drop column {1} ",
                        strTabName,
                        objColumns.Column_Name);

            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                throw new Exception("删除表主键字段有问题" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();
            ////把临时主键重命名为原主键名
            // exec sp_rename 'aa1.iid','mid' ;
            strAlterTabCode.AppendFormat("exec sp_rename '{0}.{1}','{2}';",
                        strTabName,
                        strTempPrimeryKey,
                        objColumns.Column_Name);
            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                throw new Exception("Sql对象改名（exec sp_rename）有问题" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();
            //修改表添加主键
            //a)	alter table UserGrade add  primary  key(GradeID)
            strAlterTabCode.AppendFormat("alter table {0} add primary key ({1});",
                        strTabName,
                        objColumns.Column_Name);
            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                throw new Exception("把重命名后的字段设置成有问题" + objException.Message);

            }


            return true;
        }


        /// <summary>
        /// 建立视图
        /// </summary>
        /// <param name="strViewName">视图名</param>       
        /// <param name="strViewText">视图文本内容</param>
        /// <param name="strConnectString">连接者</param>
        /// <param name="strDatabaseOwner">拥有者</param>
        /// <returns>成功?</returns>
        public static bool CreateView(string strViewName,
                                string strViewText,
                                string strConnectString,
                                string strDatabaseOwner)
        {
            StringBuilder sbMessage = new StringBuilder();
            StringBuilder strAlterTabCode = new StringBuilder();

            ArrayList arrFieldCodes = new ArrayList();

            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }
            //添加临时代替字段
            //alter table aa1 add iid bigint not null default 0
            ////把主键值复制到临时字段
            // update aa1 set iid=mid ;
            ////删除表的主键
            //alter table aa1 drop constraint aa1_pk;
            ////删除表的原主键列
            // alter table aa1 drop column mid ;
            ////把临时主键重命名为原主键名
            // exec sp_rename 'aa1.iid','mid' ;

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            ////把主键值复制到临时字段
            // update aa1 set iid=mid ;
            strAlterTabCode.AppendFormat(" if exists (select * from dbo.sysobjects where id = object_id(N'[{0}].[{1}]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [{0}].[{1}];",
                        strDatabaseOwner,
                        strViewName);
           
            //strAlterTabCode.AppendFormat(" drop view [{0}].[{1}];",
            //   strDatabaseOwner,
            //   strViewName);

    
            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                throw new Exception(new StringBuilder().AppendFormat("删除视图（{0}.{1}）出错！{2}", strDatabaseOwner, strViewName, objException.Message).ToString());

            }
            strAlterTabCode = new StringBuilder();


            //修改表，修改临时代替字段为非空
            //alter   table   aa1   alter column  iid bigint not null ;
            strAlterTabCode.Append(strViewText);
            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                string strMsg = new StringBuilder().AppendFormat("新建视图（{0}.{1}）出错:{2}. 视图内容：（{3}）", strDatabaseOwner, strViewName, objException.Message, strViewText).ToString();
                throw new Exception(strMsg);
            }
            return true;
        }



        /// <summary>
        /// 删除视图
        /// </summary>
        /// <param name="strViewName">视图名</param>       
        /// <param name="strConnectString">连接者</param>
        /// <param name="strDatabaseOwner">拥有者</param>
        /// <returns>成功?</returns>
        public static bool DeleteView(string strViewName,                              
                                string strConnectString,
                                string strDatabaseOwner)
        {
            StringBuilder sbMessage = new StringBuilder();
            StringBuilder strAlterTabCode = new StringBuilder();

            ArrayList arrFieldCodes = new ArrayList();

            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }
            //添加临时代替字段
            //alter table aa1 add iid bigint not null default 0
            ////把主键值复制到临时字段
            // update aa1 set iid=mid ;
            ////删除表的主键
            //alter table aa1 drop constraint aa1_pk;
            ////删除表的原主键列
            // alter table aa1 drop column mid ;
            ////把临时主键重命名为原主键名
            // exec sp_rename 'aa1.iid','mid' ;

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            ////把主键值复制到临时字段
            // update aa1 set iid=mid ;
            strAlterTabCode.AppendFormat(" if exists (select * from dbo.sysobjects where id = object_id(N'[{0}].[{1}]') and OBJECTPROPERTY(id, N'IsView') = 1) drop view [{0}].[{1}];",
                        strDatabaseOwner,
                        strViewName);

            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                throw new Exception(new StringBuilder().AppendFormat("删除视图（{0}.{1}）出错！{2}", strDatabaseOwner, strViewName, objException.Message).ToString());
            }
          
            return true;
        }



        /// <summary>
        /// 组装SQL字段中的缺省值表达式
        /// </summary>
        /// <param name="strFieldType">字段类型</param>
        /// <param name="strDefaultValue">缺省值</param>
        /// <returns>缺省值表达式</returns>
        private static string CombineDefaultValueString(string strFieldType, string strDefaultValue)
        {
            string strDefaultValueStr = "";
            if (string.IsNullOrEmpty(strDefaultValue) == true) //系统设置缺省值为空
            {
                if (strFieldType == "varchar" || strFieldType == "char")
                {
                    strDefaultValueStr = "default ''";
                }
                else if (strFieldType == "bigint" || strFieldType == "int")
                {
                    strDefaultValueStr = "default 0";
                }
                else if (strFieldType == "float" || strFieldType == "bit")
                {
                    strDefaultValueStr = "default 0.0";
                }
                else if (strFieldType == "double")
                {
                    strDefaultValueStr = "default 0.0";

                }
                else if (strFieldType == "text")
                {
                    strDefaultValueStr = "default ''";
                }
                else if (strFieldType == "timestamp")
                {
                }
                else if (strFieldType == "smallint")
                {
                    strDefaultValueStr = "default 0";
                }
                else if (strFieldType == "tinyint")
                {
                    strDefaultValueStr = "default 0";
                }
                else if (strFieldType == "image")
                {
                }
                else if (strFieldType == "bigint identity")
                {
                    strDefaultValueStr = "";
                }
            }
            else   //系统设置缺省值不为空
            {
                if (strFieldType == "varchar" || strFieldType == "char")
                {
                    if (strDefaultValue.ToLower() == "space")
                    {
                        strDefaultValueStr = "default ''";
                    }
                    else
                    {
                        strDefaultValueStr = "default " + strDefaultValue;
                    }
                }
                else if (strFieldType == "bigint" || strFieldType == "int")
                {
                    strDefaultValueStr = "default " + strDefaultValue;
                }
                else if (strFieldType == "float" || strFieldType == "bit")
                {
                    strDefaultValueStr = "default " + strDefaultValue;
                }
                else if (strFieldType == "double")
                {
                    strDefaultValueStr = "default " + strDefaultValue;
                }
                else if (strFieldType == "text")
                {
                    if (strDefaultValue.ToLower() == "space")
                    {
                        strDefaultValueStr = "default ''";
                    }
                    else
                    {
                        strDefaultValueStr = "default " + strDefaultValue;
                    }
                }
                else if (strFieldType == "timestamp")
                {
                }
                else if (strFieldType == "smallint")
                {
                    strDefaultValueStr = "default " + strDefaultValue;
                }
                else if (strFieldType == "tinyint")
                {
                    strDefaultValueStr = "default " + strDefaultValue;
                }
                else if (strFieldType == "image")
                {
                }
                else if (strFieldType == "bigint identity")
                {
                    strDefaultValueStr = string.Empty;
                }
            }
            return strDefaultValueStr;
        }
        public static string GetViewText(string strViewName,
                                string strConnectString,
                                string strDatabaseOwner)
        {
            StringBuilder sbMessage = new StringBuilder();
            StringBuilder sbSql = new StringBuilder();
            StringBuilder sbViewText = new StringBuilder();
            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);

            //添加临时代替字段
            sbSql.AppendFormat("sp_helptext '{0}.{1}';",
                            strDatabaseOwner,
                            strViewName);
            try
            {
                DataTable objDT = objSQL.GetDataTable(sbSql.ToString());
                foreach (DataRow objRow in objDT.Rows)
                {
                    sbViewText.AppendLine(objRow[0].ToString());
                }                
            }
            catch (Exception objException)
            {
                sbMessage.AppendFormat("获取视图（{0}.{1}）出错请检查。{2}", strDatabaseOwner, strViewName, objException.Message);
                throw new Exception(sbMessage.ToString() );

            }
            string strTemp = sbViewText.Replace("dbo.", strDatabaseOwner + ".").ToString();
            return strTemp;
        }

        public bool GetTableInfo()
        {
            objDataBase = new clsPrjDataBaseEx();
            objDataBase.IpAddress = this.Server;
            objDataBase.DataBaseName = this.DataBaseName;
            objDataBase.DataBaseUserId=this.UserId;
            objDataBase.DataBasePwd = this.Password;
            objDataBase.DataBaseTypeId = "01";
            arrColumnsObjList = clsSqlObject.GetColumnObjList(this.Name, objDataBase.ConnectString, this.Owner);
            arrPkeysObjList = clsSqlObject.GetPKeyObjList(objDataBase.ConnectString, this.Name, this.Owner);
            //arrFKeysObjList = clsSqlObject.GetPKeys();
            return true;
        }
        /// <summary>
        /// 生成可以建表的SQL语句
        /// </summary>
        /// <returns>可以建表的SQL语句</returns>
        public string GenSQLCode4CreateTab()
        {
            StringBuilder sbMessage = new StringBuilder();

            if (arrColumnsObjList.Count == 0)
            {
                sbMessage.AppendFormat("当前表：{0}的字段数为0，无法生成建表脚本!", this.Name);
                throw new Exception(sbMessage.ToString());
            }

            StringBuilder strCreateTabCode = new StringBuilder();

            string strDatabaseOwner;
            string strFieldCode;
            string strFieldName;
            string strFieldType;
            //			string strFieldType0;
            string strIsNullable;		//, strIsNullable0;		// =" null ";
            string strPrimaryKey;		//, strPrimaryKey0;
            string strFieldLength, strFieldLength0;		//字段长度

            ArrayList arrFieldCodes = new ArrayList();

            //定义类中私有属性
            foreach (clsColumns objColumns in arrColumnsObjList)
            {
                //				strBuilder.Append("\r\n" +objColumns.DefPrivateProperty());

                //计算字段名
                strFieldName = objColumns.Column_Name;
                //计算字段类型
                strFieldType = objColumns.Type_Name;
                //计算字段长度
                strFieldLength0 = objColumns.length.ToString();
                if (strFieldLength0 == string.Empty)
                    strFieldLength = string.Empty;
                else
                    strFieldLength = "(" + strFieldLength0 + ")";
                if (strFieldType == "bigint" || strFieldType == "int"
                    || strFieldType == "float" || strFieldType == "bit"
                    || strFieldType == "double" || strFieldType == "text"
                    || strFieldType == "timestamp" || strFieldType == "smallint"
                    || strFieldType == "tinyint"
                    || strFieldType == "image" || strFieldType == "bigint identity")
                {
                    strFieldLength = string.Empty;
                }

                //计算是否可空

                if (objColumns.Is_Nullable.ToLower() == "yes")
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                //计算主键

                //if (objColumns.PrimaryTypeId == "02") //标识型主键identity
                //{
                //    strPrimaryKey = " primary key identity";
                //}
                //else if (objColumns.IsTabPrimary)
                //{
                //    strPrimaryKey = " primary key";
                //}
                //else
                //{
                //    strPrimaryKey = "";
                //}

                if (arrPkeysObjList.Count >0) //标识型主键identity
                {
                    clsPKeys objPkeys = (clsPKeys)arrPkeysObjList[0];
                    string strPrimaryFieldName = objPkeys.COLUMN_NAME;
                    if (strPrimaryFieldName.Equals(strFieldName, StringComparison.CurrentCultureIgnoreCase) == true)
                    {
                        strPrimaryKey = " primary key ";
                    }
                    else
                    {
                        strPrimaryKey = "";
                    }
                }
                else
                {
                    strPrimaryKey = "";
                }

                if (strPrimaryKey == "")
                {
                    strFieldCode = " " + strFieldName + " " + strFieldType + strFieldLength + strIsNullable;
                }
                else
                {
                    strFieldCode = " " + strFieldName + " " + strFieldType + strFieldLength + strPrimaryKey;
                }
                arrFieldCodes.Add(strFieldCode);
            }
            string[] sstrFieldCode = (string[])(arrFieldCodes.ToArray(System.Type.GetType("System.String")));
            string strTabBodyCode = string.Join(", \r\n", sstrFieldCode);
            strDatabaseOwner = this.Owner;
            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strCreateTabCode.AppendFormat("CREATE table [{2}].[{0}] ({1}) \r\r\n", this.Name, strTabBodyCode, strDatabaseOwner);
            strCreateTabCode.Append("ON [PRIMARY] ");
            //			strCreateTabCode.Append("\r\r\nGO");
            //						Response.Write(strCreateTabCode.ToString());
            return strCreateTabCode.ToString();

        }

    }
}