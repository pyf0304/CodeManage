
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionnaireDA
 表名:Questionnaire(01120001)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:17
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
 /// 题目(Questionnaire)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQuestionnaireDA : clsCommBase4DA
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
 return clsQuestionnaireEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQuestionnaireEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQuestionnaireEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQuestionnaireEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQuestionnaireEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQuestionnaireDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
strSQL = "Select * from Questionnaire where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Questionnaire(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQuestionnaireDA: GetDataTable_Questionnaire)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
strSQL = "Select * from Questionnaire where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQuestionnaireDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQuestionnaireDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
strSQL = "Select * from Questionnaire where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQuestionnaireDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQuestionnaireDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Questionnaire where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Questionnaire where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQuestionnaireDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Questionnaire where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQuestionnaireDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Questionnaire.* from Questionnaire Left Join {1} on {2} where {3} and Questionnaire.QuestionId not in (Select top {5} Questionnaire.QuestionId from Questionnaire Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Questionnaire where {1} and QuestionId not in (Select top {2} QuestionId from Questionnaire where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Questionnaire where {1} and QuestionId not in (Select top {3} QuestionId from Questionnaire where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQuestionnaireDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Questionnaire.* from Questionnaire Left Join {1} on {2} where {3} and Questionnaire.QuestionId not in (Select top {5} Questionnaire.QuestionId from Questionnaire Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Questionnaire where {1} and QuestionId not in (Select top {2} QuestionId from Questionnaire where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Questionnaire where {1} and QuestionId not in (Select top {3} QuestionId from Questionnaire where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsQuestionnaireEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQuestionnaireDA:GetObjLst)", objException.Message));
}
List<clsQuestionnaireEN> arrObjLst = new List<clsQuestionnaireEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
strSQL = "Select * from Questionnaire where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN();
try
{
objQuestionnaireEN.QuestionId = TransNullToInt(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireEN.QuestionIndex = objRow[conQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireEN.QuestionName = objRow[conQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireEN.QuestionContent = objRow[conQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireEN.QuestionMemo = objRow[conQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireEN.QuestionNo = objRow[conQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireEN.ParentQuestionId = objRow[conQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireEN.ExamAnswer = objRow[conQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireEN.CourseId = objRow[conQuestionnaire.CourseId].ToString().Trim(); //课程Id
objQuestionnaireEN.LevelNo = objRow[conQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireEN.CourseChapterId = objRow[conQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireEN.QuestionTypeId = objRow[conQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireEN.QuestionTypeId4Course = objRow[conQuestionnaire.QuestionTypeId4Course] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireEN.AnswerTypeId = objRow[conQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireEN.GridTitle = objRow[conQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireEN.AnswerModeId = objRow[conQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireEN.IsHaveAdditionalMemo = TransNullToBool(objRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireEN.QuestionScore = objRow[conQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireEN.DefaultValue = objRow[conQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireEN.DefaultSelectItem = objRow[conQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireEN.IsShow = TransNullToBool(objRow[conQuestionnaire.IsShow].ToString().Trim()); //是否启用
objQuestionnaireEN.IsCast = TransNullToBool(objRow[conQuestionnaire.IsCast].ToString().Trim()); //是否播放
objQuestionnaireEN.LikeCount = objRow[conQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireEN.AnswerAttLimitSize = objRow[conQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireEN.LimitedResourceType = objRow[conQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireEN.IsEffective = TransNullToBool(objRow[conQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireEN.IsCanInPaper = TransNullToBool(objRow[conQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireEN.ExamGradeId = objRow[conQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireEN.TextDirectId = objRow[conQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireEN.UpdDate = objRow[conQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireEN.UpdUser = objRow[conQuestionnaire.UpdUser].ToString().Trim(); //修改人
objQuestionnaireEN.Memo = objRow[conQuestionnaire.Memo] == DBNull.Value ? null : objRow[conQuestionnaire.Memo].ToString().Trim(); //备注
objQuestionnaireEN.QuestionCode = objRow[conQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objQuestionnaireEN.DifficultyLevelId = objRow[conQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[conQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objQuestionnaireEN.SectionTypeId = objRow[conQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objQuestionnaireEN.KnowledgeGraphId = objRow[conQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[conQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objQuestionnaireEN.FirstIndent = TransNullToBool(objRow[conQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireEN.QuestionNameAdd = objRow[conQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireEN.CodeTab = objRow[conQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTab].ToString().Trim(); //代码表
objQuestionnaireEN.CodeTabCode = objRow[conQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireEN.CodeTabCondition = objRow[conQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireEN.CodeTabName = objRow[conQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireEN.FillInTextHeight = objRow[conQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireEN.FillInTextWidth = objRow[conQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireEN.IsMulti4FillInText = TransNullToBool(objRow[conQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireEN.CheckBoxLimitCount = objRow[conQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireEN.IsJs = TransNullToBool(objRow[conQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objQuestionnaireEN.MemoTextWidth = objRow[conQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireEN.RelaEvent = objRow[conQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireEN.IsTest = TransNullToBool(objRow[conQuestionnaire.IsTest].ToString().Trim()); //是否测试
objQuestionnaireEN.LevelModeTypeId = objRow[conQuestionnaire.LevelModeTypeId].ToString().Trim(); //模式Id
objQuestionnaireEN.IsRandom = TransNullToBool(objRow[conQuestionnaire.IsRandom].ToString().Trim()); //是否随机
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQuestionnaireDA: GetObjLst)", objException.Message));
}
objQuestionnaireEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQuestionnaireEN);
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
public List<clsQuestionnaireEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQuestionnaireDA:GetObjLstByTabName)", objException.Message));
}
List<clsQuestionnaireEN> arrObjLst = new List<clsQuestionnaireEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN();
try
{
objQuestionnaireEN.QuestionId = TransNullToInt(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireEN.QuestionIndex = objRow[conQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireEN.QuestionName = objRow[conQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireEN.QuestionContent = objRow[conQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireEN.QuestionMemo = objRow[conQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireEN.QuestionNo = objRow[conQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireEN.ParentQuestionId = objRow[conQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireEN.ExamAnswer = objRow[conQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireEN.CourseId = objRow[conQuestionnaire.CourseId].ToString().Trim(); //课程Id
objQuestionnaireEN.LevelNo = objRow[conQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireEN.CourseChapterId = objRow[conQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireEN.QuestionTypeId = objRow[conQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireEN.QuestionTypeId4Course = objRow[conQuestionnaire.QuestionTypeId4Course] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireEN.AnswerTypeId = objRow[conQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireEN.GridTitle = objRow[conQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireEN.AnswerModeId = objRow[conQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireEN.IsHaveAdditionalMemo = TransNullToBool(objRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireEN.QuestionScore = objRow[conQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireEN.DefaultValue = objRow[conQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireEN.DefaultSelectItem = objRow[conQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireEN.IsShow = TransNullToBool(objRow[conQuestionnaire.IsShow].ToString().Trim()); //是否启用
objQuestionnaireEN.IsCast = TransNullToBool(objRow[conQuestionnaire.IsCast].ToString().Trim()); //是否播放
objQuestionnaireEN.LikeCount = objRow[conQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireEN.AnswerAttLimitSize = objRow[conQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireEN.LimitedResourceType = objRow[conQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireEN.IsEffective = TransNullToBool(objRow[conQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireEN.IsCanInPaper = TransNullToBool(objRow[conQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireEN.ExamGradeId = objRow[conQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireEN.TextDirectId = objRow[conQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireEN.UpdDate = objRow[conQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireEN.UpdUser = objRow[conQuestionnaire.UpdUser].ToString().Trim(); //修改人
objQuestionnaireEN.Memo = objRow[conQuestionnaire.Memo] == DBNull.Value ? null : objRow[conQuestionnaire.Memo].ToString().Trim(); //备注
objQuestionnaireEN.QuestionCode = objRow[conQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objQuestionnaireEN.DifficultyLevelId = objRow[conQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[conQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objQuestionnaireEN.SectionTypeId = objRow[conQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objQuestionnaireEN.KnowledgeGraphId = objRow[conQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[conQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objQuestionnaireEN.FirstIndent = TransNullToBool(objRow[conQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireEN.QuestionNameAdd = objRow[conQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireEN.CodeTab = objRow[conQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTab].ToString().Trim(); //代码表
objQuestionnaireEN.CodeTabCode = objRow[conQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireEN.CodeTabCondition = objRow[conQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireEN.CodeTabName = objRow[conQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireEN.FillInTextHeight = objRow[conQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireEN.FillInTextWidth = objRow[conQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireEN.IsMulti4FillInText = TransNullToBool(objRow[conQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireEN.CheckBoxLimitCount = objRow[conQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireEN.IsJs = TransNullToBool(objRow[conQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objQuestionnaireEN.MemoTextWidth = objRow[conQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireEN.RelaEvent = objRow[conQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireEN.IsTest = TransNullToBool(objRow[conQuestionnaire.IsTest].ToString().Trim()); //是否测试
objQuestionnaireEN.LevelModeTypeId = objRow[conQuestionnaire.LevelModeTypeId].ToString().Trim(); //模式Id
objQuestionnaireEN.IsRandom = TransNullToBool(objRow[conQuestionnaire.IsRandom].ToString().Trim()); //是否随机
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQuestionnaireDA: GetObjLst)", objException.Message));
}
objQuestionnaireEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQuestionnaireEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQuestionnaire(ref clsQuestionnaireEN objQuestionnaireEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
strSQL = "Select * from Questionnaire where QuestionId = " + ""+ objQuestionnaireEN.QuestionId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQuestionnaireEN.QuestionId = TransNullToInt(objDT.Rows[0][conQuestionnaire.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objQuestionnaireEN.QuestionIndex = TransNullToInt(objDT.Rows[0][conQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireEN.QuestionName = objDT.Rows[0][conQuestionnaire.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objQuestionnaireEN.QuestionContent = objDT.Rows[0][conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objQuestionnaireEN.QuestionMemo = objDT.Rows[0][conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objQuestionnaireEN.QuestionNo = objDT.Rows[0][conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objQuestionnaireEN.ParentQuestionId = objDT.Rows[0][conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id(字段类型:char,字段长度:8,是否可空:True)
 objQuestionnaireEN.ExamAnswer = objDT.Rows[0][conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案(字段类型:varchar,字段长度:8000,是否可空:True)
 objQuestionnaireEN.CourseId = objDT.Rows[0][conQuestionnaire.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objQuestionnaireEN.LevelNo = TransNullToInt(objDT.Rows[0][conQuestionnaire.LevelNo].ToString().Trim()); //学习关号2(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireEN.CourseChapterId = objDT.Rows[0][conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objQuestionnaireEN.QuestionTypeId = objDT.Rows[0][conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objQuestionnaireEN.QuestionTypeId4Course = objDT.Rows[0][conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
 objQuestionnaireEN.AnswerTypeId = objDT.Rows[0][conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objQuestionnaireEN.GridTitle = objDT.Rows[0][conQuestionnaire.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objQuestionnaireEN.AnswerModeId = objDT.Rows[0][conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objQuestionnaireEN.IsHaveAdditionalMemo = TransNullToBool(objDT.Rows[0][conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.QuestionScore = TransNullToFloat(objDT.Rows[0][conQuestionnaire.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objQuestionnaireEN.DefaultValue = objDT.Rows[0][conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireEN.DefaultSelectItem = objDT.Rows[0][conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireEN.IsShow = TransNullToBool(objDT.Rows[0][conQuestionnaire.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.IsCast = TransNullToBool(objDT.Rows[0][conQuestionnaire.IsCast].ToString().Trim()); //是否播放(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.LikeCount = TransNullToInt(objDT.Rows[0][conQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objQuestionnaireEN.AnswerAttLimitSize = TransNullToInt(objDT.Rows[0][conQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小(字段类型:bigint,字段长度:8,是否可空:True)
 objQuestionnaireEN.LimitedResourceType = objDT.Rows[0][conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型(字段类型:varchar,字段长度:100,是否可空:True)
 objQuestionnaireEN.IsEffective = TransNullToBool(objDT.Rows[0][conQuestionnaire.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.IsCanInPaper = TransNullToBool(objDT.Rows[0][conQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.ExamGradeId = objDT.Rows[0][conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID(字段类型:char,字段长度:2,是否可空:True)
 objQuestionnaireEN.TextDirectId = objDT.Rows[0][conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID(字段类型:char,字段长度:4,是否可空:True)
 objQuestionnaireEN.UpdDate = objDT.Rows[0][conQuestionnaire.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireEN.UpdUser = objDT.Rows[0][conQuestionnaire.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireEN.Memo = objDT.Rows[0][conQuestionnaire.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQuestionnaireEN.QuestionCode = objDT.Rows[0][conQuestionnaire.QuestionCode].ToString().Trim(); //html代码(字段类型:varchar,字段长度:8000,是否可空:True)
 objQuestionnaireEN.DifficultyLevelId = objDT.Rows[0][conQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id(字段类型:char,字段长度:2,是否可空:True)
 objQuestionnaireEN.SectionTypeId = objDT.Rows[0][conQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id(字段类型:char,字段长度:8,是否可空:True)
 objQuestionnaireEN.KnowledgeGraphId = objDT.Rows[0][conQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id(字段类型:char,字段长度:10,是否可空:True)
 objQuestionnaireEN.FirstIndent = TransNullToBool(objDT.Rows[0][conQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.QuestionNameAdd = objDT.Rows[0][conQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充(字段类型:varchar,字段长度:500,是否可空:True)
 objQuestionnaireEN.CodeTab = objDT.Rows[0][conQuestionnaire.CodeTab].ToString().Trim(); //代码表(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireEN.CodeTabCode = objDT.Rows[0][conQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireEN.CodeTabCondition = objDT.Rows[0][conQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件(字段类型:varchar,字段长度:200,是否可空:True)
 objQuestionnaireEN.CodeTabName = objDT.Rows[0][conQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireEN.FillInTextHeight = TransNullToInt(objDT.Rows[0][conQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireEN.FillInTextWidth = TransNullToInt(objDT.Rows[0][conQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireEN.IsMulti4FillInText = TransNullToBool(objDT.Rows[0][conQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.CheckBoxLimitCount = TransNullToInt(objDT.Rows[0][conQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireEN.IsJs = TransNullToBool(objDT.Rows[0][conQuestionnaire.IsJs].ToString().Trim()); //是否是JS(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.MemoTextWidth = TransNullToInt(objDT.Rows[0][conQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireEN.RelaEvent = objDT.Rows[0][conQuestionnaire.RelaEvent].ToString().Trim(); //相关事件(字段类型:varchar,字段长度:4000,是否可空:True)
 objQuestionnaireEN.IsTest = TransNullToBool(objDT.Rows[0][conQuestionnaire.IsTest].ToString().Trim()); //是否测试(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.LevelModeTypeId = objDT.Rows[0][conQuestionnaire.LevelModeTypeId].ToString().Trim(); //模式Id(字段类型:char,字段长度:2,是否可空:False)
 objQuestionnaireEN.IsRandom = TransNullToBool(objDT.Rows[0][conQuestionnaire.IsRandom].ToString().Trim()); //是否随机(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQuestionnaireDA: GetQuestionnaire)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public clsQuestionnaireEN GetObjByQuestionId(long lngQuestionId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
strSQL = "Select * from Questionnaire where QuestionId = " + ""+ lngQuestionId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN();
try
{
 objQuestionnaireEN.QuestionId = Int32.Parse(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objQuestionnaireEN.QuestionIndex = objRow[conQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireEN.QuestionName = objRow[conQuestionnaire.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objQuestionnaireEN.QuestionContent = objRow[conQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objQuestionnaireEN.QuestionMemo = objRow[conQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objQuestionnaireEN.QuestionNo = objRow[conQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objQuestionnaireEN.ParentQuestionId = objRow[conQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id(字段类型:char,字段长度:8,是否可空:True)
 objQuestionnaireEN.ExamAnswer = objRow[conQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案(字段类型:varchar,字段长度:8000,是否可空:True)
 objQuestionnaireEN.CourseId = objRow[conQuestionnaire.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objQuestionnaireEN.LevelNo = objRow[conQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LevelNo].ToString().Trim()); //学习关号2(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireEN.CourseChapterId = objRow[conQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objQuestionnaireEN.QuestionTypeId = objRow[conQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objQuestionnaireEN.QuestionTypeId4Course = objRow[conQuestionnaire.QuestionTypeId4Course] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
 objQuestionnaireEN.AnswerTypeId = objRow[conQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objQuestionnaireEN.GridTitle = objRow[conQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaire.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objQuestionnaireEN.AnswerModeId = objRow[conQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.QuestionScore = objRow[conQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaire.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objQuestionnaireEN.DefaultValue = objRow[conQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireEN.DefaultSelectItem = objRow[conQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCast].ToString().Trim()); //是否播放(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.LikeCount = objRow[conQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objQuestionnaireEN.AnswerAttLimitSize = objRow[conQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小(字段类型:bigint,字段长度:8,是否可空:True)
 objQuestionnaireEN.LimitedResourceType = objRow[conQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型(字段类型:varchar,字段长度:100,是否可空:True)
 objQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.ExamGradeId = objRow[conQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID(字段类型:char,字段长度:2,是否可空:True)
 objQuestionnaireEN.TextDirectId = objRow[conQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID(字段类型:char,字段长度:4,是否可空:True)
 objQuestionnaireEN.UpdDate = objRow[conQuestionnaire.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireEN.UpdUser = objRow[conQuestionnaire.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireEN.Memo = objRow[conQuestionnaire.Memo] == DBNull.Value ? null : objRow[conQuestionnaire.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objQuestionnaireEN.QuestionCode = objRow[conQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionCode].ToString().Trim(); //html代码(字段类型:varchar,字段长度:8000,是否可空:True)
 objQuestionnaireEN.DifficultyLevelId = objRow[conQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[conQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id(字段类型:char,字段长度:2,是否可空:True)
 objQuestionnaireEN.SectionTypeId = objRow[conQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id(字段类型:char,字段长度:8,是否可空:True)
 objQuestionnaireEN.KnowledgeGraphId = objRow[conQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[conQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id(字段类型:char,字段长度:10,是否可空:True)
 objQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.QuestionNameAdd = objRow[conQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充(字段类型:varchar,字段长度:500,是否可空:True)
 objQuestionnaireEN.CodeTab = objRow[conQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTab].ToString().Trim(); //代码表(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireEN.CodeTabCode = objRow[conQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireEN.CodeTabCondition = objRow[conQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件(字段类型:varchar,字段长度:200,是否可空:True)
 objQuestionnaireEN.CodeTabName = objRow[conQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireEN.FillInTextHeight = objRow[conQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireEN.FillInTextWidth = objRow[conQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.CheckBoxLimitCount = objRow[conQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsJs].ToString().Trim()); //是否是JS(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.MemoTextWidth = objRow[conQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireEN.RelaEvent = objRow[conQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaire.RelaEvent].ToString().Trim(); //相关事件(字段类型:varchar,字段长度:4000,是否可空:True)
 objQuestionnaireEN.IsTest = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsTest].ToString().Trim()); //是否测试(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireEN.LevelModeTypeId = objRow[conQuestionnaire.LevelModeTypeId].ToString().Trim(); //模式Id(字段类型:char,字段长度:2,是否可空:False)
 objQuestionnaireEN.IsRandom = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsRandom].ToString().Trim()); //是否随机(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQuestionnaireDA: GetObjByQuestionId)", objException.Message));
}
return objQuestionnaireEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQuestionnaireEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQuestionnaireDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
strSQL = "Select * from Questionnaire where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN()
{
QuestionId = TransNullToInt(objRow[conQuestionnaire.QuestionId].ToString().Trim()), //题目Id
QuestionIndex = objRow[conQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.QuestionIndex].ToString().Trim()), //题目序号
QuestionName = objRow[conQuestionnaire.QuestionName].ToString().Trim(), //题目名称
QuestionContent = objRow[conQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionContent].ToString().Trim(), //题目内容
QuestionMemo = objRow[conQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionMemo].ToString().Trim(), //题目说明
QuestionNo = objRow[conQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNo].ToString().Trim(), //题目编号
ParentQuestionId = objRow[conQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaire.ParentQuestionId].ToString().Trim(), //父题目Id
ExamAnswer = objRow[conQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaire.ExamAnswer].ToString().Trim(), //题目答案
CourseId = objRow[conQuestionnaire.CourseId].ToString().Trim(), //课程Id
LevelNo = objRow[conQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.LevelNo].ToString().Trim()), //学习关号2
CourseChapterId = objRow[conQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaire.CourseChapterId].ToString().Trim(), //课程章节ID
QuestionTypeId = objRow[conQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionTypeId4Course = objRow[conQuestionnaire.QuestionTypeId4Course] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(), //题目类型Id4课程
AnswerTypeId = objRow[conQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerTypeId].ToString().Trim(), //答案类型ID
GridTitle = objRow[conQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaire.GridTitle].ToString().Trim(), //表格标题
AnswerModeId = objRow[conQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerModeId].ToString().Trim(), //答案模式Id
IsHaveAdditionalMemo = TransNullToBool(objRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()), //是否有附加说明
QuestionScore = objRow[conQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conQuestionnaire.QuestionScore].ToString().Trim()), //题目得分
DefaultValue = objRow[conQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultValue].ToString().Trim(), //缺省值
DefaultSelectItem = objRow[conQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(), //默认选项
IsShow = TransNullToBool(objRow[conQuestionnaire.IsShow].ToString().Trim()), //是否启用
IsCast = TransNullToBool(objRow[conQuestionnaire.IsCast].ToString().Trim()), //是否播放
LikeCount = objRow[conQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaire.LikeCount].ToString().Trim()), //资源喜欢数量
AnswerAttLimitSize = objRow[conQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim()), //回答附件限制大小
LimitedResourceType = objRow[conQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaire.LimitedResourceType].ToString().Trim(), //限制资源类型
IsEffective = TransNullToBool(objRow[conQuestionnaire.IsEffective].ToString().Trim()), //是否有效
IsCanInPaper = TransNullToBool(objRow[conQuestionnaire.IsCanInPaper].ToString().Trim()), //是否可在Paper
ExamGradeId = objRow[conQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaire.ExamGradeId].ToString().Trim(), //题库等级ID
TextDirectId = objRow[conQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[conQuestionnaire.TextDirectId].ToString().Trim(), //文本方向ID
UpdDate = objRow[conQuestionnaire.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conQuestionnaire.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conQuestionnaire.Memo] == DBNull.Value ? null : objRow[conQuestionnaire.Memo].ToString().Trim(), //备注
QuestionCode = objRow[conQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionCode].ToString().Trim(), //html代码
DifficultyLevelId = objRow[conQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[conQuestionnaire.DifficultyLevelId].ToString().Trim(), //难度等级Id
SectionTypeId = objRow[conQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.SectionTypeId].ToString().Trim(), //节点类型Id
KnowledgeGraphId = objRow[conQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[conQuestionnaire.KnowledgeGraphId].ToString().Trim(), //知识点图Id
FirstIndent = TransNullToBool(objRow[conQuestionnaire.FirstIndent].ToString().Trim()), //首行缩进
QuestionNameAdd = objRow[conQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNameAdd].ToString().Trim(), //题目补充
CodeTab = objRow[conQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTab].ToString().Trim(), //代码表
CodeTabCode = objRow[conQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCode].ToString().Trim(), //CodeTab_Code
CodeTabCondition = objRow[conQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCondition].ToString().Trim(), //代码表_条件
CodeTabName = objRow[conQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabName].ToString().Trim(), //CodeTab_Name
FillInTextHeight = objRow[conQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.FillInTextHeight].ToString().Trim()), //填空框高度
FillInTextWidth = objRow[conQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.FillInTextWidth].ToString().Trim()), //填空框宽度
IsMulti4FillInText = TransNullToBool(objRow[conQuestionnaire.IsMulti4FillInText].ToString().Trim()), //是否填空框多行
CheckBoxLimitCount = objRow[conQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.CheckBoxLimitCount].ToString().Trim()), //复选框限制数
IsJs = TransNullToBool(objRow[conQuestionnaire.IsJs].ToString().Trim()), //是否是JS
MemoTextWidth = objRow[conQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.MemoTextWidth].ToString().Trim()), //备注框宽度
RelaEvent = objRow[conQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaire.RelaEvent].ToString().Trim(), //相关事件
IsTest = TransNullToBool(objRow[conQuestionnaire.IsTest].ToString().Trim()), //是否测试
LevelModeTypeId = objRow[conQuestionnaire.LevelModeTypeId].ToString().Trim(), //模式Id
IsRandom = TransNullToBool(objRow[conQuestionnaire.IsRandom].ToString().Trim()) //是否随机
};
objQuestionnaireEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQuestionnaireEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQuestionnaireDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQuestionnaireEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN();
try
{
objQuestionnaireEN.QuestionId = TransNullToInt(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireEN.QuestionIndex = objRow[conQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireEN.QuestionName = objRow[conQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireEN.QuestionContent = objRow[conQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireEN.QuestionMemo = objRow[conQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireEN.QuestionNo = objRow[conQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireEN.ParentQuestionId = objRow[conQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireEN.ExamAnswer = objRow[conQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireEN.CourseId = objRow[conQuestionnaire.CourseId].ToString().Trim(); //课程Id
objQuestionnaireEN.LevelNo = objRow[conQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireEN.CourseChapterId = objRow[conQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireEN.QuestionTypeId = objRow[conQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireEN.QuestionTypeId4Course = objRow[conQuestionnaire.QuestionTypeId4Course] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireEN.AnswerTypeId = objRow[conQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireEN.GridTitle = objRow[conQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireEN.AnswerModeId = objRow[conQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireEN.IsHaveAdditionalMemo = TransNullToBool(objRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireEN.QuestionScore = objRow[conQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireEN.DefaultValue = objRow[conQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireEN.DefaultSelectItem = objRow[conQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireEN.IsShow = TransNullToBool(objRow[conQuestionnaire.IsShow].ToString().Trim()); //是否启用
objQuestionnaireEN.IsCast = TransNullToBool(objRow[conQuestionnaire.IsCast].ToString().Trim()); //是否播放
objQuestionnaireEN.LikeCount = objRow[conQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireEN.AnswerAttLimitSize = objRow[conQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireEN.LimitedResourceType = objRow[conQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireEN.IsEffective = TransNullToBool(objRow[conQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireEN.IsCanInPaper = TransNullToBool(objRow[conQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireEN.ExamGradeId = objRow[conQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireEN.TextDirectId = objRow[conQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireEN.UpdDate = objRow[conQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireEN.UpdUser = objRow[conQuestionnaire.UpdUser].ToString().Trim(); //修改人
objQuestionnaireEN.Memo = objRow[conQuestionnaire.Memo] == DBNull.Value ? null : objRow[conQuestionnaire.Memo].ToString().Trim(); //备注
objQuestionnaireEN.QuestionCode = objRow[conQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objQuestionnaireEN.DifficultyLevelId = objRow[conQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[conQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objQuestionnaireEN.SectionTypeId = objRow[conQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objQuestionnaireEN.KnowledgeGraphId = objRow[conQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[conQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objQuestionnaireEN.FirstIndent = TransNullToBool(objRow[conQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireEN.QuestionNameAdd = objRow[conQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireEN.CodeTab = objRow[conQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTab].ToString().Trim(); //代码表
objQuestionnaireEN.CodeTabCode = objRow[conQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireEN.CodeTabCondition = objRow[conQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireEN.CodeTabName = objRow[conQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireEN.FillInTextHeight = objRow[conQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireEN.FillInTextWidth = objRow[conQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireEN.IsMulti4FillInText = TransNullToBool(objRow[conQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireEN.CheckBoxLimitCount = objRow[conQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireEN.IsJs = TransNullToBool(objRow[conQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objQuestionnaireEN.MemoTextWidth = objRow[conQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireEN.RelaEvent = objRow[conQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireEN.IsTest = TransNullToBool(objRow[conQuestionnaire.IsTest].ToString().Trim()); //是否测试
objQuestionnaireEN.LevelModeTypeId = objRow[conQuestionnaire.LevelModeTypeId].ToString().Trim(); //模式Id
objQuestionnaireEN.IsRandom = TransNullToBool(objRow[conQuestionnaire.IsRandom].ToString().Trim()); //是否随机
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQuestionnaireDA: GetObjByDataRowQuestionnaire)", objException.Message));
}
objQuestionnaireEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQuestionnaireEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQuestionnaireEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN();
try
{
objQuestionnaireEN.QuestionId = TransNullToInt(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireEN.QuestionIndex = objRow[conQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireEN.QuestionName = objRow[conQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireEN.QuestionContent = objRow[conQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireEN.QuestionMemo = objRow[conQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireEN.QuestionNo = objRow[conQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireEN.ParentQuestionId = objRow[conQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireEN.ExamAnswer = objRow[conQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireEN.CourseId = objRow[conQuestionnaire.CourseId].ToString().Trim(); //课程Id
objQuestionnaireEN.LevelNo = objRow[conQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireEN.CourseChapterId = objRow[conQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireEN.QuestionTypeId = objRow[conQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireEN.QuestionTypeId4Course = objRow[conQuestionnaire.QuestionTypeId4Course] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireEN.AnswerTypeId = objRow[conQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireEN.GridTitle = objRow[conQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireEN.AnswerModeId = objRow[conQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireEN.IsHaveAdditionalMemo = TransNullToBool(objRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireEN.QuestionScore = objRow[conQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireEN.DefaultValue = objRow[conQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireEN.DefaultSelectItem = objRow[conQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireEN.IsShow = TransNullToBool(objRow[conQuestionnaire.IsShow].ToString().Trim()); //是否启用
objQuestionnaireEN.IsCast = TransNullToBool(objRow[conQuestionnaire.IsCast].ToString().Trim()); //是否播放
objQuestionnaireEN.LikeCount = objRow[conQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireEN.AnswerAttLimitSize = objRow[conQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireEN.LimitedResourceType = objRow[conQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireEN.IsEffective = TransNullToBool(objRow[conQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireEN.IsCanInPaper = TransNullToBool(objRow[conQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireEN.ExamGradeId = objRow[conQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireEN.TextDirectId = objRow[conQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireEN.UpdDate = objRow[conQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireEN.UpdUser = objRow[conQuestionnaire.UpdUser].ToString().Trim(); //修改人
objQuestionnaireEN.Memo = objRow[conQuestionnaire.Memo] == DBNull.Value ? null : objRow[conQuestionnaire.Memo].ToString().Trim(); //备注
objQuestionnaireEN.QuestionCode = objRow[conQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objQuestionnaireEN.DifficultyLevelId = objRow[conQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[conQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objQuestionnaireEN.SectionTypeId = objRow[conQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[conQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objQuestionnaireEN.KnowledgeGraphId = objRow[conQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[conQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objQuestionnaireEN.FirstIndent = TransNullToBool(objRow[conQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireEN.QuestionNameAdd = objRow[conQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireEN.CodeTab = objRow[conQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTab].ToString().Trim(); //代码表
objQuestionnaireEN.CodeTabCode = objRow[conQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireEN.CodeTabCondition = objRow[conQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireEN.CodeTabName = objRow[conQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireEN.FillInTextHeight = objRow[conQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireEN.FillInTextWidth = objRow[conQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireEN.IsMulti4FillInText = TransNullToBool(objRow[conQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireEN.CheckBoxLimitCount = objRow[conQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireEN.IsJs = TransNullToBool(objRow[conQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objQuestionnaireEN.MemoTextWidth = objRow[conQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireEN.RelaEvent = objRow[conQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireEN.IsTest = TransNullToBool(objRow[conQuestionnaire.IsTest].ToString().Trim()); //是否测试
objQuestionnaireEN.LevelModeTypeId = objRow[conQuestionnaire.LevelModeTypeId].ToString().Trim(); //模式Id
objQuestionnaireEN.IsRandom = TransNullToBool(objRow[conQuestionnaire.IsRandom].ToString().Trim()); //是否随机
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQuestionnaireDA: GetObjByDataRow)", objException.Message));
}
objQuestionnaireEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQuestionnaireEN;
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
objSQL = clsQuestionnaireDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQuestionnaireEN._CurrTabName, conQuestionnaire.QuestionId, 8, "");
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
objSQL = clsQuestionnaireDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQuestionnaireEN._CurrTabName, conQuestionnaire.QuestionId, 8, strPrefix);
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
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QuestionId from Questionnaire where " + strCondition;
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
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QuestionId from Questionnaire where " + strCondition;
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
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngQuestionId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Questionnaire", "QuestionId = " + ""+ lngQuestionId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQuestionnaireDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Questionnaire", strCondition))
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
objSQL = clsQuestionnaireDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Questionnaire");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQuestionnaireEN objQuestionnaireEN)
 {
 if (objQuestionnaireEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
strSQL = "Select * from Questionnaire where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Questionnaire");
objRow = objDS.Tables["Questionnaire"].NewRow();
objRow[conQuestionnaire.QuestionIndex] = objQuestionnaireEN.QuestionIndex; //题目序号
objRow[conQuestionnaire.QuestionName] = objQuestionnaireEN.QuestionName; //题目名称
 if (objQuestionnaireEN.QuestionContent !=  "")
 {
objRow[conQuestionnaire.QuestionContent] = objQuestionnaireEN.QuestionContent; //题目内容
 }
 if (objQuestionnaireEN.QuestionMemo !=  "")
 {
objRow[conQuestionnaire.QuestionMemo] = objQuestionnaireEN.QuestionMemo; //题目说明
 }
 if (objQuestionnaireEN.QuestionNo !=  "")
 {
objRow[conQuestionnaire.QuestionNo] = objQuestionnaireEN.QuestionNo; //题目编号
 }
 if (objQuestionnaireEN.ParentQuestionId !=  "")
 {
objRow[conQuestionnaire.ParentQuestionId] = objQuestionnaireEN.ParentQuestionId; //父题目Id
 }
 if (objQuestionnaireEN.ExamAnswer !=  "")
 {
objRow[conQuestionnaire.ExamAnswer] = objQuestionnaireEN.ExamAnswer; //题目答案
 }
objRow[conQuestionnaire.CourseId] = objQuestionnaireEN.CourseId; //课程Id
objRow[conQuestionnaire.LevelNo] = objQuestionnaireEN.LevelNo; //学习关号2
 if (objQuestionnaireEN.CourseChapterId !=  "")
 {
objRow[conQuestionnaire.CourseChapterId] = objQuestionnaireEN.CourseChapterId; //课程章节ID
 }
 if (objQuestionnaireEN.QuestionTypeId !=  "")
 {
objRow[conQuestionnaire.QuestionTypeId] = objQuestionnaireEN.QuestionTypeId; //题目类型Id
 }
 if (objQuestionnaireEN.QuestionTypeId4Course !=  "")
 {
objRow[conQuestionnaire.QuestionTypeId4Course] = objQuestionnaireEN.QuestionTypeId4Course; //题目类型Id4课程
 }
 if (objQuestionnaireEN.AnswerTypeId !=  "")
 {
objRow[conQuestionnaire.AnswerTypeId] = objQuestionnaireEN.AnswerTypeId; //答案类型ID
 }
 if (objQuestionnaireEN.GridTitle !=  "")
 {
objRow[conQuestionnaire.GridTitle] = objQuestionnaireEN.GridTitle; //表格标题
 }
 if (objQuestionnaireEN.AnswerModeId !=  "")
 {
objRow[conQuestionnaire.AnswerModeId] = objQuestionnaireEN.AnswerModeId; //答案模式Id
 }
objRow[conQuestionnaire.IsHaveAdditionalMemo] = objQuestionnaireEN.IsHaveAdditionalMemo; //是否有附加说明
objRow[conQuestionnaire.QuestionScore] = objQuestionnaireEN.QuestionScore; //题目得分
 if (objQuestionnaireEN.DefaultValue !=  "")
 {
objRow[conQuestionnaire.DefaultValue] = objQuestionnaireEN.DefaultValue; //缺省值
 }
 if (objQuestionnaireEN.DefaultSelectItem !=  "")
 {
objRow[conQuestionnaire.DefaultSelectItem] = objQuestionnaireEN.DefaultSelectItem; //默认选项
 }
objRow[conQuestionnaire.IsShow] = objQuestionnaireEN.IsShow; //是否启用
objRow[conQuestionnaire.IsCast] = objQuestionnaireEN.IsCast; //是否播放
objRow[conQuestionnaire.LikeCount] = objQuestionnaireEN.LikeCount; //资源喜欢数量
objRow[conQuestionnaire.AnswerAttLimitSize] = objQuestionnaireEN.AnswerAttLimitSize; //回答附件限制大小
 if (objQuestionnaireEN.LimitedResourceType !=  "")
 {
objRow[conQuestionnaire.LimitedResourceType] = objQuestionnaireEN.LimitedResourceType; //限制资源类型
 }
objRow[conQuestionnaire.IsEffective] = objQuestionnaireEN.IsEffective; //是否有效
objRow[conQuestionnaire.IsCanInPaper] = objQuestionnaireEN.IsCanInPaper; //是否可在Paper
 if (objQuestionnaireEN.ExamGradeId !=  "")
 {
objRow[conQuestionnaire.ExamGradeId] = objQuestionnaireEN.ExamGradeId; //题库等级ID
 }
 if (objQuestionnaireEN.TextDirectId !=  "")
 {
objRow[conQuestionnaire.TextDirectId] = objQuestionnaireEN.TextDirectId; //文本方向ID
 }
objRow[conQuestionnaire.UpdDate] = objQuestionnaireEN.UpdDate; //修改日期
objRow[conQuestionnaire.UpdUser] = objQuestionnaireEN.UpdUser; //修改人
 if (objQuestionnaireEN.Memo !=  "")
 {
objRow[conQuestionnaire.Memo] = objQuestionnaireEN.Memo; //备注
 }
 if (objQuestionnaireEN.QuestionCode !=  "")
 {
objRow[conQuestionnaire.QuestionCode] = objQuestionnaireEN.QuestionCode; //html代码
 }
 if (objQuestionnaireEN.DifficultyLevelId !=  "")
 {
objRow[conQuestionnaire.DifficultyLevelId] = objQuestionnaireEN.DifficultyLevelId; //难度等级Id
 }
 if (objQuestionnaireEN.SectionTypeId !=  "")
 {
objRow[conQuestionnaire.SectionTypeId] = objQuestionnaireEN.SectionTypeId; //节点类型Id
 }
 if (objQuestionnaireEN.KnowledgeGraphId !=  "")
 {
objRow[conQuestionnaire.KnowledgeGraphId] = objQuestionnaireEN.KnowledgeGraphId; //知识点图Id
 }
objRow[conQuestionnaire.FirstIndent] = objQuestionnaireEN.FirstIndent; //首行缩进
 if (objQuestionnaireEN.QuestionNameAdd !=  "")
 {
objRow[conQuestionnaire.QuestionNameAdd] = objQuestionnaireEN.QuestionNameAdd; //题目补充
 }
 if (objQuestionnaireEN.CodeTab !=  "")
 {
objRow[conQuestionnaire.CodeTab] = objQuestionnaireEN.CodeTab; //代码表
 }
 if (objQuestionnaireEN.CodeTabCode !=  "")
 {
objRow[conQuestionnaire.CodeTabCode] = objQuestionnaireEN.CodeTabCode; //CodeTab_Code
 }
 if (objQuestionnaireEN.CodeTabCondition !=  "")
 {
objRow[conQuestionnaire.CodeTabCondition] = objQuestionnaireEN.CodeTabCondition; //代码表_条件
 }
 if (objQuestionnaireEN.CodeTabName !=  "")
 {
objRow[conQuestionnaire.CodeTabName] = objQuestionnaireEN.CodeTabName; //CodeTab_Name
 }
objRow[conQuestionnaire.FillInTextHeight] = objQuestionnaireEN.FillInTextHeight; //填空框高度
objRow[conQuestionnaire.FillInTextWidth] = objQuestionnaireEN.FillInTextWidth; //填空框宽度
objRow[conQuestionnaire.IsMulti4FillInText] = objQuestionnaireEN.IsMulti4FillInText; //是否填空框多行
objRow[conQuestionnaire.CheckBoxLimitCount] = objQuestionnaireEN.CheckBoxLimitCount; //复选框限制数
objRow[conQuestionnaire.IsJs] = objQuestionnaireEN.IsJs; //是否是JS
objRow[conQuestionnaire.MemoTextWidth] = objQuestionnaireEN.MemoTextWidth; //备注框宽度
 if (objQuestionnaireEN.RelaEvent !=  "")
 {
objRow[conQuestionnaire.RelaEvent] = objQuestionnaireEN.RelaEvent; //相关事件
 }
objRow[conQuestionnaire.IsTest] = objQuestionnaireEN.IsTest; //是否测试
objRow[conQuestionnaire.LevelModeTypeId] = objQuestionnaireEN.LevelModeTypeId; //模式Id
objRow[conQuestionnaire.IsRandom] = objQuestionnaireEN.IsRandom; //是否随机
objDS.Tables[clsQuestionnaireEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQuestionnaireEN._CurrTabName);
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
 /// <param name = "objQuestionnaireEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQuestionnaireEN objQuestionnaireEN)
{
 if (objQuestionnaireEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQuestionnaireEN.QuestionIndex !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionIndex);
 arrValueListForInsert.Add(objQuestionnaireEN.QuestionIndex.ToString());
 }
 
 if (objQuestionnaireEN.QuestionName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionName);
 var strQuestionName = objQuestionnaireEN.QuestionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionName + "'");
 }
 
 if (objQuestionnaireEN.QuestionContent !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionContent);
 var strQuestionContent = objQuestionnaireEN.QuestionContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionContent + "'");
 }
 
 if (objQuestionnaireEN.QuestionMemo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionMemo);
 var strQuestionMemo = objQuestionnaireEN.QuestionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionMemo + "'");
 }
 
 if (objQuestionnaireEN.QuestionNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionNo);
 var strQuestionNo = objQuestionnaireEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNo + "'");
 }
 
 if (objQuestionnaireEN.ParentQuestionId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.ParentQuestionId);
 var strParentQuestionId = objQuestionnaireEN.ParentQuestionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentQuestionId + "'");
 }
 
 if (objQuestionnaireEN.ExamAnswer !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.ExamAnswer);
 var strExamAnswer = objQuestionnaireEN.ExamAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamAnswer + "'");
 }
 
 if (objQuestionnaireEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CourseId);
 var strCourseId = objQuestionnaireEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objQuestionnaireEN.LevelNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.LevelNo);
 arrValueListForInsert.Add(objQuestionnaireEN.LevelNo.ToString());
 }
 
 if (objQuestionnaireEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CourseChapterId);
 var strCourseChapterId = objQuestionnaireEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objQuestionnaireEN.QuestionTypeId  ==  "")
 {
 objQuestionnaireEN.QuestionTypeId = null;
 }
 if (objQuestionnaireEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionTypeId);
 var strQuestionTypeId = objQuestionnaireEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 if (objQuestionnaireEN.QuestionTypeId4Course !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionTypeId4Course);
 var strQuestionTypeId4Course = objQuestionnaireEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId4Course + "'");
 }
 
 if (objQuestionnaireEN.AnswerTypeId  ==  "")
 {
 objQuestionnaireEN.AnswerTypeId = null;
 }
 if (objQuestionnaireEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.AnswerTypeId);
 var strAnswerTypeId = objQuestionnaireEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objQuestionnaireEN.GridTitle !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.GridTitle);
 var strGridTitle = objQuestionnaireEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGridTitle + "'");
 }
 
 if (objQuestionnaireEN.AnswerModeId  ==  "")
 {
 objQuestionnaireEN.AnswerModeId = null;
 }
 if (objQuestionnaireEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.AnswerModeId);
 var strAnswerModeId = objQuestionnaireEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsHaveAdditionalMemo);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsHaveAdditionalMemo  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.QuestionScore !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionScore);
 arrValueListForInsert.Add(objQuestionnaireEN.QuestionScore.ToString());
 }
 
 if (objQuestionnaireEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.DefaultValue);
 var strDefaultValue = objQuestionnaireEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objQuestionnaireEN.DefaultSelectItem !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.DefaultSelectItem);
 var strDefaultSelectItem = objQuestionnaireEN.DefaultSelectItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultSelectItem + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsShow);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsShow  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaire.IsCast);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsCast  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.LikeCount);
 arrValueListForInsert.Add(objQuestionnaireEN.LikeCount.ToString());
 }
 
 if (objQuestionnaireEN.AnswerAttLimitSize !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.AnswerAttLimitSize);
 arrValueListForInsert.Add(objQuestionnaireEN.AnswerAttLimitSize.ToString());
 }
 
 if (objQuestionnaireEN.LimitedResourceType !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.LimitedResourceType);
 var strLimitedResourceType = objQuestionnaireEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLimitedResourceType + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsEffective);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaire.IsCanInPaper);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsCanInPaper  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.ExamGradeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.ExamGradeId);
 var strExamGradeId = objQuestionnaireEN.ExamGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamGradeId + "'");
 }
 
 if (objQuestionnaireEN.TextDirectId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.TextDirectId);
 var strTextDirectId = objQuestionnaireEN.TextDirectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextDirectId + "'");
 }
 
 if (objQuestionnaireEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.UpdDate);
 var strUpdDate = objQuestionnaireEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionnaireEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.UpdUser);
 var strUpdUser = objQuestionnaireEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionnaireEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.Memo);
 var strMemo = objQuestionnaireEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQuestionnaireEN.QuestionCode !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionCode);
 var strQuestionCode = objQuestionnaireEN.QuestionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionCode + "'");
 }
 
 if (objQuestionnaireEN.DifficultyLevelId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.DifficultyLevelId);
 var strDifficultyLevelId = objQuestionnaireEN.DifficultyLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDifficultyLevelId + "'");
 }
 
 if (objQuestionnaireEN.SectionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.SectionTypeId);
 var strSectionTypeId = objQuestionnaireEN.SectionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionTypeId + "'");
 }
 
 if (objQuestionnaireEN.KnowledgeGraphId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.KnowledgeGraphId);
 var strKnowledgeGraphId = objQuestionnaireEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeGraphId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.FirstIndent);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.FirstIndent  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.QuestionNameAdd !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionNameAdd);
 var strQuestionNameAdd = objQuestionnaireEN.QuestionNameAdd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNameAdd + "'");
 }
 
 if (objQuestionnaireEN.CodeTab !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CodeTab);
 var strCodeTab = objQuestionnaireEN.CodeTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTab + "'");
 }
 
 if (objQuestionnaireEN.CodeTabCode !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CodeTabCode);
 var strCodeTabCode = objQuestionnaireEN.CodeTabCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCode + "'");
 }
 
 if (objQuestionnaireEN.CodeTabCondition !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CodeTabCondition);
 var strCodeTabCondition = objQuestionnaireEN.CodeTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCondition + "'");
 }
 
 if (objQuestionnaireEN.CodeTabName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CodeTabName);
 var strCodeTabName = objQuestionnaireEN.CodeTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabName + "'");
 }
 
 if (objQuestionnaireEN.FillInTextHeight !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.FillInTextHeight);
 arrValueListForInsert.Add(objQuestionnaireEN.FillInTextHeight.ToString());
 }
 
 if (objQuestionnaireEN.FillInTextWidth !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.FillInTextWidth);
 arrValueListForInsert.Add(objQuestionnaireEN.FillInTextWidth.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsMulti4FillInText);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsMulti4FillInText  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.CheckBoxLimitCount !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CheckBoxLimitCount);
 arrValueListForInsert.Add(objQuestionnaireEN.CheckBoxLimitCount.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsJs);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsJs  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.MemoTextWidth !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.MemoTextWidth);
 arrValueListForInsert.Add(objQuestionnaireEN.MemoTextWidth.ToString());
 }
 
 if (objQuestionnaireEN.RelaEvent !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.RelaEvent);
 var strRelaEvent = objQuestionnaireEN.RelaEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaEvent + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsTest);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsTest  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.LevelModeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.LevelModeTypeId);
 var strLevelModeTypeId = objQuestionnaireEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsRandom);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsRandom  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Questionnaire");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQuestionnaireEN objQuestionnaireEN)
{
 if (objQuestionnaireEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQuestionnaireEN.QuestionIndex !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionIndex);
 arrValueListForInsert.Add(objQuestionnaireEN.QuestionIndex.ToString());
 }
 
 if (objQuestionnaireEN.QuestionName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionName);
 var strQuestionName = objQuestionnaireEN.QuestionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionName + "'");
 }
 
 if (objQuestionnaireEN.QuestionContent !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionContent);
 var strQuestionContent = objQuestionnaireEN.QuestionContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionContent + "'");
 }
 
 if (objQuestionnaireEN.QuestionMemo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionMemo);
 var strQuestionMemo = objQuestionnaireEN.QuestionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionMemo + "'");
 }
 
 if (objQuestionnaireEN.QuestionNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionNo);
 var strQuestionNo = objQuestionnaireEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNo + "'");
 }
 
 if (objQuestionnaireEN.ParentQuestionId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.ParentQuestionId);
 var strParentQuestionId = objQuestionnaireEN.ParentQuestionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentQuestionId + "'");
 }
 
 if (objQuestionnaireEN.ExamAnswer !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.ExamAnswer);
 var strExamAnswer = objQuestionnaireEN.ExamAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamAnswer + "'");
 }
 
 if (objQuestionnaireEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CourseId);
 var strCourseId = objQuestionnaireEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objQuestionnaireEN.LevelNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.LevelNo);
 arrValueListForInsert.Add(objQuestionnaireEN.LevelNo.ToString());
 }
 
 if (objQuestionnaireEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CourseChapterId);
 var strCourseChapterId = objQuestionnaireEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objQuestionnaireEN.QuestionTypeId  ==  "")
 {
 objQuestionnaireEN.QuestionTypeId = null;
 }
 if (objQuestionnaireEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionTypeId);
 var strQuestionTypeId = objQuestionnaireEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 if (objQuestionnaireEN.QuestionTypeId4Course !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionTypeId4Course);
 var strQuestionTypeId4Course = objQuestionnaireEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId4Course + "'");
 }
 
 if (objQuestionnaireEN.AnswerTypeId  ==  "")
 {
 objQuestionnaireEN.AnswerTypeId = null;
 }
 if (objQuestionnaireEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.AnswerTypeId);
 var strAnswerTypeId = objQuestionnaireEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objQuestionnaireEN.GridTitle !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.GridTitle);
 var strGridTitle = objQuestionnaireEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGridTitle + "'");
 }
 
 if (objQuestionnaireEN.AnswerModeId  ==  "")
 {
 objQuestionnaireEN.AnswerModeId = null;
 }
 if (objQuestionnaireEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.AnswerModeId);
 var strAnswerModeId = objQuestionnaireEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsHaveAdditionalMemo);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsHaveAdditionalMemo  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.QuestionScore !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionScore);
 arrValueListForInsert.Add(objQuestionnaireEN.QuestionScore.ToString());
 }
 
 if (objQuestionnaireEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.DefaultValue);
 var strDefaultValue = objQuestionnaireEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objQuestionnaireEN.DefaultSelectItem !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.DefaultSelectItem);
 var strDefaultSelectItem = objQuestionnaireEN.DefaultSelectItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultSelectItem + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsShow);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsShow  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaire.IsCast);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsCast  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.LikeCount);
 arrValueListForInsert.Add(objQuestionnaireEN.LikeCount.ToString());
 }
 
 if (objQuestionnaireEN.AnswerAttLimitSize !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.AnswerAttLimitSize);
 arrValueListForInsert.Add(objQuestionnaireEN.AnswerAttLimitSize.ToString());
 }
 
 if (objQuestionnaireEN.LimitedResourceType !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.LimitedResourceType);
 var strLimitedResourceType = objQuestionnaireEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLimitedResourceType + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsEffective);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaire.IsCanInPaper);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsCanInPaper  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.ExamGradeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.ExamGradeId);
 var strExamGradeId = objQuestionnaireEN.ExamGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamGradeId + "'");
 }
 
 if (objQuestionnaireEN.TextDirectId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.TextDirectId);
 var strTextDirectId = objQuestionnaireEN.TextDirectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextDirectId + "'");
 }
 
 if (objQuestionnaireEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.UpdDate);
 var strUpdDate = objQuestionnaireEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionnaireEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.UpdUser);
 var strUpdUser = objQuestionnaireEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionnaireEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.Memo);
 var strMemo = objQuestionnaireEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQuestionnaireEN.QuestionCode !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionCode);
 var strQuestionCode = objQuestionnaireEN.QuestionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionCode + "'");
 }
 
 if (objQuestionnaireEN.DifficultyLevelId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.DifficultyLevelId);
 var strDifficultyLevelId = objQuestionnaireEN.DifficultyLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDifficultyLevelId + "'");
 }
 
 if (objQuestionnaireEN.SectionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.SectionTypeId);
 var strSectionTypeId = objQuestionnaireEN.SectionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionTypeId + "'");
 }
 
 if (objQuestionnaireEN.KnowledgeGraphId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.KnowledgeGraphId);
 var strKnowledgeGraphId = objQuestionnaireEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeGraphId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.FirstIndent);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.FirstIndent  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.QuestionNameAdd !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionNameAdd);
 var strQuestionNameAdd = objQuestionnaireEN.QuestionNameAdd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNameAdd + "'");
 }
 
 if (objQuestionnaireEN.CodeTab !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CodeTab);
 var strCodeTab = objQuestionnaireEN.CodeTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTab + "'");
 }
 
 if (objQuestionnaireEN.CodeTabCode !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CodeTabCode);
 var strCodeTabCode = objQuestionnaireEN.CodeTabCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCode + "'");
 }
 
 if (objQuestionnaireEN.CodeTabCondition !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CodeTabCondition);
 var strCodeTabCondition = objQuestionnaireEN.CodeTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCondition + "'");
 }
 
 if (objQuestionnaireEN.CodeTabName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CodeTabName);
 var strCodeTabName = objQuestionnaireEN.CodeTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabName + "'");
 }
 
 if (objQuestionnaireEN.FillInTextHeight !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.FillInTextHeight);
 arrValueListForInsert.Add(objQuestionnaireEN.FillInTextHeight.ToString());
 }
 
 if (objQuestionnaireEN.FillInTextWidth !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.FillInTextWidth);
 arrValueListForInsert.Add(objQuestionnaireEN.FillInTextWidth.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsMulti4FillInText);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsMulti4FillInText  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.CheckBoxLimitCount !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CheckBoxLimitCount);
 arrValueListForInsert.Add(objQuestionnaireEN.CheckBoxLimitCount.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsJs);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsJs  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.MemoTextWidth !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.MemoTextWidth);
 arrValueListForInsert.Add(objQuestionnaireEN.MemoTextWidth.ToString());
 }
 
 if (objQuestionnaireEN.RelaEvent !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.RelaEvent);
 var strRelaEvent = objQuestionnaireEN.RelaEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaEvent + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsTest);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsTest  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.LevelModeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.LevelModeTypeId);
 var strLevelModeTypeId = objQuestionnaireEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsRandom);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsRandom  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Questionnaire");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQuestionnaireEN objQuestionnaireEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQuestionnaireEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQuestionnaireEN.QuestionIndex !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionIndex);
 arrValueListForInsert.Add(objQuestionnaireEN.QuestionIndex.ToString());
 }
 
 if (objQuestionnaireEN.QuestionName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionName);
 var strQuestionName = objQuestionnaireEN.QuestionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionName + "'");
 }
 
 if (objQuestionnaireEN.QuestionContent !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionContent);
 var strQuestionContent = objQuestionnaireEN.QuestionContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionContent + "'");
 }
 
 if (objQuestionnaireEN.QuestionMemo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionMemo);
 var strQuestionMemo = objQuestionnaireEN.QuestionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionMemo + "'");
 }
 
 if (objQuestionnaireEN.QuestionNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionNo);
 var strQuestionNo = objQuestionnaireEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNo + "'");
 }
 
 if (objQuestionnaireEN.ParentQuestionId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.ParentQuestionId);
 var strParentQuestionId = objQuestionnaireEN.ParentQuestionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentQuestionId + "'");
 }
 
 if (objQuestionnaireEN.ExamAnswer !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.ExamAnswer);
 var strExamAnswer = objQuestionnaireEN.ExamAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamAnswer + "'");
 }
 
 if (objQuestionnaireEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CourseId);
 var strCourseId = objQuestionnaireEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objQuestionnaireEN.LevelNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.LevelNo);
 arrValueListForInsert.Add(objQuestionnaireEN.LevelNo.ToString());
 }
 
 if (objQuestionnaireEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CourseChapterId);
 var strCourseChapterId = objQuestionnaireEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objQuestionnaireEN.QuestionTypeId  ==  "")
 {
 objQuestionnaireEN.QuestionTypeId = null;
 }
 if (objQuestionnaireEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionTypeId);
 var strQuestionTypeId = objQuestionnaireEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 if (objQuestionnaireEN.QuestionTypeId4Course !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionTypeId4Course);
 var strQuestionTypeId4Course = objQuestionnaireEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId4Course + "'");
 }
 
 if (objQuestionnaireEN.AnswerTypeId  ==  "")
 {
 objQuestionnaireEN.AnswerTypeId = null;
 }
 if (objQuestionnaireEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.AnswerTypeId);
 var strAnswerTypeId = objQuestionnaireEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objQuestionnaireEN.GridTitle !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.GridTitle);
 var strGridTitle = objQuestionnaireEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGridTitle + "'");
 }
 
 if (objQuestionnaireEN.AnswerModeId  ==  "")
 {
 objQuestionnaireEN.AnswerModeId = null;
 }
 if (objQuestionnaireEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.AnswerModeId);
 var strAnswerModeId = objQuestionnaireEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsHaveAdditionalMemo);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsHaveAdditionalMemo  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.QuestionScore !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionScore);
 arrValueListForInsert.Add(objQuestionnaireEN.QuestionScore.ToString());
 }
 
 if (objQuestionnaireEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.DefaultValue);
 var strDefaultValue = objQuestionnaireEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objQuestionnaireEN.DefaultSelectItem !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.DefaultSelectItem);
 var strDefaultSelectItem = objQuestionnaireEN.DefaultSelectItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultSelectItem + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsShow);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsShow  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaire.IsCast);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsCast  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.LikeCount);
 arrValueListForInsert.Add(objQuestionnaireEN.LikeCount.ToString());
 }
 
 if (objQuestionnaireEN.AnswerAttLimitSize !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.AnswerAttLimitSize);
 arrValueListForInsert.Add(objQuestionnaireEN.AnswerAttLimitSize.ToString());
 }
 
 if (objQuestionnaireEN.LimitedResourceType !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.LimitedResourceType);
 var strLimitedResourceType = objQuestionnaireEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLimitedResourceType + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsEffective);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaire.IsCanInPaper);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsCanInPaper  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.ExamGradeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.ExamGradeId);
 var strExamGradeId = objQuestionnaireEN.ExamGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamGradeId + "'");
 }
 
 if (objQuestionnaireEN.TextDirectId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.TextDirectId);
 var strTextDirectId = objQuestionnaireEN.TextDirectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextDirectId + "'");
 }
 
 if (objQuestionnaireEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.UpdDate);
 var strUpdDate = objQuestionnaireEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionnaireEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.UpdUser);
 var strUpdUser = objQuestionnaireEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionnaireEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.Memo);
 var strMemo = objQuestionnaireEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQuestionnaireEN.QuestionCode !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionCode);
 var strQuestionCode = objQuestionnaireEN.QuestionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionCode + "'");
 }
 
 if (objQuestionnaireEN.DifficultyLevelId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.DifficultyLevelId);
 var strDifficultyLevelId = objQuestionnaireEN.DifficultyLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDifficultyLevelId + "'");
 }
 
 if (objQuestionnaireEN.SectionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.SectionTypeId);
 var strSectionTypeId = objQuestionnaireEN.SectionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionTypeId + "'");
 }
 
 if (objQuestionnaireEN.KnowledgeGraphId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.KnowledgeGraphId);
 var strKnowledgeGraphId = objQuestionnaireEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeGraphId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.FirstIndent);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.FirstIndent  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.QuestionNameAdd !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionNameAdd);
 var strQuestionNameAdd = objQuestionnaireEN.QuestionNameAdd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNameAdd + "'");
 }
 
 if (objQuestionnaireEN.CodeTab !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CodeTab);
 var strCodeTab = objQuestionnaireEN.CodeTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTab + "'");
 }
 
 if (objQuestionnaireEN.CodeTabCode !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CodeTabCode);
 var strCodeTabCode = objQuestionnaireEN.CodeTabCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCode + "'");
 }
 
 if (objQuestionnaireEN.CodeTabCondition !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CodeTabCondition);
 var strCodeTabCondition = objQuestionnaireEN.CodeTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCondition + "'");
 }
 
 if (objQuestionnaireEN.CodeTabName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CodeTabName);
 var strCodeTabName = objQuestionnaireEN.CodeTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabName + "'");
 }
 
 if (objQuestionnaireEN.FillInTextHeight !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.FillInTextHeight);
 arrValueListForInsert.Add(objQuestionnaireEN.FillInTextHeight.ToString());
 }
 
 if (objQuestionnaireEN.FillInTextWidth !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.FillInTextWidth);
 arrValueListForInsert.Add(objQuestionnaireEN.FillInTextWidth.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsMulti4FillInText);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsMulti4FillInText  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.CheckBoxLimitCount !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CheckBoxLimitCount);
 arrValueListForInsert.Add(objQuestionnaireEN.CheckBoxLimitCount.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsJs);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsJs  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.MemoTextWidth !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.MemoTextWidth);
 arrValueListForInsert.Add(objQuestionnaireEN.MemoTextWidth.ToString());
 }
 
 if (objQuestionnaireEN.RelaEvent !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.RelaEvent);
 var strRelaEvent = objQuestionnaireEN.RelaEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaEvent + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsTest);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsTest  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.LevelModeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.LevelModeTypeId);
 var strLevelModeTypeId = objQuestionnaireEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsRandom);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsRandom  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Questionnaire");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQuestionnaireEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQuestionnaireEN objQuestionnaireEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objQuestionnaireEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objQuestionnaireEN.QuestionIndex !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionIndex);
 arrValueListForInsert.Add(objQuestionnaireEN.QuestionIndex.ToString());
 }
 
 if (objQuestionnaireEN.QuestionName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionName);
 var strQuestionName = objQuestionnaireEN.QuestionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionName + "'");
 }
 
 if (objQuestionnaireEN.QuestionContent !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionContent);
 var strQuestionContent = objQuestionnaireEN.QuestionContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionContent + "'");
 }
 
 if (objQuestionnaireEN.QuestionMemo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionMemo);
 var strQuestionMemo = objQuestionnaireEN.QuestionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionMemo + "'");
 }
 
 if (objQuestionnaireEN.QuestionNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionNo);
 var strQuestionNo = objQuestionnaireEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNo + "'");
 }
 
 if (objQuestionnaireEN.ParentQuestionId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.ParentQuestionId);
 var strParentQuestionId = objQuestionnaireEN.ParentQuestionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentQuestionId + "'");
 }
 
 if (objQuestionnaireEN.ExamAnswer !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.ExamAnswer);
 var strExamAnswer = objQuestionnaireEN.ExamAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamAnswer + "'");
 }
 
 if (objQuestionnaireEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CourseId);
 var strCourseId = objQuestionnaireEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objQuestionnaireEN.LevelNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.LevelNo);
 arrValueListForInsert.Add(objQuestionnaireEN.LevelNo.ToString());
 }
 
 if (objQuestionnaireEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CourseChapterId);
 var strCourseChapterId = objQuestionnaireEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objQuestionnaireEN.QuestionTypeId  ==  "")
 {
 objQuestionnaireEN.QuestionTypeId = null;
 }
 if (objQuestionnaireEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionTypeId);
 var strQuestionTypeId = objQuestionnaireEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 if (objQuestionnaireEN.QuestionTypeId4Course !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionTypeId4Course);
 var strQuestionTypeId4Course = objQuestionnaireEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId4Course + "'");
 }
 
 if (objQuestionnaireEN.AnswerTypeId  ==  "")
 {
 objQuestionnaireEN.AnswerTypeId = null;
 }
 if (objQuestionnaireEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.AnswerTypeId);
 var strAnswerTypeId = objQuestionnaireEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objQuestionnaireEN.GridTitle !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.GridTitle);
 var strGridTitle = objQuestionnaireEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGridTitle + "'");
 }
 
 if (objQuestionnaireEN.AnswerModeId  ==  "")
 {
 objQuestionnaireEN.AnswerModeId = null;
 }
 if (objQuestionnaireEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.AnswerModeId);
 var strAnswerModeId = objQuestionnaireEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsHaveAdditionalMemo);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsHaveAdditionalMemo  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.QuestionScore !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionScore);
 arrValueListForInsert.Add(objQuestionnaireEN.QuestionScore.ToString());
 }
 
 if (objQuestionnaireEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.DefaultValue);
 var strDefaultValue = objQuestionnaireEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objQuestionnaireEN.DefaultSelectItem !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.DefaultSelectItem);
 var strDefaultSelectItem = objQuestionnaireEN.DefaultSelectItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultSelectItem + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsShow);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsShow  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaire.IsCast);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsCast  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.LikeCount);
 arrValueListForInsert.Add(objQuestionnaireEN.LikeCount.ToString());
 }
 
 if (objQuestionnaireEN.AnswerAttLimitSize !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.AnswerAttLimitSize);
 arrValueListForInsert.Add(objQuestionnaireEN.AnswerAttLimitSize.ToString());
 }
 
 if (objQuestionnaireEN.LimitedResourceType !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.LimitedResourceType);
 var strLimitedResourceType = objQuestionnaireEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLimitedResourceType + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsEffective);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaire.IsCanInPaper);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsCanInPaper  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.ExamGradeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.ExamGradeId);
 var strExamGradeId = objQuestionnaireEN.ExamGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamGradeId + "'");
 }
 
 if (objQuestionnaireEN.TextDirectId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.TextDirectId);
 var strTextDirectId = objQuestionnaireEN.TextDirectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextDirectId + "'");
 }
 
 if (objQuestionnaireEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.UpdDate);
 var strUpdDate = objQuestionnaireEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionnaireEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.UpdUser);
 var strUpdUser = objQuestionnaireEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionnaireEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.Memo);
 var strMemo = objQuestionnaireEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objQuestionnaireEN.QuestionCode !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionCode);
 var strQuestionCode = objQuestionnaireEN.QuestionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionCode + "'");
 }
 
 if (objQuestionnaireEN.DifficultyLevelId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.DifficultyLevelId);
 var strDifficultyLevelId = objQuestionnaireEN.DifficultyLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDifficultyLevelId + "'");
 }
 
 if (objQuestionnaireEN.SectionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.SectionTypeId);
 var strSectionTypeId = objQuestionnaireEN.SectionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionTypeId + "'");
 }
 
 if (objQuestionnaireEN.KnowledgeGraphId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.KnowledgeGraphId);
 var strKnowledgeGraphId = objQuestionnaireEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeGraphId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.FirstIndent);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.FirstIndent  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.QuestionNameAdd !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.QuestionNameAdd);
 var strQuestionNameAdd = objQuestionnaireEN.QuestionNameAdd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNameAdd + "'");
 }
 
 if (objQuestionnaireEN.CodeTab !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CodeTab);
 var strCodeTab = objQuestionnaireEN.CodeTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTab + "'");
 }
 
 if (objQuestionnaireEN.CodeTabCode !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CodeTabCode);
 var strCodeTabCode = objQuestionnaireEN.CodeTabCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCode + "'");
 }
 
 if (objQuestionnaireEN.CodeTabCondition !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CodeTabCondition);
 var strCodeTabCondition = objQuestionnaireEN.CodeTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCondition + "'");
 }
 
 if (objQuestionnaireEN.CodeTabName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CodeTabName);
 var strCodeTabName = objQuestionnaireEN.CodeTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabName + "'");
 }
 
 if (objQuestionnaireEN.FillInTextHeight !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.FillInTextHeight);
 arrValueListForInsert.Add(objQuestionnaireEN.FillInTextHeight.ToString());
 }
 
 if (objQuestionnaireEN.FillInTextWidth !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.FillInTextWidth);
 arrValueListForInsert.Add(objQuestionnaireEN.FillInTextWidth.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsMulti4FillInText);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsMulti4FillInText  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.CheckBoxLimitCount !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.CheckBoxLimitCount);
 arrValueListForInsert.Add(objQuestionnaireEN.CheckBoxLimitCount.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsJs);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsJs  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.MemoTextWidth !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.MemoTextWidth);
 arrValueListForInsert.Add(objQuestionnaireEN.MemoTextWidth.ToString());
 }
 
 if (objQuestionnaireEN.RelaEvent !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.RelaEvent);
 var strRelaEvent = objQuestionnaireEN.RelaEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaEvent + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsTest);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsTest  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireEN.LevelModeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaire.LevelModeTypeId);
 var strLevelModeTypeId = objQuestionnaireEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaire.IsRandom);
 arrValueListForInsert.Add("'" + (objQuestionnaireEN.IsRandom  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Questionnaire");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQuestionnaires(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
strSQL = "Select * from Questionnaire where QuestionId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Questionnaire");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngQuestionId = TransNullToInt(oRow[conQuestionnaire.QuestionId].ToString().Trim());
if (IsExist(lngQuestionId))
{
 string strResult = "关键字变量值为:" + string.Format("QuestionId = {0}", lngQuestionId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQuestionnaireEN._CurrTabName ].NewRow();
objRow[conQuestionnaire.QuestionIndex] = oRow[conQuestionnaire.QuestionIndex].ToString().Trim(); //题目序号
objRow[conQuestionnaire.QuestionName] = oRow[conQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objRow[conQuestionnaire.QuestionContent] = oRow[conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objRow[conQuestionnaire.QuestionMemo] = oRow[conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objRow[conQuestionnaire.QuestionNo] = oRow[conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objRow[conQuestionnaire.ParentQuestionId] = oRow[conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objRow[conQuestionnaire.ExamAnswer] = oRow[conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objRow[conQuestionnaire.CourseId] = oRow[conQuestionnaire.CourseId].ToString().Trim(); //课程Id
objRow[conQuestionnaire.LevelNo] = oRow[conQuestionnaire.LevelNo].ToString().Trim(); //学习关号2
objRow[conQuestionnaire.CourseChapterId] = oRow[conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objRow[conQuestionnaire.QuestionTypeId] = oRow[conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objRow[conQuestionnaire.QuestionTypeId4Course] = oRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objRow[conQuestionnaire.AnswerTypeId] = oRow[conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objRow[conQuestionnaire.GridTitle] = oRow[conQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objRow[conQuestionnaire.AnswerModeId] = oRow[conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objRow[conQuestionnaire.IsHaveAdditionalMemo] = oRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim(); //是否有附加说明
objRow[conQuestionnaire.QuestionScore] = oRow[conQuestionnaire.QuestionScore].ToString().Trim(); //题目得分
objRow[conQuestionnaire.DefaultValue] = oRow[conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objRow[conQuestionnaire.DefaultSelectItem] = oRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objRow[conQuestionnaire.IsShow] = oRow[conQuestionnaire.IsShow].ToString().Trim(); //是否启用
objRow[conQuestionnaire.IsCast] = oRow[conQuestionnaire.IsCast].ToString().Trim(); //是否播放
objRow[conQuestionnaire.LikeCount] = oRow[conQuestionnaire.LikeCount].ToString().Trim(); //资源喜欢数量
objRow[conQuestionnaire.AnswerAttLimitSize] = oRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim(); //回答附件限制大小
objRow[conQuestionnaire.LimitedResourceType] = oRow[conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objRow[conQuestionnaire.IsEffective] = oRow[conQuestionnaire.IsEffective].ToString().Trim(); //是否有效
objRow[conQuestionnaire.IsCanInPaper] = oRow[conQuestionnaire.IsCanInPaper].ToString().Trim(); //是否可在Paper
objRow[conQuestionnaire.ExamGradeId] = oRow[conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objRow[conQuestionnaire.TextDirectId] = oRow[conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objRow[conQuestionnaire.UpdDate] = oRow[conQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objRow[conQuestionnaire.UpdUser] = oRow[conQuestionnaire.UpdUser].ToString().Trim(); //修改人
objRow[conQuestionnaire.Memo] = oRow[conQuestionnaire.Memo].ToString().Trim(); //备注
objRow[conQuestionnaire.QuestionCode] = oRow[conQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objRow[conQuestionnaire.DifficultyLevelId] = oRow[conQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objRow[conQuestionnaire.SectionTypeId] = oRow[conQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objRow[conQuestionnaire.KnowledgeGraphId] = oRow[conQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objRow[conQuestionnaire.FirstIndent] = oRow[conQuestionnaire.FirstIndent].ToString().Trim(); //首行缩进
objRow[conQuestionnaire.QuestionNameAdd] = oRow[conQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objRow[conQuestionnaire.CodeTab] = oRow[conQuestionnaire.CodeTab].ToString().Trim(); //代码表
objRow[conQuestionnaire.CodeTabCode] = oRow[conQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objRow[conQuestionnaire.CodeTabCondition] = oRow[conQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objRow[conQuestionnaire.CodeTabName] = oRow[conQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objRow[conQuestionnaire.FillInTextHeight] = oRow[conQuestionnaire.FillInTextHeight].ToString().Trim(); //填空框高度
objRow[conQuestionnaire.FillInTextWidth] = oRow[conQuestionnaire.FillInTextWidth].ToString().Trim(); //填空框宽度
objRow[conQuestionnaire.IsMulti4FillInText] = oRow[conQuestionnaire.IsMulti4FillInText].ToString().Trim(); //是否填空框多行
objRow[conQuestionnaire.CheckBoxLimitCount] = oRow[conQuestionnaire.CheckBoxLimitCount].ToString().Trim(); //复选框限制数
objRow[conQuestionnaire.IsJs] = oRow[conQuestionnaire.IsJs].ToString().Trim(); //是否是JS
objRow[conQuestionnaire.MemoTextWidth] = oRow[conQuestionnaire.MemoTextWidth].ToString().Trim(); //备注框宽度
objRow[conQuestionnaire.RelaEvent] = oRow[conQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
objRow[conQuestionnaire.IsTest] = oRow[conQuestionnaire.IsTest].ToString().Trim(); //是否测试
objRow[conQuestionnaire.LevelModeTypeId] = oRow[conQuestionnaire.LevelModeTypeId].ToString().Trim(); //模式Id
objRow[conQuestionnaire.IsRandom] = oRow[conQuestionnaire.IsRandom].ToString().Trim(); //是否随机
 objDS.Tables[clsQuestionnaireEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQuestionnaireEN._CurrTabName);
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
 /// <param name = "objQuestionnaireEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQuestionnaireEN objQuestionnaireEN)
{
 if (objQuestionnaireEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
strSQL = "Select * from Questionnaire where QuestionId = " + ""+ objQuestionnaireEN.QuestionId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQuestionnaireEN._CurrTabName);
if (objDS.Tables[clsQuestionnaireEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:QuestionId = " + ""+ objQuestionnaireEN.QuestionId+"");
return false;
}
objRow = objDS.Tables[clsQuestionnaireEN._CurrTabName].Rows[0];
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionIndex))
 {
objRow[conQuestionnaire.QuestionIndex] = objQuestionnaireEN.QuestionIndex; //题目序号
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionName))
 {
objRow[conQuestionnaire.QuestionName] = objQuestionnaireEN.QuestionName; //题目名称
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionContent))
 {
objRow[conQuestionnaire.QuestionContent] = objQuestionnaireEN.QuestionContent; //题目内容
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionMemo))
 {
objRow[conQuestionnaire.QuestionMemo] = objQuestionnaireEN.QuestionMemo; //题目说明
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionNo))
 {
objRow[conQuestionnaire.QuestionNo] = objQuestionnaireEN.QuestionNo; //题目编号
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.ParentQuestionId))
 {
objRow[conQuestionnaire.ParentQuestionId] = objQuestionnaireEN.ParentQuestionId; //父题目Id
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.ExamAnswer))
 {
objRow[conQuestionnaire.ExamAnswer] = objQuestionnaireEN.ExamAnswer; //题目答案
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CourseId))
 {
objRow[conQuestionnaire.CourseId] = objQuestionnaireEN.CourseId; //课程Id
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LevelNo))
 {
objRow[conQuestionnaire.LevelNo] = objQuestionnaireEN.LevelNo; //学习关号2
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CourseChapterId))
 {
objRow[conQuestionnaire.CourseChapterId] = objQuestionnaireEN.CourseChapterId; //课程章节ID
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionTypeId))
 {
objRow[conQuestionnaire.QuestionTypeId] = objQuestionnaireEN.QuestionTypeId; //题目类型Id
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionTypeId4Course))
 {
objRow[conQuestionnaire.QuestionTypeId4Course] = objQuestionnaireEN.QuestionTypeId4Course; //题目类型Id4课程
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.AnswerTypeId))
 {
objRow[conQuestionnaire.AnswerTypeId] = objQuestionnaireEN.AnswerTypeId; //答案类型ID
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.GridTitle))
 {
objRow[conQuestionnaire.GridTitle] = objQuestionnaireEN.GridTitle; //表格标题
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.AnswerModeId))
 {
objRow[conQuestionnaire.AnswerModeId] = objQuestionnaireEN.AnswerModeId; //答案模式Id
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsHaveAdditionalMemo))
 {
objRow[conQuestionnaire.IsHaveAdditionalMemo] = objQuestionnaireEN.IsHaveAdditionalMemo; //是否有附加说明
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionScore))
 {
objRow[conQuestionnaire.QuestionScore] = objQuestionnaireEN.QuestionScore; //题目得分
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.DefaultValue))
 {
objRow[conQuestionnaire.DefaultValue] = objQuestionnaireEN.DefaultValue; //缺省值
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.DefaultSelectItem))
 {
objRow[conQuestionnaire.DefaultSelectItem] = objQuestionnaireEN.DefaultSelectItem; //默认选项
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsShow))
 {
objRow[conQuestionnaire.IsShow] = objQuestionnaireEN.IsShow; //是否启用
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsCast))
 {
objRow[conQuestionnaire.IsCast] = objQuestionnaireEN.IsCast; //是否播放
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LikeCount))
 {
objRow[conQuestionnaire.LikeCount] = objQuestionnaireEN.LikeCount; //资源喜欢数量
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.AnswerAttLimitSize))
 {
objRow[conQuestionnaire.AnswerAttLimitSize] = objQuestionnaireEN.AnswerAttLimitSize; //回答附件限制大小
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LimitedResourceType))
 {
objRow[conQuestionnaire.LimitedResourceType] = objQuestionnaireEN.LimitedResourceType; //限制资源类型
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsEffective))
 {
objRow[conQuestionnaire.IsEffective] = objQuestionnaireEN.IsEffective; //是否有效
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsCanInPaper))
 {
objRow[conQuestionnaire.IsCanInPaper] = objQuestionnaireEN.IsCanInPaper; //是否可在Paper
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.ExamGradeId))
 {
objRow[conQuestionnaire.ExamGradeId] = objQuestionnaireEN.ExamGradeId; //题库等级ID
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.TextDirectId))
 {
objRow[conQuestionnaire.TextDirectId] = objQuestionnaireEN.TextDirectId; //文本方向ID
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.UpdDate))
 {
objRow[conQuestionnaire.UpdDate] = objQuestionnaireEN.UpdDate; //修改日期
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.UpdUser))
 {
objRow[conQuestionnaire.UpdUser] = objQuestionnaireEN.UpdUser; //修改人
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.Memo))
 {
objRow[conQuestionnaire.Memo] = objQuestionnaireEN.Memo; //备注
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionCode))
 {
objRow[conQuestionnaire.QuestionCode] = objQuestionnaireEN.QuestionCode; //html代码
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.DifficultyLevelId))
 {
objRow[conQuestionnaire.DifficultyLevelId] = objQuestionnaireEN.DifficultyLevelId; //难度等级Id
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.SectionTypeId))
 {
objRow[conQuestionnaire.SectionTypeId] = objQuestionnaireEN.SectionTypeId; //节点类型Id
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.KnowledgeGraphId))
 {
objRow[conQuestionnaire.KnowledgeGraphId] = objQuestionnaireEN.KnowledgeGraphId; //知识点图Id
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.FirstIndent))
 {
objRow[conQuestionnaire.FirstIndent] = objQuestionnaireEN.FirstIndent; //首行缩进
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionNameAdd))
 {
objRow[conQuestionnaire.QuestionNameAdd] = objQuestionnaireEN.QuestionNameAdd; //题目补充
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTab))
 {
objRow[conQuestionnaire.CodeTab] = objQuestionnaireEN.CodeTab; //代码表
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTabCode))
 {
objRow[conQuestionnaire.CodeTabCode] = objQuestionnaireEN.CodeTabCode; //CodeTab_Code
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTabCondition))
 {
objRow[conQuestionnaire.CodeTabCondition] = objQuestionnaireEN.CodeTabCondition; //代码表_条件
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTabName))
 {
objRow[conQuestionnaire.CodeTabName] = objQuestionnaireEN.CodeTabName; //CodeTab_Name
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.FillInTextHeight))
 {
objRow[conQuestionnaire.FillInTextHeight] = objQuestionnaireEN.FillInTextHeight; //填空框高度
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.FillInTextWidth))
 {
objRow[conQuestionnaire.FillInTextWidth] = objQuestionnaireEN.FillInTextWidth; //填空框宽度
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsMulti4FillInText))
 {
objRow[conQuestionnaire.IsMulti4FillInText] = objQuestionnaireEN.IsMulti4FillInText; //是否填空框多行
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CheckBoxLimitCount))
 {
objRow[conQuestionnaire.CheckBoxLimitCount] = objQuestionnaireEN.CheckBoxLimitCount; //复选框限制数
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsJs))
 {
objRow[conQuestionnaire.IsJs] = objQuestionnaireEN.IsJs; //是否是JS
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.MemoTextWidth))
 {
objRow[conQuestionnaire.MemoTextWidth] = objQuestionnaireEN.MemoTextWidth; //备注框宽度
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.RelaEvent))
 {
objRow[conQuestionnaire.RelaEvent] = objQuestionnaireEN.RelaEvent; //相关事件
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsTest))
 {
objRow[conQuestionnaire.IsTest] = objQuestionnaireEN.IsTest; //是否测试
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LevelModeTypeId))
 {
objRow[conQuestionnaire.LevelModeTypeId] = objQuestionnaireEN.LevelModeTypeId; //模式Id
 }
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsRandom))
 {
objRow[conQuestionnaire.IsRandom] = objQuestionnaireEN.IsRandom; //是否随机
 }
