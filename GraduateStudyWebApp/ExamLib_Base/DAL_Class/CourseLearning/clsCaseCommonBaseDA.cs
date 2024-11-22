
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseCommonBaseDA
 表名:CaseCommonBase(01120343)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:49
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
 /// 案例公共基类(CaseCommonBase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCaseCommonBaseDA : clsCommBase4DA
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
 return clsCaseCommonBaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCaseCommonBaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCaseCommonBaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCaseCommonBaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCaseCommonBaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdCase)
{
strIdCase = strIdCase.Replace("'", "''");
if (strIdCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:CaseCommonBase中,检查关键字,长度不正确!(clsCaseCommonBaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CaseCommonBase中,关键字不能为空 或 null!(clsCaseCommonBaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCaseCommonBaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCaseCommonBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
strSQL = "Select * from CaseCommonBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CaseCommonBase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCaseCommonBaseDA: GetDataTable_CaseCommonBase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
strSQL = "Select * from CaseCommonBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCaseCommonBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCaseCommonBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
strSQL = "Select * from CaseCommonBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCaseCommonBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCaseCommonBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseCommonBase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseCommonBase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCaseCommonBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CaseCommonBase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCaseCommonBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CaseCommonBase.* from CaseCommonBase Left Join {1} on {2} where {3} and CaseCommonBase.IdCase not in (Select top {5} CaseCommonBase.IdCase from CaseCommonBase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseCommonBase where {1} and IdCase not in (Select top {2} IdCase from CaseCommonBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseCommonBase where {1} and IdCase not in (Select top {3} IdCase from CaseCommonBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCaseCommonBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CaseCommonBase.* from CaseCommonBase Left Join {1} on {2} where {3} and CaseCommonBase.IdCase not in (Select top {5} CaseCommonBase.IdCase from CaseCommonBase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseCommonBase where {1} and IdCase not in (Select top {2} IdCase from CaseCommonBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseCommonBase where {1} and IdCase not in (Select top {3} IdCase from CaseCommonBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCaseCommonBaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCaseCommonBaseDA:GetObjLst)", objException.Message));
}
List<clsCaseCommonBaseEN> arrObjLst = new List<clsCaseCommonBaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
strSQL = "Select * from CaseCommonBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCommonBaseEN objCaseCommonBaseEN = new clsCaseCommonBaseEN();
try
{
objCaseCommonBaseEN.IdCase = objRow[conCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objCaseCommonBaseEN.CaseId = objRow[conCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objCaseCommonBaseEN.CaseName = objRow[conCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objCaseCommonBaseEN.CaseText = objRow[conCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objCaseCommonBaseEN.CaseTheme = objRow[conCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objCaseCommonBaseEN.FuncModuleId = objRow[conCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCommonBaseEN.CourseChapterId = objRow[conCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objCaseCommonBaseEN.IdCaseType = objRow[conCaseCommonBase.IdCaseType] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objCaseCommonBaseEN.CaseDate = objRow[conCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objCaseCommonBaseEN.CaseTime = objRow[conCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objCaseCommonBaseEN.CaseDateIn = objRow[conCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objCaseCommonBaseEN.CaseTimeIn = objRow[conCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objCaseCommonBaseEN.OwnerId = objRow[conCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objCaseCommonBaseEN.IdStudyLevel = objRow[conCaseCommonBase.IdStudyLevel] == DBNull.Value ? null : objRow[conCaseCommonBase.IdStudyLevel].ToString().Trim(); //学段流水号
objCaseCommonBaseEN.IdTeachingPlan = objRow[conCaseCommonBase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCaseCommonBaseEN.IdDiscipline = objRow[conCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objCaseCommonBaseEN.BrowseCount = objRow[conCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objCaseCommonBaseEN.IdSenateGaugeVersion = objRow[conCaseCommonBase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCaseCommonBaseEN.IdTeachSkill = objRow[conCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCaseCommonBaseEN.CaseLevelId = objRow[conCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objCaseCommonBaseEN.DocFile = objRow[conCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[conCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objCaseCommonBaseEN.IsNeedGeneWord = TransNullToBool(objRow[conCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCaseCommonBaseEN.WordCreateDate = objRow[conCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[conCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objCaseCommonBaseEN.IsVisible = TransNullToBool(objRow[conCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objCaseCommonBaseEN.IsDualVideo = TransNullToBool(objRow[conCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objCaseCommonBaseEN.IdXzCollege = objRow[conCaseCommonBase.IdXzCollege].ToString().Trim(); //学院流水号
objCaseCommonBaseEN.IdXzMajor = objRow[conCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objCaseCommonBaseEN.ViewCount = objRow[conCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objCaseCommonBaseEN.IsShow = TransNullToBool(objRow[conCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objCaseCommonBaseEN.DownloadNumber = objRow[conCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objCaseCommonBaseEN.FileIntegration = objRow[conCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objCaseCommonBaseEN.LikeCount = objRow[conCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objCaseCommonBaseEN.CollectionCount = objRow[conCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
objCaseCommonBaseEN.RecommendedDegreeId = objRow[conCaseCommonBase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCaseCommonBaseEN.CourseId = objRow[conCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objCaseCommonBaseEN.IdCaseType4FuncModuleId = objRow[conCaseCommonBase.IdCaseType4FuncModuleId] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(); //案例类型流水号4模块
objCaseCommonBaseEN.ftpFileType = objRow[conCaseCommonBase.ftpFileType] == DBNull.Value ? null : objRow[conCaseCommonBase.ftpFileType].ToString().Trim(); //ftp文件类型
objCaseCommonBaseEN.VideoUrl = objRow[conCaseCommonBase.VideoUrl] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoUrl].ToString().Trim(); //视频Url
objCaseCommonBaseEN.VideoPath = objRow[conCaseCommonBase.VideoPath] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoPath].ToString().Trim(); //视频目录
objCaseCommonBaseEN.ResErrMsg = objRow[conCaseCommonBase.ResErrMsg] == DBNull.Value ? null : objRow[conCaseCommonBase.ResErrMsg].ToString().Trim(); //资源错误信息
objCaseCommonBaseEN.UpdDate = objRow[conCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objCaseCommonBaseEN.UpdUserId = objRow[conCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCommonBaseEN.Memo = objRow[conCaseCommonBase.Memo] == DBNull.Value ? null : objRow[conCaseCommonBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCaseCommonBaseDA: GetObjLst)", objException.Message));
}
objCaseCommonBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCaseCommonBaseEN);
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
public List<clsCaseCommonBaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCaseCommonBaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsCaseCommonBaseEN> arrObjLst = new List<clsCaseCommonBaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCommonBaseEN objCaseCommonBaseEN = new clsCaseCommonBaseEN();
try
{
objCaseCommonBaseEN.IdCase = objRow[conCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objCaseCommonBaseEN.CaseId = objRow[conCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objCaseCommonBaseEN.CaseName = objRow[conCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objCaseCommonBaseEN.CaseText = objRow[conCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objCaseCommonBaseEN.CaseTheme = objRow[conCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objCaseCommonBaseEN.FuncModuleId = objRow[conCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCommonBaseEN.CourseChapterId = objRow[conCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objCaseCommonBaseEN.IdCaseType = objRow[conCaseCommonBase.IdCaseType] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objCaseCommonBaseEN.CaseDate = objRow[conCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objCaseCommonBaseEN.CaseTime = objRow[conCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objCaseCommonBaseEN.CaseDateIn = objRow[conCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objCaseCommonBaseEN.CaseTimeIn = objRow[conCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objCaseCommonBaseEN.OwnerId = objRow[conCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objCaseCommonBaseEN.IdStudyLevel = objRow[conCaseCommonBase.IdStudyLevel] == DBNull.Value ? null : objRow[conCaseCommonBase.IdStudyLevel].ToString().Trim(); //学段流水号
objCaseCommonBaseEN.IdTeachingPlan = objRow[conCaseCommonBase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCaseCommonBaseEN.IdDiscipline = objRow[conCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objCaseCommonBaseEN.BrowseCount = objRow[conCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objCaseCommonBaseEN.IdSenateGaugeVersion = objRow[conCaseCommonBase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCaseCommonBaseEN.IdTeachSkill = objRow[conCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCaseCommonBaseEN.CaseLevelId = objRow[conCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objCaseCommonBaseEN.DocFile = objRow[conCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[conCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objCaseCommonBaseEN.IsNeedGeneWord = TransNullToBool(objRow[conCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCaseCommonBaseEN.WordCreateDate = objRow[conCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[conCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objCaseCommonBaseEN.IsVisible = TransNullToBool(objRow[conCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objCaseCommonBaseEN.IsDualVideo = TransNullToBool(objRow[conCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objCaseCommonBaseEN.IdXzCollege = objRow[conCaseCommonBase.IdXzCollege].ToString().Trim(); //学院流水号
objCaseCommonBaseEN.IdXzMajor = objRow[conCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objCaseCommonBaseEN.ViewCount = objRow[conCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objCaseCommonBaseEN.IsShow = TransNullToBool(objRow[conCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objCaseCommonBaseEN.DownloadNumber = objRow[conCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objCaseCommonBaseEN.FileIntegration = objRow[conCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objCaseCommonBaseEN.LikeCount = objRow[conCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objCaseCommonBaseEN.CollectionCount = objRow[conCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
objCaseCommonBaseEN.RecommendedDegreeId = objRow[conCaseCommonBase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCaseCommonBaseEN.CourseId = objRow[conCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objCaseCommonBaseEN.IdCaseType4FuncModuleId = objRow[conCaseCommonBase.IdCaseType4FuncModuleId] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(); //案例类型流水号4模块
objCaseCommonBaseEN.ftpFileType = objRow[conCaseCommonBase.ftpFileType] == DBNull.Value ? null : objRow[conCaseCommonBase.ftpFileType].ToString().Trim(); //ftp文件类型
objCaseCommonBaseEN.VideoUrl = objRow[conCaseCommonBase.VideoUrl] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoUrl].ToString().Trim(); //视频Url
objCaseCommonBaseEN.VideoPath = objRow[conCaseCommonBase.VideoPath] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoPath].ToString().Trim(); //视频目录
objCaseCommonBaseEN.ResErrMsg = objRow[conCaseCommonBase.ResErrMsg] == DBNull.Value ? null : objRow[conCaseCommonBase.ResErrMsg].ToString().Trim(); //资源错误信息
objCaseCommonBaseEN.UpdDate = objRow[conCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objCaseCommonBaseEN.UpdUserId = objRow[conCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCommonBaseEN.Memo = objRow[conCaseCommonBase.Memo] == DBNull.Value ? null : objRow[conCaseCommonBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCaseCommonBaseDA: GetObjLst)", objException.Message));
}
objCaseCommonBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCaseCommonBaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCaseCommonBase(ref clsCaseCommonBaseEN objCaseCommonBaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
strSQL = "Select * from CaseCommonBase where IdCase = " + "'"+ objCaseCommonBaseEN.IdCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCaseCommonBaseEN.IdCase = objDT.Rows[0][conCaseCommonBase.IdCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objCaseCommonBaseEN.CaseId = objDT.Rows[0][conCaseCommonBase.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objCaseCommonBaseEN.CaseName = objDT.Rows[0][conCaseCommonBase.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objCaseCommonBaseEN.CaseText = objDT.Rows[0][conCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objCaseCommonBaseEN.CaseTheme = objDT.Rows[0][conCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objCaseCommonBaseEN.FuncModuleId = objDT.Rows[0][conCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.CourseChapterId = objDT.Rows[0][conCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objCaseCommonBaseEN.IdCaseType = objDT.Rows[0][conCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.CaseDate = objDT.Rows[0][conCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期(字段类型:char,字段长度:8,是否可空:True)
 objCaseCommonBaseEN.CaseTime = objDT.Rows[0][conCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间(字段类型:char,字段长度:6,是否可空:True)
 objCaseCommonBaseEN.CaseDateIn = objDT.Rows[0][conCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objCaseCommonBaseEN.CaseTimeIn = objDT.Rows[0][conCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objCaseCommonBaseEN.OwnerId = objDT.Rows[0][conCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objCaseCommonBaseEN.IdStudyLevel = objDT.Rows[0][conCaseCommonBase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.IdTeachingPlan = objDT.Rows[0][conCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objCaseCommonBaseEN.IdDiscipline = objDT.Rows[0][conCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objCaseCommonBaseEN.BrowseCount = TransNullToInt(objDT.Rows[0][conCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.IdSenateGaugeVersion = objDT.Rows[0][conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objCaseCommonBaseEN.IdTeachSkill = objDT.Rows[0][conCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objCaseCommonBaseEN.CaseLevelId = objDT.Rows[0][conCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objCaseCommonBaseEN.DocFile = objDT.Rows[0][conCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objCaseCommonBaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][conCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objCaseCommonBaseEN.WordCreateDate = objDT.Rows[0][conCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objCaseCommonBaseEN.IsVisible = TransNullToBool(objDT.Rows[0][conCaseCommonBase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objCaseCommonBaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][conCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objCaseCommonBaseEN.IdXzCollege = objDT.Rows[0][conCaseCommonBase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.IdXzMajor = objDT.Rows[0][conCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objCaseCommonBaseEN.ViewCount = TransNullToInt(objDT.Rows[0][conCaseCommonBase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.IsShow = TransNullToBool(objDT.Rows[0][conCaseCommonBase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objCaseCommonBaseEN.DownloadNumber = TransNullToInt(objDT.Rows[0][conCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.FileIntegration = TransNullToInt(objDT.Rows[0][conCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.LikeCount = TransNullToInt(objDT.Rows[0][conCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objCaseCommonBaseEN.CollectionCount = TransNullToInt(objDT.Rows[0][conCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objCaseCommonBaseEN.RecommendedDegreeId = objDT.Rows[0][conCaseCommonBase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objCaseCommonBaseEN.CourseId = objDT.Rows[0][conCaseCommonBase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objCaseCommonBaseEN.IdCaseType4FuncModuleId = objDT.Rows[0][conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(); //案例类型流水号4模块(字段类型:char,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.ftpFileType = objDT.Rows[0][conCaseCommonBase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objCaseCommonBaseEN.VideoUrl = objDT.Rows[0][conCaseCommonBase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objCaseCommonBaseEN.VideoPath = objDT.Rows[0][conCaseCommonBase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objCaseCommonBaseEN.ResErrMsg = objDT.Rows[0][conCaseCommonBase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objCaseCommonBaseEN.UpdDate = objDT.Rows[0][conCaseCommonBase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseCommonBaseEN.UpdUserId = objDT.Rows[0][conCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseCommonBaseEN.Memo = objDT.Rows[0][conCaseCommonBase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCaseCommonBaseDA: GetCaseCommonBase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCase">表关键字</param>
 /// <returns>表对象</returns>
public clsCaseCommonBaseEN GetObjByIdCase(string strIdCase)
{
CheckPrimaryKey(strIdCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
strSQL = "Select * from CaseCommonBase where IdCase = " + "'"+ strIdCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCaseCommonBaseEN objCaseCommonBaseEN = new clsCaseCommonBaseEN();
try
{
 objCaseCommonBaseEN.IdCase = objRow[conCaseCommonBase.IdCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objCaseCommonBaseEN.CaseId = objRow[conCaseCommonBase.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objCaseCommonBaseEN.CaseName = objRow[conCaseCommonBase.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objCaseCommonBaseEN.CaseText = objRow[conCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objCaseCommonBaseEN.CaseTheme = objRow[conCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objCaseCommonBaseEN.FuncModuleId = objRow[conCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.CourseChapterId = objRow[conCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objCaseCommonBaseEN.IdCaseType = objRow[conCaseCommonBase.IdCaseType] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.CaseDate = objRow[conCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期(字段类型:char,字段长度:8,是否可空:True)
 objCaseCommonBaseEN.CaseTime = objRow[conCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间(字段类型:char,字段长度:6,是否可空:True)
 objCaseCommonBaseEN.CaseDateIn = objRow[conCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objCaseCommonBaseEN.CaseTimeIn = objRow[conCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objCaseCommonBaseEN.OwnerId = objRow[conCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objCaseCommonBaseEN.IdStudyLevel = objRow[conCaseCommonBase.IdStudyLevel] == DBNull.Value ? null : objRow[conCaseCommonBase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.IdTeachingPlan = objRow[conCaseCommonBase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objCaseCommonBaseEN.IdDiscipline = objRow[conCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objCaseCommonBaseEN.BrowseCount = objRow[conCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.IdSenateGaugeVersion = objRow[conCaseCommonBase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objCaseCommonBaseEN.IdTeachSkill = objRow[conCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objCaseCommonBaseEN.CaseLevelId = objRow[conCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objCaseCommonBaseEN.DocFile = objRow[conCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[conCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objCaseCommonBaseEN.WordCreateDate = objRow[conCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[conCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objCaseCommonBaseEN.IdXzCollege = objRow[conCaseCommonBase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.IdXzMajor = objRow[conCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objCaseCommonBaseEN.ViewCount = objRow[conCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objCaseCommonBaseEN.DownloadNumber = objRow[conCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.FileIntegration = objRow[conCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.LikeCount = objRow[conCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objCaseCommonBaseEN.CollectionCount = objRow[conCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objCaseCommonBaseEN.RecommendedDegreeId = objRow[conCaseCommonBase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objCaseCommonBaseEN.CourseId = objRow[conCaseCommonBase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objCaseCommonBaseEN.IdCaseType4FuncModuleId = objRow[conCaseCommonBase.IdCaseType4FuncModuleId] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(); //案例类型流水号4模块(字段类型:char,字段长度:4,是否可空:True)
 objCaseCommonBaseEN.ftpFileType = objRow[conCaseCommonBase.ftpFileType] == DBNull.Value ? null : objRow[conCaseCommonBase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objCaseCommonBaseEN.VideoUrl = objRow[conCaseCommonBase.VideoUrl] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objCaseCommonBaseEN.VideoPath = objRow[conCaseCommonBase.VideoPath] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objCaseCommonBaseEN.ResErrMsg = objRow[conCaseCommonBase.ResErrMsg] == DBNull.Value ? null : objRow[conCaseCommonBase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objCaseCommonBaseEN.UpdDate = objRow[conCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseCommonBaseEN.UpdUserId = objRow[conCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseCommonBaseEN.Memo = objRow[conCaseCommonBase.Memo] == DBNull.Value ? null : objRow[conCaseCommonBase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCaseCommonBaseDA: GetObjByIdCase)", objException.Message));
}
return objCaseCommonBaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCaseCommonBaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCaseCommonBaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
strSQL = "Select * from CaseCommonBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCaseCommonBaseEN objCaseCommonBaseEN = new clsCaseCommonBaseEN()
{
IdCase = objRow[conCaseCommonBase.IdCase].ToString().Trim(), //案例流水号
CaseId = objRow[conCaseCommonBase.CaseId].ToString().Trim(), //案例Id
CaseName = objRow[conCaseCommonBase.CaseName].ToString().Trim(), //案例名称
CaseText = objRow[conCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseText].ToString().Trim(), //案例文本内容
CaseTheme = objRow[conCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTheme].ToString().Trim(), //案例主题词
FuncModuleId = objRow[conCaseCommonBase.FuncModuleId].ToString().Trim(), //功能模块Id
CourseChapterId = objRow[conCaseCommonBase.CourseChapterId].ToString().Trim(), //课程章节ID
IdCaseType = objRow[conCaseCommonBase.IdCaseType] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType].ToString().Trim(), //案例类型流水号
CaseDate = objRow[conCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDate].ToString().Trim(), //案例建立日期
CaseTime = objRow[conCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTime].ToString().Trim(), //案例建立时间
CaseDateIn = objRow[conCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDateIn].ToString().Trim(), //案例入库日期
CaseTimeIn = objRow[conCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTimeIn].ToString().Trim(), //案例入库时间
OwnerId = objRow[conCaseCommonBase.OwnerId].ToString().Trim(), //拥有者Id
IdStudyLevel = objRow[conCaseCommonBase.IdStudyLevel] == DBNull.Value ? null : objRow[conCaseCommonBase.IdStudyLevel].ToString().Trim(), //学段流水号
IdTeachingPlan = objRow[conCaseCommonBase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCaseCommonBase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdDiscipline = objRow[conCaseCommonBase.IdDiscipline].ToString().Trim(), //学科流水号
BrowseCount = objRow[conCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[conCaseCommonBase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
IdTeachSkill = objRow[conCaseCommonBase.IdTeachSkill].ToString().Trim(), //教学技能流水号
CaseLevelId = objRow[conCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseLevelId].ToString().Trim(), //课例等级Id
DocFile = objRow[conCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[conCaseCommonBase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[conCaseCommonBase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[conCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[conCaseCommonBase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[conCaseCommonBase.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[conCaseCommonBase.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[conCaseCommonBase.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[conCaseCommonBase.IdXzMajor].ToString().Trim(), //专业流水号
ViewCount = objRow[conCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[conCaseCommonBase.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[conCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[conCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[conCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCaseCommonBase.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[conCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCaseCommonBase.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[conCaseCommonBase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
CourseId = objRow[conCaseCommonBase.CourseId].ToString().Trim(), //课程Id
IdCaseType4FuncModuleId = objRow[conCaseCommonBase.IdCaseType4FuncModuleId] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(), //案例类型流水号4模块
ftpFileType = objRow[conCaseCommonBase.ftpFileType] == DBNull.Value ? null : objRow[conCaseCommonBase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[conCaseCommonBase.VideoUrl] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[conCaseCommonBase.VideoPath] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[conCaseCommonBase.ResErrMsg] == DBNull.Value ? null : objRow[conCaseCommonBase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdDate = objRow[conCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conCaseCommonBase.Memo] == DBNull.Value ? null : objRow[conCaseCommonBase.Memo].ToString().Trim() //备注
};
objCaseCommonBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseCommonBaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCaseCommonBaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCaseCommonBaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCaseCommonBaseEN objCaseCommonBaseEN = new clsCaseCommonBaseEN();
try
{
objCaseCommonBaseEN.IdCase = objRow[conCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objCaseCommonBaseEN.CaseId = objRow[conCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objCaseCommonBaseEN.CaseName = objRow[conCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objCaseCommonBaseEN.CaseText = objRow[conCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objCaseCommonBaseEN.CaseTheme = objRow[conCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objCaseCommonBaseEN.FuncModuleId = objRow[conCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCommonBaseEN.CourseChapterId = objRow[conCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objCaseCommonBaseEN.IdCaseType = objRow[conCaseCommonBase.IdCaseType] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objCaseCommonBaseEN.CaseDate = objRow[conCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objCaseCommonBaseEN.CaseTime = objRow[conCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objCaseCommonBaseEN.CaseDateIn = objRow[conCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objCaseCommonBaseEN.CaseTimeIn = objRow[conCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objCaseCommonBaseEN.OwnerId = objRow[conCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objCaseCommonBaseEN.IdStudyLevel = objRow[conCaseCommonBase.IdStudyLevel] == DBNull.Value ? null : objRow[conCaseCommonBase.IdStudyLevel].ToString().Trim(); //学段流水号
objCaseCommonBaseEN.IdTeachingPlan = objRow[conCaseCommonBase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCaseCommonBaseEN.IdDiscipline = objRow[conCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objCaseCommonBaseEN.BrowseCount = objRow[conCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objCaseCommonBaseEN.IdSenateGaugeVersion = objRow[conCaseCommonBase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCaseCommonBaseEN.IdTeachSkill = objRow[conCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCaseCommonBaseEN.CaseLevelId = objRow[conCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objCaseCommonBaseEN.DocFile = objRow[conCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[conCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objCaseCommonBaseEN.IsNeedGeneWord = TransNullToBool(objRow[conCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCaseCommonBaseEN.WordCreateDate = objRow[conCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[conCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objCaseCommonBaseEN.IsVisible = TransNullToBool(objRow[conCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objCaseCommonBaseEN.IsDualVideo = TransNullToBool(objRow[conCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objCaseCommonBaseEN.IdXzCollege = objRow[conCaseCommonBase.IdXzCollege].ToString().Trim(); //学院流水号
objCaseCommonBaseEN.IdXzMajor = objRow[conCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objCaseCommonBaseEN.ViewCount = objRow[conCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objCaseCommonBaseEN.IsShow = TransNullToBool(objRow[conCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objCaseCommonBaseEN.DownloadNumber = objRow[conCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objCaseCommonBaseEN.FileIntegration = objRow[conCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objCaseCommonBaseEN.LikeCount = objRow[conCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objCaseCommonBaseEN.CollectionCount = objRow[conCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
objCaseCommonBaseEN.RecommendedDegreeId = objRow[conCaseCommonBase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCaseCommonBaseEN.CourseId = objRow[conCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objCaseCommonBaseEN.IdCaseType4FuncModuleId = objRow[conCaseCommonBase.IdCaseType4FuncModuleId] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(); //案例类型流水号4模块
objCaseCommonBaseEN.ftpFileType = objRow[conCaseCommonBase.ftpFileType] == DBNull.Value ? null : objRow[conCaseCommonBase.ftpFileType].ToString().Trim(); //ftp文件类型
objCaseCommonBaseEN.VideoUrl = objRow[conCaseCommonBase.VideoUrl] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoUrl].ToString().Trim(); //视频Url
objCaseCommonBaseEN.VideoPath = objRow[conCaseCommonBase.VideoPath] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoPath].ToString().Trim(); //视频目录
objCaseCommonBaseEN.ResErrMsg = objRow[conCaseCommonBase.ResErrMsg] == DBNull.Value ? null : objRow[conCaseCommonBase.ResErrMsg].ToString().Trim(); //资源错误信息
objCaseCommonBaseEN.UpdDate = objRow[conCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objCaseCommonBaseEN.UpdUserId = objRow[conCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCommonBaseEN.Memo = objRow[conCaseCommonBase.Memo] == DBNull.Value ? null : objRow[conCaseCommonBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCaseCommonBaseDA: GetObjByDataRowCaseCommonBase)", objException.Message));
}
objCaseCommonBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseCommonBaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCaseCommonBaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCaseCommonBaseEN objCaseCommonBaseEN = new clsCaseCommonBaseEN();
try
{
objCaseCommonBaseEN.IdCase = objRow[conCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objCaseCommonBaseEN.CaseId = objRow[conCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objCaseCommonBaseEN.CaseName = objRow[conCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objCaseCommonBaseEN.CaseText = objRow[conCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objCaseCommonBaseEN.CaseTheme = objRow[conCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objCaseCommonBaseEN.FuncModuleId = objRow[conCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCommonBaseEN.CourseChapterId = objRow[conCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objCaseCommonBaseEN.IdCaseType = objRow[conCaseCommonBase.IdCaseType] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objCaseCommonBaseEN.CaseDate = objRow[conCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objCaseCommonBaseEN.CaseTime = objRow[conCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objCaseCommonBaseEN.CaseDateIn = objRow[conCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objCaseCommonBaseEN.CaseTimeIn = objRow[conCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objCaseCommonBaseEN.OwnerId = objRow[conCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objCaseCommonBaseEN.IdStudyLevel = objRow[conCaseCommonBase.IdStudyLevel] == DBNull.Value ? null : objRow[conCaseCommonBase.IdStudyLevel].ToString().Trim(); //学段流水号
objCaseCommonBaseEN.IdTeachingPlan = objRow[conCaseCommonBase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCaseCommonBaseEN.IdDiscipline = objRow[conCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objCaseCommonBaseEN.BrowseCount = objRow[conCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objCaseCommonBaseEN.IdSenateGaugeVersion = objRow[conCaseCommonBase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCaseCommonBaseEN.IdTeachSkill = objRow[conCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCaseCommonBaseEN.CaseLevelId = objRow[conCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objCaseCommonBaseEN.DocFile = objRow[conCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[conCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objCaseCommonBaseEN.IsNeedGeneWord = TransNullToBool(objRow[conCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCaseCommonBaseEN.WordCreateDate = objRow[conCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[conCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objCaseCommonBaseEN.IsVisible = TransNullToBool(objRow[conCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objCaseCommonBaseEN.IsDualVideo = TransNullToBool(objRow[conCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objCaseCommonBaseEN.IdXzCollege = objRow[conCaseCommonBase.IdXzCollege].ToString().Trim(); //学院流水号
objCaseCommonBaseEN.IdXzMajor = objRow[conCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objCaseCommonBaseEN.ViewCount = objRow[conCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objCaseCommonBaseEN.IsShow = TransNullToBool(objRow[conCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objCaseCommonBaseEN.DownloadNumber = objRow[conCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objCaseCommonBaseEN.FileIntegration = objRow[conCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objCaseCommonBaseEN.LikeCount = objRow[conCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objCaseCommonBaseEN.CollectionCount = objRow[conCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
objCaseCommonBaseEN.RecommendedDegreeId = objRow[conCaseCommonBase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCaseCommonBaseEN.CourseId = objRow[conCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objCaseCommonBaseEN.IdCaseType4FuncModuleId = objRow[conCaseCommonBase.IdCaseType4FuncModuleId] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(); //案例类型流水号4模块
objCaseCommonBaseEN.ftpFileType = objRow[conCaseCommonBase.ftpFileType] == DBNull.Value ? null : objRow[conCaseCommonBase.ftpFileType].ToString().Trim(); //ftp文件类型
objCaseCommonBaseEN.VideoUrl = objRow[conCaseCommonBase.VideoUrl] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoUrl].ToString().Trim(); //视频Url
objCaseCommonBaseEN.VideoPath = objRow[conCaseCommonBase.VideoPath] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoPath].ToString().Trim(); //视频目录
objCaseCommonBaseEN.ResErrMsg = objRow[conCaseCommonBase.ResErrMsg] == DBNull.Value ? null : objRow[conCaseCommonBase.ResErrMsg].ToString().Trim(); //资源错误信息
objCaseCommonBaseEN.UpdDate = objRow[conCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objCaseCommonBaseEN.UpdUserId = objRow[conCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCommonBaseEN.Memo = objRow[conCaseCommonBase.Memo] == DBNull.Value ? null : objRow[conCaseCommonBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCaseCommonBaseDA: GetObjByDataRow)", objException.Message));
}
objCaseCommonBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseCommonBaseEN;
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
objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCaseCommonBaseEN._CurrTabName, conCaseCommonBase.IdCase, 8, "");
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
objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCaseCommonBaseEN._CurrTabName, conCaseCommonBase.IdCase, 8, strPrefix);
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
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCase from CaseCommonBase where " + strCondition;
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
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCase from CaseCommonBase where " + strCondition;
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
 /// <param name = "strIdCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdCase)
{
CheckPrimaryKey(strIdCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CaseCommonBase", "IdCase = " + "'"+ strIdCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCaseCommonBaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CaseCommonBase", strCondition))
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
objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CaseCommonBase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCaseCommonBaseEN objCaseCommonBaseEN)
 {
 objCaseCommonBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCommonBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseCommonBaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
strSQL = "Select * from CaseCommonBase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CaseCommonBase");
objRow = objDS.Tables["CaseCommonBase"].NewRow();
objRow[conCaseCommonBase.IdCase] = objCaseCommonBaseEN.IdCase; //案例流水号
objRow[conCaseCommonBase.CaseId] = objCaseCommonBaseEN.CaseId; //案例Id
objRow[conCaseCommonBase.CaseName] = objCaseCommonBaseEN.CaseName; //案例名称
 if (objCaseCommonBaseEN.CaseText !=  "")
 {
objRow[conCaseCommonBase.CaseText] = objCaseCommonBaseEN.CaseText; //案例文本内容
 }
 if (objCaseCommonBaseEN.CaseTheme !=  "")
 {
objRow[conCaseCommonBase.CaseTheme] = objCaseCommonBaseEN.CaseTheme; //案例主题词
 }
objRow[conCaseCommonBase.FuncModuleId] = objCaseCommonBaseEN.FuncModuleId; //功能模块Id
objRow[conCaseCommonBase.CourseChapterId] = objCaseCommonBaseEN.CourseChapterId; //课程章节ID
 if (objCaseCommonBaseEN.IdCaseType !=  "")
 {
objRow[conCaseCommonBase.IdCaseType] = objCaseCommonBaseEN.IdCaseType; //案例类型流水号
 }
 if (objCaseCommonBaseEN.CaseDate !=  "")
 {
objRow[conCaseCommonBase.CaseDate] = objCaseCommonBaseEN.CaseDate; //案例建立日期
 }
 if (objCaseCommonBaseEN.CaseTime !=  "")
 {
objRow[conCaseCommonBase.CaseTime] = objCaseCommonBaseEN.CaseTime; //案例建立时间
 }
 if (objCaseCommonBaseEN.CaseDateIn !=  "")
 {
objRow[conCaseCommonBase.CaseDateIn] = objCaseCommonBaseEN.CaseDateIn; //案例入库日期
 }
 if (objCaseCommonBaseEN.CaseTimeIn !=  "")
 {
objRow[conCaseCommonBase.CaseTimeIn] = objCaseCommonBaseEN.CaseTimeIn; //案例入库时间
 }
objRow[conCaseCommonBase.OwnerId] = objCaseCommonBaseEN.OwnerId; //拥有者Id
 if (objCaseCommonBaseEN.IdStudyLevel !=  "")
 {
objRow[conCaseCommonBase.IdStudyLevel] = objCaseCommonBaseEN.IdStudyLevel; //学段流水号
 }
 if (objCaseCommonBaseEN.IdTeachingPlan !=  "")
 {
objRow[conCaseCommonBase.IdTeachingPlan] = objCaseCommonBaseEN.IdTeachingPlan; //教案流水号
 }
objRow[conCaseCommonBase.IdDiscipline] = objCaseCommonBaseEN.IdDiscipline; //学科流水号
objRow[conCaseCommonBase.BrowseCount] = objCaseCommonBaseEN.BrowseCount; //浏览次数
 if (objCaseCommonBaseEN.IdSenateGaugeVersion !=  "")
 {
objRow[conCaseCommonBase.IdSenateGaugeVersion] = objCaseCommonBaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
objRow[conCaseCommonBase.IdTeachSkill] = objCaseCommonBaseEN.IdTeachSkill; //教学技能流水号
 if (objCaseCommonBaseEN.CaseLevelId !=  "")
 {
objRow[conCaseCommonBase.CaseLevelId] = objCaseCommonBaseEN.CaseLevelId; //课例等级Id
 }
 if (objCaseCommonBaseEN.DocFile !=  "")
 {
objRow[conCaseCommonBase.DocFile] = objCaseCommonBaseEN.DocFile; //生成的Word文件名
 }
objRow[conCaseCommonBase.IsNeedGeneWord] = objCaseCommonBaseEN.IsNeedGeneWord; //是否需要生成Word
 if (objCaseCommonBaseEN.WordCreateDate !=  "")
 {
objRow[conCaseCommonBase.WordCreateDate] = objCaseCommonBaseEN.WordCreateDate; //Word生成日期
 }
objRow[conCaseCommonBase.IsVisible] = objCaseCommonBaseEN.IsVisible; //是否显示
objRow[conCaseCommonBase.IsDualVideo] = objCaseCommonBaseEN.IsDualVideo; //是否双视频
objRow[conCaseCommonBase.IdXzCollege] = objCaseCommonBaseEN.IdXzCollege; //学院流水号
objRow[conCaseCommonBase.IdXzMajor] = objCaseCommonBaseEN.IdXzMajor; //专业流水号
objRow[conCaseCommonBase.ViewCount] = objCaseCommonBaseEN.ViewCount; //浏览量
objRow[conCaseCommonBase.IsShow] = objCaseCommonBaseEN.IsShow; //是否启用
objRow[conCaseCommonBase.DownloadNumber] = objCaseCommonBaseEN.DownloadNumber; //下载数目
objRow[conCaseCommonBase.FileIntegration] = objCaseCommonBaseEN.FileIntegration; //文件积分
objRow[conCaseCommonBase.LikeCount] = objCaseCommonBaseEN.LikeCount; //资源喜欢数量
objRow[conCaseCommonBase.CollectionCount] = objCaseCommonBaseEN.CollectionCount; //收藏数量
objRow[conCaseCommonBase.RecommendedDegreeId] = objCaseCommonBaseEN.RecommendedDegreeId; //推荐度Id
objRow[conCaseCommonBase.CourseId] = objCaseCommonBaseEN.CourseId; //课程Id
 if (objCaseCommonBaseEN.IdCaseType4FuncModuleId !=  "")
 {
objRow[conCaseCommonBase.IdCaseType4FuncModuleId] = objCaseCommonBaseEN.IdCaseType4FuncModuleId; //案例类型流水号4模块
 }
 if (objCaseCommonBaseEN.ftpFileType !=  "")
 {
objRow[conCaseCommonBase.ftpFileType] = objCaseCommonBaseEN.ftpFileType; //ftp文件类型
 }
 if (objCaseCommonBaseEN.VideoUrl !=  "")
 {
objRow[conCaseCommonBase.VideoUrl] = objCaseCommonBaseEN.VideoUrl; //视频Url
 }
 if (objCaseCommonBaseEN.VideoPath !=  "")
 {
objRow[conCaseCommonBase.VideoPath] = objCaseCommonBaseEN.VideoPath; //视频目录
 }
 if (objCaseCommonBaseEN.ResErrMsg !=  "")
 {
objRow[conCaseCommonBase.ResErrMsg] = objCaseCommonBaseEN.ResErrMsg; //资源错误信息
 }
 if (objCaseCommonBaseEN.UpdDate !=  "")
 {
objRow[conCaseCommonBase.UpdDate] = objCaseCommonBaseEN.UpdDate; //修改日期
 }
 if (objCaseCommonBaseEN.UpdUserId !=  "")
 {
objRow[conCaseCommonBase.UpdUserId] = objCaseCommonBaseEN.UpdUserId; //修改用户Id
 }
 if (objCaseCommonBaseEN.Memo !=  "")
 {
objRow[conCaseCommonBase.Memo] = objCaseCommonBaseEN.Memo; //备注
 }
objDS.Tables[clsCaseCommonBaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCaseCommonBaseEN._CurrTabName);
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
 /// <param name = "objCaseCommonBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCaseCommonBaseEN objCaseCommonBaseEN)
{
 objCaseCommonBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCommonBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseCommonBaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCaseCommonBaseEN.IdCase !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdCase);
 var strIdCase = objCaseCommonBaseEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCase + "'");
 }
 
 if (objCaseCommonBaseEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseId);
 var strCaseId = objCaseCommonBaseEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseCommonBaseEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseName);
 var strCaseName = objCaseCommonBaseEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseCommonBaseEN.CaseText !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseText);
 var strCaseText = objCaseCommonBaseEN.CaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseText + "'");
 }
 
 if (objCaseCommonBaseEN.CaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseTheme);
 var strCaseTheme = objCaseCommonBaseEN.CaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseTheme + "'");
 }
 
 if (objCaseCommonBaseEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.FuncModuleId);
 var strFuncModuleId = objCaseCommonBaseEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseCommonBaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CourseChapterId);
 var strCourseChapterId = objCaseCommonBaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objCaseCommonBaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdCaseType);
 var strIdCaseType = objCaseCommonBaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objCaseCommonBaseEN.CaseDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseDate);
 var strCaseDate = objCaseCommonBaseEN.CaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseDate + "'");
 }
 
 if (objCaseCommonBaseEN.CaseTime !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseTime);
 var strCaseTime = objCaseCommonBaseEN.CaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseTime + "'");
 }
 
 if (objCaseCommonBaseEN.CaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseDateIn);
 var strCaseDateIn = objCaseCommonBaseEN.CaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseDateIn + "'");
 }
 
 if (objCaseCommonBaseEN.CaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseTimeIn);
 var strCaseTimeIn = objCaseCommonBaseEN.CaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseTimeIn + "'");
 }
 
 if (objCaseCommonBaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.OwnerId);
 var strOwnerId = objCaseCommonBaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseCommonBaseEN.IdStudyLevel  ==  "")
 {
 objCaseCommonBaseEN.IdStudyLevel = null;
 }
 if (objCaseCommonBaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdStudyLevel);
 var strIdStudyLevel = objCaseCommonBaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objCaseCommonBaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdTeachingPlan);
 var strIdTeachingPlan = objCaseCommonBaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objCaseCommonBaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdDiscipline);
 var strIdDiscipline = objCaseCommonBaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objCaseCommonBaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.BrowseCount);
 arrValueListForInsert.Add(objCaseCommonBaseEN.BrowseCount.ToString());
 }
 
 if (objCaseCommonBaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCaseCommonBaseEN.IdSenateGaugeVersion = null;
 }
 if (objCaseCommonBaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objCaseCommonBaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objCaseCommonBaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdTeachSkill);
 var strIdTeachSkill = objCaseCommonBaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objCaseCommonBaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseLevelId);
 var strCaseLevelId = objCaseCommonBaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objCaseCommonBaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.DocFile);
 var strDocFile = objCaseCommonBaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conCaseCommonBase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objCaseCommonBaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objCaseCommonBaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.WordCreateDate);
 var strWordCreateDate = objCaseCommonBaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conCaseCommonBase.IsVisible);
 arrValueListForInsert.Add("'" + (objCaseCommonBaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCaseCommonBase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objCaseCommonBaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objCaseCommonBaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdXzCollege);
 var strIdXzCollege = objCaseCommonBaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCaseCommonBaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdXzMajor);
 var strIdXzMajor = objCaseCommonBaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objCaseCommonBaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.ViewCount);
 arrValueListForInsert.Add(objCaseCommonBaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conCaseCommonBase.IsShow);
 arrValueListForInsert.Add("'" + (objCaseCommonBaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objCaseCommonBaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.DownloadNumber);
 arrValueListForInsert.Add(objCaseCommonBaseEN.DownloadNumber.ToString());
 }
 
 if (objCaseCommonBaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.FileIntegration);
 arrValueListForInsert.Add(objCaseCommonBaseEN.FileIntegration.ToString());
 }
 
 if (objCaseCommonBaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.LikeCount);
 arrValueListForInsert.Add(objCaseCommonBaseEN.LikeCount.ToString());
 }
 
 if (objCaseCommonBaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CollectionCount);
 arrValueListForInsert.Add(objCaseCommonBaseEN.CollectionCount.ToString());
 }
 
 if (objCaseCommonBaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.RecommendedDegreeId);
 var strRecommendedDegreeId = objCaseCommonBaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objCaseCommonBaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CourseId);
 var strCourseId = objCaseCommonBaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCaseCommonBaseEN.IdCaseType4FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdCaseType4FuncModuleId);
 var strIdCaseType4FuncModuleId = objCaseCommonBaseEN.IdCaseType4FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType4FuncModuleId + "'");
 }
 
 if (objCaseCommonBaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.ftpFileType);
 var strftpFileType = objCaseCommonBaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objCaseCommonBaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.VideoUrl);
 var strVideoUrl = objCaseCommonBaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objCaseCommonBaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.VideoPath);
 var strVideoPath = objCaseCommonBaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objCaseCommonBaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.ResErrMsg);
 var strResErrMsg = objCaseCommonBaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objCaseCommonBaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.UpdDate);
 var strUpdDate = objCaseCommonBaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseCommonBaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.UpdUserId);
 var strUpdUserId = objCaseCommonBaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseCommonBaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.Memo);
 var strMemo = objCaseCommonBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseCommonBase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCaseCommonBaseEN objCaseCommonBaseEN)
{
 objCaseCommonBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCommonBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseCommonBaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCaseCommonBaseEN.IdCase !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdCase);
 var strIdCase = objCaseCommonBaseEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCase + "'");
 }
 
 if (objCaseCommonBaseEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseId);
 var strCaseId = objCaseCommonBaseEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseCommonBaseEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseName);
 var strCaseName = objCaseCommonBaseEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseCommonBaseEN.CaseText !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseText);
 var strCaseText = objCaseCommonBaseEN.CaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseText + "'");
 }
 
 if (objCaseCommonBaseEN.CaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseTheme);
 var strCaseTheme = objCaseCommonBaseEN.CaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseTheme + "'");
 }
 
 if (objCaseCommonBaseEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.FuncModuleId);
 var strFuncModuleId = objCaseCommonBaseEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseCommonBaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CourseChapterId);
 var strCourseChapterId = objCaseCommonBaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objCaseCommonBaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdCaseType);
 var strIdCaseType = objCaseCommonBaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objCaseCommonBaseEN.CaseDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseDate);
 var strCaseDate = objCaseCommonBaseEN.CaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseDate + "'");
 }
 
 if (objCaseCommonBaseEN.CaseTime !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseTime);
 var strCaseTime = objCaseCommonBaseEN.CaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseTime + "'");
 }
 
 if (objCaseCommonBaseEN.CaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseDateIn);
 var strCaseDateIn = objCaseCommonBaseEN.CaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseDateIn + "'");
 }
 
 if (objCaseCommonBaseEN.CaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseTimeIn);
 var strCaseTimeIn = objCaseCommonBaseEN.CaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseTimeIn + "'");
 }
 
 if (objCaseCommonBaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.OwnerId);
 var strOwnerId = objCaseCommonBaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseCommonBaseEN.IdStudyLevel  ==  "")
 {
 objCaseCommonBaseEN.IdStudyLevel = null;
 }
 if (objCaseCommonBaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdStudyLevel);
 var strIdStudyLevel = objCaseCommonBaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objCaseCommonBaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdTeachingPlan);
 var strIdTeachingPlan = objCaseCommonBaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objCaseCommonBaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdDiscipline);
 var strIdDiscipline = objCaseCommonBaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objCaseCommonBaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.BrowseCount);
 arrValueListForInsert.Add(objCaseCommonBaseEN.BrowseCount.ToString());
 }
 
 if (objCaseCommonBaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCaseCommonBaseEN.IdSenateGaugeVersion = null;
 }
 if (objCaseCommonBaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objCaseCommonBaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objCaseCommonBaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdTeachSkill);
 var strIdTeachSkill = objCaseCommonBaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objCaseCommonBaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseLevelId);
 var strCaseLevelId = objCaseCommonBaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objCaseCommonBaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.DocFile);
 var strDocFile = objCaseCommonBaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conCaseCommonBase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objCaseCommonBaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objCaseCommonBaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.WordCreateDate);
 var strWordCreateDate = objCaseCommonBaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conCaseCommonBase.IsVisible);
 arrValueListForInsert.Add("'" + (objCaseCommonBaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCaseCommonBase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objCaseCommonBaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objCaseCommonBaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdXzCollege);
 var strIdXzCollege = objCaseCommonBaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCaseCommonBaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdXzMajor);
 var strIdXzMajor = objCaseCommonBaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objCaseCommonBaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.ViewCount);
 arrValueListForInsert.Add(objCaseCommonBaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conCaseCommonBase.IsShow);
 arrValueListForInsert.Add("'" + (objCaseCommonBaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objCaseCommonBaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.DownloadNumber);
 arrValueListForInsert.Add(objCaseCommonBaseEN.DownloadNumber.ToString());
 }
 
 if (objCaseCommonBaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.FileIntegration);
 arrValueListForInsert.Add(objCaseCommonBaseEN.FileIntegration.ToString());
 }
 
 if (objCaseCommonBaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.LikeCount);
 arrValueListForInsert.Add(objCaseCommonBaseEN.LikeCount.ToString());
 }
 
 if (objCaseCommonBaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CollectionCount);
 arrValueListForInsert.Add(objCaseCommonBaseEN.CollectionCount.ToString());
 }
 
 if (objCaseCommonBaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.RecommendedDegreeId);
 var strRecommendedDegreeId = objCaseCommonBaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objCaseCommonBaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CourseId);
 var strCourseId = objCaseCommonBaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCaseCommonBaseEN.IdCaseType4FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdCaseType4FuncModuleId);
 var strIdCaseType4FuncModuleId = objCaseCommonBaseEN.IdCaseType4FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType4FuncModuleId + "'");
 }
 
 if (objCaseCommonBaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.ftpFileType);
 var strftpFileType = objCaseCommonBaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objCaseCommonBaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.VideoUrl);
 var strVideoUrl = objCaseCommonBaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objCaseCommonBaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.VideoPath);
 var strVideoPath = objCaseCommonBaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objCaseCommonBaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.ResErrMsg);
 var strResErrMsg = objCaseCommonBaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objCaseCommonBaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.UpdDate);
 var strUpdDate = objCaseCommonBaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseCommonBaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.UpdUserId);
 var strUpdUserId = objCaseCommonBaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseCommonBaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.Memo);
 var strMemo = objCaseCommonBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseCommonBase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCaseCommonBaseEN.IdCase;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCaseCommonBaseEN objCaseCommonBaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCaseCommonBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCommonBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseCommonBaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCaseCommonBaseEN.IdCase !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdCase);
 var strIdCase = objCaseCommonBaseEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCase + "'");
 }
 
 if (objCaseCommonBaseEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseId);
 var strCaseId = objCaseCommonBaseEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseCommonBaseEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseName);
 var strCaseName = objCaseCommonBaseEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseCommonBaseEN.CaseText !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseText);
 var strCaseText = objCaseCommonBaseEN.CaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseText + "'");
 }
 
 if (objCaseCommonBaseEN.CaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseTheme);
 var strCaseTheme = objCaseCommonBaseEN.CaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseTheme + "'");
 }
 
 if (objCaseCommonBaseEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.FuncModuleId);
 var strFuncModuleId = objCaseCommonBaseEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseCommonBaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CourseChapterId);
 var strCourseChapterId = objCaseCommonBaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objCaseCommonBaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdCaseType);
 var strIdCaseType = objCaseCommonBaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objCaseCommonBaseEN.CaseDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseDate);
 var strCaseDate = objCaseCommonBaseEN.CaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseDate + "'");
 }
 
 if (objCaseCommonBaseEN.CaseTime !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseTime);
 var strCaseTime = objCaseCommonBaseEN.CaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseTime + "'");
 }
 
 if (objCaseCommonBaseEN.CaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseDateIn);
 var strCaseDateIn = objCaseCommonBaseEN.CaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseDateIn + "'");
 }
 
 if (objCaseCommonBaseEN.CaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseTimeIn);
 var strCaseTimeIn = objCaseCommonBaseEN.CaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseTimeIn + "'");
 }
 
 if (objCaseCommonBaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.OwnerId);
 var strOwnerId = objCaseCommonBaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseCommonBaseEN.IdStudyLevel  ==  "")
 {
 objCaseCommonBaseEN.IdStudyLevel = null;
 }
 if (objCaseCommonBaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdStudyLevel);
 var strIdStudyLevel = objCaseCommonBaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objCaseCommonBaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdTeachingPlan);
 var strIdTeachingPlan = objCaseCommonBaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objCaseCommonBaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdDiscipline);
 var strIdDiscipline = objCaseCommonBaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objCaseCommonBaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.BrowseCount);
 arrValueListForInsert.Add(objCaseCommonBaseEN.BrowseCount.ToString());
 }
 
 if (objCaseCommonBaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCaseCommonBaseEN.IdSenateGaugeVersion = null;
 }
 if (objCaseCommonBaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objCaseCommonBaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objCaseCommonBaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdTeachSkill);
 var strIdTeachSkill = objCaseCommonBaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objCaseCommonBaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseLevelId);
 var strCaseLevelId = objCaseCommonBaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objCaseCommonBaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.DocFile);
 var strDocFile = objCaseCommonBaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conCaseCommonBase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objCaseCommonBaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objCaseCommonBaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.WordCreateDate);
 var strWordCreateDate = objCaseCommonBaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conCaseCommonBase.IsVisible);
 arrValueListForInsert.Add("'" + (objCaseCommonBaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCaseCommonBase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objCaseCommonBaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objCaseCommonBaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdXzCollege);
 var strIdXzCollege = objCaseCommonBaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCaseCommonBaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdXzMajor);
 var strIdXzMajor = objCaseCommonBaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objCaseCommonBaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.ViewCount);
 arrValueListForInsert.Add(objCaseCommonBaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conCaseCommonBase.IsShow);
 arrValueListForInsert.Add("'" + (objCaseCommonBaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objCaseCommonBaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.DownloadNumber);
 arrValueListForInsert.Add(objCaseCommonBaseEN.DownloadNumber.ToString());
 }
 
 if (objCaseCommonBaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.FileIntegration);
 arrValueListForInsert.Add(objCaseCommonBaseEN.FileIntegration.ToString());
 }
 
 if (objCaseCommonBaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.LikeCount);
 arrValueListForInsert.Add(objCaseCommonBaseEN.LikeCount.ToString());
 }
 
 if (objCaseCommonBaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CollectionCount);
 arrValueListForInsert.Add(objCaseCommonBaseEN.CollectionCount.ToString());
 }
 
 if (objCaseCommonBaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.RecommendedDegreeId);
 var strRecommendedDegreeId = objCaseCommonBaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objCaseCommonBaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CourseId);
 var strCourseId = objCaseCommonBaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCaseCommonBaseEN.IdCaseType4FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdCaseType4FuncModuleId);
 var strIdCaseType4FuncModuleId = objCaseCommonBaseEN.IdCaseType4FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType4FuncModuleId + "'");
 }
 
 if (objCaseCommonBaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.ftpFileType);
 var strftpFileType = objCaseCommonBaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objCaseCommonBaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.VideoUrl);
 var strVideoUrl = objCaseCommonBaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objCaseCommonBaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.VideoPath);
 var strVideoPath = objCaseCommonBaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objCaseCommonBaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.ResErrMsg);
 var strResErrMsg = objCaseCommonBaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objCaseCommonBaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.UpdDate);
 var strUpdDate = objCaseCommonBaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseCommonBaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.UpdUserId);
 var strUpdUserId = objCaseCommonBaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseCommonBaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.Memo);
 var strMemo = objCaseCommonBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseCommonBase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCaseCommonBaseEN.IdCase;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCaseCommonBaseEN objCaseCommonBaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCaseCommonBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCommonBaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseCommonBaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCaseCommonBaseEN.IdCase !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdCase);
 var strIdCase = objCaseCommonBaseEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCase + "'");
 }
 
 if (objCaseCommonBaseEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseId);
 var strCaseId = objCaseCommonBaseEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseCommonBaseEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseName);
 var strCaseName = objCaseCommonBaseEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseCommonBaseEN.CaseText !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseText);
 var strCaseText = objCaseCommonBaseEN.CaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseText + "'");
 }
 
 if (objCaseCommonBaseEN.CaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseTheme);
 var strCaseTheme = objCaseCommonBaseEN.CaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseTheme + "'");
 }
 
 if (objCaseCommonBaseEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.FuncModuleId);
 var strFuncModuleId = objCaseCommonBaseEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseCommonBaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CourseChapterId);
 var strCourseChapterId = objCaseCommonBaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objCaseCommonBaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdCaseType);
 var strIdCaseType = objCaseCommonBaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objCaseCommonBaseEN.CaseDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseDate);
 var strCaseDate = objCaseCommonBaseEN.CaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseDate + "'");
 }
 
 if (objCaseCommonBaseEN.CaseTime !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseTime);
 var strCaseTime = objCaseCommonBaseEN.CaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseTime + "'");
 }
 
 if (objCaseCommonBaseEN.CaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseDateIn);
 var strCaseDateIn = objCaseCommonBaseEN.CaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseDateIn + "'");
 }
 
 if (objCaseCommonBaseEN.CaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseTimeIn);
 var strCaseTimeIn = objCaseCommonBaseEN.CaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseTimeIn + "'");
 }
 
 if (objCaseCommonBaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.OwnerId);
 var strOwnerId = objCaseCommonBaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseCommonBaseEN.IdStudyLevel  ==  "")
 {
 objCaseCommonBaseEN.IdStudyLevel = null;
 }
 if (objCaseCommonBaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdStudyLevel);
 var strIdStudyLevel = objCaseCommonBaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objCaseCommonBaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdTeachingPlan);
 var strIdTeachingPlan = objCaseCommonBaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objCaseCommonBaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdDiscipline);
 var strIdDiscipline = objCaseCommonBaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objCaseCommonBaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.BrowseCount);
 arrValueListForInsert.Add(objCaseCommonBaseEN.BrowseCount.ToString());
 }
 
 if (objCaseCommonBaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCaseCommonBaseEN.IdSenateGaugeVersion = null;
 }
 if (objCaseCommonBaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objCaseCommonBaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objCaseCommonBaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdTeachSkill);
 var strIdTeachSkill = objCaseCommonBaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objCaseCommonBaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CaseLevelId);
 var strCaseLevelId = objCaseCommonBaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objCaseCommonBaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.DocFile);
 var strDocFile = objCaseCommonBaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conCaseCommonBase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objCaseCommonBaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objCaseCommonBaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.WordCreateDate);
 var strWordCreateDate = objCaseCommonBaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conCaseCommonBase.IsVisible);
 arrValueListForInsert.Add("'" + (objCaseCommonBaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCaseCommonBase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objCaseCommonBaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objCaseCommonBaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdXzCollege);
 var strIdXzCollege = objCaseCommonBaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCaseCommonBaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdXzMajor);
 var strIdXzMajor = objCaseCommonBaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objCaseCommonBaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.ViewCount);
 arrValueListForInsert.Add(objCaseCommonBaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conCaseCommonBase.IsShow);
 arrValueListForInsert.Add("'" + (objCaseCommonBaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objCaseCommonBaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.DownloadNumber);
 arrValueListForInsert.Add(objCaseCommonBaseEN.DownloadNumber.ToString());
 }
 
 if (objCaseCommonBaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.FileIntegration);
 arrValueListForInsert.Add(objCaseCommonBaseEN.FileIntegration.ToString());
 }
 
 if (objCaseCommonBaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.LikeCount);
 arrValueListForInsert.Add(objCaseCommonBaseEN.LikeCount.ToString());
 }
 
 if (objCaseCommonBaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CollectionCount);
 arrValueListForInsert.Add(objCaseCommonBaseEN.CollectionCount.ToString());
 }
 
 if (objCaseCommonBaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.RecommendedDegreeId);
 var strRecommendedDegreeId = objCaseCommonBaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objCaseCommonBaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.CourseId);
 var strCourseId = objCaseCommonBaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCaseCommonBaseEN.IdCaseType4FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.IdCaseType4FuncModuleId);
 var strIdCaseType4FuncModuleId = objCaseCommonBaseEN.IdCaseType4FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType4FuncModuleId + "'");
 }
 
 if (objCaseCommonBaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.ftpFileType);
 var strftpFileType = objCaseCommonBaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objCaseCommonBaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.VideoUrl);
 var strVideoUrl = objCaseCommonBaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objCaseCommonBaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.VideoPath);
 var strVideoPath = objCaseCommonBaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objCaseCommonBaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.ResErrMsg);
 var strResErrMsg = objCaseCommonBaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objCaseCommonBaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.UpdDate);
 var strUpdDate = objCaseCommonBaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseCommonBaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.UpdUserId);
 var strUpdUserId = objCaseCommonBaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseCommonBaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseCommonBase.Memo);
 var strMemo = objCaseCommonBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseCommonBase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCaseCommonBases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
strSQL = "Select * from CaseCommonBase where IdCase = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CaseCommonBase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdCase = oRow[conCaseCommonBase.IdCase].ToString().Trim();
if (IsExist(strIdCase))
{
 string strResult = "关键字变量值为:" + string.Format("IdCase = {0}", strIdCase) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCaseCommonBaseEN._CurrTabName ].NewRow();
objRow[conCaseCommonBase.IdCase] = oRow[conCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objRow[conCaseCommonBase.CaseId] = oRow[conCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objRow[conCaseCommonBase.CaseName] = oRow[conCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objRow[conCaseCommonBase.CaseText] = oRow[conCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objRow[conCaseCommonBase.CaseTheme] = oRow[conCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objRow[conCaseCommonBase.FuncModuleId] = oRow[conCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objRow[conCaseCommonBase.CourseChapterId] = oRow[conCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objRow[conCaseCommonBase.IdCaseType] = oRow[conCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objRow[conCaseCommonBase.CaseDate] = oRow[conCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objRow[conCaseCommonBase.CaseTime] = oRow[conCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objRow[conCaseCommonBase.CaseDateIn] = oRow[conCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objRow[conCaseCommonBase.CaseTimeIn] = oRow[conCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objRow[conCaseCommonBase.OwnerId] = oRow[conCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objRow[conCaseCommonBase.IdStudyLevel] = oRow[conCaseCommonBase.IdStudyLevel].ToString().Trim(); //学段流水号
objRow[conCaseCommonBase.IdTeachingPlan] = oRow[conCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objRow[conCaseCommonBase.IdDiscipline] = oRow[conCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objRow[conCaseCommonBase.BrowseCount] = oRow[conCaseCommonBase.BrowseCount].ToString().Trim(); //浏览次数
objRow[conCaseCommonBase.IdSenateGaugeVersion] = oRow[conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objRow[conCaseCommonBase.IdTeachSkill] = oRow[conCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objRow[conCaseCommonBase.CaseLevelId] = oRow[conCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objRow[conCaseCommonBase.DocFile] = oRow[conCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objRow[conCaseCommonBase.IsNeedGeneWord] = oRow[conCaseCommonBase.IsNeedGeneWord].ToString().Trim(); //是否需要生成Word
objRow[conCaseCommonBase.WordCreateDate] = oRow[conCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objRow[conCaseCommonBase.IsVisible] = oRow[conCaseCommonBase.IsVisible].ToString().Trim(); //是否显示
objRow[conCaseCommonBase.IsDualVideo] = oRow[conCaseCommonBase.IsDualVideo].ToString().Trim(); //是否双视频
objRow[conCaseCommonBase.IdXzCollege] = oRow[conCaseCommonBase.IdXzCollege].ToString().Trim(); //学院流水号
objRow[conCaseCommonBase.IdXzMajor] = oRow[conCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objRow[conCaseCommonBase.ViewCount] = oRow[conCaseCommonBase.ViewCount].ToString().Trim(); //浏览量
objRow[conCaseCommonBase.IsShow] = oRow[conCaseCommonBase.IsShow].ToString().Trim(); //是否启用
objRow[conCaseCommonBase.DownloadNumber] = oRow[conCaseCommonBase.DownloadNumber].ToString().Trim(); //下载数目
objRow[conCaseCommonBase.FileIntegration] = oRow[conCaseCommonBase.FileIntegration].ToString().Trim(); //文件积分
objRow[conCaseCommonBase.LikeCount] = oRow[conCaseCommonBase.LikeCount].ToString().Trim(); //资源喜欢数量
objRow[conCaseCommonBase.CollectionCount] = oRow[conCaseCommonBase.CollectionCount].ToString().Trim(); //收藏数量
objRow[conCaseCommonBase.RecommendedDegreeId] = oRow[conCaseCommonBase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objRow[conCaseCommonBase.CourseId] = oRow[conCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objRow[conCaseCommonBase.IdCaseType4FuncModuleId] = oRow[conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(); //案例类型流水号4模块
objRow[conCaseCommonBase.ftpFileType] = oRow[conCaseCommonBase.ftpFileType].ToString().Trim(); //ftp文件类型
objRow[conCaseCommonBase.VideoUrl] = oRow[conCaseCommonBase.VideoUrl].ToString().Trim(); //视频Url
objRow[conCaseCommonBase.VideoPath] = oRow[conCaseCommonBase.VideoPath].ToString().Trim(); //视频目录
objRow[conCaseCommonBase.ResErrMsg] = oRow[conCaseCommonBase.ResErrMsg].ToString().Trim(); //资源错误信息
objRow[conCaseCommonBase.UpdDate] = oRow[conCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objRow[conCaseCommonBase.UpdUserId] = oRow[conCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conCaseCommonBase.Memo] = oRow[conCaseCommonBase.Memo].ToString().Trim(); //备注
 objDS.Tables[clsCaseCommonBaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCaseCommonBaseEN._CurrTabName);
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
 /// <param name = "objCaseCommonBaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCaseCommonBaseEN objCaseCommonBaseEN)
{
 objCaseCommonBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCommonBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseCommonBaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
strSQL = "Select * from CaseCommonBase where IdCase = " + "'"+ objCaseCommonBaseEN.IdCase+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCaseCommonBaseEN._CurrTabName);
if (objDS.Tables[clsCaseCommonBaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdCase = " + "'"+ objCaseCommonBaseEN.IdCase+"'");
return false;
}
objRow = objDS.Tables[clsCaseCommonBaseEN._CurrTabName].Rows[0];
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdCase))
 {
objRow[conCaseCommonBase.IdCase] = objCaseCommonBaseEN.IdCase; //案例流水号
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseId))
 {
objRow[conCaseCommonBase.CaseId] = objCaseCommonBaseEN.CaseId; //案例Id
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseName))
 {
objRow[conCaseCommonBase.CaseName] = objCaseCommonBaseEN.CaseName; //案例名称
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseText))
 {
objRow[conCaseCommonBase.CaseText] = objCaseCommonBaseEN.CaseText; //案例文本内容
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseTheme))
 {
objRow[conCaseCommonBase.CaseTheme] = objCaseCommonBaseEN.CaseTheme; //案例主题词
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.FuncModuleId))
 {
objRow[conCaseCommonBase.FuncModuleId] = objCaseCommonBaseEN.FuncModuleId; //功能模块Id
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CourseChapterId))
 {
objRow[conCaseCommonBase.CourseChapterId] = objCaseCommonBaseEN.CourseChapterId; //课程章节ID
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdCaseType))
 {
objRow[conCaseCommonBase.IdCaseType] = objCaseCommonBaseEN.IdCaseType; //案例类型流水号
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseDate))
 {
objRow[conCaseCommonBase.CaseDate] = objCaseCommonBaseEN.CaseDate; //案例建立日期
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseTime))
 {
objRow[conCaseCommonBase.CaseTime] = objCaseCommonBaseEN.CaseTime; //案例建立时间
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseDateIn))
 {
objRow[conCaseCommonBase.CaseDateIn] = objCaseCommonBaseEN.CaseDateIn; //案例入库日期
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseTimeIn))
 {
objRow[conCaseCommonBase.CaseTimeIn] = objCaseCommonBaseEN.CaseTimeIn; //案例入库时间
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.OwnerId))
 {
objRow[conCaseCommonBase.OwnerId] = objCaseCommonBaseEN.OwnerId; //拥有者Id
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdStudyLevel))
 {
objRow[conCaseCommonBase.IdStudyLevel] = objCaseCommonBaseEN.IdStudyLevel; //学段流水号
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdTeachingPlan))
 {
objRow[conCaseCommonBase.IdTeachingPlan] = objCaseCommonBaseEN.IdTeachingPlan; //教案流水号
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdDiscipline))
 {
objRow[conCaseCommonBase.IdDiscipline] = objCaseCommonBaseEN.IdDiscipline; //学科流水号
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.BrowseCount))
 {
objRow[conCaseCommonBase.BrowseCount] = objCaseCommonBaseEN.BrowseCount; //浏览次数
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdSenateGaugeVersion))
 {
objRow[conCaseCommonBase.IdSenateGaugeVersion] = objCaseCommonBaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdTeachSkill))
 {
objRow[conCaseCommonBase.IdTeachSkill] = objCaseCommonBaseEN.IdTeachSkill; //教学技能流水号
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseLevelId))
 {
objRow[conCaseCommonBase.CaseLevelId] = objCaseCommonBaseEN.CaseLevelId; //课例等级Id
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.DocFile))
 {
objRow[conCaseCommonBase.DocFile] = objCaseCommonBaseEN.DocFile; //生成的Word文件名
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsNeedGeneWord))
 {
objRow[conCaseCommonBase.IsNeedGeneWord] = objCaseCommonBaseEN.IsNeedGeneWord; //是否需要生成Word
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.WordCreateDate))
 {
objRow[conCaseCommonBase.WordCreateDate] = objCaseCommonBaseEN.WordCreateDate; //Word生成日期
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsVisible))
 {
objRow[conCaseCommonBase.IsVisible] = objCaseCommonBaseEN.IsVisible; //是否显示
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsDualVideo))
 {
objRow[conCaseCommonBase.IsDualVideo] = objCaseCommonBaseEN.IsDualVideo; //是否双视频
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdXzCollege))
 {
objRow[conCaseCommonBase.IdXzCollege] = objCaseCommonBaseEN.IdXzCollege; //学院流水号
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdXzMajor))
 {
objRow[conCaseCommonBase.IdXzMajor] = objCaseCommonBaseEN.IdXzMajor; //专业流水号
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.ViewCount))
 {
objRow[conCaseCommonBase.ViewCount] = objCaseCommonBaseEN.ViewCount; //浏览量
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsShow))
 {
objRow[conCaseCommonBase.IsShow] = objCaseCommonBaseEN.IsShow; //是否启用
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.DownloadNumber))
 {
objRow[conCaseCommonBase.DownloadNumber] = objCaseCommonBaseEN.DownloadNumber; //下载数目
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.FileIntegration))
 {
objRow[conCaseCommonBase.FileIntegration] = objCaseCommonBaseEN.FileIntegration; //文件积分
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.LikeCount))
 {
objRow[conCaseCommonBase.LikeCount] = objCaseCommonBaseEN.LikeCount; //资源喜欢数量
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CollectionCount))
 {
objRow[conCaseCommonBase.CollectionCount] = objCaseCommonBaseEN.CollectionCount; //收藏数量
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.RecommendedDegreeId))
 {
objRow[conCaseCommonBase.RecommendedDegreeId] = objCaseCommonBaseEN.RecommendedDegreeId; //推荐度Id
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CourseId))
 {
objRow[conCaseCommonBase.CourseId] = objCaseCommonBaseEN.CourseId; //课程Id
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdCaseType4FuncModuleId))
 {
objRow[conCaseCommonBase.IdCaseType4FuncModuleId] = objCaseCommonBaseEN.IdCaseType4FuncModuleId; //案例类型流水号4模块
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.ftpFileType))
 {
objRow[conCaseCommonBase.ftpFileType] = objCaseCommonBaseEN.ftpFileType; //ftp文件类型
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.VideoUrl))
 {
objRow[conCaseCommonBase.VideoUrl] = objCaseCommonBaseEN.VideoUrl; //视频Url
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.VideoPath))
 {
objRow[conCaseCommonBase.VideoPath] = objCaseCommonBaseEN.VideoPath; //视频目录
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.ResErrMsg))
 {
objRow[conCaseCommonBase.ResErrMsg] = objCaseCommonBaseEN.ResErrMsg; //资源错误信息
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.UpdDate))
 {
objRow[conCaseCommonBase.UpdDate] = objCaseCommonBaseEN.UpdDate; //修改日期
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.UpdUserId))
 {
objRow[conCaseCommonBase.UpdUserId] = objCaseCommonBaseEN.UpdUserId; //修改用户Id
 }
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.Memo))
 {
objRow[conCaseCommonBase.Memo] = objCaseCommonBaseEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsCaseCommonBaseEN._CurrTabName);
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
 /// <param name = "objCaseCommonBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCaseCommonBaseEN objCaseCommonBaseEN)
{
 objCaseCommonBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCommonBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseCommonBaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CaseCommonBase Set ");
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseId))
 {
 if (objCaseCommonBaseEN.CaseId !=  null)
 {
 var strCaseId = objCaseCommonBaseEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseId, conCaseCommonBase.CaseId); //案例Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseId); //案例Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseName))
 {
 if (objCaseCommonBaseEN.CaseName !=  null)
 {
 var strCaseName = objCaseCommonBaseEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName, conCaseCommonBase.CaseName); //案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseName); //案例名称
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseText))
 {
 if (objCaseCommonBaseEN.CaseText !=  null)
 {
 var strCaseText = objCaseCommonBaseEN.CaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseText, conCaseCommonBase.CaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseText); //案例文本内容
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseTheme))
 {
 if (objCaseCommonBaseEN.CaseTheme !=  null)
 {
 var strCaseTheme = objCaseCommonBaseEN.CaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseTheme, conCaseCommonBase.CaseTheme); //案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseTheme); //案例主题词
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.FuncModuleId))
 {
 if (objCaseCommonBaseEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseCommonBaseEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conCaseCommonBase.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.FuncModuleId); //功能模块Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CourseChapterId))
 {
 if (objCaseCommonBaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objCaseCommonBaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, conCaseCommonBase.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CourseChapterId); //课程章节ID
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdCaseType))
 {
 if (objCaseCommonBaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objCaseCommonBaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conCaseCommonBase.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdCaseType); //案例类型流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseDate))
 {
 if (objCaseCommonBaseEN.CaseDate !=  null)
 {
 var strCaseDate = objCaseCommonBaseEN.CaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseDate, conCaseCommonBase.CaseDate); //案例建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseDate); //案例建立日期
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseTime))
 {
 if (objCaseCommonBaseEN.CaseTime !=  null)
 {
 var strCaseTime = objCaseCommonBaseEN.CaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseTime, conCaseCommonBase.CaseTime); //案例建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseTime); //案例建立时间
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseDateIn))
 {
 if (objCaseCommonBaseEN.CaseDateIn !=  null)
 {
 var strCaseDateIn = objCaseCommonBaseEN.CaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseDateIn, conCaseCommonBase.CaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseDateIn); //案例入库日期
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseTimeIn))
 {
 if (objCaseCommonBaseEN.CaseTimeIn !=  null)
 {
 var strCaseTimeIn = objCaseCommonBaseEN.CaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseTimeIn, conCaseCommonBase.CaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseTimeIn); //案例入库时间
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.OwnerId))
 {
 if (objCaseCommonBaseEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseCommonBaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conCaseCommonBase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.OwnerId); //拥有者Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdStudyLevel))
 {
 if (objCaseCommonBaseEN.IdStudyLevel  ==  "")
 {
 objCaseCommonBaseEN.IdStudyLevel = null;
 }
 if (objCaseCommonBaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objCaseCommonBaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conCaseCommonBase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdTeachingPlan))
 {
 if (objCaseCommonBaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objCaseCommonBaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conCaseCommonBase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdDiscipline))
 {
 if (objCaseCommonBaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objCaseCommonBaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conCaseCommonBase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdDiscipline); //学科流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.BrowseCount))
 {
 if (objCaseCommonBaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.BrowseCount, conCaseCommonBase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.BrowseCount); //浏览次数
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdSenateGaugeVersion))
 {
 if (objCaseCommonBaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCaseCommonBaseEN.IdSenateGaugeVersion = null;
 }
 if (objCaseCommonBaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objCaseCommonBaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conCaseCommonBase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdTeachSkill))
 {
 if (objCaseCommonBaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objCaseCommonBaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conCaseCommonBase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseLevelId))
 {
 if (objCaseCommonBaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objCaseCommonBaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conCaseCommonBase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.DocFile))
 {
 if (objCaseCommonBaseEN.DocFile !=  null)
 {
 var strDocFile = objCaseCommonBaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conCaseCommonBase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.DocFile); //生成的Word文件名
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCaseCommonBaseEN.IsNeedGeneWord == true?"1":"0", conCaseCommonBase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.WordCreateDate))
 {
 if (objCaseCommonBaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objCaseCommonBaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conCaseCommonBase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCaseCommonBaseEN.IsVisible == true?"1":"0", conCaseCommonBase.IsVisible); //是否显示
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCaseCommonBaseEN.IsDualVideo == true?"1":"0", conCaseCommonBase.IsDualVideo); //是否双视频
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdXzCollege))
 {
 if (objCaseCommonBaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCaseCommonBaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conCaseCommonBase.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdXzCollege); //学院流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdXzMajor))
 {
 if (objCaseCommonBaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objCaseCommonBaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conCaseCommonBase.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdXzMajor); //专业流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.ViewCount))
 {
 if (objCaseCommonBaseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.ViewCount, conCaseCommonBase.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.ViewCount); //浏览量
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCaseCommonBaseEN.IsShow == true?"1":"0", conCaseCommonBase.IsShow); //是否启用
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.DownloadNumber))
 {
 if (objCaseCommonBaseEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.DownloadNumber, conCaseCommonBase.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.DownloadNumber); //下载数目
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.FileIntegration))
 {
 if (objCaseCommonBaseEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.FileIntegration, conCaseCommonBase.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.FileIntegration); //文件积分
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.LikeCount))
 {
 if (objCaseCommonBaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.LikeCount, conCaseCommonBase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CollectionCount))
 {
 if (objCaseCommonBaseEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.CollectionCount, conCaseCommonBase.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CollectionCount); //收藏数量
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.RecommendedDegreeId))
 {
 if (objCaseCommonBaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objCaseCommonBaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conCaseCommonBase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CourseId))
 {
 if (objCaseCommonBaseEN.CourseId !=  null)
 {
 var strCourseId = objCaseCommonBaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conCaseCommonBase.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CourseId); //课程Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdCaseType4FuncModuleId))
 {
 if (objCaseCommonBaseEN.IdCaseType4FuncModuleId !=  null)
 {
 var strIdCaseType4FuncModuleId = objCaseCommonBaseEN.IdCaseType4FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType4FuncModuleId, conCaseCommonBase.IdCaseType4FuncModuleId); //案例类型流水号4模块
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdCaseType4FuncModuleId); //案例类型流水号4模块
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.ftpFileType))
 {
 if (objCaseCommonBaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objCaseCommonBaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conCaseCommonBase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.VideoUrl))
 {
 if (objCaseCommonBaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objCaseCommonBaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conCaseCommonBase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.VideoUrl); //视频Url
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.VideoPath))
 {
 if (objCaseCommonBaseEN.VideoPath !=  null)
 {
 var strVideoPath = objCaseCommonBaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conCaseCommonBase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.VideoPath); //视频目录
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.ResErrMsg))
 {
 if (objCaseCommonBaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objCaseCommonBaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conCaseCommonBase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.UpdDate))
 {
 if (objCaseCommonBaseEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseCommonBaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCaseCommonBase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.UpdDate); //修改日期
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.UpdUserId))
 {
 if (objCaseCommonBaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseCommonBaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCaseCommonBase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.UpdUserId); //修改用户Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.Memo))
 {
 if (objCaseCommonBaseEN.Memo !=  null)
 {
 var strMemo = objCaseCommonBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCaseCommonBase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCase = '{0}'", objCaseCommonBaseEN.IdCase); 
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
 /// <param name = "objCaseCommonBaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCaseCommonBaseEN objCaseCommonBaseEN, string strCondition)
{
 objCaseCommonBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCommonBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseCommonBaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseCommonBase Set ");
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseId))
 {
 if (objCaseCommonBaseEN.CaseId !=  null)
 {
 var strCaseId = objCaseCommonBaseEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseId = '{0}',", strCaseId); //案例Id
 }
 else
 {
 sbSQL.Append(" CaseId = null,"); //案例Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseName))
 {
 if (objCaseCommonBaseEN.CaseName !=  null)
 {
 var strCaseName = objCaseCommonBaseEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName = '{0}',", strCaseName); //案例名称
 }
 else
 {
 sbSQL.Append(" CaseName = null,"); //案例名称
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseText))
 {
 if (objCaseCommonBaseEN.CaseText !=  null)
 {
 var strCaseText = objCaseCommonBaseEN.CaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseText = '{0}',", strCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" CaseText = null,"); //案例文本内容
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseTheme))
 {
 if (objCaseCommonBaseEN.CaseTheme !=  null)
 {
 var strCaseTheme = objCaseCommonBaseEN.CaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseTheme = '{0}',", strCaseTheme); //案例主题词
 }
 else
 {
 sbSQL.Append(" CaseTheme = null,"); //案例主题词
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.FuncModuleId))
 {
 if (objCaseCommonBaseEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseCommonBaseEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CourseChapterId))
 {
 if (objCaseCommonBaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objCaseCommonBaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdCaseType))
 {
 if (objCaseCommonBaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objCaseCommonBaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseDate))
 {
 if (objCaseCommonBaseEN.CaseDate !=  null)
 {
 var strCaseDate = objCaseCommonBaseEN.CaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseDate = '{0}',", strCaseDate); //案例建立日期
 }
 else
 {
 sbSQL.Append(" CaseDate = null,"); //案例建立日期
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseTime))
 {
 if (objCaseCommonBaseEN.CaseTime !=  null)
 {
 var strCaseTime = objCaseCommonBaseEN.CaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseTime = '{0}',", strCaseTime); //案例建立时间
 }
 else
 {
 sbSQL.Append(" CaseTime = null,"); //案例建立时间
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseDateIn))
 {
 if (objCaseCommonBaseEN.CaseDateIn !=  null)
 {
 var strCaseDateIn = objCaseCommonBaseEN.CaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseDateIn = '{0}',", strCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" CaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseTimeIn))
 {
 if (objCaseCommonBaseEN.CaseTimeIn !=  null)
 {
 var strCaseTimeIn = objCaseCommonBaseEN.CaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseTimeIn = '{0}',", strCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" CaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.OwnerId))
 {
 if (objCaseCommonBaseEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseCommonBaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdStudyLevel))
 {
 if (objCaseCommonBaseEN.IdStudyLevel  ==  "")
 {
 objCaseCommonBaseEN.IdStudyLevel = null;
 }
 if (objCaseCommonBaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objCaseCommonBaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdTeachingPlan))
 {
 if (objCaseCommonBaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objCaseCommonBaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdDiscipline))
 {
 if (objCaseCommonBaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objCaseCommonBaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.BrowseCount))
 {
 if (objCaseCommonBaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.BrowseCount, conCaseCommonBase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.BrowseCount); //浏览次数
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdSenateGaugeVersion))
 {
 if (objCaseCommonBaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCaseCommonBaseEN.IdSenateGaugeVersion = null;
 }
 if (objCaseCommonBaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objCaseCommonBaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdTeachSkill))
 {
 if (objCaseCommonBaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objCaseCommonBaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseLevelId))
 {
 if (objCaseCommonBaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objCaseCommonBaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.DocFile))
 {
 if (objCaseCommonBaseEN.DocFile !=  null)
 {
 var strDocFile = objCaseCommonBaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objCaseCommonBaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.WordCreateDate))
 {
 if (objCaseCommonBaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objCaseCommonBaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objCaseCommonBaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objCaseCommonBaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdXzCollege))
 {
 if (objCaseCommonBaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCaseCommonBaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdXzMajor))
 {
 if (objCaseCommonBaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objCaseCommonBaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.ViewCount))
 {
 if (objCaseCommonBaseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.ViewCount, conCaseCommonBase.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.ViewCount); //浏览量
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objCaseCommonBaseEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.DownloadNumber))
 {
 if (objCaseCommonBaseEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.DownloadNumber, conCaseCommonBase.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.DownloadNumber); //下载数目
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.FileIntegration))
 {
 if (objCaseCommonBaseEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.FileIntegration, conCaseCommonBase.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.FileIntegration); //文件积分
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.LikeCount))
 {
 if (objCaseCommonBaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.LikeCount, conCaseCommonBase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CollectionCount))
 {
 if (objCaseCommonBaseEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.CollectionCount, conCaseCommonBase.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CollectionCount); //收藏数量
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.RecommendedDegreeId))
 {
 if (objCaseCommonBaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objCaseCommonBaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CourseId))
 {
 if (objCaseCommonBaseEN.CourseId !=  null)
 {
 var strCourseId = objCaseCommonBaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdCaseType4FuncModuleId))
 {
 if (objCaseCommonBaseEN.IdCaseType4FuncModuleId !=  null)
 {
 var strIdCaseType4FuncModuleId = objCaseCommonBaseEN.IdCaseType4FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType4FuncModuleId = '{0}',", strIdCaseType4FuncModuleId); //案例类型流水号4模块
 }
 else
 {
 sbSQL.Append(" IdCaseType4FuncModuleId = null,"); //案例类型流水号4模块
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.ftpFileType))
 {
 if (objCaseCommonBaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objCaseCommonBaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.VideoUrl))
 {
 if (objCaseCommonBaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objCaseCommonBaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.VideoPath))
 {
 if (objCaseCommonBaseEN.VideoPath !=  null)
 {
 var strVideoPath = objCaseCommonBaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.ResErrMsg))
 {
 if (objCaseCommonBaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objCaseCommonBaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.UpdDate))
 {
 if (objCaseCommonBaseEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseCommonBaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.UpdUserId))
 {
 if (objCaseCommonBaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseCommonBaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.Memo))
 {
 if (objCaseCommonBaseEN.Memo !=  null)
 {
 var strMemo = objCaseCommonBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCaseCommonBaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCaseCommonBaseEN objCaseCommonBaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCaseCommonBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCommonBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseCommonBaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseCommonBase Set ");
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseId))
 {
 if (objCaseCommonBaseEN.CaseId !=  null)
 {
 var strCaseId = objCaseCommonBaseEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseId = '{0}',", strCaseId); //案例Id
 }
 else
 {
 sbSQL.Append(" CaseId = null,"); //案例Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseName))
 {
 if (objCaseCommonBaseEN.CaseName !=  null)
 {
 var strCaseName = objCaseCommonBaseEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName = '{0}',", strCaseName); //案例名称
 }
 else
 {
 sbSQL.Append(" CaseName = null,"); //案例名称
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseText))
 {
 if (objCaseCommonBaseEN.CaseText !=  null)
 {
 var strCaseText = objCaseCommonBaseEN.CaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseText = '{0}',", strCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" CaseText = null,"); //案例文本内容
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseTheme))
 {
 if (objCaseCommonBaseEN.CaseTheme !=  null)
 {
 var strCaseTheme = objCaseCommonBaseEN.CaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseTheme = '{0}',", strCaseTheme); //案例主题词
 }
 else
 {
 sbSQL.Append(" CaseTheme = null,"); //案例主题词
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.FuncModuleId))
 {
 if (objCaseCommonBaseEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseCommonBaseEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CourseChapterId))
 {
 if (objCaseCommonBaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objCaseCommonBaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdCaseType))
 {
 if (objCaseCommonBaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objCaseCommonBaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseDate))
 {
 if (objCaseCommonBaseEN.CaseDate !=  null)
 {
 var strCaseDate = objCaseCommonBaseEN.CaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseDate = '{0}',", strCaseDate); //案例建立日期
 }
 else
 {
 sbSQL.Append(" CaseDate = null,"); //案例建立日期
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseTime))
 {
 if (objCaseCommonBaseEN.CaseTime !=  null)
 {
 var strCaseTime = objCaseCommonBaseEN.CaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseTime = '{0}',", strCaseTime); //案例建立时间
 }
 else
 {
 sbSQL.Append(" CaseTime = null,"); //案例建立时间
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseDateIn))
 {
 if (objCaseCommonBaseEN.CaseDateIn !=  null)
 {
 var strCaseDateIn = objCaseCommonBaseEN.CaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseDateIn = '{0}',", strCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" CaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseTimeIn))
 {
 if (objCaseCommonBaseEN.CaseTimeIn !=  null)
 {
 var strCaseTimeIn = objCaseCommonBaseEN.CaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseTimeIn = '{0}',", strCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" CaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.OwnerId))
 {
 if (objCaseCommonBaseEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseCommonBaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdStudyLevel))
 {
 if (objCaseCommonBaseEN.IdStudyLevel  ==  "")
 {
 objCaseCommonBaseEN.IdStudyLevel = null;
 }
 if (objCaseCommonBaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objCaseCommonBaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdTeachingPlan))
 {
 if (objCaseCommonBaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objCaseCommonBaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdDiscipline))
 {
 if (objCaseCommonBaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objCaseCommonBaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.BrowseCount))
 {
 if (objCaseCommonBaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.BrowseCount, conCaseCommonBase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.BrowseCount); //浏览次数
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdSenateGaugeVersion))
 {
 if (objCaseCommonBaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCaseCommonBaseEN.IdSenateGaugeVersion = null;
 }
 if (objCaseCommonBaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objCaseCommonBaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdTeachSkill))
 {
 if (objCaseCommonBaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objCaseCommonBaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseLevelId))
 {
 if (objCaseCommonBaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objCaseCommonBaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.DocFile))
 {
 if (objCaseCommonBaseEN.DocFile !=  null)
 {
 var strDocFile = objCaseCommonBaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objCaseCommonBaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.WordCreateDate))
 {
 if (objCaseCommonBaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objCaseCommonBaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objCaseCommonBaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objCaseCommonBaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdXzCollege))
 {
 if (objCaseCommonBaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCaseCommonBaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdXzMajor))
 {
 if (objCaseCommonBaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objCaseCommonBaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.ViewCount))
 {
 if (objCaseCommonBaseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.ViewCount, conCaseCommonBase.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.ViewCount); //浏览量
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objCaseCommonBaseEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.DownloadNumber))
 {
 if (objCaseCommonBaseEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.DownloadNumber, conCaseCommonBase.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.DownloadNumber); //下载数目
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.FileIntegration))
 {
 if (objCaseCommonBaseEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.FileIntegration, conCaseCommonBase.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.FileIntegration); //文件积分
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.LikeCount))
 {
 if (objCaseCommonBaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.LikeCount, conCaseCommonBase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CollectionCount))
 {
 if (objCaseCommonBaseEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.CollectionCount, conCaseCommonBase.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CollectionCount); //收藏数量
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.RecommendedDegreeId))
 {
 if (objCaseCommonBaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objCaseCommonBaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CourseId))
 {
 if (objCaseCommonBaseEN.CourseId !=  null)
 {
 var strCourseId = objCaseCommonBaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdCaseType4FuncModuleId))
 {
 if (objCaseCommonBaseEN.IdCaseType4FuncModuleId !=  null)
 {
 var strIdCaseType4FuncModuleId = objCaseCommonBaseEN.IdCaseType4FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType4FuncModuleId = '{0}',", strIdCaseType4FuncModuleId); //案例类型流水号4模块
 }
 else
 {
 sbSQL.Append(" IdCaseType4FuncModuleId = null,"); //案例类型流水号4模块
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.ftpFileType))
 {
 if (objCaseCommonBaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objCaseCommonBaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.VideoUrl))
 {
 if (objCaseCommonBaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objCaseCommonBaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.VideoPath))
 {
 if (objCaseCommonBaseEN.VideoPath !=  null)
 {
 var strVideoPath = objCaseCommonBaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.ResErrMsg))
 {
 if (objCaseCommonBaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objCaseCommonBaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.UpdDate))
 {
 if (objCaseCommonBaseEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseCommonBaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.UpdUserId))
 {
 if (objCaseCommonBaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseCommonBaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.Memo))
 {
 if (objCaseCommonBaseEN.Memo !=  null)
 {
 var strMemo = objCaseCommonBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCaseCommonBaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCaseCommonBaseEN objCaseCommonBaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCaseCommonBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCommonBaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseCommonBaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseCommonBase Set ");
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseId))
 {
 if (objCaseCommonBaseEN.CaseId !=  null)
 {
 var strCaseId = objCaseCommonBaseEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseId, conCaseCommonBase.CaseId); //案例Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseId); //案例Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseName))
 {
 if (objCaseCommonBaseEN.CaseName !=  null)
 {
 var strCaseName = objCaseCommonBaseEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName, conCaseCommonBase.CaseName); //案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseName); //案例名称
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseText))
 {
 if (objCaseCommonBaseEN.CaseText !=  null)
 {
 var strCaseText = objCaseCommonBaseEN.CaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseText, conCaseCommonBase.CaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseText); //案例文本内容
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseTheme))
 {
 if (objCaseCommonBaseEN.CaseTheme !=  null)
 {
 var strCaseTheme = objCaseCommonBaseEN.CaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseTheme, conCaseCommonBase.CaseTheme); //案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseTheme); //案例主题词
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.FuncModuleId))
 {
 if (objCaseCommonBaseEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseCommonBaseEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conCaseCommonBase.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.FuncModuleId); //功能模块Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CourseChapterId))
 {
 if (objCaseCommonBaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objCaseCommonBaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, conCaseCommonBase.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CourseChapterId); //课程章节ID
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdCaseType))
 {
 if (objCaseCommonBaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objCaseCommonBaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conCaseCommonBase.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdCaseType); //案例类型流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseDate))
 {
 if (objCaseCommonBaseEN.CaseDate !=  null)
 {
 var strCaseDate = objCaseCommonBaseEN.CaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseDate, conCaseCommonBase.CaseDate); //案例建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseDate); //案例建立日期
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseTime))
 {
 if (objCaseCommonBaseEN.CaseTime !=  null)
 {
 var strCaseTime = objCaseCommonBaseEN.CaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseTime, conCaseCommonBase.CaseTime); //案例建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseTime); //案例建立时间
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseDateIn))
 {
 if (objCaseCommonBaseEN.CaseDateIn !=  null)
 {
 var strCaseDateIn = objCaseCommonBaseEN.CaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseDateIn, conCaseCommonBase.CaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseDateIn); //案例入库日期
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseTimeIn))
 {
 if (objCaseCommonBaseEN.CaseTimeIn !=  null)
 {
 var strCaseTimeIn = objCaseCommonBaseEN.CaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseTimeIn, conCaseCommonBase.CaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseTimeIn); //案例入库时间
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.OwnerId))
 {
 if (objCaseCommonBaseEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseCommonBaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conCaseCommonBase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.OwnerId); //拥有者Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdStudyLevel))
 {
 if (objCaseCommonBaseEN.IdStudyLevel  ==  "")
 {
 objCaseCommonBaseEN.IdStudyLevel = null;
 }
 if (objCaseCommonBaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objCaseCommonBaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conCaseCommonBase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdTeachingPlan))
 {
 if (objCaseCommonBaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objCaseCommonBaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conCaseCommonBase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdDiscipline))
 {
 if (objCaseCommonBaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objCaseCommonBaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conCaseCommonBase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdDiscipline); //学科流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.BrowseCount))
 {
 if (objCaseCommonBaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.BrowseCount, conCaseCommonBase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.BrowseCount); //浏览次数
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdSenateGaugeVersion))
 {
 if (objCaseCommonBaseEN.IdSenateGaugeVersion  ==  "")
 {
 objCaseCommonBaseEN.IdSenateGaugeVersion = null;
 }
 if (objCaseCommonBaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objCaseCommonBaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conCaseCommonBase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdTeachSkill))
 {
 if (objCaseCommonBaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objCaseCommonBaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conCaseCommonBase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CaseLevelId))
 {
 if (objCaseCommonBaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objCaseCommonBaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conCaseCommonBase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.DocFile))
 {
 if (objCaseCommonBaseEN.DocFile !=  null)
 {
 var strDocFile = objCaseCommonBaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conCaseCommonBase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.DocFile); //生成的Word文件名
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCaseCommonBaseEN.IsNeedGeneWord == true?"1":"0", conCaseCommonBase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.WordCreateDate))
 {
 if (objCaseCommonBaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objCaseCommonBaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conCaseCommonBase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCaseCommonBaseEN.IsVisible == true?"1":"0", conCaseCommonBase.IsVisible); //是否显示
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCaseCommonBaseEN.IsDualVideo == true?"1":"0", conCaseCommonBase.IsDualVideo); //是否双视频
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdXzCollege))
 {
 if (objCaseCommonBaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCaseCommonBaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conCaseCommonBase.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdXzCollege); //学院流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdXzMajor))
 {
 if (objCaseCommonBaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objCaseCommonBaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conCaseCommonBase.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdXzMajor); //专业流水号
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.ViewCount))
 {
 if (objCaseCommonBaseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.ViewCount, conCaseCommonBase.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.ViewCount); //浏览量
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCaseCommonBaseEN.IsShow == true?"1":"0", conCaseCommonBase.IsShow); //是否启用
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.DownloadNumber))
 {
 if (objCaseCommonBaseEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.DownloadNumber, conCaseCommonBase.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.DownloadNumber); //下载数目
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.FileIntegration))
 {
 if (objCaseCommonBaseEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.FileIntegration, conCaseCommonBase.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.FileIntegration); //文件积分
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.LikeCount))
 {
 if (objCaseCommonBaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.LikeCount, conCaseCommonBase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CollectionCount))
 {
 if (objCaseCommonBaseEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCommonBaseEN.CollectionCount, conCaseCommonBase.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CollectionCount); //收藏数量
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.RecommendedDegreeId))
 {
 if (objCaseCommonBaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objCaseCommonBaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conCaseCommonBase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.CourseId))
 {
 if (objCaseCommonBaseEN.CourseId !=  null)
 {
 var strCourseId = objCaseCommonBaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conCaseCommonBase.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.CourseId); //课程Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.IdCaseType4FuncModuleId))
 {
 if (objCaseCommonBaseEN.IdCaseType4FuncModuleId !=  null)
 {
 var strIdCaseType4FuncModuleId = objCaseCommonBaseEN.IdCaseType4FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType4FuncModuleId, conCaseCommonBase.IdCaseType4FuncModuleId); //案例类型流水号4模块
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.IdCaseType4FuncModuleId); //案例类型流水号4模块
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.ftpFileType))
 {
 if (objCaseCommonBaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objCaseCommonBaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conCaseCommonBase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.VideoUrl))
 {
 if (objCaseCommonBaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objCaseCommonBaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conCaseCommonBase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.VideoUrl); //视频Url
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.VideoPath))
 {
 if (objCaseCommonBaseEN.VideoPath !=  null)
 {
 var strVideoPath = objCaseCommonBaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conCaseCommonBase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.VideoPath); //视频目录
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.ResErrMsg))
 {
 if (objCaseCommonBaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objCaseCommonBaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conCaseCommonBase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.UpdDate))
 {
 if (objCaseCommonBaseEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseCommonBaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCaseCommonBase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.UpdDate); //修改日期
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.UpdUserId))
 {
 if (objCaseCommonBaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseCommonBaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCaseCommonBase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.UpdUserId); //修改用户Id
 }
 }
 
 if (objCaseCommonBaseEN.IsUpdated(conCaseCommonBase.Memo))
 {
 if (objCaseCommonBaseEN.Memo !=  null)
 {
 var strMemo = objCaseCommonBaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCaseCommonBase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCommonBase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCase = '{0}'", objCaseCommonBaseEN.IdCase); 
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
 /// <param name = "strIdCase">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdCase) 
{
CheckPrimaryKey(strIdCase);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdCase,
};
 objSQL.ExecSP("CaseCommonBase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdCase);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
//删除CaseCommonBase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseCommonBase where IdCase = " + "'"+ strIdCase+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCaseCommonBase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
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
//删除CaseCommonBase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseCommonBase where IdCase in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdCase) 
{
CheckPrimaryKey(strIdCase);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
//删除CaseCommonBase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseCommonBase where IdCase = " + "'"+ strIdCase+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCaseCommonBase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCaseCommonBaseDA: DelCaseCommonBase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CaseCommonBase where " + strCondition ;
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
public bool DelCaseCommonBaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCaseCommonBaseDA: DelCaseCommonBaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CaseCommonBase where " + strCondition ;
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
 /// <param name = "objCaseCommonBaseENS">源对象</param>
 /// <param name = "objCaseCommonBaseENT">目标对象</param>
public void CopyTo(clsCaseCommonBaseEN objCaseCommonBaseENS, clsCaseCommonBaseEN objCaseCommonBaseENT)
{
objCaseCommonBaseENT.IdCase = objCaseCommonBaseENS.IdCase; //案例流水号
objCaseCommonBaseENT.CaseId = objCaseCommonBaseENS.CaseId; //案例Id
objCaseCommonBaseENT.CaseName = objCaseCommonBaseENS.CaseName; //案例名称
objCaseCommonBaseENT.CaseText = objCaseCommonBaseENS.CaseText; //案例文本内容
objCaseCommonBaseENT.CaseTheme = objCaseCommonBaseENS.CaseTheme; //案例主题词
objCaseCommonBaseENT.FuncModuleId = objCaseCommonBaseENS.FuncModuleId; //功能模块Id
objCaseCommonBaseENT.CourseChapterId = objCaseCommonBaseENS.CourseChapterId; //课程章节ID
objCaseCommonBaseENT.IdCaseType = objCaseCommonBaseENS.IdCaseType; //案例类型流水号
objCaseCommonBaseENT.CaseDate = objCaseCommonBaseENS.CaseDate; //案例建立日期
objCaseCommonBaseENT.CaseTime = objCaseCommonBaseENS.CaseTime; //案例建立时间
objCaseCommonBaseENT.CaseDateIn = objCaseCommonBaseENS.CaseDateIn; //案例入库日期
objCaseCommonBaseENT.CaseTimeIn = objCaseCommonBaseENS.CaseTimeIn; //案例入库时间
objCaseCommonBaseENT.OwnerId = objCaseCommonBaseENS.OwnerId; //拥有者Id
objCaseCommonBaseENT.IdStudyLevel = objCaseCommonBaseENS.IdStudyLevel; //学段流水号
objCaseCommonBaseENT.IdTeachingPlan = objCaseCommonBaseENS.IdTeachingPlan; //教案流水号
objCaseCommonBaseENT.IdDiscipline = objCaseCommonBaseENS.IdDiscipline; //学科流水号
objCaseCommonBaseENT.BrowseCount = objCaseCommonBaseENS.BrowseCount; //浏览次数
objCaseCommonBaseENT.IdSenateGaugeVersion = objCaseCommonBaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objCaseCommonBaseENT.IdTeachSkill = objCaseCommonBaseENS.IdTeachSkill; //教学技能流水号
objCaseCommonBaseENT.CaseLevelId = objCaseCommonBaseENS.CaseLevelId; //课例等级Id
objCaseCommonBaseENT.DocFile = objCaseCommonBaseENS.DocFile; //生成的Word文件名
objCaseCommonBaseENT.IsNeedGeneWord = objCaseCommonBaseENS.IsNeedGeneWord; //是否需要生成Word
objCaseCommonBaseENT.WordCreateDate = objCaseCommonBaseENS.WordCreateDate; //Word生成日期
objCaseCommonBaseENT.IsVisible = objCaseCommonBaseENS.IsVisible; //是否显示
objCaseCommonBaseENT.IsDualVideo = objCaseCommonBaseENS.IsDualVideo; //是否双视频
objCaseCommonBaseENT.IdXzCollege = objCaseCommonBaseENS.IdXzCollege; //学院流水号
objCaseCommonBaseENT.IdXzMajor = objCaseCommonBaseENS.IdXzMajor; //专业流水号
objCaseCommonBaseENT.ViewCount = objCaseCommonBaseENS.ViewCount; //浏览量
objCaseCommonBaseENT.IsShow = objCaseCommonBaseENS.IsShow; //是否启用
objCaseCommonBaseENT.DownloadNumber = objCaseCommonBaseENS.DownloadNumber; //下载数目
objCaseCommonBaseENT.FileIntegration = objCaseCommonBaseENS.FileIntegration; //文件积分
objCaseCommonBaseENT.LikeCount = objCaseCommonBaseENS.LikeCount; //资源喜欢数量
objCaseCommonBaseENT.CollectionCount = objCaseCommonBaseENS.CollectionCount; //收藏数量
objCaseCommonBaseENT.RecommendedDegreeId = objCaseCommonBaseENS.RecommendedDegreeId; //推荐度Id
objCaseCommonBaseENT.CourseId = objCaseCommonBaseENS.CourseId; //课程Id
objCaseCommonBaseENT.IdCaseType4FuncModuleId = objCaseCommonBaseENS.IdCaseType4FuncModuleId; //案例类型流水号4模块
objCaseCommonBaseENT.ftpFileType = objCaseCommonBaseENS.ftpFileType; //ftp文件类型
objCaseCommonBaseENT.VideoUrl = objCaseCommonBaseENS.VideoUrl; //视频Url
objCaseCommonBaseENT.VideoPath = objCaseCommonBaseENS.VideoPath; //视频目录
objCaseCommonBaseENT.ResErrMsg = objCaseCommonBaseENS.ResErrMsg; //资源错误信息
objCaseCommonBaseENT.UpdDate = objCaseCommonBaseENS.UpdDate; //修改日期
objCaseCommonBaseENT.UpdUserId = objCaseCommonBaseENS.UpdUserId; //修改用户Id
objCaseCommonBaseENT.Memo = objCaseCommonBaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCaseCommonBaseEN objCaseCommonBaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCaseCommonBaseEN.CaseId, conCaseCommonBase.CaseId);
clsCheckSql.CheckFieldNotNull(objCaseCommonBaseEN.CaseName, conCaseCommonBase.CaseName);
clsCheckSql.CheckFieldNotNull(objCaseCommonBaseEN.FuncModuleId, conCaseCommonBase.FuncModuleId);
clsCheckSql.CheckFieldNotNull(objCaseCommonBaseEN.CourseChapterId, conCaseCommonBase.CourseChapterId);
clsCheckSql.CheckFieldNotNull(objCaseCommonBaseEN.OwnerId, conCaseCommonBase.OwnerId);
clsCheckSql.CheckFieldNotNull(objCaseCommonBaseEN.IdDiscipline, conCaseCommonBase.IdDiscipline);
clsCheckSql.CheckFieldNotNull(objCaseCommonBaseEN.IdTeachSkill, conCaseCommonBase.IdTeachSkill);
clsCheckSql.CheckFieldNotNull(objCaseCommonBaseEN.IdXzCollege, conCaseCommonBase.IdXzCollege);
clsCheckSql.CheckFieldNotNull(objCaseCommonBaseEN.IdXzMajor, conCaseCommonBase.IdXzMajor);
clsCheckSql.CheckFieldNotNull(objCaseCommonBaseEN.RecommendedDegreeId, conCaseCommonBase.RecommendedDegreeId);
clsCheckSql.CheckFieldNotNull(objCaseCommonBaseEN.CourseId, conCaseCommonBase.CourseId);
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdCase, 8, conCaseCommonBase.IdCase);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseId, 8, conCaseCommonBase.CaseId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseName, 100, conCaseCommonBase.CaseName);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseText, 8000, conCaseCommonBase.CaseText);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseTheme, 200, conCaseCommonBase.CaseTheme);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.FuncModuleId, 4, conCaseCommonBase.FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CourseChapterId, 8, conCaseCommonBase.CourseChapterId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdCaseType, 4, conCaseCommonBase.IdCaseType);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseDate, 8, conCaseCommonBase.CaseDate);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseTime, 6, conCaseCommonBase.CaseTime);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseDateIn, 8, conCaseCommonBase.CaseDateIn);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseTimeIn, 6, conCaseCommonBase.CaseTimeIn);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.OwnerId, 20, conCaseCommonBase.OwnerId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdStudyLevel, 4, conCaseCommonBase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdTeachingPlan, 8, conCaseCommonBase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdDiscipline, 4, conCaseCommonBase.IdDiscipline);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdSenateGaugeVersion, 4, conCaseCommonBase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdTeachSkill, 8, conCaseCommonBase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseLevelId, 2, conCaseCommonBase.CaseLevelId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.DocFile, 200, conCaseCommonBase.DocFile);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.WordCreateDate, 14, conCaseCommonBase.WordCreateDate);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdXzCollege, 4, conCaseCommonBase.IdXzCollege);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdXzMajor, 8, conCaseCommonBase.IdXzMajor);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.RecommendedDegreeId, 2, conCaseCommonBase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CourseId, 8, conCaseCommonBase.CourseId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdCaseType4FuncModuleId, 4, conCaseCommonBase.IdCaseType4FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.ftpFileType, 30, conCaseCommonBase.ftpFileType);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.VideoUrl, 1000, conCaseCommonBase.VideoUrl);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.VideoPath, 1000, conCaseCommonBase.VideoPath);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.ResErrMsg, 30, conCaseCommonBase.ResErrMsg);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.UpdDate, 20, conCaseCommonBase.UpdDate);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.UpdUserId, 20, conCaseCommonBase.UpdUserId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.Memo, 1000, conCaseCommonBase.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objCaseCommonBaseEN.IdStudyLevel, 4, conCaseCommonBase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objCaseCommonBaseEN.IdSenateGaugeVersion, 4, conCaseCommonBase.IdSenateGaugeVersion);
 objCaseCommonBaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCaseCommonBaseEN objCaseCommonBaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseId, 8, conCaseCommonBase.CaseId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseName, 100, conCaseCommonBase.CaseName);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseText, 8000, conCaseCommonBase.CaseText);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseTheme, 200, conCaseCommonBase.CaseTheme);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.FuncModuleId, 4, conCaseCommonBase.FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CourseChapterId, 8, conCaseCommonBase.CourseChapterId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdCaseType, 4, conCaseCommonBase.IdCaseType);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseDate, 8, conCaseCommonBase.CaseDate);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseTime, 6, conCaseCommonBase.CaseTime);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseDateIn, 8, conCaseCommonBase.CaseDateIn);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseTimeIn, 6, conCaseCommonBase.CaseTimeIn);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.OwnerId, 20, conCaseCommonBase.OwnerId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdStudyLevel, 4, conCaseCommonBase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdTeachingPlan, 8, conCaseCommonBase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdDiscipline, 4, conCaseCommonBase.IdDiscipline);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdSenateGaugeVersion, 4, conCaseCommonBase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdTeachSkill, 8, conCaseCommonBase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseLevelId, 2, conCaseCommonBase.CaseLevelId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.DocFile, 200, conCaseCommonBase.DocFile);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.WordCreateDate, 14, conCaseCommonBase.WordCreateDate);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdXzCollege, 4, conCaseCommonBase.IdXzCollege);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdXzMajor, 8, conCaseCommonBase.IdXzMajor);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.RecommendedDegreeId, 2, conCaseCommonBase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CourseId, 8, conCaseCommonBase.CourseId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdCaseType4FuncModuleId, 4, conCaseCommonBase.IdCaseType4FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.ftpFileType, 30, conCaseCommonBase.ftpFileType);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.VideoUrl, 1000, conCaseCommonBase.VideoUrl);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.VideoPath, 1000, conCaseCommonBase.VideoPath);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.ResErrMsg, 30, conCaseCommonBase.ResErrMsg);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.UpdDate, 20, conCaseCommonBase.UpdDate);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.UpdUserId, 20, conCaseCommonBase.UpdUserId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.Memo, 1000, conCaseCommonBase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCaseCommonBaseEN.IdStudyLevel, 4, conCaseCommonBase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objCaseCommonBaseEN.IdSenateGaugeVersion, 4, conCaseCommonBase.IdSenateGaugeVersion);
 objCaseCommonBaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCaseCommonBaseEN objCaseCommonBaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdCase, 8, conCaseCommonBase.IdCase);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseId, 8, conCaseCommonBase.CaseId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseName, 100, conCaseCommonBase.CaseName);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseText, 8000, conCaseCommonBase.CaseText);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseTheme, 200, conCaseCommonBase.CaseTheme);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.FuncModuleId, 4, conCaseCommonBase.FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CourseChapterId, 8, conCaseCommonBase.CourseChapterId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdCaseType, 4, conCaseCommonBase.IdCaseType);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseDate, 8, conCaseCommonBase.CaseDate);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseTime, 6, conCaseCommonBase.CaseTime);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseDateIn, 8, conCaseCommonBase.CaseDateIn);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseTimeIn, 6, conCaseCommonBase.CaseTimeIn);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.OwnerId, 20, conCaseCommonBase.OwnerId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdStudyLevel, 4, conCaseCommonBase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdTeachingPlan, 8, conCaseCommonBase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdDiscipline, 4, conCaseCommonBase.IdDiscipline);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdSenateGaugeVersion, 4, conCaseCommonBase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdTeachSkill, 8, conCaseCommonBase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CaseLevelId, 2, conCaseCommonBase.CaseLevelId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.DocFile, 200, conCaseCommonBase.DocFile);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.WordCreateDate, 14, conCaseCommonBase.WordCreateDate);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdXzCollege, 4, conCaseCommonBase.IdXzCollege);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdXzMajor, 8, conCaseCommonBase.IdXzMajor);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.RecommendedDegreeId, 2, conCaseCommonBase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.CourseId, 8, conCaseCommonBase.CourseId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.IdCaseType4FuncModuleId, 4, conCaseCommonBase.IdCaseType4FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.ftpFileType, 30, conCaseCommonBase.ftpFileType);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.VideoUrl, 1000, conCaseCommonBase.VideoUrl);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.VideoPath, 1000, conCaseCommonBase.VideoPath);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.ResErrMsg, 30, conCaseCommonBase.ResErrMsg);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.UpdDate, 20, conCaseCommonBase.UpdDate);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.UpdUserId, 20, conCaseCommonBase.UpdUserId);
