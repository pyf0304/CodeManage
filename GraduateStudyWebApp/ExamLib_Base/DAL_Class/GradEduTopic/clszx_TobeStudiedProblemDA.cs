
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TobeStudiedProblemDA
 表名:zx_TobeStudiedProblem(01120804)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:38
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 中学待研究问题(zx_TobeStudiedProblem)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_TobeStudiedProblemDA : clsCommBase4DA
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
 return clszx_TobeStudiedProblemEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_TobeStudiedProblemEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TobeStudiedProblemEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_TobeStudiedProblemEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_TobeStudiedProblemEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:zx_TobeStudiedProblem中,检查关键字,长度不正确!(clszx_TobeStudiedProblemDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strProblemId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_TobeStudiedProblem中,关键字不能为空 或 null!(clszx_TobeStudiedProblemDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strProblemId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_TobeStudiedProblemDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblem where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_TobeStudiedProblem(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemDA: GetDataTable_zx_TobeStudiedProblem)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblem where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblem where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TobeStudiedProblem where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TobeStudiedProblem where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_TobeStudiedProblem where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_TobeStudiedProblemDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_TobeStudiedProblem.* from zx_TobeStudiedProblem Left Join {1} on {2} where {3} and zx_TobeStudiedProblem.ProblemId not in (Select top {5} zx_TobeStudiedProblem.ProblemId from zx_TobeStudiedProblem Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TobeStudiedProblem where {1} and ProblemId not in (Select top {2} ProblemId from zx_TobeStudiedProblem where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TobeStudiedProblem where {1} and ProblemId not in (Select top {3} ProblemId from zx_TobeStudiedProblem where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_TobeStudiedProblemDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_TobeStudiedProblem.* from zx_TobeStudiedProblem Left Join {1} on {2} where {3} and zx_TobeStudiedProblem.ProblemId not in (Select top {5} zx_TobeStudiedProblem.ProblemId from zx_TobeStudiedProblem Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TobeStudiedProblem where {1} and ProblemId not in (Select top {2} ProblemId from zx_TobeStudiedProblem where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TobeStudiedProblem where {1} and ProblemId not in (Select top {3} ProblemId from zx_TobeStudiedProblem where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_TobeStudiedProblemEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemDA:GetObjLst)", objException.Message));
}
List<clszx_TobeStudiedProblemEN> arrObjLst = new List<clszx_TobeStudiedProblemEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblem where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN = new clszx_TobeStudiedProblemEN();
try
{
objzx_TobeStudiedProblemEN.ProblemId = objRow[conzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemEN.ProblemTitle = objRow[conzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objzx_TobeStudiedProblemEN.ProblemContent = objRow[conzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemEN.GroupTextId = objRow[conzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objRow[conzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemEN.ProblemDate = objRow[conzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemEN.UpdDate = objRow[conzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemEN.UpdUser = objRow[conzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemEN.Year = objRow[conzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemEN.Month = objRow[conzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemEN.VersionCount = objRow[conzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objzx_TobeStudiedProblemEN.Participant = objRow[conzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemEN.Memo = objRow[conzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[conzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_TobeStudiedProblemDA: GetObjLst)", objException.Message));
}
objzx_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_TobeStudiedProblemEN);
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
public List<clszx_TobeStudiedProblemEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_TobeStudiedProblemEN> arrObjLst = new List<clszx_TobeStudiedProblemEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN = new clszx_TobeStudiedProblemEN();
try
{
objzx_TobeStudiedProblemEN.ProblemId = objRow[conzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemEN.ProblemTitle = objRow[conzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objzx_TobeStudiedProblemEN.ProblemContent = objRow[conzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemEN.GroupTextId = objRow[conzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objRow[conzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemEN.ProblemDate = objRow[conzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemEN.UpdDate = objRow[conzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemEN.UpdUser = objRow[conzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemEN.Year = objRow[conzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemEN.Month = objRow[conzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemEN.VersionCount = objRow[conzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objzx_TobeStudiedProblemEN.Participant = objRow[conzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemEN.Memo = objRow[conzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[conzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_TobeStudiedProblemDA: GetObjLst)", objException.Message));
}
objzx_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_TobeStudiedProblemEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_TobeStudiedProblem(ref clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblem where ProblemId = " + "'"+ objzx_TobeStudiedProblemEN.ProblemId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_TobeStudiedProblemEN.ProblemId = objDT.Rows[0][conzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_TobeStudiedProblemEN.ProblemTitle = objDT.Rows[0][conzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TobeStudiedProblemEN.ProblemContent = objDT.Rows[0][conzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_TobeStudiedProblemEN.GroupTextId = objDT.Rows[0][conzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TobeStudiedProblemEN.ProblemDate = objDT.Rows[0][conzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TobeStudiedProblemEN.UpdDate = objDT.Rows[0][conzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TobeStudiedProblemEN.UpdUser = objDT.Rows[0][conzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TobeStudiedProblemEN.Year = objDT.Rows[0][conzx_TobeStudiedProblem.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objzx_TobeStudiedProblemEN.Month = objDT.Rows[0][conzx_TobeStudiedProblem.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objzx_TobeStudiedProblemEN.VersionCount = TransNullToInt(objDT.Rows[0][conzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_TobeStudiedProblemEN.Participant = objDT.Rows[0][conzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_TobeStudiedProblemEN.Memo = objDT.Rows[0][conzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TobeStudiedProblemEN.IdCurrEduCls = objDT.Rows[0][conzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_TobeStudiedProblemDA: Getzx_TobeStudiedProblem)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strProblemId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_TobeStudiedProblemEN GetObjByProblemId(string strProblemId)
{
CheckPrimaryKey(strProblemId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblem where ProblemId = " + "'"+ strProblemId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN = new clszx_TobeStudiedProblemEN();
try
{
 objzx_TobeStudiedProblemEN.ProblemId = objRow[conzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_TobeStudiedProblemEN.ProblemTitle = objRow[conzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TobeStudiedProblemEN.ProblemContent = objRow[conzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_TobeStudiedProblemEN.GroupTextId = objRow[conzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TobeStudiedProblemEN.ProblemDate = objRow[conzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TobeStudiedProblemEN.UpdDate = objRow[conzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TobeStudiedProblemEN.UpdUser = objRow[conzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TobeStudiedProblemEN.Year = objRow[conzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objzx_TobeStudiedProblemEN.Month = objRow[conzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objzx_TobeStudiedProblemEN.VersionCount = objRow[conzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_TobeStudiedProblemEN.Participant = objRow[conzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_TobeStudiedProblemEN.Memo = objRow[conzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[conzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_TobeStudiedProblemDA: GetObjByProblemId)", objException.Message));
}
return objzx_TobeStudiedProblemEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_TobeStudiedProblemEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblem where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN = new clszx_TobeStudiedProblemEN()
{
ProblemId = objRow[conzx_TobeStudiedProblem.ProblemId].ToString().Trim(), //问题Id
ProblemTitle = objRow[conzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(), //问题标题
ProblemContent = objRow[conzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemContent].ToString().Trim(), //问题内容
GroupTextId = objRow[conzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.GroupTextId].ToString().Trim(), //小组Id
IsSubmit = TransNullToBool(objRow[conzx_TobeStudiedProblem.IsSubmit].ToString().Trim()), //是否提交
ProblemDate = objRow[conzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemDate].ToString().Trim(), //问题日期
UpdDate = objRow[conzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.UpdUser].ToString().Trim(), //修改人
Year = objRow[conzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Year].ToString().Trim(), //年
Month = objRow[conzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Month].ToString().Trim(), //月
VersionCount = objRow[conzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TobeStudiedProblem.VersionCount].ToString().Trim()), //版本统计
Participant = objRow[conzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Participant].ToString().Trim(), //参与者
Memo = objRow[conzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Memo].ToString().Trim(), //备注
IdCurrEduCls = objRow[conzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim() //教学班流水号
};
objzx_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TobeStudiedProblemEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_TobeStudiedProblemDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_TobeStudiedProblemEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN = new clszx_TobeStudiedProblemEN();
try
{
objzx_TobeStudiedProblemEN.ProblemId = objRow[conzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemEN.ProblemTitle = objRow[conzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objzx_TobeStudiedProblemEN.ProblemContent = objRow[conzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemEN.GroupTextId = objRow[conzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objRow[conzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemEN.ProblemDate = objRow[conzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemEN.UpdDate = objRow[conzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemEN.UpdUser = objRow[conzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemEN.Year = objRow[conzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemEN.Month = objRow[conzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemEN.VersionCount = objRow[conzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objzx_TobeStudiedProblemEN.Participant = objRow[conzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemEN.Memo = objRow[conzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[conzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_TobeStudiedProblemDA: GetObjByDataRowzx_TobeStudiedProblem)", objException.Message));
}
objzx_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TobeStudiedProblemEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_TobeStudiedProblemEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN = new clszx_TobeStudiedProblemEN();
try
{
objzx_TobeStudiedProblemEN.ProblemId = objRow[conzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemEN.ProblemTitle = objRow[conzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objzx_TobeStudiedProblemEN.ProblemContent = objRow[conzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemEN.GroupTextId = objRow[conzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemEN.IsSubmit = TransNullToBool(objRow[conzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemEN.ProblemDate = objRow[conzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemEN.UpdDate = objRow[conzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemEN.UpdUser = objRow[conzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemEN.Year = objRow[conzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemEN.Month = objRow[conzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemEN.VersionCount = objRow[conzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objzx_TobeStudiedProblemEN.Participant = objRow[conzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemEN.Memo = objRow[conzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[conzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_TobeStudiedProblemDA: GetObjByDataRow)", objException.Message));
}
objzx_TobeStudiedProblemEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TobeStudiedProblemEN;
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
objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_TobeStudiedProblemEN._CurrTabName, conzx_TobeStudiedProblem.ProblemId, 10, "");
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
objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_TobeStudiedProblemEN._CurrTabName, conzx_TobeStudiedProblem.ProblemId, 10, strPrefix);
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
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ProblemId from zx_TobeStudiedProblem where " + strCondition;
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
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ProblemId from zx_TobeStudiedProblem where " + strCondition;
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
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_TobeStudiedProblem", "ProblemId = " + "'"+ strProblemId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_TobeStudiedProblem", strCondition))
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
objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_TobeStudiedProblem");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN)
 {
 if (objzx_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TobeStudiedProblemEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblem where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_TobeStudiedProblem");
objRow = objDS.Tables["zx_TobeStudiedProblem"].NewRow();
objRow[conzx_TobeStudiedProblem.ProblemId] = objzx_TobeStudiedProblemEN.ProblemId; //问题Id
 if (objzx_TobeStudiedProblemEN.ProblemTitle !=  "")
 {
objRow[conzx_TobeStudiedProblem.ProblemTitle] = objzx_TobeStudiedProblemEN.ProblemTitle; //问题标题
 }
 if (objzx_TobeStudiedProblemEN.ProblemContent !=  "")
 {
objRow[conzx_TobeStudiedProblem.ProblemContent] = objzx_TobeStudiedProblemEN.ProblemContent; //问题内容
 }
 if (objzx_TobeStudiedProblemEN.GroupTextId !=  "")
 {
objRow[conzx_TobeStudiedProblem.GroupTextId] = objzx_TobeStudiedProblemEN.GroupTextId; //小组Id
 }
objRow[conzx_TobeStudiedProblem.IsSubmit] = objzx_TobeStudiedProblemEN.IsSubmit; //是否提交
 if (objzx_TobeStudiedProblemEN.ProblemDate !=  "")
 {
objRow[conzx_TobeStudiedProblem.ProblemDate] = objzx_TobeStudiedProblemEN.ProblemDate; //问题日期
 }
 if (objzx_TobeStudiedProblemEN.UpdDate !=  "")
 {
objRow[conzx_TobeStudiedProblem.UpdDate] = objzx_TobeStudiedProblemEN.UpdDate; //修改日期
 }
 if (objzx_TobeStudiedProblemEN.UpdUser !=  "")
 {
objRow[conzx_TobeStudiedProblem.UpdUser] = objzx_TobeStudiedProblemEN.UpdUser; //修改人
 }
 if (objzx_TobeStudiedProblemEN.Year !=  "")
 {
objRow[conzx_TobeStudiedProblem.Year] = objzx_TobeStudiedProblemEN.Year; //年
 }
 if (objzx_TobeStudiedProblemEN.Month !=  "")
 {
objRow[conzx_TobeStudiedProblem.Month] = objzx_TobeStudiedProblemEN.Month; //月
 }
objRow[conzx_TobeStudiedProblem.VersionCount] = objzx_TobeStudiedProblemEN.VersionCount; //版本统计
 if (objzx_TobeStudiedProblemEN.Participant !=  "")
 {
objRow[conzx_TobeStudiedProblem.Participant] = objzx_TobeStudiedProblemEN.Participant; //参与者
 }
 if (objzx_TobeStudiedProblemEN.Memo !=  "")
 {
objRow[conzx_TobeStudiedProblem.Memo] = objzx_TobeStudiedProblemEN.Memo; //备注
 }
objRow[conzx_TobeStudiedProblem.IdCurrEduCls] = objzx_TobeStudiedProblemEN.IdCurrEduCls; //教学班流水号
objDS.Tables[clszx_TobeStudiedProblemEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_TobeStudiedProblemEN._CurrTabName);
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
 /// <param name = "objzx_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN)
{
 if (objzx_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TobeStudiedProblemEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TobeStudiedProblemEN.ProblemId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.ProblemId);
 var strProblemId = objzx_TobeStudiedProblemEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemId + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.ProblemTitle !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.ProblemTitle);
 var strProblemTitle = objzx_TobeStudiedProblemEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemTitle + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.ProblemContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.ProblemContent);
 var strProblemContent = objzx_TobeStudiedProblemEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemContent + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.GroupTextId);
 var strGroupTextId = objzx_TobeStudiedProblemEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TobeStudiedProblemEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_TobeStudiedProblemEN.ProblemDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.ProblemDate);
 var strProblemDate = objzx_TobeStudiedProblemEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemDate + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.UpdDate);
 var strUpdDate = objzx_TobeStudiedProblemEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.UpdUser);
 var strUpdUser = objzx_TobeStudiedProblemEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.Year !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.Year);
 var strYear = objzx_TobeStudiedProblemEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.Month);
 var strMonth = objzx_TobeStudiedProblemEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.VersionCount);
 arrValueListForInsert.Add(objzx_TobeStudiedProblemEN.VersionCount.ToString());
 }
 
 if (objzx_TobeStudiedProblemEN.Participant !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.Participant);
 var strParticipant = objzx_TobeStudiedProblemEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipant + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.Memo);
 var strMemo = objzx_TobeStudiedProblemEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TobeStudiedProblemEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TobeStudiedProblem");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN)
{
 if (objzx_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TobeStudiedProblemEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TobeStudiedProblemEN.ProblemId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.ProblemId);
 var strProblemId = objzx_TobeStudiedProblemEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemId + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.ProblemTitle !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.ProblemTitle);
 var strProblemTitle = objzx_TobeStudiedProblemEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemTitle + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.ProblemContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.ProblemContent);
 var strProblemContent = objzx_TobeStudiedProblemEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemContent + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.GroupTextId);
 var strGroupTextId = objzx_TobeStudiedProblemEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TobeStudiedProblemEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_TobeStudiedProblemEN.ProblemDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.ProblemDate);
 var strProblemDate = objzx_TobeStudiedProblemEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemDate + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.UpdDate);
 var strUpdDate = objzx_TobeStudiedProblemEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.UpdUser);
 var strUpdUser = objzx_TobeStudiedProblemEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.Year !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.Year);
 var strYear = objzx_TobeStudiedProblemEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.Month);
 var strMonth = objzx_TobeStudiedProblemEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.VersionCount);
 arrValueListForInsert.Add(objzx_TobeStudiedProblemEN.VersionCount.ToString());
 }
 
 if (objzx_TobeStudiedProblemEN.Participant !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.Participant);
 var strParticipant = objzx_TobeStudiedProblemEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipant + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.Memo);
 var strMemo = objzx_TobeStudiedProblemEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TobeStudiedProblemEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TobeStudiedProblem");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_TobeStudiedProblemEN.ProblemId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TobeStudiedProblemEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TobeStudiedProblemEN.ProblemId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.ProblemId);
 var strProblemId = objzx_TobeStudiedProblemEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemId + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.ProblemTitle !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.ProblemTitle);
 var strProblemTitle = objzx_TobeStudiedProblemEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemTitle + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.ProblemContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.ProblemContent);
 var strProblemContent = objzx_TobeStudiedProblemEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemContent + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.GroupTextId);
 var strGroupTextId = objzx_TobeStudiedProblemEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TobeStudiedProblemEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_TobeStudiedProblemEN.ProblemDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.ProblemDate);
 var strProblemDate = objzx_TobeStudiedProblemEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemDate + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.UpdDate);
 var strUpdDate = objzx_TobeStudiedProblemEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.UpdUser);
 var strUpdUser = objzx_TobeStudiedProblemEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.Year !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.Year);
 var strYear = objzx_TobeStudiedProblemEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.Month);
 var strMonth = objzx_TobeStudiedProblemEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.VersionCount);
 arrValueListForInsert.Add(objzx_TobeStudiedProblemEN.VersionCount.ToString());
 }
 
 if (objzx_TobeStudiedProblemEN.Participant !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.Participant);
 var strParticipant = objzx_TobeStudiedProblemEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipant + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.Memo);
 var strMemo = objzx_TobeStudiedProblemEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TobeStudiedProblemEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TobeStudiedProblem");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_TobeStudiedProblemEN.ProblemId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TobeStudiedProblemEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TobeStudiedProblemEN.ProblemId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.ProblemId);
 var strProblemId = objzx_TobeStudiedProblemEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemId + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.ProblemTitle !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.ProblemTitle);
 var strProblemTitle = objzx_TobeStudiedProblemEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemTitle + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.ProblemContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.ProblemContent);
 var strProblemContent = objzx_TobeStudiedProblemEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemContent + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.GroupTextId);
 var strGroupTextId = objzx_TobeStudiedProblemEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TobeStudiedProblemEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_TobeStudiedProblemEN.ProblemDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.ProblemDate);
 var strProblemDate = objzx_TobeStudiedProblemEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemDate + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.UpdDate);
 var strUpdDate = objzx_TobeStudiedProblemEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.UpdUser);
 var strUpdUser = objzx_TobeStudiedProblemEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.Year !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.Year);
 var strYear = objzx_TobeStudiedProblemEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.Month);
 var strMonth = objzx_TobeStudiedProblemEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.VersionCount);
 arrValueListForInsert.Add(objzx_TobeStudiedProblemEN.VersionCount.ToString());
 }
 
 if (objzx_TobeStudiedProblemEN.Participant !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.Participant);
 var strParticipant = objzx_TobeStudiedProblemEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipant + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.Memo);
 var strMemo = objzx_TobeStudiedProblemEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TobeStudiedProblemEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblem.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TobeStudiedProblemEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TobeStudiedProblem");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_TobeStudiedProblems(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblem where ProblemId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_TobeStudiedProblem");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strProblemId = oRow[conzx_TobeStudiedProblem.ProblemId].ToString().Trim();
if (IsExist(strProblemId))
{
 string strResult = "关键字变量值为:" + string.Format("ProblemId = {0}", strProblemId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_TobeStudiedProblemEN._CurrTabName ].NewRow();
objRow[conzx_TobeStudiedProblem.ProblemId] = oRow[conzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objRow[conzx_TobeStudiedProblem.ProblemTitle] = oRow[conzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objRow[conzx_TobeStudiedProblem.ProblemContent] = oRow[conzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objRow[conzx_TobeStudiedProblem.GroupTextId] = oRow[conzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objRow[conzx_TobeStudiedProblem.IsSubmit] = oRow[conzx_TobeStudiedProblem.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_TobeStudiedProblem.ProblemDate] = oRow[conzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objRow[conzx_TobeStudiedProblem.UpdDate] = oRow[conzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_TobeStudiedProblem.UpdUser] = oRow[conzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objRow[conzx_TobeStudiedProblem.Year] = oRow[conzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objRow[conzx_TobeStudiedProblem.Month] = oRow[conzx_TobeStudiedProblem.Month].ToString().Trim(); //月
objRow[conzx_TobeStudiedProblem.VersionCount] = oRow[conzx_TobeStudiedProblem.VersionCount].ToString().Trim(); //版本统计
objRow[conzx_TobeStudiedProblem.Participant] = oRow[conzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objRow[conzx_TobeStudiedProblem.Memo] = oRow[conzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objRow[conzx_TobeStudiedProblem.IdCurrEduCls] = oRow[conzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
 objDS.Tables[clszx_TobeStudiedProblemEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_TobeStudiedProblemEN._CurrTabName);
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
 /// <param name = "objzx_TobeStudiedProblemEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN)
{
 if (objzx_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TobeStudiedProblemEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblem where ProblemId = " + "'"+ objzx_TobeStudiedProblemEN.ProblemId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_TobeStudiedProblemEN._CurrTabName);
if (objDS.Tables[clszx_TobeStudiedProblemEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ProblemId = " + "'"+ objzx_TobeStudiedProblemEN.ProblemId+"'");
return false;
}
objRow = objDS.Tables[clszx_TobeStudiedProblemEN._CurrTabName].Rows[0];
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.ProblemId))
 {
objRow[conzx_TobeStudiedProblem.ProblemId] = objzx_TobeStudiedProblemEN.ProblemId; //问题Id
 }
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.ProblemTitle))
 {
objRow[conzx_TobeStudiedProblem.ProblemTitle] = objzx_TobeStudiedProblemEN.ProblemTitle; //问题标题
 }
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.ProblemContent))
 {
objRow[conzx_TobeStudiedProblem.ProblemContent] = objzx_TobeStudiedProblemEN.ProblemContent; //问题内容
 }
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.GroupTextId))
 {
objRow[conzx_TobeStudiedProblem.GroupTextId] = objzx_TobeStudiedProblemEN.GroupTextId; //小组Id
 }
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.IsSubmit))
 {
objRow[conzx_TobeStudiedProblem.IsSubmit] = objzx_TobeStudiedProblemEN.IsSubmit; //是否提交
 }
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.ProblemDate))
 {
objRow[conzx_TobeStudiedProblem.ProblemDate] = objzx_TobeStudiedProblemEN.ProblemDate; //问题日期
 }
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.UpdDate))
 {
objRow[conzx_TobeStudiedProblem.UpdDate] = objzx_TobeStudiedProblemEN.UpdDate; //修改日期
 }
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.UpdUser))
 {
objRow[conzx_TobeStudiedProblem.UpdUser] = objzx_TobeStudiedProblemEN.UpdUser; //修改人
 }
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Year))
 {
objRow[conzx_TobeStudiedProblem.Year] = objzx_TobeStudiedProblemEN.Year; //年
 }
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Month))
 {
objRow[conzx_TobeStudiedProblem.Month] = objzx_TobeStudiedProblemEN.Month; //月
 }
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.VersionCount))
 {
objRow[conzx_TobeStudiedProblem.VersionCount] = objzx_TobeStudiedProblemEN.VersionCount; //版本统计
 }
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Participant))
 {
objRow[conzx_TobeStudiedProblem.Participant] = objzx_TobeStudiedProblemEN.Participant; //参与者
 }
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Memo))
 {
objRow[conzx_TobeStudiedProblem.Memo] = objzx_TobeStudiedProblemEN.Memo; //备注
 }
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.IdCurrEduCls))
 {
objRow[conzx_TobeStudiedProblem.IdCurrEduCls] = objzx_TobeStudiedProblemEN.IdCurrEduCls; //教学班流水号
 }
try
{
objDA.Update(objDS, clszx_TobeStudiedProblemEN._CurrTabName);
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
 /// <param name = "objzx_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN)
{
 if (objzx_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TobeStudiedProblemEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_TobeStudiedProblem Set ");
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.ProblemTitle))
 {
 if (objzx_TobeStudiedProblemEN.ProblemTitle !=  null)
 {
 var strProblemTitle = objzx_TobeStudiedProblemEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemTitle, conzx_TobeStudiedProblem.ProblemTitle); //问题标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.ProblemTitle); //问题标题
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.ProblemContent))
 {
 if (objzx_TobeStudiedProblemEN.ProblemContent !=  null)
 {
 var strProblemContent = objzx_TobeStudiedProblemEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemContent, conzx_TobeStudiedProblem.ProblemContent); //问题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.ProblemContent); //问题内容
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.GroupTextId))
 {
 if (objzx_TobeStudiedProblemEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_TobeStudiedProblemEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_TobeStudiedProblem.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.GroupTextId); //小组Id
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TobeStudiedProblemEN.IsSubmit == true?"1":"0", conzx_TobeStudiedProblem.IsSubmit); //是否提交
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.ProblemDate))
 {
 if (objzx_TobeStudiedProblemEN.ProblemDate !=  null)
 {
 var strProblemDate = objzx_TobeStudiedProblemEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemDate, conzx_TobeStudiedProblem.ProblemDate); //问题日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.ProblemDate); //问题日期
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.UpdDate))
 {
 if (objzx_TobeStudiedProblemEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TobeStudiedProblemEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_TobeStudiedProblem.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.UpdDate); //修改日期
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.UpdUser))
 {
 if (objzx_TobeStudiedProblemEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TobeStudiedProblemEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_TobeStudiedProblem.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.UpdUser); //修改人
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Year))
 {
 if (objzx_TobeStudiedProblemEN.Year !=  null)
 {
 var strYear = objzx_TobeStudiedProblemEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYear, conzx_TobeStudiedProblem.Year); //年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.Year); //年
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Month))
 {
 if (objzx_TobeStudiedProblemEN.Month !=  null)
 {
 var strMonth = objzx_TobeStudiedProblemEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMonth, conzx_TobeStudiedProblem.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.Month); //月
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.VersionCount))
 {
 if (objzx_TobeStudiedProblemEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TobeStudiedProblemEN.VersionCount, conzx_TobeStudiedProblem.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.VersionCount); //版本统计
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Participant))
 {
 if (objzx_TobeStudiedProblemEN.Participant !=  null)
 {
 var strParticipant = objzx_TobeStudiedProblemEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParticipant, conzx_TobeStudiedProblem.Participant); //参与者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.Participant); //参与者
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Memo))
 {
 if (objzx_TobeStudiedProblemEN.Memo !=  null)
 {
 var strMemo = objzx_TobeStudiedProblemEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_TobeStudiedProblem.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.Memo); //备注
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.IdCurrEduCls))
 {
 if (objzx_TobeStudiedProblemEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TobeStudiedProblemEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_TobeStudiedProblem.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.IdCurrEduCls); //教学班流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ProblemId = '{0}'", objzx_TobeStudiedProblemEN.ProblemId); 
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
 /// <param name = "objzx_TobeStudiedProblemEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN, string strCondition)
{
 if (objzx_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TobeStudiedProblemEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TobeStudiedProblem Set ");
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.ProblemTitle))
 {
 if (objzx_TobeStudiedProblemEN.ProblemTitle !=  null)
 {
 var strProblemTitle = objzx_TobeStudiedProblemEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemTitle = '{0}',", strProblemTitle); //问题标题
 }
 else
 {
 sbSQL.Append(" ProblemTitle = null,"); //问题标题
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.ProblemContent))
 {
 if (objzx_TobeStudiedProblemEN.ProblemContent !=  null)
 {
 var strProblemContent = objzx_TobeStudiedProblemEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemContent = '{0}',", strProblemContent); //问题内容
 }
 else
 {
 sbSQL.Append(" ProblemContent = null,"); //问题内容
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.GroupTextId))
 {
 if (objzx_TobeStudiedProblemEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_TobeStudiedProblemEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_TobeStudiedProblemEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.ProblemDate))
 {
 if (objzx_TobeStudiedProblemEN.ProblemDate !=  null)
 {
 var strProblemDate = objzx_TobeStudiedProblemEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemDate = '{0}',", strProblemDate); //问题日期
 }
 else
 {
 sbSQL.Append(" ProblemDate = null,"); //问题日期
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.UpdDate))
 {
 if (objzx_TobeStudiedProblemEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TobeStudiedProblemEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.UpdUser))
 {
 if (objzx_TobeStudiedProblemEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TobeStudiedProblemEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Year))
 {
 if (objzx_TobeStudiedProblemEN.Year !=  null)
 {
 var strYear = objzx_TobeStudiedProblemEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Year = '{0}',", strYear); //年
 }
 else
 {
 sbSQL.Append(" Year = null,"); //年
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Month))
 {
 if (objzx_TobeStudiedProblemEN.Month !=  null)
 {
 var strMonth = objzx_TobeStudiedProblemEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Month = '{0}',", strMonth); //月
 }
 else
 {
 sbSQL.Append(" Month = null,"); //月
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.VersionCount))
 {
 if (objzx_TobeStudiedProblemEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TobeStudiedProblemEN.VersionCount, conzx_TobeStudiedProblem.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.VersionCount); //版本统计
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Participant))
 {
 if (objzx_TobeStudiedProblemEN.Participant !=  null)
 {
 var strParticipant = objzx_TobeStudiedProblemEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Participant = '{0}',", strParticipant); //参与者
 }
 else
 {
 sbSQL.Append(" Participant = null,"); //参与者
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Memo))
 {
 if (objzx_TobeStudiedProblemEN.Memo !=  null)
 {
 var strMemo = objzx_TobeStudiedProblemEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.IdCurrEduCls))
 {
 if (objzx_TobeStudiedProblemEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TobeStudiedProblemEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_TobeStudiedProblemEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TobeStudiedProblemEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TobeStudiedProblem Set ");
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.ProblemTitle))
 {
 if (objzx_TobeStudiedProblemEN.ProblemTitle !=  null)
 {
 var strProblemTitle = objzx_TobeStudiedProblemEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemTitle = '{0}',", strProblemTitle); //问题标题
 }
 else
 {
 sbSQL.Append(" ProblemTitle = null,"); //问题标题
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.ProblemContent))
 {
 if (objzx_TobeStudiedProblemEN.ProblemContent !=  null)
 {
 var strProblemContent = objzx_TobeStudiedProblemEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemContent = '{0}',", strProblemContent); //问题内容
 }
 else
 {
 sbSQL.Append(" ProblemContent = null,"); //问题内容
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.GroupTextId))
 {
 if (objzx_TobeStudiedProblemEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_TobeStudiedProblemEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_TobeStudiedProblemEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.ProblemDate))
 {
 if (objzx_TobeStudiedProblemEN.ProblemDate !=  null)
 {
 var strProblemDate = objzx_TobeStudiedProblemEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemDate = '{0}',", strProblemDate); //问题日期
 }
 else
 {
 sbSQL.Append(" ProblemDate = null,"); //问题日期
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.UpdDate))
 {
 if (objzx_TobeStudiedProblemEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TobeStudiedProblemEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.UpdUser))
 {
 if (objzx_TobeStudiedProblemEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TobeStudiedProblemEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Year))
 {
 if (objzx_TobeStudiedProblemEN.Year !=  null)
 {
 var strYear = objzx_TobeStudiedProblemEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Year = '{0}',", strYear); //年
 }
 else
 {
 sbSQL.Append(" Year = null,"); //年
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Month))
 {
 if (objzx_TobeStudiedProblemEN.Month !=  null)
 {
 var strMonth = objzx_TobeStudiedProblemEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Month = '{0}',", strMonth); //月
 }
 else
 {
 sbSQL.Append(" Month = null,"); //月
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.VersionCount))
 {
 if (objzx_TobeStudiedProblemEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TobeStudiedProblemEN.VersionCount, conzx_TobeStudiedProblem.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.VersionCount); //版本统计
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Participant))
 {
 if (objzx_TobeStudiedProblemEN.Participant !=  null)
 {
 var strParticipant = objzx_TobeStudiedProblemEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Participant = '{0}',", strParticipant); //参与者
 }
 else
 {
 sbSQL.Append(" Participant = null,"); //参与者
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Memo))
 {
 if (objzx_TobeStudiedProblemEN.Memo !=  null)
 {
 var strMemo = objzx_TobeStudiedProblemEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.IdCurrEduCls))
 {
 if (objzx_TobeStudiedProblemEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TobeStudiedProblemEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_TobeStudiedProblemEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TobeStudiedProblemEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TobeStudiedProblem Set ");
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.ProblemTitle))
 {
 if (objzx_TobeStudiedProblemEN.ProblemTitle !=  null)
 {
 var strProblemTitle = objzx_TobeStudiedProblemEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemTitle, conzx_TobeStudiedProblem.ProblemTitle); //问题标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.ProblemTitle); //问题标题
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.ProblemContent))
 {
 if (objzx_TobeStudiedProblemEN.ProblemContent !=  null)
 {
 var strProblemContent = objzx_TobeStudiedProblemEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemContent, conzx_TobeStudiedProblem.ProblemContent); //问题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.ProblemContent); //问题内容
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.GroupTextId))
 {
 if (objzx_TobeStudiedProblemEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_TobeStudiedProblemEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_TobeStudiedProblem.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.GroupTextId); //小组Id
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TobeStudiedProblemEN.IsSubmit == true?"1":"0", conzx_TobeStudiedProblem.IsSubmit); //是否提交
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.ProblemDate))
 {
 if (objzx_TobeStudiedProblemEN.ProblemDate !=  null)
 {
 var strProblemDate = objzx_TobeStudiedProblemEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemDate, conzx_TobeStudiedProblem.ProblemDate); //问题日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.ProblemDate); //问题日期
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.UpdDate))
 {
 if (objzx_TobeStudiedProblemEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TobeStudiedProblemEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_TobeStudiedProblem.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.UpdDate); //修改日期
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.UpdUser))
 {
 if (objzx_TobeStudiedProblemEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TobeStudiedProblemEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_TobeStudiedProblem.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.UpdUser); //修改人
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Year))
 {
 if (objzx_TobeStudiedProblemEN.Year !=  null)
 {
 var strYear = objzx_TobeStudiedProblemEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYear, conzx_TobeStudiedProblem.Year); //年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.Year); //年
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Month))
 {
 if (objzx_TobeStudiedProblemEN.Month !=  null)
 {
 var strMonth = objzx_TobeStudiedProblemEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMonth, conzx_TobeStudiedProblem.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.Month); //月
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.VersionCount))
 {
 if (objzx_TobeStudiedProblemEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TobeStudiedProblemEN.VersionCount, conzx_TobeStudiedProblem.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.VersionCount); //版本统计
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Participant))
 {
 if (objzx_TobeStudiedProblemEN.Participant !=  null)
 {
 var strParticipant = objzx_TobeStudiedProblemEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParticipant, conzx_TobeStudiedProblem.Participant); //参与者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.Participant); //参与者
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.Memo))
 {
 if (objzx_TobeStudiedProblemEN.Memo !=  null)
 {
 var strMemo = objzx_TobeStudiedProblemEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_TobeStudiedProblem.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.Memo); //备注
 }
 }
 
 if (objzx_TobeStudiedProblemEN.IsUpdated(conzx_TobeStudiedProblem.IdCurrEduCls))
 {
 if (objzx_TobeStudiedProblemEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TobeStudiedProblemEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_TobeStudiedProblem.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblem.IdCurrEduCls); //教学班流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ProblemId = '{0}'", objzx_TobeStudiedProblemEN.ProblemId); 
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
 /// <param name = "strProblemId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strProblemId) 
{
CheckPrimaryKey(strProblemId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strProblemId,
};
 objSQL.ExecSP("zx_TobeStudiedProblem_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strProblemId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strProblemId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strProblemId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
//删除zx_TobeStudiedProblem本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TobeStudiedProblem where ProblemId = " + "'"+ strProblemId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_TobeStudiedProblem(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
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
//删除zx_TobeStudiedProblem本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TobeStudiedProblem where ProblemId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strProblemId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strProblemId) 
{
CheckPrimaryKey(strProblemId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
//删除zx_TobeStudiedProblem本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TobeStudiedProblem where ProblemId = " + "'"+ strProblemId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_TobeStudiedProblem(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemDA: Delzx_TobeStudiedProblem)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_TobeStudiedProblem where " + strCondition ;
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
public bool Delzx_TobeStudiedProblemWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemDA: Delzx_TobeStudiedProblemWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_TobeStudiedProblem where " + strCondition ;
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
 /// <param name = "objzx_TobeStudiedProblemENS">源对象</param>
 /// <param name = "objzx_TobeStudiedProblemENT">目标对象</param>
public void CopyTo(clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemENS, clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemENT)
{
objzx_TobeStudiedProblemENT.ProblemId = objzx_TobeStudiedProblemENS.ProblemId; //问题Id
objzx_TobeStudiedProblemENT.ProblemTitle = objzx_TobeStudiedProblemENS.ProblemTitle; //问题标题
objzx_TobeStudiedProblemENT.ProblemContent = objzx_TobeStudiedProblemENS.ProblemContent; //问题内容
objzx_TobeStudiedProblemENT.GroupTextId = objzx_TobeStudiedProblemENS.GroupTextId; //小组Id
objzx_TobeStudiedProblemENT.IsSubmit = objzx_TobeStudiedProblemENS.IsSubmit; //是否提交
objzx_TobeStudiedProblemENT.ProblemDate = objzx_TobeStudiedProblemENS.ProblemDate; //问题日期
objzx_TobeStudiedProblemENT.UpdDate = objzx_TobeStudiedProblemENS.UpdDate; //修改日期
objzx_TobeStudiedProblemENT.UpdUser = objzx_TobeStudiedProblemENS.UpdUser; //修改人
objzx_TobeStudiedProblemENT.Year = objzx_TobeStudiedProblemENS.Year; //年
objzx_TobeStudiedProblemENT.Month = objzx_TobeStudiedProblemENS.Month; //月
objzx_TobeStudiedProblemENT.VersionCount = objzx_TobeStudiedProblemENS.VersionCount; //版本统计
objzx_TobeStudiedProblemENT.Participant = objzx_TobeStudiedProblemENS.Participant; //参与者
objzx_TobeStudiedProblemENT.Memo = objzx_TobeStudiedProblemENS.Memo; //备注
objzx_TobeStudiedProblemENT.IdCurrEduCls = objzx_TobeStudiedProblemENS.IdCurrEduCls; //教学班流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_TobeStudiedProblemEN.IdCurrEduCls, conzx_TobeStudiedProblem.IdCurrEduCls);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.ProblemId, 10, conzx_TobeStudiedProblem.ProblemId);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.ProblemTitle, 1000, conzx_TobeStudiedProblem.ProblemTitle);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.GroupTextId, 8, conzx_TobeStudiedProblem.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.ProblemDate, 20, conzx_TobeStudiedProblem.ProblemDate);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.UpdDate, 20, conzx_TobeStudiedProblem.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.UpdUser, 20, conzx_TobeStudiedProblem.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.Year, 4, conzx_TobeStudiedProblem.Year);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.Month, 2, conzx_TobeStudiedProblem.Month);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.Participant, 500, conzx_TobeStudiedProblem.Participant);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.Memo, 1000, conzx_TobeStudiedProblem.Memo);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.IdCurrEduCls, 8, conzx_TobeStudiedProblem.IdCurrEduCls);
//检查字段外键固定长度
 objzx_TobeStudiedProblemEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.ProblemTitle, 1000, conzx_TobeStudiedProblem.ProblemTitle);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.GroupTextId, 8, conzx_TobeStudiedProblem.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.ProblemDate, 20, conzx_TobeStudiedProblem.ProblemDate);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.UpdDate, 20, conzx_TobeStudiedProblem.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.UpdUser, 20, conzx_TobeStudiedProblem.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.Year, 4, conzx_TobeStudiedProblem.Year);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.Month, 2, conzx_TobeStudiedProblem.Month);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.Participant, 500, conzx_TobeStudiedProblem.Participant);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.Memo, 1000, conzx_TobeStudiedProblem.Memo);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.IdCurrEduCls, 8, conzx_TobeStudiedProblem.IdCurrEduCls);
