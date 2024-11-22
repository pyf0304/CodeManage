
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire_KnowledgeDA
 表名:vQuestionnaire_Knowledge(01120143)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:29:17
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
 /// v题目表_知识点(vQuestionnaire_Knowledge)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQuestionnaire_KnowledgeDA : clsCommBase4DA
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
 return clsvQuestionnaire_KnowledgeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQuestionnaire_KnowledgeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionnaire_KnowledgeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQuestionnaire_KnowledgeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQuestionnaire_KnowledgeEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQuestionnaire_KnowledgeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Knowledge where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQuestionnaire_Knowledge(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQuestionnaire_KnowledgeDA: GetDataTable_vQuestionnaire_Knowledge)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Knowledge where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQuestionnaire_KnowledgeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQuestionnaire_KnowledgeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Knowledge where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQuestionnaire_KnowledgeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQuestionnaire_KnowledgeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Knowledge where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Knowledge where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQuestionnaire_KnowledgeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Knowledge where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQuestionnaire_KnowledgeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQuestionnaire_Knowledge.* from vQuestionnaire_Knowledge Left Join {1} on {2} where {3} and vQuestionnaire_Knowledge.QuestionId not in (Select top {5} vQuestionnaire_Knowledge.QuestionId from vQuestionnaire_Knowledge Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Knowledge where {1} and QuestionId not in (Select top {2} QuestionId from vQuestionnaire_Knowledge where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Knowledge where {1} and QuestionId not in (Select top {3} QuestionId from vQuestionnaire_Knowledge where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQuestionnaire_KnowledgeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQuestionnaire_Knowledge.* from vQuestionnaire_Knowledge Left Join {1} on {2} where {3} and vQuestionnaire_Knowledge.QuestionId not in (Select top {5} vQuestionnaire_Knowledge.QuestionId from vQuestionnaire_Knowledge Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Knowledge where {1} and QuestionId not in (Select top {2} QuestionId from vQuestionnaire_Knowledge where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Knowledge where {1} and QuestionId not in (Select top {3} QuestionId from vQuestionnaire_Knowledge where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvQuestionnaire_KnowledgeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQuestionnaire_KnowledgeDA:GetObjLst)", objException.Message));
}
List<clsvQuestionnaire_KnowledgeEN> arrObjLst = new List<clsvQuestionnaire_KnowledgeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Knowledge where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN();
try
{
objvQuestionnaire_KnowledgeEN.QuestionId = TransNullToInt(objRow[convQuestionnaire_Knowledge.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_KnowledgeEN.QuestionIndex = objRow[convQuestionnaire_Knowledge.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_KnowledgeEN.QuestionName = objRow[convQuestionnaire_Knowledge.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_KnowledgeEN.QuestionContent = objRow[convQuestionnaire_Knowledge.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaire_KnowledgeEN.QuestionMemo = objRow[convQuestionnaire_Knowledge.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaire_KnowledgeEN.QuestionNo = objRow[convQuestionnaire_Knowledge.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_KnowledgeEN.ExamAnswer = objRow[convQuestionnaire_Knowledge.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaire_KnowledgeEN.CourseId = objRow[convQuestionnaire_Knowledge.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_KnowledgeEN.CourseName = objRow[convQuestionnaire_Knowledge.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire_KnowledgeEN.CourseChapterId = objRow[convQuestionnaire_Knowledge.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_KnowledgeEN.CourseChapterName = objRow[convQuestionnaire_Knowledge.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaire_KnowledgeEN.ChapterId = objRow[convQuestionnaire_Knowledge.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_KnowledgeEN.SectionId = objRow[convQuestionnaire_Knowledge.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_KnowledgeEN.ChapterName = objRow[convQuestionnaire_Knowledge.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_KnowledgeEN.SectionName = objRow[convQuestionnaire_Knowledge.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionName].ToString().Trim(); //节名
objvQuestionnaire_KnowledgeEN.ChapterNameSim = objRow[convQuestionnaire_Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_KnowledgeEN.SectionNameSim = objRow[convQuestionnaire_Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_KnowledgeEN.ParentNodeId = objRow[convQuestionnaire_Knowledge.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire_KnowledgeEN.CourseChapterReferred = objRow[convQuestionnaire_Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaire_KnowledgeEN.ParentNodeName = objRow[convQuestionnaire_Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaire_KnowledgeEN.ParentNodeReferred = objRow[convQuestionnaire_Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaire_KnowledgeEN.QuestionTypeId = objRow[convQuestionnaire_Knowledge.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_KnowledgeEN.QuestionTypeName = objRow[convQuestionnaire_Knowledge.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire_KnowledgeEN.ExamGradeId = objRow[convQuestionnaire_Knowledge.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire_KnowledgeEN.ExamGradeName = objRow[convQuestionnaire_Knowledge.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire_KnowledgeEN.AnswerTypeId = objRow[convQuestionnaire_Knowledge.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_KnowledgeEN.AnswerTypeName = objRow[convQuestionnaire_Knowledge.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaire_KnowledgeEN.GridTitle = objRow[convQuestionnaire_Knowledge.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_KnowledgeEN.AnswerModeId = objRow[convQuestionnaire_Knowledge.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_KnowledgeEN.AnswerModeName = objRow[convQuestionnaire_Knowledge.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = objRow[convQuestionnaire_Knowledge.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = objRow[convQuestionnaire_Knowledge.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaire_KnowledgeEN.QuestionScore = objRow[convQuestionnaire_Knowledge.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionnaire_Knowledge.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire_KnowledgeEN.QuestionNameAdd = objRow[convQuestionnaire_Knowledge.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaire_KnowledgeEN.DefaultValue = objRow[convQuestionnaire_Knowledge.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaire_KnowledgeEN.TextDirectId = objRow[convQuestionnaire_Knowledge.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaire_KnowledgeEN.TextDirectName = objRow[convQuestionnaire_Knowledge.TextDirectName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectName].ToString().Trim(); //文本方向名
objvQuestionnaire_KnowledgeEN.FillInTextWidth = objRow[convQuestionnaire_Knowledge.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaire_KnowledgeEN.MemoTextWidth = objRow[convQuestionnaire_Knowledge.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaire_KnowledgeEN.CodeTab = objRow[convQuestionnaire_Knowledge.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTab].ToString().Trim(); //代码表
objvQuestionnaire_KnowledgeEN.CodeTabCode = objRow[convQuestionnaire_Knowledge.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaire_KnowledgeEN.CodeTabName = objRow[convQuestionnaire_Knowledge.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaire_KnowledgeEN.CodeTabCondition = objRow[convQuestionnaire_Knowledge.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaire_KnowledgeEN.RelaEvent = objRow[convQuestionnaire_Knowledge.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RelaEvent].ToString().Trim(); //相关事件
objvQuestionnaire_KnowledgeEN.FirstIndent = TransNullToBool(objRow[convQuestionnaire_Knowledge.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaire_KnowledgeEN.DefaultSelectItem = objRow[convQuestionnaire_Knowledge.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objvQuestionnaire_KnowledgeEN.FillInTextHeight = objRow[convQuestionnaire_Knowledge.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaire_KnowledgeEN.RoleId = objRow[convQuestionnaire_Knowledge.RoleId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleId].ToString().Trim(); //角色Id
objvQuestionnaire_KnowledgeEN.RoleName = objRow[convQuestionnaire_Knowledge.RoleName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleName].ToString().Trim(); //角色名
objvQuestionnaire_KnowledgeEN.IsShow = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_KnowledgeEN.IsCast = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsCast].ToString().Trim()); //是否播放
objvQuestionnaire_KnowledgeEN.LikeCount = objRow[convQuestionnaire_Knowledge.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaire_KnowledgeEN.IsEffective = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaire_KnowledgeEN.IsCanInPaper = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaire_KnowledgeEN.UpdDate = objRow[convQuestionnaire_Knowledge.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire_KnowledgeEN.UpdUser = objRow[convQuestionnaire_Knowledge.UpdUser].ToString().Trim(); //修改人
objvQuestionnaire_KnowledgeEN.Memo = objRow[convQuestionnaire_Knowledge.Memo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.Memo].ToString().Trim(); //备注
objvQuestionnaire_KnowledgeEN.KnowledgeNum = objRow[convQuestionnaire_Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
objvQuestionnaire_KnowledgeEN.AnswerNum = objRow[convQuestionnaire_Knowledge.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.AnswerNum].ToString().Trim()); //答案数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQuestionnaire_KnowledgeDA: GetObjLst)", objException.Message));
}
objvQuestionnaire_KnowledgeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQuestionnaire_KnowledgeEN);
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
public List<clsvQuestionnaire_KnowledgeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQuestionnaire_KnowledgeDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQuestionnaire_KnowledgeEN> arrObjLst = new List<clsvQuestionnaire_KnowledgeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN();
try
{
objvQuestionnaire_KnowledgeEN.QuestionId = TransNullToInt(objRow[convQuestionnaire_Knowledge.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_KnowledgeEN.QuestionIndex = objRow[convQuestionnaire_Knowledge.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_KnowledgeEN.QuestionName = objRow[convQuestionnaire_Knowledge.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_KnowledgeEN.QuestionContent = objRow[convQuestionnaire_Knowledge.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaire_KnowledgeEN.QuestionMemo = objRow[convQuestionnaire_Knowledge.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaire_KnowledgeEN.QuestionNo = objRow[convQuestionnaire_Knowledge.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_KnowledgeEN.ExamAnswer = objRow[convQuestionnaire_Knowledge.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaire_KnowledgeEN.CourseId = objRow[convQuestionnaire_Knowledge.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_KnowledgeEN.CourseName = objRow[convQuestionnaire_Knowledge.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire_KnowledgeEN.CourseChapterId = objRow[convQuestionnaire_Knowledge.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_KnowledgeEN.CourseChapterName = objRow[convQuestionnaire_Knowledge.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaire_KnowledgeEN.ChapterId = objRow[convQuestionnaire_Knowledge.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_KnowledgeEN.SectionId = objRow[convQuestionnaire_Knowledge.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_KnowledgeEN.ChapterName = objRow[convQuestionnaire_Knowledge.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_KnowledgeEN.SectionName = objRow[convQuestionnaire_Knowledge.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionName].ToString().Trim(); //节名
objvQuestionnaire_KnowledgeEN.ChapterNameSim = objRow[convQuestionnaire_Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_KnowledgeEN.SectionNameSim = objRow[convQuestionnaire_Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_KnowledgeEN.ParentNodeId = objRow[convQuestionnaire_Knowledge.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire_KnowledgeEN.CourseChapterReferred = objRow[convQuestionnaire_Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaire_KnowledgeEN.ParentNodeName = objRow[convQuestionnaire_Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaire_KnowledgeEN.ParentNodeReferred = objRow[convQuestionnaire_Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaire_KnowledgeEN.QuestionTypeId = objRow[convQuestionnaire_Knowledge.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_KnowledgeEN.QuestionTypeName = objRow[convQuestionnaire_Knowledge.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire_KnowledgeEN.ExamGradeId = objRow[convQuestionnaire_Knowledge.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire_KnowledgeEN.ExamGradeName = objRow[convQuestionnaire_Knowledge.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire_KnowledgeEN.AnswerTypeId = objRow[convQuestionnaire_Knowledge.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_KnowledgeEN.AnswerTypeName = objRow[convQuestionnaire_Knowledge.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaire_KnowledgeEN.GridTitle = objRow[convQuestionnaire_Knowledge.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_KnowledgeEN.AnswerModeId = objRow[convQuestionnaire_Knowledge.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_KnowledgeEN.AnswerModeName = objRow[convQuestionnaire_Knowledge.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = objRow[convQuestionnaire_Knowledge.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = objRow[convQuestionnaire_Knowledge.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaire_KnowledgeEN.QuestionScore = objRow[convQuestionnaire_Knowledge.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionnaire_Knowledge.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire_KnowledgeEN.QuestionNameAdd = objRow[convQuestionnaire_Knowledge.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaire_KnowledgeEN.DefaultValue = objRow[convQuestionnaire_Knowledge.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaire_KnowledgeEN.TextDirectId = objRow[convQuestionnaire_Knowledge.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaire_KnowledgeEN.TextDirectName = objRow[convQuestionnaire_Knowledge.TextDirectName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectName].ToString().Trim(); //文本方向名
objvQuestionnaire_KnowledgeEN.FillInTextWidth = objRow[convQuestionnaire_Knowledge.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaire_KnowledgeEN.MemoTextWidth = objRow[convQuestionnaire_Knowledge.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaire_KnowledgeEN.CodeTab = objRow[convQuestionnaire_Knowledge.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTab].ToString().Trim(); //代码表
objvQuestionnaire_KnowledgeEN.CodeTabCode = objRow[convQuestionnaire_Knowledge.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaire_KnowledgeEN.CodeTabName = objRow[convQuestionnaire_Knowledge.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaire_KnowledgeEN.CodeTabCondition = objRow[convQuestionnaire_Knowledge.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaire_KnowledgeEN.RelaEvent = objRow[convQuestionnaire_Knowledge.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RelaEvent].ToString().Trim(); //相关事件
objvQuestionnaire_KnowledgeEN.FirstIndent = TransNullToBool(objRow[convQuestionnaire_Knowledge.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaire_KnowledgeEN.DefaultSelectItem = objRow[convQuestionnaire_Knowledge.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objvQuestionnaire_KnowledgeEN.FillInTextHeight = objRow[convQuestionnaire_Knowledge.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaire_KnowledgeEN.RoleId = objRow[convQuestionnaire_Knowledge.RoleId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleId].ToString().Trim(); //角色Id
objvQuestionnaire_KnowledgeEN.RoleName = objRow[convQuestionnaire_Knowledge.RoleName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleName].ToString().Trim(); //角色名
objvQuestionnaire_KnowledgeEN.IsShow = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_KnowledgeEN.IsCast = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsCast].ToString().Trim()); //是否播放
objvQuestionnaire_KnowledgeEN.LikeCount = objRow[convQuestionnaire_Knowledge.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaire_KnowledgeEN.IsEffective = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaire_KnowledgeEN.IsCanInPaper = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaire_KnowledgeEN.UpdDate = objRow[convQuestionnaire_Knowledge.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire_KnowledgeEN.UpdUser = objRow[convQuestionnaire_Knowledge.UpdUser].ToString().Trim(); //修改人
objvQuestionnaire_KnowledgeEN.Memo = objRow[convQuestionnaire_Knowledge.Memo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.Memo].ToString().Trim(); //备注
objvQuestionnaire_KnowledgeEN.KnowledgeNum = objRow[convQuestionnaire_Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
objvQuestionnaire_KnowledgeEN.AnswerNum = objRow[convQuestionnaire_Knowledge.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.AnswerNum].ToString().Trim()); //答案数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQuestionnaire_KnowledgeDA: GetObjLst)", objException.Message));
}
objvQuestionnaire_KnowledgeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQuestionnaire_KnowledgeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQuestionnaire_Knowledge(ref clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Knowledge where QuestionId = " + ""+ objvQuestionnaire_KnowledgeEN.QuestionId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQuestionnaire_KnowledgeEN.QuestionId = TransNullToInt(objDT.Rows[0][convQuestionnaire_Knowledge.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convQuestionnaire_Knowledge.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionName = objDT.Rows[0][convQuestionnaire_Knowledge.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionContent = objDT.Rows[0][convQuestionnaire_Knowledge.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionMemo = objDT.Rows[0][convQuestionnaire_Knowledge.QuestionMemo].ToString().Trim(); //题目说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionNo = objDT.Rows[0][convQuestionnaire_Knowledge.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire_KnowledgeEN.ExamAnswer = objDT.Rows[0][convQuestionnaire_Knowledge.ExamAnswer].ToString().Trim(); //题目答案(字段类型:varchar,字段长度:8000,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CourseId = objDT.Rows[0][convQuestionnaire_Knowledge.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CourseName = objDT.Rows[0][convQuestionnaire_Knowledge.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CourseChapterId = objDT.Rows[0][convQuestionnaire_Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionnaire_KnowledgeEN.CourseChapterName = objDT.Rows[0][convQuestionnaire_Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvQuestionnaire_KnowledgeEN.ChapterId = objDT.Rows[0][convQuestionnaire_Knowledge.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire_KnowledgeEN.SectionId = objDT.Rows[0][convQuestionnaire_Knowledge.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire_KnowledgeEN.ChapterName = objDT.Rows[0][convQuestionnaire_Knowledge.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire_KnowledgeEN.SectionName = objDT.Rows[0][convQuestionnaire_Knowledge.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire_KnowledgeEN.ChapterNameSim = objDT.Rows[0][convQuestionnaire_Knowledge.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire_KnowledgeEN.SectionNameSim = objDT.Rows[0][convQuestionnaire_Knowledge.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire_KnowledgeEN.ParentNodeId = objDT.Rows[0][convQuestionnaire_Knowledge.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CourseChapterReferred = objDT.Rows[0][convQuestionnaire_Knowledge.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire_KnowledgeEN.ParentNodeName = objDT.Rows[0][convQuestionnaire_Knowledge.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire_KnowledgeEN.ParentNodeReferred = objDT.Rows[0][convQuestionnaire_Knowledge.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionTypeId = objDT.Rows[0][convQuestionnaire_Knowledge.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionTypeName = objDT.Rows[0][convQuestionnaire_Knowledge.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaire_KnowledgeEN.ExamGradeId = objDT.Rows[0][convQuestionnaire_Knowledge.ExamGradeId].ToString().Trim(); //题库等级ID(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire_KnowledgeEN.ExamGradeName = objDT.Rows[0][convQuestionnaire_Knowledge.ExamGradeName].ToString().Trim(); //题库等级名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaire_KnowledgeEN.AnswerTypeId = objDT.Rows[0][convQuestionnaire_Knowledge.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire_KnowledgeEN.AnswerTypeName = objDT.Rows[0][convQuestionnaire_Knowledge.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaire_KnowledgeEN.GridTitle = objDT.Rows[0][convQuestionnaire_Knowledge.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvQuestionnaire_KnowledgeEN.AnswerModeId = objDT.Rows[0][convQuestionnaire_Knowledge.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.AnswerModeName = objDT.Rows[0][convQuestionnaire_Knowledge.AnswerModeName].ToString().Trim(); //答案模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = TransNullToBool(objDT.Rows[0][convQuestionnaire_Knowledge.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = objDT.Rows[0][convQuestionnaire_Knowledge.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = objDT.Rows[0][convQuestionnaire_Knowledge.QuestionnaireSetName].ToString().Trim(); //问卷集名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionScore = TransNullToFloat(objDT.Rows[0][convQuestionnaire_Knowledge.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionNameAdd = objDT.Rows[0][convQuestionnaire_Knowledge.QuestionNameAdd].ToString().Trim(); //题目补充(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionnaire_KnowledgeEN.DefaultValue = objDT.Rows[0][convQuestionnaire_Knowledge.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaire_KnowledgeEN.TextDirectId = objDT.Rows[0][convQuestionnaire_Knowledge.TextDirectId].ToString().Trim(); //文本方向ID(字段类型:char,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.TextDirectName = objDT.Rows[0][convQuestionnaire_Knowledge.TextDirectName].ToString().Trim(); //文本方向名(字段类型:varchar,字段长度:40,是否可空:True)
 objvQuestionnaire_KnowledgeEN.FillInTextWidth = TransNullToInt(objDT.Rows[0][convQuestionnaire_Knowledge.FillInTextWidth].ToString().Trim()); //填空框宽度(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.MemoTextWidth = TransNullToInt(objDT.Rows[0][convQuestionnaire_Knowledge.MemoTextWidth].ToString().Trim()); //备注框宽度(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CodeTab = objDT.Rows[0][convQuestionnaire_Knowledge.CodeTab].ToString().Trim(); //代码表(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CodeTabCode = objDT.Rows[0][convQuestionnaire_Knowledge.CodeTabCode].ToString().Trim(); //CodeTab_Code(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CodeTabName = objDT.Rows[0][convQuestionnaire_Knowledge.CodeTabName].ToString().Trim(); //CodeTab_Name(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CodeTabCondition = objDT.Rows[0][convQuestionnaire_Knowledge.CodeTabCondition].ToString().Trim(); //代码表_条件(字段类型:varchar,字段长度:200,是否可空:True)
 objvQuestionnaire_KnowledgeEN.RelaEvent = objDT.Rows[0][convQuestionnaire_Knowledge.RelaEvent].ToString().Trim(); //相关事件(字段类型:varchar,字段长度:4000,是否可空:True)
 objvQuestionnaire_KnowledgeEN.FirstIndent = TransNullToBool(objDT.Rows[0][convQuestionnaire_Knowledge.FirstIndent].ToString().Trim()); //首行缩进(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_KnowledgeEN.DefaultSelectItem = objDT.Rows[0][convQuestionnaire_Knowledge.DefaultSelectItem].ToString().Trim(); //默认选项(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = TransNullToBool(objDT.Rows[0][convQuestionnaire_Knowledge.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_KnowledgeEN.FillInTextHeight = TransNullToInt(objDT.Rows[0][convQuestionnaire_Knowledge.FillInTextHeight].ToString().Trim()); //填空框高度(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = TransNullToBool(objDT.Rows[0][convQuestionnaire_Knowledge.IsMulti4FillInText].ToString().Trim()); //是否填空框多行(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = TransNullToInt(objDT.Rows[0][convQuestionnaire_Knowledge.CheckBoxLimitCount].ToString().Trim()); //复选框限制数(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.RoleId = objDT.Rows[0][convQuestionnaire_Knowledge.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire_KnowledgeEN.RoleName = objDT.Rows[0][convQuestionnaire_Knowledge.RoleName].ToString().Trim(); //角色名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire_KnowledgeEN.IsShow = TransNullToBool(objDT.Rows[0][convQuestionnaire_Knowledge.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_KnowledgeEN.IsCast = TransNullToBool(objDT.Rows[0][convQuestionnaire_Knowledge.IsCast].ToString().Trim()); //是否播放(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_KnowledgeEN.LikeCount = TransNullToInt(objDT.Rows[0][convQuestionnaire_Knowledge.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaire_KnowledgeEN.IsEffective = TransNullToBool(objDT.Rows[0][convQuestionnaire_Knowledge.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_KnowledgeEN.IsCanInPaper = TransNullToBool(objDT.Rows[0][convQuestionnaire_Knowledge.IsCanInPaper].ToString().Trim()); //是否可在Paper(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_KnowledgeEN.UpdDate = objDT.Rows[0][convQuestionnaire_Knowledge.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaire_KnowledgeEN.UpdUser = objDT.Rows[0][convQuestionnaire_Knowledge.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaire_KnowledgeEN.Memo = objDT.Rows[0][convQuestionnaire_Knowledge.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQuestionnaire_KnowledgeEN.KnowledgeNum = TransNullToInt(objDT.Rows[0][convQuestionnaire_Knowledge.KnowledgeNum].ToString().Trim()); //知识点数(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.AnswerNum = TransNullToInt(objDT.Rows[0][convQuestionnaire_Knowledge.AnswerNum].ToString().Trim()); //答案数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQuestionnaire_KnowledgeDA: GetvQuestionnaire_Knowledge)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQuestionnaire_KnowledgeEN GetObjByQuestionId(long lngQuestionId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Knowledge where QuestionId = " + ""+ lngQuestionId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN();
try
{
 objvQuestionnaire_KnowledgeEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Knowledge.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionIndex = objRow[convQuestionnaire_Knowledge.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionName = objRow[convQuestionnaire_Knowledge.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionContent = objRow[convQuestionnaire_Knowledge.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionMemo = objRow[convQuestionnaire_Knowledge.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionMemo].ToString().Trim(); //题目说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionNo = objRow[convQuestionnaire_Knowledge.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire_KnowledgeEN.ExamAnswer = objRow[convQuestionnaire_Knowledge.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamAnswer].ToString().Trim(); //题目答案(字段类型:varchar,字段长度:8000,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CourseId = objRow[convQuestionnaire_Knowledge.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CourseName = objRow[convQuestionnaire_Knowledge.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CourseChapterId = objRow[convQuestionnaire_Knowledge.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionnaire_KnowledgeEN.CourseChapterName = objRow[convQuestionnaire_Knowledge.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvQuestionnaire_KnowledgeEN.ChapterId = objRow[convQuestionnaire_Knowledge.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire_KnowledgeEN.SectionId = objRow[convQuestionnaire_Knowledge.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire_KnowledgeEN.ChapterName = objRow[convQuestionnaire_Knowledge.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire_KnowledgeEN.SectionName = objRow[convQuestionnaire_Knowledge.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire_KnowledgeEN.ChapterNameSim = objRow[convQuestionnaire_Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire_KnowledgeEN.SectionNameSim = objRow[convQuestionnaire_Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire_KnowledgeEN.ParentNodeId = objRow[convQuestionnaire_Knowledge.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CourseChapterReferred = objRow[convQuestionnaire_Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire_KnowledgeEN.ParentNodeName = objRow[convQuestionnaire_Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire_KnowledgeEN.ParentNodeReferred = objRow[convQuestionnaire_Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionTypeId = objRow[convQuestionnaire_Knowledge.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionTypeName = objRow[convQuestionnaire_Knowledge.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaire_KnowledgeEN.ExamGradeId = objRow[convQuestionnaire_Knowledge.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeId].ToString().Trim(); //题库等级ID(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire_KnowledgeEN.ExamGradeName = objRow[convQuestionnaire_Knowledge.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeName].ToString().Trim(); //题库等级名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaire_KnowledgeEN.AnswerTypeId = objRow[convQuestionnaire_Knowledge.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire_KnowledgeEN.AnswerTypeName = objRow[convQuestionnaire_Knowledge.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaire_KnowledgeEN.GridTitle = objRow[convQuestionnaire_Knowledge.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvQuestionnaire_KnowledgeEN.AnswerModeId = objRow[convQuestionnaire_Knowledge.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.AnswerModeName = objRow[convQuestionnaire_Knowledge.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeName].ToString().Trim(); //答案模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = objRow[convQuestionnaire_Knowledge.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = objRow[convQuestionnaire_Knowledge.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetName].ToString().Trim(); //问卷集名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionScore = objRow[convQuestionnaire_Knowledge.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionnaire_Knowledge.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objvQuestionnaire_KnowledgeEN.QuestionNameAdd = objRow[convQuestionnaire_Knowledge.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNameAdd].ToString().Trim(); //题目补充(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionnaire_KnowledgeEN.DefaultValue = objRow[convQuestionnaire_Knowledge.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaire_KnowledgeEN.TextDirectId = objRow[convQuestionnaire_Knowledge.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectId].ToString().Trim(); //文本方向ID(字段类型:char,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.TextDirectName = objRow[convQuestionnaire_Knowledge.TextDirectName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectName].ToString().Trim(); //文本方向名(字段类型:varchar,字段长度:40,是否可空:True)
 objvQuestionnaire_KnowledgeEN.FillInTextWidth = objRow[convQuestionnaire_Knowledge.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextWidth].ToString().Trim()); //填空框宽度(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.MemoTextWidth = objRow[convQuestionnaire_Knowledge.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.MemoTextWidth].ToString().Trim()); //备注框宽度(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CodeTab = objRow[convQuestionnaire_Knowledge.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTab].ToString().Trim(); //代码表(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CodeTabCode = objRow[convQuestionnaire_Knowledge.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCode].ToString().Trim(); //CodeTab_Code(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CodeTabName = objRow[convQuestionnaire_Knowledge.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabName].ToString().Trim(); //CodeTab_Name(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CodeTabCondition = objRow[convQuestionnaire_Knowledge.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCondition].ToString().Trim(); //代码表_条件(字段类型:varchar,字段长度:200,是否可空:True)
 objvQuestionnaire_KnowledgeEN.RelaEvent = objRow[convQuestionnaire_Knowledge.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RelaEvent].ToString().Trim(); //相关事件(字段类型:varchar,字段长度:4000,是否可空:True)
 objvQuestionnaire_KnowledgeEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.FirstIndent].ToString().Trim()); //首行缩进(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_KnowledgeEN.DefaultSelectItem = objRow[convQuestionnaire_Knowledge.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultSelectItem].ToString().Trim(); //默认选项(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_KnowledgeEN.FillInTextHeight = objRow[convQuestionnaire_Knowledge.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.FillInTextHeight].ToString().Trim()); //填空框高度(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsMulti4FillInText].ToString().Trim()); //是否填空框多行(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount].ToString().Trim()); //复选框限制数(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.RoleId = objRow[convQuestionnaire_Knowledge.RoleId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire_KnowledgeEN.RoleName = objRow[convQuestionnaire_Knowledge.RoleName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleName].ToString().Trim(); //角色名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire_KnowledgeEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_KnowledgeEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCast].ToString().Trim()); //是否播放(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_KnowledgeEN.LikeCount = objRow[convQuestionnaire_Knowledge.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaire_KnowledgeEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_KnowledgeEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Knowledge.IsCanInPaper].ToString().Trim()); //是否可在Paper(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_KnowledgeEN.UpdDate = objRow[convQuestionnaire_Knowledge.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaire_KnowledgeEN.UpdUser = objRow[convQuestionnaire_Knowledge.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionnaire_KnowledgeEN.Memo = objRow[convQuestionnaire_Knowledge.Memo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQuestionnaire_KnowledgeEN.KnowledgeNum = objRow[convQuestionnaire_Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.KnowledgeNum].ToString().Trim()); //知识点数(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_KnowledgeEN.AnswerNum = objRow[convQuestionnaire_Knowledge.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Knowledge.AnswerNum].ToString().Trim()); //答案数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQuestionnaire_KnowledgeDA: GetObjByQuestionId)", objException.Message));
}
return objvQuestionnaire_KnowledgeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQuestionnaire_KnowledgeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQuestionnaire_KnowledgeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Knowledge where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN()
{
QuestionId = TransNullToInt(objRow[convQuestionnaire_Knowledge.QuestionId].ToString().Trim()), //题目Id
QuestionIndex = objRow[convQuestionnaire_Knowledge.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.QuestionIndex].ToString().Trim()), //题目序号
QuestionName = objRow[convQuestionnaire_Knowledge.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionName].ToString().Trim(), //题目名称
QuestionContent = objRow[convQuestionnaire_Knowledge.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionContent].ToString().Trim(), //题目内容
QuestionMemo = objRow[convQuestionnaire_Knowledge.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionMemo].ToString().Trim(), //题目说明
QuestionNo = objRow[convQuestionnaire_Knowledge.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNo].ToString().Trim(), //题目编号
ExamAnswer = objRow[convQuestionnaire_Knowledge.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamAnswer].ToString().Trim(), //题目答案
CourseId = objRow[convQuestionnaire_Knowledge.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseId].ToString().Trim(), //课程Id
CourseName = objRow[convQuestionnaire_Knowledge.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseName].ToString().Trim(), //课程名称
CourseChapterId = objRow[convQuestionnaire_Knowledge.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convQuestionnaire_Knowledge.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterName].ToString().Trim(), //课程章节名称
ChapterId = objRow[convQuestionnaire_Knowledge.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterId].ToString().Trim(), //章Id
SectionId = objRow[convQuestionnaire_Knowledge.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionId].ToString().Trim(), //节Id
ChapterName = objRow[convQuestionnaire_Knowledge.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterName].ToString().Trim(), //章名
SectionName = objRow[convQuestionnaire_Knowledge.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionName].ToString().Trim(), //节名
ChapterNameSim = objRow[convQuestionnaire_Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterNameSim].ToString().Trim(), //章名简称
SectionNameSim = objRow[convQuestionnaire_Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionNameSim].ToString().Trim(), //节名简称
ParentNodeId = objRow[convQuestionnaire_Knowledge.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeId].ToString().Trim(), //父节点编号
CourseChapterReferred = objRow[convQuestionnaire_Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterReferred].ToString().Trim(), //节简称
ParentNodeName = objRow[convQuestionnaire_Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeName].ToString().Trim(), //父节点名称
ParentNodeReferred = objRow[convQuestionnaire_Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeReferred].ToString().Trim(), //章简称
QuestionTypeId = objRow[convQuestionnaire_Knowledge.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionTypeName = objRow[convQuestionnaire_Knowledge.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeName].ToString().Trim(), //题目类型名
ExamGradeId = objRow[convQuestionnaire_Knowledge.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeId].ToString().Trim(), //题库等级ID
ExamGradeName = objRow[convQuestionnaire_Knowledge.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeName].ToString().Trim(), //题库等级名
AnswerTypeId = objRow[convQuestionnaire_Knowledge.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeId].ToString().Trim(), //答案类型ID
AnswerTypeName = objRow[convQuestionnaire_Knowledge.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeName].ToString().Trim(), //答案类型名
GridTitle = objRow[convQuestionnaire_Knowledge.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.GridTitle].ToString().Trim(), //表格标题
AnswerModeId = objRow[convQuestionnaire_Knowledge.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeId].ToString().Trim(), //答案模式Id
AnswerModeName = objRow[convQuestionnaire_Knowledge.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeName].ToString().Trim(), //答案模式名称
IsHaveAdditionalMemo = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsHaveAdditionalMemo].ToString().Trim()), //是否有附加说明
QuestionnaireSetId = objRow[convQuestionnaire_Knowledge.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetId].ToString().Trim(), //问卷集ID
QuestionnaireSetName = objRow[convQuestionnaire_Knowledge.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetName].ToString().Trim(), //问卷集名
QuestionScore = objRow[convQuestionnaire_Knowledge.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionnaire_Knowledge.QuestionScore].ToString().Trim()), //题目得分
QuestionNameAdd = objRow[convQuestionnaire_Knowledge.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNameAdd].ToString().Trim(), //题目补充
DefaultValue = objRow[convQuestionnaire_Knowledge.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultValue].ToString().Trim(), //缺省值
TextDirectId = objRow[convQuestionnaire_Knowledge.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectId].ToString().Trim(), //文本方向ID
TextDirectName = objRow[convQuestionnaire_Knowledge.TextDirectName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectName].ToString().Trim(), //文本方向名
FillInTextWidth = objRow[convQuestionnaire_Knowledge.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.FillInTextWidth].ToString().Trim()), //填空框宽度
MemoTextWidth = objRow[convQuestionnaire_Knowledge.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.MemoTextWidth].ToString().Trim()), //备注框宽度
CodeTab = objRow[convQuestionnaire_Knowledge.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTab].ToString().Trim(), //代码表
CodeTabCode = objRow[convQuestionnaire_Knowledge.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCode].ToString().Trim(), //CodeTab_Code
CodeTabName = objRow[convQuestionnaire_Knowledge.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabName].ToString().Trim(), //CodeTab_Name
CodeTabCondition = objRow[convQuestionnaire_Knowledge.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCondition].ToString().Trim(), //代码表_条件
RelaEvent = objRow[convQuestionnaire_Knowledge.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RelaEvent].ToString().Trim(), //相关事件
FirstIndent = TransNullToBool(objRow[convQuestionnaire_Knowledge.FirstIndent].ToString().Trim()), //首行缩进
DefaultSelectItem = objRow[convQuestionnaire_Knowledge.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultSelectItem].ToString().Trim(), //默认选项
IsAutoGridTitle = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsAutoGridTitle].ToString().Trim()), //是否自动编表格标题
FillInTextHeight = objRow[convQuestionnaire_Knowledge.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.FillInTextHeight].ToString().Trim()), //填空框高度
IsMulti4FillInText = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsMulti4FillInText].ToString().Trim()), //是否填空框多行
CheckBoxLimitCount = objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount].ToString().Trim()), //复选框限制数
RoleId = objRow[convQuestionnaire_Knowledge.RoleId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleId].ToString().Trim(), //角色Id
RoleName = objRow[convQuestionnaire_Knowledge.RoleName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleName].ToString().Trim(), //角色名
IsShow = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsShow].ToString().Trim()), //是否启用
IsCast = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsCast].ToString().Trim()), //是否播放
LikeCount = objRow[convQuestionnaire_Knowledge.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.LikeCount].ToString().Trim()), //资源喜欢数量
IsEffective = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsEffective].ToString().Trim()), //是否有效
IsCanInPaper = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsCanInPaper].ToString().Trim()), //是否可在Paper
UpdDate = objRow[convQuestionnaire_Knowledge.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convQuestionnaire_Knowledge.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convQuestionnaire_Knowledge.Memo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.Memo].ToString().Trim(), //备注
KnowledgeNum = objRow[convQuestionnaire_Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.KnowledgeNum].ToString().Trim()), //知识点数
AnswerNum = objRow[convQuestionnaire_Knowledge.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.AnswerNum].ToString().Trim()) //答案数
};
objvQuestionnaire_KnowledgeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaire_KnowledgeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQuestionnaire_KnowledgeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQuestionnaire_KnowledgeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN();
try
{
objvQuestionnaire_KnowledgeEN.QuestionId = TransNullToInt(objRow[convQuestionnaire_Knowledge.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_KnowledgeEN.QuestionIndex = objRow[convQuestionnaire_Knowledge.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_KnowledgeEN.QuestionName = objRow[convQuestionnaire_Knowledge.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_KnowledgeEN.QuestionContent = objRow[convQuestionnaire_Knowledge.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaire_KnowledgeEN.QuestionMemo = objRow[convQuestionnaire_Knowledge.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaire_KnowledgeEN.QuestionNo = objRow[convQuestionnaire_Knowledge.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_KnowledgeEN.ExamAnswer = objRow[convQuestionnaire_Knowledge.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaire_KnowledgeEN.CourseId = objRow[convQuestionnaire_Knowledge.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_KnowledgeEN.CourseName = objRow[convQuestionnaire_Knowledge.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire_KnowledgeEN.CourseChapterId = objRow[convQuestionnaire_Knowledge.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_KnowledgeEN.CourseChapterName = objRow[convQuestionnaire_Knowledge.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaire_KnowledgeEN.ChapterId = objRow[convQuestionnaire_Knowledge.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_KnowledgeEN.SectionId = objRow[convQuestionnaire_Knowledge.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_KnowledgeEN.ChapterName = objRow[convQuestionnaire_Knowledge.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_KnowledgeEN.SectionName = objRow[convQuestionnaire_Knowledge.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionName].ToString().Trim(); //节名
objvQuestionnaire_KnowledgeEN.ChapterNameSim = objRow[convQuestionnaire_Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_KnowledgeEN.SectionNameSim = objRow[convQuestionnaire_Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_KnowledgeEN.ParentNodeId = objRow[convQuestionnaire_Knowledge.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire_KnowledgeEN.CourseChapterReferred = objRow[convQuestionnaire_Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaire_KnowledgeEN.ParentNodeName = objRow[convQuestionnaire_Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaire_KnowledgeEN.ParentNodeReferred = objRow[convQuestionnaire_Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaire_KnowledgeEN.QuestionTypeId = objRow[convQuestionnaire_Knowledge.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_KnowledgeEN.QuestionTypeName = objRow[convQuestionnaire_Knowledge.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire_KnowledgeEN.ExamGradeId = objRow[convQuestionnaire_Knowledge.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire_KnowledgeEN.ExamGradeName = objRow[convQuestionnaire_Knowledge.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire_KnowledgeEN.AnswerTypeId = objRow[convQuestionnaire_Knowledge.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_KnowledgeEN.AnswerTypeName = objRow[convQuestionnaire_Knowledge.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaire_KnowledgeEN.GridTitle = objRow[convQuestionnaire_Knowledge.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_KnowledgeEN.AnswerModeId = objRow[convQuestionnaire_Knowledge.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_KnowledgeEN.AnswerModeName = objRow[convQuestionnaire_Knowledge.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = objRow[convQuestionnaire_Knowledge.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = objRow[convQuestionnaire_Knowledge.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaire_KnowledgeEN.QuestionScore = objRow[convQuestionnaire_Knowledge.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionnaire_Knowledge.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire_KnowledgeEN.QuestionNameAdd = objRow[convQuestionnaire_Knowledge.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaire_KnowledgeEN.DefaultValue = objRow[convQuestionnaire_Knowledge.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaire_KnowledgeEN.TextDirectId = objRow[convQuestionnaire_Knowledge.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaire_KnowledgeEN.TextDirectName = objRow[convQuestionnaire_Knowledge.TextDirectName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectName].ToString().Trim(); //文本方向名
objvQuestionnaire_KnowledgeEN.FillInTextWidth = objRow[convQuestionnaire_Knowledge.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaire_KnowledgeEN.MemoTextWidth = objRow[convQuestionnaire_Knowledge.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaire_KnowledgeEN.CodeTab = objRow[convQuestionnaire_Knowledge.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTab].ToString().Trim(); //代码表
objvQuestionnaire_KnowledgeEN.CodeTabCode = objRow[convQuestionnaire_Knowledge.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaire_KnowledgeEN.CodeTabName = objRow[convQuestionnaire_Knowledge.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaire_KnowledgeEN.CodeTabCondition = objRow[convQuestionnaire_Knowledge.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaire_KnowledgeEN.RelaEvent = objRow[convQuestionnaire_Knowledge.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RelaEvent].ToString().Trim(); //相关事件
objvQuestionnaire_KnowledgeEN.FirstIndent = TransNullToBool(objRow[convQuestionnaire_Knowledge.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaire_KnowledgeEN.DefaultSelectItem = objRow[convQuestionnaire_Knowledge.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objvQuestionnaire_KnowledgeEN.FillInTextHeight = objRow[convQuestionnaire_Knowledge.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaire_KnowledgeEN.RoleId = objRow[convQuestionnaire_Knowledge.RoleId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleId].ToString().Trim(); //角色Id
objvQuestionnaire_KnowledgeEN.RoleName = objRow[convQuestionnaire_Knowledge.RoleName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleName].ToString().Trim(); //角色名
objvQuestionnaire_KnowledgeEN.IsShow = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_KnowledgeEN.IsCast = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsCast].ToString().Trim()); //是否播放
objvQuestionnaire_KnowledgeEN.LikeCount = objRow[convQuestionnaire_Knowledge.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaire_KnowledgeEN.IsEffective = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaire_KnowledgeEN.IsCanInPaper = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaire_KnowledgeEN.UpdDate = objRow[convQuestionnaire_Knowledge.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire_KnowledgeEN.UpdUser = objRow[convQuestionnaire_Knowledge.UpdUser].ToString().Trim(); //修改人
objvQuestionnaire_KnowledgeEN.Memo = objRow[convQuestionnaire_Knowledge.Memo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.Memo].ToString().Trim(); //备注
objvQuestionnaire_KnowledgeEN.KnowledgeNum = objRow[convQuestionnaire_Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
objvQuestionnaire_KnowledgeEN.AnswerNum = objRow[convQuestionnaire_Knowledge.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.AnswerNum].ToString().Trim()); //答案数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQuestionnaire_KnowledgeDA: GetObjByDataRowvQuestionnaire_Knowledge)", objException.Message));
}
objvQuestionnaire_KnowledgeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaire_KnowledgeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQuestionnaire_KnowledgeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN = new clsvQuestionnaire_KnowledgeEN();
try
{
objvQuestionnaire_KnowledgeEN.QuestionId = TransNullToInt(objRow[convQuestionnaire_Knowledge.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_KnowledgeEN.QuestionIndex = objRow[convQuestionnaire_Knowledge.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_KnowledgeEN.QuestionName = objRow[convQuestionnaire_Knowledge.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_KnowledgeEN.QuestionContent = objRow[convQuestionnaire_Knowledge.QuestionContent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionContent].ToString().Trim(); //题目内容
objvQuestionnaire_KnowledgeEN.QuestionMemo = objRow[convQuestionnaire_Knowledge.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionnaire_KnowledgeEN.QuestionNo = objRow[convQuestionnaire_Knowledge.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_KnowledgeEN.ExamAnswer = objRow[convQuestionnaire_Knowledge.ExamAnswer] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamAnswer].ToString().Trim(); //题目答案
objvQuestionnaire_KnowledgeEN.CourseId = objRow[convQuestionnaire_Knowledge.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_KnowledgeEN.CourseName = objRow[convQuestionnaire_Knowledge.CourseName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseName].ToString().Trim(); //课程名称
objvQuestionnaire_KnowledgeEN.CourseChapterId = objRow[convQuestionnaire_Knowledge.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_KnowledgeEN.CourseChapterName = objRow[convQuestionnaire_Knowledge.CourseChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterName].ToString().Trim(); //课程章节名称
objvQuestionnaire_KnowledgeEN.ChapterId = objRow[convQuestionnaire_Knowledge.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_KnowledgeEN.SectionId = objRow[convQuestionnaire_Knowledge.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_KnowledgeEN.ChapterName = objRow[convQuestionnaire_Knowledge.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_KnowledgeEN.SectionName = objRow[convQuestionnaire_Knowledge.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionName].ToString().Trim(); //节名
objvQuestionnaire_KnowledgeEN.ChapterNameSim = objRow[convQuestionnaire_Knowledge.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_KnowledgeEN.SectionNameSim = objRow[convQuestionnaire_Knowledge.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_KnowledgeEN.ParentNodeId = objRow[convQuestionnaire_Knowledge.ParentNodeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeId].ToString().Trim(); //父节点编号
objvQuestionnaire_KnowledgeEN.CourseChapterReferred = objRow[convQuestionnaire_Knowledge.CourseChapterReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CourseChapterReferred].ToString().Trim(); //节简称
objvQuestionnaire_KnowledgeEN.ParentNodeName = objRow[convQuestionnaire_Knowledge.ParentNodeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeName].ToString().Trim(); //父节点名称
objvQuestionnaire_KnowledgeEN.ParentNodeReferred = objRow[convQuestionnaire_Knowledge.ParentNodeReferred] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ParentNodeReferred].ToString().Trim(); //章简称
objvQuestionnaire_KnowledgeEN.QuestionTypeId = objRow[convQuestionnaire_Knowledge.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_KnowledgeEN.QuestionTypeName = objRow[convQuestionnaire_Knowledge.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaire_KnowledgeEN.ExamGradeId = objRow[convQuestionnaire_Knowledge.ExamGradeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeId].ToString().Trim(); //题库等级ID
objvQuestionnaire_KnowledgeEN.ExamGradeName = objRow[convQuestionnaire_Knowledge.ExamGradeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.ExamGradeName].ToString().Trim(); //题库等级名
objvQuestionnaire_KnowledgeEN.AnswerTypeId = objRow[convQuestionnaire_Knowledge.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_KnowledgeEN.AnswerTypeName = objRow[convQuestionnaire_Knowledge.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionnaire_KnowledgeEN.GridTitle = objRow[convQuestionnaire_Knowledge.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_KnowledgeEN.AnswerModeId = objRow[convQuestionnaire_Knowledge.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_KnowledgeEN.AnswerModeName = objRow[convQuestionnaire_Knowledge.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionnaire_KnowledgeEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvQuestionnaire_KnowledgeEN.QuestionnaireSetId = objRow[convQuestionnaire_Knowledge.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaire_KnowledgeEN.QuestionnaireSetName = objRow[convQuestionnaire_Knowledge.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaire_KnowledgeEN.QuestionScore = objRow[convQuestionnaire_Knowledge.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionnaire_Knowledge.QuestionScore].ToString().Trim()); //题目得分
objvQuestionnaire_KnowledgeEN.QuestionNameAdd = objRow[convQuestionnaire_Knowledge.QuestionNameAdd] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.QuestionNameAdd].ToString().Trim(); //题目补充
objvQuestionnaire_KnowledgeEN.DefaultValue = objRow[convQuestionnaire_Knowledge.DefaultValue] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultValue].ToString().Trim(); //缺省值
objvQuestionnaire_KnowledgeEN.TextDirectId = objRow[convQuestionnaire_Knowledge.TextDirectId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectId].ToString().Trim(); //文本方向ID
objvQuestionnaire_KnowledgeEN.TextDirectName = objRow[convQuestionnaire_Knowledge.TextDirectName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.TextDirectName].ToString().Trim(); //文本方向名
objvQuestionnaire_KnowledgeEN.FillInTextWidth = objRow[convQuestionnaire_Knowledge.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.FillInTextWidth].ToString().Trim()); //填空框宽度
objvQuestionnaire_KnowledgeEN.MemoTextWidth = objRow[convQuestionnaire_Knowledge.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.MemoTextWidth].ToString().Trim()); //备注框宽度
objvQuestionnaire_KnowledgeEN.CodeTab = objRow[convQuestionnaire_Knowledge.CodeTab] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTab].ToString().Trim(); //代码表
objvQuestionnaire_KnowledgeEN.CodeTabCode = objRow[convQuestionnaire_Knowledge.CodeTabCode] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvQuestionnaire_KnowledgeEN.CodeTabName = objRow[convQuestionnaire_Knowledge.CodeTabName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabName].ToString().Trim(); //CodeTab_Name
objvQuestionnaire_KnowledgeEN.CodeTabCondition = objRow[convQuestionnaire_Knowledge.CodeTabCondition] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.CodeTabCondition].ToString().Trim(); //代码表_条件
objvQuestionnaire_KnowledgeEN.RelaEvent = objRow[convQuestionnaire_Knowledge.RelaEvent] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RelaEvent].ToString().Trim(); //相关事件
objvQuestionnaire_KnowledgeEN.FirstIndent = TransNullToBool(objRow[convQuestionnaire_Knowledge.FirstIndent].ToString().Trim()); //首行缩进
objvQuestionnaire_KnowledgeEN.DefaultSelectItem = objRow[convQuestionnaire_Knowledge.DefaultSelectItem] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.DefaultSelectItem].ToString().Trim(); //默认选项
objvQuestionnaire_KnowledgeEN.IsAutoGridTitle = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objvQuestionnaire_KnowledgeEN.FillInTextHeight = objRow[convQuestionnaire_Knowledge.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.FillInTextHeight].ToString().Trim()); //填空框高度
objvQuestionnaire_KnowledgeEN.IsMulti4FillInText = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvQuestionnaire_KnowledgeEN.CheckBoxLimitCount = objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvQuestionnaire_KnowledgeEN.RoleId = objRow[convQuestionnaire_Knowledge.RoleId] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleId].ToString().Trim(); //角色Id
objvQuestionnaire_KnowledgeEN.RoleName = objRow[convQuestionnaire_Knowledge.RoleName] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.RoleName].ToString().Trim(); //角色名
objvQuestionnaire_KnowledgeEN.IsShow = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_KnowledgeEN.IsCast = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsCast].ToString().Trim()); //是否播放
objvQuestionnaire_KnowledgeEN.LikeCount = objRow[convQuestionnaire_Knowledge.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.LikeCount].ToString().Trim()); //资源喜欢数量
objvQuestionnaire_KnowledgeEN.IsEffective = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsEffective].ToString().Trim()); //是否有效
objvQuestionnaire_KnowledgeEN.IsCanInPaper = TransNullToBool(objRow[convQuestionnaire_Knowledge.IsCanInPaper].ToString().Trim()); //是否可在Paper
objvQuestionnaire_KnowledgeEN.UpdDate = objRow[convQuestionnaire_Knowledge.UpdDate].ToString().Trim(); //修改日期
objvQuestionnaire_KnowledgeEN.UpdUser = objRow[convQuestionnaire_Knowledge.UpdUser].ToString().Trim(); //修改人
objvQuestionnaire_KnowledgeEN.Memo = objRow[convQuestionnaire_Knowledge.Memo] == DBNull.Value ? null : objRow[convQuestionnaire_Knowledge.Memo].ToString().Trim(); //备注
objvQuestionnaire_KnowledgeEN.KnowledgeNum = objRow[convQuestionnaire_Knowledge.KnowledgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.KnowledgeNum].ToString().Trim()); //知识点数
objvQuestionnaire_KnowledgeEN.AnswerNum = objRow[convQuestionnaire_Knowledge.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Knowledge.AnswerNum].ToString().Trim()); //答案数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQuestionnaire_KnowledgeDA: GetObjByDataRow)", objException.Message));
}
objvQuestionnaire_KnowledgeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaire_KnowledgeEN;
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
objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQuestionnaire_KnowledgeEN._CurrTabName, convQuestionnaire_Knowledge.QuestionId, 8, "");
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
objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQuestionnaire_KnowledgeEN._CurrTabName, convQuestionnaire_Knowledge.QuestionId, 8, strPrefix);
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
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QuestionId from vQuestionnaire_Knowledge where " + strCondition;
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
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QuestionId from vQuestionnaire_Knowledge where " + strCondition;
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
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQuestionnaire_Knowledge", "QuestionId = " + ""+ lngQuestionId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQuestionnaire_KnowledgeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQuestionnaire_Knowledge", strCondition))
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
objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQuestionnaire_Knowledge");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQuestionnaire_KnowledgeENS">源对象</param>
 /// <param name = "objvQuestionnaire_KnowledgeENT">目标对象</param>
public void CopyTo(clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeENS, clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeENT)
{
objvQuestionnaire_KnowledgeENT.QuestionId = objvQuestionnaire_KnowledgeENS.QuestionId; //题目Id
objvQuestionnaire_KnowledgeENT.QuestionIndex = objvQuestionnaire_KnowledgeENS.QuestionIndex; //题目序号
objvQuestionnaire_KnowledgeENT.QuestionName = objvQuestionnaire_KnowledgeENS.QuestionName; //题目名称
objvQuestionnaire_KnowledgeENT.QuestionContent = objvQuestionnaire_KnowledgeENS.QuestionContent; //题目内容
objvQuestionnaire_KnowledgeENT.QuestionMemo = objvQuestionnaire_KnowledgeENS.QuestionMemo; //题目说明
objvQuestionnaire_KnowledgeENT.QuestionNo = objvQuestionnaire_KnowledgeENS.QuestionNo; //题目编号
objvQuestionnaire_KnowledgeENT.ExamAnswer = objvQuestionnaire_KnowledgeENS.ExamAnswer; //题目答案
objvQuestionnaire_KnowledgeENT.CourseId = objvQuestionnaire_KnowledgeENS.CourseId; //课程Id
objvQuestionnaire_KnowledgeENT.CourseName = objvQuestionnaire_KnowledgeENS.CourseName; //课程名称
objvQuestionnaire_KnowledgeENT.CourseChapterId = objvQuestionnaire_KnowledgeENS.CourseChapterId; //课程章节ID
objvQuestionnaire_KnowledgeENT.CourseChapterName = objvQuestionnaire_KnowledgeENS.CourseChapterName; //课程章节名称
objvQuestionnaire_KnowledgeENT.ChapterId = objvQuestionnaire_KnowledgeENS.ChapterId; //章Id
objvQuestionnaire_KnowledgeENT.SectionId = objvQuestionnaire_KnowledgeENS.SectionId; //节Id
objvQuestionnaire_KnowledgeENT.ChapterName = objvQuestionnaire_KnowledgeENS.ChapterName; //章名
objvQuestionnaire_KnowledgeENT.SectionName = objvQuestionnaire_KnowledgeENS.SectionName; //节名
objvQuestionnaire_KnowledgeENT.ChapterNameSim = objvQuestionnaire_KnowledgeENS.ChapterNameSim; //章名简称
objvQuestionnaire_KnowledgeENT.SectionNameSim = objvQuestionnaire_KnowledgeENS.SectionNameSim; //节名简称
objvQuestionnaire_KnowledgeENT.ParentNodeId = objvQuestionnaire_KnowledgeENS.ParentNodeId; //父节点编号
objvQuestionnaire_KnowledgeENT.CourseChapterReferred = objvQuestionnaire_KnowledgeENS.CourseChapterReferred; //节简称
objvQuestionnaire_KnowledgeENT.ParentNodeName = objvQuestionnaire_KnowledgeENS.ParentNodeName; //父节点名称
objvQuestionnaire_KnowledgeENT.ParentNodeReferred = objvQuestionnaire_KnowledgeENS.ParentNodeReferred; //章简称
objvQuestionnaire_KnowledgeENT.QuestionTypeId = objvQuestionnaire_KnowledgeENS.QuestionTypeId; //题目类型Id
objvQuestionnaire_KnowledgeENT.QuestionTypeName = objvQuestionnaire_KnowledgeENS.QuestionTypeName; //题目类型名
objvQuestionnaire_KnowledgeENT.ExamGradeId = objvQuestionnaire_KnowledgeENS.ExamGradeId; //题库等级ID
objvQuestionnaire_KnowledgeENT.ExamGradeName = objvQuestionnaire_KnowledgeENS.ExamGradeName; //题库等级名
objvQuestionnaire_KnowledgeENT.AnswerTypeId = objvQuestionnaire_KnowledgeENS.AnswerTypeId; //答案类型ID
objvQuestionnaire_KnowledgeENT.AnswerTypeName = objvQuestionnaire_KnowledgeENS.AnswerTypeName; //答案类型名
objvQuestionnaire_KnowledgeENT.GridTitle = objvQuestionnaire_KnowledgeENS.GridTitle; //表格标题
objvQuestionnaire_KnowledgeENT.AnswerModeId = objvQuestionnaire_KnowledgeENS.AnswerModeId; //答案模式Id
objvQuestionnaire_KnowledgeENT.AnswerModeName = objvQuestionnaire_KnowledgeENS.AnswerModeName; //答案模式名称
objvQuestionnaire_KnowledgeENT.IsHaveAdditionalMemo = objvQuestionnaire_KnowledgeENS.IsHaveAdditionalMemo; //是否有附加说明
objvQuestionnaire_KnowledgeENT.QuestionnaireSetId = objvQuestionnaire_KnowledgeENS.QuestionnaireSetId; //问卷集ID
objvQuestionnaire_KnowledgeENT.QuestionnaireSetName = objvQuestionnaire_KnowledgeENS.QuestionnaireSetName; //问卷集名
objvQuestionnaire_KnowledgeENT.QuestionScore = objvQuestionnaire_KnowledgeENS.QuestionScore; //题目得分
objvQuestionnaire_KnowledgeENT.QuestionNameAdd = objvQuestionnaire_KnowledgeENS.QuestionNameAdd; //题目补充
objvQuestionnaire_KnowledgeENT.DefaultValue = objvQuestionnaire_KnowledgeENS.DefaultValue; //缺省值
objvQuestionnaire_KnowledgeENT.TextDirectId = objvQuestionnaire_KnowledgeENS.TextDirectId; //文本方向ID
objvQuestionnaire_KnowledgeENT.TextDirectName = objvQuestionnaire_KnowledgeENS.TextDirectName; //文本方向名
objvQuestionnaire_KnowledgeENT.FillInTextWidth = objvQuestionnaire_KnowledgeENS.FillInTextWidth; //填空框宽度
objvQuestionnaire_KnowledgeENT.MemoTextWidth = objvQuestionnaire_KnowledgeENS.MemoTextWidth; //备注框宽度
objvQuestionnaire_KnowledgeENT.CodeTab = objvQuestionnaire_KnowledgeENS.CodeTab; //代码表
objvQuestionnaire_KnowledgeENT.CodeTabCode = objvQuestionnaire_KnowledgeENS.CodeTabCode; //CodeTab_Code
objvQuestionnaire_KnowledgeENT.CodeTabName = objvQuestionnaire_KnowledgeENS.CodeTabName; //CodeTab_Name
objvQuestionnaire_KnowledgeENT.CodeTabCondition = objvQuestionnaire_KnowledgeENS.CodeTabCondition; //代码表_条件
objvQuestionnaire_KnowledgeENT.RelaEvent = objvQuestionnaire_KnowledgeENS.RelaEvent; //相关事件
objvQuestionnaire_KnowledgeENT.FirstIndent = objvQuestionnaire_KnowledgeENS.FirstIndent; //首行缩进
objvQuestionnaire_KnowledgeENT.DefaultSelectItem = objvQuestionnaire_KnowledgeENS.DefaultSelectItem; //默认选项
objvQuestionnaire_KnowledgeENT.IsAutoGridTitle = objvQuestionnaire_KnowledgeENS.IsAutoGridTitle; //是否自动编表格标题
objvQuestionnaire_KnowledgeENT.FillInTextHeight = objvQuestionnaire_KnowledgeENS.FillInTextHeight; //填空框高度
objvQuestionnaire_KnowledgeENT.IsMulti4FillInText = objvQuestionnaire_KnowledgeENS.IsMulti4FillInText; //是否填空框多行
objvQuestionnaire_KnowledgeENT.CheckBoxLimitCount = objvQuestionnaire_KnowledgeENS.CheckBoxLimitCount; //复选框限制数
objvQuestionnaire_KnowledgeENT.RoleId = objvQuestionnaire_KnowledgeENS.RoleId; //角色Id
objvQuestionnaire_KnowledgeENT.RoleName = objvQuestionnaire_KnowledgeENS.RoleName; //角色名
objvQuestionnaire_KnowledgeENT.IsShow = objvQuestionnaire_KnowledgeENS.IsShow; //是否启用
objvQuestionnaire_KnowledgeENT.IsCast = objvQuestionnaire_KnowledgeENS.IsCast; //是否播放
objvQuestionnaire_KnowledgeENT.LikeCount = objvQuestionnaire_KnowledgeENS.LikeCount; //资源喜欢数量
objvQuestionnaire_KnowledgeENT.IsEffective = objvQuestionnaire_KnowledgeENS.IsEffective; //是否有效
objvQuestionnaire_KnowledgeENT.IsCanInPaper = objvQuestionnaire_KnowledgeENS.IsCanInPaper; //是否可在Paper
objvQuestionnaire_KnowledgeENT.UpdDate = objvQuestionnaire_KnowledgeENS.UpdDate; //修改日期
objvQuestionnaire_KnowledgeENT.UpdUser = objvQuestionnaire_KnowledgeENS.UpdUser; //修改人
objvQuestionnaire_KnowledgeENT.Memo = objvQuestionnaire_KnowledgeENS.Memo; //备注
objvQuestionnaire_KnowledgeENT.KnowledgeNum = objvQuestionnaire_KnowledgeENS.KnowledgeNum; //知识点数
objvQuestionnaire_KnowledgeENT.AnswerNum = objvQuestionnaire_KnowledgeENS.AnswerNum; //答案数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQuestionnaire_KnowledgeEN objvQuestionnaire_KnowledgeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.QuestionName, 500, convQuestionnaire_Knowledge.QuestionName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.QuestionContent, 4000, convQuestionnaire_Knowledge.QuestionContent);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.QuestionMemo, 1000, convQuestionnaire_Knowledge.QuestionMemo);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.QuestionNo, 10, convQuestionnaire_Knowledge.QuestionNo);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.ExamAnswer, 8000, convQuestionnaire_Knowledge.ExamAnswer);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.CourseId, 8, convQuestionnaire_Knowledge.CourseId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.CourseName, 100, convQuestionnaire_Knowledge.CourseName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.CourseChapterId, 8, convQuestionnaire_Knowledge.CourseChapterId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.CourseChapterName, 100, convQuestionnaire_Knowledge.CourseChapterName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.ChapterId, 8, convQuestionnaire_Knowledge.ChapterId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.SectionId, 8, convQuestionnaire_Knowledge.SectionId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.ChapterName, 100, convQuestionnaire_Knowledge.ChapterName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.SectionName, 100, convQuestionnaire_Knowledge.SectionName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.ChapterNameSim, 10, convQuestionnaire_Knowledge.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.SectionNameSim, 10, convQuestionnaire_Knowledge.SectionNameSim);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.ParentNodeId, 8, convQuestionnaire_Knowledge.ParentNodeId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.CourseChapterReferred, 10, convQuestionnaire_Knowledge.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.ParentNodeName, 100, convQuestionnaire_Knowledge.ParentNodeName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.ParentNodeReferred, 10, convQuestionnaire_Knowledge.ParentNodeReferred);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.QuestionTypeId, 2, convQuestionnaire_Knowledge.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.QuestionTypeName, 20, convQuestionnaire_Knowledge.QuestionTypeName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.ExamGradeId, 2, convQuestionnaire_Knowledge.ExamGradeId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.ExamGradeName, 50, convQuestionnaire_Knowledge.ExamGradeName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.AnswerTypeId, 2, convQuestionnaire_Knowledge.AnswerTypeId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.AnswerTypeName, 50, convQuestionnaire_Knowledge.AnswerTypeName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.GridTitle, 30, convQuestionnaire_Knowledge.GridTitle);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.AnswerModeId, 4, convQuestionnaire_Knowledge.AnswerModeId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.AnswerModeName, 30, convQuestionnaire_Knowledge.AnswerModeName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.QuestionnaireSetId, 4, convQuestionnaire_Knowledge.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.QuestionnaireSetName, 50, convQuestionnaire_Knowledge.QuestionnaireSetName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.QuestionNameAdd, 500, convQuestionnaire_Knowledge.QuestionNameAdd);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.DefaultValue, 50, convQuestionnaire_Knowledge.DefaultValue);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.TextDirectId, 4, convQuestionnaire_Knowledge.TextDirectId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.TextDirectName, 40, convQuestionnaire_Knowledge.TextDirectName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.CodeTab, 50, convQuestionnaire_Knowledge.CodeTab);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.CodeTabCode, 50, convQuestionnaire_Knowledge.CodeTabCode);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.CodeTabName, 50, convQuestionnaire_Knowledge.CodeTabName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.CodeTabCondition, 200, convQuestionnaire_Knowledge.CodeTabCondition);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.RelaEvent, 4000, convQuestionnaire_Knowledge.RelaEvent);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.DefaultSelectItem, 20, convQuestionnaire_Knowledge.DefaultSelectItem);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.RoleId, 8, convQuestionnaire_Knowledge.RoleId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.RoleName, 100, convQuestionnaire_Knowledge.RoleName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.UpdDate, 20, convQuestionnaire_Knowledge.UpdDate);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.UpdUser, 20, convQuestionnaire_Knowledge.UpdUser);
clsCheckSql.CheckFieldLen(objvQuestionnaire_KnowledgeEN.Memo, 1000, convQuestionnaire_Knowledge.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.QuestionName, convQuestionnaire_Knowledge.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.QuestionContent, convQuestionnaire_Knowledge.QuestionContent);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.QuestionMemo, convQuestionnaire_Knowledge.QuestionMemo);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.QuestionNo, convQuestionnaire_Knowledge.QuestionNo);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.ExamAnswer, convQuestionnaire_Knowledge.ExamAnswer);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.CourseId, convQuestionnaire_Knowledge.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.CourseName, convQuestionnaire_Knowledge.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.CourseChapterId, convQuestionnaire_Knowledge.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.CourseChapterName, convQuestionnaire_Knowledge.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.ChapterId, convQuestionnaire_Knowledge.ChapterId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.SectionId, convQuestionnaire_Knowledge.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.ChapterName, convQuestionnaire_Knowledge.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.SectionName, convQuestionnaire_Knowledge.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.ChapterNameSim, convQuestionnaire_Knowledge.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.SectionNameSim, convQuestionnaire_Knowledge.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.ParentNodeId, convQuestionnaire_Knowledge.ParentNodeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.CourseChapterReferred, convQuestionnaire_Knowledge.CourseChapterReferred);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.ParentNodeName, convQuestionnaire_Knowledge.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.ParentNodeReferred, convQuestionnaire_Knowledge.ParentNodeReferred);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.QuestionTypeId, convQuestionnaire_Knowledge.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.QuestionTypeName, convQuestionnaire_Knowledge.QuestionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.ExamGradeId, convQuestionnaire_Knowledge.ExamGradeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.ExamGradeName, convQuestionnaire_Knowledge.ExamGradeName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.AnswerTypeId, convQuestionnaire_Knowledge.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.AnswerTypeName, convQuestionnaire_Knowledge.AnswerTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.GridTitle, convQuestionnaire_Knowledge.GridTitle);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.AnswerModeId, convQuestionnaire_Knowledge.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.AnswerModeName, convQuestionnaire_Knowledge.AnswerModeName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.QuestionnaireSetId, convQuestionnaire_Knowledge.QuestionnaireSetId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.QuestionnaireSetName, convQuestionnaire_Knowledge.QuestionnaireSetName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.QuestionNameAdd, convQuestionnaire_Knowledge.QuestionNameAdd);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.DefaultValue, convQuestionnaire_Knowledge.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.TextDirectId, convQuestionnaire_Knowledge.TextDirectId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.TextDirectName, convQuestionnaire_Knowledge.TextDirectName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.CodeTab, convQuestionnaire_Knowledge.CodeTab);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.CodeTabCode, convQuestionnaire_Knowledge.CodeTabCode);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.CodeTabName, convQuestionnaire_Knowledge.CodeTabName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.CodeTabCondition, convQuestionnaire_Knowledge.CodeTabCondition);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.RelaEvent, convQuestionnaire_Knowledge.RelaEvent);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.DefaultSelectItem, convQuestionnaire_Knowledge.DefaultSelectItem);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.RoleId, convQuestionnaire_Knowledge.RoleId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.RoleName, convQuestionnaire_Knowledge.RoleName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.UpdDate, convQuestionnaire_Knowledge.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.UpdUser, convQuestionnaire_Knowledge.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_KnowledgeEN.Memo, convQuestionnaire_Knowledge.Memo);
//检查外键字段长度
 objvQuestionnaire_KnowledgeEN._IsCheckProperty = true;
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
string strSQL = "select QuestionId, QuestionName from vQuestionnaire_Knowledge ";
 clsSpecSQLforSql mySql = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQuestionnaire_KnowledgeEN._CurrTabName);
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
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQuestionnaire_KnowledgeEN._CurrTabName, strCondition);
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
 objSQL = clsvQuestionnaire_KnowledgeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}