
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSenateGaugeItemsDA
 表名:SenateGaugeItems(01120476)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:16
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
 /// 量表指标(SenateGaugeItems)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSenateGaugeItemsDA : clsCommBase4DA
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
 return clsSenateGaugeItemsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSenateGaugeItemsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSenateGaugeItemsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSenateGaugeItemsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSenateGaugeItemsEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:SenateGaugeItems中,检查关键字,长度不正确!(clsSenateGaugeItemsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdSenateGaugeItem)  ==  true)
{
throw new Exception("(errid:Data000002)在表:SenateGaugeItems中,关键字不能为空 或 null!(clsSenateGaugeItemsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSenateGaugeItem);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsSenateGaugeItemsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSenateGaugeItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SenateGaugeItems(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSenateGaugeItemsDA: GetDataTable_SenateGaugeItems)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeItems where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSenateGaugeItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSenateGaugeItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeItems where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSenateGaugeItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSenateGaugeItemsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeItems where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeItems where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSenateGaugeItemsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SenateGaugeItems where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSenateGaugeItemsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SenateGaugeItems.* from SenateGaugeItems Left Join {1} on {2} where {3} and SenateGaugeItems.IdSenateGaugeItem not in (Select top {5} SenateGaugeItems.IdSenateGaugeItem from SenateGaugeItems Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeItems where {1} and IdSenateGaugeItem not in (Select top {2} IdSenateGaugeItem from SenateGaugeItems where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeItems where {1} and IdSenateGaugeItem not in (Select top {3} IdSenateGaugeItem from SenateGaugeItems where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSenateGaugeItemsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SenateGaugeItems.* from SenateGaugeItems Left Join {1} on {2} where {3} and SenateGaugeItems.IdSenateGaugeItem not in (Select top {5} SenateGaugeItems.IdSenateGaugeItem from SenateGaugeItems Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeItems where {1} and IdSenateGaugeItem not in (Select top {2} IdSenateGaugeItem from SenateGaugeItems where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeItems where {1} and IdSenateGaugeItem not in (Select top {3} IdSenateGaugeItem from SenateGaugeItems where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSenateGaugeItemsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSenateGaugeItemsDA:GetObjLst)", objException.Message));
}
List<clsSenateGaugeItemsEN> arrObjLst = new List<clsSenateGaugeItemsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN();
try
{
objSenateGaugeItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeItemsEN.senateGaugeItemID = objRow[conSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objSenateGaugeItemsEN.senateGaugeItemName = objRow[conSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objSenateGaugeItemsEN.senateGaugeItemDesc = objRow[conSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objSenateGaugeItemsEN.senateGaugeItemWeight = objRow[conSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objSenateGaugeItemsEN.AnswerModeId = objRow[conSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objSenateGaugeItemsEN.AnswerTypeId = objRow[conSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objSenateGaugeItemsEN.GridTitle = objRow[conSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objSenateGaugeItemsEN.QuestionIndex = TransNullToInt(objRow[conSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objSenateGaugeItemsEN.QuestionNo = objRow[conSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objSenateGaugeItemsEN.QuestionTypeId = objRow[conSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objSenateGaugeItemsEN.IsHaveAdditionalMemo = TransNullToBool(objRow[conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objSenateGaugeItemsEN.UpdDate = objRow[conSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeItemsEN.UpdUserId = objRow[conSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeItemsEN.senateGaugeItemMemo = objRow[conSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSenateGaugeItemsDA: GetObjLst)", objException.Message));
}
objSenateGaugeItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSenateGaugeItemsEN);
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
public List<clsSenateGaugeItemsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSenateGaugeItemsDA:GetObjLstByTabName)", objException.Message));
}
List<clsSenateGaugeItemsEN> arrObjLst = new List<clsSenateGaugeItemsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN();
try
{
objSenateGaugeItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeItemsEN.senateGaugeItemID = objRow[conSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objSenateGaugeItemsEN.senateGaugeItemName = objRow[conSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objSenateGaugeItemsEN.senateGaugeItemDesc = objRow[conSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objSenateGaugeItemsEN.senateGaugeItemWeight = objRow[conSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objSenateGaugeItemsEN.AnswerModeId = objRow[conSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objSenateGaugeItemsEN.AnswerTypeId = objRow[conSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objSenateGaugeItemsEN.GridTitle = objRow[conSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objSenateGaugeItemsEN.QuestionIndex = TransNullToInt(objRow[conSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objSenateGaugeItemsEN.QuestionNo = objRow[conSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objSenateGaugeItemsEN.QuestionTypeId = objRow[conSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objSenateGaugeItemsEN.IsHaveAdditionalMemo = TransNullToBool(objRow[conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objSenateGaugeItemsEN.UpdDate = objRow[conSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeItemsEN.UpdUserId = objRow[conSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeItemsEN.senateGaugeItemMemo = objRow[conSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSenateGaugeItemsDA: GetObjLst)", objException.Message));
}
objSenateGaugeItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSenateGaugeItemsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSenateGaugeItems(ref clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeItems where IdSenateGaugeItem = " + "'"+ objSenateGaugeItemsEN.IdSenateGaugeItem+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSenateGaugeItemsEN.IdSenateGaugeItem = objDT.Rows[0][conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeItemsEN.IdSenateGaugeVersion = objDT.Rows[0][conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeItemsEN.senateGaugeItemID = objDT.Rows[0][conSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID(字段类型:char,字段长度:4,是否可空:True)
 objSenateGaugeItemsEN.senateGaugeItemName = objDT.Rows[0][conSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称(字段类型:varchar,字段长度:200,是否可空:True)
 objSenateGaugeItemsEN.senateGaugeItemDesc = objDT.Rows[0][conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objSenateGaugeItemsEN.senateGaugeItemWeight = TransNullToFloat(objDT.Rows[0][conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重(字段类型:float,字段长度:8,是否可空:True)
 objSenateGaugeItemsEN.AnswerModeId = objDT.Rows[0][conSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objSenateGaugeItemsEN.AnswerTypeId = objDT.Rows[0][conSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objSenateGaugeItemsEN.GridTitle = objDT.Rows[0][conSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objSenateGaugeItemsEN.QuestionIndex = TransNullToInt(objDT.Rows[0][conSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objSenateGaugeItemsEN.QuestionNo = objDT.Rows[0][conSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objSenateGaugeItemsEN.QuestionTypeId = objDT.Rows[0][conSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objSenateGaugeItemsEN.IsHaveAdditionalMemo = TransNullToBool(objDT.Rows[0][conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明(字段类型:bit,字段长度:1,是否可空:True)
 objSenateGaugeItemsEN.UpdDate = objDT.Rows[0][conSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSenateGaugeItemsEN.UpdUserId = objDT.Rows[0][conSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSenateGaugeItemsEN.senateGaugeItemMemo = objDT.Rows[0][conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSenateGaugeItemsDA: GetSenateGaugeItems)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdSenateGaugeItem">表关键字</param>
 /// <returns>表对象</returns>
public clsSenateGaugeItemsEN GetObjByIdSenateGaugeItem(string strIdSenateGaugeItem)
{
CheckPrimaryKey(strIdSenateGaugeItem);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeItems where IdSenateGaugeItem = " + "'"+ strIdSenateGaugeItem+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN();
try
{
 objSenateGaugeItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeItemsEN.senateGaugeItemID = objRow[conSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID(字段类型:char,字段长度:4,是否可空:True)
 objSenateGaugeItemsEN.senateGaugeItemName = objRow[conSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称(字段类型:varchar,字段长度:200,是否可空:True)
 objSenateGaugeItemsEN.senateGaugeItemDesc = objRow[conSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objSenateGaugeItemsEN.senateGaugeItemWeight = objRow[conSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重(字段类型:float,字段长度:8,是否可空:True)
 objSenateGaugeItemsEN.AnswerModeId = objRow[conSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objSenateGaugeItemsEN.AnswerTypeId = objRow[conSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objSenateGaugeItemsEN.GridTitle = objRow[conSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objSenateGaugeItemsEN.QuestionIndex = Int32.Parse(objRow[conSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objSenateGaugeItemsEN.QuestionNo = objRow[conSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objSenateGaugeItemsEN.QuestionTypeId = objRow[conSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明(字段类型:bit,字段长度:1,是否可空:True)
 objSenateGaugeItemsEN.UpdDate = objRow[conSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSenateGaugeItemsEN.UpdUserId = objRow[conSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSenateGaugeItemsEN.senateGaugeItemMemo = objRow[conSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSenateGaugeItemsDA: GetObjByIdSenateGaugeItem)", objException.Message));
}
return objSenateGaugeItemsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSenateGaugeItemsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSenateGaugeItemsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN()
{
IdSenateGaugeItem = objRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(), //量表指标流水号
IdSenateGaugeVersion = objRow[conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeItemID = objRow[conSenateGaugeItems.senateGaugeItemID].ToString().Trim(), //量表指标ID
senateGaugeItemName = objRow[conSenateGaugeItems.senateGaugeItemName].ToString().Trim(), //量表指标名称
senateGaugeItemDesc = objRow[conSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(), //量表指标说明
senateGaugeItemWeight = objRow[conSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()), //量表指标权重
AnswerModeId = objRow[conSenateGaugeItems.AnswerModeId].ToString().Trim(), //答案模式Id
AnswerTypeId = objRow[conSenateGaugeItems.AnswerTypeId].ToString().Trim(), //答案类型ID
GridTitle = objRow[conSenateGaugeItems.GridTitle].ToString().Trim(), //表格标题
QuestionIndex = TransNullToInt(objRow[conSenateGaugeItems.QuestionIndex].ToString().Trim()), //题目序号
QuestionNo = objRow[conSenateGaugeItems.QuestionNo].ToString().Trim(), //题目编号
QuestionTypeId = objRow[conSenateGaugeItems.QuestionTypeId].ToString().Trim(), //题目类型Id
IsHaveAdditionalMemo = TransNullToBool(objRow[conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()), //是否有附加说明
UpdDate = objRow[conSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdUserId].ToString().Trim(), //修改用户Id
senateGaugeItemMemo = objRow[conSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim() //备注
};
objSenateGaugeItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSenateGaugeItemsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSenateGaugeItemsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSenateGaugeItemsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN();
try
{
objSenateGaugeItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeItemsEN.senateGaugeItemID = objRow[conSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objSenateGaugeItemsEN.senateGaugeItemName = objRow[conSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objSenateGaugeItemsEN.senateGaugeItemDesc = objRow[conSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objSenateGaugeItemsEN.senateGaugeItemWeight = objRow[conSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objSenateGaugeItemsEN.AnswerModeId = objRow[conSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objSenateGaugeItemsEN.AnswerTypeId = objRow[conSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objSenateGaugeItemsEN.GridTitle = objRow[conSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objSenateGaugeItemsEN.QuestionIndex = TransNullToInt(objRow[conSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objSenateGaugeItemsEN.QuestionNo = objRow[conSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objSenateGaugeItemsEN.QuestionTypeId = objRow[conSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objSenateGaugeItemsEN.IsHaveAdditionalMemo = TransNullToBool(objRow[conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objSenateGaugeItemsEN.UpdDate = objRow[conSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeItemsEN.UpdUserId = objRow[conSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeItemsEN.senateGaugeItemMemo = objRow[conSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSenateGaugeItemsDA: GetObjByDataRowSenateGaugeItems)", objException.Message));
}
objSenateGaugeItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSenateGaugeItemsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSenateGaugeItemsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN();
try
{
objSenateGaugeItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeItemsEN.senateGaugeItemID = objRow[conSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objSenateGaugeItemsEN.senateGaugeItemName = objRow[conSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objSenateGaugeItemsEN.senateGaugeItemDesc = objRow[conSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objSenateGaugeItemsEN.senateGaugeItemWeight = objRow[conSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objSenateGaugeItemsEN.AnswerModeId = objRow[conSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objSenateGaugeItemsEN.AnswerTypeId = objRow[conSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objSenateGaugeItemsEN.GridTitle = objRow[conSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objSenateGaugeItemsEN.QuestionIndex = TransNullToInt(objRow[conSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objSenateGaugeItemsEN.QuestionNo = objRow[conSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objSenateGaugeItemsEN.QuestionTypeId = objRow[conSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objSenateGaugeItemsEN.IsHaveAdditionalMemo = TransNullToBool(objRow[conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objSenateGaugeItemsEN.UpdDate = objRow[conSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeItemsEN.UpdUserId = objRow[conSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeItemsEN.senateGaugeItemMemo = objRow[conSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSenateGaugeItemsDA: GetObjByDataRow)", objException.Message));
}
objSenateGaugeItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSenateGaugeItemsEN;
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
objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSenateGaugeItemsEN._CurrTabName, conSenateGaugeItems.IdSenateGaugeItem, 4, "");
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
objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSenateGaugeItemsEN._CurrTabName, conSenateGaugeItems.IdSenateGaugeItem, 4, strPrefix);
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
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdSenateGaugeItem from SenateGaugeItems where " + strCondition;
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
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdSenateGaugeItem from SenateGaugeItems where " + strCondition;
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
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SenateGaugeItems", "IdSenateGaugeItem = " + "'"+ strIdSenateGaugeItem+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSenateGaugeItemsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SenateGaugeItems", strCondition))
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
objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SenateGaugeItems");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
 {
 objSenateGaugeItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeItemsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeItemsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeItems where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SenateGaugeItems");
objRow = objDS.Tables["SenateGaugeItems"].NewRow();
objRow[conSenateGaugeItems.IdSenateGaugeItem] = objSenateGaugeItemsEN.IdSenateGaugeItem; //量表指标流水号
objRow[conSenateGaugeItems.IdSenateGaugeVersion] = objSenateGaugeItemsEN.IdSenateGaugeVersion; //评价量表版本流水号
objRow[conSenateGaugeItems.senateGaugeItemID] = objSenateGaugeItemsEN.senateGaugeItemID; //量表指标ID
objRow[conSenateGaugeItems.senateGaugeItemName] = objSenateGaugeItemsEN.senateGaugeItemName; //量表指标名称
 if (objSenateGaugeItemsEN.senateGaugeItemDesc !=  "")
 {
objRow[conSenateGaugeItems.senateGaugeItemDesc] = objSenateGaugeItemsEN.senateGaugeItemDesc; //量表指标说明
 }
objRow[conSenateGaugeItems.senateGaugeItemWeight] = objSenateGaugeItemsEN.senateGaugeItemWeight; //量表指标权重
objRow[conSenateGaugeItems.AnswerModeId] = objSenateGaugeItemsEN.AnswerModeId; //答案模式Id
objRow[conSenateGaugeItems.AnswerTypeId] = objSenateGaugeItemsEN.AnswerTypeId; //答案类型ID
objRow[conSenateGaugeItems.GridTitle] = objSenateGaugeItemsEN.GridTitle; //表格标题
objRow[conSenateGaugeItems.QuestionIndex] = objSenateGaugeItemsEN.QuestionIndex; //题目序号
objRow[conSenateGaugeItems.QuestionNo] = objSenateGaugeItemsEN.QuestionNo; //题目编号
objRow[conSenateGaugeItems.QuestionTypeId] = objSenateGaugeItemsEN.QuestionTypeId; //题目类型Id
objRow[conSenateGaugeItems.IsHaveAdditionalMemo] = objSenateGaugeItemsEN.IsHaveAdditionalMemo; //是否有附加说明
 if (objSenateGaugeItemsEN.UpdDate !=  "")
 {
objRow[conSenateGaugeItems.UpdDate] = objSenateGaugeItemsEN.UpdDate; //修改日期
 }
 if (objSenateGaugeItemsEN.UpdUserId !=  "")
 {
objRow[conSenateGaugeItems.UpdUserId] = objSenateGaugeItemsEN.UpdUserId; //修改用户Id
 }
 if (objSenateGaugeItemsEN.senateGaugeItemMemo !=  "")
 {
objRow[conSenateGaugeItems.senateGaugeItemMemo] = objSenateGaugeItemsEN.senateGaugeItemMemo; //备注
 }
objDS.Tables[clsSenateGaugeItemsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSenateGaugeItemsEN._CurrTabName);
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
 /// <param name = "objSenateGaugeItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
 objSenateGaugeItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeItemsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeItemsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSenateGaugeItemsEN.IdSenateGaugeItem !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.IdSenateGaugeItem);
 var strIdSenateGaugeItem = objSenateGaugeItemsEN.IdSenateGaugeItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeItem + "'");
 }
 
 if (objSenateGaugeItemsEN.IdSenateGaugeVersion  ==  "")
 {
 objSenateGaugeItemsEN.IdSenateGaugeVersion = null;
 }
 if (objSenateGaugeItemsEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objSenateGaugeItemsEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemID !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemID);
 var strsenateGaugeItemID = objSenateGaugeItemsEN.senateGaugeItemID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeItemID + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemName !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemName);
 var strsenateGaugeItemName = objSenateGaugeItemsEN.senateGaugeItemName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeItemName + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemDesc !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemDesc);
 var strsenateGaugeItemDesc = objSenateGaugeItemsEN.senateGaugeItemDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeItemDesc + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemWeight !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemWeight);
 arrValueListForInsert.Add(objSenateGaugeItemsEN.senateGaugeItemWeight.ToString());
 }
 
 if (objSenateGaugeItemsEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.AnswerModeId);
 var strAnswerModeId = objSenateGaugeItemsEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objSenateGaugeItemsEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.AnswerTypeId);
 var strAnswerTypeId = objSenateGaugeItemsEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objSenateGaugeItemsEN.GridTitle !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.GridTitle);
 var strGridTitle = objSenateGaugeItemsEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGridTitle + "'");
 }
 
 arrFieldListForInsert.Add(conSenateGaugeItems.QuestionIndex);
 arrValueListForInsert.Add(objSenateGaugeItemsEN.QuestionIndex.ToString());
 
 if (objSenateGaugeItemsEN.QuestionNo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.QuestionNo);
 var strQuestionNo = objSenateGaugeItemsEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNo + "'");
 }
 
 if (objSenateGaugeItemsEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.QuestionTypeId);
 var strQuestionTypeId = objSenateGaugeItemsEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conSenateGaugeItems.IsHaveAdditionalMemo);
 arrValueListForInsert.Add("'" + (objSenateGaugeItemsEN.IsHaveAdditionalMemo  ==  false ? "0" : "1") + "'");
 
 if (objSenateGaugeItemsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.UpdDate);
 var strUpdDate = objSenateGaugeItemsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSenateGaugeItemsEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.UpdUserId);
 var strUpdUserId = objSenateGaugeItemsEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemMemo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemMemo);
 var strsenateGaugeItemMemo = objSenateGaugeItemsEN.senateGaugeItemMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeItemMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SenateGaugeItems");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
 objSenateGaugeItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeItemsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeItemsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSenateGaugeItemsEN.IdSenateGaugeItem !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.IdSenateGaugeItem);
 var strIdSenateGaugeItem = objSenateGaugeItemsEN.IdSenateGaugeItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeItem + "'");
 }
 
 if (objSenateGaugeItemsEN.IdSenateGaugeVersion  ==  "")
 {
 objSenateGaugeItemsEN.IdSenateGaugeVersion = null;
 }
 if (objSenateGaugeItemsEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objSenateGaugeItemsEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemID !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemID);
 var strsenateGaugeItemID = objSenateGaugeItemsEN.senateGaugeItemID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeItemID + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemName !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemName);
 var strsenateGaugeItemName = objSenateGaugeItemsEN.senateGaugeItemName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeItemName + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemDesc !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemDesc);
 var strsenateGaugeItemDesc = objSenateGaugeItemsEN.senateGaugeItemDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeItemDesc + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemWeight !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemWeight);
 arrValueListForInsert.Add(objSenateGaugeItemsEN.senateGaugeItemWeight.ToString());
 }
 
 if (objSenateGaugeItemsEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.AnswerModeId);
 var strAnswerModeId = objSenateGaugeItemsEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objSenateGaugeItemsEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.AnswerTypeId);
 var strAnswerTypeId = objSenateGaugeItemsEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objSenateGaugeItemsEN.GridTitle !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.GridTitle);
 var strGridTitle = objSenateGaugeItemsEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGridTitle + "'");
 }
 
 arrFieldListForInsert.Add(conSenateGaugeItems.QuestionIndex);
 arrValueListForInsert.Add(objSenateGaugeItemsEN.QuestionIndex.ToString());
 
 if (objSenateGaugeItemsEN.QuestionNo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.QuestionNo);
 var strQuestionNo = objSenateGaugeItemsEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNo + "'");
 }
 
 if (objSenateGaugeItemsEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.QuestionTypeId);
 var strQuestionTypeId = objSenateGaugeItemsEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conSenateGaugeItems.IsHaveAdditionalMemo);
 arrValueListForInsert.Add("'" + (objSenateGaugeItemsEN.IsHaveAdditionalMemo  ==  false ? "0" : "1") + "'");
 
 if (objSenateGaugeItemsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.UpdDate);
 var strUpdDate = objSenateGaugeItemsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSenateGaugeItemsEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.UpdUserId);
 var strUpdUserId = objSenateGaugeItemsEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemMemo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemMemo);
 var strsenateGaugeItemMemo = objSenateGaugeItemsEN.senateGaugeItemMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeItemMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SenateGaugeItems");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objSenateGaugeItemsEN.IdSenateGaugeItem;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSenateGaugeItemsEN objSenateGaugeItemsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSenateGaugeItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeItemsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeItemsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSenateGaugeItemsEN.IdSenateGaugeItem !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.IdSenateGaugeItem);
 var strIdSenateGaugeItem = objSenateGaugeItemsEN.IdSenateGaugeItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeItem + "'");
 }
 
 if (objSenateGaugeItemsEN.IdSenateGaugeVersion  ==  "")
 {
 objSenateGaugeItemsEN.IdSenateGaugeVersion = null;
 }
 if (objSenateGaugeItemsEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objSenateGaugeItemsEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemID !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemID);
 var strsenateGaugeItemID = objSenateGaugeItemsEN.senateGaugeItemID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeItemID + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemName !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemName);
 var strsenateGaugeItemName = objSenateGaugeItemsEN.senateGaugeItemName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeItemName + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemDesc !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemDesc);
 var strsenateGaugeItemDesc = objSenateGaugeItemsEN.senateGaugeItemDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeItemDesc + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemWeight !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemWeight);
 arrValueListForInsert.Add(objSenateGaugeItemsEN.senateGaugeItemWeight.ToString());
 }
 
 if (objSenateGaugeItemsEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.AnswerModeId);
 var strAnswerModeId = objSenateGaugeItemsEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objSenateGaugeItemsEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.AnswerTypeId);
 var strAnswerTypeId = objSenateGaugeItemsEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objSenateGaugeItemsEN.GridTitle !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.GridTitle);
 var strGridTitle = objSenateGaugeItemsEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGridTitle + "'");
 }
 
 arrFieldListForInsert.Add(conSenateGaugeItems.QuestionIndex);
 arrValueListForInsert.Add(objSenateGaugeItemsEN.QuestionIndex.ToString());
 
 if (objSenateGaugeItemsEN.QuestionNo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.QuestionNo);
 var strQuestionNo = objSenateGaugeItemsEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNo + "'");
 }
 
 if (objSenateGaugeItemsEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.QuestionTypeId);
 var strQuestionTypeId = objSenateGaugeItemsEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conSenateGaugeItems.IsHaveAdditionalMemo);
 arrValueListForInsert.Add("'" + (objSenateGaugeItemsEN.IsHaveAdditionalMemo  ==  false ? "0" : "1") + "'");
 
 if (objSenateGaugeItemsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.UpdDate);
 var strUpdDate = objSenateGaugeItemsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSenateGaugeItemsEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.UpdUserId);
 var strUpdUserId = objSenateGaugeItemsEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemMemo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemMemo);
 var strsenateGaugeItemMemo = objSenateGaugeItemsEN.senateGaugeItemMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeItemMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SenateGaugeItems");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objSenateGaugeItemsEN.IdSenateGaugeItem;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSenateGaugeItemsEN objSenateGaugeItemsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSenateGaugeItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeItemsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeItemsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSenateGaugeItemsEN.IdSenateGaugeItem !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.IdSenateGaugeItem);
 var strIdSenateGaugeItem = objSenateGaugeItemsEN.IdSenateGaugeItem.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeItem + "'");
 }
 
 if (objSenateGaugeItemsEN.IdSenateGaugeVersion  ==  "")
 {
 objSenateGaugeItemsEN.IdSenateGaugeVersion = null;
 }
 if (objSenateGaugeItemsEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objSenateGaugeItemsEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemID !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemID);
 var strsenateGaugeItemID = objSenateGaugeItemsEN.senateGaugeItemID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeItemID + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemName !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemName);
 var strsenateGaugeItemName = objSenateGaugeItemsEN.senateGaugeItemName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeItemName + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemDesc !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemDesc);
 var strsenateGaugeItemDesc = objSenateGaugeItemsEN.senateGaugeItemDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeItemDesc + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemWeight !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemWeight);
 arrValueListForInsert.Add(objSenateGaugeItemsEN.senateGaugeItemWeight.ToString());
 }
 
 if (objSenateGaugeItemsEN.AnswerModeId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.AnswerModeId);
 var strAnswerModeId = objSenateGaugeItemsEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerModeId + "'");
 }
 
 if (objSenateGaugeItemsEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.AnswerTypeId);
 var strAnswerTypeId = objSenateGaugeItemsEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objSenateGaugeItemsEN.GridTitle !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.GridTitle);
 var strGridTitle = objSenateGaugeItemsEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGridTitle + "'");
 }
 
 arrFieldListForInsert.Add(conSenateGaugeItems.QuestionIndex);
 arrValueListForInsert.Add(objSenateGaugeItemsEN.QuestionIndex.ToString());
 
 if (objSenateGaugeItemsEN.QuestionNo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.QuestionNo);
 var strQuestionNo = objSenateGaugeItemsEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionNo + "'");
 }
 
 if (objSenateGaugeItemsEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.QuestionTypeId);
 var strQuestionTypeId = objSenateGaugeItemsEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conSenateGaugeItems.IsHaveAdditionalMemo);
 arrValueListForInsert.Add("'" + (objSenateGaugeItemsEN.IsHaveAdditionalMemo  ==  false ? "0" : "1") + "'");
 
 if (objSenateGaugeItemsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.UpdDate);
 var strUpdDate = objSenateGaugeItemsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSenateGaugeItemsEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.UpdUserId);
 var strUpdUserId = objSenateGaugeItemsEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSenateGaugeItemsEN.senateGaugeItemMemo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeItems.senateGaugeItemMemo);
 var strsenateGaugeItemMemo = objSenateGaugeItemsEN.senateGaugeItemMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeItemMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SenateGaugeItems");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSenateGaugeItemss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeItems where IdSenateGaugeItem = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SenateGaugeItems");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdSenateGaugeItem = oRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim();
if (IsExist(strIdSenateGaugeItem))
{
 string strResult = "关键字变量值为:" + string.Format("IdSenateGaugeItem = {0}", strIdSenateGaugeItem) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSenateGaugeItemsEN._CurrTabName ].NewRow();
objRow[conSenateGaugeItems.IdSenateGaugeItem] = oRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objRow[conSenateGaugeItems.IdSenateGaugeVersion] = oRow[conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objRow[conSenateGaugeItems.senateGaugeItemID] = oRow[conSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objRow[conSenateGaugeItems.senateGaugeItemName] = oRow[conSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objRow[conSenateGaugeItems.senateGaugeItemDesc] = oRow[conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objRow[conSenateGaugeItems.senateGaugeItemWeight] = oRow[conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim(); //量表指标权重
objRow[conSenateGaugeItems.AnswerModeId] = oRow[conSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objRow[conSenateGaugeItems.AnswerTypeId] = oRow[conSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objRow[conSenateGaugeItems.GridTitle] = oRow[conSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objRow[conSenateGaugeItems.QuestionIndex] = oRow[conSenateGaugeItems.QuestionIndex].ToString().Trim(); //题目序号
objRow[conSenateGaugeItems.QuestionNo] = oRow[conSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objRow[conSenateGaugeItems.QuestionTypeId] = oRow[conSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objRow[conSenateGaugeItems.IsHaveAdditionalMemo] = oRow[conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim(); //是否有附加说明
objRow[conSenateGaugeItems.UpdDate] = oRow[conSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objRow[conSenateGaugeItems.UpdUserId] = oRow[conSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conSenateGaugeItems.senateGaugeItemMemo] = oRow[conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
 objDS.Tables[clsSenateGaugeItemsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSenateGaugeItemsEN._CurrTabName);
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
 /// <param name = "objSenateGaugeItemsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
 objSenateGaugeItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeItemsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeItemsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeItems where IdSenateGaugeItem = " + "'"+ objSenateGaugeItemsEN.IdSenateGaugeItem+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSenateGaugeItemsEN._CurrTabName);
if (objDS.Tables[clsSenateGaugeItemsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdSenateGaugeItem = " + "'"+ objSenateGaugeItemsEN.IdSenateGaugeItem+"'");
return false;
}
objRow = objDS.Tables[clsSenateGaugeItemsEN._CurrTabName].Rows[0];
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.IdSenateGaugeItem))
 {
objRow[conSenateGaugeItems.IdSenateGaugeItem] = objSenateGaugeItemsEN.IdSenateGaugeItem; //量表指标流水号
 }
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.IdSenateGaugeVersion))
 {
objRow[conSenateGaugeItems.IdSenateGaugeVersion] = objSenateGaugeItemsEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemID))
 {
objRow[conSenateGaugeItems.senateGaugeItemID] = objSenateGaugeItemsEN.senateGaugeItemID; //量表指标ID
 }
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemName))
 {
objRow[conSenateGaugeItems.senateGaugeItemName] = objSenateGaugeItemsEN.senateGaugeItemName; //量表指标名称
 }
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemDesc))
 {
objRow[conSenateGaugeItems.senateGaugeItemDesc] = objSenateGaugeItemsEN.senateGaugeItemDesc; //量表指标说明
 }
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemWeight))
 {
objRow[conSenateGaugeItems.senateGaugeItemWeight] = objSenateGaugeItemsEN.senateGaugeItemWeight; //量表指标权重
 }
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.AnswerModeId))
 {
objRow[conSenateGaugeItems.AnswerModeId] = objSenateGaugeItemsEN.AnswerModeId; //答案模式Id
 }
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.AnswerTypeId))
 {
objRow[conSenateGaugeItems.AnswerTypeId] = objSenateGaugeItemsEN.AnswerTypeId; //答案类型ID
 }
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.GridTitle))
 {
objRow[conSenateGaugeItems.GridTitle] = objSenateGaugeItemsEN.GridTitle; //表格标题
 }
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.QuestionIndex))
 {
objRow[conSenateGaugeItems.QuestionIndex] = objSenateGaugeItemsEN.QuestionIndex; //题目序号
 }
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.QuestionNo))
 {
objRow[conSenateGaugeItems.QuestionNo] = objSenateGaugeItemsEN.QuestionNo; //题目编号
 }
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.QuestionTypeId))
 {
objRow[conSenateGaugeItems.QuestionTypeId] = objSenateGaugeItemsEN.QuestionTypeId; //题目类型Id
 }
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.IsHaveAdditionalMemo))
 {
objRow[conSenateGaugeItems.IsHaveAdditionalMemo] = objSenateGaugeItemsEN.IsHaveAdditionalMemo; //是否有附加说明
 }
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.UpdDate))
 {
objRow[conSenateGaugeItems.UpdDate] = objSenateGaugeItemsEN.UpdDate; //修改日期
 }
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.UpdUserId))
 {
objRow[conSenateGaugeItems.UpdUserId] = objSenateGaugeItemsEN.UpdUserId; //修改用户Id
 }
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemMemo))
 {
objRow[conSenateGaugeItems.senateGaugeItemMemo] = objSenateGaugeItemsEN.senateGaugeItemMemo; //备注
 }
try
{
objDA.Update(objDS, clsSenateGaugeItemsEN._CurrTabName);
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
 /// <param name = "objSenateGaugeItemsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
 objSenateGaugeItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeItemsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeItemsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SenateGaugeItems Set ");
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.IdSenateGaugeVersion))
 {
 if (objSenateGaugeItemsEN.IdSenateGaugeVersion  ==  "")
 {
 objSenateGaugeItemsEN.IdSenateGaugeVersion = null;
 }
 if (objSenateGaugeItemsEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objSenateGaugeItemsEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conSenateGaugeItems.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemID))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemID !=  null)
 {
 var strsenateGaugeItemID = objSenateGaugeItemsEN.senateGaugeItemID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeItemID, conSenateGaugeItems.senateGaugeItemID); //量表指标ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.senateGaugeItemID); //量表指标ID
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemName))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemName !=  null)
 {
 var strsenateGaugeItemName = objSenateGaugeItemsEN.senateGaugeItemName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeItemName, conSenateGaugeItems.senateGaugeItemName); //量表指标名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.senateGaugeItemName); //量表指标名称
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemDesc))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemDesc !=  null)
 {
 var strsenateGaugeItemDesc = objSenateGaugeItemsEN.senateGaugeItemDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeItemDesc, conSenateGaugeItems.senateGaugeItemDesc); //量表指标说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.senateGaugeItemDesc); //量表指标说明
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemWeight))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemWeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeItemsEN.senateGaugeItemWeight, conSenateGaugeItems.senateGaugeItemWeight); //量表指标权重
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.senateGaugeItemWeight); //量表指标权重
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.AnswerModeId))
 {
 if (objSenateGaugeItemsEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objSenateGaugeItemsEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerModeId, conSenateGaugeItems.AnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.AnswerModeId); //答案模式Id
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.AnswerTypeId))
 {
 if (objSenateGaugeItemsEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objSenateGaugeItemsEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTypeId, conSenateGaugeItems.AnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.AnswerTypeId); //答案类型ID
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.GridTitle))
 {
 if (objSenateGaugeItemsEN.GridTitle !=  null)
 {
 var strGridTitle = objSenateGaugeItemsEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGridTitle, conSenateGaugeItems.GridTitle); //表格标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.GridTitle); //表格标题
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.QuestionIndex))
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeItemsEN.QuestionIndex, conSenateGaugeItems.QuestionIndex); //题目序号
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.QuestionNo))
 {
 if (objSenateGaugeItemsEN.QuestionNo !=  null)
 {
 var strQuestionNo = objSenateGaugeItemsEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionNo, conSenateGaugeItems.QuestionNo); //题目编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.QuestionNo); //题目编号
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.QuestionTypeId))
 {
 if (objSenateGaugeItemsEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objSenateGaugeItemsEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionTypeId, conSenateGaugeItems.QuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.QuestionTypeId); //题目类型Id
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.IsHaveAdditionalMemo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSenateGaugeItemsEN.IsHaveAdditionalMemo == true?"1":"0", conSenateGaugeItems.IsHaveAdditionalMemo); //是否有附加说明
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.UpdDate))
 {
 if (objSenateGaugeItemsEN.UpdDate !=  null)
 {
 var strUpdDate = objSenateGaugeItemsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSenateGaugeItems.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.UpdDate); //修改日期
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.UpdUserId))
 {
 if (objSenateGaugeItemsEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSenateGaugeItemsEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSenateGaugeItems.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.UpdUserId); //修改用户Id
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemMemo))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemMemo !=  null)
 {
 var strsenateGaugeItemMemo = objSenateGaugeItemsEN.senateGaugeItemMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeItemMemo, conSenateGaugeItems.senateGaugeItemMemo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.senateGaugeItemMemo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdSenateGaugeItem = '{0}'", objSenateGaugeItemsEN.IdSenateGaugeItem); 
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
 /// <param name = "objSenateGaugeItemsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strCondition)
{
 objSenateGaugeItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeItemsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeItemsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SenateGaugeItems Set ");
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.IdSenateGaugeVersion))
 {
 if (objSenateGaugeItemsEN.IdSenateGaugeVersion  ==  "")
 {
 objSenateGaugeItemsEN.IdSenateGaugeVersion = null;
 }
 if (objSenateGaugeItemsEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objSenateGaugeItemsEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemID))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemID !=  null)
 {
 var strsenateGaugeItemID = objSenateGaugeItemsEN.senateGaugeItemID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeItemID = '{0}',", strsenateGaugeItemID); //量表指标ID
 }
 else
 {
 sbSQL.Append(" senateGaugeItemID = null,"); //量表指标ID
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemName))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemName !=  null)
 {
 var strsenateGaugeItemName = objSenateGaugeItemsEN.senateGaugeItemName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeItemName = '{0}',", strsenateGaugeItemName); //量表指标名称
 }
 else
 {
 sbSQL.Append(" senateGaugeItemName = null,"); //量表指标名称
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemDesc))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemDesc !=  null)
 {
 var strsenateGaugeItemDesc = objSenateGaugeItemsEN.senateGaugeItemDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeItemDesc = '{0}',", strsenateGaugeItemDesc); //量表指标说明
 }
 else
 {
 sbSQL.Append(" senateGaugeItemDesc = null,"); //量表指标说明
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemWeight))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemWeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeItemsEN.senateGaugeItemWeight, conSenateGaugeItems.senateGaugeItemWeight); //量表指标权重
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.senateGaugeItemWeight); //量表指标权重
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.AnswerModeId))
 {
 if (objSenateGaugeItemsEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objSenateGaugeItemsEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerModeId = '{0}',", strAnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.Append(" AnswerModeId = null,"); //答案模式Id
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.AnswerTypeId))
 {
 if (objSenateGaugeItemsEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objSenateGaugeItemsEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTypeId = '{0}',", strAnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.Append(" AnswerTypeId = null,"); //答案类型ID
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.GridTitle))
 {
 if (objSenateGaugeItemsEN.GridTitle !=  null)
 {
 var strGridTitle = objSenateGaugeItemsEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GridTitle = '{0}',", strGridTitle); //表格标题
 }
 else
 {
 sbSQL.Append(" GridTitle = null,"); //表格标题
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.QuestionIndex))
 {
 sbSQL.AppendFormat(" QuestionIndex = {0},", objSenateGaugeItemsEN.QuestionIndex); //题目序号
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.QuestionNo))
 {
 if (objSenateGaugeItemsEN.QuestionNo !=  null)
 {
 var strQuestionNo = objSenateGaugeItemsEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionNo = '{0}',", strQuestionNo); //题目编号
 }
 else
 {
 sbSQL.Append(" QuestionNo = null,"); //题目编号
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.QuestionTypeId))
 {
 if (objSenateGaugeItemsEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objSenateGaugeItemsEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionTypeId = '{0}',", strQuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.Append(" QuestionTypeId = null,"); //题目类型Id
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.IsHaveAdditionalMemo))
 {
 sbSQL.AppendFormat(" IsHaveAdditionalMemo = '{0}',", objSenateGaugeItemsEN.IsHaveAdditionalMemo == true?"1":"0"); //是否有附加说明
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.UpdDate))
 {
 if (objSenateGaugeItemsEN.UpdDate !=  null)
 {
 var strUpdDate = objSenateGaugeItemsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.UpdUserId))
 {
 if (objSenateGaugeItemsEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSenateGaugeItemsEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemMemo))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemMemo !=  null)
 {
 var strsenateGaugeItemMemo = objSenateGaugeItemsEN.senateGaugeItemMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeItemMemo = '{0}',", strsenateGaugeItemMemo); //备注
 }
 else
 {
 sbSQL.Append(" senateGaugeItemMemo = null,"); //备注
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
 /// <param name = "objSenateGaugeItemsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSenateGaugeItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeItemsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeItemsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SenateGaugeItems Set ");
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.IdSenateGaugeVersion))
 {
 if (objSenateGaugeItemsEN.IdSenateGaugeVersion  ==  "")
 {
 objSenateGaugeItemsEN.IdSenateGaugeVersion = null;
 }
 if (objSenateGaugeItemsEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objSenateGaugeItemsEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemID))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemID !=  null)
 {
 var strsenateGaugeItemID = objSenateGaugeItemsEN.senateGaugeItemID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeItemID = '{0}',", strsenateGaugeItemID); //量表指标ID
 }
 else
 {
 sbSQL.Append(" senateGaugeItemID = null,"); //量表指标ID
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemName))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemName !=  null)
 {
 var strsenateGaugeItemName = objSenateGaugeItemsEN.senateGaugeItemName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeItemName = '{0}',", strsenateGaugeItemName); //量表指标名称
 }
 else
 {
 sbSQL.Append(" senateGaugeItemName = null,"); //量表指标名称
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemDesc))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemDesc !=  null)
 {
 var strsenateGaugeItemDesc = objSenateGaugeItemsEN.senateGaugeItemDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeItemDesc = '{0}',", strsenateGaugeItemDesc); //量表指标说明
 }
 else
 {
 sbSQL.Append(" senateGaugeItemDesc = null,"); //量表指标说明
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemWeight))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemWeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeItemsEN.senateGaugeItemWeight, conSenateGaugeItems.senateGaugeItemWeight); //量表指标权重
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.senateGaugeItemWeight); //量表指标权重
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.AnswerModeId))
 {
 if (objSenateGaugeItemsEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objSenateGaugeItemsEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerModeId = '{0}',", strAnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.Append(" AnswerModeId = null,"); //答案模式Id
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.AnswerTypeId))
 {
 if (objSenateGaugeItemsEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objSenateGaugeItemsEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTypeId = '{0}',", strAnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.Append(" AnswerTypeId = null,"); //答案类型ID
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.GridTitle))
 {
 if (objSenateGaugeItemsEN.GridTitle !=  null)
 {
 var strGridTitle = objSenateGaugeItemsEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GridTitle = '{0}',", strGridTitle); //表格标题
 }
 else
 {
 sbSQL.Append(" GridTitle = null,"); //表格标题
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.QuestionIndex))
 {
 sbSQL.AppendFormat(" QuestionIndex = {0},", objSenateGaugeItemsEN.QuestionIndex); //题目序号
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.QuestionNo))
 {
 if (objSenateGaugeItemsEN.QuestionNo !=  null)
 {
 var strQuestionNo = objSenateGaugeItemsEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionNo = '{0}',", strQuestionNo); //题目编号
 }
 else
 {
 sbSQL.Append(" QuestionNo = null,"); //题目编号
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.QuestionTypeId))
 {
 if (objSenateGaugeItemsEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objSenateGaugeItemsEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionTypeId = '{0}',", strQuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.Append(" QuestionTypeId = null,"); //题目类型Id
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.IsHaveAdditionalMemo))
 {
 sbSQL.AppendFormat(" IsHaveAdditionalMemo = '{0}',", objSenateGaugeItemsEN.IsHaveAdditionalMemo == true?"1":"0"); //是否有附加说明
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.UpdDate))
 {
 if (objSenateGaugeItemsEN.UpdDate !=  null)
 {
 var strUpdDate = objSenateGaugeItemsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.UpdUserId))
 {
 if (objSenateGaugeItemsEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSenateGaugeItemsEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemMemo))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemMemo !=  null)
 {
 var strsenateGaugeItemMemo = objSenateGaugeItemsEN.senateGaugeItemMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeItemMemo = '{0}',", strsenateGaugeItemMemo); //备注
 }
 else
 {
 sbSQL.Append(" senateGaugeItemMemo = null,"); //备注
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
 /// <param name = "objSenateGaugeItemsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSenateGaugeItemsEN objSenateGaugeItemsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSenateGaugeItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeItemsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeItemsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SenateGaugeItems Set ");
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.IdSenateGaugeVersion))
 {
 if (objSenateGaugeItemsEN.IdSenateGaugeVersion  ==  "")
 {
 objSenateGaugeItemsEN.IdSenateGaugeVersion = null;
 }
 if (objSenateGaugeItemsEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objSenateGaugeItemsEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conSenateGaugeItems.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemID))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemID !=  null)
 {
 var strsenateGaugeItemID = objSenateGaugeItemsEN.senateGaugeItemID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeItemID, conSenateGaugeItems.senateGaugeItemID); //量表指标ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.senateGaugeItemID); //量表指标ID
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemName))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemName !=  null)
 {
 var strsenateGaugeItemName = objSenateGaugeItemsEN.senateGaugeItemName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeItemName, conSenateGaugeItems.senateGaugeItemName); //量表指标名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.senateGaugeItemName); //量表指标名称
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemDesc))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemDesc !=  null)
 {
 var strsenateGaugeItemDesc = objSenateGaugeItemsEN.senateGaugeItemDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeItemDesc, conSenateGaugeItems.senateGaugeItemDesc); //量表指标说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.senateGaugeItemDesc); //量表指标说明
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemWeight))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemWeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeItemsEN.senateGaugeItemWeight, conSenateGaugeItems.senateGaugeItemWeight); //量表指标权重
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.senateGaugeItemWeight); //量表指标权重
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.AnswerModeId))
 {
 if (objSenateGaugeItemsEN.AnswerModeId !=  null)
 {
 var strAnswerModeId = objSenateGaugeItemsEN.AnswerModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerModeId, conSenateGaugeItems.AnswerModeId); //答案模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.AnswerModeId); //答案模式Id
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.AnswerTypeId))
 {
 if (objSenateGaugeItemsEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objSenateGaugeItemsEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTypeId, conSenateGaugeItems.AnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.AnswerTypeId); //答案类型ID
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.GridTitle))
 {
 if (objSenateGaugeItemsEN.GridTitle !=  null)
 {
 var strGridTitle = objSenateGaugeItemsEN.GridTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGridTitle, conSenateGaugeItems.GridTitle); //表格标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.GridTitle); //表格标题
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.QuestionIndex))
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeItemsEN.QuestionIndex, conSenateGaugeItems.QuestionIndex); //题目序号
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.QuestionNo))
 {
 if (objSenateGaugeItemsEN.QuestionNo !=  null)
 {
 var strQuestionNo = objSenateGaugeItemsEN.QuestionNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionNo, conSenateGaugeItems.QuestionNo); //题目编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.QuestionNo); //题目编号
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.QuestionTypeId))
 {
 if (objSenateGaugeItemsEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objSenateGaugeItemsEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionTypeId, conSenateGaugeItems.QuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.QuestionTypeId); //题目类型Id
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.IsHaveAdditionalMemo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSenateGaugeItemsEN.IsHaveAdditionalMemo == true?"1":"0", conSenateGaugeItems.IsHaveAdditionalMemo); //是否有附加说明
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.UpdDate))
 {
 if (objSenateGaugeItemsEN.UpdDate !=  null)
 {
 var strUpdDate = objSenateGaugeItemsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSenateGaugeItems.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.UpdDate); //修改日期
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.UpdUserId))
 {
 if (objSenateGaugeItemsEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSenateGaugeItemsEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSenateGaugeItems.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.UpdUserId); //修改用户Id
 }
 }
 
 if (objSenateGaugeItemsEN.IsUpdated(conSenateGaugeItems.senateGaugeItemMemo))
 {
 if (objSenateGaugeItemsEN.senateGaugeItemMemo !=  null)
 {
 var strsenateGaugeItemMemo = objSenateGaugeItemsEN.senateGaugeItemMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeItemMemo, conSenateGaugeItems.senateGaugeItemMemo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeItems.senateGaugeItemMemo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdSenateGaugeItem = '{0}'", objSenateGaugeItemsEN.IdSenateGaugeItem); 
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
 /// <param name = "strIdSenateGaugeItem">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdSenateGaugeItem) 
{
CheckPrimaryKey(strIdSenateGaugeItem);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdSenateGaugeItem,
};
 objSQL.ExecSP("SenateGaugeItems_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdSenateGaugeItem">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdSenateGaugeItem, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdSenateGaugeItem);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
//删除SenateGaugeItems本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SenateGaugeItems where IdSenateGaugeItem = " + "'"+ strIdSenateGaugeItem+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSenateGaugeItems(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
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
//删除SenateGaugeItems本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SenateGaugeItems where IdSenateGaugeItem in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdSenateGaugeItem">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdSenateGaugeItem) 
{
CheckPrimaryKey(strIdSenateGaugeItem);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
//删除SenateGaugeItems本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SenateGaugeItems where IdSenateGaugeItem = " + "'"+ strIdSenateGaugeItem+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSenateGaugeItems(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSenateGaugeItemsDA: DelSenateGaugeItems)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SenateGaugeItems where " + strCondition ;
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
public bool DelSenateGaugeItemsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSenateGaugeItemsDA: DelSenateGaugeItemsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SenateGaugeItems where " + strCondition ;
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
 /// <param name = "objSenateGaugeItemsENS">源对象</param>
 /// <param name = "objSenateGaugeItemsENT">目标对象</param>
public void CopyTo(clsSenateGaugeItemsEN objSenateGaugeItemsENS, clsSenateGaugeItemsEN objSenateGaugeItemsENT)
{
objSenateGaugeItemsENT.IdSenateGaugeItem = objSenateGaugeItemsENS.IdSenateGaugeItem; //量表指标流水号
objSenateGaugeItemsENT.IdSenateGaugeVersion = objSenateGaugeItemsENS.IdSenateGaugeVersion; //评价量表版本流水号
objSenateGaugeItemsENT.senateGaugeItemID = objSenateGaugeItemsENS.senateGaugeItemID; //量表指标ID
objSenateGaugeItemsENT.senateGaugeItemName = objSenateGaugeItemsENS.senateGaugeItemName; //量表指标名称
objSenateGaugeItemsENT.senateGaugeItemDesc = objSenateGaugeItemsENS.senateGaugeItemDesc; //量表指标说明
objSenateGaugeItemsENT.senateGaugeItemWeight = objSenateGaugeItemsENS.senateGaugeItemWeight; //量表指标权重
objSenateGaugeItemsENT.AnswerModeId = objSenateGaugeItemsENS.AnswerModeId; //答案模式Id
objSenateGaugeItemsENT.AnswerTypeId = objSenateGaugeItemsENS.AnswerTypeId; //答案类型ID
objSenateGaugeItemsENT.GridTitle = objSenateGaugeItemsENS.GridTitle; //表格标题
objSenateGaugeItemsENT.QuestionIndex = objSenateGaugeItemsENS.QuestionIndex; //题目序号
objSenateGaugeItemsENT.QuestionNo = objSenateGaugeItemsENS.QuestionNo; //题目编号
objSenateGaugeItemsENT.QuestionTypeId = objSenateGaugeItemsENS.QuestionTypeId; //题目类型Id
objSenateGaugeItemsENT.IsHaveAdditionalMemo = objSenateGaugeItemsENS.IsHaveAdditionalMemo; //是否有附加说明
objSenateGaugeItemsENT.UpdDate = objSenateGaugeItemsENS.UpdDate; //修改日期
objSenateGaugeItemsENT.UpdUserId = objSenateGaugeItemsENS.UpdUserId; //修改用户Id
objSenateGaugeItemsENT.senateGaugeItemMemo = objSenateGaugeItemsENS.senateGaugeItemMemo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objSenateGaugeItemsEN.IdSenateGaugeVersion, conSenateGaugeItems.IdSenateGaugeVersion);
clsCheckSql.CheckFieldNotNull(objSenateGaugeItemsEN.senateGaugeItemID, conSenateGaugeItems.senateGaugeItemID);
clsCheckSql.CheckFieldNotNull(objSenateGaugeItemsEN.senateGaugeItemName, conSenateGaugeItems.senateGaugeItemName);
clsCheckSql.CheckFieldNotNull(objSenateGaugeItemsEN.AnswerModeId, conSenateGaugeItems.AnswerModeId);
clsCheckSql.CheckFieldNotNull(objSenateGaugeItemsEN.AnswerTypeId, conSenateGaugeItems.AnswerTypeId);
clsCheckSql.CheckFieldNotNull(objSenateGaugeItemsEN.GridTitle, conSenateGaugeItems.GridTitle);
clsCheckSql.CheckFieldNotNull(objSenateGaugeItemsEN.QuestionIndex, conSenateGaugeItems.QuestionIndex);
clsCheckSql.CheckFieldNotNull(objSenateGaugeItemsEN.QuestionNo, conSenateGaugeItems.QuestionNo);
clsCheckSql.CheckFieldNotNull(objSenateGaugeItemsEN.QuestionTypeId, conSenateGaugeItems.QuestionTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.IdSenateGaugeItem, 4, conSenateGaugeItems.IdSenateGaugeItem);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.IdSenateGaugeVersion, 4, conSenateGaugeItems.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.senateGaugeItemID, 4, conSenateGaugeItems.senateGaugeItemID);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.senateGaugeItemName, 200, conSenateGaugeItems.senateGaugeItemName);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.senateGaugeItemDesc, 2000, conSenateGaugeItems.senateGaugeItemDesc);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.AnswerModeId, 4, conSenateGaugeItems.AnswerModeId);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.AnswerTypeId, 2, conSenateGaugeItems.AnswerTypeId);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.GridTitle, 30, conSenateGaugeItems.GridTitle);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.QuestionNo, 10, conSenateGaugeItems.QuestionNo);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.QuestionTypeId, 2, conSenateGaugeItems.QuestionTypeId);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.UpdDate, 20, conSenateGaugeItems.UpdDate);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.UpdUserId, 20, conSenateGaugeItems.UpdUserId);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.senateGaugeItemMemo, 1000, conSenateGaugeItems.senateGaugeItemMemo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objSenateGaugeItemsEN.IdSenateGaugeVersion, 4, conSenateGaugeItems.IdSenateGaugeVersion);
 objSenateGaugeItemsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.IdSenateGaugeVersion, 4, conSenateGaugeItems.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.senateGaugeItemID, 4, conSenateGaugeItems.senateGaugeItemID);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.senateGaugeItemName, 200, conSenateGaugeItems.senateGaugeItemName);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.senateGaugeItemDesc, 2000, conSenateGaugeItems.senateGaugeItemDesc);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.AnswerModeId, 4, conSenateGaugeItems.AnswerModeId);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.AnswerTypeId, 2, conSenateGaugeItems.AnswerTypeId);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.GridTitle, 30, conSenateGaugeItems.GridTitle);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.QuestionNo, 10, conSenateGaugeItems.QuestionNo);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.QuestionTypeId, 2, conSenateGaugeItems.QuestionTypeId);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.UpdDate, 20, conSenateGaugeItems.UpdDate);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.UpdUserId, 20, conSenateGaugeItems.UpdUserId);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.senateGaugeItemMemo, 1000, conSenateGaugeItems.senateGaugeItemMemo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objSenateGaugeItemsEN.IdSenateGaugeVersion, 4, conSenateGaugeItems.IdSenateGaugeVersion);
 objSenateGaugeItemsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.IdSenateGaugeItem, 4, conSenateGaugeItems.IdSenateGaugeItem);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.IdSenateGaugeVersion, 4, conSenateGaugeItems.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.senateGaugeItemID, 4, conSenateGaugeItems.senateGaugeItemID);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.senateGaugeItemName, 200, conSenateGaugeItems.senateGaugeItemName);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.senateGaugeItemDesc, 2000, conSenateGaugeItems.senateGaugeItemDesc);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.AnswerModeId, 4, conSenateGaugeItems.AnswerModeId);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.AnswerTypeId, 2, conSenateGaugeItems.AnswerTypeId);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.GridTitle, 30, conSenateGaugeItems.GridTitle);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.QuestionNo, 10, conSenateGaugeItems.QuestionNo);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.QuestionTypeId, 2, conSenateGaugeItems.QuestionTypeId);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.UpdDate, 20, conSenateGaugeItems.UpdDate);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.UpdUserId, 20, conSenateGaugeItems.UpdUserId);
