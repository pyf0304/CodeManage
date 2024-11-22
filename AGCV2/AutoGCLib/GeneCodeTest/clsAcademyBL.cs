
///----------------------
///生成代码版本:2012.11.9.1
///生成日期:2012/11/20
///生成者:潘以锋
///工程名称:AGC_CSV7
///工程ID:0005
///模块中文名:生成代码测试
///模块英文名:GeneCodeTest
///注意:1、需要数据底层(PubDataBase.dll)的版本:2012.10.20.1
///       2、需要公共函数层(TzPubFunction.dll)的版本:2012.10.23.1
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
/// 学院(Academy)
/// 数据源类型:SQL表
/// </summary>
public class clsAcademyBL
{
 /// <summary>
/// 单项的XML结点标签
/// </summary>
public const string itemXmlNode = "AcademyListItem";
/// <summary>
/// 列表的XML结点标签
/// </summary>
public const string listXmlNode = "AcademyList";
/// <summary>
/// 集合的XML结点标签
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
throw new Exception("Copy表:Academy 数据出错!"+ objException.Message);
}
}

/// <summary>
/// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
/// </summary>
/// <param name="strWhereCond">条件串</param>
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
throw new Exception("获取表:Academy 数据出错!\r\n" + objException.Message);
}
}
/// <summary>
/// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
/// </summary>
/// <param name="strWhereCond">条件串</param>
  /// <param name="lstExclude">排除的检查字符串列表</param>
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
throw new Exception("获取表:Academy 数据出错!\r\n" + objException.Message);
}
}
/// <summary>
/// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
/// </summary>
/// <param name="strWhereCond">条件串</param>
/// <param name="bolIsCheckSQLAttack">是否检查SQL攻击</param>
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
throw new Exception("获取表:Academy 数据出错!\r\n" + objException.Message);
}
}

/// <summary>
/// 根据条件获取数据表的视图,用DataTable表示
/// </summary>
/// <param name="strWhereCond">条件串</param>
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
throw new Exception("获取表:Academy View 数据出错!\r\n" + objException.Message);
}
}
/// <summary>
/// 根据条件获取数据表的视图,用DataTable表示,同时可以排除一些关键字不检查
/// </summary>
/// <param name="strWhereCond">条件串</param>
  /// <param name="lstExclude">排除的检查字符串列表</param>
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
throw new Exception("获取表:Academy View 数据出错!\r\n" + objException.Message);
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
throw new Exception("获取表:Academy 数据出错!\r\n" + objException.Message);
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
throw new Exception("获取表:Academy 视图数据出错!\r\n" + objException.Message);
}
}

public static bool GetAcademy(ref clsAcademyEN objAcademyEN)
{
clsAcademyDA objAcademyDA = new clsAcademyDA();
bool bolResult = objAcademyDA.GetAcademy(ref objAcademyEN);
return bolResult;
}

/// <summary>
/// 获取当前表满足条件的第一条记录的关键字值
/// </summary>
/// <param name="strCondition">条件串</param>
/// <returns>返回的第一条记录的关键字值</returns>
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
 throw new Exception("获取First关键字出错!\r\n" + objException.Message);
 }
}

