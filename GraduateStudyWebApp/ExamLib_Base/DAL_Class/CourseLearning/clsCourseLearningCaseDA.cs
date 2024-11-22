
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCourseLearningCaseDA
 表名:CourseLearningCase(01120274)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 课程学习案例(CourseLearningCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCourseLearningCaseDA : clsCommBase4DA
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
 return clsCourseLearningCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCourseLearningCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCourseLearningCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCourseLearningCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCourseLearningCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdCourseLearningCase)
{
strIdCourseLearningCase = strIdCourseLearningCase.Replace("'", "''");
if (strIdCourseLearningCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:CourseLearningCase中,检查关键字,长度不正确!(clsCourseLearningCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCourseLearningCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CourseLearningCase中,关键字不能为空 或 null!(clsCourseLearningCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCourseLearningCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCourseLearningCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCourseLearningCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
strSQL = "Select * from CourseLearningCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CourseLearningCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCourseLearningCaseDA: GetDataTable_CourseLearningCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
strSQL = "Select * from CourseLearningCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCourseLearningCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCourseLearningCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
strSQL = "Select * from CourseLearningCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCourseLearningCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCourseLearningCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CourseLearningCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CourseLearningCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCourseLearningCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CourseLearningCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCourseLearningCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CourseLearningCase.* from CourseLearningCase Left Join {1} on {2} where {3} and CourseLearningCase.IdCourseLearningCase not in (Select top {5} CourseLearningCase.IdCourseLearningCase from CourseLearningCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CourseLearningCase where {1} and IdCourseLearningCase not in (Select top {2} IdCourseLearningCase from CourseLearningCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CourseLearningCase where {1} and IdCourseLearningCase not in (Select top {3} IdCourseLearningCase from CourseLearningCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCourseLearningCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CourseLearningCase.* from CourseLearningCase Left Join {1} on {2} where {3} and CourseLearningCase.IdCourseLearningCase not in (Select top {5} CourseLearningCase.IdCourseLearningCase from CourseLearningCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CourseLearningCase where {1} and IdCourseLearningCase not in (Select top {2} IdCourseLearningCase from CourseLearningCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CourseLearningCase where {1} and IdCourseLearningCase not in (Select top {3} IdCourseLearningCase from CourseLearningCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCourseLearningCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCourseLearningCaseDA:GetObjLst)", objException.Message));
}
List<clsCourseLearningCaseEN> arrObjLst = new List<clsCourseLearningCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
strSQL = "Select * from CourseLearningCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN();
try
{
objCourseLearningCaseEN.IdCourseLearningCase = objRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objCourseLearningCaseEN.CourseLearningCaseID = objRow[conCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objCourseLearningCaseEN.CourseLearningCaseName = objRow[conCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objCourseLearningCaseEN.CourseLearningCaseText = objRow[conCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objCourseLearningCaseEN.CourseLearningCaseTheme = objRow[conCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objCourseLearningCaseEN.CourseLearningCaseDate = objRow[conCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objCourseLearningCaseEN.CourseLearningCaseTime = objRow[conCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[conCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[conCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objCourseLearningCaseEN.IdCaseType = objRow[conCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[conCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCourseLearningCaseEN.IdCourseLearningCaseType = objRow[conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objCourseLearningCaseEN.OwnerId = objRow[conCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objCourseLearningCaseEN.IdStudyLevel = objRow[conCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCourseLearningCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCourseLearningCaseEN.IdTeachingPlan = objRow[conCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCourseLearningCaseEN.IdDiscipline = objRow[conCourseLearningCase.IdDiscipline] == DBNull.Value ? null : objRow[conCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objCourseLearningCaseEN.BrowseCount = objRow[conCourseLearningCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.BrowseCount].ToString().Trim()); //浏览次数
objCourseLearningCaseEN.IdSenateGaugeVersion = objRow[conCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCourseLearningCaseEN.IdTeachSkill = objRow[conCourseLearningCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCourseLearningCaseEN.CaseLevelId = objRow[conCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[conCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCourseLearningCaseEN.DocFile = objRow[conCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[conCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objCourseLearningCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCourseLearningCaseEN.WordCreateDate = objRow[conCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[conCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCourseLearningCaseEN.IsVisible = TransNullToBool(objRow[conCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objCourseLearningCaseEN.IsDualVideo = TransNullToBool(objRow[conCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objCourseLearningCaseEN.IdXzCollege = objRow[conCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objCourseLearningCaseEN.IdXzMajor = objRow[conCourseLearningCase.IdXzMajor] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objCourseLearningCaseEN.CourseId = objRow[conCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objCourseLearningCaseEN.TeachingSolutionId = objRow[conCourseLearningCase.TeachingSolutionId] == DBNull.Value ? null : objRow[conCourseLearningCase.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCourseLearningCaseEN.CourseChapterId = objRow[conCourseLearningCase.CourseChapterId] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCourseLearningCaseEN.ViewCount = objRow[conCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objCourseLearningCaseEN.IsShow = TransNullToBool(objRow[conCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objCourseLearningCaseEN.DownloadNumber = objRow[conCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objCourseLearningCaseEN.FileIntegration = objRow[conCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objCourseLearningCaseEN.LikeCount = objRow[conCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCourseLearningCaseEN.CollectionCount = objRow[conCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objCourseLearningCaseEN.RecommendedDegreeId = objRow[conCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCourseLearningCaseEN.ftpFileType = objRow[conCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[conCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCourseLearningCaseEN.VideoUrl = objRow[conCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objCourseLearningCaseEN.VideoPath = objRow[conCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objCourseLearningCaseEN.ImageUrl = objRow[conCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objCourseLearningCaseEN.ResErrMsg = objRow[conCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[conCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCourseLearningCaseEN.OrderNum = objRow[conCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.OrderNum].ToString().Trim()); //序号
objCourseLearningCaseEN.UpdDate = objRow[conCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objCourseLearningCaseEN.UpdUserId = objRow[conCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objCourseLearningCaseEN.Memo = objRow[conCourseLearningCase.Memo] == DBNull.Value ? null : objRow[conCourseLearningCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCourseLearningCaseDA: GetObjLst)", objException.Message));
}
objCourseLearningCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCourseLearningCaseEN);
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
public List<clsCourseLearningCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCourseLearningCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsCourseLearningCaseEN> arrObjLst = new List<clsCourseLearningCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN();
try
{
objCourseLearningCaseEN.IdCourseLearningCase = objRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objCourseLearningCaseEN.CourseLearningCaseID = objRow[conCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objCourseLearningCaseEN.CourseLearningCaseName = objRow[conCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objCourseLearningCaseEN.CourseLearningCaseText = objRow[conCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objCourseLearningCaseEN.CourseLearningCaseTheme = objRow[conCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objCourseLearningCaseEN.CourseLearningCaseDate = objRow[conCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objCourseLearningCaseEN.CourseLearningCaseTime = objRow[conCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[conCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[conCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objCourseLearningCaseEN.IdCaseType = objRow[conCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[conCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCourseLearningCaseEN.IdCourseLearningCaseType = objRow[conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objCourseLearningCaseEN.OwnerId = objRow[conCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objCourseLearningCaseEN.IdStudyLevel = objRow[conCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCourseLearningCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCourseLearningCaseEN.IdTeachingPlan = objRow[conCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCourseLearningCaseEN.IdDiscipline = objRow[conCourseLearningCase.IdDiscipline] == DBNull.Value ? null : objRow[conCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objCourseLearningCaseEN.BrowseCount = objRow[conCourseLearningCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.BrowseCount].ToString().Trim()); //浏览次数
objCourseLearningCaseEN.IdSenateGaugeVersion = objRow[conCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCourseLearningCaseEN.IdTeachSkill = objRow[conCourseLearningCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCourseLearningCaseEN.CaseLevelId = objRow[conCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[conCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCourseLearningCaseEN.DocFile = objRow[conCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[conCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objCourseLearningCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCourseLearningCaseEN.WordCreateDate = objRow[conCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[conCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCourseLearningCaseEN.IsVisible = TransNullToBool(objRow[conCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objCourseLearningCaseEN.IsDualVideo = TransNullToBool(objRow[conCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objCourseLearningCaseEN.IdXzCollege = objRow[conCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objCourseLearningCaseEN.IdXzMajor = objRow[conCourseLearningCase.IdXzMajor] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objCourseLearningCaseEN.CourseId = objRow[conCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objCourseLearningCaseEN.TeachingSolutionId = objRow[conCourseLearningCase.TeachingSolutionId] == DBNull.Value ? null : objRow[conCourseLearningCase.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCourseLearningCaseEN.CourseChapterId = objRow[conCourseLearningCase.CourseChapterId] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCourseLearningCaseEN.ViewCount = objRow[conCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objCourseLearningCaseEN.IsShow = TransNullToBool(objRow[conCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objCourseLearningCaseEN.DownloadNumber = objRow[conCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objCourseLearningCaseEN.FileIntegration = objRow[conCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objCourseLearningCaseEN.LikeCount = objRow[conCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCourseLearningCaseEN.CollectionCount = objRow[conCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objCourseLearningCaseEN.RecommendedDegreeId = objRow[conCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCourseLearningCaseEN.ftpFileType = objRow[conCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[conCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCourseLearningCaseEN.VideoUrl = objRow[conCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objCourseLearningCaseEN.VideoPath = objRow[conCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objCourseLearningCaseEN.ImageUrl = objRow[conCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objCourseLearningCaseEN.ResErrMsg = objRow[conCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[conCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCourseLearningCaseEN.OrderNum = objRow[conCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.OrderNum].ToString().Trim()); //序号
objCourseLearningCaseEN.UpdDate = objRow[conCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objCourseLearningCaseEN.UpdUserId = objRow[conCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objCourseLearningCaseEN.Memo = objRow[conCourseLearningCase.Memo] == DBNull.Value ? null : objRow[conCourseLearningCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCourseLearningCaseDA: GetObjLst)", objException.Message));
}
objCourseLearningCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCourseLearningCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCourseLearningCase(ref clsCourseLearningCaseEN objCourseLearningCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
strSQL = "Select * from CourseLearningCase where IdCourseLearningCase = " + "'"+ objCourseLearningCaseEN.IdCourseLearningCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCourseLearningCaseEN.IdCourseLearningCase = objDT.Rows[0][conCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objCourseLearningCaseEN.CourseLearningCaseID = objDT.Rows[0][conCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID(字段类型:char,字段长度:8,是否可空:False)
 objCourseLearningCaseEN.CourseLearningCaseName = objDT.Rows[0][conCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objCourseLearningCaseEN.CourseLearningCaseText = objDT.Rows[0][conCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objCourseLearningCaseEN.CourseLearningCaseTheme = objDT.Rows[0][conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objCourseLearningCaseEN.CourseLearningCaseDate = objDT.Rows[0][conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期(字段类型:char,字段长度:8,是否可空:True)
 objCourseLearningCaseEN.CourseLearningCaseTime = objDT.Rows[0][conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间(字段类型:char,字段长度:6,是否可空:True)
 objCourseLearningCaseEN.CourseLearningCaseDateIn = objDT.Rows[0][conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objCourseLearningCaseEN.CourseLearningCaseTimeIn = objDT.Rows[0][conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objCourseLearningCaseEN.IdCaseType = objDT.Rows[0][conCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objCourseLearningCaseEN.IdCourseLearningCaseType = objDT.Rows[0][conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCourseLearningCaseEN.OwnerId = objDT.Rows[0][conCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objCourseLearningCaseEN.IdStudyLevel = objDT.Rows[0][conCourseLearningCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objCourseLearningCaseEN.IdTeachingPlan = objDT.Rows[0][conCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objCourseLearningCaseEN.IdDiscipline = objDT.Rows[0][conCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objCourseLearningCaseEN.BrowseCount = TransNullToInt(objDT.Rows[0][conCourseLearningCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objCourseLearningCaseEN.IdSenateGaugeVersion = objDT.Rows[0][conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objCourseLearningCaseEN.IdTeachSkill = objDT.Rows[0][conCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objCourseLearningCaseEN.CaseLevelId = objDT.Rows[0][conCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objCourseLearningCaseEN.DocFile = objDT.Rows[0][conCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objCourseLearningCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][conCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objCourseLearningCaseEN.WordCreateDate = objDT.Rows[0][conCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objCourseLearningCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][conCourseLearningCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objCourseLearningCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][conCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objCourseLearningCaseEN.IdXzCollege = objDT.Rows[0][conCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objCourseLearningCaseEN.IdXzMajor = objDT.Rows[0][conCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objCourseLearningCaseEN.CourseId = objDT.Rows[0][conCourseLearningCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objCourseLearningCaseEN.TeachingSolutionId = objDT.Rows[0][conCourseLearningCase.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objCourseLearningCaseEN.CourseChapterId = objDT.Rows[0][conCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objCourseLearningCaseEN.ViewCount = TransNullToInt(objDT.Rows[0][conCourseLearningCase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objCourseLearningCaseEN.IsShow = TransNullToBool(objDT.Rows[0][conCourseLearningCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objCourseLearningCaseEN.DownloadNumber = TransNullToInt(objDT.Rows[0][conCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objCourseLearningCaseEN.FileIntegration = TransNullToInt(objDT.Rows[0][conCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objCourseLearningCaseEN.LikeCount = TransNullToInt(objDT.Rows[0][conCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objCourseLearningCaseEN.CollectionCount = TransNullToInt(objDT.Rows[0][conCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objCourseLearningCaseEN.RecommendedDegreeId = objDT.Rows[0][conCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objCourseLearningCaseEN.ftpFileType = objDT.Rows[0][conCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objCourseLearningCaseEN.VideoUrl = objDT.Rows[0][conCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objCourseLearningCaseEN.VideoPath = objDT.Rows[0][conCourseLearningCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objCourseLearningCaseEN.ImageUrl = objDT.Rows[0][conCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl(字段类型:varchar,字段长度:100,是否可空:True)
 objCourseLearningCaseEN.ResErrMsg = objDT.Rows[0][conCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objCourseLearningCaseEN.OrderNum = TransNullToInt(objDT.Rows[0][conCourseLearningCase.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objCourseLearningCaseEN.UpdDate = objDT.Rows[0][conCourseLearningCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCourseLearningCaseEN.UpdUserId = objDT.Rows[0][conCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCourseLearningCaseEN.Memo = objDT.Rows[0][conCourseLearningCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCourseLearningCaseDA: GetCourseLearningCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public clsCourseLearningCaseEN GetObjByIdCourseLearningCase(string strIdCourseLearningCase)
{
CheckPrimaryKey(strIdCourseLearningCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
strSQL = "Select * from CourseLearningCase where IdCourseLearningCase = " + "'"+ strIdCourseLearningCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN();
try
{
 objCourseLearningCaseEN.IdCourseLearningCase = objRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objCourseLearningCaseEN.CourseLearningCaseID = objRow[conCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID(字段类型:char,字段长度:8,是否可空:False)
 objCourseLearningCaseEN.CourseLearningCaseName = objRow[conCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objCourseLearningCaseEN.CourseLearningCaseText = objRow[conCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objCourseLearningCaseEN.CourseLearningCaseTheme = objRow[conCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objCourseLearningCaseEN.CourseLearningCaseDate = objRow[conCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期(字段类型:char,字段长度:8,是否可空:True)
 objCourseLearningCaseEN.CourseLearningCaseTime = objRow[conCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间(字段类型:char,字段长度:6,是否可空:True)
 objCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[conCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[conCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objCourseLearningCaseEN.IdCaseType = objRow[conCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[conCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objCourseLearningCaseEN.IdCourseLearningCaseType = objRow[conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCourseLearningCaseEN.OwnerId = objRow[conCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objCourseLearningCaseEN.IdStudyLevel = objRow[conCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCourseLearningCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objCourseLearningCaseEN.IdTeachingPlan = objRow[conCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objCourseLearningCaseEN.IdDiscipline = objRow[conCourseLearningCase.IdDiscipline] == DBNull.Value ? null : objRow[conCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objCourseLearningCaseEN.BrowseCount = objRow[conCourseLearningCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objCourseLearningCaseEN.IdSenateGaugeVersion = objRow[conCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objCourseLearningCaseEN.IdTeachSkill = objRow[conCourseLearningCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objCourseLearningCaseEN.CaseLevelId = objRow[conCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[conCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objCourseLearningCaseEN.DocFile = objRow[conCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[conCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objCourseLearningCaseEN.WordCreateDate = objRow[conCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[conCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objCourseLearningCaseEN.IdXzCollege = objRow[conCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objCourseLearningCaseEN.IdXzMajor = objRow[conCourseLearningCase.IdXzMajor] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objCourseLearningCaseEN.CourseId = objRow[conCourseLearningCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objCourseLearningCaseEN.TeachingSolutionId = objRow[conCourseLearningCase.TeachingSolutionId] == DBNull.Value ? null : objRow[conCourseLearningCase.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objCourseLearningCaseEN.CourseChapterId = objRow[conCourseLearningCase.CourseChapterId] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objCourseLearningCaseEN.ViewCount = objRow[conCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objCourseLearningCaseEN.DownloadNumber = objRow[conCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objCourseLearningCaseEN.FileIntegration = objRow[conCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objCourseLearningCaseEN.LikeCount = objRow[conCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objCourseLearningCaseEN.CollectionCount = objRow[conCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objCourseLearningCaseEN.RecommendedDegreeId = objRow[conCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objCourseLearningCaseEN.ftpFileType = objRow[conCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[conCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objCourseLearningCaseEN.VideoUrl = objRow[conCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objCourseLearningCaseEN.VideoPath = objRow[conCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objCourseLearningCaseEN.ImageUrl = objRow[conCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl(字段类型:varchar,字段长度:100,是否可空:True)
 objCourseLearningCaseEN.ResErrMsg = objRow[conCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[conCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objCourseLearningCaseEN.OrderNum = objRow[conCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objCourseLearningCaseEN.UpdDate = objRow[conCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCourseLearningCaseEN.UpdUserId = objRow[conCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCourseLearningCaseEN.Memo = objRow[conCourseLearningCase.Memo] == DBNull.Value ? null : objRow[conCourseLearningCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCourseLearningCaseDA: GetObjByIdCourseLearningCase)", objException.Message));
}
return objCourseLearningCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCourseLearningCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCourseLearningCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
strSQL = "Select * from CourseLearningCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN()
{
IdCourseLearningCase = objRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim(), //课程学习案例流水号
CourseLearningCaseID = objRow[conCourseLearningCase.CourseLearningCaseID].ToString().Trim(), //课程学习案例ID
CourseLearningCaseName = objRow[conCourseLearningCase.CourseLearningCaseName].ToString().Trim(), //课程学习案例名称
CourseLearningCaseText = objRow[conCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseText].ToString().Trim(), //案例文本内容
CourseLearningCaseTheme = objRow[conCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(), //课程学习案例主题词
CourseLearningCaseDate = objRow[conCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(), //课程学习日期
CourseLearningCaseTime = objRow[conCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(), //课程学习时间
CourseLearningCaseDateIn = objRow[conCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(), //案例入库日期
CourseLearningCaseTimeIn = objRow[conCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(), //案例入库时间
IdCaseType = objRow[conCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[conCourseLearningCase.IdCaseType].ToString().Trim(), //案例类型流水号
IdCourseLearningCaseType = objRow[conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(), //课程学习案例类型流水号
OwnerId = objRow[conCourseLearningCase.OwnerId].ToString().Trim(), //拥有者Id
IdStudyLevel = objRow[conCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCourseLearningCase.IdStudyLevel].ToString().Trim(), //学段流水号
IdTeachingPlan = objRow[conCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdDiscipline = objRow[conCourseLearningCase.IdDiscipline] == DBNull.Value ? null : objRow[conCourseLearningCase.IdDiscipline].ToString().Trim(), //学科流水号
BrowseCount = objRow[conCourseLearningCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[conCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
IdTeachSkill = objRow[conCourseLearningCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
CaseLevelId = objRow[conCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[conCourseLearningCase.CaseLevelId].ToString().Trim(), //课例等级Id
DocFile = objRow[conCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[conCourseLearningCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[conCourseLearningCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[conCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[conCourseLearningCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[conCourseLearningCase.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[conCourseLearningCase.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[conCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[conCourseLearningCase.IdXzMajor] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzMajor].ToString().Trim(), //专业流水号
CourseId = objRow[conCourseLearningCase.CourseId].ToString().Trim(), //课程Id
TeachingSolutionId = objRow[conCourseLearningCase.TeachingSolutionId] == DBNull.Value ? null : objRow[conCourseLearningCase.TeachingSolutionId].ToString().Trim(), //教学方案Id
CourseChapterId = objRow[conCourseLearningCase.CourseChapterId] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseChapterId].ToString().Trim(), //课程章节ID
ViewCount = objRow[conCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[conCourseLearningCase.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[conCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[conCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[conCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCourseLearningCase.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[conCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCourseLearningCase.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[conCourseLearningCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
ftpFileType = objRow[conCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[conCourseLearningCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[conCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[conCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoPath].ToString().Trim(), //视频目录
ImageUrl = objRow[conCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.ImageUrl].ToString().Trim(), //ImageUrl
ResErrMsg = objRow[conCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[conCourseLearningCase.ResErrMsg].ToString().Trim(), //资源错误信息
OrderNum = objRow[conCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conCourseLearningCase.Memo] == DBNull.Value ? null : objRow[conCourseLearningCase.Memo].ToString().Trim() //备注
};
objCourseLearningCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCourseLearningCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCourseLearningCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCourseLearningCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN();
try
{
objCourseLearningCaseEN.IdCourseLearningCase = objRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objCourseLearningCaseEN.CourseLearningCaseID = objRow[conCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objCourseLearningCaseEN.CourseLearningCaseName = objRow[conCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objCourseLearningCaseEN.CourseLearningCaseText = objRow[conCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objCourseLearningCaseEN.CourseLearningCaseTheme = objRow[conCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objCourseLearningCaseEN.CourseLearningCaseDate = objRow[conCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objCourseLearningCaseEN.CourseLearningCaseTime = objRow[conCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[conCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[conCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objCourseLearningCaseEN.IdCaseType = objRow[conCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[conCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCourseLearningCaseEN.IdCourseLearningCaseType = objRow[conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objCourseLearningCaseEN.OwnerId = objRow[conCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objCourseLearningCaseEN.IdStudyLevel = objRow[conCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCourseLearningCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCourseLearningCaseEN.IdTeachingPlan = objRow[conCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCourseLearningCaseEN.IdDiscipline = objRow[conCourseLearningCase.IdDiscipline] == DBNull.Value ? null : objRow[conCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objCourseLearningCaseEN.BrowseCount = objRow[conCourseLearningCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.BrowseCount].ToString().Trim()); //浏览次数
objCourseLearningCaseEN.IdSenateGaugeVersion = objRow[conCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCourseLearningCaseEN.IdTeachSkill = objRow[conCourseLearningCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCourseLearningCaseEN.CaseLevelId = objRow[conCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[conCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCourseLearningCaseEN.DocFile = objRow[conCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[conCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objCourseLearningCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCourseLearningCaseEN.WordCreateDate = objRow[conCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[conCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCourseLearningCaseEN.IsVisible = TransNullToBool(objRow[conCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objCourseLearningCaseEN.IsDualVideo = TransNullToBool(objRow[conCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objCourseLearningCaseEN.IdXzCollege = objRow[conCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objCourseLearningCaseEN.IdXzMajor = objRow[conCourseLearningCase.IdXzMajor] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objCourseLearningCaseEN.CourseId = objRow[conCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objCourseLearningCaseEN.TeachingSolutionId = objRow[conCourseLearningCase.TeachingSolutionId] == DBNull.Value ? null : objRow[conCourseLearningCase.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCourseLearningCaseEN.CourseChapterId = objRow[conCourseLearningCase.CourseChapterId] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCourseLearningCaseEN.ViewCount = objRow[conCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objCourseLearningCaseEN.IsShow = TransNullToBool(objRow[conCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objCourseLearningCaseEN.DownloadNumber = objRow[conCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objCourseLearningCaseEN.FileIntegration = objRow[conCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objCourseLearningCaseEN.LikeCount = objRow[conCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCourseLearningCaseEN.CollectionCount = objRow[conCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objCourseLearningCaseEN.RecommendedDegreeId = objRow[conCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCourseLearningCaseEN.ftpFileType = objRow[conCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[conCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCourseLearningCaseEN.VideoUrl = objRow[conCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objCourseLearningCaseEN.VideoPath = objRow[conCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objCourseLearningCaseEN.ImageUrl = objRow[conCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objCourseLearningCaseEN.ResErrMsg = objRow[conCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[conCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCourseLearningCaseEN.OrderNum = objRow[conCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.OrderNum].ToString().Trim()); //序号
objCourseLearningCaseEN.UpdDate = objRow[conCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objCourseLearningCaseEN.UpdUserId = objRow[conCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objCourseLearningCaseEN.Memo = objRow[conCourseLearningCase.Memo] == DBNull.Value ? null : objRow[conCourseLearningCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCourseLearningCaseDA: GetObjByDataRowCourseLearningCase)", objException.Message));
}
objCourseLearningCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCourseLearningCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCourseLearningCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN();
try
{
objCourseLearningCaseEN.IdCourseLearningCase = objRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objCourseLearningCaseEN.CourseLearningCaseID = objRow[conCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objCourseLearningCaseEN.CourseLearningCaseName = objRow[conCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objCourseLearningCaseEN.CourseLearningCaseText = objRow[conCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objCourseLearningCaseEN.CourseLearningCaseTheme = objRow[conCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objCourseLearningCaseEN.CourseLearningCaseDate = objRow[conCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objCourseLearningCaseEN.CourseLearningCaseTime = objRow[conCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[conCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[conCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objCourseLearningCaseEN.IdCaseType = objRow[conCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[conCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCourseLearningCaseEN.IdCourseLearningCaseType = objRow[conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objCourseLearningCaseEN.OwnerId = objRow[conCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objCourseLearningCaseEN.IdStudyLevel = objRow[conCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCourseLearningCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCourseLearningCaseEN.IdTeachingPlan = objRow[conCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCourseLearningCaseEN.IdDiscipline = objRow[conCourseLearningCase.IdDiscipline] == DBNull.Value ? null : objRow[conCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objCourseLearningCaseEN.BrowseCount = objRow[conCourseLearningCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.BrowseCount].ToString().Trim()); //浏览次数
objCourseLearningCaseEN.IdSenateGaugeVersion = objRow[conCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCourseLearningCaseEN.IdTeachSkill = objRow[conCourseLearningCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCourseLearningCaseEN.CaseLevelId = objRow[conCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[conCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCourseLearningCaseEN.DocFile = objRow[conCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[conCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objCourseLearningCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCourseLearningCaseEN.WordCreateDate = objRow[conCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[conCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCourseLearningCaseEN.IsVisible = TransNullToBool(objRow[conCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objCourseLearningCaseEN.IsDualVideo = TransNullToBool(objRow[conCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objCourseLearningCaseEN.IdXzCollege = objRow[conCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objCourseLearningCaseEN.IdXzMajor = objRow[conCourseLearningCase.IdXzMajor] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objCourseLearningCaseEN.CourseId = objRow[conCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objCourseLearningCaseEN.TeachingSolutionId = objRow[conCourseLearningCase.TeachingSolutionId] == DBNull.Value ? null : objRow[conCourseLearningCase.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCourseLearningCaseEN.CourseChapterId = objRow[conCourseLearningCase.CourseChapterId] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCourseLearningCaseEN.ViewCount = objRow[conCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objCourseLearningCaseEN.IsShow = TransNullToBool(objRow[conCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objCourseLearningCaseEN.DownloadNumber = objRow[conCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objCourseLearningCaseEN.FileIntegration = objRow[conCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objCourseLearningCaseEN.LikeCount = objRow[conCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCourseLearningCaseEN.CollectionCount = objRow[conCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objCourseLearningCaseEN.RecommendedDegreeId = objRow[conCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCourseLearningCaseEN.ftpFileType = objRow[conCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[conCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCourseLearningCaseEN.VideoUrl = objRow[conCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objCourseLearningCaseEN.VideoPath = objRow[conCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objCourseLearningCaseEN.ImageUrl = objRow[conCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objCourseLearningCaseEN.ResErrMsg = objRow[conCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[conCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCourseLearningCaseEN.OrderNum = objRow[conCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCourseLearningCase.OrderNum].ToString().Trim()); //序号
objCourseLearningCaseEN.UpdDate = objRow[conCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objCourseLearningCaseEN.UpdUserId = objRow[conCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objCourseLearningCaseEN.Memo = objRow[conCourseLearningCase.Memo] == DBNull.Value ? null : objRow[conCourseLearningCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCourseLearningCaseDA: GetObjByDataRow)", objException.Message));
}
objCourseLearningCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCourseLearningCaseEN;
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
objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCourseLearningCaseEN._CurrTabName, conCourseLearningCase.IdCourseLearningCase, 8, "");
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
objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCourseLearningCaseEN._CurrTabName, conCourseLearningCase.IdCourseLearningCase, 8, strPrefix);
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
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCourseLearningCase from CourseLearningCase where " + strCondition;
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
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCourseLearningCase from CourseLearningCase where " + strCondition;
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
 /// <param name = "strIdCourseLearningCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdCourseLearningCase)
{
CheckPrimaryKey(strIdCourseLearningCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CourseLearningCase", "IdCourseLearningCase = " + "'"+ strIdCourseLearningCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCourseLearningCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CourseLearningCase", strCondition))
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
objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CourseLearningCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCourseLearningCaseEN objCourseLearningCaseEN)
 {
 objCourseLearningCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCourseLearningCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCourseLearningCaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
strSQL = "Select * from CourseLearningCase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CourseLearningCase");
objRow = objDS.Tables["CourseLearningCase"].NewRow();
objRow[conCourseLearningCase.IdCourseLearningCase] = objCourseLearningCaseEN.IdCourseLearningCase; //课程学习案例流水号
objRow[conCourseLearningCase.CourseLearningCaseID] = objCourseLearningCaseEN.CourseLearningCaseID; //课程学习案例ID
objRow[conCourseLearningCase.CourseLearningCaseName] = objCourseLearningCaseEN.CourseLearningCaseName; //课程学习案例名称
 if (objCourseLearningCaseEN.CourseLearningCaseText !=  "")
 {
objRow[conCourseLearningCase.CourseLearningCaseText] = objCourseLearningCaseEN.CourseLearningCaseText; //案例文本内容
 }
 if (objCourseLearningCaseEN.CourseLearningCaseTheme !=  "")
 {
objRow[conCourseLearningCase.CourseLearningCaseTheme] = objCourseLearningCaseEN.CourseLearningCaseTheme; //课程学习案例主题词
 }
 if (objCourseLearningCaseEN.CourseLearningCaseDate !=  "")
 {
objRow[conCourseLearningCase.CourseLearningCaseDate] = objCourseLearningCaseEN.CourseLearningCaseDate; //课程学习日期
 }
 if (objCourseLearningCaseEN.CourseLearningCaseTime !=  "")
 {
objRow[conCourseLearningCase.CourseLearningCaseTime] = objCourseLearningCaseEN.CourseLearningCaseTime; //课程学习时间
 }
 if (objCourseLearningCaseEN.CourseLearningCaseDateIn !=  "")
 {
objRow[conCourseLearningCase.CourseLearningCaseDateIn] = objCourseLearningCaseEN.CourseLearningCaseDateIn; //案例入库日期
 }
 if (objCourseLearningCaseEN.CourseLearningCaseTimeIn !=  "")
 {
objRow[conCourseLearningCase.CourseLearningCaseTimeIn] = objCourseLearningCaseEN.CourseLearningCaseTimeIn; //案例入库时间
 }
 if (objCourseLearningCaseEN.IdCaseType !=  "")
 {
objRow[conCourseLearningCase.IdCaseType] = objCourseLearningCaseEN.IdCaseType; //案例类型流水号
 }
objRow[conCourseLearningCase.IdCourseLearningCaseType] = objCourseLearningCaseEN.IdCourseLearningCaseType; //课程学习案例类型流水号
objRow[conCourseLearningCase.OwnerId] = objCourseLearningCaseEN.OwnerId; //拥有者Id
 if (objCourseLearningCaseEN.IdStudyLevel !=  "")
 {
objRow[conCourseLearningCase.IdStudyLevel] = objCourseLearningCaseEN.IdStudyLevel; //学段流水号
 }
 if (objCourseLearningCaseEN.IdTeachingPlan !=  "")
 {
objRow[conCourseLearningCase.IdTeachingPlan] = objCourseLearningCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objCourseLearningCaseEN.IdDiscipline !=  "")
 {
objRow[conCourseLearningCase.IdDiscipline] = objCourseLearningCaseEN.IdDiscipline; //学科流水号
 }
objRow[conCourseLearningCase.BrowseCount] = objCourseLearningCaseEN.BrowseCount; //浏览次数
 if (objCourseLearningCaseEN.IdSenateGaugeVersion !=  "")
 {
objRow[conCourseLearningCase.IdSenateGaugeVersion] = objCourseLearningCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objCourseLearningCaseEN.IdTeachSkill !=  "")
 {
objRow[conCourseLearningCase.IdTeachSkill] = objCourseLearningCaseEN.IdTeachSkill; //教学技能流水号
 }
 if (objCourseLearningCaseEN.CaseLevelId !=  "")
 {
objRow[conCourseLearningCase.CaseLevelId] = objCourseLearningCaseEN.CaseLevelId; //课例等级Id
 }
 if (objCourseLearningCaseEN.DocFile !=  "")
 {
objRow[conCourseLearningCase.DocFile] = objCourseLearningCaseEN.DocFile; //生成的Word文件名
 }
objRow[conCourseLearningCase.IsNeedGeneWord] = objCourseLearningCaseEN.IsNeedGeneWord; //是否需要生成Word
 if (objCourseLearningCaseEN.WordCreateDate !=  "")
 {
objRow[conCourseLearningCase.WordCreateDate] = objCourseLearningCaseEN.WordCreateDate; //Word生成日期
 }
objRow[conCourseLearningCase.IsVisible] = objCourseLearningCaseEN.IsVisible; //是否显示
objRow[conCourseLearningCase.IsDualVideo] = objCourseLearningCaseEN.IsDualVideo; //是否双视频
 if (objCourseLearningCaseEN.IdXzCollege !=  "")
 {
objRow[conCourseLearningCase.IdXzCollege] = objCourseLearningCaseEN.IdXzCollege; //学院流水号
 }
 if (objCourseLearningCaseEN.IdXzMajor !=  "")
 {
objRow[conCourseLearningCase.IdXzMajor] = objCourseLearningCaseEN.IdXzMajor; //专业流水号
 }
objRow[conCourseLearningCase.CourseId] = objCourseLearningCaseEN.CourseId; //课程Id
 if (objCourseLearningCaseEN.TeachingSolutionId !=  "")
 {
objRow[conCourseLearningCase.TeachingSolutionId] = objCourseLearningCaseEN.TeachingSolutionId; //教学方案Id
 }
 if (objCourseLearningCaseEN.CourseChapterId !=  "")
 {
objRow[conCourseLearningCase.CourseChapterId] = objCourseLearningCaseEN.CourseChapterId; //课程章节ID
 }
objRow[conCourseLearningCase.ViewCount] = objCourseLearningCaseEN.ViewCount; //浏览量
objRow[conCourseLearningCase.IsShow] = objCourseLearningCaseEN.IsShow; //是否启用
objRow[conCourseLearningCase.DownloadNumber] = objCourseLearningCaseEN.DownloadNumber; //下载数目
objRow[conCourseLearningCase.FileIntegration] = objCourseLearningCaseEN.FileIntegration; //文件积分
objRow[conCourseLearningCase.LikeCount] = objCourseLearningCaseEN.LikeCount; //资源喜欢数量
objRow[conCourseLearningCase.CollectionCount] = objCourseLearningCaseEN.CollectionCount; //收藏数量
objRow[conCourseLearningCase.RecommendedDegreeId] = objCourseLearningCaseEN.RecommendedDegreeId; //推荐度Id
 if (objCourseLearningCaseEN.ftpFileType !=  "")
 {
objRow[conCourseLearningCase.ftpFileType] = objCourseLearningCaseEN.ftpFileType; //ftp文件类型
 }
 if (objCourseLearningCaseEN.VideoUrl !=  "")
 {
objRow[conCourseLearningCase.VideoUrl] = objCourseLearningCaseEN.VideoUrl; //视频Url
 }
 if (objCourseLearningCaseEN.VideoPath !=  "")
 {
objRow[conCourseLearningCase.VideoPath] = objCourseLearningCaseEN.VideoPath; //视频目录
 }
 if (objCourseLearningCaseEN.ImageUrl !=  "")
 {
objRow[conCourseLearningCase.ImageUrl] = objCourseLearningCaseEN.ImageUrl; //ImageUrl
 }
 if (objCourseLearningCaseEN.ResErrMsg !=  "")
 {
objRow[conCourseLearningCase.ResErrMsg] = objCourseLearningCaseEN.ResErrMsg; //资源错误信息
 }
objRow[conCourseLearningCase.OrderNum] = objCourseLearningCaseEN.OrderNum; //序号
 if (objCourseLearningCaseEN.UpdDate !=  "")
 {
objRow[conCourseLearningCase.UpdDate] = objCourseLearningCaseEN.UpdDate; //修改日期
 }
 if (objCourseLearningCaseEN.UpdUserId !=  "")
 {
objRow[conCourseLearningCase.UpdUserId] = objCourseLearningCaseEN.UpdUserId; //修改用户Id
 }
 if (objCourseLearningCaseEN.Memo !=  "")
 {
objRow[conCourseLearningCase.Memo] = objCourseLearningCaseEN.Memo; //备注
 }
objDS.Tables[clsCourseLearningCaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCourseLearningCaseEN._CurrTabName);
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
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
 objCourseLearningCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCourseLearningCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCourseLearningCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCourseLearningCaseEN.IdCourseLearningCase !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdCourseLearningCase);
 var strIdCourseLearningCase = objCourseLearningCaseEN.IdCourseLearningCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseLearningCase + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseID !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseID);
 var strCourseLearningCaseID = objCourseLearningCaseEN.CourseLearningCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseID + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseName !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseName);
 var strCourseLearningCaseName = objCourseLearningCaseEN.CourseLearningCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseName + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseText !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseText);
 var strCourseLearningCaseText = objCourseLearningCaseEN.CourseLearningCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseText + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseTheme);
 var strCourseLearningCaseTheme = objCourseLearningCaseEN.CourseLearningCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseTheme + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseDate);
 var strCourseLearningCaseDate = objCourseLearningCaseEN.CourseLearningCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseDate + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseTime);
 var strCourseLearningCaseTime = objCourseLearningCaseEN.CourseLearningCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseTime + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseDateIn);
 var strCourseLearningCaseDateIn = objCourseLearningCaseEN.CourseLearningCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseDateIn + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseTimeIn);
 var strCourseLearningCaseTimeIn = objCourseLearningCaseEN.CourseLearningCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseTimeIn + "'");
 }
 
 if (objCourseLearningCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdCaseType);
 var strIdCaseType = objCourseLearningCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objCourseLearningCaseEN.IdCourseLearningCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdCourseLearningCaseType);
 var strIdCourseLearningCaseType = objCourseLearningCaseEN.IdCourseLearningCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseLearningCaseType + "'");
 }
 
 if (objCourseLearningCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.OwnerId);
 var strOwnerId = objCourseLearningCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCourseLearningCaseEN.IdStudyLevel  ==  "")
 {
 objCourseLearningCaseEN.IdStudyLevel = null;
 }
 if (objCourseLearningCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdStudyLevel);
 var strIdStudyLevel = objCourseLearningCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objCourseLearningCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdTeachingPlan);
 var strIdTeachingPlan = objCourseLearningCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objCourseLearningCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdDiscipline);
 var strIdDiscipline = objCourseLearningCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objCourseLearningCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.BrowseCount);
 arrValueListForInsert.Add(objCourseLearningCaseEN.BrowseCount.ToString());
 }
 
 if (objCourseLearningCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCourseLearningCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCourseLearningCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objCourseLearningCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objCourseLearningCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdTeachSkill);
 var strIdTeachSkill = objCourseLearningCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objCourseLearningCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CaseLevelId);
 var strCaseLevelId = objCourseLearningCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objCourseLearningCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.DocFile);
 var strDocFile = objCourseLearningCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conCourseLearningCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objCourseLearningCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objCourseLearningCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.WordCreateDate);
 var strWordCreateDate = objCourseLearningCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conCourseLearningCase.IsVisible);
 arrValueListForInsert.Add("'" + (objCourseLearningCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCourseLearningCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objCourseLearningCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objCourseLearningCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdXzCollege);
 var strIdXzCollege = objCourseLearningCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCourseLearningCaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdXzMajor);
 var strIdXzMajor = objCourseLearningCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objCourseLearningCaseEN.CourseId  ==  "")
 {
 objCourseLearningCaseEN.CourseId = null;
 }
 if (objCourseLearningCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseId);
 var strCourseId = objCourseLearningCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCourseLearningCaseEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.TeachingSolutionId);
 var strTeachingSolutionId = objCourseLearningCaseEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objCourseLearningCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseChapterId);
 var strCourseChapterId = objCourseLearningCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objCourseLearningCaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.ViewCount);
 arrValueListForInsert.Add(objCourseLearningCaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conCourseLearningCase.IsShow);
 arrValueListForInsert.Add("'" + (objCourseLearningCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objCourseLearningCaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.DownloadNumber);
 arrValueListForInsert.Add(objCourseLearningCaseEN.DownloadNumber.ToString());
 }
 
 if (objCourseLearningCaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.FileIntegration);
 arrValueListForInsert.Add(objCourseLearningCaseEN.FileIntegration.ToString());
 }
 
 if (objCourseLearningCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.LikeCount);
 arrValueListForInsert.Add(objCourseLearningCaseEN.LikeCount.ToString());
 }
 
 if (objCourseLearningCaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CollectionCount);
 arrValueListForInsert.Add(objCourseLearningCaseEN.CollectionCount.ToString());
 }
 
 if (objCourseLearningCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objCourseLearningCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objCourseLearningCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.ftpFileType);
 var strftpFileType = objCourseLearningCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objCourseLearningCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.VideoUrl);
 var strVideoUrl = objCourseLearningCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objCourseLearningCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.VideoPath);
 var strVideoPath = objCourseLearningCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objCourseLearningCaseEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.ImageUrl);
 var strImageUrl = objCourseLearningCaseEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 if (objCourseLearningCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.ResErrMsg);
 var strResErrMsg = objCourseLearningCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objCourseLearningCaseEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.OrderNum);
 arrValueListForInsert.Add(objCourseLearningCaseEN.OrderNum.ToString());
 }
 
 if (objCourseLearningCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.UpdDate);
 var strUpdDate = objCourseLearningCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCourseLearningCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.UpdUserId);
 var strUpdUserId = objCourseLearningCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCourseLearningCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.Memo);
 var strMemo = objCourseLearningCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CourseLearningCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
 objCourseLearningCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCourseLearningCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCourseLearningCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCourseLearningCaseEN.IdCourseLearningCase !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdCourseLearningCase);
 var strIdCourseLearningCase = objCourseLearningCaseEN.IdCourseLearningCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseLearningCase + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseID !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseID);
 var strCourseLearningCaseID = objCourseLearningCaseEN.CourseLearningCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseID + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseName !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseName);
 var strCourseLearningCaseName = objCourseLearningCaseEN.CourseLearningCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseName + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseText !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseText);
 var strCourseLearningCaseText = objCourseLearningCaseEN.CourseLearningCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseText + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseTheme);
 var strCourseLearningCaseTheme = objCourseLearningCaseEN.CourseLearningCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseTheme + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseDate);
 var strCourseLearningCaseDate = objCourseLearningCaseEN.CourseLearningCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseDate + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseTime);
 var strCourseLearningCaseTime = objCourseLearningCaseEN.CourseLearningCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseTime + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseDateIn);
 var strCourseLearningCaseDateIn = objCourseLearningCaseEN.CourseLearningCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseDateIn + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseTimeIn);
 var strCourseLearningCaseTimeIn = objCourseLearningCaseEN.CourseLearningCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseTimeIn + "'");
 }
 
 if (objCourseLearningCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdCaseType);
 var strIdCaseType = objCourseLearningCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objCourseLearningCaseEN.IdCourseLearningCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdCourseLearningCaseType);
 var strIdCourseLearningCaseType = objCourseLearningCaseEN.IdCourseLearningCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseLearningCaseType + "'");
 }
 
 if (objCourseLearningCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.OwnerId);
 var strOwnerId = objCourseLearningCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCourseLearningCaseEN.IdStudyLevel  ==  "")
 {
 objCourseLearningCaseEN.IdStudyLevel = null;
 }
 if (objCourseLearningCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdStudyLevel);
 var strIdStudyLevel = objCourseLearningCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objCourseLearningCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdTeachingPlan);
 var strIdTeachingPlan = objCourseLearningCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objCourseLearningCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdDiscipline);
 var strIdDiscipline = objCourseLearningCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objCourseLearningCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.BrowseCount);
 arrValueListForInsert.Add(objCourseLearningCaseEN.BrowseCount.ToString());
 }
 
 if (objCourseLearningCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCourseLearningCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCourseLearningCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objCourseLearningCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objCourseLearningCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdTeachSkill);
 var strIdTeachSkill = objCourseLearningCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objCourseLearningCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CaseLevelId);
 var strCaseLevelId = objCourseLearningCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objCourseLearningCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.DocFile);
 var strDocFile = objCourseLearningCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conCourseLearningCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objCourseLearningCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objCourseLearningCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.WordCreateDate);
 var strWordCreateDate = objCourseLearningCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conCourseLearningCase.IsVisible);
 arrValueListForInsert.Add("'" + (objCourseLearningCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCourseLearningCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objCourseLearningCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objCourseLearningCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdXzCollege);
 var strIdXzCollege = objCourseLearningCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCourseLearningCaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdXzMajor);
 var strIdXzMajor = objCourseLearningCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objCourseLearningCaseEN.CourseId  ==  "")
 {
 objCourseLearningCaseEN.CourseId = null;
 }
 if (objCourseLearningCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseId);
 var strCourseId = objCourseLearningCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCourseLearningCaseEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.TeachingSolutionId);
 var strTeachingSolutionId = objCourseLearningCaseEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objCourseLearningCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseChapterId);
 var strCourseChapterId = objCourseLearningCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objCourseLearningCaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.ViewCount);
 arrValueListForInsert.Add(objCourseLearningCaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conCourseLearningCase.IsShow);
 arrValueListForInsert.Add("'" + (objCourseLearningCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objCourseLearningCaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.DownloadNumber);
 arrValueListForInsert.Add(objCourseLearningCaseEN.DownloadNumber.ToString());
 }
 
 if (objCourseLearningCaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.FileIntegration);
 arrValueListForInsert.Add(objCourseLearningCaseEN.FileIntegration.ToString());
 }
 
 if (objCourseLearningCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.LikeCount);
 arrValueListForInsert.Add(objCourseLearningCaseEN.LikeCount.ToString());
 }
 
 if (objCourseLearningCaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CollectionCount);
 arrValueListForInsert.Add(objCourseLearningCaseEN.CollectionCount.ToString());
 }
 
 if (objCourseLearningCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objCourseLearningCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objCourseLearningCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.ftpFileType);
 var strftpFileType = objCourseLearningCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objCourseLearningCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.VideoUrl);
 var strVideoUrl = objCourseLearningCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objCourseLearningCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.VideoPath);
 var strVideoPath = objCourseLearningCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objCourseLearningCaseEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.ImageUrl);
 var strImageUrl = objCourseLearningCaseEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 if (objCourseLearningCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.ResErrMsg);
 var strResErrMsg = objCourseLearningCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objCourseLearningCaseEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.OrderNum);
 arrValueListForInsert.Add(objCourseLearningCaseEN.OrderNum.ToString());
 }
 
 if (objCourseLearningCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.UpdDate);
 var strUpdDate = objCourseLearningCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCourseLearningCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.UpdUserId);
 var strUpdUserId = objCourseLearningCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCourseLearningCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.Memo);
 var strMemo = objCourseLearningCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CourseLearningCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCourseLearningCaseEN.IdCourseLearningCase;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCourseLearningCaseEN objCourseLearningCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCourseLearningCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCourseLearningCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCourseLearningCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCourseLearningCaseEN.IdCourseLearningCase !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdCourseLearningCase);
 var strIdCourseLearningCase = objCourseLearningCaseEN.IdCourseLearningCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseLearningCase + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseID !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseID);
 var strCourseLearningCaseID = objCourseLearningCaseEN.CourseLearningCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseID + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseName !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseName);
 var strCourseLearningCaseName = objCourseLearningCaseEN.CourseLearningCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseName + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseText !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseText);
 var strCourseLearningCaseText = objCourseLearningCaseEN.CourseLearningCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseText + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseTheme);
 var strCourseLearningCaseTheme = objCourseLearningCaseEN.CourseLearningCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseTheme + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseDate);
 var strCourseLearningCaseDate = objCourseLearningCaseEN.CourseLearningCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseDate + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseTime);
 var strCourseLearningCaseTime = objCourseLearningCaseEN.CourseLearningCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseTime + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseDateIn);
 var strCourseLearningCaseDateIn = objCourseLearningCaseEN.CourseLearningCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseDateIn + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseTimeIn);
 var strCourseLearningCaseTimeIn = objCourseLearningCaseEN.CourseLearningCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseTimeIn + "'");
 }
 
 if (objCourseLearningCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdCaseType);
 var strIdCaseType = objCourseLearningCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objCourseLearningCaseEN.IdCourseLearningCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdCourseLearningCaseType);
 var strIdCourseLearningCaseType = objCourseLearningCaseEN.IdCourseLearningCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseLearningCaseType + "'");
 }
 
 if (objCourseLearningCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.OwnerId);
 var strOwnerId = objCourseLearningCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCourseLearningCaseEN.IdStudyLevel  ==  "")
 {
 objCourseLearningCaseEN.IdStudyLevel = null;
 }
 if (objCourseLearningCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdStudyLevel);
 var strIdStudyLevel = objCourseLearningCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objCourseLearningCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdTeachingPlan);
 var strIdTeachingPlan = objCourseLearningCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objCourseLearningCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdDiscipline);
 var strIdDiscipline = objCourseLearningCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objCourseLearningCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.BrowseCount);
 arrValueListForInsert.Add(objCourseLearningCaseEN.BrowseCount.ToString());
 }
 
 if (objCourseLearningCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCourseLearningCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCourseLearningCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objCourseLearningCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objCourseLearningCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdTeachSkill);
 var strIdTeachSkill = objCourseLearningCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objCourseLearningCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CaseLevelId);
 var strCaseLevelId = objCourseLearningCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objCourseLearningCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.DocFile);
 var strDocFile = objCourseLearningCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conCourseLearningCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objCourseLearningCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objCourseLearningCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.WordCreateDate);
 var strWordCreateDate = objCourseLearningCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conCourseLearningCase.IsVisible);
 arrValueListForInsert.Add("'" + (objCourseLearningCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCourseLearningCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objCourseLearningCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objCourseLearningCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdXzCollege);
 var strIdXzCollege = objCourseLearningCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCourseLearningCaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdXzMajor);
 var strIdXzMajor = objCourseLearningCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objCourseLearningCaseEN.CourseId  ==  "")
 {
 objCourseLearningCaseEN.CourseId = null;
 }
 if (objCourseLearningCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseId);
 var strCourseId = objCourseLearningCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCourseLearningCaseEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.TeachingSolutionId);
 var strTeachingSolutionId = objCourseLearningCaseEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objCourseLearningCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseChapterId);
 var strCourseChapterId = objCourseLearningCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objCourseLearningCaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.ViewCount);
 arrValueListForInsert.Add(objCourseLearningCaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conCourseLearningCase.IsShow);
 arrValueListForInsert.Add("'" + (objCourseLearningCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objCourseLearningCaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.DownloadNumber);
 arrValueListForInsert.Add(objCourseLearningCaseEN.DownloadNumber.ToString());
 }
 
 if (objCourseLearningCaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.FileIntegration);
 arrValueListForInsert.Add(objCourseLearningCaseEN.FileIntegration.ToString());
 }
 
 if (objCourseLearningCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.LikeCount);
 arrValueListForInsert.Add(objCourseLearningCaseEN.LikeCount.ToString());
 }
 
 if (objCourseLearningCaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CollectionCount);
 arrValueListForInsert.Add(objCourseLearningCaseEN.CollectionCount.ToString());
 }
 
 if (objCourseLearningCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objCourseLearningCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objCourseLearningCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.ftpFileType);
 var strftpFileType = objCourseLearningCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objCourseLearningCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.VideoUrl);
 var strVideoUrl = objCourseLearningCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objCourseLearningCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.VideoPath);
 var strVideoPath = objCourseLearningCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objCourseLearningCaseEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.ImageUrl);
 var strImageUrl = objCourseLearningCaseEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 if (objCourseLearningCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.ResErrMsg);
 var strResErrMsg = objCourseLearningCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objCourseLearningCaseEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.OrderNum);
 arrValueListForInsert.Add(objCourseLearningCaseEN.OrderNum.ToString());
 }
 
 if (objCourseLearningCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.UpdDate);
 var strUpdDate = objCourseLearningCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCourseLearningCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.UpdUserId);
 var strUpdUserId = objCourseLearningCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCourseLearningCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.Memo);
 var strMemo = objCourseLearningCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CourseLearningCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCourseLearningCaseEN.IdCourseLearningCase;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCourseLearningCaseEN objCourseLearningCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCourseLearningCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCourseLearningCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCourseLearningCaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCourseLearningCaseEN.IdCourseLearningCase !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdCourseLearningCase);
 var strIdCourseLearningCase = objCourseLearningCaseEN.IdCourseLearningCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseLearningCase + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseID !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseID);
 var strCourseLearningCaseID = objCourseLearningCaseEN.CourseLearningCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseID + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseName !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseName);
 var strCourseLearningCaseName = objCourseLearningCaseEN.CourseLearningCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseName + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseText !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseText);
 var strCourseLearningCaseText = objCourseLearningCaseEN.CourseLearningCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseText + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseTheme);
 var strCourseLearningCaseTheme = objCourseLearningCaseEN.CourseLearningCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseTheme + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseDate);
 var strCourseLearningCaseDate = objCourseLearningCaseEN.CourseLearningCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseDate + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseTime);
 var strCourseLearningCaseTime = objCourseLearningCaseEN.CourseLearningCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseTime + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseDateIn);
 var strCourseLearningCaseDateIn = objCourseLearningCaseEN.CourseLearningCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseDateIn + "'");
 }
 
 if (objCourseLearningCaseEN.CourseLearningCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseLearningCaseTimeIn);
 var strCourseLearningCaseTimeIn = objCourseLearningCaseEN.CourseLearningCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseLearningCaseTimeIn + "'");
 }
 
 if (objCourseLearningCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdCaseType);
 var strIdCaseType = objCourseLearningCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objCourseLearningCaseEN.IdCourseLearningCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdCourseLearningCaseType);
 var strIdCourseLearningCaseType = objCourseLearningCaseEN.IdCourseLearningCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseLearningCaseType + "'");
 }
 
 if (objCourseLearningCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.OwnerId);
 var strOwnerId = objCourseLearningCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCourseLearningCaseEN.IdStudyLevel  ==  "")
 {
 objCourseLearningCaseEN.IdStudyLevel = null;
 }
 if (objCourseLearningCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdStudyLevel);
 var strIdStudyLevel = objCourseLearningCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objCourseLearningCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdTeachingPlan);
 var strIdTeachingPlan = objCourseLearningCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objCourseLearningCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdDiscipline);
 var strIdDiscipline = objCourseLearningCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objCourseLearningCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.BrowseCount);
 arrValueListForInsert.Add(objCourseLearningCaseEN.BrowseCount.ToString());
 }
 
 if (objCourseLearningCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCourseLearningCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCourseLearningCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objCourseLearningCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objCourseLearningCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdTeachSkill);
 var strIdTeachSkill = objCourseLearningCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objCourseLearningCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CaseLevelId);
 var strCaseLevelId = objCourseLearningCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objCourseLearningCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.DocFile);
 var strDocFile = objCourseLearningCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conCourseLearningCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objCourseLearningCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objCourseLearningCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.WordCreateDate);
 var strWordCreateDate = objCourseLearningCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conCourseLearningCase.IsVisible);
 arrValueListForInsert.Add("'" + (objCourseLearningCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCourseLearningCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objCourseLearningCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objCourseLearningCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdXzCollege);
 var strIdXzCollege = objCourseLearningCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCourseLearningCaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.IdXzMajor);
 var strIdXzMajor = objCourseLearningCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objCourseLearningCaseEN.CourseId  ==  "")
 {
 objCourseLearningCaseEN.CourseId = null;
 }
 if (objCourseLearningCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseId);
 var strCourseId = objCourseLearningCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCourseLearningCaseEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.TeachingSolutionId);
 var strTeachingSolutionId = objCourseLearningCaseEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objCourseLearningCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CourseChapterId);
 var strCourseChapterId = objCourseLearningCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objCourseLearningCaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.ViewCount);
 arrValueListForInsert.Add(objCourseLearningCaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conCourseLearningCase.IsShow);
 arrValueListForInsert.Add("'" + (objCourseLearningCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objCourseLearningCaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.DownloadNumber);
 arrValueListForInsert.Add(objCourseLearningCaseEN.DownloadNumber.ToString());
 }
 
 if (objCourseLearningCaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.FileIntegration);
 arrValueListForInsert.Add(objCourseLearningCaseEN.FileIntegration.ToString());
 }
 
 if (objCourseLearningCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.LikeCount);
 arrValueListForInsert.Add(objCourseLearningCaseEN.LikeCount.ToString());
 }
 
 if (objCourseLearningCaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.CollectionCount);
 arrValueListForInsert.Add(objCourseLearningCaseEN.CollectionCount.ToString());
 }
 
 if (objCourseLearningCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objCourseLearningCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objCourseLearningCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.ftpFileType);
 var strftpFileType = objCourseLearningCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objCourseLearningCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.VideoUrl);
 var strVideoUrl = objCourseLearningCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objCourseLearningCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.VideoPath);
 var strVideoPath = objCourseLearningCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objCourseLearningCaseEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.ImageUrl);
 var strImageUrl = objCourseLearningCaseEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 if (objCourseLearningCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.ResErrMsg);
 var strResErrMsg = objCourseLearningCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objCourseLearningCaseEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.OrderNum);
 arrValueListForInsert.Add(objCourseLearningCaseEN.OrderNum.ToString());
 }
 
 if (objCourseLearningCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.UpdDate);
 var strUpdDate = objCourseLearningCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCourseLearningCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.UpdUserId);
 var strUpdUserId = objCourseLearningCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCourseLearningCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCourseLearningCase.Memo);
 var strMemo = objCourseLearningCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CourseLearningCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCourseLearningCases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
strSQL = "Select * from CourseLearningCase where IdCourseLearningCase = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CourseLearningCase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdCourseLearningCase = oRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim();
if (IsExist(strIdCourseLearningCase))
{
 string strResult = "关键字变量值为:" + string.Format("IdCourseLearningCase = {0}", strIdCourseLearningCase) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCourseLearningCaseEN._CurrTabName ].NewRow();
objRow[conCourseLearningCase.IdCourseLearningCase] = oRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objRow[conCourseLearningCase.CourseLearningCaseID] = oRow[conCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objRow[conCourseLearningCase.CourseLearningCaseName] = oRow[conCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objRow[conCourseLearningCase.CourseLearningCaseText] = oRow[conCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objRow[conCourseLearningCase.CourseLearningCaseTheme] = oRow[conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objRow[conCourseLearningCase.CourseLearningCaseDate] = oRow[conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objRow[conCourseLearningCase.CourseLearningCaseTime] = oRow[conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objRow[conCourseLearningCase.CourseLearningCaseDateIn] = oRow[conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objRow[conCourseLearningCase.CourseLearningCaseTimeIn] = oRow[conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objRow[conCourseLearningCase.IdCaseType] = oRow[conCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objRow[conCourseLearningCase.IdCourseLearningCaseType] = oRow[conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objRow[conCourseLearningCase.OwnerId] = oRow[conCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objRow[conCourseLearningCase.IdStudyLevel] = oRow[conCourseLearningCase.IdStudyLevel].ToString().Trim(); //学段流水号
objRow[conCourseLearningCase.IdTeachingPlan] = oRow[conCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objRow[conCourseLearningCase.IdDiscipline] = oRow[conCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objRow[conCourseLearningCase.BrowseCount] = oRow[conCourseLearningCase.BrowseCount].ToString().Trim(); //浏览次数
objRow[conCourseLearningCase.IdSenateGaugeVersion] = oRow[conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objRow[conCourseLearningCase.IdTeachSkill] = oRow[conCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objRow[conCourseLearningCase.CaseLevelId] = oRow[conCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objRow[conCourseLearningCase.DocFile] = oRow[conCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objRow[conCourseLearningCase.IsNeedGeneWord] = oRow[conCourseLearningCase.IsNeedGeneWord].ToString().Trim(); //是否需要生成Word
objRow[conCourseLearningCase.WordCreateDate] = oRow[conCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objRow[conCourseLearningCase.IsVisible] = oRow[conCourseLearningCase.IsVisible].ToString().Trim(); //是否显示
objRow[conCourseLearningCase.IsDualVideo] = oRow[conCourseLearningCase.IsDualVideo].ToString().Trim(); //是否双视频
objRow[conCourseLearningCase.IdXzCollege] = oRow[conCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objRow[conCourseLearningCase.IdXzMajor] = oRow[conCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objRow[conCourseLearningCase.CourseId] = oRow[conCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objRow[conCourseLearningCase.TeachingSolutionId] = oRow[conCourseLearningCase.TeachingSolutionId].ToString().Trim(); //教学方案Id
objRow[conCourseLearningCase.CourseChapterId] = oRow[conCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objRow[conCourseLearningCase.ViewCount] = oRow[conCourseLearningCase.ViewCount].ToString().Trim(); //浏览量
objRow[conCourseLearningCase.IsShow] = oRow[conCourseLearningCase.IsShow].ToString().Trim(); //是否启用
objRow[conCourseLearningCase.DownloadNumber] = oRow[conCourseLearningCase.DownloadNumber].ToString().Trim(); //下载数目
objRow[conCourseLearningCase.FileIntegration] = oRow[conCourseLearningCase.FileIntegration].ToString().Trim(); //文件积分
objRow[conCourseLearningCase.LikeCount] = oRow[conCourseLearningCase.LikeCount].ToString().Trim(); //资源喜欢数量
objRow[conCourseLearningCase.CollectionCount] = oRow[conCourseLearningCase.CollectionCount].ToString().Trim(); //收藏数量
objRow[conCourseLearningCase.RecommendedDegreeId] = oRow[conCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objRow[conCourseLearningCase.ftpFileType] = oRow[conCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objRow[conCourseLearningCase.VideoUrl] = oRow[conCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objRow[conCourseLearningCase.VideoPath] = oRow[conCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objRow[conCourseLearningCase.ImageUrl] = oRow[conCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objRow[conCourseLearningCase.ResErrMsg] = oRow[conCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objRow[conCourseLearningCase.OrderNum] = oRow[conCourseLearningCase.OrderNum].ToString().Trim(); //序号
objRow[conCourseLearningCase.UpdDate] = oRow[conCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objRow[conCourseLearningCase.UpdUserId] = oRow[conCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conCourseLearningCase.Memo] = oRow[conCourseLearningCase.Memo].ToString().Trim(); //备注
 objDS.Tables[clsCourseLearningCaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCourseLearningCaseEN._CurrTabName);
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
 /// <param name = "objCourseLearningCaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
 objCourseLearningCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCourseLearningCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCourseLearningCaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
strSQL = "Select * from CourseLearningCase where IdCourseLearningCase = " + "'"+ objCourseLearningCaseEN.IdCourseLearningCase+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCourseLearningCaseEN._CurrTabName);
if (objDS.Tables[clsCourseLearningCaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdCourseLearningCase = " + "'"+ objCourseLearningCaseEN.IdCourseLearningCase+"'");
return false;
}
objRow = objDS.Tables[clsCourseLearningCaseEN._CurrTabName].Rows[0];
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdCourseLearningCase))
 {
objRow[conCourseLearningCase.IdCourseLearningCase] = objCourseLearningCaseEN.IdCourseLearningCase; //课程学习案例流水号
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseID))
 {
objRow[conCourseLearningCase.CourseLearningCaseID] = objCourseLearningCaseEN.CourseLearningCaseID; //课程学习案例ID
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseName))
 {
objRow[conCourseLearningCase.CourseLearningCaseName] = objCourseLearningCaseEN.CourseLearningCaseName; //课程学习案例名称
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseText))
 {
objRow[conCourseLearningCase.CourseLearningCaseText] = objCourseLearningCaseEN.CourseLearningCaseText; //案例文本内容
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseTheme))
 {
objRow[conCourseLearningCase.CourseLearningCaseTheme] = objCourseLearningCaseEN.CourseLearningCaseTheme; //课程学习案例主题词
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseDate))
 {
objRow[conCourseLearningCase.CourseLearningCaseDate] = objCourseLearningCaseEN.CourseLearningCaseDate; //课程学习日期
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseTime))
 {
objRow[conCourseLearningCase.CourseLearningCaseTime] = objCourseLearningCaseEN.CourseLearningCaseTime; //课程学习时间
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseDateIn))
 {
objRow[conCourseLearningCase.CourseLearningCaseDateIn] = objCourseLearningCaseEN.CourseLearningCaseDateIn; //案例入库日期
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseTimeIn))
 {
objRow[conCourseLearningCase.CourseLearningCaseTimeIn] = objCourseLearningCaseEN.CourseLearningCaseTimeIn; //案例入库时间
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdCaseType))
 {
objRow[conCourseLearningCase.IdCaseType] = objCourseLearningCaseEN.IdCaseType; //案例类型流水号
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdCourseLearningCaseType))
 {
objRow[conCourseLearningCase.IdCourseLearningCaseType] = objCourseLearningCaseEN.IdCourseLearningCaseType; //课程学习案例类型流水号
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.OwnerId))
 {
objRow[conCourseLearningCase.OwnerId] = objCourseLearningCaseEN.OwnerId; //拥有者Id
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdStudyLevel))
 {
objRow[conCourseLearningCase.IdStudyLevel] = objCourseLearningCaseEN.IdStudyLevel; //学段流水号
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdTeachingPlan))
 {
objRow[conCourseLearningCase.IdTeachingPlan] = objCourseLearningCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdDiscipline))
 {
objRow[conCourseLearningCase.IdDiscipline] = objCourseLearningCaseEN.IdDiscipline; //学科流水号
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.BrowseCount))
 {
objRow[conCourseLearningCase.BrowseCount] = objCourseLearningCaseEN.BrowseCount; //浏览次数
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdSenateGaugeVersion))
 {
objRow[conCourseLearningCase.IdSenateGaugeVersion] = objCourseLearningCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdTeachSkill))
 {
objRow[conCourseLearningCase.IdTeachSkill] = objCourseLearningCaseEN.IdTeachSkill; //教学技能流水号
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CaseLevelId))
 {
objRow[conCourseLearningCase.CaseLevelId] = objCourseLearningCaseEN.CaseLevelId; //课例等级Id
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.DocFile))
 {
objRow[conCourseLearningCase.DocFile] = objCourseLearningCaseEN.DocFile; //生成的Word文件名
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsNeedGeneWord))
 {
objRow[conCourseLearningCase.IsNeedGeneWord] = objCourseLearningCaseEN.IsNeedGeneWord; //是否需要生成Word
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.WordCreateDate))
 {
objRow[conCourseLearningCase.WordCreateDate] = objCourseLearningCaseEN.WordCreateDate; //Word生成日期
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsVisible))
 {
objRow[conCourseLearningCase.IsVisible] = objCourseLearningCaseEN.IsVisible; //是否显示
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsDualVideo))
 {
objRow[conCourseLearningCase.IsDualVideo] = objCourseLearningCaseEN.IsDualVideo; //是否双视频
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdXzCollege))
 {
objRow[conCourseLearningCase.IdXzCollege] = objCourseLearningCaseEN.IdXzCollege; //学院流水号
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdXzMajor))
 {
objRow[conCourseLearningCase.IdXzMajor] = objCourseLearningCaseEN.IdXzMajor; //专业流水号
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseId))
 {
objRow[conCourseLearningCase.CourseId] = objCourseLearningCaseEN.CourseId; //课程Id
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.TeachingSolutionId))
 {
objRow[conCourseLearningCase.TeachingSolutionId] = objCourseLearningCaseEN.TeachingSolutionId; //教学方案Id
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseChapterId))
 {
objRow[conCourseLearningCase.CourseChapterId] = objCourseLearningCaseEN.CourseChapterId; //课程章节ID
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ViewCount))
 {
objRow[conCourseLearningCase.ViewCount] = objCourseLearningCaseEN.ViewCount; //浏览量
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsShow))
 {
objRow[conCourseLearningCase.IsShow] = objCourseLearningCaseEN.IsShow; //是否启用
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.DownloadNumber))
 {
objRow[conCourseLearningCase.DownloadNumber] = objCourseLearningCaseEN.DownloadNumber; //下载数目
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.FileIntegration))
 {
objRow[conCourseLearningCase.FileIntegration] = objCourseLearningCaseEN.FileIntegration; //文件积分
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.LikeCount))
 {
objRow[conCourseLearningCase.LikeCount] = objCourseLearningCaseEN.LikeCount; //资源喜欢数量
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CollectionCount))
 {
objRow[conCourseLearningCase.CollectionCount] = objCourseLearningCaseEN.CollectionCount; //收藏数量
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.RecommendedDegreeId))
 {
objRow[conCourseLearningCase.RecommendedDegreeId] = objCourseLearningCaseEN.RecommendedDegreeId; //推荐度Id
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ftpFileType))
 {
objRow[conCourseLearningCase.ftpFileType] = objCourseLearningCaseEN.ftpFileType; //ftp文件类型
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.VideoUrl))
 {
objRow[conCourseLearningCase.VideoUrl] = objCourseLearningCaseEN.VideoUrl; //视频Url
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.VideoPath))
 {
objRow[conCourseLearningCase.VideoPath] = objCourseLearningCaseEN.VideoPath; //视频目录
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ImageUrl))
 {
objRow[conCourseLearningCase.ImageUrl] = objCourseLearningCaseEN.ImageUrl; //ImageUrl
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ResErrMsg))
 {
objRow[conCourseLearningCase.ResErrMsg] = objCourseLearningCaseEN.ResErrMsg; //资源错误信息
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.OrderNum))
 {
objRow[conCourseLearningCase.OrderNum] = objCourseLearningCaseEN.OrderNum; //序号
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.UpdDate))
 {
objRow[conCourseLearningCase.UpdDate] = objCourseLearningCaseEN.UpdDate; //修改日期
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.UpdUserId))
 {
objRow[conCourseLearningCase.UpdUserId] = objCourseLearningCaseEN.UpdUserId; //修改用户Id
 }
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.Memo))
 {
objRow[conCourseLearningCase.Memo] = objCourseLearningCaseEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsCourseLearningCaseEN._CurrTabName);
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
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
 objCourseLearningCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCourseLearningCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCourseLearningCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CourseLearningCase Set ");
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseID))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseID !=  null)
 {
 var strCourseLearningCaseID = objCourseLearningCaseEN.CourseLearningCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseLearningCaseID, conCourseLearningCase.CourseLearningCaseID); //课程学习案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseLearningCaseID); //课程学习案例ID
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseName))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseName !=  null)
 {
 var strCourseLearningCaseName = objCourseLearningCaseEN.CourseLearningCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseLearningCaseName, conCourseLearningCase.CourseLearningCaseName); //课程学习案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseLearningCaseName); //课程学习案例名称
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseText))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseText !=  null)
 {
 var strCourseLearningCaseText = objCourseLearningCaseEN.CourseLearningCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseLearningCaseText, conCourseLearningCase.CourseLearningCaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseLearningCaseText); //案例文本内容
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseTheme))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseTheme !=  null)
 {
 var strCourseLearningCaseTheme = objCourseLearningCaseEN.CourseLearningCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseLearningCaseTheme, conCourseLearningCase.CourseLearningCaseTheme); //课程学习案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseLearningCaseTheme); //课程学习案例主题词
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseDate))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseDate !=  null)
 {
 var strCourseLearningCaseDate = objCourseLearningCaseEN.CourseLearningCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseLearningCaseDate, conCourseLearningCase.CourseLearningCaseDate); //课程学习日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseLearningCaseDate); //课程学习日期
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseTime))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseTime !=  null)
 {
 var strCourseLearningCaseTime = objCourseLearningCaseEN.CourseLearningCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseLearningCaseTime, conCourseLearningCase.CourseLearningCaseTime); //课程学习时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseLearningCaseTime); //课程学习时间
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseDateIn))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseDateIn !=  null)
 {
 var strCourseLearningCaseDateIn = objCourseLearningCaseEN.CourseLearningCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseLearningCaseDateIn, conCourseLearningCase.CourseLearningCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseLearningCaseDateIn); //案例入库日期
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseTimeIn))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseTimeIn !=  null)
 {
 var strCourseLearningCaseTimeIn = objCourseLearningCaseEN.CourseLearningCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseLearningCaseTimeIn, conCourseLearningCase.CourseLearningCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseLearningCaseTimeIn); //案例入库时间
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdCaseType))
 {
 if (objCourseLearningCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objCourseLearningCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conCourseLearningCase.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdCaseType); //案例类型流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdCourseLearningCaseType))
 {
 if (objCourseLearningCaseEN.IdCourseLearningCaseType !=  null)
 {
 var strIdCourseLearningCaseType = objCourseLearningCaseEN.IdCourseLearningCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCourseLearningCaseType, conCourseLearningCase.IdCourseLearningCaseType); //课程学习案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdCourseLearningCaseType); //课程学习案例类型流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.OwnerId))
 {
 if (objCourseLearningCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objCourseLearningCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conCourseLearningCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.OwnerId); //拥有者Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdStudyLevel))
 {
 if (objCourseLearningCaseEN.IdStudyLevel  ==  "")
 {
 objCourseLearningCaseEN.IdStudyLevel = null;
 }
 if (objCourseLearningCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objCourseLearningCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conCourseLearningCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdTeachingPlan))
 {
 if (objCourseLearningCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objCourseLearningCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conCourseLearningCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdDiscipline))
 {
 if (objCourseLearningCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objCourseLearningCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conCourseLearningCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.BrowseCount))
 {
 if (objCourseLearningCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.BrowseCount, conCourseLearningCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.BrowseCount); //浏览次数
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdSenateGaugeVersion))
 {
 if (objCourseLearningCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCourseLearningCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCourseLearningCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objCourseLearningCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conCourseLearningCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdTeachSkill))
 {
 if (objCourseLearningCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objCourseLearningCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conCourseLearningCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CaseLevelId))
 {
 if (objCourseLearningCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objCourseLearningCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conCourseLearningCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.DocFile))
 {
 if (objCourseLearningCaseEN.DocFile !=  null)
 {
 var strDocFile = objCourseLearningCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conCourseLearningCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCourseLearningCaseEN.IsNeedGeneWord == true?"1":"0", conCourseLearningCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.WordCreateDate))
 {
 if (objCourseLearningCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objCourseLearningCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conCourseLearningCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCourseLearningCaseEN.IsVisible == true?"1":"0", conCourseLearningCase.IsVisible); //是否显示
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCourseLearningCaseEN.IsDualVideo == true?"1":"0", conCourseLearningCase.IsDualVideo); //是否双视频
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdXzCollege))
 {
 if (objCourseLearningCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCourseLearningCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conCourseLearningCase.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdXzCollege); //学院流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdXzMajor))
 {
 if (objCourseLearningCaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objCourseLearningCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conCourseLearningCase.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdXzMajor); //专业流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseId))
 {
 if (objCourseLearningCaseEN.CourseId  ==  "")
 {
 objCourseLearningCaseEN.CourseId = null;
 }
 if (objCourseLearningCaseEN.CourseId !=  null)
 {
 var strCourseId = objCourseLearningCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conCourseLearningCase.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseId); //课程Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.TeachingSolutionId))
 {
 if (objCourseLearningCaseEN.TeachingSolutionId !=  null)
 {
 var strTeachingSolutionId = objCourseLearningCaseEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingSolutionId, conCourseLearningCase.TeachingSolutionId); //教学方案Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.TeachingSolutionId); //教学方案Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseChapterId))
 {
 if (objCourseLearningCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objCourseLearningCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, conCourseLearningCase.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseChapterId); //课程章节ID
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ViewCount))
 {
 if (objCourseLearningCaseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.ViewCount, conCourseLearningCase.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.ViewCount); //浏览量
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCourseLearningCaseEN.IsShow == true?"1":"0", conCourseLearningCase.IsShow); //是否启用
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.DownloadNumber))
 {
 if (objCourseLearningCaseEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.DownloadNumber, conCourseLearningCase.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.DownloadNumber); //下载数目
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.FileIntegration))
 {
 if (objCourseLearningCaseEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.FileIntegration, conCourseLearningCase.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.FileIntegration); //文件积分
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.LikeCount))
 {
 if (objCourseLearningCaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.LikeCount, conCourseLearningCase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CollectionCount))
 {
 if (objCourseLearningCaseEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.CollectionCount, conCourseLearningCase.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CollectionCount); //收藏数量
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.RecommendedDegreeId))
 {
 if (objCourseLearningCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objCourseLearningCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conCourseLearningCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ftpFileType))
 {
 if (objCourseLearningCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objCourseLearningCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conCourseLearningCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.VideoUrl))
 {
 if (objCourseLearningCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objCourseLearningCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conCourseLearningCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.VideoUrl); //视频Url
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.VideoPath))
 {
 if (objCourseLearningCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objCourseLearningCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conCourseLearningCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.VideoPath); //视频目录
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ImageUrl))
 {
 if (objCourseLearningCaseEN.ImageUrl !=  null)
 {
 var strImageUrl = objCourseLearningCaseEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImageUrl, conCourseLearningCase.ImageUrl); //ImageUrl
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.ImageUrl); //ImageUrl
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ResErrMsg))
 {
 if (objCourseLearningCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objCourseLearningCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conCourseLearningCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.OrderNum))
 {
 if (objCourseLearningCaseEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.OrderNum, conCourseLearningCase.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.OrderNum); //序号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.UpdDate))
 {
 if (objCourseLearningCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objCourseLearningCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCourseLearningCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.UpdDate); //修改日期
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.UpdUserId))
 {
 if (objCourseLearningCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCourseLearningCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCourseLearningCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.Memo))
 {
 if (objCourseLearningCaseEN.Memo !=  null)
 {
 var strMemo = objCourseLearningCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCourseLearningCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCourseLearningCase = '{0}'", objCourseLearningCaseEN.IdCourseLearningCase); 
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
 /// <param name = "objCourseLearningCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCourseLearningCaseEN objCourseLearningCaseEN, string strCondition)
{
 objCourseLearningCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCourseLearningCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCourseLearningCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CourseLearningCase Set ");
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseID))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseID !=  null)
 {
 var strCourseLearningCaseID = objCourseLearningCaseEN.CourseLearningCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseLearningCaseID = '{0}',", strCourseLearningCaseID); //课程学习案例ID
 }
 else
 {
 sbSQL.Append(" CourseLearningCaseID = null,"); //课程学习案例ID
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseName))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseName !=  null)
 {
 var strCourseLearningCaseName = objCourseLearningCaseEN.CourseLearningCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseLearningCaseName = '{0}',", strCourseLearningCaseName); //课程学习案例名称
 }
 else
 {
 sbSQL.Append(" CourseLearningCaseName = null,"); //课程学习案例名称
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseText))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseText !=  null)
 {
 var strCourseLearningCaseText = objCourseLearningCaseEN.CourseLearningCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseLearningCaseText = '{0}',", strCourseLearningCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" CourseLearningCaseText = null,"); //案例文本内容
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseTheme))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseTheme !=  null)
 {
 var strCourseLearningCaseTheme = objCourseLearningCaseEN.CourseLearningCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseLearningCaseTheme = '{0}',", strCourseLearningCaseTheme); //课程学习案例主题词
 }
 else
 {
 sbSQL.Append(" CourseLearningCaseTheme = null,"); //课程学习案例主题词
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseDate))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseDate !=  null)
 {
 var strCourseLearningCaseDate = objCourseLearningCaseEN.CourseLearningCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseLearningCaseDate = '{0}',", strCourseLearningCaseDate); //课程学习日期
 }
 else
 {
 sbSQL.Append(" CourseLearningCaseDate = null,"); //课程学习日期
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseTime))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseTime !=  null)
 {
 var strCourseLearningCaseTime = objCourseLearningCaseEN.CourseLearningCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseLearningCaseTime = '{0}',", strCourseLearningCaseTime); //课程学习时间
 }
 else
 {
 sbSQL.Append(" CourseLearningCaseTime = null,"); //课程学习时间
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseDateIn))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseDateIn !=  null)
 {
 var strCourseLearningCaseDateIn = objCourseLearningCaseEN.CourseLearningCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseLearningCaseDateIn = '{0}',", strCourseLearningCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" CourseLearningCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseTimeIn))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseTimeIn !=  null)
 {
 var strCourseLearningCaseTimeIn = objCourseLearningCaseEN.CourseLearningCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseLearningCaseTimeIn = '{0}',", strCourseLearningCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" CourseLearningCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdCaseType))
 {
 if (objCourseLearningCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objCourseLearningCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdCourseLearningCaseType))
 {
 if (objCourseLearningCaseEN.IdCourseLearningCaseType !=  null)
 {
 var strIdCourseLearningCaseType = objCourseLearningCaseEN.IdCourseLearningCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCourseLearningCaseType = '{0}',", strIdCourseLearningCaseType); //课程学习案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCourseLearningCaseType = null,"); //课程学习案例类型流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.OwnerId))
 {
 if (objCourseLearningCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objCourseLearningCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdStudyLevel))
 {
 if (objCourseLearningCaseEN.IdStudyLevel  ==  "")
 {
 objCourseLearningCaseEN.IdStudyLevel = null;
 }
 if (objCourseLearningCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objCourseLearningCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdTeachingPlan))
 {
 if (objCourseLearningCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objCourseLearningCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdDiscipline))
 {
 if (objCourseLearningCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objCourseLearningCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.BrowseCount))
 {
 if (objCourseLearningCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.BrowseCount, conCourseLearningCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.BrowseCount); //浏览次数
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdSenateGaugeVersion))
 {
 if (objCourseLearningCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCourseLearningCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCourseLearningCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objCourseLearningCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdTeachSkill))
 {
 if (objCourseLearningCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objCourseLearningCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CaseLevelId))
 {
 if (objCourseLearningCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objCourseLearningCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.DocFile))
 {
 if (objCourseLearningCaseEN.DocFile !=  null)
 {
 var strDocFile = objCourseLearningCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objCourseLearningCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.WordCreateDate))
 {
 if (objCourseLearningCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objCourseLearningCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objCourseLearningCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objCourseLearningCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdXzCollege))
 {
 if (objCourseLearningCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCourseLearningCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdXzMajor))
 {
 if (objCourseLearningCaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objCourseLearningCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseId))
 {
 if (objCourseLearningCaseEN.CourseId  ==  "")
 {
 objCourseLearningCaseEN.CourseId = null;
 }
 if (objCourseLearningCaseEN.CourseId !=  null)
 {
 var strCourseId = objCourseLearningCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.TeachingSolutionId))
 {
 if (objCourseLearningCaseEN.TeachingSolutionId !=  null)
 {
 var strTeachingSolutionId = objCourseLearningCaseEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingSolutionId = '{0}',", strTeachingSolutionId); //教学方案Id
 }
 else
 {
 sbSQL.Append(" TeachingSolutionId = null,"); //教学方案Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseChapterId))
 {
 if (objCourseLearningCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objCourseLearningCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ViewCount))
 {
 if (objCourseLearningCaseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.ViewCount, conCourseLearningCase.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.ViewCount); //浏览量
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objCourseLearningCaseEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.DownloadNumber))
 {
 if (objCourseLearningCaseEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.DownloadNumber, conCourseLearningCase.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.DownloadNumber); //下载数目
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.FileIntegration))
 {
 if (objCourseLearningCaseEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.FileIntegration, conCourseLearningCase.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.FileIntegration); //文件积分
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.LikeCount))
 {
 if (objCourseLearningCaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.LikeCount, conCourseLearningCase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CollectionCount))
 {
 if (objCourseLearningCaseEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.CollectionCount, conCourseLearningCase.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CollectionCount); //收藏数量
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.RecommendedDegreeId))
 {
 if (objCourseLearningCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objCourseLearningCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ftpFileType))
 {
 if (objCourseLearningCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objCourseLearningCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.VideoUrl))
 {
 if (objCourseLearningCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objCourseLearningCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.VideoPath))
 {
 if (objCourseLearningCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objCourseLearningCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ImageUrl))
 {
 if (objCourseLearningCaseEN.ImageUrl !=  null)
 {
 var strImageUrl = objCourseLearningCaseEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImageUrl = '{0}',", strImageUrl); //ImageUrl
 }
 else
 {
 sbSQL.Append(" ImageUrl = null,"); //ImageUrl
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ResErrMsg))
 {
 if (objCourseLearningCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objCourseLearningCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.OrderNum))
 {
 if (objCourseLearningCaseEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.OrderNum, conCourseLearningCase.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.OrderNum); //序号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.UpdDate))
 {
 if (objCourseLearningCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objCourseLearningCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.UpdUserId))
 {
 if (objCourseLearningCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCourseLearningCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.Memo))
 {
 if (objCourseLearningCaseEN.Memo !=  null)
 {
 var strMemo = objCourseLearningCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCourseLearningCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCourseLearningCaseEN objCourseLearningCaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCourseLearningCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCourseLearningCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCourseLearningCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CourseLearningCase Set ");
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseID))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseID !=  null)
 {
 var strCourseLearningCaseID = objCourseLearningCaseEN.CourseLearningCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseLearningCaseID = '{0}',", strCourseLearningCaseID); //课程学习案例ID
 }
 else
 {
 sbSQL.Append(" CourseLearningCaseID = null,"); //课程学习案例ID
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseName))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseName !=  null)
 {
 var strCourseLearningCaseName = objCourseLearningCaseEN.CourseLearningCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseLearningCaseName = '{0}',", strCourseLearningCaseName); //课程学习案例名称
 }
 else
 {
 sbSQL.Append(" CourseLearningCaseName = null,"); //课程学习案例名称
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseText))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseText !=  null)
 {
 var strCourseLearningCaseText = objCourseLearningCaseEN.CourseLearningCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseLearningCaseText = '{0}',", strCourseLearningCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" CourseLearningCaseText = null,"); //案例文本内容
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseTheme))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseTheme !=  null)
 {
 var strCourseLearningCaseTheme = objCourseLearningCaseEN.CourseLearningCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseLearningCaseTheme = '{0}',", strCourseLearningCaseTheme); //课程学习案例主题词
 }
 else
 {
 sbSQL.Append(" CourseLearningCaseTheme = null,"); //课程学习案例主题词
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseDate))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseDate !=  null)
 {
 var strCourseLearningCaseDate = objCourseLearningCaseEN.CourseLearningCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseLearningCaseDate = '{0}',", strCourseLearningCaseDate); //课程学习日期
 }
 else
 {
 sbSQL.Append(" CourseLearningCaseDate = null,"); //课程学习日期
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseTime))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseTime !=  null)
 {
 var strCourseLearningCaseTime = objCourseLearningCaseEN.CourseLearningCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseLearningCaseTime = '{0}',", strCourseLearningCaseTime); //课程学习时间
 }
 else
 {
 sbSQL.Append(" CourseLearningCaseTime = null,"); //课程学习时间
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseDateIn))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseDateIn !=  null)
 {
 var strCourseLearningCaseDateIn = objCourseLearningCaseEN.CourseLearningCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseLearningCaseDateIn = '{0}',", strCourseLearningCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" CourseLearningCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseTimeIn))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseTimeIn !=  null)
 {
 var strCourseLearningCaseTimeIn = objCourseLearningCaseEN.CourseLearningCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseLearningCaseTimeIn = '{0}',", strCourseLearningCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" CourseLearningCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdCaseType))
 {
 if (objCourseLearningCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objCourseLearningCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdCourseLearningCaseType))
 {
 if (objCourseLearningCaseEN.IdCourseLearningCaseType !=  null)
 {
 var strIdCourseLearningCaseType = objCourseLearningCaseEN.IdCourseLearningCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCourseLearningCaseType = '{0}',", strIdCourseLearningCaseType); //课程学习案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCourseLearningCaseType = null,"); //课程学习案例类型流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.OwnerId))
 {
 if (objCourseLearningCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objCourseLearningCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdStudyLevel))
 {
 if (objCourseLearningCaseEN.IdStudyLevel  ==  "")
 {
 objCourseLearningCaseEN.IdStudyLevel = null;
 }
 if (objCourseLearningCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objCourseLearningCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdTeachingPlan))
 {
 if (objCourseLearningCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objCourseLearningCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdDiscipline))
 {
 if (objCourseLearningCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objCourseLearningCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.BrowseCount))
 {
 if (objCourseLearningCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.BrowseCount, conCourseLearningCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.BrowseCount); //浏览次数
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdSenateGaugeVersion))
 {
 if (objCourseLearningCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCourseLearningCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCourseLearningCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objCourseLearningCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdTeachSkill))
 {
 if (objCourseLearningCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objCourseLearningCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CaseLevelId))
 {
 if (objCourseLearningCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objCourseLearningCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.DocFile))
 {
 if (objCourseLearningCaseEN.DocFile !=  null)
 {
 var strDocFile = objCourseLearningCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objCourseLearningCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.WordCreateDate))
 {
 if (objCourseLearningCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objCourseLearningCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objCourseLearningCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objCourseLearningCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdXzCollege))
 {
 if (objCourseLearningCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCourseLearningCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdXzMajor))
 {
 if (objCourseLearningCaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objCourseLearningCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseId))
 {
 if (objCourseLearningCaseEN.CourseId  ==  "")
 {
 objCourseLearningCaseEN.CourseId = null;
 }
 if (objCourseLearningCaseEN.CourseId !=  null)
 {
 var strCourseId = objCourseLearningCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.TeachingSolutionId))
 {
 if (objCourseLearningCaseEN.TeachingSolutionId !=  null)
 {
 var strTeachingSolutionId = objCourseLearningCaseEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingSolutionId = '{0}',", strTeachingSolutionId); //教学方案Id
 }
 else
 {
 sbSQL.Append(" TeachingSolutionId = null,"); //教学方案Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseChapterId))
 {
 if (objCourseLearningCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objCourseLearningCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ViewCount))
 {
 if (objCourseLearningCaseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.ViewCount, conCourseLearningCase.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.ViewCount); //浏览量
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objCourseLearningCaseEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.DownloadNumber))
 {
 if (objCourseLearningCaseEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.DownloadNumber, conCourseLearningCase.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.DownloadNumber); //下载数目
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.FileIntegration))
 {
 if (objCourseLearningCaseEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.FileIntegration, conCourseLearningCase.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.FileIntegration); //文件积分
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.LikeCount))
 {
 if (objCourseLearningCaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.LikeCount, conCourseLearningCase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CollectionCount))
 {
 if (objCourseLearningCaseEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.CollectionCount, conCourseLearningCase.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CollectionCount); //收藏数量
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.RecommendedDegreeId))
 {
 if (objCourseLearningCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objCourseLearningCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ftpFileType))
 {
 if (objCourseLearningCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objCourseLearningCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.VideoUrl))
 {
 if (objCourseLearningCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objCourseLearningCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.VideoPath))
 {
 if (objCourseLearningCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objCourseLearningCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ImageUrl))
 {
 if (objCourseLearningCaseEN.ImageUrl !=  null)
 {
 var strImageUrl = objCourseLearningCaseEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImageUrl = '{0}',", strImageUrl); //ImageUrl
 }
 else
 {
 sbSQL.Append(" ImageUrl = null,"); //ImageUrl
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ResErrMsg))
 {
 if (objCourseLearningCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objCourseLearningCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.OrderNum))
 {
 if (objCourseLearningCaseEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.OrderNum, conCourseLearningCase.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.OrderNum); //序号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.UpdDate))
 {
 if (objCourseLearningCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objCourseLearningCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.UpdUserId))
 {
 if (objCourseLearningCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCourseLearningCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.Memo))
 {
 if (objCourseLearningCaseEN.Memo !=  null)
 {
 var strMemo = objCourseLearningCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCourseLearningCaseEN objCourseLearningCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCourseLearningCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCourseLearningCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCourseLearningCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CourseLearningCase Set ");
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseID))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseID !=  null)
 {
 var strCourseLearningCaseID = objCourseLearningCaseEN.CourseLearningCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseLearningCaseID, conCourseLearningCase.CourseLearningCaseID); //课程学习案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseLearningCaseID); //课程学习案例ID
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseName))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseName !=  null)
 {
 var strCourseLearningCaseName = objCourseLearningCaseEN.CourseLearningCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseLearningCaseName, conCourseLearningCase.CourseLearningCaseName); //课程学习案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseLearningCaseName); //课程学习案例名称
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseText))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseText !=  null)
 {
 var strCourseLearningCaseText = objCourseLearningCaseEN.CourseLearningCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseLearningCaseText, conCourseLearningCase.CourseLearningCaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseLearningCaseText); //案例文本内容
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseTheme))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseTheme !=  null)
 {
 var strCourseLearningCaseTheme = objCourseLearningCaseEN.CourseLearningCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseLearningCaseTheme, conCourseLearningCase.CourseLearningCaseTheme); //课程学习案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseLearningCaseTheme); //课程学习案例主题词
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseDate))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseDate !=  null)
 {
 var strCourseLearningCaseDate = objCourseLearningCaseEN.CourseLearningCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseLearningCaseDate, conCourseLearningCase.CourseLearningCaseDate); //课程学习日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseLearningCaseDate); //课程学习日期
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseTime))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseTime !=  null)
 {
 var strCourseLearningCaseTime = objCourseLearningCaseEN.CourseLearningCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseLearningCaseTime, conCourseLearningCase.CourseLearningCaseTime); //课程学习时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseLearningCaseTime); //课程学习时间
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseDateIn))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseDateIn !=  null)
 {
 var strCourseLearningCaseDateIn = objCourseLearningCaseEN.CourseLearningCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseLearningCaseDateIn, conCourseLearningCase.CourseLearningCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseLearningCaseDateIn); //案例入库日期
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseLearningCaseTimeIn))
 {
 if (objCourseLearningCaseEN.CourseLearningCaseTimeIn !=  null)
 {
 var strCourseLearningCaseTimeIn = objCourseLearningCaseEN.CourseLearningCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseLearningCaseTimeIn, conCourseLearningCase.CourseLearningCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseLearningCaseTimeIn); //案例入库时间
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdCaseType))
 {
 if (objCourseLearningCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objCourseLearningCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conCourseLearningCase.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdCaseType); //案例类型流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdCourseLearningCaseType))
 {
 if (objCourseLearningCaseEN.IdCourseLearningCaseType !=  null)
 {
 var strIdCourseLearningCaseType = objCourseLearningCaseEN.IdCourseLearningCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCourseLearningCaseType, conCourseLearningCase.IdCourseLearningCaseType); //课程学习案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdCourseLearningCaseType); //课程学习案例类型流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.OwnerId))
 {
 if (objCourseLearningCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objCourseLearningCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conCourseLearningCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.OwnerId); //拥有者Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdStudyLevel))
 {
 if (objCourseLearningCaseEN.IdStudyLevel  ==  "")
 {
 objCourseLearningCaseEN.IdStudyLevel = null;
 }
 if (objCourseLearningCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objCourseLearningCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conCourseLearningCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdTeachingPlan))
 {
 if (objCourseLearningCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objCourseLearningCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conCourseLearningCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdDiscipline))
 {
 if (objCourseLearningCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objCourseLearningCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conCourseLearningCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.BrowseCount))
 {
 if (objCourseLearningCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.BrowseCount, conCourseLearningCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.BrowseCount); //浏览次数
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdSenateGaugeVersion))
 {
 if (objCourseLearningCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCourseLearningCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCourseLearningCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objCourseLearningCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conCourseLearningCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdTeachSkill))
 {
 if (objCourseLearningCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objCourseLearningCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conCourseLearningCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CaseLevelId))
 {
 if (objCourseLearningCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objCourseLearningCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conCourseLearningCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.DocFile))
 {
 if (objCourseLearningCaseEN.DocFile !=  null)
 {
 var strDocFile = objCourseLearningCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conCourseLearningCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCourseLearningCaseEN.IsNeedGeneWord == true?"1":"0", conCourseLearningCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.WordCreateDate))
 {
 if (objCourseLearningCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objCourseLearningCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conCourseLearningCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCourseLearningCaseEN.IsVisible == true?"1":"0", conCourseLearningCase.IsVisible); //是否显示
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCourseLearningCaseEN.IsDualVideo == true?"1":"0", conCourseLearningCase.IsDualVideo); //是否双视频
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdXzCollege))
 {
 if (objCourseLearningCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCourseLearningCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conCourseLearningCase.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdXzCollege); //学院流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IdXzMajor))
 {
 if (objCourseLearningCaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objCourseLearningCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conCourseLearningCase.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.IdXzMajor); //专业流水号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseId))
 {
 if (objCourseLearningCaseEN.CourseId  ==  "")
 {
 objCourseLearningCaseEN.CourseId = null;
 }
 if (objCourseLearningCaseEN.CourseId !=  null)
 {
 var strCourseId = objCourseLearningCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conCourseLearningCase.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseId); //课程Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.TeachingSolutionId))
 {
 if (objCourseLearningCaseEN.TeachingSolutionId !=  null)
 {
 var strTeachingSolutionId = objCourseLearningCaseEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingSolutionId, conCourseLearningCase.TeachingSolutionId); //教学方案Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.TeachingSolutionId); //教学方案Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CourseChapterId))
 {
 if (objCourseLearningCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objCourseLearningCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, conCourseLearningCase.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CourseChapterId); //课程章节ID
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ViewCount))
 {
 if (objCourseLearningCaseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.ViewCount, conCourseLearningCase.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.ViewCount); //浏览量
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCourseLearningCaseEN.IsShow == true?"1":"0", conCourseLearningCase.IsShow); //是否启用
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.DownloadNumber))
 {
 if (objCourseLearningCaseEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.DownloadNumber, conCourseLearningCase.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.DownloadNumber); //下载数目
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.FileIntegration))
 {
 if (objCourseLearningCaseEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.FileIntegration, conCourseLearningCase.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.FileIntegration); //文件积分
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.LikeCount))
 {
 if (objCourseLearningCaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.LikeCount, conCourseLearningCase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.CollectionCount))
 {
 if (objCourseLearningCaseEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.CollectionCount, conCourseLearningCase.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.CollectionCount); //收藏数量
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.RecommendedDegreeId))
 {
 if (objCourseLearningCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objCourseLearningCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conCourseLearningCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ftpFileType))
 {
 if (objCourseLearningCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objCourseLearningCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conCourseLearningCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.VideoUrl))
 {
 if (objCourseLearningCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objCourseLearningCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conCourseLearningCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.VideoUrl); //视频Url
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.VideoPath))
 {
 if (objCourseLearningCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objCourseLearningCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conCourseLearningCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.VideoPath); //视频目录
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ImageUrl))
 {
 if (objCourseLearningCaseEN.ImageUrl !=  null)
 {
 var strImageUrl = objCourseLearningCaseEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImageUrl, conCourseLearningCase.ImageUrl); //ImageUrl
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.ImageUrl); //ImageUrl
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.ResErrMsg))
 {
 if (objCourseLearningCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objCourseLearningCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conCourseLearningCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.OrderNum))
 {
 if (objCourseLearningCaseEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCourseLearningCaseEN.OrderNum, conCourseLearningCase.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.OrderNum); //序号
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.UpdDate))
 {
 if (objCourseLearningCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objCourseLearningCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCourseLearningCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.UpdDate); //修改日期
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.UpdUserId))
 {
 if (objCourseLearningCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCourseLearningCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCourseLearningCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objCourseLearningCaseEN.IsUpdated(conCourseLearningCase.Memo))
 {
 if (objCourseLearningCaseEN.Memo !=  null)
 {
 var strMemo = objCourseLearningCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCourseLearningCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCourseLearningCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCourseLearningCase = '{0}'", objCourseLearningCaseEN.IdCourseLearningCase); 
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
 /// <param name = "strIdCourseLearningCase">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdCourseLearningCase) 
{
CheckPrimaryKey(strIdCourseLearningCase);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdCourseLearningCase,
};
 objSQL.ExecSP("CourseLearningCase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdCourseLearningCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdCourseLearningCase);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
//删除CourseLearningCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CourseLearningCase where IdCourseLearningCase = " + "'"+ strIdCourseLearningCase+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCourseLearningCase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
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
//删除CourseLearningCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CourseLearningCase where IdCourseLearningCase in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdCourseLearningCase) 
{
CheckPrimaryKey(strIdCourseLearningCase);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
//删除CourseLearningCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CourseLearningCase where IdCourseLearningCase = " + "'"+ strIdCourseLearningCase+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCourseLearningCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCourseLearningCaseDA: DelCourseLearningCase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CourseLearningCase where " + strCondition ;
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
public bool DelCourseLearningCaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCourseLearningCaseDA: DelCourseLearningCaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CourseLearningCase where " + strCondition ;
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
 /// <param name = "objCourseLearningCaseENS">源对象</param>
 /// <param name = "objCourseLearningCaseENT">目标对象</param>
public void CopyTo(clsCourseLearningCaseEN objCourseLearningCaseENS, clsCourseLearningCaseEN objCourseLearningCaseENT)
{
objCourseLearningCaseENT.IdCourseLearningCase = objCourseLearningCaseENS.IdCourseLearningCase; //课程学习案例流水号
objCourseLearningCaseENT.CourseLearningCaseID = objCourseLearningCaseENS.CourseLearningCaseID; //课程学习案例ID
objCourseLearningCaseENT.CourseLearningCaseName = objCourseLearningCaseENS.CourseLearningCaseName; //课程学习案例名称
objCourseLearningCaseENT.CourseLearningCaseText = objCourseLearningCaseENS.CourseLearningCaseText; //案例文本内容
objCourseLearningCaseENT.CourseLearningCaseTheme = objCourseLearningCaseENS.CourseLearningCaseTheme; //课程学习案例主题词
objCourseLearningCaseENT.CourseLearningCaseDate = objCourseLearningCaseENS.CourseLearningCaseDate; //课程学习日期
objCourseLearningCaseENT.CourseLearningCaseTime = objCourseLearningCaseENS.CourseLearningCaseTime; //课程学习时间
objCourseLearningCaseENT.CourseLearningCaseDateIn = objCourseLearningCaseENS.CourseLearningCaseDateIn; //案例入库日期
objCourseLearningCaseENT.CourseLearningCaseTimeIn = objCourseLearningCaseENS.CourseLearningCaseTimeIn; //案例入库时间
objCourseLearningCaseENT.IdCaseType = objCourseLearningCaseENS.IdCaseType; //案例类型流水号
objCourseLearningCaseENT.IdCourseLearningCaseType = objCourseLearningCaseENS.IdCourseLearningCaseType; //课程学习案例类型流水号
objCourseLearningCaseENT.OwnerId = objCourseLearningCaseENS.OwnerId; //拥有者Id
objCourseLearningCaseENT.IdStudyLevel = objCourseLearningCaseENS.IdStudyLevel; //学段流水号
objCourseLearningCaseENT.IdTeachingPlan = objCourseLearningCaseENS.IdTeachingPlan; //教案流水号
objCourseLearningCaseENT.IdDiscipline = objCourseLearningCaseENS.IdDiscipline; //学科流水号
objCourseLearningCaseENT.BrowseCount = objCourseLearningCaseENS.BrowseCount; //浏览次数
objCourseLearningCaseENT.IdSenateGaugeVersion = objCourseLearningCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objCourseLearningCaseENT.IdTeachSkill = objCourseLearningCaseENS.IdTeachSkill; //教学技能流水号
objCourseLearningCaseENT.CaseLevelId = objCourseLearningCaseENS.CaseLevelId; //课例等级Id
objCourseLearningCaseENT.DocFile = objCourseLearningCaseENS.DocFile; //生成的Word文件名
objCourseLearningCaseENT.IsNeedGeneWord = objCourseLearningCaseENS.IsNeedGeneWord; //是否需要生成Word
objCourseLearningCaseENT.WordCreateDate = objCourseLearningCaseENS.WordCreateDate; //Word生成日期
objCourseLearningCaseENT.IsVisible = objCourseLearningCaseENS.IsVisible; //是否显示
objCourseLearningCaseENT.IsDualVideo = objCourseLearningCaseENS.IsDualVideo; //是否双视频
objCourseLearningCaseENT.IdXzCollege = objCourseLearningCaseENS.IdXzCollege; //学院流水号
objCourseLearningCaseENT.IdXzMajor = objCourseLearningCaseENS.IdXzMajor; //专业流水号
objCourseLearningCaseENT.CourseId = objCourseLearningCaseENS.CourseId; //课程Id
objCourseLearningCaseENT.TeachingSolutionId = objCourseLearningCaseENS.TeachingSolutionId; //教学方案Id
objCourseLearningCaseENT.CourseChapterId = objCourseLearningCaseENS.CourseChapterId; //课程章节ID
objCourseLearningCaseENT.ViewCount = objCourseLearningCaseENS.ViewCount; //浏览量
objCourseLearningCaseENT.IsShow = objCourseLearningCaseENS.IsShow; //是否启用
objCourseLearningCaseENT.DownloadNumber = objCourseLearningCaseENS.DownloadNumber; //下载数目
objCourseLearningCaseENT.FileIntegration = objCourseLearningCaseENS.FileIntegration; //文件积分
objCourseLearningCaseENT.LikeCount = objCourseLearningCaseENS.LikeCount; //资源喜欢数量
objCourseLearningCaseENT.CollectionCount = objCourseLearningCaseENS.CollectionCount; //收藏数量
objCourseLearningCaseENT.RecommendedDegreeId = objCourseLearningCaseENS.RecommendedDegreeId; //推荐度Id
objCourseLearningCaseENT.ftpFileType = objCourseLearningCaseENS.ftpFileType; //ftp文件类型
objCourseLearningCaseENT.VideoUrl = objCourseLearningCaseENS.VideoUrl; //视频Url
objCourseLearningCaseENT.VideoPath = objCourseLearningCaseENS.VideoPath; //视频目录
objCourseLearningCaseENT.ImageUrl = objCourseLearningCaseENS.ImageUrl; //ImageUrl
objCourseLearningCaseENT.ResErrMsg = objCourseLearningCaseENS.ResErrMsg; //资源错误信息
objCourseLearningCaseENT.OrderNum = objCourseLearningCaseENS.OrderNum; //序号
objCourseLearningCaseENT.UpdDate = objCourseLearningCaseENS.UpdDate; //修改日期
objCourseLearningCaseENT.UpdUserId = objCourseLearningCaseENS.UpdUserId; //修改用户Id
objCourseLearningCaseENT.Memo = objCourseLearningCaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCourseLearningCaseEN.CourseLearningCaseID, conCourseLearningCase.CourseLearningCaseID);
clsCheckSql.CheckFieldNotNull(objCourseLearningCaseEN.CourseLearningCaseName, conCourseLearningCase.CourseLearningCaseName);
clsCheckSql.CheckFieldNotNull(objCourseLearningCaseEN.IdCourseLearningCaseType, conCourseLearningCase.IdCourseLearningCaseType);
clsCheckSql.CheckFieldNotNull(objCourseLearningCaseEN.OwnerId, conCourseLearningCase.OwnerId);
clsCheckSql.CheckFieldNotNull(objCourseLearningCaseEN.CourseId, conCourseLearningCase.CourseId);
clsCheckSql.CheckFieldNotNull(objCourseLearningCaseEN.RecommendedDegreeId, conCourseLearningCase.RecommendedDegreeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdCourseLearningCase, 8, conCourseLearningCase.IdCourseLearningCase);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseID, 8, conCourseLearningCase.CourseLearningCaseID);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseName, 100, conCourseLearningCase.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseText, 8000, conCourseLearningCase.CourseLearningCaseText);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseTheme, 200, conCourseLearningCase.CourseLearningCaseTheme);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseDate, 8, conCourseLearningCase.CourseLearningCaseDate);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseTime, 6, conCourseLearningCase.CourseLearningCaseTime);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseDateIn, 8, conCourseLearningCase.CourseLearningCaseDateIn);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseTimeIn, 6, conCourseLearningCase.CourseLearningCaseTimeIn);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdCaseType, 4, conCourseLearningCase.IdCaseType);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdCourseLearningCaseType, 4, conCourseLearningCase.IdCourseLearningCaseType);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.OwnerId, 20, conCourseLearningCase.OwnerId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdStudyLevel, 4, conCourseLearningCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdTeachingPlan, 8, conCourseLearningCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdDiscipline, 4, conCourseLearningCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdSenateGaugeVersion, 4, conCourseLearningCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdTeachSkill, 8, conCourseLearningCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CaseLevelId, 2, conCourseLearningCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.DocFile, 200, conCourseLearningCase.DocFile);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.WordCreateDate, 14, conCourseLearningCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdXzCollege, 4, conCourseLearningCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdXzMajor, 8, conCourseLearningCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseId, 8, conCourseLearningCase.CourseId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.TeachingSolutionId, 8, conCourseLearningCase.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseChapterId, 8, conCourseLearningCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.RecommendedDegreeId, 2, conCourseLearningCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.ftpFileType, 30, conCourseLearningCase.ftpFileType);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.VideoUrl, 1000, conCourseLearningCase.VideoUrl);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.VideoPath, 1000, conCourseLearningCase.VideoPath);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.ImageUrl, 100, conCourseLearningCase.ImageUrl);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.ResErrMsg, 30, conCourseLearningCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.UpdDate, 20, conCourseLearningCase.UpdDate);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.UpdUserId, 20, conCourseLearningCase.UpdUserId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.Memo, 1000, conCourseLearningCase.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objCourseLearningCaseEN.IdStudyLevel, 4, conCourseLearningCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objCourseLearningCaseEN.IdSenateGaugeVersion, 4, conCourseLearningCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(objCourseLearningCaseEN.CourseId, 8, conCourseLearningCase.CourseId);
 objCourseLearningCaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseID, 8, conCourseLearningCase.CourseLearningCaseID);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseName, 100, conCourseLearningCase.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseText, 8000, conCourseLearningCase.CourseLearningCaseText);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseTheme, 200, conCourseLearningCase.CourseLearningCaseTheme);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseDate, 8, conCourseLearningCase.CourseLearningCaseDate);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseTime, 6, conCourseLearningCase.CourseLearningCaseTime);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseDateIn, 8, conCourseLearningCase.CourseLearningCaseDateIn);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseTimeIn, 6, conCourseLearningCase.CourseLearningCaseTimeIn);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdCaseType, 4, conCourseLearningCase.IdCaseType);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdCourseLearningCaseType, 4, conCourseLearningCase.IdCourseLearningCaseType);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.OwnerId, 20, conCourseLearningCase.OwnerId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdStudyLevel, 4, conCourseLearningCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdTeachingPlan, 8, conCourseLearningCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdDiscipline, 4, conCourseLearningCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdSenateGaugeVersion, 4, conCourseLearningCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdTeachSkill, 8, conCourseLearningCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CaseLevelId, 2, conCourseLearningCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.DocFile, 200, conCourseLearningCase.DocFile);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.WordCreateDate, 14, conCourseLearningCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdXzCollege, 4, conCourseLearningCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdXzMajor, 8, conCourseLearningCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseId, 8, conCourseLearningCase.CourseId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.TeachingSolutionId, 8, conCourseLearningCase.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseChapterId, 8, conCourseLearningCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.RecommendedDegreeId, 2, conCourseLearningCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.ftpFileType, 30, conCourseLearningCase.ftpFileType);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.VideoUrl, 1000, conCourseLearningCase.VideoUrl);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.VideoPath, 1000, conCourseLearningCase.VideoPath);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.ImageUrl, 100, conCourseLearningCase.ImageUrl);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.ResErrMsg, 30, conCourseLearningCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.UpdDate, 20, conCourseLearningCase.UpdDate);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.UpdUserId, 20, conCourseLearningCase.UpdUserId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.Memo, 1000, conCourseLearningCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCourseLearningCaseEN.IdStudyLevel, 4, conCourseLearningCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objCourseLearningCaseEN.IdSenateGaugeVersion, 4, conCourseLearningCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(objCourseLearningCaseEN.CourseId, 8, conCourseLearningCase.CourseId);
 objCourseLearningCaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdCourseLearningCase, 8, conCourseLearningCase.IdCourseLearningCase);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseID, 8, conCourseLearningCase.CourseLearningCaseID);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseName, 100, conCourseLearningCase.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseText, 8000, conCourseLearningCase.CourseLearningCaseText);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseTheme, 200, conCourseLearningCase.CourseLearningCaseTheme);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseDate, 8, conCourseLearningCase.CourseLearningCaseDate);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseTime, 6, conCourseLearningCase.CourseLearningCaseTime);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseDateIn, 8, conCourseLearningCase.CourseLearningCaseDateIn);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseLearningCaseTimeIn, 6, conCourseLearningCase.CourseLearningCaseTimeIn);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdCaseType, 4, conCourseLearningCase.IdCaseType);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdCourseLearningCaseType, 4, conCourseLearningCase.IdCourseLearningCaseType);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.OwnerId, 20, conCourseLearningCase.OwnerId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdStudyLevel, 4, conCourseLearningCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdTeachingPlan, 8, conCourseLearningCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdDiscipline, 4, conCourseLearningCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdSenateGaugeVersion, 4, conCourseLearningCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdTeachSkill, 8, conCourseLearningCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CaseLevelId, 2, conCourseLearningCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.DocFile, 200, conCourseLearningCase.DocFile);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.WordCreateDate, 14, conCourseLearningCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdXzCollege, 4, conCourseLearningCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.IdXzMajor, 8, conCourseLearningCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseId, 8, conCourseLearningCase.CourseId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.TeachingSolutionId, 8, conCourseLearningCase.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.CourseChapterId, 8, conCourseLearningCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.RecommendedDegreeId, 2, conCourseLearningCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.ftpFileType, 30, conCourseLearningCase.ftpFileType);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.VideoUrl, 1000, conCourseLearningCase.VideoUrl);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.VideoPath, 1000, conCourseLearningCase.VideoPath);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.ImageUrl, 100, conCourseLearningCase.ImageUrl);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.ResErrMsg, 30, conCourseLearningCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.UpdDate, 20, conCourseLearningCase.UpdDate);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.UpdUserId, 20, conCourseLearningCase.UpdUserId);