try
{
objDA.Update(objDS, clsQuestionnaireEN._CurrTabName);
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
 /// <param name = "objQuestionnaireEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQuestionnaireEN objQuestionnaireEN)
{
 if (objQuestionnaireEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Questionnaire Set ");
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionIndex))
 {
 if (objQuestionnaireEN.QuestionIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.QuestionIndex, conQuestionnaire.QuestionIndex); //题目序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionIndex); //题目序号
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionName))
 {
 if (objQuestionnaireEN.QuestionName !=  null)
 {
 var strQuestionName = objQuestionnaireEN.QuestionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionName, conQuestionnaire.QuestionName); //题目名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionName); //题目名称
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionContent))
 {
 if (objQuestionnaireEN.QuestionContent !=  null)
 {
 var strQuestionContent = objQuestionnaireEN.QuestionContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionContent, conQuestionnaire.QuestionContent); //题目内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionContent); //题目内容
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionMemo))
 {
 if (objQuestionnaireEN.QuestionMemo !=  null)
 {
 var strQuestionMemo = objQuestionnaireEN.QuestionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionMemo, conQuestionnaire.QuestionMemo); //题目说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionMemo); //题目说明
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionNo))
 {
 if (objQuestionnaireEN.QuestionNo !=  null)
 {
 var strQuestionNo = objQuestionnaireEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionNo, conQuestionnaire.QuestionNo); //题目编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionNo); //题目编号
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.ParentQuestionId))
 {
 if (objQuestionnaireEN.ParentQuestionId !=  null)
 {
 var strParentQuestionId = objQuestionnaireEN.ParentQuestionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentQuestionId, conQuestionnaire.ParentQuestionId); //父题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.ParentQuestionId); //父题目Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.ExamAnswer))
 {
 if (objQuestionnaireEN.ExamAnswer !=  null)
 {
 var strExamAnswer = objQuestionnaireEN.ExamAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamAnswer, conQuestionnaire.ExamAnswer); //题目答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.ExamAnswer); //题目答案
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CourseId))
 {
 if (objQuestionnaireEN.CourseId !=  null)
 {
 var strCourseId = objQuestionnaireEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conQuestionnaire.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.CourseId); //课程Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LevelNo))
 {
 if (objQuestionnaireEN.LevelNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.LevelNo, conQuestionnaire.LevelNo); //学习关号2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.LevelNo); //学习关号2
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CourseChapterId))
 {
 if (objQuestionnaireEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objQuestionnaireEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, conQuestionnaire.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.CourseChapterId); //课程章节ID
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionTypeId))
 {
 if (objQuestionnaireEN.QuestionTypeId  ==  "")
 {
 objQuestionnaireEN.QuestionTypeId = null;
 }
 if (objQuestionnaireEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objQuestionnaireEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionTypeId, conQuestionnaire.QuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionTypeId); //题目类型Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionTypeId4Course))
 {
 if (objQuestionnaireEN.QuestionTypeId4Course !=  null)
 {
 var strQuestionTypeId4Course = objQuestionnaireEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionTypeId4Course, conQuestionnaire.QuestionTypeId4Course); //题目类型Id4课程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionTypeId4Course); //题目类型Id4课程
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.AnswerTypeId))
 {
 if (objQuestionnaireEN.AnswerTypeId  ==  "")
 {
 objQuestionnaireEN.AnswerTypeId = null;
 }
 if (objQuestionnaireEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objQuestionnaireEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTypeId, conQuestionnaire.AnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.AnswerTypeId); //答案类型ID
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.GridTitle))
 {
 if (objQuestionnaireEN.GridTitle !=  null)
 {
 var strGridTitle = objQuestionnaireEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGridTitle, conQuestionnaire.GridTitle); //表格标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.GridTitle); //表格标题
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.AnswerModeId))
 {
 if (objQuestionnaireEN.AnswerModeId  ==  "")
 {
 objQuestionnaireEN.AnswerModeId = null;
 }
 if (objQuestionnaireEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objQuestionnaireEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerModeId, conQuestionnaire.AnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.AnswerModeId); //答案模式Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsHaveAdditionalMemo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsHaveAdditionalMemo == true?"1":"0", conQuestionnaire.IsHaveAdditionalMemo); //是否有附加说明
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionScore))
 {
 if (objQuestionnaireEN.QuestionScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.QuestionScore, conQuestionnaire.QuestionScore); //题目得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionScore); //题目得分
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.DefaultValue))
 {
 if (objQuestionnaireEN.DefaultValue !=  null)
 {
 var strDefaultValue = objQuestionnaireEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultValue, conQuestionnaire.DefaultValue); //缺省值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.DefaultValue); //缺省值
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.DefaultSelectItem))
 {
 if (objQuestionnaireEN.DefaultSelectItem !=  null)
 {
 var strDefaultSelectItem = objQuestionnaireEN.DefaultSelectItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultSelectItem, conQuestionnaire.DefaultSelectItem); //默认选项
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.DefaultSelectItem); //默认选项
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsShow == true?"1":"0", conQuestionnaire.IsShow); //是否启用
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsCast))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsCast == true?"1":"0", conQuestionnaire.IsCast); //是否播放
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LikeCount))
 {
 if (objQuestionnaireEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.LikeCount, conQuestionnaire.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.LikeCount); //资源喜欢数量
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.AnswerAttLimitSize))
 {
 if (objQuestionnaireEN.AnswerAttLimitSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.AnswerAttLimitSize, conQuestionnaire.AnswerAttLimitSize); //回答附件限制大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.AnswerAttLimitSize); //回答附件限制大小
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LimitedResourceType))
 {
 if (objQuestionnaireEN.LimitedResourceType !=  null)
 {
 var strLimitedResourceType = objQuestionnaireEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLimitedResourceType, conQuestionnaire.LimitedResourceType); //限制资源类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.LimitedResourceType); //限制资源类型
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsEffective))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsEffective == true?"1":"0", conQuestionnaire.IsEffective); //是否有效
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsCanInPaper))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsCanInPaper == true?"1":"0", conQuestionnaire.IsCanInPaper); //是否可在Paper
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.ExamGradeId))
 {
 if (objQuestionnaireEN.ExamGradeId !=  null)
 {
 var strExamGradeId = objQuestionnaireEN.ExamGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamGradeId, conQuestionnaire.ExamGradeId); //题库等级ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.ExamGradeId); //题库等级ID
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.TextDirectId))
 {
 if (objQuestionnaireEN.TextDirectId !=  null)
 {
 var strTextDirectId = objQuestionnaireEN.TextDirectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextDirectId, conQuestionnaire.TextDirectId); //文本方向ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.TextDirectId); //文本方向ID
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.UpdDate))
 {
 if (objQuestionnaireEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionnaireEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQuestionnaire.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.UpdDate); //修改日期
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.UpdUser))
 {
 if (objQuestionnaireEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionnaireEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQuestionnaire.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.UpdUser); //修改人
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.Memo))
 {
 if (objQuestionnaireEN.Memo !=  null)
 {
 var strMemo = objQuestionnaireEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQuestionnaire.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.Memo); //备注
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionCode))
 {
 if (objQuestionnaireEN.QuestionCode !=  null)
 {
 var strQuestionCode = objQuestionnaireEN.QuestionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionCode, conQuestionnaire.QuestionCode); //html代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionCode); //html代码
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.DifficultyLevelId))
 {
 if (objQuestionnaireEN.DifficultyLevelId !=  null)
 {
 var strDifficultyLevelId = objQuestionnaireEN.DifficultyLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDifficultyLevelId, conQuestionnaire.DifficultyLevelId); //难度等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.DifficultyLevelId); //难度等级Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.SectionTypeId))
 {
 if (objQuestionnaireEN.SectionTypeId !=  null)
 {
 var strSectionTypeId = objQuestionnaireEN.SectionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSectionTypeId, conQuestionnaire.SectionTypeId); //节点类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.SectionTypeId); //节点类型Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.KnowledgeGraphId))
 {
 if (objQuestionnaireEN.KnowledgeGraphId !=  null)
 {
 var strKnowledgeGraphId = objQuestionnaireEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeGraphId, conQuestionnaire.KnowledgeGraphId); //知识点图Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.KnowledgeGraphId); //知识点图Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.FirstIndent))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.FirstIndent == true?"1":"0", conQuestionnaire.FirstIndent); //首行缩进
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionNameAdd))
 {
 if (objQuestionnaireEN.QuestionNameAdd !=  null)
 {
 var strQuestionNameAdd = objQuestionnaireEN.QuestionNameAdd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionNameAdd, conQuestionnaire.QuestionNameAdd); //题目补充
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionNameAdd); //题目补充
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTab))
 {
 if (objQuestionnaireEN.CodeTab !=  null)
 {
 var strCodeTab = objQuestionnaireEN.CodeTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTab, conQuestionnaire.CodeTab); //代码表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.CodeTab); //代码表
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTabCode))
 {
 if (objQuestionnaireEN.CodeTabCode !=  null)
 {
 var strCodeTabCode = objQuestionnaireEN.CodeTabCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabCode, conQuestionnaire.CodeTabCode); //CodeTab_Code
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.CodeTabCode); //CodeTab_Code
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTabCondition))
 {
 if (objQuestionnaireEN.CodeTabCondition !=  null)
 {
 var strCodeTabCondition = objQuestionnaireEN.CodeTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabCondition, conQuestionnaire.CodeTabCondition); //代码表_条件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.CodeTabCondition); //代码表_条件
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTabName))
 {
 if (objQuestionnaireEN.CodeTabName !=  null)
 {
 var strCodeTabName = objQuestionnaireEN.CodeTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabName, conQuestionnaire.CodeTabName); //CodeTab_Name
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.CodeTabName); //CodeTab_Name
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.FillInTextHeight))
 {
 if (objQuestionnaireEN.FillInTextHeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.FillInTextHeight, conQuestionnaire.FillInTextHeight); //填空框高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.FillInTextHeight); //填空框高度
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.FillInTextWidth))
 {
 if (objQuestionnaireEN.FillInTextWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.FillInTextWidth, conQuestionnaire.FillInTextWidth); //填空框宽度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.FillInTextWidth); //填空框宽度
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsMulti4FillInText))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsMulti4FillInText == true?"1":"0", conQuestionnaire.IsMulti4FillInText); //是否填空框多行
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CheckBoxLimitCount))
 {
 if (objQuestionnaireEN.CheckBoxLimitCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.CheckBoxLimitCount, conQuestionnaire.CheckBoxLimitCount); //复选框限制数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.CheckBoxLimitCount); //复选框限制数
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsJs))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsJs == true?"1":"0", conQuestionnaire.IsJs); //是否是JS
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.MemoTextWidth))
 {
 if (objQuestionnaireEN.MemoTextWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.MemoTextWidth, conQuestionnaire.MemoTextWidth); //备注框宽度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.MemoTextWidth); //备注框宽度
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.RelaEvent))
 {
 if (objQuestionnaireEN.RelaEvent !=  null)
 {
 var strRelaEvent = objQuestionnaireEN.RelaEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelaEvent, conQuestionnaire.RelaEvent); //相关事件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.RelaEvent); //相关事件
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsTest))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsTest == true?"1":"0", conQuestionnaire.IsTest); //是否测试
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LevelModeTypeId))
 {
 if (objQuestionnaireEN.LevelModeTypeId !=  null)
 {
 var strLevelModeTypeId = objQuestionnaireEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelModeTypeId, conQuestionnaire.LevelModeTypeId); //模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.LevelModeTypeId); //模式Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsRandom))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsRandom == true?"1":"0", conQuestionnaire.IsRandom); //是否随机
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where QuestionId = {0}", objQuestionnaireEN.QuestionId); 
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
 /// <param name = "objQuestionnaireEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQuestionnaireEN objQuestionnaireEN, string strCondition)
{
 if (objQuestionnaireEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Questionnaire Set ");
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionIndex))
 {
 if (objQuestionnaireEN.QuestionIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.QuestionIndex, conQuestionnaire.QuestionIndex); //题目序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionIndex); //题目序号
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionName))
 {
 if (objQuestionnaireEN.QuestionName !=  null)
 {
 var strQuestionName = objQuestionnaireEN.QuestionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionName = '{0}',", strQuestionName); //题目名称
 }
 else
 {
 sbSQL.Append(" QuestionName = null,"); //题目名称
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionContent))
 {
 if (objQuestionnaireEN.QuestionContent !=  null)
 {
 var strQuestionContent = objQuestionnaireEN.QuestionContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionContent = '{0}',", strQuestionContent); //题目内容
 }
 else
 {
 sbSQL.Append(" QuestionContent = null,"); //题目内容
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionMemo))
 {
 if (objQuestionnaireEN.QuestionMemo !=  null)
 {
 var strQuestionMemo = objQuestionnaireEN.QuestionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionMemo = '{0}',", strQuestionMemo); //题目说明
 }
 else
 {
 sbSQL.Append(" QuestionMemo = null,"); //题目说明
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionNo))
 {
 if (objQuestionnaireEN.QuestionNo !=  null)
 {
 var strQuestionNo = objQuestionnaireEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionNo = '{0}',", strQuestionNo); //题目编号
 }
 else
 {
 sbSQL.Append(" QuestionNo = null,"); //题目编号
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.ParentQuestionId))
 {
 if (objQuestionnaireEN.ParentQuestionId !=  null)
 {
 var strParentQuestionId = objQuestionnaireEN.ParentQuestionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentQuestionId = '{0}',", strParentQuestionId); //父题目Id
 }
 else
 {
 sbSQL.Append(" ParentQuestionId = null,"); //父题目Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.ExamAnswer))
 {
 if (objQuestionnaireEN.ExamAnswer !=  null)
 {
 var strExamAnswer = objQuestionnaireEN.ExamAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamAnswer = '{0}',", strExamAnswer); //题目答案
 }
 else
 {
 sbSQL.Append(" ExamAnswer = null,"); //题目答案
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CourseId))
 {
 if (objQuestionnaireEN.CourseId !=  null)
 {
 var strCourseId = objQuestionnaireEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LevelNo))
 {
 if (objQuestionnaireEN.LevelNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.LevelNo, conQuestionnaire.LevelNo); //学习关号2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.LevelNo); //学习关号2
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CourseChapterId))
 {
 if (objQuestionnaireEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objQuestionnaireEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionTypeId))
 {
 if (objQuestionnaireEN.QuestionTypeId  ==  "")
 {
 objQuestionnaireEN.QuestionTypeId = null;
 }
 if (objQuestionnaireEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objQuestionnaireEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionTypeId = '{0}',", strQuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.Append(" QuestionTypeId = null,"); //题目类型Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionTypeId4Course))
 {
 if (objQuestionnaireEN.QuestionTypeId4Course !=  null)
 {
 var strQuestionTypeId4Course = objQuestionnaireEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionTypeId4Course = '{0}',", strQuestionTypeId4Course); //题目类型Id4课程
 }
 else
 {
 sbSQL.Append(" QuestionTypeId4Course = null,"); //题目类型Id4课程
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.AnswerTypeId))
 {
 if (objQuestionnaireEN.AnswerTypeId  ==  "")
 {
 objQuestionnaireEN.AnswerTypeId = null;
 }
 if (objQuestionnaireEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objQuestionnaireEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTypeId = '{0}',", strAnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.Append(" AnswerTypeId = null,"); //答案类型ID
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.GridTitle))
 {
 if (objQuestionnaireEN.GridTitle !=  null)
 {
 var strGridTitle = objQuestionnaireEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GridTitle = '{0}',", strGridTitle); //表格标题
 }
 else
 {
 sbSQL.Append(" GridTitle = null,"); //表格标题
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.AnswerModeId))
 {
 if (objQuestionnaireEN.AnswerModeId  ==  "")
 {
 objQuestionnaireEN.AnswerModeId = null;
 }
 if (objQuestionnaireEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objQuestionnaireEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerModeId = '{0}',", strAnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.Append(" AnswerModeId = null,"); //答案模式Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsHaveAdditionalMemo))
 {
 sbSQL.AppendFormat(" IsHaveAdditionalMemo = '{0}',", objQuestionnaireEN.IsHaveAdditionalMemo == true?"1":"0"); //是否有附加说明
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionScore))
 {
 if (objQuestionnaireEN.QuestionScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.QuestionScore, conQuestionnaire.QuestionScore); //题目得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionScore); //题目得分
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.DefaultValue))
 {
 if (objQuestionnaireEN.DefaultValue !=  null)
 {
 var strDefaultValue = objQuestionnaireEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultValue = '{0}',", strDefaultValue); //缺省值
 }
 else
 {
 sbSQL.Append(" DefaultValue = null,"); //缺省值
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.DefaultSelectItem))
 {
 if (objQuestionnaireEN.DefaultSelectItem !=  null)
 {
 var strDefaultSelectItem = objQuestionnaireEN.DefaultSelectItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultSelectItem = '{0}',", strDefaultSelectItem); //默认选项
 }
 else
 {
 sbSQL.Append(" DefaultSelectItem = null,"); //默认选项
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objQuestionnaireEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsCast))
 {
 sbSQL.AppendFormat(" IsCast = '{0}',", objQuestionnaireEN.IsCast == true?"1":"0"); //是否播放
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LikeCount))
 {
 if (objQuestionnaireEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.LikeCount, conQuestionnaire.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.LikeCount); //资源喜欢数量
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.AnswerAttLimitSize))
 {
 if (objQuestionnaireEN.AnswerAttLimitSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.AnswerAttLimitSize, conQuestionnaire.AnswerAttLimitSize); //回答附件限制大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.AnswerAttLimitSize); //回答附件限制大小
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LimitedResourceType))
 {
 if (objQuestionnaireEN.LimitedResourceType !=  null)
 {
 var strLimitedResourceType = objQuestionnaireEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LimitedResourceType = '{0}',", strLimitedResourceType); //限制资源类型
 }
 else
 {
 sbSQL.Append(" LimitedResourceType = null,"); //限制资源类型
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsEffective))
 {
 sbSQL.AppendFormat(" IsEffective = '{0}',", objQuestionnaireEN.IsEffective == true?"1":"0"); //是否有效
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsCanInPaper))
 {
 sbSQL.AppendFormat(" IsCanInPaper = '{0}',", objQuestionnaireEN.IsCanInPaper == true?"1":"0"); //是否可在Paper
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.ExamGradeId))
 {
 if (objQuestionnaireEN.ExamGradeId !=  null)
 {
 var strExamGradeId = objQuestionnaireEN.ExamGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamGradeId = '{0}',", strExamGradeId); //题库等级ID
 }
 else
 {
 sbSQL.Append(" ExamGradeId = null,"); //题库等级ID
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.TextDirectId))
 {
 if (objQuestionnaireEN.TextDirectId !=  null)
 {
 var strTextDirectId = objQuestionnaireEN.TextDirectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextDirectId = '{0}',", strTextDirectId); //文本方向ID
 }
 else
 {
 sbSQL.Append(" TextDirectId = null,"); //文本方向ID
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.UpdDate))
 {
 if (objQuestionnaireEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionnaireEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.UpdUser))
 {
 if (objQuestionnaireEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionnaireEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.Memo))
 {
 if (objQuestionnaireEN.Memo !=  null)
 {
 var strMemo = objQuestionnaireEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionCode))
 {
 if (objQuestionnaireEN.QuestionCode !=  null)
 {
 var strQuestionCode = objQuestionnaireEN.QuestionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionCode = '{0}',", strQuestionCode); //html代码
 }
 else
 {
 sbSQL.Append(" QuestionCode = null,"); //html代码
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.DifficultyLevelId))
 {
 if (objQuestionnaireEN.DifficultyLevelId !=  null)
 {
 var strDifficultyLevelId = objQuestionnaireEN.DifficultyLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DifficultyLevelId = '{0}',", strDifficultyLevelId); //难度等级Id
 }
 else
 {
 sbSQL.Append(" DifficultyLevelId = null,"); //难度等级Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.SectionTypeId))
 {
 if (objQuestionnaireEN.SectionTypeId !=  null)
 {
 var strSectionTypeId = objQuestionnaireEN.SectionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SectionTypeId = '{0}',", strSectionTypeId); //节点类型Id
 }
 else
 {
 sbSQL.Append(" SectionTypeId = null,"); //节点类型Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.KnowledgeGraphId))
 {
 if (objQuestionnaireEN.KnowledgeGraphId !=  null)
 {
 var strKnowledgeGraphId = objQuestionnaireEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeGraphId = '{0}',", strKnowledgeGraphId); //知识点图Id
 }
 else
 {
 sbSQL.Append(" KnowledgeGraphId = null,"); //知识点图Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.FirstIndent))
 {
 sbSQL.AppendFormat(" FirstIndent = '{0}',", objQuestionnaireEN.FirstIndent == true?"1":"0"); //首行缩进
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionNameAdd))
 {
 if (objQuestionnaireEN.QuestionNameAdd !=  null)
 {
 var strQuestionNameAdd = objQuestionnaireEN.QuestionNameAdd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionNameAdd = '{0}',", strQuestionNameAdd); //题目补充
 }
 else
 {
 sbSQL.Append(" QuestionNameAdd = null,"); //题目补充
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTab))
 {
 if (objQuestionnaireEN.CodeTab !=  null)
 {
 var strCodeTab = objQuestionnaireEN.CodeTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTab = '{0}',", strCodeTab); //代码表
 }
 else
 {
 sbSQL.Append(" CodeTab = null,"); //代码表
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTabCode))
 {
 if (objQuestionnaireEN.CodeTabCode !=  null)
 {
 var strCodeTabCode = objQuestionnaireEN.CodeTabCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabCode = '{0}',", strCodeTabCode); //CodeTab_Code
 }
 else
 {
 sbSQL.Append(" CodeTabCode = null,"); //CodeTab_Code
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTabCondition))
 {
 if (objQuestionnaireEN.CodeTabCondition !=  null)
 {
 var strCodeTabCondition = objQuestionnaireEN.CodeTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabCondition = '{0}',", strCodeTabCondition); //代码表_条件
 }
 else
 {
 sbSQL.Append(" CodeTabCondition = null,"); //代码表_条件
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTabName))
 {
 if (objQuestionnaireEN.CodeTabName !=  null)
 {
 var strCodeTabName = objQuestionnaireEN.CodeTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabName = '{0}',", strCodeTabName); //CodeTab_Name
 }
 else
 {
 sbSQL.Append(" CodeTabName = null,"); //CodeTab_Name
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.FillInTextHeight))
 {
 if (objQuestionnaireEN.FillInTextHeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.FillInTextHeight, conQuestionnaire.FillInTextHeight); //填空框高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.FillInTextHeight); //填空框高度
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.FillInTextWidth))
 {
 if (objQuestionnaireEN.FillInTextWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.FillInTextWidth, conQuestionnaire.FillInTextWidth); //填空框宽度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.FillInTextWidth); //填空框宽度
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsMulti4FillInText))
 {
 sbSQL.AppendFormat(" IsMulti4FillInText = '{0}',", objQuestionnaireEN.IsMulti4FillInText == true?"1":"0"); //是否填空框多行
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CheckBoxLimitCount))
 {
 if (objQuestionnaireEN.CheckBoxLimitCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.CheckBoxLimitCount, conQuestionnaire.CheckBoxLimitCount); //复选框限制数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.CheckBoxLimitCount); //复选框限制数
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsJs))
 {
 sbSQL.AppendFormat(" IsJs = '{0}',", objQuestionnaireEN.IsJs == true?"1":"0"); //是否是JS
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.MemoTextWidth))
 {
 if (objQuestionnaireEN.MemoTextWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.MemoTextWidth, conQuestionnaire.MemoTextWidth); //备注框宽度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.MemoTextWidth); //备注框宽度
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.RelaEvent))
 {
 if (objQuestionnaireEN.RelaEvent !=  null)
 {
 var strRelaEvent = objQuestionnaireEN.RelaEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelaEvent = '{0}',", strRelaEvent); //相关事件
 }
 else
 {
 sbSQL.Append(" RelaEvent = null,"); //相关事件
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsTest))
 {
 sbSQL.AppendFormat(" IsTest = '{0}',", objQuestionnaireEN.IsTest == true?"1":"0"); //是否测试
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LevelModeTypeId))
 {
 if (objQuestionnaireEN.LevelModeTypeId !=  null)
 {
 var strLevelModeTypeId = objQuestionnaireEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelModeTypeId = '{0}',", strLevelModeTypeId); //模式Id
 }
 else
 {
 sbSQL.Append(" LevelModeTypeId = null,"); //模式Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsRandom))
 {
 sbSQL.AppendFormat(" IsRandom = '{0}',", objQuestionnaireEN.IsRandom == true?"1":"0"); //是否随机
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
 /// <param name = "objQuestionnaireEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQuestionnaireEN objQuestionnaireEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQuestionnaireEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Questionnaire Set ");
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionIndex))
 {
 if (objQuestionnaireEN.QuestionIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.QuestionIndex, conQuestionnaire.QuestionIndex); //题目序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionIndex); //题目序号
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionName))
 {
 if (objQuestionnaireEN.QuestionName !=  null)
 {
 var strQuestionName = objQuestionnaireEN.QuestionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionName = '{0}',", strQuestionName); //题目名称
 }
 else
 {
 sbSQL.Append(" QuestionName = null,"); //题目名称
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionContent))
 {
 if (objQuestionnaireEN.QuestionContent !=  null)
 {
 var strQuestionContent = objQuestionnaireEN.QuestionContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionContent = '{0}',", strQuestionContent); //题目内容
 }
 else
 {
 sbSQL.Append(" QuestionContent = null,"); //题目内容
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionMemo))
 {
 if (objQuestionnaireEN.QuestionMemo !=  null)
 {
 var strQuestionMemo = objQuestionnaireEN.QuestionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionMemo = '{0}',", strQuestionMemo); //题目说明
 }
 else
 {
 sbSQL.Append(" QuestionMemo = null,"); //题目说明
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionNo))
 {
 if (objQuestionnaireEN.QuestionNo !=  null)
 {
 var strQuestionNo = objQuestionnaireEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionNo = '{0}',", strQuestionNo); //题目编号
 }
 else
 {
 sbSQL.Append(" QuestionNo = null,"); //题目编号
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.ParentQuestionId))
 {
 if (objQuestionnaireEN.ParentQuestionId !=  null)
 {
 var strParentQuestionId = objQuestionnaireEN.ParentQuestionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentQuestionId = '{0}',", strParentQuestionId); //父题目Id
 }
 else
 {
 sbSQL.Append(" ParentQuestionId = null,"); //父题目Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.ExamAnswer))
 {
 if (objQuestionnaireEN.ExamAnswer !=  null)
 {
 var strExamAnswer = objQuestionnaireEN.ExamAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamAnswer = '{0}',", strExamAnswer); //题目答案
 }
 else
 {
 sbSQL.Append(" ExamAnswer = null,"); //题目答案
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CourseId))
 {
 if (objQuestionnaireEN.CourseId !=  null)
 {
 var strCourseId = objQuestionnaireEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LevelNo))
 {
 if (objQuestionnaireEN.LevelNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.LevelNo, conQuestionnaire.LevelNo); //学习关号2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.LevelNo); //学习关号2
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CourseChapterId))
 {
 if (objQuestionnaireEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objQuestionnaireEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionTypeId))
 {
 if (objQuestionnaireEN.QuestionTypeId  ==  "")
 {
 objQuestionnaireEN.QuestionTypeId = null;
 }
 if (objQuestionnaireEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objQuestionnaireEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionTypeId = '{0}',", strQuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.Append(" QuestionTypeId = null,"); //题目类型Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionTypeId4Course))
 {
 if (objQuestionnaireEN.QuestionTypeId4Course !=  null)
 {
 var strQuestionTypeId4Course = objQuestionnaireEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionTypeId4Course = '{0}',", strQuestionTypeId4Course); //题目类型Id4课程
 }
 else
 {
 sbSQL.Append(" QuestionTypeId4Course = null,"); //题目类型Id4课程
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.AnswerTypeId))
 {
 if (objQuestionnaireEN.AnswerTypeId  ==  "")
 {
 objQuestionnaireEN.AnswerTypeId = null;
 }
 if (objQuestionnaireEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objQuestionnaireEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTypeId = '{0}',", strAnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.Append(" AnswerTypeId = null,"); //答案类型ID
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.GridTitle))
 {
 if (objQuestionnaireEN.GridTitle !=  null)
 {
 var strGridTitle = objQuestionnaireEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GridTitle = '{0}',", strGridTitle); //表格标题
 }
 else
 {
 sbSQL.Append(" GridTitle = null,"); //表格标题
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.AnswerModeId))
 {
 if (objQuestionnaireEN.AnswerModeId  ==  "")
 {
 objQuestionnaireEN.AnswerModeId = null;
 }
 if (objQuestionnaireEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objQuestionnaireEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerModeId = '{0}',", strAnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.Append(" AnswerModeId = null,"); //答案模式Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsHaveAdditionalMemo))
 {
 sbSQL.AppendFormat(" IsHaveAdditionalMemo = '{0}',", objQuestionnaireEN.IsHaveAdditionalMemo == true?"1":"0"); //是否有附加说明
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionScore))
 {
 if (objQuestionnaireEN.QuestionScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.QuestionScore, conQuestionnaire.QuestionScore); //题目得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionScore); //题目得分
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.DefaultValue))
 {
 if (objQuestionnaireEN.DefaultValue !=  null)
 {
 var strDefaultValue = objQuestionnaireEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultValue = '{0}',", strDefaultValue); //缺省值
 }
 else
 {
 sbSQL.Append(" DefaultValue = null,"); //缺省值
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.DefaultSelectItem))
 {
 if (objQuestionnaireEN.DefaultSelectItem !=  null)
 {
 var strDefaultSelectItem = objQuestionnaireEN.DefaultSelectItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultSelectItem = '{0}',", strDefaultSelectItem); //默认选项
 }
 else
 {
 sbSQL.Append(" DefaultSelectItem = null,"); //默认选项
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objQuestionnaireEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsCast))
 {
 sbSQL.AppendFormat(" IsCast = '{0}',", objQuestionnaireEN.IsCast == true?"1":"0"); //是否播放
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LikeCount))
 {
 if (objQuestionnaireEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.LikeCount, conQuestionnaire.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.LikeCount); //资源喜欢数量
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.AnswerAttLimitSize))
 {
 if (objQuestionnaireEN.AnswerAttLimitSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.AnswerAttLimitSize, conQuestionnaire.AnswerAttLimitSize); //回答附件限制大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.AnswerAttLimitSize); //回答附件限制大小
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LimitedResourceType))
 {
 if (objQuestionnaireEN.LimitedResourceType !=  null)
 {
 var strLimitedResourceType = objQuestionnaireEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LimitedResourceType = '{0}',", strLimitedResourceType); //限制资源类型
 }
 else
 {
 sbSQL.Append(" LimitedResourceType = null,"); //限制资源类型
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsEffective))
 {
 sbSQL.AppendFormat(" IsEffective = '{0}',", objQuestionnaireEN.IsEffective == true?"1":"0"); //是否有效
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsCanInPaper))
 {
 sbSQL.AppendFormat(" IsCanInPaper = '{0}',", objQuestionnaireEN.IsCanInPaper == true?"1":"0"); //是否可在Paper
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.ExamGradeId))
 {
 if (objQuestionnaireEN.ExamGradeId !=  null)
 {
 var strExamGradeId = objQuestionnaireEN.ExamGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamGradeId = '{0}',", strExamGradeId); //题库等级ID
 }
 else
 {
 sbSQL.Append(" ExamGradeId = null,"); //题库等级ID
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.TextDirectId))
 {
 if (objQuestionnaireEN.TextDirectId !=  null)
 {
 var strTextDirectId = objQuestionnaireEN.TextDirectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextDirectId = '{0}',", strTextDirectId); //文本方向ID
 }
 else
 {
 sbSQL.Append(" TextDirectId = null,"); //文本方向ID
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.UpdDate))
 {
 if (objQuestionnaireEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionnaireEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.UpdUser))
 {
 if (objQuestionnaireEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionnaireEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.Memo))
 {
 if (objQuestionnaireEN.Memo !=  null)
 {
 var strMemo = objQuestionnaireEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionCode))
 {
 if (objQuestionnaireEN.QuestionCode !=  null)
 {
 var strQuestionCode = objQuestionnaireEN.QuestionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionCode = '{0}',", strQuestionCode); //html代码
 }
 else
 {
 sbSQL.Append(" QuestionCode = null,"); //html代码
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.DifficultyLevelId))
 {
 if (objQuestionnaireEN.DifficultyLevelId !=  null)
 {
 var strDifficultyLevelId = objQuestionnaireEN.DifficultyLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DifficultyLevelId = '{0}',", strDifficultyLevelId); //难度等级Id
 }
 else
 {
 sbSQL.Append(" DifficultyLevelId = null,"); //难度等级Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.SectionTypeId))
 {
 if (objQuestionnaireEN.SectionTypeId !=  null)
 {
 var strSectionTypeId = objQuestionnaireEN.SectionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SectionTypeId = '{0}',", strSectionTypeId); //节点类型Id
 }
 else
 {
 sbSQL.Append(" SectionTypeId = null,"); //节点类型Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.KnowledgeGraphId))
 {
 if (objQuestionnaireEN.KnowledgeGraphId !=  null)
 {
 var strKnowledgeGraphId = objQuestionnaireEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeGraphId = '{0}',", strKnowledgeGraphId); //知识点图Id
 }
 else
 {
 sbSQL.Append(" KnowledgeGraphId = null,"); //知识点图Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.FirstIndent))
 {
 sbSQL.AppendFormat(" FirstIndent = '{0}',", objQuestionnaireEN.FirstIndent == true?"1":"0"); //首行缩进
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionNameAdd))
 {
 if (objQuestionnaireEN.QuestionNameAdd !=  null)
 {
 var strQuestionNameAdd = objQuestionnaireEN.QuestionNameAdd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionNameAdd = '{0}',", strQuestionNameAdd); //题目补充
 }
 else
 {
 sbSQL.Append(" QuestionNameAdd = null,"); //题目补充
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTab))
 {
 if (objQuestionnaireEN.CodeTab !=  null)
 {
 var strCodeTab = objQuestionnaireEN.CodeTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTab = '{0}',", strCodeTab); //代码表
 }
 else
 {
 sbSQL.Append(" CodeTab = null,"); //代码表
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTabCode))
 {
 if (objQuestionnaireEN.CodeTabCode !=  null)
 {
 var strCodeTabCode = objQuestionnaireEN.CodeTabCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabCode = '{0}',", strCodeTabCode); //CodeTab_Code
 }
 else
 {
 sbSQL.Append(" CodeTabCode = null,"); //CodeTab_Code
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTabCondition))
 {
 if (objQuestionnaireEN.CodeTabCondition !=  null)
 {
 var strCodeTabCondition = objQuestionnaireEN.CodeTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabCondition = '{0}',", strCodeTabCondition); //代码表_条件
 }
 else
 {
 sbSQL.Append(" CodeTabCondition = null,"); //代码表_条件
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTabName))
 {
 if (objQuestionnaireEN.CodeTabName !=  null)
 {
 var strCodeTabName = objQuestionnaireEN.CodeTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabName = '{0}',", strCodeTabName); //CodeTab_Name
 }
 else
 {
 sbSQL.Append(" CodeTabName = null,"); //CodeTab_Name
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.FillInTextHeight))
 {
 if (objQuestionnaireEN.FillInTextHeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.FillInTextHeight, conQuestionnaire.FillInTextHeight); //填空框高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.FillInTextHeight); //填空框高度
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.FillInTextWidth))
 {
 if (objQuestionnaireEN.FillInTextWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.FillInTextWidth, conQuestionnaire.FillInTextWidth); //填空框宽度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.FillInTextWidth); //填空框宽度
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsMulti4FillInText))
 {
 sbSQL.AppendFormat(" IsMulti4FillInText = '{0}',", objQuestionnaireEN.IsMulti4FillInText == true?"1":"0"); //是否填空框多行
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CheckBoxLimitCount))
 {
 if (objQuestionnaireEN.CheckBoxLimitCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.CheckBoxLimitCount, conQuestionnaire.CheckBoxLimitCount); //复选框限制数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.CheckBoxLimitCount); //复选框限制数
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsJs))
 {
 sbSQL.AppendFormat(" IsJs = '{0}',", objQuestionnaireEN.IsJs == true?"1":"0"); //是否是JS
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.MemoTextWidth))
 {
 if (objQuestionnaireEN.MemoTextWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.MemoTextWidth, conQuestionnaire.MemoTextWidth); //备注框宽度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.MemoTextWidth); //备注框宽度
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.RelaEvent))
 {
 if (objQuestionnaireEN.RelaEvent !=  null)
 {
 var strRelaEvent = objQuestionnaireEN.RelaEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelaEvent = '{0}',", strRelaEvent); //相关事件
 }
 else
 {
 sbSQL.Append(" RelaEvent = null,"); //相关事件
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsTest))
 {
 sbSQL.AppendFormat(" IsTest = '{0}',", objQuestionnaireEN.IsTest == true?"1":"0"); //是否测试
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LevelModeTypeId))
 {
 if (objQuestionnaireEN.LevelModeTypeId !=  null)
 {
 var strLevelModeTypeId = objQuestionnaireEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelModeTypeId = '{0}',", strLevelModeTypeId); //模式Id
 }
 else
 {
 sbSQL.Append(" LevelModeTypeId = null,"); //模式Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsRandom))
 {
 sbSQL.AppendFormat(" IsRandom = '{0}',", objQuestionnaireEN.IsRandom == true?"1":"0"); //是否随机
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
 /// <param name = "objQuestionnaireEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQuestionnaireEN objQuestionnaireEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objQuestionnaireEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Questionnaire Set ");
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionIndex))
 {
 if (objQuestionnaireEN.QuestionIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.QuestionIndex, conQuestionnaire.QuestionIndex); //题目序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionIndex); //题目序号
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionName))
 {
 if (objQuestionnaireEN.QuestionName !=  null)
 {
 var strQuestionName = objQuestionnaireEN.QuestionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionName, conQuestionnaire.QuestionName); //题目名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionName); //题目名称
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionContent))
 {
 if (objQuestionnaireEN.QuestionContent !=  null)
 {
 var strQuestionContent = objQuestionnaireEN.QuestionContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionContent, conQuestionnaire.QuestionContent); //题目内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionContent); //题目内容
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionMemo))
 {
 if (objQuestionnaireEN.QuestionMemo !=  null)
 {
 var strQuestionMemo = objQuestionnaireEN.QuestionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionMemo, conQuestionnaire.QuestionMemo); //题目说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionMemo); //题目说明
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionNo))
 {
 if (objQuestionnaireEN.QuestionNo !=  null)
 {
 var strQuestionNo = objQuestionnaireEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionNo, conQuestionnaire.QuestionNo); //题目编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionNo); //题目编号
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.ParentQuestionId))
 {
 if (objQuestionnaireEN.ParentQuestionId !=  null)
 {
 var strParentQuestionId = objQuestionnaireEN.ParentQuestionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentQuestionId, conQuestionnaire.ParentQuestionId); //父题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.ParentQuestionId); //父题目Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.ExamAnswer))
 {
 if (objQuestionnaireEN.ExamAnswer !=  null)
 {
 var strExamAnswer = objQuestionnaireEN.ExamAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamAnswer, conQuestionnaire.ExamAnswer); //题目答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.ExamAnswer); //题目答案
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CourseId))
 {
 if (objQuestionnaireEN.CourseId !=  null)
 {
 var strCourseId = objQuestionnaireEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conQuestionnaire.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.CourseId); //课程Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LevelNo))
 {
 if (objQuestionnaireEN.LevelNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.LevelNo, conQuestionnaire.LevelNo); //学习关号2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.LevelNo); //学习关号2
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CourseChapterId))
 {
 if (objQuestionnaireEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objQuestionnaireEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, conQuestionnaire.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.CourseChapterId); //课程章节ID
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionTypeId))
 {
 if (objQuestionnaireEN.QuestionTypeId  ==  "")
 {
 objQuestionnaireEN.QuestionTypeId = null;
 }
 if (objQuestionnaireEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objQuestionnaireEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionTypeId, conQuestionnaire.QuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionTypeId); //题目类型Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionTypeId4Course))
 {
 if (objQuestionnaireEN.QuestionTypeId4Course !=  null)
 {
 var strQuestionTypeId4Course = objQuestionnaireEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionTypeId4Course, conQuestionnaire.QuestionTypeId4Course); //题目类型Id4课程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionTypeId4Course); //题目类型Id4课程
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.AnswerTypeId))
 {
 if (objQuestionnaireEN.AnswerTypeId  ==  "")
 {
 objQuestionnaireEN.AnswerTypeId = null;
 }
 if (objQuestionnaireEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objQuestionnaireEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTypeId, conQuestionnaire.AnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.AnswerTypeId); //答案类型ID
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.GridTitle))
 {
 if (objQuestionnaireEN.GridTitle !=  null)
 {
 var strGridTitle = objQuestionnaireEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGridTitle, conQuestionnaire.GridTitle); //表格标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.GridTitle); //表格标题
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.AnswerModeId))
 {
 if (objQuestionnaireEN.AnswerModeId  ==  "")
 {
 objQuestionnaireEN.AnswerModeId = null;
 }
 if (objQuestionnaireEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objQuestionnaireEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerModeId, conQuestionnaire.AnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.AnswerModeId); //答案模式Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsHaveAdditionalMemo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsHaveAdditionalMemo == true?"1":"0", conQuestionnaire.IsHaveAdditionalMemo); //是否有附加说明
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionScore))
 {
 if (objQuestionnaireEN.QuestionScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.QuestionScore, conQuestionnaire.QuestionScore); //题目得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionScore); //题目得分
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.DefaultValue))
 {
 if (objQuestionnaireEN.DefaultValue !=  null)
 {
 var strDefaultValue = objQuestionnaireEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultValue, conQuestionnaire.DefaultValue); //缺省值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.DefaultValue); //缺省值
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.DefaultSelectItem))
 {
 if (objQuestionnaireEN.DefaultSelectItem !=  null)
 {
 var strDefaultSelectItem = objQuestionnaireEN.DefaultSelectItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultSelectItem, conQuestionnaire.DefaultSelectItem); //默认选项
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.DefaultSelectItem); //默认选项
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsShow == true?"1":"0", conQuestionnaire.IsShow); //是否启用
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsCast))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsCast == true?"1":"0", conQuestionnaire.IsCast); //是否播放
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LikeCount))
 {
 if (objQuestionnaireEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.LikeCount, conQuestionnaire.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.LikeCount); //资源喜欢数量
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.AnswerAttLimitSize))
 {
 if (objQuestionnaireEN.AnswerAttLimitSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.AnswerAttLimitSize, conQuestionnaire.AnswerAttLimitSize); //回答附件限制大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.AnswerAttLimitSize); //回答附件限制大小
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LimitedResourceType))
 {
 if (objQuestionnaireEN.LimitedResourceType !=  null)
 {
 var strLimitedResourceType = objQuestionnaireEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLimitedResourceType, conQuestionnaire.LimitedResourceType); //限制资源类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.LimitedResourceType); //限制资源类型
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsEffective))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsEffective == true?"1":"0", conQuestionnaire.IsEffective); //是否有效
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsCanInPaper))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsCanInPaper == true?"1":"0", conQuestionnaire.IsCanInPaper); //是否可在Paper
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.ExamGradeId))
 {
 if (objQuestionnaireEN.ExamGradeId !=  null)
 {
 var strExamGradeId = objQuestionnaireEN.ExamGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamGradeId, conQuestionnaire.ExamGradeId); //题库等级ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.ExamGradeId); //题库等级ID
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.TextDirectId))
 {
 if (objQuestionnaireEN.TextDirectId !=  null)
 {
 var strTextDirectId = objQuestionnaireEN.TextDirectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextDirectId, conQuestionnaire.TextDirectId); //文本方向ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.TextDirectId); //文本方向ID
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.UpdDate))
 {
 if (objQuestionnaireEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionnaireEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQuestionnaire.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.UpdDate); //修改日期
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.UpdUser))
 {
 if (objQuestionnaireEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionnaireEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQuestionnaire.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.UpdUser); //修改人
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.Memo))
 {
 if (objQuestionnaireEN.Memo !=  null)
 {
 var strMemo = objQuestionnaireEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQuestionnaire.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.Memo); //备注
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionCode))
 {
 if (objQuestionnaireEN.QuestionCode !=  null)
 {
 var strQuestionCode = objQuestionnaireEN.QuestionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionCode, conQuestionnaire.QuestionCode); //html代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionCode); //html代码
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.DifficultyLevelId))
 {
 if (objQuestionnaireEN.DifficultyLevelId !=  null)
 {
 var strDifficultyLevelId = objQuestionnaireEN.DifficultyLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDifficultyLevelId, conQuestionnaire.DifficultyLevelId); //难度等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.DifficultyLevelId); //难度等级Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.SectionTypeId))
 {
 if (objQuestionnaireEN.SectionTypeId !=  null)
 {
 var strSectionTypeId = objQuestionnaireEN.SectionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSectionTypeId, conQuestionnaire.SectionTypeId); //节点类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.SectionTypeId); //节点类型Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.KnowledgeGraphId))
 {
 if (objQuestionnaireEN.KnowledgeGraphId !=  null)
 {
 var strKnowledgeGraphId = objQuestionnaireEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeGraphId, conQuestionnaire.KnowledgeGraphId); //知识点图Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.KnowledgeGraphId); //知识点图Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.FirstIndent))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.FirstIndent == true?"1":"0", conQuestionnaire.FirstIndent); //首行缩进
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.QuestionNameAdd))
 {
 if (objQuestionnaireEN.QuestionNameAdd !=  null)
 {
 var strQuestionNameAdd = objQuestionnaireEN.QuestionNameAdd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionNameAdd, conQuestionnaire.QuestionNameAdd); //题目补充
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.QuestionNameAdd); //题目补充
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTab))
 {
 if (objQuestionnaireEN.CodeTab !=  null)
 {
 var strCodeTab = objQuestionnaireEN.CodeTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTab, conQuestionnaire.CodeTab); //代码表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.CodeTab); //代码表
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTabCode))
 {
 if (objQuestionnaireEN.CodeTabCode !=  null)
 {
 var strCodeTabCode = objQuestionnaireEN.CodeTabCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabCode, conQuestionnaire.CodeTabCode); //CodeTab_Code
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.CodeTabCode); //CodeTab_Code
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTabCondition))
 {
 if (objQuestionnaireEN.CodeTabCondition !=  null)
 {
 var strCodeTabCondition = objQuestionnaireEN.CodeTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabCondition, conQuestionnaire.CodeTabCondition); //代码表_条件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.CodeTabCondition); //代码表_条件
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CodeTabName))
 {
 if (objQuestionnaireEN.CodeTabName !=  null)
 {
 var strCodeTabName = objQuestionnaireEN.CodeTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabName, conQuestionnaire.CodeTabName); //CodeTab_Name
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.CodeTabName); //CodeTab_Name
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.FillInTextHeight))
 {
 if (objQuestionnaireEN.FillInTextHeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.FillInTextHeight, conQuestionnaire.FillInTextHeight); //填空框高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.FillInTextHeight); //填空框高度
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.FillInTextWidth))
 {
 if (objQuestionnaireEN.FillInTextWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.FillInTextWidth, conQuestionnaire.FillInTextWidth); //填空框宽度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.FillInTextWidth); //填空框宽度
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsMulti4FillInText))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsMulti4FillInText == true?"1":"0", conQuestionnaire.IsMulti4FillInText); //是否填空框多行
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.CheckBoxLimitCount))
 {
 if (objQuestionnaireEN.CheckBoxLimitCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.CheckBoxLimitCount, conQuestionnaire.CheckBoxLimitCount); //复选框限制数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.CheckBoxLimitCount); //复选框限制数
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsJs))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsJs == true?"1":"0", conQuestionnaire.IsJs); //是否是JS
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.MemoTextWidth))
 {
 if (objQuestionnaireEN.MemoTextWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireEN.MemoTextWidth, conQuestionnaire.MemoTextWidth); //备注框宽度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.MemoTextWidth); //备注框宽度
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.RelaEvent))
 {
 if (objQuestionnaireEN.RelaEvent !=  null)
 {
 var strRelaEvent = objQuestionnaireEN.RelaEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelaEvent, conQuestionnaire.RelaEvent); //相关事件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.RelaEvent); //相关事件
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsTest))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsTest == true?"1":"0", conQuestionnaire.IsTest); //是否测试
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.LevelModeTypeId))
 {
 if (objQuestionnaireEN.LevelModeTypeId !=  null)
 {
 var strLevelModeTypeId = objQuestionnaireEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelModeTypeId, conQuestionnaire.LevelModeTypeId); //模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaire.LevelModeTypeId); //模式Id
 }
 }
 
 if (objQuestionnaireEN.IsUpdated(conQuestionnaire.IsRandom))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireEN.IsRandom == true?"1":"0", conQuestionnaire.IsRandom); //是否随机
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where QuestionId = {0}", objQuestionnaireEN.QuestionId); 
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
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngQuestionId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngQuestionId,
};
 objSQL.ExecSP("Questionnaire_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngQuestionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
//删除Questionnaire本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Questionnaire where QuestionId = " + ""+ lngQuestionId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQuestionnaire(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
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
//删除Questionnaire本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Questionnaire where QuestionId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngQuestionId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
//删除Questionnaire本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Questionnaire where QuestionId = " + ""+ lngQuestionId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQuestionnaire(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQuestionnaireDA: DelQuestionnaire)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Questionnaire where " + strCondition ;
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
public bool DelQuestionnaireWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQuestionnaireDA: DelQuestionnaireWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Questionnaire where " + strCondition ;
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
 /// <param name = "objQuestionnaireENS">源对象</param>
 /// <param name = "objQuestionnaireENT">目标对象</param>
public void CopyTo(clsQuestionnaireEN objQuestionnaireENS, clsQuestionnaireEN objQuestionnaireENT)
{
objQuestionnaireENT.QuestionId = objQuestionnaireENS.QuestionId; //题目Id
objQuestionnaireENT.QuestionIndex = objQuestionnaireENS.QuestionIndex; //题目序号
objQuestionnaireENT.QuestionName = objQuestionnaireENS.QuestionName; //题目名称
objQuestionnaireENT.QuestionContent = objQuestionnaireENS.QuestionContent; //题目内容
objQuestionnaireENT.QuestionMemo = objQuestionnaireENS.QuestionMemo; //题目说明
objQuestionnaireENT.QuestionNo = objQuestionnaireENS.QuestionNo; //题目编号
objQuestionnaireENT.ParentQuestionId = objQuestionnaireENS.ParentQuestionId; //父题目Id
objQuestionnaireENT.ExamAnswer = objQuestionnaireENS.ExamAnswer; //题目答案
objQuestionnaireENT.CourseId = objQuestionnaireENS.CourseId; //课程Id
objQuestionnaireENT.LevelNo = objQuestionnaireENS.LevelNo; //学习关号2
objQuestionnaireENT.CourseChapterId = objQuestionnaireENS.CourseChapterId; //课程章节ID
objQuestionnaireENT.QuestionTypeId = objQuestionnaireENS.QuestionTypeId; //题目类型Id
objQuestionnaireENT.QuestionTypeId4Course = objQuestionnaireENS.QuestionTypeId4Course; //题目类型Id4课程
objQuestionnaireENT.AnswerTypeId = objQuestionnaireENS.AnswerTypeId; //答案类型ID
objQuestionnaireENT.GridTitle = objQuestionnaireENS.GridTitle; //表格标题
objQuestionnaireENT.AnswerModeId = objQuestionnaireENS.AnswerModeId; //答案模式Id
objQuestionnaireENT.IsHaveAdditionalMemo = objQuestionnaireENS.IsHaveAdditionalMemo; //是否有附加说明
objQuestionnaireENT.QuestionScore = objQuestionnaireENS.QuestionScore; //题目得分
objQuestionnaireENT.DefaultValue = objQuestionnaireENS.DefaultValue; //缺省值
objQuestionnaireENT.DefaultSelectItem = objQuestionnaireENS.DefaultSelectItem; //默认选项
objQuestionnaireENT.IsShow = objQuestionnaireENS.IsShow; //是否启用
objQuestionnaireENT.IsCast = objQuestionnaireENS.IsCast; //是否播放
objQuestionnaireENT.LikeCount = objQuestionnaireENS.LikeCount; //资源喜欢数量
objQuestionnaireENT.AnswerAttLimitSize = objQuestionnaireENS.AnswerAttLimitSize; //回答附件限制大小
objQuestionnaireENT.LimitedResourceType = objQuestionnaireENS.LimitedResourceType; //限制资源类型
objQuestionnaireENT.IsEffective = objQuestionnaireENS.IsEffective; //是否有效
objQuestionnaireENT.IsCanInPaper = objQuestionnaireENS.IsCanInPaper; //是否可在Paper
objQuestionnaireENT.ExamGradeId = objQuestionnaireENS.ExamGradeId; //题库等级ID
objQuestionnaireENT.TextDirectId = objQuestionnaireENS.TextDirectId; //文本方向ID
objQuestionnaireENT.UpdDate = objQuestionnaireENS.UpdDate; //修改日期
objQuestionnaireENT.UpdUser = objQuestionnaireENS.UpdUser; //修改人
objQuestionnaireENT.Memo = objQuestionnaireENS.Memo; //备注
objQuestionnaireENT.QuestionCode = objQuestionnaireENS.QuestionCode; //html代码
objQuestionnaireENT.DifficultyLevelId = objQuestionnaireENS.DifficultyLevelId; //难度等级Id
objQuestionnaireENT.SectionTypeId = objQuestionnaireENS.SectionTypeId; //节点类型Id
objQuestionnaireENT.KnowledgeGraphId = objQuestionnaireENS.KnowledgeGraphId; //知识点图Id
objQuestionnaireENT.FirstIndent = objQuestionnaireENS.FirstIndent; //首行缩进
objQuestionnaireENT.QuestionNameAdd = objQuestionnaireENS.QuestionNameAdd; //题目补充
objQuestionnaireENT.CodeTab = objQuestionnaireENS.CodeTab; //代码表
objQuestionnaireENT.CodeTabCode = objQuestionnaireENS.CodeTabCode; //CodeTab_Code
objQuestionnaireENT.CodeTabCondition = objQuestionnaireENS.CodeTabCondition; //代码表_条件
objQuestionnaireENT.CodeTabName = objQuestionnaireENS.CodeTabName; //CodeTab_Name
objQuestionnaireENT.FillInTextHeight = objQuestionnaireENS.FillInTextHeight; //填空框高度
objQuestionnaireENT.FillInTextWidth = objQuestionnaireENS.FillInTextWidth; //填空框宽度
objQuestionnaireENT.IsMulti4FillInText = objQuestionnaireENS.IsMulti4FillInText; //是否填空框多行
objQuestionnaireENT.CheckBoxLimitCount = objQuestionnaireENS.CheckBoxLimitCount; //复选框限制数
objQuestionnaireENT.IsJs = objQuestionnaireENS.IsJs; //是否是JS
objQuestionnaireENT.MemoTextWidth = objQuestionnaireENS.MemoTextWidth; //备注框宽度
objQuestionnaireENT.RelaEvent = objQuestionnaireENS.RelaEvent; //相关事件
objQuestionnaireENT.IsTest = objQuestionnaireENS.IsTest; //是否测试
objQuestionnaireENT.LevelModeTypeId = objQuestionnaireENS.LevelModeTypeId; //模式Id
objQuestionnaireENT.IsRandom = objQuestionnaireENS.IsRandom; //是否随机
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQuestionnaireEN objQuestionnaireEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQuestionnaireEN.QuestionName, conQuestionnaire.QuestionName);
clsCheckSql.CheckFieldNotNull(objQuestionnaireEN.CourseId, conQuestionnaire.CourseId);
clsCheckSql.CheckFieldNotNull(objQuestionnaireEN.UpdDate, conQuestionnaire.UpdDate);
clsCheckSql.CheckFieldNotNull(objQuestionnaireEN.UpdUser, conQuestionnaire.UpdUser);
clsCheckSql.CheckFieldNotNull(objQuestionnaireEN.LevelModeTypeId, conQuestionnaire.LevelModeTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionName, 500, conQuestionnaire.QuestionName);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionContent, 4000, conQuestionnaire.QuestionContent);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionMemo, 1000, conQuestionnaire.QuestionMemo);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionNo, 10, conQuestionnaire.QuestionNo);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.ParentQuestionId, 8, conQuestionnaire.ParentQuestionId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.ExamAnswer, 8000, conQuestionnaire.ExamAnswer);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CourseId, 8, conQuestionnaire.CourseId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CourseChapterId, 8, conQuestionnaire.CourseChapterId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionTypeId, 2, conQuestionnaire.QuestionTypeId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionTypeId4Course, 8, conQuestionnaire.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.AnswerTypeId, 2, conQuestionnaire.AnswerTypeId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.GridTitle, 30, conQuestionnaire.GridTitle);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.AnswerModeId, 4, conQuestionnaire.AnswerModeId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.DefaultValue, 50, conQuestionnaire.DefaultValue);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.DefaultSelectItem, 20, conQuestionnaire.DefaultSelectItem);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.LimitedResourceType, 100, conQuestionnaire.LimitedResourceType);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.ExamGradeId, 2, conQuestionnaire.ExamGradeId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.TextDirectId, 4, conQuestionnaire.TextDirectId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.UpdDate, 20, conQuestionnaire.UpdDate);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.UpdUser, 20, conQuestionnaire.UpdUser);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.Memo, 1000, conQuestionnaire.Memo);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionCode, 8000, conQuestionnaire.QuestionCode);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.DifficultyLevelId, 2, conQuestionnaire.DifficultyLevelId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.SectionTypeId, 8, conQuestionnaire.SectionTypeId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.KnowledgeGraphId, 10, conQuestionnaire.KnowledgeGraphId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionNameAdd, 500, conQuestionnaire.QuestionNameAdd);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CodeTab, 50, conQuestionnaire.CodeTab);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CodeTabCode, 50, conQuestionnaire.CodeTabCode);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CodeTabCondition, 200, conQuestionnaire.CodeTabCondition);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CodeTabName, 50, conQuestionnaire.CodeTabName);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.RelaEvent, 4000, conQuestionnaire.RelaEvent);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.LevelModeTypeId, 2, conQuestionnaire.LevelModeTypeId);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQuestionnaireEN.QuestionTypeId, 2, conQuestionnaire.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireEN.AnswerTypeId, 2, conQuestionnaire.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireEN.AnswerModeId, 4, conQuestionnaire.AnswerModeId);
 objQuestionnaireEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQuestionnaireEN objQuestionnaireEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionName, 500, conQuestionnaire.QuestionName);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionContent, 4000, conQuestionnaire.QuestionContent);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionMemo, 1000, conQuestionnaire.QuestionMemo);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionNo, 10, conQuestionnaire.QuestionNo);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.ParentQuestionId, 8, conQuestionnaire.ParentQuestionId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.ExamAnswer, 8000, conQuestionnaire.ExamAnswer);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CourseId, 8, conQuestionnaire.CourseId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CourseChapterId, 8, conQuestionnaire.CourseChapterId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionTypeId, 2, conQuestionnaire.QuestionTypeId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionTypeId4Course, 8, conQuestionnaire.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.AnswerTypeId, 2, conQuestionnaire.AnswerTypeId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.GridTitle, 30, conQuestionnaire.GridTitle);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.AnswerModeId, 4, conQuestionnaire.AnswerModeId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.DefaultValue, 50, conQuestionnaire.DefaultValue);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.DefaultSelectItem, 20, conQuestionnaire.DefaultSelectItem);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.LimitedResourceType, 100, conQuestionnaire.LimitedResourceType);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.ExamGradeId, 2, conQuestionnaire.ExamGradeId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.TextDirectId, 4, conQuestionnaire.TextDirectId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.UpdDate, 20, conQuestionnaire.UpdDate);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.UpdUser, 20, conQuestionnaire.UpdUser);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.Memo, 1000, conQuestionnaire.Memo);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionCode, 8000, conQuestionnaire.QuestionCode);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.DifficultyLevelId, 2, conQuestionnaire.DifficultyLevelId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.SectionTypeId, 8, conQuestionnaire.SectionTypeId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.KnowledgeGraphId, 10, conQuestionnaire.KnowledgeGraphId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionNameAdd, 500, conQuestionnaire.QuestionNameAdd);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CodeTab, 50, conQuestionnaire.CodeTab);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CodeTabCode, 50, conQuestionnaire.CodeTabCode);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CodeTabCondition, 200, conQuestionnaire.CodeTabCondition);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CodeTabName, 50, conQuestionnaire.CodeTabName);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.RelaEvent, 4000, conQuestionnaire.RelaEvent);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.LevelModeTypeId, 2, conQuestionnaire.LevelModeTypeId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQuestionnaireEN.QuestionTypeId, 2, conQuestionnaire.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireEN.AnswerTypeId, 2, conQuestionnaire.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireEN.AnswerModeId, 4, conQuestionnaire.AnswerModeId);
 objQuestionnaireEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQuestionnaireEN objQuestionnaireEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionName, 500, conQuestionnaire.QuestionName);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionContent, 4000, conQuestionnaire.QuestionContent);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionMemo, 1000, conQuestionnaire.QuestionMemo);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionNo, 10, conQuestionnaire.QuestionNo);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.ParentQuestionId, 8, conQuestionnaire.ParentQuestionId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.ExamAnswer, 8000, conQuestionnaire.ExamAnswer);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CourseId, 8, conQuestionnaire.CourseId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CourseChapterId, 8, conQuestionnaire.CourseChapterId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionTypeId, 2, conQuestionnaire.QuestionTypeId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionTypeId4Course, 8, conQuestionnaire.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.AnswerTypeId, 2, conQuestionnaire.AnswerTypeId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.GridTitle, 30, conQuestionnaire.GridTitle);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.AnswerModeId, 4, conQuestionnaire.AnswerModeId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.DefaultValue, 50, conQuestionnaire.DefaultValue);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.DefaultSelectItem, 20, conQuestionnaire.DefaultSelectItem);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.LimitedResourceType, 100, conQuestionnaire.LimitedResourceType);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.ExamGradeId, 2, conQuestionnaire.ExamGradeId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.TextDirectId, 4, conQuestionnaire.TextDirectId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.UpdDate, 20, conQuestionnaire.UpdDate);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.UpdUser, 20, conQuestionnaire.UpdUser);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.Memo, 1000, conQuestionnaire.Memo);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionCode, 8000, conQuestionnaire.QuestionCode);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.DifficultyLevelId, 2, conQuestionnaire.DifficultyLevelId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.SectionTypeId, 8, conQuestionnaire.SectionTypeId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.KnowledgeGraphId, 10, conQuestionnaire.KnowledgeGraphId);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.QuestionNameAdd, 500, conQuestionnaire.QuestionNameAdd);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CodeTab, 50, conQuestionnaire.CodeTab);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CodeTabCode, 50, conQuestionnaire.CodeTabCode);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CodeTabCondition, 200, conQuestionnaire.CodeTabCondition);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.CodeTabName, 50, conQuestionnaire.CodeTabName);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.RelaEvent, 4000, conQuestionnaire.RelaEvent);
