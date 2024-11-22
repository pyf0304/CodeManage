
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_ResearchPlanDA
 表名:vgs_ResearchPlan(01120662)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:01:37
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 主题研究计划视图(vgs_ResearchPlan)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvgs_ResearchPlanDA : clsCommBase4DA
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
 return clsvgs_ResearchPlanEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvgs_ResearchPlanEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_ResearchPlanEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvgs_ResearchPlanEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvgs_ResearchPlanEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strPlanId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strPlanId)
{
strPlanId = strPlanId.Replace("'", "''");
if (strPlanId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vgs_ResearchPlan中,检查关键字,长度不正确!(clsvgs_ResearchPlanDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPlanId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vgs_ResearchPlan中,关键字不能为空 或 null!(clsvgs_ResearchPlanDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPlanId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvgs_ResearchPlanDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvgs_ResearchPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from vgs_ResearchPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vgs_ResearchPlan(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvgs_ResearchPlanDA: GetDataTable_vgs_ResearchPlan)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from vgs_ResearchPlan where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvgs_ResearchPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvgs_ResearchPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from vgs_ResearchPlan where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvgs_ResearchPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvgs_ResearchPlanDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_ResearchPlan where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_ResearchPlan where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvgs_ResearchPlanDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vgs_ResearchPlan where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvgs_ResearchPlanDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_ResearchPlan.* from vgs_ResearchPlan Left Join {1} on {2} where {3} and vgs_ResearchPlan.PlanId not in (Select top {5} vgs_ResearchPlan.PlanId from vgs_ResearchPlan Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_ResearchPlan where {1} and PlanId not in (Select top {2} PlanId from vgs_ResearchPlan where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_ResearchPlan where {1} and PlanId not in (Select top {3} PlanId from vgs_ResearchPlan where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvgs_ResearchPlanDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_ResearchPlan.* from vgs_ResearchPlan Left Join {1} on {2} where {3} and vgs_ResearchPlan.PlanId not in (Select top {5} vgs_ResearchPlan.PlanId from vgs_ResearchPlan Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_ResearchPlan where {1} and PlanId not in (Select top {2} PlanId from vgs_ResearchPlan where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_ResearchPlan where {1} and PlanId not in (Select top {3} PlanId from vgs_ResearchPlan where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvgs_ResearchPlanEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvgs_ResearchPlanDA:GetObjLst)", objException.Message));
}
List<clsvgs_ResearchPlanEN> arrObjLst = new List<clsvgs_ResearchPlanEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from vgs_ResearchPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
try
{
objvgs_ResearchPlanEN.PlanId = objRow[convgs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objvgs_ResearchPlanEN.TopicId = objRow[convgs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchPlanEN.TopicName = objRow[convgs_ResearchPlan.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchPlanEN.IdCurrEduCls = objRow[convgs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchPlanEN.StatusId = objRow[convgs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objvgs_ResearchPlanEN.StatusName = objRow[convgs_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvgs_ResearchPlanEN.PlanContent = objRow[convgs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvgs_ResearchPlanEN.ResponsibleUser = objRow[convgs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvgs_ResearchPlanEN.StartDate = objRow[convgs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvgs_ResearchPlanEN.EndDate = objRow[convgs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvgs_ResearchPlanEN.ActualFinishingDate = objRow[convgs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvgs_ResearchPlanEN.AcceptanceUser = objRow[convgs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvgs_ResearchPlanEN.IsSubmit = TransNullToBool(objRow[convgs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvgs_ResearchPlanEN.UpdUser = objRow[convgs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchPlanEN.UpdDate = objRow[convgs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchPlanEN.Memo = objRow[convgs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convgs_ResearchPlan.Memo].ToString().Trim(); //备注
objvgs_ResearchPlanEN.PlanTypeId = objRow[convgs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_ResearchPlanDA: GetObjLst)", objException.Message));
}
objvgs_ResearchPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_ResearchPlanEN);
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
public List<clsvgs_ResearchPlanEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvgs_ResearchPlanDA:GetObjLstByTabName)", objException.Message));
}
List<clsvgs_ResearchPlanEN> arrObjLst = new List<clsvgs_ResearchPlanEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
try
{
objvgs_ResearchPlanEN.PlanId = objRow[convgs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objvgs_ResearchPlanEN.TopicId = objRow[convgs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchPlanEN.TopicName = objRow[convgs_ResearchPlan.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchPlanEN.IdCurrEduCls = objRow[convgs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchPlanEN.StatusId = objRow[convgs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objvgs_ResearchPlanEN.StatusName = objRow[convgs_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvgs_ResearchPlanEN.PlanContent = objRow[convgs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvgs_ResearchPlanEN.ResponsibleUser = objRow[convgs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvgs_ResearchPlanEN.StartDate = objRow[convgs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvgs_ResearchPlanEN.EndDate = objRow[convgs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvgs_ResearchPlanEN.ActualFinishingDate = objRow[convgs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvgs_ResearchPlanEN.AcceptanceUser = objRow[convgs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvgs_ResearchPlanEN.IsSubmit = TransNullToBool(objRow[convgs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvgs_ResearchPlanEN.UpdUser = objRow[convgs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchPlanEN.UpdDate = objRow[convgs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchPlanEN.Memo = objRow[convgs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convgs_ResearchPlan.Memo].ToString().Trim(); //备注
objvgs_ResearchPlanEN.PlanTypeId = objRow[convgs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_ResearchPlanDA: GetObjLst)", objException.Message));
}
objvgs_ResearchPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_ResearchPlanEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvgs_ResearchPlan(ref clsvgs_ResearchPlanEN objvgs_ResearchPlanEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from vgs_ResearchPlan where PlanId = " + "'"+ objvgs_ResearchPlanEN.PlanId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvgs_ResearchPlanEN.PlanId = objDT.Rows[0][convgs_ResearchPlan.PlanId].ToString().Trim(); //计划Id(字段类型:char,字段长度:8,是否可空:False)
 objvgs_ResearchPlanEN.TopicId = objDT.Rows[0][convgs_ResearchPlan.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_ResearchPlanEN.TopicName = objDT.Rows[0][convgs_ResearchPlan.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_ResearchPlanEN.IdCurrEduCls = objDT.Rows[0][convgs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvgs_ResearchPlanEN.StatusId = objDT.Rows[0][convgs_ResearchPlan.StatusId].ToString().Trim(); //状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvgs_ResearchPlanEN.StatusName = objDT.Rows[0][convgs_ResearchPlan.StatusName].ToString().Trim(); //状态名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_ResearchPlanEN.PlanContent = objDT.Rows[0][convgs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_ResearchPlanEN.ResponsibleUser = objDT.Rows[0][convgs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_ResearchPlanEN.StartDate = objDT.Rows[0][convgs_ResearchPlan.StartDate].ToString().Trim(); //开始日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_ResearchPlanEN.EndDate = objDT.Rows[0][convgs_ResearchPlan.EndDate].ToString().Trim(); //截止日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_ResearchPlanEN.ActualFinishingDate = objDT.Rows[0][convgs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_ResearchPlanEN.AcceptanceUser = objDT.Rows[0][convgs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_ResearchPlanEN.IsSubmit = TransNullToBool(objDT.Rows[0][convgs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_ResearchPlanEN.UpdUser = objDT.Rows[0][convgs_ResearchPlan.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_ResearchPlanEN.UpdDate = objDT.Rows[0][convgs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_ResearchPlanEN.Memo = objDT.Rows[0][convgs_ResearchPlan.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_ResearchPlanEN.PlanTypeId = objDT.Rows[0][convgs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvgs_ResearchPlanDA: Getvgs_ResearchPlan)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPlanId">表关键字</param>
 /// <returns>表对象</returns>
public clsvgs_ResearchPlanEN GetObjByPlanId(string strPlanId)
{
CheckPrimaryKey(strPlanId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from vgs_ResearchPlan where PlanId = " + "'"+ strPlanId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
try
{
 objvgs_ResearchPlanEN.PlanId = objRow[convgs_ResearchPlan.PlanId].ToString().Trim(); //计划Id(字段类型:char,字段长度:8,是否可空:False)
 objvgs_ResearchPlanEN.TopicId = objRow[convgs_ResearchPlan.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_ResearchPlanEN.TopicName = objRow[convgs_ResearchPlan.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_ResearchPlanEN.IdCurrEduCls = objRow[convgs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvgs_ResearchPlanEN.StatusId = objRow[convgs_ResearchPlan.StatusId].ToString().Trim(); //状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvgs_ResearchPlanEN.StatusName = objRow[convgs_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StatusName].ToString().Trim(); //状态名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_ResearchPlanEN.PlanContent = objRow[convgs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_ResearchPlanEN.ResponsibleUser = objRow[convgs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_ResearchPlanEN.StartDate = objRow[convgs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StartDate].ToString().Trim(); //开始日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_ResearchPlanEN.EndDate = objRow[convgs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.EndDate].ToString().Trim(); //截止日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_ResearchPlanEN.ActualFinishingDate = objRow[convgs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_ResearchPlanEN.AcceptanceUser = objRow[convgs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_ResearchPlanEN.UpdUser = objRow[convgs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_ResearchPlanEN.UpdDate = objRow[convgs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_ResearchPlanEN.Memo = objRow[convgs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convgs_ResearchPlan.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_ResearchPlanEN.PlanTypeId = objRow[convgs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvgs_ResearchPlanDA: GetObjByPlanId)", objException.Message));
}
return objvgs_ResearchPlanEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvgs_ResearchPlanEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvgs_ResearchPlanDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from vgs_ResearchPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN()
{
PlanId = objRow[convgs_ResearchPlan.PlanId].ToString().Trim(), //计划Id
TopicId = objRow[convgs_ResearchPlan.TopicId].ToString().Trim(), //主题Id
TopicName = objRow[convgs_ResearchPlan.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.TopicName].ToString().Trim(), //栏目主题
IdCurrEduCls = objRow[convgs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchPlan.IdCurrEduCls].ToString().Trim(), //教学班流水号
StatusId = objRow[convgs_ResearchPlan.StatusId].ToString().Trim(), //状态Id
StatusName = objRow[convgs_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StatusName].ToString().Trim(), //状态名称
PlanContent = objRow[convgs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanContent].ToString().Trim(), //计划内容
ResponsibleUser = objRow[convgs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ResponsibleUser].ToString().Trim(), //负责人/小组
StartDate = objRow[convgs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StartDate].ToString().Trim(), //开始日期
EndDate = objRow[convgs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.EndDate].ToString().Trim(), //截止日期
ActualFinishingDate = objRow[convgs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ActualFinishingDate].ToString().Trim(), //实际完成日期
AcceptanceUser = objRow[convgs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.AcceptanceUser].ToString().Trim(), //验收用户
IsSubmit = TransNullToBool(objRow[convgs_ResearchPlan.IsSubmit].ToString().Trim()), //是否提交
UpdUser = objRow[convgs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[convgs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convgs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convgs_ResearchPlan.Memo].ToString().Trim(), //备注
PlanTypeId = objRow[convgs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanTypeId].ToString().Trim() //计划类型
};
objvgs_ResearchPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_ResearchPlanEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvgs_ResearchPlanDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvgs_ResearchPlanEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
try
{
objvgs_ResearchPlanEN.PlanId = objRow[convgs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objvgs_ResearchPlanEN.TopicId = objRow[convgs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchPlanEN.TopicName = objRow[convgs_ResearchPlan.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchPlanEN.IdCurrEduCls = objRow[convgs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchPlanEN.StatusId = objRow[convgs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objvgs_ResearchPlanEN.StatusName = objRow[convgs_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvgs_ResearchPlanEN.PlanContent = objRow[convgs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvgs_ResearchPlanEN.ResponsibleUser = objRow[convgs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvgs_ResearchPlanEN.StartDate = objRow[convgs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvgs_ResearchPlanEN.EndDate = objRow[convgs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvgs_ResearchPlanEN.ActualFinishingDate = objRow[convgs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvgs_ResearchPlanEN.AcceptanceUser = objRow[convgs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvgs_ResearchPlanEN.IsSubmit = TransNullToBool(objRow[convgs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvgs_ResearchPlanEN.UpdUser = objRow[convgs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchPlanEN.UpdDate = objRow[convgs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchPlanEN.Memo = objRow[convgs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convgs_ResearchPlan.Memo].ToString().Trim(); //备注
objvgs_ResearchPlanEN.PlanTypeId = objRow[convgs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvgs_ResearchPlanDA: GetObjByDataRowvgs_ResearchPlan)", objException.Message));
}
objvgs_ResearchPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_ResearchPlanEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvgs_ResearchPlanEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
try
{
objvgs_ResearchPlanEN.PlanId = objRow[convgs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objvgs_ResearchPlanEN.TopicId = objRow[convgs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchPlanEN.TopicName = objRow[convgs_ResearchPlan.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchPlanEN.IdCurrEduCls = objRow[convgs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchPlanEN.StatusId = objRow[convgs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objvgs_ResearchPlanEN.StatusName = objRow[convgs_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvgs_ResearchPlanEN.PlanContent = objRow[convgs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvgs_ResearchPlanEN.ResponsibleUser = objRow[convgs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvgs_ResearchPlanEN.StartDate = objRow[convgs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvgs_ResearchPlanEN.EndDate = objRow[convgs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvgs_ResearchPlanEN.ActualFinishingDate = objRow[convgs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvgs_ResearchPlanEN.AcceptanceUser = objRow[convgs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvgs_ResearchPlanEN.IsSubmit = TransNullToBool(objRow[convgs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvgs_ResearchPlanEN.UpdUser = objRow[convgs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchPlanEN.UpdDate = objRow[convgs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchPlanEN.Memo = objRow[convgs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convgs_ResearchPlan.Memo].ToString().Trim(); //备注
objvgs_ResearchPlanEN.PlanTypeId = objRow[convgs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvgs_ResearchPlanDA: GetObjByDataRow)", objException.Message));
}
objvgs_ResearchPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_ResearchPlanEN;
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
objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_ResearchPlanEN._CurrTabName, convgs_ResearchPlan.PlanId, 8, "");
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
objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_ResearchPlanEN._CurrTabName, convgs_ResearchPlan.PlanId, 8, strPrefix);
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
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PlanId from vgs_ResearchPlan where " + strCondition;
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
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PlanId from vgs_ResearchPlan where " + strCondition;
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
 /// <param name = "strPlanId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strPlanId)
{
CheckPrimaryKey(strPlanId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_ResearchPlan", "PlanId = " + "'"+ strPlanId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvgs_ResearchPlanDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_ResearchPlan", strCondition))
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
objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vgs_ResearchPlan");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanENS">源对象</param>
 /// <param name = "objvgs_ResearchPlanENT">目标对象</param>
public void CopyTo(clsvgs_ResearchPlanEN objvgs_ResearchPlanENS, clsvgs_ResearchPlanEN objvgs_ResearchPlanENT)
{
objvgs_ResearchPlanENT.PlanId = objvgs_ResearchPlanENS.PlanId; //计划Id
objvgs_ResearchPlanENT.TopicId = objvgs_ResearchPlanENS.TopicId; //主题Id
objvgs_ResearchPlanENT.TopicName = objvgs_ResearchPlanENS.TopicName; //栏目主题
objvgs_ResearchPlanENT.IdCurrEduCls = objvgs_ResearchPlanENS.IdCurrEduCls; //教学班流水号
objvgs_ResearchPlanENT.StatusId = objvgs_ResearchPlanENS.StatusId; //状态Id
objvgs_ResearchPlanENT.StatusName = objvgs_ResearchPlanENS.StatusName; //状态名称
objvgs_ResearchPlanENT.PlanContent = objvgs_ResearchPlanENS.PlanContent; //计划内容
objvgs_ResearchPlanENT.ResponsibleUser = objvgs_ResearchPlanENS.ResponsibleUser; //负责人/小组
objvgs_ResearchPlanENT.StartDate = objvgs_ResearchPlanENS.StartDate; //开始日期
objvgs_ResearchPlanENT.EndDate = objvgs_ResearchPlanENS.EndDate; //截止日期
objvgs_ResearchPlanENT.ActualFinishingDate = objvgs_ResearchPlanENS.ActualFinishingDate; //实际完成日期
objvgs_ResearchPlanENT.AcceptanceUser = objvgs_ResearchPlanENS.AcceptanceUser; //验收用户
objvgs_ResearchPlanENT.IsSubmit = objvgs_ResearchPlanENS.IsSubmit; //是否提交
objvgs_ResearchPlanENT.UpdUser = objvgs_ResearchPlanENS.UpdUser; //修改人
objvgs_ResearchPlanENT.UpdDate = objvgs_ResearchPlanENS.UpdDate; //修改日期
objvgs_ResearchPlanENT.Memo = objvgs_ResearchPlanENS.Memo; //备注
objvgs_ResearchPlanENT.PlanTypeId = objvgs_ResearchPlanENS.PlanTypeId; //计划类型
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvgs_ResearchPlanEN objvgs_ResearchPlanEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvgs_ResearchPlanEN.PlanId, 8, convgs_ResearchPlan.PlanId);
clsCheckSql.CheckFieldLen(objvgs_ResearchPlanEN.TopicId, 8, convgs_ResearchPlan.TopicId);
clsCheckSql.CheckFieldLen(objvgs_ResearchPlanEN.TopicName, 200, convgs_ResearchPlan.TopicName);
clsCheckSql.CheckFieldLen(objvgs_ResearchPlanEN.IdCurrEduCls, 8, convgs_ResearchPlan.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvgs_ResearchPlanEN.StatusId, 2, convgs_ResearchPlan.StatusId);
clsCheckSql.CheckFieldLen(objvgs_ResearchPlanEN.StatusName, 100, convgs_ResearchPlan.StatusName);
clsCheckSql.CheckFieldLen(objvgs_ResearchPlanEN.PlanContent, 1000, convgs_ResearchPlan.PlanContent);
clsCheckSql.CheckFieldLen(objvgs_ResearchPlanEN.ResponsibleUser, 50, convgs_ResearchPlan.ResponsibleUser);
clsCheckSql.CheckFieldLen(objvgs_ResearchPlanEN.StartDate, 20, convgs_ResearchPlan.StartDate);
clsCheckSql.CheckFieldLen(objvgs_ResearchPlanEN.EndDate, 20, convgs_ResearchPlan.EndDate);
clsCheckSql.CheckFieldLen(objvgs_ResearchPlanEN.ActualFinishingDate, 20, convgs_ResearchPlan.ActualFinishingDate);
clsCheckSql.CheckFieldLen(objvgs_ResearchPlanEN.AcceptanceUser, 50, convgs_ResearchPlan.AcceptanceUser);
clsCheckSql.CheckFieldLen(objvgs_ResearchPlanEN.UpdUser, 20, convgs_ResearchPlan.UpdUser);
clsCheckSql.CheckFieldLen(objvgs_ResearchPlanEN.UpdDate, 20, convgs_ResearchPlan.UpdDate);
clsCheckSql.CheckFieldLen(objvgs_ResearchPlanEN.Memo, 1000, convgs_ResearchPlan.Memo);
clsCheckSql.CheckFieldLen(objvgs_ResearchPlanEN.PlanTypeId, 2, convgs_ResearchPlan.PlanTypeId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchPlanEN.PlanId, convgs_ResearchPlan.PlanId);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchPlanEN.TopicId, convgs_ResearchPlan.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchPlanEN.TopicName, convgs_ResearchPlan.TopicName);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchPlanEN.IdCurrEduCls, convgs_ResearchPlan.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchPlanEN.StatusId, convgs_ResearchPlan.StatusId);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchPlanEN.StatusName, convgs_ResearchPlan.StatusName);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchPlanEN.PlanContent, convgs_ResearchPlan.PlanContent);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchPlanEN.ResponsibleUser, convgs_ResearchPlan.ResponsibleUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchPlanEN.StartDate, convgs_ResearchPlan.StartDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchPlanEN.EndDate, convgs_ResearchPlan.EndDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchPlanEN.ActualFinishingDate, convgs_ResearchPlan.ActualFinishingDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchPlanEN.AcceptanceUser, convgs_ResearchPlan.AcceptanceUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchPlanEN.UpdUser, convgs_ResearchPlan.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchPlanEN.UpdDate, convgs_ResearchPlan.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchPlanEN.Memo, convgs_ResearchPlan.Memo);
clsCheckSql.CheckSqlInjection4Field(objvgs_ResearchPlanEN.PlanTypeId, convgs_ResearchPlan.PlanTypeId);
//检查外键字段长度
 objvgs_ResearchPlanEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetPlanId()
{
//获取某学院所有专业信息
string strSQL = "select PlanId, StatusName from vgs_ResearchPlan ";
 clsSpecSQLforSql mySql = clsvgs_ResearchPlanDA.GetSpecSQLObj();
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
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
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
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
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
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_ResearchPlanEN._CurrTabName);
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
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_ResearchPlanEN._CurrTabName, strCondition);
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
 objSQL = clsvgs_ResearchPlanDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}