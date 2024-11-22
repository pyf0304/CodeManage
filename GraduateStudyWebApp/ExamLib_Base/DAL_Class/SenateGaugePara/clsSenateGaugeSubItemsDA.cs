
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSenateGaugeSubItemsDA
 表名:SenateGaugeSubItems(01120478)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数(SenateGaugePara)
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
 /// 量表指标子项(SenateGaugeSubItems)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSenateGaugeSubItemsDA : clsCommBase4DA
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
 return clsSenateGaugeSubItemsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSenateGaugeSubItemsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSenateGaugeSubItemsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSenateGaugeSubItemsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSenateGaugeSubItemsEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:SenateGaugeSubItems中,检查关键字,长度不正确!(clsSenateGaugeSubItemsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdSenateGaugeSubItem)  ==  true)
{
throw new Exception("(errid:Data000002)在表:SenateGaugeSubItems中,关键字不能为空 或 null!(clsSenateGaugeSubItemsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSenateGaugeSubItem);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsSenateGaugeSubItemsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSenateGaugeSubItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeSubItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SenateGaugeSubItems(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSenateGaugeSubItemsDA: GetDataTable_SenateGaugeSubItems)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeSubItems where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSenateGaugeSubItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSenateGaugeSubItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeSubItems where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSenateGaugeSubItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSenateGaugeSubItemsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeSubItems where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeSubItems where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSenateGaugeSubItemsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SenateGaugeSubItems where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSenateGaugeSubItemsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SenateGaugeSubItems.* from SenateGaugeSubItems Left Join {1} on {2} where {3} and SenateGaugeSubItems.IdSenateGaugeSubItem not in (Select top {5} SenateGaugeSubItems.IdSenateGaugeSubItem from SenateGaugeSubItems Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeSubItems where {1} and IdSenateGaugeSubItem not in (Select top {2} IdSenateGaugeSubItem from SenateGaugeSubItems where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeSubItems where {1} and IdSenateGaugeSubItem not in (Select top {3} IdSenateGaugeSubItem from SenateGaugeSubItems where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSenateGaugeSubItemsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SenateGaugeSubItems.* from SenateGaugeSubItems Left Join {1} on {2} where {3} and SenateGaugeSubItems.IdSenateGaugeSubItem not in (Select top {5} SenateGaugeSubItems.IdSenateGaugeSubItem from SenateGaugeSubItems Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeSubItems where {1} and IdSenateGaugeSubItem not in (Select top {2} IdSenateGaugeSubItem from SenateGaugeSubItems where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeSubItems where {1} and IdSenateGaugeSubItem not in (Select top {3} IdSenateGaugeSubItem from SenateGaugeSubItems where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSenateGaugeSubItemsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSenateGaugeSubItemsDA:GetObjLst)", objException.Message));
}
List<clsSenateGaugeSubItemsEN> arrObjLst = new List<clsSenateGaugeSubItemsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeSubItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN();
try
{
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objSenateGaugeSubItemsEN.senateGaugeSubItemScore = TransNullToFloat(objRow[conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objSenateGaugeSubItemsEN.AnswerTitle = objRow[conSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objSenateGaugeSubItemsEN.AnswerIndex = objRow[conSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objSenateGaugeSubItemsEN.UpdDate = objRow[conSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeSubItemsEN.UpdUserId = objRow[conSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSenateGaugeSubItemsDA: GetObjLst)", objException.Message));
}
objSenateGaugeSubItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSenateGaugeSubItemsEN);
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
public List<clsSenateGaugeSubItemsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSenateGaugeSubItemsDA:GetObjLstByTabName)", objException.Message));
}
List<clsSenateGaugeSubItemsEN> arrObjLst = new List<clsSenateGaugeSubItemsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN();
try
{
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objSenateGaugeSubItemsEN.senateGaugeSubItemScore = TransNullToFloat(objRow[conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objSenateGaugeSubItemsEN.AnswerTitle = objRow[conSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objSenateGaugeSubItemsEN.AnswerIndex = objRow[conSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objSenateGaugeSubItemsEN.UpdDate = objRow[conSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeSubItemsEN.UpdUserId = objRow[conSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSenateGaugeSubItemsDA: GetObjLst)", objException.Message));
}
objSenateGaugeSubItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSenateGaugeSubItemsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSenateGaugeSubItems(ref clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeSubItems where IdSenateGaugeSubItem = " + "'"+ objSenateGaugeSubItemsEN.IdSenateGaugeSubItem+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objDT.Rows[0][conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号(字段类型:char,字段长度:4,是否可空:True)
 objSenateGaugeSubItemsEN.IdSenateGaugeItem = objDT.Rows[0][conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeSubItemsEN.senateGaugeSubItemID = objDT.Rows[0][conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID(字段类型:char,字段长度:4,是否可空:True)
 objSenateGaugeSubItemsEN.senateGaugeSubItemName = objDT.Rows[0][conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称(字段类型:varchar,字段长度:200,是否可空:True)
 objSenateGaugeSubItemsEN.senateGaugeSubItemScore = TransNullToFloat(objDT.Rows[0][conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数(字段类型:float,字段长度:8,是否可空:True)
 objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objDT.Rows[0][conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objSenateGaugeSubItemsEN.AnswerTitle = objDT.Rows[0][conSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题(字段类型:varchar,字段长度:20,是否可空:True)
 objSenateGaugeSubItemsEN.AnswerIndex = TransNullToInt(objDT.Rows[0][conSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号(字段类型:int,字段长度:4,是否可空:True)
 objSenateGaugeSubItemsEN.UpdDate = objDT.Rows[0][conSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSenateGaugeSubItemsEN.UpdUserId = objDT.Rows[0][conSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objDT.Rows[0][conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSenateGaugeSubItemsDA: GetSenateGaugeSubItems)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdSenateGaugeSubItem">表关键字</param>
 /// <returns>表对象</returns>
public clsSenateGaugeSubItemsEN GetObjByIdSenateGaugeSubItem(string strIdSenateGaugeSubItem)
{
CheckPrimaryKey(strIdSenateGaugeSubItem);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeSubItems where IdSenateGaugeSubItem = " + "'"+ strIdSenateGaugeSubItem+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN();
try
{
 objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号(字段类型:char,字段长度:4,是否可空:True)
 objSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID(字段类型:char,字段长度:4,是否可空:True)
 objSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称(字段类型:varchar,字段长度:200,是否可空:True)
 objSenateGaugeSubItemsEN.senateGaugeSubItemScore = Single.Parse(objRow[conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数(字段类型:float,字段长度:8,是否可空:True)
 objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objSenateGaugeSubItemsEN.AnswerTitle = objRow[conSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题(字段类型:varchar,字段长度:20,是否可空:True)
 objSenateGaugeSubItemsEN.AnswerIndex = objRow[conSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号(字段类型:int,字段长度:4,是否可空:True)
 objSenateGaugeSubItemsEN.UpdDate = objRow[conSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSenateGaugeSubItemsEN.UpdUserId = objRow[conSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSenateGaugeSubItemsDA: GetObjByIdSenateGaugeSubItem)", objException.Message));
}
return objSenateGaugeSubItemsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSenateGaugeSubItemsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSenateGaugeSubItemsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeSubItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN()
{
IdSenateGaugeSubItem = objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(), //量表指标子项流水号
IdSenateGaugeItem = objRow[conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(), //量表指标流水号
senateGaugeSubItemID = objRow[conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(), //量表指标子项ID
senateGaugeSubItemName = objRow[conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(), //量表指标子项名称
senateGaugeSubItemScore = TransNullToFloat(objRow[conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()), //量表指标子项分数
senateGaugeSubItemDesc = objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(), //量表指标子项说明
AnswerTitle = objRow[conSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.AnswerTitle].ToString().Trim(), //答案标题
AnswerIndex = objRow[conSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSenateGaugeSubItems.AnswerIndex].ToString().Trim()), //问答序号
UpdDate = objRow[conSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdUserId].ToString().Trim(), //修改用户Id
senateGaugeSubItemMemo = objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim() //量表指标子项备注
};
objSenateGaugeSubItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSenateGaugeSubItemsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSenateGaugeSubItemsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSenateGaugeSubItemsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN();
try
{
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objSenateGaugeSubItemsEN.senateGaugeSubItemScore = TransNullToFloat(objRow[conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objSenateGaugeSubItemsEN.AnswerTitle = objRow[conSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objSenateGaugeSubItemsEN.AnswerIndex = objRow[conSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objSenateGaugeSubItemsEN.UpdDate = objRow[conSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeSubItemsEN.UpdUserId = objRow[conSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSenateGaugeSubItemsDA: GetObjByDataRowSenateGaugeSubItems)", objException.Message));
}
objSenateGaugeSubItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSenateGaugeSubItemsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSenateGaugeSubItemsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN();
try
{
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objSenateGaugeSubItemsEN.senateGaugeSubItemScore = TransNullToFloat(objRow[conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objSenateGaugeSubItemsEN.AnswerTitle = objRow[conSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objSenateGaugeSubItemsEN.AnswerIndex = objRow[conSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objSenateGaugeSubItemsEN.UpdDate = objRow[conSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeSubItemsEN.UpdUserId = objRow[conSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSenateGaugeSubItemsDA: GetObjByDataRow)", objException.Message));
}
objSenateGaugeSubItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSenateGaugeSubItemsEN;
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
objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSenateGaugeSubItemsEN._CurrTabName, conSenateGaugeSubItems.IdSenateGaugeSubItem, 4, "");
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
objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSenateGaugeSubItemsEN._CurrTabName, conSenateGaugeSubItems.IdSenateGaugeSubItem, 4, strPrefix);
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
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdSenateGaugeSubItem from SenateGaugeSubItems where " + strCondition;
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
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdSenateGaugeSubItem from SenateGaugeSubItems where " + strCondition;
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
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SenateGaugeSubItems", "IdSenateGaugeSubItem = " + "'"+ strIdSenateGaugeSubItem+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSenateGaugeSubItemsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SenateGaugeSubItems", strCondition))
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
objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SenateGaugeSubItems");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
 {
 objSenateGaugeSubItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeSubItemsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeSubItemsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeSubItems where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SenateGaugeSubItems");
objRow = objDS.Tables["SenateGaugeSubItems"].NewRow();
objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem] = objSenateGaugeSubItemsEN.IdSenateGaugeSubItem; //量表指标子项流水号
objRow[conSenateGaugeSubItems.IdSenateGaugeItem] = objSenateGaugeSubItemsEN.IdSenateGaugeItem; //量表指标流水号
objRow[conSenateGaugeSubItems.senateGaugeSubItemID] = objSenateGaugeSubItemsEN.senateGaugeSubItemID; //量表指标子项ID
objRow[conSenateGaugeSubItems.senateGaugeSubItemName] = objSenateGaugeSubItemsEN.senateGaugeSubItemName; //量表指标子项名称
objRow[conSenateGaugeSubItems.senateGaugeSubItemScore] = objSenateGaugeSubItemsEN.senateGaugeSubItemScore; //量表指标子项分数
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemDesc !=  "")
 {
objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] = objSenateGaugeSubItemsEN.senateGaugeSubItemDesc; //量表指标子项说明
 }
 if (objSenateGaugeSubItemsEN.AnswerTitle !=  "")
 {
objRow[conSenateGaugeSubItems.AnswerTitle] = objSenateGaugeSubItemsEN.AnswerTitle; //答案标题
 }
objRow[conSenateGaugeSubItems.AnswerIndex] = objSenateGaugeSubItemsEN.AnswerIndex; //问答序号
 if (objSenateGaugeSubItemsEN.UpdDate !=  "")
 {
objRow[conSenateGaugeSubItems.UpdDate] = objSenateGaugeSubItemsEN.UpdDate; //修改日期
 }
 if (objSenateGaugeSubItemsEN.UpdUserId !=  "")
 {
objRow[conSenateGaugeSubItems.UpdUserId] = objSenateGaugeSubItemsEN.UpdUserId; //修改用户Id
 }
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemMemo !=  "")
 {
objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] = objSenateGaugeSubItemsEN.senateGaugeSubItemMemo; //量表指标子项备注
 }
objDS.Tables[clsSenateGaugeSubItemsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSenateGaugeSubItemsEN._CurrTabName);
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
 /// <param name = "objSenateGaugeSubItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
 objSenateGaugeSubItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeSubItemsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeSubItemsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSenateGaugeSubItemsEN.IdSenateGaugeSubItem !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.IdSenateGaugeSubItem);
 var strIdSenateGaugeSubItem = objSenateGaugeSubItemsEN.IdSenateGaugeSubItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeSubItem + "'");
 }
 
 if (objSenateGaugeSubItemsEN.IdSenateGaugeItem !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.IdSenateGaugeItem);
 var strIdSenateGaugeItem = objSenateGaugeSubItemsEN.IdSenateGaugeItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeItem + "'");
 }
 
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemID !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemID);
 var strsenateGaugeSubItemID = objSenateGaugeSubItemsEN.senateGaugeSubItemID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeSubItemID + "'");
 }
 
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemName !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemName);
 var strsenateGaugeSubItemName = objSenateGaugeSubItemsEN.senateGaugeSubItemName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeSubItemName + "'");
 }
 
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemScore);
 arrValueListForInsert.Add(objSenateGaugeSubItemsEN.senateGaugeSubItemScore.ToString());
 
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemDesc !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemDesc);
 var strsenateGaugeSubItemDesc = objSenateGaugeSubItemsEN.senateGaugeSubItemDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeSubItemDesc + "'");
 }
 
 if (objSenateGaugeSubItemsEN.AnswerTitle !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.AnswerTitle);
 var strAnswerTitle = objSenateGaugeSubItemsEN.AnswerTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTitle + "'");
 }
 
 if (objSenateGaugeSubItemsEN.AnswerIndex !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.AnswerIndex);
 arrValueListForInsert.Add(objSenateGaugeSubItemsEN.AnswerIndex.ToString());
 }
 
 if (objSenateGaugeSubItemsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.UpdDate);
 var strUpdDate = objSenateGaugeSubItemsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSenateGaugeSubItemsEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.UpdUserId);
 var strUpdUserId = objSenateGaugeSubItemsEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemMemo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemMemo);
 var strsenateGaugeSubItemMemo = objSenateGaugeSubItemsEN.senateGaugeSubItemMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeSubItemMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SenateGaugeSubItems");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
 objSenateGaugeSubItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeSubItemsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeSubItemsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSenateGaugeSubItemsEN.IdSenateGaugeSubItem !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.IdSenateGaugeSubItem);
 var strIdSenateGaugeSubItem = objSenateGaugeSubItemsEN.IdSenateGaugeSubItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeSubItem + "'");
 }
 
 if (objSenateGaugeSubItemsEN.IdSenateGaugeItem !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.IdSenateGaugeItem);
 var strIdSenateGaugeItem = objSenateGaugeSubItemsEN.IdSenateGaugeItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeItem + "'");
 }
 
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemID !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemID);
 var strsenateGaugeSubItemID = objSenateGaugeSubItemsEN.senateGaugeSubItemID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeSubItemID + "'");
 }
 
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemName !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemName);
 var strsenateGaugeSubItemName = objSenateGaugeSubItemsEN.senateGaugeSubItemName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeSubItemName + "'");
 }
 
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemScore);
 arrValueListForInsert.Add(objSenateGaugeSubItemsEN.senateGaugeSubItemScore.ToString());
 
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemDesc !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemDesc);
 var strsenateGaugeSubItemDesc = objSenateGaugeSubItemsEN.senateGaugeSubItemDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeSubItemDesc + "'");
 }
 
 if (objSenateGaugeSubItemsEN.AnswerTitle !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.AnswerTitle);
 var strAnswerTitle = objSenateGaugeSubItemsEN.AnswerTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTitle + "'");
 }
 
 if (objSenateGaugeSubItemsEN.AnswerIndex !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.AnswerIndex);
 arrValueListForInsert.Add(objSenateGaugeSubItemsEN.AnswerIndex.ToString());
 }
 
 if (objSenateGaugeSubItemsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.UpdDate);
 var strUpdDate = objSenateGaugeSubItemsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSenateGaugeSubItemsEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.UpdUserId);
 var strUpdUserId = objSenateGaugeSubItemsEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemMemo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemMemo);
 var strsenateGaugeSubItemMemo = objSenateGaugeSubItemsEN.senateGaugeSubItemMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeSubItemMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SenateGaugeSubItems");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objSenateGaugeSubItemsEN.IdSenateGaugeSubItem;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSenateGaugeSubItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeSubItemsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeSubItemsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSenateGaugeSubItemsEN.IdSenateGaugeSubItem !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.IdSenateGaugeSubItem);
 var strIdSenateGaugeSubItem = objSenateGaugeSubItemsEN.IdSenateGaugeSubItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeSubItem + "'");
 }
 
 if (objSenateGaugeSubItemsEN.IdSenateGaugeItem !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.IdSenateGaugeItem);
 var strIdSenateGaugeItem = objSenateGaugeSubItemsEN.IdSenateGaugeItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeItem + "'");
 }
 
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemID !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemID);
 var strsenateGaugeSubItemID = objSenateGaugeSubItemsEN.senateGaugeSubItemID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeSubItemID + "'");
 }
 
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemName !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemName);
 var strsenateGaugeSubItemName = objSenateGaugeSubItemsEN.senateGaugeSubItemName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeSubItemName + "'");
 }
 
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemScore);
 arrValueListForInsert.Add(objSenateGaugeSubItemsEN.senateGaugeSubItemScore.ToString());
 
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemDesc !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemDesc);
 var strsenateGaugeSubItemDesc = objSenateGaugeSubItemsEN.senateGaugeSubItemDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeSubItemDesc + "'");
 }
 
 if (objSenateGaugeSubItemsEN.AnswerTitle !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.AnswerTitle);
 var strAnswerTitle = objSenateGaugeSubItemsEN.AnswerTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTitle + "'");
 }
 
 if (objSenateGaugeSubItemsEN.AnswerIndex !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.AnswerIndex);
 arrValueListForInsert.Add(objSenateGaugeSubItemsEN.AnswerIndex.ToString());
 }
 
 if (objSenateGaugeSubItemsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.UpdDate);
 var strUpdDate = objSenateGaugeSubItemsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSenateGaugeSubItemsEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.UpdUserId);
 var strUpdUserId = objSenateGaugeSubItemsEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemMemo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemMemo);
 var strsenateGaugeSubItemMemo = objSenateGaugeSubItemsEN.senateGaugeSubItemMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeSubItemMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SenateGaugeSubItems");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objSenateGaugeSubItemsEN.IdSenateGaugeSubItem;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSenateGaugeSubItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeSubItemsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeSubItemsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSenateGaugeSubItemsEN.IdSenateGaugeSubItem !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.IdSenateGaugeSubItem);
 var strIdSenateGaugeSubItem = objSenateGaugeSubItemsEN.IdSenateGaugeSubItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeSubItem + "'");
 }
 
 if (objSenateGaugeSubItemsEN.IdSenateGaugeItem !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.IdSenateGaugeItem);
 var strIdSenateGaugeItem = objSenateGaugeSubItemsEN.IdSenateGaugeItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeItem + "'");
 }
 
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemID !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemID);
 var strsenateGaugeSubItemID = objSenateGaugeSubItemsEN.senateGaugeSubItemID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeSubItemID + "'");
 }
 
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemName !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemName);
 var strsenateGaugeSubItemName = objSenateGaugeSubItemsEN.senateGaugeSubItemName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeSubItemName + "'");
 }
 
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemScore);
 arrValueListForInsert.Add(objSenateGaugeSubItemsEN.senateGaugeSubItemScore.ToString());
 
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemDesc !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemDesc);
 var strsenateGaugeSubItemDesc = objSenateGaugeSubItemsEN.senateGaugeSubItemDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeSubItemDesc + "'");
 }
 
 if (objSenateGaugeSubItemsEN.AnswerTitle !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.AnswerTitle);
 var strAnswerTitle = objSenateGaugeSubItemsEN.AnswerTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTitle + "'");
 }
 
 if (objSenateGaugeSubItemsEN.AnswerIndex !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.AnswerIndex);
 arrValueListForInsert.Add(objSenateGaugeSubItemsEN.AnswerIndex.ToString());
 }
 
 if (objSenateGaugeSubItemsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.UpdDate);
 var strUpdDate = objSenateGaugeSubItemsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSenateGaugeSubItemsEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.UpdUserId);
 var strUpdUserId = objSenateGaugeSubItemsEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemMemo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeSubItems.senateGaugeSubItemMemo);
 var strsenateGaugeSubItemMemo = objSenateGaugeSubItemsEN.senateGaugeSubItemMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeSubItemMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SenateGaugeSubItems");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSenateGaugeSubItemss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeSubItems where IdSenateGaugeSubItem = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SenateGaugeSubItems");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdSenateGaugeSubItem = oRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim();
