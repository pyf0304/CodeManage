
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaireDA
 表名:vQuestionnaire(01120019)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:31:04
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
 /// v题目(vQuestionnaire)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQuestionnaireDA : clsCommBase4DA
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
 return clsvQuestionnaireEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQuestionnaireEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionnaireEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQuestionnaireEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQuestionnaireEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQuestionnaireDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQuestionnaire(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQuestionnaireDA: GetDataTable_vQuestionnaire)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQuestionnaireDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQuestionnaireDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQuestionnaireDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQuestionnaireDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQuestionnaireDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQuestionnaire where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQuestionnaireDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQuestionnaire.* from vQuestionnaire Left Join {1} on {2} where {3} and vQuestionnaire.QuestionId not in (Select top {5} vQuestionnaire.QuestionId from vQuestionnaire Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire where {1} and QuestionId not in (Select top {2} QuestionId from vQuestionnaire where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire where {1} and QuestionId not in (Select top {3} QuestionId from vQuestionnaire where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQuestionnaireDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQuestionnaire.* from vQuestionnaire Left Join {1} on {2} where {3} and vQuestionnaire.QuestionId not in (Select top {5} vQuestionnaire.QuestionId from vQuestionnaire Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire where {1} and QuestionId not in (Select top {2} QuestionId from vQuestionnaire where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire where {1} and QuestionId not in (Select top {3} QuestionId from vQuestionnaire where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvQuestionnaireEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQuestionnaireDA:GetObjLst)", objException.Message));
}
List<clsvQuestionnaireEN> arrObjLst = new List<clsvQuestionnaireEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN();
try
{
objvQuestionnaireEN.QuestionId = TransNullToInt(objRow[convQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaireEN.QuestionIndex = objRow[convQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaireEN.QuestionName = objRow[convQuestionnaire.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaireEN.QuestionContent = objRow[convQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaireEN.QuestionMemo = objRow[convQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaireEN.QuestionNo = objRow[convQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaireEN.ParentQuestionId = objRow[convQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaireEN.ExamAnswer = objRow[convQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaireEN.CourseId = objRow[convQuestionnaire.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireEN.CourseCode = objRow[convQuestionnaire.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaireEN.CourseName = objRow[convQuestionnaire.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseName].ToString().Trim(); //课程名称
objvQuestionnaireEN.LevelNo = objRow[convQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objvQuestionnaireEN.CourseChapterId = objRow[convQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaireEN.CourseChapterName = objRow[convQuestionnaire.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaireEN.ChapterId = objRow[convQuestionnaire.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterId].ToString().Trim(); //章Id
objvQuestionnaireEN.SectionId = objRow[convQuestionnaire.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionId].ToString().Trim(); //节Id
objvQuestionnaireEN.ChapterName = objRow[convQuestionnaire.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterName].ToString().Trim(); //章名
objvQuestionnaireEN.SectionName = objRow[convQuestionnaire.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire.SectionName].ToString().Trim(); //节名
objvQuestionnaireEN.ChapterNameSim = objRow[convQuestionnaire.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaireEN.SectionNameSim = objRow[convQuestionnaire.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaireEN.ParentNodeId = objRow[convQuestionnaire.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaireEN.CourseChapterReferred = objRow[convQuestionnaire.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaireEN.ParentNodeName = objRow[convQuestionnaire.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaireEN.ParentNodeReferred = objRow[convQuestionnaire.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaireEN.QuestionTypeId = objRow[convQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireEN.QuestionTypeName = objRow[convQuestionnaire.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireEN.QuestionTypeId4Course = objRow[convQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaireEN.QuestionTypeName4Course = objRow[convQuestionnaire.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionnaireEN.AnswerTypeId = objRow[convQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaireEN.AnswerTypeName = objRow[convQuestionnaire.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaireEN.GridTitle = objRow[convQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaireEN.AnswerModeId = objRow[convQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaireEN.AnswerModeName = objRow[convQuestionnaire.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaireEN.QuestionScore = objRow[convQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaireEN.DefaultValue = objRow[convQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaireEN.DefaultSelectItem = objRow[convQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaireEN.IsShow = TransNullToBool(objRow[convQuestionnaire.IsShow].ToString().Trim()); //是否启用
objvQuestionnaireEN.IsCast = TransNullToBool(objRow[convQuestionnaire.IsCast].ToString().Trim()); //是否播放
objvQuestionnaireEN.LikeCount = objRow[convQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaireEN.AnswerAttLimitSize = objRow[convQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvQuestionnaireEN.LimitedResourceType = objRow[convQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[convQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objvQuestionnaireEN.IsEffective = TransNullToBool(objRow[convQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaireEN.IsCanInPaper = TransNullToBool(objRow[convQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaireEN.ExamGradeId = objRow[convQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaireEN.ExamGradeName = objRow[convQuestionnaire.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaireEN.TextDirectId = objRow[convQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaireEN.UpdDate = objRow[convQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaireEN.UpdUser = objRow[convQuestionnaire.UpdUser].ToString().Trim(); //修改人
objvQuestionnaireEN.Memo = objRow[convQuestionnaire.Memo] == DBNull.Value ? null : objRow[convQuestionnaire.Memo].ToString().Trim(); //备注
objvQuestionnaireEN.FirstIndent = TransNullToBool(objRow[convQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaireEN.CodeTab = objRow[convQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTab].ToString().Trim(); //代码表
objvQuestionnaireEN.CodeTabCode = objRow[convQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaireEN.CodeTabCondition = objRow[convQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaireEN.CodeTabName = objRow[convQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaireEN.CourseIdChapter = objRow[convQuestionnaire.CourseIdChapter] == DBNull.Value ? null : objRow[convQuestionnaire.CourseIdChapter].ToString().Trim(); //CourseId_Chapter
objvQuestionnaireEN.OptionNum = objRow[convQuestionnaire.OptionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.OptionNum].ToString().Trim()); //选项数
objvQuestionnaireEN.ChapterOrderNum = objRow[convQuestionnaire.ChapterOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaireEN.QuestionNameAdd = objRow[convQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaireEN.DifficultyLevelId = objRow[convQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objvQuestionnaireEN.FillInTextHeight = objRow[convQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaireEN.FillInTextWidth = objRow[convQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaireEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaireEN.IsJs = TransNullToBool(objRow[convQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objvQuestionnaireEN.IsMulti4FillInText = TransNullToBool(objRow[convQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaireEN.KnowledgeGraphId = objRow[convQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[convQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvQuestionnaireEN.MemoTextWidth = objRow[convQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaireEN.QuestionCode = objRow[convQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objvQuestionnaireEN.SectionTypeId = objRow[convQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objvQuestionnaireEN.CheckBoxLimitCount = objRow[convQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaireEN.RelaEvent = objRow[convQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQuestionnaireDA: GetObjLst)", objException.Message));
}
objvQuestionnaireEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQuestionnaireEN);
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
public List<clsvQuestionnaireEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQuestionnaireDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQuestionnaireEN> arrObjLst = new List<clsvQuestionnaireEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN();
try
{
objvQuestionnaireEN.QuestionId = TransNullToInt(objRow[convQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaireEN.QuestionIndex = objRow[convQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaireEN.QuestionName = objRow[convQuestionnaire.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaireEN.QuestionContent = objRow[convQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaireEN.QuestionMemo = objRow[convQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaireEN.QuestionNo = objRow[convQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaireEN.ParentQuestionId = objRow[convQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaireEN.ExamAnswer = objRow[convQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaireEN.CourseId = objRow[convQuestionnaire.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireEN.CourseCode = objRow[convQuestionnaire.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaireEN.CourseName = objRow[convQuestionnaire.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseName].ToString().Trim(); //课程名称
objvQuestionnaireEN.LevelNo = objRow[convQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objvQuestionnaireEN.CourseChapterId = objRow[convQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaireEN.CourseChapterName = objRow[convQuestionnaire.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaireEN.ChapterId = objRow[convQuestionnaire.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterId].ToString().Trim(); //章Id
objvQuestionnaireEN.SectionId = objRow[convQuestionnaire.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionId].ToString().Trim(); //节Id
objvQuestionnaireEN.ChapterName = objRow[convQuestionnaire.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterName].ToString().Trim(); //章名
objvQuestionnaireEN.SectionName = objRow[convQuestionnaire.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire.SectionName].ToString().Trim(); //节名
objvQuestionnaireEN.ChapterNameSim = objRow[convQuestionnaire.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaireEN.SectionNameSim = objRow[convQuestionnaire.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaireEN.ParentNodeId = objRow[convQuestionnaire.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaireEN.CourseChapterReferred = objRow[convQuestionnaire.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaireEN.ParentNodeName = objRow[convQuestionnaire.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaireEN.ParentNodeReferred = objRow[convQuestionnaire.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaireEN.QuestionTypeId = objRow[convQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireEN.QuestionTypeName = objRow[convQuestionnaire.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireEN.QuestionTypeId4Course = objRow[convQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaireEN.QuestionTypeName4Course = objRow[convQuestionnaire.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionnaireEN.AnswerTypeId = objRow[convQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaireEN.AnswerTypeName = objRow[convQuestionnaire.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaireEN.GridTitle = objRow[convQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaireEN.AnswerModeId = objRow[convQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaireEN.AnswerModeName = objRow[convQuestionnaire.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaireEN.QuestionScore = objRow[convQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaireEN.DefaultValue = objRow[convQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaireEN.DefaultSelectItem = objRow[convQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaireEN.IsShow = TransNullToBool(objRow[convQuestionnaire.IsShow].ToString().Trim()); //是否启用
objvQuestionnaireEN.IsCast = TransNullToBool(objRow[convQuestionnaire.IsCast].ToString().Trim()); //是否播放
objvQuestionnaireEN.LikeCount = objRow[convQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaireEN.AnswerAttLimitSize = objRow[convQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvQuestionnaireEN.LimitedResourceType = objRow[convQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[convQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objvQuestionnaireEN.IsEffective = TransNullToBool(objRow[convQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaireEN.IsCanInPaper = TransNullToBool(objRow[convQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaireEN.ExamGradeId = objRow[convQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaireEN.ExamGradeName = objRow[convQuestionnaire.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaireEN.TextDirectId = objRow[convQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaireEN.UpdDate = objRow[convQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaireEN.UpdUser = objRow[convQuestionnaire.UpdUser].ToString().Trim(); //修改人
objvQuestionnaireEN.Memo = objRow[convQuestionnaire.Memo] == DBNull.Value ? null : objRow[convQuestionnaire.Memo].ToString().Trim(); //备注
objvQuestionnaireEN.FirstIndent = TransNullToBool(objRow[convQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaireEN.CodeTab = objRow[convQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTab].ToString().Trim(); //代码表
objvQuestionnaireEN.CodeTabCode = objRow[convQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaireEN.CodeTabCondition = objRow[convQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaireEN.CodeTabName = objRow[convQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaireEN.CourseIdChapter = objRow[convQuestionnaire.CourseIdChapter] == DBNull.Value ? null : objRow[convQuestionnaire.CourseIdChapter].ToString().Trim(); //CourseId_Chapter
objvQuestionnaireEN.OptionNum = objRow[convQuestionnaire.OptionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.OptionNum].ToString().Trim()); //选项数
objvQuestionnaireEN.ChapterOrderNum = objRow[convQuestionnaire.ChapterOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaireEN.QuestionNameAdd = objRow[convQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaireEN.DifficultyLevelId = objRow[convQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objvQuestionnaireEN.FillInTextHeight = objRow[convQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaireEN.FillInTextWidth = objRow[convQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaireEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaireEN.IsJs = TransNullToBool(objRow[convQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objvQuestionnaireEN.IsMulti4FillInText = TransNullToBool(objRow[convQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaireEN.KnowledgeGraphId = objRow[convQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[convQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvQuestionnaireEN.MemoTextWidth = objRow[convQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaireEN.QuestionCode = objRow[convQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objvQuestionnaireEN.SectionTypeId = objRow[convQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objvQuestionnaireEN.CheckBoxLimitCount = objRow[convQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaireEN.RelaEvent = objRow[convQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQuestionnaireDA: GetObjLst)", objException.Message));
}
objvQuestionnaireEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQuestionnaireEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQuestionnaireEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQuestionnaire(ref clsvQuestionnaireEN objvQuestionnaireEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire where QuestionId = " + ""+ objvQuestionnaireEN.QuestionId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQuestionnaireEN.QuestionId = TransNullToInt(objDT.Rows[0][convQuestionnaire.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaireEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaireEN.QuestionName = objDT.Rows[0][convQuestionnaire.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionnaireEN.QuestionContent = objDT.Rows[0][convQuestionnaire.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvQuestionnaireEN.QuestionMemo = objDT.Rows[0][convQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQuestionnaireEN.QuestionNo = objDT.Rows[0][convQuestionnaire.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaireEN.ParentQuestionId = objDT.Rows[0][convQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaireEN.ExamAnswer = objDT.Rows[0][convQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案(字段类型:varchar,字段长度:8000,是否可空:True)
 objvQuestionnaireEN.CourseId = objDT.Rows[0][convQuestionnaire.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaireEN.CourseCode = objDT.Rows[0][convQuestionnaire.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaireEN.CourseName = objDT.Rows[0][convQuestionnaire.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaireEN.LevelNo = TransNullToInt(objDT.Rows[0][convQuestionnaire.LevelNo].ToString().Trim()); //学习关号2(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaireEN.CourseChapterId = objDT.Rows[0][convQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionnaireEN.CourseChapterName = objDT.Rows[0][convQuestionnaire.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvQuestionnaireEN.ChapterId = objDT.Rows[0][convQuestionnaire.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaireEN.SectionId = objDT.Rows[0][convQuestionnaire.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaireEN.ChapterName = objDT.Rows[0][convQuestionnaire.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaireEN.SectionName = objDT.Rows[0][convQuestionnaire.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaireEN.ChapterNameSim = objDT.Rows[0][convQuestionnaire.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaireEN.SectionNameSim = objDT.Rows[0][convQuestionnaire.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaireEN.ParentNodeId = objDT.Rows[0][convQuestionnaire.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvQuestionnaireEN.CourseChapterReferred = objDT.Rows[0][convQuestionnaire.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaireEN.ParentNodeName = objDT.Rows[0][convQuestionnaire.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaireEN.ParentNodeReferred = objDT.Rows[0][convQuestionnaire.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaireEN.QuestionTypeId = objDT.Rows[0][convQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaireEN.QuestionTypeName = objDT.Rows[0][convQuestionnaire.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaireEN.QuestionTypeId4Course = objDT.Rows[0][convQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionnaireEN.QuestionTypeName4Course = objDT.Rows[0][convQuestionnaire.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程(字段类型:varchar,字段长度:30,是否可空:False)
 objvQuestionnaireEN.AnswerTypeId = objDT.Rows[0][convQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaireEN.AnswerTypeName = objDT.Rows[0][convQuestionnaire.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaireEN.GridTitle = objDT.Rows[0][convQuestionnaire.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvQuestionnaireEN.AnswerModeId = objDT.Rows[0][convQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvQuestionnaireEN.AnswerModeName = objDT.Rows[0][convQuestionnaire.AnswerModeName].ToString().Trim(); //答案模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvQuestionnaireEN.QuestionScore = TransNullToFloat(objDT.Rows[0][convQuestionnaire.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objvQuestionnaireEN.DefaultValue = objDT.Rows[0][convQuestionnaire.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaireEN.DefaultSelectItem = objDT.Rows[0][convQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaireEN.IsShow = TransNullToBool(objDT.Rows[0][convQuestionnaire.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaireEN.IsCast = TransNullToBool(objDT.Rows[0][convQuestionnaire.IsCast].ToString().Trim()); //是否播放(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaireEN.LikeCount = TransNullToInt(objDT.Rows[0][convQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaireEN.AnswerAttLimitSize = TransNullToInt(objDT.Rows[0][convQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaireEN.LimitedResourceType = objDT.Rows[0][convQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaireEN.IsEffective = TransNullToBool(objDT.Rows[0][convQuestionnaire.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaireEN.IsCanInPaper = TransNullToBool(objDT.Rows[0][convQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaireEN.ExamGradeId = objDT.Rows[0][convQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaireEN.ExamGradeName = objDT.Rows[0][convQuestionnaire.ExamGradeName].ToString().Trim(); //题库等级名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaireEN.TextDirectId = objDT.Rows[0][convQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID(字段类型:char,字段长度:4,是否可空:True)
 objvQuestionnaireEN.UpdDate = objDT.Rows[0][convQuestionnaire.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaireEN.UpdUser = objDT.Rows[0][convQuestionnaire.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaireEN.Memo = objDT.Rows[0][convQuestionnaire.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQuestionnaireEN.FirstIndent = TransNullToBool(objDT.Rows[0][convQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaireEN.CodeTab = objDT.Rows[0][convQuestionnaire.CodeTab].ToString().Trim(); //代码表(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaireEN.CodeTabCode = objDT.Rows[0][convQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaireEN.CodeTabCondition = objDT.Rows[0][convQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件(字段类型:varchar,字段长度:200,是否可空:True)
 objvQuestionnaireEN.CodeTabName = objDT.Rows[0][convQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaireEN.CourseIdChapter = objDT.Rows[0][convQuestionnaire.CourseIdChapter].ToString().Trim(); //CourseId_Chapter(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaireEN.OptionNum = TransNullToInt(objDT.Rows[0][convQuestionnaire.OptionNum].ToString().Trim()); //选项数(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaireEN.ChapterOrderNum = TransNullToInt(objDT.Rows[0][convQuestionnaire.ChapterOrderNum].ToString().Trim()); //章排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaireEN.QuestionNameAdd = objDT.Rows[0][convQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionnaireEN.DifficultyLevelId = objDT.Rows[0][convQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaireEN.FillInTextHeight = TransNullToInt(objDT.Rows[0][convQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaireEN.FillInTextWidth = TransNullToInt(objDT.Rows[0][convQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaireEN.IsHaveAdditionalMemo = TransNullToBool(objDT.Rows[0][convQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaireEN.IsJs = TransNullToBool(objDT.Rows[0][convQuestionnaire.IsJs].ToString().Trim()); //是否是JS(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaireEN.IsMulti4FillInText = TransNullToBool(objDT.Rows[0][convQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaireEN.KnowledgeGraphId = objDT.Rows[0][convQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id(字段类型:char,字段长度:10,是否可空:True)
 objvQuestionnaireEN.MemoTextWidth = TransNullToInt(objDT.Rows[0][convQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaireEN.QuestionCode = objDT.Rows[0][convQuestionnaire.QuestionCode].ToString().Trim(); //html代码(字段类型:varchar,字段长度:8000,是否可空:True)
 objvQuestionnaireEN.SectionTypeId = objDT.Rows[0][convQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaireEN.CheckBoxLimitCount = TransNullToInt(objDT.Rows[0][convQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaireEN.RelaEvent = objDT.Rows[0][convQuestionnaire.RelaEvent].ToString().Trim(); //相关事件(字段类型:varchar,字段长度:4000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQuestionnaireDA: GetvQuestionnaire)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQuestionnaireEN GetObjByQuestionId(long lngQuestionId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire where QuestionId = " + ""+ lngQuestionId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN();
try
{
 objvQuestionnaireEN.QuestionId = Int32.Parse(objRow[convQuestionnaire.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaireEN.QuestionIndex = objRow[convQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaireEN.QuestionName = objRow[convQuestionnaire.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionnaireEN.QuestionContent = objRow[convQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvQuestionnaireEN.QuestionMemo = objRow[convQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQuestionnaireEN.QuestionNo = objRow[convQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaireEN.ParentQuestionId = objRow[convQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaireEN.ExamAnswer = objRow[convQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案(字段类型:varchar,字段长度:8000,是否可空:True)
 objvQuestionnaireEN.CourseId = objRow[convQuestionnaire.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaireEN.CourseCode = objRow[convQuestionnaire.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaireEN.CourseName = objRow[convQuestionnaire.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaireEN.LevelNo = objRow[convQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LevelNo].ToString().Trim()); //学习关号2(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaireEN.CourseChapterId = objRow[convQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionnaireEN.CourseChapterName = objRow[convQuestionnaire.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvQuestionnaireEN.ChapterId = objRow[convQuestionnaire.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaireEN.SectionId = objRow[convQuestionnaire.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaireEN.ChapterName = objRow[convQuestionnaire.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaireEN.SectionName = objRow[convQuestionnaire.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaireEN.ChapterNameSim = objRow[convQuestionnaire.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaireEN.SectionNameSim = objRow[convQuestionnaire.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaireEN.ParentNodeId = objRow[convQuestionnaire.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvQuestionnaireEN.CourseChapterReferred = objRow[convQuestionnaire.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaireEN.ParentNodeName = objRow[convQuestionnaire.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaireEN.ParentNodeReferred = objRow[convQuestionnaire.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaireEN.QuestionTypeId = objRow[convQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaireEN.QuestionTypeName = objRow[convQuestionnaire.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaireEN.QuestionTypeId4Course = objRow[convQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionnaireEN.QuestionTypeName4Course = objRow[convQuestionnaire.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程(字段类型:varchar,字段长度:30,是否可空:False)
 objvQuestionnaireEN.AnswerTypeId = objRow[convQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaireEN.AnswerTypeName = objRow[convQuestionnaire.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaireEN.GridTitle = objRow[convQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvQuestionnaireEN.AnswerModeId = objRow[convQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvQuestionnaireEN.AnswerModeName = objRow[convQuestionnaire.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeName].ToString().Trim(); //答案模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvQuestionnaireEN.QuestionScore = objRow[convQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objvQuestionnaireEN.DefaultValue = objRow[convQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaireEN.DefaultSelectItem = objRow[convQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCast].ToString().Trim()); //是否播放(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaireEN.LikeCount = objRow[convQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaireEN.AnswerAttLimitSize = objRow[convQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaireEN.LimitedResourceType = objRow[convQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[convQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaireEN.ExamGradeId = objRow[convQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaireEN.ExamGradeName = objRow[convQuestionnaire.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeName].ToString().Trim(); //题库等级名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaireEN.TextDirectId = objRow[convQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID(字段类型:char,字段长度:4,是否可空:True)
 objvQuestionnaireEN.UpdDate = objRow[convQuestionnaire.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaireEN.UpdUser = objRow[convQuestionnaire.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaireEN.Memo = objRow[convQuestionnaire.Memo] == DBNull.Value ? null : objRow[convQuestionnaire.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQuestionnaireEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaireEN.CodeTab = objRow[convQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTab].ToString().Trim(); //代码表(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaireEN.CodeTabCode = objRow[convQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaireEN.CodeTabCondition = objRow[convQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件(字段类型:varchar,字段长度:200,是否可空:True)
 objvQuestionnaireEN.CodeTabName = objRow[convQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaireEN.CourseIdChapter = objRow[convQuestionnaire.CourseIdChapter] == DBNull.Value ? null : objRow[convQuestionnaire.CourseIdChapter].ToString().Trim(); //CourseId_Chapter(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaireEN.OptionNum = objRow[convQuestionnaire.OptionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.OptionNum].ToString().Trim()); //选项数(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaireEN.ChapterOrderNum = objRow[convQuestionnaire.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.ChapterOrderNum].ToString().Trim()); //章排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaireEN.QuestionNameAdd = objRow[convQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionnaireEN.DifficultyLevelId = objRow[convQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaireEN.FillInTextHeight = objRow[convQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaireEN.FillInTextWidth = objRow[convQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaireEN.IsJs = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsJs].ToString().Trim()); //是否是JS(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaireEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaireEN.KnowledgeGraphId = objRow[convQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[convQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id(字段类型:char,字段长度:10,是否可空:True)
 objvQuestionnaireEN.MemoTextWidth = objRow[convQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaireEN.QuestionCode = objRow[convQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionCode].ToString().Trim(); //html代码(字段类型:varchar,字段长度:8000,是否可空:True)
 objvQuestionnaireEN.SectionTypeId = objRow[convQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaireEN.CheckBoxLimitCount = objRow[convQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaireEN.RelaEvent = objRow[convQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire.RelaEvent].ToString().Trim(); //相关事件(字段类型:varchar,字段长度:4000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQuestionnaireDA: GetObjByQuestionId)", objException.Message));
}
return objvQuestionnaireEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQuestionnaireEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQuestionnaireDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN()
{
QuestionId = TransNullToInt(objRow[convQuestionnaire.QuestionId].ToString().Trim()), //题目Id
QuestionIndex = objRow[convQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.QuestionIndex].ToString().Trim()), //题目序号
QuestionName = objRow[convQuestionnaire.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionName].ToString().Trim(), //题目名称
QuestionContent = objRow[convQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionContent].ToString().Trim(), //题目内容
QuestionMemo = objRow[convQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionMemo].ToString().Trim(), //题目说明
QuestionNo = objRow[convQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNo].ToString().Trim(), //题目编号
ParentQuestionId = objRow[convQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentQuestionId].ToString().Trim(), //父题目Id
ExamAnswer = objRow[convQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire.ExamAnswer].ToString().Trim(), //题目答案
CourseId = objRow[convQuestionnaire.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convQuestionnaire.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convQuestionnaire.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseName].ToString().Trim(), //课程名称
LevelNo = objRow[convQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.LevelNo].ToString().Trim()), //学习关号2
CourseChapterId = objRow[convQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convQuestionnaire.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterName].ToString().Trim(), //课程章节名称
ChapterId = objRow[convQuestionnaire.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterId].ToString().Trim(), //章Id
SectionId = objRow[convQuestionnaire.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionId].ToString().Trim(), //节Id
ChapterName = objRow[convQuestionnaire.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterName].ToString().Trim(), //章名
SectionName = objRow[convQuestionnaire.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire.SectionName].ToString().Trim(), //节名
ChapterNameSim = objRow[convQuestionnaire.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterNameSim].ToString().Trim(), //章名简称
SectionNameSim = objRow[convQuestionnaire.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.SectionNameSim].ToString().Trim(), //节名简称
ParentNodeId = objRow[convQuestionnaire.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeId].ToString().Trim(), //父节点编号
CourseChapterReferred = objRow[convQuestionnaire.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterReferred].ToString().Trim(), //节简称
ParentNodeName = objRow[convQuestionnaire.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeName].ToString().Trim(), //父节点名称
ParentNodeReferred = objRow[convQuestionnaire.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeReferred].ToString().Trim(), //章简称
QuestionTypeId = objRow[convQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionTypeName = objRow[convQuestionnaire.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName].ToString().Trim(), //题目类型名
QuestionTypeId4Course = objRow[convQuestionnaire.QuestionTypeId4Course].ToString().Trim(), //题目类型Id4课程
QuestionTypeName4Course = objRow[convQuestionnaire.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName4Course].ToString().Trim(), //题目类型名4课程
AnswerTypeId = objRow[convQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeId].ToString().Trim(), //答案类型ID
AnswerTypeName = objRow[convQuestionnaire.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeName].ToString().Trim(), //答案类型名
GridTitle = objRow[convQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire.GridTitle].ToString().Trim(), //表格标题
AnswerModeId = objRow[convQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeId].ToString().Trim(), //答案模式Id
AnswerModeName = objRow[convQuestionnaire.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeName].ToString().Trim(), //答案模式名称
QuestionScore = objRow[convQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionnaire.QuestionScore].ToString().Trim()), //题目得分
DefaultValue = objRow[convQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultValue].ToString().Trim(), //缺省值
DefaultSelectItem = objRow[convQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultSelectItem].ToString().Trim(), //默认选项
IsShow = TransNullToBool(objRow[convQuestionnaire.IsShow].ToString().Trim()), //是否启用
IsCast = TransNullToBool(objRow[convQuestionnaire.IsCast].ToString().Trim()), //是否播放
LikeCount = objRow[convQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionnaire.LikeCount].ToString().Trim()), //资源喜欢数量
AnswerAttLimitSize = objRow[convQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionnaire.AnswerAttLimitSize].ToString().Trim()), //回答附件限制大小
LimitedResourceType = objRow[convQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[convQuestionnaire.LimitedResourceType].ToString().Trim(), //限制资源类型
IsEffective = TransNullToBool(objRow[convQuestionnaire.IsEffective].ToString().Trim()), //是否有效
IsCanInPaper = TransNullToBool(objRow[convQuestionnaire.IsCanInPaper].ToString().Trim()), //是否可在Paper
ExamGradeId = objRow[convQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeId].ToString().Trim(), //题库等级ID
ExamGradeName = objRow[convQuestionnaire.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeName].ToString().Trim(), //题库等级名
TextDirectId = objRow[convQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire.TextDirectId].ToString().Trim(), //文本方向ID
UpdDate = objRow[convQuestionnaire.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convQuestionnaire.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convQuestionnaire.Memo] == DBNull.Value ? null : objRow[convQuestionnaire.Memo].ToString().Trim(), //备注
FirstIndent = TransNullToBool(objRow[convQuestionnaire.FirstIndent].ToString().Trim()), //首行缩进
CodeTab = objRow[convQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTab].ToString().Trim(), //代码表
CodeTabCode = objRow[convQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCode].ToString().Trim(), //CodeTab_Code
CodeTabCondition = objRow[convQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCondition].ToString().Trim(), //代码表_条件
CodeTabName = objRow[convQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabName].ToString().Trim(), //CodeTab_Name
CourseIdChapter = objRow[convQuestionnaire.CourseIdChapter] == DBNull.Value ? null : objRow[convQuestionnaire.CourseIdChapter].ToString().Trim(), //CourseId_Chapter
OptionNum = objRow[convQuestionnaire.OptionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.OptionNum].ToString().Trim()), //选项数
ChapterOrderNum = objRow[convQuestionnaire.ChapterOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.ChapterOrderNum].ToString().Trim()), //章排序号
QuestionNameAdd = objRow[convQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNameAdd].ToString().Trim(), //题目补充
DifficultyLevelId = objRow[convQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire.DifficultyLevelId].ToString().Trim(), //难度等级Id
FillInTextHeight = objRow[convQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.FillInTextHeight].ToString().Trim()), //填空框高度
FillInTextWidth = objRow[convQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.FillInTextWidth].ToString().Trim()), //填空框宽度
IsHaveAdditionalMemo = TransNullToBool(objRow[convQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()), //是否有附加说明
IsJs = TransNullToBool(objRow[convQuestionnaire.IsJs].ToString().Trim()), //是否是JS
IsMulti4FillInText = TransNullToBool(objRow[convQuestionnaire.IsMulti4FillInText].ToString().Trim()), //是否填空框多行
KnowledgeGraphId = objRow[convQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[convQuestionnaire.KnowledgeGraphId].ToString().Trim(), //知识点图Id
MemoTextWidth = objRow[convQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.MemoTextWidth].ToString().Trim()), //备注框宽度
QuestionCode = objRow[convQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionCode].ToString().Trim(), //html代码
SectionTypeId = objRow[convQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionTypeId].ToString().Trim(), //节点类型Id
CheckBoxLimitCount = objRow[convQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.CheckBoxLimitCount].ToString().Trim()), //复选框限制数
RelaEvent = objRow[convQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire.RelaEvent].ToString().Trim() //相关事件
};
objvQuestionnaireEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaireEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQuestionnaireDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQuestionnaireEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN();
try
{
objvQuestionnaireEN.QuestionId = TransNullToInt(objRow[convQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaireEN.QuestionIndex = objRow[convQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaireEN.QuestionName = objRow[convQuestionnaire.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaireEN.QuestionContent = objRow[convQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaireEN.QuestionMemo = objRow[convQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaireEN.QuestionNo = objRow[convQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaireEN.ParentQuestionId = objRow[convQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaireEN.ExamAnswer = objRow[convQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaireEN.CourseId = objRow[convQuestionnaire.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireEN.CourseCode = objRow[convQuestionnaire.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaireEN.CourseName = objRow[convQuestionnaire.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseName].ToString().Trim(); //课程名称
objvQuestionnaireEN.LevelNo = objRow[convQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objvQuestionnaireEN.CourseChapterId = objRow[convQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaireEN.CourseChapterName = objRow[convQuestionnaire.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaireEN.ChapterId = objRow[convQuestionnaire.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterId].ToString().Trim(); //章Id
objvQuestionnaireEN.SectionId = objRow[convQuestionnaire.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionId].ToString().Trim(); //节Id
objvQuestionnaireEN.ChapterName = objRow[convQuestionnaire.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterName].ToString().Trim(); //章名
objvQuestionnaireEN.SectionName = objRow[convQuestionnaire.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire.SectionName].ToString().Trim(); //节名
objvQuestionnaireEN.ChapterNameSim = objRow[convQuestionnaire.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaireEN.SectionNameSim = objRow[convQuestionnaire.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaireEN.ParentNodeId = objRow[convQuestionnaire.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaireEN.CourseChapterReferred = objRow[convQuestionnaire.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaireEN.ParentNodeName = objRow[convQuestionnaire.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaireEN.ParentNodeReferred = objRow[convQuestionnaire.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaireEN.QuestionTypeId = objRow[convQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireEN.QuestionTypeName = objRow[convQuestionnaire.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireEN.QuestionTypeId4Course = objRow[convQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaireEN.QuestionTypeName4Course = objRow[convQuestionnaire.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionnaireEN.AnswerTypeId = objRow[convQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaireEN.AnswerTypeName = objRow[convQuestionnaire.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaireEN.GridTitle = objRow[convQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaireEN.AnswerModeId = objRow[convQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaireEN.AnswerModeName = objRow[convQuestionnaire.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaireEN.QuestionScore = objRow[convQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaireEN.DefaultValue = objRow[convQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaireEN.DefaultSelectItem = objRow[convQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaireEN.IsShow = TransNullToBool(objRow[convQuestionnaire.IsShow].ToString().Trim()); //是否启用
objvQuestionnaireEN.IsCast = TransNullToBool(objRow[convQuestionnaire.IsCast].ToString().Trim()); //是否播放
objvQuestionnaireEN.LikeCount = objRow[convQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaireEN.AnswerAttLimitSize = objRow[convQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvQuestionnaireEN.LimitedResourceType = objRow[convQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[convQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objvQuestionnaireEN.IsEffective = TransNullToBool(objRow[convQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaireEN.IsCanInPaper = TransNullToBool(objRow[convQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaireEN.ExamGradeId = objRow[convQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaireEN.ExamGradeName = objRow[convQuestionnaire.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaireEN.TextDirectId = objRow[convQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaireEN.UpdDate = objRow[convQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaireEN.UpdUser = objRow[convQuestionnaire.UpdUser].ToString().Trim(); //修改人
objvQuestionnaireEN.Memo = objRow[convQuestionnaire.Memo] == DBNull.Value ? null : objRow[convQuestionnaire.Memo].ToString().Trim(); //备注
objvQuestionnaireEN.FirstIndent = TransNullToBool(objRow[convQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaireEN.CodeTab = objRow[convQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTab].ToString().Trim(); //代码表
objvQuestionnaireEN.CodeTabCode = objRow[convQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaireEN.CodeTabCondition = objRow[convQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaireEN.CodeTabName = objRow[convQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaireEN.CourseIdChapter = objRow[convQuestionnaire.CourseIdChapter] == DBNull.Value ? null : objRow[convQuestionnaire.CourseIdChapter].ToString().Trim(); //CourseId_Chapter
objvQuestionnaireEN.OptionNum = objRow[convQuestionnaire.OptionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.OptionNum].ToString().Trim()); //选项数
objvQuestionnaireEN.ChapterOrderNum = objRow[convQuestionnaire.ChapterOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaireEN.QuestionNameAdd = objRow[convQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaireEN.DifficultyLevelId = objRow[convQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objvQuestionnaireEN.FillInTextHeight = objRow[convQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaireEN.FillInTextWidth = objRow[convQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaireEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaireEN.IsJs = TransNullToBool(objRow[convQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objvQuestionnaireEN.IsMulti4FillInText = TransNullToBool(objRow[convQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaireEN.KnowledgeGraphId = objRow[convQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[convQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvQuestionnaireEN.MemoTextWidth = objRow[convQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaireEN.QuestionCode = objRow[convQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objvQuestionnaireEN.SectionTypeId = objRow[convQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objvQuestionnaireEN.CheckBoxLimitCount = objRow[convQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaireEN.RelaEvent = objRow[convQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQuestionnaireDA: GetObjByDataRowvQuestionnaire)", objException.Message));
}
objvQuestionnaireEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaireEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQuestionnaireEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQuestionnaireEN objvQuestionnaireEN = new clsvQuestionnaireEN();
try
{
objvQuestionnaireEN.QuestionId = TransNullToInt(objRow[convQuestionnaire.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaireEN.QuestionIndex = objRow[convQuestionnaire.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaireEN.QuestionName = objRow[convQuestionnaire.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaireEN.QuestionContent = objRow[convQuestionnaire.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaireEN.QuestionMemo = objRow[convQuestionnaire.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaireEN.QuestionNo = objRow[convQuestionnaire.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaireEN.ParentQuestionId = objRow[convQuestionnaire.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaireEN.ExamAnswer = objRow[convQuestionnaire.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaireEN.CourseId = objRow[convQuestionnaire.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireEN.CourseCode = objRow[convQuestionnaire.CourseCode] == DBNull.Value ? null : objRow[convQuestionnaire.CourseCode].ToString().Trim(); //课程代码
objvQuestionnaireEN.CourseName = objRow[convQuestionnaire.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseName].ToString().Trim(); //课程名称
objvQuestionnaireEN.LevelNo = objRow[convQuestionnaire.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.LevelNo].ToString().Trim()); //学习关号2
objvQuestionnaireEN.CourseChapterId = objRow[convQuestionnaire.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaireEN.CourseChapterName = objRow[convQuestionnaire.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaireEN.ChapterId = objRow[convQuestionnaire.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterId].ToString().Trim(); //章Id
objvQuestionnaireEN.SectionId = objRow[convQuestionnaire.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionId].ToString().Trim(); //节Id
objvQuestionnaireEN.ChapterName = objRow[convQuestionnaire.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterName].ToString().Trim(); //章名
objvQuestionnaireEN.SectionName = objRow[convQuestionnaire.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire.SectionName].ToString().Trim(); //节名
objvQuestionnaireEN.ChapterNameSim = objRow[convQuestionnaire.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaireEN.SectionNameSim = objRow[convQuestionnaire.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaireEN.ParentNodeId = objRow[convQuestionnaire.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaireEN.CourseChapterReferred = objRow[convQuestionnaire.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaireEN.ParentNodeName = objRow[convQuestionnaire.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaireEN.ParentNodeReferred = objRow[convQuestionnaire.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaireEN.QuestionTypeId = objRow[convQuestionnaire.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireEN.QuestionTypeName = objRow[convQuestionnaire.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireEN.QuestionTypeId4Course = objRow[convQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaireEN.QuestionTypeName4Course = objRow[convQuestionnaire.QuestionTypeName4Course] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objvQuestionnaireEN.AnswerTypeId = objRow[convQuestionnaire.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaireEN.AnswerTypeName = objRow[convQuestionnaire.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaireEN.GridTitle = objRow[convQuestionnaire.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaireEN.AnswerModeId = objRow[convQuestionnaire.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaireEN.AnswerModeName = objRow[convQuestionnaire.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaireEN.QuestionScore = objRow[convQuestionnaire.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionnaire.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaireEN.DefaultValue = objRow[convQuestionnaire.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaireEN.DefaultSelectItem = objRow[convQuestionnaire.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaireEN.IsShow = TransNullToBool(objRow[convQuestionnaire.IsShow].ToString().Trim()); //是否启用
objvQuestionnaireEN.IsCast = TransNullToBool(objRow[convQuestionnaire.IsCast].ToString().Trim()); //是否播放
objvQuestionnaireEN.LikeCount = objRow[convQuestionnaire.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaireEN.AnswerAttLimitSize = objRow[convQuestionnaire.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objvQuestionnaireEN.LimitedResourceType = objRow[convQuestionnaire.LimitedResourceType] == DBNull.Value ? null : objRow[convQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
objvQuestionnaireEN.IsEffective = TransNullToBool(objRow[convQuestionnaire.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaireEN.IsCanInPaper = TransNullToBool(objRow[convQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaireEN.ExamGradeId = objRow[convQuestionnaire.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaireEN.ExamGradeName = objRow[convQuestionnaire.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaireEN.TextDirectId = objRow[convQuestionnaire.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaireEN.UpdDate = objRow[convQuestionnaire.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaireEN.UpdUser = objRow[convQuestionnaire.UpdUser].ToString().Trim(); //修改人
objvQuestionnaireEN.Memo = objRow[convQuestionnaire.Memo] == DBNull.Value ? null : objRow[convQuestionnaire.Memo].ToString().Trim(); //备注
objvQuestionnaireEN.FirstIndent = TransNullToBool(objRow[convQuestionnaire.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaireEN.CodeTab = objRow[convQuestionnaire.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTab].ToString().Trim(); //代码表
objvQuestionnaireEN.CodeTabCode = objRow[convQuestionnaire.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaireEN.CodeTabCondition = objRow[convQuestionnaire.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaireEN.CodeTabName = objRow[convQuestionnaire.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaireEN.CourseIdChapter = objRow[convQuestionnaire.CourseIdChapter] == DBNull.Value ? null : objRow[convQuestionnaire.CourseIdChapter].ToString().Trim(); //CourseId_Chapter
objvQuestionnaireEN.OptionNum = objRow[convQuestionnaire.OptionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.OptionNum].ToString().Trim()); //选项数
objvQuestionnaireEN.ChapterOrderNum = objRow[convQuestionnaire.ChapterOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaireEN.QuestionNameAdd = objRow[convQuestionnaire.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaireEN.DifficultyLevelId = objRow[convQuestionnaire.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire.DifficultyLevelId].ToString().Trim(); //难度等级Id
objvQuestionnaireEN.FillInTextHeight = objRow[convQuestionnaire.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaireEN.FillInTextWidth = objRow[convQuestionnaire.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaireEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaireEN.IsJs = TransNullToBool(objRow[convQuestionnaire.IsJs].ToString().Trim()); //是否是JS
objvQuestionnaireEN.IsMulti4FillInText = TransNullToBool(objRow[convQuestionnaire.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaireEN.KnowledgeGraphId = objRow[convQuestionnaire.KnowledgeGraphId] == DBNull.Value ? null : objRow[convQuestionnaire.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvQuestionnaireEN.MemoTextWidth = objRow[convQuestionnaire.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaireEN.QuestionCode = objRow[convQuestionnaire.QuestionCode] == DBNull.Value ? null : objRow[convQuestionnaire.QuestionCode].ToString().Trim(); //html代码
objvQuestionnaireEN.SectionTypeId = objRow[convQuestionnaire.SectionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire.SectionTypeId].ToString().Trim(); //节点类型Id
objvQuestionnaireEN.CheckBoxLimitCount = objRow[convQuestionnaire.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaireEN.RelaEvent = objRow[convQuestionnaire.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire.RelaEvent].ToString().Trim(); //相关事件
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQuestionnaireDA: GetObjByDataRow)", objException.Message));
}
objvQuestionnaireEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaireEN;
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
objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQuestionnaireEN._CurrTabName, convQuestionnaire.QuestionId, 8, "");
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
objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQuestionnaireEN._CurrTabName, convQuestionnaire.QuestionId, 8, strPrefix);
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
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QuestionId from vQuestionnaire where " + strCondition;
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
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QuestionId from vQuestionnaire where " + strCondition;
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
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQuestionnaire", "QuestionId = " + ""+ lngQuestionId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQuestionnaireDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQuestionnaire", strCondition))
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
objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQuestionnaire");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQuestionnaireENS">源对象</param>
 /// <param name = "objvQuestionnaireENT">目标对象</param>
public void CopyTo(clsvQuestionnaireEN objvQuestionnaireENS, clsvQuestionnaireEN objvQuestionnaireENT)
{
objvQuestionnaireENT.QuestionId = objvQuestionnaireENS.QuestionId; //题目Id
objvQuestionnaireENT.QuestionIndex = objvQuestionnaireENS.QuestionIndex; //题目序号
objvQuestionnaireENT.QuestionName = objvQuestionnaireENS.QuestionName; //题目名称
objvQuestionnaireENT.QuestionContent = objvQuestionnaireENS.QuestionContent; //题目内容
objvQuestionnaireENT.QuestionMemo = objvQuestionnaireENS.QuestionMemo; //题目说明
objvQuestionnaireENT.QuestionNo = objvQuestionnaireENS.QuestionNo; //题目编号
objvQuestionnaireENT.ParentQuestionId = objvQuestionnaireENS.ParentQuestionId; //父题目Id
objvQuestionnaireENT.ExamAnswer = objvQuestionnaireENS.ExamAnswer; //题目答案
objvQuestionnaireENT.CourseId = objvQuestionnaireENS.CourseId; //课程Id
objvQuestionnaireENT.CourseCode = objvQuestionnaireENS.CourseCode; //课程代码
objvQuestionnaireENT.CourseName = objvQuestionnaireENS.CourseName; //课程名称
objvQuestionnaireENT.LevelNo = objvQuestionnaireENS.LevelNo; //学习关号2
objvQuestionnaireENT.CourseChapterId = objvQuestionnaireENS.CourseChapterId; //课程章节ID
objvQuestionnaireENT.CourseChapterName = objvQuestionnaireENS.CourseChapterName; //课程章节名称
objvQuestionnaireENT.ChapterId = objvQuestionnaireENS.ChapterId; //章Id
objvQuestionnaireENT.SectionId = objvQuestionnaireENS.SectionId; //节Id
objvQuestionnaireENT.ChapterName = objvQuestionnaireENS.ChapterName; //章名
objvQuestionnaireENT.SectionName = objvQuestionnaireENS.SectionName; //节名
objvQuestionnaireENT.ChapterNameSim = objvQuestionnaireENS.ChapterNameSim; //章名简称
objvQuestionnaireENT.SectionNameSim = objvQuestionnaireENS.SectionNameSim; //节名简称
objvQuestionnaireENT.ParentNodeId = objvQuestionnaireENS.ParentNodeId; //父节点编号
objvQuestionnaireENT.CourseChapterReferred = objvQuestionnaireENS.CourseChapterReferred; //节简称
objvQuestionnaireENT.ParentNodeName = objvQuestionnaireENS.ParentNodeName; //父节点名称
objvQuestionnaireENT.ParentNodeReferred = objvQuestionnaireENS.ParentNodeReferred; //章简称
objvQuestionnaireENT.QuestionTypeId = objvQuestionnaireENS.QuestionTypeId; //题目类型Id
objvQuestionnaireENT.QuestionTypeName = objvQuestionnaireENS.QuestionTypeName; //题目类型名
objvQuestionnaireENT.QuestionTypeId4Course = objvQuestionnaireENS.QuestionTypeId4Course; //题目类型Id4课程
objvQuestionnaireENT.QuestionTypeName4Course = objvQuestionnaireENS.QuestionTypeName4Course; //题目类型名4课程
objvQuestionnaireENT.AnswerTypeId = objvQuestionnaireENS.AnswerTypeId; //答案类型ID
objvQuestionnaireENT.AnswerTypeName = objvQuestionnaireENS.AnswerTypeName; //答案类型名
objvQuestionnaireENT.GridTitle = objvQuestionnaireENS.GridTitle; //表格标题
objvQuestionnaireENT.AnswerModeId = objvQuestionnaireENS.AnswerModeId; //答案模式Id
objvQuestionnaireENT.AnswerModeName = objvQuestionnaireENS.AnswerModeName; //答案模式名称
objvQuestionnaireENT.QuestionScore = objvQuestionnaireENS.QuestionScore; //题目得分
objvQuestionnaireENT.DefaultValue = objvQuestionnaireENS.DefaultValue; //缺省值
objvQuestionnaireENT.DefaultSelectItem = objvQuestionnaireENS.DefaultSelectItem; //默认选项
objvQuestionnaireENT.IsShow = objvQuestionnaireENS.IsShow; //是否启用
objvQuestionnaireENT.IsCast = objvQuestionnaireENS.IsCast; //是否播放
objvQuestionnaireENT.LikeCount = objvQuestionnaireENS.LikeCount; //资源喜欢数量
objvQuestionnaireENT.AnswerAttLimitSize = objvQuestionnaireENS.AnswerAttLimitSize; //回答附件限制大小
objvQuestionnaireENT.LimitedResourceType = objvQuestionnaireENS.LimitedResourceType; //限制资源类型
objvQuestionnaireENT.IsEffective = objvQuestionnaireENS.IsEffective; //是否有效
objvQuestionnaireENT.IsCanInPaper = objvQuestionnaireENS.IsCanInPaper; //是否可在Paper
objvQuestionnaireENT.ExamGradeId = objvQuestionnaireENS.ExamGradeId; //题库等级ID
objvQuestionnaireENT.ExamGradeName = objvQuestionnaireENS.ExamGradeName; //题库等级名
objvQuestionnaireENT.TextDirectId = objvQuestionnaireENS.TextDirectId; //文本方向ID
objvQuestionnaireENT.UpdDate = objvQuestionnaireENS.UpdDate; //修改日期
objvQuestionnaireENT.UpdUser = objvQuestionnaireENS.UpdUser; //修改人
objvQuestionnaireENT.Memo = objvQuestionnaireENS.Memo; //备注
objvQuestionnaireENT.FirstIndent = objvQuestionnaireENS.FirstIndent; //首行缩进
objvQuestionnaireENT.CodeTab = objvQuestionnaireENS.CodeTab; //代码表
objvQuestionnaireENT.CodeTabCode = objvQuestionnaireENS.CodeTabCode; //CodeTab_Code
objvQuestionnaireENT.CodeTabCondition = objvQuestionnaireENS.CodeTabCondition; //代码表_条件
objvQuestionnaireENT.CodeTabName = objvQuestionnaireENS.CodeTabName; //CodeTab_Name
objvQuestionnaireENT.CourseIdChapter = objvQuestionnaireENS.CourseIdChapter; //CourseId_Chapter
objvQuestionnaireENT.OptionNum = objvQuestionnaireENS.OptionNum; //选项数
objvQuestionnaireENT.ChapterOrderNum = objvQuestionnaireENS.ChapterOrderNum; //章排序号
objvQuestionnaireENT.QuestionNameAdd = objvQuestionnaireENS.QuestionNameAdd; //题目补充
objvQuestionnaireENT.DifficultyLevelId = objvQuestionnaireENS.DifficultyLevelId; //难度等级Id
objvQuestionnaireENT.FillInTextHeight = objvQuestionnaireENS.FillInTextHeight; //填空框高度
objvQuestionnaireENT.FillInTextWidth = objvQuestionnaireENS.FillInTextWidth; //填空框宽度
objvQuestionnaireENT.IsHaveAdditionalMemo = objvQuestionnaireENS.IsHaveAdditionalMemo; //是否有附加说明
objvQuestionnaireENT.IsJs = objvQuestionnaireENS.IsJs; //是否是JS
objvQuestionnaireENT.IsMulti4FillInText = objvQuestionnaireENS.IsMulti4FillInText; //是否填空框多行
objvQuestionnaireENT.KnowledgeGraphId = objvQuestionnaireENS.KnowledgeGraphId; //知识点图Id
objvQuestionnaireENT.MemoTextWidth = objvQuestionnaireENS.MemoTextWidth; //备注框宽度
objvQuestionnaireENT.QuestionCode = objvQuestionnaireENS.QuestionCode; //html代码
objvQuestionnaireENT.SectionTypeId = objvQuestionnaireENS.SectionTypeId; //节点类型Id
objvQuestionnaireENT.CheckBoxLimitCount = objvQuestionnaireENS.CheckBoxLimitCount; //复选框限制数
objvQuestionnaireENT.RelaEvent = objvQuestionnaireENS.RelaEvent; //相关事件
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQuestionnaireEN objvQuestionnaireEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.QuestionName, 500, convQuestionnaire.QuestionName);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.QuestionContent, 4000, convQuestionnaire.QuestionContent);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.QuestionMemo, 1000, convQuestionnaire.QuestionMemo);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.QuestionNo, 10, convQuestionnaire.QuestionNo);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.ParentQuestionId, 8, convQuestionnaire.ParentQuestionId);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.ExamAnswer, 8000, convQuestionnaire.ExamAnswer);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.CourseId, 8, convQuestionnaire.CourseId);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.CourseCode, 20, convQuestionnaire.CourseCode);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.CourseName, 100, convQuestionnaire.CourseName);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.CourseChapterId, 8, convQuestionnaire.CourseChapterId);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.CourseChapterName, 100, convQuestionnaire.CourseChapterName);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.ChapterId, 8, convQuestionnaire.ChapterId);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.SectionId, 8, convQuestionnaire.SectionId);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.ChapterName, 100, convQuestionnaire.ChapterName);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.SectionName, 100, convQuestionnaire.SectionName);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.ChapterNameSim, 10, convQuestionnaire.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.SectionNameSim, 10, convQuestionnaire.SectionNameSim);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.ParentNodeId, 8, convQuestionnaire.ParentNodeId);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.CourseChapterReferred, 10, convQuestionnaire.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.ParentNodeName, 100, convQuestionnaire.ParentNodeName);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.ParentNodeReferred, 10, convQuestionnaire.ParentNodeReferred);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.QuestionTypeId, 2, convQuestionnaire.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.QuestionTypeName, 20, convQuestionnaire.QuestionTypeName);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.QuestionTypeId4Course, 8, convQuestionnaire.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.QuestionTypeName4Course, 30, convQuestionnaire.QuestionTypeName4Course);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.AnswerTypeId, 2, convQuestionnaire.AnswerTypeId);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.AnswerTypeName, 50, convQuestionnaire.AnswerTypeName);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.GridTitle, 30, convQuestionnaire.GridTitle);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.AnswerModeId, 4, convQuestionnaire.AnswerModeId);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.AnswerModeName, 30, convQuestionnaire.AnswerModeName);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.DefaultValue, 50, convQuestionnaire.DefaultValue);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.DefaultSelectItem, 20, convQuestionnaire.DefaultSelectItem);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.LimitedResourceType, 100, convQuestionnaire.LimitedResourceType);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.ExamGradeId, 2, convQuestionnaire.ExamGradeId);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.ExamGradeName, 50, convQuestionnaire.ExamGradeName);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.TextDirectId, 4, convQuestionnaire.TextDirectId);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.UpdDate, 20, convQuestionnaire.UpdDate);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.UpdUser, 20, convQuestionnaire.UpdUser);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.Memo, 1000, convQuestionnaire.Memo);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.CodeTab, 50, convQuestionnaire.CodeTab);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.CodeTabCode, 50, convQuestionnaire.CodeTabCode);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.CodeTabCondition, 200, convQuestionnaire.CodeTabCondition);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.CodeTabName, 50, convQuestionnaire.CodeTabName);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.CourseIdChapter, 8, convQuestionnaire.CourseIdChapter);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.QuestionNameAdd, 500, convQuestionnaire.QuestionNameAdd);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.DifficultyLevelId, 2, convQuestionnaire.DifficultyLevelId);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.KnowledgeGraphId, 10, convQuestionnaire.KnowledgeGraphId);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.QuestionCode, 8000, convQuestionnaire.QuestionCode);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.SectionTypeId, 8, convQuestionnaire.SectionTypeId);
clsCheckSql.CheckFieldLen(objvQuestionnaireEN.RelaEvent, 4000, convQuestionnaire.RelaEvent);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.QuestionName, convQuestionnaire.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.QuestionContent, convQuestionnaire.QuestionContent);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.QuestionMemo, convQuestionnaire.QuestionMemo);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.QuestionNo, convQuestionnaire.QuestionNo);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.ParentQuestionId, convQuestionnaire.ParentQuestionId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.ExamAnswer, convQuestionnaire.ExamAnswer);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.CourseId, convQuestionnaire.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.CourseCode, convQuestionnaire.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.CourseName, convQuestionnaire.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.CourseChapterId, convQuestionnaire.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.CourseChapterName, convQuestionnaire.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.ChapterId, convQuestionnaire.ChapterId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.SectionId, convQuestionnaire.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.ChapterName, convQuestionnaire.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.SectionName, convQuestionnaire.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.ChapterNameSim, convQuestionnaire.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.SectionNameSim, convQuestionnaire.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.ParentNodeId, convQuestionnaire.ParentNodeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.CourseChapterReferred, convQuestionnaire.CourseChapterReferred);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.ParentNodeName, convQuestionnaire.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.ParentNodeReferred, convQuestionnaire.ParentNodeReferred);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.QuestionTypeId, convQuestionnaire.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.QuestionTypeName, convQuestionnaire.QuestionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.QuestionTypeId4Course, convQuestionnaire.QuestionTypeId4Course);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.QuestionTypeName4Course, convQuestionnaire.QuestionTypeName4Course);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.AnswerTypeId, convQuestionnaire.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.AnswerTypeName, convQuestionnaire.AnswerTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.GridTitle, convQuestionnaire.GridTitle);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.AnswerModeId, convQuestionnaire.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.AnswerModeName, convQuestionnaire.AnswerModeName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.DefaultValue, convQuestionnaire.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.DefaultSelectItem, convQuestionnaire.DefaultSelectItem);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.LimitedResourceType, convQuestionnaire.LimitedResourceType);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.ExamGradeId, convQuestionnaire.ExamGradeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.ExamGradeName, convQuestionnaire.ExamGradeName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.TextDirectId, convQuestionnaire.TextDirectId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.UpdDate, convQuestionnaire.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.UpdUser, convQuestionnaire.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.Memo, convQuestionnaire.Memo);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.CodeTab, convQuestionnaire.CodeTab);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.CodeTabCode, convQuestionnaire.CodeTabCode);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.CodeTabCondition, convQuestionnaire.CodeTabCondition);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.CodeTabName, convQuestionnaire.CodeTabName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.CourseIdChapter, convQuestionnaire.CourseIdChapter);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.QuestionNameAdd, convQuestionnaire.QuestionNameAdd);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.DifficultyLevelId, convQuestionnaire.DifficultyLevelId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.KnowledgeGraphId, convQuestionnaire.KnowledgeGraphId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.QuestionCode, convQuestionnaire.QuestionCode);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.SectionTypeId, convQuestionnaire.SectionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaireEN.RelaEvent, convQuestionnaire.RelaEvent);
//检查外键字段长度
 objvQuestionnaireEN._IsCheckProperty = true;
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
string strSQL = "select QuestionId, QuestionName from vQuestionnaire ";
 clsSpecSQLforSql mySql = clsvQuestionnaireDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQuestionnaireEN._CurrTabName);
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
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQuestionnaireEN._CurrTabName, strCondition);
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
 objSQL = clsvQuestionnaireDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}