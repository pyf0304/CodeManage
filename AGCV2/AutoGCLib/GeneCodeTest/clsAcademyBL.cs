
///----------------------
///���ɴ���汾:2012.11.9.1
///��������:2012/11/20
///������:���Է�
///��������:AGC_CSV7
///����ID:0005
///ģ��������:���ɴ������
///ģ��Ӣ����:GeneCodeTest
///ע��:1����Ҫ���ݵײ�(PubDataBase.dll)�İ汾:2012.10.20.1
///       2����Ҫ����������(TzPubFunction.dll)�İ汾:2012.10.23.1
///========================
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
 using System.Globalization;
using System.IO;
 using System.Xml;
  using com.taishsoft.file;
using AGC_CSV7.Entity;
using System.Data; 
using AGC_CSV7.DAL;

namespace AGC_CSV7.BusinessLogicEx
{
/// <summary>
/// ѧԺ(Academy)
/// ����Դ����:SQL��
/// </summary>
public class clsAcademyBL
{
 /// <summary>
/// �����XML����ǩ
/// </summary>
public const string itemXmlNode = "AcademyListItem";
/// <summary>
/// �б��XML����ǩ
/// </summary>
public const string listXmlNode = "AcademyList";
/// <summary>
/// ���ϵ�XML����ǩ
/// </summary>
public const string itemsXmlNode = "Items";
public static List<clsAcademyEN> arrAcademyObjLst = null;

