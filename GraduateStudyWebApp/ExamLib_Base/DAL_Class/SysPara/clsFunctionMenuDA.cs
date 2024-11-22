
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionMenuDA
 表名:FunctionMenu(01120475)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 功能菜单(FunctionMenu)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFunctionMenuDA : clsCommBase4DA
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
 return clsFunctionMenuEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFunctionMenuEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFunctionMenuEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFunctionMenuEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFunctionMenuEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFunctionMenuId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFunctionMenuId)
{
strFunctionMenuId = strFunctionMenuId.Replace("'", "''");
if (strFunctionMenuId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:FunctionMenu中,检查关键字,长度不正确!(clsFunctionMenuDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFunctionMenuId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:FunctionMenu中,关键字不能为空 或 null!(clsFunctionMenuDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFunctionMenuId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsFunctionMenuDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFunctionMenuDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
strSQL = "Select * from FunctionMenu where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FunctionMenu(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFunctionMenuDA: GetDataTable_FunctionMenu)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
strSQL = "Select * from FunctionMenu where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFunctionMenuDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFunctionMenuDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
strSQL = "Select * from FunctionMenu where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFunctionMenuDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFunctionMenuDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FunctionMenu where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FunctionMenu where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFunctionMenuDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FunctionMenu where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFunctionMenuDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FunctionMenu.* from FunctionMenu Left Join {1} on {2} where {3} and FunctionMenu.FunctionMenuId not in (Select top {5} FunctionMenu.FunctionMenuId from FunctionMenu Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FunctionMenu where {1} and FunctionMenuId not in (Select top {2} FunctionMenuId from FunctionMenu where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FunctionMenu where {1} and FunctionMenuId not in (Select top {3} FunctionMenuId from FunctionMenu where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFunctionMenuDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FunctionMenu.* from FunctionMenu Left Join {1} on {2} where {3} and FunctionMenu.FunctionMenuId not in (Select top {5} FunctionMenu.FunctionMenuId from FunctionMenu Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FunctionMenu where {1} and FunctionMenuId not in (Select top {2} FunctionMenuId from FunctionMenu where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FunctionMenu where {1} and FunctionMenuId not in (Select top {3} FunctionMenuId from FunctionMenu where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFunctionMenuEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFunctionMenuDA:GetObjLst)", objException.Message));
}
List<clsFunctionMenuEN> arrObjLst = new List<clsFunctionMenuEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
strSQL = "Select * from FunctionMenu where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionMenuEN objFunctionMenuEN = new clsFunctionMenuEN();
try
{
objFunctionMenuEN.FunctionMenuId = objRow[conFunctionMenu.FunctionMenuId].ToString().Trim(); //功能菜单ID
objFunctionMenuEN.FunctionName = objRow[conFunctionMenu.FunctionName] == DBNull.Value ? null : objRow[conFunctionMenu.FunctionName].ToString().Trim(); //函数名
objFunctionMenuEN.TitleName = objRow[conFunctionMenu.TitleName] == DBNull.Value ? null : objRow[conFunctionMenu.TitleName].ToString().Trim(); //功能菜单标题
objFunctionMenuEN.IsVisible = TransNullToBool(objRow[conFunctionMenu.IsVisible].ToString().Trim()); //是否显示
objFunctionMenuEN.DispPageMode = objRow[conFunctionMenu.DispPageMode] == DBNull.Value ? null : objRow[conFunctionMenu.DispPageMode].ToString().Trim(); //显示页面方式
objFunctionMenuEN.IsTransUserBySingleSignOn = TransNullToBool(objRow[conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim()); //是否单点登录传用户信息
objFunctionMenuEN.IsWithParameter = TransNullToBool(objRow[conFunctionMenu.IsWithParameter].ToString().Trim()); //是否带参数
objFunctionMenuEN.HyperLink = objRow[conFunctionMenu.HyperLink] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink].ToString().Trim(); //超链接
objFunctionMenuEN.HyperLink4NoUser = objRow[conFunctionMenu.HyperLink4NoUser] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink4NoUser].ToString().Trim(); //超链接针对无用户
objFunctionMenuEN.SingleSignOnKey = objRow[conFunctionMenu.SingleSignOnKey] == DBNull.Value ? null : objRow[conFunctionMenu.SingleSignOnKey].ToString().Trim(); //单点登录关键字
objFunctionMenuEN.SchoolId = objRow[conFunctionMenu.SchoolId].ToString().Trim(); //学校编号
objFunctionMenuEN.UpdDate = objRow[conFunctionMenu.UpdDate] == DBNull.Value ? null : objRow[conFunctionMenu.UpdDate].ToString().Trim(); //修改日期
objFunctionMenuEN.UpdUserId = objRow[conFunctionMenu.UpdUserId] == DBNull.Value ? null : objRow[conFunctionMenu.UpdUserId].ToString().Trim(); //修改用户Id
objFunctionMenuEN.Memo = objRow[conFunctionMenu.Memo] == DBNull.Value ? null : objRow[conFunctionMenu.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFunctionMenuDA: GetObjLst)", objException.Message));
}
objFunctionMenuEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFunctionMenuEN);
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
public List<clsFunctionMenuEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFunctionMenuDA:GetObjLstByTabName)", objException.Message));
}
List<clsFunctionMenuEN> arrObjLst = new List<clsFunctionMenuEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionMenuEN objFunctionMenuEN = new clsFunctionMenuEN();
try
{
objFunctionMenuEN.FunctionMenuId = objRow[conFunctionMenu.FunctionMenuId].ToString().Trim(); //功能菜单ID
objFunctionMenuEN.FunctionName = objRow[conFunctionMenu.FunctionName] == DBNull.Value ? null : objRow[conFunctionMenu.FunctionName].ToString().Trim(); //函数名
objFunctionMenuEN.TitleName = objRow[conFunctionMenu.TitleName] == DBNull.Value ? null : objRow[conFunctionMenu.TitleName].ToString().Trim(); //功能菜单标题
objFunctionMenuEN.IsVisible = TransNullToBool(objRow[conFunctionMenu.IsVisible].ToString().Trim()); //是否显示
objFunctionMenuEN.DispPageMode = objRow[conFunctionMenu.DispPageMode] == DBNull.Value ? null : objRow[conFunctionMenu.DispPageMode].ToString().Trim(); //显示页面方式
objFunctionMenuEN.IsTransUserBySingleSignOn = TransNullToBool(objRow[conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim()); //是否单点登录传用户信息
objFunctionMenuEN.IsWithParameter = TransNullToBool(objRow[conFunctionMenu.IsWithParameter].ToString().Trim()); //是否带参数
objFunctionMenuEN.HyperLink = objRow[conFunctionMenu.HyperLink] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink].ToString().Trim(); //超链接
objFunctionMenuEN.HyperLink4NoUser = objRow[conFunctionMenu.HyperLink4NoUser] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink4NoUser].ToString().Trim(); //超链接针对无用户
objFunctionMenuEN.SingleSignOnKey = objRow[conFunctionMenu.SingleSignOnKey] == DBNull.Value ? null : objRow[conFunctionMenu.SingleSignOnKey].ToString().Trim(); //单点登录关键字
objFunctionMenuEN.SchoolId = objRow[conFunctionMenu.SchoolId].ToString().Trim(); //学校编号
objFunctionMenuEN.UpdDate = objRow[conFunctionMenu.UpdDate] == DBNull.Value ? null : objRow[conFunctionMenu.UpdDate].ToString().Trim(); //修改日期
objFunctionMenuEN.UpdUserId = objRow[conFunctionMenu.UpdUserId] == DBNull.Value ? null : objRow[conFunctionMenu.UpdUserId].ToString().Trim(); //修改用户Id
objFunctionMenuEN.Memo = objRow[conFunctionMenu.Memo] == DBNull.Value ? null : objRow[conFunctionMenu.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFunctionMenuDA: GetObjLst)", objException.Message));
}
objFunctionMenuEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFunctionMenuEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFunctionMenu(ref clsFunctionMenuEN objFunctionMenuEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
strSQL = "Select * from FunctionMenu where FunctionMenuId = " + "'"+ objFunctionMenuEN.FunctionMenuId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFunctionMenuEN.FunctionMenuId = objDT.Rows[0][conFunctionMenu.FunctionMenuId].ToString().Trim(); //功能菜单ID(字段类型:char,字段长度:4,是否可空:True)
 objFunctionMenuEN.FunctionName = objDT.Rows[0][conFunctionMenu.FunctionName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:True)
 objFunctionMenuEN.TitleName = objDT.Rows[0][conFunctionMenu.TitleName].ToString().Trim(); //功能菜单标题(字段类型:varchar,字段长度:200,是否可空:True)
 objFunctionMenuEN.IsVisible = TransNullToBool(objDT.Rows[0][conFunctionMenu.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objFunctionMenuEN.DispPageMode = objDT.Rows[0][conFunctionMenu.DispPageMode].ToString().Trim(); //显示页面方式(字段类型:varchar,字段长度:50,是否可空:True)
 objFunctionMenuEN.IsTransUserBySingleSignOn = TransNullToBool(objDT.Rows[0][conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim()); //是否单点登录传用户信息(字段类型:bit,字段长度:1,是否可空:True)
 objFunctionMenuEN.IsWithParameter = TransNullToBool(objDT.Rows[0][conFunctionMenu.IsWithParameter].ToString().Trim()); //是否带参数(字段类型:bit,字段长度:1,是否可空:True)
 objFunctionMenuEN.HyperLink = objDT.Rows[0][conFunctionMenu.HyperLink].ToString().Trim(); //超链接(字段类型:varchar,字段长度:200,是否可空:True)
 objFunctionMenuEN.HyperLink4NoUser = objDT.Rows[0][conFunctionMenu.HyperLink4NoUser].ToString().Trim(); //超链接针对无用户(字段类型:varchar,字段长度:200,是否可空:True)
 objFunctionMenuEN.SingleSignOnKey = objDT.Rows[0][conFunctionMenu.SingleSignOnKey].ToString().Trim(); //单点登录关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objFunctionMenuEN.SchoolId = objDT.Rows[0][conFunctionMenu.SchoolId].ToString().Trim(); //学校编号(字段类型:varchar,字段长度:10,是否可空:True)
 objFunctionMenuEN.UpdDate = objDT.Rows[0][conFunctionMenu.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionMenuEN.UpdUserId = objDT.Rows[0][conFunctionMenu.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionMenuEN.Memo = objDT.Rows[0][conFunctionMenu.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFunctionMenuDA: GetFunctionMenu)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFunctionMenuId">表关键字</param>
 /// <returns>表对象</returns>
public clsFunctionMenuEN GetObjByFunctionMenuId(string strFunctionMenuId)
{
CheckPrimaryKey(strFunctionMenuId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
strSQL = "Select * from FunctionMenu where FunctionMenuId = " + "'"+ strFunctionMenuId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFunctionMenuEN objFunctionMenuEN = new clsFunctionMenuEN();
try
{
 objFunctionMenuEN.FunctionMenuId = objRow[conFunctionMenu.FunctionMenuId].ToString().Trim(); //功能菜单ID(字段类型:char,字段长度:4,是否可空:True)
 objFunctionMenuEN.FunctionName = objRow[conFunctionMenu.FunctionName] == DBNull.Value ? null : objRow[conFunctionMenu.FunctionName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:True)
 objFunctionMenuEN.TitleName = objRow[conFunctionMenu.TitleName] == DBNull.Value ? null : objRow[conFunctionMenu.TitleName].ToString().Trim(); //功能菜单标题(字段类型:varchar,字段长度:200,是否可空:True)
 objFunctionMenuEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objFunctionMenuEN.DispPageMode = objRow[conFunctionMenu.DispPageMode] == DBNull.Value ? null : objRow[conFunctionMenu.DispPageMode].ToString().Trim(); //显示页面方式(字段类型:varchar,字段长度:50,是否可空:True)
 objFunctionMenuEN.IsTransUserBySingleSignOn = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim()); //是否单点登录传用户信息(字段类型:bit,字段长度:1,是否可空:True)
 objFunctionMenuEN.IsWithParameter = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsWithParameter].ToString().Trim()); //是否带参数(字段类型:bit,字段长度:1,是否可空:True)
 objFunctionMenuEN.HyperLink = objRow[conFunctionMenu.HyperLink] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink].ToString().Trim(); //超链接(字段类型:varchar,字段长度:200,是否可空:True)
 objFunctionMenuEN.HyperLink4NoUser = objRow[conFunctionMenu.HyperLink4NoUser] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink4NoUser].ToString().Trim(); //超链接针对无用户(字段类型:varchar,字段长度:200,是否可空:True)
 objFunctionMenuEN.SingleSignOnKey = objRow[conFunctionMenu.SingleSignOnKey] == DBNull.Value ? null : objRow[conFunctionMenu.SingleSignOnKey].ToString().Trim(); //单点登录关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objFunctionMenuEN.SchoolId = objRow[conFunctionMenu.SchoolId].ToString().Trim(); //学校编号(字段类型:varchar,字段长度:10,是否可空:True)
 objFunctionMenuEN.UpdDate = objRow[conFunctionMenu.UpdDate] == DBNull.Value ? null : objRow[conFunctionMenu.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionMenuEN.UpdUserId = objRow[conFunctionMenu.UpdUserId] == DBNull.Value ? null : objRow[conFunctionMenu.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionMenuEN.Memo = objRow[conFunctionMenu.Memo] == DBNull.Value ? null : objRow[conFunctionMenu.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFunctionMenuDA: GetObjByFunctionMenuId)", objException.Message));
}
return objFunctionMenuEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFunctionMenuEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFunctionMenuDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
strSQL = "Select * from FunctionMenu where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFunctionMenuEN objFunctionMenuEN = new clsFunctionMenuEN()
{
FunctionMenuId = objRow[conFunctionMenu.FunctionMenuId].ToString().Trim(), //功能菜单ID
FunctionName = objRow[conFunctionMenu.FunctionName] == DBNull.Value ? null : objRow[conFunctionMenu.FunctionName].ToString().Trim(), //函数名
TitleName = objRow[conFunctionMenu.TitleName] == DBNull.Value ? null : objRow[conFunctionMenu.TitleName].ToString().Trim(), //功能菜单标题
IsVisible = TransNullToBool(objRow[conFunctionMenu.IsVisible].ToString().Trim()), //是否显示
DispPageMode = objRow[conFunctionMenu.DispPageMode] == DBNull.Value ? null : objRow[conFunctionMenu.DispPageMode].ToString().Trim(), //显示页面方式
IsTransUserBySingleSignOn = TransNullToBool(objRow[conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim()), //是否单点登录传用户信息
IsWithParameter = TransNullToBool(objRow[conFunctionMenu.IsWithParameter].ToString().Trim()), //是否带参数
HyperLink = objRow[conFunctionMenu.HyperLink] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink].ToString().Trim(), //超链接
HyperLink4NoUser = objRow[conFunctionMenu.HyperLink4NoUser] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink4NoUser].ToString().Trim(), //超链接针对无用户
SingleSignOnKey = objRow[conFunctionMenu.SingleSignOnKey] == DBNull.Value ? null : objRow[conFunctionMenu.SingleSignOnKey].ToString().Trim(), //单点登录关键字
SchoolId = objRow[conFunctionMenu.SchoolId].ToString().Trim(), //学校编号
UpdDate = objRow[conFunctionMenu.UpdDate] == DBNull.Value ? null : objRow[conFunctionMenu.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conFunctionMenu.UpdUserId] == DBNull.Value ? null : objRow[conFunctionMenu.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conFunctionMenu.Memo] == DBNull.Value ? null : objRow[conFunctionMenu.Memo].ToString().Trim() //备注
};
objFunctionMenuEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunctionMenuEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFunctionMenuDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFunctionMenuEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFunctionMenuEN objFunctionMenuEN = new clsFunctionMenuEN();
try
{
objFunctionMenuEN.FunctionMenuId = objRow[conFunctionMenu.FunctionMenuId].ToString().Trim(); //功能菜单ID
objFunctionMenuEN.FunctionName = objRow[conFunctionMenu.FunctionName] == DBNull.Value ? null : objRow[conFunctionMenu.FunctionName].ToString().Trim(); //函数名
objFunctionMenuEN.TitleName = objRow[conFunctionMenu.TitleName] == DBNull.Value ? null : objRow[conFunctionMenu.TitleName].ToString().Trim(); //功能菜单标题
objFunctionMenuEN.IsVisible = TransNullToBool(objRow[conFunctionMenu.IsVisible].ToString().Trim()); //是否显示
objFunctionMenuEN.DispPageMode = objRow[conFunctionMenu.DispPageMode] == DBNull.Value ? null : objRow[conFunctionMenu.DispPageMode].ToString().Trim(); //显示页面方式
objFunctionMenuEN.IsTransUserBySingleSignOn = TransNullToBool(objRow[conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim()); //是否单点登录传用户信息
objFunctionMenuEN.IsWithParameter = TransNullToBool(objRow[conFunctionMenu.IsWithParameter].ToString().Trim()); //是否带参数
objFunctionMenuEN.HyperLink = objRow[conFunctionMenu.HyperLink] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink].ToString().Trim(); //超链接
objFunctionMenuEN.HyperLink4NoUser = objRow[conFunctionMenu.HyperLink4NoUser] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink4NoUser].ToString().Trim(); //超链接针对无用户
objFunctionMenuEN.SingleSignOnKey = objRow[conFunctionMenu.SingleSignOnKey] == DBNull.Value ? null : objRow[conFunctionMenu.SingleSignOnKey].ToString().Trim(); //单点登录关键字
objFunctionMenuEN.SchoolId = objRow[conFunctionMenu.SchoolId].ToString().Trim(); //学校编号
objFunctionMenuEN.UpdDate = objRow[conFunctionMenu.UpdDate] == DBNull.Value ? null : objRow[conFunctionMenu.UpdDate].ToString().Trim(); //修改日期
objFunctionMenuEN.UpdUserId = objRow[conFunctionMenu.UpdUserId] == DBNull.Value ? null : objRow[conFunctionMenu.UpdUserId].ToString().Trim(); //修改用户Id
objFunctionMenuEN.Memo = objRow[conFunctionMenu.Memo] == DBNull.Value ? null : objRow[conFunctionMenu.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFunctionMenuDA: GetObjByDataRowFunctionMenu)", objException.Message));
}
objFunctionMenuEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunctionMenuEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFunctionMenuEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFunctionMenuEN objFunctionMenuEN = new clsFunctionMenuEN();
try
{
objFunctionMenuEN.FunctionMenuId = objRow[conFunctionMenu.FunctionMenuId].ToString().Trim(); //功能菜单ID
objFunctionMenuEN.FunctionName = objRow[conFunctionMenu.FunctionName] == DBNull.Value ? null : objRow[conFunctionMenu.FunctionName].ToString().Trim(); //函数名
objFunctionMenuEN.TitleName = objRow[conFunctionMenu.TitleName] == DBNull.Value ? null : objRow[conFunctionMenu.TitleName].ToString().Trim(); //功能菜单标题
objFunctionMenuEN.IsVisible = TransNullToBool(objRow[conFunctionMenu.IsVisible].ToString().Trim()); //是否显示
objFunctionMenuEN.DispPageMode = objRow[conFunctionMenu.DispPageMode] == DBNull.Value ? null : objRow[conFunctionMenu.DispPageMode].ToString().Trim(); //显示页面方式
objFunctionMenuEN.IsTransUserBySingleSignOn = TransNullToBool(objRow[conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim()); //是否单点登录传用户信息
objFunctionMenuEN.IsWithParameter = TransNullToBool(objRow[conFunctionMenu.IsWithParameter].ToString().Trim()); //是否带参数
objFunctionMenuEN.HyperLink = objRow[conFunctionMenu.HyperLink] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink].ToString().Trim(); //超链接
objFunctionMenuEN.HyperLink4NoUser = objRow[conFunctionMenu.HyperLink4NoUser] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink4NoUser].ToString().Trim(); //超链接针对无用户
objFunctionMenuEN.SingleSignOnKey = objRow[conFunctionMenu.SingleSignOnKey] == DBNull.Value ? null : objRow[conFunctionMenu.SingleSignOnKey].ToString().Trim(); //单点登录关键字
objFunctionMenuEN.SchoolId = objRow[conFunctionMenu.SchoolId].ToString().Trim(); //学校编号
objFunctionMenuEN.UpdDate = objRow[conFunctionMenu.UpdDate] == DBNull.Value ? null : objRow[conFunctionMenu.UpdDate].ToString().Trim(); //修改日期
objFunctionMenuEN.UpdUserId = objRow[conFunctionMenu.UpdUserId] == DBNull.Value ? null : objRow[conFunctionMenu.UpdUserId].ToString().Trim(); //修改用户Id
objFunctionMenuEN.Memo = objRow[conFunctionMenu.Memo] == DBNull.Value ? null : objRow[conFunctionMenu.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFunctionMenuDA: GetObjByDataRow)", objException.Message));
}
objFunctionMenuEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunctionMenuEN;
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
objSQL = clsFunctionMenuDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFunctionMenuEN._CurrTabName, conFunctionMenu.FunctionMenuId, 4, "");
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
objSQL = clsFunctionMenuDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFunctionMenuEN._CurrTabName, conFunctionMenu.FunctionMenuId, 4, strPrefix);
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
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FunctionMenuId from FunctionMenu where " + strCondition;
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
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FunctionMenuId from FunctionMenu where " + strCondition;
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
 /// <param name = "strFunctionMenuId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFunctionMenuId)
{
CheckPrimaryKey(strFunctionMenuId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FunctionMenu", "FunctionMenuId = " + "'"+ strFunctionMenuId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFunctionMenuDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FunctionMenu", strCondition))
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
objSQL = clsFunctionMenuDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FunctionMenu");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFunctionMenuEN objFunctionMenuEN)
 {
 objFunctionMenuEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionMenuEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionMenuEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
strSQL = "Select * from FunctionMenu where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FunctionMenu");
objRow = objDS.Tables["FunctionMenu"].NewRow();
objRow[conFunctionMenu.FunctionMenuId] = objFunctionMenuEN.FunctionMenuId; //功能菜单ID
 if (objFunctionMenuEN.FunctionName !=  "")
 {
objRow[conFunctionMenu.FunctionName] = objFunctionMenuEN.FunctionName; //函数名
 }
 if (objFunctionMenuEN.TitleName !=  "")
 {
objRow[conFunctionMenu.TitleName] = objFunctionMenuEN.TitleName; //功能菜单标题
 }
objRow[conFunctionMenu.IsVisible] = objFunctionMenuEN.IsVisible; //是否显示
 if (objFunctionMenuEN.DispPageMode !=  "")
 {
objRow[conFunctionMenu.DispPageMode] = objFunctionMenuEN.DispPageMode; //显示页面方式
 }
objRow[conFunctionMenu.IsTransUserBySingleSignOn] = objFunctionMenuEN.IsTransUserBySingleSignOn; //是否单点登录传用户信息
objRow[conFunctionMenu.IsWithParameter] = objFunctionMenuEN.IsWithParameter; //是否带参数
 if (objFunctionMenuEN.HyperLink !=  "")
 {
objRow[conFunctionMenu.HyperLink] = objFunctionMenuEN.HyperLink; //超链接
 }
 if (objFunctionMenuEN.HyperLink4NoUser !=  "")
 {
objRow[conFunctionMenu.HyperLink4NoUser] = objFunctionMenuEN.HyperLink4NoUser; //超链接针对无用户
 }
 if (objFunctionMenuEN.SingleSignOnKey !=  "")
 {
objRow[conFunctionMenu.SingleSignOnKey] = objFunctionMenuEN.SingleSignOnKey; //单点登录关键字
 }
objRow[conFunctionMenu.SchoolId] = objFunctionMenuEN.SchoolId; //学校编号
 if (objFunctionMenuEN.UpdDate !=  "")
 {
objRow[conFunctionMenu.UpdDate] = objFunctionMenuEN.UpdDate; //修改日期
 }
 if (objFunctionMenuEN.UpdUserId !=  "")
 {
objRow[conFunctionMenu.UpdUserId] = objFunctionMenuEN.UpdUserId; //修改用户Id
 }
 if (objFunctionMenuEN.Memo !=  "")
 {
objRow[conFunctionMenu.Memo] = objFunctionMenuEN.Memo; //备注
 }
objDS.Tables[clsFunctionMenuEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFunctionMenuEN._CurrTabName);
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
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFunctionMenuEN objFunctionMenuEN)
{
 objFunctionMenuEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionMenuEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionMenuEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionMenuEN.FunctionMenuId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.FunctionMenuId);
 var strFunctionMenuId = objFunctionMenuEN.FunctionMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionMenuId + "'");
 }
 
 if (objFunctionMenuEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.FunctionName);
 var strFunctionName = objFunctionMenuEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 if (objFunctionMenuEN.TitleName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.TitleName);
 var strTitleName = objFunctionMenuEN.TitleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTitleName + "'");
 }
 
 arrFieldListForInsert.Add(conFunctionMenu.IsVisible);
 arrValueListForInsert.Add("'" + (objFunctionMenuEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objFunctionMenuEN.DispPageMode !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.DispPageMode);
 var strDispPageMode = objFunctionMenuEN.DispPageMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDispPageMode + "'");
 }
 
 arrFieldListForInsert.Add(conFunctionMenu.IsTransUserBySingleSignOn);
 arrValueListForInsert.Add("'" + (objFunctionMenuEN.IsTransUserBySingleSignOn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunctionMenu.IsWithParameter);
 arrValueListForInsert.Add("'" + (objFunctionMenuEN.IsWithParameter  ==  false ? "0" : "1") + "'");
 
 if (objFunctionMenuEN.HyperLink !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.HyperLink);
 var strHyperLink = objFunctionMenuEN.HyperLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHyperLink + "'");
 }
 
 if (objFunctionMenuEN.HyperLink4NoUser !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.HyperLink4NoUser);
 var strHyperLink4NoUser = objFunctionMenuEN.HyperLink4NoUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHyperLink4NoUser + "'");
 }
 
 if (objFunctionMenuEN.SingleSignOnKey !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.SingleSignOnKey);
 var strSingleSignOnKey = objFunctionMenuEN.SingleSignOnKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSingleSignOnKey + "'");
 }
 
 if (objFunctionMenuEN.SchoolId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.SchoolId);
 var strSchoolId = objFunctionMenuEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolId + "'");
 }
 
 if (objFunctionMenuEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.UpdDate);
 var strUpdDate = objFunctionMenuEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunctionMenuEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.UpdUserId);
 var strUpdUserId = objFunctionMenuEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objFunctionMenuEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.Memo);
 var strMemo = objFunctionMenuEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionMenu");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFunctionMenuEN objFunctionMenuEN)
{
 objFunctionMenuEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionMenuEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionMenuEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionMenuEN.FunctionMenuId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.FunctionMenuId);
 var strFunctionMenuId = objFunctionMenuEN.FunctionMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionMenuId + "'");
 }
 
 if (objFunctionMenuEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.FunctionName);
 var strFunctionName = objFunctionMenuEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 if (objFunctionMenuEN.TitleName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.TitleName);
 var strTitleName = objFunctionMenuEN.TitleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTitleName + "'");
 }
 
 arrFieldListForInsert.Add(conFunctionMenu.IsVisible);
 arrValueListForInsert.Add("'" + (objFunctionMenuEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objFunctionMenuEN.DispPageMode !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.DispPageMode);
 var strDispPageMode = objFunctionMenuEN.DispPageMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDispPageMode + "'");
 }
 
 arrFieldListForInsert.Add(conFunctionMenu.IsTransUserBySingleSignOn);
 arrValueListForInsert.Add("'" + (objFunctionMenuEN.IsTransUserBySingleSignOn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunctionMenu.IsWithParameter);
 arrValueListForInsert.Add("'" + (objFunctionMenuEN.IsWithParameter  ==  false ? "0" : "1") + "'");
 
 if (objFunctionMenuEN.HyperLink !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.HyperLink);
 var strHyperLink = objFunctionMenuEN.HyperLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHyperLink + "'");
 }
 
 if (objFunctionMenuEN.HyperLink4NoUser !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.HyperLink4NoUser);
 var strHyperLink4NoUser = objFunctionMenuEN.HyperLink4NoUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHyperLink4NoUser + "'");
 }
 
 if (objFunctionMenuEN.SingleSignOnKey !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.SingleSignOnKey);
 var strSingleSignOnKey = objFunctionMenuEN.SingleSignOnKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSingleSignOnKey + "'");
 }
 
 if (objFunctionMenuEN.SchoolId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.SchoolId);
 var strSchoolId = objFunctionMenuEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolId + "'");
 }
 
 if (objFunctionMenuEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.UpdDate);
 var strUpdDate = objFunctionMenuEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunctionMenuEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.UpdUserId);
 var strUpdUserId = objFunctionMenuEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objFunctionMenuEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.Memo);
 var strMemo = objFunctionMenuEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionMenu");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objFunctionMenuEN.FunctionMenuId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFunctionMenuEN objFunctionMenuEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFunctionMenuEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionMenuEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionMenuEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionMenuEN.FunctionMenuId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.FunctionMenuId);
 var strFunctionMenuId = objFunctionMenuEN.FunctionMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionMenuId + "'");
 }
 
 if (objFunctionMenuEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.FunctionName);
 var strFunctionName = objFunctionMenuEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 if (objFunctionMenuEN.TitleName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.TitleName);
 var strTitleName = objFunctionMenuEN.TitleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTitleName + "'");
 }
 
 arrFieldListForInsert.Add(conFunctionMenu.IsVisible);
 arrValueListForInsert.Add("'" + (objFunctionMenuEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objFunctionMenuEN.DispPageMode !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.DispPageMode);
 var strDispPageMode = objFunctionMenuEN.DispPageMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDispPageMode + "'");
 }
 
 arrFieldListForInsert.Add(conFunctionMenu.IsTransUserBySingleSignOn);
 arrValueListForInsert.Add("'" + (objFunctionMenuEN.IsTransUserBySingleSignOn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunctionMenu.IsWithParameter);
 arrValueListForInsert.Add("'" + (objFunctionMenuEN.IsWithParameter  ==  false ? "0" : "1") + "'");
 
 if (objFunctionMenuEN.HyperLink !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.HyperLink);
 var strHyperLink = objFunctionMenuEN.HyperLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHyperLink + "'");
 }
 
 if (objFunctionMenuEN.HyperLink4NoUser !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.HyperLink4NoUser);
 var strHyperLink4NoUser = objFunctionMenuEN.HyperLink4NoUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHyperLink4NoUser + "'");
 }
 
 if (objFunctionMenuEN.SingleSignOnKey !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.SingleSignOnKey);
 var strSingleSignOnKey = objFunctionMenuEN.SingleSignOnKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSingleSignOnKey + "'");
 }
 
 if (objFunctionMenuEN.SchoolId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.SchoolId);
 var strSchoolId = objFunctionMenuEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolId + "'");
 }
 
 if (objFunctionMenuEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.UpdDate);
 var strUpdDate = objFunctionMenuEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunctionMenuEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.UpdUserId);
 var strUpdUserId = objFunctionMenuEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objFunctionMenuEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.Memo);
 var strMemo = objFunctionMenuEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionMenu");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objFunctionMenuEN.FunctionMenuId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFunctionMenuEN objFunctionMenuEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFunctionMenuEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionMenuEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionMenuEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionMenuEN.FunctionMenuId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.FunctionMenuId);
 var strFunctionMenuId = objFunctionMenuEN.FunctionMenuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionMenuId + "'");
 }
 
 if (objFunctionMenuEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.FunctionName);
 var strFunctionName = objFunctionMenuEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 if (objFunctionMenuEN.TitleName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.TitleName);
 var strTitleName = objFunctionMenuEN.TitleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTitleName + "'");
 }
 
 arrFieldListForInsert.Add(conFunctionMenu.IsVisible);
 arrValueListForInsert.Add("'" + (objFunctionMenuEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objFunctionMenuEN.DispPageMode !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.DispPageMode);
 var strDispPageMode = objFunctionMenuEN.DispPageMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDispPageMode + "'");
 }
 
 arrFieldListForInsert.Add(conFunctionMenu.IsTransUserBySingleSignOn);
 arrValueListForInsert.Add("'" + (objFunctionMenuEN.IsTransUserBySingleSignOn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunctionMenu.IsWithParameter);
 arrValueListForInsert.Add("'" + (objFunctionMenuEN.IsWithParameter  ==  false ? "0" : "1") + "'");
 
 if (objFunctionMenuEN.HyperLink !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.HyperLink);
 var strHyperLink = objFunctionMenuEN.HyperLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHyperLink + "'");
 }
 
 if (objFunctionMenuEN.HyperLink4NoUser !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.HyperLink4NoUser);
 var strHyperLink4NoUser = objFunctionMenuEN.HyperLink4NoUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHyperLink4NoUser + "'");
 }
 
 if (objFunctionMenuEN.SingleSignOnKey !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.SingleSignOnKey);
 var strSingleSignOnKey = objFunctionMenuEN.SingleSignOnKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSingleSignOnKey + "'");
 }
 
 if (objFunctionMenuEN.SchoolId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.SchoolId);
 var strSchoolId = objFunctionMenuEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolId + "'");
 }
 
 if (objFunctionMenuEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.UpdDate);
 var strUpdDate = objFunctionMenuEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunctionMenuEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.UpdUserId);
 var strUpdUserId = objFunctionMenuEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objFunctionMenuEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionMenu.Memo);
 var strMemo = objFunctionMenuEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionMenu");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFunctionMenus(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