clsCheckSql.CheckFieldLen(objQuestionnaireEN.LevelModeTypeId, 2, conQuestionnaire.LevelModeTypeId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.QuestionName, conQuestionnaire.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.QuestionContent, conQuestionnaire.QuestionContent);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.QuestionMemo, conQuestionnaire.QuestionMemo);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.QuestionNo, conQuestionnaire.QuestionNo);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.ParentQuestionId, conQuestionnaire.ParentQuestionId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.ExamAnswer, conQuestionnaire.ExamAnswer);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.CourseId, conQuestionnaire.CourseId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.CourseChapterId, conQuestionnaire.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.QuestionTypeId, conQuestionnaire.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.QuestionTypeId4Course, conQuestionnaire.QuestionTypeId4Course);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.AnswerTypeId, conQuestionnaire.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.GridTitle, conQuestionnaire.GridTitle);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.AnswerModeId, conQuestionnaire.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.DefaultValue, conQuestionnaire.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.DefaultSelectItem, conQuestionnaire.DefaultSelectItem);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.LimitedResourceType, conQuestionnaire.LimitedResourceType);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.ExamGradeId, conQuestionnaire.ExamGradeId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.TextDirectId, conQuestionnaire.TextDirectId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.UpdDate, conQuestionnaire.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.UpdUser, conQuestionnaire.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.Memo, conQuestionnaire.Memo);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.QuestionCode, conQuestionnaire.QuestionCode);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.DifficultyLevelId, conQuestionnaire.DifficultyLevelId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.SectionTypeId, conQuestionnaire.SectionTypeId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.KnowledgeGraphId, conQuestionnaire.KnowledgeGraphId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.QuestionNameAdd, conQuestionnaire.QuestionNameAdd);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.CodeTab, conQuestionnaire.CodeTab);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.CodeTabCode, conQuestionnaire.CodeTabCode);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.CodeTabCondition, conQuestionnaire.CodeTabCondition);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.CodeTabName, conQuestionnaire.CodeTabName);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.RelaEvent, conQuestionnaire.RelaEvent);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireEN.LevelModeTypeId, conQuestionnaire.LevelModeTypeId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQuestionnaireEN.QuestionTypeId, 2, conQuestionnaire.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireEN.AnswerTypeId, 2, conQuestionnaire.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireEN.AnswerModeId, 4, conQuestionnaire.AnswerModeId);
 objQuestionnaireEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetQuestionId()
{
//获取某学院所有专业信息
string strSQL = "select QuestionId, QuestionName from Questionnaire ";
 clsSpecSQLforSql mySql = clsQuestionnaireDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--Questionnaire(题目),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQuestionnaireEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQuestionnaireEN objQuestionnaireEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objQuestionnaireEN.QuestionId);
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
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
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
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
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
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQuestionnaireEN._CurrTabName);
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
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQuestionnaireEN._CurrTabName, strCondition);
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
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
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
 objSQL = clsQuestionnaireDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}