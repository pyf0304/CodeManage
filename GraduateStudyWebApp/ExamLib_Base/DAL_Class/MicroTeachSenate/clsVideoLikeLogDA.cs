
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsVideoLikeLogDA
 表名:VideoLikeLog(01120291)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:56
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 视频点赞日志(VideoLikeLog)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsVideoLikeLogDA : clsCommBase4DA
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
 return clsVideoLikeLogEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsVideoLikeLogEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsVideoLikeLogEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsVideoLikeLogEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsVideoLikeLogEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsVideoLikeLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from VideoLikeLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_VideoLikeLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsVideoLikeLogDA: GetDataTable_VideoLikeLog)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from VideoLikeLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsVideoLikeLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsVideoLikeLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from VideoLikeLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsVideoLikeLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsVideoLikeLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from VideoLikeLog where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from VideoLikeLog where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsVideoLikeLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from VideoLikeLog where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsVideoLikeLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} VideoLikeLog.* from VideoLikeLog Left Join {1} on {2} where {3} and VideoLikeLog.IdVideoLikeLog not in (Select top {5} VideoLikeLog.IdVideoLikeLog from VideoLikeLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from VideoLikeLog where {1} and IdVideoLikeLog not in (Select top {2} IdVideoLikeLog from VideoLikeLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from VideoLikeLog where {1} and IdVideoLikeLog not in (Select top {3} IdVideoLikeLog from VideoLikeLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsVideoLikeLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} VideoLikeLog.* from VideoLikeLog Left Join {1} on {2} where {3} and VideoLikeLog.IdVideoLikeLog not in (Select top {5} VideoLikeLog.IdVideoLikeLog from VideoLikeLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from VideoLikeLog where {1} and IdVideoLikeLog not in (Select top {2} IdVideoLikeLog from VideoLikeLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from VideoLikeLog where {1} and IdVideoLikeLog not in (Select top {3} IdVideoLikeLog from VideoLikeLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsVideoLikeLogEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsVideoLikeLogDA:GetObjLst)", objException.Message));
}
List<clsVideoLikeLogEN> arrObjLst = new List<clsVideoLikeLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from VideoLikeLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLikeLogEN objVideoLikeLogEN = new clsVideoLikeLogEN();
try
{
objVideoLikeLogEN.IdVideoLikeLog = TransNullToInt(objRow[conVideoLikeLog.IdVideoLikeLog].ToString().Trim()); //视频点赞日志流水号
objVideoLikeLogEN.FuncModuleId = objRow[conVideoLikeLog.FuncModuleId].ToString().Trim(); //功能模块Id
objVideoLikeLogEN.UserId = objRow[conVideoLikeLog.UserId].ToString().Trim(); //用户ID
objVideoLikeLogEN.IdCase = objRow[conVideoLikeLog.IdCase].ToString().Trim(); //案例流水号
objVideoLikeLogEN.LikeDate = objRow[conVideoLikeLog.LikeDate].ToString().Trim(); //点赞日期
objVideoLikeLogEN.LikeDegree = objRow[conVideoLikeLog.LikeDegree] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLikeLog.LikeDegree].ToString().Trim()); //点赞度
objVideoLikeLogEN.Memo = objRow[conVideoLikeLog.Memo] == DBNull.Value ? null : objRow[conVideoLikeLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsVideoLikeLogDA: GetObjLst)", objException.Message));
}
objVideoLikeLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objVideoLikeLogEN);
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
public List<clsVideoLikeLogEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsVideoLikeLogDA:GetObjLstByTabName)", objException.Message));
}
List<clsVideoLikeLogEN> arrObjLst = new List<clsVideoLikeLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLikeLogEN objVideoLikeLogEN = new clsVideoLikeLogEN();
try
{
objVideoLikeLogEN.IdVideoLikeLog = TransNullToInt(objRow[conVideoLikeLog.IdVideoLikeLog].ToString().Trim()); //视频点赞日志流水号
objVideoLikeLogEN.FuncModuleId = objRow[conVideoLikeLog.FuncModuleId].ToString().Trim(); //功能模块Id
objVideoLikeLogEN.UserId = objRow[conVideoLikeLog.UserId].ToString().Trim(); //用户ID
objVideoLikeLogEN.IdCase = objRow[conVideoLikeLog.IdCase].ToString().Trim(); //案例流水号
objVideoLikeLogEN.LikeDate = objRow[conVideoLikeLog.LikeDate].ToString().Trim(); //点赞日期
objVideoLikeLogEN.LikeDegree = objRow[conVideoLikeLog.LikeDegree] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLikeLog.LikeDegree].ToString().Trim()); //点赞度
objVideoLikeLogEN.Memo = objRow[conVideoLikeLog.Memo] == DBNull.Value ? null : objRow[conVideoLikeLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsVideoLikeLogDA: GetObjLst)", objException.Message));
}
objVideoLikeLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objVideoLikeLogEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetVideoLikeLog(ref clsVideoLikeLogEN objVideoLikeLogEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from VideoLikeLog where IdVideoLikeLog = " + ""+ objVideoLikeLogEN.IdVideoLikeLog+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objVideoLikeLogEN.IdVideoLikeLog = TransNullToInt(objDT.Rows[0][conVideoLikeLog.IdVideoLikeLog].ToString().Trim()); //视频点赞日志流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objVideoLikeLogEN.FuncModuleId = objDT.Rows[0][conVideoLikeLog.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objVideoLikeLogEN.UserId = objDT.Rows[0][conVideoLikeLog.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objVideoLikeLogEN.IdCase = objDT.Rows[0][conVideoLikeLog.IdCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objVideoLikeLogEN.LikeDate = objDT.Rows[0][conVideoLikeLog.LikeDate].ToString().Trim(); //点赞日期(字段类型:varchar,字段长度:20,是否可空:False)
 objVideoLikeLogEN.LikeDegree = TransNullToInt(objDT.Rows[0][conVideoLikeLog.LikeDegree].ToString().Trim()); //点赞度(字段类型:int,字段长度:4,是否可空:True)
 objVideoLikeLogEN.Memo = objDT.Rows[0][conVideoLikeLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsVideoLikeLogDA: GetVideoLikeLog)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdVideoLikeLog">表关键字</param>
 /// <returns>表对象</returns>
public clsVideoLikeLogEN GetObjByIdVideoLikeLog(long lngIdVideoLikeLog)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from VideoLikeLog where IdVideoLikeLog = " + ""+ lngIdVideoLikeLog+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsVideoLikeLogEN objVideoLikeLogEN = new clsVideoLikeLogEN();
try
{
 objVideoLikeLogEN.IdVideoLikeLog = Int32.Parse(objRow[conVideoLikeLog.IdVideoLikeLog].ToString().Trim()); //视频点赞日志流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objVideoLikeLogEN.FuncModuleId = objRow[conVideoLikeLog.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objVideoLikeLogEN.UserId = objRow[conVideoLikeLog.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objVideoLikeLogEN.IdCase = objRow[conVideoLikeLog.IdCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objVideoLikeLogEN.LikeDate = objRow[conVideoLikeLog.LikeDate].ToString().Trim(); //点赞日期(字段类型:varchar,字段长度:20,是否可空:False)
 objVideoLikeLogEN.LikeDegree = objRow[conVideoLikeLog.LikeDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLikeLog.LikeDegree].ToString().Trim()); //点赞度(字段类型:int,字段长度:4,是否可空:True)
 objVideoLikeLogEN.Memo = objRow[conVideoLikeLog.Memo] == DBNull.Value ? null : objRow[conVideoLikeLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsVideoLikeLogDA: GetObjByIdVideoLikeLog)", objException.Message));
}
return objVideoLikeLogEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsVideoLikeLogEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsVideoLikeLogDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from VideoLikeLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsVideoLikeLogEN objVideoLikeLogEN = new clsVideoLikeLogEN()
{
IdVideoLikeLog = TransNullToInt(objRow[conVideoLikeLog.IdVideoLikeLog].ToString().Trim()), //视频点赞日志流水号
FuncModuleId = objRow[conVideoLikeLog.FuncModuleId].ToString().Trim(), //功能模块Id
UserId = objRow[conVideoLikeLog.UserId].ToString().Trim(), //用户ID
IdCase = objRow[conVideoLikeLog.IdCase].ToString().Trim(), //案例流水号
LikeDate = objRow[conVideoLikeLog.LikeDate].ToString().Trim(), //点赞日期
LikeDegree = objRow[conVideoLikeLog.LikeDegree] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLikeLog.LikeDegree].ToString().Trim()), //点赞度
Memo = objRow[conVideoLikeLog.Memo] == DBNull.Value ? null : objRow[conVideoLikeLog.Memo].ToString().Trim() //备注
};
objVideoLikeLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objVideoLikeLogEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsVideoLikeLogDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsVideoLikeLogEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsVideoLikeLogEN objVideoLikeLogEN = new clsVideoLikeLogEN();
try
{
objVideoLikeLogEN.IdVideoLikeLog = TransNullToInt(objRow[conVideoLikeLog.IdVideoLikeLog].ToString().Trim()); //视频点赞日志流水号
objVideoLikeLogEN.FuncModuleId = objRow[conVideoLikeLog.FuncModuleId].ToString().Trim(); //功能模块Id
objVideoLikeLogEN.UserId = objRow[conVideoLikeLog.UserId].ToString().Trim(); //用户ID
objVideoLikeLogEN.IdCase = objRow[conVideoLikeLog.IdCase].ToString().Trim(); //案例流水号
objVideoLikeLogEN.LikeDate = objRow[conVideoLikeLog.LikeDate].ToString().Trim(); //点赞日期
objVideoLikeLogEN.LikeDegree = objRow[conVideoLikeLog.LikeDegree] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLikeLog.LikeDegree].ToString().Trim()); //点赞度
objVideoLikeLogEN.Memo = objRow[conVideoLikeLog.Memo] == DBNull.Value ? null : objRow[conVideoLikeLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsVideoLikeLogDA: GetObjByDataRowVideoLikeLog)", objException.Message));
}
objVideoLikeLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objVideoLikeLogEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsVideoLikeLogEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsVideoLikeLogEN objVideoLikeLogEN = new clsVideoLikeLogEN();
try
{
objVideoLikeLogEN.IdVideoLikeLog = TransNullToInt(objRow[conVideoLikeLog.IdVideoLikeLog].ToString().Trim()); //视频点赞日志流水号
objVideoLikeLogEN.FuncModuleId = objRow[conVideoLikeLog.FuncModuleId].ToString().Trim(); //功能模块Id
objVideoLikeLogEN.UserId = objRow[conVideoLikeLog.UserId].ToString().Trim(); //用户ID
objVideoLikeLogEN.IdCase = objRow[conVideoLikeLog.IdCase].ToString().Trim(); //案例流水号
objVideoLikeLogEN.LikeDate = objRow[conVideoLikeLog.LikeDate].ToString().Trim(); //点赞日期
objVideoLikeLogEN.LikeDegree = objRow[conVideoLikeLog.LikeDegree] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conVideoLikeLog.LikeDegree].ToString().Trim()); //点赞度
objVideoLikeLogEN.Memo = objRow[conVideoLikeLog.Memo] == DBNull.Value ? null : objRow[conVideoLikeLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsVideoLikeLogDA: GetObjByDataRow)", objException.Message));
}
objVideoLikeLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objVideoLikeLogEN;
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
objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsVideoLikeLogEN._CurrTabName, conVideoLikeLog.IdVideoLikeLog, 8, "");
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
objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsVideoLikeLogEN._CurrTabName, conVideoLikeLog.IdVideoLikeLog, 8, strPrefix);
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
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdVideoLikeLog from VideoLikeLog where " + strCondition;
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
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdVideoLikeLog from VideoLikeLog where " + strCondition;
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
 /// <param name = "lngIdVideoLikeLog">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdVideoLikeLog)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("VideoLikeLog", "IdVideoLikeLog = " + ""+ lngIdVideoLikeLog+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsVideoLikeLogDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("VideoLikeLog", strCondition))
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
objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("VideoLikeLog");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsVideoLikeLogEN objVideoLikeLogEN)
 {
 if (objVideoLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objVideoLikeLogEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from VideoLikeLog where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "VideoLikeLog");
objRow = objDS.Tables["VideoLikeLog"].NewRow();
objRow[conVideoLikeLog.FuncModuleId] = objVideoLikeLogEN.FuncModuleId; //功能模块Id
objRow[conVideoLikeLog.UserId] = objVideoLikeLogEN.UserId; //用户ID
objRow[conVideoLikeLog.IdCase] = objVideoLikeLogEN.IdCase; //案例流水号
objRow[conVideoLikeLog.LikeDate] = objVideoLikeLogEN.LikeDate; //点赞日期
objRow[conVideoLikeLog.LikeDegree] = objVideoLikeLogEN.LikeDegree; //点赞度
 if (objVideoLikeLogEN.Memo !=  "")
 {
objRow[conVideoLikeLog.Memo] = objVideoLikeLogEN.Memo; //备注
 }
objDS.Tables[clsVideoLikeLogEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsVideoLikeLogEN._CurrTabName);
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
 /// <param name = "objVideoLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsVideoLikeLogEN objVideoLikeLogEN)
{
 if (objVideoLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objVideoLikeLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objVideoLikeLogEN.FuncModuleId  ==  "")
 {
 objVideoLikeLogEN.FuncModuleId = null;
 }
 if (objVideoLikeLogEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.FuncModuleId);
 var strFuncModuleId = objVideoLikeLogEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objVideoLikeLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.UserId);
 var strUserId = objVideoLikeLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objVideoLikeLogEN.IdCase !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.IdCase);
 var strIdCase = objVideoLikeLogEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCase + "'");
 }
 
 if (objVideoLikeLogEN.LikeDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.LikeDate);
 var strLikeDate = objVideoLikeLogEN.LikeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLikeDate + "'");
 }
 
 if (objVideoLikeLogEN.LikeDegree !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.LikeDegree);
 arrValueListForInsert.Add(objVideoLikeLogEN.LikeDegree.ToString());
 }
 
 if (objVideoLikeLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.Memo);
 var strMemo = objVideoLikeLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into VideoLikeLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsVideoLikeLogEN objVideoLikeLogEN)
{
 if (objVideoLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objVideoLikeLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objVideoLikeLogEN.FuncModuleId  ==  "")
 {
 objVideoLikeLogEN.FuncModuleId = null;
 }
 if (objVideoLikeLogEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.FuncModuleId);
 var strFuncModuleId = objVideoLikeLogEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objVideoLikeLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.UserId);
 var strUserId = objVideoLikeLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objVideoLikeLogEN.IdCase !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.IdCase);
 var strIdCase = objVideoLikeLogEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCase + "'");
 }
 
 if (objVideoLikeLogEN.LikeDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.LikeDate);
 var strLikeDate = objVideoLikeLogEN.LikeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLikeDate + "'");
 }
 
 if (objVideoLikeLogEN.LikeDegree !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.LikeDegree);
 arrValueListForInsert.Add(objVideoLikeLogEN.LikeDegree.ToString());
 }
 
 if (objVideoLikeLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.Memo);
 var strMemo = objVideoLikeLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into VideoLikeLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsVideoLikeLogEN objVideoLikeLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objVideoLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objVideoLikeLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objVideoLikeLogEN.FuncModuleId  ==  "")
 {
 objVideoLikeLogEN.FuncModuleId = null;
 }
 if (objVideoLikeLogEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.FuncModuleId);
 var strFuncModuleId = objVideoLikeLogEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objVideoLikeLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.UserId);
 var strUserId = objVideoLikeLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objVideoLikeLogEN.IdCase !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.IdCase);
 var strIdCase = objVideoLikeLogEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCase + "'");
 }
 
 if (objVideoLikeLogEN.LikeDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.LikeDate);
 var strLikeDate = objVideoLikeLogEN.LikeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLikeDate + "'");
 }
 
 if (objVideoLikeLogEN.LikeDegree !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.LikeDegree);
 arrValueListForInsert.Add(objVideoLikeLogEN.LikeDegree.ToString());
 }
 
 if (objVideoLikeLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.Memo);
 var strMemo = objVideoLikeLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into VideoLikeLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsVideoLikeLogEN objVideoLikeLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objVideoLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objVideoLikeLogEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objVideoLikeLogEN.FuncModuleId  ==  "")
 {
 objVideoLikeLogEN.FuncModuleId = null;
 }
 if (objVideoLikeLogEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.FuncModuleId);
 var strFuncModuleId = objVideoLikeLogEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objVideoLikeLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.UserId);
 var strUserId = objVideoLikeLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objVideoLikeLogEN.IdCase !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.IdCase);
 var strIdCase = objVideoLikeLogEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCase + "'");
 }
 
 if (objVideoLikeLogEN.LikeDate !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.LikeDate);
 var strLikeDate = objVideoLikeLogEN.LikeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLikeDate + "'");
 }
 
 if (objVideoLikeLogEN.LikeDegree !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.LikeDegree);
 arrValueListForInsert.Add(objVideoLikeLogEN.LikeDegree.ToString());
 }
 
 if (objVideoLikeLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conVideoLikeLog.Memo);
 var strMemo = objVideoLikeLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into VideoLikeLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewVideoLikeLogs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from VideoLikeLog where IdVideoLikeLog = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "VideoLikeLog");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdVideoLikeLog = TransNullToInt(oRow[conVideoLikeLog.IdVideoLikeLog].ToString().Trim());
