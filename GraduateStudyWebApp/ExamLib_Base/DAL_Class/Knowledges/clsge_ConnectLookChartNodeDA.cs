
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_ConnectLookChartNodeDA
 表名:ge_ConnectLookChartNode(01120917)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 连连看图节点(ge_ConnectLookChartNode)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsge_ConnectLookChartNodeDA : clsCommBase4DA
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
 return clsge_ConnectLookChartNodeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsge_ConnectLookChartNodeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_ConnectLookChartNodeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsge_ConnectLookChartNodeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsge_ConnectLookChartNodeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strConnectLookNodeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strConnectLookNodeId)
{
strConnectLookNodeId = strConnectLookNodeId.Replace("'", "''");
if (strConnectLookNodeId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:ge_ConnectLookChartNode中,检查关键字,长度不正确!(clsge_ConnectLookChartNodeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strConnectLookNodeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ge_ConnectLookChartNode中,关键字不能为空 或 null!(clsge_ConnectLookChartNodeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strConnectLookNodeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsge_ConnectLookChartNodeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_ConnectLookChartNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_ConnectLookChartNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ge_ConnectLookChartNode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsge_ConnectLookChartNodeDA: GetDataTable_ge_ConnectLookChartNode)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_ConnectLookChartNode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsge_ConnectLookChartNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsge_ConnectLookChartNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_ConnectLookChartNode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsge_ConnectLookChartNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsge_ConnectLookChartNodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_ConnectLookChartNode where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_ConnectLookChartNode where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsge_ConnectLookChartNodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ge_ConnectLookChartNode where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsge_ConnectLookChartNodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_ConnectLookChartNode.* from ge_ConnectLookChartNode Left Join {1} on {2} where {3} and ge_ConnectLookChartNode.ConnectLookNodeId not in (Select top {5} ge_ConnectLookChartNode.ConnectLookNodeId from ge_ConnectLookChartNode Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_ConnectLookChartNode where {1} and ConnectLookNodeId not in (Select top {2} ConnectLookNodeId from ge_ConnectLookChartNode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_ConnectLookChartNode where {1} and ConnectLookNodeId not in (Select top {3} ConnectLookNodeId from ge_ConnectLookChartNode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsge_ConnectLookChartNodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_ConnectLookChartNode.* from ge_ConnectLookChartNode Left Join {1} on {2} where {3} and ge_ConnectLookChartNode.ConnectLookNodeId not in (Select top {5} ge_ConnectLookChartNode.ConnectLookNodeId from ge_ConnectLookChartNode Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_ConnectLookChartNode where {1} and ConnectLookNodeId not in (Select top {2} ConnectLookNodeId from ge_ConnectLookChartNode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_ConnectLookChartNode where {1} and ConnectLookNodeId not in (Select top {3} ConnectLookNodeId from ge_ConnectLookChartNode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsge_ConnectLookChartNodeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsge_ConnectLookChartNodeDA:GetObjLst)", objException.Message));
}
List<clsge_ConnectLookChartNodeEN> arrObjLst = new List<clsge_ConnectLookChartNodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_ConnectLookChartNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = new clsge_ConnectLookChartNodeEN();
try
{
objge_ConnectLookChartNodeEN.ConnectLookNodeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(); //连连看节点Id
objge_ConnectLookChartNodeEN.ConnectLookNodeName = objRow[conge_ConnectLookChartNode.ConnectLookNodeName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(); //连连看节点名称
objge_ConnectLookChartNodeEN.ConnectLookChartId = objRow[conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartNodeEN.XPosition = objRow[conge_ConnectLookChartNode.XPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conge_ConnectLookChartNode.XPosition].ToString().Trim()); //X_坐标
objge_ConnectLookChartNodeEN.YPosition = objRow[conge_ConnectLookChartNode.YPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conge_ConnectLookChartNode.YPosition].ToString().Trim()); //Y_坐标
objge_ConnectLookChartNodeEN.LogicNodeId = objRow[conge_ConnectLookChartNode.LogicNodeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(); //逻辑节点Id
objge_ConnectLookChartNodeEN.ClassName = objRow[conge_ConnectLookChartNode.ClassName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ClassName].ToString().Trim(); //样式名称
objge_ConnectLookChartNodeEN.UpdDate = objRow[conge_ConnectLookChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartNodeEN.UpdUser = objRow[conge_ConnectLookChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartNodeEN.Memo = objRow[conge_ConnectLookChartNode.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.Memo].ToString().Trim(); //备注
objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim(); //连连看节点类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_ConnectLookChartNodeDA: GetObjLst)", objException.Message));
}
objge_ConnectLookChartNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_ConnectLookChartNodeEN);
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
public List<clsge_ConnectLookChartNodeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsge_ConnectLookChartNodeDA:GetObjLstByTabName)", objException.Message));
}
List<clsge_ConnectLookChartNodeEN> arrObjLst = new List<clsge_ConnectLookChartNodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = new clsge_ConnectLookChartNodeEN();
try
{
objge_ConnectLookChartNodeEN.ConnectLookNodeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(); //连连看节点Id
objge_ConnectLookChartNodeEN.ConnectLookNodeName = objRow[conge_ConnectLookChartNode.ConnectLookNodeName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(); //连连看节点名称
objge_ConnectLookChartNodeEN.ConnectLookChartId = objRow[conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartNodeEN.XPosition = objRow[conge_ConnectLookChartNode.XPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conge_ConnectLookChartNode.XPosition].ToString().Trim()); //X_坐标
objge_ConnectLookChartNodeEN.YPosition = objRow[conge_ConnectLookChartNode.YPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conge_ConnectLookChartNode.YPosition].ToString().Trim()); //Y_坐标
objge_ConnectLookChartNodeEN.LogicNodeId = objRow[conge_ConnectLookChartNode.LogicNodeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(); //逻辑节点Id
objge_ConnectLookChartNodeEN.ClassName = objRow[conge_ConnectLookChartNode.ClassName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ClassName].ToString().Trim(); //样式名称
objge_ConnectLookChartNodeEN.UpdDate = objRow[conge_ConnectLookChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartNodeEN.UpdUser = objRow[conge_ConnectLookChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartNodeEN.Memo = objRow[conge_ConnectLookChartNode.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.Memo].ToString().Trim(); //备注
objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim(); //连连看节点类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_ConnectLookChartNodeDA: GetObjLst)", objException.Message));
}
objge_ConnectLookChartNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_ConnectLookChartNodeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getge_ConnectLookChartNode(ref clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_ConnectLookChartNode where ConnectLookNodeId = " + "'"+ objge_ConnectLookChartNodeEN.ConnectLookNodeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objge_ConnectLookChartNodeEN.ConnectLookNodeId = objDT.Rows[0][conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(); //连连看节点Id(字段类型:char,字段长度:10,是否可空:True)
 objge_ConnectLookChartNodeEN.ConnectLookNodeName = objDT.Rows[0][conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(); //连连看节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objge_ConnectLookChartNodeEN.ConnectLookChartId = objDT.Rows[0][conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(); //连连看图Id(字段类型:char,字段长度:10,是否可空:True)
 objge_ConnectLookChartNodeEN.XPosition = TransNullToFloat(objDT.Rows[0][conge_ConnectLookChartNode.XPosition].ToString().Trim()); //X_坐标(字段类型:float,字段长度:8,是否可空:True)
 objge_ConnectLookChartNodeEN.YPosition = TransNullToFloat(objDT.Rows[0][conge_ConnectLookChartNode.YPosition].ToString().Trim()); //Y_坐标(字段类型:float,字段长度:8,是否可空:True)
 objge_ConnectLookChartNodeEN.LogicNodeId = objDT.Rows[0][conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(); //逻辑节点Id(字段类型:varchar,字段长度:20,是否可空:True)
 objge_ConnectLookChartNodeEN.ClassName = objDT.Rows[0][conge_ConnectLookChartNode.ClassName].ToString().Trim(); //样式名称(字段类型:varchar,字段长度:100,是否可空:True)
 objge_ConnectLookChartNodeEN.UpdDate = objDT.Rows[0][conge_ConnectLookChartNode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_ConnectLookChartNodeEN.UpdUser = objDT.Rows[0][conge_ConnectLookChartNode.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_ConnectLookChartNodeEN.Memo = objDT.Rows[0][conge_ConnectLookChartNode.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = objDT.Rows[0][conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim(); //连连看节点类型(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsge_ConnectLookChartNodeDA: Getge_ConnectLookChartNode)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strConnectLookNodeId">表关键字</param>
 /// <returns>表对象</returns>
public clsge_ConnectLookChartNodeEN GetObjByConnectLookNodeId(string strConnectLookNodeId)
{
CheckPrimaryKey(strConnectLookNodeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_ConnectLookChartNode where ConnectLookNodeId = " + "'"+ strConnectLookNodeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = new clsge_ConnectLookChartNodeEN();
try
{
 objge_ConnectLookChartNodeEN.ConnectLookNodeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(); //连连看节点Id(字段类型:char,字段长度:10,是否可空:True)
 objge_ConnectLookChartNodeEN.ConnectLookNodeName = objRow[conge_ConnectLookChartNode.ConnectLookNodeName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(); //连连看节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objge_ConnectLookChartNodeEN.ConnectLookChartId = objRow[conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(); //连连看图Id(字段类型:char,字段长度:10,是否可空:True)
 objge_ConnectLookChartNodeEN.XPosition = objRow[conge_ConnectLookChartNode.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.XPosition].ToString().Trim()); //X_坐标(字段类型:float,字段长度:8,是否可空:True)
 objge_ConnectLookChartNodeEN.YPosition = objRow[conge_ConnectLookChartNode.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.YPosition].ToString().Trim()); //Y_坐标(字段类型:float,字段长度:8,是否可空:True)
 objge_ConnectLookChartNodeEN.LogicNodeId = objRow[conge_ConnectLookChartNode.LogicNodeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(); //逻辑节点Id(字段类型:varchar,字段长度:20,是否可空:True)
 objge_ConnectLookChartNodeEN.ClassName = objRow[conge_ConnectLookChartNode.ClassName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ClassName].ToString().Trim(); //样式名称(字段类型:varchar,字段长度:100,是否可空:True)
 objge_ConnectLookChartNodeEN.UpdDate = objRow[conge_ConnectLookChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_ConnectLookChartNodeEN.UpdUser = objRow[conge_ConnectLookChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_ConnectLookChartNodeEN.Memo = objRow[conge_ConnectLookChartNode.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim(); //连连看节点类型(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsge_ConnectLookChartNodeDA: GetObjByConnectLookNodeId)", objException.Message));
}
return objge_ConnectLookChartNodeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsge_ConnectLookChartNodeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsge_ConnectLookChartNodeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_ConnectLookChartNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = new clsge_ConnectLookChartNodeEN()
{
ConnectLookNodeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(), //连连看节点Id
ConnectLookNodeName = objRow[conge_ConnectLookChartNode.ConnectLookNodeName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(), //连连看节点名称
ConnectLookChartId = objRow[conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(), //连连看图Id
XPosition = objRow[conge_ConnectLookChartNode.XPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conge_ConnectLookChartNode.XPosition].ToString().Trim()), //X_坐标
YPosition = objRow[conge_ConnectLookChartNode.YPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conge_ConnectLookChartNode.YPosition].ToString().Trim()), //Y_坐标
LogicNodeId = objRow[conge_ConnectLookChartNode.LogicNodeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(), //逻辑节点Id
ClassName = objRow[conge_ConnectLookChartNode.ClassName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ClassName].ToString().Trim(), //样式名称
UpdDate = objRow[conge_ConnectLookChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conge_ConnectLookChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conge_ConnectLookChartNode.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.Memo].ToString().Trim(), //备注
ConnectLookNodeTypeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim() //连连看节点类型
};
objge_ConnectLookChartNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_ConnectLookChartNodeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsge_ConnectLookChartNodeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsge_ConnectLookChartNodeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = new clsge_ConnectLookChartNodeEN();
try
{
objge_ConnectLookChartNodeEN.ConnectLookNodeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(); //连连看节点Id
objge_ConnectLookChartNodeEN.ConnectLookNodeName = objRow[conge_ConnectLookChartNode.ConnectLookNodeName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(); //连连看节点名称
objge_ConnectLookChartNodeEN.ConnectLookChartId = objRow[conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartNodeEN.XPosition = objRow[conge_ConnectLookChartNode.XPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conge_ConnectLookChartNode.XPosition].ToString().Trim()); //X_坐标
objge_ConnectLookChartNodeEN.YPosition = objRow[conge_ConnectLookChartNode.YPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conge_ConnectLookChartNode.YPosition].ToString().Trim()); //Y_坐标
objge_ConnectLookChartNodeEN.LogicNodeId = objRow[conge_ConnectLookChartNode.LogicNodeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(); //逻辑节点Id
objge_ConnectLookChartNodeEN.ClassName = objRow[conge_ConnectLookChartNode.ClassName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ClassName].ToString().Trim(); //样式名称
objge_ConnectLookChartNodeEN.UpdDate = objRow[conge_ConnectLookChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartNodeEN.UpdUser = objRow[conge_ConnectLookChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartNodeEN.Memo = objRow[conge_ConnectLookChartNode.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.Memo].ToString().Trim(); //备注
objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim(); //连连看节点类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsge_ConnectLookChartNodeDA: GetObjByDataRowge_ConnectLookChartNode)", objException.Message));
}
objge_ConnectLookChartNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_ConnectLookChartNodeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsge_ConnectLookChartNodeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = new clsge_ConnectLookChartNodeEN();
try
{
objge_ConnectLookChartNodeEN.ConnectLookNodeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(); //连连看节点Id
objge_ConnectLookChartNodeEN.ConnectLookNodeName = objRow[conge_ConnectLookChartNode.ConnectLookNodeName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(); //连连看节点名称
objge_ConnectLookChartNodeEN.ConnectLookChartId = objRow[conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartNodeEN.XPosition = objRow[conge_ConnectLookChartNode.XPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conge_ConnectLookChartNode.XPosition].ToString().Trim()); //X_坐标
objge_ConnectLookChartNodeEN.YPosition = objRow[conge_ConnectLookChartNode.YPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conge_ConnectLookChartNode.YPosition].ToString().Trim()); //Y_坐标
objge_ConnectLookChartNodeEN.LogicNodeId = objRow[conge_ConnectLookChartNode.LogicNodeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(); //逻辑节点Id
objge_ConnectLookChartNodeEN.ClassName = objRow[conge_ConnectLookChartNode.ClassName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ClassName].ToString().Trim(); //样式名称
objge_ConnectLookChartNodeEN.UpdDate = objRow[conge_ConnectLookChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartNodeEN.UpdUser = objRow[conge_ConnectLookChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartNodeEN.Memo = objRow[conge_ConnectLookChartNode.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.Memo].ToString().Trim(); //备注
objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim(); //连连看节点类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsge_ConnectLookChartNodeDA: GetObjByDataRow)", objException.Message));
}
objge_ConnectLookChartNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_ConnectLookChartNodeEN;
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
objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_ConnectLookChartNodeEN._CurrTabName, conge_ConnectLookChartNode.ConnectLookNodeId, 10, "");
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
objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_ConnectLookChartNodeEN._CurrTabName, conge_ConnectLookChartNode.ConnectLookNodeId, 10, strPrefix);
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
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ConnectLookNodeId from ge_ConnectLookChartNode where " + strCondition;
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
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ConnectLookNodeId from ge_ConnectLookChartNode where " + strCondition;
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
 /// <param name = "strConnectLookNodeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strConnectLookNodeId)
{
CheckPrimaryKey(strConnectLookNodeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_ConnectLookChartNode", "ConnectLookNodeId = " + "'"+ strConnectLookNodeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsge_ConnectLookChartNodeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_ConnectLookChartNode", strCondition))
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
objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ge_ConnectLookChartNode");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
 {
 if (objge_ConnectLookChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_ConnectLookChartNodeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_ConnectLookChartNode where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_ConnectLookChartNode");
objRow = objDS.Tables["ge_ConnectLookChartNode"].NewRow();
objRow[conge_ConnectLookChartNode.ConnectLookNodeId] = objge_ConnectLookChartNodeEN.ConnectLookNodeId; //连连看节点Id
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeName !=  "")
 {
objRow[conge_ConnectLookChartNode.ConnectLookNodeName] = objge_ConnectLookChartNodeEN.ConnectLookNodeName; //连连看节点名称
 }
objRow[conge_ConnectLookChartNode.ConnectLookChartId] = objge_ConnectLookChartNodeEN.ConnectLookChartId; //连连看图Id
objRow[conge_ConnectLookChartNode.XPosition] = objge_ConnectLookChartNodeEN.XPosition; //X_坐标
objRow[conge_ConnectLookChartNode.YPosition] = objge_ConnectLookChartNodeEN.YPosition; //Y_坐标
 if (objge_ConnectLookChartNodeEN.LogicNodeId !=  "")
 {
objRow[conge_ConnectLookChartNode.LogicNodeId] = objge_ConnectLookChartNodeEN.LogicNodeId; //逻辑节点Id
 }
 if (objge_ConnectLookChartNodeEN.ClassName !=  "")
 {
objRow[conge_ConnectLookChartNode.ClassName] = objge_ConnectLookChartNodeEN.ClassName; //样式名称
 }
 if (objge_ConnectLookChartNodeEN.UpdDate !=  "")
 {
objRow[conge_ConnectLookChartNode.UpdDate] = objge_ConnectLookChartNodeEN.UpdDate; //修改日期
 }
 if (objge_ConnectLookChartNodeEN.UpdUser !=  "")
 {
objRow[conge_ConnectLookChartNode.UpdUser] = objge_ConnectLookChartNodeEN.UpdUser; //修改人
 }
 if (objge_ConnectLookChartNodeEN.Memo !=  "")
 {
objRow[conge_ConnectLookChartNode.Memo] = objge_ConnectLookChartNodeEN.Memo; //备注
 }
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId !=  "")
 {
objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] = objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId; //连连看节点类型
 }
objDS.Tables[clsge_ConnectLookChartNodeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsge_ConnectLookChartNodeEN._CurrTabName);
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
 /// <param name = "objge_ConnectLookChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
 if (objge_ConnectLookChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_ConnectLookChartNodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ConnectLookNodeId);
 var strConnectLookNodeId = objge_ConnectLookChartNodeEN.ConnectLookNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectLookNodeId + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeName !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ConnectLookNodeName);
 var strConnectLookNodeName = objge_ConnectLookChartNodeEN.ConnectLookNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectLookNodeName + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.ConnectLookChartId !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ConnectLookChartId);
 var strConnectLookChartId = objge_ConnectLookChartNodeEN.ConnectLookChartId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectLookChartId + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.XPosition !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.XPosition);
 arrValueListForInsert.Add(objge_ConnectLookChartNodeEN.XPosition.ToString());
 }
 
 if (objge_ConnectLookChartNodeEN.YPosition !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.YPosition);
 arrValueListForInsert.Add(objge_ConnectLookChartNodeEN.YPosition.ToString());
 }
 
 if (objge_ConnectLookChartNodeEN.LogicNodeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.LogicNodeId);
 var strLogicNodeId = objge_ConnectLookChartNodeEN.LogicNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogicNodeId + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.ClassName !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ClassName);
 var strClassName = objge_ConnectLookChartNodeEN.ClassName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassName + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.UpdDate);
 var strUpdDate = objge_ConnectLookChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.UpdUser);
 var strUpdUser = objge_ConnectLookChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.Memo);
 var strMemo = objge_ConnectLookChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ConnectLookNodeTypeId);
 var strConnectLookNodeTypeId = objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectLookNodeTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_ConnectLookChartNode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
 if (objge_ConnectLookChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_ConnectLookChartNodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ConnectLookNodeId);
 var strConnectLookNodeId = objge_ConnectLookChartNodeEN.ConnectLookNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectLookNodeId + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeName !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ConnectLookNodeName);
 var strConnectLookNodeName = objge_ConnectLookChartNodeEN.ConnectLookNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectLookNodeName + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.ConnectLookChartId !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ConnectLookChartId);
 var strConnectLookChartId = objge_ConnectLookChartNodeEN.ConnectLookChartId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectLookChartId + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.XPosition !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.XPosition);
 arrValueListForInsert.Add(objge_ConnectLookChartNodeEN.XPosition.ToString());
 }
 
 if (objge_ConnectLookChartNodeEN.YPosition !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.YPosition);
 arrValueListForInsert.Add(objge_ConnectLookChartNodeEN.YPosition.ToString());
 }
 
 if (objge_ConnectLookChartNodeEN.LogicNodeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.LogicNodeId);
 var strLogicNodeId = objge_ConnectLookChartNodeEN.LogicNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogicNodeId + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.ClassName !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ClassName);
 var strClassName = objge_ConnectLookChartNodeEN.ClassName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassName + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.UpdDate);
 var strUpdDate = objge_ConnectLookChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.UpdUser);
 var strUpdUser = objge_ConnectLookChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.Memo);
 var strMemo = objge_ConnectLookChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ConnectLookNodeTypeId);
 var strConnectLookNodeTypeId = objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectLookNodeTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_ConnectLookChartNode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objge_ConnectLookChartNodeEN.ConnectLookNodeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_ConnectLookChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_ConnectLookChartNodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ConnectLookNodeId);
 var strConnectLookNodeId = objge_ConnectLookChartNodeEN.ConnectLookNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectLookNodeId + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeName !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ConnectLookNodeName);
 var strConnectLookNodeName = objge_ConnectLookChartNodeEN.ConnectLookNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectLookNodeName + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.ConnectLookChartId !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ConnectLookChartId);
 var strConnectLookChartId = objge_ConnectLookChartNodeEN.ConnectLookChartId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectLookChartId + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.XPosition !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.XPosition);
 arrValueListForInsert.Add(objge_ConnectLookChartNodeEN.XPosition.ToString());
 }
 
 if (objge_ConnectLookChartNodeEN.YPosition !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.YPosition);
 arrValueListForInsert.Add(objge_ConnectLookChartNodeEN.YPosition.ToString());
 }
 
 if (objge_ConnectLookChartNodeEN.LogicNodeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.LogicNodeId);
 var strLogicNodeId = objge_ConnectLookChartNodeEN.LogicNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogicNodeId + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.ClassName !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ClassName);
 var strClassName = objge_ConnectLookChartNodeEN.ClassName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassName + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.UpdDate);
 var strUpdDate = objge_ConnectLookChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.UpdUser);
 var strUpdUser = objge_ConnectLookChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.Memo);
 var strMemo = objge_ConnectLookChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ConnectLookNodeTypeId);
 var strConnectLookNodeTypeId = objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectLookNodeTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_ConnectLookChartNode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objge_ConnectLookChartNodeEN.ConnectLookNodeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objge_ConnectLookChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_ConnectLookChartNodeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ConnectLookNodeId);
 var strConnectLookNodeId = objge_ConnectLookChartNodeEN.ConnectLookNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectLookNodeId + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeName !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ConnectLookNodeName);
 var strConnectLookNodeName = objge_ConnectLookChartNodeEN.ConnectLookNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectLookNodeName + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.ConnectLookChartId !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ConnectLookChartId);
 var strConnectLookChartId = objge_ConnectLookChartNodeEN.ConnectLookChartId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectLookChartId + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.XPosition !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.XPosition);
 arrValueListForInsert.Add(objge_ConnectLookChartNodeEN.XPosition.ToString());
 }
 
 if (objge_ConnectLookChartNodeEN.YPosition !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.YPosition);
 arrValueListForInsert.Add(objge_ConnectLookChartNodeEN.YPosition.ToString());
 }
 
 if (objge_ConnectLookChartNodeEN.LogicNodeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.LogicNodeId);
 var strLogicNodeId = objge_ConnectLookChartNodeEN.LogicNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogicNodeId + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.ClassName !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ClassName);
 var strClassName = objge_ConnectLookChartNodeEN.ClassName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassName + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.UpdDate);
 var strUpdDate = objge_ConnectLookChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.UpdUser);
 var strUpdUser = objge_ConnectLookChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.Memo);
 var strMemo = objge_ConnectLookChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ConnectLookChartNode.ConnectLookNodeTypeId);
 var strConnectLookNodeTypeId = objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConnectLookNodeTypeId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_ConnectLookChartNode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewge_ConnectLookChartNodes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_ConnectLookChartNode where ConnectLookNodeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_ConnectLookChartNode");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strConnectLookNodeId = oRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim();