strSQL = "Select * from FunctionMenu where FunctionMenuId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FunctionMenu");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFunctionMenuId = oRow[conFunctionMenu.FunctionMenuId].ToString().Trim();
if (IsExist(strFunctionMenuId))
{
 string strResult = "关键字变量值为:" + string.Format("FunctionMenuId = {0}", strFunctionMenuId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFunctionMenuEN._CurrTabName ].NewRow();
objRow[conFunctionMenu.FunctionMenuId] = oRow[conFunctionMenu.FunctionMenuId].ToString().Trim(); //功能菜单ID
objRow[conFunctionMenu.FunctionName] = oRow[conFunctionMenu.FunctionName].ToString().Trim(); //函数名
objRow[conFunctionMenu.TitleName] = oRow[conFunctionMenu.TitleName].ToString().Trim(); //功能菜单标题
objRow[conFunctionMenu.IsVisible] = oRow[conFunctionMenu.IsVisible].ToString().Trim(); //是否显示
objRow[conFunctionMenu.DispPageMode] = oRow[conFunctionMenu.DispPageMode].ToString().Trim(); //显示页面方式
objRow[conFunctionMenu.IsTransUserBySingleSignOn] = oRow[conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim(); //是否单点登录传用户信息
objRow[conFunctionMenu.IsWithParameter] = oRow[conFunctionMenu.IsWithParameter].ToString().Trim(); //是否带参数
objRow[conFunctionMenu.HyperLink] = oRow[conFunctionMenu.HyperLink].ToString().Trim(); //超链接
objRow[conFunctionMenu.HyperLink4NoUser] = oRow[conFunctionMenu.HyperLink4NoUser].ToString().Trim(); //超链接针对无用户
objRow[conFunctionMenu.SingleSignOnKey] = oRow[conFunctionMenu.SingleSignOnKey].ToString().Trim(); //单点登录关键字
objRow[conFunctionMenu.SchoolId] = oRow[conFunctionMenu.SchoolId].ToString().Trim(); //学校编号
objRow[conFunctionMenu.UpdDate] = oRow[conFunctionMenu.UpdDate].ToString().Trim(); //修改日期
objRow[conFunctionMenu.UpdUserId] = oRow[conFunctionMenu.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conFunctionMenu.Memo] = oRow[conFunctionMenu.Memo].ToString().Trim(); //备注
 objDS.Tables[clsFunctionMenuEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFunctionMenuEN._CurrTabName);
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
 /// <param name = "objFunctionMenuEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFunctionMenuEN objFunctionMenuEN)
{
 objFunctionMenuEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionMenuEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionMenuEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
strSQL = "Select * from FunctionMenu where FunctionMenuId = " + "'"+ objFunctionMenuEN.FunctionMenuId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFunctionMenuEN._CurrTabName);
if (objDS.Tables[clsFunctionMenuEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FunctionMenuId = " + "'"+ objFunctionMenuEN.FunctionMenuId+"'");
return false;
}
objRow = objDS.Tables[clsFunctionMenuEN._CurrTabName].Rows[0];
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.FunctionMenuId))
 {
objRow[conFunctionMenu.FunctionMenuId] = objFunctionMenuEN.FunctionMenuId; //功能菜单ID
 }
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.FunctionName))
 {
objRow[conFunctionMenu.FunctionName] = objFunctionMenuEN.FunctionName; //函数名
 }
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.TitleName))
 {
objRow[conFunctionMenu.TitleName] = objFunctionMenuEN.TitleName; //功能菜单标题
 }
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.IsVisible))
 {
objRow[conFunctionMenu.IsVisible] = objFunctionMenuEN.IsVisible; //是否显示
 }
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.DispPageMode))
 {
objRow[conFunctionMenu.DispPageMode] = objFunctionMenuEN.DispPageMode; //显示页面方式
 }
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.IsTransUserBySingleSignOn))
 {
objRow[conFunctionMenu.IsTransUserBySingleSignOn] = objFunctionMenuEN.IsTransUserBySingleSignOn; //是否单点登录传用户信息
 }
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.IsWithParameter))
 {
objRow[conFunctionMenu.IsWithParameter] = objFunctionMenuEN.IsWithParameter; //是否带参数
 }
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.HyperLink))
 {
objRow[conFunctionMenu.HyperLink] = objFunctionMenuEN.HyperLink; //超链接
 }
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.HyperLink4NoUser))
 {
objRow[conFunctionMenu.HyperLink4NoUser] = objFunctionMenuEN.HyperLink4NoUser; //超链接针对无用户
 }
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.SingleSignOnKey))
 {
objRow[conFunctionMenu.SingleSignOnKey] = objFunctionMenuEN.SingleSignOnKey; //单点登录关键字
 }
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.SchoolId))
 {
objRow[conFunctionMenu.SchoolId] = objFunctionMenuEN.SchoolId; //学校编号
 }
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.UpdDate))
 {
objRow[conFunctionMenu.UpdDate] = objFunctionMenuEN.UpdDate; //修改日期
 }
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.UpdUserId))
 {
objRow[conFunctionMenu.UpdUserId] = objFunctionMenuEN.UpdUserId; //修改用户Id
 }
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.Memo))
 {
objRow[conFunctionMenu.Memo] = objFunctionMenuEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsFunctionMenuEN._CurrTabName);
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
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFunctionMenuEN objFunctionMenuEN)
{
 objFunctionMenuEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionMenuEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionMenuEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FunctionMenu Set ");
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.FunctionName))
 {
 if (objFunctionMenuEN.FunctionName !=  null)
 {
 var strFunctionName = objFunctionMenuEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionName, conFunctionMenu.FunctionName); //函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.FunctionName); //函数名
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.TitleName))
 {
 if (objFunctionMenuEN.TitleName !=  null)
 {
 var strTitleName = objFunctionMenuEN.TitleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTitleName, conFunctionMenu.TitleName); //功能菜单标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.TitleName); //功能菜单标题
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunctionMenuEN.IsVisible == true?"1":"0", conFunctionMenu.IsVisible); //是否显示
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.DispPageMode))
 {
 if (objFunctionMenuEN.DispPageMode !=  null)
 {
 var strDispPageMode = objFunctionMenuEN.DispPageMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDispPageMode, conFunctionMenu.DispPageMode); //显示页面方式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.DispPageMode); //显示页面方式
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.IsTransUserBySingleSignOn))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunctionMenuEN.IsTransUserBySingleSignOn == true?"1":"0", conFunctionMenu.IsTransUserBySingleSignOn); //是否单点登录传用户信息
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.IsWithParameter))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunctionMenuEN.IsWithParameter == true?"1":"0", conFunctionMenu.IsWithParameter); //是否带参数
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.HyperLink))
 {
 if (objFunctionMenuEN.HyperLink !=  null)
 {
 var strHyperLink = objFunctionMenuEN.HyperLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHyperLink, conFunctionMenu.HyperLink); //超链接
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.HyperLink); //超链接
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.HyperLink4NoUser))
 {
 if (objFunctionMenuEN.HyperLink4NoUser !=  null)
 {
 var strHyperLink4NoUser = objFunctionMenuEN.HyperLink4NoUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHyperLink4NoUser, conFunctionMenu.HyperLink4NoUser); //超链接针对无用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.HyperLink4NoUser); //超链接针对无用户
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.SingleSignOnKey))
 {
 if (objFunctionMenuEN.SingleSignOnKey !=  null)
 {
 var strSingleSignOnKey = objFunctionMenuEN.SingleSignOnKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSingleSignOnKey, conFunctionMenu.SingleSignOnKey); //单点登录关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.SingleSignOnKey); //单点登录关键字
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.SchoolId))
 {
 if (objFunctionMenuEN.SchoolId !=  null)
 {
 var strSchoolId = objFunctionMenuEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolId, conFunctionMenu.SchoolId); //学校编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.SchoolId); //学校编号
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.UpdDate))
 {
 if (objFunctionMenuEN.UpdDate !=  null)
 {
 var strUpdDate = objFunctionMenuEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFunctionMenu.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.UpdDate); //修改日期
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.UpdUserId))
 {
 if (objFunctionMenuEN.UpdUserId !=  null)
 {
 var strUpdUserId = objFunctionMenuEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conFunctionMenu.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.UpdUserId); //修改用户Id
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.Memo))
 {
 if (objFunctionMenuEN.Memo !=  null)
 {
 var strMemo = objFunctionMenuEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFunctionMenu.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FunctionMenuId = '{0}'", objFunctionMenuEN.FunctionMenuId); 
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
 /// <param name = "objFunctionMenuEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFunctionMenuEN objFunctionMenuEN, string strCondition)
{
 objFunctionMenuEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionMenuEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionMenuEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FunctionMenu Set ");
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.FunctionName))
 {
 if (objFunctionMenuEN.FunctionName !=  null)
 {
 var strFunctionName = objFunctionMenuEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionName = '{0}',", strFunctionName); //函数名
 }
 else
 {
 sbSQL.Append(" FunctionName = null,"); //函数名
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.TitleName))
 {
 if (objFunctionMenuEN.TitleName !=  null)
 {
 var strTitleName = objFunctionMenuEN.TitleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TitleName = '{0}',", strTitleName); //功能菜单标题
 }
 else
 {
 sbSQL.Append(" TitleName = null,"); //功能菜单标题
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objFunctionMenuEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.DispPageMode))
 {
 if (objFunctionMenuEN.DispPageMode !=  null)
 {
 var strDispPageMode = objFunctionMenuEN.DispPageMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DispPageMode = '{0}',", strDispPageMode); //显示页面方式
 }
 else
 {
 sbSQL.Append(" DispPageMode = null,"); //显示页面方式
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.IsTransUserBySingleSignOn))
 {
 sbSQL.AppendFormat(" IsTransUserBySingleSignOn = '{0}',", objFunctionMenuEN.IsTransUserBySingleSignOn == true?"1":"0"); //是否单点登录传用户信息
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.IsWithParameter))
 {
 sbSQL.AppendFormat(" IsWithParameter = '{0}',", objFunctionMenuEN.IsWithParameter == true?"1":"0"); //是否带参数
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.HyperLink))
 {
 if (objFunctionMenuEN.HyperLink !=  null)
 {
 var strHyperLink = objFunctionMenuEN.HyperLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HyperLink = '{0}',", strHyperLink); //超链接
 }
 else
 {
 sbSQL.Append(" HyperLink = null,"); //超链接
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.HyperLink4NoUser))
 {
 if (objFunctionMenuEN.HyperLink4NoUser !=  null)
 {
 var strHyperLink4NoUser = objFunctionMenuEN.HyperLink4NoUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HyperLink4NoUser = '{0}',", strHyperLink4NoUser); //超链接针对无用户
 }
 else
 {
 sbSQL.Append(" HyperLink4NoUser = null,"); //超链接针对无用户
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.SingleSignOnKey))
 {
 if (objFunctionMenuEN.SingleSignOnKey !=  null)
 {
 var strSingleSignOnKey = objFunctionMenuEN.SingleSignOnKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SingleSignOnKey = '{0}',", strSingleSignOnKey); //单点登录关键字
 }
 else
 {
 sbSQL.Append(" SingleSignOnKey = null,"); //单点登录关键字
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.SchoolId))
 {
 if (objFunctionMenuEN.SchoolId !=  null)
 {
 var strSchoolId = objFunctionMenuEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolId = '{0}',", strSchoolId); //学校编号
 }
 else
 {
 sbSQL.Append(" SchoolId = null,"); //学校编号
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.UpdDate))
 {
 if (objFunctionMenuEN.UpdDate !=  null)
 {
 var strUpdDate = objFunctionMenuEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.UpdUserId))
 {
 if (objFunctionMenuEN.UpdUserId !=  null)
 {
 var strUpdUserId = objFunctionMenuEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.Memo))
 {
 if (objFunctionMenuEN.Memo !=  null)
 {
 var strMemo = objFunctionMenuEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFunctionMenuEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFunctionMenuEN objFunctionMenuEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFunctionMenuEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionMenuEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionMenuEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FunctionMenu Set ");
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.FunctionName))
 {
 if (objFunctionMenuEN.FunctionName !=  null)
 {
 var strFunctionName = objFunctionMenuEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionName = '{0}',", strFunctionName); //函数名
 }
 else
 {
 sbSQL.Append(" FunctionName = null,"); //函数名
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.TitleName))
 {
 if (objFunctionMenuEN.TitleName !=  null)
 {
 var strTitleName = objFunctionMenuEN.TitleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TitleName = '{0}',", strTitleName); //功能菜单标题
 }
 else
 {
 sbSQL.Append(" TitleName = null,"); //功能菜单标题
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objFunctionMenuEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.DispPageMode))
 {
 if (objFunctionMenuEN.DispPageMode !=  null)
 {
 var strDispPageMode = objFunctionMenuEN.DispPageMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DispPageMode = '{0}',", strDispPageMode); //显示页面方式
 }
 else
 {
 sbSQL.Append(" DispPageMode = null,"); //显示页面方式
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.IsTransUserBySingleSignOn))
 {
 sbSQL.AppendFormat(" IsTransUserBySingleSignOn = '{0}',", objFunctionMenuEN.IsTransUserBySingleSignOn == true?"1":"0"); //是否单点登录传用户信息
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.IsWithParameter))
 {
 sbSQL.AppendFormat(" IsWithParameter = '{0}',", objFunctionMenuEN.IsWithParameter == true?"1":"0"); //是否带参数
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.HyperLink))
 {
 if (objFunctionMenuEN.HyperLink !=  null)
 {
 var strHyperLink = objFunctionMenuEN.HyperLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HyperLink = '{0}',", strHyperLink); //超链接
 }
 else
 {
 sbSQL.Append(" HyperLink = null,"); //超链接
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.HyperLink4NoUser))
 {
 if (objFunctionMenuEN.HyperLink4NoUser !=  null)
 {
 var strHyperLink4NoUser = objFunctionMenuEN.HyperLink4NoUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HyperLink4NoUser = '{0}',", strHyperLink4NoUser); //超链接针对无用户
 }
 else
 {
 sbSQL.Append(" HyperLink4NoUser = null,"); //超链接针对无用户
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.SingleSignOnKey))
 {
 if (objFunctionMenuEN.SingleSignOnKey !=  null)
 {
 var strSingleSignOnKey = objFunctionMenuEN.SingleSignOnKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SingleSignOnKey = '{0}',", strSingleSignOnKey); //单点登录关键字
 }
 else
 {
 sbSQL.Append(" SingleSignOnKey = null,"); //单点登录关键字
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.SchoolId))
 {
 if (objFunctionMenuEN.SchoolId !=  null)
 {
 var strSchoolId = objFunctionMenuEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolId = '{0}',", strSchoolId); //学校编号
 }
 else
 {
 sbSQL.Append(" SchoolId = null,"); //学校编号
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.UpdDate))
 {
 if (objFunctionMenuEN.UpdDate !=  null)
 {
 var strUpdDate = objFunctionMenuEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.UpdUserId))
 {
 if (objFunctionMenuEN.UpdUserId !=  null)
 {
 var strUpdUserId = objFunctionMenuEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.Memo))
 {
 if (objFunctionMenuEN.Memo !=  null)
 {
 var strMemo = objFunctionMenuEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFunctionMenuEN objFunctionMenuEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFunctionMenuEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionMenuEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionMenuEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FunctionMenu Set ");
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.FunctionName))
 {
 if (objFunctionMenuEN.FunctionName !=  null)
 {
 var strFunctionName = objFunctionMenuEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionName, conFunctionMenu.FunctionName); //函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.FunctionName); //函数名
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.TitleName))
 {
 if (objFunctionMenuEN.TitleName !=  null)
 {
 var strTitleName = objFunctionMenuEN.TitleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTitleName, conFunctionMenu.TitleName); //功能菜单标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.TitleName); //功能菜单标题
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunctionMenuEN.IsVisible == true?"1":"0", conFunctionMenu.IsVisible); //是否显示
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.DispPageMode))
 {
 if (objFunctionMenuEN.DispPageMode !=  null)
 {
 var strDispPageMode = objFunctionMenuEN.DispPageMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDispPageMode, conFunctionMenu.DispPageMode); //显示页面方式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.DispPageMode); //显示页面方式
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.IsTransUserBySingleSignOn))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunctionMenuEN.IsTransUserBySingleSignOn == true?"1":"0", conFunctionMenu.IsTransUserBySingleSignOn); //是否单点登录传用户信息
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.IsWithParameter))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunctionMenuEN.IsWithParameter == true?"1":"0", conFunctionMenu.IsWithParameter); //是否带参数
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.HyperLink))
 {
 if (objFunctionMenuEN.HyperLink !=  null)
 {
 var strHyperLink = objFunctionMenuEN.HyperLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHyperLink, conFunctionMenu.HyperLink); //超链接
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.HyperLink); //超链接
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.HyperLink4NoUser))
 {
 if (objFunctionMenuEN.HyperLink4NoUser !=  null)
 {
 var strHyperLink4NoUser = objFunctionMenuEN.HyperLink4NoUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHyperLink4NoUser, conFunctionMenu.HyperLink4NoUser); //超链接针对无用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.HyperLink4NoUser); //超链接针对无用户
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.SingleSignOnKey))
 {
 if (objFunctionMenuEN.SingleSignOnKey !=  null)
 {
 var strSingleSignOnKey = objFunctionMenuEN.SingleSignOnKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSingleSignOnKey, conFunctionMenu.SingleSignOnKey); //单点登录关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.SingleSignOnKey); //单点登录关键字
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.SchoolId))
 {
 if (objFunctionMenuEN.SchoolId !=  null)
 {
 var strSchoolId = objFunctionMenuEN.SchoolId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolId, conFunctionMenu.SchoolId); //学校编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.SchoolId); //学校编号
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.UpdDate))
 {
 if (objFunctionMenuEN.UpdDate !=  null)
 {
 var strUpdDate = objFunctionMenuEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFunctionMenu.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.UpdDate); //修改日期
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.UpdUserId))
 {
 if (objFunctionMenuEN.UpdUserId !=  null)
 {
 var strUpdUserId = objFunctionMenuEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conFunctionMenu.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.UpdUserId); //修改用户Id
 }
 }
 
 if (objFunctionMenuEN.IsUpdated(conFunctionMenu.Memo))
 {
 if (objFunctionMenuEN.Memo !=  null)
 {
 var strMemo = objFunctionMenuEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFunctionMenu.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionMenu.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FunctionMenuId = '{0}'", objFunctionMenuEN.FunctionMenuId); 
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
 /// <param name = "strFunctionMenuId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFunctionMenuId) 
{
CheckPrimaryKey(strFunctionMenuId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFunctionMenuId,
};
 objSQL.ExecSP("FunctionMenu_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFunctionMenuId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFunctionMenuId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFunctionMenuId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
//删除FunctionMenu本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FunctionMenu where FunctionMenuId = " + "'"+ strFunctionMenuId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFunctionMenu(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
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
//删除FunctionMenu本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FunctionMenu where FunctionMenuId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFunctionMenuId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFunctionMenuId) 
{
CheckPrimaryKey(strFunctionMenuId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
//删除FunctionMenu本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FunctionMenu where FunctionMenuId = " + "'"+ strFunctionMenuId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFunctionMenu(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFunctionMenuDA: DelFunctionMenu)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FunctionMenu where " + strCondition ;
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
public bool DelFunctionMenuWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFunctionMenuDA: DelFunctionMenuWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FunctionMenu where " + strCondition ;
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
 /// <param name = "objFunctionMenuENS">源对象</param>
 /// <param name = "objFunctionMenuENT">目标对象</param>
public void CopyTo(clsFunctionMenuEN objFunctionMenuENS, clsFunctionMenuEN objFunctionMenuENT)
{
objFunctionMenuENT.FunctionMenuId = objFunctionMenuENS.FunctionMenuId; //功能菜单ID
objFunctionMenuENT.FunctionName = objFunctionMenuENS.FunctionName; //函数名
objFunctionMenuENT.TitleName = objFunctionMenuENS.TitleName; //功能菜单标题
objFunctionMenuENT.IsVisible = objFunctionMenuENS.IsVisible; //是否显示
objFunctionMenuENT.DispPageMode = objFunctionMenuENS.DispPageMode; //显示页面方式
objFunctionMenuENT.IsTransUserBySingleSignOn = objFunctionMenuENS.IsTransUserBySingleSignOn; //是否单点登录传用户信息
objFunctionMenuENT.IsWithParameter = objFunctionMenuENS.IsWithParameter; //是否带参数
objFunctionMenuENT.HyperLink = objFunctionMenuENS.HyperLink; //超链接
objFunctionMenuENT.HyperLink4NoUser = objFunctionMenuENS.HyperLink4NoUser; //超链接针对无用户
objFunctionMenuENT.SingleSignOnKey = objFunctionMenuENS.SingleSignOnKey; //单点登录关键字
objFunctionMenuENT.SchoolId = objFunctionMenuENS.SchoolId; //学校编号
objFunctionMenuENT.UpdDate = objFunctionMenuENS.UpdDate; //修改日期
objFunctionMenuENT.UpdUserId = objFunctionMenuENS.UpdUserId; //修改用户Id
objFunctionMenuENT.Memo = objFunctionMenuENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFunctionMenuEN objFunctionMenuEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFunctionMenuEN.SchoolId, conFunctionMenu.SchoolId);
//检查字段长度
clsCheckSql.CheckFieldLen(objFunctionMenuEN.FunctionMenuId, 4, conFunctionMenu.FunctionMenuId);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.FunctionName, 100, conFunctionMenu.FunctionName);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.TitleName, 200, conFunctionMenu.TitleName);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.DispPageMode, 50, conFunctionMenu.DispPageMode);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.HyperLink, 200, conFunctionMenu.HyperLink);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.HyperLink4NoUser, 200, conFunctionMenu.HyperLink4NoUser);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.SingleSignOnKey, 50, conFunctionMenu.SingleSignOnKey);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.SchoolId, 10, conFunctionMenu.SchoolId);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.UpdDate, 20, conFunctionMenu.UpdDate);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.UpdUserId, 20, conFunctionMenu.UpdUserId);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.Memo, 1000, conFunctionMenu.Memo);
//检查字段外键固定长度
 objFunctionMenuEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFunctionMenuEN objFunctionMenuEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFunctionMenuEN.FunctionName, 100, conFunctionMenu.FunctionName);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.TitleName, 200, conFunctionMenu.TitleName);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.DispPageMode, 50, conFunctionMenu.DispPageMode);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.HyperLink, 200, conFunctionMenu.HyperLink);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.HyperLink4NoUser, 200, conFunctionMenu.HyperLink4NoUser);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.SingleSignOnKey, 50, conFunctionMenu.SingleSignOnKey);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.SchoolId, 10, conFunctionMenu.SchoolId);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.UpdDate, 20, conFunctionMenu.UpdDate);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.UpdUserId, 20, conFunctionMenu.UpdUserId);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.Memo, 1000, conFunctionMenu.Memo);
