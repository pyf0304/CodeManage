
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ResearchPlanDA
 表名:zx_ResearchPlan(01120729)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:59:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
 /// 中学研究计划(zx_ResearchPlan)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_ResearchPlanDA : clsCommBase4DA
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
 return clszx_ResearchPlanEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_ResearchPlanEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ResearchPlanEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_ResearchPlanEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_ResearchPlanEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxPlanId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxPlanId)
{
strzxPlanId = strzxPlanId.Replace("'", "''");
if (strzxPlanId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:zx_ResearchPlan中,检查关键字,长度不正确!(clszx_ResearchPlanDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxPlanId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_ResearchPlan中,关键字不能为空 或 null!(clszx_ResearchPlanDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxPlanId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_ResearchPlanDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_ResearchPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_ResearchPlan(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_ResearchPlanDA: GetDataTable_zx_ResearchPlan)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchPlan where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_ResearchPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_ResearchPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchPlan where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_ResearchPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_ResearchPlanDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ResearchPlan where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ResearchPlan where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_ResearchPlanDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_ResearchPlan where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_ResearchPlanDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_ResearchPlan.* from zx_ResearchPlan Left Join {1} on {2} where {3} and zx_ResearchPlan.zxPlanId not in (Select top {5} zx_ResearchPlan.zxPlanId from zx_ResearchPlan Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ResearchPlan where {1} and zxPlanId not in (Select top {2} zxPlanId from zx_ResearchPlan where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ResearchPlan where {1} and zxPlanId not in (Select top {3} zxPlanId from zx_ResearchPlan where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_ResearchPlanDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_ResearchPlan.* from zx_ResearchPlan Left Join {1} on {2} where {3} and zx_ResearchPlan.zxPlanId not in (Select top {5} zx_ResearchPlan.zxPlanId from zx_ResearchPlan Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_ResearchPlan where {1} and zxPlanId not in (Select top {2} zxPlanId from zx_ResearchPlan where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_ResearchPlan where {1} and zxPlanId not in (Select top {3} zxPlanId from zx_ResearchPlan where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_ResearchPlanEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_ResearchPlanDA:GetObjLst)", objException.Message));
}
List<clszx_ResearchPlanEN> arrObjLst = new List<clszx_ResearchPlanEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchPlanEN objzx_ResearchPlanEN = new clszx_ResearchPlanEN();
try
{
objzx_ResearchPlanEN.zxPlanId = objRow[conzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objzx_ResearchPlanEN.zxStatusId = objRow[conzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objzx_ResearchPlanEN.PlanContent = objRow[conzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objzx_ResearchPlanEN.ResponsibleUser = objRow[conzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objzx_ResearchPlanEN.StartDate = objRow[conzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objzx_ResearchPlanEN.EndDate = objRow[conzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objzx_ResearchPlanEN.ActualFinishingDate = objRow[conzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objzx_ResearchPlanEN.AcceptanceUser = objRow[conzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objzx_ResearchPlanEN.IsSubmit = TransNullToBool(objRow[conzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objzx_ResearchPlanEN.UpdUser = objRow[conzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objzx_ResearchPlanEN.UpdDate = objRow[conzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchPlanEN.Memo = objRow[conzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[conzx_ResearchPlan.Memo].ToString().Trim(); //备注
objzx_ResearchPlanEN.PlanTypeId = objRow[conzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objzx_ResearchPlanEN.GroupTextId = objRow[conzx_ResearchPlan.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_ResearchPlanDA: GetObjLst)", objException.Message));
}
objzx_ResearchPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_ResearchPlanEN);
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
public List<clszx_ResearchPlanEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_ResearchPlanDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_ResearchPlanEN> arrObjLst = new List<clszx_ResearchPlanEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchPlanEN objzx_ResearchPlanEN = new clszx_ResearchPlanEN();
try
{
objzx_ResearchPlanEN.zxPlanId = objRow[conzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objzx_ResearchPlanEN.zxStatusId = objRow[conzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objzx_ResearchPlanEN.PlanContent = objRow[conzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objzx_ResearchPlanEN.ResponsibleUser = objRow[conzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objzx_ResearchPlanEN.StartDate = objRow[conzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objzx_ResearchPlanEN.EndDate = objRow[conzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objzx_ResearchPlanEN.ActualFinishingDate = objRow[conzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objzx_ResearchPlanEN.AcceptanceUser = objRow[conzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objzx_ResearchPlanEN.IsSubmit = TransNullToBool(objRow[conzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objzx_ResearchPlanEN.UpdUser = objRow[conzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objzx_ResearchPlanEN.UpdDate = objRow[conzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchPlanEN.Memo = objRow[conzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[conzx_ResearchPlan.Memo].ToString().Trim(); //备注
objzx_ResearchPlanEN.PlanTypeId = objRow[conzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objzx_ResearchPlanEN.GroupTextId = objRow[conzx_ResearchPlan.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_ResearchPlanDA: GetObjLst)", objException.Message));
}
objzx_ResearchPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_ResearchPlanEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_ResearchPlan(ref clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchPlan where zxPlanId = " + "'"+ objzx_ResearchPlanEN.zxPlanId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_ResearchPlanEN.zxPlanId = objDT.Rows[0][conzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ResearchPlanEN.zxStatusId = objDT.Rows[0][conzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_ResearchPlanEN.PlanContent = objDT.Rows[0][conzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_ResearchPlanEN.ResponsibleUser = objDT.Rows[0][conzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ResearchPlanEN.StartDate = objDT.Rows[0][conzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ResearchPlanEN.EndDate = objDT.Rows[0][conzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ResearchPlanEN.ActualFinishingDate = objDT.Rows[0][conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ResearchPlanEN.AcceptanceUser = objDT.Rows[0][conzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ResearchPlanEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_ResearchPlanEN.UpdUser = objDT.Rows[0][conzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ResearchPlanEN.UpdDate = objDT.Rows[0][conzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ResearchPlanEN.Memo = objDT.Rows[0][conzx_ResearchPlan.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_ResearchPlanEN.PlanTypeId = objDT.Rows[0][conzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型(字段类型:char,字段长度:2,是否可空:False)
 objzx_ResearchPlanEN.GroupTextId = objDT.Rows[0][conzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_ResearchPlanDA: Getzx_ResearchPlan)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxPlanId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_ResearchPlanEN GetObjByzxPlanId(string strzxPlanId)
{
CheckPrimaryKey(strzxPlanId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchPlan where zxPlanId = " + "'"+ strzxPlanId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_ResearchPlanEN objzx_ResearchPlanEN = new clszx_ResearchPlanEN();
try
{
 objzx_ResearchPlanEN.zxPlanId = objRow[conzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ResearchPlanEN.zxStatusId = objRow[conzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_ResearchPlanEN.PlanContent = objRow[conzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_ResearchPlanEN.ResponsibleUser = objRow[conzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ResearchPlanEN.StartDate = objRow[conzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ResearchPlanEN.EndDate = objRow[conzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ResearchPlanEN.ActualFinishingDate = objRow[conzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ResearchPlanEN.AcceptanceUser = objRow[conzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_ResearchPlanEN.UpdUser = objRow[conzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ResearchPlanEN.UpdDate = objRow[conzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ResearchPlanEN.Memo = objRow[conzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[conzx_ResearchPlan.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_ResearchPlanEN.PlanTypeId = objRow[conzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型(字段类型:char,字段长度:2,是否可空:False)
 objzx_ResearchPlanEN.GroupTextId = objRow[conzx_ResearchPlan.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_ResearchPlanDA: GetObjByzxPlanId)", objException.Message));
}
return objzx_ResearchPlanEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_ResearchPlanEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_ResearchPlanDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_ResearchPlanEN objzx_ResearchPlanEN = new clszx_ResearchPlanEN()
{
zxPlanId = objRow[conzx_ResearchPlan.zxPlanId].ToString().Trim(), //计划Id
zxStatusId = objRow[conzx_ResearchPlan.zxStatusId].ToString().Trim(), //状态Id
PlanContent = objRow[conzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanContent].ToString().Trim(), //计划内容
ResponsibleUser = objRow[conzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ResponsibleUser].ToString().Trim(), //负责人/小组
StartDate = objRow[conzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.StartDate].ToString().Trim(), //开始日期
EndDate = objRow[conzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.EndDate].ToString().Trim(), //截止日期
ActualFinishingDate = objRow[conzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(), //实际完成日期
AcceptanceUser = objRow[conzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.AcceptanceUser].ToString().Trim(), //验收用户
IsSubmit = TransNullToBool(objRow[conzx_ResearchPlan.IsSubmit].ToString().Trim()), //是否提交
UpdUser = objRow[conzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[conzx_ResearchPlan.Memo].ToString().Trim(), //备注
PlanTypeId = objRow[conzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanTypeId].ToString().Trim(), //计划类型
GroupTextId = objRow[conzx_ResearchPlan.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.GroupTextId].ToString().Trim() //小组Id
};
objzx_ResearchPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ResearchPlanEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_ResearchPlanDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_ResearchPlanEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_ResearchPlanEN objzx_ResearchPlanEN = new clszx_ResearchPlanEN();
try
{
objzx_ResearchPlanEN.zxPlanId = objRow[conzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objzx_ResearchPlanEN.zxStatusId = objRow[conzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objzx_ResearchPlanEN.PlanContent = objRow[conzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objzx_ResearchPlanEN.ResponsibleUser = objRow[conzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objzx_ResearchPlanEN.StartDate = objRow[conzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objzx_ResearchPlanEN.EndDate = objRow[conzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objzx_ResearchPlanEN.ActualFinishingDate = objRow[conzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objzx_ResearchPlanEN.AcceptanceUser = objRow[conzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objzx_ResearchPlanEN.IsSubmit = TransNullToBool(objRow[conzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objzx_ResearchPlanEN.UpdUser = objRow[conzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objzx_ResearchPlanEN.UpdDate = objRow[conzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchPlanEN.Memo = objRow[conzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[conzx_ResearchPlan.Memo].ToString().Trim(); //备注
objzx_ResearchPlanEN.PlanTypeId = objRow[conzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objzx_ResearchPlanEN.GroupTextId = objRow[conzx_ResearchPlan.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_ResearchPlanDA: GetObjByDataRowzx_ResearchPlan)", objException.Message));
}
objzx_ResearchPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ResearchPlanEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_ResearchPlanEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_ResearchPlanEN objzx_ResearchPlanEN = new clszx_ResearchPlanEN();
try
{
objzx_ResearchPlanEN.zxPlanId = objRow[conzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objzx_ResearchPlanEN.zxStatusId = objRow[conzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objzx_ResearchPlanEN.PlanContent = objRow[conzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objzx_ResearchPlanEN.ResponsibleUser = objRow[conzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objzx_ResearchPlanEN.StartDate = objRow[conzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objzx_ResearchPlanEN.EndDate = objRow[conzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objzx_ResearchPlanEN.ActualFinishingDate = objRow[conzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objzx_ResearchPlanEN.AcceptanceUser = objRow[conzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objzx_ResearchPlanEN.IsSubmit = TransNullToBool(objRow[conzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objzx_ResearchPlanEN.UpdUser = objRow[conzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objzx_ResearchPlanEN.UpdDate = objRow[conzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchPlanEN.Memo = objRow[conzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[conzx_ResearchPlan.Memo].ToString().Trim(); //备注
objzx_ResearchPlanEN.PlanTypeId = objRow[conzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objzx_ResearchPlanEN.GroupTextId = objRow[conzx_ResearchPlan.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_ResearchPlanDA: GetObjByDataRow)", objException.Message));
}
objzx_ResearchPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ResearchPlanEN;
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
objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_ResearchPlanEN._CurrTabName, conzx_ResearchPlan.zxPlanId, 8, "");
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
objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_ResearchPlanEN._CurrTabName, conzx_ResearchPlan.zxPlanId, 8, strPrefix);
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
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxPlanId from zx_ResearchPlan where " + strCondition;
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
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxPlanId from zx_ResearchPlan where " + strCondition;
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
 /// <param name = "strzxPlanId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxPlanId)
{
CheckPrimaryKey(strzxPlanId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_ResearchPlan", "zxPlanId = " + "'"+ strzxPlanId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_ResearchPlanDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_ResearchPlan", strCondition))
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
objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_ResearchPlan");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_ResearchPlanEN objzx_ResearchPlanEN)
 {
 if (objzx_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ResearchPlanEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchPlan where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_ResearchPlan");
objRow = objDS.Tables["zx_ResearchPlan"].NewRow();
objRow[conzx_ResearchPlan.zxPlanId] = objzx_ResearchPlanEN.zxPlanId; //计划Id
objRow[conzx_ResearchPlan.zxStatusId] = objzx_ResearchPlanEN.zxStatusId; //状态Id
 if (objzx_ResearchPlanEN.PlanContent !=  "")
 {
objRow[conzx_ResearchPlan.PlanContent] = objzx_ResearchPlanEN.PlanContent; //计划内容
 }
 if (objzx_ResearchPlanEN.ResponsibleUser !=  "")
 {
objRow[conzx_ResearchPlan.ResponsibleUser] = objzx_ResearchPlanEN.ResponsibleUser; //负责人/小组
 }
 if (objzx_ResearchPlanEN.StartDate !=  "")
 {
objRow[conzx_ResearchPlan.StartDate] = objzx_ResearchPlanEN.StartDate; //开始日期
 }
 if (objzx_ResearchPlanEN.EndDate !=  "")
 {
objRow[conzx_ResearchPlan.EndDate] = objzx_ResearchPlanEN.EndDate; //截止日期
 }
 if (objzx_ResearchPlanEN.ActualFinishingDate !=  "")
 {
objRow[conzx_ResearchPlan.ActualFinishingDate] = objzx_ResearchPlanEN.ActualFinishingDate; //实际完成日期
 }
 if (objzx_ResearchPlanEN.AcceptanceUser !=  "")
 {
objRow[conzx_ResearchPlan.AcceptanceUser] = objzx_ResearchPlanEN.AcceptanceUser; //验收用户
 }
objRow[conzx_ResearchPlan.IsSubmit] = objzx_ResearchPlanEN.IsSubmit; //是否提交
 if (objzx_ResearchPlanEN.UpdUser !=  "")
 {
objRow[conzx_ResearchPlan.UpdUser] = objzx_ResearchPlanEN.UpdUser; //修改人
 }
 if (objzx_ResearchPlanEN.UpdDate !=  "")
 {
objRow[conzx_ResearchPlan.UpdDate] = objzx_ResearchPlanEN.UpdDate; //修改日期
 }
 if (objzx_ResearchPlanEN.Memo !=  "")
 {
objRow[conzx_ResearchPlan.Memo] = objzx_ResearchPlanEN.Memo; //备注
 }
 if (objzx_ResearchPlanEN.PlanTypeId !=  "")
 {
objRow[conzx_ResearchPlan.PlanTypeId] = objzx_ResearchPlanEN.PlanTypeId; //计划类型
 }
 if (objzx_ResearchPlanEN.GroupTextId !=  "")
 {
objRow[conzx_ResearchPlan.GroupTextId] = objzx_ResearchPlanEN.GroupTextId; //小组Id
 }
objDS.Tables[clszx_ResearchPlanEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_ResearchPlanEN._CurrTabName);
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
 /// <param name = "objzx_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
 if (objzx_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ResearchPlanEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ResearchPlanEN.zxPlanId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.zxPlanId);
 var strzxPlanId = objzx_ResearchPlanEN.zxPlanId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxPlanId + "'");
 }
 
 if (objzx_ResearchPlanEN.zxStatusId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.zxStatusId);
 var strzxStatusId = objzx_ResearchPlanEN.zxStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxStatusId + "'");
 }
 
 if (objzx_ResearchPlanEN.PlanContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.PlanContent);
 var strPlanContent = objzx_ResearchPlanEN.PlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanContent + "'");
 }
 
 if (objzx_ResearchPlanEN.ResponsibleUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.ResponsibleUser);
 var strResponsibleUser = objzx_ResearchPlanEN.ResponsibleUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResponsibleUser + "'");
 }
 
 if (objzx_ResearchPlanEN.StartDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.StartDate);
 var strStartDate = objzx_ResearchPlanEN.StartDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartDate + "'");
 }
 
 if (objzx_ResearchPlanEN.EndDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.EndDate);
 var strEndDate = objzx_ResearchPlanEN.EndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEndDate + "'");
 }
 
 if (objzx_ResearchPlanEN.ActualFinishingDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.ActualFinishingDate);
 var strActualFinishingDate = objzx_ResearchPlanEN.ActualFinishingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strActualFinishingDate + "'");
 }
 
 if (objzx_ResearchPlanEN.AcceptanceUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.AcceptanceUser);
 var strAcceptanceUser = objzx_ResearchPlanEN.AcceptanceUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAcceptanceUser + "'");
 }
 
 arrFieldListForInsert.Add(conzx_ResearchPlan.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ResearchPlanEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ResearchPlanEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.UpdUser);
 var strUpdUser = objzx_ResearchPlanEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ResearchPlanEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.UpdDate);
 var strUpdDate = objzx_ResearchPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ResearchPlanEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.Memo);
 var strMemo = objzx_ResearchPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ResearchPlanEN.PlanTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.PlanTypeId);
 var strPlanTypeId = objzx_ResearchPlanEN.PlanTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanTypeId + "'");
 }
 
 if (objzx_ResearchPlanEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.GroupTextId);
 var strGroupTextId = objzx_ResearchPlanEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ResearchPlan");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
 if (objzx_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ResearchPlanEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ResearchPlanEN.zxPlanId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.zxPlanId);
 var strzxPlanId = objzx_ResearchPlanEN.zxPlanId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxPlanId + "'");
 }
 
 if (objzx_ResearchPlanEN.zxStatusId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.zxStatusId);
 var strzxStatusId = objzx_ResearchPlanEN.zxStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxStatusId + "'");
 }
 
 if (objzx_ResearchPlanEN.PlanContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.PlanContent);
 var strPlanContent = objzx_ResearchPlanEN.PlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanContent + "'");
 }
 
 if (objzx_ResearchPlanEN.ResponsibleUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.ResponsibleUser);
 var strResponsibleUser = objzx_ResearchPlanEN.ResponsibleUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResponsibleUser + "'");
 }
 
 if (objzx_ResearchPlanEN.StartDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.StartDate);
 var strStartDate = objzx_ResearchPlanEN.StartDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartDate + "'");
 }
 
 if (objzx_ResearchPlanEN.EndDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.EndDate);
 var strEndDate = objzx_ResearchPlanEN.EndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEndDate + "'");
 }
 
 if (objzx_ResearchPlanEN.ActualFinishingDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.ActualFinishingDate);
 var strActualFinishingDate = objzx_ResearchPlanEN.ActualFinishingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strActualFinishingDate + "'");
 }
 
 if (objzx_ResearchPlanEN.AcceptanceUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.AcceptanceUser);
 var strAcceptanceUser = objzx_ResearchPlanEN.AcceptanceUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAcceptanceUser + "'");
 }
 
 arrFieldListForInsert.Add(conzx_ResearchPlan.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ResearchPlanEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ResearchPlanEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.UpdUser);
 var strUpdUser = objzx_ResearchPlanEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ResearchPlanEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.UpdDate);
 var strUpdDate = objzx_ResearchPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ResearchPlanEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.Memo);
 var strMemo = objzx_ResearchPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ResearchPlanEN.PlanTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.PlanTypeId);
 var strPlanTypeId = objzx_ResearchPlanEN.PlanTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanTypeId + "'");
 }
 
 if (objzx_ResearchPlanEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.GroupTextId);
 var strGroupTextId = objzx_ResearchPlanEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ResearchPlan");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_ResearchPlanEN.zxPlanId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_ResearchPlanEN objzx_ResearchPlanEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ResearchPlanEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ResearchPlanEN.zxPlanId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.zxPlanId);
 var strzxPlanId = objzx_ResearchPlanEN.zxPlanId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxPlanId + "'");
 }
 
 if (objzx_ResearchPlanEN.zxStatusId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.zxStatusId);
 var strzxStatusId = objzx_ResearchPlanEN.zxStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxStatusId + "'");
 }
 
 if (objzx_ResearchPlanEN.PlanContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.PlanContent);
 var strPlanContent = objzx_ResearchPlanEN.PlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanContent + "'");
 }
 
 if (objzx_ResearchPlanEN.ResponsibleUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.ResponsibleUser);
 var strResponsibleUser = objzx_ResearchPlanEN.ResponsibleUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResponsibleUser + "'");
 }
 
 if (objzx_ResearchPlanEN.StartDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.StartDate);
 var strStartDate = objzx_ResearchPlanEN.StartDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartDate + "'");
 }
 
 if (objzx_ResearchPlanEN.EndDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.EndDate);
 var strEndDate = objzx_ResearchPlanEN.EndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEndDate + "'");
 }
 
 if (objzx_ResearchPlanEN.ActualFinishingDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.ActualFinishingDate);
 var strActualFinishingDate = objzx_ResearchPlanEN.ActualFinishingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strActualFinishingDate + "'");
 }
 
 if (objzx_ResearchPlanEN.AcceptanceUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.AcceptanceUser);
 var strAcceptanceUser = objzx_ResearchPlanEN.AcceptanceUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAcceptanceUser + "'");
 }
 
 arrFieldListForInsert.Add(conzx_ResearchPlan.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ResearchPlanEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ResearchPlanEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.UpdUser);
 var strUpdUser = objzx_ResearchPlanEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ResearchPlanEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.UpdDate);
 var strUpdDate = objzx_ResearchPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ResearchPlanEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.Memo);
 var strMemo = objzx_ResearchPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ResearchPlanEN.PlanTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.PlanTypeId);
 var strPlanTypeId = objzx_ResearchPlanEN.PlanTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanTypeId + "'");
 }
 
 if (objzx_ResearchPlanEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.GroupTextId);
 var strGroupTextId = objzx_ResearchPlanEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ResearchPlan");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_ResearchPlanEN.zxPlanId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_ResearchPlanEN objzx_ResearchPlanEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ResearchPlanEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ResearchPlanEN.zxPlanId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.zxPlanId);
 var strzxPlanId = objzx_ResearchPlanEN.zxPlanId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxPlanId + "'");
 }
 
 if (objzx_ResearchPlanEN.zxStatusId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.zxStatusId);
 var strzxStatusId = objzx_ResearchPlanEN.zxStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxStatusId + "'");
 }
 
 if (objzx_ResearchPlanEN.PlanContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.PlanContent);
 var strPlanContent = objzx_ResearchPlanEN.PlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanContent + "'");
 }
 
 if (objzx_ResearchPlanEN.ResponsibleUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.ResponsibleUser);
 var strResponsibleUser = objzx_ResearchPlanEN.ResponsibleUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResponsibleUser + "'");
 }
 
 if (objzx_ResearchPlanEN.StartDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.StartDate);
 var strStartDate = objzx_ResearchPlanEN.StartDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartDate + "'");
 }
 
 if (objzx_ResearchPlanEN.EndDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.EndDate);
 var strEndDate = objzx_ResearchPlanEN.EndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEndDate + "'");
 }
 
 if (objzx_ResearchPlanEN.ActualFinishingDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.ActualFinishingDate);
 var strActualFinishingDate = objzx_ResearchPlanEN.ActualFinishingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strActualFinishingDate + "'");
 }
 
 if (objzx_ResearchPlanEN.AcceptanceUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.AcceptanceUser);
 var strAcceptanceUser = objzx_ResearchPlanEN.AcceptanceUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAcceptanceUser + "'");
 }
 
 arrFieldListForInsert.Add(conzx_ResearchPlan.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ResearchPlanEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ResearchPlanEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.UpdUser);
 var strUpdUser = objzx_ResearchPlanEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ResearchPlanEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.UpdDate);
 var strUpdDate = objzx_ResearchPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ResearchPlanEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.Memo);
 var strMemo = objzx_ResearchPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ResearchPlanEN.PlanTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.PlanTypeId);
 var strPlanTypeId = objzx_ResearchPlanEN.PlanTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPlanTypeId + "'");
 }
 
 if (objzx_ResearchPlanEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_ResearchPlan.GroupTextId);
 var strGroupTextId = objzx_ResearchPlanEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_ResearchPlan");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_ResearchPlans(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchPlan where zxPlanId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_ResearchPlan");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strzxPlanId = oRow[conzx_ResearchPlan.zxPlanId].ToString().Trim();
