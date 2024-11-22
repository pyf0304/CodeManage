
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCaseQuantitySenateItemsDA
 表名:vMicroteachCaseQuantitySenateItems(01120493)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:54
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
 /// 微格量化评价详细(vMicroteachCaseQuantitySenateItems)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMicroteachCaseQuantitySenateItemsDA : clsCommBase4DA
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
 return clsvMicroteachCaseQuantitySenateItemsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMicroteachCaseQuantitySenateItemsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCaseQuantitySenateItemsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMicroteachCaseQuantitySenateItemsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMicroteachCaseQuantitySenateItemsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseQuantitySenateItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMicroteachCaseQuantitySenateItems(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA: GetDataTable_vMicroteachCaseQuantitySenateItems)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseQuantitySenateItems where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseQuantitySenateItems where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseQuantitySenateItems where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseQuantitySenateItems where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseQuantitySenateItems where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCaseQuantitySenateItems.* from vMicroteachCaseQuantitySenateItems Left Join {1} on {2} where {3} and vMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem not in (Select top {5} vMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem from vMicroteachCaseQuantitySenateItems Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseQuantitySenateItems where {1} and IdmicroteachCaseQuantitySenateItem not in (Select top {2} IdmicroteachCaseQuantitySenateItem from vMicroteachCaseQuantitySenateItems where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseQuantitySenateItems where {1} and IdmicroteachCaseQuantitySenateItem not in (Select top {3} IdmicroteachCaseQuantitySenateItem from vMicroteachCaseQuantitySenateItems where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCaseQuantitySenateItems.* from vMicroteachCaseQuantitySenateItems Left Join {1} on {2} where {3} and vMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem not in (Select top {5} vMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem from vMicroteachCaseQuantitySenateItems Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseQuantitySenateItems where {1} and IdmicroteachCaseQuantitySenateItem not in (Select top {2} IdmicroteachCaseQuantitySenateItem from vMicroteachCaseQuantitySenateItems where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseQuantitySenateItems where {1} and IdmicroteachCaseQuantitySenateItem not in (Select top {3} IdmicroteachCaseQuantitySenateItem from vMicroteachCaseQuantitySenateItems where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA:GetObjLst)", objException.Message));
}
List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItemsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseQuantitySenateItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = new clsvMicroteachCaseQuantitySenateItemsEN();
try
{
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[convMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvMicroteachCaseQuantitySenateItemsEN.UserId = objRow[convMicroteachCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateItemsEN.UserName = objRow[convMicroteachCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateItemsEN.CollegeID = objRow[convMicroteachCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateItemsEN.CollegeName = objRow[convMicroteachCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = objRow[convMicroteachCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateItemsEN.SenateContent = objRow[convMicroteachCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateItemsEN.SenateDate = objRow[convMicroteachCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateItemsEN.SenateTime = objRow[convMicroteachCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvMicroteachCaseQuantitySenateItemsEN.GridTitle = objRow[convMicroteachCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = objRow[convMicroteachCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = objRow[convMicroteachCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvMicroteachCaseQuantitySenateItemsEN.OwnerId = objRow[convMicroteachCaseQuantitySenateItems.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateItemsEN.OwnerName = objRow[convMicroteachCaseQuantitySenateItems.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateItemsEN.SenateIp = objRow[convMicroteachCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = objRow[convMicroteachCaseQuantitySenateItems.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateItemsEN.IsAccess = TransNullToBool(objRow[convMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = TransNullToBool(objRow[convMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[convMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[convMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindId = objRow[convMicroteachCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindName = objRow[convMicroteachCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = objRow[convMicroteachCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA: GetObjLst)", objException.Message));
}
objvMicroteachCaseQuantitySenateItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItemsEN);
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
public List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItemsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = new clsvMicroteachCaseQuantitySenateItemsEN();
try
{
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[convMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvMicroteachCaseQuantitySenateItemsEN.UserId = objRow[convMicroteachCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateItemsEN.UserName = objRow[convMicroteachCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateItemsEN.CollegeID = objRow[convMicroteachCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateItemsEN.CollegeName = objRow[convMicroteachCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = objRow[convMicroteachCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateItemsEN.SenateContent = objRow[convMicroteachCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateItemsEN.SenateDate = objRow[convMicroteachCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateItemsEN.SenateTime = objRow[convMicroteachCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvMicroteachCaseQuantitySenateItemsEN.GridTitle = objRow[convMicroteachCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = objRow[convMicroteachCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = objRow[convMicroteachCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvMicroteachCaseQuantitySenateItemsEN.OwnerId = objRow[convMicroteachCaseQuantitySenateItems.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateItemsEN.OwnerName = objRow[convMicroteachCaseQuantitySenateItems.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateItemsEN.SenateIp = objRow[convMicroteachCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = objRow[convMicroteachCaseQuantitySenateItems.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateItemsEN.IsAccess = TransNullToBool(objRow[convMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = TransNullToBool(objRow[convMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[convMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[convMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindId = objRow[convMicroteachCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindName = objRow[convMicroteachCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = objRow[convMicroteachCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA: GetObjLst)", objException.Message));
}
objvMicroteachCaseQuantitySenateItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItemsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMicroteachCaseQuantitySenateItems(ref clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseQuantitySenateItems where IdmicroteachCaseQuantitySenateItem = " + ""+ objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = TransNullToInt(objDT.Rows[0][convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号(字段类型:bigint,字段长度:8,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objDT.Rows[0][convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder(字段类型:varchar,字段长度:204,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = TransNullToFloat(objDT.Rows[0][convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重(字段类型:float,字段长度:8,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.SenateScore = TransNullToFloat(objDT.Rows[0][convMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分(字段类型:float,字段长度:8,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = TransNullToFloat(objDT.Rows[0][convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数(字段类型:float,字段长度:8,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.UserId = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.UserName = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.CollegeID = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.CollegeName = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.SenateContent = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.SenateDate = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.SenateTime = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = TransNullToFloat(objDT.Rows[0][convMicroteachCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.GridTitle = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convMicroteachCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = TransNullToInt(objDT.Rows[0][convMicroteachCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = TransNullToInt(objDT.Rows[0][convMicroteachCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.OwnerId = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.OwnerName = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.SenateIp = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.IsAccess = TransNullToBool(objDT.Rows[0][convMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = TransNullToBool(objDT.Rows[0][convMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.UpdDate = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.UpdUser = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.UserKindId = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.UserKindName = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = objDT.Rows[0][convMicroteachCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA: GetvMicroteachCaseQuantitySenateItems)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenateItem">表关键字</param>
 /// <returns>表对象</returns>
public clsvMicroteachCaseQuantitySenateItemsEN GetObjByIdmicroteachCaseQuantitySenateItem(long lngIdmicroteachCaseQuantitySenateItem)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseQuantitySenateItems where IdmicroteachCaseQuantitySenateItem = " + ""+ lngIdmicroteachCaseQuantitySenateItem+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = new clsvMicroteachCaseQuantitySenateItemsEN();
try
{
 objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号(字段类型:bigint,字段长度:8,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder(字段类型:varchar,字段长度:204,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重(字段类型:float,字段长度:8,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[convMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分(字段类型:float,字段长度:8,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数(字段类型:float,字段长度:8,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.UserId = objRow[convMicroteachCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.UserName = objRow[convMicroteachCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.CollegeID = objRow[convMicroteachCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.CollegeName = objRow[convMicroteachCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = objRow[convMicroteachCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.SenateContent = objRow[convMicroteachCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.SenateDate = objRow[convMicroteachCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.SenateTime = objRow[convMicroteachCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.GridTitle = objRow[convMicroteachCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = objRow[convMicroteachCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = objRow[convMicroteachCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.OwnerId = objRow[convMicroteachCaseQuantitySenateItems.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.OwnerName = objRow[convMicroteachCaseQuantitySenateItems.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.SenateIp = objRow[convMicroteachCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = objRow[convMicroteachCaseQuantitySenateItems.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[convMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[convMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.UserKindId = objRow[convMicroteachCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.UserKindName = objRow[convMicroteachCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = objRow[convMicroteachCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA: GetObjByIdmicroteachCaseQuantitySenateItem)", objException.Message));
}
return objvMicroteachCaseQuantitySenateItemsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMicroteachCaseQuantitySenateItemsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseQuantitySenateItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = new clsvMicroteachCaseQuantitySenateItemsEN()
{
IdmicroteachCaseQuantitySenateItem = TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()), //微格量化评价指标流水号
IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()), //微格量化评价流水号
IdMicroteachCase = objRow[convMicroteachCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
MicroteachCaseID = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID].ToString().Trim(), //微格教学案例ID
MicroteachCaseName = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName].ToString().Trim(), //微格教学案例名称
IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(), //量表指标流水号
senateGaugeItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(), //量表指标ID
senateGaugeItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(), //量表指标名称
senateGaugeItemNameWithOrder = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(), //量表指标名称WithOrder
senateGaugeItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(), //量表指标说明
senateGaugeItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(), //备注
senateGaugeItemWeight = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()), //量表指标权重
SenateScore = objRow[convMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()), //指标得分
IdSenateGaugeSubItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(), //量表指标子项流水号
senateGaugeSubItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(), //量表指标子项ID
senateGaugeSubItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(), //量表指标子项名称
senateGaugeSubItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(), //量表指标子项说明
senateGaugeSubItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(), //量表指标子项备注
senateGaugeSubItemScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()), //量表指标子项分数
UserId = objRow[convMicroteachCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserId].ToString().Trim(), //用户ID
UserName = objRow[convMicroteachCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserName].ToString().Trim(), //用户名
CollegeID = objRow[convMicroteachCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convMicroteachCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeName].ToString().Trim(), //学院名称
SenateTheme = objRow[convMicroteachCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTheme].ToString().Trim(), //量化评价主题
SenateContent = objRow[convMicroteachCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateContent].ToString().Trim(), //评价内容
SenateDate = objRow[convMicroteachCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateDate].ToString().Trim(), //评价日期
SenateTime = objRow[convMicroteachCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTime].ToString().Trim(), //评价时间
SenateTotalScore = objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()), //评价分数
AnswerModeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId].ToString().Trim(), //答案模式Id
AnswerTypeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(), //答案类型ID
GridTitle = objRow[convMicroteachCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.GridTitle].ToString().Trim(), //表格标题
QuestionIndex = objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex].ToString().Trim()), //题目序号
QuestionNo = objRow[convMicroteachCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionNo].ToString().Trim(), //题目编号
QuestionTypeId = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(), //题目类型Id
AnswerModeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName].ToString().Trim(), //答案模式名称
AnswerNum = objRow[convMicroteachCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.AnswerNum].ToString().Trim()), //答案数
AnswerTypeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(), //答案类型名
QuestionTypeName = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(), //题目类型名
senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
AnswerIndex = objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex].ToString().Trim()), //问答序号
AnswerTitle = objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle].ToString().Trim(), //答案标题
OwnerId = objRow[convMicroteachCaseQuantitySenateItems.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convMicroteachCaseQuantitySenateItems.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
SenateIp = objRow[convMicroteachCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateIp].ToString().Trim(), //评议Ip
UserNameWithUserId = objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
UserTypeId = objRow[convMicroteachCaseQuantitySenateItems.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeId].ToString().Trim(), //用户类型Id
IsAccess = TransNullToBool(objRow[convMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()), //IsAccess
IsAccessC = TransNullToBool(objRow[convMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()), //IsAccessC
UpdDate = objRow[convMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(), //修改人
IdAppraiseType = objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTypeName = objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(), //评议类型名称
FuncModuleId = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId].ToString().Trim(), //功能模块Id
UserKindId = objRow[convMicroteachCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convMicroteachCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindName].ToString().Trim(), //用户类别名
UserTypeName = objRow[convMicroteachCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeName].ToString().Trim(), //用户类型名称
FuncModuleName = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName].ToString().Trim(), //功能模块名称
IdXzCollege = objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege].ToString().Trim(), //学院流水号
CollegeNameA = objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA].ToString().Trim() //学院名称简写
};
objvMicroteachCaseQuantitySenateItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCaseQuantitySenateItemsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCaseQuantitySenateItemsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = new clsvMicroteachCaseQuantitySenateItemsEN();
try
{
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[convMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvMicroteachCaseQuantitySenateItemsEN.UserId = objRow[convMicroteachCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateItemsEN.UserName = objRow[convMicroteachCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateItemsEN.CollegeID = objRow[convMicroteachCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateItemsEN.CollegeName = objRow[convMicroteachCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = objRow[convMicroteachCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateItemsEN.SenateContent = objRow[convMicroteachCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateItemsEN.SenateDate = objRow[convMicroteachCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateItemsEN.SenateTime = objRow[convMicroteachCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvMicroteachCaseQuantitySenateItemsEN.GridTitle = objRow[convMicroteachCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = objRow[convMicroteachCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = objRow[convMicroteachCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvMicroteachCaseQuantitySenateItemsEN.OwnerId = objRow[convMicroteachCaseQuantitySenateItems.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateItemsEN.OwnerName = objRow[convMicroteachCaseQuantitySenateItems.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateItemsEN.SenateIp = objRow[convMicroteachCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = objRow[convMicroteachCaseQuantitySenateItems.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateItemsEN.IsAccess = TransNullToBool(objRow[convMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = TransNullToBool(objRow[convMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[convMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[convMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindId = objRow[convMicroteachCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindName = objRow[convMicroteachCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = objRow[convMicroteachCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA: GetObjByDataRowvMicroteachCaseQuantitySenateItems)", objException.Message));
}
objvMicroteachCaseQuantitySenateItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCaseQuantitySenateItemsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCaseQuantitySenateItemsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = new clsvMicroteachCaseQuantitySenateItemsEN();
try
{
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[convMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvMicroteachCaseQuantitySenateItemsEN.UserId = objRow[convMicroteachCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateItemsEN.UserName = objRow[convMicroteachCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateItemsEN.CollegeID = objRow[convMicroteachCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateItemsEN.CollegeName = objRow[convMicroteachCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = objRow[convMicroteachCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateItemsEN.SenateContent = objRow[convMicroteachCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateItemsEN.SenateDate = objRow[convMicroteachCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateItemsEN.SenateTime = objRow[convMicroteachCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvMicroteachCaseQuantitySenateItemsEN.GridTitle = objRow[convMicroteachCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = objRow[convMicroteachCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = objRow[convMicroteachCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvMicroteachCaseQuantitySenateItemsEN.OwnerId = objRow[convMicroteachCaseQuantitySenateItems.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateItemsEN.OwnerName = objRow[convMicroteachCaseQuantitySenateItems.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateItemsEN.SenateIp = objRow[convMicroteachCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = objRow[convMicroteachCaseQuantitySenateItems.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateItemsEN.IsAccess = TransNullToBool(objRow[convMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = TransNullToBool(objRow[convMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[convMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[convMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindId = objRow[convMicroteachCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindName = objRow[convMicroteachCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = objRow[convMicroteachCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA: GetObjByDataRow)", objException.Message));
}
objvMicroteachCaseQuantitySenateItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCaseQuantitySenateItemsEN;
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
objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCaseQuantitySenateItemsEN._CurrTabName, convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem, 8, "");
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
objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCaseQuantitySenateItemsEN._CurrTabName, convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem, 8, strPrefix);
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
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenateItem from vMicroteachCaseQuantitySenateItems where " + strCondition;
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
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenateItem from vMicroteachCaseQuantitySenateItems where " + strCondition;
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
 /// <param name = "lngIdmicroteachCaseQuantitySenateItem">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdmicroteachCaseQuantitySenateItem)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCaseQuantitySenateItems", "IdmicroteachCaseQuantitySenateItem = " + ""+ lngIdmicroteachCaseQuantitySenateItem+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateItemsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCaseQuantitySenateItems", strCondition))
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
objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMicroteachCaseQuantitySenateItems");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsENS">源对象</param>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsENT">目标对象</param>
public void CopyTo(clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsENS, clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsENT)
{
objvMicroteachCaseQuantitySenateItemsENT.IdmicroteachCaseQuantitySenateItem = objvMicroteachCaseQuantitySenateItemsENS.IdmicroteachCaseQuantitySenateItem; //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsENT.IdmicroteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateItemsENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsENT.IdMicroteachCase = objvMicroteachCaseQuantitySenateItemsENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsENT.MicroteachCaseID = objvMicroteachCaseQuantitySenateItemsENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsENT.MicroteachCaseName = objvMicroteachCaseQuantitySenateItemsENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsENT.IdSenateGaugeItem = objvMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeItem; //量表指标流水号
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemID = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemID; //量表指标ID
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemName = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemName; //量表指标名称
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemNameWithOrder = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemNameWithOrder; //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemDesc = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemDesc; //量表指标说明
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemMemo = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemMemo; //备注
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemWeight = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemWeight; //量表指标权重
objvMicroteachCaseQuantitySenateItemsENT.SenateScore = objvMicroteachCaseQuantitySenateItemsENS.SenateScore; //指标得分
objvMicroteachCaseQuantitySenateItemsENT.IdSenateGaugeSubItem = objvMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeSubItem; //量表指标子项流水号
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeSubItemID = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeSubItemID; //量表指标子项ID
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeSubItemName = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeSubItemName; //量表指标子项名称
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeSubItemDesc = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeSubItemDesc; //量表指标子项说明
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeSubItemMemo = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeSubItemMemo; //量表指标子项备注
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeSubItemScore = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeSubItemScore; //量表指标子项分数
objvMicroteachCaseQuantitySenateItemsENT.UserId = objvMicroteachCaseQuantitySenateItemsENS.UserId; //用户ID
objvMicroteachCaseQuantitySenateItemsENT.UserName = objvMicroteachCaseQuantitySenateItemsENS.UserName; //用户名
objvMicroteachCaseQuantitySenateItemsENT.CollegeID = objvMicroteachCaseQuantitySenateItemsENS.CollegeID; //学院ID
objvMicroteachCaseQuantitySenateItemsENT.CollegeName = objvMicroteachCaseQuantitySenateItemsENS.CollegeName; //学院名称
objvMicroteachCaseQuantitySenateItemsENT.SenateTheme = objvMicroteachCaseQuantitySenateItemsENS.SenateTheme; //量化评价主题
objvMicroteachCaseQuantitySenateItemsENT.SenateContent = objvMicroteachCaseQuantitySenateItemsENS.SenateContent; //评价内容
objvMicroteachCaseQuantitySenateItemsENT.SenateDate = objvMicroteachCaseQuantitySenateItemsENS.SenateDate; //评价日期
objvMicroteachCaseQuantitySenateItemsENT.SenateTime = objvMicroteachCaseQuantitySenateItemsENS.SenateTime; //评价时间
objvMicroteachCaseQuantitySenateItemsENT.SenateTotalScore = objvMicroteachCaseQuantitySenateItemsENS.SenateTotalScore; //评价分数
objvMicroteachCaseQuantitySenateItemsENT.AnswerModeId = objvMicroteachCaseQuantitySenateItemsENS.AnswerModeId; //答案模式Id
objvMicroteachCaseQuantitySenateItemsENT.AnswerTypeId = objvMicroteachCaseQuantitySenateItemsENS.AnswerTypeId; //答案类型ID
objvMicroteachCaseQuantitySenateItemsENT.GridTitle = objvMicroteachCaseQuantitySenateItemsENS.GridTitle; //表格标题
objvMicroteachCaseQuantitySenateItemsENT.QuestionIndex = objvMicroteachCaseQuantitySenateItemsENS.QuestionIndex; //题目序号
objvMicroteachCaseQuantitySenateItemsENT.QuestionNo = objvMicroteachCaseQuantitySenateItemsENS.QuestionNo; //题目编号
objvMicroteachCaseQuantitySenateItemsENT.QuestionTypeId = objvMicroteachCaseQuantitySenateItemsENS.QuestionTypeId; //题目类型Id
objvMicroteachCaseQuantitySenateItemsENT.AnswerModeName = objvMicroteachCaseQuantitySenateItemsENS.AnswerModeName; //答案模式名称
objvMicroteachCaseQuantitySenateItemsENT.AnswerNum = objvMicroteachCaseQuantitySenateItemsENS.AnswerNum; //答案数
objvMicroteachCaseQuantitySenateItemsENT.AnswerTypeName = objvMicroteachCaseQuantitySenateItemsENS.AnswerTypeName; //答案类型名
objvMicroteachCaseQuantitySenateItemsENT.QuestionTypeName = objvMicroteachCaseQuantitySenateItemsENS.QuestionTypeName; //题目类型名
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeVersionID = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeVersionName = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeVersionTtlScore = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCaseQuantitySenateItemsENT.IdSenateGaugeVersion = objvMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeVersion; //评价量表版本流水号
objvMicroteachCaseQuantitySenateItemsENT.AnswerIndex = objvMicroteachCaseQuantitySenateItemsENS.AnswerIndex; //问答序号
objvMicroteachCaseQuantitySenateItemsENT.AnswerTitle = objvMicroteachCaseQuantitySenateItemsENS.AnswerTitle; //答案标题
objvMicroteachCaseQuantitySenateItemsENT.OwnerId = objvMicroteachCaseQuantitySenateItemsENS.OwnerId; //拥有者Id
objvMicroteachCaseQuantitySenateItemsENT.OwnerName = objvMicroteachCaseQuantitySenateItemsENS.OwnerName; //拥有者姓名
objvMicroteachCaseQuantitySenateItemsENT.OwnerNameWithId = objvMicroteachCaseQuantitySenateItemsENS.OwnerNameWithId; //拥有者名称附Id
objvMicroteachCaseQuantitySenateItemsENT.SenateIp = objvMicroteachCaseQuantitySenateItemsENS.SenateIp; //评议Ip
objvMicroteachCaseQuantitySenateItemsENT.UserNameWithUserId = objvMicroteachCaseQuantitySenateItemsENS.UserNameWithUserId; //UserNameWithUserId
objvMicroteachCaseQuantitySenateItemsENT.UserTypeId = objvMicroteachCaseQuantitySenateItemsENS.UserTypeId; //用户类型Id
objvMicroteachCaseQuantitySenateItemsENT.IsAccess = objvMicroteachCaseQuantitySenateItemsENS.IsAccess; //IsAccess
objvMicroteachCaseQuantitySenateItemsENT.IsAccessC = objvMicroteachCaseQuantitySenateItemsENS.IsAccessC; //IsAccessC
objvMicroteachCaseQuantitySenateItemsENT.UpdDate = objvMicroteachCaseQuantitySenateItemsENS.UpdDate; //修改日期
objvMicroteachCaseQuantitySenateItemsENT.UpdUser = objvMicroteachCaseQuantitySenateItemsENS.UpdUser; //修改人
objvMicroteachCaseQuantitySenateItemsENT.IdAppraiseType = objvMicroteachCaseQuantitySenateItemsENS.IdAppraiseType; //评议类型流水号
objvMicroteachCaseQuantitySenateItemsENT.AppraiseTypeName = objvMicroteachCaseQuantitySenateItemsENS.AppraiseTypeName; //评议类型名称
objvMicroteachCaseQuantitySenateItemsENT.FuncModuleId = objvMicroteachCaseQuantitySenateItemsENS.FuncModuleId; //功能模块Id
objvMicroteachCaseQuantitySenateItemsENT.UserKindId = objvMicroteachCaseQuantitySenateItemsENS.UserKindId; //用户类别Id
objvMicroteachCaseQuantitySenateItemsENT.UserKindName = objvMicroteachCaseQuantitySenateItemsENS.UserKindName; //用户类别名
objvMicroteachCaseQuantitySenateItemsENT.UserTypeName = objvMicroteachCaseQuantitySenateItemsENS.UserTypeName; //用户类型名称
objvMicroteachCaseQuantitySenateItemsENT.FuncModuleName = objvMicroteachCaseQuantitySenateItemsENS.FuncModuleName; //功能模块名称
objvMicroteachCaseQuantitySenateItemsENT.IdXzCollege = objvMicroteachCaseQuantitySenateItemsENS.IdXzCollege; //学院流水号
objvMicroteachCaseQuantitySenateItemsENT.CollegeNameA = objvMicroteachCaseQuantitySenateItemsENS.CollegeNameA; //学院名称简写
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase, 8, convMicroteachCaseQuantitySenateItems.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID, 8, convMicroteachCaseQuantitySenateItems.MicroteachCaseID);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName, 100, convMicroteachCaseQuantitySenateItems.MicroteachCaseName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem, 4, convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID, 4, convMicroteachCaseQuantitySenateItems.senateGaugeItemID);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName, 200, convMicroteachCaseQuantitySenateItems.senateGaugeItemName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder, 204, convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc, 2000, convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo, 1000, convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem, 4, convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID, 4, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName, 200, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc, 2000, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo, 1000, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.UserId, 18, convMicroteachCaseQuantitySenateItems.UserId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.UserName, 30, convMicroteachCaseQuantitySenateItems.UserName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.CollegeID, 4, convMicroteachCaseQuantitySenateItems.CollegeID);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.CollegeName, 100, convMicroteachCaseQuantitySenateItems.CollegeName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.SenateTheme, 200, convMicroteachCaseQuantitySenateItems.SenateTheme);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.SenateContent, 2000, convMicroteachCaseQuantitySenateItems.SenateContent);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.SenateDate, 8, convMicroteachCaseQuantitySenateItems.SenateDate);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.SenateTime, 6, convMicroteachCaseQuantitySenateItems.SenateTime);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId, 4, convMicroteachCaseQuantitySenateItems.AnswerModeId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId, 2, convMicroteachCaseQuantitySenateItems.AnswerTypeId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.GridTitle, 30, convMicroteachCaseQuantitySenateItems.GridTitle);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.QuestionNo, 10, convMicroteachCaseQuantitySenateItems.QuestionNo);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId, 2, convMicroteachCaseQuantitySenateItems.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName, 30, convMicroteachCaseQuantitySenateItems.AnswerModeName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName, 50, convMicroteachCaseQuantitySenateItems.AnswerTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName, 20, convMicroteachCaseQuantitySenateItems.QuestionTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID, 4, convMicroteachCaseQuantitySenateItems.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName, 200, convMicroteachCaseQuantitySenateItems.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion, 4, convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle, 20, convMicroteachCaseQuantitySenateItems.AnswerTitle);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.OwnerId, 20, convMicroteachCaseQuantitySenateItems.OwnerId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.OwnerName, 30, convMicroteachCaseQuantitySenateItems.OwnerName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId, 51, convMicroteachCaseQuantitySenateItems.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.SenateIp, 50, convMicroteachCaseQuantitySenateItems.SenateIp);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId, 51, convMicroteachCaseQuantitySenateItems.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.UserTypeId, 2, convMicroteachCaseQuantitySenateItems.UserTypeId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.UpdDate, 20, convMicroteachCaseQuantitySenateItems.UpdDate);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.UpdUser, 20, convMicroteachCaseQuantitySenateItems.UpdUser);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType, 4, convMicroteachCaseQuantitySenateItems.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName, 50, convMicroteachCaseQuantitySenateItems.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId, 4, convMicroteachCaseQuantitySenateItems.FuncModuleId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.UserKindId, 2, convMicroteachCaseQuantitySenateItems.UserKindId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.UserKindName, 30, convMicroteachCaseQuantitySenateItems.UserKindName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.UserTypeName, 20, convMicroteachCaseQuantitySenateItems.UserTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName, 30, convMicroteachCaseQuantitySenateItems.FuncModuleName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege, 4, convMicroteachCaseQuantitySenateItems.IdXzCollege);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA, 12, convMicroteachCaseQuantitySenateItems.CollegeNameA);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase, convMicroteachCaseQuantitySenateItems.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID, convMicroteachCaseQuantitySenateItems.MicroteachCaseID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName, convMicroteachCaseQuantitySenateItems.MicroteachCaseName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem, convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID, convMicroteachCaseQuantitySenateItems.senateGaugeItemID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName, convMicroteachCaseQuantitySenateItems.senateGaugeItemName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder, convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc, convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo, convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem, convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.UserId, convMicroteachCaseQuantitySenateItems.UserId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.UserName, convMicroteachCaseQuantitySenateItems.UserName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.CollegeID, convMicroteachCaseQuantitySenateItems.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.CollegeName, convMicroteachCaseQuantitySenateItems.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.SenateTheme, convMicroteachCaseQuantitySenateItems.SenateTheme);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.SenateContent, convMicroteachCaseQuantitySenateItems.SenateContent);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.SenateDate, convMicroteachCaseQuantitySenateItems.SenateDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.SenateTime, convMicroteachCaseQuantitySenateItems.SenateTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId, convMicroteachCaseQuantitySenateItems.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId, convMicroteachCaseQuantitySenateItems.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.GridTitle, convMicroteachCaseQuantitySenateItems.GridTitle);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.QuestionNo, convMicroteachCaseQuantitySenateItems.QuestionNo);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId, convMicroteachCaseQuantitySenateItems.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName, convMicroteachCaseQuantitySenateItems.AnswerModeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName, convMicroteachCaseQuantitySenateItems.AnswerTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName, convMicroteachCaseQuantitySenateItems.QuestionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID, convMicroteachCaseQuantitySenateItems.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName, convMicroteachCaseQuantitySenateItems.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion, convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle, convMicroteachCaseQuantitySenateItems.AnswerTitle);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.OwnerId, convMicroteachCaseQuantitySenateItems.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.OwnerName, convMicroteachCaseQuantitySenateItems.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId, convMicroteachCaseQuantitySenateItems.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.SenateIp, convMicroteachCaseQuantitySenateItems.SenateIp);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId, convMicroteachCaseQuantitySenateItems.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.UserTypeId, convMicroteachCaseQuantitySenateItems.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.UpdDate, convMicroteachCaseQuantitySenateItems.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.UpdUser, convMicroteachCaseQuantitySenateItems.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType, convMicroteachCaseQuantitySenateItems.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName, convMicroteachCaseQuantitySenateItems.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId, convMicroteachCaseQuantitySenateItems.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.UserKindId, convMicroteachCaseQuantitySenateItems.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.UserKindName, convMicroteachCaseQuantitySenateItems.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.UserTypeName, convMicroteachCaseQuantitySenateItems.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName, convMicroteachCaseQuantitySenateItems.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege, convMicroteachCaseQuantitySenateItems.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA, convMicroteachCaseQuantitySenateItems.CollegeNameA);
//检查外键字段长度
 objvMicroteachCaseQuantitySenateItemsEN._IsCheckProperty = true;
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
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCaseQuantitySenateItemsEN._CurrTabName);
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
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCaseQuantitySenateItemsEN._CurrTabName, strCondition);
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
 objSQL = clsvMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}