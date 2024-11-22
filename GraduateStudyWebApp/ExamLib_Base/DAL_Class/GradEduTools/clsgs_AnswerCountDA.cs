
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_AnswerCountDA
 表名:gs_AnswerCount(01120767)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 问题讨论回答统计(gs_AnswerCount)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsgs_AnswerCountDA : clsCommBase4DA
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
 return clsgs_AnswerCountEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsgs_AnswerCountEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_AnswerCountEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsgs_AnswerCountEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsgs_AnswerCountEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strAnswerCountId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strAnswerCountId)
{
strAnswerCountId = strAnswerCountId.Replace("'", "''");
if (strAnswerCountId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:gs_AnswerCount中,检查关键字,长度不正确!(clsgs_AnswerCountDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strAnswerCountId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:gs_AnswerCount中,关键字不能为空 或 null!(clsgs_AnswerCountDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAnswerCountId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsgs_AnswerCountDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsgs_AnswerCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from gs_AnswerCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_gs_AnswerCount(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsgs_AnswerCountDA: GetDataTable_gs_AnswerCount)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from gs_AnswerCount where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsgs_AnswerCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsgs_AnswerCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from gs_AnswerCount where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsgs_AnswerCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsgs_AnswerCountDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_AnswerCount where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_AnswerCount where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsgs_AnswerCountDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from gs_AnswerCount where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsgs_AnswerCountDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_AnswerCount.* from gs_AnswerCount Left Join {1} on {2} where {3} and gs_AnswerCount.AnswerCountId not in (Select top {5} gs_AnswerCount.AnswerCountId from gs_AnswerCount Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_AnswerCount where {1} and AnswerCountId not in (Select top {2} AnswerCountId from gs_AnswerCount where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_AnswerCount where {1} and AnswerCountId not in (Select top {3} AnswerCountId from gs_AnswerCount where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsgs_AnswerCountDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_AnswerCount.* from gs_AnswerCount Left Join {1} on {2} where {3} and gs_AnswerCount.AnswerCountId not in (Select top {5} gs_AnswerCount.AnswerCountId from gs_AnswerCount Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_AnswerCount where {1} and AnswerCountId not in (Select top {2} AnswerCountId from gs_AnswerCount where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_AnswerCount where {1} and AnswerCountId not in (Select top {3} AnswerCountId from gs_AnswerCount where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsgs_AnswerCountEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsgs_AnswerCountDA:GetObjLst)", objException.Message));
}
List<clsgs_AnswerCountEN> arrObjLst = new List<clsgs_AnswerCountEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from gs_AnswerCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_AnswerCountEN objgs_AnswerCountEN = new clsgs_AnswerCountEN();
try
{
objgs_AnswerCountEN.Memo = objRow[congs_AnswerCount.Memo] == DBNull.Value ? null : objRow[congs_AnswerCount.Memo].ToString().Trim(); //备注
objgs_AnswerCountEN.AnswerCountId = objRow[congs_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objgs_AnswerCountEN.DataUser = objRow[congs_AnswerCount.DataUser] == DBNull.Value ? null : objRow[congs_AnswerCount.DataUser].ToString().Trim(); //数据用户
objgs_AnswerCountEN.DataAddDate = objRow[congs_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[congs_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objgs_AnswerCountEN.Month = objRow[congs_AnswerCount.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_AnswerCount.Month].ToString().Trim()); //月
objgs_AnswerCountEN.Week = objRow[congs_AnswerCount.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_AnswerCount.Week].ToString().Trim()); //周
objgs_AnswerCountEN.WeekTimeRange = objRow[congs_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objgs_AnswerCountEN.IsRecommend = TransNullToBool(objRow[congs_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objgs_AnswerCountEN.AnswerId = objRow[congs_AnswerCount.AnswerId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerId].ToString().Trim(); //回答Id
objgs_AnswerCountEN.AnswerTypeId = objRow[congs_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objgs_AnswerCountEN.QuestionsId = objRow[congs_AnswerCount.QuestionsId] == DBNull.Value ? null : objRow[congs_AnswerCount.QuestionsId].ToString().Trim(); //提问Id
objgs_AnswerCountEN.TopicId = objRow[congs_AnswerCount.TopicId] == DBNull.Value ? null : objRow[congs_AnswerCount.TopicId].ToString().Trim(); //主题Id
objgs_AnswerCountEN.PaperId = objRow[congs_AnswerCount.PaperId] == DBNull.Value ? null : objRow[congs_AnswerCount.PaperId].ToString().Trim(); //论文Id
objgs_AnswerCountEN.IdCurrEduCls = objRow[congs_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_AnswerCountEN.AnswerContent = objRow[congs_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objgs_AnswerCountEN.Score = objRow[congs_AnswerCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_AnswerCount.Score].ToString().Trim()); //评分
objgs_AnswerCountEN.ScoreType = objRow[congs_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[congs_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objgs_AnswerCountEN.UpdUser = objRow[congs_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdUser].ToString().Trim(); //修改人
objgs_AnswerCountEN.UpdDate = objRow[congs_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objgs_AnswerCountEN.UserName = objRow[congs_AnswerCount.UserName] == DBNull.Value ? null : objRow[congs_AnswerCount.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_AnswerCountDA: GetObjLst)", objException.Message));
}
objgs_AnswerCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_AnswerCountEN);
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
public List<clsgs_AnswerCountEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsgs_AnswerCountDA:GetObjLstByTabName)", objException.Message));
}
List<clsgs_AnswerCountEN> arrObjLst = new List<clsgs_AnswerCountEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_AnswerCountEN objgs_AnswerCountEN = new clsgs_AnswerCountEN();
try
{
objgs_AnswerCountEN.Memo = objRow[congs_AnswerCount.Memo] == DBNull.Value ? null : objRow[congs_AnswerCount.Memo].ToString().Trim(); //备注
objgs_AnswerCountEN.AnswerCountId = objRow[congs_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objgs_AnswerCountEN.DataUser = objRow[congs_AnswerCount.DataUser] == DBNull.Value ? null : objRow[congs_AnswerCount.DataUser].ToString().Trim(); //数据用户
objgs_AnswerCountEN.DataAddDate = objRow[congs_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[congs_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objgs_AnswerCountEN.Month = objRow[congs_AnswerCount.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_AnswerCount.Month].ToString().Trim()); //月
objgs_AnswerCountEN.Week = objRow[congs_AnswerCount.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_AnswerCount.Week].ToString().Trim()); //周
objgs_AnswerCountEN.WeekTimeRange = objRow[congs_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objgs_AnswerCountEN.IsRecommend = TransNullToBool(objRow[congs_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objgs_AnswerCountEN.AnswerId = objRow[congs_AnswerCount.AnswerId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerId].ToString().Trim(); //回答Id
objgs_AnswerCountEN.AnswerTypeId = objRow[congs_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objgs_AnswerCountEN.QuestionsId = objRow[congs_AnswerCount.QuestionsId] == DBNull.Value ? null : objRow[congs_AnswerCount.QuestionsId].ToString().Trim(); //提问Id
objgs_AnswerCountEN.TopicId = objRow[congs_AnswerCount.TopicId] == DBNull.Value ? null : objRow[congs_AnswerCount.TopicId].ToString().Trim(); //主题Id
objgs_AnswerCountEN.PaperId = objRow[congs_AnswerCount.PaperId] == DBNull.Value ? null : objRow[congs_AnswerCount.PaperId].ToString().Trim(); //论文Id
objgs_AnswerCountEN.IdCurrEduCls = objRow[congs_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_AnswerCountEN.AnswerContent = objRow[congs_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objgs_AnswerCountEN.Score = objRow[congs_AnswerCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_AnswerCount.Score].ToString().Trim()); //评分
objgs_AnswerCountEN.ScoreType = objRow[congs_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[congs_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objgs_AnswerCountEN.UpdUser = objRow[congs_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdUser].ToString().Trim(); //修改人
objgs_AnswerCountEN.UpdDate = objRow[congs_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objgs_AnswerCountEN.UserName = objRow[congs_AnswerCount.UserName] == DBNull.Value ? null : objRow[congs_AnswerCount.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_AnswerCountDA: GetObjLst)", objException.Message));
}
objgs_AnswerCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_AnswerCountEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getgs_AnswerCount(ref clsgs_AnswerCountEN objgs_AnswerCountEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from gs_AnswerCount where AnswerCountId = " + "'"+ objgs_AnswerCountEN.AnswerCountId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objgs_AnswerCountEN.Memo = objDT.Rows[0][congs_AnswerCount.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_AnswerCountEN.AnswerCountId = objDT.Rows[0][congs_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId(字段类型:char,字段长度:10,是否可空:False)
 objgs_AnswerCountEN.DataUser = objDT.Rows[0][congs_AnswerCount.DataUser].ToString().Trim(); //数据用户(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_AnswerCountEN.DataAddDate = objDT.Rows[0][congs_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_AnswerCountEN.Month = TransNullToInt(objDT.Rows[0][congs_AnswerCount.Month].ToString().Trim()); //月(字段类型:int,字段长度:4,是否可空:True)
 objgs_AnswerCountEN.Week = TransNullToInt(objDT.Rows[0][congs_AnswerCount.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objgs_AnswerCountEN.WeekTimeRange = objDT.Rows[0][congs_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange(字段类型:varchar,字段长度:100,是否可空:True)
 objgs_AnswerCountEN.IsRecommend = TransNullToBool(objDT.Rows[0][congs_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objgs_AnswerCountEN.AnswerId = objDT.Rows[0][congs_AnswerCount.AnswerId].ToString().Trim(); //回答Id(字段类型:char,字段长度:10,是否可空:False)
 objgs_AnswerCountEN.AnswerTypeId = objDT.Rows[0][congs_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objgs_AnswerCountEN.QuestionsId = objDT.Rows[0][congs_AnswerCount.QuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objgs_AnswerCountEN.TopicId = objDT.Rows[0][congs_AnswerCount.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_AnswerCountEN.PaperId = objDT.Rows[0][congs_AnswerCount.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_AnswerCountEN.IdCurrEduCls = objDT.Rows[0][congs_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objgs_AnswerCountEN.AnswerContent = objDT.Rows[0][congs_AnswerCount.AnswerContent].ToString().Trim(); //答案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objgs_AnswerCountEN.Score = TransNullToFloat(objDT.Rows[0][congs_AnswerCount.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objgs_AnswerCountEN.ScoreType = objDT.Rows[0][congs_AnswerCount.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objgs_AnswerCountEN.UpdUser = objDT.Rows[0][congs_AnswerCount.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_AnswerCountEN.UpdDate = objDT.Rows[0][congs_AnswerCount.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_AnswerCountEN.UserName = objDT.Rows[0][congs_AnswerCount.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsgs_AnswerCountDA: Getgs_AnswerCount)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strAnswerCountId">表关键字</param>
 /// <returns>表对象</returns>
public clsgs_AnswerCountEN GetObjByAnswerCountId(string strAnswerCountId)
{
CheckPrimaryKey(strAnswerCountId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from gs_AnswerCount where AnswerCountId = " + "'"+ strAnswerCountId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsgs_AnswerCountEN objgs_AnswerCountEN = new clsgs_AnswerCountEN();
try
{
 objgs_AnswerCountEN.Memo = objRow[congs_AnswerCount.Memo] == DBNull.Value ? null : objRow[congs_AnswerCount.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_AnswerCountEN.AnswerCountId = objRow[congs_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId(字段类型:char,字段长度:10,是否可空:False)
 objgs_AnswerCountEN.DataUser = objRow[congs_AnswerCount.DataUser] == DBNull.Value ? null : objRow[congs_AnswerCount.DataUser].ToString().Trim(); //数据用户(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_AnswerCountEN.DataAddDate = objRow[congs_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[congs_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_AnswerCountEN.Month = objRow[congs_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Month].ToString().Trim()); //月(字段类型:int,字段长度:4,是否可空:True)
 objgs_AnswerCountEN.Week = objRow[congs_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objgs_AnswerCountEN.WeekTimeRange = objRow[congs_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange(字段类型:varchar,字段长度:100,是否可空:True)
 objgs_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objgs_AnswerCountEN.AnswerId = objRow[congs_AnswerCount.AnswerId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerId].ToString().Trim(); //回答Id(字段类型:char,字段长度:10,是否可空:False)
 objgs_AnswerCountEN.AnswerTypeId = objRow[congs_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objgs_AnswerCountEN.QuestionsId = objRow[congs_AnswerCount.QuestionsId] == DBNull.Value ? null : objRow[congs_AnswerCount.QuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objgs_AnswerCountEN.TopicId = objRow[congs_AnswerCount.TopicId] == DBNull.Value ? null : objRow[congs_AnswerCount.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_AnswerCountEN.PaperId = objRow[congs_AnswerCount.PaperId] == DBNull.Value ? null : objRow[congs_AnswerCount.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_AnswerCountEN.IdCurrEduCls = objRow[congs_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objgs_AnswerCountEN.AnswerContent = objRow[congs_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerContent].ToString().Trim(); //答案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objgs_AnswerCountEN.Score = objRow[congs_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_AnswerCount.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objgs_AnswerCountEN.ScoreType = objRow[congs_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[congs_AnswerCount.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objgs_AnswerCountEN.UpdUser = objRow[congs_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_AnswerCountEN.UpdDate = objRow[congs_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_AnswerCountEN.UserName = objRow[congs_AnswerCount.UserName] == DBNull.Value ? null : objRow[congs_AnswerCount.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsgs_AnswerCountDA: GetObjByAnswerCountId)", objException.Message));
}
return objgs_AnswerCountEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsgs_AnswerCountEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsgs_AnswerCountDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from gs_AnswerCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsgs_AnswerCountEN objgs_AnswerCountEN = new clsgs_AnswerCountEN()
{
Memo = objRow[congs_AnswerCount.Memo] == DBNull.Value ? null : objRow[congs_AnswerCount.Memo].ToString().Trim(), //备注
AnswerCountId = objRow[congs_AnswerCount.AnswerCountId].ToString().Trim(), //AnswerCountId
DataUser = objRow[congs_AnswerCount.DataUser] == DBNull.Value ? null : objRow[congs_AnswerCount.DataUser].ToString().Trim(), //数据用户
DataAddDate = objRow[congs_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[congs_AnswerCount.DataAddDate].ToString().Trim(), //数据添加日期
Month = objRow[congs_AnswerCount.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_AnswerCount.Month].ToString().Trim()), //月
Week = objRow[congs_AnswerCount.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_AnswerCount.Week].ToString().Trim()), //周
WeekTimeRange = objRow[congs_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(), //WeekTimeRange
IsRecommend = TransNullToBool(objRow[congs_AnswerCount.IsRecommend].ToString().Trim()), //是否推荐
AnswerId = objRow[congs_AnswerCount.AnswerId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerId].ToString().Trim(), //回答Id
AnswerTypeId = objRow[congs_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerTypeId].ToString().Trim(), //答案类型ID
QuestionsId = objRow[congs_AnswerCount.QuestionsId] == DBNull.Value ? null : objRow[congs_AnswerCount.QuestionsId].ToString().Trim(), //提问Id
TopicId = objRow[congs_AnswerCount.TopicId] == DBNull.Value ? null : objRow[congs_AnswerCount.TopicId].ToString().Trim(), //主题Id
PaperId = objRow[congs_AnswerCount.PaperId] == DBNull.Value ? null : objRow[congs_AnswerCount.PaperId].ToString().Trim(), //论文Id
IdCurrEduCls = objRow[congs_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_AnswerCount.IdCurrEduCls].ToString().Trim(), //教学班流水号
AnswerContent = objRow[congs_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerContent].ToString().Trim(), //答案内容
Score = objRow[congs_AnswerCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_AnswerCount.Score].ToString().Trim()), //评分
ScoreType = objRow[congs_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[congs_AnswerCount.ScoreType].ToString().Trim(), //评分类型
UpdUser = objRow[congs_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[congs_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdDate].ToString().Trim(), //修改日期
UserName = objRow[congs_AnswerCount.UserName] == DBNull.Value ? null : objRow[congs_AnswerCount.UserName].ToString().Trim() //用户名
};
objgs_AnswerCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_AnswerCountEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsgs_AnswerCountDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsgs_AnswerCountEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_AnswerCountEN objgs_AnswerCountEN = new clsgs_AnswerCountEN();
try
{
objgs_AnswerCountEN.Memo = objRow[congs_AnswerCount.Memo] == DBNull.Value ? null : objRow[congs_AnswerCount.Memo].ToString().Trim(); //备注
objgs_AnswerCountEN.AnswerCountId = objRow[congs_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objgs_AnswerCountEN.DataUser = objRow[congs_AnswerCount.DataUser] == DBNull.Value ? null : objRow[congs_AnswerCount.DataUser].ToString().Trim(); //数据用户
objgs_AnswerCountEN.DataAddDate = objRow[congs_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[congs_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objgs_AnswerCountEN.Month = objRow[congs_AnswerCount.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_AnswerCount.Month].ToString().Trim()); //月
objgs_AnswerCountEN.Week = objRow[congs_AnswerCount.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_AnswerCount.Week].ToString().Trim()); //周
objgs_AnswerCountEN.WeekTimeRange = objRow[congs_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objgs_AnswerCountEN.IsRecommend = TransNullToBool(objRow[congs_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objgs_AnswerCountEN.AnswerId = objRow[congs_AnswerCount.AnswerId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerId].ToString().Trim(); //回答Id
objgs_AnswerCountEN.AnswerTypeId = objRow[congs_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objgs_AnswerCountEN.QuestionsId = objRow[congs_AnswerCount.QuestionsId] == DBNull.Value ? null : objRow[congs_AnswerCount.QuestionsId].ToString().Trim(); //提问Id
objgs_AnswerCountEN.TopicId = objRow[congs_AnswerCount.TopicId] == DBNull.Value ? null : objRow[congs_AnswerCount.TopicId].ToString().Trim(); //主题Id
objgs_AnswerCountEN.PaperId = objRow[congs_AnswerCount.PaperId] == DBNull.Value ? null : objRow[congs_AnswerCount.PaperId].ToString().Trim(); //论文Id
objgs_AnswerCountEN.IdCurrEduCls = objRow[congs_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_AnswerCountEN.AnswerContent = objRow[congs_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objgs_AnswerCountEN.Score = objRow[congs_AnswerCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_AnswerCount.Score].ToString().Trim()); //评分
objgs_AnswerCountEN.ScoreType = objRow[congs_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[congs_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objgs_AnswerCountEN.UpdUser = objRow[congs_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdUser].ToString().Trim(); //修改人
objgs_AnswerCountEN.UpdDate = objRow[congs_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objgs_AnswerCountEN.UserName = objRow[congs_AnswerCount.UserName] == DBNull.Value ? null : objRow[congs_AnswerCount.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsgs_AnswerCountDA: GetObjByDataRowgs_AnswerCount)", objException.Message));
}
objgs_AnswerCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_AnswerCountEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsgs_AnswerCountEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_AnswerCountEN objgs_AnswerCountEN = new clsgs_AnswerCountEN();
try
{
objgs_AnswerCountEN.Memo = objRow[congs_AnswerCount.Memo] == DBNull.Value ? null : objRow[congs_AnswerCount.Memo].ToString().Trim(); //备注
objgs_AnswerCountEN.AnswerCountId = objRow[congs_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objgs_AnswerCountEN.DataUser = objRow[congs_AnswerCount.DataUser] == DBNull.Value ? null : objRow[congs_AnswerCount.DataUser].ToString().Trim(); //数据用户
objgs_AnswerCountEN.DataAddDate = objRow[congs_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[congs_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objgs_AnswerCountEN.Month = objRow[congs_AnswerCount.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_AnswerCount.Month].ToString().Trim()); //月
objgs_AnswerCountEN.Week = objRow[congs_AnswerCount.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[congs_AnswerCount.Week].ToString().Trim()); //周
objgs_AnswerCountEN.WeekTimeRange = objRow[congs_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objgs_AnswerCountEN.IsRecommend = TransNullToBool(objRow[congs_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objgs_AnswerCountEN.AnswerId = objRow[congs_AnswerCount.AnswerId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerId].ToString().Trim(); //回答Id
objgs_AnswerCountEN.AnswerTypeId = objRow[congs_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objgs_AnswerCountEN.QuestionsId = objRow[congs_AnswerCount.QuestionsId] == DBNull.Value ? null : objRow[congs_AnswerCount.QuestionsId].ToString().Trim(); //提问Id
objgs_AnswerCountEN.TopicId = objRow[congs_AnswerCount.TopicId] == DBNull.Value ? null : objRow[congs_AnswerCount.TopicId].ToString().Trim(); //主题Id
objgs_AnswerCountEN.PaperId = objRow[congs_AnswerCount.PaperId] == DBNull.Value ? null : objRow[congs_AnswerCount.PaperId].ToString().Trim(); //论文Id
objgs_AnswerCountEN.IdCurrEduCls = objRow[congs_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_AnswerCountEN.AnswerContent = objRow[congs_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objgs_AnswerCountEN.Score = objRow[congs_AnswerCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_AnswerCount.Score].ToString().Trim()); //评分
objgs_AnswerCountEN.ScoreType = objRow[congs_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[congs_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objgs_AnswerCountEN.UpdUser = objRow[congs_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdUser].ToString().Trim(); //修改人
objgs_AnswerCountEN.UpdDate = objRow[congs_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objgs_AnswerCountEN.UserName = objRow[congs_AnswerCount.UserName] == DBNull.Value ? null : objRow[congs_AnswerCount.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsgs_AnswerCountDA: GetObjByDataRow)", objException.Message));
}
objgs_AnswerCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_AnswerCountEN;
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
objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_AnswerCountEN._CurrTabName, congs_AnswerCount.AnswerCountId, 10, "");
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
objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_AnswerCountEN._CurrTabName, congs_AnswerCount.AnswerCountId, 10, strPrefix);
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
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select AnswerCountId from gs_AnswerCount where " + strCondition;
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
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select AnswerCountId from gs_AnswerCount where " + strCondition;
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
 /// <param name = "strAnswerCountId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strAnswerCountId)
{
CheckPrimaryKey(strAnswerCountId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_AnswerCount", "AnswerCountId = " + "'"+ strAnswerCountId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsgs_AnswerCountDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_AnswerCount", strCondition))
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
objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("gs_AnswerCount");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsgs_AnswerCountEN objgs_AnswerCountEN)
 {
 if (objgs_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_AnswerCountEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from gs_AnswerCount where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_AnswerCount");
objRow = objDS.Tables["gs_AnswerCount"].NewRow();
 if (objgs_AnswerCountEN.Memo !=  "")
 {
objRow[congs_AnswerCount.Memo] = objgs_AnswerCountEN.Memo; //备注
 }
objRow[congs_AnswerCount.AnswerCountId] = objgs_AnswerCountEN.AnswerCountId; //AnswerCountId
 if (objgs_AnswerCountEN.DataUser !=  "")
 {
objRow[congs_AnswerCount.DataUser] = objgs_AnswerCountEN.DataUser; //数据用户
 }
 if (objgs_AnswerCountEN.DataAddDate !=  "")
 {
objRow[congs_AnswerCount.DataAddDate] = objgs_AnswerCountEN.DataAddDate; //数据添加日期
 }
objRow[congs_AnswerCount.Month] = objgs_AnswerCountEN.Month; //月
objRow[congs_AnswerCount.Week] = objgs_AnswerCountEN.Week; //周
 if (objgs_AnswerCountEN.WeekTimeRange !=  "")
 {
objRow[congs_AnswerCount.WeekTimeRange] = objgs_AnswerCountEN.WeekTimeRange; //WeekTimeRange
 }
objRow[congs_AnswerCount.IsRecommend] = objgs_AnswerCountEN.IsRecommend; //是否推荐
 if (objgs_AnswerCountEN.AnswerId !=  "")
 {
objRow[congs_AnswerCount.AnswerId] = objgs_AnswerCountEN.AnswerId; //回答Id
 }
 if (objgs_AnswerCountEN.AnswerTypeId !=  "")
 {
objRow[congs_AnswerCount.AnswerTypeId] = objgs_AnswerCountEN.AnswerTypeId; //答案类型ID
 }
 if (objgs_AnswerCountEN.QuestionsId !=  "")
 {
objRow[congs_AnswerCount.QuestionsId] = objgs_AnswerCountEN.QuestionsId; //提问Id
 }
 if (objgs_AnswerCountEN.TopicId !=  "")
 {
objRow[congs_AnswerCount.TopicId] = objgs_AnswerCountEN.TopicId; //主题Id
 }
 if (objgs_AnswerCountEN.PaperId !=  "")
 {
objRow[congs_AnswerCount.PaperId] = objgs_AnswerCountEN.PaperId; //论文Id
 }
 if (objgs_AnswerCountEN.IdCurrEduCls !=  "")
 {
objRow[congs_AnswerCount.IdCurrEduCls] = objgs_AnswerCountEN.IdCurrEduCls; //教学班流水号
 }
 if (objgs_AnswerCountEN.AnswerContent !=  "")
 {
objRow[congs_AnswerCount.AnswerContent] = objgs_AnswerCountEN.AnswerContent; //答案内容
 }
objRow[congs_AnswerCount.Score] = objgs_AnswerCountEN.Score; //评分
 if (objgs_AnswerCountEN.ScoreType !=  "")
 {
objRow[congs_AnswerCount.ScoreType] = objgs_AnswerCountEN.ScoreType; //评分类型
 }
 if (objgs_AnswerCountEN.UpdUser !=  "")
 {
objRow[congs_AnswerCount.UpdUser] = objgs_AnswerCountEN.UpdUser; //修改人
 }
 if (objgs_AnswerCountEN.UpdDate !=  "")
 {
objRow[congs_AnswerCount.UpdDate] = objgs_AnswerCountEN.UpdDate; //修改日期
 }
 if (objgs_AnswerCountEN.UserName !=  "")
 {
objRow[congs_AnswerCount.UserName] = objgs_AnswerCountEN.UserName; //用户名
 }
objDS.Tables[clsgs_AnswerCountEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsgs_AnswerCountEN._CurrTabName);
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
 /// <param name = "objgs_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_AnswerCountEN objgs_AnswerCountEN)
{
 if (objgs_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_AnswerCountEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_AnswerCountEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.Memo);
 var strMemo = objgs_AnswerCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_AnswerCountEN.AnswerCountId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.AnswerCountId);
 var strAnswerCountId = objgs_AnswerCountEN.AnswerCountId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerCountId + "'");
 }
 
 if (objgs_AnswerCountEN.DataUser !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.DataUser);
 var strDataUser = objgs_AnswerCountEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataUser + "'");
 }
 
 if (objgs_AnswerCountEN.DataAddDate !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.DataAddDate);
 var strDataAddDate = objgs_AnswerCountEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataAddDate + "'");
 }
 
 if (objgs_AnswerCountEN.Month !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.Month);
 arrValueListForInsert.Add(objgs_AnswerCountEN.Month.ToString());
 }
 
 if (objgs_AnswerCountEN.Week !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.Week);
 arrValueListForInsert.Add(objgs_AnswerCountEN.Week.ToString());
 }
 
 if (objgs_AnswerCountEN.WeekTimeRange !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.WeekTimeRange);
 var strWeekTimeRange = objgs_AnswerCountEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekTimeRange + "'");
 }
 
 arrFieldListForInsert.Add(congs_AnswerCount.IsRecommend);
 arrValueListForInsert.Add("'" + (objgs_AnswerCountEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objgs_AnswerCountEN.AnswerId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.AnswerId);
 var strAnswerId = objgs_AnswerCountEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerId + "'");
 }
 
 if (objgs_AnswerCountEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.AnswerTypeId);
 var strAnswerTypeId = objgs_AnswerCountEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objgs_AnswerCountEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.QuestionsId);
 var strQuestionsId = objgs_AnswerCountEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objgs_AnswerCountEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.TopicId);
 var strTopicId = objgs_AnswerCountEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objgs_AnswerCountEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.PaperId);
 var strPaperId = objgs_AnswerCountEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_AnswerCountEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.IdCurrEduCls);
 var strIdCurrEduCls = objgs_AnswerCountEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_AnswerCountEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.AnswerContent);
 var strAnswerContent = objgs_AnswerCountEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objgs_AnswerCountEN.Score !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.Score);
 arrValueListForInsert.Add(objgs_AnswerCountEN.Score.ToString());
 }
 
 if (objgs_AnswerCountEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.ScoreType);
 var strScoreType = objgs_AnswerCountEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 if (objgs_AnswerCountEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.UpdUser);
 var strUpdUser = objgs_AnswerCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_AnswerCountEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.UpdDate);
 var strUpdDate = objgs_AnswerCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_AnswerCountEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.UserName);
 var strUserName = objgs_AnswerCountEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_AnswerCount");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_AnswerCountEN objgs_AnswerCountEN)
{
 if (objgs_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_AnswerCountEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_AnswerCountEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.Memo);
 var strMemo = objgs_AnswerCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_AnswerCountEN.AnswerCountId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.AnswerCountId);
 var strAnswerCountId = objgs_AnswerCountEN.AnswerCountId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerCountId + "'");
 }
 
 if (objgs_AnswerCountEN.DataUser !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.DataUser);
 var strDataUser = objgs_AnswerCountEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataUser + "'");
 }
 
 if (objgs_AnswerCountEN.DataAddDate !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.DataAddDate);
 var strDataAddDate = objgs_AnswerCountEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataAddDate + "'");
 }
 
 if (objgs_AnswerCountEN.Month !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.Month);
 arrValueListForInsert.Add(objgs_AnswerCountEN.Month.ToString());
 }
 
 if (objgs_AnswerCountEN.Week !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.Week);
 arrValueListForInsert.Add(objgs_AnswerCountEN.Week.ToString());
 }
 
 if (objgs_AnswerCountEN.WeekTimeRange !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.WeekTimeRange);
 var strWeekTimeRange = objgs_AnswerCountEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekTimeRange + "'");
 }
 
 arrFieldListForInsert.Add(congs_AnswerCount.IsRecommend);
 arrValueListForInsert.Add("'" + (objgs_AnswerCountEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objgs_AnswerCountEN.AnswerId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.AnswerId);
 var strAnswerId = objgs_AnswerCountEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerId + "'");
 }
 
 if (objgs_AnswerCountEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.AnswerTypeId);
 var strAnswerTypeId = objgs_AnswerCountEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objgs_AnswerCountEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.QuestionsId);
 var strQuestionsId = objgs_AnswerCountEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objgs_AnswerCountEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.TopicId);
 var strTopicId = objgs_AnswerCountEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objgs_AnswerCountEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.PaperId);
 var strPaperId = objgs_AnswerCountEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_AnswerCountEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.IdCurrEduCls);
 var strIdCurrEduCls = objgs_AnswerCountEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_AnswerCountEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.AnswerContent);
 var strAnswerContent = objgs_AnswerCountEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objgs_AnswerCountEN.Score !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.Score);
 arrValueListForInsert.Add(objgs_AnswerCountEN.Score.ToString());
 }
 
 if (objgs_AnswerCountEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.ScoreType);
 var strScoreType = objgs_AnswerCountEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 if (objgs_AnswerCountEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.UpdUser);
 var strUpdUser = objgs_AnswerCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_AnswerCountEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.UpdDate);
 var strUpdDate = objgs_AnswerCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_AnswerCountEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.UserName);
 var strUserName = objgs_AnswerCountEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_AnswerCount");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objgs_AnswerCountEN.AnswerCountId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_AnswerCountEN objgs_AnswerCountEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_AnswerCountEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_AnswerCountEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.Memo);
 var strMemo = objgs_AnswerCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_AnswerCountEN.AnswerCountId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.AnswerCountId);
 var strAnswerCountId = objgs_AnswerCountEN.AnswerCountId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerCountId + "'");
 }
 
 if (objgs_AnswerCountEN.DataUser !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.DataUser);
 var strDataUser = objgs_AnswerCountEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataUser + "'");
 }
 
 if (objgs_AnswerCountEN.DataAddDate !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.DataAddDate);
 var strDataAddDate = objgs_AnswerCountEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataAddDate + "'");
 }
 
 if (objgs_AnswerCountEN.Month !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.Month);
 arrValueListForInsert.Add(objgs_AnswerCountEN.Month.ToString());
 }
 
 if (objgs_AnswerCountEN.Week !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.Week);
 arrValueListForInsert.Add(objgs_AnswerCountEN.Week.ToString());
 }
 
 if (objgs_AnswerCountEN.WeekTimeRange !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.WeekTimeRange);
 var strWeekTimeRange = objgs_AnswerCountEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekTimeRange + "'");
 }
 
 arrFieldListForInsert.Add(congs_AnswerCount.IsRecommend);
 arrValueListForInsert.Add("'" + (objgs_AnswerCountEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objgs_AnswerCountEN.AnswerId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.AnswerId);
 var strAnswerId = objgs_AnswerCountEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerId + "'");
 }
 
 if (objgs_AnswerCountEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.AnswerTypeId);
 var strAnswerTypeId = objgs_AnswerCountEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objgs_AnswerCountEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.QuestionsId);
 var strQuestionsId = objgs_AnswerCountEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objgs_AnswerCountEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.TopicId);
 var strTopicId = objgs_AnswerCountEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objgs_AnswerCountEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.PaperId);
 var strPaperId = objgs_AnswerCountEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_AnswerCountEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.IdCurrEduCls);
 var strIdCurrEduCls = objgs_AnswerCountEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_AnswerCountEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.AnswerContent);
 var strAnswerContent = objgs_AnswerCountEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objgs_AnswerCountEN.Score !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.Score);
 arrValueListForInsert.Add(objgs_AnswerCountEN.Score.ToString());
 }
 
 if (objgs_AnswerCountEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.ScoreType);
 var strScoreType = objgs_AnswerCountEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 if (objgs_AnswerCountEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.UpdUser);
 var strUpdUser = objgs_AnswerCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_AnswerCountEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.UpdDate);
 var strUpdDate = objgs_AnswerCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_AnswerCountEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.UserName);
 var strUserName = objgs_AnswerCountEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_AnswerCount");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objgs_AnswerCountEN.AnswerCountId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_AnswerCountEN objgs_AnswerCountEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_AnswerCountEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_AnswerCountEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.Memo);
 var strMemo = objgs_AnswerCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_AnswerCountEN.AnswerCountId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.AnswerCountId);
 var strAnswerCountId = objgs_AnswerCountEN.AnswerCountId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerCountId + "'");
 }
 
 if (objgs_AnswerCountEN.DataUser !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.DataUser);
 var strDataUser = objgs_AnswerCountEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataUser + "'");
 }
 
 if (objgs_AnswerCountEN.DataAddDate !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.DataAddDate);
 var strDataAddDate = objgs_AnswerCountEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataAddDate + "'");
 }
 
 if (objgs_AnswerCountEN.Month !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.Month);
 arrValueListForInsert.Add(objgs_AnswerCountEN.Month.ToString());
 }
 
 if (objgs_AnswerCountEN.Week !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.Week);
 arrValueListForInsert.Add(objgs_AnswerCountEN.Week.ToString());
 }
 
 if (objgs_AnswerCountEN.WeekTimeRange !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.WeekTimeRange);
 var strWeekTimeRange = objgs_AnswerCountEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekTimeRange + "'");
 }
 
 arrFieldListForInsert.Add(congs_AnswerCount.IsRecommend);
 arrValueListForInsert.Add("'" + (objgs_AnswerCountEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objgs_AnswerCountEN.AnswerId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.AnswerId);
 var strAnswerId = objgs_AnswerCountEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerId + "'");
 }
 
 if (objgs_AnswerCountEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.AnswerTypeId);
 var strAnswerTypeId = objgs_AnswerCountEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objgs_AnswerCountEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.QuestionsId);
 var strQuestionsId = objgs_AnswerCountEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objgs_AnswerCountEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.TopicId);
 var strTopicId = objgs_AnswerCountEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objgs_AnswerCountEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.PaperId);
 var strPaperId = objgs_AnswerCountEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_AnswerCountEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.IdCurrEduCls);
 var strIdCurrEduCls = objgs_AnswerCountEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_AnswerCountEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.AnswerContent);
 var strAnswerContent = objgs_AnswerCountEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objgs_AnswerCountEN.Score !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.Score);
 arrValueListForInsert.Add(objgs_AnswerCountEN.Score.ToString());
 }
 
 if (objgs_AnswerCountEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.ScoreType);
 var strScoreType = objgs_AnswerCountEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 if (objgs_AnswerCountEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.UpdUser);
 var strUpdUser = objgs_AnswerCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_AnswerCountEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.UpdDate);
 var strUpdDate = objgs_AnswerCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_AnswerCountEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(congs_AnswerCount.UserName);
 var strUserName = objgs_AnswerCountEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_AnswerCount");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewgs_AnswerCounts(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from gs_AnswerCount where AnswerCountId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_AnswerCount");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strAnswerCountId = oRow[congs_AnswerCount.AnswerCountId].ToString().Trim();