if (IsExist(lngIdVideoLikeLog))
{
 string strResult = "关键字变量值为:" + string.Format("IdVideoLikeLog = {0}", lngIdVideoLikeLog) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsVideoLikeLogEN._CurrTabName ].NewRow();
objRow[conVideoLikeLog.FuncModuleId] = oRow[conVideoLikeLog.FuncModuleId].ToString().Trim(); //功能模块Id
objRow[conVideoLikeLog.UserId] = oRow[conVideoLikeLog.UserId].ToString().Trim(); //用户ID
objRow[conVideoLikeLog.IdCase] = oRow[conVideoLikeLog.IdCase].ToString().Trim(); //案例流水号
objRow[conVideoLikeLog.LikeDate] = oRow[conVideoLikeLog.LikeDate].ToString().Trim(); //点赞日期
objRow[conVideoLikeLog.LikeDegree] = oRow[conVideoLikeLog.LikeDegree].ToString().Trim(); //点赞度
objRow[conVideoLikeLog.Memo] = oRow[conVideoLikeLog.Memo].ToString().Trim(); //备注
 objDS.Tables[clsVideoLikeLogEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsVideoLikeLogEN._CurrTabName);
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
 /// <param name = "objVideoLikeLogEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsVideoLikeLogEN objVideoLikeLogEN)
{
 if (objVideoLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objVideoLikeLogEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from VideoLikeLog where IdVideoLikeLog = " + ""+ objVideoLikeLogEN.IdVideoLikeLog+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsVideoLikeLogEN._CurrTabName);
if (objDS.Tables[clsVideoLikeLogEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdVideoLikeLog = " + ""+ objVideoLikeLogEN.IdVideoLikeLog+"");
return false;
}
objRow = objDS.Tables[clsVideoLikeLogEN._CurrTabName].Rows[0];
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.FuncModuleId))
 {
objRow[conVideoLikeLog.FuncModuleId] = objVideoLikeLogEN.FuncModuleId; //功能模块Id
 }
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.UserId))
 {
objRow[conVideoLikeLog.UserId] = objVideoLikeLogEN.UserId; //用户ID
 }
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.IdCase))
 {
objRow[conVideoLikeLog.IdCase] = objVideoLikeLogEN.IdCase; //案例流水号
 }
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.LikeDate))
 {
objRow[conVideoLikeLog.LikeDate] = objVideoLikeLogEN.LikeDate; //点赞日期
 }
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.LikeDegree))
 {
objRow[conVideoLikeLog.LikeDegree] = objVideoLikeLogEN.LikeDegree; //点赞度
 }
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.Memo))
 {
objRow[conVideoLikeLog.Memo] = objVideoLikeLogEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsVideoLikeLogEN._CurrTabName);
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
 /// <param name = "objVideoLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsVideoLikeLogEN objVideoLikeLogEN)
{
 if (objVideoLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objVideoLikeLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update VideoLikeLog Set ");
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.FuncModuleId))
 {
 if (objVideoLikeLogEN.FuncModuleId  ==  "")
 {
 objVideoLikeLogEN.FuncModuleId = null;
 }
 if (objVideoLikeLogEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objVideoLikeLogEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conVideoLikeLog.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLikeLog.FuncModuleId); //功能模块Id
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.UserId))
 {
 if (objVideoLikeLogEN.UserId !=  null)
 {
 var strUserId = objVideoLikeLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conVideoLikeLog.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLikeLog.UserId); //用户ID
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.IdCase))
 {
 if (objVideoLikeLogEN.IdCase !=  null)
 {
 var strIdCase = objVideoLikeLogEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCase, conVideoLikeLog.IdCase); //案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLikeLog.IdCase); //案例流水号
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.LikeDate))
 {
 if (objVideoLikeLogEN.LikeDate !=  null)
 {
 var strLikeDate = objVideoLikeLogEN.LikeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLikeDate, conVideoLikeLog.LikeDate); //点赞日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLikeLog.LikeDate); //点赞日期
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.LikeDegree))
 {
 if (objVideoLikeLogEN.LikeDegree !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoLikeLogEN.LikeDegree, conVideoLikeLog.LikeDegree); //点赞度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLikeLog.LikeDegree); //点赞度
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.Memo))
 {
 if (objVideoLikeLogEN.Memo !=  null)
 {
 var strMemo = objVideoLikeLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conVideoLikeLog.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLikeLog.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdVideoLikeLog = {0}", objVideoLikeLogEN.IdVideoLikeLog); 
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
 /// <param name = "objVideoLikeLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsVideoLikeLogEN objVideoLikeLogEN, string strCondition)
{
 if (objVideoLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objVideoLikeLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update VideoLikeLog Set ");
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.FuncModuleId))
 {
 if (objVideoLikeLogEN.FuncModuleId  ==  "")
 {
 objVideoLikeLogEN.FuncModuleId = null;
 }
 if (objVideoLikeLogEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objVideoLikeLogEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.UserId))
 {
 if (objVideoLikeLogEN.UserId !=  null)
 {
 var strUserId = objVideoLikeLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.IdCase))
 {
 if (objVideoLikeLogEN.IdCase !=  null)
 {
 var strIdCase = objVideoLikeLogEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCase = '{0}',", strIdCase); //案例流水号
 }
 else
 {
 sbSQL.Append(" IdCase = null,"); //案例流水号
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.LikeDate))
 {
 if (objVideoLikeLogEN.LikeDate !=  null)
 {
 var strLikeDate = objVideoLikeLogEN.LikeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LikeDate = '{0}',", strLikeDate); //点赞日期
 }
 else
 {
 sbSQL.Append(" LikeDate = null,"); //点赞日期
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.LikeDegree))
 {
 sbSQL.AppendFormat(" LikeDegree = {0},", objVideoLikeLogEN.LikeDegree); //点赞度
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.Memo))
 {
 if (objVideoLikeLogEN.Memo !=  null)
 {
 var strMemo = objVideoLikeLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objVideoLikeLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsVideoLikeLogEN objVideoLikeLogEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objVideoLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objVideoLikeLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update VideoLikeLog Set ");
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.FuncModuleId))
 {
 if (objVideoLikeLogEN.FuncModuleId  ==  "")
 {
 objVideoLikeLogEN.FuncModuleId = null;
 }
 if (objVideoLikeLogEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objVideoLikeLogEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.UserId))
 {
 if (objVideoLikeLogEN.UserId !=  null)
 {
 var strUserId = objVideoLikeLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.IdCase))
 {
 if (objVideoLikeLogEN.IdCase !=  null)
 {
 var strIdCase = objVideoLikeLogEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCase = '{0}',", strIdCase); //案例流水号
 }
 else
 {
 sbSQL.Append(" IdCase = null,"); //案例流水号
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.LikeDate))
 {
 if (objVideoLikeLogEN.LikeDate !=  null)
 {
 var strLikeDate = objVideoLikeLogEN.LikeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LikeDate = '{0}',", strLikeDate); //点赞日期
 }
 else
 {
 sbSQL.Append(" LikeDate = null,"); //点赞日期
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.LikeDegree))
 {
 sbSQL.AppendFormat(" LikeDegree = {0},", objVideoLikeLogEN.LikeDegree); //点赞度
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.Memo))
 {
 if (objVideoLikeLogEN.Memo !=  null)
 {
 var strMemo = objVideoLikeLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objVideoLikeLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsVideoLikeLogEN objVideoLikeLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objVideoLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objVideoLikeLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update VideoLikeLog Set ");
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.FuncModuleId))
 {
 if (objVideoLikeLogEN.FuncModuleId  ==  "")
 {
 objVideoLikeLogEN.FuncModuleId = null;
 }
 if (objVideoLikeLogEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objVideoLikeLogEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conVideoLikeLog.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLikeLog.FuncModuleId); //功能模块Id
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.UserId))
 {
 if (objVideoLikeLogEN.UserId !=  null)
 {
 var strUserId = objVideoLikeLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conVideoLikeLog.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLikeLog.UserId); //用户ID
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.IdCase))
 {
 if (objVideoLikeLogEN.IdCase !=  null)
 {
 var strIdCase = objVideoLikeLogEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCase, conVideoLikeLog.IdCase); //案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLikeLog.IdCase); //案例流水号
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.LikeDate))
 {
 if (objVideoLikeLogEN.LikeDate !=  null)
 {
 var strLikeDate = objVideoLikeLogEN.LikeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLikeDate, conVideoLikeLog.LikeDate); //点赞日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLikeLog.LikeDate); //点赞日期
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.LikeDegree))
 {
 if (objVideoLikeLogEN.LikeDegree !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objVideoLikeLogEN.LikeDegree, conVideoLikeLog.LikeDegree); //点赞度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLikeLog.LikeDegree); //点赞度
 }
 }
 
 if (objVideoLikeLogEN.IsUpdated(conVideoLikeLog.Memo))
 {
 if (objVideoLikeLogEN.Memo !=  null)
 {
 var strMemo = objVideoLikeLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conVideoLikeLog.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conVideoLikeLog.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdVideoLikeLog = {0}", objVideoLikeLogEN.IdVideoLikeLog); 
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
 /// <param name = "lngIdVideoLikeLog">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdVideoLikeLog) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdVideoLikeLog,
};
 objSQL.ExecSP("VideoLikeLog_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdVideoLikeLog">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdVideoLikeLog, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
//删除VideoLikeLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from VideoLikeLog where IdVideoLikeLog = " + ""+ lngIdVideoLikeLog+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelVideoLikeLog(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
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
//删除VideoLikeLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from VideoLikeLog where IdVideoLikeLog in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdVideoLikeLog">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdVideoLikeLog) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
//删除VideoLikeLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from VideoLikeLog where IdVideoLikeLog = " + ""+ lngIdVideoLikeLog+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelVideoLikeLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsVideoLikeLogDA: DelVideoLikeLog)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from VideoLikeLog where " + strCondition ;
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
public bool DelVideoLikeLogWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsVideoLikeLogDA: DelVideoLikeLogWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from VideoLikeLog where " + strCondition ;
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
 /// <param name = "objVideoLikeLogENS">源对象</param>
 /// <param name = "objVideoLikeLogENT">目标对象</param>
public void CopyTo(clsVideoLikeLogEN objVideoLikeLogENS, clsVideoLikeLogEN objVideoLikeLogENT)
{
objVideoLikeLogENT.IdVideoLikeLog = objVideoLikeLogENS.IdVideoLikeLog; //视频点赞日志流水号
objVideoLikeLogENT.FuncModuleId = objVideoLikeLogENS.FuncModuleId; //功能模块Id
objVideoLikeLogENT.UserId = objVideoLikeLogENS.UserId; //用户ID
objVideoLikeLogENT.IdCase = objVideoLikeLogENS.IdCase; //案例流水号
objVideoLikeLogENT.LikeDate = objVideoLikeLogENS.LikeDate; //点赞日期
objVideoLikeLogENT.LikeDegree = objVideoLikeLogENS.LikeDegree; //点赞度
objVideoLikeLogENT.Memo = objVideoLikeLogENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsVideoLikeLogEN objVideoLikeLogEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objVideoLikeLogEN.FuncModuleId, conVideoLikeLog.FuncModuleId);
clsCheckSql.CheckFieldNotNull(objVideoLikeLogEN.UserId, conVideoLikeLog.UserId);
clsCheckSql.CheckFieldNotNull(objVideoLikeLogEN.IdCase, conVideoLikeLog.IdCase);
clsCheckSql.CheckFieldNotNull(objVideoLikeLogEN.LikeDate, conVideoLikeLog.LikeDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objVideoLikeLogEN.FuncModuleId, 4, conVideoLikeLog.FuncModuleId);
clsCheckSql.CheckFieldLen(objVideoLikeLogEN.UserId, 18, conVideoLikeLog.UserId);
clsCheckSql.CheckFieldLen(objVideoLikeLogEN.IdCase, 8, conVideoLikeLog.IdCase);
clsCheckSql.CheckFieldLen(objVideoLikeLogEN.LikeDate, 20, conVideoLikeLog.LikeDate);
clsCheckSql.CheckFieldLen(objVideoLikeLogEN.Memo, 1000, conVideoLikeLog.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objVideoLikeLogEN.FuncModuleId, 4, conVideoLikeLog.FuncModuleId);
 objVideoLikeLogEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsVideoLikeLogEN objVideoLikeLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objVideoLikeLogEN.FuncModuleId, 4, conVideoLikeLog.FuncModuleId);
clsCheckSql.CheckFieldLen(objVideoLikeLogEN.UserId, 18, conVideoLikeLog.UserId);
clsCheckSql.CheckFieldLen(objVideoLikeLogEN.IdCase, 8, conVideoLikeLog.IdCase);
clsCheckSql.CheckFieldLen(objVideoLikeLogEN.LikeDate, 20, conVideoLikeLog.LikeDate);
clsCheckSql.CheckFieldLen(objVideoLikeLogEN.Memo, 1000, conVideoLikeLog.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objVideoLikeLogEN.FuncModuleId, 4, conVideoLikeLog.FuncModuleId);
 objVideoLikeLogEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsVideoLikeLogEN objVideoLikeLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objVideoLikeLogEN.FuncModuleId, 4, conVideoLikeLog.FuncModuleId);
