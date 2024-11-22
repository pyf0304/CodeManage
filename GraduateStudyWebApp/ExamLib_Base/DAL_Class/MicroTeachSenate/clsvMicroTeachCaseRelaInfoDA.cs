
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroTeachCaseRelaInfoDA
 表名:vMicroTeachCaseRelaInfo(01120319)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:59
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 微格案例相关信息视图(vMicroTeachCaseRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMicroTeachCaseRelaInfoDA : clsCommBase4DA
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
 return clsvMicroTeachCaseRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMicroTeachCaseRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroTeachCaseRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMicroTeachCaseRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMicroTeachCaseRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMicroTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vMicroTeachCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMicroTeachCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMicroTeachCaseRelaInfoDA: GetDataTable_vMicroTeachCaseRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vMicroTeachCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMicroTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMicroTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vMicroTeachCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMicroTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMicroTeachCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroTeachCaseRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroTeachCaseRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMicroTeachCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMicroTeachCaseRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMicroTeachCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroTeachCaseRelaInfo.* from vMicroTeachCaseRelaInfo Left Join {1} on {2} where {3} and vMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo from vMicroTeachCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroTeachCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vMicroTeachCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroTeachCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vMicroTeachCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMicroTeachCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroTeachCaseRelaInfo.* from vMicroTeachCaseRelaInfo Left Join {1} on {2} where {3} and vMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo from vMicroTeachCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroTeachCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vMicroTeachCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroTeachCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vMicroTeachCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMicroTeachCaseRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMicroTeachCaseRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsvMicroTeachCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vMicroTeachCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = new clsvMicroTeachCaseRelaInfoEN();
try
{
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[convMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroTeachCaseRelaInfoEN.FuncModuleName = objRow[convMicroTeachCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoEN.BrowseCount = objRow[convMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMicroTeachCaseRelaInfoEN.ResourceOwner = objRow[convMicroTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMicroTeachCaseRelaInfoEN.ftpFileType = objRow[convMicroTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseRelaInfoEN.ftpFileSize = objRow[convMicroTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroTeachCaseRelaInfoEN.FileOriginName = objRow[convMicroTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMicroTeachCaseRelaInfoEN.IdFile = objRow[convMicroTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMicroTeachCaseRelaInfoEN.FileName = objRow[convMicroTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMicroTeachCaseRelaInfoEN.FileType = objRow[convMicroTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMicroTeachCaseRelaInfoEN.SaveDate = objRow[convMicroTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileSize = objRow[convMicroTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMicroTeachCaseRelaInfoEN.SaveTime = objRow[convMicroTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[convMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = objRow[convMicroTeachCaseRelaInfo.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseRelaInfoEN.IdFtpResource = objRow[convMicroTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroTeachCaseRelaInfoEN.FtpResourceID = objRow[convMicroTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroTeachCaseRelaInfoEN.FileOriginalName = objRow[convMicroTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMicroTeachCaseRelaInfoEN.FileDirName = objRow[convMicroTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMicroTeachCaseRelaInfoEN.FileRename = objRow[convMicroTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMicroTeachCaseRelaInfoEN.FileUpDate = objRow[convMicroTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileUpTime = objRow[convMicroTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdResource = objRow[convMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMicroTeachCaseRelaInfoEN.ResourceID = objRow[convMicroTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMicroTeachCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convMicroTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMicroTeachCaseRelaInfoEN.IdResourceType = objRow[convMicroTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroTeachCaseRelaInfoEN.ResourceTypeID = objRow[convMicroTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroTeachCaseRelaInfoEN.ResourceTypeName = objRow[convMicroTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroTeachCaseRelaInfoEN.Flag = objRow[convMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMicroTeachCaseRelaInfoEN.FileNewName = objRow[convMicroTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMicroTeachCaseRelaInfoEN.FileOldName = objRow[convMicroTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMicroTeachCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convMicroTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroTeachCaseRelaInfoEN.ResourceName = objRow[convMicroTeachCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvMicroTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseRelaInfoEN.UpdDate = objRow[convMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMicroTeachCaseRelaInfoEN.UpdUser = objRow[convMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMicroTeachCaseRelaInfoEN.Memo = objRow[convMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroTeachCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvMicroTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroTeachCaseRelaInfoEN);
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
public List<clsvMicroTeachCaseRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMicroTeachCaseRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsvMicroTeachCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = new clsvMicroTeachCaseRelaInfoEN();
try
{
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[convMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroTeachCaseRelaInfoEN.FuncModuleName = objRow[convMicroTeachCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoEN.BrowseCount = objRow[convMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMicroTeachCaseRelaInfoEN.ResourceOwner = objRow[convMicroTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMicroTeachCaseRelaInfoEN.ftpFileType = objRow[convMicroTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseRelaInfoEN.ftpFileSize = objRow[convMicroTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroTeachCaseRelaInfoEN.FileOriginName = objRow[convMicroTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMicroTeachCaseRelaInfoEN.IdFile = objRow[convMicroTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMicroTeachCaseRelaInfoEN.FileName = objRow[convMicroTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMicroTeachCaseRelaInfoEN.FileType = objRow[convMicroTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMicroTeachCaseRelaInfoEN.SaveDate = objRow[convMicroTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileSize = objRow[convMicroTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMicroTeachCaseRelaInfoEN.SaveTime = objRow[convMicroTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[convMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = objRow[convMicroTeachCaseRelaInfo.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseRelaInfoEN.IdFtpResource = objRow[convMicroTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroTeachCaseRelaInfoEN.FtpResourceID = objRow[convMicroTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroTeachCaseRelaInfoEN.FileOriginalName = objRow[convMicroTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMicroTeachCaseRelaInfoEN.FileDirName = objRow[convMicroTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMicroTeachCaseRelaInfoEN.FileRename = objRow[convMicroTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMicroTeachCaseRelaInfoEN.FileUpDate = objRow[convMicroTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileUpTime = objRow[convMicroTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdResource = objRow[convMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMicroTeachCaseRelaInfoEN.ResourceID = objRow[convMicroTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMicroTeachCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convMicroTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMicroTeachCaseRelaInfoEN.IdResourceType = objRow[convMicroTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroTeachCaseRelaInfoEN.ResourceTypeID = objRow[convMicroTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroTeachCaseRelaInfoEN.ResourceTypeName = objRow[convMicroTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroTeachCaseRelaInfoEN.Flag = objRow[convMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMicroTeachCaseRelaInfoEN.FileNewName = objRow[convMicroTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMicroTeachCaseRelaInfoEN.FileOldName = objRow[convMicroTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMicroTeachCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convMicroTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroTeachCaseRelaInfoEN.ResourceName = objRow[convMicroTeachCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvMicroTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseRelaInfoEN.UpdDate = objRow[convMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMicroTeachCaseRelaInfoEN.UpdUser = objRow[convMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMicroTeachCaseRelaInfoEN.Memo = objRow[convMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroTeachCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvMicroTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMicroTeachCaseRelaInfo(ref clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vMicroTeachCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objDT.Rows[0][convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.FuncModuleId = objDT.Rows[0][convMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FuncModuleName = objDT.Rows[0][convMicroTeachCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objDT.Rows[0][convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objDT.Rows[0][convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][convMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.ResourceOwner = objDT.Rows[0][convMicroTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.ftpFileType = objDT.Rows[0][convMicroTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.ftpFileSize = objDT.Rows[0][convMicroTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = objDT.Rows[0][convMicroTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileOriginName = objDT.Rows[0][convMicroTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.IdFile = objDT.Rows[0][convMicroTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileName = objDT.Rows[0][convMicroTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileType = objDT.Rows[0][convMicroTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.SaveDate = objDT.Rows[0][convMicroTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileSize = objDT.Rows[0][convMicroTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.SaveTime = objDT.Rows[0][convMicroTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = objDT.Rows[0][convMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = objDT.Rows[0][convMicroTeachCaseRelaInfo.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.IdFtpResource = objDT.Rows[0][convMicroTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FtpResourceID = objDT.Rows[0][convMicroTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.FileOriginalName = objDT.Rows[0][convMicroTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileDirName = objDT.Rows[0][convMicroTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileRename = objDT.Rows[0][convMicroTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileUpDate = objDT.Rows[0][convMicroTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileUpTime = objDT.Rows[0][convMicroTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.IdResource = objDT.Rows[0][convMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.ResourceID = objDT.Rows[0][convMicroTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.SaveMode = TransNullToBool(objDT.Rows[0][convMicroTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.IdResourceType = objDT.Rows[0][convMicroTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.ResourceTypeID = objDT.Rows[0][convMicroTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.ResourceTypeName = objDT.Rows[0][convMicroTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.Flag = objDT.Rows[0][convMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileNewName = objDT.Rows[0][convMicroTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileOldName = objDT.Rows[0][convMicroTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.IsExistFile = TransNullToBool(objDT.Rows[0][convMicroTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.ResourceName = objDT.Rows[0][convMicroTeachCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objDT.Rows[0][convMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.UpdDate = objDT.Rows[0][convMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.UpdUser = objDT.Rows[0][convMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.Memo = objDT.Rows[0][convMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMicroTeachCaseRelaInfoDA: GetvMicroTeachCaseRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsvMicroTeachCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vMicroTeachCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = new clsvMicroTeachCaseRelaInfoEN();
try
{
 objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[convMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FuncModuleName = objRow[convMicroTeachCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.BrowseCount = objRow[convMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.ResourceOwner = objRow[convMicroTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.ftpFileType = objRow[convMicroTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.ftpFileSize = objRow[convMicroTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileOriginName = objRow[convMicroTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.IdFile = objRow[convMicroTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileName = objRow[convMicroTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileType = objRow[convMicroTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.SaveDate = objRow[convMicroTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileSize = objRow[convMicroTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.SaveTime = objRow[convMicroTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[convMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = objRow[convMicroTeachCaseRelaInfo.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.IdFtpResource = objRow[convMicroTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FtpResourceID = objRow[convMicroTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.FileOriginalName = objRow[convMicroTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileDirName = objRow[convMicroTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileRename = objRow[convMicroTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileUpDate = objRow[convMicroTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileUpTime = objRow[convMicroTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.IdResource = objRow[convMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.ResourceID = objRow[convMicroTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.IdResourceType = objRow[convMicroTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.ResourceTypeID = objRow[convMicroTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.ResourceTypeName = objRow[convMicroTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.Flag = objRow[convMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileNewName = objRow[convMicroTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.FileOldName = objRow[convMicroTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.ResourceName = objRow[convMicroTeachCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.UpdDate = objRow[convMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.UpdUser = objRow[convMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroTeachCaseRelaInfoEN.Memo = objRow[convMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMicroTeachCaseRelaInfoDA: GetObjByIdMicroTeachCaseRelaInfo)", objException.Message));
}
return objvMicroTeachCaseRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMicroTeachCaseRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMicroTeachCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vMicroTeachCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = new clsvMicroTeachCaseRelaInfoEN()
{
IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()), //案例相关信息流水号
FuncModuleId = objRow[convMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convMicroTeachCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroTeachCaseRelaInfoType = objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(), //微格案例相关信息类型流水号
MicroTeachCaseRelaInfoTypeName = objRow[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(), //微格案例相关信息类型名称
BrowseCount = objRow[convMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
ResourceOwner = objRow[convMicroTeachCaseRelaInfo.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convMicroTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convMicroTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convMicroTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginName].ToString().Trim(), //原文件名
IdFile = objRow[convMicroTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convMicroTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileName].ToString().Trim(), //文件名称
FileType = objRow[convMicroTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convMicroTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convMicroTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convMicroTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveTime].ToString().Trim(), //创建时间
IdMicroteachCase = objRow[convMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
MicroteachCaseName = objRow[convMicroTeachCaseRelaInfo.MicroteachCaseName].ToString().Trim(), //微格教学案例名称
IdFtpResource = objRow[convMicroTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[convMicroTeachCaseRelaInfo.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convMicroTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convMicroTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convMicroTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convMicroTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convMicroTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpTime].ToString().Trim(), //创建时间
IdResource = objRow[convMicroTeachCaseRelaInfo.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convMicroTeachCaseRelaInfo.ResourceID].ToString().Trim(), //资源ID
SaveMode = TransNullToBool(objRow[convMicroTeachCaseRelaInfo.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convMicroTeachCaseRelaInfo.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convMicroTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convMicroTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(), //资源类型名称
Flag = objRow[convMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Flag].ToString().Trim(), //标志
FileNewName = objRow[convMicroTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convMicroTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOldName].ToString().Trim(), //旧文件名
IsExistFile = TransNullToBool(objRow[convMicroTeachCaseRelaInfo.IsExistFile].ToString().Trim()), //是否存在文件
ResourceName = objRow[convMicroTeachCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ResourceName].ToString().Trim(), //资源名称
IsVisible = TransNullToBool(objRow[convMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()), //是否显示
UpdDate = objRow[convMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Memo].ToString().Trim() //备注
};
objvMicroTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroTeachCaseRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMicroTeachCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMicroTeachCaseRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = new clsvMicroTeachCaseRelaInfoEN();
try
{
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[convMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroTeachCaseRelaInfoEN.FuncModuleName = objRow[convMicroTeachCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoEN.BrowseCount = objRow[convMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMicroTeachCaseRelaInfoEN.ResourceOwner = objRow[convMicroTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMicroTeachCaseRelaInfoEN.ftpFileType = objRow[convMicroTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseRelaInfoEN.ftpFileSize = objRow[convMicroTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroTeachCaseRelaInfoEN.FileOriginName = objRow[convMicroTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMicroTeachCaseRelaInfoEN.IdFile = objRow[convMicroTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMicroTeachCaseRelaInfoEN.FileName = objRow[convMicroTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMicroTeachCaseRelaInfoEN.FileType = objRow[convMicroTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMicroTeachCaseRelaInfoEN.SaveDate = objRow[convMicroTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileSize = objRow[convMicroTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMicroTeachCaseRelaInfoEN.SaveTime = objRow[convMicroTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[convMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = objRow[convMicroTeachCaseRelaInfo.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseRelaInfoEN.IdFtpResource = objRow[convMicroTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroTeachCaseRelaInfoEN.FtpResourceID = objRow[convMicroTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroTeachCaseRelaInfoEN.FileOriginalName = objRow[convMicroTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMicroTeachCaseRelaInfoEN.FileDirName = objRow[convMicroTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMicroTeachCaseRelaInfoEN.FileRename = objRow[convMicroTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMicroTeachCaseRelaInfoEN.FileUpDate = objRow[convMicroTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileUpTime = objRow[convMicroTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdResource = objRow[convMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMicroTeachCaseRelaInfoEN.ResourceID = objRow[convMicroTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMicroTeachCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convMicroTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMicroTeachCaseRelaInfoEN.IdResourceType = objRow[convMicroTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroTeachCaseRelaInfoEN.ResourceTypeID = objRow[convMicroTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroTeachCaseRelaInfoEN.ResourceTypeName = objRow[convMicroTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroTeachCaseRelaInfoEN.Flag = objRow[convMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMicroTeachCaseRelaInfoEN.FileNewName = objRow[convMicroTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMicroTeachCaseRelaInfoEN.FileOldName = objRow[convMicroTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMicroTeachCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convMicroTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroTeachCaseRelaInfoEN.ResourceName = objRow[convMicroTeachCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvMicroTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseRelaInfoEN.UpdDate = objRow[convMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMicroTeachCaseRelaInfoEN.UpdUser = objRow[convMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMicroTeachCaseRelaInfoEN.Memo = objRow[convMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMicroTeachCaseRelaInfoDA: GetObjByDataRowvMicroTeachCaseRelaInfo)", objException.Message));
}
objvMicroTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroTeachCaseRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMicroTeachCaseRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN = new clsvMicroTeachCaseRelaInfoEN();
try
{
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[convMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroTeachCaseRelaInfoEN.FuncModuleName = objRow[convMicroTeachCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoEN.BrowseCount = objRow[convMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMicroTeachCaseRelaInfoEN.ResourceOwner = objRow[convMicroTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMicroTeachCaseRelaInfoEN.ftpFileType = objRow[convMicroTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroTeachCaseRelaInfoEN.ftpFileSize = objRow[convMicroTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroTeachCaseRelaInfoEN.FileOriginName = objRow[convMicroTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMicroTeachCaseRelaInfoEN.IdFile = objRow[convMicroTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMicroTeachCaseRelaInfoEN.FileName = objRow[convMicroTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMicroTeachCaseRelaInfoEN.FileType = objRow[convMicroTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMicroTeachCaseRelaInfoEN.SaveDate = objRow[convMicroTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileSize = objRow[convMicroTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMicroTeachCaseRelaInfoEN.SaveTime = objRow[convMicroTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[convMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroTeachCaseRelaInfoEN.MicroteachCaseName = objRow[convMicroTeachCaseRelaInfo.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroTeachCaseRelaInfoEN.IdFtpResource = objRow[convMicroTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroTeachCaseRelaInfoEN.FtpResourceID = objRow[convMicroTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroTeachCaseRelaInfoEN.FileOriginalName = objRow[convMicroTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMicroTeachCaseRelaInfoEN.FileDirName = objRow[convMicroTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMicroTeachCaseRelaInfoEN.FileRename = objRow[convMicroTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMicroTeachCaseRelaInfoEN.FileUpDate = objRow[convMicroTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMicroTeachCaseRelaInfoEN.FileUpTime = objRow[convMicroTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMicroTeachCaseRelaInfoEN.IdResource = objRow[convMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMicroTeachCaseRelaInfoEN.ResourceID = objRow[convMicroTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMicroTeachCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convMicroTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMicroTeachCaseRelaInfoEN.IdResourceType = objRow[convMicroTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroTeachCaseRelaInfoEN.ResourceTypeID = objRow[convMicroTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroTeachCaseRelaInfoEN.ResourceTypeName = objRow[convMicroTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroTeachCaseRelaInfoEN.Flag = objRow[convMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMicroTeachCaseRelaInfoEN.FileNewName = objRow[convMicroTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMicroTeachCaseRelaInfoEN.FileOldName = objRow[convMicroTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMicroTeachCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convMicroTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroTeachCaseRelaInfoEN.ResourceName = objRow[convMicroTeachCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvMicroTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMicroTeachCaseRelaInfoEN.UpdDate = objRow[convMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMicroTeachCaseRelaInfoEN.UpdUser = objRow[convMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMicroTeachCaseRelaInfoEN.Memo = objRow[convMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMicroTeachCaseRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objvMicroTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroTeachCaseRelaInfoEN;
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
objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroTeachCaseRelaInfoEN._CurrTabName, convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, "");
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
objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroTeachCaseRelaInfoEN._CurrTabName, convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vMicroTeachCaseRelaInfo where " + strCondition;
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
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vMicroTeachCaseRelaInfo where " + strCondition;
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
 /// <param name = "lngIdMicroTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdMicroTeachCaseRelaInfo)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroTeachCaseRelaInfo", "IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMicroTeachCaseRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroTeachCaseRelaInfo", strCondition))
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
objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMicroTeachCaseRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMicroTeachCaseRelaInfoENS">源对象</param>
 /// <param name = "objvMicroTeachCaseRelaInfoENT">目标对象</param>
public void CopyTo(clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoENS, clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoENT)
{
objvMicroTeachCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objvMicroTeachCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvMicroTeachCaseRelaInfoENT.FuncModuleId = objvMicroTeachCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvMicroTeachCaseRelaInfoENT.FuncModuleName = objvMicroTeachCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvMicroTeachCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvMicroTeachCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvMicroTeachCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvMicroTeachCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvMicroTeachCaseRelaInfoENT.BrowseCount = objvMicroTeachCaseRelaInfoENS.BrowseCount; //浏览次数
objvMicroTeachCaseRelaInfoENT.ResourceOwner = objvMicroTeachCaseRelaInfoENS.ResourceOwner; //上传者
objvMicroTeachCaseRelaInfoENT.ftpFileType = objvMicroTeachCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvMicroTeachCaseRelaInfoENT.ftpFileSize = objvMicroTeachCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvMicroTeachCaseRelaInfoENT.ftpResourceOwner = objvMicroTeachCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroTeachCaseRelaInfoENT.FileOriginName = objvMicroTeachCaseRelaInfoENS.FileOriginName; //原文件名
objvMicroTeachCaseRelaInfoENT.IdFile = objvMicroTeachCaseRelaInfoENS.IdFile; //文件流水号
objvMicroTeachCaseRelaInfoENT.FileName = objvMicroTeachCaseRelaInfoENS.FileName; //文件名称
objvMicroTeachCaseRelaInfoENT.FileType = objvMicroTeachCaseRelaInfoENS.FileType; //文件类型
objvMicroTeachCaseRelaInfoENT.SaveDate = objvMicroTeachCaseRelaInfoENS.SaveDate; //创建日期
objvMicroTeachCaseRelaInfoENT.FileSize = objvMicroTeachCaseRelaInfoENS.FileSize; //文件大小
objvMicroTeachCaseRelaInfoENT.SaveTime = objvMicroTeachCaseRelaInfoENS.SaveTime; //创建时间
objvMicroTeachCaseRelaInfoENT.IdMicroteachCase = objvMicroTeachCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvMicroTeachCaseRelaInfoENT.MicroteachCaseName = objvMicroTeachCaseRelaInfoENS.MicroteachCaseName; //微格教学案例名称
objvMicroTeachCaseRelaInfoENT.IdFtpResource = objvMicroTeachCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvMicroTeachCaseRelaInfoENT.FtpResourceID = objvMicroTeachCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvMicroTeachCaseRelaInfoENT.FileOriginalName = objvMicroTeachCaseRelaInfoENS.FileOriginalName; //文件原名
objvMicroTeachCaseRelaInfoENT.FileDirName = objvMicroTeachCaseRelaInfoENS.FileDirName; //文件目录名
objvMicroTeachCaseRelaInfoENT.FileRename = objvMicroTeachCaseRelaInfoENS.FileRename; //文件新名
objvMicroTeachCaseRelaInfoENT.FileUpDate = objvMicroTeachCaseRelaInfoENS.FileUpDate; //创建日期
objvMicroTeachCaseRelaInfoENT.FileUpTime = objvMicroTeachCaseRelaInfoENS.FileUpTime; //创建时间
objvMicroTeachCaseRelaInfoENT.IdResource = objvMicroTeachCaseRelaInfoENS.IdResource; //资源流水号
objvMicroTeachCaseRelaInfoENT.ResourceID = objvMicroTeachCaseRelaInfoENS.ResourceID; //资源ID
objvMicroTeachCaseRelaInfoENT.SaveMode = objvMicroTeachCaseRelaInfoENS.SaveMode; //文件存放方式
objvMicroTeachCaseRelaInfoENT.IdResourceType = objvMicroTeachCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvMicroTeachCaseRelaInfoENT.ResourceTypeID = objvMicroTeachCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvMicroTeachCaseRelaInfoENT.ResourceTypeName = objvMicroTeachCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvMicroTeachCaseRelaInfoENT.Flag = objvMicroTeachCaseRelaInfoENS.Flag; //标志
objvMicroTeachCaseRelaInfoENT.FileNewName = objvMicroTeachCaseRelaInfoENS.FileNewName; //新文件名
objvMicroTeachCaseRelaInfoENT.FileOldName = objvMicroTeachCaseRelaInfoENS.FileOldName; //旧文件名
objvMicroTeachCaseRelaInfoENT.IsExistFile = objvMicroTeachCaseRelaInfoENS.IsExistFile; //是否存在文件
objvMicroTeachCaseRelaInfoENT.ResourceName = objvMicroTeachCaseRelaInfoENS.ResourceName; //资源名称
objvMicroTeachCaseRelaInfoENT.IsVisible = objvMicroTeachCaseRelaInfoENS.IsVisible; //是否显示
objvMicroTeachCaseRelaInfoENT.UpdDate = objvMicroTeachCaseRelaInfoENS.UpdDate; //修改日期
objvMicroTeachCaseRelaInfoENT.UpdUser = objvMicroTeachCaseRelaInfoENS.UpdUser; //修改人
objvMicroTeachCaseRelaInfoENT.Memo = objvMicroTeachCaseRelaInfoENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMicroTeachCaseRelaInfoEN objvMicroTeachCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.FuncModuleId, 4, convMicroTeachCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.FuncModuleName, 30, convMicroTeachCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, 4, convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, 50, convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.ResourceOwner, 50, convMicroTeachCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.ftpFileType, 30, convMicroTeachCaseRelaInfo.ftpFileType);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.ftpFileSize, 50, convMicroTeachCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.ftpResourceOwner, 50, convMicroTeachCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.FileOriginName, 500, convMicroTeachCaseRelaInfo.FileOriginName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.IdFile, 8, convMicroTeachCaseRelaInfo.IdFile);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.FileName, 500, convMicroTeachCaseRelaInfo.FileName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.FileType, 30, convMicroTeachCaseRelaInfo.FileType);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.SaveDate, 8, convMicroTeachCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.FileSize, 50, convMicroTeachCaseRelaInfo.FileSize);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.SaveTime, 6, convMicroTeachCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.IdMicroteachCase, 8, convMicroTeachCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.MicroteachCaseName, 100, convMicroTeachCaseRelaInfo.MicroteachCaseName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.IdFtpResource, 8, convMicroTeachCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.FtpResourceID, 8, convMicroTeachCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.FileOriginalName, 200, convMicroTeachCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.FileDirName, 200, convMicroTeachCaseRelaInfo.FileDirName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.FileRename, 200, convMicroTeachCaseRelaInfo.FileRename);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.FileUpDate, 8, convMicroTeachCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.FileUpTime, 6, convMicroTeachCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.IdResource, 8, convMicroTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.ResourceID, 8, convMicroTeachCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.IdResourceType, 4, convMicroTeachCaseRelaInfo.IdResourceType);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.ResourceTypeID, 4, convMicroTeachCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.ResourceTypeName, 50, convMicroTeachCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.Flag, 50, convMicroTeachCaseRelaInfo.Flag);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.FileNewName, 530, convMicroTeachCaseRelaInfo.FileNewName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.FileOldName, 530, convMicroTeachCaseRelaInfo.FileOldName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.ResourceName, 100, convMicroTeachCaseRelaInfo.ResourceName);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.UpdDate, 20, convMicroTeachCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.UpdUser, 20, convMicroTeachCaseRelaInfo.UpdUser);
clsCheckSql.CheckFieldLen(objvMicroTeachCaseRelaInfoEN.Memo, 1000, convMicroTeachCaseRelaInfo.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.FuncModuleId, convMicroTeachCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.FuncModuleName, convMicroTeachCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, convMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, convMicroTeachCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.ResourceOwner, convMicroTeachCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.ftpFileType, convMicroTeachCaseRelaInfo.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.ftpFileSize, convMicroTeachCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.ftpResourceOwner, convMicroTeachCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.FileOriginName, convMicroTeachCaseRelaInfo.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.IdFile, convMicroTeachCaseRelaInfo.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.FileName, convMicroTeachCaseRelaInfo.FileName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.FileType, convMicroTeachCaseRelaInfo.FileType);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.SaveDate, convMicroTeachCaseRelaInfo.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.FileSize, convMicroTeachCaseRelaInfo.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.SaveTime, convMicroTeachCaseRelaInfo.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.IdMicroteachCase, convMicroTeachCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.MicroteachCaseName, convMicroTeachCaseRelaInfo.MicroteachCaseName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.IdFtpResource, convMicroTeachCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.FtpResourceID, convMicroTeachCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.FileOriginalName, convMicroTeachCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.FileDirName, convMicroTeachCaseRelaInfo.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.FileRename, convMicroTeachCaseRelaInfo.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.FileUpDate, convMicroTeachCaseRelaInfo.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.FileUpTime, convMicroTeachCaseRelaInfo.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.IdResource, convMicroTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.ResourceID, convMicroTeachCaseRelaInfo.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.IdResourceType, convMicroTeachCaseRelaInfo.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.ResourceTypeID, convMicroTeachCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.ResourceTypeName, convMicroTeachCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.Flag, convMicroTeachCaseRelaInfo.Flag);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.FileNewName, convMicroTeachCaseRelaInfo.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.FileOldName, convMicroTeachCaseRelaInfo.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.ResourceName, convMicroTeachCaseRelaInfo.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.UpdDate, convMicroTeachCaseRelaInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.UpdUser, convMicroTeachCaseRelaInfo.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvMicroTeachCaseRelaInfoEN.Memo, convMicroTeachCaseRelaInfo.Memo);
//检查外键字段长度
 objvMicroTeachCaseRelaInfoEN._IsCheckProperty = true;
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
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroTeachCaseRelaInfoEN._CurrTabName);
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
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroTeachCaseRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}