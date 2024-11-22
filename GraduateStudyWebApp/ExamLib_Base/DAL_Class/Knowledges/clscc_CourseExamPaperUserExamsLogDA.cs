
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseExamPaperUserExamsLogDA
 表名:cc_CourseExamPaperUserExamsLog(01120091)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:06
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
 /// 学生考卷答题记录(cc_CourseExamPaperUserExamsLog)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_CourseExamPaperUserExamsLogDA : clsCommBase4DA
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
 return clscc_CourseExamPaperUserExamsLogEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_CourseExamPaperUserExamsLogEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_CourseExamPaperUserExamsLogEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_CourseExamPaperUserExamsLogEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_CourseExamPaperUserExamsLogEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaperUserExamsLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_CourseExamPaperUserExamsLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: GetDataTable_cc_CourseExamPaperUserExamsLog)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaperUserExamsLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaperUserExamsLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseExamPaperUserExamsLog where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseExamPaperUserExamsLog where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_CourseExamPaperUserExamsLog where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_CourseExamPaperUserExamsLog.* from cc_CourseExamPaperUserExamsLog Left Join {1} on {2} where {3} and cc_CourseExamPaperUserExamsLog.mId not in (Select top {5} cc_CourseExamPaperUserExamsLog.mId from cc_CourseExamPaperUserExamsLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseExamPaperUserExamsLog where {1} and mId not in (Select top {2} mId from cc_CourseExamPaperUserExamsLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseExamPaperUserExamsLog where {1} and mId not in (Select top {3} mId from cc_CourseExamPaperUserExamsLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_CourseExamPaperUserExamsLog.* from cc_CourseExamPaperUserExamsLog Left Join {1} on {2} where {3} and cc_CourseExamPaperUserExamsLog.mId not in (Select top {5} cc_CourseExamPaperUserExamsLog.mId from cc_CourseExamPaperUserExamsLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseExamPaperUserExamsLog where {1} and mId not in (Select top {2} mId from cc_CourseExamPaperUserExamsLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseExamPaperUserExamsLog where {1} and mId not in (Select top {3} mId from cc_CourseExamPaperUserExamsLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_CourseExamPaperUserExamsLogEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_CourseExamPaperUserExamsLogDA:GetObjLst)", objException.Message));
}
List<clscc_CourseExamPaperUserExamsLogEN> arrObjLst = new List<clscc_CourseExamPaperUserExamsLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaperUserExamsLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN = new clscc_CourseExamPaperUserExamsLogEN();
try
{
objcc_CourseExamPaperUserExamsLogEN.mId = TransNullToInt(objRow[concc_CourseExamPaperUserExamsLog.mId].ToString().Trim()); //mId
objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId = objRow[concc_CourseExamPaperUserExamsLog.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperUserExamsLogEN.QuestionId = objRow[concc_CourseExamPaperUserExamsLog.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseExamPaperUserExamsLog.QuestionId].ToString().Trim()); //题目Id
objcc_CourseExamPaperUserExamsLogEN.IsTrue = TransNullToBool(objRow[concc_CourseExamPaperUserExamsLog.IsTrue].ToString().Trim()); //是否正确
objcc_CourseExamPaperUserExamsLogEN.Score = objRow[concc_CourseExamPaperUserExamsLog.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseExamPaperUserExamsLog.Score].ToString().Trim()); //得分
objcc_CourseExamPaperUserExamsLogEN.CourseId = objRow[concc_CourseExamPaperUserExamsLog.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds = objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds].ToString().Trim(); //答案Ids
objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent = objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent].ToString().Trim(); //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
objcc_CourseExamPaperUserExamsLogEN.IsShow = TransNullToBool(objRow[concc_CourseExamPaperUserExamsLog.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperUserExamsLogEN.CreateTime = objRow[concc_CourseExamPaperUserExamsLog.CreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CreateTime].ToString().Trim(); //建立时间
objcc_CourseExamPaperUserExamsLogEN.UserId = objRow[concc_CourseExamPaperUserExamsLog.UserId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: GetObjLst)", objException.Message));
}
objcc_CourseExamPaperUserExamsLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_CourseExamPaperUserExamsLogEN);
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
public List<clscc_CourseExamPaperUserExamsLogEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_CourseExamPaperUserExamsLogDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_CourseExamPaperUserExamsLogEN> arrObjLst = new List<clscc_CourseExamPaperUserExamsLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN = new clscc_CourseExamPaperUserExamsLogEN();
try
{
objcc_CourseExamPaperUserExamsLogEN.mId = TransNullToInt(objRow[concc_CourseExamPaperUserExamsLog.mId].ToString().Trim()); //mId
objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId = objRow[concc_CourseExamPaperUserExamsLog.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperUserExamsLogEN.QuestionId = objRow[concc_CourseExamPaperUserExamsLog.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseExamPaperUserExamsLog.QuestionId].ToString().Trim()); //题目Id
objcc_CourseExamPaperUserExamsLogEN.IsTrue = TransNullToBool(objRow[concc_CourseExamPaperUserExamsLog.IsTrue].ToString().Trim()); //是否正确
objcc_CourseExamPaperUserExamsLogEN.Score = objRow[concc_CourseExamPaperUserExamsLog.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseExamPaperUserExamsLog.Score].ToString().Trim()); //得分
objcc_CourseExamPaperUserExamsLogEN.CourseId = objRow[concc_CourseExamPaperUserExamsLog.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds = objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds].ToString().Trim(); //答案Ids
objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent = objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent].ToString().Trim(); //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
objcc_CourseExamPaperUserExamsLogEN.IsShow = TransNullToBool(objRow[concc_CourseExamPaperUserExamsLog.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperUserExamsLogEN.CreateTime = objRow[concc_CourseExamPaperUserExamsLog.CreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CreateTime].ToString().Trim(); //建立时间
objcc_CourseExamPaperUserExamsLogEN.UserId = objRow[concc_CourseExamPaperUserExamsLog.UserId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: GetObjLst)", objException.Message));
}
objcc_CourseExamPaperUserExamsLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_CourseExamPaperUserExamsLogEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_CourseExamPaperUserExamsLog(ref clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaperUserExamsLog where mId = " + ""+ objcc_CourseExamPaperUserExamsLogEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_CourseExamPaperUserExamsLogEN.mId = TransNullToInt(objDT.Rows[0][concc_CourseExamPaperUserExamsLog.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId = objDT.Rows[0][concc_CourseExamPaperUserExamsLog.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.QuestionId = TransNullToInt(objDT.Rows[0][concc_CourseExamPaperUserExamsLog.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.IsTrue = TransNullToBool(objDT.Rows[0][concc_CourseExamPaperUserExamsLog.IsTrue].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.Score = TransNullToDouble(objDT.Rows[0][concc_CourseExamPaperUserExamsLog.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.CourseId = objDT.Rows[0][concc_CourseExamPaperUserExamsLog.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds = objDT.Rows[0][concc_CourseExamPaperUserExamsLog.QuestionAnswerIds].ToString().Trim(); //答案Ids(字段类型:varchar,字段长度:255,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent = objDT.Rows[0][concc_CourseExamPaperUserExamsLog.QuestionAnswerContent].ToString().Trim(); //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.IsShow = TransNullToBool(objDT.Rows[0][concc_CourseExamPaperUserExamsLog.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.CreateTime = objDT.Rows[0][concc_CourseExamPaperUserExamsLog.CreateTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:16,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.UserId = objDT.Rows[0][concc_CourseExamPaperUserExamsLog.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: Getcc_CourseExamPaperUserExamsLog)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clscc_CourseExamPaperUserExamsLogEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaperUserExamsLog where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN = new clscc_CourseExamPaperUserExamsLogEN();
try
{
 objcc_CourseExamPaperUserExamsLogEN.mId = Int32.Parse(objRow[concc_CourseExamPaperUserExamsLog.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId = objRow[concc_CourseExamPaperUserExamsLog.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.QuestionId = objRow[concc_CourseExamPaperUserExamsLog.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserExamsLog.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.IsTrue = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaperUserExamsLog.IsTrue].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.Score = objRow[concc_CourseExamPaperUserExamsLog.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaperUserExamsLog.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.CourseId = objRow[concc_CourseExamPaperUserExamsLog.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds = objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds].ToString().Trim(); //答案Ids(字段类型:varchar,字段长度:255,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent = objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent].ToString().Trim(); //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaperUserExamsLog.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.CreateTime = objRow[concc_CourseExamPaperUserExamsLog.CreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CreateTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:16,是否可空:True)
 objcc_CourseExamPaperUserExamsLogEN.UserId = objRow[concc_CourseExamPaperUserExamsLog.UserId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: GetObjBymId)", objException.Message));
}
return objcc_CourseExamPaperUserExamsLogEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_CourseExamPaperUserExamsLogEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaperUserExamsLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN = new clscc_CourseExamPaperUserExamsLogEN()
{
mId = TransNullToInt(objRow[concc_CourseExamPaperUserExamsLog.mId].ToString().Trim()), //mId
CourseExamPaperId = objRow[concc_CourseExamPaperUserExamsLog.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CourseExamPaperId].ToString().Trim(), //考卷流水号
QuestionId = objRow[concc_CourseExamPaperUserExamsLog.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseExamPaperUserExamsLog.QuestionId].ToString().Trim()), //题目Id
IsTrue = TransNullToBool(objRow[concc_CourseExamPaperUserExamsLog.IsTrue].ToString().Trim()), //是否正确
Score = objRow[concc_CourseExamPaperUserExamsLog.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseExamPaperUserExamsLog.Score].ToString().Trim()), //得分
CourseId = objRow[concc_CourseExamPaperUserExamsLog.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CourseId].ToString().Trim(), //课程Id
QuestionAnswerIds = objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds].ToString().Trim(), //答案Ids
QuestionAnswerContent = objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent].ToString().Trim(), //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
IsShow = TransNullToBool(objRow[concc_CourseExamPaperUserExamsLog.IsShow].ToString().Trim()), //是否启用
CreateTime = objRow[concc_CourseExamPaperUserExamsLog.CreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CreateTime].ToString().Trim(), //建立时间
UserId = objRow[concc_CourseExamPaperUserExamsLog.UserId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.UserId].ToString().Trim() //用户ID
};
objcc_CourseExamPaperUserExamsLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseExamPaperUserExamsLogEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_CourseExamPaperUserExamsLogEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN = new clscc_CourseExamPaperUserExamsLogEN();
try
{
objcc_CourseExamPaperUserExamsLogEN.mId = TransNullToInt(objRow[concc_CourseExamPaperUserExamsLog.mId].ToString().Trim()); //mId
objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId = objRow[concc_CourseExamPaperUserExamsLog.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperUserExamsLogEN.QuestionId = objRow[concc_CourseExamPaperUserExamsLog.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseExamPaperUserExamsLog.QuestionId].ToString().Trim()); //题目Id
objcc_CourseExamPaperUserExamsLogEN.IsTrue = TransNullToBool(objRow[concc_CourseExamPaperUserExamsLog.IsTrue].ToString().Trim()); //是否正确
objcc_CourseExamPaperUserExamsLogEN.Score = objRow[concc_CourseExamPaperUserExamsLog.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseExamPaperUserExamsLog.Score].ToString().Trim()); //得分
objcc_CourseExamPaperUserExamsLogEN.CourseId = objRow[concc_CourseExamPaperUserExamsLog.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds = objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds].ToString().Trim(); //答案Ids
objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent = objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent].ToString().Trim(); //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
objcc_CourseExamPaperUserExamsLogEN.IsShow = TransNullToBool(objRow[concc_CourseExamPaperUserExamsLog.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperUserExamsLogEN.CreateTime = objRow[concc_CourseExamPaperUserExamsLog.CreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CreateTime].ToString().Trim(); //建立时间
objcc_CourseExamPaperUserExamsLogEN.UserId = objRow[concc_CourseExamPaperUserExamsLog.UserId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: GetObjByDataRowcc_CourseExamPaperUserExamsLog)", objException.Message));
}
objcc_CourseExamPaperUserExamsLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseExamPaperUserExamsLogEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_CourseExamPaperUserExamsLogEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN = new clscc_CourseExamPaperUserExamsLogEN();
try
{
objcc_CourseExamPaperUserExamsLogEN.mId = TransNullToInt(objRow[concc_CourseExamPaperUserExamsLog.mId].ToString().Trim()); //mId
objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId = objRow[concc_CourseExamPaperUserExamsLog.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperUserExamsLogEN.QuestionId = objRow[concc_CourseExamPaperUserExamsLog.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseExamPaperUserExamsLog.QuestionId].ToString().Trim()); //题目Id
objcc_CourseExamPaperUserExamsLogEN.IsTrue = TransNullToBool(objRow[concc_CourseExamPaperUserExamsLog.IsTrue].ToString().Trim()); //是否正确
objcc_CourseExamPaperUserExamsLogEN.Score = objRow[concc_CourseExamPaperUserExamsLog.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseExamPaperUserExamsLog.Score].ToString().Trim()); //得分
objcc_CourseExamPaperUserExamsLogEN.CourseId = objRow[concc_CourseExamPaperUserExamsLog.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds = objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds].ToString().Trim(); //答案Ids
objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent = objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent].ToString().Trim(); //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
objcc_CourseExamPaperUserExamsLogEN.IsShow = TransNullToBool(objRow[concc_CourseExamPaperUserExamsLog.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperUserExamsLogEN.CreateTime = objRow[concc_CourseExamPaperUserExamsLog.CreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.CreateTime].ToString().Trim(); //建立时间
objcc_CourseExamPaperUserExamsLogEN.UserId = objRow[concc_CourseExamPaperUserExamsLog.UserId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserExamsLog.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: GetObjByDataRow)", objException.Message));
}
objcc_CourseExamPaperUserExamsLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseExamPaperUserExamsLogEN;
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
objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_CourseExamPaperUserExamsLogEN._CurrTabName, concc_CourseExamPaperUserExamsLog.mId, 8, "");
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
objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_CourseExamPaperUserExamsLogEN._CurrTabName, concc_CourseExamPaperUserExamsLog.mId, 8, strPrefix);
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
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from cc_CourseExamPaperUserExamsLog where " + strCondition;
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
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from cc_CourseExamPaperUserExamsLog where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_CourseExamPaperUserExamsLog", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_CourseExamPaperUserExamsLogDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_CourseExamPaperUserExamsLog", strCondition))
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
objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_CourseExamPaperUserExamsLog");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN)
 {
 if (objcc_CourseExamPaperUserExamsLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseExamPaperUserExamsLogEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaperUserExamsLog where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_CourseExamPaperUserExamsLog");
objRow = objDS.Tables["cc_CourseExamPaperUserExamsLog"].NewRow();
 if (objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId !=  "")
 {
objRow[concc_CourseExamPaperUserExamsLog.CourseExamPaperId] = objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId; //考卷流水号
 }
objRow[concc_CourseExamPaperUserExamsLog.QuestionId] = objcc_CourseExamPaperUserExamsLogEN.QuestionId; //题目Id
objRow[concc_CourseExamPaperUserExamsLog.IsTrue] = objcc_CourseExamPaperUserExamsLogEN.IsTrue; //是否正确
objRow[concc_CourseExamPaperUserExamsLog.Score] = objcc_CourseExamPaperUserExamsLogEN.Score; //得分
 if (objcc_CourseExamPaperUserExamsLogEN.CourseId !=  "")
 {
objRow[concc_CourseExamPaperUserExamsLog.CourseId] = objcc_CourseExamPaperUserExamsLogEN.CourseId; //课程Id
 }
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds !=  "")
 {
objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds] = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds; //答案Ids
 }
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent !=  "")
 {
objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent] = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent; //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
 }
