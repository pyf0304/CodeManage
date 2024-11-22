
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSenateGaugeSubItemsDA
 表名:vSenateGaugeSubItems(01120479)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数(SenateGaugePara)
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
 /// v量表指标子项(vSenateGaugeSubItems)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvSenateGaugeSubItemsDA : clsCommBase4DA
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
 return clsvSenateGaugeSubItemsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvSenateGaugeSubItemsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSenateGaugeSubItemsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvSenateGaugeSubItemsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvSenateGaugeSubItemsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdSenateGaugeSubItem">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdSenateGaugeSubItem)
{
strIdSenateGaugeSubItem = strIdSenateGaugeSubItem.Replace("'", "''");
if (strIdSenateGaugeSubItem.Length > 4)
{
throw new Exception("(errid:Data000001)在表:vSenateGaugeSubItems中,检查关键字,长度不正确!(clsvSenateGaugeSubItemsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdSenateGaugeSubItem)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vSenateGaugeSubItems中,关键字不能为空 或 null!(clsvSenateGaugeSubItemsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSenateGaugeSubItem);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvSenateGaugeSubItemsDA:CheckPrimaryKey)", objException.Message));
}
return true;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvSenateGaugeSubItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeSubItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vSenateGaugeSubItems(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvSenateGaugeSubItemsDA: GetDataTable_vSenateGaugeSubItems)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeSubItems where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvSenateGaugeSubItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvSenateGaugeSubItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeSubItems where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvSenateGaugeSubItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvSenateGaugeSubItemsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeSubItems where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeSubItems where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvSenateGaugeSubItemsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vSenateGaugeSubItems where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvSenateGaugeSubItemsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vSenateGaugeSubItems.* from vSenateGaugeSubItems Left Join {1} on {2} where {3} and vSenateGaugeSubItems.IdSenateGaugeSubItem not in (Select top {5} vSenateGaugeSubItems.IdSenateGaugeSubItem from vSenateGaugeSubItems Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeSubItems where {1} and IdSenateGaugeSubItem not in (Select top {2} IdSenateGaugeSubItem from vSenateGaugeSubItems where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeSubItems where {1} and IdSenateGaugeSubItem not in (Select top {3} IdSenateGaugeSubItem from vSenateGaugeSubItems where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvSenateGaugeSubItemsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vSenateGaugeSubItems.* from vSenateGaugeSubItems Left Join {1} on {2} where {3} and vSenateGaugeSubItems.IdSenateGaugeSubItem not in (Select top {5} vSenateGaugeSubItems.IdSenateGaugeSubItem from vSenateGaugeSubItems Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeSubItems where {1} and IdSenateGaugeSubItem not in (Select top {2} IdSenateGaugeSubItem from vSenateGaugeSubItems where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeSubItems where {1} and IdSenateGaugeSubItem not in (Select top {3} IdSenateGaugeSubItem from vSenateGaugeSubItems where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvSenateGaugeSubItemsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvSenateGaugeSubItemsDA:GetObjLst)", objException.Message));
}
List<clsvSenateGaugeSubItemsEN> arrObjLst = new List<clsvSenateGaugeSubItemsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeSubItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = new clsvSenateGaugeSubItemsEN();
try
{
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[convSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[convSenateGaugeSubItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[convSenateGaugeSubItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeSubItemsEN.senateGaugeItemName = objRow[convSenateGaugeSubItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeSubItemsEN.senateGaugeVersionName = objRow[convSenateGaugeSubItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = objRow[convSenateGaugeSubItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeSubItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeSubItemsEN.senateGaugeItemID = objRow[convSenateGaugeSubItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvSenateGaugeSubItemsEN.AnswerTitle = objRow[convSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objvSenateGaugeSubItemsEN.AnswerIndex = objRow[convSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objvSenateGaugeSubItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeSubItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeSubItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeSubItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeSubItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvSenateGaugeSubItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeSubItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeSubItemsEN.senateGaugeVersionID = objRow[convSenateGaugeSubItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convSenateGaugeSubItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll].ToString().Trim(); //子项等地分数
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2].ToString().Trim(); //senateGaugeSubItemAll2
objvSenateGaugeSubItemsEN.VersionNo = objRow[convSenateGaugeSubItems.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeSubItemsEN.IsUse = TransNullToBool(objRow[convSenateGaugeSubItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeSubItemsEN.UpdDate = objRow[convSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeSubItemsEN.UpdUserId = objRow[convSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeSubItemsEN.AnswerModeId = objRow[convSenateGaugeSubItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeSubItemsEN.AnswerModeName = objRow[convSenateGaugeSubItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeSubItemsEN.AnswerNum = objRow[convSenateGaugeSubItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeSubItemsEN.AnswerTypeId = objRow[convSenateGaugeSubItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeSubItemsEN.AnswerTypeName = objRow[convSenateGaugeSubItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeSubItemsEN.GridTitle = objRow[convSenateGaugeSubItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convSenateGaugeSubItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvSenateGaugeSubItemsEN.QuestionIndex = objRow[convSenateGaugeSubItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeSubItemsEN.QuestionNo = objRow[convSenateGaugeSubItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeSubItemsEN.QuestionTypeId = objRow[convSenateGaugeSubItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeSubItemsEN.QuestionTypeName = objRow[convSenateGaugeSubItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeSubItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSenateGaugeSubItemsDA: GetObjLst)", objException.Message));
}
objvSenateGaugeSubItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSenateGaugeSubItemsEN);
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
public List<clsvSenateGaugeSubItemsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvSenateGaugeSubItemsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvSenateGaugeSubItemsEN> arrObjLst = new List<clsvSenateGaugeSubItemsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = new clsvSenateGaugeSubItemsEN();
try
{
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[convSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[convSenateGaugeSubItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[convSenateGaugeSubItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeSubItemsEN.senateGaugeItemName = objRow[convSenateGaugeSubItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeSubItemsEN.senateGaugeVersionName = objRow[convSenateGaugeSubItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = objRow[convSenateGaugeSubItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeSubItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeSubItemsEN.senateGaugeItemID = objRow[convSenateGaugeSubItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvSenateGaugeSubItemsEN.AnswerTitle = objRow[convSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objvSenateGaugeSubItemsEN.AnswerIndex = objRow[convSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objvSenateGaugeSubItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeSubItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeSubItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeSubItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeSubItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvSenateGaugeSubItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeSubItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeSubItemsEN.senateGaugeVersionID = objRow[convSenateGaugeSubItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convSenateGaugeSubItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll].ToString().Trim(); //子项等地分数
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2].ToString().Trim(); //senateGaugeSubItemAll2
objvSenateGaugeSubItemsEN.VersionNo = objRow[convSenateGaugeSubItems.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeSubItemsEN.IsUse = TransNullToBool(objRow[convSenateGaugeSubItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeSubItemsEN.UpdDate = objRow[convSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeSubItemsEN.UpdUserId = objRow[convSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeSubItemsEN.AnswerModeId = objRow[convSenateGaugeSubItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeSubItemsEN.AnswerModeName = objRow[convSenateGaugeSubItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeSubItemsEN.AnswerNum = objRow[convSenateGaugeSubItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeSubItemsEN.AnswerTypeId = objRow[convSenateGaugeSubItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeSubItemsEN.AnswerTypeName = objRow[convSenateGaugeSubItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeSubItemsEN.GridTitle = objRow[convSenateGaugeSubItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convSenateGaugeSubItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvSenateGaugeSubItemsEN.QuestionIndex = objRow[convSenateGaugeSubItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeSubItemsEN.QuestionNo = objRow[convSenateGaugeSubItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeSubItemsEN.QuestionTypeId = objRow[convSenateGaugeSubItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeSubItemsEN.QuestionTypeName = objRow[convSenateGaugeSubItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeSubItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSenateGaugeSubItemsDA: GetObjLst)", objException.Message));
}
objvSenateGaugeSubItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSenateGaugeSubItemsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvSenateGaugeSubItems(ref clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeSubItems where IdSenateGaugeSubItem = " + "'"+ objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objDT.Rows[0][convSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号(字段类型:char,字段长度:4,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeSubItemID = objDT.Rows[0][convSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID(字段类型:char,字段长度:4,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeSubItemName = objDT.Rows[0][convSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvSenateGaugeSubItemsEN.IdSenateGaugeItem = objDT.Rows[0][convSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeSubItemsEN.senateGaugeItemName = objDT.Rows[0][convSenateGaugeSubItems.senateGaugeItemName].ToString().Trim(); //量表指标名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeVersionName = objDT.Rows[0][convSenateGaugeSubItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = TransNullToFloat(objDT.Rows[0][convSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数(字段类型:float,字段长度:8,是否可空:True)
 objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = objDT.Rows[0][convSenateGaugeSubItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeSubItemsEN.senateGaugeItemID = objDT.Rows[0][convSenateGaugeSubItems.senateGaugeItemID].ToString().Trim(); //量表指标ID(字段类型:char,字段长度:4,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objDT.Rows[0][convSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvSenateGaugeSubItemsEN.AnswerTitle = objDT.Rows[0][convSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeSubItemsEN.AnswerIndex = TransNullToInt(objDT.Rows[0][convSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeItemDesc = objDT.Rows[0][convSenateGaugeSubItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeItemWeight = TransNullToFloat(objDT.Rows[0][convSenateGaugeSubItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重(字段类型:float,字段长度:8,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objDT.Rows[0][convSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeItemMemo = objDT.Rows[0][convSenateGaugeSubItems.senateGaugeItemMemo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeVersionID = objDT.Rows[0][convSenateGaugeSubItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convSenateGaugeSubItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = objDT.Rows[0][convSenateGaugeSubItems.senateGaugeSubItemAll].ToString().Trim(); //子项等地分数(字段类型:varchar,字段长度:230,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = objDT.Rows[0][convSenateGaugeSubItems.senateGaugeSubItemAll2].ToString().Trim(); //senateGaugeSubItemAll2(字段类型:varchar,字段长度:2235,是否可空:True)
 objvSenateGaugeSubItemsEN.VersionNo = TransNullToInt(objDT.Rows[0][convSenateGaugeSubItems.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeSubItemsEN.IsUse = TransNullToBool(objDT.Rows[0][convSenateGaugeSubItems.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvSenateGaugeSubItemsEN.UpdDate = objDT.Rows[0][convSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeSubItemsEN.UpdUserId = objDT.Rows[0][convSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeSubItemsEN.AnswerModeId = objDT.Rows[0][convSenateGaugeSubItems.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvSenateGaugeSubItemsEN.AnswerModeName = objDT.Rows[0][convSenateGaugeSubItems.AnswerModeName].ToString().Trim(); //答案模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvSenateGaugeSubItemsEN.AnswerNum = TransNullToInt(objDT.Rows[0][convSenateGaugeSubItems.AnswerNum].ToString().Trim()); //答案数(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeSubItemsEN.AnswerTypeId = objDT.Rows[0][convSenateGaugeSubItems.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvSenateGaugeSubItemsEN.AnswerTypeName = objDT.Rows[0][convSenateGaugeSubItems.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvSenateGaugeSubItemsEN.GridTitle = objDT.Rows[0][convSenateGaugeSubItems.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = TransNullToBool(objDT.Rows[0][convSenateGaugeSubItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明(字段类型:bit,字段长度:1,是否可空:True)
 objvSenateGaugeSubItemsEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convSenateGaugeSubItems.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeSubItemsEN.QuestionNo = objDT.Rows[0][convSenateGaugeSubItems.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvSenateGaugeSubItemsEN.QuestionTypeId = objDT.Rows[0][convSenateGaugeSubItems.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvSenateGaugeSubItemsEN.QuestionTypeName = objDT.Rows[0][convSenateGaugeSubItems.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = objDT.Rows[0][convSenateGaugeSubItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder(字段类型:varchar,字段长度:204,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = objDT.Rows[0][convSenateGaugeSubItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvSenateGaugeSubItemsDA: GetvSenateGaugeSubItems)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdSenateGaugeSubItem">表关键字</param>
 /// <returns>表对象</returns>
public clsvSenateGaugeSubItemsEN GetObjByIdSenateGaugeSubItem(string strIdSenateGaugeSubItem)
{
CheckPrimaryKey(strIdSenateGaugeSubItem);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeSubItems where IdSenateGaugeSubItem = " + "'"+ strIdSenateGaugeSubItem+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = new clsvSenateGaugeSubItemsEN();
try
{
 objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[convSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号(字段类型:char,字段长度:4,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[convSenateGaugeSubItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID(字段类型:char,字段长度:4,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[convSenateGaugeSubItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeSubItemsEN.senateGaugeItemName = objRow[convSenateGaugeSubItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemName].ToString().Trim(); //量表指标名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeVersionName = objRow[convSenateGaugeSubItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = objRow[convSenateGaugeSubItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数(字段类型:float,字段长度:8,是否可空:True)
 objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeSubItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeSubItemsEN.senateGaugeItemID = objRow[convSenateGaugeSubItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemID].ToString().Trim(); //量表指标ID(字段类型:char,字段长度:4,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvSenateGaugeSubItemsEN.AnswerTitle = objRow[convSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeSubItemsEN.AnswerIndex = objRow[convSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeSubItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeSubItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重(字段类型:float,字段长度:8,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeSubItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemMemo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeVersionID = objRow[convSenateGaugeSubItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeSubItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll].ToString().Trim(); //子项等地分数(字段类型:varchar,字段长度:230,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2].ToString().Trim(); //senateGaugeSubItemAll2(字段类型:varchar,字段长度:2235,是否可空:True)
 objvSenateGaugeSubItemsEN.VersionNo = objRow[convSenateGaugeSubItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeSubItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvSenateGaugeSubItemsEN.UpdDate = objRow[convSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeSubItemsEN.UpdUserId = objRow[convSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeSubItemsEN.AnswerModeId = objRow[convSenateGaugeSubItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvSenateGaugeSubItemsEN.AnswerModeName = objRow[convSenateGaugeSubItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeName].ToString().Trim(); //答案模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvSenateGaugeSubItemsEN.AnswerNum = objRow[convSenateGaugeSubItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerNum].ToString().Trim()); //答案数(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeSubItemsEN.AnswerTypeId = objRow[convSenateGaugeSubItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvSenateGaugeSubItemsEN.AnswerTypeName = objRow[convSenateGaugeSubItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvSenateGaugeSubItemsEN.GridTitle = objRow[convSenateGaugeSubItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明(字段类型:bit,字段长度:1,是否可空:True)
 objvSenateGaugeSubItemsEN.QuestionIndex = objRow[convSenateGaugeSubItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeSubItemsEN.QuestionNo = objRow[convSenateGaugeSubItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvSenateGaugeSubItemsEN.QuestionTypeId = objRow[convSenateGaugeSubItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvSenateGaugeSubItemsEN.QuestionTypeName = objRow[convSenateGaugeSubItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder(字段类型:varchar,字段长度:204,是否可空:True)
 objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeSubItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvSenateGaugeSubItemsDA: GetObjByIdSenateGaugeSubItem)", objException.Message));
}
return objvSenateGaugeSubItemsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvSenateGaugeSubItemsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvSenateGaugeSubItemsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeSubItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = new clsvSenateGaugeSubItemsEN()
{
IdSenateGaugeSubItem = objRow[convSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(), //量表指标子项流水号
senateGaugeSubItemID = objRow[convSenateGaugeSubItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(), //量表指标子项ID
senateGaugeSubItemName = objRow[convSenateGaugeSubItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(), //量表指标子项名称
IdSenateGaugeItem = objRow[convSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(), //量表指标流水号
senateGaugeItemName = objRow[convSenateGaugeSubItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemName].ToString().Trim(), //量表指标名称
senateGaugeVersionName = objRow[convSenateGaugeSubItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeSubItemScore = objRow[convSenateGaugeSubItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()), //量表指标子项分数
IdSenateGaugeVersion = objRow[convSenateGaugeSubItems.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeItemID = objRow[convSenateGaugeSubItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemID].ToString().Trim(), //量表指标ID
senateGaugeSubItemDesc = objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(), //量表指标子项说明
AnswerTitle = objRow[convSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTitle].ToString().Trim(), //答案标题
AnswerIndex = objRow[convSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.AnswerIndex].ToString().Trim()), //问答序号
senateGaugeItemDesc = objRow[convSenateGaugeSubItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemDesc].ToString().Trim(), //量表指标说明
senateGaugeItemWeight = objRow[convSenateGaugeSubItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeSubItems.senateGaugeItemWeight].ToString().Trim()), //量表指标权重
senateGaugeSubItemMemo = objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(), //量表指标子项备注
senateGaugeItemMemo = objRow[convSenateGaugeSubItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemMemo].ToString().Trim(), //备注
senateGaugeVersionID = objRow[convSenateGaugeSubItems.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionTtlScore = TransNullToFloat(objRow[convSenateGaugeSubItems.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
senateGaugeSubItemAll = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll].ToString().Trim(), //子项等地分数
senateGaugeSubItemAll2 = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2].ToString().Trim(), //senateGaugeSubItemAll2
VersionNo = objRow[convSenateGaugeSubItems.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.VersionNo].ToString().Trim()), //版本号
IsUse = TransNullToBool(objRow[convSenateGaugeSubItems.IsUse].ToString().Trim()), //是否使用
UpdDate = objRow[convSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdUserId].ToString().Trim(), //修改用户Id
AnswerModeId = objRow[convSenateGaugeSubItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeId].ToString().Trim(), //答案模式Id
AnswerModeName = objRow[convSenateGaugeSubItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeName].ToString().Trim(), //答案模式名称
AnswerNum = objRow[convSenateGaugeSubItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.AnswerNum].ToString().Trim()), //答案数
AnswerTypeId = objRow[convSenateGaugeSubItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeId].ToString().Trim(), //答案类型ID
AnswerTypeName = objRow[convSenateGaugeSubItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeName].ToString().Trim(), //答案类型名
GridTitle = objRow[convSenateGaugeSubItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.GridTitle].ToString().Trim(), //表格标题
IsHaveAdditionalMemo = TransNullToBool(objRow[convSenateGaugeSubItems.IsHaveAdditionalMemo].ToString().Trim()), //是否有附加说明
QuestionIndex = objRow[convSenateGaugeSubItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.QuestionIndex].ToString().Trim()), //题目序号
QuestionNo = objRow[convSenateGaugeSubItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionNo].ToString().Trim(), //题目编号
QuestionTypeId = objRow[convSenateGaugeSubItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionTypeName = objRow[convSenateGaugeSubItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeName].ToString().Trim(), //题目类型名
senateGaugeItemNameWithOrder = objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder].ToString().Trim(), //量表指标名称WithOrder
senateGaugeVersionMemo = objRow[convSenateGaugeSubItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionMemo].ToString().Trim() //评价量表版本说明
};
objvSenateGaugeSubItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSenateGaugeSubItemsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvSenateGaugeSubItemsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvSenateGaugeSubItemsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = new clsvSenateGaugeSubItemsEN();
try
{
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[convSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[convSenateGaugeSubItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[convSenateGaugeSubItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeSubItemsEN.senateGaugeItemName = objRow[convSenateGaugeSubItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeSubItemsEN.senateGaugeVersionName = objRow[convSenateGaugeSubItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = objRow[convSenateGaugeSubItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeSubItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeSubItemsEN.senateGaugeItemID = objRow[convSenateGaugeSubItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvSenateGaugeSubItemsEN.AnswerTitle = objRow[convSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objvSenateGaugeSubItemsEN.AnswerIndex = objRow[convSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objvSenateGaugeSubItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeSubItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeSubItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeSubItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeSubItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvSenateGaugeSubItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeSubItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeSubItemsEN.senateGaugeVersionID = objRow[convSenateGaugeSubItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convSenateGaugeSubItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll].ToString().Trim(); //子项等地分数
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2].ToString().Trim(); //senateGaugeSubItemAll2
objvSenateGaugeSubItemsEN.VersionNo = objRow[convSenateGaugeSubItems.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeSubItemsEN.IsUse = TransNullToBool(objRow[convSenateGaugeSubItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeSubItemsEN.UpdDate = objRow[convSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeSubItemsEN.UpdUserId = objRow[convSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeSubItemsEN.AnswerModeId = objRow[convSenateGaugeSubItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeSubItemsEN.AnswerModeName = objRow[convSenateGaugeSubItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeSubItemsEN.AnswerNum = objRow[convSenateGaugeSubItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeSubItemsEN.AnswerTypeId = objRow[convSenateGaugeSubItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeSubItemsEN.AnswerTypeName = objRow[convSenateGaugeSubItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeSubItemsEN.GridTitle = objRow[convSenateGaugeSubItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convSenateGaugeSubItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvSenateGaugeSubItemsEN.QuestionIndex = objRow[convSenateGaugeSubItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeSubItemsEN.QuestionNo = objRow[convSenateGaugeSubItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeSubItemsEN.QuestionTypeId = objRow[convSenateGaugeSubItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeSubItemsEN.QuestionTypeName = objRow[convSenateGaugeSubItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeSubItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvSenateGaugeSubItemsDA: GetObjByDataRowvSenateGaugeSubItems)", objException.Message));
}
objvSenateGaugeSubItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSenateGaugeSubItemsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvSenateGaugeSubItemsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = new clsvSenateGaugeSubItemsEN();
try
{
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[convSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[convSenateGaugeSubItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[convSenateGaugeSubItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeSubItemsEN.senateGaugeItemName = objRow[convSenateGaugeSubItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeSubItemsEN.senateGaugeVersionName = objRow[convSenateGaugeSubItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = objRow[convSenateGaugeSubItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeSubItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeSubItemsEN.senateGaugeItemID = objRow[convSenateGaugeSubItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvSenateGaugeSubItemsEN.AnswerTitle = objRow[convSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objvSenateGaugeSubItemsEN.AnswerIndex = objRow[convSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objvSenateGaugeSubItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeSubItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeSubItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeSubItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeSubItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvSenateGaugeSubItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeSubItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeSubItemsEN.senateGaugeVersionID = objRow[convSenateGaugeSubItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convSenateGaugeSubItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll].ToString().Trim(); //子项等地分数
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2].ToString().Trim(); //senateGaugeSubItemAll2
objvSenateGaugeSubItemsEN.VersionNo = objRow[convSenateGaugeSubItems.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeSubItemsEN.IsUse = TransNullToBool(objRow[convSenateGaugeSubItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeSubItemsEN.UpdDate = objRow[convSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeSubItemsEN.UpdUserId = objRow[convSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeSubItemsEN.AnswerModeId = objRow[convSenateGaugeSubItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeSubItemsEN.AnswerModeName = objRow[convSenateGaugeSubItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeSubItemsEN.AnswerNum = objRow[convSenateGaugeSubItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeSubItemsEN.AnswerTypeId = objRow[convSenateGaugeSubItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeSubItemsEN.AnswerTypeName = objRow[convSenateGaugeSubItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeSubItemsEN.GridTitle = objRow[convSenateGaugeSubItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convSenateGaugeSubItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvSenateGaugeSubItemsEN.QuestionIndex = objRow[convSenateGaugeSubItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeSubItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeSubItemsEN.QuestionNo = objRow[convSenateGaugeSubItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeSubItemsEN.QuestionTypeId = objRow[convSenateGaugeSubItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeSubItemsEN.QuestionTypeName = objRow[convSenateGaugeSubItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeSubItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvSenateGaugeSubItemsDA: GetObjByDataRow)", objException.Message));
}
objvSenateGaugeSubItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSenateGaugeSubItemsEN;
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
objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSenateGaugeSubItemsEN._CurrTabName, convSenateGaugeSubItems.IdSenateGaugeSubItem, 4, "");
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
objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSenateGaugeSubItemsEN._CurrTabName, convSenateGaugeSubItems.IdSenateGaugeSubItem, 4, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdSenateGaugeSubItem from vSenateGaugeSubItems where " + strCondition;
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
return "";
}
strKeyValue = objDT.Rows[0][0].ToString();
return strKeyValue;
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
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdSenateGaugeSubItem from vSenateGaugeSubItems where " + strCondition;
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
 /// <param name = "strIdSenateGaugeSubItem">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdSenateGaugeSubItem)
{
CheckPrimaryKey(strIdSenateGaugeSubItem);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSenateGaugeSubItems", "IdSenateGaugeSubItem = " + "'"+ strIdSenateGaugeSubItem+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvSenateGaugeSubItemsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSenateGaugeSubItems", strCondition))
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
objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vSenateGaugeSubItems");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsENS">源对象</param>
 /// <param name = "objvSenateGaugeSubItemsENT">目标对象</param>
public void CopyTo(clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsENS, clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsENT)
{
objvSenateGaugeSubItemsENT.IdSenateGaugeSubItem = objvSenateGaugeSubItemsENS.IdSenateGaugeSubItem; //量表指标子项流水号
objvSenateGaugeSubItemsENT.senateGaugeSubItemID = objvSenateGaugeSubItemsENS.senateGaugeSubItemID; //量表指标子项ID
objvSenateGaugeSubItemsENT.senateGaugeSubItemName = objvSenateGaugeSubItemsENS.senateGaugeSubItemName; //量表指标子项名称
objvSenateGaugeSubItemsENT.IdSenateGaugeItem = objvSenateGaugeSubItemsENS.IdSenateGaugeItem; //量表指标流水号
objvSenateGaugeSubItemsENT.senateGaugeItemName = objvSenateGaugeSubItemsENS.senateGaugeItemName; //量表指标名称
objvSenateGaugeSubItemsENT.senateGaugeVersionName = objvSenateGaugeSubItemsENS.senateGaugeVersionName; //评价量表版本名称
objvSenateGaugeSubItemsENT.senateGaugeSubItemScore = objvSenateGaugeSubItemsENS.senateGaugeSubItemScore; //量表指标子项分数
objvSenateGaugeSubItemsENT.IdSenateGaugeVersion = objvSenateGaugeSubItemsENS.IdSenateGaugeVersion; //评价量表版本流水号
objvSenateGaugeSubItemsENT.senateGaugeItemID = objvSenateGaugeSubItemsENS.senateGaugeItemID; //量表指标ID
objvSenateGaugeSubItemsENT.senateGaugeSubItemDesc = objvSenateGaugeSubItemsENS.senateGaugeSubItemDesc; //量表指标子项说明
objvSenateGaugeSubItemsENT.AnswerTitle = objvSenateGaugeSubItemsENS.AnswerTitle; //答案标题
objvSenateGaugeSubItemsENT.AnswerIndex = objvSenateGaugeSubItemsENS.AnswerIndex; //问答序号
objvSenateGaugeSubItemsENT.senateGaugeItemDesc = objvSenateGaugeSubItemsENS.senateGaugeItemDesc; //量表指标说明
objvSenateGaugeSubItemsENT.senateGaugeItemWeight = objvSenateGaugeSubItemsENS.senateGaugeItemWeight; //量表指标权重
objvSenateGaugeSubItemsENT.senateGaugeSubItemMemo = objvSenateGaugeSubItemsENS.senateGaugeSubItemMemo; //量表指标子项备注
objvSenateGaugeSubItemsENT.senateGaugeItemMemo = objvSenateGaugeSubItemsENS.senateGaugeItemMemo; //备注
objvSenateGaugeSubItemsENT.senateGaugeVersionID = objvSenateGaugeSubItemsENS.senateGaugeVersionID; //评价量表版本ID
objvSenateGaugeSubItemsENT.senateGaugeVersionTtlScore = objvSenateGaugeSubItemsENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvSenateGaugeSubItemsENT.senateGaugeSubItemAll = objvSenateGaugeSubItemsENS.senateGaugeSubItemAll; //子项等地分数
objvSenateGaugeSubItemsENT.senateGaugeSubItemAll2 = objvSenateGaugeSubItemsENS.senateGaugeSubItemAll2; //senateGaugeSubItemAll2
objvSenateGaugeSubItemsENT.VersionNo = objvSenateGaugeSubItemsENS.VersionNo; //版本号
objvSenateGaugeSubItemsENT.IsUse = objvSenateGaugeSubItemsENS.IsUse; //是否使用
objvSenateGaugeSubItemsENT.UpdDate = objvSenateGaugeSubItemsENS.UpdDate; //修改日期
objvSenateGaugeSubItemsENT.UpdUserId = objvSenateGaugeSubItemsENS.UpdUserId; //修改用户Id
objvSenateGaugeSubItemsENT.AnswerModeId = objvSenateGaugeSubItemsENS.AnswerModeId; //答案模式Id
objvSenateGaugeSubItemsENT.AnswerModeName = objvSenateGaugeSubItemsENS.AnswerModeName; //答案模式名称
objvSenateGaugeSubItemsENT.AnswerNum = objvSenateGaugeSubItemsENS.AnswerNum; //答案数
objvSenateGaugeSubItemsENT.AnswerTypeId = objvSenateGaugeSubItemsENS.AnswerTypeId; //答案类型ID
objvSenateGaugeSubItemsENT.AnswerTypeName = objvSenateGaugeSubItemsENS.AnswerTypeName; //答案类型名
objvSenateGaugeSubItemsENT.GridTitle = objvSenateGaugeSubItemsENS.GridTitle; //表格标题
objvSenateGaugeSubItemsENT.IsHaveAdditionalMemo = objvSenateGaugeSubItemsENS.IsHaveAdditionalMemo; //是否有附加说明
objvSenateGaugeSubItemsENT.QuestionIndex = objvSenateGaugeSubItemsENS.QuestionIndex; //题目序号
objvSenateGaugeSubItemsENT.QuestionNo = objvSenateGaugeSubItemsENS.QuestionNo; //题目编号
objvSenateGaugeSubItemsENT.QuestionTypeId = objvSenateGaugeSubItemsENS.QuestionTypeId; //题目类型Id
objvSenateGaugeSubItemsENT.QuestionTypeName = objvSenateGaugeSubItemsENS.QuestionTypeName; //题目类型名
objvSenateGaugeSubItemsENT.senateGaugeItemNameWithOrder = objvSenateGaugeSubItemsENS.senateGaugeItemNameWithOrder; //量表指标名称WithOrder
objvSenateGaugeSubItemsENT.senateGaugeVersionMemo = objvSenateGaugeSubItemsENS.senateGaugeVersionMemo; //评价量表版本说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem, 4, convSenateGaugeSubItems.IdSenateGaugeSubItem);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.senateGaugeSubItemID, 4, convSenateGaugeSubItems.senateGaugeSubItemID);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.senateGaugeSubItemName, 200, convSenateGaugeSubItems.senateGaugeSubItemName);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.IdSenateGaugeItem, 4, convSenateGaugeSubItems.IdSenateGaugeItem);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.senateGaugeItemName, 200, convSenateGaugeSubItems.senateGaugeItemName);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.senateGaugeVersionName, 200, convSenateGaugeSubItems.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.IdSenateGaugeVersion, 4, convSenateGaugeSubItems.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.senateGaugeItemID, 4, convSenateGaugeSubItems.senateGaugeItemID);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc, 2000, convSenateGaugeSubItems.senateGaugeSubItemDesc);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.AnswerTitle, 20, convSenateGaugeSubItems.AnswerTitle);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.senateGaugeItemDesc, 2000, convSenateGaugeSubItems.senateGaugeItemDesc);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo, 1000, convSenateGaugeSubItems.senateGaugeSubItemMemo);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.senateGaugeItemMemo, 1000, convSenateGaugeSubItems.senateGaugeItemMemo);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.senateGaugeVersionID, 4, convSenateGaugeSubItems.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.senateGaugeSubItemAll, 230, convSenateGaugeSubItems.senateGaugeSubItemAll);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2, 2235, convSenateGaugeSubItems.senateGaugeSubItemAll2);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.UpdDate, 20, convSenateGaugeSubItems.UpdDate);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.UpdUserId, 20, convSenateGaugeSubItems.UpdUserId);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.AnswerModeId, 4, convSenateGaugeSubItems.AnswerModeId);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.AnswerModeName, 30, convSenateGaugeSubItems.AnswerModeName);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.AnswerTypeId, 2, convSenateGaugeSubItems.AnswerTypeId);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.AnswerTypeName, 50, convSenateGaugeSubItems.AnswerTypeName);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.GridTitle, 30, convSenateGaugeSubItems.GridTitle);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.QuestionNo, 10, convSenateGaugeSubItems.QuestionNo);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.QuestionTypeId, 2, convSenateGaugeSubItems.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.QuestionTypeName, 20, convSenateGaugeSubItems.QuestionTypeName);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder, 204, convSenateGaugeSubItems.senateGaugeItemNameWithOrder);
clsCheckSql.CheckFieldLen(objvSenateGaugeSubItemsEN.senateGaugeVersionMemo, 1000, convSenateGaugeSubItems.senateGaugeVersionMemo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem, convSenateGaugeSubItems.IdSenateGaugeSubItem);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.senateGaugeSubItemID, convSenateGaugeSubItems.senateGaugeSubItemID);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.senateGaugeSubItemName, convSenateGaugeSubItems.senateGaugeSubItemName);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.IdSenateGaugeItem, convSenateGaugeSubItems.IdSenateGaugeItem);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.senateGaugeItemName, convSenateGaugeSubItems.senateGaugeItemName);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.senateGaugeVersionName, convSenateGaugeSubItems.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.IdSenateGaugeVersion, convSenateGaugeSubItems.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.senateGaugeItemID, convSenateGaugeSubItems.senateGaugeItemID);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc, convSenateGaugeSubItems.senateGaugeSubItemDesc);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.AnswerTitle, convSenateGaugeSubItems.AnswerTitle);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.senateGaugeItemDesc, convSenateGaugeSubItems.senateGaugeItemDesc);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo, convSenateGaugeSubItems.senateGaugeSubItemMemo);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.senateGaugeItemMemo, convSenateGaugeSubItems.senateGaugeItemMemo);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.senateGaugeVersionID, convSenateGaugeSubItems.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.senateGaugeSubItemAll, convSenateGaugeSubItems.senateGaugeSubItemAll);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2, convSenateGaugeSubItems.senateGaugeSubItemAll2);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.UpdDate, convSenateGaugeSubItems.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.UpdUserId, convSenateGaugeSubItems.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.AnswerModeId, convSenateGaugeSubItems.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.AnswerModeName, convSenateGaugeSubItems.AnswerModeName);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.AnswerTypeId, convSenateGaugeSubItems.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.AnswerTypeName, convSenateGaugeSubItems.AnswerTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.GridTitle, convSenateGaugeSubItems.GridTitle);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.QuestionNo, convSenateGaugeSubItems.QuestionNo);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.QuestionTypeId, convSenateGaugeSubItems.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.QuestionTypeName, convSenateGaugeSubItems.QuestionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder, convSenateGaugeSubItems.senateGaugeItemNameWithOrder);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeSubItemsEN.senateGaugeVersionMemo, convSenateGaugeSubItems.senateGaugeVersionMemo);
//检查外键字段长度
 objvSenateGaugeSubItemsEN._IsCheckProperty = true;
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
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
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
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
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
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSenateGaugeSubItemsEN._CurrTabName);
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
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSenateGaugeSubItemsEN._CurrTabName, strCondition);
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
 objSQL = clsvSenateGaugeSubItemsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}