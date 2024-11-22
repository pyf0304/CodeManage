
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserAnswerResultDA
 表名:UserAnswerResult(01120032)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:26
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
 /// 用户答题结果(UserAnswerResult)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsUserAnswerResultDA : clsCommBase4DA
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
 return clsUserAnswerResultEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsUserAnswerResultEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserAnswerResultEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsUserAnswerResultEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsUserAnswerResultEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsUserAnswerResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
strSQL = "Select * from UserAnswerResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_UserAnswerResult(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsUserAnswerResultDA: GetDataTable_UserAnswerResult)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
strSQL = "Select * from UserAnswerResult where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsUserAnswerResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsUserAnswerResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
strSQL = "Select * from UserAnswerResult where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsUserAnswerResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsUserAnswerResultDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserAnswerResult where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserAnswerResult where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsUserAnswerResultDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from UserAnswerResult where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsUserAnswerResultDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} UserAnswerResult.* from UserAnswerResult Left Join {1} on {2} where {3} and UserAnswerResult.MinId not in (Select top {5} UserAnswerResult.MinId from UserAnswerResult Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserAnswerResult where {1} and MinId not in (Select top {2} MinId from UserAnswerResult where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserAnswerResult where {1} and MinId not in (Select top {3} MinId from UserAnswerResult where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsUserAnswerResultDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} UserAnswerResult.* from UserAnswerResult Left Join {1} on {2} where {3} and UserAnswerResult.MinId not in (Select top {5} UserAnswerResult.MinId from UserAnswerResult Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserAnswerResult where {1} and MinId not in (Select top {2} MinId from UserAnswerResult where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserAnswerResult where {1} and MinId not in (Select top {3} MinId from UserAnswerResult where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsUserAnswerResultEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsUserAnswerResultDA:GetObjLst)", objException.Message));
}
List<clsUserAnswerResultEN> arrObjLst = new List<clsUserAnswerResultEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
strSQL = "Select * from UserAnswerResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserAnswerResultEN objUserAnswerResultEN = new clsUserAnswerResultEN();
try
{
objUserAnswerResultEN.MinId = TransNullToInt(objRow[conUserAnswerResult.MinId].ToString().Trim()); //MinId
objUserAnswerResultEN.QuestionId = objRow[conUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objUserAnswerResultEN.CourseId = objRow[conUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objUserAnswerResultEN.IdCurrEduCls = objRow[conUserAnswerResult.IdCurrEduCls] == DBNull.Value ? null : objRow[conUserAnswerResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objUserAnswerResultEN.ExamBatchNo = objRow[conUserAnswerResult.ExamBatchNo] == DBNull.Value ? null : objRow[conUserAnswerResult.ExamBatchNo].ToString().Trim(); //学生批次号
objUserAnswerResultEN.CourseExamPaperId = objRow[conUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objUserAnswerResultEN.AnswerOptionId = objRow[conUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objUserAnswerResultEN.BatchId = objRow[conUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[conUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objUserAnswerResultEN.UserId = objRow[conUserAnswerResult.UserId] == DBNull.Value ? null : objRow[conUserAnswerResult.UserId].ToString().Trim(); //用户ID
objUserAnswerResultEN.AnswerText = objRow[conUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objUserAnswerResultEN.AnswerDate = objRow[conUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objUserAnswerResultEN.AnswerTime = objRow[conUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objUserAnswerResultEN.AnswerIP = objRow[conUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objUserAnswerResultEN.IsAccess = TransNullToBool(objRow[conUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objUserAnswerResultEN.IsAccessC = TransNullToBool(objRow[conUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objUserAnswerResultEN.IdSchool = objRow[conUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[conUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objUserAnswerResultEN.School = objRow[conUserAnswerResult.School] == DBNull.Value ? null : objRow[conUserAnswerResult.School].ToString().Trim(); //School
objUserAnswerResultEN.AnswerMode = objRow[conUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objUserAnswerResultEN.IsMarking = TransNullToBool(objRow[conUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objUserAnswerResultEN.IsRight = TransNullToBool(objRow[conUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objUserAnswerResultEN.Score = objRow[conUserAnswerResult.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conUserAnswerResult.Score].ToString().Trim()); //得分
objUserAnswerResultEN.MarkTime = objRow[conUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objUserAnswerResultEN.MarkerId = objRow[conUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objUserAnswerResultEN.Comment = objRow[conUserAnswerResult.Comment] == DBNull.Value ? null : objRow[conUserAnswerResult.Comment].ToString().Trim(); //批注
objUserAnswerResultEN.IsAccessKnowledge = TransNullToBool(objRow[conUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objUserAnswerResultEN.AnswerId = objRow[conUserAnswerResult.AnswerId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUserAnswerResult.AnswerId].ToString().Trim()); //问答ID
objUserAnswerResultEN.AnswerMultiOption = objRow[conUserAnswerResult.AnswerMultiOption] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerMultiOption].ToString().Trim(); //多选项答案
objUserAnswerResultEN.UpdDate = objRow[conUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objUserAnswerResultEN.UpdUser = objRow[conUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objUserAnswerResultEN.Memo = objRow[conUserAnswerResult.Memo] == DBNull.Value ? null : objRow[conUserAnswerResult.Memo].ToString().Trim(); //备注
objUserAnswerResultEN.QuestionnaireSetId = objRow[conUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[conUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserAnswerResultDA: GetObjLst)", objException.Message));
}
objUserAnswerResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserAnswerResultEN);
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
public List<clsUserAnswerResultEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsUserAnswerResultDA:GetObjLstByTabName)", objException.Message));
}
List<clsUserAnswerResultEN> arrObjLst = new List<clsUserAnswerResultEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserAnswerResultEN objUserAnswerResultEN = new clsUserAnswerResultEN();
try
{
objUserAnswerResultEN.MinId = TransNullToInt(objRow[conUserAnswerResult.MinId].ToString().Trim()); //MinId
objUserAnswerResultEN.QuestionId = objRow[conUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objUserAnswerResultEN.CourseId = objRow[conUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objUserAnswerResultEN.IdCurrEduCls = objRow[conUserAnswerResult.IdCurrEduCls] == DBNull.Value ? null : objRow[conUserAnswerResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objUserAnswerResultEN.ExamBatchNo = objRow[conUserAnswerResult.ExamBatchNo] == DBNull.Value ? null : objRow[conUserAnswerResult.ExamBatchNo].ToString().Trim(); //学生批次号
objUserAnswerResultEN.CourseExamPaperId = objRow[conUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objUserAnswerResultEN.AnswerOptionId = objRow[conUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objUserAnswerResultEN.BatchId = objRow[conUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[conUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objUserAnswerResultEN.UserId = objRow[conUserAnswerResult.UserId] == DBNull.Value ? null : objRow[conUserAnswerResult.UserId].ToString().Trim(); //用户ID
objUserAnswerResultEN.AnswerText = objRow[conUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objUserAnswerResultEN.AnswerDate = objRow[conUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objUserAnswerResultEN.AnswerTime = objRow[conUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objUserAnswerResultEN.AnswerIP = objRow[conUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objUserAnswerResultEN.IsAccess = TransNullToBool(objRow[conUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objUserAnswerResultEN.IsAccessC = TransNullToBool(objRow[conUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objUserAnswerResultEN.IdSchool = objRow[conUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[conUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objUserAnswerResultEN.School = objRow[conUserAnswerResult.School] == DBNull.Value ? null : objRow[conUserAnswerResult.School].ToString().Trim(); //School
objUserAnswerResultEN.AnswerMode = objRow[conUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objUserAnswerResultEN.IsMarking = TransNullToBool(objRow[conUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objUserAnswerResultEN.IsRight = TransNullToBool(objRow[conUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objUserAnswerResultEN.Score = objRow[conUserAnswerResult.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conUserAnswerResult.Score].ToString().Trim()); //得分
objUserAnswerResultEN.MarkTime = objRow[conUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objUserAnswerResultEN.MarkerId = objRow[conUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objUserAnswerResultEN.Comment = objRow[conUserAnswerResult.Comment] == DBNull.Value ? null : objRow[conUserAnswerResult.Comment].ToString().Trim(); //批注
objUserAnswerResultEN.IsAccessKnowledge = TransNullToBool(objRow[conUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objUserAnswerResultEN.AnswerId = objRow[conUserAnswerResult.AnswerId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUserAnswerResult.AnswerId].ToString().Trim()); //问答ID
objUserAnswerResultEN.AnswerMultiOption = objRow[conUserAnswerResult.AnswerMultiOption] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerMultiOption].ToString().Trim(); //多选项答案
objUserAnswerResultEN.UpdDate = objRow[conUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objUserAnswerResultEN.UpdUser = objRow[conUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objUserAnswerResultEN.Memo = objRow[conUserAnswerResult.Memo] == DBNull.Value ? null : objRow[conUserAnswerResult.Memo].ToString().Trim(); //备注
objUserAnswerResultEN.QuestionnaireSetId = objRow[conUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[conUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserAnswerResultDA: GetObjLst)", objException.Message));
}
objUserAnswerResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserAnswerResultEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetUserAnswerResult(ref clsUserAnswerResultEN objUserAnswerResultEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
strSQL = "Select * from UserAnswerResult where MinId = " + ""+ objUserAnswerResultEN.MinId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objUserAnswerResultEN.MinId = TransNullToInt(objDT.Rows[0][conUserAnswerResult.MinId].ToString().Trim()); //MinId(字段类型:bigint,字段长度:8,是否可空:True)
 objUserAnswerResultEN.QuestionId = TransNullToInt(objDT.Rows[0][conUserAnswerResult.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objUserAnswerResultEN.CourseId = objDT.Rows[0][conUserAnswerResult.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objUserAnswerResultEN.IdCurrEduCls = objDT.Rows[0][conUserAnswerResult.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objUserAnswerResultEN.ExamBatchNo = objDT.Rows[0][conUserAnswerResult.ExamBatchNo].ToString().Trim(); //学生批次号(字段类型:varchar,字段长度:20,是否可空:False)
 objUserAnswerResultEN.CourseExamPaperId = objDT.Rows[0][conUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objUserAnswerResultEN.AnswerOptionId = objDT.Rows[0][conUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objUserAnswerResultEN.BatchId = objDT.Rows[0][conUserAnswerResult.BatchId].ToString().Trim(); //批次ID(字段类型:char,字段长度:4,是否可空:True)
 objUserAnswerResultEN.UserId = objDT.Rows[0][conUserAnswerResult.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objUserAnswerResultEN.AnswerText = objDT.Rows[0][conUserAnswerResult.AnswerText].ToString().Trim(); //回答文本(字段类型:varchar,字段长度:8000,是否可空:True)
 objUserAnswerResultEN.AnswerDate = objDT.Rows[0][conUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期(字段类型:varchar,字段长度:8,是否可空:True)
 objUserAnswerResultEN.AnswerTime = objDT.Rows[0][conUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间(字段类型:varchar,字段长度:10,是否可空:True)
 objUserAnswerResultEN.AnswerIP = objDT.Rows[0][conUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP(字段类型:varchar,字段长度:30,是否可空:True)
 objUserAnswerResultEN.IsAccess = TransNullToBool(objDT.Rows[0][conUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess(字段类型:bit,字段长度:1,是否可空:True)
 objUserAnswerResultEN.IsAccessC = TransNullToBool(objDT.Rows[0][conUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC(字段类型:bit,字段长度:1,是否可空:True)
 objUserAnswerResultEN.IdSchool = objDT.Rows[0][conUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objUserAnswerResultEN.School = objDT.Rows[0][conUserAnswerResult.School].ToString().Trim(); //School(字段类型:varchar,字段长度:50,是否可空:True)
 objUserAnswerResultEN.AnswerMode = TransNullToInt(objDT.Rows[0][conUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode(字段类型:int,字段长度:4,是否可空:True)
 objUserAnswerResultEN.IsMarking = TransNullToBool(objDT.Rows[0][conUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅(字段类型:bit,字段长度:1,是否可空:True)
 objUserAnswerResultEN.IsRight = TransNullToBool(objDT.Rows[0][conUserAnswerResult.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objUserAnswerResultEN.Score = TransNullToDouble(objDT.Rows[0][conUserAnswerResult.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objUserAnswerResultEN.MarkTime = objDT.Rows[0][conUserAnswerResult.MarkTime].ToString().Trim(); //批改时间(字段类型:varchar,字段长度:14,是否可空:True)
 objUserAnswerResultEN.MarkerId = objDT.Rows[0][conUserAnswerResult.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objUserAnswerResultEN.Comment = objDT.Rows[0][conUserAnswerResult.Comment].ToString().Trim(); //批注(字段类型:text,字段长度:2147483647,是否可空:True)
 objUserAnswerResultEN.IsAccessKnowledge = TransNullToBool(objDT.Rows[0][conUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点(字段类型:bit,字段长度:1,是否可空:True)
 objUserAnswerResultEN.AnswerId = TransNullToInt(objDT.Rows[0][conUserAnswerResult.AnswerId].ToString().Trim()); //问答ID(字段类型:bigint,字段长度:8,是否可空:True)
 objUserAnswerResultEN.AnswerMultiOption = objDT.Rows[0][conUserAnswerResult.AnswerMultiOption].ToString().Trim(); //多选项答案(字段类型:varchar,字段长度:300,是否可空:True)
 objUserAnswerResultEN.UpdDate = objDT.Rows[0][conUserAnswerResult.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUserAnswerResultEN.UpdUser = objDT.Rows[0][conUserAnswerResult.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objUserAnswerResultEN.Memo = objDT.Rows[0][conUserAnswerResult.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objUserAnswerResultEN.QuestionnaireSetId = objDT.Rows[0][conUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsUserAnswerResultDA: GetUserAnswerResult)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngMinId">表关键字</param>
 /// <returns>表对象</returns>
public clsUserAnswerResultEN GetObjByMinId(long lngMinId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
strSQL = "Select * from UserAnswerResult where MinId = " + ""+ lngMinId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsUserAnswerResultEN objUserAnswerResultEN = new clsUserAnswerResultEN();
try
{
 objUserAnswerResultEN.MinId = Int32.Parse(objRow[conUserAnswerResult.MinId].ToString().Trim()); //MinId(字段类型:bigint,字段长度:8,是否可空:True)
 objUserAnswerResultEN.QuestionId = objRow[conUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objUserAnswerResultEN.CourseId = objRow[conUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objUserAnswerResultEN.IdCurrEduCls = objRow[conUserAnswerResult.IdCurrEduCls] == DBNull.Value ? null : objRow[conUserAnswerResult.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objUserAnswerResultEN.ExamBatchNo = objRow[conUserAnswerResult.ExamBatchNo] == DBNull.Value ? null : objRow[conUserAnswerResult.ExamBatchNo].ToString().Trim(); //学生批次号(字段类型:varchar,字段长度:20,是否可空:False)
 objUserAnswerResultEN.CourseExamPaperId = objRow[conUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objUserAnswerResultEN.AnswerOptionId = objRow[conUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id(字段类型:char,字段长度:8,是否可空:True)
 objUserAnswerResultEN.BatchId = objRow[conUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[conUserAnswerResult.BatchId].ToString().Trim(); //批次ID(字段类型:char,字段长度:4,是否可空:True)
 objUserAnswerResultEN.UserId = objRow[conUserAnswerResult.UserId] == DBNull.Value ? null : objRow[conUserAnswerResult.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objUserAnswerResultEN.AnswerText = objRow[conUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerText].ToString().Trim(); //回答文本(字段类型:varchar,字段长度:8000,是否可空:True)
 objUserAnswerResultEN.AnswerDate = objRow[conUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期(字段类型:varchar,字段长度:8,是否可空:True)
 objUserAnswerResultEN.AnswerTime = objRow[conUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间(字段类型:varchar,字段长度:10,是否可空:True)
 objUserAnswerResultEN.AnswerIP = objRow[conUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP(字段类型:varchar,字段长度:30,是否可空:True)
 objUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess(字段类型:bit,字段长度:1,是否可空:True)
 objUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC(字段类型:bit,字段长度:1,是否可空:True)
 objUserAnswerResultEN.IdSchool = objRow[conUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[conUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objUserAnswerResultEN.School = objRow[conUserAnswerResult.School] == DBNull.Value ? null : objRow[conUserAnswerResult.School].ToString().Trim(); //School(字段类型:varchar,字段长度:50,是否可空:True)
 objUserAnswerResultEN.AnswerMode = objRow[conUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode(字段类型:int,字段长度:4,是否可空:True)
 objUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅(字段类型:bit,字段长度:1,是否可空:True)
 objUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objUserAnswerResultEN.Score = objRow[conUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conUserAnswerResult.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objUserAnswerResultEN.MarkTime = objRow[conUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkTime].ToString().Trim(); //批改时间(字段类型:varchar,字段长度:14,是否可空:True)
 objUserAnswerResultEN.MarkerId = objRow[conUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objUserAnswerResultEN.Comment = objRow[conUserAnswerResult.Comment] == DBNull.Value ? null : objRow[conUserAnswerResult.Comment].ToString().Trim(); //批注(字段类型:text,字段长度:2147483647,是否可空:True)
 objUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点(字段类型:bit,字段长度:1,是否可空:True)
 objUserAnswerResultEN.AnswerId = objRow[conUserAnswerResult.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerId].ToString().Trim()); //问答ID(字段类型:bigint,字段长度:8,是否可空:True)
 objUserAnswerResultEN.AnswerMultiOption = objRow[conUserAnswerResult.AnswerMultiOption] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerMultiOption].ToString().Trim(); //多选项答案(字段类型:varchar,字段长度:300,是否可空:True)
 objUserAnswerResultEN.UpdDate = objRow[conUserAnswerResult.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUserAnswerResultEN.UpdUser = objRow[conUserAnswerResult.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objUserAnswerResultEN.Memo = objRow[conUserAnswerResult.Memo] == DBNull.Value ? null : objRow[conUserAnswerResult.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objUserAnswerResultEN.QuestionnaireSetId = objRow[conUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[conUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsUserAnswerResultDA: GetObjByMinId)", objException.Message));
}
return objUserAnswerResultEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsUserAnswerResultEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsUserAnswerResultDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
strSQL = "Select * from UserAnswerResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsUserAnswerResultEN objUserAnswerResultEN = new clsUserAnswerResultEN()
{
MinId = TransNullToInt(objRow[conUserAnswerResult.MinId].ToString().Trim()), //MinId
QuestionId = objRow[conUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUserAnswerResult.QuestionId].ToString().Trim()), //题目Id
CourseId = objRow[conUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseId].ToString().Trim(), //课程Id
IdCurrEduCls = objRow[conUserAnswerResult.IdCurrEduCls] == DBNull.Value ? null : objRow[conUserAnswerResult.IdCurrEduCls].ToString().Trim(), //教学班流水号
ExamBatchNo = objRow[conUserAnswerResult.ExamBatchNo] == DBNull.Value ? null : objRow[conUserAnswerResult.ExamBatchNo].ToString().Trim(), //学生批次号
CourseExamPaperId = objRow[conUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseExamPaperId].ToString().Trim(), //考卷流水号
AnswerOptionId = objRow[conUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerOptionId].ToString().Trim(), //回答选项Id
BatchId = objRow[conUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[conUserAnswerResult.BatchId].ToString().Trim(), //批次ID
UserId = objRow[conUserAnswerResult.UserId] == DBNull.Value ? null : objRow[conUserAnswerResult.UserId].ToString().Trim(), //用户ID
AnswerText = objRow[conUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerText].ToString().Trim(), //回答文本
AnswerDate = objRow[conUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerDate].ToString().Trim(), //回答日期
AnswerTime = objRow[conUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerTime].ToString().Trim(), //回答时间
AnswerIP = objRow[conUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerIP].ToString().Trim(), //回答IP
IsAccess = TransNullToBool(objRow[conUserAnswerResult.IsAccess].ToString().Trim()), //IsAccess
IsAccessC = TransNullToBool(objRow[conUserAnswerResult.IsAccessC].ToString().Trim()), //IsAccessC
IdSchool = objRow[conUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[conUserAnswerResult.IdSchool].ToString().Trim(), //学校流水号
School = objRow[conUserAnswerResult.School] == DBNull.Value ? null : objRow[conUserAnswerResult.School].ToString().Trim(), //School
AnswerMode = objRow[conUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUserAnswerResult.AnswerMode].ToString().Trim()), //AnswerMode
IsMarking = TransNullToBool(objRow[conUserAnswerResult.IsMarking].ToString().Trim()), //是否批阅
IsRight = TransNullToBool(objRow[conUserAnswerResult.IsRight].ToString().Trim()), //是否正确
Score = objRow[conUserAnswerResult.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conUserAnswerResult.Score].ToString().Trim()), //得分
MarkTime = objRow[conUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkTime].ToString().Trim(), //批改时间
MarkerId = objRow[conUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkerId].ToString().Trim(), //打分者
Comment = objRow[conUserAnswerResult.Comment] == DBNull.Value ? null : objRow[conUserAnswerResult.Comment].ToString().Trim(), //批注
IsAccessKnowledge = TransNullToBool(objRow[conUserAnswerResult.IsAccessKnowledge].ToString().Trim()), //是否处理知识点
AnswerId = objRow[conUserAnswerResult.AnswerId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUserAnswerResult.AnswerId].ToString().Trim()), //问答ID
AnswerMultiOption = objRow[conUserAnswerResult.AnswerMultiOption] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerMultiOption].ToString().Trim(), //多选项答案
UpdDate = objRow[conUserAnswerResult.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conUserAnswerResult.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conUserAnswerResult.Memo] == DBNull.Value ? null : objRow[conUserAnswerResult.Memo].ToString().Trim(), //备注
QuestionnaireSetId = objRow[conUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[conUserAnswerResult.QuestionnaireSetId].ToString().Trim() //问卷集ID
};
objUserAnswerResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserAnswerResultEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsUserAnswerResultDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsUserAnswerResultEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserAnswerResultEN objUserAnswerResultEN = new clsUserAnswerResultEN();
try
{
objUserAnswerResultEN.MinId = TransNullToInt(objRow[conUserAnswerResult.MinId].ToString().Trim()); //MinId
objUserAnswerResultEN.QuestionId = objRow[conUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objUserAnswerResultEN.CourseId = objRow[conUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objUserAnswerResultEN.IdCurrEduCls = objRow[conUserAnswerResult.IdCurrEduCls] == DBNull.Value ? null : objRow[conUserAnswerResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objUserAnswerResultEN.ExamBatchNo = objRow[conUserAnswerResult.ExamBatchNo] == DBNull.Value ? null : objRow[conUserAnswerResult.ExamBatchNo].ToString().Trim(); //学生批次号
objUserAnswerResultEN.CourseExamPaperId = objRow[conUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objUserAnswerResultEN.AnswerOptionId = objRow[conUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objUserAnswerResultEN.BatchId = objRow[conUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[conUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objUserAnswerResultEN.UserId = objRow[conUserAnswerResult.UserId] == DBNull.Value ? null : objRow[conUserAnswerResult.UserId].ToString().Trim(); //用户ID
objUserAnswerResultEN.AnswerText = objRow[conUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objUserAnswerResultEN.AnswerDate = objRow[conUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objUserAnswerResultEN.AnswerTime = objRow[conUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objUserAnswerResultEN.AnswerIP = objRow[conUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objUserAnswerResultEN.IsAccess = TransNullToBool(objRow[conUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objUserAnswerResultEN.IsAccessC = TransNullToBool(objRow[conUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objUserAnswerResultEN.IdSchool = objRow[conUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[conUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objUserAnswerResultEN.School = objRow[conUserAnswerResult.School] == DBNull.Value ? null : objRow[conUserAnswerResult.School].ToString().Trim(); //School
objUserAnswerResultEN.AnswerMode = objRow[conUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objUserAnswerResultEN.IsMarking = TransNullToBool(objRow[conUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objUserAnswerResultEN.IsRight = TransNullToBool(objRow[conUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objUserAnswerResultEN.Score = objRow[conUserAnswerResult.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conUserAnswerResult.Score].ToString().Trim()); //得分
objUserAnswerResultEN.MarkTime = objRow[conUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objUserAnswerResultEN.MarkerId = objRow[conUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objUserAnswerResultEN.Comment = objRow[conUserAnswerResult.Comment] == DBNull.Value ? null : objRow[conUserAnswerResult.Comment].ToString().Trim(); //批注
objUserAnswerResultEN.IsAccessKnowledge = TransNullToBool(objRow[conUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objUserAnswerResultEN.AnswerId = objRow[conUserAnswerResult.AnswerId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUserAnswerResult.AnswerId].ToString().Trim()); //问答ID
objUserAnswerResultEN.AnswerMultiOption = objRow[conUserAnswerResult.AnswerMultiOption] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerMultiOption].ToString().Trim(); //多选项答案
objUserAnswerResultEN.UpdDate = objRow[conUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objUserAnswerResultEN.UpdUser = objRow[conUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objUserAnswerResultEN.Memo = objRow[conUserAnswerResult.Memo] == DBNull.Value ? null : objRow[conUserAnswerResult.Memo].ToString().Trim(); //备注
objUserAnswerResultEN.QuestionnaireSetId = objRow[conUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[conUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsUserAnswerResultDA: GetObjByDataRowUserAnswerResult)", objException.Message));
}
objUserAnswerResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserAnswerResultEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsUserAnswerResultEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserAnswerResultEN objUserAnswerResultEN = new clsUserAnswerResultEN();
try
{
objUserAnswerResultEN.MinId = TransNullToInt(objRow[conUserAnswerResult.MinId].ToString().Trim()); //MinId
objUserAnswerResultEN.QuestionId = objRow[conUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objUserAnswerResultEN.CourseId = objRow[conUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objUserAnswerResultEN.IdCurrEduCls = objRow[conUserAnswerResult.IdCurrEduCls] == DBNull.Value ? null : objRow[conUserAnswerResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objUserAnswerResultEN.ExamBatchNo = objRow[conUserAnswerResult.ExamBatchNo] == DBNull.Value ? null : objRow[conUserAnswerResult.ExamBatchNo].ToString().Trim(); //学生批次号
objUserAnswerResultEN.CourseExamPaperId = objRow[conUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objUserAnswerResultEN.AnswerOptionId = objRow[conUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objUserAnswerResultEN.BatchId = objRow[conUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[conUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objUserAnswerResultEN.UserId = objRow[conUserAnswerResult.UserId] == DBNull.Value ? null : objRow[conUserAnswerResult.UserId].ToString().Trim(); //用户ID
objUserAnswerResultEN.AnswerText = objRow[conUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objUserAnswerResultEN.AnswerDate = objRow[conUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objUserAnswerResultEN.AnswerTime = objRow[conUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objUserAnswerResultEN.AnswerIP = objRow[conUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objUserAnswerResultEN.IsAccess = TransNullToBool(objRow[conUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objUserAnswerResultEN.IsAccessC = TransNullToBool(objRow[conUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objUserAnswerResultEN.IdSchool = objRow[conUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[conUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objUserAnswerResultEN.School = objRow[conUserAnswerResult.School] == DBNull.Value ? null : objRow[conUserAnswerResult.School].ToString().Trim(); //School
objUserAnswerResultEN.AnswerMode = objRow[conUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objUserAnswerResultEN.IsMarking = TransNullToBool(objRow[conUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objUserAnswerResultEN.IsRight = TransNullToBool(objRow[conUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objUserAnswerResultEN.Score = objRow[conUserAnswerResult.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conUserAnswerResult.Score].ToString().Trim()); //得分
objUserAnswerResultEN.MarkTime = objRow[conUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objUserAnswerResultEN.MarkerId = objRow[conUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objUserAnswerResultEN.Comment = objRow[conUserAnswerResult.Comment] == DBNull.Value ? null : objRow[conUserAnswerResult.Comment].ToString().Trim(); //批注
objUserAnswerResultEN.IsAccessKnowledge = TransNullToBool(objRow[conUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objUserAnswerResultEN.AnswerId = objRow[conUserAnswerResult.AnswerId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUserAnswerResult.AnswerId].ToString().Trim()); //问答ID
objUserAnswerResultEN.AnswerMultiOption = objRow[conUserAnswerResult.AnswerMultiOption] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerMultiOption].ToString().Trim(); //多选项答案
objUserAnswerResultEN.UpdDate = objRow[conUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objUserAnswerResultEN.UpdUser = objRow[conUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objUserAnswerResultEN.Memo = objRow[conUserAnswerResult.Memo] == DBNull.Value ? null : objRow[conUserAnswerResult.Memo].ToString().Trim(); //备注
objUserAnswerResultEN.QuestionnaireSetId = objRow[conUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[conUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsUserAnswerResultDA: GetObjByDataRow)", objException.Message));
}
objUserAnswerResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserAnswerResultEN;
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
objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserAnswerResultEN._CurrTabName, conUserAnswerResult.MinId, 8, "");
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
objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserAnswerResultEN._CurrTabName, conUserAnswerResult.MinId, 8, strPrefix);
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
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select MinId from UserAnswerResult where " + strCondition;
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
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select MinId from UserAnswerResult where " + strCondition;
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
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserAnswerResult", "MinId = " + ""+ lngMinId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsUserAnswerResultDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserAnswerResult", strCondition))
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
objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("UserAnswerResult");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsUserAnswerResultEN objUserAnswerResultEN)
 {
 objUserAnswerResultEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserAnswerResultEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserAnswerResultEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
strSQL = "Select * from UserAnswerResult where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserAnswerResult");
objRow = objDS.Tables["UserAnswerResult"].NewRow();
objRow[conUserAnswerResult.QuestionId] = objUserAnswerResultEN.QuestionId; //题目Id
 if (objUserAnswerResultEN.CourseId !=  "")
 {
objRow[conUserAnswerResult.CourseId] = objUserAnswerResultEN.CourseId; //课程Id
 }
 if (objUserAnswerResultEN.IdCurrEduCls !=  "")
 {
objRow[conUserAnswerResult.IdCurrEduCls] = objUserAnswerResultEN.IdCurrEduCls; //教学班流水号
 }
 if (objUserAnswerResultEN.ExamBatchNo !=  "")
 {
objRow[conUserAnswerResult.ExamBatchNo] = objUserAnswerResultEN.ExamBatchNo; //学生批次号
 }
 if (objUserAnswerResultEN.CourseExamPaperId !=  "")
 {
objRow[conUserAnswerResult.CourseExamPaperId] = objUserAnswerResultEN.CourseExamPaperId; //考卷流水号
 }
 if (objUserAnswerResultEN.AnswerOptionId !=  "")
 {
objRow[conUserAnswerResult.AnswerOptionId] = objUserAnswerResultEN.AnswerOptionId; //回答选项Id
 }
 if (objUserAnswerResultEN.BatchId !=  "")
 {
objRow[conUserAnswerResult.BatchId] = objUserAnswerResultEN.BatchId; //批次ID
 }
 if (objUserAnswerResultEN.UserId !=  "")
 {
objRow[conUserAnswerResult.UserId] = objUserAnswerResultEN.UserId; //用户ID
 }
 if (objUserAnswerResultEN.AnswerText !=  "")
 {
objRow[conUserAnswerResult.AnswerText] = objUserAnswerResultEN.AnswerText; //回答文本
 }
 if (objUserAnswerResultEN.AnswerDate !=  "")
 {
objRow[conUserAnswerResult.AnswerDate] = objUserAnswerResultEN.AnswerDate; //回答日期
 }
 if (objUserAnswerResultEN.AnswerTime !=  "")
 {
objRow[conUserAnswerResult.AnswerTime] = objUserAnswerResultEN.AnswerTime; //回答时间
 }
 if (objUserAnswerResultEN.AnswerIP !=  "")
 {
objRow[conUserAnswerResult.AnswerIP] = objUserAnswerResultEN.AnswerIP; //回答IP
 }
objRow[conUserAnswerResult.IsAccess] = objUserAnswerResultEN.IsAccess; //IsAccess
objRow[conUserAnswerResult.IsAccessC] = objUserAnswerResultEN.IsAccessC; //IsAccessC
 if (objUserAnswerResultEN.IdSchool !=  "")
 {
objRow[conUserAnswerResult.IdSchool] = objUserAnswerResultEN.IdSchool; //学校流水号
 }
 if (objUserAnswerResultEN.School !=  "")
 {
objRow[conUserAnswerResult.School] = objUserAnswerResultEN.School; //School
 }
objRow[conUserAnswerResult.AnswerMode] = objUserAnswerResultEN.AnswerMode; //AnswerMode
objRow[conUserAnswerResult.IsMarking] = objUserAnswerResultEN.IsMarking; //是否批阅
objRow[conUserAnswerResult.IsRight] = objUserAnswerResultEN.IsRight; //是否正确
objRow[conUserAnswerResult.Score] = objUserAnswerResultEN.Score; //得分
 if (objUserAnswerResultEN.MarkTime !=  "")
 {
objRow[conUserAnswerResult.MarkTime] = objUserAnswerResultEN.MarkTime; //批改时间
 }
 if (objUserAnswerResultEN.MarkerId !=  "")
 {
objRow[conUserAnswerResult.MarkerId] = objUserAnswerResultEN.MarkerId; //打分者
 }
 if (objUserAnswerResultEN.Comment !=  "")
 {
objRow[conUserAnswerResult.Comment] = objUserAnswerResultEN.Comment; //批注
 }
objRow[conUserAnswerResult.IsAccessKnowledge] = objUserAnswerResultEN.IsAccessKnowledge; //是否处理知识点
objRow[conUserAnswerResult.AnswerId] = objUserAnswerResultEN.AnswerId; //问答ID
 if (objUserAnswerResultEN.AnswerMultiOption !=  "")
 {
objRow[conUserAnswerResult.AnswerMultiOption] = objUserAnswerResultEN.AnswerMultiOption; //多选项答案
 }
objRow[conUserAnswerResult.UpdDate] = objUserAnswerResultEN.UpdDate; //修改日期
objRow[conUserAnswerResult.UpdUser] = objUserAnswerResultEN.UpdUser; //修改人
 if (objUserAnswerResultEN.Memo !=  "")
 {
objRow[conUserAnswerResult.Memo] = objUserAnswerResultEN.Memo; //备注
 }
 if (objUserAnswerResultEN.QuestionnaireSetId !=  "")
 {
objRow[conUserAnswerResult.QuestionnaireSetId] = objUserAnswerResultEN.QuestionnaireSetId; //问卷集ID
 }
objDS.Tables[clsUserAnswerResultEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsUserAnswerResultEN._CurrTabName);
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
 /// <param name = "objUserAnswerResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserAnswerResultEN objUserAnswerResultEN)
{
 objUserAnswerResultEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserAnswerResultEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserAnswerResultEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserAnswerResultEN.QuestionId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.QuestionId);
 arrValueListForInsert.Add(objUserAnswerResultEN.QuestionId.ToString());
 }
 
 if (objUserAnswerResultEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.CourseId);
 var strCourseId = objUserAnswerResultEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objUserAnswerResultEN.IdCurrEduCls  ==  "")
 {
 objUserAnswerResultEN.IdCurrEduCls = null;
 }
 if (objUserAnswerResultEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.IdCurrEduCls);
 var strIdCurrEduCls = objUserAnswerResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objUserAnswerResultEN.ExamBatchNo !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.ExamBatchNo);
 var strExamBatchNo = objUserAnswerResultEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamBatchNo + "'");
 }
 
 if (objUserAnswerResultEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.CourseExamPaperId);
 var strCourseExamPaperId = objUserAnswerResultEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objUserAnswerResultEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerOptionId);
 var strAnswerOptionId = objUserAnswerResultEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objUserAnswerResultEN.BatchId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.BatchId);
 var strBatchId = objUserAnswerResultEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchId + "'");
 }
 
 if (objUserAnswerResultEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.UserId);
 var strUserId = objUserAnswerResultEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserAnswerResultEN.AnswerText !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerText);
 var strAnswerText = objUserAnswerResultEN.AnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerText + "'");
 }
 
 if (objUserAnswerResultEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerDate);
 var strAnswerDate = objUserAnswerResultEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objUserAnswerResultEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerTime);
 var strAnswerTime = objUserAnswerResultEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objUserAnswerResultEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerIP);
 var strAnswerIP = objUserAnswerResultEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsAccess);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsAccess  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsAccessC);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsAccessC  ==  false ? "0" : "1") + "'");
 
 if (objUserAnswerResultEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.IdSchool);
 var strIdSchool = objUserAnswerResultEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objUserAnswerResultEN.School !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.School);
 var strSchool = objUserAnswerResultEN.School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchool + "'");
 }
 
 if (objUserAnswerResultEN.AnswerMode !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerMode);
 arrValueListForInsert.Add(objUserAnswerResultEN.AnswerMode.ToString());
 }
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsMarking);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsRight);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsRight  ==  false ? "0" : "1") + "'");
 
 if (objUserAnswerResultEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.Score);
 arrValueListForInsert.Add(objUserAnswerResultEN.Score.ToString());
 }
 
 if (objUserAnswerResultEN.MarkTime !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.MarkTime);
 var strMarkTime = objUserAnswerResultEN.MarkTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkTime + "'");
 }
 
 if (objUserAnswerResultEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.MarkerId);
 var strMarkerId = objUserAnswerResultEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objUserAnswerResultEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.Comment);
 var strComment = objUserAnswerResultEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 if (objUserAnswerResultEN.AnswerId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerId);
 arrValueListForInsert.Add(objUserAnswerResultEN.AnswerId.ToString());
 }
 
 if (objUserAnswerResultEN.AnswerMultiOption !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerMultiOption);
 var strAnswerMultiOption = objUserAnswerResultEN.AnswerMultiOption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOption + "'");
 }
 
 if (objUserAnswerResultEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.UpdDate);
 var strUpdDate = objUserAnswerResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserAnswerResultEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.UpdUser);
 var strUpdUser = objUserAnswerResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objUserAnswerResultEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.Memo);
 var strMemo = objUserAnswerResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objUserAnswerResultEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.QuestionnaireSetId);
 var strQuestionnaireSetId = objUserAnswerResultEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserAnswerResult");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserAnswerResultEN objUserAnswerResultEN)
{
 objUserAnswerResultEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserAnswerResultEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserAnswerResultEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserAnswerResultEN.QuestionId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.QuestionId);
 arrValueListForInsert.Add(objUserAnswerResultEN.QuestionId.ToString());
 }
 
 if (objUserAnswerResultEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.CourseId);
 var strCourseId = objUserAnswerResultEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objUserAnswerResultEN.IdCurrEduCls  ==  "")
 {
 objUserAnswerResultEN.IdCurrEduCls = null;
 }
 if (objUserAnswerResultEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.IdCurrEduCls);
 var strIdCurrEduCls = objUserAnswerResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objUserAnswerResultEN.ExamBatchNo !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.ExamBatchNo);
 var strExamBatchNo = objUserAnswerResultEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamBatchNo + "'");
 }
 
 if (objUserAnswerResultEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.CourseExamPaperId);
 var strCourseExamPaperId = objUserAnswerResultEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objUserAnswerResultEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerOptionId);
 var strAnswerOptionId = objUserAnswerResultEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objUserAnswerResultEN.BatchId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.BatchId);
 var strBatchId = objUserAnswerResultEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchId + "'");
 }
 
 if (objUserAnswerResultEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.UserId);
 var strUserId = objUserAnswerResultEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserAnswerResultEN.AnswerText !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerText);
 var strAnswerText = objUserAnswerResultEN.AnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerText + "'");
 }
 
 if (objUserAnswerResultEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerDate);
 var strAnswerDate = objUserAnswerResultEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objUserAnswerResultEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerTime);
 var strAnswerTime = objUserAnswerResultEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objUserAnswerResultEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerIP);
 var strAnswerIP = objUserAnswerResultEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsAccess);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsAccess  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsAccessC);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsAccessC  ==  false ? "0" : "1") + "'");
 
 if (objUserAnswerResultEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.IdSchool);
 var strIdSchool = objUserAnswerResultEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objUserAnswerResultEN.School !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.School);
 var strSchool = objUserAnswerResultEN.School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchool + "'");
 }
 
 if (objUserAnswerResultEN.AnswerMode !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerMode);
 arrValueListForInsert.Add(objUserAnswerResultEN.AnswerMode.ToString());
 }
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsMarking);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsRight);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsRight  ==  false ? "0" : "1") + "'");
 
 if (objUserAnswerResultEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.Score);
 arrValueListForInsert.Add(objUserAnswerResultEN.Score.ToString());
 }
 
 if (objUserAnswerResultEN.MarkTime !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.MarkTime);
 var strMarkTime = objUserAnswerResultEN.MarkTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkTime + "'");
 }
 
 if (objUserAnswerResultEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.MarkerId);
 var strMarkerId = objUserAnswerResultEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objUserAnswerResultEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.Comment);
 var strComment = objUserAnswerResultEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 if (objUserAnswerResultEN.AnswerId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerId);
 arrValueListForInsert.Add(objUserAnswerResultEN.AnswerId.ToString());
 }
 
 if (objUserAnswerResultEN.AnswerMultiOption !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerMultiOption);
 var strAnswerMultiOption = objUserAnswerResultEN.AnswerMultiOption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOption + "'");
 }
 
 if (objUserAnswerResultEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.UpdDate);
 var strUpdDate = objUserAnswerResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserAnswerResultEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.UpdUser);
 var strUpdUser = objUserAnswerResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objUserAnswerResultEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.Memo);
 var strMemo = objUserAnswerResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objUserAnswerResultEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.QuestionnaireSetId);
 var strQuestionnaireSetId = objUserAnswerResultEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserAnswerResult");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserAnswerResultEN objUserAnswerResultEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUserAnswerResultEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserAnswerResultEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserAnswerResultEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserAnswerResultEN.QuestionId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.QuestionId);
 arrValueListForInsert.Add(objUserAnswerResultEN.QuestionId.ToString());
 }
 
 if (objUserAnswerResultEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.CourseId);
 var strCourseId = objUserAnswerResultEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objUserAnswerResultEN.IdCurrEduCls  ==  "")
 {
 objUserAnswerResultEN.IdCurrEduCls = null;
 }
 if (objUserAnswerResultEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.IdCurrEduCls);
 var strIdCurrEduCls = objUserAnswerResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objUserAnswerResultEN.ExamBatchNo !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.ExamBatchNo);
 var strExamBatchNo = objUserAnswerResultEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamBatchNo + "'");
 }
 
 if (objUserAnswerResultEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.CourseExamPaperId);
 var strCourseExamPaperId = objUserAnswerResultEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objUserAnswerResultEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerOptionId);
 var strAnswerOptionId = objUserAnswerResultEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objUserAnswerResultEN.BatchId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.BatchId);
 var strBatchId = objUserAnswerResultEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchId + "'");
 }
 
 if (objUserAnswerResultEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.UserId);
 var strUserId = objUserAnswerResultEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserAnswerResultEN.AnswerText !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerText);
 var strAnswerText = objUserAnswerResultEN.AnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerText + "'");
 }
 
 if (objUserAnswerResultEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerDate);
 var strAnswerDate = objUserAnswerResultEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objUserAnswerResultEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerTime);
 var strAnswerTime = objUserAnswerResultEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objUserAnswerResultEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerIP);
 var strAnswerIP = objUserAnswerResultEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsAccess);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsAccess  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsAccessC);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsAccessC  ==  false ? "0" : "1") + "'");
 
 if (objUserAnswerResultEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.IdSchool);
 var strIdSchool = objUserAnswerResultEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objUserAnswerResultEN.School !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.School);
 var strSchool = objUserAnswerResultEN.School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchool + "'");
 }
 
 if (objUserAnswerResultEN.AnswerMode !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerMode);
 arrValueListForInsert.Add(objUserAnswerResultEN.AnswerMode.ToString());
 }
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsMarking);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsRight);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsRight  ==  false ? "0" : "1") + "'");
 
 if (objUserAnswerResultEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.Score);
 arrValueListForInsert.Add(objUserAnswerResultEN.Score.ToString());
 }
 
 if (objUserAnswerResultEN.MarkTime !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.MarkTime);
 var strMarkTime = objUserAnswerResultEN.MarkTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkTime + "'");
 }
 
 if (objUserAnswerResultEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.MarkerId);
 var strMarkerId = objUserAnswerResultEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objUserAnswerResultEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.Comment);
 var strComment = objUserAnswerResultEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 if (objUserAnswerResultEN.AnswerId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerId);
 arrValueListForInsert.Add(objUserAnswerResultEN.AnswerId.ToString());
 }
 
 if (objUserAnswerResultEN.AnswerMultiOption !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerMultiOption);
 var strAnswerMultiOption = objUserAnswerResultEN.AnswerMultiOption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOption + "'");
 }
 
 if (objUserAnswerResultEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.UpdDate);
 var strUpdDate = objUserAnswerResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserAnswerResultEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.UpdUser);
 var strUpdUser = objUserAnswerResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objUserAnswerResultEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.Memo);
 var strMemo = objUserAnswerResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objUserAnswerResultEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.QuestionnaireSetId);
 var strQuestionnaireSetId = objUserAnswerResultEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserAnswerResult");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserAnswerResultEN objUserAnswerResultEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUserAnswerResultEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserAnswerResultEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserAnswerResultEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserAnswerResultEN.QuestionId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.QuestionId);
 arrValueListForInsert.Add(objUserAnswerResultEN.QuestionId.ToString());
 }
 
 if (objUserAnswerResultEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.CourseId);
 var strCourseId = objUserAnswerResultEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objUserAnswerResultEN.IdCurrEduCls  ==  "")
 {
 objUserAnswerResultEN.IdCurrEduCls = null;
 }
 if (objUserAnswerResultEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.IdCurrEduCls);
 var strIdCurrEduCls = objUserAnswerResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objUserAnswerResultEN.ExamBatchNo !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.ExamBatchNo);
 var strExamBatchNo = objUserAnswerResultEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamBatchNo + "'");
 }
 
 if (objUserAnswerResultEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.CourseExamPaperId);
 var strCourseExamPaperId = objUserAnswerResultEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objUserAnswerResultEN.AnswerOptionId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerOptionId);
 var strAnswerOptionId = objUserAnswerResultEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerOptionId + "'");
 }
 
 if (objUserAnswerResultEN.BatchId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.BatchId);
 var strBatchId = objUserAnswerResultEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchId + "'");
 }
 
 if (objUserAnswerResultEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.UserId);
 var strUserId = objUserAnswerResultEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserAnswerResultEN.AnswerText !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerText);
 var strAnswerText = objUserAnswerResultEN.AnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerText + "'");
 }
 
 if (objUserAnswerResultEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerDate);
 var strAnswerDate = objUserAnswerResultEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objUserAnswerResultEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerTime);
 var strAnswerTime = objUserAnswerResultEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objUserAnswerResultEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerIP);
 var strAnswerIP = objUserAnswerResultEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsAccess);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsAccess  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsAccessC);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsAccessC  ==  false ? "0" : "1") + "'");
 
 if (objUserAnswerResultEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.IdSchool);
 var strIdSchool = objUserAnswerResultEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objUserAnswerResultEN.School !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.School);
 var strSchool = objUserAnswerResultEN.School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchool + "'");
 }
 
 if (objUserAnswerResultEN.AnswerMode !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerMode);
 arrValueListForInsert.Add(objUserAnswerResultEN.AnswerMode.ToString());
 }
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsMarking);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsRight);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsRight  ==  false ? "0" : "1") + "'");
 
 if (objUserAnswerResultEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.Score);
 arrValueListForInsert.Add(objUserAnswerResultEN.Score.ToString());
 }
 
 if (objUserAnswerResultEN.MarkTime !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.MarkTime);
 var strMarkTime = objUserAnswerResultEN.MarkTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkTime + "'");
 }
 
 if (objUserAnswerResultEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.MarkerId);
 var strMarkerId = objUserAnswerResultEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objUserAnswerResultEN.Comment !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.Comment);
 var strComment = objUserAnswerResultEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strComment + "'");
 }
 
 arrFieldListForInsert.Add(conUserAnswerResult.IsAccessKnowledge);
 arrValueListForInsert.Add("'" + (objUserAnswerResultEN.IsAccessKnowledge  ==  false ? "0" : "1") + "'");
 
 if (objUserAnswerResultEN.AnswerId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerId);
 arrValueListForInsert.Add(objUserAnswerResultEN.AnswerId.ToString());
 }
 
 if (objUserAnswerResultEN.AnswerMultiOption !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.AnswerMultiOption);
 var strAnswerMultiOption = objUserAnswerResultEN.AnswerMultiOption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerMultiOption + "'");
 }
 
 if (objUserAnswerResultEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.UpdDate);
 var strUpdDate = objUserAnswerResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserAnswerResultEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.UpdUser);
 var strUpdUser = objUserAnswerResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objUserAnswerResultEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.Memo);
 var strMemo = objUserAnswerResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objUserAnswerResultEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conUserAnswerResult.QuestionnaireSetId);
 var strQuestionnaireSetId = objUserAnswerResultEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserAnswerResult");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewUserAnswerResults(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
