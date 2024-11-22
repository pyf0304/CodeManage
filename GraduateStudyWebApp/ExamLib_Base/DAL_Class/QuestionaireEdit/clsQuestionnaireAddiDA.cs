
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionnaireAddiDA
 表名:QuestionnaireAddi(01120886)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:54
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
 /// 题目附加(QuestionnaireAddi)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQuestionnaireAddiDA : clsCommBase4DA
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
 return clsQuestionnaireAddiEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQuestionnaireAddiEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQuestionnaireAddiEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQuestionnaireAddiEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQuestionnaireAddiEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQuestionnaireAddiDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireAddi where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QuestionnaireAddi(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQuestionnaireAddiDA: GetDataTable_QuestionnaireAddi)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireAddi where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQuestionnaireAddiDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQuestionnaireAddiDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireAddi where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQuestionnaireAddiDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQuestionnaireAddiDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireAddi where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireAddi where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQuestionnaireAddiDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QuestionnaireAddi where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQuestionnaireAddiDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QuestionnaireAddi.* from QuestionnaireAddi Left Join {1} on {2} where {3} and QuestionnaireAddi.QuestionId not in (Select top {5} QuestionnaireAddi.QuestionId from QuestionnaireAddi Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireAddi where {1} and QuestionId not in (Select top {2} QuestionId from QuestionnaireAddi where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireAddi where {1} and QuestionId not in (Select top {3} QuestionId from QuestionnaireAddi where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQuestionnaireAddiDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QuestionnaireAddi.* from QuestionnaireAddi Left Join {1} on {2} where {3} and QuestionnaireAddi.QuestionId not in (Select top {5} QuestionnaireAddi.QuestionId from QuestionnaireAddi Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireAddi where {1} and QuestionId not in (Select top {2} QuestionId from QuestionnaireAddi where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireAddi where {1} and QuestionId not in (Select top {3} QuestionId from QuestionnaireAddi where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsQuestionnaireAddiEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQuestionnaireAddiDA:GetObjLst)", objException.Message));
}
List<clsQuestionnaireAddiEN> arrObjLst = new List<clsQuestionnaireAddiEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireAddi where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN();
try
{
objQuestionnaireAddiEN.QuestionId = TransNullToInt(objRow[conQuestionnaireAddi.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireAddiEN.QuestionIndex = objRow[conQuestionnaireAddi.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireAddiEN.QuestionName = objRow[conQuestionnaireAddi.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireAddiEN.QuestionContent = objRow[conQuestionnaireAddi.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireAddiEN.QuestionMemo = objRow[conQuestionnaireAddi.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireAddiEN.QuestionNo = objRow[conQuestionnaireAddi.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireAddiEN.ParentQuestionId = objRow[conQuestionnaireAddi.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireAddiEN.ExamAnswer = objRow[conQuestionnaireAddi.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireAddiEN.CourseId = objRow[conQuestionnaireAddi.CourseId].ToString().Trim(); //课程Id
objQuestionnaireAddiEN.LevelNo = objRow[conQuestionnaireAddi.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireAddiEN.CourseChapterId = objRow[conQuestionnaireAddi.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireAddiEN.QuestionTypeId = objRow[conQuestionnaireAddi.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireAddiEN.QuestionTypeId4Course = objRow[conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireAddiEN.ExamGradeId = objRow[conQuestionnaireAddi.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireAddiEN.AnswerTypeId = objRow[conQuestionnaireAddi.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireAddiEN.GridTitle = objRow[conQuestionnaireAddi.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaireAddi.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireAddiEN.AnswerModeId = objRow[conQuestionnaireAddi.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireAddiEN.IsHaveAdditionalMemo = TransNullToBool(objRow[conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireAddiEN.QuestionnaireSetId = objRow[conQuestionnaireAddi.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireAddiEN.QuestionScore = objRow[conQuestionnaireAddi.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conQuestionnaireAddi.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireAddiEN.QuestionNameAdd = objRow[conQuestionnaireAddi.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireAddiEN.DefaultValue = objRow[conQuestionnaireAddi.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireAddiEN.TextDirectId = objRow[conQuestionnaireAddi.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireAddiEN.FillInTextWidth = objRow[conQuestionnaireAddi.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireAddiEN.MemoTextWidth = objRow[conQuestionnaireAddi.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireAddiEN.CodeTab = objRow[conQuestionnaireAddi.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTab].ToString().Trim(); //代码表
objQuestionnaireAddiEN.CodeTabCode = objRow[conQuestionnaireAddi.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireAddiEN.CodeTabName = objRow[conQuestionnaireAddi.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireAddiEN.CodeTabCondition = objRow[conQuestionnaireAddi.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireAddiEN.RelaEvent = objRow[conQuestionnaireAddi.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireAddiEN.FirstIndent = TransNullToBool(objRow[conQuestionnaireAddi.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireAddiEN.DefaultSelectItem = objRow[conQuestionnaireAddi.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireAddiEN.IfLinkage = TransNullToBool(objRow[conQuestionnaireAddi.IfLinkage].ToString().Trim()); //是否联动
objQuestionnaireAddiEN.LinkageIndex = objRow[conQuestionnaireAddi.LinkageIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.LinkageIndex].ToString().Trim()); //联动题序号
objQuestionnaireAddiEN.IsAutoGridTitle = TransNullToBool(objRow[conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objQuestionnaireAddiEN.FillInTextHeight = objRow[conQuestionnaireAddi.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireAddiEN.IsMulti4FillInText = TransNullToBool(objRow[conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireAddiEN.CheckBoxLimitCount = objRow[conQuestionnaireAddi.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireAddiEN.RoleId = objRow[conQuestionnaireAddi.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RoleId].ToString().Trim(); //角色Id
objQuestionnaireAddiEN.IsShow = TransNullToBool(objRow[conQuestionnaireAddi.IsShow].ToString().Trim()); //是否启用
objQuestionnaireAddiEN.IsCast = TransNullToBool(objRow[conQuestionnaireAddi.IsCast].ToString().Trim()); //是否播放
objQuestionnaireAddiEN.LikeCount = objRow[conQuestionnaireAddi.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaireAddi.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireAddiEN.AnswerAttLimitSize = objRow[conQuestionnaireAddi.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireAddiEN.LimitedResourceType = objRow[conQuestionnaireAddi.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaireAddi.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireAddiEN.IsEffective = TransNullToBool(objRow[conQuestionnaireAddi.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireAddiEN.IsCanInPaper = TransNullToBool(objRow[conQuestionnaireAddi.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireAddiEN.UpdDate = objRow[conQuestionnaireAddi.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireAddiEN.UpdUser = objRow[conQuestionnaireAddi.UpdUser].ToString().Trim(); //修改人
objQuestionnaireAddiEN.Memo = objRow[conQuestionnaireAddi.Memo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQuestionnaireAddiDA: GetObjLst)", objException.Message));
}
objQuestionnaireAddiEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQuestionnaireAddiEN);
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
public List<clsQuestionnaireAddiEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQuestionnaireAddiDA:GetObjLstByTabName)", objException.Message));
}
List<clsQuestionnaireAddiEN> arrObjLst = new List<clsQuestionnaireAddiEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN();
try
{
objQuestionnaireAddiEN.QuestionId = TransNullToInt(objRow[conQuestionnaireAddi.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireAddiEN.QuestionIndex = objRow[conQuestionnaireAddi.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireAddiEN.QuestionName = objRow[conQuestionnaireAddi.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireAddiEN.QuestionContent = objRow[conQuestionnaireAddi.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireAddiEN.QuestionMemo = objRow[conQuestionnaireAddi.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireAddiEN.QuestionNo = objRow[conQuestionnaireAddi.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireAddiEN.ParentQuestionId = objRow[conQuestionnaireAddi.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireAddiEN.ExamAnswer = objRow[conQuestionnaireAddi.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireAddiEN.CourseId = objRow[conQuestionnaireAddi.CourseId].ToString().Trim(); //课程Id
objQuestionnaireAddiEN.LevelNo = objRow[conQuestionnaireAddi.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireAddiEN.CourseChapterId = objRow[conQuestionnaireAddi.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireAddiEN.QuestionTypeId = objRow[conQuestionnaireAddi.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireAddiEN.QuestionTypeId4Course = objRow[conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireAddiEN.ExamGradeId = objRow[conQuestionnaireAddi.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireAddiEN.AnswerTypeId = objRow[conQuestionnaireAddi.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireAddiEN.GridTitle = objRow[conQuestionnaireAddi.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaireAddi.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireAddiEN.AnswerModeId = objRow[conQuestionnaireAddi.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireAddiEN.IsHaveAdditionalMemo = TransNullToBool(objRow[conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireAddiEN.QuestionnaireSetId = objRow[conQuestionnaireAddi.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireAddiEN.QuestionScore = objRow[conQuestionnaireAddi.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conQuestionnaireAddi.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireAddiEN.QuestionNameAdd = objRow[conQuestionnaireAddi.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireAddiEN.DefaultValue = objRow[conQuestionnaireAddi.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireAddiEN.TextDirectId = objRow[conQuestionnaireAddi.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireAddiEN.FillInTextWidth = objRow[conQuestionnaireAddi.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireAddiEN.MemoTextWidth = objRow[conQuestionnaireAddi.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireAddiEN.CodeTab = objRow[conQuestionnaireAddi.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTab].ToString().Trim(); //代码表
objQuestionnaireAddiEN.CodeTabCode = objRow[conQuestionnaireAddi.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireAddiEN.CodeTabName = objRow[conQuestionnaireAddi.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireAddiEN.CodeTabCondition = objRow[conQuestionnaireAddi.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireAddiEN.RelaEvent = objRow[conQuestionnaireAddi.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireAddiEN.FirstIndent = TransNullToBool(objRow[conQuestionnaireAddi.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireAddiEN.DefaultSelectItem = objRow[conQuestionnaireAddi.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireAddiEN.IfLinkage = TransNullToBool(objRow[conQuestionnaireAddi.IfLinkage].ToString().Trim()); //是否联动
objQuestionnaireAddiEN.LinkageIndex = objRow[conQuestionnaireAddi.LinkageIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.LinkageIndex].ToString().Trim()); //联动题序号
objQuestionnaireAddiEN.IsAutoGridTitle = TransNullToBool(objRow[conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objQuestionnaireAddiEN.FillInTextHeight = objRow[conQuestionnaireAddi.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireAddiEN.IsMulti4FillInText = TransNullToBool(objRow[conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireAddiEN.CheckBoxLimitCount = objRow[conQuestionnaireAddi.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireAddiEN.RoleId = objRow[conQuestionnaireAddi.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RoleId].ToString().Trim(); //角色Id
objQuestionnaireAddiEN.IsShow = TransNullToBool(objRow[conQuestionnaireAddi.IsShow].ToString().Trim()); //是否启用
objQuestionnaireAddiEN.IsCast = TransNullToBool(objRow[conQuestionnaireAddi.IsCast].ToString().Trim()); //是否播放
objQuestionnaireAddiEN.LikeCount = objRow[conQuestionnaireAddi.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaireAddi.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireAddiEN.AnswerAttLimitSize = objRow[conQuestionnaireAddi.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireAddiEN.LimitedResourceType = objRow[conQuestionnaireAddi.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaireAddi.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireAddiEN.IsEffective = TransNullToBool(objRow[conQuestionnaireAddi.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireAddiEN.IsCanInPaper = TransNullToBool(objRow[conQuestionnaireAddi.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireAddiEN.UpdDate = objRow[conQuestionnaireAddi.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireAddiEN.UpdUser = objRow[conQuestionnaireAddi.UpdUser].ToString().Trim(); //修改人
objQuestionnaireAddiEN.Memo = objRow[conQuestionnaireAddi.Memo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQuestionnaireAddiDA: GetObjLst)", objException.Message));
}
objQuestionnaireAddiEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQuestionnaireAddiEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQuestionnaireAddi(ref clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireAddi where QuestionId = " + ""+ objQuestionnaireAddiEN.QuestionId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQuestionnaireAddiEN.QuestionId = TransNullToInt(objDT.Rows[0][conQuestionnaireAddi.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objQuestionnaireAddiEN.QuestionIndex = TransNullToInt(objDT.Rows[0][conQuestionnaireAddi.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.QuestionName = objDT.Rows[0][conQuestionnaireAddi.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objQuestionnaireAddiEN.QuestionContent = objDT.Rows[0][conQuestionnaireAddi.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objQuestionnaireAddiEN.QuestionMemo = objDT.Rows[0][conQuestionnaireAddi.QuestionMemo].ToString().Trim(); //题目说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objQuestionnaireAddiEN.QuestionNo = objDT.Rows[0][conQuestionnaireAddi.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objQuestionnaireAddiEN.ParentQuestionId = objDT.Rows[0][conQuestionnaireAddi.ParentQuestionId].ToString().Trim(); //父题目Id(字段类型:char,字段长度:8,是否可空:True)
 objQuestionnaireAddiEN.ExamAnswer = objDT.Rows[0][conQuestionnaireAddi.ExamAnswer].ToString().Trim(); //题目答案(字段类型:varchar,字段长度:8000,是否可空:True)
 objQuestionnaireAddiEN.CourseId = objDT.Rows[0][conQuestionnaireAddi.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objQuestionnaireAddiEN.LevelNo = TransNullToInt(objDT.Rows[0][conQuestionnaireAddi.LevelNo].ToString().Trim()); //学习关号2(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.CourseChapterId = objDT.Rows[0][conQuestionnaireAddi.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objQuestionnaireAddiEN.QuestionTypeId = objDT.Rows[0][conQuestionnaireAddi.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objQuestionnaireAddiEN.QuestionTypeId4Course = objDT.Rows[0][conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
 objQuestionnaireAddiEN.ExamGradeId = objDT.Rows[0][conQuestionnaireAddi.ExamGradeId].ToString().Trim(); //题库等级ID(字段类型:char,字段长度:2,是否可空:True)
 objQuestionnaireAddiEN.AnswerTypeId = objDT.Rows[0][conQuestionnaireAddi.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objQuestionnaireAddiEN.GridTitle = objDT.Rows[0][conQuestionnaireAddi.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objQuestionnaireAddiEN.AnswerModeId = objDT.Rows[0][conQuestionnaireAddi.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.IsHaveAdditionalMemo = TransNullToBool(objDT.Rows[0][conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.QuestionnaireSetId = objDT.Rows[0][conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.QuestionScore = TransNullToFloat(objDT.Rows[0][conQuestionnaireAddi.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objQuestionnaireAddiEN.QuestionNameAdd = objDT.Rows[0][conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(); //题目补充(字段类型:varchar,字段长度:500,是否可空:True)
 objQuestionnaireAddiEN.DefaultValue = objDT.Rows[0][conQuestionnaireAddi.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireAddiEN.TextDirectId = objDT.Rows[0][conQuestionnaireAddi.TextDirectId].ToString().Trim(); //文本方向ID(字段类型:char,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.FillInTextWidth = TransNullToInt(objDT.Rows[0][conQuestionnaireAddi.FillInTextWidth].ToString().Trim()); //填空框宽度(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.MemoTextWidth = TransNullToInt(objDT.Rows[0][conQuestionnaireAddi.MemoTextWidth].ToString().Trim()); //备注框宽度(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.CodeTab = objDT.Rows[0][conQuestionnaireAddi.CodeTab].ToString().Trim(); //代码表(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireAddiEN.CodeTabCode = objDT.Rows[0][conQuestionnaireAddi.CodeTabCode].ToString().Trim(); //CodeTab_Code(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireAddiEN.CodeTabName = objDT.Rows[0][conQuestionnaireAddi.CodeTabName].ToString().Trim(); //CodeTab_Name(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireAddiEN.CodeTabCondition = objDT.Rows[0][conQuestionnaireAddi.CodeTabCondition].ToString().Trim(); //代码表_条件(字段类型:varchar,字段长度:200,是否可空:True)
 objQuestionnaireAddiEN.RelaEvent = objDT.Rows[0][conQuestionnaireAddi.RelaEvent].ToString().Trim(); //相关事件(字段类型:varchar,字段长度:4000,是否可空:True)
 objQuestionnaireAddiEN.FirstIndent = TransNullToBool(objDT.Rows[0][conQuestionnaireAddi.FirstIndent].ToString().Trim()); //首行缩进(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.DefaultSelectItem = objDT.Rows[0][conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(); //默认选项(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireAddiEN.IfLinkage = TransNullToBool(objDT.Rows[0][conQuestionnaireAddi.IfLinkage].ToString().Trim()); //是否联动(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.LinkageIndex = TransNullToInt(objDT.Rows[0][conQuestionnaireAddi.LinkageIndex].ToString().Trim()); //联动题序号(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.IsAutoGridTitle = TransNullToBool(objDT.Rows[0][conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.FillInTextHeight = TransNullToInt(objDT.Rows[0][conQuestionnaireAddi.FillInTextHeight].ToString().Trim()); //填空框高度(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.IsMulti4FillInText = TransNullToBool(objDT.Rows[0][conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim()); //是否填空框多行(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.CheckBoxLimitCount = TransNullToInt(objDT.Rows[0][conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim()); //复选框限制数(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.RoleId = objDT.Rows[0][conQuestionnaireAddi.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQuestionnaireAddiEN.IsShow = TransNullToBool(objDT.Rows[0][conQuestionnaireAddi.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.IsCast = TransNullToBool(objDT.Rows[0][conQuestionnaireAddi.IsCast].ToString().Trim()); //是否播放(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.LikeCount = TransNullToInt(objDT.Rows[0][conQuestionnaireAddi.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objQuestionnaireAddiEN.AnswerAttLimitSize = TransNullToInt(objDT.Rows[0][conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小(字段类型:bigint,字段长度:8,是否可空:True)
 objQuestionnaireAddiEN.LimitedResourceType = objDT.Rows[0][conQuestionnaireAddi.LimitedResourceType].ToString().Trim(); //限制资源类型(字段类型:varchar,字段长度:100,是否可空:True)
 objQuestionnaireAddiEN.IsEffective = TransNullToBool(objDT.Rows[0][conQuestionnaireAddi.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.IsCanInPaper = TransNullToBool(objDT.Rows[0][conQuestionnaireAddi.IsCanInPaper].ToString().Trim()); //是否可在Paper(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.UpdDate = objDT.Rows[0][conQuestionnaireAddi.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireAddiEN.UpdUser = objDT.Rows[0][conQuestionnaireAddi.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireAddiEN.Memo = objDT.Rows[0][conQuestionnaireAddi.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQuestionnaireAddiDA: GetQuestionnaireAddi)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public clsQuestionnaireAddiEN GetObjByQuestionId(long lngQuestionId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireAddi where QuestionId = " + ""+ lngQuestionId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN();
try
{
 objQuestionnaireAddiEN.QuestionId = Int32.Parse(objRow[conQuestionnaireAddi.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objQuestionnaireAddiEN.QuestionIndex = objRow[conQuestionnaireAddi.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.QuestionName = objRow[conQuestionnaireAddi.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objQuestionnaireAddiEN.QuestionContent = objRow[conQuestionnaireAddi.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objQuestionnaireAddiEN.QuestionMemo = objRow[conQuestionnaireAddi.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionMemo].ToString().Trim(); //题目说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objQuestionnaireAddiEN.QuestionNo = objRow[conQuestionnaireAddi.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objQuestionnaireAddiEN.ParentQuestionId = objRow[conQuestionnaireAddi.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ParentQuestionId].ToString().Trim(); //父题目Id(字段类型:char,字段长度:8,是否可空:True)
 objQuestionnaireAddiEN.ExamAnswer = objRow[conQuestionnaireAddi.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamAnswer].ToString().Trim(); //题目答案(字段类型:varchar,字段长度:8000,是否可空:True)
 objQuestionnaireAddiEN.CourseId = objRow[conQuestionnaireAddi.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objQuestionnaireAddiEN.LevelNo = objRow[conQuestionnaireAddi.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LevelNo].ToString().Trim()); //学习关号2(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.CourseChapterId = objRow[conQuestionnaireAddi.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objQuestionnaireAddiEN.QuestionTypeId = objRow[conQuestionnaireAddi.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objQuestionnaireAddiEN.QuestionTypeId4Course = objRow[conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
 objQuestionnaireAddiEN.ExamGradeId = objRow[conQuestionnaireAddi.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamGradeId].ToString().Trim(); //题库等级ID(字段类型:char,字段长度:2,是否可空:True)
 objQuestionnaireAddiEN.AnswerTypeId = objRow[conQuestionnaireAddi.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objQuestionnaireAddiEN.GridTitle = objRow[conQuestionnaireAddi.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaireAddi.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objQuestionnaireAddiEN.AnswerModeId = objRow[conQuestionnaireAddi.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.QuestionnaireSetId = objRow[conQuestionnaireAddi.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.QuestionScore = objRow[conQuestionnaireAddi.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaireAddi.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objQuestionnaireAddiEN.QuestionNameAdd = objRow[conQuestionnaireAddi.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(); //题目补充(字段类型:varchar,字段长度:500,是否可空:True)
 objQuestionnaireAddiEN.DefaultValue = objRow[conQuestionnaireAddi.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireAddiEN.TextDirectId = objRow[conQuestionnaireAddi.TextDirectId].ToString().Trim(); //文本方向ID(字段类型:char,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.FillInTextWidth = objRow[conQuestionnaireAddi.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextWidth].ToString().Trim()); //填空框宽度(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.MemoTextWidth = objRow[conQuestionnaireAddi.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.MemoTextWidth].ToString().Trim()); //备注框宽度(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.CodeTab = objRow[conQuestionnaireAddi.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTab].ToString().Trim(); //代码表(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireAddiEN.CodeTabCode = objRow[conQuestionnaireAddi.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCode].ToString().Trim(); //CodeTab_Code(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireAddiEN.CodeTabName = objRow[conQuestionnaireAddi.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabName].ToString().Trim(); //CodeTab_Name(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireAddiEN.CodeTabCondition = objRow[conQuestionnaireAddi.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCondition].ToString().Trim(); //代码表_条件(字段类型:varchar,字段长度:200,是否可空:True)
 objQuestionnaireAddiEN.RelaEvent = objRow[conQuestionnaireAddi.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RelaEvent].ToString().Trim(); //相关事件(字段类型:varchar,字段长度:4000,是否可空:True)
 objQuestionnaireAddiEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.FirstIndent].ToString().Trim()); //首行缩进(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.DefaultSelectItem = objRow[conQuestionnaireAddi.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(); //默认选项(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireAddiEN.IfLinkage = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IfLinkage].ToString().Trim()); //是否联动(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.LinkageIndex = objRow[conQuestionnaireAddi.LinkageIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LinkageIndex].ToString().Trim()); //联动题序号(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.IsAutoGridTitle = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.FillInTextHeight = objRow[conQuestionnaireAddi.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.FillInTextHeight].ToString().Trim()); //填空框高度(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim()); //是否填空框多行(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.CheckBoxLimitCount = objRow[conQuestionnaireAddi.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim()); //复选框限制数(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireAddiEN.RoleId = objRow[conQuestionnaireAddi.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objQuestionnaireAddiEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCast].ToString().Trim()); //是否播放(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.LikeCount = objRow[conQuestionnaireAddi.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objQuestionnaireAddiEN.AnswerAttLimitSize = objRow[conQuestionnaireAddi.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小(字段类型:bigint,字段长度:8,是否可空:True)
 objQuestionnaireAddiEN.LimitedResourceType = objRow[conQuestionnaireAddi.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaireAddi.LimitedResourceType].ToString().Trim(); //限制资源类型(字段类型:varchar,字段长度:100,是否可空:True)
 objQuestionnaireAddiEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireAddi.IsCanInPaper].ToString().Trim()); //是否可在Paper(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireAddiEN.UpdDate = objRow[conQuestionnaireAddi.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireAddiEN.UpdUser = objRow[conQuestionnaireAddi.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireAddiEN.Memo = objRow[conQuestionnaireAddi.Memo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQuestionnaireAddiDA: GetObjByQuestionId)", objException.Message));
}
return objQuestionnaireAddiEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQuestionnaireAddiEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQuestionnaireAddiDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireAddi where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN()
{
QuestionId = TransNullToInt(objRow[conQuestionnaireAddi.QuestionId].ToString().Trim()), //题目Id
QuestionIndex = objRow[conQuestionnaireAddi.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.QuestionIndex].ToString().Trim()), //题目序号
QuestionName = objRow[conQuestionnaireAddi.QuestionName].ToString().Trim(), //题目名称
QuestionContent = objRow[conQuestionnaireAddi.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionContent].ToString().Trim(), //题目内容
QuestionMemo = objRow[conQuestionnaireAddi.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionMemo].ToString().Trim(), //题目说明
QuestionNo = objRow[conQuestionnaireAddi.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNo].ToString().Trim(), //题目编号
ParentQuestionId = objRow[conQuestionnaireAddi.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ParentQuestionId].ToString().Trim(), //父题目Id
ExamAnswer = objRow[conQuestionnaireAddi.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamAnswer].ToString().Trim(), //题目答案
CourseId = objRow[conQuestionnaireAddi.CourseId].ToString().Trim(), //课程Id
LevelNo = objRow[conQuestionnaireAddi.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.LevelNo].ToString().Trim()), //学习关号2
CourseChapterId = objRow[conQuestionnaireAddi.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CourseChapterId].ToString().Trim(), //课程章节ID
QuestionTypeId = objRow[conQuestionnaireAddi.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionTypeId4Course = objRow[conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(), //题目类型Id4课程
ExamGradeId = objRow[conQuestionnaireAddi.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamGradeId].ToString().Trim(), //题库等级ID
AnswerTypeId = objRow[conQuestionnaireAddi.AnswerTypeId].ToString().Trim(), //答案类型ID
GridTitle = objRow[conQuestionnaireAddi.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaireAddi.GridTitle].ToString().Trim(), //表格标题
AnswerModeId = objRow[conQuestionnaireAddi.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.AnswerModeId].ToString().Trim(), //答案模式Id
IsHaveAdditionalMemo = TransNullToBool(objRow[conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim()), //是否有附加说明
QuestionnaireSetId = objRow[conQuestionnaireAddi.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(), //问卷集ID
QuestionScore = objRow[conQuestionnaireAddi.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conQuestionnaireAddi.QuestionScore].ToString().Trim()), //题目得分
QuestionNameAdd = objRow[conQuestionnaireAddi.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(), //题目补充
DefaultValue = objRow[conQuestionnaireAddi.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultValue].ToString().Trim(), //缺省值
TextDirectId = objRow[conQuestionnaireAddi.TextDirectId].ToString().Trim(), //文本方向ID
FillInTextWidth = objRow[conQuestionnaireAddi.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.FillInTextWidth].ToString().Trim()), //填空框宽度
MemoTextWidth = objRow[conQuestionnaireAddi.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.MemoTextWidth].ToString().Trim()), //备注框宽度
CodeTab = objRow[conQuestionnaireAddi.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTab].ToString().Trim(), //代码表
CodeTabCode = objRow[conQuestionnaireAddi.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCode].ToString().Trim(), //CodeTab_Code
CodeTabName = objRow[conQuestionnaireAddi.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabName].ToString().Trim(), //CodeTab_Name
CodeTabCondition = objRow[conQuestionnaireAddi.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCondition].ToString().Trim(), //代码表_条件
RelaEvent = objRow[conQuestionnaireAddi.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RelaEvent].ToString().Trim(), //相关事件
FirstIndent = TransNullToBool(objRow[conQuestionnaireAddi.FirstIndent].ToString().Trim()), //首行缩进
DefaultSelectItem = objRow[conQuestionnaireAddi.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(), //默认选项
IfLinkage = TransNullToBool(objRow[conQuestionnaireAddi.IfLinkage].ToString().Trim()), //是否联动
LinkageIndex = objRow[conQuestionnaireAddi.LinkageIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.LinkageIndex].ToString().Trim()), //联动题序号
IsAutoGridTitle = TransNullToBool(objRow[conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim()), //是否自动编表格标题
FillInTextHeight = objRow[conQuestionnaireAddi.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.FillInTextHeight].ToString().Trim()), //填空框高度
IsMulti4FillInText = TransNullToBool(objRow[conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim()), //是否填空框多行
CheckBoxLimitCount = objRow[conQuestionnaireAddi.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim()), //复选框限制数
RoleId = objRow[conQuestionnaireAddi.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RoleId].ToString().Trim(), //角色Id
IsShow = TransNullToBool(objRow[conQuestionnaireAddi.IsShow].ToString().Trim()), //是否启用
IsCast = TransNullToBool(objRow[conQuestionnaireAddi.IsCast].ToString().Trim()), //是否播放
LikeCount = objRow[conQuestionnaireAddi.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaireAddi.LikeCount].ToString().Trim()), //资源喜欢数量
AnswerAttLimitSize = objRow[conQuestionnaireAddi.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim()), //回答附件限制大小
LimitedResourceType = objRow[conQuestionnaireAddi.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaireAddi.LimitedResourceType].ToString().Trim(), //限制资源类型
IsEffective = TransNullToBool(objRow[conQuestionnaireAddi.IsEffective].ToString().Trim()), //是否有效
IsCanInPaper = TransNullToBool(objRow[conQuestionnaireAddi.IsCanInPaper].ToString().Trim()), //是否可在Paper
UpdDate = objRow[conQuestionnaireAddi.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conQuestionnaireAddi.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conQuestionnaireAddi.Memo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.Memo].ToString().Trim() //备注
};
objQuestionnaireAddiEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQuestionnaireAddiEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQuestionnaireAddiDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQuestionnaireAddiEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN();
try
{
objQuestionnaireAddiEN.QuestionId = TransNullToInt(objRow[conQuestionnaireAddi.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireAddiEN.QuestionIndex = objRow[conQuestionnaireAddi.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireAddiEN.QuestionName = objRow[conQuestionnaireAddi.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireAddiEN.QuestionContent = objRow[conQuestionnaireAddi.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireAddiEN.QuestionMemo = objRow[conQuestionnaireAddi.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireAddiEN.QuestionNo = objRow[conQuestionnaireAddi.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireAddiEN.ParentQuestionId = objRow[conQuestionnaireAddi.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireAddiEN.ExamAnswer = objRow[conQuestionnaireAddi.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireAddiEN.CourseId = objRow[conQuestionnaireAddi.CourseId].ToString().Trim(); //课程Id
objQuestionnaireAddiEN.LevelNo = objRow[conQuestionnaireAddi.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireAddiEN.CourseChapterId = objRow[conQuestionnaireAddi.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireAddiEN.QuestionTypeId = objRow[conQuestionnaireAddi.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireAddiEN.QuestionTypeId4Course = objRow[conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireAddiEN.ExamGradeId = objRow[conQuestionnaireAddi.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireAddiEN.AnswerTypeId = objRow[conQuestionnaireAddi.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireAddiEN.GridTitle = objRow[conQuestionnaireAddi.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaireAddi.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireAddiEN.AnswerModeId = objRow[conQuestionnaireAddi.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireAddiEN.IsHaveAdditionalMemo = TransNullToBool(objRow[conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireAddiEN.QuestionnaireSetId = objRow[conQuestionnaireAddi.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireAddiEN.QuestionScore = objRow[conQuestionnaireAddi.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conQuestionnaireAddi.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireAddiEN.QuestionNameAdd = objRow[conQuestionnaireAddi.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireAddiEN.DefaultValue = objRow[conQuestionnaireAddi.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireAddiEN.TextDirectId = objRow[conQuestionnaireAddi.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireAddiEN.FillInTextWidth = objRow[conQuestionnaireAddi.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireAddiEN.MemoTextWidth = objRow[conQuestionnaireAddi.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireAddiEN.CodeTab = objRow[conQuestionnaireAddi.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTab].ToString().Trim(); //代码表
objQuestionnaireAddiEN.CodeTabCode = objRow[conQuestionnaireAddi.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireAddiEN.CodeTabName = objRow[conQuestionnaireAddi.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireAddiEN.CodeTabCondition = objRow[conQuestionnaireAddi.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireAddiEN.RelaEvent = objRow[conQuestionnaireAddi.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireAddiEN.FirstIndent = TransNullToBool(objRow[conQuestionnaireAddi.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireAddiEN.DefaultSelectItem = objRow[conQuestionnaireAddi.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireAddiEN.IfLinkage = TransNullToBool(objRow[conQuestionnaireAddi.IfLinkage].ToString().Trim()); //是否联动
objQuestionnaireAddiEN.LinkageIndex = objRow[conQuestionnaireAddi.LinkageIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.LinkageIndex].ToString().Trim()); //联动题序号
objQuestionnaireAddiEN.IsAutoGridTitle = TransNullToBool(objRow[conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objQuestionnaireAddiEN.FillInTextHeight = objRow[conQuestionnaireAddi.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireAddiEN.IsMulti4FillInText = TransNullToBool(objRow[conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireAddiEN.CheckBoxLimitCount = objRow[conQuestionnaireAddi.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireAddiEN.RoleId = objRow[conQuestionnaireAddi.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RoleId].ToString().Trim(); //角色Id
objQuestionnaireAddiEN.IsShow = TransNullToBool(objRow[conQuestionnaireAddi.IsShow].ToString().Trim()); //是否启用
objQuestionnaireAddiEN.IsCast = TransNullToBool(objRow[conQuestionnaireAddi.IsCast].ToString().Trim()); //是否播放
objQuestionnaireAddiEN.LikeCount = objRow[conQuestionnaireAddi.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaireAddi.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireAddiEN.AnswerAttLimitSize = objRow[conQuestionnaireAddi.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireAddiEN.LimitedResourceType = objRow[conQuestionnaireAddi.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaireAddi.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireAddiEN.IsEffective = TransNullToBool(objRow[conQuestionnaireAddi.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireAddiEN.IsCanInPaper = TransNullToBool(objRow[conQuestionnaireAddi.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireAddiEN.UpdDate = objRow[conQuestionnaireAddi.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireAddiEN.UpdUser = objRow[conQuestionnaireAddi.UpdUser].ToString().Trim(); //修改人
objQuestionnaireAddiEN.Memo = objRow[conQuestionnaireAddi.Memo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQuestionnaireAddiDA: GetObjByDataRowQuestionnaireAddi)", objException.Message));
}
objQuestionnaireAddiEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQuestionnaireAddiEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQuestionnaireAddiEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQuestionnaireAddiEN objQuestionnaireAddiEN = new clsQuestionnaireAddiEN();
try
{
objQuestionnaireAddiEN.QuestionId = TransNullToInt(objRow[conQuestionnaireAddi.QuestionId].ToString().Trim()); //题目Id
objQuestionnaireAddiEN.QuestionIndex = objRow[conQuestionnaireAddi.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.QuestionIndex].ToString().Trim()); //题目序号
objQuestionnaireAddiEN.QuestionName = objRow[conQuestionnaireAddi.QuestionName].ToString().Trim(); //题目名称
objQuestionnaireAddiEN.QuestionContent = objRow[conQuestionnaireAddi.QuestionContent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionContent].ToString().Trim(); //题目内容
objQuestionnaireAddiEN.QuestionMemo = objRow[conQuestionnaireAddi.QuestionMemo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionMemo].ToString().Trim(); //题目说明
objQuestionnaireAddiEN.QuestionNo = objRow[conQuestionnaireAddi.QuestionNo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNo].ToString().Trim(); //题目编号
objQuestionnaireAddiEN.ParentQuestionId = objRow[conQuestionnaireAddi.ParentQuestionId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ParentQuestionId].ToString().Trim(); //父题目Id
objQuestionnaireAddiEN.ExamAnswer = objRow[conQuestionnaireAddi.ExamAnswer] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamAnswer].ToString().Trim(); //题目答案
objQuestionnaireAddiEN.CourseId = objRow[conQuestionnaireAddi.CourseId].ToString().Trim(); //课程Id
objQuestionnaireAddiEN.LevelNo = objRow[conQuestionnaireAddi.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.LevelNo].ToString().Trim()); //学习关号2
objQuestionnaireAddiEN.CourseChapterId = objRow[conQuestionnaireAddi.CourseChapterId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CourseChapterId].ToString().Trim(); //课程章节ID
objQuestionnaireAddiEN.QuestionTypeId = objRow[conQuestionnaireAddi.QuestionTypeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionnaireAddiEN.QuestionTypeId4Course = objRow[conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionnaireAddiEN.ExamGradeId = objRow[conQuestionnaireAddi.ExamGradeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.ExamGradeId].ToString().Trim(); //题库等级ID
objQuestionnaireAddiEN.AnswerTypeId = objRow[conQuestionnaireAddi.AnswerTypeId].ToString().Trim(); //答案类型ID
objQuestionnaireAddiEN.GridTitle = objRow[conQuestionnaireAddi.GridTitle] == DBNull.Value ? null : objRow[conQuestionnaireAddi.GridTitle].ToString().Trim(); //表格标题
objQuestionnaireAddiEN.AnswerModeId = objRow[conQuestionnaireAddi.AnswerModeId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.AnswerModeId].ToString().Trim(); //答案模式Id
objQuestionnaireAddiEN.IsHaveAdditionalMemo = TransNullToBool(objRow[conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objQuestionnaireAddiEN.QuestionnaireSetId = objRow[conQuestionnaireAddi.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireAddiEN.QuestionScore = objRow[conQuestionnaireAddi.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conQuestionnaireAddi.QuestionScore].ToString().Trim()); //题目得分
objQuestionnaireAddiEN.QuestionNameAdd = objRow[conQuestionnaireAddi.QuestionNameAdd] == DBNull.Value ? null : objRow[conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(); //题目补充
objQuestionnaireAddiEN.DefaultValue = objRow[conQuestionnaireAddi.DefaultValue] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultValue].ToString().Trim(); //缺省值
objQuestionnaireAddiEN.TextDirectId = objRow[conQuestionnaireAddi.TextDirectId].ToString().Trim(); //文本方向ID
objQuestionnaireAddiEN.FillInTextWidth = objRow[conQuestionnaireAddi.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.FillInTextWidth].ToString().Trim()); //填空框宽度
objQuestionnaireAddiEN.MemoTextWidth = objRow[conQuestionnaireAddi.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.MemoTextWidth].ToString().Trim()); //备注框宽度
objQuestionnaireAddiEN.CodeTab = objRow[conQuestionnaireAddi.CodeTab] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTab].ToString().Trim(); //代码表
objQuestionnaireAddiEN.CodeTabCode = objRow[conQuestionnaireAddi.CodeTabCode] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCode].ToString().Trim(); //CodeTab_Code
objQuestionnaireAddiEN.CodeTabName = objRow[conQuestionnaireAddi.CodeTabName] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabName].ToString().Trim(); //CodeTab_Name
objQuestionnaireAddiEN.CodeTabCondition = objRow[conQuestionnaireAddi.CodeTabCondition] == DBNull.Value ? null : objRow[conQuestionnaireAddi.CodeTabCondition].ToString().Trim(); //代码表_条件
objQuestionnaireAddiEN.RelaEvent = objRow[conQuestionnaireAddi.RelaEvent] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RelaEvent].ToString().Trim(); //相关事件
objQuestionnaireAddiEN.FirstIndent = TransNullToBool(objRow[conQuestionnaireAddi.FirstIndent].ToString().Trim()); //首行缩进
objQuestionnaireAddiEN.DefaultSelectItem = objRow[conQuestionnaireAddi.DefaultSelectItem] == DBNull.Value ? null : objRow[conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(); //默认选项
objQuestionnaireAddiEN.IfLinkage = TransNullToBool(objRow[conQuestionnaireAddi.IfLinkage].ToString().Trim()); //是否联动
objQuestionnaireAddiEN.LinkageIndex = objRow[conQuestionnaireAddi.LinkageIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.LinkageIndex].ToString().Trim()); //联动题序号
objQuestionnaireAddiEN.IsAutoGridTitle = TransNullToBool(objRow[conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim()); //是否自动编表格标题
objQuestionnaireAddiEN.FillInTextHeight = objRow[conQuestionnaireAddi.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.FillInTextHeight].ToString().Trim()); //填空框高度
objQuestionnaireAddiEN.IsMulti4FillInText = TransNullToBool(objRow[conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objQuestionnaireAddiEN.CheckBoxLimitCount = objRow[conQuestionnaireAddi.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objQuestionnaireAddiEN.RoleId = objRow[conQuestionnaireAddi.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireAddi.RoleId].ToString().Trim(); //角色Id
objQuestionnaireAddiEN.IsShow = TransNullToBool(objRow[conQuestionnaireAddi.IsShow].ToString().Trim()); //是否启用
objQuestionnaireAddiEN.IsCast = TransNullToBool(objRow[conQuestionnaireAddi.IsCast].ToString().Trim()); //是否播放
objQuestionnaireAddiEN.LikeCount = objRow[conQuestionnaireAddi.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaireAddi.LikeCount].ToString().Trim()); //资源喜欢数量
objQuestionnaireAddiEN.AnswerAttLimitSize = objRow[conQuestionnaireAddi.AnswerAttLimitSize] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objQuestionnaireAddiEN.LimitedResourceType = objRow[conQuestionnaireAddi.LimitedResourceType] == DBNull.Value ? null : objRow[conQuestionnaireAddi.LimitedResourceType].ToString().Trim(); //限制资源类型
objQuestionnaireAddiEN.IsEffective = TransNullToBool(objRow[conQuestionnaireAddi.IsEffective].ToString().Trim()); //是否有效
objQuestionnaireAddiEN.IsCanInPaper = TransNullToBool(objRow[conQuestionnaireAddi.IsCanInPaper].ToString().Trim()); //是否可在Paper
objQuestionnaireAddiEN.UpdDate = objRow[conQuestionnaireAddi.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireAddiEN.UpdUser = objRow[conQuestionnaireAddi.UpdUser].ToString().Trim(); //修改人
objQuestionnaireAddiEN.Memo = objRow[conQuestionnaireAddi.Memo] == DBNull.Value ? null : objRow[conQuestionnaireAddi.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQuestionnaireAddiDA: GetObjByDataRow)", objException.Message));
}
objQuestionnaireAddiEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQuestionnaireAddiEN;
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
objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQuestionnaireAddiEN._CurrTabName, conQuestionnaireAddi.QuestionId, 8, "");
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
objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQuestionnaireAddiEN._CurrTabName, conQuestionnaireAddi.QuestionId, 8, strPrefix);
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
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QuestionId from QuestionnaireAddi where " + strCondition;
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
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QuestionId from QuestionnaireAddi where " + strCondition;
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
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QuestionnaireAddi", "QuestionId = " + ""+ lngQuestionId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQuestionnaireAddiDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QuestionnaireAddi", strCondition))
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
objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QuestionnaireAddi");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
 {
 objQuestionnaireAddiEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireAddiEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireAddiEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireAddi where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QuestionnaireAddi");
objRow = objDS.Tables["QuestionnaireAddi"].NewRow();
objRow[conQuestionnaireAddi.QuestionId] = objQuestionnaireAddiEN.QuestionId; //题目Id
objRow[conQuestionnaireAddi.QuestionIndex] = objQuestionnaireAddiEN.QuestionIndex; //题目序号
objRow[conQuestionnaireAddi.QuestionName] = objQuestionnaireAddiEN.QuestionName; //题目名称
 if (objQuestionnaireAddiEN.QuestionContent !=  "")
 {
objRow[conQuestionnaireAddi.QuestionContent] = objQuestionnaireAddiEN.QuestionContent; //题目内容
 }
 if (objQuestionnaireAddiEN.QuestionMemo !=  "")
 {
objRow[conQuestionnaireAddi.QuestionMemo] = objQuestionnaireAddiEN.QuestionMemo; //题目说明
 }
 if (objQuestionnaireAddiEN.QuestionNo !=  "")
 {
objRow[conQuestionnaireAddi.QuestionNo] = objQuestionnaireAddiEN.QuestionNo; //题目编号
 }
 if (objQuestionnaireAddiEN.ParentQuestionId !=  "")
 {
objRow[conQuestionnaireAddi.ParentQuestionId] = objQuestionnaireAddiEN.ParentQuestionId; //父题目Id
 }
 if (objQuestionnaireAddiEN.ExamAnswer !=  "")
 {
objRow[conQuestionnaireAddi.ExamAnswer] = objQuestionnaireAddiEN.ExamAnswer; //题目答案
 }
objRow[conQuestionnaireAddi.CourseId] = objQuestionnaireAddiEN.CourseId; //课程Id
objRow[conQuestionnaireAddi.LevelNo] = objQuestionnaireAddiEN.LevelNo; //学习关号2
 if (objQuestionnaireAddiEN.CourseChapterId !=  "")
 {
objRow[conQuestionnaireAddi.CourseChapterId] = objQuestionnaireAddiEN.CourseChapterId; //课程章节ID
 }
 if (objQuestionnaireAddiEN.QuestionTypeId !=  "")
 {
objRow[conQuestionnaireAddi.QuestionTypeId] = objQuestionnaireAddiEN.QuestionTypeId; //题目类型Id
 }
objRow[conQuestionnaireAddi.QuestionTypeId4Course] = objQuestionnaireAddiEN.QuestionTypeId4Course; //题目类型Id4课程
 if (objQuestionnaireAddiEN.ExamGradeId !=  "")
 {
objRow[conQuestionnaireAddi.ExamGradeId] = objQuestionnaireAddiEN.ExamGradeId; //题库等级ID
 }
objRow[conQuestionnaireAddi.AnswerTypeId] = objQuestionnaireAddiEN.AnswerTypeId; //答案类型ID
 if (objQuestionnaireAddiEN.GridTitle !=  "")
 {
objRow[conQuestionnaireAddi.GridTitle] = objQuestionnaireAddiEN.GridTitle; //表格标题
 }
 if (objQuestionnaireAddiEN.AnswerModeId !=  "")
 {
objRow[conQuestionnaireAddi.AnswerModeId] = objQuestionnaireAddiEN.AnswerModeId; //答案模式Id
 }
objRow[conQuestionnaireAddi.IsHaveAdditionalMemo] = objQuestionnaireAddiEN.IsHaveAdditionalMemo; //是否有附加说明
 if (objQuestionnaireAddiEN.QuestionnaireSetId !=  "")
 {
objRow[conQuestionnaireAddi.QuestionnaireSetId] = objQuestionnaireAddiEN.QuestionnaireSetId; //问卷集ID
 }
objRow[conQuestionnaireAddi.QuestionScore] = objQuestionnaireAddiEN.QuestionScore; //题目得分
 if (objQuestionnaireAddiEN.QuestionNameAdd !=  "")
 {
objRow[conQuestionnaireAddi.QuestionNameAdd] = objQuestionnaireAddiEN.QuestionNameAdd; //题目补充
 }
 if (objQuestionnaireAddiEN.DefaultValue !=  "")
 {
objRow[conQuestionnaireAddi.DefaultValue] = objQuestionnaireAddiEN.DefaultValue; //缺省值
 }
objRow[conQuestionnaireAddi.TextDirectId] = objQuestionnaireAddiEN.TextDirectId; //文本方向ID
objRow[conQuestionnaireAddi.FillInTextWidth] = objQuestionnaireAddiEN.FillInTextWidth; //填空框宽度
objRow[conQuestionnaireAddi.MemoTextWidth] = objQuestionnaireAddiEN.MemoTextWidth; //备注框宽度
 if (objQuestionnaireAddiEN.CodeTab !=  "")
 {
objRow[conQuestionnaireAddi.CodeTab] = objQuestionnaireAddiEN.CodeTab; //代码表
 }
 if (objQuestionnaireAddiEN.CodeTabCode !=  "")
 {
objRow[conQuestionnaireAddi.CodeTabCode] = objQuestionnaireAddiEN.CodeTabCode; //CodeTab_Code
 }
 if (objQuestionnaireAddiEN.CodeTabName !=  "")
 {
objRow[conQuestionnaireAddi.CodeTabName] = objQuestionnaireAddiEN.CodeTabName; //CodeTab_Name
 }
 if (objQuestionnaireAddiEN.CodeTabCondition !=  "")
 {
objRow[conQuestionnaireAddi.CodeTabCondition] = objQuestionnaireAddiEN.CodeTabCondition; //代码表_条件
 }
 if (objQuestionnaireAddiEN.RelaEvent !=  "")
 {
objRow[conQuestionnaireAddi.RelaEvent] = objQuestionnaireAddiEN.RelaEvent; //相关事件
 }
objRow[conQuestionnaireAddi.FirstIndent] = objQuestionnaireAddiEN.FirstIndent; //首行缩进
 if (objQuestionnaireAddiEN.DefaultSelectItem !=  "")
 {
objRow[conQuestionnaireAddi.DefaultSelectItem] = objQuestionnaireAddiEN.DefaultSelectItem; //默认选项
 }
objRow[conQuestionnaireAddi.IfLinkage] = objQuestionnaireAddiEN.IfLinkage; //是否联动
objRow[conQuestionnaireAddi.LinkageIndex] = objQuestionnaireAddiEN.LinkageIndex; //联动题序号
objRow[conQuestionnaireAddi.IsAutoGridTitle] = objQuestionnaireAddiEN.IsAutoGridTitle; //是否自动编表格标题
objRow[conQuestionnaireAddi.FillInTextHeight] = objQuestionnaireAddiEN.FillInTextHeight; //填空框高度
objRow[conQuestionnaireAddi.IsMulti4FillInText] = objQuestionnaireAddiEN.IsMulti4FillInText; //是否填空框多行
objRow[conQuestionnaireAddi.CheckBoxLimitCount] = objQuestionnaireAddiEN.CheckBoxLimitCount; //复选框限制数
 if (objQuestionnaireAddiEN.RoleId !=  "")
 {
objRow[conQuestionnaireAddi.RoleId] = objQuestionnaireAddiEN.RoleId; //角色Id
 }
objRow[conQuestionnaireAddi.IsShow] = objQuestionnaireAddiEN.IsShow; //是否启用
objRow[conQuestionnaireAddi.IsCast] = objQuestionnaireAddiEN.IsCast; //是否播放
objRow[conQuestionnaireAddi.LikeCount] = objQuestionnaireAddiEN.LikeCount; //资源喜欢数量
objRow[conQuestionnaireAddi.AnswerAttLimitSize] = objQuestionnaireAddiEN.AnswerAttLimitSize; //回答附件限制大小
 if (objQuestionnaireAddiEN.LimitedResourceType !=  "")
 {
objRow[conQuestionnaireAddi.LimitedResourceType] = objQuestionnaireAddiEN.LimitedResourceType; //限制资源类型
 }
objRow[conQuestionnaireAddi.IsEffective] = objQuestionnaireAddiEN.IsEffective; //是否有效
objRow[conQuestionnaireAddi.IsCanInPaper] = objQuestionnaireAddiEN.IsCanInPaper; //是否可在Paper
objRow[conQuestionnaireAddi.UpdDate] = objQuestionnaireAddiEN.UpdDate; //修改日期
objRow[conQuestionnaireAddi.UpdUser] = objQuestionnaireAddiEN.UpdUser; //修改人
 if (objQuestionnaireAddiEN.Memo !=  "")
 {
objRow[conQuestionnaireAddi.Memo] = objQuestionnaireAddiEN.Memo; //备注
 }
objDS.Tables[clsQuestionnaireAddiEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQuestionnaireAddiEN._CurrTabName);
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
 /// <param name = "objQuestionnaireAddiEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
 objQuestionnaireAddiEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireAddiEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireAddiEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionId);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.QuestionId.ToString());
 
 if (objQuestionnaireAddiEN.QuestionIndex !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionIndex);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.QuestionIndex.ToString());
 }
 
 if (objQuestionnaireAddiEN.QuestionName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionName);
 var strQuestionName = objQuestionnaireAddiEN.QuestionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionName + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionContent !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionContent);
 var strQuestionContent = objQuestionnaireAddiEN.QuestionContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionContent + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionMemo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionMemo);
 var strQuestionMemo = objQuestionnaireAddiEN.QuestionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionMemo + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionNo);
 var strQuestionNo = objQuestionnaireAddiEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNo + "'");
 }
 
 if (objQuestionnaireAddiEN.ParentQuestionId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.ParentQuestionId);
 var strParentQuestionId = objQuestionnaireAddiEN.ParentQuestionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentQuestionId + "'");
 }
 
 if (objQuestionnaireAddiEN.ExamAnswer !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.ExamAnswer);
 var strExamAnswer = objQuestionnaireAddiEN.ExamAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamAnswer + "'");
 }
 
 if (objQuestionnaireAddiEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CourseId);
 var strCourseId = objQuestionnaireAddiEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objQuestionnaireAddiEN.LevelNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.LevelNo);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.LevelNo.ToString());
 }
 
 if (objQuestionnaireAddiEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CourseChapterId);
 var strCourseChapterId = objQuestionnaireAddiEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionTypeId  ==  "")
 {
 objQuestionnaireAddiEN.QuestionTypeId = null;
 }
 if (objQuestionnaireAddiEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionTypeId);
 var strQuestionTypeId = objQuestionnaireAddiEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionTypeId4Course !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionTypeId4Course);
 var strQuestionTypeId4Course = objQuestionnaireAddiEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId4Course + "'");
 }
 
 if (objQuestionnaireAddiEN.ExamGradeId  ==  "")
 {
 objQuestionnaireAddiEN.ExamGradeId = null;
 }
 if (objQuestionnaireAddiEN.ExamGradeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.ExamGradeId);
 var strExamGradeId = objQuestionnaireAddiEN.ExamGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamGradeId + "'");
 }
 
 if (objQuestionnaireAddiEN.AnswerTypeId  ==  "")
 {
 objQuestionnaireAddiEN.AnswerTypeId = null;
 }
 if (objQuestionnaireAddiEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.AnswerTypeId);
 var strAnswerTypeId = objQuestionnaireAddiEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objQuestionnaireAddiEN.GridTitle !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.GridTitle);
 var strGridTitle = objQuestionnaireAddiEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGridTitle + "'");
 }
 
 if (objQuestionnaireAddiEN.AnswerModeId  ==  "")
 {
 objQuestionnaireAddiEN.AnswerModeId = null;
 }
 if (objQuestionnaireAddiEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.AnswerModeId);
 var strAnswerModeId = objQuestionnaireAddiEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsHaveAdditionalMemo);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsHaveAdditionalMemo  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.QuestionnaireSetId  ==  "")
 {
 objQuestionnaireAddiEN.QuestionnaireSetId = null;
 }
 if (objQuestionnaireAddiEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionnaireSetId);
 var strQuestionnaireSetId = objQuestionnaireAddiEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionScore !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionScore);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.QuestionScore.ToString());
 }
 
 if (objQuestionnaireAddiEN.QuestionNameAdd !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionNameAdd);
 var strQuestionNameAdd = objQuestionnaireAddiEN.QuestionNameAdd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNameAdd + "'");
 }
 
 if (objQuestionnaireAddiEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.DefaultValue);
 var strDefaultValue = objQuestionnaireAddiEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objQuestionnaireAddiEN.TextDirectId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.TextDirectId);
 var strTextDirectId = objQuestionnaireAddiEN.TextDirectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextDirectId + "'");
 }
 
 if (objQuestionnaireAddiEN.FillInTextWidth !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.FillInTextWidth);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.FillInTextWidth.ToString());
 }
 
 if (objQuestionnaireAddiEN.MemoTextWidth !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.MemoTextWidth);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.MemoTextWidth.ToString());
 }
 
 if (objQuestionnaireAddiEN.CodeTab !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CodeTab);
 var strCodeTab = objQuestionnaireAddiEN.CodeTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTab + "'");
 }
 
 if (objQuestionnaireAddiEN.CodeTabCode !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CodeTabCode);
 var strCodeTabCode = objQuestionnaireAddiEN.CodeTabCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCode + "'");
 }
 
 if (objQuestionnaireAddiEN.CodeTabName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CodeTabName);
 var strCodeTabName = objQuestionnaireAddiEN.CodeTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabName + "'");
 }
 
 if (objQuestionnaireAddiEN.CodeTabCondition !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CodeTabCondition);
 var strCodeTabCondition = objQuestionnaireAddiEN.CodeTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCondition + "'");
 }
 
 if (objQuestionnaireAddiEN.RelaEvent !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.RelaEvent);
 var strRelaEvent = objQuestionnaireAddiEN.RelaEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaEvent + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.FirstIndent);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.FirstIndent  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.DefaultSelectItem !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.DefaultSelectItem);
 var strDefaultSelectItem = objQuestionnaireAddiEN.DefaultSelectItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultSelectItem + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IfLinkage);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IfLinkage  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.LinkageIndex !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.LinkageIndex);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.LinkageIndex.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsAutoGridTitle);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsAutoGridTitle  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.FillInTextHeight !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.FillInTextHeight);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.FillInTextHeight.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsMulti4FillInText);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsMulti4FillInText  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.CheckBoxLimitCount !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CheckBoxLimitCount);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.CheckBoxLimitCount.ToString());
 }
 
 if (objQuestionnaireAddiEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.RoleId);
 var strRoleId = objQuestionnaireAddiEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsShow);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsShow  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsCast);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsCast  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.LikeCount);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.LikeCount.ToString());
 }
 
 if (objQuestionnaireAddiEN.AnswerAttLimitSize !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.AnswerAttLimitSize);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.AnswerAttLimitSize.ToString());
 }
 
 if (objQuestionnaireAddiEN.LimitedResourceType !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.LimitedResourceType);
 var strLimitedResourceType = objQuestionnaireAddiEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLimitedResourceType + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsEffective);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsCanInPaper);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsCanInPaper  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.UpdDate);
 var strUpdDate = objQuestionnaireAddiEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionnaireAddiEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.UpdUser);
 var strUpdUser = objQuestionnaireAddiEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionnaireAddiEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.Memo);
 var strMemo = objQuestionnaireAddiEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QuestionnaireAddi");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
 objQuestionnaireAddiEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireAddiEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireAddiEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionId);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.QuestionId.ToString());
 
 if (objQuestionnaireAddiEN.QuestionIndex !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionIndex);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.QuestionIndex.ToString());
 }
 
 if (objQuestionnaireAddiEN.QuestionName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionName);
 var strQuestionName = objQuestionnaireAddiEN.QuestionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionName + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionContent !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionContent);
 var strQuestionContent = objQuestionnaireAddiEN.QuestionContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionContent + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionMemo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionMemo);
 var strQuestionMemo = objQuestionnaireAddiEN.QuestionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionMemo + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionNo);
 var strQuestionNo = objQuestionnaireAddiEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNo + "'");
 }
 
 if (objQuestionnaireAddiEN.ParentQuestionId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.ParentQuestionId);
 var strParentQuestionId = objQuestionnaireAddiEN.ParentQuestionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentQuestionId + "'");
 }
 
 if (objQuestionnaireAddiEN.ExamAnswer !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.ExamAnswer);
 var strExamAnswer = objQuestionnaireAddiEN.ExamAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamAnswer + "'");
 }
 
 if (objQuestionnaireAddiEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CourseId);
 var strCourseId = objQuestionnaireAddiEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objQuestionnaireAddiEN.LevelNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.LevelNo);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.LevelNo.ToString());
 }
 
 if (objQuestionnaireAddiEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CourseChapterId);
 var strCourseChapterId = objQuestionnaireAddiEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionTypeId  ==  "")
 {
 objQuestionnaireAddiEN.QuestionTypeId = null;
 }
 if (objQuestionnaireAddiEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionTypeId);
 var strQuestionTypeId = objQuestionnaireAddiEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionTypeId4Course !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionTypeId4Course);
 var strQuestionTypeId4Course = objQuestionnaireAddiEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId4Course + "'");
 }
 
 if (objQuestionnaireAddiEN.ExamGradeId  ==  "")
 {
 objQuestionnaireAddiEN.ExamGradeId = null;
 }
 if (objQuestionnaireAddiEN.ExamGradeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.ExamGradeId);
 var strExamGradeId = objQuestionnaireAddiEN.ExamGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamGradeId + "'");
 }
 
 if (objQuestionnaireAddiEN.AnswerTypeId  ==  "")
 {
 objQuestionnaireAddiEN.AnswerTypeId = null;
 }
 if (objQuestionnaireAddiEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.AnswerTypeId);
 var strAnswerTypeId = objQuestionnaireAddiEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objQuestionnaireAddiEN.GridTitle !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.GridTitle);
 var strGridTitle = objQuestionnaireAddiEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGridTitle + "'");
 }
 
 if (objQuestionnaireAddiEN.AnswerModeId  ==  "")
 {
 objQuestionnaireAddiEN.AnswerModeId = null;
 }
 if (objQuestionnaireAddiEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.AnswerModeId);
 var strAnswerModeId = objQuestionnaireAddiEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsHaveAdditionalMemo);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsHaveAdditionalMemo  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.QuestionnaireSetId  ==  "")
 {
 objQuestionnaireAddiEN.QuestionnaireSetId = null;
 }
 if (objQuestionnaireAddiEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionnaireSetId);
 var strQuestionnaireSetId = objQuestionnaireAddiEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionScore !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionScore);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.QuestionScore.ToString());
 }
 
 if (objQuestionnaireAddiEN.QuestionNameAdd !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionNameAdd);
 var strQuestionNameAdd = objQuestionnaireAddiEN.QuestionNameAdd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNameAdd + "'");
 }
 
 if (objQuestionnaireAddiEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.DefaultValue);
 var strDefaultValue = objQuestionnaireAddiEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objQuestionnaireAddiEN.TextDirectId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.TextDirectId);
 var strTextDirectId = objQuestionnaireAddiEN.TextDirectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextDirectId + "'");
 }
 
 if (objQuestionnaireAddiEN.FillInTextWidth !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.FillInTextWidth);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.FillInTextWidth.ToString());
 }
 
 if (objQuestionnaireAddiEN.MemoTextWidth !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.MemoTextWidth);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.MemoTextWidth.ToString());
 }
 
 if (objQuestionnaireAddiEN.CodeTab !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CodeTab);
 var strCodeTab = objQuestionnaireAddiEN.CodeTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTab + "'");
 }
 
 if (objQuestionnaireAddiEN.CodeTabCode !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CodeTabCode);
 var strCodeTabCode = objQuestionnaireAddiEN.CodeTabCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCode + "'");
 }
 
 if (objQuestionnaireAddiEN.CodeTabName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CodeTabName);
 var strCodeTabName = objQuestionnaireAddiEN.CodeTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabName + "'");
 }
 
 if (objQuestionnaireAddiEN.CodeTabCondition !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CodeTabCondition);
 var strCodeTabCondition = objQuestionnaireAddiEN.CodeTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCondition + "'");
 }
 
 if (objQuestionnaireAddiEN.RelaEvent !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.RelaEvent);
 var strRelaEvent = objQuestionnaireAddiEN.RelaEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaEvent + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.FirstIndent);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.FirstIndent  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.DefaultSelectItem !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.DefaultSelectItem);
 var strDefaultSelectItem = objQuestionnaireAddiEN.DefaultSelectItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultSelectItem + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IfLinkage);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IfLinkage  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.LinkageIndex !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.LinkageIndex);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.LinkageIndex.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsAutoGridTitle);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsAutoGridTitle  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.FillInTextHeight !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.FillInTextHeight);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.FillInTextHeight.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsMulti4FillInText);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsMulti4FillInText  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.CheckBoxLimitCount !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CheckBoxLimitCount);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.CheckBoxLimitCount.ToString());
 }
 
 if (objQuestionnaireAddiEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.RoleId);
 var strRoleId = objQuestionnaireAddiEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsShow);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsShow  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsCast);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsCast  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.LikeCount);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.LikeCount.ToString());
 }
 
 if (objQuestionnaireAddiEN.AnswerAttLimitSize !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.AnswerAttLimitSize);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.AnswerAttLimitSize.ToString());
 }
 
 if (objQuestionnaireAddiEN.LimitedResourceType !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.LimitedResourceType);
 var strLimitedResourceType = objQuestionnaireAddiEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLimitedResourceType + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsEffective);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsCanInPaper);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsCanInPaper  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.UpdDate);
 var strUpdDate = objQuestionnaireAddiEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionnaireAddiEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.UpdUser);
 var strUpdUser = objQuestionnaireAddiEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionnaireAddiEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.Memo);
 var strMemo = objQuestionnaireAddiEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QuestionnaireAddi");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQuestionnaireAddiEN objQuestionnaireAddiEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQuestionnaireAddiEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireAddiEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireAddiEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionId);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.QuestionId.ToString());
 
 if (objQuestionnaireAddiEN.QuestionIndex !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionIndex);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.QuestionIndex.ToString());
 }
 
 if (objQuestionnaireAddiEN.QuestionName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionName);
 var strQuestionName = objQuestionnaireAddiEN.QuestionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionName + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionContent !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionContent);
 var strQuestionContent = objQuestionnaireAddiEN.QuestionContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionContent + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionMemo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionMemo);
 var strQuestionMemo = objQuestionnaireAddiEN.QuestionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionMemo + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionNo);
 var strQuestionNo = objQuestionnaireAddiEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNo + "'");
 }
 
 if (objQuestionnaireAddiEN.ParentQuestionId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.ParentQuestionId);
 var strParentQuestionId = objQuestionnaireAddiEN.ParentQuestionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentQuestionId + "'");
 }
 
 if (objQuestionnaireAddiEN.ExamAnswer !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.ExamAnswer);
 var strExamAnswer = objQuestionnaireAddiEN.ExamAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamAnswer + "'");
 }
 
 if (objQuestionnaireAddiEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CourseId);
 var strCourseId = objQuestionnaireAddiEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objQuestionnaireAddiEN.LevelNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.LevelNo);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.LevelNo.ToString());
 }
 
 if (objQuestionnaireAddiEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CourseChapterId);
 var strCourseChapterId = objQuestionnaireAddiEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionTypeId  ==  "")
 {
 objQuestionnaireAddiEN.QuestionTypeId = null;
 }
 if (objQuestionnaireAddiEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionTypeId);
 var strQuestionTypeId = objQuestionnaireAddiEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionTypeId4Course !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionTypeId4Course);
 var strQuestionTypeId4Course = objQuestionnaireAddiEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId4Course + "'");
 }
 
 if (objQuestionnaireAddiEN.ExamGradeId  ==  "")
 {
 objQuestionnaireAddiEN.ExamGradeId = null;
 }
 if (objQuestionnaireAddiEN.ExamGradeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.ExamGradeId);
 var strExamGradeId = objQuestionnaireAddiEN.ExamGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamGradeId + "'");
 }
 
 if (objQuestionnaireAddiEN.AnswerTypeId  ==  "")
 {
 objQuestionnaireAddiEN.AnswerTypeId = null;
 }
 if (objQuestionnaireAddiEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.AnswerTypeId);
 var strAnswerTypeId = objQuestionnaireAddiEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objQuestionnaireAddiEN.GridTitle !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.GridTitle);
 var strGridTitle = objQuestionnaireAddiEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGridTitle + "'");
 }
 
 if (objQuestionnaireAddiEN.AnswerModeId  ==  "")
 {
 objQuestionnaireAddiEN.AnswerModeId = null;
 }
 if (objQuestionnaireAddiEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.AnswerModeId);
 var strAnswerModeId = objQuestionnaireAddiEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsHaveAdditionalMemo);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsHaveAdditionalMemo  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.QuestionnaireSetId  ==  "")
 {
 objQuestionnaireAddiEN.QuestionnaireSetId = null;
 }
 if (objQuestionnaireAddiEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionnaireSetId);
 var strQuestionnaireSetId = objQuestionnaireAddiEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionScore !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionScore);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.QuestionScore.ToString());
 }
 
 if (objQuestionnaireAddiEN.QuestionNameAdd !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionNameAdd);
 var strQuestionNameAdd = objQuestionnaireAddiEN.QuestionNameAdd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNameAdd + "'");
 }
 
 if (objQuestionnaireAddiEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.DefaultValue);
 var strDefaultValue = objQuestionnaireAddiEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objQuestionnaireAddiEN.TextDirectId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.TextDirectId);
 var strTextDirectId = objQuestionnaireAddiEN.TextDirectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextDirectId + "'");
 }
 
 if (objQuestionnaireAddiEN.FillInTextWidth !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.FillInTextWidth);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.FillInTextWidth.ToString());
 }
 
 if (objQuestionnaireAddiEN.MemoTextWidth !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.MemoTextWidth);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.MemoTextWidth.ToString());
 }
 
 if (objQuestionnaireAddiEN.CodeTab !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CodeTab);
 var strCodeTab = objQuestionnaireAddiEN.CodeTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTab + "'");
 }
 
 if (objQuestionnaireAddiEN.CodeTabCode !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CodeTabCode);
 var strCodeTabCode = objQuestionnaireAddiEN.CodeTabCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCode + "'");
 }
 
 if (objQuestionnaireAddiEN.CodeTabName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CodeTabName);
 var strCodeTabName = objQuestionnaireAddiEN.CodeTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabName + "'");
 }
 
 if (objQuestionnaireAddiEN.CodeTabCondition !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CodeTabCondition);
 var strCodeTabCondition = objQuestionnaireAddiEN.CodeTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCondition + "'");
 }
 
 if (objQuestionnaireAddiEN.RelaEvent !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.RelaEvent);
 var strRelaEvent = objQuestionnaireAddiEN.RelaEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaEvent + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.FirstIndent);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.FirstIndent  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.DefaultSelectItem !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.DefaultSelectItem);
 var strDefaultSelectItem = objQuestionnaireAddiEN.DefaultSelectItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultSelectItem + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IfLinkage);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IfLinkage  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.LinkageIndex !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.LinkageIndex);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.LinkageIndex.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsAutoGridTitle);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsAutoGridTitle  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.FillInTextHeight !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.FillInTextHeight);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.FillInTextHeight.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsMulti4FillInText);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsMulti4FillInText  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.CheckBoxLimitCount !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CheckBoxLimitCount);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.CheckBoxLimitCount.ToString());
 }
 
 if (objQuestionnaireAddiEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.RoleId);
 var strRoleId = objQuestionnaireAddiEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsShow);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsShow  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsCast);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsCast  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.LikeCount);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.LikeCount.ToString());
 }
 
 if (objQuestionnaireAddiEN.AnswerAttLimitSize !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.AnswerAttLimitSize);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.AnswerAttLimitSize.ToString());
 }
 
 if (objQuestionnaireAddiEN.LimitedResourceType !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.LimitedResourceType);
 var strLimitedResourceType = objQuestionnaireAddiEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLimitedResourceType + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsEffective);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsCanInPaper);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsCanInPaper  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.UpdDate);
 var strUpdDate = objQuestionnaireAddiEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionnaireAddiEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.UpdUser);
 var strUpdUser = objQuestionnaireAddiEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionnaireAddiEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.Memo);
 var strMemo = objQuestionnaireAddiEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QuestionnaireAddi");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQuestionnaireAddiEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQuestionnaireAddiEN objQuestionnaireAddiEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQuestionnaireAddiEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireAddiEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireAddiEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionId);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.QuestionId.ToString());
 
 if (objQuestionnaireAddiEN.QuestionIndex !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionIndex);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.QuestionIndex.ToString());
 }
 
 if (objQuestionnaireAddiEN.QuestionName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionName);
 var strQuestionName = objQuestionnaireAddiEN.QuestionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionName + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionContent !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionContent);
 var strQuestionContent = objQuestionnaireAddiEN.QuestionContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionContent + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionMemo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionMemo);
 var strQuestionMemo = objQuestionnaireAddiEN.QuestionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionMemo + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionNo);
 var strQuestionNo = objQuestionnaireAddiEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNo + "'");
 }
 
 if (objQuestionnaireAddiEN.ParentQuestionId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.ParentQuestionId);
 var strParentQuestionId = objQuestionnaireAddiEN.ParentQuestionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentQuestionId + "'");
 }
 
 if (objQuestionnaireAddiEN.ExamAnswer !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.ExamAnswer);
 var strExamAnswer = objQuestionnaireAddiEN.ExamAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamAnswer + "'");
 }
 
 if (objQuestionnaireAddiEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CourseId);
 var strCourseId = objQuestionnaireAddiEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objQuestionnaireAddiEN.LevelNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.LevelNo);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.LevelNo.ToString());
 }
 
 if (objQuestionnaireAddiEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CourseChapterId);
 var strCourseChapterId = objQuestionnaireAddiEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionTypeId  ==  "")
 {
 objQuestionnaireAddiEN.QuestionTypeId = null;
 }
 if (objQuestionnaireAddiEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionTypeId);
 var strQuestionTypeId = objQuestionnaireAddiEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionTypeId4Course !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionTypeId4Course);
 var strQuestionTypeId4Course = objQuestionnaireAddiEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId4Course + "'");
 }
 
 if (objQuestionnaireAddiEN.ExamGradeId  ==  "")
 {
 objQuestionnaireAddiEN.ExamGradeId = null;
 }
 if (objQuestionnaireAddiEN.ExamGradeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.ExamGradeId);
 var strExamGradeId = objQuestionnaireAddiEN.ExamGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamGradeId + "'");
 }
 
 if (objQuestionnaireAddiEN.AnswerTypeId  ==  "")
 {
 objQuestionnaireAddiEN.AnswerTypeId = null;
 }
 if (objQuestionnaireAddiEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.AnswerTypeId);
 var strAnswerTypeId = objQuestionnaireAddiEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objQuestionnaireAddiEN.GridTitle !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.GridTitle);
 var strGridTitle = objQuestionnaireAddiEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGridTitle + "'");
 }
 
 if (objQuestionnaireAddiEN.AnswerModeId  ==  "")
 {
 objQuestionnaireAddiEN.AnswerModeId = null;
 }
 if (objQuestionnaireAddiEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.AnswerModeId);
 var strAnswerModeId = objQuestionnaireAddiEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsHaveAdditionalMemo);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsHaveAdditionalMemo  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.QuestionnaireSetId  ==  "")
 {
 objQuestionnaireAddiEN.QuestionnaireSetId = null;
 }
 if (objQuestionnaireAddiEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionnaireSetId);
 var strQuestionnaireSetId = objQuestionnaireAddiEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 if (objQuestionnaireAddiEN.QuestionScore !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionScore);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.QuestionScore.ToString());
 }
 
 if (objQuestionnaireAddiEN.QuestionNameAdd !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.QuestionNameAdd);
 var strQuestionNameAdd = objQuestionnaireAddiEN.QuestionNameAdd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNameAdd + "'");
 }
 
 if (objQuestionnaireAddiEN.DefaultValue !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.DefaultValue);
 var strDefaultValue = objQuestionnaireAddiEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultValue + "'");
 }
 
 if (objQuestionnaireAddiEN.TextDirectId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.TextDirectId);
 var strTextDirectId = objQuestionnaireAddiEN.TextDirectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextDirectId + "'");
 }
 
 if (objQuestionnaireAddiEN.FillInTextWidth !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.FillInTextWidth);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.FillInTextWidth.ToString());
 }
 
 if (objQuestionnaireAddiEN.MemoTextWidth !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.MemoTextWidth);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.MemoTextWidth.ToString());
 }
 
 if (objQuestionnaireAddiEN.CodeTab !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CodeTab);
 var strCodeTab = objQuestionnaireAddiEN.CodeTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTab + "'");
 }
 
 if (objQuestionnaireAddiEN.CodeTabCode !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CodeTabCode);
 var strCodeTabCode = objQuestionnaireAddiEN.CodeTabCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCode + "'");
 }
 
 if (objQuestionnaireAddiEN.CodeTabName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CodeTabName);
 var strCodeTabName = objQuestionnaireAddiEN.CodeTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabName + "'");
 }
 
 if (objQuestionnaireAddiEN.CodeTabCondition !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CodeTabCondition);
 var strCodeTabCondition = objQuestionnaireAddiEN.CodeTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTabCondition + "'");
 }
 
 if (objQuestionnaireAddiEN.RelaEvent !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.RelaEvent);
 var strRelaEvent = objQuestionnaireAddiEN.RelaEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaEvent + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.FirstIndent);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.FirstIndent  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.DefaultSelectItem !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.DefaultSelectItem);
 var strDefaultSelectItem = objQuestionnaireAddiEN.DefaultSelectItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaultSelectItem + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IfLinkage);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IfLinkage  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.LinkageIndex !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.LinkageIndex);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.LinkageIndex.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsAutoGridTitle);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsAutoGridTitle  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.FillInTextHeight !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.FillInTextHeight);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.FillInTextHeight.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsMulti4FillInText);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsMulti4FillInText  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.CheckBoxLimitCount !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.CheckBoxLimitCount);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.CheckBoxLimitCount.ToString());
 }
 
 if (objQuestionnaireAddiEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.RoleId);
 var strRoleId = objQuestionnaireAddiEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsShow);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsShow  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsCast);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsCast  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.LikeCount);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.LikeCount.ToString());
 }
 
 if (objQuestionnaireAddiEN.AnswerAttLimitSize !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.AnswerAttLimitSize);
 arrValueListForInsert.Add(objQuestionnaireAddiEN.AnswerAttLimitSize.ToString());
 }
 
 if (objQuestionnaireAddiEN.LimitedResourceType !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.LimitedResourceType);
 var strLimitedResourceType = objQuestionnaireAddiEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLimitedResourceType + "'");
 }
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsEffective);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conQuestionnaireAddi.IsCanInPaper);
 arrValueListForInsert.Add("'" + (objQuestionnaireAddiEN.IsCanInPaper  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireAddiEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.UpdDate);
 var strUpdDate = objQuestionnaireAddiEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionnaireAddiEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.UpdUser);
 var strUpdUser = objQuestionnaireAddiEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionnaireAddiEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireAddi.Memo);
 var strMemo = objQuestionnaireAddiEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QuestionnaireAddi");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQuestionnaireAddis(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireAddi where QuestionId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QuestionnaireAddi");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngQuestionId = TransNullToInt(oRow[conQuestionnaireAddi.QuestionId].ToString().Trim());
