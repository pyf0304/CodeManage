using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;


using AGC.Entity;

using AGC.BusinessLogic;
using com.taishsoft.datetime;
using AgcCommBase;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
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
    partial class AutoGC6Cs_Business : AutoGCPubFuncV6
    {
        
        /// <summary>
        /// ����ҵ���߼�����룭��Swift2
        /// </summary>
        /// <returns></returns>
        public string A_GenBusinessLogicCode_Swift(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            this.CmPrjId = "û�и�ֵ,�����¿���!";
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = "��ǰ��:" + objPrjTabENEx.TabName + "���ֶ���Ϊ0,�޷�����ͨ���߼���!";
                return strResult;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!({1})",
                       objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(1);
            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "BL";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.BusinessLogicLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";
            objPrjTabENEx.FileName = strClassFName;

            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                //������ʼ


                strCodeForCs.AppendFormat("\r\n" + "import Foundation",
                   objProjectsENEx.JavaPackageName,
                   objPrjTabENEx.TabName);


                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                clsSQLDSTypeEN objSQLDSType = clsSQLDSTypeBL.GetObjBySqlDsTypeIdCache(objPrjTabENEx.SqlDsTypeId);
                strCodeForCs.AppendFormat("\r\n /// ����Դ����:{0}",
                objSQLDSType.SqlDsTypeName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public class  {0} : NSObject", objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �����XML����ǩ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public var itemXmlNode : String = \"{0}ListItem\";",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �б��XML����ǩ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public var listXmlNode : String = \"{0}List\";",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ���ϵ�XML����ǩ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public var itemsXmlNode :String = \"Items\";");

                //˽��������-----�����Թ���
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public static var arr{0}ObjLstCache : Array<cls{0}EN> = Array<cls{0}EN>();",
                       objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// �ӻ����в���ʧ�ܵĴ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "private var intFindFailCount : Int = 0;");

                //�������еĺ���

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        if (objPrjTabENEx.LangType == clsPubConst.LangType.CSharp)
                        {
                            strCodeForCs.Append("\r\n" + "");
                            strCodeForCs.Append("\r\n" + "");
                            strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        }
                        continue;
                    }
                    try
                    {
                        strTemp = A_GeneFuncCode_Swift(strFuncName);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
                                objException.Message,
                                clsStackTrace.GetCurrClassFunction());
                        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                        throw new Exception(strMsg);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }
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
                
        public string A_GeneFuncCode_Swift(string strFuncName)
        {
            try
            {

                switch (strFuncName)
                {

                    case "Gen_4BL_getRecObjByJSONStr_Swift":
                        return Gen_4BL_Swift_getRecObjByJSONStr();


                    case "Gen_4BL_getObjLstByJSONStr_Swift":
                        return Gen_4BL_Swift_getObjLstByJSONStr();

                    case "Gen_4BL_getJSONStrByRecObj_Swift":
                        return Gen_4BL_Swift_getJSONStrByRecObj();


                    case "Gen_4BL_getDictionaryObjByRecObj_Swift":
                        return Gen_4BL_Swift_getDictionaryObjByRecObj();

                  
                    case "ErrNo":
                        return GenpErrNo();

                    case "ConnectString":
                        return GenConnectString();
                 
                    case "GenBindListView":
                        return GenBindListView();
                    case "Gen_4BL_SerializeObjToXMLStrIso_SilverLight":
                        return Gen_4BL_SerializeObjToXMLStrIso_SilverLight();

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
                    case "GetStrLen":
                        return GengetStrLen();
                    case "Dispose":
                        return GenDispose();
                    case "LogError":
                        return GenLogError();
                    default:
                        string strMsg = string.Format("������:{1}��Switchû�д���,����!({0})",
                            clsStackTrace.GetCurrClassFunction(), strFuncName);
                        throw new Exception(strMsg);
                        //            return "///��1����������:" + strFuncName;
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
        }
                
    
        /// <summary>
        /// ��һ��JSON��ת��Ϊһ������.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Swift_getRecObjByJSONStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��һ��JSON��ת��Ϊһ������");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strJSON\">��Ҫת����JSON��</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ�����ɵĶ���</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static func GetObjByJSONStr(strJSON : String) -> cls{0}EN",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "const json : AnyObject!");

            strBuilder.AppendFormat("\r\n" + "let data : NSData! = strJSON.dataUsingEncoding(NSUTF8StringEncoding);");

            strBuilder.AppendFormat("\r\n" + "if (strJSON == \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "do");
            strBuilder.Append("\r\n" + "{");
            //  let data : NSData! = try? NSJSONSerialization.dataWithJSONObject(strJSON, options: []);

            strBuilder.AppendFormat("\r\n" + "json = try? NSJSONSerialization.JSONObjectWithData(data, options: NSJSONReadingOptions.AllowFragments);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch let objException as NSError");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//��ȡJSON���������еĹؼ��ּ���");
            strBuilder.Append("\r\n" + "let jsonAllKeys : NSArray = json.allKeys;");
            strBuilder.Append("\r\n" + "//�����ؼ��ּ���,����ӡ����!");
            strBuilder.Append("\r\n" + "//for strKey in jsonAllKeys");
            strBuilder.Append("\r\n" + "//{");
            strBuilder.Append("\r\n" + "//print(strKey);");
            strBuilder.Append("\r\n" + "//}");
            strBuilder.Append("\r\n" + "//���ؼ��֣�\"Memo1\"�ڹؼ��ּ������Ƿ����!");
            strBuilder.Append("\r\n" + "//if (jsonAllKeys.containsObject(\"Memo1\") == true)");
            strBuilder.Append("\r\n" + "//{");
            strBuilder.Append("\r\n" + "//print(\"Memo1 is Exist!\");");
            strBuilder.Append("\r\n" + "//}");
            strBuilder.Append("\r\n" + "//else");
            strBuilder.Append("\r\n" + "//{");
            strBuilder.Append("\r\n" + "//print(\"Memo1 is not Exist!\");");
            strBuilder.Append("\r\n" + "//}");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(json.getString(\"{1}\"));",
                //     objPrjTabENEx.TabName,
                //     objField.ObjFieldTabENEx.FldName
                //    );
                string strResult = SetPropertyByJson_Swift(objField);
                strBuilder.Append(strResult);
            }


            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
                    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        
        /// <summary>
        /// ��һ��JSON��ת��Ϊһ������.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Swift_getJSONStrByRecObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��һ������ת��Ϊһ��JSON��");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strJSON\">��Ҫת����JSON��</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ�����ɵĶ���</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static func GetJSONStrByObj(obj{0}EN : cls{0}EN) -> String",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.getUpdFldString();",
                objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "const objDict : NSMutableDictionary!");

            strBuilder.AppendFormat("\r\n" + "objDict = GetDictionaryObjByObj(obj{0}EN);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "const strJson : NSString!");
            strBuilder.Append("\r\n" + "const jsonData: NSData!");
            strBuilder.Append("\r\n" + "do");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "jsonData = try? NSJSONSerialization.dataWithJSONObject(objDict, options: NSJSONWritingOptions());");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch let objException as NSException");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "return String(objException);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "strJson = NSString(data: jsonData!, encoding: NSUTF8StringEncoding);");
            strBuilder.Append("\r\n" + "return String(strJson);");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
    
        /// <summary>
        /// ��һ��JSON��ת��Ϊһ������.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Swift_getDictionaryObjByRecObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��һ������ת��Ϊһ��JSON��");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strJSON\">��Ҫת����JSON��</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ�����ɵĶ���</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static func GetDictionaryObjByObj(obj{0}EN : cls{0}EN) -> NSMutableDictionary",
                  objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.getUpdFldString();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "const objDict : NSMutableDictionary!");
            strBuilder.Append("\r\n" + "objDict = NSMutableDictionary();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
                {
                    case "Int32":
                        strBuilder.AppendFormat("\r\n" + "objDict.setValue(String(obj{0}EN.{1}), forKey: cls{0}EN.con_{1});",
                             objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                        break;
                    default:
                        strBuilder.AppendFormat("\r\n" + "objDict.setValue(obj{0}EN.{1}, forKey: cls{0}EN.con_{1});",
                             objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                        break;
                }
            }
            strBuilder.AppendFormat("\r\n" + "objDict.setValue(obj{0}EN.sfUpdFldSetStr, forKey: \"sfUpdFldSetStr\");",
                 objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDict;");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
    
        /// <summary>
        /// ��һ��JSON��ת��Ϊһ�������б�.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Swift_getObjLstByJSONStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��һ��JSON��ת��Ϊһ�������б�");
            strBuilder.AppendFormat("\r\n /// ����:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// ����:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strJSON\">��Ҫת����JSON��</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>����һ�����ɵĶ����б�</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static func GetObjLstByJSONStr(strJSON : String) -> Array<cls{0}EN> ",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
              objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "let data = strJSON.dataUsingEncoding(NSUTF8StringEncoding);");

            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst : Array<cls{0}EN>= Array<cls{0}EN>();",
              objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "if (strJSON == \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "do");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let jsonArr = try! NSJSONSerialization.JSONObjectWithData(data!, options: NSJSONReadingOptions.MutableContainers) as!NSArray;",
              objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "json = new JSONObject(strJSON);");
            strBuilder.AppendFormat("\r\n" + "for json in jsonArr");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//��ȡJSON���������еĹؼ��ּ���");
            strBuilder.Append("\r\n" + "let jsonAllKeys : NSArray = json.allKeys;");
            strBuilder.Append("\r\n" + "//�����ؼ��ּ���,����ӡ����!");
            strBuilder.Append("\r\n" + "//for strKey in jsonAllKeys");
            strBuilder.Append("\r\n" + "//{");
            strBuilder.Append("\r\n" + "//print(strKey);");
            strBuilder.Append("\r\n" + "//}");
            strBuilder.Append("\r\n" + "//���ؼ��֣�\"Memo1\"�ڹؼ��ּ������Ƿ����!");
            strBuilder.Append("\r\n" + "//if (jsonAllKeys.containsObject(\"Memo1\") == true)");
            strBuilder.Append("\r\n" + "//{");
            strBuilder.Append("\r\n" + "//print(\"Memo1 is Exist!\");");
            strBuilder.Append("\r\n" + "//}");
            strBuilder.Append("\r\n" + "//else");
            strBuilder.Append("\r\n" + "//{");
            strBuilder.Append("\r\n" + "//print(\"Memo1 is not Exist!\");");
            strBuilder.Append("\r\n" + "//}");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = cls{0}EN();",
                  objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(json.getString(\"{1}\"));",
                //     objPrjTabENEx.TabName,
                //     objField.ObjFieldTabENEx.FldName
                //    );
                string strResult = SetPropertyByJson_Swift(objField);
                strBuilder.Append(strResult);
            }
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst.append(obj{0}EN);",
              objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch let objException as tzErrorType");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        private string SetPropertyByJson_Swift(clsPrjTabFldENEx objField)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n" + "if (jsonAllKeys.containsObject(\"{0}\") == true)",
                 objField.ObjFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "{");
            //  strBuilder.Append("\r\n" + "//print(\"Memo1 is Exist!\");");
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
            {
                case "String":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = String(json.objectForKey(\"{1}\")!);",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Int32":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = Int32(String(json.objectForKey(\"{1}\")!))!;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Int":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = Int(String(json.objectForKey(\"{1}\")!))!;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Double":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = Double(String(json.objectForKey(\"{1}\")!))!;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Float":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = Float(String(json.objectForKey(\"{1}\")!))!;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Short":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = Short(String(json.objectForKey(\"{1}\")!))!;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Bool":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = clsPubFun.myBool(json.objectForKey(\"{1}\")!);",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                default:
                    string strMsg = string.Format("Swift��������:[{1}]��switch��û�д���({0})",
                        clsStackTrace.GetCurrClassFunction(),
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
                    throw new Exception(strMsg);

            }
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
     
    }
}
