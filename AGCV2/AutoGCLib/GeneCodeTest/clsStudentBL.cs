
///----------------------
///���ɴ���汾:2013.04.17.1
///��������:2013/10/21
///������:���Է�
///��������:AGC_CSV7
///����ID:0005
///ģ��������:���ɴ������
///ģ��Ӣ����:GeneCodeTest
///ע��:1����Ҫ���ݵײ�(PubDataBase.dll)�İ汾:2013.06.20.1
///       2����Ҫ����������(TzPubFunction.dll)�İ汾:2013.04.25.2
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
/// ѧ��������Ϣ(Student)
/// ����Դ����:SQL��
/// </summary>
public class clsStudentBL
{
 /// <summary>
/// �����XML����ǩ
/// </summary>
public const string itemXmlNode = "StudentListItem";
/// <summary>
/// �б��XML����ǩ
/// </summary>
public const string listXmlNode = "StudentList";
/// <summary>
/// ���ϵ�XML����ǩ
/// </summary>
public const string itemsXmlNode = "Items";
public static List<clsStudentEN> arrStudentObjLst_Cache = null;

 public clsStudentBL()
 {
 }



public static void CopyTo(clsStudentEN objStudentENS, clsStudentEN objStudentENT)
{
clsStudentDA objStudentDA = new clsStudentDA();
try
{
objStudentDA.CopyTo(objStudentENS, objStudentENT);
}
catch (Exception objException)
{
throw new Exception("Copy��:Student ���ݳ���!"+ objException.Message);
}
}

/// <summary>
/// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����
/// </summary>
/// <param name="strWhereCond">������</param>
/// <returns></returns>
public static DataTable GetDataTable_Student(string strWhereCond)
{
 DataTable objDT = null;
try
{
objDT = clsStudentDA.GetStudent(strWhereCond);
return objDT;
}
catch (Exception objException)
{
throw new Exception("��ȡ��:Student ���ݳ���!\r\n" + objException.Message);
}
}
/// <summary>
/// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ�����ų�һЩ�ؼ��ֲ����
/// </summary>
/// <param name="strWhereCond">������</param>
  /// <param name="lstExclude">�ų��ļ���ַ����б�</param>
/// <returns></returns>
public static DataTable GetDataTable_Student(string strWhereCond, List<string> lstExclude)
{
 DataTable objDT = null;
try
{
objDT = clsStudentDA.GetStudent(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
throw new Exception("��ȡ��:Student ���ݳ���!\r\n" + objException.Message);
}
}
/// <summary>
/// ����������ȡ���ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����
/// </summary>
/// <param name="strWhereCond">������</param>
/// <param name="bolIsCheckSQLAttack">�Ƿ���SQL����</param>
/// <returns></returns>
public static DataTable GetDataTable_Student(string strWhereCond, bool bolIsCheckSQLAttack)
{
 DataTable objDT = null;
try
{
objDT = clsStudentDA.GetStudent(strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
throw new Exception("��ȡ��:Student ���ݳ���!\r\n" + objException.Message);
}
}

/// <summary>
/// ����������ȡ���ݱ����ͼ,��DataTable��ʾ
/// </summary>
/// <param name="strWhereCond">������</param>
/// <returns></returns>
public static DataTable GetDataTable_StudentV(string strWhereCond)
{
DataTable objDT = null;
try
{
objDT = clsStudentDA.GetStudentV(strWhereCond);
return objDT;
}
catch (Exception objException)
{
throw new Exception("��ȡ��:Student View ���ݳ���!\r\n" + objException.Message);
}
}
/// <summary>
/// ����������ȡ���ݱ����ͼ,��DataTable��ʾ,ͬʱ�����ų�һЩ�ؼ��ֲ����
/// </summary>
/// <param name="strWhereCond">������</param>
  /// <param name="lstExclude">�ų��ļ���ַ����б�</param>
/// <returns></returns>
public static DataTable GetDataTable_StudentV(string strWhereCond, List<string> lstExclude)
{
DataTable objDT = null;
try
{
objDT = clsStudentDA.GetStudentV(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
throw new Exception("��ȡ��:Student View ���ݳ���!\r\n" + objException.Message);
}
}

public static System.Data.DataSet GetDataSet_Student(string strCondition)
{
 DataSet objDS = null;
try
{
objDS = clsStudentDA.GetDataSet_Student(strCondition);
return objDS;
}
catch (Exception objException)
{
throw new Exception("��ȡ��:Student ���ݳ���!\r\n" + objException.Message);
}
}

public static System.Data.DataSet GetDataSet_StudentV(string strCondition)
{
 DataSet objDS = null;
try
{
objDS = clsStudentDA.GetDataSet_StudentV(strCondition);
return objDS;
}
catch (Exception objException)
{
throw new Exception("��ȡ��:Student ��ͼ���ݳ���!\r\n" + objException.Message);
}
}

public static bool GetStudent(ref clsStudentEN objStudentEN)
{
clsStudentDA objStudentDA = new clsStudentDA();
bool bolResult = objStudentDA.GetStudent(ref objStudentEN);
return bolResult;
}

public static clsStudentEN GetStudentByStdId(string strStdId)
{
clsStudentEN objStudentEN = clsStudentDA.GetStudentByStdId(strStdId);
return objStudentEN;
}

/// <summary>
/// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ
/// </summary>
/// <param name="strCondition">������</param>
/// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>
public static string GetFirstID_S(string strCondition ) 
{
 string strStdId;
 try
 {
 strStdId = clsStudentDA.GetFirstID_S(strCondition);
 return strStdId;
 }
 catch (Exception objException)
 {
 throw new Exception("��ȡFirst�ؼ��ֳ���!\r\n" + objException.Message);
 }
}

/// <summary>
/// ��ȡ��ǰ�����������Ĺؼ���ֵ�б�
/// </summary>
/// <param name="strCondition">������</param>
/// <returns>�������������Ĺؼ����б�ֵ</returns>
public static List<string> GetPrimaryKeyID_S(string strCondition ) 
{
  List<string> arrList = new List<string>();
 try
 {
 arrList = new clsStudentDA().GetID(strCondition);
 return arrList;
 }
 catch (Exception objException)
 {
 throw new Exception("��ȡ�ؼ����б����!\r\n" + objException.Message);
 }
}

/// <summary>
/// ��ȡ��ǰ�����������ĵ�һ����¼�Ķ���
/// </summary>
/// <param name="strCondition">������</param>
/// <returns>���صĵ�һ����¼�Ķ���</returns>
public static clsStudentEN GetFirstStudent_S(string strCondition ) 
{
 try
 {
 clsStudentEN objStudentEN = new clsStudentDA().GetFirstStudent(strCondition);
 return objStudentEN;
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
 string strMaxStdId;
 try
 {
 strMaxStdId = clsStudentDA.GetMaxStrId();
 return strMaxStdId;
 }
 catch (Exception objException)
 {
 throw new Exception("��ȡFirst�ؼ��ֳ���!\r\n" + objException.Message);
 }
}

public static List<clsStudentEN> GetStudentObjList(string strCondition)
{
List<clsStudentEN> arrObjList = new List<clsStudentEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_Student(strCondition);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentEN objStudentEN = new clsStudentEN();
objStudentEN.StdId = objRow["StdId"].ToString().Trim(); //ѧ��
objStudentEN.StdName = objRow["StdName"].ToString().Trim(); //ѧ������
objStudentEN.Age = Int32.Parse(objRow["Age"].ToString().Trim()); //����
objStudentEN.Doublegrade = com.taishsoft.comm_db_obj.clsEntityBase2.TransNullToDouble_S(objRow["Doublegrade"].ToString().Trim()); //����
objStudentEN.AcademyId = objRow["AcademyId"].ToString().Trim(); //ѧԺID
objStudentEN.Sex = objRow["Sex"].ToString().Trim(); //�Ա�
	arrObjList.Add(objStudentEN);
	}
objDT = null;
return arrObjList;
}
public static List<clsStudentEN> GetStudentObjList(string strCondition, List<string> lstExclude)
{
List<clsStudentEN> arrObjList = new List<clsStudentEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_Student(strCondition, lstExclude);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentEN objStudentEN = new clsStudentEN();
objStudentEN.StdId = objRow["StdId"].ToString().Trim(); //ѧ��
objStudentEN.StdName = objRow["StdName"].ToString().Trim(); //ѧ������
objStudentEN.Age = Int32.Parse(objRow["Age"].ToString().Trim()); //����
objStudentEN.Doublegrade = com.taishsoft.comm_db_obj.clsEntityBase2.TransNullToDouble_S(objRow["Doublegrade"].ToString().Trim()); //����
objStudentEN.AcademyId = objRow["AcademyId"].ToString().Trim(); //ѧԺID
objStudentEN.Sex = objRow["Sex"].ToString().Trim(); //�Ա�
	arrObjList.Add(objStudentEN);
	}
objDT = null;
return arrObjList;
}

public static List<clsStudentEN> StudentList(string strCondition)
{
List<clsStudentEN> arrObjList = new List<clsStudentEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_Student(strCondition);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentEN objStudentEN = new clsStudentEN();
objStudentEN.StdId = objRow["StdId"].ToString().Trim(); //ѧ��
objStudentEN.StdName = objRow["StdName"].ToString().Trim(); //ѧ������
objStudentEN.Age = Int32.Parse(objRow["Age"].ToString().Trim()); //����
objStudentEN.Doublegrade = com.taishsoft.comm_db_obj.clsEntityBase2.TransNullToDouble_S(objRow["Doublegrade"].ToString().Trim()); //����
objStudentEN.AcademyId = objRow["AcademyId"].ToString().Trim(); //ѧԺID
objStudentEN.Sex = objRow["Sex"].ToString().Trim(); //�Ա�
	arrObjList.Add(objStudentEN);
	}
objDT = null;
return arrObjList;
}

public static bool DelRecord(string strStdId)
{
try
{
bool bolResult = clsStudentDA.DelRecord(strStdId);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("ɾ����¼����!\r\n" + objException.Message);
}
}

public bool DelRecordBySP(string strStdId) 
{
try
{
bool bolResult = clsStudentDA.DelRecordBySP(strStdId);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("ɾ����¼����!\r\n" + objException.Message);
}
}

public static bool DelStudents(List<string> arrStdIdLst)
{
try
{
bool bolResult = clsStudentDA.DelStudent(arrStdIdLst);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("ɾ�����¼����!\r\n" + objException.Message);
}
}

public static int DelStudentsByCond(string strWhereCond)
{
try
{
int intRecNum = clsStudentDA.DelStudent(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
throw new Exception("ɾ�����¼����!\r\n" + objException.Message);
}
}

public static bool AddNewRecordBySql2(clsStudentEN objStudentEN)
{
clsStudentDA objStudentDA = new clsStudentDA();
try
{
bool bolResult = objStudentDA.AddNewRecordBySQL2(objStudentEN);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("��Ӽ�¼����!\r\n" + objException.Message);
}
}

public static string AddNewRecordBySql2WithReturnKey(clsStudentEN objStudentEN)
{
clsStudentDA objStudentDA = new clsStudentDA();
try
{
string strKey = objStudentDA.AddNewRecordBySQL2WithReturnKey(objStudentEN);
return strKey;
}
catch (Exception objException)
{
throw new Exception("��Ӽ�¼����!\r\n" + objException.Message);
}
}

public static bool AddNewRecordBySql_XML(string strStudentENObjXml)
{
clsStudentEN objStudentEN = GetStudentFromXmlStr(strStudentENObjXml);
clsStudentDA objStudentDA = new clsStudentDA();
try
{
bool bolResult = objStudentDA.AddNewRecordBySQL2(objStudentEN);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("��Ӽ�¼����!\r\n" + objException.Message);
}
}

public static bool UpdateBySql2(clsStudentEN objStudentEN)
{
clsStudentDA objStudentDA = new clsStudentDA();
try
{
bool bolResult = objStudentDA.UpdateBySql2(objStudentEN);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("��Ӽ�¼����!\r\n" + objException.Message);
}
}

public static bool UpdateBySqlWithCondition(clsStudentEN objStudentEN, string strCondition)
{
clsStudentDA objStudentDA = new clsStudentDA();
try
{
bool bolResult = objStudentDA.UpdateBySqlWithCondition(objStudentEN, strCondition);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("��Ӽ�¼����!\r\n" + objException.Message);
}
}

public static bool UpdateBySql_XML(string strStudentENObjXml)
{
clsStudentEN objStudentEN = GetStudentFromXmlStr(strStudentENObjXml);
clsStudentDA objStudentDA = new clsStudentDA();
try
{
bool bolResult = objStudentDA.UpdateBySql2(objStudentEN);
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
bool bolIsExist = clsStudentDA.IsExistCondRec(strCondition);
return bolIsExist;
}

public static bool IsExist(string strStdId)
{
//����¼�Ƿ����
bool bolIsExist = clsStudentDA.IsExist(strStdId);
return bolIsExist;
}

/// <summary>
/// ���Ψһ��(Uniqueness)--ѧ������(StdName)
/// </summary>
/// <param name="strStdId">ѧ��(����)</param>
/// <param name="strStdName">ѧ������(Ҫ��Ψһ���ֶ�)</param>
/// <returns></returns>
public static bool CheckStdNameUniqueness(clsStudentEN objStudentEN)
{
//����¼�Ƿ����
bool bolIsUniqueness;
if (objStudentEN == null) return true;
if (objStudentEN.StdId == null || objStudentEN.StdId == "")
{
bolIsUniqueness = clsStudentDA.CheckStdNameUniqueness(
objStudentEN.StdName);
}
else
{
bolIsUniqueness = clsStudentDA.CheckStdNameUniqueness(
objStudentEN.StdId, objStudentEN.StdName);
}
return bolIsUniqueness;
}
/// <summary>
/// ���Ψһ��(Uniqueness)--����(Age)
/// </summary>
/// <param name="strStdId">ѧ��(����)</param>
/// <param name="intAge">����(Ҫ��Ψһ���ֶ�)</param>
/// <returns></returns>
public static bool CheckAgeUniqueness(clsStudentEN objStudentEN)
{
//����¼�Ƿ����
bool bolIsUniqueness;
if (objStudentEN == null) return true;
if (objStudentEN.StdId == null || objStudentEN.StdId == "")
{
bolIsUniqueness = clsStudentDA.CheckAgeUniqueness(
objStudentEN.Age);
}
else
{
bolIsUniqueness = clsStudentDA.CheckAgeUniqueness(
objStudentEN.StdId, objStudentEN.Age);
}
return bolIsUniqueness;
}

/// <summary>
/// ����ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.
/// </summary>
public static void CheckPropertyNew(clsStudentEN objStudentEN)
{
  clsStudentDA.CheckPropertyNew(objStudentEN);
 }

/// <summary>
/// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
/// </summary>
/// <param name="strStdId">�����Ĺؼ���</param>
/// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>
public static clsStudentEN GetStudentObjByStdId_Cache(string strStdId)
{
if (arrStudentObjLst_Cache == null)
{
arrStudentObjLst_Cache = new clsStudentDA().GetStudentObjList("1=1");
}
foreach (clsStudentEN objStudentEN in arrStudentObjLst_Cache)
{
if (objStudentEN.StdId == strStdId)
{
return objStudentEN;
}
}
return null;
}


/// <summary>
/// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
/// </summary>
/// <param name="strStdId">�����Ĺؼ���</param>
/// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>
public static clsStudentEN GetStudentObjByStdIdFromList(string strStdId, List<clsStudentEN> lstStudentObjList)
{
foreach (clsStudentEN objStudentEN in lstStudentObjList)
{
if (objStudentEN.StdId == strStdId)
{
return objStudentEN;
}
}
return null;
}

/// <summary>
/// ���л�һ�������б�Xml�ļ�
/// ����:���Է�
/// ����:2013/10/21
/// </summary>
/// <param name="lstStudentObjList">��Ҫ���л��Ķ����б�</param>
/// <param name="strXmlFile">���ɵ�XML�ļ�</param>
/// <returns>����һ��<clsStudentEN>�����б�XML��</returns>
public static string SerializeObjListToXMLStr(List<clsStudentEN> lstStudentObjList)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings();
settings.Indent = true;
settings.IndentChars = ("  ");
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjListToXML(lstStudentObjList, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

/// <summary>
/// ���л�һ�������б�Xml�ļ�
/// ����:���Է�
/// ����:2013/10/21
/// </summary>
/// <param name="lstStudentObjList">��Ҫ���л��Ķ����б�</param>
/// <param name="strXmlFile">���ɵ�XML�ļ�</param>
public static void SerializeObjListToXMLFile(List<clsStudentEN> lstStudentObjList, string strXmlFile)
{
XmlWriterSettings settings = new XmlWriterSettings();
settings.Indent = true;
settings.IndentChars = ("  ");
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjListToXML(lstStudentObjList, writer);
}
}

/// <summary>
/// ���л�һ�������б�XmlWriter
/// ����:���Է�
/// ����:2013/10/21
/// </summary>
/// <param name="strXmlFileName">�ṩ��һ��XML�ļ�</param>
/// <returns>����һ��<clsStudentEN>�����б�</returns>
public static bool SerializeObjListToXML(List<clsStudentEN> lstStudentObjList, XmlWriter writer)
{
writer.WriteStartElement(clsStudentBL.listXmlNode);
writer.WriteStartElement(clsStudentBL.itemsXmlNode);
foreach (clsStudentEN objStudentEN in lstStudentObjList)
{
clsStudentBL.SerializeXML(writer, objStudentEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

/// <summary>
/// ��һ���������л���XML��
/// ����:���Է�
/// ����:2013/10/21
/// </summary>
/// <param name="writer">Ŀ��:���л�����XmlWriter</param>
/// <param name="objStudentEN">����Դ:��Ҫ���л��Ķ���</param>
public static void SerializeXML(XmlWriter writer, clsStudentEN objStudentEN)
{
writer.WriteStartElement(clsStudentBL.itemXmlNode);
writer.WriteElementString("StdId", objStudentEN.StdId.ToString(CultureInfo.InvariantCulture));
writer.WriteElementString("StdName", objStudentEN.StdName.ToString(CultureInfo.InvariantCulture));
writer.WriteElementString("Age", objStudentEN.Age.ToString(CultureInfo.InvariantCulture));
writer.WriteElementString("Doublegrade", objStudentEN.Doublegrade.ToString(CultureInfo.InvariantCulture));
writer.WriteElementString("AcademyId", objStudentEN.AcademyId.ToString(CultureInfo.InvariantCulture));
writer.WriteElementString("Sex", objStudentEN.Sex.ToString(CultureInfo.InvariantCulture));
writer.WriteEndElement();
}

/// <summary>
/// ��XML���л�ȡһ�������б�
/// ����:���Է�
/// ����:2013/10/21
/// </summary>
/// <param name="strStudentlistXml">�ṩ��һ��XML��</param>
/// <returns>����һ��<clsStudentEN>�����б�</returns>
public static List<clsStudentEN> GetStudentObjListFromXmlStr(string strStudentlistXml)
{
List<clsStudentEN> lstStudentObj = new List<clsStudentEN>();
clsStudentEN objStudentEN;
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strStudentlistXml)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings();
xmlrs.IgnoreComments = true;
xmlrs.IgnoreWhitespace = true;
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsStudentBL.itemXmlNode))
{
objStudentEN = GetStudentFromXml(reader);
lstStudentObj.Add(objStudentEN);
}
}
return lstStudentObj;
}

/// <summary>
/// ��XML�ļ��л�ȡһ�������б�
/// ����:���Է�
/// ����:2013/10/21
/// </summary>
/// <param name="strXmlFileName">�ṩ��һ��XML�ļ�</param>
/// <returns>����һ��<clsStudentEN>�����б�</returns>
public static List<clsStudentEN> GetStudentObjListFromXmlFile(string strXmlFileName)
{
List<clsStudentEN> lstStudentObj = new List<clsStudentEN>();
clsStudentEN objStudentEN;
XmlReader reader = XmlReader.Create(strXmlFileName);
while (reader.ReadToFollowing(clsStudentBL.itemXmlNode))
{
objStudentEN = GetStudentFromXml(reader);
lstStudentObj.Add(objStudentEN);
}
return lstStudentObj;
}

/// <summary>
/// ��XmlReader��һ������
/// ����:���Է�
/// ����:2013/10/21
/// </summary>
/// <param name="reader">�ṩ������Դ:XmlReader</param>
/// <returns>���ص�һ������</returns>
public static clsStudentEN GetStudentFromXml(System.Xml.XmlReader reader)
{
clsStudentEN objStudentEN = new clsStudentEN();
reader.Read();
 while (!(reader.Name == clsStudentBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement("StdId"))
{
objStudentEN.StdId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement("StdName"))
{
objStudentEN.StdName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement("Age"))
{
objStudentEN.Age = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement("Doublegrade"))
{
objStudentEN.Doublegrade = reader.ReadElementContentAsDouble();
}
if (reader.IsStartElement("AcademyId"))
{
objStudentEN.AcademyId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement("Sex"))
{
objStudentEN.Sex = reader.ReadElementContentAsString();
}
}
return objStudentEN;
}

/// <summary>
/// ��Xml�ַ�����һ������
/// ����:���Է�
/// ����:2010/10/04
/// </summary>
/// <param name="strStudentObjXmlStr">�ṩ������Դ:��ʾһ�������XML��</param>
/// <returns>���ص�һ������</returns>
public static clsStudentEN GetStudentFromXmlStr(string strStudentObjXmlStr)
{
clsStudentEN objStudentEN = new clsStudentEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strStudentObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings();
xmlrs.IgnoreComments = true;
xmlrs.IgnoreWhitespace = true;
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsStudentBL.itemXmlNode))
{
objStudentEN = GetStudentFromXml(reader);
return objStudentEN;
}
}
return objStudentEN;
}

/// <summary>
/// ���л�һ������Xml�ļ�
/// ����:���Է�
/// ����:2013/10/21
/// </summary>
/// <param name="objStudentEN">��Ҫ���л��Ķ���</param>
/// <returns>����һ��<clsStudentEN>����XML��</returns>
public static string SerializeObjToXMLStr(clsStudentEN objStudentEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings();
settings.Indent = true;
settings.IndentChars = ("  ");
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objStudentEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}
}
}