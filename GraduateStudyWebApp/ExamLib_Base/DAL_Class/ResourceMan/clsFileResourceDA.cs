﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFileResourceDA
 表名:FileResource(01120373)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:09:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理(ResourceMan)
 框架-层名:数据处理层(CS)(DALCode)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using ExamLib.Entity;

namespace ExamLib.DAL
{
 /// <summary>
 /// 文件资源(FileResource)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFileResourceDA : clsCommBase4DA
{
 /// <summary>
 /// 错误信息
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected const string EXCEPTION_MSG = "出错:"; //there was an error in the method. please see the Application Log for details.";
 /// <summary>
 /// 模块名称
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected string mstrModuleName;
//以下是属性变量

 /// <summary>
 /// 当前表名
 /// </summary>
 public override string _CurrTabName
 {
 get
 {
 return clsFileResourceEN._CurrTabName;
 }
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.DALCode4CSharp:Gen_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsFileResourceEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFileResourceEN._ConnectString);
}
return objSQL;
}


 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetSpecSQLObj_Obj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public override clsSpecSQLforSql GetSpecSQLObj_Obj() 
{
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
 if (string.IsNullOrEmpty(clsFileResourceEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFileResourceEN._ConnectString);
 }
 return objSQL;
 }


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFileResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from FileResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FileResource(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFileResourceDA: GetDataTable_FileResource)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from FileResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFileResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFileResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from FileResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFileResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)
{
 return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFileResourceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FileResource where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FileResource where {1} order by {2}", intTopSize, strCondition, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S_Exclude)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFileResourceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FileResource where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFileResourceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} FileResource.* from FileResource Left Join {1} on {2} where {3} and FileResource.FileResourceID not in (Select top {5} FileResource.FileResourceID from FileResource Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FileResource where {1} and FileResourceID not in (Select top {2} FileResourceID from FileResource where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FileResource where {1} and FileResourceID not in (Select top {3} FileResourceID from FileResource where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S_Exclude)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFileResourceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} FileResource.* from FileResource Left Join {1} on {2} where {3} and FileResource.FileResourceID not in (Select top {5} FileResource.FileResourceID from FileResource Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FileResource where {1} and FileResourceID not in (Select top {2} FileResourceID from FileResource where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FileResource where {1} and FileResourceID not in (Select top {3} FileResourceID from FileResource where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 #endregion 获取数据表的DataTable

 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsFileResourceEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFileResourceDA:GetObjLst)", objException.Message));
}
List<clsFileResourceEN> arrObjLst = new List<clsFileResourceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from FileResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileResourceEN objFileResourceEN = new clsFileResourceEN();
try
{
objFileResourceEN.FileResourceID = TransNullToInt(objRow[conFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objFileResourceEN.IpAddress = objRow[conFileResource.IpAddress] == DBNull.Value ? null : objRow[conFileResource.IpAddress].ToString().Trim(); //Ip地址
objFileResourceEN.FileDirName = objRow[conFileResource.FileDirName].ToString().Trim(); //文件目录名
objFileResourceEN.FileName = objRow[conFileResource.FileName].ToString().Trim(); //文件名称
objFileResourceEN.FileNameBak = objRow[conFileResource.FileNameBak] == DBNull.Value ? null : objRow[conFileResource.FileNameBak].ToString().Trim(); //FileName_Bak
objFileResourceEN.Extension = objRow[conFileResource.Extension] == DBNull.Value ? null : objRow[conFileResource.Extension].ToString().Trim(); //扩展名
objFileResourceEN.FileLength = objRow[conFileResource.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFileResource.FileLength].ToString().Trim()); //文件长度
objFileResourceEN.FileType = objRow[conFileResource.FileType] == DBNull.Value ? null : objRow[conFileResource.FileType].ToString().Trim(); //文件类型
objFileResourceEN.CreationTime = objRow[conFileResource.CreationTime] == DBNull.Value ? null : objRow[conFileResource.CreationTime].ToString().Trim(); //建立时间
objFileResourceEN.LastWriteTime = objRow[conFileResource.LastWriteTime] == DBNull.Value ? null : objRow[conFileResource.LastWriteTime].ToString().Trim(); //最后修改时间
objFileResourceEN.CheckDateTime = objRow[conFileResource.CheckDateTime] == DBNull.Value ? null : objRow[conFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFileResourceEN.IdFtpResource = objRow[conFileResource.IdFtpResource] == DBNull.Value ? null : objRow[conFileResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileResourceEN.InUse = TransNullToBool(objRow[conFileResource.InUse].ToString().Trim()); //是否在用
objFileResourceEN.IsExistFile = TransNullToBool(objRow[conFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objFileResourceEN.UpdDate = objRow[conFileResource.UpdDate] == DBNull.Value ? null : objRow[conFileResource.UpdDate].ToString().Trim(); //修改日期
objFileResourceEN.UpdUser = objRow[conFileResource.UpdUser] == DBNull.Value ? null : objRow[conFileResource.UpdUser].ToString().Trim(); //修改人
objFileResourceEN.Memo = objRow[conFileResource.Memo] == DBNull.Value ? null : objRow[conFileResource.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFileResourceDA: GetObjLst)", objException.Message));
}
objFileResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFileResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstByTabName)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回对象列表</returns>
public List<clsFileResourceEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFileResourceDA:GetObjLstByTabName)", objException.Message));
}
List<clsFileResourceEN> arrObjLst = new List<clsFileResourceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileResourceEN objFileResourceEN = new clsFileResourceEN();
try
{
objFileResourceEN.FileResourceID = TransNullToInt(objRow[conFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objFileResourceEN.IpAddress = objRow[conFileResource.IpAddress] == DBNull.Value ? null : objRow[conFileResource.IpAddress].ToString().Trim(); //Ip地址
objFileResourceEN.FileDirName = objRow[conFileResource.FileDirName].ToString().Trim(); //文件目录名
objFileResourceEN.FileName = objRow[conFileResource.FileName].ToString().Trim(); //文件名称
objFileResourceEN.FileNameBak = objRow[conFileResource.FileNameBak] == DBNull.Value ? null : objRow[conFileResource.FileNameBak].ToString().Trim(); //FileName_Bak
objFileResourceEN.Extension = objRow[conFileResource.Extension] == DBNull.Value ? null : objRow[conFileResource.Extension].ToString().Trim(); //扩展名
objFileResourceEN.FileLength = objRow[conFileResource.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFileResource.FileLength].ToString().Trim()); //文件长度
objFileResourceEN.FileType = objRow[conFileResource.FileType] == DBNull.Value ? null : objRow[conFileResource.FileType].ToString().Trim(); //文件类型
objFileResourceEN.CreationTime = objRow[conFileResource.CreationTime] == DBNull.Value ? null : objRow[conFileResource.CreationTime].ToString().Trim(); //建立时间
objFileResourceEN.LastWriteTime = objRow[conFileResource.LastWriteTime] == DBNull.Value ? null : objRow[conFileResource.LastWriteTime].ToString().Trim(); //最后修改时间
objFileResourceEN.CheckDateTime = objRow[conFileResource.CheckDateTime] == DBNull.Value ? null : objRow[conFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFileResourceEN.IdFtpResource = objRow[conFileResource.IdFtpResource] == DBNull.Value ? null : objRow[conFileResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileResourceEN.InUse = TransNullToBool(objRow[conFileResource.InUse].ToString().Trim()); //是否在用
objFileResourceEN.IsExistFile = TransNullToBool(objRow[conFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objFileResourceEN.UpdDate = objRow[conFileResource.UpdDate] == DBNull.Value ? null : objRow[conFileResource.UpdDate].ToString().Trim(); //修改日期
objFileResourceEN.UpdUser = objRow[conFileResource.UpdUser] == DBNull.Value ? null : objRow[conFileResource.UpdUser].ToString().Trim(); //修改人
objFileResourceEN.Memo = objRow[conFileResource.Memo] == DBNull.Value ? null : objRow[conFileResource.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFileResourceDA: GetObjLst)", objException.Message));
}
objFileResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFileResourceEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFileResourceEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFileResource(ref clsFileResourceEN objFileResourceEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from FileResource where FileResourceID = " + ""+ objFileResourceEN.FileResourceID+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFileResourceEN.FileResourceID = TransNullToInt(objDT.Rows[0][conFileResource.FileResourceID].ToString().Trim()); //FileResourceID(字段类型:bigint,字段长度:8,是否可空:False)
 objFileResourceEN.IpAddress = objDT.Rows[0][conFileResource.IpAddress].ToString().Trim(); //Ip地址(字段类型:varchar,字段长度:50,是否可空:True)
 objFileResourceEN.FileDirName = objDT.Rows[0][conFileResource.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objFileResourceEN.FileName = objDT.Rows[0][conFileResource.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objFileResourceEN.FileNameBak = objDT.Rows[0][conFileResource.FileNameBak].ToString().Trim(); //FileName_Bak(字段类型:varchar,字段长度:500,是否可空:True)
 objFileResourceEN.Extension = objDT.Rows[0][conFileResource.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:10,是否可空:True)
 objFileResourceEN.FileLength = TransNullToInt(objDT.Rows[0][conFileResource.FileLength].ToString().Trim()); //文件长度(字段类型:bigint,字段长度:8,是否可空:True)
 objFileResourceEN.FileType = objDT.Rows[0][conFileResource.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objFileResourceEN.CreationTime = objDT.Rows[0][conFileResource.CreationTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objFileResourceEN.LastWriteTime = objDT.Rows[0][conFileResource.LastWriteTime].ToString().Trim(); //最后修改时间(字段类型:varchar,字段长度:20,是否可空:True)
 objFileResourceEN.CheckDateTime = objDT.Rows[0][conFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime(字段类型:varchar,字段长度:30,是否可空:True)
 objFileResourceEN.IdFtpResource = objDT.Rows[0][conFileResource.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objFileResourceEN.InUse = TransNullToBool(objDT.Rows[0][conFileResource.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objFileResourceEN.IsExistFile = TransNullToBool(objDT.Rows[0][conFileResource.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objFileResourceEN.UpdDate = objDT.Rows[0][conFileResource.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFileResourceEN.UpdUser = objDT.Rows[0][conFileResource.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objFileResourceEN.Memo = objDT.Rows[0][conFileResource.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFileResourceDA: GetFileResource)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngFileResourceID">表关键字</param>
 /// <returns>表对象</returns>
public clsFileResourceEN GetObjByFileResourceID(long lngFileResourceID)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from FileResource where FileResourceID = " + ""+ lngFileResourceID+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFileResourceEN objFileResourceEN = new clsFileResourceEN();
try
{
 objFileResourceEN.FileResourceID = Int32.Parse(objRow[conFileResource.FileResourceID].ToString().Trim()); //FileResourceID(字段类型:bigint,字段长度:8,是否可空:False)
 objFileResourceEN.IpAddress = objRow[conFileResource.IpAddress] == DBNull.Value ? null : objRow[conFileResource.IpAddress].ToString().Trim(); //Ip地址(字段类型:varchar,字段长度:50,是否可空:True)
 objFileResourceEN.FileDirName = objRow[conFileResource.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objFileResourceEN.FileName = objRow[conFileResource.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objFileResourceEN.FileNameBak = objRow[conFileResource.FileNameBak] == DBNull.Value ? null : objRow[conFileResource.FileNameBak].ToString().Trim(); //FileName_Bak(字段类型:varchar,字段长度:500,是否可空:True)
 objFileResourceEN.Extension = objRow[conFileResource.Extension] == DBNull.Value ? null : objRow[conFileResource.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:10,是否可空:True)
 objFileResourceEN.FileLength = objRow[conFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileResource.FileLength].ToString().Trim()); //文件长度(字段类型:bigint,字段长度:8,是否可空:True)
 objFileResourceEN.FileType = objRow[conFileResource.FileType] == DBNull.Value ? null : objRow[conFileResource.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objFileResourceEN.CreationTime = objRow[conFileResource.CreationTime] == DBNull.Value ? null : objRow[conFileResource.CreationTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objFileResourceEN.LastWriteTime = objRow[conFileResource.LastWriteTime] == DBNull.Value ? null : objRow[conFileResource.LastWriteTime].ToString().Trim(); //最后修改时间(字段类型:varchar,字段长度:20,是否可空:True)
 objFileResourceEN.CheckDateTime = objRow[conFileResource.CheckDateTime] == DBNull.Value ? null : objRow[conFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime(字段类型:varchar,字段长度:30,是否可空:True)
 objFileResourceEN.IdFtpResource = objRow[conFileResource.IdFtpResource] == DBNull.Value ? null : objRow[conFileResource.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objFileResourceEN.UpdDate = objRow[conFileResource.UpdDate] == DBNull.Value ? null : objRow[conFileResource.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFileResourceEN.UpdUser = objRow[conFileResource.UpdUser] == DBNull.Value ? null : objRow[conFileResource.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objFileResourceEN.Memo = objRow[conFileResource.Memo] == DBNull.Value ? null : objRow[conFileResource.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFileResourceDA: GetObjByFileResourceID)", objException.Message));
}
return objFileResourceEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFileResourceEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFileResourceDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from FileResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFileResourceEN objFileResourceEN = new clsFileResourceEN()
{
FileResourceID = TransNullToInt(objRow[conFileResource.FileResourceID].ToString().Trim()), //FileResourceID
IpAddress = objRow[conFileResource.IpAddress] == DBNull.Value ? null : objRow[conFileResource.IpAddress].ToString().Trim(), //Ip地址
FileDirName = objRow[conFileResource.FileDirName].ToString().Trim(), //文件目录名
FileName = objRow[conFileResource.FileName].ToString().Trim(), //文件名称
FileNameBak = objRow[conFileResource.FileNameBak] == DBNull.Value ? null : objRow[conFileResource.FileNameBak].ToString().Trim(), //FileName_Bak
Extension = objRow[conFileResource.Extension] == DBNull.Value ? null : objRow[conFileResource.Extension].ToString().Trim(), //扩展名
FileLength = objRow[conFileResource.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFileResource.FileLength].ToString().Trim()), //文件长度
FileType = objRow[conFileResource.FileType] == DBNull.Value ? null : objRow[conFileResource.FileType].ToString().Trim(), //文件类型
CreationTime = objRow[conFileResource.CreationTime] == DBNull.Value ? null : objRow[conFileResource.CreationTime].ToString().Trim(), //建立时间
LastWriteTime = objRow[conFileResource.LastWriteTime] == DBNull.Value ? null : objRow[conFileResource.LastWriteTime].ToString().Trim(), //最后修改时间
CheckDateTime = objRow[conFileResource.CheckDateTime] == DBNull.Value ? null : objRow[conFileResource.CheckDateTime].ToString().Trim(), //CheckDateTime
IdFtpResource = objRow[conFileResource.IdFtpResource] == DBNull.Value ? null : objRow[conFileResource.IdFtpResource].ToString().Trim(), //FTP资源流水号
InUse = TransNullToBool(objRow[conFileResource.InUse].ToString().Trim()), //是否在用
IsExistFile = TransNullToBool(objRow[conFileResource.IsExistFile].ToString().Trim()), //是否存在文件
UpdDate = objRow[conFileResource.UpdDate] == DBNull.Value ? null : objRow[conFileResource.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conFileResource.UpdUser] == DBNull.Value ? null : objRow[conFileResource.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conFileResource.Memo] == DBNull.Value ? null : objRow[conFileResource.Memo].ToString().Trim() //备注
};
objFileResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFileResourceEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFileResourceDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFileResourceEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFileResourceEN objFileResourceEN = new clsFileResourceEN();
try
{
objFileResourceEN.FileResourceID = TransNullToInt(objRow[conFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objFileResourceEN.IpAddress = objRow[conFileResource.IpAddress] == DBNull.Value ? null : objRow[conFileResource.IpAddress].ToString().Trim(); //Ip地址
objFileResourceEN.FileDirName = objRow[conFileResource.FileDirName].ToString().Trim(); //文件目录名
objFileResourceEN.FileName = objRow[conFileResource.FileName].ToString().Trim(); //文件名称
objFileResourceEN.FileNameBak = objRow[conFileResource.FileNameBak] == DBNull.Value ? null : objRow[conFileResource.FileNameBak].ToString().Trim(); //FileName_Bak
objFileResourceEN.Extension = objRow[conFileResource.Extension] == DBNull.Value ? null : objRow[conFileResource.Extension].ToString().Trim(); //扩展名
objFileResourceEN.FileLength = objRow[conFileResource.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFileResource.FileLength].ToString().Trim()); //文件长度
objFileResourceEN.FileType = objRow[conFileResource.FileType] == DBNull.Value ? null : objRow[conFileResource.FileType].ToString().Trim(); //文件类型
objFileResourceEN.CreationTime = objRow[conFileResource.CreationTime] == DBNull.Value ? null : objRow[conFileResource.CreationTime].ToString().Trim(); //建立时间
objFileResourceEN.LastWriteTime = objRow[conFileResource.LastWriteTime] == DBNull.Value ? null : objRow[conFileResource.LastWriteTime].ToString().Trim(); //最后修改时间
objFileResourceEN.CheckDateTime = objRow[conFileResource.CheckDateTime] == DBNull.Value ? null : objRow[conFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFileResourceEN.IdFtpResource = objRow[conFileResource.IdFtpResource] == DBNull.Value ? null : objRow[conFileResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileResourceEN.InUse = TransNullToBool(objRow[conFileResource.InUse].ToString().Trim()); //是否在用
objFileResourceEN.IsExistFile = TransNullToBool(objRow[conFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objFileResourceEN.UpdDate = objRow[conFileResource.UpdDate] == DBNull.Value ? null : objRow[conFileResource.UpdDate].ToString().Trim(); //修改日期
objFileResourceEN.UpdUser = objRow[conFileResource.UpdUser] == DBNull.Value ? null : objRow[conFileResource.UpdUser].ToString().Trim(); //修改人
objFileResourceEN.Memo = objRow[conFileResource.Memo] == DBNull.Value ? null : objRow[conFileResource.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFileResourceDA: GetObjByDataRowFileResource)", objException.Message));
}
objFileResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFileResourceEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFileResourceEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFileResourceEN objFileResourceEN = new clsFileResourceEN();
try
{
objFileResourceEN.FileResourceID = TransNullToInt(objRow[conFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objFileResourceEN.IpAddress = objRow[conFileResource.IpAddress] == DBNull.Value ? null : objRow[conFileResource.IpAddress].ToString().Trim(); //Ip地址
objFileResourceEN.FileDirName = objRow[conFileResource.FileDirName].ToString().Trim(); //文件目录名
objFileResourceEN.FileName = objRow[conFileResource.FileName].ToString().Trim(); //文件名称
objFileResourceEN.FileNameBak = objRow[conFileResource.FileNameBak] == DBNull.Value ? null : objRow[conFileResource.FileNameBak].ToString().Trim(); //FileName_Bak
objFileResourceEN.Extension = objRow[conFileResource.Extension] == DBNull.Value ? null : objRow[conFileResource.Extension].ToString().Trim(); //扩展名
objFileResourceEN.FileLength = objRow[conFileResource.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conFileResource.FileLength].ToString().Trim()); //文件长度
objFileResourceEN.FileType = objRow[conFileResource.FileType] == DBNull.Value ? null : objRow[conFileResource.FileType].ToString().Trim(); //文件类型
objFileResourceEN.CreationTime = objRow[conFileResource.CreationTime] == DBNull.Value ? null : objRow[conFileResource.CreationTime].ToString().Trim(); //建立时间
objFileResourceEN.LastWriteTime = objRow[conFileResource.LastWriteTime] == DBNull.Value ? null : objRow[conFileResource.LastWriteTime].ToString().Trim(); //最后修改时间
objFileResourceEN.CheckDateTime = objRow[conFileResource.CheckDateTime] == DBNull.Value ? null : objRow[conFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFileResourceEN.IdFtpResource = objRow[conFileResource.IdFtpResource] == DBNull.Value ? null : objRow[conFileResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileResourceEN.InUse = TransNullToBool(objRow[conFileResource.InUse].ToString().Trim()); //是否在用
objFileResourceEN.IsExistFile = TransNullToBool(objRow[conFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objFileResourceEN.UpdDate = objRow[conFileResource.UpdDate] == DBNull.Value ? null : objRow[conFileResource.UpdDate].ToString().Trim(); //修改日期
objFileResourceEN.UpdUser = objRow[conFileResource.UpdUser] == DBNull.Value ? null : objRow[conFileResource.UpdUser].ToString().Trim(); //修改人
objFileResourceEN.Memo = objRow[conFileResource.Memo] == DBNull.Value ? null : objRow[conFileResource.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFileResourceDA: GetObjByDataRow)", objException.Message));
}
objFileResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFileResourceEN;
}

 #endregion 获取一个实体对象

 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrID)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public static string GetMaxStrId()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFileResourceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFileResourceEN._CurrTabName, conFileResource.FileResourceID, 8, "");
return strMaxValue;
}

 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public string GetMaxStrIdByPrefix(string strPrefix)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFileResourceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFileResourceEN._CurrTabName, conFileResource.FileResourceID, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FileResourceID from FileResource where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
}

 #endregion 获取一个关键字值

 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的所有记录的关键字值列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetPrimaryKeyID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的关键字值列表</returns>
public List<string> GetID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
List<string> arrList = new List<string>();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FileResourceID from FileResource where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return null;
}
for (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)
{
strKeyValue = "";
for (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)
{
if (iCol  ==  0)
{
strKeyValue +=  objDT.Rows[iRow][iCol].ToString();
}
else
{
strKeyValue +=  "//" + objDT.Rows[iRow][iCol].ToString();
}
}
arrList.Add(strKeyValue);
}
return arrList;
}

 #endregion 获取多个关键字值列表

 #region 判断记录是否存在

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExist_S)
 /// </summary>
 /// <param name = "lngFileResourceID">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngFileResourceID)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FileResource", "FileResourceID = " + ""+ lngFileResourceID+""))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistCondRec_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public bool IsExistCondRec(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFileResourceDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FileResource", strCondition))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFileResourceDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FileResource");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFileResourceEN objFileResourceEN)
 {
 objFileResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFileResourceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFileResourceEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from FileResource where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FileResource");
objRow = objDS.Tables["FileResource"].NewRow();
 if (objFileResourceEN.IpAddress !=  "")
 {
objRow[conFileResource.IpAddress] = objFileResourceEN.IpAddress; //Ip地址
 }
objRow[conFileResource.FileDirName] = objFileResourceEN.FileDirName; //文件目录名
objRow[conFileResource.FileName] = objFileResourceEN.FileName; //文件名称
 if (objFileResourceEN.FileNameBak !=  "")
 {
objRow[conFileResource.FileNameBak] = objFileResourceEN.FileNameBak; //FileName_Bak
 }
 if (objFileResourceEN.Extension !=  "")
 {
objRow[conFileResource.Extension] = objFileResourceEN.Extension; //扩展名
 }
objRow[conFileResource.FileLength] = objFileResourceEN.FileLength; //文件长度
 if (objFileResourceEN.FileType !=  "")
 {
objRow[conFileResource.FileType] = objFileResourceEN.FileType; //文件类型
 }
 if (objFileResourceEN.CreationTime !=  "")
 {
objRow[conFileResource.CreationTime] = objFileResourceEN.CreationTime; //建立时间
 }
 if (objFileResourceEN.LastWriteTime !=  "")
 {
objRow[conFileResource.LastWriteTime] = objFileResourceEN.LastWriteTime; //最后修改时间
 }
 if (objFileResourceEN.CheckDateTime !=  "")
 {
objRow[conFileResource.CheckDateTime] = objFileResourceEN.CheckDateTime; //CheckDateTime
 }
 if (objFileResourceEN.IdFtpResource !=  "")
 {
objRow[conFileResource.IdFtpResource] = objFileResourceEN.IdFtpResource; //FTP资源流水号
 }
objRow[conFileResource.InUse] = objFileResourceEN.InUse; //是否在用
objRow[conFileResource.IsExistFile] = objFileResourceEN.IsExistFile; //是否存在文件
 if (objFileResourceEN.UpdDate !=  "")
 {
objRow[conFileResource.UpdDate] = objFileResourceEN.UpdDate; //修改日期
 }
 if (objFileResourceEN.UpdUser !=  "")
 {
objRow[conFileResource.UpdUser] = objFileResourceEN.UpdUser; //修改人
 }
 if (objFileResourceEN.Memo !=  "")
 {
objRow[conFileResource.Memo] = objFileResourceEN.Memo; //备注
 }
objDS.Tables[clsFileResourceEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFileResourceEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2)
 /// </summary>
 /// <param name = "objFileResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFileResourceEN objFileResourceEN)
{
 objFileResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFileResourceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFileResourceEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFileResourceEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.IpAddress);
 var strIpAddress = objFileResourceEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objFileResourceEN.FileDirName !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileDirName);
 var strFileDirName = objFileResourceEN.FileDirName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileDirName + "'");
 }
 
 if (objFileResourceEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileName);
 var strFileName = objFileResourceEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objFileResourceEN.FileNameBak !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileNameBak);
 var strFileNameBak = objFileResourceEN.FileNameBak.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileNameBak + "'");
 }
 
 if (objFileResourceEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.Extension);
 var strExtension = objFileResourceEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objFileResourceEN.FileLength !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileLength);
 arrValueListForInsert.Add(objFileResourceEN.FileLength.ToString());
 }
 
 if (objFileResourceEN.FileType !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileType);
 var strFileType = objFileResourceEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileType + "'");
 }
 
 if (objFileResourceEN.CreationTime !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.CreationTime);
 var strCreationTime = objFileResourceEN.CreationTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreationTime + "'");
 }
 
 if (objFileResourceEN.LastWriteTime !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.LastWriteTime);
 var strLastWriteTime = objFileResourceEN.LastWriteTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastWriteTime + "'");
 }
 
 if (objFileResourceEN.CheckDateTime !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.CheckDateTime);
 var strCheckDateTime = objFileResourceEN.CheckDateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDateTime + "'");
 }
 
 if (objFileResourceEN.IdFtpResource !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.IdFtpResource);
 var strIdFtpResource = objFileResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdFtpResource + "'");
 }
 
 arrFieldListForInsert.Add(conFileResource.InUse);
 arrValueListForInsert.Add("'" + (objFileResourceEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFileResource.IsExistFile);
 arrValueListForInsert.Add("'" + (objFileResourceEN.IsExistFile  ==  false ? "0" : "1") + "'");
 
 if (objFileResourceEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.UpdDate);
 var strUpdDate = objFileResourceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFileResourceEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.UpdUser);
 var strUpdUser = objFileResourceEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFileResourceEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.Memo);
 var strMemo = objFileResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FileResource");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFileResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFileResourceEN objFileResourceEN)
{
 objFileResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFileResourceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFileResourceEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFileResourceEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.IpAddress);
 var strIpAddress = objFileResourceEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objFileResourceEN.FileDirName !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileDirName);
 var strFileDirName = objFileResourceEN.FileDirName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileDirName + "'");
 }
 
 if (objFileResourceEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileName);
 var strFileName = objFileResourceEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objFileResourceEN.FileNameBak !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileNameBak);
 var strFileNameBak = objFileResourceEN.FileNameBak.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileNameBak + "'");
 }
 
 if (objFileResourceEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.Extension);
 var strExtension = objFileResourceEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objFileResourceEN.FileLength !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileLength);
 arrValueListForInsert.Add(objFileResourceEN.FileLength.ToString());
 }
 
 if (objFileResourceEN.FileType !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileType);
 var strFileType = objFileResourceEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileType + "'");
 }
 
 if (objFileResourceEN.CreationTime !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.CreationTime);
 var strCreationTime = objFileResourceEN.CreationTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreationTime + "'");
 }
 
 if (objFileResourceEN.LastWriteTime !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.LastWriteTime);
 var strLastWriteTime = objFileResourceEN.LastWriteTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastWriteTime + "'");
 }
 
 if (objFileResourceEN.CheckDateTime !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.CheckDateTime);
 var strCheckDateTime = objFileResourceEN.CheckDateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDateTime + "'");
 }
 
 if (objFileResourceEN.IdFtpResource !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.IdFtpResource);
 var strIdFtpResource = objFileResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdFtpResource + "'");
 }
 
 arrFieldListForInsert.Add(conFileResource.InUse);
 arrValueListForInsert.Add("'" + (objFileResourceEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFileResource.IsExistFile);
 arrValueListForInsert.Add("'" + (objFileResourceEN.IsExistFile  ==  false ? "0" : "1") + "'");
 
 if (objFileResourceEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.UpdDate);
 var strUpdDate = objFileResourceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFileResourceEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.UpdUser);
 var strUpdUser = objFileResourceEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFileResourceEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.Memo);
 var strMemo = objFileResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FileResource");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFileResourceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFileResourceEN objFileResourceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFileResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFileResourceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFileResourceEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFileResourceEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.IpAddress);
 var strIpAddress = objFileResourceEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objFileResourceEN.FileDirName !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileDirName);
 var strFileDirName = objFileResourceEN.FileDirName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileDirName + "'");
 }
 
 if (objFileResourceEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileName);
 var strFileName = objFileResourceEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objFileResourceEN.FileNameBak !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileNameBak);
 var strFileNameBak = objFileResourceEN.FileNameBak.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileNameBak + "'");
 }
 
 if (objFileResourceEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.Extension);
 var strExtension = objFileResourceEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objFileResourceEN.FileLength !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileLength);
 arrValueListForInsert.Add(objFileResourceEN.FileLength.ToString());
 }
 
 if (objFileResourceEN.FileType !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileType);
 var strFileType = objFileResourceEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileType + "'");
 }
 
 if (objFileResourceEN.CreationTime !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.CreationTime);
 var strCreationTime = objFileResourceEN.CreationTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreationTime + "'");
 }
 
 if (objFileResourceEN.LastWriteTime !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.LastWriteTime);
 var strLastWriteTime = objFileResourceEN.LastWriteTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastWriteTime + "'");
 }
 
 if (objFileResourceEN.CheckDateTime !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.CheckDateTime);
 var strCheckDateTime = objFileResourceEN.CheckDateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDateTime + "'");
 }
 
 if (objFileResourceEN.IdFtpResource !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.IdFtpResource);
 var strIdFtpResource = objFileResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdFtpResource + "'");
 }
 
 arrFieldListForInsert.Add(conFileResource.InUse);
 arrValueListForInsert.Add("'" + (objFileResourceEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFileResource.IsExistFile);
 arrValueListForInsert.Add("'" + (objFileResourceEN.IsExistFile  ==  false ? "0" : "1") + "'");
 
 if (objFileResourceEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.UpdDate);
 var strUpdDate = objFileResourceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFileResourceEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.UpdUser);
 var strUpdUser = objFileResourceEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFileResourceEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.Memo);
 var strMemo = objFileResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FileResource");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFileResourceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFileResourceEN objFileResourceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFileResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFileResourceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFileResourceEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFileResourceEN.IpAddress !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.IpAddress);
 var strIpAddress = objFileResourceEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIpAddress + "'");
 }
 
 if (objFileResourceEN.FileDirName !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileDirName);
 var strFileDirName = objFileResourceEN.FileDirName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileDirName + "'");
 }
 
 if (objFileResourceEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileName);
 var strFileName = objFileResourceEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objFileResourceEN.FileNameBak !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileNameBak);
 var strFileNameBak = objFileResourceEN.FileNameBak.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileNameBak + "'");
 }
 
 if (objFileResourceEN.Extension !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.Extension);
 var strExtension = objFileResourceEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtension + "'");
 }
 
 if (objFileResourceEN.FileLength !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileLength);
 arrValueListForInsert.Add(objFileResourceEN.FileLength.ToString());
 }
 
 if (objFileResourceEN.FileType !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.FileType);
 var strFileType = objFileResourceEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileType + "'");
 }
 
 if (objFileResourceEN.CreationTime !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.CreationTime);
 var strCreationTime = objFileResourceEN.CreationTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreationTime + "'");
 }
 
 if (objFileResourceEN.LastWriteTime !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.LastWriteTime);
 var strLastWriteTime = objFileResourceEN.LastWriteTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastWriteTime + "'");
 }
 
 if (objFileResourceEN.CheckDateTime !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.CheckDateTime);
 var strCheckDateTime = objFileResourceEN.CheckDateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDateTime + "'");
 }
 
 if (objFileResourceEN.IdFtpResource !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.IdFtpResource);
 var strIdFtpResource = objFileResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdFtpResource + "'");
 }
 
 arrFieldListForInsert.Add(conFileResource.InUse);
 arrValueListForInsert.Add("'" + (objFileResourceEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFileResource.IsExistFile);
 arrValueListForInsert.Add("'" + (objFileResourceEN.IsExistFile  ==  false ? "0" : "1") + "'");
 
 if (objFileResourceEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.UpdDate);
 var strUpdDate = objFileResourceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFileResourceEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.UpdUser);
 var strUpdUser = objFileResourceEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFileResourceEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFileResource.Memo);
 var strMemo = objFileResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FileResource");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFileResources(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from FileResource where FileResourceID = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FileResource");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngFileResourceID = TransNullToInt(oRow[conFileResource.FileResourceID].ToString().Trim());
