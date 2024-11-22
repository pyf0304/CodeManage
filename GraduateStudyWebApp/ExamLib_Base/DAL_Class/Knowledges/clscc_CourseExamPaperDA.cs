
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseExamPaperDA
 表名:cc_CourseExamPaper(01120071)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 考卷(cc_CourseExamPaper)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_CourseExamPaperDA : clsCommBase4DA
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
 return clscc_CourseExamPaperEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_CourseExamPaperEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_CourseExamPaperEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_CourseExamPaperEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_CourseExamPaperEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCourseExamPaperId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCourseExamPaperId)
{
strCourseExamPaperId = strCourseExamPaperId.Replace("'", "''");
if (strCourseExamPaperId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:cc_CourseExamPaper中,检查关键字,长度不正确!(clscc_CourseExamPaperDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCourseExamPaperId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:cc_CourseExamPaper中,关键字不能为空 或 null!(clscc_CourseExamPaperDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseExamPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clscc_CourseExamPaperDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_CourseExamPaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_CourseExamPaper(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_CourseExamPaperDA: GetDataTable_cc_CourseExamPaper)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaper where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_CourseExamPaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_CourseExamPaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaper where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_CourseExamPaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_CourseExamPaperDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseExamPaper where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseExamPaper where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_CourseExamPaperDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_CourseExamPaper where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_CourseExamPaperDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_CourseExamPaper.* from cc_CourseExamPaper Left Join {1} on {2} where {3} and cc_CourseExamPaper.CourseExamPaperId not in (Select top {5} cc_CourseExamPaper.CourseExamPaperId from cc_CourseExamPaper Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseExamPaper where {1} and CourseExamPaperId not in (Select top {2} CourseExamPaperId from cc_CourseExamPaper where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseExamPaper where {1} and CourseExamPaperId not in (Select top {3} CourseExamPaperId from cc_CourseExamPaper where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_CourseExamPaperDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_CourseExamPaper.* from cc_CourseExamPaper Left Join {1} on {2} where {3} and cc_CourseExamPaper.CourseExamPaperId not in (Select top {5} cc_CourseExamPaper.CourseExamPaperId from cc_CourseExamPaper Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseExamPaper where {1} and CourseExamPaperId not in (Select top {2} CourseExamPaperId from cc_CourseExamPaper where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseExamPaper where {1} and CourseExamPaperId not in (Select top {3} CourseExamPaperId from cc_CourseExamPaper where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_CourseExamPaperEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_CourseExamPaperDA:GetObjLst)", objException.Message));
}
List<clscc_CourseExamPaperEN> arrObjLst = new List<clscc_CourseExamPaperEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperEN objcc_CourseExamPaperEN = new clscc_CourseExamPaperEN();
try
{
objcc_CourseExamPaperEN.CourseExamPaperId = objRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperEN.CourseId = objRow[concc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperEN.ExamPaperName = objRow[concc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objcc_CourseExamPaperEN.PaperIndex = objRow[concc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objcc_CourseExamPaperEN.ExamPaperTypeId = objRow[concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_CourseExamPaperEN.IsShow = TransNullToBool(objRow[concc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperEN.TotalScore = objRow[concc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objcc_CourseExamPaperEN.ViewCount = objRow[concc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objcc_CourseExamPaperEN.DoneNumber = objRow[concc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objcc_CourseExamPaperEN.PaperTime = objRow[concc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objcc_CourseExamPaperEN.DownloadNumber = objRow[concc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objcc_CourseExamPaperEN.CollectionCount = objRow[concc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objcc_CourseExamPaperEN.LikeCount = objRow[concc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseExamPaperEN.IdXzMajor = objRow[concc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[concc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseExamPaperEN.PaperDispModeId = objRow[concc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objcc_CourseExamPaperEN.ExamCreateTime = objRow[concc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objcc_CourseExamPaperEN.CreateUserID = objRow[concc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objcc_CourseExamPaperEN.IsOpenToAllStu = TransNullToBool(objRow[concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseExamPaperEN.IsOpenToSchool = TransNullToBool(objRow[concc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseExamPaperEN.IsOpenToSocial = TransNullToBool(objRow[concc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseExamPaperEN.CourseChapterId = objRow[concc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseExamPaperEN.IsAutoGeneQuestion = TransNullToBool(objRow[concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objcc_CourseExamPaperEN.IsCanMultiDo = TransNullToBool(objRow[concc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objcc_CourseExamPaperEN.UpdDate = objRow[concc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objcc_CourseExamPaperEN.UpdUserId = objRow[concc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseExamPaperEN.Memo = objRow[concc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[concc_CourseExamPaper.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_CourseExamPaperDA: GetObjLst)", objException.Message));
}
objcc_CourseExamPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_CourseExamPaperEN);
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
public List<clscc_CourseExamPaperEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_CourseExamPaperDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_CourseExamPaperEN> arrObjLst = new List<clscc_CourseExamPaperEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperEN objcc_CourseExamPaperEN = new clscc_CourseExamPaperEN();
try
{
objcc_CourseExamPaperEN.CourseExamPaperId = objRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperEN.CourseId = objRow[concc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperEN.ExamPaperName = objRow[concc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objcc_CourseExamPaperEN.PaperIndex = objRow[concc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objcc_CourseExamPaperEN.ExamPaperTypeId = objRow[concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_CourseExamPaperEN.IsShow = TransNullToBool(objRow[concc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperEN.TotalScore = objRow[concc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objcc_CourseExamPaperEN.ViewCount = objRow[concc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objcc_CourseExamPaperEN.DoneNumber = objRow[concc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objcc_CourseExamPaperEN.PaperTime = objRow[concc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objcc_CourseExamPaperEN.DownloadNumber = objRow[concc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objcc_CourseExamPaperEN.CollectionCount = objRow[concc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objcc_CourseExamPaperEN.LikeCount = objRow[concc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseExamPaperEN.IdXzMajor = objRow[concc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[concc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseExamPaperEN.PaperDispModeId = objRow[concc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objcc_CourseExamPaperEN.ExamCreateTime = objRow[concc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objcc_CourseExamPaperEN.CreateUserID = objRow[concc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objcc_CourseExamPaperEN.IsOpenToAllStu = TransNullToBool(objRow[concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseExamPaperEN.IsOpenToSchool = TransNullToBool(objRow[concc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseExamPaperEN.IsOpenToSocial = TransNullToBool(objRow[concc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseExamPaperEN.CourseChapterId = objRow[concc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseExamPaperEN.IsAutoGeneQuestion = TransNullToBool(objRow[concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objcc_CourseExamPaperEN.IsCanMultiDo = TransNullToBool(objRow[concc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objcc_CourseExamPaperEN.UpdDate = objRow[concc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objcc_CourseExamPaperEN.UpdUserId = objRow[concc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseExamPaperEN.Memo = objRow[concc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[concc_CourseExamPaper.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_CourseExamPaperDA: GetObjLst)", objException.Message));
}
objcc_CourseExamPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_CourseExamPaperEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_CourseExamPaper(ref clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaper where CourseExamPaperId = " + "'"+ objcc_CourseExamPaperEN.CourseExamPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_CourseExamPaperEN.CourseExamPaperId = objDT.Rows[0][concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseExamPaperEN.CourseId = objDT.Rows[0][concc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseExamPaperEN.ExamPaperName = objDT.Rows[0][concc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称(字段类型:varchar,字段长度:500,是否可空:True)
 objcc_CourseExamPaperEN.PaperIndex = TransNullToInt(objDT.Rows[0][concc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseExamPaperEN.ExamPaperTypeId = objDT.Rows[0][concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id(字段类型:char,字段长度:2,是否可空:False)
 objcc_CourseExamPaperEN.IsShow = TransNullToBool(objDT.Rows[0][concc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseExamPaperEN.TotalScore = TransNullToDouble(objDT.Rows[0][concc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分(字段类型:decimal,字段长度:10,是否可空:False)
 objcc_CourseExamPaperEN.ViewCount = TransNullToInt(objDT.Rows[0][concc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseExamPaperEN.DoneNumber = TransNullToInt(objDT.Rows[0][concc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseExamPaperEN.PaperTime = TransNullToInt(objDT.Rows[0][concc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseExamPaperEN.DownloadNumber = TransNullToInt(objDT.Rows[0][concc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseExamPaperEN.CollectionCount = TransNullToInt(objDT.Rows[0][concc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_CourseExamPaperEN.LikeCount = TransNullToInt(objDT.Rows[0][concc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_CourseExamPaperEN.IdXzMajor = objDT.Rows[0][concc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseExamPaperEN.PaperDispModeId = objDT.Rows[0][concc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id(字段类型:char,字段长度:4,是否可空:True)
 objcc_CourseExamPaperEN.ExamCreateTime = objDT.Rows[0][concc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_CourseExamPaperEN.CreateUserID = objDT.Rows[0][concc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseExamPaperEN.IsOpenToAllStu = TransNullToBool(objDT.Rows[0][concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseExamPaperEN.IsOpenToSchool = TransNullToBool(objDT.Rows[0][concc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseExamPaperEN.IsOpenToSocial = TransNullToBool(objDT.Rows[0][concc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseExamPaperEN.CourseChapterId = objDT.Rows[0][concc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseExamPaperEN.IsAutoGeneQuestion = TransNullToBool(objDT.Rows[0][concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseExamPaperEN.IsCanMultiDo = TransNullToBool(objDT.Rows[0][concc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseExamPaperEN.UpdDate = objDT.Rows[0][concc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseExamPaperEN.UpdUserId = objDT.Rows[0][concc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseExamPaperEN.Memo = objDT.Rows[0][concc_CourseExamPaper.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_CourseExamPaperDA: Getcc_CourseExamPaper)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseExamPaperId">表关键字</param>
 /// <returns>表对象</returns>
public clscc_CourseExamPaperEN GetObjByCourseExamPaperId(string strCourseExamPaperId)
{
CheckPrimaryKey(strCourseExamPaperId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaper where CourseExamPaperId = " + "'"+ strCourseExamPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_CourseExamPaperEN objcc_CourseExamPaperEN = new clscc_CourseExamPaperEN();
try
{
 objcc_CourseExamPaperEN.CourseExamPaperId = objRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseExamPaperEN.CourseId = objRow[concc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseExamPaperEN.ExamPaperName = objRow[concc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称(字段类型:varchar,字段长度:500,是否可空:True)
 objcc_CourseExamPaperEN.PaperIndex = objRow[concc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseExamPaperEN.ExamPaperTypeId = objRow[concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id(字段类型:char,字段长度:2,是否可空:False)
 objcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseExamPaperEN.TotalScore = objRow[concc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分(字段类型:decimal,字段长度:10,是否可空:False)
 objcc_CourseExamPaperEN.ViewCount = objRow[concc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseExamPaperEN.DoneNumber = objRow[concc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseExamPaperEN.PaperTime = objRow[concc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseExamPaperEN.DownloadNumber = objRow[concc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseExamPaperEN.CollectionCount = objRow[concc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_CourseExamPaperEN.LikeCount = objRow[concc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_CourseExamPaperEN.IdXzMajor = objRow[concc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[concc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseExamPaperEN.PaperDispModeId = objRow[concc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id(字段类型:char,字段长度:4,是否可空:True)
 objcc_CourseExamPaperEN.ExamCreateTime = objRow[concc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_CourseExamPaperEN.CreateUserID = objRow[concc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseExamPaperEN.CourseChapterId = objRow[concc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseExamPaperEN.UpdDate = objRow[concc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseExamPaperEN.UpdUserId = objRow[concc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseExamPaperEN.Memo = objRow[concc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[concc_CourseExamPaper.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_CourseExamPaperDA: GetObjByCourseExamPaperId)", objException.Message));
}
return objcc_CourseExamPaperEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_CourseExamPaperEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_CourseExamPaperDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_CourseExamPaperEN objcc_CourseExamPaperEN = new clscc_CourseExamPaperEN()
{
CourseExamPaperId = objRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(), //考卷流水号
CourseId = objRow[concc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseId].ToString().Trim(), //课程Id
ExamPaperName = objRow[concc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamPaperName].ToString().Trim(), //考卷名称
PaperIndex = objRow[concc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.PaperIndex].ToString().Trim()), //试卷序号
ExamPaperTypeId = objRow[concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(), //试卷类型Id
IsShow = TransNullToBool(objRow[concc_CourseExamPaper.IsShow].ToString().Trim()), //是否启用
TotalScore = objRow[concc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseExamPaper.TotalScore].ToString().Trim()), //总得分
ViewCount = objRow[concc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.ViewCount].ToString().Trim()), //浏览量
DoneNumber = objRow[concc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.DoneNumber].ToString().Trim()), //已做人数
PaperTime = objRow[concc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.PaperTime].ToString().Trim()), //考试时间（分钟）
DownloadNumber = objRow[concc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.DownloadNumber].ToString().Trim()), //下载数目
CollectionCount = objRow[concc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseExamPaper.CollectionCount].ToString().Trim()), //收藏数量
LikeCount = objRow[concc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseExamPaper.LikeCount].ToString().Trim()), //资源喜欢数量
IdXzMajor = objRow[concc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[concc_CourseExamPaper.IdXzMajor].ToString().Trim(), //专业流水号
PaperDispModeId = objRow[concc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.PaperDispModeId].ToString().Trim(), //试卷显示模式Id
ExamCreateTime = objRow[concc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamCreateTime].ToString().Trim(), //考卷建立时间
CreateUserID = objRow[concc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CreateUserID].ToString().Trim(), //建立用户ID
IsOpenToAllStu = TransNullToBool(objRow[concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()), //全校师生
IsOpenToSchool = TransNullToBool(objRow[concc_CourseExamPaper.IsOpenToSchool].ToString().Trim()), //全校师生公开
IsOpenToSocial = TransNullToBool(objRow[concc_CourseExamPaper.IsOpenToSocial].ToString().Trim()), //社会公众
CourseChapterId = objRow[concc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseChapterId].ToString().Trim(), //课程章节ID
IsAutoGeneQuestion = TransNullToBool(objRow[concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()), //是否自动生成题目
IsCanMultiDo = TransNullToBool(objRow[concc_CourseExamPaper.IsCanMultiDo].ToString().Trim()), //是否可以做多次
UpdDate = objRow[concc_CourseExamPaper.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[concc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[concc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[concc_CourseExamPaper.Memo].ToString().Trim() //备注
};
objcc_CourseExamPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseExamPaperEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_CourseExamPaperDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_CourseExamPaperEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_CourseExamPaperEN objcc_CourseExamPaperEN = new clscc_CourseExamPaperEN();
try
{
objcc_CourseExamPaperEN.CourseExamPaperId = objRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperEN.CourseId = objRow[concc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperEN.ExamPaperName = objRow[concc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objcc_CourseExamPaperEN.PaperIndex = objRow[concc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objcc_CourseExamPaperEN.ExamPaperTypeId = objRow[concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_CourseExamPaperEN.IsShow = TransNullToBool(objRow[concc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperEN.TotalScore = objRow[concc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objcc_CourseExamPaperEN.ViewCount = objRow[concc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objcc_CourseExamPaperEN.DoneNumber = objRow[concc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objcc_CourseExamPaperEN.PaperTime = objRow[concc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objcc_CourseExamPaperEN.DownloadNumber = objRow[concc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objcc_CourseExamPaperEN.CollectionCount = objRow[concc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objcc_CourseExamPaperEN.LikeCount = objRow[concc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseExamPaperEN.IdXzMajor = objRow[concc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[concc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseExamPaperEN.PaperDispModeId = objRow[concc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objcc_CourseExamPaperEN.ExamCreateTime = objRow[concc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objcc_CourseExamPaperEN.CreateUserID = objRow[concc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objcc_CourseExamPaperEN.IsOpenToAllStu = TransNullToBool(objRow[concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseExamPaperEN.IsOpenToSchool = TransNullToBool(objRow[concc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseExamPaperEN.IsOpenToSocial = TransNullToBool(objRow[concc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseExamPaperEN.CourseChapterId = objRow[concc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseExamPaperEN.IsAutoGeneQuestion = TransNullToBool(objRow[concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objcc_CourseExamPaperEN.IsCanMultiDo = TransNullToBool(objRow[concc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objcc_CourseExamPaperEN.UpdDate = objRow[concc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objcc_CourseExamPaperEN.UpdUserId = objRow[concc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseExamPaperEN.Memo = objRow[concc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[concc_CourseExamPaper.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_CourseExamPaperDA: GetObjByDataRowcc_CourseExamPaper)", objException.Message));
}
objcc_CourseExamPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseExamPaperEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_CourseExamPaperEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_CourseExamPaperEN objcc_CourseExamPaperEN = new clscc_CourseExamPaperEN();
try
{
objcc_CourseExamPaperEN.CourseExamPaperId = objRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperEN.CourseId = objRow[concc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperEN.ExamPaperName = objRow[concc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objcc_CourseExamPaperEN.PaperIndex = objRow[concc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objcc_CourseExamPaperEN.ExamPaperTypeId = objRow[concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_CourseExamPaperEN.IsShow = TransNullToBool(objRow[concc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperEN.TotalScore = objRow[concc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objcc_CourseExamPaperEN.ViewCount = objRow[concc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objcc_CourseExamPaperEN.DoneNumber = objRow[concc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objcc_CourseExamPaperEN.PaperTime = objRow[concc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objcc_CourseExamPaperEN.DownloadNumber = objRow[concc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objcc_CourseExamPaperEN.CollectionCount = objRow[concc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objcc_CourseExamPaperEN.LikeCount = objRow[concc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseExamPaperEN.IdXzMajor = objRow[concc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[concc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseExamPaperEN.PaperDispModeId = objRow[concc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objcc_CourseExamPaperEN.ExamCreateTime = objRow[concc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objcc_CourseExamPaperEN.CreateUserID = objRow[concc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objcc_CourseExamPaperEN.IsOpenToAllStu = TransNullToBool(objRow[concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseExamPaperEN.IsOpenToSchool = TransNullToBool(objRow[concc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseExamPaperEN.IsOpenToSocial = TransNullToBool(objRow[concc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseExamPaperEN.CourseChapterId = objRow[concc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseExamPaperEN.IsAutoGeneQuestion = TransNullToBool(objRow[concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objcc_CourseExamPaperEN.IsCanMultiDo = TransNullToBool(objRow[concc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objcc_CourseExamPaperEN.UpdDate = objRow[concc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objcc_CourseExamPaperEN.UpdUserId = objRow[concc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseExamPaperEN.Memo = objRow[concc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[concc_CourseExamPaper.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_CourseExamPaperDA: GetObjByDataRow)", objException.Message));
}
objcc_CourseExamPaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseExamPaperEN;
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
objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_CourseExamPaperEN._CurrTabName, concc_CourseExamPaper.CourseExamPaperId, 8, "");
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
objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_CourseExamPaperEN._CurrTabName, concc_CourseExamPaper.CourseExamPaperId, 8, strPrefix);
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
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CourseExamPaperId from cc_CourseExamPaper where " + strCondition;
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
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CourseExamPaperId from cc_CourseExamPaper where " + strCondition;
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
 /// <param name = "strCourseExamPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCourseExamPaperId)
{
CheckPrimaryKey(strCourseExamPaperId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_CourseExamPaper", "CourseExamPaperId = " + "'"+ strCourseExamPaperId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_CourseExamPaperDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_CourseExamPaper", strCondition))
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
objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_CourseExamPaper");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
 {
 objcc_CourseExamPaperEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseExamPaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseExamPaperEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaper where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_CourseExamPaper");
objRow = objDS.Tables["cc_CourseExamPaper"].NewRow();
objRow[concc_CourseExamPaper.CourseExamPaperId] = objcc_CourseExamPaperEN.CourseExamPaperId; //考卷流水号
 if (objcc_CourseExamPaperEN.CourseId !=  "")
 {
objRow[concc_CourseExamPaper.CourseId] = objcc_CourseExamPaperEN.CourseId; //课程Id
 }
 if (objcc_CourseExamPaperEN.ExamPaperName !=  "")
 {
objRow[concc_CourseExamPaper.ExamPaperName] = objcc_CourseExamPaperEN.ExamPaperName; //考卷名称
 }
objRow[concc_CourseExamPaper.PaperIndex] = objcc_CourseExamPaperEN.PaperIndex; //试卷序号
objRow[concc_CourseExamPaper.ExamPaperTypeId] = objcc_CourseExamPaperEN.ExamPaperTypeId; //试卷类型Id
objRow[concc_CourseExamPaper.IsShow] = objcc_CourseExamPaperEN.IsShow; //是否启用
objRow[concc_CourseExamPaper.TotalScore] = objcc_CourseExamPaperEN.TotalScore; //总得分
objRow[concc_CourseExamPaper.ViewCount] = objcc_CourseExamPaperEN.ViewCount; //浏览量
objRow[concc_CourseExamPaper.DoneNumber] = objcc_CourseExamPaperEN.DoneNumber; //已做人数
objRow[concc_CourseExamPaper.PaperTime] = objcc_CourseExamPaperEN.PaperTime; //考试时间（分钟）
objRow[concc_CourseExamPaper.DownloadNumber] = objcc_CourseExamPaperEN.DownloadNumber; //下载数目
objRow[concc_CourseExamPaper.CollectionCount] = objcc_CourseExamPaperEN.CollectionCount; //收藏数量
objRow[concc_CourseExamPaper.LikeCount] = objcc_CourseExamPaperEN.LikeCount; //资源喜欢数量
 if (objcc_CourseExamPaperEN.IdXzMajor !=  "")
 {
objRow[concc_CourseExamPaper.IdXzMajor] = objcc_CourseExamPaperEN.IdXzMajor; //专业流水号
 }
 if (objcc_CourseExamPaperEN.PaperDispModeId !=  "")
 {
objRow[concc_CourseExamPaper.PaperDispModeId] = objcc_CourseExamPaperEN.PaperDispModeId; //试卷显示模式Id
 }
 if (objcc_CourseExamPaperEN.ExamCreateTime !=  "")
 {
objRow[concc_CourseExamPaper.ExamCreateTime] = objcc_CourseExamPaperEN.ExamCreateTime; //考卷建立时间
 }
 if (objcc_CourseExamPaperEN.CreateUserID !=  "")
 {
objRow[concc_CourseExamPaper.CreateUserID] = objcc_CourseExamPaperEN.CreateUserID; //建立用户ID
 }
objRow[concc_CourseExamPaper.IsOpenToAllStu] = objcc_CourseExamPaperEN.IsOpenToAllStu; //全校师生
objRow[concc_CourseExamPaper.IsOpenToSchool] = objcc_CourseExamPaperEN.IsOpenToSchool; //全校师生公开
objRow[concc_CourseExamPaper.IsOpenToSocial] = objcc_CourseExamPaperEN.IsOpenToSocial; //社会公众
 if (objcc_CourseExamPaperEN.CourseChapterId !=  "")
 {
objRow[concc_CourseExamPaper.CourseChapterId] = objcc_CourseExamPaperEN.CourseChapterId; //课程章节ID
 }
objRow[concc_CourseExamPaper.IsAutoGeneQuestion] = objcc_CourseExamPaperEN.IsAutoGeneQuestion; //是否自动生成题目
objRow[concc_CourseExamPaper.IsCanMultiDo] = objcc_CourseExamPaperEN.IsCanMultiDo; //是否可以做多次
objRow[concc_CourseExamPaper.UpdDate] = objcc_CourseExamPaperEN.UpdDate; //修改日期
 if (objcc_CourseExamPaperEN.UpdUserId !=  "")
 {
objRow[concc_CourseExamPaper.UpdUserId] = objcc_CourseExamPaperEN.UpdUserId; //修改用户Id
 }
 if (objcc_CourseExamPaperEN.Memo !=  "")
 {
objRow[concc_CourseExamPaper.Memo] = objcc_CourseExamPaperEN.Memo; //备注
 }
objDS.Tables[clscc_CourseExamPaperEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_CourseExamPaperEN._CurrTabName);
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
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
 objcc_CourseExamPaperEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseExamPaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseExamPaperEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseExamPaperEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CourseExamPaperId);
 var strCourseExamPaperId = objcc_CourseExamPaperEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_CourseExamPaperEN.CourseId  ==  "")
 {
 objcc_CourseExamPaperEN.CourseId = null;
 }
 if (objcc_CourseExamPaperEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CourseId);
 var strCourseId = objcc_CourseExamPaperEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseExamPaperEN.ExamPaperName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.ExamPaperName);
 var strExamPaperName = objcc_CourseExamPaperEN.ExamPaperName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperName + "'");
 }
 
 if (objcc_CourseExamPaperEN.PaperIndex !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.PaperIndex);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.PaperIndex.ToString());
 }
 
 if (objcc_CourseExamPaperEN.ExamPaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.ExamPaperTypeId);
 var strExamPaperTypeId = objcc_CourseExamPaperEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperTypeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperEN.TotalScore !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.TotalScore);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.TotalScore.ToString());
 }
 
 if (objcc_CourseExamPaperEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.ViewCount);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.ViewCount.ToString());
 }
 
 if (objcc_CourseExamPaperEN.DoneNumber !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.DoneNumber);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.DoneNumber.ToString());
 }
 
 if (objcc_CourseExamPaperEN.PaperTime !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.PaperTime);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.PaperTime.ToString());
 }
 
 if (objcc_CourseExamPaperEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.DownloadNumber);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.DownloadNumber.ToString());
 }
 
 if (objcc_CourseExamPaperEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CollectionCount);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.CollectionCount.ToString());
 }
 
 if (objcc_CourseExamPaperEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.LikeCount);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.LikeCount.ToString());
 }
 
 if (objcc_CourseExamPaperEN.IdXzMajor  ==  "")
 {
 objcc_CourseExamPaperEN.IdXzMajor = null;
 }
 if (objcc_CourseExamPaperEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.IdXzMajor);
 var strIdXzMajor = objcc_CourseExamPaperEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objcc_CourseExamPaperEN.PaperDispModeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.PaperDispModeId);
 var strPaperDispModeId = objcc_CourseExamPaperEN.PaperDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperDispModeId + "'");
 }
 
 if (objcc_CourseExamPaperEN.ExamCreateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.ExamCreateTime);
 var strExamCreateTime = objcc_CourseExamPaperEN.ExamCreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamCreateTime + "'");
 }
 
 if (objcc_CourseExamPaperEN.CreateUserID !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CreateUserID);
 var strCreateUserID = objcc_CourseExamPaperEN.CreateUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserID + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsOpenToAllStu);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsOpenToAllStu  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsOpenToSchool);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsOpenToSchool  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsOpenToSocial);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsOpenToSocial  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CourseChapterId);
 var strCourseChapterId = objcc_CourseExamPaperEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsAutoGeneQuestion);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsAutoGeneQuestion  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsCanMultiDo);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsCanMultiDo  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.UpdDate);
 var strUpdDate = objcc_CourseExamPaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_CourseExamPaperEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.UpdUserId);
 var strUpdUserId = objcc_CourseExamPaperEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_CourseExamPaperEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.Memo);
 var strMemo = objcc_CourseExamPaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseExamPaper");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
 objcc_CourseExamPaperEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseExamPaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseExamPaperEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseExamPaperEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CourseExamPaperId);
 var strCourseExamPaperId = objcc_CourseExamPaperEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_CourseExamPaperEN.CourseId  ==  "")
 {
 objcc_CourseExamPaperEN.CourseId = null;
 }
 if (objcc_CourseExamPaperEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CourseId);
 var strCourseId = objcc_CourseExamPaperEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseExamPaperEN.ExamPaperName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.ExamPaperName);
 var strExamPaperName = objcc_CourseExamPaperEN.ExamPaperName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperName + "'");
 }
 
 if (objcc_CourseExamPaperEN.PaperIndex !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.PaperIndex);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.PaperIndex.ToString());
 }
 
 if (objcc_CourseExamPaperEN.ExamPaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.ExamPaperTypeId);
 var strExamPaperTypeId = objcc_CourseExamPaperEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperTypeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperEN.TotalScore !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.TotalScore);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.TotalScore.ToString());
 }
 
 if (objcc_CourseExamPaperEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.ViewCount);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.ViewCount.ToString());
 }
 
 if (objcc_CourseExamPaperEN.DoneNumber !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.DoneNumber);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.DoneNumber.ToString());
 }
 
 if (objcc_CourseExamPaperEN.PaperTime !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.PaperTime);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.PaperTime.ToString());
 }
 
 if (objcc_CourseExamPaperEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.DownloadNumber);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.DownloadNumber.ToString());
 }
 
 if (objcc_CourseExamPaperEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CollectionCount);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.CollectionCount.ToString());
 }
 
 if (objcc_CourseExamPaperEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.LikeCount);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.LikeCount.ToString());
 }
 
 if (objcc_CourseExamPaperEN.IdXzMajor  ==  "")
 {
 objcc_CourseExamPaperEN.IdXzMajor = null;
 }
 if (objcc_CourseExamPaperEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.IdXzMajor);
 var strIdXzMajor = objcc_CourseExamPaperEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objcc_CourseExamPaperEN.PaperDispModeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.PaperDispModeId);
 var strPaperDispModeId = objcc_CourseExamPaperEN.PaperDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperDispModeId + "'");
 }
 
 if (objcc_CourseExamPaperEN.ExamCreateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.ExamCreateTime);
 var strExamCreateTime = objcc_CourseExamPaperEN.ExamCreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamCreateTime + "'");
 }
 
 if (objcc_CourseExamPaperEN.CreateUserID !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CreateUserID);
 var strCreateUserID = objcc_CourseExamPaperEN.CreateUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserID + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsOpenToAllStu);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsOpenToAllStu  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsOpenToSchool);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsOpenToSchool  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsOpenToSocial);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsOpenToSocial  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CourseChapterId);
 var strCourseChapterId = objcc_CourseExamPaperEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsAutoGeneQuestion);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsAutoGeneQuestion  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsCanMultiDo);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsCanMultiDo  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.UpdDate);
 var strUpdDate = objcc_CourseExamPaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_CourseExamPaperEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.UpdUserId);
 var strUpdUserId = objcc_CourseExamPaperEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_CourseExamPaperEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.Memo);
 var strMemo = objcc_CourseExamPaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseExamPaper");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objcc_CourseExamPaperEN.CourseExamPaperId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_CourseExamPaperEN objcc_CourseExamPaperEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_CourseExamPaperEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseExamPaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseExamPaperEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseExamPaperEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CourseExamPaperId);
 var strCourseExamPaperId = objcc_CourseExamPaperEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_CourseExamPaperEN.CourseId  ==  "")
 {
 objcc_CourseExamPaperEN.CourseId = null;
 }
 if (objcc_CourseExamPaperEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CourseId);
 var strCourseId = objcc_CourseExamPaperEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseExamPaperEN.ExamPaperName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.ExamPaperName);
 var strExamPaperName = objcc_CourseExamPaperEN.ExamPaperName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperName + "'");
 }
 
 if (objcc_CourseExamPaperEN.PaperIndex !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.PaperIndex);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.PaperIndex.ToString());
 }
 
 if (objcc_CourseExamPaperEN.ExamPaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.ExamPaperTypeId);
 var strExamPaperTypeId = objcc_CourseExamPaperEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperTypeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperEN.TotalScore !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.TotalScore);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.TotalScore.ToString());
 }
 
 if (objcc_CourseExamPaperEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.ViewCount);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.ViewCount.ToString());
 }
 
 if (objcc_CourseExamPaperEN.DoneNumber !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.DoneNumber);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.DoneNumber.ToString());
 }
 
 if (objcc_CourseExamPaperEN.PaperTime !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.PaperTime);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.PaperTime.ToString());
 }
 
 if (objcc_CourseExamPaperEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.DownloadNumber);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.DownloadNumber.ToString());
 }
 
 if (objcc_CourseExamPaperEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CollectionCount);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.CollectionCount.ToString());
 }
 
 if (objcc_CourseExamPaperEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.LikeCount);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.LikeCount.ToString());
 }
 
 if (objcc_CourseExamPaperEN.IdXzMajor  ==  "")
 {
 objcc_CourseExamPaperEN.IdXzMajor = null;
 }
 if (objcc_CourseExamPaperEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.IdXzMajor);
 var strIdXzMajor = objcc_CourseExamPaperEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objcc_CourseExamPaperEN.PaperDispModeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.PaperDispModeId);
 var strPaperDispModeId = objcc_CourseExamPaperEN.PaperDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperDispModeId + "'");
 }
 
 if (objcc_CourseExamPaperEN.ExamCreateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.ExamCreateTime);
 var strExamCreateTime = objcc_CourseExamPaperEN.ExamCreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamCreateTime + "'");
 }
 
 if (objcc_CourseExamPaperEN.CreateUserID !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CreateUserID);
 var strCreateUserID = objcc_CourseExamPaperEN.CreateUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserID + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsOpenToAllStu);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsOpenToAllStu  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsOpenToSchool);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsOpenToSchool  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsOpenToSocial);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsOpenToSocial  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CourseChapterId);
 var strCourseChapterId = objcc_CourseExamPaperEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsAutoGeneQuestion);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsAutoGeneQuestion  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsCanMultiDo);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsCanMultiDo  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.UpdDate);
 var strUpdDate = objcc_CourseExamPaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_CourseExamPaperEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.UpdUserId);
 var strUpdUserId = objcc_CourseExamPaperEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_CourseExamPaperEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.Memo);
 var strMemo = objcc_CourseExamPaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseExamPaper");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objcc_CourseExamPaperEN.CourseExamPaperId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_CourseExamPaperEN objcc_CourseExamPaperEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_CourseExamPaperEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseExamPaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseExamPaperEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseExamPaperEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CourseExamPaperId);
 var strCourseExamPaperId = objcc_CourseExamPaperEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_CourseExamPaperEN.CourseId  ==  "")
 {
 objcc_CourseExamPaperEN.CourseId = null;
 }
 if (objcc_CourseExamPaperEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CourseId);
 var strCourseId = objcc_CourseExamPaperEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseExamPaperEN.ExamPaperName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.ExamPaperName);
 var strExamPaperName = objcc_CourseExamPaperEN.ExamPaperName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperName + "'");
 }
 
 if (objcc_CourseExamPaperEN.PaperIndex !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.PaperIndex);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.PaperIndex.ToString());
 }
 
 if (objcc_CourseExamPaperEN.ExamPaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.ExamPaperTypeId);
 var strExamPaperTypeId = objcc_CourseExamPaperEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperTypeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperEN.TotalScore !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.TotalScore);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.TotalScore.ToString());
 }
 
 if (objcc_CourseExamPaperEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.ViewCount);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.ViewCount.ToString());
 }
 
 if (objcc_CourseExamPaperEN.DoneNumber !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.DoneNumber);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.DoneNumber.ToString());
 }
 
 if (objcc_CourseExamPaperEN.PaperTime !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.PaperTime);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.PaperTime.ToString());
 }
 
 if (objcc_CourseExamPaperEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.DownloadNumber);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.DownloadNumber.ToString());
 }
 
 if (objcc_CourseExamPaperEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CollectionCount);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.CollectionCount.ToString());
 }
 
 if (objcc_CourseExamPaperEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.LikeCount);
 arrValueListForInsert.Add(objcc_CourseExamPaperEN.LikeCount.ToString());
 }
 
 if (objcc_CourseExamPaperEN.IdXzMajor  ==  "")
 {
 objcc_CourseExamPaperEN.IdXzMajor = null;
 }
 if (objcc_CourseExamPaperEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.IdXzMajor);
 var strIdXzMajor = objcc_CourseExamPaperEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objcc_CourseExamPaperEN.PaperDispModeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.PaperDispModeId);
 var strPaperDispModeId = objcc_CourseExamPaperEN.PaperDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperDispModeId + "'");
 }
 
 if (objcc_CourseExamPaperEN.ExamCreateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.ExamCreateTime);
 var strExamCreateTime = objcc_CourseExamPaperEN.ExamCreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamCreateTime + "'");
 }
 
 if (objcc_CourseExamPaperEN.CreateUserID !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CreateUserID);
 var strCreateUserID = objcc_CourseExamPaperEN.CreateUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUserID + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsOpenToAllStu);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsOpenToAllStu  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsOpenToSchool);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsOpenToSchool  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsOpenToSocial);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsOpenToSocial  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.CourseChapterId);
 var strCourseChapterId = objcc_CourseExamPaperEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsAutoGeneQuestion);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsAutoGeneQuestion  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseExamPaper.IsCanMultiDo);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperEN.IsCanMultiDo  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.UpdDate);
 var strUpdDate = objcc_CourseExamPaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_CourseExamPaperEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.UpdUserId);
 var strUpdUserId = objcc_CourseExamPaperEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_CourseExamPaperEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaper.Memo);
 var strMemo = objcc_CourseExamPaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseExamPaper");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_CourseExamPapers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaper where CourseExamPaperId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_CourseExamPaper");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCourseExamPaperId = oRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim();
if (IsExist(strCourseExamPaperId))
{
 string strResult = "关键字变量值为:" + string.Format("CourseExamPaperId = {0}", strCourseExamPaperId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_CourseExamPaperEN._CurrTabName ].NewRow();
objRow[concc_CourseExamPaper.CourseExamPaperId] = oRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objRow[concc_CourseExamPaper.CourseId] = oRow[concc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objRow[concc_CourseExamPaper.ExamPaperName] = oRow[concc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objRow[concc_CourseExamPaper.PaperIndex] = oRow[concc_CourseExamPaper.PaperIndex].ToString().Trim(); //试卷序号
objRow[concc_CourseExamPaper.ExamPaperTypeId] = oRow[concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objRow[concc_CourseExamPaper.IsShow] = oRow[concc_CourseExamPaper.IsShow].ToString().Trim(); //是否启用
objRow[concc_CourseExamPaper.TotalScore] = oRow[concc_CourseExamPaper.TotalScore].ToString().Trim(); //总得分
objRow[concc_CourseExamPaper.ViewCount] = oRow[concc_CourseExamPaper.ViewCount].ToString().Trim(); //浏览量
objRow[concc_CourseExamPaper.DoneNumber] = oRow[concc_CourseExamPaper.DoneNumber].ToString().Trim(); //已做人数
objRow[concc_CourseExamPaper.PaperTime] = oRow[concc_CourseExamPaper.PaperTime].ToString().Trim(); //考试时间（分钟）
objRow[concc_CourseExamPaper.DownloadNumber] = oRow[concc_CourseExamPaper.DownloadNumber].ToString().Trim(); //下载数目
objRow[concc_CourseExamPaper.CollectionCount] = oRow[concc_CourseExamPaper.CollectionCount].ToString().Trim(); //收藏数量
objRow[concc_CourseExamPaper.LikeCount] = oRow[concc_CourseExamPaper.LikeCount].ToString().Trim(); //资源喜欢数量
objRow[concc_CourseExamPaper.IdXzMajor] = oRow[concc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objRow[concc_CourseExamPaper.PaperDispModeId] = oRow[concc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objRow[concc_CourseExamPaper.ExamCreateTime] = oRow[concc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objRow[concc_CourseExamPaper.CreateUserID] = oRow[concc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objRow[concc_CourseExamPaper.IsOpenToAllStu] = oRow[concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim(); //全校师生
objRow[concc_CourseExamPaper.IsOpenToSchool] = oRow[concc_CourseExamPaper.IsOpenToSchool].ToString().Trim(); //全校师生公开
objRow[concc_CourseExamPaper.IsOpenToSocial] = oRow[concc_CourseExamPaper.IsOpenToSocial].ToString().Trim(); //社会公众
objRow[concc_CourseExamPaper.CourseChapterId] = oRow[concc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objRow[concc_CourseExamPaper.IsAutoGeneQuestion] = oRow[concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim(); //是否自动生成题目
objRow[concc_CourseExamPaper.IsCanMultiDo] = oRow[concc_CourseExamPaper.IsCanMultiDo].ToString().Trim(); //是否可以做多次
objRow[concc_CourseExamPaper.UpdDate] = oRow[concc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objRow[concc_CourseExamPaper.UpdUserId] = oRow[concc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objRow[concc_CourseExamPaper.Memo] = oRow[concc_CourseExamPaper.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_CourseExamPaperEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_CourseExamPaperEN._CurrTabName);
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
 /// <param name = "objcc_CourseExamPaperEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
 objcc_CourseExamPaperEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseExamPaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseExamPaperEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaper where CourseExamPaperId = " + "'"+ objcc_CourseExamPaperEN.CourseExamPaperId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_CourseExamPaperEN._CurrTabName);
if (objDS.Tables[clscc_CourseExamPaperEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CourseExamPaperId = " + "'"+ objcc_CourseExamPaperEN.CourseExamPaperId+"'");
return false;
}
objRow = objDS.Tables[clscc_CourseExamPaperEN._CurrTabName].Rows[0];
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CourseExamPaperId))
 {
objRow[concc_CourseExamPaper.CourseExamPaperId] = objcc_CourseExamPaperEN.CourseExamPaperId; //考卷流水号
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CourseId))
 {
objRow[concc_CourseExamPaper.CourseId] = objcc_CourseExamPaperEN.CourseId; //课程Id
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ExamPaperName))
 {
objRow[concc_CourseExamPaper.ExamPaperName] = objcc_CourseExamPaperEN.ExamPaperName; //考卷名称
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.PaperIndex))
 {
objRow[concc_CourseExamPaper.PaperIndex] = objcc_CourseExamPaperEN.PaperIndex; //试卷序号
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ExamPaperTypeId))
 {
objRow[concc_CourseExamPaper.ExamPaperTypeId] = objcc_CourseExamPaperEN.ExamPaperTypeId; //试卷类型Id
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsShow))
 {
objRow[concc_CourseExamPaper.IsShow] = objcc_CourseExamPaperEN.IsShow; //是否启用
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.TotalScore))
 {
objRow[concc_CourseExamPaper.TotalScore] = objcc_CourseExamPaperEN.TotalScore; //总得分
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ViewCount))
 {
objRow[concc_CourseExamPaper.ViewCount] = objcc_CourseExamPaperEN.ViewCount; //浏览量
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.DoneNumber))
 {
objRow[concc_CourseExamPaper.DoneNumber] = objcc_CourseExamPaperEN.DoneNumber; //已做人数
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.PaperTime))
 {
objRow[concc_CourseExamPaper.PaperTime] = objcc_CourseExamPaperEN.PaperTime; //考试时间（分钟）
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.DownloadNumber))
 {
objRow[concc_CourseExamPaper.DownloadNumber] = objcc_CourseExamPaperEN.DownloadNumber; //下载数目
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CollectionCount))
 {
objRow[concc_CourseExamPaper.CollectionCount] = objcc_CourseExamPaperEN.CollectionCount; //收藏数量
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.LikeCount))
 {
objRow[concc_CourseExamPaper.LikeCount] = objcc_CourseExamPaperEN.LikeCount; //资源喜欢数量
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IdXzMajor))
 {
objRow[concc_CourseExamPaper.IdXzMajor] = objcc_CourseExamPaperEN.IdXzMajor; //专业流水号
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.PaperDispModeId))
 {
objRow[concc_CourseExamPaper.PaperDispModeId] = objcc_CourseExamPaperEN.PaperDispModeId; //试卷显示模式Id
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ExamCreateTime))
 {
objRow[concc_CourseExamPaper.ExamCreateTime] = objcc_CourseExamPaperEN.ExamCreateTime; //考卷建立时间
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CreateUserID))
 {
objRow[concc_CourseExamPaper.CreateUserID] = objcc_CourseExamPaperEN.CreateUserID; //建立用户ID
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsOpenToAllStu))
 {
objRow[concc_CourseExamPaper.IsOpenToAllStu] = objcc_CourseExamPaperEN.IsOpenToAllStu; //全校师生
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsOpenToSchool))
 {
objRow[concc_CourseExamPaper.IsOpenToSchool] = objcc_CourseExamPaperEN.IsOpenToSchool; //全校师生公开
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsOpenToSocial))
 {
objRow[concc_CourseExamPaper.IsOpenToSocial] = objcc_CourseExamPaperEN.IsOpenToSocial; //社会公众
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CourseChapterId))
 {
objRow[concc_CourseExamPaper.CourseChapterId] = objcc_CourseExamPaperEN.CourseChapterId; //课程章节ID
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsAutoGeneQuestion))
 {
objRow[concc_CourseExamPaper.IsAutoGeneQuestion] = objcc_CourseExamPaperEN.IsAutoGeneQuestion; //是否自动生成题目
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsCanMultiDo))
 {
objRow[concc_CourseExamPaper.IsCanMultiDo] = objcc_CourseExamPaperEN.IsCanMultiDo; //是否可以做多次
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.UpdDate))
 {
objRow[concc_CourseExamPaper.UpdDate] = objcc_CourseExamPaperEN.UpdDate; //修改日期
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.UpdUserId))
 {
objRow[concc_CourseExamPaper.UpdUserId] = objcc_CourseExamPaperEN.UpdUserId; //修改用户Id
 }
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.Memo))
 {
objRow[concc_CourseExamPaper.Memo] = objcc_CourseExamPaperEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_CourseExamPaperEN._CurrTabName);
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
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
 objcc_CourseExamPaperEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseExamPaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseExamPaperEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_CourseExamPaper Set ");
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CourseId))
 {
 if (objcc_CourseExamPaperEN.CourseId  ==  "")
 {
 objcc_CourseExamPaperEN.CourseId = null;
 }
 if (objcc_CourseExamPaperEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseExamPaperEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_CourseExamPaper.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.CourseId); //课程Id
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ExamPaperName))
 {
 if (objcc_CourseExamPaperEN.ExamPaperName !=  null)
 {
 var strExamPaperName = objcc_CourseExamPaperEN.ExamPaperName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamPaperName, concc_CourseExamPaper.ExamPaperName); //考卷名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.ExamPaperName); //考卷名称
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.PaperIndex))
 {
 if (objcc_CourseExamPaperEN.PaperIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.PaperIndex, concc_CourseExamPaper.PaperIndex); //试卷序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.PaperIndex); //试卷序号
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ExamPaperTypeId))
 {
 if (objcc_CourseExamPaperEN.ExamPaperTypeId !=  null)
 {
 var strExamPaperTypeId = objcc_CourseExamPaperEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamPaperTypeId, concc_CourseExamPaper.ExamPaperTypeId); //试卷类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.ExamPaperTypeId); //试卷类型Id
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseExamPaperEN.IsShow == true?"1":"0", concc_CourseExamPaper.IsShow); //是否启用
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.TotalScore))
 {
 if (objcc_CourseExamPaperEN.TotalScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.TotalScore, concc_CourseExamPaper.TotalScore); //总得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.TotalScore); //总得分
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ViewCount))
 {
 if (objcc_CourseExamPaperEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.ViewCount, concc_CourseExamPaper.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.ViewCount); //浏览量
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.DoneNumber))
 {
 if (objcc_CourseExamPaperEN.DoneNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.DoneNumber, concc_CourseExamPaper.DoneNumber); //已做人数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.DoneNumber); //已做人数
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.PaperTime))
 {
 if (objcc_CourseExamPaperEN.PaperTime !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.PaperTime, concc_CourseExamPaper.PaperTime); //考试时间（分钟）
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.PaperTime); //考试时间（分钟）
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.DownloadNumber))
 {
 if (objcc_CourseExamPaperEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.DownloadNumber, concc_CourseExamPaper.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.DownloadNumber); //下载数目
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CollectionCount))
 {
 if (objcc_CourseExamPaperEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.CollectionCount, concc_CourseExamPaper.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.CollectionCount); //收藏数量
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.LikeCount))
 {
 if (objcc_CourseExamPaperEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.LikeCount, concc_CourseExamPaper.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.LikeCount); //资源喜欢数量
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IdXzMajor))
 {
 if (objcc_CourseExamPaperEN.IdXzMajor  ==  "")
 {
 objcc_CourseExamPaperEN.IdXzMajor = null;
 }
 if (objcc_CourseExamPaperEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objcc_CourseExamPaperEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, concc_CourseExamPaper.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.IdXzMajor); //专业流水号
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.PaperDispModeId))
 {
 if (objcc_CourseExamPaperEN.PaperDispModeId !=  null)
 {
 var strPaperDispModeId = objcc_CourseExamPaperEN.PaperDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperDispModeId, concc_CourseExamPaper.PaperDispModeId); //试卷显示模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.PaperDispModeId); //试卷显示模式Id
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ExamCreateTime))
 {
 if (objcc_CourseExamPaperEN.ExamCreateTime !=  null)
 {
 var strExamCreateTime = objcc_CourseExamPaperEN.ExamCreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamCreateTime, concc_CourseExamPaper.ExamCreateTime); //考卷建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.ExamCreateTime); //考卷建立时间
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CreateUserID))
 {
 if (objcc_CourseExamPaperEN.CreateUserID !=  null)
 {
 var strCreateUserID = objcc_CourseExamPaperEN.CreateUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUserID, concc_CourseExamPaper.CreateUserID); //建立用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.CreateUserID); //建立用户ID
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsOpenToAllStu))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseExamPaperEN.IsOpenToAllStu == true?"1":"0", concc_CourseExamPaper.IsOpenToAllStu); //全校师生
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsOpenToSchool))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseExamPaperEN.IsOpenToSchool == true?"1":"0", concc_CourseExamPaper.IsOpenToSchool); //全校师生公开
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsOpenToSocial))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseExamPaperEN.IsOpenToSocial == true?"1":"0", concc_CourseExamPaper.IsOpenToSocial); //社会公众
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CourseChapterId))
 {
 if (objcc_CourseExamPaperEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_CourseExamPaperEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, concc_CourseExamPaper.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.CourseChapterId); //课程章节ID
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsAutoGeneQuestion))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseExamPaperEN.IsAutoGeneQuestion == true?"1":"0", concc_CourseExamPaper.IsAutoGeneQuestion); //是否自动生成题目
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsCanMultiDo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseExamPaperEN.IsCanMultiDo == true?"1":"0", concc_CourseExamPaper.IsCanMultiDo); //是否可以做多次
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.UpdDate))
 {
 if (objcc_CourseExamPaperEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_CourseExamPaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_CourseExamPaper.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.UpdDate); //修改日期
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.UpdUserId))
 {
 if (objcc_CourseExamPaperEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_CourseExamPaperEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_CourseExamPaper.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.Memo))
 {
 if (objcc_CourseExamPaperEN.Memo !=  null)
 {
 var strMemo = objcc_CourseExamPaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_CourseExamPaper.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CourseExamPaperId = '{0}'", objcc_CourseExamPaperEN.CourseExamPaperId); 
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
 /// <param name = "objcc_CourseExamPaperEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strCondition)
{
 objcc_CourseExamPaperEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseExamPaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseExamPaperEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseExamPaper Set ");
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CourseId))
 {
 if (objcc_CourseExamPaperEN.CourseId  ==  "")
 {
 objcc_CourseExamPaperEN.CourseId = null;
 }
 if (objcc_CourseExamPaperEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseExamPaperEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ExamPaperName))
 {
 if (objcc_CourseExamPaperEN.ExamPaperName !=  null)
 {
 var strExamPaperName = objcc_CourseExamPaperEN.ExamPaperName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamPaperName = '{0}',", strExamPaperName); //考卷名称
 }
 else
 {
 sbSQL.Append(" ExamPaperName = null,"); //考卷名称
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.PaperIndex))
 {
 if (objcc_CourseExamPaperEN.PaperIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.PaperIndex, concc_CourseExamPaper.PaperIndex); //试卷序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.PaperIndex); //试卷序号
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ExamPaperTypeId))
 {
 if (objcc_CourseExamPaperEN.ExamPaperTypeId !=  null)
 {
 var strExamPaperTypeId = objcc_CourseExamPaperEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamPaperTypeId = '{0}',", strExamPaperTypeId); //试卷类型Id
 }
 else
 {
 sbSQL.Append(" ExamPaperTypeId = null,"); //试卷类型Id
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objcc_CourseExamPaperEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.TotalScore))
 {
 if (objcc_CourseExamPaperEN.TotalScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.TotalScore, concc_CourseExamPaper.TotalScore); //总得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.TotalScore); //总得分
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ViewCount))
 {
 if (objcc_CourseExamPaperEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.ViewCount, concc_CourseExamPaper.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.ViewCount); //浏览量
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.DoneNumber))
 {
 if (objcc_CourseExamPaperEN.DoneNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.DoneNumber, concc_CourseExamPaper.DoneNumber); //已做人数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.DoneNumber); //已做人数
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.PaperTime))
 {
 if (objcc_CourseExamPaperEN.PaperTime !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.PaperTime, concc_CourseExamPaper.PaperTime); //考试时间（分钟）
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.PaperTime); //考试时间（分钟）
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.DownloadNumber))
 {
 if (objcc_CourseExamPaperEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.DownloadNumber, concc_CourseExamPaper.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.DownloadNumber); //下载数目
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CollectionCount))
 {
 if (objcc_CourseExamPaperEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.CollectionCount, concc_CourseExamPaper.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.CollectionCount); //收藏数量
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.LikeCount))
 {
 if (objcc_CourseExamPaperEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.LikeCount, concc_CourseExamPaper.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.LikeCount); //资源喜欢数量
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IdXzMajor))
 {
 if (objcc_CourseExamPaperEN.IdXzMajor  ==  "")
 {
 objcc_CourseExamPaperEN.IdXzMajor = null;
 }
 if (objcc_CourseExamPaperEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objcc_CourseExamPaperEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.PaperDispModeId))
 {
 if (objcc_CourseExamPaperEN.PaperDispModeId !=  null)
 {
 var strPaperDispModeId = objcc_CourseExamPaperEN.PaperDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperDispModeId = '{0}',", strPaperDispModeId); //试卷显示模式Id
 }
 else
 {
 sbSQL.Append(" PaperDispModeId = null,"); //试卷显示模式Id
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ExamCreateTime))
 {
 if (objcc_CourseExamPaperEN.ExamCreateTime !=  null)
 {
 var strExamCreateTime = objcc_CourseExamPaperEN.ExamCreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamCreateTime = '{0}',", strExamCreateTime); //考卷建立时间
 }
 else
 {
 sbSQL.Append(" ExamCreateTime = null,"); //考卷建立时间
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CreateUserID))
 {
 if (objcc_CourseExamPaperEN.CreateUserID !=  null)
 {
 var strCreateUserID = objcc_CourseExamPaperEN.CreateUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUserID = '{0}',", strCreateUserID); //建立用户ID
 }
 else
 {
 sbSQL.Append(" CreateUserID = null,"); //建立用户ID
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsOpenToAllStu))
 {
 sbSQL.AppendFormat(" IsOpenToAllStu = '{0}',", objcc_CourseExamPaperEN.IsOpenToAllStu == true?"1":"0"); //全校师生
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsOpenToSchool))
 {
 sbSQL.AppendFormat(" IsOpenToSchool = '{0}',", objcc_CourseExamPaperEN.IsOpenToSchool == true?"1":"0"); //全校师生公开
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsOpenToSocial))
 {
 sbSQL.AppendFormat(" IsOpenToSocial = '{0}',", objcc_CourseExamPaperEN.IsOpenToSocial == true?"1":"0"); //社会公众
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CourseChapterId))
 {
 if (objcc_CourseExamPaperEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_CourseExamPaperEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsAutoGeneQuestion))
 {
 sbSQL.AppendFormat(" IsAutoGeneQuestion = '{0}',", objcc_CourseExamPaperEN.IsAutoGeneQuestion == true?"1":"0"); //是否自动生成题目
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsCanMultiDo))
 {
 sbSQL.AppendFormat(" IsCanMultiDo = '{0}',", objcc_CourseExamPaperEN.IsCanMultiDo == true?"1":"0"); //是否可以做多次
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.UpdDate))
 {
 if (objcc_CourseExamPaperEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_CourseExamPaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.UpdUserId))
 {
 if (objcc_CourseExamPaperEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_CourseExamPaperEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.Memo))
 {
 if (objcc_CourseExamPaperEN.Memo !=  null)
 {
 var strMemo = objcc_CourseExamPaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_CourseExamPaperEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_CourseExamPaperEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseExamPaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseExamPaperEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseExamPaper Set ");
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CourseId))
 {
 if (objcc_CourseExamPaperEN.CourseId  ==  "")
 {
 objcc_CourseExamPaperEN.CourseId = null;
 }
 if (objcc_CourseExamPaperEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseExamPaperEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ExamPaperName))
 {
 if (objcc_CourseExamPaperEN.ExamPaperName !=  null)
 {
 var strExamPaperName = objcc_CourseExamPaperEN.ExamPaperName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamPaperName = '{0}',", strExamPaperName); //考卷名称
 }
 else
 {
 sbSQL.Append(" ExamPaperName = null,"); //考卷名称
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.PaperIndex))
 {
 if (objcc_CourseExamPaperEN.PaperIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.PaperIndex, concc_CourseExamPaper.PaperIndex); //试卷序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.PaperIndex); //试卷序号
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ExamPaperTypeId))
 {
 if (objcc_CourseExamPaperEN.ExamPaperTypeId !=  null)
 {
 var strExamPaperTypeId = objcc_CourseExamPaperEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamPaperTypeId = '{0}',", strExamPaperTypeId); //试卷类型Id
 }
 else
 {
 sbSQL.Append(" ExamPaperTypeId = null,"); //试卷类型Id
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objcc_CourseExamPaperEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.TotalScore))
 {
 if (objcc_CourseExamPaperEN.TotalScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.TotalScore, concc_CourseExamPaper.TotalScore); //总得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.TotalScore); //总得分
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ViewCount))
 {
 if (objcc_CourseExamPaperEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.ViewCount, concc_CourseExamPaper.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.ViewCount); //浏览量
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.DoneNumber))
 {
 if (objcc_CourseExamPaperEN.DoneNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.DoneNumber, concc_CourseExamPaper.DoneNumber); //已做人数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.DoneNumber); //已做人数
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.PaperTime))
 {
 if (objcc_CourseExamPaperEN.PaperTime !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.PaperTime, concc_CourseExamPaper.PaperTime); //考试时间（分钟）
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.PaperTime); //考试时间（分钟）
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.DownloadNumber))
 {
 if (objcc_CourseExamPaperEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.DownloadNumber, concc_CourseExamPaper.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.DownloadNumber); //下载数目
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CollectionCount))
 {
 if (objcc_CourseExamPaperEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.CollectionCount, concc_CourseExamPaper.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.CollectionCount); //收藏数量
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.LikeCount))
 {
 if (objcc_CourseExamPaperEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.LikeCount, concc_CourseExamPaper.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.LikeCount); //资源喜欢数量
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IdXzMajor))
 {
 if (objcc_CourseExamPaperEN.IdXzMajor  ==  "")
 {
 objcc_CourseExamPaperEN.IdXzMajor = null;
 }
 if (objcc_CourseExamPaperEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objcc_CourseExamPaperEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.PaperDispModeId))
 {
 if (objcc_CourseExamPaperEN.PaperDispModeId !=  null)
 {
 var strPaperDispModeId = objcc_CourseExamPaperEN.PaperDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperDispModeId = '{0}',", strPaperDispModeId); //试卷显示模式Id
 }
 else
 {
 sbSQL.Append(" PaperDispModeId = null,"); //试卷显示模式Id
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ExamCreateTime))
 {
 if (objcc_CourseExamPaperEN.ExamCreateTime !=  null)
 {
 var strExamCreateTime = objcc_CourseExamPaperEN.ExamCreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamCreateTime = '{0}',", strExamCreateTime); //考卷建立时间
 }
 else
 {
 sbSQL.Append(" ExamCreateTime = null,"); //考卷建立时间
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CreateUserID))
 {
 if (objcc_CourseExamPaperEN.CreateUserID !=  null)
 {
 var strCreateUserID = objcc_CourseExamPaperEN.CreateUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUserID = '{0}',", strCreateUserID); //建立用户ID
 }
 else
 {
 sbSQL.Append(" CreateUserID = null,"); //建立用户ID
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsOpenToAllStu))
 {
 sbSQL.AppendFormat(" IsOpenToAllStu = '{0}',", objcc_CourseExamPaperEN.IsOpenToAllStu == true?"1":"0"); //全校师生
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsOpenToSchool))
 {
 sbSQL.AppendFormat(" IsOpenToSchool = '{0}',", objcc_CourseExamPaperEN.IsOpenToSchool == true?"1":"0"); //全校师生公开
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsOpenToSocial))
 {
 sbSQL.AppendFormat(" IsOpenToSocial = '{0}',", objcc_CourseExamPaperEN.IsOpenToSocial == true?"1":"0"); //社会公众
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CourseChapterId))
 {
 if (objcc_CourseExamPaperEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_CourseExamPaperEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsAutoGeneQuestion))
 {
 sbSQL.AppendFormat(" IsAutoGeneQuestion = '{0}',", objcc_CourseExamPaperEN.IsAutoGeneQuestion == true?"1":"0"); //是否自动生成题目
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsCanMultiDo))
 {
 sbSQL.AppendFormat(" IsCanMultiDo = '{0}',", objcc_CourseExamPaperEN.IsCanMultiDo == true?"1":"0"); //是否可以做多次
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.UpdDate))
 {
 if (objcc_CourseExamPaperEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_CourseExamPaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.UpdUserId))
 {
 if (objcc_CourseExamPaperEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_CourseExamPaperEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.Memo))
 {
 if (objcc_CourseExamPaperEN.Memo !=  null)
 {
 var strMemo = objcc_CourseExamPaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_CourseExamPaperEN objcc_CourseExamPaperEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_CourseExamPaperEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseExamPaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseExamPaperEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseExamPaper Set ");
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CourseId))
 {
 if (objcc_CourseExamPaperEN.CourseId  ==  "")
 {
 objcc_CourseExamPaperEN.CourseId = null;
 }
 if (objcc_CourseExamPaperEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseExamPaperEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_CourseExamPaper.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.CourseId); //课程Id
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ExamPaperName))
 {
 if (objcc_CourseExamPaperEN.ExamPaperName !=  null)
 {
 var strExamPaperName = objcc_CourseExamPaperEN.ExamPaperName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamPaperName, concc_CourseExamPaper.ExamPaperName); //考卷名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.ExamPaperName); //考卷名称
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.PaperIndex))
 {
 if (objcc_CourseExamPaperEN.PaperIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.PaperIndex, concc_CourseExamPaper.PaperIndex); //试卷序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.PaperIndex); //试卷序号
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ExamPaperTypeId))
 {
 if (objcc_CourseExamPaperEN.ExamPaperTypeId !=  null)
 {
 var strExamPaperTypeId = objcc_CourseExamPaperEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamPaperTypeId, concc_CourseExamPaper.ExamPaperTypeId); //试卷类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.ExamPaperTypeId); //试卷类型Id
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseExamPaperEN.IsShow == true?"1":"0", concc_CourseExamPaper.IsShow); //是否启用
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.TotalScore))
 {
 if (objcc_CourseExamPaperEN.TotalScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.TotalScore, concc_CourseExamPaper.TotalScore); //总得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.TotalScore); //总得分
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ViewCount))
 {
 if (objcc_CourseExamPaperEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.ViewCount, concc_CourseExamPaper.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.ViewCount); //浏览量
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.DoneNumber))
 {
 if (objcc_CourseExamPaperEN.DoneNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.DoneNumber, concc_CourseExamPaper.DoneNumber); //已做人数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.DoneNumber); //已做人数
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.PaperTime))
 {
 if (objcc_CourseExamPaperEN.PaperTime !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.PaperTime, concc_CourseExamPaper.PaperTime); //考试时间（分钟）
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.PaperTime); //考试时间（分钟）
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.DownloadNumber))
 {
 if (objcc_CourseExamPaperEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.DownloadNumber, concc_CourseExamPaper.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.DownloadNumber); //下载数目
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CollectionCount))
 {
 if (objcc_CourseExamPaperEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.CollectionCount, concc_CourseExamPaper.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.CollectionCount); //收藏数量
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.LikeCount))
 {
 if (objcc_CourseExamPaperEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperEN.LikeCount, concc_CourseExamPaper.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.LikeCount); //资源喜欢数量
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IdXzMajor))
 {
 if (objcc_CourseExamPaperEN.IdXzMajor  ==  "")
 {
 objcc_CourseExamPaperEN.IdXzMajor = null;
 }
 if (objcc_CourseExamPaperEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objcc_CourseExamPaperEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, concc_CourseExamPaper.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.IdXzMajor); //专业流水号
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.PaperDispModeId))
 {
 if (objcc_CourseExamPaperEN.PaperDispModeId !=  null)
 {
 var strPaperDispModeId = objcc_CourseExamPaperEN.PaperDispModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperDispModeId, concc_CourseExamPaper.PaperDispModeId); //试卷显示模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.PaperDispModeId); //试卷显示模式Id
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.ExamCreateTime))
 {
 if (objcc_CourseExamPaperEN.ExamCreateTime !=  null)
 {
 var strExamCreateTime = objcc_CourseExamPaperEN.ExamCreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamCreateTime, concc_CourseExamPaper.ExamCreateTime); //考卷建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.ExamCreateTime); //考卷建立时间
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CreateUserID))
 {
 if (objcc_CourseExamPaperEN.CreateUserID !=  null)
 {
 var strCreateUserID = objcc_CourseExamPaperEN.CreateUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUserID, concc_CourseExamPaper.CreateUserID); //建立用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.CreateUserID); //建立用户ID
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsOpenToAllStu))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseExamPaperEN.IsOpenToAllStu == true?"1":"0", concc_CourseExamPaper.IsOpenToAllStu); //全校师生
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsOpenToSchool))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseExamPaperEN.IsOpenToSchool == true?"1":"0", concc_CourseExamPaper.IsOpenToSchool); //全校师生公开
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsOpenToSocial))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseExamPaperEN.IsOpenToSocial == true?"1":"0", concc_CourseExamPaper.IsOpenToSocial); //社会公众
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.CourseChapterId))
 {
 if (objcc_CourseExamPaperEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_CourseExamPaperEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, concc_CourseExamPaper.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.CourseChapterId); //课程章节ID
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsAutoGeneQuestion))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseExamPaperEN.IsAutoGeneQuestion == true?"1":"0", concc_CourseExamPaper.IsAutoGeneQuestion); //是否自动生成题目
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.IsCanMultiDo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseExamPaperEN.IsCanMultiDo == true?"1":"0", concc_CourseExamPaper.IsCanMultiDo); //是否可以做多次
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.UpdDate))
 {
 if (objcc_CourseExamPaperEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_CourseExamPaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_CourseExamPaper.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.UpdDate); //修改日期
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.UpdUserId))
 {
 if (objcc_CourseExamPaperEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_CourseExamPaperEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_CourseExamPaper.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_CourseExamPaperEN.IsUpdated(concc_CourseExamPaper.Memo))
 {
 if (objcc_CourseExamPaperEN.Memo !=  null)
 {
 var strMemo = objcc_CourseExamPaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_CourseExamPaper.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaper.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CourseExamPaperId = '{0}'", objcc_CourseExamPaperEN.CourseExamPaperId); 
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
 /// <param name = "strCourseExamPaperId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCourseExamPaperId) 
{
CheckPrimaryKey(strCourseExamPaperId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCourseExamPaperId,
};
 objSQL.ExecSP("cc_CourseExamPaper_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCourseExamPaperId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCourseExamPaperId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCourseExamPaperId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
//删除cc_CourseExamPaper本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseExamPaper where CourseExamPaperId = " + "'"+ strCourseExamPaperId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_CourseExamPaper(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
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
//删除cc_CourseExamPaper本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseExamPaper where CourseExamPaperId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCourseExamPaperId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCourseExamPaperId) 
{
CheckPrimaryKey(strCourseExamPaperId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
//删除cc_CourseExamPaper本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseExamPaper where CourseExamPaperId = " + "'"+ strCourseExamPaperId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_CourseExamPaper(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_CourseExamPaperDA: Delcc_CourseExamPaper)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_CourseExamPaper where " + strCondition ;
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
public bool Delcc_CourseExamPaperWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_CourseExamPaperDA: Delcc_CourseExamPaperWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_CourseExamPaper where " + strCondition ;
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
 /// <param name = "objcc_CourseExamPaperENS">源对象</param>
 /// <param name = "objcc_CourseExamPaperENT">目标对象</param>
public void CopyTo(clscc_CourseExamPaperEN objcc_CourseExamPaperENS, clscc_CourseExamPaperEN objcc_CourseExamPaperENT)
{
objcc_CourseExamPaperENT.CourseExamPaperId = objcc_CourseExamPaperENS.CourseExamPaperId; //考卷流水号
objcc_CourseExamPaperENT.CourseId = objcc_CourseExamPaperENS.CourseId; //课程Id
objcc_CourseExamPaperENT.ExamPaperName = objcc_CourseExamPaperENS.ExamPaperName; //考卷名称
objcc_CourseExamPaperENT.PaperIndex = objcc_CourseExamPaperENS.PaperIndex; //试卷序号
objcc_CourseExamPaperENT.ExamPaperTypeId = objcc_CourseExamPaperENS.ExamPaperTypeId; //试卷类型Id
objcc_CourseExamPaperENT.IsShow = objcc_CourseExamPaperENS.IsShow; //是否启用
objcc_CourseExamPaperENT.TotalScore = objcc_CourseExamPaperENS.TotalScore; //总得分
objcc_CourseExamPaperENT.ViewCount = objcc_CourseExamPaperENS.ViewCount; //浏览量
objcc_CourseExamPaperENT.DoneNumber = objcc_CourseExamPaperENS.DoneNumber; //已做人数
objcc_CourseExamPaperENT.PaperTime = objcc_CourseExamPaperENS.PaperTime; //考试时间（分钟）
objcc_CourseExamPaperENT.DownloadNumber = objcc_CourseExamPaperENS.DownloadNumber; //下载数目
objcc_CourseExamPaperENT.CollectionCount = objcc_CourseExamPaperENS.CollectionCount; //收藏数量
objcc_CourseExamPaperENT.LikeCount = objcc_CourseExamPaperENS.LikeCount; //资源喜欢数量
objcc_CourseExamPaperENT.IdXzMajor = objcc_CourseExamPaperENS.IdXzMajor; //专业流水号
objcc_CourseExamPaperENT.PaperDispModeId = objcc_CourseExamPaperENS.PaperDispModeId; //试卷显示模式Id
objcc_CourseExamPaperENT.ExamCreateTime = objcc_CourseExamPaperENS.ExamCreateTime; //考卷建立时间
objcc_CourseExamPaperENT.CreateUserID = objcc_CourseExamPaperENS.CreateUserID; //建立用户ID
objcc_CourseExamPaperENT.IsOpenToAllStu = objcc_CourseExamPaperENS.IsOpenToAllStu; //全校师生
objcc_CourseExamPaperENT.IsOpenToSchool = objcc_CourseExamPaperENS.IsOpenToSchool; //全校师生公开
objcc_CourseExamPaperENT.IsOpenToSocial = objcc_CourseExamPaperENS.IsOpenToSocial; //社会公众
objcc_CourseExamPaperENT.CourseChapterId = objcc_CourseExamPaperENS.CourseChapterId; //课程章节ID
objcc_CourseExamPaperENT.IsAutoGeneQuestion = objcc_CourseExamPaperENS.IsAutoGeneQuestion; //是否自动生成题目
objcc_CourseExamPaperENT.IsCanMultiDo = objcc_CourseExamPaperENS.IsCanMultiDo; //是否可以做多次
objcc_CourseExamPaperENT.UpdDate = objcc_CourseExamPaperENS.UpdDate; //修改日期
objcc_CourseExamPaperENT.UpdUserId = objcc_CourseExamPaperENS.UpdUserId; //修改用户Id
objcc_CourseExamPaperENT.Memo = objcc_CourseExamPaperENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_CourseExamPaperEN.ExamPaperTypeId, concc_CourseExamPaper.ExamPaperTypeId);
clsCheckSql.CheckFieldNotNull(objcc_CourseExamPaperEN.UpdDate, concc_CourseExamPaper.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.CourseExamPaperId, 8, concc_CourseExamPaper.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.CourseId, 8, concc_CourseExamPaper.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.ExamPaperName, 500, concc_CourseExamPaper.ExamPaperName);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.ExamPaperTypeId, 2, concc_CourseExamPaper.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.IdXzMajor, 8, concc_CourseExamPaper.IdXzMajor);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.PaperDispModeId, 4, concc_CourseExamPaper.PaperDispModeId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.ExamCreateTime, 14, concc_CourseExamPaper.ExamCreateTime);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.CreateUserID, 20, concc_CourseExamPaper.CreateUserID);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.CourseChapterId, 8, concc_CourseExamPaper.CourseChapterId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.UpdDate, 20, concc_CourseExamPaper.UpdDate);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.UpdUserId, 20, concc_CourseExamPaper.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.Memo, 1000, concc_CourseExamPaper.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objcc_CourseExamPaperEN.CourseId, 8, concc_CourseExamPaper.CourseId);
clsCheckSql.CheckFieldForeignKey(objcc_CourseExamPaperEN.IdXzMajor, 8, concc_CourseExamPaper.IdXzMajor);
 objcc_CourseExamPaperEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.CourseId, 8, concc_CourseExamPaper.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.ExamPaperName, 500, concc_CourseExamPaper.ExamPaperName);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.ExamPaperTypeId, 2, concc_CourseExamPaper.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.IdXzMajor, 8, concc_CourseExamPaper.IdXzMajor);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.PaperDispModeId, 4, concc_CourseExamPaper.PaperDispModeId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.ExamCreateTime, 14, concc_CourseExamPaper.ExamCreateTime);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.CreateUserID, 20, concc_CourseExamPaper.CreateUserID);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.CourseChapterId, 8, concc_CourseExamPaper.CourseChapterId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.UpdDate, 20, concc_CourseExamPaper.UpdDate);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.UpdUserId, 20, concc_CourseExamPaper.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.Memo, 1000, concc_CourseExamPaper.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_CourseExamPaperEN.CourseId, 8, concc_CourseExamPaper.CourseId);