/// <summary>
/// 获取当前表满足条件的第一条记录的对象
/// </summary>
/// <param name="strCondition">条件串</param>
/// <returns>返回的第一条记录的对象</returns>
public static clsAcademyEN GetFirstAcademy_S(string strCondition ) 
{
 try
 {
 clsAcademyEN objAcademyEN = new clsAcademyDA().GetFirstAcademy(strCondition);
 return objAcademyEN;
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
 string strMaxAcademyId;
 try
 {
 strMaxAcademyId = clsAcademyDA.GetMaxStrId();
 return strMaxAcademyId;
 }
 catch (Exception objException)
 {
 throw new Exception("获取First关键字出错!\r\n" + objException.Message);
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
objAcademyEN.AcademyId = objRow["AcademyId"].ToString().Trim(); //学院ID
objAcademyEN.AcademyName = objRow["AcademyName"].ToString().Trim(); //学院名称
objAcademyEN.Memo = objRow["Memo"].ToString().Trim(); //说明
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
objAcademyEN.AcademyId = objRow["AcademyId"].ToString().Trim(); //学院ID
objAcademyEN.AcademyName = objRow["AcademyName"].ToString().Trim(); //学院名称
objAcademyEN.Memo = objRow["Memo"].ToString().Trim(); //说明
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
objAcademyEN.AcademyId = objRow["AcademyId"].ToString().Trim(); //学院ID
objAcademyEN.AcademyName = objRow["AcademyName"].ToString().Trim(); //学院名称
objAcademyEN.Memo = objRow["Memo"].ToString().Trim(); //说明
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
throw new Exception("删除记录出错!\r\n" + objException.Message);
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
throw new Exception("删除记录出错!\r\n" + objException.Message);
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
throw new Exception("删除多记录出错!\r\n" + objException.Message);
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
throw new Exception("删除多记录出错!\r\n" + objException.Message);
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
throw new Exception("添加记录出错!\r\n" + objException.Message);
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
throw new Exception("添加记录出错!\r\n" + objException.Message);
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
throw new Exception("添加记录出错!\r\n" + objException.Message);
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
throw new Exception("添加记录出错!\r\n" + objException.Message);
}
}

public static bool IsExistRecord(string strCondition)
{
//检测记录是否存在
bool bolIsExist = clsAcademyDA.IsExistCondRec(strCondition);
return bolIsExist;
}

public static bool IsExist(string strAcademyId)
{
//检测记录是否存在
bool bolIsExist = clsAcademyDA.IsExist(strAcademyId);
return bolIsExist;
}

/// <summary>
/// 检查唯一性(Uniqueness)--学院名称(AcademyName)
/// </summary>
/// <param name="strAcademyId">学院ID(主键)</param>
/// <param name="strAcademyName">学院名称(要求唯一的字段)</param>
/// <returns></returns>
public static bool CheckAcademyNameUniqueness(clsAcademyEN objAcademyEN)
{
//检测记录是否存在
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
/// 检查字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
/// </summary>
public static void CheckPropertyNew(clsAcademyEN objAcademyEN)
{
  clsAcademyDA.CheckPropertyNew(objAcademyEN);
 }

/// <summary>
/// 根据关键字获取相关对象, 从缓存的对象列表中获取.
/// </summary>
/// <param name="strAcademyId">所给的关键字</param>
/// <returns>根据关键字获取的对象</returns>
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
/// 根据关键字获取相关对象, 从缓存的对象列表中获取.
/// </summary>
/// <param name="strAcademyId">所给的关键字</param>
/// <returns>根据关键字获取的对象</returns>
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
/// 序列化一个对象列表到Xml文件
/// 作者:潘以锋
/// 日期:2012/11/20
/// </summary>
/// <param name="lstAcademyObjList">需要序列化的对象列表</param>
/// <param name="strXmlFile">生成的XML文件</param>
/// <returns>返回一个<clsAcademyEN>对象列表XML串</returns>
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
/// 序列化一个对象列表到Xml文件
/// 作者:潘以锋
/// 日期:2012/11/20
/// </summary>
/// <param name="lstAcademyObjList">需要序列化的对象列表</param>
/// <param name="strXmlFile">生成的XML文件</param>
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
/// 序列化一个对象列表到XmlWriter
/// 作者:潘以锋
/// 日期:2012/11/20
/// </summary>
/// <param name="strXmlFileName">提供的一个XML文件</param>
/// <returns>返回一个<clsAcademyEN>对象列表</returns>
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
/// 把一个对象序列化到XML中
/// 作者:潘以锋
/// 日期:2012/11/20
/// </summary>
/// <param name="writer">目标:序列化到的XmlWriter</param>
/// <param name="objAcademyEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsAcademyEN objAcademyEN)
{
writer.WriteStartElement(clsAcademyBL.itemXmlNode);
writer.WriteElementString("AcademyId", objAcademyEN.AcademyId.ToString(CultureInfo.InvariantCulture));
writer.WriteElementString("AcademyName", objAcademyEN.AcademyName.ToString(CultureInfo.InvariantCulture));
writer.WriteElementString("Memo", objAcademyEN.Memo.ToString(CultureInfo.InvariantCulture));
writer.WriteEndElement();
}

/// <summary>
/// 从XML串中获取一个对象列表
/// 作者:潘以锋
/// 日期:2012/11/20
/// </summary>
/// <param name="strAcademylistXml">提供的一个XML串</param>
/// <returns>返回一个<clsAcademyEN>对象列表</returns>
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
/// 从XML文件中获取一个对象列表
/// 作者:潘以锋
/// 日期:2012/11/20
/// </summary>
/// <param name="strXmlFileName">提供的一个XML文件</param>
/// <returns>返回一个<clsAcademyEN>对象列表</returns>
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
/// 读XmlReader到一个对象
/// 作者:潘以锋
/// 日期:2012/11/20
/// </summary>
/// <param name="reader">提供的数据源:XmlReader</param>
/// <returns>返回的一个对象</returns>
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
/// 读Xml字符串到一个对象
/// 作者:潘以锋
/// 日期:2010/10/04
/// </summary>
/// <param name="strAcademyObjXmlStr">提供的数据源:表示一个对象的XML串</param>
/// <returns>返回的一个对象</returns>
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
/// 序列化一个对象到Xml文件
/// 作者:潘以锋
/// 日期:2012/11/20
/// </summary>
/// <param name="objAcademyEN">需要序列化的对象</param>
/// <returns>返回一个<clsAcademyEN>对象XML串</returns>
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