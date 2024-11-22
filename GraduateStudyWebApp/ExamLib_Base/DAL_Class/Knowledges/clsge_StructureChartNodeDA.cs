
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StructureChartNodeDA
 表名:ge_StructureChartNode(01120894)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:51
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
 /// 知识点结构图(ge_StructureChartNode)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsge_StructureChartNodeDA : clsCommBase4DA
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
 return clsge_StructureChartNodeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsge_StructureChartNodeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_StructureChartNodeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsge_StructureChartNodeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsge_StructureChartNodeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strStructureNodeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strStructureNodeId)
{
strStructureNodeId = strStructureNodeId.Replace("'", "''");
if (strStructureNodeId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:ge_StructureChartNode中,检查关键字,长度不正确!(clsge_StructureChartNodeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strStructureNodeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ge_StructureChartNode中,关键字不能为空 或 null!(clsge_StructureChartNodeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStructureNodeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsge_StructureChartNodeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_StructureChartNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureChartNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ge_StructureChartNode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsge_StructureChartNodeDA: GetDataTable_ge_StructureChartNode)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureChartNode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsge_StructureChartNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsge_StructureChartNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureChartNode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsge_StructureChartNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsge_StructureChartNodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_StructureChartNode where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_StructureChartNode where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsge_StructureChartNodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ge_StructureChartNode where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsge_StructureChartNodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_StructureChartNode.* from ge_StructureChartNode Left Join {1} on {2} where {3} and ge_StructureChartNode.StructureNodeId not in (Select top {5} ge_StructureChartNode.StructureNodeId from ge_StructureChartNode Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_StructureChartNode where {1} and StructureNodeId not in (Select top {2} StructureNodeId from ge_StructureChartNode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_StructureChartNode where {1} and StructureNodeId not in (Select top {3} StructureNodeId from ge_StructureChartNode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsge_StructureChartNodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_StructureChartNode.* from ge_StructureChartNode Left Join {1} on {2} where {3} and ge_StructureChartNode.StructureNodeId not in (Select top {5} ge_StructureChartNode.StructureNodeId from ge_StructureChartNode Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_StructureChartNode where {1} and StructureNodeId not in (Select top {2} StructureNodeId from ge_StructureChartNode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_StructureChartNode where {1} and StructureNodeId not in (Select top {3} StructureNodeId from ge_StructureChartNode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsge_StructureChartNodeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsge_StructureChartNodeDA:GetObjLst)", objException.Message));
}
List<clsge_StructureChartNodeEN> arrObjLst = new List<clsge_StructureChartNodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureChartNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureChartNodeEN objge_StructureChartNodeEN = new clsge_StructureChartNodeEN();
try
{
objge_StructureChartNodeEN.StructureNodeId = objRow[conge_StructureChartNode.StructureNodeId].ToString().Trim(); //结构Id
objge_StructureChartNodeEN.StructureNodeName = objRow[conge_StructureChartNode.StructureNodeName].ToString().Trim(); //结构名称
objge_StructureChartNodeEN.UpdDate = objRow[conge_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objge_StructureChartNodeEN.UpdUser = objRow[conge_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objge_StructureChartNodeEN.Memo = objRow[conge_StructureChartNode.Memo] == DBNull.Value ? null : objRow[conge_StructureChartNode.Memo].ToString().Trim(); //备注
objge_StructureChartNodeEN.ParentId = objRow[conge_StructureChartNode.ParentId].ToString().Trim(); //父节点Id
objge_StructureChartNodeEN.IsRoot = TransNullToBool(objRow[conge_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objge_StructureChartNodeEN.background = objRow[conge_StructureChartNode.background] == DBNull.Value ? null : objRow[conge_StructureChartNode.background].ToString().Trim(); //背景色
objge_StructureChartNodeEN.foreground = objRow[conge_StructureChartNode.foreground] == DBNull.Value ? null : objRow[conge_StructureChartNode.foreground].ToString().Trim(); //背景字颜色
objge_StructureChartNodeEN.StructureGraphId = objRow[conge_StructureChartNode.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureChartNodeEN.Direction = objRow[conge_StructureChartNode.Direction] == DBNull.Value ? null : objRow[conge_StructureChartNode.Direction].ToString().Trim(); //方向
objge_StructureChartNodeEN.IsExpanded = TransNullToBool(objRow[conge_StructureChartNode.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureChartNodeEN.StructureSectionId = objRow[conge_StructureChartNode.StructureSectionId] == DBNull.Value ? null : objRow[conge_StructureChartNode.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureChartNodeEN.OrderNum = objRow[conge_StructureChartNode.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_StructureChartNode.OrderNum].ToString().Trim()); //序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_StructureChartNodeDA: GetObjLst)", objException.Message));
}
objge_StructureChartNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_StructureChartNodeEN);
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
public List<clsge_StructureChartNodeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsge_StructureChartNodeDA:GetObjLstByTabName)", objException.Message));
}
List<clsge_StructureChartNodeEN> arrObjLst = new List<clsge_StructureChartNodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureChartNodeEN objge_StructureChartNodeEN = new clsge_StructureChartNodeEN();
try
{
objge_StructureChartNodeEN.StructureNodeId = objRow[conge_StructureChartNode.StructureNodeId].ToString().Trim(); //结构Id
objge_StructureChartNodeEN.StructureNodeName = objRow[conge_StructureChartNode.StructureNodeName].ToString().Trim(); //结构名称
objge_StructureChartNodeEN.UpdDate = objRow[conge_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objge_StructureChartNodeEN.UpdUser = objRow[conge_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objge_StructureChartNodeEN.Memo = objRow[conge_StructureChartNode.Memo] == DBNull.Value ? null : objRow[conge_StructureChartNode.Memo].ToString().Trim(); //备注
objge_StructureChartNodeEN.ParentId = objRow[conge_StructureChartNode.ParentId].ToString().Trim(); //父节点Id
objge_StructureChartNodeEN.IsRoot = TransNullToBool(objRow[conge_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objge_StructureChartNodeEN.background = objRow[conge_StructureChartNode.background] == DBNull.Value ? null : objRow[conge_StructureChartNode.background].ToString().Trim(); //背景色
objge_StructureChartNodeEN.foreground = objRow[conge_StructureChartNode.foreground] == DBNull.Value ? null : objRow[conge_StructureChartNode.foreground].ToString().Trim(); //背景字颜色
objge_StructureChartNodeEN.StructureGraphId = objRow[conge_StructureChartNode.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureChartNodeEN.Direction = objRow[conge_StructureChartNode.Direction] == DBNull.Value ? null : objRow[conge_StructureChartNode.Direction].ToString().Trim(); //方向
objge_StructureChartNodeEN.IsExpanded = TransNullToBool(objRow[conge_StructureChartNode.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureChartNodeEN.StructureSectionId = objRow[conge_StructureChartNode.StructureSectionId] == DBNull.Value ? null : objRow[conge_StructureChartNode.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureChartNodeEN.OrderNum = objRow[conge_StructureChartNode.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_StructureChartNode.OrderNum].ToString().Trim()); //序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_StructureChartNodeDA: GetObjLst)", objException.Message));
}
objge_StructureChartNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_StructureChartNodeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getge_StructureChartNode(ref clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureChartNode where StructureNodeId = " + "'"+ objge_StructureChartNodeEN.StructureNodeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objge_StructureChartNodeEN.StructureNodeId = objDT.Rows[0][conge_StructureChartNode.StructureNodeId].ToString().Trim(); //结构Id(字段类型:char,字段长度:10,是否可空:True)
 objge_StructureChartNodeEN.StructureNodeName = objDT.Rows[0][conge_StructureChartNode.StructureNodeName].ToString().Trim(); //结构名称(字段类型:varchar,字段长度:50,是否可空:False)
 objge_StructureChartNodeEN.UpdDate = objDT.Rows[0][conge_StructureChartNode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StructureChartNodeEN.UpdUser = objDT.Rows[0][conge_StructureChartNode.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StructureChartNodeEN.Memo = objDT.Rows[0][conge_StructureChartNode.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_StructureChartNodeEN.ParentId = objDT.Rows[0][conge_StructureChartNode.ParentId].ToString().Trim(); //父节点Id(字段类型:char,字段长度:10,是否可空:True)
 objge_StructureChartNodeEN.IsRoot = TransNullToBool(objDT.Rows[0][conge_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot(字段类型:bit,字段长度:1,是否可空:True)
 objge_StructureChartNodeEN.background = objDT.Rows[0][conge_StructureChartNode.background].ToString().Trim(); //背景色(字段类型:varchar,字段长度:50,是否可空:True)
 objge_StructureChartNodeEN.foreground = objDT.Rows[0][conge_StructureChartNode.foreground].ToString().Trim(); //背景字颜色(字段类型:varchar,字段长度:50,是否可空:True)
 objge_StructureChartNodeEN.StructureGraphId = objDT.Rows[0][conge_StructureChartNode.StructureGraphId].ToString().Trim(); //知识图谱Id(字段类型:char,字段长度:10,是否可空:True)
 objge_StructureChartNodeEN.Direction = objDT.Rows[0][conge_StructureChartNode.Direction].ToString().Trim(); //方向(字段类型:varchar,字段长度:50,是否可空:True)
 objge_StructureChartNodeEN.IsExpanded = TransNullToBool(objDT.Rows[0][conge_StructureChartNode.IsExpanded].ToString().Trim()); //是否扩展(字段类型:bit,字段长度:1,是否可空:True)
 objge_StructureChartNodeEN.StructureSectionId = objDT.Rows[0][conge_StructureChartNode.StructureSectionId].ToString().Trim(); //结构章节Id(字段类型:char,字段长度:10,是否可空:True)
 objge_StructureChartNodeEN.OrderNum = TransNullToInt(objDT.Rows[0][conge_StructureChartNode.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsge_StructureChartNodeDA: Getge_StructureChartNode)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strStructureNodeId">表关键字</param>
 /// <returns>表对象</returns>
public clsge_StructureChartNodeEN GetObjByStructureNodeId(string strStructureNodeId)
{
CheckPrimaryKey(strStructureNodeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureChartNode where StructureNodeId = " + "'"+ strStructureNodeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsge_StructureChartNodeEN objge_StructureChartNodeEN = new clsge_StructureChartNodeEN();
try
{
 objge_StructureChartNodeEN.StructureNodeId = objRow[conge_StructureChartNode.StructureNodeId].ToString().Trim(); //结构Id(字段类型:char,字段长度:10,是否可空:True)
 objge_StructureChartNodeEN.StructureNodeName = objRow[conge_StructureChartNode.StructureNodeName].ToString().Trim(); //结构名称(字段类型:varchar,字段长度:50,是否可空:False)
 objge_StructureChartNodeEN.UpdDate = objRow[conge_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StructureChartNodeEN.UpdUser = objRow[conge_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StructureChartNodeEN.Memo = objRow[conge_StructureChartNode.Memo] == DBNull.Value ? null : objRow[conge_StructureChartNode.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_StructureChartNodeEN.ParentId = objRow[conge_StructureChartNode.ParentId].ToString().Trim(); //父节点Id(字段类型:char,字段长度:10,是否可空:True)
 objge_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot(字段类型:bit,字段长度:1,是否可空:True)
 objge_StructureChartNodeEN.background = objRow[conge_StructureChartNode.background] == DBNull.Value ? null : objRow[conge_StructureChartNode.background].ToString().Trim(); //背景色(字段类型:varchar,字段长度:50,是否可空:True)
 objge_StructureChartNodeEN.foreground = objRow[conge_StructureChartNode.foreground] == DBNull.Value ? null : objRow[conge_StructureChartNode.foreground].ToString().Trim(); //背景字颜色(字段类型:varchar,字段长度:50,是否可空:True)
 objge_StructureChartNodeEN.StructureGraphId = objRow[conge_StructureChartNode.StructureGraphId].ToString().Trim(); //知识图谱Id(字段类型:char,字段长度:10,是否可空:True)
 objge_StructureChartNodeEN.Direction = objRow[conge_StructureChartNode.Direction] == DBNull.Value ? null : objRow[conge_StructureChartNode.Direction].ToString().Trim(); //方向(字段类型:varchar,字段长度:50,是否可空:True)
 objge_StructureChartNodeEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsExpanded].ToString().Trim()); //是否扩展(字段类型:bit,字段长度:1,是否可空:True)
 objge_StructureChartNodeEN.StructureSectionId = objRow[conge_StructureChartNode.StructureSectionId] == DBNull.Value ? null : objRow[conge_StructureChartNode.StructureSectionId].ToString().Trim(); //结构章节Id(字段类型:char,字段长度:10,是否可空:True)
 objge_StructureChartNodeEN.OrderNum = objRow[conge_StructureChartNode.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureChartNode.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsge_StructureChartNodeDA: GetObjByStructureNodeId)", objException.Message));
}
return objge_StructureChartNodeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsge_StructureChartNodeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsge_StructureChartNodeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureChartNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsge_StructureChartNodeEN objge_StructureChartNodeEN = new clsge_StructureChartNodeEN()
{
StructureNodeId = objRow[conge_StructureChartNode.StructureNodeId].ToString().Trim(), //结构Id
StructureNodeName = objRow[conge_StructureChartNode.StructureNodeName].ToString().Trim(), //结构名称
UpdDate = objRow[conge_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conge_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conge_StructureChartNode.Memo] == DBNull.Value ? null : objRow[conge_StructureChartNode.Memo].ToString().Trim(), //备注
ParentId = objRow[conge_StructureChartNode.ParentId].ToString().Trim(), //父节点Id
IsRoot = TransNullToBool(objRow[conge_StructureChartNode.IsRoot].ToString().Trim()), //IsRoot
background = objRow[conge_StructureChartNode.background] == DBNull.Value ? null : objRow[conge_StructureChartNode.background].ToString().Trim(), //背景色
foreground = objRow[conge_StructureChartNode.foreground] == DBNull.Value ? null : objRow[conge_StructureChartNode.foreground].ToString().Trim(), //背景字颜色
StructureGraphId = objRow[conge_StructureChartNode.StructureGraphId].ToString().Trim(), //知识图谱Id
Direction = objRow[conge_StructureChartNode.Direction] == DBNull.Value ? null : objRow[conge_StructureChartNode.Direction].ToString().Trim(), //方向
IsExpanded = TransNullToBool(objRow[conge_StructureChartNode.IsExpanded].ToString().Trim()), //是否扩展
StructureSectionId = objRow[conge_StructureChartNode.StructureSectionId] == DBNull.Value ? null : objRow[conge_StructureChartNode.StructureSectionId].ToString().Trim(), //结构章节Id
OrderNum = objRow[conge_StructureChartNode.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_StructureChartNode.OrderNum].ToString().Trim()) //序号
};
objge_StructureChartNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_StructureChartNodeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsge_StructureChartNodeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsge_StructureChartNodeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_StructureChartNodeEN objge_StructureChartNodeEN = new clsge_StructureChartNodeEN();
try
{
objge_StructureChartNodeEN.StructureNodeId = objRow[conge_StructureChartNode.StructureNodeId].ToString().Trim(); //结构Id
objge_StructureChartNodeEN.StructureNodeName = objRow[conge_StructureChartNode.StructureNodeName].ToString().Trim(); //结构名称
objge_StructureChartNodeEN.UpdDate = objRow[conge_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objge_StructureChartNodeEN.UpdUser = objRow[conge_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objge_StructureChartNodeEN.Memo = objRow[conge_StructureChartNode.Memo] == DBNull.Value ? null : objRow[conge_StructureChartNode.Memo].ToString().Trim(); //备注
objge_StructureChartNodeEN.ParentId = objRow[conge_StructureChartNode.ParentId].ToString().Trim(); //父节点Id
objge_StructureChartNodeEN.IsRoot = TransNullToBool(objRow[conge_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objge_StructureChartNodeEN.background = objRow[conge_StructureChartNode.background] == DBNull.Value ? null : objRow[conge_StructureChartNode.background].ToString().Trim(); //背景色
objge_StructureChartNodeEN.foreground = objRow[conge_StructureChartNode.foreground] == DBNull.Value ? null : objRow[conge_StructureChartNode.foreground].ToString().Trim(); //背景字颜色
objge_StructureChartNodeEN.StructureGraphId = objRow[conge_StructureChartNode.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureChartNodeEN.Direction = objRow[conge_StructureChartNode.Direction] == DBNull.Value ? null : objRow[conge_StructureChartNode.Direction].ToString().Trim(); //方向
objge_StructureChartNodeEN.IsExpanded = TransNullToBool(objRow[conge_StructureChartNode.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureChartNodeEN.StructureSectionId = objRow[conge_StructureChartNode.StructureSectionId] == DBNull.Value ? null : objRow[conge_StructureChartNode.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureChartNodeEN.OrderNum = objRow[conge_StructureChartNode.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_StructureChartNode.OrderNum].ToString().Trim()); //序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsge_StructureChartNodeDA: GetObjByDataRowge_StructureChartNode)", objException.Message));
}
objge_StructureChartNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_StructureChartNodeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsge_StructureChartNodeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_StructureChartNodeEN objge_StructureChartNodeEN = new clsge_StructureChartNodeEN();
try
{
objge_StructureChartNodeEN.StructureNodeId = objRow[conge_StructureChartNode.StructureNodeId].ToString().Trim(); //结构Id
objge_StructureChartNodeEN.StructureNodeName = objRow[conge_StructureChartNode.StructureNodeName].ToString().Trim(); //结构名称
objge_StructureChartNodeEN.UpdDate = objRow[conge_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objge_StructureChartNodeEN.UpdUser = objRow[conge_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objge_StructureChartNodeEN.Memo = objRow[conge_StructureChartNode.Memo] == DBNull.Value ? null : objRow[conge_StructureChartNode.Memo].ToString().Trim(); //备注
objge_StructureChartNodeEN.ParentId = objRow[conge_StructureChartNode.ParentId].ToString().Trim(); //父节点Id
objge_StructureChartNodeEN.IsRoot = TransNullToBool(objRow[conge_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objge_StructureChartNodeEN.background = objRow[conge_StructureChartNode.background] == DBNull.Value ? null : objRow[conge_StructureChartNode.background].ToString().Trim(); //背景色
objge_StructureChartNodeEN.foreground = objRow[conge_StructureChartNode.foreground] == DBNull.Value ? null : objRow[conge_StructureChartNode.foreground].ToString().Trim(); //背景字颜色
objge_StructureChartNodeEN.StructureGraphId = objRow[conge_StructureChartNode.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureChartNodeEN.Direction = objRow[conge_StructureChartNode.Direction] == DBNull.Value ? null : objRow[conge_StructureChartNode.Direction].ToString().Trim(); //方向
objge_StructureChartNodeEN.IsExpanded = TransNullToBool(objRow[conge_StructureChartNode.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureChartNodeEN.StructureSectionId = objRow[conge_StructureChartNode.StructureSectionId] == DBNull.Value ? null : objRow[conge_StructureChartNode.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureChartNodeEN.OrderNum = objRow[conge_StructureChartNode.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_StructureChartNode.OrderNum].ToString().Trim()); //序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsge_StructureChartNodeDA: GetObjByDataRow)", objException.Message));
}
objge_StructureChartNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_StructureChartNodeEN;
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
objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_StructureChartNodeEN._CurrTabName, conge_StructureChartNode.StructureNodeId, 10, "");
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
objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_StructureChartNodeEN._CurrTabName, conge_StructureChartNode.StructureNodeId, 10, strPrefix);
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
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select StructureNodeId from ge_StructureChartNode where " + strCondition;
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
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select StructureNodeId from ge_StructureChartNode where " + strCondition;
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
 /// <param name = "strStructureNodeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strStructureNodeId)
{
CheckPrimaryKey(strStructureNodeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_StructureChartNode", "StructureNodeId = " + "'"+ strStructureNodeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsge_StructureChartNodeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_StructureChartNode", strCondition))
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
objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ge_StructureChartNode");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsge_StructureChartNodeEN objge_StructureChartNodeEN)
 {
 objge_StructureChartNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StructureChartNodeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureChartNode where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_StructureChartNode");
objRow = objDS.Tables["ge_StructureChartNode"].NewRow();
objRow[conge_StructureChartNode.StructureNodeId] = objge_StructureChartNodeEN.StructureNodeId; //结构Id
objRow[conge_StructureChartNode.StructureNodeName] = objge_StructureChartNodeEN.StructureNodeName; //结构名称
 if (objge_StructureChartNodeEN.UpdDate !=  "")
 {
objRow[conge_StructureChartNode.UpdDate] = objge_StructureChartNodeEN.UpdDate; //修改日期
 }
 if (objge_StructureChartNodeEN.UpdUser !=  "")
 {
objRow[conge_StructureChartNode.UpdUser] = objge_StructureChartNodeEN.UpdUser; //修改人
 }
 if (objge_StructureChartNodeEN.Memo !=  "")
 {
objRow[conge_StructureChartNode.Memo] = objge_StructureChartNodeEN.Memo; //备注
 }
objRow[conge_StructureChartNode.ParentId] = objge_StructureChartNodeEN.ParentId; //父节点Id
objRow[conge_StructureChartNode.IsRoot] = objge_StructureChartNodeEN.IsRoot; //IsRoot
 if (objge_StructureChartNodeEN.background !=  "")
 {
objRow[conge_StructureChartNode.background] = objge_StructureChartNodeEN.background; //背景色
 }
 if (objge_StructureChartNodeEN.foreground !=  "")
 {
objRow[conge_StructureChartNode.foreground] = objge_StructureChartNodeEN.foreground; //背景字颜色
 }
objRow[conge_StructureChartNode.StructureGraphId] = objge_StructureChartNodeEN.StructureGraphId; //知识图谱Id
 if (objge_StructureChartNodeEN.Direction !=  "")
 {
objRow[conge_StructureChartNode.Direction] = objge_StructureChartNodeEN.Direction; //方向
 }
objRow[conge_StructureChartNode.IsExpanded] = objge_StructureChartNodeEN.IsExpanded; //是否扩展
 if (objge_StructureChartNodeEN.StructureSectionId !=  "")
 {
objRow[conge_StructureChartNode.StructureSectionId] = objge_StructureChartNodeEN.StructureSectionId; //结构章节Id
 }
objRow[conge_StructureChartNode.OrderNum] = objge_StructureChartNodeEN.OrderNum; //序号
objDS.Tables[clsge_StructureChartNodeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsge_StructureChartNodeEN._CurrTabName);
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
 /// <param name = "objge_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
 objge_StructureChartNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StructureChartNodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_StructureChartNodeEN.StructureNodeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.StructureNodeId);
 var strStructureNodeId = objge_StructureChartNodeEN.StructureNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureNodeId + "'");
 }
 
 if (objge_StructureChartNodeEN.StructureNodeName !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.StructureNodeName);
 var strStructureNodeName = objge_StructureChartNodeEN.StructureNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureNodeName + "'");
 }
 
 if (objge_StructureChartNodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.UpdDate);
 var strUpdDate = objge_StructureChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_StructureChartNodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.UpdUser);
 var strUpdUser = objge_StructureChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_StructureChartNodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.Memo);
 var strMemo = objge_StructureChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_StructureChartNodeEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.ParentId);
 var strParentId = objge_StructureChartNodeEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 arrFieldListForInsert.Add(conge_StructureChartNode.IsRoot);
 arrValueListForInsert.Add("'" + (objge_StructureChartNodeEN.IsRoot  ==  false ? "0" : "1") + "'");
 
 if (objge_StructureChartNodeEN.background !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.background);
 var strbackground = objge_StructureChartNodeEN.background.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strbackground + "'");
 }
 
 if (objge_StructureChartNodeEN.foreground !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.foreground);
 var strforeground = objge_StructureChartNodeEN.foreground.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strforeground + "'");
 }
 
 if (objge_StructureChartNodeEN.StructureGraphId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.StructureGraphId);
 var strStructureGraphId = objge_StructureChartNodeEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureGraphId + "'");
 }
 
 if (objge_StructureChartNodeEN.Direction !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.Direction);
 var strDirection = objge_StructureChartNodeEN.Direction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDirection + "'");
 }
 
 arrFieldListForInsert.Add(conge_StructureChartNode.IsExpanded);
 arrValueListForInsert.Add("'" + (objge_StructureChartNodeEN.IsExpanded  ==  false ? "0" : "1") + "'");
 
 if (objge_StructureChartNodeEN.StructureSectionId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.StructureSectionId);
 var strStructureSectionId = objge_StructureChartNodeEN.StructureSectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureSectionId + "'");
 }
 
 if (objge_StructureChartNodeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.OrderNum);
 arrValueListForInsert.Add(objge_StructureChartNodeEN.OrderNum.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_StructureChartNode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
 objge_StructureChartNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StructureChartNodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_StructureChartNodeEN.StructureNodeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.StructureNodeId);
 var strStructureNodeId = objge_StructureChartNodeEN.StructureNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureNodeId + "'");
 }
 
 if (objge_StructureChartNodeEN.StructureNodeName !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.StructureNodeName);
 var strStructureNodeName = objge_StructureChartNodeEN.StructureNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureNodeName + "'");
 }
 
 if (objge_StructureChartNodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.UpdDate);
 var strUpdDate = objge_StructureChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_StructureChartNodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.UpdUser);
 var strUpdUser = objge_StructureChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_StructureChartNodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.Memo);
 var strMemo = objge_StructureChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_StructureChartNodeEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.ParentId);
 var strParentId = objge_StructureChartNodeEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 arrFieldListForInsert.Add(conge_StructureChartNode.IsRoot);
 arrValueListForInsert.Add("'" + (objge_StructureChartNodeEN.IsRoot  ==  false ? "0" : "1") + "'");
 
 if (objge_StructureChartNodeEN.background !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.background);
 var strbackground = objge_StructureChartNodeEN.background.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strbackground + "'");
 }
 
 if (objge_StructureChartNodeEN.foreground !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.foreground);
 var strforeground = objge_StructureChartNodeEN.foreground.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strforeground + "'");
 }
 
 if (objge_StructureChartNodeEN.StructureGraphId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.StructureGraphId);
 var strStructureGraphId = objge_StructureChartNodeEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureGraphId + "'");
 }
 
 if (objge_StructureChartNodeEN.Direction !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.Direction);
 var strDirection = objge_StructureChartNodeEN.Direction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDirection + "'");
 }
 
 arrFieldListForInsert.Add(conge_StructureChartNode.IsExpanded);
 arrValueListForInsert.Add("'" + (objge_StructureChartNodeEN.IsExpanded  ==  false ? "0" : "1") + "'");
 
 if (objge_StructureChartNodeEN.StructureSectionId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.StructureSectionId);
 var strStructureSectionId = objge_StructureChartNodeEN.StructureSectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureSectionId + "'");
 }
 
 if (objge_StructureChartNodeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.OrderNum);
 arrValueListForInsert.Add(objge_StructureChartNodeEN.OrderNum.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_StructureChartNode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objge_StructureChartNodeEN.StructureNodeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_StructureChartNodeEN objge_StructureChartNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objge_StructureChartNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StructureChartNodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_StructureChartNodeEN.StructureNodeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.StructureNodeId);
 var strStructureNodeId = objge_StructureChartNodeEN.StructureNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureNodeId + "'");
 }
 
 if (objge_StructureChartNodeEN.StructureNodeName !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.StructureNodeName);
 var strStructureNodeName = objge_StructureChartNodeEN.StructureNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureNodeName + "'");
 }
 
 if (objge_StructureChartNodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.UpdDate);
 var strUpdDate = objge_StructureChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_StructureChartNodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.UpdUser);
 var strUpdUser = objge_StructureChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_StructureChartNodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.Memo);
 var strMemo = objge_StructureChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_StructureChartNodeEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.ParentId);
 var strParentId = objge_StructureChartNodeEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 arrFieldListForInsert.Add(conge_StructureChartNode.IsRoot);
 arrValueListForInsert.Add("'" + (objge_StructureChartNodeEN.IsRoot  ==  false ? "0" : "1") + "'");
 
 if (objge_StructureChartNodeEN.background !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.background);
 var strbackground = objge_StructureChartNodeEN.background.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strbackground + "'");
 }
 
 if (objge_StructureChartNodeEN.foreground !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.foreground);
 var strforeground = objge_StructureChartNodeEN.foreground.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strforeground + "'");
 }
 
 if (objge_StructureChartNodeEN.StructureGraphId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.StructureGraphId);
 var strStructureGraphId = objge_StructureChartNodeEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureGraphId + "'");
 }
 
 if (objge_StructureChartNodeEN.Direction !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.Direction);
 var strDirection = objge_StructureChartNodeEN.Direction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDirection + "'");
 }
 
 arrFieldListForInsert.Add(conge_StructureChartNode.IsExpanded);
 arrValueListForInsert.Add("'" + (objge_StructureChartNodeEN.IsExpanded  ==  false ? "0" : "1") + "'");
 
 if (objge_StructureChartNodeEN.StructureSectionId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.StructureSectionId);
 var strStructureSectionId = objge_StructureChartNodeEN.StructureSectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureSectionId + "'");
 }
 
 if (objge_StructureChartNodeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.OrderNum);
 arrValueListForInsert.Add(objge_StructureChartNodeEN.OrderNum.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_StructureChartNode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objge_StructureChartNodeEN.StructureNodeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_StructureChartNodeEN objge_StructureChartNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objge_StructureChartNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StructureChartNodeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_StructureChartNodeEN.StructureNodeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.StructureNodeId);
 var strStructureNodeId = objge_StructureChartNodeEN.StructureNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureNodeId + "'");
 }
 
 if (objge_StructureChartNodeEN.StructureNodeName !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.StructureNodeName);
 var strStructureNodeName = objge_StructureChartNodeEN.StructureNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureNodeName + "'");
 }
 
 if (objge_StructureChartNodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.UpdDate);
 var strUpdDate = objge_StructureChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_StructureChartNodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.UpdUser);
 var strUpdUser = objge_StructureChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_StructureChartNodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.Memo);
 var strMemo = objge_StructureChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_StructureChartNodeEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.ParentId);
 var strParentId = objge_StructureChartNodeEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 arrFieldListForInsert.Add(conge_StructureChartNode.IsRoot);
 arrValueListForInsert.Add("'" + (objge_StructureChartNodeEN.IsRoot  ==  false ? "0" : "1") + "'");
 
 if (objge_StructureChartNodeEN.background !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.background);
 var strbackground = objge_StructureChartNodeEN.background.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strbackground + "'");
 }
 
 if (objge_StructureChartNodeEN.foreground !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.foreground);
 var strforeground = objge_StructureChartNodeEN.foreground.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strforeground + "'");
 }
 
 if (objge_StructureChartNodeEN.StructureGraphId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.StructureGraphId);
 var strStructureGraphId = objge_StructureChartNodeEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureGraphId + "'");
 }
 
 if (objge_StructureChartNodeEN.Direction !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.Direction);
 var strDirection = objge_StructureChartNodeEN.Direction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDirection + "'");
 }
 
 arrFieldListForInsert.Add(conge_StructureChartNode.IsExpanded);
 arrValueListForInsert.Add("'" + (objge_StructureChartNodeEN.IsExpanded  ==  false ? "0" : "1") + "'");
 
 if (objge_StructureChartNodeEN.StructureSectionId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.StructureSectionId);
 var strStructureSectionId = objge_StructureChartNodeEN.StructureSectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureSectionId + "'");
 }
 
 if (objge_StructureChartNodeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureChartNode.OrderNum);
 arrValueListForInsert.Add(objge_StructureChartNodeEN.OrderNum.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_StructureChartNode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewge_StructureChartNodes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureChartNode where StructureNodeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_StructureChartNode");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strStructureNodeId = oRow[conge_StructureChartNode.StructureNodeId].ToString().Trim();
if (IsExist(strStructureNodeId))
{
 string strResult = "关键字变量值为:" + string.Format("StructureNodeId = {0}", strStructureNodeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsge_StructureChartNodeEN._CurrTabName ].NewRow();
objRow[conge_StructureChartNode.StructureNodeId] = oRow[conge_StructureChartNode.StructureNodeId].ToString().Trim(); //结构Id
objRow[conge_StructureChartNode.StructureNodeName] = oRow[conge_StructureChartNode.StructureNodeName].ToString().Trim(); //结构名称
objRow[conge_StructureChartNode.UpdDate] = oRow[conge_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objRow[conge_StructureChartNode.UpdUser] = oRow[conge_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objRow[conge_StructureChartNode.Memo] = oRow[conge_StructureChartNode.Memo].ToString().Trim(); //备注
objRow[conge_StructureChartNode.ParentId] = oRow[conge_StructureChartNode.ParentId].ToString().Trim(); //父节点Id
objRow[conge_StructureChartNode.IsRoot] = oRow[conge_StructureChartNode.IsRoot].ToString().Trim(); //IsRoot
objRow[conge_StructureChartNode.background] = oRow[conge_StructureChartNode.background].ToString().Trim(); //背景色
objRow[conge_StructureChartNode.foreground] = oRow[conge_StructureChartNode.foreground].ToString().Trim(); //背景字颜色
objRow[conge_StructureChartNode.StructureGraphId] = oRow[conge_StructureChartNode.StructureGraphId].ToString().Trim(); //知识图谱Id
objRow[conge_StructureChartNode.Direction] = oRow[conge_StructureChartNode.Direction].ToString().Trim(); //方向
objRow[conge_StructureChartNode.IsExpanded] = oRow[conge_StructureChartNode.IsExpanded].ToString().Trim(); //是否扩展
objRow[conge_StructureChartNode.StructureSectionId] = oRow[conge_StructureChartNode.StructureSectionId].ToString().Trim(); //结构章节Id
objRow[conge_StructureChartNode.OrderNum] = oRow[conge_StructureChartNode.OrderNum].ToString().Trim(); //序号
 objDS.Tables[clsge_StructureChartNodeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsge_StructureChartNodeEN._CurrTabName);
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
 /// <param name = "objge_StructureChartNodeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
 objge_StructureChartNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StructureChartNodeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureChartNode where StructureNodeId = " + "'"+ objge_StructureChartNodeEN.StructureNodeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsge_StructureChartNodeEN._CurrTabName);
if (objDS.Tables[clsge_StructureChartNodeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:StructureNodeId = " + "'"+ objge_StructureChartNodeEN.StructureNodeId+"'");
return false;
}
objRow = objDS.Tables[clsge_StructureChartNodeEN._CurrTabName].Rows[0];
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.StructureNodeId))
 {
objRow[conge_StructureChartNode.StructureNodeId] = objge_StructureChartNodeEN.StructureNodeId; //结构Id
 }
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.StructureNodeName))
 {
objRow[conge_StructureChartNode.StructureNodeName] = objge_StructureChartNodeEN.StructureNodeName; //结构名称
 }
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.UpdDate))
 {
objRow[conge_StructureChartNode.UpdDate] = objge_StructureChartNodeEN.UpdDate; //修改日期
 }
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.UpdUser))
 {
objRow[conge_StructureChartNode.UpdUser] = objge_StructureChartNodeEN.UpdUser; //修改人
 }
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.Memo))
 {
objRow[conge_StructureChartNode.Memo] = objge_StructureChartNodeEN.Memo; //备注
 }
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.ParentId))
 {
objRow[conge_StructureChartNode.ParentId] = objge_StructureChartNodeEN.ParentId; //父节点Id
 }
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.IsRoot))
 {
objRow[conge_StructureChartNode.IsRoot] = objge_StructureChartNodeEN.IsRoot; //IsRoot
 }
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.background))
 {
objRow[conge_StructureChartNode.background] = objge_StructureChartNodeEN.background; //背景色
 }
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.foreground))
 {
objRow[conge_StructureChartNode.foreground] = objge_StructureChartNodeEN.foreground; //背景字颜色
 }
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.StructureGraphId))
 {
objRow[conge_StructureChartNode.StructureGraphId] = objge_StructureChartNodeEN.StructureGraphId; //知识图谱Id
 }
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.Direction))
 {
objRow[conge_StructureChartNode.Direction] = objge_StructureChartNodeEN.Direction; //方向
 }
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.IsExpanded))
 {
objRow[conge_StructureChartNode.IsExpanded] = objge_StructureChartNodeEN.IsExpanded; //是否扩展
 }
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.StructureSectionId))
 {
objRow[conge_StructureChartNode.StructureSectionId] = objge_StructureChartNodeEN.StructureSectionId; //结构章节Id
 }
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.OrderNum))
 {
objRow[conge_StructureChartNode.OrderNum] = objge_StructureChartNodeEN.OrderNum; //序号
 }