 public clsAcademyBL()
 {
 }



public static void CopyTo(clsAcademyEN objAcademyENS, clsAcademyEN objAcademyENT)
{
clsAcademyDA objAcademyDA = new clsAcademyDA();
try
{
objAcademyDA.CopyTo(objAcademyENS, objAcademyENT);
}
catch (Exception objException)
{
throw new Exception("Copy��:Academy ���ݳ���!"+ objException.Message);
}
}

/// <summary>
/// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����
/// </summary>
/// <param name="strWhereCond">������</param>
/// <returns></returns>
public static DataTable GetDataTable_Academy(string strWhereCond)
{
 DataTable objDT = null;
try
{
objDT = clsAcademyDA.GetAcademy(strWhereCond);
return objDT;
}
catch (Exception objException)
{
throw new Exception("��ȡ��:Academy ���ݳ���!\r\n" + objException.Message);
}
}
/// <summary>
/// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ�����ų�һЩ�ؼ��ֲ����
/// </summary>
/// <param name="strWhereCond">������</param>
  /// <param name="lstExclude">�ų��ļ���ַ����б�</param>
/// <returns></returns>
public static DataTable GetDataTable_Academy(string strWhereCond, List<string> lstExclude)
{
 DataTable objDT = null;
try
{
objDT = clsAcademyDA.GetAcademy(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
throw new Exception("��ȡ��:Academy ���ݳ���!\r\n" + objException.Message);
}
}
/// <summary>
/// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����
/// </summary>
/// <param name="strWhereCond">������</param>
/// <param name="bolIsCheckSQLAttack">�Ƿ���SQL����</param>
/// <returns></returns>
public static DataTable GetDataTable_Academy(string strWhereCond, bool bolIsCheckSQLAttack)
{
 DataTable objDT = null;
try
{
objDT = clsAcademyDA.GetAcademy(strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
throw new Exception("��ȡ��:Academy ���ݳ���!\r\n" + objException.Message);
}
}

/// <summary>
/// ����������ȡ���ݱ����ͼ,��DataTable��ʾ
/// </summary>
/// <param name="strWhereCond">������</param>
/// <returns></returns>
public static DataTable GetDataTable_AcademyV(string strWhereCond)
{
DataTable objDT = null;
try
{
objDT = clsAcademyDA.GetAcademyV(strWhereCond);
return objDT;
}
catch (Exception objException)
{
throw new Exception("��ȡ��:Academy View ���ݳ���!\r\n" + objException.Message);
}
}
/// <summary>
/// ����������ȡ���ݱ����ͼ,��DataTable��ʾ,ͬʱ�����ų�һЩ�ؼ��ֲ����
/// </summary>
/// <param name="strWhereCond">������</param>
  /// <param name="lstExclude">�ų��ļ���ַ����б�</param>
/// <returns></returns>
public static DataTable GetDataTable_AcademyV(string strWhereCond, List<string> lstExclude)
{
DataTable objDT = null;
try
{
objDT = clsAcademyDA.GetAcademyV(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
throw new Exception("��ȡ��:Academy View ���ݳ���!\r\n" + objException.Message);
}
}

public static System.Data.DataSet GetDataSet_Academy(string strCondition)
{
 DataSet objDS = null;
try
{
objDS = clsAcademyDA.GetDataSet_Academy(strCondition);
return objDS;
}
catch (Exception objException)
{
throw new Exception("��ȡ��:Academy ���ݳ���!\r\n" + objException.Message);
}
}

public static System.Data.DataSet GetDataSet_AcademyV(string strCondition)
{
 DataSet objDS = null;
try
{
objDS = clsAcademyDA.GetDataSet_AcademyV(strCondition);
return objDS;
}
catch (Exception objException)
{
throw new Exception("��ȡ��:Academy ��ͼ���ݳ���!\r\n" + objException.Message);
}
}

public static bool GetAcademy(ref clsAcademyEN objAcademyEN)
{
clsAcademyDA objAcademyDA = new clsAcademyDA();
bool bolResult = objAcademyDA.GetAcademy(ref objAcademyEN);
return bolResult;
}

/// <summary>
/// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ
/// </summary>
/// <param name="strCondition">������</param>
/// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>
public static string GetFirstID_S(string strCondition ) 
{
 string strAcademyId;
 try
 {
 strAcademyId = clsAcademyDA.GetFirstID_S(strCondition);
 return strAcademyId;
 }
 catch (Exception objException)
 {
 throw new Exception("��ȡFirst�ؼ��ֳ���!\r\n" + objException.Message);
 }
}

/// <summary>
/// ��ȡ��ǰ�����������ĵ�һ����¼�Ķ���
/// </summary>
/// <param name="strCondition">������</param>
/// <returns>���صĵ�һ����¼�Ķ���</returns>
public static clsAcademyEN GetFirstAcademy_S(string strCondition ) 
{
 try
 {
 clsAcademyEN objAcademyEN = new clsAcademyDA().GetFirstAcademy(strCondition);
 return objAcademyEN;
 }
 catch (Exception objException)
 {
 throw new Exception("��ȡFirst��¼�������!\r\n" + objException.Message);
 }
}

/// <summary>
/// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ
/// </summary>
/// <param name="strCondition">������</param>
/// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>
public static string GetMaxStrId_S() 
{
 string strMaxAcademyId;
 try
 {
 strMaxAcademyId = clsAcademyDA.GetMaxStrId();
 return strMaxAcademyId;
 }
 catch (Exception objException)
 {
 throw new Exception("��ȡFirst�ؼ��ֳ���!\r\n" + objException.Message);
 }
}

public static List<clsAcademyEN> GetAcademyObjList(string strCondition)
{
List<clsAcademyEN> arrObjList = new List<clsAcademyEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_Academy(strCondition);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAcademyEN objAcademyEN = new clsAcademyEN();
objAcademyEN.AcademyId = objRow["AcademyId"].ToString().Trim(); //ѧԺID
objAcademyEN.AcademyName = objRow["AcademyName"].ToString().Trim(); //ѧԺ����
objAcademyEN.Memo = objRow["Memo"].ToString().Trim(); //˵��
	arrObjList.Add(objAcademyEN);
	}
objDT = null;
return arrObjList;
}
public static List<clsAcademyEN> GetAcademyObjList(string strCondition, List<string> lstExclude)
{
List<clsAcademyEN> arrObjList = new List<clsAcademyEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_Academy(strCondition, lstExclude);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAcademyEN objAcademyEN = new clsAcademyEN();
objAcademyEN.AcademyId = objRow["AcademyId"].ToString().Trim(); //ѧԺID
objAcademyEN.AcademyName = objRow["AcademyName"].ToString().Trim(); //ѧԺ����
objAcademyEN.Memo = objRow["Memo"].ToString().Trim(); //˵��
	arrObjList.Add(objAcademyEN);
	}
objDT = null;
return arrObjList;
}

public static List<clsAcademyEN> AcademyList(string strCondition)
{
List<clsAcademyEN> arrObjList = new List<clsAcademyEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_Academy(strCondition);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAcademyEN objAcademyEN = new clsAcademyEN();
objAcademyEN.AcademyId = objRow["AcademyId"].ToString().Trim(); //ѧԺID
objAcademyEN.AcademyName = objRow["AcademyName"].ToString().Trim(); //ѧԺ����
objAcademyEN.Memo = objRow["Memo"].ToString().Trim(); //˵��
	arrObjList.Add(objAcademyEN);
	}
objDT = null;
return arrObjList;
}

public static bool DelRecord(string strAcademyId)
{
try
{
bool bolResult = clsAcademyDA.DelRecord(strAcademyId);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("ɾ����¼����!\r\n" + objException.Message);
}
}

public bool DelRecordBySP(string strAcademyId) 
{
try
{
bool bolResult = clsAcademyDA.DelRecordBySP(strAcademyId);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("ɾ����¼����!\r\n" + objException.Message);
}
}

public static bool DelAcademys(List<string> arrAcademyIdLst)
{
try
{
bool bolResult = clsAcademyDA.DelAcademy(arrAcademyIdLst);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("ɾ�����¼����!\r\n" + objException.Message);
}
}

public static int DelAcademysByCond(string strWhereCond)
{
try
{
int intRecNum = clsAcademyDA.DelAcademy(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
throw new Exception("ɾ�����¼����!\r\n" + objException.Message);
}
}

public static bool AddNewRecordBySql2(clsAcademyEN objAcademyEN)
{
clsAcademyDA objAcademyDA = new clsAcademyDA();
try
{
bool bolResult = objAcademyDA.AddNewRecordBySQL2(objAcademyEN);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("��Ӽ�¼����!\r\n" + objException.Message);
}
}

public static bool AddNewRecordBySql_XML(string strAcademyENObjXml)
{
clsAcademyEN objAcademyEN = GetAcademyFromXmlStr(strAcademyENObjXml);
clsAcademyDA objAcademyDA = new clsAcademyDA();
try
{
bool bolResult = objAcademyDA.AddNewRecordBySQL2(objAcademyEN);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("��Ӽ�¼����!\r\n" + objException.Message);
}
}

public static bool UpdateBySql2(clsAcademyEN objAcademyEN)
{
clsAcademyDA objAcademyDA = new clsAcademyDA();
try
{
bool bolResult = objAcademyDA.UpdateBySql2(objAcademyEN);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("��Ӽ�¼����!\r\n" + objException.Message);
}
}

public static bool UpdateBySql_XML(string strAcademyENObjXml)
{
clsAcademyEN objAcademyEN = GetAcademyFromXmlStr(strAcademyENObjXml);
clsAcademyDA objAcademyDA = new clsAcademyDA();
try
{
bool bolResult = objAcademyDA.UpdateBySql2(objAcademyEN);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("��Ӽ�¼����!\r\n" + objException.Message);
}
}

public static bool IsExistRecord(string strCondition)
{
//����¼�Ƿ����
bool bolIsExist = clsAcademyDA.IsExistCondRec(strCondition);
return bolIsExist;
}

public static bool IsExist(string strAcademyId)
{
//����¼�Ƿ����
bool bolIsExist = clsAcademyDA.IsExist(strAcademyId);
return bolIsExist;
}

/// <summary>
/// ���Ψһ��(Uniqueness)--ѧԺ����(AcademyName)
/// </summary>
/// <param name="strAcademyId">ѧԺID(����)</param>
/// <param name="strAcademyName">ѧԺ����(Ҫ��Ψһ���ֶ�)</param>
/// <returns></returns>
public static bool CheckAcademyNameUniqueness(clsAcademyEN objAcademyEN)
{
//����¼�Ƿ����
bool bolIsUniqueness;
if (objAcademyEN == null) return true;
if (objAcademyEN.AcademyId == null || objAcademyEN.AcademyId == "")
{
bolIsUniqueness = clsAcademyDA.CheckAcademyNameUniqueness(
objAcademyEN.AcademyName);
}
else
{
bolIsUniqueness = clsAcademyDA.CheckAcademyNameUniqueness(
objAcademyEN.AcademyId, objAcademyEN.AcademyName);
}
return bolIsUniqueness;
}

/// <summary>
/// ����ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.
/// </summary>
public static void CheckPropertyNew(clsAcademyEN objAcademyEN)
{
  clsAcademyDA.CheckPropertyNew(objAcademyEN);
 }

/// <summary>
/// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
/// </summary>
/// <param name="strAcademyId">�����Ĺؼ���</param>
/// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>
public static clsAcademyEN GetAcademyObjByAcademyId(string strAcademyId)
{
if (arrAcademyObjLst == null)
{
arrAcademyObjLst = new clsAcademyDA().GetAcademyObjList("1=1");
}
foreach (clsAcademyEN objAcademyEN in arrAcademyObjLst)
{
if (objAcademyEN.AcademyId == strAcademyId)
{
return objAcademyEN;
}
}
return null;
}


/// <summary>
/// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
/// </summary>
/// <param name="strAcademyId">�����Ĺؼ���</param>
/// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>
public static clsAcademyEN GetAcademyObjByAcademyIdFromList(string strAcademyId, List<clsAcademyEN> lstAcademyObjList)
{
foreach (clsAcademyEN objAcademyEN in lstAcademyObjList)
{
if (objAcademyEN.AcademyId == strAcademyId)
{
return objAcademyEN;
}
}
return null;
}

/// <summary>
/// ���л�һ�������б�Xml�ļ�
/// ����:���Է�
/// ����:2012/11/20
/// </summary>
/// <param name="lstAcademyObjList">��Ҫ���л��Ķ����б�</param>
/// <param name="strXmlFile">���ɵ�XML�ļ�</param>
/// <returns>����һ��<clsAcademyEN>�����б�XML��</returns>
public static string SerializeObjListToXMLStr(List<clsAcademyEN> lstAcademyObjList)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings();
settings.Indent = true;
settings.IndentChars = ("  ");
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjListToXML(lstAcademyObjList, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

/// <summary>
/// ���л�һ�������б�Xml�ļ�
/// ����:���Է�
/// ����:2012/11/20
/// </summary>
/// <param name="lstAcademyObjList">��Ҫ���л��Ķ����б�</param>
/// <param name="strXmlFile">���ɵ�XML�ļ�</param>
public static void SerializeObjListToXMLFile(List<clsAcademyEN> lstAcademyObjList, string strXmlFile)
{
XmlWriterSettings settings = new XmlWriterSettings();
settings.Indent = true;
settings.IndentChars = ("  ");
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjListToXML(lstAcademyObjList, writer);
}
}

/// <summary>
/// ���л�һ�������б�XmlWriter
/// ����:���Է�
/// ����:2012/11/20
/// </summary>
/// <param name="strXmlFileName">�ṩ��һ��XML�ļ�</param>
/// <returns>����һ��<clsAcademyEN>�����б�</returns>
public static bool SerializeObjListToXML(List<clsAcademyEN> lstAcademyObjList, XmlWriter writer)
{
writer.WriteStartElement(clsAcademyBL.listXmlNode);
writer.WriteStartElement(clsAcademyBL.itemsXmlNode);
foreach (clsAcademyEN objAcademyEN in lstAcademyObjList)
{
clsAcademyBL.SerializeXML(writer, objAcademyEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

/// <summary>
/// ��һ���������л���XML��
/// ����:���Է�
/// ����:2012/11/20
/// </summary>
/// <param name="writer">Ŀ��:���л�����XmlWriter</param>
/// <param name="objAcademyEN">����Դ:��Ҫ���л��Ķ���</param>
public static void SerializeXML(XmlWriter writer, clsAcademyEN objAcademyEN)
{
writer.WriteStartElement(clsAcademyBL.itemXmlNode);
writer.WriteElementString("AcademyId", objAcademyEN.AcademyId.ToString(CultureInfo.InvariantCulture));
writer.WriteElementString("AcademyName", objAcademyEN.AcademyName.ToString(CultureInfo.InvariantCulture));
writer.WriteElementString("Memo", objAcademyEN.Memo.ToString(CultureInfo.InvariantCulture));
writer.WriteEndElement();
}

/// <summary>
/// ��XML���л�ȡһ�������б�
/// ����:���Է�
/// ����:2012/11/20
/// </summary>
/// <param name="strAcademylistXml">�ṩ��һ��XML��</param>
/// <returns>����һ��<clsAcademyEN>�����б�</returns>
public static List<clsAcademyEN> GetAcademyObjListFromXmlStr(string strAcademylistXml)
{
List<clsAcademyEN> lstAcademyObj = new List<clsAcademyEN>();
clsAcademyEN objAcademyEN;
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strAcademylistXml)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings();
xmlrs.IgnoreComments = true;
xmlrs.IgnoreWhitespace = true;
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsAcademyBL.itemXmlNode))
{
objAcademyEN = GetAcademyFromXml(reader);
lstAcademyObj.Add(objAcademyEN);
}
}
return lstAcademyObj;
}

/// <summary>
/// ��XML�ļ��л�ȡһ�������б�
/// ����:���Է�
/// ����:2012/11/20
/// </summary>
/// <param name="strXmlFileName">�ṩ��һ��XML�ļ�</param>
/// <returns>����һ��<clsAcademyEN>�����б�</returns>
public static List<clsAcademyEN> GetAcademyObjListFromXmlFile(string strXmlFileName)
{
List<clsAcademyEN> lstAcademyObj = new List<clsAcademyEN>();
clsAcademyEN objAcademyEN;
XmlReader reader = XmlReader.Create(strXmlFileName);
while (reader.ReadToFollowing(clsAcademyBL.itemXmlNode))
{
objAcademyEN = GetAcademyFromXml(reader);
lstAcademyObj.Add(objAcademyEN);
}
return lstAcademyObj;
}

/// <summary>
/// ��XmlReader��һ������
/// ����:���Է�
/// ����:2012/11/20
/// </summary>
/// <param name="reader">�ṩ������Դ:XmlReader</param>
/// <returns>���ص�һ������</returns>
public static clsAcademyEN GetAcademyFromXml(System.Xml.XmlReader reader)
{
clsAcademyEN objAcademyEN = new clsAcademyEN();
reader.Read();
 while (!(reader.Name == clsAcademyBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement("AcademyId"))
{
objAcademyEN.AcademyId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement("AcademyName"))
{
objAcademyEN.AcademyName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement("Memo"))
{
objAcademyEN.Memo = reader.ReadElementContentAsString();
}
}
return objAcademyEN;
}

/// <summary>
/// ��Xml�ַ�����һ������
/// ����:���Է�
/// ����:2010/10/04
/// </summary>
/// <param name="strAcademyObjXmlStr">�ṩ������Դ:��ʾһ�������XML��</param>
/// <returns>���ص�һ������</returns>
public static clsAcademyEN GetAcademyFromXmlStr(string strAcademyObjXmlStr)
{
clsAcademyEN objAcademyEN = new clsAcademyEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strAcademyObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings();
xmlrs.IgnoreComments = true;
xmlrs.IgnoreWhitespace = true;
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsAcademyBL.itemXmlNode))
{
objAcademyEN = GetAcademyFromXml(reader);
return objAcademyEN;
}
}
return objAcademyEN;
}

/// <summary>
/// ���л�һ������Xml�ļ�
/// ����:���Է�
/// ����:2012/11/20
/// </summary>
/// <param name="objAcademyEN">��Ҫ���л��Ķ���</param>
/// <returns>����һ��<clsAcademyEN>����XML��</returns>
public static string SerializeObjToXMLStr(clsAcademyEN objAcademyEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings();
settings.Indent = true;
settings.IndentChars = ("  ");
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objAcademyEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}
}
}