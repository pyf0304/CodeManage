﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ResearchPlanDA
 表名:gs_ResearchPlan(01120663)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 主题研究计划(gs_ResearchPlan)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsgs_ResearchPlanDA : clsCommBase4DA
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
 return clsgs_ResearchPlanEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsgs_ResearchPlanEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_ResearchPlanEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsgs_ResearchPlanEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsgs_ResearchPlanEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:gs_ResearchPlan中,检查关键字,长度不正确!(clsgs_ResearchPlanDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPlanId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:gs_ResearchPlan中,关键字不能为空 或 null!(clsgs_ResearchPlanDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPlanId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsgs_ResearchPlanDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsgs_ResearchPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_gs_ResearchPlan(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsgs_ResearchPlanDA: GetDataTable_gs_ResearchPlan)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchPlan where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsgs_ResearchPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsgs_ResearchPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchPlan where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsgs_ResearchPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsgs_ResearchPlanDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_ResearchPlan where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_ResearchPlan where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsgs_ResearchPlanDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from gs_ResearchPlan where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsgs_ResearchPlanDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_ResearchPlan.* from gs_ResearchPlan Left Join {1} on {2} where {3} and gs_ResearchPlan.PlanId not in (Select top {5} gs_ResearchPlan.PlanId from gs_ResearchPlan Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_ResearchPlan where {1} and PlanId not in (Select top {2} PlanId from gs_ResearchPlan where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_ResearchPlan where {1} and PlanId not in (Select top {3} PlanId from gs_ResearchPlan where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsgs_ResearchPlanDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} gs_ResearchPlan.* from gs_ResearchPlan Left Join {1} on {2} where {3} and gs_ResearchPlan.PlanId not in (Select top {5} gs_ResearchPlan.PlanId from gs_ResearchPlan Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from gs_ResearchPlan where {1} and PlanId not in (Select top {2} PlanId from gs_ResearchPlan where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from gs_ResearchPlan where {1} and PlanId not in (Select top {3} PlanId from gs_ResearchPlan where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsgs_ResearchPlanEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsgs_ResearchPlanDA:GetObjLst)", objException.Message));
}
List<clsgs_ResearchPlanEN> arrObjLst = new List<clsgs_ResearchPlanEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchPlanEN objgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
try
{
objgs_ResearchPlanEN.PlanId = objRow[congs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objgs_ResearchPlanEN.TopicId = objRow[congs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objgs_ResearchPlanEN.StatusId = objRow[congs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objgs_ResearchPlanEN.PlanContent = objRow[congs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objgs_ResearchPlanEN.ResponsibleUser = objRow[congs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objgs_ResearchPlanEN.StartDate = objRow[congs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objgs_ResearchPlanEN.EndDate = objRow[congs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objgs_ResearchPlanEN.ActualFinishingDate = objRow[congs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objgs_ResearchPlanEN.AcceptanceUser = objRow[congs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objgs_ResearchPlanEN.IsSubmit = TransNullToBool(objRow[congs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objgs_ResearchPlanEN.UpdUser = objRow[congs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objgs_ResearchPlanEN.UpdDate = objRow[congs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchPlanEN.Memo = objRow[congs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[congs_ResearchPlan.Memo].ToString().Trim(); //备注
objgs_ResearchPlanEN.PlanTypeId = objRow[congs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objgs_ResearchPlanEN.IdCurrEduCls = objRow[congs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_ResearchPlanDA: GetObjLst)", objException.Message));
}
objgs_ResearchPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_ResearchPlanEN);
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
public List<clsgs_ResearchPlanEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsgs_ResearchPlanDA:GetObjLstByTabName)", objException.Message));
}
List<clsgs_ResearchPlanEN> arrObjLst = new List<clsgs_ResearchPlanEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchPlanEN objgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
try
{
objgs_ResearchPlanEN.PlanId = objRow[congs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objgs_ResearchPlanEN.TopicId = objRow[congs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objgs_ResearchPlanEN.StatusId = objRow[congs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objgs_ResearchPlanEN.PlanContent = objRow[congs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objgs_ResearchPlanEN.ResponsibleUser = objRow[congs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objgs_ResearchPlanEN.StartDate = objRow[congs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objgs_ResearchPlanEN.EndDate = objRow[congs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objgs_ResearchPlanEN.ActualFinishingDate = objRow[congs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objgs_ResearchPlanEN.AcceptanceUser = objRow[congs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objgs_ResearchPlanEN.IsSubmit = TransNullToBool(objRow[congs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objgs_ResearchPlanEN.UpdUser = objRow[congs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objgs_ResearchPlanEN.UpdDate = objRow[congs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchPlanEN.Memo = objRow[congs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[congs_ResearchPlan.Memo].ToString().Trim(); //备注
objgs_ResearchPlanEN.PlanTypeId = objRow[congs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objgs_ResearchPlanEN.IdCurrEduCls = objRow[congs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsgs_ResearchPlanDA: GetObjLst)", objException.Message));
}
objgs_ResearchPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objgs_ResearchPlanEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getgs_ResearchPlan(ref clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchPlan where PlanId = " + "'"+ objgs_ResearchPlanEN.PlanId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objgs_ResearchPlanEN.PlanId = objDT.Rows[0][congs_ResearchPlan.PlanId].ToString().Trim(); //计划Id(字段类型:char,字段长度:8,是否可空:False)
 objgs_ResearchPlanEN.TopicId = objDT.Rows[0][congs_ResearchPlan.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_ResearchPlanEN.StatusId = objDT.Rows[0][congs_ResearchPlan.StatusId].ToString().Trim(); //状态Id(字段类型:char,字段长度:2,是否可空:False)
 objgs_ResearchPlanEN.PlanContent = objDT.Rows[0][congs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_ResearchPlanEN.ResponsibleUser = objDT.Rows[0][congs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_ResearchPlanEN.StartDate = objDT.Rows[0][congs_ResearchPlan.StartDate].ToString().Trim(); //开始日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_ResearchPlanEN.EndDate = objDT.Rows[0][congs_ResearchPlan.EndDate].ToString().Trim(); //截止日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_ResearchPlanEN.ActualFinishingDate = objDT.Rows[0][congs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_ResearchPlanEN.AcceptanceUser = objDT.Rows[0][congs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_ResearchPlanEN.IsSubmit = TransNullToBool(objDT.Rows[0][congs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objgs_ResearchPlanEN.UpdUser = objDT.Rows[0][congs_ResearchPlan.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_ResearchPlanEN.UpdDate = objDT.Rows[0][congs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_ResearchPlanEN.Memo = objDT.Rows[0][congs_ResearchPlan.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_ResearchPlanEN.PlanTypeId = objDT.Rows[0][congs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型(字段类型:char,字段长度:2,是否可空:False)
 objgs_ResearchPlanEN.IdCurrEduCls = objDT.Rows[0][congs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsgs_ResearchPlanDA: Getgs_ResearchPlan)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPlanId">表关键字</param>
 /// <returns>表对象</returns>
public clsgs_ResearchPlanEN GetObjByPlanId(string strPlanId)
{
CheckPrimaryKey(strPlanId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchPlan where PlanId = " + "'"+ strPlanId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsgs_ResearchPlanEN objgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
try
{
 objgs_ResearchPlanEN.PlanId = objRow[congs_ResearchPlan.PlanId].ToString().Trim(); //计划Id(字段类型:char,字段长度:8,是否可空:False)
 objgs_ResearchPlanEN.TopicId = objRow[congs_ResearchPlan.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objgs_ResearchPlanEN.StatusId = objRow[congs_ResearchPlan.StatusId].ToString().Trim(); //状态Id(字段类型:char,字段长度:2,是否可空:False)
 objgs_ResearchPlanEN.PlanContent = objRow[congs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_ResearchPlanEN.ResponsibleUser = objRow[congs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_ResearchPlanEN.StartDate = objRow[congs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.StartDate].ToString().Trim(); //开始日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_ResearchPlanEN.EndDate = objRow[congs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.EndDate].ToString().Trim(); //截止日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_ResearchPlanEN.ActualFinishingDate = objRow[congs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_ResearchPlanEN.AcceptanceUser = objRow[congs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户(字段类型:varchar,字段长度:50,是否可空:True)
 objgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objgs_ResearchPlanEN.UpdUser = objRow[congs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_ResearchPlanEN.UpdDate = objRow[congs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objgs_ResearchPlanEN.Memo = objRow[congs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[congs_ResearchPlan.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objgs_ResearchPlanEN.PlanTypeId = objRow[congs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型(字段类型:char,字段长度:2,是否可空:False)
 objgs_ResearchPlanEN.IdCurrEduCls = objRow[congs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsgs_ResearchPlanDA: GetObjByPlanId)", objException.Message));
}
return objgs_ResearchPlanEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsgs_ResearchPlanEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsgs_ResearchPlanDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsgs_ResearchPlanEN objgs_ResearchPlanEN = new clsgs_ResearchPlanEN()
{
PlanId = objRow[congs_ResearchPlan.PlanId].ToString().Trim(), //计划Id
TopicId = objRow[congs_ResearchPlan.TopicId].ToString().Trim(), //主题Id
StatusId = objRow[congs_ResearchPlan.StatusId].ToString().Trim(), //状态Id
PlanContent = objRow[congs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanContent].ToString().Trim(), //计划内容
ResponsibleUser = objRow[congs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.ResponsibleUser].ToString().Trim(), //负责人/小组
StartDate = objRow[congs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.StartDate].ToString().Trim(), //开始日期
EndDate = objRow[congs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.EndDate].ToString().Trim(), //截止日期
ActualFinishingDate = objRow[congs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.ActualFinishingDate].ToString().Trim(), //实际完成日期
AcceptanceUser = objRow[congs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.AcceptanceUser].ToString().Trim(), //验收用户
IsSubmit = TransNullToBool(objRow[congs_ResearchPlan.IsSubmit].ToString().Trim()), //是否提交
UpdUser = objRow[congs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[congs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[congs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[congs_ResearchPlan.Memo].ToString().Trim(), //备注
PlanTypeId = objRow[congs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanTypeId].ToString().Trim(), //计划类型
IdCurrEduCls = objRow[congs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchPlan.IdCurrEduCls].ToString().Trim() //教学班流水号
};
objgs_ResearchPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_ResearchPlanEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsgs_ResearchPlanDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsgs_ResearchPlanEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_ResearchPlanEN objgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
try
{
objgs_ResearchPlanEN.PlanId = objRow[congs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objgs_ResearchPlanEN.TopicId = objRow[congs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objgs_ResearchPlanEN.StatusId = objRow[congs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objgs_ResearchPlanEN.PlanContent = objRow[congs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objgs_ResearchPlanEN.ResponsibleUser = objRow[congs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objgs_ResearchPlanEN.StartDate = objRow[congs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objgs_ResearchPlanEN.EndDate = objRow[congs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objgs_ResearchPlanEN.ActualFinishingDate = objRow[congs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objgs_ResearchPlanEN.AcceptanceUser = objRow[congs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objgs_ResearchPlanEN.IsSubmit = TransNullToBool(objRow[congs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objgs_ResearchPlanEN.UpdUser = objRow[congs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objgs_ResearchPlanEN.UpdDate = objRow[congs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchPlanEN.Memo = objRow[congs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[congs_ResearchPlan.Memo].ToString().Trim(); //备注
objgs_ResearchPlanEN.PlanTypeId = objRow[congs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objgs_ResearchPlanEN.IdCurrEduCls = objRow[congs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsgs_ResearchPlanDA: GetObjByDataRowgs_ResearchPlan)", objException.Message));
}
objgs_ResearchPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_ResearchPlanEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsgs_ResearchPlanEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsgs_ResearchPlanEN objgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
try
{
objgs_ResearchPlanEN.PlanId = objRow[congs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objgs_ResearchPlanEN.TopicId = objRow[congs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objgs_ResearchPlanEN.StatusId = objRow[congs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objgs_ResearchPlanEN.PlanContent = objRow[congs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objgs_ResearchPlanEN.ResponsibleUser = objRow[congs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objgs_ResearchPlanEN.StartDate = objRow[congs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objgs_ResearchPlanEN.EndDate = objRow[congs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objgs_ResearchPlanEN.ActualFinishingDate = objRow[congs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objgs_ResearchPlanEN.AcceptanceUser = objRow[congs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objgs_ResearchPlanEN.IsSubmit = TransNullToBool(objRow[congs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objgs_ResearchPlanEN.UpdUser = objRow[congs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objgs_ResearchPlanEN.UpdDate = objRow[congs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchPlanEN.Memo = objRow[congs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[congs_ResearchPlan.Memo].ToString().Trim(); //备注
objgs_ResearchPlanEN.PlanTypeId = objRow[congs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objgs_ResearchPlanEN.IdCurrEduCls = objRow[congs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsgs_ResearchPlanDA: GetObjByDataRow)", objException.Message));
}
objgs_ResearchPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objgs_ResearchPlanEN;
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
objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_ResearchPlanEN._CurrTabName, congs_ResearchPlan.PlanId, 8, "");
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
objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsgs_ResearchPlanEN._CurrTabName, congs_ResearchPlan.PlanId, 8, strPrefix);
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
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PlanId from gs_ResearchPlan where " + strCondition;
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
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PlanId from gs_ResearchPlan where " + strCondition;
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
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_ResearchPlan", "PlanId = " + "'"+ strPlanId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsgs_ResearchPlanDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("gs_ResearchPlan", strCondition))
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
objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("gs_ResearchPlan");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsgs_ResearchPlanEN objgs_ResearchPlanEN)
 {
 objgs_ResearchPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_ResearchPlanEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchPlan where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_ResearchPlan");
objRow = objDS.Tables["gs_ResearchPlan"].NewRow();
objRow[congs_ResearchPlan.PlanId] = objgs_ResearchPlanEN.PlanId; //计划Id
objRow[congs_ResearchPlan.TopicId] = objgs_ResearchPlanEN.TopicId; //主题Id
objRow[congs_ResearchPlan.StatusId] = objgs_ResearchPlanEN.StatusId; //状态Id
 if (objgs_ResearchPlanEN.PlanContent !=  "")
 {
objRow[congs_ResearchPlan.PlanContent] = objgs_ResearchPlanEN.PlanContent; //计划内容
 }
 if (objgs_ResearchPlanEN.ResponsibleUser !=  "")
 {
objRow[congs_ResearchPlan.ResponsibleUser] = objgs_ResearchPlanEN.ResponsibleUser; //负责人/小组
 }
 if (objgs_ResearchPlanEN.StartDate !=  "")
 {
objRow[congs_ResearchPlan.StartDate] = objgs_ResearchPlanEN.StartDate; //开始日期
 }
 if (objgs_ResearchPlanEN.EndDate !=  "")
 {
objRow[congs_ResearchPlan.EndDate] = objgs_ResearchPlanEN.EndDate; //截止日期
 }
 if (objgs_ResearchPlanEN.ActualFinishingDate !=  "")
 {
objRow[congs_ResearchPlan.ActualFinishingDate] = objgs_ResearchPlanEN.ActualFinishingDate; //实际完成日期
 }
 if (objgs_ResearchPlanEN.AcceptanceUser !=  "")
 {
objRow[congs_ResearchPlan.AcceptanceUser] = objgs_ResearchPlanEN.AcceptanceUser; //验收用户
 }
objRow[congs_ResearchPlan.IsSubmit] = objgs_ResearchPlanEN.IsSubmit; //是否提交
 if (objgs_ResearchPlanEN.UpdUser !=  "")
 {
objRow[congs_ResearchPlan.UpdUser] = objgs_ResearchPlanEN.UpdUser; //修改人
 }
 if (objgs_ResearchPlanEN.UpdDate !=  "")
 {
objRow[congs_ResearchPlan.UpdDate] = objgs_ResearchPlanEN.UpdDate; //修改日期
 }
 if (objgs_ResearchPlanEN.Memo !=  "")
 {
objRow[congs_ResearchPlan.Memo] = objgs_ResearchPlanEN.Memo; //备注
 }
 if (objgs_ResearchPlanEN.PlanTypeId !=  "")
 {
objRow[congs_ResearchPlan.PlanTypeId] = objgs_ResearchPlanEN.PlanTypeId; //计划类型
 }
 if (objgs_ResearchPlanEN.IdCurrEduCls !=  "")
 {
objRow[congs_ResearchPlan.IdCurrEduCls] = objgs_ResearchPlanEN.IdCurrEduCls; //教学班流水号
 }
objDS.Tables[clsgs_ResearchPlanEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsgs_ResearchPlanEN._CurrTabName);
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
 /// <param name = "objgs_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
 objgs_ResearchPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_ResearchPlanEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_ResearchPlanEN.PlanId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.PlanId);
 var strPlanId = objgs_ResearchPlanEN.PlanId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanId + "'");
 }
 
 if (objgs_ResearchPlanEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.TopicId);
 var strTopicId = objgs_ResearchPlanEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objgs_ResearchPlanEN.StatusId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.StatusId);
 var strStatusId = objgs_ResearchPlanEN.StatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatusId + "'");
 }
 
 if (objgs_ResearchPlanEN.PlanContent !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.PlanContent);
 var strPlanContent = objgs_ResearchPlanEN.PlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanContent + "'");
 }
 
 if (objgs_ResearchPlanEN.ResponsibleUser !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.ResponsibleUser);
 var strResponsibleUser = objgs_ResearchPlanEN.ResponsibleUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResponsibleUser + "'");
 }
 
 if (objgs_ResearchPlanEN.StartDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.StartDate);
 var strStartDate = objgs_ResearchPlanEN.StartDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartDate + "'");
 }
 
 if (objgs_ResearchPlanEN.EndDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.EndDate);
 var strEndDate = objgs_ResearchPlanEN.EndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEndDate + "'");
 }
 
 if (objgs_ResearchPlanEN.ActualFinishingDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.ActualFinishingDate);
 var strActualFinishingDate = objgs_ResearchPlanEN.ActualFinishingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strActualFinishingDate + "'");
 }
 
 if (objgs_ResearchPlanEN.AcceptanceUser !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.AcceptanceUser);
 var strAcceptanceUser = objgs_ResearchPlanEN.AcceptanceUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAcceptanceUser + "'");
 }
 
 arrFieldListForInsert.Add(congs_ResearchPlan.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_ResearchPlanEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_ResearchPlanEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.UpdUser);
 var strUpdUser = objgs_ResearchPlanEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_ResearchPlanEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.UpdDate);
 var strUpdDate = objgs_ResearchPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_ResearchPlanEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.Memo);
 var strMemo = objgs_ResearchPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_ResearchPlanEN.PlanTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.PlanTypeId);
 var strPlanTypeId = objgs_ResearchPlanEN.PlanTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanTypeId + "'");
 }
 
 if (objgs_ResearchPlanEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.IdCurrEduCls);
 var strIdCurrEduCls = objgs_ResearchPlanEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_ResearchPlan");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
 objgs_ResearchPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_ResearchPlanEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_ResearchPlanEN.PlanId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.PlanId);
 var strPlanId = objgs_ResearchPlanEN.PlanId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanId + "'");
 }
 
 if (objgs_ResearchPlanEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.TopicId);
 var strTopicId = objgs_ResearchPlanEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objgs_ResearchPlanEN.StatusId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.StatusId);
 var strStatusId = objgs_ResearchPlanEN.StatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatusId + "'");
 }
 
 if (objgs_ResearchPlanEN.PlanContent !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.PlanContent);
 var strPlanContent = objgs_ResearchPlanEN.PlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanContent + "'");
 }
 
 if (objgs_ResearchPlanEN.ResponsibleUser !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.ResponsibleUser);
 var strResponsibleUser = objgs_ResearchPlanEN.ResponsibleUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResponsibleUser + "'");
 }
 
 if (objgs_ResearchPlanEN.StartDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.StartDate);
 var strStartDate = objgs_ResearchPlanEN.StartDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartDate + "'");
 }
 
 if (objgs_ResearchPlanEN.EndDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.EndDate);
 var strEndDate = objgs_ResearchPlanEN.EndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEndDate + "'");
 }
 
 if (objgs_ResearchPlanEN.ActualFinishingDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.ActualFinishingDate);
 var strActualFinishingDate = objgs_ResearchPlanEN.ActualFinishingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strActualFinishingDate + "'");
 }
 
 if (objgs_ResearchPlanEN.AcceptanceUser !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.AcceptanceUser);
 var strAcceptanceUser = objgs_ResearchPlanEN.AcceptanceUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAcceptanceUser + "'");
 }
 
 arrFieldListForInsert.Add(congs_ResearchPlan.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_ResearchPlanEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_ResearchPlanEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.UpdUser);
 var strUpdUser = objgs_ResearchPlanEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_ResearchPlanEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.UpdDate);
 var strUpdDate = objgs_ResearchPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_ResearchPlanEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.Memo);
 var strMemo = objgs_ResearchPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_ResearchPlanEN.PlanTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.PlanTypeId);
 var strPlanTypeId = objgs_ResearchPlanEN.PlanTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanTypeId + "'");
 }
 
 if (objgs_ResearchPlanEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.IdCurrEduCls);
 var strIdCurrEduCls = objgs_ResearchPlanEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_ResearchPlan");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objgs_ResearchPlanEN.PlanId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsgs_ResearchPlanEN objgs_ResearchPlanEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objgs_ResearchPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_ResearchPlanEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_ResearchPlanEN.PlanId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.PlanId);
 var strPlanId = objgs_ResearchPlanEN.PlanId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanId + "'");
 }
 
 if (objgs_ResearchPlanEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.TopicId);
 var strTopicId = objgs_ResearchPlanEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objgs_ResearchPlanEN.StatusId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.StatusId);
 var strStatusId = objgs_ResearchPlanEN.StatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatusId + "'");
 }
 
 if (objgs_ResearchPlanEN.PlanContent !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.PlanContent);
 var strPlanContent = objgs_ResearchPlanEN.PlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanContent + "'");
 }
 
 if (objgs_ResearchPlanEN.ResponsibleUser !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.ResponsibleUser);
 var strResponsibleUser = objgs_ResearchPlanEN.ResponsibleUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResponsibleUser + "'");
 }
 
 if (objgs_ResearchPlanEN.StartDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.StartDate);
 var strStartDate = objgs_ResearchPlanEN.StartDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartDate + "'");
 }
 
 if (objgs_ResearchPlanEN.EndDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.EndDate);
 var strEndDate = objgs_ResearchPlanEN.EndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEndDate + "'");
 }
 
 if (objgs_ResearchPlanEN.ActualFinishingDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.ActualFinishingDate);
 var strActualFinishingDate = objgs_ResearchPlanEN.ActualFinishingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strActualFinishingDate + "'");
 }
 
 if (objgs_ResearchPlanEN.AcceptanceUser !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.AcceptanceUser);
 var strAcceptanceUser = objgs_ResearchPlanEN.AcceptanceUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAcceptanceUser + "'");
 }
 
 arrFieldListForInsert.Add(congs_ResearchPlan.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_ResearchPlanEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_ResearchPlanEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.UpdUser);
 var strUpdUser = objgs_ResearchPlanEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_ResearchPlanEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.UpdDate);
 var strUpdDate = objgs_ResearchPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_ResearchPlanEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.Memo);
 var strMemo = objgs_ResearchPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_ResearchPlanEN.PlanTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.PlanTypeId);
 var strPlanTypeId = objgs_ResearchPlanEN.PlanTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanTypeId + "'");
 }
 
 if (objgs_ResearchPlanEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.IdCurrEduCls);
 var strIdCurrEduCls = objgs_ResearchPlanEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_ResearchPlan");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objgs_ResearchPlanEN.PlanId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsgs_ResearchPlanEN objgs_ResearchPlanEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objgs_ResearchPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objgs_ResearchPlanEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objgs_ResearchPlanEN.PlanId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.PlanId);
 var strPlanId = objgs_ResearchPlanEN.PlanId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanId + "'");
 }
 
 if (objgs_ResearchPlanEN.TopicId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.TopicId);
 var strTopicId = objgs_ResearchPlanEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicId + "'");
 }
 
 if (objgs_ResearchPlanEN.StatusId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.StatusId);
 var strStatusId = objgs_ResearchPlanEN.StatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatusId + "'");
 }
 
 if (objgs_ResearchPlanEN.PlanContent !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.PlanContent);
 var strPlanContent = objgs_ResearchPlanEN.PlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanContent + "'");
 }
 
 if (objgs_ResearchPlanEN.ResponsibleUser !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.ResponsibleUser);
 var strResponsibleUser = objgs_ResearchPlanEN.ResponsibleUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResponsibleUser + "'");
 }
 
 if (objgs_ResearchPlanEN.StartDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.StartDate);
 var strStartDate = objgs_ResearchPlanEN.StartDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartDate + "'");
 }
 
 if (objgs_ResearchPlanEN.EndDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.EndDate);
 var strEndDate = objgs_ResearchPlanEN.EndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEndDate + "'");
 }
 
 if (objgs_ResearchPlanEN.ActualFinishingDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.ActualFinishingDate);
 var strActualFinishingDate = objgs_ResearchPlanEN.ActualFinishingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strActualFinishingDate + "'");
 }
 
 if (objgs_ResearchPlanEN.AcceptanceUser !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.AcceptanceUser);
 var strAcceptanceUser = objgs_ResearchPlanEN.AcceptanceUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAcceptanceUser + "'");
 }
 
 arrFieldListForInsert.Add(congs_ResearchPlan.IsSubmit);
 arrValueListForInsert.Add("'" + (objgs_ResearchPlanEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objgs_ResearchPlanEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.UpdUser);
 var strUpdUser = objgs_ResearchPlanEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objgs_ResearchPlanEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.UpdDate);
 var strUpdDate = objgs_ResearchPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objgs_ResearchPlanEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.Memo);
 var strMemo = objgs_ResearchPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objgs_ResearchPlanEN.PlanTypeId !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.PlanTypeId);
 var strPlanTypeId = objgs_ResearchPlanEN.PlanTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanTypeId + "'");
 }
 
 if (objgs_ResearchPlanEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(congs_ResearchPlan.IdCurrEduCls);
 var strIdCurrEduCls = objgs_ResearchPlanEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into gs_ResearchPlan");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewgs_ResearchPlans(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchPlan where PlanId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "gs_ResearchPlan");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strPlanId = oRow[congs_ResearchPlan.PlanId].ToString().Trim();
if (IsExist(strPlanId))
{
 string strResult = "关键字变量值为:" + string.Format("PlanId = {0}", strPlanId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsgs_ResearchPlanEN._CurrTabName ].NewRow();
objRow[congs_ResearchPlan.PlanId] = oRow[congs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objRow[congs_ResearchPlan.TopicId] = oRow[congs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objRow[congs_ResearchPlan.StatusId] = oRow[congs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objRow[congs_ResearchPlan.PlanContent] = oRow[congs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objRow[congs_ResearchPlan.ResponsibleUser] = oRow[congs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objRow[congs_ResearchPlan.StartDate] = oRow[congs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objRow[congs_ResearchPlan.EndDate] = oRow[congs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objRow[congs_ResearchPlan.ActualFinishingDate] = oRow[congs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objRow[congs_ResearchPlan.AcceptanceUser] = oRow[congs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objRow[congs_ResearchPlan.IsSubmit] = oRow[congs_ResearchPlan.IsSubmit].ToString().Trim(); //是否提交
objRow[congs_ResearchPlan.UpdUser] = oRow[congs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objRow[congs_ResearchPlan.UpdDate] = oRow[congs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objRow[congs_ResearchPlan.Memo] = oRow[congs_ResearchPlan.Memo].ToString().Trim(); //备注
objRow[congs_ResearchPlan.PlanTypeId] = oRow[congs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objRow[congs_ResearchPlan.IdCurrEduCls] = oRow[congs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
 objDS.Tables[clsgs_ResearchPlanEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsgs_ResearchPlanEN._CurrTabName);
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
 /// <param name = "objgs_ResearchPlanEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
 objgs_ResearchPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_ResearchPlanEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from gs_ResearchPlan where PlanId = " + "'"+ objgs_ResearchPlanEN.PlanId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsgs_ResearchPlanEN._CurrTabName);
if (objDS.Tables[clsgs_ResearchPlanEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PlanId = " + "'"+ objgs_ResearchPlanEN.PlanId+"'");
return false;
}
objRow = objDS.Tables[clsgs_ResearchPlanEN._CurrTabName].Rows[0];
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.PlanId))
 {
objRow[congs_ResearchPlan.PlanId] = objgs_ResearchPlanEN.PlanId; //计划Id
 }
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.TopicId))
 {
objRow[congs_ResearchPlan.TopicId] = objgs_ResearchPlanEN.TopicId; //主题Id
 }
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.StatusId))
 {
objRow[congs_ResearchPlan.StatusId] = objgs_ResearchPlanEN.StatusId; //状态Id
 }
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.PlanContent))
 {
objRow[congs_ResearchPlan.PlanContent] = objgs_ResearchPlanEN.PlanContent; //计划内容
 }
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.ResponsibleUser))
 {
objRow[congs_ResearchPlan.ResponsibleUser] = objgs_ResearchPlanEN.ResponsibleUser; //负责人/小组
 }
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.StartDate))
 {
objRow[congs_ResearchPlan.StartDate] = objgs_ResearchPlanEN.StartDate; //开始日期
 }
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.EndDate))
 {
objRow[congs_ResearchPlan.EndDate] = objgs_ResearchPlanEN.EndDate; //截止日期
 }
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.ActualFinishingDate))
 {
objRow[congs_ResearchPlan.ActualFinishingDate] = objgs_ResearchPlanEN.ActualFinishingDate; //实际完成日期
 }
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.AcceptanceUser))
 {
objRow[congs_ResearchPlan.AcceptanceUser] = objgs_ResearchPlanEN.AcceptanceUser; //验收用户
 }
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.IsSubmit))
 {
objRow[congs_ResearchPlan.IsSubmit] = objgs_ResearchPlanEN.IsSubmit; //是否提交
 }
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.UpdUser))
 {
objRow[congs_ResearchPlan.UpdUser] = objgs_ResearchPlanEN.UpdUser; //修改人
 }
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.UpdDate))
 {
objRow[congs_ResearchPlan.UpdDate] = objgs_ResearchPlanEN.UpdDate; //修改日期
 }
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.Memo))
 {
objRow[congs_ResearchPlan.Memo] = objgs_ResearchPlanEN.Memo; //备注
 }
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.PlanTypeId))
 {
objRow[congs_ResearchPlan.PlanTypeId] = objgs_ResearchPlanEN.PlanTypeId; //计划类型
 }
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.IdCurrEduCls))
 {
objRow[congs_ResearchPlan.IdCurrEduCls] = objgs_ResearchPlanEN.IdCurrEduCls; //教学班流水号
 }