clsCheckSql.CheckFieldLen(objVideoLikeLogEN.UserId, 18, conVideoLikeLog.UserId);
clsCheckSql.CheckFieldLen(objVideoLikeLogEN.IdCase, 8, conVideoLikeLog.IdCase);
clsCheckSql.CheckFieldLen(objVideoLikeLogEN.LikeDate, 20, conVideoLikeLog.LikeDate);
clsCheckSql.CheckFieldLen(objVideoLikeLogEN.Memo, 1000, conVideoLikeLog.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objVideoLikeLogEN.FuncModuleId, conVideoLikeLog.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objVideoLikeLogEN.UserId, conVideoLikeLog.UserId);
clsCheckSql.CheckSqlInjection4Field(objVideoLikeLogEN.IdCase, conVideoLikeLog.IdCase);
clsCheckSql.CheckSqlInjection4Field(objVideoLikeLogEN.LikeDate, conVideoLikeLog.LikeDate);
clsCheckSql.CheckSqlInjection4Field(objVideoLikeLogEN.Memo, conVideoLikeLog.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objVideoLikeLogEN.FuncModuleId, 4, conVideoLikeLog.FuncModuleId);
 objVideoLikeLogEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--VideoLikeLog(视频点赞日志),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsVideoLikeLogEN objVideoLikeLogEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdCase = '{0}'", objVideoLikeLogEN.IdCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objVideoLikeLogEN.UserId);
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
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
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
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
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
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsVideoLikeLogEN._CurrTabName);
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
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsVideoLikeLogEN._CurrTabName, strCondition);
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
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
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
 objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}