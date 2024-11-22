using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.sql;
using AGC.Entity;
using CommonTable.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.file;
using com.taishsoft.commexception;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using System.Collections.Generic;

namespace AutoGCLib
{
    /// <summary>
    /// ����ר�����������ݱ�ı����㣬�ô�������߼����һ���֣���ϵ�ṹ���µ��£�
    /// �������¼���:
    ///		1�������
    ///			ͨ�ý���㣬ר���ṩһЩ����ؼ��Ĺ�����������
    ///		2���߼���
    ///			2.1 ҵ���߼���
    ///			2.2 �����㡣����:
    ///					1)���¼����ӡ�
    ///					2)���¼��ɾ��
    ///					3)���¼���޸�
    ///					4)���¼�Ĳ�ѯ
    ///					5)��ȡĳЩ���¼���й��ֶ�����
    ///					6)���ñ��¼���й��ֶ����Եȡ�
    ///		3�����ݲ㣬��ͨ�����ݲ㣬ר�����ڲ������ݿ��һЩ�������Լ��������һЩͨ�ò���
    /// </summary>
    class AutoGC6Swift_M : clsGeneCodeBase
    {
        //internal CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();

        //public string ClsName;
    
        private bool mbolIsHaveImageField;
        private string mstrImageFieldName;
        protected string mstrFolderName; // '�ļ�Ŀ¼��
        protected string mstrFileName;

        #region ���캯��

        public AutoGC6Swift_M()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public AutoGC6Swift_M(string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strViewId, strPrjDataBaseId, strPrjId)
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
            if (objPrjTabENEx.TabFldNum == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
                         objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum == 0)
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
                //				strBuilder.Append("\r\n" +clsPrjTabFldBLEx.DefPrivateProperty(objPrjTabENEx.LangType, objField));