try
{
objDA.Update(objDS, clsgs_ResearchPlanEN._CurrTabName);
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
 /// <param name = "objgs_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
 objgs_ResearchPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_ResearchPlanEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update gs_ResearchPlan Set ");
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.TopicId))
 {
 if (objgs_ResearchPlanEN.TopicId !=  null)
 {
 var strTopicId = objgs_ResearchPlanEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, congs_ResearchPlan.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.TopicId); //主题Id
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.StatusId))
 {
 if (objgs_ResearchPlanEN.StatusId !=  null)
 {
 var strStatusId = objgs_ResearchPlanEN.StatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStatusId, congs_ResearchPlan.StatusId); //状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.StatusId); //状态Id
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.PlanContent))
 {
 if (objgs_ResearchPlanEN.PlanContent !=  null)
 {
 var strPlanContent = objgs_ResearchPlanEN.PlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPlanContent, congs_ResearchPlan.PlanContent); //计划内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.PlanContent); //计划内容
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.ResponsibleUser))
 {
 if (objgs_ResearchPlanEN.ResponsibleUser !=  null)
 {
 var strResponsibleUser = objgs_ResearchPlanEN.ResponsibleUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResponsibleUser, congs_ResearchPlan.ResponsibleUser); //负责人/小组
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.ResponsibleUser); //负责人/小组
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.StartDate))
 {
 if (objgs_ResearchPlanEN.StartDate !=  null)
 {
 var strStartDate = objgs_ResearchPlanEN.StartDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStartDate, congs_ResearchPlan.StartDate); //开始日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.StartDate); //开始日期
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.EndDate))
 {
 if (objgs_ResearchPlanEN.EndDate !=  null)
 {
 var strEndDate = objgs_ResearchPlanEN.EndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEndDate, congs_ResearchPlan.EndDate); //截止日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.EndDate); //截止日期
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.ActualFinishingDate))
 {
 if (objgs_ResearchPlanEN.ActualFinishingDate !=  null)
 {
 var strActualFinishingDate = objgs_ResearchPlanEN.ActualFinishingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strActualFinishingDate, congs_ResearchPlan.ActualFinishingDate); //实际完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.ActualFinishingDate); //实际完成日期
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.AcceptanceUser))
 {
 if (objgs_ResearchPlanEN.AcceptanceUser !=  null)
 {
 var strAcceptanceUser = objgs_ResearchPlanEN.AcceptanceUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAcceptanceUser, congs_ResearchPlan.AcceptanceUser); //验收用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.AcceptanceUser); //验收用户
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_ResearchPlanEN.IsSubmit == true?"1":"0", congs_ResearchPlan.IsSubmit); //是否提交
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.UpdUser))
 {
 if (objgs_ResearchPlanEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_ResearchPlanEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_ResearchPlan.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.UpdUser); //修改人
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.UpdDate))
 {
 if (objgs_ResearchPlanEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_ResearchPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_ResearchPlan.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.UpdDate); //修改日期
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.Memo))
 {
 if (objgs_ResearchPlanEN.Memo !=  null)
 {
 var strMemo = objgs_ResearchPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_ResearchPlan.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.Memo); //备注
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.PlanTypeId))
 {
 if (objgs_ResearchPlanEN.PlanTypeId !=  null)
 {
 var strPlanTypeId = objgs_ResearchPlanEN.PlanTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPlanTypeId, congs_ResearchPlan.PlanTypeId); //计划类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.PlanTypeId); //计划类型
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.IdCurrEduCls))
 {
 if (objgs_ResearchPlanEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_ResearchPlanEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_ResearchPlan.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.IdCurrEduCls); //教学班流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PlanId = '{0}'", objgs_ResearchPlanEN.PlanId); 
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
 /// <param name = "objgs_ResearchPlanEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strCondition)
{
 objgs_ResearchPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_ResearchPlanEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_ResearchPlan Set ");
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.TopicId))
 {
 if (objgs_ResearchPlanEN.TopicId !=  null)
 {
 var strTopicId = objgs_ResearchPlanEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.StatusId))
 {
 if (objgs_ResearchPlanEN.StatusId !=  null)
 {
 var strStatusId = objgs_ResearchPlanEN.StatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StatusId = '{0}',", strStatusId); //状态Id
 }
 else
 {
 sbSQL.Append(" StatusId = null,"); //状态Id
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.PlanContent))
 {
 if (objgs_ResearchPlanEN.PlanContent !=  null)
 {
 var strPlanContent = objgs_ResearchPlanEN.PlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PlanContent = '{0}',", strPlanContent); //计划内容
 }
 else
 {
 sbSQL.Append(" PlanContent = null,"); //计划内容
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.ResponsibleUser))
 {
 if (objgs_ResearchPlanEN.ResponsibleUser !=  null)
 {
 var strResponsibleUser = objgs_ResearchPlanEN.ResponsibleUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResponsibleUser = '{0}',", strResponsibleUser); //负责人/小组
 }
 else
 {
 sbSQL.Append(" ResponsibleUser = null,"); //负责人/小组
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.StartDate))
 {
 if (objgs_ResearchPlanEN.StartDate !=  null)
 {
 var strStartDate = objgs_ResearchPlanEN.StartDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StartDate = '{0}',", strStartDate); //开始日期
 }
 else
 {
 sbSQL.Append(" StartDate = null,"); //开始日期
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.EndDate))
 {
 if (objgs_ResearchPlanEN.EndDate !=  null)
 {
 var strEndDate = objgs_ResearchPlanEN.EndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EndDate = '{0}',", strEndDate); //截止日期
 }
 else
 {
 sbSQL.Append(" EndDate = null,"); //截止日期
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.ActualFinishingDate))
 {
 if (objgs_ResearchPlanEN.ActualFinishingDate !=  null)
 {
 var strActualFinishingDate = objgs_ResearchPlanEN.ActualFinishingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ActualFinishingDate = '{0}',", strActualFinishingDate); //实际完成日期
 }
 else
 {
 sbSQL.Append(" ActualFinishingDate = null,"); //实际完成日期
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.AcceptanceUser))
 {
 if (objgs_ResearchPlanEN.AcceptanceUser !=  null)
 {
 var strAcceptanceUser = objgs_ResearchPlanEN.AcceptanceUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AcceptanceUser = '{0}',", strAcceptanceUser); //验收用户
 }
 else
 {
 sbSQL.Append(" AcceptanceUser = null,"); //验收用户
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objgs_ResearchPlanEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.UpdUser))
 {
 if (objgs_ResearchPlanEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_ResearchPlanEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.UpdDate))
 {
 if (objgs_ResearchPlanEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_ResearchPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.Memo))
 {
 if (objgs_ResearchPlanEN.Memo !=  null)
 {
 var strMemo = objgs_ResearchPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.PlanTypeId))
 {
 if (objgs_ResearchPlanEN.PlanTypeId !=  null)
 {
 var strPlanTypeId = objgs_ResearchPlanEN.PlanTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PlanTypeId = '{0}',", strPlanTypeId); //计划类型
 }
 else
 {
 sbSQL.Append(" PlanTypeId = null,"); //计划类型
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.IdCurrEduCls))
 {
 if (objgs_ResearchPlanEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_ResearchPlanEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
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
 /// <param name = "objgs_ResearchPlanEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objgs_ResearchPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_ResearchPlanEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_ResearchPlan Set ");
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.TopicId))
 {
 if (objgs_ResearchPlanEN.TopicId !=  null)
 {
 var strTopicId = objgs_ResearchPlanEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicId = '{0}',", strTopicId); //主题Id
 }
 else
 {
 sbSQL.Append(" TopicId = null,"); //主题Id
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.StatusId))
 {
 if (objgs_ResearchPlanEN.StatusId !=  null)
 {
 var strStatusId = objgs_ResearchPlanEN.StatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StatusId = '{0}',", strStatusId); //状态Id
 }
 else
 {
 sbSQL.Append(" StatusId = null,"); //状态Id
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.PlanContent))
 {
 if (objgs_ResearchPlanEN.PlanContent !=  null)
 {
 var strPlanContent = objgs_ResearchPlanEN.PlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PlanContent = '{0}',", strPlanContent); //计划内容
 }
 else
 {
 sbSQL.Append(" PlanContent = null,"); //计划内容
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.ResponsibleUser))
 {
 if (objgs_ResearchPlanEN.ResponsibleUser !=  null)
 {
 var strResponsibleUser = objgs_ResearchPlanEN.ResponsibleUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResponsibleUser = '{0}',", strResponsibleUser); //负责人/小组
 }
 else
 {
 sbSQL.Append(" ResponsibleUser = null,"); //负责人/小组
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.StartDate))
 {
 if (objgs_ResearchPlanEN.StartDate !=  null)
 {
 var strStartDate = objgs_ResearchPlanEN.StartDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StartDate = '{0}',", strStartDate); //开始日期
 }
 else
 {
 sbSQL.Append(" StartDate = null,"); //开始日期
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.EndDate))
 {
 if (objgs_ResearchPlanEN.EndDate !=  null)
 {
 var strEndDate = objgs_ResearchPlanEN.EndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EndDate = '{0}',", strEndDate); //截止日期
 }
 else
 {
 sbSQL.Append(" EndDate = null,"); //截止日期
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.ActualFinishingDate))
 {
 if (objgs_ResearchPlanEN.ActualFinishingDate !=  null)
 {
 var strActualFinishingDate = objgs_ResearchPlanEN.ActualFinishingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ActualFinishingDate = '{0}',", strActualFinishingDate); //实际完成日期
 }
 else
 {
 sbSQL.Append(" ActualFinishingDate = null,"); //实际完成日期
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.AcceptanceUser))
 {
 if (objgs_ResearchPlanEN.AcceptanceUser !=  null)
 {
 var strAcceptanceUser = objgs_ResearchPlanEN.AcceptanceUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AcceptanceUser = '{0}',", strAcceptanceUser); //验收用户
 }
 else
 {
 sbSQL.Append(" AcceptanceUser = null,"); //验收用户
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objgs_ResearchPlanEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.UpdUser))
 {
 if (objgs_ResearchPlanEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_ResearchPlanEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.UpdDate))
 {
 if (objgs_ResearchPlanEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_ResearchPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.Memo))
 {
 if (objgs_ResearchPlanEN.Memo !=  null)
 {
 var strMemo = objgs_ResearchPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.PlanTypeId))
 {
 if (objgs_ResearchPlanEN.PlanTypeId !=  null)
 {
 var strPlanTypeId = objgs_ResearchPlanEN.PlanTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PlanTypeId = '{0}',", strPlanTypeId); //计划类型
 }
 else
 {
 sbSQL.Append(" PlanTypeId = null,"); //计划类型
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.IdCurrEduCls))
 {
 if (objgs_ResearchPlanEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_ResearchPlanEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
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
 /// <param name = "objgs_ResearchPlanEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsgs_ResearchPlanEN objgs_ResearchPlanEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objgs_ResearchPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objgs_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objgs_ResearchPlanEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update gs_ResearchPlan Set ");
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.TopicId))
 {
 if (objgs_ResearchPlanEN.TopicId !=  null)
 {
 var strTopicId = objgs_ResearchPlanEN.TopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicId, congs_ResearchPlan.TopicId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.TopicId); //主题Id
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.StatusId))
 {
 if (objgs_ResearchPlanEN.StatusId !=  null)
 {
 var strStatusId = objgs_ResearchPlanEN.StatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStatusId, congs_ResearchPlan.StatusId); //状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.StatusId); //状态Id
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.PlanContent))
 {
 if (objgs_ResearchPlanEN.PlanContent !=  null)
 {
 var strPlanContent = objgs_ResearchPlanEN.PlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPlanContent, congs_ResearchPlan.PlanContent); //计划内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.PlanContent); //计划内容
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.ResponsibleUser))
 {
 if (objgs_ResearchPlanEN.ResponsibleUser !=  null)
 {
 var strResponsibleUser = objgs_ResearchPlanEN.ResponsibleUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResponsibleUser, congs_ResearchPlan.ResponsibleUser); //负责人/小组
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.ResponsibleUser); //负责人/小组
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.StartDate))
 {
 if (objgs_ResearchPlanEN.StartDate !=  null)
 {
 var strStartDate = objgs_ResearchPlanEN.StartDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStartDate, congs_ResearchPlan.StartDate); //开始日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.StartDate); //开始日期
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.EndDate))
 {
 if (objgs_ResearchPlanEN.EndDate !=  null)
 {
 var strEndDate = objgs_ResearchPlanEN.EndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEndDate, congs_ResearchPlan.EndDate); //截止日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.EndDate); //截止日期
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.ActualFinishingDate))
 {
 if (objgs_ResearchPlanEN.ActualFinishingDate !=  null)
 {
 var strActualFinishingDate = objgs_ResearchPlanEN.ActualFinishingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strActualFinishingDate, congs_ResearchPlan.ActualFinishingDate); //实际完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.ActualFinishingDate); //实际完成日期
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.AcceptanceUser))
 {
 if (objgs_ResearchPlanEN.AcceptanceUser !=  null)
 {
 var strAcceptanceUser = objgs_ResearchPlanEN.AcceptanceUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAcceptanceUser, congs_ResearchPlan.AcceptanceUser); //验收用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.AcceptanceUser); //验收用户
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objgs_ResearchPlanEN.IsSubmit == true?"1":"0", congs_ResearchPlan.IsSubmit); //是否提交
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.UpdUser))
 {
 if (objgs_ResearchPlanEN.UpdUser !=  null)
 {
 var strUpdUser = objgs_ResearchPlanEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, congs_ResearchPlan.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.UpdUser); //修改人
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.UpdDate))
 {
 if (objgs_ResearchPlanEN.UpdDate !=  null)
 {
 var strUpdDate = objgs_ResearchPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, congs_ResearchPlan.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.UpdDate); //修改日期
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.Memo))
 {
 if (objgs_ResearchPlanEN.Memo !=  null)
 {
 var strMemo = objgs_ResearchPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, congs_ResearchPlan.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.Memo); //备注
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.PlanTypeId))
 {
 if (objgs_ResearchPlanEN.PlanTypeId !=  null)
 {
 var strPlanTypeId = objgs_ResearchPlanEN.PlanTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPlanTypeId, congs_ResearchPlan.PlanTypeId); //计划类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.PlanTypeId); //计划类型
 }
 }
 
 if (objgs_ResearchPlanEN.IsUpdated(congs_ResearchPlan.IdCurrEduCls))
 {
 if (objgs_ResearchPlanEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objgs_ResearchPlanEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, congs_ResearchPlan.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",congs_ResearchPlan.IdCurrEduCls); //教学班流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PlanId = '{0}'", objgs_ResearchPlanEN.PlanId); 
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
 /// <param name = "strPlanId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strPlanId) 
{
CheckPrimaryKey(strPlanId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strPlanId,
};
 objSQL.ExecSP("gs_ResearchPlan_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strPlanId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strPlanId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strPlanId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
//删除gs_ResearchPlan本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_ResearchPlan where PlanId = " + "'"+ strPlanId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delgs_ResearchPlan(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
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
//删除gs_ResearchPlan本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_ResearchPlan where PlanId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strPlanId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strPlanId) 
{
CheckPrimaryKey(strPlanId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
//删除gs_ResearchPlan本表中与当前对象有关的记录
strSQL = strSQL + "Delete from gs_ResearchPlan where PlanId = " + "'"+ strPlanId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delgs_ResearchPlan(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsgs_ResearchPlanDA: Delgs_ResearchPlan)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_ResearchPlan where " + strCondition ;
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
public bool Delgs_ResearchPlanWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsgs_ResearchPlanDA: Delgs_ResearchPlanWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from gs_ResearchPlan where " + strCondition ;
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
 /// <param name = "objgs_ResearchPlanENS">源对象</param>
 /// <param name = "objgs_ResearchPlanENT">目标对象</param>
public void CopyTo(clsgs_ResearchPlanEN objgs_ResearchPlanENS, clsgs_ResearchPlanEN objgs_ResearchPlanENT)
{
objgs_ResearchPlanENT.PlanId = objgs_ResearchPlanENS.PlanId; //计划Id
objgs_ResearchPlanENT.TopicId = objgs_ResearchPlanENS.TopicId; //主题Id
objgs_ResearchPlanENT.StatusId = objgs_ResearchPlanENS.StatusId; //状态Id
objgs_ResearchPlanENT.PlanContent = objgs_ResearchPlanENS.PlanContent; //计划内容
objgs_ResearchPlanENT.ResponsibleUser = objgs_ResearchPlanENS.ResponsibleUser; //负责人/小组
objgs_ResearchPlanENT.StartDate = objgs_ResearchPlanENS.StartDate; //开始日期
objgs_ResearchPlanENT.EndDate = objgs_ResearchPlanENS.EndDate; //截止日期
objgs_ResearchPlanENT.ActualFinishingDate = objgs_ResearchPlanENS.ActualFinishingDate; //实际完成日期
objgs_ResearchPlanENT.AcceptanceUser = objgs_ResearchPlanENS.AcceptanceUser; //验收用户
objgs_ResearchPlanENT.IsSubmit = objgs_ResearchPlanENS.IsSubmit; //是否提交
objgs_ResearchPlanENT.UpdUser = objgs_ResearchPlanENS.UpdUser; //修改人
objgs_ResearchPlanENT.UpdDate = objgs_ResearchPlanENS.UpdDate; //修改日期
objgs_ResearchPlanENT.Memo = objgs_ResearchPlanENS.Memo; //备注
objgs_ResearchPlanENT.PlanTypeId = objgs_ResearchPlanENS.PlanTypeId; //计划类型
objgs_ResearchPlanENT.IdCurrEduCls = objgs_ResearchPlanENS.IdCurrEduCls; //教学班流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objgs_ResearchPlanEN.TopicId, congs_ResearchPlan.TopicId);
clsCheckSql.CheckFieldNotNull(objgs_ResearchPlanEN.StatusId, congs_ResearchPlan.StatusId);
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.PlanId, 8, congs_ResearchPlan.PlanId);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.TopicId, 8, congs_ResearchPlan.TopicId);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.StatusId, 2, congs_ResearchPlan.StatusId);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.PlanContent, 1000, congs_ResearchPlan.PlanContent);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.ResponsibleUser, 50, congs_ResearchPlan.ResponsibleUser);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.StartDate, 20, congs_ResearchPlan.StartDate);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.EndDate, 20, congs_ResearchPlan.EndDate);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.ActualFinishingDate, 20, congs_ResearchPlan.ActualFinishingDate);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.AcceptanceUser, 50, congs_ResearchPlan.AcceptanceUser);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.UpdUser, 20, congs_ResearchPlan.UpdUser);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.UpdDate, 20, congs_ResearchPlan.UpdDate);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.Memo, 1000, congs_ResearchPlan.Memo);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.PlanTypeId, 2, congs_ResearchPlan.PlanTypeId);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.IdCurrEduCls, 8, congs_ResearchPlan.IdCurrEduCls);
//检查字段外键固定长度
 objgs_ResearchPlanEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.TopicId, 8, congs_ResearchPlan.TopicId);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.StatusId, 2, congs_ResearchPlan.StatusId);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.PlanContent, 1000, congs_ResearchPlan.PlanContent);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.ResponsibleUser, 50, congs_ResearchPlan.ResponsibleUser);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.StartDate, 20, congs_ResearchPlan.StartDate);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.EndDate, 20, congs_ResearchPlan.EndDate);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.ActualFinishingDate, 20, congs_ResearchPlan.ActualFinishingDate);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.AcceptanceUser, 50, congs_ResearchPlan.AcceptanceUser);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.UpdUser, 20, congs_ResearchPlan.UpdUser);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.UpdDate, 20, congs_ResearchPlan.UpdDate);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.Memo, 1000, congs_ResearchPlan.Memo);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.PlanTypeId, 2, congs_ResearchPlan.PlanTypeId);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.IdCurrEduCls, 8, congs_ResearchPlan.IdCurrEduCls);
