
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingPlanDA
 表名:TeachingPlan(01120387)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:56
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
 /// 教案(TeachingPlan)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsTeachingPlanDA : clsCommBase4DA
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
 return clsTeachingPlanEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTeachingPlanEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTeachingPlanEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTeachingPlanEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTeachingPlanEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdTeachingPlan">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdTeachingPlan)
{
strIdTeachingPlan = strIdTeachingPlan.Replace("'", "''");
if (strIdTeachingPlan.Length > 8)
{
throw new Exception("(errid:Data000001)在表:TeachingPlan中,检查关键字,长度不正确!(clsTeachingPlanDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdTeachingPlan)  ==  true)
{
throw new Exception("(errid:Data000002)在表:TeachingPlan中,关键字不能为空 或 null!(clsTeachingPlanDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeachingPlan);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsTeachingPlanDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTeachingPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from TeachingPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TeachingPlan(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTeachingPlanDA: GetDataTable_TeachingPlan)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from TeachingPlan where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTeachingPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTeachingPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from TeachingPlan where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTeachingPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTeachingPlanDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachingPlan where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachingPlan where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTeachingPlanDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TeachingPlan where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTeachingPlanDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeachingPlan.* from TeachingPlan Left Join {1} on {2} where {3} and TeachingPlan.IdTeachingPlan not in (Select top {5} TeachingPlan.IdTeachingPlan from TeachingPlan Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachingPlan where {1} and IdTeachingPlan not in (Select top {2} IdTeachingPlan from TeachingPlan where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachingPlan where {1} and IdTeachingPlan not in (Select top {3} IdTeachingPlan from TeachingPlan where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTeachingPlanDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeachingPlan.* from TeachingPlan Left Join {1} on {2} where {3} and TeachingPlan.IdTeachingPlan not in (Select top {5} TeachingPlan.IdTeachingPlan from TeachingPlan Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachingPlan where {1} and IdTeachingPlan not in (Select top {2} IdTeachingPlan from TeachingPlan where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachingPlan where {1} and IdTeachingPlan not in (Select top {3} IdTeachingPlan from TeachingPlan where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsTeachingPlanEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTeachingPlanDA:GetObjLst)", objException.Message));
}
List<clsTeachingPlanEN> arrObjLst = new List<clsTeachingPlanEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from TeachingPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingPlanEN objTeachingPlanEN = new clsTeachingPlanEN();
try
{
objTeachingPlanEN.IdTeachingPlan = objRow[conTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingPlanEN.SubjectName = objRow[conTeachingPlan.SubjectName] == DBNull.Value ? null : objRow[conTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objTeachingPlanEN.TeachingPlanAuthor = objRow[conTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objTeachingPlanEN.TeachingObject = objRow[conTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objTeachingPlanEN.TeachingEmphases = objRow[conTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objTeachingPlanEN.TeachingDifficulty = objRow[conTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objTeachingPlanEN.TeachingTool = objRow[conTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objTeachingPlanEN.TeachingProcess = objRow[conTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objTeachingPlanEN.TeachingPlanType = objRow[conTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objTeachingPlanEN.SimplePlanContent = objRow[conTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[conTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objTeachingPlanEN.TeachingPlanInDate = objRow[conTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objTeachingPlanEN.TeachingPlanInTime = objRow[conTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objTeachingPlanEN.UpdDate = objRow[conTeachingPlan.UpdDate] == DBNull.Value ? null : objRow[conTeachingPlan.UpdDate].ToString().Trim(); //修改日期
objTeachingPlanEN.UpdUserId = objRow[conTeachingPlan.UpdUserId] == DBNull.Value ? null : objRow[conTeachingPlan.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingPlanEN.Memo = objRow[conTeachingPlan.Memo] == DBNull.Value ? null : objRow[conTeachingPlan.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeachingPlanDA: GetObjLst)", objException.Message));
}
objTeachingPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeachingPlanEN);
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
public List<clsTeachingPlanEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTeachingPlanDA:GetObjLstByTabName)", objException.Message));
}
List<clsTeachingPlanEN> arrObjLst = new List<clsTeachingPlanEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingPlanEN objTeachingPlanEN = new clsTeachingPlanEN();
try
{
objTeachingPlanEN.IdTeachingPlan = objRow[conTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingPlanEN.SubjectName = objRow[conTeachingPlan.SubjectName] == DBNull.Value ? null : objRow[conTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objTeachingPlanEN.TeachingPlanAuthor = objRow[conTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objTeachingPlanEN.TeachingObject = objRow[conTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objTeachingPlanEN.TeachingEmphases = objRow[conTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objTeachingPlanEN.TeachingDifficulty = objRow[conTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objTeachingPlanEN.TeachingTool = objRow[conTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objTeachingPlanEN.TeachingProcess = objRow[conTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objTeachingPlanEN.TeachingPlanType = objRow[conTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objTeachingPlanEN.SimplePlanContent = objRow[conTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[conTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objTeachingPlanEN.TeachingPlanInDate = objRow[conTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objTeachingPlanEN.TeachingPlanInTime = objRow[conTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objTeachingPlanEN.UpdDate = objRow[conTeachingPlan.UpdDate] == DBNull.Value ? null : objRow[conTeachingPlan.UpdDate].ToString().Trim(); //修改日期
objTeachingPlanEN.UpdUserId = objRow[conTeachingPlan.UpdUserId] == DBNull.Value ? null : objRow[conTeachingPlan.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingPlanEN.Memo = objRow[conTeachingPlan.Memo] == DBNull.Value ? null : objRow[conTeachingPlan.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeachingPlanDA: GetObjLst)", objException.Message));
}
objTeachingPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeachingPlanEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTeachingPlan(ref clsTeachingPlanEN objTeachingPlanEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from TeachingPlan where IdTeachingPlan = " + "'"+ objTeachingPlanEN.IdTeachingPlan+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTeachingPlanEN.IdTeachingPlan = objDT.Rows[0][conTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachingPlanEN.SubjectName = objDT.Rows[0][conTeachingPlan.SubjectName].ToString().Trim(); //课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objTeachingPlanEN.TeachingPlanAuthor = objDT.Rows[0][conTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人(字段类型:varchar,字段长度:50,是否可空:True)
 objTeachingPlanEN.TeachingObject = objDT.Rows[0][conTeachingPlan.TeachingObject].ToString().Trim(); //教学目标(字段类型:varchar,字段长度:5000,是否可空:True)
 objTeachingPlanEN.TeachingEmphases = objDT.Rows[0][conTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点(字段类型:varchar,字段长度:5000,是否可空:True)
 objTeachingPlanEN.TeachingDifficulty = objDT.Rows[0][conTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点(字段类型:varchar,字段长度:5000,是否可空:True)
 objTeachingPlanEN.TeachingTool = objDT.Rows[0][conTeachingPlan.TeachingTool].ToString().Trim(); //教学用具(字段类型:varchar,字段长度:5000,是否可空:True)
 objTeachingPlanEN.TeachingProcess = objDT.Rows[0][conTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程(字段类型:varchar,字段长度:8000,是否可空:True)
 objTeachingPlanEN.TeachingPlanType = objDT.Rows[0][conTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型(字段类型:char,字段长度:1,是否可空:True)
 objTeachingPlanEN.SimplePlanContent = objDT.Rows[0][conTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objTeachingPlanEN.TeachingPlanInDate = objDT.Rows[0][conTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期(字段类型:char,字段长度:8,是否可空:True)
 objTeachingPlanEN.TeachingPlanInTime = objDT.Rows[0][conTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间(字段类型:char,字段长度:6,是否可空:True)
 objTeachingPlanEN.UpdDate = objDT.Rows[0][conTeachingPlan.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingPlanEN.UpdUserId = objDT.Rows[0][conTeachingPlan.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingPlanEN.Memo = objDT.Rows[0][conTeachingPlan.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTeachingPlanDA: GetTeachingPlan)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdTeachingPlan">表关键字</param>
 /// <returns>表对象</returns>
public clsTeachingPlanEN GetObjByIdTeachingPlan(string strIdTeachingPlan)
{
CheckPrimaryKey(strIdTeachingPlan);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from TeachingPlan where IdTeachingPlan = " + "'"+ strIdTeachingPlan+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTeachingPlanEN objTeachingPlanEN = new clsTeachingPlanEN();
try
{
 objTeachingPlanEN.IdTeachingPlan = objRow[conTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachingPlanEN.SubjectName = objRow[conTeachingPlan.SubjectName] == DBNull.Value ? null : objRow[conTeachingPlan.SubjectName].ToString().Trim(); //课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objTeachingPlanEN.TeachingPlanAuthor = objRow[conTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人(字段类型:varchar,字段长度:50,是否可空:True)
 objTeachingPlanEN.TeachingObject = objRow[conTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingObject].ToString().Trim(); //教学目标(字段类型:varchar,字段长度:5000,是否可空:True)
 objTeachingPlanEN.TeachingEmphases = objRow[conTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点(字段类型:varchar,字段长度:5000,是否可空:True)
 objTeachingPlanEN.TeachingDifficulty = objRow[conTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点(字段类型:varchar,字段长度:5000,是否可空:True)
 objTeachingPlanEN.TeachingTool = objRow[conTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingTool].ToString().Trim(); //教学用具(字段类型:varchar,字段长度:5000,是否可空:True)
 objTeachingPlanEN.TeachingProcess = objRow[conTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程(字段类型:varchar,字段长度:8000,是否可空:True)
 objTeachingPlanEN.TeachingPlanType = objRow[conTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型(字段类型:char,字段长度:1,是否可空:True)
 objTeachingPlanEN.SimplePlanContent = objRow[conTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[conTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objTeachingPlanEN.TeachingPlanInDate = objRow[conTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期(字段类型:char,字段长度:8,是否可空:True)
 objTeachingPlanEN.TeachingPlanInTime = objRow[conTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间(字段类型:char,字段长度:6,是否可空:True)
 objTeachingPlanEN.UpdDate = objRow[conTeachingPlan.UpdDate] == DBNull.Value ? null : objRow[conTeachingPlan.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingPlanEN.UpdUserId = objRow[conTeachingPlan.UpdUserId] == DBNull.Value ? null : objRow[conTeachingPlan.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingPlanEN.Memo = objRow[conTeachingPlan.Memo] == DBNull.Value ? null : objRow[conTeachingPlan.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTeachingPlanDA: GetObjByIdTeachingPlan)", objException.Message));
}
return objTeachingPlanEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTeachingPlanEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTeachingPlanDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from TeachingPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTeachingPlanEN objTeachingPlanEN = new clsTeachingPlanEN()
{
IdTeachingPlan = objRow[conTeachingPlan.IdTeachingPlan].ToString().Trim(), //教案流水号
SubjectName = objRow[conTeachingPlan.SubjectName] == DBNull.Value ? null : objRow[conTeachingPlan.SubjectName].ToString().Trim(), //课题名称
TeachingPlanAuthor = objRow[conTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanAuthor].ToString().Trim(), //教案撰写人
TeachingObject = objRow[conTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingObject].ToString().Trim(), //教学目标
TeachingEmphases = objRow[conTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingEmphases].ToString().Trim(), //教学重点
TeachingDifficulty = objRow[conTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingDifficulty].ToString().Trim(), //教学难点
TeachingTool = objRow[conTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingTool].ToString().Trim(), //教学用具
TeachingProcess = objRow[conTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingProcess].ToString().Trim(), //教学过程
TeachingPlanType = objRow[conTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanType].ToString().Trim(), //教案类型
SimplePlanContent = objRow[conTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[conTeachingPlan.SimplePlanContent].ToString().Trim(), //简案内容
TeachingPlanInDate = objRow[conTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInDate].ToString().Trim(), //教案入库日期
TeachingPlanInTime = objRow[conTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInTime].ToString().Trim(), //教案入库时间
UpdDate = objRow[conTeachingPlan.UpdDate] == DBNull.Value ? null : objRow[conTeachingPlan.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conTeachingPlan.UpdUserId] == DBNull.Value ? null : objRow[conTeachingPlan.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conTeachingPlan.Memo] == DBNull.Value ? null : objRow[conTeachingPlan.Memo].ToString().Trim() //备注
};
objTeachingPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachingPlanEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTeachingPlanDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTeachingPlanEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeachingPlanEN objTeachingPlanEN = new clsTeachingPlanEN();
try
{
objTeachingPlanEN.IdTeachingPlan = objRow[conTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingPlanEN.SubjectName = objRow[conTeachingPlan.SubjectName] == DBNull.Value ? null : objRow[conTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objTeachingPlanEN.TeachingPlanAuthor = objRow[conTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objTeachingPlanEN.TeachingObject = objRow[conTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objTeachingPlanEN.TeachingEmphases = objRow[conTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objTeachingPlanEN.TeachingDifficulty = objRow[conTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objTeachingPlanEN.TeachingTool = objRow[conTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objTeachingPlanEN.TeachingProcess = objRow[conTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objTeachingPlanEN.TeachingPlanType = objRow[conTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objTeachingPlanEN.SimplePlanContent = objRow[conTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[conTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objTeachingPlanEN.TeachingPlanInDate = objRow[conTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objTeachingPlanEN.TeachingPlanInTime = objRow[conTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objTeachingPlanEN.UpdDate = objRow[conTeachingPlan.UpdDate] == DBNull.Value ? null : objRow[conTeachingPlan.UpdDate].ToString().Trim(); //修改日期
objTeachingPlanEN.UpdUserId = objRow[conTeachingPlan.UpdUserId] == DBNull.Value ? null : objRow[conTeachingPlan.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingPlanEN.Memo = objRow[conTeachingPlan.Memo] == DBNull.Value ? null : objRow[conTeachingPlan.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTeachingPlanDA: GetObjByDataRowTeachingPlan)", objException.Message));
}
objTeachingPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachingPlanEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTeachingPlanEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeachingPlanEN objTeachingPlanEN = new clsTeachingPlanEN();
try
{
objTeachingPlanEN.IdTeachingPlan = objRow[conTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingPlanEN.SubjectName = objRow[conTeachingPlan.SubjectName] == DBNull.Value ? null : objRow[conTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objTeachingPlanEN.TeachingPlanAuthor = objRow[conTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objTeachingPlanEN.TeachingObject = objRow[conTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objTeachingPlanEN.TeachingEmphases = objRow[conTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objTeachingPlanEN.TeachingDifficulty = objRow[conTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objTeachingPlanEN.TeachingTool = objRow[conTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objTeachingPlanEN.TeachingProcess = objRow[conTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objTeachingPlanEN.TeachingPlanType = objRow[conTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objTeachingPlanEN.SimplePlanContent = objRow[conTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[conTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objTeachingPlanEN.TeachingPlanInDate = objRow[conTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objTeachingPlanEN.TeachingPlanInTime = objRow[conTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[conTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objTeachingPlanEN.UpdDate = objRow[conTeachingPlan.UpdDate] == DBNull.Value ? null : objRow[conTeachingPlan.UpdDate].ToString().Trim(); //修改日期
objTeachingPlanEN.UpdUserId = objRow[conTeachingPlan.UpdUserId] == DBNull.Value ? null : objRow[conTeachingPlan.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingPlanEN.Memo = objRow[conTeachingPlan.Memo] == DBNull.Value ? null : objRow[conTeachingPlan.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTeachingPlanDA: GetObjByDataRow)", objException.Message));
}
objTeachingPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachingPlanEN;
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
objSQL = clsTeachingPlanDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeachingPlanEN._CurrTabName, conTeachingPlan.IdTeachingPlan, 8, "");
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
objSQL = clsTeachingPlanDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeachingPlanEN._CurrTabName, conTeachingPlan.IdTeachingPlan, 8, strPrefix);
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
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdTeachingPlan from TeachingPlan where " + strCondition;
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
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdTeachingPlan from TeachingPlan where " + strCondition;
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
 /// <param name = "strIdTeachingPlan">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdTeachingPlan)
{
CheckPrimaryKey(strIdTeachingPlan);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeachingPlan", "IdTeachingPlan = " + "'"+ strIdTeachingPlan+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTeachingPlanDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeachingPlan", strCondition))
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
objSQL = clsTeachingPlanDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TeachingPlan");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTeachingPlanEN objTeachingPlanEN)
 {
 objTeachingPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingPlanEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from TeachingPlan where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeachingPlan");
objRow = objDS.Tables["TeachingPlan"].NewRow();
objRow[conTeachingPlan.IdTeachingPlan] = objTeachingPlanEN.IdTeachingPlan; //教案流水号
 if (objTeachingPlanEN.SubjectName !=  "")
 {
objRow[conTeachingPlan.SubjectName] = objTeachingPlanEN.SubjectName; //课题名称
 }
 if (objTeachingPlanEN.TeachingPlanAuthor !=  "")
 {
objRow[conTeachingPlan.TeachingPlanAuthor] = objTeachingPlanEN.TeachingPlanAuthor; //教案撰写人
 }
 if (objTeachingPlanEN.TeachingObject !=  "")
 {
objRow[conTeachingPlan.TeachingObject] = objTeachingPlanEN.TeachingObject; //教学目标
 }
 if (objTeachingPlanEN.TeachingEmphases !=  "")
 {
objRow[conTeachingPlan.TeachingEmphases] = objTeachingPlanEN.TeachingEmphases; //教学重点
 }
 if (objTeachingPlanEN.TeachingDifficulty !=  "")
 {
objRow[conTeachingPlan.TeachingDifficulty] = objTeachingPlanEN.TeachingDifficulty; //教学难点
 }
 if (objTeachingPlanEN.TeachingTool !=  "")
 {
objRow[conTeachingPlan.TeachingTool] = objTeachingPlanEN.TeachingTool; //教学用具
 }
 if (objTeachingPlanEN.TeachingProcess !=  "")
 {
objRow[conTeachingPlan.TeachingProcess] = objTeachingPlanEN.TeachingProcess; //教学过程
 }
 if (objTeachingPlanEN.TeachingPlanType !=  "")
 {
objRow[conTeachingPlan.TeachingPlanType] = objTeachingPlanEN.TeachingPlanType; //教案类型
 }
 if (objTeachingPlanEN.SimplePlanContent !=  "")
 {
objRow[conTeachingPlan.SimplePlanContent] = objTeachingPlanEN.SimplePlanContent; //简案内容
 }
 if (objTeachingPlanEN.TeachingPlanInDate !=  "")
 {
objRow[conTeachingPlan.TeachingPlanInDate] = objTeachingPlanEN.TeachingPlanInDate; //教案入库日期
 }
 if (objTeachingPlanEN.TeachingPlanInTime !=  "")
 {
objRow[conTeachingPlan.TeachingPlanInTime] = objTeachingPlanEN.TeachingPlanInTime; //教案入库时间
 }
 if (objTeachingPlanEN.UpdDate !=  "")
 {
objRow[conTeachingPlan.UpdDate] = objTeachingPlanEN.UpdDate; //修改日期
 }
 if (objTeachingPlanEN.UpdUserId !=  "")
 {
objRow[conTeachingPlan.UpdUserId] = objTeachingPlanEN.UpdUserId; //修改用户Id
 }
 if (objTeachingPlanEN.Memo !=  "")
 {
objRow[conTeachingPlan.Memo] = objTeachingPlanEN.Memo; //备注
 }
objDS.Tables[clsTeachingPlanEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTeachingPlanEN._CurrTabName);
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
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeachingPlanEN objTeachingPlanEN)
{
 objTeachingPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingPlanEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachingPlanEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.IdTeachingPlan);
 var strIdTeachingPlan = objTeachingPlanEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objTeachingPlanEN.SubjectName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.SubjectName);
 var strSubjectName = objTeachingPlanEN.SubjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubjectName + "'");
 }
 
 if (objTeachingPlanEN.TeachingPlanAuthor !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingPlanAuthor);
 var strTeachingPlanAuthor = objTeachingPlanEN.TeachingPlanAuthor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanAuthor + "'");
 }
 
 if (objTeachingPlanEN.TeachingObject !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingObject);
 var strTeachingObject = objTeachingPlanEN.TeachingObject.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingObject + "'");
 }
 
 if (objTeachingPlanEN.TeachingEmphases !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingEmphases);
 var strTeachingEmphases = objTeachingPlanEN.TeachingEmphases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingEmphases + "'");
 }
 
 if (objTeachingPlanEN.TeachingDifficulty !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingDifficulty);
 var strTeachingDifficulty = objTeachingPlanEN.TeachingDifficulty.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingDifficulty + "'");
 }
 
 if (objTeachingPlanEN.TeachingTool !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingTool);
 var strTeachingTool = objTeachingPlanEN.TeachingTool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingTool + "'");
 }
 
 if (objTeachingPlanEN.TeachingProcess !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingProcess);
 var strTeachingProcess = objTeachingPlanEN.TeachingProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingProcess + "'");
 }
 
 if (objTeachingPlanEN.TeachingPlanType !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingPlanType);
 var strTeachingPlanType = objTeachingPlanEN.TeachingPlanType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanType + "'");
 }
 
 if (objTeachingPlanEN.SimplePlanContent !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.SimplePlanContent);
 var strSimplePlanContent = objTeachingPlanEN.SimplePlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSimplePlanContent + "'");
 }
 
 if (objTeachingPlanEN.TeachingPlanInDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingPlanInDate);
 var strTeachingPlanInDate = objTeachingPlanEN.TeachingPlanInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanInDate + "'");
 }
 
 if (objTeachingPlanEN.TeachingPlanInTime !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingPlanInTime);
 var strTeachingPlanInTime = objTeachingPlanEN.TeachingPlanInTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanInTime + "'");
 }
 
 if (objTeachingPlanEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.UpdDate);
 var strUpdDate = objTeachingPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingPlanEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.UpdUserId);
 var strUpdUserId = objTeachingPlanEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachingPlanEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.Memo);
 var strMemo = objTeachingPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingPlan");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeachingPlanEN objTeachingPlanEN)
{
 objTeachingPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingPlanEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachingPlanEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.IdTeachingPlan);
 var strIdTeachingPlan = objTeachingPlanEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objTeachingPlanEN.SubjectName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.SubjectName);
 var strSubjectName = objTeachingPlanEN.SubjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubjectName + "'");
 }
 
 if (objTeachingPlanEN.TeachingPlanAuthor !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingPlanAuthor);
 var strTeachingPlanAuthor = objTeachingPlanEN.TeachingPlanAuthor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanAuthor + "'");
 }
 
 if (objTeachingPlanEN.TeachingObject !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingObject);
 var strTeachingObject = objTeachingPlanEN.TeachingObject.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingObject + "'");
 }
 
 if (objTeachingPlanEN.TeachingEmphases !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingEmphases);
 var strTeachingEmphases = objTeachingPlanEN.TeachingEmphases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingEmphases + "'");
 }
 
 if (objTeachingPlanEN.TeachingDifficulty !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingDifficulty);
 var strTeachingDifficulty = objTeachingPlanEN.TeachingDifficulty.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingDifficulty + "'");
 }
 
 if (objTeachingPlanEN.TeachingTool !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingTool);
 var strTeachingTool = objTeachingPlanEN.TeachingTool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingTool + "'");
 }
 
 if (objTeachingPlanEN.TeachingProcess !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingProcess);
 var strTeachingProcess = objTeachingPlanEN.TeachingProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingProcess + "'");
 }
 
 if (objTeachingPlanEN.TeachingPlanType !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingPlanType);
 var strTeachingPlanType = objTeachingPlanEN.TeachingPlanType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanType + "'");
 }
 
 if (objTeachingPlanEN.SimplePlanContent !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.SimplePlanContent);
 var strSimplePlanContent = objTeachingPlanEN.SimplePlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSimplePlanContent + "'");
 }
 
 if (objTeachingPlanEN.TeachingPlanInDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingPlanInDate);
 var strTeachingPlanInDate = objTeachingPlanEN.TeachingPlanInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanInDate + "'");
 }
 
 if (objTeachingPlanEN.TeachingPlanInTime !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingPlanInTime);
 var strTeachingPlanInTime = objTeachingPlanEN.TeachingPlanInTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanInTime + "'");
 }
 
 if (objTeachingPlanEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.UpdDate);
 var strUpdDate = objTeachingPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingPlanEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.UpdUserId);
 var strUpdUserId = objTeachingPlanEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachingPlanEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.Memo);
 var strMemo = objTeachingPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingPlan");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objTeachingPlanEN.IdTeachingPlan;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeachingPlanEN objTeachingPlanEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTeachingPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingPlanEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachingPlanEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.IdTeachingPlan);
 var strIdTeachingPlan = objTeachingPlanEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objTeachingPlanEN.SubjectName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.SubjectName);
 var strSubjectName = objTeachingPlanEN.SubjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubjectName + "'");
 }
 
 if (objTeachingPlanEN.TeachingPlanAuthor !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingPlanAuthor);
 var strTeachingPlanAuthor = objTeachingPlanEN.TeachingPlanAuthor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanAuthor + "'");
 }
 
 if (objTeachingPlanEN.TeachingObject !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingObject);
 var strTeachingObject = objTeachingPlanEN.TeachingObject.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingObject + "'");
 }
 
 if (objTeachingPlanEN.TeachingEmphases !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingEmphases);
 var strTeachingEmphases = objTeachingPlanEN.TeachingEmphases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingEmphases + "'");
 }
 
 if (objTeachingPlanEN.TeachingDifficulty !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingDifficulty);
 var strTeachingDifficulty = objTeachingPlanEN.TeachingDifficulty.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingDifficulty + "'");
 }
 
 if (objTeachingPlanEN.TeachingTool !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingTool);
 var strTeachingTool = objTeachingPlanEN.TeachingTool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingTool + "'");
 }
 
 if (objTeachingPlanEN.TeachingProcess !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingProcess);
 var strTeachingProcess = objTeachingPlanEN.TeachingProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingProcess + "'");
 }
 
 if (objTeachingPlanEN.TeachingPlanType !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingPlanType);
 var strTeachingPlanType = objTeachingPlanEN.TeachingPlanType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanType + "'");
 }
 
 if (objTeachingPlanEN.SimplePlanContent !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.SimplePlanContent);
 var strSimplePlanContent = objTeachingPlanEN.SimplePlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSimplePlanContent + "'");
 }
 
 if (objTeachingPlanEN.TeachingPlanInDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingPlanInDate);
 var strTeachingPlanInDate = objTeachingPlanEN.TeachingPlanInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanInDate + "'");
 }
 
 if (objTeachingPlanEN.TeachingPlanInTime !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingPlanInTime);
 var strTeachingPlanInTime = objTeachingPlanEN.TeachingPlanInTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanInTime + "'");
 }
 
 if (objTeachingPlanEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.UpdDate);
 var strUpdDate = objTeachingPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingPlanEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.UpdUserId);
 var strUpdUserId = objTeachingPlanEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachingPlanEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.Memo);
 var strMemo = objTeachingPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingPlan");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objTeachingPlanEN.IdTeachingPlan;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeachingPlanEN objTeachingPlanEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTeachingPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingPlanEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachingPlanEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.IdTeachingPlan);
 var strIdTeachingPlan = objTeachingPlanEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objTeachingPlanEN.SubjectName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.SubjectName);
 var strSubjectName = objTeachingPlanEN.SubjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubjectName + "'");
 }
 
 if (objTeachingPlanEN.TeachingPlanAuthor !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingPlanAuthor);
 var strTeachingPlanAuthor = objTeachingPlanEN.TeachingPlanAuthor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanAuthor + "'");
 }
 
 if (objTeachingPlanEN.TeachingObject !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingObject);
 var strTeachingObject = objTeachingPlanEN.TeachingObject.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingObject + "'");
 }
 
 if (objTeachingPlanEN.TeachingEmphases !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingEmphases);
 var strTeachingEmphases = objTeachingPlanEN.TeachingEmphases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingEmphases + "'");
 }
 
 if (objTeachingPlanEN.TeachingDifficulty !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingDifficulty);
 var strTeachingDifficulty = objTeachingPlanEN.TeachingDifficulty.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingDifficulty + "'");
 }
 
 if (objTeachingPlanEN.TeachingTool !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingTool);
 var strTeachingTool = objTeachingPlanEN.TeachingTool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingTool + "'");
 }
 
 if (objTeachingPlanEN.TeachingProcess !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingProcess);
 var strTeachingProcess = objTeachingPlanEN.TeachingProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingProcess + "'");
 }
 
 if (objTeachingPlanEN.TeachingPlanType !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingPlanType);
 var strTeachingPlanType = objTeachingPlanEN.TeachingPlanType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanType + "'");
 }
 
 if (objTeachingPlanEN.SimplePlanContent !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.SimplePlanContent);
 var strSimplePlanContent = objTeachingPlanEN.SimplePlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSimplePlanContent + "'");
 }
 
 if (objTeachingPlanEN.TeachingPlanInDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingPlanInDate);
 var strTeachingPlanInDate = objTeachingPlanEN.TeachingPlanInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanInDate + "'");
 }
 
 if (objTeachingPlanEN.TeachingPlanInTime !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.TeachingPlanInTime);
 var strTeachingPlanInTime = objTeachingPlanEN.TeachingPlanInTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanInTime + "'");
 }
 
 if (objTeachingPlanEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.UpdDate);
 var strUpdDate = objTeachingPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingPlanEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.UpdUserId);
 var strUpdUserId = objTeachingPlanEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachingPlanEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingPlan.Memo);
 var strMemo = objTeachingPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingPlan");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTeachingPlans(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from TeachingPlan where IdTeachingPlan = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeachingPlan");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdTeachingPlan = oRow[conTeachingPlan.IdTeachingPlan].ToString().Trim();
