
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsJxTeachingPlanDA
 表名:JxTeachingPlan(01120968)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:21
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教学执行计划管理(TeachingPlan)
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
 /// 教学计划(JxTeachingPlan)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsJxTeachingPlanDA : clsCommBase4DA
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
 return clsJxTeachingPlanEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsJxTeachingPlanEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsJxTeachingPlanEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsJxTeachingPlanEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsJxTeachingPlanEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:JxTeachingPlan中,检查关键字,长度不正确!(clsJxTeachingPlanDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdTeachingPlan)  ==  true)
{
throw new Exception("(errid:Data000002)在表:JxTeachingPlan中,关键字不能为空 或 null!(clsJxTeachingPlanDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeachingPlan);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsJxTeachingPlanDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsJxTeachingPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from JxTeachingPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_JxTeachingPlan(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsJxTeachingPlanDA: GetDataTable_JxTeachingPlan)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from JxTeachingPlan where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsJxTeachingPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsJxTeachingPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from JxTeachingPlan where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsJxTeachingPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsJxTeachingPlanDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from JxTeachingPlan where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from JxTeachingPlan where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsJxTeachingPlanDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from JxTeachingPlan where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsJxTeachingPlanDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} JxTeachingPlan.* from JxTeachingPlan Left Join {1} on {2} where {3} and JxTeachingPlan.IdTeachingPlan not in (Select top {5} JxTeachingPlan.IdTeachingPlan from JxTeachingPlan Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from JxTeachingPlan where {1} and IdTeachingPlan not in (Select top {2} IdTeachingPlan from JxTeachingPlan where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from JxTeachingPlan where {1} and IdTeachingPlan not in (Select top {3} IdTeachingPlan from JxTeachingPlan where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsJxTeachingPlanDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} JxTeachingPlan.* from JxTeachingPlan Left Join {1} on {2} where {3} and JxTeachingPlan.IdTeachingPlan not in (Select top {5} JxTeachingPlan.IdTeachingPlan from JxTeachingPlan Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from JxTeachingPlan where {1} and IdTeachingPlan not in (Select top {2} IdTeachingPlan from JxTeachingPlan where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from JxTeachingPlan where {1} and IdTeachingPlan not in (Select top {3} IdTeachingPlan from JxTeachingPlan where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsJxTeachingPlanEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsJxTeachingPlanDA:GetObjLst)", objException.Message));
}
List<clsJxTeachingPlanEN> arrObjLst = new List<clsJxTeachingPlanEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from JxTeachingPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJxTeachingPlanEN objJxTeachingPlanEN = new clsJxTeachingPlanEN();
try
{
objJxTeachingPlanEN.IdTeachingPlan = objRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objJxTeachingPlanEN.TeachingPlanId = objRow[conJxTeachingPlan.TeachingPlanId].ToString().Trim(); //教学计划编号
objJxTeachingPlanEN.TeachingPlanDesc = objRow[conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(); //教学计划名称
objJxTeachingPlanEN.IdGrade = objRow[conJxTeachingPlan.IdGrade].ToString().Trim(); //年级流水号
objJxTeachingPlanEN.SchoolTerm = objRow[conJxTeachingPlan.SchoolTerm].ToString().Trim(); //学期
objJxTeachingPlanEN.CourseId = objRow[conJxTeachingPlan.CourseId].ToString().Trim(); //课程Id
objJxTeachingPlanEN.IsClgCheck = TransNullToBool(objRow[conJxTeachingPlan.IsClgCheck].ToString().Trim()); //是否学院审批
objJxTeachingPlanEN.ClgNote = objRow[conJxTeachingPlan.ClgNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgNote].ToString().Trim(); //学院审批意见
objJxTeachingPlanEN.ClgCheckerId = objRow[conJxTeachingPlan.ClgCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckerId].ToString().Trim(); //学院审批人id
objJxTeachingPlanEN.ClgCheckDate = objRow[conJxTeachingPlan.ClgCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckDate].ToString().Trim(); //学院审批日期
objJxTeachingPlanEN.IsSchCheck = TransNullToBool(objRow[conJxTeachingPlan.IsSchCheck].ToString().Trim()); //是否学校审批
objJxTeachingPlanEN.SchNote = objRow[conJxTeachingPlan.SchNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchNote].ToString().Trim(); //学校审批意见
objJxTeachingPlanEN.SchCheckerId = objRow[conJxTeachingPlan.SchCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckerId].ToString().Trim(); //学校审批人Id
objJxTeachingPlanEN.SchCheckDate = objRow[conJxTeachingPlan.SchCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckDate].ToString().Trim(); //学校审批日期
objJxTeachingPlanEN.IdSubmitStatus = objRow[conJxTeachingPlan.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objJxTeachingPlanEN.Memo = objRow[conJxTeachingPlan.Memo] == DBNull.Value ? null : objRow[conJxTeachingPlan.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsJxTeachingPlanDA: GetObjLst)", objException.Message));
}
objJxTeachingPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objJxTeachingPlanEN);
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
public List<clsJxTeachingPlanEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsJxTeachingPlanDA:GetObjLstByTabName)", objException.Message));
}
List<clsJxTeachingPlanEN> arrObjLst = new List<clsJxTeachingPlanEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJxTeachingPlanEN objJxTeachingPlanEN = new clsJxTeachingPlanEN();
try
{
objJxTeachingPlanEN.IdTeachingPlan = objRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objJxTeachingPlanEN.TeachingPlanId = objRow[conJxTeachingPlan.TeachingPlanId].ToString().Trim(); //教学计划编号
objJxTeachingPlanEN.TeachingPlanDesc = objRow[conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(); //教学计划名称
objJxTeachingPlanEN.IdGrade = objRow[conJxTeachingPlan.IdGrade].ToString().Trim(); //年级流水号
objJxTeachingPlanEN.SchoolTerm = objRow[conJxTeachingPlan.SchoolTerm].ToString().Trim(); //学期
objJxTeachingPlanEN.CourseId = objRow[conJxTeachingPlan.CourseId].ToString().Trim(); //课程Id
objJxTeachingPlanEN.IsClgCheck = TransNullToBool(objRow[conJxTeachingPlan.IsClgCheck].ToString().Trim()); //是否学院审批
objJxTeachingPlanEN.ClgNote = objRow[conJxTeachingPlan.ClgNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgNote].ToString().Trim(); //学院审批意见
objJxTeachingPlanEN.ClgCheckerId = objRow[conJxTeachingPlan.ClgCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckerId].ToString().Trim(); //学院审批人id
objJxTeachingPlanEN.ClgCheckDate = objRow[conJxTeachingPlan.ClgCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckDate].ToString().Trim(); //学院审批日期
objJxTeachingPlanEN.IsSchCheck = TransNullToBool(objRow[conJxTeachingPlan.IsSchCheck].ToString().Trim()); //是否学校审批
objJxTeachingPlanEN.SchNote = objRow[conJxTeachingPlan.SchNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchNote].ToString().Trim(); //学校审批意见
objJxTeachingPlanEN.SchCheckerId = objRow[conJxTeachingPlan.SchCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckerId].ToString().Trim(); //学校审批人Id
objJxTeachingPlanEN.SchCheckDate = objRow[conJxTeachingPlan.SchCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckDate].ToString().Trim(); //学校审批日期
objJxTeachingPlanEN.IdSubmitStatus = objRow[conJxTeachingPlan.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objJxTeachingPlanEN.Memo = objRow[conJxTeachingPlan.Memo] == DBNull.Value ? null : objRow[conJxTeachingPlan.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsJxTeachingPlanDA: GetObjLst)", objException.Message));
}
objJxTeachingPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objJxTeachingPlanEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetJxTeachingPlan(ref clsJxTeachingPlanEN objJxTeachingPlanEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from JxTeachingPlan where IdTeachingPlan = " + "'"+ objJxTeachingPlanEN.IdTeachingPlan+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objJxTeachingPlanEN.IdTeachingPlan = objDT.Rows[0][conJxTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objJxTeachingPlanEN.TeachingPlanId = objDT.Rows[0][conJxTeachingPlan.TeachingPlanId].ToString().Trim(); //教学计划编号(字段类型:char,字段长度:12,是否可空:True)
 objJxTeachingPlanEN.TeachingPlanDesc = objDT.Rows[0][conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(); //教学计划名称(字段类型:varchar,字段长度:100,是否可空:True)
 objJxTeachingPlanEN.IdGrade = objDT.Rows[0][conJxTeachingPlan.IdGrade].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:False)
 objJxTeachingPlanEN.SchoolTerm = objDT.Rows[0][conJxTeachingPlan.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objJxTeachingPlanEN.CourseId = objDT.Rows[0][conJxTeachingPlan.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objJxTeachingPlanEN.IsClgCheck = TransNullToBool(objDT.Rows[0][conJxTeachingPlan.IsClgCheck].ToString().Trim()); //是否学院审批(字段类型:bit,字段长度:1,是否可空:True)
 objJxTeachingPlanEN.ClgNote = objDT.Rows[0][conJxTeachingPlan.ClgNote].ToString().Trim(); //学院审批意见(字段类型:text,字段长度:2147483647,是否可空:True)
 objJxTeachingPlanEN.ClgCheckerId = objDT.Rows[0][conJxTeachingPlan.ClgCheckerId].ToString().Trim(); //学院审批人id(字段类型:varchar,字段长度:18,是否可空:True)
 objJxTeachingPlanEN.ClgCheckDate = objDT.Rows[0][conJxTeachingPlan.ClgCheckDate].ToString().Trim(); //学院审批日期(字段类型:char,字段长度:8,是否可空:True)
 objJxTeachingPlanEN.IsSchCheck = TransNullToBool(objDT.Rows[0][conJxTeachingPlan.IsSchCheck].ToString().Trim()); //是否学校审批(字段类型:bit,字段长度:1,是否可空:True)
 objJxTeachingPlanEN.SchNote = objDT.Rows[0][conJxTeachingPlan.SchNote].ToString().Trim(); //学校审批意见(字段类型:text,字段长度:16,是否可空:True)
 objJxTeachingPlanEN.SchCheckerId = objDT.Rows[0][conJxTeachingPlan.SchCheckerId].ToString().Trim(); //学校审批人Id(字段类型:varchar,字段长度:18,是否可空:True)
 objJxTeachingPlanEN.SchCheckDate = objDT.Rows[0][conJxTeachingPlan.SchCheckDate].ToString().Trim(); //学校审批日期(字段类型:char,字段长度:8,是否可空:True)
 objJxTeachingPlanEN.IdSubmitStatus = objDT.Rows[0][conJxTeachingPlan.IdSubmitStatus].ToString().Trim(); //送审状态流水号(字段类型:char,字段长度:2,是否可空:False)
 objJxTeachingPlanEN.Memo = objDT.Rows[0][conJxTeachingPlan.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsJxTeachingPlanDA: GetJxTeachingPlan)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdTeachingPlan">表关键字</param>
 /// <returns>表对象</returns>
public clsJxTeachingPlanEN GetObjByIdTeachingPlan(string strIdTeachingPlan)
{
CheckPrimaryKey(strIdTeachingPlan);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from JxTeachingPlan where IdTeachingPlan = " + "'"+ strIdTeachingPlan+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsJxTeachingPlanEN objJxTeachingPlanEN = new clsJxTeachingPlanEN();
try
{
 objJxTeachingPlanEN.IdTeachingPlan = objRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objJxTeachingPlanEN.TeachingPlanId = objRow[conJxTeachingPlan.TeachingPlanId].ToString().Trim(); //教学计划编号(字段类型:char,字段长度:12,是否可空:True)
 objJxTeachingPlanEN.TeachingPlanDesc = objRow[conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(); //教学计划名称(字段类型:varchar,字段长度:100,是否可空:True)
 objJxTeachingPlanEN.IdGrade = objRow[conJxTeachingPlan.IdGrade].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:False)
 objJxTeachingPlanEN.SchoolTerm = objRow[conJxTeachingPlan.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objJxTeachingPlanEN.CourseId = objRow[conJxTeachingPlan.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objJxTeachingPlanEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsClgCheck].ToString().Trim()); //是否学院审批(字段类型:bit,字段长度:1,是否可空:True)
 objJxTeachingPlanEN.ClgNote = objRow[conJxTeachingPlan.ClgNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgNote].ToString().Trim(); //学院审批意见(字段类型:text,字段长度:2147483647,是否可空:True)
 objJxTeachingPlanEN.ClgCheckerId = objRow[conJxTeachingPlan.ClgCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckerId].ToString().Trim(); //学院审批人id(字段类型:varchar,字段长度:18,是否可空:True)
 objJxTeachingPlanEN.ClgCheckDate = objRow[conJxTeachingPlan.ClgCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckDate].ToString().Trim(); //学院审批日期(字段类型:char,字段长度:8,是否可空:True)
 objJxTeachingPlanEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conJxTeachingPlan.IsSchCheck].ToString().Trim()); //是否学校审批(字段类型:bit,字段长度:1,是否可空:True)
 objJxTeachingPlanEN.SchNote = objRow[conJxTeachingPlan.SchNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchNote].ToString().Trim(); //学校审批意见(字段类型:text,字段长度:16,是否可空:True)
 objJxTeachingPlanEN.SchCheckerId = objRow[conJxTeachingPlan.SchCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckerId].ToString().Trim(); //学校审批人Id(字段类型:varchar,字段长度:18,是否可空:True)
 objJxTeachingPlanEN.SchCheckDate = objRow[conJxTeachingPlan.SchCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckDate].ToString().Trim(); //学校审批日期(字段类型:char,字段长度:8,是否可空:True)
 objJxTeachingPlanEN.IdSubmitStatus = objRow[conJxTeachingPlan.IdSubmitStatus].ToString().Trim(); //送审状态流水号(字段类型:char,字段长度:2,是否可空:False)
 objJxTeachingPlanEN.Memo = objRow[conJxTeachingPlan.Memo] == DBNull.Value ? null : objRow[conJxTeachingPlan.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsJxTeachingPlanDA: GetObjByIdTeachingPlan)", objException.Message));
}
return objJxTeachingPlanEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsJxTeachingPlanEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsJxTeachingPlanDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from JxTeachingPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsJxTeachingPlanEN objJxTeachingPlanEN = new clsJxTeachingPlanEN()
{
IdTeachingPlan = objRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim(), //教案流水号
TeachingPlanId = objRow[conJxTeachingPlan.TeachingPlanId].ToString().Trim(), //教学计划编号
TeachingPlanDesc = objRow[conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(), //教学计划名称
IdGrade = objRow[conJxTeachingPlan.IdGrade].ToString().Trim(), //年级流水号
SchoolTerm = objRow[conJxTeachingPlan.SchoolTerm].ToString().Trim(), //学期
CourseId = objRow[conJxTeachingPlan.CourseId].ToString().Trim(), //课程Id
IsClgCheck = TransNullToBool(objRow[conJxTeachingPlan.IsClgCheck].ToString().Trim()), //是否学院审批
ClgNote = objRow[conJxTeachingPlan.ClgNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgNote].ToString().Trim(), //学院审批意见
ClgCheckerId = objRow[conJxTeachingPlan.ClgCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckerId].ToString().Trim(), //学院审批人id
ClgCheckDate = objRow[conJxTeachingPlan.ClgCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckDate].ToString().Trim(), //学院审批日期
IsSchCheck = TransNullToBool(objRow[conJxTeachingPlan.IsSchCheck].ToString().Trim()), //是否学校审批
SchNote = objRow[conJxTeachingPlan.SchNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchNote].ToString().Trim(), //学校审批意见
SchCheckerId = objRow[conJxTeachingPlan.SchCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckerId].ToString().Trim(), //学校审批人Id
SchCheckDate = objRow[conJxTeachingPlan.SchCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckDate].ToString().Trim(), //学校审批日期
IdSubmitStatus = objRow[conJxTeachingPlan.IdSubmitStatus].ToString().Trim(), //送审状态流水号
Memo = objRow[conJxTeachingPlan.Memo] == DBNull.Value ? null : objRow[conJxTeachingPlan.Memo].ToString().Trim() //备注
};
objJxTeachingPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objJxTeachingPlanEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsJxTeachingPlanDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsJxTeachingPlanEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsJxTeachingPlanEN objJxTeachingPlanEN = new clsJxTeachingPlanEN();
try
{
objJxTeachingPlanEN.IdTeachingPlan = objRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objJxTeachingPlanEN.TeachingPlanId = objRow[conJxTeachingPlan.TeachingPlanId].ToString().Trim(); //教学计划编号
objJxTeachingPlanEN.TeachingPlanDesc = objRow[conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(); //教学计划名称
objJxTeachingPlanEN.IdGrade = objRow[conJxTeachingPlan.IdGrade].ToString().Trim(); //年级流水号
objJxTeachingPlanEN.SchoolTerm = objRow[conJxTeachingPlan.SchoolTerm].ToString().Trim(); //学期
objJxTeachingPlanEN.CourseId = objRow[conJxTeachingPlan.CourseId].ToString().Trim(); //课程Id
objJxTeachingPlanEN.IsClgCheck = TransNullToBool(objRow[conJxTeachingPlan.IsClgCheck].ToString().Trim()); //是否学院审批
objJxTeachingPlanEN.ClgNote = objRow[conJxTeachingPlan.ClgNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgNote].ToString().Trim(); //学院审批意见
objJxTeachingPlanEN.ClgCheckerId = objRow[conJxTeachingPlan.ClgCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckerId].ToString().Trim(); //学院审批人id
objJxTeachingPlanEN.ClgCheckDate = objRow[conJxTeachingPlan.ClgCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckDate].ToString().Trim(); //学院审批日期
objJxTeachingPlanEN.IsSchCheck = TransNullToBool(objRow[conJxTeachingPlan.IsSchCheck].ToString().Trim()); //是否学校审批
objJxTeachingPlanEN.SchNote = objRow[conJxTeachingPlan.SchNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchNote].ToString().Trim(); //学校审批意见
objJxTeachingPlanEN.SchCheckerId = objRow[conJxTeachingPlan.SchCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckerId].ToString().Trim(); //学校审批人Id
objJxTeachingPlanEN.SchCheckDate = objRow[conJxTeachingPlan.SchCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckDate].ToString().Trim(); //学校审批日期
objJxTeachingPlanEN.IdSubmitStatus = objRow[conJxTeachingPlan.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objJxTeachingPlanEN.Memo = objRow[conJxTeachingPlan.Memo] == DBNull.Value ? null : objRow[conJxTeachingPlan.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsJxTeachingPlanDA: GetObjByDataRowJxTeachingPlan)", objException.Message));
}
objJxTeachingPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objJxTeachingPlanEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsJxTeachingPlanEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsJxTeachingPlanEN objJxTeachingPlanEN = new clsJxTeachingPlanEN();
try
{
objJxTeachingPlanEN.IdTeachingPlan = objRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objJxTeachingPlanEN.TeachingPlanId = objRow[conJxTeachingPlan.TeachingPlanId].ToString().Trim(); //教学计划编号
objJxTeachingPlanEN.TeachingPlanDesc = objRow[conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(); //教学计划名称
objJxTeachingPlanEN.IdGrade = objRow[conJxTeachingPlan.IdGrade].ToString().Trim(); //年级流水号
objJxTeachingPlanEN.SchoolTerm = objRow[conJxTeachingPlan.SchoolTerm].ToString().Trim(); //学期
objJxTeachingPlanEN.CourseId = objRow[conJxTeachingPlan.CourseId].ToString().Trim(); //课程Id
objJxTeachingPlanEN.IsClgCheck = TransNullToBool(objRow[conJxTeachingPlan.IsClgCheck].ToString().Trim()); //是否学院审批
objJxTeachingPlanEN.ClgNote = objRow[conJxTeachingPlan.ClgNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgNote].ToString().Trim(); //学院审批意见
objJxTeachingPlanEN.ClgCheckerId = objRow[conJxTeachingPlan.ClgCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckerId].ToString().Trim(); //学院审批人id
objJxTeachingPlanEN.ClgCheckDate = objRow[conJxTeachingPlan.ClgCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.ClgCheckDate].ToString().Trim(); //学院审批日期
objJxTeachingPlanEN.IsSchCheck = TransNullToBool(objRow[conJxTeachingPlan.IsSchCheck].ToString().Trim()); //是否学校审批
objJxTeachingPlanEN.SchNote = objRow[conJxTeachingPlan.SchNote] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchNote].ToString().Trim(); //学校审批意见
objJxTeachingPlanEN.SchCheckerId = objRow[conJxTeachingPlan.SchCheckerId] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckerId].ToString().Trim(); //学校审批人Id
objJxTeachingPlanEN.SchCheckDate = objRow[conJxTeachingPlan.SchCheckDate] == DBNull.Value ? null : objRow[conJxTeachingPlan.SchCheckDate].ToString().Trim(); //学校审批日期
objJxTeachingPlanEN.IdSubmitStatus = objRow[conJxTeachingPlan.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objJxTeachingPlanEN.Memo = objRow[conJxTeachingPlan.Memo] == DBNull.Value ? null : objRow[conJxTeachingPlan.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsJxTeachingPlanDA: GetObjByDataRow)", objException.Message));
}
objJxTeachingPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objJxTeachingPlanEN;
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
objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsJxTeachingPlanEN._CurrTabName, conJxTeachingPlan.IdTeachingPlan, 8, "");
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
objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsJxTeachingPlanEN._CurrTabName, conJxTeachingPlan.IdTeachingPlan, 8, strPrefix);
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
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdTeachingPlan from JxTeachingPlan where " + strCondition;
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
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdTeachingPlan from JxTeachingPlan where " + strCondition;
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
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("JxTeachingPlan", "IdTeachingPlan = " + "'"+ strIdTeachingPlan+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsJxTeachingPlanDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("JxTeachingPlan", strCondition))
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
objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("JxTeachingPlan");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsJxTeachingPlanEN objJxTeachingPlanEN)
 {
 if (objJxTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objJxTeachingPlanEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from JxTeachingPlan where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "JxTeachingPlan");
objRow = objDS.Tables["JxTeachingPlan"].NewRow();
objRow[conJxTeachingPlan.IdTeachingPlan] = objJxTeachingPlanEN.IdTeachingPlan; //教案流水号
objRow[conJxTeachingPlan.TeachingPlanId] = objJxTeachingPlanEN.TeachingPlanId; //教学计划编号
objRow[conJxTeachingPlan.TeachingPlanDesc] = objJxTeachingPlanEN.TeachingPlanDesc; //教学计划名称
objRow[conJxTeachingPlan.IdGrade] = objJxTeachingPlanEN.IdGrade; //年级流水号
objRow[conJxTeachingPlan.SchoolTerm] = objJxTeachingPlanEN.SchoolTerm; //学期
objRow[conJxTeachingPlan.CourseId] = objJxTeachingPlanEN.CourseId; //课程Id
objRow[conJxTeachingPlan.IsClgCheck] = objJxTeachingPlanEN.IsClgCheck; //是否学院审批
 if (objJxTeachingPlanEN.ClgNote !=  "")
 {
objRow[conJxTeachingPlan.ClgNote] = objJxTeachingPlanEN.ClgNote; //学院审批意见
 }
 if (objJxTeachingPlanEN.ClgCheckerId !=  "")
 {
objRow[conJxTeachingPlan.ClgCheckerId] = objJxTeachingPlanEN.ClgCheckerId; //学院审批人id
 }
 if (objJxTeachingPlanEN.ClgCheckDate !=  "")
 {
objRow[conJxTeachingPlan.ClgCheckDate] = objJxTeachingPlanEN.ClgCheckDate; //学院审批日期
 }
objRow[conJxTeachingPlan.IsSchCheck] = objJxTeachingPlanEN.IsSchCheck; //是否学校审批
 if (objJxTeachingPlanEN.SchNote !=  "")
 {
objRow[conJxTeachingPlan.SchNote] = objJxTeachingPlanEN.SchNote; //学校审批意见
 }
 if (objJxTeachingPlanEN.SchCheckerId !=  "")
 {
objRow[conJxTeachingPlan.SchCheckerId] = objJxTeachingPlanEN.SchCheckerId; //学校审批人Id
 }
 if (objJxTeachingPlanEN.SchCheckDate !=  "")
 {
objRow[conJxTeachingPlan.SchCheckDate] = objJxTeachingPlanEN.SchCheckDate; //学校审批日期
 }
objRow[conJxTeachingPlan.IdSubmitStatus] = objJxTeachingPlanEN.IdSubmitStatus; //送审状态流水号
 if (objJxTeachingPlanEN.Memo !=  "")
 {
objRow[conJxTeachingPlan.Memo] = objJxTeachingPlanEN.Memo; //备注
 }
objDS.Tables[clsJxTeachingPlanEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsJxTeachingPlanEN._CurrTabName);
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
 /// <param name = "objJxTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsJxTeachingPlanEN objJxTeachingPlanEN)
{
 if (objJxTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objJxTeachingPlanEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objJxTeachingPlanEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.IdTeachingPlan);
 var strIdTeachingPlan = objJxTeachingPlanEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objJxTeachingPlanEN.TeachingPlanId !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.TeachingPlanId);
 var strTeachingPlanId = objJxTeachingPlanEN.TeachingPlanId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanId + "'");
 }
 
 if (objJxTeachingPlanEN.TeachingPlanDesc !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.TeachingPlanDesc);
 var strTeachingPlanDesc = objJxTeachingPlanEN.TeachingPlanDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanDesc + "'");
 }
 
 if (objJxTeachingPlanEN.IdGrade !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.IdGrade);
 var strIdGrade = objJxTeachingPlanEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGrade + "'");
 }
 
 if (objJxTeachingPlanEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.SchoolTerm);
 var strSchoolTerm = objJxTeachingPlanEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objJxTeachingPlanEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.CourseId);
 var strCourseId = objJxTeachingPlanEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(conJxTeachingPlan.IsClgCheck);
 arrValueListForInsert.Add("'" + (objJxTeachingPlanEN.IsClgCheck  ==  false ? "0" : "1") + "'");
 
 if (objJxTeachingPlanEN.ClgNote !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.ClgNote);
 var strClgNote = objJxTeachingPlanEN.ClgNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgNote + "'");
 }
 
 if (objJxTeachingPlanEN.ClgCheckerId !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.ClgCheckerId);
 var strClgCheckerId = objJxTeachingPlanEN.ClgCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgCheckerId + "'");
 }
 
 if (objJxTeachingPlanEN.ClgCheckDate !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.ClgCheckDate);
 var strClgCheckDate = objJxTeachingPlanEN.ClgCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgCheckDate + "'");
 }
 
 arrFieldListForInsert.Add(conJxTeachingPlan.IsSchCheck);
 arrValueListForInsert.Add("'" + (objJxTeachingPlanEN.IsSchCheck  ==  false ? "0" : "1") + "'");
 
 if (objJxTeachingPlanEN.SchNote !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.SchNote);
 var strSchNote = objJxTeachingPlanEN.SchNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchNote + "'");
 }
 
 if (objJxTeachingPlanEN.SchCheckerId !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.SchCheckerId);
 var strSchCheckerId = objJxTeachingPlanEN.SchCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchCheckerId + "'");
 }
 
 if (objJxTeachingPlanEN.SchCheckDate !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.SchCheckDate);
 var strSchCheckDate = objJxTeachingPlanEN.SchCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchCheckDate + "'");
 }
 
 if (objJxTeachingPlanEN.IdSubmitStatus  ==  "")
 {
 objJxTeachingPlanEN.IdSubmitStatus = null;
 }
 if (objJxTeachingPlanEN.IdSubmitStatus !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.IdSubmitStatus);
 var strIdSubmitStatus = objJxTeachingPlanEN.IdSubmitStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSubmitStatus + "'");
 }
 
 if (objJxTeachingPlanEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.Memo);
 var strMemo = objJxTeachingPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into JxTeachingPlan");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsJxTeachingPlanEN objJxTeachingPlanEN)
{
 if (objJxTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objJxTeachingPlanEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objJxTeachingPlanEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.IdTeachingPlan);
 var strIdTeachingPlan = objJxTeachingPlanEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objJxTeachingPlanEN.TeachingPlanId !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.TeachingPlanId);
 var strTeachingPlanId = objJxTeachingPlanEN.TeachingPlanId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanId + "'");
 }
 
 if (objJxTeachingPlanEN.TeachingPlanDesc !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.TeachingPlanDesc);
 var strTeachingPlanDesc = objJxTeachingPlanEN.TeachingPlanDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanDesc + "'");
 }
 
 if (objJxTeachingPlanEN.IdGrade !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.IdGrade);
 var strIdGrade = objJxTeachingPlanEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGrade + "'");
 }
 
 if (objJxTeachingPlanEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.SchoolTerm);
 var strSchoolTerm = objJxTeachingPlanEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objJxTeachingPlanEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.CourseId);
 var strCourseId = objJxTeachingPlanEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(conJxTeachingPlan.IsClgCheck);
 arrValueListForInsert.Add("'" + (objJxTeachingPlanEN.IsClgCheck  ==  false ? "0" : "1") + "'");
 
 if (objJxTeachingPlanEN.ClgNote !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.ClgNote);
 var strClgNote = objJxTeachingPlanEN.ClgNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgNote + "'");
 }
 
 if (objJxTeachingPlanEN.ClgCheckerId !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.ClgCheckerId);
 var strClgCheckerId = objJxTeachingPlanEN.ClgCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgCheckerId + "'");
 }
 
 if (objJxTeachingPlanEN.ClgCheckDate !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.ClgCheckDate);
 var strClgCheckDate = objJxTeachingPlanEN.ClgCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgCheckDate + "'");
 }
 
 arrFieldListForInsert.Add(conJxTeachingPlan.IsSchCheck);
 arrValueListForInsert.Add("'" + (objJxTeachingPlanEN.IsSchCheck  ==  false ? "0" : "1") + "'");
 
 if (objJxTeachingPlanEN.SchNote !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.SchNote);
 var strSchNote = objJxTeachingPlanEN.SchNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchNote + "'");
 }
 
 if (objJxTeachingPlanEN.SchCheckerId !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.SchCheckerId);
 var strSchCheckerId = objJxTeachingPlanEN.SchCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchCheckerId + "'");
 }
 
 if (objJxTeachingPlanEN.SchCheckDate !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.SchCheckDate);
 var strSchCheckDate = objJxTeachingPlanEN.SchCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchCheckDate + "'");
 }
 
 if (objJxTeachingPlanEN.IdSubmitStatus  ==  "")
 {
 objJxTeachingPlanEN.IdSubmitStatus = null;
 }
 if (objJxTeachingPlanEN.IdSubmitStatus !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.IdSubmitStatus);
 var strIdSubmitStatus = objJxTeachingPlanEN.IdSubmitStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSubmitStatus + "'");
 }
 
 if (objJxTeachingPlanEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.Memo);
 var strMemo = objJxTeachingPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into JxTeachingPlan");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objJxTeachingPlanEN.IdTeachingPlan;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsJxTeachingPlanEN objJxTeachingPlanEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objJxTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objJxTeachingPlanEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objJxTeachingPlanEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.IdTeachingPlan);
 var strIdTeachingPlan = objJxTeachingPlanEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objJxTeachingPlanEN.TeachingPlanId !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.TeachingPlanId);
 var strTeachingPlanId = objJxTeachingPlanEN.TeachingPlanId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanId + "'");
 }
 
 if (objJxTeachingPlanEN.TeachingPlanDesc !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.TeachingPlanDesc);
 var strTeachingPlanDesc = objJxTeachingPlanEN.TeachingPlanDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanDesc + "'");
 }
 
 if (objJxTeachingPlanEN.IdGrade !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.IdGrade);
 var strIdGrade = objJxTeachingPlanEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGrade + "'");
 }
 
 if (objJxTeachingPlanEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.SchoolTerm);
 var strSchoolTerm = objJxTeachingPlanEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objJxTeachingPlanEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.CourseId);
 var strCourseId = objJxTeachingPlanEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(conJxTeachingPlan.IsClgCheck);
 arrValueListForInsert.Add("'" + (objJxTeachingPlanEN.IsClgCheck  ==  false ? "0" : "1") + "'");
 
 if (objJxTeachingPlanEN.ClgNote !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.ClgNote);
 var strClgNote = objJxTeachingPlanEN.ClgNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgNote + "'");
 }
 
 if (objJxTeachingPlanEN.ClgCheckerId !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.ClgCheckerId);
 var strClgCheckerId = objJxTeachingPlanEN.ClgCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgCheckerId + "'");
 }
 
 if (objJxTeachingPlanEN.ClgCheckDate !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.ClgCheckDate);
 var strClgCheckDate = objJxTeachingPlanEN.ClgCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgCheckDate + "'");
 }
 
 arrFieldListForInsert.Add(conJxTeachingPlan.IsSchCheck);
 arrValueListForInsert.Add("'" + (objJxTeachingPlanEN.IsSchCheck  ==  false ? "0" : "1") + "'");
 
 if (objJxTeachingPlanEN.SchNote !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.SchNote);
 var strSchNote = objJxTeachingPlanEN.SchNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchNote + "'");
 }
 
 if (objJxTeachingPlanEN.SchCheckerId !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.SchCheckerId);
 var strSchCheckerId = objJxTeachingPlanEN.SchCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchCheckerId + "'");
 }
 
 if (objJxTeachingPlanEN.SchCheckDate !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.SchCheckDate);
 var strSchCheckDate = objJxTeachingPlanEN.SchCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchCheckDate + "'");
 }
 
 if (objJxTeachingPlanEN.IdSubmitStatus  ==  "")
 {
 objJxTeachingPlanEN.IdSubmitStatus = null;
 }
 if (objJxTeachingPlanEN.IdSubmitStatus !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.IdSubmitStatus);
 var strIdSubmitStatus = objJxTeachingPlanEN.IdSubmitStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSubmitStatus + "'");
 }
 
 if (objJxTeachingPlanEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.Memo);
 var strMemo = objJxTeachingPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into JxTeachingPlan");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objJxTeachingPlanEN.IdTeachingPlan;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsJxTeachingPlanEN objJxTeachingPlanEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objJxTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objJxTeachingPlanEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objJxTeachingPlanEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.IdTeachingPlan);
 var strIdTeachingPlan = objJxTeachingPlanEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objJxTeachingPlanEN.TeachingPlanId !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.TeachingPlanId);
 var strTeachingPlanId = objJxTeachingPlanEN.TeachingPlanId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanId + "'");
 }
 
 if (objJxTeachingPlanEN.TeachingPlanDesc !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.TeachingPlanDesc);
 var strTeachingPlanDesc = objJxTeachingPlanEN.TeachingPlanDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingPlanDesc + "'");
 }
 
 if (objJxTeachingPlanEN.IdGrade !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.IdGrade);
 var strIdGrade = objJxTeachingPlanEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGrade + "'");
 }
 
 if (objJxTeachingPlanEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.SchoolTerm);
 var strSchoolTerm = objJxTeachingPlanEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objJxTeachingPlanEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.CourseId);
 var strCourseId = objJxTeachingPlanEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(conJxTeachingPlan.IsClgCheck);
 arrValueListForInsert.Add("'" + (objJxTeachingPlanEN.IsClgCheck  ==  false ? "0" : "1") + "'");
 
 if (objJxTeachingPlanEN.ClgNote !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.ClgNote);
 var strClgNote = objJxTeachingPlanEN.ClgNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgNote + "'");
 }
 
 if (objJxTeachingPlanEN.ClgCheckerId !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.ClgCheckerId);
 var strClgCheckerId = objJxTeachingPlanEN.ClgCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgCheckerId + "'");
 }
 
 if (objJxTeachingPlanEN.ClgCheckDate !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.ClgCheckDate);
 var strClgCheckDate = objJxTeachingPlanEN.ClgCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClgCheckDate + "'");
 }
 
 arrFieldListForInsert.Add(conJxTeachingPlan.IsSchCheck);
 arrValueListForInsert.Add("'" + (objJxTeachingPlanEN.IsSchCheck  ==  false ? "0" : "1") + "'");
 
 if (objJxTeachingPlanEN.SchNote !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.SchNote);
 var strSchNote = objJxTeachingPlanEN.SchNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchNote + "'");
 }
 
 if (objJxTeachingPlanEN.SchCheckerId !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.SchCheckerId);
 var strSchCheckerId = objJxTeachingPlanEN.SchCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchCheckerId + "'");
 }
 
 if (objJxTeachingPlanEN.SchCheckDate !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.SchCheckDate);
 var strSchCheckDate = objJxTeachingPlanEN.SchCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchCheckDate + "'");
 }
 
 if (objJxTeachingPlanEN.IdSubmitStatus  ==  "")
 {
 objJxTeachingPlanEN.IdSubmitStatus = null;
 }
 if (objJxTeachingPlanEN.IdSubmitStatus !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.IdSubmitStatus);
 var strIdSubmitStatus = objJxTeachingPlanEN.IdSubmitStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSubmitStatus + "'");
 }
 
 if (objJxTeachingPlanEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conJxTeachingPlan.Memo);
 var strMemo = objJxTeachingPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into JxTeachingPlan");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewJxTeachingPlans(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from JxTeachingPlan where IdTeachingPlan = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "JxTeachingPlan");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdTeachingPlan = oRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim();