objRow[concc_CourseExamPaperUserExamsLog.IsShow] = objcc_CourseExamPaperUserExamsLogEN.IsShow; //是否启用
 if (objcc_CourseExamPaperUserExamsLogEN.CreateTime !=  "")
 {
objRow[concc_CourseExamPaperUserExamsLog.CreateTime] = objcc_CourseExamPaperUserExamsLogEN.CreateTime; //建立时间
 }
 if (objcc_CourseExamPaperUserExamsLogEN.UserId !=  "")
 {
objRow[concc_CourseExamPaperUserExamsLog.UserId] = objcc_CourseExamPaperUserExamsLogEN.UserId; //用户ID
 }
objDS.Tables[clscc_CourseExamPaperUserExamsLogEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_CourseExamPaperUserExamsLogEN._CurrTabName);
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
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN)
{
 if (objcc_CourseExamPaperUserExamsLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseExamPaperUserExamsLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.CourseExamPaperId);
 var strCourseExamPaperId = objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.QuestionId);
 arrValueListForInsert.Add(objcc_CourseExamPaperUserExamsLogEN.QuestionId.ToString());
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.IsTrue);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperUserExamsLogEN.IsTrue  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperUserExamsLogEN.Score !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.Score);
 arrValueListForInsert.Add(objcc_CourseExamPaperUserExamsLogEN.Score.ToString());
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.CourseId);
 var strCourseId = objcc_CourseExamPaperUserExamsLogEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.QuestionAnswerIds);
 var strQuestionAnswerIds = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionAnswerIds + "'");
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.QuestionAnswerContent);
 var strQuestionAnswerContent = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionAnswerContent + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperUserExamsLogEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperUserExamsLogEN.CreateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.CreateTime);
 var strCreateTime = objcc_CourseExamPaperUserExamsLogEN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateTime + "'");
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.UserId);
 var strUserId = objcc_CourseExamPaperUserExamsLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseExamPaperUserExamsLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN)
{
 if (objcc_CourseExamPaperUserExamsLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseExamPaperUserExamsLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.CourseExamPaperId);
 var strCourseExamPaperId = objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.QuestionId);
 arrValueListForInsert.Add(objcc_CourseExamPaperUserExamsLogEN.QuestionId.ToString());
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.IsTrue);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperUserExamsLogEN.IsTrue  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperUserExamsLogEN.Score !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.Score);
 arrValueListForInsert.Add(objcc_CourseExamPaperUserExamsLogEN.Score.ToString());
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.CourseId);
 var strCourseId = objcc_CourseExamPaperUserExamsLogEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.QuestionAnswerIds);
 var strQuestionAnswerIds = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionAnswerIds + "'");
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.QuestionAnswerContent);
 var strQuestionAnswerContent = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionAnswerContent + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperUserExamsLogEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperUserExamsLogEN.CreateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.CreateTime);
 var strCreateTime = objcc_CourseExamPaperUserExamsLogEN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateTime + "'");
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.UserId);
 var strUserId = objcc_CourseExamPaperUserExamsLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseExamPaperUserExamsLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_CourseExamPaperUserExamsLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseExamPaperUserExamsLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.CourseExamPaperId);
 var strCourseExamPaperId = objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.QuestionId);
 arrValueListForInsert.Add(objcc_CourseExamPaperUserExamsLogEN.QuestionId.ToString());
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.IsTrue);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperUserExamsLogEN.IsTrue  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperUserExamsLogEN.Score !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.Score);
 arrValueListForInsert.Add(objcc_CourseExamPaperUserExamsLogEN.Score.ToString());
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.CourseId);
 var strCourseId = objcc_CourseExamPaperUserExamsLogEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.QuestionAnswerIds);
 var strQuestionAnswerIds = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionAnswerIds + "'");
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.QuestionAnswerContent);
 var strQuestionAnswerContent = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionAnswerContent + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperUserExamsLogEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperUserExamsLogEN.CreateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.CreateTime);
 var strCreateTime = objcc_CourseExamPaperUserExamsLogEN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateTime + "'");
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.UserId);
 var strUserId = objcc_CourseExamPaperUserExamsLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseExamPaperUserExamsLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objcc_CourseExamPaperUserExamsLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseExamPaperUserExamsLogEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.CourseExamPaperId);
 var strCourseExamPaperId = objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.QuestionId);
 arrValueListForInsert.Add(objcc_CourseExamPaperUserExamsLogEN.QuestionId.ToString());
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.IsTrue);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperUserExamsLogEN.IsTrue  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperUserExamsLogEN.Score !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.Score);
 arrValueListForInsert.Add(objcc_CourseExamPaperUserExamsLogEN.Score.ToString());
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.CourseId);
 var strCourseId = objcc_CourseExamPaperUserExamsLogEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.QuestionAnswerIds);
 var strQuestionAnswerIds = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionAnswerIds + "'");
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.QuestionAnswerContent);
 var strQuestionAnswerContent = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionAnswerContent + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseExamPaperUserExamsLogEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseExamPaperUserExamsLogEN.CreateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.CreateTime);
 var strCreateTime = objcc_CourseExamPaperUserExamsLogEN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateTime + "'");
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseExamPaperUserExamsLog.UserId);
 var strUserId = objcc_CourseExamPaperUserExamsLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseExamPaperUserExamsLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_CourseExamPaperUserExamsLogs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaperUserExamsLog where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_CourseExamPaperUserExamsLog");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_CourseExamPaperUserExamsLogEN._CurrTabName ].NewRow();
