using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.sql;



using AGC.Entity;

using AGC.BusinessLogic;
using AgcCommBase;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using System.Reflection;
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
    class NodeDALCode4CSharp : clsGeneCodeBase
    {


        #region ���캯��

        public NodeDALCode4CSharp()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public NodeDALCode4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
        }
        #endregion



        /// <summary>
        /// Ϊ�ֶ����������ֶ�ֵ
        /// </summary>
        /// <returns></returns>
        public override string GenSetCondFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();



            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// ����������ȡ�����б�-{0}[{1}]", objField.ObjFieldTabENEx.FldCnName, objField.ObjFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�ֶ�����ֵ</param>", objField.ObjFieldTabENEx.PrivPropName);
                strBuilder.Append("\r\n /// <param name = \"strComparisonOp\">�Ƚ������</param>");
                strBuilder.Append("\r\n /// <returns>void</returns>");
                strBuilder.AppendFormat("\r\npublic void SetCond_{0}({1} {2}, string strComparisonOp)",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                strBuilder.Append("\r\n{");
                strBuilder.AppendFormat("\r\n" + "this.{0} = {1};", objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.PrivFuncName);
                strBuilder.AppendFormat("\r\n" + "if (dicFldComparisonOp.ContainsKey(con{0}) == false)", objField.ObjFieldTabENEx.FldName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "dicFldComparisonOp.Add(con{0}, strComparisonOp);", objField.ObjFieldTabENEx.FldName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.AppendFormat("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "dicFldComparisonOp[con{0}] = strComparisonOp;", objField.ObjFieldTabENEx.FldName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n}");

            }

            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

      
        /// <summary>
        /// ����DAL(���ݴ����)����
        /// </summary>
        /// <returns></returns>
        public override string GeneCode( ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
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
clsvFunction4GeneCodeBLEx.GetObjLstByPrjTabEx(objPrjTabENEx, this.CmPrjId);

  

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "DA";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.DataAccessLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //

            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic; "); //
                strCodeForCs.Append("\r\n" + "using Newtonsoft.Json;"); //
                strCodeForCs.Append("\r\n" + "using System.Linq;"); //
                strCodeForCs.Append("\r\n" + "using Neo4jClient.Cypher;"); //

                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");

                strCodeForCs.Append("\r\n" + "using com.taishsoft.commexception;");
                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.comm_db_obj;"); //
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

                strCodeForCs.AppendFormat("\r\n" + "public class  {0} : clsCommBase4DA", objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

           
                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// ʵ������������б����");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.AppendFormat("\r\n" + "protected const int mintAttributeCount = {0};",
                //      objPrjTabENEx.arrFldSet.Count);
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

              
                strCodeForCs.Append("\r\n" + "//���������Ա���");
                

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");                
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
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
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
             
            }
            return strCodeForCs.ToString();
        }
     
       
        public string A_GenSQLCode4CreateTab(string strPrjDataBaseId)
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
            string strIsNullable;       //, strIsNullable0;		// = " null ";
            string strPrimaryKey;       //, strPrimaryKey0;
            string strFieldLength, strFieldLength0;     //�ֶγ���
            string strFldPrecision;
            ArrayList arrFieldCodes = new ArrayList();

            ///��������˽������
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetAll)
            {
                //				strBuilder.Append("\r\n" +clsPrjTabFldBLEx.DefPrivateProperty(objPrjTabENEx.LangType, objField));

                ///�����ֶ���
                strFieldName = objField.ObjFieldTabENEx.FldName;
                ///�����ֶ�����
                strFieldType = objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///�����ֶγ���
                strFieldLength0 = objField.ObjFieldTabENEx.FldLength.ToString();
                strFldPrecision = objField.ObjFieldTabENEx.FldPrecision.ToString();
                if (strFieldLength0 == string.Empty)
                    strFieldLength = string.Empty;
                else if (strFieldType == "decimal" || strFieldType == "numeric")
                {
                    strFieldLength = string.Format("({0},{1})", strFieldLength0, strFldPrecision);
                }
                else
                {
                    strFieldLength = "(" + strFieldLength0 + ")";
                }
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
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strPrimaryKey = " primary key identity";
                    if (strFieldType == "bigint identity")
                    {
                        strFieldType = "bigint";
                    }
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
        public virtual string Gen_Neo4JDA_GetSpecSQLObj()
        {
            //return "";
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

        public virtual string Gen_Neo4JDA_GetSpecSQLObj_Obj()
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
                Type t = typeof(NodeDALCode4CSharp);
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
            this.ClsName = string.Format("cls{0}DA", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
        public virtual string Gen_Neo4JDA_AddNewNode()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��������--------------------------------------;
            ///����¼�¼----------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����½��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>����Ƿ�ɹ�?</returns>");

            strBuilder.AppendFormat("\r\n public bool AddNewNode(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckPropertyNew(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");


            strBuilder.Append("\r\n" + "StringBuilder sbFldNameLst = new StringBuilder();");
            strBuilder.Append("\r\n" + "List<string> arrFldName = new List<string>();");
            strBuilder.Append("\r\n" + "IDictionary<string, object> dicParam = new Dictionary<string, object>();");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                //if (objField.PrimaryTypeId == enumPrimaryType.Identity_02 && objField.FieldTypeId == enumFieldType.KeyField_02)
                //{
                //    continue;
                //}
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (new List<string>(){enumFldOperationType.OnlyWrite_0003, enumFldOperationType.ReadWrite_0001}.Contains( objField.FldOpTypeId)) //ֻд
                {
                    if (objField.IsTabNullable == true && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                    {
                        strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{1}) == false)", objPrjTabENEx.TabName, objField.FldName);
                        strBuilder.Append("\r\n" + "{");
                        strBuilder.AppendFormat("\r\n" + "arrFldName.Add(string.Format(\"{{0}}:{{{{ {{0}} }}}}\", con{0}.{1}));", objPrjTabENEx.TabName, objField.FldName);
                        strBuilder.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}EN.{1});", objPrjTabENEx.TabName, objField.FldName);
                        strBuilder.Append("\r\n" + "}");            
                    }
                    else
                    {                    
                        strBuilder.AppendFormat("\r\n" + "arrFldName.Add(string.Format(\"{{0}}:{{{{ {{0}} }}}}\", con{0}.{1}));", objPrjTabENEx.TabName, objField.FldName);
                        strBuilder.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}EN.{1});", objPrjTabENEx.TabName, objField.FldName);                    
                    }                  
                }
            }

            strBuilder.Append("\r\n" + "string strFldNameLst = string.Join(\", \", arrFldName);");
            strBuilder.AppendFormat("\r\n" + "string strFldNameSet = string.Format(\"(p1:{0} {{{{ {{0}} }}}})\", strFldNameLst);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const query = clsSysParaEN_Neo4J.GraphClient.Cypher");
            strBuilder.Append("\r\n" + ".Create(strFldNameSet)");
            strBuilder.Append("\r\n" + ".WithParams(dicParam)");
            strBuilder.Append("\r\n" + ".ExecuteWithoutResultsAsync();");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw objException;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "return true;");

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
            strBuilder.Append("\r\nArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            int intCount = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                intCount++;
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.PrimaryTypeId == "02" && objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    continue;
                }
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strBuilder.AppendFormat("\r\n{0},", strPrivPropNameWithObjectName4Get);
                    continue;
                }
                if (intCount == objPrjTabENEx.arrFldSet.Count)
                {
                    strBuilder.AppendFormat("\r\n{0}", strPrivPropNameWithObjectName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n {0},", strPrivPropNameWithObjectName);
                }
            }
            strBuilder.Append("\r\n};");
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
            strBuilder.Append("\r\nArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            int intCount = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                intCount++;
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.FldOpTypeId == "0003")
                {
                    strBuilder.AppendFormat("\r\n {0},", strPrivPropNameWithObjectName4Get);
                    continue;
                }
                if (intCount == objPrjTabENEx.arrFldSet.Count)
                {
                    strBuilder.AppendFormat("\r\n {0}", strPrivPropNameWithObjectName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n {0},", strPrivPropNameWithObjectName);
                }
            }
            strBuilder.Append("\r\n};");
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
            strBuilder.Append("\r\nArrayList values = new ArrayList()");
            strBuilder.Append("\r\n{");
            int intCount = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                intCount++;
                if (intCount == objPrjTabENEx.arrFldSet.Count)
                {
                    strBuilder.Append("\r\n " + objField.ObjFieldTabENEx.PrivFuncName  );
                }
                else
                {
                    strBuilder.Append("\r\n " + objField.ObjFieldTabENEx.PrivFuncName + ",");
                }
            }
            strBuilder.Append("\r\n};");
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
                        strTT = string.Format("oRow[con{1}.{0}].ToString().Trim()",
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
                strBuilder.AppendFormat("\r\nobjRow[con{1}.{2}] = oRow[con{1}.{2}].ToString().Trim(); //{0}",
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
                    strBuilder.AppendFormat("\r\n if (obj{1}EN.IsUpdated(con{1}.{0}))",
               objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n {");
                    strBuilder.AppendFormat("\r\nobjRow[con{1}.{2}] = {3}; //{0}",
                        objField.ColCaption,
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName,
                    strPrivPropNameWithObjectName4Get);
                    strBuilder.Append("\r\n }");
                    continue;
                }

                strBuilder.AppendFormat("\r\n if (obj{1}EN.IsUpdated(con{1}.{0}))",
                objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\nobjRow[con{1}.{2}] = {3}; //{0}",
                    objField.ColCaption,
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName,
                     strPrivPropNameWithObjectName);
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

        public virtual string Gen_Neo4JDA_UpdateBySqlWithCondition()
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


        public virtual string Gen_Neo4JDA_UpdateNode()
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
            strBuilder.AppendFormat("\r\npublic bool UpdateNode(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n if (obj{0}EN._IsCheckProperty  ==  false)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n CheckProperty4Update(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "StringBuilder sbFldNameLst = new StringBuilder();");
            strBuilder.Append("\r\n" + "List<string> arrFldName = new List<string>();");
            strBuilder.Append("\r\n" + "IDictionary<string, object> dicParam = new Dictionary<string, object>();");
            strBuilder.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}EN.{1});", objPrjTabENEx.TabName, objKeyField.FldName);

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (IsKeyField(objField.ObjFieldTabENEx.FldName) == true) continue;
                if (objField.FieldTypeId == enumFieldType.CalcField_11) continue;
                string strTemp = GetCode4FieldInUpdateNode(objField);
                strBuilder.AppendFormat("\r\n {0}", strTemp);

                //}

            }
            
            strBuilder.Append("\r\n" + "string strFldNameLst = string.Join(\", \", arrFldName);");
            strBuilder.AppendFormat("\r\n" + "string strFldNameSet = string.Format(\"{{0}} \", strFldNameLst);", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const query = clsSysParaEN_Neo4J.GraphClient.Cypher");
    
            strBuilder.AppendFormat("\r\n" + ".Match(\"(p:{0})\")", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + ".Where(\"p.{0}={{ {0} }}\")", objKeyField.FldName);
            strBuilder.Append("\r\n" + ".Set(strFldNameLst)");
            strBuilder.Append("\r\n" + ".WithParams(dicParam)");
            strBuilder.Append("\r\n" + ".ExecuteWithoutResultsAsync();");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"��������:[{{0}}].({{1}})\"," );
            strBuilder.Append("\r\n" + "     objException.Message, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");

            //            strBuilder.Append("\r\nclsGeneralTab2.LogErrorS(objException, \"\");");
            strBuilder.Append("\r\nthrow new Exception(strMsg);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nfinally");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n return true;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///�޸ļ�¼ == = ;
            return strBuilder.ToString();
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
                string strTemp = GetCode4FieldInUpdateNode(objField);
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
        public virtual string Gen_Neo4JDA_GetRecCountByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ��ǰ�������������ļ�¼��, �ñ��뵱ǰ����ء�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}Cond\">���ڸ�����������������</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.AppendFormat("\r\n public static long GetRecCountByCond(cls{0}EN obj{0}Cond)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            //strBuilder.Append("\r\n try");
            //strBuilder.Append("\r\n{");

            //strBuilder.AppendFormat("\r\nCheckProperty4Condition(obj{0}Cond);", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n}");
            //strBuilder.Append("\r\ncatch (Exception objException)");
            //strBuilder.Append("\r\n{");

            //string strFunctionName = string.Format("GetRecCountByCond", objPrjTabENEx.TabName, objKeyField.FldName);
            //string strExplanation = "�����������к���{0},����!";
            //string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
            //    objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            //strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})�����������к���{{0}},����!({1}:GetRecCountByCond)\", objException.Message));",
            //            objPrjTabENEx.TabName,
            //            objPrjTabENEx.ClsName,
            //            "{", "}",
            //            strErrId);
            //strBuilder.Append("\r\n}");

            strBuilder.Append("\r\n" + "IDictionary<string, object> dicParam = new Dictionary<string, object>();");
            //strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{0}Id) == false)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{0}Id));");
            //strBuilder.Append("\r\n" + "dicParam.Add(con{0}.{0}Id, obj{0}EN.{0}Id);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
            strBuilder.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");


            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeId) //objEditRegionFldsEx.objCtlType.CtlTypeName
                {
                    case enumDataTypeAbbr.bit_03:
                        strBuilder.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                             objPrjTabENEx.TabName,
                                    objField.ObjFieldTabENEx.FldName);
                        strBuilder.Append("\r\n" + "{");
                        strBuilder.AppendFormat("\r\n" + "if (obj{0}Cond.{1} == true)",
                                    objPrjTabENEx.TabName,
                                    objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                        strBuilder.Append("\r\n" + "{");


                        strBuilder.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And p.{{0}} = '1'\", con{1}.{0});",
                                 objField.ObjFieldTabENEx.FldName,
                                 objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{0}Id));");


                        strBuilder.Append("\r\n" + "}");

                        strBuilder.AppendFormat("\r\n" + "else");
                        strBuilder.Append("\r\n" + "{");

                        strBuilder.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And p.{{0}} = '0'\", con{1}.{0});",
                             objField.ObjFieldTabENEx.FldName,
                                 objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{0}Id));");

                        strBuilder.Append("\r\n" + "}");
                        strBuilder.Append("\r\n" + "}");

                        break;

                    case enumDataTypeAbbr.char_04:
                    case enumDataTypeAbbr.varchar_25:
                    case enumDataTypeAbbr.nvarchar_15:
                        strBuilder.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                  objPrjTabENEx.TabName,
                         objField.ObjFieldTabENEx.FldName);
                        strBuilder.Append("\r\n" + "{");
                        strBuilder.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.FldName);

                        strBuilder.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And p.{{0}} {{1}} {{{{ {0} }}}}\", con{1}.{0}, strComparisonOp{0});",
                            objField.ObjFieldTabENEx.FldName,
                            objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{0}Id));");

                        strBuilder.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}Cond.{1});", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase));

                        strBuilder.Append("\r\n" + "}");
                        break;
                    case enumDataTypeAbbr.datetime_05:
                        strBuilder.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                  objPrjTabENEx.TabName,
                         objField.ObjFieldTabENEx.FldName);
                        strBuilder.Append("\r\n" + "{");
                        strBuilder.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.FldName);

                        strBuilder.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And p.{{0}} {{1}} {{{{ {0} }}}}\", con{1}.{0}, strComparisonOp{0});",
                            objField.ObjFieldTabENEx.FldName,
                            objPrjTabENEx.TabName,
                            "{", "}");
                        //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{1}));");

                        strBuilder.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}Cond.{1});", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase));

                        strBuilder.Append("\r\n" + "}");
                        break;
                    case enumDataTypeAbbr.decimal_06:
                    case enumDataTypeAbbr.float_07:
                    case enumDataTypeAbbr.int_09:
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:


                        strBuilder.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                  objPrjTabENEx.TabName,
                         objField.ObjFieldTabENEx.FldName);
                        strBuilder.Append("\r\n" + "{");
                        strBuilder.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.FldName);

                        strBuilder.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} {{1}} {{{{ {0} }}}}\", con{1}.{0}, strComparisonOp{0});",
                            objField.ObjFieldTabENEx.FldName,
                            objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{1}));");

                        strBuilder.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}Cond.{1});", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase));

                        strBuilder.Append("\r\n" + "}");
                        break;
                    default:
                        strBuilder.AppendFormat("\r\n" + "//��������{0}({1})�ں���:[{2}]��û�д���!",
                              objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                              clsStackTrace.GetCurrClassFunction());
                        break;
                }
            }

            //strBuilder.Append("\r\n" + " return strWhereCond;");


            //strBuilder.Append("\r\n" + "string strCondition = string.Join(\" and \", arrFldName_Cond);");
            //strBuilder.Append("\r\n" + "if (arrFldName_Cond.Count == 0) strCondition = \"1=1\";");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "long intCount = 0;");
            strBuilder.Append("\r\n" + "const query = clsSysParaEN_Neo4J.GraphClient.Cypher");
            strBuilder.AppendFormat("\r\n" + ".Match(\"(p:{0})\")", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + ".Where(strWhereCond)");
            strBuilder.Append("\r\n" + ".WithParams(dicParam)");
            strBuilder.Append("\r\n" + ".Return( p=> new { Count = p.Count() })");
            //strBuilder.Append("\r\n" + ".OrderBy(\"p.{0}Id\")");
            //strBuilder.Append("\r\n" + ".Skip(2)");
            //strBuilder.Append("\r\n" + ".Limit(5)");
            strBuilder.Append("\r\n" + ".Results;");
            //.ExecuteWithoutResults();
            strBuilder.Append("\r\n" + "const first = query.First();");
            strBuilder.Append("\r\n" + "return first.Count;");
                
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw objException;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");

            return strBuilder.ToString();
        }
        public virtual string Gen_Neo4JDA_GetRecCountByCond()
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
        public virtual string Gen_Neo4JDA_DelNode()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��һ����¼-----------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ���ؼ�����ָ���ļ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼��</returns>");
            strBuilder.Append("\r\n" + string.Format("public int DelNode({0}) ", objPrjTabENEx.KeyVarDefineLstStr));
            strBuilder.Append("\r\n{");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }

            strBuilder.Append("\r\n//ɾ��������¼");

            strBuilder.Append("\r\n" + "      var query = clsSysParaEN_Neo4J.GraphClient.Cypher");
            strBuilder.AppendFormat("\r\n" + ".Match(\"(p:{0})\")", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + ".Where(\"p.{0}={{ {0} }}\")", objKeyField.FldName);
            strBuilder.Append("\r\n" + ".Delete(\"p\")");
            strBuilder.AppendFormat("\r\n" + ".WithParam(\"{0}\", {1})", objKeyField.FldName , objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + ".ExecuteWithoutResultsAsync();");
            strBuilder.Append("\r\n" + "return 1;");
            strBuilder.Append("\r\n}");
            ///ɾ��һ����¼ == = ;
            return strBuilder.ToString();
        }


        public string GenDelRecordBySign()
        {
            if (objDelSignField == null) return "";
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��һ����¼-----------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:���ݱ�־ɾ���ؼ�����ָ���ļ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼��</returns>");
            strBuilder.Append("\r\n" + string.Format("public int DelRecordBySign({0}) ", objPrjTabENEx.KeyVarDefineLstStr));
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

            if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
            {
                strBuilder.AppendFormat("\r\n" + "strSQL = strSQL + string.Format(\"Update {0} Set {{0}}='1', {{1}} = '{{2}}' where {1} = {{3}}\",",
                 objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "con{0}.IsDeleted, con{0}.DeletedDate, clsDateTime.getTodayDateTimeStr(0), {1});",
                   objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "strSQL = strSQL + string.Format(\"Update {0} Set {{0}}='1', {{1}} = '{{2}}' where {1} = '{{3}}'\",",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "con{0}.IsDeleted, con{0}.DeletedDate, clsDateTime.getTodayDateTimeStr(0), {1});",
                   objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n return objSQL.ExecSql2(strSQL);");
            strBuilder.Append("\r\n}");
            ///ɾ��һ����¼ == = ;
            return strBuilder.ToString();
        }

        public string GenUnDelRecordBySign()
        {
            if (objDelSignField == null) return "";
            StringBuilder strBuilder = new StringBuilder();
            ///ɾ��һ����¼-----------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:�ָ���ɾ���ļ�¼,�����ɾ����־�ı�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>���ػָ�ɾ���ļ�¼��</returns>");
            strBuilder.Append("\r\n" + string.Format("public int UnDelRecordBySign({0}) ", objPrjTabENEx.KeyVarDefineLstStr));
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
            if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
            {
                strBuilder.AppendFormat("\r\n" + "strSQL = strSQL + string.Format(\"Update {0} Set {{0}}='0', {{1}} = '{{2}}' where {1} = {{3}}\",",
                 objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "con{0}.IsDeleted, con{0}.DeletedDate, clsDateTime.getTodayDateTimeStr(0), {1});",
                   objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "strSQL = strSQL + string.Format(\"Update {0} Set {{0}}='0', {{1}} = '{{2}}' where {1} = '{{3}}'\",",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "con{0}.IsDeleted, con{0}.DeletedDate, clsDateTime.getTodayDateTimeStr(0), {1});",
                   objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n return objSQL.ExecSql2(strSQL);");
            strBuilder.Append("\r\n}");
            ///ɾ��һ����¼ == = ;
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
                sbCodeForCs.AppendFormat("\r\n if (obj{1}EN.IsUpdated(con{1}.{0}))",
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
                     objField.ObjFieldTabENEx.FldName,
                     strPrivPropNameWithObjectName4Get);
                }
                sbCodeForCs.Append("\r\n }");

                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n if (obj{1}EN.IsUpdated(con{1}.{0}))",
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
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName,
                          strPrivPropNameWithObjectName);
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
                         objField.ObjFieldTabENEx.FldName,
                          strPrivPropNameWithObjectName);
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
                 objField.ObjFieldTabENEx.FldName,
                 strPrivPropNameWithObjectName);
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
                            objField.ObjFieldTabENEx.FldName,
                             strPrivPropNameWithObjectName4Get);
                        }
                        else
                        {
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{3} = '{{0}}'\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                              strPrivPropNameWithObjectName4Get);
                        }
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{3} = {{0}}\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName,
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
                             objField.ObjFieldTabENEx.FldName,
                              strPrivPropNameWithObjectName4Get);
                        }
                        else
                        {
                            sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = '{{0}}'\", {4}); //{2}",
                            "{", "}",
                            objField.ColCaption,
                             objField.ObjFieldTabENEx.FldName,
                             strPrivPropNameWithObjectName4Get);
                        }
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = {{0}}\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName,
                         strPrivPropNameWithObjectName4Get);
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
                         objField.ObjFieldTabENEx.FldName,
                          strPrivPropNameWithObjectName);
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}'\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName,
                          strPrivPropNameWithObjectName);
                    }
                }
                else
                {
                    sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = {{0}}\", {4}); //{2}",
                    "{", "}",
                    objField.ColCaption,
                     objField.ObjFieldTabENEx.FldName,
                      strPrivPropNameWithObjectName);
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
                         objField.ObjFieldTabENEx.FldName,
                          strPrivPropNameWithObjectName);
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3}= '{{0}}'\", {4}); //{2}",
                        "{", "}",
                        objField.ColCaption,
                         objField.ObjFieldTabENEx.FldName,
                          strPrivPropNameWithObjectName);
                    }
                }
                else
                {
                    sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\", {3} = {{0}}\", {4}); //{2}",
                    "{", "}",
                    objField.ColCaption,
                     objField.ObjFieldTabENEx.FldName,
                      strPrivPropNameWithObjectName);
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
                        sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
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
                        sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
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

                        sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
                        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                        strPrivPropNameWithObjectName);
                        break;
                    default:
                        sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
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
                    sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
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
                    sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
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

                    sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
                    objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                    sbCodeForCs.AppendFormat("\r\n arrValueListForInsert.Add({0}.ToString());",
                    strPrivPropNameWithObjectName);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n arrFieldListForInsert.Add(con{1}.{0});",
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
        private string GetCode4FieldInUpdateNode(clsPrjTabFldENEx objField)
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
                sbCodeForCs.AppendFormat("\r\n if (obj{1}EN.IsUpdated(con{1}.{0}))",
        objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
                sbCodeForCs.Append("\r\n {");

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                    {
                        case "bool":
                            //sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4} == true?\"1\":\"0\"); //{2}",
                            //"{", "}",
                            //objField.ColCaption,
                            // objField.ObjFieldTabENEx.FldName,
                            // strPrivPropNameWithObjectName4Get);
                            sbCodeForCs.AppendFormat("\r\n" + "arrFldName.Add(string.Format(\"p.{{0}}={{{{ {{0}} }}}}\", con{0}.{1}));", objPrjTabENEx.TabName, objField.FldName);
                            sbCodeForCs.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}EN.{1});", objPrjTabENEx.TabName, objField.FldName);

                            break;
                        case "byte":
                        case "byte[]":
                            //sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                            //"{", "}",
                            //objField.ColCaption,
                            // objField.ObjFieldTabENEx.FldName,
                            //  strPrivPropNameWithObjectName4Get);
                            sbCodeForCs.AppendFormat("\r\n" + "arrFldName.Add(string.Format(\"p.{{0}}={{{{ {{0}} }}}}\", con{0}.{1}));", objPrjTabENEx.TabName, objField.FldName);
                            sbCodeForCs.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}EN.{1});", objPrjTabENEx.TabName, objField.FldName);

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
                            //if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                            //{
                            //    sbCodeForCs.AppendFormat("\r\n {0} = {1}.Replace(\"'\", \"''\"); //ת��ֵ���еĵ�Ʋ\"'\",ʹ֮��Ϊ˫Ʋ\"''\"",
                            //    strPrivPropNameWithObjectName4Get,
                            //    strPrivPropNameWithObjectName4Get
                            //   );
                            //}
                            //sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = '{{0}}',\", {4}); //{2}",
                            //"{", "}",
                            //objField.ColCaption,
                            //objField.ObjFieldTabENEx.FldName,
                            // strPrivPropNameWithObjectName4Get);
                            //sbCodeForCs.Append("\r\n }");
                            //sbCodeForCs.Append("\r\n else");
                            //sbCodeForCs.Append("\r\n {");
                            //sbCodeForCs.AppendFormat("\r\n sbSQL.Append(\" " + objField.ObjFieldTabENEx.FldName + " = null,\"); //{2}",
                            //"{", "}",
                            //objField.ColCaption);
                            sbCodeForCs.AppendFormat("\r\n" + "arrFldName.Add(string.Format(\"p.{{0}}={{{{ {{0}} }}}}\", con{0}.{1}));", objPrjTabENEx.TabName, objField.FldName);
                            sbCodeForCs.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}EN.{1});", objPrjTabENEx.TabName, objField.FldName);

                            sbCodeForCs.Append("\r\n }");
                            break;
                    }
                }
                else
                {
                    //sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {3} = {{0}},\", {4}); //{2}",
                    //"{", "}",
                    //objField.ColCaption,
                    //objField.ObjFieldTabENEx.FldName,
                    // strPrivPropNameWithObjectName4Get);
                    sbCodeForCs.AppendFormat("\r\n" + "arrFldName.Add(string.Format(\"p.{{0}}={{{{ {{0}} }}}}\", con{0}.{1}));", objPrjTabENEx.TabName, objField.FldName);
                    sbCodeForCs.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}EN.{1});", objPrjTabENEx.TabName, objField.FldName);

                }
                sbCodeForCs.Append("\r\n }");
                return sbCodeForCs.ToString();
            }
            sbCodeForCs.AppendFormat("\r\n if (obj{1}EN.IsUpdated(con{1}.{0}))",
            objField.ObjFieldTabENEx.FldName, objPrjTabENEx.TabName);
            sbCodeForCs.Append("\r\n {");

            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "bool":
                        //sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\" {{1}} = '{{0}}',\", {3} == true?\"1\":\"0\", con{4}.{5}); //{2}",
                        //"{", "}",
                        //objField.ColCaption,
                        //strPrivPropNameWithObjectName,
                        // objPrjTabENEx.TabName,
                        //objField.ObjFieldTabENEx.FldName);
                        sbCodeForCs.AppendFormat("\r\n" + "arrFldName.Add(string.Format(\"p.{{0}}={{{{ {{0}} }}}}\", con{0}.{1}));", objPrjTabENEx.TabName, objField.FldName);
                        sbCodeForCs.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}EN.{1});", objPrjTabENEx.TabName, objField.FldName);

                        break;
                    case "byte":
                    case "byte[]":
                        //sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{1}} = '{{0}}',\", {3}, con{4}.{5}); //{2}",
                        //"{", "}",
                        //objField.ColCaption,
                        //strPrivPropNameWithObjectName,
                        // objPrjTabENEx.TabName,
                        //objField.ObjFieldTabENEx.FldName);
                        sbCodeForCs.AppendFormat("\r\n" + "arrFldName.Add(string.Format(\"p.{{0}}={{{{ {{0}} }}}}\", con{0}.{1}));", objPrjTabENEx.TabName, objField.FldName);
                        sbCodeForCs.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}EN.{1});", objPrjTabENEx.TabName, objField.FldName);

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
                        //if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase) == false)
                        //{
                        //    sbCodeForCs.AppendFormat("\r\n {0} = {0}.Replace(\"'\", \"''\"); //ת��ֵ���еĵ�Ʋ\"'\",ʹ֮��Ϊ˫Ʋ\"''\"",
                        //    strPrivPropNameWithObjectName);
                        //}
                        //sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{1}} = '{{0}}',\", {3}, con{4}.{5}); //{2}",
                        //"{", "}",
                        //objField.ColCaption,
                        //strPrivPropNameWithObjectName,
                        //objPrjTabENEx.TabName,
                        //objField.ObjFieldTabENEx.FldName);
                        sbCodeForCs.AppendFormat("\r\n" + "arrFldName.Add(string.Format(\"p.{{0}}={{{{ {{0}} }}}}\", con{0}.{1}));", objPrjTabENEx.TabName, objField.FldName);
                        sbCodeForCs.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}EN.{1});", objPrjTabENEx.TabName, objField.FldName);

                        sbCodeForCs.Append("\r\n }");
                        sbCodeForCs.Append("\r\n else");
                        sbCodeForCs.Append("\r\n {");
                        //sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{0}} = null,\",con{3}.{4}); //{2}",
                        //"{", "}",
                        //objField.ColCaption,
                        // objPrjTabENEx.TabName,
                        //objField.ObjFieldTabENEx.FldName);
                        sbCodeForCs.AppendFormat("\r\n" + "arrFldName.Add(string.Format(\"p.{{0}}={{{{ {{0}} }}}}\", con{0}.{1}));", objPrjTabENEx.TabName, objField.FldName);
                        sbCodeForCs.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}EN.{1});", objPrjTabENEx.TabName, objField.FldName);

                        sbCodeForCs.Append("\r\n }");
                        break;
                }
            }
            else
            {
                //sbCodeForCs.AppendFormat("\r\n sbSQL.AppendFormat(\"{{1}} = {{0}},\",{3}, con{4}.{5}); //{2}",
                //"{", "}",
                //objField.ColCaption,
                //strPrivPropNameWithObjectName,
                // objPrjTabENEx.TabName,
                //        objField.ObjFieldTabENEx.FldName);
                sbCodeForCs.AppendFormat("\r\n" + "arrFldName.Add(string.Format(\"p.{{0}}={{{{ {{0}} }}}}\", con{0}.{1}));", objPrjTabENEx.TabName, objField.FldName);
                sbCodeForCs.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}EN.{1});", objPrjTabENEx.TabName, objField.FldName);

            }
            sbCodeForCs.Append("\r\n }");
            return sbCodeForCs.ToString();
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
                         strPrivPropNameWithObjectName,
                          AccessNull(objField));
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

        public string Gen_Neo4JDA_GetObjByKeyId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
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
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            //            strBuilder.Append("\r\n" + "long intCount = 0;");
            strBuilder.Append("\r\n" + "const arrObjLst = clsSysParaEN_Neo4J.GraphClient.Cypher");
            strBuilder.AppendFormat("\r\n" + ".Match(\"(p:{0})\")", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + ".Where(\"p.{0} = {{ {0} }}\")", objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + ".WithParam(\"{0}\", {1})", objKeyField.FldName, objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n" + ".Return(p => p.As<cls{0}EN>())", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + ".Results;");

            strBuilder.Append("\r\n" + "if (arrObjLst.Count() > 0) return arrObjLst.First();");
            strBuilder.Append("\r\n" + "else return null;");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw objException;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //��ȡĳһ�ؼ�ֵ�ļ�¼ ==  == = ;
            return strBuilder.ToString();
        }
        public virtual string Gen_Neo4JDA_GetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}Cond\">���ڸ�����������������</param>",  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic IEnumerable<cls{0}EN> GetObjLst(cls{0}EN obj{0}Cond)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\nCheckProperty4Condition(obj{0}Cond);", objPrjTabENEx.TabName);
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

            //strBuilder.Append("\r\n" + "StringBuilder sbCondition = new StringBuilder();");
            //strBuilder.Append("\r\n" + "List<string> arrFldName_Cond = new List<string>();");
            strBuilder.Append("\r\n" + "IDictionary<string, object> dicParam = new Dictionary<string, object>();");
            //strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{0}Id) == false)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{0}Id));");
            //strBuilder.Append("\r\n" + "dicParam.Add(con{0}.{0}Id, obj{0}EN.{0}Id);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
            strBuilder.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");


            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeId) //objEditRegionFldsEx.objCtlType.CtlTypeName
                {
                    case enumDataTypeAbbr.bit_03:
                        strBuilder.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                             objPrjTabENEx.TabName,
                                    objField.ObjFieldTabENEx.FldName);
                        strBuilder.Append("\r\n" + "{");
                        strBuilder.AppendFormat("\r\n" + "if (obj{0}Cond.{1} == true)",
                                    objPrjTabENEx.TabName,
                                    objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                        strBuilder.Append("\r\n" + "{");


                        strBuilder.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And p.{{0}} = '1'\", con{1}.{0});",
                                 objField.ObjFieldTabENEx.FldName,
                                 objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{0}Id));");


                        strBuilder.Append("\r\n" + "}");

                        strBuilder.AppendFormat("\r\n" + "else");
                        strBuilder.Append("\r\n" + "{");

                        strBuilder.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And p.{{0}} = '0'\", con{1}.{0});",
                             objField.ObjFieldTabENEx.FldName,
                                 objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{0}Id));");

                        strBuilder.Append("\r\n" + "}");
                        strBuilder.Append("\r\n" + "}");

                        break;

                    case enumDataTypeAbbr.char_04:
                    case enumDataTypeAbbr.varchar_25:
                    case enumDataTypeAbbr.nvarchar_15:
                        strBuilder.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                  objPrjTabENEx.TabName,
                         objField.ObjFieldTabENEx.FldName);
                        strBuilder.Append("\r\n" + "{");
                        strBuilder.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.FldName);

                        strBuilder.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And p.{{0}} {{1}} {{{{ {0} }}}}\", con{1}.{0}, strComparisonOp{0});",
                            objField.ObjFieldTabENEx.FldName,
                            objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{0}Id));");

                        strBuilder.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}Cond.{1});", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase));

                        strBuilder.Append("\r\n" + "}");
                        break;
                    case enumDataTypeAbbr.datetime_05:
                        strBuilder.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                  objPrjTabENEx.TabName,
                         objField.ObjFieldTabENEx.FldName);
                        strBuilder.Append("\r\n" + "{");
                        strBuilder.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.FldName);

                        strBuilder.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And p.{{0}} {{1}} {{{{ {0} }}}}\", con{1}.{0}, strComparisonOp{0});",
                            objField.ObjFieldTabENEx.FldName,
                            objPrjTabENEx.TabName,
                            "{", "}");
                        //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{1}));");

                        strBuilder.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}Cond.{1});", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase));

                        strBuilder.Append("\r\n" + "}");
                        break;
                    case enumDataTypeAbbr.decimal_06:
                    case enumDataTypeAbbr.float_07:
                    case enumDataTypeAbbr.int_09:
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:


                        strBuilder.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                  objPrjTabENEx.TabName,
                         objField.ObjFieldTabENEx.FldName);
                        strBuilder.Append("\r\n" + "{");
                        strBuilder.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.FldName);

                        strBuilder.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} {{1}} {{{{ {0} }}}}\", con{1}.{0}, strComparisonOp{0});",
                            objField.ObjFieldTabENEx.FldName,
                            objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{1}));");

                        strBuilder.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}Cond.{1});", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase));

                        strBuilder.Append("\r\n" + "}");
                        break;
                    default:
                        strBuilder.AppendFormat("\r\n" + "//��������{0}({1})�ں���:[{2}]��û�д���!",
                              objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                              clsStackTrace.GetCurrClassFunction());
                        break;
                }
            }

            //strBuilder.Append("\r\n" + " return strWhereCond;");


            //strBuilder.Append("\r\n" + "string strCondition = string.Join(\" and \", arrFldName_Cond);");
            //strBuilder.Append("\r\n" + "if (arrFldName_Cond.Count == 0) strCondition = \"1=1\";");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const arrObjLst = clsSysParaEN_Neo4J.GraphClient.Cypher");
            strBuilder.AppendFormat("\r\n" + ".Match(\"(p:{0})\")", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + ".Where(strWhereCond)");
            strBuilder.Append("\r\n" + ".WithParams(dicParam)");
            strBuilder.AppendFormat("\r\n" + ".Return(p => p.As<cls{0}EN>())", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + ".OrderBy(\"p.{0}Id\")");
            //strBuilder.Append("\r\n" + ".Skip(2)");
            //strBuilder.Append("\r\n" + ".Limit(5)");
            strBuilder.Append("\r\n" + ".Results;");
            //.ExecuteWithoutResults();
            strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw objException;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public virtual string Gen_Neo4JDA_GetObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ҳ��ȡJSON�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objPagerPara\">��ҳ��ȡ��¼�Ĳ�������</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic IEnumerable<cls{0}EN> GetObjLstByPager(stuPagerPara objPagerPara)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}Cond = JsonConvert.DeserializeObject<cls{0}EN>(objPagerPara.whereCond);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}DA.SetUpdFlag(obj{0}Cond);", objPrjTabENEx.TabName);


            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\nCheckProperty4Condition(obj{0}Cond);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\ncatch (Exception objException)");
            strBuilder.Append("\r\n{");

            string strFunctionName = string.Format("GetObjLstByPager", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�����������к���{0},����!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strBuilder.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{2})�����������к���{{0}},����!({1}:GetObjLstByPager)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        strErrId);
            strBuilder.Append("\r\n}");

            //strBuilder.Append("\r\n" + "StringBuilder sbCondition = new StringBuilder();");
            //strBuilder.Append("\r\n" + "List<string> arrFldName_Cond = new List<string>();");
            strBuilder.Append("\r\n" + "IDictionary<string, object> dicParam = new Dictionary<string, object>();");
            //strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.{0}Id) == false)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{0}Id));");
            //strBuilder.Append("\r\n" + "dicParam.Add(con{0}.{0}Id, obj{0}EN.{0}Id);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
            strBuilder.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");


            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeId) //objEditRegionFldsEx.objCtlType.CtlTypeName
                {
                    case enumDataTypeAbbr.bit_03:
                        strBuilder.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                             objPrjTabENEx.TabName,
                                    objField.ObjFieldTabENEx.FldName);
                        strBuilder.Append("\r\n" + "{");
                        strBuilder.AppendFormat("\r\n" + "if (obj{0}Cond.{1} == true)",
                                    objPrjTabENEx.TabName,
                                    objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                        strBuilder.Append("\r\n" + "{");


                        strBuilder.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And p.{{0}} = '1'\", con{1}.{0});",
                                 objField.ObjFieldTabENEx.FldName,
                                 objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{0}Id));");

                        
                        strBuilder.Append("\r\n" + "}");

                        strBuilder.AppendFormat("\r\n" + "else");
                        strBuilder.Append("\r\n" + "{");

                        strBuilder.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And p.{{0}} = '0'\", con{1}.{0});",
                             objField.ObjFieldTabENEx.FldName,
                                 objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{0}Id));");
                        
                        strBuilder.Append("\r\n" + "}");
                        strBuilder.Append("\r\n" + "}");

                        break;

                    case enumDataTypeAbbr.char_04:
                    case enumDataTypeAbbr.varchar_25:
                    case enumDataTypeAbbr.nvarchar_15:
                        strBuilder.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                  objPrjTabENEx.TabName,
                         objField.ObjFieldTabENEx.FldName);
                        strBuilder.Append("\r\n" + "{");
                        strBuilder.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.FldName);

                        strBuilder.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And p.{{0}} {{1}} {{{{ {0} }}}}\", con{1}.{0}, strComparisonOp{0});",
                            objField.ObjFieldTabENEx.FldName,
                            objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{0}Id));");

                        strBuilder.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}Cond.{1});", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase));

                        strBuilder.Append("\r\n" + "}");
                        break;
                    case enumDataTypeAbbr.datetime_05:
                        strBuilder.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                  objPrjTabENEx.TabName,
                         objField.ObjFieldTabENEx.FldName);
                        strBuilder.Append("\r\n" + "{");
                        strBuilder.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.FldName);

                        strBuilder.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And p.{{0}} {{1}} {{{{ {0} }}}}\", con{1}.{0}, strComparisonOp{0});",
                            objField.ObjFieldTabENEx.FldName,
                            objPrjTabENEx.TabName,
                            "{", "}");
                        //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{1}));");

                        strBuilder.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}Cond.{1});", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase));

                        strBuilder.Append("\r\n" + "}");
                        break;
                    case enumDataTypeAbbr.decimal_06:
                    case enumDataTypeAbbr.float_07:
                    case enumDataTypeAbbr.int_09:
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:


                        strBuilder.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                  objPrjTabENEx.TabName,
                         objField.ObjFieldTabENEx.FldName);
                        strBuilder.Append("\r\n" + "{");
                        strBuilder.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.FldName);

                        strBuilder.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} {{1}} {{{{ {0} }}}}\", con{1}.{0}, strComparisonOp{0});",
                            objField.ObjFieldTabENEx.FldName,
                            objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n" + "arrFldName_Cond.Add(string.Format(\"p.{0}={{ {0} }} \", con{0}.{1}));");

                        strBuilder.AppendFormat("\r\n" + "dicParam.Add(con{0}.{1}, obj{0}Cond.{1});", objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase));

                        strBuilder.Append("\r\n" + "}");
                        break;
                    default:
                        strBuilder.AppendFormat("\r\n" + "//��������{0}({1})�ں���:[{2}]��û�д���!",
                              objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                              clsStackTrace.GetCurrClassFunction());
                        break;
                }
            }

            //strBuilder.Append("\r\n" + " return strWhereCond;");


            //strBuilder.Append("\r\n" + "string strCondition = string.Join(\" and \", arrFldName_Cond);");
            //strBuilder.Append("\r\n" + "if (arrFldName_Cond.Count == 0) strCondition = \"1=1\";");
            strBuilder.Append("\r\n" + "int intSkip = objPagerPara.pageSize * (objPagerPara.pageIndex - 2);");
            strBuilder.Append("\r\n" + "if (intSkip <= 0) intSkip = 0;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const arrObjLst = clsSysParaEN_Neo4J.GraphClient.Cypher");
            strBuilder.AppendFormat("\r\n" + ".Match(\"(p:{0})\")", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + ".Where(strWhereCond)");
            strBuilder.Append("\r\n" + ".WithParams(dicParam)");
            strBuilder.AppendFormat("\r\n" + ".Return(p => p.As<cls{0}EN>())", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + ".OrderBy(\"p.{0}Id\")");
            strBuilder.Append("\r\n" + ".Skip(intSkip)");
            strBuilder.Append("\r\n" + ".Limit(objPagerPara.pageSize)");
            strBuilder.Append("\r\n" + ".Results;");
            //.ExecuteWithoutResults();
            strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw objException;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }
        public virtual string Gen_Neo4JDA_GetMaxStrID()
        {
            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.CsType == "string")
            {

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ��ȡ��ǰ������ַ��͹ؼ���ID");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <returns>���ص����ؼ���ֵID</returns>");
                strBuilder.Append("\r\npublic static string GetMaxStrId()");
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\n" + "try");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "const query = clsSysParaEN_Neo4J.GraphClient.Cypher");
                strBuilder.AppendFormat("\r\n" + ".Match(\"(p:{0})\")", objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + ".Return(p => Return.As<string>(\"max(p.{0})\"))", objKeyField.FldName);
                strBuilder.Append("\r\n" + ".Results;");
                strBuilder.AppendFormat("\r\n" + "int intFldLen = {0};", objKeyField.ObjFieldTabENEx.FldLength);
                strBuilder.Append("\r\n" + "if (query.Count() == 0)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "return clsString.combineStrS(\"0\", intFldLen - 1) + \"1\";");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "const strMaxValue = query.First();");
                strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strMaxValue) == true)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "return clsString.combineStrS(\"0\", intFldLen - 1) + \"1\";");
                strBuilder.Append("\r\n" + "}");

                strBuilder.Append("\r\n" + "int intNextMaxValue, intLen;");
                strBuilder.Append("\r\n" + "string strNextMaxValue;");

                strBuilder.Append("\r\n" + "intNextMaxValue = int.Parse(strMaxValue) + 1;");
                strBuilder.Append("\r\n" + "strNextMaxValue = intNextMaxValue.ToString();");
                strBuilder.Append("\r\n" + "intLen = strNextMaxValue.Length;");
                strBuilder.Append("\r\n" + "strNextMaxValue = clsString.combineStrS(\"0\", intFldLen - intLen) + strNextMaxValue;");
                strBuilder.Append("\r\n" + "return strNextMaxValue;");

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "catch (Exception objException)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "throw objException;");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n}");
            }
            else
            {

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ��ȡ��ǰ�����ؼ���ID");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <returns>���ص����ؼ���ֵID</returns>");
                strBuilder.AppendFormat("\r\npublic static {0} GetMaxId()", objKeyField.CsType);
                strBuilder.Append("\r\n{");
                strBuilder.Append("\r\n" + "try");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "const query = clsSysParaEN_Neo4J.GraphClient.Cypher");
                strBuilder.AppendFormat("\r\n" + ".Match(\"(p:{0})\")", objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + ".Return(p => Return.As<string>(\"max(p.{0})\"))", objKeyField.FldName, objKeyField.CsType);
                strBuilder.Append("\r\n" + ".Results;");
                strBuilder.Append("\r\n" + "if (query.Count() == 0) return 1;");
                strBuilder.Append("\r\n" + "const varMaxValue = query.First();");
                
                strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(varMaxValue)) return 1;");
                strBuilder.AppendFormat("\r\n" + "return {0}.Parse(varMaxValue) + 1;", objKeyField.CsType);

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "catch (Exception objException)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "throw objException;");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n}");
            }
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

        public string Gen_Neo4JDA_GetMaxStrIdByPrefix()
        {
            if (objKeyField.CsType != "string") return "";
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����ǰ׺��ȡ��ǰ������ַ��͹ؼ���ID");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>���ص����ؼ���ֵID</returns>");
            strBuilder.Append("\r\npublic string GetMaxStrIdByPrefix(string strPrefix)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const query = clsSysParaEN_Neo4J.GraphClient.Cypher");
            strBuilder.AppendFormat("\r\n" + ".Match(\"(p:{0})\")", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + ".Return(p => Return.As<string>(\"max(p.{0})\"))", objKeyField.FldName);
            strBuilder.Append("\r\n" + ".Results;");
            strBuilder.AppendFormat("\r\n" + "int intFldLen = {0};", objKeyField.ObjFieldTabENEx.FldLength);
            strBuilder.Append("\r\n" + "int intPrefixLen = strPrefix.Length;");
            strBuilder.Append("\r\n" + "if (query.Count() == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "return strPrefix + clsString.combineStrS(\"0\", intFldLen - 1 - intPrefixLen) + \"1\";");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "const strMaxValue = query.First();");
            strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strMaxValue) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "return strPrefix + clsString.combineStrS(\"0\", intFldLen - 1 - intPrefixLen) + \"1\";");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "int intNextMaxValue, intLen;");
            strBuilder.Append("\r\n" + "string strNextMaxValue, strTemp;");

            strBuilder.Append("\r\n" + "strTemp = strMaxValue.Substring(intPrefixLen);");
            strBuilder.Append("\r\n" + "intNextMaxValue = int.Parse(strTemp) + 1;");
            strBuilder.Append("\r\n" + "strNextMaxValue = intNextMaxValue.ToString();");
            strBuilder.Append("\r\n" + "intLen = strNextMaxValue.Length;");
            strBuilder.Append("\r\n" + "strNextMaxValue = strPrefix + clsString.combineStrS(\"0\", intFldLen - intLen - intPrefixLen) + strNextMaxValue;");

            strBuilder.Append("\r\n" + "return strNextMaxValue;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw objException;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }
        /// <summary>
        /// ����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��
        /// </summary>
        /// <param name = "strWordTypeId">�ؼ���</param>
        /// <returns>�Ƿ���ɹ�</returns>
        public string Gen_Neo4JDA_CheckPrimaryKey()
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
        public string Gen_Neo4JDA_CheckPropertyNew()
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
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, con{2}.{3});",
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
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, con{2}.{3});",
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
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                 strPrivPropNameWithObjectName,
                 objField.ObjFieldTabENEx.FldLength,
                 objPrjTabENEx.TabName,
                 objField.ObjFieldTabENEx.FldName);
                        //strBuilder.AppendFormat("\r\nif (!Object.Equals(null, {0}) && GetStrLen({0}) > {1})", strPrivPropNameWithObjectName4Get, objField.ObjFieldTabENEx.FldLength);
                        //strBuilder.Append("\r\n{");
                        //strBuilder.AppendFormat("\r\n throw new clsDbObjException(string.Format(\"(errid:{7})�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:{{0}}(cls{3}DA:CheckPropertyNew)\", obj{3}EN.{4}));",
                        //objField.ColCaption,
                        //objField.ObjFieldTabENEx.FldLength.ToString().Trim(),
                        //objPrjTabENEx.TabCnName,
                        //objPrjTabENEx.TabName,
                        //objField.ObjFieldTabENEx.FldName,
                        //"{", "}",
                        //strErrId);
                        // strBuilder.Append("\r\n}");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                             strPrivPropNameWithObjectName,
                            objField.ObjFieldTabENEx.FldLength,
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName);

                    }
                }
            }

            //�������ֶγ���;

            strFunctionName = string.Format("CheckPropertyNew1", objPrjTabENEx.TabName, objKeyField.FldName);
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
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
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
            //        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckSqlInjection4Field({0}, con{1}.{2});",
            //          strPrivPropNameWithObjectName,
            //          objPrjTabENEx.TabName,
            //          objField.ObjFieldTabENEx.FldName);
            //    }
            //}
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
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                         strPrivPropNameWithObjectName,
                        objField.ObjFieldTabENEx.FldLength,
                      objPrjTabENEx.TabName,
                      objField.ObjFieldTabENEx.FldName);


                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
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
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
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
            //        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckSqlInjection4Field({0}, con{1}.{2});",
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
        public virtual string Gen_Neo4JDA_IsExist()
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
                    strBuilder.AppendFormat("\r\n" + "CheckPrimaryKey_Sim({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
                }
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
//            strBuilder.Append("\r\n" + "long intCount = 0;");
            strBuilder.Append("\r\n" + "const query = clsSysParaEN_Neo4J.GraphClient.Cypher");
            strBuilder.AppendFormat("\r\n" + ".Match(\"(p:{0})\")", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + ".Where(\"p.{0} = {{ {0} }}\")", objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + ".WithParam(\"{0}\", {1})", objKeyField.FldName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + ".Return(p => new { Count = p.Count() })");
            strBuilder.Append("\r\n" + ".Results;");
            strBuilder.Append("\r\n" + "const first = query.First();");
            strBuilder.Append("\r\n" + "return first.Count > 0 ? true : false;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw objException;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            ///�����ݿ����Ƿ���ڵ�ǰ����(������̺���) ==  == ;
            return strBuilder.ToString();
        }
        public virtual string Gen_Neo4JDA_GetDataTable()
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
        /// <summary>
        /// ����ؼ����Ƿ�Ϸ�,�Ƿ���SQLע��
        /// </summary>
        /// <param name = "strWordTypeId">�ؼ���</param>
        /// <returns>�Ƿ���ɹ�</returns>
        public string Gen_Neo4JDA_CheckPrimaryKey_Sim()
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
        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public virtual string Gen_Neo4JDA_GetFirstID()
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

        public virtual string Gen_Neo4JDA_IsExistCondRec()
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
        public virtual string Gen_Neo4JDA_DelRecordWithTransaction()
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
        public string Gen_Neo4JDA_CopyTo()
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
        public virtual string Gen_Neo4JDA_GetCondRecSetByPager()
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
        public string Gen_Neo4JDA_CheckProperty4Condition()
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

                    strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
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
                    strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckSqlInjection4Field({0}, con{1}.{2});",
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
                    strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
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
        public string Gen_Neo4JDA_SetUpdFlag_S()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �����޸ı�־,�������ֶ��޸ı�־�ַ�����ȡ��һ���ֶ��Ѿ����޸�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">Դ�򻯶���</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void SetUpdFlag(cls{0}EN obj{0}EN)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n   string strsfUpdFldSetStr = obj{0}EN.sfUpdFldSetStr;",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');");
            strBuilder.Append("\r\n   List<string> arrFldSet = new List<string>(sstrFldSet);");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(obj{0}EN.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = obj{0}EN.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "if (arrFldSet.Contains(con{0}.{1}, new clsStrCompareIgnoreCase())  ==  true)",
                         objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = obj{0}EN.{1}; //{3}",
                               objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                    strBuilder.Append("\r\n" + "}");

                }
            }

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                  objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "SetUpdFlag", "���ñ���޸ı�־����!��:{0}.", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})���ñ���޸ı�־����,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy��:{0} ��������(����޸�)����!({1}:CopyObjFromSimObj4Upd)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyObjFromSimObj4Upd)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

    }
}