if (IsExist(strConnectLookNodeId))
{
 string strResult = "关键字变量值为:" + string.Format("ConnectLookNodeId = {0}", strConnectLookNodeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsge_ConnectLookChartNodeEN._CurrTabName ].NewRow();
objRow[conge_ConnectLookChartNode.ConnectLookNodeId] = oRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(); //连连看节点Id
objRow[conge_ConnectLookChartNode.ConnectLookNodeName] = oRow[conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(); //连连看节点名称
objRow[conge_ConnectLookChartNode.ConnectLookChartId] = oRow[conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(); //连连看图Id
objRow[conge_ConnectLookChartNode.XPosition] = oRow[conge_ConnectLookChartNode.XPosition].ToString().Trim(); //X_坐标
objRow[conge_ConnectLookChartNode.YPosition] = oRow[conge_ConnectLookChartNode.YPosition].ToString().Trim(); //Y_坐标
objRow[conge_ConnectLookChartNode.LogicNodeId] = oRow[conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(); //逻辑节点Id
objRow[conge_ConnectLookChartNode.ClassName] = oRow[conge_ConnectLookChartNode.ClassName].ToString().Trim(); //样式名称
objRow[conge_ConnectLookChartNode.UpdDate] = oRow[conge_ConnectLookChartNode.UpdDate].ToString().Trim(); //修改日期
objRow[conge_ConnectLookChartNode.UpdUser] = oRow[conge_ConnectLookChartNode.UpdUser].ToString().Trim(); //修改人
objRow[conge_ConnectLookChartNode.Memo] = oRow[conge_ConnectLookChartNode.Memo].ToString().Trim(); //备注
objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] = oRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim(); //连连看节点类型
 objDS.Tables[clsge_ConnectLookChartNodeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsge_ConnectLookChartNodeEN._CurrTabName);
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
 /// <param name = "objge_ConnectLookChartNodeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
 if (objge_ConnectLookChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_ConnectLookChartNodeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_ConnectLookChartNode where ConnectLookNodeId = " + "'"+ objge_ConnectLookChartNodeEN.ConnectLookNodeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsge_ConnectLookChartNodeEN._CurrTabName);
if (objDS.Tables[clsge_ConnectLookChartNodeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ConnectLookNodeId = " + "'"+ objge_ConnectLookChartNodeEN.ConnectLookNodeId+"'");
return false;
}
objRow = objDS.Tables[clsge_ConnectLookChartNodeEN._CurrTabName].Rows[0];
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ConnectLookNodeId))
 {
objRow[conge_ConnectLookChartNode.ConnectLookNodeId] = objge_ConnectLookChartNodeEN.ConnectLookNodeId; //连连看节点Id
 }
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ConnectLookNodeName))
 {
objRow[conge_ConnectLookChartNode.ConnectLookNodeName] = objge_ConnectLookChartNodeEN.ConnectLookNodeName; //连连看节点名称
 }
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ConnectLookChartId))
 {
objRow[conge_ConnectLookChartNode.ConnectLookChartId] = objge_ConnectLookChartNodeEN.ConnectLookChartId; //连连看图Id
 }
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.XPosition))
 {
objRow[conge_ConnectLookChartNode.XPosition] = objge_ConnectLookChartNodeEN.XPosition; //X_坐标
 }
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.YPosition))
 {
objRow[conge_ConnectLookChartNode.YPosition] = objge_ConnectLookChartNodeEN.YPosition; //Y_坐标
 }
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.LogicNodeId))
 {
objRow[conge_ConnectLookChartNode.LogicNodeId] = objge_ConnectLookChartNodeEN.LogicNodeId; //逻辑节点Id
 }
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ClassName))
 {
objRow[conge_ConnectLookChartNode.ClassName] = objge_ConnectLookChartNodeEN.ClassName; //样式名称
 }
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.UpdDate))
 {
objRow[conge_ConnectLookChartNode.UpdDate] = objge_ConnectLookChartNodeEN.UpdDate; //修改日期
 }
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.UpdUser))
 {
objRow[conge_ConnectLookChartNode.UpdUser] = objge_ConnectLookChartNodeEN.UpdUser; //修改人
 }
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.Memo))
 {
objRow[conge_ConnectLookChartNode.Memo] = objge_ConnectLookChartNodeEN.Memo; //备注
 }
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ConnectLookNodeTypeId))
 {
objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] = objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId; //连连看节点类型
 }
