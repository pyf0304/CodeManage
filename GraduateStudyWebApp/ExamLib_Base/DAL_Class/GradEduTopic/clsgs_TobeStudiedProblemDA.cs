
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TobeStudiedProblemDA
 表名:gs_TobeStudiedProblem(01120776)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:38
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
 /// 待研究问题(gs_TobeStudiedProblem)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsgs_TobeStudiedProblemDA : clsCommBase4DA
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
 return clsgs_TobeStudiedProblemEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsgs_TobeStudiedProblemEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_TobeStudiedProblemEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsgs_TobeStudiedProblemEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsgs_TobeStudiedProblemEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strProblemId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strProblemId)
{
strProblemId = strProblemId.Replace("'", "''");
if (strProblemId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:gs_TobeStudiedProblem中,检查关键字,长度不正确!(clsgs_TobeStudiedProblemDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strProblemId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:gs_TobeStudiedProblem中,关键字不能为空 或 null!(clsgs_TobeStudiedProblemDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strProblemId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsgs_TobeStudiedProblemDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblem where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_gs_TobeStudiedProblem(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemDA: GetDataTable_gs_TobeStudiedProblem)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblem where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblem where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_TobeStudiedProblem where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_TobeStudiedProblem where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from gs_TobeStudiedProblem where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_TobeStudiedProblem.* from gs_TobeStudiedProblem Left Join {1} on {2} where {3} and gs_TobeStudiedProblem.ProblemId not in (Select top {5} gs_TobeStudiedProblem.ProblemId from gs_TobeStudiedProblem Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_TobeStudiedProblem where {1} and ProblemId not in (Select top {2} ProblemId from gs_TobeStudiedProblem where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_TobeStudiedProblem where {1} and ProblemId not in (Select top {3} ProblemId from gs_TobeStudiedProblem where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_TobeStudiedProblem.* from gs_TobeStudiedProblem Left Join {1} on {2} where {3} and gs_TobeStudiedProblem.ProblemId not in (Select top {5} gs_TobeStudiedProblem.ProblemId from gs_TobeStudiedProblem Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_TobeStudiedProblem where {1} and ProblemId not in (Select top {2} ProblemId from gs_TobeStudiedProblem where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_TobeStudiedProblem where {1} and ProblemId not in (Select top {3} ProblemId from gs_TobeStudiedProblem where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsgs_TobeStudiedProblemEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemDA:GetObjLst)", objException.Message));
}
List<clsgs_TobeStudiedProblemEN> arrObjLst = new List<clsgs_TobeStudiedProblemEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblem where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
try
{
objgs_TobeStudiedProblemEN.ProblemId = objRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemEN.ProblemTitle = objRow[congs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objgs_TobeStudiedProblemEN.ProblemContent = objRow[congs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemEN.TopicId = objRow[congs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objRow[congs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemEN.ProblemDate = objRow[congs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemEN.UpdDate = objRow[congs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemEN.UpdUser = objRow[congs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemEN.Year = objRow[congs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemEN.Month = objRow[congs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemEN.VersionCount = objRow[congs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objgs_TobeStudiedProblemEN.Participant = objRow[congs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemEN.Memo = objRow[congs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[congs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_TobeStudiedProblemDA: GetObjLst)", objException.Message));
}
objgs_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_TobeStudiedProblemEN);
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
public List<clsgs_TobeStudiedProblemEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemDA:GetObjLstByTabName)", objException.Message));
}
List<clsgs_TobeStudiedProblemEN> arrObjLst = new List<clsgs_TobeStudiedProblemEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
try
{
objgs_TobeStudiedProblemEN.ProblemId = objRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemEN.ProblemTitle = objRow[congs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objgs_TobeStudiedProblemEN.ProblemContent = objRow[congs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemEN.TopicId = objRow[congs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objRow[congs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemEN.ProblemDate = objRow[congs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemEN.UpdDate = objRow[congs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemEN.UpdUser = objRow[congs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemEN.Year = objRow[congs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemEN.Month = objRow[congs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemEN.VersionCount = objRow[congs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objgs_TobeStudiedProblemEN.Participant = objRow[congs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemEN.Memo = objRow[congs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[congs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_TobeStudiedProblemDA: GetObjLst)", objException.Message));
}
objgs_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_TobeStudiedProblemEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getgs_TobeStudiedProblem(ref clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblem where ProblemId = " + "'"+ objgs_TobeStudiedProblemEN.ProblemId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objgs_TobeStudiedProblemEN.ProblemId = objDT.Rows[0][congs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id(字段类型:char,字段长度:10,是否可空:False)
 objgs_TobeStudiedProblemEN.ProblemTitle = objDT.Rows[0][congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_TobeStudiedProblemEN.ProblemContent = objDT.Rows[0][congs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objgs_TobeStudiedProblemEN.TopicId = objDT.Rows[0][congs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objDT.Rows[0][congs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objgs_TobeStudiedProblemEN.ProblemDate = objDT.Rows[0][congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_TobeStudiedProblemEN.UpdDate = objDT.Rows[0][congs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_TobeStudiedProblemEN.UpdUser = objDT.Rows[0][congs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_TobeStudiedProblemEN.Year = objDT.Rows[0][congs_TobeStudiedProblem.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objgs_TobeStudiedProblemEN.Month = objDT.Rows[0][congs_TobeStudiedProblem.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objgs_TobeStudiedProblemEN.VersionCount = TransNullToInt(objDT.Rows[0][congs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objgs_TobeStudiedProblemEN.Participant = objDT.Rows[0][congs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者(字段类型:varchar,字段长度:500,是否可空:True)
 objgs_TobeStudiedProblemEN.Memo = objDT.Rows[0][congs_TobeStudiedProblem.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_TobeStudiedProblemEN.IdCurrEduCls = objDT.Rows[0][congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsgs_TobeStudiedProblemDA: Getgs_TobeStudiedProblem)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strProblemId">表关键字</param>
 /// <returns>表对象</returns>
public clsgs_TobeStudiedProblemEN GetObjByProblemId(string strProblemId)
{
CheckPrimaryKey(strProblemId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblem where ProblemId = " + "'"+ strProblemId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
try
{
 objgs_TobeStudiedProblemEN.ProblemId = objRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id(字段类型:char,字段长度:10,是否可空:False)
 objgs_TobeStudiedProblemEN.ProblemTitle = objRow[congs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_TobeStudiedProblemEN.ProblemContent = objRow[congs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objgs_TobeStudiedProblemEN.TopicId = objRow[congs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objgs_TobeStudiedProblemEN.ProblemDate = objRow[congs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_TobeStudiedProblemEN.UpdDate = objRow[congs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_TobeStudiedProblemEN.UpdUser = objRow[congs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_TobeStudiedProblemEN.Year = objRow[congs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objgs_TobeStudiedProblemEN.Month = objRow[congs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objgs_TobeStudiedProblemEN.VersionCount = objRow[congs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objgs_TobeStudiedProblemEN.Participant = objRow[congs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者(字段类型:varchar,字段长度:500,是否可空:True)
 objgs_TobeStudiedProblemEN.Memo = objRow[congs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[congs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsgs_TobeStudiedProblemDA: GetObjByProblemId)", objException.Message));
}
return objgs_TobeStudiedProblemEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsgs_TobeStudiedProblemEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblem where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN()
{
ProblemId = objRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim(), //问题Id
ProblemTitle = objRow[congs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(), //问题标题
ProblemContent = objRow[congs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemContent].ToString().Trim(), //问题内容
TopicId = objRow[congs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.TopicId].ToString().Trim(), //主题Id
IsSubmit = TransNullToBool(objRow[congs_TobeStudiedProblem.IsSubmit].ToString().Trim()), //是否提交
ProblemDate = objRow[congs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(), //问题日期
UpdDate = objRow[congs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[congs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdUser].ToString().Trim(), //修改人
Year = objRow[congs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Year].ToString().Trim(), //年
Month = objRow[congs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Month].ToString().Trim(), //月
VersionCount = objRow[congs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_TobeStudiedProblem.VersionCount].ToString().Trim()), //版本统计
Participant = objRow[congs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Participant].ToString().Trim(), //参与者
Memo = objRow[congs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Memo].ToString().Trim(), //备注
IdCurrEduCls = objRow[congs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim() //教学班流水号
};
objgs_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_TobeStudiedProblemEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsgs_TobeStudiedProblemDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsgs_TobeStudiedProblemEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
try
{
objgs_TobeStudiedProblemEN.ProblemId = objRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemEN.ProblemTitle = objRow[congs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objgs_TobeStudiedProblemEN.ProblemContent = objRow[congs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemEN.TopicId = objRow[congs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objRow[congs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemEN.ProblemDate = objRow[congs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemEN.UpdDate = objRow[congs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemEN.UpdUser = objRow[congs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemEN.Year = objRow[congs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemEN.Month = objRow[congs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemEN.VersionCount = objRow[congs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objgs_TobeStudiedProblemEN.Participant = objRow[congs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemEN.Memo = objRow[congs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[congs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsgs_TobeStudiedProblemDA: GetObjByDataRowgs_TobeStudiedProblem)", objException.Message));
}
objgs_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_TobeStudiedProblemEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsgs_TobeStudiedProblemEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
try
{
objgs_TobeStudiedProblemEN.ProblemId = objRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemEN.ProblemTitle = objRow[congs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objgs_TobeStudiedProblemEN.ProblemContent = objRow[congs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemEN.TopicId = objRow[congs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objRow[congs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemEN.ProblemDate = objRow[congs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemEN.UpdDate = objRow[congs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemEN.UpdUser = objRow[congs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemEN.Year = objRow[congs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemEN.Month = objRow[congs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemEN.VersionCount = objRow[congs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objgs_TobeStudiedProblemEN.Participant = objRow[congs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemEN.Memo = objRow[congs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[congs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsgs_TobeStudiedProblemDA: GetObjByDataRow)", objException.Message));
}
objgs_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_TobeStudiedProblemEN;
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
objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_TobeStudiedProblemEN._CurrTabName, congs_TobeStudiedProblem.ProblemId, 10, "");
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
objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_TobeStudiedProblemEN._CurrTabName, congs_TobeStudiedProblem.ProblemId, 10, strPrefix);
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
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ProblemId from gs_TobeStudiedProblem where " + strCondition;
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
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ProblemId from gs_TobeStudiedProblem where " + strCondition;
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
 /// <param name = "strProblemId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strProblemId)
{
CheckPrimaryKey(strProblemId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_TobeStudiedProblem", "ProblemId = " + "'"+ strProblemId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_TobeStudiedProblem", strCondition))
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
objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("gs_TobeStudiedProblem");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
 {
 if (objgs_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_TobeStudiedProblemEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblem where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_TobeStudiedProblem");
objRow = objDS.Tables["gs_TobeStudiedProblem"].NewRow();
objRow[congs_TobeStudiedProblem.ProblemId] = objgs_TobeStudiedProblemEN.ProblemId; //问题Id
 if (objgs_TobeStudiedProblemEN.ProblemTitle !=  "")
 {
objRow[congs_TobeStudiedProblem.ProblemTitle] = objgs_TobeStudiedProblemEN.ProblemTitle; //问题标题
 }
 if (objgs_TobeStudiedProblemEN.ProblemContent !=  "")
 {
objRow[congs_TobeStudiedProblem.ProblemContent] = objgs_TobeStudiedProblemEN.ProblemContent; //问题内容
 }
 if (objgs_TobeStudiedProblemEN.TopicId !=  "")
 {
objRow[congs_TobeStudiedProblem.TopicId] = objgs_TobeStudiedProblemEN.TopicId; //主题Id
 }
objRow[congs_TobeStudiedProblem.IsSubmit] = objgs_TobeStudiedProblemEN.IsSubmit; //是否提交
 if (objgs_TobeStudiedProblemEN.ProblemDate !=  "")
 {
objRow[congs_TobeStudiedProblem.ProblemDate] = objgs_TobeStudiedProblemEN.ProblemDate; //问题日期
 }
 if (objgs_TobeStudiedProblemEN.UpdDate !=  "")
 {
objRow[congs_TobeStudiedProblem.UpdDate] = objgs_TobeStudiedProblemEN.UpdDate; //修改日期
 }
 if (objgs_TobeStudiedProblemEN.UpdUser !=  "")
 {
objRow[congs_TobeStudiedProblem.UpdUser] = objgs_TobeStudiedProblemEN.UpdUser; //修改人
 }
 if (objgs_TobeStudiedProblemEN.Year !=  "")
 {
objRow[congs_TobeStudiedProblem.Year] = objgs_TobeStudiedProblemEN.Year; //年
 }
 if (objgs_TobeStudiedProblemEN.Month !=  "")
 {
objRow[congs_TobeStudiedProblem.Month] = objgs_TobeStudiedProblemEN.Month; //月
 }
objRow[congs_TobeStudiedProblem.VersionCount] = objgs_TobeStudiedProblemEN.VersionCount; //版本统计
 if (objgs_TobeStudiedProblemEN.Participant !=  "")
 {
objRow[congs_TobeStudiedProblem.Participant] = objgs_TobeStudiedProblemEN.Participant; //参与者
 }
 if (objgs_TobeStudiedProblemEN.Memo !=  "")
 {
objRow[congs_TobeStudiedProblem.Memo] = objgs_TobeStudiedProblemEN.Memo; //备注
 }
 if (objgs_TobeStudiedProblemEN.IdCurrEduCls !=  "")
 {
objRow[congs_TobeStudiedProblem.IdCurrEduCls] = objgs_TobeStudiedProblemEN.IdCurrEduCls; //教学班流水号
 }
objDS.Tables[clsgs_TobeStudiedProblemEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsgs_TobeStudiedProblemEN._CurrTabName);
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
 /// <param name = "objgs_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
 if (objgs_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_TobeStudiedProblemEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_TobeStudiedProblemEN.ProblemId !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.ProblemId);
 var strProblemId = objgs_TobeStudiedProblemEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemId + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.ProblemTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.ProblemTitle);
 var strProblemTitle = objgs_TobeStudiedProblemEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemTitle + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.ProblemContent !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.ProblemContent);
 var strProblemContent = objgs_TobeStudiedProblemEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemContent + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.TopicId);
 var strTopicId = objgs_TobeStudiedProblemEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_TobeStudiedProblemEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_TobeStudiedProblemEN.ProblemDate !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.ProblemDate);
 var strProblemDate = objgs_TobeStudiedProblemEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemDate + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.UpdDate);
 var strUpdDate = objgs_TobeStudiedProblemEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.UpdUser);
 var strUpdUser = objgs_TobeStudiedProblemEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.Year !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.Year);
 var strYear = objgs_TobeStudiedProblemEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.Month !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.Month);
 var strMonth = objgs_TobeStudiedProblemEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.VersionCount);
 arrValueListForInsert.Add(objgs_TobeStudiedProblemEN.VersionCount.ToString());
 }
 
 if (objgs_TobeStudiedProblemEN.Participant !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.Participant);
 var strParticipant = objgs_TobeStudiedProblemEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipant + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.Memo);
 var strMemo = objgs_TobeStudiedProblemEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.IdCurrEduCls);
 var strIdCurrEduCls = objgs_TobeStudiedProblemEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_TobeStudiedProblem");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
 if (objgs_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_TobeStudiedProblemEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_TobeStudiedProblemEN.ProblemId !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.ProblemId);
 var strProblemId = objgs_TobeStudiedProblemEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemId + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.ProblemTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.ProblemTitle);
 var strProblemTitle = objgs_TobeStudiedProblemEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemTitle + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.ProblemContent !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.ProblemContent);
 var strProblemContent = objgs_TobeStudiedProblemEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemContent + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.TopicId);
 var strTopicId = objgs_TobeStudiedProblemEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_TobeStudiedProblemEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_TobeStudiedProblemEN.ProblemDate !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.ProblemDate);
 var strProblemDate = objgs_TobeStudiedProblemEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemDate + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.UpdDate);
 var strUpdDate = objgs_TobeStudiedProblemEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.UpdUser);
 var strUpdUser = objgs_TobeStudiedProblemEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.Year !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.Year);
 var strYear = objgs_TobeStudiedProblemEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.Month !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.Month);
 var strMonth = objgs_TobeStudiedProblemEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.VersionCount);
 arrValueListForInsert.Add(objgs_TobeStudiedProblemEN.VersionCount.ToString());
 }
 
 if (objgs_TobeStudiedProblemEN.Participant !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.Participant);
 var strParticipant = objgs_TobeStudiedProblemEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipant + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.Memo);
 var strMemo = objgs_TobeStudiedProblemEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.IdCurrEduCls);
 var strIdCurrEduCls = objgs_TobeStudiedProblemEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_TobeStudiedProblem");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objgs_TobeStudiedProblemEN.ProblemId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_TobeStudiedProblemEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_TobeStudiedProblemEN.ProblemId !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.ProblemId);
 var strProblemId = objgs_TobeStudiedProblemEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemId + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.ProblemTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.ProblemTitle);
 var strProblemTitle = objgs_TobeStudiedProblemEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemTitle + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.ProblemContent !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.ProblemContent);
 var strProblemContent = objgs_TobeStudiedProblemEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemContent + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.TopicId);
 var strTopicId = objgs_TobeStudiedProblemEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_TobeStudiedProblemEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_TobeStudiedProblemEN.ProblemDate !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.ProblemDate);
 var strProblemDate = objgs_TobeStudiedProblemEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemDate + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.UpdDate);
 var strUpdDate = objgs_TobeStudiedProblemEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.UpdUser);
 var strUpdUser = objgs_TobeStudiedProblemEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.Year !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.Year);
 var strYear = objgs_TobeStudiedProblemEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.Month !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.Month);
 var strMonth = objgs_TobeStudiedProblemEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.VersionCount);
 arrValueListForInsert.Add(objgs_TobeStudiedProblemEN.VersionCount.ToString());
 }
 
 if (objgs_TobeStudiedProblemEN.Participant !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.Participant);
 var strParticipant = objgs_TobeStudiedProblemEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipant + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.Memo);
 var strMemo = objgs_TobeStudiedProblemEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.IdCurrEduCls);
 var strIdCurrEduCls = objgs_TobeStudiedProblemEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_TobeStudiedProblem");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objgs_TobeStudiedProblemEN.ProblemId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_TobeStudiedProblemEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_TobeStudiedProblemEN.ProblemId !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.ProblemId);
 var strProblemId = objgs_TobeStudiedProblemEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemId + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.ProblemTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.ProblemTitle);
 var strProblemTitle = objgs_TobeStudiedProblemEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemTitle + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.ProblemContent !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.ProblemContent);
 var strProblemContent = objgs_TobeStudiedProblemEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemContent + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.TopicId);
 var strTopicId = objgs_TobeStudiedProblemEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_TobeStudiedProblemEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_TobeStudiedProblemEN.ProblemDate !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.ProblemDate);
 var strProblemDate = objgs_TobeStudiedProblemEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemDate + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.UpdDate);
 var strUpdDate = objgs_TobeStudiedProblemEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.UpdUser);
 var strUpdUser = objgs_TobeStudiedProblemEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.Year !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.Year);
 var strYear = objgs_TobeStudiedProblemEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.Month !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.Month);
 var strMonth = objgs_TobeStudiedProblemEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.VersionCount);
 arrValueListForInsert.Add(objgs_TobeStudiedProblemEN.VersionCount.ToString());
 }
 
 if (objgs_TobeStudiedProblemEN.Participant !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.Participant);
 var strParticipant = objgs_TobeStudiedProblemEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipant + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.Memo);
 var strMemo = objgs_TobeStudiedProblemEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_TobeStudiedProblemEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblem.IdCurrEduCls);
 var strIdCurrEduCls = objgs_TobeStudiedProblemEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_TobeStudiedProblem");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewgs_TobeStudiedProblems(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblem where ProblemId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_TobeStudiedProblem");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strProblemId = oRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim();
if (IsExist(strProblemId))
{
 string strResult = "关键字变量值为:" + string.Format("ProblemId = {0}", strProblemId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsgs_TobeStudiedProblemEN._CurrTabName ].NewRow();
objRow[congs_TobeStudiedProblem.ProblemId] = oRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objRow[congs_TobeStudiedProblem.ProblemTitle] = oRow[congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objRow[congs_TobeStudiedProblem.ProblemContent] = oRow[congs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objRow[congs_TobeStudiedProblem.TopicId] = oRow[congs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objRow[congs_TobeStudiedProblem.IsSubmit] = oRow[congs_TobeStudiedProblem.IsSubmit].ToString().Trim(); //是否提交
objRow[congs_TobeStudiedProblem.ProblemDate] = oRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objRow[congs_TobeStudiedProblem.UpdDate] = oRow[congs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objRow[congs_TobeStudiedProblem.UpdUser] = oRow[congs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objRow[congs_TobeStudiedProblem.Year] = oRow[congs_TobeStudiedProblem.Year].ToString().Trim(); //年
objRow[congs_TobeStudiedProblem.Month] = oRow[congs_TobeStudiedProblem.Month].ToString().Trim(); //月
objRow[congs_TobeStudiedProblem.VersionCount] = oRow[congs_TobeStudiedProblem.VersionCount].ToString().Trim(); //版本统计
objRow[congs_TobeStudiedProblem.Participant] = oRow[congs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objRow[congs_TobeStudiedProblem.Memo] = oRow[congs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objRow[congs_TobeStudiedProblem.IdCurrEduCls] = oRow[congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
 objDS.Tables[clsgs_TobeStudiedProblemEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsgs_TobeStudiedProblemEN._CurrTabName);
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
 /// <param name = "objgs_TobeStudiedProblemEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
 if (objgs_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_TobeStudiedProblemEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblem where ProblemId = " + "'"+ objgs_TobeStudiedProblemEN.ProblemId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsgs_TobeStudiedProblemEN._CurrTabName);
if (objDS.Tables[clsgs_TobeStudiedProblemEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ProblemId = " + "'"+ objgs_TobeStudiedProblemEN.ProblemId+"'");
return false;
}
objRow = objDS.Tables[clsgs_TobeStudiedProblemEN._CurrTabName].Rows[0];
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.ProblemId))
 {
objRow[congs_TobeStudiedProblem.ProblemId] = objgs_TobeStudiedProblemEN.ProblemId; //问题Id
 }
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.ProblemTitle))
 {
objRow[congs_TobeStudiedProblem.ProblemTitle] = objgs_TobeStudiedProblemEN.ProblemTitle; //问题标题
 }
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.ProblemContent))
 {
objRow[congs_TobeStudiedProblem.ProblemContent] = objgs_TobeStudiedProblemEN.ProblemContent; //问题内容
 }
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.TopicId))
 {
objRow[congs_TobeStudiedProblem.TopicId] = objgs_TobeStudiedProblemEN.TopicId; //主题Id
 }
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.IsSubmit))
 {
objRow[congs_TobeStudiedProblem.IsSubmit] = objgs_TobeStudiedProblemEN.IsSubmit; //是否提交
 }
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.ProblemDate))
 {
objRow[congs_TobeStudiedProblem.ProblemDate] = objgs_TobeStudiedProblemEN.ProblemDate; //问题日期
 }
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.UpdDate))
 {
objRow[congs_TobeStudiedProblem.UpdDate] = objgs_TobeStudiedProblemEN.UpdDate; //修改日期
 }
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.UpdUser))
 {
objRow[congs_TobeStudiedProblem.UpdUser] = objgs_TobeStudiedProblemEN.UpdUser; //修改人
 }
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Year))
 {
objRow[congs_TobeStudiedProblem.Year] = objgs_TobeStudiedProblemEN.Year; //年
 }
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Month))
 {
objRow[congs_TobeStudiedProblem.Month] = objgs_TobeStudiedProblemEN.Month; //月
 }
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.VersionCount))
 {
objRow[congs_TobeStudiedProblem.VersionCount] = objgs_TobeStudiedProblemEN.VersionCount; //版本统计
 }
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Participant))
 {
objRow[congs_TobeStudiedProblem.Participant] = objgs_TobeStudiedProblemEN.Participant; //参与者
 }
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Memo))
 {
objRow[congs_TobeStudiedProblem.Memo] = objgs_TobeStudiedProblemEN.Memo; //备注
 }
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.IdCurrEduCls))
 {
objRow[congs_TobeStudiedProblem.IdCurrEduCls] = objgs_TobeStudiedProblemEN.IdCurrEduCls; //教学班流水号
 }
try
{
objDA.Update(objDS, clsgs_TobeStudiedProblemEN._CurrTabName);
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
 /// <param name = "objgs_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
 if (objgs_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_TobeStudiedProblemEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update gs_TobeStudiedProblem Set ");
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.ProblemTitle))
 {
 if (objgs_TobeStudiedProblemEN.ProblemTitle !=  null)
 {
 var strProblemTitle = objgs_TobeStudiedProblemEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemTitle, congs_TobeStudiedProblem.ProblemTitle); //问题标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.ProblemTitle); //问题标题
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.ProblemContent))
 {
 if (objgs_TobeStudiedProblemEN.ProblemContent !=  null)
 {
 var strProblemContent = objgs_TobeStudiedProblemEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemContent, congs_TobeStudiedProblem.ProblemContent); //问题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.ProblemContent); //问题内容
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.TopicId))
 {
 if (objgs_TobeStudiedProblemEN.TopicId !=  null)
 {
 var strTopicId = objgs_TobeStudiedProblemEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, congs_TobeStudiedProblem.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.TopicId); //主题Id
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_TobeStudiedProblemEN.IsSubmit == true?"1":"0", congs_TobeStudiedProblem.IsSubmit); //是否提交
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.ProblemDate))
 {
 if (objgs_TobeStudiedProblemEN.ProblemDate !=  null)
 {
 var strProblemDate = objgs_TobeStudiedProblemEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemDate, congs_TobeStudiedProblem.ProblemDate); //问题日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.ProblemDate); //问题日期
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.UpdDate))
 {
 if (objgs_TobeStudiedProblemEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_TobeStudiedProblemEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_TobeStudiedProblem.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.UpdDate); //修改日期
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.UpdUser))
 {
 if (objgs_TobeStudiedProblemEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_TobeStudiedProblemEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_TobeStudiedProblem.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.UpdUser); //修改人
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Year))
 {
 if (objgs_TobeStudiedProblemEN.Year !=  null)
 {
 var strYear = objgs_TobeStudiedProblemEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYear, congs_TobeStudiedProblem.Year); //年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.Year); //年
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Month))
 {
 if (objgs_TobeStudiedProblemEN.Month !=  null)
 {
 var strMonth = objgs_TobeStudiedProblemEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMonth, congs_TobeStudiedProblem.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.Month); //月
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.VersionCount))
 {
 if (objgs_TobeStudiedProblemEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TobeStudiedProblemEN.VersionCount, congs_TobeStudiedProblem.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.VersionCount); //版本统计
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Participant))
 {
 if (objgs_TobeStudiedProblemEN.Participant !=  null)
 {
 var strParticipant = objgs_TobeStudiedProblemEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParticipant, congs_TobeStudiedProblem.Participant); //参与者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.Participant); //参与者
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Memo))
 {
 if (objgs_TobeStudiedProblemEN.Memo !=  null)
 {
 var strMemo = objgs_TobeStudiedProblemEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_TobeStudiedProblem.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.Memo); //备注
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.IdCurrEduCls))
 {
 if (objgs_TobeStudiedProblemEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_TobeStudiedProblemEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_TobeStudiedProblem.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.IdCurrEduCls); //教学班流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ProblemId = '{0}'", objgs_TobeStudiedProblemEN.ProblemId); 
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
 /// <param name = "objgs_TobeStudiedProblemEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, string strCondition)
{
 if (objgs_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_TobeStudiedProblemEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_TobeStudiedProblem Set ");
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.ProblemTitle))
 {
 if (objgs_TobeStudiedProblemEN.ProblemTitle !=  null)
 {
 var strProblemTitle = objgs_TobeStudiedProblemEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemTitle = '{0}',", strProblemTitle); //问题标题
 }
 else
 {
 sbSQL.Append(" ProblemTitle = null,"); //问题标题
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.ProblemContent))
 {
 if (objgs_TobeStudiedProblemEN.ProblemContent !=  null)
 {
 var strProblemContent = objgs_TobeStudiedProblemEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemContent = '{0}',", strProblemContent); //问题内容
 }
 else
 {
 sbSQL.Append(" ProblemContent = null,"); //问题内容
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.TopicId))
 {
 if (objgs_TobeStudiedProblemEN.TopicId !=  null)
 {
 var strTopicId = objgs_TobeStudiedProblemEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objgs_TobeStudiedProblemEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.ProblemDate))
 {
 if (objgs_TobeStudiedProblemEN.ProblemDate !=  null)
 {
 var strProblemDate = objgs_TobeStudiedProblemEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemDate = '{0}',", strProblemDate); //问题日期
 }
 else
 {
 sbSQL.Append(" ProblemDate = null,"); //问题日期
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.UpdDate))
 {
 if (objgs_TobeStudiedProblemEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_TobeStudiedProblemEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.UpdUser))
 {
 if (objgs_TobeStudiedProblemEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_TobeStudiedProblemEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Year))
 {
 if (objgs_TobeStudiedProblemEN.Year !=  null)
 {
 var strYear = objgs_TobeStudiedProblemEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Year = '{0}',", strYear); //年
 }
 else
 {
 sbSQL.Append(" Year = null,"); //年
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Month))
 {
 if (objgs_TobeStudiedProblemEN.Month !=  null)
 {
 var strMonth = objgs_TobeStudiedProblemEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Month = '{0}',", strMonth); //月
 }
 else
 {
 sbSQL.Append(" Month = null,"); //月
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.VersionCount))
 {
 if (objgs_TobeStudiedProblemEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TobeStudiedProblemEN.VersionCount, congs_TobeStudiedProblem.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.VersionCount); //版本统计
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Participant))
 {
 if (objgs_TobeStudiedProblemEN.Participant !=  null)
 {
 var strParticipant = objgs_TobeStudiedProblemEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Participant = '{0}',", strParticipant); //参与者
 }
 else
 {
 sbSQL.Append(" Participant = null,"); //参与者
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Memo))
 {
 if (objgs_TobeStudiedProblemEN.Memo !=  null)
 {
 var strMemo = objgs_TobeStudiedProblemEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.IdCurrEduCls))
 {
 if (objgs_TobeStudiedProblemEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_TobeStudiedProblemEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
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
 /// <param name = "objgs_TobeStudiedProblemEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_TobeStudiedProblemEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_TobeStudiedProblem Set ");
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.ProblemTitle))
 {
 if (objgs_TobeStudiedProblemEN.ProblemTitle !=  null)
 {
 var strProblemTitle = objgs_TobeStudiedProblemEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemTitle = '{0}',", strProblemTitle); //问题标题
 }
 else
 {
 sbSQL.Append(" ProblemTitle = null,"); //问题标题
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.ProblemContent))
 {
 if (objgs_TobeStudiedProblemEN.ProblemContent !=  null)
 {
 var strProblemContent = objgs_TobeStudiedProblemEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemContent = '{0}',", strProblemContent); //问题内容
 }
 else
 {
 sbSQL.Append(" ProblemContent = null,"); //问题内容
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.TopicId))
 {
 if (objgs_TobeStudiedProblemEN.TopicId !=  null)
 {
 var strTopicId = objgs_TobeStudiedProblemEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objgs_TobeStudiedProblemEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.ProblemDate))
 {
 if (objgs_TobeStudiedProblemEN.ProblemDate !=  null)
 {
 var strProblemDate = objgs_TobeStudiedProblemEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemDate = '{0}',", strProblemDate); //问题日期
 }
 else
 {
 sbSQL.Append(" ProblemDate = null,"); //问题日期
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.UpdDate))
 {
 if (objgs_TobeStudiedProblemEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_TobeStudiedProblemEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.UpdUser))
 {
 if (objgs_TobeStudiedProblemEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_TobeStudiedProblemEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Year))
 {
 if (objgs_TobeStudiedProblemEN.Year !=  null)
 {
 var strYear = objgs_TobeStudiedProblemEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Year = '{0}',", strYear); //年
 }
 else
 {
 sbSQL.Append(" Year = null,"); //年
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Month))
 {
 if (objgs_TobeStudiedProblemEN.Month !=  null)
 {
 var strMonth = objgs_TobeStudiedProblemEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Month = '{0}',", strMonth); //月
 }
 else
 {
 sbSQL.Append(" Month = null,"); //月
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.VersionCount))
 {
 if (objgs_TobeStudiedProblemEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TobeStudiedProblemEN.VersionCount, congs_TobeStudiedProblem.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.VersionCount); //版本统计
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Participant))
 {
 if (objgs_TobeStudiedProblemEN.Participant !=  null)
 {
 var strParticipant = objgs_TobeStudiedProblemEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Participant = '{0}',", strParticipant); //参与者
 }
 else
 {
 sbSQL.Append(" Participant = null,"); //参与者
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Memo))
 {
 if (objgs_TobeStudiedProblemEN.Memo !=  null)
 {
 var strMemo = objgs_TobeStudiedProblemEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.IdCurrEduCls))
 {
 if (objgs_TobeStudiedProblemEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_TobeStudiedProblemEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
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
 /// <param name = "objgs_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_TobeStudiedProblemEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_TobeStudiedProblem Set ");
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.ProblemTitle))
 {
 if (objgs_TobeStudiedProblemEN.ProblemTitle !=  null)
 {
 var strProblemTitle = objgs_TobeStudiedProblemEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemTitle, congs_TobeStudiedProblem.ProblemTitle); //问题标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.ProblemTitle); //问题标题
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.ProblemContent))
 {
 if (objgs_TobeStudiedProblemEN.ProblemContent !=  null)
 {
 var strProblemContent = objgs_TobeStudiedProblemEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemContent, congs_TobeStudiedProblem.ProblemContent); //问题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.ProblemContent); //问题内容
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.TopicId))
 {
 if (objgs_TobeStudiedProblemEN.TopicId !=  null)
 {
 var strTopicId = objgs_TobeStudiedProblemEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, congs_TobeStudiedProblem.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.TopicId); //主题Id
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_TobeStudiedProblemEN.IsSubmit == true?"1":"0", congs_TobeStudiedProblem.IsSubmit); //是否提交
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.ProblemDate))
 {
 if (objgs_TobeStudiedProblemEN.ProblemDate !=  null)
 {
 var strProblemDate = objgs_TobeStudiedProblemEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemDate, congs_TobeStudiedProblem.ProblemDate); //问题日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.ProblemDate); //问题日期
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.UpdDate))
 {
 if (objgs_TobeStudiedProblemEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_TobeStudiedProblemEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_TobeStudiedProblem.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.UpdDate); //修改日期
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.UpdUser))
 {
 if (objgs_TobeStudiedProblemEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_TobeStudiedProblemEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_TobeStudiedProblem.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.UpdUser); //修改人
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Year))
 {
 if (objgs_TobeStudiedProblemEN.Year !=  null)
 {
 var strYear = objgs_TobeStudiedProblemEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYear, congs_TobeStudiedProblem.Year); //年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.Year); //年
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Month))
 {
 if (objgs_TobeStudiedProblemEN.Month !=  null)
 {
 var strMonth = objgs_TobeStudiedProblemEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMonth, congs_TobeStudiedProblem.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.Month); //月
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.VersionCount))
 {
 if (objgs_TobeStudiedProblemEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_TobeStudiedProblemEN.VersionCount, congs_TobeStudiedProblem.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.VersionCount); //版本统计
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Participant))
 {
 if (objgs_TobeStudiedProblemEN.Participant !=  null)
 {
 var strParticipant = objgs_TobeStudiedProblemEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParticipant, congs_TobeStudiedProblem.Participant); //参与者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.Participant); //参与者
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.Memo))
 {
 if (objgs_TobeStudiedProblemEN.Memo !=  null)
 {
 var strMemo = objgs_TobeStudiedProblemEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_TobeStudiedProblem.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.Memo); //备注
 }
 }
 
 if (objgs_TobeStudiedProblemEN.IsUpdated(congs_TobeStudiedProblem.IdCurrEduCls))
 {
 if (objgs_TobeStudiedProblemEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_TobeStudiedProblemEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_TobeStudiedProblem.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblem.IdCurrEduCls); //教学班流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ProblemId = '{0}'", objgs_TobeStudiedProblemEN.ProblemId); 
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
 /// <param name = "strProblemId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strProblemId) 
{
CheckPrimaryKey(strProblemId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strProblemId,
};
 objSQL.ExecSP("gs_TobeStudiedProblem_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strProblemId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strProblemId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strProblemId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
//删除gs_TobeStudiedProblem本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_TobeStudiedProblem where ProblemId = " + "'"+ strProblemId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delgs_TobeStudiedProblem(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
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
//删除gs_TobeStudiedProblem本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_TobeStudiedProblem where ProblemId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strProblemId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strProblemId) 
{
CheckPrimaryKey(strProblemId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
//删除gs_TobeStudiedProblem本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_TobeStudiedProblem where ProblemId = " + "'"+ strProblemId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delgs_TobeStudiedProblem(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemDA: Delgs_TobeStudiedProblem)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_TobeStudiedProblem where " + strCondition ;
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
public bool Delgs_TobeStudiedProblemWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemDA: Delgs_TobeStudiedProblemWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_TobeStudiedProblem where " + strCondition ;
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
 /// <param name = "objgs_TobeStudiedProblemENS">源对象</param>
 /// <param name = "objgs_TobeStudiedProblemENT">目标对象</param>
public void CopyTo(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemENS, clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemENT)
{
objgs_TobeStudiedProblemENT.ProblemId = objgs_TobeStudiedProblemENS.ProblemId; //问题Id
objgs_TobeStudiedProblemENT.ProblemTitle = objgs_TobeStudiedProblemENS.ProblemTitle; //问题标题
objgs_TobeStudiedProblemENT.ProblemContent = objgs_TobeStudiedProblemENS.ProblemContent; //问题内容
objgs_TobeStudiedProblemENT.TopicId = objgs_TobeStudiedProblemENS.TopicId; //主题Id
objgs_TobeStudiedProblemENT.IsSubmit = objgs_TobeStudiedProblemENS.IsSubmit; //是否提交
objgs_TobeStudiedProblemENT.ProblemDate = objgs_TobeStudiedProblemENS.ProblemDate; //问题日期
objgs_TobeStudiedProblemENT.UpdDate = objgs_TobeStudiedProblemENS.UpdDate; //修改日期
objgs_TobeStudiedProblemENT.UpdUser = objgs_TobeStudiedProblemENS.UpdUser; //修改人
objgs_TobeStudiedProblemENT.Year = objgs_TobeStudiedProblemENS.Year; //年
objgs_TobeStudiedProblemENT.Month = objgs_TobeStudiedProblemENS.Month; //月
objgs_TobeStudiedProblemENT.VersionCount = objgs_TobeStudiedProblemENS.VersionCount; //版本统计
objgs_TobeStudiedProblemENT.Participant = objgs_TobeStudiedProblemENS.Participant; //参与者
objgs_TobeStudiedProblemENT.Memo = objgs_TobeStudiedProblemENS.Memo; //备注
objgs_TobeStudiedProblemENT.IdCurrEduCls = objgs_TobeStudiedProblemENS.IdCurrEduCls; //教学班流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.ProblemId, 10, congs_TobeStudiedProblem.ProblemId);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.ProblemTitle, 1000, congs_TobeStudiedProblem.ProblemTitle);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.TopicId, 8, congs_TobeStudiedProblem.TopicId);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.ProblemDate, 20, congs_TobeStudiedProblem.ProblemDate);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.UpdDate, 20, congs_TobeStudiedProblem.UpdDate);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.UpdUser, 20, congs_TobeStudiedProblem.UpdUser);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.Year, 4, congs_TobeStudiedProblem.Year);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.Month, 2, congs_TobeStudiedProblem.Month);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.Participant, 500, congs_TobeStudiedProblem.Participant);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.Memo, 1000, congs_TobeStudiedProblem.Memo);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.IdCurrEduCls, 8, congs_TobeStudiedProblem.IdCurrEduCls);
//检查字段外键固定长度
 objgs_TobeStudiedProblemEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.ProblemTitle, 1000, congs_TobeStudiedProblem.ProblemTitle);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.TopicId, 8, congs_TobeStudiedProblem.TopicId);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.ProblemDate, 20, congs_TobeStudiedProblem.ProblemDate);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.UpdDate, 20, congs_TobeStudiedProblem.UpdDate);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.UpdUser, 20, congs_TobeStudiedProblem.UpdUser);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.Year, 4, congs_TobeStudiedProblem.Year);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.Month, 2, congs_TobeStudiedProblem.Month);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.Participant, 500, congs_TobeStudiedProblem.Participant);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.Memo, 1000, congs_TobeStudiedProblem.Memo);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.IdCurrEduCls, 8, congs_TobeStudiedProblem.IdCurrEduCls);