if (IsExist(lngFileResourceID))
{
 string strResult = "关键字变量值为:" + string.Format("FileResourceID = {0}", lngFileResourceID) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFileResourceEN._CurrTabName ].NewRow();
objRow[conFileResource.IpAddress] = oRow[conFileResource.IpAddress].ToString().Trim(); //Ip地址
objRow[conFileResource.FileDirName] = oRow[conFileResource.FileDirName].ToString().Trim(); //文件目录名
objRow[conFileResource.FileName] = oRow[conFileResource.FileName].ToString().Trim(); //文件名称
objRow[conFileResource.FileNameBak] = oRow[conFileResource.FileNameBak].ToString().Trim(); //FileName_Bak
objRow[conFileResource.Extension] = oRow[conFileResource.Extension].ToString().Trim(); //扩展名
objRow[conFileResource.FileLength] = oRow[conFileResource.FileLength].ToString().Trim(); //文件长度
objRow[conFileResource.FileType] = oRow[conFileResource.FileType].ToString().Trim(); //文件类型
objRow[conFileResource.CreationTime] = oRow[conFileResource.CreationTime].ToString().Trim(); //建立时间
objRow[conFileResource.LastWriteTime] = oRow[conFileResource.LastWriteTime].ToString().Trim(); //最后修改时间
objRow[conFileResource.CheckDateTime] = oRow[conFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objRow[conFileResource.IdFtpResource] = oRow[conFileResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objRow[conFileResource.InUse] = oRow[conFileResource.InUse].ToString().Trim(); //是否在用
objRow[conFileResource.IsExistFile] = oRow[conFileResource.IsExistFile].ToString().Trim(); //是否存在文件
objRow[conFileResource.UpdDate] = oRow[conFileResource.UpdDate].ToString().Trim(); //修改日期
objRow[conFileResource.UpdUser] = oRow[conFileResource.UpdUser].ToString().Trim(); //修改人
objRow[conFileResource.Memo] = oRow[conFileResource.Memo].ToString().Trim(); //备注
 objDS.Tables[clsFileResourceEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFileResourceEN._CurrTabName);
}
catch(Exception objException) 
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objSQL.SQLConnect.Close();
}
return true;
}

 #endregion 添加记录

 #region 修改记录

 /// <summary>
 /// 功能:通过ADO修改记录
 /// (AutoGCLib.DALCode4CSharp:GenUpdate)
 /// </summary>
 /// <param name = "objFileResourceEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFileResourceEN objFileResourceEN)
{
 objFileResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFileResourceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFileResourceEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from FileResource where FileResourceID = " + ""+ objFileResourceEN.FileResourceID+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFileResourceEN._CurrTabName);
if (objDS.Tables[clsFileResourceEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FileResourceID = " + ""+ objFileResourceEN.FileResourceID+"");
return false;
}
objRow = objDS.Tables[clsFileResourceEN._CurrTabName].Rows[0];
 if (objFileResourceEN.IsUpdated(conFileResource.IpAddress))
 {
objRow[conFileResource.IpAddress] = objFileResourceEN.IpAddress; //Ip地址
 }
 if (objFileResourceEN.IsUpdated(conFileResource.FileDirName))
 {
objRow[conFileResource.FileDirName] = objFileResourceEN.FileDirName; //文件目录名
 }
 if (objFileResourceEN.IsUpdated(conFileResource.FileName))
 {
objRow[conFileResource.FileName] = objFileResourceEN.FileName; //文件名称
 }
 if (objFileResourceEN.IsUpdated(conFileResource.FileNameBak))
 {
objRow[conFileResource.FileNameBak] = objFileResourceEN.FileNameBak; //FileName_Bak
 }
 if (objFileResourceEN.IsUpdated(conFileResource.Extension))
 {
objRow[conFileResource.Extension] = objFileResourceEN.Extension; //扩展名
 }
 if (objFileResourceEN.IsUpdated(conFileResource.FileLength))
 {
objRow[conFileResource.FileLength] = objFileResourceEN.FileLength; //文件长度
 }
 if (objFileResourceEN.IsUpdated(conFileResource.FileType))
 {
objRow[conFileResource.FileType] = objFileResourceEN.FileType; //文件类型
 }
 if (objFileResourceEN.IsUpdated(conFileResource.CreationTime))
 {
objRow[conFileResource.CreationTime] = objFileResourceEN.CreationTime; //建立时间
 }
 if (objFileResourceEN.IsUpdated(conFileResource.LastWriteTime))
 {
objRow[conFileResource.LastWriteTime] = objFileResourceEN.LastWriteTime; //最后修改时间
 }
 if (objFileResourceEN.IsUpdated(conFileResource.CheckDateTime))
 {
objRow[conFileResource.CheckDateTime] = objFileResourceEN.CheckDateTime; //CheckDateTime
 }
 if (objFileResourceEN.IsUpdated(conFileResource.IdFtpResource))
 {
objRow[conFileResource.IdFtpResource] = objFileResourceEN.IdFtpResource; //FTP资源流水号
 }
 if (objFileResourceEN.IsUpdated(conFileResource.InUse))
 {
objRow[conFileResource.InUse] = objFileResourceEN.InUse; //是否在用
 }
 if (objFileResourceEN.IsUpdated(conFileResource.IsExistFile))
 {
objRow[conFileResource.IsExistFile] = objFileResourceEN.IsExistFile; //是否存在文件
 }
 if (objFileResourceEN.IsUpdated(conFileResource.UpdDate))
 {
objRow[conFileResource.UpdDate] = objFileResourceEN.UpdDate; //修改日期
 }
 if (objFileResourceEN.IsUpdated(conFileResource.UpdUser))
 {
objRow[conFileResource.UpdUser] = objFileResourceEN.UpdUser; //修改人
 }
 if (objFileResourceEN.IsUpdated(conFileResource.Memo))
 {
objRow[conFileResource.Memo] = objFileResourceEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsFileResourceEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objFileResourceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFileResourceEN objFileResourceEN)
{
 objFileResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFileResourceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFileResourceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FileResource Set ");
 
 if (objFileResourceEN.IsUpdated(conFileResource.IpAddress))
 {
 if (objFileResourceEN.IpAddress !=  null)
 {
 var strIpAddress = objFileResourceEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIpAddress, conFileResource.IpAddress); //Ip地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.IpAddress); //Ip地址
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileDirName))
 {
 if (objFileResourceEN.FileDirName !=  null)
 {
 var strFileDirName = objFileResourceEN.FileDirName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileDirName, conFileResource.FileDirName); //文件目录名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.FileDirName); //文件目录名
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileName))
 {
 if (objFileResourceEN.FileName !=  null)
 {
 var strFileName = objFileResourceEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conFileResource.FileName); //文件名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.FileName); //文件名称
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileNameBak))
 {
 if (objFileResourceEN.FileNameBak !=  null)
 {
 var strFileNameBak = objFileResourceEN.FileNameBak.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileNameBak, conFileResource.FileNameBak); //FileName_Bak
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.FileNameBak); //FileName_Bak
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.Extension))
 {
 if (objFileResourceEN.Extension !=  null)
 {
 var strExtension = objFileResourceEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExtension, conFileResource.Extension); //扩展名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.Extension); //扩展名
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileLength))
 {
 if (objFileResourceEN.FileLength !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFileResourceEN.FileLength, conFileResource.FileLength); //文件长度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.FileLength); //文件长度
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileType))
 {
 if (objFileResourceEN.FileType !=  null)
 {
 var strFileType = objFileResourceEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileType, conFileResource.FileType); //文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.FileType); //文件类型
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.CreationTime))
 {
 if (objFileResourceEN.CreationTime !=  null)
 {
 var strCreationTime = objFileResourceEN.CreationTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreationTime, conFileResource.CreationTime); //建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.CreationTime); //建立时间
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.LastWriteTime))
 {
 if (objFileResourceEN.LastWriteTime !=  null)
 {
 var strLastWriteTime = objFileResourceEN.LastWriteTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLastWriteTime, conFileResource.LastWriteTime); //最后修改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.LastWriteTime); //最后修改时间
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.CheckDateTime))
 {
 if (objFileResourceEN.CheckDateTime !=  null)
 {
 var strCheckDateTime = objFileResourceEN.CheckDateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckDateTime, conFileResource.CheckDateTime); //CheckDateTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.CheckDateTime); //CheckDateTime
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.IdFtpResource))
 {
 if (objFileResourceEN.IdFtpResource !=  null)
 {
 var strIdFtpResource = objFileResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdFtpResource, conFileResource.IdFtpResource); //FTP资源流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.IdFtpResource); //FTP资源流水号
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFileResourceEN.InUse == true?"1":"0", conFileResource.InUse); //是否在用
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.IsExistFile))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFileResourceEN.IsExistFile == true?"1":"0", conFileResource.IsExistFile); //是否存在文件
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.UpdDate))
 {
 if (objFileResourceEN.UpdDate !=  null)
 {
 var strUpdDate = objFileResourceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFileResource.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.UpdDate); //修改日期
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.UpdUser))
 {
 if (objFileResourceEN.UpdUser !=  null)
 {
 var strUpdUser = objFileResourceEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFileResource.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.UpdUser); //修改人
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.Memo))
 {
 if (objFileResourceEN.Memo !=  null)
 {
 var strMemo = objFileResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFileResource.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FileResourceID = {0}", objFileResourceEN.FileResourceID); 
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
string strMsg = string.Format("发生错误:[{0}].SQL:[{1}].({2})",
     objException.Message, sbSQL.ToString(), clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objFileResourceEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFileResourceEN objFileResourceEN, string strCondition)
{
 objFileResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFileResourceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFileResourceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FileResource Set ");
 
 if (objFileResourceEN.IsUpdated(conFileResource.IpAddress))
 {
 if (objFileResourceEN.IpAddress !=  null)
 {
 var strIpAddress = objFileResourceEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IpAddress = '{0}',", strIpAddress); //Ip地址
 }
 else
 {
 sbSQL.Append(" IpAddress = null,"); //Ip地址
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileDirName))
 {
 if (objFileResourceEN.FileDirName !=  null)
 {
 var strFileDirName = objFileResourceEN.FileDirName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileDirName = '{0}',", strFileDirName); //文件目录名
 }
 else
 {
 sbSQL.Append(" FileDirName = null,"); //文件目录名
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileName))
 {
 if (objFileResourceEN.FileName !=  null)
 {
 var strFileName = objFileResourceEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名称
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名称
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileNameBak))
 {
 if (objFileResourceEN.FileNameBak !=  null)
 {
 var strFileNameBak = objFileResourceEN.FileNameBak.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileNameBak = '{0}',", strFileNameBak); //FileName_Bak
 }
 else
 {
 sbSQL.Append(" FileNameBak = null,"); //FileName_Bak
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.Extension))
 {
 if (objFileResourceEN.Extension !=  null)
 {
 var strExtension = objFileResourceEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Extension = '{0}',", strExtension); //扩展名
 }
 else
 {
 sbSQL.Append(" Extension = null,"); //扩展名
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileLength))
 {
 sbSQL.AppendFormat(" FileLength = {0},", objFileResourceEN.FileLength); //文件长度
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileType))
 {
 if (objFileResourceEN.FileType !=  null)
 {
 var strFileType = objFileResourceEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileType = '{0}',", strFileType); //文件类型
 }
 else
 {
 sbSQL.Append(" FileType = null,"); //文件类型
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.CreationTime))
 {
 if (objFileResourceEN.CreationTime !=  null)
 {
 var strCreationTime = objFileResourceEN.CreationTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreationTime = '{0}',", strCreationTime); //建立时间
 }
 else
 {
 sbSQL.Append(" CreationTime = null,"); //建立时间
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.LastWriteTime))
 {
 if (objFileResourceEN.LastWriteTime !=  null)
 {
 var strLastWriteTime = objFileResourceEN.LastWriteTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastWriteTime = '{0}',", strLastWriteTime); //最后修改时间
 }
 else
 {
 sbSQL.Append(" LastWriteTime = null,"); //最后修改时间
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.CheckDateTime))
 {
 if (objFileResourceEN.CheckDateTime !=  null)
 {
 var strCheckDateTime = objFileResourceEN.CheckDateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckDateTime = '{0}',", strCheckDateTime); //CheckDateTime
 }
 else
 {
 sbSQL.Append(" CheckDateTime = null,"); //CheckDateTime
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.IdFtpResource))
 {
 if (objFileResourceEN.IdFtpResource !=  null)
 {
 var strIdFtpResource = objFileResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdFtpResource = '{0}',", strIdFtpResource); //FTP资源流水号
 }
 else
 {
 sbSQL.Append(" IdFtpResource = null,"); //FTP资源流水号
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objFileResourceEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.IsExistFile))
 {
 sbSQL.AppendFormat(" IsExistFile = '{0}',", objFileResourceEN.IsExistFile == true?"1":"0"); //是否存在文件
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.UpdDate))
 {
 if (objFileResourceEN.UpdDate !=  null)
 {
 var strUpdDate = objFileResourceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.UpdUser))
 {
 if (objFileResourceEN.UpdUser !=  null)
 {
 var strUpdUser = objFileResourceEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.Memo))
 {
 if (objFileResourceEN.Memo !=  null)
 {
 var strMemo = objFileResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式,根据条件修改记录.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithConditionTransaction)
 /// </summary>
 /// <param name = "objFileResourceEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFileResourceEN objFileResourceEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFileResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFileResourceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFileResourceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FileResource Set ");
 
 if (objFileResourceEN.IsUpdated(conFileResource.IpAddress))
 {
 if (objFileResourceEN.IpAddress !=  null)
 {
 var strIpAddress = objFileResourceEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IpAddress = '{0}',", strIpAddress); //Ip地址
 }
 else
 {
 sbSQL.Append(" IpAddress = null,"); //Ip地址
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileDirName))
 {
 if (objFileResourceEN.FileDirName !=  null)
 {
 var strFileDirName = objFileResourceEN.FileDirName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileDirName = '{0}',", strFileDirName); //文件目录名
 }
 else
 {
 sbSQL.Append(" FileDirName = null,"); //文件目录名
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileName))
 {
 if (objFileResourceEN.FileName !=  null)
 {
 var strFileName = objFileResourceEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名称
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名称
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileNameBak))
 {
 if (objFileResourceEN.FileNameBak !=  null)
 {
 var strFileNameBak = objFileResourceEN.FileNameBak.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileNameBak = '{0}',", strFileNameBak); //FileName_Bak
 }
 else
 {
 sbSQL.Append(" FileNameBak = null,"); //FileName_Bak
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.Extension))
 {
 if (objFileResourceEN.Extension !=  null)
 {
 var strExtension = objFileResourceEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Extension = '{0}',", strExtension); //扩展名
 }
 else
 {
 sbSQL.Append(" Extension = null,"); //扩展名
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileLength))
 {
 sbSQL.AppendFormat(" FileLength = {0},", objFileResourceEN.FileLength); //文件长度
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileType))
 {
 if (objFileResourceEN.FileType !=  null)
 {
 var strFileType = objFileResourceEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileType = '{0}',", strFileType); //文件类型
 }
 else
 {
 sbSQL.Append(" FileType = null,"); //文件类型
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.CreationTime))
 {
 if (objFileResourceEN.CreationTime !=  null)
 {
 var strCreationTime = objFileResourceEN.CreationTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreationTime = '{0}',", strCreationTime); //建立时间
 }
 else
 {
 sbSQL.Append(" CreationTime = null,"); //建立时间
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.LastWriteTime))
 {
 if (objFileResourceEN.LastWriteTime !=  null)
 {
 var strLastWriteTime = objFileResourceEN.LastWriteTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastWriteTime = '{0}',", strLastWriteTime); //最后修改时间
 }
 else
 {
 sbSQL.Append(" LastWriteTime = null,"); //最后修改时间
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.CheckDateTime))
 {
 if (objFileResourceEN.CheckDateTime !=  null)
 {
 var strCheckDateTime = objFileResourceEN.CheckDateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckDateTime = '{0}',", strCheckDateTime); //CheckDateTime
 }
 else
 {
 sbSQL.Append(" CheckDateTime = null,"); //CheckDateTime
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.IdFtpResource))
 {
 if (objFileResourceEN.IdFtpResource !=  null)
 {
 var strIdFtpResource = objFileResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdFtpResource = '{0}',", strIdFtpResource); //FTP资源流水号
 }
 else
 {
 sbSQL.Append(" IdFtpResource = null,"); //FTP资源流水号
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objFileResourceEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.IsExistFile))
 {
 sbSQL.AppendFormat(" IsExistFile = '{0}',", objFileResourceEN.IsExistFile == true?"1":"0"); //是否存在文件
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.UpdDate))
 {
 if (objFileResourceEN.UpdDate !=  null)
 {
 var strUpdDate = objFileResourceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.UpdUser))
 {
 if (objFileResourceEN.UpdUser !=  null)
 {
 var strUpdUser = objFileResourceEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.Memo))
 {
 if (objFileResourceEN.Memo !=  null)
 {
 var strMemo = objFileResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithTransaction2)
 /// </summary>
 /// <param name = "objFileResourceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFileResourceEN objFileResourceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFileResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFileResourceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFileResourceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FileResource Set ");
 
 if (objFileResourceEN.IsUpdated(conFileResource.IpAddress))
 {
 if (objFileResourceEN.IpAddress !=  null)
 {
 var strIpAddress = objFileResourceEN.IpAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIpAddress, conFileResource.IpAddress); //Ip地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.IpAddress); //Ip地址
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileDirName))
 {
 if (objFileResourceEN.FileDirName !=  null)
 {
 var strFileDirName = objFileResourceEN.FileDirName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileDirName, conFileResource.FileDirName); //文件目录名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.FileDirName); //文件目录名
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileName))
 {
 if (objFileResourceEN.FileName !=  null)
 {
 var strFileName = objFileResourceEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conFileResource.FileName); //文件名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.FileName); //文件名称
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileNameBak))
 {
 if (objFileResourceEN.FileNameBak !=  null)
 {
 var strFileNameBak = objFileResourceEN.FileNameBak.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileNameBak, conFileResource.FileNameBak); //FileName_Bak
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.FileNameBak); //FileName_Bak
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.Extension))
 {
 if (objFileResourceEN.Extension !=  null)
 {
 var strExtension = objFileResourceEN.Extension.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExtension, conFileResource.Extension); //扩展名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.Extension); //扩展名
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileLength))
 {
 if (objFileResourceEN.FileLength !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFileResourceEN.FileLength, conFileResource.FileLength); //文件长度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.FileLength); //文件长度
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.FileType))
 {
 if (objFileResourceEN.FileType !=  null)
 {
 var strFileType = objFileResourceEN.FileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileType, conFileResource.FileType); //文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.FileType); //文件类型
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.CreationTime))
 {
 if (objFileResourceEN.CreationTime !=  null)
 {
 var strCreationTime = objFileResourceEN.CreationTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreationTime, conFileResource.CreationTime); //建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.CreationTime); //建立时间
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.LastWriteTime))
 {
 if (objFileResourceEN.LastWriteTime !=  null)
 {
 var strLastWriteTime = objFileResourceEN.LastWriteTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLastWriteTime, conFileResource.LastWriteTime); //最后修改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.LastWriteTime); //最后修改时间
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.CheckDateTime))
 {
 if (objFileResourceEN.CheckDateTime !=  null)
 {
 var strCheckDateTime = objFileResourceEN.CheckDateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckDateTime, conFileResource.CheckDateTime); //CheckDateTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.CheckDateTime); //CheckDateTime
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.IdFtpResource))
 {
 if (objFileResourceEN.IdFtpResource !=  null)
 {
 var strIdFtpResource = objFileResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdFtpResource, conFileResource.IdFtpResource); //FTP资源流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.IdFtpResource); //FTP资源流水号
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFileResourceEN.InUse == true?"1":"0", conFileResource.InUse); //是否在用
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.IsExistFile))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFileResourceEN.IsExistFile == true?"1":"0", conFileResource.IsExistFile); //是否存在文件
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.UpdDate))
 {
 if (objFileResourceEN.UpdDate !=  null)
 {
 var strUpdDate = objFileResourceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFileResource.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.UpdDate); //修改日期
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.UpdUser))
 {
 if (objFileResourceEN.UpdUser !=  null)
 {
 var strUpdUser = objFileResourceEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFileResource.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.UpdUser); //修改人
 }
 }
 
 if (objFileResourceEN.IsUpdated(conFileResource.Memo))
 {
 if (objFileResourceEN.Memo !=  null)
 {
 var strMemo = objFileResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFileResource.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFileResource.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FileResourceID = {0}", objFileResourceEN.FileResourceID); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 #endregion 修改记录

 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySP)
 /// </summary>
 /// <param name = "lngFileResourceID">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngFileResourceID) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngFileResourceID,
};
 objSQL.ExecSP("FileResource_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngFileResourceID">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngFileResourceID, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
//删除FileResource本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FileResource where FileResourceID = " + ""+ lngFileResourceID+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFileResource(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除FileResource本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FileResource where FileResourceID in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngFileResourceID">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngFileResourceID) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
//删除FileResource本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FileResource where FileResourceID = " + ""+ lngFileResourceID+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFileResource(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFileResourceDA: DelFileResource)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FileResource where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool DelFileResourceWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFileResourceDA: DelFileResourceWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FileResource where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objFileResourceENS">源对象</param>
 /// <param name = "objFileResourceENT">目标对象</param>
public void CopyTo(clsFileResourceEN objFileResourceENS, clsFileResourceEN objFileResourceENT)
{
objFileResourceENT.FileResourceID = objFileResourceENS.FileResourceID; //FileResourceID
objFileResourceENT.IpAddress = objFileResourceENS.IpAddress; //Ip地址
objFileResourceENT.FileDirName = objFileResourceENS.FileDirName; //文件目录名
objFileResourceENT.FileName = objFileResourceENS.FileName; //文件名称
objFileResourceENT.FileNameBak = objFileResourceENS.FileNameBak; //FileName_Bak
objFileResourceENT.Extension = objFileResourceENS.Extension; //扩展名
objFileResourceENT.FileLength = objFileResourceENS.FileLength; //文件长度
objFileResourceENT.FileType = objFileResourceENS.FileType; //文件类型
objFileResourceENT.CreationTime = objFileResourceENS.CreationTime; //建立时间
objFileResourceENT.LastWriteTime = objFileResourceENS.LastWriteTime; //最后修改时间
objFileResourceENT.CheckDateTime = objFileResourceENS.CheckDateTime; //CheckDateTime
objFileResourceENT.IdFtpResource = objFileResourceENS.IdFtpResource; //FTP资源流水号
objFileResourceENT.InUse = objFileResourceENS.InUse; //是否在用
objFileResourceENT.IsExistFile = objFileResourceENS.IsExistFile; //是否存在文件
objFileResourceENT.UpdDate = objFileResourceENS.UpdDate; //修改日期
objFileResourceENT.UpdUser = objFileResourceENS.UpdUser; //修改人
objFileResourceENT.Memo = objFileResourceENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFileResourceEN objFileResourceEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFileResourceEN.FileDirName, conFileResource.FileDirName);
clsCheckSql.CheckFieldNotNull(objFileResourceEN.FileName, conFileResource.FileName);
//检查字段长度
clsCheckSql.CheckFieldLen(objFileResourceEN.IpAddress, 50, conFileResource.IpAddress);
clsCheckSql.CheckFieldLen(objFileResourceEN.FileDirName, 200, conFileResource.FileDirName);
clsCheckSql.CheckFieldLen(objFileResourceEN.FileName, 500, conFileResource.FileName);
clsCheckSql.CheckFieldLen(objFileResourceEN.FileNameBak, 500, conFileResource.FileNameBak);
clsCheckSql.CheckFieldLen(objFileResourceEN.Extension, 10, conFileResource.Extension);
clsCheckSql.CheckFieldLen(objFileResourceEN.FileType, 30, conFileResource.FileType);
clsCheckSql.CheckFieldLen(objFileResourceEN.CreationTime, 20, conFileResource.CreationTime);
clsCheckSql.CheckFieldLen(objFileResourceEN.LastWriteTime, 20, conFileResource.LastWriteTime);
clsCheckSql.CheckFieldLen(objFileResourceEN.CheckDateTime, 30, conFileResource.CheckDateTime);
clsCheckSql.CheckFieldLen(objFileResourceEN.IdFtpResource, 8, conFileResource.IdFtpResource);
clsCheckSql.CheckFieldLen(objFileResourceEN.UpdDate, 20, conFileResource.UpdDate);
clsCheckSql.CheckFieldLen(objFileResourceEN.UpdUser, 20, conFileResource.UpdUser);
clsCheckSql.CheckFieldLen(objFileResourceEN.Memo, 1000, conFileResource.Memo);
//检查字段外键固定长度
 objFileResourceEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFileResourceEN objFileResourceEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFileResourceEN.IpAddress, 50, conFileResource.IpAddress);
