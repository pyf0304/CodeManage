
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TobeStudiedProblemVerDA
 表名:gs_TobeStudiedProblemVer(01120775)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:11:23
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
 /// 待研究问题历史版本表(gs_TobeStudiedProblemVer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsgs_TobeStudiedProblemVerDA : clsCommBase4DA
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
 return clsgs_TobeStudiedProblemVerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsgs_TobeStudiedProblemVerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_TobeStudiedProblemVerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsgs_TobeStudiedProblemVerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsgs_TobeStudiedProblemVerEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblemVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_gs_TobeStudiedProblemVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemVerDA: GetDataTable_gs_TobeStudiedProblemVer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblemVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblemVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_TobeStudiedProblemVer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_TobeStudiedProblemVer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from gs_TobeStudiedProblemVer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_TobeStudiedProblemVer.* from gs_TobeStudiedProblemVer Left Join {1} on {2} where {3} and gs_TobeStudiedProblemVer.ProblemVId not in (Select top {5} gs_TobeStudiedProblemVer.ProblemVId from gs_TobeStudiedProblemVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_TobeStudiedProblemVer where {1} and ProblemVId not in (Select top {2} ProblemVId from gs_TobeStudiedProblemVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_TobeStudiedProblemVer where {1} and ProblemVId not in (Select top {3} ProblemVId from gs_TobeStudiedProblemVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_TobeStudiedProblemVer.* from gs_TobeStudiedProblemVer Left Join {1} on {2} where {3} and gs_TobeStudiedProblemVer.ProblemVId not in (Select top {5} gs_TobeStudiedProblemVer.ProblemVId from gs_TobeStudiedProblemVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_TobeStudiedProblemVer where {1} and ProblemVId not in (Select top {2} ProblemVId from gs_TobeStudiedProblemVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_TobeStudiedProblemVer where {1} and ProblemVId not in (Select top {3} ProblemVId from gs_TobeStudiedProblemVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsgs_TobeStudiedProblemVerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemVerDA:GetObjLst)", objException.Message));
}
List<clsgs_TobeStudiedProblemVerEN> arrObjLst = new List<clsgs_TobeStudiedProblemVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblemVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN = new clsgs_TobeStudiedProblemVerEN();
try
{
objgs_TobeStudiedProblemVerEN.ProblemVId = TransNullToInt(objRow[congs_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objgs_TobeStudiedProblemVerEN.ProblemId = objRow[congs_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemVerEN.TopicId = objRow[congs_TobeStudiedProblemVer.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemVerEN.IsSubmit = TransNullToBool(objRow[congs_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemVerEN.ProblemContent = objRow[congs_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemVerEN.ProblemDate = objRow[congs_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemVerEN.Participant = objRow[congs_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemVerEN.UpdDate = objRow[congs_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemVerEN.UpdUser = objRow[congs_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemVerEN.Year = objRow[congs_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemVerEN.Month = objRow[congs_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemVerEN.Memo = objRow[congs_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemVerEN.ProblemTitle = objRow[congs_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_TobeStudiedProblemVerDA: GetObjLst)", objException.Message));
}
objgs_TobeStudiedProblemVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_TobeStudiedProblemVerEN);
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
public List<clsgs_TobeStudiedProblemVerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemVerDA:GetObjLstByTabName)", objException.Message));
}
List<clsgs_TobeStudiedProblemVerEN> arrObjLst = new List<clsgs_TobeStudiedProblemVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN = new clsgs_TobeStudiedProblemVerEN();
try
{
objgs_TobeStudiedProblemVerEN.ProblemVId = TransNullToInt(objRow[congs_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objgs_TobeStudiedProblemVerEN.ProblemId = objRow[congs_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemVerEN.TopicId = objRow[congs_TobeStudiedProblemVer.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemVerEN.IsSubmit = TransNullToBool(objRow[congs_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemVerEN.ProblemContent = objRow[congs_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemVerEN.ProblemDate = objRow[congs_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemVerEN.Participant = objRow[congs_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemVerEN.UpdDate = objRow[congs_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemVerEN.UpdUser = objRow[congs_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemVerEN.Year = objRow[congs_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemVerEN.Month = objRow[congs_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemVerEN.Memo = objRow[congs_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemVerEN.ProblemTitle = objRow[congs_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_TobeStudiedProblemVerDA: GetObjLst)", objException.Message));
}
objgs_TobeStudiedProblemVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_TobeStudiedProblemVerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemVerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getgs_TobeStudiedProblemVer(ref clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblemVer where ProblemVId = " + ""+ objgs_TobeStudiedProblemVerEN.ProblemVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objgs_TobeStudiedProblemVerEN.ProblemVId = TransNullToInt(objDT.Rows[0][congs_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId(字段类型:bigint,字段长度:8,是否可空:False)
 objgs_TobeStudiedProblemVerEN.ProblemId = objDT.Rows[0][congs_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id(字段类型:char,字段长度:10,是否可空:False)
 objgs_TobeStudiedProblemVerEN.TopicId = objDT.Rows[0][congs_TobeStudiedProblemVer.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_TobeStudiedProblemVerEN.IsSubmit = TransNullToBool(objDT.Rows[0][congs_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objgs_TobeStudiedProblemVerEN.ProblemContent = objDT.Rows[0][congs_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objgs_TobeStudiedProblemVerEN.ProblemDate = objDT.Rows[0][congs_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_TobeStudiedProblemVerEN.Participant = objDT.Rows[0][congs_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者(字段类型:varchar,字段长度:500,是否可空:True)
 objgs_TobeStudiedProblemVerEN.UpdDate = objDT.Rows[0][congs_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_TobeStudiedProblemVerEN.UpdUser = objDT.Rows[0][congs_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_TobeStudiedProblemVerEN.Year = objDT.Rows[0][congs_TobeStudiedProblemVer.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objgs_TobeStudiedProblemVerEN.Month = objDT.Rows[0][congs_TobeStudiedProblemVer.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objgs_TobeStudiedProblemVerEN.Memo = objDT.Rows[0][congs_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_TobeStudiedProblemVerEN.ProblemTitle = objDT.Rows[0][congs_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsgs_TobeStudiedProblemVerDA: Getgs_TobeStudiedProblemVer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngProblemVId">表关键字</param>
 /// <returns>表对象</returns>
public clsgs_TobeStudiedProblemVerEN GetObjByProblemVId(long lngProblemVId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblemVer where ProblemVId = " + ""+ lngProblemVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN = new clsgs_TobeStudiedProblemVerEN();
try
{
 objgs_TobeStudiedProblemVerEN.ProblemVId = Int32.Parse(objRow[congs_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId(字段类型:bigint,字段长度:8,是否可空:False)
 objgs_TobeStudiedProblemVerEN.ProblemId = objRow[congs_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id(字段类型:char,字段长度:10,是否可空:False)
 objgs_TobeStudiedProblemVerEN.TopicId = objRow[congs_TobeStudiedProblemVer.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_TobeStudiedProblemVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objgs_TobeStudiedProblemVerEN.ProblemContent = objRow[congs_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objgs_TobeStudiedProblemVerEN.ProblemDate = objRow[congs_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_TobeStudiedProblemVerEN.Participant = objRow[congs_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者(字段类型:varchar,字段长度:500,是否可空:True)
 objgs_TobeStudiedProblemVerEN.UpdDate = objRow[congs_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_TobeStudiedProblemVerEN.UpdUser = objRow[congs_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_TobeStudiedProblemVerEN.Year = objRow[congs_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objgs_TobeStudiedProblemVerEN.Month = objRow[congs_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objgs_TobeStudiedProblemVerEN.Memo = objRow[congs_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_TobeStudiedProblemVerEN.ProblemTitle = objRow[congs_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsgs_TobeStudiedProblemVerDA: GetObjByProblemVId)", objException.Message));
}
return objgs_TobeStudiedProblemVerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsgs_TobeStudiedProblemVerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemVerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblemVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN = new clsgs_TobeStudiedProblemVerEN()
{
ProblemVId = TransNullToInt(objRow[congs_TobeStudiedProblemVer.ProblemVId].ToString().Trim()), //ProblemVId
ProblemId = objRow[congs_TobeStudiedProblemVer.ProblemId].ToString().Trim(), //问题Id
TopicId = objRow[congs_TobeStudiedProblemVer.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.TopicId].ToString().Trim(), //主题Id
IsSubmit = TransNullToBool(objRow[congs_TobeStudiedProblemVer.IsSubmit].ToString().Trim()), //是否提交
ProblemContent = objRow[congs_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemContent].ToString().Trim(), //问题内容
ProblemDate = objRow[congs_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemDate].ToString().Trim(), //问题日期
Participant = objRow[congs_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Participant].ToString().Trim(), //参与者
UpdDate = objRow[congs_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[congs_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.UpdUser].ToString().Trim(), //修改人
Year = objRow[congs_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Year].ToString().Trim(), //年
Month = objRow[congs_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Month].ToString().Trim(), //月
Memo = objRow[congs_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Memo].ToString().Trim(), //备注
ProblemTitle = objRow[congs_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemTitle].ToString().Trim() //问题标题
};
objgs_TobeStudiedProblemVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_TobeStudiedProblemVerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsgs_TobeStudiedProblemVerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsgs_TobeStudiedProblemVerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN = new clsgs_TobeStudiedProblemVerEN();
try
{
objgs_TobeStudiedProblemVerEN.ProblemVId = TransNullToInt(objRow[congs_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objgs_TobeStudiedProblemVerEN.ProblemId = objRow[congs_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemVerEN.TopicId = objRow[congs_TobeStudiedProblemVer.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemVerEN.IsSubmit = TransNullToBool(objRow[congs_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemVerEN.ProblemContent = objRow[congs_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemVerEN.ProblemDate = objRow[congs_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemVerEN.Participant = objRow[congs_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemVerEN.UpdDate = objRow[congs_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemVerEN.UpdUser = objRow[congs_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemVerEN.Year = objRow[congs_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemVerEN.Month = objRow[congs_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemVerEN.Memo = objRow[congs_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemVerEN.ProblemTitle = objRow[congs_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsgs_TobeStudiedProblemVerDA: GetObjByDataRowgs_TobeStudiedProblemVer)", objException.Message));
}
objgs_TobeStudiedProblemVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_TobeStudiedProblemVerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsgs_TobeStudiedProblemVerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN = new clsgs_TobeStudiedProblemVerEN();
try
{
objgs_TobeStudiedProblemVerEN.ProblemVId = TransNullToInt(objRow[congs_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objgs_TobeStudiedProblemVerEN.ProblemId = objRow[congs_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemVerEN.TopicId = objRow[congs_TobeStudiedProblemVer.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemVerEN.IsSubmit = TransNullToBool(objRow[congs_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemVerEN.ProblemContent = objRow[congs_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemVerEN.ProblemDate = objRow[congs_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemVerEN.Participant = objRow[congs_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemVerEN.UpdDate = objRow[congs_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemVerEN.UpdUser = objRow[congs_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemVerEN.Year = objRow[congs_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemVerEN.Month = objRow[congs_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemVerEN.Memo = objRow[congs_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemVerEN.ProblemTitle = objRow[congs_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsgs_TobeStudiedProblemVerDA: GetObjByDataRow)", objException.Message));
}
objgs_TobeStudiedProblemVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_TobeStudiedProblemVerEN;
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
objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_TobeStudiedProblemVerEN._CurrTabName, congs_TobeStudiedProblemVer.ProblemVId, 8, "");
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
objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_TobeStudiedProblemVerEN._CurrTabName, congs_TobeStudiedProblemVer.ProblemVId, 8, strPrefix);
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
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ProblemVId from gs_TobeStudiedProblemVer where " + strCondition;
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
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ProblemVId from gs_TobeStudiedProblemVer where " + strCondition;
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
 /// <param name = "lngProblemVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngProblemVId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_TobeStudiedProblemVer", "ProblemVId = " + ""+ lngProblemVId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemVerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_TobeStudiedProblemVer", strCondition))
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
objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("gs_TobeStudiedProblemVer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN)
 {
 if (objgs_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_TobeStudiedProblemVerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblemVer where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_TobeStudiedProblemVer");
objRow = objDS.Tables["gs_TobeStudiedProblemVer"].NewRow();
objRow[congs_TobeStudiedProblemVer.ProblemId] = objgs_TobeStudiedProblemVerEN.ProblemId; //问题Id
 if (objgs_TobeStudiedProblemVerEN.TopicId !=  "")
 {
objRow[congs_TobeStudiedProblemVer.TopicId] = objgs_TobeStudiedProblemVerEN.TopicId; //主题Id
 }
objRow[congs_TobeStudiedProblemVer.IsSubmit] = objgs_TobeStudiedProblemVerEN.IsSubmit; //是否提交
 if (objgs_TobeStudiedProblemVerEN.ProblemContent !=  "")
 {
objRow[congs_TobeStudiedProblemVer.ProblemContent] = objgs_TobeStudiedProblemVerEN.ProblemContent; //问题内容
 }
 if (objgs_TobeStudiedProblemVerEN.ProblemDate !=  "")
 {
objRow[congs_TobeStudiedProblemVer.ProblemDate] = objgs_TobeStudiedProblemVerEN.ProblemDate; //问题日期
 }
 if (objgs_TobeStudiedProblemVerEN.Participant !=  "")
 {
objRow[congs_TobeStudiedProblemVer.Participant] = objgs_TobeStudiedProblemVerEN.Participant; //参与者
 }
 if (objgs_TobeStudiedProblemVerEN.UpdDate !=  "")
 {
objRow[congs_TobeStudiedProblemVer.UpdDate] = objgs_TobeStudiedProblemVerEN.UpdDate; //修改日期
 }
 if (objgs_TobeStudiedProblemVerEN.UpdUser !=  "")
 {
objRow[congs_TobeStudiedProblemVer.UpdUser] = objgs_TobeStudiedProblemVerEN.UpdUser; //修改人
 }
 if (objgs_TobeStudiedProblemVerEN.Year !=  "")
 {
objRow[congs_TobeStudiedProblemVer.Year] = objgs_TobeStudiedProblemVerEN.Year; //年
 }
 if (objgs_TobeStudiedProblemVerEN.Month !=  "")
 {
objRow[congs_TobeStudiedProblemVer.Month] = objgs_TobeStudiedProblemVerEN.Month; //月
 }
 if (objgs_TobeStudiedProblemVerEN.Memo !=  "")
 {
objRow[congs_TobeStudiedProblemVer.Memo] = objgs_TobeStudiedProblemVerEN.Memo; //备注
 }
 if (objgs_TobeStudiedProblemVerEN.ProblemTitle !=  "")
 {
objRow[congs_TobeStudiedProblemVer.ProblemTitle] = objgs_TobeStudiedProblemVerEN.ProblemTitle; //问题标题
 }
objDS.Tables[clsgs_TobeStudiedProblemVerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsgs_TobeStudiedProblemVerEN._CurrTabName);
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
 /// <param name = "objgs_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN)
{
 if (objgs_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_TobeStudiedProblemVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_TobeStudiedProblemVerEN.ProblemId !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.ProblemId);
 var strProblemId = objgs_TobeStudiedProblemVerEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemId + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.TopicId);
 var strTopicId = objgs_TobeStudiedProblemVerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_TobeStudiedProblemVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_TobeStudiedProblemVerEN.ProblemContent !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.ProblemContent);
 var strProblemContent = objgs_TobeStudiedProblemVerEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemContent + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.ProblemDate !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.ProblemDate);
 var strProblemDate = objgs_TobeStudiedProblemVerEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemDate + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.Participant !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.Participant);
 var strParticipant = objgs_TobeStudiedProblemVerEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipant + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.UpdDate);
 var strUpdDate = objgs_TobeStudiedProblemVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.UpdUser);
 var strUpdUser = objgs_TobeStudiedProblemVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.Year !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.Year);
 var strYear = objgs_TobeStudiedProblemVerEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.Month !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.Month);
 var strMonth = objgs_TobeStudiedProblemVerEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.Memo);
 var strMemo = objgs_TobeStudiedProblemVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.ProblemTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.ProblemTitle);
 var strProblemTitle = objgs_TobeStudiedProblemVerEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemTitle + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_TobeStudiedProblemVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN)
{
 if (objgs_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_TobeStudiedProblemVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_TobeStudiedProblemVerEN.ProblemId !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.ProblemId);
 var strProblemId = objgs_TobeStudiedProblemVerEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemId + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.TopicId);
 var strTopicId = objgs_TobeStudiedProblemVerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_TobeStudiedProblemVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_TobeStudiedProblemVerEN.ProblemContent !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.ProblemContent);
 var strProblemContent = objgs_TobeStudiedProblemVerEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemContent + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.ProblemDate !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.ProblemDate);
 var strProblemDate = objgs_TobeStudiedProblemVerEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemDate + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.Participant !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.Participant);
 var strParticipant = objgs_TobeStudiedProblemVerEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipant + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.UpdDate);
 var strUpdDate = objgs_TobeStudiedProblemVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.UpdUser);
 var strUpdUser = objgs_TobeStudiedProblemVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.Year !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.Year);
 var strYear = objgs_TobeStudiedProblemVerEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.Month !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.Month);
 var strMonth = objgs_TobeStudiedProblemVerEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.Memo);
 var strMemo = objgs_TobeStudiedProblemVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.ProblemTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.ProblemTitle);
 var strProblemTitle = objgs_TobeStudiedProblemVerEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemTitle + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_TobeStudiedProblemVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_TobeStudiedProblemVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_TobeStudiedProblemVerEN.ProblemId !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.ProblemId);
 var strProblemId = objgs_TobeStudiedProblemVerEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemId + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.TopicId);
 var strTopicId = objgs_TobeStudiedProblemVerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_TobeStudiedProblemVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_TobeStudiedProblemVerEN.ProblemContent !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.ProblemContent);
 var strProblemContent = objgs_TobeStudiedProblemVerEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemContent + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.ProblemDate !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.ProblemDate);
 var strProblemDate = objgs_TobeStudiedProblemVerEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemDate + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.Participant !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.Participant);
 var strParticipant = objgs_TobeStudiedProblemVerEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipant + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.UpdDate);
 var strUpdDate = objgs_TobeStudiedProblemVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.UpdUser);
 var strUpdUser = objgs_TobeStudiedProblemVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.Year !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.Year);
 var strYear = objgs_TobeStudiedProblemVerEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.Month !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.Month);
 var strMonth = objgs_TobeStudiedProblemVerEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.Memo);
 var strMemo = objgs_TobeStudiedProblemVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.ProblemTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.ProblemTitle);
 var strProblemTitle = objgs_TobeStudiedProblemVerEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemTitle + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_TobeStudiedProblemVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_TobeStudiedProblemVerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_TobeStudiedProblemVerEN.ProblemId !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.ProblemId);
 var strProblemId = objgs_TobeStudiedProblemVerEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemId + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.TopicId);
 var strTopicId = objgs_TobeStudiedProblemVerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_TobeStudiedProblemVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_TobeStudiedProblemVerEN.ProblemContent !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.ProblemContent);
 var strProblemContent = objgs_TobeStudiedProblemVerEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemContent + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.ProblemDate !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.ProblemDate);
 var strProblemDate = objgs_TobeStudiedProblemVerEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemDate + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.Participant !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.Participant);
 var strParticipant = objgs_TobeStudiedProblemVerEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipant + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.UpdDate);
 var strUpdDate = objgs_TobeStudiedProblemVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.UpdUser);
 var strUpdUser = objgs_TobeStudiedProblemVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.Year !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.Year);
 var strYear = objgs_TobeStudiedProblemVerEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.Month !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.Month);
 var strMonth = objgs_TobeStudiedProblemVerEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.Memo);
 var strMemo = objgs_TobeStudiedProblemVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_TobeStudiedProblemVerEN.ProblemTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_TobeStudiedProblemVer.ProblemTitle);
 var strProblemTitle = objgs_TobeStudiedProblemVerEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemTitle + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_TobeStudiedProblemVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewgs_TobeStudiedProblemVers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblemVer where ProblemVId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_TobeStudiedProblemVer");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngProblemVId = TransNullToInt(oRow[congs_TobeStudiedProblemVer.ProblemVId].ToString().Trim());
if (IsExist(lngProblemVId))
{
 string strResult = "关键字变量值为:" + string.Format("ProblemVId = {0}", lngProblemVId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsgs_TobeStudiedProblemVerEN._CurrTabName ].NewRow();
objRow[congs_TobeStudiedProblemVer.ProblemId] = oRow[congs_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objRow[congs_TobeStudiedProblemVer.TopicId] = oRow[congs_TobeStudiedProblemVer.TopicId].ToString().Trim(); //主题Id
objRow[congs_TobeStudiedProblemVer.IsSubmit] = oRow[congs_TobeStudiedProblemVer.IsSubmit].ToString().Trim(); //是否提交
objRow[congs_TobeStudiedProblemVer.ProblemContent] = oRow[congs_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objRow[congs_TobeStudiedProblemVer.ProblemDate] = oRow[congs_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objRow[congs_TobeStudiedProblemVer.Participant] = oRow[congs_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objRow[congs_TobeStudiedProblemVer.UpdDate] = oRow[congs_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objRow[congs_TobeStudiedProblemVer.UpdUser] = oRow[congs_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objRow[congs_TobeStudiedProblemVer.Year] = oRow[congs_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objRow[congs_TobeStudiedProblemVer.Month] = oRow[congs_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objRow[congs_TobeStudiedProblemVer.Memo] = oRow[congs_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objRow[congs_TobeStudiedProblemVer.ProblemTitle] = oRow[congs_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
 objDS.Tables[clsgs_TobeStudiedProblemVerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsgs_TobeStudiedProblemVerEN._CurrTabName);
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
 /// <param name = "objgs_TobeStudiedProblemVerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN)
{
 if (objgs_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_TobeStudiedProblemVerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from gs_TobeStudiedProblemVer where ProblemVId = " + ""+ objgs_TobeStudiedProblemVerEN.ProblemVId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsgs_TobeStudiedProblemVerEN._CurrTabName);
if (objDS.Tables[clsgs_TobeStudiedProblemVerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ProblemVId = " + ""+ objgs_TobeStudiedProblemVerEN.ProblemVId+"");
return false;
}
objRow = objDS.Tables[clsgs_TobeStudiedProblemVerEN._CurrTabName].Rows[0];
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemId))
 {
objRow[congs_TobeStudiedProblemVer.ProblemId] = objgs_TobeStudiedProblemVerEN.ProblemId; //问题Id
 }
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.TopicId))
 {
objRow[congs_TobeStudiedProblemVer.TopicId] = objgs_TobeStudiedProblemVerEN.TopicId; //主题Id
 }
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.IsSubmit))
 {
objRow[congs_TobeStudiedProblemVer.IsSubmit] = objgs_TobeStudiedProblemVerEN.IsSubmit; //是否提交
 }
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemContent))
 {
objRow[congs_TobeStudiedProblemVer.ProblemContent] = objgs_TobeStudiedProblemVerEN.ProblemContent; //问题内容
 }
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemDate))
 {
objRow[congs_TobeStudiedProblemVer.ProblemDate] = objgs_TobeStudiedProblemVerEN.ProblemDate; //问题日期
 }
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Participant))
 {
objRow[congs_TobeStudiedProblemVer.Participant] = objgs_TobeStudiedProblemVerEN.Participant; //参与者
 }
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.UpdDate))
 {
objRow[congs_TobeStudiedProblemVer.UpdDate] = objgs_TobeStudiedProblemVerEN.UpdDate; //修改日期
 }
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.UpdUser))
 {
objRow[congs_TobeStudiedProblemVer.UpdUser] = objgs_TobeStudiedProblemVerEN.UpdUser; //修改人
 }
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Year))
 {
objRow[congs_TobeStudiedProblemVer.Year] = objgs_TobeStudiedProblemVerEN.Year; //年
 }
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Month))
 {
objRow[congs_TobeStudiedProblemVer.Month] = objgs_TobeStudiedProblemVerEN.Month; //月
 }
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Memo))
 {
objRow[congs_TobeStudiedProblemVer.Memo] = objgs_TobeStudiedProblemVerEN.Memo; //备注
 }
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemTitle))
 {
objRow[congs_TobeStudiedProblemVer.ProblemTitle] = objgs_TobeStudiedProblemVerEN.ProblemTitle; //问题标题
 }
try
{
objDA.Update(objDS, clsgs_TobeStudiedProblemVerEN._CurrTabName);
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
 /// <param name = "objgs_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN)
{
 if (objgs_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_TobeStudiedProblemVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update gs_TobeStudiedProblemVer Set ");
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemId))
 {
 if (objgs_TobeStudiedProblemVerEN.ProblemId !=  null)
 {
 var strProblemId = objgs_TobeStudiedProblemVerEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemId, congs_TobeStudiedProblemVer.ProblemId); //问题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.ProblemId); //问题Id
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.TopicId))
 {
 if (objgs_TobeStudiedProblemVerEN.TopicId !=  null)
 {
 var strTopicId = objgs_TobeStudiedProblemVerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, congs_TobeStudiedProblemVer.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.TopicId); //主题Id
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_TobeStudiedProblemVerEN.IsSubmit == true?"1":"0", congs_TobeStudiedProblemVer.IsSubmit); //是否提交
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemContent))
 {
 if (objgs_TobeStudiedProblemVerEN.ProblemContent !=  null)
 {
 var strProblemContent = objgs_TobeStudiedProblemVerEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemContent, congs_TobeStudiedProblemVer.ProblemContent); //问题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.ProblemContent); //问题内容
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemDate))
 {
 if (objgs_TobeStudiedProblemVerEN.ProblemDate !=  null)
 {
 var strProblemDate = objgs_TobeStudiedProblemVerEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemDate, congs_TobeStudiedProblemVer.ProblemDate); //问题日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.ProblemDate); //问题日期
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Participant))
 {
 if (objgs_TobeStudiedProblemVerEN.Participant !=  null)
 {
 var strParticipant = objgs_TobeStudiedProblemVerEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParticipant, congs_TobeStudiedProblemVer.Participant); //参与者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.Participant); //参与者
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.UpdDate))
 {
 if (objgs_TobeStudiedProblemVerEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_TobeStudiedProblemVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_TobeStudiedProblemVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.UpdDate); //修改日期
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.UpdUser))
 {
 if (objgs_TobeStudiedProblemVerEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_TobeStudiedProblemVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_TobeStudiedProblemVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.UpdUser); //修改人
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Year))
 {
 if (objgs_TobeStudiedProblemVerEN.Year !=  null)
 {
 var strYear = objgs_TobeStudiedProblemVerEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYear, congs_TobeStudiedProblemVer.Year); //年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.Year); //年
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Month))
 {
 if (objgs_TobeStudiedProblemVerEN.Month !=  null)
 {
 var strMonth = objgs_TobeStudiedProblemVerEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMonth, congs_TobeStudiedProblemVer.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.Month); //月
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Memo))
 {
 if (objgs_TobeStudiedProblemVerEN.Memo !=  null)
 {
 var strMemo = objgs_TobeStudiedProblemVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_TobeStudiedProblemVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.Memo); //备注
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemTitle))
 {
 if (objgs_TobeStudiedProblemVerEN.ProblemTitle !=  null)
 {
 var strProblemTitle = objgs_TobeStudiedProblemVerEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemTitle, congs_TobeStudiedProblemVer.ProblemTitle); //问题标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.ProblemTitle); //问题标题
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ProblemVId = {0}", objgs_TobeStudiedProblemVerEN.ProblemVId); 
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
 /// <param name = "objgs_TobeStudiedProblemVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN, string strCondition)
{
 if (objgs_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_TobeStudiedProblemVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_TobeStudiedProblemVer Set ");
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemId))
 {
 if (objgs_TobeStudiedProblemVerEN.ProblemId !=  null)
 {
 var strProblemId = objgs_TobeStudiedProblemVerEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemId = '{0}',", strProblemId); //问题Id
 }
 else
 {
 sbSQL.Append(" ProblemId = null,"); //问题Id
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.TopicId))
 {
 if (objgs_TobeStudiedProblemVerEN.TopicId !=  null)
 {
 var strTopicId = objgs_TobeStudiedProblemVerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objgs_TobeStudiedProblemVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemContent))
 {
 if (objgs_TobeStudiedProblemVerEN.ProblemContent !=  null)
 {
 var strProblemContent = objgs_TobeStudiedProblemVerEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemContent = '{0}',", strProblemContent); //问题内容
 }
 else
 {
 sbSQL.Append(" ProblemContent = null,"); //问题内容
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemDate))
 {
 if (objgs_TobeStudiedProblemVerEN.ProblemDate !=  null)
 {
 var strProblemDate = objgs_TobeStudiedProblemVerEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemDate = '{0}',", strProblemDate); //问题日期
 }
 else
 {
 sbSQL.Append(" ProblemDate = null,"); //问题日期
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Participant))
 {
 if (objgs_TobeStudiedProblemVerEN.Participant !=  null)
 {
 var strParticipant = objgs_TobeStudiedProblemVerEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Participant = '{0}',", strParticipant); //参与者
 }
 else
 {
 sbSQL.Append(" Participant = null,"); //参与者
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.UpdDate))
 {
 if (objgs_TobeStudiedProblemVerEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_TobeStudiedProblemVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.UpdUser))
 {
 if (objgs_TobeStudiedProblemVerEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_TobeStudiedProblemVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Year))
 {
 if (objgs_TobeStudiedProblemVerEN.Year !=  null)
 {
 var strYear = objgs_TobeStudiedProblemVerEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Year = '{0}',", strYear); //年
 }
 else
 {
 sbSQL.Append(" Year = null,"); //年
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Month))
 {
 if (objgs_TobeStudiedProblemVerEN.Month !=  null)
 {
 var strMonth = objgs_TobeStudiedProblemVerEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Month = '{0}',", strMonth); //月
 }
 else
 {
 sbSQL.Append(" Month = null,"); //月
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Memo))
 {
 if (objgs_TobeStudiedProblemVerEN.Memo !=  null)
 {
 var strMemo = objgs_TobeStudiedProblemVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemTitle))
 {
 if (objgs_TobeStudiedProblemVerEN.ProblemTitle !=  null)
 {
 var strProblemTitle = objgs_TobeStudiedProblemVerEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemTitle = '{0}',", strProblemTitle); //问题标题
 }
 else
 {
 sbSQL.Append(" ProblemTitle = null,"); //问题标题
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
 /// <param name = "objgs_TobeStudiedProblemVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_TobeStudiedProblemVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_TobeStudiedProblemVer Set ");
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemId))
 {
 if (objgs_TobeStudiedProblemVerEN.ProblemId !=  null)
 {
 var strProblemId = objgs_TobeStudiedProblemVerEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemId = '{0}',", strProblemId); //问题Id
 }
 else
 {
 sbSQL.Append(" ProblemId = null,"); //问题Id
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.TopicId))
 {
 if (objgs_TobeStudiedProblemVerEN.TopicId !=  null)
 {
 var strTopicId = objgs_TobeStudiedProblemVerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objgs_TobeStudiedProblemVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemContent))
 {
 if (objgs_TobeStudiedProblemVerEN.ProblemContent !=  null)
 {
 var strProblemContent = objgs_TobeStudiedProblemVerEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemContent = '{0}',", strProblemContent); //问题内容
 }
 else
 {
 sbSQL.Append(" ProblemContent = null,"); //问题内容
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemDate))
 {
 if (objgs_TobeStudiedProblemVerEN.ProblemDate !=  null)
 {
 var strProblemDate = objgs_TobeStudiedProblemVerEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemDate = '{0}',", strProblemDate); //问题日期
 }
 else
 {
 sbSQL.Append(" ProblemDate = null,"); //问题日期
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Participant))
 {
 if (objgs_TobeStudiedProblemVerEN.Participant !=  null)
 {
 var strParticipant = objgs_TobeStudiedProblemVerEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Participant = '{0}',", strParticipant); //参与者
 }
 else
 {
 sbSQL.Append(" Participant = null,"); //参与者
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.UpdDate))
 {
 if (objgs_TobeStudiedProblemVerEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_TobeStudiedProblemVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.UpdUser))
 {
 if (objgs_TobeStudiedProblemVerEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_TobeStudiedProblemVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Year))
 {
 if (objgs_TobeStudiedProblemVerEN.Year !=  null)
 {
 var strYear = objgs_TobeStudiedProblemVerEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Year = '{0}',", strYear); //年
 }
 else
 {
 sbSQL.Append(" Year = null,"); //年
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Month))
 {
 if (objgs_TobeStudiedProblemVerEN.Month !=  null)
 {
 var strMonth = objgs_TobeStudiedProblemVerEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Month = '{0}',", strMonth); //月
 }
 else
 {
 sbSQL.Append(" Month = null,"); //月
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Memo))
 {
 if (objgs_TobeStudiedProblemVerEN.Memo !=  null)
 {
 var strMemo = objgs_TobeStudiedProblemVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemTitle))
 {
 if (objgs_TobeStudiedProblemVerEN.ProblemTitle !=  null)
 {
 var strProblemTitle = objgs_TobeStudiedProblemVerEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemTitle = '{0}',", strProblemTitle); //问题标题
 }
 else
 {
 sbSQL.Append(" ProblemTitle = null,"); //问题标题
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
 /// <param name = "objgs_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_TobeStudiedProblemVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_TobeStudiedProblemVer Set ");
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemId))
 {
 if (objgs_TobeStudiedProblemVerEN.ProblemId !=  null)
 {
 var strProblemId = objgs_TobeStudiedProblemVerEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemId, congs_TobeStudiedProblemVer.ProblemId); //问题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.ProblemId); //问题Id
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.TopicId))
 {
 if (objgs_TobeStudiedProblemVerEN.TopicId !=  null)
 {
 var strTopicId = objgs_TobeStudiedProblemVerEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, congs_TobeStudiedProblemVer.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.TopicId); //主题Id
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_TobeStudiedProblemVerEN.IsSubmit == true?"1":"0", congs_TobeStudiedProblemVer.IsSubmit); //是否提交
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemContent))
 {
 if (objgs_TobeStudiedProblemVerEN.ProblemContent !=  null)
 {
 var strProblemContent = objgs_TobeStudiedProblemVerEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemContent, congs_TobeStudiedProblemVer.ProblemContent); //问题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.ProblemContent); //问题内容
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemDate))
 {
 if (objgs_TobeStudiedProblemVerEN.ProblemDate !=  null)
 {
 var strProblemDate = objgs_TobeStudiedProblemVerEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemDate, congs_TobeStudiedProblemVer.ProblemDate); //问题日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.ProblemDate); //问题日期
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Participant))
 {
 if (objgs_TobeStudiedProblemVerEN.Participant !=  null)
 {
 var strParticipant = objgs_TobeStudiedProblemVerEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParticipant, congs_TobeStudiedProblemVer.Participant); //参与者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.Participant); //参与者
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.UpdDate))
 {
 if (objgs_TobeStudiedProblemVerEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_TobeStudiedProblemVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_TobeStudiedProblemVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.UpdDate); //修改日期
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.UpdUser))
 {
 if (objgs_TobeStudiedProblemVerEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_TobeStudiedProblemVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_TobeStudiedProblemVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.UpdUser); //修改人
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Year))
 {
 if (objgs_TobeStudiedProblemVerEN.Year !=  null)
 {
 var strYear = objgs_TobeStudiedProblemVerEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYear, congs_TobeStudiedProblemVer.Year); //年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.Year); //年
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Month))
 {
 if (objgs_TobeStudiedProblemVerEN.Month !=  null)
 {
 var strMonth = objgs_TobeStudiedProblemVerEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMonth, congs_TobeStudiedProblemVer.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.Month); //月
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.Memo))
 {
 if (objgs_TobeStudiedProblemVerEN.Memo !=  null)
 {
 var strMemo = objgs_TobeStudiedProblemVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_TobeStudiedProblemVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.Memo); //备注
 }
 }
 
 if (objgs_TobeStudiedProblemVerEN.IsUpdated(congs_TobeStudiedProblemVer.ProblemTitle))
 {
 if (objgs_TobeStudiedProblemVerEN.ProblemTitle !=  null)
 {
 var strProblemTitle = objgs_TobeStudiedProblemVerEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemTitle, congs_TobeStudiedProblemVer.ProblemTitle); //问题标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_TobeStudiedProblemVer.ProblemTitle); //问题标题
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ProblemVId = {0}", objgs_TobeStudiedProblemVerEN.ProblemVId); 
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
 /// <param name = "lngProblemVId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngProblemVId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngProblemVId,
};
 objSQL.ExecSP("gs_TobeStudiedProblemVer_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngProblemVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngProblemVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
//删除gs_TobeStudiedProblemVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_TobeStudiedProblemVer where ProblemVId = " + ""+ lngProblemVId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delgs_TobeStudiedProblemVer(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
//删除gs_TobeStudiedProblemVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_TobeStudiedProblemVer where ProblemVId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngProblemVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngProblemVId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
//删除gs_TobeStudiedProblemVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_TobeStudiedProblemVer where ProblemVId = " + ""+ lngProblemVId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delgs_TobeStudiedProblemVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemVerDA: Delgs_TobeStudiedProblemVer)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_TobeStudiedProblemVer where " + strCondition ;
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
public bool Delgs_TobeStudiedProblemVerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsgs_TobeStudiedProblemVerDA: Delgs_TobeStudiedProblemVerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_TobeStudiedProblemVer where " + strCondition ;
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
 /// <param name = "objgs_TobeStudiedProblemVerENS">源对象</param>
 /// <param name = "objgs_TobeStudiedProblemVerENT">目标对象</param>
public void CopyTo(clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerENS, clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerENT)
{
objgs_TobeStudiedProblemVerENT.ProblemVId = objgs_TobeStudiedProblemVerENS.ProblemVId; //ProblemVId
objgs_TobeStudiedProblemVerENT.ProblemId = objgs_TobeStudiedProblemVerENS.ProblemId; //问题Id
objgs_TobeStudiedProblemVerENT.TopicId = objgs_TobeStudiedProblemVerENS.TopicId; //主题Id
objgs_TobeStudiedProblemVerENT.IsSubmit = objgs_TobeStudiedProblemVerENS.IsSubmit; //是否提交
objgs_TobeStudiedProblemVerENT.ProblemContent = objgs_TobeStudiedProblemVerENS.ProblemContent; //问题内容
objgs_TobeStudiedProblemVerENT.ProblemDate = objgs_TobeStudiedProblemVerENS.ProblemDate; //问题日期
objgs_TobeStudiedProblemVerENT.Participant = objgs_TobeStudiedProblemVerENS.Participant; //参与者
objgs_TobeStudiedProblemVerENT.UpdDate = objgs_TobeStudiedProblemVerENS.UpdDate; //修改日期
objgs_TobeStudiedProblemVerENT.UpdUser = objgs_TobeStudiedProblemVerENS.UpdUser; //修改人
objgs_TobeStudiedProblemVerENT.Year = objgs_TobeStudiedProblemVerENS.Year; //年
objgs_TobeStudiedProblemVerENT.Month = objgs_TobeStudiedProblemVerENS.Month; //月
objgs_TobeStudiedProblemVerENT.Memo = objgs_TobeStudiedProblemVerENS.Memo; //备注
objgs_TobeStudiedProblemVerENT.ProblemTitle = objgs_TobeStudiedProblemVerENS.ProblemTitle; //问题标题
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objgs_TobeStudiedProblemVerEN.ProblemId, congs_TobeStudiedProblemVer.ProblemId);
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.ProblemId, 10, congs_TobeStudiedProblemVer.ProblemId);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.TopicId, 8, congs_TobeStudiedProblemVer.TopicId);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.ProblemContent, 5000, congs_TobeStudiedProblemVer.ProblemContent);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.ProblemDate, 20, congs_TobeStudiedProblemVer.ProblemDate);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.Participant, 500, congs_TobeStudiedProblemVer.Participant);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.UpdDate, 20, congs_TobeStudiedProblemVer.UpdDate);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.UpdUser, 20, congs_TobeStudiedProblemVer.UpdUser);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.Year, 4, congs_TobeStudiedProblemVer.Year);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.Month, 2, congs_TobeStudiedProblemVer.Month);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.Memo, 1000, congs_TobeStudiedProblemVer.Memo);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.ProblemTitle, 1000, congs_TobeStudiedProblemVer.ProblemTitle);
//检查字段外键固定长度
 objgs_TobeStudiedProblemVerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.ProblemId, 10, congs_TobeStudiedProblemVer.ProblemId);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.TopicId, 8, congs_TobeStudiedProblemVer.TopicId);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.ProblemContent, 5000, congs_TobeStudiedProblemVer.ProblemContent);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.ProblemDate, 20, congs_TobeStudiedProblemVer.ProblemDate);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.Participant, 500, congs_TobeStudiedProblemVer.Participant);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.UpdDate, 20, congs_TobeStudiedProblemVer.UpdDate);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.UpdUser, 20, congs_TobeStudiedProblemVer.UpdUser);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.Year, 4, congs_TobeStudiedProblemVer.Year);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.Month, 2, congs_TobeStudiedProblemVer.Month);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.Memo, 1000, congs_TobeStudiedProblemVer.Memo);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.ProblemTitle, 1000, congs_TobeStudiedProblemVer.ProblemTitle);
