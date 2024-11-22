
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachCaseDA
 表名:MicroteachCase(01120322)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:26
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
 框架-层名:数据处理层(CS)(DALCode,0002)
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
 /// 微格教学案例(MicroteachCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsMicroteachCaseDA : clsCommBase4DA
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
 return clsMicroteachCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsMicroteachCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMicroteachCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsMicroteachCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsMicroteachCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdMicroteachCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdMicroteachCase)
{
strIdMicroteachCase = strIdMicroteachCase.Replace("'", "''");
if (strIdMicroteachCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:MicroteachCase中,检查关键字,长度不正确!(clsMicroteachCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdMicroteachCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:MicroteachCase中,关键字不能为空 或 null!(clsMicroteachCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdMicroteachCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsMicroteachCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsMicroteachCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_MicroteachCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsMicroteachCaseDA: GetDataTable_MicroteachCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsMicroteachCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsMicroteachCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsMicroteachCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsMicroteachCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MicroteachCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MicroteachCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsMicroteachCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from MicroteachCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsMicroteachCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} MicroteachCase.* from MicroteachCase Left Join {1} on {2} where {3} and MicroteachCase.IdMicroteachCase not in (Select top {5} MicroteachCase.IdMicroteachCase from MicroteachCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MicroteachCase where {1} and IdMicroteachCase not in (Select top {2} IdMicroteachCase from MicroteachCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MicroteachCase where {1} and IdMicroteachCase not in (Select top {3} IdMicroteachCase from MicroteachCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsMicroteachCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} MicroteachCase.* from MicroteachCase Left Join {1} on {2} where {3} and MicroteachCase.IdMicroteachCase not in (Select top {5} MicroteachCase.IdMicroteachCase from MicroteachCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MicroteachCase where {1} and IdMicroteachCase not in (Select top {2} IdMicroteachCase from MicroteachCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MicroteachCase where {1} and IdMicroteachCase not in (Select top {3} IdMicroteachCase from MicroteachCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsMicroteachCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsMicroteachCaseDA:GetObjLst)", objException.Message));
}
List<clsMicroteachCaseEN> arrObjLst = new List<clsMicroteachCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseEN objMicroteachCaseEN = new clsMicroteachCaseEN();
try
{
objMicroteachCaseEN.IdMicroteachCase = objRow[conMicroteachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseEN.MicroteachCaseID = objRow[conMicroteachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objMicroteachCaseEN.MicroteachCaseName = objRow[conMicroteachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objMicroteachCaseEN.MicroteachCaseTheme = objRow[conMicroteachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objMicroteachCaseEN.MicroteachCaseDate = objRow[conMicroteachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objMicroteachCaseEN.MicroteachCaseTime = objRow[conMicroteachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objMicroteachCaseEN.MicroteachCaseDateIn = objRow[conMicroteachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objMicroteachCaseEN.IdStudyLevel = objRow[conMicroteachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMicroteachCaseEN.IdTeachingPlan = objRow[conMicroteachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conMicroteachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMicroteachCaseEN.MicroTeachCaseTimeIn = objRow[conMicroteachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objMicroteachCaseEN.IdMicroteachCaseType = objRow[conMicroteachCase.IdMicroteachCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseEN.IdCaseType = objRow[conMicroteachCase.IdCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objMicroteachCaseEN.IdDiscipline = objRow[conMicroteachCase.IdDiscipline].ToString().Trim(); //学科流水号
objMicroteachCaseEN.BrowseCount = objRow[conMicroteachCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroteachCase.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseEN.IdSenateGaugeVersion = objRow[conMicroteachCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseEN.IdTeachSkill = objRow[conMicroteachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objMicroteachCaseEN.CaseLevelId = objRow[conMicroteachCase.CaseLevelId] == DBNull.Value ? null : objRow[conMicroteachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMicroteachCaseEN.DocFile = objRow[conMicroteachCase.DocFile] == DBNull.Value ? null : objRow[conMicroteachCase.DocFile].ToString().Trim(); //生成的Word文件名
objMicroteachCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conMicroteachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMicroteachCaseEN.WordCreateDate = objRow[conMicroteachCase.WordCreateDate] == DBNull.Value ? null : objRow[conMicroteachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMicroteachCaseEN.IsVisible = TransNullToBool(objRow[conMicroteachCase.IsVisible].ToString().Trim()); //是否显示
objMicroteachCaseEN.microteachCaseText = objRow[conMicroteachCase.microteachCaseText] == DBNull.Value ? null : objRow[conMicroteachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objMicroteachCaseEN.OwnerId = objRow[conMicroteachCase.OwnerId].ToString().Trim(); //拥有者Id
objMicroteachCaseEN.IsDualVideo = TransNullToBool(objRow[conMicroteachCase.IsDualVideo].ToString().Trim()); //是否双视频
objMicroteachCaseEN.UserKindId = objRow[conMicroteachCase.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseEN.UserTypeId = objRow[conMicroteachCase.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCase.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseEN.RecommendedDegreeId = objRow[conMicroteachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMicroteachCaseEN.ftpFileType = objRow[conMicroteachCase.ftpFileType] == DBNull.Value ? null : objRow[conMicroteachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMicroteachCaseEN.VideoUrl = objRow[conMicroteachCase.VideoUrl] == DBNull.Value ? null : objRow[conMicroteachCase.VideoUrl].ToString().Trim(); //视频Url
objMicroteachCaseEN.VideoPath = objRow[conMicroteachCase.VideoPath] == DBNull.Value ? null : objRow[conMicroteachCase.VideoPath].ToString().Trim(); //视频目录
objMicroteachCaseEN.ResErrMsg = objRow[conMicroteachCase.ResErrMsg] == DBNull.Value ? null : objRow[conMicroteachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMicroteachCaseEN.UpdDate = objRow[conMicroteachCase.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseEN.UpdUserId = objRow[conMicroteachCase.UpdUserId] == DBNull.Value ? null : objRow[conMicroteachCase.UpdUserId].ToString().Trim(); //修改用户Id
objMicroteachCaseEN.Memo = objRow[conMicroteachCase.Memo] == DBNull.Value ? null : objRow[conMicroteachCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsMicroteachCaseDA: GetObjLst)", objException.Message));
}
objMicroteachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objMicroteachCaseEN);
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
public List<clsMicroteachCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsMicroteachCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsMicroteachCaseEN> arrObjLst = new List<clsMicroteachCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseEN objMicroteachCaseEN = new clsMicroteachCaseEN();
try
{
objMicroteachCaseEN.IdMicroteachCase = objRow[conMicroteachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseEN.MicroteachCaseID = objRow[conMicroteachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objMicroteachCaseEN.MicroteachCaseName = objRow[conMicroteachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objMicroteachCaseEN.MicroteachCaseTheme = objRow[conMicroteachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objMicroteachCaseEN.MicroteachCaseDate = objRow[conMicroteachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objMicroteachCaseEN.MicroteachCaseTime = objRow[conMicroteachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objMicroteachCaseEN.MicroteachCaseDateIn = objRow[conMicroteachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objMicroteachCaseEN.IdStudyLevel = objRow[conMicroteachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMicroteachCaseEN.IdTeachingPlan = objRow[conMicroteachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conMicroteachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMicroteachCaseEN.MicroTeachCaseTimeIn = objRow[conMicroteachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objMicroteachCaseEN.IdMicroteachCaseType = objRow[conMicroteachCase.IdMicroteachCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseEN.IdCaseType = objRow[conMicroteachCase.IdCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objMicroteachCaseEN.IdDiscipline = objRow[conMicroteachCase.IdDiscipline].ToString().Trim(); //学科流水号
objMicroteachCaseEN.BrowseCount = objRow[conMicroteachCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroteachCase.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseEN.IdSenateGaugeVersion = objRow[conMicroteachCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseEN.IdTeachSkill = objRow[conMicroteachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objMicroteachCaseEN.CaseLevelId = objRow[conMicroteachCase.CaseLevelId] == DBNull.Value ? null : objRow[conMicroteachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMicroteachCaseEN.DocFile = objRow[conMicroteachCase.DocFile] == DBNull.Value ? null : objRow[conMicroteachCase.DocFile].ToString().Trim(); //生成的Word文件名
objMicroteachCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conMicroteachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMicroteachCaseEN.WordCreateDate = objRow[conMicroteachCase.WordCreateDate] == DBNull.Value ? null : objRow[conMicroteachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMicroteachCaseEN.IsVisible = TransNullToBool(objRow[conMicroteachCase.IsVisible].ToString().Trim()); //是否显示
objMicroteachCaseEN.microteachCaseText = objRow[conMicroteachCase.microteachCaseText] == DBNull.Value ? null : objRow[conMicroteachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objMicroteachCaseEN.OwnerId = objRow[conMicroteachCase.OwnerId].ToString().Trim(); //拥有者Id
objMicroteachCaseEN.IsDualVideo = TransNullToBool(objRow[conMicroteachCase.IsDualVideo].ToString().Trim()); //是否双视频
objMicroteachCaseEN.UserKindId = objRow[conMicroteachCase.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseEN.UserTypeId = objRow[conMicroteachCase.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCase.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseEN.RecommendedDegreeId = objRow[conMicroteachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMicroteachCaseEN.ftpFileType = objRow[conMicroteachCase.ftpFileType] == DBNull.Value ? null : objRow[conMicroteachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMicroteachCaseEN.VideoUrl = objRow[conMicroteachCase.VideoUrl] == DBNull.Value ? null : objRow[conMicroteachCase.VideoUrl].ToString().Trim(); //视频Url
objMicroteachCaseEN.VideoPath = objRow[conMicroteachCase.VideoPath] == DBNull.Value ? null : objRow[conMicroteachCase.VideoPath].ToString().Trim(); //视频目录
objMicroteachCaseEN.ResErrMsg = objRow[conMicroteachCase.ResErrMsg] == DBNull.Value ? null : objRow[conMicroteachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMicroteachCaseEN.UpdDate = objRow[conMicroteachCase.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseEN.UpdUserId = objRow[conMicroteachCase.UpdUserId] == DBNull.Value ? null : objRow[conMicroteachCase.UpdUserId].ToString().Trim(); //修改用户Id
objMicroteachCaseEN.Memo = objRow[conMicroteachCase.Memo] == DBNull.Value ? null : objRow[conMicroteachCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsMicroteachCaseDA: GetObjLst)", objException.Message));
}
objMicroteachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objMicroteachCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetMicroteachCase(ref clsMicroteachCaseEN objMicroteachCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCase where IdMicroteachCase = " + "'"+ objMicroteachCaseEN.IdMicroteachCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objMicroteachCaseEN.IdMicroteachCase = objDT.Rows[0][conMicroteachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objMicroteachCaseEN.MicroteachCaseID = objDT.Rows[0][conMicroteachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objMicroteachCaseEN.MicroteachCaseName = objDT.Rows[0][conMicroteachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objMicroteachCaseEN.MicroteachCaseTheme = objDT.Rows[0][conMicroteachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objMicroteachCaseEN.MicroteachCaseDate = objDT.Rows[0][conMicroteachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objMicroteachCaseEN.MicroteachCaseTime = objDT.Rows[0][conMicroteachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间(字段类型:char,字段长度:6,是否可空:True)
 objMicroteachCaseEN.MicroteachCaseDateIn = objDT.Rows[0][conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objMicroteachCaseEN.IdStudyLevel = objDT.Rows[0][conMicroteachCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objMicroteachCaseEN.IdTeachingPlan = objDT.Rows[0][conMicroteachCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objMicroteachCaseEN.MicroTeachCaseTimeIn = objDT.Rows[0][conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objMicroteachCaseEN.IdMicroteachCaseType = objDT.Rows[0][conMicroteachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objMicroteachCaseEN.IdCaseType = objDT.Rows[0][conMicroteachCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objMicroteachCaseEN.IdDiscipline = objDT.Rows[0][conMicroteachCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objMicroteachCaseEN.BrowseCount = TransNullToInt(objDT.Rows[0][conMicroteachCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objMicroteachCaseEN.IdSenateGaugeVersion = objDT.Rows[0][conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objMicroteachCaseEN.IdTeachSkill = objDT.Rows[0][conMicroteachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objMicroteachCaseEN.CaseLevelId = objDT.Rows[0][conMicroteachCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objMicroteachCaseEN.DocFile = objDT.Rows[0][conMicroteachCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objMicroteachCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][conMicroteachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objMicroteachCaseEN.WordCreateDate = objDT.Rows[0][conMicroteachCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objMicroteachCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][conMicroteachCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objMicroteachCaseEN.microteachCaseText = objDT.Rows[0][conMicroteachCase.microteachCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objMicroteachCaseEN.OwnerId = objDT.Rows[0][conMicroteachCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objMicroteachCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][conMicroteachCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objMicroteachCaseEN.UserKindId = objDT.Rows[0][conMicroteachCase.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objMicroteachCaseEN.UserTypeId = objDT.Rows[0][conMicroteachCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objMicroteachCaseEN.RecommendedDegreeId = objDT.Rows[0][conMicroteachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objMicroteachCaseEN.ftpFileType = objDT.Rows[0][conMicroteachCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objMicroteachCaseEN.VideoUrl = objDT.Rows[0][conMicroteachCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objMicroteachCaseEN.VideoPath = objDT.Rows[0][conMicroteachCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objMicroteachCaseEN.ResErrMsg = objDT.Rows[0][conMicroteachCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objMicroteachCaseEN.UpdDate = objDT.Rows[0][conMicroteachCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objMicroteachCaseEN.UpdUserId = objDT.Rows[0][conMicroteachCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objMicroteachCaseEN.Memo = objDT.Rows[0][conMicroteachCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsMicroteachCaseDA: GetMicroteachCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdMicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public clsMicroteachCaseEN GetObjByIdMicroteachCase(string strIdMicroteachCase)
{
CheckPrimaryKey(strIdMicroteachCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCase where IdMicroteachCase = " + "'"+ strIdMicroteachCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsMicroteachCaseEN objMicroteachCaseEN = new clsMicroteachCaseEN();
try
{
 objMicroteachCaseEN.IdMicroteachCase = objRow[conMicroteachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objMicroteachCaseEN.MicroteachCaseID = objRow[conMicroteachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objMicroteachCaseEN.MicroteachCaseName = objRow[conMicroteachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objMicroteachCaseEN.MicroteachCaseTheme = objRow[conMicroteachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objMicroteachCaseEN.MicroteachCaseDate = objRow[conMicroteachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objMicroteachCaseEN.MicroteachCaseTime = objRow[conMicroteachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间(字段类型:char,字段长度:6,是否可空:True)
 objMicroteachCaseEN.MicroteachCaseDateIn = objRow[conMicroteachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objMicroteachCaseEN.IdStudyLevel = objRow[conMicroteachCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objMicroteachCaseEN.IdTeachingPlan = objRow[conMicroteachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conMicroteachCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objMicroteachCaseEN.MicroTeachCaseTimeIn = objRow[conMicroteachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objMicroteachCaseEN.IdMicroteachCaseType = objRow[conMicroteachCase.IdMicroteachCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objMicroteachCaseEN.IdCaseType = objRow[conMicroteachCase.IdCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objMicroteachCaseEN.IdDiscipline = objRow[conMicroteachCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objMicroteachCaseEN.BrowseCount = objRow[conMicroteachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objMicroteachCaseEN.IdSenateGaugeVersion = objRow[conMicroteachCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objMicroteachCaseEN.IdTeachSkill = objRow[conMicroteachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objMicroteachCaseEN.CaseLevelId = objRow[conMicroteachCase.CaseLevelId] == DBNull.Value ? null : objRow[conMicroteachCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objMicroteachCaseEN.DocFile = objRow[conMicroteachCase.DocFile] == DBNull.Value ? null : objRow[conMicroteachCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objMicroteachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objMicroteachCaseEN.WordCreateDate = objRow[conMicroteachCase.WordCreateDate] == DBNull.Value ? null : objRow[conMicroteachCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objMicroteachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objMicroteachCaseEN.microteachCaseText = objRow[conMicroteachCase.microteachCaseText] == DBNull.Value ? null : objRow[conMicroteachCase.microteachCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objMicroteachCaseEN.OwnerId = objRow[conMicroteachCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objMicroteachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objMicroteachCaseEN.UserKindId = objRow[conMicroteachCase.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objMicroteachCaseEN.UserTypeId = objRow[conMicroteachCase.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objMicroteachCaseEN.RecommendedDegreeId = objRow[conMicroteachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objMicroteachCaseEN.ftpFileType = objRow[conMicroteachCase.ftpFileType] == DBNull.Value ? null : objRow[conMicroteachCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objMicroteachCaseEN.VideoUrl = objRow[conMicroteachCase.VideoUrl] == DBNull.Value ? null : objRow[conMicroteachCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objMicroteachCaseEN.VideoPath = objRow[conMicroteachCase.VideoPath] == DBNull.Value ? null : objRow[conMicroteachCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objMicroteachCaseEN.ResErrMsg = objRow[conMicroteachCase.ResErrMsg] == DBNull.Value ? null : objRow[conMicroteachCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objMicroteachCaseEN.UpdDate = objRow[conMicroteachCase.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objMicroteachCaseEN.UpdUserId = objRow[conMicroteachCase.UpdUserId] == DBNull.Value ? null : objRow[conMicroteachCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objMicroteachCaseEN.Memo = objRow[conMicroteachCase.Memo] == DBNull.Value ? null : objRow[conMicroteachCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsMicroteachCaseDA: GetObjByIdMicroteachCase)", objException.Message));
}
return objMicroteachCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsMicroteachCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsMicroteachCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsMicroteachCaseEN objMicroteachCaseEN = new clsMicroteachCaseEN()
{
IdMicroteachCase = objRow[conMicroteachCase.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
MicroteachCaseID = objRow[conMicroteachCase.MicroteachCaseID].ToString().Trim(), //微格教学案例ID
MicroteachCaseName = objRow[conMicroteachCase.MicroteachCaseName].ToString().Trim(), //微格教学案例名称
MicroteachCaseTheme = objRow[conMicroteachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTheme].ToString().Trim(), //微格教学案例主题词
MicroteachCaseDate = objRow[conMicroteachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDate].ToString().Trim(), //微格教学日期
MicroteachCaseTime = objRow[conMicroteachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTime].ToString().Trim(), //微格教学时间
MicroteachCaseDateIn = objRow[conMicroteachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(), //案例入库日期
IdStudyLevel = objRow[conMicroteachCase.IdStudyLevel].ToString().Trim(), //学段流水号
IdTeachingPlan = objRow[conMicroteachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conMicroteachCase.IdTeachingPlan].ToString().Trim(), //教案流水号
MicroTeachCaseTimeIn = objRow[conMicroteachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(), //案例入库时间
IdMicroteachCaseType = objRow[conMicroteachCase.IdMicroteachCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdMicroteachCaseType].ToString().Trim(), //微格案例类型流水号
IdCaseType = objRow[conMicroteachCase.IdCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[conMicroteachCase.IdDiscipline].ToString().Trim(), //学科流水号
BrowseCount = objRow[conMicroteachCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroteachCase.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[conMicroteachCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
IdTeachSkill = objRow[conMicroteachCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
CaseLevelId = objRow[conMicroteachCase.CaseLevelId] == DBNull.Value ? null : objRow[conMicroteachCase.CaseLevelId].ToString().Trim(), //课例等级Id
DocFile = objRow[conMicroteachCase.DocFile] == DBNull.Value ? null : objRow[conMicroteachCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[conMicroteachCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[conMicroteachCase.WordCreateDate] == DBNull.Value ? null : objRow[conMicroteachCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[conMicroteachCase.IsVisible].ToString().Trim()), //是否显示
microteachCaseText = objRow[conMicroteachCase.microteachCaseText] == DBNull.Value ? null : objRow[conMicroteachCase.microteachCaseText].ToString().Trim(), //案例文本内容
OwnerId = objRow[conMicroteachCase.OwnerId].ToString().Trim(), //拥有者Id
IsDualVideo = TransNullToBool(objRow[conMicroteachCase.IsDualVideo].ToString().Trim()), //是否双视频
UserKindId = objRow[conMicroteachCase.UserKindId].ToString().Trim(), //用户类别Id
UserTypeId = objRow[conMicroteachCase.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCase.UserTypeId].ToString().Trim(), //用户类型Id
RecommendedDegreeId = objRow[conMicroteachCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
ftpFileType = objRow[conMicroteachCase.ftpFileType] == DBNull.Value ? null : objRow[conMicroteachCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[conMicroteachCase.VideoUrl] == DBNull.Value ? null : objRow[conMicroteachCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[conMicroteachCase.VideoPath] == DBNull.Value ? null : objRow[conMicroteachCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[conMicroteachCase.ResErrMsg] == DBNull.Value ? null : objRow[conMicroteachCase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdDate = objRow[conMicroteachCase.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conMicroteachCase.UpdUserId] == DBNull.Value ? null : objRow[conMicroteachCase.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conMicroteachCase.Memo] == DBNull.Value ? null : objRow[conMicroteachCase.Memo].ToString().Trim() //备注
};
objMicroteachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMicroteachCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsMicroteachCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsMicroteachCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsMicroteachCaseEN objMicroteachCaseEN = new clsMicroteachCaseEN();
try
{
objMicroteachCaseEN.IdMicroteachCase = objRow[conMicroteachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseEN.MicroteachCaseID = objRow[conMicroteachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objMicroteachCaseEN.MicroteachCaseName = objRow[conMicroteachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objMicroteachCaseEN.MicroteachCaseTheme = objRow[conMicroteachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objMicroteachCaseEN.MicroteachCaseDate = objRow[conMicroteachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objMicroteachCaseEN.MicroteachCaseTime = objRow[conMicroteachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objMicroteachCaseEN.MicroteachCaseDateIn = objRow[conMicroteachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objMicroteachCaseEN.IdStudyLevel = objRow[conMicroteachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMicroteachCaseEN.IdTeachingPlan = objRow[conMicroteachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conMicroteachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMicroteachCaseEN.MicroTeachCaseTimeIn = objRow[conMicroteachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objMicroteachCaseEN.IdMicroteachCaseType = objRow[conMicroteachCase.IdMicroteachCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseEN.IdCaseType = objRow[conMicroteachCase.IdCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objMicroteachCaseEN.IdDiscipline = objRow[conMicroteachCase.IdDiscipline].ToString().Trim(); //学科流水号
objMicroteachCaseEN.BrowseCount = objRow[conMicroteachCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroteachCase.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseEN.IdSenateGaugeVersion = objRow[conMicroteachCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseEN.IdTeachSkill = objRow[conMicroteachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objMicroteachCaseEN.CaseLevelId = objRow[conMicroteachCase.CaseLevelId] == DBNull.Value ? null : objRow[conMicroteachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMicroteachCaseEN.DocFile = objRow[conMicroteachCase.DocFile] == DBNull.Value ? null : objRow[conMicroteachCase.DocFile].ToString().Trim(); //生成的Word文件名
objMicroteachCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conMicroteachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMicroteachCaseEN.WordCreateDate = objRow[conMicroteachCase.WordCreateDate] == DBNull.Value ? null : objRow[conMicroteachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMicroteachCaseEN.IsVisible = TransNullToBool(objRow[conMicroteachCase.IsVisible].ToString().Trim()); //是否显示
objMicroteachCaseEN.microteachCaseText = objRow[conMicroteachCase.microteachCaseText] == DBNull.Value ? null : objRow[conMicroteachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objMicroteachCaseEN.OwnerId = objRow[conMicroteachCase.OwnerId].ToString().Trim(); //拥有者Id
objMicroteachCaseEN.IsDualVideo = TransNullToBool(objRow[conMicroteachCase.IsDualVideo].ToString().Trim()); //是否双视频
objMicroteachCaseEN.UserKindId = objRow[conMicroteachCase.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseEN.UserTypeId = objRow[conMicroteachCase.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCase.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseEN.RecommendedDegreeId = objRow[conMicroteachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMicroteachCaseEN.ftpFileType = objRow[conMicroteachCase.ftpFileType] == DBNull.Value ? null : objRow[conMicroteachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMicroteachCaseEN.VideoUrl = objRow[conMicroteachCase.VideoUrl] == DBNull.Value ? null : objRow[conMicroteachCase.VideoUrl].ToString().Trim(); //视频Url
objMicroteachCaseEN.VideoPath = objRow[conMicroteachCase.VideoPath] == DBNull.Value ? null : objRow[conMicroteachCase.VideoPath].ToString().Trim(); //视频目录
objMicroteachCaseEN.ResErrMsg = objRow[conMicroteachCase.ResErrMsg] == DBNull.Value ? null : objRow[conMicroteachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMicroteachCaseEN.UpdDate = objRow[conMicroteachCase.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseEN.UpdUserId = objRow[conMicroteachCase.UpdUserId] == DBNull.Value ? null : objRow[conMicroteachCase.UpdUserId].ToString().Trim(); //修改用户Id
objMicroteachCaseEN.Memo = objRow[conMicroteachCase.Memo] == DBNull.Value ? null : objRow[conMicroteachCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsMicroteachCaseDA: GetObjByDataRowMicroteachCase)", objException.Message));
}
objMicroteachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMicroteachCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsMicroteachCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsMicroteachCaseEN objMicroteachCaseEN = new clsMicroteachCaseEN();
try
{
objMicroteachCaseEN.IdMicroteachCase = objRow[conMicroteachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseEN.MicroteachCaseID = objRow[conMicroteachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objMicroteachCaseEN.MicroteachCaseName = objRow[conMicroteachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objMicroteachCaseEN.MicroteachCaseTheme = objRow[conMicroteachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objMicroteachCaseEN.MicroteachCaseDate = objRow[conMicroteachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objMicroteachCaseEN.MicroteachCaseTime = objRow[conMicroteachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objMicroteachCaseEN.MicroteachCaseDateIn = objRow[conMicroteachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objMicroteachCaseEN.IdStudyLevel = objRow[conMicroteachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMicroteachCaseEN.IdTeachingPlan = objRow[conMicroteachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conMicroteachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMicroteachCaseEN.MicroTeachCaseTimeIn = objRow[conMicroteachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objMicroteachCaseEN.IdMicroteachCaseType = objRow[conMicroteachCase.IdMicroteachCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseEN.IdCaseType = objRow[conMicroteachCase.IdCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objMicroteachCaseEN.IdDiscipline = objRow[conMicroteachCase.IdDiscipline].ToString().Trim(); //学科流水号
objMicroteachCaseEN.BrowseCount = objRow[conMicroteachCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroteachCase.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseEN.IdSenateGaugeVersion = objRow[conMicroteachCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseEN.IdTeachSkill = objRow[conMicroteachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objMicroteachCaseEN.CaseLevelId = objRow[conMicroteachCase.CaseLevelId] == DBNull.Value ? null : objRow[conMicroteachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMicroteachCaseEN.DocFile = objRow[conMicroteachCase.DocFile] == DBNull.Value ? null : objRow[conMicroteachCase.DocFile].ToString().Trim(); //生成的Word文件名
objMicroteachCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conMicroteachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMicroteachCaseEN.WordCreateDate = objRow[conMicroteachCase.WordCreateDate] == DBNull.Value ? null : objRow[conMicroteachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMicroteachCaseEN.IsVisible = TransNullToBool(objRow[conMicroteachCase.IsVisible].ToString().Trim()); //是否显示
objMicroteachCaseEN.microteachCaseText = objRow[conMicroteachCase.microteachCaseText] == DBNull.Value ? null : objRow[conMicroteachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objMicroteachCaseEN.OwnerId = objRow[conMicroteachCase.OwnerId].ToString().Trim(); //拥有者Id
objMicroteachCaseEN.IsDualVideo = TransNullToBool(objRow[conMicroteachCase.IsDualVideo].ToString().Trim()); //是否双视频
objMicroteachCaseEN.UserKindId = objRow[conMicroteachCase.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseEN.UserTypeId = objRow[conMicroteachCase.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCase.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseEN.RecommendedDegreeId = objRow[conMicroteachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMicroteachCaseEN.ftpFileType = objRow[conMicroteachCase.ftpFileType] == DBNull.Value ? null : objRow[conMicroteachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMicroteachCaseEN.VideoUrl = objRow[conMicroteachCase.VideoUrl] == DBNull.Value ? null : objRow[conMicroteachCase.VideoUrl].ToString().Trim(); //视频Url
objMicroteachCaseEN.VideoPath = objRow[conMicroteachCase.VideoPath] == DBNull.Value ? null : objRow[conMicroteachCase.VideoPath].ToString().Trim(); //视频目录
objMicroteachCaseEN.ResErrMsg = objRow[conMicroteachCase.ResErrMsg] == DBNull.Value ? null : objRow[conMicroteachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMicroteachCaseEN.UpdDate = objRow[conMicroteachCase.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseEN.UpdUserId = objRow[conMicroteachCase.UpdUserId] == DBNull.Value ? null : objRow[conMicroteachCase.UpdUserId].ToString().Trim(); //修改用户Id
objMicroteachCaseEN.Memo = objRow[conMicroteachCase.Memo] == DBNull.Value ? null : objRow[conMicroteachCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsMicroteachCaseDA: GetObjByDataRow)", objException.Message));
}
objMicroteachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMicroteachCaseEN;
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
objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsMicroteachCaseEN._CurrTabName, conMicroteachCase.IdMicroteachCase, 8, "");
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
objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsMicroteachCaseEN._CurrTabName, conMicroteachCase.IdMicroteachCase, 8, strPrefix);
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
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCase from MicroteachCase where " + strCondition;
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
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCase from MicroteachCase where " + strCondition;
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
 /// <param name = "strIdMicroteachCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdMicroteachCase)
{
CheckPrimaryKey(strIdMicroteachCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("MicroteachCase", "IdMicroteachCase = " + "'"+ strIdMicroteachCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsMicroteachCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("MicroteachCase", strCondition))
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
objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("MicroteachCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsMicroteachCaseEN objMicroteachCaseEN)
 {
 objMicroteachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroteachCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroteachCaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "MicroteachCase");
objRow = objDS.Tables["MicroteachCase"].NewRow();
objRow[conMicroteachCase.IdMicroteachCase] = objMicroteachCaseEN.IdMicroteachCase; //微格教学案例流水号
objRow[conMicroteachCase.MicroteachCaseID] = objMicroteachCaseEN.MicroteachCaseID; //微格教学案例ID
objRow[conMicroteachCase.MicroteachCaseName] = objMicroteachCaseEN.MicroteachCaseName; //微格教学案例名称
 if (objMicroteachCaseEN.MicroteachCaseTheme !=  "")
 {
objRow[conMicroteachCase.MicroteachCaseTheme] = objMicroteachCaseEN.MicroteachCaseTheme; //微格教学案例主题词
 }
 if (objMicroteachCaseEN.MicroteachCaseDate !=  "")
 {
objRow[conMicroteachCase.MicroteachCaseDate] = objMicroteachCaseEN.MicroteachCaseDate; //微格教学日期
 }
 if (objMicroteachCaseEN.MicroteachCaseTime !=  "")
 {
objRow[conMicroteachCase.MicroteachCaseTime] = objMicroteachCaseEN.MicroteachCaseTime; //微格教学时间
 }
 if (objMicroteachCaseEN.MicroteachCaseDateIn !=  "")
 {
objRow[conMicroteachCase.MicroteachCaseDateIn] = objMicroteachCaseEN.MicroteachCaseDateIn; //案例入库日期
 }
objRow[conMicroteachCase.IdStudyLevel] = objMicroteachCaseEN.IdStudyLevel; //学段流水号
 if (objMicroteachCaseEN.IdTeachingPlan !=  "")
 {
objRow[conMicroteachCase.IdTeachingPlan] = objMicroteachCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objMicroteachCaseEN.MicroTeachCaseTimeIn !=  "")
 {
objRow[conMicroteachCase.MicroTeachCaseTimeIn] = objMicroteachCaseEN.MicroTeachCaseTimeIn; //案例入库时间
 }
 if (objMicroteachCaseEN.IdMicroteachCaseType !=  "")
 {
objRow[conMicroteachCase.IdMicroteachCaseType] = objMicroteachCaseEN.IdMicroteachCaseType; //微格案例类型流水号
 }
 if (objMicroteachCaseEN.IdCaseType !=  "")
 {
objRow[conMicroteachCase.IdCaseType] = objMicroteachCaseEN.IdCaseType; //案例类型流水号
 }
objRow[conMicroteachCase.IdDiscipline] = objMicroteachCaseEN.IdDiscipline; //学科流水号
objRow[conMicroteachCase.BrowseCount] = objMicroteachCaseEN.BrowseCount; //浏览次数
 if (objMicroteachCaseEN.IdSenateGaugeVersion !=  "")
 {
objRow[conMicroteachCase.IdSenateGaugeVersion] = objMicroteachCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
objRow[conMicroteachCase.IdTeachSkill] = objMicroteachCaseEN.IdTeachSkill; //教学技能流水号
 if (objMicroteachCaseEN.CaseLevelId !=  "")
 {
objRow[conMicroteachCase.CaseLevelId] = objMicroteachCaseEN.CaseLevelId; //课例等级Id
 }
 if (objMicroteachCaseEN.DocFile !=  "")
 {
objRow[conMicroteachCase.DocFile] = objMicroteachCaseEN.DocFile; //生成的Word文件名
 }
objRow[conMicroteachCase.IsNeedGeneWord] = objMicroteachCaseEN.IsNeedGeneWord; //是否需要生成Word
 if (objMicroteachCaseEN.WordCreateDate !=  "")
 {
objRow[conMicroteachCase.WordCreateDate] = objMicroteachCaseEN.WordCreateDate; //Word生成日期
 }
objRow[conMicroteachCase.IsVisible] = objMicroteachCaseEN.IsVisible; //是否显示
 if (objMicroteachCaseEN.microteachCaseText !=  "")
 {
objRow[conMicroteachCase.microteachCaseText] = objMicroteachCaseEN.microteachCaseText; //案例文本内容
 }
objRow[conMicroteachCase.OwnerId] = objMicroteachCaseEN.OwnerId; //拥有者Id
objRow[conMicroteachCase.IsDualVideo] = objMicroteachCaseEN.IsDualVideo; //是否双视频
objRow[conMicroteachCase.UserKindId] = objMicroteachCaseEN.UserKindId; //用户类别Id
 if (objMicroteachCaseEN.UserTypeId !=  "")
 {
objRow[conMicroteachCase.UserTypeId] = objMicroteachCaseEN.UserTypeId; //用户类型Id
 }
objRow[conMicroteachCase.RecommendedDegreeId] = objMicroteachCaseEN.RecommendedDegreeId; //推荐度Id
 if (objMicroteachCaseEN.ftpFileType !=  "")
 {
objRow[conMicroteachCase.ftpFileType] = objMicroteachCaseEN.ftpFileType; //ftp文件类型
 }
 if (objMicroteachCaseEN.VideoUrl !=  "")
 {
objRow[conMicroteachCase.VideoUrl] = objMicroteachCaseEN.VideoUrl; //视频Url
 }
 if (objMicroteachCaseEN.VideoPath !=  "")
 {
objRow[conMicroteachCase.VideoPath] = objMicroteachCaseEN.VideoPath; //视频目录
 }
 if (objMicroteachCaseEN.ResErrMsg !=  "")
 {
objRow[conMicroteachCase.ResErrMsg] = objMicroteachCaseEN.ResErrMsg; //资源错误信息
 }
 if (objMicroteachCaseEN.UpdDate !=  "")
 {
objRow[conMicroteachCase.UpdDate] = objMicroteachCaseEN.UpdDate; //修改日期
 }
 if (objMicroteachCaseEN.UpdUserId !=  "")
 {
objRow[conMicroteachCase.UpdUserId] = objMicroteachCaseEN.UpdUserId; //修改用户Id
 }
 if (objMicroteachCaseEN.Memo !=  "")
 {
objRow[conMicroteachCase.Memo] = objMicroteachCaseEN.Memo; //备注
 }
objDS.Tables[clsMicroteachCaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsMicroteachCaseEN._CurrTabName);
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
 /// <param name = "objMicroteachCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsMicroteachCaseEN objMicroteachCaseEN)
{
 objMicroteachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroteachCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroteachCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMicroteachCaseEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdMicroteachCase);
 var strIdMicroteachCase = objMicroteachCaseEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseID !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseID);
 var strMicroteachCaseID = objMicroteachCaseEN.MicroteachCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseID + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseName !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseName);
 var strMicroteachCaseName = objMicroteachCaseEN.MicroteachCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseName + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseTheme);
 var strMicroteachCaseTheme = objMicroteachCaseEN.MicroteachCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseTheme + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseDate);
 var strMicroteachCaseDate = objMicroteachCaseEN.MicroteachCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseDate + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseTime);
 var strMicroteachCaseTime = objMicroteachCaseEN.MicroteachCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseTime + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseDateIn);
 var strMicroteachCaseDateIn = objMicroteachCaseEN.MicroteachCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseDateIn + "'");
 }
 
 if (objMicroteachCaseEN.IdStudyLevel  ==  "")
 {
 objMicroteachCaseEN.IdStudyLevel = null;
 }
 if (objMicroteachCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdStudyLevel);
 var strIdStudyLevel = objMicroteachCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objMicroteachCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdTeachingPlan);
 var strIdTeachingPlan = objMicroteachCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objMicroteachCaseEN.MicroTeachCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroTeachCaseTimeIn);
 var strMicroTeachCaseTimeIn = objMicroteachCaseEN.MicroTeachCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroTeachCaseTimeIn + "'");
 }
 
 if (objMicroteachCaseEN.IdMicroteachCaseType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdMicroteachCaseType);
 var strIdMicroteachCaseType = objMicroteachCaseEN.IdMicroteachCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCaseType + "'");
 }
 
 if (objMicroteachCaseEN.IdCaseType  ==  "")
 {
 objMicroteachCaseEN.IdCaseType = null;
 }
 if (objMicroteachCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdCaseType);
 var strIdCaseType = objMicroteachCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objMicroteachCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdDiscipline);
 var strIdDiscipline = objMicroteachCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objMicroteachCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.BrowseCount);
 arrValueListForInsert.Add(objMicroteachCaseEN.BrowseCount.ToString());
 }
 
 if (objMicroteachCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objMicroteachCaseEN.IdSenateGaugeVersion = null;
 }
 if (objMicroteachCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objMicroteachCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objMicroteachCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdTeachSkill);
 var strIdTeachSkill = objMicroteachCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objMicroteachCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.CaseLevelId);
 var strCaseLevelId = objMicroteachCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objMicroteachCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.DocFile);
 var strDocFile = objMicroteachCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objMicroteachCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objMicroteachCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.WordCreateDate);
 var strWordCreateDate = objMicroteachCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachCase.IsVisible);
 arrValueListForInsert.Add("'" + (objMicroteachCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objMicroteachCaseEN.microteachCaseText !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.microteachCaseText);
 var strmicroteachCaseText = objMicroteachCaseEN.microteachCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmicroteachCaseText + "'");
 }
 
 if (objMicroteachCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.OwnerId);
 var strOwnerId = objMicroteachCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objMicroteachCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objMicroteachCaseEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.UserKindId);
 var strUserKindId = objMicroteachCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objMicroteachCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.UserTypeId);
 var strUserTypeId = objMicroteachCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objMicroteachCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objMicroteachCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objMicroteachCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.ftpFileType);
 var strftpFileType = objMicroteachCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objMicroteachCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.VideoUrl);
 var strVideoUrl = objMicroteachCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objMicroteachCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.VideoPath);
 var strVideoPath = objMicroteachCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objMicroteachCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.ResErrMsg);
 var strResErrMsg = objMicroteachCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objMicroteachCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.UpdDate);
 var strUpdDate = objMicroteachCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objMicroteachCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.UpdUserId);
 var strUpdUserId = objMicroteachCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objMicroteachCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.Memo);
 var strMemo = objMicroteachCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MicroteachCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsMicroteachCaseEN objMicroteachCaseEN)
{
 objMicroteachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroteachCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroteachCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMicroteachCaseEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdMicroteachCase);
 var strIdMicroteachCase = objMicroteachCaseEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseID !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseID);
 var strMicroteachCaseID = objMicroteachCaseEN.MicroteachCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseID + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseName !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseName);
 var strMicroteachCaseName = objMicroteachCaseEN.MicroteachCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseName + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseTheme);
 var strMicroteachCaseTheme = objMicroteachCaseEN.MicroteachCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseTheme + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseDate);
 var strMicroteachCaseDate = objMicroteachCaseEN.MicroteachCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseDate + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseTime);
 var strMicroteachCaseTime = objMicroteachCaseEN.MicroteachCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseTime + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseDateIn);
 var strMicroteachCaseDateIn = objMicroteachCaseEN.MicroteachCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseDateIn + "'");
 }
 
 if (objMicroteachCaseEN.IdStudyLevel  ==  "")
 {
 objMicroteachCaseEN.IdStudyLevel = null;
 }
 if (objMicroteachCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdStudyLevel);
 var strIdStudyLevel = objMicroteachCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objMicroteachCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdTeachingPlan);
 var strIdTeachingPlan = objMicroteachCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objMicroteachCaseEN.MicroTeachCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroTeachCaseTimeIn);
 var strMicroTeachCaseTimeIn = objMicroteachCaseEN.MicroTeachCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroTeachCaseTimeIn + "'");
 }
 
 if (objMicroteachCaseEN.IdMicroteachCaseType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdMicroteachCaseType);
 var strIdMicroteachCaseType = objMicroteachCaseEN.IdMicroteachCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCaseType + "'");
 }
 
 if (objMicroteachCaseEN.IdCaseType  ==  "")
 {
 objMicroteachCaseEN.IdCaseType = null;
 }
 if (objMicroteachCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdCaseType);
 var strIdCaseType = objMicroteachCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objMicroteachCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdDiscipline);
 var strIdDiscipline = objMicroteachCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objMicroteachCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.BrowseCount);
 arrValueListForInsert.Add(objMicroteachCaseEN.BrowseCount.ToString());
 }
 
 if (objMicroteachCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objMicroteachCaseEN.IdSenateGaugeVersion = null;
 }
 if (objMicroteachCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objMicroteachCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objMicroteachCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdTeachSkill);
 var strIdTeachSkill = objMicroteachCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objMicroteachCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.CaseLevelId);
 var strCaseLevelId = objMicroteachCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objMicroteachCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.DocFile);
 var strDocFile = objMicroteachCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objMicroteachCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objMicroteachCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.WordCreateDate);
 var strWordCreateDate = objMicroteachCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachCase.IsVisible);
 arrValueListForInsert.Add("'" + (objMicroteachCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objMicroteachCaseEN.microteachCaseText !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.microteachCaseText);
 var strmicroteachCaseText = objMicroteachCaseEN.microteachCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmicroteachCaseText + "'");
 }
 
 if (objMicroteachCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.OwnerId);
 var strOwnerId = objMicroteachCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objMicroteachCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objMicroteachCaseEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.UserKindId);
 var strUserKindId = objMicroteachCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objMicroteachCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.UserTypeId);
 var strUserTypeId = objMicroteachCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objMicroteachCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objMicroteachCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objMicroteachCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.ftpFileType);
 var strftpFileType = objMicroteachCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objMicroteachCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.VideoUrl);
 var strVideoUrl = objMicroteachCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objMicroteachCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.VideoPath);
 var strVideoPath = objMicroteachCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objMicroteachCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.ResErrMsg);
 var strResErrMsg = objMicroteachCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objMicroteachCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.UpdDate);
 var strUpdDate = objMicroteachCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objMicroteachCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.UpdUserId);
 var strUpdUserId = objMicroteachCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objMicroteachCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.Memo);
 var strMemo = objMicroteachCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MicroteachCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objMicroteachCaseEN.IdMicroteachCase;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsMicroteachCaseEN objMicroteachCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objMicroteachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroteachCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroteachCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMicroteachCaseEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdMicroteachCase);
 var strIdMicroteachCase = objMicroteachCaseEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseID !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseID);
 var strMicroteachCaseID = objMicroteachCaseEN.MicroteachCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseID + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseName !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseName);
 var strMicroteachCaseName = objMicroteachCaseEN.MicroteachCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseName + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseTheme);
 var strMicroteachCaseTheme = objMicroteachCaseEN.MicroteachCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseTheme + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseDate);
 var strMicroteachCaseDate = objMicroteachCaseEN.MicroteachCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseDate + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseTime);
 var strMicroteachCaseTime = objMicroteachCaseEN.MicroteachCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseTime + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseDateIn);
 var strMicroteachCaseDateIn = objMicroteachCaseEN.MicroteachCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseDateIn + "'");
 }
 
 if (objMicroteachCaseEN.IdStudyLevel  ==  "")
 {
 objMicroteachCaseEN.IdStudyLevel = null;
 }
 if (objMicroteachCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdStudyLevel);
 var strIdStudyLevel = objMicroteachCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objMicroteachCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdTeachingPlan);
 var strIdTeachingPlan = objMicroteachCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objMicroteachCaseEN.MicroTeachCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroTeachCaseTimeIn);
 var strMicroTeachCaseTimeIn = objMicroteachCaseEN.MicroTeachCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroTeachCaseTimeIn + "'");
 }
 
 if (objMicroteachCaseEN.IdMicroteachCaseType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdMicroteachCaseType);
 var strIdMicroteachCaseType = objMicroteachCaseEN.IdMicroteachCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCaseType + "'");
 }
 
 if (objMicroteachCaseEN.IdCaseType  ==  "")
 {
 objMicroteachCaseEN.IdCaseType = null;
 }
 if (objMicroteachCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdCaseType);
 var strIdCaseType = objMicroteachCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objMicroteachCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdDiscipline);
 var strIdDiscipline = objMicroteachCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objMicroteachCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.BrowseCount);
 arrValueListForInsert.Add(objMicroteachCaseEN.BrowseCount.ToString());
 }
 
 if (objMicroteachCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objMicroteachCaseEN.IdSenateGaugeVersion = null;
 }
 if (objMicroteachCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objMicroteachCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objMicroteachCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdTeachSkill);
 var strIdTeachSkill = objMicroteachCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objMicroteachCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.CaseLevelId);
 var strCaseLevelId = objMicroteachCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objMicroteachCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.DocFile);
 var strDocFile = objMicroteachCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objMicroteachCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objMicroteachCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.WordCreateDate);
 var strWordCreateDate = objMicroteachCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachCase.IsVisible);
 arrValueListForInsert.Add("'" + (objMicroteachCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objMicroteachCaseEN.microteachCaseText !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.microteachCaseText);
 var strmicroteachCaseText = objMicroteachCaseEN.microteachCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmicroteachCaseText + "'");
 }
 
 if (objMicroteachCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.OwnerId);
 var strOwnerId = objMicroteachCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objMicroteachCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objMicroteachCaseEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.UserKindId);
 var strUserKindId = objMicroteachCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objMicroteachCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.UserTypeId);
 var strUserTypeId = objMicroteachCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objMicroteachCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objMicroteachCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objMicroteachCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.ftpFileType);
 var strftpFileType = objMicroteachCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objMicroteachCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.VideoUrl);
 var strVideoUrl = objMicroteachCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objMicroteachCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.VideoPath);
 var strVideoPath = objMicroteachCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objMicroteachCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.ResErrMsg);
 var strResErrMsg = objMicroteachCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objMicroteachCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.UpdDate);
 var strUpdDate = objMicroteachCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objMicroteachCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.UpdUserId);
 var strUpdUserId = objMicroteachCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objMicroteachCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.Memo);
 var strMemo = objMicroteachCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MicroteachCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objMicroteachCaseEN.IdMicroteachCase;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsMicroteachCaseEN objMicroteachCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objMicroteachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroteachCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroteachCaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMicroteachCaseEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdMicroteachCase);
 var strIdMicroteachCase = objMicroteachCaseEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseID !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseID);
 var strMicroteachCaseID = objMicroteachCaseEN.MicroteachCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseID + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseName !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseName);
 var strMicroteachCaseName = objMicroteachCaseEN.MicroteachCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseName + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseTheme);
 var strMicroteachCaseTheme = objMicroteachCaseEN.MicroteachCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseTheme + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseDate);
 var strMicroteachCaseDate = objMicroteachCaseEN.MicroteachCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseDate + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseTime);
 var strMicroteachCaseTime = objMicroteachCaseEN.MicroteachCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseTime + "'");
 }
 
 if (objMicroteachCaseEN.MicroteachCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroteachCaseDateIn);
 var strMicroteachCaseDateIn = objMicroteachCaseEN.MicroteachCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroteachCaseDateIn + "'");
 }
 
 if (objMicroteachCaseEN.IdStudyLevel  ==  "")
 {
 objMicroteachCaseEN.IdStudyLevel = null;
 }
 if (objMicroteachCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdStudyLevel);
 var strIdStudyLevel = objMicroteachCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objMicroteachCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdTeachingPlan);
 var strIdTeachingPlan = objMicroteachCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objMicroteachCaseEN.MicroTeachCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.MicroTeachCaseTimeIn);
 var strMicroTeachCaseTimeIn = objMicroteachCaseEN.MicroTeachCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroTeachCaseTimeIn + "'");
 }
 
 if (objMicroteachCaseEN.IdMicroteachCaseType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdMicroteachCaseType);
 var strIdMicroteachCaseType = objMicroteachCaseEN.IdMicroteachCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCaseType + "'");
 }
 
 if (objMicroteachCaseEN.IdCaseType  ==  "")
 {
 objMicroteachCaseEN.IdCaseType = null;
 }
 if (objMicroteachCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdCaseType);
 var strIdCaseType = objMicroteachCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objMicroteachCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdDiscipline);
 var strIdDiscipline = objMicroteachCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objMicroteachCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.BrowseCount);
 arrValueListForInsert.Add(objMicroteachCaseEN.BrowseCount.ToString());
 }
 
 if (objMicroteachCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objMicroteachCaseEN.IdSenateGaugeVersion = null;
 }
 if (objMicroteachCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objMicroteachCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objMicroteachCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.IdTeachSkill);
 var strIdTeachSkill = objMicroteachCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objMicroteachCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.CaseLevelId);
 var strCaseLevelId = objMicroteachCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objMicroteachCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.DocFile);
 var strDocFile = objMicroteachCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objMicroteachCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objMicroteachCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.WordCreateDate);
 var strWordCreateDate = objMicroteachCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachCase.IsVisible);
 arrValueListForInsert.Add("'" + (objMicroteachCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objMicroteachCaseEN.microteachCaseText !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.microteachCaseText);
 var strmicroteachCaseText = objMicroteachCaseEN.microteachCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strmicroteachCaseText + "'");
 }
 
 if (objMicroteachCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.OwnerId);
 var strOwnerId = objMicroteachCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objMicroteachCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objMicroteachCaseEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.UserKindId);
 var strUserKindId = objMicroteachCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objMicroteachCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.UserTypeId);
 var strUserTypeId = objMicroteachCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objMicroteachCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objMicroteachCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objMicroteachCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.ftpFileType);
 var strftpFileType = objMicroteachCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objMicroteachCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.VideoUrl);
 var strVideoUrl = objMicroteachCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objMicroteachCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.VideoPath);
 var strVideoPath = objMicroteachCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objMicroteachCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.ResErrMsg);
 var strResErrMsg = objMicroteachCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objMicroteachCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.UpdDate);
 var strUpdDate = objMicroteachCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objMicroteachCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.UpdUserId);
 var strUpdUserId = objMicroteachCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objMicroteachCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCase.Memo);
 var strMemo = objMicroteachCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MicroteachCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewMicroteachCases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCase where IdMicroteachCase = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "MicroteachCase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdMicroteachCase = oRow[conMicroteachCase.IdMicroteachCase].ToString().Trim();
if (IsExist(strIdMicroteachCase))
{
 string strResult = "关键字变量值为:" + string.Format("IdMicroteachCase = {0}", strIdMicroteachCase) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsMicroteachCaseEN._CurrTabName ].NewRow();
objRow[conMicroteachCase.IdMicroteachCase] = oRow[conMicroteachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objRow[conMicroteachCase.MicroteachCaseID] = oRow[conMicroteachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objRow[conMicroteachCase.MicroteachCaseName] = oRow[conMicroteachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objRow[conMicroteachCase.MicroteachCaseTheme] = oRow[conMicroteachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objRow[conMicroteachCase.MicroteachCaseDate] = oRow[conMicroteachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objRow[conMicroteachCase.MicroteachCaseTime] = oRow[conMicroteachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objRow[conMicroteachCase.MicroteachCaseDateIn] = oRow[conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objRow[conMicroteachCase.IdStudyLevel] = oRow[conMicroteachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objRow[conMicroteachCase.IdTeachingPlan] = oRow[conMicroteachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objRow[conMicroteachCase.MicroTeachCaseTimeIn] = oRow[conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objRow[conMicroteachCase.IdMicroteachCaseType] = oRow[conMicroteachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objRow[conMicroteachCase.IdCaseType] = oRow[conMicroteachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objRow[conMicroteachCase.IdDiscipline] = oRow[conMicroteachCase.IdDiscipline].ToString().Trim(); //学科流水号
objRow[conMicroteachCase.BrowseCount] = oRow[conMicroteachCase.BrowseCount].ToString().Trim(); //浏览次数
objRow[conMicroteachCase.IdSenateGaugeVersion] = oRow[conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objRow[conMicroteachCase.IdTeachSkill] = oRow[conMicroteachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objRow[conMicroteachCase.CaseLevelId] = oRow[conMicroteachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objRow[conMicroteachCase.DocFile] = oRow[conMicroteachCase.DocFile].ToString().Trim(); //生成的Word文件名
objRow[conMicroteachCase.IsNeedGeneWord] = oRow[conMicroteachCase.IsNeedGeneWord].ToString().Trim(); //是否需要生成Word
objRow[conMicroteachCase.WordCreateDate] = oRow[conMicroteachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objRow[conMicroteachCase.IsVisible] = oRow[conMicroteachCase.IsVisible].ToString().Trim(); //是否显示
objRow[conMicroteachCase.microteachCaseText] = oRow[conMicroteachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objRow[conMicroteachCase.OwnerId] = oRow[conMicroteachCase.OwnerId].ToString().Trim(); //拥有者Id
objRow[conMicroteachCase.IsDualVideo] = oRow[conMicroteachCase.IsDualVideo].ToString().Trim(); //是否双视频
objRow[conMicroteachCase.UserKindId] = oRow[conMicroteachCase.UserKindId].ToString().Trim(); //用户类别Id
objRow[conMicroteachCase.UserTypeId] = oRow[conMicroteachCase.UserTypeId].ToString().Trim(); //用户类型Id
objRow[conMicroteachCase.RecommendedDegreeId] = oRow[conMicroteachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objRow[conMicroteachCase.ftpFileType] = oRow[conMicroteachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objRow[conMicroteachCase.VideoUrl] = oRow[conMicroteachCase.VideoUrl].ToString().Trim(); //视频Url
objRow[conMicroteachCase.VideoPath] = oRow[conMicroteachCase.VideoPath].ToString().Trim(); //视频目录
objRow[conMicroteachCase.ResErrMsg] = oRow[conMicroteachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objRow[conMicroteachCase.UpdDate] = oRow[conMicroteachCase.UpdDate].ToString().Trim(); //修改日期
objRow[conMicroteachCase.UpdUserId] = oRow[conMicroteachCase.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conMicroteachCase.Memo] = oRow[conMicroteachCase.Memo].ToString().Trim(); //备注
 objDS.Tables[clsMicroteachCaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsMicroteachCaseEN._CurrTabName);
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
 /// <param name = "objMicroteachCaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsMicroteachCaseEN objMicroteachCaseEN)
{
 objMicroteachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroteachCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroteachCaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCase where IdMicroteachCase = " + "'"+ objMicroteachCaseEN.IdMicroteachCase+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsMicroteachCaseEN._CurrTabName);
if (objDS.Tables[clsMicroteachCaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdMicroteachCase = " + "'"+ objMicroteachCaseEN.IdMicroteachCase+"'");
return false;
}
objRow = objDS.Tables[clsMicroteachCaseEN._CurrTabName].Rows[0];
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdMicroteachCase))
 {
objRow[conMicroteachCase.IdMicroteachCase] = objMicroteachCaseEN.IdMicroteachCase; //微格教学案例流水号
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseID))
 {
objRow[conMicroteachCase.MicroteachCaseID] = objMicroteachCaseEN.MicroteachCaseID; //微格教学案例ID
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseName))
 {
objRow[conMicroteachCase.MicroteachCaseName] = objMicroteachCaseEN.MicroteachCaseName; //微格教学案例名称
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseTheme))
 {
objRow[conMicroteachCase.MicroteachCaseTheme] = objMicroteachCaseEN.MicroteachCaseTheme; //微格教学案例主题词
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseDate))
 {
objRow[conMicroteachCase.MicroteachCaseDate] = objMicroteachCaseEN.MicroteachCaseDate; //微格教学日期
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseTime))
 {
objRow[conMicroteachCase.MicroteachCaseTime] = objMicroteachCaseEN.MicroteachCaseTime; //微格教学时间
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseDateIn))
 {
objRow[conMicroteachCase.MicroteachCaseDateIn] = objMicroteachCaseEN.MicroteachCaseDateIn; //案例入库日期
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdStudyLevel))
 {
objRow[conMicroteachCase.IdStudyLevel] = objMicroteachCaseEN.IdStudyLevel; //学段流水号
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdTeachingPlan))
 {
objRow[conMicroteachCase.IdTeachingPlan] = objMicroteachCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroTeachCaseTimeIn))
 {
objRow[conMicroteachCase.MicroTeachCaseTimeIn] = objMicroteachCaseEN.MicroTeachCaseTimeIn; //案例入库时间
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdMicroteachCaseType))
 {
objRow[conMicroteachCase.IdMicroteachCaseType] = objMicroteachCaseEN.IdMicroteachCaseType; //微格案例类型流水号
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdCaseType))
 {
objRow[conMicroteachCase.IdCaseType] = objMicroteachCaseEN.IdCaseType; //案例类型流水号
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdDiscipline))
 {
objRow[conMicroteachCase.IdDiscipline] = objMicroteachCaseEN.IdDiscipline; //学科流水号
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.BrowseCount))
 {
objRow[conMicroteachCase.BrowseCount] = objMicroteachCaseEN.BrowseCount; //浏览次数
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdSenateGaugeVersion))
 {
objRow[conMicroteachCase.IdSenateGaugeVersion] = objMicroteachCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdTeachSkill))
 {
objRow[conMicroteachCase.IdTeachSkill] = objMicroteachCaseEN.IdTeachSkill; //教学技能流水号
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.CaseLevelId))
 {
objRow[conMicroteachCase.CaseLevelId] = objMicroteachCaseEN.CaseLevelId; //课例等级Id
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.DocFile))
 {
objRow[conMicroteachCase.DocFile] = objMicroteachCaseEN.DocFile; //生成的Word文件名
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IsNeedGeneWord))
 {
objRow[conMicroteachCase.IsNeedGeneWord] = objMicroteachCaseEN.IsNeedGeneWord; //是否需要生成Word
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.WordCreateDate))
 {
objRow[conMicroteachCase.WordCreateDate] = objMicroteachCaseEN.WordCreateDate; //Word生成日期
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IsVisible))
 {
objRow[conMicroteachCase.IsVisible] = objMicroteachCaseEN.IsVisible; //是否显示
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.microteachCaseText))
 {
objRow[conMicroteachCase.microteachCaseText] = objMicroteachCaseEN.microteachCaseText; //案例文本内容
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.OwnerId))
 {
objRow[conMicroteachCase.OwnerId] = objMicroteachCaseEN.OwnerId; //拥有者Id
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IsDualVideo))
 {
objRow[conMicroteachCase.IsDualVideo] = objMicroteachCaseEN.IsDualVideo; //是否双视频
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UserKindId))
 {
objRow[conMicroteachCase.UserKindId] = objMicroteachCaseEN.UserKindId; //用户类别Id
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UserTypeId))
 {
objRow[conMicroteachCase.UserTypeId] = objMicroteachCaseEN.UserTypeId; //用户类型Id
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.RecommendedDegreeId))
 {
objRow[conMicroteachCase.RecommendedDegreeId] = objMicroteachCaseEN.RecommendedDegreeId; //推荐度Id
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.ftpFileType))
 {
objRow[conMicroteachCase.ftpFileType] = objMicroteachCaseEN.ftpFileType; //ftp文件类型
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.VideoUrl))
 {
objRow[conMicroteachCase.VideoUrl] = objMicroteachCaseEN.VideoUrl; //视频Url
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.VideoPath))
 {
objRow[conMicroteachCase.VideoPath] = objMicroteachCaseEN.VideoPath; //视频目录
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.ResErrMsg))
 {
objRow[conMicroteachCase.ResErrMsg] = objMicroteachCaseEN.ResErrMsg; //资源错误信息
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UpdDate))
 {
objRow[conMicroteachCase.UpdDate] = objMicroteachCaseEN.UpdDate; //修改日期
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UpdUserId))
 {
objRow[conMicroteachCase.UpdUserId] = objMicroteachCaseEN.UpdUserId; //修改用户Id
 }
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.Memo))
 {
objRow[conMicroteachCase.Memo] = objMicroteachCaseEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsMicroteachCaseEN._CurrTabName);
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
 /// <param name = "objMicroteachCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsMicroteachCaseEN objMicroteachCaseEN)
{
 objMicroteachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroteachCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroteachCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update MicroteachCase Set ");
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseID))
 {
 if (objMicroteachCaseEN.MicroteachCaseID !=  null)
 {
 var strMicroteachCaseID = objMicroteachCaseEN.MicroteachCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroteachCaseID, conMicroteachCase.MicroteachCaseID); //微格教学案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.MicroteachCaseID); //微格教学案例ID
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseName))
 {
 if (objMicroteachCaseEN.MicroteachCaseName !=  null)
 {
 var strMicroteachCaseName = objMicroteachCaseEN.MicroteachCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroteachCaseName, conMicroteachCase.MicroteachCaseName); //微格教学案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.MicroteachCaseName); //微格教学案例名称
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseTheme))
 {
 if (objMicroteachCaseEN.MicroteachCaseTheme !=  null)
 {
 var strMicroteachCaseTheme = objMicroteachCaseEN.MicroteachCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroteachCaseTheme, conMicroteachCase.MicroteachCaseTheme); //微格教学案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.MicroteachCaseTheme); //微格教学案例主题词
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseDate))
 {
 if (objMicroteachCaseEN.MicroteachCaseDate !=  null)
 {
 var strMicroteachCaseDate = objMicroteachCaseEN.MicroteachCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroteachCaseDate, conMicroteachCase.MicroteachCaseDate); //微格教学日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.MicroteachCaseDate); //微格教学日期
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseTime))
 {
 if (objMicroteachCaseEN.MicroteachCaseTime !=  null)
 {
 var strMicroteachCaseTime = objMicroteachCaseEN.MicroteachCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroteachCaseTime, conMicroteachCase.MicroteachCaseTime); //微格教学时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.MicroteachCaseTime); //微格教学时间
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseDateIn))
 {
 if (objMicroteachCaseEN.MicroteachCaseDateIn !=  null)
 {
 var strMicroteachCaseDateIn = objMicroteachCaseEN.MicroteachCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroteachCaseDateIn, conMicroteachCase.MicroteachCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.MicroteachCaseDateIn); //案例入库日期
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdStudyLevel))
 {
 if (objMicroteachCaseEN.IdStudyLevel  ==  "")
 {
 objMicroteachCaseEN.IdStudyLevel = null;
 }
 if (objMicroteachCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objMicroteachCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conMicroteachCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdTeachingPlan))
 {
 if (objMicroteachCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objMicroteachCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conMicroteachCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroTeachCaseTimeIn))
 {
 if (objMicroteachCaseEN.MicroTeachCaseTimeIn !=  null)
 {
 var strMicroTeachCaseTimeIn = objMicroteachCaseEN.MicroTeachCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroTeachCaseTimeIn, conMicroteachCase.MicroTeachCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.MicroTeachCaseTimeIn); //案例入库时间
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdMicroteachCaseType))
 {
 if (objMicroteachCaseEN.IdMicroteachCaseType !=  null)
 {
 var strIdMicroteachCaseType = objMicroteachCaseEN.IdMicroteachCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMicroteachCaseType, conMicroteachCase.IdMicroteachCaseType); //微格案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.IdMicroteachCaseType); //微格案例类型流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdCaseType))
 {
 if (objMicroteachCaseEN.IdCaseType  ==  "")
 {
 objMicroteachCaseEN.IdCaseType = null;
 }
 if (objMicroteachCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objMicroteachCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conMicroteachCase.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.IdCaseType); //案例类型流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdDiscipline))
 {
 if (objMicroteachCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objMicroteachCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conMicroteachCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.BrowseCount))
 {
 if (objMicroteachCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objMicroteachCaseEN.BrowseCount, conMicroteachCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.BrowseCount); //浏览次数
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdSenateGaugeVersion))
 {
 if (objMicroteachCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objMicroteachCaseEN.IdSenateGaugeVersion = null;
 }
 if (objMicroteachCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objMicroteachCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conMicroteachCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdTeachSkill))
 {
 if (objMicroteachCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objMicroteachCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conMicroteachCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.CaseLevelId))
 {
 if (objMicroteachCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objMicroteachCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conMicroteachCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.DocFile))
 {
 if (objMicroteachCaseEN.DocFile !=  null)
 {
 var strDocFile = objMicroteachCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conMicroteachCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMicroteachCaseEN.IsNeedGeneWord == true?"1":"0", conMicroteachCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.WordCreateDate))
 {
 if (objMicroteachCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objMicroteachCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conMicroteachCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMicroteachCaseEN.IsVisible == true?"1":"0", conMicroteachCase.IsVisible); //是否显示
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.microteachCaseText))
 {
 if (objMicroteachCaseEN.microteachCaseText !=  null)
 {
 var strmicroteachCaseText = objMicroteachCaseEN.microteachCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strmicroteachCaseText, conMicroteachCase.microteachCaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.microteachCaseText); //案例文本内容
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.OwnerId))
 {
 if (objMicroteachCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objMicroteachCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conMicroteachCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.OwnerId); //拥有者Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMicroteachCaseEN.IsDualVideo == true?"1":"0", conMicroteachCase.IsDualVideo); //是否双视频
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UserKindId))
 {
 if (objMicroteachCaseEN.UserKindId !=  null)
 {
 var strUserKindId = objMicroteachCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserKindId, conMicroteachCase.UserKindId); //用户类别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.UserKindId); //用户类别Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UserTypeId))
 {
 if (objMicroteachCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objMicroteachCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conMicroteachCase.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.UserTypeId); //用户类型Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.RecommendedDegreeId))
 {
 if (objMicroteachCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objMicroteachCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conMicroteachCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.ftpFileType))
 {
 if (objMicroteachCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objMicroteachCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conMicroteachCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.VideoUrl))
 {
 if (objMicroteachCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objMicroteachCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conMicroteachCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.VideoUrl); //视频Url
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.VideoPath))
 {
 if (objMicroteachCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objMicroteachCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conMicroteachCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.VideoPath); //视频目录
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.ResErrMsg))
 {
 if (objMicroteachCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objMicroteachCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conMicroteachCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UpdDate))
 {
 if (objMicroteachCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objMicroteachCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conMicroteachCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.UpdDate); //修改日期
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UpdUserId))
 {
 if (objMicroteachCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objMicroteachCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conMicroteachCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.Memo))
 {
 if (objMicroteachCaseEN.Memo !=  null)
 {
 var strMemo = objMicroteachCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conMicroteachCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdMicroteachCase = '{0}'", objMicroteachCaseEN.IdMicroteachCase); 
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
 /// <param name = "objMicroteachCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsMicroteachCaseEN objMicroteachCaseEN, string strCondition)
{
 objMicroteachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroteachCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroteachCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MicroteachCase Set ");
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseID))
 {
 if (objMicroteachCaseEN.MicroteachCaseID !=  null)
 {
 var strMicroteachCaseID = objMicroteachCaseEN.MicroteachCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MicroteachCaseID = '{0}',", strMicroteachCaseID); //微格教学案例ID
 }
 else
 {
 sbSQL.Append(" MicroteachCaseID = null,"); //微格教学案例ID
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseName))
 {
 if (objMicroteachCaseEN.MicroteachCaseName !=  null)
 {
 var strMicroteachCaseName = objMicroteachCaseEN.MicroteachCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MicroteachCaseName = '{0}',", strMicroteachCaseName); //微格教学案例名称
 }
 else
 {
 sbSQL.Append(" MicroteachCaseName = null,"); //微格教学案例名称
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseTheme))
 {
 if (objMicroteachCaseEN.MicroteachCaseTheme !=  null)
 {
 var strMicroteachCaseTheme = objMicroteachCaseEN.MicroteachCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MicroteachCaseTheme = '{0}',", strMicroteachCaseTheme); //微格教学案例主题词
 }
 else
 {
 sbSQL.Append(" MicroteachCaseTheme = null,"); //微格教学案例主题词
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseDate))
 {
 if (objMicroteachCaseEN.MicroteachCaseDate !=  null)
 {
 var strMicroteachCaseDate = objMicroteachCaseEN.MicroteachCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MicroteachCaseDate = '{0}',", strMicroteachCaseDate); //微格教学日期
 }
 else
 {
 sbSQL.Append(" MicroteachCaseDate = null,"); //微格教学日期
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseTime))
 {
 if (objMicroteachCaseEN.MicroteachCaseTime !=  null)
 {
 var strMicroteachCaseTime = objMicroteachCaseEN.MicroteachCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MicroteachCaseTime = '{0}',", strMicroteachCaseTime); //微格教学时间
 }
 else
 {
 sbSQL.Append(" MicroteachCaseTime = null,"); //微格教学时间
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseDateIn))
 {
 if (objMicroteachCaseEN.MicroteachCaseDateIn !=  null)
 {
 var strMicroteachCaseDateIn = objMicroteachCaseEN.MicroteachCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MicroteachCaseDateIn = '{0}',", strMicroteachCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" MicroteachCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdStudyLevel))
 {
 if (objMicroteachCaseEN.IdStudyLevel  ==  "")
 {
 objMicroteachCaseEN.IdStudyLevel = null;
 }
 if (objMicroteachCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objMicroteachCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdTeachingPlan))
 {
 if (objMicroteachCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objMicroteachCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroTeachCaseTimeIn))
 {
 if (objMicroteachCaseEN.MicroTeachCaseTimeIn !=  null)
 {
 var strMicroTeachCaseTimeIn = objMicroteachCaseEN.MicroTeachCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MicroTeachCaseTimeIn = '{0}',", strMicroTeachCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" MicroTeachCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdMicroteachCaseType))
 {
 if (objMicroteachCaseEN.IdMicroteachCaseType !=  null)
 {
 var strIdMicroteachCaseType = objMicroteachCaseEN.IdMicroteachCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMicroteachCaseType = '{0}',", strIdMicroteachCaseType); //微格案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdMicroteachCaseType = null,"); //微格案例类型流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdCaseType))
 {
 if (objMicroteachCaseEN.IdCaseType  ==  "")
 {
 objMicroteachCaseEN.IdCaseType = null;
 }
 if (objMicroteachCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objMicroteachCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdDiscipline))
 {
 if (objMicroteachCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objMicroteachCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.BrowseCount))
 {
 if (objMicroteachCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objMicroteachCaseEN.BrowseCount, conMicroteachCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.BrowseCount); //浏览次数
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdSenateGaugeVersion))
 {
 if (objMicroteachCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objMicroteachCaseEN.IdSenateGaugeVersion = null;
 }
 if (objMicroteachCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objMicroteachCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdTeachSkill))
 {
 if (objMicroteachCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objMicroteachCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.CaseLevelId))
 {
 if (objMicroteachCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objMicroteachCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.DocFile))
 {
 if (objMicroteachCaseEN.DocFile !=  null)
 {
 var strDocFile = objMicroteachCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objMicroteachCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.WordCreateDate))
 {
 if (objMicroteachCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objMicroteachCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objMicroteachCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.microteachCaseText))
 {
 if (objMicroteachCaseEN.microteachCaseText !=  null)
 {
 var strmicroteachCaseText = objMicroteachCaseEN.microteachCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" microteachCaseText = '{0}',", strmicroteachCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" microteachCaseText = null,"); //案例文本内容
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.OwnerId))
 {
 if (objMicroteachCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objMicroteachCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objMicroteachCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UserKindId))
 {
 if (objMicroteachCaseEN.UserKindId !=  null)
 {
 var strUserKindId = objMicroteachCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserKindId = '{0}',", strUserKindId); //用户类别Id
 }
 else
 {
 sbSQL.Append(" UserKindId = null,"); //用户类别Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UserTypeId))
 {
 if (objMicroteachCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objMicroteachCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.RecommendedDegreeId))
 {
 if (objMicroteachCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objMicroteachCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.ftpFileType))
 {
 if (objMicroteachCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objMicroteachCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.VideoUrl))
 {
 if (objMicroteachCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objMicroteachCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.VideoPath))
 {
 if (objMicroteachCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objMicroteachCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.ResErrMsg))
 {
 if (objMicroteachCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objMicroteachCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UpdDate))
 {
 if (objMicroteachCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objMicroteachCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UpdUserId))
 {
 if (objMicroteachCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objMicroteachCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.Memo))
 {
 if (objMicroteachCaseEN.Memo !=  null)
 {
 var strMemo = objMicroteachCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objMicroteachCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsMicroteachCaseEN objMicroteachCaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objMicroteachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroteachCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroteachCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MicroteachCase Set ");
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseID))
 {
 if (objMicroteachCaseEN.MicroteachCaseID !=  null)
 {
 var strMicroteachCaseID = objMicroteachCaseEN.MicroteachCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MicroteachCaseID = '{0}',", strMicroteachCaseID); //微格教学案例ID
 }
 else
 {
 sbSQL.Append(" MicroteachCaseID = null,"); //微格教学案例ID
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseName))
 {
 if (objMicroteachCaseEN.MicroteachCaseName !=  null)
 {
 var strMicroteachCaseName = objMicroteachCaseEN.MicroteachCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MicroteachCaseName = '{0}',", strMicroteachCaseName); //微格教学案例名称
 }
 else
 {
 sbSQL.Append(" MicroteachCaseName = null,"); //微格教学案例名称
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseTheme))
 {
 if (objMicroteachCaseEN.MicroteachCaseTheme !=  null)
 {
 var strMicroteachCaseTheme = objMicroteachCaseEN.MicroteachCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MicroteachCaseTheme = '{0}',", strMicroteachCaseTheme); //微格教学案例主题词
 }
 else
 {
 sbSQL.Append(" MicroteachCaseTheme = null,"); //微格教学案例主题词
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseDate))
 {
 if (objMicroteachCaseEN.MicroteachCaseDate !=  null)
 {
 var strMicroteachCaseDate = objMicroteachCaseEN.MicroteachCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MicroteachCaseDate = '{0}',", strMicroteachCaseDate); //微格教学日期
 }
 else
 {
 sbSQL.Append(" MicroteachCaseDate = null,"); //微格教学日期
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseTime))
 {
 if (objMicroteachCaseEN.MicroteachCaseTime !=  null)
 {
 var strMicroteachCaseTime = objMicroteachCaseEN.MicroteachCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MicroteachCaseTime = '{0}',", strMicroteachCaseTime); //微格教学时间
 }
 else
 {
 sbSQL.Append(" MicroteachCaseTime = null,"); //微格教学时间
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseDateIn))
 {
 if (objMicroteachCaseEN.MicroteachCaseDateIn !=  null)
 {
 var strMicroteachCaseDateIn = objMicroteachCaseEN.MicroteachCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MicroteachCaseDateIn = '{0}',", strMicroteachCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" MicroteachCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdStudyLevel))
 {
 if (objMicroteachCaseEN.IdStudyLevel  ==  "")
 {
 objMicroteachCaseEN.IdStudyLevel = null;
 }
 if (objMicroteachCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objMicroteachCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdTeachingPlan))
 {
 if (objMicroteachCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objMicroteachCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroTeachCaseTimeIn))
 {
 if (objMicroteachCaseEN.MicroTeachCaseTimeIn !=  null)
 {
 var strMicroTeachCaseTimeIn = objMicroteachCaseEN.MicroTeachCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MicroTeachCaseTimeIn = '{0}',", strMicroTeachCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" MicroTeachCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdMicroteachCaseType))
 {
 if (objMicroteachCaseEN.IdMicroteachCaseType !=  null)
 {
 var strIdMicroteachCaseType = objMicroteachCaseEN.IdMicroteachCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMicroteachCaseType = '{0}',", strIdMicroteachCaseType); //微格案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdMicroteachCaseType = null,"); //微格案例类型流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdCaseType))
 {
 if (objMicroteachCaseEN.IdCaseType  ==  "")
 {
 objMicroteachCaseEN.IdCaseType = null;
 }
 if (objMicroteachCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objMicroteachCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdDiscipline))
 {
 if (objMicroteachCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objMicroteachCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.BrowseCount))
 {
 if (objMicroteachCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objMicroteachCaseEN.BrowseCount, conMicroteachCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.BrowseCount); //浏览次数
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdSenateGaugeVersion))
 {
 if (objMicroteachCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objMicroteachCaseEN.IdSenateGaugeVersion = null;
 }
 if (objMicroteachCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objMicroteachCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdTeachSkill))
 {
 if (objMicroteachCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objMicroteachCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.CaseLevelId))
 {
 if (objMicroteachCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objMicroteachCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.DocFile))
 {
 if (objMicroteachCaseEN.DocFile !=  null)
 {
 var strDocFile = objMicroteachCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objMicroteachCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.WordCreateDate))
 {
 if (objMicroteachCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objMicroteachCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objMicroteachCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.microteachCaseText))
 {
 if (objMicroteachCaseEN.microteachCaseText !=  null)
 {
 var strmicroteachCaseText = objMicroteachCaseEN.microteachCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" microteachCaseText = '{0}',", strmicroteachCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" microteachCaseText = null,"); //案例文本内容
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.OwnerId))
 {
 if (objMicroteachCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objMicroteachCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objMicroteachCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UserKindId))
 {
 if (objMicroteachCaseEN.UserKindId !=  null)
 {
 var strUserKindId = objMicroteachCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserKindId = '{0}',", strUserKindId); //用户类别Id
 }
 else
 {
 sbSQL.Append(" UserKindId = null,"); //用户类别Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UserTypeId))
 {
 if (objMicroteachCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objMicroteachCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.RecommendedDegreeId))
 {
 if (objMicroteachCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objMicroteachCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.ftpFileType))
 {
 if (objMicroteachCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objMicroteachCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.VideoUrl))
 {
 if (objMicroteachCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objMicroteachCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.VideoPath))
 {
 if (objMicroteachCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objMicroteachCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.ResErrMsg))
 {
 if (objMicroteachCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objMicroteachCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UpdDate))
 {
 if (objMicroteachCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objMicroteachCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UpdUserId))
 {
 if (objMicroteachCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objMicroteachCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.Memo))
 {
 if (objMicroteachCaseEN.Memo !=  null)
 {
 var strMemo = objMicroteachCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objMicroteachCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsMicroteachCaseEN objMicroteachCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objMicroteachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroteachCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroteachCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MicroteachCase Set ");
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseID))
 {
 if (objMicroteachCaseEN.MicroteachCaseID !=  null)
 {
 var strMicroteachCaseID = objMicroteachCaseEN.MicroteachCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroteachCaseID, conMicroteachCase.MicroteachCaseID); //微格教学案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.MicroteachCaseID); //微格教学案例ID
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseName))
 {
 if (objMicroteachCaseEN.MicroteachCaseName !=  null)
 {
 var strMicroteachCaseName = objMicroteachCaseEN.MicroteachCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroteachCaseName, conMicroteachCase.MicroteachCaseName); //微格教学案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.MicroteachCaseName); //微格教学案例名称
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseTheme))
 {
 if (objMicroteachCaseEN.MicroteachCaseTheme !=  null)
 {
 var strMicroteachCaseTheme = objMicroteachCaseEN.MicroteachCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroteachCaseTheme, conMicroteachCase.MicroteachCaseTheme); //微格教学案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.MicroteachCaseTheme); //微格教学案例主题词
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseDate))
 {
 if (objMicroteachCaseEN.MicroteachCaseDate !=  null)
 {
 var strMicroteachCaseDate = objMicroteachCaseEN.MicroteachCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroteachCaseDate, conMicroteachCase.MicroteachCaseDate); //微格教学日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.MicroteachCaseDate); //微格教学日期
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseTime))
 {
 if (objMicroteachCaseEN.MicroteachCaseTime !=  null)
 {
 var strMicroteachCaseTime = objMicroteachCaseEN.MicroteachCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroteachCaseTime, conMicroteachCase.MicroteachCaseTime); //微格教学时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.MicroteachCaseTime); //微格教学时间
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroteachCaseDateIn))
 {
 if (objMicroteachCaseEN.MicroteachCaseDateIn !=  null)
 {
 var strMicroteachCaseDateIn = objMicroteachCaseEN.MicroteachCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroteachCaseDateIn, conMicroteachCase.MicroteachCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.MicroteachCaseDateIn); //案例入库日期
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdStudyLevel))
 {
 if (objMicroteachCaseEN.IdStudyLevel  ==  "")
 {
 objMicroteachCaseEN.IdStudyLevel = null;
 }
 if (objMicroteachCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objMicroteachCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conMicroteachCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdTeachingPlan))
 {
 if (objMicroteachCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objMicroteachCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conMicroteachCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.MicroTeachCaseTimeIn))
 {
 if (objMicroteachCaseEN.MicroTeachCaseTimeIn !=  null)
 {
 var strMicroTeachCaseTimeIn = objMicroteachCaseEN.MicroTeachCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroTeachCaseTimeIn, conMicroteachCase.MicroTeachCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.MicroTeachCaseTimeIn); //案例入库时间
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdMicroteachCaseType))
 {
 if (objMicroteachCaseEN.IdMicroteachCaseType !=  null)
 {
 var strIdMicroteachCaseType = objMicroteachCaseEN.IdMicroteachCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMicroteachCaseType, conMicroteachCase.IdMicroteachCaseType); //微格案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.IdMicroteachCaseType); //微格案例类型流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdCaseType))
 {
 if (objMicroteachCaseEN.IdCaseType  ==  "")
 {
 objMicroteachCaseEN.IdCaseType = null;
 }
 if (objMicroteachCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objMicroteachCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conMicroteachCase.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.IdCaseType); //案例类型流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdDiscipline))
 {
 if (objMicroteachCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objMicroteachCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conMicroteachCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.BrowseCount))
 {
 if (objMicroteachCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objMicroteachCaseEN.BrowseCount, conMicroteachCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.BrowseCount); //浏览次数
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdSenateGaugeVersion))
 {
 if (objMicroteachCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objMicroteachCaseEN.IdSenateGaugeVersion = null;
 }
 if (objMicroteachCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objMicroteachCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conMicroteachCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IdTeachSkill))
 {
 if (objMicroteachCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objMicroteachCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conMicroteachCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.CaseLevelId))
 {
 if (objMicroteachCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objMicroteachCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conMicroteachCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.DocFile))
 {
 if (objMicroteachCaseEN.DocFile !=  null)
 {
 var strDocFile = objMicroteachCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conMicroteachCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMicroteachCaseEN.IsNeedGeneWord == true?"1":"0", conMicroteachCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.WordCreateDate))
 {
 if (objMicroteachCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objMicroteachCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conMicroteachCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMicroteachCaseEN.IsVisible == true?"1":"0", conMicroteachCase.IsVisible); //是否显示
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.microteachCaseText))
 {
 if (objMicroteachCaseEN.microteachCaseText !=  null)
 {
 var strmicroteachCaseText = objMicroteachCaseEN.microteachCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strmicroteachCaseText, conMicroteachCase.microteachCaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.microteachCaseText); //案例文本内容
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.OwnerId))
 {
 if (objMicroteachCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objMicroteachCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conMicroteachCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.OwnerId); //拥有者Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMicroteachCaseEN.IsDualVideo == true?"1":"0", conMicroteachCase.IsDualVideo); //是否双视频
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UserKindId))
 {
 if (objMicroteachCaseEN.UserKindId !=  null)
 {
 var strUserKindId = objMicroteachCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserKindId, conMicroteachCase.UserKindId); //用户类别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.UserKindId); //用户类别Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UserTypeId))
 {
 if (objMicroteachCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objMicroteachCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conMicroteachCase.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.UserTypeId); //用户类型Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.RecommendedDegreeId))
 {
 if (objMicroteachCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objMicroteachCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conMicroteachCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.ftpFileType))
 {
 if (objMicroteachCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objMicroteachCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conMicroteachCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.VideoUrl))
 {
 if (objMicroteachCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objMicroteachCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conMicroteachCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.VideoUrl); //视频Url
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.VideoPath))
 {
 if (objMicroteachCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objMicroteachCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conMicroteachCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.VideoPath); //视频目录
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.ResErrMsg))
 {
 if (objMicroteachCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objMicroteachCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conMicroteachCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UpdDate))
 {
 if (objMicroteachCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objMicroteachCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conMicroteachCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.UpdDate); //修改日期
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.UpdUserId))
 {
 if (objMicroteachCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objMicroteachCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conMicroteachCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objMicroteachCaseEN.IsUpdated(conMicroteachCase.Memo))
 {
 if (objMicroteachCaseEN.Memo !=  null)
 {
 var strMemo = objMicroteachCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conMicroteachCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdMicroteachCase = '{0}'", objMicroteachCaseEN.IdMicroteachCase); 
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
 /// <param name = "strIdMicroteachCase">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdMicroteachCase) 
{
CheckPrimaryKey(strIdMicroteachCase);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdMicroteachCase,
};
 objSQL.ExecSP("MicroteachCase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdMicroteachCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdMicroteachCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdMicroteachCase);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
//删除MicroteachCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MicroteachCase where IdMicroteachCase = " + "'"+ strIdMicroteachCase+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelMicroteachCase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除MicroteachCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MicroteachCase where IdMicroteachCase in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdMicroteachCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdMicroteachCase) 
{
CheckPrimaryKey(strIdMicroteachCase);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
//删除MicroteachCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MicroteachCase where IdMicroteachCase = " + "'"+ strIdMicroteachCase+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelMicroteachCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsMicroteachCaseDA: DelMicroteachCase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from MicroteachCase where " + strCondition ;
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
public bool DelMicroteachCaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsMicroteachCaseDA: DelMicroteachCaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from MicroteachCase where " + strCondition ;
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
 /// <param name = "objMicroteachCaseENS">源对象</param>
 /// <param name = "objMicroteachCaseENT">目标对象</param>
public void CopyTo(clsMicroteachCaseEN objMicroteachCaseENS, clsMicroteachCaseEN objMicroteachCaseENT)
{
objMicroteachCaseENT.IdMicroteachCase = objMicroteachCaseENS.IdMicroteachCase; //微格教学案例流水号
objMicroteachCaseENT.MicroteachCaseID = objMicroteachCaseENS.MicroteachCaseID; //微格教学案例ID
objMicroteachCaseENT.MicroteachCaseName = objMicroteachCaseENS.MicroteachCaseName; //微格教学案例名称
objMicroteachCaseENT.MicroteachCaseTheme = objMicroteachCaseENS.MicroteachCaseTheme; //微格教学案例主题词
objMicroteachCaseENT.MicroteachCaseDate = objMicroteachCaseENS.MicroteachCaseDate; //微格教学日期
objMicroteachCaseENT.MicroteachCaseTime = objMicroteachCaseENS.MicroteachCaseTime; //微格教学时间
objMicroteachCaseENT.MicroteachCaseDateIn = objMicroteachCaseENS.MicroteachCaseDateIn; //案例入库日期
objMicroteachCaseENT.IdStudyLevel = objMicroteachCaseENS.IdStudyLevel; //学段流水号
objMicroteachCaseENT.IdTeachingPlan = objMicroteachCaseENS.IdTeachingPlan; //教案流水号
objMicroteachCaseENT.MicroTeachCaseTimeIn = objMicroteachCaseENS.MicroTeachCaseTimeIn; //案例入库时间
objMicroteachCaseENT.IdMicroteachCaseType = objMicroteachCaseENS.IdMicroteachCaseType; //微格案例类型流水号
objMicroteachCaseENT.IdCaseType = objMicroteachCaseENS.IdCaseType; //案例类型流水号
objMicroteachCaseENT.IdDiscipline = objMicroteachCaseENS.IdDiscipline; //学科流水号
objMicroteachCaseENT.BrowseCount = objMicroteachCaseENS.BrowseCount; //浏览次数
objMicroteachCaseENT.IdSenateGaugeVersion = objMicroteachCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objMicroteachCaseENT.IdTeachSkill = objMicroteachCaseENS.IdTeachSkill; //教学技能流水号
objMicroteachCaseENT.CaseLevelId = objMicroteachCaseENS.CaseLevelId; //课例等级Id
objMicroteachCaseENT.DocFile = objMicroteachCaseENS.DocFile; //生成的Word文件名
objMicroteachCaseENT.IsNeedGeneWord = objMicroteachCaseENS.IsNeedGeneWord; //是否需要生成Word
objMicroteachCaseENT.WordCreateDate = objMicroteachCaseENS.WordCreateDate; //Word生成日期
objMicroteachCaseENT.IsVisible = objMicroteachCaseENS.IsVisible; //是否显示
objMicroteachCaseENT.microteachCaseText = objMicroteachCaseENS.microteachCaseText; //案例文本内容
objMicroteachCaseENT.OwnerId = objMicroteachCaseENS.OwnerId; //拥有者Id
objMicroteachCaseENT.IsDualVideo = objMicroteachCaseENS.IsDualVideo; //是否双视频
objMicroteachCaseENT.UserKindId = objMicroteachCaseENS.UserKindId; //用户类别Id
objMicroteachCaseENT.UserTypeId = objMicroteachCaseENS.UserTypeId; //用户类型Id
objMicroteachCaseENT.RecommendedDegreeId = objMicroteachCaseENS.RecommendedDegreeId; //推荐度Id
objMicroteachCaseENT.ftpFileType = objMicroteachCaseENS.ftpFileType; //ftp文件类型
objMicroteachCaseENT.VideoUrl = objMicroteachCaseENS.VideoUrl; //视频Url
objMicroteachCaseENT.VideoPath = objMicroteachCaseENS.VideoPath; //视频目录
objMicroteachCaseENT.ResErrMsg = objMicroteachCaseENS.ResErrMsg; //资源错误信息
objMicroteachCaseENT.UpdDate = objMicroteachCaseENS.UpdDate; //修改日期
objMicroteachCaseENT.UpdUserId = objMicroteachCaseENS.UpdUserId; //修改用户Id
objMicroteachCaseENT.Memo = objMicroteachCaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsMicroteachCaseEN objMicroteachCaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objMicroteachCaseEN.MicroteachCaseID, conMicroteachCase.MicroteachCaseID);
clsCheckSql.CheckFieldNotNull(objMicroteachCaseEN.MicroteachCaseName, conMicroteachCase.MicroteachCaseName);
clsCheckSql.CheckFieldNotNull(objMicroteachCaseEN.IdStudyLevel, conMicroteachCase.IdStudyLevel);
clsCheckSql.CheckFieldNotNull(objMicroteachCaseEN.IdDiscipline, conMicroteachCase.IdDiscipline);
clsCheckSql.CheckFieldNotNull(objMicroteachCaseEN.IdTeachSkill, conMicroteachCase.IdTeachSkill);
clsCheckSql.CheckFieldNotNull(objMicroteachCaseEN.OwnerId, conMicroteachCase.OwnerId);
clsCheckSql.CheckFieldNotNull(objMicroteachCaseEN.UserKindId, conMicroteachCase.UserKindId);
clsCheckSql.CheckFieldNotNull(objMicroteachCaseEN.RecommendedDegreeId, conMicroteachCase.RecommendedDegreeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdMicroteachCase, 8, conMicroteachCase.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseID, 8, conMicroteachCase.MicroteachCaseID);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseName, 100, conMicroteachCase.MicroteachCaseName);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseTheme, 200, conMicroteachCase.MicroteachCaseTheme);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseDate, 8, conMicroteachCase.MicroteachCaseDate);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseTime, 6, conMicroteachCase.MicroteachCaseTime);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseDateIn, 8, conMicroteachCase.MicroteachCaseDateIn);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdStudyLevel, 4, conMicroteachCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdTeachingPlan, 8, conMicroteachCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroTeachCaseTimeIn, 6, conMicroteachCase.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdMicroteachCaseType, 4, conMicroteachCase.IdMicroteachCaseType);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdCaseType, 4, conMicroteachCase.IdCaseType);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdDiscipline, 4, conMicroteachCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdSenateGaugeVersion, 4, conMicroteachCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdTeachSkill, 8, conMicroteachCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.CaseLevelId, 2, conMicroteachCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.DocFile, 200, conMicroteachCase.DocFile);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.WordCreateDate, 14, conMicroteachCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.microteachCaseText, 8000, conMicroteachCase.microteachCaseText);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.OwnerId, 20, conMicroteachCase.OwnerId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.UserKindId, 2, conMicroteachCase.UserKindId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.UserTypeId, 2, conMicroteachCase.UserTypeId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.RecommendedDegreeId, 2, conMicroteachCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.ftpFileType, 30, conMicroteachCase.ftpFileType);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.VideoUrl, 1000, conMicroteachCase.VideoUrl);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.VideoPath, 1000, conMicroteachCase.VideoPath);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.ResErrMsg, 30, conMicroteachCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.UpdDate, 20, conMicroteachCase.UpdDate);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.UpdUserId, 20, conMicroteachCase.UpdUserId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.Memo, 1000, conMicroteachCase.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objMicroteachCaseEN.IdStudyLevel, 4, conMicroteachCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objMicroteachCaseEN.IdCaseType, 4, conMicroteachCase.IdCaseType);
clsCheckSql.CheckFieldForeignKey(objMicroteachCaseEN.IdSenateGaugeVersion, 4, conMicroteachCase.IdSenateGaugeVersion);
 objMicroteachCaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsMicroteachCaseEN objMicroteachCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseID, 8, conMicroteachCase.MicroteachCaseID);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseName, 100, conMicroteachCase.MicroteachCaseName);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseTheme, 200, conMicroteachCase.MicroteachCaseTheme);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseDate, 8, conMicroteachCase.MicroteachCaseDate);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseTime, 6, conMicroteachCase.MicroteachCaseTime);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseDateIn, 8, conMicroteachCase.MicroteachCaseDateIn);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdStudyLevel, 4, conMicroteachCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdTeachingPlan, 8, conMicroteachCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroTeachCaseTimeIn, 6, conMicroteachCase.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdMicroteachCaseType, 4, conMicroteachCase.IdMicroteachCaseType);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdCaseType, 4, conMicroteachCase.IdCaseType);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdDiscipline, 4, conMicroteachCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdSenateGaugeVersion, 4, conMicroteachCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdTeachSkill, 8, conMicroteachCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.CaseLevelId, 2, conMicroteachCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.DocFile, 200, conMicroteachCase.DocFile);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.WordCreateDate, 14, conMicroteachCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.microteachCaseText, 8000, conMicroteachCase.microteachCaseText);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.OwnerId, 20, conMicroteachCase.OwnerId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.UserKindId, 2, conMicroteachCase.UserKindId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.UserTypeId, 2, conMicroteachCase.UserTypeId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.RecommendedDegreeId, 2, conMicroteachCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.ftpFileType, 30, conMicroteachCase.ftpFileType);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.VideoUrl, 1000, conMicroteachCase.VideoUrl);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.VideoPath, 1000, conMicroteachCase.VideoPath);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.ResErrMsg, 30, conMicroteachCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.UpdDate, 20, conMicroteachCase.UpdDate);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.UpdUserId, 20, conMicroteachCase.UpdUserId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.Memo, 1000, conMicroteachCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objMicroteachCaseEN.IdStudyLevel, 4, conMicroteachCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objMicroteachCaseEN.IdCaseType, 4, conMicroteachCase.IdCaseType);