if (IsExist(strIdSenateGaugeSubItem))
{
 string strResult = "关键字变量值为:" + string.Format("IdSenateGaugeSubItem = {0}", strIdSenateGaugeSubItem) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSenateGaugeSubItemsEN._CurrTabName ].NewRow();
objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem] = oRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objRow[conSenateGaugeSubItems.IdSenateGaugeItem] = oRow[conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objRow[conSenateGaugeSubItems.senateGaugeSubItemID] = oRow[conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objRow[conSenateGaugeSubItems.senateGaugeSubItemName] = oRow[conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objRow[conSenateGaugeSubItems.senateGaugeSubItemScore] = oRow[conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim(); //量表指标子项分数
objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] = oRow[conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objRow[conSenateGaugeSubItems.AnswerTitle] = oRow[conSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objRow[conSenateGaugeSubItems.AnswerIndex] = oRow[conSenateGaugeSubItems.AnswerIndex].ToString().Trim(); //问答序号
objRow[conSenateGaugeSubItems.UpdDate] = oRow[conSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objRow[conSenateGaugeSubItems.UpdUserId] = oRow[conSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] = oRow[conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
 objDS.Tables[clsSenateGaugeSubItemsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSenateGaugeSubItemsEN._CurrTabName);
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
 /// <param name = "objSenateGaugeSubItemsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
 objSenateGaugeSubItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeSubItemsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeSubItemsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeSubItems where IdSenateGaugeSubItem = " + "'"+ objSenateGaugeSubItemsEN.IdSenateGaugeSubItem+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSenateGaugeSubItemsEN._CurrTabName);
if (objDS.Tables[clsSenateGaugeSubItemsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdSenateGaugeSubItem = " + "'"+ objSenateGaugeSubItemsEN.IdSenateGaugeSubItem+"'");
return false;
}
objRow = objDS.Tables[clsSenateGaugeSubItemsEN._CurrTabName].Rows[0];
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.IdSenateGaugeSubItem))
 {
objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem] = objSenateGaugeSubItemsEN.IdSenateGaugeSubItem; //量表指标子项流水号
 }
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.IdSenateGaugeItem))
 {
objRow[conSenateGaugeSubItems.IdSenateGaugeItem] = objSenateGaugeSubItemsEN.IdSenateGaugeItem; //量表指标流水号
 }
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemID))
 {
objRow[conSenateGaugeSubItems.senateGaugeSubItemID] = objSenateGaugeSubItemsEN.senateGaugeSubItemID; //量表指标子项ID
 }
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemName))
 {
objRow[conSenateGaugeSubItems.senateGaugeSubItemName] = objSenateGaugeSubItemsEN.senateGaugeSubItemName; //量表指标子项名称
 }
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemScore))
 {
objRow[conSenateGaugeSubItems.senateGaugeSubItemScore] = objSenateGaugeSubItemsEN.senateGaugeSubItemScore; //量表指标子项分数
 }
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemDesc))
 {
objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] = objSenateGaugeSubItemsEN.senateGaugeSubItemDesc; //量表指标子项说明
 }
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.AnswerTitle))
 {
objRow[conSenateGaugeSubItems.AnswerTitle] = objSenateGaugeSubItemsEN.AnswerTitle; //答案标题
 }
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.AnswerIndex))
 {
objRow[conSenateGaugeSubItems.AnswerIndex] = objSenateGaugeSubItemsEN.AnswerIndex; //问答序号
 }
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.UpdDate))
 {
objRow[conSenateGaugeSubItems.UpdDate] = objSenateGaugeSubItemsEN.UpdDate; //修改日期
 }
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.UpdUserId))
 {
objRow[conSenateGaugeSubItems.UpdUserId] = objSenateGaugeSubItemsEN.UpdUserId; //修改用户Id
 }
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemMemo))
 {
objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] = objSenateGaugeSubItemsEN.senateGaugeSubItemMemo; //量表指标子项备注
 }