//检查外键字段长度
 objgs_ResearchPlanEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.PlanId, 8, congs_ResearchPlan.PlanId);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.TopicId, 8, congs_ResearchPlan.TopicId);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.StatusId, 2, congs_ResearchPlan.StatusId);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.PlanContent, 1000, congs_ResearchPlan.PlanContent);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.ResponsibleUser, 50, congs_ResearchPlan.ResponsibleUser);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.StartDate, 20, congs_ResearchPlan.StartDate);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.EndDate, 20, congs_ResearchPlan.EndDate);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.ActualFinishingDate, 20, congs_ResearchPlan.ActualFinishingDate);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.AcceptanceUser, 50, congs_ResearchPlan.AcceptanceUser);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.UpdUser, 20, congs_ResearchPlan.UpdUser);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.UpdDate, 20, congs_ResearchPlan.UpdDate);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.Memo, 1000, congs_ResearchPlan.Memo);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.PlanTypeId, 2, congs_ResearchPlan.PlanTypeId);
clsCheckSql.CheckFieldLen(objgs_ResearchPlanEN.IdCurrEduCls, 8, congs_ResearchPlan.IdCurrEduCls);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchPlanEN.PlanId, congs_ResearchPlan.PlanId);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchPlanEN.TopicId, congs_ResearchPlan.TopicId);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchPlanEN.StatusId, congs_ResearchPlan.StatusId);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchPlanEN.PlanContent, congs_ResearchPlan.PlanContent);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchPlanEN.ResponsibleUser, congs_ResearchPlan.ResponsibleUser);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchPlanEN.StartDate, congs_ResearchPlan.StartDate);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchPlanEN.EndDate, congs_ResearchPlan.EndDate);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchPlanEN.ActualFinishingDate, congs_ResearchPlan.ActualFinishingDate);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchPlanEN.AcceptanceUser, congs_ResearchPlan.AcceptanceUser);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchPlanEN.UpdUser, congs_ResearchPlan.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchPlanEN.UpdDate, congs_ResearchPlan.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchPlanEN.Memo, congs_ResearchPlan.Memo);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchPlanEN.PlanTypeId, congs_ResearchPlan.PlanTypeId);
clsCheckSql.CheckSqlInjection4Field(objgs_ResearchPlanEN.IdCurrEduCls, congs_ResearchPlan.IdCurrEduCls);
//检查外键字段长度
 objgs_ResearchPlanEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--gs_ResearchPlan(主题研究计划),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PlanId = '{0}'", objgs_ResearchPlanEN.PlanId);
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
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
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
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
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
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_ResearchPlanEN._CurrTabName);
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
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsgs_ResearchPlanEN._CurrTabName, strCondition);
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
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
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
 objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}