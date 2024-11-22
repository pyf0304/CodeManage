
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_KnowledgesLogicDA
 表名:gs_KnowledgesLogic(01120872)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:04
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
 /// 知识点逻辑(gs_KnowledgesLogic)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsgs_KnowledgesLogicDA : clsCommBase4DA
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
 return clsgs_KnowledgesLogicEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsgs_KnowledgesLogicEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_KnowledgesLogicEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsgs_KnowledgesLogicEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsgs_KnowledgesLogicEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsgs_KnowledgesLogicDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesLogic where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_gs_KnowledgesLogic(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsgs_KnowledgesLogicDA: GetDataTable_gs_KnowledgesLogic)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesLogic where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsgs_KnowledgesLogicDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsgs_KnowledgesLogicDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesLogic where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsgs_KnowledgesLogicDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsgs_KnowledgesLogicDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_KnowledgesLogic where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_KnowledgesLogic where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsgs_KnowledgesLogicDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from gs_KnowledgesLogic where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsgs_KnowledgesLogicDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_KnowledgesLogic.* from gs_KnowledgesLogic Left Join {1} on {2} where {3} and gs_KnowledgesLogic.mId not in (Select top {5} gs_KnowledgesLogic.mId from gs_KnowledgesLogic Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_KnowledgesLogic where {1} and mId not in (Select top {2} mId from gs_KnowledgesLogic where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_KnowledgesLogic where {1} and mId not in (Select top {3} mId from gs_KnowledgesLogic where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsgs_KnowledgesLogicDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_KnowledgesLogic.* from gs_KnowledgesLogic Left Join {1} on {2} where {3} and gs_KnowledgesLogic.mId not in (Select top {5} gs_KnowledgesLogic.mId from gs_KnowledgesLogic Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_KnowledgesLogic where {1} and mId not in (Select top {2} mId from gs_KnowledgesLogic where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_KnowledgesLogic where {1} and mId not in (Select top {3} mId from gs_KnowledgesLogic where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsgs_KnowledgesLogicEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsgs_KnowledgesLogicDA:GetObjLst)", objException.Message));
}
List<clsgs_KnowledgesLogicEN> arrObjLst = new List<clsgs_KnowledgesLogicEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesLogic where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN = new clsgs_KnowledgesLogicEN();
try
{
objgs_KnowledgesLogicEN.mId = TransNullToInt(objRow[congs_KnowledgesLogic.mId].ToString().Trim()); //mId
objgs_KnowledgesLogicEN.CourseKnowledgeId = objRow[congs_KnowledgesLogic.CourseKnowledgeId].ToString().Trim(); //知识点Id
objgs_KnowledgesLogicEN.CourseKnowledgeTitle = objRow[congs_KnowledgesLogic.CourseKnowledgeTitle] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.CourseKnowledgeTitle].ToString().Trim(); //知识点标题
objgs_KnowledgesLogicEN.XPosition = objRow[congs_KnowledgesLogic.XPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_KnowledgesLogic.XPosition].ToString().Trim()); //X_坐标
objgs_KnowledgesLogicEN.YPosition = objRow[congs_KnowledgesLogic.YPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_KnowledgesLogic.YPosition].ToString().Trim()); //Y_坐标
objgs_KnowledgesLogicEN.KnowledgeGraphId = objRow[congs_KnowledgesLogic.KnowledgeGraphId] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesLogicEN.NodeColor = objRow[congs_KnowledgesLogic.NodeColor] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.NodeColor].ToString().Trim(); //结点颜色
objgs_KnowledgesLogicEN.LogicNodeId = objRow[congs_KnowledgesLogic.LogicNodeId] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.LogicNodeId].ToString().Trim(); //逻辑节点Id
objgs_KnowledgesLogicEN.ClassNameCss = objRow[congs_KnowledgesLogic.ClassNameCss] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.ClassNameCss].ToString().Trim(); //样式名称
objgs_KnowledgesLogicEN.CourseId = objRow[congs_KnowledgesLogic.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesLogicEN.UpdDate = objRow[congs_KnowledgesLogic.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesLogicEN.UpdUser = objRow[congs_KnowledgesLogic.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesLogicEN.Memo = objRow[congs_KnowledgesLogic.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_KnowledgesLogicDA: GetObjLst)", objException.Message));
}
objgs_KnowledgesLogicEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_KnowledgesLogicEN);
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
public List<clsgs_KnowledgesLogicEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsgs_KnowledgesLogicDA:GetObjLstByTabName)", objException.Message));
}
List<clsgs_KnowledgesLogicEN> arrObjLst = new List<clsgs_KnowledgesLogicEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN = new clsgs_KnowledgesLogicEN();
try
{
objgs_KnowledgesLogicEN.mId = TransNullToInt(objRow[congs_KnowledgesLogic.mId].ToString().Trim()); //mId
objgs_KnowledgesLogicEN.CourseKnowledgeId = objRow[congs_KnowledgesLogic.CourseKnowledgeId].ToString().Trim(); //知识点Id
objgs_KnowledgesLogicEN.CourseKnowledgeTitle = objRow[congs_KnowledgesLogic.CourseKnowledgeTitle] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.CourseKnowledgeTitle].ToString().Trim(); //知识点标题
objgs_KnowledgesLogicEN.XPosition = objRow[congs_KnowledgesLogic.XPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_KnowledgesLogic.XPosition].ToString().Trim()); //X_坐标
objgs_KnowledgesLogicEN.YPosition = objRow[congs_KnowledgesLogic.YPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_KnowledgesLogic.YPosition].ToString().Trim()); //Y_坐标
objgs_KnowledgesLogicEN.KnowledgeGraphId = objRow[congs_KnowledgesLogic.KnowledgeGraphId] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesLogicEN.NodeColor = objRow[congs_KnowledgesLogic.NodeColor] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.NodeColor].ToString().Trim(); //结点颜色
objgs_KnowledgesLogicEN.LogicNodeId = objRow[congs_KnowledgesLogic.LogicNodeId] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.LogicNodeId].ToString().Trim(); //逻辑节点Id
objgs_KnowledgesLogicEN.ClassNameCss = objRow[congs_KnowledgesLogic.ClassNameCss] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.ClassNameCss].ToString().Trim(); //样式名称
objgs_KnowledgesLogicEN.CourseId = objRow[congs_KnowledgesLogic.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesLogicEN.UpdDate = objRow[congs_KnowledgesLogic.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesLogicEN.UpdUser = objRow[congs_KnowledgesLogic.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesLogicEN.Memo = objRow[congs_KnowledgesLogic.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_KnowledgesLogicDA: GetObjLst)", objException.Message));
}
objgs_KnowledgesLogicEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_KnowledgesLogicEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getgs_KnowledgesLogic(ref clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesLogic where mId = " + ""+ objgs_KnowledgesLogicEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objgs_KnowledgesLogicEN.mId = TransNullToInt(objDT.Rows[0][congs_KnowledgesLogic.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objgs_KnowledgesLogicEN.CourseKnowledgeId = objDT.Rows[0][congs_KnowledgesLogic.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objgs_KnowledgesLogicEN.CourseKnowledgeTitle = objDT.Rows[0][congs_KnowledgesLogic.CourseKnowledgeTitle].ToString().Trim(); //知识点标题(字段类型:varchar,字段长度:100,是否可空:True)
 objgs_KnowledgesLogicEN.XPosition = TransNullToFloat(objDT.Rows[0][congs_KnowledgesLogic.XPosition].ToString().Trim()); //X_坐标(字段类型:float,字段长度:8,是否可空:True)
 objgs_KnowledgesLogicEN.YPosition = TransNullToFloat(objDT.Rows[0][congs_KnowledgesLogic.YPosition].ToString().Trim()); //Y_坐标(字段类型:float,字段长度:8,是否可空:True)
 objgs_KnowledgesLogicEN.KnowledgeGraphId = objDT.Rows[0][congs_KnowledgesLogic.KnowledgeGraphId].ToString().Trim(); //知识点图Id(字段类型:char,字段长度:10,是否可空:True)
 objgs_KnowledgesLogicEN.NodeColor = objDT.Rows[0][congs_KnowledgesLogic.NodeColor].ToString().Trim(); //结点颜色(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_KnowledgesLogicEN.LogicNodeId = objDT.Rows[0][congs_KnowledgesLogic.LogicNodeId].ToString().Trim(); //逻辑节点Id(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_KnowledgesLogicEN.ClassNameCss = objDT.Rows[0][congs_KnowledgesLogic.ClassNameCss].ToString().Trim(); //样式名称(字段类型:varchar,字段长度:100,是否可空:True)
 objgs_KnowledgesLogicEN.CourseId = objDT.Rows[0][congs_KnowledgesLogic.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_KnowledgesLogicEN.UpdDate = objDT.Rows[0][congs_KnowledgesLogic.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_KnowledgesLogicEN.UpdUser = objDT.Rows[0][congs_KnowledgesLogic.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_KnowledgesLogicEN.Memo = objDT.Rows[0][congs_KnowledgesLogic.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsgs_KnowledgesLogicDA: Getgs_KnowledgesLogic)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsgs_KnowledgesLogicEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesLogic where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN = new clsgs_KnowledgesLogicEN();
try
{
 objgs_KnowledgesLogicEN.mId = Int32.Parse(objRow[congs_KnowledgesLogic.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objgs_KnowledgesLogicEN.CourseKnowledgeId = objRow[congs_KnowledgesLogic.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objgs_KnowledgesLogicEN.CourseKnowledgeTitle = objRow[congs_KnowledgesLogic.CourseKnowledgeTitle] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.CourseKnowledgeTitle].ToString().Trim(); //知识点标题(字段类型:varchar,字段长度:100,是否可空:True)
 objgs_KnowledgesLogicEN.XPosition = objRow[congs_KnowledgesLogic.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_KnowledgesLogic.XPosition].ToString().Trim()); //X_坐标(字段类型:float,字段长度:8,是否可空:True)
 objgs_KnowledgesLogicEN.YPosition = objRow[congs_KnowledgesLogic.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_KnowledgesLogic.YPosition].ToString().Trim()); //Y_坐标(字段类型:float,字段长度:8,是否可空:True)
 objgs_KnowledgesLogicEN.KnowledgeGraphId = objRow[congs_KnowledgesLogic.KnowledgeGraphId] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.KnowledgeGraphId].ToString().Trim(); //知识点图Id(字段类型:char,字段长度:10,是否可空:True)
 objgs_KnowledgesLogicEN.NodeColor = objRow[congs_KnowledgesLogic.NodeColor] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.NodeColor].ToString().Trim(); //结点颜色(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_KnowledgesLogicEN.LogicNodeId = objRow[congs_KnowledgesLogic.LogicNodeId] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.LogicNodeId].ToString().Trim(); //逻辑节点Id(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_KnowledgesLogicEN.ClassNameCss = objRow[congs_KnowledgesLogic.ClassNameCss] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.ClassNameCss].ToString().Trim(); //样式名称(字段类型:varchar,字段长度:100,是否可空:True)
 objgs_KnowledgesLogicEN.CourseId = objRow[congs_KnowledgesLogic.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_KnowledgesLogicEN.UpdDate = objRow[congs_KnowledgesLogic.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_KnowledgesLogicEN.UpdUser = objRow[congs_KnowledgesLogic.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_KnowledgesLogicEN.Memo = objRow[congs_KnowledgesLogic.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsgs_KnowledgesLogicDA: GetObjBymId)", objException.Message));
}
return objgs_KnowledgesLogicEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsgs_KnowledgesLogicEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsgs_KnowledgesLogicDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesLogic where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN = new clsgs_KnowledgesLogicEN()
{
mId = TransNullToInt(objRow[congs_KnowledgesLogic.mId].ToString().Trim()), //mId
CourseKnowledgeId = objRow[congs_KnowledgesLogic.CourseKnowledgeId].ToString().Trim(), //知识点Id
CourseKnowledgeTitle = objRow[congs_KnowledgesLogic.CourseKnowledgeTitle] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.CourseKnowledgeTitle].ToString().Trim(), //知识点标题
XPosition = objRow[congs_KnowledgesLogic.XPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_KnowledgesLogic.XPosition].ToString().Trim()), //X_坐标
YPosition = objRow[congs_KnowledgesLogic.YPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_KnowledgesLogic.YPosition].ToString().Trim()), //Y_坐标
KnowledgeGraphId = objRow[congs_KnowledgesLogic.KnowledgeGraphId] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.KnowledgeGraphId].ToString().Trim(), //知识点图Id
NodeColor = objRow[congs_KnowledgesLogic.NodeColor] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.NodeColor].ToString().Trim(), //结点颜色
LogicNodeId = objRow[congs_KnowledgesLogic.LogicNodeId] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.LogicNodeId].ToString().Trim(), //逻辑节点Id
ClassNameCss = objRow[congs_KnowledgesLogic.ClassNameCss] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.ClassNameCss].ToString().Trim(), //样式名称
CourseId = objRow[congs_KnowledgesLogic.CourseId].ToString().Trim(), //课程Id
UpdDate = objRow[congs_KnowledgesLogic.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[congs_KnowledgesLogic.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.UpdUser].ToString().Trim(), //修改人
Memo = objRow[congs_KnowledgesLogic.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.Memo].ToString().Trim() //备注
};
objgs_KnowledgesLogicEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_KnowledgesLogicEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsgs_KnowledgesLogicDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsgs_KnowledgesLogicEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN = new clsgs_KnowledgesLogicEN();
try
{
objgs_KnowledgesLogicEN.mId = TransNullToInt(objRow[congs_KnowledgesLogic.mId].ToString().Trim()); //mId
objgs_KnowledgesLogicEN.CourseKnowledgeId = objRow[congs_KnowledgesLogic.CourseKnowledgeId].ToString().Trim(); //知识点Id
objgs_KnowledgesLogicEN.CourseKnowledgeTitle = objRow[congs_KnowledgesLogic.CourseKnowledgeTitle] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.CourseKnowledgeTitle].ToString().Trim(); //知识点标题
objgs_KnowledgesLogicEN.XPosition = objRow[congs_KnowledgesLogic.XPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_KnowledgesLogic.XPosition].ToString().Trim()); //X_坐标
objgs_KnowledgesLogicEN.YPosition = objRow[congs_KnowledgesLogic.YPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_KnowledgesLogic.YPosition].ToString().Trim()); //Y_坐标
objgs_KnowledgesLogicEN.KnowledgeGraphId = objRow[congs_KnowledgesLogic.KnowledgeGraphId] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesLogicEN.NodeColor = objRow[congs_KnowledgesLogic.NodeColor] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.NodeColor].ToString().Trim(); //结点颜色
objgs_KnowledgesLogicEN.LogicNodeId = objRow[congs_KnowledgesLogic.LogicNodeId] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.LogicNodeId].ToString().Trim(); //逻辑节点Id
objgs_KnowledgesLogicEN.ClassNameCss = objRow[congs_KnowledgesLogic.ClassNameCss] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.ClassNameCss].ToString().Trim(); //样式名称
objgs_KnowledgesLogicEN.CourseId = objRow[congs_KnowledgesLogic.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesLogicEN.UpdDate = objRow[congs_KnowledgesLogic.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesLogicEN.UpdUser = objRow[congs_KnowledgesLogic.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesLogicEN.Memo = objRow[congs_KnowledgesLogic.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsgs_KnowledgesLogicDA: GetObjByDataRowgs_KnowledgesLogic)", objException.Message));
}
objgs_KnowledgesLogicEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_KnowledgesLogicEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsgs_KnowledgesLogicEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN = new clsgs_KnowledgesLogicEN();
try
{
objgs_KnowledgesLogicEN.mId = TransNullToInt(objRow[congs_KnowledgesLogic.mId].ToString().Trim()); //mId
objgs_KnowledgesLogicEN.CourseKnowledgeId = objRow[congs_KnowledgesLogic.CourseKnowledgeId].ToString().Trim(); //知识点Id
objgs_KnowledgesLogicEN.CourseKnowledgeTitle = objRow[congs_KnowledgesLogic.CourseKnowledgeTitle] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.CourseKnowledgeTitle].ToString().Trim(); //知识点标题
objgs_KnowledgesLogicEN.XPosition = objRow[congs_KnowledgesLogic.XPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_KnowledgesLogic.XPosition].ToString().Trim()); //X_坐标
objgs_KnowledgesLogicEN.YPosition = objRow[congs_KnowledgesLogic.YPosition] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[congs_KnowledgesLogic.YPosition].ToString().Trim()); //Y_坐标
objgs_KnowledgesLogicEN.KnowledgeGraphId = objRow[congs_KnowledgesLogic.KnowledgeGraphId] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesLogicEN.NodeColor = objRow[congs_KnowledgesLogic.NodeColor] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.NodeColor].ToString().Trim(); //结点颜色
objgs_KnowledgesLogicEN.LogicNodeId = objRow[congs_KnowledgesLogic.LogicNodeId] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.LogicNodeId].ToString().Trim(); //逻辑节点Id
objgs_KnowledgesLogicEN.ClassNameCss = objRow[congs_KnowledgesLogic.ClassNameCss] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.ClassNameCss].ToString().Trim(); //样式名称
objgs_KnowledgesLogicEN.CourseId = objRow[congs_KnowledgesLogic.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesLogicEN.UpdDate = objRow[congs_KnowledgesLogic.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesLogicEN.UpdUser = objRow[congs_KnowledgesLogic.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesLogicEN.Memo = objRow[congs_KnowledgesLogic.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesLogic.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsgs_KnowledgesLogicDA: GetObjByDataRow)", objException.Message));
}
objgs_KnowledgesLogicEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_KnowledgesLogicEN;
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
objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_KnowledgesLogicEN._CurrTabName, congs_KnowledgesLogic.mId, 8, "");
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
objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_KnowledgesLogicEN._CurrTabName, congs_KnowledgesLogic.mId, 8, strPrefix);
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
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from gs_KnowledgesLogic where " + strCondition;
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
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from gs_KnowledgesLogic where " + strCondition;
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
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_KnowledgesLogic", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsgs_KnowledgesLogicDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_KnowledgesLogic", strCondition))
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
objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("gs_KnowledgesLogic");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN)
 {
 objgs_KnowledgesLogicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_KnowledgesLogicEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_KnowledgesLogicEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesLogic where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_KnowledgesLogic");
objRow = objDS.Tables["gs_KnowledgesLogic"].NewRow();
objRow[congs_KnowledgesLogic.CourseKnowledgeId] = objgs_KnowledgesLogicEN.CourseKnowledgeId; //知识点Id
 if (objgs_KnowledgesLogicEN.CourseKnowledgeTitle !=  "")
 {
objRow[congs_KnowledgesLogic.CourseKnowledgeTitle] = objgs_KnowledgesLogicEN.CourseKnowledgeTitle; //知识点标题
 }
objRow[congs_KnowledgesLogic.XPosition] = objgs_KnowledgesLogicEN.XPosition; //X_坐标
objRow[congs_KnowledgesLogic.YPosition] = objgs_KnowledgesLogicEN.YPosition; //Y_坐标
 if (objgs_KnowledgesLogicEN.KnowledgeGraphId !=  "")
 {
objRow[congs_KnowledgesLogic.KnowledgeGraphId] = objgs_KnowledgesLogicEN.KnowledgeGraphId; //知识点图Id
 }
 if (objgs_KnowledgesLogicEN.NodeColor !=  "")
 {
objRow[congs_KnowledgesLogic.NodeColor] = objgs_KnowledgesLogicEN.NodeColor; //结点颜色
 }
 if (objgs_KnowledgesLogicEN.LogicNodeId !=  "")
 {
objRow[congs_KnowledgesLogic.LogicNodeId] = objgs_KnowledgesLogicEN.LogicNodeId; //逻辑节点Id
 }
 if (objgs_KnowledgesLogicEN.ClassNameCss !=  "")
 {
objRow[congs_KnowledgesLogic.ClassNameCss] = objgs_KnowledgesLogicEN.ClassNameCss; //样式名称
 }
objRow[congs_KnowledgesLogic.CourseId] = objgs_KnowledgesLogicEN.CourseId; //课程Id
 if (objgs_KnowledgesLogicEN.UpdDate !=  "")
 {
objRow[congs_KnowledgesLogic.UpdDate] = objgs_KnowledgesLogicEN.UpdDate; //修改日期
 }
 if (objgs_KnowledgesLogicEN.UpdUser !=  "")
 {
objRow[congs_KnowledgesLogic.UpdUser] = objgs_KnowledgesLogicEN.UpdUser; //修改人
 }
 if (objgs_KnowledgesLogicEN.Memo !=  "")
 {
objRow[congs_KnowledgesLogic.Memo] = objgs_KnowledgesLogicEN.Memo; //备注
 }
objDS.Tables[clsgs_KnowledgesLogicEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsgs_KnowledgesLogicEN._CurrTabName);
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
 /// <param name = "objgs_KnowledgesLogicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN)
{
 objgs_KnowledgesLogicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_KnowledgesLogicEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_KnowledgesLogicEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_KnowledgesLogicEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.CourseKnowledgeId);
 var strCourseKnowledgeId = objgs_KnowledgesLogicEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objgs_KnowledgesLogicEN.CourseKnowledgeTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.CourseKnowledgeTitle);
 var strCourseKnowledgeTitle = objgs_KnowledgesLogicEN.CourseKnowledgeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeTitle + "'");
 }
 
 if (objgs_KnowledgesLogicEN.XPosition !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.XPosition);
 arrValueListForInsert.Add(objgs_KnowledgesLogicEN.XPosition.ToString());
 }
 
 if (objgs_KnowledgesLogicEN.YPosition !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.YPosition);
 arrValueListForInsert.Add(objgs_KnowledgesLogicEN.YPosition.ToString());
 }
 
 if (objgs_KnowledgesLogicEN.KnowledgeGraphId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.KnowledgeGraphId);
 var strKnowledgeGraphId = objgs_KnowledgesLogicEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeGraphId + "'");
 }
 
 if (objgs_KnowledgesLogicEN.NodeColor !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.NodeColor);
 var strNodeColor = objgs_KnowledgesLogicEN.NodeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNodeColor + "'");
 }
 
 if (objgs_KnowledgesLogicEN.LogicNodeId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.LogicNodeId);
 var strLogicNodeId = objgs_KnowledgesLogicEN.LogicNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogicNodeId + "'");
 }
 
 if (objgs_KnowledgesLogicEN.ClassNameCss !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.ClassNameCss);
 var strClassNameCss = objgs_KnowledgesLogicEN.ClassNameCss.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassNameCss + "'");
 }
 
 if (objgs_KnowledgesLogicEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.CourseId);
 var strCourseId = objgs_KnowledgesLogicEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objgs_KnowledgesLogicEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.UpdDate);
 var strUpdDate = objgs_KnowledgesLogicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_KnowledgesLogicEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.UpdUser);
 var strUpdUser = objgs_KnowledgesLogicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_KnowledgesLogicEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.Memo);
 var strMemo = objgs_KnowledgesLogicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_KnowledgesLogic");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN)
{
 objgs_KnowledgesLogicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_KnowledgesLogicEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_KnowledgesLogicEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_KnowledgesLogicEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.CourseKnowledgeId);
 var strCourseKnowledgeId = objgs_KnowledgesLogicEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objgs_KnowledgesLogicEN.CourseKnowledgeTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.CourseKnowledgeTitle);
 var strCourseKnowledgeTitle = objgs_KnowledgesLogicEN.CourseKnowledgeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeTitle + "'");
 }
 
 if (objgs_KnowledgesLogicEN.XPosition !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.XPosition);
 arrValueListForInsert.Add(objgs_KnowledgesLogicEN.XPosition.ToString());
 }
 
 if (objgs_KnowledgesLogicEN.YPosition !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.YPosition);
 arrValueListForInsert.Add(objgs_KnowledgesLogicEN.YPosition.ToString());
 }
 
 if (objgs_KnowledgesLogicEN.KnowledgeGraphId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.KnowledgeGraphId);
 var strKnowledgeGraphId = objgs_KnowledgesLogicEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeGraphId + "'");
 }
 
 if (objgs_KnowledgesLogicEN.NodeColor !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.NodeColor);
 var strNodeColor = objgs_KnowledgesLogicEN.NodeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNodeColor + "'");
 }
 
 if (objgs_KnowledgesLogicEN.LogicNodeId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.LogicNodeId);
 var strLogicNodeId = objgs_KnowledgesLogicEN.LogicNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogicNodeId + "'");
 }
 
 if (objgs_KnowledgesLogicEN.ClassNameCss !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.ClassNameCss);
 var strClassNameCss = objgs_KnowledgesLogicEN.ClassNameCss.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassNameCss + "'");
 }
 
 if (objgs_KnowledgesLogicEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.CourseId);
 var strCourseId = objgs_KnowledgesLogicEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objgs_KnowledgesLogicEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.UpdDate);
 var strUpdDate = objgs_KnowledgesLogicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_KnowledgesLogicEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.UpdUser);
 var strUpdUser = objgs_KnowledgesLogicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_KnowledgesLogicEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.Memo);
 var strMemo = objgs_KnowledgesLogicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_KnowledgesLogic");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objgs_KnowledgesLogicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_KnowledgesLogicEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_KnowledgesLogicEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_KnowledgesLogicEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.CourseKnowledgeId);
 var strCourseKnowledgeId = objgs_KnowledgesLogicEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objgs_KnowledgesLogicEN.CourseKnowledgeTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.CourseKnowledgeTitle);
 var strCourseKnowledgeTitle = objgs_KnowledgesLogicEN.CourseKnowledgeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeTitle + "'");
 }
 
 if (objgs_KnowledgesLogicEN.XPosition !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.XPosition);
 arrValueListForInsert.Add(objgs_KnowledgesLogicEN.XPosition.ToString());
 }
 
 if (objgs_KnowledgesLogicEN.YPosition !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.YPosition);
 arrValueListForInsert.Add(objgs_KnowledgesLogicEN.YPosition.ToString());
 }
 
 if (objgs_KnowledgesLogicEN.KnowledgeGraphId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.KnowledgeGraphId);
 var strKnowledgeGraphId = objgs_KnowledgesLogicEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeGraphId + "'");
 }
 
 if (objgs_KnowledgesLogicEN.NodeColor !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.NodeColor);
 var strNodeColor = objgs_KnowledgesLogicEN.NodeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNodeColor + "'");
 }
 
 if (objgs_KnowledgesLogicEN.LogicNodeId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.LogicNodeId);
 var strLogicNodeId = objgs_KnowledgesLogicEN.LogicNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogicNodeId + "'");
 }
 
 if (objgs_KnowledgesLogicEN.ClassNameCss !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.ClassNameCss);
 var strClassNameCss = objgs_KnowledgesLogicEN.ClassNameCss.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassNameCss + "'");
 }
 
 if (objgs_KnowledgesLogicEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.CourseId);
 var strCourseId = objgs_KnowledgesLogicEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objgs_KnowledgesLogicEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.UpdDate);
 var strUpdDate = objgs_KnowledgesLogicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_KnowledgesLogicEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.UpdUser);
 var strUpdUser = objgs_KnowledgesLogicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_KnowledgesLogicEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.Memo);
 var strMemo = objgs_KnowledgesLogicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_KnowledgesLogic");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objgs_KnowledgesLogicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_KnowledgesLogicEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_KnowledgesLogicEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objgs_KnowledgesLogicEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.CourseKnowledgeId);
 var strCourseKnowledgeId = objgs_KnowledgesLogicEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objgs_KnowledgesLogicEN.CourseKnowledgeTitle !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.CourseKnowledgeTitle);
 var strCourseKnowledgeTitle = objgs_KnowledgesLogicEN.CourseKnowledgeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeTitle + "'");
 }
 
 if (objgs_KnowledgesLogicEN.XPosition !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.XPosition);
 arrValueListForInsert.Add(objgs_KnowledgesLogicEN.XPosition.ToString());
 }
 
 if (objgs_KnowledgesLogicEN.YPosition !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.YPosition);
 arrValueListForInsert.Add(objgs_KnowledgesLogicEN.YPosition.ToString());
 }
 
 if (objgs_KnowledgesLogicEN.KnowledgeGraphId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.KnowledgeGraphId);
 var strKnowledgeGraphId = objgs_KnowledgesLogicEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeGraphId + "'");
 }
 
 if (objgs_KnowledgesLogicEN.NodeColor !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.NodeColor);
 var strNodeColor = objgs_KnowledgesLogicEN.NodeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNodeColor + "'");
 }
 
 if (objgs_KnowledgesLogicEN.LogicNodeId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.LogicNodeId);
 var strLogicNodeId = objgs_KnowledgesLogicEN.LogicNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogicNodeId + "'");
 }
 
 if (objgs_KnowledgesLogicEN.ClassNameCss !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.ClassNameCss);
 var strClassNameCss = objgs_KnowledgesLogicEN.ClassNameCss.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassNameCss + "'");
 }
 
 if (objgs_KnowledgesLogicEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.CourseId);
 var strCourseId = objgs_KnowledgesLogicEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objgs_KnowledgesLogicEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.UpdDate);
 var strUpdDate = objgs_KnowledgesLogicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_KnowledgesLogicEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.UpdUser);
 var strUpdUser = objgs_KnowledgesLogicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_KnowledgesLogicEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_KnowledgesLogic.Memo);
 var strMemo = objgs_KnowledgesLogicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_KnowledgesLogic");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewgs_KnowledgesLogics(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesLogic where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_KnowledgesLogic");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsgs_KnowledgesLogicEN._CurrTabName ].NewRow();