strSQL = "Select * from UserAnswerResult where MinId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserAnswerResult");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngMinId = TransNullToInt(oRow[conUserAnswerResult.MinId].ToString().Trim());
if (IsExist(lngMinId))
{
 string strResult = "关键字变量值为:" + string.Format("MinId = {0}", lngMinId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsUserAnswerResultEN._CurrTabName ].NewRow();
objRow[conUserAnswerResult.QuestionId] = oRow[conUserAnswerResult.QuestionId].ToString().Trim(); //题目Id
objRow[conUserAnswerResult.CourseId] = oRow[conUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objRow[conUserAnswerResult.IdCurrEduCls] = oRow[conUserAnswerResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conUserAnswerResult.ExamBatchNo] = oRow[conUserAnswerResult.ExamBatchNo].ToString().Trim(); //学生批次号
objRow[conUserAnswerResult.CourseExamPaperId] = oRow[conUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objRow[conUserAnswerResult.AnswerOptionId] = oRow[conUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objRow[conUserAnswerResult.BatchId] = oRow[conUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objRow[conUserAnswerResult.UserId] = oRow[conUserAnswerResult.UserId].ToString().Trim(); //用户ID
objRow[conUserAnswerResult.AnswerText] = oRow[conUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objRow[conUserAnswerResult.AnswerDate] = oRow[conUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objRow[conUserAnswerResult.AnswerTime] = oRow[conUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objRow[conUserAnswerResult.AnswerIP] = oRow[conUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objRow[conUserAnswerResult.IsAccess] = oRow[conUserAnswerResult.IsAccess].ToString().Trim(); //IsAccess
objRow[conUserAnswerResult.IsAccessC] = oRow[conUserAnswerResult.IsAccessC].ToString().Trim(); //IsAccessC
objRow[conUserAnswerResult.IdSchool] = oRow[conUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objRow[conUserAnswerResult.School] = oRow[conUserAnswerResult.School].ToString().Trim(); //School
objRow[conUserAnswerResult.AnswerMode] = oRow[conUserAnswerResult.AnswerMode].ToString().Trim(); //AnswerMode
objRow[conUserAnswerResult.IsMarking] = oRow[conUserAnswerResult.IsMarking].ToString().Trim(); //是否批阅
objRow[conUserAnswerResult.IsRight] = oRow[conUserAnswerResult.IsRight].ToString().Trim(); //是否正确
objRow[conUserAnswerResult.Score] = oRow[conUserAnswerResult.Score].ToString().Trim(); //得分
objRow[conUserAnswerResult.MarkTime] = oRow[conUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objRow[conUserAnswerResult.MarkerId] = oRow[conUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objRow[conUserAnswerResult.Comment] = oRow[conUserAnswerResult.Comment].ToString().Trim(); //批注
objRow[conUserAnswerResult.IsAccessKnowledge] = oRow[conUserAnswerResult.IsAccessKnowledge].ToString().Trim(); //是否处理知识点
objRow[conUserAnswerResult.AnswerId] = oRow[conUserAnswerResult.AnswerId].ToString().Trim(); //问答ID
objRow[conUserAnswerResult.AnswerMultiOption] = oRow[conUserAnswerResult.AnswerMultiOption].ToString().Trim(); //多选项答案
objRow[conUserAnswerResult.UpdDate] = oRow[conUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objRow[conUserAnswerResult.UpdUser] = oRow[conUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objRow[conUserAnswerResult.Memo] = oRow[conUserAnswerResult.Memo].ToString().Trim(); //备注
objRow[conUserAnswerResult.QuestionnaireSetId] = oRow[conUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
 objDS.Tables[clsUserAnswerResultEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsUserAnswerResultEN._CurrTabName);
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
 /// <param name = "objUserAnswerResultEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsUserAnswerResultEN objUserAnswerResultEN)
{
 objUserAnswerResultEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserAnswerResultEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserAnswerResultEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
strSQL = "Select * from UserAnswerResult where MinId = " + ""+ objUserAnswerResultEN.MinId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsUserAnswerResultEN._CurrTabName);
if (objDS.Tables[clsUserAnswerResultEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:MinId = " + ""+ objUserAnswerResultEN.MinId+"");
return false;
}
objRow = objDS.Tables[clsUserAnswerResultEN._CurrTabName].Rows[0];
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.QuestionId))
 {
objRow[conUserAnswerResult.QuestionId] = objUserAnswerResultEN.QuestionId; //题目Id
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.CourseId))
 {
objRow[conUserAnswerResult.CourseId] = objUserAnswerResultEN.CourseId; //课程Id
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IdCurrEduCls))
 {
objRow[conUserAnswerResult.IdCurrEduCls] = objUserAnswerResultEN.IdCurrEduCls; //教学班流水号
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.ExamBatchNo))
 {
objRow[conUserAnswerResult.ExamBatchNo] = objUserAnswerResultEN.ExamBatchNo; //学生批次号
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.CourseExamPaperId))
 {
objRow[conUserAnswerResult.CourseExamPaperId] = objUserAnswerResultEN.CourseExamPaperId; //考卷流水号
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerOptionId))
 {
objRow[conUserAnswerResult.AnswerOptionId] = objUserAnswerResultEN.AnswerOptionId; //回答选项Id
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.BatchId))
 {
objRow[conUserAnswerResult.BatchId] = objUserAnswerResultEN.BatchId; //批次ID
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.UserId))
 {
objRow[conUserAnswerResult.UserId] = objUserAnswerResultEN.UserId; //用户ID
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerText))
 {
objRow[conUserAnswerResult.AnswerText] = objUserAnswerResultEN.AnswerText; //回答文本
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerDate))
 {
objRow[conUserAnswerResult.AnswerDate] = objUserAnswerResultEN.AnswerDate; //回答日期
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerTime))
 {
objRow[conUserAnswerResult.AnswerTime] = objUserAnswerResultEN.AnswerTime; //回答时间
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerIP))
 {
objRow[conUserAnswerResult.AnswerIP] = objUserAnswerResultEN.AnswerIP; //回答IP
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsAccess))
 {
objRow[conUserAnswerResult.IsAccess] = objUserAnswerResultEN.IsAccess; //IsAccess
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsAccessC))
 {
objRow[conUserAnswerResult.IsAccessC] = objUserAnswerResultEN.IsAccessC; //IsAccessC
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IdSchool))
 {
objRow[conUserAnswerResult.IdSchool] = objUserAnswerResultEN.IdSchool; //学校流水号
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.School))
 {
objRow[conUserAnswerResult.School] = objUserAnswerResultEN.School; //School
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerMode))
 {
objRow[conUserAnswerResult.AnswerMode] = objUserAnswerResultEN.AnswerMode; //AnswerMode
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsMarking))
 {
objRow[conUserAnswerResult.IsMarking] = objUserAnswerResultEN.IsMarking; //是否批阅
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsRight))
 {
objRow[conUserAnswerResult.IsRight] = objUserAnswerResultEN.IsRight; //是否正确
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.Score))
 {
objRow[conUserAnswerResult.Score] = objUserAnswerResultEN.Score; //得分
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.MarkTime))
 {
objRow[conUserAnswerResult.MarkTime] = objUserAnswerResultEN.MarkTime; //批改时间
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.MarkerId))
 {
objRow[conUserAnswerResult.MarkerId] = objUserAnswerResultEN.MarkerId; //打分者
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.Comment))
 {
objRow[conUserAnswerResult.Comment] = objUserAnswerResultEN.Comment; //批注
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsAccessKnowledge))
 {
objRow[conUserAnswerResult.IsAccessKnowledge] = objUserAnswerResultEN.IsAccessKnowledge; //是否处理知识点
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerId))
 {
objRow[conUserAnswerResult.AnswerId] = objUserAnswerResultEN.AnswerId; //问答ID
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerMultiOption))
 {
objRow[conUserAnswerResult.AnswerMultiOption] = objUserAnswerResultEN.AnswerMultiOption; //多选项答案
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.UpdDate))
 {
objRow[conUserAnswerResult.UpdDate] = objUserAnswerResultEN.UpdDate; //修改日期
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.UpdUser))
 {
objRow[conUserAnswerResult.UpdUser] = objUserAnswerResultEN.UpdUser; //修改人
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.Memo))
 {
objRow[conUserAnswerResult.Memo] = objUserAnswerResultEN.Memo; //备注
 }
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.QuestionnaireSetId))
 {
objRow[conUserAnswerResult.QuestionnaireSetId] = objUserAnswerResultEN.QuestionnaireSetId; //问卷集ID
 }
