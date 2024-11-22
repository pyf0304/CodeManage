
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_UserCreditsLogDA
 表名:ge_UserCreditsLog(01120883)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:52
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
 /// 用户积分日志(ge_UserCreditsLog)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsge_UserCreditsLogDA : clsCommBase4DA
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
 return clsge_UserCreditsLogEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsge_UserCreditsLogEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_UserCreditsLogEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsge_UserCreditsLogEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsge_UserCreditsLogEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_UserCreditsLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserCreditsLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ge_UserCreditsLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsge_UserCreditsLogDA: GetDataTable_ge_UserCreditsLog)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserCreditsLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsge_UserCreditsLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsge_UserCreditsLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserCreditsLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsge_UserCreditsLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsge_UserCreditsLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_UserCreditsLog where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_UserCreditsLog where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsge_UserCreditsLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ge_UserCreditsLog where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsge_UserCreditsLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_UserCreditsLog.* from ge_UserCreditsLog Left Join {1} on {2} where {3} and ge_UserCreditsLog.mId not in (Select top {5} ge_UserCreditsLog.mId from ge_UserCreditsLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_UserCreditsLog where {1} and mId not in (Select top {2} mId from ge_UserCreditsLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_UserCreditsLog where {1} and mId not in (Select top {3} mId from ge_UserCreditsLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsge_UserCreditsLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_UserCreditsLog.* from ge_UserCreditsLog Left Join {1} on {2} where {3} and ge_UserCreditsLog.mId not in (Select top {5} ge_UserCreditsLog.mId from ge_UserCreditsLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_UserCreditsLog where {1} and mId not in (Select top {2} mId from ge_UserCreditsLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_UserCreditsLog where {1} and mId not in (Select top {3} mId from ge_UserCreditsLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsge_UserCreditsLogEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsge_UserCreditsLogDA:GetObjLst)", objException.Message));
}
List<clsge_UserCreditsLogEN> arrObjLst = new List<clsge_UserCreditsLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserCreditsLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserCreditsLogEN objge_UserCreditsLogEN = new clsge_UserCreditsLogEN();
try
{
objge_UserCreditsLogEN.mId = TransNullToInt(objRow[conge_UserCreditsLog.mId].ToString().Trim()); //mId
objge_UserCreditsLogEN.UserId = objRow[conge_UserCreditsLog.UserId] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UserId].ToString().Trim(); //用户ID
objge_UserCreditsLogEN.ExamBatchNo = objRow[conge_UserCreditsLog.ExamBatchNo].ToString().Trim(); //学生批次号
objge_UserCreditsLogEN.Credits = objRow[conge_UserCreditsLog.Credits] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_UserCreditsLog.Credits].ToString().Trim()); //积分
objge_UserCreditsLogEN.BadgeNum = objRow[conge_UserCreditsLog.BadgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_UserCreditsLog.BadgeNum].ToString().Trim()); //徽章数量
objge_UserCreditsLogEN.Passed = TransNullToBool(objRow[conge_UserCreditsLog.Passed].ToString().Trim()); //是否合格
objge_UserCreditsLogEN.IsSubmit = TransNullToBool(objRow[conge_UserCreditsLog.IsSubmit].ToString().Trim()); //是否提交
objge_UserCreditsLogEN.GetInstructions = objRow[conge_UserCreditsLog.GetInstructions] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GetInstructions].ToString().Trim(); //获取说明
objge_UserCreditsLogEN.GetDate = objRow[conge_UserCreditsLog.GetDate] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GetDate].ToString().Trim(); //获取日期
objge_UserCreditsLogEN.IdCurrEduCls = objRow[conge_UserCreditsLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserCreditsLogEN.CourseId = objRow[conge_UserCreditsLog.CourseId].ToString().Trim(); //课程Id
objge_UserCreditsLogEN.UpdDate = objRow[conge_UserCreditsLog.UpdDate] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UpdDate].ToString().Trim(); //修改日期
objge_UserCreditsLogEN.UpdUser = objRow[conge_UserCreditsLog.UpdUser] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UpdUser].ToString().Trim(); //修改人
objge_UserCreditsLogEN.Memo = objRow[conge_UserCreditsLog.Memo] == DBNull.Value ? null : objRow[conge_UserCreditsLog.Memo].ToString().Trim(); //备注
objge_UserCreditsLogEN.GameLevelId = objRow[conge_UserCreditsLog.GameLevelId] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GameLevelId].ToString().Trim(); //游戏关卡Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_UserCreditsLogDA: GetObjLst)", objException.Message));
}
objge_UserCreditsLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_UserCreditsLogEN);
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
public List<clsge_UserCreditsLogEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsge_UserCreditsLogDA:GetObjLstByTabName)", objException.Message));
}
List<clsge_UserCreditsLogEN> arrObjLst = new List<clsge_UserCreditsLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserCreditsLogEN objge_UserCreditsLogEN = new clsge_UserCreditsLogEN();
try
{
objge_UserCreditsLogEN.mId = TransNullToInt(objRow[conge_UserCreditsLog.mId].ToString().Trim()); //mId
objge_UserCreditsLogEN.UserId = objRow[conge_UserCreditsLog.UserId] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UserId].ToString().Trim(); //用户ID
objge_UserCreditsLogEN.ExamBatchNo = objRow[conge_UserCreditsLog.ExamBatchNo].ToString().Trim(); //学生批次号
objge_UserCreditsLogEN.Credits = objRow[conge_UserCreditsLog.Credits] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_UserCreditsLog.Credits].ToString().Trim()); //积分
objge_UserCreditsLogEN.BadgeNum = objRow[conge_UserCreditsLog.BadgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_UserCreditsLog.BadgeNum].ToString().Trim()); //徽章数量
objge_UserCreditsLogEN.Passed = TransNullToBool(objRow[conge_UserCreditsLog.Passed].ToString().Trim()); //是否合格
objge_UserCreditsLogEN.IsSubmit = TransNullToBool(objRow[conge_UserCreditsLog.IsSubmit].ToString().Trim()); //是否提交
objge_UserCreditsLogEN.GetInstructions = objRow[conge_UserCreditsLog.GetInstructions] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GetInstructions].ToString().Trim(); //获取说明
objge_UserCreditsLogEN.GetDate = objRow[conge_UserCreditsLog.GetDate] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GetDate].ToString().Trim(); //获取日期
objge_UserCreditsLogEN.IdCurrEduCls = objRow[conge_UserCreditsLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserCreditsLogEN.CourseId = objRow[conge_UserCreditsLog.CourseId].ToString().Trim(); //课程Id
objge_UserCreditsLogEN.UpdDate = objRow[conge_UserCreditsLog.UpdDate] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UpdDate].ToString().Trim(); //修改日期
objge_UserCreditsLogEN.UpdUser = objRow[conge_UserCreditsLog.UpdUser] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UpdUser].ToString().Trim(); //修改人
objge_UserCreditsLogEN.Memo = objRow[conge_UserCreditsLog.Memo] == DBNull.Value ? null : objRow[conge_UserCreditsLog.Memo].ToString().Trim(); //备注
objge_UserCreditsLogEN.GameLevelId = objRow[conge_UserCreditsLog.GameLevelId] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GameLevelId].ToString().Trim(); //游戏关卡Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_UserCreditsLogDA: GetObjLst)", objException.Message));
}
objge_UserCreditsLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_UserCreditsLogEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objge_UserCreditsLogEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getge_UserCreditsLog(ref clsge_UserCreditsLogEN objge_UserCreditsLogEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserCreditsLog where mId = " + ""+ objge_UserCreditsLogEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objge_UserCreditsLogEN.mId = TransNullToInt(objDT.Rows[0][conge_UserCreditsLog.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objge_UserCreditsLogEN.UserId = objDT.Rows[0][conge_UserCreditsLog.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objge_UserCreditsLogEN.ExamBatchNo = objDT.Rows[0][conge_UserCreditsLog.ExamBatchNo].ToString().Trim(); //学生批次号(字段类型:varchar,字段长度:20,是否可空:False)
 objge_UserCreditsLogEN.Credits = TransNullToInt(objDT.Rows[0][conge_UserCreditsLog.Credits].ToString().Trim()); //积分(字段类型:int,字段长度:4,是否可空:True)
 objge_UserCreditsLogEN.BadgeNum = TransNullToInt(objDT.Rows[0][conge_UserCreditsLog.BadgeNum].ToString().Trim()); //徽章数量(字段类型:int,字段长度:4,是否可空:True)
 objge_UserCreditsLogEN.Passed = TransNullToBool(objDT.Rows[0][conge_UserCreditsLog.Passed].ToString().Trim()); //是否合格(字段类型:bit,字段长度:1,是否可空:True)
 objge_UserCreditsLogEN.IsSubmit = TransNullToBool(objDT.Rows[0][conge_UserCreditsLog.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objge_UserCreditsLogEN.GetInstructions = objDT.Rows[0][conge_UserCreditsLog.GetInstructions].ToString().Trim(); //获取说明(字段类型:varchar,字段长度:100,是否可空:True)
 objge_UserCreditsLogEN.GetDate = objDT.Rows[0][conge_UserCreditsLog.GetDate].ToString().Trim(); //获取日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_UserCreditsLogEN.IdCurrEduCls = objDT.Rows[0][conge_UserCreditsLog.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objge_UserCreditsLogEN.CourseId = objDT.Rows[0][conge_UserCreditsLog.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_UserCreditsLogEN.UpdDate = objDT.Rows[0][conge_UserCreditsLog.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_UserCreditsLogEN.UpdUser = objDT.Rows[0][conge_UserCreditsLog.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_UserCreditsLogEN.Memo = objDT.Rows[0][conge_UserCreditsLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_UserCreditsLogEN.GameLevelId = objDT.Rows[0][conge_UserCreditsLog.GameLevelId].ToString().Trim(); //游戏关卡Id(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsge_UserCreditsLogDA: Getge_UserCreditsLog)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsge_UserCreditsLogEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserCreditsLog where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsge_UserCreditsLogEN objge_UserCreditsLogEN = new clsge_UserCreditsLogEN();
try
{
 objge_UserCreditsLogEN.mId = Int32.Parse(objRow[conge_UserCreditsLog.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objge_UserCreditsLogEN.UserId = objRow[conge_UserCreditsLog.UserId] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objge_UserCreditsLogEN.ExamBatchNo = objRow[conge_UserCreditsLog.ExamBatchNo].ToString().Trim(); //学生批次号(字段类型:varchar,字段长度:20,是否可空:False)
 objge_UserCreditsLogEN.Credits = objRow[conge_UserCreditsLog.Credits] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_UserCreditsLog.Credits].ToString().Trim()); //积分(字段类型:int,字段长度:4,是否可空:True)
 objge_UserCreditsLogEN.BadgeNum = objRow[conge_UserCreditsLog.BadgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_UserCreditsLog.BadgeNum].ToString().Trim()); //徽章数量(字段类型:int,字段长度:4,是否可空:True)
 objge_UserCreditsLogEN.Passed = clsEntityBase2.TransNullToBool_S(objRow[conge_UserCreditsLog.Passed].ToString().Trim()); //是否合格(字段类型:bit,字段长度:1,是否可空:True)
 objge_UserCreditsLogEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_UserCreditsLog.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objge_UserCreditsLogEN.GetInstructions = objRow[conge_UserCreditsLog.GetInstructions] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GetInstructions].ToString().Trim(); //获取说明(字段类型:varchar,字段长度:100,是否可空:True)
 objge_UserCreditsLogEN.GetDate = objRow[conge_UserCreditsLog.GetDate] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GetDate].ToString().Trim(); //获取日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_UserCreditsLogEN.IdCurrEduCls = objRow[conge_UserCreditsLog.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objge_UserCreditsLogEN.CourseId = objRow[conge_UserCreditsLog.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_UserCreditsLogEN.UpdDate = objRow[conge_UserCreditsLog.UpdDate] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_UserCreditsLogEN.UpdUser = objRow[conge_UserCreditsLog.UpdUser] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_UserCreditsLogEN.Memo = objRow[conge_UserCreditsLog.Memo] == DBNull.Value ? null : objRow[conge_UserCreditsLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_UserCreditsLogEN.GameLevelId = objRow[conge_UserCreditsLog.GameLevelId] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GameLevelId].ToString().Trim(); //游戏关卡Id(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsge_UserCreditsLogDA: GetObjBymId)", objException.Message));
}
return objge_UserCreditsLogEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsge_UserCreditsLogEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsge_UserCreditsLogDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserCreditsLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsge_UserCreditsLogEN objge_UserCreditsLogEN = new clsge_UserCreditsLogEN()
{
mId = TransNullToInt(objRow[conge_UserCreditsLog.mId].ToString().Trim()), //mId
UserId = objRow[conge_UserCreditsLog.UserId] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UserId].ToString().Trim(), //用户ID
ExamBatchNo = objRow[conge_UserCreditsLog.ExamBatchNo].ToString().Trim(), //学生批次号
Credits = objRow[conge_UserCreditsLog.Credits] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_UserCreditsLog.Credits].ToString().Trim()), //积分
BadgeNum = objRow[conge_UserCreditsLog.BadgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_UserCreditsLog.BadgeNum].ToString().Trim()), //徽章数量
Passed = TransNullToBool(objRow[conge_UserCreditsLog.Passed].ToString().Trim()), //是否合格
IsSubmit = TransNullToBool(objRow[conge_UserCreditsLog.IsSubmit].ToString().Trim()), //是否提交
GetInstructions = objRow[conge_UserCreditsLog.GetInstructions] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GetInstructions].ToString().Trim(), //获取说明
GetDate = objRow[conge_UserCreditsLog.GetDate] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GetDate].ToString().Trim(), //获取日期
IdCurrEduCls = objRow[conge_UserCreditsLog.IdCurrEduCls].ToString().Trim(), //教学班流水号
CourseId = objRow[conge_UserCreditsLog.CourseId].ToString().Trim(), //课程Id
UpdDate = objRow[conge_UserCreditsLog.UpdDate] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conge_UserCreditsLog.UpdUser] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conge_UserCreditsLog.Memo] == DBNull.Value ? null : objRow[conge_UserCreditsLog.Memo].ToString().Trim(), //备注
GameLevelId = objRow[conge_UserCreditsLog.GameLevelId] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GameLevelId].ToString().Trim() //游戏关卡Id
};
objge_UserCreditsLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_UserCreditsLogEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsge_UserCreditsLogDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsge_UserCreditsLogEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_UserCreditsLogEN objge_UserCreditsLogEN = new clsge_UserCreditsLogEN();
try
{
objge_UserCreditsLogEN.mId = TransNullToInt(objRow[conge_UserCreditsLog.mId].ToString().Trim()); //mId
objge_UserCreditsLogEN.UserId = objRow[conge_UserCreditsLog.UserId] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UserId].ToString().Trim(); //用户ID
objge_UserCreditsLogEN.ExamBatchNo = objRow[conge_UserCreditsLog.ExamBatchNo].ToString().Trim(); //学生批次号
objge_UserCreditsLogEN.Credits = objRow[conge_UserCreditsLog.Credits] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_UserCreditsLog.Credits].ToString().Trim()); //积分
objge_UserCreditsLogEN.BadgeNum = objRow[conge_UserCreditsLog.BadgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_UserCreditsLog.BadgeNum].ToString().Trim()); //徽章数量
objge_UserCreditsLogEN.Passed = TransNullToBool(objRow[conge_UserCreditsLog.Passed].ToString().Trim()); //是否合格
objge_UserCreditsLogEN.IsSubmit = TransNullToBool(objRow[conge_UserCreditsLog.IsSubmit].ToString().Trim()); //是否提交
objge_UserCreditsLogEN.GetInstructions = objRow[conge_UserCreditsLog.GetInstructions] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GetInstructions].ToString().Trim(); //获取说明
objge_UserCreditsLogEN.GetDate = objRow[conge_UserCreditsLog.GetDate] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GetDate].ToString().Trim(); //获取日期
objge_UserCreditsLogEN.IdCurrEduCls = objRow[conge_UserCreditsLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserCreditsLogEN.CourseId = objRow[conge_UserCreditsLog.CourseId].ToString().Trim(); //课程Id
objge_UserCreditsLogEN.UpdDate = objRow[conge_UserCreditsLog.UpdDate] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UpdDate].ToString().Trim(); //修改日期
objge_UserCreditsLogEN.UpdUser = objRow[conge_UserCreditsLog.UpdUser] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UpdUser].ToString().Trim(); //修改人
objge_UserCreditsLogEN.Memo = objRow[conge_UserCreditsLog.Memo] == DBNull.Value ? null : objRow[conge_UserCreditsLog.Memo].ToString().Trim(); //备注
objge_UserCreditsLogEN.GameLevelId = objRow[conge_UserCreditsLog.GameLevelId] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GameLevelId].ToString().Trim(); //游戏关卡Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsge_UserCreditsLogDA: GetObjByDataRowge_UserCreditsLog)", objException.Message));
}
objge_UserCreditsLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_UserCreditsLogEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsge_UserCreditsLogEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_UserCreditsLogEN objge_UserCreditsLogEN = new clsge_UserCreditsLogEN();
try
{
objge_UserCreditsLogEN.mId = TransNullToInt(objRow[conge_UserCreditsLog.mId].ToString().Trim()); //mId
objge_UserCreditsLogEN.UserId = objRow[conge_UserCreditsLog.UserId] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UserId].ToString().Trim(); //用户ID
objge_UserCreditsLogEN.ExamBatchNo = objRow[conge_UserCreditsLog.ExamBatchNo].ToString().Trim(); //学生批次号
objge_UserCreditsLogEN.Credits = objRow[conge_UserCreditsLog.Credits] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_UserCreditsLog.Credits].ToString().Trim()); //积分
objge_UserCreditsLogEN.BadgeNum = objRow[conge_UserCreditsLog.BadgeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_UserCreditsLog.BadgeNum].ToString().Trim()); //徽章数量
objge_UserCreditsLogEN.Passed = TransNullToBool(objRow[conge_UserCreditsLog.Passed].ToString().Trim()); //是否合格
objge_UserCreditsLogEN.IsSubmit = TransNullToBool(objRow[conge_UserCreditsLog.IsSubmit].ToString().Trim()); //是否提交
objge_UserCreditsLogEN.GetInstructions = objRow[conge_UserCreditsLog.GetInstructions] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GetInstructions].ToString().Trim(); //获取说明
objge_UserCreditsLogEN.GetDate = objRow[conge_UserCreditsLog.GetDate] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GetDate].ToString().Trim(); //获取日期
objge_UserCreditsLogEN.IdCurrEduCls = objRow[conge_UserCreditsLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserCreditsLogEN.CourseId = objRow[conge_UserCreditsLog.CourseId].ToString().Trim(); //课程Id
objge_UserCreditsLogEN.UpdDate = objRow[conge_UserCreditsLog.UpdDate] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UpdDate].ToString().Trim(); //修改日期
objge_UserCreditsLogEN.UpdUser = objRow[conge_UserCreditsLog.UpdUser] == DBNull.Value ? null : objRow[conge_UserCreditsLog.UpdUser].ToString().Trim(); //修改人
objge_UserCreditsLogEN.Memo = objRow[conge_UserCreditsLog.Memo] == DBNull.Value ? null : objRow[conge_UserCreditsLog.Memo].ToString().Trim(); //备注
objge_UserCreditsLogEN.GameLevelId = objRow[conge_UserCreditsLog.GameLevelId] == DBNull.Value ? null : objRow[conge_UserCreditsLog.GameLevelId].ToString().Trim(); //游戏关卡Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsge_UserCreditsLogDA: GetObjByDataRow)", objException.Message));
}
objge_UserCreditsLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_UserCreditsLogEN;
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
objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_UserCreditsLogEN._CurrTabName, conge_UserCreditsLog.mId, 8, "");
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
objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_UserCreditsLogEN._CurrTabName, conge_UserCreditsLog.mId, 8, strPrefix);
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
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from ge_UserCreditsLog where " + strCondition;
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
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from ge_UserCreditsLog where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_UserCreditsLog", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsge_UserCreditsLogDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_UserCreditsLog", strCondition))
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
objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ge_UserCreditsLog");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsge_UserCreditsLogEN objge_UserCreditsLogEN)
 {
 if (objge_UserCreditsLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_UserCreditsLogEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserCreditsLog where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_UserCreditsLog");
objRow = objDS.Tables["ge_UserCreditsLog"].NewRow();
 if (objge_UserCreditsLogEN.UserId !=  "")
 {
objRow[conge_UserCreditsLog.UserId] = objge_UserCreditsLogEN.UserId; //用户ID
 }
objRow[conge_UserCreditsLog.ExamBatchNo] = objge_UserCreditsLogEN.ExamBatchNo; //学生批次号
objRow[conge_UserCreditsLog.Credits] = objge_UserCreditsLogEN.Credits; //积分
objRow[conge_UserCreditsLog.BadgeNum] = objge_UserCreditsLogEN.BadgeNum; //徽章数量
objRow[conge_UserCreditsLog.Passed] = objge_UserCreditsLogEN.Passed; //是否合格
objRow[conge_UserCreditsLog.IsSubmit] = objge_UserCreditsLogEN.IsSubmit; //是否提交
 if (objge_UserCreditsLogEN.GetInstructions !=  "")
 {
objRow[conge_UserCreditsLog.GetInstructions] = objge_UserCreditsLogEN.GetInstructions; //获取说明
 }
 if (objge_UserCreditsLogEN.GetDate !=  "")
 {
objRow[conge_UserCreditsLog.GetDate] = objge_UserCreditsLogEN.GetDate; //获取日期
 }
objRow[conge_UserCreditsLog.IdCurrEduCls] = objge_UserCreditsLogEN.IdCurrEduCls; //教学班流水号
objRow[conge_UserCreditsLog.CourseId] = objge_UserCreditsLogEN.CourseId; //课程Id
 if (objge_UserCreditsLogEN.UpdDate !=  "")
 {
objRow[conge_UserCreditsLog.UpdDate] = objge_UserCreditsLogEN.UpdDate; //修改日期
 }
 if (objge_UserCreditsLogEN.UpdUser !=  "")
 {
objRow[conge_UserCreditsLog.UpdUser] = objge_UserCreditsLogEN.UpdUser; //修改人
 }
 if (objge_UserCreditsLogEN.Memo !=  "")
 {
objRow[conge_UserCreditsLog.Memo] = objge_UserCreditsLogEN.Memo; //备注
 }
 if (objge_UserCreditsLogEN.GameLevelId !=  "")
 {
objRow[conge_UserCreditsLog.GameLevelId] = objge_UserCreditsLogEN.GameLevelId; //游戏关卡Id
 }
objDS.Tables[clsge_UserCreditsLogEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsge_UserCreditsLogEN._CurrTabName);
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
 /// <param name = "objge_UserCreditsLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_UserCreditsLogEN objge_UserCreditsLogEN)
{
 if (objge_UserCreditsLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_UserCreditsLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objge_UserCreditsLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.UserId);
 var strUserId = objge_UserCreditsLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objge_UserCreditsLogEN.ExamBatchNo !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.ExamBatchNo);
 var strExamBatchNo = objge_UserCreditsLogEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamBatchNo + "'");
 }
 
 if (objge_UserCreditsLogEN.Credits !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.Credits);
 arrValueListForInsert.Add(objge_UserCreditsLogEN.Credits.ToString());
 }
 
 if (objge_UserCreditsLogEN.BadgeNum !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.BadgeNum);
 arrValueListForInsert.Add(objge_UserCreditsLogEN.BadgeNum.ToString());
 }
 
 arrFieldListForInsert.Add(conge_UserCreditsLog.Passed);
 arrValueListForInsert.Add("'" + (objge_UserCreditsLogEN.Passed  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_UserCreditsLog.IsSubmit);
 arrValueListForInsert.Add("'" + (objge_UserCreditsLogEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objge_UserCreditsLogEN.GetInstructions !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.GetInstructions);
 var strGetInstructions = objge_UserCreditsLogEN.GetInstructions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetInstructions + "'");
 }
 
 if (objge_UserCreditsLogEN.GetDate !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.GetDate);
 var strGetDate = objge_UserCreditsLogEN.GetDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetDate + "'");
 }
 
 if (objge_UserCreditsLogEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.IdCurrEduCls);
 var strIdCurrEduCls = objge_UserCreditsLogEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_UserCreditsLogEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.CourseId);
 var strCourseId = objge_UserCreditsLogEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_UserCreditsLogEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.UpdDate);
 var strUpdDate = objge_UserCreditsLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_UserCreditsLogEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.UpdUser);
 var strUpdUser = objge_UserCreditsLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_UserCreditsLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.Memo);
 var strMemo = objge_UserCreditsLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_UserCreditsLogEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.GameLevelId);
 var strGameLevelId = objge_UserCreditsLogEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_UserCreditsLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objge_UserCreditsLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_UserCreditsLogEN objge_UserCreditsLogEN)
{
 if (objge_UserCreditsLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_UserCreditsLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objge_UserCreditsLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.UserId);
 var strUserId = objge_UserCreditsLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objge_UserCreditsLogEN.ExamBatchNo !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.ExamBatchNo);
 var strExamBatchNo = objge_UserCreditsLogEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamBatchNo + "'");
 }
 
 if (objge_UserCreditsLogEN.Credits !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.Credits);
 arrValueListForInsert.Add(objge_UserCreditsLogEN.Credits.ToString());
 }
 
 if (objge_UserCreditsLogEN.BadgeNum !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.BadgeNum);
 arrValueListForInsert.Add(objge_UserCreditsLogEN.BadgeNum.ToString());
 }
 
 arrFieldListForInsert.Add(conge_UserCreditsLog.Passed);
 arrValueListForInsert.Add("'" + (objge_UserCreditsLogEN.Passed  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_UserCreditsLog.IsSubmit);
 arrValueListForInsert.Add("'" + (objge_UserCreditsLogEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objge_UserCreditsLogEN.GetInstructions !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.GetInstructions);
 var strGetInstructions = objge_UserCreditsLogEN.GetInstructions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetInstructions + "'");
 }
 
 if (objge_UserCreditsLogEN.GetDate !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.GetDate);
 var strGetDate = objge_UserCreditsLogEN.GetDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetDate + "'");
 }
 
 if (objge_UserCreditsLogEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.IdCurrEduCls);
 var strIdCurrEduCls = objge_UserCreditsLogEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_UserCreditsLogEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.CourseId);
 var strCourseId = objge_UserCreditsLogEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_UserCreditsLogEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.UpdDate);
 var strUpdDate = objge_UserCreditsLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_UserCreditsLogEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.UpdUser);
 var strUpdUser = objge_UserCreditsLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_UserCreditsLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.Memo);
 var strMemo = objge_UserCreditsLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_UserCreditsLogEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.GameLevelId);
 var strGameLevelId = objge_UserCreditsLogEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_UserCreditsLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objge_UserCreditsLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_UserCreditsLogEN objge_UserCreditsLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_UserCreditsLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_UserCreditsLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objge_UserCreditsLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.UserId);
 var strUserId = objge_UserCreditsLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objge_UserCreditsLogEN.ExamBatchNo !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.ExamBatchNo);
 var strExamBatchNo = objge_UserCreditsLogEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamBatchNo + "'");
 }
 
 if (objge_UserCreditsLogEN.Credits !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.Credits);
 arrValueListForInsert.Add(objge_UserCreditsLogEN.Credits.ToString());
 }
 
 if (objge_UserCreditsLogEN.BadgeNum !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.BadgeNum);
 arrValueListForInsert.Add(objge_UserCreditsLogEN.BadgeNum.ToString());
 }
 
 arrFieldListForInsert.Add(conge_UserCreditsLog.Passed);
 arrValueListForInsert.Add("'" + (objge_UserCreditsLogEN.Passed  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_UserCreditsLog.IsSubmit);
 arrValueListForInsert.Add("'" + (objge_UserCreditsLogEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objge_UserCreditsLogEN.GetInstructions !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.GetInstructions);
 var strGetInstructions = objge_UserCreditsLogEN.GetInstructions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetInstructions + "'");
 }
 
 if (objge_UserCreditsLogEN.GetDate !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.GetDate);
 var strGetDate = objge_UserCreditsLogEN.GetDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetDate + "'");
 }
 
 if (objge_UserCreditsLogEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.IdCurrEduCls);
 var strIdCurrEduCls = objge_UserCreditsLogEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_UserCreditsLogEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.CourseId);
 var strCourseId = objge_UserCreditsLogEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_UserCreditsLogEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.UpdDate);
 var strUpdDate = objge_UserCreditsLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_UserCreditsLogEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.UpdUser);
 var strUpdUser = objge_UserCreditsLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_UserCreditsLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.Memo);
 var strMemo = objge_UserCreditsLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_UserCreditsLogEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.GameLevelId);
 var strGameLevelId = objge_UserCreditsLogEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_UserCreditsLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objge_UserCreditsLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_UserCreditsLogEN objge_UserCreditsLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objge_UserCreditsLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_UserCreditsLogEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objge_UserCreditsLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.UserId);
 var strUserId = objge_UserCreditsLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objge_UserCreditsLogEN.ExamBatchNo !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.ExamBatchNo);
 var strExamBatchNo = objge_UserCreditsLogEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamBatchNo + "'");
 }
 
 if (objge_UserCreditsLogEN.Credits !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.Credits);
 arrValueListForInsert.Add(objge_UserCreditsLogEN.Credits.ToString());
 }
 
 if (objge_UserCreditsLogEN.BadgeNum !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.BadgeNum);
 arrValueListForInsert.Add(objge_UserCreditsLogEN.BadgeNum.ToString());
 }
 
 arrFieldListForInsert.Add(conge_UserCreditsLog.Passed);
 arrValueListForInsert.Add("'" + (objge_UserCreditsLogEN.Passed  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_UserCreditsLog.IsSubmit);
 arrValueListForInsert.Add("'" + (objge_UserCreditsLogEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objge_UserCreditsLogEN.GetInstructions !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.GetInstructions);
 var strGetInstructions = objge_UserCreditsLogEN.GetInstructions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetInstructions + "'");
 }
 
 if (objge_UserCreditsLogEN.GetDate !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.GetDate);
 var strGetDate = objge_UserCreditsLogEN.GetDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetDate + "'");
 }
 
 if (objge_UserCreditsLogEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.IdCurrEduCls);
 var strIdCurrEduCls = objge_UserCreditsLogEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_UserCreditsLogEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.CourseId);
 var strCourseId = objge_UserCreditsLogEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_UserCreditsLogEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.UpdDate);
 var strUpdDate = objge_UserCreditsLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_UserCreditsLogEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.UpdUser);
 var strUpdUser = objge_UserCreditsLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_UserCreditsLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.Memo);
 var strMemo = objge_UserCreditsLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_UserCreditsLogEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_UserCreditsLog.GameLevelId);
 var strGameLevelId = objge_UserCreditsLogEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_UserCreditsLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewge_UserCreditsLogs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserCreditsLog where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_UserCreditsLog");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsge_UserCreditsLogEN._CurrTabName ].NewRow();