if (IsExist(lngQuestionId))
{
 string strResult = "关键字变量值为:" + string.Format("QuestionId = {0}", lngQuestionId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQuestionnaireAddiEN._CurrTabName ].NewRow();
objRow[conQuestionnaireAddi.QuestionId] = oRow[conQuestionnaireAddi.QuestionId].ToString().Trim(); //题目Id
objRow[conQuestionnaireAddi.QuestionIndex] = oRow[conQuestionnaireAddi.QuestionIndex].ToString().Trim(); //题目序号
objRow[conQuestionnaireAddi.QuestionName] = oRow[conQuestionnaireAddi.QuestionName].ToString().Trim(); //题目名称
objRow[conQuestionnaireAddi.QuestionContent] = oRow[conQuestionnaireAddi.QuestionContent].ToString().Trim(); //题目内容
objRow[conQuestionnaireAddi.QuestionMemo] = oRow[conQuestionnaireAddi.QuestionMemo].ToString().Trim(); //题目说明
objRow[conQuestionnaireAddi.QuestionNo] = oRow[conQuestionnaireAddi.QuestionNo].ToString().Trim(); //题目编号
objRow[conQuestionnaireAddi.ParentQuestionId] = oRow[conQuestionnaireAddi.ParentQuestionId].ToString().Trim(); //父题目Id
objRow[conQuestionnaireAddi.ExamAnswer] = oRow[conQuestionnaireAddi.ExamAnswer].ToString().Trim(); //题目答案
objRow[conQuestionnaireAddi.CourseId] = oRow[conQuestionnaireAddi.CourseId].ToString().Trim(); //课程Id
objRow[conQuestionnaireAddi.LevelNo] = oRow[conQuestionnaireAddi.LevelNo].ToString().Trim(); //学习关号2
objRow[conQuestionnaireAddi.CourseChapterId] = oRow[conQuestionnaireAddi.CourseChapterId].ToString().Trim(); //课程章节ID
objRow[conQuestionnaireAddi.QuestionTypeId] = oRow[conQuestionnaireAddi.QuestionTypeId].ToString().Trim(); //题目类型Id
objRow[conQuestionnaireAddi.QuestionTypeId4Course] = oRow[conQuestionnaireAddi.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objRow[conQuestionnaireAddi.ExamGradeId] = oRow[conQuestionnaireAddi.ExamGradeId].ToString().Trim(); //题库等级ID
objRow[conQuestionnaireAddi.AnswerTypeId] = oRow[conQuestionnaireAddi.AnswerTypeId].ToString().Trim(); //答案类型ID
objRow[conQuestionnaireAddi.GridTitle] = oRow[conQuestionnaireAddi.GridTitle].ToString().Trim(); //表格标题
objRow[conQuestionnaireAddi.AnswerModeId] = oRow[conQuestionnaireAddi.AnswerModeId].ToString().Trim(); //答案模式Id
objRow[conQuestionnaireAddi.IsHaveAdditionalMemo] = oRow[conQuestionnaireAddi.IsHaveAdditionalMemo].ToString().Trim(); //是否有附加说明
objRow[conQuestionnaireAddi.QuestionnaireSetId] = oRow[conQuestionnaireAddi.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objRow[conQuestionnaireAddi.QuestionScore] = oRow[conQuestionnaireAddi.QuestionScore].ToString().Trim(); //题目得分
objRow[conQuestionnaireAddi.QuestionNameAdd] = oRow[conQuestionnaireAddi.QuestionNameAdd].ToString().Trim(); //题目补充
objRow[conQuestionnaireAddi.DefaultValue] = oRow[conQuestionnaireAddi.DefaultValue].ToString().Trim(); //缺省值
objRow[conQuestionnaireAddi.TextDirectId] = oRow[conQuestionnaireAddi.TextDirectId].ToString().Trim(); //文本方向ID
objRow[conQuestionnaireAddi.FillInTextWidth] = oRow[conQuestionnaireAddi.FillInTextWidth].ToString().Trim(); //填空框宽度
objRow[conQuestionnaireAddi.MemoTextWidth] = oRow[conQuestionnaireAddi.MemoTextWidth].ToString().Trim(); //备注框宽度
objRow[conQuestionnaireAddi.CodeTab] = oRow[conQuestionnaireAddi.CodeTab].ToString().Trim(); //代码表
objRow[conQuestionnaireAddi.CodeTabCode] = oRow[conQuestionnaireAddi.CodeTabCode].ToString().Trim(); //CodeTab_Code
objRow[conQuestionnaireAddi.CodeTabName] = oRow[conQuestionnaireAddi.CodeTabName].ToString().Trim(); //CodeTab_Name
objRow[conQuestionnaireAddi.CodeTabCondition] = oRow[conQuestionnaireAddi.CodeTabCondition].ToString().Trim(); //代码表_条件
objRow[conQuestionnaireAddi.RelaEvent] = oRow[conQuestionnaireAddi.RelaEvent].ToString().Trim(); //相关事件
objRow[conQuestionnaireAddi.FirstIndent] = oRow[conQuestionnaireAddi.FirstIndent].ToString().Trim(); //首行缩进
objRow[conQuestionnaireAddi.DefaultSelectItem] = oRow[conQuestionnaireAddi.DefaultSelectItem].ToString().Trim(); //默认选项
objRow[conQuestionnaireAddi.IfLinkage] = oRow[conQuestionnaireAddi.IfLinkage].ToString().Trim(); //是否联动
objRow[conQuestionnaireAddi.LinkageIndex] = oRow[conQuestionnaireAddi.LinkageIndex].ToString().Trim(); //联动题序号
objRow[conQuestionnaireAddi.IsAutoGridTitle] = oRow[conQuestionnaireAddi.IsAutoGridTitle].ToString().Trim(); //是否自动编表格标题
objRow[conQuestionnaireAddi.FillInTextHeight] = oRow[conQuestionnaireAddi.FillInTextHeight].ToString().Trim(); //填空框高度
objRow[conQuestionnaireAddi.IsMulti4FillInText] = oRow[conQuestionnaireAddi.IsMulti4FillInText].ToString().Trim(); //是否填空框多行
objRow[conQuestionnaireAddi.CheckBoxLimitCount] = oRow[conQuestionnaireAddi.CheckBoxLimitCount].ToString().Trim(); //复选框限制数
objRow[conQuestionnaireAddi.RoleId] = oRow[conQuestionnaireAddi.RoleId].ToString().Trim(); //角色Id
objRow[conQuestionnaireAddi.IsShow] = oRow[conQuestionnaireAddi.IsShow].ToString().Trim(); //是否启用
objRow[conQuestionnaireAddi.IsCast] = oRow[conQuestionnaireAddi.IsCast].ToString().Trim(); //是否播放
objRow[conQuestionnaireAddi.LikeCount] = oRow[conQuestionnaireAddi.LikeCount].ToString().Trim(); //资源喜欢数量
objRow[conQuestionnaireAddi.AnswerAttLimitSize] = oRow[conQuestionnaireAddi.AnswerAttLimitSize].ToString().Trim(); //回答附件限制大小
objRow[conQuestionnaireAddi.LimitedResourceType] = oRow[conQuestionnaireAddi.LimitedResourceType].ToString().Trim(); //限制资源类型
objRow[conQuestionnaireAddi.IsEffective] = oRow[conQuestionnaireAddi.IsEffective].ToString().Trim(); //是否有效
objRow[conQuestionnaireAddi.IsCanInPaper] = oRow[conQuestionnaireAddi.IsCanInPaper].ToString().Trim(); //是否可在Paper
objRow[conQuestionnaireAddi.UpdDate] = oRow[conQuestionnaireAddi.UpdDate].ToString().Trim(); //修改日期
objRow[conQuestionnaireAddi.UpdUser] = oRow[conQuestionnaireAddi.UpdUser].ToString().Trim(); //修改人
objRow[conQuestionnaireAddi.Memo] = oRow[conQuestionnaireAddi.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQuestionnaireAddiEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQuestionnaireAddiEN._CurrTabName);
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
 /// <param name = "objQuestionnaireAddiEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
 objQuestionnaireAddiEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireAddiEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireAddiEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireAddi where QuestionId = " + ""+ objQuestionnaireAddiEN.QuestionId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQuestionnaireAddiEN._CurrTabName);
if (objDS.Tables[clsQuestionnaireAddiEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:QuestionId = " + ""+ objQuestionnaireAddiEN.QuestionId+"");
return false;
}
objRow = objDS.Tables[clsQuestionnaireAddiEN._CurrTabName].Rows[0];
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionId))
 {
objRow[conQuestionnaireAddi.QuestionId] = objQuestionnaireAddiEN.QuestionId; //题目Id
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionIndex))
 {
objRow[conQuestionnaireAddi.QuestionIndex] = objQuestionnaireAddiEN.QuestionIndex; //题目序号
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionName))
 {
objRow[conQuestionnaireAddi.QuestionName] = objQuestionnaireAddiEN.QuestionName; //题目名称
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionContent))
 {
objRow[conQuestionnaireAddi.QuestionContent] = objQuestionnaireAddiEN.QuestionContent; //题目内容
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionMemo))
 {
objRow[conQuestionnaireAddi.QuestionMemo] = objQuestionnaireAddiEN.QuestionMemo; //题目说明
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionNo))
 {
objRow[conQuestionnaireAddi.QuestionNo] = objQuestionnaireAddiEN.QuestionNo; //题目编号
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.ParentQuestionId))
 {
objRow[conQuestionnaireAddi.ParentQuestionId] = objQuestionnaireAddiEN.ParentQuestionId; //父题目Id
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.ExamAnswer))
 {
objRow[conQuestionnaireAddi.ExamAnswer] = objQuestionnaireAddiEN.ExamAnswer; //题目答案
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CourseId))
 {
objRow[conQuestionnaireAddi.CourseId] = objQuestionnaireAddiEN.CourseId; //课程Id
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LevelNo))
 {
objRow[conQuestionnaireAddi.LevelNo] = objQuestionnaireAddiEN.LevelNo; //学习关号2
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CourseChapterId))
 {
objRow[conQuestionnaireAddi.CourseChapterId] = objQuestionnaireAddiEN.CourseChapterId; //课程章节ID
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionTypeId))
 {
objRow[conQuestionnaireAddi.QuestionTypeId] = objQuestionnaireAddiEN.QuestionTypeId; //题目类型Id
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionTypeId4Course))
 {
objRow[conQuestionnaireAddi.QuestionTypeId4Course] = objQuestionnaireAddiEN.QuestionTypeId4Course; //题目类型Id4课程
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.ExamGradeId))
 {
objRow[conQuestionnaireAddi.ExamGradeId] = objQuestionnaireAddiEN.ExamGradeId; //题库等级ID
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.AnswerTypeId))
 {
objRow[conQuestionnaireAddi.AnswerTypeId] = objQuestionnaireAddiEN.AnswerTypeId; //答案类型ID
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.GridTitle))
 {
objRow[conQuestionnaireAddi.GridTitle] = objQuestionnaireAddiEN.GridTitle; //表格标题
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.AnswerModeId))
 {
objRow[conQuestionnaireAddi.AnswerModeId] = objQuestionnaireAddiEN.AnswerModeId; //答案模式Id
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsHaveAdditionalMemo))
 {
objRow[conQuestionnaireAddi.IsHaveAdditionalMemo] = objQuestionnaireAddiEN.IsHaveAdditionalMemo; //是否有附加说明
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionnaireSetId))
 {
objRow[conQuestionnaireAddi.QuestionnaireSetId] = objQuestionnaireAddiEN.QuestionnaireSetId; //问卷集ID
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionScore))
 {
objRow[conQuestionnaireAddi.QuestionScore] = objQuestionnaireAddiEN.QuestionScore; //题目得分
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionNameAdd))
 {
objRow[conQuestionnaireAddi.QuestionNameAdd] = objQuestionnaireAddiEN.QuestionNameAdd; //题目补充
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.DefaultValue))
 {
objRow[conQuestionnaireAddi.DefaultValue] = objQuestionnaireAddiEN.DefaultValue; //缺省值
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.TextDirectId))
 {
objRow[conQuestionnaireAddi.TextDirectId] = objQuestionnaireAddiEN.TextDirectId; //文本方向ID
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.FillInTextWidth))
 {
objRow[conQuestionnaireAddi.FillInTextWidth] = objQuestionnaireAddiEN.FillInTextWidth; //填空框宽度
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.MemoTextWidth))
 {
objRow[conQuestionnaireAddi.MemoTextWidth] = objQuestionnaireAddiEN.MemoTextWidth; //备注框宽度
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTab))
 {
objRow[conQuestionnaireAddi.CodeTab] = objQuestionnaireAddiEN.CodeTab; //代码表
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTabCode))
 {
objRow[conQuestionnaireAddi.CodeTabCode] = objQuestionnaireAddiEN.CodeTabCode; //CodeTab_Code
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTabName))
 {
objRow[conQuestionnaireAddi.CodeTabName] = objQuestionnaireAddiEN.CodeTabName; //CodeTab_Name
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTabCondition))
 {
objRow[conQuestionnaireAddi.CodeTabCondition] = objQuestionnaireAddiEN.CodeTabCondition; //代码表_条件
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.RelaEvent))
 {
objRow[conQuestionnaireAddi.RelaEvent] = objQuestionnaireAddiEN.RelaEvent; //相关事件
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.FirstIndent))
 {
objRow[conQuestionnaireAddi.FirstIndent] = objQuestionnaireAddiEN.FirstIndent; //首行缩进
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.DefaultSelectItem))
 {
objRow[conQuestionnaireAddi.DefaultSelectItem] = objQuestionnaireAddiEN.DefaultSelectItem; //默认选项
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IfLinkage))
 {
objRow[conQuestionnaireAddi.IfLinkage] = objQuestionnaireAddiEN.IfLinkage; //是否联动
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LinkageIndex))
 {
objRow[conQuestionnaireAddi.LinkageIndex] = objQuestionnaireAddiEN.LinkageIndex; //联动题序号
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsAutoGridTitle))
 {
objRow[conQuestionnaireAddi.IsAutoGridTitle] = objQuestionnaireAddiEN.IsAutoGridTitle; //是否自动编表格标题
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.FillInTextHeight))
 {
objRow[conQuestionnaireAddi.FillInTextHeight] = objQuestionnaireAddiEN.FillInTextHeight; //填空框高度
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsMulti4FillInText))
 {
objRow[conQuestionnaireAddi.IsMulti4FillInText] = objQuestionnaireAddiEN.IsMulti4FillInText; //是否填空框多行
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CheckBoxLimitCount))
 {
objRow[conQuestionnaireAddi.CheckBoxLimitCount] = objQuestionnaireAddiEN.CheckBoxLimitCount; //复选框限制数
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.RoleId))
 {
objRow[conQuestionnaireAddi.RoleId] = objQuestionnaireAddiEN.RoleId; //角色Id
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsShow))
 {
objRow[conQuestionnaireAddi.IsShow] = objQuestionnaireAddiEN.IsShow; //是否启用
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsCast))
 {
objRow[conQuestionnaireAddi.IsCast] = objQuestionnaireAddiEN.IsCast; //是否播放
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LikeCount))
 {
objRow[conQuestionnaireAddi.LikeCount] = objQuestionnaireAddiEN.LikeCount; //资源喜欢数量
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.AnswerAttLimitSize))
 {
objRow[conQuestionnaireAddi.AnswerAttLimitSize] = objQuestionnaireAddiEN.AnswerAttLimitSize; //回答附件限制大小
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LimitedResourceType))
 {
objRow[conQuestionnaireAddi.LimitedResourceType] = objQuestionnaireAddiEN.LimitedResourceType; //限制资源类型
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsEffective))
 {
objRow[conQuestionnaireAddi.IsEffective] = objQuestionnaireAddiEN.IsEffective; //是否有效
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsCanInPaper))
 {
objRow[conQuestionnaireAddi.IsCanInPaper] = objQuestionnaireAddiEN.IsCanInPaper; //是否可在Paper
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.UpdDate))
 {
objRow[conQuestionnaireAddi.UpdDate] = objQuestionnaireAddiEN.UpdDate; //修改日期
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.UpdUser))
 {
objRow[conQuestionnaireAddi.UpdUser] = objQuestionnaireAddiEN.UpdUser; //修改人
 }
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.Memo))
 {
objRow[conQuestionnaireAddi.Memo] = objQuestionnaireAddiEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQuestionnaireAddiEN._CurrTabName);
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
 /// <param name = "objQuestionnaireAddiEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
 objQuestionnaireAddiEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireAddiEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireAddiEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QuestionnaireAddi Set ");
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionIndex))
 {
 if (objQuestionnaireAddiEN.QuestionIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.QuestionIndex, conQuestionnaireAddi.QuestionIndex); //题目序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionIndex); //题目序号
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionName))
 {
 if (objQuestionnaireAddiEN.QuestionName !=  null)
 {
 var strQuestionName = objQuestionnaireAddiEN.QuestionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionName, conQuestionnaireAddi.QuestionName); //题目名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionName); //题目名称
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionContent))
 {
 if (objQuestionnaireAddiEN.QuestionContent !=  null)
 {
 var strQuestionContent = objQuestionnaireAddiEN.QuestionContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionContent, conQuestionnaireAddi.QuestionContent); //题目内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionContent); //题目内容
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionMemo))
 {
 if (objQuestionnaireAddiEN.QuestionMemo !=  null)
 {
 var strQuestionMemo = objQuestionnaireAddiEN.QuestionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionMemo, conQuestionnaireAddi.QuestionMemo); //题目说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionMemo); //题目说明
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionNo))
 {
 if (objQuestionnaireAddiEN.QuestionNo !=  null)
 {
 var strQuestionNo = objQuestionnaireAddiEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionNo, conQuestionnaireAddi.QuestionNo); //题目编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionNo); //题目编号
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.ParentQuestionId))
 {
 if (objQuestionnaireAddiEN.ParentQuestionId !=  null)
 {
 var strParentQuestionId = objQuestionnaireAddiEN.ParentQuestionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentQuestionId, conQuestionnaireAddi.ParentQuestionId); //父题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.ParentQuestionId); //父题目Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.ExamAnswer))
 {
 if (objQuestionnaireAddiEN.ExamAnswer !=  null)
 {
 var strExamAnswer = objQuestionnaireAddiEN.ExamAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamAnswer, conQuestionnaireAddi.ExamAnswer); //题目答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.ExamAnswer); //题目答案
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CourseId))
 {
 if (objQuestionnaireAddiEN.CourseId !=  null)
 {
 var strCourseId = objQuestionnaireAddiEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conQuestionnaireAddi.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.CourseId); //课程Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LevelNo))
 {
 if (objQuestionnaireAddiEN.LevelNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.LevelNo, conQuestionnaireAddi.LevelNo); //学习关号2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.LevelNo); //学习关号2
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CourseChapterId))
 {
 if (objQuestionnaireAddiEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objQuestionnaireAddiEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, conQuestionnaireAddi.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.CourseChapterId); //课程章节ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionTypeId))
 {
 if (objQuestionnaireAddiEN.QuestionTypeId  ==  "")
 {
 objQuestionnaireAddiEN.QuestionTypeId = null;
 }
 if (objQuestionnaireAddiEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objQuestionnaireAddiEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionTypeId, conQuestionnaireAddi.QuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionTypeId); //题目类型Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionTypeId4Course))
 {
 if (objQuestionnaireAddiEN.QuestionTypeId4Course !=  null)
 {
 var strQuestionTypeId4Course = objQuestionnaireAddiEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionTypeId4Course, conQuestionnaireAddi.QuestionTypeId4Course); //题目类型Id4课程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionTypeId4Course); //题目类型Id4课程
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.ExamGradeId))
 {
 if (objQuestionnaireAddiEN.ExamGradeId  ==  "")
 {
 objQuestionnaireAddiEN.ExamGradeId = null;
 }
 if (objQuestionnaireAddiEN.ExamGradeId !=  null)
 {
 var strExamGradeId = objQuestionnaireAddiEN.ExamGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamGradeId, conQuestionnaireAddi.ExamGradeId); //题库等级ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.ExamGradeId); //题库等级ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.AnswerTypeId))
 {
 if (objQuestionnaireAddiEN.AnswerTypeId  ==  "")
 {
 objQuestionnaireAddiEN.AnswerTypeId = null;
 }
 if (objQuestionnaireAddiEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objQuestionnaireAddiEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTypeId, conQuestionnaireAddi.AnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.AnswerTypeId); //答案类型ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.GridTitle))
 {
 if (objQuestionnaireAddiEN.GridTitle !=  null)
 {
 var strGridTitle = objQuestionnaireAddiEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGridTitle, conQuestionnaireAddi.GridTitle); //表格标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.GridTitle); //表格标题
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.AnswerModeId))
 {
 if (objQuestionnaireAddiEN.AnswerModeId  ==  "")
 {
 objQuestionnaireAddiEN.AnswerModeId = null;
 }
 if (objQuestionnaireAddiEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objQuestionnaireAddiEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerModeId, conQuestionnaireAddi.AnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.AnswerModeId); //答案模式Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsHaveAdditionalMemo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.IsHaveAdditionalMemo == true?"1":"0", conQuestionnaireAddi.IsHaveAdditionalMemo); //是否有附加说明
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionnaireSetId))
 {
 if (objQuestionnaireAddiEN.QuestionnaireSetId  ==  "")
 {
 objQuestionnaireAddiEN.QuestionnaireSetId = null;
 }
 if (objQuestionnaireAddiEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objQuestionnaireAddiEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionnaireSetId, conQuestionnaireAddi.QuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionnaireSetId); //问卷集ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionScore))
 {
 if (objQuestionnaireAddiEN.QuestionScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.QuestionScore, conQuestionnaireAddi.QuestionScore); //题目得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionScore); //题目得分
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionNameAdd))
 {
 if (objQuestionnaireAddiEN.QuestionNameAdd !=  null)
 {
 var strQuestionNameAdd = objQuestionnaireAddiEN.QuestionNameAdd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionNameAdd, conQuestionnaireAddi.QuestionNameAdd); //题目补充
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionNameAdd); //题目补充
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.DefaultValue))
 {
 if (objQuestionnaireAddiEN.DefaultValue !=  null)
 {
 var strDefaultValue = objQuestionnaireAddiEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultValue, conQuestionnaireAddi.DefaultValue); //缺省值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.DefaultValue); //缺省值
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.TextDirectId))
 {
 if (objQuestionnaireAddiEN.TextDirectId !=  null)
 {
 var strTextDirectId = objQuestionnaireAddiEN.TextDirectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextDirectId, conQuestionnaireAddi.TextDirectId); //文本方向ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.TextDirectId); //文本方向ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.FillInTextWidth))
 {
 if (objQuestionnaireAddiEN.FillInTextWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.FillInTextWidth, conQuestionnaireAddi.FillInTextWidth); //填空框宽度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.FillInTextWidth); //填空框宽度
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.MemoTextWidth))
 {
 if (objQuestionnaireAddiEN.MemoTextWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.MemoTextWidth, conQuestionnaireAddi.MemoTextWidth); //备注框宽度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.MemoTextWidth); //备注框宽度
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTab))
 {
 if (objQuestionnaireAddiEN.CodeTab !=  null)
 {
 var strCodeTab = objQuestionnaireAddiEN.CodeTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTab, conQuestionnaireAddi.CodeTab); //代码表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.CodeTab); //代码表
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTabCode))
 {
 if (objQuestionnaireAddiEN.CodeTabCode !=  null)
 {
 var strCodeTabCode = objQuestionnaireAddiEN.CodeTabCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabCode, conQuestionnaireAddi.CodeTabCode); //CodeTab_Code
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.CodeTabCode); //CodeTab_Code
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTabName))
 {
 if (objQuestionnaireAddiEN.CodeTabName !=  null)
 {
 var strCodeTabName = objQuestionnaireAddiEN.CodeTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabName, conQuestionnaireAddi.CodeTabName); //CodeTab_Name
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.CodeTabName); //CodeTab_Name
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTabCondition))
 {
 if (objQuestionnaireAddiEN.CodeTabCondition !=  null)
 {
 var strCodeTabCondition = objQuestionnaireAddiEN.CodeTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabCondition, conQuestionnaireAddi.CodeTabCondition); //代码表_条件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.CodeTabCondition); //代码表_条件
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.RelaEvent))
 {
 if (objQuestionnaireAddiEN.RelaEvent !=  null)
 {
 var strRelaEvent = objQuestionnaireAddiEN.RelaEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelaEvent, conQuestionnaireAddi.RelaEvent); //相关事件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.RelaEvent); //相关事件
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.FirstIndent))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.FirstIndent == true?"1":"0", conQuestionnaireAddi.FirstIndent); //首行缩进
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.DefaultSelectItem))
 {
 if (objQuestionnaireAddiEN.DefaultSelectItem !=  null)
 {
 var strDefaultSelectItem = objQuestionnaireAddiEN.DefaultSelectItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultSelectItem, conQuestionnaireAddi.DefaultSelectItem); //默认选项
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.DefaultSelectItem); //默认选项
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IfLinkage))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.IfLinkage == true?"1":"0", conQuestionnaireAddi.IfLinkage); //是否联动
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LinkageIndex))
 {
 if (objQuestionnaireAddiEN.LinkageIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.LinkageIndex, conQuestionnaireAddi.LinkageIndex); //联动题序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.LinkageIndex); //联动题序号
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsAutoGridTitle))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.IsAutoGridTitle == true?"1":"0", conQuestionnaireAddi.IsAutoGridTitle); //是否自动编表格标题
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.FillInTextHeight))
 {
 if (objQuestionnaireAddiEN.FillInTextHeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.FillInTextHeight, conQuestionnaireAddi.FillInTextHeight); //填空框高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.FillInTextHeight); //填空框高度
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsMulti4FillInText))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.IsMulti4FillInText == true?"1":"0", conQuestionnaireAddi.IsMulti4FillInText); //是否填空框多行
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CheckBoxLimitCount))
 {
 if (objQuestionnaireAddiEN.CheckBoxLimitCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.CheckBoxLimitCount, conQuestionnaireAddi.CheckBoxLimitCount); //复选框限制数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.CheckBoxLimitCount); //复选框限制数
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.RoleId))
 {
 if (objQuestionnaireAddiEN.RoleId !=  null)
 {
 var strRoleId = objQuestionnaireAddiEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conQuestionnaireAddi.RoleId); //角色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.RoleId); //角色Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.IsShow == true?"1":"0", conQuestionnaireAddi.IsShow); //是否启用
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsCast))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.IsCast == true?"1":"0", conQuestionnaireAddi.IsCast); //是否播放
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LikeCount))
 {
 if (objQuestionnaireAddiEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.LikeCount, conQuestionnaireAddi.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.LikeCount); //资源喜欢数量
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.AnswerAttLimitSize))
 {
 if (objQuestionnaireAddiEN.AnswerAttLimitSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.AnswerAttLimitSize, conQuestionnaireAddi.AnswerAttLimitSize); //回答附件限制大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.AnswerAttLimitSize); //回答附件限制大小
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LimitedResourceType))
 {
 if (objQuestionnaireAddiEN.LimitedResourceType !=  null)
 {
 var strLimitedResourceType = objQuestionnaireAddiEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLimitedResourceType, conQuestionnaireAddi.LimitedResourceType); //限制资源类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.LimitedResourceType); //限制资源类型
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsEffective))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.IsEffective == true?"1":"0", conQuestionnaireAddi.IsEffective); //是否有效
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsCanInPaper))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.IsCanInPaper == true?"1":"0", conQuestionnaireAddi.IsCanInPaper); //是否可在Paper
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.UpdDate))
 {
 if (objQuestionnaireAddiEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionnaireAddiEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQuestionnaireAddi.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.UpdDate); //修改日期
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.UpdUser))
 {
 if (objQuestionnaireAddiEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionnaireAddiEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQuestionnaireAddi.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.UpdUser); //修改人
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.Memo))
 {
 if (objQuestionnaireAddiEN.Memo !=  null)
 {
 var strMemo = objQuestionnaireAddiEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQuestionnaireAddi.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where QuestionId = {0}", objQuestionnaireAddiEN.QuestionId); 
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
 /// <param name = "objQuestionnaireAddiEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strCondition)
{
 objQuestionnaireAddiEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireAddiEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireAddiEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QuestionnaireAddi Set ");
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionIndex))
 {
 if (objQuestionnaireAddiEN.QuestionIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.QuestionIndex, conQuestionnaireAddi.QuestionIndex); //题目序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionIndex); //题目序号
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionName))
 {
 if (objQuestionnaireAddiEN.QuestionName !=  null)
 {
 var strQuestionName = objQuestionnaireAddiEN.QuestionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionName = '{0}',", strQuestionName); //题目名称
 }
 else
 {
 sbSQL.Append(" QuestionName = null,"); //题目名称
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionContent))
 {
 if (objQuestionnaireAddiEN.QuestionContent !=  null)
 {
 var strQuestionContent = objQuestionnaireAddiEN.QuestionContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionContent = '{0}',", strQuestionContent); //题目内容
 }
 else
 {
 sbSQL.Append(" QuestionContent = null,"); //题目内容
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionMemo))
 {
 if (objQuestionnaireAddiEN.QuestionMemo !=  null)
 {
 var strQuestionMemo = objQuestionnaireAddiEN.QuestionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionMemo = '{0}',", strQuestionMemo); //题目说明
 }
 else
 {
 sbSQL.Append(" QuestionMemo = null,"); //题目说明
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionNo))
 {
 if (objQuestionnaireAddiEN.QuestionNo !=  null)
 {
 var strQuestionNo = objQuestionnaireAddiEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionNo = '{0}',", strQuestionNo); //题目编号
 }
 else
 {
 sbSQL.Append(" QuestionNo = null,"); //题目编号
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.ParentQuestionId))
 {
 if (objQuestionnaireAddiEN.ParentQuestionId !=  null)
 {
 var strParentQuestionId = objQuestionnaireAddiEN.ParentQuestionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentQuestionId = '{0}',", strParentQuestionId); //父题目Id
 }
 else
 {
 sbSQL.Append(" ParentQuestionId = null,"); //父题目Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.ExamAnswer))
 {
 if (objQuestionnaireAddiEN.ExamAnswer !=  null)
 {
 var strExamAnswer = objQuestionnaireAddiEN.ExamAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamAnswer = '{0}',", strExamAnswer); //题目答案
 }
 else
 {
 sbSQL.Append(" ExamAnswer = null,"); //题目答案
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CourseId))
 {
 if (objQuestionnaireAddiEN.CourseId !=  null)
 {
 var strCourseId = objQuestionnaireAddiEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LevelNo))
 {
 if (objQuestionnaireAddiEN.LevelNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.LevelNo, conQuestionnaireAddi.LevelNo); //学习关号2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.LevelNo); //学习关号2
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CourseChapterId))
 {
 if (objQuestionnaireAddiEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objQuestionnaireAddiEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionTypeId))
 {
 if (objQuestionnaireAddiEN.QuestionTypeId  ==  "")
 {
 objQuestionnaireAddiEN.QuestionTypeId = null;
 }
 if (objQuestionnaireAddiEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objQuestionnaireAddiEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionTypeId = '{0}',", strQuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.Append(" QuestionTypeId = null,"); //题目类型Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionTypeId4Course))
 {
 if (objQuestionnaireAddiEN.QuestionTypeId4Course !=  null)
 {
 var strQuestionTypeId4Course = objQuestionnaireAddiEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionTypeId4Course = '{0}',", strQuestionTypeId4Course); //题目类型Id4课程
 }
 else
 {
 sbSQL.Append(" QuestionTypeId4Course = null,"); //题目类型Id4课程
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.ExamGradeId))
 {
 if (objQuestionnaireAddiEN.ExamGradeId  ==  "")
 {
 objQuestionnaireAddiEN.ExamGradeId = null;
 }
 if (objQuestionnaireAddiEN.ExamGradeId !=  null)
 {
 var strExamGradeId = objQuestionnaireAddiEN.ExamGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamGradeId = '{0}',", strExamGradeId); //题库等级ID
 }
 else
 {
 sbSQL.Append(" ExamGradeId = null,"); //题库等级ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.AnswerTypeId))
 {
 if (objQuestionnaireAddiEN.AnswerTypeId  ==  "")
 {
 objQuestionnaireAddiEN.AnswerTypeId = null;
 }
 if (objQuestionnaireAddiEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objQuestionnaireAddiEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTypeId = '{0}',", strAnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.Append(" AnswerTypeId = null,"); //答案类型ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.GridTitle))
 {
 if (objQuestionnaireAddiEN.GridTitle !=  null)
 {
 var strGridTitle = objQuestionnaireAddiEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GridTitle = '{0}',", strGridTitle); //表格标题
 }
 else
 {
 sbSQL.Append(" GridTitle = null,"); //表格标题
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.AnswerModeId))
 {
 if (objQuestionnaireAddiEN.AnswerModeId  ==  "")
 {
 objQuestionnaireAddiEN.AnswerModeId = null;
 }
 if (objQuestionnaireAddiEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objQuestionnaireAddiEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerModeId = '{0}',", strAnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.Append(" AnswerModeId = null,"); //答案模式Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsHaveAdditionalMemo))
 {
 sbSQL.AppendFormat(" IsHaveAdditionalMemo = '{0}',", objQuestionnaireAddiEN.IsHaveAdditionalMemo == true?"1":"0"); //是否有附加说明
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionnaireSetId))
 {
 if (objQuestionnaireAddiEN.QuestionnaireSetId  ==  "")
 {
 objQuestionnaireAddiEN.QuestionnaireSetId = null;
 }
 if (objQuestionnaireAddiEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objQuestionnaireAddiEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionnaireSetId = '{0}',", strQuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.Append(" QuestionnaireSetId = null,"); //问卷集ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionScore))
 {
 if (objQuestionnaireAddiEN.QuestionScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.QuestionScore, conQuestionnaireAddi.QuestionScore); //题目得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionScore); //题目得分
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionNameAdd))
 {
 if (objQuestionnaireAddiEN.QuestionNameAdd !=  null)
 {
 var strQuestionNameAdd = objQuestionnaireAddiEN.QuestionNameAdd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionNameAdd = '{0}',", strQuestionNameAdd); //题目补充
 }
 else
 {
 sbSQL.Append(" QuestionNameAdd = null,"); //题目补充
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.DefaultValue))
 {
 if (objQuestionnaireAddiEN.DefaultValue !=  null)
 {
 var strDefaultValue = objQuestionnaireAddiEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultValue = '{0}',", strDefaultValue); //缺省值
 }
 else
 {
 sbSQL.Append(" DefaultValue = null,"); //缺省值
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.TextDirectId))
 {
 if (objQuestionnaireAddiEN.TextDirectId !=  null)
 {
 var strTextDirectId = objQuestionnaireAddiEN.TextDirectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextDirectId = '{0}',", strTextDirectId); //文本方向ID
 }
 else
 {
 sbSQL.Append(" TextDirectId = null,"); //文本方向ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.FillInTextWidth))
 {
 if (objQuestionnaireAddiEN.FillInTextWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.FillInTextWidth, conQuestionnaireAddi.FillInTextWidth); //填空框宽度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.FillInTextWidth); //填空框宽度
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.MemoTextWidth))
 {
 if (objQuestionnaireAddiEN.MemoTextWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.MemoTextWidth, conQuestionnaireAddi.MemoTextWidth); //备注框宽度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.MemoTextWidth); //备注框宽度
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTab))
 {
 if (objQuestionnaireAddiEN.CodeTab !=  null)
 {
 var strCodeTab = objQuestionnaireAddiEN.CodeTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTab = '{0}',", strCodeTab); //代码表
 }
 else
 {
 sbSQL.Append(" CodeTab = null,"); //代码表
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTabCode))
 {
 if (objQuestionnaireAddiEN.CodeTabCode !=  null)
 {
 var strCodeTabCode = objQuestionnaireAddiEN.CodeTabCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabCode = '{0}',", strCodeTabCode); //CodeTab_Code
 }
 else
 {
 sbSQL.Append(" CodeTabCode = null,"); //CodeTab_Code
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTabName))
 {
 if (objQuestionnaireAddiEN.CodeTabName !=  null)
 {
 var strCodeTabName = objQuestionnaireAddiEN.CodeTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabName = '{0}',", strCodeTabName); //CodeTab_Name
 }
 else
 {
 sbSQL.Append(" CodeTabName = null,"); //CodeTab_Name
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTabCondition))
 {
 if (objQuestionnaireAddiEN.CodeTabCondition !=  null)
 {
 var strCodeTabCondition = objQuestionnaireAddiEN.CodeTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabCondition = '{0}',", strCodeTabCondition); //代码表_条件
 }
 else
 {
 sbSQL.Append(" CodeTabCondition = null,"); //代码表_条件
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.RelaEvent))
 {
 if (objQuestionnaireAddiEN.RelaEvent !=  null)
 {
 var strRelaEvent = objQuestionnaireAddiEN.RelaEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelaEvent = '{0}',", strRelaEvent); //相关事件
 }
 else
 {
 sbSQL.Append(" RelaEvent = null,"); //相关事件
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.FirstIndent))
 {
 sbSQL.AppendFormat(" FirstIndent = '{0}',", objQuestionnaireAddiEN.FirstIndent == true?"1":"0"); //首行缩进
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.DefaultSelectItem))
 {
 if (objQuestionnaireAddiEN.DefaultSelectItem !=  null)
 {
 var strDefaultSelectItem = objQuestionnaireAddiEN.DefaultSelectItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultSelectItem = '{0}',", strDefaultSelectItem); //默认选项
 }
 else
 {
 sbSQL.Append(" DefaultSelectItem = null,"); //默认选项
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IfLinkage))
 {
 sbSQL.AppendFormat(" IfLinkage = '{0}',", objQuestionnaireAddiEN.IfLinkage == true?"1":"0"); //是否联动
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LinkageIndex))
 {
 if (objQuestionnaireAddiEN.LinkageIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.LinkageIndex, conQuestionnaireAddi.LinkageIndex); //联动题序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.LinkageIndex); //联动题序号
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsAutoGridTitle))
 {
 sbSQL.AppendFormat(" IsAutoGridTitle = '{0}',", objQuestionnaireAddiEN.IsAutoGridTitle == true?"1":"0"); //是否自动编表格标题
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.FillInTextHeight))
 {
 if (objQuestionnaireAddiEN.FillInTextHeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.FillInTextHeight, conQuestionnaireAddi.FillInTextHeight); //填空框高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.FillInTextHeight); //填空框高度
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsMulti4FillInText))
 {
 sbSQL.AppendFormat(" IsMulti4FillInText = '{0}',", objQuestionnaireAddiEN.IsMulti4FillInText == true?"1":"0"); //是否填空框多行
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CheckBoxLimitCount))
 {
 if (objQuestionnaireAddiEN.CheckBoxLimitCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.CheckBoxLimitCount, conQuestionnaireAddi.CheckBoxLimitCount); //复选框限制数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.CheckBoxLimitCount); //复选框限制数
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.RoleId))
 {
 if (objQuestionnaireAddiEN.RoleId !=  null)
 {
 var strRoleId = objQuestionnaireAddiEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色Id
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objQuestionnaireAddiEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsCast))
 {
 sbSQL.AppendFormat(" IsCast = '{0}',", objQuestionnaireAddiEN.IsCast == true?"1":"0"); //是否播放
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LikeCount))
 {
 if (objQuestionnaireAddiEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.LikeCount, conQuestionnaireAddi.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.LikeCount); //资源喜欢数量
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.AnswerAttLimitSize))
 {
 if (objQuestionnaireAddiEN.AnswerAttLimitSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.AnswerAttLimitSize, conQuestionnaireAddi.AnswerAttLimitSize); //回答附件限制大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.AnswerAttLimitSize); //回答附件限制大小
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LimitedResourceType))
 {
 if (objQuestionnaireAddiEN.LimitedResourceType !=  null)
 {
 var strLimitedResourceType = objQuestionnaireAddiEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LimitedResourceType = '{0}',", strLimitedResourceType); //限制资源类型
 }
 else
 {
 sbSQL.Append(" LimitedResourceType = null,"); //限制资源类型
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsEffective))
 {
 sbSQL.AppendFormat(" IsEffective = '{0}',", objQuestionnaireAddiEN.IsEffective == true?"1":"0"); //是否有效
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsCanInPaper))
 {
 sbSQL.AppendFormat(" IsCanInPaper = '{0}',", objQuestionnaireAddiEN.IsCanInPaper == true?"1":"0"); //是否可在Paper
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.UpdDate))
 {
 if (objQuestionnaireAddiEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionnaireAddiEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.UpdUser))
 {
 if (objQuestionnaireAddiEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionnaireAddiEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.Memo))
 {
 if (objQuestionnaireAddiEN.Memo !=  null)
 {
 var strMemo = objQuestionnaireAddiEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQuestionnaireAddiEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQuestionnaireAddiEN objQuestionnaireAddiEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQuestionnaireAddiEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireAddiEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireAddiEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QuestionnaireAddi Set ");
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionIndex))
 {
 if (objQuestionnaireAddiEN.QuestionIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.QuestionIndex, conQuestionnaireAddi.QuestionIndex); //题目序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionIndex); //题目序号
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionName))
 {
 if (objQuestionnaireAddiEN.QuestionName !=  null)
 {
 var strQuestionName = objQuestionnaireAddiEN.QuestionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionName = '{0}',", strQuestionName); //题目名称
 }
 else
 {
 sbSQL.Append(" QuestionName = null,"); //题目名称
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionContent))
 {
 if (objQuestionnaireAddiEN.QuestionContent !=  null)
 {
 var strQuestionContent = objQuestionnaireAddiEN.QuestionContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionContent = '{0}',", strQuestionContent); //题目内容
 }
 else
 {
 sbSQL.Append(" QuestionContent = null,"); //题目内容
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionMemo))
 {
 if (objQuestionnaireAddiEN.QuestionMemo !=  null)
 {
 var strQuestionMemo = objQuestionnaireAddiEN.QuestionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionMemo = '{0}',", strQuestionMemo); //题目说明
 }
 else
 {
 sbSQL.Append(" QuestionMemo = null,"); //题目说明
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionNo))
 {
 if (objQuestionnaireAddiEN.QuestionNo !=  null)
 {
 var strQuestionNo = objQuestionnaireAddiEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionNo = '{0}',", strQuestionNo); //题目编号
 }
 else
 {
 sbSQL.Append(" QuestionNo = null,"); //题目编号
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.ParentQuestionId))
 {
 if (objQuestionnaireAddiEN.ParentQuestionId !=  null)
 {
 var strParentQuestionId = objQuestionnaireAddiEN.ParentQuestionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentQuestionId = '{0}',", strParentQuestionId); //父题目Id
 }
 else
 {
 sbSQL.Append(" ParentQuestionId = null,"); //父题目Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.ExamAnswer))
 {
 if (objQuestionnaireAddiEN.ExamAnswer !=  null)
 {
 var strExamAnswer = objQuestionnaireAddiEN.ExamAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamAnswer = '{0}',", strExamAnswer); //题目答案
 }
 else
 {
 sbSQL.Append(" ExamAnswer = null,"); //题目答案
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CourseId))
 {
 if (objQuestionnaireAddiEN.CourseId !=  null)
 {
 var strCourseId = objQuestionnaireAddiEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LevelNo))
 {
 if (objQuestionnaireAddiEN.LevelNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.LevelNo, conQuestionnaireAddi.LevelNo); //学习关号2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.LevelNo); //学习关号2
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CourseChapterId))
 {
 if (objQuestionnaireAddiEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objQuestionnaireAddiEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionTypeId))
 {
 if (objQuestionnaireAddiEN.QuestionTypeId  ==  "")
 {
 objQuestionnaireAddiEN.QuestionTypeId = null;
 }
 if (objQuestionnaireAddiEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objQuestionnaireAddiEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionTypeId = '{0}',", strQuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.Append(" QuestionTypeId = null,"); //题目类型Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionTypeId4Course))
 {
 if (objQuestionnaireAddiEN.QuestionTypeId4Course !=  null)
 {
 var strQuestionTypeId4Course = objQuestionnaireAddiEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionTypeId4Course = '{0}',", strQuestionTypeId4Course); //题目类型Id4课程
 }
 else
 {
 sbSQL.Append(" QuestionTypeId4Course = null,"); //题目类型Id4课程
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.ExamGradeId))
 {
 if (objQuestionnaireAddiEN.ExamGradeId  ==  "")
 {
 objQuestionnaireAddiEN.ExamGradeId = null;
 }
 if (objQuestionnaireAddiEN.ExamGradeId !=  null)
 {
 var strExamGradeId = objQuestionnaireAddiEN.ExamGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamGradeId = '{0}',", strExamGradeId); //题库等级ID
 }
 else
 {
 sbSQL.Append(" ExamGradeId = null,"); //题库等级ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.AnswerTypeId))
 {
 if (objQuestionnaireAddiEN.AnswerTypeId  ==  "")
 {
 objQuestionnaireAddiEN.AnswerTypeId = null;
 }
 if (objQuestionnaireAddiEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objQuestionnaireAddiEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTypeId = '{0}',", strAnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.Append(" AnswerTypeId = null,"); //答案类型ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.GridTitle))
 {
 if (objQuestionnaireAddiEN.GridTitle !=  null)
 {
 var strGridTitle = objQuestionnaireAddiEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GridTitle = '{0}',", strGridTitle); //表格标题
 }
 else
 {
 sbSQL.Append(" GridTitle = null,"); //表格标题
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.AnswerModeId))
 {
 if (objQuestionnaireAddiEN.AnswerModeId  ==  "")
 {
 objQuestionnaireAddiEN.AnswerModeId = null;
 }
 if (objQuestionnaireAddiEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objQuestionnaireAddiEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerModeId = '{0}',", strAnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.Append(" AnswerModeId = null,"); //答案模式Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsHaveAdditionalMemo))
 {
 sbSQL.AppendFormat(" IsHaveAdditionalMemo = '{0}',", objQuestionnaireAddiEN.IsHaveAdditionalMemo == true?"1":"0"); //是否有附加说明
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionnaireSetId))
 {
 if (objQuestionnaireAddiEN.QuestionnaireSetId  ==  "")
 {
 objQuestionnaireAddiEN.QuestionnaireSetId = null;
 }
 if (objQuestionnaireAddiEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objQuestionnaireAddiEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionnaireSetId = '{0}',", strQuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.Append(" QuestionnaireSetId = null,"); //问卷集ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionScore))
 {
 if (objQuestionnaireAddiEN.QuestionScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.QuestionScore, conQuestionnaireAddi.QuestionScore); //题目得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionScore); //题目得分
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionNameAdd))
 {
 if (objQuestionnaireAddiEN.QuestionNameAdd !=  null)
 {
 var strQuestionNameAdd = objQuestionnaireAddiEN.QuestionNameAdd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionNameAdd = '{0}',", strQuestionNameAdd); //题目补充
 }
 else
 {
 sbSQL.Append(" QuestionNameAdd = null,"); //题目补充
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.DefaultValue))
 {
 if (objQuestionnaireAddiEN.DefaultValue !=  null)
 {
 var strDefaultValue = objQuestionnaireAddiEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultValue = '{0}',", strDefaultValue); //缺省值
 }
 else
 {
 sbSQL.Append(" DefaultValue = null,"); //缺省值
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.TextDirectId))
 {
 if (objQuestionnaireAddiEN.TextDirectId !=  null)
 {
 var strTextDirectId = objQuestionnaireAddiEN.TextDirectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextDirectId = '{0}',", strTextDirectId); //文本方向ID
 }
 else
 {
 sbSQL.Append(" TextDirectId = null,"); //文本方向ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.FillInTextWidth))
 {
 if (objQuestionnaireAddiEN.FillInTextWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.FillInTextWidth, conQuestionnaireAddi.FillInTextWidth); //填空框宽度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.FillInTextWidth); //填空框宽度
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.MemoTextWidth))
 {
 if (objQuestionnaireAddiEN.MemoTextWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.MemoTextWidth, conQuestionnaireAddi.MemoTextWidth); //备注框宽度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.MemoTextWidth); //备注框宽度
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTab))
 {
 if (objQuestionnaireAddiEN.CodeTab !=  null)
 {
 var strCodeTab = objQuestionnaireAddiEN.CodeTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTab = '{0}',", strCodeTab); //代码表
 }
 else
 {
 sbSQL.Append(" CodeTab = null,"); //代码表
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTabCode))
 {
 if (objQuestionnaireAddiEN.CodeTabCode !=  null)
 {
 var strCodeTabCode = objQuestionnaireAddiEN.CodeTabCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabCode = '{0}',", strCodeTabCode); //CodeTab_Code
 }
 else
 {
 sbSQL.Append(" CodeTabCode = null,"); //CodeTab_Code
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTabName))
 {
 if (objQuestionnaireAddiEN.CodeTabName !=  null)
 {
 var strCodeTabName = objQuestionnaireAddiEN.CodeTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabName = '{0}',", strCodeTabName); //CodeTab_Name
 }
 else
 {
 sbSQL.Append(" CodeTabName = null,"); //CodeTab_Name
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTabCondition))
 {
 if (objQuestionnaireAddiEN.CodeTabCondition !=  null)
 {
 var strCodeTabCondition = objQuestionnaireAddiEN.CodeTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTabCondition = '{0}',", strCodeTabCondition); //代码表_条件
 }
 else
 {
 sbSQL.Append(" CodeTabCondition = null,"); //代码表_条件
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.RelaEvent))
 {
 if (objQuestionnaireAddiEN.RelaEvent !=  null)
 {
 var strRelaEvent = objQuestionnaireAddiEN.RelaEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelaEvent = '{0}',", strRelaEvent); //相关事件
 }
 else
 {
 sbSQL.Append(" RelaEvent = null,"); //相关事件
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.FirstIndent))
 {
 sbSQL.AppendFormat(" FirstIndent = '{0}',", objQuestionnaireAddiEN.FirstIndent == true?"1":"0"); //首行缩进
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.DefaultSelectItem))
 {
 if (objQuestionnaireAddiEN.DefaultSelectItem !=  null)
 {
 var strDefaultSelectItem = objQuestionnaireAddiEN.DefaultSelectItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaultSelectItem = '{0}',", strDefaultSelectItem); //默认选项
 }
 else
 {
 sbSQL.Append(" DefaultSelectItem = null,"); //默认选项
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IfLinkage))
 {
 sbSQL.AppendFormat(" IfLinkage = '{0}',", objQuestionnaireAddiEN.IfLinkage == true?"1":"0"); //是否联动
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LinkageIndex))
 {
 if (objQuestionnaireAddiEN.LinkageIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.LinkageIndex, conQuestionnaireAddi.LinkageIndex); //联动题序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.LinkageIndex); //联动题序号
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsAutoGridTitle))
 {
 sbSQL.AppendFormat(" IsAutoGridTitle = '{0}',", objQuestionnaireAddiEN.IsAutoGridTitle == true?"1":"0"); //是否自动编表格标题
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.FillInTextHeight))
 {
 if (objQuestionnaireAddiEN.FillInTextHeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.FillInTextHeight, conQuestionnaireAddi.FillInTextHeight); //填空框高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.FillInTextHeight); //填空框高度
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsMulti4FillInText))
 {
 sbSQL.AppendFormat(" IsMulti4FillInText = '{0}',", objQuestionnaireAddiEN.IsMulti4FillInText == true?"1":"0"); //是否填空框多行
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CheckBoxLimitCount))
 {
 if (objQuestionnaireAddiEN.CheckBoxLimitCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.CheckBoxLimitCount, conQuestionnaireAddi.CheckBoxLimitCount); //复选框限制数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.CheckBoxLimitCount); //复选框限制数
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.RoleId))
 {
 if (objQuestionnaireAddiEN.RoleId !=  null)
 {
 var strRoleId = objQuestionnaireAddiEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色Id
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objQuestionnaireAddiEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsCast))
 {
 sbSQL.AppendFormat(" IsCast = '{0}',", objQuestionnaireAddiEN.IsCast == true?"1":"0"); //是否播放
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LikeCount))
 {
 if (objQuestionnaireAddiEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.LikeCount, conQuestionnaireAddi.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.LikeCount); //资源喜欢数量
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.AnswerAttLimitSize))
 {
 if (objQuestionnaireAddiEN.AnswerAttLimitSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.AnswerAttLimitSize, conQuestionnaireAddi.AnswerAttLimitSize); //回答附件限制大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.AnswerAttLimitSize); //回答附件限制大小
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LimitedResourceType))
 {
 if (objQuestionnaireAddiEN.LimitedResourceType !=  null)
 {
 var strLimitedResourceType = objQuestionnaireAddiEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LimitedResourceType = '{0}',", strLimitedResourceType); //限制资源类型
 }
 else
 {
 sbSQL.Append(" LimitedResourceType = null,"); //限制资源类型
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsEffective))
 {
 sbSQL.AppendFormat(" IsEffective = '{0}',", objQuestionnaireAddiEN.IsEffective == true?"1":"0"); //是否有效
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsCanInPaper))
 {
 sbSQL.AppendFormat(" IsCanInPaper = '{0}',", objQuestionnaireAddiEN.IsCanInPaper == true?"1":"0"); //是否可在Paper
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.UpdDate))
 {
 if (objQuestionnaireAddiEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionnaireAddiEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.UpdUser))
 {
 if (objQuestionnaireAddiEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionnaireAddiEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.Memo))
 {
 if (objQuestionnaireAddiEN.Memo !=  null)
 {
 var strMemo = objQuestionnaireAddiEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQuestionnaireAddiEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQuestionnaireAddiEN objQuestionnaireAddiEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQuestionnaireAddiEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireAddiEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireAddiEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QuestionnaireAddi Set ");
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionIndex))
 {
 if (objQuestionnaireAddiEN.QuestionIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.QuestionIndex, conQuestionnaireAddi.QuestionIndex); //题目序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionIndex); //题目序号
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionName))
 {
 if (objQuestionnaireAddiEN.QuestionName !=  null)
 {
 var strQuestionName = objQuestionnaireAddiEN.QuestionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionName, conQuestionnaireAddi.QuestionName); //题目名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionName); //题目名称
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionContent))
 {
 if (objQuestionnaireAddiEN.QuestionContent !=  null)
 {
 var strQuestionContent = objQuestionnaireAddiEN.QuestionContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionContent, conQuestionnaireAddi.QuestionContent); //题目内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionContent); //题目内容
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionMemo))
 {
 if (objQuestionnaireAddiEN.QuestionMemo !=  null)
 {
 var strQuestionMemo = objQuestionnaireAddiEN.QuestionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionMemo, conQuestionnaireAddi.QuestionMemo); //题目说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionMemo); //题目说明
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionNo))
 {
 if (objQuestionnaireAddiEN.QuestionNo !=  null)
 {
 var strQuestionNo = objQuestionnaireAddiEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionNo, conQuestionnaireAddi.QuestionNo); //题目编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionNo); //题目编号
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.ParentQuestionId))
 {
 if (objQuestionnaireAddiEN.ParentQuestionId !=  null)
 {
 var strParentQuestionId = objQuestionnaireAddiEN.ParentQuestionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentQuestionId, conQuestionnaireAddi.ParentQuestionId); //父题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.ParentQuestionId); //父题目Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.ExamAnswer))
 {
 if (objQuestionnaireAddiEN.ExamAnswer !=  null)
 {
 var strExamAnswer = objQuestionnaireAddiEN.ExamAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamAnswer, conQuestionnaireAddi.ExamAnswer); //题目答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.ExamAnswer); //题目答案
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CourseId))
 {
 if (objQuestionnaireAddiEN.CourseId !=  null)
 {
 var strCourseId = objQuestionnaireAddiEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conQuestionnaireAddi.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.CourseId); //课程Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LevelNo))
 {
 if (objQuestionnaireAddiEN.LevelNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.LevelNo, conQuestionnaireAddi.LevelNo); //学习关号2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.LevelNo); //学习关号2
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CourseChapterId))
 {
 if (objQuestionnaireAddiEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objQuestionnaireAddiEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, conQuestionnaireAddi.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.CourseChapterId); //课程章节ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionTypeId))
 {
 if (objQuestionnaireAddiEN.QuestionTypeId  ==  "")
 {
 objQuestionnaireAddiEN.QuestionTypeId = null;
 }
 if (objQuestionnaireAddiEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objQuestionnaireAddiEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionTypeId, conQuestionnaireAddi.QuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionTypeId); //题目类型Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionTypeId4Course))
 {
 if (objQuestionnaireAddiEN.QuestionTypeId4Course !=  null)
 {
 var strQuestionTypeId4Course = objQuestionnaireAddiEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionTypeId4Course, conQuestionnaireAddi.QuestionTypeId4Course); //题目类型Id4课程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionTypeId4Course); //题目类型Id4课程
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.ExamGradeId))
 {
 if (objQuestionnaireAddiEN.ExamGradeId  ==  "")
 {
 objQuestionnaireAddiEN.ExamGradeId = null;
 }
 if (objQuestionnaireAddiEN.ExamGradeId !=  null)
 {
 var strExamGradeId = objQuestionnaireAddiEN.ExamGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamGradeId, conQuestionnaireAddi.ExamGradeId); //题库等级ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.ExamGradeId); //题库等级ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.AnswerTypeId))
 {
 if (objQuestionnaireAddiEN.AnswerTypeId  ==  "")
 {
 objQuestionnaireAddiEN.AnswerTypeId = null;
 }
 if (objQuestionnaireAddiEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objQuestionnaireAddiEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTypeId, conQuestionnaireAddi.AnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.AnswerTypeId); //答案类型ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.GridTitle))
 {
 if (objQuestionnaireAddiEN.GridTitle !=  null)
 {
 var strGridTitle = objQuestionnaireAddiEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGridTitle, conQuestionnaireAddi.GridTitle); //表格标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.GridTitle); //表格标题
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.AnswerModeId))
 {
 if (objQuestionnaireAddiEN.AnswerModeId  ==  "")
 {
 objQuestionnaireAddiEN.AnswerModeId = null;
 }
 if (objQuestionnaireAddiEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objQuestionnaireAddiEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerModeId, conQuestionnaireAddi.AnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.AnswerModeId); //答案模式Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsHaveAdditionalMemo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.IsHaveAdditionalMemo == true?"1":"0", conQuestionnaireAddi.IsHaveAdditionalMemo); //是否有附加说明
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionnaireSetId))
 {
 if (objQuestionnaireAddiEN.QuestionnaireSetId  ==  "")
 {
 objQuestionnaireAddiEN.QuestionnaireSetId = null;
 }
 if (objQuestionnaireAddiEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objQuestionnaireAddiEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionnaireSetId, conQuestionnaireAddi.QuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionnaireSetId); //问卷集ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionScore))
 {
 if (objQuestionnaireAddiEN.QuestionScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.QuestionScore, conQuestionnaireAddi.QuestionScore); //题目得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionScore); //题目得分
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.QuestionNameAdd))
 {
 if (objQuestionnaireAddiEN.QuestionNameAdd !=  null)
 {
 var strQuestionNameAdd = objQuestionnaireAddiEN.QuestionNameAdd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionNameAdd, conQuestionnaireAddi.QuestionNameAdd); //题目补充
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.QuestionNameAdd); //题目补充
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.DefaultValue))
 {
 if (objQuestionnaireAddiEN.DefaultValue !=  null)
 {
 var strDefaultValue = objQuestionnaireAddiEN.DefaultValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultValue, conQuestionnaireAddi.DefaultValue); //缺省值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.DefaultValue); //缺省值
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.TextDirectId))
 {
 if (objQuestionnaireAddiEN.TextDirectId !=  null)
 {
 var strTextDirectId = objQuestionnaireAddiEN.TextDirectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextDirectId, conQuestionnaireAddi.TextDirectId); //文本方向ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.TextDirectId); //文本方向ID
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.FillInTextWidth))
 {
 if (objQuestionnaireAddiEN.FillInTextWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.FillInTextWidth, conQuestionnaireAddi.FillInTextWidth); //填空框宽度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.FillInTextWidth); //填空框宽度
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.MemoTextWidth))
 {
 if (objQuestionnaireAddiEN.MemoTextWidth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.MemoTextWidth, conQuestionnaireAddi.MemoTextWidth); //备注框宽度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.MemoTextWidth); //备注框宽度
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTab))
 {
 if (objQuestionnaireAddiEN.CodeTab !=  null)
 {
 var strCodeTab = objQuestionnaireAddiEN.CodeTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTab, conQuestionnaireAddi.CodeTab); //代码表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.CodeTab); //代码表
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTabCode))
 {
 if (objQuestionnaireAddiEN.CodeTabCode !=  null)
 {
 var strCodeTabCode = objQuestionnaireAddiEN.CodeTabCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabCode, conQuestionnaireAddi.CodeTabCode); //CodeTab_Code
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.CodeTabCode); //CodeTab_Code
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTabName))
 {
 if (objQuestionnaireAddiEN.CodeTabName !=  null)
 {
 var strCodeTabName = objQuestionnaireAddiEN.CodeTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabName, conQuestionnaireAddi.CodeTabName); //CodeTab_Name
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.CodeTabName); //CodeTab_Name
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CodeTabCondition))
 {
 if (objQuestionnaireAddiEN.CodeTabCondition !=  null)
 {
 var strCodeTabCondition = objQuestionnaireAddiEN.CodeTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTabCondition, conQuestionnaireAddi.CodeTabCondition); //代码表_条件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.CodeTabCondition); //代码表_条件
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.RelaEvent))
 {
 if (objQuestionnaireAddiEN.RelaEvent !=  null)
 {
 var strRelaEvent = objQuestionnaireAddiEN.RelaEvent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelaEvent, conQuestionnaireAddi.RelaEvent); //相关事件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.RelaEvent); //相关事件
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.FirstIndent))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.FirstIndent == true?"1":"0", conQuestionnaireAddi.FirstIndent); //首行缩进
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.DefaultSelectItem))
 {
 if (objQuestionnaireAddiEN.DefaultSelectItem !=  null)
 {
 var strDefaultSelectItem = objQuestionnaireAddiEN.DefaultSelectItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaultSelectItem, conQuestionnaireAddi.DefaultSelectItem); //默认选项
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.DefaultSelectItem); //默认选项
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IfLinkage))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.IfLinkage == true?"1":"0", conQuestionnaireAddi.IfLinkage); //是否联动
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LinkageIndex))
 {
 if (objQuestionnaireAddiEN.LinkageIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.LinkageIndex, conQuestionnaireAddi.LinkageIndex); //联动题序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.LinkageIndex); //联动题序号
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsAutoGridTitle))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.IsAutoGridTitle == true?"1":"0", conQuestionnaireAddi.IsAutoGridTitle); //是否自动编表格标题
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.FillInTextHeight))
 {
 if (objQuestionnaireAddiEN.FillInTextHeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.FillInTextHeight, conQuestionnaireAddi.FillInTextHeight); //填空框高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.FillInTextHeight); //填空框高度
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsMulti4FillInText))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.IsMulti4FillInText == true?"1":"0", conQuestionnaireAddi.IsMulti4FillInText); //是否填空框多行
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.CheckBoxLimitCount))
 {
 if (objQuestionnaireAddiEN.CheckBoxLimitCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.CheckBoxLimitCount, conQuestionnaireAddi.CheckBoxLimitCount); //复选框限制数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.CheckBoxLimitCount); //复选框限制数
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.RoleId))
 {
 if (objQuestionnaireAddiEN.RoleId !=  null)
 {
 var strRoleId = objQuestionnaireAddiEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conQuestionnaireAddi.RoleId); //角色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.RoleId); //角色Id
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.IsShow == true?"1":"0", conQuestionnaireAddi.IsShow); //是否启用
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsCast))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.IsCast == true?"1":"0", conQuestionnaireAddi.IsCast); //是否播放
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LikeCount))
 {
 if (objQuestionnaireAddiEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.LikeCount, conQuestionnaireAddi.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.LikeCount); //资源喜欢数量
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.AnswerAttLimitSize))
 {
 if (objQuestionnaireAddiEN.AnswerAttLimitSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireAddiEN.AnswerAttLimitSize, conQuestionnaireAddi.AnswerAttLimitSize); //回答附件限制大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.AnswerAttLimitSize); //回答附件限制大小
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.LimitedResourceType))
 {
 if (objQuestionnaireAddiEN.LimitedResourceType !=  null)
 {
 var strLimitedResourceType = objQuestionnaireAddiEN.LimitedResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLimitedResourceType, conQuestionnaireAddi.LimitedResourceType); //限制资源类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.LimitedResourceType); //限制资源类型
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsEffective))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.IsEffective == true?"1":"0", conQuestionnaireAddi.IsEffective); //是否有效
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.IsCanInPaper))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireAddiEN.IsCanInPaper == true?"1":"0", conQuestionnaireAddi.IsCanInPaper); //是否可在Paper
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.UpdDate))
 {
 if (objQuestionnaireAddiEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionnaireAddiEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQuestionnaireAddi.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.UpdDate); //修改日期
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.UpdUser))
 {
 if (objQuestionnaireAddiEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionnaireAddiEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQuestionnaireAddi.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.UpdUser); //修改人
 }
 }
 
 if (objQuestionnaireAddiEN.IsUpdated(conQuestionnaireAddi.Memo))
 {
 if (objQuestionnaireAddiEN.Memo !=  null)
 {
 var strMemo = objQuestionnaireAddiEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQuestionnaireAddi.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireAddi.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where QuestionId = {0}", objQuestionnaireAddiEN.QuestionId); 
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
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngQuestionId,
};
 objSQL.ExecSP("QuestionnaireAddi_Delete", values);
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
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
//删除QuestionnaireAddi本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QuestionnaireAddi where QuestionId = " + ""+ lngQuestionId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQuestionnaireAddi(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
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
//删除QuestionnaireAddi本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QuestionnaireAddi where QuestionId in (" + strKeyList + ")";
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
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
//删除QuestionnaireAddi本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QuestionnaireAddi where QuestionId = " + ""+ lngQuestionId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQuestionnaireAddi(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQuestionnaireAddiDA: DelQuestionnaireAddi)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QuestionnaireAddi where " + strCondition ;
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
public bool DelQuestionnaireAddiWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQuestionnaireAddiDA: DelQuestionnaireAddiWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QuestionnaireAddi where " + strCondition ;
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
 /// <param name = "objQuestionnaireAddiENS">源对象</param>
 /// <param name = "objQuestionnaireAddiENT">目标对象</param>
public void CopyTo(clsQuestionnaireAddiEN objQuestionnaireAddiENS, clsQuestionnaireAddiEN objQuestionnaireAddiENT)
{
objQuestionnaireAddiENT.QuestionId = objQuestionnaireAddiENS.QuestionId; //题目Id
objQuestionnaireAddiENT.QuestionIndex = objQuestionnaireAddiENS.QuestionIndex; //题目序号
objQuestionnaireAddiENT.QuestionName = objQuestionnaireAddiENS.QuestionName; //题目名称
objQuestionnaireAddiENT.QuestionContent = objQuestionnaireAddiENS.QuestionContent; //题目内容
objQuestionnaireAddiENT.QuestionMemo = objQuestionnaireAddiENS.QuestionMemo; //题目说明
objQuestionnaireAddiENT.QuestionNo = objQuestionnaireAddiENS.QuestionNo; //题目编号
objQuestionnaireAddiENT.ParentQuestionId = objQuestionnaireAddiENS.ParentQuestionId; //父题目Id
objQuestionnaireAddiENT.ExamAnswer = objQuestionnaireAddiENS.ExamAnswer; //题目答案
objQuestionnaireAddiENT.CourseId = objQuestionnaireAddiENS.CourseId; //课程Id
objQuestionnaireAddiENT.LevelNo = objQuestionnaireAddiENS.LevelNo; //学习关号2
objQuestionnaireAddiENT.CourseChapterId = objQuestionnaireAddiENS.CourseChapterId; //课程章节ID
objQuestionnaireAddiENT.QuestionTypeId = objQuestionnaireAddiENS.QuestionTypeId; //题目类型Id
objQuestionnaireAddiENT.QuestionTypeId4Course = objQuestionnaireAddiENS.QuestionTypeId4Course; //题目类型Id4课程
objQuestionnaireAddiENT.ExamGradeId = objQuestionnaireAddiENS.ExamGradeId; //题库等级ID
objQuestionnaireAddiENT.AnswerTypeId = objQuestionnaireAddiENS.AnswerTypeId; //答案类型ID
objQuestionnaireAddiENT.GridTitle = objQuestionnaireAddiENS.GridTitle; //表格标题
objQuestionnaireAddiENT.AnswerModeId = objQuestionnaireAddiENS.AnswerModeId; //答案模式Id
objQuestionnaireAddiENT.IsHaveAdditionalMemo = objQuestionnaireAddiENS.IsHaveAdditionalMemo; //是否有附加说明
objQuestionnaireAddiENT.QuestionnaireSetId = objQuestionnaireAddiENS.QuestionnaireSetId; //问卷集ID
objQuestionnaireAddiENT.QuestionScore = objQuestionnaireAddiENS.QuestionScore; //题目得分
objQuestionnaireAddiENT.QuestionNameAdd = objQuestionnaireAddiENS.QuestionNameAdd; //题目补充
objQuestionnaireAddiENT.DefaultValue = objQuestionnaireAddiENS.DefaultValue; //缺省值
objQuestionnaireAddiENT.TextDirectId = objQuestionnaireAddiENS.TextDirectId; //文本方向ID
objQuestionnaireAddiENT.FillInTextWidth = objQuestionnaireAddiENS.FillInTextWidth; //填空框宽度
objQuestionnaireAddiENT.MemoTextWidth = objQuestionnaireAddiENS.MemoTextWidth; //备注框宽度
objQuestionnaireAddiENT.CodeTab = objQuestionnaireAddiENS.CodeTab; //代码表
objQuestionnaireAddiENT.CodeTabCode = objQuestionnaireAddiENS.CodeTabCode; //CodeTab_Code
objQuestionnaireAddiENT.CodeTabName = objQuestionnaireAddiENS.CodeTabName; //CodeTab_Name
objQuestionnaireAddiENT.CodeTabCondition = objQuestionnaireAddiENS.CodeTabCondition; //代码表_条件
objQuestionnaireAddiENT.RelaEvent = objQuestionnaireAddiENS.RelaEvent; //相关事件
objQuestionnaireAddiENT.FirstIndent = objQuestionnaireAddiENS.FirstIndent; //首行缩进
objQuestionnaireAddiENT.DefaultSelectItem = objQuestionnaireAddiENS.DefaultSelectItem; //默认选项
objQuestionnaireAddiENT.IfLinkage = objQuestionnaireAddiENS.IfLinkage; //是否联动
objQuestionnaireAddiENT.LinkageIndex = objQuestionnaireAddiENS.LinkageIndex; //联动题序号
objQuestionnaireAddiENT.IsAutoGridTitle = objQuestionnaireAddiENS.IsAutoGridTitle; //是否自动编表格标题
objQuestionnaireAddiENT.FillInTextHeight = objQuestionnaireAddiENS.FillInTextHeight; //填空框高度
objQuestionnaireAddiENT.IsMulti4FillInText = objQuestionnaireAddiENS.IsMulti4FillInText; //是否填空框多行
objQuestionnaireAddiENT.CheckBoxLimitCount = objQuestionnaireAddiENS.CheckBoxLimitCount; //复选框限制数
objQuestionnaireAddiENT.RoleId = objQuestionnaireAddiENS.RoleId; //角色Id
objQuestionnaireAddiENT.IsShow = objQuestionnaireAddiENS.IsShow; //是否启用
objQuestionnaireAddiENT.IsCast = objQuestionnaireAddiENS.IsCast; //是否播放
objQuestionnaireAddiENT.LikeCount = objQuestionnaireAddiENS.LikeCount; //资源喜欢数量
objQuestionnaireAddiENT.AnswerAttLimitSize = objQuestionnaireAddiENS.AnswerAttLimitSize; //回答附件限制大小
objQuestionnaireAddiENT.LimitedResourceType = objQuestionnaireAddiENS.LimitedResourceType; //限制资源类型
objQuestionnaireAddiENT.IsEffective = objQuestionnaireAddiENS.IsEffective; //是否有效
objQuestionnaireAddiENT.IsCanInPaper = objQuestionnaireAddiENS.IsCanInPaper; //是否可在Paper
objQuestionnaireAddiENT.UpdDate = objQuestionnaireAddiENS.UpdDate; //修改日期
objQuestionnaireAddiENT.UpdUser = objQuestionnaireAddiENS.UpdUser; //修改人
objQuestionnaireAddiENT.Memo = objQuestionnaireAddiENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQuestionnaireAddiEN.QuestionName, conQuestionnaireAddi.QuestionName);
clsCheckSql.CheckFieldNotNull(objQuestionnaireAddiEN.CourseId, conQuestionnaireAddi.CourseId);
clsCheckSql.CheckFieldNotNull(objQuestionnaireAddiEN.QuestionTypeId4Course, conQuestionnaireAddi.QuestionTypeId4Course);
clsCheckSql.CheckFieldNotNull(objQuestionnaireAddiEN.AnswerTypeId, conQuestionnaireAddi.AnswerTypeId);
clsCheckSql.CheckFieldNotNull(objQuestionnaireAddiEN.TextDirectId, conQuestionnaireAddi.TextDirectId);
clsCheckSql.CheckFieldNotNull(objQuestionnaireAddiEN.UpdDate, conQuestionnaireAddi.UpdDate);
clsCheckSql.CheckFieldNotNull(objQuestionnaireAddiEN.UpdUser, conQuestionnaireAddi.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionName, 500, conQuestionnaireAddi.QuestionName);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionContent, 4000, conQuestionnaireAddi.QuestionContent);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionMemo, 1000, conQuestionnaireAddi.QuestionMemo);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionNo, 10, conQuestionnaireAddi.QuestionNo);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.ParentQuestionId, 8, conQuestionnaireAddi.ParentQuestionId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.ExamAnswer, 8000, conQuestionnaireAddi.ExamAnswer);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CourseId, 8, conQuestionnaireAddi.CourseId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CourseChapterId, 8, conQuestionnaireAddi.CourseChapterId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionTypeId, 2, conQuestionnaireAddi.QuestionTypeId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionTypeId4Course, 8, conQuestionnaireAddi.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.ExamGradeId, 2, conQuestionnaireAddi.ExamGradeId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.AnswerTypeId, 2, conQuestionnaireAddi.AnswerTypeId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.GridTitle, 30, conQuestionnaireAddi.GridTitle);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.AnswerModeId, 4, conQuestionnaireAddi.AnswerModeId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionnaireSetId, 4, conQuestionnaireAddi.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionNameAdd, 500, conQuestionnaireAddi.QuestionNameAdd);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.DefaultValue, 50, conQuestionnaireAddi.DefaultValue);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.TextDirectId, 4, conQuestionnaireAddi.TextDirectId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CodeTab, 50, conQuestionnaireAddi.CodeTab);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CodeTabCode, 50, conQuestionnaireAddi.CodeTabCode);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CodeTabName, 50, conQuestionnaireAddi.CodeTabName);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CodeTabCondition, 200, conQuestionnaireAddi.CodeTabCondition);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.RelaEvent, 4000, conQuestionnaireAddi.RelaEvent);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.DefaultSelectItem, 20, conQuestionnaireAddi.DefaultSelectItem);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.RoleId, 8, conQuestionnaireAddi.RoleId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.LimitedResourceType, 100, conQuestionnaireAddi.LimitedResourceType);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.UpdDate, 20, conQuestionnaireAddi.UpdDate);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.UpdUser, 20, conQuestionnaireAddi.UpdUser);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.Memo, 1000, conQuestionnaireAddi.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objQuestionnaireAddiEN.QuestionTypeId, 2, conQuestionnaireAddi.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireAddiEN.ExamGradeId, 2, conQuestionnaireAddi.ExamGradeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireAddiEN.AnswerTypeId, 2, conQuestionnaireAddi.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireAddiEN.AnswerModeId, 4, conQuestionnaireAddi.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireAddiEN.QuestionnaireSetId, 4, conQuestionnaireAddi.QuestionnaireSetId);
 objQuestionnaireAddiEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionName, 500, conQuestionnaireAddi.QuestionName);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionContent, 4000, conQuestionnaireAddi.QuestionContent);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionMemo, 1000, conQuestionnaireAddi.QuestionMemo);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionNo, 10, conQuestionnaireAddi.QuestionNo);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.ParentQuestionId, 8, conQuestionnaireAddi.ParentQuestionId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.ExamAnswer, 8000, conQuestionnaireAddi.ExamAnswer);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CourseId, 8, conQuestionnaireAddi.CourseId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CourseChapterId, 8, conQuestionnaireAddi.CourseChapterId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionTypeId, 2, conQuestionnaireAddi.QuestionTypeId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionTypeId4Course, 8, conQuestionnaireAddi.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.ExamGradeId, 2, conQuestionnaireAddi.ExamGradeId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.AnswerTypeId, 2, conQuestionnaireAddi.AnswerTypeId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.GridTitle, 30, conQuestionnaireAddi.GridTitle);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.AnswerModeId, 4, conQuestionnaireAddi.AnswerModeId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionnaireSetId, 4, conQuestionnaireAddi.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionNameAdd, 500, conQuestionnaireAddi.QuestionNameAdd);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.DefaultValue, 50, conQuestionnaireAddi.DefaultValue);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.TextDirectId, 4, conQuestionnaireAddi.TextDirectId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CodeTab, 50, conQuestionnaireAddi.CodeTab);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CodeTabCode, 50, conQuestionnaireAddi.CodeTabCode);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CodeTabName, 50, conQuestionnaireAddi.CodeTabName);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CodeTabCondition, 200, conQuestionnaireAddi.CodeTabCondition);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.RelaEvent, 4000, conQuestionnaireAddi.RelaEvent);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.DefaultSelectItem, 20, conQuestionnaireAddi.DefaultSelectItem);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.RoleId, 8, conQuestionnaireAddi.RoleId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.LimitedResourceType, 100, conQuestionnaireAddi.LimitedResourceType);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.UpdDate, 20, conQuestionnaireAddi.UpdDate);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.UpdUser, 20, conQuestionnaireAddi.UpdUser);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.Memo, 1000, conQuestionnaireAddi.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQuestionnaireAddiEN.QuestionTypeId, 2, conQuestionnaireAddi.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireAddiEN.ExamGradeId, 2, conQuestionnaireAddi.ExamGradeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireAddiEN.AnswerTypeId, 2, conQuestionnaireAddi.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireAddiEN.AnswerModeId, 4, conQuestionnaireAddi.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireAddiEN.QuestionnaireSetId, 4, conQuestionnaireAddi.QuestionnaireSetId);
 objQuestionnaireAddiEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQuestionnaireAddiEN objQuestionnaireAddiEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionName, 500, conQuestionnaireAddi.QuestionName);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionContent, 4000, conQuestionnaireAddi.QuestionContent);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionMemo, 1000, conQuestionnaireAddi.QuestionMemo);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionNo, 10, conQuestionnaireAddi.QuestionNo);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.ParentQuestionId, 8, conQuestionnaireAddi.ParentQuestionId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.ExamAnswer, 8000, conQuestionnaireAddi.ExamAnswer);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CourseId, 8, conQuestionnaireAddi.CourseId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CourseChapterId, 8, conQuestionnaireAddi.CourseChapterId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionTypeId, 2, conQuestionnaireAddi.QuestionTypeId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionTypeId4Course, 8, conQuestionnaireAddi.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.ExamGradeId, 2, conQuestionnaireAddi.ExamGradeId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.AnswerTypeId, 2, conQuestionnaireAddi.AnswerTypeId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.GridTitle, 30, conQuestionnaireAddi.GridTitle);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.AnswerModeId, 4, conQuestionnaireAddi.AnswerModeId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionnaireSetId, 4, conQuestionnaireAddi.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.QuestionNameAdd, 500, conQuestionnaireAddi.QuestionNameAdd);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.DefaultValue, 50, conQuestionnaireAddi.DefaultValue);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.TextDirectId, 4, conQuestionnaireAddi.TextDirectId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CodeTab, 50, conQuestionnaireAddi.CodeTab);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CodeTabCode, 50, conQuestionnaireAddi.CodeTabCode);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CodeTabName, 50, conQuestionnaireAddi.CodeTabName);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.CodeTabCondition, 200, conQuestionnaireAddi.CodeTabCondition);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.RelaEvent, 4000, conQuestionnaireAddi.RelaEvent);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.DefaultSelectItem, 20, conQuestionnaireAddi.DefaultSelectItem);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.RoleId, 8, conQuestionnaireAddi.RoleId);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.LimitedResourceType, 100, conQuestionnaireAddi.LimitedResourceType);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.UpdDate, 20, conQuestionnaireAddi.UpdDate);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.UpdUser, 20, conQuestionnaireAddi.UpdUser);