if (IsExist(strIdTeachingPlan))
{
 string strResult = "关键字变量值为:" + string.Format("IdTeachingPlan = {0}", strIdTeachingPlan) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsJxTeachingPlanEN._CurrTabName ].NewRow();
objRow[conJxTeachingPlan.IdTeachingPlan] = oRow[conJxTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objRow[conJxTeachingPlan.TeachingPlanId] = oRow[conJxTeachingPlan.TeachingPlanId].ToString().Trim(); //教学计划编号
objRow[conJxTeachingPlan.TeachingPlanDesc] = oRow[conJxTeachingPlan.TeachingPlanDesc].ToString().Trim(); //教学计划名称
objRow[conJxTeachingPlan.IdGrade] = oRow[conJxTeachingPlan.IdGrade].ToString().Trim(); //年级流水号
objRow[conJxTeachingPlan.SchoolTerm] = oRow[conJxTeachingPlan.SchoolTerm].ToString().Trim(); //学期
objRow[conJxTeachingPlan.CourseId] = oRow[conJxTeachingPlan.CourseId].ToString().Trim(); //课程Id
objRow[conJxTeachingPlan.IsClgCheck] = oRow[conJxTeachingPlan.IsClgCheck].ToString().Trim(); //是否学院审批
objRow[conJxTeachingPlan.ClgNote] = oRow[conJxTeachingPlan.ClgNote].ToString().Trim(); //学院审批意见
objRow[conJxTeachingPlan.ClgCheckerId] = oRow[conJxTeachingPlan.ClgCheckerId].ToString().Trim(); //学院审批人id
objRow[conJxTeachingPlan.ClgCheckDate] = oRow[conJxTeachingPlan.ClgCheckDate].ToString().Trim(); //学院审批日期
objRow[conJxTeachingPlan.IsSchCheck] = oRow[conJxTeachingPlan.IsSchCheck].ToString().Trim(); //是否学校审批
objRow[conJxTeachingPlan.SchNote] = oRow[conJxTeachingPlan.SchNote].ToString().Trim(); //学校审批意见
objRow[conJxTeachingPlan.SchCheckerId] = oRow[conJxTeachingPlan.SchCheckerId].ToString().Trim(); //学校审批人Id
objRow[conJxTeachingPlan.SchCheckDate] = oRow[conJxTeachingPlan.SchCheckDate].ToString().Trim(); //学校审批日期
objRow[conJxTeachingPlan.IdSubmitStatus] = oRow[conJxTeachingPlan.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objRow[conJxTeachingPlan.Memo] = oRow[conJxTeachingPlan.Memo].ToString().Trim(); //备注
 objDS.Tables[clsJxTeachingPlanEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsJxTeachingPlanEN._CurrTabName);
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
 /// <param name = "objJxTeachingPlanEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsJxTeachingPlanEN objJxTeachingPlanEN)
{
 if (objJxTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objJxTeachingPlanEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from JxTeachingPlan where IdTeachingPlan = " + "'"+ objJxTeachingPlanEN.IdTeachingPlan+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsJxTeachingPlanEN._CurrTabName);
if (objDS.Tables[clsJxTeachingPlanEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdTeachingPlan = " + "'"+ objJxTeachingPlanEN.IdTeachingPlan+"'");
return false;
}
objRow = objDS.Tables[clsJxTeachingPlanEN._CurrTabName].Rows[0];
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IdTeachingPlan))
 {
objRow[conJxTeachingPlan.IdTeachingPlan] = objJxTeachingPlanEN.IdTeachingPlan; //教案流水号
 }
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.TeachingPlanId))
 {
objRow[conJxTeachingPlan.TeachingPlanId] = objJxTeachingPlanEN.TeachingPlanId; //教学计划编号
 }
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.TeachingPlanDesc))
 {
objRow[conJxTeachingPlan.TeachingPlanDesc] = objJxTeachingPlanEN.TeachingPlanDesc; //教学计划名称
 }
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IdGrade))
 {
objRow[conJxTeachingPlan.IdGrade] = objJxTeachingPlanEN.IdGrade; //年级流水号
 }
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchoolTerm))
 {
objRow[conJxTeachingPlan.SchoolTerm] = objJxTeachingPlanEN.SchoolTerm; //学期
 }
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.CourseId))
 {
objRow[conJxTeachingPlan.CourseId] = objJxTeachingPlanEN.CourseId; //课程Id
 }
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IsClgCheck))
 {
objRow[conJxTeachingPlan.IsClgCheck] = objJxTeachingPlanEN.IsClgCheck; //是否学院审批
 }
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.ClgNote))
 {
objRow[conJxTeachingPlan.ClgNote] = objJxTeachingPlanEN.ClgNote; //学院审批意见
 }
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.ClgCheckerId))
 {
objRow[conJxTeachingPlan.ClgCheckerId] = objJxTeachingPlanEN.ClgCheckerId; //学院审批人id
 }
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.ClgCheckDate))
 {
objRow[conJxTeachingPlan.ClgCheckDate] = objJxTeachingPlanEN.ClgCheckDate; //学院审批日期
 }
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IsSchCheck))
 {
objRow[conJxTeachingPlan.IsSchCheck] = objJxTeachingPlanEN.IsSchCheck; //是否学校审批
 }
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchNote))
 {
objRow[conJxTeachingPlan.SchNote] = objJxTeachingPlanEN.SchNote; //学校审批意见
 }
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchCheckerId))
 {
objRow[conJxTeachingPlan.SchCheckerId] = objJxTeachingPlanEN.SchCheckerId; //学校审批人Id
 }
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchCheckDate))
 {
objRow[conJxTeachingPlan.SchCheckDate] = objJxTeachingPlanEN.SchCheckDate; //学校审批日期
 }
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IdSubmitStatus))
 {
objRow[conJxTeachingPlan.IdSubmitStatus] = objJxTeachingPlanEN.IdSubmitStatus; //送审状态流水号
 }
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.Memo))
 {
objRow[conJxTeachingPlan.Memo] = objJxTeachingPlanEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsJxTeachingPlanEN._CurrTabName);
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
 /// <param name = "objJxTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsJxTeachingPlanEN objJxTeachingPlanEN)
{
 if (objJxTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objJxTeachingPlanEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update JxTeachingPlan Set ");
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.TeachingPlanId))
 {
 if (objJxTeachingPlanEN.TeachingPlanId !=  null)
 {
 var strTeachingPlanId = objJxTeachingPlanEN.TeachingPlanId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingPlanId, conJxTeachingPlan.TeachingPlanId); //教学计划编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.TeachingPlanId); //教学计划编号
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.TeachingPlanDesc))
 {
 if (objJxTeachingPlanEN.TeachingPlanDesc !=  null)
 {
 var strTeachingPlanDesc = objJxTeachingPlanEN.TeachingPlanDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingPlanDesc, conJxTeachingPlan.TeachingPlanDesc); //教学计划名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.TeachingPlanDesc); //教学计划名称
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IdGrade))
 {
 if (objJxTeachingPlanEN.IdGrade !=  null)
 {
 var strIdGrade = objJxTeachingPlanEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGrade, conJxTeachingPlan.IdGrade); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.IdGrade); //年级流水号
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchoolTerm))
 {
 if (objJxTeachingPlanEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objJxTeachingPlanEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conJxTeachingPlan.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.SchoolTerm); //学期
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.CourseId))
 {
 if (objJxTeachingPlanEN.CourseId !=  null)
 {
 var strCourseId = objJxTeachingPlanEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conJxTeachingPlan.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.CourseId); //课程Id
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IsClgCheck))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objJxTeachingPlanEN.IsClgCheck == true?"1":"0", conJxTeachingPlan.IsClgCheck); //是否学院审批
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.ClgNote))
 {
 if (objJxTeachingPlanEN.ClgNote !=  null)
 {
 var strClgNote = objJxTeachingPlanEN.ClgNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClgNote, conJxTeachingPlan.ClgNote); //学院审批意见
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.ClgNote); //学院审批意见
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.ClgCheckerId))
 {
 if (objJxTeachingPlanEN.ClgCheckerId !=  null)
 {
 var strClgCheckerId = objJxTeachingPlanEN.ClgCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClgCheckerId, conJxTeachingPlan.ClgCheckerId); //学院审批人id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.ClgCheckerId); //学院审批人id
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.ClgCheckDate))
 {
 if (objJxTeachingPlanEN.ClgCheckDate !=  null)
 {
 var strClgCheckDate = objJxTeachingPlanEN.ClgCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClgCheckDate, conJxTeachingPlan.ClgCheckDate); //学院审批日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.ClgCheckDate); //学院审批日期
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IsSchCheck))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objJxTeachingPlanEN.IsSchCheck == true?"1":"0", conJxTeachingPlan.IsSchCheck); //是否学校审批
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchNote))
 {
 if (objJxTeachingPlanEN.SchNote !=  null)
 {
 var strSchNote = objJxTeachingPlanEN.SchNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchNote, conJxTeachingPlan.SchNote); //学校审批意见
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.SchNote); //学校审批意见
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchCheckerId))
 {
 if (objJxTeachingPlanEN.SchCheckerId !=  null)
 {
 var strSchCheckerId = objJxTeachingPlanEN.SchCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchCheckerId, conJxTeachingPlan.SchCheckerId); //学校审批人Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.SchCheckerId); //学校审批人Id
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchCheckDate))
 {
 if (objJxTeachingPlanEN.SchCheckDate !=  null)
 {
 var strSchCheckDate = objJxTeachingPlanEN.SchCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchCheckDate, conJxTeachingPlan.SchCheckDate); //学校审批日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.SchCheckDate); //学校审批日期
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IdSubmitStatus))
 {
 if (objJxTeachingPlanEN.IdSubmitStatus  ==  "")
 {
 objJxTeachingPlanEN.IdSubmitStatus = null;
 }
 if (objJxTeachingPlanEN.IdSubmitStatus !=  null)
 {
 var strIdSubmitStatus = objJxTeachingPlanEN.IdSubmitStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSubmitStatus, conJxTeachingPlan.IdSubmitStatus); //送审状态流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.IdSubmitStatus); //送审状态流水号
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.Memo))
 {
 if (objJxTeachingPlanEN.Memo !=  null)
 {
 var strMemo = objJxTeachingPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conJxTeachingPlan.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdTeachingPlan = '{0}'", objJxTeachingPlanEN.IdTeachingPlan); 
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
 /// <param name = "objJxTeachingPlanEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsJxTeachingPlanEN objJxTeachingPlanEN, string strCondition)
{
 if (objJxTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objJxTeachingPlanEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update JxTeachingPlan Set ");
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.TeachingPlanId))
 {
 if (objJxTeachingPlanEN.TeachingPlanId !=  null)
 {
 var strTeachingPlanId = objJxTeachingPlanEN.TeachingPlanId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingPlanId = '{0}',", strTeachingPlanId); //教学计划编号
 }
 else
 {
 sbSQL.Append(" TeachingPlanId = null,"); //教学计划编号
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.TeachingPlanDesc))
 {
 if (objJxTeachingPlanEN.TeachingPlanDesc !=  null)
 {
 var strTeachingPlanDesc = objJxTeachingPlanEN.TeachingPlanDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingPlanDesc = '{0}',", strTeachingPlanDesc); //教学计划名称
 }
 else
 {
 sbSQL.Append(" TeachingPlanDesc = null,"); //教学计划名称
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IdGrade))
 {
 if (objJxTeachingPlanEN.IdGrade !=  null)
 {
 var strIdGrade = objJxTeachingPlanEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGrade = '{0}',", strIdGrade); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGrade = null,"); //年级流水号
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchoolTerm))
 {
 if (objJxTeachingPlanEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objJxTeachingPlanEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.CourseId))
 {
 if (objJxTeachingPlanEN.CourseId !=  null)
 {
 var strCourseId = objJxTeachingPlanEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IsClgCheck))
 {
 sbSQL.AppendFormat(" IsClgCheck = '{0}',", objJxTeachingPlanEN.IsClgCheck == true?"1":"0"); //是否学院审批
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.ClgNote))
 {
 if (objJxTeachingPlanEN.ClgNote !=  null)
 {
 var strClgNote = objJxTeachingPlanEN.ClgNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClgNote = '{0}',", strClgNote); //学院审批意见
 }
 else
 {
 sbSQL.Append(" ClgNote = null,"); //学院审批意见
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.ClgCheckerId))
 {
 if (objJxTeachingPlanEN.ClgCheckerId !=  null)
 {
 var strClgCheckerId = objJxTeachingPlanEN.ClgCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClgCheckerId = '{0}',", strClgCheckerId); //学院审批人id
 }
 else
 {
 sbSQL.Append(" ClgCheckerId = null,"); //学院审批人id
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.ClgCheckDate))
 {
 if (objJxTeachingPlanEN.ClgCheckDate !=  null)
 {
 var strClgCheckDate = objJxTeachingPlanEN.ClgCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClgCheckDate = '{0}',", strClgCheckDate); //学院审批日期
 }
 else
 {
 sbSQL.Append(" ClgCheckDate = null,"); //学院审批日期
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IsSchCheck))
 {
 sbSQL.AppendFormat(" IsSchCheck = '{0}',", objJxTeachingPlanEN.IsSchCheck == true?"1":"0"); //是否学校审批
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchNote))
 {
 if (objJxTeachingPlanEN.SchNote !=  null)
 {
 var strSchNote = objJxTeachingPlanEN.SchNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchNote = '{0}',", strSchNote); //学校审批意见
 }
 else
 {
 sbSQL.Append(" SchNote = null,"); //学校审批意见
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchCheckerId))
 {
 if (objJxTeachingPlanEN.SchCheckerId !=  null)
 {
 var strSchCheckerId = objJxTeachingPlanEN.SchCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchCheckerId = '{0}',", strSchCheckerId); //学校审批人Id
 }
 else
 {
 sbSQL.Append(" SchCheckerId = null,"); //学校审批人Id
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchCheckDate))
 {
 if (objJxTeachingPlanEN.SchCheckDate !=  null)
 {
 var strSchCheckDate = objJxTeachingPlanEN.SchCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchCheckDate = '{0}',", strSchCheckDate); //学校审批日期
 }
 else
 {
 sbSQL.Append(" SchCheckDate = null,"); //学校审批日期
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IdSubmitStatus))
 {
 if (objJxTeachingPlanEN.IdSubmitStatus  ==  "")
 {
 objJxTeachingPlanEN.IdSubmitStatus = null;
 }
 if (objJxTeachingPlanEN.IdSubmitStatus !=  null)
 {
 var strIdSubmitStatus = objJxTeachingPlanEN.IdSubmitStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSubmitStatus = '{0}',", strIdSubmitStatus); //送审状态流水号
 }
 else
 {
 sbSQL.Append(" IdSubmitStatus = null,"); //送审状态流水号
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.Memo))
 {
 if (objJxTeachingPlanEN.Memo !=  null)
 {
 var strMemo = objJxTeachingPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objJxTeachingPlanEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsJxTeachingPlanEN objJxTeachingPlanEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objJxTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objJxTeachingPlanEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update JxTeachingPlan Set ");
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.TeachingPlanId))
 {
 if (objJxTeachingPlanEN.TeachingPlanId !=  null)
 {
 var strTeachingPlanId = objJxTeachingPlanEN.TeachingPlanId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingPlanId = '{0}',", strTeachingPlanId); //教学计划编号
 }
 else
 {
 sbSQL.Append(" TeachingPlanId = null,"); //教学计划编号
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.TeachingPlanDesc))
 {
 if (objJxTeachingPlanEN.TeachingPlanDesc !=  null)
 {
 var strTeachingPlanDesc = objJxTeachingPlanEN.TeachingPlanDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingPlanDesc = '{0}',", strTeachingPlanDesc); //教学计划名称
 }
 else
 {
 sbSQL.Append(" TeachingPlanDesc = null,"); //教学计划名称
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IdGrade))
 {
 if (objJxTeachingPlanEN.IdGrade !=  null)
 {
 var strIdGrade = objJxTeachingPlanEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGrade = '{0}',", strIdGrade); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGrade = null,"); //年级流水号
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchoolTerm))
 {
 if (objJxTeachingPlanEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objJxTeachingPlanEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.CourseId))
 {
 if (objJxTeachingPlanEN.CourseId !=  null)
 {
 var strCourseId = objJxTeachingPlanEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IsClgCheck))
 {
 sbSQL.AppendFormat(" IsClgCheck = '{0}',", objJxTeachingPlanEN.IsClgCheck == true?"1":"0"); //是否学院审批
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.ClgNote))
 {
 if (objJxTeachingPlanEN.ClgNote !=  null)
 {
 var strClgNote = objJxTeachingPlanEN.ClgNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClgNote = '{0}',", strClgNote); //学院审批意见
 }
 else
 {
 sbSQL.Append(" ClgNote = null,"); //学院审批意见
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.ClgCheckerId))
 {
 if (objJxTeachingPlanEN.ClgCheckerId !=  null)
 {
 var strClgCheckerId = objJxTeachingPlanEN.ClgCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClgCheckerId = '{0}',", strClgCheckerId); //学院审批人id
 }
 else
 {
 sbSQL.Append(" ClgCheckerId = null,"); //学院审批人id
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.ClgCheckDate))
 {
 if (objJxTeachingPlanEN.ClgCheckDate !=  null)
 {
 var strClgCheckDate = objJxTeachingPlanEN.ClgCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClgCheckDate = '{0}',", strClgCheckDate); //学院审批日期
 }
 else
 {
 sbSQL.Append(" ClgCheckDate = null,"); //学院审批日期
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IsSchCheck))
 {
 sbSQL.AppendFormat(" IsSchCheck = '{0}',", objJxTeachingPlanEN.IsSchCheck == true?"1":"0"); //是否学校审批
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchNote))
 {
 if (objJxTeachingPlanEN.SchNote !=  null)
 {
 var strSchNote = objJxTeachingPlanEN.SchNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchNote = '{0}',", strSchNote); //学校审批意见
 }
 else
 {
 sbSQL.Append(" SchNote = null,"); //学校审批意见
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchCheckerId))
 {
 if (objJxTeachingPlanEN.SchCheckerId !=  null)
 {
 var strSchCheckerId = objJxTeachingPlanEN.SchCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchCheckerId = '{0}',", strSchCheckerId); //学校审批人Id
 }
 else
 {
 sbSQL.Append(" SchCheckerId = null,"); //学校审批人Id
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchCheckDate))
 {
 if (objJxTeachingPlanEN.SchCheckDate !=  null)
 {
 var strSchCheckDate = objJxTeachingPlanEN.SchCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchCheckDate = '{0}',", strSchCheckDate); //学校审批日期
 }
 else
 {
 sbSQL.Append(" SchCheckDate = null,"); //学校审批日期
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IdSubmitStatus))
 {
 if (objJxTeachingPlanEN.IdSubmitStatus  ==  "")
 {
 objJxTeachingPlanEN.IdSubmitStatus = null;
 }
 if (objJxTeachingPlanEN.IdSubmitStatus !=  null)
 {
 var strIdSubmitStatus = objJxTeachingPlanEN.IdSubmitStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSubmitStatus = '{0}',", strIdSubmitStatus); //送审状态流水号
 }
 else
 {
 sbSQL.Append(" IdSubmitStatus = null,"); //送审状态流水号
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.Memo))
 {
 if (objJxTeachingPlanEN.Memo !=  null)
 {
 var strMemo = objJxTeachingPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objJxTeachingPlanEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsJxTeachingPlanEN objJxTeachingPlanEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objJxTeachingPlanEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objJxTeachingPlanEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update JxTeachingPlan Set ");
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.TeachingPlanId))
 {
 if (objJxTeachingPlanEN.TeachingPlanId !=  null)
 {
 var strTeachingPlanId = objJxTeachingPlanEN.TeachingPlanId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingPlanId, conJxTeachingPlan.TeachingPlanId); //教学计划编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.TeachingPlanId); //教学计划编号
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.TeachingPlanDesc))
 {
 if (objJxTeachingPlanEN.TeachingPlanDesc !=  null)
 {
 var strTeachingPlanDesc = objJxTeachingPlanEN.TeachingPlanDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingPlanDesc, conJxTeachingPlan.TeachingPlanDesc); //教学计划名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.TeachingPlanDesc); //教学计划名称
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IdGrade))
 {
 if (objJxTeachingPlanEN.IdGrade !=  null)
 {
 var strIdGrade = objJxTeachingPlanEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGrade, conJxTeachingPlan.IdGrade); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.IdGrade); //年级流水号
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchoolTerm))
 {
 if (objJxTeachingPlanEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objJxTeachingPlanEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conJxTeachingPlan.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.SchoolTerm); //学期
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.CourseId))
 {
 if (objJxTeachingPlanEN.CourseId !=  null)
 {
 var strCourseId = objJxTeachingPlanEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conJxTeachingPlan.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.CourseId); //课程Id
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IsClgCheck))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objJxTeachingPlanEN.IsClgCheck == true?"1":"0", conJxTeachingPlan.IsClgCheck); //是否学院审批
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.ClgNote))
 {
 if (objJxTeachingPlanEN.ClgNote !=  null)
 {
 var strClgNote = objJxTeachingPlanEN.ClgNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClgNote, conJxTeachingPlan.ClgNote); //学院审批意见
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.ClgNote); //学院审批意见
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.ClgCheckerId))
 {
 if (objJxTeachingPlanEN.ClgCheckerId !=  null)
 {
 var strClgCheckerId = objJxTeachingPlanEN.ClgCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClgCheckerId, conJxTeachingPlan.ClgCheckerId); //学院审批人id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.ClgCheckerId); //学院审批人id
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.ClgCheckDate))
 {
 if (objJxTeachingPlanEN.ClgCheckDate !=  null)
 {
 var strClgCheckDate = objJxTeachingPlanEN.ClgCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClgCheckDate, conJxTeachingPlan.ClgCheckDate); //学院审批日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.ClgCheckDate); //学院审批日期
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IsSchCheck))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objJxTeachingPlanEN.IsSchCheck == true?"1":"0", conJxTeachingPlan.IsSchCheck); //是否学校审批
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchNote))
 {
 if (objJxTeachingPlanEN.SchNote !=  null)
 {
 var strSchNote = objJxTeachingPlanEN.SchNote.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchNote, conJxTeachingPlan.SchNote); //学校审批意见
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.SchNote); //学校审批意见
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchCheckerId))
 {
 if (objJxTeachingPlanEN.SchCheckerId !=  null)
 {
 var strSchCheckerId = objJxTeachingPlanEN.SchCheckerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchCheckerId, conJxTeachingPlan.SchCheckerId); //学校审批人Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.SchCheckerId); //学校审批人Id
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.SchCheckDate))
 {
 if (objJxTeachingPlanEN.SchCheckDate !=  null)
 {
 var strSchCheckDate = objJxTeachingPlanEN.SchCheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchCheckDate, conJxTeachingPlan.SchCheckDate); //学校审批日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.SchCheckDate); //学校审批日期
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.IdSubmitStatus))
 {
 if (objJxTeachingPlanEN.IdSubmitStatus  ==  "")
 {
 objJxTeachingPlanEN.IdSubmitStatus = null;
 }
 if (objJxTeachingPlanEN.IdSubmitStatus !=  null)
 {
 var strIdSubmitStatus = objJxTeachingPlanEN.IdSubmitStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSubmitStatus, conJxTeachingPlan.IdSubmitStatus); //送审状态流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.IdSubmitStatus); //送审状态流水号
 }
 }
 
 if (objJxTeachingPlanEN.IsUpdated(conJxTeachingPlan.Memo))
 {
 if (objJxTeachingPlanEN.Memo !=  null)
 {
 var strMemo = objJxTeachingPlanEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conJxTeachingPlan.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJxTeachingPlan.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdTeachingPlan = '{0}'", objJxTeachingPlanEN.IdTeachingPlan); 
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
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdTeachingPlan,
};
 objSQL.ExecSP("JxTeachingPlan_Delete", values);
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
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
//删除JxTeachingPlan本表中与当前对象有关的记录
strSQL = strSQL + "Delete from JxTeachingPlan where IdTeachingPlan = " + "'"+ strIdTeachingPlan+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelJxTeachingPlan(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
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
//删除JxTeachingPlan本表中与当前对象有关的记录
strSQL = strSQL + "Delete from JxTeachingPlan where IdTeachingPlan in (" + strKeyList + ")";
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
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
//删除JxTeachingPlan本表中与当前对象有关的记录
strSQL = strSQL + "Delete from JxTeachingPlan where IdTeachingPlan = " + "'"+ strIdTeachingPlan+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelJxTeachingPlan(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsJxTeachingPlanDA: DelJxTeachingPlan)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from JxTeachingPlan where " + strCondition ;
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
public bool DelJxTeachingPlanWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsJxTeachingPlanDA: DelJxTeachingPlanWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from JxTeachingPlan where " + strCondition ;
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
 /// <param name = "objJxTeachingPlanENS">源对象</param>
 /// <param name = "objJxTeachingPlanENT">目标对象</param>
public void CopyTo(clsJxTeachingPlanEN objJxTeachingPlanENS, clsJxTeachingPlanEN objJxTeachingPlanENT)
{
objJxTeachingPlanENT.IdTeachingPlan = objJxTeachingPlanENS.IdTeachingPlan; //教案流水号
objJxTeachingPlanENT.TeachingPlanId = objJxTeachingPlanENS.TeachingPlanId; //教学计划编号
objJxTeachingPlanENT.TeachingPlanDesc = objJxTeachingPlanENS.TeachingPlanDesc; //教学计划名称
objJxTeachingPlanENT.IdGrade = objJxTeachingPlanENS.IdGrade; //年级流水号
objJxTeachingPlanENT.SchoolTerm = objJxTeachingPlanENS.SchoolTerm; //学期
objJxTeachingPlanENT.CourseId = objJxTeachingPlanENS.CourseId; //课程Id
objJxTeachingPlanENT.IsClgCheck = objJxTeachingPlanENS.IsClgCheck; //是否学院审批
objJxTeachingPlanENT.ClgNote = objJxTeachingPlanENS.ClgNote; //学院审批意见
objJxTeachingPlanENT.ClgCheckerId = objJxTeachingPlanENS.ClgCheckerId; //学院审批人id
objJxTeachingPlanENT.ClgCheckDate = objJxTeachingPlanENS.ClgCheckDate; //学院审批日期
objJxTeachingPlanENT.IsSchCheck = objJxTeachingPlanENS.IsSchCheck; //是否学校审批
objJxTeachingPlanENT.SchNote = objJxTeachingPlanENS.SchNote; //学校审批意见
objJxTeachingPlanENT.SchCheckerId = objJxTeachingPlanENS.SchCheckerId; //学校审批人Id
objJxTeachingPlanENT.SchCheckDate = objJxTeachingPlanENS.SchCheckDate; //学校审批日期
objJxTeachingPlanENT.IdSubmitStatus = objJxTeachingPlanENS.IdSubmitStatus; //送审状态流水号
objJxTeachingPlanENT.Memo = objJxTeachingPlanENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsJxTeachingPlanEN objJxTeachingPlanEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objJxTeachingPlanEN.TeachingPlanId, conJxTeachingPlan.TeachingPlanId);
clsCheckSql.CheckFieldNotNull(objJxTeachingPlanEN.TeachingPlanDesc, conJxTeachingPlan.TeachingPlanDesc);
clsCheckSql.CheckFieldNotNull(objJxTeachingPlanEN.IdGrade, conJxTeachingPlan.IdGrade);
clsCheckSql.CheckFieldNotNull(objJxTeachingPlanEN.SchoolTerm, conJxTeachingPlan.SchoolTerm);
clsCheckSql.CheckFieldNotNull(objJxTeachingPlanEN.CourseId, conJxTeachingPlan.CourseId);
clsCheckSql.CheckFieldNotNull(objJxTeachingPlanEN.IdSubmitStatus, conJxTeachingPlan.IdSubmitStatus);
//检查字段长度
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.IdTeachingPlan, 8, conJxTeachingPlan.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.TeachingPlanId, 12, conJxTeachingPlan.TeachingPlanId);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.TeachingPlanDesc, 100, conJxTeachingPlan.TeachingPlanDesc);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.IdGrade, 4, conJxTeachingPlan.IdGrade);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.SchoolTerm, 1, conJxTeachingPlan.SchoolTerm);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.CourseId, 8, conJxTeachingPlan.CourseId);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.ClgCheckerId, 18, conJxTeachingPlan.ClgCheckerId);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.ClgCheckDate, 8, conJxTeachingPlan.ClgCheckDate);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.SchCheckerId, 18, conJxTeachingPlan.SchCheckerId);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.SchCheckDate, 8, conJxTeachingPlan.SchCheckDate);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.IdSubmitStatus, 2, conJxTeachingPlan.IdSubmitStatus);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.Memo, 1000, conJxTeachingPlan.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objJxTeachingPlanEN.IdSubmitStatus, 2, conJxTeachingPlan.IdSubmitStatus);
 objJxTeachingPlanEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsJxTeachingPlanEN objJxTeachingPlanEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.TeachingPlanId, 12, conJxTeachingPlan.TeachingPlanId);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.TeachingPlanDesc, 100, conJxTeachingPlan.TeachingPlanDesc);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.IdGrade, 4, conJxTeachingPlan.IdGrade);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.SchoolTerm, 1, conJxTeachingPlan.SchoolTerm);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.CourseId, 8, conJxTeachingPlan.CourseId);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.ClgCheckerId, 18, conJxTeachingPlan.ClgCheckerId);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.ClgCheckDate, 8, conJxTeachingPlan.ClgCheckDate);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.SchCheckerId, 18, conJxTeachingPlan.SchCheckerId);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.SchCheckDate, 8, conJxTeachingPlan.SchCheckDate);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.IdSubmitStatus, 2, conJxTeachingPlan.IdSubmitStatus);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.Memo, 1000, conJxTeachingPlan.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objJxTeachingPlanEN.IdSubmitStatus, 2, conJxTeachingPlan.IdSubmitStatus);
 objJxTeachingPlanEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsJxTeachingPlanEN objJxTeachingPlanEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.IdTeachingPlan, 8, conJxTeachingPlan.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.TeachingPlanId, 12, conJxTeachingPlan.TeachingPlanId);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.TeachingPlanDesc, 100, conJxTeachingPlan.TeachingPlanDesc);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.IdGrade, 4, conJxTeachingPlan.IdGrade);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.SchoolTerm, 1, conJxTeachingPlan.SchoolTerm);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.CourseId, 8, conJxTeachingPlan.CourseId);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.ClgCheckerId, 18, conJxTeachingPlan.ClgCheckerId);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.ClgCheckDate, 8, conJxTeachingPlan.ClgCheckDate);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.SchCheckerId, 18, conJxTeachingPlan.SchCheckerId);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.SchCheckDate, 8, conJxTeachingPlan.SchCheckDate);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.IdSubmitStatus, 2, conJxTeachingPlan.IdSubmitStatus);
