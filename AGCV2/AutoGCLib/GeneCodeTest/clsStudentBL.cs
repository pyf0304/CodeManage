
///----------------------
///生成代码版本:2013.04.17.1
///生成日期:2013/10/21
///生成者:潘以锋
///工程名称:AGC_CSV7
///工程ID:0005
///模块中文名:生成代码测试
///模块英文名:GeneCodeTest
///注意:1、需要数据底层(PubDataBase.dll)的版本:2013.06.20.1
///       2、需要公共函数层(TzPubFunction.dll)的版本:2013.04.25.2
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
/// 学生基本信息(Student)
/// 数据源类型:SQL表
/// </summary>
public class clsStudentBL
{
 /// <summary>
/// 单项的XML结点标签
/// </summary>
public const string itemXmlNode = "StudentListItem";
/// <summary>
/// 列表的XML结点标签
/// </summary>
public const string listXmlNode = "StudentList";
/// <summary>
/// 集合的XML结点标签
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
throw new Exception("Copy表:Student 数据出错!"+ objException.Message);
}
}

/// <summary>
/// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
/// </summary>
/// <param name="strWhereCond">条件串</param>
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
throw new Exception("获取表:Student 数据出错!\r\n" + objException.Message);
}
}
/// <summary>
/// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
/// </summary>
/// <param name="strWhereCond">条件串</param>
  /// <param name="lstExclude">排除的检查字符串列表</param>
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
throw new Exception("获取表:Student 数据出错!\r\n" + objException.Message);
}
}
/// <summary>
/// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
/// </summary>
/// <param name="strWhereCond">条件串</param>
/// <param name="bolIsCheckSQLAttack">是否检查SQL攻击</param>
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
throw new Exception("获取表:Student 数据出错!\r\n" + objException.Message);
}
}

/// <summary>
/// 根据条件获取数据表的视图,用DataTable表示
/// </summary>
/// <param name="strWhereCond">条件串</param>
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
throw new Exception("获取表:Student View 数据出错!\r\n" + objException.Message);
}
}
/// <summary>
/// 根据条件获取数据表的视图,用DataTable表示,同时可以排除一些关键字不检查
/// </summary>
/// <param name="strWhereCond">条件串</param>
  /// <param name="lstExclude">排除的检查字符串列表</param>
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
throw new Exception("获取表:Student View 数据出错!\r\n" + objException.Message);
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
throw new Exception("获取表:Student 数据出错!\r\n" + objException.Message);
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
throw new Exception("获取表:Student 视图数据出错!\r\n" + objException.Message);
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
/// 获取当前表满足条件的第一条记录的关键字值
/// </summary>
/// <param name="strCondition">条件串</param>
/// <returns>返回的第一条记录的关键字值</returns>
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
 throw new Exception("获取First关键字出错!\r\n" + objException.Message);
 }
}

/// <summary>
/// 获取当前表满足条件的关键字值列表
/// </summary>
/// <param name="strCondition">条件串</param>
/// <returns>返回满足条件的关键字列表值</returns>
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
 throw new Exception("获取关键字列表出错!\r\n" + objException.Message);
 }
}

/// <summary>
/// 获取当前表满足条件的第一条记录的对象
/// </summary>
/// <param name="strCondition">条件串</param>
/// <returns>返回的第一条记录的对象</returns>
public static clsStudentEN GetFirstStudent_S(string strCondition ) 
{
 try
 {
 clsStudentEN objStudentEN = new clsStudentDA().GetFirstStudent(strCondition);
 return objStudentEN;
 }
 catch (Exception objException)
 {
 throw new Exception("获取First记录对象出错!\r\n" + objException.Message);
 }
}

/// <summary>
/// 获取当前表满足条件的第一条记录的关键字值
/// </summary>
/// <param name="strCondition">条件串</param>
/// <returns>返回的第一条记录的关键字值</returns>
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
 throw new Exception("获取First关键字出错!\r\n" + objException.Message);
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
objStudentEN.StdId = objRow["StdId"].ToString().Trim(); //学号
objStudentEN.StdName = objRow["StdName"].ToString().Trim(); //学生姓名
objStudentEN.Age = Int32.Parse(objRow["Age"].ToString().Trim()); //年龄
objStudentEN.Doublegrade = com.taishsoft.comm_db_obj.clsEntityBase2.TransNullToDouble_S(objRow["Doublegrade"].ToString().Trim()); //分数
objStudentEN.AcademyId = objRow["AcademyId"].ToString().Trim(); //学院ID
objStudentEN.Sex = objRow["Sex"].ToString().Trim(); //性别
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
objStudentEN.StdId = objRow["StdId"].ToString().Trim(); //学号
objStudentEN.StdName = objRow["StdName"].ToString().Trim(); //学生姓名
objStudentEN.Age = Int32.Parse(objRow["Age"].ToString().Trim()); //年龄
objStudentEN.Doublegrade = com.taishsoft.comm_db_obj.clsEntityBase2.TransNullToDouble_S(objRow["Doublegrade"].ToString().Trim()); //分数
objStudentEN.AcademyId = objRow["AcademyId"].ToString().Trim(); //学院ID
objStudentEN.Sex = objRow["Sex"].ToString().Trim(); //性别
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
objStudentEN.StdId = objRow["StdId"].ToString().Trim(); //学号
objStudentEN.StdName = objRow["StdName"].ToString().Trim(); //学生姓名
objStudentEN.Age = Int32.Parse(objRow["Age"].ToString().Trim()); //年龄
objStudentEN.Doublegrade = com.taishsoft.comm_db_obj.clsEntityBase2.TransNullToDouble_S(objRow["Doublegrade"].ToString().Trim()); //分数
objStudentEN.AcademyId = objRow["AcademyId"].ToString().Trim(); //学院ID
objStudentEN.Sex = objRow["Sex"].ToString().Trim(); //性别
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
throw new Exception("删除记录出错!\r\n" + objException.Message);
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
throw new Exception("删除记录出错!\r\n" + objException.Message);
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
throw new Exception("删除多记录出错!\r\n" + objException.Message);
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
throw new Exception("删除多记录出错!\r\n" + objException.Message);
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
throw new Exception("添加记录出错!\r\n" + objException.Message);
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
throw new Exception("添加记录出错!\r\n" + objException.Message);
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
throw new Exception("添加记录出错!\r\n" + objException.Message);
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
throw new Exception("添加记录出错!\r\n" + objException.Message);
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
throw new Exception("添加记录出错!\r\n" + objException.Message);
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
throw new Exception("添加记录出错!\r\n" + objException.Message);
}
}

