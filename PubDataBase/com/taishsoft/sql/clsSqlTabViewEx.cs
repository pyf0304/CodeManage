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
        //�����ͼ��ص��ж����б�
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
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select Id, Name from SqlTabView ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }

        ///���ɰ�ListView�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��ListView�С�
        /// </summary>
        public static int BindLv_SqlTabView(System.Windows.Forms.ListView lvSqlTabView, string strWhereCond)
        {
            //	�������裺(��4��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3������ListView����ͷ��Ϣ
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

            System.Windows.Forms.ListViewItem lviSqlTabView;
            ArrayList arrSqlTabViewObjList;
            //	2��������������ȡ�ñ�����������DataTable��
            arrSqlTabViewObjList = new clsSqlTabView().GetSqlTabViewObjList(strWhereCond);
            //	3������ListView����ͷ��Ϣ
            lvSqlTabView.Items.Clear();//���ԭ������Item
            lvSqlTabView.Columns.Clear();//���ԭ��������ͷ��Ϣ
            lvSqlTabView.Columns.Add("����Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlTabView.Columns.Add("����ͼ��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlTabView.View = System.Windows.Forms.View.Details;
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            foreach (clsSqlTabView objSqlTabView in arrSqlTabViewObjList)
            {
                lviSqlTabView = new System.Windows.Forms.ListViewItem();
                lviSqlTabView.Tag = objSqlTabView.Id;
                lviSqlTabView.Text = objSqlTabView.Id.ToString();
                lviSqlTabView.SubItems.Add(objSqlTabView.Name);
                lvSqlTabView.Items.Add(lviSqlTabView);
            }
            //	4�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
            return arrSqlTabViewObjList.Count;
        }
        /// <summary>
        /// �޸ı�--����ֶ�
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="objColumns">�ж���</param>
        /// <param name="strConnectString">������</param>
        /// <param name="strDatabaseOwner">ӵ����</param>
        /// <returns>�ɹ�?</returns>
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
            string strFieldLength, strFieldLength0;		//�ֶγ���
            ArrayList arrFieldCodes = new ArrayList();

            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strAlterTabCode.AppendFormat("Alter table [{0}].[{1}] add \r\r\n",
               strDatabaseOwner,
               strTabName
               );

            //�ֶ���
            strAlterTabCode.AppendFormat("\t{0}", objColumns.Column_Name);

            //�����ֶ�����
            strAlterTabCode.AppendFormat(" {0}", objColumns.Type_Name);

            //�����ֶγ���
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
            //�����Ƿ�ɿ�

            if (objColumns.Is_Nullable == "YES")
            {
                strAlterTabCode.Append(" Null");
            }
            else
            {
                strAlterTabCode.Append(" not Null");
                //���ȱʡֵ��
                string strDefaultValueStr = CombineDefaultValueString(strFieldType, objColumns.COLUMN_DEF);
                strAlterTabCode.AppendFormat(" {0}", strDefaultValueStr);
            }

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            return objSQL.ExecSql(strAlterTabCode.ToString());
        }


        /// <summary>
        /// �޸ı�--Ϊ����ȥ��Identity����
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strConstraint_Name">����Լ����</param>
        /// <param name="objColumns">�ж���</param>
        /// <param name="strConnectString">������</param>
        /// <param name="strDatabaseOwner">ӵ����</param>
        /// <returns>�ɹ�?</returns>
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
            //�����ʱ�����ֶ�
            //alter table aa1 add iid bigint not null default 0
            ////������ֵ���Ƶ���ʱ�ֶ�
            // update aa1 set iid=mid ;
            ////ɾ���������
            //alter table aa1 drop constraint aa1_pk;
            ////ɾ�����ԭ������
            // alter table aa1 drop column mid ;
            ////����ʱ����������Ϊԭ������
            // exec sp_rename 'aa1.iid','mid' ;

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);

            string strTempPrimeryKey = "TzIdForUpdateIdentity";
            if (clsSqlObject.IsExistColumnInTable(strConnectString, strTabName, strDatabaseOwner, strTempPrimeryKey) == false)
            {
                //�����ʱ�����ֶ�
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
                    throw new Exception("�������ʱ�ֶ�������" + objException.Message);

                }
                strAlterTabCode = new StringBuilder();
            }
            ////������ֵ���Ƶ���ʱ�ֶ�
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
                throw new Exception("��ԭ����ֵ���Ƶ����ֶΣ�update {0} set��������" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();


            //�޸ı��޸���ʱ�����ֶ�Ϊ�ǿ�
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
                throw new Exception("�޸ı��޸���ʱ�����ֶ�Ϊ�ǿ�������" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();
            

            ////ɾ���������
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
                throw new Exception("ɾ��������Լ����ϵ������" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();
            ////ɾ����������ֶ�
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
                throw new Exception("ɾ���������ֶ�������" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();
            ////����ʱ����������Ϊԭ������
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
                throw new Exception("Sql���������exec sp_rename��������" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();
            //�޸ı��������
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
                throw new Exception("������������ֶ����ó�������" + objException.Message);

            }


            return true;
        }


        /// <summary>
        /// �޸ı�--Ϊ����ȥ��Identity����
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strConstraint_Name">����Լ����</param>
        /// <param name="strConnectString">������</param>
        /// <returns>�ɹ�?</returns>
        public static bool AlterTab4DropConstraint(string strTabName,
                                string strConstraint_Name,
                                string strConnectString)
        {
            StringBuilder sbMessage = new StringBuilder();
            StringBuilder strAlterTabCode = new StringBuilder();

            ArrayList arrFieldCodes = new ArrayList();

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);

            strAlterTabCode = new StringBuilder();


            ////ɾ���������
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
                throw new Exception("ɾ��������Լ����ϵ������" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();


            return true;
        }


        /// <summary>
        /// �޸ı�--Ϊ����ȥ��Identity����
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strConnectString">������</param>
        /// <param name="strDatabaseOwner">ӵ����</param>
        /// <returns>�ɹ�?</returns>
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

                //�����ʱ�����ֶ�
            strAlterTabCode.AppendFormat("SET IDENTITY_INSERT {0}.{1} ON;",
                            strDatabaseOwner,
                            strTabName);
                try
                {
                    objSQL.ExecSql(strAlterTabCode.ToString());
                }
                catch (Exception objException)
                {
                    throw new Exception("���ñ�ʶ�У�Identity��������ӱ�ʶֵ������" + objException.Message);

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

            //�����ʱ�����ֶ�
            strAlterTabCode.AppendFormat("SET IDENTITY_INSERT {0}.{1} OFF;",
                            strDatabaseOwner,
                            strTabName);
            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                throw new Exception("���ñ�ʶ�У�Identity����ֹ��ӱ�ʶֵ������" + objException.Message);

            }

            return true;
        }

        /// <summary>
        /// �޸ı�--Ϊ�������Identity����,��ʱ��ʵ��
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strConstraint_Name">����Լ����</param>
        /// <param name="objColumns">�ж���</param>
        /// <param name="strConnectString">������</param>
        /// <param name="strDatabaseOwner">ӵ����</param>
        /// <returns>�ɹ�?</returns>
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
            //�����ʱ�����ֶ�
            //alter table aa1 add iid bigint not null default 0
            ////������ֵ���Ƶ���ʱ�ֶ�
            // update aa1 set iid=mid ;
            ////ɾ���������
            //alter table aa1 drop constraint aa1_pk;
            ////ɾ�����ԭ������
            // alter table aa1 drop column mid ;
            ////����ʱ����������Ϊԭ������
            // exec sp_rename 'aa1.iid','mid' ;

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            string strTempPrimeryKey = "TzIdForUpdateIdentity";

            if (clsSqlObject.IsExistColumnInTable(strConnectString, strTabName, strDatabaseOwner, strTempPrimeryKey) == false)
            {
                //�����ʱ�����ֶ�
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
                    throw new Exception("�������ʱ�ֶ�������" + objException.Message);

                }
                strAlterTabCode = new StringBuilder();
            }
            ////������ֵ���Ƶ���ʱ�ֶ�
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
                throw new Exception("��ԭ����ֵ���Ƶ����ֶΣ�update {0} set��������" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();


            //�޸ı��޸���ʱ�����ֶ�Ϊ�ǿ�
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
                throw new Exception("�޸ı��޸���ʱ�����ֶ�Ϊ�ǿ�������" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();


            ////ɾ���������
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
                throw new Exception("ɾ��������Լ����ϵ������" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();
            ////ɾ����������ֶ�
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
                throw new Exception("ɾ���������ֶ�������" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();
            ////����ʱ����������Ϊԭ������
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
                throw new Exception("Sql���������exec sp_rename��������" + objException.Message);

            }
            strAlterTabCode = new StringBuilder();
            //�޸ı��������
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
                throw new Exception("������������ֶ����ó�������" + objException.Message);

            }


            return true;
        }


        /// <summary>
        /// ������ͼ
        /// </summary>
        /// <param name="strViewName">��ͼ��</param>       
        /// <param name="strViewText">��ͼ�ı�����</param>
        /// <param name="strConnectString">������</param>
        /// <param name="strDatabaseOwner">ӵ����</param>
        /// <returns>�ɹ�?</returns>
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
            //�����ʱ�����ֶ�
            //alter table aa1 add iid bigint not null default 0
            ////������ֵ���Ƶ���ʱ�ֶ�
            // update aa1 set iid=mid ;
            ////ɾ���������
            //alter table aa1 drop constraint aa1_pk;
            ////ɾ�����ԭ������
            // alter table aa1 drop column mid ;
            ////����ʱ����������Ϊԭ������
            // exec sp_rename 'aa1.iid','mid' ;

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            ////������ֵ���Ƶ���ʱ�ֶ�
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
                throw new Exception(new StringBuilder().AppendFormat("ɾ����ͼ��{0}.{1}������{2}", strDatabaseOwner, strViewName, objException.Message).ToString());

            }
            strAlterTabCode = new StringBuilder();


            //�޸ı��޸���ʱ�����ֶ�Ϊ�ǿ�
            //alter   table   aa1   alter column  iid bigint not null ;
            strAlterTabCode.Append(strViewText);
            try
            {
                objSQL.ExecSql(strAlterTabCode.ToString());
            }
            catch (Exception objException)
            {
                string strMsg = new StringBuilder().AppendFormat("�½���ͼ��{0}.{1}������:{2}. ��ͼ���ݣ���{3}��", strDatabaseOwner, strViewName, objException.Message, strViewText).ToString();
                throw new Exception(strMsg);
            }
            return true;
        }



        /// <summary>
        /// ɾ����ͼ
        /// </summary>
        /// <param name="strViewName">��ͼ��</param>       
        /// <param name="strConnectString">������</param>
        /// <param name="strDatabaseOwner">ӵ����</param>
        /// <returns>�ɹ�?</returns>
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
            //�����ʱ�����ֶ�
            //alter table aa1 add iid bigint not null default 0
            ////������ֵ���Ƶ���ʱ�ֶ�
            // update aa1 set iid=mid ;
            ////ɾ���������
            //alter table aa1 drop constraint aa1_pk;
            ////ɾ�����ԭ������
            // alter table aa1 drop column mid ;
            ////����ʱ����������Ϊԭ������
            // exec sp_rename 'aa1.iid','mid' ;

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            ////������ֵ���Ƶ���ʱ�ֶ�
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
                throw new Exception(new StringBuilder().AppendFormat("ɾ����ͼ��{0}.{1}������{2}", strDatabaseOwner, strViewName, objException.Message).ToString());
            }
          
            return true;
        }



        /// <summary>
        /// ��װSQL�ֶ��е�ȱʡֵ���ʽ
        /// </summary>
        /// <param name="strFieldType">�ֶ�����</param>
        /// <param name="strDefaultValue">ȱʡֵ</param>
        /// <returns>ȱʡֵ���ʽ</returns>
        private static string CombineDefaultValueString(string strFieldType, string strDefaultValue)
        {
            string strDefaultValueStr = "";
            if (string.IsNullOrEmpty(strDefaultValue) == true) //ϵͳ����ȱʡֵΪ��
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
            else   //ϵͳ����ȱʡֵ��Ϊ��
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

            //�����ʱ�����ֶ�
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
                sbMessage.AppendFormat("��ȡ��ͼ��{0}.{1}���������顣{2}", strDatabaseOwner, strViewName, objException.Message);
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
        /// ���ɿ��Խ����SQL���
        /// </summary>
        /// <returns>���Խ����SQL���</returns>
        public string GenSQLCode4CreateTab()
        {
            StringBuilder sbMessage = new StringBuilder();

            if (arrColumnsObjList.Count == 0)
            {
                sbMessage.AppendFormat("��ǰ��{0}���ֶ���Ϊ0���޷����ɽ���ű�!", this.Name);
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
            string strFieldLength, strFieldLength0;		//�ֶγ���

            ArrayList arrFieldCodes = new ArrayList();

            //��������˽������
            foreach (clsColumns objColumns in arrColumnsObjList)
            {
                //				strBuilder.Append("\r\n" +objColumns.DefPrivateProperty());

                //�����ֶ���
                strFieldName = objColumns.Column_Name;
                //�����ֶ�����
                strFieldType = objColumns.Type_Name;
                //�����ֶγ���
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

                //�����Ƿ�ɿ�

                if (objColumns.Is_Nullable.ToLower() == "yes")
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                //��������

                //if (objColumns.PrimaryTypeId == "02") //��ʶ������identity
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

                if (arrPkeysObjList.Count >0) //��ʶ������identity
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