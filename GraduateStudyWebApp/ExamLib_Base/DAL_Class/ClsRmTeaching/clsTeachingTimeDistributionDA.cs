
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingTimeDistributionDA
 表名:TeachingTimeDistribution(01120440)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:58
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学(ClsRmTeaching)
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
 /// 教学时间分布(TeachingTimeDistribution)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsTeachingTimeDistributionDA : clsCommBase4DA
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
 return clsTeachingTimeDistributionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTeachingTimeDistributionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTeachingTimeDistributionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTeachingTimeDistributionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTeachingTimeDistributionEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTeachingTimeDistributionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingTimeDistribution where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TeachingTimeDistribution(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTeachingTimeDistributionDA: GetDataTable_TeachingTimeDistribution)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingTimeDistribution where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTeachingTimeDistributionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTeachingTimeDistributionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingTimeDistribution where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTeachingTimeDistributionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTeachingTimeDistributionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachingTimeDistribution where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachingTimeDistribution where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTeachingTimeDistributionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TeachingTimeDistribution where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTeachingTimeDistributionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeachingTimeDistribution.* from TeachingTimeDistribution Left Join {1} on {2} where {3} and TeachingTimeDistribution.mId not in (Select top {5} TeachingTimeDistribution.mId from TeachingTimeDistribution Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachingTimeDistribution where {1} and mId not in (Select top {2} mId from TeachingTimeDistribution where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachingTimeDistribution where {1} and mId not in (Select top {3} mId from TeachingTimeDistribution where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTeachingTimeDistributionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeachingTimeDistribution.* from TeachingTimeDistribution Left Join {1} on {2} where {3} and TeachingTimeDistribution.mId not in (Select top {5} TeachingTimeDistribution.mId from TeachingTimeDistribution Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachingTimeDistribution where {1} and mId not in (Select top {2} mId from TeachingTimeDistribution where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachingTimeDistribution where {1} and mId not in (Select top {3} mId from TeachingTimeDistribution where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsTeachingTimeDistributionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTeachingTimeDistributionDA:GetObjLst)", objException.Message));
}
List<clsTeachingTimeDistributionEN> arrObjLst = new List<clsTeachingTimeDistributionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingTimeDistribution where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingTimeDistributionEN objTeachingTimeDistributionEN = new clsTeachingTimeDistributionEN();
try
{
objTeachingTimeDistributionEN.mId = TransNullToInt(objRow[conTeachingTimeDistribution.mId].ToString().Trim()); //mId
objTeachingTimeDistributionEN.FuncModuleId = objRow[conTeachingTimeDistribution.FuncModuleId].ToString().Trim(); //功能模块Id
objTeachingTimeDistributionEN.IdMicroteachCase = objRow[conTeachingTimeDistribution.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objTeachingTimeDistributionEN.CaseName = objRow[conTeachingTimeDistribution.CaseName] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.CaseName].ToString().Trim(); //案例名称
objTeachingTimeDistributionEN.OwnerId = objRow[conTeachingTimeDistribution.OwnerId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.OwnerId].ToString().Trim(); //拥有者Id
objTeachingTimeDistributionEN.TeachingActivityTypeId = objRow[conTeachingTimeDistribution.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id
objTeachingTimeDistributionEN.UseTime = TransNullToDouble(objRow[conTeachingTimeDistribution.UseTime].ToString().Trim()); //使用时间s
objTeachingTimeDistributionEN.TimePercent = objRow[conTeachingTimeDistribution.TimePercent] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conTeachingTimeDistribution.TimePercent].ToString().Trim()); //时间比例
objTeachingTimeDistributionEN.TimeLengthOfVideo = objRow[conTeachingTimeDistribution.TimeLengthOfVideo] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conTeachingTimeDistribution.TimeLengthOfVideo].ToString().Trim()); //视频时长
objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId = objRow[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId].ToString().Trim(); //教学时间分布主类型Id
objTeachingTimeDistributionEN.TimeLengthPercent = objRow[conTeachingTimeDistribution.TimeLengthPercent] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conTeachingTimeDistribution.TimeLengthPercent].ToString().Trim()); //时长和占总视频时长百分比
objTeachingTimeDistributionEN.UseMedia = objRow[conTeachingTimeDistribution.UseMedia] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UseMedia].ToString().Trim(); //使用媒体
objTeachingTimeDistributionEN.UpdDate = objRow[conTeachingTimeDistribution.UpdDate] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UpdDate].ToString().Trim(); //修改日期
objTeachingTimeDistributionEN.UpdUserId = objRow[conTeachingTimeDistribution.UpdUserId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingTimeDistributionEN.Memo = objRow[conTeachingTimeDistribution.Memo] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeachingTimeDistributionDA: GetObjLst)", objException.Message));
}
objTeachingTimeDistributionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeachingTimeDistributionEN);
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
public List<clsTeachingTimeDistributionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTeachingTimeDistributionDA:GetObjLstByTabName)", objException.Message));
}
List<clsTeachingTimeDistributionEN> arrObjLst = new List<clsTeachingTimeDistributionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingTimeDistributionEN objTeachingTimeDistributionEN = new clsTeachingTimeDistributionEN();
try
{
objTeachingTimeDistributionEN.mId = TransNullToInt(objRow[conTeachingTimeDistribution.mId].ToString().Trim()); //mId
objTeachingTimeDistributionEN.FuncModuleId = objRow[conTeachingTimeDistribution.FuncModuleId].ToString().Trim(); //功能模块Id
objTeachingTimeDistributionEN.IdMicroteachCase = objRow[conTeachingTimeDistribution.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objTeachingTimeDistributionEN.CaseName = objRow[conTeachingTimeDistribution.CaseName] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.CaseName].ToString().Trim(); //案例名称
objTeachingTimeDistributionEN.OwnerId = objRow[conTeachingTimeDistribution.OwnerId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.OwnerId].ToString().Trim(); //拥有者Id
objTeachingTimeDistributionEN.TeachingActivityTypeId = objRow[conTeachingTimeDistribution.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id
objTeachingTimeDistributionEN.UseTime = TransNullToDouble(objRow[conTeachingTimeDistribution.UseTime].ToString().Trim()); //使用时间s
objTeachingTimeDistributionEN.TimePercent = objRow[conTeachingTimeDistribution.TimePercent] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conTeachingTimeDistribution.TimePercent].ToString().Trim()); //时间比例
objTeachingTimeDistributionEN.TimeLengthOfVideo = objRow[conTeachingTimeDistribution.TimeLengthOfVideo] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conTeachingTimeDistribution.TimeLengthOfVideo].ToString().Trim()); //视频时长
objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId = objRow[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId].ToString().Trim(); //教学时间分布主类型Id
objTeachingTimeDistributionEN.TimeLengthPercent = objRow[conTeachingTimeDistribution.TimeLengthPercent] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conTeachingTimeDistribution.TimeLengthPercent].ToString().Trim()); //时长和占总视频时长百分比
objTeachingTimeDistributionEN.UseMedia = objRow[conTeachingTimeDistribution.UseMedia] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UseMedia].ToString().Trim(); //使用媒体
objTeachingTimeDistributionEN.UpdDate = objRow[conTeachingTimeDistribution.UpdDate] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UpdDate].ToString().Trim(); //修改日期
objTeachingTimeDistributionEN.UpdUserId = objRow[conTeachingTimeDistribution.UpdUserId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingTimeDistributionEN.Memo = objRow[conTeachingTimeDistribution.Memo] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeachingTimeDistributionDA: GetObjLst)", objException.Message));
}
objTeachingTimeDistributionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeachingTimeDistributionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTeachingTimeDistribution(ref clsTeachingTimeDistributionEN objTeachingTimeDistributionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingTimeDistribution where mId = " + ""+ objTeachingTimeDistributionEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTeachingTimeDistributionEN.mId = TransNullToInt(objDT.Rows[0][conTeachingTimeDistribution.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objTeachingTimeDistributionEN.FuncModuleId = objDT.Rows[0][conTeachingTimeDistribution.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objTeachingTimeDistributionEN.IdMicroteachCase = objDT.Rows[0][conTeachingTimeDistribution.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachingTimeDistributionEN.CaseName = objDT.Rows[0][conTeachingTimeDistribution.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objTeachingTimeDistributionEN.OwnerId = objDT.Rows[0][conTeachingTimeDistribution.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objTeachingTimeDistributionEN.TeachingActivityTypeId = objDT.Rows[0][conTeachingTimeDistribution.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id(字段类型:char,字段长度:2,是否可空:False)
 objTeachingTimeDistributionEN.UseTime = TransNullToDouble(objDT.Rows[0][conTeachingTimeDistribution.UseTime].ToString().Trim()); //使用时间s(字段类型:decimal,字段长度:12,是否可空:False)
 objTeachingTimeDistributionEN.TimePercent = TransNullToDouble(objDT.Rows[0][conTeachingTimeDistribution.TimePercent].ToString().Trim()); //时间比例(字段类型:decimal,字段长度:20,是否可空:False)
 objTeachingTimeDistributionEN.TimeLengthOfVideo = TransNullToDouble(objDT.Rows[0][conTeachingTimeDistribution.TimeLengthOfVideo].ToString().Trim()); //视频时长(字段类型:decimal,字段长度:12,是否可空:True)
 objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId = objDT.Rows[0][conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId].ToString().Trim(); //教学时间分布主类型Id(字段类型:char,字段长度:4,是否可空:False)
 objTeachingTimeDistributionEN.TimeLengthPercent = TransNullToDouble(objDT.Rows[0][conTeachingTimeDistribution.TimeLengthPercent].ToString().Trim()); //时长和占总视频时长百分比(字段类型:decimal,字段长度:12,是否可空:True)
 objTeachingTimeDistributionEN.UseMedia = objDT.Rows[0][conTeachingTimeDistribution.UseMedia].ToString().Trim(); //使用媒体(字段类型:varchar,字段长度:30,是否可空:False)
 objTeachingTimeDistributionEN.UpdDate = objDT.Rows[0][conTeachingTimeDistribution.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingTimeDistributionEN.UpdUserId = objDT.Rows[0][conTeachingTimeDistribution.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingTimeDistributionEN.Memo = objDT.Rows[0][conTeachingTimeDistribution.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTeachingTimeDistributionDA: GetTeachingTimeDistribution)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsTeachingTimeDistributionEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingTimeDistribution where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTeachingTimeDistributionEN objTeachingTimeDistributionEN = new clsTeachingTimeDistributionEN();
try
{
 objTeachingTimeDistributionEN.mId = Int32.Parse(objRow[conTeachingTimeDistribution.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objTeachingTimeDistributionEN.FuncModuleId = objRow[conTeachingTimeDistribution.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objTeachingTimeDistributionEN.IdMicroteachCase = objRow[conTeachingTimeDistribution.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachingTimeDistributionEN.CaseName = objRow[conTeachingTimeDistribution.CaseName] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objTeachingTimeDistributionEN.OwnerId = objRow[conTeachingTimeDistribution.OwnerId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objTeachingTimeDistributionEN.TeachingActivityTypeId = objRow[conTeachingTimeDistribution.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id(字段类型:char,字段长度:2,是否可空:False)
 objTeachingTimeDistributionEN.UseTime = Double.Parse(objRow[conTeachingTimeDistribution.UseTime].ToString().Trim()); //使用时间s(字段类型:decimal,字段长度:12,是否可空:False)
 objTeachingTimeDistributionEN.TimePercent = objRow[conTeachingTimeDistribution.TimePercent] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conTeachingTimeDistribution.TimePercent].ToString().Trim()); //时间比例(字段类型:decimal,字段长度:20,是否可空:False)
 objTeachingTimeDistributionEN.TimeLengthOfVideo = objRow[conTeachingTimeDistribution.TimeLengthOfVideo] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conTeachingTimeDistribution.TimeLengthOfVideo].ToString().Trim()); //视频时长(字段类型:decimal,字段长度:12,是否可空:True)
 objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId = objRow[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId].ToString().Trim(); //教学时间分布主类型Id(字段类型:char,字段长度:4,是否可空:False)
 objTeachingTimeDistributionEN.TimeLengthPercent = objRow[conTeachingTimeDistribution.TimeLengthPercent] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conTeachingTimeDistribution.TimeLengthPercent].ToString().Trim()); //时长和占总视频时长百分比(字段类型:decimal,字段长度:12,是否可空:True)
 objTeachingTimeDistributionEN.UseMedia = objRow[conTeachingTimeDistribution.UseMedia] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UseMedia].ToString().Trim(); //使用媒体(字段类型:varchar,字段长度:30,是否可空:False)
 objTeachingTimeDistributionEN.UpdDate = objRow[conTeachingTimeDistribution.UpdDate] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingTimeDistributionEN.UpdUserId = objRow[conTeachingTimeDistribution.UpdUserId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingTimeDistributionEN.Memo = objRow[conTeachingTimeDistribution.Memo] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTeachingTimeDistributionDA: GetObjBymId)", objException.Message));
}
return objTeachingTimeDistributionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTeachingTimeDistributionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTeachingTimeDistributionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingTimeDistribution where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTeachingTimeDistributionEN objTeachingTimeDistributionEN = new clsTeachingTimeDistributionEN()
{
mId = TransNullToInt(objRow[conTeachingTimeDistribution.mId].ToString().Trim()), //mId
FuncModuleId = objRow[conTeachingTimeDistribution.FuncModuleId].ToString().Trim(), //功能模块Id
IdMicroteachCase = objRow[conTeachingTimeDistribution.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
CaseName = objRow[conTeachingTimeDistribution.CaseName] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.CaseName].ToString().Trim(), //案例名称
OwnerId = objRow[conTeachingTimeDistribution.OwnerId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.OwnerId].ToString().Trim(), //拥有者Id
TeachingActivityTypeId = objRow[conTeachingTimeDistribution.TeachingActivityTypeId].ToString().Trim(), //教学活动类型Id
UseTime = TransNullToDouble(objRow[conTeachingTimeDistribution.UseTime].ToString().Trim()), //使用时间s
TimePercent = objRow[conTeachingTimeDistribution.TimePercent] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conTeachingTimeDistribution.TimePercent].ToString().Trim()), //时间比例
TimeLengthOfVideo = objRow[conTeachingTimeDistribution.TimeLengthOfVideo] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conTeachingTimeDistribution.TimeLengthOfVideo].ToString().Trim()), //视频时长
TeachingTimeDistributionDetailMainTypeId = objRow[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId].ToString().Trim(), //教学时间分布主类型Id
TimeLengthPercent = objRow[conTeachingTimeDistribution.TimeLengthPercent] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conTeachingTimeDistribution.TimeLengthPercent].ToString().Trim()), //时长和占总视频时长百分比
UseMedia = objRow[conTeachingTimeDistribution.UseMedia] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UseMedia].ToString().Trim(), //使用媒体
UpdDate = objRow[conTeachingTimeDistribution.UpdDate] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conTeachingTimeDistribution.UpdUserId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conTeachingTimeDistribution.Memo] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.Memo].ToString().Trim() //备注
};
objTeachingTimeDistributionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachingTimeDistributionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTeachingTimeDistributionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTeachingTimeDistributionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeachingTimeDistributionEN objTeachingTimeDistributionEN = new clsTeachingTimeDistributionEN();
try
{
objTeachingTimeDistributionEN.mId = TransNullToInt(objRow[conTeachingTimeDistribution.mId].ToString().Trim()); //mId
objTeachingTimeDistributionEN.FuncModuleId = objRow[conTeachingTimeDistribution.FuncModuleId].ToString().Trim(); //功能模块Id
objTeachingTimeDistributionEN.IdMicroteachCase = objRow[conTeachingTimeDistribution.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objTeachingTimeDistributionEN.CaseName = objRow[conTeachingTimeDistribution.CaseName] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.CaseName].ToString().Trim(); //案例名称
objTeachingTimeDistributionEN.OwnerId = objRow[conTeachingTimeDistribution.OwnerId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.OwnerId].ToString().Trim(); //拥有者Id
objTeachingTimeDistributionEN.TeachingActivityTypeId = objRow[conTeachingTimeDistribution.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id
objTeachingTimeDistributionEN.UseTime = TransNullToDouble(objRow[conTeachingTimeDistribution.UseTime].ToString().Trim()); //使用时间s
objTeachingTimeDistributionEN.TimePercent = objRow[conTeachingTimeDistribution.TimePercent] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conTeachingTimeDistribution.TimePercent].ToString().Trim()); //时间比例
objTeachingTimeDistributionEN.TimeLengthOfVideo = objRow[conTeachingTimeDistribution.TimeLengthOfVideo] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conTeachingTimeDistribution.TimeLengthOfVideo].ToString().Trim()); //视频时长
objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId = objRow[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId].ToString().Trim(); //教学时间分布主类型Id
objTeachingTimeDistributionEN.TimeLengthPercent = objRow[conTeachingTimeDistribution.TimeLengthPercent] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conTeachingTimeDistribution.TimeLengthPercent].ToString().Trim()); //时长和占总视频时长百分比
objTeachingTimeDistributionEN.UseMedia = objRow[conTeachingTimeDistribution.UseMedia] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UseMedia].ToString().Trim(); //使用媒体
objTeachingTimeDistributionEN.UpdDate = objRow[conTeachingTimeDistribution.UpdDate] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UpdDate].ToString().Trim(); //修改日期
objTeachingTimeDistributionEN.UpdUserId = objRow[conTeachingTimeDistribution.UpdUserId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingTimeDistributionEN.Memo = objRow[conTeachingTimeDistribution.Memo] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTeachingTimeDistributionDA: GetObjByDataRowTeachingTimeDistribution)", objException.Message));
}
objTeachingTimeDistributionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachingTimeDistributionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTeachingTimeDistributionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeachingTimeDistributionEN objTeachingTimeDistributionEN = new clsTeachingTimeDistributionEN();
try
{
objTeachingTimeDistributionEN.mId = TransNullToInt(objRow[conTeachingTimeDistribution.mId].ToString().Trim()); //mId
objTeachingTimeDistributionEN.FuncModuleId = objRow[conTeachingTimeDistribution.FuncModuleId].ToString().Trim(); //功能模块Id
objTeachingTimeDistributionEN.IdMicroteachCase = objRow[conTeachingTimeDistribution.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objTeachingTimeDistributionEN.CaseName = objRow[conTeachingTimeDistribution.CaseName] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.CaseName].ToString().Trim(); //案例名称
objTeachingTimeDistributionEN.OwnerId = objRow[conTeachingTimeDistribution.OwnerId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.OwnerId].ToString().Trim(); //拥有者Id
objTeachingTimeDistributionEN.TeachingActivityTypeId = objRow[conTeachingTimeDistribution.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id
objTeachingTimeDistributionEN.UseTime = TransNullToDouble(objRow[conTeachingTimeDistribution.UseTime].ToString().Trim()); //使用时间s
objTeachingTimeDistributionEN.TimePercent = objRow[conTeachingTimeDistribution.TimePercent] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conTeachingTimeDistribution.TimePercent].ToString().Trim()); //时间比例
objTeachingTimeDistributionEN.TimeLengthOfVideo = objRow[conTeachingTimeDistribution.TimeLengthOfVideo] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conTeachingTimeDistribution.TimeLengthOfVideo].ToString().Trim()); //视频时长
objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId = objRow[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId].ToString().Trim(); //教学时间分布主类型Id
objTeachingTimeDistributionEN.TimeLengthPercent = objRow[conTeachingTimeDistribution.TimeLengthPercent] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conTeachingTimeDistribution.TimeLengthPercent].ToString().Trim()); //时长和占总视频时长百分比
objTeachingTimeDistributionEN.UseMedia = objRow[conTeachingTimeDistribution.UseMedia] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UseMedia].ToString().Trim(); //使用媒体
objTeachingTimeDistributionEN.UpdDate = objRow[conTeachingTimeDistribution.UpdDate] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UpdDate].ToString().Trim(); //修改日期
objTeachingTimeDistributionEN.UpdUserId = objRow[conTeachingTimeDistribution.UpdUserId] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingTimeDistributionEN.Memo = objRow[conTeachingTimeDistribution.Memo] == DBNull.Value ? null : objRow[conTeachingTimeDistribution.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTeachingTimeDistributionDA: GetObjByDataRow)", objException.Message));
}
objTeachingTimeDistributionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachingTimeDistributionEN;
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
objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeachingTimeDistributionEN._CurrTabName, conTeachingTimeDistribution.mId, 8, "");
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
objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeachingTimeDistributionEN._CurrTabName, conTeachingTimeDistribution.mId, 8, strPrefix);
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
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from TeachingTimeDistribution where " + strCondition;
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
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from TeachingTimeDistribution where " + strCondition;
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
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeachingTimeDistribution", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTeachingTimeDistributionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeachingTimeDistribution", strCondition))
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
objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TeachingTimeDistribution");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN)
 {
 objTeachingTimeDistributionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingTimeDistributionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingTimeDistributionEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingTimeDistribution where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeachingTimeDistribution");
objRow = objDS.Tables["TeachingTimeDistribution"].NewRow();
objRow[conTeachingTimeDistribution.FuncModuleId] = objTeachingTimeDistributionEN.FuncModuleId; //功能模块Id
objRow[conTeachingTimeDistribution.IdMicroteachCase] = objTeachingTimeDistributionEN.IdMicroteachCase; //微格教学案例流水号
 if (objTeachingTimeDistributionEN.CaseName !=  "")
 {
objRow[conTeachingTimeDistribution.CaseName] = objTeachingTimeDistributionEN.CaseName; //案例名称
 }
 if (objTeachingTimeDistributionEN.OwnerId !=  "")
 {
objRow[conTeachingTimeDistribution.OwnerId] = objTeachingTimeDistributionEN.OwnerId; //拥有者Id
 }
objRow[conTeachingTimeDistribution.TeachingActivityTypeId] = objTeachingTimeDistributionEN.TeachingActivityTypeId; //教学活动类型Id
objRow[conTeachingTimeDistribution.UseTime] = objTeachingTimeDistributionEN.UseTime; //使用时间s
objRow[conTeachingTimeDistribution.TimePercent] = objTeachingTimeDistributionEN.TimePercent; //时间比例
objRow[conTeachingTimeDistribution.TimeLengthOfVideo] = objTeachingTimeDistributionEN.TimeLengthOfVideo; //视频时长
 if (objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId !=  "")
 {
objRow[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId] = objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId; //教学时间分布主类型Id
 }
objRow[conTeachingTimeDistribution.TimeLengthPercent] = objTeachingTimeDistributionEN.TimeLengthPercent; //时长和占总视频时长百分比
 if (objTeachingTimeDistributionEN.UseMedia !=  "")
 {
objRow[conTeachingTimeDistribution.UseMedia] = objTeachingTimeDistributionEN.UseMedia; //使用媒体
 }
 if (objTeachingTimeDistributionEN.UpdDate !=  "")
 {
objRow[conTeachingTimeDistribution.UpdDate] = objTeachingTimeDistributionEN.UpdDate; //修改日期
 }
 if (objTeachingTimeDistributionEN.UpdUserId !=  "")
 {
objRow[conTeachingTimeDistribution.UpdUserId] = objTeachingTimeDistributionEN.UpdUserId; //修改用户Id
 }
 if (objTeachingTimeDistributionEN.Memo !=  "")
 {
objRow[conTeachingTimeDistribution.Memo] = objTeachingTimeDistributionEN.Memo; //备注
 }
objDS.Tables[clsTeachingTimeDistributionEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTeachingTimeDistributionEN._CurrTabName);
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
 /// <param name = "objTeachingTimeDistributionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN)
{
 objTeachingTimeDistributionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingTimeDistributionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingTimeDistributionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTeachingTimeDistributionEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.FuncModuleId);
 var strFuncModuleId = objTeachingTimeDistributionEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objTeachingTimeDistributionEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.IdMicroteachCase);
 var strIdMicroteachCase = objTeachingTimeDistributionEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objTeachingTimeDistributionEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.CaseName);
 var strCaseName = objTeachingTimeDistributionEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objTeachingTimeDistributionEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.OwnerId);
 var strOwnerId = objTeachingTimeDistributionEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objTeachingTimeDistributionEN.TeachingActivityTypeId  ==  "")
 {
 objTeachingTimeDistributionEN.TeachingActivityTypeId = null;
 }
 if (objTeachingTimeDistributionEN.TeachingActivityTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TeachingActivityTypeId);
 var strTeachingActivityTypeId = objTeachingTimeDistributionEN.TeachingActivityTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingActivityTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conTeachingTimeDistribution.UseTime);
 arrValueListForInsert.Add(objTeachingTimeDistributionEN.UseTime.ToString());
 
 if (objTeachingTimeDistributionEN.TimePercent !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TimePercent);
 arrValueListForInsert.Add(objTeachingTimeDistributionEN.TimePercent.ToString());
 }
 
 if (objTeachingTimeDistributionEN.TimeLengthOfVideo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TimeLengthOfVideo);
 arrValueListForInsert.Add(objTeachingTimeDistributionEN.TimeLengthOfVideo.ToString());
 }
 
 if (objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId);
 var strTeachingTimeDistributionDetailMainTypeId = objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingTimeDistributionDetailMainTypeId + "'");
 }
 
 if (objTeachingTimeDistributionEN.TimeLengthPercent !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TimeLengthPercent);
 arrValueListForInsert.Add(objTeachingTimeDistributionEN.TimeLengthPercent.ToString());
 }
 
 if (objTeachingTimeDistributionEN.UseMedia !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.UseMedia);
 var strUseMedia = objTeachingTimeDistributionEN.UseMedia.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseMedia + "'");
 }
 
 if (objTeachingTimeDistributionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.UpdDate);
 var strUpdDate = objTeachingTimeDistributionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingTimeDistributionEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.UpdUserId);
 var strUpdUserId = objTeachingTimeDistributionEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachingTimeDistributionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.Memo);
 var strMemo = objTeachingTimeDistributionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingTimeDistribution");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN)
{
 objTeachingTimeDistributionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingTimeDistributionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingTimeDistributionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTeachingTimeDistributionEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.FuncModuleId);
 var strFuncModuleId = objTeachingTimeDistributionEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objTeachingTimeDistributionEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.IdMicroteachCase);
 var strIdMicroteachCase = objTeachingTimeDistributionEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objTeachingTimeDistributionEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.CaseName);
 var strCaseName = objTeachingTimeDistributionEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objTeachingTimeDistributionEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.OwnerId);
 var strOwnerId = objTeachingTimeDistributionEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objTeachingTimeDistributionEN.TeachingActivityTypeId  ==  "")
 {
 objTeachingTimeDistributionEN.TeachingActivityTypeId = null;
 }
 if (objTeachingTimeDistributionEN.TeachingActivityTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TeachingActivityTypeId);
 var strTeachingActivityTypeId = objTeachingTimeDistributionEN.TeachingActivityTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingActivityTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conTeachingTimeDistribution.UseTime);
 arrValueListForInsert.Add(objTeachingTimeDistributionEN.UseTime.ToString());
 
 if (objTeachingTimeDistributionEN.TimePercent !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TimePercent);
 arrValueListForInsert.Add(objTeachingTimeDistributionEN.TimePercent.ToString());
 }
 
 if (objTeachingTimeDistributionEN.TimeLengthOfVideo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TimeLengthOfVideo);
 arrValueListForInsert.Add(objTeachingTimeDistributionEN.TimeLengthOfVideo.ToString());
 }
 
 if (objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId);
 var strTeachingTimeDistributionDetailMainTypeId = objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingTimeDistributionDetailMainTypeId + "'");
 }
 
 if (objTeachingTimeDistributionEN.TimeLengthPercent !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TimeLengthPercent);
 arrValueListForInsert.Add(objTeachingTimeDistributionEN.TimeLengthPercent.ToString());
 }
 
 if (objTeachingTimeDistributionEN.UseMedia !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.UseMedia);
 var strUseMedia = objTeachingTimeDistributionEN.UseMedia.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseMedia + "'");
 }
 
 if (objTeachingTimeDistributionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.UpdDate);
 var strUpdDate = objTeachingTimeDistributionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingTimeDistributionEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.UpdUserId);
 var strUpdUserId = objTeachingTimeDistributionEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachingTimeDistributionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.Memo);
 var strMemo = objTeachingTimeDistributionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingTimeDistribution");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTeachingTimeDistributionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingTimeDistributionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingTimeDistributionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTeachingTimeDistributionEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.FuncModuleId);
 var strFuncModuleId = objTeachingTimeDistributionEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objTeachingTimeDistributionEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.IdMicroteachCase);
 var strIdMicroteachCase = objTeachingTimeDistributionEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objTeachingTimeDistributionEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.CaseName);
 var strCaseName = objTeachingTimeDistributionEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objTeachingTimeDistributionEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.OwnerId);
 var strOwnerId = objTeachingTimeDistributionEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objTeachingTimeDistributionEN.TeachingActivityTypeId  ==  "")
 {
 objTeachingTimeDistributionEN.TeachingActivityTypeId = null;
 }
 if (objTeachingTimeDistributionEN.TeachingActivityTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TeachingActivityTypeId);
 var strTeachingActivityTypeId = objTeachingTimeDistributionEN.TeachingActivityTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingActivityTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conTeachingTimeDistribution.UseTime);
 arrValueListForInsert.Add(objTeachingTimeDistributionEN.UseTime.ToString());
 
 if (objTeachingTimeDistributionEN.TimePercent !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TimePercent);
 arrValueListForInsert.Add(objTeachingTimeDistributionEN.TimePercent.ToString());
 }
 
 if (objTeachingTimeDistributionEN.TimeLengthOfVideo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TimeLengthOfVideo);
 arrValueListForInsert.Add(objTeachingTimeDistributionEN.TimeLengthOfVideo.ToString());
 }
 
 if (objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId);
 var strTeachingTimeDistributionDetailMainTypeId = objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingTimeDistributionDetailMainTypeId + "'");
 }
 
 if (objTeachingTimeDistributionEN.TimeLengthPercent !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TimeLengthPercent);
 arrValueListForInsert.Add(objTeachingTimeDistributionEN.TimeLengthPercent.ToString());
 }
 
 if (objTeachingTimeDistributionEN.UseMedia !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.UseMedia);
 var strUseMedia = objTeachingTimeDistributionEN.UseMedia.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseMedia + "'");
 }
 
 if (objTeachingTimeDistributionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.UpdDate);
 var strUpdDate = objTeachingTimeDistributionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingTimeDistributionEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.UpdUserId);
 var strUpdUserId = objTeachingTimeDistributionEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachingTimeDistributionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.Memo);
 var strMemo = objTeachingTimeDistributionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingTimeDistribution");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTeachingTimeDistributionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingTimeDistributionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingTimeDistributionEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTeachingTimeDistributionEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.FuncModuleId);
 var strFuncModuleId = objTeachingTimeDistributionEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objTeachingTimeDistributionEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.IdMicroteachCase);
 var strIdMicroteachCase = objTeachingTimeDistributionEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objTeachingTimeDistributionEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.CaseName);
 var strCaseName = objTeachingTimeDistributionEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objTeachingTimeDistributionEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.OwnerId);
 var strOwnerId = objTeachingTimeDistributionEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objTeachingTimeDistributionEN.TeachingActivityTypeId  ==  "")
 {
 objTeachingTimeDistributionEN.TeachingActivityTypeId = null;
 }
 if (objTeachingTimeDistributionEN.TeachingActivityTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TeachingActivityTypeId);
 var strTeachingActivityTypeId = objTeachingTimeDistributionEN.TeachingActivityTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingActivityTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conTeachingTimeDistribution.UseTime);
 arrValueListForInsert.Add(objTeachingTimeDistributionEN.UseTime.ToString());
 
 if (objTeachingTimeDistributionEN.TimePercent !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TimePercent);
 arrValueListForInsert.Add(objTeachingTimeDistributionEN.TimePercent.ToString());
 }
 
 if (objTeachingTimeDistributionEN.TimeLengthOfVideo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TimeLengthOfVideo);
 arrValueListForInsert.Add(objTeachingTimeDistributionEN.TimeLengthOfVideo.ToString());
 }
 
 if (objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId);
 var strTeachingTimeDistributionDetailMainTypeId = objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingTimeDistributionDetailMainTypeId + "'");
 }
 
 if (objTeachingTimeDistributionEN.TimeLengthPercent !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.TimeLengthPercent);
 arrValueListForInsert.Add(objTeachingTimeDistributionEN.TimeLengthPercent.ToString());
 }
 
 if (objTeachingTimeDistributionEN.UseMedia !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.UseMedia);
 var strUseMedia = objTeachingTimeDistributionEN.UseMedia.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseMedia + "'");
 }
 
 if (objTeachingTimeDistributionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.UpdDate);
 var strUpdDate = objTeachingTimeDistributionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingTimeDistributionEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.UpdUserId);
 var strUpdUserId = objTeachingTimeDistributionEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachingTimeDistributionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingTimeDistribution.Memo);
 var strMemo = objTeachingTimeDistributionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingTimeDistribution");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTeachingTimeDistributions(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingTimeDistribution where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeachingTimeDistribution");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTeachingTimeDistributionEN._CurrTabName ].NewRow();
