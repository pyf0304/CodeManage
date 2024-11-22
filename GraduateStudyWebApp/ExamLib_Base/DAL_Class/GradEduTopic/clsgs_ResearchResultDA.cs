
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ResearchResultDA
 表名:gs_ResearchResult(01120780)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:41
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
 /// 研究成果(gs_ResearchResult)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsgs_ResearchResultDA : clsCommBase4DA
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
 return clsgs_ResearchResultEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsgs_ResearchResultEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_ResearchResultEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsgs_ResearchResultEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsgs_ResearchResultEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strResultId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strResultId)
{
strResultId = strResultId.Replace("'", "''");
if (strResultId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:gs_ResearchResult中,检查关键字,长度不正确!(clsgs_ResearchResultDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strResultId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:gs_ResearchResult中,关键字不能为空 或 null!(clsgs_ResearchResultDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strResultId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsgs_ResearchResultDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsgs_ResearchResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_gs_ResearchResult(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsgs_ResearchResultDA: GetDataTable_gs_ResearchResult)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchResult where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsgs_ResearchResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsgs_ResearchResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchResult where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsgs_ResearchResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsgs_ResearchResultDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_ResearchResult where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_ResearchResult where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsgs_ResearchResultDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from gs_ResearchResult where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsgs_ResearchResultDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_ResearchResult.* from gs_ResearchResult Left Join {1} on {2} where {3} and gs_ResearchResult.ResultId not in (Select top {5} gs_ResearchResult.ResultId from gs_ResearchResult Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_ResearchResult where {1} and ResultId not in (Select top {2} ResultId from gs_ResearchResult where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_ResearchResult where {1} and ResultId not in (Select top {3} ResultId from gs_ResearchResult where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsgs_ResearchResultDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_ResearchResult.* from gs_ResearchResult Left Join {1} on {2} where {3} and gs_ResearchResult.ResultId not in (Select top {5} gs_ResearchResult.ResultId from gs_ResearchResult Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_ResearchResult where {1} and ResultId not in (Select top {2} ResultId from gs_ResearchResult where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_ResearchResult where {1} and ResultId not in (Select top {3} ResultId from gs_ResearchResult where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsgs_ResearchResultEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsgs_ResearchResultDA:GetObjLst)", objException.Message));
}
List<clsgs_ResearchResultEN> arrObjLst = new List<clsgs_ResearchResultEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultEN objgs_ResearchResultEN = new clsgs_ResearchResultEN();
try
{
objgs_ResearchResultEN.ResultId = objRow[congs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultEN.TopicId = objRow[congs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultEN.PaperId = objRow[congs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[congs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objgs_ResearchResultEN.ResultTypeId = objRow[congs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objgs_ResearchResultEN.ResultName = objRow[congs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objgs_ResearchResultEN.ResultContent = objRow[congs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objgs_ResearchResultEN.Author = objRow[congs_ResearchResult.Author] == DBNull.Value ? null : objRow[congs_ResearchResult.Author].ToString().Trim(); //作者
objgs_ResearchResultEN.Division = objRow[congs_ResearchResult.Division] == DBNull.Value ? null : objRow[congs_ResearchResult.Division].ToString().Trim(); //分工
objgs_ResearchResultEN.VersionCount = objRow[congs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objgs_ResearchResultEN.OkCount = objRow[congs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objgs_ResearchResultEN.AppraiseCount = objRow[congs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objgs_ResearchResultEN.Score = objRow[congs_ResearchResult.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_ResearchResult.Score].ToString().Trim()); //评分
objgs_ResearchResultEN.StuScore = objRow[congs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objgs_ResearchResultEN.TeaScore = objRow[congs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objgs_ResearchResultEN.IdCurrEduCls = objRow[congs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ResearchResultEN.UpdDate = objRow[congs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultEN.UpdUser = objRow[congs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultEN.Memo = objRow[congs_ResearchResult.Memo] == DBNull.Value ? null : objRow[congs_ResearchResult.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_ResearchResultDA: GetObjLst)", objException.Message));
}
objgs_ResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_ResearchResultEN);
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
public List<clsgs_ResearchResultEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsgs_ResearchResultDA:GetObjLstByTabName)", objException.Message));
}
List<clsgs_ResearchResultEN> arrObjLst = new List<clsgs_ResearchResultEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultEN objgs_ResearchResultEN = new clsgs_ResearchResultEN();
try
{
objgs_ResearchResultEN.ResultId = objRow[congs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultEN.TopicId = objRow[congs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultEN.PaperId = objRow[congs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[congs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objgs_ResearchResultEN.ResultTypeId = objRow[congs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objgs_ResearchResultEN.ResultName = objRow[congs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objgs_ResearchResultEN.ResultContent = objRow[congs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objgs_ResearchResultEN.Author = objRow[congs_ResearchResult.Author] == DBNull.Value ? null : objRow[congs_ResearchResult.Author].ToString().Trim(); //作者
objgs_ResearchResultEN.Division = objRow[congs_ResearchResult.Division] == DBNull.Value ? null : objRow[congs_ResearchResult.Division].ToString().Trim(); //分工
objgs_ResearchResultEN.VersionCount = objRow[congs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objgs_ResearchResultEN.OkCount = objRow[congs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objgs_ResearchResultEN.AppraiseCount = objRow[congs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objgs_ResearchResultEN.Score = objRow[congs_ResearchResult.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_ResearchResult.Score].ToString().Trim()); //评分
objgs_ResearchResultEN.StuScore = objRow[congs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objgs_ResearchResultEN.TeaScore = objRow[congs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objgs_ResearchResultEN.IdCurrEduCls = objRow[congs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ResearchResultEN.UpdDate = objRow[congs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultEN.UpdUser = objRow[congs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultEN.Memo = objRow[congs_ResearchResult.Memo] == DBNull.Value ? null : objRow[congs_ResearchResult.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_ResearchResultDA: GetObjLst)", objException.Message));
}
objgs_ResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_ResearchResultEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getgs_ResearchResult(ref clsgs_ResearchResultEN objgs_ResearchResultEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchResult where ResultId = " + "'"+ objgs_ResearchResultEN.ResultId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objgs_ResearchResultEN.ResultId = objDT.Rows[0][congs_ResearchResult.ResultId].ToString().Trim(); //成果Id(字段类型:char,字段长度:10,是否可空:False)
 objgs_ResearchResultEN.TopicId = objDT.Rows[0][congs_ResearchResult.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_ResearchResultEN.PaperId = objDT.Rows[0][congs_ResearchResult.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_ResearchResultEN.ResultTypeId = objDT.Rows[0][congs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id(字段类型:char,字段长度:2,是否可空:True)
 objgs_ResearchResultEN.ResultName = objDT.Rows[0][congs_ResearchResult.ResultName].ToString().Trim(); //成果名称(字段类型:varchar,字段长度:500,是否可空:True)
 objgs_ResearchResultEN.ResultContent = objDT.Rows[0][congs_ResearchResult.ResultContent].ToString().Trim(); //成果内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objgs_ResearchResultEN.Author = objDT.Rows[0][congs_ResearchResult.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objgs_ResearchResultEN.Division = objDT.Rows[0][congs_ResearchResult.Division].ToString().Trim(); //分工(字段类型:varchar,字段长度:500,是否可空:True)
 objgs_ResearchResultEN.VersionCount = TransNullToInt(objDT.Rows[0][congs_ResearchResult.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objgs_ResearchResultEN.OkCount = TransNullToInt(objDT.Rows[0][congs_ResearchResult.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objgs_ResearchResultEN.AppraiseCount = TransNullToInt(objDT.Rows[0][congs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objgs_ResearchResultEN.Score = TransNullToFloat(objDT.Rows[0][congs_ResearchResult.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objgs_ResearchResultEN.StuScore = TransNullToFloat(objDT.Rows[0][congs_ResearchResult.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objgs_ResearchResultEN.TeaScore = TransNullToFloat(objDT.Rows[0][congs_ResearchResult.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objgs_ResearchResultEN.IdCurrEduCls = objDT.Rows[0][congs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objgs_ResearchResultEN.UpdDate = objDT.Rows[0][congs_ResearchResult.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_ResearchResultEN.UpdUser = objDT.Rows[0][congs_ResearchResult.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_ResearchResultEN.Memo = objDT.Rows[0][congs_ResearchResult.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsgs_ResearchResultDA: Getgs_ResearchResult)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strResultId">表关键字</param>
 /// <returns>表对象</returns>
public clsgs_ResearchResultEN GetObjByResultId(string strResultId)
{
CheckPrimaryKey(strResultId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchResult where ResultId = " + "'"+ strResultId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsgs_ResearchResultEN objgs_ResearchResultEN = new clsgs_ResearchResultEN();
try
{
 objgs_ResearchResultEN.ResultId = objRow[congs_ResearchResult.ResultId].ToString().Trim(); //成果Id(字段类型:char,字段长度:10,是否可空:False)
 objgs_ResearchResultEN.TopicId = objRow[congs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResult.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_ResearchResultEN.PaperId = objRow[congs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[congs_ResearchResult.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_ResearchResultEN.ResultTypeId = objRow[congs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id(字段类型:char,字段长度:2,是否可空:True)
 objgs_ResearchResultEN.ResultName = objRow[congs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultName].ToString().Trim(); //成果名称(字段类型:varchar,字段长度:500,是否可空:True)
 objgs_ResearchResultEN.ResultContent = objRow[congs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultContent].ToString().Trim(); //成果内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objgs_ResearchResultEN.Author = objRow[congs_ResearchResult.Author] == DBNull.Value ? null : objRow[congs_ResearchResult.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objgs_ResearchResultEN.Division = objRow[congs_ResearchResult.Division] == DBNull.Value ? null : objRow[congs_ResearchResult.Division].ToString().Trim(); //分工(字段类型:varchar,字段长度:500,是否可空:True)
 objgs_ResearchResultEN.VersionCount = objRow[congs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objgs_ResearchResultEN.OkCount = objRow[congs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objgs_ResearchResultEN.AppraiseCount = objRow[congs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objgs_ResearchResultEN.Score = objRow[congs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objgs_ResearchResultEN.StuScore = objRow[congs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objgs_ResearchResultEN.TeaScore = objRow[congs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objgs_ResearchResultEN.IdCurrEduCls = objRow[congs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objgs_ResearchResultEN.UpdDate = objRow[congs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_ResearchResultEN.UpdUser = objRow[congs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_ResearchResultEN.Memo = objRow[congs_ResearchResult.Memo] == DBNull.Value ? null : objRow[congs_ResearchResult.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsgs_ResearchResultDA: GetObjByResultId)", objException.Message));
}
return objgs_ResearchResultEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsgs_ResearchResultEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsgs_ResearchResultDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsgs_ResearchResultEN objgs_ResearchResultEN = new clsgs_ResearchResultEN()
{
ResultId = objRow[congs_ResearchResult.ResultId].ToString().Trim(), //成果Id
TopicId = objRow[congs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResult.TopicId].ToString().Trim(), //主题Id
PaperId = objRow[congs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[congs_ResearchResult.PaperId].ToString().Trim(), //论文Id
ResultTypeId = objRow[congs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultTypeId].ToString().Trim(), //成果类型Id
ResultName = objRow[congs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultName].ToString().Trim(), //成果名称
ResultContent = objRow[congs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultContent].ToString().Trim(), //成果内容
Author = objRow[congs_ResearchResult.Author] == DBNull.Value ? null : objRow[congs_ResearchResult.Author].ToString().Trim(), //作者
Division = objRow[congs_ResearchResult.Division] == DBNull.Value ? null : objRow[congs_ResearchResult.Division].ToString().Trim(), //分工
VersionCount = objRow[congs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_ResearchResult.VersionCount].ToString().Trim()), //版本统计
OkCount = objRow[congs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_ResearchResult.OkCount].ToString().Trim()), //点赞统计
AppraiseCount = objRow[congs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_ResearchResult.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[congs_ResearchResult.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_ResearchResult.Score].ToString().Trim()), //评分
StuScore = objRow[congs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_ResearchResult.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[congs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_ResearchResult.TeaScore].ToString().Trim()), //教师评分
IdCurrEduCls = objRow[congs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchResult.IdCurrEduCls].ToString().Trim(), //教学班流水号
UpdDate = objRow[congs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[congs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdUser].ToString().Trim(), //修改人
Memo = objRow[congs_ResearchResult.Memo] == DBNull.Value ? null : objRow[congs_ResearchResult.Memo].ToString().Trim() //备注
};
objgs_ResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_ResearchResultEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsgs_ResearchResultDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsgs_ResearchResultEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_ResearchResultEN objgs_ResearchResultEN = new clsgs_ResearchResultEN();
try
{
objgs_ResearchResultEN.ResultId = objRow[congs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultEN.TopicId = objRow[congs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultEN.PaperId = objRow[congs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[congs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objgs_ResearchResultEN.ResultTypeId = objRow[congs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objgs_ResearchResultEN.ResultName = objRow[congs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objgs_ResearchResultEN.ResultContent = objRow[congs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objgs_ResearchResultEN.Author = objRow[congs_ResearchResult.Author] == DBNull.Value ? null : objRow[congs_ResearchResult.Author].ToString().Trim(); //作者
objgs_ResearchResultEN.Division = objRow[congs_ResearchResult.Division] == DBNull.Value ? null : objRow[congs_ResearchResult.Division].ToString().Trim(); //分工
objgs_ResearchResultEN.VersionCount = objRow[congs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objgs_ResearchResultEN.OkCount = objRow[congs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objgs_ResearchResultEN.AppraiseCount = objRow[congs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objgs_ResearchResultEN.Score = objRow[congs_ResearchResult.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_ResearchResult.Score].ToString().Trim()); //评分
objgs_ResearchResultEN.StuScore = objRow[congs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objgs_ResearchResultEN.TeaScore = objRow[congs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objgs_ResearchResultEN.IdCurrEduCls = objRow[congs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ResearchResultEN.UpdDate = objRow[congs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultEN.UpdUser = objRow[congs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultEN.Memo = objRow[congs_ResearchResult.Memo] == DBNull.Value ? null : objRow[congs_ResearchResult.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsgs_ResearchResultDA: GetObjByDataRowgs_ResearchResult)", objException.Message));
}
objgs_ResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_ResearchResultEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsgs_ResearchResultEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_ResearchResultEN objgs_ResearchResultEN = new clsgs_ResearchResultEN();
try
{
objgs_ResearchResultEN.ResultId = objRow[congs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultEN.TopicId = objRow[congs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultEN.PaperId = objRow[congs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[congs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objgs_ResearchResultEN.ResultTypeId = objRow[congs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objgs_ResearchResultEN.ResultName = objRow[congs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objgs_ResearchResultEN.ResultContent = objRow[congs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objgs_ResearchResultEN.Author = objRow[congs_ResearchResult.Author] == DBNull.Value ? null : objRow[congs_ResearchResult.Author].ToString().Trim(); //作者
objgs_ResearchResultEN.Division = objRow[congs_ResearchResult.Division] == DBNull.Value ? null : objRow[congs_ResearchResult.Division].ToString().Trim(); //分工
objgs_ResearchResultEN.VersionCount = objRow[congs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objgs_ResearchResultEN.OkCount = objRow[congs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objgs_ResearchResultEN.AppraiseCount = objRow[congs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objgs_ResearchResultEN.Score = objRow[congs_ResearchResult.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_ResearchResult.Score].ToString().Trim()); //评分
objgs_ResearchResultEN.StuScore = objRow[congs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objgs_ResearchResultEN.TeaScore = objRow[congs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objgs_ResearchResultEN.IdCurrEduCls = objRow[congs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ResearchResultEN.UpdDate = objRow[congs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultEN.UpdUser = objRow[congs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultEN.Memo = objRow[congs_ResearchResult.Memo] == DBNull.Value ? null : objRow[congs_ResearchResult.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsgs_ResearchResultDA: GetObjByDataRow)", objException.Message));
}
objgs_ResearchResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_ResearchResultEN;
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
objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_ResearchResultEN._CurrTabName, congs_ResearchResult.ResultId, 10, "");
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
objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_ResearchResultEN._CurrTabName, congs_ResearchResult.ResultId, 10, strPrefix);
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
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ResultId from gs_ResearchResult where " + strCondition;
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
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ResultId from gs_ResearchResult where " + strCondition;
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
 /// <param name = "strResultId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strResultId)
{
CheckPrimaryKey(strResultId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_ResearchResult", "ResultId = " + "'"+ strResultId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsgs_ResearchResultDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_ResearchResult", strCondition))
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
objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("gs_ResearchResult");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsgs_ResearchResultEN objgs_ResearchResultEN)
 {
 if (objgs_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_ResearchResultEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchResult where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_ResearchResult");
objRow = objDS.Tables["gs_ResearchResult"].NewRow();
objRow[congs_ResearchResult.ResultId] = objgs_ResearchResultEN.ResultId; //成果Id
 if (objgs_ResearchResultEN.TopicId !=  "")
 {
objRow[congs_ResearchResult.TopicId] = objgs_ResearchResultEN.TopicId; //主题Id
 }
 if (objgs_ResearchResultEN.PaperId !=  "")
 {
objRow[congs_ResearchResult.PaperId] = objgs_ResearchResultEN.PaperId; //论文Id
 }
 if (objgs_ResearchResultEN.ResultTypeId !=  "")
 {
objRow[congs_ResearchResult.ResultTypeId] = objgs_ResearchResultEN.ResultTypeId; //成果类型Id
 }
 if (objgs_ResearchResultEN.ResultName !=  "")
 {
objRow[congs_ResearchResult.ResultName] = objgs_ResearchResultEN.ResultName; //成果名称
 }
 if (objgs_ResearchResultEN.ResultContent !=  "")
 {
objRow[congs_ResearchResult.ResultContent] = objgs_ResearchResultEN.ResultContent; //成果内容
 }
 if (objgs_ResearchResultEN.Author !=  "")
 {
objRow[congs_ResearchResult.Author] = objgs_ResearchResultEN.Author; //作者
 }
 if (objgs_ResearchResultEN.Division !=  "")
 {
objRow[congs_ResearchResult.Division] = objgs_ResearchResultEN.Division; //分工
 }
objRow[congs_ResearchResult.VersionCount] = objgs_ResearchResultEN.VersionCount; //版本统计
objRow[congs_ResearchResult.OkCount] = objgs_ResearchResultEN.OkCount; //点赞统计
objRow[congs_ResearchResult.AppraiseCount] = objgs_ResearchResultEN.AppraiseCount; //评论数
objRow[congs_ResearchResult.Score] = objgs_ResearchResultEN.Score; //评分
objRow[congs_ResearchResult.StuScore] = objgs_ResearchResultEN.StuScore; //学生平均分
objRow[congs_ResearchResult.TeaScore] = objgs_ResearchResultEN.TeaScore; //教师评分
 if (objgs_ResearchResultEN.IdCurrEduCls !=  "")
 {
objRow[congs_ResearchResult.IdCurrEduCls] = objgs_ResearchResultEN.IdCurrEduCls; //教学班流水号
 }
 if (objgs_ResearchResultEN.UpdDate !=  "")
 {
objRow[congs_ResearchResult.UpdDate] = objgs_ResearchResultEN.UpdDate; //修改日期
 }
 if (objgs_ResearchResultEN.UpdUser !=  "")
 {
objRow[congs_ResearchResult.UpdUser] = objgs_ResearchResultEN.UpdUser; //修改人
 }
 if (objgs_ResearchResultEN.Memo !=  "")
 {
objRow[congs_ResearchResult.Memo] = objgs_ResearchResultEN.Memo; //备注
 }
objDS.Tables[clsgs_ResearchResultEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsgs_ResearchResultEN._CurrTabName);
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
 /// <param name = "objgs_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_ResearchResultEN objgs_ResearchResultEN)
{
 if (objgs_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_ResearchResultEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_ResearchResultEN.ResultId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.ResultId);
 var strResultId = objgs_ResearchResultEN.ResultId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultId + "'");
 }
 
 if (objgs_ResearchResultEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.TopicId);
 var strTopicId = objgs_ResearchResultEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objgs_ResearchResultEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.PaperId);
 var strPaperId = objgs_ResearchResultEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_ResearchResultEN.ResultTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.ResultTypeId);
 var strResultTypeId = objgs_ResearchResultEN.ResultTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultTypeId + "'");
 }
 
 if (objgs_ResearchResultEN.ResultName !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.ResultName);
 var strResultName = objgs_ResearchResultEN.ResultName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultName + "'");
 }
 
 if (objgs_ResearchResultEN.ResultContent !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.ResultContent);
 var strResultContent = objgs_ResearchResultEN.ResultContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultContent + "'");
 }
 
 if (objgs_ResearchResultEN.Author !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.Author);
 var strAuthor = objgs_ResearchResultEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objgs_ResearchResultEN.Division !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.Division);
 var strDivision = objgs_ResearchResultEN.Division.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDivision + "'");
 }
 
 if (objgs_ResearchResultEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.VersionCount);
 arrValueListForInsert.Add(objgs_ResearchResultEN.VersionCount.ToString());
 }
 
 if (objgs_ResearchResultEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.OkCount);
 arrValueListForInsert.Add(objgs_ResearchResultEN.OkCount.ToString());
 }
 
 if (objgs_ResearchResultEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.AppraiseCount);
 arrValueListForInsert.Add(objgs_ResearchResultEN.AppraiseCount.ToString());
 }
 
 if (objgs_ResearchResultEN.Score !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.Score);
 arrValueListForInsert.Add(objgs_ResearchResultEN.Score.ToString());
 }
 
 if (objgs_ResearchResultEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.StuScore);
 arrValueListForInsert.Add(objgs_ResearchResultEN.StuScore.ToString());
 }
 
 if (objgs_ResearchResultEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.TeaScore);
 arrValueListForInsert.Add(objgs_ResearchResultEN.TeaScore.ToString());
 }
 
 if (objgs_ResearchResultEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.IdCurrEduCls);
 var strIdCurrEduCls = objgs_ResearchResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_ResearchResultEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.UpdDate);
 var strUpdDate = objgs_ResearchResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_ResearchResultEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.UpdUser);
 var strUpdUser = objgs_ResearchResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_ResearchResultEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.Memo);
 var strMemo = objgs_ResearchResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_ResearchResult");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_ResearchResultEN objgs_ResearchResultEN)
{
 if (objgs_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_ResearchResultEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_ResearchResultEN.ResultId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.ResultId);
 var strResultId = objgs_ResearchResultEN.ResultId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultId + "'");
 }
 
 if (objgs_ResearchResultEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.TopicId);
 var strTopicId = objgs_ResearchResultEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objgs_ResearchResultEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.PaperId);
 var strPaperId = objgs_ResearchResultEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_ResearchResultEN.ResultTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.ResultTypeId);
 var strResultTypeId = objgs_ResearchResultEN.ResultTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultTypeId + "'");
 }
 
 if (objgs_ResearchResultEN.ResultName !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.ResultName);
 var strResultName = objgs_ResearchResultEN.ResultName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultName + "'");
 }
 
 if (objgs_ResearchResultEN.ResultContent !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.ResultContent);
 var strResultContent = objgs_ResearchResultEN.ResultContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultContent + "'");
 }
 
 if (objgs_ResearchResultEN.Author !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.Author);
 var strAuthor = objgs_ResearchResultEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objgs_ResearchResultEN.Division !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.Division);
 var strDivision = objgs_ResearchResultEN.Division.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDivision + "'");
 }
 
 if (objgs_ResearchResultEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.VersionCount);
 arrValueListForInsert.Add(objgs_ResearchResultEN.VersionCount.ToString());
 }
 
 if (objgs_ResearchResultEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.OkCount);
 arrValueListForInsert.Add(objgs_ResearchResultEN.OkCount.ToString());
 }
 
 if (objgs_ResearchResultEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.AppraiseCount);
 arrValueListForInsert.Add(objgs_ResearchResultEN.AppraiseCount.ToString());
 }
 
 if (objgs_ResearchResultEN.Score !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.Score);
 arrValueListForInsert.Add(objgs_ResearchResultEN.Score.ToString());
 }
 
 if (objgs_ResearchResultEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.StuScore);
 arrValueListForInsert.Add(objgs_ResearchResultEN.StuScore.ToString());
 }
 
 if (objgs_ResearchResultEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.TeaScore);
 arrValueListForInsert.Add(objgs_ResearchResultEN.TeaScore.ToString());
 }
 
 if (objgs_ResearchResultEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.IdCurrEduCls);
 var strIdCurrEduCls = objgs_ResearchResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_ResearchResultEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.UpdDate);
 var strUpdDate = objgs_ResearchResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_ResearchResultEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.UpdUser);
 var strUpdUser = objgs_ResearchResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_ResearchResultEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.Memo);
 var strMemo = objgs_ResearchResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_ResearchResult");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objgs_ResearchResultEN.ResultId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_ResearchResultEN objgs_ResearchResultEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_ResearchResultEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_ResearchResultEN.ResultId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.ResultId);
 var strResultId = objgs_ResearchResultEN.ResultId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultId + "'");
 }
 
 if (objgs_ResearchResultEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.TopicId);
 var strTopicId = objgs_ResearchResultEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objgs_ResearchResultEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.PaperId);
 var strPaperId = objgs_ResearchResultEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_ResearchResultEN.ResultTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.ResultTypeId);
 var strResultTypeId = objgs_ResearchResultEN.ResultTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultTypeId + "'");
 }
 
 if (objgs_ResearchResultEN.ResultName !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.ResultName);
 var strResultName = objgs_ResearchResultEN.ResultName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultName + "'");
 }
 
 if (objgs_ResearchResultEN.ResultContent !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.ResultContent);
 var strResultContent = objgs_ResearchResultEN.ResultContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultContent + "'");
 }
 
 if (objgs_ResearchResultEN.Author !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.Author);
 var strAuthor = objgs_ResearchResultEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objgs_ResearchResultEN.Division !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.Division);
 var strDivision = objgs_ResearchResultEN.Division.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDivision + "'");
 }
 
 if (objgs_ResearchResultEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.VersionCount);
 arrValueListForInsert.Add(objgs_ResearchResultEN.VersionCount.ToString());
 }
 
 if (objgs_ResearchResultEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.OkCount);
 arrValueListForInsert.Add(objgs_ResearchResultEN.OkCount.ToString());
 }
 
 if (objgs_ResearchResultEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.AppraiseCount);
 arrValueListForInsert.Add(objgs_ResearchResultEN.AppraiseCount.ToString());
 }
 
 if (objgs_ResearchResultEN.Score !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.Score);
 arrValueListForInsert.Add(objgs_ResearchResultEN.Score.ToString());
 }
 
 if (objgs_ResearchResultEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.StuScore);
 arrValueListForInsert.Add(objgs_ResearchResultEN.StuScore.ToString());
 }
 
 if (objgs_ResearchResultEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.TeaScore);
 arrValueListForInsert.Add(objgs_ResearchResultEN.TeaScore.ToString());
 }
 
 if (objgs_ResearchResultEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.IdCurrEduCls);
 var strIdCurrEduCls = objgs_ResearchResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_ResearchResultEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.UpdDate);
 var strUpdDate = objgs_ResearchResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_ResearchResultEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.UpdUser);
 var strUpdUser = objgs_ResearchResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_ResearchResultEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.Memo);
 var strMemo = objgs_ResearchResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_ResearchResult");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objgs_ResearchResultEN.ResultId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_ResearchResultEN objgs_ResearchResultEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_ResearchResultEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_ResearchResultEN.ResultId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.ResultId);
 var strResultId = objgs_ResearchResultEN.ResultId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultId + "'");
 }
 
 if (objgs_ResearchResultEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.TopicId);
 var strTopicId = objgs_ResearchResultEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objgs_ResearchResultEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.PaperId);
 var strPaperId = objgs_ResearchResultEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_ResearchResultEN.ResultTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.ResultTypeId);
 var strResultTypeId = objgs_ResearchResultEN.ResultTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultTypeId + "'");
 }
 
 if (objgs_ResearchResultEN.ResultName !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.ResultName);
 var strResultName = objgs_ResearchResultEN.ResultName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultName + "'");
 }
 
 if (objgs_ResearchResultEN.ResultContent !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.ResultContent);
 var strResultContent = objgs_ResearchResultEN.ResultContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResultContent + "'");
 }
 
 if (objgs_ResearchResultEN.Author !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.Author);
 var strAuthor = objgs_ResearchResultEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAuthor + "'");
 }
 
 if (objgs_ResearchResultEN.Division !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.Division);
 var strDivision = objgs_ResearchResultEN.Division.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDivision + "'");
 }
 
 if (objgs_ResearchResultEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.VersionCount);
 arrValueListForInsert.Add(objgs_ResearchResultEN.VersionCount.ToString());
 }
 
 if (objgs_ResearchResultEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.OkCount);
 arrValueListForInsert.Add(objgs_ResearchResultEN.OkCount.ToString());
 }
 
 if (objgs_ResearchResultEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.AppraiseCount);
 arrValueListForInsert.Add(objgs_ResearchResultEN.AppraiseCount.ToString());
 }
 
 if (objgs_ResearchResultEN.Score !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.Score);
 arrValueListForInsert.Add(objgs_ResearchResultEN.Score.ToString());
 }
 
 if (objgs_ResearchResultEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.StuScore);
 arrValueListForInsert.Add(objgs_ResearchResultEN.StuScore.ToString());
 }
 
 if (objgs_ResearchResultEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.TeaScore);
 arrValueListForInsert.Add(objgs_ResearchResultEN.TeaScore.ToString());
 }
 
 if (objgs_ResearchResultEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.IdCurrEduCls);
 var strIdCurrEduCls = objgs_ResearchResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_ResearchResultEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.UpdDate);
 var strUpdDate = objgs_ResearchResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_ResearchResultEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.UpdUser);
 var strUpdUser = objgs_ResearchResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_ResearchResultEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchResult.Memo);
 var strMemo = objgs_ResearchResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_ResearchResult");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewgs_ResearchResults(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchResult where ResultId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_ResearchResult");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strResultId = oRow[congs_ResearchResult.ResultId].ToString().Trim();
if (IsExist(strResultId))
{
 string strResult = "关键字变量值为:" + string.Format("ResultId = {0}", strResultId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsgs_ResearchResultEN._CurrTabName ].NewRow();
objRow[congs_ResearchResult.ResultId] = oRow[congs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objRow[congs_ResearchResult.TopicId] = oRow[congs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objRow[congs_ResearchResult.PaperId] = oRow[congs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objRow[congs_ResearchResult.ResultTypeId] = oRow[congs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objRow[congs_ResearchResult.ResultName] = oRow[congs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objRow[congs_ResearchResult.ResultContent] = oRow[congs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objRow[congs_ResearchResult.Author] = oRow[congs_ResearchResult.Author].ToString().Trim(); //作者
objRow[congs_ResearchResult.Division] = oRow[congs_ResearchResult.Division].ToString().Trim(); //分工
objRow[congs_ResearchResult.VersionCount] = oRow[congs_ResearchResult.VersionCount].ToString().Trim(); //版本统计
objRow[congs_ResearchResult.OkCount] = oRow[congs_ResearchResult.OkCount].ToString().Trim(); //点赞统计
objRow[congs_ResearchResult.AppraiseCount] = oRow[congs_ResearchResult.AppraiseCount].ToString().Trim(); //评论数
objRow[congs_ResearchResult.Score] = oRow[congs_ResearchResult.Score].ToString().Trim(); //评分
objRow[congs_ResearchResult.StuScore] = oRow[congs_ResearchResult.StuScore].ToString().Trim(); //学生平均分
objRow[congs_ResearchResult.TeaScore] = oRow[congs_ResearchResult.TeaScore].ToString().Trim(); //教师评分
objRow[congs_ResearchResult.IdCurrEduCls] = oRow[congs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[congs_ResearchResult.UpdDate] = oRow[congs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objRow[congs_ResearchResult.UpdUser] = oRow[congs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objRow[congs_ResearchResult.Memo] = oRow[congs_ResearchResult.Memo].ToString().Trim(); //备注
 objDS.Tables[clsgs_ResearchResultEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsgs_ResearchResultEN._CurrTabName);
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
 /// <param name = "objgs_ResearchResultEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsgs_ResearchResultEN objgs_ResearchResultEN)
{
 if (objgs_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_ResearchResultEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchResult where ResultId = " + "'"+ objgs_ResearchResultEN.ResultId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsgs_ResearchResultEN._CurrTabName);
if (objDS.Tables[clsgs_ResearchResultEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ResultId = " + "'"+ objgs_ResearchResultEN.ResultId+"'");
return false;
}
objRow = objDS.Tables[clsgs_ResearchResultEN._CurrTabName].Rows[0];
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.ResultId))
 {
objRow[congs_ResearchResult.ResultId] = objgs_ResearchResultEN.ResultId; //成果Id
 }
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.TopicId))
 {
objRow[congs_ResearchResult.TopicId] = objgs_ResearchResultEN.TopicId; //主题Id
 }
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.PaperId))
 {
objRow[congs_ResearchResult.PaperId] = objgs_ResearchResultEN.PaperId; //论文Id
 }
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.ResultTypeId))
 {
objRow[congs_ResearchResult.ResultTypeId] = objgs_ResearchResultEN.ResultTypeId; //成果类型Id
 }
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.ResultName))
 {
objRow[congs_ResearchResult.ResultName] = objgs_ResearchResultEN.ResultName; //成果名称
 }
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.ResultContent))
 {
objRow[congs_ResearchResult.ResultContent] = objgs_ResearchResultEN.ResultContent; //成果内容
 }
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Author))
 {
objRow[congs_ResearchResult.Author] = objgs_ResearchResultEN.Author; //作者
 }
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Division))
 {
objRow[congs_ResearchResult.Division] = objgs_ResearchResultEN.Division; //分工
 }
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.VersionCount))
 {
objRow[congs_ResearchResult.VersionCount] = objgs_ResearchResultEN.VersionCount; //版本统计
 }
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.OkCount))
 {
objRow[congs_ResearchResult.OkCount] = objgs_ResearchResultEN.OkCount; //点赞统计
 }
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.AppraiseCount))
 {
objRow[congs_ResearchResult.AppraiseCount] = objgs_ResearchResultEN.AppraiseCount; //评论数
 }
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Score))
 {
objRow[congs_ResearchResult.Score] = objgs_ResearchResultEN.Score; //评分
 }
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.StuScore))
 {
objRow[congs_ResearchResult.StuScore] = objgs_ResearchResultEN.StuScore; //学生平均分
 }
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.TeaScore))
 {
objRow[congs_ResearchResult.TeaScore] = objgs_ResearchResultEN.TeaScore; //教师评分
 }
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.IdCurrEduCls))
 {
objRow[congs_ResearchResult.IdCurrEduCls] = objgs_ResearchResultEN.IdCurrEduCls; //教学班流水号
 }
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.UpdDate))
 {
objRow[congs_ResearchResult.UpdDate] = objgs_ResearchResultEN.UpdDate; //修改日期
 }
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.UpdUser))
 {
objRow[congs_ResearchResult.UpdUser] = objgs_ResearchResultEN.UpdUser; //修改人
 }
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Memo))
 {
objRow[congs_ResearchResult.Memo] = objgs_ResearchResultEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsgs_ResearchResultEN._CurrTabName);
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
 /// <param name = "objgs_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_ResearchResultEN objgs_ResearchResultEN)
{
 if (objgs_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_ResearchResultEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update gs_ResearchResult Set ");
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.TopicId))
 {
 if (objgs_ResearchResultEN.TopicId !=  null)
 {
 var strTopicId = objgs_ResearchResultEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, congs_ResearchResult.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.TopicId); //主题Id
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.PaperId))
 {
 if (objgs_ResearchResultEN.PaperId !=  null)
 {
 var strPaperId = objgs_ResearchResultEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, congs_ResearchResult.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.PaperId); //论文Id
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.ResultTypeId))
 {
 if (objgs_ResearchResultEN.ResultTypeId !=  null)
 {
 var strResultTypeId = objgs_ResearchResultEN.ResultTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResultTypeId, congs_ResearchResult.ResultTypeId); //成果类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.ResultTypeId); //成果类型Id
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.ResultName))
 {
 if (objgs_ResearchResultEN.ResultName !=  null)
 {
 var strResultName = objgs_ResearchResultEN.ResultName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResultName, congs_ResearchResult.ResultName); //成果名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.ResultName); //成果名称
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.ResultContent))
 {
 if (objgs_ResearchResultEN.ResultContent !=  null)
 {
 var strResultContent = objgs_ResearchResultEN.ResultContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResultContent, congs_ResearchResult.ResultContent); //成果内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.ResultContent); //成果内容
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Author))
 {
 if (objgs_ResearchResultEN.Author !=  null)
 {
 var strAuthor = objgs_ResearchResultEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuthor, congs_ResearchResult.Author); //作者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.Author); //作者
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Division))
 {
 if (objgs_ResearchResultEN.Division !=  null)
 {
 var strDivision = objgs_ResearchResultEN.Division.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDivision, congs_ResearchResult.Division); //分工
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.Division); //分工
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.VersionCount))
 {
 if (objgs_ResearchResultEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.VersionCount, congs_ResearchResult.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.VersionCount); //版本统计
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.OkCount))
 {
 if (objgs_ResearchResultEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.OkCount, congs_ResearchResult.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.OkCount); //点赞统计
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.AppraiseCount))
 {
 if (objgs_ResearchResultEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.AppraiseCount, congs_ResearchResult.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.AppraiseCount); //评论数
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Score))
 {
 if (objgs_ResearchResultEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.Score, congs_ResearchResult.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.Score); //评分
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.StuScore))
 {
 if (objgs_ResearchResultEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.StuScore, congs_ResearchResult.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.StuScore); //学生平均分
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.TeaScore))
 {
 if (objgs_ResearchResultEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.TeaScore, congs_ResearchResult.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.TeaScore); //教师评分
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.IdCurrEduCls))
 {
 if (objgs_ResearchResultEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_ResearchResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_ResearchResult.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.UpdDate))
 {
 if (objgs_ResearchResultEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_ResearchResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_ResearchResult.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.UpdDate); //修改日期
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.UpdUser))
 {
 if (objgs_ResearchResultEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_ResearchResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_ResearchResult.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.UpdUser); //修改人
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Memo))
 {
 if (objgs_ResearchResultEN.Memo !=  null)
 {
 var strMemo = objgs_ResearchResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_ResearchResult.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ResultId = '{0}'", objgs_ResearchResultEN.ResultId); 
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
 /// <param name = "objgs_ResearchResultEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsgs_ResearchResultEN objgs_ResearchResultEN, string strCondition)
{
 if (objgs_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_ResearchResultEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_ResearchResult Set ");
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.TopicId))
 {
 if (objgs_ResearchResultEN.TopicId !=  null)
 {
 var strTopicId = objgs_ResearchResultEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.PaperId))
 {
 if (objgs_ResearchResultEN.PaperId !=  null)
 {
 var strPaperId = objgs_ResearchResultEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.ResultTypeId))
 {
 if (objgs_ResearchResultEN.ResultTypeId !=  null)
 {
 var strResultTypeId = objgs_ResearchResultEN.ResultTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResultTypeId = '{0}',", strResultTypeId); //成果类型Id
 }
 else
 {
 sbSQL.Append(" ResultTypeId = null,"); //成果类型Id
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.ResultName))
 {
 if (objgs_ResearchResultEN.ResultName !=  null)
 {
 var strResultName = objgs_ResearchResultEN.ResultName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResultName = '{0}',", strResultName); //成果名称
 }
 else
 {
 sbSQL.Append(" ResultName = null,"); //成果名称
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.ResultContent))
 {
 if (objgs_ResearchResultEN.ResultContent !=  null)
 {
 var strResultContent = objgs_ResearchResultEN.ResultContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResultContent = '{0}',", strResultContent); //成果内容
 }
 else
 {
 sbSQL.Append(" ResultContent = null,"); //成果内容
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Author))
 {
 if (objgs_ResearchResultEN.Author !=  null)
 {
 var strAuthor = objgs_ResearchResultEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Author = '{0}',", strAuthor); //作者
 }
 else
 {
 sbSQL.Append(" Author = null,"); //作者
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Division))
 {
 if (objgs_ResearchResultEN.Division !=  null)
 {
 var strDivision = objgs_ResearchResultEN.Division.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Division = '{0}',", strDivision); //分工
 }
 else
 {
 sbSQL.Append(" Division = null,"); //分工
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.VersionCount))
 {
 if (objgs_ResearchResultEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.VersionCount, congs_ResearchResult.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.VersionCount); //版本统计
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.OkCount))
 {
 if (objgs_ResearchResultEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.OkCount, congs_ResearchResult.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.OkCount); //点赞统计
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.AppraiseCount))
 {
 if (objgs_ResearchResultEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.AppraiseCount, congs_ResearchResult.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.AppraiseCount); //评论数
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Score))
 {
 if (objgs_ResearchResultEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.Score, congs_ResearchResult.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.Score); //评分
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.StuScore))
 {
 if (objgs_ResearchResultEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.StuScore, congs_ResearchResult.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.StuScore); //学生平均分
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.TeaScore))
 {
 if (objgs_ResearchResultEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.TeaScore, congs_ResearchResult.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.TeaScore); //教师评分
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.IdCurrEduCls))
 {
 if (objgs_ResearchResultEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_ResearchResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.UpdDate))
 {
 if (objgs_ResearchResultEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_ResearchResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.UpdUser))
 {
 if (objgs_ResearchResultEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_ResearchResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Memo))
 {
 if (objgs_ResearchResultEN.Memo !=  null)
 {
 var strMemo = objgs_ResearchResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objgs_ResearchResultEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsgs_ResearchResultEN objgs_ResearchResultEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_ResearchResultEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_ResearchResult Set ");
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.TopicId))
 {
 if (objgs_ResearchResultEN.TopicId !=  null)
 {
 var strTopicId = objgs_ResearchResultEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.PaperId))
 {
 if (objgs_ResearchResultEN.PaperId !=  null)
 {
 var strPaperId = objgs_ResearchResultEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.ResultTypeId))
 {
 if (objgs_ResearchResultEN.ResultTypeId !=  null)
 {
 var strResultTypeId = objgs_ResearchResultEN.ResultTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResultTypeId = '{0}',", strResultTypeId); //成果类型Id
 }
 else
 {
 sbSQL.Append(" ResultTypeId = null,"); //成果类型Id
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.ResultName))
 {
 if (objgs_ResearchResultEN.ResultName !=  null)
 {
 var strResultName = objgs_ResearchResultEN.ResultName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResultName = '{0}',", strResultName); //成果名称
 }
 else
 {
 sbSQL.Append(" ResultName = null,"); //成果名称
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.ResultContent))
 {
 if (objgs_ResearchResultEN.ResultContent !=  null)
 {
 var strResultContent = objgs_ResearchResultEN.ResultContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResultContent = '{0}',", strResultContent); //成果内容
 }
 else
 {
 sbSQL.Append(" ResultContent = null,"); //成果内容
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Author))
 {
 if (objgs_ResearchResultEN.Author !=  null)
 {
 var strAuthor = objgs_ResearchResultEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Author = '{0}',", strAuthor); //作者
 }
 else
 {
 sbSQL.Append(" Author = null,"); //作者
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Division))
 {
 if (objgs_ResearchResultEN.Division !=  null)
 {
 var strDivision = objgs_ResearchResultEN.Division.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Division = '{0}',", strDivision); //分工
 }
 else
 {
 sbSQL.Append(" Division = null,"); //分工
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.VersionCount))
 {
 if (objgs_ResearchResultEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.VersionCount, congs_ResearchResult.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.VersionCount); //版本统计
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.OkCount))
 {
 if (objgs_ResearchResultEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.OkCount, congs_ResearchResult.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.OkCount); //点赞统计
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.AppraiseCount))
 {
 if (objgs_ResearchResultEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.AppraiseCount, congs_ResearchResult.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.AppraiseCount); //评论数
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Score))
 {
 if (objgs_ResearchResultEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.Score, congs_ResearchResult.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.Score); //评分
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.StuScore))
 {
 if (objgs_ResearchResultEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.StuScore, congs_ResearchResult.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.StuScore); //学生平均分
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.TeaScore))
 {
 if (objgs_ResearchResultEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.TeaScore, congs_ResearchResult.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.TeaScore); //教师评分
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.IdCurrEduCls))
 {
 if (objgs_ResearchResultEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_ResearchResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.UpdDate))
 {
 if (objgs_ResearchResultEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_ResearchResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.UpdUser))
 {
 if (objgs_ResearchResultEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_ResearchResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Memo))
 {
 if (objgs_ResearchResultEN.Memo !=  null)
 {
 var strMemo = objgs_ResearchResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objgs_ResearchResultEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_ResearchResultEN objgs_ResearchResultEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_ResearchResultEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_ResearchResultEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_ResearchResult Set ");
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.TopicId))
 {
 if (objgs_ResearchResultEN.TopicId !=  null)
 {
 var strTopicId = objgs_ResearchResultEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, congs_ResearchResult.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.TopicId); //主题Id
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.PaperId))
 {
 if (objgs_ResearchResultEN.PaperId !=  null)
 {
 var strPaperId = objgs_ResearchResultEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, congs_ResearchResult.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.PaperId); //论文Id
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.ResultTypeId))
 {
 if (objgs_ResearchResultEN.ResultTypeId !=  null)
 {
 var strResultTypeId = objgs_ResearchResultEN.ResultTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResultTypeId, congs_ResearchResult.ResultTypeId); //成果类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.ResultTypeId); //成果类型Id
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.ResultName))
 {
 if (objgs_ResearchResultEN.ResultName !=  null)
 {
 var strResultName = objgs_ResearchResultEN.ResultName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResultName, congs_ResearchResult.ResultName); //成果名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.ResultName); //成果名称
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.ResultContent))
 {
 if (objgs_ResearchResultEN.ResultContent !=  null)
 {
 var strResultContent = objgs_ResearchResultEN.ResultContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResultContent, congs_ResearchResult.ResultContent); //成果内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.ResultContent); //成果内容
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Author))
 {
 if (objgs_ResearchResultEN.Author !=  null)
 {
 var strAuthor = objgs_ResearchResultEN.Author.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAuthor, congs_ResearchResult.Author); //作者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.Author); //作者
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Division))
 {
 if (objgs_ResearchResultEN.Division !=  null)
 {
 var strDivision = objgs_ResearchResultEN.Division.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDivision, congs_ResearchResult.Division); //分工
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.Division); //分工
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.VersionCount))
 {
 if (objgs_ResearchResultEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.VersionCount, congs_ResearchResult.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.VersionCount); //版本统计
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.OkCount))
 {
 if (objgs_ResearchResultEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.OkCount, congs_ResearchResult.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.OkCount); //点赞统计
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.AppraiseCount))
 {
 if (objgs_ResearchResultEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.AppraiseCount, congs_ResearchResult.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.AppraiseCount); //评论数
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Score))
 {
 if (objgs_ResearchResultEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.Score, congs_ResearchResult.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.Score); //评分
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.StuScore))
 {
 if (objgs_ResearchResultEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.StuScore, congs_ResearchResult.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.StuScore); //学生平均分
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.TeaScore))
 {
 if (objgs_ResearchResultEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_ResearchResultEN.TeaScore, congs_ResearchResult.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.TeaScore); //教师评分
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.IdCurrEduCls))
 {
 if (objgs_ResearchResultEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_ResearchResultEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_ResearchResult.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.UpdDate))
 {
 if (objgs_ResearchResultEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_ResearchResultEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_ResearchResult.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.UpdDate); //修改日期
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.UpdUser))
 {
 if (objgs_ResearchResultEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_ResearchResultEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_ResearchResult.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.UpdUser); //修改人
 }
 }
 
 if (objgs_ResearchResultEN.IsUpdated(congs_ResearchResult.Memo))
 {
 if (objgs_ResearchResultEN.Memo !=  null)
 {
 var strMemo = objgs_ResearchResultEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_ResearchResult.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchResult.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ResultId = '{0}'", objgs_ResearchResultEN.ResultId); 
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
 /// <param name = "strResultId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strResultId) 
{
CheckPrimaryKey(strResultId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strResultId,
};
 objSQL.ExecSP("gs_ResearchResult_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strResultId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strResultId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strResultId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
//删除gs_ResearchResult本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_ResearchResult where ResultId = " + "'"+ strResultId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delgs_ResearchResult(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
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
//删除gs_ResearchResult本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_ResearchResult where ResultId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strResultId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strResultId) 
{
CheckPrimaryKey(strResultId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
//删除gs_ResearchResult本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_ResearchResult where ResultId = " + "'"+ strResultId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delgs_ResearchResult(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsgs_ResearchResultDA: Delgs_ResearchResult)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_ResearchResult where " + strCondition ;
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
public bool Delgs_ResearchResultWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsgs_ResearchResultDA: Delgs_ResearchResultWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_ResearchResult where " + strCondition ;
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
 /// <param name = "objgs_ResearchResultENS">源对象</param>
 /// <param name = "objgs_ResearchResultENT">目标对象</param>
public void CopyTo(clsgs_ResearchResultEN objgs_ResearchResultENS, clsgs_ResearchResultEN objgs_ResearchResultENT)
{
objgs_ResearchResultENT.ResultId = objgs_ResearchResultENS.ResultId; //成果Id
objgs_ResearchResultENT.TopicId = objgs_ResearchResultENS.TopicId; //主题Id
objgs_ResearchResultENT.PaperId = objgs_ResearchResultENS.PaperId; //论文Id
objgs_ResearchResultENT.ResultTypeId = objgs_ResearchResultENS.ResultTypeId; //成果类型Id
objgs_ResearchResultENT.ResultName = objgs_ResearchResultENS.ResultName; //成果名称
objgs_ResearchResultENT.ResultContent = objgs_ResearchResultENS.ResultContent; //成果内容
objgs_ResearchResultENT.Author = objgs_ResearchResultENS.Author; //作者
objgs_ResearchResultENT.Division = objgs_ResearchResultENS.Division; //分工
objgs_ResearchResultENT.VersionCount = objgs_ResearchResultENS.VersionCount; //版本统计
objgs_ResearchResultENT.OkCount = objgs_ResearchResultENS.OkCount; //点赞统计
objgs_ResearchResultENT.AppraiseCount = objgs_ResearchResultENS.AppraiseCount; //评论数
objgs_ResearchResultENT.Score = objgs_ResearchResultENS.Score; //评分
objgs_ResearchResultENT.StuScore = objgs_ResearchResultENS.StuScore; //学生平均分
objgs_ResearchResultENT.TeaScore = objgs_ResearchResultENS.TeaScore; //教师评分
objgs_ResearchResultENT.IdCurrEduCls = objgs_ResearchResultENS.IdCurrEduCls; //教学班流水号
objgs_ResearchResultENT.UpdDate = objgs_ResearchResultENS.UpdDate; //修改日期
objgs_ResearchResultENT.UpdUser = objgs_ResearchResultENS.UpdUser; //修改人
objgs_ResearchResultENT.Memo = objgs_ResearchResultENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsgs_ResearchResultEN objgs_ResearchResultEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.ResultId, 10, congs_ResearchResult.ResultId);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.TopicId, 8, congs_ResearchResult.TopicId);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.PaperId, 8, congs_ResearchResult.PaperId);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.ResultTypeId, 2, congs_ResearchResult.ResultTypeId);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.ResultName, 500, congs_ResearchResult.ResultName);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.Author, 200, congs_ResearchResult.Author);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.Division, 500, congs_ResearchResult.Division);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.IdCurrEduCls, 8, congs_ResearchResult.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.UpdDate, 20, congs_ResearchResult.UpdDate);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.UpdUser, 20, congs_ResearchResult.UpdUser);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.Memo, 1000, congs_ResearchResult.Memo);
//检查字段外键固定长度
 objgs_ResearchResultEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsgs_ResearchResultEN objgs_ResearchResultEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.TopicId, 8, congs_ResearchResult.TopicId);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.PaperId, 8, congs_ResearchResult.PaperId);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.ResultTypeId, 2, congs_ResearchResult.ResultTypeId);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.ResultName, 500, congs_ResearchResult.ResultName);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.Author, 200, congs_ResearchResult.Author);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.Division, 500, congs_ResearchResult.Division);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.IdCurrEduCls, 8, congs_ResearchResult.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.UpdDate, 20, congs_ResearchResult.UpdDate);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.UpdUser, 20, congs_ResearchResult.UpdUser);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.Memo, 1000, congs_ResearchResult.Memo);