if (IsExist(strzxPlanId))
{
 string strResult = "关键字变量值为:" + string.Format("zxPlanId = {0}", strzxPlanId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_ResearchPlanEN._CurrTabName ].NewRow();
objRow[conzx_ResearchPlan.zxPlanId] = oRow[conzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objRow[conzx_ResearchPlan.zxStatusId] = oRow[conzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objRow[conzx_ResearchPlan.PlanContent] = oRow[conzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objRow[conzx_ResearchPlan.ResponsibleUser] = oRow[conzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objRow[conzx_ResearchPlan.StartDate] = oRow[conzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objRow[conzx_ResearchPlan.EndDate] = oRow[conzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objRow[conzx_ResearchPlan.ActualFinishingDate] = oRow[conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objRow[conzx_ResearchPlan.AcceptanceUser] = oRow[conzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objRow[conzx_ResearchPlan.IsSubmit] = oRow[conzx_ResearchPlan.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_ResearchPlan.UpdUser] = oRow[conzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objRow[conzx_ResearchPlan.UpdDate] = oRow[conzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_ResearchPlan.Memo] = oRow[conzx_ResearchPlan.Memo].ToString().Trim(); //备注
objRow[conzx_ResearchPlan.PlanTypeId] = oRow[conzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objRow[conzx_ResearchPlan.GroupTextId] = oRow[conzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
 objDS.Tables[clszx_ResearchPlanEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_ResearchPlanEN._CurrTabName);
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
 /// <param name = "objzx_ResearchPlanEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
 if (objzx_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ResearchPlanEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
strSQL = "Select * from zx_ResearchPlan where zxPlanId = " + "'"+ objzx_ResearchPlanEN.zxPlanId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_ResearchPlanEN._CurrTabName);
if (objDS.Tables[clszx_ResearchPlanEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:zxPlanId = " + "'"+ objzx_ResearchPlanEN.zxPlanId+"'");
return false;
}
objRow = objDS.Tables[clszx_ResearchPlanEN._CurrTabName].Rows[0];
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.zxPlanId))
 {
objRow[conzx_ResearchPlan.zxPlanId] = objzx_ResearchPlanEN.zxPlanId; //计划Id
 }
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.zxStatusId))
 {
objRow[conzx_ResearchPlan.zxStatusId] = objzx_ResearchPlanEN.zxStatusId; //状态Id
 }
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.PlanContent))
 {
objRow[conzx_ResearchPlan.PlanContent] = objzx_ResearchPlanEN.PlanContent; //计划内容
 }
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.ResponsibleUser))
 {
objRow[conzx_ResearchPlan.ResponsibleUser] = objzx_ResearchPlanEN.ResponsibleUser; //负责人/小组
 }
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.StartDate))
 {
objRow[conzx_ResearchPlan.StartDate] = objzx_ResearchPlanEN.StartDate; //开始日期
 }
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.EndDate))
 {
objRow[conzx_ResearchPlan.EndDate] = objzx_ResearchPlanEN.EndDate; //截止日期
 }
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.ActualFinishingDate))
 {
objRow[conzx_ResearchPlan.ActualFinishingDate] = objzx_ResearchPlanEN.ActualFinishingDate; //实际完成日期
 }
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.AcceptanceUser))
 {
objRow[conzx_ResearchPlan.AcceptanceUser] = objzx_ResearchPlanEN.AcceptanceUser; //验收用户
 }
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.IsSubmit))
 {
objRow[conzx_ResearchPlan.IsSubmit] = objzx_ResearchPlanEN.IsSubmit; //是否提交
 }
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.UpdUser))
 {
objRow[conzx_ResearchPlan.UpdUser] = objzx_ResearchPlanEN.UpdUser; //修改人
 }
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.UpdDate))
 {
objRow[conzx_ResearchPlan.UpdDate] = objzx_ResearchPlanEN.UpdDate; //修改日期
 }
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.Memo))
 {
objRow[conzx_ResearchPlan.Memo] = objzx_ResearchPlanEN.Memo; //备注
 }
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.PlanTypeId))
 {
objRow[conzx_ResearchPlan.PlanTypeId] = objzx_ResearchPlanEN.PlanTypeId; //计划类型
 }
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.GroupTextId))
 {
objRow[conzx_ResearchPlan.GroupTextId] = objzx_ResearchPlanEN.GroupTextId; //小组Id
 }
