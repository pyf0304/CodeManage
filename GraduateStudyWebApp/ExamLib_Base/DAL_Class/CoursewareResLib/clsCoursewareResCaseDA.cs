
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCoursewareResCaseDA
 表名:CoursewareResCase(01120418)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:58
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件资源库(CoursewareResLib)
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
 /// 课件资源案例(CoursewareResCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCoursewareResCaseDA : clsCommBase4DA
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
 return clsCoursewareResCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCoursewareResCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCoursewareResCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCoursewareResCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCoursewareResCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdCoursewareResCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdCoursewareResCase)
{
strIdCoursewareResCase = strIdCoursewareResCase.Replace("'", "''");
if (strIdCoursewareResCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:CoursewareResCase中,检查关键字,长度不正确!(clsCoursewareResCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCoursewareResCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CoursewareResCase中,关键字不能为空 或 null!(clsCoursewareResCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCoursewareResCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCoursewareResCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCoursewareResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CoursewareResCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCoursewareResCaseDA: GetDataTable_CoursewareResCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareResCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCoursewareResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCoursewareResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareResCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCoursewareResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCoursewareResCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CoursewareResCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CoursewareResCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCoursewareResCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CoursewareResCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCoursewareResCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CoursewareResCase.* from CoursewareResCase Left Join {1} on {2} where {3} and CoursewareResCase.IdCoursewareResCase not in (Select top {5} CoursewareResCase.IdCoursewareResCase from CoursewareResCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CoursewareResCase where {1} and IdCoursewareResCase not in (Select top {2} IdCoursewareResCase from CoursewareResCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CoursewareResCase where {1} and IdCoursewareResCase not in (Select top {3} IdCoursewareResCase from CoursewareResCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCoursewareResCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CoursewareResCase.* from CoursewareResCase Left Join {1} on {2} where {3} and CoursewareResCase.IdCoursewareResCase not in (Select top {5} CoursewareResCase.IdCoursewareResCase from CoursewareResCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CoursewareResCase where {1} and IdCoursewareResCase not in (Select top {2} IdCoursewareResCase from CoursewareResCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CoursewareResCase where {1} and IdCoursewareResCase not in (Select top {3} IdCoursewareResCase from CoursewareResCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCoursewareResCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCoursewareResCaseDA:GetObjLst)", objException.Message));
}
List<clsCoursewareResCaseEN> arrObjLst = new List<clsCoursewareResCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCoursewareResCaseEN objCoursewareResCaseEN = new clsCoursewareResCaseEN();
try
{
objCoursewareResCaseEN.IdCoursewareResCase = objRow[conCoursewareResCase.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objCoursewareResCaseEN.CoursewareResCaseID = objRow[conCoursewareResCase.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objCoursewareResCaseEN.CoursewareResCaseName = objRow[conCoursewareResCase.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objCoursewareResCaseEN.CoursewareResCaseTheme = objRow[conCoursewareResCase.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objCoursewareResCaseEN.CoursewareResCaseText = objRow[conCoursewareResCase.CoursewareResCaseText] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseText].ToString().Trim(); //案例文本内容
objCoursewareResCaseEN.IdCoursewareResCaseType = objRow[conCoursewareResCase.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objCoursewareResCaseEN.CoursewareResCaseDate = objRow[conCoursewareResCase.CoursewareResCaseDate] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objCoursewareResCaseEN.CoursewareResCaseTime = objRow[conCoursewareResCase.CoursewareResCaseTime] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objCoursewareResCaseEN.CoursewareResCaseDateIn = objRow[conCoursewareResCase.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objCoursewareResCaseEN.CoursewareResCaseTimeIn = objRow[conCoursewareResCase.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objCoursewareResCaseEN.OwnerId = objRow[conCoursewareResCase.OwnerId].ToString().Trim(); //拥有者Id
objCoursewareResCaseEN.IdStudyLevel = objRow[conCoursewareResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCoursewareResCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCoursewareResCaseEN.IdTeachingPlan = objRow[conCoursewareResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCoursewareResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCoursewareResCaseEN.IdDiscipline = objRow[conCoursewareResCase.IdDiscipline] == DBNull.Value ? null : objRow[conCoursewareResCase.IdDiscipline].ToString().Trim(); //学科流水号
objCoursewareResCaseEN.BrowseCount = objRow[conCoursewareResCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.BrowseCount].ToString().Trim()); //浏览次数
objCoursewareResCaseEN.IdSenateGaugeVersion = objRow[conCoursewareResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCoursewareResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCoursewareResCaseEN.IdTeachSkill = objRow[conCoursewareResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCoursewareResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCoursewareResCaseEN.CaseLevelId = objRow[conCoursewareResCase.CaseLevelId] == DBNull.Value ? null : objRow[conCoursewareResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCoursewareResCaseEN.DocFile = objRow[conCoursewareResCase.DocFile] == DBNull.Value ? null : objRow[conCoursewareResCase.DocFile].ToString().Trim(); //生成的Word文件名
objCoursewareResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conCoursewareResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCoursewareResCaseEN.WordCreateDate = objRow[conCoursewareResCase.WordCreateDate] == DBNull.Value ? null : objRow[conCoursewareResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCoursewareResCaseEN.IsVisible = TransNullToBool(objRow[conCoursewareResCase.IsVisible].ToString().Trim()); //是否显示
objCoursewareResCaseEN.IsDualVideo = TransNullToBool(objRow[conCoursewareResCase.IsDualVideo].ToString().Trim()); //是否双视频
objCoursewareResCaseEN.IdXzCollege = objRow[conCoursewareResCase.IdXzCollege].ToString().Trim(); //学院流水号
objCoursewareResCaseEN.IdXzMajor = objRow[conCoursewareResCase.IdXzMajor].ToString().Trim(); //专业流水号
objCoursewareResCaseEN.CourseChapterId = objRow[conCoursewareResCase.CourseChapterId] == DBNull.Value ? null : objRow[conCoursewareResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCoursewareResCaseEN.ViewCount = objRow[conCoursewareResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.ViewCount].ToString().Trim()); //浏览量
objCoursewareResCaseEN.IsShow = TransNullToBool(objRow[conCoursewareResCase.IsShow].ToString().Trim()); //是否启用
objCoursewareResCaseEN.DownloadNumber = objRow[conCoursewareResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.DownloadNumber].ToString().Trim()); //下载数目
objCoursewareResCaseEN.FileIntegration = objRow[conCoursewareResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.FileIntegration].ToString().Trim()); //文件积分
objCoursewareResCaseEN.LikeCount = objRow[conCoursewareResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCoursewareResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCoursewareResCaseEN.CollectionCount = objRow[conCoursewareResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCoursewareResCase.CollectionCount].ToString().Trim()); //收藏数量
objCoursewareResCaseEN.RecommendedDegreeId = objRow[conCoursewareResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCoursewareResCaseEN.ftpFileType = objRow[conCoursewareResCase.ftpFileType] == DBNull.Value ? null : objRow[conCoursewareResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCoursewareResCaseEN.CourseId = objRow[conCoursewareResCase.CourseId].ToString().Trim(); //课程Id
objCoursewareResCaseEN.VideoUrl = objRow[conCoursewareResCase.VideoUrl] == DBNull.Value ? null : objRow[conCoursewareResCase.VideoUrl].ToString().Trim(); //视频Url
objCoursewareResCaseEN.VideoPath = objRow[conCoursewareResCase.VideoPath] == DBNull.Value ? null : objRow[conCoursewareResCase.VideoPath].ToString().Trim(); //视频目录
objCoursewareResCaseEN.ResErrMsg = objRow[conCoursewareResCase.ResErrMsg] == DBNull.Value ? null : objRow[conCoursewareResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCoursewareResCaseEN.UpdDate = objRow[conCoursewareResCase.UpdDate] == DBNull.Value ? null : objRow[conCoursewareResCase.UpdDate].ToString().Trim(); //修改日期
objCoursewareResCaseEN.UpdUserId = objRow[conCoursewareResCase.UpdUserId] == DBNull.Value ? null : objRow[conCoursewareResCase.UpdUserId].ToString().Trim(); //修改用户Id
objCoursewareResCaseEN.Memo = objRow[conCoursewareResCase.Memo] == DBNull.Value ? null : objRow[conCoursewareResCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCoursewareResCaseDA: GetObjLst)", objException.Message));
}
objCoursewareResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCoursewareResCaseEN);
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
public List<clsCoursewareResCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCoursewareResCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsCoursewareResCaseEN> arrObjLst = new List<clsCoursewareResCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCoursewareResCaseEN objCoursewareResCaseEN = new clsCoursewareResCaseEN();
try
{
objCoursewareResCaseEN.IdCoursewareResCase = objRow[conCoursewareResCase.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objCoursewareResCaseEN.CoursewareResCaseID = objRow[conCoursewareResCase.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objCoursewareResCaseEN.CoursewareResCaseName = objRow[conCoursewareResCase.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objCoursewareResCaseEN.CoursewareResCaseTheme = objRow[conCoursewareResCase.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objCoursewareResCaseEN.CoursewareResCaseText = objRow[conCoursewareResCase.CoursewareResCaseText] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseText].ToString().Trim(); //案例文本内容
objCoursewareResCaseEN.IdCoursewareResCaseType = objRow[conCoursewareResCase.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objCoursewareResCaseEN.CoursewareResCaseDate = objRow[conCoursewareResCase.CoursewareResCaseDate] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objCoursewareResCaseEN.CoursewareResCaseTime = objRow[conCoursewareResCase.CoursewareResCaseTime] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objCoursewareResCaseEN.CoursewareResCaseDateIn = objRow[conCoursewareResCase.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objCoursewareResCaseEN.CoursewareResCaseTimeIn = objRow[conCoursewareResCase.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objCoursewareResCaseEN.OwnerId = objRow[conCoursewareResCase.OwnerId].ToString().Trim(); //拥有者Id
objCoursewareResCaseEN.IdStudyLevel = objRow[conCoursewareResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCoursewareResCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCoursewareResCaseEN.IdTeachingPlan = objRow[conCoursewareResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCoursewareResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCoursewareResCaseEN.IdDiscipline = objRow[conCoursewareResCase.IdDiscipline] == DBNull.Value ? null : objRow[conCoursewareResCase.IdDiscipline].ToString().Trim(); //学科流水号
objCoursewareResCaseEN.BrowseCount = objRow[conCoursewareResCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.BrowseCount].ToString().Trim()); //浏览次数
objCoursewareResCaseEN.IdSenateGaugeVersion = objRow[conCoursewareResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCoursewareResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCoursewareResCaseEN.IdTeachSkill = objRow[conCoursewareResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCoursewareResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCoursewareResCaseEN.CaseLevelId = objRow[conCoursewareResCase.CaseLevelId] == DBNull.Value ? null : objRow[conCoursewareResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCoursewareResCaseEN.DocFile = objRow[conCoursewareResCase.DocFile] == DBNull.Value ? null : objRow[conCoursewareResCase.DocFile].ToString().Trim(); //生成的Word文件名
objCoursewareResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conCoursewareResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCoursewareResCaseEN.WordCreateDate = objRow[conCoursewareResCase.WordCreateDate] == DBNull.Value ? null : objRow[conCoursewareResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCoursewareResCaseEN.IsVisible = TransNullToBool(objRow[conCoursewareResCase.IsVisible].ToString().Trim()); //是否显示
objCoursewareResCaseEN.IsDualVideo = TransNullToBool(objRow[conCoursewareResCase.IsDualVideo].ToString().Trim()); //是否双视频
objCoursewareResCaseEN.IdXzCollege = objRow[conCoursewareResCase.IdXzCollege].ToString().Trim(); //学院流水号
objCoursewareResCaseEN.IdXzMajor = objRow[conCoursewareResCase.IdXzMajor].ToString().Trim(); //专业流水号
objCoursewareResCaseEN.CourseChapterId = objRow[conCoursewareResCase.CourseChapterId] == DBNull.Value ? null : objRow[conCoursewareResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCoursewareResCaseEN.ViewCount = objRow[conCoursewareResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.ViewCount].ToString().Trim()); //浏览量
objCoursewareResCaseEN.IsShow = TransNullToBool(objRow[conCoursewareResCase.IsShow].ToString().Trim()); //是否启用
objCoursewareResCaseEN.DownloadNumber = objRow[conCoursewareResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.DownloadNumber].ToString().Trim()); //下载数目
objCoursewareResCaseEN.FileIntegration = objRow[conCoursewareResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.FileIntegration].ToString().Trim()); //文件积分
objCoursewareResCaseEN.LikeCount = objRow[conCoursewareResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCoursewareResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCoursewareResCaseEN.CollectionCount = objRow[conCoursewareResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCoursewareResCase.CollectionCount].ToString().Trim()); //收藏数量
objCoursewareResCaseEN.RecommendedDegreeId = objRow[conCoursewareResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCoursewareResCaseEN.ftpFileType = objRow[conCoursewareResCase.ftpFileType] == DBNull.Value ? null : objRow[conCoursewareResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCoursewareResCaseEN.CourseId = objRow[conCoursewareResCase.CourseId].ToString().Trim(); //课程Id
objCoursewareResCaseEN.VideoUrl = objRow[conCoursewareResCase.VideoUrl] == DBNull.Value ? null : objRow[conCoursewareResCase.VideoUrl].ToString().Trim(); //视频Url
objCoursewareResCaseEN.VideoPath = objRow[conCoursewareResCase.VideoPath] == DBNull.Value ? null : objRow[conCoursewareResCase.VideoPath].ToString().Trim(); //视频目录
objCoursewareResCaseEN.ResErrMsg = objRow[conCoursewareResCase.ResErrMsg] == DBNull.Value ? null : objRow[conCoursewareResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCoursewareResCaseEN.UpdDate = objRow[conCoursewareResCase.UpdDate] == DBNull.Value ? null : objRow[conCoursewareResCase.UpdDate].ToString().Trim(); //修改日期
objCoursewareResCaseEN.UpdUserId = objRow[conCoursewareResCase.UpdUserId] == DBNull.Value ? null : objRow[conCoursewareResCase.UpdUserId].ToString().Trim(); //修改用户Id
objCoursewareResCaseEN.Memo = objRow[conCoursewareResCase.Memo] == DBNull.Value ? null : objRow[conCoursewareResCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCoursewareResCaseDA: GetObjLst)", objException.Message));
}
objCoursewareResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCoursewareResCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCoursewareResCase(ref clsCoursewareResCaseEN objCoursewareResCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareResCase where IdCoursewareResCase = " + "'"+ objCoursewareResCaseEN.IdCoursewareResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCoursewareResCaseEN.IdCoursewareResCase = objDT.Rows[0][conCoursewareResCase.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareResCaseEN.CoursewareResCaseID = objDT.Rows[0][conCoursewareResCase.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareResCaseEN.CoursewareResCaseName = objDT.Rows[0][conCoursewareResCase.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objCoursewareResCaseEN.CoursewareResCaseTheme = objDT.Rows[0][conCoursewareResCase.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objCoursewareResCaseEN.CoursewareResCaseText = objDT.Rows[0][conCoursewareResCase.CoursewareResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objCoursewareResCaseEN.IdCoursewareResCaseType = objDT.Rows[0][conCoursewareResCase.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCoursewareResCaseEN.CoursewareResCaseDate = objDT.Rows[0][conCoursewareResCase.CoursewareResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objCoursewareResCaseEN.CoursewareResCaseTime = objDT.Rows[0][conCoursewareResCase.CoursewareResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objCoursewareResCaseEN.CoursewareResCaseDateIn = objDT.Rows[0][conCoursewareResCase.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objCoursewareResCaseEN.CoursewareResCaseTimeIn = objDT.Rows[0][conCoursewareResCase.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objCoursewareResCaseEN.OwnerId = objDT.Rows[0][conCoursewareResCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objCoursewareResCaseEN.IdStudyLevel = objDT.Rows[0][conCoursewareResCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objCoursewareResCaseEN.IdTeachingPlan = objDT.Rows[0][conCoursewareResCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareResCaseEN.IdDiscipline = objDT.Rows[0][conCoursewareResCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objCoursewareResCaseEN.BrowseCount = TransNullToInt(objDT.Rows[0][conCoursewareResCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objCoursewareResCaseEN.IdSenateGaugeVersion = objDT.Rows[0][conCoursewareResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objCoursewareResCaseEN.IdTeachSkill = objDT.Rows[0][conCoursewareResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareResCaseEN.CaseLevelId = objDT.Rows[0][conCoursewareResCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objCoursewareResCaseEN.DocFile = objDT.Rows[0][conCoursewareResCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objCoursewareResCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][conCoursewareResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objCoursewareResCaseEN.WordCreateDate = objDT.Rows[0][conCoursewareResCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objCoursewareResCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][conCoursewareResCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objCoursewareResCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][conCoursewareResCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objCoursewareResCaseEN.IdXzCollege = objDT.Rows[0][conCoursewareResCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objCoursewareResCaseEN.IdXzMajor = objDT.Rows[0][conCoursewareResCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareResCaseEN.CourseChapterId = objDT.Rows[0][conCoursewareResCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareResCaseEN.ViewCount = TransNullToInt(objDT.Rows[0][conCoursewareResCase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objCoursewareResCaseEN.IsShow = TransNullToBool(objDT.Rows[0][conCoursewareResCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objCoursewareResCaseEN.DownloadNumber = TransNullToInt(objDT.Rows[0][conCoursewareResCase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objCoursewareResCaseEN.FileIntegration = TransNullToInt(objDT.Rows[0][conCoursewareResCase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objCoursewareResCaseEN.LikeCount = TransNullToInt(objDT.Rows[0][conCoursewareResCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objCoursewareResCaseEN.CollectionCount = TransNullToInt(objDT.Rows[0][conCoursewareResCase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objCoursewareResCaseEN.RecommendedDegreeId = objDT.Rows[0][conCoursewareResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objCoursewareResCaseEN.ftpFileType = objDT.Rows[0][conCoursewareResCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objCoursewareResCaseEN.CourseId = objDT.Rows[0][conCoursewareResCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objCoursewareResCaseEN.VideoUrl = objDT.Rows[0][conCoursewareResCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objCoursewareResCaseEN.VideoPath = objDT.Rows[0][conCoursewareResCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objCoursewareResCaseEN.ResErrMsg = objDT.Rows[0][conCoursewareResCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objCoursewareResCaseEN.UpdDate = objDT.Rows[0][conCoursewareResCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCoursewareResCaseEN.UpdUserId = objDT.Rows[0][conCoursewareResCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCoursewareResCaseEN.Memo = objDT.Rows[0][conCoursewareResCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCoursewareResCaseDA: GetCoursewareResCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCoursewareResCase">表关键字</param>
 /// <returns>表对象</returns>
public clsCoursewareResCaseEN GetObjByIdCoursewareResCase(string strIdCoursewareResCase)
{
CheckPrimaryKey(strIdCoursewareResCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareResCase where IdCoursewareResCase = " + "'"+ strIdCoursewareResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCoursewareResCaseEN objCoursewareResCaseEN = new clsCoursewareResCaseEN();
try
{
 objCoursewareResCaseEN.IdCoursewareResCase = objRow[conCoursewareResCase.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareResCaseEN.CoursewareResCaseID = objRow[conCoursewareResCase.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareResCaseEN.CoursewareResCaseName = objRow[conCoursewareResCase.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objCoursewareResCaseEN.CoursewareResCaseTheme = objRow[conCoursewareResCase.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objCoursewareResCaseEN.CoursewareResCaseText = objRow[conCoursewareResCase.CoursewareResCaseText] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objCoursewareResCaseEN.IdCoursewareResCaseType = objRow[conCoursewareResCase.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCoursewareResCaseEN.CoursewareResCaseDate = objRow[conCoursewareResCase.CoursewareResCaseDate] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objCoursewareResCaseEN.CoursewareResCaseTime = objRow[conCoursewareResCase.CoursewareResCaseTime] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objCoursewareResCaseEN.CoursewareResCaseDateIn = objRow[conCoursewareResCase.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objCoursewareResCaseEN.CoursewareResCaseTimeIn = objRow[conCoursewareResCase.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objCoursewareResCaseEN.OwnerId = objRow[conCoursewareResCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objCoursewareResCaseEN.IdStudyLevel = objRow[conCoursewareResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCoursewareResCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objCoursewareResCaseEN.IdTeachingPlan = objRow[conCoursewareResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCoursewareResCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareResCaseEN.IdDiscipline = objRow[conCoursewareResCase.IdDiscipline] == DBNull.Value ? null : objRow[conCoursewareResCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objCoursewareResCaseEN.BrowseCount = objRow[conCoursewareResCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCoursewareResCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objCoursewareResCaseEN.IdSenateGaugeVersion = objRow[conCoursewareResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCoursewareResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objCoursewareResCaseEN.IdTeachSkill = objRow[conCoursewareResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCoursewareResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareResCaseEN.CaseLevelId = objRow[conCoursewareResCase.CaseLevelId] == DBNull.Value ? null : objRow[conCoursewareResCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objCoursewareResCaseEN.DocFile = objRow[conCoursewareResCase.DocFile] == DBNull.Value ? null : objRow[conCoursewareResCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objCoursewareResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCoursewareResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objCoursewareResCaseEN.WordCreateDate = objRow[conCoursewareResCase.WordCreateDate] == DBNull.Value ? null : objRow[conCoursewareResCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objCoursewareResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCoursewareResCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objCoursewareResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCoursewareResCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objCoursewareResCaseEN.IdXzCollege = objRow[conCoursewareResCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objCoursewareResCaseEN.IdXzMajor = objRow[conCoursewareResCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareResCaseEN.CourseChapterId = objRow[conCoursewareResCase.CourseChapterId] == DBNull.Value ? null : objRow[conCoursewareResCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objCoursewareResCaseEN.ViewCount = objRow[conCoursewareResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCoursewareResCase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objCoursewareResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCoursewareResCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objCoursewareResCaseEN.DownloadNumber = objRow[conCoursewareResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCoursewareResCase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objCoursewareResCaseEN.FileIntegration = objRow[conCoursewareResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCoursewareResCase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objCoursewareResCaseEN.LikeCount = objRow[conCoursewareResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCoursewareResCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objCoursewareResCaseEN.CollectionCount = objRow[conCoursewareResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCoursewareResCase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objCoursewareResCaseEN.RecommendedDegreeId = objRow[conCoursewareResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objCoursewareResCaseEN.ftpFileType = objRow[conCoursewareResCase.ftpFileType] == DBNull.Value ? null : objRow[conCoursewareResCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objCoursewareResCaseEN.CourseId = objRow[conCoursewareResCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objCoursewareResCaseEN.VideoUrl = objRow[conCoursewareResCase.VideoUrl] == DBNull.Value ? null : objRow[conCoursewareResCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objCoursewareResCaseEN.VideoPath = objRow[conCoursewareResCase.VideoPath] == DBNull.Value ? null : objRow[conCoursewareResCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objCoursewareResCaseEN.ResErrMsg = objRow[conCoursewareResCase.ResErrMsg] == DBNull.Value ? null : objRow[conCoursewareResCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objCoursewareResCaseEN.UpdDate = objRow[conCoursewareResCase.UpdDate] == DBNull.Value ? null : objRow[conCoursewareResCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCoursewareResCaseEN.UpdUserId = objRow[conCoursewareResCase.UpdUserId] == DBNull.Value ? null : objRow[conCoursewareResCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCoursewareResCaseEN.Memo = objRow[conCoursewareResCase.Memo] == DBNull.Value ? null : objRow[conCoursewareResCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCoursewareResCaseDA: GetObjByIdCoursewareResCase)", objException.Message));
}
return objCoursewareResCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCoursewareResCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCoursewareResCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCoursewareResCaseEN objCoursewareResCaseEN = new clsCoursewareResCaseEN()
{
IdCoursewareResCase = objRow[conCoursewareResCase.IdCoursewareResCase].ToString().Trim(), //课件资源案例流水号
CoursewareResCaseID = objRow[conCoursewareResCase.CoursewareResCaseID].ToString().Trim(), //课件资源案例ID
CoursewareResCaseName = objRow[conCoursewareResCase.CoursewareResCaseName].ToString().Trim(), //课件资源案例名称
CoursewareResCaseTheme = objRow[conCoursewareResCase.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTheme].ToString().Trim(), //课件资源案例主题词
CoursewareResCaseText = objRow[conCoursewareResCase.CoursewareResCaseText] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseText].ToString().Trim(), //案例文本内容
IdCoursewareResCaseType = objRow[conCoursewareResCase.IdCoursewareResCaseType].ToString().Trim(), //课件资源类型流水号
CoursewareResCaseDate = objRow[conCoursewareResCase.CoursewareResCaseDate] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseDate].ToString().Trim(), //视频资源日期
CoursewareResCaseTime = objRow[conCoursewareResCase.CoursewareResCaseTime] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTime].ToString().Trim(), //视频资源时间
CoursewareResCaseDateIn = objRow[conCoursewareResCase.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseDateIn].ToString().Trim(), //案例入库日期
CoursewareResCaseTimeIn = objRow[conCoursewareResCase.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTimeIn].ToString().Trim(), //案例入库时间
OwnerId = objRow[conCoursewareResCase.OwnerId].ToString().Trim(), //拥有者Id
IdStudyLevel = objRow[conCoursewareResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCoursewareResCase.IdStudyLevel].ToString().Trim(), //学段流水号
IdTeachingPlan = objRow[conCoursewareResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCoursewareResCase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdDiscipline = objRow[conCoursewareResCase.IdDiscipline] == DBNull.Value ? null : objRow[conCoursewareResCase.IdDiscipline].ToString().Trim(), //学科流水号
BrowseCount = objRow[conCoursewareResCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[conCoursewareResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCoursewareResCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
IdTeachSkill = objRow[conCoursewareResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCoursewareResCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
CaseLevelId = objRow[conCoursewareResCase.CaseLevelId] == DBNull.Value ? null : objRow[conCoursewareResCase.CaseLevelId].ToString().Trim(), //课例等级Id
DocFile = objRow[conCoursewareResCase.DocFile] == DBNull.Value ? null : objRow[conCoursewareResCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[conCoursewareResCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[conCoursewareResCase.WordCreateDate] == DBNull.Value ? null : objRow[conCoursewareResCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[conCoursewareResCase.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[conCoursewareResCase.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[conCoursewareResCase.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[conCoursewareResCase.IdXzMajor].ToString().Trim(), //专业流水号
CourseChapterId = objRow[conCoursewareResCase.CourseChapterId] == DBNull.Value ? null : objRow[conCoursewareResCase.CourseChapterId].ToString().Trim(), //课程章节ID
ViewCount = objRow[conCoursewareResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[conCoursewareResCase.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[conCoursewareResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[conCoursewareResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[conCoursewareResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCoursewareResCase.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[conCoursewareResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCoursewareResCase.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[conCoursewareResCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
ftpFileType = objRow[conCoursewareResCase.ftpFileType] == DBNull.Value ? null : objRow[conCoursewareResCase.ftpFileType].ToString().Trim(), //ftp文件类型
CourseId = objRow[conCoursewareResCase.CourseId].ToString().Trim(), //课程Id
VideoUrl = objRow[conCoursewareResCase.VideoUrl] == DBNull.Value ? null : objRow[conCoursewareResCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[conCoursewareResCase.VideoPath] == DBNull.Value ? null : objRow[conCoursewareResCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[conCoursewareResCase.ResErrMsg] == DBNull.Value ? null : objRow[conCoursewareResCase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdDate = objRow[conCoursewareResCase.UpdDate] == DBNull.Value ? null : objRow[conCoursewareResCase.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conCoursewareResCase.UpdUserId] == DBNull.Value ? null : objRow[conCoursewareResCase.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conCoursewareResCase.Memo] == DBNull.Value ? null : objRow[conCoursewareResCase.Memo].ToString().Trim() //备注
};
objCoursewareResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCoursewareResCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCoursewareResCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCoursewareResCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCoursewareResCaseEN objCoursewareResCaseEN = new clsCoursewareResCaseEN();
try
{
objCoursewareResCaseEN.IdCoursewareResCase = objRow[conCoursewareResCase.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objCoursewareResCaseEN.CoursewareResCaseID = objRow[conCoursewareResCase.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objCoursewareResCaseEN.CoursewareResCaseName = objRow[conCoursewareResCase.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objCoursewareResCaseEN.CoursewareResCaseTheme = objRow[conCoursewareResCase.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objCoursewareResCaseEN.CoursewareResCaseText = objRow[conCoursewareResCase.CoursewareResCaseText] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseText].ToString().Trim(); //案例文本内容
objCoursewareResCaseEN.IdCoursewareResCaseType = objRow[conCoursewareResCase.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objCoursewareResCaseEN.CoursewareResCaseDate = objRow[conCoursewareResCase.CoursewareResCaseDate] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objCoursewareResCaseEN.CoursewareResCaseTime = objRow[conCoursewareResCase.CoursewareResCaseTime] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objCoursewareResCaseEN.CoursewareResCaseDateIn = objRow[conCoursewareResCase.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objCoursewareResCaseEN.CoursewareResCaseTimeIn = objRow[conCoursewareResCase.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objCoursewareResCaseEN.OwnerId = objRow[conCoursewareResCase.OwnerId].ToString().Trim(); //拥有者Id
objCoursewareResCaseEN.IdStudyLevel = objRow[conCoursewareResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCoursewareResCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCoursewareResCaseEN.IdTeachingPlan = objRow[conCoursewareResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCoursewareResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCoursewareResCaseEN.IdDiscipline = objRow[conCoursewareResCase.IdDiscipline] == DBNull.Value ? null : objRow[conCoursewareResCase.IdDiscipline].ToString().Trim(); //学科流水号
objCoursewareResCaseEN.BrowseCount = objRow[conCoursewareResCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.BrowseCount].ToString().Trim()); //浏览次数
objCoursewareResCaseEN.IdSenateGaugeVersion = objRow[conCoursewareResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCoursewareResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCoursewareResCaseEN.IdTeachSkill = objRow[conCoursewareResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCoursewareResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCoursewareResCaseEN.CaseLevelId = objRow[conCoursewareResCase.CaseLevelId] == DBNull.Value ? null : objRow[conCoursewareResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCoursewareResCaseEN.DocFile = objRow[conCoursewareResCase.DocFile] == DBNull.Value ? null : objRow[conCoursewareResCase.DocFile].ToString().Trim(); //生成的Word文件名
objCoursewareResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conCoursewareResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCoursewareResCaseEN.WordCreateDate = objRow[conCoursewareResCase.WordCreateDate] == DBNull.Value ? null : objRow[conCoursewareResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCoursewareResCaseEN.IsVisible = TransNullToBool(objRow[conCoursewareResCase.IsVisible].ToString().Trim()); //是否显示
objCoursewareResCaseEN.IsDualVideo = TransNullToBool(objRow[conCoursewareResCase.IsDualVideo].ToString().Trim()); //是否双视频
objCoursewareResCaseEN.IdXzCollege = objRow[conCoursewareResCase.IdXzCollege].ToString().Trim(); //学院流水号
objCoursewareResCaseEN.IdXzMajor = objRow[conCoursewareResCase.IdXzMajor].ToString().Trim(); //专业流水号
objCoursewareResCaseEN.CourseChapterId = objRow[conCoursewareResCase.CourseChapterId] == DBNull.Value ? null : objRow[conCoursewareResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCoursewareResCaseEN.ViewCount = objRow[conCoursewareResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.ViewCount].ToString().Trim()); //浏览量
objCoursewareResCaseEN.IsShow = TransNullToBool(objRow[conCoursewareResCase.IsShow].ToString().Trim()); //是否启用
objCoursewareResCaseEN.DownloadNumber = objRow[conCoursewareResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.DownloadNumber].ToString().Trim()); //下载数目
objCoursewareResCaseEN.FileIntegration = objRow[conCoursewareResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.FileIntegration].ToString().Trim()); //文件积分
objCoursewareResCaseEN.LikeCount = objRow[conCoursewareResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCoursewareResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCoursewareResCaseEN.CollectionCount = objRow[conCoursewareResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCoursewareResCase.CollectionCount].ToString().Trim()); //收藏数量
objCoursewareResCaseEN.RecommendedDegreeId = objRow[conCoursewareResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCoursewareResCaseEN.ftpFileType = objRow[conCoursewareResCase.ftpFileType] == DBNull.Value ? null : objRow[conCoursewareResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCoursewareResCaseEN.CourseId = objRow[conCoursewareResCase.CourseId].ToString().Trim(); //课程Id
objCoursewareResCaseEN.VideoUrl = objRow[conCoursewareResCase.VideoUrl] == DBNull.Value ? null : objRow[conCoursewareResCase.VideoUrl].ToString().Trim(); //视频Url
objCoursewareResCaseEN.VideoPath = objRow[conCoursewareResCase.VideoPath] == DBNull.Value ? null : objRow[conCoursewareResCase.VideoPath].ToString().Trim(); //视频目录
objCoursewareResCaseEN.ResErrMsg = objRow[conCoursewareResCase.ResErrMsg] == DBNull.Value ? null : objRow[conCoursewareResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCoursewareResCaseEN.UpdDate = objRow[conCoursewareResCase.UpdDate] == DBNull.Value ? null : objRow[conCoursewareResCase.UpdDate].ToString().Trim(); //修改日期
objCoursewareResCaseEN.UpdUserId = objRow[conCoursewareResCase.UpdUserId] == DBNull.Value ? null : objRow[conCoursewareResCase.UpdUserId].ToString().Trim(); //修改用户Id
objCoursewareResCaseEN.Memo = objRow[conCoursewareResCase.Memo] == DBNull.Value ? null : objRow[conCoursewareResCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCoursewareResCaseDA: GetObjByDataRowCoursewareResCase)", objException.Message));
}
objCoursewareResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCoursewareResCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCoursewareResCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCoursewareResCaseEN objCoursewareResCaseEN = new clsCoursewareResCaseEN();
try
{
objCoursewareResCaseEN.IdCoursewareResCase = objRow[conCoursewareResCase.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objCoursewareResCaseEN.CoursewareResCaseID = objRow[conCoursewareResCase.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objCoursewareResCaseEN.CoursewareResCaseName = objRow[conCoursewareResCase.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objCoursewareResCaseEN.CoursewareResCaseTheme = objRow[conCoursewareResCase.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objCoursewareResCaseEN.CoursewareResCaseText = objRow[conCoursewareResCase.CoursewareResCaseText] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseText].ToString().Trim(); //案例文本内容
objCoursewareResCaseEN.IdCoursewareResCaseType = objRow[conCoursewareResCase.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objCoursewareResCaseEN.CoursewareResCaseDate = objRow[conCoursewareResCase.CoursewareResCaseDate] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objCoursewareResCaseEN.CoursewareResCaseTime = objRow[conCoursewareResCase.CoursewareResCaseTime] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objCoursewareResCaseEN.CoursewareResCaseDateIn = objRow[conCoursewareResCase.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objCoursewareResCaseEN.CoursewareResCaseTimeIn = objRow[conCoursewareResCase.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[conCoursewareResCase.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objCoursewareResCaseEN.OwnerId = objRow[conCoursewareResCase.OwnerId].ToString().Trim(); //拥有者Id
objCoursewareResCaseEN.IdStudyLevel = objRow[conCoursewareResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCoursewareResCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCoursewareResCaseEN.IdTeachingPlan = objRow[conCoursewareResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCoursewareResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCoursewareResCaseEN.IdDiscipline = objRow[conCoursewareResCase.IdDiscipline] == DBNull.Value ? null : objRow[conCoursewareResCase.IdDiscipline].ToString().Trim(); //学科流水号
objCoursewareResCaseEN.BrowseCount = objRow[conCoursewareResCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.BrowseCount].ToString().Trim()); //浏览次数
objCoursewareResCaseEN.IdSenateGaugeVersion = objRow[conCoursewareResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCoursewareResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCoursewareResCaseEN.IdTeachSkill = objRow[conCoursewareResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCoursewareResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCoursewareResCaseEN.CaseLevelId = objRow[conCoursewareResCase.CaseLevelId] == DBNull.Value ? null : objRow[conCoursewareResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCoursewareResCaseEN.DocFile = objRow[conCoursewareResCase.DocFile] == DBNull.Value ? null : objRow[conCoursewareResCase.DocFile].ToString().Trim(); //生成的Word文件名
objCoursewareResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conCoursewareResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCoursewareResCaseEN.WordCreateDate = objRow[conCoursewareResCase.WordCreateDate] == DBNull.Value ? null : objRow[conCoursewareResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCoursewareResCaseEN.IsVisible = TransNullToBool(objRow[conCoursewareResCase.IsVisible].ToString().Trim()); //是否显示
objCoursewareResCaseEN.IsDualVideo = TransNullToBool(objRow[conCoursewareResCase.IsDualVideo].ToString().Trim()); //是否双视频
objCoursewareResCaseEN.IdXzCollege = objRow[conCoursewareResCase.IdXzCollege].ToString().Trim(); //学院流水号
objCoursewareResCaseEN.IdXzMajor = objRow[conCoursewareResCase.IdXzMajor].ToString().Trim(); //专业流水号
objCoursewareResCaseEN.CourseChapterId = objRow[conCoursewareResCase.CourseChapterId] == DBNull.Value ? null : objRow[conCoursewareResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCoursewareResCaseEN.ViewCount = objRow[conCoursewareResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.ViewCount].ToString().Trim()); //浏览量
objCoursewareResCaseEN.IsShow = TransNullToBool(objRow[conCoursewareResCase.IsShow].ToString().Trim()); //是否启用
objCoursewareResCaseEN.DownloadNumber = objRow[conCoursewareResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.DownloadNumber].ToString().Trim()); //下载数目
objCoursewareResCaseEN.FileIntegration = objRow[conCoursewareResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCoursewareResCase.FileIntegration].ToString().Trim()); //文件积分
objCoursewareResCaseEN.LikeCount = objRow[conCoursewareResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCoursewareResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCoursewareResCaseEN.CollectionCount = objRow[conCoursewareResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCoursewareResCase.CollectionCount].ToString().Trim()); //收藏数量
objCoursewareResCaseEN.RecommendedDegreeId = objRow[conCoursewareResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCoursewareResCaseEN.ftpFileType = objRow[conCoursewareResCase.ftpFileType] == DBNull.Value ? null : objRow[conCoursewareResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCoursewareResCaseEN.CourseId = objRow[conCoursewareResCase.CourseId].ToString().Trim(); //课程Id
objCoursewareResCaseEN.VideoUrl = objRow[conCoursewareResCase.VideoUrl] == DBNull.Value ? null : objRow[conCoursewareResCase.VideoUrl].ToString().Trim(); //视频Url
objCoursewareResCaseEN.VideoPath = objRow[conCoursewareResCase.VideoPath] == DBNull.Value ? null : objRow[conCoursewareResCase.VideoPath].ToString().Trim(); //视频目录
objCoursewareResCaseEN.ResErrMsg = objRow[conCoursewareResCase.ResErrMsg] == DBNull.Value ? null : objRow[conCoursewareResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCoursewareResCaseEN.UpdDate = objRow[conCoursewareResCase.UpdDate] == DBNull.Value ? null : objRow[conCoursewareResCase.UpdDate].ToString().Trim(); //修改日期
objCoursewareResCaseEN.UpdUserId = objRow[conCoursewareResCase.UpdUserId] == DBNull.Value ? null : objRow[conCoursewareResCase.UpdUserId].ToString().Trim(); //修改用户Id
objCoursewareResCaseEN.Memo = objRow[conCoursewareResCase.Memo] == DBNull.Value ? null : objRow[conCoursewareResCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCoursewareResCaseDA: GetObjByDataRow)", objException.Message));
}
objCoursewareResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCoursewareResCaseEN;
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
objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCoursewareResCaseEN._CurrTabName, conCoursewareResCase.IdCoursewareResCase, 8, "");
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
objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCoursewareResCaseEN._CurrTabName, conCoursewareResCase.IdCoursewareResCase, 8, strPrefix);
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
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCoursewareResCase from CoursewareResCase where " + strCondition;
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
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCoursewareResCase from CoursewareResCase where " + strCondition;
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
 /// <param name = "strIdCoursewareResCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdCoursewareResCase)
{
CheckPrimaryKey(strIdCoursewareResCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CoursewareResCase", "IdCoursewareResCase = " + "'"+ strIdCoursewareResCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCoursewareResCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CoursewareResCase", strCondition))
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
objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CoursewareResCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCoursewareResCaseEN objCoursewareResCaseEN)
 {
 objCoursewareResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareResCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCoursewareResCaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareResCase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CoursewareResCase");
objRow = objDS.Tables["CoursewareResCase"].NewRow();
objRow[conCoursewareResCase.IdCoursewareResCase] = objCoursewareResCaseEN.IdCoursewareResCase; //课件资源案例流水号
objRow[conCoursewareResCase.CoursewareResCaseID] = objCoursewareResCaseEN.CoursewareResCaseID; //课件资源案例ID
objRow[conCoursewareResCase.CoursewareResCaseName] = objCoursewareResCaseEN.CoursewareResCaseName; //课件资源案例名称
 if (objCoursewareResCaseEN.CoursewareResCaseTheme !=  "")
 {
objRow[conCoursewareResCase.CoursewareResCaseTheme] = objCoursewareResCaseEN.CoursewareResCaseTheme; //课件资源案例主题词
 }
 if (objCoursewareResCaseEN.CoursewareResCaseText !=  "")
 {
objRow[conCoursewareResCase.CoursewareResCaseText] = objCoursewareResCaseEN.CoursewareResCaseText; //案例文本内容
 }
objRow[conCoursewareResCase.IdCoursewareResCaseType] = objCoursewareResCaseEN.IdCoursewareResCaseType; //课件资源类型流水号
 if (objCoursewareResCaseEN.CoursewareResCaseDate !=  "")
 {
objRow[conCoursewareResCase.CoursewareResCaseDate] = objCoursewareResCaseEN.CoursewareResCaseDate; //视频资源日期
 }
 if (objCoursewareResCaseEN.CoursewareResCaseTime !=  "")
 {
objRow[conCoursewareResCase.CoursewareResCaseTime] = objCoursewareResCaseEN.CoursewareResCaseTime; //视频资源时间
 }
 if (objCoursewareResCaseEN.CoursewareResCaseDateIn !=  "")
 {
objRow[conCoursewareResCase.CoursewareResCaseDateIn] = objCoursewareResCaseEN.CoursewareResCaseDateIn; //案例入库日期
 }
 if (objCoursewareResCaseEN.CoursewareResCaseTimeIn !=  "")
 {
objRow[conCoursewareResCase.CoursewareResCaseTimeIn] = objCoursewareResCaseEN.CoursewareResCaseTimeIn; //案例入库时间
 }
objRow[conCoursewareResCase.OwnerId] = objCoursewareResCaseEN.OwnerId; //拥有者Id
 if (objCoursewareResCaseEN.IdStudyLevel !=  "")
 {
objRow[conCoursewareResCase.IdStudyLevel] = objCoursewareResCaseEN.IdStudyLevel; //学段流水号
 }
 if (objCoursewareResCaseEN.IdTeachingPlan !=  "")
 {
objRow[conCoursewareResCase.IdTeachingPlan] = objCoursewareResCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objCoursewareResCaseEN.IdDiscipline !=  "")
 {
objRow[conCoursewareResCase.IdDiscipline] = objCoursewareResCaseEN.IdDiscipline; //学科流水号
 }
objRow[conCoursewareResCase.BrowseCount] = objCoursewareResCaseEN.BrowseCount; //浏览次数
 if (objCoursewareResCaseEN.IdSenateGaugeVersion !=  "")
 {
objRow[conCoursewareResCase.IdSenateGaugeVersion] = objCoursewareResCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objCoursewareResCaseEN.IdTeachSkill !=  "")
 {
objRow[conCoursewareResCase.IdTeachSkill] = objCoursewareResCaseEN.IdTeachSkill; //教学技能流水号
 }
 if (objCoursewareResCaseEN.CaseLevelId !=  "")
 {
objRow[conCoursewareResCase.CaseLevelId] = objCoursewareResCaseEN.CaseLevelId; //课例等级Id
 }
 if (objCoursewareResCaseEN.DocFile !=  "")
 {
objRow[conCoursewareResCase.DocFile] = objCoursewareResCaseEN.DocFile; //生成的Word文件名
 }
objRow[conCoursewareResCase.IsNeedGeneWord] = objCoursewareResCaseEN.IsNeedGeneWord; //是否需要生成Word
 if (objCoursewareResCaseEN.WordCreateDate !=  "")
 {
objRow[conCoursewareResCase.WordCreateDate] = objCoursewareResCaseEN.WordCreateDate; //Word生成日期
 }
objRow[conCoursewareResCase.IsVisible] = objCoursewareResCaseEN.IsVisible; //是否显示
objRow[conCoursewareResCase.IsDualVideo] = objCoursewareResCaseEN.IsDualVideo; //是否双视频
objRow[conCoursewareResCase.IdXzCollege] = objCoursewareResCaseEN.IdXzCollege; //学院流水号
objRow[conCoursewareResCase.IdXzMajor] = objCoursewareResCaseEN.IdXzMajor; //专业流水号
 if (objCoursewareResCaseEN.CourseChapterId !=  "")
 {
objRow[conCoursewareResCase.CourseChapterId] = objCoursewareResCaseEN.CourseChapterId; //课程章节ID
 }
objRow[conCoursewareResCase.ViewCount] = objCoursewareResCaseEN.ViewCount; //浏览量
objRow[conCoursewareResCase.IsShow] = objCoursewareResCaseEN.IsShow; //是否启用
objRow[conCoursewareResCase.DownloadNumber] = objCoursewareResCaseEN.DownloadNumber; //下载数目
objRow[conCoursewareResCase.FileIntegration] = objCoursewareResCaseEN.FileIntegration; //文件积分
objRow[conCoursewareResCase.LikeCount] = objCoursewareResCaseEN.LikeCount; //资源喜欢数量
objRow[conCoursewareResCase.CollectionCount] = objCoursewareResCaseEN.CollectionCount; //收藏数量
objRow[conCoursewareResCase.RecommendedDegreeId] = objCoursewareResCaseEN.RecommendedDegreeId; //推荐度Id
 if (objCoursewareResCaseEN.ftpFileType !=  "")
 {
objRow[conCoursewareResCase.ftpFileType] = objCoursewareResCaseEN.ftpFileType; //ftp文件类型
 }
objRow[conCoursewareResCase.CourseId] = objCoursewareResCaseEN.CourseId; //课程Id
 if (objCoursewareResCaseEN.VideoUrl !=  "")
 {
objRow[conCoursewareResCase.VideoUrl] = objCoursewareResCaseEN.VideoUrl; //视频Url
 }
 if (objCoursewareResCaseEN.VideoPath !=  "")
 {
objRow[conCoursewareResCase.VideoPath] = objCoursewareResCaseEN.VideoPath; //视频目录
 }
 if (objCoursewareResCaseEN.ResErrMsg !=  "")
 {
objRow[conCoursewareResCase.ResErrMsg] = objCoursewareResCaseEN.ResErrMsg; //资源错误信息
 }
 if (objCoursewareResCaseEN.UpdDate !=  "")
 {
objRow[conCoursewareResCase.UpdDate] = objCoursewareResCaseEN.UpdDate; //修改日期
 }
 if (objCoursewareResCaseEN.UpdUserId !=  "")
 {
objRow[conCoursewareResCase.UpdUserId] = objCoursewareResCaseEN.UpdUserId; //修改用户Id
 }
 if (objCoursewareResCaseEN.Memo !=  "")
 {
objRow[conCoursewareResCase.Memo] = objCoursewareResCaseEN.Memo; //备注
 }
objDS.Tables[clsCoursewareResCaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCoursewareResCaseEN._CurrTabName);
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
 /// <param name = "objCoursewareResCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCoursewareResCaseEN objCoursewareResCaseEN)
{
 objCoursewareResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareResCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCoursewareResCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCoursewareResCaseEN.IdCoursewareResCase !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdCoursewareResCase);
 var strIdCoursewareResCase = objCoursewareResCaseEN.IdCoursewareResCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCoursewareResCase + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseID !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseID);
 var strCoursewareResCaseID = objCoursewareResCaseEN.CoursewareResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseID + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseName !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseName);
 var strCoursewareResCaseName = objCoursewareResCaseEN.CoursewareResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseName + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseTheme);
 var strCoursewareResCaseTheme = objCoursewareResCaseEN.CoursewareResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseTheme + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseText !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseText);
 var strCoursewareResCaseText = objCoursewareResCaseEN.CoursewareResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseText + "'");
 }
 
 if (objCoursewareResCaseEN.IdCoursewareResCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdCoursewareResCaseType);
 var strIdCoursewareResCaseType = objCoursewareResCaseEN.IdCoursewareResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCoursewareResCaseType + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseDate);
 var strCoursewareResCaseDate = objCoursewareResCaseEN.CoursewareResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseDate + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseTime);
 var strCoursewareResCaseTime = objCoursewareResCaseEN.CoursewareResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseTime + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseDateIn);
 var strCoursewareResCaseDateIn = objCoursewareResCaseEN.CoursewareResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseDateIn + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseTimeIn);
 var strCoursewareResCaseTimeIn = objCoursewareResCaseEN.CoursewareResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseTimeIn + "'");
 }
 
 if (objCoursewareResCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.OwnerId);
 var strOwnerId = objCoursewareResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCoursewareResCaseEN.IdStudyLevel  ==  "")
 {
 objCoursewareResCaseEN.IdStudyLevel = null;
 }
 if (objCoursewareResCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdStudyLevel);
 var strIdStudyLevel = objCoursewareResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objCoursewareResCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdTeachingPlan);
 var strIdTeachingPlan = objCoursewareResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objCoursewareResCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdDiscipline);
 var strIdDiscipline = objCoursewareResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objCoursewareResCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.BrowseCount);
 arrValueListForInsert.Add(objCoursewareResCaseEN.BrowseCount.ToString());
 }
 
 if (objCoursewareResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCoursewareResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCoursewareResCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objCoursewareResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objCoursewareResCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdTeachSkill);
 var strIdTeachSkill = objCoursewareResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objCoursewareResCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CaseLevelId);
 var strCaseLevelId = objCoursewareResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objCoursewareResCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.DocFile);
 var strDocFile = objCoursewareResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareResCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objCoursewareResCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareResCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.WordCreateDate);
 var strWordCreateDate = objCoursewareResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareResCase.IsVisible);
 arrValueListForInsert.Add("'" + (objCoursewareResCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCoursewareResCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objCoursewareResCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareResCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdXzCollege);
 var strIdXzCollege = objCoursewareResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCoursewareResCaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdXzMajor);
 var strIdXzMajor = objCoursewareResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objCoursewareResCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CourseChapterId);
 var strCourseChapterId = objCoursewareResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objCoursewareResCaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.ViewCount);
 arrValueListForInsert.Add(objCoursewareResCaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conCoursewareResCase.IsShow);
 arrValueListForInsert.Add("'" + (objCoursewareResCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareResCaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.DownloadNumber);
 arrValueListForInsert.Add(objCoursewareResCaseEN.DownloadNumber.ToString());
 }
 
 if (objCoursewareResCaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.FileIntegration);
 arrValueListForInsert.Add(objCoursewareResCaseEN.FileIntegration.ToString());
 }
 
 if (objCoursewareResCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.LikeCount);
 arrValueListForInsert.Add(objCoursewareResCaseEN.LikeCount.ToString());
 }
 
 if (objCoursewareResCaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CollectionCount);
 arrValueListForInsert.Add(objCoursewareResCaseEN.CollectionCount.ToString());
 }
 
 if (objCoursewareResCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objCoursewareResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objCoursewareResCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.ftpFileType);
 var strftpFileType = objCoursewareResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objCoursewareResCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CourseId);
 var strCourseId = objCoursewareResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCoursewareResCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.VideoUrl);
 var strVideoUrl = objCoursewareResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objCoursewareResCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.VideoPath);
 var strVideoPath = objCoursewareResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objCoursewareResCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.ResErrMsg);
 var strResErrMsg = objCoursewareResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objCoursewareResCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.UpdDate);
 var strUpdDate = objCoursewareResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCoursewareResCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.UpdUserId);
 var strUpdUserId = objCoursewareResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCoursewareResCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.Memo);
 var strMemo = objCoursewareResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CoursewareResCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCoursewareResCaseEN objCoursewareResCaseEN)
{
 objCoursewareResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareResCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCoursewareResCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCoursewareResCaseEN.IdCoursewareResCase !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdCoursewareResCase);
 var strIdCoursewareResCase = objCoursewareResCaseEN.IdCoursewareResCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCoursewareResCase + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseID !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseID);
 var strCoursewareResCaseID = objCoursewareResCaseEN.CoursewareResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseID + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseName !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseName);
 var strCoursewareResCaseName = objCoursewareResCaseEN.CoursewareResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseName + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseTheme);
 var strCoursewareResCaseTheme = objCoursewareResCaseEN.CoursewareResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseTheme + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseText !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseText);
 var strCoursewareResCaseText = objCoursewareResCaseEN.CoursewareResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseText + "'");
 }
 
 if (objCoursewareResCaseEN.IdCoursewareResCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdCoursewareResCaseType);
 var strIdCoursewareResCaseType = objCoursewareResCaseEN.IdCoursewareResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCoursewareResCaseType + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseDate);
 var strCoursewareResCaseDate = objCoursewareResCaseEN.CoursewareResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseDate + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseTime);
 var strCoursewareResCaseTime = objCoursewareResCaseEN.CoursewareResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseTime + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseDateIn);
 var strCoursewareResCaseDateIn = objCoursewareResCaseEN.CoursewareResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseDateIn + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseTimeIn);
 var strCoursewareResCaseTimeIn = objCoursewareResCaseEN.CoursewareResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseTimeIn + "'");
 }
 
 if (objCoursewareResCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.OwnerId);
 var strOwnerId = objCoursewareResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCoursewareResCaseEN.IdStudyLevel  ==  "")
 {
 objCoursewareResCaseEN.IdStudyLevel = null;
 }
 if (objCoursewareResCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdStudyLevel);
 var strIdStudyLevel = objCoursewareResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objCoursewareResCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdTeachingPlan);
 var strIdTeachingPlan = objCoursewareResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objCoursewareResCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdDiscipline);
 var strIdDiscipline = objCoursewareResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objCoursewareResCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.BrowseCount);
 arrValueListForInsert.Add(objCoursewareResCaseEN.BrowseCount.ToString());
 }
 
 if (objCoursewareResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCoursewareResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCoursewareResCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objCoursewareResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objCoursewareResCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdTeachSkill);
 var strIdTeachSkill = objCoursewareResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objCoursewareResCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CaseLevelId);
 var strCaseLevelId = objCoursewareResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objCoursewareResCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.DocFile);
 var strDocFile = objCoursewareResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareResCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objCoursewareResCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareResCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.WordCreateDate);
 var strWordCreateDate = objCoursewareResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareResCase.IsVisible);
 arrValueListForInsert.Add("'" + (objCoursewareResCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCoursewareResCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objCoursewareResCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareResCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdXzCollege);
 var strIdXzCollege = objCoursewareResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCoursewareResCaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdXzMajor);
 var strIdXzMajor = objCoursewareResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objCoursewareResCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CourseChapterId);
 var strCourseChapterId = objCoursewareResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objCoursewareResCaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.ViewCount);
 arrValueListForInsert.Add(objCoursewareResCaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conCoursewareResCase.IsShow);
 arrValueListForInsert.Add("'" + (objCoursewareResCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareResCaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.DownloadNumber);
 arrValueListForInsert.Add(objCoursewareResCaseEN.DownloadNumber.ToString());
 }
 
 if (objCoursewareResCaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.FileIntegration);
 arrValueListForInsert.Add(objCoursewareResCaseEN.FileIntegration.ToString());
 }
 
 if (objCoursewareResCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.LikeCount);
 arrValueListForInsert.Add(objCoursewareResCaseEN.LikeCount.ToString());
 }
 
 if (objCoursewareResCaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CollectionCount);
 arrValueListForInsert.Add(objCoursewareResCaseEN.CollectionCount.ToString());
 }
 
 if (objCoursewareResCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objCoursewareResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objCoursewareResCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.ftpFileType);
 var strftpFileType = objCoursewareResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objCoursewareResCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CourseId);
 var strCourseId = objCoursewareResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCoursewareResCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.VideoUrl);
 var strVideoUrl = objCoursewareResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objCoursewareResCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.VideoPath);
 var strVideoPath = objCoursewareResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objCoursewareResCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.ResErrMsg);
 var strResErrMsg = objCoursewareResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objCoursewareResCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.UpdDate);
 var strUpdDate = objCoursewareResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCoursewareResCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.UpdUserId);
 var strUpdUserId = objCoursewareResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCoursewareResCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.Memo);
 var strMemo = objCoursewareResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CoursewareResCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCoursewareResCaseEN.IdCoursewareResCase;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCoursewareResCaseEN objCoursewareResCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCoursewareResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareResCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCoursewareResCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCoursewareResCaseEN.IdCoursewareResCase !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdCoursewareResCase);
 var strIdCoursewareResCase = objCoursewareResCaseEN.IdCoursewareResCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCoursewareResCase + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseID !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseID);
 var strCoursewareResCaseID = objCoursewareResCaseEN.CoursewareResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseID + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseName !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseName);
 var strCoursewareResCaseName = objCoursewareResCaseEN.CoursewareResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseName + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseTheme);
 var strCoursewareResCaseTheme = objCoursewareResCaseEN.CoursewareResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseTheme + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseText !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseText);
 var strCoursewareResCaseText = objCoursewareResCaseEN.CoursewareResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseText + "'");
 }
 
 if (objCoursewareResCaseEN.IdCoursewareResCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdCoursewareResCaseType);
 var strIdCoursewareResCaseType = objCoursewareResCaseEN.IdCoursewareResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCoursewareResCaseType + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseDate);
 var strCoursewareResCaseDate = objCoursewareResCaseEN.CoursewareResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseDate + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseTime);
 var strCoursewareResCaseTime = objCoursewareResCaseEN.CoursewareResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseTime + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseDateIn);
 var strCoursewareResCaseDateIn = objCoursewareResCaseEN.CoursewareResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseDateIn + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseTimeIn);
 var strCoursewareResCaseTimeIn = objCoursewareResCaseEN.CoursewareResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseTimeIn + "'");
 }
 
 if (objCoursewareResCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.OwnerId);
 var strOwnerId = objCoursewareResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCoursewareResCaseEN.IdStudyLevel  ==  "")
 {
 objCoursewareResCaseEN.IdStudyLevel = null;
 }
 if (objCoursewareResCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdStudyLevel);
 var strIdStudyLevel = objCoursewareResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objCoursewareResCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdTeachingPlan);
 var strIdTeachingPlan = objCoursewareResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objCoursewareResCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdDiscipline);
 var strIdDiscipline = objCoursewareResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objCoursewareResCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.BrowseCount);
 arrValueListForInsert.Add(objCoursewareResCaseEN.BrowseCount.ToString());
 }
 
 if (objCoursewareResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCoursewareResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCoursewareResCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objCoursewareResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objCoursewareResCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdTeachSkill);
 var strIdTeachSkill = objCoursewareResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objCoursewareResCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CaseLevelId);
 var strCaseLevelId = objCoursewareResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objCoursewareResCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.DocFile);
 var strDocFile = objCoursewareResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareResCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objCoursewareResCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareResCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.WordCreateDate);
 var strWordCreateDate = objCoursewareResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareResCase.IsVisible);
 arrValueListForInsert.Add("'" + (objCoursewareResCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCoursewareResCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objCoursewareResCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareResCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdXzCollege);
 var strIdXzCollege = objCoursewareResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCoursewareResCaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdXzMajor);
 var strIdXzMajor = objCoursewareResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objCoursewareResCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CourseChapterId);
 var strCourseChapterId = objCoursewareResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objCoursewareResCaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.ViewCount);
 arrValueListForInsert.Add(objCoursewareResCaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conCoursewareResCase.IsShow);
 arrValueListForInsert.Add("'" + (objCoursewareResCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareResCaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.DownloadNumber);
 arrValueListForInsert.Add(objCoursewareResCaseEN.DownloadNumber.ToString());
 }
 
 if (objCoursewareResCaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.FileIntegration);
 arrValueListForInsert.Add(objCoursewareResCaseEN.FileIntegration.ToString());
 }
 
 if (objCoursewareResCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.LikeCount);
 arrValueListForInsert.Add(objCoursewareResCaseEN.LikeCount.ToString());
 }
 
 if (objCoursewareResCaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CollectionCount);
 arrValueListForInsert.Add(objCoursewareResCaseEN.CollectionCount.ToString());
 }
 
 if (objCoursewareResCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objCoursewareResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objCoursewareResCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.ftpFileType);
 var strftpFileType = objCoursewareResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objCoursewareResCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CourseId);
 var strCourseId = objCoursewareResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCoursewareResCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.VideoUrl);
 var strVideoUrl = objCoursewareResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objCoursewareResCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.VideoPath);
 var strVideoPath = objCoursewareResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objCoursewareResCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.ResErrMsg);
 var strResErrMsg = objCoursewareResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objCoursewareResCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.UpdDate);
 var strUpdDate = objCoursewareResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCoursewareResCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.UpdUserId);
 var strUpdUserId = objCoursewareResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCoursewareResCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.Memo);
 var strMemo = objCoursewareResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CoursewareResCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCoursewareResCaseEN.IdCoursewareResCase;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCoursewareResCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCoursewareResCaseEN objCoursewareResCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCoursewareResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareResCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCoursewareResCaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCoursewareResCaseEN.IdCoursewareResCase !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdCoursewareResCase);
 var strIdCoursewareResCase = objCoursewareResCaseEN.IdCoursewareResCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCoursewareResCase + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseID !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseID);
 var strCoursewareResCaseID = objCoursewareResCaseEN.CoursewareResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseID + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseName !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseName);
 var strCoursewareResCaseName = objCoursewareResCaseEN.CoursewareResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseName + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseTheme);
 var strCoursewareResCaseTheme = objCoursewareResCaseEN.CoursewareResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseTheme + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseText !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseText);
 var strCoursewareResCaseText = objCoursewareResCaseEN.CoursewareResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseText + "'");
 }
 
 if (objCoursewareResCaseEN.IdCoursewareResCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdCoursewareResCaseType);
 var strIdCoursewareResCaseType = objCoursewareResCaseEN.IdCoursewareResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCoursewareResCaseType + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseDate);
 var strCoursewareResCaseDate = objCoursewareResCaseEN.CoursewareResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseDate + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseTime);
 var strCoursewareResCaseTime = objCoursewareResCaseEN.CoursewareResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseTime + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseDateIn);
 var strCoursewareResCaseDateIn = objCoursewareResCaseEN.CoursewareResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseDateIn + "'");
 }
 
 if (objCoursewareResCaseEN.CoursewareResCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CoursewareResCaseTimeIn);
 var strCoursewareResCaseTimeIn = objCoursewareResCaseEN.CoursewareResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCoursewareResCaseTimeIn + "'");
 }
 
 if (objCoursewareResCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.OwnerId);
 var strOwnerId = objCoursewareResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCoursewareResCaseEN.IdStudyLevel  ==  "")
 {
 objCoursewareResCaseEN.IdStudyLevel = null;
 }
 if (objCoursewareResCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdStudyLevel);
 var strIdStudyLevel = objCoursewareResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objCoursewareResCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdTeachingPlan);
 var strIdTeachingPlan = objCoursewareResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objCoursewareResCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdDiscipline);
 var strIdDiscipline = objCoursewareResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objCoursewareResCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.BrowseCount);
 arrValueListForInsert.Add(objCoursewareResCaseEN.BrowseCount.ToString());
 }
 
 if (objCoursewareResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCoursewareResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCoursewareResCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objCoursewareResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objCoursewareResCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdTeachSkill);
 var strIdTeachSkill = objCoursewareResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objCoursewareResCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CaseLevelId);
 var strCaseLevelId = objCoursewareResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objCoursewareResCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.DocFile);
 var strDocFile = objCoursewareResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareResCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objCoursewareResCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareResCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.WordCreateDate);
 var strWordCreateDate = objCoursewareResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conCoursewareResCase.IsVisible);
 arrValueListForInsert.Add("'" + (objCoursewareResCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCoursewareResCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objCoursewareResCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareResCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdXzCollege);
 var strIdXzCollege = objCoursewareResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCoursewareResCaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.IdXzMajor);
 var strIdXzMajor = objCoursewareResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objCoursewareResCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CourseChapterId);
 var strCourseChapterId = objCoursewareResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objCoursewareResCaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.ViewCount);
 arrValueListForInsert.Add(objCoursewareResCaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conCoursewareResCase.IsShow);
 arrValueListForInsert.Add("'" + (objCoursewareResCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objCoursewareResCaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.DownloadNumber);
 arrValueListForInsert.Add(objCoursewareResCaseEN.DownloadNumber.ToString());
 }
 
 if (objCoursewareResCaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.FileIntegration);
 arrValueListForInsert.Add(objCoursewareResCaseEN.FileIntegration.ToString());
 }
 
 if (objCoursewareResCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.LikeCount);
 arrValueListForInsert.Add(objCoursewareResCaseEN.LikeCount.ToString());
 }
 
 if (objCoursewareResCaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CollectionCount);
 arrValueListForInsert.Add(objCoursewareResCaseEN.CollectionCount.ToString());
 }
 
 if (objCoursewareResCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objCoursewareResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objCoursewareResCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.ftpFileType);
 var strftpFileType = objCoursewareResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objCoursewareResCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.CourseId);
 var strCourseId = objCoursewareResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCoursewareResCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.VideoUrl);
 var strVideoUrl = objCoursewareResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objCoursewareResCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.VideoPath);
 var strVideoPath = objCoursewareResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objCoursewareResCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.ResErrMsg);
 var strResErrMsg = objCoursewareResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objCoursewareResCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.UpdDate);
 var strUpdDate = objCoursewareResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCoursewareResCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.UpdUserId);
 var strUpdUserId = objCoursewareResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCoursewareResCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCoursewareResCase.Memo);
 var strMemo = objCoursewareResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CoursewareResCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCoursewareResCases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareResCase where IdCoursewareResCase = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CoursewareResCase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdCoursewareResCase = oRow[conCoursewareResCase.IdCoursewareResCase].ToString().Trim();
