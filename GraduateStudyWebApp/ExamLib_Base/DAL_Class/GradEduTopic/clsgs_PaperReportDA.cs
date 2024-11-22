
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperReportDA
 表名:gs_PaperReport(01120772)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:01
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 论文汇报表(gs_PaperReport)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsgs_PaperReportDA : clsCommBase4DA
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
 return clsgs_PaperReportEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsgs_PaperReportEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_PaperReportEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsgs_PaperReportEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsgs_PaperReportEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strReportId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strReportId)
{
strReportId = strReportId.Replace("'", "''");
if (strReportId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:gs_PaperReport中,检查关键字,长度不正确!(clsgs_PaperReportDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strReportId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:gs_PaperReport中,关键字不能为空 或 null!(clsgs_PaperReportDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strReportId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsgs_PaperReportDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsgs_PaperReportDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperReport where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_gs_PaperReport(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsgs_PaperReportDA: GetDataTable_gs_PaperReport)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperReport where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsgs_PaperReportDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsgs_PaperReportDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperReport where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsgs_PaperReportDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsgs_PaperReportDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_PaperReport where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_PaperReport where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsgs_PaperReportDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from gs_PaperReport where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsgs_PaperReportDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_PaperReport.* from gs_PaperReport Left Join {1} on {2} where {3} and gs_PaperReport.ReportId not in (Select top {5} gs_PaperReport.ReportId from gs_PaperReport Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_PaperReport where {1} and ReportId not in (Select top {2} ReportId from gs_PaperReport where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_PaperReport where {1} and ReportId not in (Select top {3} ReportId from gs_PaperReport where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsgs_PaperReportDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_PaperReport.* from gs_PaperReport Left Join {1} on {2} where {3} and gs_PaperReport.ReportId not in (Select top {5} gs_PaperReport.ReportId from gs_PaperReport Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_PaperReport where {1} and ReportId not in (Select top {2} ReportId from gs_PaperReport where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_PaperReport where {1} and ReportId not in (Select top {3} ReportId from gs_PaperReport where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsgs_PaperReportEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsgs_PaperReportDA:GetObjLst)", objException.Message));
}
List<clsgs_PaperReportEN> arrObjLst = new List<clsgs_PaperReportEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperReport where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();
try
{
objgs_PaperReportEN.ReportId = objRow[congs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objgs_PaperReportEN.TopicId = objRow[congs_PaperReport.TopicId] == DBNull.Value ? null : objRow[congs_PaperReport.TopicId].ToString().Trim(); //主题Id
objgs_PaperReportEN.PaperId = objRow[congs_PaperReport.PaperId] == DBNull.Value ? null : objRow[congs_PaperReport.PaperId].ToString().Trim(); //论文Id
objgs_PaperReportEN.ReportContent = objRow[congs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[congs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objgs_PaperReportEN.IsSubmit = TransNullToBool(objRow[congs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperReportEN.ReportUser = objRow[congs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[congs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objgs_PaperReportEN.ReportDate = objRow[congs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[congs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objgs_PaperReportEN.VersionCount = objRow[congs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objgs_PaperReportEN.OkCount = objRow[congs_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objgs_PaperReportEN.AppraiseCount = objRow[congs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objgs_PaperReportEN.Score = objRow[congs_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_PaperReport.Score].ToString().Trim()); //评分
objgs_PaperReportEN.StuScore = objRow[congs_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objgs_PaperReportEN.TeaScore = objRow[congs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objgs_PaperReportEN.PDFUrl = objRow[congs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objgs_PaperReportEN.PPTUrl = objRow[congs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objgs_PaperReportEN.Month = objRow[congs_PaperReport.Month] == DBNull.Value ? null : objRow[congs_PaperReport.Month].ToString().Trim(); //月
objgs_PaperReportEN.Week = objRow[congs_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.Week].ToString().Trim()); //周
objgs_PaperReportEN.Year = objRow[congs_PaperReport.Year] == DBNull.Value ? null : objRow[congs_PaperReport.Year].ToString().Trim(); //年
objgs_PaperReportEN.IdCurrEduCls = objRow[congs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperReportEN.UpdUser = objRow[congs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[congs_PaperReport.UpdUser].ToString().Trim(); //修改人
objgs_PaperReportEN.UpdDate = objRow[congs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[congs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objgs_PaperReportEN.Memo = objRow[congs_PaperReport.Memo] == DBNull.Value ? null : objRow[congs_PaperReport.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_PaperReportDA: GetObjLst)", objException.Message));
}
objgs_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_PaperReportEN);
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
public List<clsgs_PaperReportEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsgs_PaperReportDA:GetObjLstByTabName)", objException.Message));
}
List<clsgs_PaperReportEN> arrObjLst = new List<clsgs_PaperReportEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();
try
{
objgs_PaperReportEN.ReportId = objRow[congs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objgs_PaperReportEN.TopicId = objRow[congs_PaperReport.TopicId] == DBNull.Value ? null : objRow[congs_PaperReport.TopicId].ToString().Trim(); //主题Id
objgs_PaperReportEN.PaperId = objRow[congs_PaperReport.PaperId] == DBNull.Value ? null : objRow[congs_PaperReport.PaperId].ToString().Trim(); //论文Id
objgs_PaperReportEN.ReportContent = objRow[congs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[congs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objgs_PaperReportEN.IsSubmit = TransNullToBool(objRow[congs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperReportEN.ReportUser = objRow[congs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[congs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objgs_PaperReportEN.ReportDate = objRow[congs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[congs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objgs_PaperReportEN.VersionCount = objRow[congs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objgs_PaperReportEN.OkCount = objRow[congs_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objgs_PaperReportEN.AppraiseCount = objRow[congs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objgs_PaperReportEN.Score = objRow[congs_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_PaperReport.Score].ToString().Trim()); //评分
objgs_PaperReportEN.StuScore = objRow[congs_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objgs_PaperReportEN.TeaScore = objRow[congs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objgs_PaperReportEN.PDFUrl = objRow[congs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objgs_PaperReportEN.PPTUrl = objRow[congs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objgs_PaperReportEN.Month = objRow[congs_PaperReport.Month] == DBNull.Value ? null : objRow[congs_PaperReport.Month].ToString().Trim(); //月
objgs_PaperReportEN.Week = objRow[congs_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.Week].ToString().Trim()); //周
objgs_PaperReportEN.Year = objRow[congs_PaperReport.Year] == DBNull.Value ? null : objRow[congs_PaperReport.Year].ToString().Trim(); //年
objgs_PaperReportEN.IdCurrEduCls = objRow[congs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperReportEN.UpdUser = objRow[congs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[congs_PaperReport.UpdUser].ToString().Trim(); //修改人
objgs_PaperReportEN.UpdDate = objRow[congs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[congs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objgs_PaperReportEN.Memo = objRow[congs_PaperReport.Memo] == DBNull.Value ? null : objRow[congs_PaperReport.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_PaperReportDA: GetObjLst)", objException.Message));
}
objgs_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_PaperReportEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getgs_PaperReport(ref clsgs_PaperReportEN objgs_PaperReportEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperReport where ReportId = " + "'"+ objgs_PaperReportEN.ReportId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objgs_PaperReportEN.ReportId = objDT.Rows[0][congs_PaperReport.ReportId].ToString().Trim(); //汇报Id(字段类型:char,字段长度:10,是否可空:False)
 objgs_PaperReportEN.TopicId = objDT.Rows[0][congs_PaperReport.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_PaperReportEN.PaperId = objDT.Rows[0][congs_PaperReport.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_PaperReportEN.ReportContent = objDT.Rows[0][congs_PaperReport.ReportContent].ToString().Trim(); //汇报内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objgs_PaperReportEN.IsSubmit = TransNullToBool(objDT.Rows[0][congs_PaperReport.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objgs_PaperReportEN.ReportUser = objDT.Rows[0][congs_PaperReport.ReportUser].ToString().Trim(); //汇报用户(字段类型:varchar,字段长度:500,是否可空:True)
 objgs_PaperReportEN.ReportDate = objDT.Rows[0][congs_PaperReport.ReportDate].ToString().Trim(); //汇报日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_PaperReportEN.VersionCount = TransNullToInt(objDT.Rows[0][congs_PaperReport.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objgs_PaperReportEN.OkCount = TransNullToInt(objDT.Rows[0][congs_PaperReport.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objgs_PaperReportEN.AppraiseCount = TransNullToInt(objDT.Rows[0][congs_PaperReport.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objgs_PaperReportEN.Score = TransNullToFloat(objDT.Rows[0][congs_PaperReport.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objgs_PaperReportEN.StuScore = TransNullToFloat(objDT.Rows[0][congs_PaperReport.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objgs_PaperReportEN.TeaScore = TransNullToFloat(objDT.Rows[0][congs_PaperReport.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objgs_PaperReportEN.PDFUrl = objDT.Rows[0][congs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl(字段类型:varchar,字段长度:500,是否可空:True)
 objgs_PaperReportEN.PPTUrl = objDT.Rows[0][congs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl(字段类型:varchar,字段长度:500,是否可空:True)
 objgs_PaperReportEN.Month = objDT.Rows[0][congs_PaperReport.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objgs_PaperReportEN.Week = TransNullToInt(objDT.Rows[0][congs_PaperReport.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objgs_PaperReportEN.Year = objDT.Rows[0][congs_PaperReport.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objgs_PaperReportEN.IdCurrEduCls = objDT.Rows[0][congs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objgs_PaperReportEN.UpdUser = objDT.Rows[0][congs_PaperReport.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_PaperReportEN.UpdDate = objDT.Rows[0][congs_PaperReport.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_PaperReportEN.Memo = objDT.Rows[0][congs_PaperReport.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsgs_PaperReportDA: Getgs_PaperReport)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strReportId">表关键字</param>
 /// <returns>表对象</returns>
public clsgs_PaperReportEN GetObjByReportId(string strReportId)
{
CheckPrimaryKey(strReportId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperReport where ReportId = " + "'"+ strReportId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();
try
{
 objgs_PaperReportEN.ReportId = objRow[congs_PaperReport.ReportId].ToString().Trim(); //汇报Id(字段类型:char,字段长度:10,是否可空:False)
 objgs_PaperReportEN.TopicId = objRow[congs_PaperReport.TopicId] == DBNull.Value ? null : objRow[congs_PaperReport.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_PaperReportEN.PaperId = objRow[congs_PaperReport.PaperId] == DBNull.Value ? null : objRow[congs_PaperReport.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_PaperReportEN.ReportContent = objRow[congs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[congs_PaperReport.ReportContent].ToString().Trim(); //汇报内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperReport.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objgs_PaperReportEN.ReportUser = objRow[congs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[congs_PaperReport.ReportUser].ToString().Trim(); //汇报用户(字段类型:varchar,字段长度:500,是否可空:True)
 objgs_PaperReportEN.ReportDate = objRow[congs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[congs_PaperReport.ReportDate].ToString().Trim(); //汇报日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_PaperReportEN.VersionCount = objRow[congs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objgs_PaperReportEN.OkCount = objRow[congs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objgs_PaperReportEN.AppraiseCount = objRow[congs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objgs_PaperReportEN.Score = objRow[congs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objgs_PaperReportEN.StuScore = objRow[congs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objgs_PaperReportEN.TeaScore = objRow[congs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objgs_PaperReportEN.PDFUrl = objRow[congs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl(字段类型:varchar,字段长度:500,是否可空:True)
 objgs_PaperReportEN.PPTUrl = objRow[congs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl(字段类型:varchar,字段长度:500,是否可空:True)
 objgs_PaperReportEN.Month = objRow[congs_PaperReport.Month] == DBNull.Value ? null : objRow[congs_PaperReport.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objgs_PaperReportEN.Week = objRow[congs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objgs_PaperReportEN.Year = objRow[congs_PaperReport.Year] == DBNull.Value ? null : objRow[congs_PaperReport.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objgs_PaperReportEN.IdCurrEduCls = objRow[congs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objgs_PaperReportEN.UpdUser = objRow[congs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[congs_PaperReport.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_PaperReportEN.UpdDate = objRow[congs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[congs_PaperReport.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_PaperReportEN.Memo = objRow[congs_PaperReport.Memo] == DBNull.Value ? null : objRow[congs_PaperReport.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsgs_PaperReportDA: GetObjByReportId)", objException.Message));
}
return objgs_PaperReportEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsgs_PaperReportEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsgs_PaperReportDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperReport where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN()
{
ReportId = objRow[congs_PaperReport.ReportId].ToString().Trim(), //汇报Id
TopicId = objRow[congs_PaperReport.TopicId] == DBNull.Value ? null : objRow[congs_PaperReport.TopicId].ToString().Trim(), //主题Id
PaperId = objRow[congs_PaperReport.PaperId] == DBNull.Value ? null : objRow[congs_PaperReport.PaperId].ToString().Trim(), //论文Id
ReportContent = objRow[congs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[congs_PaperReport.ReportContent].ToString().Trim(), //汇报内容
IsSubmit = TransNullToBool(objRow[congs_PaperReport.IsSubmit].ToString().Trim()), //是否提交
ReportUser = objRow[congs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[congs_PaperReport.ReportUser].ToString().Trim(), //汇报用户
ReportDate = objRow[congs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[congs_PaperReport.ReportDate].ToString().Trim(), //汇报日期
VersionCount = objRow[congs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.VersionCount].ToString().Trim()), //版本统计
OkCount = objRow[congs_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.OkCount].ToString().Trim()), //点赞统计
AppraiseCount = objRow[congs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[congs_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_PaperReport.Score].ToString().Trim()), //评分
StuScore = objRow[congs_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_PaperReport.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[congs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_PaperReport.TeaScore].ToString().Trim()), //教师评分
PDFUrl = objRow[congs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PDFUrl].ToString().Trim(), //PDFUrl
PPTUrl = objRow[congs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PPTUrl].ToString().Trim(), //PPTUrl
Month = objRow[congs_PaperReport.Month] == DBNull.Value ? null : objRow[congs_PaperReport.Month].ToString().Trim(), //月
Week = objRow[congs_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.Week].ToString().Trim()), //周
Year = objRow[congs_PaperReport.Year] == DBNull.Value ? null : objRow[congs_PaperReport.Year].ToString().Trim(), //年
IdCurrEduCls = objRow[congs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperReport.IdCurrEduCls].ToString().Trim(), //教学班流水号
UpdUser = objRow[congs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[congs_PaperReport.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[congs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[congs_PaperReport.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[congs_PaperReport.Memo] == DBNull.Value ? null : objRow[congs_PaperReport.Memo].ToString().Trim() //备注
};
objgs_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_PaperReportEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsgs_PaperReportDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsgs_PaperReportEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();
try
{
objgs_PaperReportEN.ReportId = objRow[congs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objgs_PaperReportEN.TopicId = objRow[congs_PaperReport.TopicId] == DBNull.Value ? null : objRow[congs_PaperReport.TopicId].ToString().Trim(); //主题Id
objgs_PaperReportEN.PaperId = objRow[congs_PaperReport.PaperId] == DBNull.Value ? null : objRow[congs_PaperReport.PaperId].ToString().Trim(); //论文Id
objgs_PaperReportEN.ReportContent = objRow[congs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[congs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objgs_PaperReportEN.IsSubmit = TransNullToBool(objRow[congs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperReportEN.ReportUser = objRow[congs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[congs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objgs_PaperReportEN.ReportDate = objRow[congs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[congs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objgs_PaperReportEN.VersionCount = objRow[congs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objgs_PaperReportEN.OkCount = objRow[congs_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objgs_PaperReportEN.AppraiseCount = objRow[congs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objgs_PaperReportEN.Score = objRow[congs_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_PaperReport.Score].ToString().Trim()); //评分
objgs_PaperReportEN.StuScore = objRow[congs_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objgs_PaperReportEN.TeaScore = objRow[congs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objgs_PaperReportEN.PDFUrl = objRow[congs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objgs_PaperReportEN.PPTUrl = objRow[congs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objgs_PaperReportEN.Month = objRow[congs_PaperReport.Month] == DBNull.Value ? null : objRow[congs_PaperReport.Month].ToString().Trim(); //月
objgs_PaperReportEN.Week = objRow[congs_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.Week].ToString().Trim()); //周
objgs_PaperReportEN.Year = objRow[congs_PaperReport.Year] == DBNull.Value ? null : objRow[congs_PaperReport.Year].ToString().Trim(); //年
objgs_PaperReportEN.IdCurrEduCls = objRow[congs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperReportEN.UpdUser = objRow[congs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[congs_PaperReport.UpdUser].ToString().Trim(); //修改人
objgs_PaperReportEN.UpdDate = objRow[congs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[congs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objgs_PaperReportEN.Memo = objRow[congs_PaperReport.Memo] == DBNull.Value ? null : objRow[congs_PaperReport.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsgs_PaperReportDA: GetObjByDataRowgs_PaperReport)", objException.Message));
}
objgs_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_PaperReportEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsgs_PaperReportEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();
try
{
objgs_PaperReportEN.ReportId = objRow[congs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objgs_PaperReportEN.TopicId = objRow[congs_PaperReport.TopicId] == DBNull.Value ? null : objRow[congs_PaperReport.TopicId].ToString().Trim(); //主题Id
objgs_PaperReportEN.PaperId = objRow[congs_PaperReport.PaperId] == DBNull.Value ? null : objRow[congs_PaperReport.PaperId].ToString().Trim(); //论文Id
objgs_PaperReportEN.ReportContent = objRow[congs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[congs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objgs_PaperReportEN.IsSubmit = TransNullToBool(objRow[congs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperReportEN.ReportUser = objRow[congs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[congs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objgs_PaperReportEN.ReportDate = objRow[congs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[congs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objgs_PaperReportEN.VersionCount = objRow[congs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objgs_PaperReportEN.OkCount = objRow[congs_PaperReport.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objgs_PaperReportEN.AppraiseCount = objRow[congs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objgs_PaperReportEN.Score = objRow[congs_PaperReport.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_PaperReport.Score].ToString().Trim()); //评分
objgs_PaperReportEN.StuScore = objRow[congs_PaperReport.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objgs_PaperReportEN.TeaScore = objRow[congs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objgs_PaperReportEN.PDFUrl = objRow[congs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objgs_PaperReportEN.PPTUrl = objRow[congs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objgs_PaperReportEN.Month = objRow[congs_PaperReport.Month] == DBNull.Value ? null : objRow[congs_PaperReport.Month].ToString().Trim(); //月
objgs_PaperReportEN.Week = objRow[congs_PaperReport.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_PaperReport.Week].ToString().Trim()); //周
objgs_PaperReportEN.Year = objRow[congs_PaperReport.Year] == DBNull.Value ? null : objRow[congs_PaperReport.Year].ToString().Trim(); //年
objgs_PaperReportEN.IdCurrEduCls = objRow[congs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperReportEN.UpdUser = objRow[congs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[congs_PaperReport.UpdUser].ToString().Trim(); //修改人
objgs_PaperReportEN.UpdDate = objRow[congs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[congs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objgs_PaperReportEN.Memo = objRow[congs_PaperReport.Memo] == DBNull.Value ? null : objRow[congs_PaperReport.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsgs_PaperReportDA: GetObjByDataRow)", objException.Message));
}
objgs_PaperReportEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_PaperReportEN;
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
objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_PaperReportEN._CurrTabName, congs_PaperReport.ReportId, 10, "");
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
objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_PaperReportEN._CurrTabName, congs_PaperReport.ReportId, 10, strPrefix);
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
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ReportId from gs_PaperReport where " + strCondition;
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
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ReportId from gs_PaperReport where " + strCondition;
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
 /// <param name = "strReportId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strReportId)
{
CheckPrimaryKey(strReportId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_PaperReport", "ReportId = " + "'"+ strReportId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsgs_PaperReportDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_PaperReport", strCondition))
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
objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("gs_PaperReport");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsgs_PaperReportEN objgs_PaperReportEN)
 {
 if (objgs_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_PaperReportEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperReport where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_PaperReport");
objRow = objDS.Tables["gs_PaperReport"].NewRow();
objRow[congs_PaperReport.ReportId] = objgs_PaperReportEN.ReportId; //汇报Id
 if (objgs_PaperReportEN.TopicId !=  "")
 {
objRow[congs_PaperReport.TopicId] = objgs_PaperReportEN.TopicId; //主题Id
 }
 if (objgs_PaperReportEN.PaperId !=  "")
 {
objRow[congs_PaperReport.PaperId] = objgs_PaperReportEN.PaperId; //论文Id
 }
 if (objgs_PaperReportEN.ReportContent !=  "")
 {
objRow[congs_PaperReport.ReportContent] = objgs_PaperReportEN.ReportContent; //汇报内容
 }
objRow[congs_PaperReport.IsSubmit] = objgs_PaperReportEN.IsSubmit; //是否提交
 if (objgs_PaperReportEN.ReportUser !=  "")
 {
objRow[congs_PaperReport.ReportUser] = objgs_PaperReportEN.ReportUser; //汇报用户
 }
 if (objgs_PaperReportEN.ReportDate !=  "")
 {
objRow[congs_PaperReport.ReportDate] = objgs_PaperReportEN.ReportDate; //汇报日期
 }
objRow[congs_PaperReport.VersionCount] = objgs_PaperReportEN.VersionCount; //版本统计
objRow[congs_PaperReport.OkCount] = objgs_PaperReportEN.OkCount; //点赞统计
objRow[congs_PaperReport.AppraiseCount] = objgs_PaperReportEN.AppraiseCount; //评论数
objRow[congs_PaperReport.Score] = objgs_PaperReportEN.Score; //评分
objRow[congs_PaperReport.StuScore] = objgs_PaperReportEN.StuScore; //学生平均分
objRow[congs_PaperReport.TeaScore] = objgs_PaperReportEN.TeaScore; //教师评分
 if (objgs_PaperReportEN.PDFUrl !=  "")
 {
objRow[congs_PaperReport.PDFUrl] = objgs_PaperReportEN.PDFUrl; //PDFUrl
 }
 if (objgs_PaperReportEN.PPTUrl !=  "")
 {
objRow[congs_PaperReport.PPTUrl] = objgs_PaperReportEN.PPTUrl; //PPTUrl
 }
 if (objgs_PaperReportEN.Month !=  "")
 {
objRow[congs_PaperReport.Month] = objgs_PaperReportEN.Month; //月
 }
objRow[congs_PaperReport.Week] = objgs_PaperReportEN.Week; //周
 if (objgs_PaperReportEN.Year !=  "")
 {
objRow[congs_PaperReport.Year] = objgs_PaperReportEN.Year; //年
 }
 if (objgs_PaperReportEN.IdCurrEduCls !=  "")
 {
objRow[congs_PaperReport.IdCurrEduCls] = objgs_PaperReportEN.IdCurrEduCls; //教学班流水号
 }
 if (objgs_PaperReportEN.UpdUser !=  "")
 {
objRow[congs_PaperReport.UpdUser] = objgs_PaperReportEN.UpdUser; //修改人
 }
 if (objgs_PaperReportEN.UpdDate !=  "")
 {
objRow[congs_PaperReport.UpdDate] = objgs_PaperReportEN.UpdDate; //修改日期
 }
 if (objgs_PaperReportEN.Memo !=  "")
 {
objRow[congs_PaperReport.Memo] = objgs_PaperReportEN.Memo; //备注
 }
objDS.Tables[clsgs_PaperReportEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsgs_PaperReportEN._CurrTabName);
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
 /// <param name = "objgs_PaperReportEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_PaperReportEN objgs_PaperReportEN)
{
 if (objgs_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_PaperReportEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_PaperReportEN.ReportId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.ReportId);
 var strReportId = objgs_PaperReportEN.ReportId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportId + "'");
 }
 
 if (objgs_PaperReportEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.TopicId);
 var strTopicId = objgs_PaperReportEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objgs_PaperReportEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.PaperId);
 var strPaperId = objgs_PaperReportEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_PaperReportEN.ReportContent !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.ReportContent);
 var strReportContent = objgs_PaperReportEN.ReportContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportContent + "'");
 }
 
 arrFieldListForInsert.Add(congs_PaperReport.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_PaperReportEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_PaperReportEN.ReportUser !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.ReportUser);
 var strReportUser = objgs_PaperReportEN.ReportUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportUser + "'");
 }
 
 if (objgs_PaperReportEN.ReportDate !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.ReportDate);
 var strReportDate = objgs_PaperReportEN.ReportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportDate + "'");
 }
 
 if (objgs_PaperReportEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.VersionCount);
 arrValueListForInsert.Add(objgs_PaperReportEN.VersionCount.ToString());
 }
 
 if (objgs_PaperReportEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.OkCount);
 arrValueListForInsert.Add(objgs_PaperReportEN.OkCount.ToString());
 }
 
 if (objgs_PaperReportEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.AppraiseCount);
 arrValueListForInsert.Add(objgs_PaperReportEN.AppraiseCount.ToString());
 }
 
 if (objgs_PaperReportEN.Score !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Score);
 arrValueListForInsert.Add(objgs_PaperReportEN.Score.ToString());
 }
 
 if (objgs_PaperReportEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.StuScore);
 arrValueListForInsert.Add(objgs_PaperReportEN.StuScore.ToString());
 }
 
 if (objgs_PaperReportEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.TeaScore);
 arrValueListForInsert.Add(objgs_PaperReportEN.TeaScore.ToString());
 }
 
 if (objgs_PaperReportEN.PDFUrl !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.PDFUrl);
 var strPDFUrl = objgs_PaperReportEN.PDFUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPDFUrl + "'");
 }
 
 if (objgs_PaperReportEN.PPTUrl !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.PPTUrl);
 var strPPTUrl = objgs_PaperReportEN.PPTUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPPTUrl + "'");
 }
 
 if (objgs_PaperReportEN.Month !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Month);
 var strMonth = objgs_PaperReportEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objgs_PaperReportEN.Week !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Week);
 arrValueListForInsert.Add(objgs_PaperReportEN.Week.ToString());
 }
 
 if (objgs_PaperReportEN.Year !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Year);
 var strYear = objgs_PaperReportEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objgs_PaperReportEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.IdCurrEduCls);
 var strIdCurrEduCls = objgs_PaperReportEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_PaperReportEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.UpdUser);
 var strUpdUser = objgs_PaperReportEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_PaperReportEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.UpdDate);
 var strUpdDate = objgs_PaperReportEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_PaperReportEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Memo);
 var strMemo = objgs_PaperReportEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_PaperReport");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_PaperReportEN objgs_PaperReportEN)
{
 if (objgs_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_PaperReportEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_PaperReportEN.ReportId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.ReportId);
 var strReportId = objgs_PaperReportEN.ReportId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportId + "'");
 }
 
 if (objgs_PaperReportEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.TopicId);
 var strTopicId = objgs_PaperReportEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objgs_PaperReportEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.PaperId);
 var strPaperId = objgs_PaperReportEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_PaperReportEN.ReportContent !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.ReportContent);
 var strReportContent = objgs_PaperReportEN.ReportContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportContent + "'");
 }
 
 arrFieldListForInsert.Add(congs_PaperReport.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_PaperReportEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_PaperReportEN.ReportUser !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.ReportUser);
 var strReportUser = objgs_PaperReportEN.ReportUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportUser + "'");
 }
 
 if (objgs_PaperReportEN.ReportDate !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.ReportDate);
 var strReportDate = objgs_PaperReportEN.ReportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportDate + "'");
 }
 
 if (objgs_PaperReportEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.VersionCount);
 arrValueListForInsert.Add(objgs_PaperReportEN.VersionCount.ToString());
 }
 
 if (objgs_PaperReportEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.OkCount);
 arrValueListForInsert.Add(objgs_PaperReportEN.OkCount.ToString());
 }
 
 if (objgs_PaperReportEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.AppraiseCount);
 arrValueListForInsert.Add(objgs_PaperReportEN.AppraiseCount.ToString());
 }
 
 if (objgs_PaperReportEN.Score !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Score);
 arrValueListForInsert.Add(objgs_PaperReportEN.Score.ToString());
 }
 
 if (objgs_PaperReportEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.StuScore);
 arrValueListForInsert.Add(objgs_PaperReportEN.StuScore.ToString());
 }
 
 if (objgs_PaperReportEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.TeaScore);
 arrValueListForInsert.Add(objgs_PaperReportEN.TeaScore.ToString());
 }
 
 if (objgs_PaperReportEN.PDFUrl !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.PDFUrl);
 var strPDFUrl = objgs_PaperReportEN.PDFUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPDFUrl + "'");
 }
 
 if (objgs_PaperReportEN.PPTUrl !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.PPTUrl);
 var strPPTUrl = objgs_PaperReportEN.PPTUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPPTUrl + "'");
 }
 
 if (objgs_PaperReportEN.Month !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Month);
 var strMonth = objgs_PaperReportEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objgs_PaperReportEN.Week !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Week);
 arrValueListForInsert.Add(objgs_PaperReportEN.Week.ToString());
 }
 
 if (objgs_PaperReportEN.Year !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Year);
 var strYear = objgs_PaperReportEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objgs_PaperReportEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.IdCurrEduCls);
 var strIdCurrEduCls = objgs_PaperReportEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_PaperReportEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.UpdUser);
 var strUpdUser = objgs_PaperReportEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_PaperReportEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.UpdDate);
 var strUpdDate = objgs_PaperReportEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_PaperReportEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Memo);
 var strMemo = objgs_PaperReportEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_PaperReport");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objgs_PaperReportEN.ReportId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_PaperReportEN objgs_PaperReportEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_PaperReportEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_PaperReportEN.ReportId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.ReportId);
 var strReportId = objgs_PaperReportEN.ReportId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportId + "'");
 }
 
 if (objgs_PaperReportEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.TopicId);
 var strTopicId = objgs_PaperReportEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objgs_PaperReportEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.PaperId);
 var strPaperId = objgs_PaperReportEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_PaperReportEN.ReportContent !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.ReportContent);
 var strReportContent = objgs_PaperReportEN.ReportContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportContent + "'");
 }
 
 arrFieldListForInsert.Add(congs_PaperReport.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_PaperReportEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_PaperReportEN.ReportUser !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.ReportUser);
 var strReportUser = objgs_PaperReportEN.ReportUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportUser + "'");
 }
 
 if (objgs_PaperReportEN.ReportDate !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.ReportDate);
 var strReportDate = objgs_PaperReportEN.ReportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportDate + "'");
 }
 
 if (objgs_PaperReportEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.VersionCount);
 arrValueListForInsert.Add(objgs_PaperReportEN.VersionCount.ToString());
 }
 
 if (objgs_PaperReportEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.OkCount);
 arrValueListForInsert.Add(objgs_PaperReportEN.OkCount.ToString());
 }
 
 if (objgs_PaperReportEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.AppraiseCount);
 arrValueListForInsert.Add(objgs_PaperReportEN.AppraiseCount.ToString());
 }
 
 if (objgs_PaperReportEN.Score !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Score);
 arrValueListForInsert.Add(objgs_PaperReportEN.Score.ToString());
 }
 
 if (objgs_PaperReportEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.StuScore);
 arrValueListForInsert.Add(objgs_PaperReportEN.StuScore.ToString());
 }
 
 if (objgs_PaperReportEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.TeaScore);
 arrValueListForInsert.Add(objgs_PaperReportEN.TeaScore.ToString());
 }
 
 if (objgs_PaperReportEN.PDFUrl !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.PDFUrl);
 var strPDFUrl = objgs_PaperReportEN.PDFUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPDFUrl + "'");
 }
 
 if (objgs_PaperReportEN.PPTUrl !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.PPTUrl);
 var strPPTUrl = objgs_PaperReportEN.PPTUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPPTUrl + "'");
 }
 
 if (objgs_PaperReportEN.Month !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Month);
 var strMonth = objgs_PaperReportEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objgs_PaperReportEN.Week !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Week);
 arrValueListForInsert.Add(objgs_PaperReportEN.Week.ToString());
 }
 
 if (objgs_PaperReportEN.Year !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Year);
 var strYear = objgs_PaperReportEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objgs_PaperReportEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.IdCurrEduCls);
 var strIdCurrEduCls = objgs_PaperReportEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_PaperReportEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.UpdUser);
 var strUpdUser = objgs_PaperReportEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_PaperReportEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.UpdDate);
 var strUpdDate = objgs_PaperReportEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_PaperReportEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Memo);
 var strMemo = objgs_PaperReportEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_PaperReport");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objgs_PaperReportEN.ReportId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_PaperReportEN objgs_PaperReportEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_PaperReportEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_PaperReportEN.ReportId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.ReportId);
 var strReportId = objgs_PaperReportEN.ReportId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportId + "'");
 }
 
 if (objgs_PaperReportEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.TopicId);
 var strTopicId = objgs_PaperReportEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objgs_PaperReportEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.PaperId);
 var strPaperId = objgs_PaperReportEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_PaperReportEN.ReportContent !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.ReportContent);
 var strReportContent = objgs_PaperReportEN.ReportContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportContent + "'");
 }
 
 arrFieldListForInsert.Add(congs_PaperReport.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_PaperReportEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_PaperReportEN.ReportUser !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.ReportUser);
 var strReportUser = objgs_PaperReportEN.ReportUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportUser + "'");
 }
 
 if (objgs_PaperReportEN.ReportDate !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.ReportDate);
 var strReportDate = objgs_PaperReportEN.ReportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReportDate + "'");
 }
 
 if (objgs_PaperReportEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.VersionCount);
 arrValueListForInsert.Add(objgs_PaperReportEN.VersionCount.ToString());
 }
 
 if (objgs_PaperReportEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.OkCount);
 arrValueListForInsert.Add(objgs_PaperReportEN.OkCount.ToString());
 }
 
 if (objgs_PaperReportEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.AppraiseCount);
 arrValueListForInsert.Add(objgs_PaperReportEN.AppraiseCount.ToString());
 }
 
 if (objgs_PaperReportEN.Score !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Score);
 arrValueListForInsert.Add(objgs_PaperReportEN.Score.ToString());
 }
 
 if (objgs_PaperReportEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.StuScore);
 arrValueListForInsert.Add(objgs_PaperReportEN.StuScore.ToString());
 }
 
 if (objgs_PaperReportEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.TeaScore);
 arrValueListForInsert.Add(objgs_PaperReportEN.TeaScore.ToString());
 }
 
 if (objgs_PaperReportEN.PDFUrl !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.PDFUrl);
 var strPDFUrl = objgs_PaperReportEN.PDFUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPDFUrl + "'");
 }
 
 if (objgs_PaperReportEN.PPTUrl !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.PPTUrl);
 var strPPTUrl = objgs_PaperReportEN.PPTUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPPTUrl + "'");
 }
 
 if (objgs_PaperReportEN.Month !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Month);
 var strMonth = objgs_PaperReportEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objgs_PaperReportEN.Week !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Week);
 arrValueListForInsert.Add(objgs_PaperReportEN.Week.ToString());
 }
 
 if (objgs_PaperReportEN.Year !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Year);
 var strYear = objgs_PaperReportEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objgs_PaperReportEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.IdCurrEduCls);
 var strIdCurrEduCls = objgs_PaperReportEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_PaperReportEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.UpdUser);
 var strUpdUser = objgs_PaperReportEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_PaperReportEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.UpdDate);
 var strUpdDate = objgs_PaperReportEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_PaperReportEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_PaperReport.Memo);
 var strMemo = objgs_PaperReportEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_PaperReport");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewgs_PaperReports(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperReport where ReportId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_PaperReport");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strReportId = oRow[congs_PaperReport.ReportId].ToString().Trim();
if (IsExist(strReportId))
{
 string strResult = "关键字变量值为:" + string.Format("ReportId = {0}", strReportId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsgs_PaperReportEN._CurrTabName ].NewRow();
objRow[congs_PaperReport.ReportId] = oRow[congs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objRow[congs_PaperReport.TopicId] = oRow[congs_PaperReport.TopicId].ToString().Trim(); //主题Id
objRow[congs_PaperReport.PaperId] = oRow[congs_PaperReport.PaperId].ToString().Trim(); //论文Id
objRow[congs_PaperReport.ReportContent] = oRow[congs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objRow[congs_PaperReport.IsSubmit] = oRow[congs_PaperReport.IsSubmit].ToString().Trim(); //是否提交
objRow[congs_PaperReport.ReportUser] = oRow[congs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objRow[congs_PaperReport.ReportDate] = oRow[congs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objRow[congs_PaperReport.VersionCount] = oRow[congs_PaperReport.VersionCount].ToString().Trim(); //版本统计
objRow[congs_PaperReport.OkCount] = oRow[congs_PaperReport.OkCount].ToString().Trim(); //点赞统计
objRow[congs_PaperReport.AppraiseCount] = oRow[congs_PaperReport.AppraiseCount].ToString().Trim(); //评论数
objRow[congs_PaperReport.Score] = oRow[congs_PaperReport.Score].ToString().Trim(); //评分
objRow[congs_PaperReport.StuScore] = oRow[congs_PaperReport.StuScore].ToString().Trim(); //学生平均分
objRow[congs_PaperReport.TeaScore] = oRow[congs_PaperReport.TeaScore].ToString().Trim(); //教师评分
objRow[congs_PaperReport.PDFUrl] = oRow[congs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objRow[congs_PaperReport.PPTUrl] = oRow[congs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objRow[congs_PaperReport.Month] = oRow[congs_PaperReport.Month].ToString().Trim(); //月
objRow[congs_PaperReport.Week] = oRow[congs_PaperReport.Week].ToString().Trim(); //周
objRow[congs_PaperReport.Year] = oRow[congs_PaperReport.Year].ToString().Trim(); //年
objRow[congs_PaperReport.IdCurrEduCls] = oRow[congs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[congs_PaperReport.UpdUser] = oRow[congs_PaperReport.UpdUser].ToString().Trim(); //修改人
objRow[congs_PaperReport.UpdDate] = oRow[congs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objRow[congs_PaperReport.Memo] = oRow[congs_PaperReport.Memo].ToString().Trim(); //备注
 objDS.Tables[clsgs_PaperReportEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsgs_PaperReportEN._CurrTabName);
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
 /// <param name = "objgs_PaperReportEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsgs_PaperReportEN objgs_PaperReportEN)
{
 if (objgs_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_PaperReportEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
strSQL = "Select * from gs_PaperReport where ReportId = " + "'"+ objgs_PaperReportEN.ReportId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsgs_PaperReportEN._CurrTabName);
if (objDS.Tables[clsgs_PaperReportEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ReportId = " + "'"+ objgs_PaperReportEN.ReportId+"'");
return false;
}
objRow = objDS.Tables[clsgs_PaperReportEN._CurrTabName].Rows[0];
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.ReportId))
 {
objRow[congs_PaperReport.ReportId] = objgs_PaperReportEN.ReportId; //汇报Id
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.TopicId))
 {
objRow[congs_PaperReport.TopicId] = objgs_PaperReportEN.TopicId; //主题Id
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.PaperId))
 {
objRow[congs_PaperReport.PaperId] = objgs_PaperReportEN.PaperId; //论文Id
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.ReportContent))
 {
objRow[congs_PaperReport.ReportContent] = objgs_PaperReportEN.ReportContent; //汇报内容
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.IsSubmit))
 {
objRow[congs_PaperReport.IsSubmit] = objgs_PaperReportEN.IsSubmit; //是否提交
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.ReportUser))
 {
objRow[congs_PaperReport.ReportUser] = objgs_PaperReportEN.ReportUser; //汇报用户
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.ReportDate))
 {
objRow[congs_PaperReport.ReportDate] = objgs_PaperReportEN.ReportDate; //汇报日期
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.VersionCount))
 {
objRow[congs_PaperReport.VersionCount] = objgs_PaperReportEN.VersionCount; //版本统计
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.OkCount))
 {
objRow[congs_PaperReport.OkCount] = objgs_PaperReportEN.OkCount; //点赞统计
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.AppraiseCount))
 {
objRow[congs_PaperReport.AppraiseCount] = objgs_PaperReportEN.AppraiseCount; //评论数
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Score))
 {
objRow[congs_PaperReport.Score] = objgs_PaperReportEN.Score; //评分
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.StuScore))
 {
objRow[congs_PaperReport.StuScore] = objgs_PaperReportEN.StuScore; //学生平均分
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.TeaScore))
 {
objRow[congs_PaperReport.TeaScore] = objgs_PaperReportEN.TeaScore; //教师评分
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.PDFUrl))
 {
objRow[congs_PaperReport.PDFUrl] = objgs_PaperReportEN.PDFUrl; //PDFUrl
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.PPTUrl))
 {
objRow[congs_PaperReport.PPTUrl] = objgs_PaperReportEN.PPTUrl; //PPTUrl
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Month))
 {
objRow[congs_PaperReport.Month] = objgs_PaperReportEN.Month; //月
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Week))
 {
objRow[congs_PaperReport.Week] = objgs_PaperReportEN.Week; //周
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Year))
 {
objRow[congs_PaperReport.Year] = objgs_PaperReportEN.Year; //年
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.IdCurrEduCls))
 {
objRow[congs_PaperReport.IdCurrEduCls] = objgs_PaperReportEN.IdCurrEduCls; //教学班流水号
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.UpdUser))
 {
objRow[congs_PaperReport.UpdUser] = objgs_PaperReportEN.UpdUser; //修改人
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.UpdDate))
 {
objRow[congs_PaperReport.UpdDate] = objgs_PaperReportEN.UpdDate; //修改日期
 }
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Memo))
 {
objRow[congs_PaperReport.Memo] = objgs_PaperReportEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsgs_PaperReportEN._CurrTabName);
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
 /// <param name = "objgs_PaperReportEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_PaperReportEN objgs_PaperReportEN)
{
 if (objgs_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_PaperReportEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update gs_PaperReport Set ");
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.TopicId))
 {
 if (objgs_PaperReportEN.TopicId !=  null)
 {
 var strTopicId = objgs_PaperReportEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, congs_PaperReport.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.TopicId); //主题Id
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.PaperId))
 {
 if (objgs_PaperReportEN.PaperId !=  null)
 {
 var strPaperId = objgs_PaperReportEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, congs_PaperReport.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.PaperId); //论文Id
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.ReportContent))
 {
 if (objgs_PaperReportEN.ReportContent !=  null)
 {
 var strReportContent = objgs_PaperReportEN.ReportContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReportContent, congs_PaperReport.ReportContent); //汇报内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.ReportContent); //汇报内容
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_PaperReportEN.IsSubmit == true?"1":"0", congs_PaperReport.IsSubmit); //是否提交
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.ReportUser))
 {
 if (objgs_PaperReportEN.ReportUser !=  null)
 {
 var strReportUser = objgs_PaperReportEN.ReportUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReportUser, congs_PaperReport.ReportUser); //汇报用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.ReportUser); //汇报用户
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.ReportDate))
 {
 if (objgs_PaperReportEN.ReportDate !=  null)
 {
 var strReportDate = objgs_PaperReportEN.ReportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReportDate, congs_PaperReport.ReportDate); //汇报日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.ReportDate); //汇报日期
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.VersionCount))
 {
 if (objgs_PaperReportEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.VersionCount, congs_PaperReport.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.VersionCount); //版本统计
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.OkCount))
 {
 if (objgs_PaperReportEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.OkCount, congs_PaperReport.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.OkCount); //点赞统计
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.AppraiseCount))
 {
 if (objgs_PaperReportEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.AppraiseCount, congs_PaperReport.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.AppraiseCount); //评论数
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Score))
 {
 if (objgs_PaperReportEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.Score, congs_PaperReport.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.Score); //评分
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.StuScore))
 {
 if (objgs_PaperReportEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.StuScore, congs_PaperReport.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.StuScore); //学生平均分
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.TeaScore))
 {
 if (objgs_PaperReportEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.TeaScore, congs_PaperReport.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.TeaScore); //教师评分
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.PDFUrl))
 {
 if (objgs_PaperReportEN.PDFUrl !=  null)
 {
 var strPDFUrl = objgs_PaperReportEN.PDFUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPDFUrl, congs_PaperReport.PDFUrl); //PDFUrl
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.PDFUrl); //PDFUrl
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.PPTUrl))
 {
 if (objgs_PaperReportEN.PPTUrl !=  null)
 {
 var strPPTUrl = objgs_PaperReportEN.PPTUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPPTUrl, congs_PaperReport.PPTUrl); //PPTUrl
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.PPTUrl); //PPTUrl
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Month))
 {
 if (objgs_PaperReportEN.Month !=  null)
 {
 var strMonth = objgs_PaperReportEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMonth, congs_PaperReport.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.Month); //月
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Week))
 {
 if (objgs_PaperReportEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.Week, congs_PaperReport.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.Week); //周
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Year))
 {
 if (objgs_PaperReportEN.Year !=  null)
 {
 var strYear = objgs_PaperReportEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYear, congs_PaperReport.Year); //年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.Year); //年
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.IdCurrEduCls))
 {
 if (objgs_PaperReportEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_PaperReportEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_PaperReport.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.UpdUser))
 {
 if (objgs_PaperReportEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_PaperReportEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_PaperReport.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.UpdUser); //修改人
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.UpdDate))
 {
 if (objgs_PaperReportEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_PaperReportEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_PaperReport.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.UpdDate); //修改日期
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Memo))
 {
 if (objgs_PaperReportEN.Memo !=  null)
 {
 var strMemo = objgs_PaperReportEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_PaperReport.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ReportId = '{0}'", objgs_PaperReportEN.ReportId); 
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
 /// <param name = "objgs_PaperReportEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsgs_PaperReportEN objgs_PaperReportEN, string strCondition)
{
 if (objgs_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_PaperReportEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_PaperReport Set ");
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.TopicId))
 {
 if (objgs_PaperReportEN.TopicId !=  null)
 {
 var strTopicId = objgs_PaperReportEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.PaperId))
 {
 if (objgs_PaperReportEN.PaperId !=  null)
 {
 var strPaperId = objgs_PaperReportEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.ReportContent))
 {
 if (objgs_PaperReportEN.ReportContent !=  null)
 {
 var strReportContent = objgs_PaperReportEN.ReportContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReportContent = '{0}',", strReportContent); //汇报内容
 }
 else
 {
 sbSQL.Append(" ReportContent = null,"); //汇报内容
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objgs_PaperReportEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.ReportUser))
 {
 if (objgs_PaperReportEN.ReportUser !=  null)
 {
 var strReportUser = objgs_PaperReportEN.ReportUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReportUser = '{0}',", strReportUser); //汇报用户
 }
 else
 {
 sbSQL.Append(" ReportUser = null,"); //汇报用户
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.ReportDate))
 {
 if (objgs_PaperReportEN.ReportDate !=  null)
 {
 var strReportDate = objgs_PaperReportEN.ReportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReportDate = '{0}',", strReportDate); //汇报日期
 }
 else
 {
 sbSQL.Append(" ReportDate = null,"); //汇报日期
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.VersionCount))
 {
 if (objgs_PaperReportEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.VersionCount, congs_PaperReport.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.VersionCount); //版本统计
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.OkCount))
 {
 if (objgs_PaperReportEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.OkCount, congs_PaperReport.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.OkCount); //点赞统计
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.AppraiseCount))
 {
 if (objgs_PaperReportEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.AppraiseCount, congs_PaperReport.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.AppraiseCount); //评论数
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Score))
 {
 if (objgs_PaperReportEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.Score, congs_PaperReport.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.Score); //评分
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.StuScore))
 {
 if (objgs_PaperReportEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.StuScore, congs_PaperReport.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.StuScore); //学生平均分
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.TeaScore))
 {
 if (objgs_PaperReportEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.TeaScore, congs_PaperReport.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.TeaScore); //教师评分
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.PDFUrl))
 {
 if (objgs_PaperReportEN.PDFUrl !=  null)
 {
 var strPDFUrl = objgs_PaperReportEN.PDFUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PDFUrl = '{0}',", strPDFUrl); //PDFUrl
 }
 else
 {
 sbSQL.Append(" PDFUrl = null,"); //PDFUrl
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.PPTUrl))
 {
 if (objgs_PaperReportEN.PPTUrl !=  null)
 {
 var strPPTUrl = objgs_PaperReportEN.PPTUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PPTUrl = '{0}',", strPPTUrl); //PPTUrl
 }
 else
 {
 sbSQL.Append(" PPTUrl = null,"); //PPTUrl
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Month))
 {
 if (objgs_PaperReportEN.Month !=  null)
 {
 var strMonth = objgs_PaperReportEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Month = '{0}',", strMonth); //月
 }
 else
 {
 sbSQL.Append(" Month = null,"); //月
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Week))
 {
 if (objgs_PaperReportEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.Week, congs_PaperReport.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.Week); //周
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Year))
 {
 if (objgs_PaperReportEN.Year !=  null)
 {
 var strYear = objgs_PaperReportEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Year = '{0}',", strYear); //年
 }
 else
 {
 sbSQL.Append(" Year = null,"); //年
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.IdCurrEduCls))
 {
 if (objgs_PaperReportEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_PaperReportEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.UpdUser))
 {
 if (objgs_PaperReportEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_PaperReportEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.UpdDate))
 {
 if (objgs_PaperReportEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_PaperReportEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Memo))
 {
 if (objgs_PaperReportEN.Memo !=  null)
 {
 var strMemo = objgs_PaperReportEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objgs_PaperReportEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsgs_PaperReportEN objgs_PaperReportEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_PaperReportEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_PaperReport Set ");
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.TopicId))
 {
 if (objgs_PaperReportEN.TopicId !=  null)
 {
 var strTopicId = objgs_PaperReportEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.PaperId))
 {
 if (objgs_PaperReportEN.PaperId !=  null)
 {
 var strPaperId = objgs_PaperReportEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.ReportContent))
 {
 if (objgs_PaperReportEN.ReportContent !=  null)
 {
 var strReportContent = objgs_PaperReportEN.ReportContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReportContent = '{0}',", strReportContent); //汇报内容
 }
 else
 {
 sbSQL.Append(" ReportContent = null,"); //汇报内容
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objgs_PaperReportEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.ReportUser))
 {
 if (objgs_PaperReportEN.ReportUser !=  null)
 {
 var strReportUser = objgs_PaperReportEN.ReportUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReportUser = '{0}',", strReportUser); //汇报用户
 }
 else
 {
 sbSQL.Append(" ReportUser = null,"); //汇报用户
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.ReportDate))
 {
 if (objgs_PaperReportEN.ReportDate !=  null)
 {
 var strReportDate = objgs_PaperReportEN.ReportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReportDate = '{0}',", strReportDate); //汇报日期
 }
 else
 {
 sbSQL.Append(" ReportDate = null,"); //汇报日期
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.VersionCount))
 {
 if (objgs_PaperReportEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.VersionCount, congs_PaperReport.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.VersionCount); //版本统计
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.OkCount))
 {
 if (objgs_PaperReportEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.OkCount, congs_PaperReport.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.OkCount); //点赞统计
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.AppraiseCount))
 {
 if (objgs_PaperReportEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.AppraiseCount, congs_PaperReport.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.AppraiseCount); //评论数
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Score))
 {
 if (objgs_PaperReportEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.Score, congs_PaperReport.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.Score); //评分
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.StuScore))
 {
 if (objgs_PaperReportEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.StuScore, congs_PaperReport.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.StuScore); //学生平均分
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.TeaScore))
 {
 if (objgs_PaperReportEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.TeaScore, congs_PaperReport.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.TeaScore); //教师评分
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.PDFUrl))
 {
 if (objgs_PaperReportEN.PDFUrl !=  null)
 {
 var strPDFUrl = objgs_PaperReportEN.PDFUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PDFUrl = '{0}',", strPDFUrl); //PDFUrl
 }
 else
 {
 sbSQL.Append(" PDFUrl = null,"); //PDFUrl
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.PPTUrl))
 {
 if (objgs_PaperReportEN.PPTUrl !=  null)
 {
 var strPPTUrl = objgs_PaperReportEN.PPTUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PPTUrl = '{0}',", strPPTUrl); //PPTUrl
 }
 else
 {
 sbSQL.Append(" PPTUrl = null,"); //PPTUrl
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Month))
 {
 if (objgs_PaperReportEN.Month !=  null)
 {
 var strMonth = objgs_PaperReportEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Month = '{0}',", strMonth); //月
 }
 else
 {
 sbSQL.Append(" Month = null,"); //月
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Week))
 {
 if (objgs_PaperReportEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.Week, congs_PaperReport.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.Week); //周
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Year))
 {
 if (objgs_PaperReportEN.Year !=  null)
 {
 var strYear = objgs_PaperReportEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Year = '{0}',", strYear); //年
 }
 else
 {
 sbSQL.Append(" Year = null,"); //年
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.IdCurrEduCls))
 {
 if (objgs_PaperReportEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_PaperReportEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.UpdUser))
 {
 if (objgs_PaperReportEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_PaperReportEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.UpdDate))
 {
 if (objgs_PaperReportEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_PaperReportEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Memo))
 {
 if (objgs_PaperReportEN.Memo !=  null)
 {
 var strMemo = objgs_PaperReportEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objgs_PaperReportEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_PaperReportEN objgs_PaperReportEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_PaperReportEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_PaperReportEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_PaperReport Set ");
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.TopicId))
 {
 if (objgs_PaperReportEN.TopicId !=  null)
 {
 var strTopicId = objgs_PaperReportEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, congs_PaperReport.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.TopicId); //主题Id
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.PaperId))
 {
 if (objgs_PaperReportEN.PaperId !=  null)
 {
 var strPaperId = objgs_PaperReportEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, congs_PaperReport.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.PaperId); //论文Id
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.ReportContent))
 {
 if (objgs_PaperReportEN.ReportContent !=  null)
 {
 var strReportContent = objgs_PaperReportEN.ReportContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReportContent, congs_PaperReport.ReportContent); //汇报内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.ReportContent); //汇报内容
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_PaperReportEN.IsSubmit == true?"1":"0", congs_PaperReport.IsSubmit); //是否提交
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.ReportUser))
 {
 if (objgs_PaperReportEN.ReportUser !=  null)
 {
 var strReportUser = objgs_PaperReportEN.ReportUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReportUser, congs_PaperReport.ReportUser); //汇报用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.ReportUser); //汇报用户
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.ReportDate))
 {
 if (objgs_PaperReportEN.ReportDate !=  null)
 {
 var strReportDate = objgs_PaperReportEN.ReportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReportDate, congs_PaperReport.ReportDate); //汇报日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.ReportDate); //汇报日期
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.VersionCount))
 {
 if (objgs_PaperReportEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.VersionCount, congs_PaperReport.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.VersionCount); //版本统计
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.OkCount))
 {
 if (objgs_PaperReportEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.OkCount, congs_PaperReport.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.OkCount); //点赞统计
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.AppraiseCount))
 {
 if (objgs_PaperReportEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.AppraiseCount, congs_PaperReport.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.AppraiseCount); //评论数
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Score))
 {
 if (objgs_PaperReportEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.Score, congs_PaperReport.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.Score); //评分
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.StuScore))
 {
 if (objgs_PaperReportEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.StuScore, congs_PaperReport.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.StuScore); //学生平均分
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.TeaScore))
 {
 if (objgs_PaperReportEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.TeaScore, congs_PaperReport.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.TeaScore); //教师评分
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.PDFUrl))
 {
 if (objgs_PaperReportEN.PDFUrl !=  null)
 {
 var strPDFUrl = objgs_PaperReportEN.PDFUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPDFUrl, congs_PaperReport.PDFUrl); //PDFUrl
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.PDFUrl); //PDFUrl
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.PPTUrl))
 {
 if (objgs_PaperReportEN.PPTUrl !=  null)
 {
 var strPPTUrl = objgs_PaperReportEN.PPTUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPPTUrl, congs_PaperReport.PPTUrl); //PPTUrl
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.PPTUrl); //PPTUrl
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Month))
 {
 if (objgs_PaperReportEN.Month !=  null)
 {
 var strMonth = objgs_PaperReportEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMonth, congs_PaperReport.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.Month); //月
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Week))
 {
 if (objgs_PaperReportEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_PaperReportEN.Week, congs_PaperReport.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.Week); //周
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Year))
 {
 if (objgs_PaperReportEN.Year !=  null)
 {
 var strYear = objgs_PaperReportEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYear, congs_PaperReport.Year); //年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.Year); //年
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.IdCurrEduCls))
 {
 if (objgs_PaperReportEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_PaperReportEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_PaperReport.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.UpdUser))
 {
 if (objgs_PaperReportEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_PaperReportEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_PaperReport.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.UpdUser); //修改人
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.UpdDate))
 {
 if (objgs_PaperReportEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_PaperReportEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_PaperReport.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.UpdDate); //修改日期
 }
 }
 
 if (objgs_PaperReportEN.IsUpdated(congs_PaperReport.Memo))
 {
 if (objgs_PaperReportEN.Memo !=  null)
 {
 var strMemo = objgs_PaperReportEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_PaperReport.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_PaperReport.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ReportId = '{0}'", objgs_PaperReportEN.ReportId); 
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
 /// <param name = "strReportId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strReportId) 
{
CheckPrimaryKey(strReportId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strReportId,
};
 objSQL.ExecSP("gs_PaperReport_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strReportId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strReportId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strReportId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
//删除gs_PaperReport本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_PaperReport where ReportId = " + "'"+ strReportId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delgs_PaperReport(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
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
//删除gs_PaperReport本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_PaperReport where ReportId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strReportId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strReportId) 
{
CheckPrimaryKey(strReportId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
//删除gs_PaperReport本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_PaperReport where ReportId = " + "'"+ strReportId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delgs_PaperReport(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsgs_PaperReportDA: Delgs_PaperReport)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_PaperReport where " + strCondition ;
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
public bool Delgs_PaperReportWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsgs_PaperReportDA: Delgs_PaperReportWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_PaperReport where " + strCondition ;
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
 /// <param name = "objgs_PaperReportENS">源对象</param>
 /// <param name = "objgs_PaperReportENT">目标对象</param>
public void CopyTo(clsgs_PaperReportEN objgs_PaperReportENS, clsgs_PaperReportEN objgs_PaperReportENT)
{
objgs_PaperReportENT.ReportId = objgs_PaperReportENS.ReportId; //汇报Id
objgs_PaperReportENT.TopicId = objgs_PaperReportENS.TopicId; //主题Id
objgs_PaperReportENT.PaperId = objgs_PaperReportENS.PaperId; //论文Id
objgs_PaperReportENT.ReportContent = objgs_PaperReportENS.ReportContent; //汇报内容
objgs_PaperReportENT.IsSubmit = objgs_PaperReportENS.IsSubmit; //是否提交
objgs_PaperReportENT.ReportUser = objgs_PaperReportENS.ReportUser; //汇报用户
objgs_PaperReportENT.ReportDate = objgs_PaperReportENS.ReportDate; //汇报日期
objgs_PaperReportENT.VersionCount = objgs_PaperReportENS.VersionCount; //版本统计
objgs_PaperReportENT.OkCount = objgs_PaperReportENS.OkCount; //点赞统计
objgs_PaperReportENT.AppraiseCount = objgs_PaperReportENS.AppraiseCount; //评论数
objgs_PaperReportENT.Score = objgs_PaperReportENS.Score; //评分
objgs_PaperReportENT.StuScore = objgs_PaperReportENS.StuScore; //学生平均分
objgs_PaperReportENT.TeaScore = objgs_PaperReportENS.TeaScore; //教师评分
objgs_PaperReportENT.PDFUrl = objgs_PaperReportENS.PDFUrl; //PDFUrl
objgs_PaperReportENT.PPTUrl = objgs_PaperReportENS.PPTUrl; //PPTUrl
objgs_PaperReportENT.Month = objgs_PaperReportENS.Month; //月
objgs_PaperReportENT.Week = objgs_PaperReportENS.Week; //周
objgs_PaperReportENT.Year = objgs_PaperReportENS.Year; //年
objgs_PaperReportENT.IdCurrEduCls = objgs_PaperReportENS.IdCurrEduCls; //教学班流水号
objgs_PaperReportENT.UpdUser = objgs_PaperReportENS.UpdUser; //修改人
objgs_PaperReportENT.UpdDate = objgs_PaperReportENS.UpdDate; //修改日期
objgs_PaperReportENT.Memo = objgs_PaperReportENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsgs_PaperReportEN objgs_PaperReportEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.ReportId, 10, congs_PaperReport.ReportId);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.TopicId, 8, congs_PaperReport.TopicId);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.PaperId, 8, congs_PaperReport.PaperId);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.ReportContent, 5000, congs_PaperReport.ReportContent);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.ReportUser, 500, congs_PaperReport.ReportUser);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.ReportDate, 20, congs_PaperReport.ReportDate);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.PDFUrl, 500, congs_PaperReport.PDFUrl);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.PPTUrl, 500, congs_PaperReport.PPTUrl);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.Month, 2, congs_PaperReport.Month);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.Year, 4, congs_PaperReport.Year);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.IdCurrEduCls, 8, congs_PaperReport.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.UpdUser, 20, congs_PaperReport.UpdUser);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.UpdDate, 20, congs_PaperReport.UpdDate);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.Memo, 1000, congs_PaperReport.Memo);
//检查字段外键固定长度
 objgs_PaperReportEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsgs_PaperReportEN objgs_PaperReportEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.TopicId, 8, congs_PaperReport.TopicId);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.PaperId, 8, congs_PaperReport.PaperId);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.ReportContent, 5000, congs_PaperReport.ReportContent);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.ReportUser, 500, congs_PaperReport.ReportUser);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.ReportDate, 20, congs_PaperReport.ReportDate);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.PDFUrl, 500, congs_PaperReport.PDFUrl);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.PPTUrl, 500, congs_PaperReport.PPTUrl);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.Month, 2, congs_PaperReport.Month);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.Year, 4, congs_PaperReport.Year);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.IdCurrEduCls, 8, congs_PaperReport.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.UpdUser, 20, congs_PaperReport.UpdUser);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.UpdDate, 20, congs_PaperReport.UpdDate);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.Memo, 1000, congs_PaperReport.Memo);