objRow[conge_UserCreditsLog.UserId] = oRow[conge_UserCreditsLog.UserId].ToString().Trim(); //用户ID
objRow[conge_UserCreditsLog.ExamBatchNo] = oRow[conge_UserCreditsLog.ExamBatchNo].ToString().Trim(); //学生批次号
objRow[conge_UserCreditsLog.Credits] = oRow[conge_UserCreditsLog.Credits].ToString().Trim(); //积分
objRow[conge_UserCreditsLog.BadgeNum] = oRow[conge_UserCreditsLog.BadgeNum].ToString().Trim(); //徽章数量
objRow[conge_UserCreditsLog.Passed] = oRow[conge_UserCreditsLog.Passed].ToString().Trim(); //是否合格
objRow[conge_UserCreditsLog.IsSubmit] = oRow[conge_UserCreditsLog.IsSubmit].ToString().Trim(); //是否提交
objRow[conge_UserCreditsLog.GetInstructions] = oRow[conge_UserCreditsLog.GetInstructions].ToString().Trim(); //获取说明
objRow[conge_UserCreditsLog.GetDate] = oRow[conge_UserCreditsLog.GetDate].ToString().Trim(); //获取日期
objRow[conge_UserCreditsLog.IdCurrEduCls] = oRow[conge_UserCreditsLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conge_UserCreditsLog.CourseId] = oRow[conge_UserCreditsLog.CourseId].ToString().Trim(); //课程Id
objRow[conge_UserCreditsLog.UpdDate] = oRow[conge_UserCreditsLog.UpdDate].ToString().Trim(); //修改日期
objRow[conge_UserCreditsLog.UpdUser] = oRow[conge_UserCreditsLog.UpdUser].ToString().Trim(); //修改人
objRow[conge_UserCreditsLog.Memo] = oRow[conge_UserCreditsLog.Memo].ToString().Trim(); //备注
objRow[conge_UserCreditsLog.GameLevelId] = oRow[conge_UserCreditsLog.GameLevelId].ToString().Trim(); //游戏关卡Id
 objDS.Tables[clsge_UserCreditsLogEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsge_UserCreditsLogEN._CurrTabName);
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
 /// <param name = "objge_UserCreditsLogEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsge_UserCreditsLogEN objge_UserCreditsLogEN)
{
 if (objge_UserCreditsLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_UserCreditsLogEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
strSQL = "Select * from ge_UserCreditsLog where mId = " + ""+ objge_UserCreditsLogEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsge_UserCreditsLogEN._CurrTabName);
if (objDS.Tables[clsge_UserCreditsLogEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objge_UserCreditsLogEN.mId+"");
return false;
}
objRow = objDS.Tables[clsge_UserCreditsLogEN._CurrTabName].Rows[0];
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.UserId))
 {
objRow[conge_UserCreditsLog.UserId] = objge_UserCreditsLogEN.UserId; //用户ID
 }
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.ExamBatchNo))
 {
objRow[conge_UserCreditsLog.ExamBatchNo] = objge_UserCreditsLogEN.ExamBatchNo; //学生批次号
 }
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.Credits))
 {
objRow[conge_UserCreditsLog.Credits] = objge_UserCreditsLogEN.Credits; //积分
 }
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.BadgeNum))
 {
objRow[conge_UserCreditsLog.BadgeNum] = objge_UserCreditsLogEN.BadgeNum; //徽章数量
 }
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.Passed))
 {
objRow[conge_UserCreditsLog.Passed] = objge_UserCreditsLogEN.Passed; //是否合格
 }
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.IsSubmit))
 {
objRow[conge_UserCreditsLog.IsSubmit] = objge_UserCreditsLogEN.IsSubmit; //是否提交
 }
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.GetInstructions))
 {
objRow[conge_UserCreditsLog.GetInstructions] = objge_UserCreditsLogEN.GetInstructions; //获取说明
 }
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.GetDate))
 {
objRow[conge_UserCreditsLog.GetDate] = objge_UserCreditsLogEN.GetDate; //获取日期
 }
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.IdCurrEduCls))
 {
objRow[conge_UserCreditsLog.IdCurrEduCls] = objge_UserCreditsLogEN.IdCurrEduCls; //教学班流水号
 }
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.CourseId))
 {
objRow[conge_UserCreditsLog.CourseId] = objge_UserCreditsLogEN.CourseId; //课程Id
 }
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.UpdDate))
 {
objRow[conge_UserCreditsLog.UpdDate] = objge_UserCreditsLogEN.UpdDate; //修改日期
 }
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.UpdUser))
 {
objRow[conge_UserCreditsLog.UpdUser] = objge_UserCreditsLogEN.UpdUser; //修改人
 }
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.Memo))
 {
objRow[conge_UserCreditsLog.Memo] = objge_UserCreditsLogEN.Memo; //备注
 }
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.GameLevelId))
 {
objRow[conge_UserCreditsLog.GameLevelId] = objge_UserCreditsLogEN.GameLevelId; //游戏关卡Id
 }