clsCheckSql.CheckFieldLen(objQuestionnaireAddiEN.Memo, 1000, conQuestionnaireAddi.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.QuestionName, conQuestionnaireAddi.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.QuestionContent, conQuestionnaireAddi.QuestionContent);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.QuestionMemo, conQuestionnaireAddi.QuestionMemo);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.QuestionNo, conQuestionnaireAddi.QuestionNo);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.ParentQuestionId, conQuestionnaireAddi.ParentQuestionId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.ExamAnswer, conQuestionnaireAddi.ExamAnswer);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.CourseId, conQuestionnaireAddi.CourseId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.CourseChapterId, conQuestionnaireAddi.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.QuestionTypeId, conQuestionnaireAddi.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.QuestionTypeId4Course, conQuestionnaireAddi.QuestionTypeId4Course);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.ExamGradeId, conQuestionnaireAddi.ExamGradeId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.AnswerTypeId, conQuestionnaireAddi.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.GridTitle, conQuestionnaireAddi.GridTitle);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.AnswerModeId, conQuestionnaireAddi.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.QuestionnaireSetId, conQuestionnaireAddi.QuestionnaireSetId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.QuestionNameAdd, conQuestionnaireAddi.QuestionNameAdd);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.DefaultValue, conQuestionnaireAddi.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.TextDirectId, conQuestionnaireAddi.TextDirectId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.CodeTab, conQuestionnaireAddi.CodeTab);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.CodeTabCode, conQuestionnaireAddi.CodeTabCode);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.CodeTabName, conQuestionnaireAddi.CodeTabName);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.CodeTabCondition, conQuestionnaireAddi.CodeTabCondition);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.RelaEvent, conQuestionnaireAddi.RelaEvent);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.DefaultSelectItem, conQuestionnaireAddi.DefaultSelectItem);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.RoleId, conQuestionnaireAddi.RoleId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.LimitedResourceType, conQuestionnaireAddi.LimitedResourceType);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.UpdDate, conQuestionnaireAddi.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.UpdUser, conQuestionnaireAddi.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireAddiEN.Memo, conQuestionnaireAddi.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objQuestionnaireAddiEN.QuestionTypeId, 2, conQuestionnaireAddi.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireAddiEN.ExamGradeId, 2, conQuestionnaireAddi.ExamGradeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireAddiEN.AnswerTypeId, 2, conQuestionnaireAddi.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireAddiEN.AnswerModeId, 4, conQuestionnaireAddi.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(objQuestionnaireAddiEN.QuestionnaireSetId, 4, conQuestionnaireAddi.QuestionnaireSetId);
 objQuestionnaireAddiEN._IsCheckProperty = true;
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
string strSQL = "select QuestionId, QuestionName from QuestionnaireAddi ";
 clsSpecSQLforSql mySql = clsQuestionnaireAddiDA.GetSpecSQLObj();
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
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
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
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
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
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQuestionnaireAddiEN._CurrTabName);
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
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQuestionnaireAddiEN._CurrTabName, strCondition);
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
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
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
 objSQL = clsQuestionnaireAddiDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}