
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSenateGaugeItemsDA
 表名:vSenateGaugeItems(01120477)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:26
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
 /// v量表指标(vSenateGaugeItems)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvSenateGaugeItemsDA : clsCommBase4DA
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
 return clsvSenateGaugeItemsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvSenateGaugeItemsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSenateGaugeItemsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvSenateGaugeItemsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvSenateGaugeItemsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdSenateGaugeItem">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdSenateGaugeItem)
{
strIdSenateGaugeItem = strIdSenateGaugeItem.Replace("'", "''");
if (strIdSenateGaugeItem.Length > 4)
{
throw new Exception("(errid:Data000001)在表:vSenateGaugeItems中,检查关键字,长度不正确!(clsvSenateGaugeItemsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdSenateGaugeItem)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vSenateGaugeItems中,关键字不能为空 或 null!(clsvSenateGaugeItemsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSenateGaugeItem);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvSenateGaugeItemsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvSenateGaugeItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vSenateGaugeItems(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvSenateGaugeItemsDA: GetDataTable_vSenateGaugeItems)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeItems where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvSenateGaugeItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvSenateGaugeItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeItems where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvSenateGaugeItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvSenateGaugeItemsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeItems where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeItems where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvSenateGaugeItemsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vSenateGaugeItems where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvSenateGaugeItemsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vSenateGaugeItems.* from vSenateGaugeItems Left Join {1} on {2} where {3} and vSenateGaugeItems.IdSenateGaugeItem not in (Select top {5} vSenateGaugeItems.IdSenateGaugeItem from vSenateGaugeItems Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeItems where {1} and IdSenateGaugeItem not in (Select top {2} IdSenateGaugeItem from vSenateGaugeItems where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeItems where {1} and IdSenateGaugeItem not in (Select top {3} IdSenateGaugeItem from vSenateGaugeItems where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvSenateGaugeItemsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vSenateGaugeItems.* from vSenateGaugeItems Left Join {1} on {2} where {3} and vSenateGaugeItems.IdSenateGaugeItem not in (Select top {5} vSenateGaugeItems.IdSenateGaugeItem from vSenateGaugeItems Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeItems where {1} and IdSenateGaugeItem not in (Select top {2} IdSenateGaugeItem from vSenateGaugeItems where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeItems where {1} and IdSenateGaugeItem not in (Select top {3} IdSenateGaugeItem from vSenateGaugeItems where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvSenateGaugeItemsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvSenateGaugeItemsDA:GetObjLst)", objException.Message));
}
List<clsvSenateGaugeItemsEN> arrObjLst = new List<clsvSenateGaugeItemsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = new clsvSenateGaugeItemsEN();
try
{
objvSenateGaugeItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeItemsEN.senateGaugeItemID = objRow[convSenateGaugeItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeItemsEN.senateGaugeItemName = objRow[convSenateGaugeItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeItemsEN.senateGaugeVersionName = objRow[convSenateGaugeItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeItemsEN.AnswerModeId = objRow[convSenateGaugeItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeItemsEN.AnswerTypeId = objRow[convSenateGaugeItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeItemsEN.GridTitle = objRow[convSenateGaugeItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeItemsEN.QuestionIndex = objRow[convSenateGaugeItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeItemsEN.senateGaugeVersionID = objRow[convSenateGaugeItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeItemsEN.QuestionNo = objRow[convSenateGaugeItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeItemsEN.QuestionTypeId = objRow[convSenateGaugeItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convSenateGaugeItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeItemsEN.AnswerTypeName = objRow[convSenateGaugeItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeItemsEN.AnswerModeName = objRow[convSenateGaugeItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeItemsEN.QuestionTypeName = objRow[convSenateGaugeItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeItemsEN.AnswerNum = objRow[convSenateGaugeItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeItemsEN.VersionNo = objRow[convSenateGaugeItems.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeItemsEN.IsUse = TransNullToBool(objRow[convSenateGaugeItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeItemsEN.UpdDate = objRow[convSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeItemsEN.UpdUserId = objRow[convSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeItemsEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSenateGaugeItemsDA: GetObjLst)", objException.Message));
}
objvSenateGaugeItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSenateGaugeItemsEN);
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
public List<clsvSenateGaugeItemsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvSenateGaugeItemsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvSenateGaugeItemsEN> arrObjLst = new List<clsvSenateGaugeItemsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = new clsvSenateGaugeItemsEN();
try
{
objvSenateGaugeItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeItemsEN.senateGaugeItemID = objRow[convSenateGaugeItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeItemsEN.senateGaugeItemName = objRow[convSenateGaugeItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeItemsEN.senateGaugeVersionName = objRow[convSenateGaugeItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeItemsEN.AnswerModeId = objRow[convSenateGaugeItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeItemsEN.AnswerTypeId = objRow[convSenateGaugeItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeItemsEN.GridTitle = objRow[convSenateGaugeItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeItemsEN.QuestionIndex = objRow[convSenateGaugeItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeItemsEN.senateGaugeVersionID = objRow[convSenateGaugeItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeItemsEN.QuestionNo = objRow[convSenateGaugeItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeItemsEN.QuestionTypeId = objRow[convSenateGaugeItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convSenateGaugeItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeItemsEN.AnswerTypeName = objRow[convSenateGaugeItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeItemsEN.AnswerModeName = objRow[convSenateGaugeItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeItemsEN.QuestionTypeName = objRow[convSenateGaugeItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeItemsEN.AnswerNum = objRow[convSenateGaugeItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeItemsEN.VersionNo = objRow[convSenateGaugeItems.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeItemsEN.IsUse = TransNullToBool(objRow[convSenateGaugeItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeItemsEN.UpdDate = objRow[convSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeItemsEN.UpdUserId = objRow[convSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeItemsEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSenateGaugeItemsDA: GetObjLst)", objException.Message));
}
objvSenateGaugeItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSenateGaugeItemsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvSenateGaugeItems(ref clsvSenateGaugeItemsEN objvSenateGaugeItemsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeItems where IdSenateGaugeItem = " + "'"+ objvSenateGaugeItemsEN.IdSenateGaugeItem+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvSenateGaugeItemsEN.IdSenateGaugeItem = objDT.Rows[0][convSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeItemsEN.senateGaugeItemID = objDT.Rows[0][convSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID(字段类型:char,字段长度:4,是否可空:True)
 objvSenateGaugeItemsEN.senateGaugeItemName = objDT.Rows[0][convSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvSenateGaugeItemsEN.IdSenateGaugeVersion = objDT.Rows[0][convSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeItemsEN.senateGaugeVersionName = objDT.Rows[0][convSenateGaugeItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvSenateGaugeItemsEN.senateGaugeItemDesc = objDT.Rows[0][convSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvSenateGaugeItemsEN.senateGaugeItemWeight = TransNullToFloat(objDT.Rows[0][convSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重(字段类型:float,字段长度:8,是否可空:True)
 objvSenateGaugeItemsEN.AnswerModeId = objDT.Rows[0][convSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvSenateGaugeItemsEN.AnswerTypeId = objDT.Rows[0][convSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvSenateGaugeItemsEN.GridTitle = objDT.Rows[0][convSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvSenateGaugeItemsEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeItemsEN.senateGaugeVersionID = objDT.Rows[0][convSenateGaugeItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeItemsEN.QuestionNo = objDT.Rows[0][convSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvSenateGaugeItemsEN.QuestionTypeId = objDT.Rows[0][convSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convSenateGaugeItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvSenateGaugeItemsEN.AnswerTypeName = objDT.Rows[0][convSenateGaugeItems.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvSenateGaugeItemsEN.AnswerModeName = objDT.Rows[0][convSenateGaugeItems.AnswerModeName].ToString().Trim(); //答案模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvSenateGaugeItemsEN.senateGaugeItemMemo = objDT.Rows[0][convSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSenateGaugeItemsEN.QuestionTypeName = objDT.Rows[0][convSenateGaugeItems.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeItemsEN.AnswerNum = TransNullToInt(objDT.Rows[0][convSenateGaugeItems.AnswerNum].ToString().Trim()); //答案数(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeItemsEN.VersionNo = TransNullToInt(objDT.Rows[0][convSenateGaugeItems.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeItemsEN.IsUse = TransNullToBool(objDT.Rows[0][convSenateGaugeItems.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvSenateGaugeItemsEN.senateGaugeVersionMemo = objDT.Rows[0][convSenateGaugeItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = objDT.Rows[0][convSenateGaugeItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder(字段类型:varchar,字段长度:204,是否可空:True)
 objvSenateGaugeItemsEN.UpdDate = objDT.Rows[0][convSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeItemsEN.UpdUserId = objDT.Rows[0][convSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeItemsEN.IsHaveAdditionalMemo = TransNullToBool(objDT.Rows[0][convSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvSenateGaugeItemsDA: GetvSenateGaugeItems)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdSenateGaugeItem">表关键字</param>
 /// <returns>表对象</returns>
public clsvSenateGaugeItemsEN GetObjByIdSenateGaugeItem(string strIdSenateGaugeItem)
{
CheckPrimaryKey(strIdSenateGaugeItem);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeItems where IdSenateGaugeItem = " + "'"+ strIdSenateGaugeItem+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = new clsvSenateGaugeItemsEN();
try
{
 objvSenateGaugeItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeItemsEN.senateGaugeItemID = objRow[convSenateGaugeItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID(字段类型:char,字段长度:4,是否可空:True)
 objvSenateGaugeItemsEN.senateGaugeItemName = objRow[convSenateGaugeItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeItemsEN.senateGaugeVersionName = objRow[convSenateGaugeItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvSenateGaugeItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvSenateGaugeItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重(字段类型:float,字段长度:8,是否可空:True)
 objvSenateGaugeItemsEN.AnswerModeId = objRow[convSenateGaugeItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvSenateGaugeItemsEN.AnswerTypeId = objRow[convSenateGaugeItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvSenateGaugeItemsEN.GridTitle = objRow[convSenateGaugeItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvSenateGaugeItemsEN.QuestionIndex = objRow[convSenateGaugeItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeItemsEN.senateGaugeVersionID = objRow[convSenateGaugeItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeItemsEN.QuestionNo = objRow[convSenateGaugeItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvSenateGaugeItemsEN.QuestionTypeId = objRow[convSenateGaugeItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvSenateGaugeItemsEN.AnswerTypeName = objRow[convSenateGaugeItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvSenateGaugeItemsEN.AnswerModeName = objRow[convSenateGaugeItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeName].ToString().Trim(); //答案模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvSenateGaugeItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSenateGaugeItemsEN.QuestionTypeName = objRow[convSenateGaugeItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeItemsEN.AnswerNum = objRow[convSenateGaugeItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.AnswerNum].ToString().Trim()); //答案数(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeItemsEN.VersionNo = objRow[convSenateGaugeItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvSenateGaugeItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder(字段类型:varchar,字段长度:204,是否可空:True)
 objvSenateGaugeItemsEN.UpdDate = objRow[convSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeItemsEN.UpdUserId = objRow[convSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvSenateGaugeItemsDA: GetObjByIdSenateGaugeItem)", objException.Message));
}
return objvSenateGaugeItemsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvSenateGaugeItemsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvSenateGaugeItemsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = new clsvSenateGaugeItemsEN()
{
IdSenateGaugeItem = objRow[convSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(), //量表指标流水号
senateGaugeItemID = objRow[convSenateGaugeItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemID].ToString().Trim(), //量表指标ID
senateGaugeItemName = objRow[convSenateGaugeItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemName].ToString().Trim(), //量表指标名称
IdSenateGaugeVersion = objRow[convSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionName = objRow[convSenateGaugeItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeItemDesc = objRow[convSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(), //量表指标说明
senateGaugeItemWeight = objRow[convSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()), //量表指标权重
AnswerModeId = objRow[convSenateGaugeItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeId].ToString().Trim(), //答案模式Id
AnswerTypeId = objRow[convSenateGaugeItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeId].ToString().Trim(), //答案类型ID
GridTitle = objRow[convSenateGaugeItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeItems.GridTitle].ToString().Trim(), //表格标题
QuestionIndex = objRow[convSenateGaugeItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeItems.QuestionIndex].ToString().Trim()), //题目序号
senateGaugeVersionID = objRow[convSenateGaugeItems.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
QuestionNo = objRow[convSenateGaugeItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionNo].ToString().Trim(), //题目编号
QuestionTypeId = objRow[convSenateGaugeItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeId].ToString().Trim(), //题目类型Id
senateGaugeVersionTtlScore = TransNullToFloat(objRow[convSenateGaugeItems.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
AnswerTypeName = objRow[convSenateGaugeItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeName].ToString().Trim(), //答案类型名
AnswerModeName = objRow[convSenateGaugeItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeName].ToString().Trim(), //答案模式名称
senateGaugeItemMemo = objRow[convSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(), //备注
QuestionTypeName = objRow[convSenateGaugeItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeName].ToString().Trim(), //题目类型名
AnswerNum = objRow[convSenateGaugeItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeItems.AnswerNum].ToString().Trim()), //答案数
VersionNo = objRow[convSenateGaugeItems.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeItems.VersionNo].ToString().Trim()), //版本号
IsUse = TransNullToBool(objRow[convSenateGaugeItems.IsUse].ToString().Trim()), //是否使用
senateGaugeVersionMemo = objRow[convSenateGaugeItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionMemo].ToString().Trim(), //评价量表版本说明
senateGaugeItemNameWithOrder = objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder].ToString().Trim(), //量表指标名称WithOrder
UpdDate = objRow[convSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdUserId].ToString().Trim(), //修改用户Id
IsHaveAdditionalMemo = TransNullToBool(objRow[convSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()) //是否有附加说明
};
objvSenateGaugeItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSenateGaugeItemsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvSenateGaugeItemsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvSenateGaugeItemsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = new clsvSenateGaugeItemsEN();
try
{
objvSenateGaugeItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeItemsEN.senateGaugeItemID = objRow[convSenateGaugeItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeItemsEN.senateGaugeItemName = objRow[convSenateGaugeItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeItemsEN.senateGaugeVersionName = objRow[convSenateGaugeItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeItemsEN.AnswerModeId = objRow[convSenateGaugeItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeItemsEN.AnswerTypeId = objRow[convSenateGaugeItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeItemsEN.GridTitle = objRow[convSenateGaugeItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeItemsEN.QuestionIndex = objRow[convSenateGaugeItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeItemsEN.senateGaugeVersionID = objRow[convSenateGaugeItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeItemsEN.QuestionNo = objRow[convSenateGaugeItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeItemsEN.QuestionTypeId = objRow[convSenateGaugeItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convSenateGaugeItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeItemsEN.AnswerTypeName = objRow[convSenateGaugeItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeItemsEN.AnswerModeName = objRow[convSenateGaugeItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeItemsEN.QuestionTypeName = objRow[convSenateGaugeItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeItemsEN.AnswerNum = objRow[convSenateGaugeItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeItemsEN.VersionNo = objRow[convSenateGaugeItems.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeItemsEN.IsUse = TransNullToBool(objRow[convSenateGaugeItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeItemsEN.UpdDate = objRow[convSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeItemsEN.UpdUserId = objRow[convSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeItemsEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvSenateGaugeItemsDA: GetObjByDataRowvSenateGaugeItems)", objException.Message));
}
objvSenateGaugeItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSenateGaugeItemsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvSenateGaugeItemsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = new clsvSenateGaugeItemsEN();
try
{
objvSenateGaugeItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeItemsEN.senateGaugeItemID = objRow[convSenateGaugeItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeItemsEN.senateGaugeItemName = objRow[convSenateGaugeItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeItemsEN.senateGaugeVersionName = objRow[convSenateGaugeItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeItemsEN.AnswerModeId = objRow[convSenateGaugeItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeItemsEN.AnswerTypeId = objRow[convSenateGaugeItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeItemsEN.GridTitle = objRow[convSenateGaugeItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeItemsEN.QuestionIndex = objRow[convSenateGaugeItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeItemsEN.senateGaugeVersionID = objRow[convSenateGaugeItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeItemsEN.QuestionNo = objRow[convSenateGaugeItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeItemsEN.QuestionTypeId = objRow[convSenateGaugeItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convSenateGaugeItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeItemsEN.AnswerTypeName = objRow[convSenateGaugeItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeItemsEN.AnswerModeName = objRow[convSenateGaugeItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeItemsEN.QuestionTypeName = objRow[convSenateGaugeItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeItemsEN.AnswerNum = objRow[convSenateGaugeItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeItemsEN.VersionNo = objRow[convSenateGaugeItems.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeItemsEN.IsUse = TransNullToBool(objRow[convSenateGaugeItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeItemsEN.UpdDate = objRow[convSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeItemsEN.UpdUserId = objRow[convSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeItemsEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvSenateGaugeItemsDA: GetObjByDataRow)", objException.Message));
}
objvSenateGaugeItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSenateGaugeItemsEN;
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
objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSenateGaugeItemsEN._CurrTabName, convSenateGaugeItems.IdSenateGaugeItem, 4, "");
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
objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSenateGaugeItemsEN._CurrTabName, convSenateGaugeItems.IdSenateGaugeItem, 4, strPrefix);
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
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdSenateGaugeItem from vSenateGaugeItems where " + strCondition;
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
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdSenateGaugeItem from vSenateGaugeItems where " + strCondition;
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
 /// <param name = "strIdSenateGaugeItem">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdSenateGaugeItem)
{
CheckPrimaryKey(strIdSenateGaugeItem);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSenateGaugeItems", "IdSenateGaugeItem = " + "'"+ strIdSenateGaugeItem+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvSenateGaugeItemsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSenateGaugeItems", strCondition))
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
objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vSenateGaugeItems");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsENS">源对象</param>
 /// <param name = "objvSenateGaugeItemsENT">目标对象</param>
public void CopyTo(clsvSenateGaugeItemsEN objvSenateGaugeItemsENS, clsvSenateGaugeItemsEN objvSenateGaugeItemsENT)
{
objvSenateGaugeItemsENT.IdSenateGaugeItem = objvSenateGaugeItemsENS.IdSenateGaugeItem; //量表指标流水号
objvSenateGaugeItemsENT.senateGaugeItemID = objvSenateGaugeItemsENS.senateGaugeItemID; //量表指标ID
objvSenateGaugeItemsENT.senateGaugeItemName = objvSenateGaugeItemsENS.senateGaugeItemName; //量表指标名称
objvSenateGaugeItemsENT.IdSenateGaugeVersion = objvSenateGaugeItemsENS.IdSenateGaugeVersion; //评价量表版本流水号
objvSenateGaugeItemsENT.senateGaugeVersionName = objvSenateGaugeItemsENS.senateGaugeVersionName; //评价量表版本名称
objvSenateGaugeItemsENT.senateGaugeItemDesc = objvSenateGaugeItemsENS.senateGaugeItemDesc; //量表指标说明
objvSenateGaugeItemsENT.senateGaugeItemWeight = objvSenateGaugeItemsENS.senateGaugeItemWeight; //量表指标权重
objvSenateGaugeItemsENT.AnswerModeId = objvSenateGaugeItemsENS.AnswerModeId; //答案模式Id
objvSenateGaugeItemsENT.AnswerTypeId = objvSenateGaugeItemsENS.AnswerTypeId; //答案类型ID
objvSenateGaugeItemsENT.GridTitle = objvSenateGaugeItemsENS.GridTitle; //表格标题
objvSenateGaugeItemsENT.QuestionIndex = objvSenateGaugeItemsENS.QuestionIndex; //题目序号
objvSenateGaugeItemsENT.senateGaugeVersionID = objvSenateGaugeItemsENS.senateGaugeVersionID; //评价量表版本ID
objvSenateGaugeItemsENT.QuestionNo = objvSenateGaugeItemsENS.QuestionNo; //题目编号
objvSenateGaugeItemsENT.QuestionTypeId = objvSenateGaugeItemsENS.QuestionTypeId; //题目类型Id
objvSenateGaugeItemsENT.senateGaugeVersionTtlScore = objvSenateGaugeItemsENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvSenateGaugeItemsENT.AnswerTypeName = objvSenateGaugeItemsENS.AnswerTypeName; //答案类型名
objvSenateGaugeItemsENT.AnswerModeName = objvSenateGaugeItemsENS.AnswerModeName; //答案模式名称
objvSenateGaugeItemsENT.senateGaugeItemMemo = objvSenateGaugeItemsENS.senateGaugeItemMemo; //备注
objvSenateGaugeItemsENT.QuestionTypeName = objvSenateGaugeItemsENS.QuestionTypeName; //题目类型名
objvSenateGaugeItemsENT.AnswerNum = objvSenateGaugeItemsENS.AnswerNum; //答案数
objvSenateGaugeItemsENT.VersionNo = objvSenateGaugeItemsENS.VersionNo; //版本号
objvSenateGaugeItemsENT.IsUse = objvSenateGaugeItemsENS.IsUse; //是否使用
objvSenateGaugeItemsENT.senateGaugeVersionMemo = objvSenateGaugeItemsENS.senateGaugeVersionMemo; //评价量表版本说明
objvSenateGaugeItemsENT.senateGaugeItemNameWithOrder = objvSenateGaugeItemsENS.senateGaugeItemNameWithOrder; //量表指标名称WithOrder
objvSenateGaugeItemsENT.UpdDate = objvSenateGaugeItemsENS.UpdDate; //修改日期
objvSenateGaugeItemsENT.UpdUserId = objvSenateGaugeItemsENS.UpdUserId; //修改用户Id
objvSenateGaugeItemsENT.IsHaveAdditionalMemo = objvSenateGaugeItemsENS.IsHaveAdditionalMemo; //是否有附加说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvSenateGaugeItemsEN objvSenateGaugeItemsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.IdSenateGaugeItem, 4, convSenateGaugeItems.IdSenateGaugeItem);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.senateGaugeItemID, 4, convSenateGaugeItems.senateGaugeItemID);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.senateGaugeItemName, 200, convSenateGaugeItems.senateGaugeItemName);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.IdSenateGaugeVersion, 4, convSenateGaugeItems.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.senateGaugeVersionName, 200, convSenateGaugeItems.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.senateGaugeItemDesc, 2000, convSenateGaugeItems.senateGaugeItemDesc);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.AnswerModeId, 4, convSenateGaugeItems.AnswerModeId);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.AnswerTypeId, 2, convSenateGaugeItems.AnswerTypeId);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.GridTitle, 30, convSenateGaugeItems.GridTitle);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.senateGaugeVersionID, 4, convSenateGaugeItems.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.QuestionNo, 10, convSenateGaugeItems.QuestionNo);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.QuestionTypeId, 2, convSenateGaugeItems.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.AnswerTypeName, 50, convSenateGaugeItems.AnswerTypeName);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.AnswerModeName, 30, convSenateGaugeItems.AnswerModeName);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.senateGaugeItemMemo, 1000, convSenateGaugeItems.senateGaugeItemMemo);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.QuestionTypeName, 20, convSenateGaugeItems.QuestionTypeName);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.senateGaugeVersionMemo, 1000, convSenateGaugeItems.senateGaugeVersionMemo);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder, 204, convSenateGaugeItems.senateGaugeItemNameWithOrder);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.UpdDate, 20, convSenateGaugeItems.UpdDate);
clsCheckSql.CheckFieldLen(objvSenateGaugeItemsEN.UpdUserId, 20, convSenateGaugeItems.UpdUserId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.IdSenateGaugeItem, convSenateGaugeItems.IdSenateGaugeItem);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.senateGaugeItemID, convSenateGaugeItems.senateGaugeItemID);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.senateGaugeItemName, convSenateGaugeItems.senateGaugeItemName);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.IdSenateGaugeVersion, convSenateGaugeItems.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.senateGaugeVersionName, convSenateGaugeItems.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.senateGaugeItemDesc, convSenateGaugeItems.senateGaugeItemDesc);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.AnswerModeId, convSenateGaugeItems.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.AnswerTypeId, convSenateGaugeItems.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.GridTitle, convSenateGaugeItems.GridTitle);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.senateGaugeVersionID, convSenateGaugeItems.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.QuestionNo, convSenateGaugeItems.QuestionNo);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.QuestionTypeId, convSenateGaugeItems.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.AnswerTypeName, convSenateGaugeItems.AnswerTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.AnswerModeName, convSenateGaugeItems.AnswerModeName);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.senateGaugeItemMemo, convSenateGaugeItems.senateGaugeItemMemo);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.QuestionTypeName, convSenateGaugeItems.QuestionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.senateGaugeVersionMemo, convSenateGaugeItems.senateGaugeVersionMemo);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder, convSenateGaugeItems.senateGaugeItemNameWithOrder);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.UpdDate, convSenateGaugeItems.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeItemsEN.UpdUserId, convSenateGaugeItems.UpdUserId);
//检查外键字段长度
 objvSenateGaugeItemsEN._IsCheckProperty = true;
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
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
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
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
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
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSenateGaugeItemsEN._CurrTabName);
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
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSenateGaugeItemsEN._CurrTabName, strCondition);
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
 objSQL = clsvSenateGaugeItemsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}