try
{
objDA.Update(objDS, clsge_ConnectLookChartNodeEN._CurrTabName);
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
 /// <param name = "objge_ConnectLookChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
 if (objge_ConnectLookChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_ConnectLookChartNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ge_ConnectLookChartNode Set ");
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ConnectLookNodeName))
 {
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeName !=  null)
 {
 var strConnectLookNodeName = objge_ConnectLookChartNodeEN.ConnectLookNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConnectLookNodeName, conge_ConnectLookChartNode.ConnectLookNodeName); //连连看节点名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.ConnectLookNodeName); //连连看节点名称
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ConnectLookChartId))
 {
 if (objge_ConnectLookChartNodeEN.ConnectLookChartId !=  null)
 {
 var strConnectLookChartId = objge_ConnectLookChartNodeEN.ConnectLookChartId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConnectLookChartId, conge_ConnectLookChartNode.ConnectLookChartId); //连连看图Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.ConnectLookChartId); //连连看图Id
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.XPosition))
 {
 if (objge_ConnectLookChartNodeEN.XPosition !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_ConnectLookChartNodeEN.XPosition, conge_ConnectLookChartNode.XPosition); //X_坐标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.XPosition); //X_坐标
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.YPosition))
 {
 if (objge_ConnectLookChartNodeEN.YPosition !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_ConnectLookChartNodeEN.YPosition, conge_ConnectLookChartNode.YPosition); //Y_坐标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.YPosition); //Y_坐标
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.LogicNodeId))
 {
 if (objge_ConnectLookChartNodeEN.LogicNodeId !=  null)
 {
 var strLogicNodeId = objge_ConnectLookChartNodeEN.LogicNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLogicNodeId, conge_ConnectLookChartNode.LogicNodeId); //逻辑节点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.LogicNodeId); //逻辑节点Id
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ClassName))
 {
 if (objge_ConnectLookChartNodeEN.ClassName !=  null)
 {
 var strClassName = objge_ConnectLookChartNodeEN.ClassName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClassName, conge_ConnectLookChartNode.ClassName); //样式名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.ClassName); //样式名称
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.UpdDate))
 {
 if (objge_ConnectLookChartNodeEN.UpdDate !=  null)
 {
 var strUpdDate = objge_ConnectLookChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_ConnectLookChartNode.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.UpdDate); //修改日期
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.UpdUser))
 {
 if (objge_ConnectLookChartNodeEN.UpdUser !=  null)
 {
 var strUpdUser = objge_ConnectLookChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_ConnectLookChartNode.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.UpdUser); //修改人
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.Memo))
 {
 if (objge_ConnectLookChartNodeEN.Memo !=  null)
 {
 var strMemo = objge_ConnectLookChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_ConnectLookChartNode.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.Memo); //备注
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ConnectLookNodeTypeId))
 {
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId !=  null)
 {
 var strConnectLookNodeTypeId = objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConnectLookNodeTypeId, conge_ConnectLookChartNode.ConnectLookNodeTypeId); //连连看节点类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.ConnectLookNodeTypeId); //连连看节点类型
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ConnectLookNodeId = '{0}'", objge_ConnectLookChartNodeEN.ConnectLookNodeId); 
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
 /// <param name = "objge_ConnectLookChartNodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, string strCondition)
{
 if (objge_ConnectLookChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_ConnectLookChartNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_ConnectLookChartNode Set ");
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ConnectLookNodeName))
 {
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeName !=  null)
 {
 var strConnectLookNodeName = objge_ConnectLookChartNodeEN.ConnectLookNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConnectLookNodeName = '{0}',", strConnectLookNodeName); //连连看节点名称
 }
 else
 {
 sbSQL.Append(" ConnectLookNodeName = null,"); //连连看节点名称
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ConnectLookChartId))
 {
 if (objge_ConnectLookChartNodeEN.ConnectLookChartId !=  null)
 {
 var strConnectLookChartId = objge_ConnectLookChartNodeEN.ConnectLookChartId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConnectLookChartId = '{0}',", strConnectLookChartId); //连连看图Id
 }
 else
 {
 sbSQL.Append(" ConnectLookChartId = null,"); //连连看图Id
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.XPosition))
 {
 if (objge_ConnectLookChartNodeEN.XPosition !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_ConnectLookChartNodeEN.XPosition, conge_ConnectLookChartNode.XPosition); //X_坐标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.XPosition); //X_坐标
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.YPosition))
 {
 if (objge_ConnectLookChartNodeEN.YPosition !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_ConnectLookChartNodeEN.YPosition, conge_ConnectLookChartNode.YPosition); //Y_坐标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.YPosition); //Y_坐标
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.LogicNodeId))
 {
 if (objge_ConnectLookChartNodeEN.LogicNodeId !=  null)
 {
 var strLogicNodeId = objge_ConnectLookChartNodeEN.LogicNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LogicNodeId = '{0}',", strLogicNodeId); //逻辑节点Id
 }
 else
 {
 sbSQL.Append(" LogicNodeId = null,"); //逻辑节点Id
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ClassName))
 {
 if (objge_ConnectLookChartNodeEN.ClassName !=  null)
 {
 var strClassName = objge_ConnectLookChartNodeEN.ClassName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassName = '{0}',", strClassName); //样式名称
 }
 else
 {
 sbSQL.Append(" ClassName = null,"); //样式名称
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.UpdDate))
 {
 if (objge_ConnectLookChartNodeEN.UpdDate !=  null)
 {
 var strUpdDate = objge_ConnectLookChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.UpdUser))
 {
 if (objge_ConnectLookChartNodeEN.UpdUser !=  null)
 {
 var strUpdUser = objge_ConnectLookChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.Memo))
 {
 if (objge_ConnectLookChartNodeEN.Memo !=  null)
 {
 var strMemo = objge_ConnectLookChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ConnectLookNodeTypeId))
 {
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId !=  null)
 {
 var strConnectLookNodeTypeId = objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConnectLookNodeTypeId = '{0}',", strConnectLookNodeTypeId); //连连看节点类型
 }
 else
 {
 sbSQL.Append(" ConnectLookNodeTypeId = null,"); //连连看节点类型
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
 /// <param name = "objge_ConnectLookChartNodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_ConnectLookChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_ConnectLookChartNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_ConnectLookChartNode Set ");
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ConnectLookNodeName))
 {
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeName !=  null)
 {
 var strConnectLookNodeName = objge_ConnectLookChartNodeEN.ConnectLookNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConnectLookNodeName = '{0}',", strConnectLookNodeName); //连连看节点名称
 }
 else
 {
 sbSQL.Append(" ConnectLookNodeName = null,"); //连连看节点名称
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ConnectLookChartId))
 {
 if (objge_ConnectLookChartNodeEN.ConnectLookChartId !=  null)
 {
 var strConnectLookChartId = objge_ConnectLookChartNodeEN.ConnectLookChartId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConnectLookChartId = '{0}',", strConnectLookChartId); //连连看图Id
 }
 else
 {
 sbSQL.Append(" ConnectLookChartId = null,"); //连连看图Id
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.XPosition))
 {
 if (objge_ConnectLookChartNodeEN.XPosition !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_ConnectLookChartNodeEN.XPosition, conge_ConnectLookChartNode.XPosition); //X_坐标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.XPosition); //X_坐标
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.YPosition))
 {
 if (objge_ConnectLookChartNodeEN.YPosition !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_ConnectLookChartNodeEN.YPosition, conge_ConnectLookChartNode.YPosition); //Y_坐标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.YPosition); //Y_坐标
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.LogicNodeId))
 {
 if (objge_ConnectLookChartNodeEN.LogicNodeId !=  null)
 {
 var strLogicNodeId = objge_ConnectLookChartNodeEN.LogicNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LogicNodeId = '{0}',", strLogicNodeId); //逻辑节点Id
 }
 else
 {
 sbSQL.Append(" LogicNodeId = null,"); //逻辑节点Id
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ClassName))
 {
 if (objge_ConnectLookChartNodeEN.ClassName !=  null)
 {
 var strClassName = objge_ConnectLookChartNodeEN.ClassName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassName = '{0}',", strClassName); //样式名称
 }
 else
 {
 sbSQL.Append(" ClassName = null,"); //样式名称
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.UpdDate))
 {
 if (objge_ConnectLookChartNodeEN.UpdDate !=  null)
 {
 var strUpdDate = objge_ConnectLookChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.UpdUser))
 {
 if (objge_ConnectLookChartNodeEN.UpdUser !=  null)
 {
 var strUpdUser = objge_ConnectLookChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.Memo))
 {
 if (objge_ConnectLookChartNodeEN.Memo !=  null)
 {
 var strMemo = objge_ConnectLookChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ConnectLookNodeTypeId))
 {
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId !=  null)
 {
 var strConnectLookNodeTypeId = objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConnectLookNodeTypeId = '{0}',", strConnectLookNodeTypeId); //连连看节点类型
 }
 else
 {
 sbSQL.Append(" ConnectLookNodeTypeId = null,"); //连连看节点类型
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
 /// <param name = "objge_ConnectLookChartNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objge_ConnectLookChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_ConnectLookChartNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_ConnectLookChartNode Set ");
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ConnectLookNodeName))
 {
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeName !=  null)
 {
 var strConnectLookNodeName = objge_ConnectLookChartNodeEN.ConnectLookNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConnectLookNodeName, conge_ConnectLookChartNode.ConnectLookNodeName); //连连看节点名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.ConnectLookNodeName); //连连看节点名称
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ConnectLookChartId))
 {
 if (objge_ConnectLookChartNodeEN.ConnectLookChartId !=  null)
 {
 var strConnectLookChartId = objge_ConnectLookChartNodeEN.ConnectLookChartId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConnectLookChartId, conge_ConnectLookChartNode.ConnectLookChartId); //连连看图Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.ConnectLookChartId); //连连看图Id
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.XPosition))
 {
 if (objge_ConnectLookChartNodeEN.XPosition !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_ConnectLookChartNodeEN.XPosition, conge_ConnectLookChartNode.XPosition); //X_坐标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.XPosition); //X_坐标
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.YPosition))
 {
 if (objge_ConnectLookChartNodeEN.YPosition !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_ConnectLookChartNodeEN.YPosition, conge_ConnectLookChartNode.YPosition); //Y_坐标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.YPosition); //Y_坐标
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.LogicNodeId))
 {
 if (objge_ConnectLookChartNodeEN.LogicNodeId !=  null)
 {
 var strLogicNodeId = objge_ConnectLookChartNodeEN.LogicNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLogicNodeId, conge_ConnectLookChartNode.LogicNodeId); //逻辑节点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.LogicNodeId); //逻辑节点Id
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ClassName))
 {
 if (objge_ConnectLookChartNodeEN.ClassName !=  null)
 {
 var strClassName = objge_ConnectLookChartNodeEN.ClassName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClassName, conge_ConnectLookChartNode.ClassName); //样式名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.ClassName); //样式名称
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.UpdDate))
 {
 if (objge_ConnectLookChartNodeEN.UpdDate !=  null)
 {
 var strUpdDate = objge_ConnectLookChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_ConnectLookChartNode.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.UpdDate); //修改日期
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.UpdUser))
 {
 if (objge_ConnectLookChartNodeEN.UpdUser !=  null)
 {
 var strUpdUser = objge_ConnectLookChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_ConnectLookChartNode.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.UpdUser); //修改人
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.Memo))
 {
 if (objge_ConnectLookChartNodeEN.Memo !=  null)
 {
 var strMemo = objge_ConnectLookChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_ConnectLookChartNode.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.Memo); //备注
 }
 }
 
 if (objge_ConnectLookChartNodeEN.IsUpdated(conge_ConnectLookChartNode.ConnectLookNodeTypeId))
 {
 if (objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId !=  null)
 {
 var strConnectLookNodeTypeId = objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConnectLookNodeTypeId, conge_ConnectLookChartNode.ConnectLookNodeTypeId); //连连看节点类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ConnectLookChartNode.ConnectLookNodeTypeId); //连连看节点类型
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ConnectLookNodeId = '{0}'", objge_ConnectLookChartNodeEN.ConnectLookNodeId); 
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
 /// <param name = "strConnectLookNodeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strConnectLookNodeId) 
{
CheckPrimaryKey(strConnectLookNodeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strConnectLookNodeId,
};
 objSQL.ExecSP("ge_ConnectLookChartNode_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strConnectLookNodeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strConnectLookNodeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strConnectLookNodeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
//删除ge_ConnectLookChartNode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_ConnectLookChartNode where ConnectLookNodeId = " + "'"+ strConnectLookNodeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delge_ConnectLookChartNode(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
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
//删除ge_ConnectLookChartNode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_ConnectLookChartNode where ConnectLookNodeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strConnectLookNodeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strConnectLookNodeId) 
{
CheckPrimaryKey(strConnectLookNodeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
//删除ge_ConnectLookChartNode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_ConnectLookChartNode where ConnectLookNodeId = " + "'"+ strConnectLookNodeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delge_ConnectLookChartNode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsge_ConnectLookChartNodeDA: Delge_ConnectLookChartNode)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_ConnectLookChartNode where " + strCondition ;
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
public bool Delge_ConnectLookChartNodeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsge_ConnectLookChartNodeDA: Delge_ConnectLookChartNodeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_ConnectLookChartNode where " + strCondition ;
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
 /// <param name = "objge_ConnectLookChartNodeENS">源对象</param>
 /// <param name = "objge_ConnectLookChartNodeENT">目标对象</param>
public void CopyTo(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeENS, clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeENT)
{
objge_ConnectLookChartNodeENT.ConnectLookNodeId = objge_ConnectLookChartNodeENS.ConnectLookNodeId; //连连看节点Id
objge_ConnectLookChartNodeENT.ConnectLookNodeName = objge_ConnectLookChartNodeENS.ConnectLookNodeName; //连连看节点名称
objge_ConnectLookChartNodeENT.ConnectLookChartId = objge_ConnectLookChartNodeENS.ConnectLookChartId; //连连看图Id
objge_ConnectLookChartNodeENT.XPosition = objge_ConnectLookChartNodeENS.XPosition; //X_坐标
objge_ConnectLookChartNodeENT.YPosition = objge_ConnectLookChartNodeENS.YPosition; //Y_坐标
objge_ConnectLookChartNodeENT.LogicNodeId = objge_ConnectLookChartNodeENS.LogicNodeId; //逻辑节点Id
objge_ConnectLookChartNodeENT.ClassName = objge_ConnectLookChartNodeENS.ClassName; //样式名称
objge_ConnectLookChartNodeENT.UpdDate = objge_ConnectLookChartNodeENS.UpdDate; //修改日期
objge_ConnectLookChartNodeENT.UpdUser = objge_ConnectLookChartNodeENS.UpdUser; //修改人
objge_ConnectLookChartNodeENT.Memo = objge_ConnectLookChartNodeENS.Memo; //备注
objge_ConnectLookChartNodeENT.ConnectLookNodeTypeId = objge_ConnectLookChartNodeENS.ConnectLookNodeTypeId; //连连看节点类型
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objge_ConnectLookChartNodeEN.ConnectLookChartId, conge_ConnectLookChartNode.ConnectLookChartId);
//检查字段长度
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.ConnectLookNodeId, 10, conge_ConnectLookChartNode.ConnectLookNodeId);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.ConnectLookNodeName, 100, conge_ConnectLookChartNode.ConnectLookNodeName);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.ConnectLookChartId, 10, conge_ConnectLookChartNode.ConnectLookChartId);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.LogicNodeId, 20, conge_ConnectLookChartNode.LogicNodeId);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.ClassName, 100, conge_ConnectLookChartNode.ClassName);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.UpdDate, 20, conge_ConnectLookChartNode.UpdDate);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.UpdUser, 20, conge_ConnectLookChartNode.UpdUser);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.Memo, 1000, conge_ConnectLookChartNode.Memo);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId, 2, conge_ConnectLookChartNode.ConnectLookNodeTypeId);
//检查字段外键固定长度
 objge_ConnectLookChartNodeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.ConnectLookNodeName, 100, conge_ConnectLookChartNode.ConnectLookNodeName);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.ConnectLookChartId, 10, conge_ConnectLookChartNode.ConnectLookChartId);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.LogicNodeId, 20, conge_ConnectLookChartNode.LogicNodeId);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.ClassName, 100, conge_ConnectLookChartNode.ClassName);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.UpdDate, 20, conge_ConnectLookChartNode.UpdDate);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.UpdUser, 20, conge_ConnectLookChartNode.UpdUser);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.Memo, 1000, conge_ConnectLookChartNode.Memo);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId, 2, conge_ConnectLookChartNode.ConnectLookNodeTypeId);