if (IsExist(strIdCoursewareResCase))
{
 string strResult = "关键字变量值为:" + string.Format("IdCoursewareResCase = {0}", strIdCoursewareResCase) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCoursewareResCaseEN._CurrTabName ].NewRow();
objRow[conCoursewareResCase.IdCoursewareResCase] = oRow[conCoursewareResCase.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objRow[conCoursewareResCase.CoursewareResCaseID] = oRow[conCoursewareResCase.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objRow[conCoursewareResCase.CoursewareResCaseName] = oRow[conCoursewareResCase.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objRow[conCoursewareResCase.CoursewareResCaseTheme] = oRow[conCoursewareResCase.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objRow[conCoursewareResCase.CoursewareResCaseText] = oRow[conCoursewareResCase.CoursewareResCaseText].ToString().Trim(); //案例文本内容
objRow[conCoursewareResCase.IdCoursewareResCaseType] = oRow[conCoursewareResCase.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objRow[conCoursewareResCase.CoursewareResCaseDate] = oRow[conCoursewareResCase.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objRow[conCoursewareResCase.CoursewareResCaseTime] = oRow[conCoursewareResCase.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objRow[conCoursewareResCase.CoursewareResCaseDateIn] = oRow[conCoursewareResCase.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objRow[conCoursewareResCase.CoursewareResCaseTimeIn] = oRow[conCoursewareResCase.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objRow[conCoursewareResCase.OwnerId] = oRow[conCoursewareResCase.OwnerId].ToString().Trim(); //拥有者Id
objRow[conCoursewareResCase.IdStudyLevel] = oRow[conCoursewareResCase.IdStudyLevel].ToString().Trim(); //学段流水号
objRow[conCoursewareResCase.IdTeachingPlan] = oRow[conCoursewareResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objRow[conCoursewareResCase.IdDiscipline] = oRow[conCoursewareResCase.IdDiscipline].ToString().Trim(); //学科流水号
objRow[conCoursewareResCase.BrowseCount] = oRow[conCoursewareResCase.BrowseCount].ToString().Trim(); //浏览次数
objRow[conCoursewareResCase.IdSenateGaugeVersion] = oRow[conCoursewareResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objRow[conCoursewareResCase.IdTeachSkill] = oRow[conCoursewareResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objRow[conCoursewareResCase.CaseLevelId] = oRow[conCoursewareResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objRow[conCoursewareResCase.DocFile] = oRow[conCoursewareResCase.DocFile].ToString().Trim(); //生成的Word文件名
objRow[conCoursewareResCase.IsNeedGeneWord] = oRow[conCoursewareResCase.IsNeedGeneWord].ToString().Trim(); //是否需要生成Word
objRow[conCoursewareResCase.WordCreateDate] = oRow[conCoursewareResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objRow[conCoursewareResCase.IsVisible] = oRow[conCoursewareResCase.IsVisible].ToString().Trim(); //是否显示
objRow[conCoursewareResCase.IsDualVideo] = oRow[conCoursewareResCase.IsDualVideo].ToString().Trim(); //是否双视频
objRow[conCoursewareResCase.IdXzCollege] = oRow[conCoursewareResCase.IdXzCollege].ToString().Trim(); //学院流水号
objRow[conCoursewareResCase.IdXzMajor] = oRow[conCoursewareResCase.IdXzMajor].ToString().Trim(); //专业流水号
objRow[conCoursewareResCase.CourseChapterId] = oRow[conCoursewareResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objRow[conCoursewareResCase.ViewCount] = oRow[conCoursewareResCase.ViewCount].ToString().Trim(); //浏览量
objRow[conCoursewareResCase.IsShow] = oRow[conCoursewareResCase.IsShow].ToString().Trim(); //是否启用
objRow[conCoursewareResCase.DownloadNumber] = oRow[conCoursewareResCase.DownloadNumber].ToString().Trim(); //下载数目
objRow[conCoursewareResCase.FileIntegration] = oRow[conCoursewareResCase.FileIntegration].ToString().Trim(); //文件积分
objRow[conCoursewareResCase.LikeCount] = oRow[conCoursewareResCase.LikeCount].ToString().Trim(); //资源喜欢数量
objRow[conCoursewareResCase.CollectionCount] = oRow[conCoursewareResCase.CollectionCount].ToString().Trim(); //收藏数量
objRow[conCoursewareResCase.RecommendedDegreeId] = oRow[conCoursewareResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objRow[conCoursewareResCase.ftpFileType] = oRow[conCoursewareResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objRow[conCoursewareResCase.CourseId] = oRow[conCoursewareResCase.CourseId].ToString().Trim(); //课程Id
objRow[conCoursewareResCase.VideoUrl] = oRow[conCoursewareResCase.VideoUrl].ToString().Trim(); //视频Url
objRow[conCoursewareResCase.VideoPath] = oRow[conCoursewareResCase.VideoPath].ToString().Trim(); //视频目录
objRow[conCoursewareResCase.ResErrMsg] = oRow[conCoursewareResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objRow[conCoursewareResCase.UpdDate] = oRow[conCoursewareResCase.UpdDate].ToString().Trim(); //修改日期
objRow[conCoursewareResCase.UpdUserId] = oRow[conCoursewareResCase.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conCoursewareResCase.Memo] = oRow[conCoursewareResCase.Memo].ToString().Trim(); //备注
 objDS.Tables[clsCoursewareResCaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCoursewareResCaseEN._CurrTabName);
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
 /// <param name = "objCoursewareResCaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCoursewareResCaseEN objCoursewareResCaseEN)
{
 objCoursewareResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareResCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCoursewareResCaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
strSQL = "Select * from CoursewareResCase where IdCoursewareResCase = " + "'"+ objCoursewareResCaseEN.IdCoursewareResCase+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCoursewareResCaseEN._CurrTabName);
if (objDS.Tables[clsCoursewareResCaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdCoursewareResCase = " + "'"+ objCoursewareResCaseEN.IdCoursewareResCase+"'");
return false;
}
objRow = objDS.Tables[clsCoursewareResCaseEN._CurrTabName].Rows[0];
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdCoursewareResCase))
 {
objRow[conCoursewareResCase.IdCoursewareResCase] = objCoursewareResCaseEN.IdCoursewareResCase; //课件资源案例流水号
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseID))
 {
objRow[conCoursewareResCase.CoursewareResCaseID] = objCoursewareResCaseEN.CoursewareResCaseID; //课件资源案例ID
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseName))
 {
objRow[conCoursewareResCase.CoursewareResCaseName] = objCoursewareResCaseEN.CoursewareResCaseName; //课件资源案例名称
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseTheme))
 {
objRow[conCoursewareResCase.CoursewareResCaseTheme] = objCoursewareResCaseEN.CoursewareResCaseTheme; //课件资源案例主题词
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseText))
 {
objRow[conCoursewareResCase.CoursewareResCaseText] = objCoursewareResCaseEN.CoursewareResCaseText; //案例文本内容
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdCoursewareResCaseType))
 {
objRow[conCoursewareResCase.IdCoursewareResCaseType] = objCoursewareResCaseEN.IdCoursewareResCaseType; //课件资源类型流水号
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseDate))
 {
objRow[conCoursewareResCase.CoursewareResCaseDate] = objCoursewareResCaseEN.CoursewareResCaseDate; //视频资源日期
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseTime))
 {
objRow[conCoursewareResCase.CoursewareResCaseTime] = objCoursewareResCaseEN.CoursewareResCaseTime; //视频资源时间
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseDateIn))
 {
objRow[conCoursewareResCase.CoursewareResCaseDateIn] = objCoursewareResCaseEN.CoursewareResCaseDateIn; //案例入库日期
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseTimeIn))
 {
objRow[conCoursewareResCase.CoursewareResCaseTimeIn] = objCoursewareResCaseEN.CoursewareResCaseTimeIn; //案例入库时间
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.OwnerId))
 {
objRow[conCoursewareResCase.OwnerId] = objCoursewareResCaseEN.OwnerId; //拥有者Id
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdStudyLevel))
 {
objRow[conCoursewareResCase.IdStudyLevel] = objCoursewareResCaseEN.IdStudyLevel; //学段流水号
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdTeachingPlan))
 {
objRow[conCoursewareResCase.IdTeachingPlan] = objCoursewareResCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdDiscipline))
 {
objRow[conCoursewareResCase.IdDiscipline] = objCoursewareResCaseEN.IdDiscipline; //学科流水号
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.BrowseCount))
 {
objRow[conCoursewareResCase.BrowseCount] = objCoursewareResCaseEN.BrowseCount; //浏览次数
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdSenateGaugeVersion))
 {
objRow[conCoursewareResCase.IdSenateGaugeVersion] = objCoursewareResCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdTeachSkill))
 {
objRow[conCoursewareResCase.IdTeachSkill] = objCoursewareResCaseEN.IdTeachSkill; //教学技能流水号
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CaseLevelId))
 {
objRow[conCoursewareResCase.CaseLevelId] = objCoursewareResCaseEN.CaseLevelId; //课例等级Id
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.DocFile))
 {
objRow[conCoursewareResCase.DocFile] = objCoursewareResCaseEN.DocFile; //生成的Word文件名
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsNeedGeneWord))
 {
objRow[conCoursewareResCase.IsNeedGeneWord] = objCoursewareResCaseEN.IsNeedGeneWord; //是否需要生成Word
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.WordCreateDate))
 {
objRow[conCoursewareResCase.WordCreateDate] = objCoursewareResCaseEN.WordCreateDate; //Word生成日期
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsVisible))
 {
objRow[conCoursewareResCase.IsVisible] = objCoursewareResCaseEN.IsVisible; //是否显示
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsDualVideo))
 {
objRow[conCoursewareResCase.IsDualVideo] = objCoursewareResCaseEN.IsDualVideo; //是否双视频
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdXzCollege))
 {
objRow[conCoursewareResCase.IdXzCollege] = objCoursewareResCaseEN.IdXzCollege; //学院流水号
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdXzMajor))
 {
objRow[conCoursewareResCase.IdXzMajor] = objCoursewareResCaseEN.IdXzMajor; //专业流水号
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CourseChapterId))
 {
objRow[conCoursewareResCase.CourseChapterId] = objCoursewareResCaseEN.CourseChapterId; //课程章节ID
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.ViewCount))
 {
objRow[conCoursewareResCase.ViewCount] = objCoursewareResCaseEN.ViewCount; //浏览量
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsShow))
 {
objRow[conCoursewareResCase.IsShow] = objCoursewareResCaseEN.IsShow; //是否启用
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.DownloadNumber))
 {
objRow[conCoursewareResCase.DownloadNumber] = objCoursewareResCaseEN.DownloadNumber; //下载数目
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.FileIntegration))
 {
objRow[conCoursewareResCase.FileIntegration] = objCoursewareResCaseEN.FileIntegration; //文件积分
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.LikeCount))
 {
objRow[conCoursewareResCase.LikeCount] = objCoursewareResCaseEN.LikeCount; //资源喜欢数量
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CollectionCount))
 {
objRow[conCoursewareResCase.CollectionCount] = objCoursewareResCaseEN.CollectionCount; //收藏数量
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.RecommendedDegreeId))
 {
objRow[conCoursewareResCase.RecommendedDegreeId] = objCoursewareResCaseEN.RecommendedDegreeId; //推荐度Id
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.ftpFileType))
 {
objRow[conCoursewareResCase.ftpFileType] = objCoursewareResCaseEN.ftpFileType; //ftp文件类型
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CourseId))
 {
objRow[conCoursewareResCase.CourseId] = objCoursewareResCaseEN.CourseId; //课程Id
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.VideoUrl))
 {
objRow[conCoursewareResCase.VideoUrl] = objCoursewareResCaseEN.VideoUrl; //视频Url
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.VideoPath))
 {
objRow[conCoursewareResCase.VideoPath] = objCoursewareResCaseEN.VideoPath; //视频目录
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.ResErrMsg))
 {
objRow[conCoursewareResCase.ResErrMsg] = objCoursewareResCaseEN.ResErrMsg; //资源错误信息
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.UpdDate))
 {
objRow[conCoursewareResCase.UpdDate] = objCoursewareResCaseEN.UpdDate; //修改日期
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.UpdUserId))
 {
objRow[conCoursewareResCase.UpdUserId] = objCoursewareResCaseEN.UpdUserId; //修改用户Id
 }
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.Memo))
 {
objRow[conCoursewareResCase.Memo] = objCoursewareResCaseEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsCoursewareResCaseEN._CurrTabName);
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
 /// <param name = "objCoursewareResCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCoursewareResCaseEN objCoursewareResCaseEN)
{
 objCoursewareResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareResCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCoursewareResCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CoursewareResCase Set ");
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseID))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseID !=  null)
 {
 var strCoursewareResCaseID = objCoursewareResCaseEN.CoursewareResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareResCaseID, conCoursewareResCase.CoursewareResCaseID); //课件资源案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CoursewareResCaseID); //课件资源案例ID
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseName))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseName !=  null)
 {
 var strCoursewareResCaseName = objCoursewareResCaseEN.CoursewareResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareResCaseName, conCoursewareResCase.CoursewareResCaseName); //课件资源案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CoursewareResCaseName); //课件资源案例名称
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseTheme))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseTheme !=  null)
 {
 var strCoursewareResCaseTheme = objCoursewareResCaseEN.CoursewareResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareResCaseTheme, conCoursewareResCase.CoursewareResCaseTheme); //课件资源案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CoursewareResCaseTheme); //课件资源案例主题词
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseText))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseText !=  null)
 {
 var strCoursewareResCaseText = objCoursewareResCaseEN.CoursewareResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareResCaseText, conCoursewareResCase.CoursewareResCaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CoursewareResCaseText); //案例文本内容
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdCoursewareResCaseType))
 {
 if (objCoursewareResCaseEN.IdCoursewareResCaseType !=  null)
 {
 var strIdCoursewareResCaseType = objCoursewareResCaseEN.IdCoursewareResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCoursewareResCaseType, conCoursewareResCase.IdCoursewareResCaseType); //课件资源类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.IdCoursewareResCaseType); //课件资源类型流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseDate))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseDate !=  null)
 {
 var strCoursewareResCaseDate = objCoursewareResCaseEN.CoursewareResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareResCaseDate, conCoursewareResCase.CoursewareResCaseDate); //视频资源日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CoursewareResCaseDate); //视频资源日期
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseTime))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseTime !=  null)
 {
 var strCoursewareResCaseTime = objCoursewareResCaseEN.CoursewareResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareResCaseTime, conCoursewareResCase.CoursewareResCaseTime); //视频资源时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CoursewareResCaseTime); //视频资源时间
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseDateIn))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseDateIn !=  null)
 {
 var strCoursewareResCaseDateIn = objCoursewareResCaseEN.CoursewareResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareResCaseDateIn, conCoursewareResCase.CoursewareResCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CoursewareResCaseDateIn); //案例入库日期
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseTimeIn))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseTimeIn !=  null)
 {
 var strCoursewareResCaseTimeIn = objCoursewareResCaseEN.CoursewareResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareResCaseTimeIn, conCoursewareResCase.CoursewareResCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CoursewareResCaseTimeIn); //案例入库时间
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.OwnerId))
 {
 if (objCoursewareResCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objCoursewareResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conCoursewareResCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.OwnerId); //拥有者Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdStudyLevel))
 {
 if (objCoursewareResCaseEN.IdStudyLevel  ==  "")
 {
 objCoursewareResCaseEN.IdStudyLevel = null;
 }
 if (objCoursewareResCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objCoursewareResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conCoursewareResCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdTeachingPlan))
 {
 if (objCoursewareResCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objCoursewareResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conCoursewareResCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdDiscipline))
 {
 if (objCoursewareResCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objCoursewareResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conCoursewareResCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.BrowseCount))
 {
 if (objCoursewareResCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.BrowseCount, conCoursewareResCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.BrowseCount); //浏览次数
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdSenateGaugeVersion))
 {
 if (objCoursewareResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCoursewareResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCoursewareResCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objCoursewareResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conCoursewareResCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdTeachSkill))
 {
 if (objCoursewareResCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objCoursewareResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conCoursewareResCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CaseLevelId))
 {
 if (objCoursewareResCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objCoursewareResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conCoursewareResCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.DocFile))
 {
 if (objCoursewareResCaseEN.DocFile !=  null)
 {
 var strDocFile = objCoursewareResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conCoursewareResCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCoursewareResCaseEN.IsNeedGeneWord == true?"1":"0", conCoursewareResCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.WordCreateDate))
 {
 if (objCoursewareResCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objCoursewareResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conCoursewareResCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCoursewareResCaseEN.IsVisible == true?"1":"0", conCoursewareResCase.IsVisible); //是否显示
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCoursewareResCaseEN.IsDualVideo == true?"1":"0", conCoursewareResCase.IsDualVideo); //是否双视频
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdXzCollege))
 {
 if (objCoursewareResCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCoursewareResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conCoursewareResCase.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.IdXzCollege); //学院流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdXzMajor))
 {
 if (objCoursewareResCaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objCoursewareResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conCoursewareResCase.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.IdXzMajor); //专业流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CourseChapterId))
 {
 if (objCoursewareResCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objCoursewareResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, conCoursewareResCase.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CourseChapterId); //课程章节ID
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.ViewCount))
 {
 if (objCoursewareResCaseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.ViewCount, conCoursewareResCase.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.ViewCount); //浏览量
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCoursewareResCaseEN.IsShow == true?"1":"0", conCoursewareResCase.IsShow); //是否启用
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.DownloadNumber))
 {
 if (objCoursewareResCaseEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.DownloadNumber, conCoursewareResCase.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.DownloadNumber); //下载数目
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.FileIntegration))
 {
 if (objCoursewareResCaseEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.FileIntegration, conCoursewareResCase.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.FileIntegration); //文件积分
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.LikeCount))
 {
 if (objCoursewareResCaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.LikeCount, conCoursewareResCase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CollectionCount))
 {
 if (objCoursewareResCaseEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.CollectionCount, conCoursewareResCase.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CollectionCount); //收藏数量
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.RecommendedDegreeId))
 {
 if (objCoursewareResCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objCoursewareResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conCoursewareResCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.ftpFileType))
 {
 if (objCoursewareResCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objCoursewareResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conCoursewareResCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CourseId))
 {
 if (objCoursewareResCaseEN.CourseId !=  null)
 {
 var strCourseId = objCoursewareResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conCoursewareResCase.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CourseId); //课程Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.VideoUrl))
 {
 if (objCoursewareResCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objCoursewareResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conCoursewareResCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.VideoUrl); //视频Url
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.VideoPath))
 {
 if (objCoursewareResCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objCoursewareResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conCoursewareResCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.VideoPath); //视频目录
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.ResErrMsg))
 {
 if (objCoursewareResCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objCoursewareResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conCoursewareResCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.UpdDate))
 {
 if (objCoursewareResCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objCoursewareResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCoursewareResCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.UpdDate); //修改日期
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.UpdUserId))
 {
 if (objCoursewareResCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCoursewareResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCoursewareResCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.Memo))
 {
 if (objCoursewareResCaseEN.Memo !=  null)
 {
 var strMemo = objCoursewareResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCoursewareResCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCoursewareResCase = '{0}'", objCoursewareResCaseEN.IdCoursewareResCase); 
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
 /// <param name = "objCoursewareResCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCoursewareResCaseEN objCoursewareResCaseEN, string strCondition)
{
 objCoursewareResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareResCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCoursewareResCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CoursewareResCase Set ");
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseID))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseID !=  null)
 {
 var strCoursewareResCaseID = objCoursewareResCaseEN.CoursewareResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareResCaseID = '{0}',", strCoursewareResCaseID); //课件资源案例ID
 }
 else
 {
 sbSQL.Append(" CoursewareResCaseID = null,"); //课件资源案例ID
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseName))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseName !=  null)
 {
 var strCoursewareResCaseName = objCoursewareResCaseEN.CoursewareResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareResCaseName = '{0}',", strCoursewareResCaseName); //课件资源案例名称
 }
 else
 {
 sbSQL.Append(" CoursewareResCaseName = null,"); //课件资源案例名称
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseTheme))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseTheme !=  null)
 {
 var strCoursewareResCaseTheme = objCoursewareResCaseEN.CoursewareResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareResCaseTheme = '{0}',", strCoursewareResCaseTheme); //课件资源案例主题词
 }
 else
 {
 sbSQL.Append(" CoursewareResCaseTheme = null,"); //课件资源案例主题词
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseText))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseText !=  null)
 {
 var strCoursewareResCaseText = objCoursewareResCaseEN.CoursewareResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareResCaseText = '{0}',", strCoursewareResCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" CoursewareResCaseText = null,"); //案例文本内容
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdCoursewareResCaseType))
 {
 if (objCoursewareResCaseEN.IdCoursewareResCaseType !=  null)
 {
 var strIdCoursewareResCaseType = objCoursewareResCaseEN.IdCoursewareResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCoursewareResCaseType = '{0}',", strIdCoursewareResCaseType); //课件资源类型流水号
 }
 else
 {
 sbSQL.Append(" IdCoursewareResCaseType = null,"); //课件资源类型流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseDate))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseDate !=  null)
 {
 var strCoursewareResCaseDate = objCoursewareResCaseEN.CoursewareResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareResCaseDate = '{0}',", strCoursewareResCaseDate); //视频资源日期
 }
 else
 {
 sbSQL.Append(" CoursewareResCaseDate = null,"); //视频资源日期
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseTime))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseTime !=  null)
 {
 var strCoursewareResCaseTime = objCoursewareResCaseEN.CoursewareResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareResCaseTime = '{0}',", strCoursewareResCaseTime); //视频资源时间
 }
 else
 {
 sbSQL.Append(" CoursewareResCaseTime = null,"); //视频资源时间
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseDateIn))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseDateIn !=  null)
 {
 var strCoursewareResCaseDateIn = objCoursewareResCaseEN.CoursewareResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareResCaseDateIn = '{0}',", strCoursewareResCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" CoursewareResCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseTimeIn))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseTimeIn !=  null)
 {
 var strCoursewareResCaseTimeIn = objCoursewareResCaseEN.CoursewareResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareResCaseTimeIn = '{0}',", strCoursewareResCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" CoursewareResCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.OwnerId))
 {
 if (objCoursewareResCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objCoursewareResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdStudyLevel))
 {
 if (objCoursewareResCaseEN.IdStudyLevel  ==  "")
 {
 objCoursewareResCaseEN.IdStudyLevel = null;
 }
 if (objCoursewareResCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objCoursewareResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdTeachingPlan))
 {
 if (objCoursewareResCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objCoursewareResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdDiscipline))
 {
 if (objCoursewareResCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objCoursewareResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.BrowseCount))
 {
 if (objCoursewareResCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.BrowseCount, conCoursewareResCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.BrowseCount); //浏览次数
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdSenateGaugeVersion))
 {
 if (objCoursewareResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCoursewareResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCoursewareResCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objCoursewareResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdTeachSkill))
 {
 if (objCoursewareResCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objCoursewareResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CaseLevelId))
 {
 if (objCoursewareResCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objCoursewareResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.DocFile))
 {
 if (objCoursewareResCaseEN.DocFile !=  null)
 {
 var strDocFile = objCoursewareResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objCoursewareResCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.WordCreateDate))
 {
 if (objCoursewareResCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objCoursewareResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objCoursewareResCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objCoursewareResCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdXzCollege))
 {
 if (objCoursewareResCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCoursewareResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdXzMajor))
 {
 if (objCoursewareResCaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objCoursewareResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CourseChapterId))
 {
 if (objCoursewareResCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objCoursewareResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.ViewCount))
 {
 if (objCoursewareResCaseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.ViewCount, conCoursewareResCase.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.ViewCount); //浏览量
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objCoursewareResCaseEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.DownloadNumber))
 {
 if (objCoursewareResCaseEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.DownloadNumber, conCoursewareResCase.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.DownloadNumber); //下载数目
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.FileIntegration))
 {
 if (objCoursewareResCaseEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.FileIntegration, conCoursewareResCase.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.FileIntegration); //文件积分
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.LikeCount))
 {
 if (objCoursewareResCaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.LikeCount, conCoursewareResCase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CollectionCount))
 {
 if (objCoursewareResCaseEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.CollectionCount, conCoursewareResCase.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CollectionCount); //收藏数量
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.RecommendedDegreeId))
 {
 if (objCoursewareResCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objCoursewareResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.ftpFileType))
 {
 if (objCoursewareResCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objCoursewareResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CourseId))
 {
 if (objCoursewareResCaseEN.CourseId !=  null)
 {
 var strCourseId = objCoursewareResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.VideoUrl))
 {
 if (objCoursewareResCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objCoursewareResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.VideoPath))
 {
 if (objCoursewareResCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objCoursewareResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.ResErrMsg))
 {
 if (objCoursewareResCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objCoursewareResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.UpdDate))
 {
 if (objCoursewareResCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objCoursewareResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.UpdUserId))
 {
 if (objCoursewareResCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCoursewareResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.Memo))
 {
 if (objCoursewareResCaseEN.Memo !=  null)
 {
 var strMemo = objCoursewareResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCoursewareResCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCoursewareResCaseEN objCoursewareResCaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCoursewareResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareResCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCoursewareResCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CoursewareResCase Set ");
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseID))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseID !=  null)
 {
 var strCoursewareResCaseID = objCoursewareResCaseEN.CoursewareResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareResCaseID = '{0}',", strCoursewareResCaseID); //课件资源案例ID
 }
 else
 {
 sbSQL.Append(" CoursewareResCaseID = null,"); //课件资源案例ID
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseName))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseName !=  null)
 {
 var strCoursewareResCaseName = objCoursewareResCaseEN.CoursewareResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareResCaseName = '{0}',", strCoursewareResCaseName); //课件资源案例名称
 }
 else
 {
 sbSQL.Append(" CoursewareResCaseName = null,"); //课件资源案例名称
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseTheme))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseTheme !=  null)
 {
 var strCoursewareResCaseTheme = objCoursewareResCaseEN.CoursewareResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareResCaseTheme = '{0}',", strCoursewareResCaseTheme); //课件资源案例主题词
 }
 else
 {
 sbSQL.Append(" CoursewareResCaseTheme = null,"); //课件资源案例主题词
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseText))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseText !=  null)
 {
 var strCoursewareResCaseText = objCoursewareResCaseEN.CoursewareResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareResCaseText = '{0}',", strCoursewareResCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" CoursewareResCaseText = null,"); //案例文本内容
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdCoursewareResCaseType))
 {
 if (objCoursewareResCaseEN.IdCoursewareResCaseType !=  null)
 {
 var strIdCoursewareResCaseType = objCoursewareResCaseEN.IdCoursewareResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCoursewareResCaseType = '{0}',", strIdCoursewareResCaseType); //课件资源类型流水号
 }
 else
 {
 sbSQL.Append(" IdCoursewareResCaseType = null,"); //课件资源类型流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseDate))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseDate !=  null)
 {
 var strCoursewareResCaseDate = objCoursewareResCaseEN.CoursewareResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareResCaseDate = '{0}',", strCoursewareResCaseDate); //视频资源日期
 }
 else
 {
 sbSQL.Append(" CoursewareResCaseDate = null,"); //视频资源日期
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseTime))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseTime !=  null)
 {
 var strCoursewareResCaseTime = objCoursewareResCaseEN.CoursewareResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareResCaseTime = '{0}',", strCoursewareResCaseTime); //视频资源时间
 }
 else
 {
 sbSQL.Append(" CoursewareResCaseTime = null,"); //视频资源时间
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseDateIn))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseDateIn !=  null)
 {
 var strCoursewareResCaseDateIn = objCoursewareResCaseEN.CoursewareResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareResCaseDateIn = '{0}',", strCoursewareResCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" CoursewareResCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseTimeIn))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseTimeIn !=  null)
 {
 var strCoursewareResCaseTimeIn = objCoursewareResCaseEN.CoursewareResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CoursewareResCaseTimeIn = '{0}',", strCoursewareResCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" CoursewareResCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.OwnerId))
 {
 if (objCoursewareResCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objCoursewareResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdStudyLevel))
 {
 if (objCoursewareResCaseEN.IdStudyLevel  ==  "")
 {
 objCoursewareResCaseEN.IdStudyLevel = null;
 }
 if (objCoursewareResCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objCoursewareResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdTeachingPlan))
 {
 if (objCoursewareResCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objCoursewareResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdDiscipline))
 {
 if (objCoursewareResCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objCoursewareResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.BrowseCount))
 {
 if (objCoursewareResCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.BrowseCount, conCoursewareResCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.BrowseCount); //浏览次数
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdSenateGaugeVersion))
 {
 if (objCoursewareResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCoursewareResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCoursewareResCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objCoursewareResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdTeachSkill))
 {
 if (objCoursewareResCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objCoursewareResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CaseLevelId))
 {
 if (objCoursewareResCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objCoursewareResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.DocFile))
 {
 if (objCoursewareResCaseEN.DocFile !=  null)
 {
 var strDocFile = objCoursewareResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objCoursewareResCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.WordCreateDate))
 {
 if (objCoursewareResCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objCoursewareResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objCoursewareResCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objCoursewareResCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdXzCollege))
 {
 if (objCoursewareResCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCoursewareResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdXzMajor))
 {
 if (objCoursewareResCaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objCoursewareResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CourseChapterId))
 {
 if (objCoursewareResCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objCoursewareResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.ViewCount))
 {
 if (objCoursewareResCaseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.ViewCount, conCoursewareResCase.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.ViewCount); //浏览量
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objCoursewareResCaseEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.DownloadNumber))
 {
 if (objCoursewareResCaseEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.DownloadNumber, conCoursewareResCase.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.DownloadNumber); //下载数目
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.FileIntegration))
 {
 if (objCoursewareResCaseEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.FileIntegration, conCoursewareResCase.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.FileIntegration); //文件积分
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.LikeCount))
 {
 if (objCoursewareResCaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.LikeCount, conCoursewareResCase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CollectionCount))
 {
 if (objCoursewareResCaseEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.CollectionCount, conCoursewareResCase.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CollectionCount); //收藏数量
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.RecommendedDegreeId))
 {
 if (objCoursewareResCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objCoursewareResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.ftpFileType))
 {
 if (objCoursewareResCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objCoursewareResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CourseId))
 {
 if (objCoursewareResCaseEN.CourseId !=  null)
 {
 var strCourseId = objCoursewareResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.VideoUrl))
 {
 if (objCoursewareResCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objCoursewareResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.VideoPath))
 {
 if (objCoursewareResCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objCoursewareResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.ResErrMsg))
 {
 if (objCoursewareResCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objCoursewareResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.UpdDate))
 {
 if (objCoursewareResCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objCoursewareResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.UpdUserId))
 {
 if (objCoursewareResCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCoursewareResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.Memo))
 {
 if (objCoursewareResCaseEN.Memo !=  null)
 {
 var strMemo = objCoursewareResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCoursewareResCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCoursewareResCaseEN objCoursewareResCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCoursewareResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCoursewareResCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCoursewareResCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CoursewareResCase Set ");
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseID))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseID !=  null)
 {
 var strCoursewareResCaseID = objCoursewareResCaseEN.CoursewareResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareResCaseID, conCoursewareResCase.CoursewareResCaseID); //课件资源案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CoursewareResCaseID); //课件资源案例ID
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseName))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseName !=  null)
 {
 var strCoursewareResCaseName = objCoursewareResCaseEN.CoursewareResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareResCaseName, conCoursewareResCase.CoursewareResCaseName); //课件资源案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CoursewareResCaseName); //课件资源案例名称
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseTheme))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseTheme !=  null)
 {
 var strCoursewareResCaseTheme = objCoursewareResCaseEN.CoursewareResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareResCaseTheme, conCoursewareResCase.CoursewareResCaseTheme); //课件资源案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CoursewareResCaseTheme); //课件资源案例主题词
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseText))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseText !=  null)
 {
 var strCoursewareResCaseText = objCoursewareResCaseEN.CoursewareResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareResCaseText, conCoursewareResCase.CoursewareResCaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CoursewareResCaseText); //案例文本内容
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdCoursewareResCaseType))
 {
 if (objCoursewareResCaseEN.IdCoursewareResCaseType !=  null)
 {
 var strIdCoursewareResCaseType = objCoursewareResCaseEN.IdCoursewareResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCoursewareResCaseType, conCoursewareResCase.IdCoursewareResCaseType); //课件资源类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.IdCoursewareResCaseType); //课件资源类型流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseDate))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseDate !=  null)
 {
 var strCoursewareResCaseDate = objCoursewareResCaseEN.CoursewareResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareResCaseDate, conCoursewareResCase.CoursewareResCaseDate); //视频资源日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CoursewareResCaseDate); //视频资源日期
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseTime))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseTime !=  null)
 {
 var strCoursewareResCaseTime = objCoursewareResCaseEN.CoursewareResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareResCaseTime, conCoursewareResCase.CoursewareResCaseTime); //视频资源时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CoursewareResCaseTime); //视频资源时间
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseDateIn))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseDateIn !=  null)
 {
 var strCoursewareResCaseDateIn = objCoursewareResCaseEN.CoursewareResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareResCaseDateIn, conCoursewareResCase.CoursewareResCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CoursewareResCaseDateIn); //案例入库日期
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CoursewareResCaseTimeIn))
 {
 if (objCoursewareResCaseEN.CoursewareResCaseTimeIn !=  null)
 {
 var strCoursewareResCaseTimeIn = objCoursewareResCaseEN.CoursewareResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCoursewareResCaseTimeIn, conCoursewareResCase.CoursewareResCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CoursewareResCaseTimeIn); //案例入库时间
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.OwnerId))
 {
 if (objCoursewareResCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objCoursewareResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conCoursewareResCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.OwnerId); //拥有者Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdStudyLevel))
 {
 if (objCoursewareResCaseEN.IdStudyLevel  ==  "")
 {
 objCoursewareResCaseEN.IdStudyLevel = null;
 }
 if (objCoursewareResCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objCoursewareResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conCoursewareResCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdTeachingPlan))
 {
 if (objCoursewareResCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objCoursewareResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conCoursewareResCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdDiscipline))
 {
 if (objCoursewareResCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objCoursewareResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conCoursewareResCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.BrowseCount))
 {
 if (objCoursewareResCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.BrowseCount, conCoursewareResCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.BrowseCount); //浏览次数
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdSenateGaugeVersion))
 {
 if (objCoursewareResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCoursewareResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objCoursewareResCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objCoursewareResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conCoursewareResCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdTeachSkill))
 {
 if (objCoursewareResCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objCoursewareResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conCoursewareResCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CaseLevelId))
 {
 if (objCoursewareResCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objCoursewareResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conCoursewareResCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.DocFile))
 {
 if (objCoursewareResCaseEN.DocFile !=  null)
 {
 var strDocFile = objCoursewareResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conCoursewareResCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCoursewareResCaseEN.IsNeedGeneWord == true?"1":"0", conCoursewareResCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.WordCreateDate))
 {
 if (objCoursewareResCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objCoursewareResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conCoursewareResCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCoursewareResCaseEN.IsVisible == true?"1":"0", conCoursewareResCase.IsVisible); //是否显示
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCoursewareResCaseEN.IsDualVideo == true?"1":"0", conCoursewareResCase.IsDualVideo); //是否双视频
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdXzCollege))
 {
 if (objCoursewareResCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCoursewareResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conCoursewareResCase.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.IdXzCollege); //学院流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IdXzMajor))
 {
 if (objCoursewareResCaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objCoursewareResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conCoursewareResCase.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.IdXzMajor); //专业流水号
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CourseChapterId))
 {
 if (objCoursewareResCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objCoursewareResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, conCoursewareResCase.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CourseChapterId); //课程章节ID
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.ViewCount))
 {
 if (objCoursewareResCaseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.ViewCount, conCoursewareResCase.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.ViewCount); //浏览量
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCoursewareResCaseEN.IsShow == true?"1":"0", conCoursewareResCase.IsShow); //是否启用
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.DownloadNumber))
 {
 if (objCoursewareResCaseEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.DownloadNumber, conCoursewareResCase.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.DownloadNumber); //下载数目
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.FileIntegration))
 {
 if (objCoursewareResCaseEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.FileIntegration, conCoursewareResCase.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.FileIntegration); //文件积分
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.LikeCount))
 {
 if (objCoursewareResCaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.LikeCount, conCoursewareResCase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CollectionCount))
 {
 if (objCoursewareResCaseEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCoursewareResCaseEN.CollectionCount, conCoursewareResCase.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CollectionCount); //收藏数量
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.RecommendedDegreeId))
 {
 if (objCoursewareResCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objCoursewareResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conCoursewareResCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.ftpFileType))
 {
 if (objCoursewareResCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objCoursewareResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conCoursewareResCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.CourseId))
 {
 if (objCoursewareResCaseEN.CourseId !=  null)
 {
 var strCourseId = objCoursewareResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conCoursewareResCase.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.CourseId); //课程Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.VideoUrl))
 {
 if (objCoursewareResCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objCoursewareResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conCoursewareResCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.VideoUrl); //视频Url
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.VideoPath))
 {
 if (objCoursewareResCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objCoursewareResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conCoursewareResCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.VideoPath); //视频目录
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.ResErrMsg))
 {
 if (objCoursewareResCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objCoursewareResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conCoursewareResCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.UpdDate))
 {
 if (objCoursewareResCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objCoursewareResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCoursewareResCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.UpdDate); //修改日期
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.UpdUserId))
 {
 if (objCoursewareResCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCoursewareResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCoursewareResCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objCoursewareResCaseEN.IsUpdated(conCoursewareResCase.Memo))
 {
 if (objCoursewareResCaseEN.Memo !=  null)
 {
 var strMemo = objCoursewareResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCoursewareResCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCoursewareResCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCoursewareResCase = '{0}'", objCoursewareResCaseEN.IdCoursewareResCase); 
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
 /// <param name = "strIdCoursewareResCase">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdCoursewareResCase) 
{
CheckPrimaryKey(strIdCoursewareResCase);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdCoursewareResCase,
};
 objSQL.ExecSP("CoursewareResCase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdCoursewareResCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdCoursewareResCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdCoursewareResCase);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
//删除CoursewareResCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CoursewareResCase where IdCoursewareResCase = " + "'"+ strIdCoursewareResCase+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCoursewareResCase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
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
//删除CoursewareResCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CoursewareResCase where IdCoursewareResCase in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdCoursewareResCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdCoursewareResCase) 
{
CheckPrimaryKey(strIdCoursewareResCase);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
//删除CoursewareResCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CoursewareResCase where IdCoursewareResCase = " + "'"+ strIdCoursewareResCase+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCoursewareResCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCoursewareResCaseDA: DelCoursewareResCase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CoursewareResCase where " + strCondition ;
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
public bool DelCoursewareResCaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCoursewareResCaseDA: DelCoursewareResCaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CoursewareResCase where " + strCondition ;
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
 /// <param name = "objCoursewareResCaseENS">源对象</param>
 /// <param name = "objCoursewareResCaseENT">目标对象</param>
public void CopyTo(clsCoursewareResCaseEN objCoursewareResCaseENS, clsCoursewareResCaseEN objCoursewareResCaseENT)
{
objCoursewareResCaseENT.IdCoursewareResCase = objCoursewareResCaseENS.IdCoursewareResCase; //课件资源案例流水号
objCoursewareResCaseENT.CoursewareResCaseID = objCoursewareResCaseENS.CoursewareResCaseID; //课件资源案例ID
objCoursewareResCaseENT.CoursewareResCaseName = objCoursewareResCaseENS.CoursewareResCaseName; //课件资源案例名称
objCoursewareResCaseENT.CoursewareResCaseTheme = objCoursewareResCaseENS.CoursewareResCaseTheme; //课件资源案例主题词
objCoursewareResCaseENT.CoursewareResCaseText = objCoursewareResCaseENS.CoursewareResCaseText; //案例文本内容
objCoursewareResCaseENT.IdCoursewareResCaseType = objCoursewareResCaseENS.IdCoursewareResCaseType; //课件资源类型流水号
objCoursewareResCaseENT.CoursewareResCaseDate = objCoursewareResCaseENS.CoursewareResCaseDate; //视频资源日期
objCoursewareResCaseENT.CoursewareResCaseTime = objCoursewareResCaseENS.CoursewareResCaseTime; //视频资源时间
objCoursewareResCaseENT.CoursewareResCaseDateIn = objCoursewareResCaseENS.CoursewareResCaseDateIn; //案例入库日期
objCoursewareResCaseENT.CoursewareResCaseTimeIn = objCoursewareResCaseENS.CoursewareResCaseTimeIn; //案例入库时间
objCoursewareResCaseENT.OwnerId = objCoursewareResCaseENS.OwnerId; //拥有者Id
objCoursewareResCaseENT.IdStudyLevel = objCoursewareResCaseENS.IdStudyLevel; //学段流水号
objCoursewareResCaseENT.IdTeachingPlan = objCoursewareResCaseENS.IdTeachingPlan; //教案流水号
objCoursewareResCaseENT.IdDiscipline = objCoursewareResCaseENS.IdDiscipline; //学科流水号
objCoursewareResCaseENT.BrowseCount = objCoursewareResCaseENS.BrowseCount; //浏览次数
objCoursewareResCaseENT.IdSenateGaugeVersion = objCoursewareResCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objCoursewareResCaseENT.IdTeachSkill = objCoursewareResCaseENS.IdTeachSkill; //教学技能流水号
objCoursewareResCaseENT.CaseLevelId = objCoursewareResCaseENS.CaseLevelId; //课例等级Id
objCoursewareResCaseENT.DocFile = objCoursewareResCaseENS.DocFile; //生成的Word文件名
objCoursewareResCaseENT.IsNeedGeneWord = objCoursewareResCaseENS.IsNeedGeneWord; //是否需要生成Word
objCoursewareResCaseENT.WordCreateDate = objCoursewareResCaseENS.WordCreateDate; //Word生成日期
objCoursewareResCaseENT.IsVisible = objCoursewareResCaseENS.IsVisible; //是否显示
objCoursewareResCaseENT.IsDualVideo = objCoursewareResCaseENS.IsDualVideo; //是否双视频
objCoursewareResCaseENT.IdXzCollege = objCoursewareResCaseENS.IdXzCollege; //学院流水号
objCoursewareResCaseENT.IdXzMajor = objCoursewareResCaseENS.IdXzMajor; //专业流水号
objCoursewareResCaseENT.CourseChapterId = objCoursewareResCaseENS.CourseChapterId; //课程章节ID
objCoursewareResCaseENT.ViewCount = objCoursewareResCaseENS.ViewCount; //浏览量
objCoursewareResCaseENT.IsShow = objCoursewareResCaseENS.IsShow; //是否启用
objCoursewareResCaseENT.DownloadNumber = objCoursewareResCaseENS.DownloadNumber; //下载数目
objCoursewareResCaseENT.FileIntegration = objCoursewareResCaseENS.FileIntegration; //文件积分
objCoursewareResCaseENT.LikeCount = objCoursewareResCaseENS.LikeCount; //资源喜欢数量
objCoursewareResCaseENT.CollectionCount = objCoursewareResCaseENS.CollectionCount; //收藏数量
objCoursewareResCaseENT.RecommendedDegreeId = objCoursewareResCaseENS.RecommendedDegreeId; //推荐度Id
objCoursewareResCaseENT.ftpFileType = objCoursewareResCaseENS.ftpFileType; //ftp文件类型
objCoursewareResCaseENT.CourseId = objCoursewareResCaseENS.CourseId; //课程Id
objCoursewareResCaseENT.VideoUrl = objCoursewareResCaseENS.VideoUrl; //视频Url
objCoursewareResCaseENT.VideoPath = objCoursewareResCaseENS.VideoPath; //视频目录
objCoursewareResCaseENT.ResErrMsg = objCoursewareResCaseENS.ResErrMsg; //资源错误信息
objCoursewareResCaseENT.UpdDate = objCoursewareResCaseENS.UpdDate; //修改日期
objCoursewareResCaseENT.UpdUserId = objCoursewareResCaseENS.UpdUserId; //修改用户Id
objCoursewareResCaseENT.Memo = objCoursewareResCaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCoursewareResCaseEN objCoursewareResCaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCoursewareResCaseEN.CoursewareResCaseID, conCoursewareResCase.CoursewareResCaseID);
clsCheckSql.CheckFieldNotNull(objCoursewareResCaseEN.CoursewareResCaseName, conCoursewareResCase.CoursewareResCaseName);
clsCheckSql.CheckFieldNotNull(objCoursewareResCaseEN.IdCoursewareResCaseType, conCoursewareResCase.IdCoursewareResCaseType);
clsCheckSql.CheckFieldNotNull(objCoursewareResCaseEN.OwnerId, conCoursewareResCase.OwnerId);
clsCheckSql.CheckFieldNotNull(objCoursewareResCaseEN.IdXzCollege, conCoursewareResCase.IdXzCollege);
clsCheckSql.CheckFieldNotNull(objCoursewareResCaseEN.IdXzMajor, conCoursewareResCase.IdXzMajor);
clsCheckSql.CheckFieldNotNull(objCoursewareResCaseEN.RecommendedDegreeId, conCoursewareResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldNotNull(objCoursewareResCaseEN.CourseId, conCoursewareResCase.CourseId);
//检查字段长度
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdCoursewareResCase, 8, conCoursewareResCase.IdCoursewareResCase);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseID, 8, conCoursewareResCase.CoursewareResCaseID);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseName, 100, conCoursewareResCase.CoursewareResCaseName);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseTheme, 200, conCoursewareResCase.CoursewareResCaseTheme);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseText, 8000, conCoursewareResCase.CoursewareResCaseText);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdCoursewareResCaseType, 4, conCoursewareResCase.IdCoursewareResCaseType);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseDate, 8, conCoursewareResCase.CoursewareResCaseDate);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseTime, 6, conCoursewareResCase.CoursewareResCaseTime);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseDateIn, 8, conCoursewareResCase.CoursewareResCaseDateIn);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseTimeIn, 6, conCoursewareResCase.CoursewareResCaseTimeIn);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.OwnerId, 20, conCoursewareResCase.OwnerId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdStudyLevel, 4, conCoursewareResCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdTeachingPlan, 8, conCoursewareResCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdDiscipline, 4, conCoursewareResCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdSenateGaugeVersion, 4, conCoursewareResCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdTeachSkill, 8, conCoursewareResCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CaseLevelId, 2, conCoursewareResCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.DocFile, 200, conCoursewareResCase.DocFile);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.WordCreateDate, 14, conCoursewareResCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdXzCollege, 4, conCoursewareResCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdXzMajor, 8, conCoursewareResCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CourseChapterId, 8, conCoursewareResCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.RecommendedDegreeId, 2, conCoursewareResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.ftpFileType, 30, conCoursewareResCase.ftpFileType);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CourseId, 8, conCoursewareResCase.CourseId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.VideoUrl, 1000, conCoursewareResCase.VideoUrl);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.VideoPath, 1000, conCoursewareResCase.VideoPath);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.ResErrMsg, 30, conCoursewareResCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.UpdDate, 20, conCoursewareResCase.UpdDate);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.UpdUserId, 20, conCoursewareResCase.UpdUserId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.Memo, 1000, conCoursewareResCase.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objCoursewareResCaseEN.IdStudyLevel, 4, conCoursewareResCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objCoursewareResCaseEN.IdSenateGaugeVersion, 4, conCoursewareResCase.IdSenateGaugeVersion);
 objCoursewareResCaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCoursewareResCaseEN objCoursewareResCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseID, 8, conCoursewareResCase.CoursewareResCaseID);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseName, 100, conCoursewareResCase.CoursewareResCaseName);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseTheme, 200, conCoursewareResCase.CoursewareResCaseTheme);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseText, 8000, conCoursewareResCase.CoursewareResCaseText);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdCoursewareResCaseType, 4, conCoursewareResCase.IdCoursewareResCaseType);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseDate, 8, conCoursewareResCase.CoursewareResCaseDate);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseTime, 6, conCoursewareResCase.CoursewareResCaseTime);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseDateIn, 8, conCoursewareResCase.CoursewareResCaseDateIn);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseTimeIn, 6, conCoursewareResCase.CoursewareResCaseTimeIn);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.OwnerId, 20, conCoursewareResCase.OwnerId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdStudyLevel, 4, conCoursewareResCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdTeachingPlan, 8, conCoursewareResCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdDiscipline, 4, conCoursewareResCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdSenateGaugeVersion, 4, conCoursewareResCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdTeachSkill, 8, conCoursewareResCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CaseLevelId, 2, conCoursewareResCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.DocFile, 200, conCoursewareResCase.DocFile);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.WordCreateDate, 14, conCoursewareResCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdXzCollege, 4, conCoursewareResCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdXzMajor, 8, conCoursewareResCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CourseChapterId, 8, conCoursewareResCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.RecommendedDegreeId, 2, conCoursewareResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.ftpFileType, 30, conCoursewareResCase.ftpFileType);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CourseId, 8, conCoursewareResCase.CourseId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.VideoUrl, 1000, conCoursewareResCase.VideoUrl);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.VideoPath, 1000, conCoursewareResCase.VideoPath);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.ResErrMsg, 30, conCoursewareResCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.UpdDate, 20, conCoursewareResCase.UpdDate);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.UpdUserId, 20, conCoursewareResCase.UpdUserId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.Memo, 1000, conCoursewareResCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCoursewareResCaseEN.IdStudyLevel, 4, conCoursewareResCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objCoursewareResCaseEN.IdSenateGaugeVersion, 4, conCoursewareResCase.IdSenateGaugeVersion);
 objCoursewareResCaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCoursewareResCaseEN objCoursewareResCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdCoursewareResCase, 8, conCoursewareResCase.IdCoursewareResCase);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseID, 8, conCoursewareResCase.CoursewareResCaseID);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseName, 100, conCoursewareResCase.CoursewareResCaseName);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseTheme, 200, conCoursewareResCase.CoursewareResCaseTheme);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseText, 8000, conCoursewareResCase.CoursewareResCaseText);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdCoursewareResCaseType, 4, conCoursewareResCase.IdCoursewareResCaseType);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseDate, 8, conCoursewareResCase.CoursewareResCaseDate);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseTime, 6, conCoursewareResCase.CoursewareResCaseTime);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseDateIn, 8, conCoursewareResCase.CoursewareResCaseDateIn);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CoursewareResCaseTimeIn, 6, conCoursewareResCase.CoursewareResCaseTimeIn);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.OwnerId, 20, conCoursewareResCase.OwnerId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdStudyLevel, 4, conCoursewareResCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdTeachingPlan, 8, conCoursewareResCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdDiscipline, 4, conCoursewareResCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdSenateGaugeVersion, 4, conCoursewareResCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdTeachSkill, 8, conCoursewareResCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CaseLevelId, 2, conCoursewareResCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.DocFile, 200, conCoursewareResCase.DocFile);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.WordCreateDate, 14, conCoursewareResCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdXzCollege, 4, conCoursewareResCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.IdXzMajor, 8, conCoursewareResCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CourseChapterId, 8, conCoursewareResCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.RecommendedDegreeId, 2, conCoursewareResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.ftpFileType, 30, conCoursewareResCase.ftpFileType);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.CourseId, 8, conCoursewareResCase.CourseId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.VideoUrl, 1000, conCoursewareResCase.VideoUrl);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.VideoPath, 1000, conCoursewareResCase.VideoPath);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.ResErrMsg, 30, conCoursewareResCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.UpdDate, 20, conCoursewareResCase.UpdDate);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.UpdUserId, 20, conCoursewareResCase.UpdUserId);
