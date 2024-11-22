using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;

using com.taishsoft.commexception;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.sql;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;


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
    class EntityLayerEx4Swift4 : clsGeneCodeBase
    {
        //internal CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();

        //public string ClsName;
    
        private bool mbolIsHaveImageField;
        private string mstrImageFieldName;
        protected string mstrFolderName; // '�ļ�Ŀ¼��
        protected string mstrFileName;

        #region ���캯��

        public EntityLayerEx4Swift4()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public EntityLayerEx4Swift4(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
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



        public string GenSQLCode(string strPrjDataBaseId, clsPrjTabENEx objPrjTabENEx)
        {
            string strResult = "";
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseId(strPrjDataBaseId);
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
            string strDatabaseOwner;    //���ݿ�ӵ����
            string strFieldCode;
            string strRemark, strRemark0;
            string strFieldName;
            string strFieldType;
            //			string strFieldType0;
            string strIsNullable;       //, strIsNullable0;		// = " null ";
            string strPrimaryKey;       //, strPrimaryKey0;
            string strFieldLength, strFieldLength0;     //�ֶγ���

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
                    strRemark = "/**" + strRemark0 + "*/";

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

                if (objField.ObjFieldTabENEx.IsIdentity == true)
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

        public string GenSQLCode4CreateTab(string strPrjDataBaseId, clsPrjTabENEx objPrjTabENEx)
        {
            string strResult = "";
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseId(strPrjDataBaseId);
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
            string strIsNullable;       //, strIsNullable0;		// = " null ";
            string strPrimaryKey;       //, strPrimaryKey0;
            string strFieldLength, strFieldLength0;     //�ֶγ���

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
                    strRemark = "/**" + strRemark0 + "*/";

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

                if (objField.ObjFieldTabENEx.IsIdentity == true)
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

        /// <summary>
        /// ���˽�б���,���������Ե�˽�б���
        /// </summary>
        /// <returns></returns>
        public string gfunClsPrivateVar()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��������˽������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n internal {0} {1};	//{2}",
                objField.JavaType,
                clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java),
                objField.ColCaption);
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
                strTemp = objField.ObjFieldTabENEx.FldName_Java;
                clsString.FstUcase_S(ref strTemp);
                strBuilder.AppendFormat("\r\n //��ȡ{0}({1})��ֵ", objField.ColCaption, objField.ObjFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n public {0} get{1}()", objField.JavaType, strTemp);
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\n return objViewInfoENEx.{0};", objField.ObjFieldTabENEx.FldName_Java);
                strBuilder.Append("\r\n }");
                strBuilder.AppendFormat("\r\n //����{0}({1})��ֵ", objField.ColCaption, objField.ObjFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n public void set{0}({1} value)", strTemp, objField.JavaType);
                strBuilder.Append("\r\n{");
                strBuilder.AppendFormat("\r\n objViewInfoENEx.{0} = value;", objField.ObjFieldTabENEx.FldName_Java);
                strBuilder.AppendFormat("\r\n hmProperty.put(\"{0}\", \"true\");",
                objField.ObjFieldTabENEx.FldName);
                strBuilder.Append("\r\n}");
                strBuilder.Append("\r\n");
            }
            return strBuilder.ToString();
        }
        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        public string gfunClsIndexer()
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
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (strAttributeName == \"{0}\")",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (strAttributeName == \"{0}\")",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName));
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
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (strAttributeName == \"{0}\")",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName), AccessNull("value.toString()", objField.JavaType, true));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (strAttributeName == \"{0}\")",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName), AccessNull("value.toString()", objField.JavaType, true));
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
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (\"{0}\" == AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (\"{0}\" == AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName));
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
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (\"{0}\" == AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName), AccessNull("value.toString()", objField.JavaType, true));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (\"{0}\" == AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName), AccessNull("value.toString()", objField.JavaType, true));
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");

            return strBuilder.ToString();
        }

        public string gfunpErrNo()
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
        public string gfunDispErrMsg()
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
            strBuilder.Append("\r\n objViewInfoENEx.DispErrMsg = value;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string gfunClassConstructor3()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\npublic {0}({1}, boolean bolIsGet{2})",
              objPrjTabENEx.ClsName, GetKeyPara(), objPrjTabENEx.TabName);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n hmProperty = Dictionary<String, String>();");
            strBuilder.AppendFormat("\r\n{0}", GetKeyAssign() + ";");
            strBuilder.Append("\r\nSetInit();");
            strBuilder.AppendFormat("\r\nif (bolIsGet{0} == true)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nGet{0}();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }

        public string gfunClassConstructorEx1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;
            strBuilder.Append("\r\n public " + strClsNameEx + "()" + ": base()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string gfunClassConstructorEx2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic " + strClsNameEx + "(" + GetKeyPara() + ")" + ": base(" + objKeyField.PrivFuncName + ")");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string gfunClassConstructorEx3()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\npublic {0}({1}, boolean bolIsGet{2}) : base({3},bolIsGet{2})",
            strClsNameEx, GetKeyPara(), objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }

        public string gfunSetInit()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���������Щ���Գ�ʼֵ");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\nprivate void SetInit()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjViewInfoENEx.ModuleName = objViewInfoENEx.GetType().toString();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.JavaType == "Date")
                {
                    strBuilder.Append("\r\n" + clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName) + " = System.DateTime.Parse(\"01/01/1900\");	");
                }
            }
            strBuilder.Append("\r\n}");
            ///�๹���� == == == = ;
            return strBuilder.ToString();
        }
        public string gfunAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��������--------------------------------------;
            ///����¼�¼----------------;
            ///
            strBuilder.Append("\r\n public int AddNewRecord()");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException {");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\n strSQL = \"insert into " + objPrjTabENEx.TabName + "\";");
            strBuilder.Append("\r\n strSQL += \" (");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.Append(objField.ObjFieldTabENEx.FldName);
                }
                else
                {
                    strBuilder.Append(", " + objField.ObjFieldTabENEx.FldName);
                }
            }
            strBuilder.Append(") \" ;");
            bolIsFirst = true;
            int intFldNum = objPrjTabENEx.arrFldSet.Count;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.Append("\r\n strSQL += \" values (?");
                }
                else
                {
                    strBuilder.Append(", ?");
                }
            }
            strBuilder.Append(")\";");
            strBuilder.Append("\r\n PreparedStatement objPS = objSQL.getPreparedStmt(strSQL);");
            strBuilder.Append("\r\n // PreparedStatement objPS = objSQL.getCallableStmt(strSQL);");
            strBuilder.Append("\r\n objPS.clearParameters();");

            int intFieldNo = 1;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                strTemp = objField.JavaType;
                clsString.FstUcase_S(ref strTemp);
                strBuilder.AppendFormat("\r\n objPS.set" + strTemp + "(" + intFieldNo.ToString().Trim() + ", objViewInfoENEx." + clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java) + "); //{0} ",
                objField.ColCaption);
                intFieldNo += 1;
            }
            strBuilder.Append("\r\n int iResult = 0;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n iResult = objPS.executeUpdate();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException e)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw e;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objPS = null;");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return iResult;");
            strBuilder.Append("\r\n }");
            ///����¼�¼ == = ;
            return strBuilder.ToString();
        }

        public string gfunAddNewRecord_neusoft()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��������--------------------------------------;
            ///����¼�¼----------------;
            ///
            strBuilder.Append("\r\n public int AddNewRecord_neusoft()");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, OPException {");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\n strSQL = \"insert into {0} \";",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n strSQL += \" (");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.Append(objField.ObjFieldTabENEx.FldName);
                }
                else
                {
                    strBuilder.Append(", " + objField.ObjFieldTabENEx.FldName);
                }
            }
            strBuilder.Append(") \" ;");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.ObjFieldTabENEx.IsIdentity)
                    {
                        strBuilder.AppendFormat("\r\n strSQL += \" values ({0}_SEQUENCE.NEXTVAL",
                        objPrjTabENEx.TabName.ToUpper());
                    }
                    else
                    {
                        strBuilder.Append("\r\n strSQL += \" values (? ");
                    }
                }
                else
                {
                    if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.ObjFieldTabENEx.IsIdentity)
                    {
                        strBuilder.AppendFormat("\r\n , {0}_SEQUENCE.NEXTVAL",
                        objPrjTabENEx.TabName.ToUpper());
                    }
                    else
                    {
                        strBuilder.Append(", ?");
                    }
                }
            }
            strBuilder.Append(")\";");
            strBuilder.Append("\r\n Object[] params = {");

            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (bolIsFirst == true)
                {
                    if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.ObjFieldTabENEx.IsIdentity)
                    {
                    }
                    else
                    {
                        bolIsFirst = false;

                        strBuilder.AppendFormat("\r\n {0}	//{1}",
                        clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName),
                        objField.ColCaption);
                    }
                }
                else
                {
                    if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.ObjFieldTabENEx.IsIdentity)
                    {
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n , {0}			//{1}",
                        clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName),
                        objField.ColCaption);
                    }
                }
            }

            strBuilder.Append("\r\n };");
            strBuilder.Append("\r\n int iResult = pm.executeUpdate(strSQL, params);");
            strBuilder.Append("\r\n return iResult;");

            strBuilder.Append("\r\n }");
            ///����¼�¼ == = ;
            return strBuilder.ToString();
        }


        public string gfunAddNewRecordBySQL()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����¼�¼,BySQL----------------;
            if (mbolIsHaveImageField == true)
            {
                strBuilder = new StringBuilder();
                strBuilder.Append("\r\n");
                strBuilder.Append("\r\n/// <summary>");
                strBuilder.Append("\r\n/// ����:ͨ��SQL�����������¼");
                strBuilder.Append("\r\n/// ��Ҫ�����ϴ��ļ�ʱ��");
                strBuilder.Append("\r\n/// </summary>");
                strBuilder.Append("\r\n/// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
                strBuilder.Append("\r\npublic boolean Addnew RecordBySQL() ");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\nStringBuffer strSQL = new StringBuffer();");
                strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
                ///strBuilder.Append("\r\nstrSQL.AppendFormat(\"insert into StdPhoto (Stdid, FileName) values ('{0}', '{1}')\", objViewInfoENEx.Stdid, mstrFileName);");
                StringBuilder strFieldLst = new StringBuilder();
                StringBuilder strValueLsd = new StringBuilder();
                string strParaIndex = "";
                bool bolIsFirst = true;
                int intIndex = 0;
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.ObjFieldTabENEx.IsIdentity == false)
                    {
                        if (bolIsFirst == true)
                        {
                            strFieldLst.AppendFormat("{0}", objField.ObjFieldTabENEx.FldName);
                            strValueLsd.AppendFormat("{0}", clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName));
                            strParaIndex = "'{" + intIndex.ToString() + "}'";
                            bolIsFirst = false;
                        }
                        else
                        {
                            strFieldLst.AppendFormat(", {0}", objField.ObjFieldTabENEx.FldName);
                            strValueLsd.AppendFormat(", {0}", clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName));
                            strParaIndex += ", '{" + intIndex.ToString() + "}'";
                        }
                        intIndex = intIndex + 1;
                    }
                }
                strBuilder.AppendFormat("\r\nstrSQL.AppendFormat(\"insert into {3} ({0}) values ({1})\", {2});", strFieldLst.ToString(), strParaIndex, strValueLsd.ToString(), objPrjTabENEx.TabName);
                strBuilder.Append("\r\nreturn objSQL.ExecSql(strSQL.toString());");
                strBuilder.Append("\r\n}");
                strBuilder.Append("\r\n");
            }
            ///����¼�¼,BySQL == = ;
            return strBuilder.ToString();
        }


        public string gfunAddnewRecBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            strTemp = string.Format("public boolean Addnew{0}BySP() ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//ͨ���洢������");
            strBuilder.Append("\r\n//ֱ��ʹ��");
            strBuilder.Append("\r\n			if ( mintErrNo != 0) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//MsgBox(objViewInfoENEx.text-warning(mintErrNo))");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nobjSQL.setSPConfigXMLFile(\"..\\\\XML\\\\XMLSP.xml\");");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                if (objField.PrimaryTypeId == "02" && objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                }
                else
                {
                    strBuilder.Append("\r\nvalues.add(" + clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName) + ");");
                }
            }
            strBuilder.Append("\r\nobjSQL.ExecSP(\"Addnew" + objPrjTabENEx.TabName + "\",values);");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() == == ;
            return strBuilder.ToString();
        }
        public string gfunAddnewMultiRec()
        {

            StringBuilder strBuilder = new StringBuilder();
            ///��Ӷ����¼�¼---------------------------------------------;
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// �Ѷ�����¼ͬʱ���뵽����!");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"oDT\"></param>");
            strBuilder.Append("\r\n/// <param name = \"strResult\"></param>");
            strBuilder.Append("\r\n/// <returns></returns>");
            strTemp = string.Format("public boolean Addnew{0}s(ResultSet oDT, string strResult) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataAdapter objDA;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlCommandBuilder objCB; ");
            strBuilder.Append("\r\nSystem.Data.DataRow objRow;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nif (mintErrNo != 0) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrResult = \"�����Ϊ:\" + mintErrNo.ToString();");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\nstrSQL = \"Select * from {0} where " + objKeyField.FldName + " = '111'\";",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
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
                    strTT = string.Format("oRow[\"{0}\"].toString().Trim()", objKeyField.FldName);
                    strTemp = string.Format("{0} {1} = " + AccessNull(strTT, objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, objKeyField.IsTabNullable) + ";",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, objKeyField.PrivFuncName);
                    strBuilder.Append("\r\n" + strTemp);

                    strBuilder.Append("\r\nif (IsExist(" + objKeyField.PrivFuncName + "))");
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nstrResult = \"�ؼ���" + objKeyField.FldName + "Ϊ:\" + " + objKeyField.PrivFuncName + " + \"�ļ�¼�Ѵ���,�����ظ�����!\" ;");
                    strBuilder.Append("\r\nreturn false;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n//�Ѷ�����¼���뵽����");
            strBuilder.Append("\r\nforeach(System.Data.DataRow oRow in oDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjRow = objDS.Tables[\"" + objPrjTabENEx.TabName + "\"].NewRow();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.PrimaryTypeId == "02" && objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                }
                else
                {
                    strBuilder.Append("\r\nobjRow[\"" + objField.ObjFieldTabENEx.FldName + "\"] = oRow[\"" + objField.ObjFieldTabENEx.FldName + "\"].toString().Trim();");
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
            strBuilder.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            
            
            
            
            strBuilder.Append("\r\nobjSQL.SQLConnect.Close();");
            
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///��Ӷ����¼�¼ == == == = ;
            return strBuilder.ToString();
        }
        public string gfunUpdate()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�޸ļ�¼------------------;
            strBuilder.Append("\r\n public int Update()");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException {");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\n strSQL = \"update {0} set \";", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //if (bolIsFirst == true)
                //{
                // bolIsFirst = false;
                // strBuilder.AppendFormat("\r\n strSQL += \"{0} = ?\";", objField.ObjFieldTabENEx.FldName);
                //}
                //else
                //{
                // strBuilder.AppendFormat("\r\n strSQL += \", {0} = ? \";", objField.ObjFieldTabENEx.FldName);
                //}
                strBuilder.AppendFormat("\r\n //{0}",
                objField.ColCaption);

                if (objField.FieldTypeId != enumFieldType.KeyField_02)
                {
                    strBuilder.AppendFormat("\r\n if (hmProperty.containsKey(\"{0}\"))",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\n strSQL += \"{0} = ?, \";",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n }");
                }
            }
            strBuilder.Append("\r\n strSQL = strSQL.substring(0, strSQL.length()-2);");
            strBuilder.AppendFormat("strSQL += \" where {0} = ?\";", objKeyField.FldName);


            strBuilder.Append("\r\n PreparedStatement objPS = objSQL.getPreparedStmt(strSQL);");
            strBuilder.Append("\r\n // PreparedStatement objPS = objSQL.getCallableStmt(strSQL);");
            strBuilder.Append("\r\n //��ʼ������");
            strBuilder.Append("\r\n objPS.clearParameters();");
            strBuilder.Append("\r\n int intFieldNo = 1;");

            //int intFieldNo = 1;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.KeyField_02)
                {
                    strBuilder.AppendFormat("\r\n if (hmProperty.containsKey(\"{0}\"))",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n {");

                    strTemp = objField.JavaType;
                    clsString.FstUcase_S(ref strTemp);
                    strBuilder.Append("\r\n objPS.set" + strTemp + "(intFieldNo++, objViewInfoENEx." + clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java) + ");");
                    strBuilder.Append("\r\n }");
                }
                //strBuilder.Append("\r\n objPS.set" + strTemp + "(" + intFieldNo.ToString().Trim() + ", objViewInfoENEx." + clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName) + ");");
            }
            //strTemp = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType;
            //clsString.FstUcase_S(ref strTemp);
            //strBuilder.AppendFormat("\r\n objPS.set{0}({1}, objViewInfoENEx.{2}); ",
            // strTemp, intFieldNo, clsString.FstLcaseS(objKeyField.FldName));
            //intFieldNo += 1;

            strTemp = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType;
            clsString.FstUcase_S(ref strTemp);
            strBuilder.AppendFormat("\r\n objPS.set{0}(intFieldNo++, objViewInfoENEx.{1}); ",
            strTemp, clsString.FstLcaseS(objKeyField.FldName_Java));

            strBuilder.Append("\r\n int iResult = 0;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n iResult = objPS.executeUpdate();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException e)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw e;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objPS = null;");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return iResult;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n");
            ///�޸ļ�¼ == = ;
            return strBuilder.ToString();
        }

        public string gfunUpdate_neusoft()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�޸ļ�¼------------------;
            strBuilder.Append("\r\n public int Update_neusoft()");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, OPException {");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n boolean bolIsFirst = true;");
            strBuilder.Append("\r\n ArrayList paramList = new ArrayList();");
            strBuilder.AppendFormat("\r\n strSQL = \"update {0} set \";", objPrjTabENEx.TabName, objPrjTabENEx.TabSpace);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.KeyField_02)
                {
                    strBuilder.AppendFormat("\r\n if (hmProperty.containsKey(\"{0}\"))",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n {");
                    strBuilder.Append("\r\n if (bolIsFirst == true)");
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\n strSQL += \"{0} = ?\";",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n bolIsFirst = false;");
                    strBuilder.Append("\r\n }");
                    strBuilder.Append("\r\n else");
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\n strSQL += \", {0} = ?\";",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n }");
                    strBuilder.AppendFormat("\r\n paramList.add({0});",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName));
                    strBuilder.Append("\r\n }");

                    //					if (bolIsFirst == true)
                    //					{
                    //						bolIsFirst = false;
                    //						strBuilder.AppendFormat("\r\n strSQL += \"{0} = ?\";", objField.ObjFieldTabENEx.FldName);
                    //					}
                    //					else
                    //					{
                    //						strBuilder.AppendFormat("\r\n strSQL += \", {0} = ? \";", objField.ObjFieldTabENEx.FldName);
                    //					}
                }
            }
            strBuilder.AppendFormat("\r\n strSQL += \" where {0} = ?\";", objKeyField.FldName);

           
            strBuilder.AppendFormat("\r\n paramList.add({0});",
            clsString.FstLcaseS(objKeyField.FldName));

            strBuilder.Append("\r\n Object[] params = new Object[paramList.size()];");
            strBuilder.Append("\r\n paramList.toArray(params);");
            strBuilder.Append("\r\n int iResult = pm.executeUpdate(strSQL, params);");
            strBuilder.Append("\r\n return iResult;");

            strBuilder.Append("\r\n }");
            ///�޸ļ�¼ == = ;
            return strBuilder.ToString();
        }
        public string gfunUpdateBatch_neusoft()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�޸ļ�¼------------------;
            strBuilder.Append("\r\n public int[] UpdateBatch_neusoft(List lstKey, String strCondition)");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, OPException {");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n boolean bolIsFirst = true;");
            strBuilder.Append("\r\n int[] rows;");

            strBuilder.AppendFormat("\r\n strSQL = \"update {0} set \";", objPrjTabENEx.TabName, objPrjTabENEx.TabSpace);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId != enumFieldType.KeyField_02)
                {
                    strBuilder.AppendFormat("\r\n if (hmProperty.containsKey(\"{0}\"))",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n {");
                    strBuilder.Append("\r\n if (bolIsFirst == true)");
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\n strSQL += \"{0} = {1}\";",
                    objField.ObjFieldTabENEx.FldName,
                    getValueStr(objField));
                    strBuilder.Append("\r\n bolIsFirst = false;");
                    strBuilder.Append("\r\n }");
                    strBuilder.Append("\r\n else");
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\n strSQL += \", {0} = {1}\";",
                    objField.ObjFieldTabENEx.FldName,
                    getValueStr(objField));
                    strBuilder.Append("\r\n }");
                    strBuilder.Append("\r\n }");

                    //					if (bolIsFirst == true)
                    //					{
                    //						bolIsFirst = false;
                    //						strBuilder.AppendFormat("\r\n strSQL += \"{0} = ?\";", objField.ObjFieldTabENEx.FldName);
                    //					}
                    //					else
                    //					{
                    //						strBuilder.AppendFormat("\r\n strSQL += \", {0} = ? \";", objField.ObjFieldTabENEx.FldName);
                    //					}
                }
            }


            strBuilder.Append("\r\n if (strCondition == \"\")");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL += \" where {0} = ?\";", objKeyField.FldName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL += \" where \" + strCondition + \" and {0} = ?\";", objKeyField.FldName);
            strBuilder.Append("\r\n }");


            strBuilder.Append("\r\n rows = pm.executeUpdateBatch(strSQL, lstKey);");
            strBuilder.Append("\r\n return rows;");

            strBuilder.Append("\r\n }");
            ///�޸ļ�¼ == = ;
            return strBuilder.ToString();
        }

        public string gfunUpdateMultiRec()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�������޸Ķ�����¼------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:�޸Ķ�����¼");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\"></param>");
            strBuilder.Append("\r\n/// <returns></returns>");
            strBuilder.Append("\r\npublic int UpdateMultiRec(string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataAdapter objDA ;");
            strBuilder.Append("\r\nSystem.Data.DataSet objDS = new System.Data.DataSet();");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlCommandBuilder objCB ;");
            strBuilder.Append("\r\n//			System.Data.DataRow objRow ;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount;");
            strBuilder.Append("\r\nif (strCondition == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0; //��ʾɾ��0����¼,ʵ�����ǲ��ܸñ�����м�¼");
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\nstrSQL = \"Select * from {0} where \" + strCondition;",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\nobjDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);");
            strBuilder.AppendFormat("\r\nobjDA.Fill(objDS, \"{0}\");",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nif (objDS.Tables[\"{0}\"].Rows.Count == 0)",
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
                if ((objField.ObjFieldTabENEx.IsIdentity == false) && (objField.FieldTypeId != enumFieldType.KeyField_02))
                {
                    strBuilder.AppendFormat("\r\nobjRow[\"{0}\"] = {1};",
                    objField.ObjFieldTabENEx.FldName, clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName));
                }
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
        public string gGetRecCount()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡ���еļ�¼��---------------------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:��ȡ��ǰ��ļ�¼��.�ñ��뵱ǰ����ء�");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic int GetRecCount()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(CurrTabName);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gGetRecCount_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:��ȡ��ǰ��ļ�¼��.�ñ��뵱ǰ����ء�");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strTabName\">�������ı���</param>");
            strBuilder.Append("\r\n/// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic static int GetRecCount(string strTabName)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(strTabName);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:��ȡ��ǰ�������������ļ�¼��");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strCondtion\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n/// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic int clsGeneralTab2.GetRecCountByCond(string strCondtion)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(CurrTabName, strCondtion);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gGetRecCountByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:��ȡ�����������������ļ�¼��");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strTabName\">�������ı���</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondtion\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n/// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\npublic static int clsGeneralTab2.GetRecCountByCond(string strTabName, string strCondtion)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.GetRecCount(strTabName, strCondtion);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///��ȡ���еļ�¼�� == == == ;
            return strBuilder.ToString();
        }
        public string gfunfunSetFldValue4String()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����/��ȡ���еķ���������ĳ�ֶε�ֵ------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:���õ�ǰ���еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n/// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n/// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int clsGeneralTab2.SetFldValue(string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, strValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gfunfunSetFldValue4Float()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:���õ�ǰ���еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n/// <param name = \"fltValue\">ֵ</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n/// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int clsGeneralTab2.SetFldValue(string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, fltValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunfunSetFldValue4Int()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:���õ�ǰ���еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n/// <param name = \"intValue\">ֵ</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n/// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int clsGeneralTab2.SetFldValue(string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.SetFldDataOfTable(\"{0}\", strFldName, intValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunfunSetFldValue4String_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:���ø������еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n/// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n/// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic static int clsGeneralTab2.SetFldValue(string strTabName, string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, strValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunfunSetFldValue4Int_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:���ø������еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n/// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n/// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic static int clsGeneralTab2.SetFldValue(string strTabName, string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, intValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunfunSetFldValue4Float_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:���ø������еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n/// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n/// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic static int clsGeneralTab2.SetFldValue(string strTabName, string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, fltValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gGetFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:��ȡ��ǰ���еķ���������ĳ�ֶε�ֵ,���б���");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n/// <returns>��ȡ���ֶ�ֵ�б�</returns>");
            strBuilder.Append("\r\npublic ArrayList clsGeneralTab2.GetFldValue(string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\nArrayList arrList = objSQL.GetFldDataOfTable(\"{0}\", strFldName, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gGetFldValue_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:��ȡ�������еķ���������ĳ�ֶε�ֵ,���б���");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n/// <returns>��ȡ���ֶ�ֵ�б�</returns>");
            strBuilder.Append("\r\npublic static ArrayList clsGeneralTab2.GetFldValue(string strTabName, string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nArrayList arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);");
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///����/��ȡ���еķ���������ĳ�ֶε�ֵ == = ;
            return strBuilder.ToString();
        }
        public string gfunDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ����¼------------------;
            strBuilder.Append("\r\npublic int DelRecord() ");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n String strSQL = \"\";");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            //			if ( objFKSet.GetDelFKTab != \")
            //										 {
            //											 strBuilder.Append("\r\n//ɾ����" + objPrjTabENEx.TabName + "���йص�������е�����");
            //											 strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strBuilder.Append("\r\n//ɾ��" + objPrjTabENEx.TabName + "�������뵱ǰ�����йصļ�¼");
            strBuilder.AppendFormat("\r\n strSQL = strSQL + \"Delete from {0} \";",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.AppendFormat(" strSQL += \" where {0} = ?\";", objKeyField.FldName);
            strBuilder.Append("\r\n PreparedStatement objPS = objSQL.getPreparedStmt(strSQL);");
            strBuilder.Append("\r\n // PreparedStatement objPS = objSQL.getCallableStmt(strSQL);");
            strBuilder.Append("\r\n objPS.clearParameters();");

            int intFieldNo = 1;
            strTemp = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType;
            clsString.FstUcase_S(ref strTemp);
            if (strTemp == "Long")
            {
                strBuilder.AppendFormat("\r\n objPS.set{0}({1}, objViewInfoENEx.{2}); ",
                strTemp, intFieldNo, clsString.FstLcaseS(objKeyField.FldName_Java));
            }
            else if (strTemp == "Int")
            {
                strBuilder.AppendFormat("\r\n objPS.set{0}({1}, objViewInfoENEx.{2}); ",
                strTemp, intFieldNo, clsString.FstLcaseS(objKeyField.FldName_Java));
            }
            else
            {
                strBuilder.AppendFormat("\r\n objPS.set{0}({1}, objViewInfoENEx.{2}); ",
                strTemp, intFieldNo, clsString.FstLcaseS(objKeyField.FldName_Java));
            }
            intFieldNo += 1;
            strBuilder.Append("\r\n int iResult = 0;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n iResult = objPS.executeUpdate();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException e)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw e;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objPS = null;");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return iResult;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n");
            ///ɾ����¼ == = ;
            return strBuilder.ToString();
        }
        public string gfunDelMultiRec_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��һЩ��¼------------------;
            strBuilder.Append("\r\n//ͬʱɾ��������¼");
            strTemp = string.Format("public static int Del{0}(List<string> lstKey)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n String strKeyList;");
            strBuilder.Append("\r\n if (lstKey.size() == 0) return 0;");
            strBuilder.Append("\r\n strKeyList = \"\";");
            strBuilder.Append("\r\n int i = 0;");
            strBuilder.Append("\r\n Iterator e = lstKey.iterator();");
            strBuilder.Append("\r\n while(e.hasNext())");
            strBuilder.Append("\r\n {");
            ///				if ( (i == 0) strKeyList += "'" + lstKey[i].ToString() + "'";
            ///				else strKeyList += ", " + "'" + lstKey[i].ToString() + "'";
            if (objPrjTabENEx.arrKeyFldSet.Count == 0)
            {
                strBuilder.Append("\r\n//��ı�" + objPrjTabENEx.TabName + " ��û�йؼ���,��������һ���ؼ���!");
            }
            else
            {
                strBuilder.Append("\r\nif (i == 0) strKeyList = strKeyList + " + Mark(objPrjTabENEx.objKeyField0) + " + e.toString() + " + Mark(objPrjTabENEx.objKeyField0) + ";");
                strBuilder.Append("\r\nelse strKeyList += \",\" + " + Mark(objPrjTabENEx.objKeyField0) + " + e.toString() + " + Mark(objPrjTabENEx.objKeyField0) + ";");
                strBuilder.Append("\r\n i++;");
                strBuilder.Append("\r\n}");
            }
            strBuilder.Append("\r\nstrSQL = \"\";");
            //				if ( objFKSet.GetDelFKTab != \")
            //											 {
            //												 strBuilder.Append("\r\n//ɾ����" + objPrjTabENEx.TabName + "���йص�������е�����");
            //					foreach(clsForeignKey objForeignKey in arrForeignKeySet)
            //					{	 
            //						strBuilder.Append("\r\nstrSQL = strSQL + \"Delete " + objFK.FKTABLE_NAME + " where " + objKeyField.ColumnName + " in (\" + strKeyList + \")"";");
            //					}
            //			}
            strBuilder.Append("\r\n//ɾ��" + objPrjTabENEx.TabName + "�������뵱ǰ�����йصļ�¼");
            if (objPrjTabENEx.arrKeyFldSet.Count == 0)
            {
                strBuilder.Append("\r\n//��ı�" + objPrjTabENEx.TabName + " ��û�йؼ���,��������һ���ؼ���!");
                strBuilder.Append("\r\nreturn false;");
            }
            else
            {
                strBuilder.AppendFormat("\r\nstrSQL = strSQL + \"Delete from {0} where " + objKeyField.FldName + " in (\" + strKeyList + \")\";",
                objPrjTabENEx.TabName,
                objPrjTabENEx.TabSpace);
                strBuilder.Append("\r\n int iResult = 0;");
                strBuilder.Append("\r\n try");
                strBuilder.Append("\r\n {");
                strBuilder.Append("\r\n iResult = objSQL.execSQL(strSQL);");
                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n catch (SQLException e1)");
                strBuilder.Append("\r\n {");
                strBuilder.Append("\r\n throw e1;");
                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n finally");
                strBuilder.Append("\r\n {");
                strBuilder.Append("\r\n objSQL.close();");
                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n return iResult;");
            }
            strBuilder.Append("\r\n}");
            ///ɾ��һЩ��¼ == = ;
            return strBuilder.ToString();
        }

        public string gfunDelMultiRec_neusoft()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��һЩ��¼------------------;
            strBuilder.Append("\r\n//ͬʱɾ��������¼");
            strTemp = string.Format("public int[] Del{0}s_neusoft(List lstKey)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n throws OPException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n int[] rows;");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.AppendFormat("\r\n strSQL = \"Delete from {0} where {1} = ? \";",
            objPrjTabENEx.TabName, objKeyField.FldName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n rows = pm.executeUpdateBatch(strSQL, lstKey);");
            strBuilder.Append("\r\n return rows;");
            strBuilder.Append("\r\n }");

            ///ɾ��һЩ��¼ == = ;
            return strBuilder.ToString();
        }


        public string gfunDelRecord_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��һ����¼-----------------;
            strBuilder.Append("\r\n" + string.Format("public static int DelRecord({0} {1}) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, objKeyField.PrivFuncName));
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//ɾ��������¼");
            strBuilder.Append("\r\n String strSQL = \"\";");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            //			if ( objFKSet.GetDelFKTab != \")
            //			{
            //				strBuilder.Append("\r\n//ɾ����" + objPrjTabENEx.TabName + "���йص�������е�����");
            //				strBuilder.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab2 + ";");
            //			}
            strTemp = string.Format("//ɾ��{0}�������뵱ǰ�����йصļ�¼",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.AppendFormat("\r\nstrSQL = strSQL + \"Delete from {0} where " + KeyWhereStr(false, objPrjTabENEx) + ";",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n int iResult = 0;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n iResult = objSQL.execSQL(strSQL);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException e1)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw e1;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return iResult;");
            strBuilder.Append("\r\n}");
            ///ɾ��һ����¼ == = ;
            return strBuilder.ToString();
        }
        public string gfunDelCondRec_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��������¼,ɾ���������ļ�¼------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:ɾ��������¼,��������ɾ��");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">��Ҫɾ���ļ�¼����</param>");
            strBuilder.Append("\r\n/// <returns>����ɾ���ļ�¼����</returns>");
            strBuilder.AppendFormat("\r\npublic static int Del{0}(String strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException , NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n if (strCondition == \"\")");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n return 0;	//��ʾɾ��0����¼,ʵ�����ǲ��ܸñ�����м�¼");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\nstrSQL = \"Delete from {0} where \" + strCondition ;",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n int iResult = 0;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n iResult = objSQL.execSQL(strSQL);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException e1)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw e1;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return iResult;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n ");
            ///ɾ��������¼,ɾ���������ļ�¼ == = ;
            return strBuilder.ToString();
        }
        public string gGetRecValue()
        {
            // public boolean GetAA() throws SQLException, ClassNotFoundException, NamingException {
            // String strSQL;
            // Object[] objAa1 = new Object[1];
            // objAa1[0] = objViewInfoENEx.aa1;
            // strSQL = " Select * from MDF.AA where aa1 = '" + aa1 + "'";
            // ResultSet objRS;
            // clsSpecSQL objSQL = new clsSpecSQL();
            // try {
            // objRS = objSQL.GetResultSet(strSQL);
            // } catch (SQLException ex) {
            // throw new SQLException(String.format("�ؼ���Ϊ:'{0}'������!\r\n", aa1)
            // + ex.getMessage());
            // } finally {
            // }
            // if (objRS == null) {
            // throw new RuntimeException("objRS ����Ϊnull");
            // }
            // if (!objRS.next()) {
            // throw new RuntimeException("objRS ����û������");
            // }
            // ResultSetMetaData metaData = objRS.getMetaData();
            // //int intColumns = metaData.getColumnCount(); // ������Ž����������

            // if (objRS.next()) {
            // aa1 = objRS.getString("aa1").toString();
            // aa2 = objRS.getString("aa2").toString();
            // }
            // return true;
            //}

            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ�ؼ�ֵ�ļ�¼-----------------------------;
            strBuilder.Append("\r\npublic boolean Get" + objPrjTabENEx.TabName + "()");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n String strSQL ;");
            strBuilder.Append("\r\n String strResult = \" \";");
            strBuilder.Append("\r\n ResultSet objRS = null;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\n strSQL = \" Select * from {0} where {1};",
            objPrjTabENEx.TabName, KeyWhereStr(),
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n try {");
            strBuilder.Append("\r\n objRS = objSQL.GetResultSet(strSQL, strResult);");
            strBuilder.Append("\r\n if (objRS.next()) {");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.FldName.ToUpper() != objKeyField.FldName.ToUpper())
                {
                    strTemp = objField.JavaType;
                    clsString.FstUcase_S(ref strTemp);
                    strBuilder.AppendFormat("\r\n objViewInfoENEx.{0} = objRS.get{1}(\"{2}\");",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java), strTemp, objField.ObjFieldTabENEx.FldName);
                }
            }
            strBuilder.Append("\r\n objRS.close();");
            strBuilder.Append("\r\n return true;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n } catch (SQLException ex) {");
            strBuilder.Append("\r\n throw ex;");
            strBuilder.Append("\r\n } finally {");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return false;");
            strBuilder.Append("\r\n }");
            //��ȡĳһ�ؼ�ֵ�ļ�¼ == == = ;
            return strBuilder.ToString();
        }

        public string gGetRecValue_neusoft()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ�ؼ�ֵ�ļ�¼-----------------------------;
            strBuilder.Append("\r\npublic boolean Get" + objPrjTabENEx.TabName + "()");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n DataSet ds = null;");
            strBuilder.AppendFormat("\r\n Object[] obj{0} = new Object[1];",
            clsString.FirstUcaseS(objKeyField.FldName));
            strBuilder.AppendFormat("\r\n obj{0}[0] = objViewInfoENEx.{1};",
            clsString.FirstUcaseS(objKeyField.FldName),
            clsString.FstLcaseS(objKeyField.FldName));
            strBuilder.AppendFormat("\r\n strSQL = \" Select * from {0} where {1} = ?\";",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n try ");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n ds = pm.executeQuery(strSQL, obj{0});",
            clsString.FirstUcaseS(objKeyField.FldName));
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (OPException ex) ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw ex;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (ds == null) ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw new RuntimeException(\"DataSet ����Ϊnull\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n if (!ds.next()) ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw new RuntimeException(\"DataSet ����û������\");");
            strBuilder.Append("\r\n }");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.FldName.ToUpper() != objKeyField.FldName.ToUpper())
                {
                    strTemp = objField.JavaType;
                    clsString.FstUcase_S(ref strTemp);
                    if (strTemp == "Int" || strTemp == "Double" || strTemp == "Long")
                    {
                        strBuilder.AppendFormat("\r\n {4} {0}{1} = ds.get{2}(\"{3}\");",
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                        clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName),
                        strTemp,
                        objField.ObjFieldTabENEx.FldName,
                        objField.JavaType);
                        strBuilder.AppendFormat("\r\n objViewInfoENEx.{0} = new {1}({2}{3});",
                        clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName),
                        objField.JavaType,
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                        clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName));
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n objViewInfoENEx.{0} = ds.get{1}(\"{2}\");",
                        clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName),
                        strTemp,
                        objField.ObjFieldTabENEx.FldName);
                    }
                }
            }
            strBuilder.Append("\r\n return true;");
            strBuilder.Append("\r\n }");

            //��ȡĳһ�ؼ�ֵ�ļ�¼ == == = ;
            return strBuilder.ToString();
        }

        public string gGetCondRecSet_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\n public ResultSet Get{0}(String strCondition)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n String strSQL; ");
            strBuilder.Append("\r\n String strResult = \" \"; ");
            strBuilder.Append("\r\n ResultSet objRS; ");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\n strSQL = \"Select * from {0} where \" + strCondition;",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n try {");
            strBuilder.Append("\r\n objRS = objSQL.GetResultSet(strSQL, strResult);");
            strBuilder.Append("\r\n } catch (SQLException ex) {");
            strBuilder.Append("\r\n throw ex;");
            strBuilder.Append("\r\n } finally {");
            strBuilder.Append("\r\n //			objRS = null;");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return objRS;");
            strBuilder.Append("\r\n }");


            //��ȡĳһ����ֵ�ļ�¼�� == == = ;
            return strBuilder.ToString();
        }

        public string gGetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\npublic ArrayList<cls{0}> GetObjLst(String strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nArrayList<cls{0}> arrObjLst = new ArrayList<cls{0}>(); ",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n ResultSet objRS = null;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");

            strBuilder.AppendFormat("\r\n strSQL = \" Select * from {0} where \" + strCondition;",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n try ");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n objRS = objSQL.GetResultSet(strSQL);",
            clsString.FirstUcaseS(objKeyField.FldName));
            strBuilder.Append("\r\n if (objRS == null) ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw new RuntimeException(\"objRS ����Ϊnull\");");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n while(objRS.next())");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n	cls{0} obj{0} = new cls{0}();",
            objPrjTabENEx.TabName);

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strTemp = objField.JavaType;
                clsString.FstUcase_S(ref strTemp);

                strBuilder.AppendFormat("\r\n" + "obj{0}.set{1}(objRS.get{2}(\"{3}\"));",
                objPrjTabENEx.TabName,
                clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName_Java),
                strTemp,
                objField.ObjFieldTabENEx.FldName);
                //}

            }
            strBuilder.AppendFormat("\r\n	arrObjLst.add(obj{0});",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException ex) ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw new SQLException(String.format(\"����Ϊ:'{0}'��¼������!\\r\\n\", strCondition) + ex.getMessage());");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n objSQL.close();");

            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n return arrObjLst;");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == == = ;
            return strBuilder.ToString();
        }
     
        public string gGetCondRecSetT_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ������DataTable,���еĴ���ת������Ӧ������------------------------;
            if (objPrjTabENEx.IsNeedTransCode)
            {
                strBuilder = new StringBuilder();
                strBuilder.Append("\r\n");
                strBuilder.Append("\r\n/// <summary>");
                strBuilder.Append("\r\n/// ����:��ȡĳһ������DataTable,���еĴ���ת������Ӧ������");
                strBuilder.Append("\r\n/// </summary>");
                strBuilder.Append("\r\n/// <param name = \"strCondition\">������</param>");
                strBuilder.Append("\r\n/// <returns>�����Ѿ�ת�������DataTable</returns>");



                strBuilder.AppendFormat("\r\npublic static ResultSet Get{0}T(String strCondition)",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n throws SQLException, ClassNotFoundException , NamingException ");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\nStringBuffer strSQL = new StringBuffer(); ");
                strBuilder.Append("\r\nResultSet objRS = null; ");
                strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
                strBuilder.AppendFormat("\r\nstrSQL.append(\"Select {0}.* \");", objPrjTabENEx.TabName);
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
                            sbTabName.AppendFormat("\r\nstrSQL.append(\" from {0}, {1}\");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.CodeTabName);
                            sbWhereStr.AppendFormat("\r\nstrSQL.append(\" where {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.CodeTabName, objField.ObjFieldTabENEx.CodeTabCode);
                            bolIsFirst = false;
                        }
                        else
                        {
                            sbTabName.AppendFormat("\r\nstrSQL.append(\" , {0} \");",
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbWhereStr.AppendFormat("\r\nstrSQL.append(\" && {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, 
                            objField.ObjFieldTabENEx.CodeTabName, objField.ObjFieldTabENEx.CodeTabCode);
                        }
                        if (bolIsSelfLink == true)
                        {
                            sbFldStr.AppendFormat("\r\nstrSQL.append(\", {0}Self.{1} {2}{3} \");",
                            objField.ObjFieldTabENEx.CodeTabName, 
                            objField.ObjFieldTabENEx.CodeTabName, 
                            objField.ObjFieldTabENEx.CodeTabName, 
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbLeftJoinStr.AppendFormat("\r\nstrSQL.append(\" left JOIN {2} {2}Self on {0}.{1} = {2}Self.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, 
                            objField.ObjFieldTabENEx.CodeTabName, objField.ObjFieldTabENEx.CodeTabCode);
                        }
                        else
                        {
                            sbFldStr.AppendFormat("\r\nstrSQL.append(\", {0}.{1} {2}{3} \");",
                            objField.ObjFieldTabENEx.CodeTabName, 
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabName, 
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbLeftJoinStr.AppendFormat("\r\nstrSQL.append(\" left JOIN {2} on {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.CodeTabName, objField.ObjFieldTabENEx.CodeTabCode);
                        }
                    }
                }

                strBuilder.Append(sbFldStr.ToString());
                strBuilder.AppendFormat("\r\nstrSQL.append(\" from {0} \");",
                objPrjTabENEx.TabName);
                strBuilder.Append(sbLeftJoinStr.ToString());
                /// strBuilder.Append(sbTabName.ToString());
                /// strBuilder.Append(sbWhereStr.ToString());
                strBuilder.Append("\r\nstrSQL.append(\" where \" + strCondition); ");
                strBuilder.Append("\r\nobjRS = objSQL.GetResultSet(strSQL.toString());");
                strBuilder.Append("\r\nreturn objRS;");
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
        public string gGetCondRecSetV_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ��������ر���ͼ(View)------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:��ȡĳһ��������ر���ͼ(View)");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n/// <returns>�����Ѿ�ת�������DataTable</returns>");
            strBuilder.AppendFormat("\r\npublic static ResultSet Get{0}V(String strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nStringBuffer strSQL = new StringBuffer(); ");
            strBuilder.Append("\r\nResultSet objRS = null; ");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\nstrSQL.append(\"Select v{0}.* \");", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstrSQL.append(\" from v{0} \");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nstrSQL.append(\" where \" + strCondition); ");
            strBuilder.Append("\r\nobjRS = objSQL.GetResultSet(strSQL.toString());");
            strBuilder.Append("\r\nreturn objRS;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///��ȡĳһ������DataTable,���еĴ���ת������Ӧ������ == = ;
            return strBuilder.ToString();
        }


        public string gGetPrimaryKeyID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ�����Ĺؼ����б�-----------------------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:��ȡĳһ�����Ĺؼ����б�");
            strBuilder.Append("\r\n///		 �����ؼ����Ƕ��,�����ؼ���֮����\"//\"����");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strCondtion\">������</param>");
            strBuilder.Append("\r\n/// <returns>�ؼ����б�</returns>");
            strBuilder.Append("\r\npublic static ArrayList GetPrimaryKeyID(string strCondtion) ");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nResultSet objRS ;");
            strBuilder.Append("\r\nArrayList arrList = new ArrayList();");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.Append("\r\nstring strKeyValue; ");
            strBuilder.AppendFormat("\r\nstrSQL = \"Select {0} from {1} where \" + strCondtion;",
            objKeyField.FldName, objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\ntry");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjRS = objSQL.GetResultSet(strSQL);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//				clsGeneralTab2. LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n//				objRS = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nif (objRS.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjRS = null;");
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfor (iRow = 0; iRow<= objRS.Rows.Count - 1;iRow++)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue = \"\";");
            strBuilder.Append("\r\nfor (iCol = 0; iCol<= objRS.Columns.Count - 1;iCol++)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (iCol == 0)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue += objRS.Rows[iRow][iCol].toString();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrKeyValue += \"//\" + objRS.Rows[iRow][iCol].toString();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\narrList.Add(strKeyValue);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nobjRS = null;");
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///��ȡĳһ�����Ĺؼ����б� == == == ;
            return strBuilder.ToString();
        }
        public string gGetFileFromTabField()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�ϴ��ļ��Լ������ļ���ش���------------------------------------ ;
            if (mbolIsHaveImageField == true)
            {
                strBuilder = new StringBuilder();
                strBuilder.Append("\r\n/// <summary>");
                strBuilder.Append("\r\n/// ����:�����ݿ���ֶ��л�ȡ����,���Ҵ�����ļ��С�");
                strBuilder.Append("\r\n///		˵��:���¼����Ϊ��ǰ��������Ӧ�ļ�¼��");
                strBuilder.Append("\r\n/// </summary>");
                strBuilder.Append("\r\n/// <param name = \"strDownLoadFileName\">��ȡ���ݺ�,�����˵��ļ�����</param>");
                strBuilder.Append("\r\n/// <returns>����ɹ���ȡ�ͷ���TRUE,����ΪFALSE</returns>");
                strBuilder.Append("\r\npublic boolean GetFileFromTabField(string strDownLoadFileName)");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\nSpecData.clsSpecSQL objSQL = new SpecData.clsSpecSQL();");
                strBuilder.AppendFormat("\r\nstring strTabName = \"{0}\";", objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\nstring strFldName = \"{0}\";", mstrImageFieldName);
                strBuilder.Append("\r\nStringBuffer strCondition = new StringBuffer();");
                /// strBuilder.Append("\r\nstrCondition.AppendFormat(\"Stdid = '{0}'\", objViewInfoENEx.Stdid);");
                strBuilder.Append("\r\nstrCondition.AppendFormat(\" ");
                strBuilder.AppendFormat("{0}", objKeyField.FldName);
                strBuilder.Append(" = '{0}'\", ");
                strBuilder.AppendFormat("{0});", clsString.FstLcaseS(objKeyField.FldName));
                strBuilder.Append("\r\nobjSQL.GetFile(strDownLoadFileName,strTabName, strFldName, strCondition.toString());");
                strBuilder.Append("\r\nreturn true;");
                strBuilder.Append("\r\n}");
            }
            return strBuilder.ToString();
        }

        public string gfunStoreFileToTabField()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:�洢�ļ������ļ��洢�����ݿ���ֶ��С�");
            strBuilder.Append("\r\n///		˵��:���¼����Ϊ��ǰ��������Ӧ�ļ�¼��");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strUpLoadFileName\">��Ҫ�洢���ļ���</param>");
            strBuilder.Append("\r\n/// <returns>����ɹ��ͷ���TRUE,���򷵻�FALSE</returns>");
            strBuilder.Append("\r\npublic boolean StoreFileToTabField(string strUpLoadFileName)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nstring strTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strFldName = \"{0}\";", mstrImageFieldName);
            strBuilder.Append("\r\nStringBuffer strCondition = new StringBuffer();");
            strBuilder.Append("\r\nstrCondition.AppendFormat(\" ");
            strBuilder.AppendFormat("{0}", objKeyField.FldName);
            strBuilder.Append(" = '{0}'\", ");
            strBuilder.AppendFormat("{0});", clsString.FstLcaseS(objKeyField.FldName));
            strBuilder.Append("\r\nSpecData.clsSpecSQL objSQL = new SpecData.clsSpecSQL();");
            strBuilder.Append("\r\nobjSQL.StoreFile(strUpLoadFileName,strTabName, strFldName, strCondition.toString());");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunShowPic_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:��ʾͼƬ����ʾ��ؼ�����ؼ�¼��ͼƬ");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"imgPic\">��Ҫ��ʾͼƬ��image�ؼ�</param>");
            strBuilder.AppendFormat("\r\n/// <param name = \"{0}\">��¼�ؼ��ֵ�ֵ</param>",
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n/// <param name = \"strWebFileDir\">����WEB��ʾ���ļ�·��,��URL</param>");
            strBuilder.Append("\r\n/// <param name = \"strDownloadFileDir\">���������ļ�ʱ,��WEB���������ļ���Ŀ¼</param>");
            strBuilder.Append("\r\npublic static void ShowPic(System.Web.UI.WebControls.Image imgPic, ");
            strBuilder.AppendFormat("\r\n{0} {1}, ",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\nstring strWebFileDir, ");
            strBuilder.Append("\r\nstring strDownloadFileDir)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nimgPic.ImageUrl = \"\";");
            strBuilder.AppendFormat("\r\nif (cls{0}.IsExist({1}) == true)",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\ncls{0} obj{0} = new cls{0}({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\nobj{0}.Get{0}();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strFileName = obj{0}.FileName;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (strFileName != \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strDownLoadFileName = strDownloadFileDir + strFileName;");
            strBuilder.AppendFormat("\r\nobj{0}.GetFileFromTabField(strDownLoadFileName);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nimgPic.ImageUrl = strWebFileDir + strFileName;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gGetFileFromTabField_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:�����ݿ���ֶ��������ļ����ݡ��ú����Ǿ�̬(static)������");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strDownLoadFileName\">�������ص��ļ���</param>");
            strBuilder.AppendFormat("\r\n/// <param name = \"{0}\">��¼�ؼ��ֵ�ֵ</param>",
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n/// <param name = \"strDownloadFileDir\">���������ļ�ʱ,��WEB���������ļ���Ŀ¼</param>");
            strBuilder.Append("\r\npublic static boolean GetFileFromTabField(string strDownLoadFileName, ");
            strBuilder.AppendFormat("\r\n{0} {1}, ",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\nstring strDownloadFileDir)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nif (cls{0}.IsExist({1}) == true)",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\ncls{0} obj{0} = new cls{0}({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\nobj{0}.Get{0}();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strFileName = obj{0}.FileName;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nif (strFileName != \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstrDownLoadFileName = strDownloadFileDir + strFileName;");
            strBuilder.AppendFormat("\r\nobj{0}.GetFileFromTabField(strDownLoadFileName);",
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

            ///�ϴ��ļ��Լ������ļ���ش��� == == == ;
            return strBuilder.ToString();
        }
        public string gGetDataTable_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһSQL����DataTable---------------------------;
            strBuilder.Append("\r\npublic static ResultSet GetResultSet(string strSql)");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nResultSet objRS; ");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nobjRS = objSQL.GetResultSet(strSql);");
            strBuilder.Append("\r\nreturn objRS;");
            strBuilder.Append("\r\n}");
            ///��ȡĳһSQL����DataTable == == ;
            return strBuilder.ToString();
        }
        public string gfunIsExist()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�����ݿ����Ƿ���ڵ�ǰ����-----------------------;
            strBuilder.Append("\r\n public boolean IsExist()");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"" + KeyWhereStr() + "))");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            ///�����ݿ����Ƿ���ڵ�ǰ���� == == ;
            return strBuilder.ToString();
        }
        public string gfunIsExist_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�����ݿ����Ƿ���ڵ�ǰ����(������̺���)-----------------------;
            ///objField.ObjFieldTabENEx.PrivFuncName;
            int i = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                if (i == 0)    //�Ƿ��ǵ�һ��
                {
                    strTemp = objField.JavaType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else
                {
                    strTemp += ", " + objField.JavaType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                i++;
            }
            strBuilder.Append("\r\npublic static boolean IsExist(" + strTemp + ")");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"" + KeyWhereStr(false, objPrjTabENEx) + "))");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            ///�����ݿ����Ƿ���ڵ�ǰ����(������̺���) == == ;
            return strBuilder.ToString();
        }
        public string gfunIsExistCondRec_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:�ж��Ƿ����ĳһ�����ļ�¼");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n/// <returns>������ھͷ���TRUE,���򷵻�FALSE</returns>");
            strBuilder.Append("\r\npublic static boolean IsExistCondRec(string strCondition)");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
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
        public string gfunCheckProperty()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\npublic boolean CheckProperty(String strResult)");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabNullable == false && objField.ObjFieldTabENEx.IsIdentity == false)
                {
                    if (objField.JavaType != "int" && objField.JavaType != "boolean")
                    {
                        strBuilder.AppendFormat("\r\n if ((null == {0}) || (null != {0}) && ({0}.toString() == \"\")",
                        clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java));
                        if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                        {
                            strBuilder.AppendFormat("\r\n || (null != {0}) && ({0}.toString() == \"0\")",
                            clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java));
                        }
                        strBuilder.Append(")");
                        strBuilder.Append("\r\n{");
                        strBuilder.Append("\r\nstrResult = \"�ֶ�[" + objField.ColCaption + "]����Ϊ��(NULL)!\";");
                        strBuilder.Append("\r\nreturn false;");
                        strBuilder.Append("\r\n}");
                    }
                }
            }
            ///������Գ��ȴ���;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaObjType == "String" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strBuilder.AppendFormat("\r\nif ((null != {0}) && (GetStrLen({0}) > {1})",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java), objField.ObjFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append(")");
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n strResult = \"�ֶ�[{0}]�ĳ��Ȳ��ܳ���{1}!\";",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append("\r\n return false;");
                    strBuilder.Append("\r\n }");
                }
            }
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///������������Ƿ���ȷ == == == = ;
            return strBuilder.ToString();
        }

        public string gfunCheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\npublic void CheckProperty() throws dbobjexception ");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabNullable == false && objField.ObjFieldTabENEx.IsIdentity == false)
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaObjType != "Integer"
                    && objField.JavaType != "boolean"
                    && objField.JavaType != "float"
                    && objField.JavaType != "double"
                    && objField.JavaType != "long")
                    {
                        strBuilder.AppendFormat("\r\n if ((null == {0}) || (null != {0}) && ({0}.toString() == \"\")",
                        clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java));
                        if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                        {
                            strBuilder.AppendFormat("\r\n || (null != {0}) && ({0}.toString() == \"0\")",
                            clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java));
                        }
                        strBuilder.Append(")");
                        strBuilder.Append("\r\n{");
                        strBuilder.Append("\r\n throw new dbobjexception(\"�ֶ�[" + objField.ColCaption + "]����Ϊ��(NULL)!\");");
                        strBuilder.Append("\r\n}");
                    }
                }
            }
            ///������Գ��ȴ���;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                && objField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaObjType == "String"
                && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strBuilder.AppendFormat("\r\nif ((null != {0}) && (GetStrLen({0}) > {1})",
                    clsString.FstLcaseS(objField.ObjFieldTabENEx.FldName_Java), objField.ObjFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append(")");
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n throw new dbobjexception(\"�ֶ�[{0}]�ĳ��Ȳ��ܳ���{1}!\");",
                    objField.ColCaption,
                    objField.ObjFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append("\r\n }");
                }
            }
            strBuilder.Append("\r\n}");
            ///������������Ƿ���ȷ == == == = ;
            return strBuilder.ToString();
        }

        public string gGetID()
        {

            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n public ArrayList GetID(String strCondtion) ");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n String strSQL ;");
            strBuilder.Append("\r\n ResultSet objRS = null ;");
            strBuilder.Append("\r\n ArrayList<String> arrList = new ArrayList<String> ();");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\n int iCol; ");
            strBuilder.Append("\r\n String strKeyValue; ");
            // strBuilder.AppendFormat("\r\n if (objSQL.IsExistRecord(\"{0}\", \"{1}))",
            //				objPrjTabENEx.TabName, KeyWhereStr(true));
            // strBuilder.Append("\r\n return arrList;");
            strBuilder.AppendFormat("\r\n strSQL = \"Select {0} from {1} where \" + strCondtion;",
            objKeyField.FldName, objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = objSQL.GetResultSet(strSQL);");
            strBuilder.Append("\r\n ResultSetMetaData metaData = objRS.getMetaData();");
            strBuilder.Append("\r\n int intColumns = metaData.getColumnCount(); //������Ž���������� ");
            strBuilder.Append("\r\n int intRsCount = objSQL.GetCount(objRS);//������ŵ�������ļ�¼��");
            strBuilder.Append("\r\n if (intRsCount == 0)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n return null;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n while(objRS.next())");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n strKeyValue = \"\";");
            strBuilder.Append("\r\n for (iCol = 0; iCol<= intColumns - 1;iCol++)");
            strBuilder.Append("\r\n {");
            strTemp = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType;
            clsString.FstUcase_S(ref strTemp);
            strBuilder.Append("\r\n if (iCol == 0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strKeyValue += String.valueOf(objRS.get" + strTemp + "(\"{0}\"));",
            objKeyField.FldName_Java);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strKeyValue += \"//\" + String.valueOf(objRS.get" + strTemp + "(\"{0}\"));",
            objKeyField.FldName_Java);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n arrList.add(strKeyValue);");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw objException;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return arrList;");
            strBuilder.Append("\r\n }");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public string gGetFirstID()
        {

            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.AppendFormat("\r\n public {0} GetFirstID(String strCondtion) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n String strSQL ;");
            strBuilder.Append("\r\n ResultSet objRS = null;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            //			strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.AppendFormat("\r\n {0} {1}KeyValue; ",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.AppendFormat("\r\n strSQL = \"Select " + objPrjTabENEx.Keys + " from {0} where \" + strCondtion;",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n objRS = objSQL.GetResultSet(strSQL);");
            strBuilder.Append("\r\n if (objRS.next()) ");
            strBuilder.Append("\r\n {");
            strTemp = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType;
            clsString.FstUcase_S(ref strTemp);
            strBuilder.AppendFormat("\r\n {2}KeyValue = objRS.get{0}(\"{1}\");",
            strTemp,
            objKeyField.FldName_Java,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaObjType)
            {
                case "Integer":
                    strBuilder.Append("\r\n" + "return 0;");
                    break;
                case "Double":
                    strBuilder.Append("\r\n" + "return 0.0;");
                    break;
                case "Date":
                    strBuilder.Append("\r\n" + "return Date.Parse(strKeyValue);");
                    break;
                case "Boolean":
                    strBuilder.Append("\r\n" + "return Boolean.ParseBoolean(strKeyValue);");
                    break;
                case "Float":
                    strBuilder.Append("\r\n" + "return 0.0f;");
                    break;
                case "Long":
                    strBuilder.Append("\r\n" + "return 0l;");
                    break;
                default:
                    strBuilder.Append("\r\n" + "return \"\";");
                    break;
            }

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n System.out.println(objException.getMessage());");
            strBuilder.Append("\r\n throw objException;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n }");
            strBuilder.AppendFormat("\r\n return {0}KeyValue;",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n ");

            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public string gGetFirstID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.AppendFormat("\r\npublic static {0} GetFirstID_S(String strCondtion) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n String strSQL ;");
            strBuilder.Append("\r\n ResultSet objRS = null;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            //			strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.AppendFormat("\r\n {0} {1}KeyValue; ",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.AppendFormat("\r\n strSQL = \"Select " + objPrjTabENEx.Keys + " from {0} where \" + strCondtion;",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n objRS = objSQL.GetResultSet(strSQL);");
            strBuilder.Append("\r\n if (objRS.next()) ");
            strBuilder.Append("\r\n {");
            strTemp = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType;
            clsString.FstUcase_S(ref strTemp);
            strBuilder.AppendFormat("\r\n {2}KeyValue = objRS.get{0}(\"{1}\");",
            strTemp,
            objKeyField.FldName_Java,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaObjType)
            {
                case "Integer":
                    strBuilder.Append("\r\n" + "return 0;");
                    break;
                case "Double":
                    strBuilder.Append("\r\n" + "return 0.0;");
                    break;
                case "Date":
                    strBuilder.Append("\r\n" + "return Date.Parse(strKeyValue);");
                    break;
                case "Boolean":
                    strBuilder.Append("\r\n" + "return Boolean.ParseBoolean(strKeyValue);");
                    break;
                case "Float":
                    strBuilder.Append("\r\n" + "return 0.0f;");
                    break;
                case "Long":
                    strBuilder.Append("\r\n" + "return 0l;");
                    break;
                default:
                    strBuilder.Append("\r\n" + "return \"\";");
                    break;
            }

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n System.out.println(objException.getMessage());");
            strBuilder.Append("\r\n throw objException;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n objSQL.close();");
            strBuilder.Append("\r\n }");
            strBuilder.AppendFormat("\r\n return {0}KeyValue;",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n ");

            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }


        public string gGetReader()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic System.Data.SqlClient.SqlDataReader GetReader(string strCondtion) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nstring strSQL ;");
            strBuilder.Append("\r\nSystem.Data.SqlClient.SqlDataReader objDR ;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\n" + string.Format("strSQL = \"Select * from {0} where \" + strCondtion;", objPrjTabENEx.TabName));
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
        public string gGetTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///GetTable(����������ȡ���ݱ�);

            strBuilder.Append("\r\n public ResultSet GetResultSet(String strCondtion, String strResult)");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n String strSQL ;");
            strBuilder.Append("\r\n ResultSet objRS ;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\n strSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondtion;");
            strBuilder.Append("\r\n objRS = objSQL.GetResultSet(strSQL, strResult);");
            strBuilder.Append("\r\n return objRS;");
            strBuilder.Append("\r\n }");

            //'GetTable(����������ȡ���ݱ�)
            strBuilder.Append("\r\n public static ResultSet GetResultSet1(String strCondtion, String strResult)");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n String strSQL ;");
            strBuilder.Append("\r\n ResultSet objRS ;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\n strSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondtion;");
            strBuilder.Append("\r\n objRS = objSQL.GetResultSet(strSQL, strResult);");
            strBuilder.Append("\r\n return objRS;");
            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }


        public string gGetTableBySQL()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///GetTableBySQL(����SQL����ȡ���ݱ�)----------------------------------;
            strBuilder.Append("\r\npublic ResultSet GetResultSetBySQL(String strSQL, String strResult) ");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nResultSet objRS ;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nobjRS = objSQL.GetResultSet(strSQL, strResult);");
            strBuilder.Append("\r\nreturn objRS;");
            strBuilder.Append("\r\n}");
            ///GetTableBySQL(����SQL����ȡ���ݱ�) == == == ;
            return strBuilder.ToString();
        }

        public string gfungetStrLen()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡ�ַ�������,���к���Ϊ2���ֽ�,Ӣ��Ϊ1���ֽ�---------;
            strBuilder.Append("\r\npublic int GetStrLen(String strTemp)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nint len ;");
            strBuilder.Append("\r\n//byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);");
            strBuilder.Append("\r\nlen = strTemp.getBytes().length;//will output as 3+3*2 = 9");
            strBuilder.Append("\r\nreturn len;");
            strBuilder.Append("\r\n}");
            ///��ȡ�ַ�������,���к���Ϊ2���ֽ�,Ӣ��Ϊ1��;
            ///˽�к��� == == == ;
            return strBuilder.ToString();
        }
        public string gfunDispose()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������---------------------------------------;
            strBuilder.Append("\r\n public void Dispose()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (mblnDisposed == false)");
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
            ///������������ == == == ;
            return strBuilder.ToString();
        }
        public string gfunLogError()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡ�ַ�������,���к���Ϊ2���ֽ�,Ӣ��Ϊ1���ֽ� == ;
            ///������־;
            strBuilder.Append("\r\ninternal void LogError" + "(Exception objException)");
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
            strBuilder.Append("\r\n+ \"Target Site: \" + objException.TargetSite.toString();");
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

       

        public string gGetTabDict()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��һ����¼-----------------;
            ///
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";

            ///���ɽ��б���;
            //��������ĺ��� ����;
            //��0��:�ѿؼ���������ComboBoxת����ComboBox
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")//�����ֶ�
                {
                    strValueFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "03")//�����ֶ�
                {
                    strTextFieldName = objField.ObjFieldTabENEx.FldName;
                }
            }
            if (strValueFieldName == "" || strTextFieldName == "")
            {
                return "";
            }
            strBuilder.AppendFormat("\r\n public ArrayList<cls{0}> get{0}Dict() throws Exception ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n 		{");
            strBuilder.AppendFormat("\r\nArrayList<cls{0}> arrObjLst = new ArrayList<cls{0}>(); ",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n ResultSet objRS = null;");
            strBuilder.AppendFormat("\r\n strSQL = \"select {0}, {1} from {2} \";",
            strValueFieldName,
            strTextFieldName,
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n clsSpecSQL objSQL = null;");
            strBuilder.Append("\r\n try ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQL();");

            strBuilder.Append("\r\n objRS = GetResultSet(strSQL);");
            strBuilder.Append("\r\n if (objRS == null) ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw new RuntimeException(\"objRS ����Ϊnull\");");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n while(objRS.next())");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n	cls{0} obj{0} = new cls{0}();",
            objPrjTabENEx.TabName);

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.FldName == strValueFieldName ||
                objField.ObjFieldTabENEx.FldName == strTextFieldName)
                {
                    strTemp = objField.JavaType;
                    clsString.FstUcase_S(ref strTemp);
                    //if (strTemp == "Int" || strTemp == "Double" || strTemp == "Long")
                    //{
                    // strBuilder.AppendFormat("\r\n {4} {0}{1} = objRS.get{2}(\"{3}\");",
                    // objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                    // clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName), 
                    // strTemp, 
                    // objField.ObjFieldTabENEx.FldName,
                    // objField.JavaType);
                    // strBuilder.AppendFormat("\r\n" + "obj{0}.set{1}(new {2}({3}{4}));",
                    // objPrjTabENEx.TabName, 
                    // clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName),
                    // objField.JavaType,
                    // objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                    // clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName));
                    //}
                    //else
                    //{
                    strBuilder.AppendFormat("\r\n" + "obj{0}.set{1}(objRS.get{2}(\"{3}\"));",
                    objPrjTabENEx.TabName,
                    clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName_Java),
                    strTemp,
                    objField.ObjFieldTabENEx.FldName);
                }
                //}

            }
            strBuilder.AppendFormat("\r\n	arrObjLst.add(obj{0});",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException ex) ");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new SQLException(String.format(\"��{0}��û�м�¼!\\r\\n\") + ex.getMessage());",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n objSQL.close();");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return arrObjLst;");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == == = ;
            return strBuilder.ToString();
        }


        public string gGetTabDictWithCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��һ����¼-----------------;
            ///
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";

            ///���ɽ��б���;
            //��������ĺ��� ����;
            //��0��:�ѿؼ���������ComboBoxת����ComboBox
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strValueFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "03")
                {
                    strTextFieldName = objField.ObjFieldTabENEx.FldName;
                }
            }
            if (strValueFieldName == "" || strTextFieldName == "")
            {
                return "";
            }
            strBuilder.AppendFormat("\r\n ArrayList<cls{0}> get{0}Dict(String strWhere) throws Exception ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n 		{");
            strBuilder.AppendFormat("\r\nArrayList<cls{0}> arrObjLst = new ArrayList<cls{0}>(); ",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n ResultSet objRS = null;");
            strBuilder.AppendFormat("\r\n strSQL = \"select {0}, {1} from {2} Where \" + strWhere;",
            strValueFieldName,
            strTextFieldName,
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n clsSpecSQL objSQL = null;");
            strBuilder.Append("\r\n try ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQL();");

            strBuilder.Append("\r\n objRS = GetResultSet(strSQL);");
            strBuilder.Append("\r\n if (objRS == null) ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw new RuntimeException(\"objRS ����Ϊnull\");");
            strBuilder.Append("\r\n }");


            strBuilder.Append("\r\n while(objRS.next())");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n	cls{0} obj{0} = new cls{0}();",
            objPrjTabENEx.TabName);

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.FldName == strValueFieldName ||
                objField.ObjFieldTabENEx.FldName == strTextFieldName)
                {
                    strTemp = objField.JavaType;
                    clsString.FstUcase_S(ref strTemp);
                    //if (strTemp == "Int" || strTemp == "Double" || strTemp == "Long")
                    //{
                    // strBuilder.AppendFormat("\r\n {4} {0}{1} = objRS.get{2}(\"{3}\");",
                    // objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                    // clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName), 
                    // strTemp, 
                    // objField.ObjFieldTabENEx.FldName,
                    // objField.JavaType);
                    // strBuilder.AppendFormat("\r\n" + "obj{0}.set{1}(new {2}({3}{4}));",
                    // objPrjTabENEx.TabName, 
                    // clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName),
                    // objField.JavaType,
                    // objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                    // clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName));
                    //}
                    //else
                    //{
                    strBuilder.AppendFormat("\r\n" + "obj{0}.set{1}(objRS.get{2}(\"{3}\"));",
                    objPrjTabENEx.TabName,
                    clsString.FirstUcaseS(objField.ObjFieldTabENEx.FldName_Java),
                    strTemp,
                    objField.ObjFieldTabENEx.FldName);
                }
                //}

            }
            strBuilder.AppendFormat("\r\n	arrObjLst.add(obj{0});",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (SQLException ex) ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n throw new SQLException(String.format(\"����Ϊ:'{0}'��¼������!\\r\\n\", strWhere) + ex.getMessage());");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n objSQL.close();");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n return arrObjLst;");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == == = ;
            return strBuilder.ToString();
        }

 


        /// <summary>
        /// ����Entity�����
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
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

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);


            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "ENEx";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.EntityLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                //������ʼ
                strCodeForCs.Append("\r\n" + "import Foundation"); //

                strCodeForCs.Append("\r\n /// <summary>");
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n /// {0}({1}),ר�����SilverLight��ʵ����", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                //}
                //else
                //{
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                //}
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                //if (objPrjTabENEx.IsForSilverLight == false)
                //{
                //  strCodeForCs.Append("\r\n" + "[Serializable]");
                //}
                if (string.IsNullOrEmpty(objPrjTabENEx.ParentClass) == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public class  {0} : cls{1}EN", objPrjTabENEx.ClsName, objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public class  {0} : {1}",
                        objPrjTabENEx.ClsName,
                        objPrjTabENEx.ParentClass);
                }
                strCodeForCs.Append("\r\n" + "{");

                //�������еĺ���


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
                
            }
            return strCodeForCs.ToString();
        }

     
     
        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    return strCodeForCs.ToString();
                }

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
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
              string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(EntityLayerEx4Swift4);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("������û����Ӧ�ĺ���:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
                    if (mt.GetParameters().Length == 0)
                    {
                        strCode = (string)mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;
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
        public override void GetClsName()
        {
            this.ClsName = string.Format("cls{0}ENEx", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }

    }
}
