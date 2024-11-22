
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachCase_Resource_RelDA
 表名:TeachCase_Resource_Rel(01120511)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:40
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
 /// 案例与资源表系(TeachCase_Resource_Rel)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsTeachCase_Resource_RelDA : clsCommBase4DA
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
 return clsTeachCase_Resource_RelEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTeachCase_Resource_RelEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTeachCase_Resource_RelEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTeachCase_Resource_RelEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTeachCase_Resource_RelEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTeachCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TeachCase_Resource_Rel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTeachCase_Resource_RelDA: GetDataTable_TeachCase_Resource_Rel)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTeachCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTeachCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTeachCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTeachCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachCase_Resource_Rel where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachCase_Resource_Rel where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTeachCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TeachCase_Resource_Rel where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTeachCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeachCase_Resource_Rel.* from TeachCase_Resource_Rel Left Join {1} on {2} where {3} and TeachCase_Resource_Rel.IdTeachCaseResourceRel not in (Select top {5} TeachCase_Resource_Rel.IdTeachCaseResourceRel from TeachCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachCase_Resource_Rel where {1} and IdTeachCaseResourceRel not in (Select top {2} IdTeachCaseResourceRel from TeachCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachCase_Resource_Rel where {1} and IdTeachCaseResourceRel not in (Select top {3} IdTeachCaseResourceRel from TeachCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTeachCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeachCase_Resource_Rel.* from TeachCase_Resource_Rel Left Join {1} on {2} where {3} and TeachCase_Resource_Rel.IdTeachCaseResourceRel not in (Select top {5} TeachCase_Resource_Rel.IdTeachCaseResourceRel from TeachCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachCase_Resource_Rel where {1} and IdTeachCaseResourceRel not in (Select top {2} IdTeachCaseResourceRel from TeachCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachCase_Resource_Rel where {1} and IdTeachCaseResourceRel not in (Select top {3} IdTeachCaseResourceRel from TeachCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsTeachCase_Resource_RelEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTeachCase_Resource_RelDA:GetObjLst)", objException.Message));
}
List<clsTeachCase_Resource_RelEN> arrObjLst = new List<clsTeachCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = new clsTeachCase_Resource_RelEN();
try
{
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = TransNullToInt(objRow[conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objTeachCase_Resource_RelEN.IdTeachCase = objRow[conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCase_Resource_RelEN.IdResource = objRow[conTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objTeachCase_Resource_RelEN.IsMain = TransNullToBool(objRow[conTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objTeachCase_Resource_RelEN.Memo = objRow[conTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objTeachCase_Resource_RelEN.IndexNO = objRow[conTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objTeachCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[conTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objTeachCase_Resource_RelEN.BrowseCount = objRow[conTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeachCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objTeachCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeachCase_Resource_RelEN);
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
public List<clsTeachCase_Resource_RelEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTeachCase_Resource_RelDA:GetObjLstByTabName)", objException.Message));
}
List<clsTeachCase_Resource_RelEN> arrObjLst = new List<clsTeachCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = new clsTeachCase_Resource_RelEN();
try
{
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = TransNullToInt(objRow[conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objTeachCase_Resource_RelEN.IdTeachCase = objRow[conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCase_Resource_RelEN.IdResource = objRow[conTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objTeachCase_Resource_RelEN.IsMain = TransNullToBool(objRow[conTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objTeachCase_Resource_RelEN.Memo = objRow[conTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objTeachCase_Resource_RelEN.IndexNO = objRow[conTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objTeachCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[conTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objTeachCase_Resource_RelEN.BrowseCount = objRow[conTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeachCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objTeachCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeachCase_Resource_RelEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTeachCase_Resource_Rel(ref clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase_Resource_Rel where IdTeachCaseResourceRel = " + ""+ objTeachCase_Resource_RelEN.IdTeachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = TransNullToInt(objDT.Rows[0][conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objTeachCase_Resource_RelEN.IdTeachCase = objDT.Rows[0][conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachCase_Resource_RelEN.IdResource = objDT.Rows[0][conTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachCase_Resource_RelEN.IsMain = TransNullToBool(objDT.Rows[0][conTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objTeachCase_Resource_RelEN.Memo = objDT.Rows[0][conTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objTeachCase_Resource_RelEN.IndexNO = TransNullToInt(objDT.Rows[0][conTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objTeachCase_Resource_RelEN.IsVisible = TransNullToBool(objDT.Rows[0][conTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objTeachCase_Resource_RelEN.BrowseCount = TransNullToInt(objDT.Rows[0][conTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTeachCase_Resource_RelDA: GetTeachCase_Resource_Rel)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdTeachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public clsTeachCase_Resource_RelEN GetObjByIdTeachCaseResourceRel(long lngIdTeachCaseResourceRel)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase_Resource_Rel where IdTeachCaseResourceRel = " + ""+ lngIdTeachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = new clsTeachCase_Resource_RelEN();
try
{
 objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objTeachCase_Resource_RelEN.IdTeachCase = objRow[conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachCase_Resource_RelEN.IdResource = objRow[conTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objTeachCase_Resource_RelEN.Memo = objRow[conTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objTeachCase_Resource_RelEN.IndexNO = objRow[conTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objTeachCase_Resource_RelEN.BrowseCount = objRow[conTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTeachCase_Resource_RelDA: GetObjByIdTeachCaseResourceRel)", objException.Message));
}
return objTeachCase_Resource_RelEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTeachCase_Resource_RelEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTeachCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = new clsTeachCase_Resource_RelEN()
{
IdTeachCaseResourceRel = TransNullToInt(objRow[conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()), //案例与资源表系表流水号
IdTeachCase = objRow[conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(), //案例流水号
IdResource = objRow[conTeachCase_Resource_Rel.IdResource].ToString().Trim(), //资源流水号
IsMain = TransNullToBool(objRow[conTeachCase_Resource_Rel.IsMain].ToString().Trim()), //是否主资源
Memo = objRow[conTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conTeachCase_Resource_Rel.Memo].ToString().Trim(), //备注
IndexNO = objRow[conTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCase_Resource_Rel.IndexNO].ToString().Trim()), //序号
IsVisible = TransNullToBool(objRow[conTeachCase_Resource_Rel.IsVisible].ToString().Trim()), //是否显示
BrowseCount = objRow[conTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCase_Resource_Rel.BrowseCount].ToString().Trim()) //浏览次数
};
objTeachCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachCase_Resource_RelEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTeachCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTeachCase_Resource_RelEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = new clsTeachCase_Resource_RelEN();
try
{
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = TransNullToInt(objRow[conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objTeachCase_Resource_RelEN.IdTeachCase = objRow[conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCase_Resource_RelEN.IdResource = objRow[conTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objTeachCase_Resource_RelEN.IsMain = TransNullToBool(objRow[conTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objTeachCase_Resource_RelEN.Memo = objRow[conTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objTeachCase_Resource_RelEN.IndexNO = objRow[conTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objTeachCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[conTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objTeachCase_Resource_RelEN.BrowseCount = objRow[conTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTeachCase_Resource_RelDA: GetObjByDataRowTeachCase_Resource_Rel)", objException.Message));
}
objTeachCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachCase_Resource_RelEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTeachCase_Resource_RelEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN = new clsTeachCase_Resource_RelEN();
try
{
objTeachCase_Resource_RelEN.IdTeachCaseResourceRel = TransNullToInt(objRow[conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objTeachCase_Resource_RelEN.IdTeachCase = objRow[conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCase_Resource_RelEN.IdResource = objRow[conTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objTeachCase_Resource_RelEN.IsMain = TransNullToBool(objRow[conTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objTeachCase_Resource_RelEN.Memo = objRow[conTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[conTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objTeachCase_Resource_RelEN.IndexNO = objRow[conTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objTeachCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[conTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objTeachCase_Resource_RelEN.BrowseCount = objRow[conTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTeachCase_Resource_RelDA: GetObjByDataRow)", objException.Message));
}
objTeachCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachCase_Resource_RelEN;
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
objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeachCase_Resource_RelEN._CurrTabName, conTeachCase_Resource_Rel.IdTeachCaseResourceRel, 8, "");
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
objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeachCase_Resource_RelEN._CurrTabName, conTeachCase_Resource_Rel.IdTeachCaseResourceRel, 8, strPrefix);
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
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdTeachCaseResourceRel from TeachCase_Resource_Rel where " + strCondition;
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
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdTeachCaseResourceRel from TeachCase_Resource_Rel where " + strCondition;
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
 /// <param name = "lngIdTeachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdTeachCaseResourceRel)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeachCase_Resource_Rel", "IdTeachCaseResourceRel = " + ""+ lngIdTeachCaseResourceRel+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTeachCase_Resource_RelDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeachCase_Resource_Rel", strCondition))
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
objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TeachCase_Resource_Rel");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
 {
 if (objTeachCase_Resource_RelEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachCase_Resource_RelEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase_Resource_Rel where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeachCase_Resource_Rel");
objRow = objDS.Tables["TeachCase_Resource_Rel"].NewRow();
objRow[conTeachCase_Resource_Rel.IdTeachCase] = objTeachCase_Resource_RelEN.IdTeachCase; //案例流水号
objRow[conTeachCase_Resource_Rel.IdResource] = objTeachCase_Resource_RelEN.IdResource; //资源流水号
objRow[conTeachCase_Resource_Rel.IsMain] = objTeachCase_Resource_RelEN.IsMain; //是否主资源
 if (objTeachCase_Resource_RelEN.Memo !=  "")
 {
objRow[conTeachCase_Resource_Rel.Memo] = objTeachCase_Resource_RelEN.Memo; //备注
 }
objRow[conTeachCase_Resource_Rel.IndexNO] = objTeachCase_Resource_RelEN.IndexNO; //序号
objRow[conTeachCase_Resource_Rel.IsVisible] = objTeachCase_Resource_RelEN.IsVisible; //是否显示
objRow[conTeachCase_Resource_Rel.BrowseCount] = objTeachCase_Resource_RelEN.BrowseCount; //浏览次数
objDS.Tables[clsTeachCase_Resource_RelEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTeachCase_Resource_RelEN._CurrTabName);
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
 /// <param name = "objTeachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
 if (objTeachCase_Resource_RelEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachCase_Resource_RelEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTeachCase_Resource_RelEN.IdTeachCase  ==  "")
 {
 objTeachCase_Resource_RelEN.IdTeachCase = null;
 }
 if (objTeachCase_Resource_RelEN.IdTeachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IdTeachCase);
 var strIdTeachCase = objTeachCase_Resource_RelEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachCase + "'");
 }
 
 if (objTeachCase_Resource_RelEN.IdResource  ==  "")
 {
 objTeachCase_Resource_RelEN.IdResource = null;
 }
 if (objTeachCase_Resource_RelEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IdResource);
 var strIdResource = objTeachCase_Resource_RelEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IsMain);
 arrValueListForInsert.Add("'" + (objTeachCase_Resource_RelEN.IsMain  ==  false ? "0" : "1") + "'");
 
 if (objTeachCase_Resource_RelEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.Memo);
 var strMemo = objTeachCase_Resource_RelEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objTeachCase_Resource_RelEN.IndexNO !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IndexNO);
 arrValueListForInsert.Add(objTeachCase_Resource_RelEN.IndexNO.ToString());
 }
 
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IsVisible);
 arrValueListForInsert.Add("'" + (objTeachCase_Resource_RelEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objTeachCase_Resource_RelEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.BrowseCount);
 arrValueListForInsert.Add(objTeachCase_Resource_RelEN.BrowseCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachCase_Resource_Rel");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
 if (objTeachCase_Resource_RelEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachCase_Resource_RelEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTeachCase_Resource_RelEN.IdTeachCase  ==  "")
 {
 objTeachCase_Resource_RelEN.IdTeachCase = null;
 }
 if (objTeachCase_Resource_RelEN.IdTeachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IdTeachCase);
 var strIdTeachCase = objTeachCase_Resource_RelEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachCase + "'");
 }
 
 if (objTeachCase_Resource_RelEN.IdResource  ==  "")
 {
 objTeachCase_Resource_RelEN.IdResource = null;
 }
 if (objTeachCase_Resource_RelEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IdResource);
 var strIdResource = objTeachCase_Resource_RelEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IsMain);
 arrValueListForInsert.Add("'" + (objTeachCase_Resource_RelEN.IsMain  ==  false ? "0" : "1") + "'");
 
 if (objTeachCase_Resource_RelEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.Memo);
 var strMemo = objTeachCase_Resource_RelEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objTeachCase_Resource_RelEN.IndexNO !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IndexNO);
 arrValueListForInsert.Add(objTeachCase_Resource_RelEN.IndexNO.ToString());
 }
 
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IsVisible);
 arrValueListForInsert.Add("'" + (objTeachCase_Resource_RelEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objTeachCase_Resource_RelEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.BrowseCount);
 arrValueListForInsert.Add(objTeachCase_Resource_RelEN.BrowseCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachCase_Resource_Rel");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTeachCase_Resource_RelEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachCase_Resource_RelEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTeachCase_Resource_RelEN.IdTeachCase  ==  "")
 {
 objTeachCase_Resource_RelEN.IdTeachCase = null;
 }
 if (objTeachCase_Resource_RelEN.IdTeachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IdTeachCase);
 var strIdTeachCase = objTeachCase_Resource_RelEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachCase + "'");
 }
 
 if (objTeachCase_Resource_RelEN.IdResource  ==  "")
 {
 objTeachCase_Resource_RelEN.IdResource = null;
 }
 if (objTeachCase_Resource_RelEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IdResource);
 var strIdResource = objTeachCase_Resource_RelEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IsMain);
 arrValueListForInsert.Add("'" + (objTeachCase_Resource_RelEN.IsMain  ==  false ? "0" : "1") + "'");
 
 if (objTeachCase_Resource_RelEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.Memo);
 var strMemo = objTeachCase_Resource_RelEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objTeachCase_Resource_RelEN.IndexNO !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IndexNO);
 arrValueListForInsert.Add(objTeachCase_Resource_RelEN.IndexNO.ToString());
 }
 
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IsVisible);
 arrValueListForInsert.Add("'" + (objTeachCase_Resource_RelEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objTeachCase_Resource_RelEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.BrowseCount);
 arrValueListForInsert.Add(objTeachCase_Resource_RelEN.BrowseCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachCase_Resource_Rel");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objTeachCase_Resource_RelEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachCase_Resource_RelEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTeachCase_Resource_RelEN.IdTeachCase  ==  "")
 {
 objTeachCase_Resource_RelEN.IdTeachCase = null;
 }
 if (objTeachCase_Resource_RelEN.IdTeachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IdTeachCase);
 var strIdTeachCase = objTeachCase_Resource_RelEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachCase + "'");
 }
 
 if (objTeachCase_Resource_RelEN.IdResource  ==  "")
 {
 objTeachCase_Resource_RelEN.IdResource = null;
 }
 if (objTeachCase_Resource_RelEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IdResource);
 var strIdResource = objTeachCase_Resource_RelEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IsMain);
 arrValueListForInsert.Add("'" + (objTeachCase_Resource_RelEN.IsMain  ==  false ? "0" : "1") + "'");
 
 if (objTeachCase_Resource_RelEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.Memo);
 var strMemo = objTeachCase_Resource_RelEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objTeachCase_Resource_RelEN.IndexNO !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IndexNO);
 arrValueListForInsert.Add(objTeachCase_Resource_RelEN.IndexNO.ToString());
 }
 
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.IsVisible);
 arrValueListForInsert.Add("'" + (objTeachCase_Resource_RelEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objTeachCase_Resource_RelEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase_Resource_Rel.BrowseCount);
 arrValueListForInsert.Add(objTeachCase_Resource_RelEN.BrowseCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachCase_Resource_Rel");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTeachCase_Resource_Rels(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase_Resource_Rel where IdTeachCaseResourceRel = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeachCase_Resource_Rel");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdTeachCaseResourceRel = TransNullToInt(oRow[conTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim());
if (IsExist(lngIdTeachCaseResourceRel))
{
 string strResult = "关键字变量值为:" + string.Format("IdTeachCaseResourceRel = {0}", lngIdTeachCaseResourceRel) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTeachCase_Resource_RelEN._CurrTabName ].NewRow();
objRow[conTeachCase_Resource_Rel.IdTeachCase] = oRow[conTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objRow[conTeachCase_Resource_Rel.IdResource] = oRow[conTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objRow[conTeachCase_Resource_Rel.IsMain] = oRow[conTeachCase_Resource_Rel.IsMain].ToString().Trim(); //是否主资源
objRow[conTeachCase_Resource_Rel.Memo] = oRow[conTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objRow[conTeachCase_Resource_Rel.IndexNO] = oRow[conTeachCase_Resource_Rel.IndexNO].ToString().Trim(); //序号
objRow[conTeachCase_Resource_Rel.IsVisible] = oRow[conTeachCase_Resource_Rel.IsVisible].ToString().Trim(); //是否显示
objRow[conTeachCase_Resource_Rel.BrowseCount] = oRow[conTeachCase_Resource_Rel.BrowseCount].ToString().Trim(); //浏览次数
 objDS.Tables[clsTeachCase_Resource_RelEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTeachCase_Resource_RelEN._CurrTabName);
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
 /// <param name = "objTeachCase_Resource_RelEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
 if (objTeachCase_Resource_RelEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachCase_Resource_RelEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase_Resource_Rel where IdTeachCaseResourceRel = " + ""+ objTeachCase_Resource_RelEN.IdTeachCaseResourceRel+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTeachCase_Resource_RelEN._CurrTabName);
if (objDS.Tables[clsTeachCase_Resource_RelEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdTeachCaseResourceRel = " + ""+ objTeachCase_Resource_RelEN.IdTeachCaseResourceRel+"");
return false;
}
objRow = objDS.Tables[clsTeachCase_Resource_RelEN._CurrTabName].Rows[0];
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IdTeachCase))
 {
objRow[conTeachCase_Resource_Rel.IdTeachCase] = objTeachCase_Resource_RelEN.IdTeachCase; //案例流水号
 }
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IdResource))
 {
objRow[conTeachCase_Resource_Rel.IdResource] = objTeachCase_Resource_RelEN.IdResource; //资源流水号
 }
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IsMain))
 {
objRow[conTeachCase_Resource_Rel.IsMain] = objTeachCase_Resource_RelEN.IsMain; //是否主资源
 }
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.Memo))
 {
objRow[conTeachCase_Resource_Rel.Memo] = objTeachCase_Resource_RelEN.Memo; //备注
 }
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IndexNO))
 {
objRow[conTeachCase_Resource_Rel.IndexNO] = objTeachCase_Resource_RelEN.IndexNO; //序号
 }
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IsVisible))
 {
objRow[conTeachCase_Resource_Rel.IsVisible] = objTeachCase_Resource_RelEN.IsVisible; //是否显示
 }
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.BrowseCount))
 {
objRow[conTeachCase_Resource_Rel.BrowseCount] = objTeachCase_Resource_RelEN.BrowseCount; //浏览次数
 }
try
{
objDA.Update(objDS, clsTeachCase_Resource_RelEN._CurrTabName);
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
 /// <param name = "objTeachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
 if (objTeachCase_Resource_RelEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachCase_Resource_RelEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TeachCase_Resource_Rel Set ");
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IdTeachCase))
 {
 if (objTeachCase_Resource_RelEN.IdTeachCase  ==  "")
 {
 objTeachCase_Resource_RelEN.IdTeachCase = null;
 }
 if (objTeachCase_Resource_RelEN.IdTeachCase !=  null)
 {
 var strIdTeachCase = objTeachCase_Resource_RelEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachCase, conTeachCase_Resource_Rel.IdTeachCase); //案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase_Resource_Rel.IdTeachCase); //案例流水号
 }
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IdResource))
 {
 if (objTeachCase_Resource_RelEN.IdResource  ==  "")
 {
 objTeachCase_Resource_RelEN.IdResource = null;
 }
 if (objTeachCase_Resource_RelEN.IdResource !=  null)
 {
 var strIdResource = objTeachCase_Resource_RelEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdResource, conTeachCase_Resource_Rel.IdResource); //资源流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase_Resource_Rel.IdResource); //资源流水号
 }
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IsMain))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachCase_Resource_RelEN.IsMain == true?"1":"0", conTeachCase_Resource_Rel.IsMain); //是否主资源
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.Memo))
 {
 if (objTeachCase_Resource_RelEN.Memo !=  null)
 {
 var strMemo = objTeachCase_Resource_RelEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeachCase_Resource_Rel.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase_Resource_Rel.Memo); //备注
 }
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IndexNO))
 {
 if (objTeachCase_Resource_RelEN.IndexNO !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachCase_Resource_RelEN.IndexNO, conTeachCase_Resource_Rel.IndexNO); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase_Resource_Rel.IndexNO); //序号
 }
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachCase_Resource_RelEN.IsVisible == true?"1":"0", conTeachCase_Resource_Rel.IsVisible); //是否显示
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.BrowseCount))
 {
 if (objTeachCase_Resource_RelEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachCase_Resource_RelEN.BrowseCount, conTeachCase_Resource_Rel.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase_Resource_Rel.BrowseCount); //浏览次数
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdTeachCaseResourceRel = {0}", objTeachCase_Resource_RelEN.IdTeachCaseResourceRel); 
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
 /// <param name = "objTeachCase_Resource_RelEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN, string strCondition)
{
 if (objTeachCase_Resource_RelEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachCase_Resource_RelEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachCase_Resource_Rel Set ");
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IdTeachCase))
 {
 if (objTeachCase_Resource_RelEN.IdTeachCase  ==  "")
 {
 objTeachCase_Resource_RelEN.IdTeachCase = null;
 }
 if (objTeachCase_Resource_RelEN.IdTeachCase !=  null)
 {
 var strIdTeachCase = objTeachCase_Resource_RelEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachCase = '{0}',", strIdTeachCase); //案例流水号
 }
 else
 {
 sbSQL.Append(" IdTeachCase = null,"); //案例流水号
 }
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IdResource))
 {
 if (objTeachCase_Resource_RelEN.IdResource  ==  "")
 {
 objTeachCase_Resource_RelEN.IdResource = null;
 }
 if (objTeachCase_Resource_RelEN.IdResource !=  null)
 {
 var strIdResource = objTeachCase_Resource_RelEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdResource = '{0}',", strIdResource); //资源流水号
 }
 else
 {
 sbSQL.Append(" IdResource = null,"); //资源流水号
 }
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IsMain))
 {
 sbSQL.AppendFormat(" IsMain = '{0}',", objTeachCase_Resource_RelEN.IsMain == true?"1":"0"); //是否主资源
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.Memo))
 {
 if (objTeachCase_Resource_RelEN.Memo !=  null)
 {
 var strMemo = objTeachCase_Resource_RelEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IndexNO))
 {
 sbSQL.AppendFormat(" IndexNO = {0},", objTeachCase_Resource_RelEN.IndexNO); //序号
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objTeachCase_Resource_RelEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objTeachCase_Resource_RelEN.BrowseCount); //浏览次数
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
 /// <param name = "objTeachCase_Resource_RelEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTeachCase_Resource_RelEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachCase_Resource_RelEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachCase_Resource_Rel Set ");
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IdTeachCase))
 {
 if (objTeachCase_Resource_RelEN.IdTeachCase  ==  "")
 {
 objTeachCase_Resource_RelEN.IdTeachCase = null;
 }
 if (objTeachCase_Resource_RelEN.IdTeachCase !=  null)
 {
 var strIdTeachCase = objTeachCase_Resource_RelEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachCase = '{0}',", strIdTeachCase); //案例流水号
 }
 else
 {
 sbSQL.Append(" IdTeachCase = null,"); //案例流水号
 }
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IdResource))
 {
 if (objTeachCase_Resource_RelEN.IdResource  ==  "")
 {
 objTeachCase_Resource_RelEN.IdResource = null;
 }
 if (objTeachCase_Resource_RelEN.IdResource !=  null)
 {
 var strIdResource = objTeachCase_Resource_RelEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdResource = '{0}',", strIdResource); //资源流水号
 }
 else
 {
 sbSQL.Append(" IdResource = null,"); //资源流水号
 }
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IsMain))
 {
 sbSQL.AppendFormat(" IsMain = '{0}',", objTeachCase_Resource_RelEN.IsMain == true?"1":"0"); //是否主资源
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.Memo))
 {
 if (objTeachCase_Resource_RelEN.Memo !=  null)
 {
 var strMemo = objTeachCase_Resource_RelEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IndexNO))
 {
 sbSQL.AppendFormat(" IndexNO = {0},", objTeachCase_Resource_RelEN.IndexNO); //序号
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objTeachCase_Resource_RelEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objTeachCase_Resource_RelEN.BrowseCount); //浏览次数
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
 /// <param name = "objTeachCase_Resource_RelEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objTeachCase_Resource_RelEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachCase_Resource_RelEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachCase_Resource_Rel Set ");
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IdTeachCase))
 {
 if (objTeachCase_Resource_RelEN.IdTeachCase  ==  "")
 {
 objTeachCase_Resource_RelEN.IdTeachCase = null;
 }
 if (objTeachCase_Resource_RelEN.IdTeachCase !=  null)
 {
 var strIdTeachCase = objTeachCase_Resource_RelEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachCase, conTeachCase_Resource_Rel.IdTeachCase); //案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase_Resource_Rel.IdTeachCase); //案例流水号
 }
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IdResource))
 {
 if (objTeachCase_Resource_RelEN.IdResource  ==  "")
 {
 objTeachCase_Resource_RelEN.IdResource = null;
 }
 if (objTeachCase_Resource_RelEN.IdResource !=  null)
 {
 var strIdResource = objTeachCase_Resource_RelEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdResource, conTeachCase_Resource_Rel.IdResource); //资源流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase_Resource_Rel.IdResource); //资源流水号
 }
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IsMain))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachCase_Resource_RelEN.IsMain == true?"1":"0", conTeachCase_Resource_Rel.IsMain); //是否主资源
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.Memo))
 {
 if (objTeachCase_Resource_RelEN.Memo !=  null)
 {
 var strMemo = objTeachCase_Resource_RelEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeachCase_Resource_Rel.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase_Resource_Rel.Memo); //备注
 }
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IndexNO))
 {
 if (objTeachCase_Resource_RelEN.IndexNO !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachCase_Resource_RelEN.IndexNO, conTeachCase_Resource_Rel.IndexNO); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase_Resource_Rel.IndexNO); //序号
 }
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachCase_Resource_RelEN.IsVisible == true?"1":"0", conTeachCase_Resource_Rel.IsVisible); //是否显示
 }
 
 if (objTeachCase_Resource_RelEN.IsUpdated(conTeachCase_Resource_Rel.BrowseCount))
 {
 if (objTeachCase_Resource_RelEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachCase_Resource_RelEN.BrowseCount, conTeachCase_Resource_Rel.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase_Resource_Rel.BrowseCount); //浏览次数
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdTeachCaseResourceRel = {0}", objTeachCase_Resource_RelEN.IdTeachCaseResourceRel); 
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
 /// <param name = "lngIdTeachCaseResourceRel">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdTeachCaseResourceRel) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdTeachCaseResourceRel,
};
 objSQL.ExecSP("TeachCase_Resource_Rel_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdTeachCaseResourceRel">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdTeachCaseResourceRel, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
//删除TeachCase_Resource_Rel本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachCase_Resource_Rel where IdTeachCaseResourceRel = " + ""+ lngIdTeachCaseResourceRel+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTeachCase_Resource_Rel(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
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
//删除TeachCase_Resource_Rel本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachCase_Resource_Rel where IdTeachCaseResourceRel in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdTeachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdTeachCaseResourceRel) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
//删除TeachCase_Resource_Rel本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachCase_Resource_Rel where IdTeachCaseResourceRel = " + ""+ lngIdTeachCaseResourceRel+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTeachCase_Resource_Rel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTeachCase_Resource_RelDA: DelTeachCase_Resource_Rel)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeachCase_Resource_Rel where " + strCondition ;
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
public bool DelTeachCase_Resource_RelWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTeachCase_Resource_RelDA: DelTeachCase_Resource_RelWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeachCase_Resource_Rel where " + strCondition ;
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
 /// <param name = "objTeachCase_Resource_RelENS">源对象</param>
 /// <param name = "objTeachCase_Resource_RelENT">目标对象</param>
public void CopyTo(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelENS, clsTeachCase_Resource_RelEN objTeachCase_Resource_RelENT)
{
objTeachCase_Resource_RelENT.IdTeachCaseResourceRel = objTeachCase_Resource_RelENS.IdTeachCaseResourceRel; //案例与资源表系表流水号
objTeachCase_Resource_RelENT.IdTeachCase = objTeachCase_Resource_RelENS.IdTeachCase; //案例流水号
objTeachCase_Resource_RelENT.IdResource = objTeachCase_Resource_RelENS.IdResource; //资源流水号
objTeachCase_Resource_RelENT.IsMain = objTeachCase_Resource_RelENS.IsMain; //是否主资源
objTeachCase_Resource_RelENT.Memo = objTeachCase_Resource_RelENS.Memo; //备注
objTeachCase_Resource_RelENT.IndexNO = objTeachCase_Resource_RelENS.IndexNO; //序号
objTeachCase_Resource_RelENT.IsVisible = objTeachCase_Resource_RelENS.IsVisible; //是否显示
objTeachCase_Resource_RelENT.BrowseCount = objTeachCase_Resource_RelENS.BrowseCount; //浏览次数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objTeachCase_Resource_RelEN.IdTeachCase, conTeachCase_Resource_Rel.IdTeachCase);
clsCheckSql.CheckFieldNotNull(objTeachCase_Resource_RelEN.IdResource, conTeachCase_Resource_Rel.IdResource);
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachCase_Resource_RelEN.IdTeachCase, 8, conTeachCase_Resource_Rel.IdTeachCase);
clsCheckSql.CheckFieldLen(objTeachCase_Resource_RelEN.IdResource, 8, conTeachCase_Resource_Rel.IdResource);
clsCheckSql.CheckFieldLen(objTeachCase_Resource_RelEN.Memo, 1000, conTeachCase_Resource_Rel.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objTeachCase_Resource_RelEN.IdTeachCase, 8, conTeachCase_Resource_Rel.IdTeachCase);
clsCheckSql.CheckFieldForeignKey(objTeachCase_Resource_RelEN.IdResource, 8, conTeachCase_Resource_Rel.IdResource);
 objTeachCase_Resource_RelEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachCase_Resource_RelEN.IdTeachCase, 8, conTeachCase_Resource_Rel.IdTeachCase);
