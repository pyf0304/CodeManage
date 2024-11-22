
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFtpResourceDA
 表名:vFtpResource(01120500)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:38
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
 /// vFTP资源(vFtpResource)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFtpResourceDA : clsCommBase4DA
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
 return clsvFtpResourceEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFtpResourceEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFtpResourceEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFtpResourceEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFtpResourceEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdFtpResource">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdFtpResource)
{
strIdFtpResource = strIdFtpResource.Replace("'", "''");
if (strIdFtpResource.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vFtpResource中,检查关键字,长度不正确!(clsvFtpResourceDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdFtpResource)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vFtpResource中,关键字不能为空 或 null!(clsvFtpResourceDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdFtpResource);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvFtpResourceDA:CheckPrimaryKey)", objException.Message));
}
return true;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFtpResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFtpResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFtpResource(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFtpResourceDA: GetDataTable_vFtpResource)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFtpResource where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFtpResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFtpResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFtpResource where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFtpResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFtpResourceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFtpResource where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFtpResource where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFtpResourceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFtpResource where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFtpResourceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vFtpResource.* from vFtpResource Left Join {1} on {2} where {3} and vFtpResource.IdFtpResource not in (Select top {5} vFtpResource.IdFtpResource from vFtpResource Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFtpResource where {1} and IdFtpResource not in (Select top {2} IdFtpResource from vFtpResource where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFtpResource where {1} and IdFtpResource not in (Select top {3} IdFtpResource from vFtpResource where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFtpResourceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vFtpResource.* from vFtpResource Left Join {1} on {2} where {3} and vFtpResource.IdFtpResource not in (Select top {5} vFtpResource.IdFtpResource from vFtpResource Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFtpResource where {1} and IdFtpResource not in (Select top {2} IdFtpResource from vFtpResource where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFtpResource where {1} and IdFtpResource not in (Select top {3} IdFtpResource from vFtpResource where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFtpResourceEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFtpResourceDA:GetObjLst)", objException.Message));
}
List<clsvFtpResourceEN> arrObjLst = new List<clsvFtpResourceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFtpResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceEN objvFtpResourceEN = new clsvFtpResourceEN();
try
{
objvFtpResourceEN.IdFtpResource = objRow[convFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceEN.FtpResourceID = objRow[convFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvFtpResourceEN.FileOriginalName = objRow[convFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[convFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objvFtpResourceEN.FileDirName = objRow[convFtpResource.FileDirName] == DBNull.Value ? null : objRow[convFtpResource.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceEN.FileRename = objRow[convFtpResource.FileRename] == DBNull.Value ? null : objRow[convFtpResource.FileRename].ToString().Trim(); //文件新名
objvFtpResourceEN.FileNameBak = objRow[convFtpResource.FileNameBak] == DBNull.Value ? null : objRow[convFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceEN.FileUpDate = objRow[convFtpResource.FileUpDate] == DBNull.Value ? null : objRow[convFtpResource.FileUpDate].ToString().Trim(); //创建日期
objvFtpResourceEN.FileUpTime = objRow[convFtpResource.FileUpTime] == DBNull.Value ? null : objRow[convFtpResource.FileUpTime].ToString().Trim(); //创建时间
objvFtpResourceEN.FileSize = objRow[convFtpResource.FileSize] == DBNull.Value ? null : objRow[convFtpResource.FileSize].ToString().Trim(); //文件大小
objvFtpResourceEN.FileType = objRow[convFtpResource.FileType] == DBNull.Value ? null : objRow[convFtpResource.FileType].ToString().Trim(); //文件类型
objvFtpResourceEN.FuncModuleId = objRow[convFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceEN.FuncModuleName = objRow[convFtpResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceEN.FuncModuleNameSim = objRow[convFtpResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceEN.OrderNum = objRow[convFtpResource.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFtpResource.OrderNum].ToString().Trim()); //序号
objvFtpResourceEN.CheckDateTime = objRow[convFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceEN.ResourceOwner = objRow[convFtpResource.ResourceOwner].ToString().Trim(); //上传者
objvFtpResourceEN.IsExistFile = TransNullToBool(objRow[convFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceEN.FileResourceID = TransNullToInt(objRow[convFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceEN.UpdDate = objRow[convFtpResource.UpdDate] == DBNull.Value ? null : objRow[convFtpResource.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceEN.UpdUser = objRow[convFtpResource.UpdUser] == DBNull.Value ? null : objRow[convFtpResource.UpdUser].ToString().Trim(); //修改人
objvFtpResourceEN.Memo = objRow[convFtpResource.Memo] == DBNull.Value ? null : objRow[convFtpResource.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFtpResourceDA: GetObjLst)", objException.Message));
}
objvFtpResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFtpResourceEN);
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
public List<clsvFtpResourceEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFtpResourceDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFtpResourceEN> arrObjLst = new List<clsvFtpResourceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceEN objvFtpResourceEN = new clsvFtpResourceEN();
try
{
objvFtpResourceEN.IdFtpResource = objRow[convFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceEN.FtpResourceID = objRow[convFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvFtpResourceEN.FileOriginalName = objRow[convFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[convFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objvFtpResourceEN.FileDirName = objRow[convFtpResource.FileDirName] == DBNull.Value ? null : objRow[convFtpResource.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceEN.FileRename = objRow[convFtpResource.FileRename] == DBNull.Value ? null : objRow[convFtpResource.FileRename].ToString().Trim(); //文件新名
objvFtpResourceEN.FileNameBak = objRow[convFtpResource.FileNameBak] == DBNull.Value ? null : objRow[convFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceEN.FileUpDate = objRow[convFtpResource.FileUpDate] == DBNull.Value ? null : objRow[convFtpResource.FileUpDate].ToString().Trim(); //创建日期
objvFtpResourceEN.FileUpTime = objRow[convFtpResource.FileUpTime] == DBNull.Value ? null : objRow[convFtpResource.FileUpTime].ToString().Trim(); //创建时间
objvFtpResourceEN.FileSize = objRow[convFtpResource.FileSize] == DBNull.Value ? null : objRow[convFtpResource.FileSize].ToString().Trim(); //文件大小
objvFtpResourceEN.FileType = objRow[convFtpResource.FileType] == DBNull.Value ? null : objRow[convFtpResource.FileType].ToString().Trim(); //文件类型
objvFtpResourceEN.FuncModuleId = objRow[convFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceEN.FuncModuleName = objRow[convFtpResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceEN.FuncModuleNameSim = objRow[convFtpResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceEN.OrderNum = objRow[convFtpResource.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFtpResource.OrderNum].ToString().Trim()); //序号
objvFtpResourceEN.CheckDateTime = objRow[convFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceEN.ResourceOwner = objRow[convFtpResource.ResourceOwner].ToString().Trim(); //上传者
objvFtpResourceEN.IsExistFile = TransNullToBool(objRow[convFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceEN.FileResourceID = TransNullToInt(objRow[convFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceEN.UpdDate = objRow[convFtpResource.UpdDate] == DBNull.Value ? null : objRow[convFtpResource.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceEN.UpdUser = objRow[convFtpResource.UpdUser] == DBNull.Value ? null : objRow[convFtpResource.UpdUser].ToString().Trim(); //修改人
objvFtpResourceEN.Memo = objRow[convFtpResource.Memo] == DBNull.Value ? null : objRow[convFtpResource.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFtpResourceDA: GetObjLst)", objException.Message));
}
objvFtpResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFtpResourceEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFtpResourceEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFtpResource(ref clsvFtpResourceEN objvFtpResourceEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFtpResource where IdFtpResource = " + "'"+ objvFtpResourceEN.IdFtpResource+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFtpResourceEN.IdFtpResource = objDT.Rows[0][convFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvFtpResourceEN.FtpResourceID = objDT.Rows[0][convFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvFtpResourceEN.FileOriginalName = objDT.Rows[0][convFtpResource.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFtpResourceEN.FileDirName = objDT.Rows[0][convFtpResource.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFtpResourceEN.FileRename = objDT.Rows[0][convFtpResource.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFtpResourceEN.FileNameBak = objDT.Rows[0][convFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak(字段类型:varchar,字段长度:500,是否可空:True)
 objvFtpResourceEN.FileUpDate = objDT.Rows[0][convFtpResource.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvFtpResourceEN.FileUpTime = objDT.Rows[0][convFtpResource.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvFtpResourceEN.FileSize = objDT.Rows[0][convFtpResource.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvFtpResourceEN.FileType = objDT.Rows[0][convFtpResource.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvFtpResourceEN.FuncModuleId = objDT.Rows[0][convFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvFtpResourceEN.FuncModuleName = objDT.Rows[0][convFtpResource.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFtpResourceEN.FuncModuleNameSim = objDT.Rows[0][convFtpResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvFtpResourceEN.OrderNum = TransNullToInt(objDT.Rows[0][convFtpResource.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvFtpResourceEN.CheckDateTime = objDT.Rows[0][convFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime(字段类型:varchar,字段长度:30,是否可空:True)
 objvFtpResourceEN.ResourceOwner = objDT.Rows[0][convFtpResource.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvFtpResourceEN.IsExistFile = TransNullToBool(objDT.Rows[0][convFtpResource.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvFtpResourceEN.FileResourceID = TransNullToInt(objDT.Rows[0][convFtpResource.FileResourceID].ToString().Trim()); //FileResourceID(字段类型:bigint,字段长度:8,是否可空:False)
 objvFtpResourceEN.UpdDate = objDT.Rows[0][convFtpResource.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFtpResourceEN.UpdUser = objDT.Rows[0][convFtpResource.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvFtpResourceEN.Memo = objDT.Rows[0][convFtpResource.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFtpResourceDA: GetvFtpResource)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdFtpResource">表关键字</param>
 /// <returns>表对象</returns>
public clsvFtpResourceEN GetObjByIdFtpResource(string strIdFtpResource)
{
CheckPrimaryKey(strIdFtpResource);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFtpResource where IdFtpResource = " + "'"+ strIdFtpResource+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFtpResourceEN objvFtpResourceEN = new clsvFtpResourceEN();
try
{
 objvFtpResourceEN.IdFtpResource = objRow[convFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvFtpResourceEN.FtpResourceID = objRow[convFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvFtpResourceEN.FileOriginalName = objRow[convFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[convFtpResource.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFtpResourceEN.FileDirName = objRow[convFtpResource.FileDirName] == DBNull.Value ? null : objRow[convFtpResource.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFtpResourceEN.FileRename = objRow[convFtpResource.FileRename] == DBNull.Value ? null : objRow[convFtpResource.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFtpResourceEN.FileNameBak = objRow[convFtpResource.FileNameBak] == DBNull.Value ? null : objRow[convFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak(字段类型:varchar,字段长度:500,是否可空:True)
 objvFtpResourceEN.FileUpDate = objRow[convFtpResource.FileUpDate] == DBNull.Value ? null : objRow[convFtpResource.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvFtpResourceEN.FileUpTime = objRow[convFtpResource.FileUpTime] == DBNull.Value ? null : objRow[convFtpResource.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvFtpResourceEN.FileSize = objRow[convFtpResource.FileSize] == DBNull.Value ? null : objRow[convFtpResource.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvFtpResourceEN.FileType = objRow[convFtpResource.FileType] == DBNull.Value ? null : objRow[convFtpResource.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvFtpResourceEN.FuncModuleId = objRow[convFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvFtpResourceEN.FuncModuleName = objRow[convFtpResource.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFtpResourceEN.FuncModuleNameSim = objRow[convFtpResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvFtpResourceEN.OrderNum = objRow[convFtpResource.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResource.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvFtpResourceEN.CheckDateTime = objRow[convFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime(字段类型:varchar,字段长度:30,是否可空:True)
 objvFtpResourceEN.ResourceOwner = objRow[convFtpResource.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvFtpResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResource.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvFtpResourceEN.FileResourceID = Int32.Parse(objRow[convFtpResource.FileResourceID].ToString().Trim()); //FileResourceID(字段类型:bigint,字段长度:8,是否可空:False)
 objvFtpResourceEN.UpdDate = objRow[convFtpResource.UpdDate] == DBNull.Value ? null : objRow[convFtpResource.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFtpResourceEN.UpdUser = objRow[convFtpResource.UpdUser] == DBNull.Value ? null : objRow[convFtpResource.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvFtpResourceEN.Memo = objRow[convFtpResource.Memo] == DBNull.Value ? null : objRow[convFtpResource.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFtpResourceDA: GetObjByIdFtpResource)", objException.Message));
}
return objvFtpResourceEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFtpResourceEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFtpResourceDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
strSQL = "Select * from vFtpResource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFtpResourceEN objvFtpResourceEN = new clsvFtpResourceEN()
{
IdFtpResource = objRow[convFtpResource.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[convFtpResource.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[convFtpResource.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convFtpResource.FileDirName] == DBNull.Value ? null : objRow[convFtpResource.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convFtpResource.FileRename] == DBNull.Value ? null : objRow[convFtpResource.FileRename].ToString().Trim(), //文件新名
FileNameBak = objRow[convFtpResource.FileNameBak] == DBNull.Value ? null : objRow[convFtpResource.FileNameBak].ToString().Trim(), //FileName_Bak
FileUpDate = objRow[convFtpResource.FileUpDate] == DBNull.Value ? null : objRow[convFtpResource.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convFtpResource.FileUpTime] == DBNull.Value ? null : objRow[convFtpResource.FileUpTime].ToString().Trim(), //创建时间
FileSize = objRow[convFtpResource.FileSize] == DBNull.Value ? null : objRow[convFtpResource.FileSize].ToString().Trim(), //文件大小
FileType = objRow[convFtpResource.FileType] == DBNull.Value ? null : objRow[convFtpResource.FileType].ToString().Trim(), //文件类型
FuncModuleId = objRow[convFtpResource.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convFtpResource.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleNameSim = objRow[convFtpResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResource.FuncModuleNameSim].ToString().Trim(), //功能模块简称
OrderNum = objRow[convFtpResource.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFtpResource.OrderNum].ToString().Trim()), //序号
CheckDateTime = objRow[convFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResource.CheckDateTime].ToString().Trim(), //CheckDateTime
ResourceOwner = objRow[convFtpResource.ResourceOwner].ToString().Trim(), //上传者
IsExistFile = TransNullToBool(objRow[convFtpResource.IsExistFile].ToString().Trim()), //是否存在文件
FileResourceID = TransNullToInt(objRow[convFtpResource.FileResourceID].ToString().Trim()), //FileResourceID
UpdDate = objRow[convFtpResource.UpdDate] == DBNull.Value ? null : objRow[convFtpResource.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFtpResource.UpdUser] == DBNull.Value ? null : objRow[convFtpResource.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convFtpResource.Memo] == DBNull.Value ? null : objRow[convFtpResource.Memo].ToString().Trim() //备注
};
objvFtpResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFtpResourceEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFtpResourceDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFtpResourceEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFtpResourceEN objvFtpResourceEN = new clsvFtpResourceEN();
try
{
objvFtpResourceEN.IdFtpResource = objRow[convFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceEN.FtpResourceID = objRow[convFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvFtpResourceEN.FileOriginalName = objRow[convFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[convFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objvFtpResourceEN.FileDirName = objRow[convFtpResource.FileDirName] == DBNull.Value ? null : objRow[convFtpResource.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceEN.FileRename = objRow[convFtpResource.FileRename] == DBNull.Value ? null : objRow[convFtpResource.FileRename].ToString().Trim(); //文件新名
objvFtpResourceEN.FileNameBak = objRow[convFtpResource.FileNameBak] == DBNull.Value ? null : objRow[convFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceEN.FileUpDate = objRow[convFtpResource.FileUpDate] == DBNull.Value ? null : objRow[convFtpResource.FileUpDate].ToString().Trim(); //创建日期
objvFtpResourceEN.FileUpTime = objRow[convFtpResource.FileUpTime] == DBNull.Value ? null : objRow[convFtpResource.FileUpTime].ToString().Trim(); //创建时间
objvFtpResourceEN.FileSize = objRow[convFtpResource.FileSize] == DBNull.Value ? null : objRow[convFtpResource.FileSize].ToString().Trim(); //文件大小
objvFtpResourceEN.FileType = objRow[convFtpResource.FileType] == DBNull.Value ? null : objRow[convFtpResource.FileType].ToString().Trim(); //文件类型
objvFtpResourceEN.FuncModuleId = objRow[convFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceEN.FuncModuleName = objRow[convFtpResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceEN.FuncModuleNameSim = objRow[convFtpResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceEN.OrderNum = objRow[convFtpResource.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFtpResource.OrderNum].ToString().Trim()); //序号
objvFtpResourceEN.CheckDateTime = objRow[convFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceEN.ResourceOwner = objRow[convFtpResource.ResourceOwner].ToString().Trim(); //上传者
objvFtpResourceEN.IsExistFile = TransNullToBool(objRow[convFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceEN.FileResourceID = TransNullToInt(objRow[convFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceEN.UpdDate = objRow[convFtpResource.UpdDate] == DBNull.Value ? null : objRow[convFtpResource.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceEN.UpdUser = objRow[convFtpResource.UpdUser] == DBNull.Value ? null : objRow[convFtpResource.UpdUser].ToString().Trim(); //修改人
objvFtpResourceEN.Memo = objRow[convFtpResource.Memo] == DBNull.Value ? null : objRow[convFtpResource.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFtpResourceDA: GetObjByDataRowvFtpResource)", objException.Message));
}
objvFtpResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFtpResourceEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFtpResourceEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFtpResourceEN objvFtpResourceEN = new clsvFtpResourceEN();
try
{
objvFtpResourceEN.IdFtpResource = objRow[convFtpResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceEN.FtpResourceID = objRow[convFtpResource.FtpResourceID].ToString().Trim(); //FTP资源ID
objvFtpResourceEN.FileOriginalName = objRow[convFtpResource.FileOriginalName] == DBNull.Value ? null : objRow[convFtpResource.FileOriginalName].ToString().Trim(); //文件原名
objvFtpResourceEN.FileDirName = objRow[convFtpResource.FileDirName] == DBNull.Value ? null : objRow[convFtpResource.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceEN.FileRename = objRow[convFtpResource.FileRename] == DBNull.Value ? null : objRow[convFtpResource.FileRename].ToString().Trim(); //文件新名
objvFtpResourceEN.FileNameBak = objRow[convFtpResource.FileNameBak] == DBNull.Value ? null : objRow[convFtpResource.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceEN.FileUpDate = objRow[convFtpResource.FileUpDate] == DBNull.Value ? null : objRow[convFtpResource.FileUpDate].ToString().Trim(); //创建日期
objvFtpResourceEN.FileUpTime = objRow[convFtpResource.FileUpTime] == DBNull.Value ? null : objRow[convFtpResource.FileUpTime].ToString().Trim(); //创建时间
objvFtpResourceEN.FileSize = objRow[convFtpResource.FileSize] == DBNull.Value ? null : objRow[convFtpResource.FileSize].ToString().Trim(); //文件大小
objvFtpResourceEN.FileType = objRow[convFtpResource.FileType] == DBNull.Value ? null : objRow[convFtpResource.FileType].ToString().Trim(); //文件类型
objvFtpResourceEN.FuncModuleId = objRow[convFtpResource.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceEN.FuncModuleName = objRow[convFtpResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceEN.FuncModuleNameSim = objRow[convFtpResource.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResource.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceEN.OrderNum = objRow[convFtpResource.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFtpResource.OrderNum].ToString().Trim()); //序号
objvFtpResourceEN.CheckDateTime = objRow[convFtpResource.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceEN.ResourceOwner = objRow[convFtpResource.ResourceOwner].ToString().Trim(); //上传者
objvFtpResourceEN.IsExistFile = TransNullToBool(objRow[convFtpResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceEN.FileResourceID = TransNullToInt(objRow[convFtpResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceEN.UpdDate = objRow[convFtpResource.UpdDate] == DBNull.Value ? null : objRow[convFtpResource.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceEN.UpdUser = objRow[convFtpResource.UpdUser] == DBNull.Value ? null : objRow[convFtpResource.UpdUser].ToString().Trim(); //修改人
objvFtpResourceEN.Memo = objRow[convFtpResource.Memo] == DBNull.Value ? null : objRow[convFtpResource.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFtpResourceDA: GetObjByDataRow)", objException.Message));
}
objvFtpResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFtpResourceEN;
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
objSQL = clsvFtpResourceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFtpResourceEN._CurrTabName, convFtpResource.IdFtpResource, 8, "");
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
objSQL = clsvFtpResourceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFtpResourceEN._CurrTabName, convFtpResource.IdFtpResource, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdFtpResource from vFtpResource where " + strCondition;
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
return "";
}
strKeyValue = objDT.Rows[0][0].ToString();
return strKeyValue;
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
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdFtpResource from vFtpResource where " + strCondition;
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
 /// <param name = "strIdFtpResource">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdFtpResource)
{
CheckPrimaryKey(strIdFtpResource);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFtpResource", "IdFtpResource = " + "'"+ strIdFtpResource+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFtpResourceDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFtpResource", strCondition))
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
objSQL = clsvFtpResourceDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFtpResource");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFtpResourceENS">源对象</param>
 /// <param name = "objvFtpResourceENT">目标对象</param>
public void CopyTo(clsvFtpResourceEN objvFtpResourceENS, clsvFtpResourceEN objvFtpResourceENT)
{
objvFtpResourceENT.IdFtpResource = objvFtpResourceENS.IdFtpResource; //FTP资源流水号
objvFtpResourceENT.FtpResourceID = objvFtpResourceENS.FtpResourceID; //FTP资源ID
objvFtpResourceENT.FileOriginalName = objvFtpResourceENS.FileOriginalName; //文件原名
objvFtpResourceENT.FileDirName = objvFtpResourceENS.FileDirName; //文件目录名
objvFtpResourceENT.FileRename = objvFtpResourceENS.FileRename; //文件新名
objvFtpResourceENT.FileNameBak = objvFtpResourceENS.FileNameBak; //FileName_Bak
objvFtpResourceENT.FileUpDate = objvFtpResourceENS.FileUpDate; //创建日期
objvFtpResourceENT.FileUpTime = objvFtpResourceENS.FileUpTime; //创建时间
objvFtpResourceENT.FileSize = objvFtpResourceENS.FileSize; //文件大小
objvFtpResourceENT.FileType = objvFtpResourceENS.FileType; //文件类型
objvFtpResourceENT.FuncModuleId = objvFtpResourceENS.FuncModuleId; //功能模块Id
objvFtpResourceENT.FuncModuleName = objvFtpResourceENS.FuncModuleName; //功能模块名称
objvFtpResourceENT.FuncModuleNameSim = objvFtpResourceENS.FuncModuleNameSim; //功能模块简称
objvFtpResourceENT.OrderNum = objvFtpResourceENS.OrderNum; //序号
objvFtpResourceENT.CheckDateTime = objvFtpResourceENS.CheckDateTime; //CheckDateTime
objvFtpResourceENT.ResourceOwner = objvFtpResourceENS.ResourceOwner; //上传者
objvFtpResourceENT.IsExistFile = objvFtpResourceENS.IsExistFile; //是否存在文件
objvFtpResourceENT.FileResourceID = objvFtpResourceENS.FileResourceID; //FileResourceID
objvFtpResourceENT.UpdDate = objvFtpResourceENS.UpdDate; //修改日期
objvFtpResourceENT.UpdUser = objvFtpResourceENS.UpdUser; //修改人
objvFtpResourceENT.Memo = objvFtpResourceENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFtpResourceEN objvFtpResourceEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFtpResourceEN.IdFtpResource, 8, convFtpResource.IdFtpResource);
clsCheckSql.CheckFieldLen(objvFtpResourceEN.FtpResourceID, 8, convFtpResource.FtpResourceID);
clsCheckSql.CheckFieldLen(objvFtpResourceEN.FileOriginalName, 200, convFtpResource.FileOriginalName);
clsCheckSql.CheckFieldLen(objvFtpResourceEN.FileDirName, 200, convFtpResource.FileDirName);
clsCheckSql.CheckFieldLen(objvFtpResourceEN.FileRename, 200, convFtpResource.FileRename);
clsCheckSql.CheckFieldLen(objvFtpResourceEN.FileNameBak, 500, convFtpResource.FileNameBak);
clsCheckSql.CheckFieldLen(objvFtpResourceEN.FileUpDate, 8, convFtpResource.FileUpDate);
clsCheckSql.CheckFieldLen(objvFtpResourceEN.FileUpTime, 6, convFtpResource.FileUpTime);
clsCheckSql.CheckFieldLen(objvFtpResourceEN.FileSize, 50, convFtpResource.FileSize);
clsCheckSql.CheckFieldLen(objvFtpResourceEN.FileType, 30, convFtpResource.FileType);
clsCheckSql.CheckFieldLen(objvFtpResourceEN.FuncModuleId, 4, convFtpResource.FuncModuleId);
clsCheckSql.CheckFieldLen(objvFtpResourceEN.FuncModuleName, 30, convFtpResource.FuncModuleName);
clsCheckSql.CheckFieldLen(objvFtpResourceEN.FuncModuleNameSim, 30, convFtpResource.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objvFtpResourceEN.CheckDateTime, 30, convFtpResource.CheckDateTime);
clsCheckSql.CheckFieldLen(objvFtpResourceEN.ResourceOwner, 50, convFtpResource.ResourceOwner);
clsCheckSql.CheckFieldLen(objvFtpResourceEN.UpdDate, 20, convFtpResource.UpdDate);
clsCheckSql.CheckFieldLen(objvFtpResourceEN.UpdUser, 20, convFtpResource.UpdUser);
clsCheckSql.CheckFieldLen(objvFtpResourceEN.Memo, 1000, convFtpResource.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.IdFtpResource, convFtpResource.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.FtpResourceID, convFtpResource.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.FileOriginalName, convFtpResource.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.FileDirName, convFtpResource.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.FileRename, convFtpResource.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.FileNameBak, convFtpResource.FileNameBak);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.FileUpDate, convFtpResource.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.FileUpTime, convFtpResource.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.FileSize, convFtpResource.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.FileType, convFtpResource.FileType);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.FuncModuleId, convFtpResource.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.FuncModuleName, convFtpResource.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.FuncModuleNameSim, convFtpResource.FuncModuleNameSim);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.CheckDateTime, convFtpResource.CheckDateTime);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.ResourceOwner, convFtpResource.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.UpdDate, convFtpResource.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.UpdUser, convFtpResource.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFtpResourceEN.Memo, convFtpResource.Memo);
//检查外键字段长度
 objvFtpResourceEN._IsCheckProperty = true;
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
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
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
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
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
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFtpResourceEN._CurrTabName);
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
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFtpResourceEN._CurrTabName, strCondition);
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
 objSQL = clsvFtpResourceDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}