//检查外键字段长度
 objzx_TobeStudiedProblemEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.ProblemId, 10, conzx_TobeStudiedProblem.ProblemId);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.ProblemTitle, 1000, conzx_TobeStudiedProblem.ProblemTitle);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.GroupTextId, 8, conzx_TobeStudiedProblem.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.ProblemDate, 20, conzx_TobeStudiedProblem.ProblemDate);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.UpdDate, 20, conzx_TobeStudiedProblem.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.UpdUser, 20, conzx_TobeStudiedProblem.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.Year, 4, conzx_TobeStudiedProblem.Year);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.Month, 2, conzx_TobeStudiedProblem.Month);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.Participant, 500, conzx_TobeStudiedProblem.Participant);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.Memo, 1000, conzx_TobeStudiedProblem.Memo);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemEN.IdCurrEduCls, 8, conzx_TobeStudiedProblem.IdCurrEduCls);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemEN.ProblemId, conzx_TobeStudiedProblem.ProblemId);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemEN.ProblemTitle, conzx_TobeStudiedProblem.ProblemTitle);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemEN.GroupTextId, conzx_TobeStudiedProblem.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemEN.ProblemDate, conzx_TobeStudiedProblem.ProblemDate);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemEN.UpdDate, conzx_TobeStudiedProblem.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemEN.UpdUser, conzx_TobeStudiedProblem.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemEN.Year, conzx_TobeStudiedProblem.Year);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemEN.Month, conzx_TobeStudiedProblem.Month);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemEN.Participant, conzx_TobeStudiedProblem.Participant);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemEN.Memo, conzx_TobeStudiedProblem.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemEN.IdCurrEduCls, conzx_TobeStudiedProblem.IdCurrEduCls);
//检查外键字段长度
 objzx_TobeStudiedProblemEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_TobeStudiedProblem(中学待研究问题),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_TobeStudiedProblemEN objzx_TobeStudiedProblemEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ProblemId = '{0}'", objzx_TobeStudiedProblemEN.ProblemId);
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
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
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
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
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
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_TobeStudiedProblemEN._CurrTabName);
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
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_TobeStudiedProblemEN._CurrTabName, strCondition);
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
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
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
 objSQL = clszx_TobeStudiedProblemDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}