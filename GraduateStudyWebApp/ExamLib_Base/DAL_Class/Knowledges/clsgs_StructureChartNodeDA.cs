
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_StructureChartNodeDA
 表名:gs_StructureChartNode(01120877)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:56
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
 /// 结构图节点(gs_StructureChartNode)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsgs_StructureChartNodeDA : clsCommBase4DA
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
 return clsgs_StructureChartNodeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsgs_StructureChartNodeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_StructureChartNodeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsgs_StructureChartNodeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsgs_StructureChartNodeEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsgs_StructureChartNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from gs_StructureChartNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_gs_StructureChartNode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsgs_StructureChartNodeDA: GetDataTable_gs_StructureChartNode)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from gs_StructureChartNode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsgs_StructureChartNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsgs_StructureChartNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from gs_StructureChartNode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsgs_StructureChartNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsgs_StructureChartNodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_StructureChartNode where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_StructureChartNode where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsgs_StructureChartNodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from gs_StructureChartNode where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsgs_StructureChartNodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_StructureChartNode.* from gs_StructureChartNode Left Join {1} on {2} where {3} and gs_StructureChartNode.mId not in (Select top {5} gs_StructureChartNode.mId from gs_StructureChartNode Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_StructureChartNode where {1} and mId not in (Select top {2} mId from gs_StructureChartNode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_StructureChartNode where {1} and mId not in (Select top {3} mId from gs_StructureChartNode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsgs_StructureChartNodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_StructureChartNode.* from gs_StructureChartNode Left Join {1} on {2} where {3} and gs_StructureChartNode.mId not in (Select top {5} gs_StructureChartNode.mId from gs_StructureChartNode Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_StructureChartNode where {1} and mId not in (Select top {2} mId from gs_StructureChartNode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_StructureChartNode where {1} and mId not in (Select top {3} mId from gs_StructureChartNode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsgs_StructureChartNodeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsgs_StructureChartNodeDA:GetObjLst)", objException.Message));
}
List<clsgs_StructureChartNodeEN> arrObjLst = new List<clsgs_StructureChartNodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from gs_StructureChartNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = new clsgs_StructureChartNodeEN();
try
{
objgs_StructureChartNodeEN.mId = TransNullToInt(objRow[congs_StructureChartNode.mId].ToString().Trim()); //mId
objgs_StructureChartNodeEN.StructureChartId = objRow[congs_StructureChartNode.StructureChartId].ToString().Trim(); //结构图Id
objgs_StructureChartNodeEN.NodeId = objRow[congs_StructureChartNode.NodeId].ToString().Trim(); //节点Id
objgs_StructureChartNodeEN.NodeTitle = objRow[congs_StructureChartNode.NodeTitle].ToString().Trim(); //节点标题
objgs_StructureChartNodeEN.ParentId = objRow[congs_StructureChartNode.ParentId] == DBNull.Value ? null : objRow[congs_StructureChartNode.ParentId].ToString().Trim(); //父Id
objgs_StructureChartNodeEN.IsRoot = TransNullToBool(objRow[congs_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objgs_StructureChartNodeEN.Expanded = TransNullToBool(objRow[congs_StructureChartNode.Expanded].ToString().Trim()); //扩大
objgs_StructureChartNodeEN.Direction = objRow[congs_StructureChartNode.Direction] == DBNull.Value ? null : objRow[congs_StructureChartNode.Direction].ToString().Trim(); //方向
objgs_StructureChartNodeEN.BgColor = objRow[congs_StructureChartNode.BgColor] == DBNull.Value ? null : objRow[congs_StructureChartNode.BgColor].ToString().Trim(); //背景色
objgs_StructureChartNodeEN.UpdDate = objRow[congs_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objgs_StructureChartNodeEN.UpdUser = objRow[congs_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objgs_StructureChartNodeEN.Memo = objRow[congs_StructureChartNode.Memo] == DBNull.Value ? null : objRow[congs_StructureChartNode.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_StructureChartNodeDA: GetObjLst)", objException.Message));
}
objgs_StructureChartNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_StructureChartNodeEN);
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
public List<clsgs_StructureChartNodeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsgs_StructureChartNodeDA:GetObjLstByTabName)", objException.Message));
}
List<clsgs_StructureChartNodeEN> arrObjLst = new List<clsgs_StructureChartNodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = new clsgs_StructureChartNodeEN();
try
{
objgs_StructureChartNodeEN.mId = TransNullToInt(objRow[congs_StructureChartNode.mId].ToString().Trim()); //mId
objgs_StructureChartNodeEN.StructureChartId = objRow[congs_StructureChartNode.StructureChartId].ToString().Trim(); //结构图Id
objgs_StructureChartNodeEN.NodeId = objRow[congs_StructureChartNode.NodeId].ToString().Trim(); //节点Id
objgs_StructureChartNodeEN.NodeTitle = objRow[congs_StructureChartNode.NodeTitle].ToString().Trim(); //节点标题
objgs_StructureChartNodeEN.ParentId = objRow[congs_StructureChartNode.ParentId] == DBNull.Value ? null : objRow[congs_StructureChartNode.ParentId].ToString().Trim(); //父Id
objgs_StructureChartNodeEN.IsRoot = TransNullToBool(objRow[congs_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objgs_StructureChartNodeEN.Expanded = TransNullToBool(objRow[congs_StructureChartNode.Expanded].ToString().Trim()); //扩大
objgs_StructureChartNodeEN.Direction = objRow[congs_StructureChartNode.Direction] == DBNull.Value ? null : objRow[congs_StructureChartNode.Direction].ToString().Trim(); //方向
objgs_StructureChartNodeEN.BgColor = objRow[congs_StructureChartNode.BgColor] == DBNull.Value ? null : objRow[congs_StructureChartNode.BgColor].ToString().Trim(); //背景色
objgs_StructureChartNodeEN.UpdDate = objRow[congs_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objgs_StructureChartNodeEN.UpdUser = objRow[congs_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objgs_StructureChartNodeEN.Memo = objRow[congs_StructureChartNode.Memo] == DBNull.Value ? null : objRow[congs_StructureChartNode.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_StructureChartNodeDA: GetObjLst)", objException.Message));
}
objgs_StructureChartNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_StructureChartNodeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getgs_StructureChartNode(ref clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from gs_StructureChartNode where mId = " + ""+ objgs_StructureChartNodeEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objgs_StructureChartNodeEN.mId = TransNullToInt(objDT.Rows[0][congs_StructureChartNode.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objgs_StructureChartNodeEN.StructureChartId = objDT.Rows[0][congs_StructureChartNode.StructureChartId].ToString().Trim(); //结构图Id(字段类型:char,字段长度:10,是否可空:False)
 objgs_StructureChartNodeEN.NodeId = objDT.Rows[0][congs_StructureChartNode.NodeId].ToString().Trim(); //节点Id(字段类型:varchar,字段长度:20,是否可空:False)
 objgs_StructureChartNodeEN.NodeTitle = objDT.Rows[0][congs_StructureChartNode.NodeTitle].ToString().Trim(); //节点标题(字段类型:varchar,字段长度:100,是否可空:False)
 objgs_StructureChartNodeEN.ParentId = objDT.Rows[0][congs_StructureChartNode.ParentId].ToString().Trim(); //父Id(字段类型:varchar,字段长度:20,是否可空:False)
 objgs_StructureChartNodeEN.IsRoot = TransNullToBool(objDT.Rows[0][congs_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot(字段类型:bit,字段长度:1,是否可空:True)
 objgs_StructureChartNodeEN.Expanded = TransNullToBool(objDT.Rows[0][congs_StructureChartNode.Expanded].ToString().Trim()); //扩大(字段类型:bit,字段长度:1,是否可空:True)
 objgs_StructureChartNodeEN.Direction = objDT.Rows[0][congs_StructureChartNode.Direction].ToString().Trim(); //方向(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_StructureChartNodeEN.BgColor = objDT.Rows[0][congs_StructureChartNode.BgColor].ToString().Trim(); //背景色(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_StructureChartNodeEN.UpdDate = objDT.Rows[0][congs_StructureChartNode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_StructureChartNodeEN.UpdUser = objDT.Rows[0][congs_StructureChartNode.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_StructureChartNodeEN.Memo = objDT.Rows[0][congs_StructureChartNode.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsgs_StructureChartNodeDA: Getgs_StructureChartNode)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsgs_StructureChartNodeEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from gs_StructureChartNode where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = new clsgs_StructureChartNodeEN();
try
{
 objgs_StructureChartNodeEN.mId = Int32.Parse(objRow[congs_StructureChartNode.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objgs_StructureChartNodeEN.StructureChartId = objRow[congs_StructureChartNode.StructureChartId].ToString().Trim(); //结构图Id(字段类型:char,字段长度:10,是否可空:False)
 objgs_StructureChartNodeEN.NodeId = objRow[congs_StructureChartNode.NodeId].ToString().Trim(); //节点Id(字段类型:varchar,字段长度:20,是否可空:False)
 objgs_StructureChartNodeEN.NodeTitle = objRow[congs_StructureChartNode.NodeTitle].ToString().Trim(); //节点标题(字段类型:varchar,字段长度:100,是否可空:False)
 objgs_StructureChartNodeEN.ParentId = objRow[congs_StructureChartNode.ParentId] == DBNull.Value ? null : objRow[congs_StructureChartNode.ParentId].ToString().Trim(); //父Id(字段类型:varchar,字段长度:20,是否可空:False)
 objgs_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot(字段类型:bit,字段长度:1,是否可空:True)
 objgs_StructureChartNodeEN.Expanded = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.Expanded].ToString().Trim()); //扩大(字段类型:bit,字段长度:1,是否可空:True)
 objgs_StructureChartNodeEN.Direction = objRow[congs_StructureChartNode.Direction] == DBNull.Value ? null : objRow[congs_StructureChartNode.Direction].ToString().Trim(); //方向(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_StructureChartNodeEN.BgColor = objRow[congs_StructureChartNode.BgColor] == DBNull.Value ? null : objRow[congs_StructureChartNode.BgColor].ToString().Trim(); //背景色(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_StructureChartNodeEN.UpdDate = objRow[congs_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_StructureChartNodeEN.UpdUser = objRow[congs_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_StructureChartNodeEN.Memo = objRow[congs_StructureChartNode.Memo] == DBNull.Value ? null : objRow[congs_StructureChartNode.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsgs_StructureChartNodeDA: GetObjBymId)", objException.Message));
}
return objgs_StructureChartNodeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsgs_StructureChartNodeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsgs_StructureChartNodeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from gs_StructureChartNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = new clsgs_StructureChartNodeEN()
{
mId = TransNullToInt(objRow[congs_StructureChartNode.mId].ToString().Trim()), //mId
StructureChartId = objRow[congs_StructureChartNode.StructureChartId].ToString().Trim(), //结构图Id
NodeId = objRow[congs_StructureChartNode.NodeId].ToString().Trim(), //节点Id
NodeTitle = objRow[congs_StructureChartNode.NodeTitle].ToString().Trim(), //节点标题
ParentId = objRow[congs_StructureChartNode.ParentId] == DBNull.Value ? null : objRow[congs_StructureChartNode.ParentId].ToString().Trim(), //父Id
IsRoot = TransNullToBool(objRow[congs_StructureChartNode.IsRoot].ToString().Trim()), //IsRoot
Expanded = TransNullToBool(objRow[congs_StructureChartNode.Expanded].ToString().Trim()), //扩大
Direction = objRow[congs_StructureChartNode.Direction] == DBNull.Value ? null : objRow[congs_StructureChartNode.Direction].ToString().Trim(), //方向
BgColor = objRow[congs_StructureChartNode.BgColor] == DBNull.Value ? null : objRow[congs_StructureChartNode.BgColor].ToString().Trim(), //背景色
UpdDate = objRow[congs_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[congs_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdUser].ToString().Trim(), //修改人
Memo = objRow[congs_StructureChartNode.Memo] == DBNull.Value ? null : objRow[congs_StructureChartNode.Memo].ToString().Trim() //备注
};
objgs_StructureChartNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_StructureChartNodeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsgs_StructureChartNodeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsgs_StructureChartNodeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = new clsgs_StructureChartNodeEN();
try
{
objgs_StructureChartNodeEN.mId = TransNullToInt(objRow[congs_StructureChartNode.mId].ToString().Trim()); //mId
objgs_StructureChartNodeEN.StructureChartId = objRow[congs_StructureChartNode.StructureChartId].ToString().Trim(); //结构图Id
objgs_StructureChartNodeEN.NodeId = objRow[congs_StructureChartNode.NodeId].ToString().Trim(); //节点Id
objgs_StructureChartNodeEN.NodeTitle = objRow[congs_StructureChartNode.NodeTitle].ToString().Trim(); //节点标题
objgs_StructureChartNodeEN.ParentId = objRow[congs_StructureChartNode.ParentId] == DBNull.Value ? null : objRow[congs_StructureChartNode.ParentId].ToString().Trim(); //父Id
objgs_StructureChartNodeEN.IsRoot = TransNullToBool(objRow[congs_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objgs_StructureChartNodeEN.Expanded = TransNullToBool(objRow[congs_StructureChartNode.Expanded].ToString().Trim()); //扩大
objgs_StructureChartNodeEN.Direction = objRow[congs_StructureChartNode.Direction] == DBNull.Value ? null : objRow[congs_StructureChartNode.Direction].ToString().Trim(); //方向
objgs_StructureChartNodeEN.BgColor = objRow[congs_StructureChartNode.BgColor] == DBNull.Value ? null : objRow[congs_StructureChartNode.BgColor].ToString().Trim(); //背景色
objgs_StructureChartNodeEN.UpdDate = objRow[congs_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objgs_StructureChartNodeEN.UpdUser = objRow[congs_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objgs_StructureChartNodeEN.Memo = objRow[congs_StructureChartNode.Memo] == DBNull.Value ? null : objRow[congs_StructureChartNode.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsgs_StructureChartNodeDA: GetObjByDataRowgs_StructureChartNode)", objException.Message));
}
objgs_StructureChartNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_StructureChartNodeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsgs_StructureChartNodeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = new clsgs_StructureChartNodeEN();
try
{
objgs_StructureChartNodeEN.mId = TransNullToInt(objRow[congs_StructureChartNode.mId].ToString().Trim()); //mId
objgs_StructureChartNodeEN.StructureChartId = objRow[congs_StructureChartNode.StructureChartId].ToString().Trim(); //结构图Id
objgs_StructureChartNodeEN.NodeId = objRow[congs_StructureChartNode.NodeId].ToString().Trim(); //节点Id
objgs_StructureChartNodeEN.NodeTitle = objRow[congs_StructureChartNode.NodeTitle].ToString().Trim(); //节点标题
objgs_StructureChartNodeEN.ParentId = objRow[congs_StructureChartNode.ParentId] == DBNull.Value ? null : objRow[congs_StructureChartNode.ParentId].ToString().Trim(); //父Id
objgs_StructureChartNodeEN.IsRoot = TransNullToBool(objRow[congs_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objgs_StructureChartNodeEN.Expanded = TransNullToBool(objRow[congs_StructureChartNode.Expanded].ToString().Trim()); //扩大
objgs_StructureChartNodeEN.Direction = objRow[congs_StructureChartNode.Direction] == DBNull.Value ? null : objRow[congs_StructureChartNode.Direction].ToString().Trim(); //方向
objgs_StructureChartNodeEN.BgColor = objRow[congs_StructureChartNode.BgColor] == DBNull.Value ? null : objRow[congs_StructureChartNode.BgColor].ToString().Trim(); //背景色
objgs_StructureChartNodeEN.UpdDate = objRow[congs_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objgs_StructureChartNodeEN.UpdUser = objRow[congs_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objgs_StructureChartNodeEN.Memo = objRow[congs_StructureChartNode.Memo] == DBNull.Value ? null : objRow[congs_StructureChartNode.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsgs_StructureChartNodeDA: GetObjByDataRow)", objException.Message));
}
objgs_StructureChartNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_StructureChartNodeEN;
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
objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_StructureChartNodeEN._CurrTabName, congs_StructureChartNode.mId, 8, "");
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
objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_StructureChartNodeEN._CurrTabName, congs_StructureChartNode.mId, 8, strPrefix);
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
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from gs_StructureChartNode where " + strCondition;
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
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from gs_StructureChartNode where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_StructureChartNode", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsgs_StructureChartNodeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_StructureChartNode", strCondition))
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
objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("gs_StructureChartNode");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
 {
 if (objgs_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_StructureChartNodeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from gs_StructureChartNode where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_StructureChartNode");
objRow = objDS.Tables["gs_StructureChartNode"].NewRow();
objRow[congs_StructureChartNode.StructureChartId] = objgs_StructureChartNodeEN.StructureChartId; //结构图Id
objRow[congs_StructureChartNode.NodeId] = objgs_StructureChartNodeEN.NodeId; //节点Id
objRow[congs_StructureChartNode.NodeTitle] = objgs_StructureChartNodeEN.NodeTitle; //节点标题
 if (objgs_StructureChartNodeEN.ParentId !=  "")
 {
objRow[congs_StructureChartNode.ParentId] = objgs_StructureChartNodeEN.ParentId; //父Id
 }
objRow[congs_StructureChartNode.IsRoot] = objgs_StructureChartNodeEN.IsRoot; //IsRoot
objRow[congs_StructureChartNode.Expanded] = objgs_StructureChartNodeEN.Expanded; //扩大
 if (objgs_StructureChartNodeEN.Direction !=  "")
 {
objRow[congs_StructureChartNode.Direction] = objgs_StructureChartNodeEN.Direction; //方向
 }
 if (objgs_StructureChartNodeEN.BgColor !=  "")
 {
objRow[congs_StructureChartNode.BgColor] = objgs_StructureChartNodeEN.BgColor; //背景色
 }
 if (objgs_StructureChartNodeEN.UpdDate !=  "")
 {
objRow[congs_StructureChartNode.UpdDate] = objgs_StructureChartNodeEN.UpdDate; //修改日期
 }
 if (objgs_StructureChartNodeEN.UpdUser !=  "")
 {
objRow[congs_StructureChartNode.UpdUser] = objgs_StructureChartNodeEN.UpdUser; //修改人
 }
 if (objgs_StructureChartNodeEN.Memo !=  "")
 {
objRow[congs_StructureChartNode.Memo] = objgs_StructureChartNodeEN.Memo; //备注
 }
objDS.Tables[clsgs_StructureChartNodeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsgs_StructureChartNodeEN._CurrTabName);
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
 /// <param name = "objgs_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
 if (objgs_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_StructureChartNodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_StructureChartNodeEN.StructureChartId !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.StructureChartId);
 var strStructureChartId = objgs_StructureChartNodeEN.StructureChartId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureChartId + "'");
 }
 
 if (objgs_StructureChartNodeEN.NodeId !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.NodeId);
 var strNodeId = objgs_StructureChartNodeEN.NodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNodeId + "'");
 }
 
 if (objgs_StructureChartNodeEN.NodeTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.NodeTitle);
 var strNodeTitle = objgs_StructureChartNodeEN.NodeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNodeTitle + "'");
 }
 
 if (objgs_StructureChartNodeEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.ParentId);
 var strParentId = objgs_StructureChartNodeEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 arrFieldListForInsert.Add(congs_StructureChartNode.IsRoot);
 arrValueListForInsert.Add("'" + (objgs_StructureChartNodeEN.IsRoot  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_StructureChartNode.Expanded);
 arrValueListForInsert.Add("'" + (objgs_StructureChartNodeEN.Expanded  ==  false ? "0" : "1") + "'");
 
 if (objgs_StructureChartNodeEN.Direction !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.Direction);
 var strDirection = objgs_StructureChartNodeEN.Direction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDirection + "'");
 }
 
 if (objgs_StructureChartNodeEN.BgColor !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.BgColor);
 var strBgColor = objgs_StructureChartNodeEN.BgColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBgColor + "'");
 }
 
 if (objgs_StructureChartNodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.UpdDate);
 var strUpdDate = objgs_StructureChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_StructureChartNodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.UpdUser);
 var strUpdUser = objgs_StructureChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_StructureChartNodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.Memo);
 var strMemo = objgs_StructureChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_StructureChartNode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
 if (objgs_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_StructureChartNodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_StructureChartNodeEN.StructureChartId !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.StructureChartId);
 var strStructureChartId = objgs_StructureChartNodeEN.StructureChartId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureChartId + "'");
 }
 
 if (objgs_StructureChartNodeEN.NodeId !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.NodeId);
 var strNodeId = objgs_StructureChartNodeEN.NodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNodeId + "'");
 }
 
 if (objgs_StructureChartNodeEN.NodeTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.NodeTitle);
 var strNodeTitle = objgs_StructureChartNodeEN.NodeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNodeTitle + "'");
 }
 
 if (objgs_StructureChartNodeEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.ParentId);
 var strParentId = objgs_StructureChartNodeEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 arrFieldListForInsert.Add(congs_StructureChartNode.IsRoot);
 arrValueListForInsert.Add("'" + (objgs_StructureChartNodeEN.IsRoot  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_StructureChartNode.Expanded);
 arrValueListForInsert.Add("'" + (objgs_StructureChartNodeEN.Expanded  ==  false ? "0" : "1") + "'");
 
 if (objgs_StructureChartNodeEN.Direction !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.Direction);
 var strDirection = objgs_StructureChartNodeEN.Direction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDirection + "'");
 }
 
 if (objgs_StructureChartNodeEN.BgColor !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.BgColor);
 var strBgColor = objgs_StructureChartNodeEN.BgColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBgColor + "'");
 }
 
 if (objgs_StructureChartNodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.UpdDate);
 var strUpdDate = objgs_StructureChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_StructureChartNodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.UpdUser);
 var strUpdUser = objgs_StructureChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_StructureChartNodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.Memo);
 var strMemo = objgs_StructureChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_StructureChartNode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_StructureChartNodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_StructureChartNodeEN.StructureChartId !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.StructureChartId);
 var strStructureChartId = objgs_StructureChartNodeEN.StructureChartId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureChartId + "'");
 }
 
 if (objgs_StructureChartNodeEN.NodeId !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.NodeId);
 var strNodeId = objgs_StructureChartNodeEN.NodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNodeId + "'");
 }
 
 if (objgs_StructureChartNodeEN.NodeTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.NodeTitle);
 var strNodeTitle = objgs_StructureChartNodeEN.NodeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNodeTitle + "'");
 }
 
 if (objgs_StructureChartNodeEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.ParentId);
 var strParentId = objgs_StructureChartNodeEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 arrFieldListForInsert.Add(congs_StructureChartNode.IsRoot);
 arrValueListForInsert.Add("'" + (objgs_StructureChartNodeEN.IsRoot  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_StructureChartNode.Expanded);
 arrValueListForInsert.Add("'" + (objgs_StructureChartNodeEN.Expanded  ==  false ? "0" : "1") + "'");
 
 if (objgs_StructureChartNodeEN.Direction !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.Direction);
 var strDirection = objgs_StructureChartNodeEN.Direction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDirection + "'");
 }
 
 if (objgs_StructureChartNodeEN.BgColor !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.BgColor);
 var strBgColor = objgs_StructureChartNodeEN.BgColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBgColor + "'");
 }
 
 if (objgs_StructureChartNodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.UpdDate);
 var strUpdDate = objgs_StructureChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_StructureChartNodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.UpdUser);
 var strUpdUser = objgs_StructureChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_StructureChartNodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.Memo);
 var strMemo = objgs_StructureChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_StructureChartNode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_StructureChartNodeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_StructureChartNodeEN.StructureChartId !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.StructureChartId);
 var strStructureChartId = objgs_StructureChartNodeEN.StructureChartId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureChartId + "'");
 }
 
 if (objgs_StructureChartNodeEN.NodeId !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.NodeId);
 var strNodeId = objgs_StructureChartNodeEN.NodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNodeId + "'");
 }
 
 if (objgs_StructureChartNodeEN.NodeTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.NodeTitle);
 var strNodeTitle = objgs_StructureChartNodeEN.NodeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNodeTitle + "'");
 }
 
 if (objgs_StructureChartNodeEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.ParentId);
 var strParentId = objgs_StructureChartNodeEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 arrFieldListForInsert.Add(congs_StructureChartNode.IsRoot);
 arrValueListForInsert.Add("'" + (objgs_StructureChartNodeEN.IsRoot  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_StructureChartNode.Expanded);
 arrValueListForInsert.Add("'" + (objgs_StructureChartNodeEN.Expanded  ==  false ? "0" : "1") + "'");
 
 if (objgs_StructureChartNodeEN.Direction !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.Direction);
 var strDirection = objgs_StructureChartNodeEN.Direction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDirection + "'");
 }
 
 if (objgs_StructureChartNodeEN.BgColor !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.BgColor);
 var strBgColor = objgs_StructureChartNodeEN.BgColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBgColor + "'");
 }
 
 if (objgs_StructureChartNodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.UpdDate);
 var strUpdDate = objgs_StructureChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_StructureChartNodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.UpdUser);
 var strUpdUser = objgs_StructureChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_StructureChartNodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_StructureChartNode.Memo);
 var strMemo = objgs_StructureChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_StructureChartNode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewgs_StructureChartNodes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from gs_StructureChartNode where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_StructureChartNode");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsgs_StructureChartNodeEN._CurrTabName ].NewRow();
