
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_KnowledgesGraphDA
 表名:gs_KnowledgesGraph(01120873)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:44
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
 /// 知识点逻辑图(gs_KnowledgesGraph)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsgs_KnowledgesGraphDA : clsCommBase4DA
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
 return clsgs_KnowledgesGraphEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsgs_KnowledgesGraphEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_KnowledgesGraphEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsgs_KnowledgesGraphEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsgs_KnowledgesGraphEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strKnowledgeGraphId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strKnowledgeGraphId)
{
strKnowledgeGraphId = strKnowledgeGraphId.Replace("'", "''");
if (strKnowledgeGraphId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:gs_KnowledgesGraph中,检查关键字,长度不正确!(clsgs_KnowledgesGraphDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strKnowledgeGraphId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:gs_KnowledgesGraph中,关键字不能为空 或 null!(clsgs_KnowledgesGraphDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strKnowledgeGraphId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsgs_KnowledgesGraphDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsgs_KnowledgesGraphDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesGraph where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_gs_KnowledgesGraph(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsgs_KnowledgesGraphDA: GetDataTable_gs_KnowledgesGraph)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesGraph where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsgs_KnowledgesGraphDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsgs_KnowledgesGraphDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesGraph where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsgs_KnowledgesGraphDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsgs_KnowledgesGraphDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_KnowledgesGraph where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_KnowledgesGraph where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsgs_KnowledgesGraphDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from gs_KnowledgesGraph where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsgs_KnowledgesGraphDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_KnowledgesGraph.* from gs_KnowledgesGraph Left Join {1} on {2} where {3} and gs_KnowledgesGraph.KnowledgeGraphId not in (Select top {5} gs_KnowledgesGraph.KnowledgeGraphId from gs_KnowledgesGraph Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_KnowledgesGraph where {1} and KnowledgeGraphId not in (Select top {2} KnowledgeGraphId from gs_KnowledgesGraph where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_KnowledgesGraph where {1} and KnowledgeGraphId not in (Select top {3} KnowledgeGraphId from gs_KnowledgesGraph where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsgs_KnowledgesGraphDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_KnowledgesGraph.* from gs_KnowledgesGraph Left Join {1} on {2} where {3} and gs_KnowledgesGraph.KnowledgeGraphId not in (Select top {5} gs_KnowledgesGraph.KnowledgeGraphId from gs_KnowledgesGraph Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_KnowledgesGraph where {1} and KnowledgeGraphId not in (Select top {2} KnowledgeGraphId from gs_KnowledgesGraph where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_KnowledgesGraph where {1} and KnowledgeGraphId not in (Select top {3} KnowledgeGraphId from gs_KnowledgesGraph where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsgs_KnowledgesGraphEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsgs_KnowledgesGraphDA:GetObjLst)", objException.Message));
}
List<clsgs_KnowledgesGraphEN> arrObjLst = new List<clsgs_KnowledgesGraphEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesGraph where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
try
{
objgs_KnowledgesGraphEN.KnowledgeGraphId = objRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesGraphEN.KnowledgeGraphName = objRow[congs_KnowledgesGraph.KnowledgeGraphName] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(); //连连看图名
objgs_KnowledgesGraphEN.IdCurrEduCls = objRow[congs_KnowledgesGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_KnowledgesGraphEN.CourseId = objRow[congs_KnowledgesGraph.CourseId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesGraphEN.CreateUser = objRow[congs_KnowledgesGraph.CreateUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CreateUser].ToString().Trim(); //建立用户
objgs_KnowledgesGraphEN.UpdDate = objRow[congs_KnowledgesGraph.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesGraphEN.UpdUser = objRow[congs_KnowledgesGraph.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesGraphEN.Memo = objRow[congs_KnowledgesGraph.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.Memo].ToString().Trim(); //备注
objgs_KnowledgesGraphEN.GraphTypeId = objRow[congs_KnowledgesGraph.GraphTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphEN.IsDisplay = TransNullToBool(objRow[congs_KnowledgesGraph.IsDisplay].ToString().Trim()); //是否显示
objgs_KnowledgesGraphEN.IsExtend = TransNullToBool(objRow[congs_KnowledgesGraph.IsExtend].ToString().Trim()); //是否扩展
objgs_KnowledgesGraphEN.IsRecommend = TransNullToBool(objRow[congs_KnowledgesGraph.IsRecommend].ToString().Trim()); //是否推荐
objgs_KnowledgesGraphEN.IsAnswer = TransNullToBool(objRow[congs_KnowledgesGraph.IsAnswer].ToString().Trim()); //是否回答
objgs_KnowledgesGraphEN.IsSubmit = TransNullToBool(objRow[congs_KnowledgesGraph.IsSubmit].ToString().Trim()); //是否提交
objgs_KnowledgesGraphEN.StartTime = objRow[congs_KnowledgesGraph.StartTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.StartTime].ToString().Trim(); //开始时间
objgs_KnowledgesGraphEN.SubmitTime = objRow[congs_KnowledgesGraph.SubmitTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.SubmitTime].ToString().Trim(); //提交时间
objgs_KnowledgesGraphEN.TakeUpTime = objRow[congs_KnowledgesGraph.TakeUpTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.TakeUpTime].ToString().Trim(); //耗时
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_KnowledgesGraphDA: GetObjLst)", objException.Message));
}
objgs_KnowledgesGraphEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_KnowledgesGraphEN);
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
public List<clsgs_KnowledgesGraphEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsgs_KnowledgesGraphDA:GetObjLstByTabName)", objException.Message));
}
List<clsgs_KnowledgesGraphEN> arrObjLst = new List<clsgs_KnowledgesGraphEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
try
{
objgs_KnowledgesGraphEN.KnowledgeGraphId = objRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesGraphEN.KnowledgeGraphName = objRow[congs_KnowledgesGraph.KnowledgeGraphName] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(); //连连看图名
objgs_KnowledgesGraphEN.IdCurrEduCls = objRow[congs_KnowledgesGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_KnowledgesGraphEN.CourseId = objRow[congs_KnowledgesGraph.CourseId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesGraphEN.CreateUser = objRow[congs_KnowledgesGraph.CreateUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CreateUser].ToString().Trim(); //建立用户
objgs_KnowledgesGraphEN.UpdDate = objRow[congs_KnowledgesGraph.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesGraphEN.UpdUser = objRow[congs_KnowledgesGraph.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesGraphEN.Memo = objRow[congs_KnowledgesGraph.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.Memo].ToString().Trim(); //备注
objgs_KnowledgesGraphEN.GraphTypeId = objRow[congs_KnowledgesGraph.GraphTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphEN.IsDisplay = TransNullToBool(objRow[congs_KnowledgesGraph.IsDisplay].ToString().Trim()); //是否显示
objgs_KnowledgesGraphEN.IsExtend = TransNullToBool(objRow[congs_KnowledgesGraph.IsExtend].ToString().Trim()); //是否扩展
objgs_KnowledgesGraphEN.IsRecommend = TransNullToBool(objRow[congs_KnowledgesGraph.IsRecommend].ToString().Trim()); //是否推荐
objgs_KnowledgesGraphEN.IsAnswer = TransNullToBool(objRow[congs_KnowledgesGraph.IsAnswer].ToString().Trim()); //是否回答
objgs_KnowledgesGraphEN.IsSubmit = TransNullToBool(objRow[congs_KnowledgesGraph.IsSubmit].ToString().Trim()); //是否提交
objgs_KnowledgesGraphEN.StartTime = objRow[congs_KnowledgesGraph.StartTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.StartTime].ToString().Trim(); //开始时间
objgs_KnowledgesGraphEN.SubmitTime = objRow[congs_KnowledgesGraph.SubmitTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.SubmitTime].ToString().Trim(); //提交时间
objgs_KnowledgesGraphEN.TakeUpTime = objRow[congs_KnowledgesGraph.TakeUpTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.TakeUpTime].ToString().Trim(); //耗时
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_KnowledgesGraphDA: GetObjLst)", objException.Message));
}
objgs_KnowledgesGraphEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_KnowledgesGraphEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getgs_KnowledgesGraph(ref clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesGraph where KnowledgeGraphId = " + "'"+ objgs_KnowledgesGraphEN.KnowledgeGraphId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objgs_KnowledgesGraphEN.KnowledgeGraphId = objDT.Rows[0][congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(); //知识点图Id(字段类型:char,字段长度:10,是否可空:True)
 objgs_KnowledgesGraphEN.KnowledgeGraphName = objDT.Rows[0][congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(); //连连看图名(字段类型:varchar,字段长度:100,是否可空:True)
 objgs_KnowledgesGraphEN.IdCurrEduCls = objDT.Rows[0][congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objgs_KnowledgesGraphEN.CourseId = objDT.Rows[0][congs_KnowledgesGraph.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_KnowledgesGraphEN.CreateUser = objDT.Rows[0][congs_KnowledgesGraph.CreateUser].ToString().Trim(); //建立用户(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_KnowledgesGraphEN.UpdDate = objDT.Rows[0][congs_KnowledgesGraph.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_KnowledgesGraphEN.UpdUser = objDT.Rows[0][congs_KnowledgesGraph.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_KnowledgesGraphEN.Memo = objDT.Rows[0][congs_KnowledgesGraph.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_KnowledgesGraphEN.GraphTypeId = objDT.Rows[0][congs_KnowledgesGraph.GraphTypeId].ToString().Trim(); //图谱类型Id(字段类型:char,字段长度:2,是否可空:False)
 objgs_KnowledgesGraphEN.IsDisplay = TransNullToBool(objDT.Rows[0][congs_KnowledgesGraph.IsDisplay].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objgs_KnowledgesGraphEN.IsExtend = TransNullToBool(objDT.Rows[0][congs_KnowledgesGraph.IsExtend].ToString().Trim()); //是否扩展(字段类型:bit,字段长度:1,是否可空:True)
 objgs_KnowledgesGraphEN.IsRecommend = TransNullToBool(objDT.Rows[0][congs_KnowledgesGraph.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objgs_KnowledgesGraphEN.IsAnswer = TransNullToBool(objDT.Rows[0][congs_KnowledgesGraph.IsAnswer].ToString().Trim()); //是否回答(字段类型:bit,字段长度:1,是否可空:True)
 objgs_KnowledgesGraphEN.IsSubmit = TransNullToBool(objDT.Rows[0][congs_KnowledgesGraph.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objgs_KnowledgesGraphEN.StartTime = objDT.Rows[0][congs_KnowledgesGraph.StartTime].ToString().Trim(); //开始时间(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_KnowledgesGraphEN.SubmitTime = objDT.Rows[0][congs_KnowledgesGraph.SubmitTime].ToString().Trim(); //提交时间(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_KnowledgesGraphEN.TakeUpTime = objDT.Rows[0][congs_KnowledgesGraph.TakeUpTime].ToString().Trim(); //耗时(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsgs_KnowledgesGraphDA: Getgs_KnowledgesGraph)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strKnowledgeGraphId">表关键字</param>
 /// <returns>表对象</returns>
public clsgs_KnowledgesGraphEN GetObjByKnowledgeGraphId(string strKnowledgeGraphId)
{
CheckPrimaryKey(strKnowledgeGraphId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesGraph where KnowledgeGraphId = " + "'"+ strKnowledgeGraphId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
try
{
 objgs_KnowledgesGraphEN.KnowledgeGraphId = objRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(); //知识点图Id(字段类型:char,字段长度:10,是否可空:True)
 objgs_KnowledgesGraphEN.KnowledgeGraphName = objRow[congs_KnowledgesGraph.KnowledgeGraphName] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(); //连连看图名(字段类型:varchar,字段长度:100,是否可空:True)
 objgs_KnowledgesGraphEN.IdCurrEduCls = objRow[congs_KnowledgesGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objgs_KnowledgesGraphEN.CourseId = objRow[congs_KnowledgesGraph.CourseId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_KnowledgesGraphEN.CreateUser = objRow[congs_KnowledgesGraph.CreateUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CreateUser].ToString().Trim(); //建立用户(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_KnowledgesGraphEN.UpdDate = objRow[congs_KnowledgesGraph.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_KnowledgesGraphEN.UpdUser = objRow[congs_KnowledgesGraph.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_KnowledgesGraphEN.Memo = objRow[congs_KnowledgesGraph.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_KnowledgesGraphEN.GraphTypeId = objRow[congs_KnowledgesGraph.GraphTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.GraphTypeId].ToString().Trim(); //图谱类型Id(字段类型:char,字段长度:2,是否可空:False)
 objgs_KnowledgesGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsDisplay].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objgs_KnowledgesGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsExtend].ToString().Trim()); //是否扩展(字段类型:bit,字段长度:1,是否可空:True)
 objgs_KnowledgesGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objgs_KnowledgesGraphEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsAnswer].ToString().Trim()); //是否回答(字段类型:bit,字段长度:1,是否可空:True)
 objgs_KnowledgesGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objgs_KnowledgesGraphEN.StartTime = objRow[congs_KnowledgesGraph.StartTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.StartTime].ToString().Trim(); //开始时间(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_KnowledgesGraphEN.SubmitTime = objRow[congs_KnowledgesGraph.SubmitTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.SubmitTime].ToString().Trim(); //提交时间(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_KnowledgesGraphEN.TakeUpTime = objRow[congs_KnowledgesGraph.TakeUpTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.TakeUpTime].ToString().Trim(); //耗时(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsgs_KnowledgesGraphDA: GetObjByKnowledgeGraphId)", objException.Message));
}
return objgs_KnowledgesGraphEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsgs_KnowledgesGraphEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsgs_KnowledgesGraphDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesGraph where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN()
{
KnowledgeGraphId = objRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(), //知识点图Id
KnowledgeGraphName = objRow[congs_KnowledgesGraph.KnowledgeGraphName] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(), //连连看图名
IdCurrEduCls = objRow[congs_KnowledgesGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(), //教学班流水号
CourseId = objRow[congs_KnowledgesGraph.CourseId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CourseId].ToString().Trim(), //课程Id
CreateUser = objRow[congs_KnowledgesGraph.CreateUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CreateUser].ToString().Trim(), //建立用户
UpdDate = objRow[congs_KnowledgesGraph.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[congs_KnowledgesGraph.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdUser].ToString().Trim(), //修改人
Memo = objRow[congs_KnowledgesGraph.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.Memo].ToString().Trim(), //备注
GraphTypeId = objRow[congs_KnowledgesGraph.GraphTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.GraphTypeId].ToString().Trim(), //图谱类型Id
IsDisplay = TransNullToBool(objRow[congs_KnowledgesGraph.IsDisplay].ToString().Trim()), //是否显示
IsExtend = TransNullToBool(objRow[congs_KnowledgesGraph.IsExtend].ToString().Trim()), //是否扩展
IsRecommend = TransNullToBool(objRow[congs_KnowledgesGraph.IsRecommend].ToString().Trim()), //是否推荐
IsAnswer = TransNullToBool(objRow[congs_KnowledgesGraph.IsAnswer].ToString().Trim()), //是否回答
IsSubmit = TransNullToBool(objRow[congs_KnowledgesGraph.IsSubmit].ToString().Trim()), //是否提交
StartTime = objRow[congs_KnowledgesGraph.StartTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.StartTime].ToString().Trim(), //开始时间
SubmitTime = objRow[congs_KnowledgesGraph.SubmitTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.SubmitTime].ToString().Trim(), //提交时间
TakeUpTime = objRow[congs_KnowledgesGraph.TakeUpTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.TakeUpTime].ToString().Trim() //耗时
};
objgs_KnowledgesGraphEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_KnowledgesGraphEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsgs_KnowledgesGraphDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsgs_KnowledgesGraphEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
try
{
objgs_KnowledgesGraphEN.KnowledgeGraphId = objRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesGraphEN.KnowledgeGraphName = objRow[congs_KnowledgesGraph.KnowledgeGraphName] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(); //连连看图名
objgs_KnowledgesGraphEN.IdCurrEduCls = objRow[congs_KnowledgesGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_KnowledgesGraphEN.CourseId = objRow[congs_KnowledgesGraph.CourseId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesGraphEN.CreateUser = objRow[congs_KnowledgesGraph.CreateUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CreateUser].ToString().Trim(); //建立用户
objgs_KnowledgesGraphEN.UpdDate = objRow[congs_KnowledgesGraph.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesGraphEN.UpdUser = objRow[congs_KnowledgesGraph.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesGraphEN.Memo = objRow[congs_KnowledgesGraph.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.Memo].ToString().Trim(); //备注
objgs_KnowledgesGraphEN.GraphTypeId = objRow[congs_KnowledgesGraph.GraphTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphEN.IsDisplay = TransNullToBool(objRow[congs_KnowledgesGraph.IsDisplay].ToString().Trim()); //是否显示
objgs_KnowledgesGraphEN.IsExtend = TransNullToBool(objRow[congs_KnowledgesGraph.IsExtend].ToString().Trim()); //是否扩展
objgs_KnowledgesGraphEN.IsRecommend = TransNullToBool(objRow[congs_KnowledgesGraph.IsRecommend].ToString().Trim()); //是否推荐
objgs_KnowledgesGraphEN.IsAnswer = TransNullToBool(objRow[congs_KnowledgesGraph.IsAnswer].ToString().Trim()); //是否回答
objgs_KnowledgesGraphEN.IsSubmit = TransNullToBool(objRow[congs_KnowledgesGraph.IsSubmit].ToString().Trim()); //是否提交
objgs_KnowledgesGraphEN.StartTime = objRow[congs_KnowledgesGraph.StartTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.StartTime].ToString().Trim(); //开始时间
objgs_KnowledgesGraphEN.SubmitTime = objRow[congs_KnowledgesGraph.SubmitTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.SubmitTime].ToString().Trim(); //提交时间
objgs_KnowledgesGraphEN.TakeUpTime = objRow[congs_KnowledgesGraph.TakeUpTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.TakeUpTime].ToString().Trim(); //耗时
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsgs_KnowledgesGraphDA: GetObjByDataRowgs_KnowledgesGraph)", objException.Message));
}
objgs_KnowledgesGraphEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_KnowledgesGraphEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsgs_KnowledgesGraphEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
try
{
objgs_KnowledgesGraphEN.KnowledgeGraphId = objRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesGraphEN.KnowledgeGraphName = objRow[congs_KnowledgesGraph.KnowledgeGraphName] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(); //连连看图名
objgs_KnowledgesGraphEN.IdCurrEduCls = objRow[congs_KnowledgesGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_KnowledgesGraphEN.CourseId = objRow[congs_KnowledgesGraph.CourseId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesGraphEN.CreateUser = objRow[congs_KnowledgesGraph.CreateUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CreateUser].ToString().Trim(); //建立用户
objgs_KnowledgesGraphEN.UpdDate = objRow[congs_KnowledgesGraph.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesGraphEN.UpdUser = objRow[congs_KnowledgesGraph.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesGraphEN.Memo = objRow[congs_KnowledgesGraph.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.Memo].ToString().Trim(); //备注
objgs_KnowledgesGraphEN.GraphTypeId = objRow[congs_KnowledgesGraph.GraphTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphEN.IsDisplay = TransNullToBool(objRow[congs_KnowledgesGraph.IsDisplay].ToString().Trim()); //是否显示
objgs_KnowledgesGraphEN.IsExtend = TransNullToBool(objRow[congs_KnowledgesGraph.IsExtend].ToString().Trim()); //是否扩展
objgs_KnowledgesGraphEN.IsRecommend = TransNullToBool(objRow[congs_KnowledgesGraph.IsRecommend].ToString().Trim()); //是否推荐
objgs_KnowledgesGraphEN.IsAnswer = TransNullToBool(objRow[congs_KnowledgesGraph.IsAnswer].ToString().Trim()); //是否回答
objgs_KnowledgesGraphEN.IsSubmit = TransNullToBool(objRow[congs_KnowledgesGraph.IsSubmit].ToString().Trim()); //是否提交
objgs_KnowledgesGraphEN.StartTime = objRow[congs_KnowledgesGraph.StartTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.StartTime].ToString().Trim(); //开始时间
objgs_KnowledgesGraphEN.SubmitTime = objRow[congs_KnowledgesGraph.SubmitTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.SubmitTime].ToString().Trim(); //提交时间
objgs_KnowledgesGraphEN.TakeUpTime = objRow[congs_KnowledgesGraph.TakeUpTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.TakeUpTime].ToString().Trim(); //耗时
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsgs_KnowledgesGraphDA: GetObjByDataRow)", objException.Message));
}
objgs_KnowledgesGraphEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_KnowledgesGraphEN;
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
objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_KnowledgesGraphEN._CurrTabName, congs_KnowledgesGraph.KnowledgeGraphId, 10, "");
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
objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_KnowledgesGraphEN._CurrTabName, congs_KnowledgesGraph.KnowledgeGraphId, 10, strPrefix);
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
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select KnowledgeGraphId from gs_KnowledgesGraph where " + strCondition;
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
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select KnowledgeGraphId from gs_KnowledgesGraph where " + strCondition;
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
 /// <param name = "strKnowledgeGraphId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strKnowledgeGraphId)
{
CheckPrimaryKey(strKnowledgeGraphId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_KnowledgesGraph", "KnowledgeGraphId = " + "'"+ strKnowledgeGraphId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsgs_KnowledgesGraphDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_KnowledgesGraph", strCondition))
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
objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("gs_KnowledgesGraph");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
 {
 if (objgs_KnowledgesGraphEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_KnowledgesGraphEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesGraph where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_KnowledgesGraph");
objRow = objDS.Tables["gs_KnowledgesGraph"].NewRow();
objRow[congs_KnowledgesGraph.KnowledgeGraphId] = objgs_KnowledgesGraphEN.KnowledgeGraphId; //知识点图Id
 if (objgs_KnowledgesGraphEN.KnowledgeGraphName !=  "")
 {
objRow[congs_KnowledgesGraph.KnowledgeGraphName] = objgs_KnowledgesGraphEN.KnowledgeGraphName; //连连看图名
 }
 if (objgs_KnowledgesGraphEN.IdCurrEduCls !=  "")
 {
objRow[congs_KnowledgesGraph.IdCurrEduCls] = objgs_KnowledgesGraphEN.IdCurrEduCls; //教学班流水号
 }
 if (objgs_KnowledgesGraphEN.CourseId !=  "")
 {
objRow[congs_KnowledgesGraph.CourseId] = objgs_KnowledgesGraphEN.CourseId; //课程Id
 }
 if (objgs_KnowledgesGraphEN.CreateUser !=  "")
 {
objRow[congs_KnowledgesGraph.CreateUser] = objgs_KnowledgesGraphEN.CreateUser; //建立用户
 }
 if (objgs_KnowledgesGraphEN.UpdDate !=  "")
 {
objRow[congs_KnowledgesGraph.UpdDate] = objgs_KnowledgesGraphEN.UpdDate; //修改日期
 }
 if (objgs_KnowledgesGraphEN.UpdUser !=  "")
 {
objRow[congs_KnowledgesGraph.UpdUser] = objgs_KnowledgesGraphEN.UpdUser; //修改人
 }
 if (objgs_KnowledgesGraphEN.Memo !=  "")
 {
objRow[congs_KnowledgesGraph.Memo] = objgs_KnowledgesGraphEN.Memo; //备注
 }
 if (objgs_KnowledgesGraphEN.GraphTypeId !=  "")
 {
objRow[congs_KnowledgesGraph.GraphTypeId] = objgs_KnowledgesGraphEN.GraphTypeId; //图谱类型Id
 }
objRow[congs_KnowledgesGraph.IsDisplay] = objgs_KnowledgesGraphEN.IsDisplay; //是否显示
objRow[congs_KnowledgesGraph.IsExtend] = objgs_KnowledgesGraphEN.IsExtend; //是否扩展
objRow[congs_KnowledgesGraph.IsRecommend] = objgs_KnowledgesGraphEN.IsRecommend; //是否推荐
objRow[congs_KnowledgesGraph.IsAnswer] = objgs_KnowledgesGraphEN.IsAnswer; //是否回答
objRow[congs_KnowledgesGraph.IsSubmit] = objgs_KnowledgesGraphEN.IsSubmit; //是否提交
 if (objgs_KnowledgesGraphEN.StartTime !=  "")
 {
objRow[congs_KnowledgesGraph.StartTime] = objgs_KnowledgesGraphEN.StartTime; //开始时间
 }
 if (objgs_KnowledgesGraphEN.SubmitTime !=  "")
 {
objRow[congs_KnowledgesGraph.SubmitTime] = objgs_KnowledgesGraphEN.SubmitTime; //提交时间
 }
 if (objgs_KnowledgesGraphEN.TakeUpTime !=  "")
 {
objRow[congs_KnowledgesGraph.TakeUpTime] = objgs_KnowledgesGraphEN.TakeUpTime; //耗时
 }
objDS.Tables[clsgs_KnowledgesGraphEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsgs_KnowledgesGraphEN._CurrTabName);
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
 /// <param name = "objgs_KnowledgesGraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
 if (objgs_KnowledgesGraphEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_KnowledgesGraphEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_KnowledgesGraphEN.KnowledgeGraphId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.KnowledgeGraphId);
 var strKnowledgeGraphId = objgs_KnowledgesGraphEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeGraphId + "'");
 }
 
 if (objgs_KnowledgesGraphEN.KnowledgeGraphName !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.KnowledgeGraphName);
 var strKnowledgeGraphName = objgs_KnowledgesGraphEN.KnowledgeGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeGraphName + "'");
 }
 
 if (objgs_KnowledgesGraphEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IdCurrEduCls);
 var strIdCurrEduCls = objgs_KnowledgesGraphEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_KnowledgesGraphEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.CourseId);
 var strCourseId = objgs_KnowledgesGraphEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objgs_KnowledgesGraphEN.CreateUser !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.CreateUser);
 var strCreateUser = objgs_KnowledgesGraphEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUser + "'");
 }
 
 if (objgs_KnowledgesGraphEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.UpdDate);
 var strUpdDate = objgs_KnowledgesGraphEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_KnowledgesGraphEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.UpdUser);
 var strUpdUser = objgs_KnowledgesGraphEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_KnowledgesGraphEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.Memo);
 var strMemo = objgs_KnowledgesGraphEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_KnowledgesGraphEN.GraphTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.GraphTypeId);
 var strGraphTypeId = objgs_KnowledgesGraphEN.GraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGraphTypeId + "'");
 }
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsDisplay);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsDisplay  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsExtend);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsExtend  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsRecommend);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsAnswer);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsAnswer  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_KnowledgesGraphEN.StartTime !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.StartTime);
 var strStartTime = objgs_KnowledgesGraphEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartTime + "'");
 }
 
 if (objgs_KnowledgesGraphEN.SubmitTime !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.SubmitTime);
 var strSubmitTime = objgs_KnowledgesGraphEN.SubmitTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubmitTime + "'");
 }
 
 if (objgs_KnowledgesGraphEN.TakeUpTime !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.TakeUpTime);
 var strTakeUpTime = objgs_KnowledgesGraphEN.TakeUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTakeUpTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_KnowledgesGraph");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
 if (objgs_KnowledgesGraphEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_KnowledgesGraphEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_KnowledgesGraphEN.KnowledgeGraphId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.KnowledgeGraphId);
 var strKnowledgeGraphId = objgs_KnowledgesGraphEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeGraphId + "'");
 }
 
 if (objgs_KnowledgesGraphEN.KnowledgeGraphName !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.KnowledgeGraphName);
 var strKnowledgeGraphName = objgs_KnowledgesGraphEN.KnowledgeGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeGraphName + "'");
 }
 
 if (objgs_KnowledgesGraphEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IdCurrEduCls);
 var strIdCurrEduCls = objgs_KnowledgesGraphEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_KnowledgesGraphEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.CourseId);
 var strCourseId = objgs_KnowledgesGraphEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objgs_KnowledgesGraphEN.CreateUser !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.CreateUser);
 var strCreateUser = objgs_KnowledgesGraphEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUser + "'");
 }
 
 if (objgs_KnowledgesGraphEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.UpdDate);
 var strUpdDate = objgs_KnowledgesGraphEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_KnowledgesGraphEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.UpdUser);
 var strUpdUser = objgs_KnowledgesGraphEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_KnowledgesGraphEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.Memo);
 var strMemo = objgs_KnowledgesGraphEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_KnowledgesGraphEN.GraphTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.GraphTypeId);
 var strGraphTypeId = objgs_KnowledgesGraphEN.GraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGraphTypeId + "'");
 }
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsDisplay);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsDisplay  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsExtend);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsExtend  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsRecommend);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsAnswer);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsAnswer  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_KnowledgesGraphEN.StartTime !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.StartTime);
 var strStartTime = objgs_KnowledgesGraphEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartTime + "'");
 }
 
 if (objgs_KnowledgesGraphEN.SubmitTime !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.SubmitTime);
 var strSubmitTime = objgs_KnowledgesGraphEN.SubmitTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubmitTime + "'");
 }
 
 if (objgs_KnowledgesGraphEN.TakeUpTime !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.TakeUpTime);
 var strTakeUpTime = objgs_KnowledgesGraphEN.TakeUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTakeUpTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_KnowledgesGraph");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objgs_KnowledgesGraphEN.KnowledgeGraphId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_KnowledgesGraphEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_KnowledgesGraphEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_KnowledgesGraphEN.KnowledgeGraphId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.KnowledgeGraphId);
 var strKnowledgeGraphId = objgs_KnowledgesGraphEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeGraphId + "'");
 }
 
 if (objgs_KnowledgesGraphEN.KnowledgeGraphName !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.KnowledgeGraphName);
 var strKnowledgeGraphName = objgs_KnowledgesGraphEN.KnowledgeGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeGraphName + "'");
 }
 
 if (objgs_KnowledgesGraphEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IdCurrEduCls);
 var strIdCurrEduCls = objgs_KnowledgesGraphEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_KnowledgesGraphEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.CourseId);
 var strCourseId = objgs_KnowledgesGraphEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objgs_KnowledgesGraphEN.CreateUser !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.CreateUser);
 var strCreateUser = objgs_KnowledgesGraphEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUser + "'");
 }
 
 if (objgs_KnowledgesGraphEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.UpdDate);
 var strUpdDate = objgs_KnowledgesGraphEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_KnowledgesGraphEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.UpdUser);
 var strUpdUser = objgs_KnowledgesGraphEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_KnowledgesGraphEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.Memo);
 var strMemo = objgs_KnowledgesGraphEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_KnowledgesGraphEN.GraphTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.GraphTypeId);
 var strGraphTypeId = objgs_KnowledgesGraphEN.GraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGraphTypeId + "'");
 }
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsDisplay);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsDisplay  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsExtend);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsExtend  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsRecommend);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsAnswer);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsAnswer  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_KnowledgesGraphEN.StartTime !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.StartTime);
 var strStartTime = objgs_KnowledgesGraphEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartTime + "'");
 }
 
 if (objgs_KnowledgesGraphEN.SubmitTime !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.SubmitTime);
 var strSubmitTime = objgs_KnowledgesGraphEN.SubmitTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubmitTime + "'");
 }
 
 if (objgs_KnowledgesGraphEN.TakeUpTime !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.TakeUpTime);
 var strTakeUpTime = objgs_KnowledgesGraphEN.TakeUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTakeUpTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_KnowledgesGraph");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objgs_KnowledgesGraphEN.KnowledgeGraphId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_KnowledgesGraphEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_KnowledgesGraphEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_KnowledgesGraphEN.KnowledgeGraphId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.KnowledgeGraphId);
 var strKnowledgeGraphId = objgs_KnowledgesGraphEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeGraphId + "'");
 }
 
 if (objgs_KnowledgesGraphEN.KnowledgeGraphName !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.KnowledgeGraphName);
 var strKnowledgeGraphName = objgs_KnowledgesGraphEN.KnowledgeGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeGraphName + "'");
 }
 
 if (objgs_KnowledgesGraphEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IdCurrEduCls);
 var strIdCurrEduCls = objgs_KnowledgesGraphEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objgs_KnowledgesGraphEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.CourseId);
 var strCourseId = objgs_KnowledgesGraphEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objgs_KnowledgesGraphEN.CreateUser !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.CreateUser);
 var strCreateUser = objgs_KnowledgesGraphEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUser + "'");
 }
 
 if (objgs_KnowledgesGraphEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.UpdDate);
 var strUpdDate = objgs_KnowledgesGraphEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_KnowledgesGraphEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.UpdUser);
 var strUpdUser = objgs_KnowledgesGraphEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_KnowledgesGraphEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.Memo);
 var strMemo = objgs_KnowledgesGraphEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_KnowledgesGraphEN.GraphTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.GraphTypeId);
 var strGraphTypeId = objgs_KnowledgesGraphEN.GraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGraphTypeId + "'");
 }
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsDisplay);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsDisplay  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsExtend);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsExtend  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsRecommend);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsAnswer);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsAnswer  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(congs_KnowledgesGraph.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_KnowledgesGraphEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_KnowledgesGraphEN.StartTime !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.StartTime);
 var strStartTime = objgs_KnowledgesGraphEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartTime + "'");
 }
 
 if (objgs_KnowledgesGraphEN.SubmitTime !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.SubmitTime);
 var strSubmitTime = objgs_KnowledgesGraphEN.SubmitTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubmitTime + "'");
 }
 
 if (objgs_KnowledgesGraphEN.TakeUpTime !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesGraph.TakeUpTime);
 var strTakeUpTime = objgs_KnowledgesGraphEN.TakeUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTakeUpTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_KnowledgesGraph");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewgs_KnowledgesGraphs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesGraph where KnowledgeGraphId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_KnowledgesGraph");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strKnowledgeGraphId = oRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim();