clsCheckSql.CheckFieldLen(objCourseLearningCaseEN.Memo, 1000, conCourseLearningCase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.IdCourseLearningCase, conCourseLearningCase.IdCourseLearningCase);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.CourseLearningCaseID, conCourseLearningCase.CourseLearningCaseID);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.CourseLearningCaseName, conCourseLearningCase.CourseLearningCaseName);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.CourseLearningCaseText, conCourseLearningCase.CourseLearningCaseText);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.CourseLearningCaseTheme, conCourseLearningCase.CourseLearningCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.CourseLearningCaseDate, conCourseLearningCase.CourseLearningCaseDate);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.CourseLearningCaseTime, conCourseLearningCase.CourseLearningCaseTime);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.CourseLearningCaseDateIn, conCourseLearningCase.CourseLearningCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.CourseLearningCaseTimeIn, conCourseLearningCase.CourseLearningCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.IdCaseType, conCourseLearningCase.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.IdCourseLearningCaseType, conCourseLearningCase.IdCourseLearningCaseType);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.OwnerId, conCourseLearningCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.IdStudyLevel, conCourseLearningCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.IdTeachingPlan, conCourseLearningCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.IdDiscipline, conCourseLearningCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.IdSenateGaugeVersion, conCourseLearningCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.IdTeachSkill, conCourseLearningCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.CaseLevelId, conCourseLearningCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.DocFile, conCourseLearningCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.WordCreateDate, conCourseLearningCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.IdXzCollege, conCourseLearningCase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.IdXzMajor, conCourseLearningCase.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.CourseId, conCourseLearningCase.CourseId);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.TeachingSolutionId, conCourseLearningCase.TeachingSolutionId);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.CourseChapterId, conCourseLearningCase.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.RecommendedDegreeId, conCourseLearningCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.ftpFileType, conCourseLearningCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.VideoUrl, conCourseLearningCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.VideoPath, conCourseLearningCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.ImageUrl, conCourseLearningCase.ImageUrl);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.ResErrMsg, conCourseLearningCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.UpdDate, conCourseLearningCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.UpdUserId, conCourseLearningCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objCourseLearningCaseEN.Memo, conCourseLearningCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCourseLearningCaseEN.IdStudyLevel, 4, conCourseLearningCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objCourseLearningCaseEN.IdSenateGaugeVersion, 4, conCourseLearningCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(objCourseLearningCaseEN.CourseId, 8, conCourseLearningCase.CourseId);
 objCourseLearningCaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdCourseLearningCase()
{
//获取某学院所有专业信息
string strSQL = "select IdCourseLearningCase, CourseLearningCaseName from CourseLearningCase ";
 clsSpecSQLforSql mySql = clsCourseLearningCaseDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CourseLearningCase(课程学习案例),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseLearningCaseID = '{0}'", objCourseLearningCaseEN.CourseLearningCaseID);
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
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
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
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
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
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCourseLearningCaseEN._CurrTabName);
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
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCourseLearningCaseEN._CurrTabName, strCondition);
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
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
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
 objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}