try
{
objDA.Update(objDS, clsUserAnswerResultEN._CurrTabName);
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
 /// <param name = "objUserAnswerResultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserAnswerResultEN objUserAnswerResultEN)
{
 objUserAnswerResultEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserAnswerResultEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserAnswerResultEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update UserAnswerResult Set ");
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.QuestionId))
 {
 if (objUserAnswerResultEN.QuestionId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserAnswerResultEN.QuestionId, conUserAnswerResult.QuestionId); //题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.QuestionId); //题目Id
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.CourseId))
 {
 if (objUserAnswerResultEN.CourseId !=  null)
 {
 var strCourseId = objUserAnswerResultEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conUserAnswerResult.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.CourseId); //课程Id
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IdCurrEduCls))
 {
 if (objUserAnswerResultEN.IdCurrEduCls  ==  "")
 {
 objUserAnswerResultEN.IdCurrEduCls = null;
 }
 if (objUserAnswerResultEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objUserAnswerResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conUserAnswerResult.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.ExamBatchNo))
 {
 if (objUserAnswerResultEN.ExamBatchNo !=  null)
 {
 var strExamBatchNo = objUserAnswerResultEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamBatchNo, conUserAnswerResult.ExamBatchNo); //学生批次号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.ExamBatchNo); //学生批次号
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.CourseExamPaperId))
 {
 if (objUserAnswerResultEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objUserAnswerResultEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseExamPaperId, conUserAnswerResult.CourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.CourseExamPaperId); //考卷流水号
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerOptionId))
 {
 if (objUserAnswerResultEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objUserAnswerResultEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerOptionId, conUserAnswerResult.AnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerOptionId); //回答选项Id
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.BatchId))
 {
 if (objUserAnswerResultEN.BatchId !=  null)
 {
 var strBatchId = objUserAnswerResultEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBatchId, conUserAnswerResult.BatchId); //批次ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.BatchId); //批次ID
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.UserId))
 {
 if (objUserAnswerResultEN.UserId !=  null)
 {
 var strUserId = objUserAnswerResultEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conUserAnswerResult.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.UserId); //用户ID
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerText))
 {
 if (objUserAnswerResultEN.AnswerText !=  null)
 {
 var strAnswerText = objUserAnswerResultEN.AnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerText, conUserAnswerResult.AnswerText); //回答文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerText); //回答文本
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerDate))
 {
 if (objUserAnswerResultEN.AnswerDate !=  null)
 {
 var strAnswerDate = objUserAnswerResultEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerDate, conUserAnswerResult.AnswerDate); //回答日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerDate); //回答日期
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerTime))
 {
 if (objUserAnswerResultEN.AnswerTime !=  null)
 {
 var strAnswerTime = objUserAnswerResultEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTime, conUserAnswerResult.AnswerTime); //回答时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerTime); //回答时间
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerIP))
 {
 if (objUserAnswerResultEN.AnswerIP !=  null)
 {
 var strAnswerIP = objUserAnswerResultEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerIP, conUserAnswerResult.AnswerIP); //回答IP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerIP); //回答IP
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsAccess))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserAnswerResultEN.IsAccess == true?"1":"0", conUserAnswerResult.IsAccess); //IsAccess
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsAccessC))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserAnswerResultEN.IsAccessC == true?"1":"0", conUserAnswerResult.IsAccessC); //IsAccessC
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IdSchool))
 {
 if (objUserAnswerResultEN.IdSchool !=  null)
 {
 var strIdSchool = objUserAnswerResultEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchool, conUserAnswerResult.IdSchool); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.IdSchool); //学校流水号
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.School))
 {
 if (objUserAnswerResultEN.School !=  null)
 {
 var strSchool = objUserAnswerResultEN.School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchool, conUserAnswerResult.School); //School
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.School); //School
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerMode))
 {
 if (objUserAnswerResultEN.AnswerMode !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserAnswerResultEN.AnswerMode, conUserAnswerResult.AnswerMode); //AnswerMode
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerMode); //AnswerMode
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsMarking))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserAnswerResultEN.IsMarking == true?"1":"0", conUserAnswerResult.IsMarking); //是否批阅
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserAnswerResultEN.IsRight == true?"1":"0", conUserAnswerResult.IsRight); //是否正确
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.Score))
 {
 if (objUserAnswerResultEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserAnswerResultEN.Score, conUserAnswerResult.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.Score); //得分
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.MarkTime))
 {
 if (objUserAnswerResultEN.MarkTime !=  null)
 {
 var strMarkTime = objUserAnswerResultEN.MarkTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkTime, conUserAnswerResult.MarkTime); //批改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.MarkTime); //批改时间
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.MarkerId))
 {
 if (objUserAnswerResultEN.MarkerId !=  null)
 {
 var strMarkerId = objUserAnswerResultEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkerId, conUserAnswerResult.MarkerId); //打分者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.MarkerId); //打分者
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.Comment))
 {
 if (objUserAnswerResultEN.Comment !=  null)
 {
 var strComment = objUserAnswerResultEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strComment, conUserAnswerResult.Comment); //批注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.Comment); //批注
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserAnswerResultEN.IsAccessKnowledge == true?"1":"0", conUserAnswerResult.IsAccessKnowledge); //是否处理知识点
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerId))
 {
 if (objUserAnswerResultEN.AnswerId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserAnswerResultEN.AnswerId, conUserAnswerResult.AnswerId); //问答ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerId); //问答ID
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerMultiOption))
 {
 if (objUserAnswerResultEN.AnswerMultiOption !=  null)
 {
 var strAnswerMultiOption = objUserAnswerResultEN.AnswerMultiOption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerMultiOption, conUserAnswerResult.AnswerMultiOption); //多选项答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerMultiOption); //多选项答案
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.UpdDate))
 {
 if (objUserAnswerResultEN.UpdDate !=  null)
 {
 var strUpdDate = objUserAnswerResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conUserAnswerResult.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.UpdDate); //修改日期
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.UpdUser))
 {
 if (objUserAnswerResultEN.UpdUser !=  null)
 {
 var strUpdUser = objUserAnswerResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conUserAnswerResult.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.UpdUser); //修改人
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.Memo))
 {
 if (objUserAnswerResultEN.Memo !=  null)
 {
 var strMemo = objUserAnswerResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserAnswerResult.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.Memo); //备注
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.QuestionnaireSetId))
 {
 if (objUserAnswerResultEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objUserAnswerResultEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionnaireSetId, conUserAnswerResult.QuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.QuestionnaireSetId); //问卷集ID
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where MinId = {0}", objUserAnswerResultEN.MinId); 
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
 /// <param name = "objUserAnswerResultEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsUserAnswerResultEN objUserAnswerResultEN, string strCondition)
{
 objUserAnswerResultEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserAnswerResultEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserAnswerResultEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserAnswerResult Set ");
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.QuestionId))
 {
 if (objUserAnswerResultEN.QuestionId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserAnswerResultEN.QuestionId, conUserAnswerResult.QuestionId); //题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.QuestionId); //题目Id
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.CourseId))
 {
 if (objUserAnswerResultEN.CourseId !=  null)
 {
 var strCourseId = objUserAnswerResultEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IdCurrEduCls))
 {
 if (objUserAnswerResultEN.IdCurrEduCls  ==  "")
 {
 objUserAnswerResultEN.IdCurrEduCls = null;
 }
 if (objUserAnswerResultEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objUserAnswerResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.ExamBatchNo))
 {
 if (objUserAnswerResultEN.ExamBatchNo !=  null)
 {
 var strExamBatchNo = objUserAnswerResultEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamBatchNo = '{0}',", strExamBatchNo); //学生批次号
 }
 else
 {
 sbSQL.Append(" ExamBatchNo = null,"); //学生批次号
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.CourseExamPaperId))
 {
 if (objUserAnswerResultEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objUserAnswerResultEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseExamPaperId = '{0}',", strCourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.Append(" CourseExamPaperId = null,"); //考卷流水号
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerOptionId))
 {
 if (objUserAnswerResultEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objUserAnswerResultEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerOptionId = '{0}',", strAnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.Append(" AnswerOptionId = null,"); //回答选项Id
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.BatchId))
 {
 if (objUserAnswerResultEN.BatchId !=  null)
 {
 var strBatchId = objUserAnswerResultEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BatchId = '{0}',", strBatchId); //批次ID
 }
 else
 {
 sbSQL.Append(" BatchId = null,"); //批次ID
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.UserId))
 {
 if (objUserAnswerResultEN.UserId !=  null)
 {
 var strUserId = objUserAnswerResultEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerText))
 {
 if (objUserAnswerResultEN.AnswerText !=  null)
 {
 var strAnswerText = objUserAnswerResultEN.AnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerText = '{0}',", strAnswerText); //回答文本
 }
 else
 {
 sbSQL.Append(" AnswerText = null,"); //回答文本
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerDate))
 {
 if (objUserAnswerResultEN.AnswerDate !=  null)
 {
 var strAnswerDate = objUserAnswerResultEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerDate = '{0}',", strAnswerDate); //回答日期
 }
 else
 {
 sbSQL.Append(" AnswerDate = null,"); //回答日期
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerTime))
 {
 if (objUserAnswerResultEN.AnswerTime !=  null)
 {
 var strAnswerTime = objUserAnswerResultEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTime = '{0}',", strAnswerTime); //回答时间
 }
 else
 {
 sbSQL.Append(" AnswerTime = null,"); //回答时间
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerIP))
 {
 if (objUserAnswerResultEN.AnswerIP !=  null)
 {
 var strAnswerIP = objUserAnswerResultEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerIP = '{0}',", strAnswerIP); //回答IP
 }
 else
 {
 sbSQL.Append(" AnswerIP = null,"); //回答IP
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsAccess))
 {
 sbSQL.AppendFormat(" IsAccess = '{0}',", objUserAnswerResultEN.IsAccess == true?"1":"0"); //IsAccess
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsAccessC))
 {
 sbSQL.AppendFormat(" IsAccessC = '{0}',", objUserAnswerResultEN.IsAccessC == true?"1":"0"); //IsAccessC
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IdSchool))
 {
 if (objUserAnswerResultEN.IdSchool !=  null)
 {
 var strIdSchool = objUserAnswerResultEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchool = '{0}',", strIdSchool); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchool = null,"); //学校流水号
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.School))
 {
 if (objUserAnswerResultEN.School !=  null)
 {
 var strSchool = objUserAnswerResultEN.School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" School = '{0}',", strSchool); //School
 }
 else
 {
 sbSQL.Append(" School = null,"); //School
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerMode))
 {
 if (objUserAnswerResultEN.AnswerMode !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserAnswerResultEN.AnswerMode, conUserAnswerResult.AnswerMode); //AnswerMode
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerMode); //AnswerMode
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsMarking))
 {
 sbSQL.AppendFormat(" IsMarking = '{0}',", objUserAnswerResultEN.IsMarking == true?"1":"0"); //是否批阅
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objUserAnswerResultEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.Score))
 {
 if (objUserAnswerResultEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserAnswerResultEN.Score, conUserAnswerResult.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.Score); //得分
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.MarkTime))
 {
 if (objUserAnswerResultEN.MarkTime !=  null)
 {
 var strMarkTime = objUserAnswerResultEN.MarkTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkTime = '{0}',", strMarkTime); //批改时间
 }
 else
 {
 sbSQL.Append(" MarkTime = null,"); //批改时间
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.MarkerId))
 {
 if (objUserAnswerResultEN.MarkerId !=  null)
 {
 var strMarkerId = objUserAnswerResultEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkerId = '{0}',", strMarkerId); //打分者
 }
 else
 {
 sbSQL.Append(" MarkerId = null,"); //打分者
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.Comment))
 {
 if (objUserAnswerResultEN.Comment !=  null)
 {
 var strComment = objUserAnswerResultEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Comment = '{0}',", strComment); //批注
 }
 else
 {
 sbSQL.Append(" Comment = null,"); //批注
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" IsAccessKnowledge = '{0}',", objUserAnswerResultEN.IsAccessKnowledge == true?"1":"0"); //是否处理知识点
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerId))
 {
 if (objUserAnswerResultEN.AnswerId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserAnswerResultEN.AnswerId, conUserAnswerResult.AnswerId); //问答ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerId); //问答ID
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerMultiOption))
 {
 if (objUserAnswerResultEN.AnswerMultiOption !=  null)
 {
 var strAnswerMultiOption = objUserAnswerResultEN.AnswerMultiOption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerMultiOption = '{0}',", strAnswerMultiOption); //多选项答案
 }
 else
 {
 sbSQL.Append(" AnswerMultiOption = null,"); //多选项答案
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.UpdDate))
 {
 if (objUserAnswerResultEN.UpdDate !=  null)
 {
 var strUpdDate = objUserAnswerResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.UpdUser))
 {
 if (objUserAnswerResultEN.UpdUser !=  null)
 {
 var strUpdUser = objUserAnswerResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.Memo))
 {
 if (objUserAnswerResultEN.Memo !=  null)
 {
 var strMemo = objUserAnswerResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.QuestionnaireSetId))
 {
 if (objUserAnswerResultEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objUserAnswerResultEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionnaireSetId = '{0}',", strQuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.Append(" QuestionnaireSetId = null,"); //问卷集ID
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
 /// <param name = "objUserAnswerResultEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsUserAnswerResultEN objUserAnswerResultEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUserAnswerResultEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserAnswerResultEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserAnswerResultEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserAnswerResult Set ");
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.QuestionId))
 {
 if (objUserAnswerResultEN.QuestionId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserAnswerResultEN.QuestionId, conUserAnswerResult.QuestionId); //题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.QuestionId); //题目Id
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.CourseId))
 {
 if (objUserAnswerResultEN.CourseId !=  null)
 {
 var strCourseId = objUserAnswerResultEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IdCurrEduCls))
 {
 if (objUserAnswerResultEN.IdCurrEduCls  ==  "")
 {
 objUserAnswerResultEN.IdCurrEduCls = null;
 }
 if (objUserAnswerResultEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objUserAnswerResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.ExamBatchNo))
 {
 if (objUserAnswerResultEN.ExamBatchNo !=  null)
 {
 var strExamBatchNo = objUserAnswerResultEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamBatchNo = '{0}',", strExamBatchNo); //学生批次号
 }
 else
 {
 sbSQL.Append(" ExamBatchNo = null,"); //学生批次号
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.CourseExamPaperId))
 {
 if (objUserAnswerResultEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objUserAnswerResultEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseExamPaperId = '{0}',", strCourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.Append(" CourseExamPaperId = null,"); //考卷流水号
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerOptionId))
 {
 if (objUserAnswerResultEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objUserAnswerResultEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerOptionId = '{0}',", strAnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.Append(" AnswerOptionId = null,"); //回答选项Id
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.BatchId))
 {
 if (objUserAnswerResultEN.BatchId !=  null)
 {
 var strBatchId = objUserAnswerResultEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BatchId = '{0}',", strBatchId); //批次ID
 }
 else
 {
 sbSQL.Append(" BatchId = null,"); //批次ID
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.UserId))
 {
 if (objUserAnswerResultEN.UserId !=  null)
 {
 var strUserId = objUserAnswerResultEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerText))
 {
 if (objUserAnswerResultEN.AnswerText !=  null)
 {
 var strAnswerText = objUserAnswerResultEN.AnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerText = '{0}',", strAnswerText); //回答文本
 }
 else
 {
 sbSQL.Append(" AnswerText = null,"); //回答文本
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerDate))
 {
 if (objUserAnswerResultEN.AnswerDate !=  null)
 {
 var strAnswerDate = objUserAnswerResultEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerDate = '{0}',", strAnswerDate); //回答日期
 }
 else
 {
 sbSQL.Append(" AnswerDate = null,"); //回答日期
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerTime))
 {
 if (objUserAnswerResultEN.AnswerTime !=  null)
 {
 var strAnswerTime = objUserAnswerResultEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTime = '{0}',", strAnswerTime); //回答时间
 }
 else
 {
 sbSQL.Append(" AnswerTime = null,"); //回答时间
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerIP))
 {
 if (objUserAnswerResultEN.AnswerIP !=  null)
 {
 var strAnswerIP = objUserAnswerResultEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerIP = '{0}',", strAnswerIP); //回答IP
 }
 else
 {
 sbSQL.Append(" AnswerIP = null,"); //回答IP
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsAccess))
 {
 sbSQL.AppendFormat(" IsAccess = '{0}',", objUserAnswerResultEN.IsAccess == true?"1":"0"); //IsAccess
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsAccessC))
 {
 sbSQL.AppendFormat(" IsAccessC = '{0}',", objUserAnswerResultEN.IsAccessC == true?"1":"0"); //IsAccessC
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IdSchool))
 {
 if (objUserAnswerResultEN.IdSchool !=  null)
 {
 var strIdSchool = objUserAnswerResultEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchool = '{0}',", strIdSchool); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchool = null,"); //学校流水号
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.School))
 {
 if (objUserAnswerResultEN.School !=  null)
 {
 var strSchool = objUserAnswerResultEN.School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" School = '{0}',", strSchool); //School
 }
 else
 {
 sbSQL.Append(" School = null,"); //School
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerMode))
 {
 if (objUserAnswerResultEN.AnswerMode !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserAnswerResultEN.AnswerMode, conUserAnswerResult.AnswerMode); //AnswerMode
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerMode); //AnswerMode
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsMarking))
 {
 sbSQL.AppendFormat(" IsMarking = '{0}',", objUserAnswerResultEN.IsMarking == true?"1":"0"); //是否批阅
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objUserAnswerResultEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.Score))
 {
 if (objUserAnswerResultEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserAnswerResultEN.Score, conUserAnswerResult.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.Score); //得分
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.MarkTime))
 {
 if (objUserAnswerResultEN.MarkTime !=  null)
 {
 var strMarkTime = objUserAnswerResultEN.MarkTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkTime = '{0}',", strMarkTime); //批改时间
 }
 else
 {
 sbSQL.Append(" MarkTime = null,"); //批改时间
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.MarkerId))
 {
 if (objUserAnswerResultEN.MarkerId !=  null)
 {
 var strMarkerId = objUserAnswerResultEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkerId = '{0}',", strMarkerId); //打分者
 }
 else
 {
 sbSQL.Append(" MarkerId = null,"); //打分者
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.Comment))
 {
 if (objUserAnswerResultEN.Comment !=  null)
 {
 var strComment = objUserAnswerResultEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Comment = '{0}',", strComment); //批注
 }
 else
 {
 sbSQL.Append(" Comment = null,"); //批注
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" IsAccessKnowledge = '{0}',", objUserAnswerResultEN.IsAccessKnowledge == true?"1":"0"); //是否处理知识点
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerId))
 {
 if (objUserAnswerResultEN.AnswerId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserAnswerResultEN.AnswerId, conUserAnswerResult.AnswerId); //问答ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerId); //问答ID
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerMultiOption))
 {
 if (objUserAnswerResultEN.AnswerMultiOption !=  null)
 {
 var strAnswerMultiOption = objUserAnswerResultEN.AnswerMultiOption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerMultiOption = '{0}',", strAnswerMultiOption); //多选项答案
 }
 else
 {
 sbSQL.Append(" AnswerMultiOption = null,"); //多选项答案
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.UpdDate))
 {
 if (objUserAnswerResultEN.UpdDate !=  null)
 {
 var strUpdDate = objUserAnswerResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.UpdUser))
 {
 if (objUserAnswerResultEN.UpdUser !=  null)
 {
 var strUpdUser = objUserAnswerResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.Memo))
 {
 if (objUserAnswerResultEN.Memo !=  null)
 {
 var strMemo = objUserAnswerResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.QuestionnaireSetId))
 {
 if (objUserAnswerResultEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objUserAnswerResultEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionnaireSetId = '{0}',", strQuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.Append(" QuestionnaireSetId = null,"); //问卷集ID
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
 /// <param name = "objUserAnswerResultEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserAnswerResultEN objUserAnswerResultEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUserAnswerResultEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserAnswerResultEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserAnswerResultEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserAnswerResult Set ");
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.QuestionId))
 {
 if (objUserAnswerResultEN.QuestionId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserAnswerResultEN.QuestionId, conUserAnswerResult.QuestionId); //题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.QuestionId); //题目Id
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.CourseId))
 {
 if (objUserAnswerResultEN.CourseId !=  null)
 {
 var strCourseId = objUserAnswerResultEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conUserAnswerResult.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.CourseId); //课程Id
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IdCurrEduCls))
 {
 if (objUserAnswerResultEN.IdCurrEduCls  ==  "")
 {
 objUserAnswerResultEN.IdCurrEduCls = null;
 }
 if (objUserAnswerResultEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objUserAnswerResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conUserAnswerResult.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.ExamBatchNo))
 {
 if (objUserAnswerResultEN.ExamBatchNo !=  null)
 {
 var strExamBatchNo = objUserAnswerResultEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamBatchNo, conUserAnswerResult.ExamBatchNo); //学生批次号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.ExamBatchNo); //学生批次号
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.CourseExamPaperId))
 {
 if (objUserAnswerResultEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objUserAnswerResultEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseExamPaperId, conUserAnswerResult.CourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.CourseExamPaperId); //考卷流水号
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerOptionId))
 {
 if (objUserAnswerResultEN.AnswerOptionId !=  null)
 {
 var strAnswerOptionId = objUserAnswerResultEN.AnswerOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerOptionId, conUserAnswerResult.AnswerOptionId); //回答选项Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerOptionId); //回答选项Id
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.BatchId))
 {
 if (objUserAnswerResultEN.BatchId !=  null)
 {
 var strBatchId = objUserAnswerResultEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBatchId, conUserAnswerResult.BatchId); //批次ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.BatchId); //批次ID
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.UserId))
 {
 if (objUserAnswerResultEN.UserId !=  null)
 {
 var strUserId = objUserAnswerResultEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conUserAnswerResult.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.UserId); //用户ID
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerText))
 {
 if (objUserAnswerResultEN.AnswerText !=  null)
 {
 var strAnswerText = objUserAnswerResultEN.AnswerText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerText, conUserAnswerResult.AnswerText); //回答文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerText); //回答文本
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerDate))
 {
 if (objUserAnswerResultEN.AnswerDate !=  null)
 {
 var strAnswerDate = objUserAnswerResultEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerDate, conUserAnswerResult.AnswerDate); //回答日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerDate); //回答日期
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerTime))
 {
 if (objUserAnswerResultEN.AnswerTime !=  null)
 {
 var strAnswerTime = objUserAnswerResultEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTime, conUserAnswerResult.AnswerTime); //回答时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerTime); //回答时间
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerIP))
 {
 if (objUserAnswerResultEN.AnswerIP !=  null)
 {
 var strAnswerIP = objUserAnswerResultEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerIP, conUserAnswerResult.AnswerIP); //回答IP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerIP); //回答IP
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsAccess))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserAnswerResultEN.IsAccess == true?"1":"0", conUserAnswerResult.IsAccess); //IsAccess
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsAccessC))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserAnswerResultEN.IsAccessC == true?"1":"0", conUserAnswerResult.IsAccessC); //IsAccessC
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IdSchool))
 {
 if (objUserAnswerResultEN.IdSchool !=  null)
 {
 var strIdSchool = objUserAnswerResultEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchool, conUserAnswerResult.IdSchool); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.IdSchool); //学校流水号
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.School))
 {
 if (objUserAnswerResultEN.School !=  null)
 {
 var strSchool = objUserAnswerResultEN.School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchool, conUserAnswerResult.School); //School
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.School); //School
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerMode))
 {
 if (objUserAnswerResultEN.AnswerMode !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserAnswerResultEN.AnswerMode, conUserAnswerResult.AnswerMode); //AnswerMode
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerMode); //AnswerMode
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsMarking))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserAnswerResultEN.IsMarking == true?"1":"0", conUserAnswerResult.IsMarking); //是否批阅
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserAnswerResultEN.IsRight == true?"1":"0", conUserAnswerResult.IsRight); //是否正确
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.Score))
 {
 if (objUserAnswerResultEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserAnswerResultEN.Score, conUserAnswerResult.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.Score); //得分
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.MarkTime))
 {
 if (objUserAnswerResultEN.MarkTime !=  null)
 {
 var strMarkTime = objUserAnswerResultEN.MarkTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkTime, conUserAnswerResult.MarkTime); //批改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.MarkTime); //批改时间
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.MarkerId))
 {
 if (objUserAnswerResultEN.MarkerId !=  null)
 {
 var strMarkerId = objUserAnswerResultEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkerId, conUserAnswerResult.MarkerId); //打分者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.MarkerId); //打分者
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.Comment))
 {
 if (objUserAnswerResultEN.Comment !=  null)
 {
 var strComment = objUserAnswerResultEN.Comment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strComment, conUserAnswerResult.Comment); //批注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.Comment); //批注
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.IsAccessKnowledge))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserAnswerResultEN.IsAccessKnowledge == true?"1":"0", conUserAnswerResult.IsAccessKnowledge); //是否处理知识点
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerId))
 {
 if (objUserAnswerResultEN.AnswerId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserAnswerResultEN.AnswerId, conUserAnswerResult.AnswerId); //问答ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerId); //问答ID
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.AnswerMultiOption))
 {
 if (objUserAnswerResultEN.AnswerMultiOption !=  null)
 {
 var strAnswerMultiOption = objUserAnswerResultEN.AnswerMultiOption.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerMultiOption, conUserAnswerResult.AnswerMultiOption); //多选项答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.AnswerMultiOption); //多选项答案
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.UpdDate))
 {
 if (objUserAnswerResultEN.UpdDate !=  null)
 {
 var strUpdDate = objUserAnswerResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conUserAnswerResult.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.UpdDate); //修改日期
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.UpdUser))
 {
 if (objUserAnswerResultEN.UpdUser !=  null)
 {
 var strUpdUser = objUserAnswerResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conUserAnswerResult.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.UpdUser); //修改人
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.Memo))
 {
 if (objUserAnswerResultEN.Memo !=  null)
 {
 var strMemo = objUserAnswerResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserAnswerResult.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.Memo); //备注
 }
 }
 
 if (objUserAnswerResultEN.IsUpdated(conUserAnswerResult.QuestionnaireSetId))
 {
 if (objUserAnswerResultEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objUserAnswerResultEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionnaireSetId, conUserAnswerResult.QuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserAnswerResult.QuestionnaireSetId); //问卷集ID
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where MinId = {0}", objUserAnswerResultEN.MinId); 
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
 /// <param name = "lngMinId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngMinId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngMinId,
};
 objSQL.ExecSP("UserAnswerResult_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngMinId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngMinId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
//删除UserAnswerResult本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserAnswerResult where MinId = " + ""+ lngMinId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelUserAnswerResult(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除UserAnswerResult本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserAnswerResult where MinId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngMinId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngMinId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
//删除UserAnswerResult本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserAnswerResult where MinId = " + ""+ lngMinId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelUserAnswerResult(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsUserAnswerResultDA: DelUserAnswerResult)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserAnswerResult where " + strCondition ;
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
public bool DelUserAnswerResultWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsUserAnswerResultDA: DelUserAnswerResultWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserAnswerResult where " + strCondition ;
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
 /// <param name = "objUserAnswerResultENS">源对象</param>
 /// <param name = "objUserAnswerResultENT">目标对象</param>
public void CopyTo(clsUserAnswerResultEN objUserAnswerResultENS, clsUserAnswerResultEN objUserAnswerResultENT)
{
objUserAnswerResultENT.MinId = objUserAnswerResultENS.MinId; //MinId
objUserAnswerResultENT.QuestionId = objUserAnswerResultENS.QuestionId; //题目Id
objUserAnswerResultENT.CourseId = objUserAnswerResultENS.CourseId; //课程Id
objUserAnswerResultENT.IdCurrEduCls = objUserAnswerResultENS.IdCurrEduCls; //教学班流水号
objUserAnswerResultENT.ExamBatchNo = objUserAnswerResultENS.ExamBatchNo; //学生批次号
objUserAnswerResultENT.CourseExamPaperId = objUserAnswerResultENS.CourseExamPaperId; //考卷流水号
objUserAnswerResultENT.AnswerOptionId = objUserAnswerResultENS.AnswerOptionId; //回答选项Id
objUserAnswerResultENT.BatchId = objUserAnswerResultENS.BatchId; //批次ID
objUserAnswerResultENT.UserId = objUserAnswerResultENS.UserId; //用户ID
objUserAnswerResultENT.AnswerText = objUserAnswerResultENS.AnswerText; //回答文本
objUserAnswerResultENT.AnswerDate = objUserAnswerResultENS.AnswerDate; //回答日期
objUserAnswerResultENT.AnswerTime = objUserAnswerResultENS.AnswerTime; //回答时间
objUserAnswerResultENT.AnswerIP = objUserAnswerResultENS.AnswerIP; //回答IP
objUserAnswerResultENT.IsAccess = objUserAnswerResultENS.IsAccess; //IsAccess
objUserAnswerResultENT.IsAccessC = objUserAnswerResultENS.IsAccessC; //IsAccessC
objUserAnswerResultENT.IdSchool = objUserAnswerResultENS.IdSchool; //学校流水号
objUserAnswerResultENT.School = objUserAnswerResultENS.School; //School
objUserAnswerResultENT.AnswerMode = objUserAnswerResultENS.AnswerMode; //AnswerMode
objUserAnswerResultENT.IsMarking = objUserAnswerResultENS.IsMarking; //是否批阅
objUserAnswerResultENT.IsRight = objUserAnswerResultENS.IsRight; //是否正确
objUserAnswerResultENT.Score = objUserAnswerResultENS.Score; //得分
objUserAnswerResultENT.MarkTime = objUserAnswerResultENS.MarkTime; //批改时间
objUserAnswerResultENT.MarkerId = objUserAnswerResultENS.MarkerId; //打分者
objUserAnswerResultENT.Comment = objUserAnswerResultENS.Comment; //批注
objUserAnswerResultENT.IsAccessKnowledge = objUserAnswerResultENS.IsAccessKnowledge; //是否处理知识点
objUserAnswerResultENT.AnswerId = objUserAnswerResultENS.AnswerId; //问答ID
objUserAnswerResultENT.AnswerMultiOption = objUserAnswerResultENS.AnswerMultiOption; //多选项答案
objUserAnswerResultENT.UpdDate = objUserAnswerResultENS.UpdDate; //修改日期
objUserAnswerResultENT.UpdUser = objUserAnswerResultENS.UpdUser; //修改人
objUserAnswerResultENT.Memo = objUserAnswerResultENS.Memo; //备注
objUserAnswerResultENT.QuestionnaireSetId = objUserAnswerResultENS.QuestionnaireSetId; //问卷集ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsUserAnswerResultEN objUserAnswerResultEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objUserAnswerResultEN.UpdDate, conUserAnswerResult.UpdDate);
clsCheckSql.CheckFieldNotNull(objUserAnswerResultEN.UpdUser, conUserAnswerResult.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.CourseId, 8, conUserAnswerResult.CourseId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.IdCurrEduCls, 8, conUserAnswerResult.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.ExamBatchNo, 20, conUserAnswerResult.ExamBatchNo);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.CourseExamPaperId, 8, conUserAnswerResult.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerOptionId, 8, conUserAnswerResult.AnswerOptionId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.BatchId, 4, conUserAnswerResult.BatchId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.UserId, 18, conUserAnswerResult.UserId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerText, 8000, conUserAnswerResult.AnswerText);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerDate, 8, conUserAnswerResult.AnswerDate);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerTime, 10, conUserAnswerResult.AnswerTime);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerIP, 30, conUserAnswerResult.AnswerIP);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.IdSchool, 4, conUserAnswerResult.IdSchool);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.School, 50, conUserAnswerResult.School);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.MarkTime, 14, conUserAnswerResult.MarkTime);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.MarkerId, 20, conUserAnswerResult.MarkerId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerMultiOption, 300, conUserAnswerResult.AnswerMultiOption);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.UpdDate, 20, conUserAnswerResult.UpdDate);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.UpdUser, 20, conUserAnswerResult.UpdUser);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.Memo, 1000, conUserAnswerResult.Memo);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.QuestionnaireSetId, 4, conUserAnswerResult.QuestionnaireSetId);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objUserAnswerResultEN.IdCurrEduCls, 8, conUserAnswerResult.IdCurrEduCls);
 objUserAnswerResultEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsUserAnswerResultEN objUserAnswerResultEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.CourseId, 8, conUserAnswerResult.CourseId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.IdCurrEduCls, 8, conUserAnswerResult.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.ExamBatchNo, 20, conUserAnswerResult.ExamBatchNo);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.CourseExamPaperId, 8, conUserAnswerResult.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerOptionId, 8, conUserAnswerResult.AnswerOptionId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.BatchId, 4, conUserAnswerResult.BatchId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.UserId, 18, conUserAnswerResult.UserId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerText, 8000, conUserAnswerResult.AnswerText);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerDate, 8, conUserAnswerResult.AnswerDate);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerTime, 10, conUserAnswerResult.AnswerTime);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerIP, 30, conUserAnswerResult.AnswerIP);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.IdSchool, 4, conUserAnswerResult.IdSchool);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.School, 50, conUserAnswerResult.School);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.MarkTime, 14, conUserAnswerResult.MarkTime);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.MarkerId, 20, conUserAnswerResult.MarkerId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerMultiOption, 300, conUserAnswerResult.AnswerMultiOption);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.UpdDate, 20, conUserAnswerResult.UpdDate);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.UpdUser, 20, conUserAnswerResult.UpdUser);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.Memo, 1000, conUserAnswerResult.Memo);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.QuestionnaireSetId, 4, conUserAnswerResult.QuestionnaireSetId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objUserAnswerResultEN.IdCurrEduCls, 8, conUserAnswerResult.IdCurrEduCls);
 objUserAnswerResultEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsUserAnswerResultEN objUserAnswerResultEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.CourseId, 8, conUserAnswerResult.CourseId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.IdCurrEduCls, 8, conUserAnswerResult.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.ExamBatchNo, 20, conUserAnswerResult.ExamBatchNo);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.CourseExamPaperId, 8, conUserAnswerResult.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerOptionId, 8, conUserAnswerResult.AnswerOptionId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.BatchId, 4, conUserAnswerResult.BatchId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.UserId, 18, conUserAnswerResult.UserId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerText, 8000, conUserAnswerResult.AnswerText);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerDate, 8, conUserAnswerResult.AnswerDate);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerTime, 10, conUserAnswerResult.AnswerTime);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerIP, 30, conUserAnswerResult.AnswerIP);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.IdSchool, 4, conUserAnswerResult.IdSchool);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.School, 50, conUserAnswerResult.School);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.MarkTime, 14, conUserAnswerResult.MarkTime);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.MarkerId, 20, conUserAnswerResult.MarkerId);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.AnswerMultiOption, 300, conUserAnswerResult.AnswerMultiOption);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.UpdDate, 20, conUserAnswerResult.UpdDate);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.UpdUser, 20, conUserAnswerResult.UpdUser);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.Memo, 1000, conUserAnswerResult.Memo);