clsCheckSql.CheckFieldLen(objCoursewareResCaseEN.Memo, 1000, conCoursewareResCase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.IdCoursewareResCase, conCoursewareResCase.IdCoursewareResCase);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.CoursewareResCaseID, conCoursewareResCase.CoursewareResCaseID);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.CoursewareResCaseName, conCoursewareResCase.CoursewareResCaseName);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.CoursewareResCaseTheme, conCoursewareResCase.CoursewareResCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.CoursewareResCaseText, conCoursewareResCase.CoursewareResCaseText);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.IdCoursewareResCaseType, conCoursewareResCase.IdCoursewareResCaseType);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.CoursewareResCaseDate, conCoursewareResCase.CoursewareResCaseDate);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.CoursewareResCaseTime, conCoursewareResCase.CoursewareResCaseTime);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.CoursewareResCaseDateIn, conCoursewareResCase.CoursewareResCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.CoursewareResCaseTimeIn, conCoursewareResCase.CoursewareResCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.OwnerId, conCoursewareResCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.IdStudyLevel, conCoursewareResCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.IdTeachingPlan, conCoursewareResCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.IdDiscipline, conCoursewareResCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.IdSenateGaugeVersion, conCoursewareResCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.IdTeachSkill, conCoursewareResCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.CaseLevelId, conCoursewareResCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.DocFile, conCoursewareResCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.WordCreateDate, conCoursewareResCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.IdXzCollege, conCoursewareResCase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.IdXzMajor, conCoursewareResCase.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.CourseChapterId, conCoursewareResCase.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.RecommendedDegreeId, conCoursewareResCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.ftpFileType, conCoursewareResCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.CourseId, conCoursewareResCase.CourseId);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.VideoUrl, conCoursewareResCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.VideoPath, conCoursewareResCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.ResErrMsg, conCoursewareResCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.UpdDate, conCoursewareResCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.UpdUserId, conCoursewareResCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objCoursewareResCaseEN.Memo, conCoursewareResCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCoursewareResCaseEN.IdStudyLevel, 4, conCoursewareResCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objCoursewareResCaseEN.IdSenateGaugeVersion, 4, conCoursewareResCase.IdSenateGaugeVersion);
 objCoursewareResCaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdCoursewareResCase()
{
//获取某学院所有专业信息
string strSQL = "select IdCoursewareResCase, CoursewareResCaseName from CoursewareResCase ";
 clsSpecSQLforSql mySql = clsCoursewareResCaseDA.GetSpecSQLObj();
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
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
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
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
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
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCoursewareResCaseEN._CurrTabName);
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
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCoursewareResCaseEN._CurrTabName, strCondition);
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
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
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
 objSQL = clsCoursewareResCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}