clsCheckSql.CheckFieldLen(objSenateGaugeItemsEN.senateGaugeItemMemo, 1000, conSenateGaugeItems.senateGaugeItemMemo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeItemsEN.IdSenateGaugeItem, conSenateGaugeItems.IdSenateGaugeItem);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeItemsEN.IdSenateGaugeVersion, conSenateGaugeItems.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeItemsEN.senateGaugeItemID, conSenateGaugeItems.senateGaugeItemID);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeItemsEN.senateGaugeItemName, conSenateGaugeItems.senateGaugeItemName);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeItemsEN.senateGaugeItemDesc, conSenateGaugeItems.senateGaugeItemDesc);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeItemsEN.AnswerModeId, conSenateGaugeItems.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeItemsEN.AnswerTypeId, conSenateGaugeItems.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeItemsEN.GridTitle, conSenateGaugeItems.GridTitle);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeItemsEN.QuestionNo, conSenateGaugeItems.QuestionNo);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeItemsEN.QuestionTypeId, conSenateGaugeItems.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeItemsEN.UpdDate, conSenateGaugeItems.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeItemsEN.UpdUserId, conSenateGaugeItems.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeItemsEN.senateGaugeItemMemo, conSenateGaugeItems.senateGaugeItemMemo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objSenateGaugeItemsEN.IdSenateGaugeVersion, 4, conSenateGaugeItems.IdSenateGaugeVersion);
 objSenateGaugeItemsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdSenateGaugeItem()
{
//获取某学院所有专业信息
string strSQL = "select IdSenateGaugeItem, senateGaugeItemName from SenateGaugeItems ";
 clsSpecSQLforSql mySql = clsSenateGaugeItemsDA.GetSpecSQLObj();
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
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
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
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
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
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSenateGaugeItemsEN._CurrTabName);
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
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSenateGaugeItemsEN._CurrTabName, strCondition);
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
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
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
 objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}