objRow[concc_CourseExamPaperUserExamsLog.CourseExamPaperId] = oRow[concc_CourseExamPaperUserExamsLog.CourseExamPaperId].ToString().Trim(); //考卷流水号
objRow[concc_CourseExamPaperUserExamsLog.QuestionId] = oRow[concc_CourseExamPaperUserExamsLog.QuestionId].ToString().Trim(); //题目Id
objRow[concc_CourseExamPaperUserExamsLog.IsTrue] = oRow[concc_CourseExamPaperUserExamsLog.IsTrue].ToString().Trim(); //是否正确
objRow[concc_CourseExamPaperUserExamsLog.Score] = oRow[concc_CourseExamPaperUserExamsLog.Score].ToString().Trim(); //得分
objRow[concc_CourseExamPaperUserExamsLog.CourseId] = oRow[concc_CourseExamPaperUserExamsLog.CourseId].ToString().Trim(); //课程Id
objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds] = oRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds].ToString().Trim(); //答案Ids
objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent] = oRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent].ToString().Trim(); //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
objRow[concc_CourseExamPaperUserExamsLog.IsShow] = oRow[concc_CourseExamPaperUserExamsLog.IsShow].ToString().Trim(); //是否启用
objRow[concc_CourseExamPaperUserExamsLog.CreateTime] = oRow[concc_CourseExamPaperUserExamsLog.CreateTime].ToString().Trim(); //建立时间
objRow[concc_CourseExamPaperUserExamsLog.UserId] = oRow[concc_CourseExamPaperUserExamsLog.UserId].ToString().Trim(); //用户ID
 objDS.Tables[clscc_CourseExamPaperUserExamsLogEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_CourseExamPaperUserExamsLogEN._CurrTabName);
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
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN)
{
 if (objcc_CourseExamPaperUserExamsLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseExamPaperUserExamsLogEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseExamPaperUserExamsLog where mId = " + ""+ objcc_CourseExamPaperUserExamsLogEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_CourseExamPaperUserExamsLogEN._CurrTabName);
if (objDS.Tables[clscc_CourseExamPaperUserExamsLogEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objcc_CourseExamPaperUserExamsLogEN.mId+"");
return false;
}
objRow = objDS.Tables[clscc_CourseExamPaperUserExamsLogEN._CurrTabName].Rows[0];
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.CourseExamPaperId))
 {
objRow[concc_CourseExamPaperUserExamsLog.CourseExamPaperId] = objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId; //考卷流水号
 }
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.QuestionId))
 {
objRow[concc_CourseExamPaperUserExamsLog.QuestionId] = objcc_CourseExamPaperUserExamsLogEN.QuestionId; //题目Id
 }
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.IsTrue))
 {
objRow[concc_CourseExamPaperUserExamsLog.IsTrue] = objcc_CourseExamPaperUserExamsLogEN.IsTrue; //是否正确
 }
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.Score))
 {
objRow[concc_CourseExamPaperUserExamsLog.Score] = objcc_CourseExamPaperUserExamsLogEN.Score; //得分
 }
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.CourseId))
 {
objRow[concc_CourseExamPaperUserExamsLog.CourseId] = objcc_CourseExamPaperUserExamsLogEN.CourseId; //课程Id
 }
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.QuestionAnswerIds))
 {
objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds] = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds; //答案Ids
 }
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.QuestionAnswerContent))
 {
objRow[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent] = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent; //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
 }
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.IsShow))
 {
objRow[concc_CourseExamPaperUserExamsLog.IsShow] = objcc_CourseExamPaperUserExamsLogEN.IsShow; //是否启用
 }
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.CreateTime))
 {
objRow[concc_CourseExamPaperUserExamsLog.CreateTime] = objcc_CourseExamPaperUserExamsLogEN.CreateTime; //建立时间
 }
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.UserId))
 {
objRow[concc_CourseExamPaperUserExamsLog.UserId] = objcc_CourseExamPaperUserExamsLogEN.UserId; //用户ID
 }