clsCheckSql.CheckFieldForeignKey(objcc_CourseExamPaperEN.IdXzMajor, 8, concc_CourseExamPaper.IdXzMajor);
 objcc_CourseExamPaperEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.CourseExamPaperId, 8, concc_CourseExamPaper.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.CourseId, 8, concc_CourseExamPaper.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.ExamPaperName, 500, concc_CourseExamPaper.ExamPaperName);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.ExamPaperTypeId, 2, concc_CourseExamPaper.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.IdXzMajor, 8, concc_CourseExamPaper.IdXzMajor);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.PaperDispModeId, 4, concc_CourseExamPaper.PaperDispModeId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.ExamCreateTime, 14, concc_CourseExamPaper.ExamCreateTime);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.CreateUserID, 20, concc_CourseExamPaper.CreateUserID);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.CourseChapterId, 8, concc_CourseExamPaper.CourseChapterId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.UpdDate, 20, concc_CourseExamPaper.UpdDate);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.UpdUserId, 20, concc_CourseExamPaper.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperEN.Memo, 1000, concc_CourseExamPaper.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_CourseExamPaperEN.CourseExamPaperId, concc_CourseExamPaper.CourseExamPaperId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseExamPaperEN.CourseId, concc_CourseExamPaper.CourseId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseExamPaperEN.ExamPaperName, concc_CourseExamPaper.ExamPaperName);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseExamPaperEN.ExamPaperTypeId, concc_CourseExamPaper.ExamPaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseExamPaperEN.IdXzMajor, concc_CourseExamPaper.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseExamPaperEN.PaperDispModeId, concc_CourseExamPaper.PaperDispModeId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseExamPaperEN.ExamCreateTime, concc_CourseExamPaper.ExamCreateTime);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseExamPaperEN.CreateUserID, concc_CourseExamPaper.CreateUserID);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseExamPaperEN.CourseChapterId, concc_CourseExamPaper.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseExamPaperEN.UpdDate, concc_CourseExamPaper.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseExamPaperEN.UpdUserId, concc_CourseExamPaper.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseExamPaperEN.Memo, concc_CourseExamPaper.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_CourseExamPaperEN.CourseId, 8, concc_CourseExamPaper.CourseId);
clsCheckSql.CheckFieldForeignKey(objcc_CourseExamPaperEN.IdXzMajor, 8, concc_CourseExamPaper.IdXzMajor);
 objcc_CourseExamPaperEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCourseExamPaperId()
{
//获取某学院所有专业信息
string strSQL = "select CourseExamPaperId, ExamPaperName from cc_CourseExamPaper ";
 clsSpecSQLforSql mySql = clscc_CourseExamPaperDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_CourseExamPaper(考卷),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objcc_CourseExamPaperEN.ExamPaperName == null)
{
 sbCondition.AppendFormat(" and ExamPaperName is null");
}
else
{
 sbCondition.AppendFormat(" and ExamPaperName = '{0}'", objcc_CourseExamPaperEN.ExamPaperName);
}
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
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
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
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
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
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_CourseExamPaperEN._CurrTabName);
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
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_CourseExamPaperEN._CurrTabName, strCondition);
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
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
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
 objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}