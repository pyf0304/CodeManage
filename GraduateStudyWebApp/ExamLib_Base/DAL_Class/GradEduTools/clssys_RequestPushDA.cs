
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clssys_RequestPushDA
 表名:sys_RequestPush(01120726)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:23
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
 /// 请求推送表(sys_RequestPush)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clssys_RequestPushDA : clsCommBase4DA
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
 return clssys_RequestPushEN._CurrTabName;
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
if (string.IsNullOrEmpty(clssys_RequestPushEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clssys_RequestPushEN._ConnectString);
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
 if (string.IsNullOrEmpty(clssys_RequestPushEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clssys_RequestPushEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clssys_RequestPushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
strSQL = "Select * from sys_RequestPush where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_sys_RequestPush(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clssys_RequestPushDA: GetDataTable_sys_RequestPush)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
strSQL = "Select * from sys_RequestPush where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clssys_RequestPushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clssys_RequestPushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
strSQL = "Select * from sys_RequestPush where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clssys_RequestPushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clssys_RequestPushDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from sys_RequestPush where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from sys_RequestPush where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clssys_RequestPushDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from sys_RequestPush where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clssys_RequestPushDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} sys_RequestPush.* from sys_RequestPush Left Join {1} on {2} where {3} and sys_RequestPush.RequestId not in (Select top {5} sys_RequestPush.RequestId from sys_RequestPush Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from sys_RequestPush where {1} and RequestId not in (Select top {2} RequestId from sys_RequestPush where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from sys_RequestPush where {1} and RequestId not in (Select top {3} RequestId from sys_RequestPush where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clssys_RequestPushDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} sys_RequestPush.* from sys_RequestPush Left Join {1} on {2} where {3} and sys_RequestPush.RequestId not in (Select top {5} sys_RequestPush.RequestId from sys_RequestPush Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from sys_RequestPush where {1} and RequestId not in (Select top {2} RequestId from sys_RequestPush where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from sys_RequestPush where {1} and RequestId not in (Select top {3} RequestId from sys_RequestPush where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clssys_RequestPushEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clssys_RequestPushDA:GetObjLst)", objException.Message));
}
List<clssys_RequestPushEN> arrObjLst = new List<clssys_RequestPushEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
strSQL = "Select * from sys_RequestPush where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestPushEN objsys_RequestPushEN = new clssys_RequestPushEN();
try
{
objsys_RequestPushEN.RequestId = TransNullToInt(objRow[consys_RequestPush.RequestId].ToString().Trim()); //RequestId
objsys_RequestPushEN.RequesTypeId = objRow[consys_RequestPush.RequesTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.RequesTypeId].ToString().Trim(); //请求类型Id
objsys_RequestPushEN.TableKey = objRow[consys_RequestPush.TableKey] == DBNull.Value ? null : objRow[consys_RequestPush.TableKey].ToString().Trim(); //表主键
objsys_RequestPushEN.ReceiveUser = objRow[consys_RequestPush.ReceiveUser] == DBNull.Value ? null : objRow[consys_RequestPush.ReceiveUser].ToString().Trim(); //接收用户
objsys_RequestPushEN.IsReply = TransNullToBool(objRow[consys_RequestPush.IsReply].ToString().Trim()); //是否回复
objsys_RequestPushEN.ReplyDate = objRow[consys_RequestPush.ReplyDate] == DBNull.Value ? null : objRow[consys_RequestPush.ReplyDate].ToString().Trim(); //回复日期
objsys_RequestPushEN.RequestUser = objRow[consys_RequestPush.RequestUser] == DBNull.Value ? null : objRow[consys_RequestPush.RequestUser].ToString().Trim(); //RequestUser
objsys_RequestPushEN.RequestDate = objRow[consys_RequestPush.RequestDate] == DBNull.Value ? null : objRow[consys_RequestPush.RequestDate].ToString().Trim(); //RequestDate
objsys_RequestPushEN.RequestStata = objRow[consys_RequestPush.RequestStata] == DBNull.Value ? null : objRow[consys_RequestPush.RequestStata].ToString().Trim(); //RequestStata
objsys_RequestPushEN.Memo = objRow[consys_RequestPush.Memo] == DBNull.Value ? null : objRow[consys_RequestPush.Memo].ToString().Trim(); //备注
objsys_RequestPushEN.IdCurrEduCls = objRow[consys_RequestPush.IdCurrEduCls] == DBNull.Value ? null : objRow[consys_RequestPush.IdCurrEduCls].ToString().Trim(); //教学班流水号
objsys_RequestPushEN.PushTypeId = objRow[consys_RequestPush.PushTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.PushTypeId].ToString().Trim(); //推送类型Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clssys_RequestPushDA: GetObjLst)", objException.Message));
}
objsys_RequestPushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objsys_RequestPushEN);
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
public List<clssys_RequestPushEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clssys_RequestPushDA:GetObjLstByTabName)", objException.Message));
}
List<clssys_RequestPushEN> arrObjLst = new List<clssys_RequestPushEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestPushEN objsys_RequestPushEN = new clssys_RequestPushEN();
try
{
objsys_RequestPushEN.RequestId = TransNullToInt(objRow[consys_RequestPush.RequestId].ToString().Trim()); //RequestId
objsys_RequestPushEN.RequesTypeId = objRow[consys_RequestPush.RequesTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.RequesTypeId].ToString().Trim(); //请求类型Id
objsys_RequestPushEN.TableKey = objRow[consys_RequestPush.TableKey] == DBNull.Value ? null : objRow[consys_RequestPush.TableKey].ToString().Trim(); //表主键
objsys_RequestPushEN.ReceiveUser = objRow[consys_RequestPush.ReceiveUser] == DBNull.Value ? null : objRow[consys_RequestPush.ReceiveUser].ToString().Trim(); //接收用户
objsys_RequestPushEN.IsReply = TransNullToBool(objRow[consys_RequestPush.IsReply].ToString().Trim()); //是否回复
objsys_RequestPushEN.ReplyDate = objRow[consys_RequestPush.ReplyDate] == DBNull.Value ? null : objRow[consys_RequestPush.ReplyDate].ToString().Trim(); //回复日期
objsys_RequestPushEN.RequestUser = objRow[consys_RequestPush.RequestUser] == DBNull.Value ? null : objRow[consys_RequestPush.RequestUser].ToString().Trim(); //RequestUser
objsys_RequestPushEN.RequestDate = objRow[consys_RequestPush.RequestDate] == DBNull.Value ? null : objRow[consys_RequestPush.RequestDate].ToString().Trim(); //RequestDate
objsys_RequestPushEN.RequestStata = objRow[consys_RequestPush.RequestStata] == DBNull.Value ? null : objRow[consys_RequestPush.RequestStata].ToString().Trim(); //RequestStata
objsys_RequestPushEN.Memo = objRow[consys_RequestPush.Memo] == DBNull.Value ? null : objRow[consys_RequestPush.Memo].ToString().Trim(); //备注
objsys_RequestPushEN.IdCurrEduCls = objRow[consys_RequestPush.IdCurrEduCls] == DBNull.Value ? null : objRow[consys_RequestPush.IdCurrEduCls].ToString().Trim(); //教学班流水号
objsys_RequestPushEN.PushTypeId = objRow[consys_RequestPush.PushTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.PushTypeId].ToString().Trim(); //推送类型Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clssys_RequestPushDA: GetObjLst)", objException.Message));
}
objsys_RequestPushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objsys_RequestPushEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getsys_RequestPush(ref clssys_RequestPushEN objsys_RequestPushEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
strSQL = "Select * from sys_RequestPush where RequestId = " + ""+ objsys_RequestPushEN.RequestId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objsys_RequestPushEN.RequestId = TransNullToInt(objDT.Rows[0][consys_RequestPush.RequestId].ToString().Trim()); //RequestId(字段类型:bigint,字段长度:8,是否可空:False)
 objsys_RequestPushEN.RequesTypeId = objDT.Rows[0][consys_RequestPush.RequesTypeId].ToString().Trim(); //请求类型Id(字段类型:char,字段长度:2,是否可空:True)
 objsys_RequestPushEN.TableKey = objDT.Rows[0][consys_RequestPush.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objsys_RequestPushEN.ReceiveUser = objDT.Rows[0][consys_RequestPush.ReceiveUser].ToString().Trim(); //接收用户(字段类型:varchar,字段长度:20,是否可空:True)
 objsys_RequestPushEN.IsReply = TransNullToBool(objDT.Rows[0][consys_RequestPush.IsReply].ToString().Trim()); //是否回复(字段类型:bit,字段长度:1,是否可空:True)
 objsys_RequestPushEN.ReplyDate = objDT.Rows[0][consys_RequestPush.ReplyDate].ToString().Trim(); //回复日期(字段类型:varchar,字段长度:20,是否可空:True)
 objsys_RequestPushEN.RequestUser = objDT.Rows[0][consys_RequestPush.RequestUser].ToString().Trim(); //RequestUser(字段类型:varchar,字段长度:20,是否可空:True)
 objsys_RequestPushEN.RequestDate = objDT.Rows[0][consys_RequestPush.RequestDate].ToString().Trim(); //RequestDate(字段类型:varchar,字段长度:20,是否可空:True)
 objsys_RequestPushEN.RequestStata = objDT.Rows[0][consys_RequestPush.RequestStata].ToString().Trim(); //RequestStata(字段类型:varchar,字段长度:10,是否可空:True)
 objsys_RequestPushEN.Memo = objDT.Rows[0][consys_RequestPush.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objsys_RequestPushEN.IdCurrEduCls = objDT.Rows[0][consys_RequestPush.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objsys_RequestPushEN.PushTypeId = objDT.Rows[0][consys_RequestPush.PushTypeId].ToString().Trim(); //推送类型Id(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clssys_RequestPushDA: Getsys_RequestPush)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngRequestId">表关键字</param>
 /// <returns>表对象</returns>
public clssys_RequestPushEN GetObjByRequestId(long lngRequestId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
strSQL = "Select * from sys_RequestPush where RequestId = " + ""+ lngRequestId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clssys_RequestPushEN objsys_RequestPushEN = new clssys_RequestPushEN();
try
{
 objsys_RequestPushEN.RequestId = Int32.Parse(objRow[consys_RequestPush.RequestId].ToString().Trim()); //RequestId(字段类型:bigint,字段长度:8,是否可空:False)
 objsys_RequestPushEN.RequesTypeId = objRow[consys_RequestPush.RequesTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.RequesTypeId].ToString().Trim(); //请求类型Id(字段类型:char,字段长度:2,是否可空:True)
 objsys_RequestPushEN.TableKey = objRow[consys_RequestPush.TableKey] == DBNull.Value ? null : objRow[consys_RequestPush.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objsys_RequestPushEN.ReceiveUser = objRow[consys_RequestPush.ReceiveUser] == DBNull.Value ? null : objRow[consys_RequestPush.ReceiveUser].ToString().Trim(); //接收用户(字段类型:varchar,字段长度:20,是否可空:True)
 objsys_RequestPushEN.IsReply = clsEntityBase2.TransNullToBool_S(objRow[consys_RequestPush.IsReply].ToString().Trim()); //是否回复(字段类型:bit,字段长度:1,是否可空:True)
 objsys_RequestPushEN.ReplyDate = objRow[consys_RequestPush.ReplyDate] == DBNull.Value ? null : objRow[consys_RequestPush.ReplyDate].ToString().Trim(); //回复日期(字段类型:varchar,字段长度:20,是否可空:True)
 objsys_RequestPushEN.RequestUser = objRow[consys_RequestPush.RequestUser] == DBNull.Value ? null : objRow[consys_RequestPush.RequestUser].ToString().Trim(); //RequestUser(字段类型:varchar,字段长度:20,是否可空:True)
 objsys_RequestPushEN.RequestDate = objRow[consys_RequestPush.RequestDate] == DBNull.Value ? null : objRow[consys_RequestPush.RequestDate].ToString().Trim(); //RequestDate(字段类型:varchar,字段长度:20,是否可空:True)
 objsys_RequestPushEN.RequestStata = objRow[consys_RequestPush.RequestStata] == DBNull.Value ? null : objRow[consys_RequestPush.RequestStata].ToString().Trim(); //RequestStata(字段类型:varchar,字段长度:10,是否可空:True)
 objsys_RequestPushEN.Memo = objRow[consys_RequestPush.Memo] == DBNull.Value ? null : objRow[consys_RequestPush.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objsys_RequestPushEN.IdCurrEduCls = objRow[consys_RequestPush.IdCurrEduCls] == DBNull.Value ? null : objRow[consys_RequestPush.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objsys_RequestPushEN.PushTypeId = objRow[consys_RequestPush.PushTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.PushTypeId].ToString().Trim(); //推送类型Id(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clssys_RequestPushDA: GetObjByRequestId)", objException.Message));
}
return objsys_RequestPushEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clssys_RequestPushEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clssys_RequestPushDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
strSQL = "Select * from sys_RequestPush where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clssys_RequestPushEN objsys_RequestPushEN = new clssys_RequestPushEN()
{
RequestId = TransNullToInt(objRow[consys_RequestPush.RequestId].ToString().Trim()), //RequestId
RequesTypeId = objRow[consys_RequestPush.RequesTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.RequesTypeId].ToString().Trim(), //请求类型Id
TableKey = objRow[consys_RequestPush.TableKey] == DBNull.Value ? null : objRow[consys_RequestPush.TableKey].ToString().Trim(), //表主键
ReceiveUser = objRow[consys_RequestPush.ReceiveUser] == DBNull.Value ? null : objRow[consys_RequestPush.ReceiveUser].ToString().Trim(), //接收用户
IsReply = TransNullToBool(objRow[consys_RequestPush.IsReply].ToString().Trim()), //是否回复
ReplyDate = objRow[consys_RequestPush.ReplyDate] == DBNull.Value ? null : objRow[consys_RequestPush.ReplyDate].ToString().Trim(), //回复日期
RequestUser = objRow[consys_RequestPush.RequestUser] == DBNull.Value ? null : objRow[consys_RequestPush.RequestUser].ToString().Trim(), //RequestUser
RequestDate = objRow[consys_RequestPush.RequestDate] == DBNull.Value ? null : objRow[consys_RequestPush.RequestDate].ToString().Trim(), //RequestDate
RequestStata = objRow[consys_RequestPush.RequestStata] == DBNull.Value ? null : objRow[consys_RequestPush.RequestStata].ToString().Trim(), //RequestStata
Memo = objRow[consys_RequestPush.Memo] == DBNull.Value ? null : objRow[consys_RequestPush.Memo].ToString().Trim(), //备注
IdCurrEduCls = objRow[consys_RequestPush.IdCurrEduCls] == DBNull.Value ? null : objRow[consys_RequestPush.IdCurrEduCls].ToString().Trim(), //教学班流水号
PushTypeId = objRow[consys_RequestPush.PushTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.PushTypeId].ToString().Trim() //推送类型Id
};
objsys_RequestPushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objsys_RequestPushEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clssys_RequestPushDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clssys_RequestPushEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clssys_RequestPushEN objsys_RequestPushEN = new clssys_RequestPushEN();
try
{
objsys_RequestPushEN.RequestId = TransNullToInt(objRow[consys_RequestPush.RequestId].ToString().Trim()); //RequestId
objsys_RequestPushEN.RequesTypeId = objRow[consys_RequestPush.RequesTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.RequesTypeId].ToString().Trim(); //请求类型Id
objsys_RequestPushEN.TableKey = objRow[consys_RequestPush.TableKey] == DBNull.Value ? null : objRow[consys_RequestPush.TableKey].ToString().Trim(); //表主键
objsys_RequestPushEN.ReceiveUser = objRow[consys_RequestPush.ReceiveUser] == DBNull.Value ? null : objRow[consys_RequestPush.ReceiveUser].ToString().Trim(); //接收用户
objsys_RequestPushEN.IsReply = TransNullToBool(objRow[consys_RequestPush.IsReply].ToString().Trim()); //是否回复
objsys_RequestPushEN.ReplyDate = objRow[consys_RequestPush.ReplyDate] == DBNull.Value ? null : objRow[consys_RequestPush.ReplyDate].ToString().Trim(); //回复日期
objsys_RequestPushEN.RequestUser = objRow[consys_RequestPush.RequestUser] == DBNull.Value ? null : objRow[consys_RequestPush.RequestUser].ToString().Trim(); //RequestUser
objsys_RequestPushEN.RequestDate = objRow[consys_RequestPush.RequestDate] == DBNull.Value ? null : objRow[consys_RequestPush.RequestDate].ToString().Trim(); //RequestDate
objsys_RequestPushEN.RequestStata = objRow[consys_RequestPush.RequestStata] == DBNull.Value ? null : objRow[consys_RequestPush.RequestStata].ToString().Trim(); //RequestStata
objsys_RequestPushEN.Memo = objRow[consys_RequestPush.Memo] == DBNull.Value ? null : objRow[consys_RequestPush.Memo].ToString().Trim(); //备注
objsys_RequestPushEN.IdCurrEduCls = objRow[consys_RequestPush.IdCurrEduCls] == DBNull.Value ? null : objRow[consys_RequestPush.IdCurrEduCls].ToString().Trim(); //教学班流水号
objsys_RequestPushEN.PushTypeId = objRow[consys_RequestPush.PushTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.PushTypeId].ToString().Trim(); //推送类型Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clssys_RequestPushDA: GetObjByDataRowsys_RequestPush)", objException.Message));
}
objsys_RequestPushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objsys_RequestPushEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clssys_RequestPushEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clssys_RequestPushEN objsys_RequestPushEN = new clssys_RequestPushEN();
try
{
objsys_RequestPushEN.RequestId = TransNullToInt(objRow[consys_RequestPush.RequestId].ToString().Trim()); //RequestId
objsys_RequestPushEN.RequesTypeId = objRow[consys_RequestPush.RequesTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.RequesTypeId].ToString().Trim(); //请求类型Id
objsys_RequestPushEN.TableKey = objRow[consys_RequestPush.TableKey] == DBNull.Value ? null : objRow[consys_RequestPush.TableKey].ToString().Trim(); //表主键
objsys_RequestPushEN.ReceiveUser = objRow[consys_RequestPush.ReceiveUser] == DBNull.Value ? null : objRow[consys_RequestPush.ReceiveUser].ToString().Trim(); //接收用户
objsys_RequestPushEN.IsReply = TransNullToBool(objRow[consys_RequestPush.IsReply].ToString().Trim()); //是否回复
objsys_RequestPushEN.ReplyDate = objRow[consys_RequestPush.ReplyDate] == DBNull.Value ? null : objRow[consys_RequestPush.ReplyDate].ToString().Trim(); //回复日期
objsys_RequestPushEN.RequestUser = objRow[consys_RequestPush.RequestUser] == DBNull.Value ? null : objRow[consys_RequestPush.RequestUser].ToString().Trim(); //RequestUser
objsys_RequestPushEN.RequestDate = objRow[consys_RequestPush.RequestDate] == DBNull.Value ? null : objRow[consys_RequestPush.RequestDate].ToString().Trim(); //RequestDate
objsys_RequestPushEN.RequestStata = objRow[consys_RequestPush.RequestStata] == DBNull.Value ? null : objRow[consys_RequestPush.RequestStata].ToString().Trim(); //RequestStata
objsys_RequestPushEN.Memo = objRow[consys_RequestPush.Memo] == DBNull.Value ? null : objRow[consys_RequestPush.Memo].ToString().Trim(); //备注
objsys_RequestPushEN.IdCurrEduCls = objRow[consys_RequestPush.IdCurrEduCls] == DBNull.Value ? null : objRow[consys_RequestPush.IdCurrEduCls].ToString().Trim(); //教学班流水号
objsys_RequestPushEN.PushTypeId = objRow[consys_RequestPush.PushTypeId] == DBNull.Value ? null : objRow[consys_RequestPush.PushTypeId].ToString().Trim(); //推送类型Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clssys_RequestPushDA: GetObjByDataRow)", objException.Message));
}
objsys_RequestPushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objsys_RequestPushEN;
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
objSQL = clssys_RequestPushDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clssys_RequestPushEN._CurrTabName, consys_RequestPush.RequestId, 8, "");
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
objSQL = clssys_RequestPushDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clssys_RequestPushEN._CurrTabName, consys_RequestPush.RequestId, 8, strPrefix);
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
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select RequestId from sys_RequestPush where " + strCondition;
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
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select RequestId from sys_RequestPush where " + strCondition;
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
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("sys_RequestPush", "RequestId = " + ""+ lngRequestId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clssys_RequestPushDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("sys_RequestPush", strCondition))
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
objSQL = clssys_RequestPushDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("sys_RequestPush");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clssys_RequestPushEN objsys_RequestPushEN)
 {
 if (objsys_RequestPushEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objsys_RequestPushEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
strSQL = "Select * from sys_RequestPush where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "sys_RequestPush");
objRow = objDS.Tables["sys_RequestPush"].NewRow();
 if (objsys_RequestPushEN.RequesTypeId !=  "")
 {
objRow[consys_RequestPush.RequesTypeId] = objsys_RequestPushEN.RequesTypeId; //请求类型Id
 }
 if (objsys_RequestPushEN.TableKey !=  "")
 {
objRow[consys_RequestPush.TableKey] = objsys_RequestPushEN.TableKey; //表主键
 }
 if (objsys_RequestPushEN.ReceiveUser !=  "")
 {
objRow[consys_RequestPush.ReceiveUser] = objsys_RequestPushEN.ReceiveUser; //接收用户
 }
objRow[consys_RequestPush.IsReply] = objsys_RequestPushEN.IsReply; //是否回复
 if (objsys_RequestPushEN.ReplyDate !=  "")
 {
objRow[consys_RequestPush.ReplyDate] = objsys_RequestPushEN.ReplyDate; //回复日期
 }
 if (objsys_RequestPushEN.RequestUser !=  "")
 {
objRow[consys_RequestPush.RequestUser] = objsys_RequestPushEN.RequestUser; //RequestUser
 }
 if (objsys_RequestPushEN.RequestDate !=  "")
 {
objRow[consys_RequestPush.RequestDate] = objsys_RequestPushEN.RequestDate; //RequestDate
 }
 if (objsys_RequestPushEN.RequestStata !=  "")
 {
objRow[consys_RequestPush.RequestStata] = objsys_RequestPushEN.RequestStata; //RequestStata
 }
 if (objsys_RequestPushEN.Memo !=  "")
 {
objRow[consys_RequestPush.Memo] = objsys_RequestPushEN.Memo; //备注
 }
 if (objsys_RequestPushEN.IdCurrEduCls !=  "")
 {
objRow[consys_RequestPush.IdCurrEduCls] = objsys_RequestPushEN.IdCurrEduCls; //教学班流水号
 }
 if (objsys_RequestPushEN.PushTypeId !=  "")
 {
objRow[consys_RequestPush.PushTypeId] = objsys_RequestPushEN.PushTypeId; //推送类型Id
 }
objDS.Tables[clssys_RequestPushEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clssys_RequestPushEN._CurrTabName);
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
 /// <param name = "objsys_RequestPushEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clssys_RequestPushEN objsys_RequestPushEN)
{
 if (objsys_RequestPushEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objsys_RequestPushEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objsys_RequestPushEN.RequesTypeId !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.RequesTypeId);
 var strRequesTypeId = objsys_RequestPushEN.RequesTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequesTypeId + "'");
 }
 
 if (objsys_RequestPushEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.TableKey);
 var strTableKey = objsys_RequestPushEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objsys_RequestPushEN.ReceiveUser !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.ReceiveUser);
 var strReceiveUser = objsys_RequestPushEN.ReceiveUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReceiveUser + "'");
 }
 
 arrFieldListForInsert.Add(consys_RequestPush.IsReply);
 arrValueListForInsert.Add("'" + (objsys_RequestPushEN.IsReply  ==  false ? "0" : "1") + "'");
 
 if (objsys_RequestPushEN.ReplyDate !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.ReplyDate);
 var strReplyDate = objsys_RequestPushEN.ReplyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReplyDate + "'");
 }
 
 if (objsys_RequestPushEN.RequestUser !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.RequestUser);
 var strRequestUser = objsys_RequestPushEN.RequestUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestUser + "'");
 }
 
 if (objsys_RequestPushEN.RequestDate !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.RequestDate);
 var strRequestDate = objsys_RequestPushEN.RequestDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestDate + "'");
 }
 
 if (objsys_RequestPushEN.RequestStata !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.RequestStata);
 var strRequestStata = objsys_RequestPushEN.RequestStata.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestStata + "'");
 }
 
 if (objsys_RequestPushEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.Memo);
 var strMemo = objsys_RequestPushEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objsys_RequestPushEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.IdCurrEduCls);
 var strIdCurrEduCls = objsys_RequestPushEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objsys_RequestPushEN.PushTypeId !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.PushTypeId);
 var strPushTypeId = objsys_RequestPushEN.PushTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPushTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into sys_RequestPush");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clssys_RequestPushEN objsys_RequestPushEN)
{
 if (objsys_RequestPushEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objsys_RequestPushEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objsys_RequestPushEN.RequesTypeId !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.RequesTypeId);
 var strRequesTypeId = objsys_RequestPushEN.RequesTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequesTypeId + "'");
 }
 
 if (objsys_RequestPushEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.TableKey);
 var strTableKey = objsys_RequestPushEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objsys_RequestPushEN.ReceiveUser !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.ReceiveUser);
 var strReceiveUser = objsys_RequestPushEN.ReceiveUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReceiveUser + "'");
 }
 
 arrFieldListForInsert.Add(consys_RequestPush.IsReply);
 arrValueListForInsert.Add("'" + (objsys_RequestPushEN.IsReply  ==  false ? "0" : "1") + "'");
 
 if (objsys_RequestPushEN.ReplyDate !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.ReplyDate);
 var strReplyDate = objsys_RequestPushEN.ReplyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReplyDate + "'");
 }
 
 if (objsys_RequestPushEN.RequestUser !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.RequestUser);
 var strRequestUser = objsys_RequestPushEN.RequestUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestUser + "'");
 }
 
 if (objsys_RequestPushEN.RequestDate !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.RequestDate);
 var strRequestDate = objsys_RequestPushEN.RequestDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestDate + "'");
 }
 
 if (objsys_RequestPushEN.RequestStata !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.RequestStata);
 var strRequestStata = objsys_RequestPushEN.RequestStata.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestStata + "'");
 }
 
 if (objsys_RequestPushEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.Memo);
 var strMemo = objsys_RequestPushEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objsys_RequestPushEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.IdCurrEduCls);
 var strIdCurrEduCls = objsys_RequestPushEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objsys_RequestPushEN.PushTypeId !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.PushTypeId);
 var strPushTypeId = objsys_RequestPushEN.PushTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPushTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into sys_RequestPush");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clssys_RequestPushEN objsys_RequestPushEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objsys_RequestPushEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objsys_RequestPushEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objsys_RequestPushEN.RequesTypeId !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.RequesTypeId);
 var strRequesTypeId = objsys_RequestPushEN.RequesTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequesTypeId + "'");
 }
 
 if (objsys_RequestPushEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.TableKey);
 var strTableKey = objsys_RequestPushEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objsys_RequestPushEN.ReceiveUser !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.ReceiveUser);
 var strReceiveUser = objsys_RequestPushEN.ReceiveUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReceiveUser + "'");
 }
 
 arrFieldListForInsert.Add(consys_RequestPush.IsReply);
 arrValueListForInsert.Add("'" + (objsys_RequestPushEN.IsReply  ==  false ? "0" : "1") + "'");
 
 if (objsys_RequestPushEN.ReplyDate !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.ReplyDate);
 var strReplyDate = objsys_RequestPushEN.ReplyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReplyDate + "'");
 }
 
 if (objsys_RequestPushEN.RequestUser !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.RequestUser);
 var strRequestUser = objsys_RequestPushEN.RequestUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestUser + "'");
 }
 
 if (objsys_RequestPushEN.RequestDate !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.RequestDate);
 var strRequestDate = objsys_RequestPushEN.RequestDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestDate + "'");
 }
 
 if (objsys_RequestPushEN.RequestStata !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.RequestStata);
 var strRequestStata = objsys_RequestPushEN.RequestStata.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestStata + "'");
 }
 
 if (objsys_RequestPushEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.Memo);
 var strMemo = objsys_RequestPushEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objsys_RequestPushEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.IdCurrEduCls);
 var strIdCurrEduCls = objsys_RequestPushEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objsys_RequestPushEN.PushTypeId !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.PushTypeId);
 var strPushTypeId = objsys_RequestPushEN.PushTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPushTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into sys_RequestPush");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clssys_RequestPushEN objsys_RequestPushEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objsys_RequestPushEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objsys_RequestPushEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objsys_RequestPushEN.RequesTypeId !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.RequesTypeId);
 var strRequesTypeId = objsys_RequestPushEN.RequesTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequesTypeId + "'");
 }
 
 if (objsys_RequestPushEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.TableKey);
 var strTableKey = objsys_RequestPushEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objsys_RequestPushEN.ReceiveUser !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.ReceiveUser);
 var strReceiveUser = objsys_RequestPushEN.ReceiveUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReceiveUser + "'");
 }
 
 arrFieldListForInsert.Add(consys_RequestPush.IsReply);
 arrValueListForInsert.Add("'" + (objsys_RequestPushEN.IsReply  ==  false ? "0" : "1") + "'");
 
 if (objsys_RequestPushEN.ReplyDate !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.ReplyDate);
 var strReplyDate = objsys_RequestPushEN.ReplyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReplyDate + "'");
 }
 
 if (objsys_RequestPushEN.RequestUser !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.RequestUser);
 var strRequestUser = objsys_RequestPushEN.RequestUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestUser + "'");
 }
 
 if (objsys_RequestPushEN.RequestDate !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.RequestDate);
 var strRequestDate = objsys_RequestPushEN.RequestDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestDate + "'");
 }
 
 if (objsys_RequestPushEN.RequestStata !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.RequestStata);
 var strRequestStata = objsys_RequestPushEN.RequestStata.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestStata + "'");
 }
 
 if (objsys_RequestPushEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.Memo);
 var strMemo = objsys_RequestPushEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objsys_RequestPushEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.IdCurrEduCls);
 var strIdCurrEduCls = objsys_RequestPushEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objsys_RequestPushEN.PushTypeId !=  null)
 {
 arrFieldListForInsert.Add(consys_RequestPush.PushTypeId);
 var strPushTypeId = objsys_RequestPushEN.PushTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPushTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into sys_RequestPush");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewsys_RequestPushs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
strSQL = "Select * from sys_RequestPush where RequestId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "sys_RequestPush");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngRequestId = TransNullToInt(oRow[consys_RequestPush.RequestId].ToString().Trim());
if (IsExist(lngRequestId))
{
 string strResult = "关键字变量值为:" + string.Format("RequestId = {0}", lngRequestId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clssys_RequestPushEN._CurrTabName ].NewRow();
objRow[consys_RequestPush.RequesTypeId] = oRow[consys_RequestPush.RequesTypeId].ToString().Trim(); //请求类型Id
objRow[consys_RequestPush.TableKey] = oRow[consys_RequestPush.TableKey].ToString().Trim(); //表主键
objRow[consys_RequestPush.ReceiveUser] = oRow[consys_RequestPush.ReceiveUser].ToString().Trim(); //接收用户
objRow[consys_RequestPush.IsReply] = oRow[consys_RequestPush.IsReply].ToString().Trim(); //是否回复
objRow[consys_RequestPush.ReplyDate] = oRow[consys_RequestPush.ReplyDate].ToString().Trim(); //回复日期
objRow[consys_RequestPush.RequestUser] = oRow[consys_RequestPush.RequestUser].ToString().Trim(); //RequestUser
objRow[consys_RequestPush.RequestDate] = oRow[consys_RequestPush.RequestDate].ToString().Trim(); //RequestDate
objRow[consys_RequestPush.RequestStata] = oRow[consys_RequestPush.RequestStata].ToString().Trim(); //RequestStata
objRow[consys_RequestPush.Memo] = oRow[consys_RequestPush.Memo].ToString().Trim(); //备注
objRow[consys_RequestPush.IdCurrEduCls] = oRow[consys_RequestPush.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[consys_RequestPush.PushTypeId] = oRow[consys_RequestPush.PushTypeId].ToString().Trim(); //推送类型Id
 objDS.Tables[clssys_RequestPushEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clssys_RequestPushEN._CurrTabName);
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
 /// <param name = "objsys_RequestPushEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clssys_RequestPushEN objsys_RequestPushEN)
{
 if (objsys_RequestPushEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objsys_RequestPushEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
strSQL = "Select * from sys_RequestPush where RequestId = " + ""+ objsys_RequestPushEN.RequestId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clssys_RequestPushEN._CurrTabName);
if (objDS.Tables[clssys_RequestPushEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:RequestId = " + ""+ objsys_RequestPushEN.RequestId+"");
return false;
}
objRow = objDS.Tables[clssys_RequestPushEN._CurrTabName].Rows[0];
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequesTypeId))
 {
objRow[consys_RequestPush.RequesTypeId] = objsys_RequestPushEN.RequesTypeId; //请求类型Id
 }
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.TableKey))
 {
objRow[consys_RequestPush.TableKey] = objsys_RequestPushEN.TableKey; //表主键
 }
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.ReceiveUser))
 {
objRow[consys_RequestPush.ReceiveUser] = objsys_RequestPushEN.ReceiveUser; //接收用户
 }
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.IsReply))
 {
objRow[consys_RequestPush.IsReply] = objsys_RequestPushEN.IsReply; //是否回复
 }
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.ReplyDate))
 {
objRow[consys_RequestPush.ReplyDate] = objsys_RequestPushEN.ReplyDate; //回复日期
 }
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequestUser))
 {
objRow[consys_RequestPush.RequestUser] = objsys_RequestPushEN.RequestUser; //RequestUser
 }
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequestDate))
 {
objRow[consys_RequestPush.RequestDate] = objsys_RequestPushEN.RequestDate; //RequestDate
 }
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequestStata))
 {
objRow[consys_RequestPush.RequestStata] = objsys_RequestPushEN.RequestStata; //RequestStata
 }
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.Memo))
 {
objRow[consys_RequestPush.Memo] = objsys_RequestPushEN.Memo; //备注
 }
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.IdCurrEduCls))
 {
objRow[consys_RequestPush.IdCurrEduCls] = objsys_RequestPushEN.IdCurrEduCls; //教学班流水号
 }
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.PushTypeId))
 {
objRow[consys_RequestPush.PushTypeId] = objsys_RequestPushEN.PushTypeId; //推送类型Id
 }