try
{
objDA.Update(objDS, clsSenateGaugeSubItemsEN._CurrTabName);
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
 /// <param name = "objSenateGaugeSubItemsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
 objSenateGaugeSubItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeSubItemsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeSubItemsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SenateGaugeSubItems Set ");
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.IdSenateGaugeItem))
 {
 if (objSenateGaugeSubItemsEN.IdSenateGaugeItem !=  null)
 {
 var strIdSenateGaugeItem = objSenateGaugeSubItemsEN.IdSenateGaugeItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeItem, conSenateGaugeSubItems.IdSenateGaugeItem); //量表指标流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.IdSenateGaugeItem); //量表指标流水号
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemID))
 {
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemID !=  null)
 {
 var strsenateGaugeSubItemID = objSenateGaugeSubItemsEN.senateGaugeSubItemID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeSubItemID, conSenateGaugeSubItems.senateGaugeSubItemID); //量表指标子项ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.senateGaugeSubItemID); //量表指标子项ID
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemName))
 {
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemName !=  null)
 {
 var strsenateGaugeSubItemName = objSenateGaugeSubItemsEN.senateGaugeSubItemName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeSubItemName, conSenateGaugeSubItems.senateGaugeSubItemName); //量表指标子项名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.senateGaugeSubItemName); //量表指标子项名称
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemScore))
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeSubItemsEN.senateGaugeSubItemScore, conSenateGaugeSubItems.senateGaugeSubItemScore); //量表指标子项分数
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemDesc))
 {
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemDesc !=  null)
 {
 var strsenateGaugeSubItemDesc = objSenateGaugeSubItemsEN.senateGaugeSubItemDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeSubItemDesc, conSenateGaugeSubItems.senateGaugeSubItemDesc); //量表指标子项说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.senateGaugeSubItemDesc); //量表指标子项说明
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.AnswerTitle))
 {
 if (objSenateGaugeSubItemsEN.AnswerTitle !=  null)
 {
 var strAnswerTitle = objSenateGaugeSubItemsEN.AnswerTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTitle, conSenateGaugeSubItems.AnswerTitle); //答案标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.AnswerTitle); //答案标题
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.AnswerIndex))
 {
 if (objSenateGaugeSubItemsEN.AnswerIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeSubItemsEN.AnswerIndex, conSenateGaugeSubItems.AnswerIndex); //问答序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.AnswerIndex); //问答序号
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.UpdDate))
 {
 if (objSenateGaugeSubItemsEN.UpdDate !=  null)
 {
 var strUpdDate = objSenateGaugeSubItemsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSenateGaugeSubItems.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.UpdDate); //修改日期
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.UpdUserId))
 {
 if (objSenateGaugeSubItemsEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSenateGaugeSubItemsEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSenateGaugeSubItems.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.UpdUserId); //修改用户Id
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemMemo))
 {
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemMemo !=  null)
 {
 var strsenateGaugeSubItemMemo = objSenateGaugeSubItemsEN.senateGaugeSubItemMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeSubItemMemo, conSenateGaugeSubItems.senateGaugeSubItemMemo); //量表指标子项备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.senateGaugeSubItemMemo); //量表指标子项备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdSenateGaugeSubItem = '{0}'", objSenateGaugeSubItemsEN.IdSenateGaugeSubItem); 
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
 /// <param name = "objSenateGaugeSubItemsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strCondition)
{
 objSenateGaugeSubItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeSubItemsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeSubItemsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SenateGaugeSubItems Set ");
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.IdSenateGaugeItem))
 {
 if (objSenateGaugeSubItemsEN.IdSenateGaugeItem !=  null)
 {
 var strIdSenateGaugeItem = objSenateGaugeSubItemsEN.IdSenateGaugeItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeItem = '{0}',", strIdSenateGaugeItem); //量表指标流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeItem = null,"); //量表指标流水号
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemID))
 {
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemID !=  null)
 {
 var strsenateGaugeSubItemID = objSenateGaugeSubItemsEN.senateGaugeSubItemID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeSubItemID = '{0}',", strsenateGaugeSubItemID); //量表指标子项ID
 }
 else
 {
 sbSQL.Append(" senateGaugeSubItemID = null,"); //量表指标子项ID
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemName))
 {
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemName !=  null)
 {
 var strsenateGaugeSubItemName = objSenateGaugeSubItemsEN.senateGaugeSubItemName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeSubItemName = '{0}',", strsenateGaugeSubItemName); //量表指标子项名称
 }
 else
 {
 sbSQL.Append(" senateGaugeSubItemName = null,"); //量表指标子项名称
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemScore))
 {
 sbSQL.AppendFormat(" senateGaugeSubItemScore = {0},", objSenateGaugeSubItemsEN.senateGaugeSubItemScore); //量表指标子项分数
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemDesc))
 {
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemDesc !=  null)
 {
 var strsenateGaugeSubItemDesc = objSenateGaugeSubItemsEN.senateGaugeSubItemDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeSubItemDesc = '{0}',", strsenateGaugeSubItemDesc); //量表指标子项说明
 }
 else
 {
 sbSQL.Append(" senateGaugeSubItemDesc = null,"); //量表指标子项说明
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.AnswerTitle))
 {
 if (objSenateGaugeSubItemsEN.AnswerTitle !=  null)
 {
 var strAnswerTitle = objSenateGaugeSubItemsEN.AnswerTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTitle = '{0}',", strAnswerTitle); //答案标题
 }
 else
 {
 sbSQL.Append(" AnswerTitle = null,"); //答案标题
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.AnswerIndex))
 {
 if (objSenateGaugeSubItemsEN.AnswerIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeSubItemsEN.AnswerIndex, conSenateGaugeSubItems.AnswerIndex); //问答序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.AnswerIndex); //问答序号
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.UpdDate))
 {
 if (objSenateGaugeSubItemsEN.UpdDate !=  null)
 {
 var strUpdDate = objSenateGaugeSubItemsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.UpdUserId))
 {
 if (objSenateGaugeSubItemsEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSenateGaugeSubItemsEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemMemo))
 {
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemMemo !=  null)
 {
 var strsenateGaugeSubItemMemo = objSenateGaugeSubItemsEN.senateGaugeSubItemMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeSubItemMemo = '{0}',", strsenateGaugeSubItemMemo); //量表指标子项备注
 }
 else
 {
 sbSQL.Append(" senateGaugeSubItemMemo = null,"); //量表指标子项备注
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
 /// <param name = "objSenateGaugeSubItemsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSenateGaugeSubItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeSubItemsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeSubItemsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SenateGaugeSubItems Set ");
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.IdSenateGaugeItem))
 {
 if (objSenateGaugeSubItemsEN.IdSenateGaugeItem !=  null)
 {
 var strIdSenateGaugeItem = objSenateGaugeSubItemsEN.IdSenateGaugeItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeItem = '{0}',", strIdSenateGaugeItem); //量表指标流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeItem = null,"); //量表指标流水号
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemID))
 {
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemID !=  null)
 {
 var strsenateGaugeSubItemID = objSenateGaugeSubItemsEN.senateGaugeSubItemID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeSubItemID = '{0}',", strsenateGaugeSubItemID); //量表指标子项ID
 }
 else
 {
 sbSQL.Append(" senateGaugeSubItemID = null,"); //量表指标子项ID
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemName))
 {
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemName !=  null)
 {
 var strsenateGaugeSubItemName = objSenateGaugeSubItemsEN.senateGaugeSubItemName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeSubItemName = '{0}',", strsenateGaugeSubItemName); //量表指标子项名称
 }
 else
 {
 sbSQL.Append(" senateGaugeSubItemName = null,"); //量表指标子项名称
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemScore))
 {
 sbSQL.AppendFormat(" senateGaugeSubItemScore = {0},", objSenateGaugeSubItemsEN.senateGaugeSubItemScore); //量表指标子项分数
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemDesc))
 {
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemDesc !=  null)
 {
 var strsenateGaugeSubItemDesc = objSenateGaugeSubItemsEN.senateGaugeSubItemDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeSubItemDesc = '{0}',", strsenateGaugeSubItemDesc); //量表指标子项说明
 }
 else
 {
 sbSQL.Append(" senateGaugeSubItemDesc = null,"); //量表指标子项说明
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.AnswerTitle))
 {
 if (objSenateGaugeSubItemsEN.AnswerTitle !=  null)
 {
 var strAnswerTitle = objSenateGaugeSubItemsEN.AnswerTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTitle = '{0}',", strAnswerTitle); //答案标题
 }
 else
 {
 sbSQL.Append(" AnswerTitle = null,"); //答案标题
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.AnswerIndex))
 {
 if (objSenateGaugeSubItemsEN.AnswerIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeSubItemsEN.AnswerIndex, conSenateGaugeSubItems.AnswerIndex); //问答序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.AnswerIndex); //问答序号
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.UpdDate))
 {
 if (objSenateGaugeSubItemsEN.UpdDate !=  null)
 {
 var strUpdDate = objSenateGaugeSubItemsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.UpdUserId))
 {
 if (objSenateGaugeSubItemsEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSenateGaugeSubItemsEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemMemo))
 {
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemMemo !=  null)
 {
 var strsenateGaugeSubItemMemo = objSenateGaugeSubItemsEN.senateGaugeSubItemMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeSubItemMemo = '{0}',", strsenateGaugeSubItemMemo); //量表指标子项备注
 }
 else
 {
 sbSQL.Append(" senateGaugeSubItemMemo = null,"); //量表指标子项备注
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
 /// <param name = "objSenateGaugeSubItemsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSenateGaugeSubItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeSubItemsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeSubItemsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SenateGaugeSubItems Set ");
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.IdSenateGaugeItem))
 {
 if (objSenateGaugeSubItemsEN.IdSenateGaugeItem !=  null)
 {
 var strIdSenateGaugeItem = objSenateGaugeSubItemsEN.IdSenateGaugeItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeItem, conSenateGaugeSubItems.IdSenateGaugeItem); //量表指标流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.IdSenateGaugeItem); //量表指标流水号
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemID))
 {
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemID !=  null)
 {
 var strsenateGaugeSubItemID = objSenateGaugeSubItemsEN.senateGaugeSubItemID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeSubItemID, conSenateGaugeSubItems.senateGaugeSubItemID); //量表指标子项ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.senateGaugeSubItemID); //量表指标子项ID
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemName))
 {
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemName !=  null)
 {
 var strsenateGaugeSubItemName = objSenateGaugeSubItemsEN.senateGaugeSubItemName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeSubItemName, conSenateGaugeSubItems.senateGaugeSubItemName); //量表指标子项名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.senateGaugeSubItemName); //量表指标子项名称
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemScore))
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeSubItemsEN.senateGaugeSubItemScore, conSenateGaugeSubItems.senateGaugeSubItemScore); //量表指标子项分数
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemDesc))
 {
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemDesc !=  null)
 {
 var strsenateGaugeSubItemDesc = objSenateGaugeSubItemsEN.senateGaugeSubItemDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeSubItemDesc, conSenateGaugeSubItems.senateGaugeSubItemDesc); //量表指标子项说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.senateGaugeSubItemDesc); //量表指标子项说明
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.AnswerTitle))
 {
 if (objSenateGaugeSubItemsEN.AnswerTitle !=  null)
 {
 var strAnswerTitle = objSenateGaugeSubItemsEN.AnswerTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTitle, conSenateGaugeSubItems.AnswerTitle); //答案标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.AnswerTitle); //答案标题
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.AnswerIndex))
 {
 if (objSenateGaugeSubItemsEN.AnswerIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeSubItemsEN.AnswerIndex, conSenateGaugeSubItems.AnswerIndex); //问答序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.AnswerIndex); //问答序号
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.UpdDate))
 {
 if (objSenateGaugeSubItemsEN.UpdDate !=  null)
 {
 var strUpdDate = objSenateGaugeSubItemsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSenateGaugeSubItems.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.UpdDate); //修改日期
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.UpdUserId))
 {
 if (objSenateGaugeSubItemsEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSenateGaugeSubItemsEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSenateGaugeSubItems.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.UpdUserId); //修改用户Id
 }
 }
 
 if (objSenateGaugeSubItemsEN.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemMemo))
 {
 if (objSenateGaugeSubItemsEN.senateGaugeSubItemMemo !=  null)
 {
 var strsenateGaugeSubItemMemo = objSenateGaugeSubItemsEN.senateGaugeSubItemMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeSubItemMemo, conSenateGaugeSubItems.senateGaugeSubItemMemo); //量表指标子项备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeSubItems.senateGaugeSubItemMemo); //量表指标子项备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdSenateGaugeSubItem = '{0}'", objSenateGaugeSubItemsEN.IdSenateGaugeSubItem); 
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
 /// <param name = "strIdSenateGaugeSubItem">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdSenateGaugeSubItem) 
{
CheckPrimaryKey(strIdSenateGaugeSubItem);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdSenateGaugeSubItem,
};
 objSQL.ExecSP("SenateGaugeSubItems_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdSenateGaugeSubItem">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdSenateGaugeSubItem, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdSenateGaugeSubItem);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
//删除SenateGaugeSubItems本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SenateGaugeSubItems where IdSenateGaugeSubItem = " + "'"+ strIdSenateGaugeSubItem+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSenateGaugeSubItems(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除SenateGaugeSubItems本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SenateGaugeSubItems where IdSenateGaugeSubItem in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdSenateGaugeSubItem">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdSenateGaugeSubItem) 
{
CheckPrimaryKey(strIdSenateGaugeSubItem);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
//删除SenateGaugeSubItems本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SenateGaugeSubItems where IdSenateGaugeSubItem = " + "'"+ strIdSenateGaugeSubItem+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSenateGaugeSubItems(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSenateGaugeSubItemsDA: DelSenateGaugeSubItems)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SenateGaugeSubItems where " + strCondition ;
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
public bool DelSenateGaugeSubItemsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSenateGaugeSubItemsDA: DelSenateGaugeSubItemsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SenateGaugeSubItems where " + strCondition ;
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
 /// <param name = "objSenateGaugeSubItemsENS">源对象</param>
 /// <param name = "objSenateGaugeSubItemsENT">目标对象</param>
public void CopyTo(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsENS, clsSenateGaugeSubItemsEN objSenateGaugeSubItemsENT)
{
objSenateGaugeSubItemsENT.IdSenateGaugeSubItem = objSenateGaugeSubItemsENS.IdSenateGaugeSubItem; //量表指标子项流水号
objSenateGaugeSubItemsENT.IdSenateGaugeItem = objSenateGaugeSubItemsENS.IdSenateGaugeItem; //量表指标流水号
objSenateGaugeSubItemsENT.senateGaugeSubItemID = objSenateGaugeSubItemsENS.senateGaugeSubItemID; //量表指标子项ID
objSenateGaugeSubItemsENT.senateGaugeSubItemName = objSenateGaugeSubItemsENS.senateGaugeSubItemName; //量表指标子项名称
objSenateGaugeSubItemsENT.senateGaugeSubItemScore = objSenateGaugeSubItemsENS.senateGaugeSubItemScore; //量表指标子项分数
objSenateGaugeSubItemsENT.senateGaugeSubItemDesc = objSenateGaugeSubItemsENS.senateGaugeSubItemDesc; //量表指标子项说明
objSenateGaugeSubItemsENT.AnswerTitle = objSenateGaugeSubItemsENS.AnswerTitle; //答案标题
objSenateGaugeSubItemsENT.AnswerIndex = objSenateGaugeSubItemsENS.AnswerIndex; //问答序号
objSenateGaugeSubItemsENT.UpdDate = objSenateGaugeSubItemsENS.UpdDate; //修改日期
objSenateGaugeSubItemsENT.UpdUserId = objSenateGaugeSubItemsENS.UpdUserId; //修改用户Id
objSenateGaugeSubItemsENT.senateGaugeSubItemMemo = objSenateGaugeSubItemsENS.senateGaugeSubItemMemo; //量表指标子项备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objSenateGaugeSubItemsEN.IdSenateGaugeItem, conSenateGaugeSubItems.IdSenateGaugeItem);
clsCheckSql.CheckFieldNotNull(objSenateGaugeSubItemsEN.senateGaugeSubItemID, conSenateGaugeSubItems.senateGaugeSubItemID);
clsCheckSql.CheckFieldNotNull(objSenateGaugeSubItemsEN.senateGaugeSubItemName, conSenateGaugeSubItems.senateGaugeSubItemName);
clsCheckSql.CheckFieldNotNull(objSenateGaugeSubItemsEN.senateGaugeSubItemScore, conSenateGaugeSubItems.senateGaugeSubItemScore);
//检查字段长度
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, 4, conSenateGaugeSubItems.IdSenateGaugeSubItem);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.IdSenateGaugeItem, 4, conSenateGaugeSubItems.IdSenateGaugeItem);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.senateGaugeSubItemID, 4, conSenateGaugeSubItems.senateGaugeSubItemID);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.senateGaugeSubItemName, 200, conSenateGaugeSubItems.senateGaugeSubItemName);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.senateGaugeSubItemDesc, 2000, conSenateGaugeSubItems.senateGaugeSubItemDesc);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.AnswerTitle, 20, conSenateGaugeSubItems.AnswerTitle);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.UpdDate, 20, conSenateGaugeSubItems.UpdDate);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.UpdUserId, 20, conSenateGaugeSubItems.UpdUserId);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.senateGaugeSubItemMemo, 1000, conSenateGaugeSubItems.senateGaugeSubItemMemo);
//检查字段外键固定长度
 objSenateGaugeSubItemsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.IdSenateGaugeItem, 4, conSenateGaugeSubItems.IdSenateGaugeItem);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.senateGaugeSubItemID, 4, conSenateGaugeSubItems.senateGaugeSubItemID);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.senateGaugeSubItemName, 200, conSenateGaugeSubItems.senateGaugeSubItemName);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.senateGaugeSubItemDesc, 2000, conSenateGaugeSubItems.senateGaugeSubItemDesc);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.AnswerTitle, 20, conSenateGaugeSubItems.AnswerTitle);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.UpdDate, 20, conSenateGaugeSubItems.UpdDate);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.UpdUserId, 20, conSenateGaugeSubItems.UpdUserId);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.senateGaugeSubItemMemo, 1000, conSenateGaugeSubItems.senateGaugeSubItemMemo);
