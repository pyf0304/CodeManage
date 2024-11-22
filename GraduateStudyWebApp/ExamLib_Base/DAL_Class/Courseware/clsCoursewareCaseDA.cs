
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCoursewareCaseDA
 表名:CoursewareCase(01120416)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件(Courseware)
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
 /// 课件教学案例(CoursewareCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCoursewareCaseDA : clsCommBase4DA
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
 return clsCoursewareCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCoursewareCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCoursewareCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCoursewareCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCoursewareCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdCoursewareCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdCoursewareCase)
{
strIdCoursewareCase = strIdCoursewareCase.Replace("'", "''");
if (strIdCoursewareCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:CoursewareCase中,检查关键字,长度不正确!(clsCoursewareCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCoursewareCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CoursewareCase中,关键字不能为空 或 null!(clsCoursewareCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCoursewareCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCoursewareCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCoursewareCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CoursewareCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCoursewareCaseDA: GetDataTable_CoursewareCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCoursewareCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCoursewareCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCoursewareCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCoursewareCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CoursewareCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CoursewareCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCoursewareCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CoursewareCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCoursewareCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CoursewareCase.* from CoursewareCase Left Join {1} on {2} where {3} and CoursewareCase.IdCoursewareCase not in (Select top {5} CoursewareCase.IdCoursewareCase from CoursewareCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CoursewareCase where {1} and IdCoursewareCase not in (Select top {2} IdCoursewareCase from CoursewareCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CoursewareCase where {1} and IdCoursewareCase not in (Select top {3} IdCoursewareCase from CoursewareCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCoursewareCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CoursewareCase.* from CoursewareCase Left Join {1} on {2} where {3} and CoursewareCase.IdCoursewareCase not in (Select top {5} CoursewareCase.IdCoursewareCase from CoursewareCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CoursewareCase where {1} and IdCoursewareCase not in (Select top {2} IdCoursewareCase from CoursewareCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CoursewareCase where {1} and IdCoursewareCase not in (Select top {3} IdCoursewareCase from CoursewareCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCoursewareCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCoursewareCaseDA:GetObjLst)", objException.Message));
}
List<clsCoursewareCaseEN> arrObjLst = new List<clsCoursewareCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCoursewareCaseEN objCoursewareCaseEN = new clsCoursewareCaseEN();
try
{
objCoursewareCaseEN.IdCoursewareCase = objRow[conCoursewareCase.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objCoursewareCaseEN.CoursewareCaseID = objRow[conCoursewareCase.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objCoursewareCaseEN.CoursewareCaseName = objRow[conCoursewareCase.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objCoursewareCaseEN.CoursewareCaseTheme = objRow[conCoursewareCase.CoursewareCaseTheme] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objCoursewareCaseEN.IdCoursewareCaseType = objRow[conCoursewareCase.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objCoursewareCaseEN.CoursewareCaseText = objRow[conCoursewareCase.CoursewareCaseText] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseText].ToString().Trim(); //案例文本内容
objCoursewareCaseEN.CoursewareCaseDate = objRow[conCoursewareCase.CoursewareCaseDate] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objCoursewareCaseEN.CoursewareCaseTime = objRow[conCoursewareCase.CoursewareCaseTime] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objCoursewareCaseEN.CoursewareCaseDateIn = objRow[conCoursewareCase.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objCoursewareCaseEN.CoursewareCaseTimeIn = objRow[conCoursewareCase.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objCoursewareCaseEN.IdStudyLevel = objRow[conCoursewareCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCoursewareCaseEN.IdTeachingPlan = objRow[conCoursewareCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCoursewareCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCoursewareCaseEN.IdCaseType = objRow[conCoursewareCase.IdCaseType] == DBNull.Value ? null : objRow[conCoursewareCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCoursewareCaseEN.IdDiscipline = objRow[conCoursewareCase.IdDiscipline].ToString().Trim(); //学科流水号
objCoursewareCaseEN.BrowseCount = objRow[conCoursewareCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareCase.BrowseCount].ToString().Trim()); //浏览次数
objCoursewareCaseEN.IdSenateGaugeVersion = objRow[conCoursewareCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCoursewareCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCoursewareCaseEN.IdTeachSkill = objRow[conCoursewareCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCoursewareCaseEN.CaseLevelId = objRow[conCoursewareCase.CaseLevelId] == DBNull.Value ? null : objRow[conCoursewareCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCoursewareCaseEN.DocFile = objRow[conCoursewareCase.DocFile] == DBNull.Value ? null : objRow[conCoursewareCase.DocFile].ToString().Trim(); //生成的Word文件名
objCoursewareCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conCoursewareCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCoursewareCaseEN.WordCreateDate = objRow[conCoursewareCase.WordCreateDate] == DBNull.Value ? null : objRow[conCoursewareCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCoursewareCaseEN.IsVisible = TransNullToBool(objRow[conCoursewareCase.IsVisible].ToString().Trim()); //是否显示
objCoursewareCaseEN.OwnerId = objRow[conCoursewareCase.OwnerId].ToString().Trim(); //拥有者Id
objCoursewareCaseEN.UserKindId = objRow[conCoursewareCase.UserKindId].ToString().Trim(); //用户类别Id
objCoursewareCaseEN.UserTypeId = objRow[conCoursewareCase.UserTypeId] == DBNull.Value ? null : objRow[conCoursewareCase.UserTypeId].ToString().Trim(); //用户类型Id
objCoursewareCaseEN.IsDualVideo = TransNullToBool(objRow[conCoursewareCase.IsDualVideo].ToString().Trim()); //是否双视频
objCoursewareCaseEN.RecommendedDegreeId = objRow[conCoursewareCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCoursewareCaseEN.ftpFileType = objRow[conCoursewareCase.ftpFileType] == DBNull.Value ? null : objRow[conCoursewareCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCoursewareCaseEN.VideoUrl = objRow[conCoursewareCase.VideoUrl] == DBNull.Value ? null : objRow[conCoursewareCase.VideoUrl].ToString().Trim(); //视频Url
objCoursewareCaseEN.VideoPath = objRow[conCoursewareCase.VideoPath] == DBNull.Value ? null : objRow[conCoursewareCase.VideoPath].ToString().Trim(); //视频目录
objCoursewareCaseEN.ResErrMsg = objRow[conCoursewareCase.ResErrMsg] == DBNull.Value ? null : objRow[conCoursewareCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCoursewareCaseEN.UpdDate = objRow[conCoursewareCase.UpdDate] == DBNull.Value ? null : objRow[conCoursewareCase.UpdDate].ToString().Trim(); //修改日期
objCoursewareCaseEN.UpdUserId = objRow[conCoursewareCase.UpdUserId] == DBNull.Value ? null : objRow[conCoursewareCase.UpdUserId].ToString().Trim(); //修改用户Id
objCoursewareCaseEN.Memo = objRow[conCoursewareCase.Memo] == DBNull.Value ? null : objRow[conCoursewareCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCoursewareCaseDA: GetObjLst)", objException.Message));
}
objCoursewareCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCoursewareCaseEN);
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
public List<clsCoursewareCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCoursewareCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsCoursewareCaseEN> arrObjLst = new List<clsCoursewareCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCoursewareCaseEN objCoursewareCaseEN = new clsCoursewareCaseEN();
try
{
objCoursewareCaseEN.IdCoursewareCase = objRow[conCoursewareCase.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objCoursewareCaseEN.CoursewareCaseID = objRow[conCoursewareCase.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objCoursewareCaseEN.CoursewareCaseName = objRow[conCoursewareCase.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objCoursewareCaseEN.CoursewareCaseTheme = objRow[conCoursewareCase.CoursewareCaseTheme] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objCoursewareCaseEN.IdCoursewareCaseType = objRow[conCoursewareCase.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objCoursewareCaseEN.CoursewareCaseText = objRow[conCoursewareCase.CoursewareCaseText] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseText].ToString().Trim(); //案例文本内容
objCoursewareCaseEN.CoursewareCaseDate = objRow[conCoursewareCase.CoursewareCaseDate] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objCoursewareCaseEN.CoursewareCaseTime = objRow[conCoursewareCase.CoursewareCaseTime] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objCoursewareCaseEN.CoursewareCaseDateIn = objRow[conCoursewareCase.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objCoursewareCaseEN.CoursewareCaseTimeIn = objRow[conCoursewareCase.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objCoursewareCaseEN.IdStudyLevel = objRow[conCoursewareCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCoursewareCaseEN.IdTeachingPlan = objRow[conCoursewareCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCoursewareCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCoursewareCaseEN.IdCaseType = objRow[conCoursewareCase.IdCaseType] == DBNull.Value ? null : objRow[conCoursewareCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCoursewareCaseEN.IdDiscipline = objRow[conCoursewareCase.IdDiscipline].ToString().Trim(); //学科流水号
objCoursewareCaseEN.BrowseCount = objRow[conCoursewareCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareCase.BrowseCount].ToString().Trim()); //浏览次数
objCoursewareCaseEN.IdSenateGaugeVersion = objRow[conCoursewareCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCoursewareCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCoursewareCaseEN.IdTeachSkill = objRow[conCoursewareCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCoursewareCaseEN.CaseLevelId = objRow[conCoursewareCase.CaseLevelId] == DBNull.Value ? null : objRow[conCoursewareCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCoursewareCaseEN.DocFile = objRow[conCoursewareCase.DocFile] == DBNull.Value ? null : objRow[conCoursewareCase.DocFile].ToString().Trim(); //生成的Word文件名
objCoursewareCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conCoursewareCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCoursewareCaseEN.WordCreateDate = objRow[conCoursewareCase.WordCreateDate] == DBNull.Value ? null : objRow[conCoursewareCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCoursewareCaseEN.IsVisible = TransNullToBool(objRow[conCoursewareCase.IsVisible].ToString().Trim()); //是否显示
objCoursewareCaseEN.OwnerId = objRow[conCoursewareCase.OwnerId].ToString().Trim(); //拥有者Id
objCoursewareCaseEN.UserKindId = objRow[conCoursewareCase.UserKindId].ToString().Trim(); //用户类别Id
objCoursewareCaseEN.UserTypeId = objRow[conCoursewareCase.UserTypeId] == DBNull.Value ? null : objRow[conCoursewareCase.UserTypeId].ToString().Trim(); //用户类型Id
objCoursewareCaseEN.IsDualVideo = TransNullToBool(objRow[conCoursewareCase.IsDualVideo].ToString().Trim()); //是否双视频
objCoursewareCaseEN.RecommendedDegreeId = objRow[conCoursewareCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCoursewareCaseEN.ftpFileType = objRow[conCoursewareCase.ftpFileType] == DBNull.Value ? null : objRow[conCoursewareCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCoursewareCaseEN.VideoUrl = objRow[conCoursewareCase.VideoUrl] == DBNull.Value ? null : objRow[conCoursewareCase.VideoUrl].ToString().Trim(); //视频Url
objCoursewareCaseEN.VideoPath = objRow[conCoursewareCase.VideoPath] == DBNull.Value ? null : objRow[conCoursewareCase.VideoPath].ToString().Trim(); //视频目录
objCoursewareCaseEN.ResErrMsg = objRow[conCoursewareCase.ResErrMsg] == DBNull.Value ? null : objRow[conCoursewareCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCoursewareCaseEN.UpdDate = objRow[conCoursewareCase.UpdDate] == DBNull.Value ? null : objRow[conCoursewareCase.UpdDate].ToString().Trim(); //修改日期
objCoursewareCaseEN.UpdUserId = objRow[conCoursewareCase.UpdUserId] == DBNull.Value ? null : objRow[conCoursewareCase.UpdUserId].ToString().Trim(); //修改用户Id
objCoursewareCaseEN.Memo = objRow[conCoursewareCase.Memo] == DBNull.Value ? null : objRow[conCoursewareCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCoursewareCaseDA: GetObjLst)", objException.Message));
}
objCoursewareCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCoursewareCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCoursewareCase(ref clsCoursewareCaseEN objCoursewareCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareCase where IdCoursewareCase = " + "'"+ objCoursewareCaseEN.IdCoursewareCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCoursewareCaseEN.IdCoursewareCase = objDT.Rows[0][conCoursewareCase.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareCaseEN.CoursewareCaseID = objDT.Rows[0][conCoursewareCase.CoursewareCaseID].ToString().Trim(); //课件教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareCaseEN.CoursewareCaseName = objDT.Rows[0][conCoursewareCase.CoursewareCaseName].ToString().Trim(); //课件教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objCoursewareCaseEN.CoursewareCaseTheme = objDT.Rows[0][conCoursewareCase.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objCoursewareCaseEN.IdCoursewareCaseType = objDT.Rows[0][conCoursewareCase.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCoursewareCaseEN.CoursewareCaseText = objDT.Rows[0][conCoursewareCase.CoursewareCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objCoursewareCaseEN.CoursewareCaseDate = objDT.Rows[0][conCoursewareCase.CoursewareCaseDate].ToString().Trim(); //课件教学日期(字段类型:char,字段长度:8,是否可空:True)
 objCoursewareCaseEN.CoursewareCaseTime = objDT.Rows[0][conCoursewareCase.CoursewareCaseTime].ToString().Trim(); //课件教学时间(字段类型:char,字段长度:6,是否可空:True)
 objCoursewareCaseEN.CoursewareCaseDateIn = objDT.Rows[0][conCoursewareCase.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objCoursewareCaseEN.CoursewareCaseTimeIn = objDT.Rows[0][conCoursewareCase.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objCoursewareCaseEN.IdStudyLevel = objDT.Rows[0][conCoursewareCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objCoursewareCaseEN.IdTeachingPlan = objDT.Rows[0][conCoursewareCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareCaseEN.IdCaseType = objDT.Rows[0][conCoursewareCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objCoursewareCaseEN.IdDiscipline = objDT.Rows[0][conCoursewareCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objCoursewareCaseEN.BrowseCount = TransNullToInt(objDT.Rows[0][conCoursewareCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objCoursewareCaseEN.IdSenateGaugeVersion = objDT.Rows[0][conCoursewareCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objCoursewareCaseEN.IdTeachSkill = objDT.Rows[0][conCoursewareCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareCaseEN.CaseLevelId = objDT.Rows[0][conCoursewareCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objCoursewareCaseEN.DocFile = objDT.Rows[0][conCoursewareCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objCoursewareCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][conCoursewareCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objCoursewareCaseEN.WordCreateDate = objDT.Rows[0][conCoursewareCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objCoursewareCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][conCoursewareCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objCoursewareCaseEN.OwnerId = objDT.Rows[0][conCoursewareCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objCoursewareCaseEN.UserKindId = objDT.Rows[0][conCoursewareCase.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objCoursewareCaseEN.UserTypeId = objDT.Rows[0][conCoursewareCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objCoursewareCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][conCoursewareCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objCoursewareCaseEN.RecommendedDegreeId = objDT.Rows[0][conCoursewareCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objCoursewareCaseEN.ftpFileType = objDT.Rows[0][conCoursewareCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objCoursewareCaseEN.VideoUrl = objDT.Rows[0][conCoursewareCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objCoursewareCaseEN.VideoPath = objDT.Rows[0][conCoursewareCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objCoursewareCaseEN.ResErrMsg = objDT.Rows[0][conCoursewareCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objCoursewareCaseEN.UpdDate = objDT.Rows[0][conCoursewareCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCoursewareCaseEN.UpdUserId = objDT.Rows[0][conCoursewareCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCoursewareCaseEN.Memo = objDT.Rows[0][conCoursewareCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCoursewareCaseDA: GetCoursewareCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCoursewareCase">表关键字</param>
 /// <returns>表对象</returns>
public clsCoursewareCaseEN GetObjByIdCoursewareCase(string strIdCoursewareCase)
{
CheckPrimaryKey(strIdCoursewareCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareCase where IdCoursewareCase = " + "'"+ strIdCoursewareCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCoursewareCaseEN objCoursewareCaseEN = new clsCoursewareCaseEN();
try
{
 objCoursewareCaseEN.IdCoursewareCase = objRow[conCoursewareCase.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareCaseEN.CoursewareCaseID = objRow[conCoursewareCase.CoursewareCaseID].ToString().Trim(); //课件教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareCaseEN.CoursewareCaseName = objRow[conCoursewareCase.CoursewareCaseName].ToString().Trim(); //课件教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objCoursewareCaseEN.CoursewareCaseTheme = objRow[conCoursewareCase.CoursewareCaseTheme] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objCoursewareCaseEN.IdCoursewareCaseType = objRow[conCoursewareCase.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCoursewareCaseEN.CoursewareCaseText = objRow[conCoursewareCase.CoursewareCaseText] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objCoursewareCaseEN.CoursewareCaseDate = objRow[conCoursewareCase.CoursewareCaseDate] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseDate].ToString().Trim(); //课件教学日期(字段类型:char,字段长度:8,是否可空:True)
 objCoursewareCaseEN.CoursewareCaseTime = objRow[conCoursewareCase.CoursewareCaseTime] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTime].ToString().Trim(); //课件教学时间(字段类型:char,字段长度:6,是否可空:True)
 objCoursewareCaseEN.CoursewareCaseDateIn = objRow[conCoursewareCase.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objCoursewareCaseEN.CoursewareCaseTimeIn = objRow[conCoursewareCase.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objCoursewareCaseEN.IdStudyLevel = objRow[conCoursewareCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objCoursewareCaseEN.IdTeachingPlan = objRow[conCoursewareCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCoursewareCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareCaseEN.IdCaseType = objRow[conCoursewareCase.IdCaseType] == DBNull.Value ? null : objRow[conCoursewareCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objCoursewareCaseEN.IdDiscipline = objRow[conCoursewareCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objCoursewareCaseEN.BrowseCount = objRow[conCoursewareCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCoursewareCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objCoursewareCaseEN.IdSenateGaugeVersion = objRow[conCoursewareCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCoursewareCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objCoursewareCaseEN.IdTeachSkill = objRow[conCoursewareCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareCaseEN.CaseLevelId = objRow[conCoursewareCase.CaseLevelId] == DBNull.Value ? null : objRow[conCoursewareCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objCoursewareCaseEN.DocFile = objRow[conCoursewareCase.DocFile] == DBNull.Value ? null : objRow[conCoursewareCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objCoursewareCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCoursewareCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objCoursewareCaseEN.WordCreateDate = objRow[conCoursewareCase.WordCreateDate] == DBNull.Value ? null : objRow[conCoursewareCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objCoursewareCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCoursewareCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objCoursewareCaseEN.OwnerId = objRow[conCoursewareCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objCoursewareCaseEN.UserKindId = objRow[conCoursewareCase.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objCoursewareCaseEN.UserTypeId = objRow[conCoursewareCase.UserTypeId] == DBNull.Value ? null : objRow[conCoursewareCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objCoursewareCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCoursewareCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objCoursewareCaseEN.RecommendedDegreeId = objRow[conCoursewareCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objCoursewareCaseEN.ftpFileType = objRow[conCoursewareCase.ftpFileType] == DBNull.Value ? null : objRow[conCoursewareCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objCoursewareCaseEN.VideoUrl = objRow[conCoursewareCase.VideoUrl] == DBNull.Value ? null : objRow[conCoursewareCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objCoursewareCaseEN.VideoPath = objRow[conCoursewareCase.VideoPath] == DBNull.Value ? null : objRow[conCoursewareCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objCoursewareCaseEN.ResErrMsg = objRow[conCoursewareCase.ResErrMsg] == DBNull.Value ? null : objRow[conCoursewareCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objCoursewareCaseEN.UpdDate = objRow[conCoursewareCase.UpdDate] == DBNull.Value ? null : objRow[conCoursewareCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCoursewareCaseEN.UpdUserId = objRow[conCoursewareCase.UpdUserId] == DBNull.Value ? null : objRow[conCoursewareCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCoursewareCaseEN.Memo = objRow[conCoursewareCase.Memo] == DBNull.Value ? null : objRow[conCoursewareCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCoursewareCaseDA: GetObjByIdCoursewareCase)", objException.Message));
}
return objCoursewareCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCoursewareCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCoursewareCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCoursewareCaseEN objCoursewareCaseEN = new clsCoursewareCaseEN()
{
IdCoursewareCase = objRow[conCoursewareCase.IdCoursewareCase].ToString().Trim(), //课件教学案例流水号
CoursewareCaseID = objRow[conCoursewareCase.CoursewareCaseID].ToString().Trim(), //课件教学案例ID
CoursewareCaseName = objRow[conCoursewareCase.CoursewareCaseName].ToString().Trim(), //课件教学案例名称
CoursewareCaseTheme = objRow[conCoursewareCase.CoursewareCaseTheme] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTheme].ToString().Trim(), //课件教学案例主题词
IdCoursewareCaseType = objRow[conCoursewareCase.IdCoursewareCaseType].ToString().Trim(), //课件案例类型流水号
CoursewareCaseText = objRow[conCoursewareCase.CoursewareCaseText] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseText].ToString().Trim(), //案例文本内容
CoursewareCaseDate = objRow[conCoursewareCase.CoursewareCaseDate] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseDate].ToString().Trim(), //课件教学日期
CoursewareCaseTime = objRow[conCoursewareCase.CoursewareCaseTime] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTime].ToString().Trim(), //课件教学时间
CoursewareCaseDateIn = objRow[conCoursewareCase.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseDateIn].ToString().Trim(), //案例入库日期
CoursewareCaseTimeIn = objRow[conCoursewareCase.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTimeIn].ToString().Trim(), //案例入库时间
IdStudyLevel = objRow[conCoursewareCase.IdStudyLevel].ToString().Trim(), //学段流水号
IdTeachingPlan = objRow[conCoursewareCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCoursewareCase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdCaseType = objRow[conCoursewareCase.IdCaseType] == DBNull.Value ? null : objRow[conCoursewareCase.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[conCoursewareCase.IdDiscipline].ToString().Trim(), //学科流水号
BrowseCount = objRow[conCoursewareCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareCase.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[conCoursewareCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCoursewareCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
IdTeachSkill = objRow[conCoursewareCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
CaseLevelId = objRow[conCoursewareCase.CaseLevelId] == DBNull.Value ? null : objRow[conCoursewareCase.CaseLevelId].ToString().Trim(), //课例等级Id
DocFile = objRow[conCoursewareCase.DocFile] == DBNull.Value ? null : objRow[conCoursewareCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[conCoursewareCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[conCoursewareCase.WordCreateDate] == DBNull.Value ? null : objRow[conCoursewareCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[conCoursewareCase.IsVisible].ToString().Trim()), //是否显示
OwnerId = objRow[conCoursewareCase.OwnerId].ToString().Trim(), //拥有者Id
UserKindId = objRow[conCoursewareCase.UserKindId].ToString().Trim(), //用户类别Id
UserTypeId = objRow[conCoursewareCase.UserTypeId] == DBNull.Value ? null : objRow[conCoursewareCase.UserTypeId].ToString().Trim(), //用户类型Id
IsDualVideo = TransNullToBool(objRow[conCoursewareCase.IsDualVideo].ToString().Trim()), //是否双视频
RecommendedDegreeId = objRow[conCoursewareCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
ftpFileType = objRow[conCoursewareCase.ftpFileType] == DBNull.Value ? null : objRow[conCoursewareCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[conCoursewareCase.VideoUrl] == DBNull.Value ? null : objRow[conCoursewareCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[conCoursewareCase.VideoPath] == DBNull.Value ? null : objRow[conCoursewareCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[conCoursewareCase.ResErrMsg] == DBNull.Value ? null : objRow[conCoursewareCase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdDate = objRow[conCoursewareCase.UpdDate] == DBNull.Value ? null : objRow[conCoursewareCase.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conCoursewareCase.UpdUserId] == DBNull.Value ? null : objRow[conCoursewareCase.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conCoursewareCase.Memo] == DBNull.Value ? null : objRow[conCoursewareCase.Memo].ToString().Trim() //备注
};
objCoursewareCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCoursewareCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCoursewareCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCoursewareCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCoursewareCaseEN objCoursewareCaseEN = new clsCoursewareCaseEN();
try
{
objCoursewareCaseEN.IdCoursewareCase = objRow[conCoursewareCase.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objCoursewareCaseEN.CoursewareCaseID = objRow[conCoursewareCase.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objCoursewareCaseEN.CoursewareCaseName = objRow[conCoursewareCase.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objCoursewareCaseEN.CoursewareCaseTheme = objRow[conCoursewareCase.CoursewareCaseTheme] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objCoursewareCaseEN.IdCoursewareCaseType = objRow[conCoursewareCase.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objCoursewareCaseEN.CoursewareCaseText = objRow[conCoursewareCase.CoursewareCaseText] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseText].ToString().Trim(); //案例文本内容
objCoursewareCaseEN.CoursewareCaseDate = objRow[conCoursewareCase.CoursewareCaseDate] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objCoursewareCaseEN.CoursewareCaseTime = objRow[conCoursewareCase.CoursewareCaseTime] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objCoursewareCaseEN.CoursewareCaseDateIn = objRow[conCoursewareCase.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objCoursewareCaseEN.CoursewareCaseTimeIn = objRow[conCoursewareCase.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objCoursewareCaseEN.IdStudyLevel = objRow[conCoursewareCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCoursewareCaseEN.IdTeachingPlan = objRow[conCoursewareCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCoursewareCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCoursewareCaseEN.IdCaseType = objRow[conCoursewareCase.IdCaseType] == DBNull.Value ? null : objRow[conCoursewareCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCoursewareCaseEN.IdDiscipline = objRow[conCoursewareCase.IdDiscipline].ToString().Trim(); //学科流水号
objCoursewareCaseEN.BrowseCount = objRow[conCoursewareCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareCase.BrowseCount].ToString().Trim()); //浏览次数
objCoursewareCaseEN.IdSenateGaugeVersion = objRow[conCoursewareCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCoursewareCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCoursewareCaseEN.IdTeachSkill = objRow[conCoursewareCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCoursewareCaseEN.CaseLevelId = objRow[conCoursewareCase.CaseLevelId] == DBNull.Value ? null : objRow[conCoursewareCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCoursewareCaseEN.DocFile = objRow[conCoursewareCase.DocFile] == DBNull.Value ? null : objRow[conCoursewareCase.DocFile].ToString().Trim(); //生成的Word文件名
objCoursewareCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conCoursewareCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCoursewareCaseEN.WordCreateDate = objRow[conCoursewareCase.WordCreateDate] == DBNull.Value ? null : objRow[conCoursewareCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCoursewareCaseEN.IsVisible = TransNullToBool(objRow[conCoursewareCase.IsVisible].ToString().Trim()); //是否显示
objCoursewareCaseEN.OwnerId = objRow[conCoursewareCase.OwnerId].ToString().Trim(); //拥有者Id
objCoursewareCaseEN.UserKindId = objRow[conCoursewareCase.UserKindId].ToString().Trim(); //用户类别Id
objCoursewareCaseEN.UserTypeId = objRow[conCoursewareCase.UserTypeId] == DBNull.Value ? null : objRow[conCoursewareCase.UserTypeId].ToString().Trim(); //用户类型Id
objCoursewareCaseEN.IsDualVideo = TransNullToBool(objRow[conCoursewareCase.IsDualVideo].ToString().Trim()); //是否双视频
objCoursewareCaseEN.RecommendedDegreeId = objRow[conCoursewareCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCoursewareCaseEN.ftpFileType = objRow[conCoursewareCase.ftpFileType] == DBNull.Value ? null : objRow[conCoursewareCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCoursewareCaseEN.VideoUrl = objRow[conCoursewareCase.VideoUrl] == DBNull.Value ? null : objRow[conCoursewareCase.VideoUrl].ToString().Trim(); //视频Url
objCoursewareCaseEN.VideoPath = objRow[conCoursewareCase.VideoPath] == DBNull.Value ? null : objRow[conCoursewareCase.VideoPath].ToString().Trim(); //视频目录
objCoursewareCaseEN.ResErrMsg = objRow[conCoursewareCase.ResErrMsg] == DBNull.Value ? null : objRow[conCoursewareCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCoursewareCaseEN.UpdDate = objRow[conCoursewareCase.UpdDate] == DBNull.Value ? null : objRow[conCoursewareCase.UpdDate].ToString().Trim(); //修改日期
objCoursewareCaseEN.UpdUserId = objRow[conCoursewareCase.UpdUserId] == DBNull.Value ? null : objRow[conCoursewareCase.UpdUserId].ToString().Trim(); //修改用户Id
objCoursewareCaseEN.Memo = objRow[conCoursewareCase.Memo] == DBNull.Value ? null : objRow[conCoursewareCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCoursewareCaseDA: GetObjByDataRowCoursewareCase)", objException.Message));
}
objCoursewareCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCoursewareCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCoursewareCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCoursewareCaseEN objCoursewareCaseEN = new clsCoursewareCaseEN();
try
{
objCoursewareCaseEN.IdCoursewareCase = objRow[conCoursewareCase.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objCoursewareCaseEN.CoursewareCaseID = objRow[conCoursewareCase.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objCoursewareCaseEN.CoursewareCaseName = objRow[conCoursewareCase.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objCoursewareCaseEN.CoursewareCaseTheme = objRow[conCoursewareCase.CoursewareCaseTheme] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objCoursewareCaseEN.IdCoursewareCaseType = objRow[conCoursewareCase.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objCoursewareCaseEN.CoursewareCaseText = objRow[conCoursewareCase.CoursewareCaseText] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseText].ToString().Trim(); //案例文本内容
objCoursewareCaseEN.CoursewareCaseDate = objRow[conCoursewareCase.CoursewareCaseDate] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objCoursewareCaseEN.CoursewareCaseTime = objRow[conCoursewareCase.CoursewareCaseTime] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objCoursewareCaseEN.CoursewareCaseDateIn = objRow[conCoursewareCase.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objCoursewareCaseEN.CoursewareCaseTimeIn = objRow[conCoursewareCase.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[conCoursewareCase.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objCoursewareCaseEN.IdStudyLevel = objRow[conCoursewareCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCoursewareCaseEN.IdTeachingPlan = objRow[conCoursewareCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCoursewareCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCoursewareCaseEN.IdCaseType = objRow[conCoursewareCase.IdCaseType] == DBNull.Value ? null : objRow[conCoursewareCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCoursewareCaseEN.IdDiscipline = objRow[conCoursewareCase.IdDiscipline].ToString().Trim(); //学科流水号
objCoursewareCaseEN.BrowseCount = objRow[conCoursewareCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareCase.BrowseCount].ToString().Trim()); //浏览次数
objCoursewareCaseEN.IdSenateGaugeVersion = objRow[conCoursewareCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCoursewareCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCoursewareCaseEN.IdTeachSkill = objRow[conCoursewareCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCoursewareCaseEN.CaseLevelId = objRow[conCoursewareCase.CaseLevelId] == DBNull.Value ? null : objRow[conCoursewareCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCoursewareCaseEN.DocFile = objRow[conCoursewareCase.DocFile] == DBNull.Value ? null : objRow[conCoursewareCase.DocFile].ToString().Trim(); //生成的Word文件名
objCoursewareCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conCoursewareCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCoursewareCaseEN.WordCreateDate = objRow[conCoursewareCase.WordCreateDate] == DBNull.Value ? null : objRow[conCoursewareCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCoursewareCaseEN.IsVisible = TransNullToBool(objRow[conCoursewareCase.IsVisible].ToString().Trim()); //是否显示
objCoursewareCaseEN.OwnerId = objRow[conCoursewareCase.OwnerId].ToString().Trim(); //拥有者Id
objCoursewareCaseEN.UserKindId = objRow[conCoursewareCase.UserKindId].ToString().Trim(); //用户类别Id
objCoursewareCaseEN.UserTypeId = objRow[conCoursewareCase.UserTypeId] == DBNull.Value ? null : objRow[conCoursewareCase.UserTypeId].ToString().Trim(); //用户类型Id
objCoursewareCaseEN.IsDualVideo = TransNullToBool(objRow[conCoursewareCase.IsDualVideo].ToString().Trim()); //是否双视频
objCoursewareCaseEN.RecommendedDegreeId = objRow[conCoursewareCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCoursewareCaseEN.ftpFileType = objRow[conCoursewareCase.ftpFileType] == DBNull.Value ? null : objRow[conCoursewareCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCoursewareCaseEN.VideoUrl = objRow[conCoursewareCase.VideoUrl] == DBNull.Value ? null : objRow[conCoursewareCase.VideoUrl].ToString().Trim(); //视频Url
objCoursewareCaseEN.VideoPath = objRow[conCoursewareCase.VideoPath] == DBNull.Value ? null : objRow[conCoursewareCase.VideoPath].ToString().Trim(); //视频目录
objCoursewareCaseEN.ResErrMsg = objRow[conCoursewareCase.ResErrMsg] == DBNull.Value ? null : objRow[conCoursewareCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCoursewareCaseEN.UpdDate = objRow[conCoursewareCase.UpdDate] == DBNull.Value ? null : objRow[conCoursewareCase.UpdDate].ToString().Trim(); //修改日期
objCoursewareCaseEN.UpdUserId = objRow[conCoursewareCase.UpdUserId] == DBNull.Value ? null : objRow[conCoursewareCase.UpdUserId].ToString().Trim(); //修改用户Id
objCoursewareCaseEN.Memo = objRow[conCoursewareCase.Memo] == DBNull.Value ? null : objRow[conCoursewareCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCoursewareCaseDA: GetObjByDataRow)", objException.Message));
}
objCoursewareCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCoursewareCaseEN;
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
objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCoursewareCaseEN._CurrTabName, conCoursewareCase.IdCoursewareCase, 8, "");
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
objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCoursewareCaseEN._CurrTabName, conCoursewareCase.IdCoursewareCase, 8, strPrefix);
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
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCoursewareCase from CoursewareCase where " + strCondition;
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
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCoursewareCase from CoursewareCase where " + strCondition;
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
 /// <param name = "strIdCoursewareCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdCoursewareCase)
{
CheckPrimaryKey(strIdCoursewareCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CoursewareCase", "IdCoursewareCase = " + "'"+ strIdCoursewareCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCoursewareCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CoursewareCase", strCondition))
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
objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CoursewareCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCoursewareCaseEN objCoursewareCaseEN)
 {
 objCoursewareCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCoursewareCaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareCase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CoursewareCase");
objRow = objDS.Tables["CoursewareCase"].NewRow();
objRow[conCoursewareCase.IdCoursewareCase] = objCoursewareCaseEN.IdCoursewareCase; //课件教学案例流水号
objRow[conCoursewareCase.CoursewareCaseID] = objCoursewareCaseEN.CoursewareCaseID; //课件教学案例ID
objRow[conCoursewareCase.CoursewareCaseName] = objCoursewareCaseEN.CoursewareCaseName; //课件教学案例名称
 if (objCoursewareCaseEN.CoursewareCaseTheme !=  "")
 {
objRow[conCoursewareCase.CoursewareCaseTheme] = objCoursewareCaseEN.CoursewareCaseTheme; //课件教学案例主题词
 }
objRow[conCoursewareCase.IdCoursewareCaseType] = objCoursewareCaseEN.IdCoursewareCaseType; //课件案例类型流水号
 if (objCoursewareCaseEN.CoursewareCaseText !=  "")
 {
objRow[conCoursewareCase.CoursewareCaseText] = objCoursewareCaseEN.CoursewareCaseText; //案例文本内容
 }
 if (objCoursewareCaseEN.CoursewareCaseDate !=  "")
 {
objRow[conCoursewareCase.CoursewareCaseDate] = objCoursewareCaseEN.CoursewareCaseDate; //课件教学日期
 }
 if (objCoursewareCaseEN.CoursewareCaseTime !=  "")
 {
objRow[conCoursewareCase.CoursewareCaseTime] = objCoursewareCaseEN.CoursewareCaseTime; //课件教学时间
 }
 if (objCoursewareCaseEN.CoursewareCaseDateIn !=  "")
 {
objRow[conCoursewareCase.CoursewareCaseDateIn] = objCoursewareCaseEN.CoursewareCaseDateIn; //案例入库日期
 }
 if (objCoursewareCaseEN.CoursewareCaseTimeIn !=  "")
 {
objRow[conCoursewareCase.CoursewareCaseTimeIn] = objCoursewareCaseEN.CoursewareCaseTimeIn; //案例入库时间
 }
objRow[conCoursewareCase.IdStudyLevel] = objCoursewareCaseEN.IdStudyLevel; //学段流水号
 if (objCoursewareCaseEN.IdTeachingPlan !=  "")
 {
objRow[conCoursewareCase.IdTeachingPlan] = objCoursewareCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objCoursewareCaseEN.IdCaseType !=  "")
 {
objRow[conCoursewareCase.IdCaseType] = objCoursewareCaseEN.IdCaseType; //案例类型流水号
 }
objRow[conCoursewareCase.IdDiscipline] = objCoursewareCaseEN.IdDiscipline; //学科流水号
objRow[conCoursewareCase.BrowseCount] = objCoursewareCaseEN.BrowseCount; //浏览次数
 if (objCoursewareCaseEN.IdSenateGaugeVersion !=  "")
 {
objRow[conCoursewareCase.IdSenateGaugeVersion] = objCoursewareCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
objRow[conCoursewareCase.IdTeachSkill] = objCoursewareCaseEN.IdTeachSkill; //教学技能流水号
 if (objCoursewareCaseEN.CaseLevelId !=  "")
 {
objRow[conCoursewareCase.CaseLevelId] = objCoursewareCaseEN.CaseLevelId; //课例等级Id
 }
 if (objCoursewareCaseEN.DocFile !=  "")
 {
objRow[conCoursewareCase.DocFile] = objCoursewareCaseEN.DocFile; //生成的Word文件名
 }
objRow[conCoursewareCase.IsNeedGeneWord] = objCoursewareCaseEN.IsNeedGeneWord; //是否需要生成Word
 if (objCoursewareCaseEN.WordCreateDate !=  "")
 {
objRow[conCoursewareCase.WordCreateDate] = objCoursewareCaseEN.WordCreateDate; //Word生成日期
 }
objRow[conCoursewareCase.IsVisible] = objCoursewareCaseEN.IsVisible; //是否显示
objRow[conCoursewareCase.OwnerId] = objCoursewareCaseEN.OwnerId; //拥有者Id
objRow[conCoursewareCase.UserKindId] = objCoursewareCaseEN.UserKindId; //用户类别Id
 if (objCoursewareCaseEN.UserTypeId !=  "")
 {
objRow[conCoursewareCase.UserTypeId] = objCoursewareCaseEN.UserTypeId; //用户类型Id
 }
objRow[conCoursewareCase.IsDualVideo] = objCoursewareCaseEN.IsDualVideo; //是否双视频
objRow[conCoursewareCase.RecommendedDegreeId] = objCoursewareCaseEN.RecommendedDegreeId; //推荐度Id
 if (objCoursewareCaseEN.ftpFileType !=  "")
 {
objRow[conCoursewareCase.ftpFileType] = objCoursewareCaseEN.ftpFileType; //ftp文件类型
 }
 if (objCoursewareCaseEN.VideoUrl !=  "")
 {
objRow[conCoursewareCase.VideoUrl] = objCoursewareCaseEN.VideoUrl; //视频Url
 }
 if (objCoursewareCaseEN.VideoPath !=  "")
 {
objRow[conCoursewareCase.VideoPath] = objCoursewareCaseEN.VideoPath; //视频目录
 }
 if (objCoursewareCaseEN.ResErrMsg !=  "")
 {
objRow[conCoursewareCase.ResErrMsg] = objCoursewareCaseEN.ResErrMsg; //资源错误信息
 }
 if (objCoursewareCaseEN.UpdDate !=  "")
 {
objRow[conCoursewareCase.UpdDate] = objCoursewareCaseEN.UpdDate; //修改日期
 }
 if (objCoursewareCaseEN.UpdUserId !=  "")
 {
objRow[conCoursewareCase.UpdUserId] = objCoursewareCaseEN.UpdUserId; //修改用户Id
 }
 if (objCoursewareCaseEN.Memo !=  "")
 {
objRow[conCoursewareCase.Memo] = objCoursewareCaseEN.Memo; //备注
 }
objDS.Tables[clsCoursewareCaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCoursewareCaseEN._CurrTabName);
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
 /// <param name = "objCoursewareCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCoursewareCaseEN objCoursewareCaseEN)
{
 objCoursewareCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCoursewareCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCoursewareCaseEN.IdCoursewareCase !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdCoursewareCase);
 var strIdCoursewareCase = objCoursewareCaseEN.IdCoursewareCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCoursewareCase + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseID !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseID);
 var strCoursewareCaseID = objCoursewareCaseEN.CoursewareCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseID + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseName !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseName);
 var strCoursewareCaseName = objCoursewareCaseEN.CoursewareCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseName + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseTheme);
 var strCoursewareCaseTheme = objCoursewareCaseEN.CoursewareCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseTheme + "'");
 }
 
 if (objCoursewareCaseEN.IdCoursewareCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdCoursewareCaseType);
 var strIdCoursewareCaseType = objCoursewareCaseEN.IdCoursewareCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCoursewareCaseType + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseText !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseText);
 var strCoursewareCaseText = objCoursewareCaseEN.CoursewareCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseText + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseDate);
 var strCoursewareCaseDate = objCoursewareCaseEN.CoursewareCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseDate + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseTime);
 var strCoursewareCaseTime = objCoursewareCaseEN.CoursewareCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseTime + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseDateIn);
 var strCoursewareCaseDateIn = objCoursewareCaseEN.CoursewareCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseDateIn + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseTimeIn);
 var strCoursewareCaseTimeIn = objCoursewareCaseEN.CoursewareCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseTimeIn + "'");
 }
 
 if (objCoursewareCaseEN.IdStudyLevel  ==  "")
 {
 objCoursewareCaseEN.IdStudyLevel = null;
 }
 if (objCoursewareCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdStudyLevel);
 var strIdStudyLevel = objCoursewareCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objCoursewareCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdTeachingPlan);
 var strIdTeachingPlan = objCoursewareCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objCoursewareCaseEN.IdCaseType  ==  "")
 {
 objCoursewareCaseEN.IdCaseType = null;
 }
 if (objCoursewareCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdCaseType);
 var strIdCaseType = objCoursewareCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objCoursewareCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdDiscipline);
 var strIdDiscipline = objCoursewareCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objCoursewareCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.BrowseCount);
 arrValueListForInsert.Add(objCoursewareCaseEN.BrowseCount.ToString());
 }
 
 if (objCoursewareCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCoursewareCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCoursewareCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objCoursewareCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objCoursewareCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdTeachSkill);
 var strIdTeachSkill = objCoursewareCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objCoursewareCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CaseLevelId);
 var strCaseLevelId = objCoursewareCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objCoursewareCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.DocFile);
 var strDocFile = objCoursewareCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objCoursewareCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.WordCreateDate);
 var strWordCreateDate = objCoursewareCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareCase.IsVisible);
 arrValueListForInsert.Add("'" + (objCoursewareCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.OwnerId);
 var strOwnerId = objCoursewareCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCoursewareCaseEN.UserKindId  ==  "")
 {
 objCoursewareCaseEN.UserKindId = null;
 }
 if (objCoursewareCaseEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.UserKindId);
 var strUserKindId = objCoursewareCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objCoursewareCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.UserTypeId);
 var strUserTypeId = objCoursewareCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objCoursewareCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objCoursewareCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objCoursewareCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.ftpFileType);
 var strftpFileType = objCoursewareCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objCoursewareCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.VideoUrl);
 var strVideoUrl = objCoursewareCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objCoursewareCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.VideoPath);
 var strVideoPath = objCoursewareCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objCoursewareCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.ResErrMsg);
 var strResErrMsg = objCoursewareCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objCoursewareCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.UpdDate);
 var strUpdDate = objCoursewareCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCoursewareCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.UpdUserId);
 var strUpdUserId = objCoursewareCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCoursewareCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.Memo);
 var strMemo = objCoursewareCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CoursewareCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCoursewareCaseEN objCoursewareCaseEN)
{
 objCoursewareCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCoursewareCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCoursewareCaseEN.IdCoursewareCase !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdCoursewareCase);
 var strIdCoursewareCase = objCoursewareCaseEN.IdCoursewareCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCoursewareCase + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseID !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseID);
 var strCoursewareCaseID = objCoursewareCaseEN.CoursewareCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseID + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseName !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseName);
 var strCoursewareCaseName = objCoursewareCaseEN.CoursewareCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseName + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseTheme);
 var strCoursewareCaseTheme = objCoursewareCaseEN.CoursewareCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseTheme + "'");
 }
 
 if (objCoursewareCaseEN.IdCoursewareCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdCoursewareCaseType);
 var strIdCoursewareCaseType = objCoursewareCaseEN.IdCoursewareCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCoursewareCaseType + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseText !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseText);
 var strCoursewareCaseText = objCoursewareCaseEN.CoursewareCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseText + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseDate);
 var strCoursewareCaseDate = objCoursewareCaseEN.CoursewareCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseDate + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseTime);
 var strCoursewareCaseTime = objCoursewareCaseEN.CoursewareCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseTime + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseDateIn);
 var strCoursewareCaseDateIn = objCoursewareCaseEN.CoursewareCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseDateIn + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseTimeIn);
 var strCoursewareCaseTimeIn = objCoursewareCaseEN.CoursewareCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseTimeIn + "'");
 }
 
 if (objCoursewareCaseEN.IdStudyLevel  ==  "")
 {
 objCoursewareCaseEN.IdStudyLevel = null;
 }
 if (objCoursewareCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdStudyLevel);
 var strIdStudyLevel = objCoursewareCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objCoursewareCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdTeachingPlan);
 var strIdTeachingPlan = objCoursewareCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objCoursewareCaseEN.IdCaseType  ==  "")
 {
 objCoursewareCaseEN.IdCaseType = null;
 }
 if (objCoursewareCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdCaseType);
 var strIdCaseType = objCoursewareCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objCoursewareCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdDiscipline);
 var strIdDiscipline = objCoursewareCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objCoursewareCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.BrowseCount);
 arrValueListForInsert.Add(objCoursewareCaseEN.BrowseCount.ToString());
 }
 
 if (objCoursewareCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCoursewareCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCoursewareCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objCoursewareCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objCoursewareCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdTeachSkill);
 var strIdTeachSkill = objCoursewareCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objCoursewareCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CaseLevelId);
 var strCaseLevelId = objCoursewareCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objCoursewareCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.DocFile);
 var strDocFile = objCoursewareCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objCoursewareCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.WordCreateDate);
 var strWordCreateDate = objCoursewareCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareCase.IsVisible);
 arrValueListForInsert.Add("'" + (objCoursewareCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.OwnerId);
 var strOwnerId = objCoursewareCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCoursewareCaseEN.UserKindId  ==  "")
 {
 objCoursewareCaseEN.UserKindId = null;
 }
 if (objCoursewareCaseEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.UserKindId);
 var strUserKindId = objCoursewareCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objCoursewareCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.UserTypeId);
 var strUserTypeId = objCoursewareCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objCoursewareCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objCoursewareCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objCoursewareCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.ftpFileType);
 var strftpFileType = objCoursewareCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objCoursewareCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.VideoUrl);
 var strVideoUrl = objCoursewareCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objCoursewareCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.VideoPath);
 var strVideoPath = objCoursewareCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objCoursewareCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.ResErrMsg);
 var strResErrMsg = objCoursewareCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objCoursewareCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.UpdDate);
 var strUpdDate = objCoursewareCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCoursewareCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.UpdUserId);
 var strUpdUserId = objCoursewareCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCoursewareCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.Memo);
 var strMemo = objCoursewareCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CoursewareCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCoursewareCaseEN.IdCoursewareCase;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCoursewareCaseEN objCoursewareCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCoursewareCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCoursewareCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCoursewareCaseEN.IdCoursewareCase !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdCoursewareCase);
 var strIdCoursewareCase = objCoursewareCaseEN.IdCoursewareCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCoursewareCase + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseID !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseID);
 var strCoursewareCaseID = objCoursewareCaseEN.CoursewareCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseID + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseName !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseName);
 var strCoursewareCaseName = objCoursewareCaseEN.CoursewareCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseName + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseTheme);
 var strCoursewareCaseTheme = objCoursewareCaseEN.CoursewareCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseTheme + "'");
 }
 
 if (objCoursewareCaseEN.IdCoursewareCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdCoursewareCaseType);
 var strIdCoursewareCaseType = objCoursewareCaseEN.IdCoursewareCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCoursewareCaseType + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseText !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseText);
 var strCoursewareCaseText = objCoursewareCaseEN.CoursewareCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseText + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseDate);
 var strCoursewareCaseDate = objCoursewareCaseEN.CoursewareCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseDate + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseTime);
 var strCoursewareCaseTime = objCoursewareCaseEN.CoursewareCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseTime + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseDateIn);
 var strCoursewareCaseDateIn = objCoursewareCaseEN.CoursewareCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseDateIn + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseTimeIn);
 var strCoursewareCaseTimeIn = objCoursewareCaseEN.CoursewareCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseTimeIn + "'");
 }
 
 if (objCoursewareCaseEN.IdStudyLevel  ==  "")
 {
 objCoursewareCaseEN.IdStudyLevel = null;
 }
 if (objCoursewareCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdStudyLevel);
 var strIdStudyLevel = objCoursewareCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objCoursewareCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdTeachingPlan);
 var strIdTeachingPlan = objCoursewareCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objCoursewareCaseEN.IdCaseType  ==  "")
 {
 objCoursewareCaseEN.IdCaseType = null;
 }
 if (objCoursewareCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdCaseType);
 var strIdCaseType = objCoursewareCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objCoursewareCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdDiscipline);
 var strIdDiscipline = objCoursewareCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objCoursewareCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.BrowseCount);
 arrValueListForInsert.Add(objCoursewareCaseEN.BrowseCount.ToString());
 }
 
 if (objCoursewareCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCoursewareCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCoursewareCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objCoursewareCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objCoursewareCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdTeachSkill);
 var strIdTeachSkill = objCoursewareCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objCoursewareCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CaseLevelId);
 var strCaseLevelId = objCoursewareCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objCoursewareCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.DocFile);
 var strDocFile = objCoursewareCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objCoursewareCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.WordCreateDate);
 var strWordCreateDate = objCoursewareCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareCase.IsVisible);
 arrValueListForInsert.Add("'" + (objCoursewareCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.OwnerId);
 var strOwnerId = objCoursewareCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCoursewareCaseEN.UserKindId  ==  "")
 {
 objCoursewareCaseEN.UserKindId = null;
 }
 if (objCoursewareCaseEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.UserKindId);
 var strUserKindId = objCoursewareCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objCoursewareCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.UserTypeId);
 var strUserTypeId = objCoursewareCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objCoursewareCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objCoursewareCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objCoursewareCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.ftpFileType);
 var strftpFileType = objCoursewareCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objCoursewareCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.VideoUrl);
 var strVideoUrl = objCoursewareCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objCoursewareCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.VideoPath);
 var strVideoPath = objCoursewareCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objCoursewareCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.ResErrMsg);
 var strResErrMsg = objCoursewareCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objCoursewareCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.UpdDate);
 var strUpdDate = objCoursewareCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCoursewareCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.UpdUserId);
 var strUpdUserId = objCoursewareCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCoursewareCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.Memo);
 var strMemo = objCoursewareCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CoursewareCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCoursewareCaseEN.IdCoursewareCase;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCoursewareCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCoursewareCaseEN objCoursewareCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCoursewareCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCoursewareCaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCoursewareCaseEN.IdCoursewareCase !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdCoursewareCase);
 var strIdCoursewareCase = objCoursewareCaseEN.IdCoursewareCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCoursewareCase + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseID !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseID);
 var strCoursewareCaseID = objCoursewareCaseEN.CoursewareCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseID + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseName !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseName);
 var strCoursewareCaseName = objCoursewareCaseEN.CoursewareCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseName + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseTheme);
 var strCoursewareCaseTheme = objCoursewareCaseEN.CoursewareCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseTheme + "'");
 }
 
 if (objCoursewareCaseEN.IdCoursewareCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdCoursewareCaseType);
 var strIdCoursewareCaseType = objCoursewareCaseEN.IdCoursewareCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCoursewareCaseType + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseText !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseText);
 var strCoursewareCaseText = objCoursewareCaseEN.CoursewareCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseText + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseDate);
 var strCoursewareCaseDate = objCoursewareCaseEN.CoursewareCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseDate + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseTime);
 var strCoursewareCaseTime = objCoursewareCaseEN.CoursewareCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseTime + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseDateIn);
 var strCoursewareCaseDateIn = objCoursewareCaseEN.CoursewareCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseDateIn + "'");
 }
 
 if (objCoursewareCaseEN.CoursewareCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CoursewareCaseTimeIn);
 var strCoursewareCaseTimeIn = objCoursewareCaseEN.CoursewareCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareCaseTimeIn + "'");
 }
 
 if (objCoursewareCaseEN.IdStudyLevel  ==  "")
 {
 objCoursewareCaseEN.IdStudyLevel = null;
 }
 if (objCoursewareCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdStudyLevel);
 var strIdStudyLevel = objCoursewareCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objCoursewareCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdTeachingPlan);
 var strIdTeachingPlan = objCoursewareCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objCoursewareCaseEN.IdCaseType  ==  "")
 {
 objCoursewareCaseEN.IdCaseType = null;
 }
 if (objCoursewareCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdCaseType);
 var strIdCaseType = objCoursewareCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objCoursewareCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdDiscipline);
 var strIdDiscipline = objCoursewareCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objCoursewareCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.BrowseCount);
 arrValueListForInsert.Add(objCoursewareCaseEN.BrowseCount.ToString());
 }
 
 if (objCoursewareCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCoursewareCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCoursewareCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objCoursewareCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objCoursewareCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.IdTeachSkill);
 var strIdTeachSkill = objCoursewareCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objCoursewareCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.CaseLevelId);
 var strCaseLevelId = objCoursewareCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objCoursewareCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.DocFile);
 var strDocFile = objCoursewareCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objCoursewareCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.WordCreateDate);
 var strWordCreateDate = objCoursewareCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareCase.IsVisible);
 arrValueListForInsert.Add("'" + (objCoursewareCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.OwnerId);
 var strOwnerId = objCoursewareCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCoursewareCaseEN.UserKindId  ==  "")
 {
 objCoursewareCaseEN.UserKindId = null;
 }
 if (objCoursewareCaseEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.UserKindId);
 var strUserKindId = objCoursewareCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objCoursewareCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.UserTypeId);
 var strUserTypeId = objCoursewareCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objCoursewareCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objCoursewareCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objCoursewareCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.ftpFileType);
 var strftpFileType = objCoursewareCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objCoursewareCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.VideoUrl);
 var strVideoUrl = objCoursewareCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objCoursewareCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.VideoPath);
 var strVideoPath = objCoursewareCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objCoursewareCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.ResErrMsg);
 var strResErrMsg = objCoursewareCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objCoursewareCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.UpdDate);
 var strUpdDate = objCoursewareCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCoursewareCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.UpdUserId);
 var strUpdUserId = objCoursewareCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCoursewareCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareCase.Memo);
 var strMemo = objCoursewareCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CoursewareCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCoursewareCases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareCase where IdCoursewareCase = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CoursewareCase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdCoursewareCase = oRow[conCoursewareCase.IdCoursewareCase].ToString().Trim();
if (IsExist(strIdCoursewareCase))
{
 string strResult = "关键字变量值为:" + string.Format("IdCoursewareCase = {0}", strIdCoursewareCase) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCoursewareCaseEN._CurrTabName ].NewRow();
objRow[conCoursewareCase.IdCoursewareCase] = oRow[conCoursewareCase.IdCoursewareCase].ToString().Trim(); //课件教学案例流水号
objRow[conCoursewareCase.CoursewareCaseID] = oRow[conCoursewareCase.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objRow[conCoursewareCase.CoursewareCaseName] = oRow[conCoursewareCase.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objRow[conCoursewareCase.CoursewareCaseTheme] = oRow[conCoursewareCase.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objRow[conCoursewareCase.IdCoursewareCaseType] = oRow[conCoursewareCase.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objRow[conCoursewareCase.CoursewareCaseText] = oRow[conCoursewareCase.CoursewareCaseText].ToString().Trim(); //案例文本内容
objRow[conCoursewareCase.CoursewareCaseDate] = oRow[conCoursewareCase.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objRow[conCoursewareCase.CoursewareCaseTime] = oRow[conCoursewareCase.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objRow[conCoursewareCase.CoursewareCaseDateIn] = oRow[conCoursewareCase.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objRow[conCoursewareCase.CoursewareCaseTimeIn] = oRow[conCoursewareCase.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objRow[conCoursewareCase.IdStudyLevel] = oRow[conCoursewareCase.IdStudyLevel].ToString().Trim(); //学段流水号
objRow[conCoursewareCase.IdTeachingPlan] = oRow[conCoursewareCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objRow[conCoursewareCase.IdCaseType] = oRow[conCoursewareCase.IdCaseType].ToString().Trim(); //案例类型流水号
objRow[conCoursewareCase.IdDiscipline] = oRow[conCoursewareCase.IdDiscipline].ToString().Trim(); //学科流水号
objRow[conCoursewareCase.BrowseCount] = oRow[conCoursewareCase.BrowseCount].ToString().Trim(); //浏览次数
objRow[conCoursewareCase.IdSenateGaugeVersion] = oRow[conCoursewareCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objRow[conCoursewareCase.IdTeachSkill] = oRow[conCoursewareCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objRow[conCoursewareCase.CaseLevelId] = oRow[conCoursewareCase.CaseLevelId].ToString().Trim(); //课例等级Id
objRow[conCoursewareCase.DocFile] = oRow[conCoursewareCase.DocFile].ToString().Trim(); //生成的Word文件名
objRow[conCoursewareCase.IsNeedGeneWord] = oRow[conCoursewareCase.IsNeedGeneWord].ToString().Trim(); //是否需要生成Word
objRow[conCoursewareCase.WordCreateDate] = oRow[conCoursewareCase.WordCreateDate].ToString().Trim(); //Word生成日期
objRow[conCoursewareCase.IsVisible] = oRow[conCoursewareCase.IsVisible].ToString().Trim(); //是否显示
objRow[conCoursewareCase.OwnerId] = oRow[conCoursewareCase.OwnerId].ToString().Trim(); //拥有者Id
objRow[conCoursewareCase.UserKindId] = oRow[conCoursewareCase.UserKindId].ToString().Trim(); //用户类别Id
objRow[conCoursewareCase.UserTypeId] = oRow[conCoursewareCase.UserTypeId].ToString().Trim(); //用户类型Id
objRow[conCoursewareCase.IsDualVideo] = oRow[conCoursewareCase.IsDualVideo].ToString().Trim(); //是否双视频
objRow[conCoursewareCase.RecommendedDegreeId] = oRow[conCoursewareCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objRow[conCoursewareCase.ftpFileType] = oRow[conCoursewareCase.ftpFileType].ToString().Trim(); //ftp文件类型
objRow[conCoursewareCase.VideoUrl] = oRow[conCoursewareCase.VideoUrl].ToString().Trim(); //视频Url
objRow[conCoursewareCase.VideoPath] = oRow[conCoursewareCase.VideoPath].ToString().Trim(); //视频目录
objRow[conCoursewareCase.ResErrMsg] = oRow[conCoursewareCase.ResErrMsg].ToString().Trim(); //资源错误信息
objRow[conCoursewareCase.UpdDate] = oRow[conCoursewareCase.UpdDate].ToString().Trim(); //修改日期
objRow[conCoursewareCase.UpdUserId] = oRow[conCoursewareCase.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conCoursewareCase.Memo] = oRow[conCoursewareCase.Memo].ToString().Trim(); //备注
 objDS.Tables[clsCoursewareCaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCoursewareCaseEN._CurrTabName);
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
 /// <param name = "objCoursewareCaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCoursewareCaseEN objCoursewareCaseEN)
{
 objCoursewareCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCoursewareCaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareCase where IdCoursewareCase = " + "'"+ objCoursewareCaseEN.IdCoursewareCase+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCoursewareCaseEN._CurrTabName);
if (objDS.Tables[clsCoursewareCaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdCoursewareCase = " + "'"+ objCoursewareCaseEN.IdCoursewareCase+"'");
return false;
}
objRow = objDS.Tables[clsCoursewareCaseEN._CurrTabName].Rows[0];
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdCoursewareCase))
 {
objRow[conCoursewareCase.IdCoursewareCase] = objCoursewareCaseEN.IdCoursewareCase; //课件教学案例流水号
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseID))
 {
objRow[conCoursewareCase.CoursewareCaseID] = objCoursewareCaseEN.CoursewareCaseID; //课件教学案例ID
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseName))
 {
objRow[conCoursewareCase.CoursewareCaseName] = objCoursewareCaseEN.CoursewareCaseName; //课件教学案例名称
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseTheme))
 {
objRow[conCoursewareCase.CoursewareCaseTheme] = objCoursewareCaseEN.CoursewareCaseTheme; //课件教学案例主题词
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdCoursewareCaseType))
 {
objRow[conCoursewareCase.IdCoursewareCaseType] = objCoursewareCaseEN.IdCoursewareCaseType; //课件案例类型流水号
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseText))
 {
objRow[conCoursewareCase.CoursewareCaseText] = objCoursewareCaseEN.CoursewareCaseText; //案例文本内容
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseDate))
 {
objRow[conCoursewareCase.CoursewareCaseDate] = objCoursewareCaseEN.CoursewareCaseDate; //课件教学日期
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseTime))
 {
objRow[conCoursewareCase.CoursewareCaseTime] = objCoursewareCaseEN.CoursewareCaseTime; //课件教学时间
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseDateIn))
 {
objRow[conCoursewareCase.CoursewareCaseDateIn] = objCoursewareCaseEN.CoursewareCaseDateIn; //案例入库日期
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseTimeIn))
 {
objRow[conCoursewareCase.CoursewareCaseTimeIn] = objCoursewareCaseEN.CoursewareCaseTimeIn; //案例入库时间
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdStudyLevel))
 {
objRow[conCoursewareCase.IdStudyLevel] = objCoursewareCaseEN.IdStudyLevel; //学段流水号
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdTeachingPlan))
 {
objRow[conCoursewareCase.IdTeachingPlan] = objCoursewareCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdCaseType))
 {
objRow[conCoursewareCase.IdCaseType] = objCoursewareCaseEN.IdCaseType; //案例类型流水号
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdDiscipline))
 {
objRow[conCoursewareCase.IdDiscipline] = objCoursewareCaseEN.IdDiscipline; //学科流水号
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.BrowseCount))
 {
objRow[conCoursewareCase.BrowseCount] = objCoursewareCaseEN.BrowseCount; //浏览次数
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdSenateGaugeVersion))
 {
objRow[conCoursewareCase.IdSenateGaugeVersion] = objCoursewareCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdTeachSkill))
 {
objRow[conCoursewareCase.IdTeachSkill] = objCoursewareCaseEN.IdTeachSkill; //教学技能流水号
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CaseLevelId))
 {
objRow[conCoursewareCase.CaseLevelId] = objCoursewareCaseEN.CaseLevelId; //课例等级Id
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.DocFile))
 {
objRow[conCoursewareCase.DocFile] = objCoursewareCaseEN.DocFile; //生成的Word文件名
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IsNeedGeneWord))
 {
objRow[conCoursewareCase.IsNeedGeneWord] = objCoursewareCaseEN.IsNeedGeneWord; //是否需要生成Word
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.WordCreateDate))
 {
objRow[conCoursewareCase.WordCreateDate] = objCoursewareCaseEN.WordCreateDate; //Word生成日期
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IsVisible))
 {
objRow[conCoursewareCase.IsVisible] = objCoursewareCaseEN.IsVisible; //是否显示
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.OwnerId))
 {
objRow[conCoursewareCase.OwnerId] = objCoursewareCaseEN.OwnerId; //拥有者Id
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UserKindId))
 {
objRow[conCoursewareCase.UserKindId] = objCoursewareCaseEN.UserKindId; //用户类别Id
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UserTypeId))
 {
objRow[conCoursewareCase.UserTypeId] = objCoursewareCaseEN.UserTypeId; //用户类型Id
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IsDualVideo))
 {
objRow[conCoursewareCase.IsDualVideo] = objCoursewareCaseEN.IsDualVideo; //是否双视频
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.RecommendedDegreeId))
 {
objRow[conCoursewareCase.RecommendedDegreeId] = objCoursewareCaseEN.RecommendedDegreeId; //推荐度Id
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.ftpFileType))
 {
objRow[conCoursewareCase.ftpFileType] = objCoursewareCaseEN.ftpFileType; //ftp文件类型
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.VideoUrl))
 {
objRow[conCoursewareCase.VideoUrl] = objCoursewareCaseEN.VideoUrl; //视频Url
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.VideoPath))
 {
objRow[conCoursewareCase.VideoPath] = objCoursewareCaseEN.VideoPath; //视频目录
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.ResErrMsg))
 {
objRow[conCoursewareCase.ResErrMsg] = objCoursewareCaseEN.ResErrMsg; //资源错误信息
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UpdDate))
 {
objRow[conCoursewareCase.UpdDate] = objCoursewareCaseEN.UpdDate; //修改日期
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UpdUserId))
 {
objRow[conCoursewareCase.UpdUserId] = objCoursewareCaseEN.UpdUserId; //修改用户Id
 }
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.Memo))
 {
objRow[conCoursewareCase.Memo] = objCoursewareCaseEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsCoursewareCaseEN._CurrTabName);
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
 /// <param name = "objCoursewareCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCoursewareCaseEN objCoursewareCaseEN)
{
 objCoursewareCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCoursewareCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CoursewareCase Set ");
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseID))
 {
 if (objCoursewareCaseEN.CoursewareCaseID !=  null)
 {
 var strCoursewareCaseID = objCoursewareCaseEN.CoursewareCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareCaseID, conCoursewareCase.CoursewareCaseID); //课件教学案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CoursewareCaseID); //课件教学案例ID
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseName))
 {
 if (objCoursewareCaseEN.CoursewareCaseName !=  null)
 {
 var strCoursewareCaseName = objCoursewareCaseEN.CoursewareCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareCaseName, conCoursewareCase.CoursewareCaseName); //课件教学案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CoursewareCaseName); //课件教学案例名称
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseTheme))
 {
 if (objCoursewareCaseEN.CoursewareCaseTheme !=  null)
 {
 var strCoursewareCaseTheme = objCoursewareCaseEN.CoursewareCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareCaseTheme, conCoursewareCase.CoursewareCaseTheme); //课件教学案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CoursewareCaseTheme); //课件教学案例主题词
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdCoursewareCaseType))
 {
 if (objCoursewareCaseEN.IdCoursewareCaseType !=  null)
 {
 var strIdCoursewareCaseType = objCoursewareCaseEN.IdCoursewareCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCoursewareCaseType, conCoursewareCase.IdCoursewareCaseType); //课件案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.IdCoursewareCaseType); //课件案例类型流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseText))
 {
 if (objCoursewareCaseEN.CoursewareCaseText !=  null)
 {
 var strCoursewareCaseText = objCoursewareCaseEN.CoursewareCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareCaseText, conCoursewareCase.CoursewareCaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CoursewareCaseText); //案例文本内容
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseDate))
 {
 if (objCoursewareCaseEN.CoursewareCaseDate !=  null)
 {
 var strCoursewareCaseDate = objCoursewareCaseEN.CoursewareCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareCaseDate, conCoursewareCase.CoursewareCaseDate); //课件教学日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CoursewareCaseDate); //课件教学日期
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseTime))
 {
 if (objCoursewareCaseEN.CoursewareCaseTime !=  null)
 {
 var strCoursewareCaseTime = objCoursewareCaseEN.CoursewareCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareCaseTime, conCoursewareCase.CoursewareCaseTime); //课件教学时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CoursewareCaseTime); //课件教学时间
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseDateIn))
 {
 if (objCoursewareCaseEN.CoursewareCaseDateIn !=  null)
 {
 var strCoursewareCaseDateIn = objCoursewareCaseEN.CoursewareCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareCaseDateIn, conCoursewareCase.CoursewareCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CoursewareCaseDateIn); //案例入库日期
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseTimeIn))
 {
 if (objCoursewareCaseEN.CoursewareCaseTimeIn !=  null)
 {
 var strCoursewareCaseTimeIn = objCoursewareCaseEN.CoursewareCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareCaseTimeIn, conCoursewareCase.CoursewareCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CoursewareCaseTimeIn); //案例入库时间
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdStudyLevel))
 {
 if (objCoursewareCaseEN.IdStudyLevel  ==  "")
 {
 objCoursewareCaseEN.IdStudyLevel = null;
 }
 if (objCoursewareCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objCoursewareCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conCoursewareCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdTeachingPlan))
 {
 if (objCoursewareCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objCoursewareCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conCoursewareCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdCaseType))
 {
 if (objCoursewareCaseEN.IdCaseType  ==  "")
 {
 objCoursewareCaseEN.IdCaseType = null;
 }
 if (objCoursewareCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objCoursewareCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conCoursewareCase.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.IdCaseType); //案例类型流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdDiscipline))
 {
 if (objCoursewareCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objCoursewareCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conCoursewareCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.BrowseCount))
 {
 if (objCoursewareCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareCaseEN.BrowseCount, conCoursewareCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.BrowseCount); //浏览次数
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdSenateGaugeVersion))
 {
 if (objCoursewareCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCoursewareCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCoursewareCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objCoursewareCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conCoursewareCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdTeachSkill))
 {
 if (objCoursewareCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objCoursewareCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conCoursewareCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CaseLevelId))
 {
 if (objCoursewareCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objCoursewareCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conCoursewareCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.DocFile))
 {
 if (objCoursewareCaseEN.DocFile !=  null)
 {
 var strDocFile = objCoursewareCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conCoursewareCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCoursewareCaseEN.IsNeedGeneWord == true?"1":"0", conCoursewareCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.WordCreateDate))
 {
 if (objCoursewareCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objCoursewareCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conCoursewareCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCoursewareCaseEN.IsVisible == true?"1":"0", conCoursewareCase.IsVisible); //是否显示
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.OwnerId))
 {
 if (objCoursewareCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objCoursewareCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conCoursewareCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.OwnerId); //拥有者Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UserKindId))
 {
 if (objCoursewareCaseEN.UserKindId  ==  "")
 {
 objCoursewareCaseEN.UserKindId = null;
 }
 if (objCoursewareCaseEN.UserKindId !=  null)
 {
 var strUserKindId = objCoursewareCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserKindId, conCoursewareCase.UserKindId); //用户类别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.UserKindId); //用户类别Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UserTypeId))
 {
 if (objCoursewareCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objCoursewareCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conCoursewareCase.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.UserTypeId); //用户类型Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCoursewareCaseEN.IsDualVideo == true?"1":"0", conCoursewareCase.IsDualVideo); //是否双视频
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.RecommendedDegreeId))
 {
 if (objCoursewareCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objCoursewareCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conCoursewareCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.ftpFileType))
 {
 if (objCoursewareCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objCoursewareCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conCoursewareCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.VideoUrl))
 {
 if (objCoursewareCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objCoursewareCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conCoursewareCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.VideoUrl); //视频Url
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.VideoPath))
 {
 if (objCoursewareCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objCoursewareCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conCoursewareCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.VideoPath); //视频目录
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.ResErrMsg))
 {
 if (objCoursewareCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objCoursewareCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conCoursewareCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UpdDate))
 {
 if (objCoursewareCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objCoursewareCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCoursewareCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.UpdDate); //修改日期
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UpdUserId))
 {
 if (objCoursewareCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCoursewareCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCoursewareCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.Memo))
 {
 if (objCoursewareCaseEN.Memo !=  null)
 {
 var strMemo = objCoursewareCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCoursewareCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCoursewareCase = '{0}'", objCoursewareCaseEN.IdCoursewareCase); 
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
 /// <param name = "objCoursewareCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCoursewareCaseEN objCoursewareCaseEN, string strCondition)
{
 objCoursewareCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCoursewareCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CoursewareCase Set ");
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseID))
 {
 if (objCoursewareCaseEN.CoursewareCaseID !=  null)
 {
 var strCoursewareCaseID = objCoursewareCaseEN.CoursewareCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareCaseID = '{0}',", strCoursewareCaseID); //课件教学案例ID
 }
 else
 {
 sbSQL.Append(" CoursewareCaseID = null,"); //课件教学案例ID
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseName))
 {
 if (objCoursewareCaseEN.CoursewareCaseName !=  null)
 {
 var strCoursewareCaseName = objCoursewareCaseEN.CoursewareCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareCaseName = '{0}',", strCoursewareCaseName); //课件教学案例名称
 }
 else
 {
 sbSQL.Append(" CoursewareCaseName = null,"); //课件教学案例名称
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseTheme))
 {
 if (objCoursewareCaseEN.CoursewareCaseTheme !=  null)
 {
 var strCoursewareCaseTheme = objCoursewareCaseEN.CoursewareCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareCaseTheme = '{0}',", strCoursewareCaseTheme); //课件教学案例主题词
 }
 else
 {
 sbSQL.Append(" CoursewareCaseTheme = null,"); //课件教学案例主题词
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdCoursewareCaseType))
 {
 if (objCoursewareCaseEN.IdCoursewareCaseType !=  null)
 {
 var strIdCoursewareCaseType = objCoursewareCaseEN.IdCoursewareCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCoursewareCaseType = '{0}',", strIdCoursewareCaseType); //课件案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCoursewareCaseType = null,"); //课件案例类型流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseText))
 {
 if (objCoursewareCaseEN.CoursewareCaseText !=  null)
 {
 var strCoursewareCaseText = objCoursewareCaseEN.CoursewareCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareCaseText = '{0}',", strCoursewareCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" CoursewareCaseText = null,"); //案例文本内容
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseDate))
 {
 if (objCoursewareCaseEN.CoursewareCaseDate !=  null)
 {
 var strCoursewareCaseDate = objCoursewareCaseEN.CoursewareCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareCaseDate = '{0}',", strCoursewareCaseDate); //课件教学日期
 }
 else
 {
 sbSQL.Append(" CoursewareCaseDate = null,"); //课件教学日期
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseTime))
 {
 if (objCoursewareCaseEN.CoursewareCaseTime !=  null)
 {
 var strCoursewareCaseTime = objCoursewareCaseEN.CoursewareCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareCaseTime = '{0}',", strCoursewareCaseTime); //课件教学时间
 }
 else
 {
 sbSQL.Append(" CoursewareCaseTime = null,"); //课件教学时间
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseDateIn))
 {
 if (objCoursewareCaseEN.CoursewareCaseDateIn !=  null)
 {
 var strCoursewareCaseDateIn = objCoursewareCaseEN.CoursewareCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareCaseDateIn = '{0}',", strCoursewareCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" CoursewareCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseTimeIn))
 {
 if (objCoursewareCaseEN.CoursewareCaseTimeIn !=  null)
 {
 var strCoursewareCaseTimeIn = objCoursewareCaseEN.CoursewareCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareCaseTimeIn = '{0}',", strCoursewareCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" CoursewareCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdStudyLevel))
 {
 if (objCoursewareCaseEN.IdStudyLevel  ==  "")
 {
 objCoursewareCaseEN.IdStudyLevel = null;
 }
 if (objCoursewareCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objCoursewareCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdTeachingPlan))
 {
 if (objCoursewareCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objCoursewareCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdCaseType))
 {
 if (objCoursewareCaseEN.IdCaseType  ==  "")
 {
 objCoursewareCaseEN.IdCaseType = null;
 }
 if (objCoursewareCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objCoursewareCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdDiscipline))
 {
 if (objCoursewareCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objCoursewareCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.BrowseCount))
 {
 if (objCoursewareCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareCaseEN.BrowseCount, conCoursewareCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.BrowseCount); //浏览次数
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdSenateGaugeVersion))
 {
 if (objCoursewareCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCoursewareCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCoursewareCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objCoursewareCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdTeachSkill))
 {
 if (objCoursewareCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objCoursewareCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CaseLevelId))
 {
 if (objCoursewareCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objCoursewareCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.DocFile))
 {
 if (objCoursewareCaseEN.DocFile !=  null)
 {
 var strDocFile = objCoursewareCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objCoursewareCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.WordCreateDate))
 {
 if (objCoursewareCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objCoursewareCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objCoursewareCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.OwnerId))
 {
 if (objCoursewareCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objCoursewareCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UserKindId))
 {
 if (objCoursewareCaseEN.UserKindId  ==  "")
 {
 objCoursewareCaseEN.UserKindId = null;
 }
 if (objCoursewareCaseEN.UserKindId !=  null)
 {
 var strUserKindId = objCoursewareCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserKindId = '{0}',", strUserKindId); //用户类别Id
 }
 else
 {
 sbSQL.Append(" UserKindId = null,"); //用户类别Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UserTypeId))
 {
 if (objCoursewareCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objCoursewareCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objCoursewareCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.RecommendedDegreeId))
 {
 if (objCoursewareCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objCoursewareCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.ftpFileType))
 {
 if (objCoursewareCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objCoursewareCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.VideoUrl))
 {
 if (objCoursewareCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objCoursewareCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.VideoPath))
 {
 if (objCoursewareCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objCoursewareCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.ResErrMsg))
 {
 if (objCoursewareCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objCoursewareCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UpdDate))
 {
 if (objCoursewareCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objCoursewareCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UpdUserId))
 {
 if (objCoursewareCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCoursewareCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.Memo))
 {
 if (objCoursewareCaseEN.Memo !=  null)
 {
 var strMemo = objCoursewareCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCoursewareCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCoursewareCaseEN objCoursewareCaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCoursewareCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCoursewareCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CoursewareCase Set ");
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseID))
 {
 if (objCoursewareCaseEN.CoursewareCaseID !=  null)
 {
 var strCoursewareCaseID = objCoursewareCaseEN.CoursewareCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareCaseID = '{0}',", strCoursewareCaseID); //课件教学案例ID
 }
 else
 {
 sbSQL.Append(" CoursewareCaseID = null,"); //课件教学案例ID
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseName))
 {
 if (objCoursewareCaseEN.CoursewareCaseName !=  null)
 {
 var strCoursewareCaseName = objCoursewareCaseEN.CoursewareCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareCaseName = '{0}',", strCoursewareCaseName); //课件教学案例名称
 }
 else
 {
 sbSQL.Append(" CoursewareCaseName = null,"); //课件教学案例名称
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseTheme))
 {
 if (objCoursewareCaseEN.CoursewareCaseTheme !=  null)
 {
 var strCoursewareCaseTheme = objCoursewareCaseEN.CoursewareCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareCaseTheme = '{0}',", strCoursewareCaseTheme); //课件教学案例主题词
 }
 else
 {
 sbSQL.Append(" CoursewareCaseTheme = null,"); //课件教学案例主题词
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdCoursewareCaseType))
 {
 if (objCoursewareCaseEN.IdCoursewareCaseType !=  null)
 {
 var strIdCoursewareCaseType = objCoursewareCaseEN.IdCoursewareCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCoursewareCaseType = '{0}',", strIdCoursewareCaseType); //课件案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCoursewareCaseType = null,"); //课件案例类型流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseText))
 {
 if (objCoursewareCaseEN.CoursewareCaseText !=  null)
 {
 var strCoursewareCaseText = objCoursewareCaseEN.CoursewareCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareCaseText = '{0}',", strCoursewareCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" CoursewareCaseText = null,"); //案例文本内容
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseDate))
 {
 if (objCoursewareCaseEN.CoursewareCaseDate !=  null)
 {
 var strCoursewareCaseDate = objCoursewareCaseEN.CoursewareCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareCaseDate = '{0}',", strCoursewareCaseDate); //课件教学日期
 }
 else
 {
 sbSQL.Append(" CoursewareCaseDate = null,"); //课件教学日期
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseTime))
 {
 if (objCoursewareCaseEN.CoursewareCaseTime !=  null)
 {
 var strCoursewareCaseTime = objCoursewareCaseEN.CoursewareCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareCaseTime = '{0}',", strCoursewareCaseTime); //课件教学时间
 }
 else
 {
 sbSQL.Append(" CoursewareCaseTime = null,"); //课件教学时间
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseDateIn))
 {
 if (objCoursewareCaseEN.CoursewareCaseDateIn !=  null)
 {
 var strCoursewareCaseDateIn = objCoursewareCaseEN.CoursewareCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareCaseDateIn = '{0}',", strCoursewareCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" CoursewareCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseTimeIn))
 {
 if (objCoursewareCaseEN.CoursewareCaseTimeIn !=  null)
 {
 var strCoursewareCaseTimeIn = objCoursewareCaseEN.CoursewareCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareCaseTimeIn = '{0}',", strCoursewareCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" CoursewareCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdStudyLevel))
 {
 if (objCoursewareCaseEN.IdStudyLevel  ==  "")
 {
 objCoursewareCaseEN.IdStudyLevel = null;
 }
 if (objCoursewareCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objCoursewareCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdTeachingPlan))
 {
 if (objCoursewareCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objCoursewareCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdCaseType))
 {
 if (objCoursewareCaseEN.IdCaseType  ==  "")
 {
 objCoursewareCaseEN.IdCaseType = null;
 }
 if (objCoursewareCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objCoursewareCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdDiscipline))
 {
 if (objCoursewareCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objCoursewareCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.BrowseCount))
 {
 if (objCoursewareCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareCaseEN.BrowseCount, conCoursewareCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.BrowseCount); //浏览次数
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdSenateGaugeVersion))
 {
 if (objCoursewareCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCoursewareCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCoursewareCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objCoursewareCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdTeachSkill))
 {
 if (objCoursewareCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objCoursewareCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CaseLevelId))
 {
 if (objCoursewareCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objCoursewareCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.DocFile))
 {
 if (objCoursewareCaseEN.DocFile !=  null)
 {
 var strDocFile = objCoursewareCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objCoursewareCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.WordCreateDate))
 {
 if (objCoursewareCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objCoursewareCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objCoursewareCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.OwnerId))
 {
 if (objCoursewareCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objCoursewareCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UserKindId))
 {
 if (objCoursewareCaseEN.UserKindId  ==  "")
 {
 objCoursewareCaseEN.UserKindId = null;
 }
 if (objCoursewareCaseEN.UserKindId !=  null)
 {
 var strUserKindId = objCoursewareCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserKindId = '{0}',", strUserKindId); //用户类别Id
 }
 else
 {
 sbSQL.Append(" UserKindId = null,"); //用户类别Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UserTypeId))
 {
 if (objCoursewareCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objCoursewareCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objCoursewareCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.RecommendedDegreeId))
 {
 if (objCoursewareCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objCoursewareCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.ftpFileType))
 {
 if (objCoursewareCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objCoursewareCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.VideoUrl))
 {
 if (objCoursewareCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objCoursewareCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.VideoPath))
 {
 if (objCoursewareCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objCoursewareCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.ResErrMsg))
 {
 if (objCoursewareCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objCoursewareCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UpdDate))
 {
 if (objCoursewareCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objCoursewareCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UpdUserId))
 {
 if (objCoursewareCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCoursewareCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.Memo))
 {
 if (objCoursewareCaseEN.Memo !=  null)
 {
 var strMemo = objCoursewareCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCoursewareCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCoursewareCaseEN objCoursewareCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCoursewareCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCoursewareCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CoursewareCase Set ");
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseID))
 {
 if (objCoursewareCaseEN.CoursewareCaseID !=  null)
 {
 var strCoursewareCaseID = objCoursewareCaseEN.CoursewareCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareCaseID, conCoursewareCase.CoursewareCaseID); //课件教学案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CoursewareCaseID); //课件教学案例ID
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseName))
 {
 if (objCoursewareCaseEN.CoursewareCaseName !=  null)
 {
 var strCoursewareCaseName = objCoursewareCaseEN.CoursewareCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareCaseName, conCoursewareCase.CoursewareCaseName); //课件教学案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CoursewareCaseName); //课件教学案例名称
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseTheme))
 {
 if (objCoursewareCaseEN.CoursewareCaseTheme !=  null)
 {
 var strCoursewareCaseTheme = objCoursewareCaseEN.CoursewareCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareCaseTheme, conCoursewareCase.CoursewareCaseTheme); //课件教学案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CoursewareCaseTheme); //课件教学案例主题词
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdCoursewareCaseType))
 {
 if (objCoursewareCaseEN.IdCoursewareCaseType !=  null)
 {
 var strIdCoursewareCaseType = objCoursewareCaseEN.IdCoursewareCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCoursewareCaseType, conCoursewareCase.IdCoursewareCaseType); //课件案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.IdCoursewareCaseType); //课件案例类型流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseText))
 {
 if (objCoursewareCaseEN.CoursewareCaseText !=  null)
 {
 var strCoursewareCaseText = objCoursewareCaseEN.CoursewareCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareCaseText, conCoursewareCase.CoursewareCaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CoursewareCaseText); //案例文本内容
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseDate))
 {
 if (objCoursewareCaseEN.CoursewareCaseDate !=  null)
 {
 var strCoursewareCaseDate = objCoursewareCaseEN.CoursewareCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareCaseDate, conCoursewareCase.CoursewareCaseDate); //课件教学日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CoursewareCaseDate); //课件教学日期
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseTime))
 {
 if (objCoursewareCaseEN.CoursewareCaseTime !=  null)
 {
 var strCoursewareCaseTime = objCoursewareCaseEN.CoursewareCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareCaseTime, conCoursewareCase.CoursewareCaseTime); //课件教学时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CoursewareCaseTime); //课件教学时间
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseDateIn))
 {
 if (objCoursewareCaseEN.CoursewareCaseDateIn !=  null)
 {
 var strCoursewareCaseDateIn = objCoursewareCaseEN.CoursewareCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareCaseDateIn, conCoursewareCase.CoursewareCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CoursewareCaseDateIn); //案例入库日期
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CoursewareCaseTimeIn))
 {
 if (objCoursewareCaseEN.CoursewareCaseTimeIn !=  null)
 {
 var strCoursewareCaseTimeIn = objCoursewareCaseEN.CoursewareCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareCaseTimeIn, conCoursewareCase.CoursewareCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CoursewareCaseTimeIn); //案例入库时间
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdStudyLevel))
 {
 if (objCoursewareCaseEN.IdStudyLevel  ==  "")
 {
 objCoursewareCaseEN.IdStudyLevel = null;
 }
 if (objCoursewareCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objCoursewareCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conCoursewareCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdTeachingPlan))
 {
 if (objCoursewareCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objCoursewareCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conCoursewareCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdCaseType))
 {
 if (objCoursewareCaseEN.IdCaseType  ==  "")
 {
 objCoursewareCaseEN.IdCaseType = null;
 }
 if (objCoursewareCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objCoursewareCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conCoursewareCase.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.IdCaseType); //案例类型流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdDiscipline))
 {
 if (objCoursewareCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objCoursewareCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conCoursewareCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.BrowseCount))
 {
 if (objCoursewareCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareCaseEN.BrowseCount, conCoursewareCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.BrowseCount); //浏览次数
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdSenateGaugeVersion))
 {
 if (objCoursewareCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCoursewareCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCoursewareCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objCoursewareCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conCoursewareCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IdTeachSkill))
 {
 if (objCoursewareCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objCoursewareCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conCoursewareCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.CaseLevelId))
 {
 if (objCoursewareCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objCoursewareCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conCoursewareCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.DocFile))
 {
 if (objCoursewareCaseEN.DocFile !=  null)
 {
 var strDocFile = objCoursewareCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conCoursewareCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCoursewareCaseEN.IsNeedGeneWord == true?"1":"0", conCoursewareCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.WordCreateDate))
 {
 if (objCoursewareCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objCoursewareCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conCoursewareCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCoursewareCaseEN.IsVisible == true?"1":"0", conCoursewareCase.IsVisible); //是否显示
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.OwnerId))
 {
 if (objCoursewareCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objCoursewareCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conCoursewareCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.OwnerId); //拥有者Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UserKindId))
 {
 if (objCoursewareCaseEN.UserKindId  ==  "")
 {
 objCoursewareCaseEN.UserKindId = null;
 }
 if (objCoursewareCaseEN.UserKindId !=  null)
 {
 var strUserKindId = objCoursewareCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserKindId, conCoursewareCase.UserKindId); //用户类别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.UserKindId); //用户类别Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UserTypeId))
 {
 if (objCoursewareCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objCoursewareCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conCoursewareCase.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.UserTypeId); //用户类型Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCoursewareCaseEN.IsDualVideo == true?"1":"0", conCoursewareCase.IsDualVideo); //是否双视频
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.RecommendedDegreeId))
 {
 if (objCoursewareCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objCoursewareCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conCoursewareCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.ftpFileType))
 {
 if (objCoursewareCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objCoursewareCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conCoursewareCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.VideoUrl))
 {
 if (objCoursewareCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objCoursewareCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conCoursewareCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.VideoUrl); //视频Url
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.VideoPath))
 {
 if (objCoursewareCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objCoursewareCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conCoursewareCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.VideoPath); //视频目录
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.ResErrMsg))
 {
 if (objCoursewareCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objCoursewareCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conCoursewareCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UpdDate))
 {
 if (objCoursewareCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objCoursewareCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCoursewareCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.UpdDate); //修改日期
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.UpdUserId))
 {
 if (objCoursewareCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCoursewareCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCoursewareCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objCoursewareCaseEN.IsUpdated(conCoursewareCase.Memo))
 {
 if (objCoursewareCaseEN.Memo !=  null)
 {
 var strMemo = objCoursewareCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCoursewareCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCoursewareCase = '{0}'", objCoursewareCaseEN.IdCoursewareCase); 
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
 /// <param name = "strIdCoursewareCase">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdCoursewareCase) 
{
CheckPrimaryKey(strIdCoursewareCase);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdCoursewareCase,
};
 objSQL.ExecSP("CoursewareCase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdCoursewareCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdCoursewareCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdCoursewareCase);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
//删除CoursewareCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CoursewareCase where IdCoursewareCase = " + "'"+ strIdCoursewareCase+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCoursewareCase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
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
//删除CoursewareCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CoursewareCase where IdCoursewareCase in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdCoursewareCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdCoursewareCase) 
{
CheckPrimaryKey(strIdCoursewareCase);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
//删除CoursewareCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CoursewareCase where IdCoursewareCase = " + "'"+ strIdCoursewareCase+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCoursewareCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCoursewareCaseDA: DelCoursewareCase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CoursewareCase where " + strCondition ;
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
public bool DelCoursewareCaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCoursewareCaseDA: DelCoursewareCaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CoursewareCase where " + strCondition ;
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
 /// <param name = "objCoursewareCaseENS">源对象</param>
 /// <param name = "objCoursewareCaseENT">目标对象</param>
public void CopyTo(clsCoursewareCaseEN objCoursewareCaseENS, clsCoursewareCaseEN objCoursewareCaseENT)
{
objCoursewareCaseENT.IdCoursewareCase = objCoursewareCaseENS.IdCoursewareCase; //课件教学案例流水号
objCoursewareCaseENT.CoursewareCaseID = objCoursewareCaseENS.CoursewareCaseID; //课件教学案例ID
objCoursewareCaseENT.CoursewareCaseName = objCoursewareCaseENS.CoursewareCaseName; //课件教学案例名称
objCoursewareCaseENT.CoursewareCaseTheme = objCoursewareCaseENS.CoursewareCaseTheme; //课件教学案例主题词
objCoursewareCaseENT.IdCoursewareCaseType = objCoursewareCaseENS.IdCoursewareCaseType; //课件案例类型流水号
objCoursewareCaseENT.CoursewareCaseText = objCoursewareCaseENS.CoursewareCaseText; //案例文本内容
objCoursewareCaseENT.CoursewareCaseDate = objCoursewareCaseENS.CoursewareCaseDate; //课件教学日期
objCoursewareCaseENT.CoursewareCaseTime = objCoursewareCaseENS.CoursewareCaseTime; //课件教学时间
objCoursewareCaseENT.CoursewareCaseDateIn = objCoursewareCaseENS.CoursewareCaseDateIn; //案例入库日期
objCoursewareCaseENT.CoursewareCaseTimeIn = objCoursewareCaseENS.CoursewareCaseTimeIn; //案例入库时间
objCoursewareCaseENT.IdStudyLevel = objCoursewareCaseENS.IdStudyLevel; //学段流水号
objCoursewareCaseENT.IdTeachingPlan = objCoursewareCaseENS.IdTeachingPlan; //教案流水号
objCoursewareCaseENT.IdCaseType = objCoursewareCaseENS.IdCaseType; //案例类型流水号
objCoursewareCaseENT.IdDiscipline = objCoursewareCaseENS.IdDiscipline; //学科流水号
objCoursewareCaseENT.BrowseCount = objCoursewareCaseENS.BrowseCount; //浏览次数
objCoursewareCaseENT.IdSenateGaugeVersion = objCoursewareCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objCoursewareCaseENT.IdTeachSkill = objCoursewareCaseENS.IdTeachSkill; //教学技能流水号
objCoursewareCaseENT.CaseLevelId = objCoursewareCaseENS.CaseLevelId; //课例等级Id
objCoursewareCaseENT.DocFile = objCoursewareCaseENS.DocFile; //生成的Word文件名
objCoursewareCaseENT.IsNeedGeneWord = objCoursewareCaseENS.IsNeedGeneWord; //是否需要生成Word
objCoursewareCaseENT.WordCreateDate = objCoursewareCaseENS.WordCreateDate; //Word生成日期
objCoursewareCaseENT.IsVisible = objCoursewareCaseENS.IsVisible; //是否显示
objCoursewareCaseENT.OwnerId = objCoursewareCaseENS.OwnerId; //拥有者Id
objCoursewareCaseENT.UserKindId = objCoursewareCaseENS.UserKindId; //用户类别Id
objCoursewareCaseENT.UserTypeId = objCoursewareCaseENS.UserTypeId; //用户类型Id
objCoursewareCaseENT.IsDualVideo = objCoursewareCaseENS.IsDualVideo; //是否双视频
objCoursewareCaseENT.RecommendedDegreeId = objCoursewareCaseENS.RecommendedDegreeId; //推荐度Id
objCoursewareCaseENT.ftpFileType = objCoursewareCaseENS.ftpFileType; //ftp文件类型
objCoursewareCaseENT.VideoUrl = objCoursewareCaseENS.VideoUrl; //视频Url
objCoursewareCaseENT.VideoPath = objCoursewareCaseENS.VideoPath; //视频目录
objCoursewareCaseENT.ResErrMsg = objCoursewareCaseENS.ResErrMsg; //资源错误信息
objCoursewareCaseENT.UpdDate = objCoursewareCaseENS.UpdDate; //修改日期
objCoursewareCaseENT.UpdUserId = objCoursewareCaseENS.UpdUserId; //修改用户Id
objCoursewareCaseENT.Memo = objCoursewareCaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCoursewareCaseEN objCoursewareCaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCoursewareCaseEN.CoursewareCaseID, conCoursewareCase.CoursewareCaseID);
clsCheckSql.CheckFieldNotNull(objCoursewareCaseEN.CoursewareCaseName, conCoursewareCase.CoursewareCaseName);
clsCheckSql.CheckFieldNotNull(objCoursewareCaseEN.IdCoursewareCaseType, conCoursewareCase.IdCoursewareCaseType);
clsCheckSql.CheckFieldNotNull(objCoursewareCaseEN.IdStudyLevel, conCoursewareCase.IdStudyLevel);
clsCheckSql.CheckFieldNotNull(objCoursewareCaseEN.IdDiscipline, conCoursewareCase.IdDiscipline);
clsCheckSql.CheckFieldNotNull(objCoursewareCaseEN.IdTeachSkill, conCoursewareCase.IdTeachSkill);
clsCheckSql.CheckFieldNotNull(objCoursewareCaseEN.OwnerId, conCoursewareCase.OwnerId);
clsCheckSql.CheckFieldNotNull(objCoursewareCaseEN.UserKindId, conCoursewareCase.UserKindId);
clsCheckSql.CheckFieldNotNull(objCoursewareCaseEN.RecommendedDegreeId, conCoursewareCase.RecommendedDegreeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdCoursewareCase, 8, conCoursewareCase.IdCoursewareCase);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseID, 8, conCoursewareCase.CoursewareCaseID);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseName, 100, conCoursewareCase.CoursewareCaseName);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseTheme, 200, conCoursewareCase.CoursewareCaseTheme);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdCoursewareCaseType, 4, conCoursewareCase.IdCoursewareCaseType);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseText, 8000, conCoursewareCase.CoursewareCaseText);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseDate, 8, conCoursewareCase.CoursewareCaseDate);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseTime, 6, conCoursewareCase.CoursewareCaseTime);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseDateIn, 8, conCoursewareCase.CoursewareCaseDateIn);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseTimeIn, 6, conCoursewareCase.CoursewareCaseTimeIn);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdStudyLevel, 4, conCoursewareCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdTeachingPlan, 8, conCoursewareCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdCaseType, 4, conCoursewareCase.IdCaseType);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdDiscipline, 4, conCoursewareCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdSenateGaugeVersion, 4, conCoursewareCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdTeachSkill, 8, conCoursewareCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CaseLevelId, 2, conCoursewareCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.DocFile, 200, conCoursewareCase.DocFile);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.WordCreateDate, 14, conCoursewareCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.OwnerId, 20, conCoursewareCase.OwnerId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.UserKindId, 2, conCoursewareCase.UserKindId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.UserTypeId, 2, conCoursewareCase.UserTypeId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.RecommendedDegreeId, 2, conCoursewareCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.ftpFileType, 30, conCoursewareCase.ftpFileType);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.VideoUrl, 1000, conCoursewareCase.VideoUrl);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.VideoPath, 1000, conCoursewareCase.VideoPath);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.ResErrMsg, 30, conCoursewareCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.UpdDate, 20, conCoursewareCase.UpdDate);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.UpdUserId, 20, conCoursewareCase.UpdUserId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.Memo, 1000, conCoursewareCase.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objCoursewareCaseEN.IdStudyLevel, 4, conCoursewareCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objCoursewareCaseEN.IdCaseType, 4, conCoursewareCase.IdCaseType);
clsCheckSql.CheckFieldForeignKey(objCoursewareCaseEN.IdSenateGaugeVersion, 4, conCoursewareCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(objCoursewareCaseEN.UserKindId, 2, conCoursewareCase.UserKindId);
 objCoursewareCaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCoursewareCaseEN objCoursewareCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseID, 8, conCoursewareCase.CoursewareCaseID);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseName, 100, conCoursewareCase.CoursewareCaseName);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseTheme, 200, conCoursewareCase.CoursewareCaseTheme);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdCoursewareCaseType, 4, conCoursewareCase.IdCoursewareCaseType);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseText, 8000, conCoursewareCase.CoursewareCaseText);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseDate, 8, conCoursewareCase.CoursewareCaseDate);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseTime, 6, conCoursewareCase.CoursewareCaseTime);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseDateIn, 8, conCoursewareCase.CoursewareCaseDateIn);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseTimeIn, 6, conCoursewareCase.CoursewareCaseTimeIn);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdStudyLevel, 4, conCoursewareCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdTeachingPlan, 8, conCoursewareCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdCaseType, 4, conCoursewareCase.IdCaseType);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdDiscipline, 4, conCoursewareCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdSenateGaugeVersion, 4, conCoursewareCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdTeachSkill, 8, conCoursewareCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CaseLevelId, 2, conCoursewareCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.DocFile, 200, conCoursewareCase.DocFile);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.WordCreateDate, 14, conCoursewareCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.OwnerId, 20, conCoursewareCase.OwnerId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.UserKindId, 2, conCoursewareCase.UserKindId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.UserTypeId, 2, conCoursewareCase.UserTypeId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.RecommendedDegreeId, 2, conCoursewareCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.ftpFileType, 30, conCoursewareCase.ftpFileType);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.VideoUrl, 1000, conCoursewareCase.VideoUrl);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.VideoPath, 1000, conCoursewareCase.VideoPath);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.ResErrMsg, 30, conCoursewareCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.UpdDate, 20, conCoursewareCase.UpdDate);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.UpdUserId, 20, conCoursewareCase.UpdUserId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.Memo, 1000, conCoursewareCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCoursewareCaseEN.IdStudyLevel, 4, conCoursewareCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objCoursewareCaseEN.IdCaseType, 4, conCoursewareCase.IdCaseType);