try
{
objDA.Update(objDS, clszx_ResearchPlanEN._CurrTabName);
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
 /// <param name = "objzx_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
 if (objzx_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ResearchPlanEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_ResearchPlan Set ");
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.zxStatusId))
 {
 if (objzx_ResearchPlanEN.zxStatusId !=  null)
 {
 var strzxStatusId = objzx_ResearchPlanEN.zxStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxStatusId, conzx_ResearchPlan.zxStatusId); //状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.zxStatusId); //状态Id
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.PlanContent))
 {
 if (objzx_ResearchPlanEN.PlanContent !=  null)
 {
 var strPlanContent = objzx_ResearchPlanEN.PlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPlanContent, conzx_ResearchPlan.PlanContent); //计划内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.PlanContent); //计划内容
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.ResponsibleUser))
 {
 if (objzx_ResearchPlanEN.ResponsibleUser !=  null)
 {
 var strResponsibleUser = objzx_ResearchPlanEN.ResponsibleUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResponsibleUser, conzx_ResearchPlan.ResponsibleUser); //负责人/小组
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.ResponsibleUser); //负责人/小组
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.StartDate))
 {
 if (objzx_ResearchPlanEN.StartDate !=  null)
 {
 var strStartDate = objzx_ResearchPlanEN.StartDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStartDate, conzx_ResearchPlan.StartDate); //开始日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.StartDate); //开始日期
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.EndDate))
 {
 if (objzx_ResearchPlanEN.EndDate !=  null)
 {
 var strEndDate = objzx_ResearchPlanEN.EndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEndDate, conzx_ResearchPlan.EndDate); //截止日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.EndDate); //截止日期
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.ActualFinishingDate))
 {
 if (objzx_ResearchPlanEN.ActualFinishingDate !=  null)
 {
 var strActualFinishingDate = objzx_ResearchPlanEN.ActualFinishingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strActualFinishingDate, conzx_ResearchPlan.ActualFinishingDate); //实际完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.ActualFinishingDate); //实际完成日期
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.AcceptanceUser))
 {
 if (objzx_ResearchPlanEN.AcceptanceUser !=  null)
 {
 var strAcceptanceUser = objzx_ResearchPlanEN.AcceptanceUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAcceptanceUser, conzx_ResearchPlan.AcceptanceUser); //验收用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.AcceptanceUser); //验收用户
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_ResearchPlanEN.IsSubmit == true?"1":"0", conzx_ResearchPlan.IsSubmit); //是否提交
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.UpdUser))
 {
 if (objzx_ResearchPlanEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ResearchPlanEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_ResearchPlan.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.UpdUser); //修改人
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.UpdDate))
 {
 if (objzx_ResearchPlanEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ResearchPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_ResearchPlan.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.UpdDate); //修改日期
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.Memo))
 {
 if (objzx_ResearchPlanEN.Memo !=  null)
 {
 var strMemo = objzx_ResearchPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_ResearchPlan.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.Memo); //备注
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.PlanTypeId))
 {
 if (objzx_ResearchPlanEN.PlanTypeId !=  null)
 {
 var strPlanTypeId = objzx_ResearchPlanEN.PlanTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPlanTypeId, conzx_ResearchPlan.PlanTypeId); //计划类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.PlanTypeId); //计划类型
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.GroupTextId))
 {
 if (objzx_ResearchPlanEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ResearchPlanEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_ResearchPlan.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxPlanId = '{0}'", objzx_ResearchPlanEN.zxPlanId); 
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
 /// <param name = "objzx_ResearchPlanEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_ResearchPlanEN objzx_ResearchPlanEN, string strCondition)
{
 if (objzx_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ResearchPlanEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ResearchPlan Set ");
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.zxStatusId))
 {
 if (objzx_ResearchPlanEN.zxStatusId !=  null)
 {
 var strzxStatusId = objzx_ResearchPlanEN.zxStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxStatusId = '{0}',", strzxStatusId); //状态Id
 }
 else
 {
 sbSQL.Append(" zxStatusId = null,"); //状态Id
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.PlanContent))
 {
 if (objzx_ResearchPlanEN.PlanContent !=  null)
 {
 var strPlanContent = objzx_ResearchPlanEN.PlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PlanContent = '{0}',", strPlanContent); //计划内容
 }
 else
 {
 sbSQL.Append(" PlanContent = null,"); //计划内容
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.ResponsibleUser))
 {
 if (objzx_ResearchPlanEN.ResponsibleUser !=  null)
 {
 var strResponsibleUser = objzx_ResearchPlanEN.ResponsibleUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResponsibleUser = '{0}',", strResponsibleUser); //负责人/小组
 }
 else
 {
 sbSQL.Append(" ResponsibleUser = null,"); //负责人/小组
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.StartDate))
 {
 if (objzx_ResearchPlanEN.StartDate !=  null)
 {
 var strStartDate = objzx_ResearchPlanEN.StartDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StartDate = '{0}',", strStartDate); //开始日期
 }
 else
 {
 sbSQL.Append(" StartDate = null,"); //开始日期
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.EndDate))
 {
 if (objzx_ResearchPlanEN.EndDate !=  null)
 {
 var strEndDate = objzx_ResearchPlanEN.EndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EndDate = '{0}',", strEndDate); //截止日期
 }
 else
 {
 sbSQL.Append(" EndDate = null,"); //截止日期
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.ActualFinishingDate))
 {
 if (objzx_ResearchPlanEN.ActualFinishingDate !=  null)
 {
 var strActualFinishingDate = objzx_ResearchPlanEN.ActualFinishingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ActualFinishingDate = '{0}',", strActualFinishingDate); //实际完成日期
 }
 else
 {
 sbSQL.Append(" ActualFinishingDate = null,"); //实际完成日期
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.AcceptanceUser))
 {
 if (objzx_ResearchPlanEN.AcceptanceUser !=  null)
 {
 var strAcceptanceUser = objzx_ResearchPlanEN.AcceptanceUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AcceptanceUser = '{0}',", strAcceptanceUser); //验收用户
 }
 else
 {
 sbSQL.Append(" AcceptanceUser = null,"); //验收用户
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_ResearchPlanEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.UpdUser))
 {
 if (objzx_ResearchPlanEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ResearchPlanEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.UpdDate))
 {
 if (objzx_ResearchPlanEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ResearchPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.Memo))
 {
 if (objzx_ResearchPlanEN.Memo !=  null)
 {
 var strMemo = objzx_ResearchPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.PlanTypeId))
 {
 if (objzx_ResearchPlanEN.PlanTypeId !=  null)
 {
 var strPlanTypeId = objzx_ResearchPlanEN.PlanTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PlanTypeId = '{0}',", strPlanTypeId); //计划类型
 }
 else
 {
 sbSQL.Append(" PlanTypeId = null,"); //计划类型
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.GroupTextId))
 {
 if (objzx_ResearchPlanEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ResearchPlanEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
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
 /// <param name = "objzx_ResearchPlanEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_ResearchPlanEN objzx_ResearchPlanEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ResearchPlanEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ResearchPlan Set ");
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.zxStatusId))
 {
 if (objzx_ResearchPlanEN.zxStatusId !=  null)
 {
 var strzxStatusId = objzx_ResearchPlanEN.zxStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxStatusId = '{0}',", strzxStatusId); //状态Id
 }
 else
 {
 sbSQL.Append(" zxStatusId = null,"); //状态Id
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.PlanContent))
 {
 if (objzx_ResearchPlanEN.PlanContent !=  null)
 {
 var strPlanContent = objzx_ResearchPlanEN.PlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PlanContent = '{0}',", strPlanContent); //计划内容
 }
 else
 {
 sbSQL.Append(" PlanContent = null,"); //计划内容
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.ResponsibleUser))
 {
 if (objzx_ResearchPlanEN.ResponsibleUser !=  null)
 {
 var strResponsibleUser = objzx_ResearchPlanEN.ResponsibleUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResponsibleUser = '{0}',", strResponsibleUser); //负责人/小组
 }
 else
 {
 sbSQL.Append(" ResponsibleUser = null,"); //负责人/小组
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.StartDate))
 {
 if (objzx_ResearchPlanEN.StartDate !=  null)
 {
 var strStartDate = objzx_ResearchPlanEN.StartDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StartDate = '{0}',", strStartDate); //开始日期
 }
 else
 {
 sbSQL.Append(" StartDate = null,"); //开始日期
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.EndDate))
 {
 if (objzx_ResearchPlanEN.EndDate !=  null)
 {
 var strEndDate = objzx_ResearchPlanEN.EndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EndDate = '{0}',", strEndDate); //截止日期
 }
 else
 {
 sbSQL.Append(" EndDate = null,"); //截止日期
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.ActualFinishingDate))
 {
 if (objzx_ResearchPlanEN.ActualFinishingDate !=  null)
 {
 var strActualFinishingDate = objzx_ResearchPlanEN.ActualFinishingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ActualFinishingDate = '{0}',", strActualFinishingDate); //实际完成日期
 }
 else
 {
 sbSQL.Append(" ActualFinishingDate = null,"); //实际完成日期
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.AcceptanceUser))
 {
 if (objzx_ResearchPlanEN.AcceptanceUser !=  null)
 {
 var strAcceptanceUser = objzx_ResearchPlanEN.AcceptanceUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AcceptanceUser = '{0}',", strAcceptanceUser); //验收用户
 }
 else
 {
 sbSQL.Append(" AcceptanceUser = null,"); //验收用户
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_ResearchPlanEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.UpdUser))
 {
 if (objzx_ResearchPlanEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ResearchPlanEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.UpdDate))
 {
 if (objzx_ResearchPlanEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ResearchPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.Memo))
 {
 if (objzx_ResearchPlanEN.Memo !=  null)
 {
 var strMemo = objzx_ResearchPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.PlanTypeId))
 {
 if (objzx_ResearchPlanEN.PlanTypeId !=  null)
 {
 var strPlanTypeId = objzx_ResearchPlanEN.PlanTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PlanTypeId = '{0}',", strPlanTypeId); //计划类型
 }
 else
 {
 sbSQL.Append(" PlanTypeId = null,"); //计划类型
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.GroupTextId))
 {
 if (objzx_ResearchPlanEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ResearchPlanEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
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
 /// <param name = "objzx_ResearchPlanEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_ResearchPlanEN objzx_ResearchPlanEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_ResearchPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ResearchPlanEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_ResearchPlan Set ");
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.zxStatusId))
 {
 if (objzx_ResearchPlanEN.zxStatusId !=  null)
 {
 var strzxStatusId = objzx_ResearchPlanEN.zxStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxStatusId, conzx_ResearchPlan.zxStatusId); //状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.zxStatusId); //状态Id
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.PlanContent))
 {
 if (objzx_ResearchPlanEN.PlanContent !=  null)
 {
 var strPlanContent = objzx_ResearchPlanEN.PlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPlanContent, conzx_ResearchPlan.PlanContent); //计划内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.PlanContent); //计划内容
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.ResponsibleUser))
 {
 if (objzx_ResearchPlanEN.ResponsibleUser !=  null)
 {
 var strResponsibleUser = objzx_ResearchPlanEN.ResponsibleUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResponsibleUser, conzx_ResearchPlan.ResponsibleUser); //负责人/小组
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.ResponsibleUser); //负责人/小组
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.StartDate))
 {
 if (objzx_ResearchPlanEN.StartDate !=  null)
 {
 var strStartDate = objzx_ResearchPlanEN.StartDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStartDate, conzx_ResearchPlan.StartDate); //开始日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.StartDate); //开始日期
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.EndDate))
 {
 if (objzx_ResearchPlanEN.EndDate !=  null)
 {
 var strEndDate = objzx_ResearchPlanEN.EndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEndDate, conzx_ResearchPlan.EndDate); //截止日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.EndDate); //截止日期
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.ActualFinishingDate))
 {
 if (objzx_ResearchPlanEN.ActualFinishingDate !=  null)
 {
 var strActualFinishingDate = objzx_ResearchPlanEN.ActualFinishingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strActualFinishingDate, conzx_ResearchPlan.ActualFinishingDate); //实际完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.ActualFinishingDate); //实际完成日期
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.AcceptanceUser))
 {
 if (objzx_ResearchPlanEN.AcceptanceUser !=  null)
 {
 var strAcceptanceUser = objzx_ResearchPlanEN.AcceptanceUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAcceptanceUser, conzx_ResearchPlan.AcceptanceUser); //验收用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.AcceptanceUser); //验收用户
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_ResearchPlanEN.IsSubmit == true?"1":"0", conzx_ResearchPlan.IsSubmit); //是否提交
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.UpdUser))
 {
 if (objzx_ResearchPlanEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ResearchPlanEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_ResearchPlan.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.UpdUser); //修改人
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.UpdDate))
 {
 if (objzx_ResearchPlanEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ResearchPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_ResearchPlan.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.UpdDate); //修改日期
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.Memo))
 {
 if (objzx_ResearchPlanEN.Memo !=  null)
 {
 var strMemo = objzx_ResearchPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_ResearchPlan.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.Memo); //备注
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.PlanTypeId))
 {
 if (objzx_ResearchPlanEN.PlanTypeId !=  null)
 {
 var strPlanTypeId = objzx_ResearchPlanEN.PlanTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPlanTypeId, conzx_ResearchPlan.PlanTypeId); //计划类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.PlanTypeId); //计划类型
 }
 }
 
 if (objzx_ResearchPlanEN.IsUpdated(conzx_ResearchPlan.GroupTextId))
 {
 if (objzx_ResearchPlanEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ResearchPlanEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_ResearchPlan.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_ResearchPlan.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxPlanId = '{0}'", objzx_ResearchPlanEN.zxPlanId); 
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
 /// <param name = "strzxPlanId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strzxPlanId) 
{
CheckPrimaryKey(strzxPlanId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strzxPlanId,
};
 objSQL.ExecSP("zx_ResearchPlan_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strzxPlanId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strzxPlanId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strzxPlanId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
//删除zx_ResearchPlan本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ResearchPlan where zxPlanId = " + "'"+ strzxPlanId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_ResearchPlan(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
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
//删除zx_ResearchPlan本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ResearchPlan where zxPlanId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strzxPlanId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strzxPlanId) 
{
CheckPrimaryKey(strzxPlanId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
//删除zx_ResearchPlan本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_ResearchPlan where zxPlanId = " + "'"+ strzxPlanId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_ResearchPlan(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_ResearchPlanDA: Delzx_ResearchPlan)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_ResearchPlan where " + strCondition ;
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
public bool Delzx_ResearchPlanWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_ResearchPlanDA: Delzx_ResearchPlanWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_ResearchPlan where " + strCondition ;
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
 /// <param name = "objzx_ResearchPlanENS">源对象</param>
 /// <param name = "objzx_ResearchPlanENT">目标对象</param>
public void CopyTo(clszx_ResearchPlanEN objzx_ResearchPlanENS, clszx_ResearchPlanEN objzx_ResearchPlanENT)
{
objzx_ResearchPlanENT.zxPlanId = objzx_ResearchPlanENS.zxPlanId; //计划Id
objzx_ResearchPlanENT.zxStatusId = objzx_ResearchPlanENS.zxStatusId; //状态Id
objzx_ResearchPlanENT.PlanContent = objzx_ResearchPlanENS.PlanContent; //计划内容
objzx_ResearchPlanENT.ResponsibleUser = objzx_ResearchPlanENS.ResponsibleUser; //负责人/小组
objzx_ResearchPlanENT.StartDate = objzx_ResearchPlanENS.StartDate; //开始日期
objzx_ResearchPlanENT.EndDate = objzx_ResearchPlanENS.EndDate; //截止日期
objzx_ResearchPlanENT.ActualFinishingDate = objzx_ResearchPlanENS.ActualFinishingDate; //实际完成日期
objzx_ResearchPlanENT.AcceptanceUser = objzx_ResearchPlanENS.AcceptanceUser; //验收用户
objzx_ResearchPlanENT.IsSubmit = objzx_ResearchPlanENS.IsSubmit; //是否提交
objzx_ResearchPlanENT.UpdUser = objzx_ResearchPlanENS.UpdUser; //修改人
objzx_ResearchPlanENT.UpdDate = objzx_ResearchPlanENS.UpdDate; //修改日期
objzx_ResearchPlanENT.Memo = objzx_ResearchPlanENS.Memo; //备注
objzx_ResearchPlanENT.PlanTypeId = objzx_ResearchPlanENS.PlanTypeId; //计划类型
objzx_ResearchPlanENT.GroupTextId = objzx_ResearchPlanENS.GroupTextId; //小组Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_ResearchPlanEN.zxStatusId, conzx_ResearchPlan.zxStatusId);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.zxPlanId, 8, conzx_ResearchPlan.zxPlanId);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.zxStatusId, 2, conzx_ResearchPlan.zxStatusId);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.PlanContent, 1000, conzx_ResearchPlan.PlanContent);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.ResponsibleUser, 50, conzx_ResearchPlan.ResponsibleUser);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.StartDate, 20, conzx_ResearchPlan.StartDate);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.EndDate, 20, conzx_ResearchPlan.EndDate);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.ActualFinishingDate, 20, conzx_ResearchPlan.ActualFinishingDate);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.AcceptanceUser, 50, conzx_ResearchPlan.AcceptanceUser);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.UpdUser, 20, conzx_ResearchPlan.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.UpdDate, 20, conzx_ResearchPlan.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.Memo, 1000, conzx_ResearchPlan.Memo);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.PlanTypeId, 2, conzx_ResearchPlan.PlanTypeId);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.GroupTextId, 8, conzx_ResearchPlan.GroupTextId);
//检查字段外键固定长度
 objzx_ResearchPlanEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.zxStatusId, 2, conzx_ResearchPlan.zxStatusId);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.PlanContent, 1000, conzx_ResearchPlan.PlanContent);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.ResponsibleUser, 50, conzx_ResearchPlan.ResponsibleUser);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.StartDate, 20, conzx_ResearchPlan.StartDate);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.EndDate, 20, conzx_ResearchPlan.EndDate);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.ActualFinishingDate, 20, conzx_ResearchPlan.ActualFinishingDate);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.AcceptanceUser, 50, conzx_ResearchPlan.AcceptanceUser);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.UpdUser, 20, conzx_ResearchPlan.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.UpdDate, 20, conzx_ResearchPlan.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.Memo, 1000, conzx_ResearchPlan.Memo);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.PlanTypeId, 2, conzx_ResearchPlan.PlanTypeId);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.GroupTextId, 8, conzx_ResearchPlan.GroupTextId);