clsCheckSql.CheckFieldLen(objTeachCase_Resource_RelEN.IdResource, 8, conTeachCase_Resource_Rel.IdResource);
clsCheckSql.CheckFieldLen(objTeachCase_Resource_RelEN.Memo, 1000, conTeachCase_Resource_Rel.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTeachCase_Resource_RelEN.IdTeachCase, 8, conTeachCase_Resource_Rel.IdTeachCase);
clsCheckSql.CheckFieldForeignKey(objTeachCase_Resource_RelEN.IdResource, 8, conTeachCase_Resource_Rel.IdResource);
 objTeachCase_Resource_RelEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachCase_Resource_RelEN.IdTeachCase, 8, conTeachCase_Resource_Rel.IdTeachCase);
clsCheckSql.CheckFieldLen(objTeachCase_Resource_RelEN.IdResource, 8, conTeachCase_Resource_Rel.IdResource);
clsCheckSql.CheckFieldLen(objTeachCase_Resource_RelEN.Memo, 1000, conTeachCase_Resource_Rel.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTeachCase_Resource_RelEN.IdTeachCase, conTeachCase_Resource_Rel.IdTeachCase);
clsCheckSql.CheckSqlInjection4Field(objTeachCase_Resource_RelEN.IdResource, conTeachCase_Resource_Rel.IdResource);
clsCheckSql.CheckSqlInjection4Field(objTeachCase_Resource_RelEN.Memo, conTeachCase_Resource_Rel.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTeachCase_Resource_RelEN.IdTeachCase, 8, conTeachCase_Resource_Rel.IdTeachCase);
clsCheckSql.CheckFieldForeignKey(objTeachCase_Resource_RelEN.IdResource, 8, conTeachCase_Resource_Rel.IdResource);
 objTeachCase_Resource_RelEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--TeachCase_Resource_Rel(案例与资源表系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTeachCase_Resource_RelEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsTeachCase_Resource_RelEN objTeachCase_Resource_RelEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdTeachCase = '{0}'", objTeachCase_Resource_RelEN.IdTeachCase);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objTeachCase_Resource_RelEN.IdResource);
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
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeachCase_Resource_RelEN._CurrTabName);
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
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeachCase_Resource_RelEN._CurrTabName, strCondition);
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
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsTeachCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}