clsCheckSql.CheckFieldLen(objFileResourceEN.FileDirName, 200, conFileResource.FileDirName);
clsCheckSql.CheckFieldLen(objFileResourceEN.FileName, 500, conFileResource.FileName);
clsCheckSql.CheckFieldLen(objFileResourceEN.FileNameBak, 500, conFileResource.FileNameBak);
clsCheckSql.CheckFieldLen(objFileResourceEN.Extension, 10, conFileResource.Extension);
clsCheckSql.CheckFieldLen(objFileResourceEN.FileType, 30, conFileResource.FileType);
clsCheckSql.CheckFieldLen(objFileResourceEN.CreationTime, 20, conFileResource.CreationTime);
clsCheckSql.CheckFieldLen(objFileResourceEN.LastWriteTime, 20, conFileResource.LastWriteTime);
clsCheckSql.CheckFieldLen(objFileResourceEN.CheckDateTime, 30, conFileResource.CheckDateTime);
clsCheckSql.CheckFieldLen(objFileResourceEN.IdFtpResource, 8, conFileResource.IdFtpResource);
clsCheckSql.CheckFieldLen(objFileResourceEN.UpdDate, 20, conFileResource.UpdDate);
clsCheckSql.CheckFieldLen(objFileResourceEN.UpdUser, 20, conFileResource.UpdUser);
clsCheckSql.CheckFieldLen(objFileResourceEN.Memo, 1000, conFileResource.Memo);
//检查外键字段长度
 objFileResourceEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFileResourceEN objFileResourceEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFileResourceEN.IpAddress, 50, conFileResource.IpAddress);