clsCheckSql.CheckFieldForeignKey(objMicroteachCaseEN.IdSenateGaugeVersion, 4, conMicroteachCase.IdSenateGaugeVersion);
 objMicroteachCaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsMicroteachCaseEN objMicroteachCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdMicroteachCase, 8, conMicroteachCase.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseID, 8, conMicroteachCase.MicroteachCaseID);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseName, 100, conMicroteachCase.MicroteachCaseName);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseTheme, 200, conMicroteachCase.MicroteachCaseTheme);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseDate, 8, conMicroteachCase.MicroteachCaseDate);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseTime, 6, conMicroteachCase.MicroteachCaseTime);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroteachCaseDateIn, 8, conMicroteachCase.MicroteachCaseDateIn);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdStudyLevel, 4, conMicroteachCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdTeachingPlan, 8, conMicroteachCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.MicroTeachCaseTimeIn, 6, conMicroteachCase.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdMicroteachCaseType, 4, conMicroteachCase.IdMicroteachCaseType);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdCaseType, 4, conMicroteachCase.IdCaseType);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdDiscipline, 4, conMicroteachCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdSenateGaugeVersion, 4, conMicroteachCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.IdTeachSkill, 8, conMicroteachCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.CaseLevelId, 2, conMicroteachCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.DocFile, 200, conMicroteachCase.DocFile);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.WordCreateDate, 14, conMicroteachCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.microteachCaseText, 8000, conMicroteachCase.microteachCaseText);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.OwnerId, 20, conMicroteachCase.OwnerId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.UserKindId, 2, conMicroteachCase.UserKindId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.UserTypeId, 2, conMicroteachCase.UserTypeId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.RecommendedDegreeId, 2, conMicroteachCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.ftpFileType, 30, conMicroteachCase.ftpFileType);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.VideoUrl, 1000, conMicroteachCase.VideoUrl);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.VideoPath, 1000, conMicroteachCase.VideoPath);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.ResErrMsg, 30, conMicroteachCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.UpdDate, 20, conMicroteachCase.UpdDate);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.UpdUserId, 20, conMicroteachCase.UpdUserId);