clsCheckSql.CheckFieldLen(objJxTeachingPlanEN.Memo, 1000, conJxTeachingPlan.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objJxTeachingPlanEN.IdTeachingPlan, conJxTeachingPlan.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objJxTeachingPlanEN.TeachingPlanId, conJxTeachingPlan.TeachingPlanId);
clsCheckSql.CheckSqlInjection4Field(objJxTeachingPlanEN.TeachingPlanDesc, conJxTeachingPlan.TeachingPlanDesc);
clsCheckSql.CheckSqlInjection4Field(objJxTeachingPlanEN.IdGrade, conJxTeachingPlan.IdGrade);
clsCheckSql.CheckSqlInjection4Field(objJxTeachingPlanEN.SchoolTerm, conJxTeachingPlan.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objJxTeachingPlanEN.CourseId, conJxTeachingPlan.CourseId);
clsCheckSql.CheckSqlInjection4Field(objJxTeachingPlanEN.ClgCheckerId, conJxTeachingPlan.ClgCheckerId);
clsCheckSql.CheckSqlInjection4Field(objJxTeachingPlanEN.ClgCheckDate, conJxTeachingPlan.ClgCheckDate);
clsCheckSql.CheckSqlInjection4Field(objJxTeachingPlanEN.SchCheckerId, conJxTeachingPlan.SchCheckerId);
clsCheckSql.CheckSqlInjection4Field(objJxTeachingPlanEN.SchCheckDate, conJxTeachingPlan.SchCheckDate);
clsCheckSql.CheckSqlInjection4Field(objJxTeachingPlanEN.IdSubmitStatus, conJxTeachingPlan.IdSubmitStatus);
clsCheckSql.CheckSqlInjection4Field(objJxTeachingPlanEN.Memo, conJxTeachingPlan.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objJxTeachingPlanEN.IdSubmitStatus, 2, conJxTeachingPlan.IdSubmitStatus);
 objJxTeachingPlanEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdTeachingPlan()
{
//获取某学院所有专业信息
string strSQL = "select IdTeachingPlan, TeachingPlanDesc from JxTeachingPlan ";
 clsSpecSQLforSql mySql = clsJxTeachingPlanDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--JxTeachingPlan(教学计划),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objJxTeachingPlanEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsJxTeachingPlanEN objJxTeachingPlanEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TeachingPlanDesc = '{0}'", objJxTeachingPlanEN.TeachingPlanDesc);
 sbCondition.AppendFormat(" and TeachingPlanId = '{0}'", objJxTeachingPlanEN.TeachingPlanId);
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
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
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
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
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
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsJxTeachingPlanEN._CurrTabName);
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
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsJxTeachingPlanEN._CurrTabName, strCondition);
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
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
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
 objSQL = clsJxTeachingPlanDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}