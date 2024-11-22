
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMandarinCaseQuantitySenateDA
 表名:vMandarinCaseQuantitySenate(01120451)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:12
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:普通话点播(Mandarin)
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
 /// vMandarinCaseQuantitySenate(vMandarinCaseQuantitySenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMandarinCaseQuantitySenateDA : clsCommBase4DA
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
 return clsvMandarinCaseQuantitySenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMandarinCaseQuantitySenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMandarinCaseQuantitySenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMandarinCaseQuantitySenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMandarinCaseQuantitySenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMandarinCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMandarinCaseQuantitySenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMandarinCaseQuantitySenateDA: GetDataTable_vMandarinCaseQuantitySenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMandarinCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMandarinCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMandarinCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMandarinCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCaseQuantitySenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCaseQuantitySenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMandarinCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMandarinCaseQuantitySenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMandarinCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMandarinCaseQuantitySenate.* from vMandarinCaseQuantitySenate Left Join {1} on {2} where {3} and vMandarinCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vMandarinCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vMandarinCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vMandarinCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vMandarinCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMandarinCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMandarinCaseQuantitySenate.* from vMandarinCaseQuantitySenate Left Join {1} on {2} where {3} and vMandarinCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vMandarinCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vMandarinCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vMandarinCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vMandarinCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMandarinCaseQuantitySenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMandarinCaseQuantitySenateDA:GetObjLst)", objException.Message));
}
List<clsvMandarinCaseQuantitySenateEN> arrObjLst = new List<clsvMandarinCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN = new clsvMandarinCaseQuantitySenateEN();
try
{
objvMandarinCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convMandarinCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMandarinCaseQuantitySenateEN.FuncModuleId = objRow[convMandarinCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMandarinCaseQuantitySenateEN.FuncModuleName = objRow[convMandarinCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMandarinCaseQuantitySenateEN.IdAppraiseType = objRow[convMandarinCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMandarinCaseQuantitySenateEN.AppraiseTypeName = objRow[convMandarinCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMandarinCaseQuantitySenateEN.IdMicroteachCase = objRow[convMandarinCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMandarinCaseQuantitySenateEN.MandarinCaseID = objRow[convMandarinCaseQuantitySenate.MandarinCaseID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseID].ToString().Trim(); //普通话教学案例ID
objvMandarinCaseQuantitySenateEN.MandarinCaseName = objRow[convMandarinCaseQuantitySenate.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objvMandarinCaseQuantitySenateEN.MandarinCaseDate = objRow[convMandarinCaseQuantitySenate.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseDate].ToString().Trim(); //普通话教学日期
objvMandarinCaseQuantitySenateEN.SenateTheme = objRow[convMandarinCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMandarinCaseQuantitySenateEN.SenateContent = objRow[convMandarinCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMandarinCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convMandarinCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMandarinCaseQuantitySenateEN.SenateDate = objRow[convMandarinCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMandarinCaseQuantitySenateEN.SenateTime = objRow[convMandarinCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMandarinCaseQuantitySenateEN.BrowseCount = objRow[convMandarinCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMandarinCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMandarinCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMandarinCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMandarinCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMandarinCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMandarinCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMandarinCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMandarinCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMandarinCaseQuantitySenateEN.SenateIp = objRow[convMandarinCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMandarinCaseQuantitySenateEN.UpdUserName = objRow[convMandarinCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMandarinCaseQuantitySenateEN.UpdUser = objRow[convMandarinCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMandarinCaseQuantitySenateEN.CollegeID = objRow[convMandarinCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMandarinCaseQuantitySenateEN.CollegeName = objRow[convMandarinCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMandarinCaseQuantitySenateEN.IsLeaved = TransNullToBool(objRow[convMandarinCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvMandarinCaseQuantitySenateEN.StuIdTeacherId = objRow[convMandarinCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvMandarinCaseQuantitySenateEN.UserId = objRow[convMandarinCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMandarinCaseQuantitySenateEN.UserName = objRow[convMandarinCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMandarinCaseQuantitySenateEN.OwnerId = objRow[convMandarinCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMandarinCaseQuantitySenateEN.OwnerName = objRow[convMandarinCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMandarinCaseQuantitySenateEN.StuID = objRow[convMandarinCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuID].ToString().Trim(); //学号
objvMandarinCaseQuantitySenateEN.StuName = objRow[convMandarinCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuName].ToString().Trim(); //姓名
objvMandarinCaseQuantitySenateEN.IdMandarinCase = objRow[convMandarinCaseQuantitySenate.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.IdMandarinCase].ToString().Trim(); //普通话案例流水号
objvMandarinCaseQuantitySenateEN.MandarinCaseTypeName = objRow[convMandarinCaseQuantitySenate.MandarinCaseTypeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseTypeName].ToString().Trim(); //普通话案例类型名称
objvMandarinCaseQuantitySenateEN.UserNameWithUserId = objRow[convMandarinCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMandarinCaseQuantitySenateEN.OwnerNameWithId = objRow[convMandarinCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMandarinCaseQuantitySenateEN.IdXzCollege = objRow[convMandarinCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMandarinCaseQuantitySenateEN.CollegeNameA = objRow[convMandarinCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMandarinCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvMandarinCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMandarinCaseQuantitySenateEN);
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
public List<clsvMandarinCaseQuantitySenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMandarinCaseQuantitySenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMandarinCaseQuantitySenateEN> arrObjLst = new List<clsvMandarinCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN = new clsvMandarinCaseQuantitySenateEN();
try
{
objvMandarinCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convMandarinCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMandarinCaseQuantitySenateEN.FuncModuleId = objRow[convMandarinCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMandarinCaseQuantitySenateEN.FuncModuleName = objRow[convMandarinCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMandarinCaseQuantitySenateEN.IdAppraiseType = objRow[convMandarinCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMandarinCaseQuantitySenateEN.AppraiseTypeName = objRow[convMandarinCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMandarinCaseQuantitySenateEN.IdMicroteachCase = objRow[convMandarinCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMandarinCaseQuantitySenateEN.MandarinCaseID = objRow[convMandarinCaseQuantitySenate.MandarinCaseID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseID].ToString().Trim(); //普通话教学案例ID
objvMandarinCaseQuantitySenateEN.MandarinCaseName = objRow[convMandarinCaseQuantitySenate.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objvMandarinCaseQuantitySenateEN.MandarinCaseDate = objRow[convMandarinCaseQuantitySenate.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseDate].ToString().Trim(); //普通话教学日期
objvMandarinCaseQuantitySenateEN.SenateTheme = objRow[convMandarinCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMandarinCaseQuantitySenateEN.SenateContent = objRow[convMandarinCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMandarinCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convMandarinCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMandarinCaseQuantitySenateEN.SenateDate = objRow[convMandarinCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMandarinCaseQuantitySenateEN.SenateTime = objRow[convMandarinCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMandarinCaseQuantitySenateEN.BrowseCount = objRow[convMandarinCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMandarinCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMandarinCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMandarinCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMandarinCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMandarinCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMandarinCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMandarinCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMandarinCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMandarinCaseQuantitySenateEN.SenateIp = objRow[convMandarinCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMandarinCaseQuantitySenateEN.UpdUserName = objRow[convMandarinCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMandarinCaseQuantitySenateEN.UpdUser = objRow[convMandarinCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMandarinCaseQuantitySenateEN.CollegeID = objRow[convMandarinCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMandarinCaseQuantitySenateEN.CollegeName = objRow[convMandarinCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMandarinCaseQuantitySenateEN.IsLeaved = TransNullToBool(objRow[convMandarinCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvMandarinCaseQuantitySenateEN.StuIdTeacherId = objRow[convMandarinCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvMandarinCaseQuantitySenateEN.UserId = objRow[convMandarinCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMandarinCaseQuantitySenateEN.UserName = objRow[convMandarinCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMandarinCaseQuantitySenateEN.OwnerId = objRow[convMandarinCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMandarinCaseQuantitySenateEN.OwnerName = objRow[convMandarinCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMandarinCaseQuantitySenateEN.StuID = objRow[convMandarinCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuID].ToString().Trim(); //学号
objvMandarinCaseQuantitySenateEN.StuName = objRow[convMandarinCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuName].ToString().Trim(); //姓名
objvMandarinCaseQuantitySenateEN.IdMandarinCase = objRow[convMandarinCaseQuantitySenate.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.IdMandarinCase].ToString().Trim(); //普通话案例流水号
objvMandarinCaseQuantitySenateEN.MandarinCaseTypeName = objRow[convMandarinCaseQuantitySenate.MandarinCaseTypeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseTypeName].ToString().Trim(); //普通话案例类型名称
objvMandarinCaseQuantitySenateEN.UserNameWithUserId = objRow[convMandarinCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMandarinCaseQuantitySenateEN.OwnerNameWithId = objRow[convMandarinCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMandarinCaseQuantitySenateEN.IdXzCollege = objRow[convMandarinCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMandarinCaseQuantitySenateEN.CollegeNameA = objRow[convMandarinCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMandarinCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvMandarinCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMandarinCaseQuantitySenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMandarinCaseQuantitySenate(ref clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ objvMandarinCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMandarinCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objDT.Rows[0][convMandarinCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMandarinCaseQuantitySenateEN.FuncModuleId = objDT.Rows[0][convMandarinCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCaseQuantitySenateEN.FuncModuleName = objDT.Rows[0][convMandarinCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMandarinCaseQuantitySenateEN.IdAppraiseType = objDT.Rows[0][convMandarinCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseQuantitySenateEN.AppraiseTypeName = objDT.Rows[0][convMandarinCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseQuantitySenateEN.IdMicroteachCase = objDT.Rows[0][convMandarinCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseQuantitySenateEN.MandarinCaseID = objDT.Rows[0][convMandarinCaseQuantitySenate.MandarinCaseID].ToString().Trim(); //普通话教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseQuantitySenateEN.MandarinCaseName = objDT.Rows[0][convMandarinCaseQuantitySenate.MandarinCaseName].ToString().Trim(); //普通话教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMandarinCaseQuantitySenateEN.MandarinCaseDate = objDT.Rows[0][convMandarinCaseQuantitySenate.MandarinCaseDate].ToString().Trim(); //普通话教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseQuantitySenateEN.SenateTheme = objDT.Rows[0][convMandarinCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCaseQuantitySenateEN.SenateContent = objDT.Rows[0][convMandarinCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMandarinCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objDT.Rows[0][convMandarinCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvMandarinCaseQuantitySenateEN.SenateDate = objDT.Rows[0][convMandarinCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseQuantitySenateEN.SenateTime = objDT.Rows[0][convMandarinCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCaseQuantitySenateEN.BrowseCount = TransNullToInt(objDT.Rows[0][convMandarinCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMandarinCaseQuantitySenateEN.IdSenateGaugeVersion = objDT.Rows[0][convMandarinCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseQuantitySenateEN.senateGaugeVersionID = objDT.Rows[0][convMandarinCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseQuantitySenateEN.senateGaugeVersionName = objDT.Rows[0][convMandarinCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convMandarinCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMandarinCaseQuantitySenateEN.SenateIp = objDT.Rows[0][convMandarinCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCaseQuantitySenateEN.UpdUserName = objDT.Rows[0][convMandarinCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseQuantitySenateEN.UpdUser = objDT.Rows[0][convMandarinCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseQuantitySenateEN.CollegeID = objDT.Rows[0][convMandarinCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMandarinCaseQuantitySenateEN.CollegeName = objDT.Rows[0][convMandarinCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMandarinCaseQuantitySenateEN.IsLeaved = TransNullToBool(objDT.Rows[0][convMandarinCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCaseQuantitySenateEN.StuIdTeacherId = objDT.Rows[0][convMandarinCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseQuantitySenateEN.UserId = objDT.Rows[0][convMandarinCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvMandarinCaseQuantitySenateEN.UserName = objDT.Rows[0][convMandarinCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMandarinCaseQuantitySenateEN.OwnerId = objDT.Rows[0][convMandarinCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMandarinCaseQuantitySenateEN.OwnerName = objDT.Rows[0][convMandarinCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMandarinCaseQuantitySenateEN.StuID = objDT.Rows[0][convMandarinCaseQuantitySenate.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseQuantitySenateEN.StuName = objDT.Rows[0][convMandarinCaseQuantitySenate.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCaseQuantitySenateEN.IdMandarinCase = objDT.Rows[0][convMandarinCaseQuantitySenate.IdMandarinCase].ToString().Trim(); //普通话案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseQuantitySenateEN.MandarinCaseTypeName = objDT.Rows[0][convMandarinCaseQuantitySenate.MandarinCaseTypeName].ToString().Trim(); //普通话案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseQuantitySenateEN.UserNameWithUserId = objDT.Rows[0][convMandarinCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvMandarinCaseQuantitySenateEN.OwnerNameWithId = objDT.Rows[0][convMandarinCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvMandarinCaseQuantitySenateEN.IdXzCollege = objDT.Rows[0][convMandarinCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCaseQuantitySenateEN.CollegeNameA = objDT.Rows[0][convMandarinCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMandarinCaseQuantitySenateDA: GetvMandarinCaseQuantitySenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public clsvMandarinCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN = new clsvMandarinCaseQuantitySenateEN();
try
{
 objvMandarinCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMandarinCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMandarinCaseQuantitySenateEN.FuncModuleId = objRow[convMandarinCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCaseQuantitySenateEN.FuncModuleName = objRow[convMandarinCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMandarinCaseQuantitySenateEN.IdAppraiseType = objRow[convMandarinCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseQuantitySenateEN.AppraiseTypeName = objRow[convMandarinCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseQuantitySenateEN.IdMicroteachCase = objRow[convMandarinCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseQuantitySenateEN.MandarinCaseID = objRow[convMandarinCaseQuantitySenate.MandarinCaseID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseID].ToString().Trim(); //普通话教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseQuantitySenateEN.MandarinCaseName = objRow[convMandarinCaseQuantitySenate.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseName].ToString().Trim(); //普通话教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMandarinCaseQuantitySenateEN.MandarinCaseDate = objRow[convMandarinCaseQuantitySenate.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseDate].ToString().Trim(); //普通话教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseQuantitySenateEN.SenateTheme = objRow[convMandarinCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCaseQuantitySenateEN.SenateContent = objRow[convMandarinCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMandarinCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convMandarinCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvMandarinCaseQuantitySenateEN.SenateDate = objRow[convMandarinCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCaseQuantitySenateEN.SenateTime = objRow[convMandarinCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCaseQuantitySenateEN.BrowseCount = objRow[convMandarinCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMandarinCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMandarinCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMandarinCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMandarinCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMandarinCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCaseQuantitySenateEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convMandarinCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMandarinCaseQuantitySenateEN.SenateIp = objRow[convMandarinCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCaseQuantitySenateEN.UpdUserName = objRow[convMandarinCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseQuantitySenateEN.UpdUser = objRow[convMandarinCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseQuantitySenateEN.CollegeID = objRow[convMandarinCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMandarinCaseQuantitySenateEN.CollegeName = objRow[convMandarinCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMandarinCaseQuantitySenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convMandarinCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCaseQuantitySenateEN.StuIdTeacherId = objRow[convMandarinCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseQuantitySenateEN.UserId = objRow[convMandarinCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvMandarinCaseQuantitySenateEN.UserName = objRow[convMandarinCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMandarinCaseQuantitySenateEN.OwnerId = objRow[convMandarinCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMandarinCaseQuantitySenateEN.OwnerName = objRow[convMandarinCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMandarinCaseQuantitySenateEN.StuID = objRow[convMandarinCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCaseQuantitySenateEN.StuName = objRow[convMandarinCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCaseQuantitySenateEN.IdMandarinCase = objRow[convMandarinCaseQuantitySenate.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.IdMandarinCase].ToString().Trim(); //普通话案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCaseQuantitySenateEN.MandarinCaseTypeName = objRow[convMandarinCaseQuantitySenate.MandarinCaseTypeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseTypeName].ToString().Trim(); //普通话案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCaseQuantitySenateEN.UserNameWithUserId = objRow[convMandarinCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvMandarinCaseQuantitySenateEN.OwnerNameWithId = objRow[convMandarinCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvMandarinCaseQuantitySenateEN.IdXzCollege = objRow[convMandarinCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCaseQuantitySenateEN.CollegeNameA = objRow[convMandarinCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMandarinCaseQuantitySenateDA: GetObjByIdmicroteachCaseQuantitySenate)", objException.Message));
}
return objvMandarinCaseQuantitySenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMandarinCaseQuantitySenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMandarinCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN = new clsvMandarinCaseQuantitySenateEN()
{
IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convMandarinCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()), //微格量化评价流水号
FuncModuleId = objRow[convMandarinCaseQuantitySenate.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convMandarinCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.FuncModuleName].ToString().Trim(), //功能模块名称
IdAppraiseType = objRow[convMandarinCaseQuantitySenate.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTypeName = objRow[convMandarinCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.AppraiseTypeName].ToString().Trim(), //评议类型名称
IdMicroteachCase = objRow[convMandarinCaseQuantitySenate.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
MandarinCaseID = objRow[convMandarinCaseQuantitySenate.MandarinCaseID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseID].ToString().Trim(), //普通话教学案例ID
MandarinCaseName = objRow[convMandarinCaseQuantitySenate.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseName].ToString().Trim(), //普通话教学案例名称
MandarinCaseDate = objRow[convMandarinCaseQuantitySenate.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseDate].ToString().Trim(), //普通话教学日期
SenateTheme = objRow[convMandarinCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateTheme].ToString().Trim(), //量化评价主题
SenateContent = objRow[convMandarinCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateContent].ToString().Trim(), //评价内容
SenateTotalScore = TransNullToFloat(objRow[convMandarinCaseQuantitySenate.SenateTotalScore].ToString().Trim()), //评价分数
SenateDate = objRow[convMandarinCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateDate].ToString().Trim(), //评价日期
SenateTime = objRow[convMandarinCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateTime].ToString().Trim(), //评价时间
BrowseCount = objRow[convMandarinCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCaseQuantitySenate.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[convMandarinCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convMandarinCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convMandarinCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMandarinCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
SenateIp = objRow[convMandarinCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateIp].ToString().Trim(), //评议Ip
UpdUserName = objRow[convMandarinCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UpdUserName].ToString().Trim(), //UpdUserName
UpdUser = objRow[convMandarinCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UpdUser].ToString().Trim(), //修改人
CollegeID = objRow[convMandarinCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convMandarinCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeName].ToString().Trim(), //学院名称
IsLeaved = TransNullToBool(objRow[convMandarinCaseQuantitySenate.IsLeaved].ToString().Trim()), //IsLeaved
StuIdTeacherId = objRow[convMandarinCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuIdTeacherId].ToString().Trim(), //学工号
UserId = objRow[convMandarinCaseQuantitySenate.UserId].ToString().Trim(), //用户ID
UserName = objRow[convMandarinCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UserName].ToString().Trim(), //用户名
OwnerId = objRow[convMandarinCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convMandarinCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerName].ToString().Trim(), //拥有者姓名
StuID = objRow[convMandarinCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuID].ToString().Trim(), //学号
StuName = objRow[convMandarinCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuName].ToString().Trim(), //姓名
IdMandarinCase = objRow[convMandarinCaseQuantitySenate.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.IdMandarinCase].ToString().Trim(), //普通话案例流水号
MandarinCaseTypeName = objRow[convMandarinCaseQuantitySenate.MandarinCaseTypeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseTypeName].ToString().Trim(), //普通话案例类型名称
UserNameWithUserId = objRow[convMandarinCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
OwnerNameWithId = objRow[convMandarinCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
IdXzCollege = objRow[convMandarinCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.IdXzCollege].ToString().Trim(), //学院流水号
CollegeNameA = objRow[convMandarinCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeNameA].ToString().Trim() //学院名称简写
};
objvMandarinCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMandarinCaseQuantitySenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMandarinCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMandarinCaseQuantitySenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN = new clsvMandarinCaseQuantitySenateEN();
try
{
objvMandarinCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convMandarinCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMandarinCaseQuantitySenateEN.FuncModuleId = objRow[convMandarinCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMandarinCaseQuantitySenateEN.FuncModuleName = objRow[convMandarinCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMandarinCaseQuantitySenateEN.IdAppraiseType = objRow[convMandarinCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMandarinCaseQuantitySenateEN.AppraiseTypeName = objRow[convMandarinCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMandarinCaseQuantitySenateEN.IdMicroteachCase = objRow[convMandarinCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMandarinCaseQuantitySenateEN.MandarinCaseID = objRow[convMandarinCaseQuantitySenate.MandarinCaseID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseID].ToString().Trim(); //普通话教学案例ID
objvMandarinCaseQuantitySenateEN.MandarinCaseName = objRow[convMandarinCaseQuantitySenate.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objvMandarinCaseQuantitySenateEN.MandarinCaseDate = objRow[convMandarinCaseQuantitySenate.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseDate].ToString().Trim(); //普通话教学日期
objvMandarinCaseQuantitySenateEN.SenateTheme = objRow[convMandarinCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMandarinCaseQuantitySenateEN.SenateContent = objRow[convMandarinCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMandarinCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convMandarinCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMandarinCaseQuantitySenateEN.SenateDate = objRow[convMandarinCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMandarinCaseQuantitySenateEN.SenateTime = objRow[convMandarinCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMandarinCaseQuantitySenateEN.BrowseCount = objRow[convMandarinCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMandarinCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMandarinCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMandarinCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMandarinCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMandarinCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMandarinCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMandarinCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMandarinCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMandarinCaseQuantitySenateEN.SenateIp = objRow[convMandarinCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMandarinCaseQuantitySenateEN.UpdUserName = objRow[convMandarinCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMandarinCaseQuantitySenateEN.UpdUser = objRow[convMandarinCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMandarinCaseQuantitySenateEN.CollegeID = objRow[convMandarinCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMandarinCaseQuantitySenateEN.CollegeName = objRow[convMandarinCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMandarinCaseQuantitySenateEN.IsLeaved = TransNullToBool(objRow[convMandarinCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvMandarinCaseQuantitySenateEN.StuIdTeacherId = objRow[convMandarinCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvMandarinCaseQuantitySenateEN.UserId = objRow[convMandarinCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMandarinCaseQuantitySenateEN.UserName = objRow[convMandarinCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMandarinCaseQuantitySenateEN.OwnerId = objRow[convMandarinCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMandarinCaseQuantitySenateEN.OwnerName = objRow[convMandarinCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMandarinCaseQuantitySenateEN.StuID = objRow[convMandarinCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuID].ToString().Trim(); //学号
objvMandarinCaseQuantitySenateEN.StuName = objRow[convMandarinCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuName].ToString().Trim(); //姓名
objvMandarinCaseQuantitySenateEN.IdMandarinCase = objRow[convMandarinCaseQuantitySenate.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.IdMandarinCase].ToString().Trim(); //普通话案例流水号
objvMandarinCaseQuantitySenateEN.MandarinCaseTypeName = objRow[convMandarinCaseQuantitySenate.MandarinCaseTypeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseTypeName].ToString().Trim(); //普通话案例类型名称
objvMandarinCaseQuantitySenateEN.UserNameWithUserId = objRow[convMandarinCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMandarinCaseQuantitySenateEN.OwnerNameWithId = objRow[convMandarinCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMandarinCaseQuantitySenateEN.IdXzCollege = objRow[convMandarinCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMandarinCaseQuantitySenateEN.CollegeNameA = objRow[convMandarinCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMandarinCaseQuantitySenateDA: GetObjByDataRowvMandarinCaseQuantitySenate)", objException.Message));
}
objvMandarinCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMandarinCaseQuantitySenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMandarinCaseQuantitySenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN = new clsvMandarinCaseQuantitySenateEN();
try
{
objvMandarinCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convMandarinCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMandarinCaseQuantitySenateEN.FuncModuleId = objRow[convMandarinCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMandarinCaseQuantitySenateEN.FuncModuleName = objRow[convMandarinCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMandarinCaseQuantitySenateEN.IdAppraiseType = objRow[convMandarinCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMandarinCaseQuantitySenateEN.AppraiseTypeName = objRow[convMandarinCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMandarinCaseQuantitySenateEN.IdMicroteachCase = objRow[convMandarinCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMandarinCaseQuantitySenateEN.MandarinCaseID = objRow[convMandarinCaseQuantitySenate.MandarinCaseID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseID].ToString().Trim(); //普通话教学案例ID
objvMandarinCaseQuantitySenateEN.MandarinCaseName = objRow[convMandarinCaseQuantitySenate.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objvMandarinCaseQuantitySenateEN.MandarinCaseDate = objRow[convMandarinCaseQuantitySenate.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseDate].ToString().Trim(); //普通话教学日期
objvMandarinCaseQuantitySenateEN.SenateTheme = objRow[convMandarinCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMandarinCaseQuantitySenateEN.SenateContent = objRow[convMandarinCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMandarinCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convMandarinCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMandarinCaseQuantitySenateEN.SenateDate = objRow[convMandarinCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMandarinCaseQuantitySenateEN.SenateTime = objRow[convMandarinCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMandarinCaseQuantitySenateEN.BrowseCount = objRow[convMandarinCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMandarinCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMandarinCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMandarinCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMandarinCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMandarinCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMandarinCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMandarinCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMandarinCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMandarinCaseQuantitySenateEN.SenateIp = objRow[convMandarinCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMandarinCaseQuantitySenateEN.UpdUserName = objRow[convMandarinCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMandarinCaseQuantitySenateEN.UpdUser = objRow[convMandarinCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMandarinCaseQuantitySenateEN.CollegeID = objRow[convMandarinCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMandarinCaseQuantitySenateEN.CollegeName = objRow[convMandarinCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMandarinCaseQuantitySenateEN.IsLeaved = TransNullToBool(objRow[convMandarinCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvMandarinCaseQuantitySenateEN.StuIdTeacherId = objRow[convMandarinCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvMandarinCaseQuantitySenateEN.UserId = objRow[convMandarinCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMandarinCaseQuantitySenateEN.UserName = objRow[convMandarinCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMandarinCaseQuantitySenateEN.OwnerId = objRow[convMandarinCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMandarinCaseQuantitySenateEN.OwnerName = objRow[convMandarinCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMandarinCaseQuantitySenateEN.StuID = objRow[convMandarinCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuID].ToString().Trim(); //学号
objvMandarinCaseQuantitySenateEN.StuName = objRow[convMandarinCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.StuName].ToString().Trim(); //姓名
objvMandarinCaseQuantitySenateEN.IdMandarinCase = objRow[convMandarinCaseQuantitySenate.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.IdMandarinCase].ToString().Trim(); //普通话案例流水号
objvMandarinCaseQuantitySenateEN.MandarinCaseTypeName = objRow[convMandarinCaseQuantitySenate.MandarinCaseTypeName] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.MandarinCaseTypeName].ToString().Trim(); //普通话案例类型名称
objvMandarinCaseQuantitySenateEN.UserNameWithUserId = objRow[convMandarinCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMandarinCaseQuantitySenateEN.OwnerNameWithId = objRow[convMandarinCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMandarinCaseQuantitySenateEN.IdXzCollege = objRow[convMandarinCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMandarinCaseQuantitySenateEN.CollegeNameA = objRow[convMandarinCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMandarinCaseQuantitySenateDA: GetObjByDataRow)", objException.Message));
}
objvMandarinCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMandarinCaseQuantitySenateEN;
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
objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMandarinCaseQuantitySenateEN._CurrTabName, convMandarinCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, "");
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
objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMandarinCaseQuantitySenateEN._CurrTabName, convMandarinCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, strPrefix);
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
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vMandarinCaseQuantitySenate where " + strCondition;
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
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vMandarinCaseQuantitySenate where " + strCondition;
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
 /// <param name = "lngIdmicroteachCaseQuantitySenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdmicroteachCaseQuantitySenate)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMandarinCaseQuantitySenate", "IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMandarinCaseQuantitySenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMandarinCaseQuantitySenate", strCondition))
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
objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMandarinCaseQuantitySenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMandarinCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvMandarinCaseQuantitySenateENT">目标对象</param>
public void CopyTo(clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateENS, clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateENT)
{
objvMandarinCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvMandarinCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvMandarinCaseQuantitySenateENT.FuncModuleId = objvMandarinCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvMandarinCaseQuantitySenateENT.FuncModuleName = objvMandarinCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvMandarinCaseQuantitySenateENT.IdAppraiseType = objvMandarinCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvMandarinCaseQuantitySenateENT.AppraiseTypeName = objvMandarinCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvMandarinCaseQuantitySenateENT.IdMicroteachCase = objvMandarinCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvMandarinCaseQuantitySenateENT.MandarinCaseID = objvMandarinCaseQuantitySenateENS.MandarinCaseID; //普通话教学案例ID
objvMandarinCaseQuantitySenateENT.MandarinCaseName = objvMandarinCaseQuantitySenateENS.MandarinCaseName; //普通话教学案例名称
objvMandarinCaseQuantitySenateENT.MandarinCaseDate = objvMandarinCaseQuantitySenateENS.MandarinCaseDate; //普通话教学日期
objvMandarinCaseQuantitySenateENT.SenateTheme = objvMandarinCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvMandarinCaseQuantitySenateENT.SenateContent = objvMandarinCaseQuantitySenateENS.SenateContent; //评价内容
objvMandarinCaseQuantitySenateENT.SenateTotalScore = objvMandarinCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvMandarinCaseQuantitySenateENT.SenateDate = objvMandarinCaseQuantitySenateENS.SenateDate; //评价日期
objvMandarinCaseQuantitySenateENT.SenateTime = objvMandarinCaseQuantitySenateENS.SenateTime; //评价时间
objvMandarinCaseQuantitySenateENT.BrowseCount = objvMandarinCaseQuantitySenateENS.BrowseCount; //浏览次数
objvMandarinCaseQuantitySenateENT.IdSenateGaugeVersion = objvMandarinCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvMandarinCaseQuantitySenateENT.senateGaugeVersionID = objvMandarinCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvMandarinCaseQuantitySenateENT.senateGaugeVersionName = objvMandarinCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvMandarinCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvMandarinCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMandarinCaseQuantitySenateENT.SenateIp = objvMandarinCaseQuantitySenateENS.SenateIp; //评议Ip
objvMandarinCaseQuantitySenateENT.UpdUserName = objvMandarinCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvMandarinCaseQuantitySenateENT.UpdUser = objvMandarinCaseQuantitySenateENS.UpdUser; //修改人
objvMandarinCaseQuantitySenateENT.CollegeID = objvMandarinCaseQuantitySenateENS.CollegeID; //学院ID
objvMandarinCaseQuantitySenateENT.CollegeName = objvMandarinCaseQuantitySenateENS.CollegeName; //学院名称
objvMandarinCaseQuantitySenateENT.IsLeaved = objvMandarinCaseQuantitySenateENS.IsLeaved; //IsLeaved
objvMandarinCaseQuantitySenateENT.StuIdTeacherId = objvMandarinCaseQuantitySenateENS.StuIdTeacherId; //学工号
objvMandarinCaseQuantitySenateENT.UserId = objvMandarinCaseQuantitySenateENS.UserId; //用户ID
objvMandarinCaseQuantitySenateENT.UserName = objvMandarinCaseQuantitySenateENS.UserName; //用户名
objvMandarinCaseQuantitySenateENT.OwnerId = objvMandarinCaseQuantitySenateENS.OwnerId; //拥有者Id
objvMandarinCaseQuantitySenateENT.OwnerName = objvMandarinCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvMandarinCaseQuantitySenateENT.StuID = objvMandarinCaseQuantitySenateENS.StuID; //学号
objvMandarinCaseQuantitySenateENT.StuName = objvMandarinCaseQuantitySenateENS.StuName; //姓名
objvMandarinCaseQuantitySenateENT.IdMandarinCase = objvMandarinCaseQuantitySenateENS.IdMandarinCase; //普通话案例流水号
objvMandarinCaseQuantitySenateENT.MandarinCaseTypeName = objvMandarinCaseQuantitySenateENS.MandarinCaseTypeName; //普通话案例类型名称
objvMandarinCaseQuantitySenateENT.UserNameWithUserId = objvMandarinCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvMandarinCaseQuantitySenateENT.OwnerNameWithId = objvMandarinCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvMandarinCaseQuantitySenateENT.IdXzCollege = objvMandarinCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvMandarinCaseQuantitySenateENT.CollegeNameA = objvMandarinCaseQuantitySenateENS.CollegeNameA; //学院名称简写
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMandarinCaseQuantitySenateEN objvMandarinCaseQuantitySenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.FuncModuleId, 4, convMandarinCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.FuncModuleName, 30, convMandarinCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.IdAppraiseType, 4, convMandarinCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.AppraiseTypeName, 50, convMandarinCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.IdMicroteachCase, 8, convMandarinCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.MandarinCaseID, 8, convMandarinCaseQuantitySenate.MandarinCaseID);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.MandarinCaseName, 100, convMandarinCaseQuantitySenate.MandarinCaseName);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.MandarinCaseDate, 8, convMandarinCaseQuantitySenate.MandarinCaseDate);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.SenateTheme, 200, convMandarinCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.SenateContent, 2000, convMandarinCaseQuantitySenate.SenateContent);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.SenateDate, 8, convMandarinCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.SenateTime, 6, convMandarinCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.IdSenateGaugeVersion, 4, convMandarinCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.senateGaugeVersionID, 4, convMandarinCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.senateGaugeVersionName, 200, convMandarinCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.SenateIp, 50, convMandarinCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.UpdUserName, 20, convMandarinCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.UpdUser, 20, convMandarinCaseQuantitySenate.UpdUser);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.CollegeID, 4, convMandarinCaseQuantitySenate.CollegeID);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.CollegeName, 100, convMandarinCaseQuantitySenate.CollegeName);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.StuIdTeacherId, 20, convMandarinCaseQuantitySenate.StuIdTeacherId);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.UserId, 18, convMandarinCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.UserName, 30, convMandarinCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.OwnerId, 20, convMandarinCaseQuantitySenate.OwnerId);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.OwnerName, 30, convMandarinCaseQuantitySenate.OwnerName);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.StuID, 20, convMandarinCaseQuantitySenate.StuID);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.StuName, 50, convMandarinCaseQuantitySenate.StuName);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.IdMandarinCase, 8, convMandarinCaseQuantitySenate.IdMandarinCase);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.MandarinCaseTypeName, 50, convMandarinCaseQuantitySenate.MandarinCaseTypeName);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.UserNameWithUserId, 51, convMandarinCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.OwnerNameWithId, 51, convMandarinCaseQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.IdXzCollege, 4, convMandarinCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckFieldLen(objvMandarinCaseQuantitySenateEN.CollegeNameA, 12, convMandarinCaseQuantitySenate.CollegeNameA);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.FuncModuleId, convMandarinCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.FuncModuleName, convMandarinCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.IdAppraiseType, convMandarinCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.AppraiseTypeName, convMandarinCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.IdMicroteachCase, convMandarinCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.MandarinCaseID, convMandarinCaseQuantitySenate.MandarinCaseID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.MandarinCaseName, convMandarinCaseQuantitySenate.MandarinCaseName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.MandarinCaseDate, convMandarinCaseQuantitySenate.MandarinCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.SenateTheme, convMandarinCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.SenateContent, convMandarinCaseQuantitySenate.SenateContent);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.SenateDate, convMandarinCaseQuantitySenate.SenateDate);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.SenateTime, convMandarinCaseQuantitySenate.SenateTime);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.IdSenateGaugeVersion, convMandarinCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.senateGaugeVersionID, convMandarinCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.senateGaugeVersionName, convMandarinCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.SenateIp, convMandarinCaseQuantitySenate.SenateIp);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.UpdUserName, convMandarinCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.UpdUser, convMandarinCaseQuantitySenate.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.CollegeID, convMandarinCaseQuantitySenate.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.CollegeName, convMandarinCaseQuantitySenate.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.StuIdTeacherId, convMandarinCaseQuantitySenate.StuIdTeacherId);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.UserId, convMandarinCaseQuantitySenate.UserId);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.UserName, convMandarinCaseQuantitySenate.UserName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.OwnerId, convMandarinCaseQuantitySenate.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.OwnerName, convMandarinCaseQuantitySenate.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.StuID, convMandarinCaseQuantitySenate.StuID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.StuName, convMandarinCaseQuantitySenate.StuName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.IdMandarinCase, convMandarinCaseQuantitySenate.IdMandarinCase);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.MandarinCaseTypeName, convMandarinCaseQuantitySenate.MandarinCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.UserNameWithUserId, convMandarinCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.OwnerNameWithId, convMandarinCaseQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.IdXzCollege, convMandarinCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCaseQuantitySenateEN.CollegeNameA, convMandarinCaseQuantitySenate.CollegeNameA);
//检查外键字段长度
 objvMandarinCaseQuantitySenateEN._IsCheckProperty = true;
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
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMandarinCaseQuantitySenateEN._CurrTabName);
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
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMandarinCaseQuantitySenateEN._CurrTabName, strCondition);
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
 objSQL = clsvMandarinCaseQuantitySenateDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}