clsCheckSql.CheckFieldLen(objMicroteachCaseEN.Memo, 1000, conMicroteachCase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.IdMicroteachCase, conMicroteachCase.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.MicroteachCaseID, conMicroteachCase.MicroteachCaseID);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.MicroteachCaseName, conMicroteachCase.MicroteachCaseName);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.MicroteachCaseTheme, conMicroteachCase.MicroteachCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.MicroteachCaseDate, conMicroteachCase.MicroteachCaseDate);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.MicroteachCaseTime, conMicroteachCase.MicroteachCaseTime);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.MicroteachCaseDateIn, conMicroteachCase.MicroteachCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.IdStudyLevel, conMicroteachCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.IdTeachingPlan, conMicroteachCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.MicroTeachCaseTimeIn, conMicroteachCase.MicroTeachCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.IdMicroteachCaseType, conMicroteachCase.IdMicroteachCaseType);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.IdCaseType, conMicroteachCase.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.IdDiscipline, conMicroteachCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.IdSenateGaugeVersion, conMicroteachCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.IdTeachSkill, conMicroteachCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.CaseLevelId, conMicroteachCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.DocFile, conMicroteachCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.WordCreateDate, conMicroteachCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.microteachCaseText, conMicroteachCase.microteachCaseText);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.OwnerId, conMicroteachCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.UserKindId, conMicroteachCase.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.UserTypeId, conMicroteachCase.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.RecommendedDegreeId, conMicroteachCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.ftpFileType, conMicroteachCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.VideoUrl, conMicroteachCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.VideoPath, conMicroteachCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.ResErrMsg, conMicroteachCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.UpdDate, conMicroteachCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.UpdUserId, conMicroteachCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseEN.Memo, conMicroteachCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objMicroteachCaseEN.IdStudyLevel, 4, conMicroteachCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objMicroteachCaseEN.IdCaseType, 4, conMicroteachCase.IdCaseType);
clsCheckSql.CheckFieldForeignKey(objMicroteachCaseEN.IdSenateGaugeVersion, 4, conMicroteachCase.IdSenateGaugeVersion);
 objMicroteachCaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdMicroteachCase()
{
//获取某学院所有专业信息
string strSQL = "select IdMicroteachCase, MicroteachCaseName from MicroteachCase ";
 clsSpecSQLforSql mySql = clsMicroteachCaseDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
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
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
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
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsMicroteachCaseEN._CurrTabName);
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
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsMicroteachCaseEN._CurrTabName, strCondition);
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
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
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
 objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}