
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGameBottleDA
 表名:GameBottle(01120974)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:58:33
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
 /// 游戏瓶(GameBottle)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsGameBottleDA : clsCommBase4DA
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
 return clsGameBottleEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsGameBottleEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGameBottleEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsGameBottleEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsGameBottleEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsGameBottleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
strSQL = "Select * from GameBottle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_GameBottle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsGameBottleDA: GetDataTable_GameBottle)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
strSQL = "Select * from GameBottle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsGameBottleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsGameBottleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
strSQL = "Select * from GameBottle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsGameBottleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsGameBottleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GameBottle where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GameBottle where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsGameBottleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from GameBottle where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsGameBottleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} GameBottle.* from GameBottle Left Join {1} on {2} where {3} and GameBottle.BottleId not in (Select top {5} GameBottle.BottleId from GameBottle Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GameBottle where {1} and BottleId not in (Select top {2} BottleId from GameBottle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GameBottle where {1} and BottleId not in (Select top {3} BottleId from GameBottle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsGameBottleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} GameBottle.* from GameBottle Left Join {1} on {2} where {3} and GameBottle.BottleId not in (Select top {5} GameBottle.BottleId from GameBottle Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GameBottle where {1} and BottleId not in (Select top {2} BottleId from GameBottle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GameBottle where {1} and BottleId not in (Select top {3} BottleId from GameBottle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsGameBottleEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsGameBottleDA:GetObjLst)", objException.Message));
}
List<clsGameBottleEN> arrObjLst = new List<clsGameBottleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
strSQL = "Select * from GameBottle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGameBottleEN objGameBottleEN = new clsGameBottleEN();
try
{
objGameBottleEN.BottleId = TransNullToInt(objRow[conGameBottle.BottleId].ToString().Trim()); //瓶子Id
objGameBottleEN.QuestionId = TransNullToInt(objRow[conGameBottle.QuestionId].ToString().Trim()); //题目Id
objGameBottleEN.UserId_Throw = objRow[conGameBottle.UserId_Throw].ToString().Trim(); //用户ID
objGameBottleEN.ThrowTime = objRow[conGameBottle.ThrowTime].ToString().Trim(); //扔的时间
objGameBottleEN.UserId_PickUp = objRow[conGameBottle.UserId_PickUp] == DBNull.Value ? null : objRow[conGameBottle.UserId_PickUp].ToString().Trim(); //用户ID
objGameBottleEN.PickUpTime = objRow[conGameBottle.PickUpTime] == DBNull.Value ? null : objRow[conGameBottle.PickUpTime].ToString().Trim(); //捞的时间
objGameBottleEN.FinishedTime = objRow[conGameBottle.FinishedTime] == DBNull.Value ? null : objRow[conGameBottle.FinishedTime].ToString().Trim(); //完成时间
objGameBottleEN.PosTop = objRow[conGameBottle.PosTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGameBottle.PosTop].ToString().Trim()); //位置Y
objGameBottleEN.PosLeft = objRow[conGameBottle.PosLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGameBottle.PosLeft].ToString().Trim()); //位置X
objGameBottleEN.BottleStateId = objRow[conGameBottle.BottleStateId].ToString().Trim(); //操作方式Id
objGameBottleEN.UpdUser = objRow[conGameBottle.UpdUser].ToString().Trim(); //修改人
objGameBottleEN.UpdDate = objRow[conGameBottle.UpdDate].ToString().Trim(); //修改日期
objGameBottleEN.Memo = objRow[conGameBottle.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsGameBottleDA: GetObjLst)", objException.Message));
}
objGameBottleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objGameBottleEN);
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
public List<clsGameBottleEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsGameBottleDA:GetObjLstByTabName)", objException.Message));
}
List<clsGameBottleEN> arrObjLst = new List<clsGameBottleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGameBottleEN objGameBottleEN = new clsGameBottleEN();
try
{
objGameBottleEN.BottleId = TransNullToInt(objRow[conGameBottle.BottleId].ToString().Trim()); //瓶子Id
objGameBottleEN.QuestionId = TransNullToInt(objRow[conGameBottle.QuestionId].ToString().Trim()); //题目Id
objGameBottleEN.UserId_Throw = objRow[conGameBottle.UserId_Throw].ToString().Trim(); //用户ID
objGameBottleEN.ThrowTime = objRow[conGameBottle.ThrowTime].ToString().Trim(); //扔的时间
objGameBottleEN.UserId_PickUp = objRow[conGameBottle.UserId_PickUp] == DBNull.Value ? null : objRow[conGameBottle.UserId_PickUp].ToString().Trim(); //用户ID
objGameBottleEN.PickUpTime = objRow[conGameBottle.PickUpTime] == DBNull.Value ? null : objRow[conGameBottle.PickUpTime].ToString().Trim(); //捞的时间
objGameBottleEN.FinishedTime = objRow[conGameBottle.FinishedTime] == DBNull.Value ? null : objRow[conGameBottle.FinishedTime].ToString().Trim(); //完成时间
objGameBottleEN.PosTop = objRow[conGameBottle.PosTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGameBottle.PosTop].ToString().Trim()); //位置Y
objGameBottleEN.PosLeft = objRow[conGameBottle.PosLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGameBottle.PosLeft].ToString().Trim()); //位置X
objGameBottleEN.BottleStateId = objRow[conGameBottle.BottleStateId].ToString().Trim(); //操作方式Id
objGameBottleEN.UpdUser = objRow[conGameBottle.UpdUser].ToString().Trim(); //修改人
objGameBottleEN.UpdDate = objRow[conGameBottle.UpdDate].ToString().Trim(); //修改日期
objGameBottleEN.Memo = objRow[conGameBottle.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsGameBottleDA: GetObjLst)", objException.Message));
}
objGameBottleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objGameBottleEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objGameBottleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetGameBottle(ref clsGameBottleEN objGameBottleEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
strSQL = "Select * from GameBottle where BottleId = " + ""+ objGameBottleEN.BottleId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objGameBottleEN.BottleId = TransNullToInt(objDT.Rows[0][conGameBottle.BottleId].ToString().Trim()); //瓶子Id(字段类型:bigint,字段长度:8,是否可空:False)
 objGameBottleEN.QuestionId = TransNullToInt(objDT.Rows[0][conGameBottle.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objGameBottleEN.UserId_Throw = objDT.Rows[0][conGameBottle.UserId_Throw].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objGameBottleEN.ThrowTime = objDT.Rows[0][conGameBottle.ThrowTime].ToString().Trim(); //扔的时间(字段类型:varchar,字段长度:20,是否可空:False)
 objGameBottleEN.UserId_PickUp = objDT.Rows[0][conGameBottle.UserId_PickUp].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objGameBottleEN.PickUpTime = objDT.Rows[0][conGameBottle.PickUpTime].ToString().Trim(); //捞的时间(字段类型:varchar,字段长度:20,是否可空:False)
 objGameBottleEN.FinishedTime = objDT.Rows[0][conGameBottle.FinishedTime].ToString().Trim(); //完成时间(字段类型:varchar,字段长度:20,是否可空:False)
 objGameBottleEN.PosTop = TransNullToInt(objDT.Rows[0][conGameBottle.PosTop].ToString().Trim()); //位置Y(字段类型:int,字段长度:4,是否可空:False)
 objGameBottleEN.PosLeft = TransNullToInt(objDT.Rows[0][conGameBottle.PosLeft].ToString().Trim()); //位置X(字段类型:int,字段长度:4,是否可空:False)
 objGameBottleEN.BottleStateId = objDT.Rows[0][conGameBottle.BottleStateId].ToString().Trim(); //操作方式Id(字段类型:char,字段长度:2,是否可空:False)
 objGameBottleEN.UpdUser = objDT.Rows[0][conGameBottle.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objGameBottleEN.UpdDate = objDT.Rows[0][conGameBottle.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objGameBottleEN.Memo = objDT.Rows[0][conGameBottle.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsGameBottleDA: GetGameBottle)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngBottleId">表关键字</param>
 /// <returns>表对象</returns>
public clsGameBottleEN GetObjByBottleId(long lngBottleId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
strSQL = "Select * from GameBottle where BottleId = " + ""+ lngBottleId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsGameBottleEN objGameBottleEN = new clsGameBottleEN();
try
{
 objGameBottleEN.BottleId = Int32.Parse(objRow[conGameBottle.BottleId].ToString().Trim()); //瓶子Id(字段类型:bigint,字段长度:8,是否可空:False)
 objGameBottleEN.QuestionId = Int32.Parse(objRow[conGameBottle.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objGameBottleEN.UserId_Throw = objRow[conGameBottle.UserId_Throw].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objGameBottleEN.ThrowTime = objRow[conGameBottle.ThrowTime].ToString().Trim(); //扔的时间(字段类型:varchar,字段长度:20,是否可空:False)
 objGameBottleEN.UserId_PickUp = objRow[conGameBottle.UserId_PickUp] == DBNull.Value ? null : objRow[conGameBottle.UserId_PickUp].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objGameBottleEN.PickUpTime = objRow[conGameBottle.PickUpTime] == DBNull.Value ? null : objRow[conGameBottle.PickUpTime].ToString().Trim(); //捞的时间(字段类型:varchar,字段长度:20,是否可空:False)
 objGameBottleEN.FinishedTime = objRow[conGameBottle.FinishedTime] == DBNull.Value ? null : objRow[conGameBottle.FinishedTime].ToString().Trim(); //完成时间(字段类型:varchar,字段长度:20,是否可空:False)
 objGameBottleEN.PosTop = objRow[conGameBottle.PosTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosTop].ToString().Trim()); //位置Y(字段类型:int,字段长度:4,是否可空:False)
 objGameBottleEN.PosLeft = objRow[conGameBottle.PosLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosLeft].ToString().Trim()); //位置X(字段类型:int,字段长度:4,是否可空:False)
 objGameBottleEN.BottleStateId = objRow[conGameBottle.BottleStateId].ToString().Trim(); //操作方式Id(字段类型:char,字段长度:2,是否可空:False)
 objGameBottleEN.UpdUser = objRow[conGameBottle.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objGameBottleEN.UpdDate = objRow[conGameBottle.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objGameBottleEN.Memo = objRow[conGameBottle.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsGameBottleDA: GetObjByBottleId)", objException.Message));
}
return objGameBottleEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsGameBottleEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsGameBottleDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
strSQL = "Select * from GameBottle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsGameBottleEN objGameBottleEN = new clsGameBottleEN()
{
BottleId = TransNullToInt(objRow[conGameBottle.BottleId].ToString().Trim()), //瓶子Id
QuestionId = TransNullToInt(objRow[conGameBottle.QuestionId].ToString().Trim()), //题目Id
UserId_Throw = objRow[conGameBottle.UserId_Throw].ToString().Trim(), //用户ID
ThrowTime = objRow[conGameBottle.ThrowTime].ToString().Trim(), //扔的时间
UserId_PickUp = objRow[conGameBottle.UserId_PickUp] == DBNull.Value ? null : objRow[conGameBottle.UserId_PickUp].ToString().Trim(), //用户ID
PickUpTime = objRow[conGameBottle.PickUpTime] == DBNull.Value ? null : objRow[conGameBottle.PickUpTime].ToString().Trim(), //捞的时间
FinishedTime = objRow[conGameBottle.FinishedTime] == DBNull.Value ? null : objRow[conGameBottle.FinishedTime].ToString().Trim(), //完成时间
PosTop = objRow[conGameBottle.PosTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGameBottle.PosTop].ToString().Trim()), //位置Y
PosLeft = objRow[conGameBottle.PosLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGameBottle.PosLeft].ToString().Trim()), //位置X
BottleStateId = objRow[conGameBottle.BottleStateId].ToString().Trim(), //操作方式Id
UpdUser = objRow[conGameBottle.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conGameBottle.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conGameBottle.Memo].ToString().Trim() //备注
};
objGameBottleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGameBottleEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsGameBottleDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsGameBottleEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsGameBottleEN objGameBottleEN = new clsGameBottleEN();
try
{
objGameBottleEN.BottleId = TransNullToInt(objRow[conGameBottle.BottleId].ToString().Trim()); //瓶子Id
objGameBottleEN.QuestionId = TransNullToInt(objRow[conGameBottle.QuestionId].ToString().Trim()); //题目Id
objGameBottleEN.UserId_Throw = objRow[conGameBottle.UserId_Throw].ToString().Trim(); //用户ID
objGameBottleEN.ThrowTime = objRow[conGameBottle.ThrowTime].ToString().Trim(); //扔的时间
objGameBottleEN.UserId_PickUp = objRow[conGameBottle.UserId_PickUp] == DBNull.Value ? null : objRow[conGameBottle.UserId_PickUp].ToString().Trim(); //用户ID
objGameBottleEN.PickUpTime = objRow[conGameBottle.PickUpTime] == DBNull.Value ? null : objRow[conGameBottle.PickUpTime].ToString().Trim(); //捞的时间
objGameBottleEN.FinishedTime = objRow[conGameBottle.FinishedTime] == DBNull.Value ? null : objRow[conGameBottle.FinishedTime].ToString().Trim(); //完成时间
objGameBottleEN.PosTop = objRow[conGameBottle.PosTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGameBottle.PosTop].ToString().Trim()); //位置Y
objGameBottleEN.PosLeft = objRow[conGameBottle.PosLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGameBottle.PosLeft].ToString().Trim()); //位置X
objGameBottleEN.BottleStateId = objRow[conGameBottle.BottleStateId].ToString().Trim(); //操作方式Id
objGameBottleEN.UpdUser = objRow[conGameBottle.UpdUser].ToString().Trim(); //修改人
objGameBottleEN.UpdDate = objRow[conGameBottle.UpdDate].ToString().Trim(); //修改日期
objGameBottleEN.Memo = objRow[conGameBottle.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsGameBottleDA: GetObjByDataRowGameBottle)", objException.Message));
}
objGameBottleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGameBottleEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsGameBottleEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsGameBottleEN objGameBottleEN = new clsGameBottleEN();
try
{
objGameBottleEN.BottleId = TransNullToInt(objRow[conGameBottle.BottleId].ToString().Trim()); //瓶子Id
objGameBottleEN.QuestionId = TransNullToInt(objRow[conGameBottle.QuestionId].ToString().Trim()); //题目Id
objGameBottleEN.UserId_Throw = objRow[conGameBottle.UserId_Throw].ToString().Trim(); //用户ID
objGameBottleEN.ThrowTime = objRow[conGameBottle.ThrowTime].ToString().Trim(); //扔的时间
objGameBottleEN.UserId_PickUp = objRow[conGameBottle.UserId_PickUp] == DBNull.Value ? null : objRow[conGameBottle.UserId_PickUp].ToString().Trim(); //用户ID
objGameBottleEN.PickUpTime = objRow[conGameBottle.PickUpTime] == DBNull.Value ? null : objRow[conGameBottle.PickUpTime].ToString().Trim(); //捞的时间
objGameBottleEN.FinishedTime = objRow[conGameBottle.FinishedTime] == DBNull.Value ? null : objRow[conGameBottle.FinishedTime].ToString().Trim(); //完成时间
objGameBottleEN.PosTop = objRow[conGameBottle.PosTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGameBottle.PosTop].ToString().Trim()); //位置Y
objGameBottleEN.PosLeft = objRow[conGameBottle.PosLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGameBottle.PosLeft].ToString().Trim()); //位置X
objGameBottleEN.BottleStateId = objRow[conGameBottle.BottleStateId].ToString().Trim(); //操作方式Id
objGameBottleEN.UpdUser = objRow[conGameBottle.UpdUser].ToString().Trim(); //修改人
objGameBottleEN.UpdDate = objRow[conGameBottle.UpdDate].ToString().Trim(); //修改日期
objGameBottleEN.Memo = objRow[conGameBottle.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsGameBottleDA: GetObjByDataRow)", objException.Message));
}
objGameBottleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGameBottleEN;
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
objSQL = clsGameBottleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsGameBottleEN._CurrTabName, conGameBottle.BottleId, 8, "");
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
objSQL = clsGameBottleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsGameBottleEN._CurrTabName, conGameBottle.BottleId, 8, strPrefix);
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
 objSQL = clsGameBottleDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select BottleId from GameBottle where " + strCondition;
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
 objSQL = clsGameBottleDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select BottleId from GameBottle where " + strCondition;
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
 /// <param name = "lngBottleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngBottleId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("GameBottle", "BottleId = " + ""+ lngBottleId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsGameBottleDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("GameBottle", strCondition))
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
objSQL = clsGameBottleDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("GameBottle");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsGameBottleEN objGameBottleEN)
 {
 objGameBottleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGameBottleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGameBottleEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
strSQL = "Select * from GameBottle where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "GameBottle");
objRow = objDS.Tables["GameBottle"].NewRow();
objRow[conGameBottle.QuestionId] = objGameBottleEN.QuestionId; //题目Id
objRow[conGameBottle.UserId_Throw] = objGameBottleEN.UserId_Throw; //用户ID
objRow[conGameBottle.ThrowTime] = objGameBottleEN.ThrowTime; //扔的时间
 if (objGameBottleEN.UserId_PickUp !=  "")
 {
objRow[conGameBottle.UserId_PickUp] = objGameBottleEN.UserId_PickUp; //用户ID
 }
 if (objGameBottleEN.PickUpTime !=  "")
 {
objRow[conGameBottle.PickUpTime] = objGameBottleEN.PickUpTime; //捞的时间
 }
 if (objGameBottleEN.FinishedTime !=  "")
 {
objRow[conGameBottle.FinishedTime] = objGameBottleEN.FinishedTime; //完成时间
 }
objRow[conGameBottle.PosTop] = objGameBottleEN.PosTop; //位置Y
objRow[conGameBottle.PosLeft] = objGameBottleEN.PosLeft; //位置X
objRow[conGameBottle.BottleStateId] = objGameBottleEN.BottleStateId; //操作方式Id
objRow[conGameBottle.UpdUser] = objGameBottleEN.UpdUser; //修改人
objRow[conGameBottle.UpdDate] = objGameBottleEN.UpdDate; //修改日期
objRow[conGameBottle.Memo] = objGameBottleEN.Memo; //备注
objDS.Tables[clsGameBottleEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsGameBottleEN._CurrTabName);
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
 /// <param name = "objGameBottleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsGameBottleEN objGameBottleEN)
{
 objGameBottleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGameBottleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGameBottleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conGameBottle.QuestionId);
 arrValueListForInsert.Add(objGameBottleEN.QuestionId.ToString());
 
 if (objGameBottleEN.UserId_Throw !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.UserId_Throw);
 var strUserId_Throw = objGameBottleEN.UserId_Throw.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId_Throw + "'");
 }
 
 if (objGameBottleEN.ThrowTime !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.ThrowTime);
 var strThrowTime = objGameBottleEN.ThrowTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThrowTime + "'");
 }
 
 if (objGameBottleEN.UserId_PickUp !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.UserId_PickUp);
 var strUserId_PickUp = objGameBottleEN.UserId_PickUp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId_PickUp + "'");
 }
 
 if (objGameBottleEN.PickUpTime !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.PickUpTime);
 var strPickUpTime = objGameBottleEN.PickUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPickUpTime + "'");
 }
 
 if (objGameBottleEN.FinishedTime !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.FinishedTime);
 var strFinishedTime = objGameBottleEN.FinishedTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFinishedTime + "'");
 }
 
 if (objGameBottleEN.PosTop !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.PosTop);
 arrValueListForInsert.Add(objGameBottleEN.PosTop.ToString());
 }
 
 if (objGameBottleEN.PosLeft !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.PosLeft);
 arrValueListForInsert.Add(objGameBottleEN.PosLeft.ToString());
 }
 
 if (objGameBottleEN.BottleStateId !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.BottleStateId);
 var strBottleStateId = objGameBottleEN.BottleStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBottleStateId + "'");
 }
 
 if (objGameBottleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.UpdUser);
 var strUpdUser = objGameBottleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGameBottleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.UpdDate);
 var strUpdDate = objGameBottleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGameBottleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.Memo);
 var strMemo = objGameBottleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GameBottle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objGameBottleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsGameBottleEN objGameBottleEN)
{
 objGameBottleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGameBottleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGameBottleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conGameBottle.QuestionId);
 arrValueListForInsert.Add(objGameBottleEN.QuestionId.ToString());
 
 if (objGameBottleEN.UserId_Throw !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.UserId_Throw);
 var strUserId_Throw = objGameBottleEN.UserId_Throw.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId_Throw + "'");
 }
 
 if (objGameBottleEN.ThrowTime !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.ThrowTime);
 var strThrowTime = objGameBottleEN.ThrowTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThrowTime + "'");
 }
 
 if (objGameBottleEN.UserId_PickUp !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.UserId_PickUp);
 var strUserId_PickUp = objGameBottleEN.UserId_PickUp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId_PickUp + "'");
 }
 
 if (objGameBottleEN.PickUpTime !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.PickUpTime);
 var strPickUpTime = objGameBottleEN.PickUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPickUpTime + "'");
 }
 
 if (objGameBottleEN.FinishedTime !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.FinishedTime);
 var strFinishedTime = objGameBottleEN.FinishedTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFinishedTime + "'");
 }
 
 if (objGameBottleEN.PosTop !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.PosTop);
 arrValueListForInsert.Add(objGameBottleEN.PosTop.ToString());
 }
 
 if (objGameBottleEN.PosLeft !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.PosLeft);
 arrValueListForInsert.Add(objGameBottleEN.PosLeft.ToString());
 }
 
 if (objGameBottleEN.BottleStateId !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.BottleStateId);
 var strBottleStateId = objGameBottleEN.BottleStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBottleStateId + "'");
 }
 
 if (objGameBottleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.UpdUser);
 var strUpdUser = objGameBottleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGameBottleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.UpdDate);
 var strUpdDate = objGameBottleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGameBottleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.Memo);
 var strMemo = objGameBottleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GameBottle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objGameBottleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsGameBottleEN objGameBottleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objGameBottleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGameBottleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGameBottleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conGameBottle.QuestionId);
 arrValueListForInsert.Add(objGameBottleEN.QuestionId.ToString());
 
 if (objGameBottleEN.UserId_Throw !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.UserId_Throw);
 var strUserId_Throw = objGameBottleEN.UserId_Throw.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId_Throw + "'");
 }
 
 if (objGameBottleEN.ThrowTime !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.ThrowTime);
 var strThrowTime = objGameBottleEN.ThrowTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThrowTime + "'");
 }
 
 if (objGameBottleEN.UserId_PickUp !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.UserId_PickUp);
 var strUserId_PickUp = objGameBottleEN.UserId_PickUp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId_PickUp + "'");
 }
 
 if (objGameBottleEN.PickUpTime !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.PickUpTime);
 var strPickUpTime = objGameBottleEN.PickUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPickUpTime + "'");
 }
 
 if (objGameBottleEN.FinishedTime !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.FinishedTime);
 var strFinishedTime = objGameBottleEN.FinishedTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFinishedTime + "'");
 }
 
 if (objGameBottleEN.PosTop !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.PosTop);
 arrValueListForInsert.Add(objGameBottleEN.PosTop.ToString());
 }
 
 if (objGameBottleEN.PosLeft !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.PosLeft);
 arrValueListForInsert.Add(objGameBottleEN.PosLeft.ToString());
 }
 
 if (objGameBottleEN.BottleStateId !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.BottleStateId);
 var strBottleStateId = objGameBottleEN.BottleStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBottleStateId + "'");
 }
 
 if (objGameBottleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.UpdUser);
 var strUpdUser = objGameBottleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGameBottleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.UpdDate);
 var strUpdDate = objGameBottleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGameBottleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.Memo);
 var strMemo = objGameBottleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GameBottle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objGameBottleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsGameBottleEN objGameBottleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objGameBottleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGameBottleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGameBottleEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conGameBottle.QuestionId);
 arrValueListForInsert.Add(objGameBottleEN.QuestionId.ToString());
 
 if (objGameBottleEN.UserId_Throw !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.UserId_Throw);
 var strUserId_Throw = objGameBottleEN.UserId_Throw.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId_Throw + "'");
 }
 
 if (objGameBottleEN.ThrowTime !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.ThrowTime);
 var strThrowTime = objGameBottleEN.ThrowTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThrowTime + "'");
 }
 
 if (objGameBottleEN.UserId_PickUp !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.UserId_PickUp);
 var strUserId_PickUp = objGameBottleEN.UserId_PickUp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId_PickUp + "'");
 }
 
 if (objGameBottleEN.PickUpTime !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.PickUpTime);
 var strPickUpTime = objGameBottleEN.PickUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPickUpTime + "'");
 }
 
 if (objGameBottleEN.FinishedTime !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.FinishedTime);
 var strFinishedTime = objGameBottleEN.FinishedTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFinishedTime + "'");
 }
 
 if (objGameBottleEN.PosTop !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.PosTop);
 arrValueListForInsert.Add(objGameBottleEN.PosTop.ToString());
 }
 
 if (objGameBottleEN.PosLeft !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.PosLeft);
 arrValueListForInsert.Add(objGameBottleEN.PosLeft.ToString());
 }
 
 if (objGameBottleEN.BottleStateId !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.BottleStateId);
 var strBottleStateId = objGameBottleEN.BottleStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBottleStateId + "'");
 }
 
 if (objGameBottleEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.UpdUser);
 var strUpdUser = objGameBottleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objGameBottleEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.UpdDate);
 var strUpdDate = objGameBottleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objGameBottleEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conGameBottle.Memo);
 var strMemo = objGameBottleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GameBottle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewGameBottles(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
strSQL = "Select * from GameBottle where BottleId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "GameBottle");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngBottleId = TransNullToInt(oRow[conGameBottle.BottleId].ToString().Trim());
if (IsExist(lngBottleId))
{
 string strResult = "关键字变量值为:" + string.Format("BottleId = {0}", lngBottleId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsGameBottleEN._CurrTabName ].NewRow();
objRow[conGameBottle.QuestionId] = oRow[conGameBottle.QuestionId].ToString().Trim(); //题目Id
objRow[conGameBottle.UserId_Throw] = oRow[conGameBottle.UserId_Throw].ToString().Trim(); //用户ID
objRow[conGameBottle.ThrowTime] = oRow[conGameBottle.ThrowTime].ToString().Trim(); //扔的时间
objRow[conGameBottle.UserId_PickUp] = oRow[conGameBottle.UserId_PickUp].ToString().Trim(); //用户ID
objRow[conGameBottle.PickUpTime] = oRow[conGameBottle.PickUpTime].ToString().Trim(); //捞的时间
objRow[conGameBottle.FinishedTime] = oRow[conGameBottle.FinishedTime].ToString().Trim(); //完成时间
objRow[conGameBottle.PosTop] = oRow[conGameBottle.PosTop].ToString().Trim(); //位置Y
objRow[conGameBottle.PosLeft] = oRow[conGameBottle.PosLeft].ToString().Trim(); //位置X
objRow[conGameBottle.BottleStateId] = oRow[conGameBottle.BottleStateId].ToString().Trim(); //操作方式Id
objRow[conGameBottle.UpdUser] = oRow[conGameBottle.UpdUser].ToString().Trim(); //修改人
objRow[conGameBottle.UpdDate] = oRow[conGameBottle.UpdDate].ToString().Trim(); //修改日期
objRow[conGameBottle.Memo] = oRow[conGameBottle.Memo].ToString().Trim(); //备注
 objDS.Tables[clsGameBottleEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsGameBottleEN._CurrTabName);
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
 /// <param name = "objGameBottleEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsGameBottleEN objGameBottleEN)
{
 objGameBottleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGameBottleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGameBottleEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
strSQL = "Select * from GameBottle where BottleId = " + ""+ objGameBottleEN.BottleId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsGameBottleEN._CurrTabName);
if (objDS.Tables[clsGameBottleEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:BottleId = " + ""+ objGameBottleEN.BottleId+"");
return false;
}
objRow = objDS.Tables[clsGameBottleEN._CurrTabName].Rows[0];
 if (objGameBottleEN.IsUpdated(conGameBottle.QuestionId))
 {
objRow[conGameBottle.QuestionId] = objGameBottleEN.QuestionId; //题目Id
 }
 if (objGameBottleEN.IsUpdated(conGameBottle.UserId_Throw))
 {
objRow[conGameBottle.UserId_Throw] = objGameBottleEN.UserId_Throw; //用户ID
 }
 if (objGameBottleEN.IsUpdated(conGameBottle.ThrowTime))
 {
objRow[conGameBottle.ThrowTime] = objGameBottleEN.ThrowTime; //扔的时间
 }
 if (objGameBottleEN.IsUpdated(conGameBottle.UserId_PickUp))
 {
objRow[conGameBottle.UserId_PickUp] = objGameBottleEN.UserId_PickUp; //用户ID
 }
 if (objGameBottleEN.IsUpdated(conGameBottle.PickUpTime))
 {
objRow[conGameBottle.PickUpTime] = objGameBottleEN.PickUpTime; //捞的时间
 }
 if (objGameBottleEN.IsUpdated(conGameBottle.FinishedTime))
 {
objRow[conGameBottle.FinishedTime] = objGameBottleEN.FinishedTime; //完成时间
 }
 if (objGameBottleEN.IsUpdated(conGameBottle.PosTop))
 {
objRow[conGameBottle.PosTop] = objGameBottleEN.PosTop; //位置Y
 }
 if (objGameBottleEN.IsUpdated(conGameBottle.PosLeft))
 {
objRow[conGameBottle.PosLeft] = objGameBottleEN.PosLeft; //位置X
 }
 if (objGameBottleEN.IsUpdated(conGameBottle.BottleStateId))
 {
objRow[conGameBottle.BottleStateId] = objGameBottleEN.BottleStateId; //操作方式Id
 }
 if (objGameBottleEN.IsUpdated(conGameBottle.UpdUser))
 {
objRow[conGameBottle.UpdUser] = objGameBottleEN.UpdUser; //修改人
 }
 if (objGameBottleEN.IsUpdated(conGameBottle.UpdDate))
 {
objRow[conGameBottle.UpdDate] = objGameBottleEN.UpdDate; //修改日期
 }
 if (objGameBottleEN.IsUpdated(conGameBottle.Memo))
 {
objRow[conGameBottle.Memo] = objGameBottleEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsGameBottleEN._CurrTabName);
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
 /// <param name = "objGameBottleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsGameBottleEN objGameBottleEN)
{
 objGameBottleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGameBottleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGameBottleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update GameBottle Set ");
 
 if (objGameBottleEN.IsUpdated(conGameBottle.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objGameBottleEN.QuestionId, conGameBottle.QuestionId); //题目Id
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.UserId_Throw))
 {
 if (objGameBottleEN.UserId_Throw !=  null)
 {
 var strUserId_Throw = objGameBottleEN.UserId_Throw.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId_Throw, conGameBottle.UserId_Throw); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.UserId_Throw); //用户ID
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.ThrowTime))
 {
 if (objGameBottleEN.ThrowTime !=  null)
 {
 var strThrowTime = objGameBottleEN.ThrowTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strThrowTime, conGameBottle.ThrowTime); //扔的时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.ThrowTime); //扔的时间
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.UserId_PickUp))
 {
 if (objGameBottleEN.UserId_PickUp !=  null)
 {
 var strUserId_PickUp = objGameBottleEN.UserId_PickUp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId_PickUp, conGameBottle.UserId_PickUp); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.UserId_PickUp); //用户ID
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.PickUpTime))
 {
 if (objGameBottleEN.PickUpTime !=  null)
 {
 var strPickUpTime = objGameBottleEN.PickUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPickUpTime, conGameBottle.PickUpTime); //捞的时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.PickUpTime); //捞的时间
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.FinishedTime))
 {
 if (objGameBottleEN.FinishedTime !=  null)
 {
 var strFinishedTime = objGameBottleEN.FinishedTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFinishedTime, conGameBottle.FinishedTime); //完成时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.FinishedTime); //完成时间
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.PosTop))
 {
 if (objGameBottleEN.PosTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGameBottleEN.PosTop, conGameBottle.PosTop); //位置Y
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.PosTop); //位置Y
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.PosLeft))
 {
 if (objGameBottleEN.PosLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGameBottleEN.PosLeft, conGameBottle.PosLeft); //位置X
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.PosLeft); //位置X
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.BottleStateId))
 {
 if (objGameBottleEN.BottleStateId !=  null)
 {
 var strBottleStateId = objGameBottleEN.BottleStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBottleStateId, conGameBottle.BottleStateId); //操作方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.BottleStateId); //操作方式Id
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.UpdUser))
 {
 if (objGameBottleEN.UpdUser !=  null)
 {
 var strUpdUser = objGameBottleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conGameBottle.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.UpdUser); //修改人
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.UpdDate))
 {
 if (objGameBottleEN.UpdDate !=  null)
 {
 var strUpdDate = objGameBottleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conGameBottle.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.UpdDate); //修改日期
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.Memo))
 {
 if (objGameBottleEN.Memo !=  null)
 {
 var strMemo = objGameBottleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conGameBottle.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where BottleId = {0}", objGameBottleEN.BottleId); 
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
 /// <param name = "objGameBottleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsGameBottleEN objGameBottleEN, string strCondition)
{
 objGameBottleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGameBottleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGameBottleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GameBottle Set ");
 
 if (objGameBottleEN.IsUpdated(conGameBottle.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objGameBottleEN.QuestionId); //题目Id
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.UserId_Throw))
 {
 if (objGameBottleEN.UserId_Throw !=  null)
 {
 var strUserId_Throw = objGameBottleEN.UserId_Throw.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId_Throw = '{0}',", strUserId_Throw); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId_Throw = null,"); //用户ID
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.ThrowTime))
 {
 if (objGameBottleEN.ThrowTime !=  null)
 {
 var strThrowTime = objGameBottleEN.ThrowTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ThrowTime = '{0}',", strThrowTime); //扔的时间
 }
 else
 {
 sbSQL.Append(" ThrowTime = null,"); //扔的时间
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.UserId_PickUp))
 {
 if (objGameBottleEN.UserId_PickUp !=  null)
 {
 var strUserId_PickUp = objGameBottleEN.UserId_PickUp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId_PickUp = '{0}',", strUserId_PickUp); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId_PickUp = null,"); //用户ID
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.PickUpTime))
 {
 if (objGameBottleEN.PickUpTime !=  null)
 {
 var strPickUpTime = objGameBottleEN.PickUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PickUpTime = '{0}',", strPickUpTime); //捞的时间
 }
 else
 {
 sbSQL.Append(" PickUpTime = null,"); //捞的时间
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.FinishedTime))
 {
 if (objGameBottleEN.FinishedTime !=  null)
 {
 var strFinishedTime = objGameBottleEN.FinishedTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FinishedTime = '{0}',", strFinishedTime); //完成时间
 }
 else
 {
 sbSQL.Append(" FinishedTime = null,"); //完成时间
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.PosTop))
 {
 if (objGameBottleEN.PosTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGameBottleEN.PosTop, conGameBottle.PosTop); //位置Y
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.PosTop); //位置Y
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.PosLeft))
 {
 if (objGameBottleEN.PosLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGameBottleEN.PosLeft, conGameBottle.PosLeft); //位置X
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.PosLeft); //位置X
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.BottleStateId))
 {
 if (objGameBottleEN.BottleStateId !=  null)
 {
 var strBottleStateId = objGameBottleEN.BottleStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BottleStateId = '{0}',", strBottleStateId); //操作方式Id
 }
 else
 {
 sbSQL.Append(" BottleStateId = null,"); //操作方式Id
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.UpdUser))
 {
 if (objGameBottleEN.UpdUser !=  null)
 {
 var strUpdUser = objGameBottleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.UpdDate))
 {
 if (objGameBottleEN.UpdDate !=  null)
 {
 var strUpdDate = objGameBottleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.Memo))
 {
 if (objGameBottleEN.Memo !=  null)
 {
 var strMemo = objGameBottleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objGameBottleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsGameBottleEN objGameBottleEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objGameBottleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGameBottleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGameBottleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GameBottle Set ");
 
 if (objGameBottleEN.IsUpdated(conGameBottle.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objGameBottleEN.QuestionId); //题目Id
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.UserId_Throw))
 {
 if (objGameBottleEN.UserId_Throw !=  null)
 {
 var strUserId_Throw = objGameBottleEN.UserId_Throw.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId_Throw = '{0}',", strUserId_Throw); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId_Throw = null,"); //用户ID
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.ThrowTime))
 {
 if (objGameBottleEN.ThrowTime !=  null)
 {
 var strThrowTime = objGameBottleEN.ThrowTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ThrowTime = '{0}',", strThrowTime); //扔的时间
 }
 else
 {
 sbSQL.Append(" ThrowTime = null,"); //扔的时间
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.UserId_PickUp))
 {
 if (objGameBottleEN.UserId_PickUp !=  null)
 {
 var strUserId_PickUp = objGameBottleEN.UserId_PickUp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId_PickUp = '{0}',", strUserId_PickUp); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId_PickUp = null,"); //用户ID
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.PickUpTime))
 {
 if (objGameBottleEN.PickUpTime !=  null)
 {
 var strPickUpTime = objGameBottleEN.PickUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PickUpTime = '{0}',", strPickUpTime); //捞的时间
 }
 else
 {
 sbSQL.Append(" PickUpTime = null,"); //捞的时间
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.FinishedTime))
 {
 if (objGameBottleEN.FinishedTime !=  null)
 {
 var strFinishedTime = objGameBottleEN.FinishedTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FinishedTime = '{0}',", strFinishedTime); //完成时间
 }
 else
 {
 sbSQL.Append(" FinishedTime = null,"); //完成时间
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.PosTop))
 {
 if (objGameBottleEN.PosTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGameBottleEN.PosTop, conGameBottle.PosTop); //位置Y
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.PosTop); //位置Y
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.PosLeft))
 {
 if (objGameBottleEN.PosLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGameBottleEN.PosLeft, conGameBottle.PosLeft); //位置X
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.PosLeft); //位置X
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.BottleStateId))
 {
 if (objGameBottleEN.BottleStateId !=  null)
 {
 var strBottleStateId = objGameBottleEN.BottleStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BottleStateId = '{0}',", strBottleStateId); //操作方式Id
 }
 else
 {
 sbSQL.Append(" BottleStateId = null,"); //操作方式Id
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.UpdUser))
 {
 if (objGameBottleEN.UpdUser !=  null)
 {
 var strUpdUser = objGameBottleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.UpdDate))
 {
 if (objGameBottleEN.UpdDate !=  null)
 {
 var strUpdDate = objGameBottleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.Memo))
 {
 if (objGameBottleEN.Memo !=  null)
 {
 var strMemo = objGameBottleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objGameBottleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsGameBottleEN objGameBottleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objGameBottleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objGameBottleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGameBottleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GameBottle Set ");
 
 if (objGameBottleEN.IsUpdated(conGameBottle.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objGameBottleEN.QuestionId, conGameBottle.QuestionId); //题目Id
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.UserId_Throw))
 {
 if (objGameBottleEN.UserId_Throw !=  null)
 {
 var strUserId_Throw = objGameBottleEN.UserId_Throw.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId_Throw, conGameBottle.UserId_Throw); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.UserId_Throw); //用户ID
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.ThrowTime))
 {
 if (objGameBottleEN.ThrowTime !=  null)
 {
 var strThrowTime = objGameBottleEN.ThrowTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strThrowTime, conGameBottle.ThrowTime); //扔的时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.ThrowTime); //扔的时间
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.UserId_PickUp))
 {
 if (objGameBottleEN.UserId_PickUp !=  null)
 {
 var strUserId_PickUp = objGameBottleEN.UserId_PickUp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId_PickUp, conGameBottle.UserId_PickUp); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.UserId_PickUp); //用户ID
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.PickUpTime))
 {
 if (objGameBottleEN.PickUpTime !=  null)
 {
 var strPickUpTime = objGameBottleEN.PickUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPickUpTime, conGameBottle.PickUpTime); //捞的时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.PickUpTime); //捞的时间
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.FinishedTime))
 {
 if (objGameBottleEN.FinishedTime !=  null)
 {
 var strFinishedTime = objGameBottleEN.FinishedTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFinishedTime, conGameBottle.FinishedTime); //完成时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.FinishedTime); //完成时间
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.PosTop))
 {
 if (objGameBottleEN.PosTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGameBottleEN.PosTop, conGameBottle.PosTop); //位置Y
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.PosTop); //位置Y
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.PosLeft))
 {
 if (objGameBottleEN.PosLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGameBottleEN.PosLeft, conGameBottle.PosLeft); //位置X
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.PosLeft); //位置X
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.BottleStateId))
 {
 if (objGameBottleEN.BottleStateId !=  null)
 {
 var strBottleStateId = objGameBottleEN.BottleStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBottleStateId, conGameBottle.BottleStateId); //操作方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.BottleStateId); //操作方式Id
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.UpdUser))
 {
 if (objGameBottleEN.UpdUser !=  null)
 {
 var strUpdUser = objGameBottleEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conGameBottle.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.UpdUser); //修改人
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.UpdDate))
 {
 if (objGameBottleEN.UpdDate !=  null)
 {
 var strUpdDate = objGameBottleEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conGameBottle.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.UpdDate); //修改日期
 }
 }
 
 if (objGameBottleEN.IsUpdated(conGameBottle.Memo))
 {
 if (objGameBottleEN.Memo !=  null)
 {
 var strMemo = objGameBottleEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conGameBottle.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGameBottle.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where BottleId = {0}", objGameBottleEN.BottleId); 
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
 /// <param name = "lngBottleId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngBottleId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngBottleId,
};
 objSQL.ExecSP("GameBottle_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngBottleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngBottleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
//删除GameBottle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GameBottle where BottleId = " + ""+ lngBottleId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelGameBottle(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
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
//删除GameBottle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GameBottle where BottleId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngBottleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngBottleId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
//删除GameBottle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GameBottle where BottleId = " + ""+ lngBottleId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelGameBottle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsGameBottleDA: DelGameBottle)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from GameBottle where " + strCondition ;
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
public bool DelGameBottleWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsGameBottleDA: DelGameBottleWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGameBottleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from GameBottle where " + strCondition ;
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
 /// <param name = "objGameBottleENS">源对象</param>
 /// <param name = "objGameBottleENT">目标对象</param>
public void CopyTo(clsGameBottleEN objGameBottleENS, clsGameBottleEN objGameBottleENT)
{
objGameBottleENT.BottleId = objGameBottleENS.BottleId; //瓶子Id
objGameBottleENT.QuestionId = objGameBottleENS.QuestionId; //题目Id
objGameBottleENT.UserId_Throw = objGameBottleENS.UserId_Throw; //用户ID
objGameBottleENT.ThrowTime = objGameBottleENS.ThrowTime; //扔的时间
objGameBottleENT.UserId_PickUp = objGameBottleENS.UserId_PickUp; //用户ID
objGameBottleENT.PickUpTime = objGameBottleENS.PickUpTime; //捞的时间
objGameBottleENT.FinishedTime = objGameBottleENS.FinishedTime; //完成时间
objGameBottleENT.PosTop = objGameBottleENS.PosTop; //位置Y
objGameBottleENT.PosLeft = objGameBottleENS.PosLeft; //位置X
objGameBottleENT.BottleStateId = objGameBottleENS.BottleStateId; //操作方式Id
objGameBottleENT.UpdUser = objGameBottleENS.UpdUser; //修改人
objGameBottleENT.UpdDate = objGameBottleENS.UpdDate; //修改日期
objGameBottleENT.Memo = objGameBottleENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsGameBottleEN objGameBottleEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objGameBottleEN.QuestionId, conGameBottle.QuestionId);
clsCheckSql.CheckFieldNotNull(objGameBottleEN.UserId_Throw, conGameBottle.UserId_Throw);
clsCheckSql.CheckFieldNotNull(objGameBottleEN.ThrowTime, conGameBottle.ThrowTime);
clsCheckSql.CheckFieldNotNull(objGameBottleEN.BottleStateId, conGameBottle.BottleStateId);
clsCheckSql.CheckFieldNotNull(objGameBottleEN.UpdUser, conGameBottle.UpdUser);
clsCheckSql.CheckFieldNotNull(objGameBottleEN.UpdDate, conGameBottle.UpdDate);
clsCheckSql.CheckFieldNotNull(objGameBottleEN.Memo, conGameBottle.Memo);
//检查字段长度
clsCheckSql.CheckFieldLen(objGameBottleEN.UserId_Throw, 18, conGameBottle.UserId_Throw);
clsCheckSql.CheckFieldLen(objGameBottleEN.ThrowTime, 20, conGameBottle.ThrowTime);
clsCheckSql.CheckFieldLen(objGameBottleEN.UserId_PickUp, 18, conGameBottle.UserId_PickUp);
clsCheckSql.CheckFieldLen(objGameBottleEN.PickUpTime, 20, conGameBottle.PickUpTime);
clsCheckSql.CheckFieldLen(objGameBottleEN.FinishedTime, 20, conGameBottle.FinishedTime);
clsCheckSql.CheckFieldLen(objGameBottleEN.BottleStateId, 2, conGameBottle.BottleStateId);
clsCheckSql.CheckFieldLen(objGameBottleEN.UpdUser, 20, conGameBottle.UpdUser);
clsCheckSql.CheckFieldLen(objGameBottleEN.UpdDate, 20, conGameBottle.UpdDate);
clsCheckSql.CheckFieldLen(objGameBottleEN.Memo, 1000, conGameBottle.Memo);
//检查字段外键固定长度
 objGameBottleEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsGameBottleEN objGameBottleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objGameBottleEN.UserId_Throw, 18, conGameBottle.UserId_Throw);
clsCheckSql.CheckFieldLen(objGameBottleEN.ThrowTime, 20, conGameBottle.ThrowTime);
clsCheckSql.CheckFieldLen(objGameBottleEN.UserId_PickUp, 18, conGameBottle.UserId_PickUp);
clsCheckSql.CheckFieldLen(objGameBottleEN.PickUpTime, 20, conGameBottle.PickUpTime);
clsCheckSql.CheckFieldLen(objGameBottleEN.FinishedTime, 20, conGameBottle.FinishedTime);
clsCheckSql.CheckFieldLen(objGameBottleEN.BottleStateId, 2, conGameBottle.BottleStateId);
clsCheckSql.CheckFieldLen(objGameBottleEN.UpdUser, 20, conGameBottle.UpdUser);
clsCheckSql.CheckFieldLen(objGameBottleEN.UpdDate, 20, conGameBottle.UpdDate);
clsCheckSql.CheckFieldLen(objGameBottleEN.Memo, 1000, conGameBottle.Memo);
//检查外键字段长度
 objGameBottleEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsGameBottleEN objGameBottleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objGameBottleEN.UserId_Throw, 18, conGameBottle.UserId_Throw);