if (IsExist(strIdTeachingPlan))
{
 string strResult = "关键字变量值为:" + string.Format("IdTeachingPlan = {0}", strIdTeachingPlan) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTeachingPlanEN._CurrTabName ].NewRow();
objRow[conTeachingPlan.IdTeachingPlan] = oRow[conTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objRow[conTeachingPlan.SubjectName] = oRow[conTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objRow[conTeachingPlan.TeachingPlanAuthor] = oRow[conTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objRow[conTeachingPlan.TeachingObject] = oRow[conTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objRow[conTeachingPlan.TeachingEmphases] = oRow[conTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objRow[conTeachingPlan.TeachingDifficulty] = oRow[conTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objRow[conTeachingPlan.TeachingTool] = oRow[conTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objRow[conTeachingPlan.TeachingProcess] = oRow[conTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objRow[conTeachingPlan.TeachingPlanType] = oRow[conTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objRow[conTeachingPlan.SimplePlanContent] = oRow[conTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objRow[conTeachingPlan.TeachingPlanInDate] = oRow[conTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objRow[conTeachingPlan.TeachingPlanInTime] = oRow[conTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objRow[conTeachingPlan.UpdDate] = oRow[conTeachingPlan.UpdDate].ToString().Trim(); //修改日期
objRow[conTeachingPlan.UpdUserId] = oRow[conTeachingPlan.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conTeachingPlan.Memo] = oRow[conTeachingPlan.Memo].ToString().Trim(); //备注
 objDS.Tables[clsTeachingPlanEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTeachingPlanEN._CurrTabName);
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
 /// <param name = "objTeachingPlanEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTeachingPlanEN objTeachingPlanEN)
{
 objTeachingPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingPlanEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from TeachingPlan where IdTeachingPlan = " + "'"+ objTeachingPlanEN.IdTeachingPlan+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTeachingPlanEN._CurrTabName);
if (objDS.Tables[clsTeachingPlanEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdTeachingPlan = " + "'"+ objTeachingPlanEN.IdTeachingPlan+"'");
return false;
}
objRow = objDS.Tables[clsTeachingPlanEN._CurrTabName].Rows[0];
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.IdTeachingPlan))
 {
objRow[conTeachingPlan.IdTeachingPlan] = objTeachingPlanEN.IdTeachingPlan; //教案流水号
 }
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.SubjectName))
 {
objRow[conTeachingPlan.SubjectName] = objTeachingPlanEN.SubjectName; //课题名称
 }
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanAuthor))
 {
objRow[conTeachingPlan.TeachingPlanAuthor] = objTeachingPlanEN.TeachingPlanAuthor; //教案撰写人
 }
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingObject))
 {
objRow[conTeachingPlan.TeachingObject] = objTeachingPlanEN.TeachingObject; //教学目标
 }
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingEmphases))
 {
objRow[conTeachingPlan.TeachingEmphases] = objTeachingPlanEN.TeachingEmphases; //教学重点
 }
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingDifficulty))
 {
objRow[conTeachingPlan.TeachingDifficulty] = objTeachingPlanEN.TeachingDifficulty; //教学难点
 }
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingTool))
 {
objRow[conTeachingPlan.TeachingTool] = objTeachingPlanEN.TeachingTool; //教学用具
 }
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingProcess))
 {
objRow[conTeachingPlan.TeachingProcess] = objTeachingPlanEN.TeachingProcess; //教学过程
 }
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanType))
 {
objRow[conTeachingPlan.TeachingPlanType] = objTeachingPlanEN.TeachingPlanType; //教案类型
 }
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.SimplePlanContent))
 {
objRow[conTeachingPlan.SimplePlanContent] = objTeachingPlanEN.SimplePlanContent; //简案内容
 }
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanInDate))
 {
objRow[conTeachingPlan.TeachingPlanInDate] = objTeachingPlanEN.TeachingPlanInDate; //教案入库日期
 }
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanInTime))
 {
objRow[conTeachingPlan.TeachingPlanInTime] = objTeachingPlanEN.TeachingPlanInTime; //教案入库时间
 }
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.UpdDate))
 {
objRow[conTeachingPlan.UpdDate] = objTeachingPlanEN.UpdDate; //修改日期
 }
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.UpdUserId))
 {
objRow[conTeachingPlan.UpdUserId] = objTeachingPlanEN.UpdUserId; //修改用户Id
 }
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.Memo))
 {
objRow[conTeachingPlan.Memo] = objTeachingPlanEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsTeachingPlanEN._CurrTabName);
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
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeachingPlanEN objTeachingPlanEN)
{
 objTeachingPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingPlanEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TeachingPlan Set ");
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.SubjectName))
 {
 if (objTeachingPlanEN.SubjectName !=  null)
 {
 var strSubjectName = objTeachingPlanEN.SubjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubjectName, conTeachingPlan.SubjectName); //课题名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.SubjectName); //课题名称
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanAuthor))
 {
 if (objTeachingPlanEN.TeachingPlanAuthor !=  null)
 {
 var strTeachingPlanAuthor = objTeachingPlanEN.TeachingPlanAuthor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingPlanAuthor, conTeachingPlan.TeachingPlanAuthor); //教案撰写人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingPlanAuthor); //教案撰写人
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingObject))
 {
 if (objTeachingPlanEN.TeachingObject !=  null)
 {
 var strTeachingObject = objTeachingPlanEN.TeachingObject.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingObject, conTeachingPlan.TeachingObject); //教学目标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingObject); //教学目标
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingEmphases))
 {
 if (objTeachingPlanEN.TeachingEmphases !=  null)
 {
 var strTeachingEmphases = objTeachingPlanEN.TeachingEmphases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingEmphases, conTeachingPlan.TeachingEmphases); //教学重点
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingEmphases); //教学重点
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingDifficulty))
 {
 if (objTeachingPlanEN.TeachingDifficulty !=  null)
 {
 var strTeachingDifficulty = objTeachingPlanEN.TeachingDifficulty.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingDifficulty, conTeachingPlan.TeachingDifficulty); //教学难点
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingDifficulty); //教学难点
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingTool))
 {
 if (objTeachingPlanEN.TeachingTool !=  null)
 {
 var strTeachingTool = objTeachingPlanEN.TeachingTool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingTool, conTeachingPlan.TeachingTool); //教学用具
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingTool); //教学用具
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingProcess))
 {
 if (objTeachingPlanEN.TeachingProcess !=  null)
 {
 var strTeachingProcess = objTeachingPlanEN.TeachingProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingProcess, conTeachingPlan.TeachingProcess); //教学过程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingProcess); //教学过程
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanType))
 {
 if (objTeachingPlanEN.TeachingPlanType !=  null)
 {
 var strTeachingPlanType = objTeachingPlanEN.TeachingPlanType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingPlanType, conTeachingPlan.TeachingPlanType); //教案类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingPlanType); //教案类型
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.SimplePlanContent))
 {
 if (objTeachingPlanEN.SimplePlanContent !=  null)
 {
 var strSimplePlanContent = objTeachingPlanEN.SimplePlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSimplePlanContent, conTeachingPlan.SimplePlanContent); //简案内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.SimplePlanContent); //简案内容
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanInDate))
 {
 if (objTeachingPlanEN.TeachingPlanInDate !=  null)
 {
 var strTeachingPlanInDate = objTeachingPlanEN.TeachingPlanInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingPlanInDate, conTeachingPlan.TeachingPlanInDate); //教案入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingPlanInDate); //教案入库日期
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanInTime))
 {
 if (objTeachingPlanEN.TeachingPlanInTime !=  null)
 {
 var strTeachingPlanInTime = objTeachingPlanEN.TeachingPlanInTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingPlanInTime, conTeachingPlan.TeachingPlanInTime); //教案入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingPlanInTime); //教案入库时间
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.UpdDate))
 {
 if (objTeachingPlanEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTeachingPlan.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.UpdDate); //修改日期
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.UpdUserId))
 {
 if (objTeachingPlanEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachingPlanEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conTeachingPlan.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.UpdUserId); //修改用户Id
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.Memo))
 {
 if (objTeachingPlanEN.Memo !=  null)
 {
 var strMemo = objTeachingPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeachingPlan.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdTeachingPlan = '{0}'", objTeachingPlanEN.IdTeachingPlan); 
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
 /// <param name = "objTeachingPlanEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTeachingPlanEN objTeachingPlanEN, string strCondition)
{
 objTeachingPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingPlanEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachingPlan Set ");
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.SubjectName))
 {
 if (objTeachingPlanEN.SubjectName !=  null)
 {
 var strSubjectName = objTeachingPlanEN.SubjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubjectName = '{0}',", strSubjectName); //课题名称
 }
 else
 {
 sbSQL.Append(" SubjectName = null,"); //课题名称
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanAuthor))
 {
 if (objTeachingPlanEN.TeachingPlanAuthor !=  null)
 {
 var strTeachingPlanAuthor = objTeachingPlanEN.TeachingPlanAuthor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingPlanAuthor = '{0}',", strTeachingPlanAuthor); //教案撰写人
 }
 else
 {
 sbSQL.Append(" TeachingPlanAuthor = null,"); //教案撰写人
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingObject))
 {
 if (objTeachingPlanEN.TeachingObject !=  null)
 {
 var strTeachingObject = objTeachingPlanEN.TeachingObject.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingObject = '{0}',", strTeachingObject); //教学目标
 }
 else
 {
 sbSQL.Append(" TeachingObject = null,"); //教学目标
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingEmphases))
 {
 if (objTeachingPlanEN.TeachingEmphases !=  null)
 {
 var strTeachingEmphases = objTeachingPlanEN.TeachingEmphases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingEmphases = '{0}',", strTeachingEmphases); //教学重点
 }
 else
 {
 sbSQL.Append(" TeachingEmphases = null,"); //教学重点
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingDifficulty))
 {
 if (objTeachingPlanEN.TeachingDifficulty !=  null)
 {
 var strTeachingDifficulty = objTeachingPlanEN.TeachingDifficulty.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingDifficulty = '{0}',", strTeachingDifficulty); //教学难点
 }
 else
 {
 sbSQL.Append(" TeachingDifficulty = null,"); //教学难点
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingTool))
 {
 if (objTeachingPlanEN.TeachingTool !=  null)
 {
 var strTeachingTool = objTeachingPlanEN.TeachingTool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingTool = '{0}',", strTeachingTool); //教学用具
 }
 else
 {
 sbSQL.Append(" TeachingTool = null,"); //教学用具
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingProcess))
 {
 if (objTeachingPlanEN.TeachingProcess !=  null)
 {
 var strTeachingProcess = objTeachingPlanEN.TeachingProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingProcess = '{0}',", strTeachingProcess); //教学过程
 }
 else
 {
 sbSQL.Append(" TeachingProcess = null,"); //教学过程
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanType))
 {
 if (objTeachingPlanEN.TeachingPlanType !=  null)
 {
 var strTeachingPlanType = objTeachingPlanEN.TeachingPlanType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingPlanType = '{0}',", strTeachingPlanType); //教案类型
 }
 else
 {
 sbSQL.Append(" TeachingPlanType = null,"); //教案类型
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.SimplePlanContent))
 {
 if (objTeachingPlanEN.SimplePlanContent !=  null)
 {
 var strSimplePlanContent = objTeachingPlanEN.SimplePlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SimplePlanContent = '{0}',", strSimplePlanContent); //简案内容
 }
 else
 {
 sbSQL.Append(" SimplePlanContent = null,"); //简案内容
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanInDate))
 {
 if (objTeachingPlanEN.TeachingPlanInDate !=  null)
 {
 var strTeachingPlanInDate = objTeachingPlanEN.TeachingPlanInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingPlanInDate = '{0}',", strTeachingPlanInDate); //教案入库日期
 }
 else
 {
 sbSQL.Append(" TeachingPlanInDate = null,"); //教案入库日期
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanInTime))
 {
 if (objTeachingPlanEN.TeachingPlanInTime !=  null)
 {
 var strTeachingPlanInTime = objTeachingPlanEN.TeachingPlanInTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingPlanInTime = '{0}',", strTeachingPlanInTime); //教案入库时间
 }
 else
 {
 sbSQL.Append(" TeachingPlanInTime = null,"); //教案入库时间
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.UpdDate))
 {
 if (objTeachingPlanEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.UpdUserId))
 {
 if (objTeachingPlanEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachingPlanEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.Memo))
 {
 if (objTeachingPlanEN.Memo !=  null)
 {
 var strMemo = objTeachingPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTeachingPlanEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTeachingPlanEN objTeachingPlanEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTeachingPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingPlanEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachingPlan Set ");
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.SubjectName))
 {
 if (objTeachingPlanEN.SubjectName !=  null)
 {
 var strSubjectName = objTeachingPlanEN.SubjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubjectName = '{0}',", strSubjectName); //课题名称
 }
 else
 {
 sbSQL.Append(" SubjectName = null,"); //课题名称
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanAuthor))
 {
 if (objTeachingPlanEN.TeachingPlanAuthor !=  null)
 {
 var strTeachingPlanAuthor = objTeachingPlanEN.TeachingPlanAuthor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingPlanAuthor = '{0}',", strTeachingPlanAuthor); //教案撰写人
 }
 else
 {
 sbSQL.Append(" TeachingPlanAuthor = null,"); //教案撰写人
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingObject))
 {
 if (objTeachingPlanEN.TeachingObject !=  null)
 {
 var strTeachingObject = objTeachingPlanEN.TeachingObject.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingObject = '{0}',", strTeachingObject); //教学目标
 }
 else
 {
 sbSQL.Append(" TeachingObject = null,"); //教学目标
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingEmphases))
 {
 if (objTeachingPlanEN.TeachingEmphases !=  null)
 {
 var strTeachingEmphases = objTeachingPlanEN.TeachingEmphases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingEmphases = '{0}',", strTeachingEmphases); //教学重点
 }
 else
 {
 sbSQL.Append(" TeachingEmphases = null,"); //教学重点
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingDifficulty))
 {
 if (objTeachingPlanEN.TeachingDifficulty !=  null)
 {
 var strTeachingDifficulty = objTeachingPlanEN.TeachingDifficulty.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingDifficulty = '{0}',", strTeachingDifficulty); //教学难点
 }
 else
 {
 sbSQL.Append(" TeachingDifficulty = null,"); //教学难点
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingTool))
 {
 if (objTeachingPlanEN.TeachingTool !=  null)
 {
 var strTeachingTool = objTeachingPlanEN.TeachingTool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingTool = '{0}',", strTeachingTool); //教学用具
 }
 else
 {
 sbSQL.Append(" TeachingTool = null,"); //教学用具
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingProcess))
 {
 if (objTeachingPlanEN.TeachingProcess !=  null)
 {
 var strTeachingProcess = objTeachingPlanEN.TeachingProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingProcess = '{0}',", strTeachingProcess); //教学过程
 }
 else
 {
 sbSQL.Append(" TeachingProcess = null,"); //教学过程
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanType))
 {
 if (objTeachingPlanEN.TeachingPlanType !=  null)
 {
 var strTeachingPlanType = objTeachingPlanEN.TeachingPlanType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingPlanType = '{0}',", strTeachingPlanType); //教案类型
 }
 else
 {
 sbSQL.Append(" TeachingPlanType = null,"); //教案类型
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.SimplePlanContent))
 {
 if (objTeachingPlanEN.SimplePlanContent !=  null)
 {
 var strSimplePlanContent = objTeachingPlanEN.SimplePlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SimplePlanContent = '{0}',", strSimplePlanContent); //简案内容
 }
 else
 {
 sbSQL.Append(" SimplePlanContent = null,"); //简案内容
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanInDate))
 {
 if (objTeachingPlanEN.TeachingPlanInDate !=  null)
 {
 var strTeachingPlanInDate = objTeachingPlanEN.TeachingPlanInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingPlanInDate = '{0}',", strTeachingPlanInDate); //教案入库日期
 }
 else
 {
 sbSQL.Append(" TeachingPlanInDate = null,"); //教案入库日期
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanInTime))
 {
 if (objTeachingPlanEN.TeachingPlanInTime !=  null)
 {
 var strTeachingPlanInTime = objTeachingPlanEN.TeachingPlanInTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingPlanInTime = '{0}',", strTeachingPlanInTime); //教案入库时间
 }
 else
 {
 sbSQL.Append(" TeachingPlanInTime = null,"); //教案入库时间
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.UpdDate))
 {
 if (objTeachingPlanEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.UpdUserId))
 {
 if (objTeachingPlanEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachingPlanEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.Memo))
 {
 if (objTeachingPlanEN.Memo !=  null)
 {
 var strMemo = objTeachingPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeachingPlanEN objTeachingPlanEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTeachingPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingPlanEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachingPlan Set ");
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.SubjectName))
 {
 if (objTeachingPlanEN.SubjectName !=  null)
 {
 var strSubjectName = objTeachingPlanEN.SubjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubjectName, conTeachingPlan.SubjectName); //课题名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.SubjectName); //课题名称
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanAuthor))
 {
 if (objTeachingPlanEN.TeachingPlanAuthor !=  null)
 {
 var strTeachingPlanAuthor = objTeachingPlanEN.TeachingPlanAuthor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingPlanAuthor, conTeachingPlan.TeachingPlanAuthor); //教案撰写人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingPlanAuthor); //教案撰写人
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingObject))
 {
 if (objTeachingPlanEN.TeachingObject !=  null)
 {
 var strTeachingObject = objTeachingPlanEN.TeachingObject.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingObject, conTeachingPlan.TeachingObject); //教学目标
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingObject); //教学目标
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingEmphases))
 {
 if (objTeachingPlanEN.TeachingEmphases !=  null)
 {
 var strTeachingEmphases = objTeachingPlanEN.TeachingEmphases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingEmphases, conTeachingPlan.TeachingEmphases); //教学重点
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingEmphases); //教学重点
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingDifficulty))
 {
 if (objTeachingPlanEN.TeachingDifficulty !=  null)
 {
 var strTeachingDifficulty = objTeachingPlanEN.TeachingDifficulty.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingDifficulty, conTeachingPlan.TeachingDifficulty); //教学难点
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingDifficulty); //教学难点
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingTool))
 {
 if (objTeachingPlanEN.TeachingTool !=  null)
 {
 var strTeachingTool = objTeachingPlanEN.TeachingTool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingTool, conTeachingPlan.TeachingTool); //教学用具
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingTool); //教学用具
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingProcess))
 {
 if (objTeachingPlanEN.TeachingProcess !=  null)
 {
 var strTeachingProcess = objTeachingPlanEN.TeachingProcess.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingProcess, conTeachingPlan.TeachingProcess); //教学过程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingProcess); //教学过程
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanType))
 {
 if (objTeachingPlanEN.TeachingPlanType !=  null)
 {
 var strTeachingPlanType = objTeachingPlanEN.TeachingPlanType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingPlanType, conTeachingPlan.TeachingPlanType); //教案类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingPlanType); //教案类型
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.SimplePlanContent))
 {
 if (objTeachingPlanEN.SimplePlanContent !=  null)
 {
 var strSimplePlanContent = objTeachingPlanEN.SimplePlanContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSimplePlanContent, conTeachingPlan.SimplePlanContent); //简案内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.SimplePlanContent); //简案内容
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanInDate))
 {
 if (objTeachingPlanEN.TeachingPlanInDate !=  null)
 {
 var strTeachingPlanInDate = objTeachingPlanEN.TeachingPlanInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingPlanInDate, conTeachingPlan.TeachingPlanInDate); //教案入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingPlanInDate); //教案入库日期
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.TeachingPlanInTime))
 {
 if (objTeachingPlanEN.TeachingPlanInTime !=  null)
 {
 var strTeachingPlanInTime = objTeachingPlanEN.TeachingPlanInTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingPlanInTime, conTeachingPlan.TeachingPlanInTime); //教案入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.TeachingPlanInTime); //教案入库时间
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.UpdDate))
 {
 if (objTeachingPlanEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingPlanEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTeachingPlan.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.UpdDate); //修改日期
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.UpdUserId))
 {
 if (objTeachingPlanEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachingPlanEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conTeachingPlan.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.UpdUserId); //修改用户Id
 }
 }
 
 if (objTeachingPlanEN.IsUpdated(conTeachingPlan.Memo))
 {
 if (objTeachingPlanEN.Memo !=  null)
 {
 var strMemo = objTeachingPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeachingPlan.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingPlan.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdTeachingPlan = '{0}'", objTeachingPlanEN.IdTeachingPlan); 
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
 /// <param name = "strIdTeachingPlan">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdTeachingPlan) 
{
CheckPrimaryKey(strIdTeachingPlan);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdTeachingPlan,
};
 objSQL.ExecSP("TeachingPlan_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdTeachingPlan">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdTeachingPlan, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdTeachingPlan);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
//删除TeachingPlan本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachingPlan where IdTeachingPlan = " + "'"+ strIdTeachingPlan+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTeachingPlan(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
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
//删除TeachingPlan本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachingPlan where IdTeachingPlan in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdTeachingPlan">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdTeachingPlan) 
{
CheckPrimaryKey(strIdTeachingPlan);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
//删除TeachingPlan本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachingPlan where IdTeachingPlan = " + "'"+ strIdTeachingPlan+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTeachingPlan(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTeachingPlanDA: DelTeachingPlan)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeachingPlan where " + strCondition ;
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
public bool DelTeachingPlanWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTeachingPlanDA: DelTeachingPlanWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeachingPlan where " + strCondition ;
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
 /// <param name = "objTeachingPlanENS">源对象</param>
 /// <param name = "objTeachingPlanENT">目标对象</param>
public void CopyTo(clsTeachingPlanEN objTeachingPlanENS, clsTeachingPlanEN objTeachingPlanENT)
{
objTeachingPlanENT.IdTeachingPlan = objTeachingPlanENS.IdTeachingPlan; //教案流水号
objTeachingPlanENT.SubjectName = objTeachingPlanENS.SubjectName; //课题名称
objTeachingPlanENT.TeachingPlanAuthor = objTeachingPlanENS.TeachingPlanAuthor; //教案撰写人
objTeachingPlanENT.TeachingObject = objTeachingPlanENS.TeachingObject; //教学目标
objTeachingPlanENT.TeachingEmphases = objTeachingPlanENS.TeachingEmphases; //教学重点
objTeachingPlanENT.TeachingDifficulty = objTeachingPlanENS.TeachingDifficulty; //教学难点
objTeachingPlanENT.TeachingTool = objTeachingPlanENS.TeachingTool; //教学用具
objTeachingPlanENT.TeachingProcess = objTeachingPlanENS.TeachingProcess; //教学过程
objTeachingPlanENT.TeachingPlanType = objTeachingPlanENS.TeachingPlanType; //教案类型
objTeachingPlanENT.SimplePlanContent = objTeachingPlanENS.SimplePlanContent; //简案内容
objTeachingPlanENT.TeachingPlanInDate = objTeachingPlanENS.TeachingPlanInDate; //教案入库日期
objTeachingPlanENT.TeachingPlanInTime = objTeachingPlanENS.TeachingPlanInTime; //教案入库时间
objTeachingPlanENT.UpdDate = objTeachingPlanENS.UpdDate; //修改日期
objTeachingPlanENT.UpdUserId = objTeachingPlanENS.UpdUserId; //修改用户Id
objTeachingPlanENT.Memo = objTeachingPlanENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTeachingPlanEN objTeachingPlanEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachingPlanEN.IdTeachingPlan, 8, conTeachingPlan.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.SubjectName, 200, conTeachingPlan.SubjectName);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingPlanAuthor, 50, conTeachingPlan.TeachingPlanAuthor);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingObject, 5000, conTeachingPlan.TeachingObject);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingEmphases, 5000, conTeachingPlan.TeachingEmphases);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingDifficulty, 5000, conTeachingPlan.TeachingDifficulty);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingTool, 5000, conTeachingPlan.TeachingTool);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingProcess, 8000, conTeachingPlan.TeachingProcess);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingPlanType, 1, conTeachingPlan.TeachingPlanType);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingPlanInDate, 8, conTeachingPlan.TeachingPlanInDate);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingPlanInTime, 6, conTeachingPlan.TeachingPlanInTime);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.UpdDate, 20, conTeachingPlan.UpdDate);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.UpdUserId, 20, conTeachingPlan.UpdUserId);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.Memo, 1000, conTeachingPlan.Memo);
//检查字段外键固定长度
 objTeachingPlanEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTeachingPlanEN objTeachingPlanEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachingPlanEN.SubjectName, 200, conTeachingPlan.SubjectName);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingPlanAuthor, 50, conTeachingPlan.TeachingPlanAuthor);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingObject, 5000, conTeachingPlan.TeachingObject);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingEmphases, 5000, conTeachingPlan.TeachingEmphases);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingDifficulty, 5000, conTeachingPlan.TeachingDifficulty);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingTool, 5000, conTeachingPlan.TeachingTool);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingProcess, 8000, conTeachingPlan.TeachingProcess);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingPlanType, 1, conTeachingPlan.TeachingPlanType);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingPlanInDate, 8, conTeachingPlan.TeachingPlanInDate);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingPlanInTime, 6, conTeachingPlan.TeachingPlanInTime);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.UpdDate, 20, conTeachingPlan.UpdDate);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.UpdUserId, 20, conTeachingPlan.UpdUserId);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.Memo, 1000, conTeachingPlan.Memo);