try
{
objDA.Update(objDS, clssys_RequestPushEN._CurrTabName);
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
 /// <param name = "objsys_RequestPushEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clssys_RequestPushEN objsys_RequestPushEN)
{
 if (objsys_RequestPushEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objsys_RequestPushEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update sys_RequestPush Set ");
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequesTypeId))
 {
 if (objsys_RequestPushEN.RequesTypeId !=  null)
 {
 var strRequesTypeId = objsys_RequestPushEN.RequesTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequesTypeId, consys_RequestPush.RequesTypeId); //请求类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.RequesTypeId); //请求类型Id
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.TableKey))
 {
 if (objsys_RequestPushEN.TableKey !=  null)
 {
 var strTableKey = objsys_RequestPushEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableKey, consys_RequestPush.TableKey); //表主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.TableKey); //表主键
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.ReceiveUser))
 {
 if (objsys_RequestPushEN.ReceiveUser !=  null)
 {
 var strReceiveUser = objsys_RequestPushEN.ReceiveUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReceiveUser, consys_RequestPush.ReceiveUser); //接收用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.ReceiveUser); //接收用户
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.IsReply))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objsys_RequestPushEN.IsReply == true?"1":"0", consys_RequestPush.IsReply); //是否回复
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.ReplyDate))
 {
 if (objsys_RequestPushEN.ReplyDate !=  null)
 {
 var strReplyDate = objsys_RequestPushEN.ReplyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReplyDate, consys_RequestPush.ReplyDate); //回复日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.ReplyDate); //回复日期
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequestUser))
 {
 if (objsys_RequestPushEN.RequestUser !=  null)
 {
 var strRequestUser = objsys_RequestPushEN.RequestUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequestUser, consys_RequestPush.RequestUser); //RequestUser
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.RequestUser); //RequestUser
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequestDate))
 {
 if (objsys_RequestPushEN.RequestDate !=  null)
 {
 var strRequestDate = objsys_RequestPushEN.RequestDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequestDate, consys_RequestPush.RequestDate); //RequestDate
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.RequestDate); //RequestDate
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequestStata))
 {
 if (objsys_RequestPushEN.RequestStata !=  null)
 {
 var strRequestStata = objsys_RequestPushEN.RequestStata.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequestStata, consys_RequestPush.RequestStata); //RequestStata
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.RequestStata); //RequestStata
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.Memo))
 {
 if (objsys_RequestPushEN.Memo !=  null)
 {
 var strMemo = objsys_RequestPushEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, consys_RequestPush.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.Memo); //备注
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.IdCurrEduCls))
 {
 if (objsys_RequestPushEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objsys_RequestPushEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, consys_RequestPush.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.PushTypeId))
 {
 if (objsys_RequestPushEN.PushTypeId !=  null)
 {
 var strPushTypeId = objsys_RequestPushEN.PushTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPushTypeId, consys_RequestPush.PushTypeId); //推送类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.PushTypeId); //推送类型Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RequestId = {0}", objsys_RequestPushEN.RequestId); 
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
 /// <param name = "objsys_RequestPushEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clssys_RequestPushEN objsys_RequestPushEN, string strCondition)
{
 if (objsys_RequestPushEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objsys_RequestPushEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update sys_RequestPush Set ");
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequesTypeId))
 {
 if (objsys_RequestPushEN.RequesTypeId !=  null)
 {
 var strRequesTypeId = objsys_RequestPushEN.RequesTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequesTypeId = '{0}',", strRequesTypeId); //请求类型Id
 }
 else
 {
 sbSQL.Append(" RequesTypeId = null,"); //请求类型Id
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.TableKey))
 {
 if (objsys_RequestPushEN.TableKey !=  null)
 {
 var strTableKey = objsys_RequestPushEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableKey = '{0}',", strTableKey); //表主键
 }
 else
 {
 sbSQL.Append(" TableKey = null,"); //表主键
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.ReceiveUser))
 {
 if (objsys_RequestPushEN.ReceiveUser !=  null)
 {
 var strReceiveUser = objsys_RequestPushEN.ReceiveUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReceiveUser = '{0}',", strReceiveUser); //接收用户
 }
 else
 {
 sbSQL.Append(" ReceiveUser = null,"); //接收用户
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.IsReply))
 {
 sbSQL.AppendFormat(" IsReply = '{0}',", objsys_RequestPushEN.IsReply == true?"1":"0"); //是否回复
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.ReplyDate))
 {
 if (objsys_RequestPushEN.ReplyDate !=  null)
 {
 var strReplyDate = objsys_RequestPushEN.ReplyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReplyDate = '{0}',", strReplyDate); //回复日期
 }
 else
 {
 sbSQL.Append(" ReplyDate = null,"); //回复日期
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequestUser))
 {
 if (objsys_RequestPushEN.RequestUser !=  null)
 {
 var strRequestUser = objsys_RequestPushEN.RequestUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequestUser = '{0}',", strRequestUser); //RequestUser
 }
 else
 {
 sbSQL.Append(" RequestUser = null,"); //RequestUser
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequestDate))
 {
 if (objsys_RequestPushEN.RequestDate !=  null)
 {
 var strRequestDate = objsys_RequestPushEN.RequestDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequestDate = '{0}',", strRequestDate); //RequestDate
 }
 else
 {
 sbSQL.Append(" RequestDate = null,"); //RequestDate
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequestStata))
 {
 if (objsys_RequestPushEN.RequestStata !=  null)
 {
 var strRequestStata = objsys_RequestPushEN.RequestStata.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequestStata = '{0}',", strRequestStata); //RequestStata
 }
 else
 {
 sbSQL.Append(" RequestStata = null,"); //RequestStata
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.Memo))
 {
 if (objsys_RequestPushEN.Memo !=  null)
 {
 var strMemo = objsys_RequestPushEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.IdCurrEduCls))
 {
 if (objsys_RequestPushEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objsys_RequestPushEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.PushTypeId))
 {
 if (objsys_RequestPushEN.PushTypeId !=  null)
 {
 var strPushTypeId = objsys_RequestPushEN.PushTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PushTypeId = '{0}',", strPushTypeId); //推送类型Id
 }
 else
 {
 sbSQL.Append(" PushTypeId = null,"); //推送类型Id
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
 /// <param name = "objsys_RequestPushEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clssys_RequestPushEN objsys_RequestPushEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objsys_RequestPushEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objsys_RequestPushEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update sys_RequestPush Set ");
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequesTypeId))
 {
 if (objsys_RequestPushEN.RequesTypeId !=  null)
 {
 var strRequesTypeId = objsys_RequestPushEN.RequesTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequesTypeId = '{0}',", strRequesTypeId); //请求类型Id
 }
 else
 {
 sbSQL.Append(" RequesTypeId = null,"); //请求类型Id
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.TableKey))
 {
 if (objsys_RequestPushEN.TableKey !=  null)
 {
 var strTableKey = objsys_RequestPushEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableKey = '{0}',", strTableKey); //表主键
 }
 else
 {
 sbSQL.Append(" TableKey = null,"); //表主键
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.ReceiveUser))
 {
 if (objsys_RequestPushEN.ReceiveUser !=  null)
 {
 var strReceiveUser = objsys_RequestPushEN.ReceiveUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReceiveUser = '{0}',", strReceiveUser); //接收用户
 }
 else
 {
 sbSQL.Append(" ReceiveUser = null,"); //接收用户
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.IsReply))
 {
 sbSQL.AppendFormat(" IsReply = '{0}',", objsys_RequestPushEN.IsReply == true?"1":"0"); //是否回复
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.ReplyDate))
 {
 if (objsys_RequestPushEN.ReplyDate !=  null)
 {
 var strReplyDate = objsys_RequestPushEN.ReplyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReplyDate = '{0}',", strReplyDate); //回复日期
 }
 else
 {
 sbSQL.Append(" ReplyDate = null,"); //回复日期
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequestUser))
 {
 if (objsys_RequestPushEN.RequestUser !=  null)
 {
 var strRequestUser = objsys_RequestPushEN.RequestUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequestUser = '{0}',", strRequestUser); //RequestUser
 }
 else
 {
 sbSQL.Append(" RequestUser = null,"); //RequestUser
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequestDate))
 {
 if (objsys_RequestPushEN.RequestDate !=  null)
 {
 var strRequestDate = objsys_RequestPushEN.RequestDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequestDate = '{0}',", strRequestDate); //RequestDate
 }
 else
 {
 sbSQL.Append(" RequestDate = null,"); //RequestDate
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequestStata))
 {
 if (objsys_RequestPushEN.RequestStata !=  null)
 {
 var strRequestStata = objsys_RequestPushEN.RequestStata.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequestStata = '{0}',", strRequestStata); //RequestStata
 }
 else
 {
 sbSQL.Append(" RequestStata = null,"); //RequestStata
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.Memo))
 {
 if (objsys_RequestPushEN.Memo !=  null)
 {
 var strMemo = objsys_RequestPushEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.IdCurrEduCls))
 {
 if (objsys_RequestPushEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objsys_RequestPushEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.PushTypeId))
 {
 if (objsys_RequestPushEN.PushTypeId !=  null)
 {
 var strPushTypeId = objsys_RequestPushEN.PushTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PushTypeId = '{0}',", strPushTypeId); //推送类型Id
 }
 else
 {
 sbSQL.Append(" PushTypeId = null,"); //推送类型Id
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
 /// <param name = "objsys_RequestPushEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clssys_RequestPushEN objsys_RequestPushEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objsys_RequestPushEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objsys_RequestPushEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update sys_RequestPush Set ");
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequesTypeId))
 {
 if (objsys_RequestPushEN.RequesTypeId !=  null)
 {
 var strRequesTypeId = objsys_RequestPushEN.RequesTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequesTypeId, consys_RequestPush.RequesTypeId); //请求类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.RequesTypeId); //请求类型Id
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.TableKey))
 {
 if (objsys_RequestPushEN.TableKey !=  null)
 {
 var strTableKey = objsys_RequestPushEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableKey, consys_RequestPush.TableKey); //表主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.TableKey); //表主键
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.ReceiveUser))
 {
 if (objsys_RequestPushEN.ReceiveUser !=  null)
 {
 var strReceiveUser = objsys_RequestPushEN.ReceiveUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReceiveUser, consys_RequestPush.ReceiveUser); //接收用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.ReceiveUser); //接收用户
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.IsReply))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objsys_RequestPushEN.IsReply == true?"1":"0", consys_RequestPush.IsReply); //是否回复
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.ReplyDate))
 {
 if (objsys_RequestPushEN.ReplyDate !=  null)
 {
 var strReplyDate = objsys_RequestPushEN.ReplyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReplyDate, consys_RequestPush.ReplyDate); //回复日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.ReplyDate); //回复日期
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequestUser))
 {
 if (objsys_RequestPushEN.RequestUser !=  null)
 {
 var strRequestUser = objsys_RequestPushEN.RequestUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequestUser, consys_RequestPush.RequestUser); //RequestUser
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.RequestUser); //RequestUser
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequestDate))
 {
 if (objsys_RequestPushEN.RequestDate !=  null)
 {
 var strRequestDate = objsys_RequestPushEN.RequestDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequestDate, consys_RequestPush.RequestDate); //RequestDate
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.RequestDate); //RequestDate
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.RequestStata))
 {
 if (objsys_RequestPushEN.RequestStata !=  null)
 {
 var strRequestStata = objsys_RequestPushEN.RequestStata.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequestStata, consys_RequestPush.RequestStata); //RequestStata
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.RequestStata); //RequestStata
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.Memo))
 {
 if (objsys_RequestPushEN.Memo !=  null)
 {
 var strMemo = objsys_RequestPushEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, consys_RequestPush.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.Memo); //备注
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.IdCurrEduCls))
 {
 if (objsys_RequestPushEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objsys_RequestPushEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, consys_RequestPush.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objsys_RequestPushEN.IsUpdated(consys_RequestPush.PushTypeId))
 {
 if (objsys_RequestPushEN.PushTypeId !=  null)
 {
 var strPushTypeId = objsys_RequestPushEN.PushTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPushTypeId, consys_RequestPush.PushTypeId); //推送类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",consys_RequestPush.PushTypeId); //推送类型Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RequestId = {0}", objsys_RequestPushEN.RequestId); 
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
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngRequestId,
};
 objSQL.ExecSP("sys_RequestPush_Delete", values);
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
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
//删除sys_RequestPush本表中与当前对象有关的记录
strSQL = strSQL + "Delete from sys_RequestPush where RequestId = " + ""+ lngRequestId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delsys_RequestPush(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
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
//删除sys_RequestPush本表中与当前对象有关的记录
strSQL = strSQL + "Delete from sys_RequestPush where RequestId in (" + strKeyList + ")";
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
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
//删除sys_RequestPush本表中与当前对象有关的记录
strSQL = strSQL + "Delete from sys_RequestPush where RequestId = " + ""+ lngRequestId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delsys_RequestPush(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clssys_RequestPushDA: Delsys_RequestPush)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from sys_RequestPush where " + strCondition ;
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
public bool Delsys_RequestPushWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clssys_RequestPushDA: Delsys_RequestPushWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from sys_RequestPush where " + strCondition ;
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
 /// <param name = "objsys_RequestPushENS">源对象</param>
 /// <param name = "objsys_RequestPushENT">目标对象</param>
public void CopyTo(clssys_RequestPushEN objsys_RequestPushENS, clssys_RequestPushEN objsys_RequestPushENT)
{
objsys_RequestPushENT.RequestId = objsys_RequestPushENS.RequestId; //RequestId
objsys_RequestPushENT.RequesTypeId = objsys_RequestPushENS.RequesTypeId; //请求类型Id
objsys_RequestPushENT.TableKey = objsys_RequestPushENS.TableKey; //表主键
objsys_RequestPushENT.ReceiveUser = objsys_RequestPushENS.ReceiveUser; //接收用户
objsys_RequestPushENT.IsReply = objsys_RequestPushENS.IsReply; //是否回复
objsys_RequestPushENT.ReplyDate = objsys_RequestPushENS.ReplyDate; //回复日期
objsys_RequestPushENT.RequestUser = objsys_RequestPushENS.RequestUser; //RequestUser
objsys_RequestPushENT.RequestDate = objsys_RequestPushENS.RequestDate; //RequestDate
objsys_RequestPushENT.RequestStata = objsys_RequestPushENS.RequestStata; //RequestStata
objsys_RequestPushENT.Memo = objsys_RequestPushENS.Memo; //备注
objsys_RequestPushENT.IdCurrEduCls = objsys_RequestPushENS.IdCurrEduCls; //教学班流水号
objsys_RequestPushENT.PushTypeId = objsys_RequestPushENS.PushTypeId; //推送类型Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clssys_RequestPushEN objsys_RequestPushEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.RequesTypeId, 2, consys_RequestPush.RequesTypeId);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.TableKey, 20, consys_RequestPush.TableKey);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.ReceiveUser, 20, consys_RequestPush.ReceiveUser);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.ReplyDate, 20, consys_RequestPush.ReplyDate);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.RequestUser, 20, consys_RequestPush.RequestUser);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.RequestDate, 20, consys_RequestPush.RequestDate);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.RequestStata, 10, consys_RequestPush.RequestStata);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.Memo, 1000, consys_RequestPush.Memo);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.IdCurrEduCls, 8, consys_RequestPush.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.PushTypeId, 2, consys_RequestPush.PushTypeId);
//检查字段外键固定长度
 objsys_RequestPushEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clssys_RequestPushEN objsys_RequestPushEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.RequesTypeId, 2, consys_RequestPush.RequesTypeId);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.TableKey, 20, consys_RequestPush.TableKey);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.ReceiveUser, 20, consys_RequestPush.ReceiveUser);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.ReplyDate, 20, consys_RequestPush.ReplyDate);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.RequestUser, 20, consys_RequestPush.RequestUser);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.RequestDate, 20, consys_RequestPush.RequestDate);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.RequestStata, 10, consys_RequestPush.RequestStata);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.Memo, 1000, consys_RequestPush.Memo);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.IdCurrEduCls, 8, consys_RequestPush.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.PushTypeId, 2, consys_RequestPush.PushTypeId);