objRow[congs_KnowledgesLogic.CourseKnowledgeId] = oRow[congs_KnowledgesLogic.CourseKnowledgeId].ToString().Trim(); //知识点Id
objRow[congs_KnowledgesLogic.CourseKnowledgeTitle] = oRow[congs_KnowledgesLogic.CourseKnowledgeTitle].ToString().Trim(); //知识点标题
objRow[congs_KnowledgesLogic.XPosition] = oRow[congs_KnowledgesLogic.XPosition].ToString().Trim(); //X_坐标
objRow[congs_KnowledgesLogic.YPosition] = oRow[congs_KnowledgesLogic.YPosition].ToString().Trim(); //Y_坐标
objRow[congs_KnowledgesLogic.KnowledgeGraphId] = oRow[congs_KnowledgesLogic.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objRow[congs_KnowledgesLogic.NodeColor] = oRow[congs_KnowledgesLogic.NodeColor].ToString().Trim(); //结点颜色
objRow[congs_KnowledgesLogic.LogicNodeId] = oRow[congs_KnowledgesLogic.LogicNodeId].ToString().Trim(); //逻辑节点Id
objRow[congs_KnowledgesLogic.ClassNameCss] = oRow[congs_KnowledgesLogic.ClassNameCss].ToString().Trim(); //样式名称
objRow[congs_KnowledgesLogic.CourseId] = oRow[congs_KnowledgesLogic.CourseId].ToString().Trim(); //课程Id
objRow[congs_KnowledgesLogic.UpdDate] = oRow[congs_KnowledgesLogic.UpdDate].ToString().Trim(); //修改日期
objRow[congs_KnowledgesLogic.UpdUser] = oRow[congs_KnowledgesLogic.UpdUser].ToString().Trim(); //修改人
objRow[congs_KnowledgesLogic.Memo] = oRow[congs_KnowledgesLogic.Memo].ToString().Trim(); //备注
 objDS.Tables[clsgs_KnowledgesLogicEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsgs_KnowledgesLogicEN._CurrTabName);
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
 /// <param name = "objgs_KnowledgesLogicEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN)
{
 objgs_KnowledgesLogicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_KnowledgesLogicEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_KnowledgesLogicEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
strSQL = "Select * from gs_KnowledgesLogic where mId = " + ""+ objgs_KnowledgesLogicEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsgs_KnowledgesLogicEN._CurrTabName);
if (objDS.Tables[clsgs_KnowledgesLogicEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objgs_KnowledgesLogicEN.mId+"");
return false;
}
objRow = objDS.Tables[clsgs_KnowledgesLogicEN._CurrTabName].Rows[0];
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.CourseKnowledgeId))
 {
objRow[congs_KnowledgesLogic.CourseKnowledgeId] = objgs_KnowledgesLogicEN.CourseKnowledgeId; //知识点Id
 }
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.CourseKnowledgeTitle))
 {
objRow[congs_KnowledgesLogic.CourseKnowledgeTitle] = objgs_KnowledgesLogicEN.CourseKnowledgeTitle; //知识点标题
 }
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.XPosition))
 {
objRow[congs_KnowledgesLogic.XPosition] = objgs_KnowledgesLogicEN.XPosition; //X_坐标
 }
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.YPosition))
 {
objRow[congs_KnowledgesLogic.YPosition] = objgs_KnowledgesLogicEN.YPosition; //Y_坐标
 }
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.KnowledgeGraphId))
 {
objRow[congs_KnowledgesLogic.KnowledgeGraphId] = objgs_KnowledgesLogicEN.KnowledgeGraphId; //知识点图Id
 }
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.NodeColor))
 {
objRow[congs_KnowledgesLogic.NodeColor] = objgs_KnowledgesLogicEN.NodeColor; //结点颜色
 }
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.LogicNodeId))
 {
objRow[congs_KnowledgesLogic.LogicNodeId] = objgs_KnowledgesLogicEN.LogicNodeId; //逻辑节点Id
 }
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.ClassNameCss))
 {
objRow[congs_KnowledgesLogic.ClassNameCss] = objgs_KnowledgesLogicEN.ClassNameCss; //样式名称
 }
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.CourseId))
 {
objRow[congs_KnowledgesLogic.CourseId] = objgs_KnowledgesLogicEN.CourseId; //课程Id
 }
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.UpdDate))
 {
objRow[congs_KnowledgesLogic.UpdDate] = objgs_KnowledgesLogicEN.UpdDate; //修改日期
 }
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.UpdUser))
 {
objRow[congs_KnowledgesLogic.UpdUser] = objgs_KnowledgesLogicEN.UpdUser; //修改人
 }
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.Memo))
 {
objRow[congs_KnowledgesLogic.Memo] = objgs_KnowledgesLogicEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsgs_KnowledgesLogicEN._CurrTabName);
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
 /// <param name = "objgs_KnowledgesLogicEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN)
{
 objgs_KnowledgesLogicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_KnowledgesLogicEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_KnowledgesLogicEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update gs_KnowledgesLogic Set ");
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.CourseKnowledgeId))
 {
 if (objgs_KnowledgesLogicEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objgs_KnowledgesLogicEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseKnowledgeId, congs_KnowledgesLogic.CourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.CourseKnowledgeId); //知识点Id
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.CourseKnowledgeTitle))
 {
 if (objgs_KnowledgesLogicEN.CourseKnowledgeTitle !=  null)
 {
 var strCourseKnowledgeTitle = objgs_KnowledgesLogicEN.CourseKnowledgeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseKnowledgeTitle, congs_KnowledgesLogic.CourseKnowledgeTitle); //知识点标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.CourseKnowledgeTitle); //知识点标题
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.XPosition))
 {
 if (objgs_KnowledgesLogicEN.XPosition !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_KnowledgesLogicEN.XPosition, congs_KnowledgesLogic.XPosition); //X_坐标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.XPosition); //X_坐标
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.YPosition))
 {
 if (objgs_KnowledgesLogicEN.YPosition !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_KnowledgesLogicEN.YPosition, congs_KnowledgesLogic.YPosition); //Y_坐标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.YPosition); //Y_坐标
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.KnowledgeGraphId))
 {
 if (objgs_KnowledgesLogicEN.KnowledgeGraphId !=  null)
 {
 var strKnowledgeGraphId = objgs_KnowledgesLogicEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeGraphId, congs_KnowledgesLogic.KnowledgeGraphId); //知识点图Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.KnowledgeGraphId); //知识点图Id
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.NodeColor))
 {
 if (objgs_KnowledgesLogicEN.NodeColor !=  null)
 {
 var strNodeColor = objgs_KnowledgesLogicEN.NodeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNodeColor, congs_KnowledgesLogic.NodeColor); //结点颜色
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.NodeColor); //结点颜色
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.LogicNodeId))
 {
 if (objgs_KnowledgesLogicEN.LogicNodeId !=  null)
 {
 var strLogicNodeId = objgs_KnowledgesLogicEN.LogicNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLogicNodeId, congs_KnowledgesLogic.LogicNodeId); //逻辑节点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.LogicNodeId); //逻辑节点Id
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.ClassNameCss))
 {
 if (objgs_KnowledgesLogicEN.ClassNameCss !=  null)
 {
 var strClassNameCss = objgs_KnowledgesLogicEN.ClassNameCss.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClassNameCss, congs_KnowledgesLogic.ClassNameCss); //样式名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.ClassNameCss); //样式名称
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.CourseId))
 {
 if (objgs_KnowledgesLogicEN.CourseId !=  null)
 {
 var strCourseId = objgs_KnowledgesLogicEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, congs_KnowledgesLogic.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.CourseId); //课程Id
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.UpdDate))
 {
 if (objgs_KnowledgesLogicEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_KnowledgesLogicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_KnowledgesLogic.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.UpdDate); //修改日期
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.UpdUser))
 {
 if (objgs_KnowledgesLogicEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_KnowledgesLogicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_KnowledgesLogic.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.UpdUser); //修改人
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.Memo))
 {
 if (objgs_KnowledgesLogicEN.Memo !=  null)
 {
 var strMemo = objgs_KnowledgesLogicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_KnowledgesLogic.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objgs_KnowledgesLogicEN.mId); 
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
 /// <param name = "objgs_KnowledgesLogicEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN, string strCondition)
{
 objgs_KnowledgesLogicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_KnowledgesLogicEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_KnowledgesLogicEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_KnowledgesLogic Set ");
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.CourseKnowledgeId))
 {
 if (objgs_KnowledgesLogicEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objgs_KnowledgesLogicEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseKnowledgeId = '{0}',", strCourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.Append(" CourseKnowledgeId = null,"); //知识点Id
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.CourseKnowledgeTitle))
 {
 if (objgs_KnowledgesLogicEN.CourseKnowledgeTitle !=  null)
 {
 var strCourseKnowledgeTitle = objgs_KnowledgesLogicEN.CourseKnowledgeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseKnowledgeTitle = '{0}',", strCourseKnowledgeTitle); //知识点标题
 }
 else
 {
 sbSQL.Append(" CourseKnowledgeTitle = null,"); //知识点标题
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.XPosition))
 {
 if (objgs_KnowledgesLogicEN.XPosition !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_KnowledgesLogicEN.XPosition, congs_KnowledgesLogic.XPosition); //X_坐标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.XPosition); //X_坐标
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.YPosition))
 {
 if (objgs_KnowledgesLogicEN.YPosition !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_KnowledgesLogicEN.YPosition, congs_KnowledgesLogic.YPosition); //Y_坐标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.YPosition); //Y_坐标
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.KnowledgeGraphId))
 {
 if (objgs_KnowledgesLogicEN.KnowledgeGraphId !=  null)
 {
 var strKnowledgeGraphId = objgs_KnowledgesLogicEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeGraphId = '{0}',", strKnowledgeGraphId); //知识点图Id
 }
 else
 {
 sbSQL.Append(" KnowledgeGraphId = null,"); //知识点图Id
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.NodeColor))
 {
 if (objgs_KnowledgesLogicEN.NodeColor !=  null)
 {
 var strNodeColor = objgs_KnowledgesLogicEN.NodeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NodeColor = '{0}',", strNodeColor); //结点颜色
 }
 else
 {
 sbSQL.Append(" NodeColor = null,"); //结点颜色
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.LogicNodeId))
 {
 if (objgs_KnowledgesLogicEN.LogicNodeId !=  null)
 {
 var strLogicNodeId = objgs_KnowledgesLogicEN.LogicNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LogicNodeId = '{0}',", strLogicNodeId); //逻辑节点Id
 }
 else
 {
 sbSQL.Append(" LogicNodeId = null,"); //逻辑节点Id
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.ClassNameCss))
 {
 if (objgs_KnowledgesLogicEN.ClassNameCss !=  null)
 {
 var strClassNameCss = objgs_KnowledgesLogicEN.ClassNameCss.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassNameCss = '{0}',", strClassNameCss); //样式名称
 }
 else
 {
 sbSQL.Append(" ClassNameCss = null,"); //样式名称
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.CourseId))
 {
 if (objgs_KnowledgesLogicEN.CourseId !=  null)
 {
 var strCourseId = objgs_KnowledgesLogicEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.UpdDate))
 {
 if (objgs_KnowledgesLogicEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_KnowledgesLogicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.UpdUser))
 {
 if (objgs_KnowledgesLogicEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_KnowledgesLogicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.Memo))
 {
 if (objgs_KnowledgesLogicEN.Memo !=  null)
 {
 var strMemo = objgs_KnowledgesLogicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objgs_KnowledgesLogicEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objgs_KnowledgesLogicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_KnowledgesLogicEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_KnowledgesLogicEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_KnowledgesLogic Set ");
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.CourseKnowledgeId))
 {
 if (objgs_KnowledgesLogicEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objgs_KnowledgesLogicEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseKnowledgeId = '{0}',", strCourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.Append(" CourseKnowledgeId = null,"); //知识点Id
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.CourseKnowledgeTitle))
 {
 if (objgs_KnowledgesLogicEN.CourseKnowledgeTitle !=  null)
 {
 var strCourseKnowledgeTitle = objgs_KnowledgesLogicEN.CourseKnowledgeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseKnowledgeTitle = '{0}',", strCourseKnowledgeTitle); //知识点标题
 }
 else
 {
 sbSQL.Append(" CourseKnowledgeTitle = null,"); //知识点标题
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.XPosition))
 {
 if (objgs_KnowledgesLogicEN.XPosition !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_KnowledgesLogicEN.XPosition, congs_KnowledgesLogic.XPosition); //X_坐标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.XPosition); //X_坐标
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.YPosition))
 {
 if (objgs_KnowledgesLogicEN.YPosition !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_KnowledgesLogicEN.YPosition, congs_KnowledgesLogic.YPosition); //Y_坐标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.YPosition); //Y_坐标
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.KnowledgeGraphId))
 {
 if (objgs_KnowledgesLogicEN.KnowledgeGraphId !=  null)
 {
 var strKnowledgeGraphId = objgs_KnowledgesLogicEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeGraphId = '{0}',", strKnowledgeGraphId); //知识点图Id
 }
 else
 {
 sbSQL.Append(" KnowledgeGraphId = null,"); //知识点图Id
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.NodeColor))
 {
 if (objgs_KnowledgesLogicEN.NodeColor !=  null)
 {
 var strNodeColor = objgs_KnowledgesLogicEN.NodeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NodeColor = '{0}',", strNodeColor); //结点颜色
 }
 else
 {
 sbSQL.Append(" NodeColor = null,"); //结点颜色
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.LogicNodeId))
 {
 if (objgs_KnowledgesLogicEN.LogicNodeId !=  null)
 {
 var strLogicNodeId = objgs_KnowledgesLogicEN.LogicNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LogicNodeId = '{0}',", strLogicNodeId); //逻辑节点Id
 }
 else
 {
 sbSQL.Append(" LogicNodeId = null,"); //逻辑节点Id
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.ClassNameCss))
 {
 if (objgs_KnowledgesLogicEN.ClassNameCss !=  null)
 {
 var strClassNameCss = objgs_KnowledgesLogicEN.ClassNameCss.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassNameCss = '{0}',", strClassNameCss); //样式名称
 }
 else
 {
 sbSQL.Append(" ClassNameCss = null,"); //样式名称
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.CourseId))
 {
 if (objgs_KnowledgesLogicEN.CourseId !=  null)
 {
 var strCourseId = objgs_KnowledgesLogicEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.UpdDate))
 {
 if (objgs_KnowledgesLogicEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_KnowledgesLogicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.UpdUser))
 {
 if (objgs_KnowledgesLogicEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_KnowledgesLogicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.Memo))
 {
 if (objgs_KnowledgesLogicEN.Memo !=  null)
 {
 var strMemo = objgs_KnowledgesLogicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objgs_KnowledgesLogicEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objgs_KnowledgesLogicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_KnowledgesLogicEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_KnowledgesLogicEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_KnowledgesLogic Set ");
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.CourseKnowledgeId))
 {
 if (objgs_KnowledgesLogicEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objgs_KnowledgesLogicEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseKnowledgeId, congs_KnowledgesLogic.CourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.CourseKnowledgeId); //知识点Id
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.CourseKnowledgeTitle))
 {
 if (objgs_KnowledgesLogicEN.CourseKnowledgeTitle !=  null)
 {
 var strCourseKnowledgeTitle = objgs_KnowledgesLogicEN.CourseKnowledgeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseKnowledgeTitle, congs_KnowledgesLogic.CourseKnowledgeTitle); //知识点标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.CourseKnowledgeTitle); //知识点标题
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.XPosition))
 {
 if (objgs_KnowledgesLogicEN.XPosition !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_KnowledgesLogicEN.XPosition, congs_KnowledgesLogic.XPosition); //X_坐标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.XPosition); //X_坐标
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.YPosition))
 {
 if (objgs_KnowledgesLogicEN.YPosition !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objgs_KnowledgesLogicEN.YPosition, congs_KnowledgesLogic.YPosition); //Y_坐标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.YPosition); //Y_坐标
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.KnowledgeGraphId))
 {
 if (objgs_KnowledgesLogicEN.KnowledgeGraphId !=  null)
 {
 var strKnowledgeGraphId = objgs_KnowledgesLogicEN.KnowledgeGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeGraphId, congs_KnowledgesLogic.KnowledgeGraphId); //知识点图Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.KnowledgeGraphId); //知识点图Id
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.NodeColor))
 {
 if (objgs_KnowledgesLogicEN.NodeColor !=  null)
 {
 var strNodeColor = objgs_KnowledgesLogicEN.NodeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNodeColor, congs_KnowledgesLogic.NodeColor); //结点颜色
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.NodeColor); //结点颜色
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.LogicNodeId))
 {
 if (objgs_KnowledgesLogicEN.LogicNodeId !=  null)
 {
 var strLogicNodeId = objgs_KnowledgesLogicEN.LogicNodeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLogicNodeId, congs_KnowledgesLogic.LogicNodeId); //逻辑节点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.LogicNodeId); //逻辑节点Id
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.ClassNameCss))
 {
 if (objgs_KnowledgesLogicEN.ClassNameCss !=  null)
 {
 var strClassNameCss = objgs_KnowledgesLogicEN.ClassNameCss.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClassNameCss, congs_KnowledgesLogic.ClassNameCss); //样式名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.ClassNameCss); //样式名称
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.CourseId))
 {
 if (objgs_KnowledgesLogicEN.CourseId !=  null)
 {
 var strCourseId = objgs_KnowledgesLogicEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, congs_KnowledgesLogic.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.CourseId); //课程Id
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.UpdDate))
 {
 if (objgs_KnowledgesLogicEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_KnowledgesLogicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_KnowledgesLogic.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.UpdDate); //修改日期
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.UpdUser))
 {
 if (objgs_KnowledgesLogicEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_KnowledgesLogicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_KnowledgesLogic.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.UpdUser); //修改人
 }
 }
 
 if (objgs_KnowledgesLogicEN.IsUpdated(congs_KnowledgesLogic.Memo))
 {
 if (objgs_KnowledgesLogicEN.Memo !=  null)
 {
 var strMemo = objgs_KnowledgesLogicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_KnowledgesLogic.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_KnowledgesLogic.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objgs_KnowledgesLogicEN.mId); 
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
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("gs_KnowledgesLogic_Delete", values);
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
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
//删除gs_KnowledgesLogic本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_KnowledgesLogic where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delgs_KnowledgesLogic(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
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
//删除gs_KnowledgesLogic本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_KnowledgesLogic where mId in (" + strKeyList + ")";
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
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
//删除gs_KnowledgesLogic本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_KnowledgesLogic where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delgs_KnowledgesLogic(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsgs_KnowledgesLogicDA: Delgs_KnowledgesLogic)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_KnowledgesLogic where " + strCondition ;
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
public bool Delgs_KnowledgesLogicWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsgs_KnowledgesLogicDA: Delgs_KnowledgesLogicWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_KnowledgesLogic where " + strCondition ;
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
 /// <param name = "objgs_KnowledgesLogicENS">源对象</param>
 /// <param name = "objgs_KnowledgesLogicENT">目标对象</param>
public void CopyTo(clsgs_KnowledgesLogicEN objgs_KnowledgesLogicENS, clsgs_KnowledgesLogicEN objgs_KnowledgesLogicENT)
{
objgs_KnowledgesLogicENT.mId = objgs_KnowledgesLogicENS.mId; //mId
objgs_KnowledgesLogicENT.CourseKnowledgeId = objgs_KnowledgesLogicENS.CourseKnowledgeId; //知识点Id
objgs_KnowledgesLogicENT.CourseKnowledgeTitle = objgs_KnowledgesLogicENS.CourseKnowledgeTitle; //知识点标题
objgs_KnowledgesLogicENT.XPosition = objgs_KnowledgesLogicENS.XPosition; //X_坐标
objgs_KnowledgesLogicENT.YPosition = objgs_KnowledgesLogicENS.YPosition; //Y_坐标
objgs_KnowledgesLogicENT.KnowledgeGraphId = objgs_KnowledgesLogicENS.KnowledgeGraphId; //知识点图Id
objgs_KnowledgesLogicENT.NodeColor = objgs_KnowledgesLogicENS.NodeColor; //结点颜色
objgs_KnowledgesLogicENT.LogicNodeId = objgs_KnowledgesLogicENS.LogicNodeId; //逻辑节点Id
objgs_KnowledgesLogicENT.ClassNameCss = objgs_KnowledgesLogicENS.ClassNameCss; //样式名称
objgs_KnowledgesLogicENT.CourseId = objgs_KnowledgesLogicENS.CourseId; //课程Id
objgs_KnowledgesLogicENT.UpdDate = objgs_KnowledgesLogicENS.UpdDate; //修改日期
objgs_KnowledgesLogicENT.UpdUser = objgs_KnowledgesLogicENS.UpdUser; //修改人
objgs_KnowledgesLogicENT.Memo = objgs_KnowledgesLogicENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objgs_KnowledgesLogicEN.CourseKnowledgeId, congs_KnowledgesLogic.CourseKnowledgeId);
clsCheckSql.CheckFieldNotNull(objgs_KnowledgesLogicEN.CourseId, congs_KnowledgesLogic.CourseId);
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.CourseKnowledgeId, 8, congs_KnowledgesLogic.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.CourseKnowledgeTitle, 100, congs_KnowledgesLogic.CourseKnowledgeTitle);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.KnowledgeGraphId, 10, congs_KnowledgesLogic.KnowledgeGraphId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.NodeColor, 50, congs_KnowledgesLogic.NodeColor);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.LogicNodeId, 20, congs_KnowledgesLogic.LogicNodeId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.ClassNameCss, 100, congs_KnowledgesLogic.ClassNameCss);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.CourseId, 8, congs_KnowledgesLogic.CourseId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.UpdDate, 20, congs_KnowledgesLogic.UpdDate);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.UpdUser, 20, congs_KnowledgesLogic.UpdUser);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.Memo, 1000, congs_KnowledgesLogic.Memo);
//检查字段外键固定长度
 objgs_KnowledgesLogicEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.CourseKnowledgeId, 8, congs_KnowledgesLogic.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.CourseKnowledgeTitle, 100, congs_KnowledgesLogic.CourseKnowledgeTitle);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.KnowledgeGraphId, 10, congs_KnowledgesLogic.KnowledgeGraphId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.NodeColor, 50, congs_KnowledgesLogic.NodeColor);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.LogicNodeId, 20, congs_KnowledgesLogic.LogicNodeId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.ClassNameCss, 100, congs_KnowledgesLogic.ClassNameCss);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.CourseId, 8, congs_KnowledgesLogic.CourseId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.UpdDate, 20, congs_KnowledgesLogic.UpdDate);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.UpdUser, 20, congs_KnowledgesLogic.UpdUser);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.Memo, 1000, congs_KnowledgesLogic.Memo);