//检查外键字段长度
 objgs_PaperReportEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsgs_PaperReportEN objgs_PaperReportEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.ReportId, 10, congs_PaperReport.ReportId);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.TopicId, 8, congs_PaperReport.TopicId);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.PaperId, 8, congs_PaperReport.PaperId);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.ReportContent, 5000, congs_PaperReport.ReportContent);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.ReportUser, 500, congs_PaperReport.ReportUser);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.ReportDate, 20, congs_PaperReport.ReportDate);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.PDFUrl, 500, congs_PaperReport.PDFUrl);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.PPTUrl, 500, congs_PaperReport.PPTUrl);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.Month, 2, congs_PaperReport.Month);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.Year, 4, congs_PaperReport.Year);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.IdCurrEduCls, 8, congs_PaperReport.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.UpdUser, 20, congs_PaperReport.UpdUser);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.UpdDate, 20, congs_PaperReport.UpdDate);
clsCheckSql.CheckFieldLen(objgs_PaperReportEN.Memo, 1000, congs_PaperReport.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objgs_PaperReportEN.ReportId, congs_PaperReport.ReportId);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperReportEN.TopicId, congs_PaperReport.TopicId);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperReportEN.PaperId, congs_PaperReport.PaperId);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperReportEN.ReportContent, congs_PaperReport.ReportContent);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperReportEN.ReportUser, congs_PaperReport.ReportUser);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperReportEN.ReportDate, congs_PaperReport.ReportDate);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperReportEN.PDFUrl, congs_PaperReport.PDFUrl);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperReportEN.PPTUrl, congs_PaperReport.PPTUrl);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperReportEN.Month, congs_PaperReport.Month);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperReportEN.Year, congs_PaperReport.Year);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperReportEN.IdCurrEduCls, congs_PaperReport.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperReportEN.UpdUser, congs_PaperReport.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperReportEN.UpdDate, congs_PaperReport.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objgs_PaperReportEN.Memo, congs_PaperReport.Memo);
//检查外键字段长度
 objgs_PaperReportEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--gs_PaperReport(论文汇报表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsgs_PaperReportEN objgs_PaperReportEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objgs_PaperReportEN.TopicId == null)
{
 sbCondition.AppendFormat(" and TopicId is null");
}
else
{
 sbCondition.AppendFormat(" and TopicId = '{0}'", objgs_PaperReportEN.TopicId);
}
 if (objgs_PaperReportEN.ReportUser == null)
{
 sbCondition.AppendFormat(" and ReportUser is null");
}
else
{
 sbCondition.AppendFormat(" and ReportUser = '{0}'", objgs_PaperReportEN.ReportUser);
}
 if (objgs_PaperReportEN.ReportDate == null)
{
 sbCondition.AppendFormat(" and ReportDate is null");
}
else
{
 sbCondition.AppendFormat(" and ReportDate = '{0}'", objgs_PaperReportEN.ReportDate);
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
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
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
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
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
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_PaperReportEN._CurrTabName);
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
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_PaperReportEN._CurrTabName, strCondition);
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
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
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
 objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}