objRow[congs_StructureChartNode.StructureChartId] = oRow[congs_StructureChartNode.StructureChartId].ToString().Trim(); //结构图Id
objRow[congs_StructureChartNode.NodeId] = oRow[congs_StructureChartNode.NodeId].ToString().Trim(); //节点Id
objRow[congs_StructureChartNode.NodeTitle] = oRow[congs_StructureChartNode.NodeTitle].ToString().Trim(); //节点标题
objRow[congs_StructureChartNode.ParentId] = oRow[congs_StructureChartNode.ParentId].ToString().Trim(); //父Id
objRow[congs_StructureChartNode.IsRoot] = oRow[congs_StructureChartNode.IsRoot].ToString().Trim(); //IsRoot
objRow[congs_StructureChartNode.Expanded] = oRow[congs_StructureChartNode.Expanded].ToString().Trim(); //扩大
objRow[congs_StructureChartNode.Direction] = oRow[congs_StructureChartNode.Direction].ToString().Trim(); //方向
objRow[congs_StructureChartNode.BgColor] = oRow[congs_StructureChartNode.BgColor].ToString().Trim(); //背景色
objRow[congs_StructureChartNode.UpdDate] = oRow[congs_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objRow[congs_StructureChartNode.UpdUser] = oRow[congs_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objRow[congs_StructureChartNode.Memo] = oRow[congs_StructureChartNode.Memo].ToString().Trim(); //备注
 objDS.Tables[clsgs_StructureChartNodeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsgs_StructureChartNodeEN._CurrTabName);
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
 /// <param name = "objgs_StructureChartNodeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
 if (objgs_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_StructureChartNodeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
strSQL = "Select * from gs_StructureChartNode where mId = " + ""+ objgs_StructureChartNodeEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsgs_StructureChartNodeEN._CurrTabName);
if (objDS.Tables[clsgs_StructureChartNodeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objgs_StructureChartNodeEN.mId+"");
return false;
}
objRow = objDS.Tables[clsgs_StructureChartNodeEN._CurrTabName].Rows[0];
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.StructureChartId))
 {
objRow[congs_StructureChartNode.StructureChartId] = objgs_StructureChartNodeEN.StructureChartId; //结构图Id
 }
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.NodeId))
 {
objRow[congs_StructureChartNode.NodeId] = objgs_StructureChartNodeEN.NodeId; //节点Id
 }
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.NodeTitle))
 {
objRow[congs_StructureChartNode.NodeTitle] = objgs_StructureChartNodeEN.NodeTitle; //节点标题
 }
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.ParentId))
 {
objRow[congs_StructureChartNode.ParentId] = objgs_StructureChartNodeEN.ParentId; //父Id
 }
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.IsRoot))
 {
objRow[congs_StructureChartNode.IsRoot] = objgs_StructureChartNodeEN.IsRoot; //IsRoot
 }
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.Expanded))
 {
objRow[congs_StructureChartNode.Expanded] = objgs_StructureChartNodeEN.Expanded; //扩大
 }
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.Direction))
 {
objRow[congs_StructureChartNode.Direction] = objgs_StructureChartNodeEN.Direction; //方向
 }
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.BgColor))
 {
objRow[congs_StructureChartNode.BgColor] = objgs_StructureChartNodeEN.BgColor; //背景色
 }
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.UpdDate))
 {
objRow[congs_StructureChartNode.UpdDate] = objgs_StructureChartNodeEN.UpdDate; //修改日期
 }
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.UpdUser))
 {
objRow[congs_StructureChartNode.UpdUser] = objgs_StructureChartNodeEN.UpdUser; //修改人
 }
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.Memo))
 {
objRow[congs_StructureChartNode.Memo] = objgs_StructureChartNodeEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsgs_StructureChartNodeEN._CurrTabName);
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
 /// <param name = "objgs_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
 if (objgs_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_StructureChartNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update gs_StructureChartNode Set ");
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.StructureChartId))
 {
 if (objgs_StructureChartNodeEN.StructureChartId !=  null)
 {
 var strStructureChartId = objgs_StructureChartNodeEN.StructureChartId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStructureChartId, congs_StructureChartNode.StructureChartId); //结构图Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.StructureChartId); //结构图Id
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.NodeId))
 {
 if (objgs_StructureChartNodeEN.NodeId !=  null)
 {
 var strNodeId = objgs_StructureChartNodeEN.NodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNodeId, congs_StructureChartNode.NodeId); //节点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.NodeId); //节点Id
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.NodeTitle))
 {
 if (objgs_StructureChartNodeEN.NodeTitle !=  null)
 {
 var strNodeTitle = objgs_StructureChartNodeEN.NodeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNodeTitle, congs_StructureChartNode.NodeTitle); //节点标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.NodeTitle); //节点标题
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.ParentId))
 {
 if (objgs_StructureChartNodeEN.ParentId !=  null)
 {
 var strParentId = objgs_StructureChartNodeEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, congs_StructureChartNode.ParentId); //父Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.ParentId); //父Id
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.IsRoot))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_StructureChartNodeEN.IsRoot == true?"1":"0", congs_StructureChartNode.IsRoot); //IsRoot
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.Expanded))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_StructureChartNodeEN.Expanded == true?"1":"0", congs_StructureChartNode.Expanded); //扩大
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.Direction))
 {
 if (objgs_StructureChartNodeEN.Direction !=  null)
 {
 var strDirection = objgs_StructureChartNodeEN.Direction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDirection, congs_StructureChartNode.Direction); //方向
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.Direction); //方向
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.BgColor))
 {
 if (objgs_StructureChartNodeEN.BgColor !=  null)
 {
 var strBgColor = objgs_StructureChartNodeEN.BgColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBgColor, congs_StructureChartNode.BgColor); //背景色
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.BgColor); //背景色
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.UpdDate))
 {
 if (objgs_StructureChartNodeEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_StructureChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_StructureChartNode.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.UpdDate); //修改日期
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.UpdUser))
 {
 if (objgs_StructureChartNodeEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_StructureChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_StructureChartNode.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.UpdUser); //修改人
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.Memo))
 {
 if (objgs_StructureChartNodeEN.Memo !=  null)
 {
 var strMemo = objgs_StructureChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_StructureChartNode.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objgs_StructureChartNodeEN.mId); 
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
 /// <param name = "objgs_StructureChartNodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, string strCondition)
{
 if (objgs_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_StructureChartNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_StructureChartNode Set ");
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.StructureChartId))
 {
 if (objgs_StructureChartNodeEN.StructureChartId !=  null)
 {
 var strStructureChartId = objgs_StructureChartNodeEN.StructureChartId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StructureChartId = '{0}',", strStructureChartId); //结构图Id
 }
 else
 {
 sbSQL.Append(" StructureChartId = null,"); //结构图Id
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.NodeId))
 {
 if (objgs_StructureChartNodeEN.NodeId !=  null)
 {
 var strNodeId = objgs_StructureChartNodeEN.NodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NodeId = '{0}',", strNodeId); //节点Id
 }
 else
 {
 sbSQL.Append(" NodeId = null,"); //节点Id
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.NodeTitle))
 {
 if (objgs_StructureChartNodeEN.NodeTitle !=  null)
 {
 var strNodeTitle = objgs_StructureChartNodeEN.NodeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NodeTitle = '{0}',", strNodeTitle); //节点标题
 }
 else
 {
 sbSQL.Append(" NodeTitle = null,"); //节点标题
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.ParentId))
 {
 if (objgs_StructureChartNodeEN.ParentId !=  null)
 {
 var strParentId = objgs_StructureChartNodeEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父Id
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.IsRoot))
 {
 sbSQL.AppendFormat(" IsRoot = '{0}',", objgs_StructureChartNodeEN.IsRoot == true?"1":"0"); //IsRoot
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.Expanded))
 {
 sbSQL.AppendFormat(" Expanded = '{0}',", objgs_StructureChartNodeEN.Expanded == true?"1":"0"); //扩大
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.Direction))
 {
 if (objgs_StructureChartNodeEN.Direction !=  null)
 {
 var strDirection = objgs_StructureChartNodeEN.Direction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Direction = '{0}',", strDirection); //方向
 }
 else
 {
 sbSQL.Append(" Direction = null,"); //方向
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.BgColor))
 {
 if (objgs_StructureChartNodeEN.BgColor !=  null)
 {
 var strBgColor = objgs_StructureChartNodeEN.BgColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BgColor = '{0}',", strBgColor); //背景色
 }
 else
 {
 sbSQL.Append(" BgColor = null,"); //背景色
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.UpdDate))
 {
 if (objgs_StructureChartNodeEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_StructureChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.UpdUser))
 {
 if (objgs_StructureChartNodeEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_StructureChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.Memo))
 {
 if (objgs_StructureChartNodeEN.Memo !=  null)
 {
 var strMemo = objgs_StructureChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objgs_StructureChartNodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_StructureChartNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_StructureChartNode Set ");
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.StructureChartId))
 {
 if (objgs_StructureChartNodeEN.StructureChartId !=  null)
 {
 var strStructureChartId = objgs_StructureChartNodeEN.StructureChartId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StructureChartId = '{0}',", strStructureChartId); //结构图Id
 }
 else
 {
 sbSQL.Append(" StructureChartId = null,"); //结构图Id
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.NodeId))
 {
 if (objgs_StructureChartNodeEN.NodeId !=  null)
 {
 var strNodeId = objgs_StructureChartNodeEN.NodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NodeId = '{0}',", strNodeId); //节点Id
 }
 else
 {
 sbSQL.Append(" NodeId = null,"); //节点Id
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.NodeTitle))
 {
 if (objgs_StructureChartNodeEN.NodeTitle !=  null)
 {
 var strNodeTitle = objgs_StructureChartNodeEN.NodeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NodeTitle = '{0}',", strNodeTitle); //节点标题
 }
 else
 {
 sbSQL.Append(" NodeTitle = null,"); //节点标题
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.ParentId))
 {
 if (objgs_StructureChartNodeEN.ParentId !=  null)
 {
 var strParentId = objgs_StructureChartNodeEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父Id
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.IsRoot))
 {
 sbSQL.AppendFormat(" IsRoot = '{0}',", objgs_StructureChartNodeEN.IsRoot == true?"1":"0"); //IsRoot
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.Expanded))
 {
 sbSQL.AppendFormat(" Expanded = '{0}',", objgs_StructureChartNodeEN.Expanded == true?"1":"0"); //扩大
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.Direction))
 {
 if (objgs_StructureChartNodeEN.Direction !=  null)
 {
 var strDirection = objgs_StructureChartNodeEN.Direction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Direction = '{0}',", strDirection); //方向
 }
 else
 {
 sbSQL.Append(" Direction = null,"); //方向
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.BgColor))
 {
 if (objgs_StructureChartNodeEN.BgColor !=  null)
 {
 var strBgColor = objgs_StructureChartNodeEN.BgColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BgColor = '{0}',", strBgColor); //背景色
 }
 else
 {
 sbSQL.Append(" BgColor = null,"); //背景色
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.UpdDate))
 {
 if (objgs_StructureChartNodeEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_StructureChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.UpdUser))
 {
 if (objgs_StructureChartNodeEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_StructureChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.Memo))
 {
 if (objgs_StructureChartNodeEN.Memo !=  null)
 {
 var strMemo = objgs_StructureChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objgs_StructureChartNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_StructureChartNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_StructureChartNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_StructureChartNode Set ");
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.StructureChartId))
 {
 if (objgs_StructureChartNodeEN.StructureChartId !=  null)
 {
 var strStructureChartId = objgs_StructureChartNodeEN.StructureChartId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStructureChartId, congs_StructureChartNode.StructureChartId); //结构图Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.StructureChartId); //结构图Id
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.NodeId))
 {
 if (objgs_StructureChartNodeEN.NodeId !=  null)
 {
 var strNodeId = objgs_StructureChartNodeEN.NodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNodeId, congs_StructureChartNode.NodeId); //节点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.NodeId); //节点Id
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.NodeTitle))
 {
 if (objgs_StructureChartNodeEN.NodeTitle !=  null)
 {
 var strNodeTitle = objgs_StructureChartNodeEN.NodeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNodeTitle, congs_StructureChartNode.NodeTitle); //节点标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.NodeTitle); //节点标题
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.ParentId))
 {
 if (objgs_StructureChartNodeEN.ParentId !=  null)
 {
 var strParentId = objgs_StructureChartNodeEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, congs_StructureChartNode.ParentId); //父Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.ParentId); //父Id
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.IsRoot))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_StructureChartNodeEN.IsRoot == true?"1":"0", congs_StructureChartNode.IsRoot); //IsRoot
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.Expanded))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_StructureChartNodeEN.Expanded == true?"1":"0", congs_StructureChartNode.Expanded); //扩大
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.Direction))
 {
 if (objgs_StructureChartNodeEN.Direction !=  null)
 {
 var strDirection = objgs_StructureChartNodeEN.Direction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDirection, congs_StructureChartNode.Direction); //方向
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.Direction); //方向
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.BgColor))
 {
 if (objgs_StructureChartNodeEN.BgColor !=  null)
 {
 var strBgColor = objgs_StructureChartNodeEN.BgColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBgColor, congs_StructureChartNode.BgColor); //背景色
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.BgColor); //背景色
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.UpdDate))
 {
 if (objgs_StructureChartNodeEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_StructureChartNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_StructureChartNode.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.UpdDate); //修改日期
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.UpdUser))
 {
 if (objgs_StructureChartNodeEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_StructureChartNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_StructureChartNode.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.UpdUser); //修改人
 }
 }
 
 if (objgs_StructureChartNodeEN.IsUpdated(congs_StructureChartNode.Memo))
 {
 if (objgs_StructureChartNodeEN.Memo !=  null)
 {
 var strMemo = objgs_StructureChartNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_StructureChartNode.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_StructureChartNode.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objgs_StructureChartNodeEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("gs_StructureChartNode_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
//删除gs_StructureChartNode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_StructureChartNode where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delgs_StructureChartNode(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
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
//删除gs_StructureChartNode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_StructureChartNode where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
//删除gs_StructureChartNode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_StructureChartNode where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delgs_StructureChartNode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsgs_StructureChartNodeDA: Delgs_StructureChartNode)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_StructureChartNode where " + strCondition ;
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
public bool Delgs_StructureChartNodeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsgs_StructureChartNodeDA: Delgs_StructureChartNodeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_StructureChartNode where " + strCondition ;
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
 /// <param name = "objgs_StructureChartNodeENS">源对象</param>
 /// <param name = "objgs_StructureChartNodeENT">目标对象</param>
public void CopyTo(clsgs_StructureChartNodeEN objgs_StructureChartNodeENS, clsgs_StructureChartNodeEN objgs_StructureChartNodeENT)
{
objgs_StructureChartNodeENT.mId = objgs_StructureChartNodeENS.mId; //mId
objgs_StructureChartNodeENT.StructureChartId = objgs_StructureChartNodeENS.StructureChartId; //结构图Id
objgs_StructureChartNodeENT.NodeId = objgs_StructureChartNodeENS.NodeId; //节点Id
objgs_StructureChartNodeENT.NodeTitle = objgs_StructureChartNodeENS.NodeTitle; //节点标题
objgs_StructureChartNodeENT.ParentId = objgs_StructureChartNodeENS.ParentId; //父Id
objgs_StructureChartNodeENT.IsRoot = objgs_StructureChartNodeENS.IsRoot; //IsRoot
objgs_StructureChartNodeENT.Expanded = objgs_StructureChartNodeENS.Expanded; //扩大
objgs_StructureChartNodeENT.Direction = objgs_StructureChartNodeENS.Direction; //方向
objgs_StructureChartNodeENT.BgColor = objgs_StructureChartNodeENS.BgColor; //背景色
objgs_StructureChartNodeENT.UpdDate = objgs_StructureChartNodeENS.UpdDate; //修改日期
objgs_StructureChartNodeENT.UpdUser = objgs_StructureChartNodeENS.UpdUser; //修改人
objgs_StructureChartNodeENT.Memo = objgs_StructureChartNodeENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objgs_StructureChartNodeEN.StructureChartId, congs_StructureChartNode.StructureChartId);
clsCheckSql.CheckFieldNotNull(objgs_StructureChartNodeEN.NodeId, congs_StructureChartNode.NodeId);
clsCheckSql.CheckFieldNotNull(objgs_StructureChartNodeEN.NodeTitle, congs_StructureChartNode.NodeTitle);
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.StructureChartId, 10, congs_StructureChartNode.StructureChartId);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.NodeId, 20, congs_StructureChartNode.NodeId);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.NodeTitle, 100, congs_StructureChartNode.NodeTitle);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.ParentId, 20, congs_StructureChartNode.ParentId);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.Direction, 50, congs_StructureChartNode.Direction);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.BgColor, 50, congs_StructureChartNode.BgColor);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.UpdDate, 20, congs_StructureChartNode.UpdDate);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.UpdUser, 20, congs_StructureChartNode.UpdUser);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.Memo, 1000, congs_StructureChartNode.Memo);
//检查字段外键固定长度
 objgs_StructureChartNodeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.StructureChartId, 10, congs_StructureChartNode.StructureChartId);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.NodeId, 20, congs_StructureChartNode.NodeId);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.NodeTitle, 100, congs_StructureChartNode.NodeTitle);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.ParentId, 20, congs_StructureChartNode.ParentId);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.Direction, 50, congs_StructureChartNode.Direction);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.BgColor, 50, congs_StructureChartNode.BgColor);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.UpdDate, 20, congs_StructureChartNode.UpdDate);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.UpdUser, 20, congs_StructureChartNode.UpdUser);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.Memo, 1000, congs_StructureChartNode.Memo);