clsCheckSql.CheckFieldForeignKey(objCoursewareCaseEN.IdSenateGaugeVersion, 4, conCoursewareCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(objCoursewareCaseEN.UserKindId, 2, conCoursewareCase.UserKindId);
 objCoursewareCaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCoursewareCaseEN objCoursewareCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdCoursewareCase, 8, conCoursewareCase.IdCoursewareCase);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseID, 8, conCoursewareCase.CoursewareCaseID);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseName, 100, conCoursewareCase.CoursewareCaseName);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseTheme, 200, conCoursewareCase.CoursewareCaseTheme);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdCoursewareCaseType, 4, conCoursewareCase.IdCoursewareCaseType);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseText, 8000, conCoursewareCase.CoursewareCaseText);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseDate, 8, conCoursewareCase.CoursewareCaseDate);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseTime, 6, conCoursewareCase.CoursewareCaseTime);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseDateIn, 8, conCoursewareCase.CoursewareCaseDateIn);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CoursewareCaseTimeIn, 6, conCoursewareCase.CoursewareCaseTimeIn);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdStudyLevel, 4, conCoursewareCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdTeachingPlan, 8, conCoursewareCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdCaseType, 4, conCoursewareCase.IdCaseType);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdDiscipline, 4, conCoursewareCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdSenateGaugeVersion, 4, conCoursewareCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.IdTeachSkill, 8, conCoursewareCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.CaseLevelId, 2, conCoursewareCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.DocFile, 200, conCoursewareCase.DocFile);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.WordCreateDate, 14, conCoursewareCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.OwnerId, 20, conCoursewareCase.OwnerId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.UserKindId, 2, conCoursewareCase.UserKindId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.UserTypeId, 2, conCoursewareCase.UserTypeId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.RecommendedDegreeId, 2, conCoursewareCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.ftpFileType, 30, conCoursewareCase.ftpFileType);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.VideoUrl, 1000, conCoursewareCase.VideoUrl);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.VideoPath, 1000, conCoursewareCase.VideoPath);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.ResErrMsg, 30, conCoursewareCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.UpdDate, 20, conCoursewareCase.UpdDate);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.UpdUserId, 20, conCoursewareCase.UpdUserId);
