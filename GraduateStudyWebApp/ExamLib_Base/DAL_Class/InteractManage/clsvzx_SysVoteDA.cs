
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SysVoteDA
 表名:vzx_SysVote(01120853)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:50:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// vzx_SysVote(vzx_SysVote)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_SysVoteDA : clsCommBase4DA
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
 return clsvzx_SysVoteEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_SysVoteEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_SysVoteEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_SysVoteEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_SysVoteEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_SysVoteDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysVote where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_SysVote(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_SysVoteDA: GetDataTable_vzx_SysVote)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysVote where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_SysVoteDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_SysVoteDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysVote where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_SysVoteDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_SysVoteDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysVote where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysVote where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_SysVoteDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_SysVote where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_SysVoteDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_SysVote.* from vzx_SysVote Left Join {1} on {2} where {3} and vzx_SysVote.zxVoteId not in (Select top {5} vzx_SysVote.zxVoteId from vzx_SysVote Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysVote where {1} and zxVoteId not in (Select top {2} zxVoteId from vzx_SysVote where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysVote where {1} and zxVoteId not in (Select top {3} zxVoteId from vzx_SysVote where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_SysVoteDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_SysVote.* from vzx_SysVote Left Join {1} on {2} where {3} and vzx_SysVote.zxVoteId not in (Select top {5} vzx_SysVote.zxVoteId from vzx_SysVote Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysVote where {1} and zxVoteId not in (Select top {2} zxVoteId from vzx_SysVote where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysVote where {1} and zxVoteId not in (Select top {3} zxVoteId from vzx_SysVote where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_SysVoteEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_SysVoteDA:GetObjLst)", objException.Message));
}
List<clsvzx_SysVoteEN> arrObjLst = new List<clsvzx_SysVoteEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysVote where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysVoteEN objvzx_SysVoteEN = new clsvzx_SysVoteEN();
try
{
objvzx_SysVoteEN.VoteTable = objRow[convzx_SysVote.VoteTable] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTable].ToString().Trim(); //点赞表
objvzx_SysVoteEN.zxVoteId = TransNullToInt(objRow[convzx_SysVote.zxVoteId].ToString().Trim()); //点赞Id
objvzx_SysVoteEN.VoteTableId = objRow[convzx_SysVote.VoteTableId] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvzx_SysVoteEN.TableKey = objRow[convzx_SysVote.TableKey] == DBNull.Value ? null : objRow[convzx_SysVote.TableKey].ToString().Trim(); //表主键
objvzx_SysVoteEN.PubParentId = objRow[convzx_SysVote.PubParentId] == DBNull.Value ? null : objRow[convzx_SysVote.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysVoteEN.UpdUser = objRow[convzx_SysVote.UpdUser] == DBNull.Value ? null : objRow[convzx_SysVote.UpdUser].ToString().Trim(); //修改人
objvzx_SysVoteEN.UpdDate = objRow[convzx_SysVote.UpdDate] == DBNull.Value ? null : objRow[convzx_SysVote.UpdDate].ToString().Trim(); //修改日期
objvzx_SysVoteEN.Memo = objRow[convzx_SysVote.Memo] == DBNull.Value ? null : objRow[convzx_SysVote.Memo].ToString().Trim(); //备注
objvzx_SysVoteEN.IdCurrEduCls = objRow[convzx_SysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysVoteEN.UserId = objRow[convzx_SysVote.UserId] == DBNull.Value ? null : objRow[convzx_SysVote.UserId].ToString().Trim(); //用户ID
objvzx_SysVoteEN.VoteTypeName = objRow[convzx_SysVote.VoteTypeName] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvzx_SysVoteEN.zxVoteTypeId = objRow[convzx_SysVote.zxVoteTypeId] == DBNull.Value ? null : objRow[convzx_SysVote.zxVoteTypeId].ToString().Trim(); //点赞类型Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_SysVoteDA: GetObjLst)", objException.Message));
}
objvzx_SysVoteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_SysVoteEN);
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
public List<clsvzx_SysVoteEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_SysVoteDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_SysVoteEN> arrObjLst = new List<clsvzx_SysVoteEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysVoteEN objvzx_SysVoteEN = new clsvzx_SysVoteEN();
try
{
objvzx_SysVoteEN.VoteTable = objRow[convzx_SysVote.VoteTable] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTable].ToString().Trim(); //点赞表
objvzx_SysVoteEN.zxVoteId = TransNullToInt(objRow[convzx_SysVote.zxVoteId].ToString().Trim()); //点赞Id
objvzx_SysVoteEN.VoteTableId = objRow[convzx_SysVote.VoteTableId] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvzx_SysVoteEN.TableKey = objRow[convzx_SysVote.TableKey] == DBNull.Value ? null : objRow[convzx_SysVote.TableKey].ToString().Trim(); //表主键
objvzx_SysVoteEN.PubParentId = objRow[convzx_SysVote.PubParentId] == DBNull.Value ? null : objRow[convzx_SysVote.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysVoteEN.UpdUser = objRow[convzx_SysVote.UpdUser] == DBNull.Value ? null : objRow[convzx_SysVote.UpdUser].ToString().Trim(); //修改人
objvzx_SysVoteEN.UpdDate = objRow[convzx_SysVote.UpdDate] == DBNull.Value ? null : objRow[convzx_SysVote.UpdDate].ToString().Trim(); //修改日期
objvzx_SysVoteEN.Memo = objRow[convzx_SysVote.Memo] == DBNull.Value ? null : objRow[convzx_SysVote.Memo].ToString().Trim(); //备注
objvzx_SysVoteEN.IdCurrEduCls = objRow[convzx_SysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysVoteEN.UserId = objRow[convzx_SysVote.UserId] == DBNull.Value ? null : objRow[convzx_SysVote.UserId].ToString().Trim(); //用户ID
objvzx_SysVoteEN.VoteTypeName = objRow[convzx_SysVote.VoteTypeName] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvzx_SysVoteEN.zxVoteTypeId = objRow[convzx_SysVote.zxVoteTypeId] == DBNull.Value ? null : objRow[convzx_SysVote.zxVoteTypeId].ToString().Trim(); //点赞类型Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_SysVoteDA: GetObjLst)", objException.Message));
}
objvzx_SysVoteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_SysVoteEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_SysVoteEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_SysVote(ref clsvzx_SysVoteEN objvzx_SysVoteEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysVote where zxVoteId = " + ""+ objvzx_SysVoteEN.zxVoteId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_SysVoteEN.VoteTable = objDT.Rows[0][convzx_SysVote.VoteTable].ToString().Trim(); //点赞表(字段类型:varchar,字段长度:100,是否可空:True)
 objvzx_SysVoteEN.zxVoteId = TransNullToInt(objDT.Rows[0][convzx_SysVote.zxVoteId].ToString().Trim()); //点赞Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvzx_SysVoteEN.VoteTableId = objDT.Rows[0][convzx_SysVote.VoteTableId].ToString().Trim(); //点赞表Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SysVoteEN.TableKey = objDT.Rows[0][convzx_SysVote.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysVoteEN.PubParentId = objDT.Rows[0][convzx_SysVote.PubParentId].ToString().Trim(); //公共父Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysVoteEN.UpdUser = objDT.Rows[0][convzx_SysVote.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysVoteEN.UpdDate = objDT.Rows[0][convzx_SysVote.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysVoteEN.Memo = objDT.Rows[0][convzx_SysVote.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_SysVoteEN.IdCurrEduCls = objDT.Rows[0][convzx_SysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_SysVoteEN.UserId = objDT.Rows[0][convzx_SysVote.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvzx_SysVoteEN.VoteTypeName = objDT.Rows[0][convzx_SysVote.VoteTypeName].ToString().Trim(); //点赞类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvzx_SysVoteEN.zxVoteTypeId = objDT.Rows[0][convzx_SysVote.zxVoteTypeId].ToString().Trim(); //点赞类型Id(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_SysVoteDA: Getvzx_SysVote)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngzxVoteId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_SysVoteEN GetObjByzxVoteId(long lngzxVoteId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysVote where zxVoteId = " + ""+ lngzxVoteId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_SysVoteEN objvzx_SysVoteEN = new clsvzx_SysVoteEN();
try
{
 objvzx_SysVoteEN.VoteTable = objRow[convzx_SysVote.VoteTable] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTable].ToString().Trim(); //点赞表(字段类型:varchar,字段长度:100,是否可空:True)
 objvzx_SysVoteEN.zxVoteId = Int32.Parse(objRow[convzx_SysVote.zxVoteId].ToString().Trim()); //点赞Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvzx_SysVoteEN.VoteTableId = objRow[convzx_SysVote.VoteTableId] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTableId].ToString().Trim(); //点赞表Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_SysVoteEN.TableKey = objRow[convzx_SysVote.TableKey] == DBNull.Value ? null : objRow[convzx_SysVote.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysVoteEN.PubParentId = objRow[convzx_SysVote.PubParentId] == DBNull.Value ? null : objRow[convzx_SysVote.PubParentId].ToString().Trim(); //公共父Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysVoteEN.UpdUser = objRow[convzx_SysVote.UpdUser] == DBNull.Value ? null : objRow[convzx_SysVote.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysVoteEN.UpdDate = objRow[convzx_SysVote.UpdDate] == DBNull.Value ? null : objRow[convzx_SysVote.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysVoteEN.Memo = objRow[convzx_SysVote.Memo] == DBNull.Value ? null : objRow[convzx_SysVote.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_SysVoteEN.IdCurrEduCls = objRow[convzx_SysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_SysVoteEN.UserId = objRow[convzx_SysVote.UserId] == DBNull.Value ? null : objRow[convzx_SysVote.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvzx_SysVoteEN.VoteTypeName = objRow[convzx_SysVote.VoteTypeName] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTypeName].ToString().Trim(); //点赞类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvzx_SysVoteEN.zxVoteTypeId = objRow[convzx_SysVote.zxVoteTypeId] == DBNull.Value ? null : objRow[convzx_SysVote.zxVoteTypeId].ToString().Trim(); //点赞类型Id(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_SysVoteDA: GetObjByzxVoteId)", objException.Message));
}
return objvzx_SysVoteEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_SysVoteEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_SysVoteDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysVote where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_SysVoteEN objvzx_SysVoteEN = new clsvzx_SysVoteEN()
{
VoteTable = objRow[convzx_SysVote.VoteTable] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTable].ToString().Trim(), //点赞表
zxVoteId = TransNullToInt(objRow[convzx_SysVote.zxVoteId].ToString().Trim()), //点赞Id
VoteTableId = objRow[convzx_SysVote.VoteTableId] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTableId].ToString().Trim(), //点赞表Id
TableKey = objRow[convzx_SysVote.TableKey] == DBNull.Value ? null : objRow[convzx_SysVote.TableKey].ToString().Trim(), //表主键
PubParentId = objRow[convzx_SysVote.PubParentId] == DBNull.Value ? null : objRow[convzx_SysVote.PubParentId].ToString().Trim(), //公共父Id
UpdUser = objRow[convzx_SysVote.UpdUser] == DBNull.Value ? null : objRow[convzx_SysVote.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[convzx_SysVote.UpdDate] == DBNull.Value ? null : objRow[convzx_SysVote.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convzx_SysVote.Memo] == DBNull.Value ? null : objRow[convzx_SysVote.Memo].ToString().Trim(), //备注
IdCurrEduCls = objRow[convzx_SysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysVote.IdCurrEduCls].ToString().Trim(), //教学班流水号
UserId = objRow[convzx_SysVote.UserId] == DBNull.Value ? null : objRow[convzx_SysVote.UserId].ToString().Trim(), //用户ID
VoteTypeName = objRow[convzx_SysVote.VoteTypeName] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTypeName].ToString().Trim(), //点赞类型名称
zxVoteTypeId = objRow[convzx_SysVote.zxVoteTypeId] == DBNull.Value ? null : objRow[convzx_SysVote.zxVoteTypeId].ToString().Trim() //点赞类型Id
};
objvzx_SysVoteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_SysVoteEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_SysVoteDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_SysVoteEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_SysVoteEN objvzx_SysVoteEN = new clsvzx_SysVoteEN();
try
{
objvzx_SysVoteEN.VoteTable = objRow[convzx_SysVote.VoteTable] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTable].ToString().Trim(); //点赞表
objvzx_SysVoteEN.zxVoteId = TransNullToInt(objRow[convzx_SysVote.zxVoteId].ToString().Trim()); //点赞Id
objvzx_SysVoteEN.VoteTableId = objRow[convzx_SysVote.VoteTableId] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvzx_SysVoteEN.TableKey = objRow[convzx_SysVote.TableKey] == DBNull.Value ? null : objRow[convzx_SysVote.TableKey].ToString().Trim(); //表主键
objvzx_SysVoteEN.PubParentId = objRow[convzx_SysVote.PubParentId] == DBNull.Value ? null : objRow[convzx_SysVote.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysVoteEN.UpdUser = objRow[convzx_SysVote.UpdUser] == DBNull.Value ? null : objRow[convzx_SysVote.UpdUser].ToString().Trim(); //修改人
objvzx_SysVoteEN.UpdDate = objRow[convzx_SysVote.UpdDate] == DBNull.Value ? null : objRow[convzx_SysVote.UpdDate].ToString().Trim(); //修改日期
objvzx_SysVoteEN.Memo = objRow[convzx_SysVote.Memo] == DBNull.Value ? null : objRow[convzx_SysVote.Memo].ToString().Trim(); //备注
objvzx_SysVoteEN.IdCurrEduCls = objRow[convzx_SysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysVoteEN.UserId = objRow[convzx_SysVote.UserId] == DBNull.Value ? null : objRow[convzx_SysVote.UserId].ToString().Trim(); //用户ID
objvzx_SysVoteEN.VoteTypeName = objRow[convzx_SysVote.VoteTypeName] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvzx_SysVoteEN.zxVoteTypeId = objRow[convzx_SysVote.zxVoteTypeId] == DBNull.Value ? null : objRow[convzx_SysVote.zxVoteTypeId].ToString().Trim(); //点赞类型Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_SysVoteDA: GetObjByDataRowvzx_SysVote)", objException.Message));
}
objvzx_SysVoteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_SysVoteEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_SysVoteEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_SysVoteEN objvzx_SysVoteEN = new clsvzx_SysVoteEN();
try
{
objvzx_SysVoteEN.VoteTable = objRow[convzx_SysVote.VoteTable] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTable].ToString().Trim(); //点赞表
objvzx_SysVoteEN.zxVoteId = TransNullToInt(objRow[convzx_SysVote.zxVoteId].ToString().Trim()); //点赞Id
objvzx_SysVoteEN.VoteTableId = objRow[convzx_SysVote.VoteTableId] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvzx_SysVoteEN.TableKey = objRow[convzx_SysVote.TableKey] == DBNull.Value ? null : objRow[convzx_SysVote.TableKey].ToString().Trim(); //表主键
objvzx_SysVoteEN.PubParentId = objRow[convzx_SysVote.PubParentId] == DBNull.Value ? null : objRow[convzx_SysVote.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysVoteEN.UpdUser = objRow[convzx_SysVote.UpdUser] == DBNull.Value ? null : objRow[convzx_SysVote.UpdUser].ToString().Trim(); //修改人
objvzx_SysVoteEN.UpdDate = objRow[convzx_SysVote.UpdDate] == DBNull.Value ? null : objRow[convzx_SysVote.UpdDate].ToString().Trim(); //修改日期
objvzx_SysVoteEN.Memo = objRow[convzx_SysVote.Memo] == DBNull.Value ? null : objRow[convzx_SysVote.Memo].ToString().Trim(); //备注
objvzx_SysVoteEN.IdCurrEduCls = objRow[convzx_SysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysVoteEN.UserId = objRow[convzx_SysVote.UserId] == DBNull.Value ? null : objRow[convzx_SysVote.UserId].ToString().Trim(); //用户ID
objvzx_SysVoteEN.VoteTypeName = objRow[convzx_SysVote.VoteTypeName] == DBNull.Value ? null : objRow[convzx_SysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvzx_SysVoteEN.zxVoteTypeId = objRow[convzx_SysVote.zxVoteTypeId] == DBNull.Value ? null : objRow[convzx_SysVote.zxVoteTypeId].ToString().Trim(); //点赞类型Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_SysVoteDA: GetObjByDataRow)", objException.Message));
}
objvzx_SysVoteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_SysVoteEN;
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
objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_SysVoteEN._CurrTabName, convzx_SysVote.zxVoteId, 8, "");
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
objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_SysVoteEN._CurrTabName, convzx_SysVote.zxVoteId, 8, strPrefix);
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
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxVoteId from vzx_SysVote where " + strCondition;
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
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxVoteId from vzx_SysVote where " + strCondition;
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
 /// <param name = "lngzxVoteId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngzxVoteId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_SysVote", "zxVoteId = " + ""+ lngzxVoteId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_SysVoteDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_SysVote", strCondition))
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
objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_SysVote");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_SysVoteENS">源对象</param>
 /// <param name = "objvzx_SysVoteENT">目标对象</param>
public void CopyTo(clsvzx_SysVoteEN objvzx_SysVoteENS, clsvzx_SysVoteEN objvzx_SysVoteENT)
{
objvzx_SysVoteENT.VoteTable = objvzx_SysVoteENS.VoteTable; //点赞表
objvzx_SysVoteENT.zxVoteId = objvzx_SysVoteENS.zxVoteId; //点赞Id
objvzx_SysVoteENT.VoteTableId = objvzx_SysVoteENS.VoteTableId; //点赞表Id
objvzx_SysVoteENT.TableKey = objvzx_SysVoteENS.TableKey; //表主键
objvzx_SysVoteENT.PubParentId = objvzx_SysVoteENS.PubParentId; //公共父Id
objvzx_SysVoteENT.UpdUser = objvzx_SysVoteENS.UpdUser; //修改人
objvzx_SysVoteENT.UpdDate = objvzx_SysVoteENS.UpdDate; //修改日期
objvzx_SysVoteENT.Memo = objvzx_SysVoteENS.Memo; //备注
objvzx_SysVoteENT.IdCurrEduCls = objvzx_SysVoteENS.IdCurrEduCls; //教学班流水号
objvzx_SysVoteENT.UserId = objvzx_SysVoteENS.UserId; //用户ID
objvzx_SysVoteENT.VoteTypeName = objvzx_SysVoteENS.VoteTypeName; //点赞类型名称
objvzx_SysVoteENT.zxVoteTypeId = objvzx_SysVoteENS.zxVoteTypeId; //点赞类型Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_SysVoteEN objvzx_SysVoteEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_SysVoteEN.VoteTable, 100, convzx_SysVote.VoteTable);
clsCheckSql.CheckFieldLen(objvzx_SysVoteEN.VoteTableId, 50, convzx_SysVote.VoteTableId);
clsCheckSql.CheckFieldLen(objvzx_SysVoteEN.TableKey, 20, convzx_SysVote.TableKey);
clsCheckSql.CheckFieldLen(objvzx_SysVoteEN.PubParentId, 20, convzx_SysVote.PubParentId);
clsCheckSql.CheckFieldLen(objvzx_SysVoteEN.UpdUser, 20, convzx_SysVote.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_SysVoteEN.UpdDate, 20, convzx_SysVote.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_SysVoteEN.Memo, 1000, convzx_SysVote.Memo);
clsCheckSql.CheckFieldLen(objvzx_SysVoteEN.IdCurrEduCls, 8, convzx_SysVote.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_SysVoteEN.UserId, 18, convzx_SysVote.UserId);
clsCheckSql.CheckFieldLen(objvzx_SysVoteEN.VoteTypeName, 100, convzx_SysVote.VoteTypeName);
clsCheckSql.CheckFieldLen(objvzx_SysVoteEN.zxVoteTypeId, 2, convzx_SysVote.zxVoteTypeId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_SysVoteEN.VoteTable, convzx_SysVote.VoteTable);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysVoteEN.VoteTableId, convzx_SysVote.VoteTableId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysVoteEN.TableKey, convzx_SysVote.TableKey);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysVoteEN.PubParentId, convzx_SysVote.PubParentId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysVoteEN.UpdUser, convzx_SysVote.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysVoteEN.UpdDate, convzx_SysVote.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysVoteEN.Memo, convzx_SysVote.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysVoteEN.IdCurrEduCls, convzx_SysVote.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysVoteEN.UserId, convzx_SysVote.UserId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysVoteEN.VoteTypeName, convzx_SysVote.VoteTypeName);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysVoteEN.zxVoteTypeId, convzx_SysVote.zxVoteTypeId);
//检查外键字段长度
 objvzx_SysVoteEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

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
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
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
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
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
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_SysVoteEN._CurrTabName);
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
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_SysVoteEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_SysVoteDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}