try
{
objDA.Update(objDS, clsge_UserCreditsLogEN._CurrTabName);
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
 /// <param name = "objge_UserCreditsLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_UserCreditsLogEN objge_UserCreditsLogEN)
{
 if (objge_UserCreditsLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_UserCreditsLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ge_UserCreditsLog Set ");
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.UserId))
 {
 if (objge_UserCreditsLogEN.UserId !=  null)
 {
 var strUserId = objge_UserCreditsLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conge_UserCreditsLog.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.UserId); //用户ID
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.ExamBatchNo))
 {
 if (objge_UserCreditsLogEN.ExamBatchNo !=  null)
 {
 var strExamBatchNo = objge_UserCreditsLogEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamBatchNo, conge_UserCreditsLog.ExamBatchNo); //学生批次号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.ExamBatchNo); //学生批次号
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.Credits))
 {
 if (objge_UserCreditsLogEN.Credits !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_UserCreditsLogEN.Credits, conge_UserCreditsLog.Credits); //积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.Credits); //积分
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.BadgeNum))
 {
 if (objge_UserCreditsLogEN.BadgeNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_UserCreditsLogEN.BadgeNum, conge_UserCreditsLog.BadgeNum); //徽章数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.BadgeNum); //徽章数量
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.Passed))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_UserCreditsLogEN.Passed == true?"1":"0", conge_UserCreditsLog.Passed); //是否合格
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_UserCreditsLogEN.IsSubmit == true?"1":"0", conge_UserCreditsLog.IsSubmit); //是否提交
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.GetInstructions))
 {
 if (objge_UserCreditsLogEN.GetInstructions !=  null)
 {
 var strGetInstructions = objge_UserCreditsLogEN.GetInstructions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetInstructions, conge_UserCreditsLog.GetInstructions); //获取说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.GetInstructions); //获取说明
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.GetDate))
 {
 if (objge_UserCreditsLogEN.GetDate !=  null)
 {
 var strGetDate = objge_UserCreditsLogEN.GetDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetDate, conge_UserCreditsLog.GetDate); //获取日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.GetDate); //获取日期
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.IdCurrEduCls))
 {
 if (objge_UserCreditsLogEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objge_UserCreditsLogEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conge_UserCreditsLog.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.CourseId))
 {
 if (objge_UserCreditsLogEN.CourseId !=  null)
 {
 var strCourseId = objge_UserCreditsLogEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_UserCreditsLog.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.CourseId); //课程Id
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.UpdDate))
 {
 if (objge_UserCreditsLogEN.UpdDate !=  null)
 {
 var strUpdDate = objge_UserCreditsLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_UserCreditsLog.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.UpdDate); //修改日期
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.UpdUser))
 {
 if (objge_UserCreditsLogEN.UpdUser !=  null)
 {
 var strUpdUser = objge_UserCreditsLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_UserCreditsLog.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.UpdUser); //修改人
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.Memo))
 {
 if (objge_UserCreditsLogEN.Memo !=  null)
 {
 var strMemo = objge_UserCreditsLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_UserCreditsLog.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.Memo); //备注
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.GameLevelId))
 {
 if (objge_UserCreditsLogEN.GameLevelId !=  null)
 {
 var strGameLevelId = objge_UserCreditsLogEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGameLevelId, conge_UserCreditsLog.GameLevelId); //游戏关卡Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.GameLevelId); //游戏关卡Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objge_UserCreditsLogEN.mId); 
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
 /// <param name = "objge_UserCreditsLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsge_UserCreditsLogEN objge_UserCreditsLogEN, string strCondition)
{
 if (objge_UserCreditsLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_UserCreditsLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_UserCreditsLog Set ");
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.UserId))
 {
 if (objge_UserCreditsLogEN.UserId !=  null)
 {
 var strUserId = objge_UserCreditsLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.ExamBatchNo))
 {
 if (objge_UserCreditsLogEN.ExamBatchNo !=  null)
 {
 var strExamBatchNo = objge_UserCreditsLogEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamBatchNo = '{0}',", strExamBatchNo); //学生批次号
 }
 else
 {
 sbSQL.Append(" ExamBatchNo = null,"); //学生批次号
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.Credits))
 {
 if (objge_UserCreditsLogEN.Credits !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_UserCreditsLogEN.Credits, conge_UserCreditsLog.Credits); //积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.Credits); //积分
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.BadgeNum))
 {
 if (objge_UserCreditsLogEN.BadgeNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_UserCreditsLogEN.BadgeNum, conge_UserCreditsLog.BadgeNum); //徽章数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.BadgeNum); //徽章数量
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.Passed))
 {
 sbSQL.AppendFormat(" Passed = '{0}',", objge_UserCreditsLogEN.Passed == true?"1":"0"); //是否合格
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objge_UserCreditsLogEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.GetInstructions))
 {
 if (objge_UserCreditsLogEN.GetInstructions !=  null)
 {
 var strGetInstructions = objge_UserCreditsLogEN.GetInstructions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetInstructions = '{0}',", strGetInstructions); //获取说明
 }
 else
 {
 sbSQL.Append(" GetInstructions = null,"); //获取说明
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.GetDate))
 {
 if (objge_UserCreditsLogEN.GetDate !=  null)
 {
 var strGetDate = objge_UserCreditsLogEN.GetDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetDate = '{0}',", strGetDate); //获取日期
 }
 else
 {
 sbSQL.Append(" GetDate = null,"); //获取日期
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.IdCurrEduCls))
 {
 if (objge_UserCreditsLogEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objge_UserCreditsLogEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.CourseId))
 {
 if (objge_UserCreditsLogEN.CourseId !=  null)
 {
 var strCourseId = objge_UserCreditsLogEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.UpdDate))
 {
 if (objge_UserCreditsLogEN.UpdDate !=  null)
 {
 var strUpdDate = objge_UserCreditsLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.UpdUser))
 {
 if (objge_UserCreditsLogEN.UpdUser !=  null)
 {
 var strUpdUser = objge_UserCreditsLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.Memo))
 {
 if (objge_UserCreditsLogEN.Memo !=  null)
 {
 var strMemo = objge_UserCreditsLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.GameLevelId))
 {
 if (objge_UserCreditsLogEN.GameLevelId !=  null)
 {
 var strGameLevelId = objge_UserCreditsLogEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GameLevelId = '{0}',", strGameLevelId); //游戏关卡Id
 }
 else
 {
 sbSQL.Append(" GameLevelId = null,"); //游戏关卡Id
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
 /// <param name = "objge_UserCreditsLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsge_UserCreditsLogEN objge_UserCreditsLogEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_UserCreditsLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_UserCreditsLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_UserCreditsLog Set ");
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.UserId))
 {
 if (objge_UserCreditsLogEN.UserId !=  null)
 {
 var strUserId = objge_UserCreditsLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.ExamBatchNo))
 {
 if (objge_UserCreditsLogEN.ExamBatchNo !=  null)
 {
 var strExamBatchNo = objge_UserCreditsLogEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamBatchNo = '{0}',", strExamBatchNo); //学生批次号
 }
 else
 {
 sbSQL.Append(" ExamBatchNo = null,"); //学生批次号
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.Credits))
 {
 if (objge_UserCreditsLogEN.Credits !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_UserCreditsLogEN.Credits, conge_UserCreditsLog.Credits); //积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.Credits); //积分
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.BadgeNum))
 {
 if (objge_UserCreditsLogEN.BadgeNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_UserCreditsLogEN.BadgeNum, conge_UserCreditsLog.BadgeNum); //徽章数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.BadgeNum); //徽章数量
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.Passed))
 {
 sbSQL.AppendFormat(" Passed = '{0}',", objge_UserCreditsLogEN.Passed == true?"1":"0"); //是否合格
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objge_UserCreditsLogEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.GetInstructions))
 {
 if (objge_UserCreditsLogEN.GetInstructions !=  null)
 {
 var strGetInstructions = objge_UserCreditsLogEN.GetInstructions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetInstructions = '{0}',", strGetInstructions); //获取说明
 }
 else
 {
 sbSQL.Append(" GetInstructions = null,"); //获取说明
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.GetDate))
 {
 if (objge_UserCreditsLogEN.GetDate !=  null)
 {
 var strGetDate = objge_UserCreditsLogEN.GetDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetDate = '{0}',", strGetDate); //获取日期
 }
 else
 {
 sbSQL.Append(" GetDate = null,"); //获取日期
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.IdCurrEduCls))
 {
 if (objge_UserCreditsLogEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objge_UserCreditsLogEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.CourseId))
 {
 if (objge_UserCreditsLogEN.CourseId !=  null)
 {
 var strCourseId = objge_UserCreditsLogEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.UpdDate))
 {
 if (objge_UserCreditsLogEN.UpdDate !=  null)
 {
 var strUpdDate = objge_UserCreditsLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.UpdUser))
 {
 if (objge_UserCreditsLogEN.UpdUser !=  null)
 {
 var strUpdUser = objge_UserCreditsLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.Memo))
 {
 if (objge_UserCreditsLogEN.Memo !=  null)
 {
 var strMemo = objge_UserCreditsLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.GameLevelId))
 {
 if (objge_UserCreditsLogEN.GameLevelId !=  null)
 {
 var strGameLevelId = objge_UserCreditsLogEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GameLevelId = '{0}',", strGameLevelId); //游戏关卡Id
 }
 else
 {
 sbSQL.Append(" GameLevelId = null,"); //游戏关卡Id
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
 /// <param name = "objge_UserCreditsLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_UserCreditsLogEN objge_UserCreditsLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objge_UserCreditsLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_UserCreditsLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_UserCreditsLog Set ");
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.UserId))
 {
 if (objge_UserCreditsLogEN.UserId !=  null)
 {
 var strUserId = objge_UserCreditsLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conge_UserCreditsLog.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.UserId); //用户ID
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.ExamBatchNo))
 {
 if (objge_UserCreditsLogEN.ExamBatchNo !=  null)
 {
 var strExamBatchNo = objge_UserCreditsLogEN.ExamBatchNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamBatchNo, conge_UserCreditsLog.ExamBatchNo); //学生批次号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.ExamBatchNo); //学生批次号
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.Credits))
 {
 if (objge_UserCreditsLogEN.Credits !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_UserCreditsLogEN.Credits, conge_UserCreditsLog.Credits); //积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.Credits); //积分
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.BadgeNum))
 {
 if (objge_UserCreditsLogEN.BadgeNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_UserCreditsLogEN.BadgeNum, conge_UserCreditsLog.BadgeNum); //徽章数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.BadgeNum); //徽章数量
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.Passed))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_UserCreditsLogEN.Passed == true?"1":"0", conge_UserCreditsLog.Passed); //是否合格
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_UserCreditsLogEN.IsSubmit == true?"1":"0", conge_UserCreditsLog.IsSubmit); //是否提交
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.GetInstructions))
 {
 if (objge_UserCreditsLogEN.GetInstructions !=  null)
 {
 var strGetInstructions = objge_UserCreditsLogEN.GetInstructions.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetInstructions, conge_UserCreditsLog.GetInstructions); //获取说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.GetInstructions); //获取说明
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.GetDate))
 {
 if (objge_UserCreditsLogEN.GetDate !=  null)
 {
 var strGetDate = objge_UserCreditsLogEN.GetDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetDate, conge_UserCreditsLog.GetDate); //获取日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.GetDate); //获取日期
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.IdCurrEduCls))
 {
 if (objge_UserCreditsLogEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objge_UserCreditsLogEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conge_UserCreditsLog.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.CourseId))
 {
 if (objge_UserCreditsLogEN.CourseId !=  null)
 {
 var strCourseId = objge_UserCreditsLogEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_UserCreditsLog.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.CourseId); //课程Id
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.UpdDate))
 {
 if (objge_UserCreditsLogEN.UpdDate !=  null)
 {
 var strUpdDate = objge_UserCreditsLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_UserCreditsLog.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.UpdDate); //修改日期
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.UpdUser))
 {
 if (objge_UserCreditsLogEN.UpdUser !=  null)
 {
 var strUpdUser = objge_UserCreditsLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_UserCreditsLog.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.UpdUser); //修改人
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.Memo))
 {
 if (objge_UserCreditsLogEN.Memo !=  null)
 {
 var strMemo = objge_UserCreditsLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_UserCreditsLog.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.Memo); //备注
 }
 }
 
 if (objge_UserCreditsLogEN.IsUpdated(conge_UserCreditsLog.GameLevelId))
 {
 if (objge_UserCreditsLogEN.GameLevelId !=  null)
 {
 var strGameLevelId = objge_UserCreditsLogEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGameLevelId, conge_UserCreditsLog.GameLevelId); //游戏关卡Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_UserCreditsLog.GameLevelId); //游戏关卡Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objge_UserCreditsLogEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("ge_UserCreditsLog_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
//删除ge_UserCreditsLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_UserCreditsLog where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delge_UserCreditsLog(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
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
//删除ge_UserCreditsLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_UserCreditsLog where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
//删除ge_UserCreditsLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_UserCreditsLog where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delge_UserCreditsLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsge_UserCreditsLogDA: Delge_UserCreditsLog)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_UserCreditsLog where " + strCondition ;
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
public bool Delge_UserCreditsLogWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsge_UserCreditsLogDA: Delge_UserCreditsLogWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_UserCreditsLog where " + strCondition ;
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
 /// <param name = "objge_UserCreditsLogENS">源对象</param>
 /// <param name = "objge_UserCreditsLogENT">目标对象</param>
public void CopyTo(clsge_UserCreditsLogEN objge_UserCreditsLogENS, clsge_UserCreditsLogEN objge_UserCreditsLogENT)
{
objge_UserCreditsLogENT.mId = objge_UserCreditsLogENS.mId; //mId
objge_UserCreditsLogENT.UserId = objge_UserCreditsLogENS.UserId; //用户ID
objge_UserCreditsLogENT.ExamBatchNo = objge_UserCreditsLogENS.ExamBatchNo; //学生批次号
objge_UserCreditsLogENT.Credits = objge_UserCreditsLogENS.Credits; //积分
objge_UserCreditsLogENT.BadgeNum = objge_UserCreditsLogENS.BadgeNum; //徽章数量
objge_UserCreditsLogENT.Passed = objge_UserCreditsLogENS.Passed; //是否合格
objge_UserCreditsLogENT.IsSubmit = objge_UserCreditsLogENS.IsSubmit; //是否提交
objge_UserCreditsLogENT.GetInstructions = objge_UserCreditsLogENS.GetInstructions; //获取说明
objge_UserCreditsLogENT.GetDate = objge_UserCreditsLogENS.GetDate; //获取日期
objge_UserCreditsLogENT.IdCurrEduCls = objge_UserCreditsLogENS.IdCurrEduCls; //教学班流水号
objge_UserCreditsLogENT.CourseId = objge_UserCreditsLogENS.CourseId; //课程Id
objge_UserCreditsLogENT.UpdDate = objge_UserCreditsLogENS.UpdDate; //修改日期
objge_UserCreditsLogENT.UpdUser = objge_UserCreditsLogENS.UpdUser; //修改人
objge_UserCreditsLogENT.Memo = objge_UserCreditsLogENS.Memo; //备注
objge_UserCreditsLogENT.GameLevelId = objge_UserCreditsLogENS.GameLevelId; //游戏关卡Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsge_UserCreditsLogEN objge_UserCreditsLogEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objge_UserCreditsLogEN.ExamBatchNo, conge_UserCreditsLog.ExamBatchNo);
clsCheckSql.CheckFieldNotNull(objge_UserCreditsLogEN.IsSubmit, conge_UserCreditsLog.IsSubmit);
clsCheckSql.CheckFieldNotNull(objge_UserCreditsLogEN.IdCurrEduCls, conge_UserCreditsLog.IdCurrEduCls);
clsCheckSql.CheckFieldNotNull(objge_UserCreditsLogEN.CourseId, conge_UserCreditsLog.CourseId);
//检查字段长度
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.UserId, 18, conge_UserCreditsLog.UserId);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.ExamBatchNo, 20, conge_UserCreditsLog.ExamBatchNo);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.GetInstructions, 100, conge_UserCreditsLog.GetInstructions);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.GetDate, 20, conge_UserCreditsLog.GetDate);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.IdCurrEduCls, 8, conge_UserCreditsLog.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.CourseId, 8, conge_UserCreditsLog.CourseId);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.UpdDate, 20, conge_UserCreditsLog.UpdDate);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.UpdUser, 20, conge_UserCreditsLog.UpdUser);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.Memo, 1000, conge_UserCreditsLog.Memo);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.GameLevelId, 8, conge_UserCreditsLog.GameLevelId);
//检查字段外键固定长度
 objge_UserCreditsLogEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsge_UserCreditsLogEN objge_UserCreditsLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.UserId, 18, conge_UserCreditsLog.UserId);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.ExamBatchNo, 20, conge_UserCreditsLog.ExamBatchNo);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.GetInstructions, 100, conge_UserCreditsLog.GetInstructions);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.GetDate, 20, conge_UserCreditsLog.GetDate);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.IdCurrEduCls, 8, conge_UserCreditsLog.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.CourseId, 8, conge_UserCreditsLog.CourseId);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.UpdDate, 20, conge_UserCreditsLog.UpdDate);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.UpdUser, 20, conge_UserCreditsLog.UpdUser);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.Memo, 1000, conge_UserCreditsLog.Memo);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.GameLevelId, 8, conge_UserCreditsLog.GameLevelId);
