
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_RequestNoticeDA
 表名:gs_RequestNotice(01120724)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:16:17
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
 框架-层名:数据处理层(CS)(DALCode)
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
 /// 请求通知表(gs_RequestNotice)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsgs_RequestNoticeDA : clsCommBase4DA
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
 return clsgs_RequestNoticeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsgs_RequestNoticeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_RequestNoticeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsgs_RequestNoticeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsgs_RequestNoticeEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsgs_RequestNoticeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
strSQL = "Select * from gs_RequestNotice where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_gs_RequestNotice(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsgs_RequestNoticeDA: GetDataTable_gs_RequestNotice)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
strSQL = "Select * from gs_RequestNotice where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsgs_RequestNoticeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsgs_RequestNoticeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
strSQL = "Select * from gs_RequestNotice where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsgs_RequestNoticeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsgs_RequestNoticeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_RequestNotice where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_RequestNotice where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsgs_RequestNoticeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from gs_RequestNotice where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsgs_RequestNoticeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_RequestNotice.* from gs_RequestNotice Left Join {1} on {2} where {3} and gs_RequestNotice.RequestId not in (Select top {5} gs_RequestNotice.RequestId from gs_RequestNotice Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_RequestNotice where {1} and RequestId not in (Select top {2} RequestId from gs_RequestNotice where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_RequestNotice where {1} and RequestId not in (Select top {3} RequestId from gs_RequestNotice where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsgs_RequestNoticeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_RequestNotice.* from gs_RequestNotice Left Join {1} on {2} where {3} and gs_RequestNotice.RequestId not in (Select top {5} gs_RequestNotice.RequestId from gs_RequestNotice Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_RequestNotice where {1} and RequestId not in (Select top {2} RequestId from gs_RequestNotice where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_RequestNotice where {1} and RequestId not in (Select top {3} RequestId from gs_RequestNotice where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsgs_RequestNoticeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsgs_RequestNoticeDA:GetObjLst)", objException.Message));
}
List<clsgs_RequestNoticeEN> arrObjLst = new List<clsgs_RequestNoticeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
strSQL = "Select * from gs_RequestNotice where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_RequestNoticeEN objgs_RequestNoticeEN = new clsgs_RequestNoticeEN();
try
{
objgs_RequestNoticeEN.RequestId = TransNullToInt(objRow[congs_RequestNotice.RequestId].ToString().Trim()); //RequestId
objgs_RequestNoticeEN.RequesTypeId = objRow[congs_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objgs_RequestNoticeEN.TableKey = objRow[congs_RequestNotice.TableKey] == DBNull.Value ? null : objRow[congs_RequestNotice.TableKey].ToString().Trim(); //表主键
objgs_RequestNoticeEN.ReceiveUser = objRow[congs_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[congs_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objgs_RequestNoticeEN.IsReply = TransNullToBool(objRow[congs_RequestNotice.IsReply].ToString().Trim()); //是否回复
objgs_RequestNoticeEN.ReplyDate = objRow[congs_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[congs_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objgs_RequestNoticeEN.RequestUser = objRow[congs_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objgs_RequestNoticeEN.RequestDate = objRow[congs_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objgs_RequestNoticeEN.RequestStata = objRow[congs_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objgs_RequestNoticeEN.PushTypeId = objRow[congs_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objgs_RequestNoticeEN.IdCurrEduCls = objRow[congs_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_RequestNoticeEN.Memo = objRow[congs_RequestNotice.Memo] == DBNull.Value ? null : objRow[congs_RequestNotice.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_RequestNoticeDA: GetObjLst)", objException.Message));
}
objgs_RequestNoticeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_RequestNoticeEN);
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
public List<clsgs_RequestNoticeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsgs_RequestNoticeDA:GetObjLstByTabName)", objException.Message));
}
List<clsgs_RequestNoticeEN> arrObjLst = new List<clsgs_RequestNoticeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_RequestNoticeEN objgs_RequestNoticeEN = new clsgs_RequestNoticeEN();
try
{
objgs_RequestNoticeEN.RequestId = TransNullToInt(objRow[congs_RequestNotice.RequestId].ToString().Trim()); //RequestId
objgs_RequestNoticeEN.RequesTypeId = objRow[congs_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objgs_RequestNoticeEN.TableKey = objRow[congs_RequestNotice.TableKey] == DBNull.Value ? null : objRow[congs_RequestNotice.TableKey].ToString().Trim(); //表主键
objgs_RequestNoticeEN.ReceiveUser = objRow[congs_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[congs_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objgs_RequestNoticeEN.IsReply = TransNullToBool(objRow[congs_RequestNotice.IsReply].ToString().Trim()); //是否回复
objgs_RequestNoticeEN.ReplyDate = objRow[congs_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[congs_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objgs_RequestNoticeEN.RequestUser = objRow[congs_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objgs_RequestNoticeEN.RequestDate = objRow[congs_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objgs_RequestNoticeEN.RequestStata = objRow[congs_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objgs_RequestNoticeEN.PushTypeId = objRow[congs_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objgs_RequestNoticeEN.IdCurrEduCls = objRow[congs_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_RequestNoticeEN.Memo = objRow[congs_RequestNotice.Memo] == DBNull.Value ? null : objRow[congs_RequestNotice.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_RequestNoticeDA: GetObjLst)", objException.Message));
}
objgs_RequestNoticeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_RequestNoticeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getgs_RequestNotice(ref clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
strSQL = "Select * from gs_RequestNotice where RequestId = " + ""+ objgs_RequestNoticeEN.RequestId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objgs_RequestNoticeEN.RequestId = TransNullToInt(objDT.Rows[0][congs_RequestNotice.RequestId].ToString().Trim()); //RequestId(字段类型:bigint,字段长度:8,是否可空:False)
 objgs_RequestNoticeEN.RequesTypeId = objDT.Rows[0][congs_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id(字段类型:char,字段长度:2,是否可空:True)
 objgs_RequestNoticeEN.TableKey = objDT.Rows[0][congs_RequestNotice.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_RequestNoticeEN.ReceiveUser = objDT.Rows[0][congs_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_RequestNoticeEN.IsReply = TransNullToBool(objDT.Rows[0][congs_RequestNotice.IsReply].ToString().Trim()); //是否回复(字段类型:bit,字段长度:1,是否可空:True)
 objgs_RequestNoticeEN.ReplyDate = objDT.Rows[0][congs_RequestNotice.ReplyDate].ToString().Trim(); //回复日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_RequestNoticeEN.RequestUser = objDT.Rows[0][congs_RequestNotice.RequestUser].ToString().Trim(); //RequestUser(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_RequestNoticeEN.RequestDate = objDT.Rows[0][congs_RequestNotice.RequestDate].ToString().Trim(); //RequestDate(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_RequestNoticeEN.RequestStata = objDT.Rows[0][congs_RequestNotice.RequestStata].ToString().Trim(); //RequestStata(字段类型:varchar,字段长度:10,是否可空:True)
 objgs_RequestNoticeEN.PushTypeId = objDT.Rows[0][congs_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id(字段类型:char,字段长度:2,是否可空:True)
 objgs_RequestNoticeEN.IdCurrEduCls = objDT.Rows[0][congs_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objgs_RequestNoticeEN.Memo = objDT.Rows[0][congs_RequestNotice.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsgs_RequestNoticeDA: Getgs_RequestNotice)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngRequestId">表关键字</param>
 /// <returns>表对象</returns>
public clsgs_RequestNoticeEN GetObjByRequestId(long lngRequestId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
strSQL = "Select * from gs_RequestNotice where RequestId = " + ""+ lngRequestId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsgs_RequestNoticeEN objgs_RequestNoticeEN = new clsgs_RequestNoticeEN();
try
{
 objgs_RequestNoticeEN.RequestId = Int32.Parse(objRow[congs_RequestNotice.RequestId].ToString().Trim()); //RequestId(字段类型:bigint,字段长度:8,是否可空:False)
 objgs_RequestNoticeEN.RequesTypeId = objRow[congs_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id(字段类型:char,字段长度:2,是否可空:True)
 objgs_RequestNoticeEN.TableKey = objRow[congs_RequestNotice.TableKey] == DBNull.Value ? null : objRow[congs_RequestNotice.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_RequestNoticeEN.ReceiveUser = objRow[congs_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[congs_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_RequestNoticeEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[congs_RequestNotice.IsReply].ToString().Trim()); //是否回复(字段类型:bit,字段长度:1,是否可空:True)
 objgs_RequestNoticeEN.ReplyDate = objRow[congs_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[congs_RequestNotice.ReplyDate].ToString().Trim(); //回复日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_RequestNoticeEN.RequestUser = objRow[congs_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestUser].ToString().Trim(); //RequestUser(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_RequestNoticeEN.RequestDate = objRow[congs_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestDate].ToString().Trim(); //RequestDate(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_RequestNoticeEN.RequestStata = objRow[congs_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestStata].ToString().Trim(); //RequestStata(字段类型:varchar,字段长度:10,是否可空:True)
 objgs_RequestNoticeEN.PushTypeId = objRow[congs_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id(字段类型:char,字段长度:2,是否可空:True)
 objgs_RequestNoticeEN.IdCurrEduCls = objRow[congs_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objgs_RequestNoticeEN.Memo = objRow[congs_RequestNotice.Memo] == DBNull.Value ? null : objRow[congs_RequestNotice.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsgs_RequestNoticeDA: GetObjByRequestId)", objException.Message));
}
return objgs_RequestNoticeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsgs_RequestNoticeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsgs_RequestNoticeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
strSQL = "Select * from gs_RequestNotice where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsgs_RequestNoticeEN objgs_RequestNoticeEN = new clsgs_RequestNoticeEN()
{
RequestId = TransNullToInt(objRow[congs_RequestNotice.RequestId].ToString().Trim()), //RequestId
RequesTypeId = objRow[congs_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.RequesTypeId].ToString().Trim(), //请求类型Id
TableKey = objRow[congs_RequestNotice.TableKey] == DBNull.Value ? null : objRow[congs_RequestNotice.TableKey].ToString().Trim(), //表主键
ReceiveUser = objRow[congs_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[congs_RequestNotice.ReceiveUser].ToString().Trim(), //接收用户
IsReply = TransNullToBool(objRow[congs_RequestNotice.IsReply].ToString().Trim()), //是否回复
ReplyDate = objRow[congs_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[congs_RequestNotice.ReplyDate].ToString().Trim(), //回复日期
RequestUser = objRow[congs_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestUser].ToString().Trim(), //RequestUser
RequestDate = objRow[congs_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestDate].ToString().Trim(), //RequestDate
RequestStata = objRow[congs_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestStata].ToString().Trim(), //RequestStata
PushTypeId = objRow[congs_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.PushTypeId].ToString().Trim(), //推送类型Id
IdCurrEduCls = objRow[congs_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_RequestNotice.IdCurrEduCls].ToString().Trim(), //教学班流水号
Memo = objRow[congs_RequestNotice.Memo] == DBNull.Value ? null : objRow[congs_RequestNotice.Memo].ToString().Trim() //备注
};
objgs_RequestNoticeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_RequestNoticeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsgs_RequestNoticeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsgs_RequestNoticeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_RequestNoticeEN objgs_RequestNoticeEN = new clsgs_RequestNoticeEN();
try
{
objgs_RequestNoticeEN.RequestId = TransNullToInt(objRow[congs_RequestNotice.RequestId].ToString().Trim()); //RequestId
objgs_RequestNoticeEN.RequesTypeId = objRow[congs_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objgs_RequestNoticeEN.TableKey = objRow[congs_RequestNotice.TableKey] == DBNull.Value ? null : objRow[congs_RequestNotice.TableKey].ToString().Trim(); //表主键
objgs_RequestNoticeEN.ReceiveUser = objRow[congs_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[congs_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objgs_RequestNoticeEN.IsReply = TransNullToBool(objRow[congs_RequestNotice.IsReply].ToString().Trim()); //是否回复
objgs_RequestNoticeEN.ReplyDate = objRow[congs_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[congs_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objgs_RequestNoticeEN.RequestUser = objRow[congs_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objgs_RequestNoticeEN.RequestDate = objRow[congs_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objgs_RequestNoticeEN.RequestStata = objRow[congs_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objgs_RequestNoticeEN.PushTypeId = objRow[congs_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objgs_RequestNoticeEN.IdCurrEduCls = objRow[congs_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_RequestNoticeEN.Memo = objRow[congs_RequestNotice.Memo] == DBNull.Value ? null : objRow[congs_RequestNotice.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsgs_RequestNoticeDA: GetObjByDataRowgs_RequestNotice)", objException.Message));
}
objgs_RequestNoticeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_RequestNoticeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsgs_RequestNoticeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_RequestNoticeEN objgs_RequestNoticeEN = new clsgs_RequestNoticeEN();
try
{
objgs_RequestNoticeEN.RequestId = TransNullToInt(objRow[congs_RequestNotice.RequestId].ToString().Trim()); //RequestId
objgs_RequestNoticeEN.RequesTypeId = objRow[congs_RequestNotice.RequesTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objgs_RequestNoticeEN.TableKey = objRow[congs_RequestNotice.TableKey] == DBNull.Value ? null : objRow[congs_RequestNotice.TableKey].ToString().Trim(); //表主键
objgs_RequestNoticeEN.ReceiveUser = objRow[congs_RequestNotice.ReceiveUser] == DBNull.Value ? null : objRow[congs_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objgs_RequestNoticeEN.IsReply = TransNullToBool(objRow[congs_RequestNotice.IsReply].ToString().Trim()); //是否回复
objgs_RequestNoticeEN.ReplyDate = objRow[congs_RequestNotice.ReplyDate] == DBNull.Value ? null : objRow[congs_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objgs_RequestNoticeEN.RequestUser = objRow[congs_RequestNotice.RequestUser] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objgs_RequestNoticeEN.RequestDate = objRow[congs_RequestNotice.RequestDate] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objgs_RequestNoticeEN.RequestStata = objRow[congs_RequestNotice.RequestStata] == DBNull.Value ? null : objRow[congs_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objgs_RequestNoticeEN.PushTypeId = objRow[congs_RequestNotice.PushTypeId] == DBNull.Value ? null : objRow[congs_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objgs_RequestNoticeEN.IdCurrEduCls = objRow[congs_RequestNotice.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_RequestNoticeEN.Memo = objRow[congs_RequestNotice.Memo] == DBNull.Value ? null : objRow[congs_RequestNotice.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsgs_RequestNoticeDA: GetObjByDataRow)", objException.Message));
}
objgs_RequestNoticeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_RequestNoticeEN;
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
objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_RequestNoticeEN._CurrTabName, congs_RequestNotice.RequestId, 8, "");
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
objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_RequestNoticeEN._CurrTabName, congs_RequestNotice.RequestId, 8, strPrefix);
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
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select RequestId from gs_RequestNotice where " + strCondition;
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
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select RequestId from gs_RequestNotice where " + strCondition;
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
 /// <param name = "lngRequestId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngRequestId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_RequestNotice", "RequestId = " + ""+ lngRequestId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsgs_RequestNoticeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_RequestNotice", strCondition))
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
objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("gs_RequestNotice");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
 {
 if (objgs_RequestNoticeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_RequestNoticeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
strSQL = "Select * from gs_RequestNotice where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_RequestNotice");
objRow = objDS.Tables["gs_RequestNotice"].NewRow();
 if (objgs_RequestNoticeEN.RequesTypeId !=  "")
 {
objRow[congs_RequestNotice.RequesTypeId] = objgs_RequestNoticeEN.RequesTypeId; //请求类型Id
 }
 if (objgs_RequestNoticeEN.TableKey !=  "")
 {
objRow[congs_RequestNotice.TableKey] = objgs_RequestNoticeEN.TableKey; //表主键
 }
 if (objgs_RequestNoticeEN.ReceiveUser !=  "")
 {
objRow[congs_RequestNotice.ReceiveUser] = objgs_RequestNoticeEN.ReceiveUser; //接收用户
 }
objRow[congs_RequestNotice.IsReply] = objgs_RequestNoticeEN.IsReply; //是否回复
 if (objgs_RequestNoticeEN.ReplyDate !=  "")
 {
objRow[congs_RequestNotice.ReplyDate] = objgs_RequestNoticeEN.ReplyDate; //回复日期
 }
 if (objgs_RequestNoticeEN.RequestUser !=  "")
 {
objRow[congs_RequestNotice.RequestUser] = objgs_RequestNoticeEN.RequestUser; //RequestUser
 }
 if (objgs_RequestNoticeEN.RequestDate !=  "")
 {
objRow[congs_RequestNotice.RequestDate] = objgs_RequestNoticeEN.RequestDate; //RequestDate
 }
 if (objgs_RequestNoticeEN.RequestStata !=  "")
 {
objRow[congs_RequestNotice.RequestStata] = objgs_RequestNoticeEN.RequestStata; //RequestStata
 }
 if (objgs_RequestNoticeEN.PushTypeId !=  "")
 {
objRow[congs_RequestNotice.PushTypeId] = objgs_RequestNoticeEN.PushTypeId; //推送类型Id
 }
 if (objgs_RequestNoticeEN.IdCurrEduCls !=  "")
 {
objRow[congs_RequestNotice.IdCurrEduCls] = objgs_RequestNoticeEN.IdCurrEduCls; //教学班流水号
 }
 if (objgs_RequestNoticeEN.Memo !=  "")
 {
objRow[congs_RequestNotice.Memo] = objgs_RequestNoticeEN.Memo; //备注
 }
objDS.Tables[clsgs_RequestNoticeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsgs_RequestNoticeEN._CurrTabName);
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
 /// <param name = "objgs_RequestNoticeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
 if (objgs_RequestNoticeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_RequestNoticeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_RequestNoticeEN.RequesTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.RequesTypeId);
 var strRequesTypeId = objgs_RequestNoticeEN.RequesTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequesTypeId + "'");
 }
 
 if (objgs_RequestNoticeEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.TableKey);
 var strTableKey = objgs_RequestNoticeEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objgs_RequestNoticeEN.ReceiveUser !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.ReceiveUser);
 var strReceiveUser = objgs_RequestNoticeEN.ReceiveUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReceiveUser + "'");
 }
 
 arrFieldListForInsert.Add(congs_RequestNotice.IsReply);
 arrValueListForInsert.Add("'" + (objgs_RequestNoticeEN.IsReply  ==  false ? "0" : "1") + "'");
 
 if (objgs_RequestNoticeEN.ReplyDate !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.ReplyDate);
 var strReplyDate = objgs_RequestNoticeEN.ReplyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReplyDate + "'");
 }
 
 if (objgs_RequestNoticeEN.RequestUser !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.RequestUser);
 var strRequestUser = objgs_RequestNoticeEN.RequestUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestUser + "'");
 }
 
 if (objgs_RequestNoticeEN.RequestDate !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.RequestDate);
 var strRequestDate = objgs_RequestNoticeEN.RequestDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestDate + "'");
 }
 
 if (objgs_RequestNoticeEN.RequestStata !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.RequestStata);
 var strRequestStata = objgs_RequestNoticeEN.RequestStata.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestStata + "'");
 }
 
 if (objgs_RequestNoticeEN.PushTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.PushTypeId);
 var strPushTypeId = objgs_RequestNoticeEN.PushTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPushTypeId + "'");
 }
 
 if (objgs_RequestNoticeEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.IdCurrEduCls);
 var strIdCurrEduCls = objgs_RequestNoticeEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_RequestNoticeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.Memo);
 var strMemo = objgs_RequestNoticeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_RequestNotice");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
 if (objgs_RequestNoticeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_RequestNoticeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_RequestNoticeEN.RequesTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.RequesTypeId);
 var strRequesTypeId = objgs_RequestNoticeEN.RequesTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequesTypeId + "'");
 }
 
 if (objgs_RequestNoticeEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.TableKey);
 var strTableKey = objgs_RequestNoticeEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objgs_RequestNoticeEN.ReceiveUser !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.ReceiveUser);
 var strReceiveUser = objgs_RequestNoticeEN.ReceiveUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReceiveUser + "'");
 }
 
 arrFieldListForInsert.Add(congs_RequestNotice.IsReply);
 arrValueListForInsert.Add("'" + (objgs_RequestNoticeEN.IsReply  ==  false ? "0" : "1") + "'");
 
 if (objgs_RequestNoticeEN.ReplyDate !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.ReplyDate);
 var strReplyDate = objgs_RequestNoticeEN.ReplyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReplyDate + "'");
 }
 
 if (objgs_RequestNoticeEN.RequestUser !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.RequestUser);
 var strRequestUser = objgs_RequestNoticeEN.RequestUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestUser + "'");
 }
 
 if (objgs_RequestNoticeEN.RequestDate !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.RequestDate);
 var strRequestDate = objgs_RequestNoticeEN.RequestDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestDate + "'");
 }
 
 if (objgs_RequestNoticeEN.RequestStata !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.RequestStata);
 var strRequestStata = objgs_RequestNoticeEN.RequestStata.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestStata + "'");
 }
 
 if (objgs_RequestNoticeEN.PushTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.PushTypeId);
 var strPushTypeId = objgs_RequestNoticeEN.PushTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPushTypeId + "'");
 }
 
 if (objgs_RequestNoticeEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.IdCurrEduCls);
 var strIdCurrEduCls = objgs_RequestNoticeEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_RequestNoticeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.Memo);
 var strMemo = objgs_RequestNoticeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_RequestNotice");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_RequestNoticeEN objgs_RequestNoticeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_RequestNoticeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_RequestNoticeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_RequestNoticeEN.RequesTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.RequesTypeId);
 var strRequesTypeId = objgs_RequestNoticeEN.RequesTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequesTypeId + "'");
 }
 
 if (objgs_RequestNoticeEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.TableKey);
 var strTableKey = objgs_RequestNoticeEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objgs_RequestNoticeEN.ReceiveUser !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.ReceiveUser);
 var strReceiveUser = objgs_RequestNoticeEN.ReceiveUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReceiveUser + "'");
 }
 
 arrFieldListForInsert.Add(congs_RequestNotice.IsReply);
 arrValueListForInsert.Add("'" + (objgs_RequestNoticeEN.IsReply  ==  false ? "0" : "1") + "'");
 
 if (objgs_RequestNoticeEN.ReplyDate !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.ReplyDate);
 var strReplyDate = objgs_RequestNoticeEN.ReplyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReplyDate + "'");
 }
 
 if (objgs_RequestNoticeEN.RequestUser !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.RequestUser);
 var strRequestUser = objgs_RequestNoticeEN.RequestUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestUser + "'");
 }
 
 if (objgs_RequestNoticeEN.RequestDate !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.RequestDate);
 var strRequestDate = objgs_RequestNoticeEN.RequestDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestDate + "'");
 }
 
 if (objgs_RequestNoticeEN.RequestStata !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.RequestStata);
 var strRequestStata = objgs_RequestNoticeEN.RequestStata.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestStata + "'");
 }
 
 if (objgs_RequestNoticeEN.PushTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.PushTypeId);
 var strPushTypeId = objgs_RequestNoticeEN.PushTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPushTypeId + "'");
 }
 
 if (objgs_RequestNoticeEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.IdCurrEduCls);
 var strIdCurrEduCls = objgs_RequestNoticeEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_RequestNoticeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.Memo);
 var strMemo = objgs_RequestNoticeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_RequestNotice");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_RequestNoticeEN objgs_RequestNoticeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_RequestNoticeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_RequestNoticeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_RequestNoticeEN.RequesTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.RequesTypeId);
 var strRequesTypeId = objgs_RequestNoticeEN.RequesTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequesTypeId + "'");
 }
 
 if (objgs_RequestNoticeEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.TableKey);
 var strTableKey = objgs_RequestNoticeEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objgs_RequestNoticeEN.ReceiveUser !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.ReceiveUser);
 var strReceiveUser = objgs_RequestNoticeEN.ReceiveUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReceiveUser + "'");
 }
 
 arrFieldListForInsert.Add(congs_RequestNotice.IsReply);
 arrValueListForInsert.Add("'" + (objgs_RequestNoticeEN.IsReply  ==  false ? "0" : "1") + "'");
 
 if (objgs_RequestNoticeEN.ReplyDate !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.ReplyDate);
 var strReplyDate = objgs_RequestNoticeEN.ReplyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReplyDate + "'");
 }
 
 if (objgs_RequestNoticeEN.RequestUser !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.RequestUser);
 var strRequestUser = objgs_RequestNoticeEN.RequestUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestUser + "'");
 }
 
 if (objgs_RequestNoticeEN.RequestDate !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.RequestDate);
 var strRequestDate = objgs_RequestNoticeEN.RequestDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestDate + "'");
 }
 
 if (objgs_RequestNoticeEN.RequestStata !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.RequestStata);
 var strRequestStata = objgs_RequestNoticeEN.RequestStata.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestStata + "'");
 }
 
 if (objgs_RequestNoticeEN.PushTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.PushTypeId);
 var strPushTypeId = objgs_RequestNoticeEN.PushTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPushTypeId + "'");
 }
 
 if (objgs_RequestNoticeEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.IdCurrEduCls);
 var strIdCurrEduCls = objgs_RequestNoticeEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_RequestNoticeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_RequestNotice.Memo);
 var strMemo = objgs_RequestNoticeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_RequestNotice");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewgs_RequestNotices(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