//检查外键字段长度
 objgs_KnowledgesLogicEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.CourseKnowledgeId, 8, congs_KnowledgesLogic.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.CourseKnowledgeTitle, 100, congs_KnowledgesLogic.CourseKnowledgeTitle);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.KnowledgeGraphId, 10, congs_KnowledgesLogic.KnowledgeGraphId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.NodeColor, 50, congs_KnowledgesLogic.NodeColor);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.LogicNodeId, 20, congs_KnowledgesLogic.LogicNodeId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.ClassNameCss, 100, congs_KnowledgesLogic.ClassNameCss);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.CourseId, 8, congs_KnowledgesLogic.CourseId);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.UpdDate, 20, congs_KnowledgesLogic.UpdDate);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.UpdUser, 20, congs_KnowledgesLogic.UpdUser);
clsCheckSql.CheckFieldLen(objgs_KnowledgesLogicEN.Memo, 1000, congs_KnowledgesLogic.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesLogicEN.CourseKnowledgeId, congs_KnowledgesLogic.CourseKnowledgeId);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesLogicEN.CourseKnowledgeTitle, congs_KnowledgesLogic.CourseKnowledgeTitle);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesLogicEN.KnowledgeGraphId, congs_KnowledgesLogic.KnowledgeGraphId);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesLogicEN.NodeColor, congs_KnowledgesLogic.NodeColor);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesLogicEN.LogicNodeId, congs_KnowledgesLogic.LogicNodeId);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesLogicEN.ClassNameCss, congs_KnowledgesLogic.ClassNameCss);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesLogicEN.CourseId, congs_KnowledgesLogic.CourseId);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesLogicEN.UpdDate, congs_KnowledgesLogic.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesLogicEN.UpdUser, congs_KnowledgesLogic.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objgs_KnowledgesLogicEN.Memo, congs_KnowledgesLogic.Memo);
//检查外键字段长度
 objgs_KnowledgesLogicEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--gs_KnowledgesLogic(知识点逻辑),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsgs_KnowledgesLogicEN objgs_KnowledgesLogicEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objgs_KnowledgesLogicEN.CourseKnowledgeId);
 if (objgs_KnowledgesLogicEN.KnowledgeGraphId == null)
{
 sbCondition.AppendFormat(" and KnowledgeGraphId is null");
}
else
{
 sbCondition.AppendFormat(" and KnowledgeGraphId = '{0}'", objgs_KnowledgesLogicEN.KnowledgeGraphId);
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
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
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
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
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
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_KnowledgesLogicEN._CurrTabName);
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
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_KnowledgesLogicEN._CurrTabName, strCondition);
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
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
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
 objSQL = clsgs_KnowledgesLogicDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}