//检查外键字段长度
 objgs_StructureChartNodeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.StructureChartId, 10, congs_StructureChartNode.StructureChartId);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.NodeId, 20, congs_StructureChartNode.NodeId);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.NodeTitle, 100, congs_StructureChartNode.NodeTitle);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.ParentId, 20, congs_StructureChartNode.ParentId);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.Direction, 50, congs_StructureChartNode.Direction);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.BgColor, 50, congs_StructureChartNode.BgColor);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.UpdDate, 20, congs_StructureChartNode.UpdDate);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.UpdUser, 20, congs_StructureChartNode.UpdUser);
clsCheckSql.CheckFieldLen(objgs_StructureChartNodeEN.Memo, 1000, congs_StructureChartNode.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objgs_StructureChartNodeEN.StructureChartId, congs_StructureChartNode.StructureChartId);
clsCheckSql.CheckSqlInjection4Field(objgs_StructureChartNodeEN.NodeId, congs_StructureChartNode.NodeId);
clsCheckSql.CheckSqlInjection4Field(objgs_StructureChartNodeEN.NodeTitle, congs_StructureChartNode.NodeTitle);
clsCheckSql.CheckSqlInjection4Field(objgs_StructureChartNodeEN.ParentId, congs_StructureChartNode.ParentId);
clsCheckSql.CheckSqlInjection4Field(objgs_StructureChartNodeEN.Direction, congs_StructureChartNode.Direction);
clsCheckSql.CheckSqlInjection4Field(objgs_StructureChartNodeEN.BgColor, congs_StructureChartNode.BgColor);
clsCheckSql.CheckSqlInjection4Field(objgs_StructureChartNodeEN.UpdDate, congs_StructureChartNode.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objgs_StructureChartNodeEN.UpdUser, congs_StructureChartNode.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objgs_StructureChartNodeEN.Memo, congs_StructureChartNode.Memo);
//检查外键字段长度
 objgs_StructureChartNodeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--gs_StructureChartNode(结构图节点),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_StructureChartNodeEN.mId);
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
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
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
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
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
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_StructureChartNodeEN._CurrTabName);
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
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_StructureChartNodeEN._CurrTabName, strCondition);
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
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
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
 objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}