if (IsExist(strAnswerCountId))
{
 string strResult = "关键字变量值为:" + string.Format("AnswerCountId = {0}", strAnswerCountId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsgs_AnswerCountEN._CurrTabName ].NewRow();
objRow[congs_AnswerCount.Memo] = oRow[congs_AnswerCount.Memo].ToString().Trim(); //备注
objRow[congs_AnswerCount.AnswerCountId] = oRow[congs_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objRow[congs_AnswerCount.DataUser] = oRow[congs_AnswerCount.DataUser].ToString().Trim(); //数据用户
objRow[congs_AnswerCount.DataAddDate] = oRow[congs_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objRow[congs_AnswerCount.Month] = oRow[congs_AnswerCount.Month].ToString().Trim(); //月
objRow[congs_AnswerCount.Week] = oRow[congs_AnswerCount.Week].ToString().Trim(); //周
objRow[congs_AnswerCount.WeekTimeRange] = oRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objRow[congs_AnswerCount.IsRecommend] = oRow[congs_AnswerCount.IsRecommend].ToString().Trim(); //是否推荐
objRow[congs_AnswerCount.AnswerId] = oRow[congs_AnswerCount.AnswerId].ToString().Trim(); //回答Id
objRow[congs_AnswerCount.AnswerTypeId] = oRow[congs_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objRow[congs_AnswerCount.QuestionsId] = oRow[congs_AnswerCount.QuestionsId].ToString().Trim(); //提问Id
objRow[congs_AnswerCount.TopicId] = oRow[congs_AnswerCount.TopicId].ToString().Trim(); //主题Id
objRow[congs_AnswerCount.PaperId] = oRow[congs_AnswerCount.PaperId].ToString().Trim(); //论文Id
objRow[congs_AnswerCount.IdCurrEduCls] = oRow[congs_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[congs_AnswerCount.AnswerContent] = oRow[congs_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objRow[congs_AnswerCount.Score] = oRow[congs_AnswerCount.Score].ToString().Trim(); //评分
objRow[congs_AnswerCount.ScoreType] = oRow[congs_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objRow[congs_AnswerCount.UpdUser] = oRow[congs_AnswerCount.UpdUser].ToString().Trim(); //修改人
objRow[congs_AnswerCount.UpdDate] = oRow[congs_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objRow[congs_AnswerCount.UserName] = oRow[congs_AnswerCount.UserName].ToString().Trim(); //用户名
 objDS.Tables[clsgs_AnswerCountEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsgs_AnswerCountEN._CurrTabName);
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
 /// <param name = "objgs_AnswerCountEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsgs_AnswerCountEN objgs_AnswerCountEN)
{
 if (objgs_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_AnswerCountEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
strSQL = "Select * from gs_AnswerCount where AnswerCountId = " + "'"+ objgs_AnswerCountEN.AnswerCountId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsgs_AnswerCountEN._CurrTabName);
if (objDS.Tables[clsgs_AnswerCountEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:AnswerCountId = " + "'"+ objgs_AnswerCountEN.AnswerCountId+"'");
return false;
}
objRow = objDS.Tables[clsgs_AnswerCountEN._CurrTabName].Rows[0];
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Memo))
 {
objRow[congs_AnswerCount.Memo] = objgs_AnswerCountEN.Memo; //备注
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.AnswerCountId))
 {
objRow[congs_AnswerCount.AnswerCountId] = objgs_AnswerCountEN.AnswerCountId; //AnswerCountId
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.DataUser))
 {
objRow[congs_AnswerCount.DataUser] = objgs_AnswerCountEN.DataUser; //数据用户
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.DataAddDate))
 {
objRow[congs_AnswerCount.DataAddDate] = objgs_AnswerCountEN.DataAddDate; //数据添加日期
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Month))
 {
objRow[congs_AnswerCount.Month] = objgs_AnswerCountEN.Month; //月
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Week))
 {
objRow[congs_AnswerCount.Week] = objgs_AnswerCountEN.Week; //周
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.WeekTimeRange))
 {
objRow[congs_AnswerCount.WeekTimeRange] = objgs_AnswerCountEN.WeekTimeRange; //WeekTimeRange
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.IsRecommend))
 {
objRow[congs_AnswerCount.IsRecommend] = objgs_AnswerCountEN.IsRecommend; //是否推荐
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.AnswerId))
 {
objRow[congs_AnswerCount.AnswerId] = objgs_AnswerCountEN.AnswerId; //回答Id
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.AnswerTypeId))
 {
objRow[congs_AnswerCount.AnswerTypeId] = objgs_AnswerCountEN.AnswerTypeId; //答案类型ID
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.QuestionsId))
 {
objRow[congs_AnswerCount.QuestionsId] = objgs_AnswerCountEN.QuestionsId; //提问Id
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.TopicId))
 {
objRow[congs_AnswerCount.TopicId] = objgs_AnswerCountEN.TopicId; //主题Id
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.PaperId))
 {
objRow[congs_AnswerCount.PaperId] = objgs_AnswerCountEN.PaperId; //论文Id
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.IdCurrEduCls))
 {
objRow[congs_AnswerCount.IdCurrEduCls] = objgs_AnswerCountEN.IdCurrEduCls; //教学班流水号
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.AnswerContent))
 {
objRow[congs_AnswerCount.AnswerContent] = objgs_AnswerCountEN.AnswerContent; //答案内容
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Score))
 {
objRow[congs_AnswerCount.Score] = objgs_AnswerCountEN.Score; //评分
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.ScoreType))
 {
objRow[congs_AnswerCount.ScoreType] = objgs_AnswerCountEN.ScoreType; //评分类型
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.UpdUser))
 {
objRow[congs_AnswerCount.UpdUser] = objgs_AnswerCountEN.UpdUser; //修改人
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.UpdDate))
 {
objRow[congs_AnswerCount.UpdDate] = objgs_AnswerCountEN.UpdDate; //修改日期
 }
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.UserName))
 {
objRow[congs_AnswerCount.UserName] = objgs_AnswerCountEN.UserName; //用户名
 }