if (IsExist(strKnowledgeGraphId))
{
 string strResult = "关键字变量值为:" + string.Format("KnowledgeGraphId = {0}", strKnowledgeGraphId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsgs_KnowledgesGraphEN._CurrTabName ].NewRow();
objRow[congs_KnowledgesGraph.KnowledgeGraphId] = oRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objRow[congs_KnowledgesGraph.KnowledgeGraphName] = oRow[congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(); //连连看图名
objRow[congs_KnowledgesGraph.IdCurrEduCls] = oRow[congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[congs_KnowledgesGraph.CourseId] = oRow[congs_KnowledgesGraph.CourseId].ToString().Trim(); //课程Id
objRow[congs_KnowledgesGraph.CreateUser] = oRow[congs_KnowledgesGraph.CreateUser].ToString().Trim(); //建立用户
objRow[congs_KnowledgesGraph.UpdDate] = oRow[congs_KnowledgesGraph.UpdDate].ToString().Trim(); //修改日期
objRow[congs_KnowledgesGraph.UpdUser] = oRow[congs_KnowledgesGraph.UpdUser].ToString().Trim(); //修改人
objRow[congs_KnowledgesGraph.Memo] = oRow[congs_KnowledgesGraph.Memo].ToString().Trim(); //备注
objRow[congs_KnowledgesGraph.GraphTypeId] = oRow[congs_KnowledgesGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objRow[congs_KnowledgesGraph.IsDisplay] = oRow[congs_KnowledgesGraph.IsDisplay].ToString().Trim(); //是否显示
objRow[congs_KnowledgesGraph.IsExtend] = oRow[congs_KnowledgesGraph.IsExtend].ToString().Trim(); //是否扩展
objRow[congs_KnowledgesGraph.IsRecommend] = oRow[congs_KnowledgesGraph.IsRecommend].ToString().Trim(); //是否推荐
objRow[congs_KnowledgesGraph.IsAnswer] = oRow[congs_KnowledgesGraph.IsAnswer].ToString().Trim(); //是否回答
objRow[congs_KnowledgesGraph.IsSubmit] = oRow[congs_KnowledgesGraph.IsSubmit].ToString().Trim(); //是否提交
objRow[congs_KnowledgesGraph.StartTime] = oRow[congs_KnowledgesGraph.StartTime].ToString().Trim(); //开始时间
objRow[congs_KnowledgesGraph.SubmitTime] = oRow[congs_KnowledgesGraph.SubmitTime].ToString().Trim(); //提交时间
objRow[congs_KnowledgesGraph.TakeUpTime] = oRow[congs_KnowledgesGraph.TakeUpTime].ToString().Trim(); //耗时
 objDS.Tables[clsgs_KnowledgesGraphEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsgs_KnowledgesGraphEN._CurrTabName);
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
 /// <param name = "objgs_KnowledgesGraphEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
 if (objgs_KnowledgesGraphEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_KnowledgesGraphEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesGraph where KnowledgeGraphId = " + "'"+ objgs_KnowledgesGraphEN.KnowledgeGraphId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsgs_KnowledgesGraphEN._CurrTabName);
if (objDS.Tables[clsgs_KnowledgesGraphEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:KnowledgeGraphId = " + "'"+ objgs_KnowledgesGraphEN.KnowledgeGraphId+"'");
return false;
}
objRow = objDS.Tables[clsgs_KnowledgesGraphEN._CurrTabName].Rows[0];
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.KnowledgeGraphId))
 {
objRow[congs_KnowledgesGraph.KnowledgeGraphId] = objgs_KnowledgesGraphEN.KnowledgeGraphId; //知识点图Id
 }
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.KnowledgeGraphName))
 {
objRow[congs_KnowledgesGraph.KnowledgeGraphName] = objgs_KnowledgesGraphEN.KnowledgeGraphName; //连连看图名
 }
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IdCurrEduCls))
 {
objRow[congs_KnowledgesGraph.IdCurrEduCls] = objgs_KnowledgesGraphEN.IdCurrEduCls; //教学班流水号
 }
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.CourseId))
 {
objRow[congs_KnowledgesGraph.CourseId] = objgs_KnowledgesGraphEN.CourseId; //课程Id
 }
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.CreateUser))
 {
objRow[congs_KnowledgesGraph.CreateUser] = objgs_KnowledgesGraphEN.CreateUser; //建立用户
 }
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.UpdDate))
 {
objRow[congs_KnowledgesGraph.UpdDate] = objgs_KnowledgesGraphEN.UpdDate; //修改日期
 }
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.UpdUser))
 {
objRow[congs_KnowledgesGraph.UpdUser] = objgs_KnowledgesGraphEN.UpdUser; //修改人
 }
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.Memo))
 {
objRow[congs_KnowledgesGraph.Memo] = objgs_KnowledgesGraphEN.Memo; //备注
 }
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.GraphTypeId))
 {
objRow[congs_KnowledgesGraph.GraphTypeId] = objgs_KnowledgesGraphEN.GraphTypeId; //图谱类型Id
 }
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsDisplay))
 {
objRow[congs_KnowledgesGraph.IsDisplay] = objgs_KnowledgesGraphEN.IsDisplay; //是否显示
 }
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsExtend))
 {
objRow[congs_KnowledgesGraph.IsExtend] = objgs_KnowledgesGraphEN.IsExtend; //是否扩展
 }
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsRecommend))
 {
objRow[congs_KnowledgesGraph.IsRecommend] = objgs_KnowledgesGraphEN.IsRecommend; //是否推荐
 }
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsAnswer))
 {
objRow[congs_KnowledgesGraph.IsAnswer] = objgs_KnowledgesGraphEN.IsAnswer; //是否回答
 }
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsSubmit))
 {
objRow[congs_KnowledgesGraph.IsSubmit] = objgs_KnowledgesGraphEN.IsSubmit; //是否提交
 }
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.StartTime))
 {
objRow[congs_KnowledgesGraph.StartTime] = objgs_KnowledgesGraphEN.StartTime; //开始时间
 }
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.SubmitTime))
 {
objRow[congs_KnowledgesGraph.SubmitTime] = objgs_KnowledgesGraphEN.SubmitTime; //提交时间
 }
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.TakeUpTime))
 {
objRow[congs_KnowledgesGraph.TakeUpTime] = objgs_KnowledgesGraphEN.TakeUpTime; //耗时
 }