clsCheckSql.CheckFieldLen(objCoursewareCaseEN.Memo, 1000, conCoursewareCase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.IdCoursewareCase, conCoursewareCase.IdCoursewareCase);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.CoursewareCaseID, conCoursewareCase.CoursewareCaseID);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.CoursewareCaseName, conCoursewareCase.CoursewareCaseName);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.CoursewareCaseTheme, conCoursewareCase.CoursewareCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.IdCoursewareCaseType, conCoursewareCase.IdCoursewareCaseType);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.CoursewareCaseText, conCoursewareCase.CoursewareCaseText);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.CoursewareCaseDate, conCoursewareCase.CoursewareCaseDate);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.CoursewareCaseTime, conCoursewareCase.CoursewareCaseTime);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.CoursewareCaseDateIn, conCoursewareCase.CoursewareCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.CoursewareCaseTimeIn, conCoursewareCase.CoursewareCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.IdStudyLevel, conCoursewareCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.IdTeachingPlan, conCoursewareCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.IdCaseType, conCoursewareCase.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.IdDiscipline, conCoursewareCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.IdSenateGaugeVersion, conCoursewareCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.IdTeachSkill, conCoursewareCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.CaseLevelId, conCoursewareCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.DocFile, conCoursewareCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.WordCreateDate, conCoursewareCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.OwnerId, conCoursewareCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.UserKindId, conCoursewareCase.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.UserTypeId, conCoursewareCase.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.RecommendedDegreeId, conCoursewareCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.ftpFileType, conCoursewareCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.VideoUrl, conCoursewareCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.VideoPath, conCoursewareCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.ResErrMsg, conCoursewareCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.UpdDate, conCoursewareCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.UpdUserId, conCoursewareCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objCoursewareCaseEN.Memo, conCoursewareCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCoursewareCaseEN.IdStudyLevel, 4, conCoursewareCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objCoursewareCaseEN.IdCaseType, 4, conCoursewareCase.IdCaseType);
clsCheckSql.CheckFieldForeignKey(objCoursewareCaseEN.IdSenateGaugeVersion, 4, conCoursewareCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(objCoursewareCaseEN.UserKindId, 2, conCoursewareCase.UserKindId);
 objCoursewareCaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdCoursewareCase()
{
//获取某学院所有专业信息
string strSQL = "select IdCoursewareCase, CoursewareCaseName from CoursewareCase ";
 clsSpecSQLforSql mySql = clsCoursewareCaseDA.GetSpecSQLObj();
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
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
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
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
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
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCoursewareCaseEN._CurrTabName);
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
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCoursewareCaseEN._CurrTabName, strCondition);
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
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
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
 objSQL = clsCoursewareCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}