clsCheckSql.CheckFieldLen(objFileResourceEN.FileDirName, 200, conFileResource.FileDirName);
clsCheckSql.CheckFieldLen(objFileResourceEN.FileName, 500, conFileResource.FileName);
clsCheckSql.CheckFieldLen(objFileResourceEN.FileNameBak, 500, conFileResource.FileNameBak);
clsCheckSql.CheckFieldLen(objFileResourceEN.Extension, 10, conFileResource.Extension);
clsCheckSql.CheckFieldLen(objFileResourceEN.FileType, 30, conFileResource.FileType);
clsCheckSql.CheckFieldLen(objFileResourceEN.CreationTime, 20, conFileResource.CreationTime);
clsCheckSql.CheckFieldLen(objFileResourceEN.LastWriteTime, 20, conFileResource.LastWriteTime);
clsCheckSql.CheckFieldLen(objFileResourceEN.CheckDateTime, 30, conFileResource.CheckDateTime);
clsCheckSql.CheckFieldLen(objFileResourceEN.IdFtpResource, 8, conFileResource.IdFtpResource);
clsCheckSql.CheckFieldLen(objFileResourceEN.UpdDate, 20, conFileResource.UpdDate);
clsCheckSql.CheckFieldLen(objFileResourceEN.UpdUser, 20, conFileResource.UpdUser);
clsCheckSql.CheckFieldLen(objFileResourceEN.Memo, 1000, conFileResource.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFileResourceEN.IpAddress, conFileResource.IpAddress);
clsCheckSql.CheckSqlInjection4Field(objFileResourceEN.FileDirName, conFileResource.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objFileResourceEN.FileName, conFileResource.FileName);
clsCheckSql.CheckSqlInjection4Field(objFileResourceEN.FileNameBak, conFileResource.FileNameBak);
clsCheckSql.CheckSqlInjection4Field(objFileResourceEN.Extension, conFileResource.Extension);
clsCheckSql.CheckSqlInjection4Field(objFileResourceEN.FileType, conFileResource.FileType);
clsCheckSql.CheckSqlInjection4Field(objFileResourceEN.CreationTime, conFileResource.CreationTime);
clsCheckSql.CheckSqlInjection4Field(objFileResourceEN.LastWriteTime, conFileResource.LastWriteTime);
clsCheckSql.CheckSqlInjection4Field(objFileResourceEN.CheckDateTime, conFileResource.CheckDateTime);
clsCheckSql.CheckSqlInjection4Field(objFileResourceEN.IdFtpResource, conFileResource.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objFileResourceEN.UpdDate, conFileResource.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objFileResourceEN.UpdUser, conFileResource.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objFileResourceEN.Memo, conFileResource.Memo);
//检查外键字段长度
 objFileResourceEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--FileResource(文件资源),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFileResourceEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsFileResourceEN objFileResourceEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objFileResourceEN.IpAddress == null)
{
 sbCondition.AppendFormat(" and IpAddress is null");
}
else
{
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objFileResourceEN.IpAddress);
}
 sbCondition.AppendFormat(" and FileName = '{0}'", objFileResourceEN.FileName);
return sbCondition.ToString();
}

 #endregion 检查唯一性

 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName, strCondition);
return intRecCount;
}



 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCount()
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFileResourceEN._CurrTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond)
 /// </summary>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCountByCond(string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFileResourceEN._CurrTabName, strCondition);
return intRecCount;
}

 /// <summary>
 /// 功能:获取给定表中的符合条件的某字段的值,以列表返回
 /// (AutoGCLib.DALCode4CSharp:GenGetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>获取的字段值列表</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.DALCode4CSharp:GenfunSetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "varValue">值</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue<T>(string strTabName, string strFldName, T varValue, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFileResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}