try
{
objDA.Update(objDS, clsgs_AnswerCountEN._CurrTabName);
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
 /// <param name = "objgs_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_AnswerCountEN objgs_AnswerCountEN)
{
 if (objgs_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_AnswerCountEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update gs_AnswerCount Set ");
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Memo))
 {
 if (objgs_AnswerCountEN.Memo !=  null)
 {
 var strMemo = objgs_AnswerCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_AnswerCount.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.Memo); //备注
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.DataUser))
 {
 if (objgs_AnswerCountEN.DataUser !=  null)
 {
 var strDataUser = objgs_AnswerCountEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataUser, congs_AnswerCount.DataUser); //数据用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.DataUser); //数据用户
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.DataAddDate))
 {
 if (objgs_AnswerCountEN.DataAddDate !=  null)
 {
 var strDataAddDate = objgs_AnswerCountEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataAddDate, congs_AnswerCount.DataAddDate); //数据添加日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.DataAddDate); //数据添加日期
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Month))
 {
 if (objgs_AnswerCountEN.Month !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_AnswerCountEN.Month, congs_AnswerCount.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.Month); //月
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Week))
 {
 if (objgs_AnswerCountEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_AnswerCountEN.Week, congs_AnswerCount.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.Week); //周
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.WeekTimeRange))
 {
 if (objgs_AnswerCountEN.WeekTimeRange !=  null)
 {
 var strWeekTimeRange = objgs_AnswerCountEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWeekTimeRange, congs_AnswerCount.WeekTimeRange); //WeekTimeRange
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.WeekTimeRange); //WeekTimeRange
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_AnswerCountEN.IsRecommend == true?"1":"0", congs_AnswerCount.IsRecommend); //是否推荐
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.AnswerId))
 {
 if (objgs_AnswerCountEN.AnswerId !=  null)
 {
 var strAnswerId = objgs_AnswerCountEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerId, congs_AnswerCount.AnswerId); //回答Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.AnswerId); //回答Id
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.AnswerTypeId))
 {
 if (objgs_AnswerCountEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objgs_AnswerCountEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTypeId, congs_AnswerCount.AnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.AnswerTypeId); //答案类型ID
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.QuestionsId))
 {
 if (objgs_AnswerCountEN.QuestionsId !=  null)
 {
 var strQuestionsId = objgs_AnswerCountEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsId, congs_AnswerCount.QuestionsId); //提问Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.QuestionsId); //提问Id
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.TopicId))
 {
 if (objgs_AnswerCountEN.TopicId !=  null)
 {
 var strTopicId = objgs_AnswerCountEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, congs_AnswerCount.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.TopicId); //主题Id
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.PaperId))
 {
 if (objgs_AnswerCountEN.PaperId !=  null)
 {
 var strPaperId = objgs_AnswerCountEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, congs_AnswerCount.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.PaperId); //论文Id
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.IdCurrEduCls))
 {
 if (objgs_AnswerCountEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_AnswerCountEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_AnswerCount.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.AnswerContent))
 {
 if (objgs_AnswerCountEN.AnswerContent !=  null)
 {
 var strAnswerContent = objgs_AnswerCountEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerContent, congs_AnswerCount.AnswerContent); //答案内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.AnswerContent); //答案内容
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Score))
 {
 if (objgs_AnswerCountEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_AnswerCountEN.Score, congs_AnswerCount.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.Score); //评分
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.ScoreType))
 {
 if (objgs_AnswerCountEN.ScoreType !=  null)
 {
 var strScoreType = objgs_AnswerCountEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strScoreType, congs_AnswerCount.ScoreType); //评分类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.ScoreType); //评分类型
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.UpdUser))
 {
 if (objgs_AnswerCountEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_AnswerCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_AnswerCount.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.UpdUser); //修改人
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.UpdDate))
 {
 if (objgs_AnswerCountEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_AnswerCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_AnswerCount.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.UpdDate); //修改日期
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.UserName))
 {
 if (objgs_AnswerCountEN.UserName !=  null)
 {
 var strUserName = objgs_AnswerCountEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserName, congs_AnswerCount.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.UserName); //用户名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where AnswerCountId = '{0}'", objgs_AnswerCountEN.AnswerCountId); 
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
 /// <param name = "objgs_AnswerCountEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsgs_AnswerCountEN objgs_AnswerCountEN, string strCondition)
{
 if (objgs_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_AnswerCountEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_AnswerCount Set ");
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Memo))
 {
 if (objgs_AnswerCountEN.Memo !=  null)
 {
 var strMemo = objgs_AnswerCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.DataUser))
 {
 if (objgs_AnswerCountEN.DataUser !=  null)
 {
 var strDataUser = objgs_AnswerCountEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataUser = '{0}',", strDataUser); //数据用户
 }
 else
 {
 sbSQL.Append(" DataUser = null,"); //数据用户
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.DataAddDate))
 {
 if (objgs_AnswerCountEN.DataAddDate !=  null)
 {
 var strDataAddDate = objgs_AnswerCountEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataAddDate = '{0}',", strDataAddDate); //数据添加日期
 }
 else
 {
 sbSQL.Append(" DataAddDate = null,"); //数据添加日期
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Month))
 {
 if (objgs_AnswerCountEN.Month !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_AnswerCountEN.Month, congs_AnswerCount.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.Month); //月
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Week))
 {
 if (objgs_AnswerCountEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_AnswerCountEN.Week, congs_AnswerCount.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.Week); //周
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.WeekTimeRange))
 {
 if (objgs_AnswerCountEN.WeekTimeRange !=  null)
 {
 var strWeekTimeRange = objgs_AnswerCountEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WeekTimeRange = '{0}',", strWeekTimeRange); //WeekTimeRange
 }
 else
 {
 sbSQL.Append(" WeekTimeRange = null,"); //WeekTimeRange
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objgs_AnswerCountEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.AnswerId))
 {
 if (objgs_AnswerCountEN.AnswerId !=  null)
 {
 var strAnswerId = objgs_AnswerCountEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerId = '{0}',", strAnswerId); //回答Id
 }
 else
 {
 sbSQL.Append(" AnswerId = null,"); //回答Id
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.AnswerTypeId))
 {
 if (objgs_AnswerCountEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objgs_AnswerCountEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTypeId = '{0}',", strAnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.Append(" AnswerTypeId = null,"); //答案类型ID
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.QuestionsId))
 {
 if (objgs_AnswerCountEN.QuestionsId !=  null)
 {
 var strQuestionsId = objgs_AnswerCountEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsId = '{0}',", strQuestionsId); //提问Id
 }
 else
 {
 sbSQL.Append(" QuestionsId = null,"); //提问Id
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.TopicId))
 {
 if (objgs_AnswerCountEN.TopicId !=  null)
 {
 var strTopicId = objgs_AnswerCountEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.PaperId))
 {
 if (objgs_AnswerCountEN.PaperId !=  null)
 {
 var strPaperId = objgs_AnswerCountEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.IdCurrEduCls))
 {
 if (objgs_AnswerCountEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_AnswerCountEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.AnswerContent))
 {
 if (objgs_AnswerCountEN.AnswerContent !=  null)
 {
 var strAnswerContent = objgs_AnswerCountEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerContent = '{0}',", strAnswerContent); //答案内容
 }
 else
 {
 sbSQL.Append(" AnswerContent = null,"); //答案内容
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Score))
 {
 if (objgs_AnswerCountEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_AnswerCountEN.Score, congs_AnswerCount.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.Score); //评分
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.ScoreType))
 {
 if (objgs_AnswerCountEN.ScoreType !=  null)
 {
 var strScoreType = objgs_AnswerCountEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ScoreType = '{0}',", strScoreType); //评分类型
 }
 else
 {
 sbSQL.Append(" ScoreType = null,"); //评分类型
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.UpdUser))
 {
 if (objgs_AnswerCountEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_AnswerCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.UpdDate))
 {
 if (objgs_AnswerCountEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_AnswerCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.UserName))
 {
 if (objgs_AnswerCountEN.UserName !=  null)
 {
 var strUserName = objgs_AnswerCountEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", strUserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
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
 /// <param name = "objgs_AnswerCountEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsgs_AnswerCountEN objgs_AnswerCountEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_AnswerCountEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_AnswerCount Set ");
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Memo))
 {
 if (objgs_AnswerCountEN.Memo !=  null)
 {
 var strMemo = objgs_AnswerCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.DataUser))
 {
 if (objgs_AnswerCountEN.DataUser !=  null)
 {
 var strDataUser = objgs_AnswerCountEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataUser = '{0}',", strDataUser); //数据用户
 }
 else
 {
 sbSQL.Append(" DataUser = null,"); //数据用户
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.DataAddDate))
 {
 if (objgs_AnswerCountEN.DataAddDate !=  null)
 {
 var strDataAddDate = objgs_AnswerCountEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataAddDate = '{0}',", strDataAddDate); //数据添加日期
 }
 else
 {
 sbSQL.Append(" DataAddDate = null,"); //数据添加日期
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Month))
 {
 if (objgs_AnswerCountEN.Month !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_AnswerCountEN.Month, congs_AnswerCount.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.Month); //月
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Week))
 {
 if (objgs_AnswerCountEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_AnswerCountEN.Week, congs_AnswerCount.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.Week); //周
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.WeekTimeRange))
 {
 if (objgs_AnswerCountEN.WeekTimeRange !=  null)
 {
 var strWeekTimeRange = objgs_AnswerCountEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WeekTimeRange = '{0}',", strWeekTimeRange); //WeekTimeRange
 }
 else
 {
 sbSQL.Append(" WeekTimeRange = null,"); //WeekTimeRange
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objgs_AnswerCountEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.AnswerId))
 {
 if (objgs_AnswerCountEN.AnswerId !=  null)
 {
 var strAnswerId = objgs_AnswerCountEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerId = '{0}',", strAnswerId); //回答Id
 }
 else
 {
 sbSQL.Append(" AnswerId = null,"); //回答Id
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.AnswerTypeId))
 {
 if (objgs_AnswerCountEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objgs_AnswerCountEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTypeId = '{0}',", strAnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.Append(" AnswerTypeId = null,"); //答案类型ID
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.QuestionsId))
 {
 if (objgs_AnswerCountEN.QuestionsId !=  null)
 {
 var strQuestionsId = objgs_AnswerCountEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsId = '{0}',", strQuestionsId); //提问Id
 }
 else
 {
 sbSQL.Append(" QuestionsId = null,"); //提问Id
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.TopicId))
 {
 if (objgs_AnswerCountEN.TopicId !=  null)
 {
 var strTopicId = objgs_AnswerCountEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.PaperId))
 {
 if (objgs_AnswerCountEN.PaperId !=  null)
 {
 var strPaperId = objgs_AnswerCountEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.IdCurrEduCls))
 {
 if (objgs_AnswerCountEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_AnswerCountEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.AnswerContent))
 {
 if (objgs_AnswerCountEN.AnswerContent !=  null)
 {
 var strAnswerContent = objgs_AnswerCountEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerContent = '{0}',", strAnswerContent); //答案内容
 }
 else
 {
 sbSQL.Append(" AnswerContent = null,"); //答案内容
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Score))
 {
 if (objgs_AnswerCountEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_AnswerCountEN.Score, congs_AnswerCount.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.Score); //评分
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.ScoreType))
 {
 if (objgs_AnswerCountEN.ScoreType !=  null)
 {
 var strScoreType = objgs_AnswerCountEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ScoreType = '{0}',", strScoreType); //评分类型
 }
 else
 {
 sbSQL.Append(" ScoreType = null,"); //评分类型
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.UpdUser))
 {
 if (objgs_AnswerCountEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_AnswerCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.UpdDate))
 {
 if (objgs_AnswerCountEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_AnswerCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.UserName))
 {
 if (objgs_AnswerCountEN.UserName !=  null)
 {
 var strUserName = objgs_AnswerCountEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", strUserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
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
 /// <param name = "objgs_AnswerCountEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_AnswerCountEN objgs_AnswerCountEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_AnswerCountEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_AnswerCountEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_AnswerCount Set ");
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Memo))
 {
 if (objgs_AnswerCountEN.Memo !=  null)
 {
 var strMemo = objgs_AnswerCountEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_AnswerCount.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.Memo); //备注
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.DataUser))
 {
 if (objgs_AnswerCountEN.DataUser !=  null)
 {
 var strDataUser = objgs_AnswerCountEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataUser, congs_AnswerCount.DataUser); //数据用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.DataUser); //数据用户
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.DataAddDate))
 {
 if (objgs_AnswerCountEN.DataAddDate !=  null)
 {
 var strDataAddDate = objgs_AnswerCountEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataAddDate, congs_AnswerCount.DataAddDate); //数据添加日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.DataAddDate); //数据添加日期
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Month))
 {
 if (objgs_AnswerCountEN.Month !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_AnswerCountEN.Month, congs_AnswerCount.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.Month); //月
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Week))
 {
 if (objgs_AnswerCountEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_AnswerCountEN.Week, congs_AnswerCount.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.Week); //周
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.WeekTimeRange))
 {
 if (objgs_AnswerCountEN.WeekTimeRange !=  null)
 {
 var strWeekTimeRange = objgs_AnswerCountEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWeekTimeRange, congs_AnswerCount.WeekTimeRange); //WeekTimeRange
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.WeekTimeRange); //WeekTimeRange
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_AnswerCountEN.IsRecommend == true?"1":"0", congs_AnswerCount.IsRecommend); //是否推荐
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.AnswerId))
 {
 if (objgs_AnswerCountEN.AnswerId !=  null)
 {
 var strAnswerId = objgs_AnswerCountEN.AnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerId, congs_AnswerCount.AnswerId); //回答Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.AnswerId); //回答Id
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.AnswerTypeId))
 {
 if (objgs_AnswerCountEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objgs_AnswerCountEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTypeId, congs_AnswerCount.AnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.AnswerTypeId); //答案类型ID
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.QuestionsId))
 {
 if (objgs_AnswerCountEN.QuestionsId !=  null)
 {
 var strQuestionsId = objgs_AnswerCountEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsId, congs_AnswerCount.QuestionsId); //提问Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.QuestionsId); //提问Id
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.TopicId))
 {
 if (objgs_AnswerCountEN.TopicId !=  null)
 {
 var strTopicId = objgs_AnswerCountEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, congs_AnswerCount.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.TopicId); //主题Id
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.PaperId))
 {
 if (objgs_AnswerCountEN.PaperId !=  null)
 {
 var strPaperId = objgs_AnswerCountEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, congs_AnswerCount.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.PaperId); //论文Id
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.IdCurrEduCls))
 {
 if (objgs_AnswerCountEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_AnswerCountEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_AnswerCount.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.AnswerContent))
 {
 if (objgs_AnswerCountEN.AnswerContent !=  null)
 {
 var strAnswerContent = objgs_AnswerCountEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerContent, congs_AnswerCount.AnswerContent); //答案内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.AnswerContent); //答案内容
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.Score))
 {
 if (objgs_AnswerCountEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_AnswerCountEN.Score, congs_AnswerCount.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.Score); //评分
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.ScoreType))
 {
 if (objgs_AnswerCountEN.ScoreType !=  null)
 {
 var strScoreType = objgs_AnswerCountEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strScoreType, congs_AnswerCount.ScoreType); //评分类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.ScoreType); //评分类型
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.UpdUser))
 {
 if (objgs_AnswerCountEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_AnswerCountEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_AnswerCount.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.UpdUser); //修改人
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.UpdDate))
 {
 if (objgs_AnswerCountEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_AnswerCountEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_AnswerCount.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.UpdDate); //修改日期
 }
 }
 
 if (objgs_AnswerCountEN.IsUpdated(congs_AnswerCount.UserName))
 {
 if (objgs_AnswerCountEN.UserName !=  null)
 {
 var strUserName = objgs_AnswerCountEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserName, congs_AnswerCount.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_AnswerCount.UserName); //用户名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where AnswerCountId = '{0}'", objgs_AnswerCountEN.AnswerCountId); 
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
 /// <param name = "strAnswerCountId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strAnswerCountId) 
{
CheckPrimaryKey(strAnswerCountId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strAnswerCountId,
};
 objSQL.ExecSP("gs_AnswerCount_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strAnswerCountId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strAnswerCountId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strAnswerCountId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
//删除gs_AnswerCount本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_AnswerCount where AnswerCountId = " + "'"+ strAnswerCountId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delgs_AnswerCount(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
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
//删除gs_AnswerCount本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_AnswerCount where AnswerCountId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strAnswerCountId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strAnswerCountId) 
{
CheckPrimaryKey(strAnswerCountId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
//删除gs_AnswerCount本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_AnswerCount where AnswerCountId = " + "'"+ strAnswerCountId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delgs_AnswerCount(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsgs_AnswerCountDA: Delgs_AnswerCount)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_AnswerCount where " + strCondition ;
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
public bool Delgs_AnswerCountWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsgs_AnswerCountDA: Delgs_AnswerCountWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_AnswerCount where " + strCondition ;
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
 /// <param name = "objgs_AnswerCountENS">源对象</param>
 /// <param name = "objgs_AnswerCountENT">目标对象</param>
public void CopyTo(clsgs_AnswerCountEN objgs_AnswerCountENS, clsgs_AnswerCountEN objgs_AnswerCountENT)
{
objgs_AnswerCountENT.Memo = objgs_AnswerCountENS.Memo; //备注
objgs_AnswerCountENT.AnswerCountId = objgs_AnswerCountENS.AnswerCountId; //AnswerCountId
objgs_AnswerCountENT.DataUser = objgs_AnswerCountENS.DataUser; //数据用户
objgs_AnswerCountENT.DataAddDate = objgs_AnswerCountENS.DataAddDate; //数据添加日期
objgs_AnswerCountENT.Month = objgs_AnswerCountENS.Month; //月
objgs_AnswerCountENT.Week = objgs_AnswerCountENS.Week; //周
objgs_AnswerCountENT.WeekTimeRange = objgs_AnswerCountENS.WeekTimeRange; //WeekTimeRange
objgs_AnswerCountENT.IsRecommend = objgs_AnswerCountENS.IsRecommend; //是否推荐
objgs_AnswerCountENT.AnswerId = objgs_AnswerCountENS.AnswerId; //回答Id
objgs_AnswerCountENT.AnswerTypeId = objgs_AnswerCountENS.AnswerTypeId; //答案类型ID
objgs_AnswerCountENT.QuestionsId = objgs_AnswerCountENS.QuestionsId; //提问Id
objgs_AnswerCountENT.TopicId = objgs_AnswerCountENS.TopicId; //主题Id
objgs_AnswerCountENT.PaperId = objgs_AnswerCountENS.PaperId; //论文Id
objgs_AnswerCountENT.IdCurrEduCls = objgs_AnswerCountENS.IdCurrEduCls; //教学班流水号
objgs_AnswerCountENT.AnswerContent = objgs_AnswerCountENS.AnswerContent; //答案内容
objgs_AnswerCountENT.Score = objgs_AnswerCountENS.Score; //评分
objgs_AnswerCountENT.ScoreType = objgs_AnswerCountENS.ScoreType; //评分类型
objgs_AnswerCountENT.UpdUser = objgs_AnswerCountENS.UpdUser; //修改人
objgs_AnswerCountENT.UpdDate = objgs_AnswerCountENS.UpdDate; //修改日期
objgs_AnswerCountENT.UserName = objgs_AnswerCountENS.UserName; //用户名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsgs_AnswerCountEN objgs_AnswerCountEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.Memo, 1000, congs_AnswerCount.Memo);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.AnswerCountId, 10, congs_AnswerCount.AnswerCountId);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.DataUser, 20, congs_AnswerCount.DataUser);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.DataAddDate, 20, congs_AnswerCount.DataAddDate);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.WeekTimeRange, 100, congs_AnswerCount.WeekTimeRange);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.AnswerId, 10, congs_AnswerCount.AnswerId);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.AnswerTypeId, 2, congs_AnswerCount.AnswerTypeId);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.QuestionsId, 8, congs_AnswerCount.QuestionsId);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.TopicId, 8, congs_AnswerCount.TopicId);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.PaperId, 8, congs_AnswerCount.PaperId);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.IdCurrEduCls, 8, congs_AnswerCount.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.ScoreType, 1, congs_AnswerCount.ScoreType);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.UpdUser, 20, congs_AnswerCount.UpdUser);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.UpdDate, 20, congs_AnswerCount.UpdDate);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.UserName, 30, congs_AnswerCount.UserName);
//检查字段外键固定长度
 objgs_AnswerCountEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsgs_AnswerCountEN objgs_AnswerCountEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.Memo, 1000, congs_AnswerCount.Memo);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.DataUser, 20, congs_AnswerCount.DataUser);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.DataAddDate, 20, congs_AnswerCount.DataAddDate);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.WeekTimeRange, 100, congs_AnswerCount.WeekTimeRange);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.AnswerId, 10, congs_AnswerCount.AnswerId);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.AnswerTypeId, 2, congs_AnswerCount.AnswerTypeId);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.QuestionsId, 8, congs_AnswerCount.QuestionsId);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.TopicId, 8, congs_AnswerCount.TopicId);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.PaperId, 8, congs_AnswerCount.PaperId);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.IdCurrEduCls, 8, congs_AnswerCount.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.ScoreType, 1, congs_AnswerCount.ScoreType);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.UpdUser, 20, congs_AnswerCount.UpdUser);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.UpdDate, 20, congs_AnswerCount.UpdDate);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.UserName, 30, congs_AnswerCount.UserName);