//检查外键字段长度
 objgs_TobeStudiedProblemVerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.ProblemId, 10, congs_TobeStudiedProblemVer.ProblemId);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.TopicId, 8, congs_TobeStudiedProblemVer.TopicId);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.ProblemContent, 5000, congs_TobeStudiedProblemVer.ProblemContent);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.ProblemDate, 20, congs_TobeStudiedProblemVer.ProblemDate);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.Participant, 500, congs_TobeStudiedProblemVer.Participant);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.UpdDate, 20, congs_TobeStudiedProblemVer.UpdDate);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.UpdUser, 20, congs_TobeStudiedProblemVer.UpdUser);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.Year, 4, congs_TobeStudiedProblemVer.Year);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.Month, 2, congs_TobeStudiedProblemVer.Month);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.Memo, 1000, congs_TobeStudiedProblemVer.Memo);
clsCheckSql.CheckFieldLen(objgs_TobeStudiedProblemVerEN.ProblemTitle, 1000, congs_TobeStudiedProblemVer.ProblemTitle);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemVerEN.ProblemId, congs_TobeStudiedProblemVer.ProblemId);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemVerEN.TopicId, congs_TobeStudiedProblemVer.TopicId);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemVerEN.ProblemContent, congs_TobeStudiedProblemVer.ProblemContent);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemVerEN.ProblemDate, congs_TobeStudiedProblemVer.ProblemDate);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemVerEN.Participant, congs_TobeStudiedProblemVer.Participant);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemVerEN.UpdDate, congs_TobeStudiedProblemVer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemVerEN.UpdUser, congs_TobeStudiedProblemVer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemVerEN.Year, congs_TobeStudiedProblemVer.Year);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemVerEN.Month, congs_TobeStudiedProblemVer.Month);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemVerEN.Memo, congs_TobeStudiedProblemVer.Memo);
clsCheckSql.CheckSqlInjection4Field(objgs_TobeStudiedProblemVerEN.ProblemTitle, congs_TobeStudiedProblemVer.ProblemTitle);
//检查外键字段长度
 objgs_TobeStudiedProblemVerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--gs_TobeStudiedProblemVer(待研究问题历史版本表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemVerEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsgs_TobeStudiedProblemVerEN objgs_TobeStudiedProblemVerEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ProblemVId = '{0}'", objgs_TobeStudiedProblemVerEN.ProblemVId);
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
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_TobeStudiedProblemVerEN._CurrTabName);
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
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_TobeStudiedProblemVerEN._CurrTabName, strCondition);
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
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
 objSQL = clsgs_TobeStudiedProblemVerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}