try
{
objDA.Update(objDS, clsgs_KnowledgesGraphEN._CurrTabName);
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
 /// <param name = "objgs_KnowledgesGraphEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
 if (objgs_KnowledgesGraphEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_KnowledgesGraphEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update gs_KnowledgesGraph Set ");
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.KnowledgeGraphName))
 {
 if (objgs_KnowledgesGraphEN.KnowledgeGraphName !=  null)
 {
 var strKnowledgeGraphName = objgs_KnowledgesGraphEN.KnowledgeGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeGraphName, congs_KnowledgesGraph.KnowledgeGraphName); //连连看图名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.KnowledgeGraphName); //连连看图名
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IdCurrEduCls))
 {
 if (objgs_KnowledgesGraphEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_KnowledgesGraphEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_KnowledgesGraph.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.CourseId))
 {
 if (objgs_KnowledgesGraphEN.CourseId !=  null)
 {
 var strCourseId = objgs_KnowledgesGraphEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, congs_KnowledgesGraph.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.CourseId); //课程Id
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.CreateUser))
 {
 if (objgs_KnowledgesGraphEN.CreateUser !=  null)
 {
 var strCreateUser = objgs_KnowledgesGraphEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUser, congs_KnowledgesGraph.CreateUser); //建立用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.CreateUser); //建立用户
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.UpdDate))
 {
 if (objgs_KnowledgesGraphEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_KnowledgesGraphEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_KnowledgesGraph.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.UpdDate); //修改日期
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.UpdUser))
 {
 if (objgs_KnowledgesGraphEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_KnowledgesGraphEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_KnowledgesGraph.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.UpdUser); //修改人
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.Memo))
 {
 if (objgs_KnowledgesGraphEN.Memo !=  null)
 {
 var strMemo = objgs_KnowledgesGraphEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_KnowledgesGraph.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.Memo); //备注
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.GraphTypeId))
 {
 if (objgs_KnowledgesGraphEN.GraphTypeId !=  null)
 {
 var strGraphTypeId = objgs_KnowledgesGraphEN.GraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGraphTypeId, congs_KnowledgesGraph.GraphTypeId); //图谱类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.GraphTypeId); //图谱类型Id
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsDisplay))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_KnowledgesGraphEN.IsDisplay == true?"1":"0", congs_KnowledgesGraph.IsDisplay); //是否显示
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsExtend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_KnowledgesGraphEN.IsExtend == true?"1":"0", congs_KnowledgesGraph.IsExtend); //是否扩展
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_KnowledgesGraphEN.IsRecommend == true?"1":"0", congs_KnowledgesGraph.IsRecommend); //是否推荐
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsAnswer))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_KnowledgesGraphEN.IsAnswer == true?"1":"0", congs_KnowledgesGraph.IsAnswer); //是否回答
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_KnowledgesGraphEN.IsSubmit == true?"1":"0", congs_KnowledgesGraph.IsSubmit); //是否提交
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.StartTime))
 {
 if (objgs_KnowledgesGraphEN.StartTime !=  null)
 {
 var strStartTime = objgs_KnowledgesGraphEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStartTime, congs_KnowledgesGraph.StartTime); //开始时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.StartTime); //开始时间
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.SubmitTime))
 {
 if (objgs_KnowledgesGraphEN.SubmitTime !=  null)
 {
 var strSubmitTime = objgs_KnowledgesGraphEN.SubmitTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubmitTime, congs_KnowledgesGraph.SubmitTime); //提交时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.SubmitTime); //提交时间
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.TakeUpTime))
 {
 if (objgs_KnowledgesGraphEN.TakeUpTime !=  null)
 {
 var strTakeUpTime = objgs_KnowledgesGraphEN.TakeUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTakeUpTime, congs_KnowledgesGraph.TakeUpTime); //耗时
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.TakeUpTime); //耗时
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where KnowledgeGraphId = '{0}'", objgs_KnowledgesGraphEN.KnowledgeGraphId); 
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
 /// <param name = "objgs_KnowledgesGraphEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, string strCondition)
{
 if (objgs_KnowledgesGraphEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_KnowledgesGraphEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_KnowledgesGraph Set ");
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.KnowledgeGraphName))
 {
 if (objgs_KnowledgesGraphEN.KnowledgeGraphName !=  null)
 {
 var strKnowledgeGraphName = objgs_KnowledgesGraphEN.KnowledgeGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeGraphName = '{0}',", strKnowledgeGraphName); //连连看图名
 }
 else
 {
 sbSQL.Append(" KnowledgeGraphName = null,"); //连连看图名
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IdCurrEduCls))
 {
 if (objgs_KnowledgesGraphEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_KnowledgesGraphEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.CourseId))
 {
 if (objgs_KnowledgesGraphEN.CourseId !=  null)
 {
 var strCourseId = objgs_KnowledgesGraphEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.CreateUser))
 {
 if (objgs_KnowledgesGraphEN.CreateUser !=  null)
 {
 var strCreateUser = objgs_KnowledgesGraphEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUser = '{0}',", strCreateUser); //建立用户
 }
 else
 {
 sbSQL.Append(" CreateUser = null,"); //建立用户
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.UpdDate))
 {
 if (objgs_KnowledgesGraphEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_KnowledgesGraphEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.UpdUser))
 {
 if (objgs_KnowledgesGraphEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_KnowledgesGraphEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.Memo))
 {
 if (objgs_KnowledgesGraphEN.Memo !=  null)
 {
 var strMemo = objgs_KnowledgesGraphEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.GraphTypeId))
 {
 if (objgs_KnowledgesGraphEN.GraphTypeId !=  null)
 {
 var strGraphTypeId = objgs_KnowledgesGraphEN.GraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GraphTypeId = '{0}',", strGraphTypeId); //图谱类型Id
 }
 else
 {
 sbSQL.Append(" GraphTypeId = null,"); //图谱类型Id
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsDisplay))
 {
 sbSQL.AppendFormat(" IsDisplay = '{0}',", objgs_KnowledgesGraphEN.IsDisplay == true?"1":"0"); //是否显示
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsExtend))
 {
 sbSQL.AppendFormat(" IsExtend = '{0}',", objgs_KnowledgesGraphEN.IsExtend == true?"1":"0"); //是否扩展
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objgs_KnowledgesGraphEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsAnswer))
 {
 sbSQL.AppendFormat(" IsAnswer = '{0}',", objgs_KnowledgesGraphEN.IsAnswer == true?"1":"0"); //是否回答
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objgs_KnowledgesGraphEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.StartTime))
 {
 if (objgs_KnowledgesGraphEN.StartTime !=  null)
 {
 var strStartTime = objgs_KnowledgesGraphEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StartTime = '{0}',", strStartTime); //开始时间
 }
 else
 {
 sbSQL.Append(" StartTime = null,"); //开始时间
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.SubmitTime))
 {
 if (objgs_KnowledgesGraphEN.SubmitTime !=  null)
 {
 var strSubmitTime = objgs_KnowledgesGraphEN.SubmitTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubmitTime = '{0}',", strSubmitTime); //提交时间
 }
 else
 {
 sbSQL.Append(" SubmitTime = null,"); //提交时间
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.TakeUpTime))
 {
 if (objgs_KnowledgesGraphEN.TakeUpTime !=  null)
 {
 var strTakeUpTime = objgs_KnowledgesGraphEN.TakeUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TakeUpTime = '{0}',", strTakeUpTime); //耗时
 }
 else
 {
 sbSQL.Append(" TakeUpTime = null,"); //耗时
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
 /// <param name = "objgs_KnowledgesGraphEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_KnowledgesGraphEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_KnowledgesGraphEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_KnowledgesGraph Set ");
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.KnowledgeGraphName))
 {
 if (objgs_KnowledgesGraphEN.KnowledgeGraphName !=  null)
 {
 var strKnowledgeGraphName = objgs_KnowledgesGraphEN.KnowledgeGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeGraphName = '{0}',", strKnowledgeGraphName); //连连看图名
 }
 else
 {
 sbSQL.Append(" KnowledgeGraphName = null,"); //连连看图名
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IdCurrEduCls))
 {
 if (objgs_KnowledgesGraphEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_KnowledgesGraphEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.CourseId))
 {
 if (objgs_KnowledgesGraphEN.CourseId !=  null)
 {
 var strCourseId = objgs_KnowledgesGraphEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.CreateUser))
 {
 if (objgs_KnowledgesGraphEN.CreateUser !=  null)
 {
 var strCreateUser = objgs_KnowledgesGraphEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUser = '{0}',", strCreateUser); //建立用户
 }
 else
 {
 sbSQL.Append(" CreateUser = null,"); //建立用户
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.UpdDate))
 {
 if (objgs_KnowledgesGraphEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_KnowledgesGraphEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.UpdUser))
 {
 if (objgs_KnowledgesGraphEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_KnowledgesGraphEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.Memo))
 {
 if (objgs_KnowledgesGraphEN.Memo !=  null)
 {
 var strMemo = objgs_KnowledgesGraphEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.GraphTypeId))
 {
 if (objgs_KnowledgesGraphEN.GraphTypeId !=  null)
 {
 var strGraphTypeId = objgs_KnowledgesGraphEN.GraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GraphTypeId = '{0}',", strGraphTypeId); //图谱类型Id
 }
 else
 {
 sbSQL.Append(" GraphTypeId = null,"); //图谱类型Id
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsDisplay))
 {
 sbSQL.AppendFormat(" IsDisplay = '{0}',", objgs_KnowledgesGraphEN.IsDisplay == true?"1":"0"); //是否显示
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsExtend))
 {
 sbSQL.AppendFormat(" IsExtend = '{0}',", objgs_KnowledgesGraphEN.IsExtend == true?"1":"0"); //是否扩展
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objgs_KnowledgesGraphEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsAnswer))
 {
 sbSQL.AppendFormat(" IsAnswer = '{0}',", objgs_KnowledgesGraphEN.IsAnswer == true?"1":"0"); //是否回答
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objgs_KnowledgesGraphEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.StartTime))
 {
 if (objgs_KnowledgesGraphEN.StartTime !=  null)
 {
 var strStartTime = objgs_KnowledgesGraphEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StartTime = '{0}',", strStartTime); //开始时间
 }
 else
 {
 sbSQL.Append(" StartTime = null,"); //开始时间
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.SubmitTime))
 {
 if (objgs_KnowledgesGraphEN.SubmitTime !=  null)
 {
 var strSubmitTime = objgs_KnowledgesGraphEN.SubmitTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubmitTime = '{0}',", strSubmitTime); //提交时间
 }
 else
 {
 sbSQL.Append(" SubmitTime = null,"); //提交时间
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.TakeUpTime))
 {
 if (objgs_KnowledgesGraphEN.TakeUpTime !=  null)
 {
 var strTakeUpTime = objgs_KnowledgesGraphEN.TakeUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TakeUpTime = '{0}',", strTakeUpTime); //耗时
 }
 else
 {
 sbSQL.Append(" TakeUpTime = null,"); //耗时
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
 /// <param name = "objgs_KnowledgesGraphEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objgs_KnowledgesGraphEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_KnowledgesGraphEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_KnowledgesGraph Set ");
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.KnowledgeGraphName))
 {
 if (objgs_KnowledgesGraphEN.KnowledgeGraphName !=  null)
 {
 var strKnowledgeGraphName = objgs_KnowledgesGraphEN.KnowledgeGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeGraphName, congs_KnowledgesGraph.KnowledgeGraphName); //连连看图名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.KnowledgeGraphName); //连连看图名
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IdCurrEduCls))
 {
 if (objgs_KnowledgesGraphEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_KnowledgesGraphEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_KnowledgesGraph.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.CourseId))
 {
 if (objgs_KnowledgesGraphEN.CourseId !=  null)
 {
 var strCourseId = objgs_KnowledgesGraphEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, congs_KnowledgesGraph.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.CourseId); //课程Id
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.CreateUser))
 {
 if (objgs_KnowledgesGraphEN.CreateUser !=  null)
 {
 var strCreateUser = objgs_KnowledgesGraphEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUser, congs_KnowledgesGraph.CreateUser); //建立用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.CreateUser); //建立用户
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.UpdDate))
 {
 if (objgs_KnowledgesGraphEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_KnowledgesGraphEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_KnowledgesGraph.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.UpdDate); //修改日期
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.UpdUser))
 {
 if (objgs_KnowledgesGraphEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_KnowledgesGraphEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_KnowledgesGraph.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.UpdUser); //修改人
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.Memo))
 {
 if (objgs_KnowledgesGraphEN.Memo !=  null)
 {
 var strMemo = objgs_KnowledgesGraphEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_KnowledgesGraph.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.Memo); //备注
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.GraphTypeId))
 {
 if (objgs_KnowledgesGraphEN.GraphTypeId !=  null)
 {
 var strGraphTypeId = objgs_KnowledgesGraphEN.GraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGraphTypeId, congs_KnowledgesGraph.GraphTypeId); //图谱类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.GraphTypeId); //图谱类型Id
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsDisplay))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_KnowledgesGraphEN.IsDisplay == true?"1":"0", congs_KnowledgesGraph.IsDisplay); //是否显示
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsExtend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_KnowledgesGraphEN.IsExtend == true?"1":"0", congs_KnowledgesGraph.IsExtend); //是否扩展
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_KnowledgesGraphEN.IsRecommend == true?"1":"0", congs_KnowledgesGraph.IsRecommend); //是否推荐
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsAnswer))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_KnowledgesGraphEN.IsAnswer == true?"1":"0", congs_KnowledgesGraph.IsAnswer); //是否回答
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_KnowledgesGraphEN.IsSubmit == true?"1":"0", congs_KnowledgesGraph.IsSubmit); //是否提交
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.StartTime))
 {
 if (objgs_KnowledgesGraphEN.StartTime !=  null)
 {
 var strStartTime = objgs_KnowledgesGraphEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStartTime, congs_KnowledgesGraph.StartTime); //开始时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.StartTime); //开始时间
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.SubmitTime))
 {
 if (objgs_KnowledgesGraphEN.SubmitTime !=  null)
 {
 var strSubmitTime = objgs_KnowledgesGraphEN.SubmitTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubmitTime, congs_KnowledgesGraph.SubmitTime); //提交时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.SubmitTime); //提交时间
 }
 }
 
 if (objgs_KnowledgesGraphEN.IsUpdated(congs_KnowledgesGraph.TakeUpTime))
 {
 if (objgs_KnowledgesGraphEN.TakeUpTime !=  null)
 {
 var strTakeUpTime = objgs_KnowledgesGraphEN.TakeUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTakeUpTime, congs_KnowledgesGraph.TakeUpTime); //耗时
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesGraph.TakeUpTime); //耗时
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where KnowledgeGraphId = '{0}'", objgs_KnowledgesGraphEN.KnowledgeGraphId); 
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
 /// <param name = "strKnowledgeGraphId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strKnowledgeGraphId) 
{
CheckPrimaryKey(strKnowledgeGraphId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strKnowledgeGraphId,
};
 objSQL.ExecSP("gs_KnowledgesGraph_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strKnowledgeGraphId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strKnowledgeGraphId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strKnowledgeGraphId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
//删除gs_KnowledgesGraph本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_KnowledgesGraph where KnowledgeGraphId = " + "'"+ strKnowledgeGraphId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delgs_KnowledgesGraph(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
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
//删除gs_KnowledgesGraph本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_KnowledgesGraph where KnowledgeGraphId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strKnowledgeGraphId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strKnowledgeGraphId) 
{
CheckPrimaryKey(strKnowledgeGraphId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
//删除gs_KnowledgesGraph本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_KnowledgesGraph where KnowledgeGraphId = " + "'"+ strKnowledgeGraphId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delgs_KnowledgesGraph(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsgs_KnowledgesGraphDA: Delgs_KnowledgesGraph)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_KnowledgesGraph where " + strCondition ;
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
public bool Delgs_KnowledgesGraphWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsgs_KnowledgesGraphDA: Delgs_KnowledgesGraphWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_KnowledgesGraph where " + strCondition ;
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
 /// <param name = "objgs_KnowledgesGraphENS">源对象</param>
 /// <param name = "objgs_KnowledgesGraphENT">目标对象</param>
public void CopyTo(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphENS, clsgs_KnowledgesGraphEN objgs_KnowledgesGraphENT)
{
objgs_KnowledgesGraphENT.KnowledgeGraphId = objgs_KnowledgesGraphENS.KnowledgeGraphId; //知识点图Id
objgs_KnowledgesGraphENT.KnowledgeGraphName = objgs_KnowledgesGraphENS.KnowledgeGraphName; //连连看图名
objgs_KnowledgesGraphENT.IdCurrEduCls = objgs_KnowledgesGraphENS.IdCurrEduCls; //教学班流水号
objgs_KnowledgesGraphENT.CourseId = objgs_KnowledgesGraphENS.CourseId; //课程Id
objgs_KnowledgesGraphENT.CreateUser = objgs_KnowledgesGraphENS.CreateUser; //建立用户
objgs_KnowledgesGraphENT.UpdDate = objgs_KnowledgesGraphENS.UpdDate; //修改日期
objgs_KnowledgesGraphENT.UpdUser = objgs_KnowledgesGraphENS.UpdUser; //修改人
objgs_KnowledgesGraphENT.Memo = objgs_KnowledgesGraphENS.Memo; //备注
objgs_KnowledgesGraphENT.GraphTypeId = objgs_KnowledgesGraphENS.GraphTypeId; //图谱类型Id
objgs_KnowledgesGraphENT.IsDisplay = objgs_KnowledgesGraphENS.IsDisplay; //是否显示
objgs_KnowledgesGraphENT.IsExtend = objgs_KnowledgesGraphENS.IsExtend; //是否扩展
objgs_KnowledgesGraphENT.IsRecommend = objgs_KnowledgesGraphENS.IsRecommend; //是否推荐
objgs_KnowledgesGraphENT.IsAnswer = objgs_KnowledgesGraphENS.IsAnswer; //是否回答
objgs_KnowledgesGraphENT.IsSubmit = objgs_KnowledgesGraphENS.IsSubmit; //是否提交
objgs_KnowledgesGraphENT.StartTime = objgs_KnowledgesGraphENS.StartTime; //开始时间
objgs_KnowledgesGraphENT.SubmitTime = objgs_KnowledgesGraphENS.SubmitTime; //提交时间
objgs_KnowledgesGraphENT.TakeUpTime = objgs_KnowledgesGraphENS.TakeUpTime; //耗时
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.KnowledgeGraphId, 10, congs_KnowledgesGraph.KnowledgeGraphId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.KnowledgeGraphName, 100, congs_KnowledgesGraph.KnowledgeGraphName);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.IdCurrEduCls, 8, congs_KnowledgesGraph.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.CourseId, 8, congs_KnowledgesGraph.CourseId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.CreateUser, 50, congs_KnowledgesGraph.CreateUser);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.UpdDate, 20, congs_KnowledgesGraph.UpdDate);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.UpdUser, 20, congs_KnowledgesGraph.UpdUser);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.Memo, 1000, congs_KnowledgesGraph.Memo);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.GraphTypeId, 2, congs_KnowledgesGraph.GraphTypeId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.StartTime, 20, congs_KnowledgesGraph.StartTime);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.SubmitTime, 20, congs_KnowledgesGraph.SubmitTime);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.TakeUpTime, 50, congs_KnowledgesGraph.TakeUpTime);
//检查字段外键固定长度
 objgs_KnowledgesGraphEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.KnowledgeGraphName, 100, congs_KnowledgesGraph.KnowledgeGraphName);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.IdCurrEduCls, 8, congs_KnowledgesGraph.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.CourseId, 8, congs_KnowledgesGraph.CourseId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.CreateUser, 50, congs_KnowledgesGraph.CreateUser);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.UpdDate, 20, congs_KnowledgesGraph.UpdDate);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.UpdUser, 20, congs_KnowledgesGraph.UpdUser);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.Memo, 1000, congs_KnowledgesGraph.Memo);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.GraphTypeId, 2, congs_KnowledgesGraph.GraphTypeId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.StartTime, 20, congs_KnowledgesGraph.StartTime);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.SubmitTime, 20, congs_KnowledgesGraph.SubmitTime);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.TakeUpTime, 50, congs_KnowledgesGraph.TakeUpTime);