objRow[conTeachingTimeDistribution.FuncModuleId] = oRow[conTeachingTimeDistribution.FuncModuleId].ToString().Trim(); //功能模块Id
objRow[conTeachingTimeDistribution.IdMicroteachCase] = oRow[conTeachingTimeDistribution.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objRow[conTeachingTimeDistribution.CaseName] = oRow[conTeachingTimeDistribution.CaseName].ToString().Trim(); //案例名称
objRow[conTeachingTimeDistribution.OwnerId] = oRow[conTeachingTimeDistribution.OwnerId].ToString().Trim(); //拥有者Id
objRow[conTeachingTimeDistribution.TeachingActivityTypeId] = oRow[conTeachingTimeDistribution.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id
objRow[conTeachingTimeDistribution.UseTime] = oRow[conTeachingTimeDistribution.UseTime].ToString().Trim(); //使用时间s
objRow[conTeachingTimeDistribution.TimePercent] = oRow[conTeachingTimeDistribution.TimePercent].ToString().Trim(); //时间比例
objRow[conTeachingTimeDistribution.TimeLengthOfVideo] = oRow[conTeachingTimeDistribution.TimeLengthOfVideo].ToString().Trim(); //视频时长
objRow[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId] = oRow[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId].ToString().Trim(); //教学时间分布主类型Id
objRow[conTeachingTimeDistribution.TimeLengthPercent] = oRow[conTeachingTimeDistribution.TimeLengthPercent].ToString().Trim(); //时长和占总视频时长百分比
objRow[conTeachingTimeDistribution.UseMedia] = oRow[conTeachingTimeDistribution.UseMedia].ToString().Trim(); //使用媒体
objRow[conTeachingTimeDistribution.UpdDate] = oRow[conTeachingTimeDistribution.UpdDate].ToString().Trim(); //修改日期
objRow[conTeachingTimeDistribution.UpdUserId] = oRow[conTeachingTimeDistribution.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conTeachingTimeDistribution.Memo] = oRow[conTeachingTimeDistribution.Memo].ToString().Trim(); //备注
 objDS.Tables[clsTeachingTimeDistributionEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTeachingTimeDistributionEN._CurrTabName);
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
 /// <param name = "objTeachingTimeDistributionEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN)
{
 objTeachingTimeDistributionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingTimeDistributionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingTimeDistributionEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
strSQL = "Select * from TeachingTimeDistribution where mId = " + ""+ objTeachingTimeDistributionEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTeachingTimeDistributionEN._CurrTabName);
if (objDS.Tables[clsTeachingTimeDistributionEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objTeachingTimeDistributionEN.mId+"");
return false;
}
objRow = objDS.Tables[clsTeachingTimeDistributionEN._CurrTabName].Rows[0];
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.FuncModuleId))
 {
objRow[conTeachingTimeDistribution.FuncModuleId] = objTeachingTimeDistributionEN.FuncModuleId; //功能模块Id
 }
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.IdMicroteachCase))
 {
objRow[conTeachingTimeDistribution.IdMicroteachCase] = objTeachingTimeDistributionEN.IdMicroteachCase; //微格教学案例流水号
 }
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.CaseName))
 {
objRow[conTeachingTimeDistribution.CaseName] = objTeachingTimeDistributionEN.CaseName; //案例名称
 }
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.OwnerId))
 {
objRow[conTeachingTimeDistribution.OwnerId] = objTeachingTimeDistributionEN.OwnerId; //拥有者Id
 }
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TeachingActivityTypeId))
 {
objRow[conTeachingTimeDistribution.TeachingActivityTypeId] = objTeachingTimeDistributionEN.TeachingActivityTypeId; //教学活动类型Id
 }
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UseTime))
 {
objRow[conTeachingTimeDistribution.UseTime] = objTeachingTimeDistributionEN.UseTime; //使用时间s
 }
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TimePercent))
 {
objRow[conTeachingTimeDistribution.TimePercent] = objTeachingTimeDistributionEN.TimePercent; //时间比例
 }
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TimeLengthOfVideo))
 {
objRow[conTeachingTimeDistribution.TimeLengthOfVideo] = objTeachingTimeDistributionEN.TimeLengthOfVideo; //视频时长
 }
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId))
 {
objRow[conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId] = objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId; //教学时间分布主类型Id
 }
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TimeLengthPercent))
 {
objRow[conTeachingTimeDistribution.TimeLengthPercent] = objTeachingTimeDistributionEN.TimeLengthPercent; //时长和占总视频时长百分比
 }
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UseMedia))
 {
objRow[conTeachingTimeDistribution.UseMedia] = objTeachingTimeDistributionEN.UseMedia; //使用媒体
 }
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UpdDate))
 {
objRow[conTeachingTimeDistribution.UpdDate] = objTeachingTimeDistributionEN.UpdDate; //修改日期
 }
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UpdUserId))
 {
objRow[conTeachingTimeDistribution.UpdUserId] = objTeachingTimeDistributionEN.UpdUserId; //修改用户Id
 }
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.Memo))
 {
objRow[conTeachingTimeDistribution.Memo] = objTeachingTimeDistributionEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsTeachingTimeDistributionEN._CurrTabName);
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
 /// <param name = "objTeachingTimeDistributionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN)
{
 objTeachingTimeDistributionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingTimeDistributionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingTimeDistributionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TeachingTimeDistribution Set ");
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.FuncModuleId))
 {
 if (objTeachingTimeDistributionEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objTeachingTimeDistributionEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conTeachingTimeDistribution.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.FuncModuleId); //功能模块Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.IdMicroteachCase))
 {
 if (objTeachingTimeDistributionEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objTeachingTimeDistributionEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMicroteachCase, conTeachingTimeDistribution.IdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.IdMicroteachCase); //微格教学案例流水号
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.CaseName))
 {
 if (objTeachingTimeDistributionEN.CaseName !=  null)
 {
 var strCaseName = objTeachingTimeDistributionEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName, conTeachingTimeDistribution.CaseName); //案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.CaseName); //案例名称
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.OwnerId))
 {
 if (objTeachingTimeDistributionEN.OwnerId !=  null)
 {
 var strOwnerId = objTeachingTimeDistributionEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conTeachingTimeDistribution.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.OwnerId); //拥有者Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TeachingActivityTypeId))
 {
 if (objTeachingTimeDistributionEN.TeachingActivityTypeId  ==  "")
 {
 objTeachingTimeDistributionEN.TeachingActivityTypeId = null;
 }
 if (objTeachingTimeDistributionEN.TeachingActivityTypeId !=  null)
 {
 var strTeachingActivityTypeId = objTeachingTimeDistributionEN.TeachingActivityTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingActivityTypeId, conTeachingTimeDistribution.TeachingActivityTypeId); //教学活动类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.TeachingActivityTypeId); //教学活动类型Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UseTime))
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingTimeDistributionEN.UseTime, conTeachingTimeDistribution.UseTime); //使用时间s
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TimePercent))
 {
 if (objTeachingTimeDistributionEN.TimePercent !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingTimeDistributionEN.TimePercent, conTeachingTimeDistribution.TimePercent); //时间比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.TimePercent); //时间比例
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TimeLengthOfVideo))
 {
 if (objTeachingTimeDistributionEN.TimeLengthOfVideo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingTimeDistributionEN.TimeLengthOfVideo, conTeachingTimeDistribution.TimeLengthOfVideo); //视频时长
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.TimeLengthOfVideo); //视频时长
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId))
 {
 if (objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId !=  null)
 {
 var strTeachingTimeDistributionDetailMainTypeId = objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingTimeDistributionDetailMainTypeId, conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId); //教学时间分布主类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId); //教学时间分布主类型Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TimeLengthPercent))
 {
 if (objTeachingTimeDistributionEN.TimeLengthPercent !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingTimeDistributionEN.TimeLengthPercent, conTeachingTimeDistribution.TimeLengthPercent); //时长和占总视频时长百分比
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.TimeLengthPercent); //时长和占总视频时长百分比
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UseMedia))
 {
 if (objTeachingTimeDistributionEN.UseMedia !=  null)
 {
 var strUseMedia = objTeachingTimeDistributionEN.UseMedia.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUseMedia, conTeachingTimeDistribution.UseMedia); //使用媒体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.UseMedia); //使用媒体
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UpdDate))
 {
 if (objTeachingTimeDistributionEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingTimeDistributionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTeachingTimeDistribution.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.UpdDate); //修改日期
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UpdUserId))
 {
 if (objTeachingTimeDistributionEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachingTimeDistributionEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conTeachingTimeDistribution.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.UpdUserId); //修改用户Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.Memo))
 {
 if (objTeachingTimeDistributionEN.Memo !=  null)
 {
 var strMemo = objTeachingTimeDistributionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeachingTimeDistribution.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objTeachingTimeDistributionEN.mId); 
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
 /// <param name = "objTeachingTimeDistributionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, string strCondition)
{
 objTeachingTimeDistributionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingTimeDistributionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingTimeDistributionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachingTimeDistribution Set ");
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.FuncModuleId))
 {
 if (objTeachingTimeDistributionEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objTeachingTimeDistributionEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.IdMicroteachCase))
 {
 if (objTeachingTimeDistributionEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objTeachingTimeDistributionEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMicroteachCase = '{0}',", strIdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.Append(" IdMicroteachCase = null,"); //微格教学案例流水号
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.CaseName))
 {
 if (objTeachingTimeDistributionEN.CaseName !=  null)
 {
 var strCaseName = objTeachingTimeDistributionEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName = '{0}',", strCaseName); //案例名称
 }
 else
 {
 sbSQL.Append(" CaseName = null,"); //案例名称
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.OwnerId))
 {
 if (objTeachingTimeDistributionEN.OwnerId !=  null)
 {
 var strOwnerId = objTeachingTimeDistributionEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TeachingActivityTypeId))
 {
 if (objTeachingTimeDistributionEN.TeachingActivityTypeId  ==  "")
 {
 objTeachingTimeDistributionEN.TeachingActivityTypeId = null;
 }
 if (objTeachingTimeDistributionEN.TeachingActivityTypeId !=  null)
 {
 var strTeachingActivityTypeId = objTeachingTimeDistributionEN.TeachingActivityTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingActivityTypeId = '{0}',", strTeachingActivityTypeId); //教学活动类型Id
 }
 else
 {
 sbSQL.Append(" TeachingActivityTypeId = null,"); //教学活动类型Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UseTime))
 {
 sbSQL.AppendFormat(" UseTime = {0},", objTeachingTimeDistributionEN.UseTime); //使用时间s
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TimePercent))
 {
 sbSQL.AppendFormat(" TimePercent = {0},", objTeachingTimeDistributionEN.TimePercent); //时间比例
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TimeLengthOfVideo))
 {
 sbSQL.AppendFormat(" TimeLengthOfVideo = {0},", objTeachingTimeDistributionEN.TimeLengthOfVideo); //视频时长
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId))
 {
 if (objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId !=  null)
 {
 var strTeachingTimeDistributionDetailMainTypeId = objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingTimeDistributionDetailMainTypeId = '{0}',", strTeachingTimeDistributionDetailMainTypeId); //教学时间分布主类型Id
 }
 else
 {
 sbSQL.Append(" TeachingTimeDistributionDetailMainTypeId = null,"); //教学时间分布主类型Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TimeLengthPercent))
 {
 sbSQL.AppendFormat(" TimeLengthPercent = {0},", objTeachingTimeDistributionEN.TimeLengthPercent); //时长和占总视频时长百分比
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UseMedia))
 {
 if (objTeachingTimeDistributionEN.UseMedia !=  null)
 {
 var strUseMedia = objTeachingTimeDistributionEN.UseMedia.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UseMedia = '{0}',", strUseMedia); //使用媒体
 }
 else
 {
 sbSQL.Append(" UseMedia = null,"); //使用媒体
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UpdDate))
 {
 if (objTeachingTimeDistributionEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingTimeDistributionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UpdUserId))
 {
 if (objTeachingTimeDistributionEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachingTimeDistributionEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.Memo))
 {
 if (objTeachingTimeDistributionEN.Memo !=  null)
 {
 var strMemo = objTeachingTimeDistributionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTeachingTimeDistributionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTeachingTimeDistributionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingTimeDistributionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingTimeDistributionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachingTimeDistribution Set ");
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.FuncModuleId))
 {
 if (objTeachingTimeDistributionEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objTeachingTimeDistributionEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.IdMicroteachCase))
 {
 if (objTeachingTimeDistributionEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objTeachingTimeDistributionEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMicroteachCase = '{0}',", strIdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.Append(" IdMicroteachCase = null,"); //微格教学案例流水号
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.CaseName))
 {
 if (objTeachingTimeDistributionEN.CaseName !=  null)
 {
 var strCaseName = objTeachingTimeDistributionEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName = '{0}',", strCaseName); //案例名称
 }
 else
 {
 sbSQL.Append(" CaseName = null,"); //案例名称
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.OwnerId))
 {
 if (objTeachingTimeDistributionEN.OwnerId !=  null)
 {
 var strOwnerId = objTeachingTimeDistributionEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TeachingActivityTypeId))
 {
 if (objTeachingTimeDistributionEN.TeachingActivityTypeId  ==  "")
 {
 objTeachingTimeDistributionEN.TeachingActivityTypeId = null;
 }
 if (objTeachingTimeDistributionEN.TeachingActivityTypeId !=  null)
 {
 var strTeachingActivityTypeId = objTeachingTimeDistributionEN.TeachingActivityTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingActivityTypeId = '{0}',", strTeachingActivityTypeId); //教学活动类型Id
 }
 else
 {
 sbSQL.Append(" TeachingActivityTypeId = null,"); //教学活动类型Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UseTime))
 {
 sbSQL.AppendFormat(" UseTime = {0},", objTeachingTimeDistributionEN.UseTime); //使用时间s
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TimePercent))
 {
 sbSQL.AppendFormat(" TimePercent = {0},", objTeachingTimeDistributionEN.TimePercent); //时间比例
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TimeLengthOfVideo))
 {
 sbSQL.AppendFormat(" TimeLengthOfVideo = {0},", objTeachingTimeDistributionEN.TimeLengthOfVideo); //视频时长
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId))
 {
 if (objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId !=  null)
 {
 var strTeachingTimeDistributionDetailMainTypeId = objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingTimeDistributionDetailMainTypeId = '{0}',", strTeachingTimeDistributionDetailMainTypeId); //教学时间分布主类型Id
 }
 else
 {
 sbSQL.Append(" TeachingTimeDistributionDetailMainTypeId = null,"); //教学时间分布主类型Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TimeLengthPercent))
 {
 sbSQL.AppendFormat(" TimeLengthPercent = {0},", objTeachingTimeDistributionEN.TimeLengthPercent); //时长和占总视频时长百分比
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UseMedia))
 {
 if (objTeachingTimeDistributionEN.UseMedia !=  null)
 {
 var strUseMedia = objTeachingTimeDistributionEN.UseMedia.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UseMedia = '{0}',", strUseMedia); //使用媒体
 }
 else
 {
 sbSQL.Append(" UseMedia = null,"); //使用媒体
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UpdDate))
 {
 if (objTeachingTimeDistributionEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingTimeDistributionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UpdUserId))
 {
 if (objTeachingTimeDistributionEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachingTimeDistributionEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.Memo))
 {
 if (objTeachingTimeDistributionEN.Memo !=  null)
 {
 var strMemo = objTeachingTimeDistributionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTeachingTimeDistributionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTeachingTimeDistributionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingTimeDistributionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingTimeDistributionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachingTimeDistribution Set ");
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.FuncModuleId))
 {
 if (objTeachingTimeDistributionEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objTeachingTimeDistributionEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conTeachingTimeDistribution.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.FuncModuleId); //功能模块Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.IdMicroteachCase))
 {
 if (objTeachingTimeDistributionEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objTeachingTimeDistributionEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMicroteachCase, conTeachingTimeDistribution.IdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.IdMicroteachCase); //微格教学案例流水号
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.CaseName))
 {
 if (objTeachingTimeDistributionEN.CaseName !=  null)
 {
 var strCaseName = objTeachingTimeDistributionEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName, conTeachingTimeDistribution.CaseName); //案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.CaseName); //案例名称
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.OwnerId))
 {
 if (objTeachingTimeDistributionEN.OwnerId !=  null)
 {
 var strOwnerId = objTeachingTimeDistributionEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conTeachingTimeDistribution.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.OwnerId); //拥有者Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TeachingActivityTypeId))
 {
 if (objTeachingTimeDistributionEN.TeachingActivityTypeId  ==  "")
 {
 objTeachingTimeDistributionEN.TeachingActivityTypeId = null;
 }
 if (objTeachingTimeDistributionEN.TeachingActivityTypeId !=  null)
 {
 var strTeachingActivityTypeId = objTeachingTimeDistributionEN.TeachingActivityTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingActivityTypeId, conTeachingTimeDistribution.TeachingActivityTypeId); //教学活动类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.TeachingActivityTypeId); //教学活动类型Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UseTime))
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingTimeDistributionEN.UseTime, conTeachingTimeDistribution.UseTime); //使用时间s
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TimePercent))
 {
 if (objTeachingTimeDistributionEN.TimePercent !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingTimeDistributionEN.TimePercent, conTeachingTimeDistribution.TimePercent); //时间比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.TimePercent); //时间比例
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TimeLengthOfVideo))
 {
 if (objTeachingTimeDistributionEN.TimeLengthOfVideo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingTimeDistributionEN.TimeLengthOfVideo, conTeachingTimeDistribution.TimeLengthOfVideo); //视频时长
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.TimeLengthOfVideo); //视频时长
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId))
 {
 if (objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId !=  null)
 {
 var strTeachingTimeDistributionDetailMainTypeId = objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingTimeDistributionDetailMainTypeId, conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId); //教学时间分布主类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId); //教学时间分布主类型Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.TimeLengthPercent))
 {
 if (objTeachingTimeDistributionEN.TimeLengthPercent !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingTimeDistributionEN.TimeLengthPercent, conTeachingTimeDistribution.TimeLengthPercent); //时长和占总视频时长百分比
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.TimeLengthPercent); //时长和占总视频时长百分比
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UseMedia))
 {
 if (objTeachingTimeDistributionEN.UseMedia !=  null)
 {
 var strUseMedia = objTeachingTimeDistributionEN.UseMedia.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUseMedia, conTeachingTimeDistribution.UseMedia); //使用媒体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.UseMedia); //使用媒体
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UpdDate))
 {
 if (objTeachingTimeDistributionEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingTimeDistributionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTeachingTimeDistribution.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.UpdDate); //修改日期
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.UpdUserId))
 {
 if (objTeachingTimeDistributionEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachingTimeDistributionEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conTeachingTimeDistribution.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.UpdUserId); //修改用户Id
 }
 }
 
 if (objTeachingTimeDistributionEN.IsUpdated(conTeachingTimeDistribution.Memo))
 {
 if (objTeachingTimeDistributionEN.Memo !=  null)
 {
 var strMemo = objTeachingTimeDistributionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeachingTimeDistribution.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingTimeDistribution.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objTeachingTimeDistributionEN.mId); 
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
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("TeachingTimeDistribution_Delete", values);
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
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
//删除TeachingTimeDistribution本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachingTimeDistribution where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTeachingTimeDistribution(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
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
//删除TeachingTimeDistribution本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachingTimeDistribution where mId in (" + strKeyList + ")";
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
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
//删除TeachingTimeDistribution本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachingTimeDistribution where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTeachingTimeDistribution(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTeachingTimeDistributionDA: DelTeachingTimeDistribution)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeachingTimeDistribution where " + strCondition ;
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
public bool DelTeachingTimeDistributionWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTeachingTimeDistributionDA: DelTeachingTimeDistributionWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeachingTimeDistribution where " + strCondition ;
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
 /// <param name = "objTeachingTimeDistributionENS">源对象</param>
 /// <param name = "objTeachingTimeDistributionENT">目标对象</param>
public void CopyTo(clsTeachingTimeDistributionEN objTeachingTimeDistributionENS, clsTeachingTimeDistributionEN objTeachingTimeDistributionENT)
{
objTeachingTimeDistributionENT.mId = objTeachingTimeDistributionENS.mId; //mId
objTeachingTimeDistributionENT.FuncModuleId = objTeachingTimeDistributionENS.FuncModuleId; //功能模块Id
objTeachingTimeDistributionENT.IdMicroteachCase = objTeachingTimeDistributionENS.IdMicroteachCase; //微格教学案例流水号
objTeachingTimeDistributionENT.CaseName = objTeachingTimeDistributionENS.CaseName; //案例名称
objTeachingTimeDistributionENT.OwnerId = objTeachingTimeDistributionENS.OwnerId; //拥有者Id
objTeachingTimeDistributionENT.TeachingActivityTypeId = objTeachingTimeDistributionENS.TeachingActivityTypeId; //教学活动类型Id
objTeachingTimeDistributionENT.UseTime = objTeachingTimeDistributionENS.UseTime; //使用时间s
objTeachingTimeDistributionENT.TimePercent = objTeachingTimeDistributionENS.TimePercent; //时间比例
objTeachingTimeDistributionENT.TimeLengthOfVideo = objTeachingTimeDistributionENS.TimeLengthOfVideo; //视频时长
objTeachingTimeDistributionENT.TeachingTimeDistributionDetailMainTypeId = objTeachingTimeDistributionENS.TeachingTimeDistributionDetailMainTypeId; //教学时间分布主类型Id
objTeachingTimeDistributionENT.TimeLengthPercent = objTeachingTimeDistributionENS.TimeLengthPercent; //时长和占总视频时长百分比
objTeachingTimeDistributionENT.UseMedia = objTeachingTimeDistributionENS.UseMedia; //使用媒体
objTeachingTimeDistributionENT.UpdDate = objTeachingTimeDistributionENS.UpdDate; //修改日期
objTeachingTimeDistributionENT.UpdUserId = objTeachingTimeDistributionENS.UpdUserId; //修改用户Id
objTeachingTimeDistributionENT.Memo = objTeachingTimeDistributionENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objTeachingTimeDistributionEN.FuncModuleId, conTeachingTimeDistribution.FuncModuleId);
clsCheckSql.CheckFieldNotNull(objTeachingTimeDistributionEN.IdMicroteachCase, conTeachingTimeDistribution.IdMicroteachCase);
clsCheckSql.CheckFieldNotNull(objTeachingTimeDistributionEN.TeachingActivityTypeId, conTeachingTimeDistribution.TeachingActivityTypeId);
clsCheckSql.CheckFieldNotNull(objTeachingTimeDistributionEN.UseTime, conTeachingTimeDistribution.UseTime);
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.FuncModuleId, 4, conTeachingTimeDistribution.FuncModuleId);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.IdMicroteachCase, 8, conTeachingTimeDistribution.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.CaseName, 100, conTeachingTimeDistribution.CaseName);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.OwnerId, 20, conTeachingTimeDistribution.OwnerId);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.TeachingActivityTypeId, 2, conTeachingTimeDistribution.TeachingActivityTypeId);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId, 4, conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.UseMedia, 30, conTeachingTimeDistribution.UseMedia);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.UpdDate, 20, conTeachingTimeDistribution.UpdDate);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.UpdUserId, 20, conTeachingTimeDistribution.UpdUserId);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.Memo, 1000, conTeachingTimeDistribution.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objTeachingTimeDistributionEN.TeachingActivityTypeId, 2, conTeachingTimeDistribution.TeachingActivityTypeId);
 objTeachingTimeDistributionEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.FuncModuleId, 4, conTeachingTimeDistribution.FuncModuleId);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.IdMicroteachCase, 8, conTeachingTimeDistribution.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.CaseName, 100, conTeachingTimeDistribution.CaseName);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.OwnerId, 20, conTeachingTimeDistribution.OwnerId);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.TeachingActivityTypeId, 2, conTeachingTimeDistribution.TeachingActivityTypeId);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId, 4, conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.UseMedia, 30, conTeachingTimeDistribution.UseMedia);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.UpdDate, 20, conTeachingTimeDistribution.UpdDate);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.UpdUserId, 20, conTeachingTimeDistribution.UpdUserId);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.Memo, 1000, conTeachingTimeDistribution.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTeachingTimeDistributionEN.TeachingActivityTypeId, 2, conTeachingTimeDistribution.TeachingActivityTypeId);
 objTeachingTimeDistributionEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.FuncModuleId, 4, conTeachingTimeDistribution.FuncModuleId);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.IdMicroteachCase, 8, conTeachingTimeDistribution.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.CaseName, 100, conTeachingTimeDistribution.CaseName);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.OwnerId, 20, conTeachingTimeDistribution.OwnerId);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.TeachingActivityTypeId, 2, conTeachingTimeDistribution.TeachingActivityTypeId);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId, 4, conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.UseMedia, 30, conTeachingTimeDistribution.UseMedia);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.UpdDate, 20, conTeachingTimeDistribution.UpdDate);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.UpdUserId, 20, conTeachingTimeDistribution.UpdUserId);
