
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFtpResourceFileResRelaDA
 表名:vFtpResourceFileResRela(01120376)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:41
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
 /// vFtp资源文件资源关系(vFtpResourceFileResRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFtpResourceFileResRelaDA : clsCommBase4DA
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
 return clsvFtpResourceFileResRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFtpResourceFileResRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFtpResourceFileResRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFtpResourceFileResRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFtpResourceFileResRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFtpResourceFileResRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFtpResourceFileResRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFtpResourceFileResRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFtpResourceFileResRelaDA: GetDataTable_vFtpResourceFileResRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFtpResourceFileResRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFtpResourceFileResRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFtpResourceFileResRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFtpResourceFileResRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFtpResourceFileResRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFtpResourceFileResRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFtpResourceFileResRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFtpResourceFileResRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFtpResourceFileResRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFtpResourceFileResRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFtpResourceFileResRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vFtpResourceFileResRela.* from vFtpResourceFileResRela Left Join {1} on {2} where {3} and vFtpResourceFileResRela.mId not in (Select top {5} vFtpResourceFileResRela.mId from vFtpResourceFileResRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFtpResourceFileResRela where {1} and mId not in (Select top {2} mId from vFtpResourceFileResRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFtpResourceFileResRela where {1} and mId not in (Select top {3} mId from vFtpResourceFileResRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFtpResourceFileResRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vFtpResourceFileResRela.* from vFtpResourceFileResRela Left Join {1} on {2} where {3} and vFtpResourceFileResRela.mId not in (Select top {5} vFtpResourceFileResRela.mId from vFtpResourceFileResRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFtpResourceFileResRela where {1} and mId not in (Select top {2} mId from vFtpResourceFileResRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFtpResourceFileResRela where {1} and mId not in (Select top {3} mId from vFtpResourceFileResRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFtpResourceFileResRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFtpResourceFileResRelaDA:GetObjLst)", objException.Message));
}
List<clsvFtpResourceFileResRelaEN> arrObjLst = new List<clsvFtpResourceFileResRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFtpResourceFileResRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = new clsvFtpResourceFileResRelaEN();
try
{
objvFtpResourceFileResRelaEN.mId = TransNullToInt(objRow[convFtpResourceFileResRela.mId].ToString().Trim()); //mId
objvFtpResourceFileResRelaEN.FileResourceID = TransNullToInt(objRow[convFtpResourceFileResRela.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceFileResRelaEN.IpAddress = objRow[convFtpResourceFileResRela.IpAddress] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IpAddress].ToString().Trim(); //Ip地址
objvFtpResourceFileResRelaEN.FileDirName = objRow[convFtpResourceFileResRela.FileDirName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceFileResRelaEN.FileName = objRow[convFtpResourceFileResRela.FileName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileName].ToString().Trim(); //文件名称
objvFtpResourceFileResRelaEN.FileNameBak = objRow[convFtpResourceFileResRela.FileNameBak] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceFileResRelaEN.Extension = objRow[convFtpResourceFileResRela.Extension] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Extension].ToString().Trim(); //扩展名
objvFtpResourceFileResRelaEN.FileLength = objRow[convFtpResourceFileResRela.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convFtpResourceFileResRela.FileLength].ToString().Trim()); //文件长度
objvFtpResourceFileResRelaEN.FileType = objRow[convFtpResourceFileResRela.FileType] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileType].ToString().Trim(); //文件类型
objvFtpResourceFileResRelaEN.CreationTime = objRow[convFtpResourceFileResRela.CreationTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CreationTime].ToString().Trim(); //建立时间
objvFtpResourceFileResRelaEN.LastWriteTime = objRow[convFtpResourceFileResRela.LastWriteTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.LastWriteTime].ToString().Trim(); //最后修改时间
objvFtpResourceFileResRelaEN.CheckDateTime = objRow[convFtpResourceFileResRela.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceFileResRelaEN.InUse = TransNullToBool(objRow[convFtpResourceFileResRela.InUse].ToString().Trim()); //是否在用
objvFtpResourceFileResRelaEN.IsExistFile = TransNullToBool(objRow[convFtpResourceFileResRela.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceFileResRelaEN.IdFtpResource = objRow[convFtpResourceFileResRela.IdFtpResource] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceFileResRelaEN.FuncModuleId = objRow[convFtpResourceFileResRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceFileResRelaEN.FuncModuleName = objRow[convFtpResourceFileResRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceFileResRelaEN.FuncModuleNameSim = objRow[convFtpResourceFileResRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceFileResRelaEN.OrderNum = objRow[convFtpResourceFileResRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFtpResourceFileResRela.OrderNum].ToString().Trim()); //序号
objvFtpResourceFileResRelaEN.UpdDate = objRow[convFtpResourceFileResRela.UpdDate] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceFileResRelaEN.UpdUser = objRow[convFtpResourceFileResRela.UpdUser] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdUser].ToString().Trim(); //修改人
objvFtpResourceFileResRelaEN.Memo = objRow[convFtpResourceFileResRela.Memo] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFtpResourceFileResRelaDA: GetObjLst)", objException.Message));
}
objvFtpResourceFileResRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFtpResourceFileResRelaEN);
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
public List<clsvFtpResourceFileResRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFtpResourceFileResRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFtpResourceFileResRelaEN> arrObjLst = new List<clsvFtpResourceFileResRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = new clsvFtpResourceFileResRelaEN();
try
{
objvFtpResourceFileResRelaEN.mId = TransNullToInt(objRow[convFtpResourceFileResRela.mId].ToString().Trim()); //mId
objvFtpResourceFileResRelaEN.FileResourceID = TransNullToInt(objRow[convFtpResourceFileResRela.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceFileResRelaEN.IpAddress = objRow[convFtpResourceFileResRela.IpAddress] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IpAddress].ToString().Trim(); //Ip地址
objvFtpResourceFileResRelaEN.FileDirName = objRow[convFtpResourceFileResRela.FileDirName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceFileResRelaEN.FileName = objRow[convFtpResourceFileResRela.FileName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileName].ToString().Trim(); //文件名称
objvFtpResourceFileResRelaEN.FileNameBak = objRow[convFtpResourceFileResRela.FileNameBak] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceFileResRelaEN.Extension = objRow[convFtpResourceFileResRela.Extension] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Extension].ToString().Trim(); //扩展名
objvFtpResourceFileResRelaEN.FileLength = objRow[convFtpResourceFileResRela.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convFtpResourceFileResRela.FileLength].ToString().Trim()); //文件长度
objvFtpResourceFileResRelaEN.FileType = objRow[convFtpResourceFileResRela.FileType] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileType].ToString().Trim(); //文件类型
objvFtpResourceFileResRelaEN.CreationTime = objRow[convFtpResourceFileResRela.CreationTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CreationTime].ToString().Trim(); //建立时间
objvFtpResourceFileResRelaEN.LastWriteTime = objRow[convFtpResourceFileResRela.LastWriteTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.LastWriteTime].ToString().Trim(); //最后修改时间
objvFtpResourceFileResRelaEN.CheckDateTime = objRow[convFtpResourceFileResRela.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceFileResRelaEN.InUse = TransNullToBool(objRow[convFtpResourceFileResRela.InUse].ToString().Trim()); //是否在用
objvFtpResourceFileResRelaEN.IsExistFile = TransNullToBool(objRow[convFtpResourceFileResRela.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceFileResRelaEN.IdFtpResource = objRow[convFtpResourceFileResRela.IdFtpResource] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceFileResRelaEN.FuncModuleId = objRow[convFtpResourceFileResRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceFileResRelaEN.FuncModuleName = objRow[convFtpResourceFileResRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceFileResRelaEN.FuncModuleNameSim = objRow[convFtpResourceFileResRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceFileResRelaEN.OrderNum = objRow[convFtpResourceFileResRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFtpResourceFileResRela.OrderNum].ToString().Trim()); //序号
objvFtpResourceFileResRelaEN.UpdDate = objRow[convFtpResourceFileResRela.UpdDate] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceFileResRelaEN.UpdUser = objRow[convFtpResourceFileResRela.UpdUser] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdUser].ToString().Trim(); //修改人
objvFtpResourceFileResRelaEN.Memo = objRow[convFtpResourceFileResRela.Memo] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFtpResourceFileResRelaDA: GetObjLst)", objException.Message));
}
objvFtpResourceFileResRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFtpResourceFileResRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFtpResourceFileResRela(ref clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFtpResourceFileResRela where mId = " + ""+ objvFtpResourceFileResRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFtpResourceFileResRelaEN.mId = TransNullToInt(objDT.Rows[0][convFtpResourceFileResRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvFtpResourceFileResRelaEN.FileResourceID = TransNullToInt(objDT.Rows[0][convFtpResourceFileResRela.FileResourceID].ToString().Trim()); //FileResourceID(字段类型:bigint,字段长度:8,是否可空:False)
 objvFtpResourceFileResRelaEN.IpAddress = objDT.Rows[0][convFtpResourceFileResRela.IpAddress].ToString().Trim(); //Ip地址(字段类型:varchar,字段长度:50,是否可空:True)
 objvFtpResourceFileResRelaEN.FileDirName = objDT.Rows[0][convFtpResourceFileResRela.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFtpResourceFileResRelaEN.FileName = objDT.Rows[0][convFtpResourceFileResRela.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvFtpResourceFileResRelaEN.FileNameBak = objDT.Rows[0][convFtpResourceFileResRela.FileNameBak].ToString().Trim(); //FileName_Bak(字段类型:varchar,字段长度:500,是否可空:True)
 objvFtpResourceFileResRelaEN.Extension = objDT.Rows[0][convFtpResourceFileResRela.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:10,是否可空:True)
 objvFtpResourceFileResRelaEN.FileLength = TransNullToInt(objDT.Rows[0][convFtpResourceFileResRela.FileLength].ToString().Trim()); //文件长度(字段类型:bigint,字段长度:8,是否可空:True)
 objvFtpResourceFileResRelaEN.FileType = objDT.Rows[0][convFtpResourceFileResRela.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvFtpResourceFileResRelaEN.CreationTime = objDT.Rows[0][convFtpResourceFileResRela.CreationTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvFtpResourceFileResRelaEN.LastWriteTime = objDT.Rows[0][convFtpResourceFileResRela.LastWriteTime].ToString().Trim(); //最后修改时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvFtpResourceFileResRelaEN.CheckDateTime = objDT.Rows[0][convFtpResourceFileResRela.CheckDateTime].ToString().Trim(); //CheckDateTime(字段类型:varchar,字段长度:30,是否可空:True)
 objvFtpResourceFileResRelaEN.InUse = TransNullToBool(objDT.Rows[0][convFtpResourceFileResRela.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvFtpResourceFileResRelaEN.IsExistFile = TransNullToBool(objDT.Rows[0][convFtpResourceFileResRela.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvFtpResourceFileResRelaEN.IdFtpResource = objDT.Rows[0][convFtpResourceFileResRela.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvFtpResourceFileResRelaEN.FuncModuleId = objDT.Rows[0][convFtpResourceFileResRela.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvFtpResourceFileResRelaEN.FuncModuleName = objDT.Rows[0][convFtpResourceFileResRela.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFtpResourceFileResRelaEN.FuncModuleNameSim = objDT.Rows[0][convFtpResourceFileResRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvFtpResourceFileResRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convFtpResourceFileResRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvFtpResourceFileResRelaEN.UpdDate = objDT.Rows[0][convFtpResourceFileResRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFtpResourceFileResRelaEN.UpdUser = objDT.Rows[0][convFtpResourceFileResRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvFtpResourceFileResRelaEN.Memo = objDT.Rows[0][convFtpResourceFileResRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFtpResourceFileResRelaDA: GetvFtpResourceFileResRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFtpResourceFileResRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFtpResourceFileResRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = new clsvFtpResourceFileResRelaEN();
try
{
 objvFtpResourceFileResRelaEN.mId = Int32.Parse(objRow[convFtpResourceFileResRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvFtpResourceFileResRelaEN.FileResourceID = Int32.Parse(objRow[convFtpResourceFileResRela.FileResourceID].ToString().Trim()); //FileResourceID(字段类型:bigint,字段长度:8,是否可空:False)
 objvFtpResourceFileResRelaEN.IpAddress = objRow[convFtpResourceFileResRela.IpAddress] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IpAddress].ToString().Trim(); //Ip地址(字段类型:varchar,字段长度:50,是否可空:True)
 objvFtpResourceFileResRelaEN.FileDirName = objRow[convFtpResourceFileResRela.FileDirName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFtpResourceFileResRelaEN.FileName = objRow[convFtpResourceFileResRela.FileName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvFtpResourceFileResRelaEN.FileNameBak = objRow[convFtpResourceFileResRela.FileNameBak] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileNameBak].ToString().Trim(); //FileName_Bak(字段类型:varchar,字段长度:500,是否可空:True)
 objvFtpResourceFileResRelaEN.Extension = objRow[convFtpResourceFileResRela.Extension] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:10,是否可空:True)
 objvFtpResourceFileResRelaEN.FileLength = objRow[convFtpResourceFileResRela.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.FileLength].ToString().Trim()); //文件长度(字段类型:bigint,字段长度:8,是否可空:True)
 objvFtpResourceFileResRelaEN.FileType = objRow[convFtpResourceFileResRela.FileType] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvFtpResourceFileResRelaEN.CreationTime = objRow[convFtpResourceFileResRela.CreationTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CreationTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvFtpResourceFileResRelaEN.LastWriteTime = objRow[convFtpResourceFileResRela.LastWriteTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.LastWriteTime].ToString().Trim(); //最后修改时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvFtpResourceFileResRelaEN.CheckDateTime = objRow[convFtpResourceFileResRela.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CheckDateTime].ToString().Trim(); //CheckDateTime(字段类型:varchar,字段长度:30,是否可空:True)
 objvFtpResourceFileResRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvFtpResourceFileResRelaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvFtpResourceFileResRelaEN.IdFtpResource = objRow[convFtpResourceFileResRela.IdFtpResource] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvFtpResourceFileResRelaEN.FuncModuleId = objRow[convFtpResourceFileResRela.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvFtpResourceFileResRelaEN.FuncModuleName = objRow[convFtpResourceFileResRela.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFtpResourceFileResRelaEN.FuncModuleNameSim = objRow[convFtpResourceFileResRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvFtpResourceFileResRelaEN.OrderNum = objRow[convFtpResourceFileResRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvFtpResourceFileResRelaEN.UpdDate = objRow[convFtpResourceFileResRela.UpdDate] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFtpResourceFileResRelaEN.UpdUser = objRow[convFtpResourceFileResRela.UpdUser] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvFtpResourceFileResRelaEN.Memo = objRow[convFtpResourceFileResRela.Memo] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFtpResourceFileResRelaDA: GetObjBymId)", objException.Message));
}
return objvFtpResourceFileResRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFtpResourceFileResRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFtpResourceFileResRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFtpResourceFileResRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = new clsvFtpResourceFileResRelaEN()
{
mId = TransNullToInt(objRow[convFtpResourceFileResRela.mId].ToString().Trim()), //mId
FileResourceID = TransNullToInt(objRow[convFtpResourceFileResRela.FileResourceID].ToString().Trim()), //FileResourceID
IpAddress = objRow[convFtpResourceFileResRela.IpAddress] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IpAddress].ToString().Trim(), //Ip地址
FileDirName = objRow[convFtpResourceFileResRela.FileDirName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileDirName].ToString().Trim(), //文件目录名
FileName = objRow[convFtpResourceFileResRela.FileName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileName].ToString().Trim(), //文件名称
FileNameBak = objRow[convFtpResourceFileResRela.FileNameBak] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileNameBak].ToString().Trim(), //FileName_Bak
Extension = objRow[convFtpResourceFileResRela.Extension] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Extension].ToString().Trim(), //扩展名
FileLength = objRow[convFtpResourceFileResRela.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convFtpResourceFileResRela.FileLength].ToString().Trim()), //文件长度
FileType = objRow[convFtpResourceFileResRela.FileType] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileType].ToString().Trim(), //文件类型
CreationTime = objRow[convFtpResourceFileResRela.CreationTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CreationTime].ToString().Trim(), //建立时间
LastWriteTime = objRow[convFtpResourceFileResRela.LastWriteTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.LastWriteTime].ToString().Trim(), //最后修改时间
CheckDateTime = objRow[convFtpResourceFileResRela.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CheckDateTime].ToString().Trim(), //CheckDateTime
InUse = TransNullToBool(objRow[convFtpResourceFileResRela.InUse].ToString().Trim()), //是否在用
IsExistFile = TransNullToBool(objRow[convFtpResourceFileResRela.IsExistFile].ToString().Trim()), //是否存在文件
IdFtpResource = objRow[convFtpResourceFileResRela.IdFtpResource] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IdFtpResource].ToString().Trim(), //FTP资源流水号
FuncModuleId = objRow[convFtpResourceFileResRela.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convFtpResourceFileResRela.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleNameSim = objRow[convFtpResourceFileResRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FuncModuleNameSim].ToString().Trim(), //功能模块简称
OrderNum = objRow[convFtpResourceFileResRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFtpResourceFileResRela.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convFtpResourceFileResRela.UpdDate] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFtpResourceFileResRela.UpdUser] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convFtpResourceFileResRela.Memo] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Memo].ToString().Trim() //备注
};
objvFtpResourceFileResRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFtpResourceFileResRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFtpResourceFileResRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFtpResourceFileResRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = new clsvFtpResourceFileResRelaEN();
try
{
objvFtpResourceFileResRelaEN.mId = TransNullToInt(objRow[convFtpResourceFileResRela.mId].ToString().Trim()); //mId
objvFtpResourceFileResRelaEN.FileResourceID = TransNullToInt(objRow[convFtpResourceFileResRela.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceFileResRelaEN.IpAddress = objRow[convFtpResourceFileResRela.IpAddress] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IpAddress].ToString().Trim(); //Ip地址
objvFtpResourceFileResRelaEN.FileDirName = objRow[convFtpResourceFileResRela.FileDirName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceFileResRelaEN.FileName = objRow[convFtpResourceFileResRela.FileName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileName].ToString().Trim(); //文件名称
objvFtpResourceFileResRelaEN.FileNameBak = objRow[convFtpResourceFileResRela.FileNameBak] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceFileResRelaEN.Extension = objRow[convFtpResourceFileResRela.Extension] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Extension].ToString().Trim(); //扩展名
objvFtpResourceFileResRelaEN.FileLength = objRow[convFtpResourceFileResRela.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convFtpResourceFileResRela.FileLength].ToString().Trim()); //文件长度
objvFtpResourceFileResRelaEN.FileType = objRow[convFtpResourceFileResRela.FileType] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileType].ToString().Trim(); //文件类型
objvFtpResourceFileResRelaEN.CreationTime = objRow[convFtpResourceFileResRela.CreationTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CreationTime].ToString().Trim(); //建立时间
objvFtpResourceFileResRelaEN.LastWriteTime = objRow[convFtpResourceFileResRela.LastWriteTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.LastWriteTime].ToString().Trim(); //最后修改时间
objvFtpResourceFileResRelaEN.CheckDateTime = objRow[convFtpResourceFileResRela.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceFileResRelaEN.InUse = TransNullToBool(objRow[convFtpResourceFileResRela.InUse].ToString().Trim()); //是否在用
objvFtpResourceFileResRelaEN.IsExistFile = TransNullToBool(objRow[convFtpResourceFileResRela.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceFileResRelaEN.IdFtpResource = objRow[convFtpResourceFileResRela.IdFtpResource] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceFileResRelaEN.FuncModuleId = objRow[convFtpResourceFileResRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceFileResRelaEN.FuncModuleName = objRow[convFtpResourceFileResRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceFileResRelaEN.FuncModuleNameSim = objRow[convFtpResourceFileResRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceFileResRelaEN.OrderNum = objRow[convFtpResourceFileResRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFtpResourceFileResRela.OrderNum].ToString().Trim()); //序号
objvFtpResourceFileResRelaEN.UpdDate = objRow[convFtpResourceFileResRela.UpdDate] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceFileResRelaEN.UpdUser = objRow[convFtpResourceFileResRela.UpdUser] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdUser].ToString().Trim(); //修改人
objvFtpResourceFileResRelaEN.Memo = objRow[convFtpResourceFileResRela.Memo] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFtpResourceFileResRelaDA: GetObjByDataRowvFtpResourceFileResRela)", objException.Message));
}
objvFtpResourceFileResRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFtpResourceFileResRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFtpResourceFileResRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = new clsvFtpResourceFileResRelaEN();
try
{
objvFtpResourceFileResRelaEN.mId = TransNullToInt(objRow[convFtpResourceFileResRela.mId].ToString().Trim()); //mId
objvFtpResourceFileResRelaEN.FileResourceID = TransNullToInt(objRow[convFtpResourceFileResRela.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceFileResRelaEN.IpAddress = objRow[convFtpResourceFileResRela.IpAddress] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IpAddress].ToString().Trim(); //Ip地址
objvFtpResourceFileResRelaEN.FileDirName = objRow[convFtpResourceFileResRela.FileDirName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceFileResRelaEN.FileName = objRow[convFtpResourceFileResRela.FileName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileName].ToString().Trim(); //文件名称
objvFtpResourceFileResRelaEN.FileNameBak = objRow[convFtpResourceFileResRela.FileNameBak] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceFileResRelaEN.Extension = objRow[convFtpResourceFileResRela.Extension] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Extension].ToString().Trim(); //扩展名
objvFtpResourceFileResRelaEN.FileLength = objRow[convFtpResourceFileResRela.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convFtpResourceFileResRela.FileLength].ToString().Trim()); //文件长度
objvFtpResourceFileResRelaEN.FileType = objRow[convFtpResourceFileResRela.FileType] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileType].ToString().Trim(); //文件类型
objvFtpResourceFileResRelaEN.CreationTime = objRow[convFtpResourceFileResRela.CreationTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CreationTime].ToString().Trim(); //建立时间
objvFtpResourceFileResRelaEN.LastWriteTime = objRow[convFtpResourceFileResRela.LastWriteTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.LastWriteTime].ToString().Trim(); //最后修改时间
objvFtpResourceFileResRelaEN.CheckDateTime = objRow[convFtpResourceFileResRela.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceFileResRelaEN.InUse = TransNullToBool(objRow[convFtpResourceFileResRela.InUse].ToString().Trim()); //是否在用
objvFtpResourceFileResRelaEN.IsExistFile = TransNullToBool(objRow[convFtpResourceFileResRela.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceFileResRelaEN.IdFtpResource = objRow[convFtpResourceFileResRela.IdFtpResource] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceFileResRelaEN.FuncModuleId = objRow[convFtpResourceFileResRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceFileResRelaEN.FuncModuleName = objRow[convFtpResourceFileResRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceFileResRelaEN.FuncModuleNameSim = objRow[convFtpResourceFileResRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceFileResRelaEN.OrderNum = objRow[convFtpResourceFileResRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFtpResourceFileResRela.OrderNum].ToString().Trim()); //序号
objvFtpResourceFileResRelaEN.UpdDate = objRow[convFtpResourceFileResRela.UpdDate] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceFileResRelaEN.UpdUser = objRow[convFtpResourceFileResRela.UpdUser] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdUser].ToString().Trim(); //修改人
objvFtpResourceFileResRelaEN.Memo = objRow[convFtpResourceFileResRela.Memo] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFtpResourceFileResRelaDA: GetObjByDataRow)", objException.Message));
}
objvFtpResourceFileResRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFtpResourceFileResRelaEN;
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
objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFtpResourceFileResRelaEN._CurrTabName, convFtpResourceFileResRela.mId, 8, "");
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
objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFtpResourceFileResRelaEN._CurrTabName, convFtpResourceFileResRela.mId, 8, strPrefix);
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
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vFtpResourceFileResRela where " + strCondition;
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
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vFtpResourceFileResRela where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFtpResourceFileResRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFtpResourceFileResRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFtpResourceFileResRela", strCondition))
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
objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFtpResourceFileResRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaENS">源对象</param>
 /// <param name = "objvFtpResourceFileResRelaENT">目标对象</param>
public void CopyTo(clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaENS, clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaENT)
{
objvFtpResourceFileResRelaENT.mId = objvFtpResourceFileResRelaENS.mId; //mId
objvFtpResourceFileResRelaENT.FileResourceID = objvFtpResourceFileResRelaENS.FileResourceID; //FileResourceID
objvFtpResourceFileResRelaENT.IpAddress = objvFtpResourceFileResRelaENS.IpAddress; //Ip地址
objvFtpResourceFileResRelaENT.FileDirName = objvFtpResourceFileResRelaENS.FileDirName; //文件目录名
objvFtpResourceFileResRelaENT.FileName = objvFtpResourceFileResRelaENS.FileName; //文件名称
objvFtpResourceFileResRelaENT.FileNameBak = objvFtpResourceFileResRelaENS.FileNameBak; //FileName_Bak
objvFtpResourceFileResRelaENT.Extension = objvFtpResourceFileResRelaENS.Extension; //扩展名
objvFtpResourceFileResRelaENT.FileLength = objvFtpResourceFileResRelaENS.FileLength; //文件长度
objvFtpResourceFileResRelaENT.FileType = objvFtpResourceFileResRelaENS.FileType; //文件类型
objvFtpResourceFileResRelaENT.CreationTime = objvFtpResourceFileResRelaENS.CreationTime; //建立时间
objvFtpResourceFileResRelaENT.LastWriteTime = objvFtpResourceFileResRelaENS.LastWriteTime; //最后修改时间
objvFtpResourceFileResRelaENT.CheckDateTime = objvFtpResourceFileResRelaENS.CheckDateTime; //CheckDateTime
objvFtpResourceFileResRelaENT.InUse = objvFtpResourceFileResRelaENS.InUse; //是否在用
objvFtpResourceFileResRelaENT.IsExistFile = objvFtpResourceFileResRelaENS.IsExistFile; //是否存在文件
objvFtpResourceFileResRelaENT.IdFtpResource = objvFtpResourceFileResRelaENS.IdFtpResource; //FTP资源流水号
objvFtpResourceFileResRelaENT.FuncModuleId = objvFtpResourceFileResRelaENS.FuncModuleId; //功能模块Id
objvFtpResourceFileResRelaENT.FuncModuleName = objvFtpResourceFileResRelaENS.FuncModuleName; //功能模块名称
objvFtpResourceFileResRelaENT.FuncModuleNameSim = objvFtpResourceFileResRelaENS.FuncModuleNameSim; //功能模块简称
objvFtpResourceFileResRelaENT.OrderNum = objvFtpResourceFileResRelaENS.OrderNum; //序号
objvFtpResourceFileResRelaENT.UpdDate = objvFtpResourceFileResRelaENS.UpdDate; //修改日期
objvFtpResourceFileResRelaENT.UpdUser = objvFtpResourceFileResRelaENS.UpdUser; //修改人
objvFtpResourceFileResRelaENT.Memo = objvFtpResourceFileResRelaENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFtpResourceFileResRelaEN.IpAddress, 50, convFtpResourceFileResRela.IpAddress);
clsCheckSql.CheckFieldLen(objvFtpResourceFileResRelaEN.FileDirName, 200, convFtpResourceFileResRela.FileDirName);
clsCheckSql.CheckFieldLen(objvFtpResourceFileResRelaEN.FileName, 500, convFtpResourceFileResRela.FileName);
clsCheckSql.CheckFieldLen(objvFtpResourceFileResRelaEN.FileNameBak, 500, convFtpResourceFileResRela.FileNameBak);
clsCheckSql.CheckFieldLen(objvFtpResourceFileResRelaEN.Extension, 10, convFtpResourceFileResRela.Extension);
clsCheckSql.CheckFieldLen(objvFtpResourceFileResRelaEN.FileType, 30, convFtpResourceFileResRela.FileType);
clsCheckSql.CheckFieldLen(objvFtpResourceFileResRelaEN.CreationTime, 20, convFtpResourceFileResRela.CreationTime);
clsCheckSql.CheckFieldLen(objvFtpResourceFileResRelaEN.LastWriteTime, 20, convFtpResourceFileResRela.LastWriteTime);
clsCheckSql.CheckFieldLen(objvFtpResourceFileResRelaEN.CheckDateTime, 30, convFtpResourceFileResRela.CheckDateTime);
clsCheckSql.CheckFieldLen(objvFtpResourceFileResRelaEN.IdFtpResource, 8, convFtpResourceFileResRela.IdFtpResource);
clsCheckSql.CheckFieldLen(objvFtpResourceFileResRelaEN.FuncModuleId, 4, convFtpResourceFileResRela.FuncModuleId);
clsCheckSql.CheckFieldLen(objvFtpResourceFileResRelaEN.FuncModuleName, 30, convFtpResourceFileResRela.FuncModuleName);
clsCheckSql.CheckFieldLen(objvFtpResourceFileResRelaEN.FuncModuleNameSim, 30, convFtpResourceFileResRela.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objvFtpResourceFileResRelaEN.UpdDate, 20, convFtpResourceFileResRela.UpdDate);
clsCheckSql.CheckFieldLen(objvFtpResourceFileResRelaEN.UpdUser, 20, convFtpResourceFileResRela.UpdUser);
clsCheckSql.CheckFieldLen(objvFtpResourceFileResRelaEN.Memo, 1000, convFtpResourceFileResRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceFileResRelaEN.IpAddress, convFtpResourceFileResRela.IpAddress);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceFileResRelaEN.FileDirName, convFtpResourceFileResRela.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceFileResRelaEN.FileName, convFtpResourceFileResRela.FileName);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceFileResRelaEN.FileNameBak, convFtpResourceFileResRela.FileNameBak);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceFileResRelaEN.Extension, convFtpResourceFileResRela.Extension);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceFileResRelaEN.FileType, convFtpResourceFileResRela.FileType);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceFileResRelaEN.CreationTime, convFtpResourceFileResRela.CreationTime);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceFileResRelaEN.LastWriteTime, convFtpResourceFileResRela.LastWriteTime);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceFileResRelaEN.CheckDateTime, convFtpResourceFileResRela.CheckDateTime);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceFileResRelaEN.IdFtpResource, convFtpResourceFileResRela.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceFileResRelaEN.FuncModuleId, convFtpResourceFileResRela.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceFileResRelaEN.FuncModuleName, convFtpResourceFileResRela.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceFileResRelaEN.FuncModuleNameSim, convFtpResourceFileResRela.FuncModuleNameSim);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceFileResRelaEN.UpdDate, convFtpResourceFileResRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceFileResRelaEN.UpdUser, convFtpResourceFileResRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceFileResRelaEN.Memo, convFtpResourceFileResRela.Memo);
//检查外键字段长度
 objvFtpResourceFileResRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

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
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
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
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
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
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFtpResourceFileResRelaEN._CurrTabName);
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
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFtpResourceFileResRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvFtpResourceFileResRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}