clsCheckSql.CheckFieldLen(objGameBottleEN.ThrowTime, 20, conGameBottle.ThrowTime);
clsCheckSql.CheckFieldLen(objGameBottleEN.UserId_PickUp, 18, conGameBottle.UserId_PickUp);
clsCheckSql.CheckFieldLen(objGameBottleEN.PickUpTime, 20, conGameBottle.PickUpTime);
clsCheckSql.CheckFieldLen(objGameBottleEN.FinishedTime, 20, conGameBottle.FinishedTime);
clsCheckSql.CheckFieldLen(objGameBottleEN.BottleStateId, 2, conGameBottle.BottleStateId);
clsCheckSql.CheckFieldLen(objGameBottleEN.UpdUser, 20, conGameBottle.UpdUser);
clsCheckSql.CheckFieldLen(objGameBottleEN.UpdDate, 20, conGameBottle.UpdDate);
clsCheckSql.CheckFieldLen(objGameBottleEN.Memo, 1000, conGameBottle.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objGameBottleEN.UserId_Throw, conGameBottle.UserId_Throw);
clsCheckSql.CheckSqlInjection4Field(objGameBottleEN.ThrowTime, conGameBottle.ThrowTime);
clsCheckSql.CheckSqlInjection4Field(objGameBottleEN.UserId_PickUp, conGameBottle.UserId_PickUp);
clsCheckSql.CheckSqlInjection4Field(objGameBottleEN.PickUpTime, conGameBottle.PickUpTime);
clsCheckSql.CheckSqlInjection4Field(objGameBottleEN.FinishedTime, conGameBottle.FinishedTime);
clsCheckSql.CheckSqlInjection4Field(objGameBottleEN.BottleStateId, conGameBottle.BottleStateId);
clsCheckSql.CheckSqlInjection4Field(objGameBottleEN.UpdUser, conGameBottle.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objGameBottleEN.UpdDate, conGameBottle.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objGameBottleEN.Memo, conGameBottle.Memo);
//检查外键字段长度
 objGameBottleEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--GameBottle(游戏瓶),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objGameBottleEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsGameBottleEN objGameBottleEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objGameBottleEN.QuestionId);
 sbCondition.AppendFormat(" and UserId_Throw = '{0}'", objGameBottleEN.UserId_Throw);
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
 objSQL = clsGameBottleDA.GetSpecSQLObj();
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
 objSQL = clsGameBottleDA.GetSpecSQLObj();
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
 objSQL = clsGameBottleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsGameBottleEN._CurrTabName);
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
 objSQL = clsGameBottleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsGameBottleEN._CurrTabName, strCondition);
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
 objSQL = clsGameBottleDA.GetSpecSQLObj();
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
 objSQL = clsGameBottleDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}