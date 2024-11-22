using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.sql;
using AGC_CSV7.Entity;
using com.taishsoft.datetime;
using AGC_CSV7.BusinessLogic;

namespace AGC_CSV7.BusinessLogicEx
{
    /// <summary>
    /// ����ר�����������ݱ�ı�����,�ô�������߼����һ����,��ϵ�ṹ���µ���,
    /// �������¼���:
    ///		1�������
    ///			ͨ�ý����,ר���ṩһЩ����ؼ��Ĺ�����������
    ///		2���߼���
    ///			2.1 ҵ���߼���
    ///			2.2 �����㡣����:
    ///					1)���¼����ӡ�
    ///					2)���¼��ɾ��
    ///					3)���¼���޸�
    ///					4)���¼�Ĳ�ѯ
    ///					5)��ȡĳЩ���¼���й��ֶ�����
    ///					6)���ñ��¼���й��ֶ����Եȡ�
    ///		3�����ݲ�,��ͨ�����ݲ�,ר�����ڲ������ݿ��һЩ����,�Լ��������һЩͨ�ò���
    /// </summary>
    public class AutoGCPubFuncV7 : clsPrjTabBLEx
    {
        //protected //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();

        public string ClsName;
        public string ClsNameEx;
        public string strTemp;

        protected bool mbolIsHaveImageField;
        protected string mstrImageFieldName;

        protected string mstrClsFName; //  '���ļ���
        protected string mstrFolderName; // '�ļ�Ŀ¼��

        protected string mstrFolderName_Root; // '���ļ�Ŀ¼��

        public string FolderName_Root
        {
            get { return mstrFolderName_Root; }
            set { mstrBackupFolderName = value; }
        }
        protected string mstrBackupFolderName; // '�ļ�Ŀ¼��
        /// <summary>
        /// ���ݵ��ļ�Ŀ¼
        /// </summary>
        public string BackupFolderName
        {
            get { return mstrBackupFolderName; }
            set { mstrBackupFolderName = value; }
        }

        protected string mstrFileName;

        #region ���캯��

        public AutoGCPubFuncV7()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public AutoGCPubFuncV7(string strViewId, string strPrjDataBaseId)
            : base(strViewId, strPrjDataBaseId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        #endregion

        public string FileName
        {
            get
            {
                return mstrFileName;
            }
            set
            {
                mstrFileName = value;
            }
        }
        public bool IsHaveImageField
        {
            get
            {
                return mbolIsHaveImageField; // '�ļ�Ŀ¼��
            }
            set
            {
                mbolIsHaveImageField = value;
            }
        }

        public string ImageFieldName
        {
            get
            {
                return mstrImageFieldName; // '�ļ�Ŀ¼��
            }
            set
            {
                mstrImageFieldName = value;
            }
        }

        public string FolderName
        {
            get
            {
                return mstrFolderName; // '�ļ�Ŀ¼��
            }
            set
            {
                mstrFolderName = value;
            }
        }

        public string GenSQLCode( clsPrjTabENEx objPrjTabENEx, string strPrjDataBaseId)
        {

            string strResult = "";

            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
                          objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!({1})",
                  objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            StringBuilder strCreateTabCode = new StringBuilder();
            string strDatabaseOwner;	//���ݿ�ӵ����
            string strFieldCode;
            string strRemark, strRemark0;
            string strFieldName;
            string strFieldType;
            //			string strFieldType0;
            string strIsNullable;		//, strIsNullable0;		// = " null ";
            string strPrimaryKey;		//, strPrimaryKey0;
            string strFieldLength, strFieldLength0;		//�ֶγ���

            ArrayList arrFieldCodes = new ArrayList();

            ///��������˽������
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSetAll)
            {
                //				strBuilder.Append("\r\n" +objPrjTabFldENEx.DefPrivateProperty());

                ///�����ֶ���
                strFieldName = objPrjTabFldENEx.objFieldTabENEx.FldName;
                ///�����ֶ�����
                strFieldType = objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///�����ֶγ���
                strFieldLength0 = objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString();
                if (strFieldLength0  ==  string.Empty)
                    strFieldLength = string.Empty;
                else
                    strFieldLength = "(" + strFieldLength0 + ")";
                //�жϸ����������Ƿ���Ҫ����
                if (clsSqlObject.IsNeedLength(strFieldType)  ==  false)
                {
                    strFieldLength = string.Empty;
                }
                ///�����ֶ�ע��(���ֶ���������)
                strRemark0 = objPrjTabFldENEx.objFieldTabENEx.Caption;
                if (strRemark0  ==  string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/*" + strRemark0 + "*/";

                ///�����Ƿ�ɿ�

                if (objPrjTabFldENEx.IsTabNullable  ==  true)
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                ///��������

                if (objPrjTabFldENEx.IsTabPrimary && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    strPrimaryKey = " primary key identity";
                }
                else if (objPrjTabFldENEx.IsTabPrimary)
                {
                    strPrimaryKey = " primary key";
                }
                else
                {
                    strPrimaryKey = "";
                }
                if (strPrimaryKey  ==  "")
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strIsNullable;
                }
                else
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strPrimaryKey;
                }
                arrFieldCodes.Add(strFieldCode);
            }
            string[] sstrFieldCode = (string[])(arrFieldCodes.ToArray(System.Type.GetType("System.String")));
            string strTabBodyCode = string.Join(",\r\r\n", sstrFieldCode);
            //clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            strDatabaseOwner = objPrjDataBaseEN.DatabaseOwner;
            if (strDatabaseOwner  ==  "")
            {
                strDatabaseOwner = "dbo";
            }
            strCreateTabCode.AppendFormat("CREATE table [{2}].[{0}] ({1}) \r\r\n", objPrjTabENEx.TabName, strTabBodyCode, strDatabaseOwner);
            strCreateTabCode.Append("ON [PRIMARY] ");
            strCreateTabCode.Append("\r\r\nGO");
            //						Response.Write(strCreateTabCode.ToString());
            return strCreateTabCode.ToString();

        }

