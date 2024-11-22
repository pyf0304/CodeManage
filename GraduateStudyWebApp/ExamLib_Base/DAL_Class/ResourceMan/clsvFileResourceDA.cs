
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFileResourceDA
 表名:vFileResource(01120374)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:35
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
 /// v文件资源(vFileResource)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFileResourceDA : clsCommBase4DA
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
 return clsvFileResourceEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFileResourceEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFileResourceEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFileResourceEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFileResourceEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFileResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFileResource(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTable_vFileResource)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFileResource where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFileResource where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFileResource where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFileResource where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFileResource where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vFileResource.* from vFileResource Left Join {1} on {2} where {3} and vFileResource.FileResourceID not in (Select top {5} vFileResource.FileResourceID from vFileResource Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFileResource where {1} and FileResourceID not in (Select top {2} FileResourceID from vFileResource where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFileResource where {1} and FileResourceID not in (Select top {3} FileResourceID from vFileResource where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFileResourceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vFileResource.* from vFileResource Left Join {1} on {2} where {3} and vFileResource.FileResourceID not in (Select top {5} vFileResource.FileResourceID from vFileResource Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFileResource where {1} and FileResourceID not in (Select top {2} FileResourceID from vFileResource where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFileResource where {1} and FileResourceID not in (Select top {3} FileResourceID from vFileResource where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFileResourceEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFileResourceDA:GetObjLst)", objException.Message));
}
List<clsvFileResourceEN> arrObjLst = new List<clsvFileResourceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFileResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = TransNullToInt(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //Ip地址
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名称
objvFileResourceEN.FileNameBak = objRow[convFileResource.FileNameBak] == DBNull.Value ? null : objRow[convFileResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //最后修改时间
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = TransNullToBool(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = TransNullToBool(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改人
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //备注
objvFileResourceEN.FtpResourceCount = objRow[convFileResource.FtpResourceCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFileResource.FtpResourceCount].ToString().Trim()); //Ftp资源数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFileResourceDA: GetObjLst)", objException.Message));
}
objvFileResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFileResourceEN);
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
public List<clsvFileResourceEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFileResourceDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFileResourceEN> arrObjLst = new List<clsvFileResourceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = TransNullToInt(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //Ip地址
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名称
objvFileResourceEN.FileNameBak = objRow[convFileResource.FileNameBak] == DBNull.Value ? null : objRow[convFileResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //最后修改时间
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = TransNullToBool(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = TransNullToBool(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改人
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //备注
objvFileResourceEN.FtpResourceCount = objRow[convFileResource.FtpResourceCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFileResource.FtpResourceCount].ToString().Trim()); //Ftp资源数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFileResourceDA: GetObjLst)", objException.Message));
}
objvFileResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFileResourceEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFileResource(ref clsvFileResourceEN objvFileResourceEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFileResource where FileResourceID = " + ""+ objvFileResourceEN.FileResourceID+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFileResourceEN.FileResourceID = TransNullToInt(objDT.Rows[0][convFileResource.FileResourceID].ToString().Trim()); //FileResourceID(字段类型:bigint,字段长度:8,是否可空:False)
 objvFileResourceEN.IpAddress = objDT.Rows[0][convFileResource.IpAddress].ToString().Trim(); //Ip地址(字段类型:varchar,字段长度:50,是否可空:True)
 objvFileResourceEN.FileDirName = objDT.Rows[0][convFileResource.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFileResourceEN.FileName = objDT.Rows[0][convFileResource.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvFileResourceEN.FileNameBak = objDT.Rows[0][convFileResource.FileNameBak].ToString().Trim(); //FileName_Bak(字段类型:varchar,字段长度:500,是否可空:True)
 objvFileResourceEN.Extension = objDT.Rows[0][convFileResource.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:10,是否可空:True)
 objvFileResourceEN.FileLength = TransNullToInt(objDT.Rows[0][convFileResource.FileLength].ToString().Trim()); //文件长度(字段类型:bigint,字段长度:8,是否可空:True)
 objvFileResourceEN.FileType = objDT.Rows[0][convFileResource.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvFileResourceEN.CreationTime = objDT.Rows[0][convFileResource.CreationTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.LastWriteTime = objDT.Rows[0][convFileResource.LastWriteTime].ToString().Trim(); //最后修改时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.CheckDateTime = objDT.Rows[0][convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime(字段类型:varchar,字段长度:30,是否可空:True)
 objvFileResourceEN.InUse = TransNullToBool(objDT.Rows[0][convFileResource.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.IsExistFile = TransNullToBool(objDT.Rows[0][convFileResource.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.UpdDate = objDT.Rows[0][convFileResource.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.UpdUser = objDT.Rows[0][convFileResource.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.Memo = objDT.Rows[0][convFileResource.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFileResourceEN.FtpResourceCount = TransNullToInt(objDT.Rows[0][convFileResource.FtpResourceCount].ToString().Trim()); //Ftp资源数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFileResourceDA: GetvFileResource)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngFileResourceID">表关键字</param>
 /// <returns>表对象</returns>
public clsvFileResourceEN GetObjByFileResourceID(long lngFileResourceID)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFileResource where FileResourceID = " + ""+ lngFileResourceID+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
 objvFileResourceEN.FileResourceID = Int32.Parse(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID(字段类型:bigint,字段长度:8,是否可空:False)
 objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //Ip地址(字段类型:varchar,字段长度:50,是否可空:True)
 objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvFileResourceEN.FileNameBak = objRow[convFileResource.FileNameBak] == DBNull.Value ? null : objRow[convFileResource.FileNameBak].ToString().Trim(); //FileName_Bak(字段类型:varchar,字段长度:500,是否可空:True)
 objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名(字段类型:varchar,字段长度:10,是否可空:True)
 objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度(字段类型:bigint,字段长度:8,是否可空:True)
 objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //最后修改时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime(字段类型:varchar,字段长度:30,是否可空:True)
 objvFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFileResourceEN.FtpResourceCount = objRow[convFileResource.FtpResourceCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFileResource.FtpResourceCount].ToString().Trim()); //Ftp资源数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFileResourceDA: GetObjByFileResourceID)", objException.Message));
}
return objvFileResourceEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFileResourceEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFileResourceDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFileResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN()
{
FileResourceID = TransNullToInt(objRow[convFileResource.FileResourceID].ToString().Trim()), //FileResourceID
IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(), //Ip地址
FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(), //文件目录名
FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(), //文件名称
FileNameBak = objRow[convFileResource.FileNameBak] == DBNull.Value ? null : objRow[convFileResource.FileNameBak].ToString().Trim(), //FileName_Bak
Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(), //扩展名
FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convFileResource.FileLength].ToString().Trim()), //文件长度
FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(), //文件类型
CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(), //建立时间
LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(), //最后修改时间
CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(), //CheckDateTime
InUse = TransNullToBool(objRow[convFileResource.InUse].ToString().Trim()), //是否在用
IsExistFile = TransNullToBool(objRow[convFileResource.IsExistFile].ToString().Trim()), //是否存在文件
UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(), //备注
FtpResourceCount = objRow[convFileResource.FtpResourceCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFileResource.FtpResourceCount].ToString().Trim()) //Ftp资源数
};
objvFileResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFileResourceEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFileResourceDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFileResourceEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = TransNullToInt(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //Ip地址
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名称
objvFileResourceEN.FileNameBak = objRow[convFileResource.FileNameBak] == DBNull.Value ? null : objRow[convFileResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //最后修改时间
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = TransNullToBool(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = TransNullToBool(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改人
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //备注
objvFileResourceEN.FtpResourceCount = objRow[convFileResource.FtpResourceCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFileResource.FtpResourceCount].ToString().Trim()); //Ftp资源数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFileResourceDA: GetObjByDataRowvFileResource)", objException.Message));
}
objvFileResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFileResourceEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFileResourceEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = TransNullToInt(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //Ip地址
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名称
objvFileResourceEN.FileNameBak = objRow[convFileResource.FileNameBak] == DBNull.Value ? null : objRow[convFileResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //最后修改时间
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = TransNullToBool(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = TransNullToBool(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改人
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //备注
objvFileResourceEN.FtpResourceCount = objRow[convFileResource.FtpResourceCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFileResource.FtpResourceCount].ToString().Trim()); //Ftp资源数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFileResourceDA: GetObjByDataRow)", objException.Message));
}
objvFileResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFileResourceEN;
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
objSQL = clsvFileResourceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFileResourceEN._CurrTabName, convFileResource.FileResourceID, 8, "");
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
objSQL = clsvFileResourceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFileResourceEN._CurrTabName, convFileResource.FileResourceID, 8, strPrefix);
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
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FileResourceID from vFileResource where " + strCondition;
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
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FileResourceID from vFileResource where " + strCondition;
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
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFileResource", "FileResourceID = " + ""+ lngFileResourceID+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFileResourceDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFileResource", strCondition))
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
objSQL = clsvFileResourceDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFileResource");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFileResourceENS">源对象</param>
 /// <param name = "objvFileResourceENT">目标对象</param>
public void CopyTo(clsvFileResourceEN objvFileResourceENS, clsvFileResourceEN objvFileResourceENT)
{
objvFileResourceENT.FileResourceID = objvFileResourceENS.FileResourceID; //FileResourceID
objvFileResourceENT.IpAddress = objvFileResourceENS.IpAddress; //Ip地址
objvFileResourceENT.FileDirName = objvFileResourceENS.FileDirName; //文件目录名
objvFileResourceENT.FileName = objvFileResourceENS.FileName; //文件名称
objvFileResourceENT.FileNameBak = objvFileResourceENS.FileNameBak; //FileName_Bak
objvFileResourceENT.Extension = objvFileResourceENS.Extension; //扩展名
objvFileResourceENT.FileLength = objvFileResourceENS.FileLength; //文件长度
objvFileResourceENT.FileType = objvFileResourceENS.FileType; //文件类型
objvFileResourceENT.CreationTime = objvFileResourceENS.CreationTime; //建立时间
objvFileResourceENT.LastWriteTime = objvFileResourceENS.LastWriteTime; //最后修改时间
objvFileResourceENT.CheckDateTime = objvFileResourceENS.CheckDateTime; //CheckDateTime
objvFileResourceENT.InUse = objvFileResourceENS.InUse; //是否在用
objvFileResourceENT.IsExistFile = objvFileResourceENS.IsExistFile; //是否存在文件
objvFileResourceENT.UpdDate = objvFileResourceENS.UpdDate; //修改日期
objvFileResourceENT.UpdUser = objvFileResourceENS.UpdUser; //修改人
objvFileResourceENT.Memo = objvFileResourceENS.Memo; //备注
objvFileResourceENT.FtpResourceCount = objvFileResourceENS.FtpResourceCount; //Ftp资源数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFileResourceEN objvFileResourceEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFileResourceEN.IpAddress, 50, convFileResource.IpAddress);
clsCheckSql.CheckFieldLen(objvFileResourceEN.FileDirName, 200, convFileResource.FileDirName);
clsCheckSql.CheckFieldLen(objvFileResourceEN.FileName, 500, convFileResource.FileName);
clsCheckSql.CheckFieldLen(objvFileResourceEN.FileNameBak, 500, convFileResource.FileNameBak);
clsCheckSql.CheckFieldLen(objvFileResourceEN.Extension, 10, convFileResource.Extension);
clsCheckSql.CheckFieldLen(objvFileResourceEN.FileType, 30, convFileResource.FileType);
clsCheckSql.CheckFieldLen(objvFileResourceEN.CreationTime, 20, convFileResource.CreationTime);
clsCheckSql.CheckFieldLen(objvFileResourceEN.LastWriteTime, 20, convFileResource.LastWriteTime);
clsCheckSql.CheckFieldLen(objvFileResourceEN.CheckDateTime, 30, convFileResource.CheckDateTime);
clsCheckSql.CheckFieldLen(objvFileResourceEN.UpdDate, 20, convFileResource.UpdDate);
clsCheckSql.CheckFieldLen(objvFileResourceEN.UpdUser, 20, convFileResource.UpdUser);
clsCheckSql.CheckFieldLen(objvFileResourceEN.Memo, 1000, convFileResource.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.IpAddress, convFileResource.IpAddress);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.FileDirName, convFileResource.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.FileName, convFileResource.FileName);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.FileNameBak, convFileResource.FileNameBak);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.Extension, convFileResource.Extension);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.FileType, convFileResource.FileType);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.CreationTime, convFileResource.CreationTime);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.LastWriteTime, convFileResource.LastWriteTime);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.CheckDateTime, convFileResource.CheckDateTime);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.UpdDate, convFileResource.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.UpdUser, convFileResource.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFileResourceEN.Memo, convFileResource.Memo);
//检查外键字段长度
 objvFileResourceEN._IsCheckProperty = true;
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
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
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
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
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
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFileResourceEN._CurrTabName);
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
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFileResourceEN._CurrTabName, strCondition);
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
 objSQL = clsvFileResourceDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}