//检查外键字段长度
 objTeachingPlanEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTeachingPlanEN objTeachingPlanEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachingPlanEN.IdTeachingPlan, 8, conTeachingPlan.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.SubjectName, 200, conTeachingPlan.SubjectName);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingPlanAuthor, 50, conTeachingPlan.TeachingPlanAuthor);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingObject, 5000, conTeachingPlan.TeachingObject);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingEmphases, 5000, conTeachingPlan.TeachingEmphases);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingDifficulty, 5000, conTeachingPlan.TeachingDifficulty);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingTool, 5000, conTeachingPlan.TeachingTool);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingProcess, 8000, conTeachingPlan.TeachingProcess);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingPlanType, 1, conTeachingPlan.TeachingPlanType);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingPlanInDate, 8, conTeachingPlan.TeachingPlanInDate);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.TeachingPlanInTime, 6, conTeachingPlan.TeachingPlanInTime);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.UpdDate, 20, conTeachingPlan.UpdDate);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.UpdUserId, 20, conTeachingPlan.UpdUserId);
clsCheckSql.CheckFieldLen(objTeachingPlanEN.Memo, 1000, conTeachingPlan.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTeachingPlanEN.IdTeachingPlan, conTeachingPlan.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objTeachingPlanEN.SubjectName, conTeachingPlan.SubjectName);
clsCheckSql.CheckSqlInjection4Field(objTeachingPlanEN.TeachingPlanAuthor, conTeachingPlan.TeachingPlanAuthor);
clsCheckSql.CheckSqlInjection4Field(objTeachingPlanEN.TeachingObject, conTeachingPlan.TeachingObject);
clsCheckSql.CheckSqlInjection4Field(objTeachingPlanEN.TeachingEmphases, conTeachingPlan.TeachingEmphases);
clsCheckSql.CheckSqlInjection4Field(objTeachingPlanEN.TeachingDifficulty, conTeachingPlan.TeachingDifficulty);
clsCheckSql.CheckSqlInjection4Field(objTeachingPlanEN.TeachingTool, conTeachingPlan.TeachingTool);
clsCheckSql.CheckSqlInjection4Field(objTeachingPlanEN.TeachingProcess, conTeachingPlan.TeachingProcess);
clsCheckSql.CheckSqlInjection4Field(objTeachingPlanEN.TeachingPlanType, conTeachingPlan.TeachingPlanType);
clsCheckSql.CheckSqlInjection4Field(objTeachingPlanEN.TeachingPlanInDate, conTeachingPlan.TeachingPlanInDate);
clsCheckSql.CheckSqlInjection4Field(objTeachingPlanEN.TeachingPlanInTime, conTeachingPlan.TeachingPlanInTime);
clsCheckSql.CheckSqlInjection4Field(objTeachingPlanEN.UpdDate, conTeachingPlan.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objTeachingPlanEN.UpdUserId, conTeachingPlan.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objTeachingPlanEN.Memo, conTeachingPlan.Memo);
//检查外键字段长度
 objTeachingPlanEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

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
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
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
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
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
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeachingPlanEN._CurrTabName);
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
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeachingPlanEN._CurrTabName, strCondition);
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
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
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
 objSQL = clsTeachingPlanDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}