        public string GenStoreProcedure_Add(clsPrjTabENEx objPrjTabENEx, string strPrjDataBaseId)
        {

            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = new clsUsersEN(objPrjTabENEx.UserId); clsUsersBL.GetUsers(ref objUsers);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
                objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
                clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Add ",
                objPrjDataBaseEN.DatabaseOwner,
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabPrimary  ==  true && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                //�жϸ����������Ƿ���Ҫ����
                if (clsSqlObject.IsNeedLength(objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName)  ==  false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1},",
                                            objPrjTabFldENEx.objFieldTabENEx.FldName,
                                            objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,

                                            objPrjTabFldENEx.objFieldTabENEx.FldLength);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2}),",
                            objPrjTabFldENEx.objFieldTabENEx.FldName,
                            objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                            objPrjTabFldENEx.objFieldTabENEx.FldLength);

                }
            }
            strCodeForCs.Remove(strCodeForCs.Length - 1, 1);
            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--��ʼ������");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            //��Ҫ�������ֶ��б�
            ArrayList arrFieldListForInsert = new ArrayList();
            //��Ҫ������ֵ�б�
            ArrayList arrValueListForInsert = new ArrayList();


            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if ((objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY) && (objPrjTabFldENEx.IsTabPrimary  ==  true))
                {
                    continue;
                }
                arrFieldListForInsert.Add(objPrjTabFldENEx.objFieldTabENEx.FldName);
                arrValueListForInsert.Add("@" + objPrjTabFldENEx.objFieldTabENEx.FldName);
            }

            //��֯�����¼SQL��
            string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
            string strFieldListCode = string.Join(",", sstrFieldCode);
            string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
            string strValuesListCode = string.Join(",", sstrValuesCode);

            strCodeForCs.AppendFormat("\r\n" + "insert into {0} ",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "({0}) values ({1}) ;", strFieldListCode, strValuesListCode);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--����ع�");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--����ȷ��");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL = null;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Add()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Add";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
                strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabPrimary  ==  true && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
                                    objPrjTabFldENEx.objFieldTabENEx.FldName,
                                    objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                                    objPrjTabFldENEx.objFieldTabENEx.FldLength);
            }
            //<Parameter name = "@Name" size = "10" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@Sex" size = "2" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@ClgId" size = "2" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@MajorId" size = "4" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@UserType" size = "10" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL = null;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Update()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Update";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
                strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
                                    objPrjTabFldENEx.objFieldTabENEx.FldName,
                                    objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                                    objPrjTabFldENEx.objFieldTabENEx.FldLength);
            }

            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL = null;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Delete()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Delete";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
                strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL = null;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Select()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Select";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
                strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL = null;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_SelectOne()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_SelectOne";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
                strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL = null;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedureXmlParameter_IsExist()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_IsExist";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
                strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            strCodeForCs.Append("\r\n" + "<Parameter name = \"@IsExist\" size = \"1\" datatype = \"Char\" direction = \"spParamOutput\" isNullable = \"False\" />");

            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL = null;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedureXmlParameter_SelectByCond()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_SelectByCond";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
                strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@strCond\" size = \"1000\" datatype = \"VarChar\" direction = \"spParamInput\" isNullable = \"False\" />",
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL = null;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedureXmlParameter_SelectTop1ByCond()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_SelectTop1ByCond";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
                strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@strCond\" size = \"1000\" datatype = \"VarChar\" direction = \"spParamInput\" isNullable = \"False\" />",
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL = null;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenStoreProcedure_Update(clsPrjTabENEx objPrjTabENEx, string strPrjDataBaseId)
        {
            return "";
            //clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            //string strMsg = "";
            //if (objPrjTabENEx.TabFldNum  ==  0)
            //{
            //    strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
            //    return strMsg;
            //}
            //if (objPrjTabENEx.KeyFldNum  ==  0)
            //{
            //    strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
            //    return strMsg;
            //}
            //clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            //StringBuilder strCodeForCs = new StringBuilder();

            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            //clsUsersEN objUsers = new clsUsersEN(objPrjTabENEx.UserId); clsUsersBL.GetUsers(ref objUsers);
            //strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            //    objUsers.UserId, objUsers.UserName);
            //strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            //    clsDateTime.getTodayStr(1));
            //strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            //strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Update ",
            //    objPrjDataBaseEN.DatabaseOwner,
            //    objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            //{
            //    //�жϸ����������Ƿ���Ҫ����
            //    if (clsSqlObject.IsNeedLength(objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName)  ==  false)
            //    {

            //        strCodeForCs.AppendFormat("\r\n" + "@{0} {1},",
            //                objPrjTabFldENEx.objFieldTabENEx.FldName,
            //                objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            //                objPrjTabFldENEx.objFieldTabENEx.FldLength);
            //    }
            //    else
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2}),",
            //                objPrjTabFldENEx.objFieldTabENEx.FldName,
            //                objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            //                objPrjTabFldENEx.objFieldTabENEx.FldLength);
            //    }
            //}
            //strCodeForCs.Remove(strCodeForCs.Length - 1, 1);
            ////@AcademyName varchar(30),
            ////@Memo varchar(1000)

            //strCodeForCs.Append("\r\n" + "AS");
            //strCodeForCs.Append("\r\n" + "BEGIN");
            //strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            //strCodeForCs.Append("\r\n" + "--��ʼ������");
            //strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            //strCodeForCs.AppendFormat("\r\n" + "update {0} set ",
            //    objPrjTabENEx.TabName);
            //foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            //{
            //    if (objPrjTabFldENEx.IsTabPrimary  ==  true)
            //    {
            //        continue;
            //    }
            //    strCodeForCs.AppendFormat("\r\n" + "{0} = @{0},", objPrjTabFldENEx.objFieldTabENEx.FldName);
            //}

            //strCodeForCs.Remove(strCodeForCs.Length - 1, 1);
            //strCodeForCs.AppendFormat("\r\n" + "Where {0} = @{0};", objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);

            //strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            //strCodeForCs.Append("\r\n" + "BEGIN");
            //strCodeForCs.Append("\r\n" + "--����ع�");
            //strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            //strCodeForCs.Append("\r\n" + "RETURN -1;");
            //strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "--����ȷ��");
            //strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            //strCodeForCs.Append("\r\n" + "return 0;");
            //strCodeForCs.Append("\r\n" + "END");
            //return strCodeForCs.ToString();            

        }


        public string GenStoreProcedure_Delete(clsPrjTabENEx objPrjTabENEx, string strPrjDataBaseId)
        {

            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = new clsUsersEN(objPrjTabENEx.UserId); clsUsersBL.GetUsers(ref objUsers);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
                objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
                clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Delete ",
                objPrjDataBaseEN.DatabaseOwner,
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //�жϸ����������Ƿ���Ҫ����
            if (clsSqlObject.IsNeedLength(objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName)  ==  false)
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}",
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2})",
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            }

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--��ʼ������");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "delete from {0} ",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Where {0} = @{0};", objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--����ع�");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--����ȷ��");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL = null;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedure_Select(clsPrjTabENEx objPrjTabENEx, string strPrjDataBaseId)
        {


            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = new clsUsersEN(objPrjTabENEx.UserId); clsUsersBL.GetUsers(ref objUsers);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
                objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
                clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Select ",
                objPrjDataBaseEN.DatabaseOwner,
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //�жϸ����������Ƿ���Ҫ����
            //if (clsSqlObject.IsNeedLength(objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName)  ==  false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "@{0} {1}",
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            //}
            //else
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2})",
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            //}

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--��ʼ������");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "Select * from {0} ",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "-- Where {0} = @{0};", objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--����ع�");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--����ȷ��");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL = null;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenStoreProcedure_SelectOne(clsPrjTabENEx objPrjTabENEx, string strPrjDataBaseId)
        {
            return "";


            //clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            //string strMsg = "";
            //if (objPrjTabENEx.TabFldNum  ==  0)
            //{
            //    strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
            //    return strMsg;
            //}
            //if (objPrjTabENEx.KeyFldNum  ==  0)
            //{
            //    strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
            //    return strMsg;
            //}
            //clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            //StringBuilder strCodeForCs = new StringBuilder();

            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            //clsUsersEN objUsers = new clsUsersEN(objPrjTabENEx.UserId); clsUsersBL.GetUsers(ref objUsers);
            //strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            //    objUsers.UserId, objUsers.UserName);
            //strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            //    clsDateTime.getTodayStr(1));
            //strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            //strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectOne ",
            //    objPrjDataBaseEN.DatabaseOwner,
            //    objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            ////�жϸ����������Ƿ���Ҫ����
            //if (clsSqlObject.IsNeedLength(objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName)  ==  false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "@{0} {1}",
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            //}
            //else
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2})",
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            //        objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            //}

            ////@AcademyName varchar(30),
            ////@Memo varchar(1000)

            //strCodeForCs.Append("\r\n" + "AS");
            //strCodeForCs.Append("\r\n" + "BEGIN");
            //strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            //strCodeForCs.Append("\r\n" + "--��ʼ������");
            //strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            //strCodeForCs.AppendFormat("\r\n" + "Select * from {0} ",
            //    objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "Where {0} = @{0};", objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);


            //strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            //strCodeForCs.Append("\r\n" + "BEGIN");
            //strCodeForCs.Append("\r\n" + "--����ع�");
            //strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            //strCodeForCs.Append("\r\n" + "RETURN -1;");
            //strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "--����ȷ��");
            //strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            //strCodeForCs.Append("\r\n" + "return 0;");
            //strCodeForCs.Append("\r\n" + "END");
            //return strCodeForCs.ToString();
    
        }


        public string GenStoreProcedure_IsExist(clsPrjTabENEx objPrjTabENEx, string strPrjDataBaseId)
        {


            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = new clsUsersEN(objPrjTabENEx.UserId); clsUsersBL.GetUsers(ref objUsers);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
                objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
                clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "-- Run Example:");
            strCodeForCs.Append("\r\n" + "-- declare @Exist char(1)");
            strCodeForCs.Append("\r\n" + "-- exec Student_IsExist '1005', @Exist out");
            strCodeForCs.Append("\r\n" + "-- select @Exist;");

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_IsExist ",
                objPrjDataBaseEN.DatabaseOwner,
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //�жϸ����������Ƿ���Ҫ����
            if (clsSqlObject.IsNeedLength(objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName)  ==  false)
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1},",
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2}),",
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            }
            strCodeForCs.Append("\r\n" + "@IsExist char(1) out");
            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.AppendFormat("\r\n" + "if (Exists(select * from {1} Where {0} = @{0}))",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "begin");
            strCodeForCs.Append("\r\n" + "set @IsExist = '1';");
            strCodeForCs.Append("\r\n" + "return 1;");
            strCodeForCs.Append("\r\n" + "end");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "begin");
            strCodeForCs.Append("\r\n" + "set @IsExist = '0'");
            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "end");
            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL = null;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedure_SelectByCond(clsPrjTabENEx objPrjTabENEx, string strPrjDataBaseId)
        {

            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = new clsUsersEN(objPrjTabENEx.UserId); clsUsersBL.GetUsers(ref objUsers);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
                objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
                clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectByCond ",
                objPrjDataBaseEN.DatabaseOwner,
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //�жϸ����������Ƿ���Ҫ����
            strCodeForCs.Append("\r\n" + "@strCond varchar(1000)");

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");

            strCodeForCs.Append("\r\n" + "declare @ret        int,    -- return value of sp call");
            strCodeForCs.Append("\r\n" + "@strSQL		nvarchar(4000)");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");

            strCodeForCs.AppendFormat("\r\n" + "set @strSQL = 'Select * from {0} ';",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + ' Where ';");
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + @strCond;");

            strCodeForCs.Append("\r\n" + "--��ʼ������");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");
            strCodeForCs.Append("\r\n" + "exec (@strSQL)");

            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--����ع�");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--����ȷ��");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL = null;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString);            
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenStoreProcedure_SelectTop1ByCond(clsPrjTabENEx objPrjTabENEx, string strPrjDataBaseId)
        {
            return "";
            //clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            //string strMsg = "";
            //if (objPrjTabENEx.TabFldNum  ==  0)
            //{
            //    strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
            //    return strMsg;
            //}
            //if (objPrjTabENEx.KeyFldNum  ==  0)
            //{
            //    strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
            //    return strMsg;
            //}
            //clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            //StringBuilder strCodeForCs = new StringBuilder();

            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            //clsUsersEN objUsers = new clsUsersEN(objPrjTabENEx.UserId); clsUsersBL.GetUsers(ref objUsers);
            //strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            //    objUsers.UserId, objUsers.UserName);
            //strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            //    clsDateTime.getTodayStr(1));
            //strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            //strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectTop1ByCond ",
            //    objPrjDataBaseEN.DatabaseOwner,
            //    objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            ////�жϸ����������Ƿ���Ҫ����
            //strCodeForCs.Append("\r\n" + "@strCond varchar(1000)");

            ////@AcademyName varchar(30),
            ////@Memo varchar(1000)

            //strCodeForCs.Append("\r\n" + "AS");
            //strCodeForCs.Append("\r\n" + "BEGIN");

            //strCodeForCs.Append("\r\n" + "declare @ret        int,    -- return value of sp call");
            //strCodeForCs.Append("\r\n" + "@strSQL		nvarchar(4000)");
            //strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");

            //strCodeForCs.AppendFormat("\r\n" + "set @strSQL = 'Select Top 1 * from {0} ';",
            //    objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + ' Where ';");
            //strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + @strCond;");

            //strCodeForCs.Append("\r\n" + "--��ʼ������");
            //strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");
            //strCodeForCs.Append("\r\n" + "exec (@strSQL)");

            //strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            //strCodeForCs.Append("\r\n" + "BEGIN");
            //strCodeForCs.Append("\r\n" + "--����ع�");
            //strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            //strCodeForCs.Append("\r\n" + "RETURN -1;");
            //strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "--����ȷ��");
            //strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            //strCodeForCs.Append("\r\n" + "return 0;");
            //strCodeForCs.Append("\r\n" + "END");
            //return strCodeForCs.ToString();
         

        }

        public string GenSQLCode4CreateTab(clsPrjTabENEx objPrjTabENEx, string strPrjDataBaseId)
        {


            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            string strResult = "";
            if (objPrjTabENEx.TabFldNum  ==  0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
                       objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum  ==  0)
            {
                strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!({1})",
                 objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            StringBuilder strCreateTabCode = new StringBuilder();
            string strDatabaseOwner;
            string strFieldCode;
            string strRemark, strRemark0;
            string strFieldName;
            string strFieldType;
            //			string strFieldType0;
            string strIsNullable;		//, strIsNullable0;		// = " null ";
            string strPrimaryKey;		//, strPrimaryKey0;
            string strFieldLength, strFieldLength0;		//�ֶγ���

            ArrayList arrFieldCodes = new ArrayList();

            ///��������˽������
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSetAll)
            {
                //				strBuilder.Append("\r\n" +objPrjTabFldENEx.DefPrivateProperty());

                ///�����ֶ���
                strFieldName = objPrjTabFldENEx.objFieldTabENEx.FldName;
                ///�����ֶ�����
                strFieldType = objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///�����ֶγ���
                strFieldLength0 = objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString();
                if (strFieldLength0  ==  string.Empty)
                    strFieldLength = string.Empty;
                else
                    strFieldLength = "(" + strFieldLength0 + ")";
                //�жϸ����������Ƿ���Ҫ����
                if (clsSqlObject.IsNeedLength(strFieldType)  ==  false)
                {
                    strFieldLength = string.Empty;
                }
                ///�����ֶ�ע��(���ֶ���������)
                strRemark0 = objPrjTabFldENEx.objFieldTabENEx.Caption;
                if (strRemark0  ==  string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/*" + strRemark0 + "*/";

                ///�����Ƿ�ɿ�

                if (objPrjTabFldENEx.IsTabNullable  ==  true)
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                ///��������
                if (objPrjTabFldENEx.IsTabPrimary && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    strPrimaryKey = " primary key identity";
                }
                else if (objPrjTabFldENEx.IsTabPrimary  ==  true)
                {
                    strPrimaryKey = " primary key";
                }
                else
                {
                    strPrimaryKey = "";
                }
                if (strPrimaryKey  ==  "")
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strIsNullable;
                }
                else
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strPrimaryKey;
                }
                arrFieldCodes.Add(strFieldCode);
            }
            string[] sstrFieldCode = (string[])(arrFieldCodes.ToArray(System.Type.GetType("System.String")));
            string strTabBodyCode = string.Join(",\r\r\n", sstrFieldCode);
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabENEx.PrjId);

            strDatabaseOwner = objPrjDataBaseEN.DatabaseOwner;
            if (strDatabaseOwner  ==  "")
            {
                strDatabaseOwner = "dbo";
            }

            strCreateTabCode.AppendFormat("CREATE table [{2}].[{0}] ({1}) \r\r\n", objPrjTabENEx.TabName, strTabBodyCode, strDatabaseOwner);
            strCreateTabCode.Append("ON [PRIMARY] ");
            //			strCreateTabCode.Append("\r\r\nGO");
            //						Response.Write(strCreateTabCode.ToString());
            return strCreateTabCode.ToString();

        }

        private string AccessNull(clsPrjTabFldENEx objPrjTabFldENEx)
        {
            string strContent = "";
            switch (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType)
            {
                case "byte":
                case "byte[]":
                    strContent = string.Format("objDT.Rows[cls{0}EN.con_{1}]", objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);

                    return AccessNull(strContent, objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable);
                default:
                    strContent = string.Format("objDT.Row[cls{0}EN.con_{1}].ToString().Trim()", objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                    return AccessNull(strContent, objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable);
            }
        }
        //private string AccessNull2(clsPrjTabFldENEx objPrjTabFldENEx)
        //{
        //    switch (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType)
        //    {
        //        case "byte":
        //        case "byte[]":
        //            return AccessNull("objRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"]", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable);
        //        default:
        //            return AccessNull("objRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"].ToString().Trim()", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable);
        //    }
        //}
        private string AccessNull2(clsPrjTabFldENEx objField)
        {
            string strContent = "";
            switch (objField.objFieldTabENEx.objDataTypeAbbrEN.CSType)
            {
                case "byte":
                case "byte[]":
                    strContent = string.Format("objRow[cls{0}EN.con_{1}]", objPrjTabENEx.TabName, objField.objFieldTabENEx.FldName);

                    return AccessNull(strContent, objField.objFieldTabENEx.objDataTypeAbbrEN.CSType, objField.IsTabNullable);
                default:
                    strContent = string.Format("objRow[cls{0}EN.con_{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.objFieldTabENEx.FldName);

                    return AccessNull(strContent, objField.objFieldTabENEx.objDataTypeAbbrEN.CSType, objField.IsTabNullable);
            }
        }
        private string AccessNull(string strContent, string strPropType, bool bolIsNullable)
        {
            //			string strReturn;
            //			strReturn = "";
            switch (strPropType)
            {
                case "string":
                    return strContent;
                case "int":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "short":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToShort(" + strContent + ")";
                    }
                    else
                    {
                        return "short.Parse(" + strContent + ")";
                    }
                case "DateTime":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToDate(" + strContent + ")";
                    }
                    else
                    {
                        return "System.DateTime.Parse(" + strContent + ")";
                    }
                case "Single":
                case "float":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToFloat(" + strContent + ")";
                    }
                    else
                    {
                        return "Single.Parse(" + strContent + ")";
                    }
                case "Double":
                case "Money":
                case "double":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToDouble(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "bool":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToBool(" + strContent + ")";
                    }
                    else
                    {
                        return "TransNullToBool(" + strContent + ")";
                        //20070701--return "bool.Parse(" + strContent + ")";
                    }
                case "Decimal":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToDouble(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "Long":
                case "long":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "Byte":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return strContent;
                    }
                case "byte[]":
                    return "(byte[])" + strContent;
                case "byte":
                    return "(byte)" + strContent;
                case "Int16":
                    if (bolIsNullable  ==  true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "System.Guid":
                    if (bolIsNullable  ==  true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
                default:
                    if (bolIsNullable  ==  true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
            }
        }//end of AccessNull

        private string Mark(clsPrjTabFldENEx pobjField)
        {
            if (pobjField.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
            {
                return "\"\'\"";
            }
            else
            {
                return "\"\"";
            }

        }


        //ƴװ�ؼ��ֵ�WHERE��
        private string KeyWhereStr()
        {
            bool isNeed_m = true;
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objPrjTabFldENEx.objFieldTabENEx.FldName + " = \" + " + Mark(objPrjTabFldENEx) + "+ " + (isNeed_m  ==  true ? "m" : "") + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + "+" + Mark(objPrjTabFldENEx);
                if (i  ==  0)	//�Ƿ��ǵ�һ��
                {
                    WhereStr +=  strTemp;
                }
                else
                {
                    WhereStr +=  " + \" and " + strTemp;
                }
                i++;
            }

            return WhereStr;
        }

        //ƴװ�ؼ��ֵ�WHERE��
        private string KeyWhereStrWithObject(string strObject)
        {
            //bool isNeed_m = true;
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objPrjTabFldENEx.objFieldTabENEx.FldName + " = \" + " + Mark(objPrjTabFldENEx) + "+ " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName(strObject) + "+" + Mark(objPrjTabFldENEx);
                if (i  ==  0)	//�Ƿ��ǵ�һ��
                {
                    WhereStr +=  strTemp;
                }
                else
                {
                    WhereStr +=  " + \" and " + strTemp;
                }
                i++;
            }

            return WhereStr;
        }
        private string KeyWhereStr(bool isNeed_m)
        {
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objPrjTabFldENEx.objFieldTabENEx.FldName + " = \" + " + Mark(objPrjTabFldENEx) + "+ " + (isNeed_m  ==  true ? "m" : "") + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + "+" + Mark(objPrjTabFldENEx);
                ///'strTemp = objPrjTabENEx.arrKeyFldSet[i].ColumnName + " = \"" + Mark(objPrjTabENEx.arrKeyFldSet[i]) + "+ " + "m" + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + Mark(objPrjTabENEx.arrKeyFldSet[i])
                if (i  ==  0)	//�Ƿ��ǵ�һ��
                {
                    WhereStr +=  strTemp;
                }
                else
                {
                    WhereStr +=  " + \" and " + strTemp;
                }
                i++;
            }

            return WhereStr;
        }


        /// <summary>
        /// �ؼ��ָ�ֵ,���ڹ��캯���йؼ��ָ���ֵ
        /// </summary>
        /// <returns>��ֵ���ʽ��</returns>
        private string GetKeyAssign()
        {
            string strPara, strTemp;
            strPara = "";
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objPrjTabFldENEx.objFieldTabENEx.PrivPropName + " = " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + ";";
                strPara +=  "\r\n" + strTemp;
            }
            return strPara;
        }
        //ƴװ�ؼ��ֵĴ�ֵ������
        private string GetKeyPara()
        {
            string strPara, strTemp;
            int i = 0;
            strPara = "";
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {

                strTemp = objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType + " " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName;
                if (i  ==  0)		//�Ƿ��ǵ�һ��
                {
                    strPara +=  strTemp;
                }
                else
                {
                    strPara +=  " , " + strTemp;
                }
                i++;
            }
            return strPara;
        }

        /// <summary>
        /// ���˽�б���,���������Ե�˽�б���
        /// </summary>
        /// <returns></returns>
        public string GenClsPrivateVar()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��������˽������
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.Append("\r\n" + objPrjTabFldENEx.objFieldTabENEx.DefPrivateProperty());
            }
            ////����Tag�ֶ�
            //clsPrjTabFldENEx objField1 = new clsPrjTabFldENEx();

            //objField1.objFieldTabENEx.FldName = "IntTag";
            //objField1.objFieldTabENEx.Caption = "����Tag";
            //objField1.objFieldTabENEx.FldLength = 4;
            //objField1.objFieldTabENEx.LangType = objPrjTabENEx.LangType;
            //objField1.objFieldTabENEx.objDataTypeAbbrEN = new clsDataTypeAbbrEN();
            //objField1.objFieldTabENEx.objDataTypeAbbrEN.CSType = "int";
            //objField1.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr = "int";
            //objField1.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName = "int";
            //strBuilder.Append("\r\n" + objField1.objFieldTabENEx.DefPrivateProperty());


            //clsPrjTabFldENEx objField2 = new clsPrjTabFldENEx();
            //objField2.objFieldTabENEx.FldName = "StrTag";
            //objField2.objFieldTabENEx.Caption = "�ַ��ͱ�ǩ";
            //objField2.objFieldTabENEx.FldLength = 1000;
            //objField2.objFieldTabENEx.LangType = objPrjTabENEx.LangType;
            //objField2.objFieldTabENEx.objDataTypeAbbrEN = new clsDataTypeAbbrEN();
            //objField2.objFieldTabENEx.objDataTypeAbbrEN.CSType = "string";
            //objField2.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr = "str";
            //objField2.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName = "string";
            //strBuilder.Append("\r\n" + objField2.objFieldTabENEx.DefPrivateProperty());


            //clsPrjTabFldENEx objField3 = new clsPrjTabFldENEx();
            //objField3.objFieldTabENEx.FldName = "IsCheckProperty";
            //objField3.objFieldTabENEx.Caption = "�Ƿ�������";
            //objField3.objFieldTabENEx.FldLength = 1;
            //objField3.objFieldTabENEx.LangType = objPrjTabENEx.LangType;
            //objField3.objFieldTabENEx.objDataTypeAbbrEN = new clsDataTypeAbbrEN();
            //objField3.objFieldTabENEx.objDataTypeAbbrEN.CSType = "bool";
            //objField3.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr = "bol";
            //objField3.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName = "bool";
            //strBuilder.Append("\r\n" + objField3.objFieldTabENEx.DefPrivateProperty());

            return strBuilder.ToString();
        }
        /// <summary>
        /// �๫����������
        /// </summary>
        /// <returns></returns>
        public string GenClsProperty()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///����������
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strTemp = objPrjTabFldENEx.objFieldTabENEx.ToString();
                strBuilder.Append("\r\n" + strTemp);
            }

            ////����Tag�ֶ�
            //clsPrjTabFldENEx objField1 = new clsPrjTabFldENEx();
            //objField1.objFieldTabENEx.FldName = "IntTag";
            //objField1.objFieldTabENEx.Caption = "����Tag";
            //objField1.objFieldTabENEx.FldLength = 4;
            //objField1.objFieldTabENEx.LangType = objPrjTabENEx.LangType;
            //objField1.objFieldTabENEx.objDataTypeAbbrEN = new clsDataTypeAbbrEN();
            //objField1.objFieldTabENEx.objDataTypeAbbrEN.CSType = "int";
            //objField1.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr = "int";
            //objField1.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName = "int";
            //strBuilder.Append("\r\n" + objField1.objFieldTabENEx.ToString());

            //clsPrjTabFldENEx objField2 = new clsPrjTabFldENEx();
            //objField2.objFieldTabENEx.FldName = "StrTag";
            //objField2.objFieldTabENEx.Caption = "�ַ��ͱ�ǩ";
            //objField2.objFieldTabENEx.FldLength = 1000;
            //objField2.objFieldTabENEx.LangType = objPrjTabENEx.LangType;
            //objField2.objFieldTabENEx.objDataTypeAbbrEN = new clsDataTypeAbbrEN();
            //objField2.objFieldTabENEx.objDataTypeAbbrEN.CSType = "string";
            //objField2.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr = "str";
            //objField2.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName = "string";
            //strBuilder.Append("\r\n" + objField2.objFieldTabENEx.ToString());


            //clsPrjTabFldENEx objField3 = new clsPrjTabFldENEx();
            //objField3.objFieldTabENEx.FldName = "IsCheckProperty";
            //objField3.objFieldTabENEx.Caption = "�Ƿ�������";
            //objField3.objFieldTabENEx.FldLength = 1;
            //objField3.objFieldTabENEx.LangType = objPrjTabENEx.LangType;
            //objField3.objFieldTabENEx.objDataTypeAbbrEN = new clsDataTypeAbbrEN();
            //objField3.objFieldTabENEx.objDataTypeAbbrEN.CSType = "bool";
            //objField3.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr = "bol";
            //objField3.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName = "bool";
            //strBuilder.Append("\r\n" + objField3.objFieldTabENEx.ToString());
            return strBuilder.ToString();
        }
        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        public string GenClsIndexer()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic static int AttributeCount");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn mintAttributeCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            //��������,�ַ�������
            strBuilder.Append("\r\npublic object this[string strAttributeName]");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget");
            strBuilder.Append("\r\n{");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.objFieldTabENEx.DataTypeId  ==  "08")
                {
                    continue;
                }
                if (bolIsFirst  ==  true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (strAttributeName  ==  \"{0}\")",
                        objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                        objPrjTabFldENEx.objFieldTabENEx.PrivPropName);
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (strAttributeName  ==  \"{0}\")",
                        objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                        objPrjTabFldENEx.objFieldTabENEx.PrivPropName);
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nset");
            strBuilder.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.objFieldTabENEx.DataTypeId  ==  "08")
                {
                    continue;
                }
                if (bolIsFirst  ==  true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (strAttributeName  ==  \"{0}\")",
                        objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                        objPrjTabFldENEx.objFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, true));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (strAttributeName  ==  \"{0}\")",
                        objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "byte[]")
                    {
                    }
                    else if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "byte")
                    {
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n{0} = {1};",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, true));
                    }
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");

            //��������,����(INT)��Ų���

            strBuilder.Append("\r\npublic object this[int intIndex]");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget");
            strBuilder.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.objFieldTabENEx.DataTypeId  ==  "08")
                {
                    continue;
                }
                if (bolIsFirst  ==  true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (\"{0}\"  ==  AttributeName[intIndex])",
                        objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                        objPrjTabFldENEx.objFieldTabENEx.PrivPropName);
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (\"{0}\"  ==  AttributeName[intIndex])",
                        objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                        objPrjTabFldENEx.objFieldTabENEx.PrivPropName);
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nset");
            strBuilder.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.objFieldTabENEx.DataTypeId  ==  "08")
                {
                    continue;
                }
                if (bolIsFirst  ==  true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (\"{0}\"  ==  AttributeName[intIndex])",
                        objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                        objPrjTabFldENEx.objFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, true));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (\"{0}\"  ==  AttributeName[intIndex])",
                        objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "byte[]")
                    {
                    }
                    else if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "byte")
                    {
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n{0} = {1};",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, true));
                    }
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");

            return strBuilder.ToString();
        }

        public string GenConnectString()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�;
            strBuilder.Append("\r\n//�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�");
            strBuilder.Append("\r\nprivate static string m_strConnectString;");

            strBuilder.Append("\r\npublic static string ConnectString");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget { return m_strConnectString; }");
            strBuilder.Append("\r\nset { m_strConnectString = value; }");
            strBuilder.Append("\r\n}");

            return strBuilder.ToString();
        }

        public string GenpErrNo()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///���Թ���;
            ///ÿ�����඼Ӧ���еĴ��������;
            strBuilder.Append("\r\npublic int ErrNo");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n get");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n  return mintErrNo;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n set");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n  mintErrNo = value;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string GenDispErrMsg()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///ÿ�����඼Ӧ���еĶ�����ʾ�Ĵ�����Ϣ;
            strBuilder.Append("\r\npublic string DispErrMsg //������ʾ�Ĵ�����Ϣ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n get");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n return objViewInfoENEx.DispErrMsg;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n set");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n  objViewInfoENEx.DispErrMsg = value;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        /// <summary>
        /// ���ɹ��캯��1
        /// </summary>
        /// <returns></returns>
        public string GenClassConstructor1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;
            strBuilder.Append("\r\n public " + ClsName + "()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n SetInit();");
            strBuilder.Append("\r\n mbolIsCheckProperty = false;");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.AppendFormat("\r\n lstKeyFldNames.Add(\"{0}\");", objPrjTabFldENEx.objFieldTabENEx.FldName);
            }
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        /// <summary>
        /// ���ɹ��캯��2
        /// </summary>
        /// <returns></returns>
        public string GenClassConstructor2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic " + ClsName + "(" + GetKeyPara() + ")");
            strBuilder.Append("\r\n {");
            switch (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType)
            {
                case "byte[]":
                case "byte":
                    break;
                case "string":
                    strBuilder.AppendFormat("\r\n  if (string.IsNullOrEmpty({0})  ==  true)", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n  {");
                    strBuilder.Append("\r\n     throw new Exception(\"�ؼ��ֲ���Ϊ�ջ�null!\");");
                    strBuilder.Append("\r\n   }");
                    break;
                case "bool":
                    break;
                case "int":
                case "short":
                case "Int16":
                case "Int32":
                case "long":
                    strBuilder.AppendFormat("\r\n  if ({0}  ==  0)", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n  {");
                    strBuilder.Append("\r\n     throw new Exception(\"�ؼ��ֲ���Ϊ0!\");");
                    strBuilder.Append("\r\n   }");
                    break;
                case "float":
                case "double":
                    break;
                default:
                    break;
            }

            strBuilder.Append("\r\n" + GetKeyAssign());
            strBuilder.Append("\r\n SetInit();");
            strBuilder.Append("\r\n mbolIsCheckProperty = false;");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.AppendFormat("\r\n lstKeyFldNames.Add(\"{0}\");", objPrjTabFldENEx.objFieldTabENEx.FldName);
            }
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string GenClassConstructor3()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\npublic {0}({1}, bool bolIsGet{2})",
                ClsName, GetKeyPara(), objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            switch (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType)
            {
                case "byte[]":
                case "byte":
                    break;
                case "string":
                    strBuilder.AppendFormat("\r\n  if (string.IsNullOrEmpty({0})  ==  true)", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n  {");
                    strBuilder.Append("\r\n     throw new Exception(\"�ؼ��ֲ���Ϊ�ջ�null!\");");
                    strBuilder.Append("\r\n   }");
                    break;
                case "bool":
                    break;
                case "int":
                case "short":
                case "Int16":
                case "Int32":
                case "long":
                    strBuilder.AppendFormat("\r\n  if ({0}  ==  0)", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n  {");
                    strBuilder.Append("\r\n     throw new Exception(\"�ؼ��ֲ���Ϊ0!\");");
                    strBuilder.Append("\r\n   }");
                    break;
                case "float":
                case "double":
                    break;
                default:
                    break;
            }
            strBuilder.AppendFormat("\r\n{0}", GetKeyAssign() + ";");
            strBuilder.Append("\r\nSetInit();");
            strBuilder.Append("\r\n mbolIsCheckProperty = false;");
            strBuilder.AppendFormat("\r\nif (bolIsGet{0} == true)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nGet{0}();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.AppendFormat("\r\n lstKeyFldNames.Add(\"{0}\");", objPrjTabFldENEx.objFieldTabENEx.FldName);
            }
            //            strBuilder.AppendFormat("\r\n KeyFldName = \"{0}\";", objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }

        public string GenClassConstructorEx1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;
            strBuilder.Append("\r\n public " + ClsNameEx + "()" + ": base()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string GenClassConstructorEx2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic " + ClsNameEx + "(" + GetKeyPara() + ")" + ": base(" + objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName + ")");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string GenClassConstructorEx3()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\npublic {0}({1}, bool bolIsGet{2}) : base({3},bolIsGet{2})",
                ClsNameEx, GetKeyPara(), objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }

        public string GenSetInit()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���������Щ���Գ�ʼֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\nprivate void SetInit()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjViewInfoENEx.ModuleName = this.GetType().ToString();");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "DateTime")
                {
                    strBuilder.Append("\r\n" + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + " = System.DateTime.Parse(\"01/01/1900\");	");
                }
            }
            strBuilder.Append("\r\n}");
            ///�๹���� ==  ==  == = ;
            return strBuilder.ToString();
        }
        public string GenAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��������--------------------------------------;
            ///����¼�¼----------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����¼�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>����Ƿ�ɹ�?</returns>");

            strBuilder.AppendFormat("\r\n public bool AddNewRecord(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n if (obj{0}EN.IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n     CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataAdapter objDA ; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlCommandBuilder objCB ; ");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            /// Dim objSQL As new IKData.SQLServer();
            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where 1 = 2\";");
            strBuilder.Append("\r\nobjDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);");
            strBuilder.Append("\r\nobjDA.Fill(objDS, \"" + objPrjTabENEx.TabName + "\");");
            strBuilder.Append("\r\nobjRow = objDS.Tables[\"" + objPrjTabENEx.TabName + "\"].NewRow();");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.PrimaryTypeId  ==  "02" && objPrjTabFldENEx.IsTabPrimary  ==  true)
                {
                }
                else
                {
                    if (objPrjTabFldENEx.IsTabNullable  ==  true && objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "string")
                    {
                        strBuilder.AppendFormat("\r\n if ({0} !=  \"\")", objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                        strBuilder.Append("\r\n {");
                        strBuilder.AppendFormat("\r\nobjRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"] = " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "; //{0}", objPrjTabFldENEx.objFieldTabENEx.Caption);
                        strBuilder.Append("\r\n }");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\nobjRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"] = " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "; //{0}", objPrjTabFldENEx.objFieldTabENEx.Caption);
                    }
                }
            }
            strBuilder.Append("\r\nobjDS.Tables[\"" + objPrjTabENEx.TabName + "\"].Rows.Add(objRow);");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDA.Update(objDS, \"" + objPrjTabENEx.TabName + "\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDA = null;");
            strBuilder.Append("\r\nobjDS = null;");
            strBuilder.Append("\r\nobjCB = null;");
            strBuilder.Append("\r\nobjRow = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}" + "\r\n");
            ///����¼�¼ == = ;
            return strBuilder.ToString();
        }
        public string GenAddNewRecordBySQL()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����¼�¼,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ͨ��SQL�����������¼");
            strBuilder.Append("\r\n /// ��Ҫ�����ϴ��ļ�ʱ��");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN.IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n     CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            ///strBuilder.Append("\r\nstrSQL.AppendFormat(\"insert into StdPhoto (Stdid, FileName) values ('{0}', '{1}')\", objViewInfoENEx.Stdid, mstrFileName);");
            StringBuilder strFieldLst = new StringBuilder();
            StringBuilder strValueLsd = new StringBuilder();
            string strParaIndex = "";
            bool bolIsFirst = true;
            int intIndex = 0;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabPrimary  ==  true && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (bolIsFirst  ==  true)
                {
                    strFieldLst.AppendFormat("{0}", objPrjTabFldENEx.objFieldTabENEx.FldName);
                    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "bool")
                    {
                        strValueLsd.AppendFormat(" {0} == true?\"1\":\"0\"", objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                    }
                    else
                    {
                        strValueLsd.AppendFormat(" {0}", objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                    }
                    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                    {
                        strParaIndex = "'{" + intIndex.ToString() + "}'";
                    }
                    else
                    {
                        strParaIndex = "{" + intIndex.ToString() + "}";
                    }
                    bolIsFirst = false;
                }
                else
                {
                    strFieldLst.AppendFormat(", {0}", objPrjTabFldENEx.objFieldTabENEx.FldName);
                    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "bool")
                    {
                        strValueLsd.AppendFormat(", {0} == true?\"1\":\"0\"", objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                    }
                    else
                    {
                        strValueLsd.AppendFormat(", {0}", objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                    }
                    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                    {
                        strParaIndex +=  ", '{" + intIndex.ToString() + "}'";
                    }
                    else
                    {
                        strParaIndex +=  ", {" + intIndex.ToString() + "}";
                    }
                }
                intIndex = intIndex + 1;

            }
            strBuilder.AppendFormat("\r\nstrSQL.AppendFormat(\"insert into {3} ({0}) values ({1})\", {2});", strFieldLst.ToString(), strParaIndex, strValueLsd.ToString(), objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///����¼�¼,BySQL == = ;
            return strBuilder.ToString();
        }

        public string GenAddNewRecordBySQL2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����¼�¼,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�����������¼,�÷�ʽ���Ż���ʽ");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ�ʹ�ֶ�ֵΪNULL���ֶ��������");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL2(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN.IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n     CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n //��Ҫ�������ֶ��б�");
            strBuilder.Append("\r\n ArrayList arrFieldListForInsert = new ArrayList();");
            strBuilder.Append("\r\n //��Ҫ������ֵ�б�");
            strBuilder.Append("\r\n ArrayList arrValueListForInsert = new ArrayList();");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabPrimary  ==  true && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                switch (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType)
                {
                    case "byte[]":
                    case "byte":
                        break;
                    case "string":
                        strBuilder.AppendFormat("\r\n if ({0} !=  null)",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                        strBuilder.Append("\r\n {");
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //ת��ֵ���еĵ�Ʋ\"'\",ʹ֮��Ϊ˫Ʋ\"''\"",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                        //if (clsSysParaEN.bolIsAccessSqlInjection  ==  true)
                        //{
                        //    strBuilder.AppendFormat("\r\n {0} = {0}.Replace(\"delete\", \" \"); //ɾ��SQLע���е�DELETE,ʹ֮��Ϊ�ո�\"",
                        //        objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                        //    string ss = "";
                        //    string ss1 = ss.Replace(
                        //}
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                        strBuilder.Append("\r\n }");
                        break;
                    case "bool":
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0}  ==  false ? \"0\" : \"1\") + \"'\");",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                        break;
                    case "int":
                    case "long":
                    case "float":
                    case "double":
                    case "short":
                    case "Int16":
                    case "Int32":

                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                        break;
                    default:
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
                        {
                            if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase)  ==  false)
                            {
                                strBuilder.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //ת��ֵ���еĵ�Ʋ\"'\",ʹ֮��Ϊ˫Ʋ\"''\"",
                                    objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                            }
                            strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                                objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\n arrValueListForInsert.Add({0});",
                                objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                        }
                        break;
                }

            }

            strBuilder.Append("\r\n //��֯�����¼SQL��");
            strBuilder.Append("\r\n string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strFieldListCode = string.Join(\",\", sstrFieldCode);");
            strBuilder.Append("\r\n string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strValuesListCode = string.Join(\",\", sstrValuesCode);");

            strBuilder.AppendFormat("\r\n strSQL.Append(\"Insert into {0}\");",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n strSQL.AppendFormat(\" ({0}0{1}) values ({0}1{1}) \", strFieldListCode, strValuesListCode);",
                "{", "}");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///����¼�¼,BySQL == = ;
            return strBuilder.ToString();
        }

        public string GenAddNewRecordBySQLWithTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����¼�¼,BySQL----------------;

            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ͨ��SQL�����������¼");
            strBuilder.Append("\r\n /// ��Ҫ�����ϴ��ļ�ʱ��");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL(cls{0}EN obj{0}EN, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction) ",
                     objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN.IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n     CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            ///strBuilder.Append("\r\nstrSQL.AppendFormat(\"insert into StdPhoto (Stdid, FileName) values ('{0}', '{1}')\", objViewInfoENEx.Stdid, mstrFileName);");
            StringBuilder strFieldLst = new StringBuilder();
            StringBuilder strValueLsd = new StringBuilder();
            string strParaIndex = "";
            bool bolIsFirst = true;
            int intIndex = 0;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabPrimary  ==  true && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (bolIsFirst  ==  true)
                {
                    strFieldLst.AppendFormat("{0}", objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strValueLsd.AppendFormat("{0}", objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
                    {
                        strParaIndex = "'{" + intIndex.ToString() + "}'";
                    }
                    else
                    {
                        strParaIndex = "{" + intIndex.ToString() + "}";
                    }
                    bolIsFirst = false;
                }
                else
                {
                    strFieldLst.AppendFormat(", {0}", objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strValueLsd.AppendFormat(", {0}", objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
                    {
                        strParaIndex +=  ", '{" + intIndex.ToString() + "}'";
                    }
                    else
                    {
                        strParaIndex +=  ", {" + intIndex.ToString() + "}";
                    }

                }
                intIndex = intIndex + 1;
            }

            strBuilder.AppendFormat("\r\nstrSQL.AppendFormat(\"insert into {3} ({0}) values ({1})\", {2});", strFieldLst.ToString(), strParaIndex, strValueLsd.ToString(), objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString(), objSqlConnect, objSqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///����¼�¼,BySQL == = ;
            return strBuilder.ToString();
        }

        public string GenAddNewRecordBySQLWithTransaction2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����¼�¼,BySQL----------------;

            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ͨ��SQL�����������¼");
            strBuilder.Append("\r\n /// ��Ҫ�����ϴ��ļ�ʱ��");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL2(cls{0}EN obj{0}EN, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction) ",
                     objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN.IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n     CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n StringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n //��Ҫ�������ֶ��б�");
            strBuilder.Append("\r\n ArrayList arrFieldListForInsert = new ArrayList();");
            strBuilder.Append("\r\n //��Ҫ������ֵ�б�");
            strBuilder.Append("\r\n ArrayList arrValueListForInsert = new ArrayList();");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabPrimary  ==  true && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                switch (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType)
                {
                    case "byte[]":
                    case "byte":
                        break;
                    case "string":
                        strBuilder.AppendFormat("\r\n if ({0} !=  null)",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                        strBuilder.Append("\r\n {");
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //ת��ֵ���еĵ�Ʋ\"'\",ʹ֮��Ϊ˫Ʋ\"''\"",
                                objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                        strBuilder.Append("\r\n }");
                        break;
                    case "bool":
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0}  ==  false ? \"0\" : \"1\") + \"'\");",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                        break;
                    case "int":
                    case "long":
                    case "float":
                    case "double":
                    case "short":
                    case "Int16":
                    case "Int32":

                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        strBuilder.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                            objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                        break;

                    default:
                        strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
                        {
                            strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                                objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\n arrValueListForInsert.Add({0});",
                                objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                        }
                        break;
                }

            }

            strBuilder.Append("\r\n //��֯�����¼SQL��");
            strBuilder.Append("\r\n string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strFieldListCode = string.Join(\",\", sstrFieldCode);");
            strBuilder.Append("\r\n string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strValuesListCode = string.Join(\",\", sstrValuesCode);");

            strBuilder.AppendFormat("\r\n strSQL.Append(\"Insert into {0}\");",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n strSQL.AppendFormat(\" ({0}0{1}) values ({0}1{1}) \", strFieldListCode, strValuesListCode);",
                "{", "}");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString(), objSqlConnect, objSqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///����¼�¼,BySQL == = ;
            return strBuilder.ToString();
        }

        public string GenAddnewRecBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ͨ���洢�����������¼");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ����ݿ��еĶ���</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");

            strTemp = string.Format("public bool Addnew{0}BySP(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//ͨ���洢������");
            strBuilder.Append("\r\n//ֱ��ʹ��");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.PrimaryTypeId  ==  "02" && objPrjTabFldENEx.IsTabPrimary  ==  true)
                {
                }
                else
                {
                    strBuilder.Append("\r\nvalues.Add(" + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + ");");
                }
            }
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Add\",values);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() ==  == ;
            return strBuilder.ToString();
        }

        public virtual string GenUpdateBySP()
        {
            return "";
            //StringBuilder strBuilder = new StringBuilder();
            /////public bool Addnew {TabName}BySP()--------------------------;
            //strBuilder.Append("\r\n /// <summary>");
            //strBuilder.Append("\r\n /// /// ����:ͨ���洢����(StoreProcedure)���޸ļ�¼");
            //strBuilder.Append("\r\n /// /// ȱ��:1������֧��������.");
            //strBuilder.Append("\r\n /// </summary>");
            //strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            //strTemp = string.Format("public bool Update{0}BySP(cls{0}EN obj{0}EN)",
            //    objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + strTemp);
            //strBuilder.Append("\r\n{");
            //strBuilder.AppendFormat("\r\n if (obj{0}EN.IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n {");
            //strBuilder.AppendFormat("\r\n     CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n }");
            //strBuilder.Append("\r\n//ͨ���洢������");
            //strBuilder.Append("\r\n//ֱ��ʹ��");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            //strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            //strBuilder.Append("\r\nArrayList values = new ArrayList();");
            //foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            //{
            //    strBuilder.Append("\r\nvalues.Add(" + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + ");");
            //}
            //strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Update\",values);",
            //        objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nreturn true;");
            //strBuilder.Append("\r\n}");
            /////public bool Addnew {TabName}BySP() ==  == ;
            //return strBuilder.ToString();
        }

        public string GenDelRecordBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ����ǰ������ָ�ļ�¼,ͨ���洢������ʵ��");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>���ɾ���ɹ��򷵻�TRUE,����ΪFALSE</returns>");

            strTemp = string.Format("public bool DelRecordBySP() ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//ͨ���洢������");
            strBuilder.Append("\r\n//ֱ��ʹ��");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objKeyField in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.Append("\r\nvalues.Add(" + objKeyField.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + ");");
            }
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Delete\", values);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() ==  == ;
            return strBuilder.ToString();
        }


        public string GenDelRecordBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strTemp = string.Format("public static bool DelRecordBySP({0}) ", objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//ͨ���洢������");
            strBuilder.Append("\r\n//ֱ��ʹ��");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.Append("\r\nvalues.Add(" + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + ");");
            }
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Delete\", values);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() ==  == ;
            return strBuilder.ToString();
        }
        public string GenAddnewMultiRec()
        {

            StringBuilder strBuilder = new StringBuilder();
            ///��Ӷ����¼�¼---------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �Ѷ�����¼ͬʱ���뵽����!");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"oDT\"></param>");
            strBuilder.Append("\r\n /// <param name = \"strResult\"></param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strTemp = string.Format("public bool Addnew{0}s(System.Data.DataTable oDT, ref string strResult) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataAdapter objDA;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlCommandBuilder objCB; ");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow;");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where " + objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName + " = '111'\";");
            strBuilder.Append("\r\nobjDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);");
            strBuilder.AppendFormat("\r\nobjDA.Fill(objDS, \"{0}\");", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n//���ؼ��ֵ�Ψһ��");
            ///����ñ�Ĺؼ�����˳�������;
            if (objPrjTabENEx.objKeyField0.objFieldTabENEx.IsIdentity  ==  false)
            {
                if (objPrjTabENEx.arrKeyFldSet.Count  ==  0)
                {
                    strBuilder.Append("\r\n//��ı�" + objPrjTabENEx.TabName + " ��û�йؼ���,��������һ���ؼ���!");

                    ///  MsgBox("��ı���û�йؼ���");
                }
                else
                {
                    strBuilder.Append("\r\nforeach(System.Data.DataRow oRow in oDT.Rows)");
                    strBuilder.Append("\r\n{");
                    string strTT;
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
                    {
                        strTT = string.Format("oRow[\"{0}\"].ToString().Trim()", objPrjTabFldENEx.objFieldTabENEx.FldName);
                        strTemp = string.Format("{0} {1} = " + AccessNull(strTT, objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable) + ";",
                            objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.objFieldTabENEx.PrivFuncName);
                        strBuilder.Append("\r\n" + strTemp);
                    }
                    strBuilder.Append("\r\nif (IsExist(" + objPrjTabENEx.KeyPrivFuncFldNameLstStr + "))");
                    strBuilder.Append("\r\n{");
                    ArrayList arrKeyVarLst = new ArrayList();
                    ArrayList arrKeyValueLst = new ArrayList();
                    int intKeyIndex = 0;
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
                    {
                        string strKeyVar = string.Format("{0} = {1}{2}{3}", objPrjTabFldENEx.objFieldTabENEx.FldName, "{", intKeyIndex, "}");
                        arrKeyVarLst.Add(strKeyVar);
                        arrKeyValueLst.Add(objPrjTabFldENEx.objFieldTabENEx.PrivFuncName);
                        intKeyIndex++;
                    }
                    string strKeyVarLst = clsArray.GetSqlInStrByArray(arrKeyVarLst, false);
                    string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);
                    string strKeyVarValueLst = string.Format("string.Format(\"{0}\", {1})", strKeyVarLst, strKeyValueLst);
                    clsArray.GetSqlInStrByArray(arrKeyVarLst, false);
                    strBuilder.Append("\r\nstrResult = \"�ؼ��ֱ���ֵΪ:\" + " + strKeyVarValueLst + " + \"�ļ�¼�Ѵ���,�����ظ�����!\" ;");
                    strBuilder.Append("\r\nreturn false;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n//�Ѷ�����¼���뵽����");
            strBuilder.Append("\r\nforeach(System.Data.DataRow oRow in oDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjRow = objDS.Tables[\"" + objPrjTabENEx.TabName + "\"].NewRow();");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.PrimaryTypeId  ==  "02" && objPrjTabFldENEx.IsTabPrimary  ==  true)
                {
                }
                else
                {
                    strBuilder.AppendFormat("\r\nobjRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"] = oRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"].ToString().Trim(); //{0}", objPrjTabFldENEx.objFieldTabENEx.Caption);
                }
            }
            strBuilder.Append("\r\nobjDS.Tables[\"" + objPrjTabENEx.TabName + "\"].Rows.Add(objRow);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDA.Update(objDS, \"" + objPrjTabENEx.TabName + "\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch(Exception objException) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDA = null;");
            strBuilder.Append("\r\nobjDS = null;");
            strBuilder.Append("\r\nobjCB = null;");
            strBuilder.Append("\r\nobjRow = null;");
            strBuilder.Append("\r\nobjSQL.SQLConnect.Close();");
            strBuilder.Append("\r\nobjSQL = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///��Ӷ����¼�¼ ==  ==  == = ;
            return strBuilder.ToString();
        }
        public string GenUpdate()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�޸ļ�¼------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:�޸ļ�¼");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵ����ݿ��еĶ���</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");

            strBuilder.AppendFormat("\r\npublic bool Update(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN.IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n     CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataAdapter objDA ;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\n System.Data.SqlClient.SqlCommandBuilder objCB ;");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow ;");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select * from {0} where {1};",
                objPrjTabENEx.TabName, KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName + "EN"));
            strBuilder.Append("\r\nobjDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);");
            strBuilder.Append("\r\nobjDA.Fill(objDS, \"" + objPrjTabENEx.TabName + "\");");
            strBuilder.Append("\r\nif (objDS.Tables[\"" + objPrjTabENEx.TabName + "\"].Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//MsgBox(\"û����Ӧ��ID��:" + KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName + "EN") + ");");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nobjRow = objDS.Tables[\"" + objPrjTabENEx.TabName + "\"].Rows[0];");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                //if ((objPrjTabFldENEx.Is1Identity  ==  false) && (objPrjTabFldENEx.IsTabPrimary  ==  false))
                //{

                if (objPrjTabFldENEx.IsTabPrimary  ==  true && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                strBuilder.AppendFormat("\r\n if (obj{1}EN.IsUpdated(cls{1}EN.con_{0}))",
                        objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\nobjRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"] = " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "; //{0}", objPrjTabFldENEx.objFieldTabENEx.Caption);
                strBuilder.Append("\r\n }");

            }
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDA.Update(objDS, \"" + objPrjTabENEx.TabName + "\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDA = null;");
            strBuilder.Append("\r\nobjDS = null;");
            strBuilder.Append("\r\nobjCB = null;");
            strBuilder.Append("\r\nobjRow = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///�޸ļ�¼ == = ;
            return strBuilder.ToString();
        }

        public virtual string GenUpdateBySql()
        {
            return "";
            //StringBuilder strBuilder = new StringBuilder();
            /////�޸ļ�¼------------------;
            //strBuilder.Append("\r\n /// <summary>");
            //strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ�Ƿ��Ż���ʽ");
            //strBuilder.Append("\r\n /// /// ȱ��:1�����ܴ����ֶ��еĵ�Ʋ���⣻2�����ܴ������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.");
            //strBuilder.Append("\r\n /// </summary>");
            //strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            //strBuilder.AppendFormat("\r\npublic bool UpdateBySql(cls{0}EN obj{0}EN)",
            //    objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n{");
            //strBuilder.AppendFormat("\r\n if (obj{0}EN.IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n {");
            //strBuilder.AppendFormat("\r\n     CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n }");
            //strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            //bool bolIsFirst = true;
            //foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            //{
            //    //if ((objPrjTabFldENEx.Is1Identity  ==  false) && (objPrjTabFldENEx.IsTabPrimary  ==  false))
            //    //{

            //    if (objPrjTabFldENEx.IsTabPrimary  ==  true && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
            //    {
            //        continue;
            //    }
            //    //if (objPrjTabFldENEx.IsTabNullable  ==  true && objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "string")
            //    //{
            //    // strBuilder.AppendFormat("\r\n if ({0} !=  \"\")", objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
            //    // strBuilder.Append("\r\n {");
            //    // strBuilder.AppendFormat("\r\nobjRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"] = " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "; //{0}", objPrjTabFldENEx.objFieldTabENEx.Caption);
            //    // strBuilder.Append("\r\n }");
            //    //}
            //    //else
            //    //{
            //    if (bolIsFirst  ==  true)
            //    {
            //        if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
            //        {
            //            //    sbSQL.AppendFormat("LoginTime = 'objViewInfoENEx.LoginTime' //��½ʱ��
            //            if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "bool")
            //            {
            //                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}'\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + " == true?\"1\":\"0\"); //{2}",
            //                       "{", "}",
            //                       objPrjTabFldENEx.objFieldTabENEx.Caption);
            //            }
            //            else
            //            {
            //                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}'\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "); //{2}",
            //                       "{", "}",
            //                       objPrjTabFldENEx.objFieldTabENEx.Caption);
            //            }
            //        }
            //        else
            //        {
            //            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + " = {0}0{1}\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "); //{2}",
            //               "{", "}",
            //               objPrjTabFldENEx.objFieldTabENEx.Caption);
            //        }
            //        bolIsFirst = false;
            //    }
            //    else
            //    {
            //        if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
            //        {
            //            if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "bool")
            //            {
            //                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\", " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}'\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + " == true?\"1\":\"0\"); //{2}",
            //                     "{", "}",
            //                     objPrjTabFldENEx.objFieldTabENEx.Caption);
            //            }
            //            else
            //            {
            //                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\", " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}'\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "); //{2}",
            //                     "{", "}",
            //                     objPrjTabFldENEx.objFieldTabENEx.Caption);
            //            }
            //        }
            //        else
            //        {
            //            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\", " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = {0}0{1}\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "); //{2}",
            //            "{", "}",
            //            objPrjTabFldENEx.objFieldTabENEx.Caption);
            //        }
            //    }
            //    //}

            //}


            //ArrayList arrKeyVarLst = new ArrayList();
            //ArrayList arrKeyValueLst = new ArrayList();
            //int intKeyIndex = 0;
            //foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            //{
            //    string strKeyVar = "";
            //    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
            //    {
            //        strKeyVar = string.Format("{0} = '{1}{2}{3}'", objPrjTabFldENEx.objFieldTabENEx.FldName, "{", intKeyIndex, "}");
            //    }
            //    else
            //    {
            //        strKeyVar = string.Format("{0} = {1}{2}{3}", objPrjTabFldENEx.objFieldTabENEx.FldName, "{", intKeyIndex, "}");
            //    }
            //    arrKeyVarLst.Add(strKeyVar);
            //    arrKeyValueLst.Add("obj" + objPrjTabENEx.TabName + "EN" + "." + objPrjTabFldENEx.objFieldTabENEx.FldName);
            //    intKeyIndex++;
            //}
            //string strKeyVarLst = clsArray.Join(arrKeyVarLst, " And ");

            //string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);

            //strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0}\", {1}); ",
            // strKeyVarLst,
            // strKeyValueLst);

            //strBuilder.Append("\r\ntry");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString());");
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\ncatch (Exception objException)");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\nLogError(objException);");
            //strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nfinally");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\n}");
            ////strBuilder.Append("\r\nreturn true;");
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\n");
            /////�޸ļ�¼ == = ;
            //return strBuilder.ToString();
        }

        public virtual string GenUpdateBySql2()
        {
            return "";
            //StringBuilder strBuilder = new StringBuilder();
            /////�޸ļ�¼------------------;
            /////
            //strBuilder.Append("\r\n /// <summary>");
            //strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ���Ż���ʽ");
            //strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ��������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.");
            //strBuilder.Append("\r\n /// </summary>");
            //strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            //strBuilder.AppendFormat("\r\npublic bool UpdateBySql2(cls{0}EN obj{0}EN)",
            //    objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n{");
            //strBuilder.AppendFormat("\r\n if (obj{0}EN.IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n {");
            //strBuilder.AppendFormat("\r\n     CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n }");
            //strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");

            //foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            //{
            //    if (objPrjTabFldENEx.IsTabPrimary  ==  true && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
            //    {
            //        continue;
            //    }

            //    //if (objPrjTabFldENEx.IsTabNullable  ==  true && objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "string")
            //    //{
            //    // strBuilder.AppendFormat("\r\n if ({0} !=  \"\")", objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
            //    // strBuilder.Append("\r\n {");
            //    // strBuilder.AppendFormat("\r\nobjRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"] = " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "; //{0}", objPrjTabFldENEx.objFieldTabENEx.Caption);
            //    // strBuilder.Append("\r\n }");
            //    //}
            //    //else
            //    //{
            //    strBuilder.AppendFormat("\r\n if (obj{1}EN.IsUpdated(cls{1}EN.con_{0}))",
            //            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
            //    strBuilder.Append("\r\n {");

            //    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
            //    {
            //        switch (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType)
            //        {
            //            case "bool":
            //                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}',\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + " == true?\"1\":\"0\"); //{2}",
            //                                                 "{", "}",
            //                                                 objPrjTabFldENEx.objFieldTabENEx.Caption);
            //                break;
            //            case "byte":
            //            case "byte[]":
            //                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}',\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "); //{2}",
            //                 "{", "}",
            //                 objPrjTabFldENEx.objFieldTabENEx.Caption);
            //                break;
            //            default:
            //                strBuilder.AppendFormat("\r\n if ({0} !=  null)",
            //     objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
            //                strBuilder.Append("\r\n {");
            //                if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase)  ==  false)
            //                {
            //                    strBuilder.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //ת��ֵ���еĵ�Ʋ\"'\",ʹ֮��Ϊ˫Ʋ\"''\"",
            //                        objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
            //                }
            //                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}',\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "); //{2}",
            //                     "{", "}",
            //                     objPrjTabFldENEx.objFieldTabENEx.Caption);
            //                strBuilder.Append("\r\n }");
            //                strBuilder.Append("\r\n else");
            //                strBuilder.Append("\r\n {");
            //                strBuilder.AppendFormat("\r\n sbSQL.Append(\" " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = null,\"); //{2}",
            //                     "{", "}",
            //                     objPrjTabFldENEx.objFieldTabENEx.Caption);

            //                strBuilder.Append("\r\n }");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = {0}0{1},\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "); //{2}",
            //        "{", "}",
            //        objPrjTabFldENEx.objFieldTabENEx.Caption);
            //    }
            //    strBuilder.Append("\r\n }");


            //    //}

            //}
            //strBuilder.AppendFormat("\r\n sbSQL.Remove(sbSQL.Length - 1, 1);");


            //ArrayList arrKeyVarLst = new ArrayList();
            //ArrayList arrKeyValueLst = new ArrayList();
            //int intKeyIndex = 0;
            //foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            //{
            //    string strKeyVar = "";
            //    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
            //    {
            //        strKeyVar = string.Format("{0} = '{1}{2}{3}'", objPrjTabFldENEx.objFieldTabENEx.FldName, "{", intKeyIndex, "}");
            //    }
            //    else
            //    {
            //        strKeyVar = string.Format("{0} = {1}{2}{3}", objPrjTabFldENEx.objFieldTabENEx.FldName, "{", intKeyIndex, "}");
            //    }
            //    arrKeyVarLst.Add(strKeyVar);
            //    arrKeyValueLst.Add("obj" + objPrjTabENEx.TabName + "EN" + "." + objPrjTabFldENEx.objFieldTabENEx.FldName);
            //    intKeyIndex++;
            //}
            //string strKeyVarLst = clsArray.Join(arrKeyVarLst, " And ");

            //string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);

            //strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0}\", {1}); ",
            // strKeyVarLst,
            // strKeyValueLst);

            //strBuilder.Append("\r\ntry");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString());");
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\ncatch (Exception objException)");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\nLogError(objException);");
            //strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nfinally");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\n}");
            ////strBuilder.Append("\r\nreturn true;");
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\n");
            /////�޸ļ�¼ == = ;
            //return strBuilder.ToString();
        }

        public virtual string GenUpdateBySqlWithTransaction()
        {
            return "";
            //StringBuilder strBuilder = new StringBuilder();
            /////�޸ļ�¼------------------;
            //strBuilder.Append("\r\n /// <summary>");
            //strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,֧��������,�÷�ʽ�Ƿ��Ż���ʽ");
            //strBuilder.Append("\r\n /// /// �ŵ�:1��֧��������.");
            //strBuilder.Append("\r\n /// /// ȱ��:1�����ܴ����ֶ��еĵ�Ʋ���⣻");
            //strBuilder.Append("\r\n /// ///      2�����ܴ������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�;");
            //strBuilder.Append("\r\n /// </summary>");
            //strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");

            //strBuilder.AppendFormat("\r\npublic bool UpdateBySql(cls{0}EN obj{0}EN, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction) ",
            //         objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n{");
            //strBuilder.AppendFormat("\r\n if (obj{0}EN.IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n {");
            //strBuilder.AppendFormat("\r\n     CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n }");
            //strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            //bool bolIsFirst = true;
            //foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            //{
            //    //if ((objPrjTabFldENEx.Is1Identity  ==  false) && (objPrjTabFldENEx.IsTabPrimary  ==  false))
            //    //{
            //    if (objPrjTabFldENEx.IsTabPrimary  ==  true && objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
            //    {
            //        continue;
            //    }
            //    //if (objPrjTabFldENEx.IsTabNullable  ==  true && objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "string")
            //    //{
            //    // strBuilder.AppendFormat("\r\n if ({0} !=  \"\")", objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
            //    // strBuilder.Append("\r\n {");
            //    // strBuilder.AppendFormat("\r\nobjRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"] = " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "; //{0}", objPrjTabFldENEx.objFieldTabENEx.Caption);
            //    // strBuilder.Append("\r\n }");
            //    //}
            //    //else
            //    //{
            //    if (bolIsFirst  ==  true)
            //    {
            //        if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
            //        {
            //            //    sbSQL.AppendFormat("LoginTime = 'objViewInfoENEx.LoginTime' //��½ʱ��

            //            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}'\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "); //{2}",
            //                   "{", "}",
            //                   objPrjTabFldENEx.objFieldTabENEx.Caption);
            //        }
            //        else
            //        {
            //            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + " = {0}0{1}\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "); //{2}",
            //               "{", "}",
            //               objPrjTabFldENEx.objFieldTabENEx.Caption);
            //        }
            //        bolIsFirst = false;
            //    }
            //    else
            //    {
            //        if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
            //        {
            //            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\", " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}'\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "); //{2}",
            //                "{", "}",
            //                objPrjTabFldENEx.objFieldTabENEx.Caption);
            //        }
            //        else
            //        {
            //            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\", " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = {0}0{1}\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "); //{2}",
            //            "{", "}",
            //            objPrjTabFldENEx.objFieldTabENEx.Caption);
            //        }
            //    }
            //    //}

            //}

            //ArrayList arrKeyVarLst = new ArrayList();
            //ArrayList arrKeyValueLst = new ArrayList();
            //int intKeyIndex = 0;
            //foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            //{
            //    string strKeyVar = "";
            //    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
            //    {
            //        strKeyVar = string.Format("{0} = '{1}{2}{3}'", objPrjTabFldENEx.objFieldTabENEx.FldName, "{", intKeyIndex, "}");
            //    }
            //    else
            //    {
            //        strKeyVar = string.Format("{0} = {1}{2}{3}", objPrjTabFldENEx.objFieldTabENEx.FldName, "{", intKeyIndex, "}");
            //    }
            //    arrKeyVarLst.Add(strKeyVar);
            //    arrKeyValueLst.Add("obj" + objPrjTabENEx.TabName + "EN" + "." + objPrjTabFldENEx.objFieldTabENEx.FldName);
            //    intKeyIndex++;
            //}
            //string strKeyVarLst = clsArray.Join(arrKeyVarLst, " And ");

            //string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);

            //strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0}\", {1}); ",
            // strKeyVarLst,
            // strKeyValueLst);

            //strBuilder.Append("\r\ntry");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString(), objSqlConnect, objSqlTransaction);");
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\ncatch (Exception objException)");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\nLogError(objException);");
            //strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nfinally");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\n}");
            ////strBuilder.Append("\r\nreturn true;");
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\n");
            /////�޸ļ�¼ == = ;
            //return strBuilder.ToString();
        }

        public virtual string GenUpdateBySqlWithTransaction2()
        {
            return "";
            //StringBuilder strBuilder = new StringBuilder();
            /////�޸ļ�¼------------------;
            //strBuilder.Append("\r\n /// <summary>");
            //strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,֧��������,�÷�ʽ���Ż���ʽ");
            //strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻");
            //strBuilder.Append("\r\n /// ///      2���ܹ��������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�;");
            //strBuilder.Append("\r\n /// ///      3��֧��������.");
            //strBuilder.Append("\r\n /// </summary>");
            //strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");

            //strBuilder.AppendFormat("\r\npublic bool UpdateBySql2(cls{0}EN obj{0}EN, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction) ",
            //         objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n{");
            //strBuilder.AppendFormat("\r\n if (obj{0}EN.IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n {");
            //strBuilder.AppendFormat("\r\n     CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n }");
            //strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            //foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            //{

            //    if ((objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY) && (objPrjTabFldENEx.IsTabPrimary  ==  true))
            //    {
            //        continue;
            //    }
            //    strBuilder.AppendFormat("\r\n if (obj{1}EN.IsUpdated(cls{1}EN.con_{0}))",
            //            objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
            //    strBuilder.Append("\r\n {");


            //    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
            //    {
            //        switch (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType)
            //        {
            //            case "bool":
            //                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}',\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + " == true?\"1\":\"0\"); //{2}",
            //                 "{", "}",
            //                 objPrjTabFldENEx.objFieldTabENEx.Caption);
            //                break;
            //            case "byte":
            //            case "byte[]":
            //                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}',\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "); //{2}",
            //                 "{", "}",
            //                 objPrjTabFldENEx.objFieldTabENEx.Caption);
            //                break;
            //            default:
            //                strBuilder.AppendFormat("\r\n if ({0} !=  null)",
            //       objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
            //                strBuilder.Append("\r\n {");
            //                if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase)  ==  false)
            //                {
            //                    strBuilder.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //ת��ֵ���еĵ�Ʋ\"'\",ʹ֮��Ϊ˫Ʋ\"''\"",
            //                        objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
            //                }
            //                strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}0{1}',\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "); //{2}",
            //                     "{", "}",
            //                     objPrjTabFldENEx.objFieldTabENEx.Caption);
            //                strBuilder.Append("\r\n }");
            //                strBuilder.Append("\r\n else");
            //                strBuilder.Append("\r\n {");
            //                strBuilder.AppendFormat("\r\n sbSQL.Append(\" " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = null,\"); //{2}",
            //                     "{", "}",
            //                     objPrjTabFldENEx.objFieldTabENEx.Caption);

            //                strBuilder.Append("\r\n }");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" " + objPrjTabFldENEx.objFieldTabENEx.FldName + " = {0}0{1},\"," + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + "); //{2}",
            //        "{", "}",
            //        objPrjTabFldENEx.objFieldTabENEx.Caption);
            //    }
            //    strBuilder.Append("\r\n }");


            //}
            //strBuilder.AppendFormat("\r\n sbSQL.Remove(sbSQL.Length - 1, 1);");

            //ArrayList arrKeyVarLst = new ArrayList();
            //ArrayList arrKeyValueLst = new ArrayList();
            //int intKeyIndex = 0;
            //foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            //{
            //    string strKeyVar = "";
            //    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
            //    {
            //        strKeyVar = string.Format("{0} = '{1}{2}{3}'", objPrjTabFldENEx.objFieldTabENEx.FldName, "{", intKeyIndex, "}");
            //    }
            //    else
            //    {
            //        strKeyVar = string.Format("{0} = {1}{2}{3}", objPrjTabFldENEx.objFieldTabENEx.FldName, "{", intKeyIndex, "}");
            //    }
            //    arrKeyVarLst.Add(strKeyVar);
            //    arrKeyValueLst.Add("obj" + objPrjTabENEx.TabName + "EN" + "." + objPrjTabFldENEx.objFieldTabENEx.FldName);
            //    intKeyIndex++;
            //}
            //string strKeyVarLst = clsArray.Join(arrKeyVarLst, " And ");

            //string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);

            //strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0}\", {1}); ",
            // strKeyVarLst,
            // strKeyValueLst);
            //strBuilder.Append("\r\ntry");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString(), objSqlConnect, objSqlTransaction);");
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\ncatch (Exception objException)");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\nLogError(objException);");
            //strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nfinally");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\n}");
            ////strBuilder.Append("\r\nreturn true;");
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\n");
            /////�޸ļ�¼ == = ;
            //return strBuilder.ToString();
        }


        public virtual string GenUpdateMultiRec()
        {
            return "";
            //StringBuilder strBuilder = new StringBuilder();
            /////�������޸Ķ�����¼------------------;
            //strBuilder = new StringBuilder();
            //strBuilder.Append("\r\n");
            //strBuilder.Append("\r\n /// <summary>");
            //strBuilder.Append("\r\n /// ����:�޸Ķ�����¼");
            //strBuilder.Append("\r\n /// </summary>");
            //strBuilder.Append("\r\n /// <param name = \"strCondition\"></param>");
            //strBuilder.Append("\r\n /// <returns></returns>");
            //strBuilder.Append("\r\npublic int UpdateMultiRec(string strCondition) ");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\ntry");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\n                clsCommonRegular.CheckStrSQL_Weak(strCondition);");
            //strBuilder.Append("\r\n   strCondition = clsString.RemoveElementValue(strCondition, \"Exclude\");");
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\ncatch (Exception objException)");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
            //strBuilder.Append("\r\n}");


            //strBuilder.Append("\r\nstring strSQL ;");
            //strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataAdapter objDA ;");
            //strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            //strBuilder.Append("\r\nSystem.Data.SqlClient.SqlCommandBuilder objCB ;");
            //strBuilder.Append("\r\n//			System.Data.DataRow objRow ;");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nint intRecCount;");
            //strBuilder.Append("\r\nif (strCondition  ==  \"\")");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\nreturn 0; //��ʾɾ��0����¼,ʵ�����ǲ��ܸñ�����м�¼");
            //strBuilder.Append("\r\n}");
            //strBuilder.AppendFormat("\r\nstrSQL = \"Select * from {0} where \" + strCondition;",
            //    objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nobjDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);");
            //strBuilder.Append("\r\nobjCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);");
            //strBuilder.AppendFormat("\r\nobjDA.Fill(objDS, \"{0}\");",
            //    objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\nif (objDS.Tables[\"{0}\"].Rows.Count  ==  0)",
            //    objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\nreturn 0;");
            //strBuilder.Append("\r\n}");
            //strBuilder.AppendFormat("\r\nintRecCount = objDS.Tables[\"{0}\"].Rows.Count;",
            //    objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\nforeach(System.Data.DataRow objRow in objDS.Tables[\"{0}\"].Rows)",
            //    objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n{");
            //foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            //{
            //    if ((objPrjTabFldENEx.PrimaryTypeId  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY) && (objPrjTabFldENEx.IsTabPrimary  ==  true))
            //    {
            //        continue;
            //    }
            //    strBuilder.AppendFormat("\r\nobjRow[\"{0}\"] = {1}; //{2}",
            //        objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"), objPrjTabFldENEx.objFieldTabENEx.Caption);
            //}
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\ntry");
            //strBuilder.Append("\r\n{");
            //strBuilder.AppendFormat("\r\nobjDA.Update(objDS, \"{0}\");",
            //    objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\ncatch (Exception objException)");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\nLogError(objException);");
            //strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nfinally");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\nobjDA = null;");
            //strBuilder.Append("\r\nobjDS = null;");
            //strBuilder.Append("\r\nobjCB = null;");
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nreturn intRecCount;");
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\n");
            /////�������޸Ķ�����¼ == = ;
            //return strBuilder.ToString();
        }
        public string GenfunGetRecCount()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡ���еļ�¼��---------------------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ��ǰ��ļ�¼��.�ñ��뵱ǰ����ء�");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic int funGetRecCount()");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.funGetRecCount(CurrTabName);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenfunGetRecCount_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ��ǰ��ļ�¼��.�ñ��뵱ǰ����ء�");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">�������ı���</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic static int funGetRecCount(string strTabName)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.funGetRecCount(strTabName);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenfunGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ��ǰ�������������ļ�¼��");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic int funGetRecCountByCond(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.funGetRecCount(CurrTabName, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenfunGetRecCountByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ�����������������ļ�¼��");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">�������ı���</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic static int funGetRecCountByCond(string strTabName, string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.funGetRecCount(strTabName, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///��ȡ���еļ�¼�� ==  ==  == ;
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4String()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����/��ȡ���еķ���������ĳ�ֶε�ֵ------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���õ�ǰ���еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int funSetFldValue(string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");



            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.funSetFldDataOfTable(\"{0}\", strFldName, strValue, strCondition);",
                          objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4Float()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���õ�ǰ���еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"fltValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int funSetFldValue(string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.funSetFldDataOfTable(\"{0}\", strFldName, fltValue, strCondition);",
                          objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4Int()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���õ�ǰ���еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"intValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int funSetFldValue(string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.funSetFldDataOfTable(\"{0}\", strFldName, intValue, strCondition);",
                          objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4String_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���ø������еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic static int funSetFldValue(string strTabName, string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, strValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4Int_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���ø������еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic static int funSetFldValue(string strTabName, string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, intValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenfunSetFldValue4Float_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���ø������еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"fltValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic static int funSetFldValue(string strTabName, string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, fltValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenfunGetFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ��ǰ���еķ���������ĳ�ֶε�ֵ,���б���");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ���ֶ�ֵ�б�</returns>");
            strBuilder.Append("\r\npublic List<string> funGetFldValue(string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n List<string> arrList = objSQL.funGetFldDataOfTable(\"{0}\", strFldName, strCondition);",
                          objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenfunGetFldValue_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ�������еķ���������ĳ�ֶε�ֵ,���б���");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ���ֶ�ֵ�б�</returns>");
            strBuilder.Append("\r\npublic static List<string> funGetFldValue(string strTabName, string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n List<string> arrList = objSQL.funGetFldDataOfTable(strTabName, strFldName, strCondition);");
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///����/��ȡ���еķ���������ĳ�ֶε�ֵ == = ;
            return strBuilder.ToString();
        }
        public string GenDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ����¼------------------;
            strBuilder.Append("\r\npublic bool DelRecord() ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL = \"\";");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			if ( objFKSet.GetDelFKTab !=  \")
            //										 {
            //											 strBuilder.Append("\r\n//ɾ����" + objPrjTabENEx.TabName + "���йص�������е�����");
            //											 strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strBuilder.Append("\r\n//ɾ��" + objPrjTabENEx.TabName + "�������뵱ǰ�����йصļ�¼");
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr() + ";");
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///ɾ����¼ == = ;
            return strBuilder.ToString();
        }

        public string Gen_GetSpecSQLObj()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");

            strBuilder.Append("\r\n public static clsSpecSQLforSql GetSpecSQLObj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");

            strBuilder.Append("\r\n //1. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�");
            strBuilder.Append("\r\n //3. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�");
            strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}EN.ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjSQL = new clsSpecSQLforSql();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjSQL = new clsSpecSQLforSql(cls{0}EN.ConnectString);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objSQL;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///ɾ����¼ == = ;
            return strBuilder.ToString();
        }
        public string Gen_GetSpecSQLObj_Obj()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");

            strBuilder.Append("\r\n public clsSpecSQLforSql GetSpecSQLObj_Obj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //1. �����ǰ������ָ�������Ӵ�,���ö������Ӵ�");
            strBuilder.Append("\r\n if (string.IsNullOrEmpty(this.ConnectString_Obj)  ==  false)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(this.ConnectString_Obj);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //3. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�");
            strBuilder.Append("\r\n //4. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�");
            strBuilder.AppendFormat("\r\n if (string.IsNullOrEmpty(cls{0}EN.ConnectString)  ==  true)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n objSQL = new clsSpecSQLforSql(cls{0}EN.ConnectString);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n");
            ///ɾ����¼ == = ;
            return strBuilder.ToString();
        }


        public string Gen_GetSpecSQLObjV5()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");

            strBuilder.Append("\r\n public static clsSpecSQLforSql GetSpecSQLObj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");

            strBuilder.Append("\r\n //1. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�");
            strBuilder.Append("\r\n //3. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�");
            strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}EN.ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjSQL = new clsSpecSQLforSql();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjSQL = new clsSpecSQLforSql(cls{0}EN.ConnectString);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objSQL;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///ɾ����¼ == = ;
            return strBuilder.ToString();
        }
        public string Gen_GetSpecSQLObj_ObjV5()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");

            strBuilder.Append("\r\n public clsSpecSQLforSql GetSpecSQLObj_Obj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //1. �����ǰ������ָ�������Ӵ�,���ö������Ӵ�");
            strBuilder.Append("\r\n if (string.IsNullOrEmpty(this.ConnectString_Obj)  ==  false)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(this.ConnectString_Obj);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //3. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�");
            strBuilder.Append("\r\n //4. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�");
            strBuilder.AppendFormat("\r\n if (string.IsNullOrEmpty(cls{0}EN.ConnectString)  ==  true)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n objSQL = new clsSpecSQLforSql(cls{0}EN.ConnectString);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n");
            ///ɾ����¼ == = ;
            return strBuilder.ToString();
        }


        public string Gen_GetSpecSQLObj5()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");

            strBuilder.Append("\r\n public static clsSpecSQLforSql GetSpecSQLObj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");

            strBuilder.Append("\r\n //1. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�");
            strBuilder.Append("\r\n //3. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�");
            strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}.ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjSQL = new clsSpecSQLforSql();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjSQL = new clsSpecSQLforSql(cls{0}.ConnectString);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objSQL;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///ɾ����¼ == = ;
            return strBuilder.ToString();
        }
        public string Gen_GetSpecSQLObj_Obj5()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");
            strBuilder.Append("\r\n public clsSpecSQLforSql GetSpecSQLObj_Obj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //1. �����ǰ������ָ�������Ӵ�,���ö������Ӵ�");
            strBuilder.Append("\r\n if (string.IsNullOrEmpty(this.ConnectString_Obj)  ==  false)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(this.ConnectString_Obj);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //3. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�");
            strBuilder.Append("\r\n //4. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�");
            strBuilder.AppendFormat("\r\n if (string.IsNullOrEmpty(cls{0}.ConnectString)  ==  true)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n objSQL = new clsSpecSQLforSql(cls{0}.ConnectString);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n");
            ///ɾ����¼ == = ;
            return strBuilder.ToString();
        }

        public string GenDelRecordWithTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ����¼------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ǰ������ָ�ļ�¼");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objSqlConnect\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼0��</returns>");

            strBuilder.Append("\r\npublic bool DelRecord(SqlConnection objSqlConnect, SqlTransaction objSqlTransaction) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL = \"\";");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            //			if ( objFKSet.GetDelFKTab !=  \")
            //										 {
            //											 strBuilder.Append("\r\n//ɾ����" + objPrjTabENEx.TabName + "���йص�������е�����");
            //											 strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strBuilder.Append("\r\n//ɾ��" + objPrjTabENEx.TabName + "�������뵱ǰ�����йصļ�¼");
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr() + ";");
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL, objSqlConnect, objSqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///ɾ����¼ == = ;
            return strBuilder.ToString();
        }
        public string GenDelRecordWithTransaction_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ����¼------------------;
            strBuilder.AppendFormat("\r\npublic static bool DelRecord({0}, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction) ",
                objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL = \"\";");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            //			if ( objFKSet.GetDelFKTab !=  \")
            //										 {
            //											 strBuilder.Append("\r\n//ɾ����" + objPrjTabENEx.TabName + "���йص�������е�����");
            //											 strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strBuilder.Append("\r\n//ɾ��" + objPrjTabENEx.TabName + "�������뵱ǰ�����йصļ�¼");
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr(false) + ";");
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL, objSqlConnect, objSqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///ɾ����¼ == = ;
            return strBuilder.ToString();
        }

        public string GenDelMultiRec_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��һЩ��¼------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ͬʱɾ��������¼");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"lstKey\">�����Ĺؼ���ֵ�б�</param>");
            strBuilder.Append("\r\n /// <returns>����ɾ���Ƿ�ɹ�?</returns>");
            strTemp = string.Format("public static bool Del{0}(List<string> lstKey)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstring strSQL;");
            strBuilder.Append("\r\nstring strKeyList;");
            strBuilder.Append("\r\nif (lstKey.Count  == 0) return true;");
            strBuilder.Append("\r\nstrKeyList = \"\";");
            strBuilder.Append("\r\nfor (int i = 0; i<lstKey.Count; i++)");
            strBuilder.Append("\r\n{");
            ///				if ( (i == 0) strKeyList +=  "'" + lstKey[i].ToString() + "'";
            ///				else strKeyList +=  ", " + "'" + lstKey[i].ToString() + "'";
            if (objPrjTabENEx.arrKeyFldSet.Count  ==  0)
            {
                strBuilder.Append("\r\n//��ı�" + objPrjTabENEx.TabName + " ��û�йؼ���,��������һ���ؼ���!");
            }
            else
            {
                strBuilder.Append("\r\nif (i == 0) strKeyList = strKeyList + " + Mark(objPrjTabENEx.objKeyField0) + " + lstKey[i].ToString() + " + Mark(objPrjTabENEx.objKeyField0) + ";");
                strBuilder.Append("\r\nelse strKeyList +=  \",\" + " + Mark(objPrjTabENEx.objKeyField0) + " + lstKey[i].ToString() + " + Mark(objPrjTabENEx.objKeyField0) + ";");
                strBuilder.Append("\r\n}");
            }
            strBuilder.Append("\r\nstrSQL = \"\";");
            //				if ( objFKSet.GetDelFKTab !=  \")
            //											 {
            //												 strBuilder.Append("\r\n//ɾ����" + objPrjTabENEx.TabName + "���йص�������е�����");
            //					foreach(clsForeignKey objForeignKey in arrForeignKeySet)
            //					{	 
            //						strBuilder.Append("\r\nstrSQL = strSQL + \"Delete " + objFK.FKTABLE_NAME + " where " + objPrjTabENEx.objKeyField0.ColumnName + " in (\" + strKeyList + \")"";");
            //					}
            //			}
            strBuilder.Append("\r\n//ɾ��" + objPrjTabENEx.TabName + "�������뵱ǰ�����йصļ�¼");
            if (objPrjTabENEx.arrKeyFldSet.Count  ==  0)
            {
                strBuilder.Append("\r\n//��ı�" + objPrjTabENEx.TabName + " ��û�йؼ���,��������һ���ؼ���!");
                strBuilder.Append("\r\nreturn false;");
            }
            else
            {
                strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName + " in (\" + strKeyList + \")\";");
                strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL);");
            }
            strBuilder.Append("\r\n}");
            ///ɾ��һЩ��¼ == = ;
            return strBuilder.ToString();
        }
        public string GenDelRecord_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��һ����¼-----------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ���ؼ�����ָ���ļ�¼");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>���ɾ���ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.Append("\r\n" + string.Format("public static bool DelRecord({0}) ", objPrjTabENEx.KeyVarDefineLstStr));
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//ɾ��������¼");
            strBuilder.Append("\r\nstring strSQL = \"\";");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			if ( objFKSet.GetDelFKTab !=  \")
            //			{
            //				strBuilder.Append("\r\n//ɾ����" + objPrjTabENEx.TabName + "���йص�������е�����");
            //				strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab2 + ";");
            //			}
            strTemp = string.Format("//ɾ��{0}�������뵱ǰ�����йصļ�¼",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr(false) + ";");
            strBuilder.Append("\r\n return objSQL.ExecSql(strSQL);");
            strBuilder.Append("\r\n}");
            ///ɾ��һ����¼ == = ;
            return strBuilder.ToString();
        }
        public string GenDelCondRec_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��������¼,ɾ���������ļ�¼------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ��������¼,��������ɾ��");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">��Ҫɾ���ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼0��</returns>");
            strBuilder.AppendFormat("\r\npublic static int Del{0}(string strCondition)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n                clsCommonRegular.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n   strCondition = clsString.RemoveElementValue(strCondition, \"Exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstring strSQL;");
            strBuilder.Append("\r\nif (strCondition  ==  \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0;	//��ʾɾ��0����¼,ʵ�����ǲ��ܸñ�����м�¼");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nstrSQL = \"Delete from {0} where \" + strCondition ;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nint intRecoCount = objSQL.ExecSql2(strSQL);");
            strBuilder.Append("\r\nreturn intRecoCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///ɾ��������¼,ɾ���������ļ�¼ == = ;
            return strBuilder.ToString();
        }
        public string GenGetRecValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ�ؼ�ֵ�ļ�¼-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��ȡ��ǰ�ؼ��ֵļ�¼����,�ö������ʽ��ʾ.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ����ݿ��еĶ���</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.AppendFormat("\r\npublic bool Get{0}(ref cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where " + KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName + "EN") + ";");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + " = " + AccessNull(objPrjTabFldENEx) + "; //{0}(�ֶ�����:{1},�ֶγ���:{2},�Ƿ�ɿ�:{3})", objPrjTabFldENEx.objFieldTabENEx.Caption, objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName, objPrjTabFldENEx.objFieldTabENEx.FldLength, objPrjTabFldENEx.objFieldTabENEx.IsNull);
            }
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///��ȡĳһ�ؼ�ֵ�ļ�¼ ==  == = ;
            return strBuilder.ToString();
        }

        public string GenGetRecValueBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ�ؼ�ֵ�ļ�¼-----------------------------;
            strBuilder.AppendFormat("\r\npublic bool Get{0}OneBySP(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT = null; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList();");
            strBuilder.Append("\r\n values.Add(" + objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + ");");
            strBuilder.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectOne\",values);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + " = " + AccessNull(objPrjTabFldENEx) + "; //{0}(�ֶ�����:{1},�ֶγ���:{2},�Ƿ�ɿ�:{3})", objPrjTabFldENEx.objFieldTabENEx.Caption, objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName, objPrjTabFldENEx.objFieldTabENEx.FldLength, objPrjTabFldENEx.objFieldTabENEx.IsNull);
            }
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///��ȡĳһ�ؼ�ֵ�ļ�¼ ==  == = ;
            return strBuilder.ToString();
        }


        public string GenGetCondRecSet_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic static System.Data.DataTable Get" + objPrjTabENEx.TabName + "(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n                clsCommonRegular.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n   strCondition = clsString.RemoveElementValue(strCondition, \"Exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic static System.Data.DataTable Get" + objPrjTabENEx.TabName + "(string strCondition, List<string> lstExclude)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n   clsCommonRegular.CheckStrSQL_Weak(strCondition, lstExclude);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");



            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic static System.Data.DataTable Get" + objPrjTabENEx.TabName + "(string strCondition,  bool bolIsCheckSQLAttack)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCommonRegular.CheckStrSQL(strCondition);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCommonRegular.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n   strCondition = clsString.RemoveElementValue(strCondition, \"Exclude\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");



            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public string GenGetCondRecSetBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataTable Get" + objPrjTabENEx.TabName + "ByCondBySP(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n                clsCommonRegular.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n   strCondition = clsString.RemoveElementValue(strCondition, \"Exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nSystem.Data.DataTable objDT = null; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList();");
            strBuilder.Append("\r\n values.Add(strCondition);");
            strBuilder.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectByCond\",values);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }
        public string GenGetCondRecDataSetBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataSet Get" + objPrjTabENEx.TabName + "DataSetByCondBySP(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n                clsCommonRegular.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n   strCondition = clsString.RemoveElementValue(strCondition, \"Exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nSystem.Data.DataSet objDS = null; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList();");
            strBuilder.Append("\r\n values.Add(strCondition);");
            strBuilder.AppendFormat("\r\n objDS = objSQL.ExecSPReturnDS(\"{0}_SelectByCond\",values, \"{0}\");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");
            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }
        public string GenGetDataSetByCondBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSet_" + objPrjTabENEx.TabName + "ByCondBySP(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n                clsCommonRegular.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n   strCondition = clsString.RemoveElementValue(strCondition, \"Exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nSystem.Data.DataSet objDS = null; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList();");
            strBuilder.Append("\r\n values.Add(strCondition);");
            strBuilder.AppendFormat("\r\n objDS = objSQL.ExecSPReturnDS(\"{0}_SelectByCond\",values, \"{0}\");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");
            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }
        public string GenGetDataSetByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSet_" + objPrjTabENEx.TabName + "(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n                clsCommonRegular.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n   strCondition = clsString.RemoveElementValue(strCondition, \"Exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = null; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n strSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return objDS;");
            strBuilder.Append("\r\n}");
            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public string GenGetDataSetByCond_V_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSet_" + objPrjTabENEx.TabName + "V(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n                clsCommonRegular.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n   strCondition = clsString.RemoveElementValue(strCondition, \"Exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = null; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n strSQL = \"Select * from v" + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"v{0}\");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return objDS;");
            strBuilder.Append("\r\n}");
            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }


        public string GenGetCondRecObjList()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\npublic List<cls{0}EN> Get" + objPrjTabENEx.TabName + "ObjList(string strCondition)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n                clsCommonRegular.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n   strCondition = clsString.RemoveElementValue(strCondition, \"Exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
            strBuilder.Append("\r\n}");

            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjList = new List<cls{0}EN>(); ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn arrObjList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objPrjTabFldENEx) + "; //{2}",
                       objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.Caption);
            }
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n	arrObjList.Add(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            strBuilder.Append("\r\nobjDT = null;");

            strBuilder.Append("\r\nreturn arrObjList;");
            strBuilder.Append("\r\n}");
            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public string GenCopyObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\npublic void CopyTo(cls{0}EN obj{0}EN)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2}; //{3}",
                       objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.PrivPropName, objPrjTabFldENEx.objFieldTabENEx.Caption);
            }
            strBuilder.Append("\r\n}");
            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public string GenCopyObj5()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\npublic void CopyTo(cls{0} obj{0})", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = {2}; //{3}",
                       objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.PrivPropName, objPrjTabFldENEx.objFieldTabENEx.Caption);
            }
            strBuilder.Append("\r\n}");
            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }
        public string GenCopyObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\npublic void CopyTo(cls{0}EN obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                       objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.PrivPropName, objPrjTabFldENEx.objFieldTabENEx.Caption);
            }
            strBuilder.Append("\r\n}");
            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }
        public string GenCopyObj_S5()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\npublic void CopyTo(cls{0} obj{0}S, cls{0} obj{0}T)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}T.{1} = obj{0}S.{1}; //{3}",
                       objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.PrivPropName, objPrjTabFldENEx.objFieldTabENEx.Caption);
            }
            strBuilder.Append("\r\n}");
            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public string GenGetCondRecObjListBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\npublic List<cls{0}EN> Get" + objPrjTabENEx.TabName + "ObjListBySP(string strCondition)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n                clsCommonRegular.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n   strCondition = clsString.RemoveElementValue(strCondition, \"Exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
            strBuilder.Append("\r\n}");


            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjList = new List<cls{0}EN>(); ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList();");
            strBuilder.Append("\r\n values.Add(strCondition);");
            strBuilder.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectByCond\",values);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn arrObjList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objPrjTabFldENEx) + "; //{2}",
                       objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.Caption);
            }
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n	arrObjList.Add(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            strBuilder.Append("\r\nobjDT = null;");

            strBuilder.Append("\r\nreturn arrObjList;");
            strBuilder.Append("\r\n}");
            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public string GenGetFirstCondRecObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\npublic cls{0}EN GetFirst{0}(string strCondition)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n                clsCommonRegular.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n   strCondition = clsString.RemoveElementValue(strCondition, \"Exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nDataRow objRow = objDT.Rows[0];");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objPrjTabFldENEx) + "; //{2}",
   objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.Caption);

            }
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public string GenGetFirstCondRecObjBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\npublic cls{0}EN GetFirst{0}BySP(string strCondition)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n                clsCommonRegular.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n   strCondition = clsString.RemoveElementValue(strCondition, \"Exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList();");
            strBuilder.Append("\r\n values.Add(strCondition);");
            strBuilder.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectTop1ByCond\",values);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nDataRow objRow = objDT.Rows[0];");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objPrjTabFldENEx) + "; //{2}",
   objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.Caption);

            }
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public string GenGetCondRecSetT_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ������DataTable,���еĴ���ת������Ӧ������------------------------;
            if (objPrjTabENEx.IsNeedTransCode)
            {
                strBuilder = new StringBuilder();
                strBuilder.Append("\r\n");
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ����:��ȡĳһ������DataTable,���еĴ���ת������Ӧ������");
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
                strBuilder.Append("\r\n /// <returns>�����Ѿ�ת�������DataTable</returns>");
                strBuilder.AppendFormat("\r\npublic static System.Data.DataTable Get{0}T(string strCondition)",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\ntry");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\n                clsCommonRegular.CheckStrSQL_Weak(strCondition);");
                strBuilder.Append("\r\n   strCondition = clsString.RemoveElementValue(strCondition, \"Exclude\");");
                strBuilder.Append("\r\n}");
                strBuilder.Append("\r\ncatch (Exception objException)");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
                strBuilder.Append("\r\n}");

                strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
                strBuilder.Append("\r\nSystem.Data.DataTable objDT = null; ");

                strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
                strBuilder.Append("\r\n //��ȡ���Ӷ���");
                strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\nstrSQL.Append(\"Select {0}.* \");", objPrjTabENEx.TabName);
                bool bolIsFirst;
                StringBuilder sbTabName = new StringBuilder();
                StringBuilder sbWhereStr = new StringBuilder();
                StringBuilder sbFldStr = new StringBuilder();
                StringBuilder sbLeftJoinStr = new StringBuilder();
                bool bolIsSelfLink = false;
                bolIsFirst = true;
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
                {
                    if (objPrjTabFldENEx.objFieldTabENEx.IsNeedTransCode  ==  true)
                    {
                        if (objPrjTabENEx.TabName  ==  objPrjTabFldENEx.objFieldTabENEx.CodeTab)
                        {
                            bolIsSelfLink = true;
                        }
                        else
                        {
                            bolIsSelfLink = false;
                        }
                        if (bolIsFirst)
                        {
                            sbTabName.AppendFormat("\r\nstrSQL.Append(\" from {0}, {1}\");",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.CodeTab);
                            sbWhereStr.AppendFormat("\r\nstrSQL.Append(\" where {0}.{1} = {2}.{3} \");",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.CodeTab, objPrjTabFldENEx.objFieldTabENEx.CodeTab_Code);
                            bolIsFirst = false;
                        }
                        else
                        {
                            sbTabName.AppendFormat("\r\nstrSQL.Append(\" , {0} \");",
                                objPrjTabFldENEx.objFieldTabENEx.CodeTab);
                            sbWhereStr.AppendFormat("\r\nstrSQL.Append(\" && {0}.{1} = {2}.{3} \");",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.CodeTab, objPrjTabFldENEx.objFieldTabENEx.CodeTab_Code);
                        }
                        if (bolIsSelfLink  ==  true)
                        {
                            sbFldStr.AppendFormat("\r\nstrSQL.Append(\", {0}Self.{1} {2}{3} \");",
                                objPrjTabFldENEx.objFieldTabENEx.CodeTab, objPrjTabFldENEx.objFieldTabENEx.CodeTab_Name, objPrjTabFldENEx.objFieldTabENEx.CodeTab, objPrjTabFldENEx.objFieldTabENEx.CodeTab_Name);
                            sbLeftJoinStr.AppendFormat("\r\nstrSQL.Append(\" left JOIN {2} {2}Self on {0}.{1} = {2}Self.{3} \");",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.CodeTab, objPrjTabFldENEx.objFieldTabENEx.CodeTab_Code);
                        }
                        else
                        {
                            sbFldStr.AppendFormat("\r\nstrSQL.Append(\", {0}.{1} {2}{3} \");",
                                objPrjTabFldENEx.objFieldTabENEx.CodeTab, objPrjTabFldENEx.objFieldTabENEx.CodeTab_Name, objPrjTabFldENEx.objFieldTabENEx.CodeTab, objPrjTabFldENEx.objFieldTabENEx.CodeTab_Name);
                            sbLeftJoinStr.AppendFormat("\r\nstrSQL.Append(\" left JOIN {2} on {0}.{1} = {2}.{3} \");",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabFldENEx.objFieldTabENEx.CodeTab, objPrjTabFldENEx.objFieldTabENEx.CodeTab_Code);
                        }
                    }
                }

                strBuilder.Append(sbFldStr.ToString());
                strBuilder.AppendFormat("\r\nstrSQL.Append(\" from {0} \");",
                    objPrjTabENEx.TabName);
                strBuilder.Append(sbLeftJoinStr.ToString());
                ///  strBuilder.Append(sbTabName.ToString());
                ///  strBuilder.Append(sbWhereStr.ToString());
                strBuilder.Append("\r\nstrSQL.Append(\" where \" + strCondition); ");
                strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL.ToString());");
                strBuilder.Append("\r\nreturn objDT;");
                strBuilder.Append("\r\n}");
                strBuilder.Append("\r\n");
            }
            ///��ȡĳһ������DataTable,���еĴ���ת������Ӧ������ == = ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// ����ͼ(SQL View)�л�ȡ��Ϣ���� == >DataTable
        /// </summary>
        /// <returns></returns>
        public string GenGetCondRecSetV_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ��������ر���ͼ(View)------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡĳһ��������ر���ͼ(View)");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>�����Ѿ�ת�������DataTable</returns>");
            strBuilder.AppendFormat("\r\npublic static System.Data.DataTable Get{0}V(string strCondition)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n                clsCommonRegular.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n   strCondition = clsString.RemoveElementValue(strCondition, \"Exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT = null; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL.Append(\"Select v{0}.* \");", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstrSQL.Append(\" from v{0} \");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstrSQL.Append(\" where \" + strCondition); ");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL.ToString());");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡĳһ��������ر���ͼ(View)");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.Append("\r\n /// <returns>�����Ѿ�ת�������DataTable</returns>");
            strBuilder.AppendFormat("\r\npublic static System.Data.DataTable Get{0}V(string strCondition, List<string> lstExclude)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n                clsCommonRegular.CheckStrSQL_Weak(strCondition, lstExclude);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT = null; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL.Append(\"Select v{0}.* \");", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstrSQL.Append(\" from v{0} \");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstrSQL.Append(\" where \" + strCondition); ");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL.ToString());");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\n");
            ///��ȡĳһ������DataTable,���еĴ���ת������Ӧ������ == = ;
            return strBuilder.ToString();
        }


        public string GenGetPrimaryKeyID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ�����Ĺؼ����б�-----------------------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡĳһ�����Ĺؼ����б�");
            strBuilder.Append("\r\n ///		 �����ؼ����Ƕ��,�����ؼ���֮����\"//\"����");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>�ؼ����б�</returns>");
            strBuilder.Append("\r\npublic static List<string> GetPrimaryKeyID(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ;");
            strBuilder.Append("\r\nList<string> arrList = new List<string>();");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.Append("\r\nstring strKeyValue; ");
            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from {1} where \" + strCondition;",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//				LogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//				objDT = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfor (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue = \"\";");
            strBuilder.Append("\r\nfor (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (iCol  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue +=  objDT.Rows[iRow][iCol].ToString();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue +=  \"//\" + objDT.Rows[iRow][iCol].ToString();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\narrList.Add(strKeyValue);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///��ȡĳһ�����Ĺؼ����б� ==  ==  ==  ;
            return strBuilder.ToString();
        }
        public string GenGetFileFromTabField()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�ϴ��ļ��Լ������ļ���ش���------------------------------------ ;
            if (mbolIsHaveImageField  ==  true)
            {
                strBuilder = new StringBuilder();
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ����:�����ݿ���ֶ��л�ȡ����,���Ҵ�����ļ��С�");
                strBuilder.Append("\r\n ///		˵��:���¼����Ϊ��ǰ��������Ӧ�ļ�¼��");
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <param name = \"strDownLoadFileName\">��ȡ���ݺ�,�����˵��ļ�����</param>");
                strBuilder.Append("\r\n /// <returns>����ɹ���ȡ�ͷ���TRUE,����ΪFALSE</returns>");
                strBuilder.Append("\r\npublic bool GetFileFromTabField(string strDownLoadFileName)");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\nSpecData.clsSpecSQLforSql objSQL = new SpecData.clsSpecSQLforSql();");
                strBuilder.AppendFormat("\r\nstring strTabName = \"{0}\";", objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\nstring strFldName = \"{0}\";", mstrImageFieldName);
                strBuilder.Append("\r\nStringBuilder strCondition = new StringBuilder();");
                ///  strBuilder.Append("\r\nstrCondition.AppendFormat(\"Stdid = '{0}'\", objViewInfoENEx.Stdid);");
                strBuilder.Append("\r\nstrCondition.AppendFormat(\" ");
                strBuilder.AppendFormat("{0}", objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
                strBuilder.Append(" = '{0}'\", ");
                strBuilder.AppendFormat("{0});", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                strBuilder.Append("\r\nobjSQL.GetFile(strDownLoadFileName,strTabName, strFldName, strCondition.ToString());");
                strBuilder.Append("\r\nreturn true;");
                strBuilder.Append("\r\n}");
            }
            return strBuilder.ToString();
        }

        public string GenStoreFileToTabField()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:�洢�ļ������ļ��洢�����ݿ���ֶ��С�");
            strBuilder.Append("\r\n ///		˵��:���¼����Ϊ��ǰ��������Ӧ�ļ�¼��");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strUpLoadFileName\">��Ҫ�洢���ļ���</param>");
            strBuilder.Append("\r\n /// <returns>����ɹ��ͷ���TRUE,���򷵻�FALSE</returns>");
            strBuilder.Append("\r\npublic bool StoreFileToTabField(string strUpLoadFileName)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nstring strTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strFldName = \"{0}\";", mstrImageFieldName);
            strBuilder.Append("\r\nStringBuilder strCondition = new StringBuilder();");
            strBuilder.Append("\r\nstrCondition.AppendFormat(\" ");
            strBuilder.AppendFormat("{0}", objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
            strBuilder.Append(" = '{0}'\", ");
            strBuilder.AppendFormat("{0});", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
            strBuilder.Append("\r\nSpecData.clsSpecSQLforSql objSQL = new SpecData.clsSpecSQLforSql();");
            strBuilder.Append("\r\nobjSQL.StoreFile(strUpLoadFileName,strTabName, strFldName, strCondition.ToString());");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenShowPic_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ʾͼƬ����ʾ��ؼ�����ؼ�¼��ͼƬ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"imgPic\">��Ҫ��ʾͼƬ��image�ؼ�</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">��¼�ؼ��ֵ�ֵ</param>",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n /// <param name = \"strWebFileDir\">����WEB��ʾ���ļ�·��,��URL</param>");
            strBuilder.Append("\r\n /// <param name = \"strDownloadFileDir\">���������ļ�ʱ,��WEB���������ļ���Ŀ¼</param>");
            strBuilder.Append("\r\npublic static void ShowPic(System.Web.UI.WebControls.Image imgPic, ");
            strBuilder.AppendFormat("\r\n{0} {1}, ",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\nstring strWebFileDir, ");
            strBuilder.Append("\r\nstring strDownloadFileDir)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nimgPic.ImageUrl = \"\";");
            strBuilder.AppendFormat("\r\nif (cls{0}EN.IsExist({1}) == true)",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\ncls{0}EN obj{0}EN = new cls{0}EN({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.AppendFormat("\r\nobj{0}EN.Get{0}();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strFileName = obj{0}EN.FileName;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (strFileName != \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strDownLoadFileName = strDownloadFileDir + strFileName;");
            strBuilder.AppendFormat("\r\nobj{0}EN.GetFileFromTabField(strDownLoadFileName);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nimgPic.ImageUrl = strWebFileDir + strFileName;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenGetFileFromTabField_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:�����ݿ���ֶ��������ļ����ݡ��ú����Ǿ�̬(static)������");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strDownLoadFileName\">�������ص��ļ���</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">��¼�ؼ��ֵ�ֵ</param>",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n /// <param name = \"strDownloadFileDir\">���������ļ�ʱ,��WEB���������ļ���Ŀ¼</param>");
            strBuilder.Append("\r\npublic static bool GetFileFromTabField(ref string strDownLoadFileName, ");
            strBuilder.AppendFormat("\r\n{0} {1}, ",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\nstring strDownloadFileDir)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nif (cls{0}EN.IsExist({1}) == true)",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\ncls{0}EN obj{0}EN = new cls{0}EN({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.AppendFormat("\r\nobj{0}EN.Get{0}();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strFileName = obj{0}EN.FileName;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (strFileName != \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrDownLoadFileName = strDownloadFileDir + strFileName;");
            strBuilder.AppendFormat("\r\nobj{0}EN.GetFileFromTabField(strDownLoadFileName);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///�ϴ��ļ��Լ������ļ���ش��� ==  ==  == ;
            return strBuilder.ToString();
        }
        public string GenGetDataTable_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһSQL����DataTable---------------------------;

            strBuilder.Append("\r\npublic static System.Data.DataTable GetDataTable(string strSql)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSql);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            ///��ȡĳһSQL����DataTable ==  == ;
            return strBuilder.ToString();
        }
        public string GenIsExist()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�����ݿ����Ƿ���ڵ�ǰ����-----------------------;
            strBuilder.Append("\r\npublic bool IsExist()");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"" + KeyWhereStr() + "))");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            ///�����ݿ����Ƿ���ڵ�ǰ���� ==  == ;
            return strBuilder.ToString();
        }
        public string GenIsExistBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�����ݿ����Ƿ���ڵ�ǰ����-----------------------;
            strBuilder.AppendFormat("\r\npublic static bool IsExistBySP({0})",
                objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.Append("\r\nvalues.Add(" + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + ");");
            }
            strBuilder.Append("\r\n" + "string strIsExist = \"\";");
            strBuilder.Append("\r\n" + "values.Add(strIsExist);");
            strBuilder.AppendFormat("\r\n" + "ArrayList arrReturn = objSQL.ExecSpWithOutPut(\"{0}_IsExist\", values);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "if (arrReturn[0].ToString()  ==  \"1\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            ///�����ݿ����Ƿ���ڵ�ǰ���� ==  == ;
            return strBuilder.ToString();
        }
        public string GenIsExist_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�����ݿ����Ƿ���ڵ�ǰ����(������̺���)-----------------------;
            ///objPrjTabFldENEx.objFieldTabENEx.PrivFuncName;
            int i = 0;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {

                if (i  ==  0)	//�Ƿ��ǵ�һ��
                {
                    strTemp = objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType + " " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName;
                }
                else
                {
                    strTemp +=  ", " + objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType + " " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName;
                }
                i++;
            }
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �жϵ�ǰ�����Ƿ���ڸ����ؼ���ֵ�ļ�¼");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>�����Ƿ����?</returns>");

            strBuilder.Append("\r\npublic static bool IsExist(" + strTemp + ")");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"" + KeyWhereStr(false) + "))");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            ///�����ݿ����Ƿ���ڵ�ǰ����(������̺���) ==  == ;
            return strBuilder.ToString();
        }
        public string GenIsExistCondRec_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:�ж��Ƿ����ĳһ�����ļ�¼");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>������ھͷ���TRUE,���򷵻�FALSE</returns>");
            strBuilder.Append("\r\npublic static bool IsExistCondRec(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n                clsCommonRegular.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n   strCondition = clsString.RemoveElementValue(strCondition, \"Exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nthrow new Exception(string.Format(\"�����������к���{0},����!\", objException.Message));");
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", strCondition))");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
  

        public string GenCheckUniqueness()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�������ĳ����(������)�Ƿ�Ψһ-------------------------------------------;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {

                if (objPrjTabFldENEx.IsTabUnique  ==  true && objPrjTabFldENEx.IsTabPrimary  ==  false)
                {

                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// ���Ψһ��(Uniqueness)--{0}({1}), �����Ψһ,��������ͬ�ļ�¼,�ͷ���False",
                    objPrjTabFldENEx.objFieldTabENEx.Caption, objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(����)</param>",
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.Caption);
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(Ҫ��Ψһ���ֶ�)</param>",
                    objPrjTabFldENEx.objFieldTabENEx.PrivFuncName, objPrjTabFldENEx.objFieldTabENEx.Caption);
                    strBuilder.Append("\r\n /// <returns></returns>");
                    strBuilder.AppendFormat("\r\npublic static bool Check{0}Uniqueness({1} {2}, {3} {4})",
                    objPrjTabFldENEx.objFieldTabENEx.FldName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName,
                    objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType,
                    objPrjTabFldENEx.objFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                    strBuilder.Append("\r\nsbCondition.AppendFormat(\"" + objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName + " !=  '{0}' and "
                  + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{1}'\", " + objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName + ", " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + ");");
                    strBuilder.AppendFormat("\r\nif (IsExistCondRec(sbCondition.ToString())  ==  true)",
                    objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nreturn false;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\nelse");
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nreturn true;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\n}");

                }
            }
            ///�������ĳ����(������)�Ƿ�Ψһ ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == ;
            return strBuilder.ToString();
        }

        public string GenCheckUniquenessV2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�������ĳ����(������)�Ƿ�Ψһ-------------------------------------------;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabUnique  ==  true && objPrjTabFldENEx.IsTabPrimary  ==  false)
                {

                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// ���Ψһ��(Uniqueness)--{0}({1}), �����Ψһ,��������ͬ�ļ�¼,�ͷ���False",
                    objPrjTabFldENEx.objFieldTabENEx.Caption, objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(����)</param>",
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.Caption);
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(Ҫ��Ψһ���ֶ�)</param>",
                    objPrjTabFldENEx.objFieldTabENEx.PrivFuncName, objPrjTabFldENEx.objFieldTabENEx.Caption);
                    strBuilder.Append("\r\n /// <returns></returns>");
                    strBuilder.AppendFormat("\r\npublic static bool Check{0}Uniqueness({1} {2}, {3} {4})",
                    objPrjTabFldENEx.objFieldTabENEx.FldName,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType,
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName,
                    objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType,
                    objPrjTabFldENEx.objFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                    if (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote  ==  true)
                    {
                        strBuilder.Append("\r\nsbCondition.AppendFormat(\"" + objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName + " !=  '{0}' and "
                      + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{1}'\", " + objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName + ", " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + ");");
                    }
                    else
                    {
                        strBuilder.Append("\r\nsbCondition.AppendFormat(\"" + objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName + " !=  {0} and "
                          + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{1}'\", " + objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName + ", " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + ");");

                    }
                    strBuilder.AppendFormat("\r\nif (IsExistCondRec(sbCondition.ToString())  ==  true)",
                    objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nreturn false;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\nelse");
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nreturn true;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\n}");

                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// ���Ψһ��(Uniqueness)--{0}({1}), �����Ψһ,��������ͬ�ļ�¼,�ͷ���False",
                                objPrjTabFldENEx.objFieldTabENEx.Caption, objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(Ҫ��Ψһ���ֶ�)</param>",
                                objPrjTabFldENEx.objFieldTabENEx.PrivFuncName, objPrjTabFldENEx.objFieldTabENEx.Caption);
                    strBuilder.Append("\r\n /// <returns></returns>");
                    strBuilder.AppendFormat("\r\npublic static bool Check{0}Uniqueness({3} {4})",
                                objPrjTabFldENEx.objFieldTabENEx.FldName,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName,
                                objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType,
                                objPrjTabFldENEx.objFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                    strBuilder.Append("\r\nsbCondition.AppendFormat(\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + " = '{0}'\", " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName + ");");
                    strBuilder.AppendFormat("\r\nif (IsExistCondRec(sbCondition.ToString())  ==  true)",
                                objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nreturn false;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\nelse");
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nreturn true;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\n}");
                }
            }
            ///�������ĳ����(������)�Ƿ�Ψһ ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == ;
            return strBuilder.ToString();
        }


        public string GenCheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckPropertyNew(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.IsTabNullable  ==  false && objPrjTabFldENEx.FieldTypeId !=  "02")
                {
                    if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "byte[]" || objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "byte")
                    {
                        continue;
                    }
                    strBuilder.Append("\r\nif (Object.Equals(null, " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + ") ");
                    strBuilder.Append("\r\n|| (!Object.Equals(null, " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + ") && " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + " .ToString()  ==  \"\")");
                    if (objPrjTabFldENEx.objFieldTabENEx.CodeTab !=  "")
                    {
                        strBuilder.Append("\r\n|| (!Object.Equals(null, " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + ") && " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + " .ToString()  ==  \"0\")");
                    }
                    strBuilder.Append(")");
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n throw new clsDbObjException(\"�ֶ�[{0}]����Ϊ��(NULL)!\");",
                    objPrjTabFldENEx.objFieldTabENEx.Caption);
                    strBuilder.Append("\r\n}");
                }


            }
            ///������Գ��ȴ���;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName !=  "text" && objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "string" && objPrjTabFldENEx.objFieldTabENEx.FldLength > 0)
                {
                    strBuilder.Append("\r\nif (!Object.Equals(null, " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + ") && getStrLen(" + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + ") > " + objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString().Trim() + ")");
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n throw new clsDbObjException(\"�ֶ�[{0}]�ĳ��Ȳ��ܳ���{1}!\");",
                    objPrjTabFldENEx.objFieldTabENEx.Caption, objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.AppendFormat("\r\n   obj{0}EN.IsCheckProperty = true;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");

            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// רҵ����޸ļ�¼,����ֶ�ֵ�Ƿ�Ϸ�,1)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckProperty4Update(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            ///������Գ��ȴ���;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName !=  "text" && objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "string" && objPrjTabFldENEx.objFieldTabENEx.FldLength > 0)
                {
                    strBuilder.Append("\r\nif (!Object.Equals(null, " + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + ") && getStrLen(" + objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN") + ") > " + objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString().Trim() + ")");
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n throw new clsDbObjException(\"�ֶ�[{0}]�ĳ��Ȳ��ܳ���{1}!\");",
                    objPrjTabFldENEx.objFieldTabENEx.Caption, objPrjTabFldENEx.objFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.AppendFormat("\r\n   obj{0}EN.IsCheckProperty = true;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");

            ///������������Ƿ���ȷ ==  ==  == = ;
            return strBuilder.ToString();
        }

        public string GenGetID()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ���������������м�¼�Ĺؼ���ֵ�б�");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĹؼ���ֵ�б�</returns>");

            strBuilder.Append("\r\npublic List<string> GetID(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\n System.Data.DataTable objDT ;");
            strBuilder.Append("\r\nList<string> arrList = new List<string>();");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.Append("\r\nstring strKeyValue; ");
            //			strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"+ " + KeyWhereStr(true) + "))");
            //			strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\nstrSQL = \"Select " + objPrjTabENEx.Keys + " from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            ///			strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfor (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue = \"\";");
            strBuilder.Append("\r\nfor (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (iCol  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue +=  objDT.Rows[iRow][iCol].ToString();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue +=  \"//\" + objDT.Rows[iRow][iCol].ToString();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\narrList.Add(strKeyValue);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }


        public string GenGetMaxStrID()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ������ַ��͹ؼ���ID");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>���ص����ؼ���ֵID</returns>");
            strBuilder.Append("\r\npublic static string GetMaxStrId()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n//��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\nobjSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strMaxValue = objSQL.GetMaxStrId(\"{0}\",\"{1}\", {2}, \"\");",
                    objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldLength);
            strBuilder.Append("\r\nreturn strMaxValue;");
            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public string GenGetFirstID()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");

            strBuilder.AppendFormat("\r\npublic {0} GetFirstID(string strCondition) ", objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\n System.Data.DataTable objDT ;");
            strBuilder.Append("\r\n List<string> arrList = new List<string>();");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.Append("\r\nstring strKeyValue; ");
            strBuilder.Append("\r\nstrSQL = \"Select " + objPrjTabENEx.Keys + " from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            ///			strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            if (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "string")
            {
                strBuilder.Append("\r\nreturn \"\";");
            }
            else if (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "long"
                || objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "int")
            {
                strBuilder.Append("\r\nreturn 0;");
            }
            else
            {
                strBuilder.AppendFormat("\r\nreturn " + AccessNull("null",
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType, true) + ";",
                  objPrjTabENEx.TabName);
            }
            //strBuilder.Append("\r\nreturn " + AccessNull("null", objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType, true) + ";");

            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nstrKeyValue = objDT.Rows[0][0].ToString();");
            strBuilder.Append("\r\nobjDT = null;");
            switch (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType)
            {
                case "int":
                    strBuilder.Append("\r\n" + "return int.Parse(strKeyValue);");
                    break;
                case "double":
                    strBuilder.Append("\r\n" + "return double.Parse(strKeyValue);");
                    break;
                case "DateTime":
                    strBuilder.Append("\r\n" + "return DateTime.Parse(strKeyValue);");
                    break;
                case "bool":
                    strBuilder.Append("\r\n" + "return bool.Parse(strKeyValue);");
                    break;
                case "float":
                    strBuilder.Append("\r\n" + "return float.Parse(strKeyValue);");
                    break;
                case "long":
                    strBuilder.Append("\r\n" + "return long.Parse(strKeyValue);");
                    break;
                case "short":
                    strBuilder.Append("\r\n" + "return short.Parse(strKeyValue);");
                    break;
                default:
                    strBuilder.Append("\r\n" + "return strKeyValue;");
                    break;
            }
            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public string GenGetFirstID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");

            strBuilder.AppendFormat("\r\npublic static {0} GetFirstID_S(string strCondition) ", objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\n System.Data.DataTable objDT ;");
            strBuilder.Append("\r\n List<string> arrList = new List<string>();");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.Append("\r\nstring strKeyValue; ");
            strBuilder.Append("\r\nstrSQL = \"Select " + objPrjTabENEx.Keys + " from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nLogErrorS(objException, \"cls{0}\");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            ///			strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = null;");
            if (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "string")
            {
                strBuilder.Append("\r\nreturn \"\";");
            }
            else if (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "long"
                || objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "int")
            {
                strBuilder.Append("\r\nreturn 0;");
            }
            else
            {
                strBuilder.AppendFormat("\r\nreturn new cls{0}DA()." + AccessNull("null",
                    objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType, true) + ";",
                  objPrjTabENEx.TabName);
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nstrKeyValue = objDT.Rows[0][0].ToString();");
            strBuilder.Append("\r\nobjDT = null;");
            switch (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType)
            {
                case "int":
                    strBuilder.Append("\r\n" + "return int.Parse(strKeyValue);");
                    break;
                case "double":
                    strBuilder.Append("\r\n" + "return double.Parse(strKeyValue);");
                    break;
                case "DateTime":
                    strBuilder.Append("\r\n" + "return DateTime.Parse(strKeyValue);");
                    break;
                case "bool":
                    strBuilder.Append("\r\n" + "return bool.Parse(strKeyValue);");
                    break;
                case "float":
                    strBuilder.Append("\r\n" + "return float.Parse(strKeyValue);");
                    break;
                case "long":
                    strBuilder.Append("\r\n" + "return long.Parse(strKeyValue);");
                    break;
                case "short":
                    strBuilder.Append("\r\n" + "return short.Parse(strKeyValue);");
                    break;
                default:
                    strBuilder.Append("\r\n" + "return strKeyValue;");
                    break;
            }
            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }


        public string GenGetReader()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic System.Data.SqlClient.SqlDataReader GetReader(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataReader objDR ;");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + string.Format("strSQL = \"Select * from {0} where \" + strCondition;", objPrjTabENEx.TabName));
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDR = objSQL.GetSqlDataReader(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            ///  strBuilder.Append("\r\nobjDR = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objDR;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenGetTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///GetTable(����������ȡ���ݱ�);
            strBuilder.Append("\r\npublic DataTable GetTable(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ;");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            ///  strBuilder.Append("\r\nobjDT = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenGetTableBySQL()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///GetTableBySQL(����SQL����ȡ���ݱ�)----------------------------------;
            strBuilder.Append("\r\npublic DataTable GetTableBySQL(string strSQL) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ;");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nLogError(objException);");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            ///GetTableBySQL(����SQL����ȡ���ݱ�) ==  ==  == ;
            ///��������END ==  ==  == ;
            return strBuilder.ToString();
        }
        public string GenTransNullToStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///˽�к���Begin-------------------------------------;
            strBuilder.Append("\r\nprotected string TransNullToStr(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n if (obj  ==  null) return \"\";");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn \"\";");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn obj.ToString();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenTransNullToInt()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\nprotected int TransNullToInt(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n if (obj  ==  null) return 0;");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn Int32.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenTransNullToLong()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\nprotected long TransNullToLong(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n if (obj  ==  null) return 0;");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn Int64.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenTransNullToShort()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\nprotected short TransNullToShort(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n if (obj  ==  null) return 0;");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn short.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }

        public string GenTransNullToDate()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\nprotected DateTime TransNullToDate(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n if (obj  ==  null) return DateTime.Parse(\"#1/1/1900#\");");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn DateTime.Parse(\"#1/1/1900#\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn DateTime.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string GenTransNullToFloat()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\nprotected float TransNullToFloat(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n  float f1 = 0.0f;");
            strBuilder.Append("\r\n   if (obj  ==  null) return f1;");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0.0f;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn float.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenTransNullToDouble()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\nprotected double TransNullToDouble(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n   double d1 = 0.0;");
            strBuilder.Append("\r\n  if (obj  ==  null) return d1;");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0.0;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn double.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenTransNullToBool()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\nprotected bool TransNullToBool(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n  if (obj  ==  null) return false;");
            strBuilder.Append("\r\nif (obj.ToString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn bool.Parse(obj.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }


        public string GengetStrLen()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡ�ַ�������,���к���Ϊ2���ֽ�,Ӣ��Ϊ1���ֽ�---------;
            strBuilder.Append("\r\npublic static int getStrLen(string strTemp)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nint len ;");
            strBuilder.Append("\r\nbyte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);");
            strBuilder.Append("\r\nlen = sarr.Length;//will output as 3+3*2 = 9");
            strBuilder.Append("\r\nreturn len;");
            strBuilder.Append("\r\n}");
            ///��ȡ�ַ�������,���к���Ϊ2���ֽ�,Ӣ��Ϊ1��;
            ///˽�к��� ==  ==  == ;
            return strBuilder.ToString();
        }
        public string GenDispose()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������---------------------------------------;
            strBuilder.Append("\r\n public void Dispose()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (mblnDisposed  ==  false)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n //Free up the database connection resource by ");
            strBuilder.Append("\r\n //calling its Dispose method");
            strBuilder.Append("\r\n //mobjConnection.Dispose()");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n //Because this Dispose method has done the necessary cleanup,");
            strBuilder.Append("\r\n //prevent the Finalize method from being called.");
            strBuilder.Append("\r\n GC.SuppressFinalize(this);");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n //Let our class know that Dispose() has been called");
            strBuilder.Append("\r\n mblnDisposed = true;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            ///������������ ==  ==  == ;
            return strBuilder.ToString();
        }
        public string GenLogError()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡ�ַ�������,���к���Ϊ2���ֽ�,Ӣ��Ϊ1���ֽ� == ;
            ///������־;
            strBuilder.Append("\r\nprotected void LogError" + "(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n //Log the error information to the Application Log");
            strBuilder.Append("\r\n string strLogMsg ;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n strLogMsg = \"An error occurred in the following module: \"");
            strBuilder.Append("\r\n+ objViewInfoENEx.ModuleName + \"Source: \" + objException.Source \r\n");
            strBuilder.Append("\r\n+ \"Message: \" + objException.Message ");
            strBuilder.Append("\r\n+ \"Stack Trace: \" + objException.StackTrace \r\n");
            strBuilder.Append("\r\n+ \"Target Site: \" + objException.TargetSite.ToString();");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n //Write error to event log");
            strBuilder.Append("\r\nSystem.Diagnostics.EventLog.WriteEntry(objViewInfoENEx.ModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }

        public string GenLogError_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡ�ַ�������,���к���Ϊ2���ֽ�,Ӣ��Ϊ1���ֽ� == ;
            ///������־;
            strBuilder.Append("\r\nprotected static void LogErrorS" + "(Exception objException, string strModuleName)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n //Log the error information to the Application Log");
            strBuilder.Append("\r\n string strLogMsg ;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n strLogMsg = \"An error occurred in the following module: \"");
            strBuilder.Append("\r\n+ strModuleName + \"Source: \" + objException.Source \r\n");
            strBuilder.Append("\r\n+ \"Message: \" + objException.Message ");
            strBuilder.Append("\r\n+ \"Stack Trace: \" + objException.StackTrace \r\n");
            strBuilder.Append("\r\n+ \"Target Site: \" + objException.TargetSite.ToString();");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n //Write error to event log");
            strBuilder.Append("\r\nSystem.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string Gen_ClearUpdateState()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����޸�״̬,����մ洢���ֶ���Ϣ��HashTable�б�.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n" + "public void ClearUpdateState()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "htProperty.Clear();");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string GenComboBoxBindFunction5()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";

            try
            {
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
                {
                    if (objPrjTabFldENEx.FieldTypeId  ==  "02")
                    {
                        strValueFieldName = objPrjTabFldENEx.objFieldTabENEx.FldName;
                    }
                    if (objPrjTabFldENEx.FieldTypeId  ==  "03")
                    {
                        strTextFieldName = objPrjTabFldENEx.objFieldTabENEx.FldName;
                    }
                }
                if (strValueFieldName !=  "" && strTextFieldName !=  "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "public static System.Data.DataTable Get{0}()",
                        strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
                    strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
                        strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						if (objPrjTabFldENEx.DS_CondStr.Trim()  ==  "")
                    //						{
                    //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						}
                    //						else
                    //						{
                    //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objPrjTabFldENEx.DS_CondStr);
                    //						}
                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

                    strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    strCodeForCs.Append("\r\n" + "return objDT;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
                        strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//Ϊ����ԴΪ�����������������");
                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                        strValueFieldName);


                    strCodeForCs.AppendFormat("\r\n" + "cls{0} obj{0};",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "//��ʼ��һ�������б�");
                    strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0} = new cls{0}();",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = \"0\";",
                        objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = \"��ѡ��...\";",
                        objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//��DataTable�е���������ӵ������б���");
                    strCodeForCs.Append("\r\n" + "foreach(DataRow objRow in objDT.Rows)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0} = new cls{0}();",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = objRow[cls{0}EN.con_{1}].ToString();",
                        objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = objRow[cls{0}EN.con_{1}].ToString();",
                        objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0});",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//���������������Դ���Լ�����ֵ���ʾ��");

                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = cls{0}EN.con_{1};",
                       objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = cls{0}EN.con_{1};",
                        objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = {0}List;",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public virtual string GenComboBoxBindFunction()
        {
            return "";
            //StringBuilder strCodeForCs = new StringBuilder();
            //string strTextFieldName = "";
            //string strValueFieldName = "";

            //try
            //{
            //    //��0��:�ѿؼ���������ComboBoxת����ComboBox
            //    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            //    {
            //        if (objPrjTabFldENEx.FieldTypeId  ==  "02")
            //        {
            //            strValueFieldName = objPrjTabFldENEx.objFieldTabENEx.FldName;
            //        }
            //        if (objPrjTabFldENEx.FieldTypeId  ==  "03")
            //        {
            //            strTextFieldName = objPrjTabFldENEx.objFieldTabENEx.FldName;
            //        }
            //    }
            //    if (strValueFieldName !=  "" && strTextFieldName !=  "")
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "public static System.Data.DataTable Get{0}()",
            //            strValueFieldName);
            //        strCodeForCs.Append("\r\n" + "{");
            //        strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
            //        strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
            //            strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
            //        //						if (objPrjTabFldENEx.DS_CondStr.Trim()  ==  "")
            //        //						{
            //        //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
            //        //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
            //        //						}
            //        //						else
            //        //						{
            //        //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
            //        //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objPrjTabFldENEx.DS_CondStr);
            //        //						}
            //        //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
            //        strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //        strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
            //        strCodeForCs.Append("\r\n" + "return objDT;");
            //        strCodeForCs.Append("\r\n" + "}");
            //        strCodeForCs.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
            //            strValueFieldName);
            //        strCodeForCs.Append("\r\n" + "{");
            //        strCodeForCs.Append("\r\n" + "//Ϊ����ԴΪ�����������������");
            //        strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
            //            strValueFieldName);


            //        strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
            //            objPrjTabENEx.TabName);
            //        strCodeForCs.AppendFormat("\r\n" + "//��ʼ��һ�������б�");
            //        strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
            //            objPrjTabENEx.TabName);
            //        strCodeForCs.Append("\r\n" + "//�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�");
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
            //            objPrjTabENEx.TabName);
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"0\";",
            //            objPrjTabENEx.TabName, strValueFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"��ѡ��...\";",
            //            objPrjTabENEx.TabName, strTextFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0}EN);",
            //            objPrjTabENEx.TabName);
            //        strCodeForCs.Append("\r\n" + "//��DataTable�е���������ӵ������б���");
            //        strCodeForCs.Append("\r\n" + "foreach(DataRow objRow in objDT.Rows)");
            //        strCodeForCs.Append("\r\n" + "{");
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
            //            objPrjTabENEx.TabName);
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[cls{0}EN.con_{1}].ToString();",
            //            objPrjTabENEx.TabName, strValueFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[cls{0}EN.con_{1}].ToString();",
            //            objPrjTabENEx.TabName, strTextFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0}EN);",
            //            objPrjTabENEx.TabName);
            //        strCodeForCs.Append("\r\n" + "}");
            //        strCodeForCs.Append("\r\n" + "//���������������Դ���Լ�����ֵ���ʾ��");

            //        strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = cls{0}EN.con_{1};",
            //           objPrjTabENEx.TabName, strValueFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = cls{0}EN.con_{1};",
            //           objPrjTabENEx.TabName, strTextFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = {0}List;",
            //          objPrjTabENEx.TabName);
            //        strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
            //        strCodeForCs.Append("\r\n" + "}");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    LogError(ex);
            //    throw new Exception(ex.Message, ex);
            //}
            //return strCodeForCs.ToString();
        }


        public string GenDdlBindFunction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            try
            {
                ///���ɽ��б���;
                strCodeForCs.Append("\r\n ///��������ĺ�������");
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
                {
                    if (objPrjTabFldENEx.FieldTypeId  ==  "02")
                    {
                        strValueFieldName = objPrjTabFldENEx.objFieldTabENEx.FldName;
                    }
                    if (objPrjTabFldENEx.FieldTypeId  ==  "03")
                    {
                        strTextFieldName = objPrjTabFldENEx.objFieldTabENEx.FldName;
                    }
                }
                if (strValueFieldName !=  "" && strTextFieldName !=  "")
                {
                    //					strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}()", 
                    //						strValueFieldName);
                    //					strCodeForCs.Append("\r\n" + "{");
                    //					strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
                    //					strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //						strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //					//									if (objViewCtlField.DS_CondStr.Trim()  ==  "")
                    //					//									{
                    //					//										strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //					//											strValueFieldName, strTextFieldName, objViewCtlField.DS_TabName);
                    //					//									}
                    //					//									else
                    //					//									{
                    //					//										strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    //					//											strValueFieldName, strTextFieldName, objViewCtlField.DS_TabName, objViewCtlField.DS_CondStr);
                    //					//									}
                    //					strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                    //					strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    //					strCodeForCs.Append("\r\n" + "return objDT;");
                    //					strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                        strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");
                    strCodeForCs.Append("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"��ѡ��...\",\"0\");");
                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                        strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};",
                        objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};",
                        objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = objDT;");
                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }

            catch (Exception ex)
            {
                LogError(ex);
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// �ѱ������ݰ󶨵�ListView��
        /// </summary>
        /// <returns></returns>
        public string GenBindListView()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///���ɰ�ListView�Ĵ���");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,");
                strCodeForCs.Append("\r\n ///			 ����ʾ��ListView�С�");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public static int BindLv_{0}(System.Windows.Forms.ListView lv{0}, string strWhereCond)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:(��4��)");
                strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.Append("\r\n" + "//	3������ListView����ͷ��Ϣ");
                strCodeForCs.Append("\r\n" + "//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��");
                strCodeForCs.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "System.Windows.Forms.ListViewItem lvi{0}; ",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "ArrayList arr{0}ObjList;",
                    objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjList = new cls{0}EN().Get{0}ObjList(strWhereCond);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	3������ListView����ͷ��Ϣ");
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Clear();//���ԭ������Item",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Clear();//���ԭ��������ͷ��Ϣ",
                    objPrjTabENEx.TabName);
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
                {
                    if (objPrjTabFldENEx.FieldTypeId !=  "04" && objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType !=  "byte[]")	//���ǹ����ֶ�
                    {
                        strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Add(\"{1}\", 100, System.Windows.Forms.HorizontalAlignment.Left);",
                            objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.Caption);
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.View = System.Windows.Forms.View.Details;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��");
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjList)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "lvi{0} = new System.Windows.Forms.ListViewItem();",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Tag = obj{0}EN.{1};",
                    objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Text = obj{0}EN.{1}.ToString();",
                    objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
                {
                    if (objPrjTabENEx.objKeyField0.FldID  ==  objPrjTabFldENEx.FldID)
                    {
                        continue;
                    }
                    if (objPrjTabFldENEx.FieldTypeId !=  "04"
                        && objPrjTabFldENEx.IsTabForeignKey  ==  false
                        && objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType !=  "byte[]")
                    {
                        if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "string")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1});",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1}.ToString());",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                        }
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Add(lvi{0});",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//	4�����ü�¼����״̬,");
                strCodeForCs.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�");
                strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjList.Count;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                LogError(ex);
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// �ѱ������ݰ󶨵�ListView��
        /// </summary>
        /// <returns></returns>
        public string GenBindListView5()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///���ɰ�ListView�Ĵ���");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,");
                strCodeForCs.Append("\r\n ///			 ����ʾ��ListView�С�");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public static int BindLv_{0}(System.Windows.Forms.ListView lv{0}, string strWhereCond)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:(��4��)");
                strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.Append("\r\n" + "//	3������ListView����ͷ��Ϣ");
                strCodeForCs.Append("\r\n" + "//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��");
                strCodeForCs.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "System.Windows.Forms.ListViewItem lvi{0}; ",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "ArrayList arr{0}ObjList;",
                    objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjList = new cls{0}().Get{0}ObjList(strWhereCond);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	3������ListView����ͷ��Ϣ");
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Clear();//���ԭ������Item",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Clear();//���ԭ��������ͷ��Ϣ",
                    objPrjTabENEx.TabName);
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
                {
                    if (objPrjTabFldENEx.FieldTypeId !=  "04" && objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType !=  "byte[]")	//���ǹ����ֶ�
                    {
                        strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Add(\"{1}\", 100, System.Windows.Forms.HorizontalAlignment.Left);",
                            objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.Caption);
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.View = System.Windows.Forms.View.Details;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��");
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0} obj{0} in arr{0}ObjList)",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "lvi{0} = new System.Windows.Forms.ListViewItem();",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Tag = obj{0}.{1};",
                    objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Text = obj{0}.{1}.ToString();",
                    objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
                {
                    if (objPrjTabENEx.objKeyField0.FldID  ==  objPrjTabFldENEx.FldID)
                    {
                        continue;
                    }
                    if (objPrjTabFldENEx.FieldTypeId !=  "04"
                        && objPrjTabFldENEx.IsTabForeignKey  ==  false
                        && objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType !=  "byte[]")
                    {
                        if (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType  ==  "string")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}.{1});",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}.{1}.ToString());",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                        }
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Add(lvi{0});",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//	4�����ü�¼����״̬,");
                strCodeForCs.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�");
                strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjList.Count;",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                LogError(ex);
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        #region ˽�к���
        protected void LogError(Exception objException)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            try
            {

                strLogMsg = "An error occurred in the following module: "
                  + objPrjTabENEx.ModuleName + "\r\nSource: " + objException.Source
                  + "Message: " + objException.Message + "\r\n"
                  + "Stack Trace: " + objException.StackTrace

                  + "Target Site: " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(objPrjTabENEx.ModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }
        #endregion

    }
}
