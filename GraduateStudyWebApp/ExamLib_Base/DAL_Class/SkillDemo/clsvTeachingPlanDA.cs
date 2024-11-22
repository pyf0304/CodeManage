
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingPlanDA
 表名:vTeachingPlan(01120388)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:13
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
 /// v教案(vTeachingPlan)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTeachingPlanDA : clsCommBase4DA
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
 return clsvTeachingPlanEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTeachingPlanEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachingPlanEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTeachingPlanEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTeachingPlanEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vTeachingPlan中,检查关键字,长度不正确!(clsvTeachingPlanDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdTeachingPlan)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vTeachingPlan中,关键字不能为空 或 null!(clsvTeachingPlanDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeachingPlan);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvTeachingPlanDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTeachingPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTeachingPlan(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTeachingPlanDA: GetDataTable_vTeachingPlan)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingPlan where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTeachingPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTeachingPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingPlan where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTeachingPlanDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTeachingPlanDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingPlan where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingPlan where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTeachingPlanDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTeachingPlan where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTeachingPlanDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachingPlan.* from vTeachingPlan Left Join {1} on {2} where {3} and vTeachingPlan.IdTeachingPlan not in (Select top {5} vTeachingPlan.IdTeachingPlan from vTeachingPlan Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingPlan where {1} and IdTeachingPlan not in (Select top {2} IdTeachingPlan from vTeachingPlan where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingPlan where {1} and IdTeachingPlan not in (Select top {3} IdTeachingPlan from vTeachingPlan where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTeachingPlanDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachingPlan.* from vTeachingPlan Left Join {1} on {2} where {3} and vTeachingPlan.IdTeachingPlan not in (Select top {5} vTeachingPlan.IdTeachingPlan from vTeachingPlan Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingPlan where {1} and IdTeachingPlan not in (Select top {2} IdTeachingPlan from vTeachingPlan where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingPlan where {1} and IdTeachingPlan not in (Select top {3} IdTeachingPlan from vTeachingPlan where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTeachingPlanEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTeachingPlanDA:GetObjLst)", objException.Message));
}
List<clsvTeachingPlanEN> arrObjLst = new List<clsvTeachingPlanEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingPlanEN objvTeachingPlanEN = new clsvTeachingPlanEN();
try
{
objvTeachingPlanEN.IdTeachingPlan = objRow[convTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingPlanEN.SubjectName = objRow[convTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objvTeachingPlanEN.TeachingPlanAuthor = objRow[convTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvTeachingPlanEN.TeachingObject = objRow[convTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objvTeachingPlanEN.TeachingEmphases = objRow[convTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objvTeachingPlanEN.TeachingDifficulty = objRow[convTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objvTeachingPlanEN.TeachingTool = objRow[convTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objvTeachingPlanEN.TeachingProcess = objRow[convTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objvTeachingPlanEN.TeachingPlanType = objRow[convTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objvTeachingPlanEN.TeachPlanTypeName = objRow[convTeachingPlan.TeachPlanTypeName] == DBNull.Value ? null : objRow[convTeachingPlan.TeachPlanTypeName].ToString().Trim(); //教案类型名称
objvTeachingPlanEN.SimplePlanContent = objRow[convTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[convTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objvTeachingPlanEN.TeachingPlanInDate = objRow[convTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objvTeachingPlanEN.TeachingPlanInTime = objRow[convTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objvTeachingPlanEN.Memo = objRow[convTeachingPlan.Memo] == DBNull.Value ? null : objRow[convTeachingPlan.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachingPlanDA: GetObjLst)", objException.Message));
}
objvTeachingPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachingPlanEN);
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
public List<clsvTeachingPlanEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTeachingPlanDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTeachingPlanEN> arrObjLst = new List<clsvTeachingPlanEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingPlanEN objvTeachingPlanEN = new clsvTeachingPlanEN();
try
{
objvTeachingPlanEN.IdTeachingPlan = objRow[convTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingPlanEN.SubjectName = objRow[convTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objvTeachingPlanEN.TeachingPlanAuthor = objRow[convTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvTeachingPlanEN.TeachingObject = objRow[convTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objvTeachingPlanEN.TeachingEmphases = objRow[convTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objvTeachingPlanEN.TeachingDifficulty = objRow[convTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objvTeachingPlanEN.TeachingTool = objRow[convTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objvTeachingPlanEN.TeachingProcess = objRow[convTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objvTeachingPlanEN.TeachingPlanType = objRow[convTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objvTeachingPlanEN.TeachPlanTypeName = objRow[convTeachingPlan.TeachPlanTypeName] == DBNull.Value ? null : objRow[convTeachingPlan.TeachPlanTypeName].ToString().Trim(); //教案类型名称
objvTeachingPlanEN.SimplePlanContent = objRow[convTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[convTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objvTeachingPlanEN.TeachingPlanInDate = objRow[convTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objvTeachingPlanEN.TeachingPlanInTime = objRow[convTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objvTeachingPlanEN.Memo = objRow[convTeachingPlan.Memo] == DBNull.Value ? null : objRow[convTeachingPlan.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachingPlanDA: GetObjLst)", objException.Message));
}
objvTeachingPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachingPlanEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTeachingPlan(ref clsvTeachingPlanEN objvTeachingPlanEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingPlan where IdTeachingPlan = " + "'"+ objvTeachingPlanEN.IdTeachingPlan+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTeachingPlanEN.IdTeachingPlan = objDT.Rows[0][convTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingPlanEN.SubjectName = objDT.Rows[0][convTeachingPlan.SubjectName].ToString().Trim(); //课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvTeachingPlanEN.TeachingPlanAuthor = objDT.Rows[0][convTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachingPlanEN.TeachingObject = objDT.Rows[0][convTeachingPlan.TeachingObject].ToString().Trim(); //教学目标(字段类型:varchar,字段长度:5000,是否可空:True)
 objvTeachingPlanEN.TeachingEmphases = objDT.Rows[0][convTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvTeachingPlanEN.TeachingDifficulty = objDT.Rows[0][convTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvTeachingPlanEN.TeachingTool = objDT.Rows[0][convTeachingPlan.TeachingTool].ToString().Trim(); //教学用具(字段类型:varchar,字段长度:5000,是否可空:True)
 objvTeachingPlanEN.TeachingProcess = objDT.Rows[0][convTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachingPlanEN.TeachingPlanType = objDT.Rows[0][convTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型(字段类型:char,字段长度:1,是否可空:True)
 objvTeachingPlanEN.TeachPlanTypeName = objDT.Rows[0][convTeachingPlan.TeachPlanTypeName].ToString().Trim(); //教案类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingPlanEN.SimplePlanContent = objDT.Rows[0][convTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvTeachingPlanEN.TeachingPlanInDate = objDT.Rows[0][convTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingPlanEN.TeachingPlanInTime = objDT.Rows[0][convTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingPlanEN.Memo = objDT.Rows[0][convTeachingPlan.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTeachingPlanDA: GetvTeachingPlan)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdTeachingPlan">表关键字</param>
 /// <returns>表对象</returns>
public clsvTeachingPlanEN GetObjByIdTeachingPlan(string strIdTeachingPlan)
{
CheckPrimaryKey(strIdTeachingPlan);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingPlan where IdTeachingPlan = " + "'"+ strIdTeachingPlan+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTeachingPlanEN objvTeachingPlanEN = new clsvTeachingPlanEN();
try
{
 objvTeachingPlanEN.IdTeachingPlan = objRow[convTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingPlanEN.SubjectName = objRow[convTeachingPlan.SubjectName].ToString().Trim(); //课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvTeachingPlanEN.TeachingPlanAuthor = objRow[convTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachingPlanEN.TeachingObject = objRow[convTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingObject].ToString().Trim(); //教学目标(字段类型:varchar,字段长度:5000,是否可空:True)
 objvTeachingPlanEN.TeachingEmphases = objRow[convTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvTeachingPlanEN.TeachingDifficulty = objRow[convTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvTeachingPlanEN.TeachingTool = objRow[convTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingTool].ToString().Trim(); //教学用具(字段类型:varchar,字段长度:5000,是否可空:True)
 objvTeachingPlanEN.TeachingProcess = objRow[convTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachingPlanEN.TeachingPlanType = objRow[convTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型(字段类型:char,字段长度:1,是否可空:True)
 objvTeachingPlanEN.TeachPlanTypeName = objRow[convTeachingPlan.TeachPlanTypeName] == DBNull.Value ? null : objRow[convTeachingPlan.TeachPlanTypeName].ToString().Trim(); //教案类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingPlanEN.SimplePlanContent = objRow[convTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[convTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvTeachingPlanEN.TeachingPlanInDate = objRow[convTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingPlanEN.TeachingPlanInTime = objRow[convTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingPlanEN.Memo = objRow[convTeachingPlan.Memo] == DBNull.Value ? null : objRow[convTeachingPlan.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTeachingPlanDA: GetObjByIdTeachingPlan)", objException.Message));
}
return objvTeachingPlanEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTeachingPlanEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTeachingPlanDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingPlan where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTeachingPlanEN objvTeachingPlanEN = new clsvTeachingPlanEN()
{
IdTeachingPlan = objRow[convTeachingPlan.IdTeachingPlan].ToString().Trim(), //教案流水号
SubjectName = objRow[convTeachingPlan.SubjectName].ToString().Trim(), //课题名称
TeachingPlanAuthor = objRow[convTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanAuthor].ToString().Trim(), //教案撰写人
TeachingObject = objRow[convTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingObject].ToString().Trim(), //教学目标
TeachingEmphases = objRow[convTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingEmphases].ToString().Trim(), //教学重点
TeachingDifficulty = objRow[convTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingDifficulty].ToString().Trim(), //教学难点
TeachingTool = objRow[convTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingTool].ToString().Trim(), //教学用具
TeachingProcess = objRow[convTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingProcess].ToString().Trim(), //教学过程
TeachingPlanType = objRow[convTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanType].ToString().Trim(), //教案类型
TeachPlanTypeName = objRow[convTeachingPlan.TeachPlanTypeName] == DBNull.Value ? null : objRow[convTeachingPlan.TeachPlanTypeName].ToString().Trim(), //教案类型名称
SimplePlanContent = objRow[convTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[convTeachingPlan.SimplePlanContent].ToString().Trim(), //简案内容
TeachingPlanInDate = objRow[convTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInDate].ToString().Trim(), //教案入库日期
TeachingPlanInTime = objRow[convTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInTime].ToString().Trim(), //教案入库时间
Memo = objRow[convTeachingPlan.Memo] == DBNull.Value ? null : objRow[convTeachingPlan.Memo].ToString().Trim() //备注
};
objvTeachingPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingPlanEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTeachingPlanDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTeachingPlanEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachingPlanEN objvTeachingPlanEN = new clsvTeachingPlanEN();
try
{
objvTeachingPlanEN.IdTeachingPlan = objRow[convTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingPlanEN.SubjectName = objRow[convTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objvTeachingPlanEN.TeachingPlanAuthor = objRow[convTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvTeachingPlanEN.TeachingObject = objRow[convTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objvTeachingPlanEN.TeachingEmphases = objRow[convTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objvTeachingPlanEN.TeachingDifficulty = objRow[convTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objvTeachingPlanEN.TeachingTool = objRow[convTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objvTeachingPlanEN.TeachingProcess = objRow[convTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objvTeachingPlanEN.TeachingPlanType = objRow[convTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objvTeachingPlanEN.TeachPlanTypeName = objRow[convTeachingPlan.TeachPlanTypeName] == DBNull.Value ? null : objRow[convTeachingPlan.TeachPlanTypeName].ToString().Trim(); //教案类型名称
objvTeachingPlanEN.SimplePlanContent = objRow[convTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[convTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objvTeachingPlanEN.TeachingPlanInDate = objRow[convTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objvTeachingPlanEN.TeachingPlanInTime = objRow[convTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objvTeachingPlanEN.Memo = objRow[convTeachingPlan.Memo] == DBNull.Value ? null : objRow[convTeachingPlan.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTeachingPlanDA: GetObjByDataRowvTeachingPlan)", objException.Message));
}
objvTeachingPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingPlanEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTeachingPlanEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachingPlanEN objvTeachingPlanEN = new clsvTeachingPlanEN();
try
{
objvTeachingPlanEN.IdTeachingPlan = objRow[convTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingPlanEN.SubjectName = objRow[convTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objvTeachingPlanEN.TeachingPlanAuthor = objRow[convTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvTeachingPlanEN.TeachingObject = objRow[convTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objvTeachingPlanEN.TeachingEmphases = objRow[convTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objvTeachingPlanEN.TeachingDifficulty = objRow[convTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objvTeachingPlanEN.TeachingTool = objRow[convTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objvTeachingPlanEN.TeachingProcess = objRow[convTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objvTeachingPlanEN.TeachingPlanType = objRow[convTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objvTeachingPlanEN.TeachPlanTypeName = objRow[convTeachingPlan.TeachPlanTypeName] == DBNull.Value ? null : objRow[convTeachingPlan.TeachPlanTypeName].ToString().Trim(); //教案类型名称
objvTeachingPlanEN.SimplePlanContent = objRow[convTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[convTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objvTeachingPlanEN.TeachingPlanInDate = objRow[convTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objvTeachingPlanEN.TeachingPlanInTime = objRow[convTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objvTeachingPlanEN.Memo = objRow[convTeachingPlan.Memo] == DBNull.Value ? null : objRow[convTeachingPlan.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTeachingPlanDA: GetObjByDataRow)", objException.Message));
}
objvTeachingPlanEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingPlanEN;
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
objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachingPlanEN._CurrTabName, convTeachingPlan.IdTeachingPlan, 8, "");
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
objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachingPlanEN._CurrTabName, convTeachingPlan.IdTeachingPlan, 8, strPrefix);
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
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdTeachingPlan from vTeachingPlan where " + strCondition;
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
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdTeachingPlan from vTeachingPlan where " + strCondition;
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
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachingPlan", "IdTeachingPlan = " + "'"+ strIdTeachingPlan+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTeachingPlanDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachingPlan", strCondition))
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
objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTeachingPlan");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTeachingPlanENS">源对象</param>
 /// <param name = "objvTeachingPlanENT">目标对象</param>
public void CopyTo(clsvTeachingPlanEN objvTeachingPlanENS, clsvTeachingPlanEN objvTeachingPlanENT)
{
objvTeachingPlanENT.IdTeachingPlan = objvTeachingPlanENS.IdTeachingPlan; //教案流水号
objvTeachingPlanENT.SubjectName = objvTeachingPlanENS.SubjectName; //课题名称
objvTeachingPlanENT.TeachingPlanAuthor = objvTeachingPlanENS.TeachingPlanAuthor; //教案撰写人
objvTeachingPlanENT.TeachingObject = objvTeachingPlanENS.TeachingObject; //教学目标
objvTeachingPlanENT.TeachingEmphases = objvTeachingPlanENS.TeachingEmphases; //教学重点
objvTeachingPlanENT.TeachingDifficulty = objvTeachingPlanENS.TeachingDifficulty; //教学难点
objvTeachingPlanENT.TeachingTool = objvTeachingPlanENS.TeachingTool; //教学用具
objvTeachingPlanENT.TeachingProcess = objvTeachingPlanENS.TeachingProcess; //教学过程
objvTeachingPlanENT.TeachingPlanType = objvTeachingPlanENS.TeachingPlanType; //教案类型
objvTeachingPlanENT.TeachPlanTypeName = objvTeachingPlanENS.TeachPlanTypeName; //教案类型名称
objvTeachingPlanENT.SimplePlanContent = objvTeachingPlanENS.SimplePlanContent; //简案内容
objvTeachingPlanENT.TeachingPlanInDate = objvTeachingPlanENS.TeachingPlanInDate; //教案入库日期
objvTeachingPlanENT.TeachingPlanInTime = objvTeachingPlanENS.TeachingPlanInTime; //教案入库时间
objvTeachingPlanENT.Memo = objvTeachingPlanENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTeachingPlanEN objvTeachingPlanEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTeachingPlanEN.IdTeachingPlan, 8, convTeachingPlan.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvTeachingPlanEN.SubjectName, 200, convTeachingPlan.SubjectName);
clsCheckSql.CheckFieldLen(objvTeachingPlanEN.TeachingPlanAuthor, 50, convTeachingPlan.TeachingPlanAuthor);
clsCheckSql.CheckFieldLen(objvTeachingPlanEN.TeachingObject, 5000, convTeachingPlan.TeachingObject);
clsCheckSql.CheckFieldLen(objvTeachingPlanEN.TeachingEmphases, 5000, convTeachingPlan.TeachingEmphases);
clsCheckSql.CheckFieldLen(objvTeachingPlanEN.TeachingDifficulty, 5000, convTeachingPlan.TeachingDifficulty);
clsCheckSql.CheckFieldLen(objvTeachingPlanEN.TeachingTool, 5000, convTeachingPlan.TeachingTool);
clsCheckSql.CheckFieldLen(objvTeachingPlanEN.TeachingProcess, 8000, convTeachingPlan.TeachingProcess);
clsCheckSql.CheckFieldLen(objvTeachingPlanEN.TeachingPlanType, 1, convTeachingPlan.TeachingPlanType);
clsCheckSql.CheckFieldLen(objvTeachingPlanEN.TeachPlanTypeName, 50, convTeachingPlan.TeachPlanTypeName);
clsCheckSql.CheckFieldLen(objvTeachingPlanEN.TeachingPlanInDate, 8, convTeachingPlan.TeachingPlanInDate);
clsCheckSql.CheckFieldLen(objvTeachingPlanEN.TeachingPlanInTime, 6, convTeachingPlan.TeachingPlanInTime);
clsCheckSql.CheckFieldLen(objvTeachingPlanEN.Memo, 1000, convTeachingPlan.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTeachingPlanEN.IdTeachingPlan, convTeachingPlan.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvTeachingPlanEN.SubjectName, convTeachingPlan.SubjectName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingPlanEN.TeachingPlanAuthor, convTeachingPlan.TeachingPlanAuthor);
clsCheckSql.CheckSqlInjection4Field(objvTeachingPlanEN.TeachingObject, convTeachingPlan.TeachingObject);
clsCheckSql.CheckSqlInjection4Field(objvTeachingPlanEN.TeachingEmphases, convTeachingPlan.TeachingEmphases);
clsCheckSql.CheckSqlInjection4Field(objvTeachingPlanEN.TeachingDifficulty, convTeachingPlan.TeachingDifficulty);
clsCheckSql.CheckSqlInjection4Field(objvTeachingPlanEN.TeachingTool, convTeachingPlan.TeachingTool);
clsCheckSql.CheckSqlInjection4Field(objvTeachingPlanEN.TeachingProcess, convTeachingPlan.TeachingProcess);
clsCheckSql.CheckSqlInjection4Field(objvTeachingPlanEN.TeachingPlanType, convTeachingPlan.TeachingPlanType);
clsCheckSql.CheckSqlInjection4Field(objvTeachingPlanEN.TeachPlanTypeName, convTeachingPlan.TeachPlanTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingPlanEN.TeachingPlanInDate, convTeachingPlan.TeachingPlanInDate);
clsCheckSql.CheckSqlInjection4Field(objvTeachingPlanEN.TeachingPlanInTime, convTeachingPlan.TeachingPlanInTime);
clsCheckSql.CheckSqlInjection4Field(objvTeachingPlanEN.Memo, convTeachingPlan.Memo);
//检查外键字段长度
 objvTeachingPlanEN._IsCheckProperty = true;
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
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
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
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
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
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachingPlanEN._CurrTabName);
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
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachingPlanEN._CurrTabName, strCondition);
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
 objSQL = clsvTeachingPlanDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}