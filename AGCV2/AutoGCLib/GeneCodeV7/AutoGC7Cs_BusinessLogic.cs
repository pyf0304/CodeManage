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
    public class AutoGC7Cs_Business : AutoGCPubFuncV7
    {
        //����
        //private string mstrClsName;



        /// <summary>
        /// ���ļ���
        /// </summary>
        public string ClsFName
        {
            get { return mstrClsFName; }
            set { mstrClsFName = value; }
        }

        #region ���캯��

        public AutoGC7Cs_Business()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public AutoGC7Cs_Business(string strViewId, string strPrjDataBaseId)
            : base(strViewId, strPrjDataBaseId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        #endregion



        ///// <summary>
        ///// ����ͨ���߼������
        ///// </summary>
        ///// <returns></returns>
        //public string A_GenWebServiceCode()
        //{
        //    string strResult;
        //    if (objPrjTabENEx.TabFldNum  ==  0)
        //    {
        //        strResult = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
        //        throw new clsDbObjException(strResult);
        //    }
        //    if (objPrjTabENEx.KeyFldNum  ==  0)
        //    {
        //        strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!({1})",
        //        objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new clsDbObjException(strResult);
        //    }

        //    ///���û���������;
        //    string strFolder;
        //    string strClassFName;
        //    StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
        //    string strTemp;  ///��ʱ����;

        //    ArrayList arrFuncList = new ArrayList();

        //    arrFuncList.Add("GetDataSet");
        //    arrFuncList.Add("GetDataSetV");
        //    arrFuncList.Add("GetRecordProperty");
        //    arrFuncList.Add("GetRecordPropertyV");
        //    arrFuncList.Add("IsExistRecordByCond");
        //    arrFuncList.Add("IsExist");
        //    arrFuncList.Add("AddNewRecordBySql2");
        //    arrFuncList.Add("UpdateBySql2");
        //    arrFuncList.Add("DelRecord");
        //    arrFuncList.Add("DelMultiRecord");
        //    arrFuncList.Add("ExposeLogicClass");
        //    arrFuncList.Add("ExposeLogicExClass");

        //    ClsName = string.Format("{0}Service", objPrjTabENEx.TabName);
        //    strClassFName = mstrFolderName + ClsName + ".cs";
        //    mstrFileName = strClassFName;
        //    clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //

            
        //    try
        //    {
        //        ///������ʼ
        //        ///
        //        strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

        //        strCodeForCs.Append("\r\n" + "using System;"); //
        //        strCodeForCs.Append("\r\n" + "using System.Data; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Text; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Collections; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Web.Services;");
        //        strCodeForCs.Append("\r\n" + "using System.Web.Services.Protocols;");
        //        strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
        //        strCodeForCs.AppendFormat("\r\n" + "using {0};",
        //            objProject.PrjDomain);
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.commdb;"); //
        //        strCodeForCs.Append("\r\n" + ""); //
        //        strCodeForCs.AppendFormat("\r\n" + "namespace {0}.BusinessLogic",
        //            objProject.PrjDomain);
        //        strCodeForCs.Append("\r\n" + "{");
        //        strCodeForCs.Append("\r\n /// <summary>");
        //        strCodeForCs.AppendFormat("\r\n /// {0}Service ��ժҪ˵��",
        //            objPrjTabENEx.TabName);
        //        strCodeForCs.Append("\r\n /// </summary>");
        //        strCodeForCs.Append("\r\n" + "[WebService(Namespace = \"http://tempuri.org/\")]");
        //        strCodeForCs.Append("\r\n" + "[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]");
        //        strCodeForCs.Append("\r\n" + "[ToolboxItem(false)]");
        //        strCodeForCs.AppendFormat("\r\n" + "public class {0}Service : System.Web.Services.WebService",
        //            objPrjTabENEx.TabName);
        //        strCodeForCs.Append("\r\n" + "{ ");

        //        //�������еĺ���
        //        foreach (string strFuncName in arrFuncList)
        //        {
        //            strTemp = A_GeneFuncCode(strFuncName);
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //        strCodeForCs.Append("\r\n" + "}");
        //        strCodeForCs.Append("\r\n" + "}");

        //        //������д���ļ���;
        //        clsPubFun4BLEx.SaveClassContentToFile(strClassFName, strCodeForCs.ToString(), mstrFolderName_Root, mstrBackupFolderName, myEncoding);

        //        ////�����ļ������ļ�����,���ж��Ƿ����;
        //        //strFolder = clsString.ParentDir_S(strClassFName);
        //        //if (System.IO.Directory.Exists(strFolder)  ==  false)
        //        //{
        //        //    Directory.CreateDirectory(strFolder);
        //        //}

        //        //if (clsSysParaEN.IsBackupForGeneCode  ==  true)
        //        //{
        //        //    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
        //        //    string strFindFileFullFile = clsFile.FindFileFromFolder(mstrFolderName_Root, strSimpleFileName);
        //        //    while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
        //        //    {
        //        //        clsFile.FileBackup(strFindFileFullFile, mstrBackupFolderName);
        //        //        File.Delete(strFindFileFullFile);
        //        //        strFindFileFullFile = clsFile.FindFileFromFolder(mstrFolderName_Root, strSimpleFileName);

        //        //    }
        //        //}
        //        //clsFile.1CreateFileByString(strClassFName, strCodeForCs.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        LogError(ex);
        //        throw new Exception(ex.Message, ex);
        //    }
        //    return strCodeForCs.ToString();
        //}

//        /// <summary>
//        /// ����Web Serviceת�������
//        /// </summary>
//        /// <returns></returns>
//        public string A_GenBusinessLogicCode()
//        {
//            string strResult = "";
//            if (objPrjTabENEx.TabFldNum  ==  0)
//            {
//                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
//                 objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
//                return strResult;
//            }
//            if (objPrjTabENEx.KeyFldNum  ==  0)
//            {
//                strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!({1})",
//                    objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
//                return strResult;
//            }
//            objPrjTabENEx.CurrDate = clsDateTime_Db.GetDataBaseDate8();
//            objPrjTabENEx.CurrDate = clsDateTime.ChangeDateToDate10(objPrjTabENEx.CurrDate);
//            ///���û���������;
//            string strFolder;
//            string strClassFName;
//            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
//            string strTemp;  ///��ʱ����;

//            ArrayList arrFuncList = new ArrayList();

//            if (objPrjTabENEx.IsForSilverLight  ==  true)
//            {
//                arrFuncList.Add("Gen_4BL_ClassConstructor1");	//��Ĺ�����1
//                //arrFuncList.Add("Gen_4BL_SerializeObjListToXMLStr");
//                //arrFuncList.Add("Gen_4BL_SerializeObjListToXMLFile");

//                arrFuncList.Add("Gen_4BL_GetRecObjByKeyFromList");
//                arrFuncList.Add("Gen_4BL_SerializeObjListToXML");
//                arrFuncList.Add("Gen_4BL_SerializeXML");
//                arrFuncList.Add("Gen_4BL_GetObjListFromXmlStr");
//                arrFuncList.Add("Gen_4BL_GetObjListFromXmlFile");
//                arrFuncList.Add("Gen_4BL_GetRecObjByXmlReader");
//                arrFuncList.Add("Gen_4BL_GetRecObjByXmlStr");
//                arrFuncList.Add("Gen_4BL_SerializeObjToXMLStrIso");
                
//            }
//            else
//            {
//                arrFuncList.Add("Gen_4BL_ClassConstructor1");	//��Ĺ�����1
//                arrFuncList.Add("Gen_4BL_ComboBoxBindFunction");		//������󶨺���
//                arrFuncList.Add("Gen_4BL_DdlBindFunction");		//DropDownList�󶨺���
//                //arrFuncList.Add("GenBindListView");		//��������
//                arrFuncList.Add("Gen_4BL_CopyObj_S");
//                arrFuncList.Add("Gen_4BL_GetDataTable4Tab");
//                arrFuncList.Add("Gen_4BL_GetDataTable4TabV");
//                arrFuncList.Add("Gen_4BL_GetDataSetByCond_S");
//                arrFuncList.Add("Gen_4BL_GetDataSetByCond_V_S");

//                //arrFuncList.Add("Gen_4BL_GetDataTable4TabV2");
//                arrFuncList.Add("Gen_4BL_GetRecordProperty4Object");
//                arrFuncList.Add("Gen_4BL_GetFirstID_S");
//                arrFuncList.Add("Gen_4BL_GetPrimaryKeyID_S");
//                arrFuncList.Add("Gen_4BL_GetFirstObject_S");
//                arrFuncList.Add("Gen_4BL_GetMaxStrID_S");
//                arrFuncList.Add("Gen_4BL_CondRecObjList");
//                arrFuncList.Add("Gen_4BL_CondRecObjList2");
//                arrFuncList.Add("Gen_4BL_DelRecord");
//                arrFuncList.Add("Gen_4BL_DelRecordBySP_S");
//                arrFuncList.Add("Gen_4BL_DelMultiRecord");
//                arrFuncList.Add("Gen_4BL_DelMultiRecordByCond");
//                arrFuncList.Add("Gen_4BL_AddNewRecordBySql2");
//                arrFuncList.Add("Gen_4BL_AddNewRecordBySql_XML");
//                arrFuncList.Add("Gen_4BL_UpdateBySql2");
//                arrFuncList.Add("Gen_4BL_UpdateBySql_XML");
                
//                arrFuncList.Add("Gen_4BL_IsExistRecord");
//                arrFuncList.Add("Gen_4BL_IsExist");
//                arrFuncList.Add("Gen_4BL_CheckUniqueness");
//                arrFuncList.Add("Gen_4BL_CheckPropertyNew");
//                arrFuncList.Add("Gen_4BL_GetRecObjByKey");
//                arrFuncList.Add("Gen_4BL_GetRecNameByKey");
//                arrFuncList.Add("Gen_4BL_GetRecObjByKeyFromList");

//                arrFuncList.Add("Gen_4BL_SerializeObjListToXMLStr");
//                arrFuncList.Add("Gen_4BL_SerializeObjListToXMLFile");
//                arrFuncList.Add("Gen_4BL_SerializeObjListToXML");
//                arrFuncList.Add("Gen_4BL_SerializeXML");
//                arrFuncList.Add("Gen_4BL_GetObjListFromXmlStr");
//                arrFuncList.Add("Gen_4BL_GetObjListFromXmlFile");
//                arrFuncList.Add("Gen_4BL_GetRecObjByXmlReader");
//                arrFuncList.Add("Gen_4BL_GetRecObjByXmlStr");
//                arrFuncList.Add("Gen_4BL_SerializeObjToXMLStr");
                
//            }
//            ClsName = "cls" + objPrjTabENEx.TabName + "BL";
//            strClassFName = mstrFolderName + ClsName + ".cs";
//            mstrFileName = strClassFName;
//            clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //

            
//            try
//            {
//                ///������ʼ
//                ///
//                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

//                ///������ʼ
//                strCodeForCs.Append("\r\n" + "using System;"); //
//                //strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
//                strCodeForCs.Append("\r\n" + "using System.Text; "); //
//                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
//                strCodeForCs.Append("\r\n" + "using System.Collections.Generic; "); //
//                strCodeForCs.Append("\r\n" + "using System.Globalization;");
//                strCodeForCs.Append("\r\n" + "using System.IO;");
//                if (objPrjTabENEx.IsForSilverLight  ==  true)
//                {
//                    strCodeForCs.Append("\r\n" + "using System.IO.IsolatedStorage;");
//                }
//                strCodeForCs.Append("\r\n" + "using System.Xml;");
//                strCodeForCs.Append("\r\n" + "using com.taishsoft.file;");
//                //strCodeForCs.Append("\r\n" + "using com.taishsoft.commdb;"); //
//                if (objPrjTabENEx.IsForSilverLight  ==  false)
//                {
//                    strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
//                    strCodeForCs.Append("\r\n" + "using System.Data; "); //
//                    strCodeForCs.AppendFormat("\r\n" + "using {0}.DAL;", objProject.PrjDomain);
//                }

//                strCodeForCs.Append("\r\n" + ""); //
//                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.BusinessLogic",
//                    objProject.PrjDomain);
//                strCodeForCs.Append("\r\n" + "{");

//                strCodeForCs.Append("\r\n /// <summary>");
//                strCodeForCs.AppendFormat("\r\n /// {0}({1})", 
//                    objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
////                clsSQLDSTypeEN objSQLDSType = clsSQLDSTypeBL.GetSQLDSTypeObjBySQLDSTypeId(objPrjTabENEx.SQLDSTypeId);
//                clsSQLDSTypeEN objSQLDSType = clsSQLDSTypeBL.GetSQLDSTypeObjBySQLDSTypeId_Cache(objPrjTabENEx.SQLDSTypeId);

//                strCodeForCs.AppendFormat("\r\n /// ����Դ����:{0}",
//                        objSQLDSType.SqlDsTypeName);

//                strCodeForCs.Append("\r\n /// </summary>");

//                strCodeForCs.Append("\r\n" + "public class " + ClsName);
//                strCodeForCs.Append("\r\n" + "{");

//                strCodeForCs.Append("\r\n /// <summary>");
//                strCodeForCs.Append("\r\n /// �����XML����ǩ");
//                strCodeForCs.Append("\r\n /// </summary>");
//                strCodeForCs.AppendFormat("\r\n" + "public const string itemXmlNode = \"{0}ListItem\";",
//                    objPrjTabENEx.TabName);
//                strCodeForCs.Append("\r\n /// <summary>");
//                strCodeForCs.Append("\r\n /// �б��XML����ǩ");
//                strCodeForCs.Append("\r\n /// </summary>");
//                strCodeForCs.AppendFormat("\r\n" + "public const string listXmlNode = \"{0}List\";",
//                    objPrjTabENEx.TabName);
//                strCodeForCs.Append("\r\n /// <summary>");
//                strCodeForCs.Append("\r\n /// ���ϵ�XML����ǩ");
//                strCodeForCs.Append("\r\n /// </summary>");
//                strCodeForCs.Append("\r\n" + "public const string itemsXmlNode = \"Items\";");

//                //˽��������-----�����Թ���
//                strCodeForCs.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLst = null;",
//                    objPrjTabENEx.TabName);

//                //�������еĺ���

//                foreach (string strFuncName in arrFuncList)
//                {
//                    strTemp = A_GeneFuncCode(strFuncName);
//                    strCodeForCs.Append("\r\n" + strTemp);
//                }

//                strCodeForCs.Append("\r\n" + "}");
//                strCodeForCs.Append("\r\n" + "}");
//                clsPubFun4BLEx.SaveClassContentToFile(strClassFName, strCodeForCs.ToString(), mstrFolderName_Root, mstrBackupFolderName, myEncoding);
//                //������д���ļ���;
//                //�����ļ������ļ�����,���ж��Ƿ����;
//                //strFolder = clsString.ParentDir_S(strClassFName);
//                //if (System.IO.Directory.Exists(strFolder)  ==  false)
//                //{
//                //    Directory.CreateDirectory(strFolder);
//                //}

//                //if (clsSysParaEN.IsBackupForGeneCode  ==  true)
//                //{
//                //    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
//                //    string strFindFileFullFile = clsFile.FindFileFromFolder(mstrFolderName_Root, strSimpleFileName);
//                //    while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
//                //    {
//                //        clsFile.FileBackup(strFindFileFullFile, mstrBackupFolderName);
//                //        File.Delete(strFindFileFullFile);
//                //        strFindFileFullFile = clsFile.FindFileFromFolder(mstrFolderName_Root, strSimpleFileName);

//                //    }
//                //}
//                //clsFile.1CreateFileByString(strClassFName, strCodeForCs.ToString());
//            }
//            catch (Exception ex)
//            {
//                LogError(ex);
//                throw new Exception(ex.Message, ex);
//            }
//            return strCodeForCs.ToString();
//        }

        ///// <summary>
        ///// ����Web Serviceת�������
        ///// </summary>
        ///// <returns></returns>
        //public string A_GenBusinessLogicCode4View()
        //{
        //    string strResult = "";
        //    if (objPrjTabENEx.TabFldNum  ==  0)
        //    {
        //        strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
        //        objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new clsDbObjException(strResult);
        //    }
        //    if (objPrjTabENEx.KeyFldNum  ==  0)
        //    {
        //        strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!({1})",
        //           objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new clsDbObjException(strResult);
        //    }
        //    objPrjTabENEx.CurrDate = clsDateTime_Db.GetDataBaseDate8();
        //    objPrjTabENEx.CurrDate = clsDateTime.ChangeDateToDate10(objPrjTabENEx.CurrDate);
        //    ///���û���������;
        //    string strFolder;
        //    string strClassFName;
        //    StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
        //    string strTemp;  ///��ʱ����;

        //    ArrayList arrFuncList = new ArrayList();
        //    if (objPrjTabENEx.IsForSilverLight  ==  true)
        //    {
        //        arrFuncList.Add("Gen_4BL_ClassConstructor1");	//��Ĺ�����1
        //        //arrFuncList.Add("Gen_4BL_SerializeObjListToXMLStr");
        //        //arrFuncList.Add("Gen_4BL_SerializeObjListToXMLFile");
        //        arrFuncList.Add("Gen_4BL_GetRecObjByKeyFromList");

        //        arrFuncList.Add("Gen_4BL_SerializeObjListToXML");
        //        arrFuncList.Add("Gen_4BL_SerializeXML");
        //        arrFuncList.Add("Gen_4BL_GetObjListFromXmlStr");
        //        arrFuncList.Add("Gen_4BL_GetObjListFromXmlFile");
        //        arrFuncList.Add("Gen_4BL_GetRecObjByXmlReader");
        //        arrFuncList.Add("Gen_4BL_GetRecObjByXmlStr");
        //        //arrFuncList.Add("Gen_4BL_SerializeObjToXMLStr");
        //        arrFuncList.Add("Gen_4BL_SerializeObjToXMLStrIso");

        //    }
        //    else
        //    {
        //        arrFuncList.Add("Gen_4BL_ClassConstructor1");	//��Ĺ�����1
        //        arrFuncList.Add("GenComboBoxBindFunction");		//������󶨺���
        //        arrFuncList.Add("GenDdlBindFunction");		//DropDownList�󶨺���
        //        //arrFuncList.Add("GenBindListView");		//��������

        //        arrFuncList.Add("Gen_4BL_GetDataTable4Tab");
        //        arrFuncList.Add("Gen_4BL_GetDataTable4TabV");
        //        arrFuncList.Add("Gen_4BL_GetDataSetByCond_S");
        //        arrFuncList.Add("Gen_4BL_GetDataSetByCond_V_S");

        //        //arrFuncList.Add("Gen_4BL_GetDataTable4TabV2");
        //        arrFuncList.Add("Gen_4BL_GetRecordProperty4Object");
        //        arrFuncList.Add("Gen_4BL_GetFirstID_S");
        //        arrFuncList.Add("Gen_4BL_GetPrimaryKeyID_S");
        //        arrFuncList.Add("Gen_4BL_GetFirstObject_S");
        //        arrFuncList.Add("Gen_4BL_CondRecObjList");

        //        arrFuncList.Add("Gen_4BL_CondRecObjList2");
        //        arrFuncList.Add("Gen_4BL_IsExistRecord");
        //        arrFuncList.Add("Gen_4BL_IsExist");
        //        arrFuncList.Add("Gen_4BL_GetRecObjByKey");
        //        arrFuncList.Add("Gen_4BL_GetRecNameByKey");
        //        arrFuncList.Add("Gen_4BL_GetRecObjByKeyFromList");

        //        arrFuncList.Add("Gen_4BL_SerializeObjListToXMLStr");
        //        arrFuncList.Add("Gen_4BL_SerializeObjListToXMLFile");
        //        arrFuncList.Add("Gen_4BL_SerializeObjListToXML");
        //        arrFuncList.Add("Gen_4BL_SerializeXML");
        //        arrFuncList.Add("Gen_4BL_GetObjListFromXmlStr");
        //        arrFuncList.Add("Gen_4BL_GetObjListFromXmlFile");
        //        arrFuncList.Add("Gen_4BL_GetRecObjByXmlReader");
        //        arrFuncList.Add("Gen_4BL_GetRecObjByXmlStr");
        //        arrFuncList.Add("Gen_4BL_SerializeObjToXMLStr");
                
        //    }
        //    ClsName = "cls" + objPrjTabENEx.TabName + "BL";
        //    strClassFName = mstrFolderName + ClsName + ".cs";
        //    mstrFileName = strClassFName;
        //    clsProjectsEN objProject = clsProjectsBL.GetProjectsObjByPrjId_Cache(objPrjTabENEx.PrjId); //
            
        //    try
        //    {
        //        ///������ʼ
        //        ///
        //        strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate(objPrjTabENEx.CurrUserName, objPrjTabENEx));

        //        ///������ʼ
        //        strCodeForCs.Append("\r\n" + "using System;"); //
        //        //strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
        //        strCodeForCs.Append("\r\n" + "using System.Text; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Collections; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Collections.Generic; "); //
        //        strCodeForCs.Append("\r\n" + "using System.Globalization;");
        //        strCodeForCs.Append("\r\n" + "using System.IO;");
        //        if (objPrjTabENEx.IsForSilverLight  ==  true)
        //        {
        //            strCodeForCs.Append("\r\n" + "using System.IO.IsolatedStorage;");
        //        } 
        //        strCodeForCs.Append("\r\n" + "using System.Xml;");
        //        strCodeForCs.Append("\r\n" + "using com.taishsoft.file;");

        //        //strCodeForCs.Append("\r\n" + "using com.taishsoft.commdb;"); //
        //        if (objPrjTabENEx.IsForSilverLight  ==  false)
        //        {
        //            strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
        //            strCodeForCs.Append("\r\n" + "using System.Data; "); //
        //            strCodeForCs.AppendFormat("\r\n" + "using {0}.DAL;", objProject.PrjDomain);
        //        }


        //        strCodeForCs.Append("\r\n" + ""); //
        //        strCodeForCs.AppendFormat("\r\n" + "namespace {0}.BusinessLogic",
        //            objProject.PrjDomain);
        //        strCodeForCs.Append("\r\n" + "{");

        //        strCodeForCs.Append("\r\n /// <summary>");
        //        strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
        //        strCodeForCs.Append("\r\n /// </summary>");

        //        strCodeForCs.Append("\r\n" + "public class " + ClsName);
        //        strCodeForCs.Append("\r\n" + "{");

        //        strCodeForCs.Append("\r\n /// <summary>");
        //        strCodeForCs.Append("\r\n /// �����XML����ǩ");
        //        strCodeForCs.Append("\r\n /// </summary>");
        //        strCodeForCs.AppendFormat("\r\n" + "public const string itemXmlNode = \"{0}ListItem\";",
        //            objPrjTabENEx.TabName);
        //        strCodeForCs.Append("\r\n /// <summary>");
        //        strCodeForCs.Append("\r\n /// �б��XML����ǩ");
        //        strCodeForCs.Append("\r\n /// </summary>");
        //        strCodeForCs.AppendFormat("\r\n" + "public const string listXmlNode = \"{0}List\";",
        //            objPrjTabENEx.TabName);
        //        strCodeForCs.Append("\r\n /// <summary>");
        //        strCodeForCs.Append("\r\n /// ���ϵ�XML����ǩ");
        //        strCodeForCs.Append("\r\n /// </summary>");
        //        strCodeForCs.Append("\r\n" + "public const string itemsXmlNode = \"Items\";");

        //        //˽��������-----�����Թ���
        //        strCodeForCs.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLst = null;",
        //          objPrjTabENEx.TabName);

        //        //�������еĺ���

        //        foreach (string strFuncName in arrFuncList)
        //        {
        //            strTemp = A_GeneFuncCode(strFuncName);
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //        strCodeForCs.Append("\r\n" + "}");
        //        strCodeForCs.Append("\r\n" + "}");

        //        //������д���ļ���;
        //        clsPubFun4BLEx.SaveClassContentToFile(strClassFName, strCodeForCs.ToString(), mstrFolderName_Root, mstrBackupFolderName, myEncoding);


        //        ////�����ļ������ļ�����,���ж��Ƿ����;
        //        //strFolder = clsString.ParentDir_S(strClassFName);
        //        //if (System.IO.Directory.Exists(strFolder)  ==  false)
        //        //{
        //        //    Directory.CreateDirectory(strFolder);
        //        //}
        //        //if (clsSysParaEN.IsBackupForGeneCode  ==  true)
        //        //{
        //        //    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
        //        //    string strFindFileFullFile = clsFile.FindFileFromFolder(mstrFolderName_Root, strSimpleFileName);
        //        //    while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
        //        //    {
        //        //        clsFile.FileBackup(strFindFileFullFile, mstrBackupFolderName);
        //        //        File.Delete(strFindFileFullFile);
        //        //        strFindFileFullFile = clsFile.FindFileFromFolder(mstrFolderName_Root, strSimpleFileName);

        //        //    }
        //        //}
        //        //clsFile.1CreateFileByString(strClassFName, strCodeForCs.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        LogError(ex);
        //        throw new Exception(ex.Message, ex);
        //    }
        //    return strCodeForCs.ToString();
        //}


        private string AccessNull(clsPrjTabFldENEx objPrjTabFldENEx)
        {
            switch (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType)
            {
                case "byte":
                case "byte[]":
                    return AccessNull("objDT.Rows[0][\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"]", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable);
                default:
                    return AccessNull("objDT.Rows[0][\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"].ToString().Trim()", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable);
            }
        }
        private string AccessNull2(clsPrjTabFldENEx objPrjTabFldENEx)
        {
            switch (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType)
            {
                case "byte":
                case "byte[]":
                    return AccessNull("objRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"]", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable);
                default:
                    return AccessNull("objRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"].ToString().Trim()", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable);
            }
        }
        //private string AccessNull(clsPrjTabFldENEx objPrjTabFldENEx)
        //{
        //    return AccessNull("objDT.Rows[0][\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"].ToString().Trim()", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable);
        //}
        //private string AccessNull2(clsPrjTabFldENEx objPrjTabFldENEx)
        //{
        //    return AccessNull("objRow[\"" + objPrjTabFldENEx.objFieldTabENEx.FldName + "\"].ToString().Trim()", objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabFldENEx.IsTabNullable);
        //}
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
                        return "com.taishsoft.comm_db_obj.clsEntityBase2.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "short":
                    if (bolIsNullable  ==  true)
                    {
                        return "com.taishsoft.comm_db_obj.clsEntityBase2.TransNullToShort_S(" + strContent + ")";
                    }
                    else
                    {
                        return "short.Parse(" + strContent + ")";
                    }
                case "DateTime":
                    if (bolIsNullable  ==  true)
                    {
                        return "com.taishsoft.comm_db_obj.clsEntityBase2.TransNullToDate_S(" + strContent + ")";
                    }
                    else
                    {
                        return "System.DateTime.Parse(" + strContent + ")";
                    }
                case "Single":
                case "float":
                    if (bolIsNullable  ==  true)
                    {
                        return "com.taishsoft.comm_db_obj.clsEntityBase2.TransNullToFloat_S(" + strContent + ")";
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
                        return "com.taishsoft.comm_db_obj.clsEntityBase2.TransNullToDouble_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "bool":
                    if (bolIsNullable  ==  true)
                    {
                        return "com.taishsoft.comm_db_obj.clsEntityBase2.TransNullToBool_S(" + strContent + ")";
                    }
                    else
                    {
                        return "com.taishsoft.comm_db_obj.clsEntityBase2.TransNullToBool_S(" + strContent + ")";
                        //20070701--return "bool.Parse(" + strContent + ")";
                    }
                case "Decimal":
                    if (bolIsNullable  ==  true)
                    {
                        return "com.taishsoft.comm_db_obj.clsEntityBase2.TransNullToDouble_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.Parse(" + strContent + ")";
                    }
                case "Long":
                case "long":
                    if (bolIsNullable  ==  true)
                    {
                        return "com.taishsoft.comm_db_obj.clsEntityBase2.TransNullToInt_S(" + strContent + ")";
                    }
                    else
                    {
                        return "Int32.Parse(" + strContent + ")";
                    }
                case "Byte":
                    if (bolIsNullable  ==  true)
                    {
                        return "com.taishsoft.comm_db_obj.clsEntityBase2.TransNullToInt_S(" + strContent + ")";
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
                        return "com.taishsoft.comm_db_obj.clsEntityBase2.TransNullToInt_S(" + strContent + ")";
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



        private string GetKeyAssign()
        {
            string strPara, strTemp;
            strPara = "";
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objPrjTabFldENEx.objFieldTabENEx.PrivPropName + " = " + objPrjTabFldENEx.objFieldTabENEx.PrivFuncName;
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

        public string A_GeneFuncCode(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {
                    case "ErrNo":
                        return GenpErrNo();
                    case "Gen_4BL_ClassConstructor1":
                        return Gen_4BL_ClassConstructor1();
                    case "ConnectString":
                        return GenConnectString();
                    case "Gen_4BL_DdlBindFunction":
                        return Gen_4BL_DdlBindFunction();
                    case "Gen_4BL_ComboBoxBindFunction":
                        return Gen_4BL_ComboBoxBindFunction();
                    case "GenBindListView":
                        return GenBindListView();
                    case "GetDataSet":
                        return Gen_GetDataSet();
                    case "GetDataSetV":
                        return Gen_GetDataSetV();
                    case "GetRecordProperty":
                        return Gen_GetRecordProperty();
                    case "GetRecordPropertyV":
                        return Gen_GetRecordPropertyV();
                    case "IsExistRecordByCond":
                        return Gen_IsExistRecordByCond();
                    case "IsExist":
                        return Gen_IsExist();
                    case "Gen_4BL_CheckUniqueness":
                        return Gen_4BL_CheckUniquenessV2();
                    case "AddNewRecordBySql2":
                        return Gen_AddNewRecordBySql2();
                    case "UpdateBySql2":
                        return Gen_UpdateBySql2();
                    case "DelRecord":
                        return Gen_DelRecord();
                    case "DelMultiRecord":
                        return Gen_DelMultiRecord();
                    case "ExposeLogicClass":
                        return Gen_ExposeLogicClass();
                    case "ExposeLogicExClass":
                        return Gen_ExposeLogicExClass();
                    case "Gen_4BL_CopyObj_S":
                        return Gen_4BL_CopyObj_S();
                    case "Gen_4BL_GetDataTable4Tab":
                        return Gen_4BL_GetDataTable4Tab();
                    case "Gen_4BL_GetDataTable4TabV":
                        return Gen_4BL_GetDataTable4TabV();
                    case "Gen_4BL_GetDataSetByCond_S":
                        return Gen_4BL_GetDataSetByCond_S();
                    case "Gen_4BL_GetDataSetByCond_V_S":
                        return Gen_4BL_GetDataSetByCond_V_S();
                    case "Gen_4BL_GetDataTable4TabV2":
                        return Gen_4BL_GetDataTable4TabV2();
                    case "Gen_4BL_GetRecordProperty4Object":
                        return Gen_4BL_GetRecordProperty4Object();
                    case "Gen_4BL_GetFirstID_S":
                        return Gen_4BL_GetFirstID_S();
                    case "Gen_4BL_GetPrimaryKeyID_S":
                        return Gen_4BL_GetPrimaryKeyID_S();
              
                    case "Gen_4BL_GetFirstObject_S":
                        return Gen_4BL_GetFirstObject_S();
                    case "Gen_4BL_GetMaxStrID_S":
                        return Gen_4BL_GetMaxStrID_S();
                    case "Gen_4BL_CondRecObjList":
                        return Gen_4BL_CondRecObjList();
                    case "Gen_4BL_CondRecObjList2":
                        return Gen_4BL_CondRecObjList2();
                    case "Gen_4BL_DelRecord":
                        return Gen_4BL_DelRecord();
                    case "Gen_4BL_DelRecordBySP_S":
                        return Gen_4BL_DelRecordBySP_S();
                    case "Gen_4BL_DelMultiRecord":
                        return Gen_4BL_DelMultiRecord();
                    case "Gen_4BL_DelMultiRecordByCond":
                        return Gen_4BL_DelMultiRecordByCond();
                    case "Gen_4BL_AddNewRecordBySql2":
                        return Gen_4BL_AddNewRecordBySql2();
                    case "Gen_4BL_AddNewRecordBySql_XML":
                        return Gen_4BL_AddNewRecordBySql_XML();
                    case "Gen_4BL_UpdateBySql2":
                        return Gen_4BL_UpdateBySql2();
                    case "Gen_4BL_UpdateBySql_XML":
                        return Gen_4BL_UpdateBySql_XML();
                    case "Gen_4BL_IsExistRecord":
                        return Gen_4BL_IsExistRecord();
                    case "Gen_4BL_IsExist":
                        return Gen_4BL_IsExist();

                    case "Gen_4BL_CheckPropertyNew":
                        return Gen_4BL_CheckPropertyNew();
                    case "Gen_4BL_GetRecObjByKey":
                        return Gen_4BL_GetRecObjByKey();
                    case "Gen_4BL_GetRecNameByKey":
                        return Gen_4BL_GetRecNameByKey();

                    case "Gen_4BL_GetRecObjByKeyFromList":
                        return Gen_4BL_GetRecObjByKeyFromList();


                    case "Gen_4BL_SerializeObjListToXMLStr":
                        return Gen_4BL_SerializeObjListToXMLStr();
                    case "Gen_4BL_SerializeObjListToXMLFile":
                        return Gen_4BL_SerializeObjListToXMLFile();
                    case "Gen_4BL_SerializeObjListToXML":
                        return Gen_4BL_SerializeObjListToXML();
                    case "Gen_4BL_SerializeXML":
                        return Gen_4BL_SerializeXML();
                    case "Gen_4BL_GetObjListFromXmlStr":
                        return Gen_4BL_GetObjListFromXmlStr();
                    case "Gen_4BL_GetObjListFromXmlFile":
                        return Gen_4BL_GetObjListFromXmlFile();
                    case "Gen_4BL_GetRecObjByXmlReader":
                        return Gen_4BL_GetRecObjByXmlReader();
                    case "Gen_4BL_GetRecObjByXmlStr":
                        return Gen_4BL_GetRecObjByXmlStr();                        
                    case "Gen_4BL_SerializeObjToXMLStr":
                        return Gen_4BL_SerializeObjToXMLStr();
                    case "Gen_4BL_SerializeObjToXMLStrIso":
                        return Gen_4BL_SerializeObjToXMLStrIso();                        
                    case "TransNullToStr":
                        return GenTransNullToStr();
                    case "TransNullToInt":
                        return GenTransNullToInt();
                    case "TransNullToDate":
                        return GenTransNullToDate();
                    case "TransNullToFloat":
                        return GenTransNullToFloat();
                    case "TransNullToDouble":
                        return GenTransNullToDouble();
                    case "TransNullToBool":
                        return GenTransNullToBool();
                    case "getStrLen":
                        return GengetStrLen();
                    case "Dispose":
                        return GenDispose();
                    case "LogError":
                        return GenLogError();
                    default:
                        string strMsg = string.Format("������:{1}��Switchû�д�������!({0})",
                              clsStackTrace.GetCurrClassFunction(), strFuncName);
                        throw new Exception(strMsg);
                        //                           return "///��1����������:" + strFuncName;
                }
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("�����ɺ���:{0}ʱ����. \r\n������Ϣ:{1}.", strFuncName, objException.Message);
                throw new Exception(sbMessage.ToString());
            }
        }



        public string Gen_GetDataSet()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}_GetDataSet(string strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}EN.GetDataSet_{0}(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_GetDataSetV()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}_GetDataSetV(string strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}EN.GetDataSet_{0}V(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// ��ȡ��¼����
        /// </summary>
        /// <returns></returns>
        public string Gen_GetRecordProperty()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_Get{0}(ref cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.Get{0}();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetRecordPropertyV()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_Get{0}V(ref cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.Get{0}();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_IsExistRecordByCond()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_IsExistRecordByCond(string strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}EN.IsExistCondRec(\"{0}\", strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_IsExist()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_IsExist({2} {1})",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName, objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}EN.IsExist({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_AddNewRecordBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_AddNewRecordBySql2(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.AddNewRecordBySQL2();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_UpdateBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_UpdateBySql2(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.UpdateBySql2();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_DelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_DelRecord({2} {1})",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName, objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = new cls{0}EN({1}).DelRecordBySP();",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRecord()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_Del{0}s(List<string> arr{1}Lst)",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}EN.Del{0}(arr{1}Lst);",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRecordByCond()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public int {0}_Del{0}sByCond(string strWhereCond)",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.Del{0}sByCond(strWhereCond);",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_ExposeLogicClass()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public cls{0}EN ExposeLogicClass(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{            ");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_ExposeLogicExClass()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public cls{0}Ex ExposeLogicExClass(cls{0}Ex obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}        ");
            return strBuilder.ToString();
        }



        public string Gen_4BL_ClassConstructor1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;
            strBuilder.Append("\r\n public " + ClsName + "()");
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }



        public string Gen_4BL_GetDataTable4Tab()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_{0}(string strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT = null;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ���ݳ���!\\r\\n\" + objException.Message);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ�����ų�һЩ�ؼ��ֲ����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>"); 
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_{0}(string strWhereCond, List<string> lstExclude)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT = null;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}(strWhereCond, lstExclude);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ���ݳ���!\\r\\n\" + objException.Message);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
             strBuilder.AppendFormat("\r\n /// <param name = \"bolIsCheckSQLAttack\">�Ƿ���SQL����</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_{0}(string strWhereCond, bool bolIsCheckSQLAttack)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT = null;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}(strWhereCond, bolIsCheckSQLAttack);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ���ݳ���!\\r\\n\" + objException.Message);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataSetByCond_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSet_" + objPrjTabENEx.TabName + "(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS = null;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = cls{0}DA.GetDataSet_{0}(strCondition);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ���ݳ���!\\r\\n\" + objException.Message);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_GetDataSetByCond_V_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\npublic static System.Data.DataSet GetDataSet_" + objPrjTabENEx.TabName + "V(string strCondition)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "DataSet objDS = null;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = cls{0}DA.GetDataSet_{0}V(strCondition);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} ��ͼ���ݳ���!\\r\\n\" + objException.Message);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// ��ȡ��View��DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetDataTable4TabV()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ����ͼ,��DataTable��ʾ");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_{0}V(string strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT = null;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}V(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} View ���ݳ���!\\r\\n\" + objException.Message);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݱ����ͼ,��DataTable��ʾ,ͬʱ�����ų�һЩ�ؼ��ֲ����");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"lstExclude\">�ų��ļ���ַ����б�</param>");
            strBuilder.AppendFormat("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_{0}V(string strWhereCond, List<string> lstExclude)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT = null;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDT = cls{0}DA.Get{0}V(strWhereCond, lstExclude);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��ȡ��:{0} View ���ݳ���!\\r\\n\" + objException.Message);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            
            return strBuilder.ToString();
        }
        /// <summary>
        /// ��ȡ��View��DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetDataTable4TabV2()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static DataTable Get{0}(string strWhereCond)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS = null;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}DA.GetDataSetV(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception (\"��ȡ��View���ݳ���!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4BL_CondRecObjList()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> Get" + objPrjTabENEx.TabName + "ObjList(string strCondition)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjList = new List<cls{0}EN>(); ",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT = null; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}EN.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable_{0}(strCondition);",
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
            strBuilder.AppendFormat("\r\n	arrObjList.Add(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            strBuilder.Append("\r\nobjDT = null;");

            strBuilder.Append("\r\nreturn arrObjList;");
            strBuilder.Append("\r\n}");


            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> Get" + objPrjTabENEx.TabName + "ObjList(string strCondition, List<string> lstExclude)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjList = new List<cls{0}EN>(); ",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT = null; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}EN.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable_{0}(strCondition, lstExclude);",
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
            strBuilder.AppendFormat("\r\n	arrObjList.Add(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            strBuilder.Append("\r\nobjDT = null;");

            strBuilder.Append("\r\nreturn arrObjList;");
            strBuilder.Append("\r\n}");


            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_CondRecObjList2()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> {0}List(string strCondition)",
                            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nList<cls{0}EN> arrObjList = new List<cls{0}EN>(); ",
                            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT = null; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL = null;");
            //strBuilder.Append("\r\n //��ȡ���Ӷ���");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}EN.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTable_{0}(strCondition);",
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
            strBuilder.AppendFormat("\r\n	arrObjList.Add(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            strBuilder.Append("\r\nobjDT = null;");

            strBuilder.Append("\r\nreturn arrObjList;");
            strBuilder.Append("\r\n}");
            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// ��ȡ��������������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecordProperty4Object()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static bool Get{0}(ref cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.Get{0}(ref obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_CopyObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.AppendFormat("\r\npublic static void CopyTo(cls{0}EN obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
               objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}DA.CopyTo(obj{0}ENS, obj{0}ENT);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} ���ݳ���!\"+ objException.Message);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");            
            strBuilder.Append("\r\n}");
            ///��ȡĳһ����ֵ�ļ�¼�� ==  == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_DelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static bool DelRecord({0})",
                objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}DA.DelRecord({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"ɾ����¼����!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_DelRecordBySP_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///public bool Addnew {TabName}BySP()--------------------------;
            ///

            strTemp = string.Format("public bool DelRecordBySP({0}) ", objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + strTemp);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}DA.DelRecordBySP({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"ɾ����¼����!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            ///public bool Addnew {TabName}BySP() ==  == ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_DelMultiRecord()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static bool Del{0}s(List<string> arr{1}Lst)",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}DA.Del{0}(arr{1}Lst);",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"ɾ�����¼����!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// ɾ��������¼��������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_DelMultiRecordByCond()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static int Del{0}sByCond(string strWhereCond)",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}DA.Del{0}(strWhereCond);",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"ɾ�����¼����!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_4BL_AddNewRecordBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static bool AddNewRecordBySql2(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.AddNewRecordBySQL2(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"��Ӽ�¼����!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_AddNewRecordBySql_XML()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static bool AddNewRecordBySql_XML(string str{0}ENObjXml)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = Get{0}FromXmlStr(str{0}ENObjXml);",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.AddNewRecordBySQL2(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"��Ӽ�¼����!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4BL_UpdateBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql2(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.UpdateBySql2(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"��Ӽ�¼����!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_UpdateBySql_XML()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql_XML(string str{0}ENObjXml)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = Get{0}FromXmlStr(str{0}ENObjXml);",
                objPrjTabENEx.TabName);


            strBuilder.AppendFormat("\r\n" + "cls{0}DA obj{0}DA = new cls{0}DA();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}DA.UpdateBySql2(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw new Exception(\"��Ӽ�¼����!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4BL_IsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "public static bool IsExistRecord(string strCondition)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//����¼�Ƿ����");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}DA.IsExistCondRec(strCondition);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetFirstID_S()
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

            strBuilder.AppendFormat("\r\n {0} {1};",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n {0} = cls{1}DA.GetFirstID_S(strCondition);",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName, objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return {0};", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(\"��ȡFirst�ؼ��ֳ���!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }


        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetPrimaryKeyID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������Ĺؼ���ֵ�б�");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>�������������Ĺؼ����б�ֵ</returns>");

            strBuilder.AppendFormat("\r\npublic static List<string> GetPrimaryKeyID_S(string strCondition) ", objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n  List<string> arrList = new List<string>();");
            //strBuilder.AppendFormat("\r\n {0} {1};",
            //    objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arrList = new cls{1}DA().GetID(strCondition);",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName, objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return arrList;", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(\"��ȡ�ؼ����б����!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetMaxStrID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");

            strBuilder.Append("\r\npublic static string GetMaxStrId_S() ");
            strBuilder.Append("\r\n{");

            strBuilder.AppendFormat("\r\n string strMax{1};",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType, objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName_FstUcase);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n strMax{0} = cls{1}DA.GetMaxStrId();",
                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName_FstUcase, objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return strMax{0};", objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName_FstUcase);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(\"��ȡFirst�ؼ��ֳ���!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ��ؼ�¼����,����ж������,��ȡ���еĵ�һ��,����������������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetFirstObject_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ķ���");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strCondition\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ķ���</returns>");

            strBuilder.AppendFormat("\r\npublic static cls{0}EN GetFirst{0}_S(string strCondition) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = new cls{0}DA().GetFirst{0}(strCondition);",
                 objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n throw new Exception(\"��ȡFirst��¼�������!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }
        public string Gen_4BL_IsExist()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static bool IsExist({0})",
                objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//����¼�Ƿ����");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}DA.IsExist({1});",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_4BL_CheckUniqueness()
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
                    strBuilder.Append("\r\n" + "//����¼�Ƿ����");
                    strBuilder.AppendFormat("\r\n" + "bool bolIsUniqueness = cls{0}DA.Check{1}Uniqueness({3}, {5});",
                                            objPrjTabENEx.TabName,
                                            objPrjTabFldENEx.objFieldTabENEx.FldName,
                                            objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType,
                                            objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName,
                                            objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType,
                                            objPrjTabFldENEx.objFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n" + "return bolIsUniqueness;");
                    strBuilder.Append("\r\n" + "}");
                }
            }
            ///�������ĳ����(������)�Ƿ�Ψһ ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == ;
            return strBuilder.ToString();
        }


        public string Gen_4BL_CheckUniquenessV2()
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
                    strBuilder.AppendFormat("\r\npublic static bool Check{0}Uniqueness(cls{1}EN obj{1}EN)",
                                    objPrjTabFldENEx.objFieldTabENEx.FldName,
                                    objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\n" + "//����¼�Ƿ����");

                    strBuilder.Append("\r\n" + "bool bolIsUniqueness;");
                    strBuilder.AppendFormat("\r\n" + "if (obj{0}EN  ==  null) return true;",
                                        objPrjTabENEx.TabName);

                    switch (objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType)
                    {
                        case "int":
                        case "long":
                        case "short":
                            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1}  ==  0)",
                                    objPrjTabENEx.TabName,
                                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
                            break;
                        case "string":
                            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1}  ==  null || obj{0}EN.{1}  ==  \"\")",
                                    objPrjTabENEx.TabName,
                                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
                            break;
                        default:
                            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1}  ==  null || obj{0}EN.{1}  ==  \"\")",
                                    objPrjTabENEx.TabName,
                                    objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
                            break;
                    }
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = cls{0}DA.Check{1}Uniqueness(",
                                objPrjTabENEx.TabName,
                                objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1});",
                                objPrjTabENEx.TabName,
                                objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n" + "}");
                    strBuilder.Append("\r\n" + "else");
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "bolIsUniqueness = cls{0}DA.Check{1}Uniqueness(",
                                objPrjTabENEx.TabName,
                                objPrjTabFldENEx.objFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{2}, obj{0}EN.{1});",
                                objPrjTabENEx.TabName,
                                objPrjTabFldENEx.objFieldTabENEx.FldName,
                                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName);
                    strBuilder.Append("\r\n" + "}");
                    strBuilder.Append("\r\n" + "return bolIsUniqueness;");

                    strBuilder.Append("\r\n" + "}");
                }
            }
            ///�������ĳ����(������)�Ƿ�Ψһ ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_CheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckPropertyNew(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            //����¼�Ƿ����
            strBuilder.AppendFormat("\r\n  cls{0}DA.CheckPropertyNew(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            ///������������Ƿ���ȷ ==  ==  == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_ComboBoxBindFunction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            bool bolIsNeedQuote = true;
            clsDataTypeAbbrEN objDataTypeAbbr4ValueField = null;
            try
            {
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
                {
                    if (objPrjTabFldENEx.FieldTypeId  ==  "02")
                    {
                        strValueFieldName = objPrjTabFldENEx.objFieldTabENEx.FldName;
                        bolIsNeedQuote = objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote;
                        objDataTypeAbbr4ValueField = objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN;
                    }
                    if (objPrjTabFldENEx.FieldTypeId  ==  "03")
                    {
                        strTextFieldName = objPrjTabFldENEx.objFieldTabENEx.FldName;
                    }
                }
                if (strValueFieldName !=  "" && strTextFieldName !=  "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
                        strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//Ϊ����ԴΪ�����������������");
                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = cls{1}DA.Get{0}();",
                        strValueFieldName, objPrjTabENEx.TabName);
                 

                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                        objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "//��ʼ��һ�������б�");
                    strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                        objPrjTabENEx.TabName);
                    if (bolIsNeedQuote  ==  true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"0\";",
                            objPrjTabENEx.TabName, strValueFieldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = 0;",
                            objPrjTabENEx.TabName, strValueFieldName);
                    
                    }
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"��ѡ��...\";",
                        objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0}EN);",
                        objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//��DataTable�е���������ӵ������б���");
                    strCodeForCs.Append("\r\n" + "foreach(DataRow objRow in objDT.Rows)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                        objPrjTabENEx.TabName);
                    if (bolIsNeedQuote  ==  true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[cls{0}EN.con_{1}].ToString();",
                            objPrjTabENEx.TabName, strValueFieldName);
                    }
                    else
                    {
                        
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2}.Parse(objRow[cls{0}EN.con_{1}].ToString());",
                            objPrjTabENEx.TabName, strValueFieldName, objDataTypeAbbr4ValueField.CSType);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[cls{0}EN.con_{1}].ToString();",
                        objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0}EN);",
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
        public string Gen_4BL_DdlBindFunction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            try
            {
                ///���ɽ��б���;
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
                    strCodeForCs.Append("\r\n ///��������ĺ�������");

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
                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = cls{1}DA.Get{0}();",
                        strValueFieldName, objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};", 
                        objPrjTabENEx.TabName,  strValueFieldName);
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
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN Get{0}ObjBy{1}({2} {3})",
                objPrjTabENEx.TabName,
                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType,
                objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}ObjLst  ==  null)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = new cls{0}DA().Get{0}ObjList(\"1 = 1\");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLst)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1}  ==  {2})",
                objPrjTabENEx.TabName,
                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. ==  == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecNameByKey()
        {
             string strTextFieldName = "";
            string strValueFieldName = "";
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
                if (strValueFieldName  ==  "" || strTextFieldName  ==  "")
                {
                    return "";
                }
            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ������</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string Get{4}By{1}({2} {3})",
                objPrjTabENEx.TabName,
                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType,
                objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName,
                strTextFieldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}ObjLst  ==  null)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = new cls{0}DA().Get{0}ObjList(\"1 = 1\");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLst)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1}  ==  {2})",
                objPrjTabENEx.TabName,
                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN.{1};",
                objPrjTabENEx.TabName,
                strTextFieldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return \"\";");
            strBuilder.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. ==  == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecObjByKeyFromList()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.");
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN Get{0}ObjBy{1}FromList({2} {3}, List<cls{0}EN> lst{0}ObjList)",
                objPrjTabENEx.TabName,
                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                objPrjTabENEx.objKeyField0.objFieldTabENEx.objDataTypeAbbrEN.CSType,
                objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in lst{0}ObjList)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1}  ==  {2})",
                objPrjTabENEx.TabName,
                objPrjTabENEx.objKeyField0.objFieldTabENEx.FldName,
                objPrjTabENEx.objKeyField0.objFieldTabENEx.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. ==  == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// ��XmlReader��һ������.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecObjByXmlReader()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��XmlReader��һ������-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��XmlReader��һ������");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.CurrUserName);
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.CurrDate);
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"reader\">�ṩ������Դ:XmlReader</param>");
            strBuilder.AppendFormat("\r\n /// <returns>���ص�һ������</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN Get{0}FromXml(System.Xml.XmlReader reader)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
              strBuilder.AppendFormat("\r\n" + "reader.Read();");
              strBuilder.AppendFormat("\r\n" + "while (!(reader.Name  ==  cls{0}BL.itemXmlNode && reader.NodeType  ==  XmlNodeType.EndElement))",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "if (reader.IsStartElement(\"{0}\"))", objPrjTabFldENEx.objFieldTabENEx.FldName);
                strBuilder.Append("\r\n" + "{");
                switch (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType)
                {
                    case "string":
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsString();",
                            objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                        break;
                    case "bool":
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsBoolean();",
                            objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName); 
                            break;
                    case "int":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsInt();",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                            break;
                    case "long":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsLong();",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                            break;
                    case "float":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsFloat();",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                            break;
                    case "double":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsDouble();",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                            break;
                    case "DateTime":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsDateTime();",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                            break;

                    case "short":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = (short)reader.ReadElementContentAsInt();",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                            break;
                    case "Int16":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsInt();",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                            break;
                    case "Int32":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsInt();",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                            break;
                    case "byte":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsByte();",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                            break;
                    case "byte[]":
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsBytes();",
                                objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                            break;
                    default:
                            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = reader.ReadElementContentAsString();",
        objPrjTabENEx.TabName, objPrjTabFldENEx.objFieldTabENEx.FldName);
                            break;
                }
                strBuilder.Append("\r\n" + "}");

            }

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. ==  == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// ��XML�ļ��л�ȡһ�������б�.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjListFromXmlFile()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��XML�ļ��л�ȡһ�������б�-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��XML�ļ��л�ȡһ�������б�");
            strBuilder.AppendFormat("\r\n /// ����:{0}",
                objPrjTabENEx.CurrUserName);
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.CurrDate);
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strXmlFileName\">�ṩ��һ��XML�ļ�</param>");
            strBuilder.AppendFormat("\r\n /// <returns>����һ��<cls{0}EN>�����б�</returns>",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> Get{0}ObjListFromXmlFile(string strXmlFileName)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> lst{0}Obj = new List<cls{0}EN>();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "XmlReader reader = XmlReader.Create(strXmlFileName);");
            strBuilder.AppendFormat("\r\n" + "while (reader.ReadToFollowing(cls{0}BL.itemXmlNode))",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = Get{0}FromXml(reader);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "lst{0}Obj.Add(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return lst{0}Obj;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. ==  == = ;
            return strBuilder.ToString();
        }
        /// <summary>
        /// ��XML���л�ȡһ�������б�.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetObjListFromXmlStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��XML���л�ȡһ�������б�.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��XML���л�ȡһ�������б�");
            strBuilder.AppendFormat("\r\n /// ����:{0}",
                objPrjTabENEx.CurrUserName);
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.CurrDate);
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}listXml\">�ṩ��һ��XML��</param>",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ��<cls{0}EN>�����б�</returns>",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> Get{0}ObjListFromXmlStr(string str{0}listXml)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> lst{0}Obj = new List<cls{0}EN>();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "UTF8Encoding enc = new UTF8Encoding();");
            strBuilder.AppendFormat("\r\n" + "using (MemoryStream ms = new MemoryStream(enc.GetBytes(str{0}listXml)))",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "XmlReaderSettings xmlrs = new XmlReaderSettings();");
            strBuilder.AppendFormat("\r\n" + "xmlrs.IgnoreComments = true;");
            strBuilder.AppendFormat("\r\n" + "xmlrs.IgnoreWhitespace = true;");
            strBuilder.AppendFormat("\r\n" + "XmlReader reader = XmlReader.Create(ms, xmlrs);");

            strBuilder.AppendFormat("\r\n" + "while (reader.ReadToFollowing(cls{0}BL.itemXmlNode))",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = Get{0}FromXml(reader);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "lst{0}Obj.Add(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return lst{0}Obj;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. ==  == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// ��һ���������л���XML��.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeXML()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��һ���������л���XML��");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.CurrUserName);
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.CurrDate);
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"writer\">Ŀ��:���л�����XmlWriter</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">����Դ:��Ҫ���л��Ķ���</param>",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static void SerializeXML(XmlWriter writer, cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "writer.WriteStartElement(cls{0}BL.itemXmlNode);",
                objPrjTabENEx.TabName);


            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrFldSet)
            {

                switch (objPrjTabFldENEx.objFieldTabENEx.objDataTypeAbbrEN.CSType)
                {
                    case "string":
                        strBuilder.AppendFormat("\r\n" + "writer.WriteElementString(\"{0}\", obj{1}EN.{0}.ToString(CultureInfo.InvariantCulture));",
        objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                    case "bool":
                        //strBuilder.AppendFormat("\r\n arrFieldListForInsert.Add(\"{0}\");",
                        //    objPrjTabFldENEx.objFieldTabENEx.FldName);
                        //strBuilder.AppendFormat("\r\n arrValueListForInsert.Add(\"'\" + ({0}  ==  false ? \"0\" : \"1\") + \"'\");",
                        //    objPrjTabFldENEx.objFieldTabENEx.PrivPropNameWithObjectName("obj" + objPrjTabENEx.TabName + "EN"));
                        strBuilder.AppendFormat("\r\n" + "writer.WriteElementString(\"{0}\", obj{1}EN.{0}.ToString().ToLower(CultureInfo.InvariantCulture));",
                   objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                    case "int":
                    case "long":
                    case "float":
                    case "double":
                    case "short":
                    case "Int16":
                    case "Int32":
                    case "byte":
                    case "byte[]":
                        strBuilder.AppendFormat("\r\n" + "writer.WriteElementString(\"{0}\", obj{1}EN.{0}.ToString(CultureInfo.InvariantCulture));",
                    objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                    default:
                        strBuilder.AppendFormat("\r\n" + "writer.WriteElementString(\"{0}\", obj{1}EN.{0}.ToString(CultureInfo.InvariantCulture));",
                   objPrjTabFldENEx.objFieldTabENEx.FldName, objPrjTabENEx.TabName);
                        break;
                }

            }

            strBuilder.AppendFormat("\r\n" + "writer.WriteEndElement();");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���л�һ�������б�XmlWriter.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjListToXML()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���л�һ�������б�XmlWriter");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.CurrUserName);
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.CurrDate);
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strXmlFileName\">�ṩ��һ��XML�ļ�</param>");
            strBuilder.AppendFormat("\r\n /// <returns>����һ��<cls{0}EN>�����б�</returns>",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static bool SerializeObjListToXML(List<cls{0}EN> lst{0}ObjList, XmlWriter writer)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "writer.WriteStartElement(cls{0}BL.listXmlNode);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "writer.WriteStartElement(cls{0}BL.itemsXmlNode);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in lst{0}ObjList)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}BL.SerializeXML(writer, obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "writer.WriteEndElement();");
            strBuilder.AppendFormat("\r\n" + "writer.WriteEndElement();");
            strBuilder.AppendFormat("\r\n" + "return true;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        /// <summary>
        /// ���л�һ�������б�Xml�ļ�.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjListToXMLFile()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���л�һ�������б�Xml�ļ�");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.CurrUserName);
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.CurrDate);
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"lst{0}ObjList\">��Ҫ���л��Ķ����б�</param>",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"strXmlFile\">���ɵ�XML�ļ�</param>");
            strBuilder.AppendFormat("\r\n" + "public static void SerializeObjListToXMLFile(List<cls{0}EN> lst{0}ObjList, string strXmlFile)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "XmlWriterSettings settings = new XmlWriterSettings();");
            strBuilder.AppendFormat("\r\n" + "settings.Indent = true;");
            strBuilder.AppendFormat("\r\n" + "settings.IndentChars = (\"  \");");
            strBuilder.AppendFormat("\r\n" + "using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "SerializeObjListToXML(lst{0}ObjList, writer);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        /// <summary>
        /// ���л�һ�������б�Xml�ļ�.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjListToXMLStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���л�һ�������б�Xml�ļ�");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.CurrUserName);
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.CurrDate);
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"lst{0}ObjList\">��Ҫ���л��Ķ����б�</param>",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"strXmlFile\">���ɵ�XML�ļ�</param>");
            strBuilder.AppendFormat("\r\n /// <returns>����һ��<cls{0}EN>�����б�XML��</returns>",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string SerializeObjListToXMLStr(List<cls{0}EN> lst{0}ObjList)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strXmlFile = clsSysParaEN.strTempXMLFileName;");
            strBuilder.AppendFormat("\r\n" + "XmlWriterSettings settings = new XmlWriterSettings();");
            strBuilder.AppendFormat("\r\n" + "settings.Indent = true;");
            strBuilder.AppendFormat("\r\n" + "settings.IndentChars = (\"  \");");
            strBuilder.AppendFormat("\r\n" + "using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "SerializeObjListToXML(lst{0}ObjList, writer);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);");
            strBuilder.AppendFormat("\r\n" + "return strXmlString;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���л�һ������Xml�ļ�.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjToXMLStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���л�һ������Xml�ļ�");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.CurrUserName);
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.CurrDate);
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ���л��Ķ���</param>",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ��<cls{0}EN>����XML��</returns>",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string SerializeObjToXMLStr(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strXmlFile = clsSysParaEN.strTempXMLFileName;");
            strBuilder.AppendFormat("\r\n" + "XmlWriterSettings settings = new XmlWriterSettings();");
            strBuilder.AppendFormat("\r\n" + "settings.Indent = true;");
            strBuilder.AppendFormat("\r\n" + "settings.IndentChars = (\"  \");");
            strBuilder.AppendFormat("\r\n" + "using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "SerializeXML(writer, obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);");
            strBuilder.AppendFormat("\r\n" + "return strXmlString;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        /// <summary>
        /// ���л�һ������Xml�ļ�,���ø����ļ�
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_SerializeObjToXMLStrIso()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���л�һ������Xml�ļ�,���ø����ļ�");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.CurrUserName);
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.CurrDate);
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ���л��Ķ���</param>",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ��<cls{0}EN>����XML��</returns>",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static string SerializeObjToXMLStrByIso(cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "string strXmlIsoFile = clsSysParaEN.strTempXMLIsoFileName;");

            strBuilder.AppendFormat("\r\n" + "using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication())");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "XmlWriterSettings xmlws = new XmlWriterSettings();");
            strBuilder.AppendFormat("\r\n" + "xmlws.Indent = true;");
            strBuilder.AppendFormat("\r\n" + "using (IsolatedStorageFileStream isoStream = isoStore.CreateFile(strXmlIsoFile))");
            strBuilder.AppendFormat("\r\n" + "using (XmlWriter writer = XmlWriter.Create(isoStream, xmlws))");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "SerializeXML(writer, obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "string strXmlString = clsFile.GetContentFromIsoFile(strXmlIsoFile);");
            strBuilder.AppendFormat("\r\n" + "return strXmlString;");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

         /// <summary>
        /// ��Xml�ַ�����һ������
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_GetRecObjByXmlStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��XmlReader��һ������-----------------------------;


            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��Xml�ַ�����һ������");
            strBuilder.Append("\r\n /// ����:���Է�");
            strBuilder.Append("\r\n /// ����:2010/10/04");
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}ObjXmlStr\">�ṩ������Դ:��ʾһ�������XML��</param>",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>���ص�һ������</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN Get{0}FromXmlStr(string str{0}ObjXmlStr)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "UTF8Encoding enc = new UTF8Encoding();");
            strBuilder.AppendFormat("\r\n" + "using (MemoryStream ms = new MemoryStream(enc.GetBytes(str{0}ObjXmlStr)))",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "XmlReaderSettings xmlrs = new XmlReaderSettings();");
            strBuilder.Append("\r\n" + "xmlrs.IgnoreComments = true;");
            strBuilder.Append("\r\n" + "xmlrs.IgnoreWhitespace = true;");
            strBuilder.Append("\r\n" + "XmlReader reader = XmlReader.Create(ms, xmlrs);");
            strBuilder.AppendFormat("\r\n" + "while (reader.ReadToFollowing(cls{0}BL.itemXmlNode))",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = Get{0}FromXml(reader);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

    }
}