try
{
objDA.Update(objDS, clscc_CourseExamPaperUserExamsLogEN._CurrTabName);
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
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN)
{
 if (objcc_CourseExamPaperUserExamsLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseExamPaperUserExamsLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_CourseExamPaperUserExamsLog Set ");
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.CourseExamPaperId))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseExamPaperId, concc_CourseExamPaperUserExamsLog.CourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.CourseExamPaperId); //考卷流水号
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.QuestionId))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperUserExamsLogEN.QuestionId, concc_CourseExamPaperUserExamsLog.QuestionId); //题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.QuestionId); //题目Id
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.IsTrue))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseExamPaperUserExamsLogEN.IsTrue == true?"1":"0", concc_CourseExamPaperUserExamsLog.IsTrue); //是否正确
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.Score))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperUserExamsLogEN.Score, concc_CourseExamPaperUserExamsLog.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.Score); //得分
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.CourseId))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseExamPaperUserExamsLogEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_CourseExamPaperUserExamsLog.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.CourseId); //课程Id
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.QuestionAnswerIds))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds !=  null)
 {
 var strQuestionAnswerIds = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionAnswerIds, concc_CourseExamPaperUserExamsLog.QuestionAnswerIds); //答案Ids
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.QuestionAnswerIds); //答案Ids
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.QuestionAnswerContent))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent !=  null)
 {
 var strQuestionAnswerContent = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionAnswerContent, concc_CourseExamPaperUserExamsLog.QuestionAnswerContent); //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.QuestionAnswerContent); //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseExamPaperUserExamsLogEN.IsShow == true?"1":"0", concc_CourseExamPaperUserExamsLog.IsShow); //是否启用
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.CreateTime))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.CreateTime !=  null)
 {
 var strCreateTime = objcc_CourseExamPaperUserExamsLogEN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateTime, concc_CourseExamPaperUserExamsLog.CreateTime); //建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.CreateTime); //建立时间
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.UserId))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.UserId !=  null)
 {
 var strUserId = objcc_CourseExamPaperUserExamsLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, concc_CourseExamPaperUserExamsLog.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.UserId); //用户ID
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objcc_CourseExamPaperUserExamsLogEN.mId); 
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
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, string strCondition)
{
 if (objcc_CourseExamPaperUserExamsLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseExamPaperUserExamsLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseExamPaperUserExamsLog Set ");
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.CourseExamPaperId))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseExamPaperId = '{0}',", strCourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.Append(" CourseExamPaperId = null,"); //考卷流水号
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.QuestionId))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperUserExamsLogEN.QuestionId, concc_CourseExamPaperUserExamsLog.QuestionId); //题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.QuestionId); //题目Id
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.IsTrue))
 {
 sbSQL.AppendFormat(" IsTrue = '{0}',", objcc_CourseExamPaperUserExamsLogEN.IsTrue == true?"1":"0"); //是否正确
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.Score))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperUserExamsLogEN.Score, concc_CourseExamPaperUserExamsLog.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.Score); //得分
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.CourseId))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseExamPaperUserExamsLogEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.QuestionAnswerIds))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds !=  null)
 {
 var strQuestionAnswerIds = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionAnswerIds = '{0}',", strQuestionAnswerIds); //答案Ids
 }
 else
 {
 sbSQL.Append(" QuestionAnswerIds = null,"); //答案Ids
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.QuestionAnswerContent))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent !=  null)
 {
 var strQuestionAnswerContent = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionAnswerContent = '{0}',", strQuestionAnswerContent); //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
 }
 else
 {
 sbSQL.Append(" QuestionAnswerContent = null,"); //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objcc_CourseExamPaperUserExamsLogEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.CreateTime))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.CreateTime !=  null)
 {
 var strCreateTime = objcc_CourseExamPaperUserExamsLogEN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateTime = '{0}',", strCreateTime); //建立时间
 }
 else
 {
 sbSQL.Append(" CreateTime = null,"); //建立时间
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.UserId))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.UserId !=  null)
 {
 var strUserId = objcc_CourseExamPaperUserExamsLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
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
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_CourseExamPaperUserExamsLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseExamPaperUserExamsLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseExamPaperUserExamsLog Set ");
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.CourseExamPaperId))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseExamPaperId = '{0}',", strCourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.Append(" CourseExamPaperId = null,"); //考卷流水号
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.QuestionId))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperUserExamsLogEN.QuestionId, concc_CourseExamPaperUserExamsLog.QuestionId); //题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.QuestionId); //题目Id
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.IsTrue))
 {
 sbSQL.AppendFormat(" IsTrue = '{0}',", objcc_CourseExamPaperUserExamsLogEN.IsTrue == true?"1":"0"); //是否正确
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.Score))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperUserExamsLogEN.Score, concc_CourseExamPaperUserExamsLog.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.Score); //得分
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.CourseId))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseExamPaperUserExamsLogEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.QuestionAnswerIds))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds !=  null)
 {
 var strQuestionAnswerIds = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionAnswerIds = '{0}',", strQuestionAnswerIds); //答案Ids
 }
 else
 {
 sbSQL.Append(" QuestionAnswerIds = null,"); //答案Ids
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.QuestionAnswerContent))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent !=  null)
 {
 var strQuestionAnswerContent = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionAnswerContent = '{0}',", strQuestionAnswerContent); //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
 }
 else
 {
 sbSQL.Append(" QuestionAnswerContent = null,"); //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objcc_CourseExamPaperUserExamsLogEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.CreateTime))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.CreateTime !=  null)
 {
 var strCreateTime = objcc_CourseExamPaperUserExamsLogEN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateTime = '{0}',", strCreateTime); //建立时间
 }
 else
 {
 sbSQL.Append(" CreateTime = null,"); //建立时间
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.UserId))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.UserId !=  null)
 {
 var strUserId = objcc_CourseExamPaperUserExamsLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
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
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objcc_CourseExamPaperUserExamsLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseExamPaperUserExamsLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseExamPaperUserExamsLog Set ");
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.CourseExamPaperId))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseExamPaperId, concc_CourseExamPaperUserExamsLog.CourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.CourseExamPaperId); //考卷流水号
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.QuestionId))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperUserExamsLogEN.QuestionId, concc_CourseExamPaperUserExamsLog.QuestionId); //题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.QuestionId); //题目Id
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.IsTrue))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseExamPaperUserExamsLogEN.IsTrue == true?"1":"0", concc_CourseExamPaperUserExamsLog.IsTrue); //是否正确
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.Score))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseExamPaperUserExamsLogEN.Score, concc_CourseExamPaperUserExamsLog.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.Score); //得分
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.CourseId))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseExamPaperUserExamsLogEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_CourseExamPaperUserExamsLog.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.CourseId); //课程Id
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.QuestionAnswerIds))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds !=  null)
 {
 var strQuestionAnswerIds = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionAnswerIds, concc_CourseExamPaperUserExamsLog.QuestionAnswerIds); //答案Ids
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.QuestionAnswerIds); //答案Ids
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.QuestionAnswerContent))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent !=  null)
 {
 var strQuestionAnswerContent = objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionAnswerContent, concc_CourseExamPaperUserExamsLog.QuestionAnswerContent); //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.QuestionAnswerContent); //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseExamPaperUserExamsLogEN.IsShow == true?"1":"0", concc_CourseExamPaperUserExamsLog.IsShow); //是否启用
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.CreateTime))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.CreateTime !=  null)
 {
 var strCreateTime = objcc_CourseExamPaperUserExamsLogEN.CreateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateTime, concc_CourseExamPaperUserExamsLog.CreateTime); //建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.CreateTime); //建立时间
 }
 }
 
 if (objcc_CourseExamPaperUserExamsLogEN.IsUpdated(concc_CourseExamPaperUserExamsLog.UserId))
 {
 if (objcc_CourseExamPaperUserExamsLogEN.UserId !=  null)
 {
 var strUserId = objcc_CourseExamPaperUserExamsLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, concc_CourseExamPaperUserExamsLog.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseExamPaperUserExamsLog.UserId); //用户ID
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objcc_CourseExamPaperUserExamsLogEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("cc_CourseExamPaperUserExamsLog_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
//删除cc_CourseExamPaperUserExamsLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseExamPaperUserExamsLog where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_CourseExamPaperUserExamsLog(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
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
//删除cc_CourseExamPaperUserExamsLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseExamPaperUserExamsLog where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
//删除cc_CourseExamPaperUserExamsLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseExamPaperUserExamsLog where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_CourseExamPaperUserExamsLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: Delcc_CourseExamPaperUserExamsLog)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_CourseExamPaperUserExamsLog where " + strCondition ;
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
public bool Delcc_CourseExamPaperUserExamsLogWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_CourseExamPaperUserExamsLogDA: Delcc_CourseExamPaperUserExamsLogWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_CourseExamPaperUserExamsLog where " + strCondition ;
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
 /// <param name = "objcc_CourseExamPaperUserExamsLogENS">源对象</param>
 /// <param name = "objcc_CourseExamPaperUserExamsLogENT">目标对象</param>
public void CopyTo(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogENS, clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogENT)
{
objcc_CourseExamPaperUserExamsLogENT.mId = objcc_CourseExamPaperUserExamsLogENS.mId; //mId
objcc_CourseExamPaperUserExamsLogENT.CourseExamPaperId = objcc_CourseExamPaperUserExamsLogENS.CourseExamPaperId; //考卷流水号
objcc_CourseExamPaperUserExamsLogENT.QuestionId = objcc_CourseExamPaperUserExamsLogENS.QuestionId; //题目Id
objcc_CourseExamPaperUserExamsLogENT.IsTrue = objcc_CourseExamPaperUserExamsLogENS.IsTrue; //是否正确
objcc_CourseExamPaperUserExamsLogENT.Score = objcc_CourseExamPaperUserExamsLogENS.Score; //得分
objcc_CourseExamPaperUserExamsLogENT.CourseId = objcc_CourseExamPaperUserExamsLogENS.CourseId; //课程Id
objcc_CourseExamPaperUserExamsLogENT.QuestionAnswerIds = objcc_CourseExamPaperUserExamsLogENS.QuestionAnswerIds; //答案Ids
objcc_CourseExamPaperUserExamsLogENT.QuestionAnswerContent = objcc_CourseExamPaperUserExamsLogENS.QuestionAnswerContent; //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
objcc_CourseExamPaperUserExamsLogENT.IsShow = objcc_CourseExamPaperUserExamsLogENS.IsShow; //是否启用
objcc_CourseExamPaperUserExamsLogENT.CreateTime = objcc_CourseExamPaperUserExamsLogENS.CreateTime; //建立时间
objcc_CourseExamPaperUserExamsLogENT.UserId = objcc_CourseExamPaperUserExamsLogENS.UserId; //用户ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId, 8, concc_CourseExamPaperUserExamsLog.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperUserExamsLogEN.CourseId, 8, concc_CourseExamPaperUserExamsLog.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds, 255, concc_CourseExamPaperUserExamsLog.QuestionAnswerIds);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperUserExamsLogEN.CreateTime, 16, concc_CourseExamPaperUserExamsLog.CreateTime);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperUserExamsLogEN.UserId, 18, concc_CourseExamPaperUserExamsLog.UserId);
//检查字段外键固定长度
 objcc_CourseExamPaperUserExamsLogEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId, 8, concc_CourseExamPaperUserExamsLog.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperUserExamsLogEN.CourseId, 8, concc_CourseExamPaperUserExamsLog.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds, 255, concc_CourseExamPaperUserExamsLog.QuestionAnswerIds);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperUserExamsLogEN.CreateTime, 16, concc_CourseExamPaperUserExamsLog.CreateTime);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperUserExamsLogEN.UserId, 18, concc_CourseExamPaperUserExamsLog.UserId);