strSQL = "Select * from gs_RequestNotice where RequestId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_RequestNotice");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngRequestId = TransNullToInt(oRow[congs_RequestNotice.RequestId].ToString().Trim());
if (IsExist(lngRequestId))
{
 string strResult = "关键字变量值为:" + string.Format("RequestId = {0}", lngRequestId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsgs_RequestNoticeEN._CurrTabName ].NewRow();
objRow[congs_RequestNotice.RequesTypeId] = oRow[congs_RequestNotice.RequesTypeId].ToString().Trim(); //请求类型Id
objRow[congs_RequestNotice.TableKey] = oRow[congs_RequestNotice.TableKey].ToString().Trim(); //表主键
objRow[congs_RequestNotice.ReceiveUser] = oRow[congs_RequestNotice.ReceiveUser].ToString().Trim(); //接收用户
objRow[congs_RequestNotice.IsReply] = oRow[congs_RequestNotice.IsReply].ToString().Trim(); //是否回复
objRow[congs_RequestNotice.ReplyDate] = oRow[congs_RequestNotice.ReplyDate].ToString().Trim(); //回复日期
objRow[congs_RequestNotice.RequestUser] = oRow[congs_RequestNotice.RequestUser].ToString().Trim(); //RequestUser
objRow[congs_RequestNotice.RequestDate] = oRow[congs_RequestNotice.RequestDate].ToString().Trim(); //RequestDate
objRow[congs_RequestNotice.RequestStata] = oRow[congs_RequestNotice.RequestStata].ToString().Trim(); //RequestStata
objRow[congs_RequestNotice.PushTypeId] = oRow[congs_RequestNotice.PushTypeId].ToString().Trim(); //推送类型Id
objRow[congs_RequestNotice.IdCurrEduCls] = oRow[congs_RequestNotice.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[congs_RequestNotice.Memo] = oRow[congs_RequestNotice.Memo].ToString().Trim(); //备注
 objDS.Tables[clsgs_RequestNoticeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsgs_RequestNoticeEN._CurrTabName);
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
 /// <param name = "objgs_RequestNoticeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
 if (objgs_RequestNoticeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_RequestNoticeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
strSQL = "Select * from gs_RequestNotice where RequestId = " + ""+ objgs_RequestNoticeEN.RequestId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsgs_RequestNoticeEN._CurrTabName);
if (objDS.Tables[clsgs_RequestNoticeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:RequestId = " + ""+ objgs_RequestNoticeEN.RequestId+"");
return false;
}
objRow = objDS.Tables[clsgs_RequestNoticeEN._CurrTabName].Rows[0];
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequesTypeId))
 {
objRow[congs_RequestNotice.RequesTypeId] = objgs_RequestNoticeEN.RequesTypeId; //请求类型Id
 }
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.TableKey))
 {
objRow[congs_RequestNotice.TableKey] = objgs_RequestNoticeEN.TableKey; //表主键
 }
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.ReceiveUser))
 {
objRow[congs_RequestNotice.ReceiveUser] = objgs_RequestNoticeEN.ReceiveUser; //接收用户
 }
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.IsReply))
 {
objRow[congs_RequestNotice.IsReply] = objgs_RequestNoticeEN.IsReply; //是否回复
 }
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.ReplyDate))
 {
objRow[congs_RequestNotice.ReplyDate] = objgs_RequestNoticeEN.ReplyDate; //回复日期
 }
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequestUser))
 {
objRow[congs_RequestNotice.RequestUser] = objgs_RequestNoticeEN.RequestUser; //RequestUser
 }
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequestDate))
 {
objRow[congs_RequestNotice.RequestDate] = objgs_RequestNoticeEN.RequestDate; //RequestDate
 }
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequestStata))
 {
objRow[congs_RequestNotice.RequestStata] = objgs_RequestNoticeEN.RequestStata; //RequestStata
 }
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.PushTypeId))
 {
objRow[congs_RequestNotice.PushTypeId] = objgs_RequestNoticeEN.PushTypeId; //推送类型Id
 }
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.IdCurrEduCls))
 {
objRow[congs_RequestNotice.IdCurrEduCls] = objgs_RequestNoticeEN.IdCurrEduCls; //教学班流水号
 }
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.Memo))
 {
objRow[congs_RequestNotice.Memo] = objgs_RequestNoticeEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsgs_RequestNoticeEN._CurrTabName);
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
 /// <param name = "objgs_RequestNoticeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
 if (objgs_RequestNoticeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_RequestNoticeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update gs_RequestNotice Set ");
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequesTypeId))
 {
 if (objgs_RequestNoticeEN.RequesTypeId !=  null)
 {
 var strRequesTypeId = objgs_RequestNoticeEN.RequesTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequesTypeId, congs_RequestNotice.RequesTypeId); //请求类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.RequesTypeId); //请求类型Id
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.TableKey))
 {
 if (objgs_RequestNoticeEN.TableKey !=  null)
 {
 var strTableKey = objgs_RequestNoticeEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableKey, congs_RequestNotice.TableKey); //表主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.TableKey); //表主键
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.ReceiveUser))
 {
 if (objgs_RequestNoticeEN.ReceiveUser !=  null)
 {
 var strReceiveUser = objgs_RequestNoticeEN.ReceiveUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReceiveUser, congs_RequestNotice.ReceiveUser); //接收用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.ReceiveUser); //接收用户
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.IsReply))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_RequestNoticeEN.IsReply == true?"1":"0", congs_RequestNotice.IsReply); //是否回复
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.ReplyDate))
 {
 if (objgs_RequestNoticeEN.ReplyDate !=  null)
 {
 var strReplyDate = objgs_RequestNoticeEN.ReplyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReplyDate, congs_RequestNotice.ReplyDate); //回复日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.ReplyDate); //回复日期
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequestUser))
 {
 if (objgs_RequestNoticeEN.RequestUser !=  null)
 {
 var strRequestUser = objgs_RequestNoticeEN.RequestUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequestUser, congs_RequestNotice.RequestUser); //RequestUser
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.RequestUser); //RequestUser
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequestDate))
 {
 if (objgs_RequestNoticeEN.RequestDate !=  null)
 {
 var strRequestDate = objgs_RequestNoticeEN.RequestDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequestDate, congs_RequestNotice.RequestDate); //RequestDate
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.RequestDate); //RequestDate
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequestStata))
 {
 if (objgs_RequestNoticeEN.RequestStata !=  null)
 {
 var strRequestStata = objgs_RequestNoticeEN.RequestStata.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequestStata, congs_RequestNotice.RequestStata); //RequestStata
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.RequestStata); //RequestStata
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.PushTypeId))
 {
 if (objgs_RequestNoticeEN.PushTypeId !=  null)
 {
 var strPushTypeId = objgs_RequestNoticeEN.PushTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPushTypeId, congs_RequestNotice.PushTypeId); //推送类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.PushTypeId); //推送类型Id
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.IdCurrEduCls))
 {
 if (objgs_RequestNoticeEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_RequestNoticeEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_RequestNotice.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.Memo))
 {
 if (objgs_RequestNoticeEN.Memo !=  null)
 {
 var strMemo = objgs_RequestNoticeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_RequestNotice.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RequestId = {0}", objgs_RequestNoticeEN.RequestId); 
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
 /// <param name = "objgs_RequestNoticeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsgs_RequestNoticeEN objgs_RequestNoticeEN, string strCondition)
{
 if (objgs_RequestNoticeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_RequestNoticeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_RequestNotice Set ");
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequesTypeId))
 {
 if (objgs_RequestNoticeEN.RequesTypeId !=  null)
 {
 var strRequesTypeId = objgs_RequestNoticeEN.RequesTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequesTypeId = '{0}',", strRequesTypeId); //请求类型Id
 }
 else
 {
 sbSQL.Append(" RequesTypeId = null,"); //请求类型Id
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.TableKey))
 {
 if (objgs_RequestNoticeEN.TableKey !=  null)
 {
 var strTableKey = objgs_RequestNoticeEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableKey = '{0}',", strTableKey); //表主键
 }
 else
 {
 sbSQL.Append(" TableKey = null,"); //表主键
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.ReceiveUser))
 {
 if (objgs_RequestNoticeEN.ReceiveUser !=  null)
 {
 var strReceiveUser = objgs_RequestNoticeEN.ReceiveUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReceiveUser = '{0}',", strReceiveUser); //接收用户
 }
 else
 {
 sbSQL.Append(" ReceiveUser = null,"); //接收用户
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.IsReply))
 {
 sbSQL.AppendFormat(" IsReply = '{0}',", objgs_RequestNoticeEN.IsReply == true?"1":"0"); //是否回复
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.ReplyDate))
 {
 if (objgs_RequestNoticeEN.ReplyDate !=  null)
 {
 var strReplyDate = objgs_RequestNoticeEN.ReplyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReplyDate = '{0}',", strReplyDate); //回复日期
 }
 else
 {
 sbSQL.Append(" ReplyDate = null,"); //回复日期
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequestUser))
 {
 if (objgs_RequestNoticeEN.RequestUser !=  null)
 {
 var strRequestUser = objgs_RequestNoticeEN.RequestUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequestUser = '{0}',", strRequestUser); //RequestUser
 }
 else
 {
 sbSQL.Append(" RequestUser = null,"); //RequestUser
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequestDate))
 {
 if (objgs_RequestNoticeEN.RequestDate !=  null)
 {
 var strRequestDate = objgs_RequestNoticeEN.RequestDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequestDate = '{0}',", strRequestDate); //RequestDate
 }
 else
 {
 sbSQL.Append(" RequestDate = null,"); //RequestDate
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequestStata))
 {
 if (objgs_RequestNoticeEN.RequestStata !=  null)
 {
 var strRequestStata = objgs_RequestNoticeEN.RequestStata.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequestStata = '{0}',", strRequestStata); //RequestStata
 }
 else
 {
 sbSQL.Append(" RequestStata = null,"); //RequestStata
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.PushTypeId))
 {
 if (objgs_RequestNoticeEN.PushTypeId !=  null)
 {
 var strPushTypeId = objgs_RequestNoticeEN.PushTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PushTypeId = '{0}',", strPushTypeId); //推送类型Id
 }
 else
 {
 sbSQL.Append(" PushTypeId = null,"); //推送类型Id
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.IdCurrEduCls))
 {
 if (objgs_RequestNoticeEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_RequestNoticeEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.Memo))
 {
 if (objgs_RequestNoticeEN.Memo !=  null)
 {
 var strMemo = objgs_RequestNoticeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objgs_RequestNoticeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsgs_RequestNoticeEN objgs_RequestNoticeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_RequestNoticeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_RequestNoticeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_RequestNotice Set ");
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequesTypeId))
 {
 if (objgs_RequestNoticeEN.RequesTypeId !=  null)
 {
 var strRequesTypeId = objgs_RequestNoticeEN.RequesTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequesTypeId = '{0}',", strRequesTypeId); //请求类型Id
 }
 else
 {
 sbSQL.Append(" RequesTypeId = null,"); //请求类型Id
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.TableKey))
 {
 if (objgs_RequestNoticeEN.TableKey !=  null)
 {
 var strTableKey = objgs_RequestNoticeEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableKey = '{0}',", strTableKey); //表主键
 }
 else
 {
 sbSQL.Append(" TableKey = null,"); //表主键
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.ReceiveUser))
 {
 if (objgs_RequestNoticeEN.ReceiveUser !=  null)
 {
 var strReceiveUser = objgs_RequestNoticeEN.ReceiveUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReceiveUser = '{0}',", strReceiveUser); //接收用户
 }
 else
 {
 sbSQL.Append(" ReceiveUser = null,"); //接收用户
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.IsReply))
 {
 sbSQL.AppendFormat(" IsReply = '{0}',", objgs_RequestNoticeEN.IsReply == true?"1":"0"); //是否回复
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.ReplyDate))
 {
 if (objgs_RequestNoticeEN.ReplyDate !=  null)
 {
 var strReplyDate = objgs_RequestNoticeEN.ReplyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReplyDate = '{0}',", strReplyDate); //回复日期
 }
 else
 {
 sbSQL.Append(" ReplyDate = null,"); //回复日期
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequestUser))
 {
 if (objgs_RequestNoticeEN.RequestUser !=  null)
 {
 var strRequestUser = objgs_RequestNoticeEN.RequestUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequestUser = '{0}',", strRequestUser); //RequestUser
 }
 else
 {
 sbSQL.Append(" RequestUser = null,"); //RequestUser
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequestDate))
 {
 if (objgs_RequestNoticeEN.RequestDate !=  null)
 {
 var strRequestDate = objgs_RequestNoticeEN.RequestDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequestDate = '{0}',", strRequestDate); //RequestDate
 }
 else
 {
 sbSQL.Append(" RequestDate = null,"); //RequestDate
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequestStata))
 {
 if (objgs_RequestNoticeEN.RequestStata !=  null)
 {
 var strRequestStata = objgs_RequestNoticeEN.RequestStata.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequestStata = '{0}',", strRequestStata); //RequestStata
 }
 else
 {
 sbSQL.Append(" RequestStata = null,"); //RequestStata
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.PushTypeId))
 {
 if (objgs_RequestNoticeEN.PushTypeId !=  null)
 {
 var strPushTypeId = objgs_RequestNoticeEN.PushTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PushTypeId = '{0}',", strPushTypeId); //推送类型Id
 }
 else
 {
 sbSQL.Append(" PushTypeId = null,"); //推送类型Id
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.IdCurrEduCls))
 {
 if (objgs_RequestNoticeEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_RequestNoticeEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.Memo))
 {
 if (objgs_RequestNoticeEN.Memo !=  null)
 {
 var strMemo = objgs_RequestNoticeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objgs_RequestNoticeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_RequestNoticeEN objgs_RequestNoticeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_RequestNoticeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_RequestNoticeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_RequestNotice Set ");
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequesTypeId))
 {
 if (objgs_RequestNoticeEN.RequesTypeId !=  null)
 {
 var strRequesTypeId = objgs_RequestNoticeEN.RequesTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequesTypeId, congs_RequestNotice.RequesTypeId); //请求类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.RequesTypeId); //请求类型Id
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.TableKey))
 {
 if (objgs_RequestNoticeEN.TableKey !=  null)
 {
 var strTableKey = objgs_RequestNoticeEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableKey, congs_RequestNotice.TableKey); //表主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.TableKey); //表主键
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.ReceiveUser))
 {
 if (objgs_RequestNoticeEN.ReceiveUser !=  null)
 {
 var strReceiveUser = objgs_RequestNoticeEN.ReceiveUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReceiveUser, congs_RequestNotice.ReceiveUser); //接收用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.ReceiveUser); //接收用户
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.IsReply))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_RequestNoticeEN.IsReply == true?"1":"0", congs_RequestNotice.IsReply); //是否回复
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.ReplyDate))
 {
 if (objgs_RequestNoticeEN.ReplyDate !=  null)
 {
 var strReplyDate = objgs_RequestNoticeEN.ReplyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReplyDate, congs_RequestNotice.ReplyDate); //回复日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.ReplyDate); //回复日期
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequestUser))
 {
 if (objgs_RequestNoticeEN.RequestUser !=  null)
 {
 var strRequestUser = objgs_RequestNoticeEN.RequestUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequestUser, congs_RequestNotice.RequestUser); //RequestUser
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.RequestUser); //RequestUser
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequestDate))
 {
 if (objgs_RequestNoticeEN.RequestDate !=  null)
 {
 var strRequestDate = objgs_RequestNoticeEN.RequestDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequestDate, congs_RequestNotice.RequestDate); //RequestDate
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.RequestDate); //RequestDate
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.RequestStata))
 {
 if (objgs_RequestNoticeEN.RequestStata !=  null)
 {
 var strRequestStata = objgs_RequestNoticeEN.RequestStata.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequestStata, congs_RequestNotice.RequestStata); //RequestStata
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.RequestStata); //RequestStata
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.PushTypeId))
 {
 if (objgs_RequestNoticeEN.PushTypeId !=  null)
 {
 var strPushTypeId = objgs_RequestNoticeEN.PushTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPushTypeId, congs_RequestNotice.PushTypeId); //推送类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.PushTypeId); //推送类型Id
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.IdCurrEduCls))
 {
 if (objgs_RequestNoticeEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_RequestNoticeEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_RequestNotice.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objgs_RequestNoticeEN.IsUpdated(congs_RequestNotice.Memo))
 {
 if (objgs_RequestNoticeEN.Memo !=  null)
 {
 var strMemo = objgs_RequestNoticeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_RequestNotice.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_RequestNotice.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RequestId = {0}", objgs_RequestNoticeEN.RequestId); 
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
 /// <param name = "lngRequestId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngRequestId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngRequestId,
};
 objSQL.ExecSP("gs_RequestNotice_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngRequestId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngRequestId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
//删除gs_RequestNotice本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_RequestNotice where RequestId = " + ""+ lngRequestId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delgs_RequestNotice(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
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
//删除gs_RequestNotice本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_RequestNotice where RequestId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngRequestId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngRequestId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
//删除gs_RequestNotice本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_RequestNotice where RequestId = " + ""+ lngRequestId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delgs_RequestNotice(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsgs_RequestNoticeDA: Delgs_RequestNotice)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_RequestNotice where " + strCondition ;
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
public bool Delgs_RequestNoticeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsgs_RequestNoticeDA: Delgs_RequestNoticeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_RequestNotice where " + strCondition ;
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
 /// <param name = "objgs_RequestNoticeENS">源对象</param>
 /// <param name = "objgs_RequestNoticeENT">目标对象</param>
public void CopyTo(clsgs_RequestNoticeEN objgs_RequestNoticeENS, clsgs_RequestNoticeEN objgs_RequestNoticeENT)
{
objgs_RequestNoticeENT.RequestId = objgs_RequestNoticeENS.RequestId; //RequestId
objgs_RequestNoticeENT.RequesTypeId = objgs_RequestNoticeENS.RequesTypeId; //请求类型Id
objgs_RequestNoticeENT.TableKey = objgs_RequestNoticeENS.TableKey; //表主键
objgs_RequestNoticeENT.ReceiveUser = objgs_RequestNoticeENS.ReceiveUser; //接收用户
objgs_RequestNoticeENT.IsReply = objgs_RequestNoticeENS.IsReply; //是否回复
objgs_RequestNoticeENT.ReplyDate = objgs_RequestNoticeENS.ReplyDate; //回复日期
objgs_RequestNoticeENT.RequestUser = objgs_RequestNoticeENS.RequestUser; //RequestUser
objgs_RequestNoticeENT.RequestDate = objgs_RequestNoticeENS.RequestDate; //RequestDate
objgs_RequestNoticeENT.RequestStata = objgs_RequestNoticeENS.RequestStata; //RequestStata
objgs_RequestNoticeENT.PushTypeId = objgs_RequestNoticeENS.PushTypeId; //推送类型Id
objgs_RequestNoticeENT.IdCurrEduCls = objgs_RequestNoticeENS.IdCurrEduCls; //教学班流水号
objgs_RequestNoticeENT.Memo = objgs_RequestNoticeENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.RequesTypeId, 2, congs_RequestNotice.RequesTypeId);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.TableKey, 20, congs_RequestNotice.TableKey);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.ReceiveUser, 20, congs_RequestNotice.ReceiveUser);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.ReplyDate, 20, congs_RequestNotice.ReplyDate);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.RequestUser, 20, congs_RequestNotice.RequestUser);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.RequestDate, 20, congs_RequestNotice.RequestDate);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.RequestStata, 10, congs_RequestNotice.RequestStata);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.PushTypeId, 2, congs_RequestNotice.PushTypeId);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.IdCurrEduCls, 8, congs_RequestNotice.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.Memo, 1000, congs_RequestNotice.Memo);
//检查字段外键固定长度
 objgs_RequestNoticeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.RequesTypeId, 2, congs_RequestNotice.RequesTypeId);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.TableKey, 20, congs_RequestNotice.TableKey);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.ReceiveUser, 20, congs_RequestNotice.ReceiveUser);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.ReplyDate, 20, congs_RequestNotice.ReplyDate);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.RequestUser, 20, congs_RequestNotice.RequestUser);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.RequestDate, 20, congs_RequestNotice.RequestDate);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.RequestStata, 10, congs_RequestNotice.RequestStata);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.PushTypeId, 2, congs_RequestNotice.PushTypeId);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.IdCurrEduCls, 8, congs_RequestNotice.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.Memo, 1000, congs_RequestNotice.Memo);
