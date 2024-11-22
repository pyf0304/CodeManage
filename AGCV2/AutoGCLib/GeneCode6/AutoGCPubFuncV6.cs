using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.sql;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AutoGCLib
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
    class AutoGCPubFuncV6 : clsPrjTabBLEx
    {
        public string CmPrjId = "û�и�ֵ,�����¿���!";
        public bool IsFstLcase = false;
        public string ClsNameEx = "";
        public clsPrjTabFldENEx objKeyField
        {
            get
            {
                return objPrjTabENEx.objKeyField0;
            }
        }

        public string strTemp;
        protected string strDataBaseType = clsPubConst.con_MsSql;

        #region ���캯��

        public AutoGCPubFuncV6()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public AutoGCPubFuncV6(string strPrjId)
         : base(strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public AutoGCPubFuncV6(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
            : base(strTabId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
       
        #endregion


        public virtual string GenSQLCode( string strPrjDataBaseId)
        {
            string strResult = "";
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
                      objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
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
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetAll)
            {

                ///�����ֶ���
                strFieldName = objField.ObjFieldTabENEx.FldName;
                ///�����ֶ�����
                strFieldType = objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///�����ֶγ���
                strFieldLength0 = objField.ObjFieldTabENEx.FldLength.ToString();
                if (strFieldLength0 == string.Empty)
                    strFieldLength = string.Empty;
                else
                    strFieldLength = "(" + strFieldLength0 + ")";
                //�жϸ����������Ƿ���Ҫ����
                if (clsSqlObject.IsNeedLength(strFieldType) == false)
                {
                    strFieldLength = string.Empty;
                }
                ///�����ֶ�ע��(���ֶ���������)
                strRemark0 = objField.ColCaption;
                if (strRemark0 == string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/**" + strRemark0 + " **/";

                ///�����Ƿ�ɿ�

                if (objField.IsTabNullable == true)
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                ///��������

                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strPrimaryKey = " primary key identity";
                }
                else if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strPrimaryKey = " primary key";
                }
                else
                {
                    strPrimaryKey = "";
                }
                if (strPrimaryKey == "")
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
            //clsProjectsENEx objProjects = new clsProjectsENEx(PrjId, true);

            strDatabaseOwner = objPrjDataBase.DatabaseOwner;
            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }
            strCreateTabCode.AppendFormat("CREATE table [{2}].[{0}] ({1}) \r\r\n", objPrjTabENEx.TabName, strTabBodyCode, strDatabaseOwner);
            strCreateTabCode.Append("ON [PRIMARY] ");
            strCreateTabCode.Append("\r\r\nGO");
            //						Response.Write(strCreateTabCode.ToString());
            return strCreateTabCode.ToString();

        }

        public virtual string GenStoreProcedure_Add(string strPrjDataBaseId)
        {

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strBuilder.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strBuilder.Append("\r\n" + "-- Description:	<Description,,>");
            strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strBuilder.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Add ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                //�жϸ����������Ƿ���Ҫ����
                if (clsSqlObject.IsNeedLength(objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
                {
                    strBuilder.AppendFormat("\r\n" + "@{0} {1},",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,

                    objField.ObjFieldTabENEx.FldLength);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "@{0} {1}({2}),",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength);

                }
            }
            strBuilder.Remove(strBuilder.Length - 1, 1);
            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strBuilder.Append("\r\n" + "AS");
            strBuilder.Append("\r\n" + "BEGIN");
            strBuilder.Append("\r\n" + "SET NOCOUNT ON;");
            strBuilder.Append("\r\n" + "--��ʼ������");
            strBuilder.Append("\r\n" + "BEGIN TRANSACTION;");

            //��Ҫ�������ֶ��б�
            ArrayList arrFieldListForInsert = new ArrayList();
            //��Ҫ������ֵ�б�
            ArrayList arrValueListForInsert = new ArrayList();


            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if ((objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY) && (objField.FieldTypeId == enumFieldType.KeyField_02))
                {
                    continue;
                }
                arrFieldListForInsert.Add(objField.ObjFieldTabENEx.FldName);
                arrValueListForInsert.Add("@" + objField.ObjFieldTabENEx.FldName);
            }

            //��֯�����¼SQL��
            string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
            string strFieldListCode = string.Join(",", sstrFieldCode);
            string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
            string strValuesListCode = string.Join(",", sstrValuesCode);

            strBuilder.AppendFormat("\r\n" + "insert into {0} ",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "({0}) values ({1}) ;", strFieldListCode, strValuesListCode);


            strBuilder.Append("\r\n" + "IF @@ERROR<>0");
            strBuilder.Append("\r\n" + "BEGIN");
            strBuilder.Append("\r\n" + "--����ع�");
            strBuilder.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strBuilder.Append("\r\n" + "RETURN -1;");
            strBuilder.Append("\r\n" + "END");
            strBuilder.Append("\r\n" + "--����ȷ��");
            strBuilder.Append("\r\n" + "COMMIT TRANSACTION;");

            strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "END");
            //strBuilder.Append("\r\n" + "GO");
            return strBuilder.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Add()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strBuilder = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Add";
            //strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strBuilder.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strBuilder.AppendFormat("\r\n" + "<Parameters>");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                strBuilder.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
                objField.ObjFieldTabENEx.FldName,
                objField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                objField.ObjFieldTabENEx.FldLength);
            }
            //<Parameter name = "@Name" size = "10" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@Sex" size = "2" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@ClgId" size = "2" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@MajorId" size = "4" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@UserType" size = "10" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            strBuilder.AppendFormat("\r\n" + "</Parameters>");
            strBuilder.AppendFormat("\r\n" + "</StoredProcedure>");

            //strBuilder.Append("\r\n" + "GO");
            return strBuilder.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Update()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strBuilder = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Update";
            //strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strBuilder.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strBuilder.AppendFormat("\r\n" + "<Parameters>");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
                objField.ObjFieldTabENEx.FldName,
                objField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                objField.ObjFieldTabENEx.FldLength);
            }

            strBuilder.AppendFormat("\r\n" + "</Parameters>");
            strBuilder.AppendFormat("\r\n" + "</StoredProcedure>");

            //strBuilder.Append("\r\n" + "GO");
            return strBuilder.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Delete()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strBuilder = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Delete";
            //strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strBuilder.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strBuilder.AppendFormat("\r\n" + "<Parameters>");

            strBuilder.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
            objKeyField.ObjFieldTabENEx.FldLength);
            strBuilder.AppendFormat("\r\n" + "</Parameters>");
            strBuilder.AppendFormat("\r\n" + "</StoredProcedure>");

            //strBuilder.Append("\r\n" + "GO");
            return strBuilder.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Select()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strBuilder = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Select";
            //strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strBuilder.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strBuilder.AppendFormat("\r\n" + "<Parameters>");

            strBuilder.AppendFormat("\r\n" + "</Parameters>");
            strBuilder.AppendFormat("\r\n" + "</StoredProcedure>");
            //strBuilder.Append("\r\n" + "GO");
            return strBuilder.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_SelectOne()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strBuilder = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_SelectOne";
            //strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strBuilder.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strBuilder.AppendFormat("\r\n" + "<Parameters>");

            strBuilder.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
            objKeyField.ObjFieldTabENEx.FldLength);
            strBuilder.AppendFormat("\r\n" + "</Parameters>");
            strBuilder.AppendFormat("\r\n" + "</StoredProcedure>");

            //strBuilder.Append("\r\n" + "GO");
            return strBuilder.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedureXmlParameter_IsExist()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strBuilder = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_IsExist";
            //strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strBuilder.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strBuilder.AppendFormat("\r\n" + "<Parameters>");

            strBuilder.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
            objKeyField.ObjFieldTabENEx.FldLength);
            strBuilder.Append("\r\n" + "<Parameter name = \"@IsExist\" size = \"1\" datatype = \"Char\" direction = \"spParamOutput\" isNullable = \"False\" />");

            strBuilder.AppendFormat("\r\n" + "</Parameters>");
            strBuilder.AppendFormat("\r\n" + "</StoredProcedure>");

            //strBuilder.Append("\r\n" + "GO");
            return strBuilder.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedureXmlParameter_SelectByCond()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strBuilder = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_SelectByCond";
            //strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strBuilder.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strBuilder.AppendFormat("\r\n" + "<Parameters>");

            strBuilder.AppendFormat("\r\n" + "<Parameter name = \"@strCond\" size = \"1000\" datatype = \"VarChar\" direction = \"spParamInput\" isNullable = \"False\" />",
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
            objKeyField.ObjFieldTabENEx.FldLength);
            strBuilder.AppendFormat("\r\n" + "</Parameters>");
            strBuilder.AppendFormat("\r\n" + "</StoredProcedure>");
            //strBuilder.Append("\r\n" + "GO");
            return strBuilder.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedureXmlParameter_SelectTop1ByCond()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strBuilder = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_SelectTop1ByCond";
            //strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strBuilder.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strBuilder.AppendFormat("\r\n" + "<Parameters>");

            strBuilder.AppendFormat("\r\n" + "<Parameter name = \"@strCond\" size = \"1000\" datatype = \"VarChar\" direction = \"spParamInput\" isNullable = \"False\" />",
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
            objKeyField.ObjFieldTabENEx.FldLength);
            strBuilder.AppendFormat("\r\n" + "</Parameters>");
            strBuilder.AppendFormat("\r\n" + "</StoredProcedure>");
            //strBuilder.Append("\r\n" + "GO");
            return strBuilder.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenStoreProcedure_Update(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strBuilder.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strBuilder.Append("\r\n" + "-- Description:	<Description,,>");
            strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strBuilder.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Update ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //�жϸ����������Ƿ���Ҫ����
                if (clsSqlObject.IsNeedLength(objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
                {

                    strBuilder.AppendFormat("\r\n" + "@{0} {1},",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "@{0} {1}({2}),",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength);
                }
            }
            strBuilder.Remove(strBuilder.Length - 1, 1);
            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strBuilder.Append("\r\n" + "AS");
            strBuilder.Append("\r\n" + "BEGIN");
            strBuilder.Append("\r\n" + "SET NOCOUNT ON;");
            strBuilder.Append("\r\n" + "--��ʼ������");
            strBuilder.Append("\r\n" + "BEGIN TRANSACTION;");

            strBuilder.AppendFormat("\r\n" + "update {0} set ",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    continue;
                }
                strBuilder.AppendFormat("\r\n" + "{0} = @{0},", objField.ObjFieldTabENEx.FldName);
            }

            strBuilder.Remove(strBuilder.Length - 1, 1);
            strBuilder.AppendFormat("\r\n" + "Where {0} = @{0};", objKeyField.FldName);

            strBuilder.Append("\r\n" + "IF @@ERROR<>0");
            strBuilder.Append("\r\n" + "BEGIN");
            strBuilder.Append("\r\n" + "--����ع�");
            strBuilder.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strBuilder.Append("\r\n" + "RETURN -1;");
            strBuilder.Append("\r\n" + "END");
            strBuilder.Append("\r\n" + "--����ȷ��");
            strBuilder.Append("\r\n" + "COMMIT TRANSACTION;");

            strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "END");
            //strBuilder.Append("\r\n" + "GO");
            return strBuilder.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public virtual string GenStoreProcedure_Delete(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strBuilder.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strBuilder.Append("\r\n" + "-- Description:	<Description,,>");
            strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strBuilder.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Delete ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //�жϸ����������Ƿ���Ҫ����
            if (clsSqlObject.IsNeedLength(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
            {
                strBuilder.AppendFormat("\r\n" + "@{0} {1}",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "@{0} {1}({2})",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strBuilder.Append("\r\n" + "AS");
            strBuilder.Append("\r\n" + "BEGIN");
            strBuilder.Append("\r\n" + "SET NOCOUNT ON;");
            strBuilder.Append("\r\n" + "--��ʼ������");
            strBuilder.Append("\r\n" + "BEGIN TRANSACTION;");

            strBuilder.AppendFormat("\r\n" + "delete from {0} ",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "Where {0} = @{0};", objKeyField.FldName);


            strBuilder.Append("\r\n" + "IF @@ERROR<>0");
            strBuilder.Append("\r\n" + "BEGIN");
            strBuilder.Append("\r\n" + "--����ع�");
            strBuilder.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strBuilder.Append("\r\n" + "RETURN -1;");
            strBuilder.Append("\r\n" + "END");
            strBuilder.Append("\r\n" + "--����ȷ��");
            strBuilder.Append("\r\n" + "COMMIT TRANSACTION;");

            strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "END");
            //strBuilder.Append("\r\n" + "GO");
            return strBuilder.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public virtual string GenStoreProcedure_Select(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strBuilder.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strBuilder.Append("\r\n" + "-- Description:	<Description,,>");
            strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strBuilder.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Select ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //�жϸ����������Ƿ���Ҫ����
            //if (clsSqlObject.IsNeedLength(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName)  ==  false)
            //{
            // strBuilder.AppendFormat("\r\n" + "@{0} {1}",
            // objKeyField.FldName,
            // objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            // objKeyField.ObjFieldTabENEx.FldLength);
            //}
            //else
            //{
            // strBuilder.AppendFormat("\r\n" + "@{0} {1}({2})",
            // objKeyField.FldName,
            // objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            // objKeyField.ObjFieldTabENEx.FldLength);
            //}

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strBuilder.Append("\r\n" + "AS");
            strBuilder.Append("\r\n" + "BEGIN");
            strBuilder.Append("\r\n" + "SET NOCOUNT ON;");
            strBuilder.Append("\r\n" + "--��ʼ������");
            strBuilder.Append("\r\n" + "BEGIN TRANSACTION;");

            strBuilder.AppendFormat("\r\n" + "Select * from {0} ",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "-- Where {0} = @{0};", objKeyField.FldName);


            strBuilder.Append("\r\n" + "IF @@ERROR<>0");
            strBuilder.Append("\r\n" + "BEGIN");
            strBuilder.Append("\r\n" + "--����ع�");
            strBuilder.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strBuilder.Append("\r\n" + "RETURN -1;");
            strBuilder.Append("\r\n" + "END");
            strBuilder.Append("\r\n" + "--����ȷ��");
            strBuilder.Append("\r\n" + "COMMIT TRANSACTION;");

            strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "END");
            //strBuilder.Append("\r\n" + "GO");
            return strBuilder.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenStoreProcedure_SelectOne(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strBuilder.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strBuilder.Append("\r\n" + "-- Description:	<Description,,>");
            strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strBuilder.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectOne ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //�жϸ����������Ƿ���Ҫ����
            if (clsSqlObject.IsNeedLength(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
            {
                strBuilder.AppendFormat("\r\n" + "@{0} {1}",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "@{0} {1}({2})",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strBuilder.Append("\r\n" + "AS");
            strBuilder.Append("\r\n" + "BEGIN");
            strBuilder.Append("\r\n" + "SET NOCOUNT ON;");
            strBuilder.Append("\r\n" + "--��ʼ������");
            strBuilder.Append("\r\n" + "BEGIN TRANSACTION;");

            strBuilder.AppendFormat("\r\n" + "Select * from {0} ",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "Where {0} = @{0};", objKeyField.FldName);


            strBuilder.Append("\r\n" + "IF @@ERROR<>0");
            strBuilder.Append("\r\n" + "BEGIN");
            strBuilder.Append("\r\n" + "--����ع�");
            strBuilder.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strBuilder.Append("\r\n" + "RETURN -1;");
            strBuilder.Append("\r\n" + "END");
            strBuilder.Append("\r\n" + "--����ȷ��");
            strBuilder.Append("\r\n" + "COMMIT TRANSACTION;");

            strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "END");
            //strBuilder.Append("\r\n" + "GO");
            return strBuilder.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public virtual string GenStoreProcedure_IsExist(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strBuilder.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strBuilder.Append("\r\n" + "-- Description:	<Description,,>");
            strBuilder.Append("\r\n" + "-- Run Example:");
            strBuilder.Append("\r\n" + "-- declare @Exist char(1)");
            strBuilder.Append("\r\n" + "-- exec Student_IsExist '1005', @Exist out");
            strBuilder.Append("\r\n" + "-- select @Exist;");

            strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strBuilder.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_IsExist ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //�жϸ����������Ƿ���Ҫ����
            if (clsSqlObject.IsNeedLength(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
            {
                strBuilder.AppendFormat("\r\n" + "@{0} {1},",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "@{0} {1}({2}),",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }
            strBuilder.Append("\r\n" + "@IsExist char(1) out");
            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strBuilder.Append("\r\n" + "AS");
            strBuilder.Append("\r\n" + "BEGIN");
            strBuilder.Append("\r\n" + "SET NOCOUNT ON;");
            strBuilder.AppendFormat("\r\n" + "if (Exists(select * from {1} Where {0} = @{0}))",
            objKeyField.FldName,
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "begin");
            strBuilder.Append("\r\n" + "set @IsExist = '1';");
            strBuilder.Append("\r\n" + "return 1;");
            strBuilder.Append("\r\n" + "end");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "begin");
            strBuilder.Append("\r\n" + "set @IsExist = '0'");
            strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "end");
            strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "END");
            //strBuilder.Append("\r\n" + "GO");
            return strBuilder.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenStoreProcedure_SelectByCond(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strBuilder.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strBuilder.Append("\r\n" + "-- Description:	<Description,,>");
            strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strBuilder.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectByCond ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //�жϸ����������Ƿ���Ҫ����
            strBuilder.Append("\r\n" + "@strCond varchar(1000)");

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strBuilder.Append("\r\n" + "AS");
            strBuilder.Append("\r\n" + "BEGIN");

            strBuilder.Append("\r\n" + "declare @ret int, -- return value of sp call");
            strBuilder.Append("\r\n" + "@strSQL		nvarchar(4000)");
            strBuilder.Append("\r\n" + "SET NOCOUNT ON;");

            strBuilder.AppendFormat("\r\n" + "set @strSQL = 'Select * from {0} ';",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "set @strSQL = @strSQL + ' Where ';");
            strBuilder.Append("\r\n" + "set @strSQL = @strSQL + @strCond;");

            strBuilder.Append("\r\n" + "--��ʼ������");
            strBuilder.Append("\r\n" + "BEGIN TRANSACTION;");
            strBuilder.Append("\r\n" + "exec (@strSQL)");

            strBuilder.Append("\r\n" + "IF @@ERROR<>0");
            strBuilder.Append("\r\n" + "BEGIN");
            strBuilder.Append("\r\n" + "--����ع�");
            strBuilder.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strBuilder.Append("\r\n" + "RETURN -1;");
            strBuilder.Append("\r\n" + "END");
            strBuilder.Append("\r\n" + "--����ȷ��");
            strBuilder.Append("\r\n" + "COMMIT TRANSACTION;");

            strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "END");
            //strBuilder.Append("\r\n" + "GO");
            return strBuilder.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenStoreProcedure_SelectTop1ByCond(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "��ǰ��:" + objPrjTabENEx.TabName + "�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strBuilder.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strBuilder.Append("\r\n" + "-- Description:	<Description,,>");
            strBuilder.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strBuilder.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectTop1ByCond ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //�жϸ����������Ƿ���Ҫ����
            strBuilder.Append("\r\n" + "@strCond varchar(1000)");

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strBuilder.Append("\r\n" + "AS");
            strBuilder.Append("\r\n" + "BEGIN");

            strBuilder.Append("\r\n" + "declare @ret int, -- return value of sp call");
            strBuilder.Append("\r\n" + "@strSQL		nvarchar(4000)");
            strBuilder.Append("\r\n" + "SET NOCOUNT ON;");

            strBuilder.AppendFormat("\r\n" + "set @strSQL = 'Select Top 1 * from {0} ';",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "set @strSQL = @strSQL + ' Where ';");
            strBuilder.Append("\r\n" + "set @strSQL = @strSQL + @strCond;");

            strBuilder.Append("\r\n" + "--��ʼ������");
            strBuilder.Append("\r\n" + "BEGIN TRANSACTION;");
            strBuilder.Append("\r\n" + "exec (@strSQL)");

            strBuilder.Append("\r\n" + "IF @@ERROR<>0");
            strBuilder.Append("\r\n" + "BEGIN");
            strBuilder.Append("\r\n" + "--����ع�");
            strBuilder.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strBuilder.Append("\r\n" + "RETURN -1;");
            strBuilder.Append("\r\n" + "END");
            strBuilder.Append("\r\n" + "--����ȷ��");
            strBuilder.Append("\r\n" + "COMMIT TRANSACTION;");

            strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "END");
            //strBuilder.Append("\r\n" + "GO");
            return strBuilder.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenSQLCode4CreateTab(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
                          objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
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
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetAll)
            {
              
                ///�����ֶ���
                strFieldName = objField.ObjFieldTabENEx.FldName;
                ///�����ֶ�����
                strFieldType = objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///�����ֶγ���
                strFieldLength0 = objField.ObjFieldTabENEx.FldLength.ToString();
                if (strFieldLength0 == string.Empty)
                    strFieldLength = string.Empty;
                else
                    strFieldLength = "(" + strFieldLength0 + ")";
                //�жϸ����������Ƿ���Ҫ����
                if (clsSqlObject.IsNeedLength(strFieldType) == false)
                {
                    strFieldLength = string.Empty;
                }
                ///�����ֶ�ע��(���ֶ���������)
                strRemark0 = objField.ColCaption;
                if (strRemark0 == string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/**" + strRemark0 + " **/";

                ///�����Ƿ�ɿ�

                if (objField.IsTabNullable == true)
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                ///��������
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strPrimaryKey = " primary key identity";
                }
                else if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strPrimaryKey = " primary key";
                }
                else
                {
                    strPrimaryKey = "";
                }
                if (strPrimaryKey == "")
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
            //clsProjectsENEx objProjects = new clsProjectsENEx(PrjId, true);

            strDatabaseOwner = objPrjDataBase.DatabaseOwner;
            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strCreateTabCode.AppendFormat("CREATE table [{2}].[{0}] ({1}) \r\r\n", objPrjTabENEx.TabName, strTabBodyCode, strDatabaseOwner);
            strCreateTabCode.Append("ON [PRIMARY] ");
            //			strCreateTabCode.Append("\r\r\nGO");
            //						Response.Write(strCreateTabCode.ToString());
            return strCreateTabCode.ToString();

        }

        private string AccessNull(clsPrjTabFldENEx objField)
        {
            string strContent = "";
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte":
                case "byte[]":
                    strContent = string.Format("objDT.Rows[0][cls{0}EN.con_{1}]", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                default:
                    strContent = string.Format("objDT.Rows[0][cls{0}EN.con_{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
            }
        }
        private string AccessNull_Static(clsPrjTabFldENEx objField)
        {
            string strContent = "";
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte":
                case "byte[]":
                    strContent = string.Format("objDT.Rows[0][cls{0}EN.con_{1}]", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull_Static(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                default:
                    strContent = string.Format("objDT.Rows[0][cls{0}EN.con_{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull_Static(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
            }
        }
        private string AccessNull2(clsPrjTabFldENEx objField)
        {
            string strContent = "";
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte":
                case "byte[]":
                    strContent = string.Format("objRow[cls{0}EN.con_{1}]", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                default:
                    strContent = string.Format("objRow[cls{0}EN.con_{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
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
                   
                        return "TransNullToInt(" + strContent + ")";
                   
                case "short":
                   
                        return "TransNullToShort(" + strContent + ")";
                   
                case "DateTime":
                    
                        return "TransNullToDate(" + strContent + ")";
                    
                case "Single":
                case "float":
                    
                        return "TransNullToFloat(" + strContent + ")";
                    
                case "Double":
                case "Money":
                case "double":
                    return "TransNullToDouble(" + strContent + ")";

                case "bool":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToBool(" + strContent + ")";
                    }
                    else
                    {
                        return "TransNullToBool(" + strContent + ")";
                        //20070701--return "bool.Parse(" + strContent + ")";
                    }
                case "Decimal":

                    return "TransNullToDouble(" + strContent + ")";

                case "Long":
                case "long":
                    
                        return "TransNullToInt(" + strContent + ")";
                    
                case "Byte":
                    if (bolIsNullable == true)
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
                    
                        return "TransNullToInt(" + strContent + ")";
                    
                case "System.Guid":
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
                default:
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
            }
        }//end of AccessNull


        private string AccessNull_Static(string strContent, string strPropType, bool bolIsNullable)
        {
            //			string strReturn;
            //			strReturn = "";
            switch (strPropType)
            {
                case "string":
                    return strContent;
                case "int":
                    if (bolIsNullable == true)
                    {
                        return "clsGeneralTab2.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "short":
                    if (bolIsNullable == true)
                    {
                        return "clsGeneralTab2.TransNullToShort_S(" + strContent + ")";
                    }
                    else
                    {
                        return "short.Parse(" + strContent + ")";
                    }
                case "DateTime":
                    if (bolIsNullable == true)
                    {
                        return "clsGeneralTab2.TransNullToDate_S(" + strContent + ")";
                    }
                    else
                    {
                        return "System.DateTime.Parse(" + strContent + ")";
                    }
                case "Single":
                case "float":
                    if (bolIsNullable == true)
                    {
                        return "clsGeneralTab2.TransNullToFloat_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Single.Parse(" + strContent + ")";
                    }
                case "Double":
                case "Money":
                case "double":
                    if (bolIsNullable == true)
                    {
                        return "clsGeneralTab2.TransNullToDouble_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "bool":
                    if (bolIsNullable == true)
                    {
                        return "clsGeneralTab2.TransNullToBool_S(" + strContent + ")";
                    }
                    else
                    {
                        return "clsGeneralTab2.TransNullToBool_S(" + strContent + ")";
                        //20070701--return "bool.Parse(" + strContent + ")";
                    }
                case "Decimal":
                    if (bolIsNullable == true)
                    {
                        return "clsGeneralTab2.TransNullToDouble_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "Long":
                case "long":
                    if (bolIsNullable == true)
                    {
                        return "clsGeneralTab2.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "Byte":
                    if (bolIsNullable == true)
                    {
                        return "clsGeneralTab2.TransNullToInt_S(" + strContent + ")";
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
                    if (bolIsNullable == true)
                    {
                        return "clsGeneralTab2.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "System.Guid":
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
                default:
                    if (bolIsNullable == true)
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
            if (pobjField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
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
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objField.ObjFieldTabENEx.FldName + " = \" + " + Mark(objField) + "+ " + (isNeed_m == true ? "m" : "") + objField.ObjFieldTabENEx.PrivFuncName + "+" + Mark(objField);
                if (i == 0)	//�Ƿ��ǵ�һ��
                {
                    WhereStr += strTemp;
                }
                else
                {
                    WhereStr += " + \" and " + strTemp;
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
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objField.ObjFieldTabENEx.FldName + " = \" + " + Mark(objField) + "+ " + clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, strObject, this.IsFstLcase) + "+" + Mark(objField);
                if (i == 0)	//�Ƿ��ǵ�һ��
                {
                    WhereStr += strTemp;
                }
                else
                {
                    WhereStr += " + \" and " + strTemp;
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
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objField.ObjFieldTabENEx.FldName + " = \" + " + Mark(objField) + "+ " + (isNeed_m == true ? "m" : "") + objField.ObjFieldTabENEx.PrivFuncName + "+" + Mark(objField);
                ///'strTemp = objPrjTabENEx.arrKeyFldSet[i].ColumnName + " = \"" + Mark(objPrjTabENEx.arrKeyFldSet[i]) + "+ " + "m" + objField.ObjFieldTabENEx.PrivFuncName + Mark(objPrjTabENEx.arrKeyFldSet[i])
                if (i == 0)	//�Ƿ��ǵ�һ��
                {
                    WhereStr += strTemp;
                }
                else
                {
                    WhereStr += " + \" and " + strTemp;
                }
                i++;
            }

            return WhereStr;
        }


        /// <summary>
        /// �ؼ��ָ�ֵ,���ڹ��캯���йؼ��ָ���ֵ
        /// </summary>
        /// <returns>��ֵ���ʽ��</returns>
        public string GetKeyAssign()
        {
            string strPara, strTemp;
            strPara = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objField.ObjFieldTabENEx.PrivPropName + " = " + objField.ObjFieldTabENEx.PrivFuncName + ";";
                strPara += "\r\n" + strTemp;
            }
            return strPara;
        }
        //ƴװ�ؼ��ֵĴ�ֵ������
        private string GetKeyPara()
        {
            string strPara, strTemp;
            int i = 0;
            strPara = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                if (objPrjTabENEx.LangType == clsPubConst.LangType.CSharp)
                {
                    strTemp = objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.SilverLight)
                {
                    strTemp = objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.JAVA)
                {
                    strTemp = objField.JavaType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.Swift)
                {
                    strTemp = string.Format("{0} : {1}",
                         objField.ObjFieldTabENEx.PrivFuncName,
                         objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.Swift3)
                {
                    strTemp = string.Format("{0} : {1}",
                         objField.ObjFieldTabENEx.PrivFuncName,
                         objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.Swift4)
                {
                    strTemp = string.Format("{0} : {1}",
                         objField.ObjFieldTabENEx.PrivFuncName,
                         objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.JavaScript)
                {
                    strTemp = objField.JavaType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else
                {
                    string strMsg = string.Format("�ں�����,û�д�����������:[{0}].({1})",
                       objPrjTabENEx.LangType,
                       clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                if (i == 0)		//�Ƿ��ǵ�һ��
                {
                    strPara += strTemp;
                }
                else
                {
                    strPara += " , " + strTemp;
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
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.Append("\r\n" + clsPrjTabFldBLEx.DefPrivateProperty(objPrjTabENEx.LangType, objField));
            }

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���˽�б���,���������Ե�˽�б���
        /// </summary>
        /// <returns></returns>
        public string GenClsPrivateVar_Sim()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��������˽������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.Append("\r\n" + clsPrjTabFldBLEx.DefPrivateProperty_Sim(objPrjTabENEx.LangType, objField));
            }
            //ϵͳ�ֶ�_�޸��ֶμ��ϴ�
            clsPrjTabFldENEx objField1 = new clsPrjTabFldENEx();
            objField1.ObjFieldTabENEx.FldName = "sfUpdFldSetStr";
            objField1.ObjFieldTabENEx.Caption = "ϵͳ�ֶ�_�޸��ֶμ��ϴ�";
            objField1.ObjFieldTabENEx.FldLength = 4;
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN = new clsDataTypeAbbrEN().CopyToEx();
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.CsType = "string";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType = "String";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType = "String";

            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr = "str";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName = "str";
            strBuilder.Append("\r\n" + clsPrjTabFldBLEx.DefPrivateProperty_Sim(objPrjTabENEx.LangType, objField1));

            return strBuilder.ToString();
        }

        /// <summary>
        /// ����ֶ����Ƴ���,�������������Ƶ�����
        /// </summary>
        /// <returns></returns>
        public string GenPropertyNameConst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //���������������Ƴ���
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.Append("\r\n" + clsPrjTabFldBLEx.DefPropertyNameConst(objPrjTabENEx.LangType, objField, this.IsFstLcase, clsStackTrace.GetCurrClassFunction()));
            }

            return strBuilder.ToString();
        }

        /// <summary>
        /// ����ֶ����Ƴ���,�������������Ƶ�����
        /// </summary>
        /// <returns></returns>
        public string GenPropertyNameConst4ConstLevel()
        {
            StringBuilder strBuilder = new StringBuilder();
            //���������������Ƴ���
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.Append("\r\n" + clsPrjTabFldBLEx.DefPropertyNameConst4ConstLevel(objPrjTabENEx.LangType, objField));
            }

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
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strTemp = clsPrjTabFldBLEx.ToString2(objField, objPrjTabENEx.LangType, false);
                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strBuilder.Append("\r\n" + strTemp);
                }
            }

            return strBuilder.ToString();
        }
        /// <summary>
        /// �๫����������
        /// </summary>
        /// <returns></returns>
        public string GenClsPropertyV2()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///����������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strTemp = clsPrjTabFldBLEx.ToStringV2(objField, this.IsFstLcase, objPrjTabENEx.LangType, objPrjTabENEx.TabName);
                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strBuilder.Append("\r\n" + strTemp);
                }
            }

            return strBuilder.ToString();
        }

        /// <summary>
        /// �๫����������
        /// </summary>
        /// <returns></returns>
        public string GenClsProperty_Sim()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///����������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strTemp = clsPrjTabFldBLEx.ToString2(objField, objPrjTabENEx.LangType, true);
                strBuilder.Append("\r\n" + strTemp);
            }
            clsPrjTabFldENEx objField1 = new clsPrjTabFldENEx();
            objField1.ObjFieldTabENEx.FldName = "sfUpdFldSetStr";
            objField1.ObjFieldTabENEx.Caption = "ϵͳ�ֶ�_�޸��ֶμ��ϴ�";
            objField1.ObjFieldTabENEx.FldLength = 4;
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN = new clsDataTypeAbbrEN().CopyToEx();
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.CsType = "string";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType = "String";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType = "String";

            objField1.FldOpTypeId = "0001";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr = "str";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName = "str";
            strBuilder.Append("\r\n" + clsPrjTabFldBLEx.ToString2(objField1, objPrjTabENEx.LangType, true));

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
            strBuilder.Append("\r\npublic override object this[string strAttributeName]");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget");
            strBuilder.Append("\r\n{");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (strAttributeName  ==  con{0})",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PrivPropName);
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (strAttributeName  ==  con{0})",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PrivPropName);
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nset");
            strBuilder.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (strAttributeName  ==  con{0})",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};", objField.ObjFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true));
                    strBuilder.AppendFormat("\r\n AddUpdatedFld(con{0});", objField.ObjFieldTabENEx.FldName);

                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (strAttributeName  ==  con{0})",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]")
                    {
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n{0} = {1};",
                        objField.ObjFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true));
                        strBuilder.AppendFormat("\r\n AddUpdatedFld(con{0});", objField.ObjFieldTabENEx.FldName);

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
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (con{0}  ==  AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PrivPropName);
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (con{0}  ==  AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PrivPropName);
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nset");
            strBuilder.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (con{0}  ==  AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                               objField.ObjFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true));
                    strBuilder.AppendFormat("\r\n AddUpdatedFld(con{0});", objField.ObjFieldTabENEx.FldName);

                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (con{0}  ==  AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]")
                    {
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n{0} = {1};",
                              objField.ObjFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true));
                        strBuilder.AppendFormat("\r\n AddUpdatedFld(con{0});", objField.ObjFieldTabENEx.FldName);

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
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ǰ��ʹ�õ����Ӵ�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");

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
            strBuilder.Append("\r\n return mintErrNo;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n set");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n mintErrNo = value;");
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
            strBuilder.Append("\r\n return objPrjTabENEx.DispErrMsg;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n set");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objPrjTabENEx.DispErrMsg = value;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ��ȡ�ؼ���Id(KeyId)
        /// </summary>
        /// <returns></returns>
        public string GenGetKeyId()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ��ȡ�ؼ���Id(KeyId)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n public override string _KeyId");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n get");
            strBuilder.Append("\r\n {");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n  return {0};", objKeyField.ObjFieldTabENEx.PrivPropName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n  return {0}.ToString();", objKeyField.ObjFieldTabENEx.PrivPropName);
            }
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ��ȡ�����ֶ�ֵ(NameValue)
        /// </summary>
        /// <returns></returns>
        public string GenGetNameValue()
        {
            if (objPrjTabENEx.objPrjTabFld4NameFld == null) return "";
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ��ȡ�����ֶ�ֵ(NameValue)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n public override string _NameValue");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n get");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n  return {0};", objPrjTabENEx.objPrjTabFld4NameFld.ObjFieldTabENEx.PrivPropName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        /// <summary>
        /// ��������ʵ��㹹�캯��
        /// </summary>
        /// <returns></returns>
        public string GenCondEntityClassConstructor()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����ʵ��㹹�캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n  dicFldComparisonOp = new Dictionary<string, string>();");
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
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n SetInit();");
            strBuilder.Append("\r\n mbolIsCheckProperty = false;");
            //strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.AppendFormat("\r\n lstKeyFldNames.Add(\"{0}\");", objField.ObjFieldTabENEx.FldName);
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
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.AppendFormat("\r\n/// <param name = \"{0}\">�ؼ���:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivFuncName,
                objKeyField.ColCaption);
            strBuilder.Append("\r\npublic " + objPrjTabENEx.ClsName + "(" + GetKeyPara() + ")");
            strBuilder.Append("\r\n {");
            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte[]":
                case "byte":
                    break;
                case "string":
                    strBuilder.AppendFormat("\r\n" + "{0} = {0}.Replace(\"'\", \"''\");",
                              objKeyField.PrivFuncName);
                    strBuilder.AppendFormat("\r\n" + "if ({0}.Length > {1})", objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldLength);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "throw new Exception(\"�ڱ�:{0}��,�ؼ��ֳ��Ȳ���ȷ!\");", objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "}");
                    strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0})  ==  true)", objKeyField.PrivFuncName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "throw new Exception(\"�ڱ�:{0}��,�ؼ��ֲ���Ϊ�� �� null!\");", objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "}");
                    strBuilder.Append("\r\n" + "try");
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckStrSQL_Weak({0});", objKeyField.PrivFuncName);

                    strBuilder.Append("\r\n" + "}");
                    strBuilder.Append("\r\n" + "catch (Exception objException)");
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.Append("\r\n" + "throw new Exception(string.Format(\"�ڹؼ����к���{" + "0" + "},����!\", objException.Message));");
                    strBuilder.Append("\r\n" + "}");
                    //strBuilder.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);

                    break;
                case "bool":
                    break;
                case "int":
                case "short":
                case "Int16":
                case "Int32":
                case "long":
                    strBuilder.AppendFormat("\r\n if ({0}  ==  0)", objKeyField.PrivFuncName);
                    strBuilder.Append("\r\n {");
                    strBuilder.Append("\r\n throw new Exception(\"�ؼ��ֲ���Ϊ0!\");");
                    strBuilder.Append("\r\n }");
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
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.AppendFormat("\r\n lstKeyFldNames.Add(\"{0}\");", objField.ObjFieldTabENEx.FldName);
            }
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string GenClassConstructor3()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\npublic {0}({1}, bool bolIsGet{2})",
            objPrjTabENEx.ClsName, GetKeyPara(), objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte[]":
                case "byte":
                    break;
                case "string":

                    strBuilder.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);

                    break;
                case "bool":
                    break;
                case "int":
                case "short":
                case "Int16":
                case "Int32":
                case "long":
                    strBuilder.AppendFormat("\r\n if ({0}  ==  0)", objKeyField.PrivFuncName);
                    strBuilder.Append("\r\n {");
                    strBuilder.Append("\r\n throw new Exception(\"�ؼ��ֲ���Ϊ0!\");");
                    strBuilder.Append("\r\n }");
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
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.AppendFormat("\r\n lstKeyFldNames.Add(\"{0}\");", objField.ObjFieldTabENEx.FldName);
            }
            // strBuilder.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
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
            strBuilder.Append("\r\npublic " + ClsNameEx + "(" + GetKeyPara() + ")" + ": base(" + objKeyField.PrivFuncName + ")");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string GenClassConstructorEx3()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\npublic {0}({1}, bool bolIsGet{2}) : base({3},bolIsGet{2})",
            ClsNameEx, GetKeyPara(), objPrjTabENEx.TabName, objKeyField.PrivFuncName);
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\nprivate void SetInit()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nmstrModuleName = this.GetType().ToString();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "DateTime")
                {
                    strBuilder.AppendFormat("\r\n {0} = System.DateTime.Parse(\"01/01/1900\");	",
                        strPrivPropNameWithObjectName4Get);
                }
            }
            strBuilder.Append("\r\n}");
            ///�๹���� ==  ==  == = ;
            return strBuilder.ToString();
        }
        public virtual string GenAddNewRecord()
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
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataAdapter objDA ; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlCommandBuilder objCB ; ");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            /// Dim objSQL As new IKData.SQLServer();
            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where 1 = 2\";");
            strBuilder.Append("\r\nobjDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);");
            strBuilder.Append("\r\nobjDA.Fill(objDS, \"" + objPrjTabENEx.TabName + "\");");
            strBuilder.Append("\r\nobjRow = objDS.Tables[\"" + objPrjTabENEx.TabName + "\"].NewRow();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.PrimaryTypeId == "02" && objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    continue;
                }
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.FldOpTypeId == "0003") //ֻд
                {
                    if (objField.IsTabNullable == true && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                    {
                        strBuilder.AppendFormat("\r\n if ({0} !=  \"\")", strPrivPropNameWithObjectName);
                        strBuilder.Append("\r\n {");
                        strBuilder.AppendFormat("\r\nobjRow[\"{1}\"] = {2}; //{0}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                              strPrivPropNameWithObjectName);
                        strBuilder.Append("\r\n }");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\nobjRow[\"{1}\"] = {2}; //{0}", 
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName ,
                              strPrivPropNameWithObjectName );
                    }

                    continue;
                }
                if (objField.IsTabNullable == true && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                {
                    strBuilder.AppendFormat("\r\n if ({0} !=  \"\")", strPrivPropNameWithObjectName);
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\nobjRow[cls{1}EN.con_{2}] = {3}; //{0}",
                        objField.ColCaption,
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName,
                     strPrivPropNameWithObjectName );
                    strBuilder.Append("\r\n }");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nobjRow[cls{1}EN.con_{2}] = {3}; //{0}",
                        objField.ColCaption,
                          objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName,
                     strPrivPropNameWithObjectName );
                }
            }
            strBuilder.AppendFormat("\r\nobjDS.Tables[cls{0}EN._CurrTabName].Rows.Add(objRow);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjDA.Update(objDS, cls{0}EN._CurrTabName);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            
            
            
            
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}" + "\r\n");
            ///����¼�¼ == = ;
            return strBuilder.ToString();
        }
        public virtual string GenAddNewRecordBySQL()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����¼�¼,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ͨ��SQL�����������¼");
            strBuilder.Append("\r\n /// ��Ҫ�����ϴ��ļ�ʱ��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            ///strBuilder.Append("\r\nstrSQL.AppendFormat(\"insert into StdPhoto (Stdid, FileName) values ('{0}', '{1}')\", objPrjTabENEx.Stdid, objPrjTabENEx.FileName);");
            StringBuilder strFieldLst = new StringBuilder();
            StringBuilder strValueLsd = new StringBuilder();
            string strParaIndex = "";
            bool bolIsFirst = true;
            int intIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.FldOpTypeId == "0003") //ֻд
                {
                    if (bolIsFirst == true)
                    {
                        strFieldLst.AppendFormat("{0}", objField.ObjFieldTabENEx.FldName);
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                        {
                            strValueLsd.AppendFormat(" {0} == true?\"1\":\"0\"", strPrivPropNameWithObjectName4Get);
                        }
                        else
                        {
                            strValueLsd.AppendFormat(" {0}", strPrivPropNameWithObjectName4Get);
                        }
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
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
                        strFieldLst.AppendFormat(", {0}", objField.ObjFieldTabENEx.FldName);
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                        {
                            strValueLsd.AppendFormat(", {0} == true?\"1\":\"0\"", strPrivPropNameWithObjectName4Get);
                        }
                        else
                        {
                            strValueLsd.AppendFormat(", {0}", strPrivPropNameWithObjectName4Get);
                        }
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                        {
                            strParaIndex += ", '{" + intIndex.ToString() + "}'";
                        }
                        else
                        {
                            strParaIndex += ", {" + intIndex.ToString() + "}";
                        }
                    }
                    continue;
                }
                if (bolIsFirst == true)
                {
                    strFieldLst.AppendFormat("{0}", objField.ObjFieldTabENEx.FldName);
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                    {
                        strValueLsd.AppendFormat(" {0} == true?\"1\":\"0\"", strPrivPropNameWithObjectName);
                    }
                    else
                    {
                        strValueLsd.AppendFormat(" {0}", strPrivPropNameWithObjectName);
                    }
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
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
                    strFieldLst.AppendFormat(", {0}", objField.ObjFieldTabENEx.FldName);
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                    {
                        strValueLsd.AppendFormat(", {0} == true?\"1\":\"0\"", strPrivPropNameWithObjectName);
                    }
                    else
                    {
                        strValueLsd.AppendFormat(", {0}", strPrivPropNameWithObjectName);
                    }
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                    {
                        strParaIndex += ", '{" + intIndex.ToString() + "}'";
                    }
                    else
                    {
                        strParaIndex += ", {" + intIndex.ToString() + "}";
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

        public virtual string GenAddNewRecordBySQL2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����¼�¼,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�����������¼,�÷�ʽ���Ż���ʽ");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ�ʹ�ֶ�ֵΪNULL���ֶ��������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n //��Ҫ�������ֶ��б�");
            strBuilder.Append("\r\n ArrayList arrFieldListForInsert = new ArrayList();");
            strBuilder.Append("\r\n //��Ҫ������ֵ�б�");
            strBuilder.Append("\r\n ArrayList arrValueListForInsert = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInAddNewRecordBySql2(objField);
                strBuilder.AppendFormat("\r\n {0}", strTemp);
            }

            strBuilder.Append("\r\n //��֯�����¼SQL��");
            strBuilder.Append("\r\n string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strFieldListCode = string.Join(\",\", sstrFieldCode);");
            strBuilder.Append("\r\n string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strValuesListCode = string.Join(\",\", sstrValuesCode);");

            strBuilder.AppendFormat("\r\n strSQL.Append(\"Insert into {0}\");",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n strSQL.AppendFormat(\" ({{0}}) values ({{1}}) \", strFieldListCode, strValuesListCode);",
            "{", "}");

            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());");
 

             strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///����¼�¼,BySQL == = ;
            return strBuilder.ToString();
        }
        public virtual string GenAddNewRecordBySQL2WithReturnKey()
        {

            if (objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
              && objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03) return "";
            StringBuilder strBuilder = new StringBuilder();
            ///����¼�¼,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�����������¼,�÷�ʽ���Ż���ʽ,ͬʱ�����²����¼�Ĺؼ��ֵ�ֵ(���Identity�ؼ���)");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ�ʹ�ֶ�ֵΪNULL���ֶ�������룻3�������²����¼�Ĺؼ��ֵ�ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻��²����¼�Ĺؼ��ֵ�ֵ,����ͱ���</returns>");
            strBuilder.AppendFormat("\r\npublic string AddNewRecordBySQL2WithReturnKey(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n //��Ҫ�������ֶ��б�");
            strBuilder.Append("\r\n ArrayList arrFieldListForInsert = new ArrayList();");
            strBuilder.Append("\r\n //��Ҫ������ֵ�б�");
            strBuilder.Append("\r\n ArrayList arrValueListForInsert = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInAddNewRecordBySql2(objField);
                strBuilder.AppendFormat("\r\n {0}", strTemp);

            }

            strBuilder.Append("\r\n //��֯�����¼SQL��");
            strBuilder.Append("\r\n string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strFieldListCode = string.Join(\",\", sstrFieldCode);");
            strBuilder.Append("\r\n string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strValuesListCode = string.Join(\",\", sstrValuesCode);");

            strBuilder.AppendFormat("\r\n strSQL.Append(\"Insert into {0}\");",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n strSQL.AppendFormat(\" ({{0}}) values ({{1}}); \", strFieldListCode, strValuesListCode);",
            "{", "}");

            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());");

            if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                strBuilder.Append("\r\n strSQL.Append(\" select @@identity;\");");
            }
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                strBuilder.Append("\r\nreturn objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();");
            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
            {
                strBuilder.Append("\r\nreturn objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();");
            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
            {
                strBuilder.Append("\r\nreturn objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();");
            }
            else
            {
                strBuilder.Append("\r\n objSQL.ExecSql(strSQL.ToString());");
                strBuilder.AppendFormat("\r\nreturn obj{0}EN.{1};", objPrjTabENEx.TabName, objKeyField.FldName);
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///����¼�¼,BySQL == = ;
            return strBuilder.ToString();
        }


        public virtual string GenAddNewRecordBySQL2WithReturnKeyAndTransaction()
        {

            if (objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
              && objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03) return "";
            StringBuilder strBuilder = new StringBuilder();
            ///����¼�¼,BySQL----------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�����������¼,�÷�ʽ���Ż���ʽ,ͬʱ�����²����¼�Ĺؼ��ֵ�ֵ.(��������)(���Identity�ؼ���)");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ�ʹ�ֶ�ֵΪNULL���ֶ�������룻3�������²����¼�Ĺؼ��ֵ�ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻��²����¼�Ĺؼ��ֵ�ֵ,����ͱ���</returns>");
            strBuilder.AppendFormat("\r\npublic string AddNewRecordBySQL2WithReturnKey(cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n //��Ҫ�������ֶ��б�");
            strBuilder.Append("\r\n ArrayList arrFieldListForInsert = new ArrayList();");
            strBuilder.Append("\r\n //��Ҫ������ֵ�б�");
            strBuilder.Append("\r\n ArrayList arrValueListForInsert = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInAddNewRecordBySql2(objField);
                strBuilder.AppendFormat("\r\n {0}", strTemp);

            }

            strBuilder.Append("\r\n //��֯�����¼SQL��");
            strBuilder.Append("\r\n string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strFieldListCode = string.Join(\",\", sstrFieldCode);");
            strBuilder.Append("\r\n string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strValuesListCode = string.Join(\",\", sstrValuesCode);");

            strBuilder.AppendFormat("\r\n strSQL.Append(\"Insert into {0}\");",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n strSQL.AppendFormat(\" ({{0}}) values ({{1}}); \", strFieldListCode, strValuesListCode);",
            "{", "}");

            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());");

            if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                strBuilder.Append("\r\n strSQL.Append(\" select @@identity;\");");
            }
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                strBuilder.Append("\r\nreturn objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();");

            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
            {
                strBuilder.Append("\r\nreturn objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();");
            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
            {
                strBuilder.Append("\r\nreturn objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();");
            }
            else
            {
                strBuilder.Append("\r\n    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);");
                strBuilder.AppendFormat("\r\nreturn obj{0}EN.{1};", objPrjTabENEx.TabName, objKeyField.FldName);
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///����¼�¼,BySQL == = ;
            return strBuilder.ToString();
        }

        public virtual string GenAddNewRecordBySQLWithTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����¼�¼,BySQL----------------;

            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ͨ��SQL�����������¼.(��������)");
            strBuilder.Append("\r\n /// ��Ҫ�����ϴ��ļ�ʱ��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL(cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            ///strBuilder.Append("\r\nstrSQL.AppendFormat(\"insert into StdPhoto (Stdid, FileName) values ('{0}', '{1}')\", objPrjTabENEx.Stdid, objPrjTabENEx.FileName);");
            StringBuilder strFieldLst = new StringBuilder();
            StringBuilder strValueLsd = new StringBuilder();
            string strParaIndex = "";
            bool bolIsFirst = true;
            int intIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.FldOpTypeId == "0003") //ֻд
                {
                    if (bolIsFirst == true)
                    {
                        strFieldLst.AppendFormat("{0}", objField.ObjFieldTabENEx.FldName);
                        strValueLsd.AppendFormat("{0}", strPrivPropNameWithObjectName4Get);
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
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
                        strFieldLst.AppendFormat(", {0}", objField.ObjFieldTabENEx.FldName);
                        strValueLsd.AppendFormat(", {0}", strPrivPropNameWithObjectName4Get);
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strParaIndex += ", '{" + intIndex.ToString() + "}'";
                        }
                        else
                        {
                            strParaIndex += ", {" + intIndex.ToString() + "}";
                        }

                    }

                    continue;
                }
                if (bolIsFirst == true)
                {
                    strFieldLst.AppendFormat("{0}", objField.ObjFieldTabENEx.FldName);
                    strValueLsd.AppendFormat("{0}", strPrivPropNameWithObjectName);
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
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
                    strFieldLst.AppendFormat(", {0}", objField.ObjFieldTabENEx.FldName);
                    strValueLsd.AppendFormat(", {0}", strPrivPropNameWithObjectName);
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strParaIndex += ", '{" + intIndex.ToString() + "}'";
                    }
                    else
                    {
                        strParaIndex += ", {" + intIndex.ToString() + "}";
                    }

                }
                intIndex = intIndex + 1;
            }

            strBuilder.AppendFormat("\r\nstrSQL.AppendFormat(\"insert into {3} ({0}) values ({1})\", {2});", strFieldLst.ToString(), strParaIndex, strValueLsd.ToString(), objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///����¼�¼,BySQL == = ;
            return strBuilder.ToString();
        }

        public virtual string GenAddNewRecordBySQLWithTransaction2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����¼�¼,BySQL----------------;

            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ͨ��SQL�����������¼");
            strBuilder.Append("\r\n /// ��Ҫ�����ϴ��ļ�ʱ��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool AddNewRecordBySQL2(cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n StringBuilder strSQL = new StringBuilder();");
            strBuilder.Append("\r\n //��Ҫ�������ֶ��б�");
            strBuilder.Append("\r\n ArrayList arrFieldListForInsert = new ArrayList();");
            strBuilder.Append("\r\n //��Ҫ������ֵ�б�");
            strBuilder.Append("\r\n ArrayList arrValueListForInsert = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInAddNewRecordBySql2(objField);
                strBuilder.AppendFormat("\r\n {0}", strTemp);

            }

            strBuilder.Append("\r\n //��֯�����¼SQL��");
            strBuilder.Append("\r\n string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strFieldListCode = string.Join(\",\", sstrFieldCode);");
            strBuilder.Append("\r\n string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType(\"System.String\")));");
            strBuilder.Append("\r\n string strValuesListCode = string.Join(\",\", sstrValuesCode);");

            strBuilder.AppendFormat("\r\n strSQL.Append(\"Insert into {0}\");",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n strSQL.AppendFormat(\" ({{0}}) values ({{1}}) \", strFieldListCode, strValuesListCode);",
            "{", "}");

            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");

            ///����¼�¼,BySQL == = ;
            return strBuilder.ToString();
        }

        public virtual string GenAddnewRecBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ͨ���洢�����������¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ����ݿ��еĶ���</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");

            strTemp = string.Format("public bool Addnew{0}BySP(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//ͨ���洢������");
            strBuilder.Append("\r\n//ֱ��ʹ��");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.PrimaryTypeId == "02" && objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    continue;
                }
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strBuilder.AppendFormat("\r\nvalues.Add({0});", strPrivPropNameWithObjectName4Get);
                    continue;
                }
                strBuilder.AppendFormat("\r\nvalues.Add({0});", strPrivPropNameWithObjectName);
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
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ���洢����(StoreProcedure)���޸ļ�¼");
            strBuilder.Append("\r\n /// /// ȱ��:1������֧��������.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strTemp = string.Format("public bool UpdateBySP(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n//ͨ���洢������");
            strBuilder.Append("\r\n//ֱ��ʹ��");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.FldOpTypeId == "0003")
                {
                    strBuilder.AppendFormat("\r\nvalues.Add({0});", strPrivPropNameWithObjectName4Get);
                    continue;
                }

                strBuilder.AppendFormat("\r\nvalues.Add({0});", strPrivPropNameWithObjectName);
            }
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Update\",values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() ==  == ;
            return strBuilder.ToString();
        }

        public virtual string GenDelRecordBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ����ǰ������ָ�ļ�¼,ͨ���洢������ʵ��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>���ɾ���ɹ��򷵻�TRUE,����ΪFALSE</returns>");

            strTemp = string.Format("public bool DelRecordBySP() ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//ͨ���洢������");
            strBuilder.Append("\r\n//ֱ��ʹ��");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objKeyField in objPrjTabENEx.arrKeyFldSet)
            {
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objKeyField, "obj" + objPrjTabENEx.TabName + "EN");

                strBuilder.AppendFormat("\r\nvalues.Add({0});", strPrivPropNameWithObjectName4Get );
            }
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Delete\", values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() ==  == ;
            return strBuilder.ToString();
        }


        public virtual string GenDelRecordBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ���ؼ�����ָ���ļ�¼,ͨ���洢����(SP)��ɾ����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>���ɾ���ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strTemp = string.Format("public bool DelRecordBySP({0}) ", objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n//ͨ���洢������");
            strBuilder.Append("\r\n//ֱ��ʹ��");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.Append("\r\nvalues.Add(" + objField.ObjFieldTabENEx.PrivFuncName + ");");
            }
            strBuilder.AppendFormat("\r\n objSQL.ExecSP(\"{0}_Delete\", values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() ==  == ;
            return strBuilder.ToString();
        }
        public virtual string GenAddnewMultiRec()
        {

            StringBuilder strBuilder = new StringBuilder();
            ///��Ӷ����¼�¼---------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �Ѷ�����¼ͬʱ���뵽����!");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"oDT\"></param>");
//            strBuilder.Append("\r\n /// <param name = \"strResult\"></param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strTemp = string.Format("public bool Addnew{0}s(System.Data.DataTable oDT) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataAdapter objDA;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlCommandBuilder objCB; ");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow;");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where " + objKeyField.FldName + " = '111'\";");
            strBuilder.Append("\r\nobjDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);");
            strBuilder.AppendFormat("\r\nobjDA.Fill(objDS, \"{0}\");", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n//���ؼ��ֵ�Ψһ��");
            ///����ñ�Ĺؼ�����˳�������;
            if (objKeyField.ObjFieldTabENEx.IsIdentity == false)
            {
                if (objPrjTabENEx.arrKeyFldSet.Count == 0)
                {
                    strBuilder.Append("\r\n//��ı�" + objPrjTabENEx.TabName + " ��û�йؼ���,��������һ���ؼ���!");

                    /// MsgBox("��ı���û�йؼ���");
                }
                else
                {
                    strBuilder.Append("\r\nforeach(System.Data.DataRow oRow in oDT.Rows)");
                    strBuilder.Append("\r\n{");
                    string strTT;
                    foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
                    {
                        strTT = string.Format("oRow[cls{1}EN.con_{0}].ToString().Trim()",
                            objField.ObjFieldTabENEx.FldName,
                            objPrjTabENEx.TabName);
                        strTemp = string.Format("{0} {1} = " + AccessNull(strTT, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable) + ";",
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.ObjFieldTabENEx.PrivFuncName);
                        strBuilder.Append("\r\n" + strTemp);
                    }
                    strBuilder.Append("\r\nif (IsExist(" + objPrjTabENEx.KeyPrivFuncFldNameLstStr + "))");
                    strBuilder.Append("\r\n{");
                    ArrayList arrKeyVarLst = new ArrayList();
                    ArrayList arrKeyValueLst = new ArrayList();
                    int intKeyIndex = 0;
                    foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
                    {
                        string strKeyVar = string.Format("{0} = {1}{2}{3}", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                        arrKeyVarLst.Add(strKeyVar);
                        arrKeyValueLst.Add(objField.ObjFieldTabENEx.PrivFuncName);
                        intKeyIndex++;
                    }
                    string strKeyVarLst = clsArray.GetSqlInStrByArray(arrKeyVarLst, false);
                    string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);
                    string strKeyVarValueLst = string.Format("string.Format(\"{0}\", {1})", strKeyVarLst, strKeyValueLst);
                    clsArray.GetSqlInStrByArray(arrKeyVarLst, false);
                    strBuilder.Append("\r\n string strResult = \"�ؼ��ֱ���ֵΪ:\" + " + strKeyVarValueLst + " + \"�ļ�¼�Ѵ���,�����ظ�����!\" ;");
                    strBuilder.Append("\r\n throw new Exception(strResult);");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n//�Ѷ�����¼���뵽����");
            strBuilder.Append("\r\nforeach(System.Data.DataRow oRow in oDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjRow = objDS.Tables[cls{0}EN._CurrTabName ].NewRow();",
                 objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.PrimaryTypeId == "02" && objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    continue;
                }
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                strBuilder.AppendFormat("\r\nobjRow[cls{1}EN.con_{2}] = oRow[cls{1}EN.con_{2}].ToString().Trim(); //{0}",
                    objField.ColCaption,
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
            }
            strBuilder.AppendFormat("\r\n objDS.Tables[cls{0}EN._CurrTabName].Rows.Add(objRow);",
                            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjDA.Update(objDS, cls{0}EN._CurrTabName);",
                 objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch(Exception objException) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            
            
            
            
            strBuilder.Append("\r\nobjSQL.SQLConnect.Close();");
            
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///��Ӷ����¼�¼ ==  ==  == = ;
            return strBuilder.ToString();
        }
        public virtual string GenUpdate()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�޸ļ�¼------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ͨ��ADO�޸ļ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵ����ݿ��еĶ���</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");

            strBuilder.AppendFormat("\r\npublic bool Update(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataAdapter objDA ;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\n System.Data.SqlClient.SqlCommandBuilder objCB ;");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow ;");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL = \"Select * from {0} where {1};",
            objPrjTabENEx.TabName, KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName + "EN"));
            strBuilder.Append("\r\nobjDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);");
            strBuilder.AppendFormat("\r\nobjDA.Fill(objDS, cls{0}EN._CurrTabName);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nif (objDS.Tables[cls{0}EN._CurrTabName].Rows.Count  ==  0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//MsgBox(\"û����Ӧ��ID��:" + KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName + "EN") + ");");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\nobjRow = objDS.Tables[cls{0}EN._CurrTabName].Rows[0];",
                        objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //if ((objField.Is1Identity  ==  false) && (objField.IsTabPrimary  ==  false))
                //{
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.FldOpTypeId == "0003")
                {
                    strBuilder.AppendFormat("\r\n if (obj{1}EN.IsUpdated(cls{1}EN.con_{0}))",
               objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\nobjRow[cls{1}EN.con_{2}] = {3}; //{0}",
                        objField.ColCaption,
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName,
                    strPrivPropNameWithObjectName4Get);
                    strBuilder.Append("\r\n }");
                    continue;
                }

                strBuilder.AppendFormat("\r\n if (obj{1}EN.IsUpdated(cls{1}EN.con_{0}))",
                objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\nobjRow[cls{1}EN.con_{2}] = {3}; //{0}",
                    objField.ColCaption,
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName,
                     strPrivPropNameWithObjectName );
                strBuilder.Append("\r\n }");

            }
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjDA.Update(objDS, cls{0}EN._CurrTabName);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            
            
            
            
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///�޸ļ�¼ == = ;
            return strBuilder.ToString();
        }

        public virtual string GenUpdateBySql()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�޸ļ�¼------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ�Ƿ��Ż���ʽ");
            strBuilder.Append("\r\n /// /// ȱ��:1�����ܴ����ֶ��еĵ�Ʋ���⣻2�����ܴ������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool UpdateBySql(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //if ((objField.Is1Identity  ==  false) && (objField.IsTabPrimary  ==  false))
                //{
                if (IsKeyField(objField.ObjFieldTabENEx.FldName) == true) continue;
                string strTemp = GetCode4FieldInUpdateBySql(objField, ref bolIsFirst);
                strBuilder.AppendFormat("\r\n {0}", strTemp);

            }


            ArrayList arrKeyVarLst = new ArrayList();
            ArrayList arrKeyValueLst = new ArrayList();
            int intKeyIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                string strKeyVar = "";
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                {
                    strKeyVar = string.Format("{0} = '{1}{2}{3}'", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                else
                {
                    strKeyVar = string.Format("{0} = {1}{2}{3}", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                arrKeyVarLst.Add(strKeyVar);
                arrKeyValueLst.Add("obj" + objPrjTabENEx.TabName + "EN" + "." + objField.ObjFieldTabENEx.FldName);
                intKeyIndex++;
            }
            string strKeyVarLst = clsArray.Join(arrKeyVarLst, " And ");

            string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);

            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0}\", {1}); ",
            strKeyVarLst,
            strKeyValueLst);

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///�޸ļ�¼ == = ;
            return strBuilder.ToString();
        }

        public virtual string GenUpdateBySqlWithCondition()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�޸ļ�¼------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ�Ƿ��Ż���ʽ,���������޸ļ�¼");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ��������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵĶ���</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strCondition\">�޸ļ�¼ʱ������</param>");
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool UpdateBySqlWithCondition(cls{0}EN obj{0}EN, string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (IsKeyField(objField.ObjFieldTabENEx.FldName) == true) continue;
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInUpdateBySqlWithCondition(objField, ref bolIsFirst);
                strBuilder.AppendFormat("\r\n {0}", strTemp);

                //}

            }
            strBuilder.AppendFormat("\r\n sbSQL.Remove(sbSQL.Length - 1, 1);");


            ArrayList arrKeyVarLst = new ArrayList();
            ArrayList arrKeyValueLst = new ArrayList();
            int intKeyIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                string strKeyVar = "";
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                {
                    strKeyVar = string.Format("{0} = '{1}{2}{3}'", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                else
                {
                    strKeyVar = string.Format("{0} = {1}{2}{3}", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                arrKeyVarLst.Add(strKeyVar);
                arrKeyValueLst.Add("obj" + objPrjTabENEx.TabName + "EN" + "." + objField.ObjFieldTabENEx.FldName);
                intKeyIndex++;
            }
            string strKeyVarLst = clsArray.Join(arrKeyVarLst, " And ");

            string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);

            strBuilder.Append("\r\n sbSQL.AppendFormat(\" Where {0}\", strCondition); ");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());");

            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///�޸ļ�¼ == = ;
            return strBuilder.ToString();
        }

        public virtual string GenUpdateBySqlWithConditionTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�޸ļ�¼------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ���Ż���ʽ,���������޸ļ�¼.(��������)");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ��������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵĶ���</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strCondition\">�޸ļ�¼ʱ������</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool UpdateBySqlWithConditionTransaction(cls{0}EN obj{0}EN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (IsKeyField(objField.ObjFieldTabENEx.FldName) == true) continue;
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInUpdateBySqlWithCondition(objField, ref bolIsFirst);
                strBuilder.AppendFormat("\r\n {0}", strTemp);

                //}

            }
            strBuilder.AppendFormat("\r\n sbSQL.Remove(sbSQL.Length - 1, 1);");


            ArrayList arrKeyVarLst = new ArrayList();
            ArrayList arrKeyValueLst = new ArrayList();
            int intKeyIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                string strKeyVar = "";
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                {
                    strKeyVar = string.Format("{0} = '{1}{2}{3}'", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                else
                {
                    strKeyVar = string.Format("{0} = {1}{2}{3}", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                arrKeyVarLst.Add(strKeyVar);
                arrKeyValueLst.Add("obj" + objPrjTabENEx.TabName + "EN" + "." + objField.ObjFieldTabENEx.FldName);
                intKeyIndex++;
            }
            string strKeyVarLst = clsArray.Join(arrKeyVarLst, " And ");

            string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);

            strBuilder.Append("\r\n sbSQL.AppendFormat(\" Where {0}\", strCondition); ");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());");

            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///�޸ļ�¼ == = ;
            return strBuilder.ToString();
        }


        public virtual string GenUpdateBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�޸ļ�¼------------------;
            ///
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ���Ż���ʽ");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ��������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");

            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\npublic bool UpdateBySql2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (IsKeyField(objField.ObjFieldTabENEx.FldName) == true) continue;
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInUpdateBySql2(objField);
                strBuilder.AppendFormat("\r\n {0}", strTemp);

                //}

            }
            strBuilder.AppendFormat("\r\n sbSQL.Remove(sbSQL.Length - 1, 1);");


            ArrayList arrKeyVarLst = new ArrayList();
            ArrayList arrKeyValueLst = new ArrayList();
            int intKeyIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                string strKeyVar = "";
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                {
                    strKeyVar = string.Format("{0} = '{1}{2}{3}'", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                else
                {
                    strKeyVar = string.Format("{0} = {1}{2}{3}", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                arrKeyVarLst.Add(strKeyVar);
                arrKeyValueLst.Add("obj" + objPrjTabENEx.TabName + "EN" + "." + objField.ObjFieldTabENEx.FldName);
                intKeyIndex++;
            }
            string strKeyVarLst = clsArray.Join(arrKeyVarLst, " And ");

            string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);

            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0}\", {1}); ",
            strKeyVarLst,
            strKeyValueLst);

            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());");
 
             strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n" +"string strMsg = string.Format(\"��������:[{{0}}].SQL:[{{1}}].({{2}})\",","{","}");
            strBuilder.Append("\r\n" + "     objException.Message, sbSQL.ToString(), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");