//检查外键字段长度
 objcc_CourseExamPaperUserExamsLogEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId, 8, concc_CourseExamPaperUserExamsLog.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperUserExamsLogEN.CourseId, 8, concc_CourseExamPaperUserExamsLog.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds, 255, concc_CourseExamPaperUserExamsLog.QuestionAnswerIds);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperUserExamsLogEN.CreateTime, 16, concc_CourseExamPaperUserExamsLog.CreateTime);
clsCheckSql.CheckFieldLen(objcc_CourseExamPaperUserExamsLogEN.UserId, 18, concc_CourseExamPaperUserExamsLog.UserId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId, concc_CourseExamPaperUserExamsLog.CourseExamPaperId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseExamPaperUserExamsLogEN.CourseId, concc_CourseExamPaperUserExamsLog.CourseId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds, concc_CourseExamPaperUserExamsLog.QuestionAnswerIds);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseExamPaperUserExamsLogEN.CreateTime, concc_CourseExamPaperUserExamsLog.CreateTime);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseExamPaperUserExamsLogEN.UserId, concc_CourseExamPaperUserExamsLog.UserId);
//检查外键字段长度
 objcc_CourseExamPaperUserExamsLogEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_CourseExamPaperUserExamsLog(学生考卷答题记录),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId == null)
{
 sbCondition.AppendFormat(" and CourseExamPaperId is null");
}
else
{
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId);
}
 if (objcc_CourseExamPaperUserExamsLogEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null");
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objcc_CourseExamPaperUserExamsLogEN.UserId);
}
 if (objcc_CourseExamPaperUserExamsLogEN.QuestionId == null)
{
 sbCondition.AppendFormat(" and QuestionId is null");
}
else
{
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_CourseExamPaperUserExamsLogEN.QuestionId);
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
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
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
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
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
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_CourseExamPaperUserExamsLogEN._CurrTabName);
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
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_CourseExamPaperUserExamsLogEN._CurrTabName, strCondition);
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
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
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
 objSQL = clscc_CourseExamPaperUserExamsLogDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}