//检查外键字段长度
 objgs_AnswerCountEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsgs_AnswerCountEN objgs_AnswerCountEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.Memo, 1000, congs_AnswerCount.Memo);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.AnswerCountId, 10, congs_AnswerCount.AnswerCountId);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.DataUser, 20, congs_AnswerCount.DataUser);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.DataAddDate, 20, congs_AnswerCount.DataAddDate);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.WeekTimeRange, 100, congs_AnswerCount.WeekTimeRange);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.AnswerId, 10, congs_AnswerCount.AnswerId);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.AnswerTypeId, 2, congs_AnswerCount.AnswerTypeId);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.QuestionsId, 8, congs_AnswerCount.QuestionsId);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.TopicId, 8, congs_AnswerCount.TopicId);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.PaperId, 8, congs_AnswerCount.PaperId);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.IdCurrEduCls, 8, congs_AnswerCount.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.ScoreType, 1, congs_AnswerCount.ScoreType);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.UpdUser, 20, congs_AnswerCount.UpdUser);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.UpdDate, 20, congs_AnswerCount.UpdDate);
clsCheckSql.CheckFieldLen(objgs_AnswerCountEN.UserName, 30, congs_AnswerCount.UserName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objgs_AnswerCountEN.Memo, congs_AnswerCount.Memo);
clsCheckSql.CheckSqlInjection4Field(objgs_AnswerCountEN.AnswerCountId, congs_AnswerCount.AnswerCountId);
clsCheckSql.CheckSqlInjection4Field(objgs_AnswerCountEN.DataUser, congs_AnswerCount.DataUser);
clsCheckSql.CheckSqlInjection4Field(objgs_AnswerCountEN.DataAddDate, congs_AnswerCount.DataAddDate);
clsCheckSql.CheckSqlInjection4Field(objgs_AnswerCountEN.WeekTimeRange, congs_AnswerCount.WeekTimeRange);
clsCheckSql.CheckSqlInjection4Field(objgs_AnswerCountEN.AnswerId, congs_AnswerCount.AnswerId);
clsCheckSql.CheckSqlInjection4Field(objgs_AnswerCountEN.AnswerTypeId, congs_AnswerCount.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objgs_AnswerCountEN.QuestionsId, congs_AnswerCount.QuestionsId);
clsCheckSql.CheckSqlInjection4Field(objgs_AnswerCountEN.TopicId, congs_AnswerCount.TopicId);
clsCheckSql.CheckSqlInjection4Field(objgs_AnswerCountEN.PaperId, congs_AnswerCount.PaperId);
clsCheckSql.CheckSqlInjection4Field(objgs_AnswerCountEN.IdCurrEduCls, congs_AnswerCount.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objgs_AnswerCountEN.ScoreType, congs_AnswerCount.ScoreType);
clsCheckSql.CheckSqlInjection4Field(objgs_AnswerCountEN.UpdUser, congs_AnswerCount.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objgs_AnswerCountEN.UpdDate, congs_AnswerCount.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objgs_AnswerCountEN.UserName, congs_AnswerCount.UserName);
//检查外键字段长度
 objgs_AnswerCountEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--gs_AnswerCount(问题讨论回答统计),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsgs_AnswerCountEN objgs_AnswerCountEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and AnswerCountId = '{0}'", objgs_AnswerCountEN.AnswerCountId);
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
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
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
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
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
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_AnswerCountEN._CurrTabName);
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
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_AnswerCountEN._CurrTabName, strCondition);
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
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
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
 objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}