clsCheckSql.CheckFieldLen(objCaseCommonBaseEN.Memo, 1000, conCaseCommonBase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.IdCase, conCaseCommonBase.IdCase);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.CaseId, conCaseCommonBase.CaseId);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.CaseName, conCaseCommonBase.CaseName);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.CaseText, conCaseCommonBase.CaseText);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.CaseTheme, conCaseCommonBase.CaseTheme);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.FuncModuleId, conCaseCommonBase.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.CourseChapterId, conCaseCommonBase.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.IdCaseType, conCaseCommonBase.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.CaseDate, conCaseCommonBase.CaseDate);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.CaseTime, conCaseCommonBase.CaseTime);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.CaseDateIn, conCaseCommonBase.CaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.CaseTimeIn, conCaseCommonBase.CaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.OwnerId, conCaseCommonBase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.IdStudyLevel, conCaseCommonBase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.IdTeachingPlan, conCaseCommonBase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.IdDiscipline, conCaseCommonBase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.IdSenateGaugeVersion, conCaseCommonBase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.IdTeachSkill, conCaseCommonBase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.CaseLevelId, conCaseCommonBase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.DocFile, conCaseCommonBase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.WordCreateDate, conCaseCommonBase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.IdXzCollege, conCaseCommonBase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.IdXzMajor, conCaseCommonBase.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.RecommendedDegreeId, conCaseCommonBase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.CourseId, conCaseCommonBase.CourseId);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.IdCaseType4FuncModuleId, conCaseCommonBase.IdCaseType4FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.ftpFileType, conCaseCommonBase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.VideoUrl, conCaseCommonBase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.VideoPath, conCaseCommonBase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.ResErrMsg, conCaseCommonBase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.UpdDate, conCaseCommonBase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.UpdUserId, conCaseCommonBase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objCaseCommonBaseEN.Memo, conCaseCommonBase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCaseCommonBaseEN.IdStudyLevel, 4, conCaseCommonBase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objCaseCommonBaseEN.IdSenateGaugeVersion, 4, conCaseCommonBase.IdSenateGaugeVersion);
 objCaseCommonBaseEN._IsCheckProperty = true;
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
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
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
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
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
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCaseCommonBaseEN._CurrTabName);
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
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCaseCommonBaseEN._CurrTabName, strCondition);
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
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
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
 objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}