//检查外键字段长度
 objgs_ResearchResultEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsgs_ResearchResultEN objgs_ResearchResultEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.ResultId, 10, congs_ResearchResult.ResultId);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.TopicId, 8, congs_ResearchResult.TopicId);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.PaperId, 8, congs_ResearchResult.PaperId);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.ResultTypeId, 2, congs_ResearchResult.ResultTypeId);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.ResultName, 500, congs_ResearchResult.ResultName);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.Author, 200, congs_ResearchResult.Author);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.Division, 500, congs_ResearchResult.Division);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.IdCurrEduCls, 8, congs_ResearchResult.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.UpdDate, 20, congs_ResearchResult.UpdDate);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.UpdUser, 20, congs_ResearchResult.UpdUser);
clsCheckSql.CheckFieldLen(objgs_ResearchResultEN.Memo, 1000, congs_ResearchResult.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchResultEN.ResultId, congs_ResearchResult.ResultId);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchResultEN.TopicId, congs_ResearchResult.TopicId);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchResultEN.PaperId, congs_ResearchResult.PaperId);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchResultEN.ResultTypeId, congs_ResearchResult.ResultTypeId);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchResultEN.ResultName, congs_ResearchResult.ResultName);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchResultEN.Author, congs_ResearchResult.Author);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchResultEN.Division, congs_ResearchResult.Division);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchResultEN.IdCurrEduCls, congs_ResearchResult.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchResultEN.UpdDate, congs_ResearchResult.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchResultEN.UpdUser, congs_ResearchResult.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchResultEN.Memo, congs_ResearchResult.Memo);
//检查外键字段长度
 objgs_ResearchResultEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--gs_ResearchResult(研究成果),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsgs_ResearchResultEN objgs_ResearchResultEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objgs_ResearchResultEN.TopicId == null)
{
 sbCondition.AppendFormat(" and TopicId is null");
}
else
{
 sbCondition.AppendFormat(" and TopicId = '{0}'", objgs_ResearchResultEN.TopicId);
}
 if (objgs_ResearchResultEN.ResultTypeId == null)
{
 sbCondition.AppendFormat(" and ResultTypeId is null");
}
else
{
 sbCondition.AppendFormat(" and ResultTypeId = '{0}'", objgs_ResearchResultEN.ResultTypeId);
}
 if (objgs_ResearchResultEN.ResultName == null)
{
 sbCondition.AppendFormat(" and ResultName is null");
}
else
{
 sbCondition.AppendFormat(" and ResultName = '{0}'", objgs_ResearchResultEN.ResultName);
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
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
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
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
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
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_ResearchResultEN._CurrTabName);
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
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_ResearchResultEN._CurrTabName, strCondition);
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
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
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
 objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}