//            strBuilder.Append("\r\nclsGeneralTab2.LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(strMsg);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///�޸ļ�¼ == = ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// ����ֶ����Ƿ��ǹؼ��ֶ�
        /// </summary>
        /// <param name = "strFldName">������ֶ���</param>
        /// <param name = "objPrjTabENEx"></param>
        /// <returns></returns>
        public bool IsKeyField(string strFldName)
        {
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {

                if (objField.ObjFieldTabENEx.FldName == strFldName)
                {
                    return true;
                }
            }
            return false;
        }
        public virtual string GenUpdateBySqlWithTransaction()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�޸ļ�¼------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ�Ƿ��Ż���ʽ.(��������)");
            strBuilder.Append("\r\n /// /// �ŵ�:1��֧��������.");
            strBuilder.Append("\r\n /// /// ȱ��:1�����ܴ����ֶ��еĵ�Ʋ���⣻");
            strBuilder.Append("\r\n /// /// 2�����ܴ������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�;");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");

            strBuilder.AppendFormat("\r\npublic bool UpdateBySql(cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (IsKeyField(objField.ObjFieldTabENEx.FldName) == true) continue;
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInUpdateBySql(objField, ref bolIsFirst);
                strBuilder.AppendFormat("\r\n {0}", strTemp);

            }

            ArrayList arrKeyVarLst = new ArrayList();
            ArrayList arrKeyValueLst = new ArrayList();
            int intKeyIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                string strKeyVar = "";
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                {
                    strKeyVar = string.Format("{0} = '{1}{2}{3}'", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                else
                {
                    strKeyVar = string.Format("{0} = {1}{2}{3}", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                arrKeyVarLst.Add(strKeyVar);
                arrKeyValueLst.Add("obj" + objPrjTabENEx.TabName + "EN" + "." + objField.ObjFieldTabENEx.FldName);
                intKeyIndex++;
            }
            string strKeyVarLst = clsArray.Join(arrKeyVarLst, " And ");

            string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);

            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0}\", {1}); ",
            strKeyVarLst,
            strKeyValueLst);

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());");
            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///�޸ļ�¼ == = ;
            return strBuilder.ToString();
        }

        public virtual string GenUpdateBySqlWithTransaction2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�޸ļ�¼------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ���Ż���ʽ.(��������)");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻");
            strBuilder.Append("\r\n /// /// 2���ܹ��������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�;");
            strBuilder.Append("\r\n /// /// 3��֧��������.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");

            strBuilder.AppendFormat("\r\npublic bool UpdateBySql2(cls{0}EN obj{0}EN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\nStringBuilder sbSQL = new StringBuilder();");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nsbSQL.AppendFormat(\"Update " + objPrjTabENEx.TabName + " Set \");");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (IsKeyField(objField.ObjFieldTabENEx.FldName) == true) continue;
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInUpdateBySql2(objField);
                strBuilder.AppendFormat("\r\n {0}", strTemp);


            }
            strBuilder.AppendFormat("\r\n sbSQL.Remove(sbSQL.Length - 1, 1);");

            ArrayList arrKeyVarLst = new ArrayList();
            ArrayList arrKeyValueLst = new ArrayList();
            int intKeyIndex = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                string strKeyVar = "";
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote)
                {
                    strKeyVar = string.Format("{0} = '{1}{2}{3}'", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                else
                {
                    strKeyVar = string.Format("{0} = {1}{2}{3}", objField.ObjFieldTabENEx.FldName, "{", intKeyIndex, "}");
                }
                arrKeyVarLst.Add(strKeyVar);
                arrKeyValueLst.Add("obj" + objPrjTabENEx.TabName + "EN" + "." + objField.ObjFieldTabENEx.FldName);
                intKeyIndex++;
            }
            string strKeyVarLst = clsArray.Join(arrKeyVarLst, " And ");

            string strKeyValueLst = clsArray.GetSqlInStrByArray(arrKeyValueLst, false);

            strBuilder.AppendFormat("\r\n sbSQL.AppendFormat(\" Where {0}\", {1}); ",
            strKeyVarLst,
            strKeyValueLst);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n " + "clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());");
            strBuilder.Append("\r\n return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///�޸ļ�¼ == = ;
            return strBuilder.ToString();
        }


        public virtual string GenUpdateMultiRec()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�������޸Ķ�����¼------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:�޸Ķ�����¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\"></param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic int UpdateMultiRec(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("UpdateMultiRec", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}:UpdateMultiRec)\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataAdapter objDA ;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlCommandBuilder objCB ;");
            strBuilder.Append("\r\n//			System.Data.DataRow objRow ;");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount;");
            strBuilder.Append("\r\nif (strCondition  ==  \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0; //��ʾɾ��0����¼,ʵ�����ǲ��ܸñ�����м�¼");
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\nstrSQL = \"Select * from {0} where \" + strCondition;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);");
            strBuilder.AppendFormat("\r\nobjDA.Fill(objDS, \"{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nif (objDS.Tables[\"{0}\"].Rows.Count  ==  0)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0;");
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\nintRecCount = objDS.Tables[\"{0}\"].Rows.Count;",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nforeach(System.Data.DataRow objRow in objDS.Tables[\"{0}\"].Rows)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
                if ((objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY) && (objField.FieldTypeId == enumFieldType.KeyField_02))
                {
                    continue;
                }
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                strBuilder.AppendFormat("\r\nobjRow[\"{0}\"] = {1}; //{2}",
                objField.ObjFieldTabENEx.FldName, strPrivPropNameWithObjectName4Get, objField.ColCaption);
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjDA.Update(objDS, \"{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            
            
            
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///�������޸Ķ�����¼ == = ;
            return strBuilder.ToString();
        }
        public virtual string GenGetRecCount()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡ���еļ�¼��---------------------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ��ǰ��ļ�¼��.�ñ��뵱ǰ����ء�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\n public static int GetRecCount()");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.GetRecCount(cls{0}EN._CurrTabName);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public virtual string GenGetRecCount_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ��ǰ��ļ�¼��, �ñ��뵱ǰ�಻��ء�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">�������ı���</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic static int GetRecCount(string strTabName)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(strTabName);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public virtual string GenGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ��ǰ�������������ļ�¼��, �ñ��뵱ǰ����ء�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\n public static int GetRecCountByCond(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.GetRecCount(cls{0}EN._CurrTabName, strCondition);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public virtual string GenGetRecCountByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ�����������������ļ�¼��, �ñ��뵱ǰ�಻��ء�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">�������ı���</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic static int GetRecCountByCond(string strTabName, string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(strTabName, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///��ȡ���еļ�¼�� ==  ==  == ;
            return strBuilder.ToString();
        }
        public virtual string GenfunSetFldValue4String()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����/��ȡ���еķ���������ĳ�ֶε�ֵ------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���õ�ǰ���еķ���������ĳ�ֶε�ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");



            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, strValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();

        }

        public virtual string GenfunSetFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����/��ȡ���еķ���������ĳ�ֶε�ֵ------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���õ�ǰ���еķ���������ĳ�ֶε�ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"varValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int SetFldValue<T>(string strFldName, T varValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, varValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }

        public virtual string GenfunSetFldValue4Float()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���õ�ǰ���еķ���������ĳ�ֶε�ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"fltValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, fltValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public virtual string GenfunSetFldValue4Int()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���õ�ǰ���еķ���������ĳ�ֶε�ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"intValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int SetFldValue(string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, intValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }

        public virtual string GenfunSetFldValue_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���ø������еķ���������ĳ�ֶε�ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"varValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue<T>(string strTabName, string strFldName, T varValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }


        public virtual string GenfunSetFldValue4String_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���ø������еķ���������ĳ�ֶε�ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, strValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public virtual string GenfunSetFldValue4Int_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���ø������еķ���������ĳ�ֶε�ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, intValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public virtual string GenfunSetFldValue4Float_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���ø������еķ���������ĳ�ֶε�ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"fltValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic static int SetFldValue(string strTabName, string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, fltValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public virtual string GenGetFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ��ǰ���еķ���������ĳ�ֶε�ֵ,���б���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ���ֶ�ֵ�б�</returns>");
            strBuilder.Append("\r\npublic List<string> GetFldValue(string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n List<string> arrList = objSQL.GetFldDataOfTable(\"{0}\", strFldName, strCondition);",
                         objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string GenGetFldValueNoDistinct()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ��ǰ���еķ���������ĳ�ֶε�ֵ,���б���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ���ֶ�ֵ�б�</returns>");
            strBuilder.Append("\r\npublic List<string> GetFldValueNoDistinct(string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n List<string> arrList = objSQL.GetFldDataOfTableNoDistinct(\"{0}\", strFldName, strCondition);",
                         objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public virtual string GenGetFldValue_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ�������еķ���������ĳ�ֶε�ֵ,���б���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ���ֶ�ֵ�б�</returns>");
            strBuilder.Append("\r\npublic static List<string> GetFldValue(string strTabName, string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);");
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///����/��ȡ���еķ���������ĳ�ֶε�ֵ == = ;
            return strBuilder.ToString();
        }
        public virtual string GenDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ����¼------------------;
            strBuilder.Append("\r\npublic bool DelRecord() ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL = \"\";");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
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

        public virtual string Gen_GetSpecSQLObj()
        {
            return "";
     
        }
              public virtual string Gen_GetSpecSQLObj_Obj()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");

            strBuilder.Append("\r\n public override clsSpecSQLforSql GetSpecSQLObj_Obj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //1. �����ǰ������ָ�������Ӵ�,���ö������Ӵ�");
            //strBuilder.Append("\r\n if (string.IsNullOrEmpty(this.ConnectString_Obj)  ==  false)");
            //strBuilder.Append("\r\n {");
            //strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(this.ConnectString_Obj);");
            //strBuilder.Append("\r\n return objSQL;");
            //strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //1. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�");
            strBuilder.Append("\r\n //3. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�");
            strBuilder.AppendFormat("\r\n if (string.IsNullOrEmpty(cls{0}EN._ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n objSQL = new clsSpecSQLforSql(cls{0}EN._ConnectString);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n");
            ///ɾ����¼ == = ;
            return strBuilder.ToString();
        }


        public virtual string Gen_GetSpecSQLObjV5()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");

            strBuilder.Append("\r\n public static clsSpecSQLforSql GetSpecSQLObj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");

            strBuilder.Append("\r\n //1. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. �������ָ�������Ӵ��ǿ�,���ø�����ָ�������Ӵ�");
            strBuilder.Append("\r\n //3. ���������Ŀϵͳ����(web.config or app.config)����ָ����Ĭ�����Ӵ�");
            strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}EN._ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjSQL = new clsSpecSQLforSql();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjSQL = new clsSpecSQLforSql(cls{0}EN._ConnectString);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objSQL;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///ɾ����¼ == = ;
            return strBuilder.ToString();
        }
        public virtual string Gen_GetSpecSQLObj_ObjV5()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");

            strBuilder.Append("\r\n public clsSpecSQLforSql GetSpecSQLObj_Obj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //1. �����ǰ������ָ�������Ӵ�,���ö������Ӵ�");
            strBuilder.Append("\r\n if (string.IsNullOrEmpty(this.ConnectString_Obj)  ==  false)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(this.ConnectString_Obj);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strBuilder.Append("\r\n if (clsSysPara.bolIsUseConnectStrName  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysPara.strConnectStrName, true);");
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


        public virtual string Gen_GetSpecSQLObj5()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");

            strBuilder.Append("\r\n public static clsSpecSQLforSql GetSpecSQLObj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");

            strBuilder.Append("\r\n //1. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strBuilder.Append("\r\n if (clsSysPara.bolIsUseConnectStrName  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysPara.strConnectStrName, true);");
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
        public virtual string Gen_GetSpecSQLObj_Obj5()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡSQL���������Ӷ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL���������Ӷ���</returns>");

            strBuilder.Append("\r\n public clsSpecSQLforSql GetSpecSQLObj_Obj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //1. �����ǰ������ָ�������Ӵ�,���ö������Ӵ�");
            strBuilder.Append("\r\n if (string.IsNullOrEmpty(this.ConnectString_Obj)  ==  false)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(this.ConnectString_Obj);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. ���ϵͳ����(SysPara)������ʹ�����Ӵ���,���ø����Ӵ�����ָ�������Ӵ�");
            strBuilder.Append("\r\n if (clsSysPara.bolIsUseConnectStrName  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysPara.strConnectStrName, true);");
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

        public virtual string GenDelRecordWithTransaction()
        {

            StringBuilder strBuilder = new StringBuilder();
            ///ɾ����¼------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ǰ������ָ�ļ�¼.(��������)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>����ɾ���Ƿ�ɹ�?��</returns>");

            strBuilder.Append("\r\npublic bool DelRecord(SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL = \"\";");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            //			if ( objFKSet.GetDelFKTab !=  \")
            //										 {
            //											 strBuilder.Append("\r\n//ɾ����" + objPrjTabENEx.TabName + "���йص�������е�����");
            //											 strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strBuilder.Append("\r\n//ɾ��" + objPrjTabENEx.TabName + "�������뵱ǰ�����йصļ�¼");
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr() + ";");
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///ɾ����¼ == = ;
            return strBuilder.ToString();
        }
        public virtual string GenDelRecordWithTransaction_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ����¼------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ���ؼ�����ָ�ļ�¼,ʹ������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>����ɾ���Ƿ�ɹ�?��</returns>");
            strBuilder.AppendFormat("\r\npublic bool DelRecord({0}, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) ",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\nstring strSQL = \"\";");
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            //			if ( objFKSet.GetDelFKTab !=  \")
            //										 {
            //											 strBuilder.Append("\r\n//ɾ����" + objPrjTabENEx.TabName + "���йص�������е�����");
            //											 strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strBuilder.Append("\r\n//ɾ��" + objPrjTabENEx.TabName + "�������뵱ǰ�����йصļ�¼");
            strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr(false) + ";");
            strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///ɾ����¼ == = ;
            return strBuilder.ToString();
        }

        public virtual string GenDelMultiRec_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��һЩ��¼------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ͬʱɾ��������¼,ɾ�������ؼ����б�ļ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"lstKey\">�����Ĺؼ���ֵ�б�</param>");
            strBuilder.Append("\r\n /// <returns>����ɾ���Ƿ�ɹ�?</returns>");
            strTemp = string.Format("public int Del{0}(List<string> lstKey)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstring strSQL;");
            strBuilder.Append("\r\nstring strKeyList;");
            strBuilder.Append("\r\nif (lstKey.Count  == 0) return 0;");
            strBuilder.Append("\r\nstrKeyList = \"\";");
            strBuilder.Append("\r\nfor (int i = 0; i<lstKey.Count; i++)");
            strBuilder.Append("\r\n{");
            ///				if ( (i == 0) strKeyList +=  "'" + lstKey[i].ToString() + "'";
            ///				else strKeyList +=  ", " + "'" + lstKey[i].ToString() + "'";
            if (objPrjTabENEx.arrKeyFldSet.Count == 0)
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
        
            strBuilder.Append("\r\n//ɾ��" + objPrjTabENEx.TabName + "�������뵱ǰ�����йصļ�¼");
            if (objPrjTabENEx.arrKeyFldSet.Count == 0)
            {
                strBuilder.Append("\r\n//��ı�" + objPrjTabENEx.TabName + " ��û�йؼ���,��������һ���ؼ���!");
                strBuilder.Append("\r\nreturn false;");
            }
            else
            {
                strBuilder.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + objKeyField.FldName + " in (\" + strKeyList + \")\";");
                strBuilder.Append("\r\nreturn objSQL.ExecSql2(strSQL);");
            }
            strBuilder.Append("\r\n}");
            ///ɾ��һЩ��¼ == = ;
            return strBuilder.ToString();
        }
        public virtual string GenDelRecord_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��һ����¼-----------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ���ؼ�����ָ���ļ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼��</returns>");
            strBuilder.Append("\r\n" + string.Format("public int DelRecord({0}) ", objPrjTabENEx.KeyVarDefineLstStr));
            strBuilder.Append("\r\n{");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }

            strBuilder.Append("\r\n//ɾ��������¼");
            strBuilder.Append("\r\nstring strSQL = \"\";");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
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
            strBuilder.Append("\r\n return objSQL.ExecSql2(strSQL);");
            strBuilder.Append("\r\n}");
            ///ɾ��һ����¼ == = ;
            return strBuilder.ToString();
        }
        public virtual string GenDelCondRec_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��������¼,ɾ���������ļ�¼------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ�����������Ķ�����¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">��Ҫɾ���ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼����</returns>");
            strBuilder.AppendFormat("\r\npublic int Del{0}(string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = "Del{0}";//, objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: Del{0})\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
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

        public virtual string GenDelCondRecWithTransaction_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��������¼,ɾ���������ļ�¼------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ�����������Ķ�����¼,ͬʱ��������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">��Ҫɾ���ļ�¼����</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlConnection\">Sql���Ӷ���</param>");
            strBuilder.Append("\r\n /// <param name = \"objSqlTransaction\">Sql�������</param>");
            strBuilder.Append("\r\n /// <returns>�����Ƿ�ɾ���ɹ���</returns>");
            strBuilder.AppendFormat("\r\npublic bool Del{0}WithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = "Del{0}WithTransaction_S";//, objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: Del{0}WithTransaction_S)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstring strSQL;");
            strBuilder.Append("\r\nif (strCondition  ==  \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;	//��ʾɾ��0����¼,ʵ�����ǲ��ܸñ�����м�¼");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nstrSQL = \"Delete from {0} where \" + strCondition ;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);");
            strBuilder.Append("\r\nreturn bolResult;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///ɾ��������¼,ɾ���������ļ�¼ == = ;
            return strBuilder.ToString();
        }


        public virtual string GenGetRecValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ�ؼ�ֵ�ļ�¼-----------------------------;
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

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where " + KeyWhereStrWithObject("obj" + objPrjTabENEx.TabName + "EN") + ";");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull(objField) + "); //{2}",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n {4} = {5}; //{0}(�ֶ�����:{1},�ֶγ���:{2},�Ƿ�ɿ�:{3})", 
                        objField.ColCaption, 
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objField.ObjFieldTabENEx.FldLength, 
                        objField.ObjFieldTabENEx.IsNull,
                         strPrivPropNameWithObjectName ,
                          AccessNull(objField) );
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"�ڸ��ݹؼ��ֻ�ȡ����ʱ,����:{{0}},����!({1}: Get{0})\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strBuilder.Append("\r\n}");
            
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            //��ȡĳһ�ؼ�ֵ�ļ�¼ ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string Gen_GetObjByKeyId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {           
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ�ؼ�ֵ�ļ�¼-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ��ض���,�ö������ʽ��ʾ.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">��ؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>�����</returns>");
            strBuilder.AppendFormat("\r\npublic cls{0}EN GetObjBy{1}({2})",
            objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "CheckPrimaryKey_Sim({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where " + KeyWhereStr(false) + ";");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull_Static(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n {4} = {5}; //{0}(�ֶ�����:{1},�ֶγ���:{2},�Ƿ�ɿ�:{3})", 
                        objField.ColCaption, 
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName, 
                        objField.ObjFieldTabENEx.FldLength, 
                        objField.ObjFieldTabENEx.IsNull,
                         strPrivPropNameWithObjectName ,
                         AccessNull_Static(objField) );
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"���ݹؼ��ֻ�ȡ��ض���ʱ,����:{{0}},����!({1}: GetObjBy{0})\", objException.Message));",
        objKeyField.FldName, objPrjTabENEx.ClsName, "{", "}");

            strBuilder.Append("\r\n}");
            
            strBuilder.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            //��ȡĳһ�ؼ�ֵ�ļ�¼ ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetRecValueBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ�ؼ�ֵ�ļ�¼-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��ȡ��ǰ�ؼ��ֵļ�¼����,�ö������ʽ��ʾ.�ô洢����{0}_SelectOne����ȡ��", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ����ݿ��еĶ���</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.AppendFormat("\r\npublic bool Get{0}OneBySP(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");

            strBuilder.Append("\r\n ArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n " + clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName, this.IsFstLcase));
            strBuilder.Append("\r\n};");

            strBuilder.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectOne\",values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n {4} = {5}; //{0}(�ֶ�����:{1},�ֶγ���:{2},�Ƿ�ɿ�:{3})", 
                        objField.ColCaption,
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objField.ObjFieldTabENEx.FldLength, 
                        objField.ObjFieldTabENEx.IsNull,
                         strPrivPropNameWithObjectName ,
                          AccessNull(objField) );
                }
            }
            
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            //��ȡĳһ�ؼ�ֵ�ļ�¼ ==  == = ;
            return strBuilder.ToString();
        }


        public virtual string GenGetDataTable_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>�������ݱ�DataTable</returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable)\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
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
            strBuilder.Append("\r\n /// <returns>�������ݱ�DataTable</returns>");
            strBuilder.AppendFormat("\r\npublic System.Data.DataTable GetDataTable_{0}(string strCondition)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strFunctionName = "GetDataTable_{0}";//, objPrjTabENEx.TabName, objKeyField.FldName);
             strExplanation = "�����������к���{0},����!";
             strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable_{0})\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");


            //��ȡĳһ�ؼ�ֵ�ļ�¼ ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetDataTableByTabName_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����(��������)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <returns>�������ݱ�DataTable</returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition, string strTabName)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!(��������)";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable)\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strBuilder.Append("\r\n}");
            
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = string.Format(\"Select * from {0} where {1}\", strTabName, strCondition);");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");

            //��ȡĳһ�ؼ�ֵ�ļ�¼ ==  == = ;
            return strBuilder.ToString();
        }


        public virtual string GenGetDataTable_Exclude()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition, List<string> lstExclude)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable(string strCondition, List<string> lstExclude)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable)\", objException.Message));",
                   objPrjTabENEx.TabName,
                   objPrjTabENEx.ClsName,
                   "{", "}",
                   strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");


            //��ȡĳһ�ؼ�ֵ�ļ�¼ ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetDataTableByTabName_S_Exclude()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition, string strTabName, List<string> lstExclude)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable(string strCondition, string strTabName, List<string> lstExclude)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable)\", objException.Message));",
                   objPrjTabENEx.TabName,
                   objPrjTabENEx.ClsName,
                   "{", "}",
                   strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            
            strBuilder.Append("\r\nstrSQL = string.Format(\"Select * from {0} where {1}\", strTabName, strCondition);");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");


            //��ȡĳһ�ؼ�ֵ�ļ�¼ ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetDataTable_IsCheckSQLAttack()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ���Ծ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���Sql����</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition, bool bolIsCheckSQLAttack)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable(string strCondition, bool bolIsCheckSQLAttack)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetDataTableByTabName_S_IsCheckSQLAttack()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ���Ծ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���Sql����</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition, string strTabName, bool bolIsCheckSQLAttack)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable(string strCondition, string strTabName, bool bolIsCheckSQLAttack)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstrSQL = string.Format(\"Select * from {0} where {1}\", strTabName, strCondition);");

            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }


        public virtual string GetDataTable_Top_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ������¼�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">������¼��</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>�������ݱ�DataTable</returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable_Top", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable_Top)\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}}\", intTopSize, strCondition);",
                objPrjTabENEx.TabName, "{", "}");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }


        public virtual string GenGetDataTableByPager_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ҳ��¼�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intPageIndex\">ҳ���</param>");
            strBuilder.Append("\r\n /// <param name = \"intPageSize\">ҳ��¼��</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <returns>�������ݱ�DataTable</returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableByPager", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ڷ�ҳ��ѯ�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�ڷ�ҳ��ѯ�����������к���{{0}},����!({1}: GetDataTableByPager)\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n int intTop_In = intPageSize * (intPageIndex - 1);//��ȡ���Ӷ���");
            strBuilder.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}} and {3} not in (Select top {{2}} {3} from {0} where {{1}}) \", intPageSize, strCondition, intTop_In);",
            objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            //   strSQL = string.Format("Select Top {0} * from {0} where {1} and {0}Id not in (Select top {3} {0}Id from {0} where {1} order by {2}) order by {2}", intPageSize, strCondition, strOrderBy, intTop_In);
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}} and {3} not in (Select top {{3}} {3} from {0} where {{1}} order by {{2}}) order by {{2}} \", intPageSize, strCondition, strOrderBy, intTop_In);",
           objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GetDataTable_Top_S_Exclude()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ������¼�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">������¼��</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable_Top)\", objException.Message));",
                   objPrjTabENEx.TabName,
                   objPrjTabENEx.ClsName,
                   "{", "}",
                   strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}}\", intTopSize, strCondition);",
         objPrjTabENEx.TabName, "{", "}");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GetDataTable_Top_S_IsCheckSQLAttack()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ������¼���ݱ�,��DataTable��ʾ,ͬʱ���Ծ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">������¼��</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���Sql����</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, bool bolIsCheckSQLAttack)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable_Top(string strCondition, bool bolIsCheckSQLAttack)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable_Top)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}}\", intTopSize, strCondition);",
         objPrjTabENEx.TabName, "{", "}");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");



            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }


        public virtual string GenGetDataTableByPager_S_Exclude()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ҳ��¼�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intPageIndex\">ҳ���</param>");
            strBuilder.Append("\r\n /// <param name = \"intPageSize\">ҳ��¼��</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ڷ�ҳ��ѯ�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�ڷ�ҳ��ѯ�����������к���{{0}},����!({1}: GetDataTableByPager)\", objException.Message));",
                   objPrjTabENEx.TabName,
                   objPrjTabENEx.ClsName,
                   "{", "}",
                   strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n int intTop_In = intPageSize * (intPageIndex - 1);//��ȡ���Ӷ���");
            strBuilder.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}} and {3} not in (Select top {{2}} {3} from {0} where {{1}}) \", intPageSize, strCondition, intTop_In);",
            objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}} and {3} not in (Select top {{3}} {3} from {0} where {{1}} order by {{2}}) order by {{2}} \", intPageSize, strCondition, strOrderBy, intTop_In);",
           objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetDataTableByPager_S_IsCheckSQLAttack()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ҳ��¼���ݱ�,��DataTable��ʾ,ͬʱ���Ծ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intPageIndex\">ҳ���</param>");
            strBuilder.Append("\r\n /// <param name = \"intPageSize\">ҳ��¼��</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���Sql����</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, bool bolIsCheckSQLAttack)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, bool bolIsCheckSQLAttack)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ڷ�ҳ��ѯ�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�ڷ�ҳ��ѯ�����������к���{{0}},����!({1}: GetDataTableByPager)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n int intTop_In = intPageSize * (intPageIndex - 1);//��ȡ���Ӷ���");
            strBuilder.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}} and {3} not in (Select top {{2}} {3} from {0} where {{1}}) \", intPageSize, strCondition, intTop_In);",
            objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}} and {3} not in (Select top {{3}} {3} from {0} where {{1}} order by {{2}}) order by {{2}} \", intPageSize, strCondition, strOrderBy, intTop_In);",
           objPrjTabENEx.TabName, "{", "}", objKeyField.FldName);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");



            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetDataTableByRange_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <returns>�������ݱ�DataTable</returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n     if (intMinNum <=  0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableByRange", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTableByRange)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                         "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}} order by {0}3{1}) order by {0}3{1}\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetDataTableByRange_S_Exclude()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTableByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n     if (intMinNum <=  0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
         string   strFunctionName = string.Format("GetDataTableByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTableByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                    "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}} order by {0}3{1}) order by {0}3{1}\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetDataTableByRange_S_IsCheckSQLAttack()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ,ͬʱ���Ծ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���Sql����</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTableByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n     if (intMinNum <=  0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");


            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataTableByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTableByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetDataTableByRangeV_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ǰ����ͼ(View)��һ����Χ�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <returns>�������ݱ�DataTable</returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTableVByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n     if (intMinNum <=  0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableVByRange", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTableVByRange)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                         "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}} order by {0}3{1}) order by {0}3{1}\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetDataTableByRangeV_S_Exclude()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ǰ����ͼ(View)��һ����Χ�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTableVByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n     if (intMinNum <=  0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableVByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTableVByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");

            strBuilder.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                    "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}} order by {0}3{1}) order by {0}3{1}\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");



            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetDataTableByRangeV_S_IsCheckSQLAttack()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ǰ����ͼ(View)��һ����Χ�����ݱ�,��DataTable��ʾ,ͬʱ���Ծ����Ƿ���SQL����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���Sql����</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTableVByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n     if (intMinNum <=  0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");


            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableVByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTableVByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                 "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}} order by {0}3{1}) order by {0}3{1}\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");



            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetDataTableBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����, �ô洢��������ȡ��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>�������ݱ�DataTable</returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTableByCondBySP(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataTableByCondBySP", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTableByCondBySP)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n strCondition");
            strBuilder.Append("\r\n};");
            strBuilder.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectByCond\",values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }
        public virtual string GenGetCondRecDataSetBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ǰ������ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����, �ô洢��������ȡ��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>�������ݱ�DataSet</returns>");
            strBuilder.Append("\r\npublic System.Data.DataSet GetDataSetByCondBySP(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetByCondBySP(string strCondition)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");


            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSetByCondBySP)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n strCondition");
            strBuilder.Append("\r\n};");
            strBuilder.AppendFormat("\r\n objDS = objSQL.ExecSPReturnDS(\"{0}_SelectByCond\",values, \"{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }
        public virtual string GenGetDataSetByCondBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ǰ������ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����,�ô洢��������ȡ��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strBuilder.Append("\r\npublic System.Data.DataSet GetDataSetByCondBySP(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetByCondBySP", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSetByCondBySP)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n strCondition");
            strBuilder.Append("\r\n};");
            strBuilder.AppendFormat("\r\n objDS = objSQL.ExecSPReturnDS(\"{0}_SelectByCond\",values, \"{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }
        public virtual string GenGetDataSetByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ǰ������ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strBuilder.Append("\r\npublic System.Data.DataSet GetDataSet(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSet(string strCondition)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSet)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n strSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return objDS;");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetTopDataSetByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ǰ��Ķ������ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intTopSize\">������¼��</param>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strBuilder.Append("\r\npublic System.Data.DataSet GetDataSet_Top(int intTopSize, string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSet_Top(string strCondition)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSet_Top)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}}\", intTopSize, strCondition);",
            objPrjTabENEx.TabName, "{", "}");

            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return objDS;");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }


        public virtual string GenGetDataSetByCondByRange_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡһ����Χ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strBuilder.Append("\r\npublic System.Data.DataSet GetDataSetByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n     if (intMinNum <=  0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetByRange", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSetByRange)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");

            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                         "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                       objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }
        public virtual string GenGetDataSetByCondByRange_S_Exclude()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>"); 
            strBuilder.Append("\r\n /// ����������ȡһ����Χ�����ݱ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strBuilder.Append("\r\npublic System.Data.DataSet GetDataSetByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n     if (intMinNum <=  0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetByRange(string strCondition, List<string> lstExclude, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSet)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                    "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");


            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }
        public virtual string GenGetDataSetByCondByRange_S_IsCheckSQLAttack()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡһ����Χ�����ݱ�,��DataSet��ʾ,ͬʱ���Ծ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���Sql����</param>");
            strBuilder.Append("\r\n /// <returns>������������һ����Χ��DataSet</returns>");
            strBuilder.Append("\r\npublic System.Data.DataSet GetDataSetByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n     if (intMinNum <=  0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetByRange(string strCondition, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSet)ByRange\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");



            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSetByRange)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\n System.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
               "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                       objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");



            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }


        public virtual string GenGetDataSetByCond_V_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ǰ����ͼ�����ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strBuilder.Append("\r\npublic System.Data.DataSet GetDataSetV(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetV", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSetV)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n strSQL = \"Select * from v" + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"v{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return objDS;");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetDataSetByCondByRange_V_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ǰ����ͼ��һ����Χ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strBuilder.Append("\r\npublic System.Data.DataSet GetDataSetVByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n     if (intMinNum <=  0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetVByRange", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSetVByRange)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");

            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                         "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                   objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }
        public virtual string GenGetDataSetByCondByRange_V_S_Exclude()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ǰ����ͼ��һ����Χ�����ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strBuilder.Append("\r\npublic System.Data.DataSet GetDataSetVByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n     if (intMinNum <=  0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetVByRange(string strCondition, List<string> lstExclude, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSetVByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                    "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                       objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn objDS;");
            strBuilder.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }
        public virtual string GenGetDataSetByCondByRange_V_S_IsCheckSQLAttack()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ǰ����ͼ��һ����Χ�����ݼ�,��DataSet��ʾ,ͬʱ���Ծ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���Sql����</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <returns>�������ݼ�DataSet</returns>");
            strBuilder.Append("\r\npublic System.Data.DataSet GetDataSetVByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n     if (intMinNum <=  0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ����Сֵ{{0}}�Ƿ�,Ӧ�ò�С��0,����!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum > 6553005)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ{{0}}�Ƿ�,Ӧ�ò�����6553005(�������������������Ƽ�¼������),����!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (intMaxNum < intMinNum)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(string.Format(\"�����뷶Χ�����ֵ[{{0}}]����С����Сֵ[{{1}}],�Ƿ�,����!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");


            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetVByRange(string strCondition, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataSetVByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
               "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {0}3{1} And {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}} order by {0}3{1})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n }");

            strBuilder.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
           objPrjTabENEx.TabName);

            strBuilder.Append("\r\n return objDS;");
            strBuilder.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">��������</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic List<cls{0}EN> GetObjLst(string strCondition)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetObjLst", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}:GetObjLst)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");

            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"�ڸ���������ȡ�����б�ʱ,����:{{0}},����!({1}: GetObjLst)\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetObjLstByTabName()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">��������</param>");
            strBuilder.Append("\r\n /// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic List<cls{0}EN> GetObjLstByTabName(string strCondition, string strTabName)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetObjLstByTabName", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}:GetObjLstByTabName)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");

            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstrSQL = string.Format(\"Select * from {0} where {1}\", strTabName, strCondition);");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"�ڸ���������ȡ�����б�ʱ,����:{{0}},����!({1}: GetObjLst)\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenSetCondFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// ����������ȡ�����б�-{0}[{1}]", objField.ObjFieldTabENEx.FldCnName, objField.ObjFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <param name = \"strCondValue\">�ֶ�����ֵ</param>");
                strBuilder.Append("\r\n /// <param name = \"strComparisonOp\">�Ƚ������</param>");
                strBuilder.Append("\r\n /// <returns>void</returns>");
                strBuilder.AppendFormat("\r\npublic void SetCond_{0}(string strCondValue, string strComparisonOp)",
                    objKeyField.FldName,
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n{");
                strBuilder.AppendFormat("\r\n" + "this.{0} = strCondValue;",
                    objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "if (dicFldComparisonOp.ContainsKey(con{0}) == false)",
                    objKeyField.FldName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "dicFldComparisonOp.Add(con{0}, strComparisonOp);",
                    objKeyField.FldName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.AppendFormat("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "dicFldComparisonOp[con{0}] = strComparisonOp;",
                    objKeyField.FldName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n}");

            }

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }
          

        public string GenCopyObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\npublic void CopyTo(cls{0}EN obj{0}EN)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2}; //{3}",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
            }
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public string GenCopyObj5()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\npublic void CopyTo(cls{0} obj{0})", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = {2}; //{3}",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
            }
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }
        public string GenCopyObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\npublic void CopyTo(cls{0}EN obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public string GenCopyObjToSimObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������(��)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\npublic void CopyObjToSimObj(cls{0}EN obj{0}ENS, cls{0}EN_Sim obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}ENT.sf_UpdFldSetStr = obj{0}ENS.getsfUpdFldSetStr(); //sf_UpdFldSetStr",
                objPrjTabENEx.TabName);
            }
            strBuilder.Append("\r\n}");     
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public string GenCopyObjFromSimObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,�Ӽ򻯶����Ƶ�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ�򻯶���</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\npublic void CopyObjFromSimObj(cls{0}EN_Sim obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }


        public string GenCopyObjFromSimObj4Upd_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,�Ӽ򻯶����Ƶ�����. ר������޸ļ�¼,�����ֶβŸ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ�򻯶���</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\npublic void CopyObjFromSimObj4Upd(cls{0}EN_Sim obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n   string strsfUpdFldSetStr = obj{0}ENS.sf_UpdFldSetStr;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');");
            strBuilder.Append("\r\n   List<string> arrFldSet = new List<string>(sstrFldSet);");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "if (arrFldSet.Contains(cls{0}EN.con_{1})  ==  true)",
                         objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                               objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                    strBuilder.Append("\r\n" + "}");

                }
            }
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }


        public string GenCopyObj_S5()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}S\">Դ����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}T\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\npublic void CopyTo(cls{0} obj{0}S, cls{0} obj{0}T)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}T.{1} = obj{0}S.{1}; //{3}",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
            }
            strBuilder.Append("\r\n}");
            ;
            return strBuilder.ToString();
        }

        public virtual string GenGetObjLstBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ�����б�,ʹ�ô洢����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">��������</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic List<cls{0}EN> GetObjLstBySP(string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetObjLstBySP", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}:GetObjLstBySP)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n strCondition");
            strBuilder.Append("\r\n};");
            strBuilder.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectByCond\",values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                   objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"����������ȡ�����б�ʱ,����:{{0}},����!({1}: GetObjLstBySP)\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public string GenGetRecValueObjByDataRow()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ�ؼ�ֵ�ļ�¼-----------------------------;
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��DataRowת���ɼ�¼����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"objRow\">������DataRow</param>");
            strBuilder.AppendFormat("\r\n /// <returns>��¼����</returns>");

            strBuilder.AppendFormat("\r\npublic cls{0}EN GetObjByDataRow(DataRow objRow)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (objRow  ==  null)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");

            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]")
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[cls{0}EN.con_{1}] as byte[]; //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        //strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = objRow[cls{0}EN.con_{1}] as byte[]; //{2}",
                        // objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                    }
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"��DataRowת���ɼ�¼����ʱ,����:{{0}},����!({1}: GetObjByDataRow{0})\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��DataRowViewת���ɼ�¼����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"objRow\">������DataRowView</param>");
            strBuilder.AppendFormat("\r\n /// <returns>��¼����</returns>");

            strBuilder.AppendFormat("\r\npublic cls{0}EN GetObjByDataRow(DataRowView objRow)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (objRow  ==  null)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");

            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]")
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[cls{0}EN.con_{1}] as byte[]; //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        //strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = objRow[cls{0}EN.con_{1}] as byte[]; //{2}",
                        // objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                    }
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"��DataRowViewת���ɼ�¼����ʱ,����:{{0}},����!({1}: GetObjByDataRow)\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");

            //��ȡĳһ�ؼ�ֵ�ļ�¼ ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetFirstCondRecObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��һ�����������ļ�¼,�Զ�����ʽ��ʾ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">��������</param>");
            strBuilder.Append("\r\n /// <returns>�������������ĵ�һ������</returns>");
            strBuilder.AppendFormat("\r\npublic cls{0}EN GetFirstObj(string strCondition)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetFirstObj", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetFirstObj)\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nDataRow objRow = objDT.Rows[0];");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append(Gen_4BL_GC_GetObjFromDataRow());
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
            objPrjTabENEx.TabName);
            
            strBuilder.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"�ڸ���������ȡ��һ������ʱ,����:{{0}},����!({1}: GetFirstObj)\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetFirstCondRecObjBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��һ�����������ļ�¼,�Զ�����ʽ��ʾ,�ô洢��������ȡ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">��������</param>");
            strBuilder.Append("\r\n /// <returns>�������������ĵ�һ������</returns>");
            strBuilder.AppendFormat("\r\npublic cls{0}EN GetFirstObjBySP(string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetFirstObjBySP", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}:GetFirstObjBySP)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);

            strBuilder.Append("\r\n}");

            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n strCondition");
            strBuilder.Append("\r\n};");
            strBuilder.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectTop1ByCond\",values);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nDataRow objRow = objDT.Rows[0];");
            strBuilder.Append(Gen_4BL_GC_GetObjFromDataRow());
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
            objPrjTabENEx.TabName);
            
            strBuilder.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string GenGetDataTableT_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ������DataTable,���еĴ���ת������Ӧ������------------------------;
            if (objPrjTabENEx.IsNeedTransCode)
            {
                strBuilder = new StringBuilder();
                strBuilder.Append("\r\n");
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ����:��ȡĳһ������DataTable,���еĴ���ת������Ӧ������");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
                strBuilder.Append("\r\n /// <returns>�����Ѿ�ת�������DataTable</returns>");
                strBuilder.AppendFormat("\r\npublic System.Data.DataTable Get{0}T(string strCondition)",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\ntry");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
                strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
                strBuilder.Append("\r\n}");
                strBuilder.Append("\r\ncatch (Exception objException)");
                strBuilder.Append("\r\n{");

                string strFunctionName = string.Format("Get{0}T", objPrjTabENEx.TabName, objKeyField.FldName);
                string strExplanation = "�����������к���{0},����!";
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                    objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

                strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}:Get{0}T)\", objException.Message));",
                            objPrjTabENEx.TabName,
                            objPrjTabENEx.ClsName,
                            "{", "}",
                            strErrId);
                strBuilder.Append("\r\n}");

                strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
                strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

                strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
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
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.ObjFieldTab4CodeConv() != null)
                    {
                        if (objPrjTabENEx.TabId == objField.ObjFieldTab4CodeConv().CodeTabId)
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
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbWhereStr.AppendFormat("\r\nstrSQL.Append(\" where {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, 
                            objField.ObjFieldTabENEx.CodeTabName, objField.ObjFieldTabENEx.CodeTabCode);
                            bolIsFirst = false;
                        }
                        else
                        {
                            sbTabName.AppendFormat("\r\nstrSQL.Append(\" , {0} \");",
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbWhereStr.AppendFormat("\r\nstrSQL.Append(\" && {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, 
                            objField.ObjFieldTabENEx.CodeTabName, objField.ObjFieldTabENEx.CodeTabCode);
                        }
                        if (bolIsSelfLink == true)
                        {
                            sbFldStr.AppendFormat("\r\nstrSQL.Append(\", {0}Self.{1} {2}{3} \");",
                            objField.ObjFieldTabENEx.CodeTabName, 
                            objField.ObjFieldTabENEx.CodeTabName, 
                            objField.ObjFieldTabENEx.CodeTabName, 
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbLeftJoinStr.AppendFormat("\r\nstrSQL.Append(\" left JOIN {2} {2}Self on {0}.{1} = {2}Self.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.CodeTabName, 
                            objField.ObjFieldTabENEx.CodeTabCode);
                        }
                        else
                        {
                            sbFldStr.AppendFormat("\r\nstrSQL.Append(\", {0}.{1} {2}{3} \");",
                            objField.ObjFieldTabENEx.CodeTabName, 
                            objField.ObjFieldTabENEx.CodeTabName, 
                            objField.ObjFieldTabENEx.CodeTabName, 
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbLeftJoinStr.AppendFormat("\r\nstrSQL.Append(\" left JOIN {2} on {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, 
                            objField.ObjFieldTabENEx.CodeTabName, 
                            objField.ObjFieldTabENEx.CodeTabCode);
                        }
                    }
                }

                strBuilder.Append(sbFldStr.ToString());
                strBuilder.AppendFormat("\r\nstrSQL.Append(\" from {0} \");",
                objPrjTabENEx.TabName);
                strBuilder.Append(sbLeftJoinStr.ToString());
                /// strBuilder.Append(sbTabName.ToString());
                /// strBuilder.Append(sbWhereStr.ToString());
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
        public virtual string GenGetDataTableV_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ��������ر���ͼ(View)------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ǰ�����ͼ(View)����,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>�����Ѿ�ת�������DataTable</returns>");
            strBuilder.AppendFormat("\r\npublic System.Data.DataTable GetDataTableV(string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetDataTableV", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTableV)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);

            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
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
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ǰ�����ͼ(View)����,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>�����Ѿ�ת�������DataTable</returns>");
            strBuilder.AppendFormat("\r\npublic System.Data.DataTable GetDataTable_{0}V(string strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            strFunctionName = "GetDataTable_{0}V";//, objPrjTabENEx.TabName, objKeyField.FldName);
             strExplanation = "�����������к���{0},����!";
             strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}: GetDataTable_{0}V)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);

            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\nstrSQL.Append(\"Select v{0}.* \");", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstrSQL.Append(\" from v{0} \");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstrSQL.Append(\" where \" + strCondition); ");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL.ToString());");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");

            //��ȡĳһ������DataTable,���еĴ���ת������Ӧ������ == = ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// ����ͼ(SQL View)�л�ȡ��Ϣ���� == >DataTable
        /// </summary>
        /// <returns></returns>
        public virtual string GenGetDataTableV_S_Exclude()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ǰ�����ͼ(View)����,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����(���ų�)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.Append("\r\n /// <returns>�����Ѿ�ת�������DataTable</returns>");
            strBuilder.AppendFormat("\r\npublic System.Data.DataTable GetDataTableV(string strCondition, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableV(string strCondition, List<string> lstExclude)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}:GetDataTableV)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
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


        public virtual string GenGetPrimaryKeyID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ�����Ĺؼ����б�-----------------------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡĳһ�����Ĺؼ����б�");
            strBuilder.Append("\r\n ///		 �����ؼ����Ƕ��,�����ؼ���֮����\"//\"����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>�ؼ����б�</returns>");
            strBuilder.Append("\r\npublic static List<string> GetPrimaryKeyID(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ;");
            strBuilder.Append("\r\nList<string> arrList = new List<string>();");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.Append("\r\nstring strKeyValue; ");
            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from {1} where \" + strCondition;",
            objKeyField.FldName, objPrjTabENEx.TabName);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//				clsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//				objDT = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            
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
            
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///��ȡĳһ�����Ĺؼ����б� ==  ==  ==  ;
            return strBuilder.ToString();
        }
        public virtual string GenGetFileFromTabField()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�ϴ��ļ��Լ������ļ���ش���------------------------------------ ;
            if (objPrjTabENEx.IsHaveImageField == true)
            {
                strBuilder = new StringBuilder();
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ����:�����ݿ���ֶ��л�ȡ����,���Ҵ�����ļ��С�");
                strBuilder.Append("\r\n ///		˵��:���¼����Ϊ��ǰ��������Ӧ�ļ�¼��");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <param name = \"strDownLoadFileName\">��ȡ���ݺ�,�����˵��ļ�����</param>");
                strBuilder.Append("\r\n /// <returns>����ɹ���ȡ�ͷ���TRUE,����ΪFALSE</returns>");
                strBuilder.Append("\r\npublic bool GetFileFromTabField(string strDownLoadFileName)");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\nSpecData.clsSpecSQLforSql objSQL = new SpecData.clsSpecSQLforSql();");
                strBuilder.AppendFormat("\r\nstring strTabName = \"{0}\";", objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\nstring strFldName = \"{0}\";", objPrjTabENEx.ImageFieldName);
                strBuilder.Append("\r\nStringBuilder strCondition = new StringBuilder();");
                /// strBuilder.Append("\r\nstrCondition.AppendFormat(\"Stdid = '{0}'\", objPrjTabENEx.Stdid);");
                strBuilder.Append("\r\nstrCondition.AppendFormat(\" ");
                strBuilder.AppendFormat("{0}", objKeyField.FldName);
                strBuilder.Append(" = '{0}'\", ");
                strBuilder.AppendFormat("{0});", clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase));
                strBuilder.Append("\r\nobjSQL.GetFile(strDownLoadFileName,strTabName, strFldName, strCondition.ToString());");
                strBuilder.Append("\r\nreturn true;");
                strBuilder.Append("\r\n}");
            }
            return strBuilder.ToString();
        }

        public virtual string GenStoreFileToTabField()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:�洢�ļ������ļ��洢�����ݿ���ֶ��С�");
            strBuilder.Append("\r\n ///		˵��:���¼����Ϊ��ǰ��������Ӧ�ļ�¼��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strUpLoadFileName\">��Ҫ�洢���ļ���</param>");
            strBuilder.Append("\r\n /// <returns>����ɹ��ͷ���TRUE,���򷵻�FALSE</returns>");
            strBuilder.Append("\r\npublic bool StoreFileToTabField(string strUpLoadFileName)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nstring strTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strFldName = \"{0}\";", objPrjTabENEx.ImageFieldName);
            strBuilder.Append("\r\nStringBuilder strCondition = new StringBuilder();");
            strBuilder.Append("\r\nstrCondition.AppendFormat(\" ");
            strBuilder.AppendFormat("{0}", objKeyField.FldName);
            strBuilder.Append(" = '{0}'\", ");
            strBuilder.AppendFormat("{0});", clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase));
            strBuilder.Append("\r\nSpecData.clsSpecSQLforSql objSQL = new SpecData.clsSpecSQLforSql();");
            strBuilder.Append("\r\nobjSQL.StoreFile(strUpLoadFileName,strTabName, strFldName, strCondition.ToString());");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public virtual string GenShowPic_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ʾͼƬ����ʾ��ؼ�����ؼ�¼��ͼƬ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"imgPic\">��Ҫ��ʾͼƬ��image�ؼ�</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">��¼�ؼ��ֵ�ֵ</param>",
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <param name = \"strWebFileDir\">����WEB��ʾ���ļ�·��,��URL</param>");
            strBuilder.Append("\r\n /// <param name = \"strDownloadFileDir\">���������ļ�ʱ,��WEB���������ļ���Ŀ¼</param>");
            strBuilder.Append("\r\npublic static void ShowPic(System.Web.UI.WebControls.Image imgPic, ");
            strBuilder.AppendFormat("\r\n{0} {1}, ",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\nstring strWebFileDir, ");
            strBuilder.Append("\r\nstring strDownloadFileDir)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nimgPic.ImageUrl = \"\";");
            strBuilder.AppendFormat("\r\nif (cls{0}BL.IsExist({1}) == true)",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\ncls{0}EN obj{0}EN = new cls{0}EN({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
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
        public virtual string GenGetFileFromTabField_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:�����ݿ���ֶ��������ļ����ݡ��ú����Ǿ�̬(static)������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strDownLoadFileName\">�������ص��ļ���</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">��¼�ؼ��ֵ�ֵ</param>",
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <param name = \"strDownloadFileDir\">���������ļ�ʱ,��WEB���������ļ���Ŀ¼</param>");
            strBuilder.Append("\r\npublic static bool GetFileFromTabField(ref string strDownLoadFileName, ");
            strBuilder.AppendFormat("\r\n{0} {1}, ",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\nstring strDownloadFileDir)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nif (cls{0}BL.IsExist({1}) == true)",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\ncls{0}EN obj{0}EN = new cls{0}EN({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
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
        public virtual string GenGetDataTableBySql_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһSQL����DataTable---------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����Sql����ȡDataTable");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strSql\">Sql���</param>");
            strBuilder.Append("\r\n /// <returns>�������ڰ��������DataTable</returns>");
            strBuilder.Append("\r\npublic System.Data.DataTable GetDataTable(string strSql)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSql);");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            ///��ȡĳһSQL����DataTable ==  == ;
            return strBuilder.ToString();
        }
        public virtual string GenIsExist()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�����ݿ����Ƿ���ڵ�ǰ����-----------------------;
            strBuilder.Append("\r\npublic bool IsExist()");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
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
        public virtual string GenIsExistBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�����ݿ����Ƿ���ڵ�ǰ����-----------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �жϵ�ǰ�����Ƿ���ڸ����ؼ���ֵ�ļ�¼, �ô洢��������ȡ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>�����Ƿ����?</returns>");
            strBuilder.AppendFormat("\r\npublic bool IsExistBySP({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n{");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\n ArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.Append("\r\nvalues.Add(" + objField.ObjFieldTabENEx.PrivFuncName + ");");
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
        public virtual string GenIsExist_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�����ݿ����Ƿ���ڵ�ǰ����(������̺���)-----------------------;
            ///objField.ObjFieldTabENEx.PrivFuncName;
            int i = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {

                if (i == 0)	//�Ƿ��ǵ�һ��
                {
                    strTemp = objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else
                {
                    strTemp += ", " + objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                i++;
            }
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �жϵ�ǰ�����Ƿ���ڸ����ؼ���ֵ�ļ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>�����Ƿ����?</returns>");

            strBuilder.Append("\r\npublic bool IsExist(" + strTemp + ")");
            strBuilder.Append("\r\n{");
            if (objPrjTabENEx.arrKeyFldSet.Count == 1)
            {
                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                {
                    strBuilder.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
                }
            }
            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
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
        public virtual string GenIsExistCondRec_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:�ж��Ƿ����ĳһ�����ļ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>������ھͷ���TRUE,���򷵻�FALSE</returns>");
            strBuilder.Append("\r\npublic bool IsExistCondRec(string strCondition)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strBuilder.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("IsExistCondRec", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}:IsExistCondRec)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strBuilder.Append("\r\n}");


            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
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
        public string GenCheckPropertyBak()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");

            strBuilder.Append("\r\npublic bool CheckProperty(ref string strResult)");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
                if (objField.IsTabNullable == false && objField.ObjFieldTabENEx.IsIdentity == false)
                {
                    strBuilder.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        strPrivPropNameWithObjectName4Get);
                    strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"\")",
                        strPrivPropNameWithObjectName4Get);
                    if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                    {
                        strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"0\")",
                            strPrivPropNameWithObjectName4Get);
                    }
                    strBuilder.Append(")");
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nstrResult = \"�ֶ�[" + objField.ColCaption + "]����Ϊ��(NULL)!\";");
                    strBuilder.Append("\r\nreturn false;");
                    strBuilder.Append("\r\n}");
                }
            }
            ///������Գ��ȴ���;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strBuilder.AppendFormat("\r\nif (!Object.Equals(null, {0}) && GetStrLen({0}) > {1})",
                        strPrivPropNameWithObjectName4Get,
                         objField.ObjFieldTabENEx.FldLength);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nstrResult = \"�ֶ�[" + objField.ColCaption + "]�ĳ��Ȳ��ܳ���" + objField.ObjFieldTabENEx.FldLength.ToString().Trim() + "!\";");
                    strBuilder.Append("\r\nreturn false;");
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///������������Ƿ���ȷ ==  ==  == = ;
            return strBuilder.ToString();
        }


        public string GenCheckUniqueness()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�������ĳ����(������)�Ƿ�Ψһ-------------------------------------------;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                if (objField.IsTabUnique == true && objField.FieldTypeId != enumFieldType.KeyField_02)
                {

                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// ���Ψһ��(Uniqueness)--{0}({1}), �����Ψһ,��������ͬ�ļ�¼,�ͷ���False",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldName);
                    
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(����)</param>",
                    objKeyField.PrivFuncName,
                    objKeyField.ColCaption);
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(Ҫ��Ψһ���ֶ�)</param>",
                    objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
                    strBuilder.Append("\r\n /// <returns></returns>");
                    strBuilder.AppendFormat("\r\npublic bool Check{0}Uniqueness({1} {2}, {3} {4})",
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                    strBuilder.Append("\r\nsbCondition.AppendFormat(\"" + objKeyField.FldName + " !=  '{0}' and "
                 + objField.ObjFieldTabENEx.FldName + " = '{1}'\", " + objKeyField.PrivFuncName + ", " + objField.ObjFieldTabENEx.PrivFuncName + ");");
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
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == true && objField.FieldTypeId != enumFieldType.KeyField_02)
                {

                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// ���Ψһ��(Uniqueness)--{0}({1}), �����Ψһ,��������ͬ�ļ�¼,�ͷ���False",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldName);
                    
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(����)</param>",
                    objKeyField.PrivFuncName,
                    objKeyField.ColCaption);
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(Ҫ��Ψһ���ֶ�)</param>",
                    objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
                    strBuilder.Append("\r\n /// <returns></returns>");
                    strBuilder.AppendFormat("\r\npublic bool Check{0}Uniqueness({1} {2}, {3} {4})",
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                    if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strBuilder.Append("\r\nsbCondition.AppendFormat(\"" + objKeyField.FldName + " !=  '{0}' and "
                     + objField.ObjFieldTabENEx.FldName + " = '{1}'\", " + objKeyField.PrivFuncName + ", " + objField.ObjFieldTabENEx.PrivFuncName + ");");
                    }
                    else
                    {
                        strBuilder.Append("\r\nsbCondition.AppendFormat(\"" + objKeyField.FldName + " !=  {0} and "
                      + objField.ObjFieldTabENEx.FldName + " = '{1}'\", " + objKeyField.PrivFuncName + ", " + objField.ObjFieldTabENEx.PrivFuncName + ");");

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
                    objField.ColCaption, objField.ObjFieldTabENEx.FldName);
                    
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(Ҫ��Ψһ���ֶ�)</param>",
                    objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
                    strBuilder.Append("\r\n /// <returns></returns>");
                    strBuilder.AppendFormat("\r\npublic bool Check{0}Uniqueness({3} {4})",
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                    strBuilder.Append("\r\nsbCondition.AppendFormat(\"" + objField.ObjFieldTabENEx.FldName + " = '{0}'\", " + objField.ObjFieldTabENEx.PrivFuncName + ");");
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

        public string GenCheckUniquenessV3()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���Ψһ��(Uniqueness)--{0}({1}), �����Ψһ,��������ͬ�ļ�¼,�ͷ���False",
                          objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(����)</param>",
            objKeyField.PrivFuncName,
            objKeyField.ColCaption);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(Ҫ��Ψһ���ֶ�)</param>",
                        objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
            }

            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\npublic bool Check{0}Uniqueness({1} {2} ",
                objPrjTabENEx.TabName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                strBuilder.AppendFormat(", {0} {1}",
                      objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                      objField.ObjFieldTabENEx.PrivFuncName);
            }
            strBuilder.Append(")");

            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
            {
                strBuilder.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  {{0}}\", {1});",
                   objKeyField.FldName,
                   objKeyField.PrivFuncName,
                   "{", "}");
            }
            else
            {
                strBuilder.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  '{{0}}'\", {1});",
                   objKeyField.FldName,
                   objKeyField.PrivFuncName,
                   "{", "}");
            }
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                strBuilder.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", {1});",
                            objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.PrivFuncName,
                            "{", "}");
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

            //StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���Ψһ��(Uniqueness)--{0}({1}), �����Ψһ,��������ͬ�ļ�¼,�ͷ���False",
                          objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            //strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(����)</param>",
            //objKeyField.PrivFuncName,
            //objKeyField.ColCaption);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(Ҫ��Ψһ���ֶ�)</param>",
                        objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
            }

            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\npublic bool Check{0}Uniqueness(",
                objPrjTabENEx.TabName,
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName);
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                if (bolIsFirst == true)
                {
                    strBuilder.AppendFormat("{0} {1}",
                          objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                          objField.ObjFieldTabENEx.PrivFuncName);
                    bolIsFirst = false;

                }
                else
                {
                    strBuilder.AppendFormat(", {0} {1}",
                       objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                       objField.ObjFieldTabENEx.PrivFuncName);
                }
            }
            strBuilder.Append(")");

            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
            strBuilder.AppendFormat("\r\nsbCondition.AppendFormat(\"1 = 1\");",
               objKeyField.FldName,
               objKeyField.PrivFuncName,
               "{", "}");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                strBuilder.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", {1});",
                            objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.PrivFuncName,
                            "{", "}");
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


            ///�������ĳ����(������)�Ƿ�Ψһ ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// ��ȡΨһ��������
        /// </summary>
        /// <returns></returns>
        public string GetUniquenessConditionString()
        {
            StringBuilder strBuilder = new StringBuilder();
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = string.Format($"_V{intVerCount}"); intVerCount++;
                
                IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId);

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// ��ȡΨһ��������(Uniqueness)--{0}({1})",
                              objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(����)</param>",
                objKeyField.PrivFuncName,
                objKeyField.ColCaption);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(Ҫ��Ψһ���ֶ�)</param>",
                            objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
                }

                strBuilder.Append("\r\n /// <returns></returns>");
                strBuilder.AppendFormat("\r\npublic string GetUniCondStr({1} {2} ",
                    objPrjTabENEx.TabName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objKeyField.PrivFuncName, objInFor.ConstraintName4GC());
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                    strBuilder.AppendFormat(", {0} {1}",
                          objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                          objField.ObjFieldTabENEx.PrivFuncName);
                }
                strBuilder.Append(")");

                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                strBuilder.AppendFormat("\r\nsbCondition.AppendFormat(\"1 = 1\");",
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                "{", "}");
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                    strBuilder.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", {1});",
                                objField.ObjFieldTabENEx.FldName,
                                objField.ObjFieldTabENEx.PrivFuncName,
                                "{", "}");
                }

                strBuilder.Append("\r\nreturn sbCondition.ToString();");
                strBuilder.Append("\r\n}");
            }
            ///�������ĳ����(������)�Ƿ�Ψһ ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == ;
            return strBuilder.ToString();
        }


        public string GenCheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic void CheckPropertyNew(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("CheckPropertyNew[{2}]", 
                objPrjTabENEx.TabName, objKeyField.FldName, this.strDataBaseType);
            string strExplanation = "�ֶ�[{1}|{0}]����Ϊ��(NULL)!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.AppendFormat("\r\n" + "//����ֶβ���Ϊ��(NULL)");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.IsTabNullable == false && objField.FieldTypeId != "02")
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        continue;
                    }

                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, cls{2}EN.con_{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);
                        //strBuilder.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        //    strPrivPropNameWithObjectName4Get);
                        //strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"\")",
                        //    strPrivPropNameWithObjectName4Get );
                        //if (string.IsNullOrEmpty(objField.ObjFieldTabENEx.CodeTabId) != true)
                        //{
                        //    strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"0\")",
                        //         strPrivPropNameWithObjectName4Get );
                        //}
                        //strBuilder.Append(")");
                        //strBuilder.Append("\r\n{");
                        //strBuilder.AppendFormat("\r\n throw new clsDbObjException(\"(errid:{2})�ֶ�[{1}|{0}]����Ϊ��(NULL)!(cls{3}DA:CheckPropertyNew)\");",
                        //        objField.ColCaption,
                        //        objPrjTabENEx.TabCnName,
                        //        strErrId,
                        //        objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n}");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, cls{2}EN.con_{3});",
                  strPrivPropNameWithObjectName,
                  objField.ObjFieldTabENEx.FldLength,
                  objPrjTabENEx.TabName,
                  objField.ObjFieldTabENEx.FldName);
                        //strBuilder.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        //    strPrivPropNameWithObjectName );
                        //strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"\")",
                        //     strPrivPropNameWithObjectName );
                        //if (string.IsNullOrEmpty(objField.ObjFieldTabENEx.CodeTabId) != true)
                        //{
                        //    strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"0\")",
                        //         strPrivPropNameWithObjectName );
                        //}
                        //strBuilder.Append(")");
                        //strBuilder.Append("\r\n{");
                        //strBuilder.AppendFormat("\r\n throw new clsDbObjException(\"(errid:{2})�ֶ�[{1}|{0}]����Ϊ��(NULL)!(cls{3}DA:CheckPropertyNew)\");",
                        //            objField.ColCaption,
                        //            objPrjTabENEx.TabCnName,
                        //            strErrId,
                        //            objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n}");
                    }
                }


            }
            //������Գ��ȴ���;

            strFunctionName = string.Format("CheckPropertyNew0", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:{{0}}";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.AppendFormat("\r\n" + "//����ֶγ���");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, cls{2}EN.con_{3});",
                 strPrivPropNameWithObjectName,
                 objField.ObjFieldTabENEx.FldLength,
                 objPrjTabENEx.TabName,
                 objField.ObjFieldTabENEx.FldName);
                       
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, cls{2}EN.con_{3});",
                             strPrivPropNameWithObjectName,
                            objField.ObjFieldTabENEx.FldLength,
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName);
                        
                    }
                }
            }

            //�������ֶγ���;

            strFunctionName = string.Format("CheckPropertyNew", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "�ֶ�[{2}|{0}]��Ϊ����ֶ�,����Ӧ��Ϊ{1}!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.AppendFormat("\r\n" + "//����ֶ�����̶�����");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.IsTabForeignKey == false) continue;//����������,�Ͳ���Ҫ���
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" 
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, cls{2}EN.con_{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);
                        
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, cls{2}EN.con_{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);
                       
                    }
                }
            }
           
            strBuilder.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");

            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// רҵ����޸ļ�¼,�������ֶ�ֵ�Ƿ�Ϸ�,1)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic void CheckProperty4Update(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            //������Գ��ȴ���;
            strFunctionName = string.Format("CheckProperty4Update", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:{{0}}";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.AppendFormat("\r\n" + "//����ֶγ���");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FieldTypeId == enumFieldType.KeyField_02) continue;
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, cls{2}EN.con_{3});",
                         strPrivPropNameWithObjectName,
                        objField.ObjFieldTabENEx.FldLength,
                      objPrjTabENEx.TabName,
                      objField.ObjFieldTabENEx.FldName);
                       

                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, cls{2}EN.con_{3});",
                         strPrivPropNameWithObjectName,
                        objField.ObjFieldTabENEx.FldLength,
                      objPrjTabENEx.TabName,
                      objField.ObjFieldTabENEx.FldName);
                       
                    }
                }
            }
            ///�������ֶγ���;
            strFunctionName = string.Format("CheckProperty4Update", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "�ֶ�[{2}|{0}]��Ϊ����ֶ�,����Ӧ��Ϊ{1}!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.AppendFormat("\r\n" + "//�������ֶγ���");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.IsTabForeignKey == false) continue;//����������,�Ͳ���Ҫ���
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" 
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, cls{2}EN.con_{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);
                        
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, cls{2}EN.con_{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);
                       
                    }
                }
            }
            //strBuilder.AppendFormat("\r\n" + "//���Sqlע��");
            //foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            //{
            //    string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

            //    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
            //        && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
            //        && objField.ObjFieldTabENEx.FldLength > 0)
            //    {

            //        //  strBuilder.AppendFormat("\r\n" + "//���Sqlע��");
            //        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckSqlInjection4Field({0}, cls{1}EN.con_{2});",
            //          strPrivPropNameWithObjectName,
            //          objPrjTabENEx.TabName,
            //          objField.ObjFieldTabENEx.FldName);                    
            //    }
            //}
            strBuilder.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");

            ///������������Ƿ���ȷ ==  ==  == = ;
            return strBuilder.ToString();
        }


        public string GenCheckProperty4Condition()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic void CheckProperty4Condition(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            //FldOpTypeId:
            //0000	δ֪	
            //0001	�ɶ�д	
            //0002	ֻ��	
            //0003	ֻд	
            //0004	���ɶ�д	

            //FieldTypeId:
            //01	һ���ֶ�	NULL
            //02	�ؼ��ֶ�	NULL
            //03	�����ֶ�	NULL
            //04	�����ֶ�	NULL

            ///������Գ��ȴ���;
            string strFunctionName = string.Format("CheckProperty4Condition", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:{{0}}";
            string strErrId1 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strExplanation = "�ֶ�[{2}({3})|{0}({4})]�Ĳ��ܰ����� = ��!ֵ:{{0}}";
            string strErrId2 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strExplanation = "�ֶ�[{2}({3})|{0}({4})]�Ĳ��ܰ����� and��!ֵ:{{0}}";
            string strErrId3 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strExplanation = "�ֶ�[{2}({3})|{0}({4})]�Ĳ��ܰ�����and ��!ֵ:{{0}}";
            string strErrId4 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.AppendFormat("\r\n" + "//����ֶγ���");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {
                  
                    strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, cls{2}EN.con_{3});",
                        strPrivPropNameWithObjectName,
                        objField.ObjFieldTabENEx.FldLength,
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);               
                }
            }
            strBuilder.AppendFormat("\r\n" + "//���Sqlע��");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {
                  
                  //  strBuilder.AppendFormat("\r\n" + "//���Sqlע��");
                    strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckSqlInjection4Field({0}, cls{1}EN.con_{2});",
                      strPrivPropNameWithObjectName,
                      objPrjTabENEx.TabName,
                      objField.ObjFieldTabENEx.FldName);
                  

                }
            }
            strBuilder.AppendFormat("\r\n" + "//�������ֶγ���");

            ///�������ֶγ���;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabForeignKey == false) continue;//����������,�Ͳ���Ҫ���
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" 
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, cls{2}EN.con_{3});",
                     strPrivPropNameWithObjectName,
                     objField.ObjFieldTabENEx.FldLength,
                     objPrjTabENEx.TabName,
                     objField.ObjFieldTabENEx.FldName);


                }
            }
            strBuilder.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");


            ///������������Ƿ���ȷ ==  ==  == = ;
            return strBuilder.ToString();
        }

       

        public virtual string GenCurrTabName_S()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ǰ����");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n public override string _CurrTabName");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n get");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n return cls{0}EN._CurrTabName;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }

        public virtual string GenGetID()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ���������������м�¼�Ĺؼ���ֵ�б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĹؼ���ֵ�б�</returns>");

            strBuilder.Append("\r\npublic List<string> GetID(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\n System.Data.DataTable objDT ;");
            strBuilder.Append("\r\nList<string> arrList = new List<string>();");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
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
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            ///			
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            
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
            
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }


        public string GenGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����ǰ׺��ȡ��ǰ������ַ��͹ؼ���ID");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>���ص����ؼ���ֵID</returns>");
            strBuilder.Append("\r\npublic string GetMaxStrIdByPrefix(string strPrefix)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n//��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\nobjSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strMaxValue = objSQL.GetMaxStrId(cls{0}EN._CurrTabName, cls{0}EN.con_{1}, {2}, strPrefix);",
            objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.ObjFieldTabENEx.FldLength);
            strBuilder.Append("\r\nreturn strMaxValue;");
            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }
        public virtual string GenGetMaxStrID()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ������ַ��͹ؼ���ID");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>���ص����ؼ���ֵID</returns>");
            strBuilder.Append("\r\npublic static string GetMaxStrId()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n//��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\nobjSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strMaxValue = objSQL.GetMaxStrId(cls{0}EN._CurrTabName, cls{0}EN.con_{1}, {2}, \"\");",
            objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.ObjFieldTabENEx.FldLength);
            strBuilder.Append("\r\nreturn strMaxValue;");
            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

        public virtual string GenIsExistTable()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����Ƿ���ڵ�ǰ��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>���ھͷ���True,���򷵻�False</returns>");
            strBuilder.Append("\r\npublic static bool IsExistTable()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n//��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\nobjSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nbool bolIsExist = objSQL.IsExistTable(\"{0}\");",
                                        objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn bolIsExist;");
            strBuilder.Append("\r\n}");

            //strBuilder.Append("\r\n /// <summary>");
            //strBuilder.Append("\r\n /// ����Ƿ���ڸ�����");
            //strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strBuilder.Append("\r\n /// </summary>");
            //strBuilder.Append("\r\n /// <param name = \"strTabName\">������</param>");
            //strBuilder.Append("\r\n /// <returns>���ھͷ���True,���򷵻�FalseD</returns>");
            //strBuilder.Append("\r\npublic static bool IsExistTable(string strTabName)");
            //strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\nclsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n//��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\nobjSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\nbool bolIsExist = objSQL.IsExistTable(strTabName);",
            //                            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nreturn bolIsExist;");
            //strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public virtual string GenGetFirstID()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");

            strBuilder.AppendFormat("\r\npublic {0} GetFirstID(string strCondition) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\n System.Data.DataTable objDT ;");
            strBuilder.Append("\r\n List<string> arrList = new List<string>();");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
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
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            ///			
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\nreturn \"\";");
            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long" || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
            {
                strBuilder.Append("\r\nreturn 0;");
            }
            else
            {
                strBuilder.AppendFormat("\r\nreturn " + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";",
                objPrjTabENEx.TabName);
            }
            //strBuilder.Append("\r\nreturn " + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";");

            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nstrKeyValue = objDT.Rows[0][0].ToString();");
            
            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
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
        public virtual string GenGetFirstID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");

            strBuilder.AppendFormat("\r\npublic {0} GetFirstID_S(string strCondition) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\n System.Data.DataTable objDT ;");
            strBuilder.Append("\r\n List<string> arrList = new List<string>();");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
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
            ///			
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strBuilder.Append("\r\n{");
            
            //if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType  ==  "string")
            //{
            // strBuilder.Append("\r\nreturn " + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";");
            //}
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\nreturn \"\";");
            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long" || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
            {
                strBuilder.Append("\r\nreturn 0;");
            }
            else
            {
                strBuilder.AppendFormat("\r\nreturn new cls{0}DA()." + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";",
                objPrjTabENEx.TabName);
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nstrKeyValue = objDT.Rows[0][0].ToString();");
            
            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
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


        public virtual string GenGetReader()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic System.Data.SqlClient.SqlDataReader GetReader(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataReader objDR ;");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + string.Format("strSQL = \"Select * from {0} where \" + strCondition;", objPrjTabENEx.TabName));
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDR = objSQL.GetSqlDataReader(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            /// strBuilder.Append("\r\nobjDR = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objDR;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public virtual string GenGetTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///GetTable(����������ȡ���ݱ�);
            strBuilder.Append("\r\npublic DataTable GetTable(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ;");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            /// 
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objDT;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public virtual string GenGetTableBySQL()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///GetTableBySQL(����SQL����ȡ���ݱ�)----------------------------------;
            strBuilder.Append("\r\npublic DataTable GetTableBySQL(string strSQL) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT ;");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            strBuilder.Append("\r\n //��ȡ���Ӷ���");
            strBuilder.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
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
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��Null����ת����String��,��������Ķ�����Null,��ֱ�ӷ��ء�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj\">�����Ķ���</param>");
            strBuilder.Append("\r\n /// <returns>����String������</returns>");
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
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��Null����ת����Int��,��������Ķ�����Null,��ֱ�ӷ��ء�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj\">�����Ķ���</param>");
            strBuilder.Append("\r\n /// <returns>����Int������</returns>");
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
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��Null����ת����Long��,��������Ķ�����Null,��ֱ�ӷ��ء�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj\">�����Ķ���</param>");
            strBuilder.Append("\r\n /// <returns>����Long������</returns>");
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
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��Null����ת����short��,��������Ķ�����Null,��ֱ�ӷ��ء�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj\">�����Ķ���</param>");
            strBuilder.Append("\r\n /// <returns>����short������</returns>");
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
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��Null����ת����DateTime��,��������Ķ�����Null,��ֱ�ӷ��ء�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj\">�����Ķ���</param>");
            strBuilder.Append("\r\n /// <returns>����DateTime������</returns>");
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
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��Null����ת����Float��,��������Ķ�����Null,��ֱ�ӷ��ء�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj\">�����Ķ���</param>");
            strBuilder.Append("\r\n /// <returns>����Float������</returns>");
            strBuilder.Append("\r\nprotected float TransNullToFloat(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n float f1 = 0.0f;");
            strBuilder.Append("\r\n if (obj  ==  null) return f1;");
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
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��Null����ת����Double��,��������Ķ�����Null,��ֱ�ӷ��ء�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj\">�����Ķ���</param>");
            strBuilder.Append("\r\n /// <returns>����Double������</returns>");
            strBuilder.Append("\r\nprotected double TransNullToDouble(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n double d1 = 0.0;");
            strBuilder.Append("\r\n if (obj  ==  null) return d1;");
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
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��Null����ת���ɲ�����,��������Ķ�����Null,��ֱ�ӷ��ء�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj\">�����Ķ���</param>");
            strBuilder.Append("\r\n /// <returns>���ز���������</returns>");
            strBuilder.Append("\r\nprotected bool TransNullToBool(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n if (obj  ==  null) return false;");
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
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ�ַ�������,���к���Ϊ2���ֽ�,Ӣ��Ϊ1���ֽ�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strTemp\">������ԭ�ַ���</param>");
            strBuilder.Append("\r\n /// <returns>�����ַ�������</returns>");
            strBuilder.Append("\r\npublic static int GetStrLen(string strTemp)");
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
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �Ѹ������쳣����洢����־��ȥ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"objException\">�������쳣����</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\nprotected void LogError" + "(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n //Log the error information to the Application Log");
            strBuilder.Append("\r\n string strLogMsg ;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n strLogMsg = \"An error occurred in the following module: \"");
            strBuilder.Append("\r\n+ mstrModuleName + \"Source: \" + objException.Source \r\n");
            strBuilder.Append("\r\n+ \"Message: \" + objException.Message ");
            strBuilder.Append("\r\n+ \"Stack Trace: \" + objException.StackTrace \r\n");
            strBuilder.Append("\r\n+ \"Target Site: \" + objException.TargetSite.ToString();");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n //Write error to event log");
            strBuilder.Append("\r\nSystem.Diagnostics.EventLog.WriteEntry(mstrModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);");
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
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �Ѹ������쳣����洢����־��ȥ(��ģ����)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"objException\">�������쳣����</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <param name = \"strModuleName\">ģ������</param>", objKeyField.PrivFuncName);
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
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n" + "public void ClearUpdateState()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "htProperty.Clear();");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public virtual string GenComboBoxBindFunction5()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";

            try
            {
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.Append("\r\n /// ��ȡ���ڰ��������DataTable,��ȡ�����ֶ�:1���ؼ��֣�2�������ֶ�");
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.Append("\r\n /// <returns>�������ڰ��������DataTable</returns>");
                    strBuilder.AppendFormat("\r\n" + "public static System.Data.DataTable Get{0}()",
                    strValueFieldName);
                    strBuilder.Append("\r\n" + "{");
                    //strBuilder.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
                    strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
                    strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						if (objField.DsCondStr.Trim()  ==  "")
                    //						{
                    //							strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						}
                    //						else
                    //						{
                    //							strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objField.DsCondStr);
                    //						}

                    strBuilder.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

                    strBuilder.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    strBuilder.Append("\r\n" + "return objDT;");
                    strBuilder.Append("\r\n" + "}");

                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.Append("\r\n /// �󶨻���Win��������");
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.Append("\r\n /// <param name = \"objComboBox\">��Ҫ�󶨵�ǰ���������</param>");
                    strBuilder.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
                    strValueFieldName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.Append("\r\n" + "//Ϊ����ԴΪ�����������������");
                    strBuilder.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                    strValueFieldName);


                    strBuilder.AppendFormat("\r\n" + "cls{0} obj{0};",
                    objPrjTabENEx.TabName);
                    strBuilder.AppendFormat("\r\n" + "//��ʼ��һ�������б�");
                    strBuilder.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                    objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "//�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�");
                    strBuilder.AppendFormat("\r\n" + "obj{0} = new cls{0}();",
                    objPrjTabENEx.TabName);
                    strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = \"0\";",
                    objPrjTabENEx.TabName, strValueFieldName);
                 
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"ѡ[{2}]...\";",
              objPrjTabENEx.TabName, strTextFieldName, objPrjTabENEx.TabCnName);

                    strBuilder.AppendFormat("\r\n" + "{0}List.Add(obj{0});",
                    objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "//��DataTable�е���������ӵ������б���");
                    strBuilder.Append("\r\n" + "foreach(DataRow objRow in objDT.Rows)");
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "obj{0} = new cls{0}();",
                    objPrjTabENEx.TabName);
                    strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = objRow[cls{0}EN.con_{1}].ToString();",
                    objPrjTabENEx.TabName, strValueFieldName);
                    strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = objRow[cls{0}EN.con_{1}].ToString();",
                    objPrjTabENEx.TabName, strTextFieldName);
                    strBuilder.AppendFormat("\r\n" + "{0}List.Add(obj{0});",
                    objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "}");
                    strBuilder.Append("\r\n" + "//���������������Դ���Լ�����ֵ���ʾ��");

                    strBuilder.AppendFormat("\r\n" + "objComboBox.ValueMember = cls{0}EN.con_{1};",
                    objPrjTabENEx.TabName, strValueFieldName);
                    strBuilder.AppendFormat("\r\n" + "objComboBox.DisplayMember = cls{0}EN.con_{1};",
                    objPrjTabENEx.TabName, strTextFieldName);
                    strBuilder.AppendFormat("\r\n" + "objComboBox.DataSource = {0}List;",
                  objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
                    strBuilder.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }

        public virtual string GenComboBoxBindFunction()
        {
            return "";
            //StringBuilder strBuilder = new StringBuilder();
            //string strTextFieldName = "";
            //string strValueFieldName = "";

            //try
            //{
            //    //��0��:�ѿؼ���������ComboBoxת����ComboBox
            //    foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            //    {
            //        if (objField.FieldTypeId == "02")
            //        {
            //            strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
            //        }
            //        if (objField.FieldTypeId == "03")
            //        {
            //            strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
            //        }
            //    }
            //    if (strValueFieldName != "" && strTextFieldName != "")
            //    {
            //        strBuilder.Append("\r\n /// <summary>");
            //        strBuilder.Append("\r\n /// ��ȡ���ڰ��������DataTable,��ȡ�����ֶ�:1���ؼ��֣�2�������ֶ�");
            //        strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //        strBuilder.Append("\r\n /// </summary>");
            //        strBuilder.Append("\r\n /// <returns>�������ڰ��������DataTable</returns>");
            //        strBuilder.AppendFormat("\r\n" + "public static System.Data.DataTable Get{0}()",
            //        strValueFieldName);
            //        strBuilder.Append("\r\n" + "{");
            //        strBuilder.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
            //        strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
            //        strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
            //        //						if (objField.DsCondStr.Trim()  ==  "")
            //        //						{
            //        //							strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
            //        //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
            //        //						}
            //        //						else
            //        //						{
            //        //							strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
            //        //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objField.DsCondStr);
            //        //						}

            //        strBuilder.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //        strBuilder.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
            //        strBuilder.Append("\r\n" + "return objDT;");
            //        strBuilder.Append("\r\n" + "}");
            //        strBuilder.Append("\r\n /// <summary>");
            //        strBuilder.Append("\r\n /// �󶨻���Win��������");
            //        strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //        strBuilder.Append("\r\n /// </summary>");
            //        strBuilder.Append("\r\n /// <param name = \"objComboBox\">��Ҫ�󶨵�ǰ���������</param>");
            //        strBuilder.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
            //        strValueFieldName);
            //        strBuilder.Append("\r\n" + "{");
            //        strBuilder.Append("\r\n" + "//Ϊ����ԴΪ�����������������");
            //        strBuilder.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
            //        strValueFieldName);


            //        strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
            //        objPrjTabENEx.TabName);
            //        strBuilder.AppendFormat("\r\n" + "//��ʼ��һ�������б�");
            //        strBuilder.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
            //        objPrjTabENEx.TabName);
            //        strBuilder.Append("\r\n" + "//�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�");
            //        strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
            //        objPrjTabENEx.TabName);
            //        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"0\";",
            //        objPrjTabENEx.TabName, strValueFieldName);
            //        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"��ѡ��1...\";",
            //        objPrjTabENEx.TabName, strTextFieldName);
            //        strBuilder.AppendFormat("\r\n" + "{0}List.Add(obj{0}EN);",
            //        objPrjTabENEx.TabName);
            //        strBuilder.Append("\r\n" + "//��DataTable�е���������ӵ������б���");
            //        strBuilder.Append("\r\n" + "foreach(DataRow objRow in objDT.Rows)");
            //        strBuilder.Append("\r\n" + "{");
            //        strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
            //        objPrjTabENEx.TabName);
            //        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[cls{0}EN.con_{1}].ToString();",
            //        objPrjTabENEx.TabName, strValueFieldName);
            //        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[cls{0}EN.con_{1}].ToString();",
            //        objPrjTabENEx.TabName, strTextFieldName);
            //        strBuilder.AppendFormat("\r\n" + "{0}List.Add(obj{0}EN);",
            //        objPrjTabENEx.TabName);
            //        strBuilder.Append("\r\n" + "}");
            //        strBuilder.Append("\r\n" + "//���������������Դ���Լ�����ֵ���ʾ��");

            //        strBuilder.AppendFormat("\r\n" + "objComboBox.ValueMember = cls{0}EN.con_{1};",
            //        objPrjTabENEx.TabName, strValueFieldName);
            //        strBuilder.AppendFormat("\r\n" + "objComboBox.DisplayMember = cls{0}EN.con_{1};",
            //       objPrjTabENEx.TabName, strTextFieldName);
            //        strBuilder.AppendFormat("\r\n" + "objComboBox.DataSource = {0}List;",
            //      objPrjTabENEx.TabName);
            //        strBuilder.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
            //        strBuilder.Append("\r\n" + "}");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    clsEntityBase.LogErrorS(ex, "");
            //    throw new Exception(ex.Message, ex);
            //}
            //return strBuilder.ToString();
        }


        public string GenDdlBindFunction()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            try
            {
                ///���ɽ��б���;
                //��������ĺ��� ����;
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    //					
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.Append("\r\n /// �󶨻���Web��������");
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.Append("\r\n /// <param name = \"objDDL\">��Ҫ�󶨵�ǰ���������</param>");
                    strBuilder.AppendFormat("\r\n" + "public static void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                    strValueFieldName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");
                    
                    strBuilder.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"ѡ[{0}]...\",\"0\");",
                                      objPrjTabENEx.TabCnName);

                    strBuilder.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                    strValueFieldName);
                    strBuilder.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};",
                        objPrjTabENEx.TabName, strValueFieldName);
                    strBuilder.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};",
                        objPrjTabENEx.TabName, strTextFieldName);
                    strBuilder.Append("\r\n" + "objDDL.DataSource = objDT;");
                    strBuilder.Append("\r\n" + "objDDL.DataBind();");
                    strBuilder.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strBuilder.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strBuilder.Append("\r\n" + "}");
                }
            }

            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }
        /// <summary>
        /// �ѱ������ݰ󶨵�ListView��
        /// </summary>
        /// <returns></returns>
        public string GenBindListView()
        {
            StringBuilder strBuilder = new StringBuilder();
            try
            {
                //strBuilder.Append("\r\n /1//���ɰ�ListView�Ĵ���");
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,");
                strBuilder.Append("\r\n ///			 ����ʾ��ListView�С�");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public int BindLv_{0}(System.Windows.Forms.ListView lv{0}, string strWhereCond)",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "//��������:(��4��)");
                strBuilder.Append("\r\n" + "//	1����Ͻ�����������");
                strBuilder.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strBuilder.Append("\r\n" + "//	3������ListView����ͷ��Ϣ");
                strBuilder.Append("\r\n" + "//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��");
                strBuilder.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�");
                strBuilder.Append("\r\n" + "");
                strBuilder.AppendFormat("\r\n" + "System.Windows.Forms.ListViewItem lvi{0}; ",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "ArrayList arr{0}ObjLst;",
                objPrjTabENEx.TabName);

                strBuilder.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = new cls{0}BL.GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "//	3������ListView����ͷ��Ϣ");
                strBuilder.AppendFormat("\r\n" + "lv{0}.Items.Clear();//���ԭ������Item",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "lv{0}.Columns.Clear();//���ԭ��������ͷ��Ϣ",
                objPrjTabENEx.TabName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId != "04" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")	//���ǹ����ֶ�
                    {
                        strBuilder.AppendFormat("\r\n" + "lv{0}.Columns.Add(\"{1}\", 100, System.Windows.Forms.HorizontalAlignment.Left);",
                        objPrjTabENEx.TabName, objField.ColCaption);
                    }
                }
                strBuilder.AppendFormat("\r\n" + "lv{0}.View = System.Windows.Forms.View.Details;",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��");
                strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLst)",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "lvi{0} = new System.Windows.Forms.ListViewItem();",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "lvi{0}.Tag = obj{0}EN.{1};",
                objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "lvi{0}.Text = obj{0}EN.{1}.ToString();",
                objPrjTabENEx.TabName, objKeyField.FldName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objKeyField.FldId == objField.FldId)
                    {
                        continue;
                    }
                    if (objField.FieldTypeId != "04"
                    && objField.IsTabForeignKey == false
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")
                    {
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                        {
                            strBuilder.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1});",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1}.ToString());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        }
                    }
                }
                strBuilder.AppendFormat("\r\n" + "lv{0}.Items.Add(lvi{0});",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "//	4�����ü�¼����״̬,");
                strBuilder.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�");
                strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst.Count;",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }


        /// <summary>
        /// �ѱ������ݰ󶨵�ListView��
        /// </summary>
        /// <returns></returns>
        public string GenBindListView5()
        {
            StringBuilder strBuilder = new StringBuilder();
            try
            {
                //strBuilder.Append("\r\n //1/���ɰ�ListView�Ĵ���");
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,");
                strBuilder.Append("\r\n ///			 ����ʾ��ListView�С�");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public int BindLv_{0}(System.Windows.Forms.ListView lv{0}, string strWhereCond)",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "//��������:(��4��)");
                strBuilder.Append("\r\n" + "//	1����Ͻ�����������");
                strBuilder.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strBuilder.Append("\r\n" + "//	3������ListView����ͷ��Ϣ");
                strBuilder.Append("\r\n" + "//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��");
                strBuilder.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�");
                strBuilder.Append("\r\n" + "");
                strBuilder.AppendFormat("\r\n" + "System.Windows.Forms.ListViewItem lvi{0}; ",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "ArrayList arr{0}ObjLst;",
                objPrjTabENEx.TabName);

                strBuilder.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = new cls{0}().GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "//	3������ListView����ͷ��Ϣ");
                strBuilder.AppendFormat("\r\n" + "lv{0}.Items.Clear();//���ԭ������Item",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "lv{0}.Columns.Clear();//���ԭ��������ͷ��Ϣ",
                objPrjTabENEx.TabName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId != "04" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")	//���ǹ����ֶ�
                    {
                        strBuilder.AppendFormat("\r\n" + "lv{0}.Columns.Add(\"{1}\", 100, System.Windows.Forms.HorizontalAlignment.Left);",
                        objPrjTabENEx.TabName, objField.ColCaption);
                    }
                }
                strBuilder.AppendFormat("\r\n" + "lv{0}.View = System.Windows.Forms.View.Details;",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��");
                strBuilder.AppendFormat("\r\n" + "foreach (cls{0} obj{0} in arr{0}ObjLst)",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "lvi{0} = new System.Windows.Forms.ListViewItem();",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "lvi{0}.Tag = obj{0}.{1};",
                objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "lvi{0}.Text = obj{0}.{1}.ToString();",
                objPrjTabENEx.TabName, objKeyField.FldName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objKeyField.FldId == objField.FldId)
                    {
                        continue;
                    }
                    if (objField.FieldTypeId != "04"
                    && objField.IsTabForeignKey == false
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")
                    {
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                        {
                            strBuilder.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}.{1});",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}.{1}.ToString());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        }
                    }
                }
                strBuilder.AppendFormat("\r\n" + "lv{0}.Items.Add(lvi{0});",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "//	4�����ü�¼����״̬,");
                strBuilder.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�");
                strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst.Count;",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }


        private string GetCode4FieldInUpdateBySqlWithCondition(clsPrjTabFldENEx objField, ref bool bolIsFirst)
        {
            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
            
            string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return sbCodeForCs.ToString();
            }
            if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") return sbCodeForCs.ToString();//ֻ���Ͳ���Ҫ���
            if (objField.FldOpTypeId == "0003")
            {
                sbCodeForCs.AppendFormat("\r\n if (obj{1}EN.IsUpdated(cls{1}EN.con_{0}))",
        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                sbCodeForCs.Append("\r\n {");

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "bool":
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4} == true?\"1\":\"0\"); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                             strPrivPropNameWithObjectName);
                            break;
                        case "byte":
                        case "byte[]":
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\",{4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                            objField.ObjFieldTabENEx.FldName,
                            strPrivPropNameWithObjectName);
                            break;
                        default:
                            if (objField.IsTabForeignKey == true)
                            {
                                sbCodeForCs.AppendFormat("\r\n if ({0}  ==  \"\")",
                                strPrivPropNameWithObjectName4Get);
                                sbCodeForCs.Append("\r\n {");
                                sbCodeForCs.AppendFormat("\r\n {0} = null;",
                                strPrivPropNameWithObjectName4Get);
                                sbCodeForCs.Append("\r\n }");
                            }
                            sbCodeForCs.AppendFormat("\r\n if ({0} !=  null)",
                            strPrivPropNameWithObjectName4Get);
                            sbCodeForCs.Append("\r\n {");
                            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                            {
                                sbCodeForCs.AppendFormat("\r\n {0} = {1}.Replace(\"'\", \"''\"); //ת��ֵ���еĵ�Ʋ\"'\",ʹ֮��Ϊ˫Ʋ\"''\"",
                                strPrivPropNameWithObjectName4Get,
                                strPrivPropNameWithObjectName4Get
                               );
                            }
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                            objField.ObjFieldTabENEx.FldName,
                            strPrivPropNameWithObjectName4Get);
                            sbCodeForCs.Append("\r\n }");
                            sbCodeForCs.Append("\r\n else");
                            sbCodeForCs.Append("\r\n {");
                            sbCodeForCs.AppendFormat("\r\n sbSQL.Append(\" " + objField.ObjFieldTabENEx.FldName + " = null,\"); //{2}",
                            "{", "}",
                            objField.ColCaption);

                            sbCodeForCs.Append("\r\n }");
                            break;
                    }
                }
                else
                {
                    sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = {{0}},\", {4}); //{2}",
                    "{", "}",
                    objField.ColCaption,
                     objField.ObjFieldTabENEx.FldName ,
                     strPrivPropNameWithObjectName4Get );
                }
                sbCodeForCs.Append("\r\n }");

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n if (obj{1}EN.IsUpdated(cls{1}EN.con_{0}))",
            objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
            sbCodeForCs.Append("\r\n {");

            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "bool":
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4} == true?\"1\":\"0\"); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName ,
                          strPrivPropNameWithObjectName );
                        break;
                    case "byte":
                    case "byte[]":
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName ,
                          strPrivPropNameWithObjectName );
                        break;
                    default:
                        if (objField.IsTabForeignKey == true)
                        {
                            sbCodeForCs.AppendFormat("\r\n if ({0}  ==  \"\")",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n {");
                            sbCodeForCs.AppendFormat("\r\n {0} = null;",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n }");
                        }
                        sbCodeForCs.AppendFormat("\r\n if ({0} !=  null)",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n {");
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                        {
                            sbCodeForCs.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //ת��ֵ���еĵ�Ʋ\"'\",ʹ֮��Ϊ˫Ʋ\"''\"",
                            strPrivPropNameWithObjectName);
                        }
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName ,
                          strPrivPropNameWithObjectName );
                        sbCodeForCs.Append("\r\n }");
                        sbCodeForCs.Append("\r\n else");
                        sbCodeForCs.Append("\r\n {");
                        sbCodeForCs.AppendFormat("\r\n sbSQL.Append(\" " + objField.ObjFieldTabENEx.FldName + " = null,\"); //{2}",
                        "{", "}",
                        objField.ColCaption);

                        sbCodeForCs.Append("\r\n }");
                        break;
                }
            }
            else
            {
                sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = {{0}},\", {4}); //{2}",
                "{", "}",
                objField.ColCaption,
                 objField.ObjFieldTabENEx.FldName , 
                 strPrivPropNameWithObjectName );
            }
            sbCodeForCs.Append("\r\n }");

            return sbCodeForCs.ToString();
        }
        private string GetCode4FieldInUpdateBySql(clsPrjTabFldENEx objField, ref bool bolIsFirst)
        {
            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
            string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

            StringBuilder sbCodeForCs = new StringBuilder();
            if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return sbCodeForCs.ToString();
            }
            if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") return sbCodeForCs.ToString();//ֻ���Ͳ���Ҫ���
            if (objField.FldOpTypeId == "0003")
            {
                if (bolIsFirst == true)
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        // sbSQL.AppendFormat("LoginTime = 'objPrjTabENEx.LoginTime' //��½ʱ��
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                        {
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{3} = '{{0}}'\", {4} == true?\"1\":\"0\"); //{2}",
                            "{", "}",
                            objField.ColCaption,
                            objField.ObjFieldTabENEx.FldName ,
                             strPrivPropNameWithObjectName4Get );
                        }
                        else
                        {
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{3} = '{{0}}'\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName ,
                              strPrivPropNameWithObjectName4Get );
                        }
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{3} = {{0}}\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName , 
                         strPrivPropNameWithObjectName4Get);
                    }
                    bolIsFirst = false;
                }
                else
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                        {
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = '{{0}}'\", {4} == true?\"1\":\"0\"); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName ,
                              strPrivPropNameWithObjectName4Get );
                        }
                        else
                        {
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = '{{0}}'\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                             strPrivPropNameWithObjectName4Get );
                        }
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = {{0}}\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName ,
                         strPrivPropNameWithObjectName4Get );
                    }
                }

                return sbCodeForCs.ToString();
            }
            if (bolIsFirst == true)
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    // sbSQL.AppendFormat("LoginTime = 'objPrjTabENEx.LoginTime' //��½ʱ��
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}'\", {4} == true?\"1\":\"0\"); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName ,
                          strPrivPropNameWithObjectName );
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}'\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName ,
                          strPrivPropNameWithObjectName );
                    }
                }
                else
                {
                    sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = {{0}}\", {4}); //{2}",
                    "{", "}",
                    objField.ColCaption,
                     objField.ObjFieldTabENEx.FldName ,
                      strPrivPropNameWithObjectName );
                }
                bolIsFirst = false;
            }
            else
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = '{{0}}'\", {4} == true?\"1\":\"0\"); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName ,
                          strPrivPropNameWithObjectName );
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3}= '{{0}}'\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName,
                          strPrivPropNameWithObjectName );
                    }
                }
                else
                {
                    sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = {{0}}\", {4}); //{2}",
                    "{", "}",
                    objField.ColCaption,
                     objField.ObjFieldTabENEx.FldName ,
                      strPrivPropNameWithObjectName );
                }
            }
            //}

            return sbCodeForCs.ToString();
        }
        private string GetCode4FieldInAddNewRecordBySql2(clsPrjTabFldENEx objField)
        {
            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

            StringBuilder sbCodeForCs = new StringBuilder();
            if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return sbCodeForCs.ToString();
            }
            if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") return sbCodeForCs.ToString();//ֻ���Ͳ���Ҫ���

            if (objField.FldOpTypeId == "0003") //ֻд
            {
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "byte[]":
                    case "byte":
                        break;
                    case "string":

                        if (objField.IsTabForeignKey == true)
                        {
                            sbCodeForCs.AppendFormat("\r\n if ({0}  ==  \"\")",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n {");
                            sbCodeForCs.AppendFormat("\r\n {0} = null;",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n }");
                        }

                        sbCodeForCs.AppendFormat("\r\n if ({0} !=  null)",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n {");
                        sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        sbCodeForCs.AppendFormat("\r\n {0} = {1}.Replace(\"'\", \"''\"); //ת��ֵ���еĵ�Ʋ\"'\",ʹ֮��Ϊ˫Ʋ\"''\"",
                        strPrivPropNameWithObjectName,
                        strPrivPropNameWithObjectName
                       );
                        //if (clsSysParaEN.bolIsAccessSqlInjection  ==  true)
                        //{
                        // sbCodeForCs.AppendFormat("\r\n {0} = {0}.Replace(\"delete\", \" \"); //ɾ��SQLע���е�DELETE,ʹ֮��Ϊ�ո�\"",
                        // strPrivPropNameWithObjectName);
                        // string ss = "";
                        // string ss1 = ss.Replace(
                        //}
                        sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n }");
                        break;
                    case "bool":
                        sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0}  ==  false ? \"0\" : \"1\") + \"'\");",
                        strPrivPropNameWithObjectName);
                        break;
                    case "int":
                    case "long":
                    case "float":
                    case "double":
                    case "short":
                    case "Int16":
                    case "Int32":

                        sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                        strPrivPropNameWithObjectName);
                        break;
                    default:
                        sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                            {
                                sbCodeForCs.AppendFormat("\r\n {0} = {1}.Replace(\"'\", \"''\"); //ת��ֵ���еĵ�Ʋ\"'\",ʹ֮��Ϊ˫Ʋ\"''\"",
                                strPrivPropNameWithObjectName,
                                strPrivPropNameWithObjectName
                               );
                            }
                            sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                            strPrivPropNameWithObjectName);
                        }
                        else
                        {
                            sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add({0});",
                            strPrivPropNameWithObjectName);
                        }
                        break;
                }

                return sbCodeForCs.ToString();
            }

            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte[]":
                case "byte":
                    break;
                case "string":

                    if (objField.IsTabForeignKey == true)
                    {
                        sbCodeForCs.AppendFormat("\r\n if ({0}  ==  \"\")",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n {");
                        sbCodeForCs.AppendFormat("\r\n {0} = null;",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n }");
                    }

                    sbCodeForCs.AppendFormat("\r\n if ({0} !=  null)",
                    strPrivPropNameWithObjectName);
                    sbCodeForCs.Append("\r\n {");
                    sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                          objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    sbCodeForCs.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //ת��ֵ���еĵ�Ʋ\"'\",ʹ֮��Ϊ˫Ʋ\"''\"",
                    strPrivPropNameWithObjectName);
                    //if (clsSysParaEN.bolIsAccessSqlInjection  ==  true)
                    //{
                    // sbCodeForCs.AppendFormat("\r\n {0} = {0}.Replace(\"delete\", \" \"); //ɾ��SQLע���е�DELETE,ʹ֮��Ϊ�ո�\"",
                    // strPrivPropNameWithObjectName);
                    // string ss = "";
                    // string ss1 = ss.Replace(
                    //}
                    sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                    strPrivPropNameWithObjectName);
                    sbCodeForCs.Append("\r\n }");
                    break;
                case "bool":
                    sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0}  ==  false ? \"0\" : \"1\") + \"'\");",
                    strPrivPropNameWithObjectName);
                    break;
                case "int":
                case "long":
                case "float":
                case "double":
                case "short":
                case "Int16":
                case "Int32":

                    sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                    strPrivPropNameWithObjectName);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(cls{1}EN.con_{0});",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                        {
                            sbCodeForCs.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //ת��ֵ���еĵ�Ʋ\"'\",ʹ֮��Ϊ˫Ʋ\"''\"",
                            strPrivPropNameWithObjectName);
                        }
                        sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + {0} + \"'\");",
                        strPrivPropNameWithObjectName);
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add({0});",
                        strPrivPropNameWithObjectName);
                    }
                    break;
            }
            return sbCodeForCs.ToString();
        }
        private string GetCode4FieldInUpdateBySql2(clsPrjTabFldENEx objField)
        {
            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
            
            string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") return ""; ;//ֻ���Ͳ���Ҫ���
            if (objField.FldOpTypeId == "0003") //ֻд
            {
                sbCodeForCs.AppendFormat("\r\n if (obj{1}EN.IsUpdated(cls{1}EN.con_{0}))",
        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                sbCodeForCs.Append("\r\n {");

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "bool":
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4} == true?\"1\":\"0\"); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName ,
                             strPrivPropNameWithObjectName4Get);
                            break;
                        case "byte":
                        case "byte[]":
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName ,
                              strPrivPropNameWithObjectName4Get);
                            break;
                        default:
                            if (objField.IsTabForeignKey == true)
                            {
                                sbCodeForCs.AppendFormat("\r\n if ({0}  ==  \"\")",
                                strPrivPropNameWithObjectName4Get);
                                sbCodeForCs.Append("\r\n {");
                                sbCodeForCs.AppendFormat("\r\n {0} = null;",
                                strPrivPropNameWithObjectName4Get);
                                sbCodeForCs.Append("\r\n }");
                            }
                            sbCodeForCs.AppendFormat("\r\n if ({0} !=  null)",
                            strPrivPropNameWithObjectName4Get);
                            sbCodeForCs.Append("\r\n {");
                            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                            {
                                sbCodeForCs.AppendFormat("\r\n {0} = {1}.Replace(\"'\", \"''\"); //ת��ֵ���еĵ�Ʋ\"'\",ʹ֮��Ϊ˫Ʋ\"''\"",
                                strPrivPropNameWithObjectName4Get,
                                strPrivPropNameWithObjectName4Get
                               );
                            }
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                            objField.ObjFieldTabENEx.FldName,
                             strPrivPropNameWithObjectName4Get );
                            sbCodeForCs.Append("\r\n }");
                            sbCodeForCs.Append("\r\n else");
                            sbCodeForCs.Append("\r\n {");
                            sbCodeForCs.AppendFormat("\r\n sbSQL.Append(\" " + objField.ObjFieldTabENEx.FldName + " = null,\"); //{2}",
                            "{", "}",
                            objField.ColCaption);

                            sbCodeForCs.Append("\r\n }");
                            break;
                    }
                }
                else
                {
                    sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = {{0}},\", {4}); //{2}",
                    "{", "}",
                    objField.ColCaption,
                    objField.ObjFieldTabENEx.FldName ,
                     strPrivPropNameWithObjectName4Get );
                }
                sbCodeForCs.Append("\r\n }");
                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n if (obj{1}EN.IsUpdated(cls{1}EN.con_{0}))",
            objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
            sbCodeForCs.Append("\r\n {");

            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "bool":
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {{1}} = '{{0}}',\", {3} == true?\"1\":\"0\", cls{4}EN.con_{5}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                        strPrivPropNameWithObjectName,
                         objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                        break;
                    case "byte":
                    case "byte[]":
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{1}} = '{{0}}',\", {3}, cls{4}EN.con_{5}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                        strPrivPropNameWithObjectName,
                         objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                        break;
                    default:
                        if (objField.IsTabForeignKey == true)
                        {
                            sbCodeForCs.AppendFormat("\r\n if ({0}  ==  \"\")",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n {");
                            sbCodeForCs.AppendFormat("\r\n {0} = null;",
                            strPrivPropNameWithObjectName);
                            sbCodeForCs.Append("\r\n }");
                        }
                        sbCodeForCs.AppendFormat("\r\n if ({0} !=  null)",
                        strPrivPropNameWithObjectName);
                        sbCodeForCs.Append("\r\n {");
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                        {
                            sbCodeForCs.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //ת��ֵ���еĵ�Ʋ\"'\",ʹ֮��Ϊ˫Ʋ\"''\"",
                            strPrivPropNameWithObjectName);
                        }
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{1}} = '{{0}}',\", {3}, cls{4}EN.con_{5}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                        strPrivPropNameWithObjectName,
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                        sbCodeForCs.Append("\r\n }");
                        sbCodeForCs.Append("\r\n else");
                        sbCodeForCs.Append("\r\n {");
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{0}} = null,\",cls{3}EN.con_{4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);

                        sbCodeForCs.Append("\r\n }");
                        break;
                }
            }
            else
            {
                sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{1}} = {{0}},\",{3}, cls{4}EN.con_{5}); //{2}",
                "{", "}",
                objField.ColCaption,
                strPrivPropNameWithObjectName,
                 objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
            }
            sbCodeForCs.Append("\r\n }");
            return sbCodeForCs.ToString();
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
        public static void CheckTabNameIsNotNull(string strTabName)
        {
            if (string.IsNullOrEmpty(strTabName) == true)
            {
                string strMsg = string.Format("�˴���������Ϊ��!");
                throw new Exception(strMsg);
            }
        }

        public virtual string A_GenEntityLayerCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);   
        }


        public virtual string A_GenEntityLayerCode_Cond(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }

        public virtual string A_GenEntityLayerCodeEx(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }


        public virtual string A_GenEntityLayerCode_Sim( ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }
        public virtual string A_GenDALCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }
        public virtual string A_GenDALExCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }
      
        public virtual string A_GenDALCode_Java( ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }
        public virtual string A_GenGeneralLogicCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }
        public virtual string A_GenGeneralExLogicCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("����չ����û��Override�ú���,��ע��!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }
  

        public virtual string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
              string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                switch (strFuncName)
                {
                    case "GetKeyId":
                        return GenGetKeyId();
                    case "GetNameValue":
                        return GenGetNameValue();
                    case "ErrNo":
                        return GenpErrNo();
                    case "DispErrMsg":
                        return GenDispErrMsg();
                    case "ConnectString":
                        return GenConnectString();
                    case "ClassConstructor1":
                    case "ClassConstructor1_Swift3":
                    case "ClassConstructor1_Swift4":
                        if (objPrjTabENEx.LangType == clsPubConst.LangType.CSharp)
                        {
                            return GenClassConstructor1();
                        }
                        else if (objPrjTabENEx.LangType == clsPubConst.LangType.JAVA)
                        {
                            return GenClassConstructor1_Java(objPrjTabENEx);
                        }
                        else if (objPrjTabENEx.LangType == clsPubConst.LangType.Swift)
                        {
                            return GenClassConstructor1_Swift(objPrjTabENEx);
                        }
                        else if (objPrjTabENEx.LangType == clsPubConst.LangType.Swift3)
                        {
                            return GenClassConstructor1_Swift3(objPrjTabENEx);
                        }
                        else if (objPrjTabENEx.LangType == clsPubConst.LangType.Swift4)
                        {
                            return GenClassConstructor1_Swift4(objPrjTabENEx);
                        }
                        else if (objPrjTabENEx.LangType == clsPubConst.LangType.JavaScript)
                        {
                            return GenClassConstructor1_JavaScript(objPrjTabENEx);
                        }
                        else if (objPrjTabENEx.LangType == clsPubConst.LangType.TypeScript)
                        {
                            return GenClassConstructor1_TypeScript(objPrjTabENEx);
                        }
                        else
                        {
                            return GenClassConstructor1();
                        }
                    case "ClassConstructor1_Swift4_Sim":
                        return GenClassConstructor1_Swift4_Sim(objPrjTabENEx);
                    case "CondEntityClassConstructor":
                        return GenCondEntityClassConstructor();

                        
                    case "ClassConstructor2":
                    case "ClassConstructor2_Swift3":
                    case "ClassConstructor2_Swift4":
                        if (objPrjTabENEx.LangType == clsPubConst.LangType.CSharp)
                        {
                            return GenClassConstructor2();
                        }
                        else if (objPrjTabENEx.LangType == clsPubConst.LangType.JAVA)
                        {
                            return GenClassConstructor2_Java(objPrjTabENEx);
                        }
                        else if (objPrjTabENEx.LangType == clsPubConst.LangType.Swift)
                        {
                            return GenClassConstructor2_Swift(objPrjTabENEx);
                        }
                        else if (objPrjTabENEx.LangType == clsPubConst.LangType.Swift3)
                        {
                            return GenClassConstructor2_Swift3(objPrjTabENEx);
                        }
                        else if (objPrjTabENEx.LangType == clsPubConst.LangType.Swift4)
                        {
                            return GenClassConstructor2_Swift4(objPrjTabENEx);
                        }
                        else if (objPrjTabENEx.LangType == clsPubConst.LangType.JavaScript)
                        {
                            return GenClassConstructor2_JavaScript(objPrjTabENEx);
                        }
                        else if (objPrjTabENEx.LangType == clsPubConst.LangType.TypeScript)
                        {
                            return GenClassConstructor2_TypeScript(objPrjTabENEx);
                        }
                        else
                        {
                            return GenClassConstructor2();
                        }

                    case "ClassConstructor3":
                        return GenClassConstructor3();
                    case "ClassConstructorEx1":
                        return GenClassConstructorEx1();
                    case "ClassConstructorEx2":
                        return GenClassConstructorEx2();
                    case "ClassConstructorEx3":
                        return GenClassConstructorEx3();
                    case "ClsPrivateVar":
                    case "ClsPrivateVar_Swift3":
                    case "ClsPrivateVar_Swift4":

                        return GenClsPrivateVar();
                        
                    case "ClsPrivateVar_Sim":
                    case "ClsPrivateVar_Sim_Swift3":
                    case "ClsPrivateVar_Sim_Swift4":
                        return GenClsPrivateVar_Sim();
                    case "PropertyNameConst":
                    case "PropertyNameConst_Swift3":
                    case "PropertyNameConst_Swift4":
                        return GenPropertyNameConst();


                    case "GenCheckPrimaryKey":
                        return GenCheckPrimaryKey();

                    case "GenSetCondFldValue":
                        return GenSetCondFldValue();

                    case "GenCheckPrimaryKey_Sim":
                        return GenCheckPrimaryKey_Sim();

                    case "Gen_ClearUpdateState":
                        return Gen_ClearUpdateState();
                    case "GenDdlBindFunction":
                        return GenDdlBindFunction();
                    case "GenComboBoxBindFunction":
                        return GenComboBoxBindFunction();
                    case "GenBindListView":
                        return GenBindListView();
                    case "ClsProperty":
                    case "ClsProperty_Swift3":

                    case "ClsProperty_Swift4":
                        return GenClsProperty();
                    case "ClsPropertyV2":
                        return GenClsPropertyV2();

                    case "ClsProperty_Sim":
                    case "ClsProperty_Sim_Swift3":
                    case "ClsProperty_Sim_Swift4":
                        return GenClsProperty_Sim();

                    case "ClsIndexer":	//��������
                        return GenClsIndexer();
                    case "SetInit":
                        return GenSetInit();
                    case "Gen_GetSpecSQLObj":
                        return Gen_GetSpecSQLObj();
                    case "Gen_GetSpecSQLObj_Obj":
                        return Gen_GetSpecSQLObj_Obj();
                    case "AddNewRecord":
                        return GenAddNewRecord();
                    case "AddNewRecordBySQL":
                        return GenAddNewRecordBySQL();
                    case "AddNewRecordBySQL2":
                        return GenAddNewRecordBySQL2();

                    case "AddNewRecordBySQL2WithReturnKey":
                        return GenAddNewRecordBySQL2WithReturnKey();

                    case "AddNewRecordBySQL2WithReturnKeyAndTransaction":
                        return GenAddNewRecordBySQL2WithReturnKeyAndTransaction();

                    case "AddNewRecordBySQLWithTransaction":
                        return GenAddNewRecordBySQLWithTransaction();
                    case "AddNewRecordBySQLWithTransaction2":
                        return GenAddNewRecordBySQLWithTransaction2();

                    case "AddnewRecBySP":
                        return GenAddnewRecBySP();
                    case "AddnewMultiRec":
                        return GenAddnewMultiRec();
                    case "Update":
                        return GenUpdate();
                    case "UpdateBySP":
                        return GenUpdateBySP();
                    //case "CopyObj":
                    // return GenCopyObj();
                    case "CopyObj_S":
                        return GenCopyObj_S();
                    case "CopyObjToSimObj_S":
                        return GenCopyObjToSimObj_S();
                    case "CopyObjFromSimObj_S":
                        return GenCopyObjFromSimObj_S();
                    case "CopyObjFromSimObj4Upd_S":
                        return GenCopyObjFromSimObj4Upd_S();

                    case "UpdateBySql":
                        return GenUpdateBySql();
                    case "UpdateBySqlWithCondition":
                        return GenUpdateBySqlWithCondition();
                    case "UpdateBySqlWithConditionTransaction":
                        return GenUpdateBySqlWithConditionTransaction();

                    case "UpdateBySql2":
                        return GenUpdateBySql2();
                    case "UpdateBySQLWithTransaction":
                        return GenUpdateBySqlWithTransaction();
                    case "UpdateBySQLWithTransaction2":
                        return GenUpdateBySqlWithTransaction2();
                    case "UpdateMultiRec":
                        return GenUpdateMultiRec();
                    case "GetRecCount":
                        return GenGetRecCount();
                    case "GetRecCount_S":
                        return GenGetRecCount_S();
                    case "GetRecCountByCond":
                        return GenGetRecCountByCond();
                    case "GetRecCountByCond_S":
                        return GenGetRecCountByCond_S();
                        
                    case "funSetFldValue":
                        return GenfunSetFldValue();
                    case "funSetFldValue_S":
                        return GenfunSetFldValue_S();

                    case "funSetFldValue4String":
                        return GenfunSetFldValue4String();
                    case "funSetFldValue4Float":
                        return GenfunSetFldValue4Float();
                    case "funSetFldValue4Int":
                        return GenfunSetFldValue4Int();
                    case "funSetFldValue4String_S":
                        return GenfunSetFldValue4String_S();
                    case "funSetFldValue4Int_S":
                        return GenfunSetFldValue4Int_S();
                    case "funSetFldValue4Float_S":
                        return GenfunSetFldValue4Float_S();

                    case "clsGeneralTab2.GetFldValue":
                        return GenGetFldValue();
                    case "GetFldValue_S":
                        return GenGetFldValue_S();
                    case "GetFldValue":
                        return GenGetFldValue();
                    case "GetFldValueNoDistinct":
                        return GenGetFldValueNoDistinct();

                    case "DelRecord":
                        return GenDelRecord();
                    case "DelRecordBySP":
                        return GenDelRecordBySP();
                    case "DelRecordBySP_S":
                        return GenDelRecordBySP_S();
                    case "DelRecordWithTransaction":
                        return GenDelRecordWithTransaction();
                    case "DelRecordWithTransaction_S":
                        return GenDelRecordWithTransaction_S();

                    case "DelMultiRec_S":
                        return GenDelMultiRec_S();
                    case "DelRecord_S":
                        return GenDelRecord_S();
                    case "DelCondRec_S":
                        return GenDelCondRec_S();
                    case "GenDelCondRecWithTransaction_S":
                        return GenDelCondRecWithTransaction_S();

                    case "GetRecValue":
                        return GenGetRecValue();

                    case "Gen_GetObjByKeyId":
                        return Gen_GetObjByKeyId(objvFunction4GeneCodeEN);
                    case "GetRecValueBySP":
                        return GenGetRecValueBySP();
                    case "GenGetDataTable_S":
                        return GenGetDataTable_S();
                    case "GenGetDataTableByTabName_S":
                        return GenGetDataTableByTabName_S();

                    case "GenGetDataTable_Exclude":
                        return GenGetDataTable_Exclude();
                    case "GenGetDataTableByTabName_S_Exclude":
                        return GenGetDataTableByTabName_S_Exclude();

                    case "GenGetDataTable_IsCheckSQLAttack":
                        return GenGetDataTable_IsCheckSQLAttack();
                    case "GenGetDataTableByTabName_S_IsCheckSQLAttack":
                        return GenGetDataTableByTabName_S_IsCheckSQLAttack();
                        
                    case "GetDataTable_Top_S":
                        return GetDataTable_Top_S();
                    case "GetDataTable_Top_S_Exclude":
                        return GetDataTable_Top_S_Exclude();
                    case "GetDataTable_Top_S_IsCheckSQLAttack":
                        return GetDataTable_Top_S_IsCheckSQLAttack();
                    case "GenGetDataTableByPager_S":
                        return GenGetDataTableByPager_S();
                    case "GenGetDataTableByPager_S_Exclude":
                        return GenGetDataTableByPager_S_Exclude();
                    case "GenGetDataTableByPager_S_IsCheckSQLAttack":
                        return GenGetDataTableByPager_S_IsCheckSQLAttack();

                    case "GetCondRecSetByRange_S":
                        return GenGetDataTableByRange_S();
                    case "GetCondRecSetByRange_S_Exclude":
                        return GenGetDataTableByRange_S_Exclude();
                    case "GetCondRecSetByRange_S_IsCheckSQLAttack":
                        return GenGetDataTableByRange_S_IsCheckSQLAttack();
                    case "GetCondRecSetBySP_S":
                        return GenGetDataTableBySP_S();
                    case "GenGetDataSetByCond_S":
                        return GenGetDataSetByCond_S();
                    case "GenGetTopDataSetByCond_S":
                        return GenGetTopDataSetByCond_S();

                    case "GetDataSetByCondByRange_S":
                        return GenGetDataSetByCondByRange_S();
                    case "GetDataSetByCondByRange_S_Exclude":
                        return GenGetDataSetByCondByRange_S_Exclude();
                    case "GetDataSetByCondByRange_S_IsCheckSQLAttack":
                        return GenGetDataSetByCondByRange_S_IsCheckSQLAttack();

                    case "GetDataSetByCondBySP_S":
                        return GenGetDataSetByCondBySP_S();
                    case "GetDataSetByCond_V_S":
                        return GenGetDataSetByCond_V_S();
                    case "GetDataSetByCondByRange_V_S":
                        return GenGetDataSetByCondByRange_V_S();
                    case "GetDataSetByCondByRange_V_S_Exclude":
                        return GenGetDataSetByCondByRange_V_S_Exclude();
                    case "GetDataSetByCondByRange_V_S_IsCheckSQLAttack":
                        return GenGetDataSetByCondByRange_V_S_IsCheckSQLAttack();


                    case "Gen_GetObjLst":
                        return GenGetObjLst();

                    case "Gen_GetObjLstByTabName":
                        return GenGetObjLstByTabName();

                    case "GetObjLstBySP":
                        return GenGetObjLstBySP();
                    case "GenGetFirstCondRecObj":
                        return GenGetFirstCondRecObj();
                    case "GetRecValueObjByDataRow":
                        return GenGetRecValueObjByDataRow();

                    case "GetFirstCondRecObjBySP":
                        return GenGetFirstCondRecObjBySP();
                    case "GetCondRecSetT_S":
                        return GenGetDataTableT_S();
                    case "GetCondRecDataSetBySP_S":
                        return GenGetCondRecDataSetBySP_S();
                    case "GetCondRecSetV_S":
                        return GenGetDataTableV_S();
                    case "GetCondRecSetV_S_Exclude":
                        return GenGetDataTableV_S_Exclude();
                    case "GetCondRecSetByRangeV_S":
                        return GenGetDataTableByRangeV_S();
                    case "GetCondRecSetByRangeV_S_Exclude":
                        return GenGetDataTableByRangeV_S_Exclude();
                    case "GetCondRecSetByRangeV_S_IsCheckSQLAttack":
                        return GenGetDataTableByRangeV_S_IsCheckSQLAttack();
                    case "GetPrimaryKeyID_S":
                        return GenGetPrimaryKeyID_S();
                    case "GetFileFromTabField":
                        return GenGetFileFromTabField();
                    case "StoreFileToTabField":
                        return GenStoreFileToTabField();
                    case "ShowPic_S":
                        return GenShowPic_S();
                    case "GetFileFromTabField_S":
                        return GenGetFileFromTabField_S();
                    case "GetDataTable_S":
                        return GenGetDataTable_S();
                    case "IsExist":
                        return GenIsExist();
                    case "IsExist_S":
                        return GenIsExist_S();
                    case "IsExistBySP_S":
                        return GenIsExistBySP();
                    case "IsExistCondRec_S":
                        return GenIsExistCondRec_S();
                    //case "CheckProperty":
                    // return GenCheckProperty();
                    case "CheckPropertyNew":
                        return GenCheckPropertyNew();
                    case "CheckProperty4Condition":
                        return GenCheckProperty4Condition();
                    case "CheckUniqueness":
                        return GenCheckUniqueness();
                    case "CheckUniquenessV2":
                        return GenCheckUniquenessV2();
                    case "CheckUniquenessV3":
                        return GenCheckUniquenessV3();

                    case "GetUniquenessCOnditionString":
                        return GetUniquenessConditionString();
                    case "GetPrimaryKeyID":
                        return GenGetID();
                    case "CurrTabName_S":
                        return GenCurrTabName_S();
                        
                    case "GetMaxStrID":
                        return GenGetMaxStrID();
                    case "GetMaxStrIdByPrefix":
                        return GenGetMaxStrIdByPrefix();
                    case "IsExistTable":
                        return GenIsExistTable();
                    case "GetFirstID":
                        return GenGetFirstID();
                    case "GetFirstID_S":
                        return GenGetFirstID_S();
                    case "GetReader":
                        return GenGetReader();
                    case "GetTable":
                        return GenGetTable();
                    case "GetTableBySQL":
                        return GenGetTableBySQL();
                    case "TransNullToStr":
                        return GenTransNullToStr();
                    case "TransNullToInt":
                        return GenTransNullToInt();
                    case "TransNullToLong":
                        return GenTransNullToLong();
                    case "TransNullToShort":
                        return GenTransNullToShort();
                    case "TransNullToDate":
                        return GenTransNullToDate();
                    case "TransNullToFloat":
                        return GenTransNullToFloat();
                    case "TransNullToDouble":
                        return GenTransNullToDouble();
                    case "TransNullToBool":
                        return GenTransNullToBool();
                    case "GetStrLen":
                        return GengetStrLen();
                    case "Dispose":
                        return GenDispose();
                    case "LogError":
                        return GenLogError();
                    case "LogError_S":
                        return GenLogError_S();
                    case "Gen_4DAL_GetDataTable4DdlBind":
                        return Gen_4DAL_GetDataTable4DdlBind();
                    case "PropertyNameConst4ConstLevel":
                        return GenPropertyNameConst4ConstLevel();

                    default:
                        string strMsg = string.Format("������:{1}��Switchû�д���,����!({0})",
                                clsStackTrace.GetCurrClassFunction(), strFuncName);
                        throw new Exception(strMsg);
                        //                        return "///��1����������:" + strFuncName;
                }
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strMsg = "";
                if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
                {
                    strMsg = objException.InnerException.Message;
                }
                else
                {
                    strMsg = objException.Message;
                }
                sbMessage.AppendFormat("�����ɺ���:{0}ʱ����. \r\n������Ϣ:{1}.", strFuncName, strMsg);
                throw new Exception(sbMessage.ToString());
            }
        }

        public string GenClassConstructor2_Java(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.AppendFormat("\r\n/// <param name = \"{0}\">�ؼ���:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strBuilder.AppendFormat("\r\npublic {0}({1})",
                objPrjTabENEx.ClsName,
                 GetKeyPara());
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n hmProperty = new HashMap<String, String>();");
            string strTemp = GetKeyAssign(objPrjTabENEx);
            if (string.IsNullOrEmpty(strTemp) == false)
            {
                strBuilder.AppendFormat("\r\n {0}", strTemp);
            }
            strBuilder.Append("\r\n SetInit();");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

        public string GenClassConstructor2_JavaScript(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.AppendFormat("\r\n/// <param name = \"{0}\">�ؼ���:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strBuilder.AppendFormat("\r\npublic {0}({1})",
                objPrjTabENEx.ClsName,
                 GetKeyPara());
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n hmProperty = new Dictionary();");
            strBuilder.Append("\r\n" + GetKeyAssign(objPrjTabENEx) + ";");
            strBuilder.Append("\r\n SetInit();");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string GenClassConstructor2_TypeScript(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.AppendFormat("\r\n/// <param name = \"{0}\">�ؼ���:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strBuilder.AppendFormat("\r\npublic constructor({0}: {1})",
                objKeyField.ObjFieldTabENEx.PrivPropName, objKeyField.TypeScriptType);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "this.{0} = {1} || {2};",
                               this.objKeyField.FldName,
                               this.objKeyField.PrivFuncName,
                                (this.objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true ? "\"\"" : "0")
               );
            strBuilder.Append("\r\n hmProperty = new Dictionary();");
            strBuilder.Append("\r\n" + GetKeyAssign(objPrjTabENEx) + ";");
            strBuilder.Append("\r\n SetInit();");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

        public string GenClassConstructor2_Swift(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.AppendFormat("\r\n/// <param name = \"{0}\">�ؼ���:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strBuilder.AppendFormat("\r\n init({1})",
                objPrjTabENEx.ClsName,
                 GetKeyPara());
            strBuilder.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strBuilder.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }
            
            strBuilder.Append("\r\n super.init();");
            strBuilder.Append("\r\n hmProperty = Dictionary<String, String>();");
            strBuilder.Append("\r\n" + GetKeyAssign_Swift(objPrjTabENEx));
            strBuilder.Append("\r\n SetInit();");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string GenClassConstructor2_Swift3(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.AppendFormat("\r\n/// <param name = \"{0}\">�ؼ���:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strBuilder.AppendFormat("\r\n init({1})",
                objPrjTabENEx.ClsName,
                 GetKeyPara());
            strBuilder.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strBuilder.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);
            }
            //strBuilder.AppendFormat("\r\n" + "self.mintIntTag = 0;     //����Tag");
            //strBuilder.AppendFormat("\r\n" + "self.mstrStrTag = \"\";     //�ַ��ͱ�ǩ");
            //strBuilder.AppendFormat("\r\n" + "self.mbolIsCheckProperty = false;     //�Ƿ�������");
            //strBuilder.AppendFormat("\r\n" + "self.sfUpdFldSetStr = \"\";     //�޸��ַ���־��");

            strBuilder.Append("\r\n super.init();");
            strBuilder.Append("\r\n hmProperty = Dictionary<String, String>();");
            strBuilder.Append("\r\n" + GetKeyAssign_Swift(objPrjTabENEx));
            strBuilder.Append("\r\n SetInit();");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

        public string GenClassConstructor2_Swift4(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.AppendFormat("\r\n/// <param name = \"{0}\">�ؼ���:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strBuilder.AppendFormat("\r\n init({1})",
                objPrjTabENEx.ClsName,
                 GetKeyPara());
            strBuilder.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strBuilder.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }
            //strBuilder.AppendFormat("\r\n" + "self.mintIntTag = 0;     //����Tag");
            //strBuilder.AppendFormat("\r\n" + "self.mstrStrTag = \"\";     //�ַ��ͱ�ǩ");
            //strBuilder.AppendFormat("\r\n" + "self.mbolIsCheckProperty = false;     //�Ƿ�������");
            //strBuilder.AppendFormat("\r\n" + "self.sfUpdFldSetStr = \"\";     //�޸��ַ���־��");

            strBuilder.Append("\r\n super.init();");
            strBuilder.Append("\r\n hmProperty = Dictionary<String, String>();");
            strBuilder.Append("\r\n" + GetKeyAssign_Swift(objPrjTabENEx));
            strBuilder.Append("\r\n SetInit();");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

        public string GetKeyAssign(clsPrjTabENEx objPrjTabENEx)
        {
            string strPara, strTemp;
            strPara = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = string.Format("this.{0} = {1};",
                    objField.ObjFieldTabENEx.PrivPropName,
                     objField.ObjFieldTabENEx.PrivFuncName);
                strPara += "\r\n" + strTemp;
            }
            return strPara;
        }

        public string GetKeyAssign_Swift(clsPrjTabENEx objPrjTabENEx)
        {
            string strPara, strTemp;
            strPara = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = string.Format("self.{0} = {1};",
                    objField.ObjFieldTabENEx.PrivPropName,
                     objField.ObjFieldTabENEx.PrivFuncName);
                strPara += "\r\n" + strTemp;
            }
            return strPara;
        }
        public string GenClassConstructor1_Java(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;            
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.AppendFormat("\r\n public {0}()",
                objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n hmProperty = new HashMap<String, String>();");
            strBuilder.Append("\r\n SetInit();");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

        public string GenClassConstructor1_JavaScript(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;            
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.AppendFormat("\r\n this.init = function()",
                objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n this.hmProperty = new Dictionary();");
            strBuilder.Append("\r\n this.SetInit();");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strBuilder.Append("\r\n };");
            return strBuilder.ToString();
        }
        public string GenClassConstructor1_TypeScript(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;            
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.AppendFormat("\r\n constructor()",
                objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n super();");
            //strBuilder.Append("\r\n this.hmProperty =  new collections.Dictionary <string, boolean>();");
            //strBuilder.Append("\r\n this.SetInit();");
            strBuilder.AppendFormat("\r\n this.CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n this.KeyFldName = \"{0}\";", objKeyField.FldName);

            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string GenClassConstructor1_Swift(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;            
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.AppendFormat("\r\n override init()",
                objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strBuilder.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }
            //strBuilder.AppendFormat("\r\n" + "self.mintIntTag = 0;     //����Tag");
            //strBuilder.AppendFormat("\r\n" + "self.mstrStrTag = \"\";     //�ַ��ͱ�ǩ");
            //strBuilder.AppendFormat("\r\n" + "self.mbolIsCheckProperty = false;     //�Ƿ�������");
            //strBuilder.AppendFormat("\r\n" + "self.sfUpdFldSetStr = \"\";     //�޸��ַ���־��");

            strBuilder.Append("\r\n super.init();");
            strBuilder.Append("\r\n hmProperty = Dictionary<String, String>();");
            strBuilder.Append("\r\n SetInit();");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string GenClassConstructor1_Swift3(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;            
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.AppendFormat("\r\n override init()",
                objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strBuilder.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }
            //strBuilder.AppendFormat("\r\n" + "self.mintIntTag = 0;     //����Tag");
            //strBuilder.AppendFormat("\r\n" + "self.mstrStrTag = \"\";     //�ַ��ͱ�ǩ");
            //strBuilder.AppendFormat("\r\n" + "self.mbolIsCheckProperty = false;     //�Ƿ�������");
            //strBuilder.AppendFormat("\r\n" + "self.sfUpdFldSetStr = \"\";     //�޸��ַ���־��");

            strBuilder.Append("\r\n super.init();");
            strBuilder.Append("\r\n hmProperty = Dictionary<String, String>();");
            strBuilder.Append("\r\n SetInit();");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

        public string GenClassConstructor1_Swift4(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;            
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.AppendFormat("\r\n override init()",
                objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strBuilder.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }
            //strBuilder.AppendFormat("\r\n" + "self.mintIntTag = 0;     //����Tag");
            //strBuilder.AppendFormat("\r\n" + "self.mstrStrTag = \"\";     //�ַ��ͱ�ǩ");
            //strBuilder.AppendFormat("\r\n" + "self.mbolIsCheckProperty = false;     //�Ƿ�������");
            //strBuilder.AppendFormat("\r\n" + "self.sfUpdFldSetStr = \"\";     //�޸��ַ���־��");

            strBuilder.Append("\r\n super.init();");
            strBuilder.Append("\r\n hmProperty = Dictionary<String, String>();");
            strBuilder.Append("\r\n SetInit();");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string GenClassConstructor1_Swift4_Sim(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;            
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.AppendFormat("\r\n init()",
                objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strBuilder.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }
            //strBuilder.AppendFormat("\r\n" + "self.mintIntTag = 0;     //����Tag");
            //strBuilder.AppendFormat("\r\n" + "self.mstrStrTag = \"\";     //�ַ��ͱ�ǩ");
            //strBuilder.AppendFormat("\r\n" + "self.mbolIsCheckProperty = false;     //�Ƿ�������");
            strBuilder.AppendFormat("\r\n" + "self.sfUpdFldSetStr = \"\";     //�޸��ַ���־��");

            //strBuilder.Append("\r\n super.init();");
            //strBuilder.Append("\r\n hmProperty = Dictionary<String, String>();");
            //strBuilder.Append("\r\n SetInit();");
            //strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��
        /// </summary>
        /// <param name = "strWordTypeId">�ؼ���</param>
        /// <returns>�Ƿ���ɹ�</returns>
        public string GenCheckPrimaryKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��.-----------------------------;
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�ؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>�Ƿ���ɹ�</returns>");
            strBuilder.AppendFormat("\r\n" + "public bool CheckPrimaryKey(string {0})", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0} = {0}.Replace(\"'\", \"''\");",
                objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n" + "if ({0}.Length > {1})", objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldLength);
            strBuilder.Append("\r\n" + "{");

            string strFunctionName = string.Format("CheckPrimaryKey", objKeyField.PrivFuncName, objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ڱ�:{0}��,���ؼ���,���Ȳ���ȷ!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{1})�ڱ�:{0}��,���ؼ���,���Ȳ���ȷ!(cls{0}DA:CheckPrimaryKey)\");",
                objPrjTabENEx.TabName,
                strErrId);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0})  ==  true)", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strExplanation = "�ڱ�:{0}��,�ؼ��ֲ���Ϊ�� �� null!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{1})�ڱ�:{0}��,�ؼ��ֲ���Ϊ�� �� null!(cls{0}DA:CheckPrimaryKey)\");",
                objPrjTabENEx.TabName,
                strErrId);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckStrSQL_Weak({0});", objKeyField.PrivFuncName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strExplanation = "�ڹؼ����к���{0},�Ƿ�,����!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"(errid:{3})�ڹؼ����к���{{0}},�Ƿ�,����!(cls{2}DA:CheckPrimaryKey)\", objException.Message));",
                    "{", "}",
                    objPrjTabENEx.TabName,
                    strErrId);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return true;");
            strBuilder.Append("\r\n" + "}");

            ///����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��. ==  == = ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// ����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��
        /// </summary>
        /// <param name = "strWordTypeId">�ؼ���</param>
        /// <returns>�Ƿ���ɹ�</returns>
        public string GenCheckPrimaryKey_Sim()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��.-----------------------------;
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�ؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>�Ƿ���ɹ�</returns>");
            strBuilder.AppendFormat("\r\n" + "public bool CheckPrimaryKey_Sim(string {0})", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0} = {0}.Replace(\"'\", \"''\");",
                objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n" + "if ({0}.Length > {1} + 4)", objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldLength);
            strBuilder.Append("\r\n" + "{");

            string strFunctionName = string.Format("CheckPrimaryKey_Sim", objKeyField.PrivFuncName, objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ڱ�:{0}��,���ؼ���,���Ȳ���ȷ!(�򻯰�)";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{1})�ڱ�:{0}��,���ؼ���,���Ȳ���ȷ!(�򻯰�)(cls{0}DA:CheckPrimaryKey)\");",
                objPrjTabENEx.TabName,
                strErrId);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0})  ==  true)", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strExplanation = "�ڱ�:{0}��,�ؼ��ֲ���Ϊ�� �� null!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{1})�ڱ�:{0}��,�ؼ��ֲ���Ϊ�� �� null!(cls{0}DA:CheckPrimaryKey)\");",
                objPrjTabENEx.TabName,
                strErrId);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckStrSQL_Weak({0});", objKeyField.PrivFuncName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strExplanation = "�ڹؼ����к���{0},�Ƿ�,����!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "throw new Exception(string.Format(\"(errid:{3})�ڹؼ����к���{{0}},�Ƿ�,����!(cls{2}DA:CheckPrimaryKey)\", objException.Message));",
                    "{", "}",
                    objPrjTabENEx.TabName,
                    strErrId);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return true;");
            strBuilder.Append("\r\n" + "}");

            ///����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��. ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string Gen_4DAL_GetDataTable4DdlBind()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";

            try
            {
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.Append("\r\n /// ��ȡ���ڰ��������DataTable,��ȡ�����ֶ�:1���ؼ��֣�2�������ֶ�");
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.Append("\r\n /// <returns>�������ڰ��������DataTable</returns>");
                    strBuilder.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}()",
                    strValueFieldName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
                    strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
                    strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						if (objField.DsCondStr.Trim()  ==  "")
                    //						{
                    //							strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						}
                    //						else
                    //						{
                    //							strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objField.DsCondStr);
                    //						}

                    strBuilder.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

                    strBuilder.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    strBuilder.Append("\r\n" + "return objDT;");
                    strBuilder.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }

        public string SetProperty4DefaultValue_Swift3(clsPrjTabFldENEx objField)
        {
            StringBuilder strBuilder = new StringBuilder();
            //strBuilder.AppendFormat("\r\n" + "if (jsonAllKeys.contains(\"{0}\") == true)",
            //     objField.ObjFieldTabENEx.FldName);
            //strBuilder.Append("\r\n" + "{");
            //  strBuilder.Append("\r\n" + "//print(\"Memo1 is Exist!\");");
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
            {
                case "String":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );

                    break;
                case "Int32":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Int":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Double":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Float":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Short":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Bool":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Date":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = Date();",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                default:
                    string strMsg = string.Format("Swift��������:[{1}]��switch��û�д���({0})",
                        clsStackTrace.GetCurrClassFunction(),
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
                    throw new Exception(strMsg);

            }
            //strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        public string SetProperty4DefaultValue_Swift4(clsPrjTabFldENEx objField)
        {
            StringBuilder strBuilder = new StringBuilder();
            //strBuilder.AppendFormat("\r\n" + "if (jsonAllKeys.contains(\"{0}\") == true)",
            //     objField.ObjFieldTabENEx.FldName);
            //strBuilder.Append("\r\n" + "{");
            //  strBuilder.Append("\r\n" + "//print(\"Memo1 is Exist!\");");
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
            {
                case "String":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );

                    break;
                case "Int32":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Int":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Double":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Float":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Short":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Bool":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Date":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                default:
                    string strMsg = string.Format("Swift��������:[{1}]��switch��û�д���({0})",
                        clsStackTrace.GetCurrClassFunction(),
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
                    throw new Exception(strMsg);

            }
            //strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public virtual string A_GenCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                if (objvFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
                {
                    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                }
                else
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                }

                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4BL_GC_GetObjFromDataRow()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN()",
      objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            int intCount = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                intCount++;
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    if (intCount == objPrjTabENEx.arrFldSet.Count)
                    {
                        strBuilder.AppendFormat("\r\n" + "{1} = " + AccessNull2(objField) + " //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "{1} = " + AccessNull2(objField) + ", //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                    }
                }
            }
            strBuilder.Append("\r\n};");
            //strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//����޸�״̬,��������ֶ���Ϣ",
            //objPrjTabENEx.TabName);

            return strBuilder.ToString();
        }


    }
}