//检查外键字段长度
 objFunctionMenuEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFunctionMenuEN objFunctionMenuEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFunctionMenuEN.FunctionMenuId, 4, conFunctionMenu.FunctionMenuId);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.FunctionName, 100, conFunctionMenu.FunctionName);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.TitleName, 200, conFunctionMenu.TitleName);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.DispPageMode, 50, conFunctionMenu.DispPageMode);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.HyperLink, 200, conFunctionMenu.HyperLink);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.HyperLink4NoUser, 200, conFunctionMenu.HyperLink4NoUser);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.SingleSignOnKey, 50, conFunctionMenu.SingleSignOnKey);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.SchoolId, 10, conFunctionMenu.SchoolId);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.UpdDate, 20, conFunctionMenu.UpdDate);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.UpdUserId, 20, conFunctionMenu.UpdUserId);
clsCheckSql.CheckFieldLen(objFunctionMenuEN.Memo, 1000, conFunctionMenu.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFunctionMenuEN.FunctionMenuId, conFunctionMenu.FunctionMenuId);
clsCheckSql.CheckSqlInjection4Field(objFunctionMenuEN.FunctionName, conFunctionMenu.FunctionName);
clsCheckSql.CheckSqlInjection4Field(objFunctionMenuEN.TitleName, conFunctionMenu.TitleName);
clsCheckSql.CheckSqlInjection4Field(objFunctionMenuEN.DispPageMode, conFunctionMenu.DispPageMode);
clsCheckSql.CheckSqlInjection4Field(objFunctionMenuEN.HyperLink, conFunctionMenu.HyperLink);
clsCheckSql.CheckSqlInjection4Field(objFunctionMenuEN.HyperLink4NoUser, conFunctionMenu.HyperLink4NoUser);
clsCheckSql.CheckSqlInjection4Field(objFunctionMenuEN.SingleSignOnKey, conFunctionMenu.SingleSignOnKey);
clsCheckSql.CheckSqlInjection4Field(objFunctionMenuEN.SchoolId, conFunctionMenu.SchoolId);
clsCheckSql.CheckSqlInjection4Field(objFunctionMenuEN.UpdDate, conFunctionMenu.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objFunctionMenuEN.UpdUserId, conFunctionMenu.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objFunctionMenuEN.Memo, conFunctionMenu.Memo);
//检查外键字段长度
 objFunctionMenuEN._IsCheckProperty = true;
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
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
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
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
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
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFunctionMenuEN._CurrTabName);
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
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFunctionMenuEN._CurrTabName, strCondition);
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
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
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
 objSQL = clsFunctionMenuDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}