                ///�����ֶ���
                strFieldName = objField.objFieldTabENEx.FldName;
                ///�����ֶ�����
                strFieldType = objField.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///�����ֶγ���
                strFieldLength0 = objField.objFieldTabENEx.FldLength.ToString();
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
                strRemark0 = objField.objFieldTabENEx.Caption;
                if (strRemark0 == string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/*" + strRemark0 + "*/";

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

                if (objField.objFieldTabENEx.IsIdentity == true)
                {
                    strPrimaryKey = " primary key identity";
                }
                else if (objField.IsTabPrimary)
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
            if (objPrjTabENEx.TabFldNum == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
                            objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum == 0)
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
                //				strBuilder.Append("\r\n" +clsPrjTabFldBLEx.DefPrivateProperty(objPrjTabENEx.LangType, objField));

                ///�����ֶ���
                strFieldName = objField.objFieldTabENEx.FldName;
                ///�����ֶ�����
                strFieldType = objField.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///�����ֶγ���
                strFieldLength0 = objField.objFieldTabENEx.FldLength.ToString();
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
                strRemark0 = objField.objFieldTabENEx.Caption;
                if (strRemark0 == string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/*" + strRemark0 + "*/";

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

                if (objField.objFieldTabENEx.IsIdentity == true)
                {
                    strPrimaryKey = " primary key identity";
                }
                else if (objField.IsTabPrimary)
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
            return AccessNull("objRS.Rows[0][\"" + objField.objFieldTabENEx.FldName + "\"].toString().Trim()", objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType, objField.IsTabNullable);
        }
        private string AccessNull2(clsPrjTabFldENEx objField)
        {
            strTemp = objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
            clsString.FstUcase_S(ref strTemp);
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("objRS.get{0}(\"{1}\")",
            strTemp, objField.objFieldTabENEx.FldName);
            return AccessNull(strBuilder.ToString(), objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType, objField.IsTabNullable);
        }
        private string AccessNull(string strContent, string strPropType, bool bolIsNullable)
        {
            //			string strReturn;
            //			strReturn = "";
            if (bolIsNullable == false)
            {
                return strContent;
            }
            switch (strPropType)
            {
                case "String":
                    return strContent;
                case "int":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return "Integer.parseInt(" + strContent + ")";
                    }
                case "short":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToShort(" + strContent + ")";
                    }
                    else
                    {
                        return "Short.parseShort(" + strContent + ")";
                    }
                case "Date":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToDate(" + strContent + ")";
                    }
                    else
                    {
                        return "System.DateTime.Parse(" + strContent + ")";
                    }
                case "Single":
                case "float":
                    if (bolIsNullable == true)
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
                    if (bolIsNullable == true)
                    {
                        return "TransNullToDouble(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.parseDouble(" + strContent + ")";
                    }
                case "boolean":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToBool(" + strContent + ")";
                    }
                    else
                    {
                        return "boolean.parseBoolean(" + strContent + ")";
                    }
                case "Decimal":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToDouble(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.parseDouble(" + strContent + ")";
                    }
                case "Long":
                case "long":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return "Integer.parseInt(" + strContent + ")";
                    }
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
                    if (bolIsNullable == true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return "Integer.parseInt(" + strContent + ")";
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
            if (pobjField.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                return "\"\'\"";
            }
            else
            {
                return "\"\"";
            }

        }

        private string getValueStr(clsPrjTabFldENEx pobjField)
        {
            if (pobjField.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                return "'\" + " + clsString.FstLcaseS(pobjField.objFieldTabENEx.FldName) + " + \"'";
            }
            else
            {
                return clsString.FstLcaseS(pobjField.objFieldTabENEx.FldName);
            }
        }
        //ƴװ�ؼ��ֵ�WHERE��
        private string KeyWhereStr(clsPrjTabENEx objPrjTabENEx)
        {
            //			bool isNeed_m = true;
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objField.objFieldTabENEx.FldName + " = \" + " + Mark(objField) + "+ " + clsString.FstLcaseS(objField.objFieldTabENEx.FldName_Java) + "+" + Mark(objField);
                if (i == 0)    //�Ƿ��ǵ�һ��
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

        private string KeyWhereStr(bool isNeed_m, clsPrjTabENEx objPrjTabENEx)
        {
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objField.objFieldTabENEx.FldName + " = \" + " + Mark(objField) + "+ " + (isNeed_m == true ? "m" : "") + objField.objFieldTabENEx.PrivFuncName + "+" + Mark(objField);
                ///'strTemp = arrKeyFldSet[i].ColumnName + " = \"" + Mark(arrKeyFldSet[i]) + "+ " + "m" + objField.objFieldTabENEx.PrivFuncName + Mark(arrKeyFldSet[i])
                if (i == 0)    //�Ƿ��ǵ�һ��
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




        //ƴװ�ؼ��ֵĴ�ֵ������
        private string GetKeyPara(clsPrjTabENEx objPrjTabENEx)
        {
            string strPara, strTemp;
            int i = 0;
            strPara = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {

                strTemp = objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType + " " + objField.objFieldTabENEx.PrivFuncName;
                if (i == 0)        //�Ƿ��ǵ�һ��
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
        /// ���˽�б��������������Ե�˽�б���
        /// </summary>
        /// <returns></returns>
        public string gfunClsPrivateVar(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��������˽������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n internal {0} {1};	//{2}",
                objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                clsString.FstLcaseS(objField.objFieldTabENEx.FldName_Java),
                objField.objFieldTabENEx.Caption);
            }
            return strBuilder.ToString();
        }
        /// <summary>
        /// �๫����������
        /// </summary>
        /// <returns></returns>
        public string gfunClsProperty(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///����������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strTemp = objField.objFieldTabENEx.FldName_Java;
                clsString.FstUcase_S(ref strTemp);
                strBuilder.AppendFormat("\r\n //��ȡ{0}({1})��ֵ", objField.objFieldTabENEx.Caption, objField.objFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n public {0} get{1}()", objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType, strTemp);
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\n return objViewInfoENEx.{0};", objField.objFieldTabENEx.FldName_Java);
                strBuilder.Append("\r\n }");
                strBuilder.AppendFormat("\r\n //����{0}({1})��ֵ", objField.objFieldTabENEx.Caption, objField.objFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n public void set{0}({1} value)", strTemp, objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType);
                strBuilder.Append("\r\n{");
                strBuilder.AppendFormat("\r\n objViewInfoENEx.{0} = value;", objField.objFieldTabENEx.FldName_Java);
                strBuilder.AppendFormat("\r\n hmProperty.put(\"{0}\", \"true\");",
                objField.objFieldTabENEx.FldName);
                strBuilder.Append("\r\n}");
                strBuilder.Append("\r\n");
            }
            return strBuilder.ToString();
        }
        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        public string gfunClsIndexer(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic static int AttributeCount");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn mintAttributeCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            //�����������ַ�������
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
                    objField.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    clsString.FstLcaseS(objField.objFieldTabENEx.FldName));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (strAttributeName == \"{0}\")",
                    objField.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    clsString.FstLcaseS(objField.objFieldTabENEx.FldName));
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
                    objField.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                    clsString.FstLcaseS(objField.objFieldTabENEx.FldName), AccessNull("value.toString()", objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType, true));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (strAttributeName == \"{0}\")",
                    objField.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                    clsString.FstLcaseS(objField.objFieldTabENEx.FldName), AccessNull("value.toString()", objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType, true));
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");

            //��������������(INT)��Ų���

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
                    objField.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    clsString.FstLcaseS(objField.objFieldTabENEx.FldName));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (\"{0}\" == AttributeName[intIndex])",
                    objField.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    clsString.FstLcaseS(objField.objFieldTabENEx.FldName));
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
                    objField.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                    clsString.FstLcaseS(objField.objFieldTabENEx.FldName), AccessNull("value.toString()", objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType, true));
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (\"{0}\" == AttributeName[intIndex])",
                    objField.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                    clsString.FstLcaseS(objField.objFieldTabENEx.FldName), AccessNull("value.toString()", objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType, true));
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
        public string gfunClassConstructor3(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\npublic {0}({1}, boolean bolIsGet{2})",
              objPrjTabENEx.ClsName, GetKeyPara(objPrjTabENEx), objPrjTabENEx.TabName);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n hmProperty = Dictionary<String, String>();");
            strBuilder.AppendFormat("\r\n{0}", GetKeyAssign(objPrjTabENEx) + ";");
            strBuilder.Append("\r\nSetInit(objPrjTabENEx);");
            strBuilder.AppendFormat("\r\nif (bolIsGet{0} == true)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nGet{0}();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.objFieldTabENEx.FldName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }

        public string gfunClassConstructorEx1(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;
            strBuilder.Append("\r\n public " + strClsNameEx + "()" + ": base()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string gfunClassConstructorEx2(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic " + strClsNameEx + "(" + GetKeyPara(objPrjTabENEx) + ")" + ": base(" + objKeyField.objFieldTabENEx.PrivFuncName + ")");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string gfunClassConstructorEx3(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\npublic {0}({1}, boolean bolIsGet{2}) : base({3},bolIsGet{2})",
            strClsNameEx, GetKeyPara(objPrjTabENEx), objPrjTabENEx.TabName, objKeyField.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }

        public string gfunSetInit(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���������Щ���Գ�ʼֵ");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\nprivate void SetInit(objPrjTabENEx)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjViewInfoENEx.ModuleName = objViewInfoENEx.GetType().toString();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType == "Date")
                {
                    strBuilder.Append("\r\n" + clsString.FstLcaseS(objField.objFieldTabENEx.FldName) + " = System.DateTime.Parse(\"01/01/1900\");	");
                }
            }
            strBuilder.Append("\r\n}");
            ///�๹���� == == == = ;
            return strBuilder.ToString();
        }
        public string gfunAddNewRecord(clsPrjTabENEx objPrjTabENEx)
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
                if (objField.IsTabPrimary == true && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.Append(objField.objFieldTabENEx.FldName);
                }
                else
                {
                    strBuilder.Append(", " + objField.objFieldTabENEx.FldName);
                }
            }
            strBuilder.Append(") \" ;");
            bolIsFirst = true;
            int intFldNum = objPrjTabENEx.arrFldSet.Count;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabPrimary == true && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
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
                if (objField.IsTabPrimary == true && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                strTemp = objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
                clsString.FstUcase_S(ref strTemp);
                strBuilder.AppendFormat("\r\n objPS.set" + strTemp + "(" + intFieldNo.ToString().Trim() + ", objViewInfoENEx." + clsString.FstLcaseS(objField.objFieldTabENEx.FldName_Java) + "); //{0} ",
                objField.objFieldTabENEx.Caption);
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

        public string gfunAddNewRecord_neusoft(clsPrjTabENEx objPrjTabENEx)
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
                    strBuilder.Append(objField.objFieldTabENEx.FldName);
                }
                else
                {
                    strBuilder.Append(", " + objField.objFieldTabENEx.FldName);
                }
            }
            strBuilder.Append(") \" ;");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    if (objField.IsTabPrimary && objField.objFieldTabENEx.IsIdentity)
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
                    if (objField.IsTabPrimary && objField.objFieldTabENEx.IsIdentity)
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
                    if (objField.IsTabPrimary && objField.objFieldTabENEx.IsIdentity)
                    {
                    }
                    else
                    {
                        bolIsFirst = false;

                        strBuilder.AppendFormat("\r\n {0}	//{1}",
                        clsString.FstLcaseS(objField.objFieldTabENEx.FldName),
                        objField.objFieldTabENEx.Caption);
                    }
                }
                else
                {
                    if (objField.IsTabPrimary && objField.objFieldTabENEx.IsIdentity)
                    {
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n , {0}			//{1}",
                        clsString.FstLcaseS(objField.objFieldTabENEx.FldName),
                        objField.objFieldTabENEx.Caption);
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


        public string gfunAddNewRecordBySQL(clsPrjTabENEx objPrjTabENEx)
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
                strBuilder.Append("\r\n/// <returns>�������ɹ��򷵻�TRUE������ΪFALSE</returns>");
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
                    if (objField.objFieldTabENEx.IsIdentity == false)
                    {
                        if (bolIsFirst == true)
                        {
                            strFieldLst.AppendFormat("{0}", objField.objFieldTabENEx.FldName);
                            strValueLsd.AppendFormat("{0}", clsString.FstLcaseS(objField.objFieldTabENEx.FldName));
                            strParaIndex = "'{" + intIndex.ToString() + "}'";
                            bolIsFirst = false;
                        }
                        else
                        {
                            strFieldLst.AppendFormat(", {0}", objField.objFieldTabENEx.FldName);
                            strValueLsd.AppendFormat(", {0}", clsString.FstLcaseS(objField.objFieldTabENEx.FldName));
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


        public string gfunAddnewRecBySP(clsPrjTabENEx objPrjTabENEx)
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
            strBuilder.Append("\r\n//MsgBox(objViewInfoENEx.ErrMsg(mintErrNo))");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nobjSQL.setSPConfigXMLFile(\"..\\\\XML\\\\XMLSP.xml\");");
            strBuilder.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strBuilder.Append("\r\nArrayList values = new ArrayList();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                if (objField.PrimaryTypeId == "02" && objField.IsTabPrimary == true)
                {
                }
                else
                {
                    strBuilder.Append("\r\nvalues.add(" + clsString.FstLcaseS(objField.objFieldTabENEx.FldName) + ");");
                }
            }
            strBuilder.Append("\r\nobjSQL.ExecSP(\"Addnew" + objPrjTabENEx.TabName + "\",values);");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///public bool Addnew {TabName}BySP() == == ;
            return strBuilder.ToString();
        }
        public string gfunAddnewMultiRec(clsPrjTabENEx objPrjTabENEx)
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
            strBuilder.AppendFormat("\r\nstrSQL = \"Select * from {0} where " + objKeyField.objFieldTabENEx.FldName + " = '111'\";",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\nobjDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);");
            strBuilder.Append("\r\nobjCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);");
            strBuilder.AppendFormat("\r\nobjDA.Fill(objDS, \"{0}\");", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n//���ؼ��ֵ�Ψһ��");
            ///����ñ�Ĺؼ�����˳�������;
            if (objKeyField.objFieldTabENEx.IsIdentity == false)
            {
                if (objPrjTabENEx.arrKeyFldSet.Count == 0)
                {
                    strBuilder.Append("\r\n//��ı�" + objPrjTabENEx.TabName + " ��û�йؼ��֣���������һ���ؼ���!");

                    /// MsgBox("��ı���û�йؼ���");
                }
                else
                {
                    strBuilder.Append("\r\nforeach(System.Data.DataRow oRow in oDT.Rows)");
                    strBuilder.Append("\r\n{");
                    string strTT;
                    strTT = string.Format("oRow[\"{0}\"].toString().Trim()", objKeyField.objFieldTabENEx.FldName);
                    strTemp = string.Format("{0} {1} = " + AccessNull(strTT, objKeyField.objFieldTabENEx.objDataTypeAbbrEN.JavaType, objKeyField.IsTabNullable) + ";",
                    objKeyField.objFieldTabENEx.objDataTypeAbbrEN.JavaType, objKeyField.objFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n" + strTemp);

                    strBuilder.Append("\r\nif (IsExist(" + objKeyField.objFieldTabENEx.PrivFuncName + "))");
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nstrResult = \"�ؼ���" + objKeyField.objFieldTabENEx.FldName + "Ϊ:\" + " + objKeyField.objFieldTabENEx.PrivFuncName + " + \"�ļ�¼�Ѵ��ڣ������ظ�����!\" ;");
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
                if (objField.PrimaryTypeId == "02" && objField.IsTabPrimary == true)
                {
                }
                else
                {
                    strBuilder.Append("\r\nobjRow[\"" + objField.objFieldTabENEx.FldName + "\"] = oRow[\"" + objField.objFieldTabENEx.FldName + "\"].toString().Trim();");
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
            strBuilder.Append("\r\nobjDA = null;");
            strBuilder.Append("\r\nobjDS = null;");
            strBuilder.Append("\r\nobjCB = null;");
            strBuilder.Append("\r\nobjRow = null;");
            strBuilder.Append("\r\nobjSQL.SQLConnect.Close();");
            strBuilder.Append("\r\nobjSQL = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///��Ӷ����¼�¼ == == == = ;
            return strBuilder.ToString();
        }
        public string gfunUpdate(clsPrjTabENEx objPrjTabENEx)
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
                // strBuilder.AppendFormat("\r\n strSQL += \"{0} = ?\";", objField.objFieldTabENEx.FldName);
                //}
                //else
                //{
                // strBuilder.AppendFormat("\r\n strSQL += \", {0} = ? \";", objField.objFieldTabENEx.FldName);
                //}
                strBuilder.AppendFormat("\r\n //{0}",
                objField.objFieldTabENEx.Caption);

                if (objField.IsTabPrimary == false)
                {
                    strBuilder.AppendFormat("\r\n if (hmProperty.containsKey(\"{0}\"))",
                    objField.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\n strSQL += \"{0} = ?, \";",
                    objField.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n }");
                }
            }
            strBuilder.Append("\r\n strSQL = strSQL.substring(0, strSQL.length()-2);");
            strBuilder.AppendFormat("strSQL += \" where {0} = ?\";", objKeyField.objFieldTabENEx.FldName);


            strBuilder.Append("\r\n PreparedStatement objPS = objSQL.getPreparedStmt(strSQL);");
            strBuilder.Append("\r\n // PreparedStatement objPS = objSQL.getCallableStmt(strSQL);");
            strBuilder.Append("\r\n //��ʼ������");
            strBuilder.Append("\r\n objPS.clearParameters();");
            strBuilder.Append("\r\n int intFieldNo = 1;");

            //int intFieldNo = 1;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabPrimary == false)
                {
                    strBuilder.AppendFormat("\r\n if (hmProperty.containsKey(\"{0}\"))",
                    objField.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n {");

                    strTemp = objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
                    clsString.FstUcase_S(ref strTemp);
                    strBuilder.Append("\r\n objPS.set" + strTemp + "(intFieldNo++, objViewInfoENEx." + clsString.FstLcaseS(objField.objFieldTabENEx.FldName_Java) + ");");
                    strBuilder.Append("\r\n }");
                }
                //strBuilder.Append("\r\n objPS.set" + strTemp + "(" + intFieldNo.ToString().Trim() + ", objViewInfoENEx." + clsString.FstLcaseS(objField.objFieldTabENEx.FldName) + ");");
            }
            //strTemp = objKeyField.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
            //clsString.FstUcase_S(ref strTemp);
            //strBuilder.AppendFormat("\r\n objPS.set{0}({1}, objViewInfoENEx.{2}); ",
            // strTemp, intFieldNo, clsString.FstLcaseS(objKeyField.objFieldTabENEx.FldName));
            //intFieldNo += 1;

            strTemp = objKeyField.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
            clsString.FstUcase_S(ref strTemp);
            strBuilder.AppendFormat("\r\n objPS.set{0}(intFieldNo++, objViewInfoENEx.{1}); ",
            strTemp, clsString.FstLcaseS(objKeyField.objFieldTabENEx.FldName_Java));

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

        public string gfunUpdate_neusoft(clsPrjTabENEx objPrjTabENEx)
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
                if (objField.IsTabPrimary == false)
                {
                    strBuilder.AppendFormat("\r\n if (hmProperty.containsKey(\"{0}\"))",
                    objField.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n {");
                    strBuilder.Append("\r\n if (bolIsFirst == true)");
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\n strSQL += \"{0} = ?\";",
                    objField.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n bolIsFirst = false;");
                    strBuilder.Append("\r\n }");
                    strBuilder.Append("\r\n else");
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\n strSQL += \", {0} = ?\";",
                    objField.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n }");
                    strBuilder.AppendFormat("\r\n paramList.add({0});",
                    clsString.FstLcaseS(objField.objFieldTabENEx.FldName));
                    strBuilder.Append("\r\n }");

                    //					if (bolIsFirst == true)
                    //					{
                    //						bolIsFirst = false;
                    //						strBuilder.AppendFormat("\r\n strSQL += \"{0} = ?\";", objField.objFieldTabENEx.FldName);
                    //					}
                    //					else
                    //					{
                    //						strBuilder.AppendFormat("\r\n strSQL += \", {0} = ? \";", objField.objFieldTabENEx.FldName);
                    //					}
                }
            }
            strBuilder.AppendFormat("\r\n strSQL += \" where {0} = ?\";", objKeyField.objFieldTabENEx.FldName);

            strBuilder.AppendFormat("\r\n paramList.add({0});",
            clsString.FstLcaseS(objKeyField.objFieldTabENEx.FldName));

            strBuilder.Append("\r\n Object[] params = new Object[paramList.size()];");
            strBuilder.Append("\r\n paramList.toArray(params);");
            strBuilder.Append("\r\n int iResult = pm.executeUpdate(strSQL, params);");
            strBuilder.Append("\r\n return iResult;");

            strBuilder.Append("\r\n }");
            ///�޸ļ�¼ == = ;
            return strBuilder.ToString();
        }
        public string gfunUpdateBatch_neusoft(clsPrjTabENEx objPrjTabENEx)
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
                if (objField.IsTabPrimary == false)
                {
                    strBuilder.AppendFormat("\r\n if (hmProperty.containsKey(\"{0}\"))",
                    objField.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n {");
                    strBuilder.Append("\r\n if (bolIsFirst == true)");
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\n strSQL += \"{0} = {1}\";",
                    objField.objFieldTabENEx.FldName,
                    getValueStr(objField));
                    strBuilder.Append("\r\n bolIsFirst = false;");
                    strBuilder.Append("\r\n }");
                    strBuilder.Append("\r\n else");
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\n strSQL += \", {0} = {1}\";",
                    objField.objFieldTabENEx.FldName,
                    getValueStr(objField));
                    strBuilder.Append("\r\n }");
                    strBuilder.Append("\r\n }");

                    //					if (bolIsFirst == true)
                    //					{
                    //						bolIsFirst = false;
                    //						strBuilder.AppendFormat("\r\n strSQL += \"{0} = ?\";", objField.objFieldTabENEx.FldName);
                    //					}
                    //					else
                    //					{
                    //						strBuilder.AppendFormat("\r\n strSQL += \", {0} = ? \";", objField.objFieldTabENEx.FldName);
                    //					}
                }
            }


            strBuilder.Append("\r\n if (strCondition == \"\")");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL += \" where {0} = ?\";", objKeyField.objFieldTabENEx.FldName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strSQL += \" where \" + strCondition + \" and {0} = ?\";", objKeyField.objFieldTabENEx.FldName);
            strBuilder.Append("\r\n }");


            strBuilder.Append("\r\n rows = pm.executeUpdateBatch(strSQL, lstKey);");
            strBuilder.Append("\r\n return rows;");

            strBuilder.Append("\r\n }");
            ///�޸ļ�¼ == = ;
            return strBuilder.ToString();
        }

        public string gfunUpdateMultiRec(clsPrjTabENEx objPrjTabENEx)
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
            strBuilder.Append("\r\nreturn 0; //��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼");
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
                if ((objField.objFieldTabENEx.IsIdentity == false) && (objField.IsTabPrimary == false))
                {
                    strBuilder.AppendFormat("\r\nobjRow[\"{0}\"] = {1};",
                    objField.objFieldTabENEx.FldName, clsString.FstLcaseS(objField.objFieldTabENEx.FldName));
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
            strBuilder.Append("\r\nobjDA = null;");
            strBuilder.Append("\r\nobjDS = null;");
            strBuilder.Append("\r\nobjCB = null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///�������޸Ķ�����¼ == = ;
            return strBuilder.ToString();
        }
        public string gfunfunGetRecCount(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡ���еļ�¼��---------------------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:��ȡ��ǰ��ļ�¼��.�ñ��뵱ǰ����ء�");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <returns>��¼����Ϊ����</returns>");
            strBuilder.Append("\r\npublic int funGetRecCount()");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.funGetRecCount(CurrTabName);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gfunfunGetRecCount_S(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:��ȡ��ǰ��ļ�¼��.�ñ��뵱ǰ����ء�");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strTabName\">�������ı���</param>");
            strBuilder.Append("\r\n/// <returns>��¼����Ϊ����</returns>");
            strBuilder.Append("\r\npublic static int funGetRecCount(string strTabName)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.funGetRecCount(strTabName);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gfunfunGetRecCountByCond(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:��ȡ��ǰ�������������ļ�¼��");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strCondtion\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n/// <returns>��¼����Ϊ����</returns>");
            strBuilder.Append("\r\npublic int clsGeneralTab2.funGetRecCountByCond(string strCondtion)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.funGetRecCount(CurrTabName, strCondtion);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunfunGetRecCountByCond_S(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:��ȡ�����������������ļ�¼��");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strTabName\">�������ı���</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondtion\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n/// <returns>��¼����Ϊ����</returns>");
            strBuilder.Append("\r\npublic static int clsGeneralTab2.funGetRecCountByCond(string strTabName, string strCondtion)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.funGetRecCount(strTabName, strCondtion);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///��ȡ���еļ�¼�� == == == ;
            return strBuilder.ToString();
        }
        public string gfunfunSetFldValue4String(clsPrjTabENEx objPrjTabENEx)
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
            strBuilder.Append("\r\npublic int clsGeneralTab2.funSetFldValue(string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.funSetFldDataOfTable(\"{0}\", strFldName, strValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gfunfunSetFldValue4Float(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:���õ�ǰ���еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n/// <param name = \"fltValue\">ֵ</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n/// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int clsGeneralTab2.funSetFldValue(string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.funSetFldDataOfTable(\"{0}\", strFldName, fltValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunfunSetFldValue4Int(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:���õ�ǰ���еķ���������ĳ�ֶε�ֵ");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n/// <param name = \"intValue\">ֵ</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n/// <returns>Ӱ��ļ�¼��</returns>");
            strBuilder.Append("\r\npublic int clsGeneralTab2.funSetFldValue(string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\nint intRecCount = objSQL.funSetFldDataOfTable(\"{0}\", strFldName, intValue, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunfunSetFldValue4String_S(clsPrjTabENEx objPrjTabENEx)
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
            strBuilder.Append("\r\npublic static int clsGeneralTab2.funSetFldValue(string strTabName, string strFldName, string strValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, strValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunfunSetFldValue4Int_S(clsPrjTabENEx objPrjTabENEx)
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
            strBuilder.Append("\r\npublic static int clsGeneralTab2.funSetFldValue(string strTabName, string strFldName, int intValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, intValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunfunSetFldValue4Float_S(clsPrjTabENEx objPrjTabENEx)
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
            strBuilder.Append("\r\npublic static int clsGeneralTab2.funSetFldValue(string strTabName, string strFldName, float fltValue, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nint intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, fltValue, strCondition);");
            strBuilder.Append("\r\nreturn intRecCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gfunfunGetFldValue(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:��ȡ��ǰ���еķ���������ĳ�ֶε�ֵ�����б���");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n/// <returns>��ȡ���ֶ�ֵ�б�</returns>");
            strBuilder.Append("\r\npublic ArrayList clsGeneralTab2.funGetFldValue(string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\nArrayList arrList = objSQL.funGetFldDataOfTable(\"{0}\", strFldName, strCondition);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gfunfunGetFldValue_S(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:��ȡ�������еķ���������ĳ�ֶε�ֵ�����б���");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strTabName\">����</param>");
            strBuilder.Append("\r\n/// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n/// <returns>��ȡ���ֶ�ֵ�б�</returns>");
            strBuilder.Append("\r\npublic static ArrayList clsGeneralTab2.funGetFldValue(string strTabName, string strFldName, string strCondition) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nArrayList arrList = objSQL.funGetFldDataOfTable(strTabName, strFldName, strCondition);");
            strBuilder.Append("\r\nreturn arrList;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///����/��ȡ���еķ���������ĳ�ֶε�ֵ == = ;
            return strBuilder.ToString();
        }
        public string gfunDelRecord(clsPrjTabENEx objPrjTabENEx)
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
            strBuilder.AppendFormat(" strSQL += \" where {0} = ?\";", objKeyField.objFieldTabENEx.FldName);
            strBuilder.Append("\r\n PreparedStatement objPS = objSQL.getPreparedStmt(strSQL);");
            strBuilder.Append("\r\n // PreparedStatement objPS = objSQL.getCallableStmt(strSQL);");
            strBuilder.Append("\r\n objPS.clearParameters();");

            int intFieldNo = 1;
            strTemp = objKeyField.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
            clsString.FstUcase_S(ref strTemp);
            if (strTemp == "Long")
            {
                strBuilder.AppendFormat("\r\n objPS.set{0}({1}, objViewInfoENEx.{2}); ",
                strTemp, intFieldNo, clsString.FstLcaseS(objKeyField.objFieldTabENEx.FldName_Java));
            }
            else if (strTemp == "Int")
            {
                strBuilder.AppendFormat("\r\n objPS.set{0}({1}, objViewInfoENEx.{2}); ",
                strTemp, intFieldNo, clsString.FstLcaseS(objKeyField.objFieldTabENEx.FldName_Java));
            }
            else
            {
                strBuilder.AppendFormat("\r\n objPS.set{0}({1}, objViewInfoENEx.{2}); ",
                strTemp, intFieldNo, clsString.FstLcaseS(objKeyField.objFieldTabENEx.FldName_Java));
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
        public string gfunDelMultiRec_S(clsPrjTabENEx objPrjTabENEx)
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
                strBuilder.Append("\r\n//��ı�" + objPrjTabENEx.TabName + " ��û�йؼ��֣���������һ���ؼ���!");
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
                strBuilder.Append("\r\n//��ı�" + objPrjTabENEx.TabName + " ��û�йؼ��֣���������һ���ؼ���!");
                strBuilder.Append("\r\nreturn false;");
            }
            else
            {
                strBuilder.AppendFormat("\r\nstrSQL = strSQL + \"Delete from {0} where " + objKeyField.objFieldTabENEx.FldName + " in (\" + strKeyList + \")\";",
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

        public string gfunDelMultiRec_neusoft(clsPrjTabENEx objPrjTabENEx)
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
            objPrjTabENEx.TabName, objKeyField.objFieldTabENEx.FldName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n rows = pm.executeUpdateBatch(strSQL, lstKey);");
            strBuilder.Append("\r\n return rows;");
            strBuilder.Append("\r\n }");

            ///ɾ��һЩ��¼ == = ;
            return strBuilder.ToString();
        }


        public string gfunDelRecord_S(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��һ����¼-----------------;
            strBuilder.Append("\r\n" + string.Format("public static int DelRecord({0} {1}) ", objKeyField.objFieldTabENEx.objDataTypeAbbrEN.JavaType, objKeyField.objFieldTabENEx.PrivFuncName));
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
        public string gfunDelCondRec_S(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��������¼��ɾ���������ļ�¼------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:ɾ��������¼����������ɾ��");
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
            strBuilder.Append("\r\n return 0;	//��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼");
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
            ///ɾ��������¼��ɾ���������ļ�¼ == = ;
            return strBuilder.ToString();
        }
        public string gfunGetRecValue(clsPrjTabENEx objPrjTabENEx)
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
            objPrjTabENEx.TabName, KeyWhereStr(objPrjTabENEx),
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n try {");
            strBuilder.Append("\r\n objRS = objSQL.GetResultSet(strSQL, strResult);");
            strBuilder.Append("\r\n if (objRS.next()) {");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.objFieldTabENEx.FldName.ToUpper() != objKeyField.objFieldTabENEx.FldName.ToUpper())
                {
                    strTemp = objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
                    clsString.FstUcase_S(ref strTemp);
                    strBuilder.AppendFormat("\r\n objViewInfoENEx.{0} = objRS.get{1}(\"{2}\");",
                    clsString.FstLcaseS(objField.objFieldTabENEx.FldName_Java), strTemp, objField.objFieldTabENEx.FldName);
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

        public string gfunGetRecValue_neusoft(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ�ؼ�ֵ�ļ�¼-----------------------------;
            strBuilder.Append("\r\npublic boolean Get" + objPrjTabENEx.TabName + "()");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n String strSQL;");
            strBuilder.Append("\r\n DataSet ds = null;");
            strBuilder.AppendFormat("\r\n Object[] obj{0} = new Object[1];",
            clsString.FirstUcaseS(objKeyField.objFieldTabENEx.FldName));
            strBuilder.AppendFormat("\r\n obj{0}[0] = objViewInfoENEx.{1};",
            clsString.FirstUcaseS(objKeyField.objFieldTabENEx.FldName),
            clsString.FstLcaseS(objKeyField.objFieldTabENEx.FldName));
            strBuilder.AppendFormat("\r\n strSQL = \" Select * from {0} where {1} = ?\";",
            objPrjTabENEx.TabName,
            objKeyField.objFieldTabENEx.FldName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n try ");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n ds = pm.executeQuery(strSQL, obj{0});",
            clsString.FirstUcaseS(objKeyField.objFieldTabENEx.FldName));
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
                if (objField.objFieldTabENEx.FldName.ToUpper() != objKeyField.objFieldTabENEx.FldName.ToUpper())
                {
                    strTemp = objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
                    clsString.FstUcase_S(ref strTemp);
                    if (strTemp == "Int" || strTemp == "Double" || strTemp == "Long")
                    {
                        strBuilder.AppendFormat("\r\n {4} {0}{1} = ds.get{2}(\"{3}\");",
                        objField.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                        clsString.FirstUcaseS(objField.objFieldTabENEx.FldName),
                        strTemp,
                        objField.objFieldTabENEx.FldName,
                        objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType);
                        strBuilder.AppendFormat("\r\n objViewInfoENEx.{0} = new {1}({2}{3});",
                        clsString.FstLcaseS(objField.objFieldTabENEx.FldName),
                        objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objField.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                        clsString.FirstUcaseS(objField.objFieldTabENEx.FldName));
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n objViewInfoENEx.{0} = ds.get{1}(\"{2}\");",
                        clsString.FstLcaseS(objField.objFieldTabENEx.FldName),
                        strTemp,
                        objField.objFieldTabENEx.FldName);
                    }
                }
            }
            strBuilder.Append("\r\n return true;");
            strBuilder.Append("\r\n }");

            //��ȡĳһ�ؼ�ֵ�ļ�¼ == == = ;
            return strBuilder.ToString();
        }

        public string gfunGetCondRecSet_S(clsPrjTabENEx objPrjTabENEx)
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

        public string gfunGetObjLst(clsPrjTabENEx objPrjTabENEx)
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
            clsString.FirstUcaseS(objKeyField.objFieldTabENEx.FldName));
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
                strTemp = objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
                clsString.FstUcase_S(ref strTemp);

                strBuilder.AppendFormat("\r\n" + "obj{0}.set{1}(objRS.get{2}(\"{3}\"));",
                objPrjTabENEx.TabName,
                clsString.FirstUcaseS(objField.objFieldTabENEx.FldName_Java),
                strTemp,
                objField.objFieldTabENEx.FldName);
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
        public string GenGetFirstCondRecObj(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\npublic cls{0} GetFirst{0}(String strCondition)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n String strSQL; ");
            strBuilder.Append("\r\n ResultSet objRS; ");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.AppendFormat("\r\n strSQL = \"Select * from {0} where \" + strCondition;",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n objRS = objSQL.GetResultSet(strSQL);");
            strBuilder.Append("\r\n if (objRS.next()) ");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n	cls{0} obj{0} = new cls{0}();",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}.set{1}(" + AccessNull2(objField) + ");",
                objPrjTabENEx.TabName, clsString.FirstUcaseS(objField.objFieldTabENEx.FldName_Java));

            }
            strBuilder.Append("\r\nobjRS = null;");
            strBuilder.AppendFormat("\r\nreturn obj{0};", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            strBuilder.Append("\r\n return null;");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == == = ;
            return strBuilder.ToString();
        }

        public string gfunGetCondRecSetT_S(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ������DataTable�����еĴ���ת������Ӧ������------------------------;
            if (objPrjTabENEx.IsNeedTransCode)
            {
                strBuilder = new StringBuilder();
                strBuilder.Append("\r\n");
                strBuilder.Append("\r\n/// <summary>");
                strBuilder.Append("\r\n/// ����:��ȡĳһ������DataTable�����еĴ���ת������Ӧ������");
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
                    if (objField.objFieldTabENEx.IsNeedTransCode == true)
                    {
                        if (objPrjTabENEx.TabId == objField.objFieldTabENEx.CodeTabId)
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
                            objPrjTabENEx.TabName, objField.objFieldTabENEx.CodeTabName);
                            sbWhereStr.AppendFormat("\r\nstrSQL.append(\" where {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.objFieldTabENEx.FldName,
                            objField.objFieldTabENEx.CodeTabName, objField.objFieldTabENEx.CodeTab_Code);
                            bolIsFirst = false;
                        }
                        else
                        {
                            sbTabName.AppendFormat("\r\nstrSQL.append(\" , {0} \");",
                            objField.objFieldTabENEx.CodeTabName);
                            sbWhereStr.AppendFormat("\r\nstrSQL.append(\" && {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.objFieldTabENEx.FldName, 
                            objField.objFieldTabENEx.CodeTabName, objField.objFieldTabENEx.CodeTab_Code);
                        }
                        if (bolIsSelfLink == true)
                        {
                            sbFldStr.AppendFormat("\r\nstrSQL.append(\", {0}Self.{1} {2}{3} \");",
                            objField.objFieldTabENEx.CodeTabName, 
                            objField.objFieldTabENEx.CodeTab_Name, 
                            objField.objFieldTabENEx.CodeTabName, 
                            objField.objFieldTabENEx.CodeTab_Name);
                            sbLeftJoinStr.AppendFormat("\r\nstrSQL.append(\" left JOIN {2} {2}Self on {0}.{1} = {2}Self.{3} \");",
                            objPrjTabENEx.TabName, objField.objFieldTabENEx.FldName, 
                            objField.objFieldTabENEx.CodeTabName, objField.objFieldTabENEx.CodeTab_Code);
                        }
                        else
                        {
                            sbFldStr.AppendFormat("\r\nstrSQL.append(\", {0}.{1} {2}{3} \");",
                            objField.objFieldTabENEx.CodeTabName, 
                            objField.objFieldTabENEx.CodeTab_Name,
                            objField.objFieldTabENEx.CodeTabName, 
                            objField.objFieldTabENEx.CodeTab_Name);
                            sbLeftJoinStr.AppendFormat("\r\nstrSQL.append(\" left JOIN {2} on {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.objFieldTabENEx.FldName,
                            objField.objFieldTabENEx.CodeTabName, objField.objFieldTabENEx.CodeTab_Code);
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
            ///��ȡĳһ������DataTable�����еĴ���ת������Ӧ������ == = ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// ����ͼ(SQL View)�л�ȡ��Ϣ���� == >DataTable
        /// </summary>
        /// <returns></returns>
        public string gfunGetCondRecSetV_S(clsPrjTabENEx objPrjTabENEx)
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
            ///��ȡĳһ������DataTable�����еĴ���ת������Ӧ������ == = ;
            return strBuilder.ToString();
        }


        public string gfunGetPrimaryKeyID_S(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ�����Ĺؼ����б�-----------------------------------------;
            strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:��ȡĳһ�����Ĺؼ����б�");
            strBuilder.Append("\r\n///		 �����ؼ����Ƕ���������ؼ���֮����\"//\"����");
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
            objKeyField.objFieldTabENEx.FldName, objPrjTabENEx.TabName,
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
        public string gfunGetFileFromTabField(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�ϴ��ļ��Լ������ļ���ش���------------------------------------ ;
            if (mbolIsHaveImageField == true)
            {
                strBuilder = new StringBuilder();
                strBuilder.Append("\r\n/// <summary>");
                strBuilder.Append("\r\n/// ����:�����ݿ���ֶ��л�ȡ���ݣ����Ҵ�����ļ��С�");
                strBuilder.Append("\r\n///		˵��:���¼����Ϊ��ǰ��������Ӧ�ļ�¼��");
                strBuilder.Append("\r\n/// </summary>");
                strBuilder.Append("\r\n/// <param name = \"strDownLoadFileName\">��ȡ���ݺ������˵��ļ�����</param>");
                strBuilder.Append("\r\n/// <returns>����ɹ���ȡ�ͷ���TRUE������ΪFALSE</returns>");
                strBuilder.Append("\r\npublic boolean GetFileFromTabField(string strDownLoadFileName)");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\nSpecData.clsSpecSQL objSQL = new SpecData.clsSpecSQL();");
                strBuilder.AppendFormat("\r\nstring strTabName = \"{0}\";", objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\nstring strFldName = \"{0}\";", mstrImageFieldName);
                strBuilder.Append("\r\nStringBuffer strCondition = new StringBuffer();");
                /// strBuilder.Append("\r\nstrCondition.AppendFormat(\"Stdid = '{0}'\", objViewInfoENEx.Stdid);");
                strBuilder.Append("\r\nstrCondition.AppendFormat(\" ");
                strBuilder.AppendFormat("{0}", objKeyField.objFieldTabENEx.FldName);
                strBuilder.Append(" = '{0}'\", ");
                strBuilder.AppendFormat("{0});", clsString.FstLcaseS(objKeyField.objFieldTabENEx.FldName));
                strBuilder.Append("\r\nobjSQL.GetFile(strDownLoadFileName,strTabName, strFldName, strCondition.toString());");
                strBuilder.Append("\r\nreturn true;");
                strBuilder.Append("\r\n}");
            }
            return strBuilder.ToString();
        }

        public string gfunStoreFileToTabField(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:�洢�ļ������ļ��洢�����ݿ���ֶ��С�");
            strBuilder.Append("\r\n///		˵��:���¼����Ϊ��ǰ��������Ӧ�ļ�¼��");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strUpLoadFileName\">��Ҫ�洢���ļ���</param>");
            strBuilder.Append("\r\n/// <returns>����ɹ��ͷ���TRUE�����򷵻�FALSE</returns>");
            strBuilder.Append("\r\npublic boolean StoreFileToTabField(string strUpLoadFileName)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nstring strTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\nstring strFldName = \"{0}\";", mstrImageFieldName);
            strBuilder.Append("\r\nStringBuffer strCondition = new StringBuffer();");
            strBuilder.Append("\r\nstrCondition.AppendFormat(\" ");
            strBuilder.AppendFormat("{0}", objKeyField.objFieldTabENEx.FldName);
            strBuilder.Append(" = '{0}'\", ");
            strBuilder.AppendFormat("{0});", clsString.FstLcaseS(objKeyField.objFieldTabENEx.FldName));
            strBuilder.Append("\r\nSpecData.clsSpecSQL objSQL = new SpecData.clsSpecSQL();");
            strBuilder.Append("\r\nobjSQL.StoreFile(strUpLoadFileName,strTabName, strFldName, strCondition.toString());");
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunShowPic_S(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:��ʾͼƬ����ʾ��ؼ�����ؼ�¼��ͼƬ");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"imgPic\">��Ҫ��ʾͼƬ��image�ؼ�</param>");
            strBuilder.AppendFormat("\r\n/// <param name = \"{0}\">��¼�ؼ��ֵ�ֵ</param>",
            objKeyField.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n/// <param name = \"strWebFileDir\">����WEB��ʾ���ļ�·������URL</param>");
            strBuilder.Append("\r\n/// <param name = \"strDownloadFileDir\">���������ļ�ʱ����WEB���������ļ���Ŀ¼</param>");
            strBuilder.Append("\r\npublic static void ShowPic(System.Web.UI.WebControls.Image imgPic, ");
            strBuilder.AppendFormat("\r\n{0} {1}, ",
            objKeyField.objFieldTabENEx.objDataTypeAbbrEN.JavaType, objKeyField.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\nstring strWebFileDir, ");
            strBuilder.Append("\r\nstring strDownloadFileDir)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n");
            strBuilder.Append("\r\nimgPic.ImageUrl = \"\";");
            strBuilder.AppendFormat("\r\nif (cls{0}.IsExist({1}) == true)",
            objPrjTabENEx.TabName, objKeyField.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\ncls{0} obj{0} = new cls{0}({1});",
            objPrjTabENEx.TabName, objKeyField.objFieldTabENEx.PrivFuncName);
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
        public string gfunGetFileFromTabField_S(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:�����ݿ���ֶ��������ļ����ݡ��ú����Ǿ�̬(static)������");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strDownLoadFileName\">�������ص��ļ���</param>");
            strBuilder.AppendFormat("\r\n/// <param name = \"{0}\">��¼�ؼ��ֵ�ֵ</param>",
            objKeyField.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n/// <param name = \"strDownloadFileDir\">���������ļ�ʱ����WEB���������ļ���Ŀ¼</param>");
            strBuilder.Append("\r\npublic static boolean GetFileFromTabField(string strDownLoadFileName, ");
            strBuilder.AppendFormat("\r\n{0} {1}, ",
            objKeyField.objFieldTabENEx.objDataTypeAbbrEN.JavaType, objKeyField.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\nstring strDownloadFileDir)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nif (cls{0}.IsExist({1}) == true)",
            objPrjTabENEx.TabName, objKeyField.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\ncls{0} obj{0} = new cls{0}({1});",
            objPrjTabENEx.TabName, objKeyField.objFieldTabENEx.PrivFuncName);
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
        public string gfunGetDataTable_S(clsPrjTabENEx objPrjTabENEx)
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
        public string gfunIsExist(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�����ݿ����Ƿ���ڵ�ǰ����-----------------------;
            strBuilder.Append("\r\n public boolean IsExist()");
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            strBuilder.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"" + KeyWhereStr(objPrjTabENEx) + "))");
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
        public string gfunIsExist_S(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�����ݿ����Ƿ���ڵ�ǰ����(������̺���)-----------------------;
            ///objField.objFieldTabENEx.PrivFuncName;
            int i = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                if (i == 0)    //�Ƿ��ǵ�һ��
                {
                    strTemp = objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType + " " + objField.objFieldTabENEx.PrivFuncName;
                }
                else
                {
                    strTemp += ", " + objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType + " " + objField.objFieldTabENEx.PrivFuncName;
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
        public string gfunIsExistCondRec_S(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ����:�ж��Ƿ����ĳһ�����ļ�¼");
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n/// <returns>������ھͷ���TRUE�����򷵻�FALSE</returns>");
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
        public string gfunCheckProperty(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\npublic boolean CheckProperty(String strResult)");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabNullable == false && objField.objFieldTabENEx.IsIdentity == false)
                {
                    if (objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType != "int" && objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType != "boolean")
                    {
                        strBuilder.AppendFormat("\r\n if ((null == {0}) || (null != {0}) && ({0}.toString() == \"\")",
                        clsString.FstLcaseS(objField.objFieldTabENEx.FldName_Java));
                        if (string.IsNullOrEmpty(objField.objFieldTabENEx.CodeTabId) != true)
                        {
                            strBuilder.AppendFormat("\r\n || (null != {0}) && ({0}.toString() == \"0\")",
                            clsString.FstLcaseS(objField.objFieldTabENEx.FldName_Java));
                        }
                        strBuilder.Append(")");
                        strBuilder.Append("\r\n{");
                        strBuilder.Append("\r\nstrResult = \"�ֶ�[" + objField.objFieldTabENEx.Caption + "]����Ϊ��(NULL)!\";");
                        strBuilder.Append("\r\nreturn false;");
                        strBuilder.Append("\r\n}");
                    }
                }
            }
            ///������Գ��ȴ���;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" && objField.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType == "String" && objField.objFieldTabENEx.FldLength > 0)
                {
                    strBuilder.AppendFormat("\r\nif ((null != {0}) && (getStrLen({0}) > {1})",
                    clsString.FstLcaseS(objField.objFieldTabENEx.FldName_Java), objField.objFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append(")");
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n strResult = \"�ֶ�[{0}]�ĳ��Ȳ��ܳ���{1}!\";",
                    objField.objFieldTabENEx.Caption, objField.objFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append("\r\n return false;");
                    strBuilder.Append("\r\n }");
                }
            }
            strBuilder.Append("\r\nreturn true;");
            strBuilder.Append("\r\n}");
            ///������������Ƿ���ȷ == == == = ;
            return strBuilder.ToString();
        }

        public string gfunCheckPropertyNew(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\npublic void CheckProperty() throws dbobjexception ");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabNullable == false && objField.objFieldTabENEx.IsIdentity == false)
                {
                    if (objField.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType != "Integer"
                    && objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType != "boolean"
                    && objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType != "float"
                    && objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType != "double"
                    && objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType != "long")
                    {
                        strBuilder.AppendFormat("\r\n if ((null == {0}) || (null != {0}) && ({0}.toString() == \"\")",
                        clsString.FstLcaseS(objField.objFieldTabENEx.FldName_Java));
                        if (string.IsNullOrEmpty(objField.objFieldTabENEx.CodeTabId) != true)
                        {
                            strBuilder.AppendFormat("\r\n || (null != {0}) && ({0}.toString() == \"0\")",
                            clsString.FstLcaseS(objField.objFieldTabENEx.FldName_Java));
                        }
                        strBuilder.Append(")");
                        strBuilder.Append("\r\n{");
                        strBuilder.Append("\r\n throw new dbobjexception(\"�ֶ�[" + objField.objFieldTabENEx.Caption + "]����Ϊ��(NULL)!\");");
                        strBuilder.Append("\r\n}");
                    }
                }
            }
            ///������Գ��ȴ���;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.objFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                && objField.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType == "String"
                && objField.objFieldTabENEx.FldLength > 0)
                {
                    strBuilder.AppendFormat("\r\nif ((null != {0}) && (getStrLen({0}) > {1})",
                    clsString.FstLcaseS(objField.objFieldTabENEx.FldName_Java), objField.objFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append(")");
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n throw new dbobjexception(\"�ֶ�[{0}]�ĳ��Ȳ��ܳ���{1}!\");",
                    objField.objFieldTabENEx.Caption,
                    objField.objFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append("\r\n }");
                }
            }
            strBuilder.Append("\r\n}");
            ///������������Ƿ���ȷ == == == = ;
            return strBuilder.ToString();
        }

        public string gfunGetID(clsPrjTabENEx objPrjTabENEx)
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
            objKeyField.objFieldTabENEx.FldName, objPrjTabENEx.TabName,
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
            strTemp = objKeyField.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
            clsString.FstUcase_S(ref strTemp);
            strBuilder.Append("\r\n if (iCol == 0)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strKeyValue += String.valueOf(objRS.get" + strTemp + "(\"{0}\"));",
            objKeyField.objFieldTabENEx.FldName_Java);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strKeyValue += \"//\" + String.valueOf(objRS.get" + strTemp + "(\"{0}\"));",
            objKeyField.objFieldTabENEx.FldName_Java);
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
        /// ���ɴ���:�ṩ��������ѯ�ؼ��֣�����ж���ؼ��֣���ȡ���еĵ�һ�������������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public string gfunGetFirstID(clsPrjTabENEx objPrjTabENEx)
        {

            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.AppendFormat("\r\n public {0} GetFirstID(String strCondtion) ", objKeyField.objFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n String strSQL ;");
            strBuilder.Append("\r\n ResultSet objRS = null;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            //			strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.AppendFormat("\r\n {0} {1}KeyValue; ",
            objKeyField.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
            objKeyField.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.AppendFormat("\r\n strSQL = \"Select " + objPrjTabENEx.Keys + " from {0} where \" + strCondtion;",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n objRS = objSQL.GetResultSet(strSQL);");
            strBuilder.Append("\r\n if (objRS.next()) ");
            strBuilder.Append("\r\n {");
            strTemp = objKeyField.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
            clsString.FstUcase_S(ref strTemp);
            strBuilder.AppendFormat("\r\n {2}KeyValue = objRS.get{0}(\"{1}\");",
            strTemp,
            objKeyField.objFieldTabENEx.FldName_Java,
            objKeyField.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            switch (objKeyField.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType)
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
            objKeyField.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n ");

            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:�ṩ��������ѯ�ؼ��֣�����ж���ؼ��֣���ȡ���еĵ�һ�������������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public string gfunGetFirstID_S(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.AppendFormat("\r\npublic static {0} GetFirstID_S(String strCondtion) ", objKeyField.objFieldTabENEx.objDataTypeAbbrEN.JavaType);
            strBuilder.Append("\r\n throws SQLException, ClassNotFoundException, NamingException ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n String strSQL ;");
            strBuilder.Append("\r\n ResultSet objRS = null;");
            strBuilder.Append("\r\n clsSpecSQL objSQL = new clsSpecSQL();");
            //			strBuilder.Append("\r\nint iRow, iCol; ");
            strBuilder.AppendFormat("\r\n {0} {1}KeyValue; ",
            objKeyField.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
            objKeyField.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.AppendFormat("\r\n strSQL = \"Select " + objPrjTabENEx.Keys + " from {0} where \" + strCondtion;",
            objPrjTabENEx.TabName,
            objPrjTabENEx.TabSpace);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n objRS = objSQL.GetResultSet(strSQL);");
            strBuilder.Append("\r\n if (objRS.next()) ");
            strBuilder.Append("\r\n {");
            strTemp = objKeyField.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
            clsString.FstUcase_S(ref strTemp);
            strBuilder.AppendFormat("\r\n {2}KeyValue = objRS.get{0}(\"{1}\");",
            strTemp,
            objKeyField.objFieldTabENEx.FldName_Java,
            objKeyField.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n else");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objRS = null;");
            switch (objKeyField.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType)
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
            objKeyField.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n ");

            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }


        public string gfunGetReader(clsPrjTabENEx objPrjTabENEx)
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
        public string gfunGetTable(clsPrjTabENEx objPrjTabENEx)
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


        public string gfunGetTableBySQL(clsPrjTabENEx objPrjTabENEx)
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
        public string gfunTransNullToStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///˽�к���Begin-------------------------------------;
            strBuilder.Append("\r\nprivate string TransNullToStr(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (obj.toString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn \"\";");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn obj.toString();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunTransNullToInt()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\nprivate int TransNullToInt(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (obj.toString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn Int32.Parse(obj.toString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunTransNullToDate()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\nprivate DateTime TransNullToDate(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (obj.toString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn DateTime.Parse(\"#1/1/1900#\");");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn DateTime.Parse(obj.toString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfunTransNullToFloat()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\nprivate float TransNullToFloat(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (obj.toString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0.0f;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn float.Parse(obj.toString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gfunTransNullToDouble()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\nprivate double TransNullToDouble(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (obj.toString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn 0.0;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn double.Parse(obj.toString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            return strBuilder.ToString();
        }
        public string gfunTransNullToBool()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\nprivate boolean TransNullToBool(Object obj) ");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nif (obj.toString() == \"\")");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn false;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn boolean.Parse(obj.toString());");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }
        public string gfungetStrLen()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡ�ַ������ȣ����к���Ϊ2���ֽڣ�Ӣ��Ϊ1���ֽ�---------;
            strBuilder.Append("\r\npublic int getStrLen(String strTemp)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nint len ;");
            strBuilder.Append("\r\n//byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);");
            strBuilder.Append("\r\nlen = strTemp.getBytes().length;//will output as 3+3*2 = 9");
            strBuilder.Append("\r\nreturn len;");
            strBuilder.Append("\r\n}");
            ///��ȡ�ַ������ȣ����к���Ϊ2���ֽڣ�Ӣ��Ϊ1��;
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
            ///��ȡ�ַ������ȣ����к���Ϊ2���ֽڣ�Ӣ��Ϊ1���ֽ� == ;
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

        public string GenComboBoxBindFunction(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";

            try
            {
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.objFieldTabENEx.FldName;
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.objFieldTabENEx.FldName;
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "public static ResultSet Get{0}()",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
                    strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
                    strValueFieldName, strTextFieldName, objPrjTabENEx.TabName,
                    objPrjTabENEx.TabSpace);
                    //						if (objField.DS_CondStr.Trim() == "")
                    //						{
                    //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						}
                    //						else
                    //						{
                    //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objField.DS_CondStr);
                    //						}
                    strCodeForCs.Append("\r\n" + "clsSpecSQL mySql = new clsSpecSQL();");
                    strCodeForCs.Append("\r\n" + "ResultSet objRS = mySql.GetResultSet(strSQL);");
                    strCodeForCs.Append("\r\n" + "return objRS;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// �󶨻���Win��������");
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name = \"objComboBox\">��Ҫ�󶨵�ǰ���������</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//Ϊ����ԴΪ�����������������");
                    strCodeForCs.AppendFormat("\r\n" + "ResultSet objRS = Get{0}();",
                    strValueFieldName);
                    //								strCodeForCs.Append("\r\n" + "DataRow objRow = objRS.NewRow();");
                    //								strCodeForCs.AppendFormat("\r\n" + "objRow[\"{0}\"] = \"0\";",
                    //									strValueFieldName);
                    //								strCodeForCs.AppendFormat("\r\n" + "objRow[\"{0}\"] = \"��ѡ��1...\";",
                    //									strTextFieldName);
                    //								strCodeForCs.Append("\r\n" + "objRS.Rows.InsertAt(objRow,0);");
                    //			
                    //								strCodeForCs.Append("\r\n" + "//���������������Դ���Լ�����ֵ���ʾ��");
                    //								strCodeForCs.Append("\r\n" + "objComboBox.DataSource = objRS;");
                    //								strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = \"{0}\";", 
                    //									strValueFieldName);
                    //								strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = \"{0}\";", 
                    //									strTextFieldName);
                    //								strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");

                    strCodeForCs.AppendFormat("\r\n" + "cls{0} obj{0};",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "//��ʼ��һ�������б�");
                    strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//�����0��ڵ�0���в��롰��ѡ��...����Ϊ�˷����û�����WEB��ʽ���ơ�");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0} = new cls{0}();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = \"0\";",
                    objPrjTabENEx.TabName, strValueFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = \"��ѡ��[{2}]...\";",
              objPrjTabENEx.TabName, strTextFieldName, objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0});",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//��DataTable�е���������ӵ������б���");
                    strCodeForCs.Append("\r\n" + "foreach(DataRow objRow in objRS.Rows)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0} = new cls{0}();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = objRow[\"{1}\"].toString();",
                    objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = objRow[\"{1}\"].toString();",
                    objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0});",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//���������������Դ���Լ�����ֵ���ʾ��");
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = {0}List;",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = \"{0}\";",
                    strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = \"{0}\";",
                    strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsGeneralTab2.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string GenDdlBindFunction(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
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
                        strValueFieldName = objField.objFieldTabENEx.FldName;
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.objFieldTabENEx.FldName;
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    //					strCodeForCs.AppendFormat("\r\n" + "public ResultSet Get{0}()", 
                    //						strValueFieldName);
                    //					strCodeForCs.Append("\r\n" + "{");
                    //					strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
                    //					strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //						strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //					//									if (objViewCtlField.DS_CondStr.Trim() == "")
                    //					//									{
                    //					//										strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //					//											strValueFieldName, strTextFieldName, objViewCtlField.DS_TabName);
                    //					//									}
                    //					//									else
                    //					//									{
                    //					//										strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    //					//											strValueFieldName, strTextFieldName, objViewCtlField.DS_TabName, objViewCtlField.DS_CondStr);
                    //					//									}
                    //					strCodeForCs.Append("\r\n" + "clsSpecSQL mySql = new clsSpecSQL();");
                    //					strCodeForCs.Append("\r\n" + "ResultSet objRS = mySql.GetResultSet(strSQL);");
                    //					strCodeForCs.Append("\r\n" + "return objRS;");
                    //					strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// �󶨻���Web��������");
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name = \"objDDL\">��Ҫ�󶨵�ǰ���������</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");

                    strCodeForCs.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"��ѡ��[{0}]...\",\"0\");",
                      objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "ResultSet objRS = Get{0}();",
                    strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = \"{0}\";", strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = \"{0}\";", strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = objRS;");
                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }

            catch (Exception ex)
            {
                clsGeneralTab2.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// �ѱ������ݰ󶨵�ListView��
        /// </summary>
        /// <returns></returns>
        public string GenBindListView(clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //strCodeForCs.Append("\r\n" + "//1/���ɰ�ListView�Ĵ���");
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��");
                strCodeForCs.Append("\r\n" + "///			 ����ʾ��ListView�С�");
                strCodeForCs.Append("\r\n" + "/// </summary>");
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
                strCodeForCs.AppendFormat("\r\n" + "ArrayList arr{0}ObjLst;",
                objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = new cls{0}().GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	3������ListView����ͷ��Ϣ");
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Clear();//���ԭ������Item",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Clear();//���ԭ��������ͷ��Ϣ",
                objPrjTabENEx.TabName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId != "04" && objField.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType != "Byte[]") //���ǹ����ֶ�
                    {
                        strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Add(\"{1}\", 100, System.Windows.Forms.HorizontalAlignment.Left);",
                        objPrjTabENEx.TabName, objField.objFieldTabENEx.Caption);
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.View = System.Windows.Forms.View.Details;",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��");
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0} obj{0} in arr{0}ObjLst)",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "lvi{0} = new System.Windows.Forms.ListViewItem();",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Tag = obj{0}.{1};",
                objPrjTabENEx.TabName, objKeyField.objFieldTabENEx.FldName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Text = obj{0}.{1};",
                objPrjTabENEx.TabName, objKeyField.objFieldTabENEx.FldName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objKeyField.FldID == objField.FldID)
                    {
                        continue;
                    }
                    if (objField.FieldTypeId != "04"
                    && objField.IsTabForeignKey == false
                    && objField.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType != "Byte[]")
                    {
                        if (objField.objFieldTabENEx.objDataTypeAbbrEN.JavaObjType == "String")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}.{1});",
                            objPrjTabENEx.TabName, objField.objFieldTabENEx.FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}.{1}.toString());",
                            objPrjTabENEx.TabName, objField.objFieldTabENEx.FldName);
                        }
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Add(lvi{0});",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//	4�����ü�¼����״̬��");
                strCodeForCs.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�");
                strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst.Count;",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsGeneralTab2.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string gfunGetTabDict(clsPrjTabENEx objPrjTabENEx)
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
                    strValueFieldName = objField.objFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "03")//�����ֶ�
                {
                    strTextFieldName = objField.objFieldTabENEx.FldName;
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
                if (objField.objFieldTabENEx.FldName == strValueFieldName ||
                objField.objFieldTabENEx.FldName == strTextFieldName)
                {
                    strTemp = objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
                    clsString.FstUcase_S(ref strTemp);
                    //if (strTemp == "Int" || strTemp == "Double" || strTemp == "Long")
                    //{
                    // strBuilder.AppendFormat("\r\n {4} {0}{1} = objRS.get{2}(\"{3}\");",
                    // objField.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                    // clsString.FirstUcaseS(objField.objFieldTabENEx.FldName), 
                    // strTemp, 
                    // objField.objFieldTabENEx.FldName,
                    // objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType);
                    // strBuilder.AppendFormat("\r\n" + "obj{0}.set{1}(new {2}({3}{4}));",
                    // objPrjTabENEx.TabName, 
                    // clsString.FirstUcaseS(objField.objFieldTabENEx.FldName),
                    // objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    // objField.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                    // clsString.FirstUcaseS(objField.objFieldTabENEx.FldName));
                    //}
                    //else
                    //{
                    strBuilder.AppendFormat("\r\n" + "obj{0}.set{1}(objRS.get{2}(\"{3}\"));",
                    objPrjTabENEx.TabName,
                    clsString.FirstUcaseS(objField.objFieldTabENEx.FldName_Java),
                    strTemp,
                    objField.objFieldTabENEx.FldName);
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


        public string gfunGetTabDictWithCond(clsPrjTabENEx objPrjTabENEx)
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
                    strValueFieldName = objField.objFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "03")
                {
                    strTextFieldName = objField.objFieldTabENEx.FldName;
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
                if (objField.objFieldTabENEx.FldName == strValueFieldName ||
                objField.objFieldTabENEx.FldName == strTextFieldName)
                {
                    strTemp = objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType;
                    clsString.FstUcase_S(ref strTemp);
                    //if (strTemp == "Int" || strTemp == "Double" || strTemp == "Long")
                    //{
                    // strBuilder.AppendFormat("\r\n {4} {0}{1} = objRS.get{2}(\"{3}\");",
                    // objField.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                    // clsString.FirstUcaseS(objField.objFieldTabENEx.FldName), 
                    // strTemp, 
                    // objField.objFieldTabENEx.FldName,
                    // objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType);
                    // strBuilder.AppendFormat("\r\n" + "obj{0}.set{1}(new {2}({3}{4}));",
                    // objPrjTabENEx.TabName, 
                    // clsString.FirstUcaseS(objField.objFieldTabENEx.FldName),
                    // objField.objFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    // objField.objFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr,
                    // clsString.FirstUcaseS(objField.objFieldTabENEx.FldName));
                    //}
                    //else
                    //{
                    strBuilder.AppendFormat("\r\n" + "obj{0}.set{1}(objRS.get{2}(\"{3}\"));",
                    objPrjTabENEx.TabName,
                    clsString.FirstUcaseS(objField.objFieldTabENEx.FldName_Java),
                    strTemp,
                    objField.objFieldTabENEx.FldName);
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
        public override string GeneCode( ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strResult = "";
            if (objPrjTabENEx.TabFldNum == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
                     objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum == 0)
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
            List<clsvFunctionTemplateRelaEN> arrvFunctionTemplateRelaObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId,
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SQLDSTypeId);

              
            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "EN";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.EntityLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabENEx.FuncModuleAgcId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName, objPrjTabENEx.SimpleFileName);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjId_Cache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

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
                    strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName + " : clsGeneralTab");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public class {0} : {1}",
                        objPrjTabENEx.ClsName,
                        objPrjTabENEx.ParentClass);
                }
                strCodeForCs.Append("\r\n" + "{");

                //˽��������-----�����Թ���
                strCodeForCs.Append("\r\n" + "public static var CurrTabName_S : String = \"" + objPrjTabENEx.TabName + "\"; //��ǰ����,�������صı���");
                strCodeForCs.Append("\r\n" + "public static var CurrTabKeyFldName_S : String = \"" + objPrjTabENEx.KeyFldNameLstStr + "\"; //��ǰ���еĹؼ�������,�������صı��йؼ�����");
                //������������صĳ�������

                //������������صĴ���
                strCodeForCs.AppendFormat("\r\n" + "public static var mintAttributeCount : Int = {0};",
                objPrjTabENEx.arrFldSet.Count);
                strTemp = "";
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (strTemp == "")
                    {
                        strTemp += "\"" + objField.objFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strTemp += ", \"" + objField.objFieldTabENEx.FldName + "\"";
                    }
                }
                //strTemp += "}";
                strCodeForCs.AppendFormat("\r\n" + "public static var AttributeName : [String] = [{0}];",
                  strTemp);

                strCodeForCs.Append("\r\n" + "//���������Ա���");

                //�������еĺ���


                foreach (clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN in arrvFunctionTemplateRelaObjLst)
                {
                    string strFuncName = objvFunctionTemplateRelaEN.FuncName;
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC_Cache(objvFunctionTemplateRelaEN.FuncId4GC);
                    strTemp = A_GeneFuncCode(objFunction4GeneCodeEN);
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
                clsGeneralTab2.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����Entity�����
        /// </summary>
        /// <returns></returns>
        public override string A_GenEntityLayerCode_Sim(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strResult = "";
            if (objPrjTabENEx.TabFldNum == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
                               objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum == 0)
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
           
            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "EN_Sim";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.EntityLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabENEx.FuncModuleAgcId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName, objPrjTabENEx.SimpleFileName);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjId_Cache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));
                strCodeForCs.AppendFormat("\r\n" + "package {0}.Entity;",
                objProject.JavaPackageName);
                //������ʼ
                strCodeForCs.Append("\r\n" + "import java.sql.*;"); //
                strCodeForCs.Append("\r\n" + "import java.sql.Date;");
                strCodeForCs.Append("\r\n" + "import java.util.*; "); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.commdb.*;"); //
                strCodeForCs.Append("\r\n" + "import com.taishsoft.commexception.*;"); //

                strCodeForCs.Append("\r\n" + "{");

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
                    strCodeForCs.Append("\r\n" + "[Serializable]");
                    strCodeForCs.Append("\r\n" + "[DataContractAttribute]");
                //}
                strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName + " ");
                strCodeForCs.Append("\r\n" + "{");

                //˽��������-----�����Թ���
                //strCodeForCs.Append("\r\n" + "public const string CurrTabName_S = \"" + objPrjTabENEx.TabName + "\"; //��ǰ����,�������صı���");
                //strCodeForCs.Append("\r\n" + "public const string CurrTabKeyFldName_S = \"" + objPrjTabENEx.KeyFldNameLstStr + "\"; //��ǰ���еĹؼ�������,�������صı��йؼ�����");
                //������������صĳ�������

                //������������صĴ���
                //strCodeForCs.AppendFormat("\r\n" + "internal const int mintAttributeCount = {0};",
                //objPrjTabENEx.arrFldSet.Count);
                //strTemp = "{";
                //foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                //{
                //  if (strTemp == "{")
                //  {
                //    strTemp += "\"" + objField.objFieldTabENEx.FldName + "\"";
                //  }
                //  else
                //  {
                //    strTemp += ", \"" + objField.objFieldTabENEx.FldName + "\"";
                //  }
                //}
                //strTemp += "}";
                //strCodeForCs.AppendFormat("\r\n" + "public static string[] AttributeName = new string[] {0};",
                //strTemp);

                strCodeForCs.Append("\r\n" + "//���������Ա���");

                //�������еĺ���
                List<clsvFunctionTemplateRelaEN> arrvFunctionTemplateRelaObjLst =
                             clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId,
                             objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SQLDSTypeId);

                foreach (clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN in arrvFunctionTemplateRelaObjLst)
                {
                    string strFuncName = objvFunctionTemplateRelaEN.FuncName;
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC_Cache(objvFunctionTemplateRelaEN.FuncId4GC);
                    strTemp = A_GeneFuncCode(objFunction4GeneCodeEN);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsGeneralTab2.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����DAL(���ݴ����)����
        /// </summary>
        /// <returns></returns>
        public override string A_GenDALCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strResult = "";
            clsErrorIdManageBLEx.arrErrIdLst_Cache = null;
            if (objPrjTabENEx.TabFldNum == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
                      objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum == 0)
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

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "DA";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.DataAccessLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabENEx.FuncModuleAgcId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName, objPrjTabENEx.SimpleFileName);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjId_Cache(objPrjTabENEx.PrjId); //

            try
            {
                //������ʼ

                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic; "); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");

                strCodeForCs.Append("\r\n" + "using com.taishsoft.commexception;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.commdb;"); //
                strCodeForCs.Append("\r\n" + "using CommonTable.Entity;"); //

                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;",
                objProject.PrjDomain); //

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.DAL",
                objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                //˽��������-----�����Թ���
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��ǰ����");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public const string CurrTabName_S = \"" + objPrjTabENEx.TabName + "\"; //��ǰ����,�������صı���");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��ǰ���еĹؼ�������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public const string CurrTabKeyFldName_S = \"" + objPrjTabENEx.KeyFldNameLstStr + "\"; //��ǰ���еĹؼ�������,�������صı��йؼ�����");
                //������������صĴ���
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ʵ������������б����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected const int mintAttributeCount = {0};",
                      objPrjTabENEx.arrFldSet.Count);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ������Ϣ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected const string EXCEPTION_MSG = \"����:\"; //there was an error in the method. please see the Application Log for details.\";");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ģ������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected string mstrModuleName;");

                strTemp = "{";
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (strTemp == "{")
                    {
                        strTemp += "\"" + objField.objFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strTemp += ", \"" + objField.objFieldTabENEx.FldName + "\"";
                    }
                }
                strTemp += "}";
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ʵ������������б�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public static string[] AttributeName = new string[] {0};",
                strTemp);

                strCodeForCs.Append("\r\n" + "//���������Ա���");

                //�������еĺ���
                List<clsvFunctionTemplateRelaEN> arrvFunctionTemplateRelaObjLst =
  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId,
  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SQLDSTypeId);


                foreach (clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN in arrvFunctionTemplateRelaObjLst)
                {
                    string strFuncName = objvFunctionTemplateRelaEN.FuncName;
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC_Cache(objvFunctionTemplateRelaEN.FuncId4GC);
                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }

                    strTemp = A_GeneFuncCode(objFunction4GeneCodeEN);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");


            }
            catch (Exception ex)
            {
                clsGeneralTab2.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ����DAL(���ݴ����)����,�����ͼ
        /// </summary>
        /// <returns></returns>
        public override string A_GenDALCode4ViewBak20170330(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strResult = "";
            if (objPrjTabENEx.TabFldNum == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
                    objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum == 0)
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
          
            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "DA";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.DataAccessLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabENEx.FuncModuleAgcId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName, objPrjTabENEx.SimpleFileName);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjId_Cache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic; "); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.commexception;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.commdb;"); //
                strCodeForCs.Append("\r\n" + "using CommonTable.Entity;"); //

                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;",
                objProject.PrjDomain); //

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.DAL",
                objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                //˽��������-----�����Թ���
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��ǰ����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public const string CurrTabName_S = \"" + objPrjTabENEx.TabName + "\"; //��ǰ����,�������صı���");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��ǰ���еĹؼ�������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public const string CurrTabKeyFldName_S = \"" + objPrjTabENEx.KeyFldNameLstStr + "\"; //��ǰ���еĹؼ�������,�������صı��йؼ�����");
                //������������صĴ���
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ʵ������������б����");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected const int mintAttributeCount = {0};",
                      objPrjTabENEx.arrFldSet.Count);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ������Ϣ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected const string EXCEPTION_MSG = \"����:\"; //there was an error in the method. please see the Application Log for details.\";");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ģ������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected string mstrModuleName;");

                strTemp = "{";
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (strTemp == "{")
                    {
                        strTemp += "\"" + objField.objFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strTemp += ", \"" + objField.objFieldTabENEx.FldName + "\"";
                    }
                }
                strTemp += "}";
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ʵ������������б�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public static string[] AttributeName = new string[] {0};",
                strTemp);

                strCodeForCs.Append("\r\n" + "//���������Ա���");

                //�������еĺ���

                List<clsvFunctionTemplateRelaEN> arrvFunctionTemplateRelaObjLst =
             clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId,
             objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SQLDSTypeId);

                foreach (clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN in arrvFunctionTemplateRelaObjLst)
                {
                    string strFuncName = objvFunctionTemplateRelaEN.FuncName;
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC_Cache(objvFunctionTemplateRelaEN.FuncId4GC);
                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }
                    strTemp = A_GeneFuncCode(objFunction4GeneCodeEN);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsGeneralTab2.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


    }
}
