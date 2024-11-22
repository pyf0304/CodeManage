
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_OriginalPaperLogDA
 表名:gs_OriginalPaperLog(01120680)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 论文日志表(gs_OriginalPaperLog)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsgs_OriginalPaperLogDA : clsCommBase4DA
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
 return clsgs_OriginalPaperLogEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsgs_OriginalPaperLogEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_OriginalPaperLogEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsgs_OriginalPaperLogEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsgs_OriginalPaperLogEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsgs_OriginalPaperLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
strSQL = "Select * from gs_OriginalPaperLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_gs_OriginalPaperLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsgs_OriginalPaperLogDA: GetDataTable_gs_OriginalPaperLog)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
strSQL = "Select * from gs_OriginalPaperLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsgs_OriginalPaperLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsgs_OriginalPaperLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
strSQL = "Select * from gs_OriginalPaperLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsgs_OriginalPaperLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsgs_OriginalPaperLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_OriginalPaperLog where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_OriginalPaperLog where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsgs_OriginalPaperLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from gs_OriginalPaperLog where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsgs_OriginalPaperLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_OriginalPaperLog.* from gs_OriginalPaperLog Left Join {1} on {2} where {3} and gs_OriginalPaperLog.PaperLogId not in (Select top {5} gs_OriginalPaperLog.PaperLogId from gs_OriginalPaperLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_OriginalPaperLog where {1} and PaperLogId not in (Select top {2} PaperLogId from gs_OriginalPaperLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_OriginalPaperLog where {1} and PaperLogId not in (Select top {3} PaperLogId from gs_OriginalPaperLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsgs_OriginalPaperLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_OriginalPaperLog.* from gs_OriginalPaperLog Left Join {1} on {2} where {3} and gs_OriginalPaperLog.PaperLogId not in (Select top {5} gs_OriginalPaperLog.PaperLogId from gs_OriginalPaperLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_OriginalPaperLog where {1} and PaperLogId not in (Select top {2} PaperLogId from gs_OriginalPaperLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_OriginalPaperLog where {1} and PaperLogId not in (Select top {3} PaperLogId from gs_OriginalPaperLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsgs_OriginalPaperLogEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsgs_OriginalPaperLogDA:GetObjLst)", objException.Message));
}
List<clsgs_OriginalPaperLogEN> arrObjLst = new List<clsgs_OriginalPaperLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
strSQL = "Select * from gs_OriginalPaperLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN = new clsgs_OriginalPaperLogEN();
try
{
objgs_OriginalPaperLogEN.PaperLogId = TransNullToInt(objRow[congs_OriginalPaperLog.PaperLogId].ToString().Trim()); //论文日志Id
objgs_OriginalPaperLogEN.PaperId = objRow[congs_OriginalPaperLog.PaperId] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.PaperId].ToString().Trim(); //论文Id
objgs_OriginalPaperLogEN.LogTypeId = objRow[congs_OriginalPaperLog.LogTypeId].ToString().Trim(); //日志类型Id
objgs_OriginalPaperLogEN.LogDescription = objRow[congs_OriginalPaperLog.LogDescription] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.LogDescription].ToString().Trim(); //日志描述
objgs_OriginalPaperLogEN.UpdUser = objRow[congs_OriginalPaperLog.UpdUser] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.UpdUser].ToString().Trim(); //修改人
objgs_OriginalPaperLogEN.UpdDate = objRow[congs_OriginalPaperLog.UpdDate] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.UpdDate].ToString().Trim(); //修改日期
objgs_OriginalPaperLogEN.Memo = objRow[congs_OriginalPaperLog.Memo] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_OriginalPaperLogDA: GetObjLst)", objException.Message));
}
objgs_OriginalPaperLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_OriginalPaperLogEN);
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
public List<clsgs_OriginalPaperLogEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsgs_OriginalPaperLogDA:GetObjLstByTabName)", objException.Message));
}
List<clsgs_OriginalPaperLogEN> arrObjLst = new List<clsgs_OriginalPaperLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN = new clsgs_OriginalPaperLogEN();
try
{
objgs_OriginalPaperLogEN.PaperLogId = TransNullToInt(objRow[congs_OriginalPaperLog.PaperLogId].ToString().Trim()); //论文日志Id
objgs_OriginalPaperLogEN.PaperId = objRow[congs_OriginalPaperLog.PaperId] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.PaperId].ToString().Trim(); //论文Id
objgs_OriginalPaperLogEN.LogTypeId = objRow[congs_OriginalPaperLog.LogTypeId].ToString().Trim(); //日志类型Id
objgs_OriginalPaperLogEN.LogDescription = objRow[congs_OriginalPaperLog.LogDescription] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.LogDescription].ToString().Trim(); //日志描述
objgs_OriginalPaperLogEN.UpdUser = objRow[congs_OriginalPaperLog.UpdUser] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.UpdUser].ToString().Trim(); //修改人
objgs_OriginalPaperLogEN.UpdDate = objRow[congs_OriginalPaperLog.UpdDate] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.UpdDate].ToString().Trim(); //修改日期
objgs_OriginalPaperLogEN.Memo = objRow[congs_OriginalPaperLog.Memo] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_OriginalPaperLogDA: GetObjLst)", objException.Message));
}
objgs_OriginalPaperLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_OriginalPaperLogEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getgs_OriginalPaperLog(ref clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
strSQL = "Select * from gs_OriginalPaperLog where PaperLogId = " + ""+ objgs_OriginalPaperLogEN.PaperLogId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objgs_OriginalPaperLogEN.PaperLogId = TransNullToInt(objDT.Rows[0][congs_OriginalPaperLog.PaperLogId].ToString().Trim()); //论文日志Id(字段类型:bigint,字段长度:8,是否可空:False)
 objgs_OriginalPaperLogEN.PaperId = objDT.Rows[0][congs_OriginalPaperLog.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_OriginalPaperLogEN.LogTypeId = objDT.Rows[0][congs_OriginalPaperLog.LogTypeId].ToString().Trim(); //日志类型Id(字段类型:char,字段长度:2,是否可空:False)
 objgs_OriginalPaperLogEN.LogDescription = objDT.Rows[0][congs_OriginalPaperLog.LogDescription].ToString().Trim(); //日志描述(字段类型:varchar,字段长度:500,是否可空:True)
 objgs_OriginalPaperLogEN.UpdUser = objDT.Rows[0][congs_OriginalPaperLog.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_OriginalPaperLogEN.UpdDate = objDT.Rows[0][congs_OriginalPaperLog.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_OriginalPaperLogEN.Memo = objDT.Rows[0][congs_OriginalPaperLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsgs_OriginalPaperLogDA: Getgs_OriginalPaperLog)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPaperLogId">表关键字</param>
 /// <returns>表对象</returns>
public clsgs_OriginalPaperLogEN GetObjByPaperLogId(long lngPaperLogId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
strSQL = "Select * from gs_OriginalPaperLog where PaperLogId = " + ""+ lngPaperLogId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN = new clsgs_OriginalPaperLogEN();
try
{
 objgs_OriginalPaperLogEN.PaperLogId = Int32.Parse(objRow[congs_OriginalPaperLog.PaperLogId].ToString().Trim()); //论文日志Id(字段类型:bigint,字段长度:8,是否可空:False)
 objgs_OriginalPaperLogEN.PaperId = objRow[congs_OriginalPaperLog.PaperId] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_OriginalPaperLogEN.LogTypeId = objRow[congs_OriginalPaperLog.LogTypeId].ToString().Trim(); //日志类型Id(字段类型:char,字段长度:2,是否可空:False)
 objgs_OriginalPaperLogEN.LogDescription = objRow[congs_OriginalPaperLog.LogDescription] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.LogDescription].ToString().Trim(); //日志描述(字段类型:varchar,字段长度:500,是否可空:True)
 objgs_OriginalPaperLogEN.UpdUser = objRow[congs_OriginalPaperLog.UpdUser] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_OriginalPaperLogEN.UpdDate = objRow[congs_OriginalPaperLog.UpdDate] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_OriginalPaperLogEN.Memo = objRow[congs_OriginalPaperLog.Memo] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsgs_OriginalPaperLogDA: GetObjByPaperLogId)", objException.Message));
}
return objgs_OriginalPaperLogEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsgs_OriginalPaperLogEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsgs_OriginalPaperLogDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
strSQL = "Select * from gs_OriginalPaperLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN = new clsgs_OriginalPaperLogEN()
{
PaperLogId = TransNullToInt(objRow[congs_OriginalPaperLog.PaperLogId].ToString().Trim()), //论文日志Id
PaperId = objRow[congs_OriginalPaperLog.PaperId] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.PaperId].ToString().Trim(), //论文Id
LogTypeId = objRow[congs_OriginalPaperLog.LogTypeId].ToString().Trim(), //日志类型Id
LogDescription = objRow[congs_OriginalPaperLog.LogDescription] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.LogDescription].ToString().Trim(), //日志描述
UpdUser = objRow[congs_OriginalPaperLog.UpdUser] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[congs_OriginalPaperLog.UpdDate] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[congs_OriginalPaperLog.Memo] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.Memo].ToString().Trim() //备注
};
objgs_OriginalPaperLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_OriginalPaperLogEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsgs_OriginalPaperLogDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsgs_OriginalPaperLogEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN = new clsgs_OriginalPaperLogEN();
try
{
objgs_OriginalPaperLogEN.PaperLogId = TransNullToInt(objRow[congs_OriginalPaperLog.PaperLogId].ToString().Trim()); //论文日志Id
objgs_OriginalPaperLogEN.PaperId = objRow[congs_OriginalPaperLog.PaperId] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.PaperId].ToString().Trim(); //论文Id
objgs_OriginalPaperLogEN.LogTypeId = objRow[congs_OriginalPaperLog.LogTypeId].ToString().Trim(); //日志类型Id
objgs_OriginalPaperLogEN.LogDescription = objRow[congs_OriginalPaperLog.LogDescription] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.LogDescription].ToString().Trim(); //日志描述
objgs_OriginalPaperLogEN.UpdUser = objRow[congs_OriginalPaperLog.UpdUser] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.UpdUser].ToString().Trim(); //修改人
objgs_OriginalPaperLogEN.UpdDate = objRow[congs_OriginalPaperLog.UpdDate] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.UpdDate].ToString().Trim(); //修改日期
objgs_OriginalPaperLogEN.Memo = objRow[congs_OriginalPaperLog.Memo] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsgs_OriginalPaperLogDA: GetObjByDataRowgs_OriginalPaperLog)", objException.Message));
}
objgs_OriginalPaperLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_OriginalPaperLogEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsgs_OriginalPaperLogEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN = new clsgs_OriginalPaperLogEN();
try
{
objgs_OriginalPaperLogEN.PaperLogId = TransNullToInt(objRow[congs_OriginalPaperLog.PaperLogId].ToString().Trim()); //论文日志Id
objgs_OriginalPaperLogEN.PaperId = objRow[congs_OriginalPaperLog.PaperId] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.PaperId].ToString().Trim(); //论文Id
objgs_OriginalPaperLogEN.LogTypeId = objRow[congs_OriginalPaperLog.LogTypeId].ToString().Trim(); //日志类型Id
objgs_OriginalPaperLogEN.LogDescription = objRow[congs_OriginalPaperLog.LogDescription] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.LogDescription].ToString().Trim(); //日志描述
objgs_OriginalPaperLogEN.UpdUser = objRow[congs_OriginalPaperLog.UpdUser] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.UpdUser].ToString().Trim(); //修改人
objgs_OriginalPaperLogEN.UpdDate = objRow[congs_OriginalPaperLog.UpdDate] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.UpdDate].ToString().Trim(); //修改日期
objgs_OriginalPaperLogEN.Memo = objRow[congs_OriginalPaperLog.Memo] == DBNull.Value ? null : objRow[congs_OriginalPaperLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsgs_OriginalPaperLogDA: GetObjByDataRow)", objException.Message));
}
objgs_OriginalPaperLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_OriginalPaperLogEN;
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
objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_OriginalPaperLogEN._CurrTabName, congs_OriginalPaperLog.PaperLogId, 8, "");
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
objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_OriginalPaperLogEN._CurrTabName, congs_OriginalPaperLog.PaperLogId, 8, strPrefix);
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
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PaperLogId from gs_OriginalPaperLog where " + strCondition;
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
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PaperLogId from gs_OriginalPaperLog where " + strCondition;
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
 /// <param name = "lngPaperLogId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngPaperLogId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_OriginalPaperLog", "PaperLogId = " + ""+ lngPaperLogId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsgs_OriginalPaperLogDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_OriginalPaperLog", strCondition))
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
objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("gs_OriginalPaperLog");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN)
 {
 if (objgs_OriginalPaperLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_OriginalPaperLogEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
strSQL = "Select * from gs_OriginalPaperLog where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_OriginalPaperLog");
objRow = objDS.Tables["gs_OriginalPaperLog"].NewRow();
 if (objgs_OriginalPaperLogEN.PaperId !=  "")
 {
objRow[congs_OriginalPaperLog.PaperId] = objgs_OriginalPaperLogEN.PaperId; //论文Id
 }
objRow[congs_OriginalPaperLog.LogTypeId] = objgs_OriginalPaperLogEN.LogTypeId; //日志类型Id
 if (objgs_OriginalPaperLogEN.LogDescription !=  "")
 {
objRow[congs_OriginalPaperLog.LogDescription] = objgs_OriginalPaperLogEN.LogDescription; //日志描述
 }
 if (objgs_OriginalPaperLogEN.UpdUser !=  "")
 {
objRow[congs_OriginalPaperLog.UpdUser] = objgs_OriginalPaperLogEN.UpdUser; //修改人
 }
 if (objgs_OriginalPaperLogEN.UpdDate !=  "")
 {
objRow[congs_OriginalPaperLog.UpdDate] = objgs_OriginalPaperLogEN.UpdDate; //修改日期
 }
 if (objgs_OriginalPaperLogEN.Memo !=  "")
 {
objRow[congs_OriginalPaperLog.Memo] = objgs_OriginalPaperLogEN.Memo; //备注
 }
objDS.Tables[clsgs_OriginalPaperLogEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsgs_OriginalPaperLogEN._CurrTabName);
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
 /// <param name = "objgs_OriginalPaperLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN)
{
 if (objgs_OriginalPaperLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_OriginalPaperLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_OriginalPaperLogEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.PaperId);
 var strPaperId = objgs_OriginalPaperLogEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_OriginalPaperLogEN.LogTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.LogTypeId);
 var strLogTypeId = objgs_OriginalPaperLogEN.LogTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogTypeId + "'");
 }
 
 if (objgs_OriginalPaperLogEN.LogDescription !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.LogDescription);
 var strLogDescription = objgs_OriginalPaperLogEN.LogDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogDescription + "'");
 }
 
 if (objgs_OriginalPaperLogEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.UpdUser);
 var strUpdUser = objgs_OriginalPaperLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_OriginalPaperLogEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.UpdDate);
 var strUpdDate = objgs_OriginalPaperLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_OriginalPaperLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.Memo);
 var strMemo = objgs_OriginalPaperLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_OriginalPaperLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN)
{
 if (objgs_OriginalPaperLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_OriginalPaperLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_OriginalPaperLogEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.PaperId);
 var strPaperId = objgs_OriginalPaperLogEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_OriginalPaperLogEN.LogTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.LogTypeId);
 var strLogTypeId = objgs_OriginalPaperLogEN.LogTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogTypeId + "'");
 }
 
 if (objgs_OriginalPaperLogEN.LogDescription !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.LogDescription);
 var strLogDescription = objgs_OriginalPaperLogEN.LogDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogDescription + "'");
 }
 
 if (objgs_OriginalPaperLogEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.UpdUser);
 var strUpdUser = objgs_OriginalPaperLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_OriginalPaperLogEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.UpdDate);
 var strUpdDate = objgs_OriginalPaperLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_OriginalPaperLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.Memo);
 var strMemo = objgs_OriginalPaperLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_OriginalPaperLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_OriginalPaperLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_OriginalPaperLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_OriginalPaperLogEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.PaperId);
 var strPaperId = objgs_OriginalPaperLogEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_OriginalPaperLogEN.LogTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.LogTypeId);
 var strLogTypeId = objgs_OriginalPaperLogEN.LogTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogTypeId + "'");
 }
 
 if (objgs_OriginalPaperLogEN.LogDescription !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.LogDescription);
 var strLogDescription = objgs_OriginalPaperLogEN.LogDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogDescription + "'");
 }
 
 if (objgs_OriginalPaperLogEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.UpdUser);
 var strUpdUser = objgs_OriginalPaperLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_OriginalPaperLogEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.UpdDate);
 var strUpdDate = objgs_OriginalPaperLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_OriginalPaperLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.Memo);
 var strMemo = objgs_OriginalPaperLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_OriginalPaperLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_OriginalPaperLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_OriginalPaperLogEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_OriginalPaperLogEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.PaperId);
 var strPaperId = objgs_OriginalPaperLogEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objgs_OriginalPaperLogEN.LogTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.LogTypeId);
 var strLogTypeId = objgs_OriginalPaperLogEN.LogTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogTypeId + "'");
 }
 
 if (objgs_OriginalPaperLogEN.LogDescription !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.LogDescription);
 var strLogDescription = objgs_OriginalPaperLogEN.LogDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogDescription + "'");
 }
 
 if (objgs_OriginalPaperLogEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.UpdUser);
 var strUpdUser = objgs_OriginalPaperLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_OriginalPaperLogEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.UpdDate);
 var strUpdDate = objgs_OriginalPaperLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_OriginalPaperLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_OriginalPaperLog.Memo);
 var strMemo = objgs_OriginalPaperLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_OriginalPaperLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewgs_OriginalPaperLogs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