//检查外键字段长度
 objgs_KnowledgesGraphEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.KnowledgeGraphId, 10, congs_KnowledgesGraph.KnowledgeGraphId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.KnowledgeGraphName, 100, congs_KnowledgesGraph.KnowledgeGraphName);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.IdCurrEduCls, 8, congs_KnowledgesGraph.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.CourseId, 8, congs_KnowledgesGraph.CourseId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.CreateUser, 50, congs_KnowledgesGraph.CreateUser);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.UpdDate, 20, congs_KnowledgesGraph.UpdDate);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.UpdUser, 20, congs_KnowledgesGraph.UpdUser);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.Memo, 1000, congs_KnowledgesGraph.Memo);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.GraphTypeId, 2, congs_KnowledgesGraph.GraphTypeId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.StartTime, 20, congs_KnowledgesGraph.StartTime);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.SubmitTime, 20, congs_KnowledgesGraph.SubmitTime);
clsCheckSql.CheckFieldLen(objgs_KnowledgesGraphEN.TakeUpTime, 50, congs_KnowledgesGraph.TakeUpTime);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesGraphEN.KnowledgeGraphId, congs_KnowledgesGraph.KnowledgeGraphId);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesGraphEN.KnowledgeGraphName, congs_KnowledgesGraph.KnowledgeGraphName);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesGraphEN.IdCurrEduCls, congs_KnowledgesGraph.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesGraphEN.CourseId, congs_KnowledgesGraph.CourseId);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesGraphEN.CreateUser, congs_KnowledgesGraph.CreateUser);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesGraphEN.UpdDate, congs_KnowledgesGraph.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesGraphEN.UpdUser, congs_KnowledgesGraph.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesGraphEN.Memo, congs_KnowledgesGraph.Memo);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesGraphEN.GraphTypeId, congs_KnowledgesGraph.GraphTypeId);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesGraphEN.StartTime, congs_KnowledgesGraph.StartTime);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesGraphEN.SubmitTime, congs_KnowledgesGraph.SubmitTime);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesGraphEN.TakeUpTime, congs_KnowledgesGraph.TakeUpTime);
//检查外键字段长度
 objgs_KnowledgesGraphEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetKnowledgeGraphId()
{
//获取某学院所有专业信息
string strSQL = "select KnowledgeGraphId, KnowledgeGraphName from gs_KnowledgesGraph ";
 clsSpecSQLforSql mySql = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--gs_KnowledgesGraph(知识点逻辑图),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objgs_KnowledgesGraphEN.KnowledgeGraphName == null)
{
 sbCondition.AppendFormat(" and KnowledgeGraphName is null");
}
else
{
 sbCondition.AppendFormat(" and KnowledgeGraphName = '{0}'", objgs_KnowledgesGraphEN.KnowledgeGraphName);
}
 if (objgs_KnowledgesGraphEN.CourseId == null)
{
 sbCondition.AppendFormat(" and CourseId is null");
}
else
{
 sbCondition.AppendFormat(" and CourseId = '{0}'", objgs_KnowledgesGraphEN.CourseId);
}
 if (objgs_KnowledgesGraphEN.CreateUser == null)
{
 sbCondition.AppendFormat(" and CreateUser is null");
}
else
{
 sbCondition.AppendFormat(" and CreateUser = '{0}'", objgs_KnowledgesGraphEN.CreateUser);
}
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
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
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
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
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
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_KnowledgesGraphEN._CurrTabName);
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
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_KnowledgesGraphEN._CurrTabName, strCondition);
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
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
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
 objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}