//检查外键字段长度
 objgs_TobeStudiedProblemEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.ProblemId, 10, congs_TobeStudiedProblem.ProblemId);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.ProblemTitle, 1000, congs_TobeStudiedProblem.ProblemTitle);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.TopicId, 8, congs_TobeStudiedProblem.TopicId);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.ProblemDate, 20, congs_TobeStudiedProblem.ProblemDate);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.UpdDate, 20, congs_TobeStudiedProblem.UpdDate);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.UpdUser, 20, congs_TobeStudiedProblem.UpdUser);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.Year, 4, congs_TobeStudiedProblem.Year);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.Month, 2, congs_TobeStudiedProblem.Month);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.Participant, 500, congs_TobeStudiedProblem.Participant);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.Memo, 1000, congs_TobeStudiedProblem.Memo);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemEN.IdCurrEduCls, 8, congs_TobeStudiedProblem.IdCurrEduCls);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemEN.ProblemId, congs_TobeStudiedProblem.ProblemId);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemEN.ProblemTitle, congs_TobeStudiedProblem.ProblemTitle);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemEN.TopicId, congs_TobeStudiedProblem.TopicId);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemEN.ProblemDate, congs_TobeStudiedProblem.ProblemDate);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemEN.UpdDate, congs_TobeStudiedProblem.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemEN.UpdUser, congs_TobeStudiedProblem.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemEN.Year, congs_TobeStudiedProblem.Year);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemEN.Month, congs_TobeStudiedProblem.Month);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemEN.Participant, congs_TobeStudiedProblem.Participant);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemEN.Memo, congs_TobeStudiedProblem.Memo);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemEN.IdCurrEduCls, congs_TobeStudiedProblem.IdCurrEduCls);
//检查外键字段长度
 objgs_TobeStudiedProblemEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--gs_TobeStudiedProblem(待研究问题),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ProblemId = '{0}'", objgs_TobeStudiedProblemEN.ProblemId);
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
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
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
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
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
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_TobeStudiedProblemEN._CurrTabName);
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
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_TobeStudiedProblemEN._CurrTabName, strCondition);
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
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
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
 objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}