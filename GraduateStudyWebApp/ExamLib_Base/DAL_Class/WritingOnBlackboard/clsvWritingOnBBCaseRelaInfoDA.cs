
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWritingOnBBCaseRelaInfoDA
 表名:vWritingOnBBCaseRelaInfo(01120397)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:板书点播(WritingOnBlackboard)
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
 /// vWritingOnBBCaseRelaInfo(vWritingOnBBCaseRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvWritingOnBBCaseRelaInfoDA : clsCommBase4DA
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
 return clsvWritingOnBBCaseRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvWritingOnBBCaseRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvWritingOnBBCaseRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvWritingOnBBCaseRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvWritingOnBBCaseRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vWritingOnBBCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseRelaInfoDA: GetDataTable_vWritingOnBBCaseRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCaseRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCaseRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCaseRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvWritingOnBBCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vWritingOnBBCaseRelaInfo.* from vWritingOnBBCaseRelaInfo Left Join {1} on {2} where {3} and vWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfo from vWritingOnBBCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vWritingOnBBCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vWritingOnBBCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvWritingOnBBCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vWritingOnBBCaseRelaInfo.* from vWritingOnBBCaseRelaInfo Left Join {1} on {2} where {3} and vWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfo from vWritingOnBBCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vWritingOnBBCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vWritingOnBBCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvWritingOnBBCaseRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsvWritingOnBBCaseRelaInfoEN> arrObjLst = new List<clsvWritingOnBBCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN = new clsvWritingOnBBCaseRelaInfoEN();
