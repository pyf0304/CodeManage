
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachCaseRelaInfoDA
 表名:TeachCaseRelaInfo(01120513)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
 /// 案例相关信息(TeachCaseRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsTeachCaseRelaInfoDA : clsCommBase4DA
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
 return clsTeachCaseRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTeachCaseRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTeachCaseRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTeachCaseRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTeachCaseRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeachCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TeachCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTeachCaseRelaInfoDA: GetDataTable_TeachCaseRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeachCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeachCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTeachCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachCaseRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachCaseRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTeachCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TeachCaseRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTeachCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeachCaseRelaInfo.* from TeachCaseRelaInfo Left Join {1} on {2} where {3} and TeachCaseRelaInfo.IdTeachCaseRelaInfo not in (Select top {5} TeachCaseRelaInfo.IdTeachCaseRelaInfo from TeachCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachCaseRelaInfo where {1} and IdTeachCaseRelaInfo not in (Select top {2} IdTeachCaseRelaInfo from TeachCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachCaseRelaInfo where {1} and IdTeachCaseRelaInfo not in (Select top {3} IdTeachCaseRelaInfo from TeachCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTeachCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeachCaseRelaInfo.* from TeachCaseRelaInfo Left Join {1} on {2} where {3} and TeachCaseRelaInfo.IdTeachCaseRelaInfo not in (Select top {5} TeachCaseRelaInfo.IdTeachCaseRelaInfo from TeachCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachCaseRelaInfo where {1} and IdTeachCaseRelaInfo not in (Select top {2} IdTeachCaseRelaInfo from TeachCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachCaseRelaInfo where {1} and IdTeachCaseRelaInfo not in (Select top {3} IdTeachCaseRelaInfo from TeachCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsTeachCaseRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTeachCaseRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsTeachCaseRelaInfoEN> arrObjLst = new List<clsTeachCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeachCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN = new clsTeachCaseRelaInfoEN();
try
{
objTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = TransNullToInt(objRow[conTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objTeachCaseRelaInfoEN.IdTeachCase = objRow[conTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseRelaInfoEN.IdResource = objRow[conTeachCaseRelaInfo.IdResource] == DBNull.Value ? null : objRow[conTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[conTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[conTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objTeachCaseRelaInfoEN.BrowseCount = objRow[conTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseRelaInfoEN.Memo = objRow[conTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeachCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeachCaseRelaInfoEN);
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
public List<clsTeachCaseRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTeachCaseRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsTeachCaseRelaInfoEN> arrObjLst = new List<clsTeachCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN = new clsTeachCaseRelaInfoEN();
try
{
objTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = TransNullToInt(objRow[conTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objTeachCaseRelaInfoEN.IdTeachCase = objRow[conTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseRelaInfoEN.IdResource = objRow[conTeachCaseRelaInfo.IdResource] == DBNull.Value ? null : objRow[conTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[conTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[conTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objTeachCaseRelaInfoEN.BrowseCount = objRow[conTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseRelaInfoEN.Memo = objRow[conTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeachCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTeachCaseRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTeachCaseRelaInfo(ref clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeachCaseRelaInfo where IdTeachCaseRelaInfo = " + ""+ objTeachCaseRelaInfoEN.IdTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = TransNullToInt(objDT.Rows[0][conTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objTeachCaseRelaInfoEN.IdTeachCase = objDT.Rows[0][conTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachCaseRelaInfoEN.IdResource = objDT.Rows[0][conTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objDT.Rows[0][conTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objDT.Rows[0][conTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objTeachCaseRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][conTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objTeachCaseRelaInfoEN.Memo = objDT.Rows[0][conTeachCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTeachCaseRelaInfoDA: GetTeachCaseRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsTeachCaseRelaInfoEN GetObjByIdTeachCaseRelaInfo(long lngIdTeachCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeachCaseRelaInfo where IdTeachCaseRelaInfo = " + ""+ lngIdTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN = new clsTeachCaseRelaInfoEN();
try
{
 objTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = Int32.Parse(objRow[conTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objTeachCaseRelaInfoEN.IdTeachCase = objRow[conTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachCaseRelaInfoEN.IdResource = objRow[conTeachCaseRelaInfo.IdResource] == DBNull.Value ? null : objRow[conTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[conTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objTeachCaseRelaInfoEN.BrowseCount = objRow[conTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objTeachCaseRelaInfoEN.Memo = objRow[conTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conTeachCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTeachCaseRelaInfoDA: GetObjByIdTeachCaseRelaInfo)", objException.Message));
}
return objTeachCaseRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTeachCaseRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTeachCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeachCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN = new clsTeachCaseRelaInfoEN()
{
IdTeachCaseRelaInfo = TransNullToInt(objRow[conTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()), //案例相关信息流水号
IdTeachCase = objRow[conTeachCaseRelaInfo.IdTeachCase].ToString().Trim(), //案例流水号
IdResource = objRow[conTeachCaseRelaInfo.IdResource] == DBNull.Value ? null : objRow[conTeachCaseRelaInfo.IdResource].ToString().Trim(), //资源流水号
IdTeachCaseRelaInfoType = objRow[conTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(), //案例相关信息类型流水号
IsVisible = TransNullToBool(objRow[conTeachCaseRelaInfo.IsVisible].ToString().Trim()), //是否显示
BrowseCount = objRow[conTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCaseRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
Memo = objRow[conTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conTeachCaseRelaInfo.Memo].ToString().Trim() //备注
};
objTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachCaseRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTeachCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTeachCaseRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN = new clsTeachCaseRelaInfoEN();
try
{
objTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = TransNullToInt(objRow[conTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objTeachCaseRelaInfoEN.IdTeachCase = objRow[conTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseRelaInfoEN.IdResource = objRow[conTeachCaseRelaInfo.IdResource] == DBNull.Value ? null : objRow[conTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[conTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[conTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objTeachCaseRelaInfoEN.BrowseCount = objRow[conTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseRelaInfoEN.Memo = objRow[conTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTeachCaseRelaInfoDA: GetObjByDataRowTeachCaseRelaInfo)", objException.Message));
}
objTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachCaseRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTeachCaseRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN = new clsTeachCaseRelaInfoEN();
try
{
objTeachCaseRelaInfoEN.IdTeachCaseRelaInfo = TransNullToInt(objRow[conTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objTeachCaseRelaInfoEN.IdTeachCase = objRow[conTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseRelaInfoEN.IdResource = objRow[conTeachCaseRelaInfo.IdResource] == DBNull.Value ? null : objRow[conTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = objRow[conTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[conTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objTeachCaseRelaInfoEN.BrowseCount = objRow[conTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseRelaInfoEN.Memo = objRow[conTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTeachCaseRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachCaseRelaInfoEN;
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
objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeachCaseRelaInfoEN._CurrTabName, conTeachCaseRelaInfo.IdTeachCaseRelaInfo, 8, "");
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
objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeachCaseRelaInfoEN._CurrTabName, conTeachCaseRelaInfo.IdTeachCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdTeachCaseRelaInfo from TeachCaseRelaInfo where " + strCondition;
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
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdTeachCaseRelaInfo from TeachCaseRelaInfo where " + strCondition;
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
 /// <param name = "lngIdTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdTeachCaseRelaInfo)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeachCaseRelaInfo", "IdTeachCaseRelaInfo = " + ""+ lngIdTeachCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTeachCaseRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeachCaseRelaInfo", strCondition))
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
objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TeachCaseRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN)
 {
 if (objTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachCaseRelaInfoEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeachCaseRelaInfo where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeachCaseRelaInfo");
objRow = objDS.Tables["TeachCaseRelaInfo"].NewRow();
objRow[conTeachCaseRelaInfo.IdTeachCase] = objTeachCaseRelaInfoEN.IdTeachCase; //案例流水号
 if (objTeachCaseRelaInfoEN.IdResource !=  "")
 {
objRow[conTeachCaseRelaInfo.IdResource] = objTeachCaseRelaInfoEN.IdResource; //资源流水号
 }
objRow[conTeachCaseRelaInfo.IdTeachCaseRelaInfoType] = objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType; //案例相关信息类型流水号
objRow[conTeachCaseRelaInfo.IsVisible] = objTeachCaseRelaInfoEN.IsVisible; //是否显示
objRow[conTeachCaseRelaInfo.BrowseCount] = objTeachCaseRelaInfoEN.BrowseCount; //浏览次数
 if (objTeachCaseRelaInfoEN.Memo !=  "")
 {
objRow[conTeachCaseRelaInfo.Memo] = objTeachCaseRelaInfoEN.Memo; //备注
 }
objDS.Tables[clsTeachCaseRelaInfoEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTeachCaseRelaInfoEN._CurrTabName);
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
 /// <param name = "objTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN)
{
 if (objTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachCaseRelaInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTeachCaseRelaInfoEN.IdTeachCase  ==  "")
 {
 objTeachCaseRelaInfoEN.IdTeachCase = null;
 }
 if (objTeachCaseRelaInfoEN.IdTeachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.IdTeachCase);
 var strIdTeachCase = objTeachCaseRelaInfoEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachCase + "'");
 }
 
 if (objTeachCaseRelaInfoEN.IdResource  ==  "")
 {
 objTeachCaseRelaInfoEN.IdResource = null;
 }
 if (objTeachCaseRelaInfoEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.IdResource);
 var strIdResource = objTeachCaseRelaInfoEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 if (objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType  ==  "")
 {
 objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = null;
 }
 if (objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
 var strIdTeachCaseRelaInfoType = objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachCaseRelaInfoType + "'");
 }
 
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.IsVisible);
 arrValueListForInsert.Add("'" + (objTeachCaseRelaInfoEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objTeachCaseRelaInfoEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.BrowseCount);
 arrValueListForInsert.Add(objTeachCaseRelaInfoEN.BrowseCount.ToString());
 }
 
 if (objTeachCaseRelaInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.Memo);
 var strMemo = objTeachCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachCaseRelaInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN)
{
 if (objTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachCaseRelaInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTeachCaseRelaInfoEN.IdTeachCase  ==  "")
 {
 objTeachCaseRelaInfoEN.IdTeachCase = null;
 }
 if (objTeachCaseRelaInfoEN.IdTeachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.IdTeachCase);
 var strIdTeachCase = objTeachCaseRelaInfoEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachCase + "'");
 }
 
 if (objTeachCaseRelaInfoEN.IdResource  ==  "")
 {
 objTeachCaseRelaInfoEN.IdResource = null;
 }
 if (objTeachCaseRelaInfoEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.IdResource);
 var strIdResource = objTeachCaseRelaInfoEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 if (objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType  ==  "")
 {
 objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = null;
 }
 if (objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
 var strIdTeachCaseRelaInfoType = objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachCaseRelaInfoType + "'");
 }
 
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.IsVisible);
 arrValueListForInsert.Add("'" + (objTeachCaseRelaInfoEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objTeachCaseRelaInfoEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.BrowseCount);
 arrValueListForInsert.Add(objTeachCaseRelaInfoEN.BrowseCount.ToString());
 }
 
 if (objTeachCaseRelaInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.Memo);
 var strMemo = objTeachCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachCaseRelaInfo");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachCaseRelaInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTeachCaseRelaInfoEN.IdTeachCase  ==  "")
 {
 objTeachCaseRelaInfoEN.IdTeachCase = null;
 }
 if (objTeachCaseRelaInfoEN.IdTeachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.IdTeachCase);
 var strIdTeachCase = objTeachCaseRelaInfoEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachCase + "'");
 }
 
 if (objTeachCaseRelaInfoEN.IdResource  ==  "")
 {
 objTeachCaseRelaInfoEN.IdResource = null;
 }
 if (objTeachCaseRelaInfoEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.IdResource);
 var strIdResource = objTeachCaseRelaInfoEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 if (objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType  ==  "")
 {
 objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = null;
 }
 if (objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
 var strIdTeachCaseRelaInfoType = objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachCaseRelaInfoType + "'");
 }
 
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.IsVisible);
 arrValueListForInsert.Add("'" + (objTeachCaseRelaInfoEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objTeachCaseRelaInfoEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.BrowseCount);
 arrValueListForInsert.Add(objTeachCaseRelaInfoEN.BrowseCount.ToString());
 }
 
 if (objTeachCaseRelaInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.Memo);
 var strMemo = objTeachCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachCaseRelaInfo");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachCaseRelaInfoEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTeachCaseRelaInfoEN.IdTeachCase  ==  "")
 {
 objTeachCaseRelaInfoEN.IdTeachCase = null;
 }
 if (objTeachCaseRelaInfoEN.IdTeachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.IdTeachCase);
 var strIdTeachCase = objTeachCaseRelaInfoEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachCase + "'");
 }
 
 if (objTeachCaseRelaInfoEN.IdResource  ==  "")
 {
 objTeachCaseRelaInfoEN.IdResource = null;
 }
 if (objTeachCaseRelaInfoEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.IdResource);
 var strIdResource = objTeachCaseRelaInfoEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 if (objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType  ==  "")
 {
 objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = null;
 }
 if (objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
 var strIdTeachCaseRelaInfoType = objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachCaseRelaInfoType + "'");
 }
 
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.IsVisible);
 arrValueListForInsert.Add("'" + (objTeachCaseRelaInfoEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objTeachCaseRelaInfoEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.BrowseCount);
 arrValueListForInsert.Add(objTeachCaseRelaInfoEN.BrowseCount.ToString());
 }
 
 if (objTeachCaseRelaInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachCaseRelaInfo.Memo);
 var strMemo = objTeachCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachCaseRelaInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTeachCaseRelaInfos(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeachCaseRelaInfo where IdTeachCaseRelaInfo = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeachCaseRelaInfo");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdTeachCaseRelaInfo = TransNullToInt(oRow[conTeachCaseRelaInfo.IdTeachCaseRelaInfo].ToString().Trim());
if (IsExist(lngIdTeachCaseRelaInfo))
{
 string strResult = "关键字变量值为:" + string.Format("IdTeachCaseRelaInfo = {0}", lngIdTeachCaseRelaInfo) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTeachCaseRelaInfoEN._CurrTabName ].NewRow();
objRow[conTeachCaseRelaInfo.IdTeachCase] = oRow[conTeachCaseRelaInfo.IdTeachCase].ToString().Trim(); //案例流水号
objRow[conTeachCaseRelaInfo.IdResource] = oRow[conTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objRow[conTeachCaseRelaInfo.IdTeachCaseRelaInfoType] = oRow[conTeachCaseRelaInfo.IdTeachCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objRow[conTeachCaseRelaInfo.IsVisible] = oRow[conTeachCaseRelaInfo.IsVisible].ToString().Trim(); //是否显示
objRow[conTeachCaseRelaInfo.BrowseCount] = oRow[conTeachCaseRelaInfo.BrowseCount].ToString().Trim(); //浏览次数
objRow[conTeachCaseRelaInfo.Memo] = oRow[conTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
 objDS.Tables[clsTeachCaseRelaInfoEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTeachCaseRelaInfoEN._CurrTabName);
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
 /// <param name = "objTeachCaseRelaInfoEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN)
{
 if (objTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachCaseRelaInfoEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeachCaseRelaInfo where IdTeachCaseRelaInfo = " + ""+ objTeachCaseRelaInfoEN.IdTeachCaseRelaInfo+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTeachCaseRelaInfoEN._CurrTabName);
if (objDS.Tables[clsTeachCaseRelaInfoEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdTeachCaseRelaInfo = " + ""+ objTeachCaseRelaInfoEN.IdTeachCaseRelaInfo+"");
return false;
}
objRow = objDS.Tables[clsTeachCaseRelaInfoEN._CurrTabName].Rows[0];
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IdTeachCase))
 {
objRow[conTeachCaseRelaInfo.IdTeachCase] = objTeachCaseRelaInfoEN.IdTeachCase; //案例流水号
 }
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IdResource))
 {
objRow[conTeachCaseRelaInfo.IdResource] = objTeachCaseRelaInfoEN.IdResource; //资源流水号
 }
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IdTeachCaseRelaInfoType))
 {
objRow[conTeachCaseRelaInfo.IdTeachCaseRelaInfoType] = objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType; //案例相关信息类型流水号
 }
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IsVisible))
 {
objRow[conTeachCaseRelaInfo.IsVisible] = objTeachCaseRelaInfoEN.IsVisible; //是否显示
 }
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.BrowseCount))
 {
objRow[conTeachCaseRelaInfo.BrowseCount] = objTeachCaseRelaInfoEN.BrowseCount; //浏览次数
 }
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.Memo))
 {
objRow[conTeachCaseRelaInfo.Memo] = objTeachCaseRelaInfoEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsTeachCaseRelaInfoEN._CurrTabName);
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
 /// <param name = "objTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN)
{
 if (objTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachCaseRelaInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TeachCaseRelaInfo Set ");
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IdTeachCase))
 {
 if (objTeachCaseRelaInfoEN.IdTeachCase  ==  "")
 {
 objTeachCaseRelaInfoEN.IdTeachCase = null;
 }
 if (objTeachCaseRelaInfoEN.IdTeachCase !=  null)
 {
 var strIdTeachCase = objTeachCaseRelaInfoEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachCase, conTeachCaseRelaInfo.IdTeachCase); //案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCaseRelaInfo.IdTeachCase); //案例流水号
 }
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IdResource))
 {
 if (objTeachCaseRelaInfoEN.IdResource  ==  "")
 {
 objTeachCaseRelaInfoEN.IdResource = null;
 }
 if (objTeachCaseRelaInfoEN.IdResource !=  null)
 {
 var strIdResource = objTeachCaseRelaInfoEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdResource, conTeachCaseRelaInfo.IdResource); //资源流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCaseRelaInfo.IdResource); //资源流水号
 }
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IdTeachCaseRelaInfoType))
 {
 if (objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType  ==  "")
 {
 objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = null;
 }
 if (objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType !=  null)
 {
 var strIdTeachCaseRelaInfoType = objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachCaseRelaInfoType, conTeachCaseRelaInfo.IdTeachCaseRelaInfoType); //案例相关信息类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCaseRelaInfo.IdTeachCaseRelaInfoType); //案例相关信息类型流水号
 }
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachCaseRelaInfoEN.IsVisible == true?"1":"0", conTeachCaseRelaInfo.IsVisible); //是否显示
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.BrowseCount))
 {
 if (objTeachCaseRelaInfoEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachCaseRelaInfoEN.BrowseCount, conTeachCaseRelaInfo.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCaseRelaInfo.BrowseCount); //浏览次数
 }
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.Memo))
 {
 if (objTeachCaseRelaInfoEN.Memo !=  null)
 {
 var strMemo = objTeachCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeachCaseRelaInfo.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCaseRelaInfo.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdTeachCaseRelaInfo = {0}", objTeachCaseRelaInfoEN.IdTeachCaseRelaInfo); 
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
 /// <param name = "objTeachCaseRelaInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN, string strCondition)
{
 if (objTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachCaseRelaInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachCaseRelaInfo Set ");
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IdTeachCase))
 {
 if (objTeachCaseRelaInfoEN.IdTeachCase  ==  "")
 {
 objTeachCaseRelaInfoEN.IdTeachCase = null;
 }
 if (objTeachCaseRelaInfoEN.IdTeachCase !=  null)
 {
 var strIdTeachCase = objTeachCaseRelaInfoEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachCase = '{0}',", strIdTeachCase); //案例流水号
 }
 else
 {
 sbSQL.Append(" IdTeachCase = null,"); //案例流水号
 }
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IdResource))
 {
 if (objTeachCaseRelaInfoEN.IdResource  ==  "")
 {
 objTeachCaseRelaInfoEN.IdResource = null;
 }
 if (objTeachCaseRelaInfoEN.IdResource !=  null)
 {
 var strIdResource = objTeachCaseRelaInfoEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdResource = '{0}',", strIdResource); //资源流水号
 }
 else
 {
 sbSQL.Append(" IdResource = null,"); //资源流水号
 }
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IdTeachCaseRelaInfoType))
 {
 if (objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType  ==  "")
 {
 objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = null;
 }
 if (objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType !=  null)
 {
 var strIdTeachCaseRelaInfoType = objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachCaseRelaInfoType = '{0}',", strIdTeachCaseRelaInfoType); //案例相关信息类型流水号
 }
 else
 {
 sbSQL.Append(" IdTeachCaseRelaInfoType = null,"); //案例相关信息类型流水号
 }
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objTeachCaseRelaInfoEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objTeachCaseRelaInfoEN.BrowseCount); //浏览次数
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.Memo))
 {
 if (objTeachCaseRelaInfoEN.Memo !=  null)
 {
 var strMemo = objTeachCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTeachCaseRelaInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachCaseRelaInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachCaseRelaInfo Set ");
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IdTeachCase))
 {
 if (objTeachCaseRelaInfoEN.IdTeachCase  ==  "")
 {
 objTeachCaseRelaInfoEN.IdTeachCase = null;
 }
 if (objTeachCaseRelaInfoEN.IdTeachCase !=  null)
 {
 var strIdTeachCase = objTeachCaseRelaInfoEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachCase = '{0}',", strIdTeachCase); //案例流水号
 }
 else
 {
 sbSQL.Append(" IdTeachCase = null,"); //案例流水号
 }
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IdResource))
 {
 if (objTeachCaseRelaInfoEN.IdResource  ==  "")
 {
 objTeachCaseRelaInfoEN.IdResource = null;
 }
 if (objTeachCaseRelaInfoEN.IdResource !=  null)
 {
 var strIdResource = objTeachCaseRelaInfoEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdResource = '{0}',", strIdResource); //资源流水号
 }
 else
 {
 sbSQL.Append(" IdResource = null,"); //资源流水号
 }
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IdTeachCaseRelaInfoType))
 {
 if (objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType  ==  "")
 {
 objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = null;
 }
 if (objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType !=  null)
 {
 var strIdTeachCaseRelaInfoType = objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachCaseRelaInfoType = '{0}',", strIdTeachCaseRelaInfoType); //案例相关信息类型流水号
 }
 else
 {
 sbSQL.Append(" IdTeachCaseRelaInfoType = null,"); //案例相关信息类型流水号
 }
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objTeachCaseRelaInfoEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objTeachCaseRelaInfoEN.BrowseCount); //浏览次数
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.Memo))
 {
 if (objTeachCaseRelaInfoEN.Memo !=  null)
 {
 var strMemo = objTeachCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachCaseRelaInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachCaseRelaInfo Set ");
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IdTeachCase))
 {
 if (objTeachCaseRelaInfoEN.IdTeachCase  ==  "")
 {
 objTeachCaseRelaInfoEN.IdTeachCase = null;
 }
 if (objTeachCaseRelaInfoEN.IdTeachCase !=  null)
 {
 var strIdTeachCase = objTeachCaseRelaInfoEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachCase, conTeachCaseRelaInfo.IdTeachCase); //案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCaseRelaInfo.IdTeachCase); //案例流水号
 }
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IdResource))
 {
 if (objTeachCaseRelaInfoEN.IdResource  ==  "")
 {
 objTeachCaseRelaInfoEN.IdResource = null;
 }
 if (objTeachCaseRelaInfoEN.IdResource !=  null)
 {
 var strIdResource = objTeachCaseRelaInfoEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdResource, conTeachCaseRelaInfo.IdResource); //资源流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCaseRelaInfo.IdResource); //资源流水号
 }
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IdTeachCaseRelaInfoType))
 {
 if (objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType  ==  "")
 {
 objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType = null;
 }
 if (objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType !=  null)
 {
 var strIdTeachCaseRelaInfoType = objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachCaseRelaInfoType, conTeachCaseRelaInfo.IdTeachCaseRelaInfoType); //案例相关信息类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCaseRelaInfo.IdTeachCaseRelaInfoType); //案例相关信息类型流水号
 }
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachCaseRelaInfoEN.IsVisible == true?"1":"0", conTeachCaseRelaInfo.IsVisible); //是否显示
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.BrowseCount))
 {
 if (objTeachCaseRelaInfoEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachCaseRelaInfoEN.BrowseCount, conTeachCaseRelaInfo.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCaseRelaInfo.BrowseCount); //浏览次数
 }
 }
 
 if (objTeachCaseRelaInfoEN.IsUpdated(conTeachCaseRelaInfo.Memo))
 {
 if (objTeachCaseRelaInfoEN.Memo !=  null)
 {
 var strMemo = objTeachCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeachCaseRelaInfo.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCaseRelaInfo.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdTeachCaseRelaInfo = {0}", objTeachCaseRelaInfoEN.IdTeachCaseRelaInfo); 
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
 /// <param name = "lngIdTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdTeachCaseRelaInfo) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdTeachCaseRelaInfo,
};
 objSQL.ExecSP("TeachCaseRelaInfo_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdTeachCaseRelaInfo">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdTeachCaseRelaInfo, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
//删除TeachCaseRelaInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachCaseRelaInfo where IdTeachCaseRelaInfo = " + ""+ lngIdTeachCaseRelaInfo+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTeachCaseRelaInfo(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
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
//删除TeachCaseRelaInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachCaseRelaInfo where IdTeachCaseRelaInfo in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdTeachCaseRelaInfo) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
//删除TeachCaseRelaInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachCaseRelaInfo where IdTeachCaseRelaInfo = " + ""+ lngIdTeachCaseRelaInfo+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTeachCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTeachCaseRelaInfoDA: DelTeachCaseRelaInfo)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeachCaseRelaInfo where " + strCondition ;
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
public bool DelTeachCaseRelaInfoWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTeachCaseRelaInfoDA: DelTeachCaseRelaInfoWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeachCaseRelaInfo where " + strCondition ;
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
 /// <param name = "objTeachCaseRelaInfoENS">源对象</param>
 /// <param name = "objTeachCaseRelaInfoENT">目标对象</param>
public void CopyTo(clsTeachCaseRelaInfoEN objTeachCaseRelaInfoENS, clsTeachCaseRelaInfoEN objTeachCaseRelaInfoENT)
{
objTeachCaseRelaInfoENT.IdTeachCaseRelaInfo = objTeachCaseRelaInfoENS.IdTeachCaseRelaInfo; //案例相关信息流水号
objTeachCaseRelaInfoENT.IdTeachCase = objTeachCaseRelaInfoENS.IdTeachCase; //案例流水号
objTeachCaseRelaInfoENT.IdResource = objTeachCaseRelaInfoENS.IdResource; //资源流水号
objTeachCaseRelaInfoENT.IdTeachCaseRelaInfoType = objTeachCaseRelaInfoENS.IdTeachCaseRelaInfoType; //案例相关信息类型流水号
objTeachCaseRelaInfoENT.IsVisible = objTeachCaseRelaInfoENS.IsVisible; //是否显示
objTeachCaseRelaInfoENT.BrowseCount = objTeachCaseRelaInfoENS.BrowseCount; //浏览次数
objTeachCaseRelaInfoENT.Memo = objTeachCaseRelaInfoENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objTeachCaseRelaInfoEN.IdTeachCase, conTeachCaseRelaInfo.IdTeachCase);
clsCheckSql.CheckFieldNotNull(objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType, conTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachCaseRelaInfoEN.IdTeachCase, 8, conTeachCaseRelaInfo.IdTeachCase);
clsCheckSql.CheckFieldLen(objTeachCaseRelaInfoEN.IdResource, 8, conTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType, 4, conTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objTeachCaseRelaInfoEN.Memo, 1000, conTeachCaseRelaInfo.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objTeachCaseRelaInfoEN.IdTeachCase, 8, conTeachCaseRelaInfo.IdTeachCase);
clsCheckSql.CheckFieldForeignKey(objTeachCaseRelaInfoEN.IdResource, 8, conTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldForeignKey(objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType, 4, conTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
 objTeachCaseRelaInfoEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachCaseRelaInfoEN.IdTeachCase, 8, conTeachCaseRelaInfo.IdTeachCase);
clsCheckSql.CheckFieldLen(objTeachCaseRelaInfoEN.IdResource, 8, conTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType, 4, conTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objTeachCaseRelaInfoEN.Memo, 1000, conTeachCaseRelaInfo.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTeachCaseRelaInfoEN.IdTeachCase, 8, conTeachCaseRelaInfo.IdTeachCase);
clsCheckSql.CheckFieldForeignKey(objTeachCaseRelaInfoEN.IdResource, 8, conTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldForeignKey(objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType, 4, conTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
 objTeachCaseRelaInfoEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachCaseRelaInfoEN.IdTeachCase, 8, conTeachCaseRelaInfo.IdTeachCase);
clsCheckSql.CheckFieldLen(objTeachCaseRelaInfoEN.IdResource, 8, conTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType, 4, conTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objTeachCaseRelaInfoEN.Memo, 1000, conTeachCaseRelaInfo.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTeachCaseRelaInfoEN.IdTeachCase, conTeachCaseRelaInfo.IdTeachCase);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseRelaInfoEN.IdResource, conTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType, conTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseRelaInfoEN.Memo, conTeachCaseRelaInfo.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTeachCaseRelaInfoEN.IdTeachCase, 8, conTeachCaseRelaInfo.IdTeachCase);
clsCheckSql.CheckFieldForeignKey(objTeachCaseRelaInfoEN.IdResource, 8, conTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldForeignKey(objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType, 4, conTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
 objTeachCaseRelaInfoEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--TeachCaseRelaInfo(案例相关信息),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTeachCaseRelaInfoEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsTeachCaseRelaInfoEN objTeachCaseRelaInfoEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdTeachCaseRelaInfoType = '{0}'", objTeachCaseRelaInfoEN.IdTeachCaseRelaInfoType);
 sbCondition.AppendFormat(" and IdTeachCase = '{0}'", objTeachCaseRelaInfoEN.IdTeachCase);
 if (objTeachCaseRelaInfoEN.IdResource == null)
{
 sbCondition.AppendFormat(" and IdResource is null");
}
else
{
 sbCondition.AppendFormat(" and IdResource = '{0}'", objTeachCaseRelaInfoEN.IdResource);
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
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeachCaseRelaInfoEN._CurrTabName);
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
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeachCaseRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsTeachCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}