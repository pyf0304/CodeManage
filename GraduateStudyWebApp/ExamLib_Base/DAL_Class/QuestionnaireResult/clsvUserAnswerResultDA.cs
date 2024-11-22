
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserAnswerResultDA
 表名:vUserAnswerResult(01120022)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:25
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷结果(QuestionnaireResult)
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
 /// v用户答题结果(vUserAnswerResult)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvUserAnswerResultDA : clsCommBase4DA
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
 return clsvUserAnswerResultEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvUserAnswerResultEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUserAnswerResultEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvUserAnswerResultEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvUserAnswerResultEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvUserAnswerResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
strSQL = "Select * from vUserAnswerResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vUserAnswerResult(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvUserAnswerResultDA: GetDataTable_vUserAnswerResult)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
strSQL = "Select * from vUserAnswerResult where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvUserAnswerResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvUserAnswerResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
strSQL = "Select * from vUserAnswerResult where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvUserAnswerResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvUserAnswerResultDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserAnswerResult where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserAnswerResult where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvUserAnswerResultDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vUserAnswerResult where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvUserAnswerResultDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vUserAnswerResult.* from vUserAnswerResult Left Join {1} on {2} where {3} and vUserAnswerResult.MinId not in (Select top {5} vUserAnswerResult.MinId from vUserAnswerResult Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserAnswerResult where {1} and MinId not in (Select top {2} MinId from vUserAnswerResult where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserAnswerResult where {1} and MinId not in (Select top {3} MinId from vUserAnswerResult where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvUserAnswerResultDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vUserAnswerResult.* from vUserAnswerResult Left Join {1} on {2} where {3} and vUserAnswerResult.MinId not in (Select top {5} vUserAnswerResult.MinId from vUserAnswerResult Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserAnswerResult where {1} and MinId not in (Select top {2} MinId from vUserAnswerResult where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserAnswerResult where {1} and MinId not in (Select top {3} MinId from vUserAnswerResult where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvUserAnswerResultEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvUserAnswerResultDA:GetObjLst)", objException.Message));
}
List<clsvUserAnswerResultEN> arrObjLst = new List<clsvUserAnswerResultEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
strSQL = "Select * from vUserAnswerResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResultEN objvUserAnswerResultEN = new clsvUserAnswerResultEN();
try
{
objvUserAnswerResultEN.MinId = TransNullToInt(objRow[convUserAnswerResult.MinId].ToString().Trim()); //MinId
objvUserAnswerResultEN.QuestionId = objRow[convUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResultEN.QuestionIndex = objRow[convUserAnswerResult.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserAnswerResult.QuestionIndex].ToString().Trim()); //题目序号
objvUserAnswerResultEN.QuestionName = objRow[convUserAnswerResult.QuestionName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionName].ToString().Trim(); //题目名称
objvUserAnswerResultEN.QuestionNo = objRow[convUserAnswerResult.QuestionNo] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionNo].ToString().Trim(); //题目编号
objvUserAnswerResultEN.QuestionTypeId = objRow[convUserAnswerResult.QuestionTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeId].ToString().Trim(); //题目类型Id
objvUserAnswerResultEN.QuestionTypeName = objRow[convUserAnswerResult.QuestionTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeName].ToString().Trim(); //题目类型名
objvUserAnswerResultEN.AnswerTypeId = objRow[convUserAnswerResult.AnswerTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeId].ToString().Trim(); //答案类型ID
objvUserAnswerResultEN.AnswerTypeName = objRow[convUserAnswerResult.AnswerTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeName].ToString().Trim(); //答案类型名
objvUserAnswerResultEN.GridTitle = objRow[convUserAnswerResult.GridTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.GridTitle].ToString().Trim(); //表格标题
objvUserAnswerResultEN.AnswerModeId = objRow[convUserAnswerResult.AnswerModeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerModeId].ToString().Trim(); //答案模式Id
objvUserAnswerResultEN.QuestionScore = objRow[convUserAnswerResult.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convUserAnswerResult.QuestionScore].ToString().Trim()); //题目得分
objvUserAnswerResultEN.QuestionnaireSetId = objRow[convUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResultEN.CourseId = objRow[convUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objvUserAnswerResultEN.CourseName = objRow[convUserAnswerResult.CourseName] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseName].ToString().Trim(); //课程名称
objvUserAnswerResultEN.CourseExamPaperId = objRow[convUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvUserAnswerResultEN.AnswerOptionId = objRow[convUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objvUserAnswerResultEN.OptionName = objRow[convUserAnswerResult.OptionName] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionName].ToString().Trim(); //选项名称
objvUserAnswerResultEN.OptionIndex = objRow[convUserAnswerResult.OptionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserAnswerResult.OptionIndex].ToString().Trim()); //选项序号
objvUserAnswerResultEN.OptionTitle = objRow[convUserAnswerResult.OptionTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionTitle].ToString().Trim(); //选项标题
objvUserAnswerResultEN.BatchId = objRow[convUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[convUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objvUserAnswerResultEN.UserId = objRow[convUserAnswerResult.UserId] == DBNull.Value ? null : objRow[convUserAnswerResult.UserId].ToString().Trim(); //用户ID
objvUserAnswerResultEN.UserName = objRow[convUserAnswerResult.UserName] == DBNull.Value ? null : objRow[convUserAnswerResult.UserName].ToString().Trim(); //用户名
objvUserAnswerResultEN.AnswerText = objRow[convUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objvUserAnswerResultEN.AnswerDate = objRow[convUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objvUserAnswerResultEN.AnswerTime = objRow[convUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objvUserAnswerResultEN.AnswerIP = objRow[convUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objvUserAnswerResultEN.IsAccess = TransNullToBool(objRow[convUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objvUserAnswerResultEN.IsAccessC = TransNullToBool(objRow[convUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objvUserAnswerResultEN.IdSchool = objRow[convUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[convUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objvUserAnswerResultEN.School = objRow[convUserAnswerResult.School] == DBNull.Value ? null : objRow[convUserAnswerResult.School].ToString().Trim(); //School
objvUserAnswerResultEN.AnswerMode = objRow[convUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objvUserAnswerResultEN.IsMarking = TransNullToBool(objRow[convUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objvUserAnswerResultEN.IsRight = TransNullToBool(objRow[convUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objvUserAnswerResultEN.Score = objRow[convUserAnswerResult.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convUserAnswerResult.Score].ToString().Trim()); //得分
objvUserAnswerResultEN.MarkTime = objRow[convUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objvUserAnswerResultEN.MarkerId = objRow[convUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objvUserAnswerResultEN.Comment = objRow[convUserAnswerResult.Comment] == DBNull.Value ? null : objRow[convUserAnswerResult.Comment].ToString().Trim(); //批注
objvUserAnswerResultEN.IsAccessKnowledge = TransNullToBool(objRow[convUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvUserAnswerResultEN.UpdDate = objRow[convUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objvUserAnswerResultEN.UpdUser = objRow[convUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objvUserAnswerResultEN.Memo = objRow[convUserAnswerResult.Memo] == DBNull.Value ? null : objRow[convUserAnswerResult.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUserAnswerResultDA: GetObjLst)", objException.Message));
}
objvUserAnswerResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUserAnswerResultEN);
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
public List<clsvUserAnswerResultEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvUserAnswerResultDA:GetObjLstByTabName)", objException.Message));
}
List<clsvUserAnswerResultEN> arrObjLst = new List<clsvUserAnswerResultEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResultEN objvUserAnswerResultEN = new clsvUserAnswerResultEN();
try
{
objvUserAnswerResultEN.MinId = TransNullToInt(objRow[convUserAnswerResult.MinId].ToString().Trim()); //MinId
objvUserAnswerResultEN.QuestionId = objRow[convUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResultEN.QuestionIndex = objRow[convUserAnswerResult.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserAnswerResult.QuestionIndex].ToString().Trim()); //题目序号
objvUserAnswerResultEN.QuestionName = objRow[convUserAnswerResult.QuestionName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionName].ToString().Trim(); //题目名称
objvUserAnswerResultEN.QuestionNo = objRow[convUserAnswerResult.QuestionNo] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionNo].ToString().Trim(); //题目编号
objvUserAnswerResultEN.QuestionTypeId = objRow[convUserAnswerResult.QuestionTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeId].ToString().Trim(); //题目类型Id
objvUserAnswerResultEN.QuestionTypeName = objRow[convUserAnswerResult.QuestionTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeName].ToString().Trim(); //题目类型名
objvUserAnswerResultEN.AnswerTypeId = objRow[convUserAnswerResult.AnswerTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeId].ToString().Trim(); //答案类型ID
objvUserAnswerResultEN.AnswerTypeName = objRow[convUserAnswerResult.AnswerTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeName].ToString().Trim(); //答案类型名
objvUserAnswerResultEN.GridTitle = objRow[convUserAnswerResult.GridTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.GridTitle].ToString().Trim(); //表格标题
objvUserAnswerResultEN.AnswerModeId = objRow[convUserAnswerResult.AnswerModeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerModeId].ToString().Trim(); //答案模式Id
objvUserAnswerResultEN.QuestionScore = objRow[convUserAnswerResult.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convUserAnswerResult.QuestionScore].ToString().Trim()); //题目得分
objvUserAnswerResultEN.QuestionnaireSetId = objRow[convUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResultEN.CourseId = objRow[convUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objvUserAnswerResultEN.CourseName = objRow[convUserAnswerResult.CourseName] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseName].ToString().Trim(); //课程名称
objvUserAnswerResultEN.CourseExamPaperId = objRow[convUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvUserAnswerResultEN.AnswerOptionId = objRow[convUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objvUserAnswerResultEN.OptionName = objRow[convUserAnswerResult.OptionName] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionName].ToString().Trim(); //选项名称
objvUserAnswerResultEN.OptionIndex = objRow[convUserAnswerResult.OptionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserAnswerResult.OptionIndex].ToString().Trim()); //选项序号
objvUserAnswerResultEN.OptionTitle = objRow[convUserAnswerResult.OptionTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionTitle].ToString().Trim(); //选项标题
objvUserAnswerResultEN.BatchId = objRow[convUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[convUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objvUserAnswerResultEN.UserId = objRow[convUserAnswerResult.UserId] == DBNull.Value ? null : objRow[convUserAnswerResult.UserId].ToString().Trim(); //用户ID
objvUserAnswerResultEN.UserName = objRow[convUserAnswerResult.UserName] == DBNull.Value ? null : objRow[convUserAnswerResult.UserName].ToString().Trim(); //用户名
objvUserAnswerResultEN.AnswerText = objRow[convUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objvUserAnswerResultEN.AnswerDate = objRow[convUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objvUserAnswerResultEN.AnswerTime = objRow[convUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objvUserAnswerResultEN.AnswerIP = objRow[convUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objvUserAnswerResultEN.IsAccess = TransNullToBool(objRow[convUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objvUserAnswerResultEN.IsAccessC = TransNullToBool(objRow[convUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objvUserAnswerResultEN.IdSchool = objRow[convUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[convUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objvUserAnswerResultEN.School = objRow[convUserAnswerResult.School] == DBNull.Value ? null : objRow[convUserAnswerResult.School].ToString().Trim(); //School
objvUserAnswerResultEN.AnswerMode = objRow[convUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objvUserAnswerResultEN.IsMarking = TransNullToBool(objRow[convUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objvUserAnswerResultEN.IsRight = TransNullToBool(objRow[convUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objvUserAnswerResultEN.Score = objRow[convUserAnswerResult.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convUserAnswerResult.Score].ToString().Trim()); //得分
objvUserAnswerResultEN.MarkTime = objRow[convUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objvUserAnswerResultEN.MarkerId = objRow[convUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objvUserAnswerResultEN.Comment = objRow[convUserAnswerResult.Comment] == DBNull.Value ? null : objRow[convUserAnswerResult.Comment].ToString().Trim(); //批注
objvUserAnswerResultEN.IsAccessKnowledge = TransNullToBool(objRow[convUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvUserAnswerResultEN.UpdDate = objRow[convUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objvUserAnswerResultEN.UpdUser = objRow[convUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objvUserAnswerResultEN.Memo = objRow[convUserAnswerResult.Memo] == DBNull.Value ? null : objRow[convUserAnswerResult.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUserAnswerResultDA: GetObjLst)", objException.Message));
}
objvUserAnswerResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUserAnswerResultEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvUserAnswerResult(ref clsvUserAnswerResultEN objvUserAnswerResultEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
strSQL = "Select * from vUserAnswerResult where MinId = " + ""+ objvUserAnswerResultEN.MinId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvUserAnswerResultEN.MinId = TransNullToInt(objDT.Rows[0][convUserAnswerResult.MinId].ToString().Trim()); //MinId(字段类型:bigint,字段长度:8,是否可空:True)
 objvUserAnswerResultEN.QuestionId = TransNullToInt(objDT.Rows[0][convUserAnswerResult.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvUserAnswerResultEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convUserAnswerResult.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvUserAnswerResultEN.QuestionName = objDT.Rows[0][convUserAnswerResult.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvUserAnswerResultEN.QuestionNo = objDT.Rows[0][convUserAnswerResult.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvUserAnswerResultEN.QuestionTypeId = objDT.Rows[0][convUserAnswerResult.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvUserAnswerResultEN.QuestionTypeName = objDT.Rows[0][convUserAnswerResult.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserAnswerResultEN.AnswerTypeId = objDT.Rows[0][convUserAnswerResult.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvUserAnswerResultEN.AnswerTypeName = objDT.Rows[0][convUserAnswerResult.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvUserAnswerResultEN.GridTitle = objDT.Rows[0][convUserAnswerResult.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserAnswerResultEN.AnswerModeId = objDT.Rows[0][convUserAnswerResult.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvUserAnswerResultEN.QuestionScore = TransNullToFloat(objDT.Rows[0][convUserAnswerResult.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objvUserAnswerResultEN.QuestionnaireSetId = objDT.Rows[0][convUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objvUserAnswerResultEN.CourseId = objDT.Rows[0][convUserAnswerResult.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvUserAnswerResultEN.CourseName = objDT.Rows[0][convUserAnswerResult.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvUserAnswerResultEN.CourseExamPaperId = objDT.Rows[0][convUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objvUserAnswerResultEN.AnswerOptionId = objDT.Rows[0][convUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objvUserAnswerResultEN.OptionName = objDT.Rows[0][convUserAnswerResult.OptionName].ToString().Trim(); //选项名称(字段类型:varchar,字段长度:4000,是否可空:False)
 objvUserAnswerResultEN.OptionIndex = TransNullToInt(objDT.Rows[0][convUserAnswerResult.OptionIndex].ToString().Trim()); //选项序号(字段类型:int,字段长度:4,是否可空:False)
 objvUserAnswerResultEN.OptionTitle = objDT.Rows[0][convUserAnswerResult.OptionTitle].ToString().Trim(); //选项标题(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserAnswerResultEN.BatchId = objDT.Rows[0][convUserAnswerResult.BatchId].ToString().Trim(); //批次ID(字段类型:char,字段长度:4,是否可空:True)
 objvUserAnswerResultEN.UserId = objDT.Rows[0][convUserAnswerResult.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvUserAnswerResultEN.UserName = objDT.Rows[0][convUserAnswerResult.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserAnswerResultEN.AnswerText = objDT.Rows[0][convUserAnswerResult.AnswerText].ToString().Trim(); //回答文本(字段类型:varchar,字段长度:8000,是否可空:True)
 objvUserAnswerResultEN.AnswerDate = objDT.Rows[0][convUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvUserAnswerResultEN.AnswerTime = objDT.Rows[0][convUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间(字段类型:varchar,字段长度:10,是否可空:True)
 objvUserAnswerResultEN.AnswerIP = objDT.Rows[0][convUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserAnswerResultEN.IsAccess = TransNullToBool(objDT.Rows[0][convUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess(字段类型:bit,字段长度:1,是否可空:True)
 objvUserAnswerResultEN.IsAccessC = TransNullToBool(objDT.Rows[0][convUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC(字段类型:bit,字段长度:1,是否可空:True)
 objvUserAnswerResultEN.IdSchool = objDT.Rows[0][convUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objvUserAnswerResultEN.School = objDT.Rows[0][convUserAnswerResult.School].ToString().Trim(); //School(字段类型:varchar,字段长度:50,是否可空:True)
 objvUserAnswerResultEN.AnswerMode = TransNullToInt(objDT.Rows[0][convUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode(字段类型:int,字段长度:4,是否可空:True)
 objvUserAnswerResultEN.IsMarking = TransNullToBool(objDT.Rows[0][convUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅(字段类型:bit,字段长度:1,是否可空:True)
 objvUserAnswerResultEN.IsRight = TransNullToBool(objDT.Rows[0][convUserAnswerResult.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objvUserAnswerResultEN.Score = TransNullToDouble(objDT.Rows[0][convUserAnswerResult.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objvUserAnswerResultEN.MarkTime = objDT.Rows[0][convUserAnswerResult.MarkTime].ToString().Trim(); //批改时间(字段类型:varchar,字段长度:14,是否可空:True)
 objvUserAnswerResultEN.MarkerId = objDT.Rows[0][convUserAnswerResult.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserAnswerResultEN.Comment = objDT.Rows[0][convUserAnswerResult.Comment].ToString().Trim(); //批注(字段类型:text,字段长度:2147483647,是否可空:True)
 objvUserAnswerResultEN.IsAccessKnowledge = TransNullToBool(objDT.Rows[0][convUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点(字段类型:bit,字段长度:1,是否可空:True)
 objvUserAnswerResultEN.UpdDate = objDT.Rows[0][convUserAnswerResult.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserAnswerResultEN.UpdUser = objDT.Rows[0][convUserAnswerResult.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserAnswerResultEN.Memo = objDT.Rows[0][convUserAnswerResult.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvUserAnswerResultDA: GetvUserAnswerResult)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngMinId">表关键字</param>
 /// <returns>表对象</returns>
public clsvUserAnswerResultEN GetObjByMinId(long lngMinId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
strSQL = "Select * from vUserAnswerResult where MinId = " + ""+ lngMinId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvUserAnswerResultEN objvUserAnswerResultEN = new clsvUserAnswerResultEN();
try
{
 objvUserAnswerResultEN.MinId = Int32.Parse(objRow[convUserAnswerResult.MinId].ToString().Trim()); //MinId(字段类型:bigint,字段长度:8,是否可空:True)
 objvUserAnswerResultEN.QuestionId = objRow[convUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvUserAnswerResultEN.QuestionIndex = objRow[convUserAnswerResult.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvUserAnswerResultEN.QuestionName = objRow[convUserAnswerResult.QuestionName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvUserAnswerResultEN.QuestionNo = objRow[convUserAnswerResult.QuestionNo] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvUserAnswerResultEN.QuestionTypeId = objRow[convUserAnswerResult.QuestionTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvUserAnswerResultEN.QuestionTypeName = objRow[convUserAnswerResult.QuestionTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserAnswerResultEN.AnswerTypeId = objRow[convUserAnswerResult.AnswerTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvUserAnswerResultEN.AnswerTypeName = objRow[convUserAnswerResult.AnswerTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvUserAnswerResultEN.GridTitle = objRow[convUserAnswerResult.GridTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserAnswerResultEN.AnswerModeId = objRow[convUserAnswerResult.AnswerModeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvUserAnswerResultEN.QuestionScore = objRow[convUserAnswerResult.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convUserAnswerResult.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objvUserAnswerResultEN.QuestionnaireSetId = objRow[convUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objvUserAnswerResultEN.CourseId = objRow[convUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvUserAnswerResultEN.CourseName = objRow[convUserAnswerResult.CourseName] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvUserAnswerResultEN.CourseExamPaperId = objRow[convUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objvUserAnswerResultEN.AnswerOptionId = objRow[convUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objvUserAnswerResultEN.OptionName = objRow[convUserAnswerResult.OptionName] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionName].ToString().Trim(); //选项名称(字段类型:varchar,字段长度:4000,是否可空:False)
 objvUserAnswerResultEN.OptionIndex = objRow[convUserAnswerResult.OptionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.OptionIndex].ToString().Trim()); //选项序号(字段类型:int,字段长度:4,是否可空:False)
 objvUserAnswerResultEN.OptionTitle = objRow[convUserAnswerResult.OptionTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionTitle].ToString().Trim(); //选项标题(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserAnswerResultEN.BatchId = objRow[convUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[convUserAnswerResult.BatchId].ToString().Trim(); //批次ID(字段类型:char,字段长度:4,是否可空:True)
 objvUserAnswerResultEN.UserId = objRow[convUserAnswerResult.UserId] == DBNull.Value ? null : objRow[convUserAnswerResult.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvUserAnswerResultEN.UserName = objRow[convUserAnswerResult.UserName] == DBNull.Value ? null : objRow[convUserAnswerResult.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserAnswerResultEN.AnswerText = objRow[convUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerText].ToString().Trim(); //回答文本(字段类型:varchar,字段长度:8000,是否可空:True)
 objvUserAnswerResultEN.AnswerDate = objRow[convUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvUserAnswerResultEN.AnswerTime = objRow[convUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间(字段类型:varchar,字段长度:10,是否可空:True)
 objvUserAnswerResultEN.AnswerIP = objRow[convUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess(字段类型:bit,字段长度:1,是否可空:True)
 objvUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC(字段类型:bit,字段长度:1,是否可空:True)
 objvUserAnswerResultEN.IdSchool = objRow[convUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[convUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objvUserAnswerResultEN.School = objRow[convUserAnswerResult.School] == DBNull.Value ? null : objRow[convUserAnswerResult.School].ToString().Trim(); //School(字段类型:varchar,字段长度:50,是否可空:True)
 objvUserAnswerResultEN.AnswerMode = objRow[convUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode(字段类型:int,字段长度:4,是否可空:True)
 objvUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅(字段类型:bit,字段长度:1,是否可空:True)
 objvUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objvUserAnswerResultEN.Score = objRow[convUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convUserAnswerResult.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objvUserAnswerResultEN.MarkTime = objRow[convUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkTime].ToString().Trim(); //批改时间(字段类型:varchar,字段长度:14,是否可空:True)
 objvUserAnswerResultEN.MarkerId = objRow[convUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserAnswerResultEN.Comment = objRow[convUserAnswerResult.Comment] == DBNull.Value ? null : objRow[convUserAnswerResult.Comment].ToString().Trim(); //批注(字段类型:text,字段长度:2147483647,是否可空:True)
 objvUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[convUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点(字段类型:bit,字段长度:1,是否可空:True)
 objvUserAnswerResultEN.UpdDate = objRow[convUserAnswerResult.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserAnswerResultEN.UpdUser = objRow[convUserAnswerResult.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserAnswerResultEN.Memo = objRow[convUserAnswerResult.Memo] == DBNull.Value ? null : objRow[convUserAnswerResult.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvUserAnswerResultDA: GetObjByMinId)", objException.Message));
}
return objvUserAnswerResultEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvUserAnswerResultEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvUserAnswerResultDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
strSQL = "Select * from vUserAnswerResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvUserAnswerResultEN objvUserAnswerResultEN = new clsvUserAnswerResultEN()
{
MinId = TransNullToInt(objRow[convUserAnswerResult.MinId].ToString().Trim()), //MinId
QuestionId = objRow[convUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convUserAnswerResult.QuestionId].ToString().Trim()), //题目Id
QuestionIndex = objRow[convUserAnswerResult.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserAnswerResult.QuestionIndex].ToString().Trim()), //题目序号
QuestionName = objRow[convUserAnswerResult.QuestionName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionName].ToString().Trim(), //题目名称
QuestionNo = objRow[convUserAnswerResult.QuestionNo] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionNo].ToString().Trim(), //题目编号
QuestionTypeId = objRow[convUserAnswerResult.QuestionTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionTypeName = objRow[convUserAnswerResult.QuestionTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeName].ToString().Trim(), //题目类型名
AnswerTypeId = objRow[convUserAnswerResult.AnswerTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeId].ToString().Trim(), //答案类型ID
AnswerTypeName = objRow[convUserAnswerResult.AnswerTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeName].ToString().Trim(), //答案类型名
GridTitle = objRow[convUserAnswerResult.GridTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.GridTitle].ToString().Trim(), //表格标题
AnswerModeId = objRow[convUserAnswerResult.AnswerModeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerModeId].ToString().Trim(), //答案模式Id
QuestionScore = objRow[convUserAnswerResult.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convUserAnswerResult.QuestionScore].ToString().Trim()), //题目得分
QuestionnaireSetId = objRow[convUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionnaireSetId].ToString().Trim(), //问卷集ID
CourseId = objRow[convUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseId].ToString().Trim(), //课程Id
CourseName = objRow[convUserAnswerResult.CourseName] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseName].ToString().Trim(), //课程名称
CourseExamPaperId = objRow[convUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseExamPaperId].ToString().Trim(), //考卷流水号
AnswerOptionId = objRow[convUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerOptionId].ToString().Trim(), //回答选项Id
OptionName = objRow[convUserAnswerResult.OptionName] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionName].ToString().Trim(), //选项名称
OptionIndex = objRow[convUserAnswerResult.OptionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserAnswerResult.OptionIndex].ToString().Trim()), //选项序号
OptionTitle = objRow[convUserAnswerResult.OptionTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionTitle].ToString().Trim(), //选项标题
BatchId = objRow[convUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[convUserAnswerResult.BatchId].ToString().Trim(), //批次ID
UserId = objRow[convUserAnswerResult.UserId] == DBNull.Value ? null : objRow[convUserAnswerResult.UserId].ToString().Trim(), //用户ID
UserName = objRow[convUserAnswerResult.UserName] == DBNull.Value ? null : objRow[convUserAnswerResult.UserName].ToString().Trim(), //用户名
AnswerText = objRow[convUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerText].ToString().Trim(), //回答文本
AnswerDate = objRow[convUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerDate].ToString().Trim(), //回答日期
AnswerTime = objRow[convUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTime].ToString().Trim(), //回答时间
AnswerIP = objRow[convUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerIP].ToString().Trim(), //回答IP
IsAccess = TransNullToBool(objRow[convUserAnswerResult.IsAccess].ToString().Trim()), //IsAccess
IsAccessC = TransNullToBool(objRow[convUserAnswerResult.IsAccessC].ToString().Trim()), //IsAccessC
IdSchool = objRow[convUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[convUserAnswerResult.IdSchool].ToString().Trim(), //学校流水号
School = objRow[convUserAnswerResult.School] == DBNull.Value ? null : objRow[convUserAnswerResult.School].ToString().Trim(), //School
AnswerMode = objRow[convUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserAnswerResult.AnswerMode].ToString().Trim()), //AnswerMode
IsMarking = TransNullToBool(objRow[convUserAnswerResult.IsMarking].ToString().Trim()), //是否批阅
IsRight = TransNullToBool(objRow[convUserAnswerResult.IsRight].ToString().Trim()), //是否正确
Score = objRow[convUserAnswerResult.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convUserAnswerResult.Score].ToString().Trim()), //得分
MarkTime = objRow[convUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkTime].ToString().Trim(), //批改时间
MarkerId = objRow[convUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkerId].ToString().Trim(), //打分者
Comment = objRow[convUserAnswerResult.Comment] == DBNull.Value ? null : objRow[convUserAnswerResult.Comment].ToString().Trim(), //批注
IsAccessKnowledge = TransNullToBool(objRow[convUserAnswerResult.IsAccessKnowledge].ToString().Trim()), //是否处理知识点
UpdDate = objRow[convUserAnswerResult.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convUserAnswerResult.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convUserAnswerResult.Memo] == DBNull.Value ? null : objRow[convUserAnswerResult.Memo].ToString().Trim() //备注
};
objvUserAnswerResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserAnswerResultEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvUserAnswerResultDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvUserAnswerResultEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUserAnswerResultEN objvUserAnswerResultEN = new clsvUserAnswerResultEN();
try
{
objvUserAnswerResultEN.MinId = TransNullToInt(objRow[convUserAnswerResult.MinId].ToString().Trim()); //MinId
objvUserAnswerResultEN.QuestionId = objRow[convUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResultEN.QuestionIndex = objRow[convUserAnswerResult.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserAnswerResult.QuestionIndex].ToString().Trim()); //题目序号
objvUserAnswerResultEN.QuestionName = objRow[convUserAnswerResult.QuestionName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionName].ToString().Trim(); //题目名称
objvUserAnswerResultEN.QuestionNo = objRow[convUserAnswerResult.QuestionNo] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionNo].ToString().Trim(); //题目编号
objvUserAnswerResultEN.QuestionTypeId = objRow[convUserAnswerResult.QuestionTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeId].ToString().Trim(); //题目类型Id
objvUserAnswerResultEN.QuestionTypeName = objRow[convUserAnswerResult.QuestionTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeName].ToString().Trim(); //题目类型名
objvUserAnswerResultEN.AnswerTypeId = objRow[convUserAnswerResult.AnswerTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeId].ToString().Trim(); //答案类型ID
objvUserAnswerResultEN.AnswerTypeName = objRow[convUserAnswerResult.AnswerTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeName].ToString().Trim(); //答案类型名
objvUserAnswerResultEN.GridTitle = objRow[convUserAnswerResult.GridTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.GridTitle].ToString().Trim(); //表格标题
objvUserAnswerResultEN.AnswerModeId = objRow[convUserAnswerResult.AnswerModeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerModeId].ToString().Trim(); //答案模式Id
objvUserAnswerResultEN.QuestionScore = objRow[convUserAnswerResult.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convUserAnswerResult.QuestionScore].ToString().Trim()); //题目得分
objvUserAnswerResultEN.QuestionnaireSetId = objRow[convUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResultEN.CourseId = objRow[convUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objvUserAnswerResultEN.CourseName = objRow[convUserAnswerResult.CourseName] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseName].ToString().Trim(); //课程名称
objvUserAnswerResultEN.CourseExamPaperId = objRow[convUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvUserAnswerResultEN.AnswerOptionId = objRow[convUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objvUserAnswerResultEN.OptionName = objRow[convUserAnswerResult.OptionName] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionName].ToString().Trim(); //选项名称
objvUserAnswerResultEN.OptionIndex = objRow[convUserAnswerResult.OptionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserAnswerResult.OptionIndex].ToString().Trim()); //选项序号
objvUserAnswerResultEN.OptionTitle = objRow[convUserAnswerResult.OptionTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionTitle].ToString().Trim(); //选项标题
objvUserAnswerResultEN.BatchId = objRow[convUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[convUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objvUserAnswerResultEN.UserId = objRow[convUserAnswerResult.UserId] == DBNull.Value ? null : objRow[convUserAnswerResult.UserId].ToString().Trim(); //用户ID
objvUserAnswerResultEN.UserName = objRow[convUserAnswerResult.UserName] == DBNull.Value ? null : objRow[convUserAnswerResult.UserName].ToString().Trim(); //用户名
objvUserAnswerResultEN.AnswerText = objRow[convUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objvUserAnswerResultEN.AnswerDate = objRow[convUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objvUserAnswerResultEN.AnswerTime = objRow[convUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objvUserAnswerResultEN.AnswerIP = objRow[convUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objvUserAnswerResultEN.IsAccess = TransNullToBool(objRow[convUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objvUserAnswerResultEN.IsAccessC = TransNullToBool(objRow[convUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objvUserAnswerResultEN.IdSchool = objRow[convUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[convUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objvUserAnswerResultEN.School = objRow[convUserAnswerResult.School] == DBNull.Value ? null : objRow[convUserAnswerResult.School].ToString().Trim(); //School
objvUserAnswerResultEN.AnswerMode = objRow[convUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objvUserAnswerResultEN.IsMarking = TransNullToBool(objRow[convUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objvUserAnswerResultEN.IsRight = TransNullToBool(objRow[convUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objvUserAnswerResultEN.Score = objRow[convUserAnswerResult.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convUserAnswerResult.Score].ToString().Trim()); //得分
objvUserAnswerResultEN.MarkTime = objRow[convUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objvUserAnswerResultEN.MarkerId = objRow[convUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objvUserAnswerResultEN.Comment = objRow[convUserAnswerResult.Comment] == DBNull.Value ? null : objRow[convUserAnswerResult.Comment].ToString().Trim(); //批注
objvUserAnswerResultEN.IsAccessKnowledge = TransNullToBool(objRow[convUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvUserAnswerResultEN.UpdDate = objRow[convUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objvUserAnswerResultEN.UpdUser = objRow[convUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objvUserAnswerResultEN.Memo = objRow[convUserAnswerResult.Memo] == DBNull.Value ? null : objRow[convUserAnswerResult.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvUserAnswerResultDA: GetObjByDataRowvUserAnswerResult)", objException.Message));
}
objvUserAnswerResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserAnswerResultEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvUserAnswerResultEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUserAnswerResultEN objvUserAnswerResultEN = new clsvUserAnswerResultEN();
try
{
objvUserAnswerResultEN.MinId = TransNullToInt(objRow[convUserAnswerResult.MinId].ToString().Trim()); //MinId
objvUserAnswerResultEN.QuestionId = objRow[convUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResultEN.QuestionIndex = objRow[convUserAnswerResult.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserAnswerResult.QuestionIndex].ToString().Trim()); //题目序号
objvUserAnswerResultEN.QuestionName = objRow[convUserAnswerResult.QuestionName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionName].ToString().Trim(); //题目名称
objvUserAnswerResultEN.QuestionNo = objRow[convUserAnswerResult.QuestionNo] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionNo].ToString().Trim(); //题目编号
objvUserAnswerResultEN.QuestionTypeId = objRow[convUserAnswerResult.QuestionTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeId].ToString().Trim(); //题目类型Id
objvUserAnswerResultEN.QuestionTypeName = objRow[convUserAnswerResult.QuestionTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionTypeName].ToString().Trim(); //题目类型名
objvUserAnswerResultEN.AnswerTypeId = objRow[convUserAnswerResult.AnswerTypeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeId].ToString().Trim(); //答案类型ID
objvUserAnswerResultEN.AnswerTypeName = objRow[convUserAnswerResult.AnswerTypeName] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTypeName].ToString().Trim(); //答案类型名
objvUserAnswerResultEN.GridTitle = objRow[convUserAnswerResult.GridTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.GridTitle].ToString().Trim(); //表格标题
objvUserAnswerResultEN.AnswerModeId = objRow[convUserAnswerResult.AnswerModeId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerModeId].ToString().Trim(); //答案模式Id
objvUserAnswerResultEN.QuestionScore = objRow[convUserAnswerResult.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convUserAnswerResult.QuestionScore].ToString().Trim()); //题目得分
objvUserAnswerResultEN.QuestionnaireSetId = objRow[convUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResultEN.CourseId = objRow[convUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objvUserAnswerResultEN.CourseName = objRow[convUserAnswerResult.CourseName] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseName].ToString().Trim(); //课程名称
objvUserAnswerResultEN.CourseExamPaperId = objRow[convUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[convUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvUserAnswerResultEN.AnswerOptionId = objRow[convUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objvUserAnswerResultEN.OptionName = objRow[convUserAnswerResult.OptionName] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionName].ToString().Trim(); //选项名称
objvUserAnswerResultEN.OptionIndex = objRow[convUserAnswerResult.OptionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserAnswerResult.OptionIndex].ToString().Trim()); //选项序号
objvUserAnswerResultEN.OptionTitle = objRow[convUserAnswerResult.OptionTitle] == DBNull.Value ? null : objRow[convUserAnswerResult.OptionTitle].ToString().Trim(); //选项标题
objvUserAnswerResultEN.BatchId = objRow[convUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[convUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objvUserAnswerResultEN.UserId = objRow[convUserAnswerResult.UserId] == DBNull.Value ? null : objRow[convUserAnswerResult.UserId].ToString().Trim(); //用户ID
objvUserAnswerResultEN.UserName = objRow[convUserAnswerResult.UserName] == DBNull.Value ? null : objRow[convUserAnswerResult.UserName].ToString().Trim(); //用户名
objvUserAnswerResultEN.AnswerText = objRow[convUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objvUserAnswerResultEN.AnswerDate = objRow[convUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objvUserAnswerResultEN.AnswerTime = objRow[convUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objvUserAnswerResultEN.AnswerIP = objRow[convUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[convUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objvUserAnswerResultEN.IsAccess = TransNullToBool(objRow[convUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objvUserAnswerResultEN.IsAccessC = TransNullToBool(objRow[convUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objvUserAnswerResultEN.IdSchool = objRow[convUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[convUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objvUserAnswerResultEN.School = objRow[convUserAnswerResult.School] == DBNull.Value ? null : objRow[convUserAnswerResult.School].ToString().Trim(); //School
objvUserAnswerResultEN.AnswerMode = objRow[convUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objvUserAnswerResultEN.IsMarking = TransNullToBool(objRow[convUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objvUserAnswerResultEN.IsRight = TransNullToBool(objRow[convUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objvUserAnswerResultEN.Score = objRow[convUserAnswerResult.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convUserAnswerResult.Score].ToString().Trim()); //得分
objvUserAnswerResultEN.MarkTime = objRow[convUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objvUserAnswerResultEN.MarkerId = objRow[convUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[convUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objvUserAnswerResultEN.Comment = objRow[convUserAnswerResult.Comment] == DBNull.Value ? null : objRow[convUserAnswerResult.Comment].ToString().Trim(); //批注
objvUserAnswerResultEN.IsAccessKnowledge = TransNullToBool(objRow[convUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objvUserAnswerResultEN.UpdDate = objRow[convUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objvUserAnswerResultEN.UpdUser = objRow[convUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objvUserAnswerResultEN.Memo = objRow[convUserAnswerResult.Memo] == DBNull.Value ? null : objRow[convUserAnswerResult.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvUserAnswerResultDA: GetObjByDataRow)", objException.Message));
}
objvUserAnswerResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserAnswerResultEN;
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
objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUserAnswerResultEN._CurrTabName, convUserAnswerResult.MinId, 8, "");
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
objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUserAnswerResultEN._CurrTabName, convUserAnswerResult.MinId, 8, strPrefix);
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
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select MinId from vUserAnswerResult where " + strCondition;
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
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select MinId from vUserAnswerResult where " + strCondition;
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
 /// <param name = "lngMinId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngMinId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUserAnswerResult", "MinId = " + ""+ lngMinId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvUserAnswerResultDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUserAnswerResult", strCondition))
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
objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vUserAnswerResult");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvUserAnswerResultENS">源对象</param>
 /// <param name = "objvUserAnswerResultENT">目标对象</param>
public void CopyTo(clsvUserAnswerResultEN objvUserAnswerResultENS, clsvUserAnswerResultEN objvUserAnswerResultENT)
{
objvUserAnswerResultENT.MinId = objvUserAnswerResultENS.MinId; //MinId
objvUserAnswerResultENT.QuestionId = objvUserAnswerResultENS.QuestionId; //题目Id
objvUserAnswerResultENT.QuestionIndex = objvUserAnswerResultENS.QuestionIndex; //题目序号
objvUserAnswerResultENT.QuestionName = objvUserAnswerResultENS.QuestionName; //题目名称
objvUserAnswerResultENT.QuestionNo = objvUserAnswerResultENS.QuestionNo; //题目编号
objvUserAnswerResultENT.QuestionTypeId = objvUserAnswerResultENS.QuestionTypeId; //题目类型Id
objvUserAnswerResultENT.QuestionTypeName = objvUserAnswerResultENS.QuestionTypeName; //题目类型名
objvUserAnswerResultENT.AnswerTypeId = objvUserAnswerResultENS.AnswerTypeId; //答案类型ID
objvUserAnswerResultENT.AnswerTypeName = objvUserAnswerResultENS.AnswerTypeName; //答案类型名
objvUserAnswerResultENT.GridTitle = objvUserAnswerResultENS.GridTitle; //表格标题
objvUserAnswerResultENT.AnswerModeId = objvUserAnswerResultENS.AnswerModeId; //答案模式Id
objvUserAnswerResultENT.QuestionScore = objvUserAnswerResultENS.QuestionScore; //题目得分
objvUserAnswerResultENT.QuestionnaireSetId = objvUserAnswerResultENS.QuestionnaireSetId; //问卷集ID
objvUserAnswerResultENT.CourseId = objvUserAnswerResultENS.CourseId; //课程Id
objvUserAnswerResultENT.CourseName = objvUserAnswerResultENS.CourseName; //课程名称
objvUserAnswerResultENT.CourseExamPaperId = objvUserAnswerResultENS.CourseExamPaperId; //考卷流水号
objvUserAnswerResultENT.AnswerOptionId = objvUserAnswerResultENS.AnswerOptionId; //回答选项Id
objvUserAnswerResultENT.OptionName = objvUserAnswerResultENS.OptionName; //选项名称
objvUserAnswerResultENT.OptionIndex = objvUserAnswerResultENS.OptionIndex; //选项序号
objvUserAnswerResultENT.OptionTitle = objvUserAnswerResultENS.OptionTitle; //选项标题
objvUserAnswerResultENT.BatchId = objvUserAnswerResultENS.BatchId; //批次ID
objvUserAnswerResultENT.UserId = objvUserAnswerResultENS.UserId; //用户ID
objvUserAnswerResultENT.UserName = objvUserAnswerResultENS.UserName; //用户名
objvUserAnswerResultENT.AnswerText = objvUserAnswerResultENS.AnswerText; //回答文本
objvUserAnswerResultENT.AnswerDate = objvUserAnswerResultENS.AnswerDate; //回答日期
objvUserAnswerResultENT.AnswerTime = objvUserAnswerResultENS.AnswerTime; //回答时间
objvUserAnswerResultENT.AnswerIP = objvUserAnswerResultENS.AnswerIP; //回答IP
objvUserAnswerResultENT.IsAccess = objvUserAnswerResultENS.IsAccess; //IsAccess
objvUserAnswerResultENT.IsAccessC = objvUserAnswerResultENS.IsAccessC; //IsAccessC
objvUserAnswerResultENT.IdSchool = objvUserAnswerResultENS.IdSchool; //学校流水号
objvUserAnswerResultENT.School = objvUserAnswerResultENS.School; //School
objvUserAnswerResultENT.AnswerMode = objvUserAnswerResultENS.AnswerMode; //AnswerMode
objvUserAnswerResultENT.IsMarking = objvUserAnswerResultENS.IsMarking; //是否批阅
objvUserAnswerResultENT.IsRight = objvUserAnswerResultENS.IsRight; //是否正确
objvUserAnswerResultENT.Score = objvUserAnswerResultENS.Score; //得分
objvUserAnswerResultENT.MarkTime = objvUserAnswerResultENS.MarkTime; //批改时间
objvUserAnswerResultENT.MarkerId = objvUserAnswerResultENS.MarkerId; //打分者
objvUserAnswerResultENT.Comment = objvUserAnswerResultENS.Comment; //批注
objvUserAnswerResultENT.IsAccessKnowledge = objvUserAnswerResultENS.IsAccessKnowledge; //是否处理知识点
objvUserAnswerResultENT.UpdDate = objvUserAnswerResultENS.UpdDate; //修改日期
objvUserAnswerResultENT.UpdUser = objvUserAnswerResultENS.UpdUser; //修改人
objvUserAnswerResultENT.Memo = objvUserAnswerResultENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvUserAnswerResultEN objvUserAnswerResultEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.QuestionName, 500, convUserAnswerResult.QuestionName);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.QuestionNo, 10, convUserAnswerResult.QuestionNo);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.QuestionTypeId, 2, convUserAnswerResult.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.QuestionTypeName, 20, convUserAnswerResult.QuestionTypeName);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.AnswerTypeId, 2, convUserAnswerResult.AnswerTypeId);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.AnswerTypeName, 50, convUserAnswerResult.AnswerTypeName);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.GridTitle, 30, convUserAnswerResult.GridTitle);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.AnswerModeId, 4, convUserAnswerResult.AnswerModeId);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.QuestionnaireSetId, 4, convUserAnswerResult.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.CourseId, 8, convUserAnswerResult.CourseId);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.CourseName, 100, convUserAnswerResult.CourseName);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.CourseExamPaperId, 8, convUserAnswerResult.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.AnswerOptionId, 8, convUserAnswerResult.AnswerOptionId);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.OptionName, 4000, convUserAnswerResult.OptionName);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.OptionTitle, 20, convUserAnswerResult.OptionTitle);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.BatchId, 4, convUserAnswerResult.BatchId);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.UserId, 18, convUserAnswerResult.UserId);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.UserName, 30, convUserAnswerResult.UserName);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.AnswerText, 8000, convUserAnswerResult.AnswerText);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.AnswerDate, 8, convUserAnswerResult.AnswerDate);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.AnswerTime, 10, convUserAnswerResult.AnswerTime);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.AnswerIP, 30, convUserAnswerResult.AnswerIP);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.IdSchool, 4, convUserAnswerResult.IdSchool);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.School, 50, convUserAnswerResult.School);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.MarkTime, 14, convUserAnswerResult.MarkTime);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.MarkerId, 20, convUserAnswerResult.MarkerId);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.UpdDate, 20, convUserAnswerResult.UpdDate);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.UpdUser, 20, convUserAnswerResult.UpdUser);
clsCheckSql.CheckFieldLen(objvUserAnswerResultEN.Memo, 1000, convUserAnswerResult.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.QuestionName, convUserAnswerResult.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.QuestionNo, convUserAnswerResult.QuestionNo);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.QuestionTypeId, convUserAnswerResult.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.QuestionTypeName, convUserAnswerResult.QuestionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.AnswerTypeId, convUserAnswerResult.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.AnswerTypeName, convUserAnswerResult.AnswerTypeName);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.GridTitle, convUserAnswerResult.GridTitle);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.AnswerModeId, convUserAnswerResult.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.QuestionnaireSetId, convUserAnswerResult.QuestionnaireSetId);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.CourseId, convUserAnswerResult.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.CourseName, convUserAnswerResult.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.CourseExamPaperId, convUserAnswerResult.CourseExamPaperId);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.AnswerOptionId, convUserAnswerResult.AnswerOptionId);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.OptionName, convUserAnswerResult.OptionName);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.OptionTitle, convUserAnswerResult.OptionTitle);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.BatchId, convUserAnswerResult.BatchId);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.UserId, convUserAnswerResult.UserId);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.UserName, convUserAnswerResult.UserName);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.AnswerText, convUserAnswerResult.AnswerText);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.AnswerDate, convUserAnswerResult.AnswerDate);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.AnswerTime, convUserAnswerResult.AnswerTime);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.AnswerIP, convUserAnswerResult.AnswerIP);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.IdSchool, convUserAnswerResult.IdSchool);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.School, convUserAnswerResult.School);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.MarkTime, convUserAnswerResult.MarkTime);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.MarkerId, convUserAnswerResult.MarkerId);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.UpdDate, convUserAnswerResult.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.UpdUser, convUserAnswerResult.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvUserAnswerResultEN.Memo, convUserAnswerResult.Memo);
//检查外键字段长度
 objvUserAnswerResultEN._IsCheckProperty = true;
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
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
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
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
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
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUserAnswerResultEN._CurrTabName);
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
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUserAnswerResultEN._CurrTabName, strCondition);
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
 objSQL = clsvUserAnswerResultDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}