try
{
objvWritingOnBBCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvWritingOnBBCaseRelaInfoEN.FuncModuleId = objRow[convWritingOnBBCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvWritingOnBBCaseRelaInfoEN.FuncModuleName = objRow[convWritingOnBBCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvWritingOnBBCaseRelaInfoEN.IdMicroteachCase = objRow[convWritingOnBBCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvWritingOnBBCaseRelaInfoEN.Memo = objRow[convWritingOnBBCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.Memo].ToString().Trim(); //备注
objvWritingOnBBCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convWritingOnBBCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvWritingOnBBCaseRelaInfoEN.IdFile = objRow[convWritingOnBBCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvWritingOnBBCaseRelaInfoEN.FileName = objRow[convWritingOnBBCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvWritingOnBBCaseRelaInfoEN.FileType = objRow[convWritingOnBBCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvWritingOnBBCaseRelaInfoEN.SaveDate = objRow[convWritingOnBBCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvWritingOnBBCaseRelaInfoEN.FileSize = objRow[convWritingOnBBCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvWritingOnBBCaseRelaInfoEN.SaveTime = objRow[convWritingOnBBCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvWritingOnBBCaseRelaInfoEN.IdFtpResource = objRow[convWritingOnBBCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvWritingOnBBCaseRelaInfoEN.FtpResourceID = objRow[convWritingOnBBCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvWritingOnBBCaseRelaInfoEN.FileOriginalName = objRow[convWritingOnBBCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvWritingOnBBCaseRelaInfoEN.FileDirName = objRow[convWritingOnBBCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvWritingOnBBCaseRelaInfoEN.FileRename = objRow[convWritingOnBBCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvWritingOnBBCaseRelaInfoEN.FileUpDate = objRow[convWritingOnBBCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvWritingOnBBCaseRelaInfoEN.FileUpTime = objRow[convWritingOnBBCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvWritingOnBBCaseRelaInfoEN.IdResource = objRow[convWritingOnBBCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvWritingOnBBCaseRelaInfoEN.ResourceID = objRow[convWritingOnBBCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvWritingOnBBCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convWritingOnBBCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvWritingOnBBCaseRelaInfoEN.IdResourceType = objRow[convWritingOnBBCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvWritingOnBBCaseRelaInfoEN.ResourceTypeID = objRow[convWritingOnBBCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvWritingOnBBCaseRelaInfoEN.ResourceTypeName = objRow[convWritingOnBBCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvWritingOnBBCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvWritingOnBBCaseRelaInfoEN.BrowseCount = objRow[convWritingOnBBCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvWritingOnBBCaseRelaInfoEN.ResourceOwner = objRow[convWritingOnBBCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvWritingOnBBCaseRelaInfoEN.ftpFileType = objRow[convWritingOnBBCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvWritingOnBBCaseRelaInfoEN.ftpFileSize = objRow[convWritingOnBBCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvWritingOnBBCaseRelaInfoEN.ftpResourceOwner = objRow[convWritingOnBBCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvWritingOnBBCaseRelaInfoEN.FileOriginName = objRow[convWritingOnBBCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvWritingOnBBCaseRelaInfoEN.IdWritingOnBBCase = objRow[convWritingOnBBCaseRelaInfo.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objvWritingOnBBCaseRelaInfoEN.WritingOnBBCaseName = objRow[convWritingOnBBCaseRelaInfo.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objvWritingOnBBCaseRelaInfoEN.Flag = objRow[convWritingOnBBCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.Flag].ToString().Trim(); //标志
objvWritingOnBBCaseRelaInfoEN.FileNewName = objRow[convWritingOnBBCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvWritingOnBBCaseRelaInfoEN.FileOldName = objRow[convWritingOnBBCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvWritingOnBBCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convWritingOnBBCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvWritingOnBBCaseRelaInfoEN.UpdDate = objRow[convWritingOnBBCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvWritingOnBBCaseRelaInfoEN.UpdUser = objRow[convWritingOnBBCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvWritingOnBBCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvWritingOnBBCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvWritingOnBBCaseRelaInfoEN);
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
public List<clsvWritingOnBBCaseRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvWritingOnBBCaseRelaInfoEN> arrObjLst = new List<clsvWritingOnBBCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN = new clsvWritingOnBBCaseRelaInfoEN();
try
{
objvWritingOnBBCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvWritingOnBBCaseRelaInfoEN.FuncModuleId = objRow[convWritingOnBBCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvWritingOnBBCaseRelaInfoEN.FuncModuleName = objRow[convWritingOnBBCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvWritingOnBBCaseRelaInfoEN.IdMicroteachCase = objRow[convWritingOnBBCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvWritingOnBBCaseRelaInfoEN.Memo = objRow[convWritingOnBBCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.Memo].ToString().Trim(); //备注
objvWritingOnBBCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convWritingOnBBCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvWritingOnBBCaseRelaInfoEN.IdFile = objRow[convWritingOnBBCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvWritingOnBBCaseRelaInfoEN.FileName = objRow[convWritingOnBBCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvWritingOnBBCaseRelaInfoEN.FileType = objRow[convWritingOnBBCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvWritingOnBBCaseRelaInfoEN.SaveDate = objRow[convWritingOnBBCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvWritingOnBBCaseRelaInfoEN.FileSize = objRow[convWritingOnBBCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvWritingOnBBCaseRelaInfoEN.SaveTime = objRow[convWritingOnBBCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvWritingOnBBCaseRelaInfoEN.IdFtpResource = objRow[convWritingOnBBCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvWritingOnBBCaseRelaInfoEN.FtpResourceID = objRow[convWritingOnBBCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvWritingOnBBCaseRelaInfoEN.FileOriginalName = objRow[convWritingOnBBCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvWritingOnBBCaseRelaInfoEN.FileDirName = objRow[convWritingOnBBCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvWritingOnBBCaseRelaInfoEN.FileRename = objRow[convWritingOnBBCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvWritingOnBBCaseRelaInfoEN.FileUpDate = objRow[convWritingOnBBCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvWritingOnBBCaseRelaInfoEN.FileUpTime = objRow[convWritingOnBBCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvWritingOnBBCaseRelaInfoEN.IdResource = objRow[convWritingOnBBCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvWritingOnBBCaseRelaInfoEN.ResourceID = objRow[convWritingOnBBCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvWritingOnBBCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convWritingOnBBCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvWritingOnBBCaseRelaInfoEN.IdResourceType = objRow[convWritingOnBBCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvWritingOnBBCaseRelaInfoEN.ResourceTypeID = objRow[convWritingOnBBCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvWritingOnBBCaseRelaInfoEN.ResourceTypeName = objRow[convWritingOnBBCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvWritingOnBBCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvWritingOnBBCaseRelaInfoEN.BrowseCount = objRow[convWritingOnBBCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvWritingOnBBCaseRelaInfoEN.ResourceOwner = objRow[convWritingOnBBCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvWritingOnBBCaseRelaInfoEN.ftpFileType = objRow[convWritingOnBBCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvWritingOnBBCaseRelaInfoEN.ftpFileSize = objRow[convWritingOnBBCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvWritingOnBBCaseRelaInfoEN.ftpResourceOwner = objRow[convWritingOnBBCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvWritingOnBBCaseRelaInfoEN.FileOriginName = objRow[convWritingOnBBCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvWritingOnBBCaseRelaInfoEN.IdWritingOnBBCase = objRow[convWritingOnBBCaseRelaInfo.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objvWritingOnBBCaseRelaInfoEN.WritingOnBBCaseName = objRow[convWritingOnBBCaseRelaInfo.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objvWritingOnBBCaseRelaInfoEN.Flag = objRow[convWritingOnBBCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.Flag].ToString().Trim(); //标志
objvWritingOnBBCaseRelaInfoEN.FileNewName = objRow[convWritingOnBBCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvWritingOnBBCaseRelaInfoEN.FileOldName = objRow[convWritingOnBBCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvWritingOnBBCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convWritingOnBBCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvWritingOnBBCaseRelaInfoEN.UpdDate = objRow[convWritingOnBBCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvWritingOnBBCaseRelaInfoEN.UpdUser = objRow[convWritingOnBBCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvWritingOnBBCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvWritingOnBBCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvWritingOnBBCaseRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvWritingOnBBCaseRelaInfo(ref clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ objvWritingOnBBCaseRelaInfoEN.IdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvWritingOnBBCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objDT.Rows[0][convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.FuncModuleId = objDT.Rows[0][convWritingOnBBCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FuncModuleName = objDT.Rows[0][convWritingOnBBCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.IdMicroteachCase = objDT.Rows[0][convWritingOnBBCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.Memo = objDT.Rows[0][convWritingOnBBCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.IsVisible = TransNullToBool(objDT.Rows[0][convWritingOnBBCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.IdFile = objDT.Rows[0][convWritingOnBBCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileName = objDT.Rows[0][convWritingOnBBCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileType = objDT.Rows[0][convWritingOnBBCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.SaveDate = objDT.Rows[0][convWritingOnBBCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileSize = objDT.Rows[0][convWritingOnBBCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.SaveTime = objDT.Rows[0][convWritingOnBBCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.IdFtpResource = objDT.Rows[0][convWritingOnBBCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FtpResourceID = objDT.Rows[0][convWritingOnBBCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.FileOriginalName = objDT.Rows[0][convWritingOnBBCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileDirName = objDT.Rows[0][convWritingOnBBCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileRename = objDT.Rows[0][convWritingOnBBCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileUpDate = objDT.Rows[0][convWritingOnBBCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileUpTime = objDT.Rows[0][convWritingOnBBCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.IdResource = objDT.Rows[0][convWritingOnBBCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.ResourceID = objDT.Rows[0][convWritingOnBBCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.SaveMode = TransNullToBool(objDT.Rows[0][convWritingOnBBCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.IdResourceType = objDT.Rows[0][convWritingOnBBCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.ResourceTypeID = objDT.Rows[0][convWritingOnBBCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.ResourceTypeName = objDT.Rows[0][convWritingOnBBCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objDT.Rows[0][convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objDT.Rows[0][convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objDT.Rows[0][convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][convWritingOnBBCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.ResourceOwner = objDT.Rows[0][convWritingOnBBCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.ftpFileType = objDT.Rows[0][convWritingOnBBCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.ftpFileSize = objDT.Rows[0][convWritingOnBBCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.ftpResourceOwner = objDT.Rows[0][convWritingOnBBCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileOriginName = objDT.Rows[0][convWritingOnBBCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.IdWritingOnBBCase = objDT.Rows[0][convWritingOnBBCaseRelaInfo.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.WritingOnBBCaseName = objDT.Rows[0][convWritingOnBBCaseRelaInfo.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.Flag = objDT.Rows[0][convWritingOnBBCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileNewName = objDT.Rows[0][convWritingOnBBCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileOldName = objDT.Rows[0][convWritingOnBBCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.IsExistFile = TransNullToBool(objDT.Rows[0][convWritingOnBBCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.UpdDate = objDT.Rows[0][convWritingOnBBCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.UpdUser = objDT.Rows[0][convWritingOnBBCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvWritingOnBBCaseRelaInfoDA: GetvWritingOnBBCaseRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsvWritingOnBBCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN = new clsvWritingOnBBCaseRelaInfoEN();
try
{
 objvWritingOnBBCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.FuncModuleId = objRow[convWritingOnBBCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FuncModuleName = objRow[convWritingOnBBCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.IdMicroteachCase = objRow[convWritingOnBBCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.Memo = objRow[convWritingOnBBCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convWritingOnBBCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.IdFile = objRow[convWritingOnBBCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileName = objRow[convWritingOnBBCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileType = objRow[convWritingOnBBCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.SaveDate = objRow[convWritingOnBBCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileSize = objRow[convWritingOnBBCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.SaveTime = objRow[convWritingOnBBCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.IdFtpResource = objRow[convWritingOnBBCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FtpResourceID = objRow[convWritingOnBBCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.FileOriginalName = objRow[convWritingOnBBCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileDirName = objRow[convWritingOnBBCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileRename = objRow[convWritingOnBBCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileUpDate = objRow[convWritingOnBBCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileUpTime = objRow[convWritingOnBBCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.IdResource = objRow[convWritingOnBBCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.ResourceID = objRow[convWritingOnBBCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convWritingOnBBCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.IdResourceType = objRow[convWritingOnBBCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.ResourceTypeID = objRow[convWritingOnBBCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.ResourceTypeName = objRow[convWritingOnBBCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.BrowseCount = objRow[convWritingOnBBCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWritingOnBBCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.ResourceOwner = objRow[convWritingOnBBCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.ftpFileType = objRow[convWritingOnBBCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.ftpFileSize = objRow[convWritingOnBBCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.ftpResourceOwner = objRow[convWritingOnBBCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileOriginName = objRow[convWritingOnBBCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.IdWritingOnBBCase = objRow[convWritingOnBBCaseRelaInfo.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.WritingOnBBCaseName = objRow[convWritingOnBBCaseRelaInfo.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWritingOnBBCaseRelaInfoEN.Flag = objRow[convWritingOnBBCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileNewName = objRow[convWritingOnBBCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.FileOldName = objRow[convWritingOnBBCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convWritingOnBBCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.UpdDate = objRow[convWritingOnBBCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseRelaInfoEN.UpdUser = objRow[convWritingOnBBCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvWritingOnBBCaseRelaInfoDA: GetObjByIdMicroTeachCaseRelaInfo)", objException.Message));
}
return objvWritingOnBBCaseRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvWritingOnBBCaseRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN = new clsvWritingOnBBCaseRelaInfoEN()
{
IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()), //案例相关信息流水号
FuncModuleId = objRow[convWritingOnBBCaseRelaInfo.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convWritingOnBBCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convWritingOnBBCaseRelaInfo.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
Memo = objRow[convWritingOnBBCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.Memo].ToString().Trim(), //备注
IsVisible = TransNullToBool(objRow[convWritingOnBBCaseRelaInfo.IsVisible].ToString().Trim()), //是否显示
IdFile = objRow[convWritingOnBBCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convWritingOnBBCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileName].ToString().Trim(), //文件名称
FileType = objRow[convWritingOnBBCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convWritingOnBBCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convWritingOnBBCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convWritingOnBBCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.SaveTime].ToString().Trim(), //创建时间
IdFtpResource = objRow[convWritingOnBBCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.IdFtpResource].ToString().Trim(), //FTP资源流水号
FtpResourceID = objRow[convWritingOnBBCaseRelaInfo.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convWritingOnBBCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convWritingOnBBCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convWritingOnBBCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convWritingOnBBCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convWritingOnBBCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileUpTime].ToString().Trim(), //创建时间
IdResource = objRow[convWritingOnBBCaseRelaInfo.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convWritingOnBBCaseRelaInfo.ResourceID].ToString().Trim(), //资源ID
SaveMode = TransNullToBool(objRow[convWritingOnBBCaseRelaInfo.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convWritingOnBBCaseRelaInfo.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convWritingOnBBCaseRelaInfo.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convWritingOnBBCaseRelaInfo.ResourceTypeName].ToString().Trim(), //资源类型名称
IdMicroTeachCaseRelaInfoType = objRow[convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(), //微格案例相关信息类型流水号
MicroTeachCaseRelaInfoTypeID = objRow[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(), //微格案例相关信息类型ID
MicroTeachCaseRelaInfoTypeName = objRow[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(), //微格案例相关信息类型名称
BrowseCount = objRow[convWritingOnBBCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCaseRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
ResourceOwner = objRow[convWritingOnBBCaseRelaInfo.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convWritingOnBBCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convWritingOnBBCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convWritingOnBBCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convWritingOnBBCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOriginName].ToString().Trim(), //原文件名
IdWritingOnBBCase = objRow[convWritingOnBBCaseRelaInfo.IdWritingOnBBCase].ToString().Trim(), //板书案例流水号
WritingOnBBCaseName = objRow[convWritingOnBBCaseRelaInfo.WritingOnBBCaseName].ToString().Trim(), //板书教学案例名称
Flag = objRow[convWritingOnBBCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.Flag].ToString().Trim(), //标志
FileNewName = objRow[convWritingOnBBCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convWritingOnBBCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOldName].ToString().Trim(), //旧文件名
IsExistFile = TransNullToBool(objRow[convWritingOnBBCaseRelaInfo.IsExistFile].ToString().Trim()), //是否存在文件
UpdDate = objRow[convWritingOnBBCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convWritingOnBBCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.UpdUser].ToString().Trim() //修改人
};
objvWritingOnBBCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWritingOnBBCaseRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvWritingOnBBCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvWritingOnBBCaseRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN = new clsvWritingOnBBCaseRelaInfoEN();
try
{
objvWritingOnBBCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvWritingOnBBCaseRelaInfoEN.FuncModuleId = objRow[convWritingOnBBCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvWritingOnBBCaseRelaInfoEN.FuncModuleName = objRow[convWritingOnBBCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvWritingOnBBCaseRelaInfoEN.IdMicroteachCase = objRow[convWritingOnBBCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvWritingOnBBCaseRelaInfoEN.Memo = objRow[convWritingOnBBCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.Memo].ToString().Trim(); //备注
objvWritingOnBBCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convWritingOnBBCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvWritingOnBBCaseRelaInfoEN.IdFile = objRow[convWritingOnBBCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvWritingOnBBCaseRelaInfoEN.FileName = objRow[convWritingOnBBCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvWritingOnBBCaseRelaInfoEN.FileType = objRow[convWritingOnBBCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvWritingOnBBCaseRelaInfoEN.SaveDate = objRow[convWritingOnBBCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvWritingOnBBCaseRelaInfoEN.FileSize = objRow[convWritingOnBBCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvWritingOnBBCaseRelaInfoEN.SaveTime = objRow[convWritingOnBBCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvWritingOnBBCaseRelaInfoEN.IdFtpResource = objRow[convWritingOnBBCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvWritingOnBBCaseRelaInfoEN.FtpResourceID = objRow[convWritingOnBBCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvWritingOnBBCaseRelaInfoEN.FileOriginalName = objRow[convWritingOnBBCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvWritingOnBBCaseRelaInfoEN.FileDirName = objRow[convWritingOnBBCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvWritingOnBBCaseRelaInfoEN.FileRename = objRow[convWritingOnBBCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvWritingOnBBCaseRelaInfoEN.FileUpDate = objRow[convWritingOnBBCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvWritingOnBBCaseRelaInfoEN.FileUpTime = objRow[convWritingOnBBCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvWritingOnBBCaseRelaInfoEN.IdResource = objRow[convWritingOnBBCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvWritingOnBBCaseRelaInfoEN.ResourceID = objRow[convWritingOnBBCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvWritingOnBBCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convWritingOnBBCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvWritingOnBBCaseRelaInfoEN.IdResourceType = objRow[convWritingOnBBCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvWritingOnBBCaseRelaInfoEN.ResourceTypeID = objRow[convWritingOnBBCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvWritingOnBBCaseRelaInfoEN.ResourceTypeName = objRow[convWritingOnBBCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvWritingOnBBCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvWritingOnBBCaseRelaInfoEN.BrowseCount = objRow[convWritingOnBBCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvWritingOnBBCaseRelaInfoEN.ResourceOwner = objRow[convWritingOnBBCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvWritingOnBBCaseRelaInfoEN.ftpFileType = objRow[convWritingOnBBCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvWritingOnBBCaseRelaInfoEN.ftpFileSize = objRow[convWritingOnBBCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvWritingOnBBCaseRelaInfoEN.ftpResourceOwner = objRow[convWritingOnBBCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvWritingOnBBCaseRelaInfoEN.FileOriginName = objRow[convWritingOnBBCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvWritingOnBBCaseRelaInfoEN.IdWritingOnBBCase = objRow[convWritingOnBBCaseRelaInfo.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objvWritingOnBBCaseRelaInfoEN.WritingOnBBCaseName = objRow[convWritingOnBBCaseRelaInfo.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objvWritingOnBBCaseRelaInfoEN.Flag = objRow[convWritingOnBBCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.Flag].ToString().Trim(); //标志
objvWritingOnBBCaseRelaInfoEN.FileNewName = objRow[convWritingOnBBCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvWritingOnBBCaseRelaInfoEN.FileOldName = objRow[convWritingOnBBCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvWritingOnBBCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convWritingOnBBCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvWritingOnBBCaseRelaInfoEN.UpdDate = objRow[convWritingOnBBCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvWritingOnBBCaseRelaInfoEN.UpdUser = objRow[convWritingOnBBCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvWritingOnBBCaseRelaInfoDA: GetObjByDataRowvWritingOnBBCaseRelaInfo)", objException.Message));
}
objvWritingOnBBCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWritingOnBBCaseRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvWritingOnBBCaseRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN = new clsvWritingOnBBCaseRelaInfoEN();
try
{
objvWritingOnBBCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvWritingOnBBCaseRelaInfoEN.FuncModuleId = objRow[convWritingOnBBCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvWritingOnBBCaseRelaInfoEN.FuncModuleName = objRow[convWritingOnBBCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvWritingOnBBCaseRelaInfoEN.IdMicroteachCase = objRow[convWritingOnBBCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvWritingOnBBCaseRelaInfoEN.Memo = objRow[convWritingOnBBCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.Memo].ToString().Trim(); //备注
objvWritingOnBBCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convWritingOnBBCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvWritingOnBBCaseRelaInfoEN.IdFile = objRow[convWritingOnBBCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvWritingOnBBCaseRelaInfoEN.FileName = objRow[convWritingOnBBCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvWritingOnBBCaseRelaInfoEN.FileType = objRow[convWritingOnBBCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvWritingOnBBCaseRelaInfoEN.SaveDate = objRow[convWritingOnBBCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvWritingOnBBCaseRelaInfoEN.FileSize = objRow[convWritingOnBBCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvWritingOnBBCaseRelaInfoEN.SaveTime = objRow[convWritingOnBBCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvWritingOnBBCaseRelaInfoEN.IdFtpResource = objRow[convWritingOnBBCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvWritingOnBBCaseRelaInfoEN.FtpResourceID = objRow[convWritingOnBBCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvWritingOnBBCaseRelaInfoEN.FileOriginalName = objRow[convWritingOnBBCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvWritingOnBBCaseRelaInfoEN.FileDirName = objRow[convWritingOnBBCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvWritingOnBBCaseRelaInfoEN.FileRename = objRow[convWritingOnBBCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvWritingOnBBCaseRelaInfoEN.FileUpDate = objRow[convWritingOnBBCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvWritingOnBBCaseRelaInfoEN.FileUpTime = objRow[convWritingOnBBCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvWritingOnBBCaseRelaInfoEN.IdResource = objRow[convWritingOnBBCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvWritingOnBBCaseRelaInfoEN.ResourceID = objRow[convWritingOnBBCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvWritingOnBBCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convWritingOnBBCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvWritingOnBBCaseRelaInfoEN.IdResourceType = objRow[convWritingOnBBCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvWritingOnBBCaseRelaInfoEN.ResourceTypeID = objRow[convWritingOnBBCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvWritingOnBBCaseRelaInfoEN.ResourceTypeName = objRow[convWritingOnBBCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvWritingOnBBCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvWritingOnBBCaseRelaInfoEN.BrowseCount = objRow[convWritingOnBBCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvWritingOnBBCaseRelaInfoEN.ResourceOwner = objRow[convWritingOnBBCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvWritingOnBBCaseRelaInfoEN.ftpFileType = objRow[convWritingOnBBCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvWritingOnBBCaseRelaInfoEN.ftpFileSize = objRow[convWritingOnBBCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvWritingOnBBCaseRelaInfoEN.ftpResourceOwner = objRow[convWritingOnBBCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvWritingOnBBCaseRelaInfoEN.FileOriginName = objRow[convWritingOnBBCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvWritingOnBBCaseRelaInfoEN.IdWritingOnBBCase = objRow[convWritingOnBBCaseRelaInfo.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objvWritingOnBBCaseRelaInfoEN.WritingOnBBCaseName = objRow[convWritingOnBBCaseRelaInfo.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objvWritingOnBBCaseRelaInfoEN.Flag = objRow[convWritingOnBBCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.Flag].ToString().Trim(); //标志
objvWritingOnBBCaseRelaInfoEN.FileNewName = objRow[convWritingOnBBCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvWritingOnBBCaseRelaInfoEN.FileOldName = objRow[convWritingOnBBCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvWritingOnBBCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convWritingOnBBCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvWritingOnBBCaseRelaInfoEN.UpdDate = objRow[convWritingOnBBCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvWritingOnBBCaseRelaInfoEN.UpdUser = objRow[convWritingOnBBCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvWritingOnBBCaseRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objvWritingOnBBCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWritingOnBBCaseRelaInfoEN;
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
objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvWritingOnBBCaseRelaInfoEN._CurrTabName, convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, "");
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
objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvWritingOnBBCaseRelaInfoEN._CurrTabName, convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vWritingOnBBCaseRelaInfo where " + strCondition;
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
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vWritingOnBBCaseRelaInfo where " + strCondition;
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
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vWritingOnBBCaseRelaInfo", "IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vWritingOnBBCaseRelaInfo", strCondition))
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
objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vWritingOnBBCaseRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseRelaInfoENS">源对象</param>
 /// <param name = "objvWritingOnBBCaseRelaInfoENT">目标对象</param>
public void CopyTo(clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoENS, clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoENT)
{
objvWritingOnBBCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objvWritingOnBBCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvWritingOnBBCaseRelaInfoENT.FuncModuleId = objvWritingOnBBCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvWritingOnBBCaseRelaInfoENT.FuncModuleName = objvWritingOnBBCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvWritingOnBBCaseRelaInfoENT.IdMicroteachCase = objvWritingOnBBCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvWritingOnBBCaseRelaInfoENT.Memo = objvWritingOnBBCaseRelaInfoENS.Memo; //备注
objvWritingOnBBCaseRelaInfoENT.IsVisible = objvWritingOnBBCaseRelaInfoENS.IsVisible; //是否显示
objvWritingOnBBCaseRelaInfoENT.IdFile = objvWritingOnBBCaseRelaInfoENS.IdFile; //文件流水号
objvWritingOnBBCaseRelaInfoENT.FileName = objvWritingOnBBCaseRelaInfoENS.FileName; //文件名称
objvWritingOnBBCaseRelaInfoENT.FileType = objvWritingOnBBCaseRelaInfoENS.FileType; //文件类型
objvWritingOnBBCaseRelaInfoENT.SaveDate = objvWritingOnBBCaseRelaInfoENS.SaveDate; //创建日期
objvWritingOnBBCaseRelaInfoENT.FileSize = objvWritingOnBBCaseRelaInfoENS.FileSize; //文件大小
objvWritingOnBBCaseRelaInfoENT.SaveTime = objvWritingOnBBCaseRelaInfoENS.SaveTime; //创建时间
objvWritingOnBBCaseRelaInfoENT.IdFtpResource = objvWritingOnBBCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvWritingOnBBCaseRelaInfoENT.FtpResourceID = objvWritingOnBBCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvWritingOnBBCaseRelaInfoENT.FileOriginalName = objvWritingOnBBCaseRelaInfoENS.FileOriginalName; //文件原名
objvWritingOnBBCaseRelaInfoENT.FileDirName = objvWritingOnBBCaseRelaInfoENS.FileDirName; //文件目录名
objvWritingOnBBCaseRelaInfoENT.FileRename = objvWritingOnBBCaseRelaInfoENS.FileRename; //文件新名
objvWritingOnBBCaseRelaInfoENT.FileUpDate = objvWritingOnBBCaseRelaInfoENS.FileUpDate; //创建日期
objvWritingOnBBCaseRelaInfoENT.FileUpTime = objvWritingOnBBCaseRelaInfoENS.FileUpTime; //创建时间
objvWritingOnBBCaseRelaInfoENT.IdResource = objvWritingOnBBCaseRelaInfoENS.IdResource; //资源流水号
objvWritingOnBBCaseRelaInfoENT.ResourceID = objvWritingOnBBCaseRelaInfoENS.ResourceID; //资源ID
objvWritingOnBBCaseRelaInfoENT.SaveMode = objvWritingOnBBCaseRelaInfoENS.SaveMode; //文件存放方式
objvWritingOnBBCaseRelaInfoENT.IdResourceType = objvWritingOnBBCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvWritingOnBBCaseRelaInfoENT.ResourceTypeID = objvWritingOnBBCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvWritingOnBBCaseRelaInfoENT.ResourceTypeName = objvWritingOnBBCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvWritingOnBBCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvWritingOnBBCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvWritingOnBBCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvWritingOnBBCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvWritingOnBBCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvWritingOnBBCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvWritingOnBBCaseRelaInfoENT.BrowseCount = objvWritingOnBBCaseRelaInfoENS.BrowseCount; //浏览次数
objvWritingOnBBCaseRelaInfoENT.ResourceOwner = objvWritingOnBBCaseRelaInfoENS.ResourceOwner; //上传者
objvWritingOnBBCaseRelaInfoENT.ftpFileType = objvWritingOnBBCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvWritingOnBBCaseRelaInfoENT.ftpFileSize = objvWritingOnBBCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvWritingOnBBCaseRelaInfoENT.ftpResourceOwner = objvWritingOnBBCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvWritingOnBBCaseRelaInfoENT.FileOriginName = objvWritingOnBBCaseRelaInfoENS.FileOriginName; //原文件名
objvWritingOnBBCaseRelaInfoENT.IdWritingOnBBCase = objvWritingOnBBCaseRelaInfoENS.IdWritingOnBBCase; //板书案例流水号
objvWritingOnBBCaseRelaInfoENT.WritingOnBBCaseName = objvWritingOnBBCaseRelaInfoENS.WritingOnBBCaseName; //板书教学案例名称
objvWritingOnBBCaseRelaInfoENT.Flag = objvWritingOnBBCaseRelaInfoENS.Flag; //标志
objvWritingOnBBCaseRelaInfoENT.FileNewName = objvWritingOnBBCaseRelaInfoENS.FileNewName; //新文件名
objvWritingOnBBCaseRelaInfoENT.FileOldName = objvWritingOnBBCaseRelaInfoENS.FileOldName; //旧文件名
objvWritingOnBBCaseRelaInfoENT.IsExistFile = objvWritingOnBBCaseRelaInfoENS.IsExistFile; //是否存在文件
objvWritingOnBBCaseRelaInfoENT.UpdDate = objvWritingOnBBCaseRelaInfoENS.UpdDate; //修改日期
objvWritingOnBBCaseRelaInfoENT.UpdUser = objvWritingOnBBCaseRelaInfoENS.UpdUser; //修改人
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvWritingOnBBCaseRelaInfoEN objvWritingOnBBCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.FuncModuleId, 4, convWritingOnBBCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.FuncModuleName, 30, convWritingOnBBCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.IdMicroteachCase, 8, convWritingOnBBCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.Memo, 1000, convWritingOnBBCaseRelaInfo.Memo);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.IdFile, 8, convWritingOnBBCaseRelaInfo.IdFile);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.FileName, 500, convWritingOnBBCaseRelaInfo.FileName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.FileType, 30, convWritingOnBBCaseRelaInfo.FileType);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.SaveDate, 8, convWritingOnBBCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.FileSize, 50, convWritingOnBBCaseRelaInfo.FileSize);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.SaveTime, 6, convWritingOnBBCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.IdFtpResource, 8, convWritingOnBBCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.FtpResourceID, 8, convWritingOnBBCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.FileOriginalName, 200, convWritingOnBBCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.FileDirName, 200, convWritingOnBBCaseRelaInfo.FileDirName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.FileRename, 200, convWritingOnBBCaseRelaInfo.FileRename);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.FileUpDate, 8, convWritingOnBBCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.FileUpTime, 6, convWritingOnBBCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.IdResource, 8, convWritingOnBBCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.ResourceID, 8, convWritingOnBBCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.IdResourceType, 4, convWritingOnBBCaseRelaInfo.IdResourceType);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.ResourceTypeID, 4, convWritingOnBBCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.ResourceTypeName, 50, convWritingOnBBCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, 4, convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, 4, convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, 50, convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.ResourceOwner, 50, convWritingOnBBCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.ftpFileType, 30, convWritingOnBBCaseRelaInfo.ftpFileType);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.ftpFileSize, 50, convWritingOnBBCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.ftpResourceOwner, 50, convWritingOnBBCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.FileOriginName, 500, convWritingOnBBCaseRelaInfo.FileOriginName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.IdWritingOnBBCase, 8, convWritingOnBBCaseRelaInfo.IdWritingOnBBCase);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.WritingOnBBCaseName, 100, convWritingOnBBCaseRelaInfo.WritingOnBBCaseName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.Flag, 50, convWritingOnBBCaseRelaInfo.Flag);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.FileNewName, 530, convWritingOnBBCaseRelaInfo.FileNewName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.FileOldName, 530, convWritingOnBBCaseRelaInfo.FileOldName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.UpdDate, 20, convWritingOnBBCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseRelaInfoEN.UpdUser, 20, convWritingOnBBCaseRelaInfo.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.FuncModuleId, convWritingOnBBCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.FuncModuleName, convWritingOnBBCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.IdMicroteachCase, convWritingOnBBCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.Memo, convWritingOnBBCaseRelaInfo.Memo);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.IdFile, convWritingOnBBCaseRelaInfo.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.FileName, convWritingOnBBCaseRelaInfo.FileName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.FileType, convWritingOnBBCaseRelaInfo.FileType);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.SaveDate, convWritingOnBBCaseRelaInfo.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.FileSize, convWritingOnBBCaseRelaInfo.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.SaveTime, convWritingOnBBCaseRelaInfo.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.IdFtpResource, convWritingOnBBCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.FtpResourceID, convWritingOnBBCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.FileOriginalName, convWritingOnBBCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.FileDirName, convWritingOnBBCaseRelaInfo.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.FileRename, convWritingOnBBCaseRelaInfo.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.FileUpDate, convWritingOnBBCaseRelaInfo.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.FileUpTime, convWritingOnBBCaseRelaInfo.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.IdResource, convWritingOnBBCaseRelaInfo.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.ResourceID, convWritingOnBBCaseRelaInfo.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.IdResourceType, convWritingOnBBCaseRelaInfo.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.ResourceTypeID, convWritingOnBBCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.ResourceTypeName, convWritingOnBBCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, convWritingOnBBCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID, convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, convWritingOnBBCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.ResourceOwner, convWritingOnBBCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.ftpFileType, convWritingOnBBCaseRelaInfo.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.ftpFileSize, convWritingOnBBCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.ftpResourceOwner, convWritingOnBBCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.FileOriginName, convWritingOnBBCaseRelaInfo.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.IdWritingOnBBCase, convWritingOnBBCaseRelaInfo.IdWritingOnBBCase);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.WritingOnBBCaseName, convWritingOnBBCaseRelaInfo.WritingOnBBCaseName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.Flag, convWritingOnBBCaseRelaInfo.Flag);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.FileNewName, convWritingOnBBCaseRelaInfo.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.FileOldName, convWritingOnBBCaseRelaInfo.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.UpdDate, convWritingOnBBCaseRelaInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseRelaInfoEN.UpdUser, convWritingOnBBCaseRelaInfo.UpdUser);
//检查外键字段长度
 objvWritingOnBBCaseRelaInfoEN._IsCheckProperty = true;
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
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvWritingOnBBCaseRelaInfoEN._CurrTabName);
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
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvWritingOnBBCaseRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvWritingOnBBCaseRelaInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}