clsCheckSql.CheckFieldLen(objTeachingTimeDistributionEN.Memo, 1000, conTeachingTimeDistribution.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTeachingTimeDistributionEN.FuncModuleId, conTeachingTimeDistribution.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objTeachingTimeDistributionEN.IdMicroteachCase, conTeachingTimeDistribution.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objTeachingTimeDistributionEN.CaseName, conTeachingTimeDistribution.CaseName);
clsCheckSql.CheckSqlInjection4Field(objTeachingTimeDistributionEN.OwnerId, conTeachingTimeDistribution.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objTeachingTimeDistributionEN.TeachingActivityTypeId, conTeachingTimeDistribution.TeachingActivityTypeId);
clsCheckSql.CheckSqlInjection4Field(objTeachingTimeDistributionEN.TeachingTimeDistributionDetailMainTypeId, conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId);
clsCheckSql.CheckSqlInjection4Field(objTeachingTimeDistributionEN.UseMedia, conTeachingTimeDistribution.UseMedia);
clsCheckSql.CheckSqlInjection4Field(objTeachingTimeDistributionEN.UpdDate, conTeachingTimeDistribution.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objTeachingTimeDistributionEN.UpdUserId, conTeachingTimeDistribution.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objTeachingTimeDistributionEN.Memo, conTeachingTimeDistribution.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTeachingTimeDistributionEN.TeachingActivityTypeId, 2, conTeachingTimeDistribution.TeachingActivityTypeId);
 objTeachingTimeDistributionEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--TeachingTimeDistribution(教学时间分布),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTeachingTimeDistributionEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsTeachingTimeDistributionEN objTeachingTimeDistributionEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncModuleId = '{0}'", objTeachingTimeDistributionEN.FuncModuleId);
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objTeachingTimeDistributionEN.IdMicroteachCase);
 if (objTeachingTimeDistributionEN.OwnerId == null)
{
 sbCondition.AppendFormat(" and OwnerId is null");
}
else
{
 sbCondition.AppendFormat(" and OwnerId = '{0}'", objTeachingTimeDistributionEN.OwnerId);
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
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
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
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
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
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeachingTimeDistributionEN._CurrTabName);
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
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeachingTimeDistributionEN._CurrTabName, strCondition);
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
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
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
 objSQL = clsTeachingTimeDistributionDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}