public static bool IsExistRecord(string strCondition)
{
//检测记录是否存在
bool bolIsExist = clsStudentDA.IsExistCondRec(strCondition);
return bolIsExist;
}

public static bool IsExist(string strStdId)
{
//检测记录是否存在
bool bolIsExist = clsStudentDA.IsExist(strStdId);
return bolIsExist;
}

/// <summary>
/// 检查唯一性(Uniqueness)--学生姓名(StdName)
/// </summary>
/// <param name="strStdId">学号(主键)</param>
/// <param name="strStdName">学生姓名(要求唯一的字段)</param>
/// <returns></returns>
public static bool CheckStdNameUniqueness(clsStudentEN objStudentEN)
{
//检测记录是否存在
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
/// 检查唯一性(Uniqueness)--年龄(Age)
/// </summary>
/// <param name="strStdId">学号(主键)</param>
/// <param name="intAge">年龄(要求唯一的字段)</param>
/// <returns></returns>
public static bool CheckAgeUniqueness(clsStudentEN objStudentEN)
{
//检测记录是否存在
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
/// 检查字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
/// </summary>
public static void CheckPropertyNew(clsStudentEN objStudentEN)
{
  clsStudentDA.CheckPropertyNew(objStudentEN);
 }

/// <summary>
/// 根据关键字获取相关对象, 从缓存的对象列表中获取.
/// </summary>
/// <param name="strStdId">所给的关键字</param>
/// <returns>根据关键字获取的对象</returns>
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
/// 根据关键字获取相关对象, 从缓存的对象列表中获取.
/// </summary>
/// <param name="strStdId">所给的关键字</param>
/// <returns>根据关键字获取的对象</returns>
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
/// 序列化一个对象列表到Xml文件
/// 作者:潘以锋
/// 日期:2013/10/21
/// </summary>
/// <param name="lstStudentObjList">需要序列化的对象列表</param>
/// <param name="strXmlFile">生成的XML文件</param>
/// <returns>返回一个<clsStudentEN>对象列表XML串</returns>
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
/// 序列化一个对象列表到Xml文件
/// 作者:潘以锋
/// 日期:2013/10/21
/// </summary>
/// <param name="lstStudentObjList">需要序列化的对象列表</param>
/// <param name="strXmlFile">生成的XML文件</param>
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
/// 序列化一个对象列表到XmlWriter
/// 作者:潘以锋
/// 日期:2013/10/21
/// </summary>
/// <param name="strXmlFileName">提供的一个XML文件</param>
/// <returns>返回一个<clsStudentEN>对象列表</returns>
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
/// 把一个对象序列化到XML中
/// 作者:潘以锋
/// 日期:2013/10/21
/// </summary>
/// <param name="writer">目标:序列化到的XmlWriter</param>
/// <param name="objStudentEN">数据源:需要序列化的对象</param>
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
/// 从XML串中获取一个对象列表
/// 作者:潘以锋
/// 日期:2013/10/21
/// </summary>
/// <param name="strStudentlistXml">提供的一个XML串</param>
/// <returns>返回一个<clsStudentEN>对象列表</returns>
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
/// 从XML文件中获取一个对象列表
/// 作者:潘以锋
/// 日期:2013/10/21
/// </summary>
/// <param name="strXmlFileName">提供的一个XML文件</param>
/// <returns>返回一个<clsStudentEN>对象列表</returns>
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
/// 读XmlReader到一个对象
/// 作者:潘以锋
/// 日期:2013/10/21
/// </summary>
/// <param name="reader">提供的数据源:XmlReader</param>
/// <returns>返回的一个对象</returns>
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
/// 读Xml字符串到一个对象
/// 作者:潘以锋
/// 日期:2010/10/04
/// </summary>
/// <param name="strStudentObjXmlStr">提供的数据源:表示一个对象的XML串</param>
/// <returns>返回的一个对象</returns>
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
/// 序列化一个对象到Xml文件
/// 作者:潘以锋
/// 日期:2013/10/21
/// </summary>
/// <param name="objStudentEN">需要序列化的对象</param>
/// <returns>返回一个<clsStudentEN>对象XML串</returns>
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