//检查外键字段长度
 objge_ConnectLookChartNodeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.ConnectLookNodeId, 10, conge_ConnectLookChartNode.ConnectLookNodeId);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.ConnectLookNodeName, 100, conge_ConnectLookChartNode.ConnectLookNodeName);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.ConnectLookChartId, 10, conge_ConnectLookChartNode.ConnectLookChartId);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.LogicNodeId, 20, conge_ConnectLookChartNode.LogicNodeId);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.ClassName, 100, conge_ConnectLookChartNode.ClassName);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.UpdDate, 20, conge_ConnectLookChartNode.UpdDate);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.UpdUser, 20, conge_ConnectLookChartNode.UpdUser);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.Memo, 1000, conge_ConnectLookChartNode.Memo);
clsCheckSql.CheckFieldLen(objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId, 2, conge_ConnectLookChartNode.ConnectLookNodeTypeId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objge_ConnectLookChartNodeEN.ConnectLookNodeId, conge_ConnectLookChartNode.ConnectLookNodeId);
clsCheckSql.CheckSqlInjection4Field(objge_ConnectLookChartNodeEN.ConnectLookNodeName, conge_ConnectLookChartNode.ConnectLookNodeName);
clsCheckSql.CheckSqlInjection4Field(objge_ConnectLookChartNodeEN.ConnectLookChartId, conge_ConnectLookChartNode.ConnectLookChartId);
clsCheckSql.CheckSqlInjection4Field(objge_ConnectLookChartNodeEN.LogicNodeId, conge_ConnectLookChartNode.LogicNodeId);
clsCheckSql.CheckSqlInjection4Field(objge_ConnectLookChartNodeEN.ClassName, conge_ConnectLookChartNode.ClassName);
clsCheckSql.CheckSqlInjection4Field(objge_ConnectLookChartNodeEN.UpdDate, conge_ConnectLookChartNode.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objge_ConnectLookChartNodeEN.UpdUser, conge_ConnectLookChartNode.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objge_ConnectLookChartNodeEN.Memo, conge_ConnectLookChartNode.Memo);
clsCheckSql.CheckSqlInjection4Field(objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId, conge_ConnectLookChartNode.ConnectLookNodeTypeId);
//检查外键字段长度
 objge_ConnectLookChartNodeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ge_ConnectLookChartNode(连连看图节点),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ConnectLookNodeId = '{0}'", objge_ConnectLookChartNodeEN.ConnectLookNodeId);
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
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
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
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
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
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_ConnectLookChartNodeEN._CurrTabName);
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
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_ConnectLookChartNodeEN._CurrTabName, strCondition);
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
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
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
 objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}