//检查外键字段长度
 objSenateGaugeSubItemsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, 4, conSenateGaugeSubItems.IdSenateGaugeSubItem);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.IdSenateGaugeItem, 4, conSenateGaugeSubItems.IdSenateGaugeItem);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.senateGaugeSubItemID, 4, conSenateGaugeSubItems.senateGaugeSubItemID);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.senateGaugeSubItemName, 200, conSenateGaugeSubItems.senateGaugeSubItemName);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.senateGaugeSubItemDesc, 2000, conSenateGaugeSubItems.senateGaugeSubItemDesc);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.AnswerTitle, 20, conSenateGaugeSubItems.AnswerTitle);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.UpdDate, 20, conSenateGaugeSubItems.UpdDate);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.UpdUserId, 20, conSenateGaugeSubItems.UpdUserId);
clsCheckSql.CheckFieldLen(objSenateGaugeSubItemsEN.senateGaugeSubItemMemo, 1000, conSenateGaugeSubItems.senateGaugeSubItemMemo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, conSenateGaugeSubItems.IdSenateGaugeSubItem);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeSubItemsEN.IdSenateGaugeItem, conSenateGaugeSubItems.IdSenateGaugeItem);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeSubItemsEN.senateGaugeSubItemID, conSenateGaugeSubItems.senateGaugeSubItemID);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeSubItemsEN.senateGaugeSubItemName, conSenateGaugeSubItems.senateGaugeSubItemName);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeSubItemsEN.senateGaugeSubItemDesc, conSenateGaugeSubItems.senateGaugeSubItemDesc);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeSubItemsEN.AnswerTitle, conSenateGaugeSubItems.AnswerTitle);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeSubItemsEN.UpdDate, conSenateGaugeSubItems.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeSubItemsEN.UpdUserId, conSenateGaugeSubItems.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeSubItemsEN.senateGaugeSubItemMemo, conSenateGaugeSubItems.senateGaugeSubItemMemo);
//检查外键字段长度
 objSenateGaugeSubItemsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdSenateGaugeSubItem()
{
//获取某学院所有专业信息
string strSQL = "select IdSenateGaugeSubItem, senateGaugeSubItemName from SenateGaugeSubItems ";
 clsSpecSQLforSql mySql = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
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
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
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
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSenateGaugeSubItemsEN._CurrTabName);
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
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSenateGaugeSubItemsEN._CurrTabName, strCondition);
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
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
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
 objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}