try
{
objDA.Update(objDS, clsge_StructureChartNodeEN._CurrTabName);
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
 /// <param name = "objge_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
 objge_StructureChartNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StructureChartNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ge_StructureChartNode Set ");
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.StructureNodeName))
 {
 if (objge_StructureChartNodeEN.StructureNodeName !=  null)
 {
 var strStructureNodeName = objge_StructureChartNodeEN.StructureNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStructureNodeName, conge_StructureChartNode.StructureNodeName); //结构名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.StructureNodeName); //结构名称
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.UpdDate))
 {
 if (objge_StructureChartNodeEN.UpdDate !=  null)
 {
 var strUpdDate = objge_StructureChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_StructureChartNode.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.UpdDate); //修改日期
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.UpdUser))
 {
 if (objge_StructureChartNodeEN.UpdUser !=  null)
 {
 var strUpdUser = objge_StructureChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_StructureChartNode.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.UpdUser); //修改人
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.Memo))
 {
 if (objge_StructureChartNodeEN.Memo !=  null)
 {
 var strMemo = objge_StructureChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_StructureChartNode.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.Memo); //备注
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.ParentId))
 {
 if (objge_StructureChartNodeEN.ParentId !=  null)
 {
 var strParentId = objge_StructureChartNodeEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, conge_StructureChartNode.ParentId); //父节点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.ParentId); //父节点Id
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.IsRoot))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StructureChartNodeEN.IsRoot == true?"1":"0", conge_StructureChartNode.IsRoot); //IsRoot
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.background))
 {
 if (objge_StructureChartNodeEN.background !=  null)
 {
 var strbackground = objge_StructureChartNodeEN.background.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strbackground, conge_StructureChartNode.background); //背景色
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.background); //背景色
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.foreground))
 {
 if (objge_StructureChartNodeEN.foreground !=  null)
 {
 var strforeground = objge_StructureChartNodeEN.foreground.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strforeground, conge_StructureChartNode.foreground); //背景字颜色
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.foreground); //背景字颜色
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.StructureGraphId))
 {
 if (objge_StructureChartNodeEN.StructureGraphId !=  null)
 {
 var strStructureGraphId = objge_StructureChartNodeEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStructureGraphId, conge_StructureChartNode.StructureGraphId); //知识图谱Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.StructureGraphId); //知识图谱Id
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.Direction))
 {
 if (objge_StructureChartNodeEN.Direction !=  null)
 {
 var strDirection = objge_StructureChartNodeEN.Direction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDirection, conge_StructureChartNode.Direction); //方向
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.Direction); //方向
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.IsExpanded))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StructureChartNodeEN.IsExpanded == true?"1":"0", conge_StructureChartNode.IsExpanded); //是否扩展
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.StructureSectionId))
 {
 if (objge_StructureChartNodeEN.StructureSectionId !=  null)
 {
 var strStructureSectionId = objge_StructureChartNodeEN.StructureSectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStructureSectionId, conge_StructureChartNode.StructureSectionId); //结构章节Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.StructureSectionId); //结构章节Id
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.OrderNum))
 {
 if (objge_StructureChartNodeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StructureChartNodeEN.OrderNum, conge_StructureChartNode.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.OrderNum); //序号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where StructureNodeId = '{0}'", objge_StructureChartNodeEN.StructureNodeId); 
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
 /// <param name = "objge_StructureChartNodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsge_StructureChartNodeEN objge_StructureChartNodeEN, string strCondition)
{
 objge_StructureChartNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StructureChartNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_StructureChartNode Set ");
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.StructureNodeName))
 {
 if (objge_StructureChartNodeEN.StructureNodeName !=  null)
 {
 var strStructureNodeName = objge_StructureChartNodeEN.StructureNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StructureNodeName = '{0}',", strStructureNodeName); //结构名称
 }
 else
 {
 sbSQL.Append(" StructureNodeName = null,"); //结构名称
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.UpdDate))
 {
 if (objge_StructureChartNodeEN.UpdDate !=  null)
 {
 var strUpdDate = objge_StructureChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.UpdUser))
 {
 if (objge_StructureChartNodeEN.UpdUser !=  null)
 {
 var strUpdUser = objge_StructureChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.Memo))
 {
 if (objge_StructureChartNodeEN.Memo !=  null)
 {
 var strMemo = objge_StructureChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.ParentId))
 {
 if (objge_StructureChartNodeEN.ParentId !=  null)
 {
 var strParentId = objge_StructureChartNodeEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父节点Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父节点Id
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.IsRoot))
 {
 sbSQL.AppendFormat(" IsRoot = '{0}',", objge_StructureChartNodeEN.IsRoot == true?"1":"0"); //IsRoot
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.background))
 {
 if (objge_StructureChartNodeEN.background !=  null)
 {
 var strbackground = objge_StructureChartNodeEN.background.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" background = '{0}',", strbackground); //背景色
 }
 else
 {
 sbSQL.Append(" background = null,"); //背景色
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.foreground))
 {
 if (objge_StructureChartNodeEN.foreground !=  null)
 {
 var strforeground = objge_StructureChartNodeEN.foreground.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" foreground = '{0}',", strforeground); //背景字颜色
 }
 else
 {
 sbSQL.Append(" foreground = null,"); //背景字颜色
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.StructureGraphId))
 {
 if (objge_StructureChartNodeEN.StructureGraphId !=  null)
 {
 var strStructureGraphId = objge_StructureChartNodeEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StructureGraphId = '{0}',", strStructureGraphId); //知识图谱Id
 }
 else
 {
 sbSQL.Append(" StructureGraphId = null,"); //知识图谱Id
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.Direction))
 {
 if (objge_StructureChartNodeEN.Direction !=  null)
 {
 var strDirection = objge_StructureChartNodeEN.Direction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Direction = '{0}',", strDirection); //方向
 }
 else
 {
 sbSQL.Append(" Direction = null,"); //方向
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.IsExpanded))
 {
 sbSQL.AppendFormat(" IsExpanded = '{0}',", objge_StructureChartNodeEN.IsExpanded == true?"1":"0"); //是否扩展
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.StructureSectionId))
 {
 if (objge_StructureChartNodeEN.StructureSectionId !=  null)
 {
 var strStructureSectionId = objge_StructureChartNodeEN.StructureSectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StructureSectionId = '{0}',", strStructureSectionId); //结构章节Id
 }
 else
 {
 sbSQL.Append(" StructureSectionId = null,"); //结构章节Id
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.OrderNum))
 {
 if (objge_StructureChartNodeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StructureChartNodeEN.OrderNum, conge_StructureChartNode.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.OrderNum); //序号
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
 /// <param name = "objge_StructureChartNodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsge_StructureChartNodeEN objge_StructureChartNodeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objge_StructureChartNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StructureChartNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_StructureChartNode Set ");
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.StructureNodeName))
 {
 if (objge_StructureChartNodeEN.StructureNodeName !=  null)
 {
 var strStructureNodeName = objge_StructureChartNodeEN.StructureNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StructureNodeName = '{0}',", strStructureNodeName); //结构名称
 }
 else
 {
 sbSQL.Append(" StructureNodeName = null,"); //结构名称
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.UpdDate))
 {
 if (objge_StructureChartNodeEN.UpdDate !=  null)
 {
 var strUpdDate = objge_StructureChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.UpdUser))
 {
 if (objge_StructureChartNodeEN.UpdUser !=  null)
 {
 var strUpdUser = objge_StructureChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.Memo))
 {
 if (objge_StructureChartNodeEN.Memo !=  null)
 {
 var strMemo = objge_StructureChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.ParentId))
 {
 if (objge_StructureChartNodeEN.ParentId !=  null)
 {
 var strParentId = objge_StructureChartNodeEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父节点Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父节点Id
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.IsRoot))
 {
 sbSQL.AppendFormat(" IsRoot = '{0}',", objge_StructureChartNodeEN.IsRoot == true?"1":"0"); //IsRoot
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.background))
 {
 if (objge_StructureChartNodeEN.background !=  null)
 {
 var strbackground = objge_StructureChartNodeEN.background.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" background = '{0}',", strbackground); //背景色
 }
 else
 {
 sbSQL.Append(" background = null,"); //背景色
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.foreground))
 {
 if (objge_StructureChartNodeEN.foreground !=  null)
 {
 var strforeground = objge_StructureChartNodeEN.foreground.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" foreground = '{0}',", strforeground); //背景字颜色
 }
 else
 {
 sbSQL.Append(" foreground = null,"); //背景字颜色
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.StructureGraphId))
 {
 if (objge_StructureChartNodeEN.StructureGraphId !=  null)
 {
 var strStructureGraphId = objge_StructureChartNodeEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StructureGraphId = '{0}',", strStructureGraphId); //知识图谱Id
 }
 else
 {
 sbSQL.Append(" StructureGraphId = null,"); //知识图谱Id
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.Direction))
 {
 if (objge_StructureChartNodeEN.Direction !=  null)
 {
 var strDirection = objge_StructureChartNodeEN.Direction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Direction = '{0}',", strDirection); //方向
 }
 else
 {
 sbSQL.Append(" Direction = null,"); //方向
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.IsExpanded))
 {
 sbSQL.AppendFormat(" IsExpanded = '{0}',", objge_StructureChartNodeEN.IsExpanded == true?"1":"0"); //是否扩展
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.StructureSectionId))
 {
 if (objge_StructureChartNodeEN.StructureSectionId !=  null)
 {
 var strStructureSectionId = objge_StructureChartNodeEN.StructureSectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StructureSectionId = '{0}',", strStructureSectionId); //结构章节Id
 }
 else
 {
 sbSQL.Append(" StructureSectionId = null,"); //结构章节Id
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.OrderNum))
 {
 if (objge_StructureChartNodeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StructureChartNodeEN.OrderNum, conge_StructureChartNode.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.OrderNum); //序号
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
 /// <param name = "objge_StructureChartNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_StructureChartNodeEN objge_StructureChartNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objge_StructureChartNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StructureChartNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_StructureChartNode Set ");
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.StructureNodeName))
 {
 if (objge_StructureChartNodeEN.StructureNodeName !=  null)
 {
 var strStructureNodeName = objge_StructureChartNodeEN.StructureNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStructureNodeName, conge_StructureChartNode.StructureNodeName); //结构名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.StructureNodeName); //结构名称
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.UpdDate))
 {
 if (objge_StructureChartNodeEN.UpdDate !=  null)
 {
 var strUpdDate = objge_StructureChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_StructureChartNode.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.UpdDate); //修改日期
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.UpdUser))
 {
 if (objge_StructureChartNodeEN.UpdUser !=  null)
 {
 var strUpdUser = objge_StructureChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_StructureChartNode.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.UpdUser); //修改人
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.Memo))
 {
 if (objge_StructureChartNodeEN.Memo !=  null)
 {
 var strMemo = objge_StructureChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_StructureChartNode.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.Memo); //备注
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.ParentId))
 {
 if (objge_StructureChartNodeEN.ParentId !=  null)
 {
 var strParentId = objge_StructureChartNodeEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, conge_StructureChartNode.ParentId); //父节点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.ParentId); //父节点Id
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.IsRoot))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StructureChartNodeEN.IsRoot == true?"1":"0", conge_StructureChartNode.IsRoot); //IsRoot
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.background))
 {
 if (objge_StructureChartNodeEN.background !=  null)
 {
 var strbackground = objge_StructureChartNodeEN.background.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strbackground, conge_StructureChartNode.background); //背景色
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.background); //背景色
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.foreground))
 {
 if (objge_StructureChartNodeEN.foreground !=  null)
 {
 var strforeground = objge_StructureChartNodeEN.foreground.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strforeground, conge_StructureChartNode.foreground); //背景字颜色
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.foreground); //背景字颜色
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.StructureGraphId))
 {
 if (objge_StructureChartNodeEN.StructureGraphId !=  null)
 {
 var strStructureGraphId = objge_StructureChartNodeEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStructureGraphId, conge_StructureChartNode.StructureGraphId); //知识图谱Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.StructureGraphId); //知识图谱Id
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.Direction))
 {
 if (objge_StructureChartNodeEN.Direction !=  null)
 {
 var strDirection = objge_StructureChartNodeEN.Direction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDirection, conge_StructureChartNode.Direction); //方向
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.Direction); //方向
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.IsExpanded))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StructureChartNodeEN.IsExpanded == true?"1":"0", conge_StructureChartNode.IsExpanded); //是否扩展
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.StructureSectionId))
 {
 if (objge_StructureChartNodeEN.StructureSectionId !=  null)
 {
 var strStructureSectionId = objge_StructureChartNodeEN.StructureSectionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStructureSectionId, conge_StructureChartNode.StructureSectionId); //结构章节Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.StructureSectionId); //结构章节Id
 }
 }
 
 if (objge_StructureChartNodeEN.IsUpdated(conge_StructureChartNode.OrderNum))
 {
 if (objge_StructureChartNodeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_StructureChartNodeEN.OrderNum, conge_StructureChartNode.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureChartNode.OrderNum); //序号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where StructureNodeId = '{0}'", objge_StructureChartNodeEN.StructureNodeId); 
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
 /// <param name = "strStructureNodeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strStructureNodeId) 
{
CheckPrimaryKey(strStructureNodeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strStructureNodeId,
};
 objSQL.ExecSP("ge_StructureChartNode_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strStructureNodeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strStructureNodeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strStructureNodeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
//删除ge_StructureChartNode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_StructureChartNode where StructureNodeId = " + "'"+ strStructureNodeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delge_StructureChartNode(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
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
//删除ge_StructureChartNode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_StructureChartNode where StructureNodeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strStructureNodeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strStructureNodeId) 
{
CheckPrimaryKey(strStructureNodeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
//删除ge_StructureChartNode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_StructureChartNode where StructureNodeId = " + "'"+ strStructureNodeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delge_StructureChartNode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsge_StructureChartNodeDA: Delge_StructureChartNode)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_StructureChartNode where " + strCondition ;
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
public bool Delge_StructureChartNodeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsge_StructureChartNodeDA: Delge_StructureChartNodeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_StructureChartNode where " + strCondition ;
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
 /// <param name = "objge_StructureChartNodeENS">源对象</param>
 /// <param name = "objge_StructureChartNodeENT">目标对象</param>
public void CopyTo(clsge_StructureChartNodeEN objge_StructureChartNodeENS, clsge_StructureChartNodeEN objge_StructureChartNodeENT)
{
objge_StructureChartNodeENT.StructureNodeId = objge_StructureChartNodeENS.StructureNodeId; //结构Id
objge_StructureChartNodeENT.StructureNodeName = objge_StructureChartNodeENS.StructureNodeName; //结构名称
objge_StructureChartNodeENT.UpdDate = objge_StructureChartNodeENS.UpdDate; //修改日期
objge_StructureChartNodeENT.UpdUser = objge_StructureChartNodeENS.UpdUser; //修改人
objge_StructureChartNodeENT.Memo = objge_StructureChartNodeENS.Memo; //备注
objge_StructureChartNodeENT.ParentId = objge_StructureChartNodeENS.ParentId; //父节点Id
objge_StructureChartNodeENT.IsRoot = objge_StructureChartNodeENS.IsRoot; //IsRoot
objge_StructureChartNodeENT.background = objge_StructureChartNodeENS.background; //背景色
objge_StructureChartNodeENT.foreground = objge_StructureChartNodeENS.foreground; //背景字颜色
objge_StructureChartNodeENT.StructureGraphId = objge_StructureChartNodeENS.StructureGraphId; //知识图谱Id
objge_StructureChartNodeENT.Direction = objge_StructureChartNodeENS.Direction; //方向
objge_StructureChartNodeENT.IsExpanded = objge_StructureChartNodeENS.IsExpanded; //是否扩展
objge_StructureChartNodeENT.StructureSectionId = objge_StructureChartNodeENS.StructureSectionId; //结构章节Id
objge_StructureChartNodeENT.OrderNum = objge_StructureChartNodeENS.OrderNum; //序号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objge_StructureChartNodeEN.StructureNodeName, conge_StructureChartNode.StructureNodeName);
clsCheckSql.CheckFieldNotNull(objge_StructureChartNodeEN.ParentId, conge_StructureChartNode.ParentId);
clsCheckSql.CheckFieldNotNull(objge_StructureChartNodeEN.StructureGraphId, conge_StructureChartNode.StructureGraphId);
//检查字段长度
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.StructureNodeId, 10, conge_StructureChartNode.StructureNodeId);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.StructureNodeName, 50, conge_StructureChartNode.StructureNodeName);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.UpdDate, 20, conge_StructureChartNode.UpdDate);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.UpdUser, 20, conge_StructureChartNode.UpdUser);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.Memo, 1000, conge_StructureChartNode.Memo);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.ParentId, 10, conge_StructureChartNode.ParentId);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.background, 50, conge_StructureChartNode.background);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.foreground, 50, conge_StructureChartNode.foreground);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.StructureGraphId, 10, conge_StructureChartNode.StructureGraphId);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.Direction, 50, conge_StructureChartNode.Direction);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.StructureSectionId, 10, conge_StructureChartNode.StructureSectionId);
//检查字段外键固定长度
 objge_StructureChartNodeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.StructureNodeName, 50, conge_StructureChartNode.StructureNodeName);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.UpdDate, 20, conge_StructureChartNode.UpdDate);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.UpdUser, 20, conge_StructureChartNode.UpdUser);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.Memo, 1000, conge_StructureChartNode.Memo);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.ParentId, 10, conge_StructureChartNode.ParentId);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.background, 50, conge_StructureChartNode.background);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.foreground, 50, conge_StructureChartNode.foreground);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.StructureGraphId, 10, conge_StructureChartNode.StructureGraphId);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.Direction, 50, conge_StructureChartNode.Direction);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.StructureSectionId, 10, conge_StructureChartNode.StructureSectionId);