clsCheckSql.CheckFieldLen(objUserAnswerResultEN.QuestionnaireSetId, 4, conUserAnswerResult.QuestionnaireSetId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.CourseId, conUserAnswerResult.CourseId);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.IdCurrEduCls, conUserAnswerResult.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.ExamBatchNo, conUserAnswerResult.ExamBatchNo);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.CourseExamPaperId, conUserAnswerResult.CourseExamPaperId);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.AnswerOptionId, conUserAnswerResult.AnswerOptionId);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.BatchId, conUserAnswerResult.BatchId);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.UserId, conUserAnswerResult.UserId);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.AnswerText, conUserAnswerResult.AnswerText);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.AnswerDate, conUserAnswerResult.AnswerDate);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.AnswerTime, conUserAnswerResult.AnswerTime);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.AnswerIP, conUserAnswerResult.AnswerIP);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.IdSchool, conUserAnswerResult.IdSchool);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.School, conUserAnswerResult.School);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.MarkTime, conUserAnswerResult.MarkTime);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.MarkerId, conUserAnswerResult.MarkerId);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.AnswerMultiOption, conUserAnswerResult.AnswerMultiOption);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.UpdDate, conUserAnswerResult.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.UpdUser, conUserAnswerResult.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.Memo, conUserAnswerResult.Memo);
clsCheckSql.CheckSqlInjection4Field(objUserAnswerResultEN.QuestionnaireSetId, conUserAnswerResult.QuestionnaireSetId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objUserAnswerResultEN.IdCurrEduCls, 8, conUserAnswerResult.IdCurrEduCls);
 objUserAnswerResultEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--UserAnswerResult(用户答题结果),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsUserAnswerResultEN objUserAnswerResultEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objUserAnswerResultEN.CourseExamPaperId == null)
{
 sbCondition.AppendFormat(" and CourseExamPaperId is null");
}
else
{
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objUserAnswerResultEN.CourseExamPaperId);
}
 if (objUserAnswerResultEN.QuestionId == null)
{
 sbCondition.AppendFormat(" and QuestionId is null");
}
else
{
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objUserAnswerResultEN.QuestionId);
}
 if (objUserAnswerResultEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null");
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserAnswerResultEN.UserId);
}
 if (objUserAnswerResultEN.ExamBatchNo == null)
{
 sbCondition.AppendFormat(" and ExamBatchNo is null");
}
else
{
 sbCondition.AppendFormat(" and ExamBatchNo = '{0}'", objUserAnswerResultEN.ExamBatchNo);
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
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
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
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
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
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserAnswerResultEN._CurrTabName);
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
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserAnswerResultEN._CurrTabName, strCondition);
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
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
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
 objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}