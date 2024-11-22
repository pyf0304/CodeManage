
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_TobeStudiedProblemDA
 表名:vgs_TobeStudiedProblem(01120774)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:05:24
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
 /// 待研究问题视图(vgs_TobeStudiedProblem)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvgs_TobeStudiedProblemDA : clsCommBase4DA
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
 return clsvgs_TobeStudiedProblemEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvgs_TobeStudiedProblemEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_TobeStudiedProblemEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvgs_TobeStudiedProblemEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvgs_TobeStudiedProblemEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strProblemId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strProblemId)
{
strProblemId = strProblemId.Replace("'", "''");
if (strProblemId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:vgs_TobeStudiedProblem中,检查关键字,长度不正确!(clsvgs_TobeStudiedProblemDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strProblemId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vgs_TobeStudiedProblem中,关键字不能为空 或 null!(clsvgs_TobeStudiedProblemDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strProblemId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvgs_TobeStudiedProblemDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvgs_TobeStudiedProblemDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from vgs_TobeStudiedProblem where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vgs_TobeStudiedProblem(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvgs_TobeStudiedProblemDA: GetDataTable_vgs_TobeStudiedProblem)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from vgs_TobeStudiedProblem where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvgs_TobeStudiedProblemDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvgs_TobeStudiedProblemDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from vgs_TobeStudiedProblem where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvgs_TobeStudiedProblemDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvgs_TobeStudiedProblemDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_TobeStudiedProblem where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_TobeStudiedProblem where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvgs_TobeStudiedProblemDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vgs_TobeStudiedProblem where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvgs_TobeStudiedProblemDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_TobeStudiedProblem.* from vgs_TobeStudiedProblem Left Join {1} on {2} where {3} and vgs_TobeStudiedProblem.ProblemId not in (Select top {5} vgs_TobeStudiedProblem.ProblemId from vgs_TobeStudiedProblem Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_TobeStudiedProblem where {1} and ProblemId not in (Select top {2} ProblemId from vgs_TobeStudiedProblem where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_TobeStudiedProblem where {1} and ProblemId not in (Select top {3} ProblemId from vgs_TobeStudiedProblem where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvgs_TobeStudiedProblemDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_TobeStudiedProblem.* from vgs_TobeStudiedProblem Left Join {1} on {2} where {3} and vgs_TobeStudiedProblem.ProblemId not in (Select top {5} vgs_TobeStudiedProblem.ProblemId from vgs_TobeStudiedProblem Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_TobeStudiedProblem where {1} and ProblemId not in (Select top {2} ProblemId from vgs_TobeStudiedProblem where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_TobeStudiedProblem where {1} and ProblemId not in (Select top {3} ProblemId from vgs_TobeStudiedProblem where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvgs_TobeStudiedProblemEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvgs_TobeStudiedProblemDA:GetObjLst)", objException.Message));
}
List<clsvgs_TobeStudiedProblemEN> arrObjLst = new List<clsvgs_TobeStudiedProblemEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from vgs_TobeStudiedProblem where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN();
try
{
objvgs_TobeStudiedProblemEN.ProblemId = objRow[convgs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvgs_TobeStudiedProblemEN.ProblemTitle = objRow[convgs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvgs_TobeStudiedProblemEN.ProblemContent = objRow[convgs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvgs_TobeStudiedProblemEN.TopicId = objRow[convgs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objvgs_TobeStudiedProblemEN.TopicName = objRow[convgs_TobeStudiedProblem.TopicName] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicName].ToString().Trim(); //栏目主题
objvgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[convgs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objRow[convgs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvgs_TobeStudiedProblemEN.ProblemDate = objRow[convgs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvgs_TobeStudiedProblemEN.UpdDate = objRow[convgs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvgs_TobeStudiedProblemEN.UpdUser = objRow[convgs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvgs_TobeStudiedProblemEN.Year = objRow[convgs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Year].ToString().Trim(); //年
objvgs_TobeStudiedProblemEN.Month = objRow[convgs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Month].ToString().Trim(); //月
objvgs_TobeStudiedProblemEN.VersionCount = objRow[convgs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvgs_TobeStudiedProblemEN.Participant = objRow[convgs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvgs_TobeStudiedProblemEN.Memo = objRow[convgs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_TobeStudiedProblemDA: GetObjLst)", objException.Message));
}
objvgs_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_TobeStudiedProblemEN);
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
public List<clsvgs_TobeStudiedProblemEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvgs_TobeStudiedProblemDA:GetObjLstByTabName)", objException.Message));
}
List<clsvgs_TobeStudiedProblemEN> arrObjLst = new List<clsvgs_TobeStudiedProblemEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN();
try
{
objvgs_TobeStudiedProblemEN.ProblemId = objRow[convgs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvgs_TobeStudiedProblemEN.ProblemTitle = objRow[convgs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvgs_TobeStudiedProblemEN.ProblemContent = objRow[convgs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvgs_TobeStudiedProblemEN.TopicId = objRow[convgs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objvgs_TobeStudiedProblemEN.TopicName = objRow[convgs_TobeStudiedProblem.TopicName] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicName].ToString().Trim(); //栏目主题
objvgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[convgs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objRow[convgs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvgs_TobeStudiedProblemEN.ProblemDate = objRow[convgs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvgs_TobeStudiedProblemEN.UpdDate = objRow[convgs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvgs_TobeStudiedProblemEN.UpdUser = objRow[convgs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvgs_TobeStudiedProblemEN.Year = objRow[convgs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Year].ToString().Trim(); //年
objvgs_TobeStudiedProblemEN.Month = objRow[convgs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Month].ToString().Trim(); //月
objvgs_TobeStudiedProblemEN.VersionCount = objRow[convgs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvgs_TobeStudiedProblemEN.Participant = objRow[convgs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvgs_TobeStudiedProblemEN.Memo = objRow[convgs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_TobeStudiedProblemDA: GetObjLst)", objException.Message));
}
objvgs_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_TobeStudiedProblemEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvgs_TobeStudiedProblem(ref clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from vgs_TobeStudiedProblem where ProblemId = " + "'"+ objvgs_TobeStudiedProblemEN.ProblemId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvgs_TobeStudiedProblemEN.ProblemId = objDT.Rows[0][convgs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id(字段类型:char,字段长度:10,是否可空:False)
 objvgs_TobeStudiedProblemEN.ProblemTitle = objDT.Rows[0][convgs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_TobeStudiedProblemEN.ProblemContent = objDT.Rows[0][convgs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_TobeStudiedProblemEN.TopicId = objDT.Rows[0][convgs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_TobeStudiedProblemEN.TopicName = objDT.Rows[0][convgs_TobeStudiedProblem.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_TobeStudiedProblemEN.IdCurrEduCls = objDT.Rows[0][convgs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvgs_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objDT.Rows[0][convgs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_TobeStudiedProblemEN.ProblemDate = objDT.Rows[0][convgs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_TobeStudiedProblemEN.UpdDate = objDT.Rows[0][convgs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_TobeStudiedProblemEN.UpdUser = objDT.Rows[0][convgs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_TobeStudiedProblemEN.Year = objDT.Rows[0][convgs_TobeStudiedProblem.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objvgs_TobeStudiedProblemEN.Month = objDT.Rows[0][convgs_TobeStudiedProblem.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objvgs_TobeStudiedProblemEN.VersionCount = TransNullToInt(objDT.Rows[0][convgs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_TobeStudiedProblemEN.Participant = objDT.Rows[0][convgs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_TobeStudiedProblemEN.Memo = objDT.Rows[0][convgs_TobeStudiedProblem.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvgs_TobeStudiedProblemDA: Getvgs_TobeStudiedProblem)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strProblemId">表关键字</param>
 /// <returns>表对象</returns>
public clsvgs_TobeStudiedProblemEN GetObjByProblemId(string strProblemId)
{
CheckPrimaryKey(strProblemId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from vgs_TobeStudiedProblem where ProblemId = " + "'"+ strProblemId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN();
try
{
 objvgs_TobeStudiedProblemEN.ProblemId = objRow[convgs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id(字段类型:char,字段长度:10,是否可空:False)
 objvgs_TobeStudiedProblemEN.ProblemTitle = objRow[convgs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_TobeStudiedProblemEN.ProblemContent = objRow[convgs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_TobeStudiedProblemEN.TopicId = objRow[convgs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_TobeStudiedProblemEN.TopicName = objRow[convgs_TobeStudiedProblem.TopicName] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[convgs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_TobeStudiedProblemEN.ProblemDate = objRow[convgs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_TobeStudiedProblemEN.UpdDate = objRow[convgs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_TobeStudiedProblemEN.UpdUser = objRow[convgs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_TobeStudiedProblemEN.Year = objRow[convgs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objvgs_TobeStudiedProblemEN.Month = objRow[convgs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objvgs_TobeStudiedProblemEN.VersionCount = objRow[convgs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_TobeStudiedProblemEN.Participant = objRow[convgs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_TobeStudiedProblemEN.Memo = objRow[convgs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvgs_TobeStudiedProblemDA: GetObjByProblemId)", objException.Message));
}
return objvgs_TobeStudiedProblemEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvgs_TobeStudiedProblemEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvgs_TobeStudiedProblemDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from vgs_TobeStudiedProblem where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN()
{
ProblemId = objRow[convgs_TobeStudiedProblem.ProblemId].ToString().Trim(), //问题Id
ProblemTitle = objRow[convgs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemTitle].ToString().Trim(), //问题标题
ProblemContent = objRow[convgs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemContent].ToString().Trim(), //问题内容
TopicId = objRow[convgs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicId].ToString().Trim(), //主题Id
TopicName = objRow[convgs_TobeStudiedProblem.TopicName] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicName].ToString().Trim(), //栏目主题
IdCurrEduCls = objRow[convgs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(), //教学班流水号
IsSubmit = TransNullToBool(objRow[convgs_TobeStudiedProblem.IsSubmit].ToString().Trim()), //是否提交
ProblemDate = objRow[convgs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemDate].ToString().Trim(), //问题日期
UpdDate = objRow[convgs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convgs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdUser].ToString().Trim(), //修改人
Year = objRow[convgs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Year].ToString().Trim(), //年
Month = objRow[convgs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Month].ToString().Trim(), //月
VersionCount = objRow[convgs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_TobeStudiedProblem.VersionCount].ToString().Trim()), //版本统计
Participant = objRow[convgs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Participant].ToString().Trim(), //参与者
Memo = objRow[convgs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Memo].ToString().Trim() //备注
};
objvgs_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_TobeStudiedProblemEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvgs_TobeStudiedProblemDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvgs_TobeStudiedProblemEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN();
try
{
objvgs_TobeStudiedProblemEN.ProblemId = objRow[convgs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvgs_TobeStudiedProblemEN.ProblemTitle = objRow[convgs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvgs_TobeStudiedProblemEN.ProblemContent = objRow[convgs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvgs_TobeStudiedProblemEN.TopicId = objRow[convgs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objvgs_TobeStudiedProblemEN.TopicName = objRow[convgs_TobeStudiedProblem.TopicName] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicName].ToString().Trim(); //栏目主题
objvgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[convgs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objRow[convgs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvgs_TobeStudiedProblemEN.ProblemDate = objRow[convgs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvgs_TobeStudiedProblemEN.UpdDate = objRow[convgs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvgs_TobeStudiedProblemEN.UpdUser = objRow[convgs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvgs_TobeStudiedProblemEN.Year = objRow[convgs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Year].ToString().Trim(); //年
objvgs_TobeStudiedProblemEN.Month = objRow[convgs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Month].ToString().Trim(); //月
objvgs_TobeStudiedProblemEN.VersionCount = objRow[convgs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvgs_TobeStudiedProblemEN.Participant = objRow[convgs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvgs_TobeStudiedProblemEN.Memo = objRow[convgs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvgs_TobeStudiedProblemDA: GetObjByDataRowvgs_TobeStudiedProblem)", objException.Message));
}
objvgs_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_TobeStudiedProblemEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvgs_TobeStudiedProblemEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN();
try
{
objvgs_TobeStudiedProblemEN.ProblemId = objRow[convgs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvgs_TobeStudiedProblemEN.ProblemTitle = objRow[convgs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvgs_TobeStudiedProblemEN.ProblemContent = objRow[convgs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvgs_TobeStudiedProblemEN.TopicId = objRow[convgs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objvgs_TobeStudiedProblemEN.TopicName = objRow[convgs_TobeStudiedProblem.TopicName] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicName].ToString().Trim(); //栏目主题
objvgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[convgs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objRow[convgs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvgs_TobeStudiedProblemEN.ProblemDate = objRow[convgs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvgs_TobeStudiedProblemEN.UpdDate = objRow[convgs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvgs_TobeStudiedProblemEN.UpdUser = objRow[convgs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvgs_TobeStudiedProblemEN.Year = objRow[convgs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Year].ToString().Trim(); //年
objvgs_TobeStudiedProblemEN.Month = objRow[convgs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Month].ToString().Trim(); //月
objvgs_TobeStudiedProblemEN.VersionCount = objRow[convgs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvgs_TobeStudiedProblemEN.Participant = objRow[convgs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvgs_TobeStudiedProblemEN.Memo = objRow[convgs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvgs_TobeStudiedProblemDA: GetObjByDataRow)", objException.Message));
}
objvgs_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_TobeStudiedProblemEN;
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
objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_TobeStudiedProblemEN._CurrTabName, convgs_TobeStudiedProblem.ProblemId, 10, "");
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
objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_TobeStudiedProblemEN._CurrTabName, convgs_TobeStudiedProblem.ProblemId, 10, strPrefix);
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
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ProblemId from vgs_TobeStudiedProblem where " + strCondition;
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
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ProblemId from vgs_TobeStudiedProblem where " + strCondition;
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
 /// <param name = "strProblemId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strProblemId)
{
CheckPrimaryKey(strProblemId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_TobeStudiedProblem", "ProblemId = " + "'"+ strProblemId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvgs_TobeStudiedProblemDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_TobeStudiedProblem", strCondition))
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
objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vgs_TobeStudiedProblem");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemENS">源对象</param>
 /// <param name = "objvgs_TobeStudiedProblemENT">目标对象</param>
public void CopyTo(clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemENS, clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemENT)
{
objvgs_TobeStudiedProblemENT.ProblemId = objvgs_TobeStudiedProblemENS.ProblemId; //问题Id
objvgs_TobeStudiedProblemENT.ProblemTitle = objvgs_TobeStudiedProblemENS.ProblemTitle; //问题标题
objvgs_TobeStudiedProblemENT.ProblemContent = objvgs_TobeStudiedProblemENS.ProblemContent; //问题内容
objvgs_TobeStudiedProblemENT.TopicId = objvgs_TobeStudiedProblemENS.TopicId; //主题Id
objvgs_TobeStudiedProblemENT.TopicName = objvgs_TobeStudiedProblemENS.TopicName; //栏目主题
objvgs_TobeStudiedProblemENT.IdCurrEduCls = objvgs_TobeStudiedProblemENS.IdCurrEduCls; //教学班流水号
objvgs_TobeStudiedProblemENT.IsSubmit = objvgs_TobeStudiedProblemENS.IsSubmit; //是否提交
objvgs_TobeStudiedProblemENT.ProblemDate = objvgs_TobeStudiedProblemENS.ProblemDate; //问题日期
objvgs_TobeStudiedProblemENT.UpdDate = objvgs_TobeStudiedProblemENS.UpdDate; //修改日期
objvgs_TobeStudiedProblemENT.UpdUser = objvgs_TobeStudiedProblemENS.UpdUser; //修改人
objvgs_TobeStudiedProblemENT.Year = objvgs_TobeStudiedProblemENS.Year; //年
objvgs_TobeStudiedProblemENT.Month = objvgs_TobeStudiedProblemENS.Month; //月
objvgs_TobeStudiedProblemENT.VersionCount = objvgs_TobeStudiedProblemENS.VersionCount; //版本统计
objvgs_TobeStudiedProblemENT.Participant = objvgs_TobeStudiedProblemENS.Participant; //参与者
objvgs_TobeStudiedProblemENT.Memo = objvgs_TobeStudiedProblemENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvgs_TobeStudiedProblemEN.ProblemId, 10, convgs_TobeStudiedProblem.ProblemId);
clsCheckSql.CheckFieldLen(objvgs_TobeStudiedProblemEN.ProblemTitle, 1000, convgs_TobeStudiedProblem.ProblemTitle);
clsCheckSql.CheckFieldLen(objvgs_TobeStudiedProblemEN.TopicId, 8, convgs_TobeStudiedProblem.TopicId);
clsCheckSql.CheckFieldLen(objvgs_TobeStudiedProblemEN.TopicName, 200, convgs_TobeStudiedProblem.TopicName);
clsCheckSql.CheckFieldLen(objvgs_TobeStudiedProblemEN.IdCurrEduCls, 8, convgs_TobeStudiedProblem.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvgs_TobeStudiedProblemEN.ProblemDate, 20, convgs_TobeStudiedProblem.ProblemDate);
clsCheckSql.CheckFieldLen(objvgs_TobeStudiedProblemEN.UpdDate, 20, convgs_TobeStudiedProblem.UpdDate);
clsCheckSql.CheckFieldLen(objvgs_TobeStudiedProblemEN.UpdUser, 20, convgs_TobeStudiedProblem.UpdUser);
clsCheckSql.CheckFieldLen(objvgs_TobeStudiedProblemEN.Year, 4, convgs_TobeStudiedProblem.Year);
clsCheckSql.CheckFieldLen(objvgs_TobeStudiedProblemEN.Month, 2, convgs_TobeStudiedProblem.Month);
clsCheckSql.CheckFieldLen(objvgs_TobeStudiedProblemEN.Participant, 500, convgs_TobeStudiedProblem.Participant);
clsCheckSql.CheckFieldLen(objvgs_TobeStudiedProblemEN.Memo, 1000, convgs_TobeStudiedProblem.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvgs_TobeStudiedProblemEN.ProblemId, convgs_TobeStudiedProblem.ProblemId);
clsCheckSql.CheckSqlInjection4Field(objvgs_TobeStudiedProblemEN.ProblemTitle, convgs_TobeStudiedProblem.ProblemTitle);
clsCheckSql.CheckSqlInjection4Field(objvgs_TobeStudiedProblemEN.TopicId, convgs_TobeStudiedProblem.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvgs_TobeStudiedProblemEN.TopicName, convgs_TobeStudiedProblem.TopicName);
clsCheckSql.CheckSqlInjection4Field(objvgs_TobeStudiedProblemEN.IdCurrEduCls, convgs_TobeStudiedProblem.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvgs_TobeStudiedProblemEN.ProblemDate, convgs_TobeStudiedProblem.ProblemDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_TobeStudiedProblemEN.UpdDate, convgs_TobeStudiedProblem.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_TobeStudiedProblemEN.UpdUser, convgs_TobeStudiedProblem.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_TobeStudiedProblemEN.Year, convgs_TobeStudiedProblem.Year);
clsCheckSql.CheckSqlInjection4Field(objvgs_TobeStudiedProblemEN.Month, convgs_TobeStudiedProblem.Month);
clsCheckSql.CheckSqlInjection4Field(objvgs_TobeStudiedProblemEN.Participant, convgs_TobeStudiedProblem.Participant);
clsCheckSql.CheckSqlInjection4Field(objvgs_TobeStudiedProblemEN.Memo, convgs_TobeStudiedProblem.Memo);
//检查外键字段长度
 objvgs_TobeStudiedProblemEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vgs_TobeStudiedProblem(待研究问题视图),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ProblemId = '{0}'", objvgs_TobeStudiedProblemEN.ProblemId);
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
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
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
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
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
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_TobeStudiedProblemEN._CurrTabName);
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
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_TobeStudiedProblemEN._CurrTabName, strCondition);
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
 objSQL = clsvgs_TobeStudiedProblemDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}