//检查外键字段长度
 objzx_ResearchPlanEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.zxPlanId, 8, conzx_ResearchPlan.zxPlanId);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.zxStatusId, 2, conzx_ResearchPlan.zxStatusId);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.PlanContent, 1000, conzx_ResearchPlan.PlanContent);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.ResponsibleUser, 50, conzx_ResearchPlan.ResponsibleUser);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.StartDate, 20, conzx_ResearchPlan.StartDate);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.EndDate, 20, conzx_ResearchPlan.EndDate);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.ActualFinishingDate, 20, conzx_ResearchPlan.ActualFinishingDate);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.AcceptanceUser, 50, conzx_ResearchPlan.AcceptanceUser);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.UpdUser, 20, conzx_ResearchPlan.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.UpdDate, 20, conzx_ResearchPlan.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.Memo, 1000, conzx_ResearchPlan.Memo);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.PlanTypeId, 2, conzx_ResearchPlan.PlanTypeId);
clsCheckSql.CheckFieldLen(objzx_ResearchPlanEN.GroupTextId, 8, conzx_ResearchPlan.GroupTextId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchPlanEN.zxPlanId, conzx_ResearchPlan.zxPlanId);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchPlanEN.zxStatusId, conzx_ResearchPlan.zxStatusId);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchPlanEN.PlanContent, conzx_ResearchPlan.PlanContent);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchPlanEN.ResponsibleUser, conzx_ResearchPlan.ResponsibleUser);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchPlanEN.StartDate, conzx_ResearchPlan.StartDate);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchPlanEN.EndDate, conzx_ResearchPlan.EndDate);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchPlanEN.ActualFinishingDate, conzx_ResearchPlan.ActualFinishingDate);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchPlanEN.AcceptanceUser, conzx_ResearchPlan.AcceptanceUser);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchPlanEN.UpdUser, conzx_ResearchPlan.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchPlanEN.UpdDate, conzx_ResearchPlan.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchPlanEN.Memo, conzx_ResearchPlan.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchPlanEN.PlanTypeId, conzx_ResearchPlan.PlanTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_ResearchPlanEN.GroupTextId, conzx_ResearchPlan.GroupTextId);
//检查外键字段长度
 objzx_ResearchPlanEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_ResearchPlan(中学研究计划),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxPlanId = '{0}'", objzx_ResearchPlanEN.zxPlanId);
 if (objzx_ResearchPlanEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null");
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ResearchPlanEN.GroupTextId);
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
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
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
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
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
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_ResearchPlanEN._CurrTabName);
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
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_ResearchPlanEN._CurrTabName, strCondition);
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
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
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
 objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}