//检查外键字段长度
 objge_StructureChartNodeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.StructureNodeId, 10, conge_StructureChartNode.StructureNodeId);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.StructureNodeName, 50, conge_StructureChartNode.StructureNodeName);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.UpdDate, 20, conge_StructureChartNode.UpdDate);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.UpdUser, 20, conge_StructureChartNode.UpdUser);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.Memo, 1000, conge_StructureChartNode.Memo);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.ParentId, 10, conge_StructureChartNode.ParentId);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.background, 50, conge_StructureChartNode.background);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.foreground, 50, conge_StructureChartNode.foreground);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.StructureGraphId, 10, conge_StructureChartNode.StructureGraphId);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.Direction, 50, conge_StructureChartNode.Direction);
clsCheckSql.CheckFieldLen(objge_StructureChartNodeEN.StructureSectionId, 10, conge_StructureChartNode.StructureSectionId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objge_StructureChartNodeEN.StructureNodeId, conge_StructureChartNode.StructureNodeId);
clsCheckSql.CheckSqlInjection4Field(objge_StructureChartNodeEN.StructureNodeName, conge_StructureChartNode.StructureNodeName);
clsCheckSql.CheckSqlInjection4Field(objge_StructureChartNodeEN.UpdDate, conge_StructureChartNode.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objge_StructureChartNodeEN.UpdUser, conge_StructureChartNode.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objge_StructureChartNodeEN.Memo, conge_StructureChartNode.Memo);
clsCheckSql.CheckSqlInjection4Field(objge_StructureChartNodeEN.ParentId, conge_StructureChartNode.ParentId);
clsCheckSql.CheckSqlInjection4Field(objge_StructureChartNodeEN.background, conge_StructureChartNode.background);
clsCheckSql.CheckSqlInjection4Field(objge_StructureChartNodeEN.foreground, conge_StructureChartNode.foreground);
clsCheckSql.CheckSqlInjection4Field(objge_StructureChartNodeEN.StructureGraphId, conge_StructureChartNode.StructureGraphId);
clsCheckSql.CheckSqlInjection4Field(objge_StructureChartNodeEN.Direction, conge_StructureChartNode.Direction);
clsCheckSql.CheckSqlInjection4Field(objge_StructureChartNodeEN.StructureSectionId, conge_StructureChartNode.StructureSectionId);
//检查外键字段长度
 objge_StructureChartNodeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetStructureNodeId()
{
//获取某学院所有专业信息
string strSQL = "select StructureNodeId, StructureNodeName from ge_StructureChartNode ";
 clsSpecSQLforSql mySql = clsge_StructureChartNodeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ge_StructureChartNode(知识点结构图),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and StructureNodeName = '{0}'", objge_StructureChartNodeEN.StructureNodeName);
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
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
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
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
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
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_StructureChartNodeEN._CurrTabName);
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
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_StructureChartNodeEN._CurrTabName, strCondition);
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
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
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
 objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}