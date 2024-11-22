
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMandarinCaseRelaInfoDA
 表名:vMandarinCaseRelaInfo(01120401)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:普通话点播(Mandarin)
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
 /// vMandarinCaseRelaInfo(vMandarinCaseRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMandarinCaseRelaInfoDA : clsCommBase4DA
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
 return clsvMandarinCaseRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMandarinCaseRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMandarinCaseRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMandarinCaseRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMandarinCaseRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMandarinCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMandarinCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMandarinCaseRelaInfoDA: GetDataTable_vMandarinCaseRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMandarinCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMandarinCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMandarinCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMandarinCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCaseRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCaseRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMandarinCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMandarinCaseRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMandarinCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMandarinCaseRelaInfo.* from vMandarinCaseRelaInfo Left Join {1} on {2} where {3} and vMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo from vMandarinCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vMandarinCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vMandarinCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMandarinCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMandarinCaseRelaInfo.* from vMandarinCaseRelaInfo Left Join {1} on {2} where {3} and vMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo from vMandarinCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vMandarinCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vMandarinCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMandarinCaseRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMandarinCaseRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsvMandarinCaseRelaInfoEN> arrObjLst = new List<clsvMandarinCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN = new clsvMandarinCaseRelaInfoEN();
try
{
objvMandarinCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMandarinCaseRelaInfoEN.FuncModuleId = objRow[convMandarinCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMandarinCaseRelaInfoEN.FuncModuleName = objRow[convMandarinCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMandarinCaseRelaInfoEN.IdMicroteachCase = objRow[convMandarinCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMandarinCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convMandarinCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMandarinCaseRelaInfoEN.IdFile = objRow[convMandarinCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMandarinCaseRelaInfoEN.FileName = objRow[convMandarinCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMandarinCaseRelaInfoEN.FileType = objRow[convMandarinCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMandarinCaseRelaInfoEN.SaveDate = objRow[convMandarinCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMandarinCaseRelaInfoEN.FileSize = objRow[convMandarinCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMandarinCaseRelaInfoEN.SaveTime = objRow[convMandarinCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMandarinCaseRelaInfoEN.IdFtpResource = objRow[convMandarinCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMandarinCaseRelaInfoEN.FtpResourceID = objRow[convMandarinCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMandarinCaseRelaInfoEN.FileOriginalName = objRow[convMandarinCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMandarinCaseRelaInfoEN.FileDirName = objRow[convMandarinCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMandarinCaseRelaInfoEN.FileRename = objRow[convMandarinCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMandarinCaseRelaInfoEN.FileUpDate = objRow[convMandarinCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMandarinCaseRelaInfoEN.FileUpTime = objRow[convMandarinCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMandarinCaseRelaInfoEN.IdResource = objRow[convMandarinCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMandarinCaseRelaInfoEN.ResourceID = objRow[convMandarinCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMandarinCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convMandarinCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMandarinCaseRelaInfoEN.IdResourceType = objRow[convMandarinCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMandarinCaseRelaInfoEN.ResourceTypeID = objRow[convMandarinCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMandarinCaseRelaInfoEN.ResourceTypeName = objRow[convMandarinCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMandarinCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMandarinCaseRelaInfoEN.BrowseCount = objRow[convMandarinCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMandarinCaseRelaInfoEN.ResourceOwner = objRow[convMandarinCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMandarinCaseRelaInfoEN.ftpFileType = objRow[convMandarinCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMandarinCaseRelaInfoEN.ftpFileSize = objRow[convMandarinCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMandarinCaseRelaInfoEN.ftpResourceOwner = objRow[convMandarinCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMandarinCaseRelaInfoEN.FileOriginName = objRow[convMandarinCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMandarinCaseRelaInfoEN.MandarinCaseName = objRow[convMandarinCaseRelaInfo.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objvMandarinCaseRelaInfoEN.FileNewName = objRow[convMandarinCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMandarinCaseRelaInfoEN.FileOldName = objRow[convMandarinCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMandarinCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convMandarinCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMandarinCaseRelaInfoEN.Flag = objRow[convMandarinCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMandarinCaseRelaInfoEN.UpdDate = objRow[convMandarinCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMandarinCaseRelaInfoEN.UpdUser = objRow[convMandarinCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMandarinCaseRelaInfoEN.Memo = objRow[convMandarinCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.Memo].ToString().Trim(); //备注
objvMandarinCaseRelaInfoEN.IdMandarinCase = objRow[convMandarinCaseRelaInfo.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdMandarinCase].ToString().Trim(); //普通话案例流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMandarinCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvMandarinCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMandarinCaseRelaInfoEN);
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
public List<clsvMandarinCaseRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMandarinCaseRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMandarinCaseRelaInfoEN> arrObjLst = new List<clsvMandarinCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN = new clsvMandarinCaseRelaInfoEN();
try
{
objvMandarinCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMandarinCaseRelaInfoEN.FuncModuleId = objRow[convMandarinCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMandarinCaseRelaInfoEN.FuncModuleName = objRow[convMandarinCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMandarinCaseRelaInfoEN.IdMicroteachCase = objRow[convMandarinCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMandarinCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convMandarinCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMandarinCaseRelaInfoEN.IdFile = objRow[convMandarinCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMandarinCaseRelaInfoEN.FileName = objRow[convMandarinCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMandarinCaseRelaInfoEN.FileType = objRow[convMandarinCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMandarinCaseRelaInfoEN.SaveDate = objRow[convMandarinCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMandarinCaseRelaInfoEN.FileSize = objRow[convMandarinCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMandarinCaseRelaInfoEN.SaveTime = objRow[convMandarinCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMandarinCaseRelaInfoEN.IdFtpResource = objRow[convMandarinCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMandarinCaseRelaInfoEN.FtpResourceID = objRow[convMandarinCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMandarinCaseRelaInfoEN.FileOriginalName = objRow[convMandarinCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMandarinCaseRelaInfoEN.FileDirName = objRow[convMandarinCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMandarinCaseRelaInfoEN.FileRename = objRow[convMandarinCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMandarinCaseRelaInfoEN.FileUpDate = objRow[convMandarinCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMandarinCaseRelaInfoEN.FileUpTime = objRow[convMandarinCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMandarinCaseRelaInfoEN.IdResource = objRow[convMandarinCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMandarinCaseRelaInfoEN.ResourceID = objRow[convMandarinCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMandarinCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convMandarinCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMandarinCaseRelaInfoEN.IdResourceType = objRow[convMandarinCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMandarinCaseRelaInfoEN.ResourceTypeID = objRow[convMandarinCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMandarinCaseRelaInfoEN.ResourceTypeName = objRow[convMandarinCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMandarinCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMandarinCaseRelaInfoEN.BrowseCount = objRow[convMandarinCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMandarinCaseRelaInfoEN.ResourceOwner = objRow[convMandarinCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMandarinCaseRelaInfoEN.ftpFileType = objRow[convMandarinCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMandarinCaseRelaInfoEN.ftpFileSize = objRow[convMandarinCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMandarinCaseRelaInfoEN.ftpResourceOwner = objRow[convMandarinCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMandarinCaseRelaInfoEN.FileOriginName = objRow[convMandarinCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMandarinCaseRelaInfoEN.MandarinCaseName = objRow[convMandarinCaseRelaInfo.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objvMandarinCaseRelaInfoEN.FileNewName = objRow[convMandarinCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMandarinCaseRelaInfoEN.FileOldName = objRow[convMandarinCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMandarinCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convMandarinCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMandarinCaseRelaInfoEN.Flag = objRow[convMandarinCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMandarinCaseRelaInfoEN.UpdDate = objRow[convMandarinCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMandarinCaseRelaInfoEN.UpdUser = objRow[convMandarinCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMandarinCaseRelaInfoEN.Memo = objRow[convMandarinCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.Memo].ToString().Trim(); //备注
objvMandarinCaseRelaInfoEN.IdMandarinCase = objRow[convMandarinCaseRelaInfo.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdMandarinCase].ToString().Trim(); //普通话案例流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMandarinCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvMandarinCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMandarinCaseRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMandarinCaseRelaInfo(ref clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ objvMandarinCaseRelaInfoEN.IdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMandarinCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objDT.Rows[0][convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMandarinCaseRelaInfoEN.FuncModuleId = objDT.Rows[0][convMandarinCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCaseRelaInfoEN.FuncModuleName = objDT.Rows[0][convMandarinCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMandarinCaseRelaInfoEN.IdMicroteachCase = objDT.Rows[0][convMandarinCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseRelaInfoEN.IsVisible = TransNullToBool(objDT.Rows[0][convMandarinCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCaseRelaInfoEN.IdFile = objDT.Rows[0][convMandarinCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileName = objDT.Rows[0][convMandarinCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileType = objDT.Rows[0][convMandarinCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMandarinCaseRelaInfoEN.SaveDate = objDT.Rows[0][convMandarinCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileSize = objDT.Rows[0][convMandarinCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCaseRelaInfoEN.SaveTime = objDT.Rows[0][convMandarinCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCaseRelaInfoEN.IdFtpResource = objDT.Rows[0][convMandarinCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseRelaInfoEN.FtpResourceID = objDT.Rows[0][convMandarinCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseRelaInfoEN.FileOriginalName = objDT.Rows[0][convMandarinCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileDirName = objDT.Rows[0][convMandarinCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileRename = objDT.Rows[0][convMandarinCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileUpDate = objDT.Rows[0][convMandarinCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileUpTime = objDT.Rows[0][convMandarinCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCaseRelaInfoEN.IdResource = objDT.Rows[0][convMandarinCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseRelaInfoEN.ResourceID = objDT.Rows[0][convMandarinCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseRelaInfoEN.SaveMode = TransNullToBool(objDT.Rows[0][convMandarinCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCaseRelaInfoEN.IdResourceType = objDT.Rows[0][convMandarinCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseRelaInfoEN.ResourceTypeID = objDT.Rows[0][convMandarinCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseRelaInfoEN.ResourceTypeName = objDT.Rows[0][convMandarinCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objDT.Rows[0][convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objDT.Rows[0][convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objDT.Rows[0][convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][convMandarinCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMandarinCaseRelaInfoEN.ResourceOwner = objDT.Rows[0][convMandarinCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseRelaInfoEN.ftpFileType = objDT.Rows[0][convMandarinCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMandarinCaseRelaInfoEN.ftpFileSize = objDT.Rows[0][convMandarinCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCaseRelaInfoEN.ftpResourceOwner = objDT.Rows[0][convMandarinCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileOriginName = objDT.Rows[0][convMandarinCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvMandarinCaseRelaInfoEN.MandarinCaseName = objDT.Rows[0][convMandarinCaseRelaInfo.MandarinCaseName].ToString().Trim(); //普通话教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMandarinCaseRelaInfoEN.FileNewName = objDT.Rows[0][convMandarinCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileOldName = objDT.Rows[0][convMandarinCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMandarinCaseRelaInfoEN.IsExistFile = TransNullToBool(objDT.Rows[0][convMandarinCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCaseRelaInfoEN.Flag = objDT.Rows[0][convMandarinCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCaseRelaInfoEN.UpdDate = objDT.Rows[0][convMandarinCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseRelaInfoEN.UpdUser = objDT.Rows[0][convMandarinCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseRelaInfoEN.Memo = objDT.Rows[0][convMandarinCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMandarinCaseRelaInfoEN.IdMandarinCase = objDT.Rows[0][convMandarinCaseRelaInfo.IdMandarinCase].ToString().Trim(); //普通话案例流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMandarinCaseRelaInfoDA: GetvMandarinCaseRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsvMandarinCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN = new clsvMandarinCaseRelaInfoEN();
try
{
 objvMandarinCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMandarinCaseRelaInfoEN.FuncModuleId = objRow[convMandarinCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCaseRelaInfoEN.FuncModuleName = objRow[convMandarinCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMandarinCaseRelaInfoEN.IdMicroteachCase = objRow[convMandarinCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMandarinCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCaseRelaInfoEN.IdFile = objRow[convMandarinCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileName = objRow[convMandarinCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileType = objRow[convMandarinCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMandarinCaseRelaInfoEN.SaveDate = objRow[convMandarinCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileSize = objRow[convMandarinCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCaseRelaInfoEN.SaveTime = objRow[convMandarinCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCaseRelaInfoEN.IdFtpResource = objRow[convMandarinCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseRelaInfoEN.FtpResourceID = objRow[convMandarinCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseRelaInfoEN.FileOriginalName = objRow[convMandarinCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileDirName = objRow[convMandarinCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileRename = objRow[convMandarinCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileUpDate = objRow[convMandarinCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileUpTime = objRow[convMandarinCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCaseRelaInfoEN.IdResource = objRow[convMandarinCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseRelaInfoEN.ResourceID = objRow[convMandarinCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMandarinCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCaseRelaInfoEN.IdResourceType = objRow[convMandarinCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseRelaInfoEN.ResourceTypeID = objRow[convMandarinCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseRelaInfoEN.ResourceTypeName = objRow[convMandarinCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseRelaInfoEN.BrowseCount = objRow[convMandarinCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMandarinCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMandarinCaseRelaInfoEN.ResourceOwner = objRow[convMandarinCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseRelaInfoEN.ftpFileType = objRow[convMandarinCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMandarinCaseRelaInfoEN.ftpFileSize = objRow[convMandarinCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCaseRelaInfoEN.ftpResourceOwner = objRow[convMandarinCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileOriginName = objRow[convMandarinCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvMandarinCaseRelaInfoEN.MandarinCaseName = objRow[convMandarinCaseRelaInfo.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.MandarinCaseName].ToString().Trim(); //普通话教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMandarinCaseRelaInfoEN.FileNewName = objRow[convMandarinCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMandarinCaseRelaInfoEN.FileOldName = objRow[convMandarinCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMandarinCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMandarinCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCaseRelaInfoEN.Flag = objRow[convMandarinCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCaseRelaInfoEN.UpdDate = objRow[convMandarinCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseRelaInfoEN.UpdUser = objRow[convMandarinCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseRelaInfoEN.Memo = objRow[convMandarinCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMandarinCaseRelaInfoEN.IdMandarinCase = objRow[convMandarinCaseRelaInfo.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdMandarinCase].ToString().Trim(); //普通话案例流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMandarinCaseRelaInfoDA: GetObjByIdMicroTeachCaseRelaInfo)", objException.Message));
}
return objvMandarinCaseRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMandarinCaseRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMandarinCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN = new clsvMandarinCaseRelaInfoEN()
{
IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()), //案例相关信息流水号
FuncModuleId = objRow[convMandarinCaseRelaInfo.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convMandarinCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convMandarinCaseRelaInfo.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IsVisible = TransNullToBool(objRow[convMandarinCaseRelaInfo.IsVisible].ToString().Trim()), //是否显示
IdFile = objRow[convMandarinCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convMandarinCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileName].ToString().Trim(), //文件名称
FileType = objRow[convMandarinCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convMandarinCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convMandarinCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convMandarinCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.SaveTime].ToString().Trim(), //创建时间
IdFtpResource = objRow[convMandarinCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[convMandarinCaseRelaInfo.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convMandarinCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convMandarinCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convMandarinCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convMandarinCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convMandarinCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileUpTime].ToString().Trim(), //创建时间
IdResource = objRow[convMandarinCaseRelaInfo.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convMandarinCaseRelaInfo.ResourceID].ToString().Trim(), //资源ID
SaveMode = TransNullToBool(objRow[convMandarinCaseRelaInfo.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convMandarinCaseRelaInfo.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convMandarinCaseRelaInfo.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convMandarinCaseRelaInfo.ResourceTypeName].ToString().Trim(), //资源类型名称
IdMicroTeachCaseRelaInfoType = objRow[convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(), //微格案例相关信息类型流水号
MicroTeachCaseRelaInfoTypeID = objRow[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(), //微格案例相关信息类型ID
MicroTeachCaseRelaInfoTypeName = objRow[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(), //微格案例相关信息类型名称
BrowseCount = objRow[convMandarinCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCaseRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
ResourceOwner = objRow[convMandarinCaseRelaInfo.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convMandarinCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convMandarinCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convMandarinCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convMandarinCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOriginName].ToString().Trim(), //原文件名
MandarinCaseName = objRow[convMandarinCaseRelaInfo.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.MandarinCaseName].ToString().Trim(), //普通话教学案例名称
FileNewName = objRow[convMandarinCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convMandarinCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOldName].ToString().Trim(), //旧文件名
IsExistFile = TransNullToBool(objRow[convMandarinCaseRelaInfo.IsExistFile].ToString().Trim()), //是否存在文件
Flag = objRow[convMandarinCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.Flag].ToString().Trim(), //标志
UpdDate = objRow[convMandarinCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convMandarinCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convMandarinCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.Memo].ToString().Trim(), //备注
IdMandarinCase = objRow[convMandarinCaseRelaInfo.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdMandarinCase].ToString().Trim() //普通话案例流水号
};
objvMandarinCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMandarinCaseRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMandarinCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMandarinCaseRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN = new clsvMandarinCaseRelaInfoEN();
try
{
objvMandarinCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMandarinCaseRelaInfoEN.FuncModuleId = objRow[convMandarinCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMandarinCaseRelaInfoEN.FuncModuleName = objRow[convMandarinCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMandarinCaseRelaInfoEN.IdMicroteachCase = objRow[convMandarinCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMandarinCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convMandarinCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMandarinCaseRelaInfoEN.IdFile = objRow[convMandarinCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMandarinCaseRelaInfoEN.FileName = objRow[convMandarinCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMandarinCaseRelaInfoEN.FileType = objRow[convMandarinCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMandarinCaseRelaInfoEN.SaveDate = objRow[convMandarinCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMandarinCaseRelaInfoEN.FileSize = objRow[convMandarinCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMandarinCaseRelaInfoEN.SaveTime = objRow[convMandarinCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMandarinCaseRelaInfoEN.IdFtpResource = objRow[convMandarinCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMandarinCaseRelaInfoEN.FtpResourceID = objRow[convMandarinCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMandarinCaseRelaInfoEN.FileOriginalName = objRow[convMandarinCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMandarinCaseRelaInfoEN.FileDirName = objRow[convMandarinCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMandarinCaseRelaInfoEN.FileRename = objRow[convMandarinCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMandarinCaseRelaInfoEN.FileUpDate = objRow[convMandarinCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMandarinCaseRelaInfoEN.FileUpTime = objRow[convMandarinCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMandarinCaseRelaInfoEN.IdResource = objRow[convMandarinCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMandarinCaseRelaInfoEN.ResourceID = objRow[convMandarinCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMandarinCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convMandarinCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMandarinCaseRelaInfoEN.IdResourceType = objRow[convMandarinCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMandarinCaseRelaInfoEN.ResourceTypeID = objRow[convMandarinCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMandarinCaseRelaInfoEN.ResourceTypeName = objRow[convMandarinCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMandarinCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMandarinCaseRelaInfoEN.BrowseCount = objRow[convMandarinCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMandarinCaseRelaInfoEN.ResourceOwner = objRow[convMandarinCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMandarinCaseRelaInfoEN.ftpFileType = objRow[convMandarinCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMandarinCaseRelaInfoEN.ftpFileSize = objRow[convMandarinCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMandarinCaseRelaInfoEN.ftpResourceOwner = objRow[convMandarinCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMandarinCaseRelaInfoEN.FileOriginName = objRow[convMandarinCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMandarinCaseRelaInfoEN.MandarinCaseName = objRow[convMandarinCaseRelaInfo.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objvMandarinCaseRelaInfoEN.FileNewName = objRow[convMandarinCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMandarinCaseRelaInfoEN.FileOldName = objRow[convMandarinCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMandarinCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convMandarinCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMandarinCaseRelaInfoEN.Flag = objRow[convMandarinCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMandarinCaseRelaInfoEN.UpdDate = objRow[convMandarinCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMandarinCaseRelaInfoEN.UpdUser = objRow[convMandarinCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMandarinCaseRelaInfoEN.Memo = objRow[convMandarinCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.Memo].ToString().Trim(); //备注
objvMandarinCaseRelaInfoEN.IdMandarinCase = objRow[convMandarinCaseRelaInfo.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdMandarinCase].ToString().Trim(); //普通话案例流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMandarinCaseRelaInfoDA: GetObjByDataRowvMandarinCaseRelaInfo)", objException.Message));
}
objvMandarinCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMandarinCaseRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMandarinCaseRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN = new clsvMandarinCaseRelaInfoEN();
try
{
objvMandarinCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvMandarinCaseRelaInfoEN.FuncModuleId = objRow[convMandarinCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvMandarinCaseRelaInfoEN.FuncModuleName = objRow[convMandarinCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvMandarinCaseRelaInfoEN.IdMicroteachCase = objRow[convMandarinCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMandarinCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convMandarinCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvMandarinCaseRelaInfoEN.IdFile = objRow[convMandarinCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvMandarinCaseRelaInfoEN.FileName = objRow[convMandarinCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvMandarinCaseRelaInfoEN.FileType = objRow[convMandarinCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvMandarinCaseRelaInfoEN.SaveDate = objRow[convMandarinCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvMandarinCaseRelaInfoEN.FileSize = objRow[convMandarinCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvMandarinCaseRelaInfoEN.SaveTime = objRow[convMandarinCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvMandarinCaseRelaInfoEN.IdFtpResource = objRow[convMandarinCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMandarinCaseRelaInfoEN.FtpResourceID = objRow[convMandarinCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMandarinCaseRelaInfoEN.FileOriginalName = objRow[convMandarinCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvMandarinCaseRelaInfoEN.FileDirName = objRow[convMandarinCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvMandarinCaseRelaInfoEN.FileRename = objRow[convMandarinCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvMandarinCaseRelaInfoEN.FileUpDate = objRow[convMandarinCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvMandarinCaseRelaInfoEN.FileUpTime = objRow[convMandarinCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvMandarinCaseRelaInfoEN.IdResource = objRow[convMandarinCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvMandarinCaseRelaInfoEN.ResourceID = objRow[convMandarinCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvMandarinCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convMandarinCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvMandarinCaseRelaInfoEN.IdResourceType = objRow[convMandarinCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvMandarinCaseRelaInfoEN.ResourceTypeID = objRow[convMandarinCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMandarinCaseRelaInfoEN.ResourceTypeName = objRow[convMandarinCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMandarinCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvMandarinCaseRelaInfoEN.BrowseCount = objRow[convMandarinCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvMandarinCaseRelaInfoEN.ResourceOwner = objRow[convMandarinCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvMandarinCaseRelaInfoEN.ftpFileType = objRow[convMandarinCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvMandarinCaseRelaInfoEN.ftpFileSize = objRow[convMandarinCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMandarinCaseRelaInfoEN.ftpResourceOwner = objRow[convMandarinCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMandarinCaseRelaInfoEN.FileOriginName = objRow[convMandarinCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvMandarinCaseRelaInfoEN.MandarinCaseName = objRow[convMandarinCaseRelaInfo.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objvMandarinCaseRelaInfoEN.FileNewName = objRow[convMandarinCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvMandarinCaseRelaInfoEN.FileOldName = objRow[convMandarinCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvMandarinCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convMandarinCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvMandarinCaseRelaInfoEN.Flag = objRow[convMandarinCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.Flag].ToString().Trim(); //标志
objvMandarinCaseRelaInfoEN.UpdDate = objRow[convMandarinCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvMandarinCaseRelaInfoEN.UpdUser = objRow[convMandarinCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvMandarinCaseRelaInfoEN.Memo = objRow[convMandarinCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.Memo].ToString().Trim(); //备注
objvMandarinCaseRelaInfoEN.IdMandarinCase = objRow[convMandarinCaseRelaInfo.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCaseRelaInfo.IdMandarinCase].ToString().Trim(); //普通话案例流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMandarinCaseRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objvMandarinCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMandarinCaseRelaInfoEN;
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
objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMandarinCaseRelaInfoEN._CurrTabName, convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, "");
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
objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMandarinCaseRelaInfoEN._CurrTabName, convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vMandarinCaseRelaInfo where " + strCondition;
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
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vMandarinCaseRelaInfo where " + strCondition;
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
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMandarinCaseRelaInfo", "IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMandarinCaseRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMandarinCaseRelaInfo", strCondition))
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
objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMandarinCaseRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMandarinCaseRelaInfoENS">源对象</param>
 /// <param name = "objvMandarinCaseRelaInfoENT">目标对象</param>
public void CopyTo(clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoENS, clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoENT)
{
objvMandarinCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objvMandarinCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvMandarinCaseRelaInfoENT.FuncModuleId = objvMandarinCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvMandarinCaseRelaInfoENT.FuncModuleName = objvMandarinCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvMandarinCaseRelaInfoENT.IdMicroteachCase = objvMandarinCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvMandarinCaseRelaInfoENT.IsVisible = objvMandarinCaseRelaInfoENS.IsVisible; //是否显示
objvMandarinCaseRelaInfoENT.IdFile = objvMandarinCaseRelaInfoENS.IdFile; //文件流水号
objvMandarinCaseRelaInfoENT.FileName = objvMandarinCaseRelaInfoENS.FileName; //文件名称
objvMandarinCaseRelaInfoENT.FileType = objvMandarinCaseRelaInfoENS.FileType; //文件类型
objvMandarinCaseRelaInfoENT.SaveDate = objvMandarinCaseRelaInfoENS.SaveDate; //创建日期
objvMandarinCaseRelaInfoENT.FileSize = objvMandarinCaseRelaInfoENS.FileSize; //文件大小
objvMandarinCaseRelaInfoENT.SaveTime = objvMandarinCaseRelaInfoENS.SaveTime; //创建时间
objvMandarinCaseRelaInfoENT.IdFtpResource = objvMandarinCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvMandarinCaseRelaInfoENT.FtpResourceID = objvMandarinCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvMandarinCaseRelaInfoENT.FileOriginalName = objvMandarinCaseRelaInfoENS.FileOriginalName; //文件原名
objvMandarinCaseRelaInfoENT.FileDirName = objvMandarinCaseRelaInfoENS.FileDirName; //文件目录名
objvMandarinCaseRelaInfoENT.FileRename = objvMandarinCaseRelaInfoENS.FileRename; //文件新名
objvMandarinCaseRelaInfoENT.FileUpDate = objvMandarinCaseRelaInfoENS.FileUpDate; //创建日期
objvMandarinCaseRelaInfoENT.FileUpTime = objvMandarinCaseRelaInfoENS.FileUpTime; //创建时间
objvMandarinCaseRelaInfoENT.IdResource = objvMandarinCaseRelaInfoENS.IdResource; //资源流水号
objvMandarinCaseRelaInfoENT.ResourceID = objvMandarinCaseRelaInfoENS.ResourceID; //资源ID
objvMandarinCaseRelaInfoENT.SaveMode = objvMandarinCaseRelaInfoENS.SaveMode; //文件存放方式
objvMandarinCaseRelaInfoENT.IdResourceType = objvMandarinCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvMandarinCaseRelaInfoENT.ResourceTypeID = objvMandarinCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvMandarinCaseRelaInfoENT.ResourceTypeName = objvMandarinCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvMandarinCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvMandarinCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvMandarinCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvMandarinCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvMandarinCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvMandarinCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvMandarinCaseRelaInfoENT.BrowseCount = objvMandarinCaseRelaInfoENS.BrowseCount; //浏览次数
objvMandarinCaseRelaInfoENT.ResourceOwner = objvMandarinCaseRelaInfoENS.ResourceOwner; //上传者
objvMandarinCaseRelaInfoENT.ftpFileType = objvMandarinCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvMandarinCaseRelaInfoENT.ftpFileSize = objvMandarinCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvMandarinCaseRelaInfoENT.ftpResourceOwner = objvMandarinCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvMandarinCaseRelaInfoENT.FileOriginName = objvMandarinCaseRelaInfoENS.FileOriginName; //原文件名
objvMandarinCaseRelaInfoENT.MandarinCaseName = objvMandarinCaseRelaInfoENS.MandarinCaseName; //普通话教学案例名称
objvMandarinCaseRelaInfoENT.FileNewName = objvMandarinCaseRelaInfoENS.FileNewName; //新文件名
objvMandarinCaseRelaInfoENT.FileOldName = objvMandarinCaseRelaInfoENS.FileOldName; //旧文件名
objvMandarinCaseRelaInfoENT.IsExistFile = objvMandarinCaseRelaInfoENS.IsExistFile; //是否存在文件
objvMandarinCaseRelaInfoENT.Flag = objvMandarinCaseRelaInfoENS.Flag; //标志
objvMandarinCaseRelaInfoENT.UpdDate = objvMandarinCaseRelaInfoENS.UpdDate; //修改日期
objvMandarinCaseRelaInfoENT.UpdUser = objvMandarinCaseRelaInfoENS.UpdUser; //修改人
objvMandarinCaseRelaInfoENT.Memo = objvMandarinCaseRelaInfoENS.Memo; //备注
objvMandarinCaseRelaInfoENT.IdMandarinCase = objvMandarinCaseRelaInfoENS.IdMandarinCase; //普通话案例流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMandarinCaseRelaInfoEN objvMandarinCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.FuncModuleId, 4, convMandarinCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.FuncModuleName, 30, convMandarinCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.IdMicroteachCase, 8, convMandarinCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.IdFile, 8, convMandarinCaseRelaInfo.IdFile);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.FileName, 500, convMandarinCaseRelaInfo.FileName);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.FileType, 30, convMandarinCaseRelaInfo.FileType);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.SaveDate, 8, convMandarinCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.FileSize, 50, convMandarinCaseRelaInfo.FileSize);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.SaveTime, 6, convMandarinCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.IdFtpResource, 8, convMandarinCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.FtpResourceID, 8, convMandarinCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.FileOriginalName, 200, convMandarinCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.FileDirName, 200, convMandarinCaseRelaInfo.FileDirName);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.FileRename, 200, convMandarinCaseRelaInfo.FileRename);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.FileUpDate, 8, convMandarinCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.FileUpTime, 6, convMandarinCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.IdResource, 8, convMandarinCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.ResourceID, 8, convMandarinCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.IdResourceType, 4, convMandarinCaseRelaInfo.IdResourceType);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.ResourceTypeID, 4, convMandarinCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.ResourceTypeName, 50, convMandarinCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, 4, convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, 4, convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, 50, convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.ResourceOwner, 50, convMandarinCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.ftpFileType, 30, convMandarinCaseRelaInfo.ftpFileType);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.ftpFileSize, 50, convMandarinCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.ftpResourceOwner, 50, convMandarinCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.FileOriginName, 500, convMandarinCaseRelaInfo.FileOriginName);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.MandarinCaseName, 100, convMandarinCaseRelaInfo.MandarinCaseName);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.FileNewName, 530, convMandarinCaseRelaInfo.FileNewName);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.FileOldName, 530, convMandarinCaseRelaInfo.FileOldName);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.Flag, 50, convMandarinCaseRelaInfo.Flag);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.UpdDate, 20, convMandarinCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.UpdUser, 20, convMandarinCaseRelaInfo.UpdUser);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.Memo, 1000, convMandarinCaseRelaInfo.Memo);
clsCheckSql.CheckFieldLen(objvMandarinCaseRelaInfoEN.IdMandarinCase, 8, convMandarinCaseRelaInfo.IdMandarinCase);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.FuncModuleId, convMandarinCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.FuncModuleName, convMandarinCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.IdMicroteachCase, convMandarinCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.IdFile, convMandarinCaseRelaInfo.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.FileName, convMandarinCaseRelaInfo.FileName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.FileType, convMandarinCaseRelaInfo.FileType);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.SaveDate, convMandarinCaseRelaInfo.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.FileSize, convMandarinCaseRelaInfo.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.SaveTime, convMandarinCaseRelaInfo.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.IdFtpResource, convMandarinCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.FtpResourceID, convMandarinCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.FileOriginalName, convMandarinCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.FileDirName, convMandarinCaseRelaInfo.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.FileRename, convMandarinCaseRelaInfo.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.FileUpDate, convMandarinCaseRelaInfo.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.FileUpTime, convMandarinCaseRelaInfo.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.IdResource, convMandarinCaseRelaInfo.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.ResourceID, convMandarinCaseRelaInfo.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.IdResourceType, convMandarinCaseRelaInfo.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.ResourceTypeID, convMandarinCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.ResourceTypeName, convMandarinCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, convMandarinCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, convMandarinCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.ResourceOwner, convMandarinCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.ftpFileType, convMandarinCaseRelaInfo.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.ftpFileSize, convMandarinCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.ftpResourceOwner, convMandarinCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.FileOriginName, convMandarinCaseRelaInfo.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.MandarinCaseName, convMandarinCaseRelaInfo.MandarinCaseName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.FileNewName, convMandarinCaseRelaInfo.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.FileOldName, convMandarinCaseRelaInfo.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.Flag, convMandarinCaseRelaInfo.Flag);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.UpdDate, convMandarinCaseRelaInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.UpdUser, convMandarinCaseRelaInfo.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.Memo, convMandarinCaseRelaInfo.Memo);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseRelaInfoEN.IdMandarinCase, convMandarinCaseRelaInfo.IdMandarinCase);
//检查外键字段长度
 objvMandarinCaseRelaInfoEN._IsCheckProperty = true;
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
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMandarinCaseRelaInfoEN._CurrTabName);
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
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMandarinCaseRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvMandarinCaseRelaInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}