//检查外键字段长度
 objgs_RequestNoticeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.RequesTypeId, 2, congs_RequestNotice.RequesTypeId);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.TableKey, 20, congs_RequestNotice.TableKey);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.ReceiveUser, 20, congs_RequestNotice.ReceiveUser);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.ReplyDate, 20, congs_RequestNotice.ReplyDate);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.RequestUser, 20, congs_RequestNotice.RequestUser);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.RequestDate, 20, congs_RequestNotice.RequestDate);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.RequestStata, 10, congs_RequestNotice.RequestStata);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.PushTypeId, 2, congs_RequestNotice.PushTypeId);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.IdCurrEduCls, 8, congs_RequestNotice.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_RequestNoticeEN.Memo, 1000, congs_RequestNotice.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objgs_RequestNoticeEN.RequesTypeId, congs_RequestNotice.RequesTypeId);
clsCheckSql.CheckSqlInjection4Field(objgs_RequestNoticeEN.TableKey, congs_RequestNotice.TableKey);
clsCheckSql.CheckSqlInjection4Field(objgs_RequestNoticeEN.ReceiveUser, congs_RequestNotice.ReceiveUser);
clsCheckSql.CheckSqlInjection4Field(objgs_RequestNoticeEN.ReplyDate, congs_RequestNotice.ReplyDate);
clsCheckSql.CheckSqlInjection4Field(objgs_RequestNoticeEN.RequestUser, congs_RequestNotice.RequestUser);
clsCheckSql.CheckSqlInjection4Field(objgs_RequestNoticeEN.RequestDate, congs_RequestNotice.RequestDate);
clsCheckSql.CheckSqlInjection4Field(objgs_RequestNoticeEN.RequestStata, congs_RequestNotice.RequestStata);
clsCheckSql.CheckSqlInjection4Field(objgs_RequestNoticeEN.PushTypeId, congs_RequestNotice.PushTypeId);
clsCheckSql.CheckSqlInjection4Field(objgs_RequestNoticeEN.IdCurrEduCls, congs_RequestNotice.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objgs_RequestNoticeEN.Memo, congs_RequestNotice.Memo);
//检查外键字段长度
 objgs_RequestNoticeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--gs_RequestNotice(请求通知表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_RequestNoticeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsgs_RequestNoticeEN objgs_RequestNoticeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objgs_RequestNoticeEN.RequesTypeId == null)
{
 sbCondition.AppendFormat(" and RequesTypeId is null");
}
else
{
 sbCondition.AppendFormat(" and RequesTypeId = '{0}'", objgs_RequestNoticeEN.RequesTypeId);
}
 if (objgs_RequestNoticeEN.TableKey == null)
{
 sbCondition.AppendFormat(" and TableKey is null");
}
else
{
 sbCondition.AppendFormat(" and TableKey = '{0}'", objgs_RequestNoticeEN.TableKey);
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
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
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
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
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
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_RequestNoticeEN._CurrTabName);
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
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_RequestNoticeEN._CurrTabName, strCondition);
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
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
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
 objSQL = clsgs_RequestNoticeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}