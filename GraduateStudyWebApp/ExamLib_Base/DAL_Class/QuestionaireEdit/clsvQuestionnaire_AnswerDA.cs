
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire_AnswerDA
 表名:vQuestionnaire_Answer(01120020)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:00
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
 /// vQuestionnaire_Answer(vQuestionnaire_Answer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQuestionnaire_AnswerDA : clsCommBase4DA
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
 return clsvQuestionnaire_AnswerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQuestionnaire_AnswerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionnaire_AnswerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQuestionnaire_AnswerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQuestionnaire_AnswerEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQuestionnaire_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQuestionnaire_Answer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQuestionnaire_AnswerDA: GetDataTable_vQuestionnaire_Answer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Answer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQuestionnaire_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQuestionnaire_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Answer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQuestionnaire_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQuestionnaire_AnswerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Answer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Answer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQuestionnaire_AnswerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Answer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQuestionnaire_AnswerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQuestionnaire_Answer.* from vQuestionnaire_Answer Left Join {1} on {2} where {3} and vQuestionnaire_Answer.QuestionId not in (Select top {5} vQuestionnaire_Answer.QuestionId from vQuestionnaire_Answer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Answer where {1} and QuestionId not in (Select top {2} QuestionId from vQuestionnaire_Answer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Answer where {1} and QuestionId not in (Select top {3} QuestionId from vQuestionnaire_Answer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQuestionnaire_AnswerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQuestionnaire_Answer.* from vQuestionnaire_Answer Left Join {1} on {2} where {3} and vQuestionnaire_Answer.QuestionId not in (Select top {5} vQuestionnaire_Answer.QuestionId from vQuestionnaire_Answer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Answer where {1} and QuestionId not in (Select top {2} QuestionId from vQuestionnaire_Answer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Answer where {1} and QuestionId not in (Select top {3} QuestionId from vQuestionnaire_Answer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvQuestionnaire_AnswerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQuestionnaire_AnswerDA:GetObjLst)", objException.Message));
}
List<clsvQuestionnaire_AnswerEN> arrObjLst = new List<clsvQuestionnaire_AnswerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = new clsvQuestionnaire_AnswerEN();
try
{
objvQuestionnaire_AnswerEN.QuestionId = TransNullToInt(objRow[convQuestionnaire_Answer.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_AnswerEN.AnswerIndex = objRow[convQuestionnaire_Answer.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Answer.AnswerIndex].ToString().Trim()); //问答序号
objvQuestionnaire_AnswerEN.AnswerContent = objRow[convQuestionnaire_Answer.AnswerContent] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerContent].ToString().Trim(); //答案内容
objvQuestionnaire_AnswerEN.Provider = objRow[convQuestionnaire_Answer.Provider] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.Provider].ToString().Trim(); //提供者
objvQuestionnaire_AnswerEN.Score = objRow[convQuestionnaire_Answer.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convQuestionnaire_Answer.Score].ToString().Trim()); //得分
objvQuestionnaire_AnswerEN.QuestionIndex = objRow[convQuestionnaire_Answer.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Answer.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_AnswerEN.QuestionName = objRow[convQuestionnaire_Answer.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_AnswerEN.ChapterId = objRow[convQuestionnaire_Answer.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_AnswerEN.SectionId = objRow[convQuestionnaire_Answer.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_AnswerEN.ChapterName = objRow[convQuestionnaire_Answer.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_AnswerEN.SectionName = objRow[convQuestionnaire_Answer.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionName].ToString().Trim(); //节名
objvQuestionnaire_AnswerEN.ChapterNameSim = objRow[convQuestionnaire_Answer.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_AnswerEN.SectionNameSim = objRow[convQuestionnaire_Answer.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_AnswerEN.QuestionTypeId = objRow[convQuestionnaire_Answer.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_AnswerEN.GridTitle = objRow[convQuestionnaire_Answer.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_AnswerEN.AnswerModeId = objRow[convQuestionnaire_Answer.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_AnswerEN.IsShow = TransNullToBool(objRow[convQuestionnaire_Answer.IsShow].ToString().Trim()); //是否启用
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQuestionnaire_AnswerDA: GetObjLst)", objException.Message));
}
objvQuestionnaire_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQuestionnaire_AnswerEN);
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
public List<clsvQuestionnaire_AnswerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQuestionnaire_AnswerDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQuestionnaire_AnswerEN> arrObjLst = new List<clsvQuestionnaire_AnswerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = new clsvQuestionnaire_AnswerEN();
try
{
objvQuestionnaire_AnswerEN.QuestionId = TransNullToInt(objRow[convQuestionnaire_Answer.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_AnswerEN.AnswerIndex = objRow[convQuestionnaire_Answer.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Answer.AnswerIndex].ToString().Trim()); //问答序号
objvQuestionnaire_AnswerEN.AnswerContent = objRow[convQuestionnaire_Answer.AnswerContent] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerContent].ToString().Trim(); //答案内容
objvQuestionnaire_AnswerEN.Provider = objRow[convQuestionnaire_Answer.Provider] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.Provider].ToString().Trim(); //提供者
objvQuestionnaire_AnswerEN.Score = objRow[convQuestionnaire_Answer.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convQuestionnaire_Answer.Score].ToString().Trim()); //得分
objvQuestionnaire_AnswerEN.QuestionIndex = objRow[convQuestionnaire_Answer.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Answer.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_AnswerEN.QuestionName = objRow[convQuestionnaire_Answer.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_AnswerEN.ChapterId = objRow[convQuestionnaire_Answer.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_AnswerEN.SectionId = objRow[convQuestionnaire_Answer.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_AnswerEN.ChapterName = objRow[convQuestionnaire_Answer.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_AnswerEN.SectionName = objRow[convQuestionnaire_Answer.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionName].ToString().Trim(); //节名
objvQuestionnaire_AnswerEN.ChapterNameSim = objRow[convQuestionnaire_Answer.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_AnswerEN.SectionNameSim = objRow[convQuestionnaire_Answer.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_AnswerEN.QuestionTypeId = objRow[convQuestionnaire_Answer.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_AnswerEN.GridTitle = objRow[convQuestionnaire_Answer.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_AnswerEN.AnswerModeId = objRow[convQuestionnaire_Answer.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_AnswerEN.IsShow = TransNullToBool(objRow[convQuestionnaire_Answer.IsShow].ToString().Trim()); //是否启用
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQuestionnaire_AnswerDA: GetObjLst)", objException.Message));
}
objvQuestionnaire_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQuestionnaire_AnswerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQuestionnaire_Answer(ref clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Answer where QuestionId = " + ""+ objvQuestionnaire_AnswerEN.QuestionId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQuestionnaire_AnswerEN.QuestionId = TransNullToInt(objDT.Rows[0][convQuestionnaire_Answer.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaire_AnswerEN.AnswerIndex = TransNullToInt(objDT.Rows[0][convQuestionnaire_Answer.AnswerIndex].ToString().Trim()); //问答序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_AnswerEN.AnswerContent = objDT.Rows[0][convQuestionnaire_Answer.AnswerContent].ToString().Trim(); //答案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvQuestionnaire_AnswerEN.Provider = objDT.Rows[0][convQuestionnaire_Answer.Provider].ToString().Trim(); //提供者(字段类型:varchar,字段长度:18,是否可空:True)
 objvQuestionnaire_AnswerEN.Score = TransNullToDouble(objDT.Rows[0][convQuestionnaire_Answer.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objvQuestionnaire_AnswerEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convQuestionnaire_Answer.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_AnswerEN.QuestionName = objDT.Rows[0][convQuestionnaire_Answer.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionnaire_AnswerEN.ChapterId = objDT.Rows[0][convQuestionnaire_Answer.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire_AnswerEN.SectionId = objDT.Rows[0][convQuestionnaire_Answer.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire_AnswerEN.ChapterName = objDT.Rows[0][convQuestionnaire_Answer.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire_AnswerEN.SectionName = objDT.Rows[0][convQuestionnaire_Answer.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire_AnswerEN.ChapterNameSim = objDT.Rows[0][convQuestionnaire_Answer.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire_AnswerEN.SectionNameSim = objDT.Rows[0][convQuestionnaire_Answer.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire_AnswerEN.QuestionTypeId = objDT.Rows[0][convQuestionnaire_Answer.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire_AnswerEN.GridTitle = objDT.Rows[0][convQuestionnaire_Answer.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvQuestionnaire_AnswerEN.AnswerModeId = objDT.Rows[0][convQuestionnaire_Answer.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvQuestionnaire_AnswerEN.IsShow = TransNullToBool(objDT.Rows[0][convQuestionnaire_Answer.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQuestionnaire_AnswerDA: GetvQuestionnaire_Answer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQuestionnaire_AnswerEN GetObjByQuestionId(long lngQuestionId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Answer where QuestionId = " + ""+ lngQuestionId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = new clsvQuestionnaire_AnswerEN();
try
{
 objvQuestionnaire_AnswerEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Answer.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaire_AnswerEN.AnswerIndex = objRow[convQuestionnaire_Answer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.AnswerIndex].ToString().Trim()); //问答序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_AnswerEN.AnswerContent = objRow[convQuestionnaire_Answer.AnswerContent] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerContent].ToString().Trim(); //答案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvQuestionnaire_AnswerEN.Provider = objRow[convQuestionnaire_Answer.Provider] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.Provider].ToString().Trim(); //提供者(字段类型:varchar,字段长度:18,是否可空:True)
 objvQuestionnaire_AnswerEN.Score = objRow[convQuestionnaire_Answer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionnaire_Answer.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objvQuestionnaire_AnswerEN.QuestionIndex = objRow[convQuestionnaire_Answer.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_AnswerEN.QuestionName = objRow[convQuestionnaire_Answer.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionnaire_AnswerEN.ChapterId = objRow[convQuestionnaire_Answer.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire_AnswerEN.SectionId = objRow[convQuestionnaire_Answer.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire_AnswerEN.ChapterName = objRow[convQuestionnaire_Answer.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire_AnswerEN.SectionName = objRow[convQuestionnaire_Answer.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire_AnswerEN.ChapterNameSim = objRow[convQuestionnaire_Answer.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire_AnswerEN.SectionNameSim = objRow[convQuestionnaire_Answer.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire_AnswerEN.QuestionTypeId = objRow[convQuestionnaire_Answer.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire_AnswerEN.GridTitle = objRow[convQuestionnaire_Answer.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvQuestionnaire_AnswerEN.AnswerModeId = objRow[convQuestionnaire_Answer.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvQuestionnaire_AnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Answer.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQuestionnaire_AnswerDA: GetObjByQuestionId)", objException.Message));
}
return objvQuestionnaire_AnswerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQuestionnaire_AnswerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQuestionnaire_AnswerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = new clsvQuestionnaire_AnswerEN()
{
QuestionId = TransNullToInt(objRow[convQuestionnaire_Answer.QuestionId].ToString().Trim()), //题目Id
AnswerIndex = objRow[convQuestionnaire_Answer.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Answer.AnswerIndex].ToString().Trim()), //问答序号
AnswerContent = objRow[convQuestionnaire_Answer.AnswerContent] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerContent].ToString().Trim(), //答案内容
Provider = objRow[convQuestionnaire_Answer.Provider] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.Provider].ToString().Trim(), //提供者
Score = objRow[convQuestionnaire_Answer.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convQuestionnaire_Answer.Score].ToString().Trim()), //得分
QuestionIndex = objRow[convQuestionnaire_Answer.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Answer.QuestionIndex].ToString().Trim()), //题目序号
QuestionName = objRow[convQuestionnaire_Answer.QuestionName].ToString().Trim(), //题目名称
ChapterId = objRow[convQuestionnaire_Answer.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterId].ToString().Trim(), //章Id
SectionId = objRow[convQuestionnaire_Answer.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionId].ToString().Trim(), //节Id
ChapterName = objRow[convQuestionnaire_Answer.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterName].ToString().Trim(), //章名
SectionName = objRow[convQuestionnaire_Answer.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionName].ToString().Trim(), //节名
ChapterNameSim = objRow[convQuestionnaire_Answer.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterNameSim].ToString().Trim(), //章名简称
SectionNameSim = objRow[convQuestionnaire_Answer.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionNameSim].ToString().Trim(), //节名简称
QuestionTypeId = objRow[convQuestionnaire_Answer.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.QuestionTypeId].ToString().Trim(), //题目类型Id
GridTitle = objRow[convQuestionnaire_Answer.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.GridTitle].ToString().Trim(), //表格标题
AnswerModeId = objRow[convQuestionnaire_Answer.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerModeId].ToString().Trim(), //答案模式Id
IsShow = TransNullToBool(objRow[convQuestionnaire_Answer.IsShow].ToString().Trim()) //是否启用
};
objvQuestionnaire_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaire_AnswerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQuestionnaire_AnswerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQuestionnaire_AnswerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = new clsvQuestionnaire_AnswerEN();
try
{
objvQuestionnaire_AnswerEN.QuestionId = TransNullToInt(objRow[convQuestionnaire_Answer.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_AnswerEN.AnswerIndex = objRow[convQuestionnaire_Answer.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Answer.AnswerIndex].ToString().Trim()); //问答序号
objvQuestionnaire_AnswerEN.AnswerContent = objRow[convQuestionnaire_Answer.AnswerContent] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerContent].ToString().Trim(); //答案内容
objvQuestionnaire_AnswerEN.Provider = objRow[convQuestionnaire_Answer.Provider] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.Provider].ToString().Trim(); //提供者
objvQuestionnaire_AnswerEN.Score = objRow[convQuestionnaire_Answer.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convQuestionnaire_Answer.Score].ToString().Trim()); //得分
objvQuestionnaire_AnswerEN.QuestionIndex = objRow[convQuestionnaire_Answer.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Answer.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_AnswerEN.QuestionName = objRow[convQuestionnaire_Answer.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_AnswerEN.ChapterId = objRow[convQuestionnaire_Answer.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_AnswerEN.SectionId = objRow[convQuestionnaire_Answer.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_AnswerEN.ChapterName = objRow[convQuestionnaire_Answer.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_AnswerEN.SectionName = objRow[convQuestionnaire_Answer.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionName].ToString().Trim(); //节名
objvQuestionnaire_AnswerEN.ChapterNameSim = objRow[convQuestionnaire_Answer.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_AnswerEN.SectionNameSim = objRow[convQuestionnaire_Answer.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_AnswerEN.QuestionTypeId = objRow[convQuestionnaire_Answer.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_AnswerEN.GridTitle = objRow[convQuestionnaire_Answer.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_AnswerEN.AnswerModeId = objRow[convQuestionnaire_Answer.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_AnswerEN.IsShow = TransNullToBool(objRow[convQuestionnaire_Answer.IsShow].ToString().Trim()); //是否启用
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQuestionnaire_AnswerDA: GetObjByDataRowvQuestionnaire_Answer)", objException.Message));
}
objvQuestionnaire_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaire_AnswerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQuestionnaire_AnswerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = new clsvQuestionnaire_AnswerEN();
try
{
objvQuestionnaire_AnswerEN.QuestionId = TransNullToInt(objRow[convQuestionnaire_Answer.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_AnswerEN.AnswerIndex = objRow[convQuestionnaire_Answer.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Answer.AnswerIndex].ToString().Trim()); //问答序号
objvQuestionnaire_AnswerEN.AnswerContent = objRow[convQuestionnaire_Answer.AnswerContent] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerContent].ToString().Trim(); //答案内容
objvQuestionnaire_AnswerEN.Provider = objRow[convQuestionnaire_Answer.Provider] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.Provider].ToString().Trim(); //提供者
objvQuestionnaire_AnswerEN.Score = objRow[convQuestionnaire_Answer.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convQuestionnaire_Answer.Score].ToString().Trim()); //得分
objvQuestionnaire_AnswerEN.QuestionIndex = objRow[convQuestionnaire_Answer.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Answer.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_AnswerEN.QuestionName = objRow[convQuestionnaire_Answer.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_AnswerEN.ChapterId = objRow[convQuestionnaire_Answer.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_AnswerEN.SectionId = objRow[convQuestionnaire_Answer.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_AnswerEN.ChapterName = objRow[convQuestionnaire_Answer.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_AnswerEN.SectionName = objRow[convQuestionnaire_Answer.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionName].ToString().Trim(); //节名
objvQuestionnaire_AnswerEN.ChapterNameSim = objRow[convQuestionnaire_Answer.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_AnswerEN.SectionNameSim = objRow[convQuestionnaire_Answer.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_AnswerEN.QuestionTypeId = objRow[convQuestionnaire_Answer.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_AnswerEN.GridTitle = objRow[convQuestionnaire_Answer.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_AnswerEN.AnswerModeId = objRow[convQuestionnaire_Answer.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_AnswerEN.IsShow = TransNullToBool(objRow[convQuestionnaire_Answer.IsShow].ToString().Trim()); //是否启用
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQuestionnaire_AnswerDA: GetObjByDataRow)", objException.Message));
}
objvQuestionnaire_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaire_AnswerEN;
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
objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQuestionnaire_AnswerEN._CurrTabName, convQuestionnaire_Answer.QuestionId, 8, "");
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
objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQuestionnaire_AnswerEN._CurrTabName, convQuestionnaire_Answer.QuestionId, 8, strPrefix);
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
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QuestionId from vQuestionnaire_Answer where " + strCondition;
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
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QuestionId from vQuestionnaire_Answer where " + strCondition;
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
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQuestionnaire_Answer", "QuestionId = " + ""+ lngQuestionId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQuestionnaire_AnswerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQuestionnaire_Answer", strCondition))
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
objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQuestionnaire_Answer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerENS">源对象</param>
 /// <param name = "objvQuestionnaire_AnswerENT">目标对象</param>
public void CopyTo(clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerENS, clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerENT)
{
objvQuestionnaire_AnswerENT.QuestionId = objvQuestionnaire_AnswerENS.QuestionId; //题目Id
objvQuestionnaire_AnswerENT.AnswerIndex = objvQuestionnaire_AnswerENS.AnswerIndex; //问答序号
objvQuestionnaire_AnswerENT.AnswerContent = objvQuestionnaire_AnswerENS.AnswerContent; //答案内容
objvQuestionnaire_AnswerENT.Provider = objvQuestionnaire_AnswerENS.Provider; //提供者
objvQuestionnaire_AnswerENT.Score = objvQuestionnaire_AnswerENS.Score; //得分
objvQuestionnaire_AnswerENT.QuestionIndex = objvQuestionnaire_AnswerENS.QuestionIndex; //题目序号
objvQuestionnaire_AnswerENT.QuestionName = objvQuestionnaire_AnswerENS.QuestionName; //题目名称
objvQuestionnaire_AnswerENT.ChapterId = objvQuestionnaire_AnswerENS.ChapterId; //章Id
objvQuestionnaire_AnswerENT.SectionId = objvQuestionnaire_AnswerENS.SectionId; //节Id
objvQuestionnaire_AnswerENT.ChapterName = objvQuestionnaire_AnswerENS.ChapterName; //章名
objvQuestionnaire_AnswerENT.SectionName = objvQuestionnaire_AnswerENS.SectionName; //节名
objvQuestionnaire_AnswerENT.ChapterNameSim = objvQuestionnaire_AnswerENS.ChapterNameSim; //章名简称
objvQuestionnaire_AnswerENT.SectionNameSim = objvQuestionnaire_AnswerENS.SectionNameSim; //节名简称
objvQuestionnaire_AnswerENT.QuestionTypeId = objvQuestionnaire_AnswerENS.QuestionTypeId; //题目类型Id
objvQuestionnaire_AnswerENT.GridTitle = objvQuestionnaire_AnswerENS.GridTitle; //表格标题
objvQuestionnaire_AnswerENT.AnswerModeId = objvQuestionnaire_AnswerENS.AnswerModeId; //答案模式Id
objvQuestionnaire_AnswerENT.IsShow = objvQuestionnaire_AnswerENS.IsShow; //是否启用
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQuestionnaire_AnswerEN.Provider, 18, convQuestionnaire_Answer.Provider);
clsCheckSql.CheckFieldLen(objvQuestionnaire_AnswerEN.QuestionName, 500, convQuestionnaire_Answer.QuestionName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_AnswerEN.ChapterId, 8, convQuestionnaire_Answer.ChapterId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_AnswerEN.SectionId, 8, convQuestionnaire_Answer.SectionId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_AnswerEN.ChapterName, 100, convQuestionnaire_Answer.ChapterName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_AnswerEN.SectionName, 100, convQuestionnaire_Answer.SectionName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_AnswerEN.ChapterNameSim, 10, convQuestionnaire_Answer.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvQuestionnaire_AnswerEN.SectionNameSim, 10, convQuestionnaire_Answer.SectionNameSim);
clsCheckSql.CheckFieldLen(objvQuestionnaire_AnswerEN.QuestionTypeId, 2, convQuestionnaire_Answer.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_AnswerEN.GridTitle, 30, convQuestionnaire_Answer.GridTitle);
clsCheckSql.CheckFieldLen(objvQuestionnaire_AnswerEN.AnswerModeId, 4, convQuestionnaire_Answer.AnswerModeId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_AnswerEN.Provider, convQuestionnaire_Answer.Provider);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_AnswerEN.QuestionName, convQuestionnaire_Answer.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_AnswerEN.ChapterId, convQuestionnaire_Answer.ChapterId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_AnswerEN.SectionId, convQuestionnaire_Answer.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_AnswerEN.ChapterName, convQuestionnaire_Answer.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_AnswerEN.SectionName, convQuestionnaire_Answer.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_AnswerEN.ChapterNameSim, convQuestionnaire_Answer.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_AnswerEN.SectionNameSim, convQuestionnaire_Answer.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_AnswerEN.QuestionTypeId, convQuestionnaire_Answer.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_AnswerEN.GridTitle, convQuestionnaire_Answer.GridTitle);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_AnswerEN.AnswerModeId, convQuestionnaire_Answer.AnswerModeId);
//检查外键字段长度
 objvQuestionnaire_AnswerEN._IsCheckProperty = true;
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
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQuestionnaire_AnswerEN._CurrTabName);
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
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQuestionnaire_AnswerEN._CurrTabName, strCondition);
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
 objSQL = clsvQuestionnaire_AnswerDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}