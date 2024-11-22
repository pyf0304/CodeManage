
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysVoteDA
 表名:vSysVote(01120633)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:47
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
 /// v系统点赞视图(vSysVote)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvSysVoteDA : clsCommBase4DA
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
 return clsvSysVoteEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvSysVoteEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSysVoteEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvSysVoteEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvSysVoteEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvSysVoteDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
strSQL = "Select * from vSysVote where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vSysVote(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvSysVoteDA: GetDataTable_vSysVote)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
strSQL = "Select * from vSysVote where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvSysVoteDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvSysVoteDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
strSQL = "Select * from vSysVote where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvSysVoteDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvSysVoteDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysVote where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysVote where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvSysVoteDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vSysVote where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvSysVoteDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vSysVote.* from vSysVote Left Join {1} on {2} where {3} and vSysVote.VoteId not in (Select top {5} vSysVote.VoteId from vSysVote Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysVote where {1} and VoteId not in (Select top {2} VoteId from vSysVote where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysVote where {1} and VoteId not in (Select top {3} VoteId from vSysVote where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvSysVoteDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vSysVote.* from vSysVote Left Join {1} on {2} where {3} and vSysVote.VoteId not in (Select top {5} vSysVote.VoteId from vSysVote Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysVote where {1} and VoteId not in (Select top {2} VoteId from vSysVote where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysVote where {1} and VoteId not in (Select top {3} VoteId from vSysVote where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvSysVoteEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvSysVoteDA:GetObjLst)", objException.Message));
}
List<clsvSysVoteEN> arrObjLst = new List<clsvSysVoteEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
strSQL = "Select * from vSysVote where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysVoteEN objvSysVoteEN = new clsvSysVoteEN();
try
{
objvSysVoteEN.VoteId = TransNullToInt(objRow[convSysVote.VoteId].ToString().Trim()); //点赞Id
objvSysVoteEN.TableKey = objRow[convSysVote.TableKey] == DBNull.Value ? null : objRow[convSysVote.TableKey].ToString().Trim(); //表主键
objvSysVoteEN.PubParentId = objRow[convSysVote.PubParentId] == DBNull.Value ? null : objRow[convSysVote.PubParentId].ToString().Trim(); //公共父Id
objvSysVoteEN.VoteTypeId = objRow[convSysVote.VoteTypeId] == DBNull.Value ? null : objRow[convSysVote.VoteTypeId].ToString().Trim(); //点赞类型Id
objvSysVoteEN.VoteTypeName = objRow[convSysVote.VoteTypeName] == DBNull.Value ? null : objRow[convSysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvSysVoteEN.UpdUser = objRow[convSysVote.UpdUser] == DBNull.Value ? null : objRow[convSysVote.UpdUser].ToString().Trim(); //修改人
objvSysVoteEN.VoteTable = objRow[convSysVote.VoteTable] == DBNull.Value ? null : objRow[convSysVote.VoteTable].ToString().Trim(); //点赞表
objvSysVoteEN.UpdDate = objRow[convSysVote.UpdDate] == DBNull.Value ? null : objRow[convSysVote.UpdDate].ToString().Trim(); //修改日期
objvSysVoteEN.VoteTableId = objRow[convSysVote.VoteTableId] == DBNull.Value ? null : objRow[convSysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvSysVoteEN.Memo = objRow[convSysVote.Memo] == DBNull.Value ? null : objRow[convSysVote.Memo].ToString().Trim(); //备注
objvSysVoteEN.IdCurrEduCls = objRow[convSysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysVoteEN.LikedUserId = objRow[convSysVote.LikedUserId] == DBNull.Value ? null : objRow[convSysVote.LikedUserId].ToString().Trim(); //被点赞用户Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSysVoteDA: GetObjLst)", objException.Message));
}
objvSysVoteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSysVoteEN);
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
public List<clsvSysVoteEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvSysVoteDA:GetObjLstByTabName)", objException.Message));
}
List<clsvSysVoteEN> arrObjLst = new List<clsvSysVoteEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysVoteEN objvSysVoteEN = new clsvSysVoteEN();
try
{
objvSysVoteEN.VoteId = TransNullToInt(objRow[convSysVote.VoteId].ToString().Trim()); //点赞Id
objvSysVoteEN.TableKey = objRow[convSysVote.TableKey] == DBNull.Value ? null : objRow[convSysVote.TableKey].ToString().Trim(); //表主键
objvSysVoteEN.PubParentId = objRow[convSysVote.PubParentId] == DBNull.Value ? null : objRow[convSysVote.PubParentId].ToString().Trim(); //公共父Id
objvSysVoteEN.VoteTypeId = objRow[convSysVote.VoteTypeId] == DBNull.Value ? null : objRow[convSysVote.VoteTypeId].ToString().Trim(); //点赞类型Id
objvSysVoteEN.VoteTypeName = objRow[convSysVote.VoteTypeName] == DBNull.Value ? null : objRow[convSysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvSysVoteEN.UpdUser = objRow[convSysVote.UpdUser] == DBNull.Value ? null : objRow[convSysVote.UpdUser].ToString().Trim(); //修改人
objvSysVoteEN.VoteTable = objRow[convSysVote.VoteTable] == DBNull.Value ? null : objRow[convSysVote.VoteTable].ToString().Trim(); //点赞表
objvSysVoteEN.UpdDate = objRow[convSysVote.UpdDate] == DBNull.Value ? null : objRow[convSysVote.UpdDate].ToString().Trim(); //修改日期
objvSysVoteEN.VoteTableId = objRow[convSysVote.VoteTableId] == DBNull.Value ? null : objRow[convSysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvSysVoteEN.Memo = objRow[convSysVote.Memo] == DBNull.Value ? null : objRow[convSysVote.Memo].ToString().Trim(); //备注
objvSysVoteEN.IdCurrEduCls = objRow[convSysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysVoteEN.LikedUserId = objRow[convSysVote.LikedUserId] == DBNull.Value ? null : objRow[convSysVote.LikedUserId].ToString().Trim(); //被点赞用户Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSysVoteDA: GetObjLst)", objException.Message));
}
objvSysVoteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSysVoteEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvSysVote(ref clsvSysVoteEN objvSysVoteEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
strSQL = "Select * from vSysVote where VoteId = " + ""+ objvSysVoteEN.VoteId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvSysVoteEN.VoteId = TransNullToInt(objDT.Rows[0][convSysVote.VoteId].ToString().Trim()); //点赞Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvSysVoteEN.TableKey = objDT.Rows[0][convSysVote.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysVoteEN.PubParentId = objDT.Rows[0][convSysVote.PubParentId].ToString().Trim(); //公共父Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysVoteEN.VoteTypeId = objDT.Rows[0][convSysVote.VoteTypeId].ToString().Trim(); //点赞类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvSysVoteEN.VoteTypeName = objDT.Rows[0][convSysVote.VoteTypeName].ToString().Trim(); //点赞类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvSysVoteEN.UpdUser = objDT.Rows[0][convSysVote.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysVoteEN.VoteTable = objDT.Rows[0][convSysVote.VoteTable].ToString().Trim(); //点赞表(字段类型:varchar,字段长度:100,是否可空:True)
 objvSysVoteEN.UpdDate = objDT.Rows[0][convSysVote.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysVoteEN.VoteTableId = objDT.Rows[0][convSysVote.VoteTableId].ToString().Trim(); //点赞表Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvSysVoteEN.Memo = objDT.Rows[0][convSysVote.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSysVoteEN.IdCurrEduCls = objDT.Rows[0][convSysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvSysVoteEN.LikedUserId = objDT.Rows[0][convSysVote.LikedUserId].ToString().Trim(); //被点赞用户Id(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvSysVoteDA: GetvSysVote)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngVoteId">表关键字</param>
 /// <returns>表对象</returns>
public clsvSysVoteEN GetObjByVoteId(long lngVoteId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
strSQL = "Select * from vSysVote where VoteId = " + ""+ lngVoteId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvSysVoteEN objvSysVoteEN = new clsvSysVoteEN();
try
{
 objvSysVoteEN.VoteId = Int32.Parse(objRow[convSysVote.VoteId].ToString().Trim()); //点赞Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvSysVoteEN.TableKey = objRow[convSysVote.TableKey] == DBNull.Value ? null : objRow[convSysVote.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysVoteEN.PubParentId = objRow[convSysVote.PubParentId] == DBNull.Value ? null : objRow[convSysVote.PubParentId].ToString().Trim(); //公共父Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysVoteEN.VoteTypeId = objRow[convSysVote.VoteTypeId] == DBNull.Value ? null : objRow[convSysVote.VoteTypeId].ToString().Trim(); //点赞类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvSysVoteEN.VoteTypeName = objRow[convSysVote.VoteTypeName] == DBNull.Value ? null : objRow[convSysVote.VoteTypeName].ToString().Trim(); //点赞类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvSysVoteEN.UpdUser = objRow[convSysVote.UpdUser] == DBNull.Value ? null : objRow[convSysVote.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysVoteEN.VoteTable = objRow[convSysVote.VoteTable] == DBNull.Value ? null : objRow[convSysVote.VoteTable].ToString().Trim(); //点赞表(字段类型:varchar,字段长度:100,是否可空:True)
 objvSysVoteEN.UpdDate = objRow[convSysVote.UpdDate] == DBNull.Value ? null : objRow[convSysVote.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysVoteEN.VoteTableId = objRow[convSysVote.VoteTableId] == DBNull.Value ? null : objRow[convSysVote.VoteTableId].ToString().Trim(); //点赞表Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvSysVoteEN.Memo = objRow[convSysVote.Memo] == DBNull.Value ? null : objRow[convSysVote.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSysVoteEN.IdCurrEduCls = objRow[convSysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvSysVoteEN.LikedUserId = objRow[convSysVote.LikedUserId] == DBNull.Value ? null : objRow[convSysVote.LikedUserId].ToString().Trim(); //被点赞用户Id(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvSysVoteDA: GetObjByVoteId)", objException.Message));
}
return objvSysVoteEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvSysVoteEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvSysVoteDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
strSQL = "Select * from vSysVote where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvSysVoteEN objvSysVoteEN = new clsvSysVoteEN()
{
VoteId = TransNullToInt(objRow[convSysVote.VoteId].ToString().Trim()), //点赞Id
TableKey = objRow[convSysVote.TableKey] == DBNull.Value ? null : objRow[convSysVote.TableKey].ToString().Trim(), //表主键
PubParentId = objRow[convSysVote.PubParentId] == DBNull.Value ? null : objRow[convSysVote.PubParentId].ToString().Trim(), //公共父Id
VoteTypeId = objRow[convSysVote.VoteTypeId] == DBNull.Value ? null : objRow[convSysVote.VoteTypeId].ToString().Trim(), //点赞类型Id
VoteTypeName = objRow[convSysVote.VoteTypeName] == DBNull.Value ? null : objRow[convSysVote.VoteTypeName].ToString().Trim(), //点赞类型名称
UpdUser = objRow[convSysVote.UpdUser] == DBNull.Value ? null : objRow[convSysVote.UpdUser].ToString().Trim(), //修改人
VoteTable = objRow[convSysVote.VoteTable] == DBNull.Value ? null : objRow[convSysVote.VoteTable].ToString().Trim(), //点赞表
UpdDate = objRow[convSysVote.UpdDate] == DBNull.Value ? null : objRow[convSysVote.UpdDate].ToString().Trim(), //修改日期
VoteTableId = objRow[convSysVote.VoteTableId] == DBNull.Value ? null : objRow[convSysVote.VoteTableId].ToString().Trim(), //点赞表Id
Memo = objRow[convSysVote.Memo] == DBNull.Value ? null : objRow[convSysVote.Memo].ToString().Trim(), //备注
IdCurrEduCls = objRow[convSysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysVote.IdCurrEduCls].ToString().Trim(), //教学班流水号
LikedUserId = objRow[convSysVote.LikedUserId] == DBNull.Value ? null : objRow[convSysVote.LikedUserId].ToString().Trim() //被点赞用户Id
};
objvSysVoteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysVoteEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvSysVoteDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvSysVoteEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSysVoteEN objvSysVoteEN = new clsvSysVoteEN();
try
{
objvSysVoteEN.VoteId = TransNullToInt(objRow[convSysVote.VoteId].ToString().Trim()); //点赞Id
objvSysVoteEN.TableKey = objRow[convSysVote.TableKey] == DBNull.Value ? null : objRow[convSysVote.TableKey].ToString().Trim(); //表主键
objvSysVoteEN.PubParentId = objRow[convSysVote.PubParentId] == DBNull.Value ? null : objRow[convSysVote.PubParentId].ToString().Trim(); //公共父Id
objvSysVoteEN.VoteTypeId = objRow[convSysVote.VoteTypeId] == DBNull.Value ? null : objRow[convSysVote.VoteTypeId].ToString().Trim(); //点赞类型Id
objvSysVoteEN.VoteTypeName = objRow[convSysVote.VoteTypeName] == DBNull.Value ? null : objRow[convSysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvSysVoteEN.UpdUser = objRow[convSysVote.UpdUser] == DBNull.Value ? null : objRow[convSysVote.UpdUser].ToString().Trim(); //修改人
objvSysVoteEN.VoteTable = objRow[convSysVote.VoteTable] == DBNull.Value ? null : objRow[convSysVote.VoteTable].ToString().Trim(); //点赞表
objvSysVoteEN.UpdDate = objRow[convSysVote.UpdDate] == DBNull.Value ? null : objRow[convSysVote.UpdDate].ToString().Trim(); //修改日期
objvSysVoteEN.VoteTableId = objRow[convSysVote.VoteTableId] == DBNull.Value ? null : objRow[convSysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvSysVoteEN.Memo = objRow[convSysVote.Memo] == DBNull.Value ? null : objRow[convSysVote.Memo].ToString().Trim(); //备注
objvSysVoteEN.IdCurrEduCls = objRow[convSysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysVoteEN.LikedUserId = objRow[convSysVote.LikedUserId] == DBNull.Value ? null : objRow[convSysVote.LikedUserId].ToString().Trim(); //被点赞用户Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvSysVoteDA: GetObjByDataRowvSysVote)", objException.Message));
}
objvSysVoteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysVoteEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvSysVoteEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSysVoteEN objvSysVoteEN = new clsvSysVoteEN();
try
{
objvSysVoteEN.VoteId = TransNullToInt(objRow[convSysVote.VoteId].ToString().Trim()); //点赞Id
objvSysVoteEN.TableKey = objRow[convSysVote.TableKey] == DBNull.Value ? null : objRow[convSysVote.TableKey].ToString().Trim(); //表主键
objvSysVoteEN.PubParentId = objRow[convSysVote.PubParentId] == DBNull.Value ? null : objRow[convSysVote.PubParentId].ToString().Trim(); //公共父Id
objvSysVoteEN.VoteTypeId = objRow[convSysVote.VoteTypeId] == DBNull.Value ? null : objRow[convSysVote.VoteTypeId].ToString().Trim(); //点赞类型Id
objvSysVoteEN.VoteTypeName = objRow[convSysVote.VoteTypeName] == DBNull.Value ? null : objRow[convSysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvSysVoteEN.UpdUser = objRow[convSysVote.UpdUser] == DBNull.Value ? null : objRow[convSysVote.UpdUser].ToString().Trim(); //修改人
objvSysVoteEN.VoteTable = objRow[convSysVote.VoteTable] == DBNull.Value ? null : objRow[convSysVote.VoteTable].ToString().Trim(); //点赞表
objvSysVoteEN.UpdDate = objRow[convSysVote.UpdDate] == DBNull.Value ? null : objRow[convSysVote.UpdDate].ToString().Trim(); //修改日期
objvSysVoteEN.VoteTableId = objRow[convSysVote.VoteTableId] == DBNull.Value ? null : objRow[convSysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvSysVoteEN.Memo = objRow[convSysVote.Memo] == DBNull.Value ? null : objRow[convSysVote.Memo].ToString().Trim(); //备注
objvSysVoteEN.IdCurrEduCls = objRow[convSysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysVoteEN.LikedUserId = objRow[convSysVote.LikedUserId] == DBNull.Value ? null : objRow[convSysVote.LikedUserId].ToString().Trim(); //被点赞用户Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvSysVoteDA: GetObjByDataRow)", objException.Message));
}
objvSysVoteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysVoteEN;
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
objSQL = clsvSysVoteDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSysVoteEN._CurrTabName, convSysVote.VoteId, 8, "");
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
objSQL = clsvSysVoteDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSysVoteEN._CurrTabName, convSysVote.VoteId, 8, strPrefix);
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
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select VoteId from vSysVote where " + strCondition;
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
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select VoteId from vSysVote where " + strCondition;
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
 /// <param name = "lngVoteId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngVoteId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSysVote", "VoteId = " + ""+ lngVoteId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvSysVoteDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSysVote", strCondition))
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
objSQL = clsvSysVoteDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vSysVote");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvSysVoteENS">源对象</param>
 /// <param name = "objvSysVoteENT">目标对象</param>
public void CopyTo(clsvSysVoteEN objvSysVoteENS, clsvSysVoteEN objvSysVoteENT)
{
objvSysVoteENT.VoteId = objvSysVoteENS.VoteId; //点赞Id
objvSysVoteENT.TableKey = objvSysVoteENS.TableKey; //表主键
objvSysVoteENT.PubParentId = objvSysVoteENS.PubParentId; //公共父Id
objvSysVoteENT.VoteTypeId = objvSysVoteENS.VoteTypeId; //点赞类型Id
objvSysVoteENT.VoteTypeName = objvSysVoteENS.VoteTypeName; //点赞类型名称
objvSysVoteENT.UpdUser = objvSysVoteENS.UpdUser; //修改人
objvSysVoteENT.VoteTable = objvSysVoteENS.VoteTable; //点赞表
objvSysVoteENT.UpdDate = objvSysVoteENS.UpdDate; //修改日期
objvSysVoteENT.VoteTableId = objvSysVoteENS.VoteTableId; //点赞表Id
objvSysVoteENT.Memo = objvSysVoteENS.Memo; //备注
objvSysVoteENT.IdCurrEduCls = objvSysVoteENS.IdCurrEduCls; //教学班流水号
objvSysVoteENT.LikedUserId = objvSysVoteENS.LikedUserId; //被点赞用户Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvSysVoteEN objvSysVoteEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvSysVoteEN.TableKey, 20, convSysVote.TableKey);
clsCheckSql.CheckFieldLen(objvSysVoteEN.PubParentId, 20, convSysVote.PubParentId);
clsCheckSql.CheckFieldLen(objvSysVoteEN.VoteTypeId, 2, convSysVote.VoteTypeId);
clsCheckSql.CheckFieldLen(objvSysVoteEN.VoteTypeName, 100, convSysVote.VoteTypeName);
clsCheckSql.CheckFieldLen(objvSysVoteEN.UpdUser, 20, convSysVote.UpdUser);
clsCheckSql.CheckFieldLen(objvSysVoteEN.VoteTable, 100, convSysVote.VoteTable);
clsCheckSql.CheckFieldLen(objvSysVoteEN.UpdDate, 20, convSysVote.UpdDate);
clsCheckSql.CheckFieldLen(objvSysVoteEN.VoteTableId, 50, convSysVote.VoteTableId);
clsCheckSql.CheckFieldLen(objvSysVoteEN.Memo, 1000, convSysVote.Memo);
clsCheckSql.CheckFieldLen(objvSysVoteEN.IdCurrEduCls, 8, convSysVote.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvSysVoteEN.LikedUserId, 20, convSysVote.LikedUserId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvSysVoteEN.TableKey, convSysVote.TableKey);
clsCheckSql.CheckSqlInjection4Field(objvSysVoteEN.PubParentId, convSysVote.PubParentId);
clsCheckSql.CheckSqlInjection4Field(objvSysVoteEN.VoteTypeId, convSysVote.VoteTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSysVoteEN.VoteTypeName, convSysVote.VoteTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSysVoteEN.UpdUser, convSysVote.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvSysVoteEN.VoteTable, convSysVote.VoteTable);
clsCheckSql.CheckSqlInjection4Field(objvSysVoteEN.UpdDate, convSysVote.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvSysVoteEN.VoteTableId, convSysVote.VoteTableId);
clsCheckSql.CheckSqlInjection4Field(objvSysVoteEN.Memo, convSysVote.Memo);
clsCheckSql.CheckSqlInjection4Field(objvSysVoteEN.IdCurrEduCls, convSysVote.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvSysVoteEN.LikedUserId, convSysVote.LikedUserId);
//检查外键字段长度
 objvSysVoteEN._IsCheckProperty = true;
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
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
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
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
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
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSysVoteEN._CurrTabName);
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
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSysVoteEN._CurrTabName, strCondition);
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
 objSQL = clsvSysVoteDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}