//检查外键字段长度
 objsys_RequestPushEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clssys_RequestPushEN objsys_RequestPushEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.RequesTypeId, 2, consys_RequestPush.RequesTypeId);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.TableKey, 20, consys_RequestPush.TableKey);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.ReceiveUser, 20, consys_RequestPush.ReceiveUser);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.ReplyDate, 20, consys_RequestPush.ReplyDate);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.RequestUser, 20, consys_RequestPush.RequestUser);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.RequestDate, 20, consys_RequestPush.RequestDate);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.RequestStata, 10, consys_RequestPush.RequestStata);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.Memo, 1000, consys_RequestPush.Memo);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.IdCurrEduCls, 8, consys_RequestPush.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objsys_RequestPushEN.PushTypeId, 2, consys_RequestPush.PushTypeId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objsys_RequestPushEN.RequesTypeId, consys_RequestPush.RequesTypeId);
clsCheckSql.CheckSqlInjection4Field(objsys_RequestPushEN.TableKey, consys_RequestPush.TableKey);
clsCheckSql.CheckSqlInjection4Field(objsys_RequestPushEN.ReceiveUser, consys_RequestPush.ReceiveUser);
clsCheckSql.CheckSqlInjection4Field(objsys_RequestPushEN.ReplyDate, consys_RequestPush.ReplyDate);
clsCheckSql.CheckSqlInjection4Field(objsys_RequestPushEN.RequestUser, consys_RequestPush.RequestUser);
clsCheckSql.CheckSqlInjection4Field(objsys_RequestPushEN.RequestDate, consys_RequestPush.RequestDate);
clsCheckSql.CheckSqlInjection4Field(objsys_RequestPushEN.RequestStata, consys_RequestPush.RequestStata);
clsCheckSql.CheckSqlInjection4Field(objsys_RequestPushEN.Memo, consys_RequestPush.Memo);
clsCheckSql.CheckSqlInjection4Field(objsys_RequestPushEN.IdCurrEduCls, consys_RequestPush.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objsys_RequestPushEN.PushTypeId, consys_RequestPush.PushTypeId);
//检查外键字段长度
 objsys_RequestPushEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--sys_RequestPush(请求推送表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objsys_RequestPushEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clssys_RequestPushEN objsys_RequestPushEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objsys_RequestPushEN.RequesTypeId == null)
{
 sbCondition.AppendFormat(" and RequesTypeId is null");
}
else
{
 sbCondition.AppendFormat(" and RequesTypeId = '{0}'", objsys_RequestPushEN.RequesTypeId);
}
 if (objsys_RequestPushEN.TableKey == null)
{
 sbCondition.AppendFormat(" and TableKey is null");
}
else
{
 sbCondition.AppendFormat(" and TableKey = '{0}'", objsys_RequestPushEN.TableKey);
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
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
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
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
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
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clssys_RequestPushEN._CurrTabName);
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
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clssys_RequestPushEN._CurrTabName, strCondition);
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
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
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
 objSQL = clssys_RequestPushDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}