strSQL = "Select * from gs_OriginalPaperLog where PaperLogId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_OriginalPaperLog");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngPaperLogId = TransNullToInt(oRow[congs_OriginalPaperLog.PaperLogId].ToString().Trim());
if (IsExist(lngPaperLogId))
{
 string strResult = "关键字变量值为:" + string.Format("PaperLogId = {0}", lngPaperLogId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsgs_OriginalPaperLogEN._CurrTabName ].NewRow();
objRow[congs_OriginalPaperLog.PaperId] = oRow[congs_OriginalPaperLog.PaperId].ToString().Trim(); //论文Id
objRow[congs_OriginalPaperLog.LogTypeId] = oRow[congs_OriginalPaperLog.LogTypeId].ToString().Trim(); //日志类型Id
objRow[congs_OriginalPaperLog.LogDescription] = oRow[congs_OriginalPaperLog.LogDescription].ToString().Trim(); //日志描述
objRow[congs_OriginalPaperLog.UpdUser] = oRow[congs_OriginalPaperLog.UpdUser].ToString().Trim(); //修改人
objRow[congs_OriginalPaperLog.UpdDate] = oRow[congs_OriginalPaperLog.UpdDate].ToString().Trim(); //修改日期
objRow[congs_OriginalPaperLog.Memo] = oRow[congs_OriginalPaperLog.Memo].ToString().Trim(); //备注
 objDS.Tables[clsgs_OriginalPaperLogEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsgs_OriginalPaperLogEN._CurrTabName);
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
 /// <param name = "objgs_OriginalPaperLogEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN)
{
 if (objgs_OriginalPaperLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_OriginalPaperLogEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
strSQL = "Select * from gs_OriginalPaperLog where PaperLogId = " + ""+ objgs_OriginalPaperLogEN.PaperLogId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsgs_OriginalPaperLogEN._CurrTabName);
if (objDS.Tables[clsgs_OriginalPaperLogEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PaperLogId = " + ""+ objgs_OriginalPaperLogEN.PaperLogId+"");
return false;
}
objRow = objDS.Tables[clsgs_OriginalPaperLogEN._CurrTabName].Rows[0];
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.PaperId))
 {
objRow[congs_OriginalPaperLog.PaperId] = objgs_OriginalPaperLogEN.PaperId; //论文Id
 }
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.LogTypeId))
 {
objRow[congs_OriginalPaperLog.LogTypeId] = objgs_OriginalPaperLogEN.LogTypeId; //日志类型Id
 }
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.LogDescription))
 {
objRow[congs_OriginalPaperLog.LogDescription] = objgs_OriginalPaperLogEN.LogDescription; //日志描述
 }
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.UpdUser))
 {
objRow[congs_OriginalPaperLog.UpdUser] = objgs_OriginalPaperLogEN.UpdUser; //修改人
 }
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.UpdDate))
 {
objRow[congs_OriginalPaperLog.UpdDate] = objgs_OriginalPaperLogEN.UpdDate; //修改日期
 }
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.Memo))
 {
objRow[congs_OriginalPaperLog.Memo] = objgs_OriginalPaperLogEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsgs_OriginalPaperLogEN._CurrTabName);
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
 /// <param name = "objgs_OriginalPaperLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN)
{
 if (objgs_OriginalPaperLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_OriginalPaperLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update gs_OriginalPaperLog Set ");
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.PaperId))
 {
 if (objgs_OriginalPaperLogEN.PaperId !=  null)
 {
 var strPaperId = objgs_OriginalPaperLogEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, congs_OriginalPaperLog.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_OriginalPaperLog.PaperId); //论文Id
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.LogTypeId))
 {
 if (objgs_OriginalPaperLogEN.LogTypeId !=  null)
 {
 var strLogTypeId = objgs_OriginalPaperLogEN.LogTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLogTypeId, congs_OriginalPaperLog.LogTypeId); //日志类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_OriginalPaperLog.LogTypeId); //日志类型Id
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.LogDescription))
 {
 if (objgs_OriginalPaperLogEN.LogDescription !=  null)
 {
 var strLogDescription = objgs_OriginalPaperLogEN.LogDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLogDescription, congs_OriginalPaperLog.LogDescription); //日志描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_OriginalPaperLog.LogDescription); //日志描述
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.UpdUser))
 {
 if (objgs_OriginalPaperLogEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_OriginalPaperLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_OriginalPaperLog.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_OriginalPaperLog.UpdUser); //修改人
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.UpdDate))
 {
 if (objgs_OriginalPaperLogEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_OriginalPaperLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_OriginalPaperLog.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_OriginalPaperLog.UpdDate); //修改日期
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.Memo))
 {
 if (objgs_OriginalPaperLogEN.Memo !=  null)
 {
 var strMemo = objgs_OriginalPaperLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_OriginalPaperLog.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_OriginalPaperLog.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PaperLogId = {0}", objgs_OriginalPaperLogEN.PaperLogId); 
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
 /// <param name = "objgs_OriginalPaperLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN, string strCondition)
{
 if (objgs_OriginalPaperLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_OriginalPaperLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_OriginalPaperLog Set ");
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.PaperId))
 {
 if (objgs_OriginalPaperLogEN.PaperId !=  null)
 {
 var strPaperId = objgs_OriginalPaperLogEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.LogTypeId))
 {
 if (objgs_OriginalPaperLogEN.LogTypeId !=  null)
 {
 var strLogTypeId = objgs_OriginalPaperLogEN.LogTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LogTypeId = '{0}',", strLogTypeId); //日志类型Id
 }
 else
 {
 sbSQL.Append(" LogTypeId = null,"); //日志类型Id
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.LogDescription))
 {
 if (objgs_OriginalPaperLogEN.LogDescription !=  null)
 {
 var strLogDescription = objgs_OriginalPaperLogEN.LogDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LogDescription = '{0}',", strLogDescription); //日志描述
 }
 else
 {
 sbSQL.Append(" LogDescription = null,"); //日志描述
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.UpdUser))
 {
 if (objgs_OriginalPaperLogEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_OriginalPaperLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.UpdDate))
 {
 if (objgs_OriginalPaperLogEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_OriginalPaperLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.Memo))
 {
 if (objgs_OriginalPaperLogEN.Memo !=  null)
 {
 var strMemo = objgs_OriginalPaperLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objgs_OriginalPaperLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_OriginalPaperLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_OriginalPaperLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_OriginalPaperLog Set ");
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.PaperId))
 {
 if (objgs_OriginalPaperLogEN.PaperId !=  null)
 {
 var strPaperId = objgs_OriginalPaperLogEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.LogTypeId))
 {
 if (objgs_OriginalPaperLogEN.LogTypeId !=  null)
 {
 var strLogTypeId = objgs_OriginalPaperLogEN.LogTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LogTypeId = '{0}',", strLogTypeId); //日志类型Id
 }
 else
 {
 sbSQL.Append(" LogTypeId = null,"); //日志类型Id
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.LogDescription))
 {
 if (objgs_OriginalPaperLogEN.LogDescription !=  null)
 {
 var strLogDescription = objgs_OriginalPaperLogEN.LogDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LogDescription = '{0}',", strLogDescription); //日志描述
 }
 else
 {
 sbSQL.Append(" LogDescription = null,"); //日志描述
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.UpdUser))
 {
 if (objgs_OriginalPaperLogEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_OriginalPaperLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.UpdDate))
 {
 if (objgs_OriginalPaperLogEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_OriginalPaperLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.Memo))
 {
 if (objgs_OriginalPaperLogEN.Memo !=  null)
 {
 var strMemo = objgs_OriginalPaperLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objgs_OriginalPaperLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_OriginalPaperLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_OriginalPaperLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_OriginalPaperLog Set ");
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.PaperId))
 {
 if (objgs_OriginalPaperLogEN.PaperId !=  null)
 {
 var strPaperId = objgs_OriginalPaperLogEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, congs_OriginalPaperLog.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_OriginalPaperLog.PaperId); //论文Id
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.LogTypeId))
 {
 if (objgs_OriginalPaperLogEN.LogTypeId !=  null)
 {
 var strLogTypeId = objgs_OriginalPaperLogEN.LogTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLogTypeId, congs_OriginalPaperLog.LogTypeId); //日志类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_OriginalPaperLog.LogTypeId); //日志类型Id
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.LogDescription))
 {
 if (objgs_OriginalPaperLogEN.LogDescription !=  null)
 {
 var strLogDescription = objgs_OriginalPaperLogEN.LogDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLogDescription, congs_OriginalPaperLog.LogDescription); //日志描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_OriginalPaperLog.LogDescription); //日志描述
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.UpdUser))
 {
 if (objgs_OriginalPaperLogEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_OriginalPaperLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_OriginalPaperLog.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_OriginalPaperLog.UpdUser); //修改人
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.UpdDate))
 {
 if (objgs_OriginalPaperLogEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_OriginalPaperLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_OriginalPaperLog.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_OriginalPaperLog.UpdDate); //修改日期
 }
 }
 
 if (objgs_OriginalPaperLogEN.IsUpdated(congs_OriginalPaperLog.Memo))
 {
 if (objgs_OriginalPaperLogEN.Memo !=  null)
 {
 var strMemo = objgs_OriginalPaperLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_OriginalPaperLog.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_OriginalPaperLog.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PaperLogId = {0}", objgs_OriginalPaperLogEN.PaperLogId); 
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
 /// <param name = "lngPaperLogId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngPaperLogId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngPaperLogId,
};
 objSQL.ExecSP("gs_OriginalPaperLog_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngPaperLogId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngPaperLogId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
//删除gs_OriginalPaperLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_OriginalPaperLog where PaperLogId = " + ""+ lngPaperLogId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delgs_OriginalPaperLog(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
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
//删除gs_OriginalPaperLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_OriginalPaperLog where PaperLogId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngPaperLogId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngPaperLogId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
//删除gs_OriginalPaperLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_OriginalPaperLog where PaperLogId = " + ""+ lngPaperLogId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delgs_OriginalPaperLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsgs_OriginalPaperLogDA: Delgs_OriginalPaperLog)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_OriginalPaperLog where " + strCondition ;
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
public bool Delgs_OriginalPaperLogWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsgs_OriginalPaperLogDA: Delgs_OriginalPaperLogWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_OriginalPaperLog where " + strCondition ;
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
 /// <param name = "objgs_OriginalPaperLogENS">源对象</param>
 /// <param name = "objgs_OriginalPaperLogENT">目标对象</param>
public void CopyTo(clsgs_OriginalPaperLogEN objgs_OriginalPaperLogENS, clsgs_OriginalPaperLogEN objgs_OriginalPaperLogENT)
{
objgs_OriginalPaperLogENT.PaperLogId = objgs_OriginalPaperLogENS.PaperLogId; //论文日志Id
objgs_OriginalPaperLogENT.PaperId = objgs_OriginalPaperLogENS.PaperId; //论文Id
objgs_OriginalPaperLogENT.LogTypeId = objgs_OriginalPaperLogENS.LogTypeId; //日志类型Id
objgs_OriginalPaperLogENT.LogDescription = objgs_OriginalPaperLogENS.LogDescription; //日志描述
objgs_OriginalPaperLogENT.UpdUser = objgs_OriginalPaperLogENS.UpdUser; //修改人
objgs_OriginalPaperLogENT.UpdDate = objgs_OriginalPaperLogENS.UpdDate; //修改日期
objgs_OriginalPaperLogENT.Memo = objgs_OriginalPaperLogENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objgs_OriginalPaperLogEN.LogTypeId, congs_OriginalPaperLog.LogTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.PaperId, 8, congs_OriginalPaperLog.PaperId);
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.LogTypeId, 2, congs_OriginalPaperLog.LogTypeId);
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.LogDescription, 500, congs_OriginalPaperLog.LogDescription);
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.UpdUser, 20, congs_OriginalPaperLog.UpdUser);
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.UpdDate, 20, congs_OriginalPaperLog.UpdDate);
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.Memo, 1000, congs_OriginalPaperLog.Memo);
//检查字段外键固定长度
 objgs_OriginalPaperLogEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.PaperId, 8, congs_OriginalPaperLog.PaperId);
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.LogTypeId, 2, congs_OriginalPaperLog.LogTypeId);
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.LogDescription, 500, congs_OriginalPaperLog.LogDescription);
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.UpdUser, 20, congs_OriginalPaperLog.UpdUser);
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.UpdDate, 20, congs_OriginalPaperLog.UpdDate);
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.Memo, 1000, congs_OriginalPaperLog.Memo);
//检查外键字段长度
 objgs_OriginalPaperLogEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.PaperId, 8, congs_OriginalPaperLog.PaperId);
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.LogTypeId, 2, congs_OriginalPaperLog.LogTypeId);
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.LogDescription, 500, congs_OriginalPaperLog.LogDescription);
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.UpdUser, 20, congs_OriginalPaperLog.UpdUser);
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.UpdDate, 20, congs_OriginalPaperLog.UpdDate);
clsCheckSql.CheckFieldLen(objgs_OriginalPaperLogEN.Memo, 1000, congs_OriginalPaperLog.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objgs_OriginalPaperLogEN.PaperId, congs_OriginalPaperLog.PaperId);
clsCheckSql.CheckSqlInjection4Field(objgs_OriginalPaperLogEN.LogTypeId, congs_OriginalPaperLog.LogTypeId);
clsCheckSql.CheckSqlInjection4Field(objgs_OriginalPaperLogEN.LogDescription, congs_OriginalPaperLog.LogDescription);
clsCheckSql.CheckSqlInjection4Field(objgs_OriginalPaperLogEN.UpdUser, congs_OriginalPaperLog.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objgs_OriginalPaperLogEN.UpdDate, congs_OriginalPaperLog.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objgs_OriginalPaperLogEN.Memo, congs_OriginalPaperLog.Memo);
//检查外键字段长度
 objgs_OriginalPaperLogEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--gs_OriginalPaperLog(论文日志表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsgs_OriginalPaperLogEN objgs_OriginalPaperLogEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperLogId = '{0}'", objgs_OriginalPaperLogEN.PaperLogId);
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
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
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
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
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
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_OriginalPaperLogEN._CurrTabName);
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
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_OriginalPaperLogEN._CurrTabName, strCondition);
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
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
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
 objSQL = clsgs_OriginalPaperLogDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}