//检查外键字段长度
 objge_UserCreditsLogEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsge_UserCreditsLogEN objge_UserCreditsLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.UserId, 18, conge_UserCreditsLog.UserId);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.ExamBatchNo, 20, conge_UserCreditsLog.ExamBatchNo);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.GetInstructions, 100, conge_UserCreditsLog.GetInstructions);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.GetDate, 20, conge_UserCreditsLog.GetDate);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.IdCurrEduCls, 8, conge_UserCreditsLog.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.CourseId, 8, conge_UserCreditsLog.CourseId);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.UpdDate, 20, conge_UserCreditsLog.UpdDate);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.UpdUser, 20, conge_UserCreditsLog.UpdUser);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.Memo, 1000, conge_UserCreditsLog.Memo);
clsCheckSql.CheckFieldLen(objge_UserCreditsLogEN.GameLevelId, 8, conge_UserCreditsLog.GameLevelId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objge_UserCreditsLogEN.UserId, conge_UserCreditsLog.UserId);
clsCheckSql.CheckSqlInjection4Field(objge_UserCreditsLogEN.ExamBatchNo, conge_UserCreditsLog.ExamBatchNo);
clsCheckSql.CheckSqlInjection4Field(objge_UserCreditsLogEN.GetInstructions, conge_UserCreditsLog.GetInstructions);
clsCheckSql.CheckSqlInjection4Field(objge_UserCreditsLogEN.GetDate, conge_UserCreditsLog.GetDate);
clsCheckSql.CheckSqlInjection4Field(objge_UserCreditsLogEN.IdCurrEduCls, conge_UserCreditsLog.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objge_UserCreditsLogEN.CourseId, conge_UserCreditsLog.CourseId);
clsCheckSql.CheckSqlInjection4Field(objge_UserCreditsLogEN.UpdDate, conge_UserCreditsLog.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objge_UserCreditsLogEN.UpdUser, conge_UserCreditsLog.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objge_UserCreditsLogEN.Memo, conge_UserCreditsLog.Memo);
clsCheckSql.CheckSqlInjection4Field(objge_UserCreditsLogEN.GameLevelId, conge_UserCreditsLog.GameLevelId);
//检查外键字段长度
 objge_UserCreditsLogEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ge_UserCreditsLog(用户积分日志),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_UserCreditsLogEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsge_UserCreditsLogEN objge_UserCreditsLogEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objge_UserCreditsLogEN.GameLevelId == null)
{
 sbCondition.AppendFormat(" and GameLevelId is null");
}
else
{
 sbCondition.AppendFormat(" and GameLevelId = '{0}'", objge_UserCreditsLogEN.GameLevelId);
}
 sbCondition.AppendFormat(" and ExamBatchNo = '{0}'", objge_UserCreditsLogEN.ExamBatchNo);
 if (objge_UserCreditsLogEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null");
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objge_UserCreditsLogEN.UserId);
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
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
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
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
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
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_UserCreditsLogEN._CurrTabName);
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
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_UserCreditsLogEN._CurrTabName, strCondition);
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
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
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
 objSQL = clsge_UserCreditsLogDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}